Namespace ValoracionDeGarantias
    Public Class Valoracion
        Public Property ISIN As String
        Public Property PorcentajeDeCobertura As Decimal
        Public Property ValorDeMercado As Decimal
        Public Property AporteDeGarantia As Decimal

        Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
            Dim otraValoracion As Valoracion = CType(otherObject, Valoracion)

            Return ISIN = otraValoracion.ISIN _
                And PorcentajeDeCobertura = otraValoracion.PorcentajeDeCobertura _
                And ValorDeMercado = otraValoracion.ValorDeMercado _
                And AporteDeGarantia = otraValoracion.AporteDeGarantia

        End Function
    End Class
End Namespace