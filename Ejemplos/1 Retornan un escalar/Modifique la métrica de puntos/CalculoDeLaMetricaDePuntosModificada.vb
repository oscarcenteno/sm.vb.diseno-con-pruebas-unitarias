Public Class CalculoDeLaMetricaDePuntosModificada
    Public Shared Function CalculeLaMetricaDePuntos(iteracion As Iteracion) As String
        If iteracion.HayInformacionDePuntosDisponible Then
            If iteracion.PuntosPlanificados > 0 Then
                Dim metricaRedondeadaConDosDecimales As Decimal = Decimal.Round(iteracion.PuntosTerminados / iteracion.PuntosPlanificados, 2) * 100
                Dim metricaSinDecimales As Integer = Decimal.Truncate(metricaRedondeadaConDosDecimales)

                Return $"{metricaSinDecimales}% {iteracion.PuntosTerminados}|{iteracion.PuntosPlanificados}"
            Else
                Return "No hay métrica"
            End If
        Else
            Return "No hay datos"
        End If
    End Function
End Class