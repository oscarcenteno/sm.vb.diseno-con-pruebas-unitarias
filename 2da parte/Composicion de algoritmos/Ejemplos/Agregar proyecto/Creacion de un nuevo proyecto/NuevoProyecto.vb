Public Class NuevoProyecto
    Public Property Nombre As String
    Public Property FechaDeInicio As Date
    Public Property FechaDeCreacion As Date

    ' https://msdn.microsoft.com/en-us/library/336aedhh%28v=vs.100%29.aspx?f=255&MSPPError=-2147217396
    Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
        If otherObject Is Nothing Or Not Me.GetType() Is otherObject.GetType() Then
            Return False
        End If
        Dim otroProyecto As NuevoProyecto = CType(otherObject, NuevoProyecto)

        ' Use Equals to compare instance variables.
        Return Nombre = otroProyecto.Nombre _
            And FechaDeInicio = otroProyecto.FechaDeInicio _
            And FechaDeCreacion = otroProyecto.FechaDeCreacion

    End Function
End Class
