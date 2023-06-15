Public Class ReferenceTables
    Private Sub ReferenceTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WaterContentForNonAirEntrainedTableAdapter.Fill(ACIDatabaseDataSet.WaterContentForNonAirEntrained)
        WaterContentForAirEntrainedTableAdapter.Fill(ACIDatabaseDataSet.WaterContentForAirEntrained)
        AirContentForNonAirEntrainedTableAdapter.Fill(ACIDatabaseDataSet.AirContentForNonAirEntrained)
        AirContentForAirEntrainedTableAdapter.Fill(ACIDatabaseDataSet.AirContentForAirEntrained)
        WaterCementRatioTableAdapter.Fill(ACIDatabaseDataSet.WaterCementRatio)
        BulkVolumeOfDRCATableAdapter.Fill(ACIDatabaseDataSet.BulkVolumeOfDRCA)
    End Sub

End Class