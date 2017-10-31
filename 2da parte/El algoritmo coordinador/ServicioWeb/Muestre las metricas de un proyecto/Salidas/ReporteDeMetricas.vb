Namespace MuestraLasMetricasDeUnProyecto
    Public Class ReporteDeMetricas
        Public Property Nombre As String
        Public Property Metricas As List(Of MetricasDeIteracion)

        Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
            Dim otroReporte As ReporteDeMetricas = CType(otherObject, ReporteDeMetricas)

            Return Equals(otroReporte)
        End Function

        Public Overloads Function Equals(otroReporte As ReporteDeMetricas) As Boolean
            Return Nombre = otroReporte.Nombre And Metricas.SequenceEqual(otroReporte.Metricas)
        End Function
    End Class
End Namespace