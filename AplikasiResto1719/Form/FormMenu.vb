Public Class FormMenu
    Private Sub RefreshGrid()
        DTGrid = KontrolMenu.TampilData.ToTable
        DGMenu.DataSource = DTGrid
    End Sub

    Private Sub FormMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub
End Class