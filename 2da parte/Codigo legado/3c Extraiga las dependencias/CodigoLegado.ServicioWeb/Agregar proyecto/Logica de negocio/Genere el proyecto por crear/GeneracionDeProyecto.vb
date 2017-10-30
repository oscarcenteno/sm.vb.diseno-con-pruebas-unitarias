Namespace AgregarProyecto
    Public Class GeneracionDeProyecto
        Public Shared Function GenereElProyectoPorCrear(nuevoProyecto As NuevoProyecto, fechaActual As Date) As ProyectoCreado
            ' Algoritmo de generacion
            Dim nombre As String = nuevoProyecto.Nombre
            Dim nombreSinEspacios As String = nombre.Trim()

            Dim proyectoCreado As New ProyectoCreado With {
                .Nombre = nombreSinEspacios,
                .FechaDeInicio = nuevoProyecto.FechaDeInicio,
                .FechaDeCreacion = fechaActual
            }

            Return proyectoCreado
        End Function
    End Class
End Namespace