Public Class auxCalculos


    Public Shared Function PorcentajeRenta(Ingreso As Double, Utilidad As Double) As Double
        Dim dts As New dtsCalculos
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Select * From dbo.ParametroRentaHacienda"
        bdAcceso.Cargar(cmd, dts.ParametroRentaHacienda)

        Dim montoIngreso As Double = 0
        Dim porcIngreso As Double = 0

        For Each pa As dtsCalculos.ParametroRentaHaciendaRow In dts.ParametroRentaHacienda

            If Not pa.SobreRentaBruta Then
                montoIngreso = pa.SalarioDesde
                porcIngreso = pa.Porcentaje
            End If

        Next
        If Ingreso > montoIngreso Then

            Return porcIngreso

        Else
            For Each pa As dtsCalculos.ParametroRentaHaciendaRow In dts.ParametroRentaHacienda
                If pa.SobreRentaBruta Then
                    If Not pa.SinLimiteHasta Then
                        If comparacion(Utilidad, pa.ComparacionDesde, pa.SalarioDesde) And comparacion(Utilidad, pa.ComparacionHasta, pa.SalarioHasta) Then
                            Return pa.Porcentaje
                        End If
                    Else
                        If comparacion(Utilidad, pa.ComparacionDesde, pa.SalarioDesde) Then
                            Return pa.Porcentaje
                        End If
                    End If
                End If
            Next
        End If

        Return 0

    End Function

    Private Shared Function comparacion(monto As Double, comparar As String, montoPar As Double) As Boolean
        If comparar.Equals("<") Then
            Return monto < montoPar
        End If
        If comparar.Equals(">") Then
            Return monto > montoPar
        End If
        Return monto = montoPar
    End Function

    Public Shared Function MontoRenta(IngresoBruto As Double, Utilidad As Double) As Double
        Dim monto As Double = IngresoBruto * PorcentajeRenta(IngresoBruto, Utilidad)
        Return monto

    End Function

End Class
