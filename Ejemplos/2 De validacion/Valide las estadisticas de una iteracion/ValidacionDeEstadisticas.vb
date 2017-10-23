Public Class ValidacionDeEstadisticas
    Public Shared Sub ValideEstadisticas(iteracion As Iteracion)

        If iteracion.HayInformacionDePuntosDisponible Then
            If iteracion.PuntosPlanificados < 0 Then
                Throw New ArgumentException("Puntos planificados debe ser un número entero positivo")
            End If

            If iteracion.PuntosPlanificados > 100 Then
                Throw New ArgumentException("Puntos planificados tiene un maximo de 100 puntos")
            End If

            If iteracion.PuntosTerminados < 0 Then
                Throw New ArgumentException("Puntos terminados debe ser un número entero positivo")
            End If

            If iteracion.PuntosTerminados > 100 Then
                Throw New ArgumentException("Puntos terminados tiene un maximo de 100 puntos")
            End If
        End If

        If iteracion.CapacidadDelEquipo < 0 Then
            Throw New ArgumentException("Capacidad del equipo debe ser un número positivo")
        End If

        If iteracion.CapacidadDelEquipo > 1000 Then
            Throw New ArgumentException("Capacidad del equipo tiene un máximo de 1000 días")
        End If

        If iteracion.TiempoNoEfectivo < 0 Then
            Throw New ArgumentException("Tiempo no efectivo debe ser un número positivo")
        End If

        If iteracion.TiempoNoEfectivo > iteracion.CapacidadDelEquipo Then
            Throw New ArgumentException("Tiempo no efectivo debe ser igual o menor a la Capacidad del equipo")
        End If
    End Sub
End Class
