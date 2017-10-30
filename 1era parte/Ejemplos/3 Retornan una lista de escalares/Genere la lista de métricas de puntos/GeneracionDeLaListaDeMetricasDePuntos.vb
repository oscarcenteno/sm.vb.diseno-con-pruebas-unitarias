Public Class GeneracionDeLaListaDeMetricasDePuntos

    Public Shared Function GenereLaListaDeMetricasDePuntos(iteraciones As List(Of Iteracion)) As String()
        Dim metricas As New List(Of String)

        For Each iteracion In iteraciones
            Dim metrica As String = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(iteracion)
            metricas.Add(metrica)
        Next

        Return metricas.ToArray
    End Function
End Class