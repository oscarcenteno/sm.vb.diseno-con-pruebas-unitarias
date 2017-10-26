Imports System.Globalization

Public Class CalculoDeLaMetricaDePuntos
    Public Shared Function CalculeLaMetricaDePuntos(iteracion As Iteracion) As String
        If iteracion.HayInformacionDePuntosDisponible Then
            If iteracion.PuntosPlanificados > 0 Then
                Dim metrica As Decimal = iteracion.PuntosTerminados / iteracion.PuntosPlanificados
                Dim metricaRedondeadaConDosDecimales As Decimal = Decimal.Round(metrica, 2)
                Dim metricaEnPorcentaje As Decimal = metricaRedondeadaConDosDecimales * 100
                Dim metricaSinDecimales As Integer = Decimal.Truncate(metricaEnPorcentaje)

                Return metricaSinDecimales.ToString("G", New CultureInfo("en-US")) + "%"
            Else
                Return "No hay métrica"
            End If
        Else
            Return "No hay datos"
        End If
    End Function
End Class