<TestClass()> Public Class CalculeLaMetricaDePuntosTests

    Dim esperado As String
    Dim puntosPlanificados As Decimal
    Dim puntosTerminados As Decimal
    Dim hayInformacionDePuntosDisponible As Boolean
    Dim obtenido As String

    <TestMethod()> Public Sub SeCalculaLaMetrica()
        esperado = "95%"

        puntosPlanificados = 100
        puntosTerminados = 95
        hayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(puntosPlanificados, puntosTerminados, hayInformacionDePuntosDisponible)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SeRedondeaADosDecimales()
        esperado = "91%"

        puntosPlanificados = 99
        puntosTerminados = 90
        hayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(puntosPlanificados, puntosTerminados, hayInformacionDePuntosDisponible)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub LosPuntosPuedenSerDecimales()
        esperado = "89%"

        puntosPlanificados = 9.5
        puntosTerminados = 8.5
        hayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(puntosPlanificados, puntosTerminados, hayInformacionDePuntosDisponible)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SiNoHayPuntosPlanificadosNoHayMetrica()
        esperado = "No hay métrica"

        puntosPlanificados = 0
        puntosTerminados = 8.5
        hayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(puntosPlanificados, puntosTerminados, hayInformacionDePuntosDisponible)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub PodriaNoHaberInformacionDisponible()
        esperado = "No hay datos"

        puntosPlanificados = 0
        puntosTerminados = 0
        hayInformacionDePuntosDisponible = False
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(puntosPlanificados, puntosTerminados, hayInformacionDePuntosDisponible)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class