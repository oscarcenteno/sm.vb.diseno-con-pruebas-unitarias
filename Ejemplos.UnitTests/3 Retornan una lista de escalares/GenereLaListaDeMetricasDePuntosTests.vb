<TestClass()> Public Class GenereLaListaDeMetricasDePuntosTests

    <TestMethod()> Public Sub SiNoHayIteraciones()
        Dim esperado As String() = {}

        Dim iteraciones As New List(Of Iteracion)
        Dim obtenido As String() = GeneracionDeLaListaDeMetricasDePuntos.GenereLaListaDeMetricasDePuntos(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub ConUnaIteracion()
        Dim esperado As String() = {"95%"}

        Dim iteraciones As New List(Of Iteracion)
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 100, .PuntosTerminados = 95, .HayInformacionDePuntosDisponible = True})

        Dim obtenido As String() = GeneracionDeLaListaDeMetricasDePuntos.GenereLaListaDeMetricasDePuntos(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub ConTresIteraciones()
        Dim esperado As String() = {"95%", "91%", "89%"}

        Dim iteraciones As New List(Of Iteracion)
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 100, .PuntosTerminados = 95, .HayInformacionDePuntosDisponible = True})
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 99, .PuntosTerminados = 90, .HayInformacionDePuntosDisponible = True})
        iteraciones.Add(New Iteracion With {.PuntosPlanificados = 9.5, .PuntosTerminados = 8.5, .HayInformacionDePuntosDisponible = True})

        Dim obtenido As String() = GeneracionDeLaListaDeMetricasDePuntos.GenereLaListaDeMetricasDePuntos(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

End Class