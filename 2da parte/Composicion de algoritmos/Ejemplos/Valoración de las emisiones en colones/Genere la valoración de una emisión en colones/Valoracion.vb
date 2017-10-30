Public Class Valoracion
    Public Property ISIN As String
    Public Property PorcentajeDeCobertura As Decimal
    Public Property ValorDeMercado As Decimal
    Public Property AporteDeGarantia As Decimal

    ' https://msdn.microsoft.com/en-us/library/336aedhh%28v=vs.100%29.aspx?f=255&MSPPError=-2147217396
    Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
        If otherObject Is Nothing Or Not Me.GetType() Is otherObject.GetType() Then
            Return False
        End If
        Dim otraValoracion As Valoracion = CType(otherObject, Valoracion)

        ' Use Equals to compare instance variables.
        Return ISIN = otraValoracion.ISIN _
            And PorcentajeDeCobertura = otraValoracion.PorcentajeDeCobertura _
            And ValorDeMercado = otraValoracion.ValorDeMercado _
            And AporteDeGarantia = otraValoracion.AporteDeGarantia

    End Function


End Class
