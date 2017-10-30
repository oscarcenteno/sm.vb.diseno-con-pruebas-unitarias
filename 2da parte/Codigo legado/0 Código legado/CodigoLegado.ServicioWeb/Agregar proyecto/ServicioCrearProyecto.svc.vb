' NOTE: In order to launch WCF Test Client for testing this service, please select ServicioCrearProyecto.svc or ServicioCrearProyecto.svc.vb at the Solution Explorer and start debugging.
Imports CodigoLegado.ServicioWeb.AgregarProyecto

<ServiceContract()>
Public Class ServicioCrearProyecto

    <FaultContract(GetType(ErrorDeValidacionFault))>
    <FaultContract(GetType(ErrorInesperadoFault))>
    <OperationContract()>
    Public Function AgregueUnProyecto(nuevoProyecto As NuevoProyecto) As ProyectoCreado
        Dim response As ProyectoCreado

        Try
            If nuevoProyecto Is Nothing Then
                Throw New ArgumentException("Se requiere indicar la información del nuevo proyecto")
            End If

            Dim nombre As String = nuevoProyecto.Nombre
            If String.IsNullOrWhiteSpace(nombre) Then
                Throw New ArgumentException("El nombre es requerido")
            End If

            If nombre.Length > 200 Then
                Throw New ArgumentException("El nombre tiene un tamaño máximo de 200 caracteres")
            End If

            If String.IsNullOrWhiteSpace(nombre) Then
                Throw New ArgumentException("El nombre no puede contener solamente espacios en blanco")
            End If

            If ContieneCaracteresEspeciales(nombre) Then
                Throw New ArgumentException("El nombre sólo puede contener letras y números")
            End If

            Dim proyectosExistentes As List(Of String)
            proyectosExistentes = RepositorioDeProyectos.ObtengaLosNombresDeLosProyectosExistentes()

            If proyectosExistentes.Contains(nombre) Then
                Throw New ArgumentException("El nombre debe ser único")
            End If

            Dim fechaDeInicio As Date = nuevoProyecto.FechaDeInicio
            If fechaDeInicio = Date.MinValue Then
                Throw New ArgumentException("La fecha de inicio es requerida")
            End If

            Dim nombreSinEspacios As String = nombre.Trim()
            Dim proyectoCreado As New ProyectoCreado With {
                .Nombre = nombreSinEspacios,
                .FechaDeInicio = nuevoProyecto.FechaDeInicio,
                .FechaDeCreacion = Date.Now
            }

            response = RepositorioDeProyectos.Guarde(proyectoCreado)
        Catch exception As ArgumentException
            Dim fault As New ErrorDeValidacionFault
            fault.Mensaje = exception.Message
            fault.Fecha = Date.Now

            Dim razon As String = "Error de validación, consulte el detalle."
            Dim nuevaExcepcion As New FaultException(Of ErrorDeValidacionFault)(fault, razon)

            Throw nuevaExcepcion
        Catch exception As Exception
            Dim fault As New ErrorInesperadoFault With {
                .Mensaje = exception.Message,
                .Fecha = Date.Now
            }
            Dim razon As String = "Error inesperado."
            Dim nuevaExcepcion As New FaultException(Of ErrorInesperadoFault)(fault, razon)

            Throw nuevaExcepcion
        End Try

        Return response
    End Function

    Private Shared Function ContieneCaracteresEspeciales(nombre As String) As Boolean
        Return Not nombre.All(Function(c) Char.IsLetterOrDigit(c) Or Char.IsWhiteSpace(c))
    End Function
End Class
