Namespace MuestraLasMetricasDeUnProyecto
    Public Class GeneracionDelReporte
        Public Shared Function GenereElReporteDeMetricas(proyecto As Proyecto) As ReporteDeMetricas
            Dim reporte As New ReporteDeMetricas
            reporte.Nombre = proyecto.Nombre
            reporte.Metricas = GeneracionDeMetricasDeLasIteraciones.GenereLasMetricasDeLasIteraciones(proyecto.Iteraciones)

            Return reporte
        End Function
    End Class
End Namespace