Public Class FormLogin

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
		'deklarasi variabel
		Dim un As String
		un = "mayrico"
		Dim pass = "12345"

		'pengecekan text kosong utk semua textbox didalam form
		Dim ct As Control
		For Each ct In Me.Controls
			If TypeOf ct Is TextBox Then
				If ct.Text = vbNullString Then
					MsgBox("Kotak Isian Masih Kosong", MessageBoxIcon.Exclamation, "Peringatan")
					ct.Focus()
					Exit Sub
				End If
			End If
		Next ct

		'pengecekan user pwd
		If Not txtUsername.Text = un Then
			MsgBox("User tidak dikenal", MessageBoxIcon.Exclamation, "Peringatan")
			txtUsername.Focus()

		ElseIf Not txtPassword.Text = pass Then
			MsgBox("password salah", MessageBoxIcon.Warning, "Kesalahan")
			txtUsername.Focus()

		Else
			MsgBox("Selamat Datang", MessageBoxIcon.Information, "Informasi")
			FormPenjualan.Show()
			Me.Hide()
		End If
	End Sub

	Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
		Dim konfirm = MsgBox("Apakah Anda yakin akan keluar?", MessageBoxButtons.YesNo + MessageBoxIcon.Question, "Konfirmasi")
		If konfirm = vbYes Then
			End
		End If
	End Sub
End Class