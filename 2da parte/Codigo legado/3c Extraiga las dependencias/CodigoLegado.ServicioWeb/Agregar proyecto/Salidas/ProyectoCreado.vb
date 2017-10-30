Namespace AgregarProyecto
    Public Class ProyectoCreado
        Public Property Id As Integer
        Public Property Nombre As String
        Public Property FechaDeInicio As Date
        Public Property FechaDeCreacion As Date

        Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
            Dim otroProyecto As ProyectoCreado = CType(otherObject, ProyectoCreado)

            Return Id = otroProyecto.Id _
                And Nombre = otroProyecto.Nombre _
                And FechaDeInicio = otroProyecto.FechaDeInicio _
                And FechaDeCreacion = otroProyecto.FechaDeCreacion
        End Function

    End Class
End Namespace