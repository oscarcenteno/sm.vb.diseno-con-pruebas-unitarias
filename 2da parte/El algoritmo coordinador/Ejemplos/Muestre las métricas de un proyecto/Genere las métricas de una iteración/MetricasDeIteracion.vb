Public Class MetricasDeIteracion
    Public Property Iteracion As Integer
    Public Property FechaInicial As Date
    Public Property FechaFinal As Date

    Public Property MetricaDePuntos As String
    Public Property MetricaDeTiempoNoEfectivo As String

    ' https://msdn.microsoft.com/en-us/library/336aedhh%28v=vs.100%29.aspx?f=255&MSPPError=-2147217396
    Public Overloads Overrides Function Equals(otherObject As Object) As Boolean
        Dim otrasMetricas As MetricasDeIteracion = CType(otherObject, MetricasDeIteracion)

        Return Equals(otrasMetricas)
    End Function

    Public Overloads Function Equals(otrasMetricas As MetricasDeIteracion) As Boolean
        Return Iteracion = otrasMetricas.Iteracion _
            And FechaInicial = otrasMetricas.FechaInicial _
            And FechaFinal = otrasMetricas.FechaFinal _
            And MetricaDePuntos = otrasMetricas.MetricaDePuntos _
            And MetricaDeTiempoNoEfectivo = otrasMetricas.MetricaDeTiempoNoEfectivo
    End Function

End Class
