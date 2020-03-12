Public Class Reporte
    Public Shared Sub Reporte(ByRef _crv As CrystalDecisions.Windows.Forms.CrystalReportViewer, EsBalance As Boolean, EsMensual As Boolean, Moneda As Integer, MonedaNombre As String, CantPeriodos As Integer, Mes As Integer, MesNombre As String, Año As Integer, ExcluirCierre As Boolean, Nivel As Integer)
        Dim dts As New dtsResultado
        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "Select Empresa, Cedula AS Juridica, Tel_01 As Telefono, Email, Logo As Foto  From configuraciones"
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


            fecha = fecha.AddYears(-1)
            fp2 = fecha
            fp2 = fp2.AddMonths(1)
            fp2 = fp2.AddDays(-1)

            fecha = fecha.AddYears(-1)
            fp3 = fecha
            fp3 = fp3.AddMonths(1)
            fp3 = fp3.AddDays(-1)
        End If

        If Moneda = 1 Then


            cmd.CommandText = consulta(CantPeriodos, Moneda)
        Else
            cmd.CommandText = consulta(CantPeriodos, Moneda)
        End If


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

        'Saldos hasta xFecha

        'Amulular por niveles

        'Filtrar solo las cuenta de los niveles seleccionados.

        'Generar titulos
        Dim Titulo As String = ""
        Dim TipoReporte As String = ""
        If EsBalance Then
            Titulo = "Balance Situación"
            TipoReporte = "Balance"
        Else
            Titulo = "Estado Resultado"
            TipoReporte = "Estado"
        End If


        If EsMensual Then
            Titulo &= " Compartivo Mensual"
        Else
            Titulo &= " Comparativo Anual"
        End If

        Dim Filtro As String = ""

        Filtro &= " en " & CantPeriodos & " periodo(s), desde " & MesNombre & "/" & Año
        If ExcluirCierre Then
            Filtro &= " excluyendo el cierre."
        End If

        If Moneda = 1 Then
            Filtro &= " Colón"
        Else
            Filtro &= " Dolar"
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

        Dim rpt As New rptEstadoResultado
        rpt.SetDataSource(dts)
        rpt.SetParameterValue("Filtros", Filtro)
        rpt.SetParameterValue("Periodo1", periodo1)
        rpt.SetParameterValue("Periodo2", periodo2)
        rpt.SetParameterValue("Periodo3", periodo3)
        rpt.SetParameterValue("Titulo", Titulo)
        rpt.SetParameterValue("Nivel", Nivel)
        rpt.SetParameterValue("TipoReporte", TipoReporte)


        _crv.ReportSource = rpt
    End Sub
    Private Shared Sub Calculos(ByRef dts As dtsResultado)
        Dim Ingresos1 As Double = 0
        Dim Gastos1 As Double = 0
        Dim Costos1 As Double = 0

        Dim Ingresos2 As Double = 0
        Dim Gastos2 As Double = 0
        Dim Costos2 As Double = 0

        Dim Ingresos3 As Double = 0
        Dim Gastos3 As Double = 0
        Dim Costos3 As Double = 0

        For Each line As dtsResultado.ResultadosRow In dts.Resultados
            If line.Tipo.Equals("INGRESOS") And Not line.GastoNoDeducible Then
                Ingresos1 += line.SaldoAcumulado1
                Ingresos2 += line.SaldoAcumulado2
                Ingresos3 += line.SaldoAcumulado3

            End If
            If line.Tipo.Equals("COSTO VENTA") And Not line.GastoNoDeducible Then
                Costos1 += line.SaldoAcumulado1
                Costos2 += line.SaldoAcumulado2
                Costos3 += line.SaldoAcumulado3

            End If
            If line.Tipo.Equals("GASTOS") And Not line.GastoNoDeducible Then
                Gastos1 += line.SaldoAcumulado1
                Gastos2 += line.SaldoAcumulado2
                Gastos3 += line.SaldoAcumulado3

            End If
        Next
        Dim Utilidad1 As Double = Ingresos1 - Costos1 - Gastos1
        Dim Utilidad2 As Double = Ingresos2 - Costos2 - Gastos2
        Dim Utilidad3 As Double = Ingresos3 - Costos3 - Gastos3

        Dim lineUtilidad As dtsResultado.ResultadosRow
        lineUtilidad = dts.Resultados.NewResultadosRow
        With lineUtilidad
            .CuentaContable = "6zzz"
            .Descripcion = "UTILIDAD ANTES RENTA"
            .Tipo = "Result"
            .Nivel = 0
            .Movimientos = 0
            .SaldoAcumulado1 = Utilidad1
            .SaldoAcumulado2 = Utilidad2
            .SaldoAcumulado3 = Utilidad3
        End With
        dts.Resultados.AddResultadosRow(lineUtilidad)


        Dim Renta1 As Double = Utilidad1 * 0.09
        Dim Renta2 As Double = Utilidad2 * 0.09
        Dim Renta3 As Double = Utilidad3 * 0.09
        Dim lineRenta As dtsResultado.ResultadosRow
        lineRenta = dts.Resultados.NewResultadosRow
        With lineRenta
            .CuentaContable = "6zzz"
            .Descripcion = "RENTA"
            .Tipo = "Result"
            .Nivel = 0
            .Movimientos = 0
            .SaldoAcumulado1 = Renta1
            .SaldoAcumulado2 = Renta2
            .SaldoAcumulado3 = Renta3
        End With
        dts.Resultados.AddResultadosRow(lineRenta)

        Renta1 = Renta1 * 0.09
        Renta2 = Renta2 * 0.09
        Renta3 = Renta3 * 0.09

        Dim lineUtilidadReal As dtsResultado.ResultadosRow
        lineUtilidadReal = dts.Resultados.NewResultadosRow
        With lineUtilidadReal
            .CuentaContable = "6zzz"
            .Descripcion = "UTILIDAD REAL"
            .Tipo = "Result"
            .Nivel = 0
            .Movimientos = 0
            .SaldoAcumulado1 = Utilidad1 - Renta1
            .SaldoAcumulado2 = Utilidad2 - Renta2
            .SaldoAcumulado3 = Utilidad3 - Renta3
        End With
        dts.Resultados.AddResultadosRow(lineUtilidadReal)
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
    Public Shared Sub SumarPadre(linea As dtsResultado.ResultadosRow, ByRef dts As dtsResultado, idPadre As Integer)
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
    Public Shared Sub Abrir(Mdi As System.Windows.Forms.Form)
        Dim dts As New dtsResultado

        Dim cmd As New SqlClient.SqlCommand

        cmd.CommandText = "Select *  From Moneda Where CodMoneda = 1 Or CodMoneda = 2"
        bdAcceso.Cargar(cmd, dts.Moneda)


        Dim frm As New frmResultado(dts)
        frm.MdiParent = Mdi
        frm.WindowState = Windows.Forms.FormWindowState.Normal 
        frm.Show()
    End Sub
End Class
