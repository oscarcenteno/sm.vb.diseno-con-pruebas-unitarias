Namespace AgregarProyecto
    Public MustInherit Class Dependencias
        Public MustOverride Function ObtengaLosNombresDeLosProyectosExistentes() As List(Of String)
        Public MustOverride Function Guarde(proyectoCreado As ProyectoCreado) As ProyectoCreado
        Public MustOverride Function ObtengaLaFechaActual() As Date
    End Class
End Namespace


