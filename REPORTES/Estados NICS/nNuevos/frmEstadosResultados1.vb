Imports Microsoft.Office.Interop
Public Class frmEstadosResultados1
    Private ConConta As String = Configuracion.Claves.Conexion("Contabilidad")

    Dim m_Excel As Excel.Application
    Dim objLibroExcel As Excel.Workbook 'Creamos un objeto WorkBook
    Dim objHojaExcel As Excel.Worksheet 'Creamos un objeto WorkSheet

    Private Function GetCelda(ByVal _limite As Integer) As String
        Select Case _limite
            Case 1 : Return "C"
            Case 2 : Return "D"
            Case 3 : Return "E"
            Case 4 : Return "F"
            Case 5 : Return "G"
            Case 6 : Return "H"
            Case 7 : Return "I"
            Case 8 : Return "J"
            Case 9 : Return "K"
            Case 10 : Return "L"
            Case 11 : Return "M"
            Case 12 : Return "N"
        End Select
    End Function
    Private Function getEncabezado(ByVal _periodo As String) As String
        Dim Pe() As String
        Pe = _periodo.Split("/")
        Select Case Pe(0)
            Case "1"
                Return "10/" & (CInt(Pe(1)) - 1).ToString
            Case "2"
                Return "11/" & (CInt(Pe(1)) - 1).ToString
            Case "3"
                Return "12/" & (CInt(Pe(1)) - 1).ToString
            Case "4"
                Return "01/" & Pe(1).ToString
            Case "5"
                Return "02/" & Pe(1).ToString
            Case "6"
                Return "03/" & Pe(1).ToString
            Case "7"
                Return "04/" & Pe(1).ToString
            Case "8"
                Return "05/" & Pe(1).ToString
            Case "9"
                Return "06/" & Pe(1).ToString
            Case "10"
                Return "07/" & Pe(1).ToString
            Case "11"
                Return "08/" & Pe(1).ToString
            Case "12"
                Return "09/" & Pe(1).ToString
        End Select
    End Function
    Private Function getPeriodoAnterior2(ByVal _idperiodo As String, Optional ByVal _annos As Integer = 1) As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT AC.Id_Periodo FROM Periodo AC INNER JOIN Periodo AN ON AC.Mes = AN.Mes AND AC.Anno = (AN.Anno - " & _annos & ") WHERE AN.Id_Periodo = " & _idperiodo, dts, Me.ConConta)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item("Id_Periodo")
        Else
            Return "0"
        End If
    End Function
    Private Function getPeriodoAnterior(ByVal _idperiodo As String, Optional ByVal _annos As Integer = 1) As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT AC.Periodo FROM Periodo AC INNER JOIN Periodo AN ON AC.Mes = AN.Mes AND AC.Anno = (AN.Anno - " & _annos & ") WHERE AN.Id_Periodo = " & _idperiodo, dts, Me.ConConta)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item("Periodo")
        Else
            Return ""
        End If
    End Function
    Private Function getAnnoPeriodoAnterior(ByVal _idperiodo As String, Optional ByVal _annos As Integer = 1) As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT AC.Anno FROM Periodo AC INNER JOIN Periodo AN ON AC.Mes = AN.Mes AND AC.Anno = (AN.Anno - " & _annos & ") WHERE AN.Id_Periodo = " & _idperiodo, dts, Me.ConConta)
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item("Anno")
        Else
            Return ""
        End If
    End Function
    Private Function AnoyFebrero(ByVal _anyo As Integer) As Integer
        If (_anyo Mod 4 = 0 And _anyo Mod 100 <> 0 Or _anyo Mod 400 = 0) Then
            Return 29
        Else
            Return 28
        End If
    End Function
    Private Function GetAnnyoPeriodoAcumulado(ByVal _annyo As Integer, ByVal _limitemes As Integer) As Integer
        If _limitemes <= 3 Then
            Return _annyo - 1
        Else
            Return _annyo
        End If
    End Function
    Private Function GetTextoPeriodoTerminado(ByVal _periodo As String) As String
        Dim Pe() As String
        Pe = _periodo.Split("/")
        Select Case Pe(0)
            Case "1"
                Return "31 de Octubre del " & (CInt(Pe(1)) - 1).ToString
            Case "2"
                Return "30 de Noviembre del " & (CInt(Pe(1)) - 1).ToString
            Case "3"
                Return "31 de Diciembre del " & (CInt(Pe(1)) - 1).ToString
            Case "4"
                Return "31 de Enero del " & Pe(1)
            Case "5"
                Return Me.AnoyFebrero(Pe(1)) & " de Febrero del " & Pe(1)
            Case "6"
                Return "31 de Marzo del " & Pe(1)
            Case "7"
                Return "30 de Abril del " & Pe(1)
            Case "8"
                Return "31 de Mayo del " & Pe(1)
            Case "9"
                Return "30 de Junio del " & Pe(1)
            Case "10"
                Return "31 de Julio del " & Pe(1)
            Case "11"
                Return "31 de Agosto del " & Pe(1)
            Case "12"
                Return "30 de Septiembre del " & Pe(1)
        End Select
    End Function
    Private Sub GeneraExcelAnyoFiscal()
        Dim frmEspere As New frmCargando
        Dim LimiteMes As Integer = 12
        Try
            Dim P() As String = Me.cboPeriodoT.Text.Split("/")
            LimiteMes = P(0)
        Catch ex As Exception
        End Try
        Try
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
            cFunciones.Llenar_Tabla_Generico("select id as Id_Cuenta, CuentaContable, Descripcion, Tipo, Nivel, Movimiento from CuentaContable where Tipo in('INGRESOS','COSTO VENTA','GASTOS') and Nivel <= 8 ", dts_Cuentas, Me.ConConta)
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
            objHojaExcel.Range("A" & Fila.ToString & ":N" & Fila.ToString & "").Value = "Por el periodo terminado del " & GetTextoPeriodoTerminado(Me.cboPeriodoT.Text)
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

            If LimiteMes >= 1 Then
                Fila += 1
                objHojaExcel.Range("B" & Fila.ToString).Merge()
                objHojaExcel.Range("B" & Fila.ToString).Value = "Oct. " & (CInt(Me.cboPeriodoFiscal.Text) - 1).ToString
                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 2 Then
                objHojaExcel.Range("C" & Fila.ToString).Merge()
                objHojaExcel.Range("C" & Fila.ToString).Value = "Nov. " & (CInt(Me.cboPeriodoFiscal.Text) - 1).ToString
                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 3 Then
                objHojaExcel.Range("D" & Fila.ToString).Merge()
                objHojaExcel.Range("D" & Fila.ToString).Value = "Dic. " & (CInt(Me.cboPeriodoFiscal.Text) - 1).ToString
                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 4 Then
                objHojaExcel.Range("E" & Fila.ToString).Merge()
                objHojaExcel.Range("E" & Fila.ToString).Value = "Enero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 5 Then
                objHojaExcel.Range("F" & Fila.ToString).Merge()
                objHojaExcel.Range("F" & Fila.ToString).Value = "Febrero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 6 Then
                objHojaExcel.Range("G" & Fila.ToString).Merge()
                objHojaExcel.Range("G" & Fila.ToString).Value = "Marzo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 7 Then
                objHojaExcel.Range("H" & Fila.ToString).Merge()
                objHojaExcel.Range("H" & Fila.ToString).Value = "Abril " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 8 Then
                objHojaExcel.Range("I" & Fila.ToString).Merge()
                objHojaExcel.Range("I" & Fila.ToString).Value = "Mayo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 9 Then
                objHojaExcel.Range("J" & Fila.ToString).Merge()
                objHojaExcel.Range("J" & Fila.ToString).Value = "Junio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 10 Then
                objHojaExcel.Range("K" & Fila.ToString).Merge()
                objHojaExcel.Range("K" & Fila.ToString).Value = "Julio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 11 Then
                objHojaExcel.Range("L" & Fila.ToString).Merge()
                objHojaExcel.Range("L" & Fila.ToString).Value = "Agosto " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 12 Then
                objHojaExcel.Range("M" & Fila.ToString).Merge()
                objHojaExcel.Range("M" & Fila.ToString).Value = "Set " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
            End If

            Dim NombreMesAcumulado As String
            Dim ValorMesAcumulado As Integer
            Select Case LimiteMes
                Case 1 : NombreMesAcumulado = "Oct. " & (CInt(Me.cboPeriodoFiscal.Text) - 1).ToString : ValorMesAcumulado = 10
                Case 2 : NombreMesAcumulado = "Nov. " & (CInt(Me.cboPeriodoFiscal.Text) - 1).ToString : ValorMesAcumulado = 11
                Case 3 : NombreMesAcumulado = "Dic. " & (CInt(Me.cboPeriodoFiscal.Text) - 1).ToString : ValorMesAcumulado = 12
                Case 4 : NombreMesAcumulado = "Ene. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 1
                Case 5 : NombreMesAcumulado = "Feb. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 2
                Case 6 : NombreMesAcumulado = "Mar. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 3
                Case 7 : NombreMesAcumulado = "Abr. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 4
                Case 8 : NombreMesAcumulado = "May. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 5
                Case 9 : NombreMesAcumulado = "Jun. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 6
                Case 10 : NombreMesAcumulado = "Jul. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 7
                Case 11 : NombreMesAcumulado = "Ago. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 8
                Case 12 : NombreMesAcumulado = "Set. " & Me.cboPeriodoFiscal.Text : ValorMesAcumulado = 9
            End Select

            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = "Acum." & NombreMesAcumulado
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

            Dim Valor As Decimal
            Dim mes As Integer
            Dim Nivel_Antes As Integer = 0
            Dim IdCuentaNivel0 As Integer
            Dim Cuenta_Nivel0 As String = ""

            Dim IdCuentaNivel1 As String
            Dim Cuenta_Nivel1 As String = ""
            Dim ING, COS, GAS As Decimal

            For Each X As DataRow In dts_Cuentas.Rows
                Select Case CInt(X.Item("Nivel"))
                    Case 0

                        If X.Item("Tipo") = "COSTO VENTA" Or X.Item("Tipo") = "GASTOS" Then
                            '***********************************************************************************
                            Fila += 1
                            objHojaExcel.Range("A" & Fila.ToString).Merge()
                            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & Cuenta_Nivel1
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                            If LimiteMes >= 1 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("B" & Fila.ToString).Merge()
                                objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 2 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("C" & Fila.ToString).Merge()
                                objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                                objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 3 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If


                                objHojaExcel.Range("D" & Fila.ToString).Merge()
                                objHojaExcel.Range("D" & Fila.ToString).Value = Valor  '"Dic. " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("D" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 4 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("E" & Fila.ToString).Merge()
                                objHojaExcel.Range("E" & Fila.ToString).Value = Valor  '"Enero " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("E" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 5 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("F" & Fila.ToString).Merge()
                                objHojaExcel.Range("F" & Fila.ToString).Value = Valor  '"Febrero " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("F" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 6 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("G" & Fila.ToString).Merge()
                                objHojaExcel.Range("G" & Fila.ToString).Value = Valor  '"Marzo " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("G" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 7 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("H" & Fila.ToString).Merge()
                                objHojaExcel.Range("H" & Fila.ToString).Value = Valor  '"Abril " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("H" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 8 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("I" & Fila.ToString).Merge()
                                objHojaExcel.Range("I" & Fila.ToString).Value = Valor   '"Mayo " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("I" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 9 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("J" & Fila.ToString).Merge()
                                objHojaExcel.Range("J" & Fila.ToString).Value = Valor  '"Junio " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("J" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 10 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("K" & Fila.ToString).Merge()
                                objHojaExcel.Range("K" & Fila.ToString).Value = Valor  '"Julio " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("K" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 11 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("L" & Fila.ToString).Merge()
                                objHojaExcel.Range("L" & Fila.ToString).Value = Valor  '"Agosto " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("L" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 12 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("M" & Fila.ToString).Merge()
                                objHojaExcel.Range("M" & Fila.ToString).Value = Valor  '"Set " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("M" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
                            End If

                            Valor = 0
                            Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel1 And I.Mes = ValorMesAcumulado And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.AcumuladoC)).Sum

                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = Valor  '"Acum. Set " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45
                            '***********************************************************************************
                            Fila += 1
                            objHojaExcel.Range("A" & Fila.ToString).Merge()
                            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & Cuenta_Nivel0
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                            If LimiteMes >= 1 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("B" & Fila.ToString).Merge()
                                objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                                objHojaExcel.Range("B" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 2 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If


                                objHojaExcel.Range("C" & Fila.ToString).Merge()
                                objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                                objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
                            End If

                            If LimiteMes >= 3 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("D" & Fila.ToString).Merge()
                                objHojaExcel.Range("D" & Fila.ToString).Value = Valor  '"Dic. " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("D" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 4 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("E" & Fila.ToString).Merge()
                                objHojaExcel.Range("E" & Fila.ToString).Value = Valor  '"Enero " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("E" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 5 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("F" & Fila.ToString).Merge()
                                objHojaExcel.Range("F" & Fila.ToString).Value = Valor  '"Febrero " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("F" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 6 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If


                                objHojaExcel.Range("G" & Fila.ToString).Merge()
                                objHojaExcel.Range("G" & Fila.ToString).Value = Valor  '"Marzo " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("G" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 7 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                End If

                                objHojaExcel.Range("H" & Fila.ToString).Merge()
                                objHojaExcel.Range("H" & Fila.ToString).Value = Valor  '"Abril " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 8 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("I" & Fila.ToString).Merge()
                                objHojaExcel.Range("I" & Fila.ToString).Value = Valor   '"Mayo " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 9 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("J" & Fila.ToString).Merge()
                                objHojaExcel.Range("J" & Fila.ToString).Value = Valor  '"Junio " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 10 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("K" & Fila.ToString).Merge()
                                objHojaExcel.Range("K" & Fila.ToString).Value = Valor '"Julio " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 11 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                End If

                                objHojaExcel.Range("L" & Fila.ToString).Merge()
                                objHojaExcel.Range("L" & Fila.ToString).Value = Valor  '"Agosto " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 12 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("M" & Fila.ToString).Merge()
                                objHojaExcel.Range("M" & Fila.ToString).Value = Valor  '"Set " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
                            End If

                            Valor = 0
                            Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where X.Item("Nivel") = 0 And I.IdCuenta = IdCuentaNivel0 And I.Mes = ValorMesAcumulado And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.AcumuladoC)).Sum

                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = Valor  '"Acum. Set " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

                            If X.Item("Tipo") = "GASTOS" Then
                                'calcula utlidad
                                Fila += 2
                                objHojaExcel.Range("A" & Fila.ToString).Merge()
                                objHojaExcel.Range("A" & Fila.ToString).Value = "Utilidad Neta de Operación "
                                objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                                If LimiteMes >= 1 Then
                                    mes = 10
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("B" & Fila.ToString).Merge()
                                    objHojaExcel.Range("B" & Fila.ToString).Value = ING - COS - GAS
                                    objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
                                End If

                                If LimiteMes >= 2 Then
                                    mes = 11
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("C" & Fila.ToString).Merge()
                                    objHojaExcel.Range("C" & Fila.ToString).Value = ING - COS - GAS
                                    objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 3 Then
                                    mes = 12
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("D" & Fila.ToString).Merge()
                                    objHojaExcel.Range("D" & Fila.ToString).Value = ING - COS - GAS
                                    objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 4 Then
                                    mes = 1
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("E" & Fila.ToString).Merge()
                                    objHojaExcel.Range("E" & Fila.ToString).Value = ING - COS - GAS
                                    objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 5 Then
                                    mes = 2
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("F" & Fila.ToString).Merge()
                                    objHojaExcel.Range("F" & Fila.ToString).Value = ING - COS - GAS '"Febrero " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 6 Then
                                    mes = 3
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("G" & Fila.ToString).Merge()
                                    objHojaExcel.Range("G" & Fila.ToString).Value = ING - COS - GAS '"Marzo " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 7 Then
                                    mes = 4
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("H" & Fila.ToString).Merge()
                                    objHojaExcel.Range("H" & Fila.ToString).Value = ING - COS - GAS '"Abril " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 8 Then
                                    mes = 5
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("I" & Fila.ToString).Merge()
                                    objHojaExcel.Range("I" & Fila.ToString).Value = ING - COS - GAS   '"Mayo " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 9 Then
                                    mes = 6
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("J" & Fila.ToString).Merge()
                                    objHojaExcel.Range("J" & Fila.ToString).Value = ING - COS - GAS '"Junio " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 10 Then
                                    mes = 7
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("K" & Fila.ToString).Merge()
                                    objHojaExcel.Range("K" & Fila.ToString).Value = ING - COS - GAS '"Julio " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 11 Then
                                    mes = 8
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("L" & Fila.ToString).Merge()
                                    objHojaExcel.Range("L" & Fila.ToString).Value = ING - COS - GAS '"Agosto " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
                                End If
                                If LimiteMes >= 12 Then
                                    mes = 9
                                    ING = 0 : COS = 0 : GAS = 0
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 1 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                                    End If
                                    If Me.cboMoneda.SelectedValue = 2 Then
                                        COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                                    End If

                                    objHojaExcel.Range("M" & Fila.ToString).Merge()
                                    objHojaExcel.Range("M" & Fila.ToString).Value = ING - COS - GAS '"Set " & Me.cboPeriodoFiscal.Text
                                    objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                                    objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                                    objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                                    objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                    objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
                                End If
                                mes = ValorMesAcumulado
                                ING = 0 : COS = 0 : GAS = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoC).Sum
                                End If
                                If Me.cboMoneda.SelectedValue = 2 Then
                                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoD).Sum
                                End If
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoC).Sum
                                End If
                                If Me.cboMoneda.SelectedValue = 2 Then
                                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoD).Sum
                                End If

                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = ING - COS - GAS '"Acum. Set " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

                                Fila += 1
                            End If
                        End If

                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Item("Descripcion")
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                        Nivel_Antes = X.Item("Nivel")
                        IdCuentaNivel0 = CInt(X.Item("Id_Cuenta"))
                        Cuenta_Nivel0 = X.Item("Descripcion")
                    Case 1
                        '*********************************************
                        If Nivel_Antes = 2 Then
                            Fila += 1
                            objHojaExcel.Range("A" & Fila.ToString).Merge()
                            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & Cuenta_Nivel1
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                            If LimiteMes >= 1 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("B" & Fila.ToString).Merge()
                                objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 2 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("C" & Fila.ToString).Merge()
                                objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 3 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                                End If


                                objHojaExcel.Range("D" & Fila.ToString).Merge()
                                objHojaExcel.Range("D" & Fila.ToString).Value = Valor  '"Dic. " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 4 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("E" & Fila.ToString).Merge()
                                objHojaExcel.Range("E" & Fila.ToString).Value = Valor  '"Enero " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 5 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("F" & Fila.ToString).Merge()
                                objHojaExcel.Range("F" & Fila.ToString).Value = Valor  '"Febrero " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 6 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("G" & Fila.ToString).Merge()
                                objHojaExcel.Range("G" & Fila.ToString).Value = Valor  '"Marzo " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 7 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("H" & Fila.ToString).Merge()
                                objHojaExcel.Range("H" & Fila.ToString).Value = Valor  '"Abril " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 8 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("I" & Fila.ToString).Merge()
                                objHojaExcel.Range("I" & Fila.ToString).Value = Valor   '"Mayo " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 9 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("J" & Fila.ToString).Merge()
                                objHojaExcel.Range("J" & Fila.ToString).Value = Valor  '"Junio " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 10 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("K" & Fila.ToString).Merge()
                                objHojaExcel.Range("K" & Fila.ToString).Value = Valor  '"Julio " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 11 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("L" & Fila.ToString).Merge()
                                objHojaExcel.Range("L" & Fila.ToString).Value = Valor  '"Agosto " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
                            End If
                            If LimiteMes >= 12 Then
                                Valor = 0
                                If Me.cboMoneda.SelectedValue = 1 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                                End If

                                objHojaExcel.Range("M" & Fila.ToString).Merge()
                                objHojaExcel.Range("M" & Fila.ToString).Value = Valor  '"Set " & Me.cboPeriodoFiscal.Text
                                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
                            End If

                            Valor = 0
                            Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = ValorMesAcumulado And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.AcumuladoC)).Sum

                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = Valor  '"Acum. Set " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45
                        End If
                        '*********************************************
                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Item("Descripcion")
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        Nivel_Antes = X.Item("Nivel")
                        IdCuentaNivel1 = X.Item("Id_Cuenta")
                        Cuenta_Nivel1 = X.Item("Descripcion")
                    Case Else
                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Item("Descripcion")
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 60

                        If Not X.Item("Movimiento") Then
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                            If CInt(X.Item("Nivel")) = 2 Then
                                objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("A" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)
                            ElseIf CInt(X.Item("Nivel")) = 3 Then
                                objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            Else
                                objHojaExcel.Range("A" & Fila.ToString).Font.Bold = False

                            End If
                        Else
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("A" & Fila.ToString).Font.Subscript = False
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                        End If

                        If LimiteMes >= 1 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                            End If
                            objHojaExcel.Range("B" & Fila.ToString).Merge()
                            objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                            objHojaExcel.Range("B" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 2 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("C" & Fila.ToString).Merge()
                            objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 3 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = Valor  '"Dic. " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 4 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = Valor  '"Enero " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 5 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("F" & Fila.ToString).Merge()
                            objHojaExcel.Range("F" & Fila.ToString).Value = Valor  '"Febrero " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 6 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("G" & Fila.ToString).Merge()
                            objHojaExcel.Range("G" & Fila.ToString).Value = Valor  '"Marzo " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("G" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45

                        End If
                        If LimiteMes >= 7 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("H" & Fila.ToString).Merge()
                            objHojaExcel.Range("H" & Fila.ToString).Value = Valor  '"Abril " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 8 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("I" & Fila.ToString).Merge()
                            objHojaExcel.Range("I" & Fila.ToString).Value = Valor   '"Mayo " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 9 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("J" & Fila.ToString).Merge()
                            objHojaExcel.Range("J" & Fila.ToString).Value = Valor  '"Junio " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 10 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("K" & Fila.ToString).Merge()
                            objHojaExcel.Range("K" & Fila.ToString).Value = Valor  '"Julio " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 11 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("L" & Fila.ToString).Merge()
                            objHojaExcel.Range("L" & Fila.ToString).Value = Valor  '"Agosto " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("L" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
                        End If
                        If LimiteMes >= 12 Then
                            Valor = 0
                            If Me.cboMoneda.SelectedValue = 1 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                            ElseIf Me.cboMoneda.SelectedValue = 2 Then
                                Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                            End If

                            objHojaExcel.Range("M" & Fila.ToString).Merge()
                            objHojaExcel.Range("M" & Fila.ToString).Value = Valor '"Set " & Me.cboPeriodoFiscal.Text
                            objHojaExcel.Range("M" & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                            objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
                        End If

                        Valor = 0
                        Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = X.Item("Id_Cuenta") And I.Mes = ValorMesAcumulado And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.AcumuladoC)).Sum

                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = Valor  '"Acum. Set " & Me.cboPeriodoFiscal.Text
                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = False
                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45


                        If Not X.Item("Movimiento") Then

                            objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontMediano
                            If CInt(X.Item("Nivel")) = 2 Then
                                objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)
                            ElseIf CInt(X.Item("Nivel")) = 3 Then
                                objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Underline = True
                            Else
                                objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Bold = False

                            End If
                        Else
                            objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Bold = False
                            objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Subscript = False
                            objHojaExcel.Range("A" & Fila.ToString, GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                        End If

                        Nivel_Antes = X.Item("Nivel")


                End Select
            Next

            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & Cuenta_Nivel1
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

            If LimiteMes >= 1 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("B" & Fila.ToString).Merge()
                objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 2 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("C" & Fila.ToString).Merge()
                objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 3 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                End If


                objHojaExcel.Range("D" & Fila.ToString).Merge()
                objHojaExcel.Range("D" & Fila.ToString).Value = Valor  '"Dic. " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 4 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("E" & Fila.ToString).Merge()
                objHojaExcel.Range("E" & Fila.ToString).Value = Valor  '"Enero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 5 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("F" & Fila.ToString).Merge()
                objHojaExcel.Range("F" & Fila.ToString).Value = Valor  '"Febrero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 6 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("G" & Fila.ToString).Merge()
                objHojaExcel.Range("G" & Fila.ToString).Value = Valor  '"Marzo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 7 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("H" & Fila.ToString).Merge()
                objHojaExcel.Range("H" & Fila.ToString).Value = Valor  '"Abril " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 8 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("I" & Fila.ToString).Merge()
                objHojaExcel.Range("I" & Fila.ToString).Value = Valor   '"Mayo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 9 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("J" & Fila.ToString).Merge()
                objHojaExcel.Range("J" & Fila.ToString).Value = Valor  '"Junio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 10 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("K" & Fila.ToString).Merge()
                objHojaExcel.Range("K" & Fila.ToString).Value = Valor  '"Julio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 11 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("L" & Fila.ToString).Merge()
                objHojaExcel.Range("L" & Fila.ToString).Value = Valor  '"Agosto " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 12 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("M" & Fila.ToString).Merge()
                objHojaExcel.Range("M" & Fila.ToString).Value = Valor  '"Set " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
            End If

            Valor = 0
            Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel1 And I.Mes = ValorMesAcumulado And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.AcumuladoC)).Sum

            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = Valor  '"Acum. Set " & Me.cboPeriodoFiscal.Text
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & Cuenta_Nivel0
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            If LimiteMes >= 1 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 10 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("B" & Fila.ToString).Merge()
                objHojaExcel.Range("B" & Fila.ToString).Value = Valor
                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 2 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 11 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                End If


                objHojaExcel.Range("C" & Fila.ToString).Merge()
                objHojaExcel.Range("C" & Fila.ToString).Value = Valor
                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
            End If

            If LimiteMes >= 3 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 12 And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("D" & Fila.ToString).Merge()
                objHojaExcel.Range("D" & Fila.ToString).Value = Valor  '"Dic. " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 4 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 1 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("E" & Fila.ToString).Merge()
                objHojaExcel.Range("E" & Fila.ToString).Value = Valor  '"Enero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 5 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 2 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("F" & Fila.ToString).Merge()
                objHojaExcel.Range("F" & Fila.ToString).Value = Valor  '"Febrero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 6 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 3 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If


                objHojaExcel.Range("G" & Fila.ToString).Merge()
                objHojaExcel.Range("G" & Fila.ToString).Value = Valor  '"Marzo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 7 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 4 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                End If

                objHojaExcel.Range("H" & Fila.ToString).Merge()
                objHojaExcel.Range("H" & Fila.ToString).Value = Valor  '"Abril " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 8 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 5 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("I" & Fila.ToString).Merge()
                objHojaExcel.Range("I" & Fila.ToString).Value = Valor   '"Mayo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 9 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 6 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("J" & Fila.ToString).Merge()
                objHojaExcel.Range("J" & Fila.ToString).Value = Valor  '"Junio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 10 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 7 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("K" & Fila.ToString).Merge()
                objHojaExcel.Range("K" & Fila.ToString).Value = Valor  '"Julio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 11 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 8 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                End If

                objHojaExcel.Range("L" & Fila.ToString).Merge()
                objHojaExcel.Range("L" & Fila.ToString).Value = Valor  '"Agosto " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 12 Then
                Valor = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesC)).Sum
                ElseIf Me.cboMoneda.SelectedValue = 2 Then
                    Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = 9 And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.SaldoMesD)).Sum
                End If

                objHojaExcel.Range("M" & Fila.ToString).Merge()
                objHojaExcel.Range("M" & Fila.ToString).Value = Valor  '"Set " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
            End If

            Valor = 0
            Valor = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Where I.IdCuenta = IdCuentaNivel0 And I.Mes = ValorMesAcumulado And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select CDec(I.AcumuladoC)).Sum

            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = Valor  '"Acum. Set " & Me.cboPeriodoFiscal.Text
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

            '************************************************************************************************************************************************
            Fila += 2
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "Utilidad o Perdida Neta del Período "
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

            If LimiteMes >= 1 Then
                mes = 10
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("B" & Fila.ToString).Merge()
                objHojaExcel.Range("B" & Fila.ToString).Value = ING - COS - GAS
                objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 2 Then
                mes = 11
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("C" & Fila.ToString).Merge()
                objHojaExcel.Range("C" & Fila.ToString).Value = ING - COS - GAS
                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 3 Then
                mes = 12
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) - 1 Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("D" & Fila.ToString).Merge()
                objHojaExcel.Range("D" & Fila.ToString).Value = ING - COS - GAS
                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 4 Then
                mes = 1
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("E" & Fila.ToString).Merge()
                objHojaExcel.Range("E" & Fila.ToString).Value = ING - COS - GAS
                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 5 Then
                mes = 2
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("F" & Fila.ToString).Merge()
                objHojaExcel.Range("F" & Fila.ToString).Value = ING - COS - GAS '"Febrero " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 6 Then
                mes = 3
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("G" & Fila.ToString).Merge()
                objHojaExcel.Range("G" & Fila.ToString).Value = ING - COS - GAS '"Marzo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("G" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("G" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("G" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("G" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("G" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 7 Then
                mes = 4
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("H" & Fila.ToString).Merge()
                objHojaExcel.Range("H" & Fila.ToString).Value = ING - COS - GAS '"Abril " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("H" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 8 Then
                mes = 5
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("I" & Fila.ToString).Merge()
                objHojaExcel.Range("I" & Fila.ToString).Value = ING - COS - GAS   '"Mayo " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("I" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 9 Then
                mes = 6
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("J" & Fila.ToString).Merge()
                objHojaExcel.Range("J" & Fila.ToString).Value = ING - COS - GAS '"Junio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("J" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 10 Then
                mes = 7
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("K" & Fila.ToString).Merge()
                objHojaExcel.Range("K" & Fila.ToString).Value = ING - COS - GAS '"Julio " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 11 Then
                mes = 8
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("L" & Fila.ToString).Merge()
                objHojaExcel.Range("L" & Fila.ToString).Value = ING - COS - GAS '"Agosto " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("L" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("L" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("L" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("L" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("L" & Fila.ToString).ColumnWidth = 45
            End If
            If LimiteMes >= 12 Then
                mes = 9
                ING = 0 : COS = 0 : GAS = 0
                If Me.cboMoneda.SelectedValue = 1 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If
                If Me.cboMoneda.SelectedValue = 1 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesC).Sum
                End If
                If Me.cboMoneda.SelectedValue = 2 Then
                    GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = CInt(Me.cboPeriodoFiscal.Text) Select I.SaldoMesD).Sum
                End If

                objHojaExcel.Range("M" & Fila.ToString).Merge()
                objHojaExcel.Range("M" & Fila.ToString).Value = ING - COS - GAS '"Set " & Me.cboPeriodoFiscal.Text
                objHojaExcel.Range("M" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("M" & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range("M" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("M" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range("M" & Fila.ToString).ColumnWidth = 45
            End If

            mes = ValorMesAcumulado
            ING = 0 : COS = 0 : GAS = 0
            If Me.cboMoneda.SelectedValue = 1 Then
                ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoC).Sum
            End If
            If Me.cboMoneda.SelectedValue = 2 Then
                ING = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "INGRESOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoD).Sum
            End If
            If Me.cboMoneda.SelectedValue = 1 Then
                COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoC).Sum
            End If
            If Me.cboMoneda.SelectedValue = 2 Then
                COS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "COSTO VENTA" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoD).Sum
            End If
            If Me.cboMoneda.SelectedValue = 1 Then
                GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoC).Sum
            End If
            If Me.cboMoneda.SelectedValue = 2 Then
                GAS = (From I As dtsReportesNuevos.getEstadoResultadoAnualRow In Me.DtsReportes.getEstadoResultadoAnual Join C As DataRow In dts_Cuentas On C.Item("Id_Cuenta") Equals I.IdCuenta Where C.Item("Tipo") = "GASTOS" And C.Item("Nivel") = 0 And I.Mes = mes And I.Anno = GetAnnyoPeriodoAcumulado(Me.cboPeriodoFiscal.Text, LimiteMes) Select I.AcumuladoD).Sum
            End If

            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = ING - COS - GAS '"Acum. Set " & Me.cboPeriodoFiscal.Text
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

            Dim dt_periodos As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Id_Periodo, Mes from Periodo where Cerrado = 1 and Id_PeriodoFiscal = " & Me.cboPeriodoFiscal.SelectedValue & " order by Anno, mes", dt_periodos, Me.ConConta)
            If dt_periodos.Rows.Count > 0 Then
                Fila += 2
                objHojaExcel.Range("A" & Fila.ToString).Merge()
                objHojaExcel.Range("A" & Fila.ToString).Value = "Impuesto sobre renta "
                objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                objHojaExcel.Range("A" & (Fila + 2).ToString).Merge()
                objHojaExcel.Range("A" & (Fila + 2).ToString).Value = "UTILIDAD NETA DESPUES DE RESERVAS E IMPUESTOS"
                objHojaExcel.Range("A" & (Fila + 2).ToString).Font.Bold = True
                objHojaExcel.Range("A" & (Fila + 2).ToString).Font.Size = FontMediano
                objHojaExcel.Range("A" & (Fila + 2).ToString).Font.Name = FontName
                objHojaExcel.Range("A" & (Fila + 2).ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                Dim dt As New DataTable
                Dim Renta, RentaAcu, UtilNeta, UtilAcuNeta As Decimal
                Dim Texto_Mes As String = "B"
                For i As Integer = 0 To dt_periodos.Rows.Count - 1
                    If LimiteMes >= (i + 1) Then

                        cFunciones.Llenar_Tabla_Generico("exec getIMPUESTO_SOBRE_RENTA " & dt_periodos.Rows(i).Item(0), dt, Me.ConConta)
                        Renta = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(0), dt.Rows(0).Item(1))
                        RentaAcu = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(2), dt.Rows(0).Item(3))
                        UtilNeta = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(4), dt.Rows(0).Item(5))
                        UtilAcuNeta = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(6), dt.Rows(0).Item(7))

                        Select Case dt_periodos.Rows(i).Item("Mes")
                            Case 10 : Texto_Mes = "B"
                            Case 11 : Texto_Mes = "C"
                            Case 12 : Texto_Mes = "D"
                            Case 9 : Texto_Mes = "M"
                            Case 8 : Texto_Mes = "L"
                            Case 7 : Texto_Mes = "K"
                            Case 6 : Texto_Mes = "J"
                            Case 5 : Texto_Mes = "I"
                            Case 4 : Texto_Mes = "H"
                            Case 3 : Texto_Mes = "G"
                            Case 2 : Texto_Mes = "F"
                            Case 1 : Texto_Mes = "E"
                        End Select

                        objHojaExcel.Range(Texto_Mes & Fila.ToString).Merge()
                        objHojaExcel.Range(Texto_Mes & Fila.ToString).Value = Renta
                        objHojaExcel.Range(Texto_Mes & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range(Texto_Mes & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range(Texto_Mes & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range(Texto_Mes & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range(Texto_Mes & Fila.ToString).ColumnWidth = 45

                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).Merge()
                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).Value = UtilNeta
                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).Font.Bold = True
                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).Font.Size = FontPequeño
                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).Font.Name = FontName
                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range(Texto_Mes & (Fila + 2).ToString).ColumnWidth = 45
                    End If
                Next

                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Merge()
                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Value = RentaAcu
                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Bold = True
                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Size = FontPequeño
                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).Font.Name = FontName
                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range(GetCelda(LimiteMes) & Fila.ToString).ColumnWidth = 45

                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).Merge()
                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).Value = UtilAcuNeta
                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).Font.Bold = True
                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).Font.Size = FontPequeño
                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).Font.Name = FontName
                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                objHojaExcel.Range(GetCelda(LimiteMes) & (Fila + 2).ToString).ColumnWidth = 45

            End If


            Me.Enabled = True
            frmEspere.Close()
            m_Excel.Visible = True
        Catch ex As Exception
            Me.Enabled = True
            frmEspere.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub
    Private Sub GeneraExcel_a_TresAnnos()
        Dim frmEspere As New frmCargando
        Try
            frmEspere.Show()
            frmEspere.TopMost = True
            Me.Enabled = False
            Dim Fila As Integer = 0
            Dim FontName = "Trebuchet MS"
            Dim FontGrande = 14
            Dim FontMediano = 10
            Dim FontPequeño = 9
            Dim dts_Conf As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from configuraciones", dts_Conf, Me.ConConta)

            m_Excel = New Excel.Application
            m_Excel.Visible = False

            objLibroExcel = m_Excel.Workbooks.Add()
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Value = dts_Conf.Rows(0).Item("Empresa")
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Size = FontGrande
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Value = "Estado de Resultados"
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Size = FontGrande
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Value = "Por el periodo terminado al " & GetTextoPeriodoTerminado(Me.cboPeriodoT.Text.ToString)
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Bold = False
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Value = "(en " & Me.cboMoneda.Text.ToLower & " sin céntimos)"
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Bold = False
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").Merge()
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").Value = "Comparativo Mensual " & Me.cboPeriodoT.Text.Remove(0, 1) & " - " & getAnnoPeriodoAnterior(Me.cboPeriodoT.SelectedValue) & " - " & getAnnoPeriodoAnterior(Me.cboPeriodoT.SelectedValue, 2)
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").Font.Size = FontPequeño
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            objHojaExcel.Range("C" & Fila.ToString & ":E" & Fila.ToString & "").ColumnWidth = 45

            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").Merge()
            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").Value = "Comparativo Acumuldo " & Me.cboPeriodoT.Text.Remove(0, 1) & " - " & getAnnoPeriodoAnterior(Me.cboPeriodoT.SelectedValue) & " - " & getAnnoPeriodoAnterior(Me.cboPeriodoT.SelectedValue, 2)
            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").Font.Size = FontPequeño
            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            objHojaExcel.Range("H" & Fila.ToString & ":J" & Fila.ToString & "").ColumnWidth = 45
            Fila += 1
            'objHojaExcel.Range("B" & Fila.ToString).Merge()
            'objHojaExcel.Range("B" & Fila.ToString).Value = getEncabezado(Me.cboPeriodoT.Text)
            'objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
            'objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
            'objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
            'objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = getEncabezado(Me.cboPeriodoT.Text)
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = getEncabezado(getPeriodoAnterior(Me.cboPeriodoT.SelectedValue))
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = getEncabezado(getPeriodoAnterior(Me.cboPeriodoT.SelectedValue, 2))
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("F" & Fila.ToString).Merge()
            objHojaExcel.Range("F" & Fila.ToString).Value = "Variacion " & Me.cboPeriodoFiscal.Text & " -> " & getAnnoPeriodoAnterior(Me.cboPeriodoT.SelectedValue)
            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("H" & Fila.ToString).Merge()
            objHojaExcel.Range("H" & Fila.ToString).Value = "ACUM. " & getEncabezado(Me.cboPeriodoT.Text)
            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("I" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = "ACUM. " & getEncabezado(getPeriodoAnterior(Me.cboPeriodoT.SelectedValue))
            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("J" & Fila.ToString).Merge()
            objHojaExcel.Range("J" & Fila.ToString).Value = "ACUM. " & getEncabezado(getPeriodoAnterior(Me.cboPeriodoT.SelectedValue, 2))
            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("K" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = "Variacion " & Me.cboPeriodoFiscal.Text & " -> " & getAnnoPeriodoAnterior(Me.cboPeriodoT.SelectedValue)
            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            Dim NivelAntes As Integer = 0
            Dim DescripcionAntes As String
            Dim DescripcionAntes2 As String
            Dim M1ANTES, M2ANTES, M3ANTES, ACUM1ANTES, ACUM2ANTES, ACUM3ANTES As Decimal
            Dim M1ANTES2, M2ANTES2, M3ANTES2, ACUM1ANTES2, ACUM2ANTES2, ACUM3ANTES2 As Decimal
            Dim Pasivos1, Pasivos2, Patrimonio1, Patrimonio2 As Decimal

            For Each X As dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow In Me.DtsReportes.getEstadosResultadosMensuala3Annos.Rows
                Select Case X.Nivel
                    Case 0
                        If NivelAntes = 2 Then
                            Fila += 1
                            objHojaExcel.Range("A" & Fila.ToString).Merge()
                            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

                            objHojaExcel.Range("C" & Fila.ToString).Merge()
                            objHojaExcel.Range("C" & Fila.ToString).Value = M1ANTES
                            objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = M2ANTES
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = M3ANTES
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("F" & Fila.ToString).Merge()
                            objHojaExcel.Range("F" & Fila.ToString).Value = M1ANTES - M2ANTES
                            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("H" & Fila.ToString).Merge()
                            objHojaExcel.Range("H" & Fila.ToString).Value = ACUM1ANTES
                            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("I" & Fila.ToString).Merge()
                            objHojaExcel.Range("I" & Fila.ToString).Value = ACUM2ANTES
                            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("J" & Fila.ToString).Merge()
                            objHojaExcel.Range("J" & Fila.ToString).Value = ACUM3ANTES
                            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("K" & Fila.ToString).Merge()
                            objHojaExcel.Range("K" & Fila.ToString).Value = ACUM1ANTES - ACUM2ANTES
                            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                            '***********************************************************************
                            Fila += 1
                            objHojaExcel.Range("A" & Fila.ToString).Merge()
                            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes2
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

                            objHojaExcel.Range("C" & Fila.ToString).Merge()
                            objHojaExcel.Range("C" & Fila.ToString).Value = M1ANTES2
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = M2ANTES2
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = M3ANTES2
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("F" & Fila.ToString).Merge()
                            objHojaExcel.Range("F" & Fila.ToString).Value = M1ANTES2 - M2ANTES2
                            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("H" & Fila.ToString).Merge()
                            objHojaExcel.Range("H" & Fila.ToString).Value = ACUM1ANTES2
                            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("I" & Fila.ToString).Merge()
                            objHojaExcel.Range("I" & Fila.ToString).Value = ACUM2ANTES2
                            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("J" & Fila.ToString).Merge()
                            objHojaExcel.Range("J" & Fila.ToString).Value = ACUM3ANTES2
                            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("K" & Fila.ToString).Merge()
                            objHojaExcel.Range("K" & Fila.ToString).Value = ACUM1ANTES2 - ACUM2ANTES2
                            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            If X.CuentaContable(0) = "6" Then
                                Dim Bruta As Generic.List(Of dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow)

                                Bruta = (From B As dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow In Me.DtsReportes.getEstadosResultadosMensuala3Annos Where B.CuentaContable(9) <> "6" And B.Nivel = 0 Select B Order By B.CuentaContable).ToList

                                Fila += 2
                                objHojaExcel.Range("A" & Fila.ToString).Merge()
                                objHojaExcel.Range("A" & Fila.ToString).Value = "Utilidad Neta de Operación "
                                objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                                objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

                                objHojaExcel.Range("C" & Fila.ToString).Merge()
                                objHojaExcel.Range("C" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, Bruta(0).SMES1C - Bruta(1).SMES1C, Bruta(0).SMES1D - Bruta(1).SMES1D)
                                objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("D" & Fila.ToString).Merge()
                                objHojaExcel.Range("D" & Fila.ToString).Value = Me.cboMoneda.SelectedValue = IIf(1, Bruta(0).SMES2C - Bruta(1).SMES2C, Bruta(0).SMES2D - Bruta(1).SMES2D)
                                objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("E" & Fila.ToString).Merge()
                                objHojaExcel.Range("E" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, Bruta(0).SMES3C - Bruta(1).SMES3C, Bruta(0).SMES3D - Bruta(1).SMES3D)
                                objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("F" & Fila.ToString).Merge()
                                objHojaExcel.Range("F" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, (Bruta(0).SMES1C - Bruta(1).SMES1C) - (Bruta(0).SMES2C - Bruta(1).SMES2C), (Bruta(0).SMES1D - Bruta(1).SMES1D) - (Bruta(0).SMES2D - Bruta(1).SMES2D))
                                objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("H" & Fila.ToString).Merge()
                                objHojaExcel.Range("H" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, Bruta(0).ACUM1C - Bruta(1).ACUM1C, Bruta(0).ACUM1D - Bruta(1).ACUM1D)
                                objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("I" & Fila.ToString).Merge()
                                objHojaExcel.Range("I" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, Bruta(0).ACUM2C - Bruta(1).ACUM2C, Bruta(0).ACUM2D - Bruta(1).ACUM2D)
                                objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("J" & Fila.ToString).Merge()
                                objHojaExcel.Range("J" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, Bruta(0).ACUM3C - Bruta(1).ACUM3C, Bruta(0).ACUM3D - Bruta(1).ACUM3D)
                                objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                                objHojaExcel.Range("K" & Fila.ToString).Merge()
                                objHojaExcel.Range("K" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, (Bruta(0).ACUM1C - Bruta(1).ACUM1C) - (Bruta(0).ACUM2C - Bruta(1).ACUM2C), (Bruta(0).ACUM1D - Bruta(1).ACUM1D) - (Bruta(0).ACUM2D - Bruta(1).ACUM2D))
                                objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                                objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
                                objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                                objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                                Fila += 1
                                '*************************************************************************************************************
                                'Pasivos1 = M1ANTES
                                'Pasivos2 = M2ANTES
                            End If
                            'If X.CuentaContable(0) = "3" Then
                            '    Patrimonio1 = M1ANTES
                            '    Patrimonio2 = M2ANTES
                            'End If
                        End If

                        Fila += 1
                        If X.Descripcion.Equals("GASTO DE DEPRECIACION Y AMORTIZACION") Then
                            Fila += 1
                        End If
                        If X.Descripcion.Equals("GASTOS FINANCIEROS") Then
                            Fila += 1
                        End If
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Descripcion
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName

                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

                        NivelAntes = X.Nivel

                        M1ANTES2 = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES1C, X.SMES1D)
                        M2ANTES2 = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES2C, X.SMES2D)
                        M3ANTES2 = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES3C, X.SMES2D)
                        ACUM1ANTES2 = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM1C, X.ACUM1D)
                        ACUM2ANTES2 = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM2C, X.ACUM2D)
                        ACUM3ANTES2 = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM3C, X.ACUM3D)

                        DescripcionAntes2 = X.Descripcion

                    Case 1
                        If NivelAntes = 2 Then
                            Fila += 1
                            objHojaExcel.Range("A" & Fila.ToString).Merge()
                            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes
                            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

                            objHojaExcel.Range("C" & Fila.ToString).Merge()
                            objHojaExcel.Range("C" & Fila.ToString).Value = M1ANTES
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = M2ANTES
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = M3ANTES
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("F" & Fila.ToString).Merge()
                            objHojaExcel.Range("F" & Fila.ToString).Value = M1ANTES - M2ANTES
                            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("H" & Fila.ToString).Merge()
                            objHojaExcel.Range("H" & Fila.ToString).Value = ACUM1ANTES
                            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("I" & Fila.ToString).Merge()
                            objHojaExcel.Range("I" & Fila.ToString).Value = ACUM2ANTES
                            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("J" & Fila.ToString).Merge()
                            objHojaExcel.Range("J" & Fila.ToString).Value = ACUM3ANTES
                            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("K" & Fila.ToString).Merge()
                            objHojaExcel.Range("K" & Fila.ToString).Value = ACUM1ANTES - ACUM2ANTES
                            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        End If
                        Fila += 1
                        If X.Descripcion.Equals("GASTO DE DEPRECIACION Y AMORTIZACION") Then
                            Fila += 1
                        End If
                        If X.Descripcion.Equals("GASTOS FINANCIEROS") Then
                            Fila += 1
                        End If
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Descripcion
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45
                        DescripcionAntes = X.Descripcion

                        M1ANTES = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES1C, X.SMES1D)
                        M2ANTES = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES2C, X.SMES2D)
                        M3ANTES = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES3C, X.SMES3D)
                        ACUM1ANTES = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM1C, X.ACUM1D)
                        ACUM2ANTES = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM2C, X.ACUM2D)
                        ACUM3ANTES = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM3C, X.ACUM3D)

                        NivelAntes = X.Nivel

                    Case Else
                        Fila += 1
                        Dim negrita As Boolean = False
                        Dim subrayado As Boolean = False
                        If Not EsCuentaMov(X.CuentaContable) Then
                            If X.Nivel = 2 Then
                                negrita = True
                                subrayado = True

                            End If
                            If X.Nivel = 3 Then
                                subrayado = True

                            End If
                        End If
                        If X.Descripcion.Equals("GASTO DE DEPRECIACION Y AMORTIZACION") Then
                            Fila += 1
                        End If
                        If X.Descripcion.Equals("GASTOS FINANCIEROS") Then
                            Fila += 1
                        End If

                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Descripcion
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("A" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45
                        If negrita And subrayado Then
                            objHojaExcel.Range("A" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If
                        objHojaExcel.Range("B" & Fila.ToString).Merge()
                        objHojaExcel.Range("B" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("B" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("B" & Fila.ToString).ColumnWidth = 10
                        If negrita And subrayado Then
                            objHojaExcel.Range("B" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("C" & Fila.ToString).Merge()
                        objHojaExcel.Range("C" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES1C, X.SMES1D)
                        objHojaExcel.Range("C" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                        objHojaExcel.Range("C" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        If negrita And subrayado Then
                            objHojaExcel.Range("C" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("D" & Fila.ToString).Merge()
                        objHojaExcel.Range("D" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES2C, X.SMES2D)
                        objHojaExcel.Range("D" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("D" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        If negrita And subrayado Then
                            objHojaExcel.Range("D" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("E" & Fila.ToString).Merge()
                        objHojaExcel.Range("E" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES3C, X.SMES3D)
                        objHojaExcel.Range("E" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("E" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        If negrita And subrayado Then
                            objHojaExcel.Range("E" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("F" & Fila.ToString).Merge()
                        objHojaExcel.Range("F" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.SMES1C - X.SMES2C, X.SMES1D - X.SMES2D)
                        objHojaExcel.Range("F" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("F" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("F" & Fila.ToString).ColumnWidth = 45
                        If negrita And subrayado Then
                            objHojaExcel.Range("F" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("H" & Fila.ToString).Merge()
                        objHojaExcel.Range("H" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM1C, X.ACUM1D)
                        objHojaExcel.Range("H" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("H" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        If negrita And subrayado Then
                            objHojaExcel.Range("H" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("I" & Fila.ToString).Merge()
                        objHojaExcel.Range("I" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM2C, X.ACUM2D)
                        objHojaExcel.Range("I" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("I" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        If negrita And subrayado Then
                            objHojaExcel.Range("I" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("J" & Fila.ToString).Merge()
                        objHojaExcel.Range("J" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM3C, X.ACUM3D)
                        objHojaExcel.Range("J" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("J" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        If negrita And subrayado Then
                            objHojaExcel.Range("J" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If

                        objHojaExcel.Range("K" & Fila.ToString).Merge()
                        objHojaExcel.Range("K" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.ACUM1C - X.ACUM2C, X.ACUM1D - X.ACUM2D)
                        objHojaExcel.Range("K" & Fila.ToString).Font.Bold = negrita
                        objHojaExcel.Range("K" & Fila.ToString).Font.Underline = subrayado
                        objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        objHojaExcel.Range("K" & Fila.ToString).ColumnWidth = 45
                        If negrita And subrayado Then
                            objHojaExcel.Range("K" & Fila.ToString).Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightGray)

                        End If
                        NivelAntes = X.Nivel
                End Select
            Next

            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = M1ANTES
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = M2ANTES
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = M3ANTES
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("F" & Fila.ToString).Merge()
            objHojaExcel.Range("F" & Fila.ToString).Value = M1ANTES - M2ANTES
            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("H" & Fila.ToString).Merge()
            objHojaExcel.Range("H" & Fila.ToString).Value = ACUM1ANTES
            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("I" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = ACUM2ANTES
            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("J" & Fila.ToString).Merge()
            objHojaExcel.Range("J" & Fila.ToString).Value = ACUM3ANTES
            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("K" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = ACUM1ANTES - ACUM2ANTES
            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes2
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = M1ANTES2
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = M2ANTES2
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = M3ANTES2
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("F" & Fila.ToString).Merge()
            objHojaExcel.Range("F" & Fila.ToString).Value = M1ANTES2 - M2ANTES2
            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("H" & Fila.ToString).Merge()
            objHojaExcel.Range("H" & Fila.ToString).Value = ACUM1ANTES2
            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("I" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = ACUM2ANTES2
            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("J" & Fila.ToString).Merge()
            objHojaExcel.Range("J" & Fila.ToString).Value = ACUM3ANTES2
            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("K" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = ACUM1ANTES2 - ACUM2ANTES2
            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            Dim N As Generic.List(Of dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow)
            N = (From B As dtsReportesNuevos.getEstadosResultadosMensuala3AnnosRow In Me.DtsReportes.getEstadosResultadosMensuala3Annos Where B.Nivel = 0 Select B Order By B.CuentaContable).ToList

            Fila += 2
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "Utilidad o Perdida Neta del Período "
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, N(0).SMES1C - N(1).SMES1C - N(2).SMES1C, N(0).SMES1D - N(1).SMES1D - N(2).SMES1D)
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, N(0).SMES2C - N(1).SMES2C - N(2).SMES2C, N(0).SMES2D - N(1).SMES2D - N(2).SMES2D)
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, N(0).SMES3C - N(1).SMES3C - N(2).SMES3C, N(0).SMES3D - N(1).SMES3D - N(2).SMES3D)
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("F" & Fila.ToString).Merge()
            objHojaExcel.Range("F" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, (N(0).SMES1C - N(1).SMES1C - N(2).SMES1C) - (N(0).SMES2C - N(1).SMES2C - N(2).SMES2C), (N(0).SMES1D - N(1).SMES1D - N(2).SMES1D) - (N(0).SMES2D - N(1).SMES2D - N(2).SMES2D))
            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("H" & Fila.ToString).Merge()
            objHojaExcel.Range("H" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, N(0).ACUM1C - N(1).ACUM1C - N(2).ACUM1C, N(0).ACUM1D - N(1).ACUM1D - N(2).ACUM1D)
            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("I" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, N(0).ACUM2C - N(1).ACUM2C - N(2).ACUM2C, N(0).ACUM2D - N(1).ACUM2D - N(2).ACUM2D)
            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("J" & Fila.ToString).Merge()
            objHojaExcel.Range("J" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, N(0).ACUM3C - N(1).ACUM3C - N(2).ACUM3C, N(0).ACUM3D - N(1).ACUM3D - N(2).ACUM3D)
            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("K" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, (N(0).ACUM1C - N(1).ACUM1C - N(2).ACUM1C) - (N(0).ACUM2C - N(1).ACUM2C - N(2).ACUM2C), (N(0).ACUM1D - N(1).ACUM1D - N(2).ACUM1D) - (N(0).ACUM2D - N(1).ACUM2D - N(2).ACUM2D))
            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            '***************************************************************************************************************************************************************************************************************************************************************************************

            Dim dt As New DataTable
            Dim Renta1, Renta2, Renta3, RentaAcu1, RentaAcu2, RentaAcu3, UtilNeta1, UtilNeta2, UtilNeta3, UtilAcuNeta1, UtilAcuNeta2, UtilAcuNeta3 As Decimal

            Fila += 2
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "Impuesto sobre renta "
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            cFunciones.Llenar_Tabla_Generico("exec getIMPUESTO_SOBRE_RENTA " & Me.cboPeriodoT.SelectedValue, dt, Me.ConConta)
            Renta1 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(0), dt.Rows(0).Item(1))
            RentaAcu1 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(2), dt.Rows(0).Item(3))
            UtilNeta1 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(4), dt.Rows(0).Item(5))
            UtilAcuNeta1 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(6), dt.Rows(0).Item(7))
            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = Renta1
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            cFunciones.Llenar_Tabla_Generico("exec getIMPUESTO_SOBRE_RENTA " & getPeriodoAnterior2(Me.cboPeriodoT.SelectedValue, 1), dt, Me.ConConta)
            Renta2 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(0), dt.Rows(0).Item(1))
            RentaAcu2 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(2), dt.Rows(0).Item(3))
            UtilNeta2 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(4), dt.Rows(0).Item(5))
            UtilAcuNeta2 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(6), dt.Rows(0).Item(7))
            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = Renta2
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            cFunciones.Llenar_Tabla_Generico("exec getIMPUESTO_SOBRE_RENTA " & getPeriodoAnterior2(Me.cboPeriodoT.SelectedValue, 2), dt, Me.ConConta)
            Renta3 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(0), dt.Rows(0).Item(1))
            RentaAcu3 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(2), dt.Rows(0).Item(3))
            UtilNeta3 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(4), dt.Rows(0).Item(5))
            UtilAcuNeta3 = IIf(Me.cboMoneda.SelectedValue = 1, dt.Rows(0).Item(6), dt.Rows(0).Item(7))
            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = Renta3
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("F" & Fila.ToString).Merge()
            objHojaExcel.Range("F" & Fila.ToString).Value = Renta1 - Renta2
            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("H" & Fila.ToString).Merge()
            objHojaExcel.Range("H" & Fila.ToString).Value = RentaAcu1
            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("I" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = RentaAcu2
            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("J" & Fila.ToString).Merge()
            objHojaExcel.Range("J" & Fila.ToString).Value = RentaAcu3
            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("K" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = RentaAcu1 - RentaAcu2
            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight


            ')))))))))))))))))))))))))))))

            Fila += 2
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "UTILIDAD NETA DESPUES DE RESERVAS E IMPUESTOS "
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = UtilNeta1
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = UtilNeta2
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = UtilNeta3
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("F" & Fila.ToString).Merge()
            objHojaExcel.Range("F" & Fila.ToString).Value = UtilNeta1 - UtilNeta2
            objHojaExcel.Range("F" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("F" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("F" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("F" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            objHojaExcel.Range("H" & Fila.ToString).Merge()
            objHojaExcel.Range("H" & Fila.ToString).Value = UtilAcuNeta1
            objHojaExcel.Range("H" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("H" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("H" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("H" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("I" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = UtilAcuNeta2
            objHojaExcel.Range("I" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("J" & Fila.ToString).Merge()
            objHojaExcel.Range("J" & Fila.ToString).Value = UtilAcuNeta3
            objHojaExcel.Range("J" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("J" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("J" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("J" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("K" & Fila.ToString).Merge()
            objHojaExcel.Range("K" & Fila.ToString).Value = UtilAcuNeta1 - UtilAcuNeta2
            objHojaExcel.Range("K" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("K" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("K" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            Me.Enabled = True
            frmEspere.Close()
            m_Excel.Visible = True
        Catch ex As Exception
            Me.Enabled = True
            frmEspere.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub frmEstadosResultados1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.cboComparativo.SelectedIndex = 0
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
            Select Case Me.cboComparativo.SelectedIndex
                Case 0
                    cFunciones.Llenar_Tabla_Generico("exec getEstadosResultadosMensuala3Annos " & Me.cboPeriodoT.SelectedValue, Me.DtsReportes.getEstadosResultadosMensuala3Annos, Me.ConConta)
                    GeneraExcel_a_TresAnnos()
                Case 1
                    cFunciones.Llenar_Tabla_Generico("exec getEstadoResultadoAnual " & Me.cboPeriodoFiscal.SelectedValue, Me.DtsReportes.getEstadoResultadoAnual, Me.ConConta)
                    GeneraExcelAnyoFiscal()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub
    Function EsCuentaMov(cuenta As String) As Boolean
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT [CuentaContable], Id,[Movimiento] FROM [Contabilidad].[dbo].[CuentaContable] WHERE CuentaContable =@cuenta"
        cmd.Parameters.AddWithValue("@cuenta", cuenta)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion("Contabilidad"))
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Movimiento")
        Else
            Return False

        End If
    End Function
    Private Sub cboPeriodoFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoFiscal.SelectedIndexChanged
        On Error Resume Next
        CargarPeriodosTrabajo(Me.cboPeriodoFiscal.SelectedValue)
    End Sub

End Class