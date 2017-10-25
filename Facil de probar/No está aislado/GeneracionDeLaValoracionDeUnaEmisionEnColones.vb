Namespace NoEstaAislado
    Public Class GeneracionDeLaValoracionDeUnaEmisionEnColones

        Public Shared Function GenereLaValoracion(emision As Emision) As Valoracion
            Dim valoracion As New Valoracion

            valoracion.ISIN = emision.ISIN

            Dim informacionOficial As InformacionOficial
            informacionOficial = Repositorio.Consulte(emision.ISIN)

            Dim diasParaElVencimiento As Integer
            diasParaElVencimiento = (informacionOficial.FechaDeVencimiento - Date.Now).Days
            Dim porcentajeDeCoberturaRevisado As Decimal
            If diasParaElVencimiento >= informacionOficial.DiasMinimos Then
                porcentajeDeCoberturaRevisado = informacionOficial.PorcentajeDeCobertura
            Else
                porcentajeDeCoberturaRevisado = 0
            End If
            valoracion.PorcentajeDeCobertura = porcentajeDeCoberturaRevisado

            Dim valorDeMercado As Decimal
            valorDeMercado = emision.MontoNominalDelSaldo * (informacionOficial.PrecioLimpio / 100)
            valoracion.ValorDeMercado = valorDeMercado

            valoracion.AporteDeGarantia = valorDeMercado * porcentajeDeCoberturaRevisado

            Return valoracion
        End Function

    End Class
End Namespace