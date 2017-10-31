Imports ServicioWeb.MuestraLasMetricasDeUnProyecto

<ServiceContract()>
Public Class ServicioConsulteLasMetricasDelProyecto
    Private dependencias As Dependencias

    Public Sub New()
        dependencias = New DependenciasConcretas
    End Sub

    Public Sub New(dependencias As Dependencias)
        Me.dependencias = dependencias
    End Sub

    <FaultContract(GetType(ProyectoNoExisteFault))>
    <OperationContract()>
    Public Function ConsulteLasMetricasDelProyecto(id As Integer) As ReporteDeMetricas
        Dim proyecto As Proyecto

        Try
            proyecto = dependencias.ObtengaElProyecto(id)
        Catch ex As Exception
            Throw New FaultException("Error inesperado")
        End Try

        If proyecto IsNot Nothing Then
            Return GeneracionDelReporte.GenereElReporteDeMetricas(proyecto)
        Else
            Dim fechaActual As Date = dependencias.ObtengaLaFechaActual()
            Throw GeneracionDelErrorProyectoNoExiste.GenereElErrorDeProyectoInexistente(id, fechaActual)
        End If
    End Function
End Class