Public Class GeneracionDelErrorProyectoInexistente
    Public Shared Function GenereElErrorDeProyectoInexistente(id As Integer, fechaActual As Date) As FaultException(Of ProyectoNoExisteFault)
        Dim fault As New ProyectoNoExisteFault With {
            .Mensaje = String.Format("El proyecto con Id {0} no existe", id),
            .Fecha = fechaActual
        }
        Dim razon As String = "Proyecto inexistente."

        Dim excepcion As New FaultException(Of ProyectoNoExisteFault)(fault, razon)

        Return excepcion
    End Function

End Class
