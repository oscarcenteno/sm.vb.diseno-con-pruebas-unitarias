<TestClass()> Public Class CalculeLaMetricaDePuntosTests

    Dim esperado As String
    Dim iteracion As Iteracion
    Dim obtenido As String

    <TestMethod()> Public Sub SeCalculaLaMetrica()
        Dim esperado As String = "95%"

        Dim iteracion As New Iteracion
        iteracion.PuntosPlanificados = 100
        iteracion.PuntosTerminados = 95
        iteracion.HayInformacionDePuntosDisponible = True
        Dim obtenido As String = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SeRedondeaADosDecimales()
        esperado = "91%"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 99
        iteracion.PuntosTerminados = 90
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub LosPuntosPuedenSerDecimales()
        esperado = "89%"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 9.5
        iteracion.PuntosTerminados = 8.5
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SiNoHayPuntosPlanificadosNoHayMetrica()
        esperado = "No hay métrica"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 0
        iteracion.PuntosTerminados = 8.5
        iteracion.HayInformacionDePuntosDisponible = True
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub PodriaNoHaberInformacionDisponible()
        esperado = "No hay datos"

        iteracion = New Iteracion
        iteracion.PuntosPlanificados = 0
        iteracion.PuntosTerminados = 0
        iteracion.HayInformacionDePuntosDisponible = False
        obtenido = CalculoDeLaMetricaDePuntos.CalculeLaMetricaDePuntos(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class