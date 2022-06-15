Public Class CLsEntKategori
    Private _idKategori As String
    Private _namaKategori As String

    Public Property idKategori As String
        Get
            Return _idKategori
        End Get
        Set(value As String)
            _idKategori = value
        End Set
    End Property

    Public Property namaKategori As String
        Get
            Return _namaKategori
        End Get
        Set(value As String)
            _namaKategori = value
        End Set
    End Property
End Class
