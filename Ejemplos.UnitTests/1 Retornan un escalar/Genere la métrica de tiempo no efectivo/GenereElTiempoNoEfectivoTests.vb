<TestClass()> Public Class GenereElTiempoNoEfectivoTests
    Dim esperado As String
    Dim iteracion As Iteracion
    Dim obtenido As String

    <TestInitialize> Public Sub Inicialice()
        iteracion = New Iteracion
        iteracion.HayInformacionDeDiasDisponible = True
        iteracion.CapacidadDelEquipo = 100
        iteracion.DiasNoEfectivos = 5
    End Sub

    <TestMethod()> Public Sub SeCalculaLaMétrica()
        esperado = "5%"

        obtenido = GeneracionDelTiempoNoEfectivo.GenereElTiempoNoEfectivo(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SeRedondeaADosDecimales()
        esperado = "6%"

        iteracion.CapacidadDelEquipo = 99
        iteracion.DiasNoEfectivos = 5.67
        obtenido = GeneracionDelTiempoNoEfectivo.GenereElTiempoNoEfectivo(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub SePermiteNoTenerDíasNoEfectivos()
        esperado = "0%"

        iteracion.DiasNoEfectivos = 0
        obtenido = GeneracionDelTiempoNoEfectivo.GenereElTiempoNoEfectivo(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub

    <TestMethod()> Public Sub PodríaNoHaberInformaciónDisponible()
        esperado = "No hay datos"

        iteracion.HayInformacionDeDiasDisponible = False
        obtenido = GeneracionDelTiempoNoEfectivo.GenereElTiempoNoEfectivo(iteracion)

        Assert.AreEqual(esperado, obtenido)
    End Sub
End Class