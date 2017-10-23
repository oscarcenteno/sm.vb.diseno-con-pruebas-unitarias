<TestClass()> Public Class CalculeLaMetricaDePuntosModificadaTests

    Dim esperado As String
    Dim iteracion As Iteracion
    Dim obtenido As String

    <TestMethod()> Public Sub SeCalculaLaMetrica()
        esperado = "95% 95|100"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 100
        iteracion.PuntosTerminados = 95
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntosModificada.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SeRedondeaADosDecimales()
        esperado = "91% 90|99"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 99
        iteracion.PuntosTerminados = 90
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntosModificada.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub LosPuntosPuedenSerDecimales()
        esperado = "89% 8.5|9.5"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 9.5
        iteracion.PuntosTerminados = 8.5
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntosModificada.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SiNoHayPuntosPlanificadosNoHayMetrica()
        esperado = "No hay métrica"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 0
        iteracion.PuntosTerminados = 8.5
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntosModificada.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub PodriaNoHaberInformacionDisponible()
        esperado = "No hay datos"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 0
        iteracion.PuntosTerminados = 0
        iteracion.HayInformacionDePuntosDisponible = False
        obtenido = CalculoDeLaMetricaDePuntosModificada.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class