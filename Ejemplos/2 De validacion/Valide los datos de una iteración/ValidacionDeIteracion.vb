Public Class ValidacionDeIteracion

    Public Shared Sub ValideLaIteracion(fechasDeOtrasIteraciones As List(Of RangoDeFechas), iteracion As Iteracion)
        If iteracion.Numero < 1 Then
            Throw New ArgumentException("Número debe ser positivo")
        End If

        If iteracion.FechaFinal <= iteracion.FechaInicial Then
            Throw New ArgumentException("Fecha final debe ser posterior a la inicial")
        End If

        If iteracion.FechaFinal <= iteracion.FechaInicial Then
            Throw New ArgumentException("Fecha final debe ser posterior a la inicial")
        End If

        For Each otraFecha As RangoDeFechas In fechasDeOtrasIteraciones
            Dim otraFechaInicial As Date = otraFecha.FechaInicial
            Dim otraFechaFinal As Date = otraFecha.FechaFinal

            If (iteracion.FechaInicial <= otraFechaFinal And iteracion.FechaFinal >= otraFechaInicial) Then
                Throw New ArgumentException("Las fechas no deben traslapar a las iteraciones existentes")
            End If
        Next
    End Sub

End Class
