Namespace AgregarProyecto
    Public Class GeneracionDeErrorInesperado
        Public Shared Function GenereElError(exception As Exception, fechaActual As Date) As FaultException(Of ErrorInesperadoFault)
            ' Algoritmo de generación
            Dim fault As New ErrorInesperadoFault With {
                .Mensaje = exception.Message,
                .Fecha = fechaActual
            }
            Dim razon As String = "Error inesperado."

            Return New FaultException(Of ErrorInesperadoFault)(fault, razon)
        End Function
    End Class
End Namespace