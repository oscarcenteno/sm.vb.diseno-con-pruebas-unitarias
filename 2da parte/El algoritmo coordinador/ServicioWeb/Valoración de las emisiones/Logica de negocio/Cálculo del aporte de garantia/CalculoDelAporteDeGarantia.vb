Namespace ValoracionDeGarantias
    Public Class CalculoDelAporteDeGarantia
        Public Shared Function CalculeElAporteDeGarantia(valorDeMercado As Decimal, porcentajeDeCoberturaRevisado As Decimal) As Decimal
            Return valorDeMercado * porcentajeDeCoberturaRevisado
        End Function
    End Class
End Namespace