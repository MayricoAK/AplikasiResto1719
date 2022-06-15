Public Class FormPenjualan
    Dim namaHari As String()
    Public Sub FormPenjualan_Load(sender As Object, e As EventArgs) Handles Me.Load

        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        lblTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & ", dd MMMM yyyy")

        'isi combo menu
        cbMenu.Items.Add("M0001-Kepiting Saod Padang-46000")
        cbMenu.Items.Add("M0004-Cumi Cah Brokoli-33000")
        cbMenu.Items.Add("M0008-Ikan Gurame Asam Manis-46000")
        cbMenu.Items.Add("M0011-Es Teh-3000")
        cbMenu.Items.Add("M0012-Es Jeruk-4000")


    End Sub

    Private Sub cbMenu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMenu.SelectedIndexChanged
        Dim arrMenu = Split(cbMenu.SelectedItem, "-")
        txtIDMenu.Text = arrMenu(0)
        txtNamaMenu.Text = arrMenu(1)
        txtHarga.Text = arrMenu(2)

    End Sub



End Class