Public Class CLsEntKasir
    Private _idKasir As String
    Private _namaKasir As String
    Private _userID As String
    Private _pass As String
    Private _levelKasir As String

    Public Property idKasir As String
        Get
            Return _idKasir
        End Get
        Set(value As String)
            _idKasir = value
        End Set
    End Property

    Public Property namaKasir As String
        Get
            Return _namaKasir
        End Get
        Set(value As String)
            _namaKasir = value
        End Set
    End Property

    Public Property userID As String
        Get
            Return _userID
        End Get
        Set(value As String)
            _userID = value
        End Set
    End Property

    Public Property pass As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Property levelKasir As String
        Get
            Return _levelKasir
        End Get
        Set(value As String)
            _levelKasir = value
        End Set
    End Property
End Class
