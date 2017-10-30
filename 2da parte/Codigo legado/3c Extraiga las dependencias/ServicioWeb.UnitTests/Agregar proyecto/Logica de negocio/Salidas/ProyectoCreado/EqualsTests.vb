Imports CodigoLegado.ServicioWeb.AgregarProyecto

Namespace AgregarProyecto.LogicaDeNegocio.Salidas.ProyectoCreadoTests

    <TestClass()> Public Class EqualsTests
        Dim esperado As Boolean
        Dim obtenido As Boolean
        Dim unProyecto As ProyectoCreado
        Dim otroProyecto As ProyectoCreado

        <TestInitialize> Public Sub Inicialice()
            unProyecto = New ProyectoCreado With {
                .Id = 1,
                .Nombre = "Proyecto Asombroso",
                .FechaDeInicio = New Date(2018, 10, 26),
                .FechaDeCreacion = New Date(2018, 9, 1)
            }
            otroProyecto = New ProyectoCreado With {
                .Id = 1,
                .Nombre = "Proyecto Asombroso",
                .FechaDeInicio = New Date(2018, 10, 26),
                .FechaDeCreacion = New Date(2018, 9, 1)
            }
        End Sub

        <TestMethod()> Public Sub SonIguales()
            esperado = True

            obtenido = unProyecto.Equals(otroProyecto)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub IdEsDiferente()
            esperado = False

            otroProyecto.Id = 2
            Dim obtenido = unProyecto.Equals(otroProyecto)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub NombreEsDiferente()
            esperado = False

            otroProyecto.Nombre = "Otro nombre"
            Dim obtenido = unProyecto.Equals(otroProyecto)

            Assert.AreEqual(esperado, obtenido)
        End Sub


        <TestMethod()> Public Sub FechaDeInicioEsDiferente()
            esperado = False

            otroProyecto.FechaDeInicio = New Date(2011, 1, 1)
            Dim obtenido = unProyecto.Equals(otroProyecto)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub FechaDeCreacionEsDiferente()
            esperado = False

            otroProyecto.FechaDeCreacion = New Date(2011, 1, 1)
            Dim obtenido = unProyecto.Equals(otroProyecto)

            Assert.AreEqual(esperado, obtenido)
        End Sub

    End Class
End Namespace