<TestClass()>
Public Class ValideLaIteracionTests
    Private fechasDeOtrasIteraciones As List(Of RangoDeFechas)
    Private iteracion As Iteracion

    <TestInitialize>
    Public Sub Inicialice()
        ' Inicialice el escenario valido aquí
        iteracion = New Iteracion
        iteracion.Numero = 1
        iteracion.FechaInicial = New Date(2017, 10, 30)
        iteracion.FechaFinal = New Date(2017, 11, 3)

        fechasDeOtrasIteraciones = New List(Of RangoDeFechas)
        fechasDeOtrasIteraciones.Add(New RangoDeFechas With {.FechaInicial = New Date(2017, 10, 16), .FechaFinal = New Date(2017, 10, 20)})
        fechasDeOtrasIteraciones.Add(New RangoDeFechas With {.FechaInicial = New Date(2017, 10, 23), .FechaFinal = New Date(2017, 10, 27)})
    End Sub

    <TestMethod()>
    Public Sub TodosSonValidos()
        ValidacionDeIteracion.ValideLaIteracion(fechasDeOtrasIteraciones, iteracion)
    End Sub


    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub NumeroDebeSerPositivo()
        iteracion.Numero = 0

        ValidacionDeIteracion.ValideLaIteracion(fechasDeOtrasIteraciones, iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub FechaFinalDebeSerPosteriorALaInicial()
        iteracion.FechaFinal = New Date(2017, 10, 29)

        ValidacionDeIteracion.ValideLaIteracion(fechasDeOtrasIteraciones, iteracion)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub LasFechasNoDebenTraslaparALasIteracionesExistentes()
        iteracion.FechaInicial = New Date(2017, 10, 27)
        iteracion.FechaFinal = New Date(2017, 10, 29)

        ValidacionDeIteracion.ValideLaIteracion(fechasDeOtrasIteraciones, iteracion)
    End Sub
End Class