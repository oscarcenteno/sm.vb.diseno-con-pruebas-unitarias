Namespace MuestraLasMetricasDeUnProyecto
    Public Class GeneracionDeMetricasDeLasIteraciones
        Public Shared Function GenereLasMetricasDeLasIteraciones(iteraciones As List(Of Iteracion)) As List(Of MetricasDeIteracion)
            Dim listaDeMetricas As New List(Of MetricasDeIteracion)

            For Each iteracion In iteraciones
                Dim metricasDeIteracion As MetricasDeIteracion
                metricasDeIteracion = GeneracionDeMetricasDeIteracion.GenereLasMetricasDeLaIteracion(iteracion)

                listaDeMetricas.Add(metricasDeIteracion)
            Next

            Return listaDeMetricas
        End Function
    End Class
End Namespace