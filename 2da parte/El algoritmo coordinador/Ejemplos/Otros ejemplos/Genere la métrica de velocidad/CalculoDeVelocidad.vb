Public Class CalculoDeVelocidad
    Public Shared Function CalculeLaVelocidad(historias As List(Of Historia), iteracion As Integer) As Integer
        Dim velocidad As Integer

        For Each historia In historias
            If historia.TerminadaEnLaIteracion = iteracion Then
                velocidad += historia.Puntos
            End If
        Next

        Return velocidad
    End Function
End Class
