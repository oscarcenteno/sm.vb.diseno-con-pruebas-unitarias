Namespace AgregarProyecto
    Public Class Validacion
        Public Shared Sub ValideElNuevoProyecto(nuevoProyecto As NuevoProyecto, proyectosExistentes As IEnumerable(Of String))
            If nuevoProyecto Is Nothing Then
                Throw New ArgumentException("Se requiere indicar la información del nuevo proyecto")
            End If

            Dim nombre As String = nuevoProyecto.Nombre
            Dim nombreSinEspaciosEnBlancoAntesYAlFinal As String = nombre.Trim
            If String.IsNullOrWhiteSpace(nombreSinEspaciosEnBlancoAntesYAlFinal) Then
                Throw New ArgumentException("El nombre es requerido")
            End If

            If nombreSinEspaciosEnBlancoAntesYAlFinal.Length > 200 Then
                Throw New ArgumentException("El nombre tiene un tamaño máximo de 200 caracteres")
            End If

            If ContieneCaracteresEspeciales(nombreSinEspaciosEnBlancoAntesYAlFinal) Then
                Throw New ArgumentException("El nombre sólo puede contener letras y números")
            End If

            If proyectosExistentes.Contains(nombreSinEspaciosEnBlancoAntesYAlFinal) Then
                Throw New ArgumentException("El nombre debe ser único")
            End If

            Dim fechaDeInicio As Date = nuevoProyecto.FechaDeInicio
            If fechaDeInicio = Date.MinValue Then
                Throw New ArgumentException("La fecha de inicio es requerida")
            End If
        End Sub

        Private Shared Function ContieneCaracteresEspeciales(nombre As String) As Boolean
            Return Not nombre.All(Function(c) Char.IsLetterOrDigit(c) Or Char.IsWhiteSpace(c))
        End Function
    End Class
End Namespace