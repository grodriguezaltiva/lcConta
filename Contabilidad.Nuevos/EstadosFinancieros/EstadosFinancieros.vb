Imports System.ComponentModel
Imports System.Threading
Public Class EstadosFinancieros
    Dim hacer As New BackgroundWorker
    Private Shared dts As New dtsEstadosFinancieros
    Public Shared Function BalanceSitacion(EsBalance As Boolean, EsMensual As Boolean, Moneda As Integer, MonedaNombre As String, CantPeriodos As Integer, Mes As Integer, MesNombre As String, Año As Integer, ExcluirCierre As Boolean, Nivel As Integer) As rptBalanceSituacion

        Dim cmd As New SqlClient.SqlCommand
        dts = New dtsEstadosFinancieros
        cmd.CommandText = "Select Empresa, Cedula AS Juridica, Tel_01 As Telefono, Tel_01 As Telefono2, Email, Logo As Foto , Dirrecion_Web AS SitioWeb, PersonaJuridica AS NombreJuridico  From configuraciones"
        bdAcceso.Cargar(cmd, dts.configuracion)
        Dim fecha As DateTime
        Dim fp2 As DateTime
        Dim fp3 As DateTime
        Dim fp1 As DateTime

        If EsMensual Then
            fecha = "01/" & Mes & "/" & Año
            fp1 = fecha
            fp1 = fp1.AddMonths(1)
            fp1 = fp1.AddDays(-1)


            fecha = fecha.AddMonths(-1)
            fp2 = fecha
            fp2 = fp2.AddMonths(1)
            fp2 = fp2.AddDays(-1)

            fecha = fecha.AddMonths(-1)
            fp3 = fecha
            fp3 = fp3.AddMonths(1)
            fp3 = fp3.AddDays(-1)
        Else
            fecha = "01/" & Mes & "/" & Año
            fp1 = fecha
            fp1 = fp1.AddMonths(1)
            fp1 = fp1.AddDays(-1)


            fecha = "01/" & Mes & "/" & (Año - 1)
            fp2 = fecha
            fp2 = fp2.AddMonths(1)
            fp2 = fp2.AddDays(-1)

            fecha = "01/" & Mes & "/" & (Año - 2)
            fp3 = fecha
            fp3 = fp3.AddMonths(1)
            fp3 = fp3.AddDays(-1)
        End If

        cmd.CommandText = consulta(CantPeriodos, Moneda)
        cmd.Parameters.AddWithValue("@fp1", fp1)
        cmd.Parameters.AddWithValue("@fp2", fp2)
        cmd.Parameters.AddWithValue("@fp3", fp3)

        bdAcceso.Cargar(cmd, dts.Resultados)

        Calculos(dts)

        For Each linea In dts.Resultados
            If linea.Movimientos Then
                SumarPadre(linea, dts, linea.PARENTID)
            End If
        Next
        GenerarSubTotales(Nivel, dts)

        Dim Titulo As String = ""
        Dim TipoReporte As String = ""
        If EsBalance Then
            Titulo = "Balance Situación"
            TipoReporte = "Balance"
        Else
            Titulo = "Estado Resultado"
            TipoReporte = "Estado"
        End If

        If CantPeriodos > 1 Then
            If EsMensual Then
                Titulo &= " Compartivo Mensual"
            Else
                Titulo &= " Comparativo Anual"
            End If
        End If
        Dim periodo1 As String = Format(fp1, "MMM") & "/" & fp1.Year
        Dim periodo2 As String = Format(fp2, "MMM") & "/" & fp2.Year
        Dim periodo3 As String = Format(fp3, "MMM") & "/" & fp3.Year
        If CantPeriodos = 1 Then
            periodo2 = "" : periodo3 = ""
        End If
        If CantPeriodos = 2 Then
            periodo3 = ""
        End If

        Dim Filtro As String = ""

        Filtro &= " en " & periodo1 & "" & IIf(periodo2.Equals(""), "", ", " & periodo2) & "" & IIf(periodo2.Equals(""), "", ", " & periodo3)
        If ExcluirCierre Then
            Filtro &= " excluyendo el cierre."
        End If

        If Moneda = 1 Then
            Filtro &= " Colón"
        Else
            Filtro &= " Dolar"
        End If
        Dim rpt As New rptBalanceSituacion
        rpt.SetDataSource(dts)
        rpt.SetParameterValue("Filtros", Filtro)
        rpt.SetParameterValue("Periodo1", periodo1)
        rpt.SetParameterValue("Periodo2", periodo2)
        rpt.SetParameterValue("Periodo3", periodo3)
        rpt.SetParameterValue("Titulo", Titulo)
        rpt.SetParameterValue("Nivel", Nivel)
        rpt.SetParameterValue("TipoReporte", TipoReporte)
        rpt.SetParameterValue("Imprime", usuario)
        Return rpt
    End Function
    Private Shared Sub Calculos(ByRef dts As dtsEstadosFinancieros)
        Dim Ingresos1 As Double = 0
        Dim Gastos1 As Double = 0
        Dim Costos1 As Double = 0

        Dim Ingresos2 As Double = 0
        Dim Gastos2 As Double = 0
        Dim Costos2 As Double = 0

        Dim Ingresos3 As Double = 0
        Dim Gastos3 As Double = 0
        Dim Costos3 As Double = 0

        Dim IngresosCompletos1 As Double = 0
        Dim CostosCompletos1 As Double = 0
        Dim GastosCompletos1 As Double = 0

        Dim IngresosCompletos2 As Double = 0
        Dim CostosCompletos2 As Double = 0
        Dim GastosCompletos2 As Double = 0


        Dim IngresosCompletos3 As Double = 0
        Dim CostosCompletos3 As Double = 0
        Dim GastosCompletos3 As Double = 0

        For Each line As dtsEstadosFinancieros.ResultadosRow In dts.Resultados
            If line.Tipo.Equals("INGRESOS") Then
                If Not line.GastoNoDeducible Then
                    Ingresos1 += line.SaldoAcumulado1
                    Ingresos2 += line.SaldoAcumulado2
                    Ingresos3 += line.SaldoAcumulado3

                End If
                IngresosCompletos1 += line.SaldoAcumulado1
                IngresosCompletos2 += line.SaldoAcumulado2
                IngresosCompletos3 += line.SaldoAcumulado3

            End If
            If line.Tipo.Equals("COSTO VENTA") Then
                If Not line.GastoNoDeducible Then
                    Costos1 += line.SaldoAcumulado1
                    Costos2 += line.SaldoAcumulado2
                    Costos3 += line.SaldoAcumulado3
                End If
                CostosCompletos1 += line.SaldoAcumulado1
                CostosCompletos2 += line.SaldoAcumulado2
                CostosCompletos3 += line.SaldoAcumulado3

            End If
            If line.Tipo.Equals("GASTOS") Then
                If Not line.GastoNoDeducible Then
                    Gastos1 += line.SaldoAcumulado1
                    Gastos2 += line.SaldoAcumulado2
                    Gastos3 += line.SaldoAcumulado3
                End If
                GastosCompletos1 += line.SaldoAcumulado1
                GastosCompletos2 += line.SaldoAcumulado2
                GastosCompletos3 += line.SaldoAcumulado3

            End If
        Next

        Dim UtilidadCompleta1 As Double = IngresosCompletos1 - CostosCompletos1
        Dim UtilidadCompleta2 As Double = IngresosCompletos2 - CostosCompletos2
        Dim UtilidadCompleta3 As Double = IngresosCompletos3 - CostosCompletos3
        addItemTotal(dts, "5zzz", "UTILIDAD BRUTA COMPLETA", UtilidadCompleta1, UtilidadCompleta2, UtilidadCompleta3)

        Dim UtilidadBruta1 As Double = Ingresos1 - Costos1
        Dim UtilidadBruta2 As Double = Ingresos2 - Costos2
        Dim UtilidadBruta3 As Double = Ingresos3 - Costos3
        addItemTotal(dts, "5zzz", "UTILIDAD BRUTA RENTA", UtilidadBruta1, UtilidadBruta2, UtilidadBruta3)

        Dim UtilidadCompletaNeta1 As Double = IngresosCompletos1 - CostosCompletos1 - GastosCompletos1
        Dim UtilidadCompletaNeta2 As Double = IngresosCompletos2 - CostosCompletos2 - GastosCompletos2
        Dim UtilidadCompletaNeta3 As Double = IngresosCompletos3 - CostosCompletos3 - GastosCompletos3
        addItemTotal(dts, "6zzz", "UTILIDAD NETA COMPLETA", UtilidadCompletaNeta1, UtilidadCompletaNeta2, UtilidadCompletaNeta3)

        Dim Utilidad1 As Double = Ingresos1 - Costos1 - Gastos1
        Dim Utilidad2 As Double = Ingresos2 - Costos2 - Gastos2
        Dim Utilidad3 As Double = Ingresos3 - Costos3 - Gastos3
        addItemTotal(dts, "6zzz", "UTILIDAD NETA ANTES RENTA", Utilidad1, Utilidad2, Utilidad3)

        Dim Renta1 As Double = Utilidad1 * auxCalculos.PorcentajeRenta(IngresosCompletos1, Utilidad1)
        Dim Renta2 As Double = Utilidad2 * auxCalculos.PorcentajeRenta(IngresosCompletos2, Utilidad2)
        Dim Renta3 As Double = Utilidad3 * auxCalculos.PorcentajeRenta(IngresosCompletos3, Utilidad3)
        addItemTotal(dts, "6zzz", "RENTA " & auxCalculos.PorcentajeRenta(IngresosCompletos1, Utilidad1) & "%", Renta1, Renta2, Renta3)
        addItemTotal(dts, "6zzz", "UTILIDAD NETA DESPUÉS RENTA", Utilidad1 - Renta1, Utilidad2 - Renta2, Utilidad3 - Renta3)
    End Sub
    Private Shared Sub addItemTotal(ByRef dts As dtsEstadosFinancieros, CuentaContable As String, Descripcion As String, Saldo1 As Double, Saldo2 As Double, Saldo3 As Double)
        Dim linea As dtsEstadosFinancieros.ResultadosRow
        linea = dts.Resultados.NewResultadosRow
        With linea
            .CuentaContable = CuentaContable
            .Descripcion = Descripcion
            .Tipo = "TOTAL"
            .Nivel = -10
            .Movimientos = 0
            .SaldoAcumulado1 = Saldo1
            .SaldoAcumulado2 = Saldo2
            .SaldoAcumulado3 = Saldo3
            .PARENTID = 0
        End With
        dts.Resultados.AddResultadosRow(linea)
    End Sub
    Private Shared Sub addItemSubTotal(ByRef dts As dtsEstadosFinancieros, CuentaContable As String, Descripcion As String, Saldo1 As Double, Saldo2 As Double, Saldo3 As Double, Nivel As Integer)
        Dim linea As dtsEstadosFinancieros.ResultadosRow
        linea = dts.Resultados.NewResultadosRow
        With linea
            .CuentaContable = CuentaContable
            .Descripcion = Descripcion
            .Tipo = "SUBTOTAL"
            .Nivel = Nivel
            .Movimientos = 0
            .SaldoAcumulado1 = Saldo1
            .SaldoAcumulado2 = Saldo2
            .SaldoAcumulado3 = Saldo3
            .PARENTID = 0
        End With
        dts.Resultados.AddResultadosRow(linea)
    End Sub
    Private Shared Sub GenerarSubTotales(Nivel As Integer, ByRef dts As dtsEstadosFinancieros)
        Dim rdts As dtsEstadosFinancieros
        rdts = dts.Copy()
        For Each line As dtsEstadosFinancieros.ResultadosRow In rdts.Resultados
            If Not line.Movimientos And (line.Nivel - Nivel) = -2 Then
                Dim cuenta As String = ""
                For Each hija As dtsEstadosFinancieros.ResultadosRow In rdts.Resultados
                    If line.id = hija.PARENTID Then
                        If cuenta < hija.CuentaContable Then
                            cuenta = hija.CuentaContable
                        End If
                    End If
                Next
                addItemSubTotal(dts, cuenta & "z", "TOTAL " & line.Descripcion, line.SaldoAcumulado1, line.SaldoAcumulado2, line.SaldoAcumulado3, line.Nivel)
            End If
        Next
    End Sub

    Private Shared Function consulta(cantPeriodos As Integer, idMoneda As Integer)
        Dim saldo As String = ""
        If idMoneda = 1 Then
            saldo = "dbo.SaldoColon"
        Else

            saldo = "dbo.SaldoDolar"

        End If

        If cantPeriodos = 3 Then
            Return "Select CuentaContable, Descripcion, " & saldo & "(CuentaContable.CuentaContable,@fp1) as SaldoAcumulado1, " & saldo & "(CuentaContable,@fp2) As SaldoAcumulado2, " & saldo & "(CuentaContable,@fp3) as SaldoAcumulado3, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible From CuentaContable WHERE Inactivo = 0"
        End If
        If cantPeriodos = 2 Then
            Return "Select CuentaContable, Descripcion, " & saldo & "(CuentaContable.CuentaContable,@fp1) as SaldoAcumulado1, " & saldo & "(CuentaContable,@fp2) As SaldoAcumulado2, 0 as SaldoAcumulado3, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible From CuentaContable WHERE Inactivo = 0"
        End If
        If cantPeriodos = 1 Then
            Return "Select CuentaContable, Descripcion, " & saldo & "(CuentaContable.CuentaContable,@fp1) as SaldoAcumulado1, 0 As SaldoAcumulado2, 0 as SaldoAcumulado3, Nivel, Movimiento As Movimientos, PARENTID, id, Tipo, GastoNoDeducible From CuentaContable WHERE Inactivo = 0"
        End If
    End Function
    Private Shared Function Relleno(text As String) As String
        Dim tama As Integer = text.Length
        Dim re As String = ""
        For i As Integer = 1 To (21 - tama)
            re &= "_"
        Next
        Return re

    End Function
    Public Shared Sub SumarPadre(linea As dtsEstadosFinancieros.ResultadosRow, ByRef dts As dtsEstadosFinancieros, idPadre As Integer)
        If idPadre = 0 Then
            Exit Sub
        End If
        For Each padre In dts.Resultados
            If padre.id = idPadre Then
                padre.SaldoAcumulado1 += linea.SaldoAcumulado1
                padre.SaldoAcumulado2 += linea.SaldoAcumulado2
                padre.SaldoAcumulado3 += linea.SaldoAcumulado3
                SumarPadre(linea, dts, padre.PARENTID)
            End If
        Next
    End Sub
    Public Shared usuario As String = ""
    Public Shared Sub Abrir(Mdi As System.Windows.Forms.Form, _usuario As String)
        Dim dts As New dtsEstadosFinancieros
        usuario = _usuario
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "Select *  From Moneda Where CodMoneda = 1 Or CodMoneda = 2"
        bdAcceso.Cargar(cmd, dts.Moneda)


        Dim frm As New frmResultado(dts)
        frm.MdiParent = Mdi
        frm.WindowState = Windows.Forms.FormWindowState.Normal
        frm.Show()
    End Sub

End Class
