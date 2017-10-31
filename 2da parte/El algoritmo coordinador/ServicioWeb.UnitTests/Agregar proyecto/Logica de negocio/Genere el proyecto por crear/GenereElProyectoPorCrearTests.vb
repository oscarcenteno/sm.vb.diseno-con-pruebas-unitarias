Imports ServicioWeb.AgregarProyecto

<TestClass()> Public Class GenereElProyectoPorCrearTests
    Dim esperado As ProyectoCreado
    Dim obtenido As ProyectoCreado

    <TestMethod()> Public Sub GeneraElProyectoPorCrear()
        esperado = New ProyectoCreado With {
            .Nombre = "Proyecto Excepcional",
            .FechaDeInicio = New Date(2018, 10, 26),
            .FechaDeCreacion = New Date(2018, 10, 20)
        }

        Dim nuevoProyecto As New NuevoProyecto With {
            .Nombre = "   Proyecto Excepcional   ",
            .FechaDeInicio = New Date(2018, 10, 26)
        }
        Dim fechaActual As New Date(2018, 10, 20)
        obtenido = GeneracionDeProyecto.GenereElProyectoPorCrear(nuevoProyecto, fechaActual)

        Assert.AreEqual(esperado, obtenido)
    End Sub

End Class