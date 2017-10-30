<TestClass()> Public Class CalculeLaVelocidadTests
    Private esperado As Integer
    Private historias As List(Of Historia)
    Private iteracion As Integer
    Private obtenido As Integer

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

    <TestMethod()> Public Sub NoHayHistoriasTerminadasEnLaIteracion()
        esperado = 0

        iteracion = 4
        obtenido = CalculoDeVelocidad.CalculeLaVelocidad(historias, iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub HayUnaHistoriaTerminadaEnLaIteracion()
        esperado = 8

        iteracion = 1
        obtenido = CalculoDeVelocidad.CalculeLaVelocidad(historias, iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub HayVariasHistoriasTermiandasEnLaIteracion()
        esperado = 10

        iteracion = 2
        obtenido = CalculoDeVelocidad.CalculeLaVelocidad(historias, iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

End Class