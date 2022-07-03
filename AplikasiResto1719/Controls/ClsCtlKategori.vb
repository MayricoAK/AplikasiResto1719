Imports System.Data.Odbc
Public Class CLsCtlKategori : Implements InfProsess
    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsess.InsertData
        Dim data As New CLsEntKategori
        data = Ob
        CMD = New OdbcCommand("insert into kategori values('" & data.IdKategori & "','" & data.NamaKategori & "')", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProsess.updateData
        Dim data As New CLsEntKategori
        data = Ob
        CMD = New OdbcCommand("update kategori set nama_kategori = '" & data.NamaKategori & "' where id_kategori='" & data.IdKategori & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProsess.deleteData
        Dim data As New CLsEntKategori
        CMD = New OdbcCommand("delete from kategori " & "where id_kategori= '" & kunci & "'", BUKAKONEKSI)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", TUTUPKONEKSI)
        Return CMD
    End Function

    Function kodebaru() As String
        Dim baru As String
        Dim kodeakhir As Integer
        Try
            DTA = New OdbcDataAdapter("select max(right(id_kategori,3)) from kategori", BUKAKONEKSI)
            DTS = New DataSet()
            DTA.Fill(DTS, "max_kode")
            kodeakhir = Val(DTS.Tables("max_kode").Rows(0).Item(0))
            baru = "KT" & Strings.Right("00" & kodeakhir + 1, 3)
            Return baru
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function TampilData() As DataView Implements InfProsess.TampilData
        Try
            DTA = New OdbcDataAdapter("select * from kategori", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kategori")
            Dim grid As New DataView(DTS.Tables("Tabel_Kategori"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProsess.cariData
        Try
            DTA = New OdbcDataAdapter("select * from kategori where nama_kategori " & " like '%" & kunci & "%'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_kategori")
            Dim grid As New DataView(DTS.Tables("Cari_kategori"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Function CekKategoriDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New Odbc.OdbcDataAdapter("Select count(idKategori) from kategori " & " where idKategori = '" & kunci & "'", BUKAKONEKSI)
        Catch ex As Exception

        End Try
    End Function
End Class
