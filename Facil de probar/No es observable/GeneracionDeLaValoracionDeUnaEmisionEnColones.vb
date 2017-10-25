Namespace NoEsObservable
    Public Class GeneracionDeLaValoracionDeUnaEmisionEnColones

        Public Shared Sub GenereLaValoracion(fechaActual As Date,
                                             informacionOficial As InformacionOficial,
                                             emision As Emision)
            Dim valoracion As New Valoracion

            valoracion.ISIN = emision.ISIN

            Dim diasParaElVencimiento As Integer = (informacionOficial.FechaDeVencimiento - fechaActual).Days
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

            Repositorio.Guarde(valoracion)
        End Sub

    End Class
End Namespace