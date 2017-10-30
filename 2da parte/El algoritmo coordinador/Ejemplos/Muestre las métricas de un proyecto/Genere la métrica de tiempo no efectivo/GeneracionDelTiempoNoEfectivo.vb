Public Class GeneracionDelTiempoNoEfectivo
    Public Shared Function GenereElTiempoNoEfectivo(iteracion As Iteracion) As String
        If iteracion.HayInformacionDeDiasDisponible Then
            Dim metrica As Decimal
            metrica = iteracion.DiasNoEfectivos / iteracion.CapacidadDelEquipo

            Dim metricaRedondeadaConDosDecimales As Decimal
            metricaRedondeadaConDosDecimales = Decimal.Round(metrica, 2)

            Dim metricaEnPorcentaje As Decimal
            metricaEnPorcentaje = metricaRedondeadaConDosDecimales * 100

            Dim metricaSinDecimales As Integer
            metricaSinDecimales = Decimal.Truncate(metricaEnPorcentaje)

            Return $"{metricaSinDecimales.ToString}%"
        Else
            Return "No hay datos"
        End If
    End Function
End Class