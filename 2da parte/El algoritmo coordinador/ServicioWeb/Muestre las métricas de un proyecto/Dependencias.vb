Imports Ejemplos

Public MustInherit Class Dependencias
    Public MustOverride Function ObtengaElProyecto(id As Integer) As Proyecto
    Public MustOverride Function ObtengaLaFechaActual() As Date
End Class