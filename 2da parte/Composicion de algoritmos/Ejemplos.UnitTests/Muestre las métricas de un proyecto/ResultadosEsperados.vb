Public Class ResultadosEsperados
    Public Shared Function ObtengaLaListaDeMetricas() As List(Of MetricasDeIteracion)
        Dim lista As New List(Of MetricasDeIteracion)
        lista.Add(CreeMetricas(1, New Date(2017, 10, 16), New Date(2017, 10, 20), "80%", "5%"))
        lista.Add(CreeMetricas(2, New Date(2017, 10, 23), New Date(2017, 10, 27), "No hay datos", "29%"))
        lista.Add(CreeMetricas(3, New Date(2017, 10, 30), New Date(2017, 11, 3), "No hay datos", "No hay datos"))

        Return lista
    End Function

    Private Shared Function CreeMetricas(iteracion As Integer, fechaInicial As Date, fechaFinal As Date, metricaDePuntos As String, metricaDeTiempoNoEfectivo As String) As MetricasDeIteracion
        Return New MetricasDeIteracion With {
            .Iteracion = iteracion,
            .FechaInicial = fechaInicial,
            .FechaFinal = fechaFinal,
            .MetricaDePuntos = metricaDePuntos,
            .MetricaDeTiempoNoEfectivo = metricaDeTiempoNoEfectivo
        }
    End Function

End Class
