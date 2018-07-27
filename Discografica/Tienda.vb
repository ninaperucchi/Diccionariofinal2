Public Class Tienda
    Private Shared _valorDescarga As Single
    Private descargas As List(Of Descarga)

    Sub New()
        _valorDescarga = Nothing

    End Sub

    Public Sub AddDescarga(value As Descarga)
        descargas.Add(value)
    End Sub

    Public Function GetAllDescargas() As List(Of Descarga)
        Return descargas
    End Function



    Public Function GetDescargaByDiscografica(value As Discografica) As List(Of Descarga)

        Dim lista2 As New List(Of Descarga)
        For Each descarga As Descarga In descargas
            If descarga.Cancion.Discografica.Id = value.Id Then
                lista2.Add(descarga)
            End If

        Next

        Return lista2


    End Function



    Public Function GetDescargaByfecha(value As Date) As List(Of Descarga)
        Dim lista As New List(Of Descarga)
        For Each getdescargas As Descarga In descargas
            If getdescargas.Fecha = value Then
                lista.Add(getdescargas)
            End If
        Next
        Return lista
    End Function



    Public Function GetDescargaByInterprete(value As Interprete) As List(Of Descarga)
        Dim lista As New List(Of Descarga)
        For Each descarga As Descarga In descargas
            For Each interprete As Interprete In descarga.Cancion.Interpretes
                If interprete.Id = value.Id Then
                    lista.Add(descarga)
                End If

            Next

        Next

        Return lista
    End Function


    'thingverse
End Class
