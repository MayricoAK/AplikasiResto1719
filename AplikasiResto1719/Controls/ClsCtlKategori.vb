Imports System.Data.Odbc
Public Class CLsCtlKategori : Implements InfProsess
    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProsess.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProsess.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(kunci As String) As OdbcCommand Implements InfProsess.deleteData
        Throw New NotImplementedException()
    End Function

    Function kodebaru() As String
        Throw New NotImplementedException()
    End Function

    Public Function TampilData() As DataView Implements InfProsess.TampilData
        Try
            DTA = New OdbcDataAdapter("select * fromkategori", BUKAKONEKSI)

            DTS = New DataSet()
            DTA.Fill(DTS, "Tabel_Kategori")
            Dim grid As New DataView(DTS.Tables("Tabel_Kategori"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProsess.cariData
        Throw New NotImplementedException()
    End Function
End Class
