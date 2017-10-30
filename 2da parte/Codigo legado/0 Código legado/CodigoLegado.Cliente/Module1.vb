Imports System.ServiceModel
Imports CodigoLegado.Cliente.CodigoLegado.ServicioWeb

Module Module1

    Sub Main()

        Console.WriteLine("Iniciando")

        Dim client As ServicioCrearProyectoClient = Nothing

        Try
            client = New ServicioCrearProyectoClient
            Dim random As New Random()
            Dim id As Integer = random.Next(0, 1000000)

            Dim nuevoProyecto As New NuevoProyecto
            nuevoProyecto.Nombre = "Proyecto asombroso " & id
            nuevoProyecto.FechaDeInicio = New Date(2018, 10, 10)

            client.AgregueUnProyecto(nuevoProyecto)

            client.Close()
        Catch exception As FaultException(Of ErrorDeValidacionFault)
            Console.WriteLine("Error de validacion: " + exception.Detail.Mensaje)

            If client IsNot Nothing Then
                client.Abort()
            End If
        Catch exception As FaultException(Of ErrorInesperadoFault)
            Console.WriteLine("Error inesperado: " + exception.Detail.Mensaje)

            If client IsNot Nothing Then
                client.Abort()
            End If
        End Try


        Console.WriteLine("Finalizado")

        Console.ReadLine()
    End Sub

End Module
