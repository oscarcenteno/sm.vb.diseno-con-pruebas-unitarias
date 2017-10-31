Imports System.ServiceModel
Imports NSubstitute
Imports ServicioWeb.AgregarProyecto

<TestClass()> Public Class AgregueUnProyectoTests
    Dim obtenido As ProyectoCreado

    <TestMethod()> Public Sub RetornaElNuevoProyectoCreado()
        Dim esperado = ObtengaElProyectoCreadoConId()

        Dim dependencias As Dependencias = InicialiceLasDependencias()
        Dim servicio As New ServicioAgregarProyecto(dependencias)
        Dim proyectoValido As NuevoProyecto = ObtengaUnProyectoValido()
        obtenido = servicio.AgregueUnProyecto(proyectoValido)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    Private Shared Function InicialiceLasDependencias() As Dependencias
        Dim dependencias = Substitute.For(Of Dependencias)()

        dependencias.ObtengaLaFechaActual().Returns(New Date(2018, 9, 1))
        dependencias.ObtengaLosNombresDeLosProyectosExistentes().Returns(New List(Of String))

        Dim proyectoCreadoSinId As ProyectoCreado = ObtengaElProyectoPorCrear()
        Dim proyectoCreadoConId As ProyectoCreado = ObtengaElProyectoCreadoConId()
        dependencias.Guarde(proyectoCreadoSinId).Returns(proyectoCreadoConId)

        Return dependencias
    End Function

    Private Shared Function ObtengaUnProyectoValido() As NuevoProyecto
        Return New NuevoProyecto() With {
            .Nombre = "Proyecto Asombroso",
            .FechaDeInicio = New Date(2018, 10, 26)
        }
    End Function

    Private Shared Function ObtengaElProyectoPorCrear() As ProyectoCreado
        Dim proyectoCreadoSinId As New ProyectoCreado With {
            .Nombre = "Proyecto Asombroso",
            .FechaDeInicio = New Date(2018, 10, 26),
            .FechaDeCreacion = New Date(2018, 9, 1)
        }
        Return proyectoCreadoSinId
    End Function

    Private Shared Function ObtengaElProyectoCreadoConId() As ProyectoCreado
        Dim proyectoCreadoConId As New ProyectoCreado With {
                    .Id = 1,
                    .Nombre = "Proyecto Asombroso",
                    .FechaDeInicio = New Date(2018, 10, 26),
                    .FechaDeCreacion = New Date(2018, 9, 1)
                }
        Return proyectoCreadoConId
    End Function

    <TestMethod()> Public Sub EnviaAGuardarElNuevoProyecto()
        Dim dependencias As Dependencias = InicialiceLasDependencias()
        Dim servicio As New ServicioAgregarProyecto(dependencias)
        Dim nuevo As NuevoProyecto = ObtengaUnProyectoValido()
        obtenido = servicio.AgregueUnProyecto(nuevo)

        ' Assert
        Dim proyectoPorCrear As ProyectoCreado = ObtengaElProyectoPorCrear()
        dependencias.Received(1).Guarde(proyectoPorCrear)
    End Sub

    <TestMethod(), ExpectedException(GetType(FaultException(Of ErrorDeValidacionFault)))>
    Public Sub ManejaErroresDeValidacion()
        Dim dependencias As Dependencias = InicialiceLasDependencias()
        Dim servicio As New ServicioAgregarProyecto(dependencias)
        Dim proyectoInvalido As NuevoProyecto = ObtengaUnProyectoInvalido()
        obtenido = servicio.AgregueUnProyecto(proyectoInvalido)
    End Sub

    Private Shared Function ObtengaUnProyectoInvalido() As NuevoProyecto
        Dim nuevo As New NuevoProyecto() With {
            .Nombre = "Proyecto Asombroso!",
            .FechaDeInicio = New Date(2018, 10, 26)
        }
        Return nuevo
    End Function

    <TestMethod(), ExpectedException(GetType(FaultException))>
    Public Sub ManejaErroresInesperados()
        Dim dependencias As Dependencias = InicialiceLasDependenciasQueLanzanExcepcion()
        Dim servicio As New ServicioAgregarProyecto(dependencias)
        Dim proyectoValido As NuevoProyecto = ObtengaUnProyectoValido()
        obtenido = servicio.AgregueUnProyecto(proyectoValido)
    End Sub

    Private Shared Function InicialiceLasDependenciasQueLanzanExcepcion() As Dependencias
        Dim dependencias = Substitute.For(Of Dependencias)()

        dependencias.ObtengaLaFechaActual().Returns(New Date(2018, 9, 1))
        dependencias.
            When(Function(c) c.ObtengaLosNombresDeLosProyectosExistentes()).
            Do(Sub(c) Throw New Exception())

        Return dependencias
    End Function

End Class