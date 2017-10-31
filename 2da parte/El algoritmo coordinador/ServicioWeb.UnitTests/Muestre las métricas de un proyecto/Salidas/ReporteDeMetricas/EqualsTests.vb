Imports ServicioWeb.MuestraLasMetricasDeUnProyecto

Namespace MuestraLasMetricasDeUnProyecto.Salidas.ReporteDeMetricasTests

    <TestClass()> Public Class EqualsTests
        Dim esperado As Boolean
        Dim obtenido As Boolean
        Dim unReporte As ReporteDeMetricas
        Dim otroReporte As ReporteDeMetricas

        <TestInitialize> Public Sub Inicialice()
            unReporte = New ReporteDeMetricas With {
                .Nombre = "Proyecto asombroso",
                .Metricas = ResultadosEsperados.ObtengaLaListaDeMetricas()
            }
            otroReporte = New ReporteDeMetricas With {
                .Nombre = "Proyecto asombroso",
                .Metricas = ResultadosEsperados.ObtengaLaListaDeMetricas()
            }
        End Sub

        <TestMethod()> Public Sub SonIguales()
            esperado = True

            obtenido = unReporte.Equals(otroReporte)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub NombreEsDiferente()
            esperado = False

            otroReporte.Nombre = "Otro proyecto"
            Dim obtenido = unReporte.Equals(otroReporte)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub MetricasEsDiferente()
            esperado = False

            otroReporte.Metricas = New List(Of MetricasDeIteracion)
            Dim obtenido = unReporte.Equals(otroReporte)

            Assert.AreEqual(esperado, obtenido)
        End Sub
    End Class
End Namespace