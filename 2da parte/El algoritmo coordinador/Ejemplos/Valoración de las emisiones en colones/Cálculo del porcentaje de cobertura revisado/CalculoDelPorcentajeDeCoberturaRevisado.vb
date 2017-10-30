Public Class CalculoDelPorcentajeDeCoberturaRevisado
    Public Shared Function CalculeElPorcentajeDeCoberturaRevisado(fechaActual As Date, fechaDeVencimientoDelValorOficial As Date, diasMinimosAlVencimientoDelEmisor As Integer, porcentajeDeCobertura As Decimal) As Decimal
        Dim diasParaElVencimiento As Integer = (fechaDeVencimientoDelValorOficial - fechaActual).Days

        If diasParaElVencimiento >= diasMinimosAlVencimientoDelEmisor Then
            Return porcentajeDeCobertura
        Else
            Return 0
        End If
    End Function
End Class