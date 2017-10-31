Imports ServicioWeb.ValoracionDeGarantias

<TestClass()> Public Class CalculeElPorcentajeDeCoberturaRevisadoTests

    <TestMethod()>
    Public Sub LaEmisionVenceEnMasDe7Dias()
        Dim esperado As Decimal = 0.8

        Dim fechaActual As Date = New Date(2016, 1, 1)
        Dim fechaDeVencimientoDelValorOficial As Date = New Date(2016, 6, 6)
        Dim diasMinimosAlVencimientoDelEmisor As Integer = 7
        Dim porcentajeDeCobertura As Decimal = 0.8
        Dim obtenido = CalculoDelPorcentajeDeCoberturaRevisado.CalculeElPorcentajeDeCoberturaRevisado(fechaActual, fechaDeVencimientoDelValorOficial, diasMinimosAlVencimientoDelEmisor, porcentajeDeCobertura)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()>
    Public Sub LaEmisionVenceEn7Dias()
        Dim esperado As Decimal = 0.8

        Dim fechaActual As Date = New Date(2016, 1, 1)
        Dim fechaDeVencimientoDelValorOficial As Date = New Date(2016, 1, 8)
        Dim diasMinimosAlVencimientoDelEmisor As Integer = 7
        Dim porcentajeDeCobertura As Decimal = 0.8
        Dim obtenido = CalculoDelPorcentajeDeCoberturaRevisado.CalculeElPorcentajeDeCoberturaRevisado(fechaActual, fechaDeVencimientoDelValorOficial, diasMinimosAlVencimientoDelEmisor, porcentajeDeCobertura)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()>
    Public Sub LaEmisionVenceEnMenosDe7Dias()
        Dim esperado As Decimal = 0

        Dim fechaActual As Date = New Date(2016, 1, 1)
        Dim fechaDeVencimientoDelValorOficial As Date = New Date(2016, 1, 1)
        Dim diasMinimosAlVencimientoDelEmisor As Integer = 7
        Dim porcentajeDeCobertura As Decimal = 0.8
        Dim obtenido = CalculoDelPorcentajeDeCoberturaRevisado.CalculeElPorcentajeDeCoberturaRevisado(fechaActual, fechaDeVencimientoDelValorOficial, diasMinimosAlVencimientoDelEmisor, porcentajeDeCobertura)

        Assert.AreEqual(esperado, obtenido)
    End Sub

End Class