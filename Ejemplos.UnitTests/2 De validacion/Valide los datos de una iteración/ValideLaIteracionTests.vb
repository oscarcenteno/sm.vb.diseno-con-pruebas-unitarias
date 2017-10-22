<TestClass()>
Public Class ValideLaIteracionTests
    Private fechas As List(Of RangoDeFechas)
    Private numero As Integer
    Private fechaInicial As Date
    Private fechaFinal As Date

    <TestInitialize>
    Public Sub Inicialice()
        ' Inicialice el escenario valido aquí
        numero = 1
        fechaInicial = New Date(2017, 10, 30)
        fechaFinal = New Date(2017, 11, 3)

        fechas = New List(Of RangoDeFechas)
        fechas.Add(New RangoDeFechas With {.FechaInicial = New Date(2017, 10, 16), .FechaFinal = New Date(2017, 10, 20)})
        fechas.Add(New RangoDeFechas With {.FechaInicial = New Date(2017, 10, 23), .FechaFinal = New Date(2017, 10, 27)})
    End Sub

    <TestMethod()>
    Public Sub TodosSonValidos()
        ValidacionDeIteracion.ValideLaIteracion(fechas, numero, fechaInicial, fechaFinal)
    End Sub


    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub NumeroDebeSerPositivo()
        numero = 0

        ValidacionDeIteracion.ValideLaIteracion(fechas, numero, fechaInicial, fechaFinal)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub FechaFinalDebeSerPosteriorALaInicial()
        fechaFinal = New Date(2017, 10, 29)

        ValidacionDeIteracion.ValideLaIteracion(fechas, numero, fechaInicial, fechaFinal)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub LasFechasNoDebenTraslaparALasIteracionesExistentes()
        fechaInicial = New Date(2017, 10, 27)
        fechaFinal = New Date(2017, 10, 29)

        ValidacionDeIteracion.ValideLaIteracion(fechas, numero, fechaInicial, fechaFinal)
    End Sub
End Class