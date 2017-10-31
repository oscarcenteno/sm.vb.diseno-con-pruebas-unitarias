Imports ServicioWeb.ValoracionDeGarantias

<TestClass()> Public Class GenereLaValoracionDeLasEmisionesEnColonesTests

    Dim esperado As List(Of Valoracion)
    Dim fechaActual As Date
    Dim informacionOficial As List(Of InformacionOficial)
    Dim emisiones As List(Of Emision)
    Dim obtenido As List(Of Valoracion)

    <TestMethod()> Public Sub GeneraLaValoracion()
        InicialiceLasValoracionesEsperadas()

        fechaActual = New Date(2016, 1, 1)
        InicialiceLaInformacionOficial()
        InicialiceLasEmisiones()
        obtenido = GeneracionDeLaValoracionDeLasEmisionesEnColones.GenereLaValoracionDeLasEmisionesEnColones(fechaActual, informacionOficial, emisiones)

        CollectionAssert.AreEqual(esperado, obtenido)

    End Sub

    Private Sub InicialiceLasValoracionesEsperadas()
        esperado = New List(Of Valoracion)
        esperado.Add(New Valoracion With {.ISIN = "HDA000000000001", .PorcentajeDeCobertura = 0.8, .ValorDeMercado = 2862400, .AporteDeGarantia = 2289920})
        esperado.Add(New Valoracion With {.ISIN = "HDA000000000002", .PorcentajeDeCobertura = 0, .ValorDeMercado = 36624000, .AporteDeGarantia = 0})
        esperado.Add(New Valoracion With {.ISIN = "HDA000000000003", .PorcentajeDeCobertura = 0, .ValorDeMercado = 52608000, .AporteDeGarantia = 0})
    End Sub

    Private Sub InicialiceLasEmisiones()
        emisiones = New List(Of Emision)
        emisiones.Add(New Emision With {.ISIN = "HDA000000000001", .MontoNominalDelSaldo = 3578000})
        emisiones.Add(New Emision With {.ISIN = "HDA000000000002", .MontoNominalDelSaldo = 4578000})
        emisiones.Add(New Emision With {.ISIN = "HDA000000000003", .MontoNominalDelSaldo = 6576000})
    End Sub

    Private Sub InicialiceLaInformacionOficial()
        informacionOficial = New List(Of InformacionOficial)
        informacionOficial.Add(New InformacionOficial With {.ISIN = "HDA000000000001", .FechaDeVencimiento = New Date(2016, 6, 6), .DiasMinimos = 7, .PorcentajeDeCobertura = 0.8, .PrecioLimpio = 80})
        informacionOficial.Add(New InformacionOficial With {.ISIN = "HDA000000000002", .FechaDeVencimiento = New Date(2016, 1, 1), .DiasMinimos = 14, .PorcentajeDeCobertura = 0.9, .PrecioLimpio = 800})
        informacionOficial.Add(New InformacionOficial With {.ISIN = "HDA000000000003", .FechaDeVencimiento = New Date(2015, 1, 1), .DiasMinimos = 14, .PorcentajeDeCobertura = 0.9, .PrecioLimpio = 800})
    End Sub
End Class