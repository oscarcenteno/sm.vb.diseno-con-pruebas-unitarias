Public Class GeneracionDeLaValoracionDeLasEmisionesEnColones

    Public Shared Function GenereLaValoracionDeLasEmisionesEnColones(fechaActual As Date,
                                                                     informacionOficial As List(Of InformacionOficial),
                                                                     emisiones As List(Of Emision)) As List(Of Valoracion)

        Dim valoraciones As New List(Of Valoracion)

        For Each emision In emisiones
            Dim informacionOficialEspecifica As InformacionOficial
            informacionOficialEspecifica = informacionOficial.Where(Function(c) c.ISIN = emision.ISIN).First

            Dim valoracion As Valoracion
            valoracion = GeneracionDeLaValoracionDeUnaEmisionEnColones.GenereLaValoracion(fechaActual, informacionOficialEspecifica, emision)

            valoraciones.Add(valoracion)
        Next

        Return valoraciones
    End Function

End Class
