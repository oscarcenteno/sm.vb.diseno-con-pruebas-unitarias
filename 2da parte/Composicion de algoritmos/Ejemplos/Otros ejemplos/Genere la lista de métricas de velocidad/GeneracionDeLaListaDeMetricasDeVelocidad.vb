Public Class GeneracionDeLaListaDeMetricasDeVelocidad
    Public Shared Function GenereLaListaDeMetricasDeVelocidad(historias As List(Of Historia), iteraciones As List(Of Integer)) As Integer()
        Dim velocidades As New List(Of Integer)

        For Each iteracion In iteraciones
            Dim velocidad = CalculoDeVelocidad.CalculeLaVelocidad(historias, iteracion)
            velocidades.Add(velocidad)
        Next

        Return velocidades.ToArray
    End Function
End Class