Public Class FormKasir
    Private Sub RefreshGrid()
        DTGrid = KontrolKasir.TampilData.ToTable
        DGKasir.DataSource = DTGrid
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class