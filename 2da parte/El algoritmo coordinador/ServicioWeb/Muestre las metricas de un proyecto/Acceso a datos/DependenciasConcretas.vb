Namespace MuestraLasMetricasDeUnProyecto
    Friend Class DependenciasConcretas
        Inherits Dependencias

        Public Overrides Function ObtengaElProyecto(id As Integer) As Proyecto
            Throw New NotImplementedException()
        End Function

        Public Overrides Function ObtengaLaFechaActual() As Date
            Throw New NotImplementedException()
        End Function
    End Class
End Namespace