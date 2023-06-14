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

    Private Sub ReferenceTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReferenceTablesToolStripMenuItem.Click
        ReferenceTables.Show()
    End Sub

    Dim FilePath As String
    Dim Saved As Boolean

    Dim HasResult As Boolean
    Dim MixProportions(4) As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbExposure.SelectedIndex = 0
        cmbMSA.SelectedIndex = 0
        rdbAirEntrained.Checked = True
        rdbVolume.Checked = True

        txtStrength.Focus()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        If Not Saved Then
            Dim UserResponse As DialogResult = MessageBox.Show(
                "The file is currently not saved. Disregard changes and close the file?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question)
            If UserResponse = DialogResult.No Then e.Cancel = True
        End If
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        picGraph.Refresh()
        picBarChart.Refresh()
    End Sub

    Private Sub txt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
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

            Dim BulkVolumeOfCoarseAgg As Double
            BulkVolumeOfCoarseAgg = 23

            CoarseAggWeight = BulkVolumeOfCoarseAgg * CoarseAggUW * 27
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

            ' TODO: Create pie chart based on result
            Dim ExcelApp As New Excel.Application
            Dim WorkBook As Excel.Workbook

            ' TODO: Create visual graphics
            HasResult = True

            ReDim MixProportions(5)

            MixProportions(0) = CementVolume / 27
            MixProportions(1) = WaterVolume / 27
            MixProportions(2) = CoarseAggVolume / 27
            MixProportions(3) = FineAggVolume / 27
            MixProportions(4) = AirContent

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

        HasResult = False
        Array.Clear(MixProportions, 0, 5)
        picBarChart.Refresh()

        txtStrength.Focus()
    End Sub


    Private Sub picBarChart_Paint(sender As Object, e As PaintEventArgs) Handles picBarChart.Paint
        If HasResult Then
            ' TODO: If possible load texture files
            Dim ColorForCement As Brush = Brushes.AliceBlue
            Dim ColorForWater As Brush = Brushes.Wheat
            Dim ColorForAir As Brush = Brushes.Fuchsia
            Dim ColorForCoarseAgg As Brush = Brushes.Aqua
            Dim ColorForFineAgg As Brush = Brushes.AntiqueWhite

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

            e.Graphics.FillRectangle(ColorForCoarseAgg, X, Y, CSng(MixProportions(3) * Width), Height)
            X += MixProportions(3) * Width

            e.Graphics.FillRectangle(ColorForFineAgg, X, Y, CSng(MixProportions(4) * Width), Height)

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


End Class
