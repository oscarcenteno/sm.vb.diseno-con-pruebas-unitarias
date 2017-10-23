Public Class GeneracionDeMetricasDeIteracion
    Public Shared Function GenereLasMetricasDeLaIteracion(iteracion As Iteracion) As MetricasDeIteracion
        Dim metricas As New MetricasDeIteracion

        metricas.Iteracion = iteracion.Numero
        metricas.FechaInicial = iteracion.FechaInicial
        metricas.FechaFinal = iteracion.FechaFinal
        metricas.MetricaDePuntos = CalculoDeLaMetricaDePuntosModificada.CalculeLaMetricaDePuntos(iteracion)
        metricas.MetricaDeTiempoNoEfectivo = GeneracionDelTiempoNoEfectivo.GenereElTiempoNoEfectivo(iteracion)

        Return metricas
    End Function
End Class
