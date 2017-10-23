Public Class CreacionDeUnNuevoProyecto

    Public Shared Function GenereUnNuevoProyecto(fechaActual As Date, nombre As String, fechaDeInicio As Date) As NuevoProyecto
        Dim nuevoProyecto As New NuevoProyecto
        nuevoProyecto.Nombre = nombre
        nuevoProyecto.FechaDeInicio = fechaDeInicio
        nuevoProyecto.FechaDeCreacion = fechaActual

        Return nuevoProyecto
    End Function

End Class
