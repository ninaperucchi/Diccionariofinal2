Imports Discografica
Public Class Descarga
    Private _fecha As Date
    Private _monto As Single
    Private _cancion As Cancion

    Sub New()
        _fecha = Nothing
        _monto = Nothing
        _cancion = New Cancion

    End Sub

    Sub New(cancion As Cancion, fecha As Date, monto As Single)
        _fecha = fecha
        _monto = monto
        _cancion = cancion

    End Sub

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Property Monto As Single
        Get
            Return _monto
        End Get
        Set(value As Single)
            _monto = value

        End Set
    End Property

    Public Property Cancion As Cancion
        Get
            Return _cancion
        End Get
        Set(value As Cancion)
            _cancion = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function

End Class
