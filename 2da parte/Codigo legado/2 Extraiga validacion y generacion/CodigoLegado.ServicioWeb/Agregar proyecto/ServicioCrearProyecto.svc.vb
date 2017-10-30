﻿' NOTE: In order to launch WCF Test Client for testing this service, please select ServicioCrearProyecto.svc or ServicioCrearProyecto.svc.vb at the Solution Explorer and start debugging.
Imports CodigoLegado.ServicioWeb.AgregarProyecto

<ServiceContract()>
Public Class ServicioCrearProyecto

    <FaultContract(GetType(ErrorDeValidacionFault))>
    <FaultContract(GetType(ErrorInesperadoFault))>
    <OperationContract()>
    Public Function AgregueUnProyecto(nuevoProyecto As NuevoProyecto) As ProyectoCreado
        ' Algoritmo que obtiene datos de fuentes externas
        Dim fechaActual As Date = Date.Now

        Try
            ' Algoritmo que obtiene datos de fuentes externas
            Dim proyectosExistentes As List(Of String) = RepositorioDeProyectos.ObtengaLosNombresDeLosProyectosExistentes()

            Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
            Dim proyectoCreado As ProyectoCreado = GeneracionDeProyecto.GenereElProyectoPorCrear(nuevoProyecto, fechaActual)

            ' Algoritmo que envia datos a fuentes externas
            Return RepositorioDeProyectos.Guarde(proyectoCreado)
        Catch exception As ArgumentException
            Dim nuevaExcepcion As FaultException(Of ErrorDeValidacionFault) = GeneracionDeErrorDeValidacion.GenereElError(exception, fechaActual)

            Throw nuevaExcepcion
        Catch exception As Exception
            Dim nuevaExcepcion As FaultException(Of ErrorInesperadoFault) = GeneracionDeErrorInesperado.GenereElError(exception, fechaActual)

            Throw nuevaExcepcion
        End Try
    End Function

End Class
