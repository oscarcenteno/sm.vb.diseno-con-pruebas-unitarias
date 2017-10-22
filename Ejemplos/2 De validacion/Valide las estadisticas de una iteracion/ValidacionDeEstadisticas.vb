Public Class ValidacionDeEstadisticas
    Public Shared Sub ValideEstadisticas(puntosPlanificados As Integer, puntosTerminados As Integer, capacidadDelEquipo As Decimal, tiempoNoEfectivo As Decimal)

        If puntosPlanificados < 0 Then
            Throw New ArgumentException("Puntos planificados debe ser un número entero positivo")
        End If

        If puntosPlanificados > 100 Then
            Throw New ArgumentException("Puntos planificados tiene un maximo de 100 puntos")
        End If

        If puntosTerminados < 0 Then
            Throw New ArgumentException("Puntos terminados debe ser un número entero positivo")
        End If

        If puntosTerminados > 100 Then
            Throw New ArgumentException("Puntos terminados tiene un maximo de 100 puntos")
        End If

        If capacidadDelEquipo < 0 Then
            Throw New ArgumentException("Capacidad del equipo debe ser un número positivo")
        End If

        If capacidadDelEquipo > 1000 Then
            Throw New ArgumentException("Capacidad del equipo tiene un máximo de 1000 días")
        End If

        If tiempoNoEfectivo < 0 Then
            Throw New ArgumentException("Tiempo no efectivo debe ser un número positivo")
        End If

        If tiempoNoEfectivo > capacidadDelEquipo Then
            Throw New ArgumentException("Tiempo no efectivo debe ser igual o menor a la Capacidad del equipo")
        End If

    End Sub

End Class
