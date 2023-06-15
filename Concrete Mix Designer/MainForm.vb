Imports System.ComponentModel
Imports Excel = Microsoft.Office.Interop.Excel

Public Class MainForm
    Dim ExposureIndex,
        MSAIndex As Integer

    Dim Strength,
        Slump,
        WaterCementRatio,
        AirContent As Double

    Dim CementSG,
        CoarseAggAC,
        CoarseAggSG,
        CoarseAggSM,
        CoarseAggUW,
        FineAggAC,
        FineAggFM,
        FineAggSG,
        FineAggSM As Double

    Dim WaterWeight,
        WaterVolume,
        CementWeight,
        CementVolume,
        CoarseAggWeight,
        CoarseAggVolume,
        FineAggWeight,
        FineAggVolume,
        AirVolume As Double

    Dim FilePath As String
    Dim Saved As Boolean

    Dim PieChartExportFilename As String

    Dim HasResult As Boolean
    Dim MixProportions(4) As Double

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WaterContentForNonAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.WaterContentForNonAirEntrained)
        WaterContentForAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.WaterContentForAirEntrained)
        AirContentForNonAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.AirContentForNonAirEntrained)
        AirContentForAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.AirContentForAirEntrained)
        WaterCementRatioTableAdapter.Fill(AciDatabaseDataSet.WaterCementRatio)

        rdbAirEntrained.Checked = True
        cmbMSA.SelectedIndex = 0
        cmbExposure.SelectedIndex = 0

        txtStrength.Focus()

        rdbVolume.Checked = True
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        ' Ask user to confirm exit when the data in the current window is not saved
        If Not Saved Then
            Dim UserResponse As DialogResult = MessageBox.Show(
                "The file is currently not saved. Disregard changes and close the file?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If UserResponse = DialogResult.No Then e.Cancel = True
        End If
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        picGraph.Refresh()
        picBarChart.Refresh()
    End Sub

    Private Sub Textboxes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        txtStrength.KeyPress,
        txtSlump.KeyPress,
        txtCementSG.KeyPress,
        txtCAAC.KeyPress,
        txtCASG.KeyPress,
        txtCASM.KeyPress,
        txtCAUW.KeyPress,
        txtFAAC.KeyPress,
        txtFAFM.KeyPress,
        txtFASG.KeyPress,
        txtFASM.KeyPress

        ' Prevent user from entering non-numeric values in input textboxes
        Dim KeyCode As Integer = AscW(e.KeyChar)

        If Not (
            KeyCode = 8 OrElse
            KeyCode > 47 And KeyCode < 58 OrElse
            KeyCode = 46 And (
                Not sender.Text.Contains(".") OrElse
                sender.SelectedText.Contains(".")) OrElse
            KeyCode = 45 And (
                sender.Text = "" OrElse
                sender.SelectedText.Contains("-") OrElse
                sender.SelectionStart = 0)
        ) Then
            e.KeyChar = Nothing
        End If
    End Sub

    Private Sub AirEntrainment_CheckedChanged(sender As Object, e As EventArgs) Handles _
        rdbAirEntrained.CheckedChanged,
        rdbNonAirEntrained.CheckedChanged

        ' Prevent the event handler trigger multiple times
        If sender.Checked Then
            lblExposure.Visible = rdbAirEntrained.Checked
            cmbExposure.Visible = rdbAirEntrained.Checked
            cmbExposure.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Try
            ExposureIndex = cmbExposure.SelectedIndex
            MSAIndex = cmbMSA.SelectedIndex
            Strength = txtStrength.Text
            Slump = txtSlump.Text

            CementSG = txtCementSG.Text
            CoarseAggAC = txtCAAC.Text
            CoarseAggSG = txtCASG.Text
            CoarseAggSM = txtCASM.Text
            CoarseAggUW = txtCAUW.Text
            FineAggAC = txtFAAC.Text
            FineAggFM = txtFAFM.Text
            FineAggSG = txtFASG.Text
            FineAggSM = txtFASM.Text

            Dim WaterContentTable,
                AirContentTable,
                WaterCementRatioTable As DataTable

            Dim SlumpRowIndex As Integer
            Select Case Slump
                Case 1.0 To 2.0
                    SlumpRowIndex = 0
                Case 2.0 To 5.0
                    SlumpRowIndex = 1
                Case 6.0 To 7.0
                    SlumpRowIndex = 2
                Case Else
                    Exit Sub
            End Select

            Select Case True
                Case rdbAirEntrained.Checked
                    WaterContentTable = WaterContentForAirEntrainedTableAdapter.GetData().CopyToDataTable()
                    AirContentTable = AirContentForAirEntrainedTableAdapter.GetData().CopyToDataTable()

                    WaterWeight = WaterContentTable.Rows.Item(SlumpRowIndex).Item(MSAIndex + 1)
                    AirContent = AirContentTable.Rows.Item(ExposureIndex).Item(MSAIndex + 1)

                Case rdbNonAirEntrained.Checked
                    WaterContentTable = WaterContentForNonAirEntrainedTableAdapter.GetData().CopyToDataTable()
                    AirContentTable = AirContentForNonAirEntrainedTableAdapter.GetData().CopyToDataTable()

                    WaterWeight = WaterContentTable.Rows.Item(SlumpRowIndex).Item(MSAIndex + 1)
                    AirContent = AirContentTable.Rows.Item(0).Item(MSAIndex + 1)
            End Select

            WaterCementRatioTable = WaterCementRatioTableAdapter.GetData().CopyToDataTable()

            ' TODO: Interpolate data
            Dim RowIndex As Integer
            For RowIndex = 0 To WaterCementRatioTable.Rows.Count - 1
                If WaterCementRatioTable.Rows.Item(RowIndex).Item(0) = Strength Then
                    Exit For

                ElseIf WaterCementRatioTable.Rows.Item(RowIndex).Item(0) < Strength And
                    WaterCementRatioTable.Rows.Item(RowIndex + 1).Item(0) > Strength Then
                    Exit For
                End If
            Next

            WaterCementRatio = WaterCementRatioTable.Rows.Item(RowIndex).Item(If(rdbNonAirEntrained.Checked, 1, 2))
            CementWeight = WaterWeight / WaterCementRatio


            CoarseAggWeight = 0.63 * CoarseAggUW * 27
            CoarseAggWeight *= 1 + CoarseAggAC

            ' Compute for the volume
            WaterVolume = WaterWeight / 62.4
            CementVolume = CementWeight / (CementSG * 62.4)
            CoarseAggVolume = CoarseAggWeight / (CoarseAggSG * 62.4)

            ' Compute for the total volume
            Dim TotalVolume As Double = WaterVolume + CementVolume + CoarseAggVolume

            ' Compute for the volume of fine aggregates
            FineAggVolume = 27 - TotalVolume

            ' Fine Aggregates Content
            FineAggWeight = FineAggVolume * FineAggSG * 62.4

            ' Increase amount of aggregates by the amount equal to surface moisture
            Dim AdjustedFineAggWeight As Double = FineAggWeight * (1 + FineAggSM)
            Dim AdjustedCoarseAggWeight As Double = CoarseAggWeight * (1 + CoarseAggSM)

            ' Decrease water content by surface moisture
            Dim DeltaWaterWeight = FineAggWeight * FineAggSM + CoarseAggWeight * CoarseAggSM

            ' Required mixing water
            Dim RequiredWater As Double = WaterWeight - DeltaWaterWeight

            ' TODO: Display the output based on user selected: volume or weight (or percentages)
            Select Case True
                Case rdbVolume.Checked
                    txtCementOutput.Text = Math.Round(CementVolume, 3)
                    txtWaterOutput.Text = Math.Round(WaterVolume, 3)
                    txtCAOutput.Text = Math.Round(CoarseAggVolume, 3)
                    txtFAOutput.Text = Math.Round(FineAggVolume, 3)

                Case rdbVolumePercent.Checked
                    txtCementOutput.Text = Math.Round(CementVolume / 27, 3) * 100
                    txtWaterOutput.Text = Math.Round(WaterVolume / 27, 3)
                    txtCAOutput.Text = Math.Round(CoarseAggVolume / 27, 3)
                    txtFAOutput.Text = Math.Round(FineAggVolume / 27, 3)

                Case rdbWeight.Checked
                    txtCementOutput.Text = Math.Round(CementWeight, 3)
                    txtWaterOutput.Text = Math.Round(WaterWeight, 3)
                    txtCAOutput.Text = Math.Round(CoarseAggWeight, 3)
                    txtFAOutput.Text = Math.Round(FineAggWeight, 3)

                Case rdbWeightPercent.Checked
                    Dim TotalWeight = CementWeight + WaterWeight + CoarseAggWeight + FineAggWeight

                    txtCementOutput.Text = Math.Round(CementWeight / TotalWeight, 3)
                    txtWaterOutput.Text = Math.Round(WaterWeight / TotalWeight, 3)
                    txtCAOutput.Text = Math.Round(CoarseAggWeight / TotalWeight, 3)
                    txtFAOutput.Text = Math.Round(FineAggWeight / TotalWeight, 3)

            End Select



        Catch ex As InvalidCastException
            MessageBox.Show("Invalid input values", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Catch ex As OverflowException
            MessageBox.Show("Entered values are too large.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

        Try
            ReDim MixProportions(5)

            MixProportions(0) = CementVolume / 27
            MixProportions(1) = WaterVolume / 27
            MixProportions(2) = AirContent
            MixProportions(3) = FineAggVolume / 27
            MixProportions(4) = CoarseAggVolume / 27

            ' TODO: Create pie chart based on result
            Dim ExcelApp As New Excel.Application
            Dim Workbook = ExcelApp.Workbooks.Add
            Dim Sheet As Excel.Worksheet = Workbook.Sheets("Sheet1")
            Dim Chart As Excel.Chart = Workbook.Charts.Add

            With Sheet
                .Range("A1").Value = "Concrete Components"
                .Range("A2").Value = "Cement"
                .Range("A3").Value = "Water"
                .Range("A4").Value = "Air"
                .Range("A5").Value = "Fine Aggregates"
                .Range("A6").Value = "Coarse Aggregates"
                .Range("B1").Value = "Mix Proportions"

                For Row As Integer = 2 To 6
                    .Cells(Row, 2).Value = MixProportions(Row - 2)
                Next
            End With

            With Chart
                .ApplyCustomType(Excel.XlChartType.xlPie)
                .SetSourceData(Source:=Sheet.Range("A2:B6"))
                .HasLegend = True
                .HasTitle = True
                .ChartTitle.Text = "Concrete Mix Proportions"
            End With

            If PieChartExportFilename <> Nothing Then
                picPieChart.Image.Dispose()
                picBarChart.Image = Nothing
            End If

            Dim PieChartExportPathDir As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Concrete Mix Designer")

            If Not IO.Directory.Exists(PieChartExportPathDir) Then
                IO.Directory.CreateDirectory(PieChartExportPathDir)
            End If

            PieChartExportFilename = IO.Path.Combine(PieChartExportPathDir, "PieChart.gif")

            If IO.File.Exists(PieChartExportFilename) Then
                IO.File.Delete(PieChartExportFilename)
            End If

            Chart.Export(Filename:=PieChartExportFilename)
            picPieChart.SizeMode = PictureBoxSizeMode.Zoom
            picPieChart.Image = Image.FromFile(PieChartExportFilename)

            Workbook.Saved = True
            Chart = Nothing
            Sheet = Nothing
            Workbook = Nothing
            ExcelApp.Quit()

            ' TODO: Create visual graphics
            HasResult = True
            picBarChart.Refresh()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtStrength.Clear()
        txtSlump.Clear()
        txtCementSG.Clear()
        txtCAAC.Clear()
        txtCASG.Clear()
        txtCASM.Clear()
        txtCAUW.Clear()
        txtFAAC.Clear()
        txtFAFM.Clear()
        txtFASG.Clear()
        txtFASM.Clear()
        txtCementOutput.Clear()
        txtWaterOutput.Clear()
        txtCAOutput.Clear()
        txtFAOutput.Clear()

        cmbExposure.SelectedIndex = 0
        cmbMSA.SelectedIndex = 0
        rdbAirEntrained.Checked = True

        HasResult = False
        Array.Clear(MixProportions, 0, 5)
        picBarChart.Refresh()

        txtStrength.Focus()
    End Sub


    Private Sub picBarChart_Paint(sender As Object, e As PaintEventArgs) Handles picBarChart.Paint
        If HasResult Then
            ' TODO: If possible load texture files
            Dim ColorForCement As Brush = Brushes.Gray
            Dim ColorForWater As Brush = Brushes.LightBlue
            Dim ColorForAir As Brush = Brushes.White
            Dim ColorForCoarseAgg As Brush = Brushes.PeachPuff
            Dim ColorForFineAgg As Brush = Brushes.SandyBrown

            Dim Padding As Single = 32.0
            Dim Height As Single = 40.0
            Dim Width As Single = picBarChart.Width - 2 * Padding

            Dim X, Y As Single
            X = Padding
            Y = picBarChart.Height / 2 - Height / 2

            ' TODO: Convert to for next loop
            e.Graphics.FillRectangle(ColorForCement, X, Y, CSng(MixProportions(0) * Width), Height)
            X += MixProportions(0) * Width

            e.Graphics.FillRectangle(ColorForWater, X, Y, CSng(MixProportions(1) * Width), Height)
            X += MixProportions(1) * Width

            e.Graphics.FillRectangle(ColorForAir, X, Y, CSng(MixProportions(2) * Width), Height)
            X += MixProportions(2) * Width

            e.Graphics.FillRectangle(ColorForFineAgg, X, Y, CSng(MixProportions(3) * Width), Height)
            X += MixProportions(3) * Width

            e.Graphics.FillRectangle(ColorForCoarseAgg, X, Y, CSng(MixProportions(4) * Width), Height)

            ' TODO: Add legends
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub RadomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RadomizeToolStripMenuItem.Click
        ' Randomize input values
        ' TODO: Recheck minimum and maximum values

        cmbExposure.SelectedIndex = Rand(0, 2)
        cmbMSA.SelectedIndex = Rand(0, 7)

        Dim Entrained = Rand(0, 1)
        rdbAirEntrained.Checked = Entrained = 0
        rdbNonAirEntrained.Checked = Entrained = 1

        Select Case True
            Case rdbAirEntrained.Checked
                txtStrength.Text = Rand(2000, 5000)
            Case rdbNonAirEntrained.Checked
                txtStrength.Text = Rand(2000, 6500)
        End Select

        txtSlump.Text = Rand(1.0, 7.0)
        txtCementSG.Text = Rand(1.0, 3.0)
        txtCAAC.Text = Rand(0.01, 1.0)
        txtCASG.Text = Rand(1.0, 3.0)
        txtCASM.Text = Rand(0.01, 1.0)
        txtCAUW.Text = Rand(1.0, 5.0)
        txtFAAC.Text = Rand(0.01, 1.0)
        txtFAFM.Text = Rand(2.4, 3.0)
        txtFASG.Text = Rand(1.0, 3.0)
        txtFASM.Text = Rand(0.01, 1.0)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Creates a new window instance
        Dim NewForm As New MainForm
        NewForm.Show()
    End Sub

    Private Sub ReferenceTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenceTablesToolStripMenuItem.Click
        ReferenceTables.Show()
    End Sub
End Class
