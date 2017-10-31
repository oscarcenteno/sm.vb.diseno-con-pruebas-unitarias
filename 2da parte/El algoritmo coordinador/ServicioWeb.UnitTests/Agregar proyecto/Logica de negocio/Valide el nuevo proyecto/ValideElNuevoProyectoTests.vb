Imports ServicioWeb.AgregarProyecto

<TestClass()> Public Class ValideElNuevoProyectoTests
    Dim nuevoProyecto As NuevoProyecto
    Dim proyectosExistentes As IEnumerable(Of String)

    <TestInitialize> Public Sub Inicialice()
        nuevoProyecto = New NuevoProyecto
        nuevoProyecto.Nombre = "Proyecto Asombroso"
        nuevoProyecto.FechaDeInicio = New Date(2018, 10, 26)

        proyectosExistentes = {"Proyecto 1", "Proyecto 2"}

    End Sub

    <TestMethod()> Public Sub SonValidos()
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub ElProyectoNoDebeSerNulo()
        nuevoProyecto = Nothing
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub ElNombreEsRequerido()
        nuevoProyecto.Nombre = String.Empty
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub ElNombreTieneUnTamañoMáximoDe200Caracteres()
        nuevoProyecto.Nombre = "123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901"
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub ElNombreNoPuedeContenerSolamenteEspaciosEnBlanco()
        nuevoProyecto.Nombre = "   "
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub ElNombreSóloPuedeContenerLetrasYNúmeros()
        nuevoProyecto.Nombre = "Hola-Mundo"
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub ElNombreDebeSerÚnico()
        nuevoProyecto.Nombre = "Proyecto 1"
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

    <TestMethod(), ExpectedException(GetType(ArgumentException))>
    Public Sub LaFechaDeInicioEsRequerida()
        nuevoProyecto.FechaDeInicio = Nothing
        Validacion.ValideElNuevoProyecto(nuevoProyecto, proyectosExistentes)
    End Sub

End Class