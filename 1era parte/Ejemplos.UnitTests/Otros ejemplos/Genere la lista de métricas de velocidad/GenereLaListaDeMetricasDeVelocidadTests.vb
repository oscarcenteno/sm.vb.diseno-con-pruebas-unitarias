<TestClass()> Public Class GenereLaListaDeMetricasDeVelocidadTests

    Dim esperado As Integer()
    Dim historias As List(Of Historia)
    Dim iteraciones As List(Of Integer)
    Dim obtenido As Integer()

    <TestInitialize>
    Public Sub Inicialice()
        historias = New List(Of Historia)
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 1, .Puntos = 8})
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 2, .Puntos = 3})
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 0, .Puntos = 5})
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 2, .Puntos = 2})
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 2, .Puntos = 5})
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 3, .Puntos = 1})
        historias.Add(New Historia With {.TerminadaEnLaIteracion = 5, .Puntos = 1})
    End Sub

    <TestMethod()> Public Sub SiNoHayIteraciones()
        esperado = {}

        iteraciones = New List(Of Integer)
        obtenido = GeneracionDeLaListaDeMetricasDeVelocidad.GenereLaListaDeMetricasDeVelocidad(historias, iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SiHayUnaIteracion()
        esperado = {8}

        iteraciones = New List(Of Integer)
        iteraciones.Add(1)
        obtenido = GeneracionDeLaListaDeMetricasDeVelocidad.GenereLaListaDeMetricasDeVelocidad(historias, iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SiHayVariasIteraciones()
        esperado = {8, 10, 1}

        iteraciones = New List(Of Integer)
        iteraciones.Add(1)
        iteraciones.Add(2)
        iteraciones.Add(3)
        obtenido = GeneracionDeLaListaDeMetricasDeVelocidad.GenereLaListaDeMetricasDeVelocidad(historias, iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub
End Class