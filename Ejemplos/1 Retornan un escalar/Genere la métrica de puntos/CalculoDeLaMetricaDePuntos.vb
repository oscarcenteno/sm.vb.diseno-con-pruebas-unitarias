Public Class CalculoDeLaMetricaDePuntos

    Public Shared Function CalculeLaMetricaDePuntos(puntosPlanificados As Decimal, puntosTerminados As Decimal, hayInformacionDePuntosDisponible As Boolean) As String
        If hayInformacionDePuntosDisponible Then
            If puntosPlanificados > 0 Then
                Dim metrica As Decimal = Decimal.Round(puntosTerminados / puntosPlanificados, 2) * 100
                Dim metricaSinDecimales As Integer = Decimal.Truncate(metrica)

                Return $"{metricaSinDecimales}%"
            Else
                Return "No hay métrica"
            End If
        Else
            Return "No hay datos"
        End If
    End Function
End Class