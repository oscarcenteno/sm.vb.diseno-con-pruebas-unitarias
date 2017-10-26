<TestClass()> Public Class GenereUnNuevoProyectoTests

    ' Comentario:
    ' Dado que no hay fórmulas, decisiones ni anidación de estructuras, 
    ' Entonces podemos considerar que esta prueba es suficiente (sencilla y completa)
    <TestMethod()> Public Sub GeneraElNuevoProyecto()
        Dim esperado As New NuevoProyecto
        esperado.Nombre = "Proyecto Excepcional"
        esperado.FechaDeInicio = New Date(2018, 10, 26)
        esperado.FechaDeCreacion = New Date(2018, 10, 20)

        Dim obtenido As NuevoProyecto
        Dim fechaActual As Date = New Date(2018, 10, 20)
        Dim nombre As String = "Proyecto Excepcional"
        Dim fechaDeInicio As Date = New Date(2018, 10, 26)
        obtenido = CreacionDeUnNuevoProyecto.GenereUnNuevoProyecto(fechaActual, nombre, fechaDeInicio)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class