Imports Discografica

Public Class Cancion
    Inherits Entidad
    Private _interpretes As List(Of Interprete)
    Private _discografica As Discografica
    Sub New()
        _interpretes = New List(Of Interprete)
        _discografica = New Discografica
    End Sub
    Sub New(id As Integer, nombre As String)
        MyBase.New()

    End Sub

    Public Sub AddInterprete(value As Interprete)
        _interpretes.Add(value)

    End Sub

    Public Function GetAllInterpretes() As List(Of Interprete)

        Return _interpretes
    End Function

    Public Sub RemoveInterprete(value As Interprete)
        _interpretes.Remove(value)
    End Sub


    Public Property Interpretes As List(Of Interprete)
        Get
            Return _interpretes
        End Get
        Set(value As List(Of Interprete))
            _interpretes = value
        End Set
    End Property


    Public Property Discografica As Discografica
        Get
            Return _discografica
        End Get
        Set(value As Discografica)
            _discografica = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ToString()
    End Function
End Class
