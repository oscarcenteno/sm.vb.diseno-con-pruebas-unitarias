Namespace ValoracionDeGarantias
    Public Class GeneracionDeLaValoracionDeUnaEmisionEnColones

        Public Shared Function GenereLaValoracion(fechaActual As Date,
                                                  informacionOficial As InformacionOficial,
                                                  emision As Emision) As Valoracion
            Dim valoracion As New Valoracion
            valoracion.ISIN = emision.ISIN

            Dim porcentajeDeCobertura As Decimal
            porcentajeDeCobertura = CalculoDelPorcentajeDeCoberturaRevisado.CalculeElPorcentajeDeCoberturaRevisado(fechaActual, informacionOficial.FechaDeVencimiento, informacionOficial.DiasMinimos, informacionOficial.PorcentajeDeCobertura)
            valoracion.PorcentajeDeCobertura = porcentajeDeCobertura

            Dim valorDeMercado As Decimal
            valorDeMercado = CalculoDelValorDeMercado.CalculeElValorDeMercado(emision.MontoNominalDelSaldo, informacionOficial.PrecioLimpio)
            valoracion.ValorDeMercado = valorDeMercado

            valoracion.AporteDeGarantia = CalculoDelAporteDeGarantia.CalculeElAporteDeGarantia(valorDeMercado, porcentajeDeCobertura)

            Return valoracion
        End Function
    End Class
End Namespace