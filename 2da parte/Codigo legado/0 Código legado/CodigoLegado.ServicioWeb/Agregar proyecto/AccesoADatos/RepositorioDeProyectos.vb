Imports System.IO
Imports CsvHelper

Namespace AgregarProyecto
    Friend Class RepositorioDeProyectos
        Friend Shared Function Guarde(proyectoCreado As ProyectoCreado) As ProyectoCreado

            Dim proyectosActuales As List(Of ProyectoCreado)
            Dim cantidadActual As Integer

            Using sr = New StreamReader("c:\code\csvDatabase\proyectos.csv")
                Dim reader = New CsvReader(sr)
                proyectosActuales = reader.GetRecords(Of ProyectoCreado).ToList
                cantidadActual = proyectosActuales.Count
            End Using

            proyectoCreado.Id = cantidadActual + 1
            proyectosActuales.Add(proyectoCreado)

            Using sr = New StreamWriter("c:\code\csvDatabase\proyectos.csv")
                Dim writer = New CsvWriter(sr)
                writer.WriteHeader(Of ProyectoCreado)()
                writer.NextRecord()

                writer.WriteRecords(proyectosActuales)
                writer.NextRecord()
            End Using

            Return proyectoCreado
        End Function

        Friend Shared Function ObtengaLosNombresDeLosProyectosExistentes() As List(Of String)
            Using sr = New StreamReader("c:\code\csvDatabase\proyectos.csv")
                Dim reader = New CsvReader(sr)

                'CSVReader will now read the whole file into an enumerable
                Dim records As IEnumerable(Of ProyectoCreado) = reader.GetRecords(Of ProyectoCreado)()

                Dim nombres = records.Select(Function(c) c.Nombre)

                Return New List(Of String)(nombres)
            End Using
        End Function
    End Class
End Namespace
