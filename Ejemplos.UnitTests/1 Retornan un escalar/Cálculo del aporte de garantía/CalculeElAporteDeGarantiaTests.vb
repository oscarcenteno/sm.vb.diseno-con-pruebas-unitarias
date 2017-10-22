<TestClass()> Public Class CalculeElAporteDeGarantiaTests

    <TestMethod()>
    Public Sub Calculo()
        Dim esperado As Decimal = 2289920

        Dim valorDeMercado As Decimal = 2862400
        Dim porcentajeDeCoberturaRevisado As Decimal = 0.8
        Dim obtenido As Decimal = CalculoDelAporteDeGarantia.CalculeElAporteDeGarantia(valorDeMercado, porcentajeDeCoberturaRevisado)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class