Imports Discografica
Public MustInherit Class Entidad
    Private _ID As Integer
    Private _nombre As String

    Sub New()
        _ID = Nothing
        _nombre = ""

    End Sub

    Sub New(id As Integer, nombre As String)
        Me._ID = id
        Me._nombre = nombre
    End Sub

    Public Property Id As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre

        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

End Class
