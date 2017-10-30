<TestClass()> Public Class GenereLasMetricasDeLasIteracionesTests

    Dim esperado As List(Of MetricasDeIteracion)
    Dim iteraciones As List(Of Iteracion)
    Dim obtenido As List(Of MetricasDeIteracion)

    <TestMethod()> Public Sub GeneraLasMetricas()
        esperado = ResultadosEsperados.ObtengaLaListaDeMetricas()

        iteraciones = Parametros.ObtengaLasIteraciones()
        obtenido = GeneracionDeMetricasDeLasIteraciones.GenereLasMetricasDeLasIteraciones(iteraciones)

        CollectionAssert.AreEqual(esperado, obtenido)
    End Sub
End Class