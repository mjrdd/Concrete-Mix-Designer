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

    Dim SaveFilePath As String
    Dim Saved As Boolean = True

    Dim PieChartExportFilename As String

    Dim HasResult As Boolean
    Dim MixProportions(4) As Double

    Dim MousePosX, MousePosY As Integer
    Dim StrengthValueFromGraph As Double

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WaterContentForNonAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.WaterContentForNonAirEntrained)
        WaterContentForAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.WaterContentForAirEntrained)
        AirContentForNonAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.AirContentForNonAirEntrained)
        AirContentForAirEntrainedTableAdapter.Fill(AciDatabaseDataSet.AirContentForAirEntrained)
        WaterCementRatioTableAdapter.Fill(AciDatabaseDataSet.WaterCementRatio)
        BulkVolumeOfDRCATableAdapter.Fill(AciDatabaseDataSet.BulkVolumeOfDRCA)

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

    Private Sub Textboxes_TextChanged(sender As Object, e As EventArgs) Handles _
        txtStrength.TextChanged,
        txtSlump.TextChanged,
        txtCementSG.TextChanged,
        txtCAAC.TextChanged,
        txtCASG.TextChanged,
        txtCASM.TextChanged,
        txtCAUW.TextChanged,
        txtFAAC.TextChanged,
        txtFAFM.TextChanged,
        txtFASG.TextChanged,
        txtFASM.TextChanged

        Saved = False
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

            If PieChartExportFilename <> Nothing Then
                picPieChart.Image.Dispose()
                picBarChart.Image = Nothing
            End If

            Dim WaterContentTable,
                AirContentTable,
                WaterCementRatioTable,
                BulkVolumeDRCATable As DataTable

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

            For i = 0 To WaterCementRatioTable.Rows.Count - 1
                If WaterCementRatioTable.Rows.Item(i).Item(0) = Strength Then
                    WaterCementRatio = WaterCementRatioTable.Rows.Item(i).Item(If(rdbNonAirEntrained.Checked, 1, 2))
                    Exit For

                ElseIf WaterCementRatioTable.Rows.Item(i).Item(0) > Strength And
                    WaterCementRatioTable.Rows.Item(i + 1).Item(0) < Strength Then
                    WaterCementRatio = LinearInterpolate(
                        WaterCementRatioTable.Rows(i).Item(0),
                        WaterCementRatioTable.Rows(i).Item(If(rdbNonAirEntrained.Checked, 1, 2)),
                        WaterCementRatioTable.Rows(i + 1).Item(0),
                        WaterCementRatioTable.Rows(i + 1).Item(If(rdbNonAirEntrained.Checked, 1, 2)),
                        Strength
                    )
                    Exit For

                End If
            Next

            CementWeight = WaterWeight / WaterCementRatio

            BulkVolumeDRCATable = BulkVolumeOfDRCATableAdapter.GetData().CopyToDataTable()
            Dim BulkVolumeDRCA As Double

            Select Case FineAggFM
                Case Is < 2.4
                    BulkVolumeDRCA = LinearInterpolate(
                        2.4,
                        BulkVolumeDRCATable.Rows.Item(0).Item(MSAIndex + 1),
                        2.5,
                        BulkVolumeDRCATable.Rows.Item(1).Item(MSAIndex + 1),
                        FineAggFM
                    )

                Case Is > 3.0
                    BulkVolumeDRCA = LinearInterpolate(
                        2.9,
                        BulkVolumeDRCATable.Rows.Item(5).Item(MSAIndex + 1),
                        3.0,
                        BulkVolumeDRCATable.Rows.Item(6).Item(MSAIndex + 1),
                        FineAggFM
                    )

                Case Else
                    For i As Integer = 0 To BulkVolumeDRCATable.Rows.Count - 1
                        If BulkVolumeDRCATable.Rows.Item(i).Item(0) = FineAggFM Then
                            BulkVolumeDRCA = BulkVolumeDRCATable.Rows.Item(i).Item(MSAIndex + 1)
                            Exit For

                        ElseIf BulkVolumeDRCATable.Rows.Item(i).Item(0) < FineAggFM And
                            BulkVolumeDRCATable.Rows.Item(i + 1).Item(0) > FineAggFM Then
                            BulkVolumeDRCA = LinearInterpolate(
                                BulkVolumeDRCATable.Rows.Item(i).Item(0),
                                BulkVolumeDRCATable.Rows.Item(i).Item(MSAIndex + 1),
                                BulkVolumeDRCATable.Rows.Item(i + 1).Item(0),
                                BulkVolumeDRCATable.Rows.Item(i + 1).Item(MSAIndex + 1),
                                FineAggFM
                            )
                            Exit For

                        End If
                    Next

            End Select

            CoarseAggWeight = BulkVolumeDRCA * CoarseAggUW * 27
            CoarseAggWeight *= 1 + CoarseAggAC

            ' Compute for the volume
            WaterVolume = WaterWeight / 62.4
            CementVolume = CementWeight / (CementSG * 62.4)
            CoarseAggVolume = CoarseAggWeight / (CoarseAggSG * 62.4)
            AirVolume = AirContent * 0.01 * 27

            ' Compute for the total volume
            Dim TotalVolume As Double = WaterVolume + CementVolume + CoarseAggVolume + AirVolume

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
                    txtWaterOutput.Text = Math.Round(WaterVolume / 27, 3) * 100
                    txtCAOutput.Text = Math.Round(CoarseAggVolume / 27, 3) * 100
                    txtFAOutput.Text = Math.Round(FineAggVolume / 27, 3) * 100

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

            ReDim MixProportions(5)

            MixProportions(0) = CementVolume / 27
            MixProportions(1) = WaterVolume / 27
            MixProportions(2) = AirContent / 100
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



            Dim PieChartExportPathDir As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Concrete Mix Designer")
            If Not IO.Directory.Exists(PieChartExportPathDir) Then IO.Directory.CreateDirectory(PieChartExportPathDir)

            PieChartExportFilename = IO.Path.Combine(PieChartExportPathDir, "PieChart.gif")
            If IO.File.Exists(PieChartExportFilename) Then IO.File.Delete(PieChartExportFilename)

            Chart.Export(Filename:=PieChartExportFilename)
            picPieChart.SizeMode = PictureBoxSizeMode.Zoom
            picPieChart.Image = Image.FromFile(PieChartExportFilename)

            Workbook.Saved = True
            Chart = Nothing
            Sheet = Nothing
            Workbook = Nothing
            ExcelApp.Quit()

            HasResult = True
            picBarChart.Refresh()

        Catch ex As InvalidCastException
            MessageBox.Show("Invalid input values", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As OverflowException
            MessageBox.Show("Entered values are too large.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

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

        If PieChartExportFilename <> Nothing Then
            picPieChart.Image.Dispose()
            picBarChart.Image = Nothing
            IO.File.Delete(PieChartExportFilename)
        End If
        PieChartExportFilename = Nothing

        HasResult = False
        Array.Clear(MixProportions, 0, 5)
        picBarChart.Refresh()

        txtStrength.Focus()
    End Sub


    Private Sub picBarChart_Paint(sender As Object, e As PaintEventArgs) Handles picBarChart.Paint
        Try
            If HasResult Then
                Dim RootDir As String = IO.Directory.GetParent(IO.Path.GetDirectoryName(Application.StartupPath)).ToString

                Dim WaterTexture As Image = Image.FromFile(IO.Path.Combine(RootDir, "WaterTexture.png"))
                Dim WaterBrush As New TextureBrush(WaterTexture)
                WaterBrush.ScaleTransform(0.1, 0.1)
                WaterBrush.WrapMode = Drawing2D.WrapMode.Tile

                Dim CoarseAggTexture As Image = Image.FromFile(IO.Path.Combine(RootDir, "CoarseAggTexture.png"))
                Dim CoarseAggBrush As New TextureBrush(CoarseAggTexture)
                CoarseAggBrush.ScaleTransform(0.1, 0.1)
                CoarseAggBrush.WrapMode = Drawing2D.WrapMode.Tile

                Dim FineAggTexture As Image = Image.FromFile(IO.Path.Combine(RootDir, "FineAggTexture.png"))
                Dim FineAggBrush As New TextureBrush(FineAggTexture)
                FineAggBrush.ScaleTransform(0.1, 0.1)
                FineAggBrush.WrapMode = Drawing2D.WrapMode.Tile

                Dim CementBrush As Brush = Brushes.LightGray
                Dim AirBrush As Brush = Brushes.White

                Dim Padding As Single = 32.0
                Dim Height As Single = 40.0
                Dim Width As Single = picBarChart.Width - 2 * Padding

                Dim X, Y As Single
                X = Padding
                Y = Padding

                ' TODO: Convert to for next loop
                e.Graphics.FillRectangle(CementBrush, X, Y, CSng(MixProportions(0) * Width), Height)
                e.Graphics.DrawRectangle(Pens.Black, X, Y, CSng(MixProportions(0) * Width), Height)
                X += MixProportions(0) * Width

                e.Graphics.FillRectangle(WaterBrush, X, Y, CSng(MixProportions(1) * Width), Height)
                e.Graphics.DrawRectangle(Pens.Black, X, Y, CSng(MixProportions(1) * Width), Height)
                X += MixProportions(1) * Width

                e.Graphics.FillRectangle(AirBrush, X, Y, CSng(MixProportions(2) * Width), Height)
                e.Graphics.DrawRectangle(Pens.Black, X, Y, CSng(MixProportions(2) * Width), Height)
                X += MixProportions(2) * Width

                e.Graphics.FillRectangle(FineAggBrush, X, Y, CSng(MixProportions(3) * Width), Height)
                e.Graphics.DrawRectangle(Pens.Black, X, Y, CSng(MixProportions(3) * Width), Height)
                X += MixProportions(3) * Width

                e.Graphics.FillRectangle(CoarseAggBrush, X, Y, CSng(MixProportions(4) * Width), Height)
                e.Graphics.DrawRectangle(Pens.Black, X, Y, CSng(MixProportions(4) * Width), Height)

                ' TODO: Add legends
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Private Sub picGraph_Paint(sender As Object, e As PaintEventArgs) Handles picGraph.Paint
        Dim AxisOriginX, AxisOriginY, StepX, StepY As Integer
        AxisOriginX = 30
        AxisOriginY = picGraph.Height - 30

        Dim Width = picGraph.Width - 30
        Dim Height = picGraph.Height - 30
        StepX = Width / 10
        StepY = Height / 5

        With e.Graphics
            .DrawLine(Pens.DarkGray, 0, AxisOriginY, picGraph.Width, AxisOriginY)
            .DrawLine(Pens.DarkGray, AxisOriginX, 0, AxisOriginX, picGraph.Height)

            For i As Integer = AxisOriginX + StepX To AxisOriginX + Width Step StepX
                .DrawLine(Pens.Gray, i, AxisOriginY - 4, i, AxisOriginY + 4)
            Next

            For i As Integer = AxisOriginY - StepY To StepY - Height Step -StepY
                .DrawLine(Pens.Gray, AxisOriginX - 4, i, AxisOriginX + 4, i)
            Next

            For i As Integer = 0 To Width
                Dim DeltaY As Single = 17878 * Math.E ^ (-2.623 * i / Width)
                .DrawRectangle(Pens.Black, AxisOriginX + i, AxisOriginY - (DeltaY / 8000) * Height, 1, 1)
            Next

            Dim Ratio = (MousePosX - 30) / Width
            StrengthValueFromGraph = 17878 * Math.E ^ (-2.623 * Ratio)
            Dim PosY As Single = AxisOriginY - (StrengthValueFromGraph / 8000) * Height

            .DrawLine(Pens.Red, MousePosX, PosY, MousePosX, AxisOriginY)
            .DrawLine(Pens.Red, 30, PosY, MousePosX, PosY)

            Dim TextFont As New Font("Arial", 10, FontStyle.Regular)
            .DrawString(Math.Round(StrengthValueFromGraph) & " psi", TextFont, Brushes.Red, 35, PosY - 20)

            Dim TextFormat As New StringFormat With {
                .Alignment = StringAlignment.Center
            }

            .DrawString(Math.Round(Ratio, 2), TextFont, Brushes.Red, MousePosX, AxisOriginY + 10, TextFormat)
        End With
    End Sub

    Private Sub picGraph_MouseMove(sender As Object, e As MouseEventArgs) Handles picGraph.MouseMove
        MousePosX = e.X
        MousePosY = e.Y

        picGraph.Refresh()

    End Sub

    Private Sub picGraph_MouseUp(sender As Object, e As MouseEventArgs) Handles picGraph.MouseUp
        txtStrength.Text = Math.Round(StrengthValueFromGraph)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Creates a new window instance
        Dim NewForm As New MainForm
        NewForm.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If Not Saved Then
            Dim Result As DialogResult = MessageBox.Show(
                "There are changes that have not been saved. Would you like to save the session before proceeding?",
                "Unsaved Changes",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            )

            If Result = DialogResult.Yes Then
                SaveToolStripMenuItem.PerformClick()

            ElseIf Result = DialogResult.Cancel Then
                Exit Sub

            End If
        End If

        Try
            OpenFileDialog1.Filter = "Concrete Mix Designs (*.cmix)|*.cmix"
            OpenFileDialog1.FileName = "Concrete Mix Design.cmix"

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                SaveFilePath = OpenFileDialog1.FileName

                Dim DataArray = Split(My.Computer.FileSystem.ReadAllText(SaveFilePath), vbCrLf)
                Dim DataList As New Dictionary(Of String, String)

                For i As Integer = 0 To DataArray.Length - 1
                    Dim DataEntry = Split(DataArray(i), "=")
                    DataList.Add(DataEntry(0), DataEntry(1))
                Next

                txtStrength.Text = DataList("Strength")
                txtSlump.Text = DataList("Slump")
                cmbMSA.SelectedIndex = DataList("MSA")
                rdbAirEntrained.Checked = CInt(DataList("Entrainment")) = 2
                rdbNonAirEntrained.Checked = CInt(DataList("Entrainment")) = 1
                cmbExposure.SelectedIndex = DataList("Exposure")
                txtCementSG.Text = DataList("CementSG")
                txtCAAC.Text = DataList("CAAC")
                txtCASG.Text = DataList("CASG")
                txtCASM.Text = DataList("CASM")
                txtCAUW.Text = DataList("CAUW")
                txtFAAC.Text = DataList("FAAC")
                txtFAFM.Text = DataList("FAFM")
                txtFASG.Text = DataList("FASG")
                txtFASM.Text = DataList("FASM")

                btnCompute.PerformClick()
                Saved = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Function SerializeData() As String
        Return "Strength=" & Strength & vbCrLf &
            "Slump=" & Slump & vbCrLf &
            "MSA=" & MSAIndex & vbCrLf &
            "Entrainment=" & If(rdbNonAirEntrained.Checked, 1, 2) & vbCrLf &
            "Exposure=" & ExposureIndex & vbCrLf &
            "CementSG=" & CementSG & vbCrLf &
            "CAAC=" & CoarseAggAC & vbCrLf &
            "CASG=" & CoarseAggSG & vbCrLf &
            "CASM=" & CoarseAggSM & vbCrLf &
            "CAUW=" & CoarseAggUW & vbCrLf &
            "FAAC=" & FineAggAC & vbCrLf &
            "FAFM=" & FineAggFM & vbCrLf &
            "FASG=" & FineAggSG & vbCrLf &
            "FASM=" & FineAggSM

    End Function

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Try
            If SaveFilePath <> Nothing Then
                My.Computer.FileSystem.WriteAllText(SaveFilePath, SerializeData, False)
                Saved = True

            Else
                SaveAsToolStripMenuItem.PerformClick()

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            SaveFileDialog1.Filter = "Concrete Mix Designs (*.cmix)|*.cmix"
            SaveFileDialog1.FileName = "Concrete Mix Design.cmix"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                SaveFilePath = SaveFileDialog1.FileName
                My.Computer.FileSystem.WriteAllText(SaveFilePath, SerializeData, False)
                Saved = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub RandomizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RandomizeToolStripMenuItem.Click
        Dim Entrained = RandomNumber(0, 1)
        rdbAirEntrained.Checked = Entrained = 0
        rdbNonAirEntrained.Checked = Entrained = 1

        Select Case True
            Case rdbAirEntrained.Checked
                txtStrength.Text = RandomNumber(2000, 5000)
                cmbExposure.SelectedIndex = RandomNumber(0, 2)
            Case rdbNonAirEntrained.Checked
                txtStrength.Text = RandomNumber(2000, 6500)
        End Select
        cmbMSA.SelectedIndex = RandomNumber(0, 7)

        txtSlump.Text = RandomNumber(1.0, 7.0, 3)
        txtCementSG.Text = RandomNumber(3.0, 3.16, 3)
        txtCAAC.Text = RandomNumber(0.01, 0.1, 3)
        txtCASG.Text = RandomNumber(2.5, 3.0, 3)
        txtCASM.Text = RandomNumber(0.01, 0.1, 3)
        txtCAUW.Text = RandomNumber(75.0, 110.0, 3)
        txtFAAC.Text = RandomNumber(0.01, 0.1, 3)
        txtFAFM.Text = RandomNumber(2.0, 3.5, 3)
        txtFASG.Text = RandomNumber(2.5, 3.0, 3)
        txtFASM.Text = RandomNumber(0.01, 0.1, 3)
    End Sub

    Private Sub ReferenceTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenceTablesToolStripMenuItem.Click
        ReferenceTables.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.ShowDialog()
    End Sub

End Class
