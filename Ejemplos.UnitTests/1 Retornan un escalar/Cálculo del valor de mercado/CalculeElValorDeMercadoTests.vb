<TestClass()> Public Class CalculeElValorDeMercadoTests

    <TestMethod()>
    Public Sub Calculo()
        Dim esperado As Decimal = 2862400

        Dim montoNominalDelSaldo As Decimal = 3578000
        Dim precioLimpioDelVectorDePrecios As Decimal = 80

        Dim obtenido As Decimal = CalculoDelValorDeMercado.CalculeElValorDeMercado(montoNominalDelSaldo, precioLimpioDelVectorDePrecios)

        Assert.AreEqual(esperado, obtenido)
    End Sub

End Class