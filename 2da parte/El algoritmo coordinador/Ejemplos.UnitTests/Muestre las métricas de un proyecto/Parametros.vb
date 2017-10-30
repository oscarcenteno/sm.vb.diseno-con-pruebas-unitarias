Public Class Parametros
    Public Shared Function ObtengaElProyecto() As Proyecto
        Dim proyecto As New Proyecto
        proyecto.Nombre = "Proyecto Asombroso"
        proyecto.Iteraciones = ObtengaLasIteraciones()

        Return proyecto
    End Function

    Public Shared Function ObtengaLasIteraciones() As List(Of Iteracion)
        Dim lista As New List(Of Iteracion)
        lista.Add(CreeIteracion(1, New Date(2017, 10, 16), New Date(2017, 10, 20), True, 10, 8, True, 100, 5))
        lista.Add(CreeIteracion(2, New Date(2017, 10, 23), New Date(2017, 10, 27), False, 0, 0, True, 35, 10))
        lista.Add(CreeIteracion(3, New Date(2017, 10, 30), New Date(2017, 11, 3), False, 0, 0, False, 0, 0))

        Return lista
    End Function

    Private Shared Function CreeIteracion(numero As Integer, fechaInicial As Date, fechaFinal As Date, hayInformacionDePuntosDisponible As Boolean, puntosPlanificados As Integer, puntosTerminados As Integer, HayInformacionDeDiasDisponible As Boolean, capacidadDelEquipo As Integer, diasNoEfectivos As Integer) As Iteracion
        Return New Iteracion With {
            .Numero = numero,
            .FechaInicial = fechaInicial,
            .FechaFinal = fechaFinal,
            .HayInformacionDePuntosDisponible = hayInformacionDePuntosDisponible,
            .PuntosPlanificados = puntosPlanificados,
            .PuntosTerminados = puntosTerminados,
            .HayInformacionDeDiasDisponible = HayInformacionDeDiasDisponible,
            .CapacidadDelEquipo = capacidadDelEquipo,
            .DiasNoEfectivos = diasNoEfectivos
            }
    End Function


End Class
