Imports System.Data.Odbc

Public Class CLsCtlMenu : Implements InfProsess

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsess.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProsess.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProsess.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function TampilData() As DataView Implements InfProsess.TampilData
        Try
            DTA = New OdbcDataAdapter("select * from menu", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Menu")
            Dim grid As New DataView(DTS.Tables("Tabel_Menu"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProsess.cariData
        Throw New NotImplementedException()
    End Function

    Function CekMenuDireferensi(kunci As String) As Boolean
        Dim cek As Boolean
        cek = False
        Try
            DTA = New OdbcDataAdapter("select count(id_Menu) from Detail_Jual " & " where id_menu = '" & kunci & "'", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "cek")
            If DTS.Tables("cek").Rows(0)(0).ToString > 0 Then cek = True
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Function
End Class
