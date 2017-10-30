Imports System.ServiceModel
Imports Ejemplos
Imports Ejemplos.UnitTests
Imports NSubstitute
Imports ServicioWeb.MuestraLasMetricasDeUnProyecto

<TestClass()> Public Class ConsulteLasMetricasDelProyectoTests
    Dim esperado As ReporteDeMetricas
    Dim dependencias As Dependencias
    Dim servicio As ServicioConsulteLasMetricas
    Dim obtenido As ReporteDeMetricas

    <TestMethod()> Public Sub RetornaElReporteDeMetricasGenerado()
        esperado = ResultadosEsperados.ObtengaElReporteDeMetricas()

        dependencias = Substitute.For(Of Dependencias)
        dependencias.ObtengaElProyecto(1).Returns(Parametros.ObtengaElProyecto())
        servicio = New ServicioConsulteLasMetricas(dependencias)
        obtenido = servicio.ConsulteLasMetricasDelProyecto(1)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod(), ExpectedException(GetType(FaultException(Of ProyectoNoExisteFault)))>
    Public Sub ManejaElCasoSiElProyectoNoExiste()
        dependencias = Substitute.For(Of Dependencias)
        dependencias.ObtengaElProyecto(2).Returns(Function(c) Nothing)
        dependencias.ObtengaLaFechaActual.Returns(New Date(2017, 11, 20))
        servicio = New ServicioConsulteLasMetricas(dependencias)
        servicio.ConsulteLasMetricasDelProyecto(2)
    End Sub

    <TestMethod(), ExpectedException(GetType(FaultException))>
    Public Sub ManejaUnErrorInesperado()
        dependencias = Substitute.For(Of Dependencias)
        dependencias.
            When(Function(c) c.ObtengaElProyecto(2)).
            Do(Sub(c) Throw New Exception())
        servicio = New ServicioConsulteLasMetricas(dependencias)
        servicio.ConsulteLasMetricasDelProyecto(2)
    End Sub
End Class