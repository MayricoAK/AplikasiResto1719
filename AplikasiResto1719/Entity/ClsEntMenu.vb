Public Class CLsEntMenu
    Private _idMenu As String
    Private _idKategori As String
    Private _namaMenu As String
    Private _hargaMenu As Integer

    Public Property idMenu As String
        Get
            Return _idMenu
        End Get
        Set(value As String)
            _idMenu = value
        End Set
    End Property

    Public Property idKategori As String
        Get
            Return _idKategori
        End Get
        Set(value As String)
            _idKategori = value
        End Set
    End Property

    Public Property namaMenu As String
        Get
            Return _namaMenu
        End Get
        Set(value As String)
            _namaMenu = value
        End Set
    End Property

    Public Property hargaMenu As Integer
        Get
            Return _hargaMenu
        End Get
        Set(value As Integer)
            _hargaMenu = value
        End Set
    End Property
End Class
