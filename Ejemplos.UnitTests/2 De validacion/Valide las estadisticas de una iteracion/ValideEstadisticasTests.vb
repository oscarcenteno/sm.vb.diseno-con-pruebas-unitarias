<TestClass()>
Public Class ValideEstadisticasTests
    Private iteracion As Iteracion

    <TestInitialize>
    Public Sub Inicialice()
        ' Inicialice el escenario valido aquí
        iteracion = New Iteracion
        iteracion.HayInformacionDePuntosDisponible = True
        iteracion.PuntosPlanificados = 10
        iteracion.PuntosTerminados = 8
        iteracion.HayInformacionDeDiasDisponible = True
        iteracion.CapacidadDelEquipo = 100
        iteracion.DiasNoEfectivos = 20
    End Sub

    <TestMethod()>
    Public Sub TodosSonValidos()
        ValidacionDeEstadisticas.ValideEstadisticas(Iteracion)
    End Sub

    <TestMethod()>
    Public Sub SiNoHayInformacionDePuntosDisponibleNoSeValidan()
        iteracion.HayInformacionDePuntosDisponible = False
        iteracion.PuntosPlanificados = -1
        iteracion.PuntosTerminados = -1

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosPlanificadosNoDebenSerNegativos()
        iteracion.PuntosPlanificados = -1

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub PuntosPlanificadosPuedenSerCero()
        iteracion.PuntosPlanificados = 0

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosPlanificadosTieneUnMaximoDe100Puntos()
        iteracion.PuntosPlanificados = 101

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub PuntosPlanificadosPuedenSerElMáximoPermitido()
        iteracion.PuntosPlanificados = 100

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosTerminadosNoDebenSerNegativos()
        iteracion.PuntosTerminados = -1

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub PuntosTerminadosPuedenSerCero()
        iteracion.PuntosTerminados = 0

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub PuntosTerminadosTieneUnMaximoDe100Puntos()
        iteracion.PuntosTerminados = 101

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub PuntosTerminadosPuedenSerElMáximoPermitido()
        iteracion.PuntosTerminados = 100

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub SiNoHayInformacionDeDíasDisponibleNoSeValidan()
        iteracion.HayInformacionDeDiasDisponible = False
        iteracion.CapacidadDelEquipo = -1
        iteracion.DiasNoEfectivos = -1
        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub CapacidadDelEquipoNoDebenSerNegativa()
        iteracion.CapacidadDelEquipo = -0.01

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub CapacidadDelEquipoPuedeSerCero()
        iteracion.CapacidadDelEquipo = 0
        iteracion.DiasNoEfectivos = 0

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub CapacidadDelEquipoTieneUnMaximoDe1000Dias()
        iteracion.CapacidadDelEquipo = 1000.01

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub CapacidadDelEquipoPuedeSerElMáximoPermitido()
        iteracion.CapacidadDelEquipo = 1000

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub DiasNoEfectivosNoDebenSerNegativo()
        iteracion.DiasNoEfectivos = -0.01

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub DiasNoEfectivosPuedeSerCero()
        iteracion.DiasNoEfectivos = 0

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub DiasNoEfectivosNoPuedeSerMayorALaCapacidadDelEquipo()
        iteracion.DiasNoEfectivos = 100.01

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub

    <TestMethod()>
    Public Sub DiasNoEfectivosPuedeSerIgualALaCapacidad()
        iteracion.DiasNoEfectivos = 100

        ValidacionDeEstadisticas.ValideEstadisticas(iteracion)
    End Sub
End Class