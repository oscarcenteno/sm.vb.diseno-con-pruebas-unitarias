Namespace ValoracionDeGarantias
    Public Class CalculoDelValorDeMercado
        Public Shared Function CalculeElValorDeMercado(montoNominalDelSaldo As Decimal, precioLimpioDelVectorDePrecios As Decimal) As Decimal
            Return montoNominalDelSaldo * (precioLimpioDelVectorDePrecios / 100)
        End Function
    End Class
End Namespace