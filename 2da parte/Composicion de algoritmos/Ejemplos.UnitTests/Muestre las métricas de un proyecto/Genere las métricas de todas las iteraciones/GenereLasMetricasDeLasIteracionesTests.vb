<TestClass()> Public Class GenereLasMetricasDeLasIteracionesTests
    Dim iteraciones As List(Of Iteracion)
    Dim esperado As List(Of MetricasDeIteracion)
    Dim obtenido As List(Of MetricasDeIteracion)

    <TestInitialize> Public Sub Inicialice()
        iteraciones = New List(Of Iteracion)
        AgregueIteracion(1, New Date(2017, 10, 16), New Date(2017, 10, 20), True, 10, 8, True, 100, 5)
        AgregueIteracion(2, New Date(2017, 10, 23), New Date(2017, 10, 27), False, 0, 0, True, 35, 10)
        AgregueIteracion(3, New Date(2017, 10, 30), New Date(2017, 11, 3), False, 0, 0, False, 0, 0)
    End Sub

    Private Sub AgregueIteracion(numero As Integer, fechaInicial As Date, fechaFinal As Date, hayInformacionDePuntosDisponible As Boolean, puntosPlanificados As Integer, puntosTerminados As Integer, HayInformacionDeDiasDisponible As Boolean, capacidadDelEquipo As Integer, diasNoEfectivos As Integer)
        Dim nuevaIteracion As New Iteracion With {
            .Numero = numero,
            .FechaInicial = fechaInicial,
            .FechaFinal = fechaFinal,
            .HayInformacionDePuntosDisponible = hayInformacionDePuntosDisponible,
            .PuntosPlanificados = puntosPlanificados,
            .PuntosTerminados = puntosTerminados,
            .HayInformacionDeDiasDisponible = HayInformacionDeDiasDisponible,
            .CapacidadDelEquipo = capacidadDelEquipo,
            .DiasNoEfectivos = diasNoEfectivos
            }

        iteraciones.Add(nuevaIteracion)
    End Sub

    <TestMethod()> Public Sub GeneraLasMetricas()
        esperado = New List(Of MetricasDeIteracion)
        AgregueMetricasDeIteracionEsperada(1, New Date(2017, 10, 16), New Date(2017, 10, 20), "80%", "5%")
        AgregueMetricasDeIteracionEsperada(2, New Date(2017, 10, 23), New Date(2017, 10, 27), "No hay datos", "29%")
        AgregueMetricasDeIteracionEsperada(3, New Date(2017, 10, 30), New Date(2017, 11, 3), "No hay datos", "No hay datos")

        obtenido = GeneracionDeMetricasDeLasIteraciones.GenereLasMetricasDeLasIteraciones(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    Private Sub AgregueMetricasDeIteracionEsperada(iteracion As Integer, fechaInicial As Date, fechaFinal As Date, metricaDePuntos As String, metricaDeTiempoNoEfectivo As String)
        Dim metrica As New MetricasDeIteracion With {
            .Iteracion = iteracion,
            .FechaInicial = fechaInicial,
            .FechaFinal = fechaFinal,
            .MetricaDePuntos = metricaDePuntos,
            .MetricaDeTiempoNoEfectivo = metricaDeTiempoNoEfectivo
        }

        esperado.Add(metrica)
    End Sub
End Class