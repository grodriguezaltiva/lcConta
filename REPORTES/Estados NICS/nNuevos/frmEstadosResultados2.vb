Imports Microsoft.Office.Interop
Public Class frmEstadosResultados2

    Dim m_Excel As Excel.Application
    Dim objLibroExcel As Excel.Workbook 'Creamos un objeto WorkBook
    Dim objHojaExcel As Excel.Worksheet 'Creamos un objeto WorkSheet

    Private ConConta As String = Configuracion.Claves.Conexion("Contabilidad")

    Private Sub GeneraExcel()
        Dim frmEspere As New frmCargando
        frmEspere.Show()
        frmEspere.TopMost = True
        Me.Enabled = False
        Dim Fila As Integer = 0
        Dim FontName = "Trebuchet MS"
        Dim FontGrande = 14
        Dim FontMediano = 10
        Dim FontPequeño = 9
        Dim dts_Conf As New DataTable
        Dim dts_Cuentas As New DataTable
        cFunciones.Llenar_Tabla_Generico("select id as Id_Cuenta, CuentaContable, Descripcion, Tipo, Nivel from CuentaContable where Tipo in('INGRESOS','COSTO VENTA','GASTOS') and Nivel <= 2 ", dts_Cuentas, Me.ConConta)
        cFunciones.Llenar_Tabla_Generico("select * from configuraciones", dts_Conf, Me.ConConta)

        m_Excel = New Excel.Application
        m_Excel.Visible = False

        objLibroExcel = m_Excel.Workbooks.Add()
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()
        Fila += 1
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Merge()
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Value = dts_Conf.Rows(0).Item("Empresa")
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Bold = True
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Size = FontGrande
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Name = FontName
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        Fila += 1
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Merge()
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Value = "Estado de Resultados"
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Bold = True
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Size = FontGrande
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Name = FontName
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        Fila += 1
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Merge()
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Value = "Por el periodo terminado "
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Bold = False
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Size = FontPequeño
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Name = FontName
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        Fila += 1
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Merge()
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Value = "(en " & Me.cboMoneda.Text.ToLower & " sin céntimos)"
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Bold = False
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Size = FontPequeño
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Font.Name = FontName
        objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        Fila += 1
        objHojaExcel.Range("B" & Fila.ToString).Merge()
        objHojaExcel.Range("B" & Fila.ToString).Value = "Oct. " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("C" & Fila.ToString).Merge()
        objHojaExcel.Range("C" & Fila.ToString).Value = "Nov. " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("D" & Fila.ToString).Merge()
        objHojaExcel.Range("D" & Fila.ToString).Value = "Dic. " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("E" & Fila.ToString).Merge()
        objHojaExcel.Range("E" & Fila.ToString).Value = "Enero " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("F" & Fila.ToString).Merge()
        objHojaExcel.Range("F" & Fila.ToString).Value = "Febrero " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("G" & Fila.ToString).Merge()
        objHojaExcel.Range("G" & Fila.ToString).Value = "Marzo " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("H" & Fila.ToString).Merge()
        objHojaExcel.Range("H" & Fila.ToString).Value = "Abril " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("I" & Fila.ToString).Merge()
        objHojaExcel.Range("I" & Fila.ToString).Value = "Mayo " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("J" & Fila.ToString).Merge()
        objHojaExcel.Range("J" & Fila.ToString).Value = "Junio " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("K" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Julio " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("L" & Fila.ToString).Merge()
        objHojaExcel.Range("L" & Fila.ToString).Value = "Agosto " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("M" & Fila.ToString).Merge()
        objHojaExcel.Range("M" & Fila.ToString).Value = "Set " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45

        objHojaExcel.Range("N" & Fila.ToString).Merge()
        objHojaExcel.Range("N" & Fila.ToString).Value = "Acum. Set " & Me.cboPeriodoFiscal.Text
        objHojaExcel.Range("N" & Fila.ToString).Font.Bold = True
        objHojaExcel.Range("N" & Fila.ToString).Font.Size = FontPequeño
        objHojaExcel.Range("N" & Fila.ToString).Font.Name = FontName
        objHojaExcel.Range("N" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
        objHojaExcel.Range("N" & Fila.ToString).ColumnWidth = 45

        Dim Valor As Decimal
        Dim Nivel_Antes As Integer = 0
        Dim IdCuenta_Antes As Integer
        Dim Cuenta_Antes As String = ""
        For Each X As DataRow In dts_Cuentas.Rows
            Select Case CInt(X.Item("Nivel"))
                Case 0

                    If X.Item("Tipo") = "COSTO VENTA" Or X.Item("Tipo") = "GASTOS" Then
                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = "Total " & Cuenta_Antes
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 10 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("B" & Fila.ToString).Merge()
                        objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                        objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 11 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("C" & Fila.ToString).Merge()
                        objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                        objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 12 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("D" & Fila.ToString).Merge()
                        objHojaExcel.Range("D" & Fila.ToString).Value = Valor '"Dic. " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 1 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("E" & Fila.ToString).Merge()
                        objHojaExcel.Range("E" & Fila.ToString).Value = Valor '"Enero " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 2 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("F" & Fila.ToString).Merge()
                        objHojaExcel.Range("F" & Fila.ToString).Value = Valor '"Febrero " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 3 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("G" & Fila.ToString).Merge()
                        objHojaExcel.Range("G" & Fila.ToString).Value = Valor '"Marzo " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 4 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("H" & Fila.ToString).Merge()
                        objHojaExcel.Range("H" & Fila.ToString).Value = Valor '"Abril " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 5 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("I" & Fila.ToString).Merge()
                        objHojaExcel.Range("I" & Fila.ToString).Value = Valor  '"Mayo " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 6 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("J" & Fila.ToString).Merge()
                        objHojaExcel.Range("J" & Fila.ToString).Value = Valor '"Junio " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 7 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("K" & Fila.ToString).Merge()
                        objHojaExcel.Range("K" & Fila.ToString).Value = Valor '"Julio " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 8 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("L" & Fila.ToString).Merge()
                        objHojaExcel.Range("L" & Fila.ToString).Value = Valor '"Agosto " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 9 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                        objHojaExcel.Range("M" & Fila.ToString).Merge()
                        objHojaExcel.Range("M" & Fila.ToString).Value = Valor '"Set " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuenta_Antes And I.Mes = 9 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.AcumuladoC)).Sum

                        objHojaExcel.Range("N" & Fila.ToString).Merge()
                        objHojaExcel.Range("N" & Fila.ToString).Value = Valor '"Acum. Set " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range("N" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("N" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("N" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("N" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("N" & Fila.ToString).ColumnWidth = 45
                    End If

                    Fila += 1
                    objHojaExcel.Range("A" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = X.Item("Descripcion")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                    Nivel_Antes = X.Item("Nivel")
                    IdCuenta_Antes = CInt(X.Item("Id_Cuenta"))
                    Cuenta_Antes = X.Item("Descripcion")
                Case 1
                    Fila += 1
                    objHojaExcel.Range("A" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = X.Item("Descripcion")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                    Nivel_Antes = X.Item("Nivel")
                Case 2
                    Fila += 1
                    objHojaExcel.Range("A" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = X.Item("Descripcion")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 10 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("B" & Fila.ToString).Merge()
                    objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                    objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 11 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("C" & Fila.ToString).Merge()
                    objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                    objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 12 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("D" & Fila.ToString).Merge()
                    objHojaExcel.Range("D" & Fila.ToString).Value = Valor '"Dic. " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 1 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("E" & Fila.ToString).Merge()
                    objHojaExcel.Range("E" & Fila.ToString).Value = Valor '"Enero " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 2 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("F" & Fila.ToString).Merge()
                    objHojaExcel.Range("F" & Fila.ToString).Value = Valor '"Febrero " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 3 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("G" & Fila.ToString).Merge()
                    objHojaExcel.Range("G" & Fila.ToString).Value = Valor '"Marzo " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 4 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("H" & Fila.ToString).Merge()
                    objHojaExcel.Range("H" & Fila.ToString).Value = Valor '"Abril " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 5 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("I" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Valor  '"Mayo " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 6 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("J" & Fila.ToString).Merge()
                    objHojaExcel.Range("J" & Fila.ToString).Value = Valor '"Junio " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 7 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("K" & Fila.ToString).Merge()
                    objHojaExcel.Range("K" & Fila.ToString).Value = Valor '"Julio " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 8 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("L" & Fila.ToString).Merge()
                    objHojaExcel.Range("L" & Fila.ToString).Value = Valor '"Agosto " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 9 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.SaldoMesC)).Sum

                    objHojaExcel.Range("M" & Fila.ToString).Merge()
                    objHojaExcel.Range("M" & Fila.ToString).Value = Valor '"Set " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45

                    Valor = 0
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 9 And I.Anno = Me.cboPeriodoFiscal.Text Select CDec(I.AcumuladoC)).Sum

                    objHojaExcel.Range("N" & Fila.ToString).Merge()
                    objHojaExcel.Range("N" & Fila.ToString).Value = Valor '"Acum. Set " & Me.cboPeriodoFiscal.Text
                    objHojaExcel.Range("N" & Fila.ToString).Font.Bold = True
                    objHojaExcel.Range("N" & Fila.ToString).Font.Size = FontPequeño
                    objHojaExcel.Range("N" & Fila.ToString).Font.Name = FontName
                    objHojaExcel.Range("N" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                    objHojaExcel.Range("N" & Fila.ToString).ColumnWidth = 45

                    Nivel_Antes = X.Item("Nivel")
            End Select
        Next

        'Dim N As Generic.List(Of dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow)
        'N = (From B As dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow In Me.DtsReportes.getEstadosResultadosMensuala3Annos Where B.Nivel = 0 Select B Order By B.CuentaContable).ToList
        'Fila += 2
        'objHojaExcel.Range("A" & Fila.ToString).Merge()
        'objHojaExcel.Range("A" & Fila.ToString).Value = "Utilidad Neta de Operación "
        'objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
        'objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

        'objHojaExcel.Range("B" & Fila.ToString).Merge()
        'objHojaExcel.Range("B" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, N(0).SMES1C - N(1).SMES1C - N(2).SMES1C, N(0).SMES1D - N(1).SMES1D - N(2).SMES1D), "N2")
        'objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("C" & Fila.ToString).Merge()
        'objHojaExcel.Range("C" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, N(0).SMES2C - N(1).SMES2C - N(2).SMES2C, N(0).SMES2D - N(1).SMES2D - N(2).SMES2D), "N2")
        'objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("D" & Fila.ToString).Merge()
        'objHojaExcel.Range("D" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, N(0).SMES3C - N(1).SMES3C - N(2).SMES3C, N(0).SMES3D - N(1).SMES3D - N(2).SMES3D), "N2")
        'objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("E" & Fila.ToString).Merge()
        'objHojaExcel.Range("E" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, (N(0).SMES1C - N(1).SMES1C - N(2).SMES1C) - (N(0).SMES2C - N(1).SMES2C - N(2).SMES2C), (N(0).SMES1D - N(1).SMES1D - N(2).SMES1D) - (N(0).SMES2D - N(1).SMES2D - N(2).SMES2D)), "N2")
        'objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("G" & Fila.ToString).Merge()
        'objHojaExcel.Range("G" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, N(0).ACUM1C - N(1).ACUM1C - N(2).ACUM1C, N(0).ACUM1D - N(1).ACUM1D - N(2).ACUM1D), "N2")
        'objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("H" & Fila.ToString).Merge()
        'objHojaExcel.Range("H" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, N(0).ACUM2C - N(1).ACUM2C - N(2).ACUM2C, N(0).ACUM2D - N(1).ACUM2D - N(2).ACUM2D), "N2")
        'objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("I" & Fila.ToString).Merge()
        'objHojaExcel.Range("I" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, N(0).ACUM3C - N(1).ACUM3C - N(2).ACUM3C, N(0).ACUM3D - N(1).ACUM3D - N(2).ACUM3D), "N2")
        'objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        'objHojaExcel.Range("J" & Fila.ToString).Merge()
        'objHojaExcel.Range("J" & Fila.ToString).Value = Format(IIf(Me.cboMoneda.SelectedValue = 1, (N(0).ACUM1C - N(1).ACUM1C - N(2).ACUM1C) - (N(0).ACUM2C - N(1).ACUM2C - N(2).ACUM2C), (N(0).ACUM1D - N(1).ACUM1D - N(2).ACUM1D) - (N(0).ACUM2D - N(1).ACUM2D - N(2).ACUM2D)), "N2")
        'objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
        'objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
        'objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
        'objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

        Me.Enabled = True
        frmEspere.Close()
        m_Excel.Visible = True

    End Sub

    Private Sub frmEstadosResultados2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.PeriodoTableAdapter.Connection.ConnectionString = ConConta
        Me.PeriodoFiscalTableAdapter.Connection.ConnectionString = ConConta
        Me.cmdGetBalance.Connection.ConnectionString = ConConta
        Me.PeriodoFiscalTableAdapter.Fill(Me.DtsReportes.PeriodoFiscal)

        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select CodMoneda, MonedaNombre from Moneda", dts, Me.ConConta)
        Me.cboMoneda.DataSource = dts
        Me.cboMoneda.DisplayMember = "MonedaNombre"
        Me.cboMoneda.ValueMember = "CodMoneda"
    End Sub


    Private Sub CargarPeriodosTrabajo(ByVal _idfiscal As String)
        Try
            If IsNumeric(_idfiscal) Then
                cFunciones.Llenar_Tabla_Generico("select * from Periodo where Cerrado = 1 and Id_PeriodoFiscal = " & _idfiscal, Me.DtsReportes.Periodo, Me.ConConta)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCantidadNivel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCantidadNivel.Click
        Try
            cFunciones.Llenar_Tabla_Generico("exec getEstadoResultadoAnual " & Me.cboPeriodoFiscal.SelectedValue, Me.DtsReportes.getEstadoResultadoAnual, Me.ConConta)
            GeneraExcel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub cboPeriodoFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoFiscal.SelectedIndexChanged
        On Error Resume Next
        CargarPeriodosTrabajo(Me.cboPeriodoFiscal.SelectedValue)
    End Sub

End Class