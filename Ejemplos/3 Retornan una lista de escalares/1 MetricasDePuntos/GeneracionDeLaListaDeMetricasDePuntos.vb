Public Class GeneracionDeLaListaDeMetricasDePuntos

    Public Shared Function GenereLaListaDeMetricasDePuntos(iteraciones As List(Of Iteracion)) As String()
        Dim metricas As New List(Of String)

        For Each iteracion In iteraciones
            Dim puntosPlanificados = iteracion.PuntosPlanificados
            Dim puntosTerminados = iteracion.PuntosTerminados
            Dim hayInformacionDePuntosDisponible = iteracion.HayInformacionDePuntosDisponible

            Dim metrica As String = CalculeLaMetricaDePuntos(puntosPlanificados, puntosTerminados, hayInformacionDePuntosDisponible)

            metricas.Add(metrica)
        Next

        Return metricas.ToArray
    End Function


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