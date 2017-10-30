Imports Ejemplos

Namespace MuestraLasMetricasDeUnProyecto
    <ServiceContract()>
    Public Class ServicioConsulteLasMetricas
        Private dependencias As Dependencias

        Public Sub New()
            dependencias = New DependenciasConcretas
        End Sub

        Public Sub New(dependencias As Dependencias)
            Me.dependencias = dependencias
        End Sub

        <OperationContract()>
        Public Function ConsulteLasMetricasDelProyecto(id As Integer)
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
                Throw GeneracionDelErrorProyectoInexistente.GenereElErrorDeProyectoInexistente(id, fechaActual)
            End If
        End Function
    End Class
End Namespace