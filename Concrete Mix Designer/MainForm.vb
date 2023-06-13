Imports System.ComponentModel

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
            txtCementOutput.Text = Math.Round(CementVolume, 3)
            txtWaterOutput.Text = Math.Round(WaterVolume, 3)
            txtCAOutput.Text = Math.Round(CoarseAggVolume, 3)
            txtFAOutput.Text = Math.Round(FineAggVolume, 3)

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

        txtStrength.Focus()
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

        cmbExposure.SelectedIndex = RandomValue(0, 2)
        cmbMSA.SelectedIndex = RandomValue(0, 7)

        Dim Entrained = RandomValue(0, 1)
        rdbAirEntrained.Checked = Entrained = 0
        rdbNonAirEntrained.Checked = Entrained = 1

        Select Case True
            Case rdbAirEntrained.Checked
                txtStrength.Text = RandomValue(2000, 5000)
            Case rdbNonAirEntrained.Checked
                txtStrength.Text = RandomValue(2000, 6500)
        End Select

        txtSlump.Text = RandomValue(1.0, 7.0)
        txtCementSG.Text = RandomValue(1.0, 3.0)
        txtCAAC.Text = RandomValue(0.01, 1.0)
        txtCASG.Text = RandomValue(1.0, 3.0)
        txtCASM.Text = RandomValue(0.01, 1.0)
        txtCAUW.Text = RandomValue(1.0, 5.0)
        txtFAAC.Text = RandomValue(0.01, 1.0)
        txtFAFM.Text = RandomValue(2.4, 3.0)
        txtFASG.Text = RandomValue(1.0, 3.0)
        txtFASM.Text = RandomValue(0.01, 1.0)
    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        ' Creates a new window instance
        Dim NewForm As New MainForm
        NewForm.Show()
    End Sub
End Class
