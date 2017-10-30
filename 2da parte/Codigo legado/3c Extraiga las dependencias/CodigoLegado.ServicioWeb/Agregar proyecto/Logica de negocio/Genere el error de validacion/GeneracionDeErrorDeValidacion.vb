Namespace AgregarProyecto
    Public Class GeneracionDeErrorDeValidacion
        Public Shared Function GenereElError(exception As ArgumentException, fechaActual As Date) As FaultException(Of ErrorDeValidacionFault)
            ' Algoritmo de generación
            Dim fault As New ErrorDeValidacionFault
            fault.Mensaje = exception.Message
            fault.Fecha = fechaActual
            Dim razon As String = "Error de validación, consulte el detalle."

            Return New FaultException(Of ErrorDeValidacionFault)(fault, razon)
        End Function
    End Class
End Namespace