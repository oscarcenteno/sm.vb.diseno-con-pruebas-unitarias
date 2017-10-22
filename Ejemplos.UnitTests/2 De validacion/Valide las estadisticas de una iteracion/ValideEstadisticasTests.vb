<TestClass()>
Public Class ValideEstadisticasTests
    Private puntosPlanificados As Decimal
    Private puntosTerminados As Decimal
    Private capacidadDelEquipo As Decimal
    Private tiempoNoEfectivo As Decimal

    <TestInitialize>
    Public Sub Inicialice()
        ' Inicialice el escenario valido aquí
        puntosPlanificados = 10
        puntosTerminados = 8
        capacidadDelEquipo = 100
        tiempoNoEfectivo = 20
    End Sub

    <TestMethod()>
    Public Sub TodosSonValidos()
        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosPlanificadosNoDebenSerNegativos()
        puntosPlanificados = -1

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub PuntosPlanificadosPuedenSerCero()
        puntosPlanificados = 0

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosPlanificadosTieneUnMaximoDe100Puntos()
        puntosPlanificados = 101

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub PuntosPlanificadosPuedenSerElMáximoPermitido()
        puntosPlanificados = 100

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosTerminadosNoDebenSerNegativos()
        puntosTerminados = -1

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub PuntosTerminadosPuedenSerCero()
        puntosTerminados = 0

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosTerminadosTieneUnMaximoDe100Puntos()
        puntosTerminados = 101

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub PuntosTerminadosPuedenSerElMáximoPermitido()
        puntosTerminados = 100

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub CapacidadDelEquipoNoDebenSerNegativa()
        capacidadDelEquipo = -0.01

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub CapacidadDelEquipoPuedeSerCero()
        capacidadDelEquipo = 0
        tiempoNoEfectivo = 0

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub CapacidadDelEquipoTieneUnMaximoDe1000Dias()
        capacidadDelEquipo = 1000.01

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub CapacidadDelEquipoPuedeSerElMáximoPermitido()
        capacidadDelEquipo = 1000

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub TiempoNoEfectivoNoDebenSerNegativa()
        tiempoNoEfectivo = -0.01

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub TiempoNoEfectivoPuedeSerCero()
        tiempoNoEfectivo = 0

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub TiempoNoEfectivoNoPuedeSerMayorALaCapacidadDelEquipo()
        tiempoNoEfectivo = 100.01

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub

    <TestMethod()>
    Public Sub TiempoNoEfectivoPuedeSerIgualALaCapacidad()
        tiempoNoEfectivo = 100

        ValidacionDeEstadisticas.ValideEstadisticas(puntosPlanificados, puntosTerminados, capacidadDelEquipo, tiempoNoEfectivo)
    End Sub
End Class