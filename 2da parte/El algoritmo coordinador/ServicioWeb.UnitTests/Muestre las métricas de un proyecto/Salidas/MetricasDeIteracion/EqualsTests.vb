Imports ServicioWeb.MuestraLasMetricasDeUnProyecto

Namespace MuestraLasMetricasDeUnProyecto.Salidas.MetricasDeIteracionTests

    <TestClass()> Public Class EqualsTests
        Dim esperado As Boolean
        Dim obtenido As Boolean
        Dim unaMetrica As MetricasDeIteracion
        Dim otraMetrica As MetricasDeIteracion

        <TestInitialize> Public Sub Inicialice()
            unaMetrica = New MetricasDeIteracion With {
                .Iteracion = 1,
                .FechaInicial = New Date(2018, 9, 1),
                .FechaFinal = New Date(2018, 9, 26),
                .MetricaDePuntos = "No hay datos",
                .MetricaDeTiempoNoEfectivo = "5%"
            }
            otraMetrica = New MetricasDeIteracion With {
                .Iteracion = 1,
                .FechaInicial = New Date(2018, 9, 1),
                .FechaFinal = New Date(2018, 9, 26),
                .MetricaDePuntos = "No hay datos",
                .MetricaDeTiempoNoEfectivo = "5%"
            }
        End Sub

        <TestMethod()> Public Sub SonIguales()
            esperado = True

            obtenido = unaMetrica.Equals(otraMetrica)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub IteracionEsDiferente()
            esperado = False

            otraMetrica.Iteracion = 2
            Dim obtenido = unaMetrica.Equals(otraMetrica)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub FechaInicialEsDiferente()
            esperado = False

            otraMetrica.FechaInicial = New Date(2012, 10, 10)
            Dim obtenido = unaMetrica.Equals(otraMetrica)

            Assert.AreEqual(esperado, obtenido)
        End Sub

        <TestMethod()> Public Sub FechaFinalEsDiferente()
            esperado = False

            otraMetrica.FechaFinal = New Date(2012, 10, 10)
            Dim obtenido = unaMetrica.Equals(otraMetrica)

            Assert.AreEqual(esperado, obtenido)
        End Sub
    End Class
End Namespace