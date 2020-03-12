Imports Microsoft.Office.Interop
Public Class frmBalanceSituancionNuevo
    Private ConConta As String = Configuracion.Claves.Conexion("Contabilidad")
    Private CuentaUtilidad As String
    Private CuentaMadreUtilidad As String

    Dim m_Excel As Excel.Application
    Dim objLibroExcel As Excel.Workbook 'Creamos un objeto WorkBook
    Dim objHojaExcel As Excel.Worksheet 'Creamos un objeto WorkSheet

    Private Function Valida(ByVal _periodo As String) As Boolean
        Dim dts As New DataTable
        If Me.cboComparativo.SelectedIndex = 0 Then
            cFunciones.Llenar_Tabla_Generico("select COUNT(*) from Contabilidad.dbo.Periodo as Ac inner join Contabilidad.dbo.Periodo as An on an.Mes = (case ac.mes when 1 then 12 else ac.Mes - 1 end) and an.Anno = (case ac.mes when 1 then ac.Anno -1 else ac.Anno end) inner join CierresPeriodos as CP on An.Id_Periodo = CP.IdPeriodoTrabajo where ac.Id_Periodo = " & _periodo, dts, Me.ConConta)
            If dts.Rows.Count > 0 Then
                If dts.Rows(0).Item(0) = 0 Then
                    Return False
                End If
            Else
                Return False
            End If
        End If

        If Me.cboComparativo.SelectedIndex = 1 Then
            cFunciones.Llenar_Tabla_Generico("select COUNT(*) from Contabilidad.dbo.Periodo as Ac inner join Contabilidad.dbo.Periodo as An on An.Mes = Ac.Mes and An.Anno = (Ac.Anno - 1) inner join CierresPeriodos as CP on an.Id_Periodo = CP.IdPeriodoTrabajo where ac.Id_Periodo = " & _periodo, dts, Me.ConConta)
            If dts.Rows.Count > 0 Then
                If dts.Rows(0).Item(0) = 0 Then
                    Return False
                End If
            Else
                Return False
            End If
        End If
        Return True
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

    Private Function AnoyFebrero(ByVal _anyo As Integer) As Integer
        If (_anyo Mod 4 = 0 And _anyo Mod 100 <> 0 Or _anyo Mod 400 = 0) Then
            Return 29
        Else
            Return 28
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

    Private Sub GetCuentaUtilidad()
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select cc.CuentaContable, cc.CuentaMadre from SettingCuentaContable as sc inner join CuentaContable  as cc on cc.id = sc.IdPeriodo", dts, Me.ConConta)
        If dts.Rows.Count > 0 Then
            Me.CuentaUtilidad = dts.Rows(0).Item(0)
            Me.CuentaMadreUtilidad = dts.Rows(0).Item(1)
        Else
            MsgBox("Antes de proseguir debe de configurar una cuenta de utilidad.", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub

    Private Function getUtilidad(ByVal _periodo As String, ByVal _tipo As Integer) As DataTable
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("EXEC getUtilidadPeriodo " & _periodo & ", " & _tipo, dts, Me.ConConta)
            Return dts
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Function

    Private Function getPeriodoAnterior(ByVal _idperiodo As String) As String
        Dim dts As New DataTable
        If Me.cboComparativo.SelectedIndex = 0 Then
            cFunciones.Llenar_Tabla_Generico("select An.Periodo from Contabilidad.dbo.Periodo as Ac inner join Contabilidad.dbo.Periodo as An on an.Mes = (case ac.mes when 1 then 12 else ac.Mes - 1 end) and an.Anno = (case ac.mes when 1 then ac.Anno -1 else ac.Anno end) where ac.Id_Periodo = " & _idperiodo, dts, Me.ConConta)
        End If
        If Me.cboComparativo.SelectedIndex = 1 Then
            cFunciones.Llenar_Tabla_Generico("select An.Periodo from Contabilidad.dbo.Periodo as Ac inner join Contabilidad.dbo.Periodo as An on An.Mes = Ac.Mes and An.Anno = (Ac.Anno - 1) where ac.Id_Periodo = " & _idperiodo, dts, Me.ConConta)
        End If
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item("Periodo")
        Else
            Return ""
        End If
    End Function

    Private Sub GeneraExcel()
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
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Value = dts_Conf.Rows(0).Item("Empresa")
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Size = FontGrande
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Value = "BALANCE DE SITUACIÓN"
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Size = FontGrande
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Value = "Por el periodo terminado al " & Me.GetTextoPeriodoTerminado(Me.cboPeriodoT.Text).ToString
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Bold = False
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Merge()
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Value = "(en " & Me.cboMoneda.Text.ToLower & " sin céntimos)"
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Bold = False
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString & ":E" & Fila.ToString & "").HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            Fila += 2
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = ""
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("B" & Fila.ToString).Merge()
            objHojaExcel.Range("B" & Fila.ToString).Value = "NOTAS"
            objHojaExcel.Range("B" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = getEncabezado(Me.cboPeriodoT.Text.ToUpper)
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = getEncabezado(getPeriodoAnterior(Me.cboPeriodoT.SelectedValue).ToUpper)
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = "Variacion".ToUpper
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter

            Dim NivelAntes As Integer = 0
            Dim DescripcionAntes As String
            Dim DescripcionAntes2 As String
            Dim P1Antes, P2Antes As Decimal
            Dim P1Antes2, P2Antes2 As Decimal
            Dim Pasivos1, Pasivos2, Patrimonio1, Patrimonio2 As Decimal
            Dim M1C, M1D, M2C, M2D As Decimal

            For Each X As dtsReportesNuevos.getBalanceSituacionRow In Me.DtsReportes.getBalanceSituacion.Rows
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
                            objHojaExcel.Range("C" & Fila.ToString).Value = P1Antes
                            objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = P2Antes
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = P1Antes - P2Antes
                            objHojaExcel.Range("E" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
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
                            objHojaExcel.Range("C" & Fila.ToString).Value = P1Antes2
                            objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = P2Antes2
                            objHojaExcel.Range("D" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = P1Antes2 - P2Antes2
                            objHojaExcel.Range("E" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            'If X.CuentaContable(0) = "2" Then
                            '    Pasivos1 = P1Antes
                            '    Pasivos2 = P2Antes
                            'End If

                            'If X.CuentaContable(0) = "3" Then
                            '    'aqui
                            '    Patrimonio1 += P1Antes
                            '    Patrimonio2 += P2Antes
                            'End If
                        End If

                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Descripcion
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45
                        NivelAntes = X.Nivel
                        P1Antes2 = IIf(Me.cboMoneda.SelectedValue = 1, X.P1C, X.P1D)
                        P2Antes2 = IIf(Me.cboMoneda.SelectedValue = 1, X.P2C, X.P2D)
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
                            objHojaExcel.Range("C" & Fila.ToString).Value = P1Antes
                            objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("D" & Fila.ToString).Merge()
                            objHojaExcel.Range("D" & Fila.ToString).Value = P2Antes
                             objHojaExcel.Range("D" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                            objHojaExcel.Range("E" & Fila.ToString).Merge()
                            objHojaExcel.Range("E" & Fila.ToString).Value = P1Antes - P2Antes
                            objHojaExcel.Range("E" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
                            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
                            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        End If
                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Descripcion
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45
                        DescripcionAntes = X.Descripcion
                        P1Antes = IIf(Me.cboMoneda.SelectedValue = 1, X.P1C, X.P1D)
                        P2Antes = IIf(Me.cboMoneda.SelectedValue = 1, X.P2C, X.P2D)
                        NivelAntes = X.Nivel
                    Case Else
                        If X.CuentaContable = Me.CuentaUtilidad Then
                            Dim dts1 As New DataTable
                            dts1 = Me.getUtilidad(Me.cboPeriodoT.SelectedValue, Me.cboComparativo.SelectedIndex)
                            M1C = dts1.Rows(0).Item("Utilidad1C")
                            M1D = dts1.Rows(0).Item("Utilidad1D")
                            M2C = dts1.Rows(0).Item("Utilidad2C")
                            M2D = dts1.Rows(0).Item("Utilidad2D")
                        Else
                            M1C = 0
                            M1D = 0
                            M2C = 0
                            M2D = 0
                        End If
                        Fila += 1
                        objHojaExcel.Range("A" & Fila.ToString).Merge()
                        objHojaExcel.Range("A" & Fila.ToString).Value = X.Descripcion
                        objHojaExcel.Range("A" & Fila.ToString).Font.Bold = False
                        objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
                        objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

                        objHojaExcel.Range("B" & Fila.ToString).Merge()
                        objHojaExcel.Range("B" & Fila.ToString).Value = X.Notas
                        objHojaExcel.Range("B" & Fila.ToString).Font.Bold = False
                        objHojaExcel.Range("B" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("B" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("B" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft

                        objHojaExcel.Range("C" & Fila.ToString).Merge()
                        objHojaExcel.Range("C" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.P1C + M1C, X.P1D + M1D)
                        objHojaExcel.Range("C" & Fila.ToString).Style.NumberFormat = "#.##0,00"
                        objHojaExcel.Range("C" & Fila.ToString).Font.Bold = False
                        objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                        objHojaExcel.Range("D" & Fila.ToString).Merge()
                        objHojaExcel.Range("D" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, X.P2C + M2C, X.P2D + M2D)
                        objHojaExcel.Range("D" & Fila.ToString).Font.Bold = False
                        objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

                        objHojaExcel.Range("E" & Fila.ToString).Merge()
                        objHojaExcel.Range("E" & Fila.ToString).Value = IIf(Me.cboMoneda.SelectedValue = 1, (X.P1C + M1C) - (X.P2C + M2C), (X.P1D + M1D) - (X.P2D + M2D))
                        objHojaExcel.Range("E" & Fila.ToString).Font.Bold = False
                        objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontPequeño
                        objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
                        objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
                        NivelAntes = X.Nivel
                End Select
            Next

            Dim Datos As Generic.List(Of dtsReportesNuevos.getBalanceSituacionRow) = (From X As dtsReportesNuevos.getBalanceSituacionRow In Me.DtsReportes.getBalanceSituacion Where X.Nivel = 0 And X.CuentaContable(0) <> "1" Select X).ToList()
            Dim dts As New DataTable
            dts = Me.getUtilidad(Me.cboPeriodoT.SelectedValue, Me.cboComparativo.SelectedIndex)
            M1C = dts.Rows(0).Item("Utilidad1C")
            M1D = dts.Rows(0).Item("Utilidad1D")
            M2C = dts.Rows(0).Item("Utilidad2C")
            M2D = dts.Rows(0).Item("Utilidad2D")

            Fila += 1

            P1Antes += IIf(Me.cboMoneda.SelectedValue = 1, M1C, M1D)
            P2Antes += IIf(Me.cboMoneda.SelectedValue = 1, M2C, M2D)

            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = P1Antes
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = P2Antes
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = P1Antes - P2Antes
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            Fila += 1
            P1Antes2 += IIf(Me.cboMoneda.SelectedValue = 1, M1C, M1D)
            P2Antes2 += IIf(Me.cboMoneda.SelectedValue = 1, M2C, M2D)

            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL " & DescripcionAntes2
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = P1Antes2
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = P2Antes2
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = P1Antes2 - P2Antes2
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight

            Pasivos1 = IIf(Me.cboMoneda.SelectedValue = 1, Datos(0).P1C, Datos(0).P1D)
            Pasivos2 = IIf(Me.cboMoneda.SelectedValue = 1, Datos(0).P2C, Datos(0).P2D)
            Patrimonio1 = IIf(Me.cboMoneda.SelectedValue = 1, Datos(1).P1C + M1C, Datos(1).P1D + M1D)
            Patrimonio2 = IIf(Me.cboMoneda.SelectedValue = 1, Datos(1).P2C + M2C, Datos(1).P2D + M2D)

            Fila += 1
            objHojaExcel.Range("A" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = "TOTAL PASIVO + PATRIMONIO "
            objHojaExcel.Range("A" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlLeft
            objHojaExcel.Range("A" & Fila.ToString).ColumnWidth = 45

            objHojaExcel.Range("C" & Fila.ToString).Merge()
            objHojaExcel.Range("C" & Fila.ToString).Value = Pasivos1 + Patrimonio1
            objHojaExcel.Range("C" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("C" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("C" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("C" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            objHojaExcel.Range("C" & Fila.ToString).ColumnWidth = 16
            objHojaExcel.Range("C" & Fila.ToString).WrapText = True

            objHojaExcel.Range("D" & Fila.ToString).Merge()
            objHojaExcel.Range("D" & Fila.ToString).Value = Pasivos2 + Patrimonio2
            objHojaExcel.Range("D" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("D" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("D" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("D" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            objHojaExcel.Range("D" & Fila.ToString).ColumnWidth = 16
            objHojaExcel.Range("D" & Fila.ToString).WrapText = True

            objHojaExcel.Range("E" & Fila.ToString).Merge()
            objHojaExcel.Range("E" & Fila.ToString).Value = (Pasivos1 + Patrimonio1) - (Pasivos2 + Patrimonio2)
            objHojaExcel.Range("E" & Fila.ToString).Font.Bold = True
            objHojaExcel.Range("E" & Fila.ToString).Font.Size = FontMediano
            objHojaExcel.Range("E" & Fila.ToString).Font.Name = FontName
            objHojaExcel.Range("E" & Fila.ToString).HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlRight
            objHojaExcel.Range("E" & Fila.ToString).ColumnWidth = 16
            objHojaExcel.Range("E" & Fila.ToString).WrapText = True

            Me.Enabled = True
            frmEspere.Close()
            m_Excel.Visible = True
        Catch ex As Exception
            Me.Enabled = True
            frmEspere.Close()
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub frmBalanceSituancionNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PeriodoTableAdapter.Connection.ConnectionString = ConConta
        Me.PeriodoFiscalTableAdapter.Connection.ConnectionString = ConConta
        Me.cmdGetBalance.Connection.ConnectionString = ConConta
        Me.PeriodoFiscalTableAdapter.Fill(Me.DtsReportes.PeriodoFiscal)

        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select CodMoneda, MonedaNombre from Moneda", dts, Me.ConConta)
        Me.cboMoneda.DataSource = dts
        Me.cboMoneda.DisplayMember = "MonedaNombre"
        Me.cboMoneda.ValueMember = "CodMoneda"
        GetCuentaUtilidad()
        Me.cboComparativo.SelectedIndex = 0
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
            If Me.cboPeriodoFiscal.Text <> "" Then
                If Me.cboPeriodoT.Text <> "" Then
                    If Valida(Me.cboPeriodoT.SelectedValue) = False Then
                        MsgBox("No se puede realizar la operacion", MsgBoxStyle.Exclamation, Text)
                        Exit Sub
                    End If
                    If Me.cboPeriodoT.SelectedIndex = 0 And Me.cboComparativo.SelectedIndex = 0 Then
                        MsgBox("Periodo Fiscal Invalido", MsgBoxStyle.Exclamation, Text)
                        Exit Sub
                    End If
                    cFunciones.Llenar_Tabla_Generico("exec getBalanceSituacion " & Me.cboPeriodoT.SelectedValue & ", " & cboComparativo.SelectedIndex, Me.DtsReportes.getBalanceSituacion, Me.ConConta)
                    GeneraExcel()
                Else
                    MsgBox("Debe seleccionar un periodo fiscal valido", MsgBoxStyle.Exclamation, Text)
                End If
            Else
                MsgBox("Año Fiscal invalido!!!", MsgBoxStyle.Exclamation, Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub cboPeriodoFiscal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoFiscal.SelectedIndexChanged
        On Error Resume Next
        CargarPeriodosTrabajo(Me.cboPeriodoFiscal.SelectedValue)
    End Sub
    'daniel

    Private Sub cboPeriodoT_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoT.SelectedIndexChanged

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub cboComparativo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboComparativo.SelectedIndexChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class