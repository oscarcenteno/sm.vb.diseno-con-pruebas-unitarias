Namespace AgregarProyecto
    Public Class DependenciasConcretas
        Inherits Dependencias

        Public Overrides Function ObtengaLosNombresDeLosProyectosExistentes() As List(Of String)
            Return RepositorioDeProyectos.ObtengaLosNombresDeLosProyectosExistentes()
        End Function

        Public Overrides Function Guarde(proyectoCreado As ProyectoCreado) As ProyectoCreado
            Return RepositorioDeProyectos.Guarde(proyectoCreado)
        End Function

        Public Overrides Function ObtengaLaFechaActual() As Date
            Return Date.Now
        End Function
    End Class
End Namespace

