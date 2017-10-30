' NOTE: In order to launch WCF Test Client for testing this service, please select ServicioCrearProyecto.svc or ServicioCrearProyecto.svc.vb at the Solution Explorer and start debugging.
Imports CodigoLegado.ServicioWeb.AgregarProyecto

<ServiceContract()>
Public Class ServicioCrearProyecto
    Private dependencias As Dependencias

    Public Sub New()
        dependencias = New DependenciasConcretas
    End Sub

    Public Sub New(dependencias As Dependencias)
        Me.dependencias = dependencias
    End Sub

    <FaultContract(GetType(ErrorDeValidacionFault))>
    <FaultContract(GetType(ErrorInesperadoFault))>
    <OperationContract()>
    Public Function AgregueUnProyecto(nuevoProyecto As NuevoProyecto) As ProyectoCreado
        ' Algoritmo que obtiene datos de fuentes externas
        Dim fechaActual = dependencias.ObtengaLaFechaActual()

        Try
            ' Algoritmo que obtiene datos de fuentes externas
            Dim proyectosExistentes As List(Of String)
            proyectosExistentes = dependencias.ObtengaLosNombresDeLosProyectosExistentes()

            Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
            Dim proyectoCreado As ProyectoCreado
            proyectoCreado = GeneracionDeProyecto.GenereElProyectoPorCrear(nuevoProyecto, fechaActual)

            ' Algoritmo que envia datos a fuentes externas
            Return dependencias.Guarde(proyectoCreado)
        Catch exception As ArgumentException
            Throw GeneracionDeErrorDeValidacion.GenereElError(exception, fechaActual)
        Catch exception As Exception
            Throw New FaultException("Error inesperado")
        End Try
    End Function
End Class


