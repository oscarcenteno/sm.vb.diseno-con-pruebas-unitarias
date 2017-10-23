<TestClass()> Public Class GenereLaListaDeMetricasDePuntosTests
    Dim esperado As String()
    Dim iteraciones As List(Of Iteracion)
    Dim obtenido As String()

    <TestMethod()> Public Sub SiNoHayIteraciones()
        esperado = {}

        iteraciones = New List(Of Iteracion)
        obtenido = GeneracionDeLaListaDeMetricasDePuntos.GenereLaListaDeMetricasDePuntos(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub ConUnaIteracion()
        esperado = {"95%"}

        iteraciones = New List(Of Iteracion)
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 100, .PuntosTerminados = 95, .HayInformacionDePuntosDisponible = True})
        obtenido = GeneracionDeLaListaDeMetricasDePuntos.GenereLaListaDeMetricasDePuntos(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub ConTresIteraciones()
        esperado = {"95%", "91%", "89%"}

        iteraciones = New List(Of Iteracion)
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 100, .PuntosTerminados = 95, .HayInformacionDePuntosDisponible = True})
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 99, .PuntosTerminados = 90, .HayInformacionDePuntosDisponible = True})
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 9.5, .PuntosTerminados = 8.5, .HayInformacionDePuntosDisponible = True})
        obtenido = GeneracionDeLaListaDeMetricasDePuntos.GenereLaListaDeMetricasDePuntos(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

End Class