Imports Discografica
Public NotInheritable Class Interprete
    Inherits Entidad
    Implements Regalias
    Private _porcentajeRegalias As Single

    Sub New()
        _porcentajeRegalias = Nothing
    End Sub

    Sub New(id As Integer, nombre As String, porcentajeregalias As Single)
        MyBase.New
        Me._porcentajeRegalias = porcentajeregalias
    End Sub

    Public Property PorcentajeRegalias As Single Implements Regalias.PorcentajeRegalias
        Get
            Return _porcentajeRegalias
        End Get
        Set(value As Single)
            _porcentajeRegalias = value
        End Set
    End Property

    Public Function TotalRegalias() As Single Implements Regalias.TotalRegalias
        Dim cancion As New Cancion
        Dim descarga As New Descarga
        Dim total As Single
        For Each interprete As Interprete In cancion.Interpretes
            If interprete.Nombre = Me.Nombre And descarga.Cancion.Nombre = cancion.Nombre Then
                total = (descarga.Monto * _porcentajeRegalias) / 100
            End If

        Next
        Return total
    End Function

    Public Overrides Function ToString() As String
        Return MyBase.ToString()

    End Function
End Class
