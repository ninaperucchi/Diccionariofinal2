Imports Discografica

Public Class Discografica
    Inherits Entidad
    Implements Regalias

    Private _porcentajeRegalias As Single


    Sub New()
        _porcentajeRegalias = Nothing
    End Sub

    Sub New(id As Integer, nombre As String, PorcentajeRegalias As Single)
        MyBase.New(id, nombre)
        Me._porcentajeRegalias = PorcentajeRegalias

    End Sub

    Public Property PorcentajeRegalias As Single Implements Regalias.PorcentajeRegalias
        Get
            Return _porcentajeRegalias
        End Get
        Set(value As Single)
            _porcentajeRegalias = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()

    End Function

    Public Function TotalRegalias() As Single Implements Regalias.TotalRegalias
        Dim cancion As New Cancion
        Dim descarga As New Descarga
        Dim total As Single
        If descarga.Cancion.Nombre = cancion.Nombre And cancion.Discografica.Nombre = Nombre Then
            total = (descarga.Monto * _porcentajeRegalias) / 100
        End If
        Return total
    End Function



End Class





'triangulo abierto es herencia
'cuando la linea tiene el 1 del lado significa que tiene una lista de lo que sigue ne la flecha y la ounta de la flecha tiene una propiedad del otro que tiene el numero
