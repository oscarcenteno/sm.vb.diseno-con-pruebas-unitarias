Namespace AgregarProyecto
    Public Class Dependencias
        Public Function ObtengaLosNombresDeLosProyectosExistentes() As List(Of String)
            Return RepositorioDeProyectos.ObtengaLosNombresDeLosProyectosExistentes()
        End Function

        Friend Function Guarde(proyectoCreado As ProyectoCreado) As ProyectoCreado
            Return RepositorioDeProyectos.Guarde(proyectoCreado)
        End Function

        Friend Function ObtengaLaFechaActual() As Date
            Return Date.Now
        End Function
    End Class
End Namespace