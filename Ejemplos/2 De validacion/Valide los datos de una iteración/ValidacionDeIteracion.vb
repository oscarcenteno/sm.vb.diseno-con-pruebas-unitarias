Public Class ValidacionDeIteracion

    Public Shared Sub ValideLaIteracion(fechas As List(Of RangoDeFechas), numero As Integer, fechaInicial As Date, fechaFinal As Date)
        If numero < 1 Then
            Throw New ArgumentException("Número debe ser positivo")
        End If

        If fechaFinal <= fechaInicial Then
            Throw New ArgumentException("Fecha final debe ser posterior a la inicial")
        End If

        If fechaFinal <= fechaInicial Then
            Throw New ArgumentException("Fecha final debe ser posterior a la inicial")
        End If

        For Each otraFecha As RangoDeFechas In fechas
            Dim otraFechaInicial As Date = otraFecha.FechaInicial
            Dim otraFechaFinal As Date = otraFecha.FechaFinal

            If (fechaInicial <= otraFechaFinal And fechaFinal >= otraFechaInicial) Then
                Throw New ArgumentException("Las fechas no deben traslapar a las iteraciones existentes")
            End If
        Next
    End Sub

End Class
