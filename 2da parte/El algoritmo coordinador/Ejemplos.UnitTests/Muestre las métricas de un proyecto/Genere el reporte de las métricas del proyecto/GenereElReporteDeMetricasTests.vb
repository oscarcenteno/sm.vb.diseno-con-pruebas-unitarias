<TestClass()> Public Class GenereElReporteDeMetricasTests

    Dim esperado As ReporteDeMetricas
    Dim proyecto As Proyecto
    Dim obtenido As ReporteDeMetricas

    <TestMethod()> Public Sub GeneraElReporte()
        esperado = ResultadosEsperados.ObtengaElReporteDeMetricas

        proyecto = Parametros.ObtengaElProyecto()
        obtenido = GeneracionDelReporte.GenereElReporteDeMetricas(proyecto)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class