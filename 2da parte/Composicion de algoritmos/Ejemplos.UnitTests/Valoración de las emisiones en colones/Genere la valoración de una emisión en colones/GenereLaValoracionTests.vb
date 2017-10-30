<TestClass()> Public Class GenereLaValoracionTests

    Dim esperado As Valoracion
    Dim fechaActual As Date
    Dim informacionOficial As InformacionOficial
    Dim emision As Emision
    Dim obtenido As Valoracion

    <TestMethod()> Public Sub GeneraLaValoracion()
        esperado = ObtengaLaValoracionEsperada()

        fechaActual = New Date(2016, 1, 1)
        InformacionOficial = ObtengaLaInformacionOficial()
        emision = ObtengaLaEmision()
        obtenido = GeneracionDeLaValoracionDeUnaEmisionEnColones.GenereLaValoracion(fechaActual, InformacionOficial, emision)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    Private Shared Function ObtengaLaEmision() As Emision
        Dim emision As New Emision
        emision.ISIN = "HDA000000000001"
        emision.MontoNominalDelSaldo = 3578000

        Return emision
    End Function

    Private Shared Function ObtengaLaInformacionOficial() As InformacionOficial
        Dim informacionOficial As New InformacionOficial
        informacionOficial.FechaDeVencimiento = New Date(2016, 6, 6)
        informacionOficial.DiasMinimos = 7
        informacionOficial.PorcentajeDeCobertura = 0.8
        informacionOficial.PrecioLimpio = 80

        Return informacionOficial
    End Function

    Private Shared Function ObtengaLaValoracionEsperada() As Valoracion
        Dim esperado As New Valoracion
        esperado.ISIN = "HDA000000000001"
        esperado.PorcentajeDeCobertura = 0.8
        esperado.ValorDeMercado = 2862400
        esperado.AporteDeGarantia = 2289920 ' Esto permite una comparación exacta al convertir a JSON

        Return esperado
    End Function
End Class