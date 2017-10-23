<TestClass()> Public Class GenereLasMetricasDeLaIteracionTests

    <TestMethod()> Public Sub GeneraLasMetricas()
        Dim esperado As New MetricasDeIteracion
        esperado.Iteracion = 1
        esperado.FechaInicial = New Date(2017, 10, 16)
        esperado.FechaFinal = New Date(2017, 10, 20)
        esperado.MetricaDePuntos = "95% 95|100"
        esperado.MetricaDeTiempoNoEfectivo = "5%"

        Dim iteracion As New Iteracion
        iteracion.Numero = 1
        iteracion.FechaInicial = New Date(2017, 10, 16)
        iteracion.FechaFinal = New Date(2017, 10, 20)
        iteracion.HayInformacionDePuntosDisponible = True
        iteracion.PuntosPlanificados = 100
        iteracion.PuntosTerminados = 95
        iteracion.HayInformacionDeDiasDisponible = True
        iteracion.CapacidadDelEquipo = 100
        iteracion.DiasNoEfectivos = 5
        Dim obtenido As MetricasDeIteracion
        obtenido = GeneracionDeMetricasDeIteracion.GenereLasMetricasDeLaIteracion(iteracion)

        JsonAssert.AreEqual(esperado, obtenido)
    End Sub
End Class