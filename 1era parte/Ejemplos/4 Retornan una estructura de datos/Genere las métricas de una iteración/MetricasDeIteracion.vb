Public Class MetricasDeIteracion
    Public Property Iteracion As Integer
    Public Property FechaInicial As Date
    Public Property FechaFinal As Date

    Public Property MetricaDePuntos As String
    Public Property MetricaDeTiempoNoEfectivo As String

    ' https://msdn.microsoft.com/en-us/library/336aedhh%28v=vs.100%29.aspx?f=255&MSPPError=-2147217396
    Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
        If otherObject Is Nothing Or Not Me.GetType() Is otherObject.GetType() Then
            Return False
        End If
        Dim otrasMetricas As MetricasDeIteracion = CType(otherObject, MetricasDeIteracion)

        ' Use Equals to compare instance variables.
        Return Iteracion = otrasMetricas.Iteracion _
            And FechaInicial = otrasMetricas.FechaInicial _
            And FechaFinal = otrasMetricas.FechaFinal _
            And MetricaDePuntos = otrasMetricas.MetricaDePuntos _
            And MetricaDeTiempoNoEfectivo = otrasMetricas.MetricaDeTiempoNoEfectivo

    End Function

End Class
