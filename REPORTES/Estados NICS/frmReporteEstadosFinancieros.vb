Imports Word = Microsoft.Office.Interop.Word
Imports System.Xml
Imports System.Linq

Public Class frmReporteEstadosFinancieros
    Public _pPeriodo As String = ""
    Public _pP1 As String = "2011"
    Public _pP2 As String = "2012"
    Public _IdP1, _IdP2 As String

    Private Sub Button1_Click(ByVal sender As System.Object, _
      ByVal e As System.EventArgs)

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table : Dim oTable2 As Word.Table, oTable3 As Word.Table
        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph, oPara3 As Word.Paragraph
        Dim oPara6 As Word.Paragraph
        Dim oRng As Word.Range : Dim oRng2 As Word.Range, oRng3 As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add

        Dim p1 As String = 0
        Dim p2 As String = 0

        Dim r As Integer, c As Integer

        oPara1 = oDoc.Content.Paragraphs.Add
        If chbEstado1.Checked Then

            '/* PAGINA 1
            oPara1.Range.Text = "Estado 1"
            oPara1.Range.Font.Bold = True
            oPara1.Range.Font.Italic = True
            oPara1.Format.SpaceAfter = 6
            oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify
            oPara1.Range.InsertParagraphAfter()

            oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara2.Range.Text = "COMPAÑIA " & txtCompañia.Text
            oPara2.Format.SpaceAfter = 2
            oPara2.Range.Font.Italic = False
            oPara2.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oPara2.Range.InsertParagraphAfter()
            oPara2.Range.Text = txtDireccion.Text
            oPara2.Range.InsertParagraphAfter()
            oPara2.Range.Text = "BALANCE SITUACIÓN"
            oPara2.Range.InsertParagraphAfter()
            oPara2.Range.Text = "Periodo " & _pPeriodo
            oPara2.Range.InsertParagraphAfter()
            oPara2.Range.Text = txtDetalle.Text
            oPara2.Range.InsertParagraphAfter()


            oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, Estado1Activos.Rows.Count, 4)
            oTable.Range.ParagraphFormat.SpaceAfter = 6


            For r = 1 To Estado1Activos.Rows.Count

                p1 = Format(Math.Abs(CDbl(Estado1Activos.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format(Math.Abs(CDbl(Estado1Activos.Rows(r - 1).Item("Periodo2"))), "#,##00")
                If CDbl(Estado1Activos.Rows(r - 1).Item("Nivel")) <= 1 Then
                    p1 = ""

                End If
                If CDbl(Estado1Activos.Rows(r - 1).Item("Nivel")) <= 1 Then
                    p2 = ""

                End If

                oTable.Cell(r, 1).Height = 2
                oTable.Cell(r, 1).Range.Text = Estado1Activos.Rows(r - 1).Item("Descripcion") : oTable.Cell(r, 2).Range.Text = Estado1Activos.Rows(r - 1).Item("Notas") : oTable.Cell(r, 3).Range.Text = p1 : oTable.Cell(r, 4).Range.Text = p2
                oTable.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oTable.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                If Estado1Activos.Rows(r - 1).Item("Nivel") < 1 Or Estado1Activos.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                    oTable.Rows.Item(r).Range.Font.Bold = True
                    If Estado1Activos.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                        oTable.Cell(r, 3).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        oTable.Cell(r, 4).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                    End If
                Else
                    oTable.Rows.Item(r).Range.Font.Bold = False
                End If


            Next

            oTable.Cell(1, 2).Range.Text = "Notas" : oTable.Cell(1, 3).Range.Text = _pP1 : oTable.Cell(1, 4).Range.Text = _pP2
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            oTable.Range.InsertParagraphAfter()

            Do
                oRng = oDoc.Bookmarks.Item("\endofdoc").Range
                oRng.ParagraphFormat.SpaceAfter = 6
                oRng.InsertAfter("")
                oRng.InsertParagraphAfter()
            Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
            oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
            oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
            '/* FIN PAGINA 1

            '/* PAGINA 2
            oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara3.Range.Text = "COMPAÑIA " & txtCompañia.Text
            oPara3.Format.SpaceAfter = 2
            oPara3.Range.Font.Italic = False
            oPara3.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oPara3.Range.InsertParagraphAfter()
            oPara3.Range.Text = txtDireccion.Text
            oPara3.Range.InsertParagraphAfter()
            oPara3.Range.Text = "BALANCE SITUACIÓN "
            oPara3.Range.InsertParagraphAfter()
            oPara3.Range.Text = "Periodo " & _pPeriodo
            oPara3.Range.InsertParagraphAfter()
            oPara3.Range.Text = txtDetalle.Text
            oPara3.Range.InsertParagraphAfter()

            r = 0
            c = 0
            oTable2 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, Estado1PasivosCapital.Rows.Count + 2, 4)
            oTable2.Range.ParagraphFormat.SpaceAfter = 6
            p1 = 0
            p2 = 0

            For r = 1 To Estado1PasivosCapital.Rows.Count

                p1 = Format(Math.Abs(CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format(Math.Abs(CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo2"))), "#,##00")
                If (CInt(Estado1PasivosCapital.Rows(r - 1).Item("Nivel")) <= 0) And CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo1")) = -1 Then
                    p1 = ""

                End If
                If (CInt(Estado1PasivosCapital.Rows(r - 1).Item("Nivel")) <= 0) And CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo2")) = -1 Then
                    p2 = ""

                End If

                oTable2.Cell(r, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                oTable2.Cell(r, 1).Range.Text = Estado1PasivosCapital.Rows(r - 1).Item("Descripcion") : oTable2.Cell(r, 2).Range.Text = Estado1PasivosCapital.Rows(r - 1).Item("Notas") : oTable2.Cell(r, 3).Range.Text = p1 : oTable2.Cell(r, 4).Range.Text = p2
                oTable2.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oTable2.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable2.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable2.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                If Estado1PasivosCapital.Rows(r - 1).Item("Nivel") < 1 Or Estado1PasivosCapital.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                    oTable2.Rows.Item(r).Range.Font.Bold = True
                    If Estado1PasivosCapital.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                        oTable2.Cell(r, 3).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        oTable2.Cell(r, 4).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        'If Estado1PasivosCapital.Rows(r - 1).Item("Nivel") = 0 Then
                        '    r += 1

                        '    oTable2.Cell(r, 1).Range.Text = "Utilidad " : oTable2.Cell(r, 2).Range.Text = Estado1PasivosCapital.Rows(r - 1).Item("Notas") : oTable2.Cell(r, 3).Range.Text = p1 : oTable2.Cell(r, 4).Range.Text = p2
                        '    oTable2.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                        '    oTable2.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        '    oTable2.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        '    oTable2.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        'End If
                    End If
                Else
                    oTable2.Rows.Item(r).Range.Font.Bold = False
                End If


            Next

            oTable2.Cell(1, 2).Range.Text = "Notas" : oTable2.Cell(1, 3).Range.Text = _pP1 : oTable2.Cell(1, 4).Range.Text = _pP2
            Dim ul As Integer = Estado1PasivosCapital.Rows.Count + 1
            oTable2.Cell(ul, 1).Range.Text = "TOTAL PASIVO + PATRIMONIO" : oTable2.Cell(ul, 3).Range.Text = Format(PasivoP1 + CapitalP1, "#,##00") : oTable2.Cell(ul, 4).Range.Text = Format(PasivoP2 + CapitalP2, "#,##00")
            oTable2.Cell(ul, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable2.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            oTable2.Range.InsertParagraphAfter()
            oRng2 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng2.InsertParagraphAfter()
            Do
                oRng2 = oDoc.Bookmarks.Item("\endofdoc").Range
                oRng2.ParagraphFormat.SpaceAfter = 6
                oRng2.InsertAfter("")
                oRng2.InsertParagraphAfter()
            Loop While Pos >= oRng2.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
            oRng2.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
            oRng2.InsertBreak(Word.WdBreakType.wdPageBreak)
            oRng2.InsertAfter("THE FIN.")
            '/* FIN PAGINA 2

        End If

        '/********* PAGINA 3
        If chbEstado2.Checked Then
            oPara6 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara6.Range.Text = "" & txtCompañia.Text
            oPara6.Format.SpaceAfter = 2
            oPara6.Range.Font.Italic = False
            oPara6.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oPara6.Range.InsertParagraphAfter()
            oPara6.Range.Text = txtDireccion.Text
            oPara6.Range.InsertParagraphAfter()
            oPara6.Range.Text = "ESTADO RESULTADO"
            oPara6.Range.InsertParagraphAfter()
            oPara6.Range.Text = "Periodo " & _pPeriodo
            oPara6.Range.InsertParagraphAfter()
            oPara6.Range.Text = txtDetalle.Text
            oPara6.Range.InsertParagraphAfter()

            r = 0
            c = 0
            oTable3 = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, Estado2.Rows.Count, 4)
            oTable3.Range.ParagraphFormat.SpaceAfter = 6
            p1 = 0
            p2 = 0

            For r = 1 To Estado2.Rows.Count

                p1 = Format(Math.Abs(CDbl(Estado2.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format(Math.Abs(CDbl(Estado2.Rows(r - 1).Item("Periodo2"))), "#,##00")
                If (CInt(Estado2.Rows(r - 1).Item("Nivel")) <= 0) And CDbl(Estado2.Rows(r - 1).Item("Periodo1")) = -1 Then
                    p1 = ""

                End If
                If (CInt(Estado2.Rows(r - 1).Item("Nivel")) <= 0) And CDbl(Estado2.Rows(r - 1).Item("Periodo2")) = -1 Then
                    p2 = ""

                End If

                oTable3.Cell(r, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                oTable3.Cell(r, 1).Range.Text = Estado2.Rows(r - 1).Item("Descripcion") : oTable3.Cell(r, 2).Range.Text = Estado2.Rows(r - 1).Item("Notas") : oTable3.Cell(r, 3).Range.Text = p1 : oTable3.Cell(r, 4).Range.Text = p2
                oTable3.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oTable3.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable3.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable3.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                If Estado2.Rows(r - 1).Item("Nivel") < 1 Or Estado2.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                    oTable3.Rows.Item(r).Range.Font.Bold = True
                    If Estado2.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                        oTable3.Cell(r, 3).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        oTable3.Cell(r, 4).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                    End If
                Else
                    oTable3.Rows.Item(r).Range.Font.Bold = False
                End If


            Next

            oTable3.Cell(1, 2).Range.Text = "Notas" : oTable3.Cell(1, 3).Range.Text = _pP1 : oTable3.Cell(1, 4).Range.Text = _pP2
            oTable3.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            oTable3.Range.InsertParagraphAfter()
            oRng3 = oDoc.Bookmarks.Item("\endofdoc").Range
            oRng3.InsertParagraphAfter()
            Do
                oRng3 = oDoc.Bookmarks.Item("\endofdoc").Range
                oRng3.ParagraphFormat.SpaceAfter = 6
                oRng3.InsertAfter("")
                oRng3.InsertParagraphAfter()
            Loop While Pos >= oRng3.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
            oRng3.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
            oRng3.InsertBreak(Word.WdBreakType.wdPageBreak)
            oRng3.InsertAfter("THE FIN.")
            '/* FIN PAGINA 3

        End If


        'All done. Close this form.
        MsgBox("DATOS CONCLUIDOS!!!!!")

    End Sub

#Region "CARGAR"
    Dim empre As New DataTable
    Dim ActivoP1 As Double = 0
    Dim PasivoP1 As Double = 0
    Dim CapitalP1 As Double = 0

    Dim ActivoP2 As Double = 0
    Dim PasivoP2 As Double = 0
    Dim CapitalP2 As Double = 0

    Dim IngresosP1 As Double = 0
    Dim CostosP1 As Double = 0
    Dim GastosP1 As Double = 0

    Dim IngresosP2 As Double = 0
    Dim CostosP2 As Double = 0
    Dim GastosP2 As Double = 0

    Dim rentaP1 As Double = 0 : Dim rentaP2 As Double = 0
    Dim Estado1Activos As New DataTable : Dim Estado1PasivosCapital As New DataTable : Dim Estado2 As New DataTable : Dim dts_Flujo As New DataTable : Dim dtRenta As New DataTable
    Private Sub frmReporteEstadosFinancieros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cls_Datos.sp_llenarTabla("Select * From configuraciones", empre, "Hotel")
        cls_Datos.sp_llenarTabla("SELECT CuentaContable, Descripcion, Notas, ROUND(Periodo1, 2) AS Periodo1, ROUND(Periodo2, 2) AS Periodo2, Nivel, Acumulado FROM Estado1 WHERE (Nivel <= 2) AND (CuentaContable LIKE '1%') ORDER BY CuentaContable", Estado1Activos, "Contabilidad")
        cls_Datos.sp_llenarTabla("SELECT CuentaContable, Descripcion, Notas, ROUND(Periodo1, 2) AS Periodo1, ROUND(Periodo2, 2) AS Periodo2, Nivel, Acumulado FROM Estado1 WHERE (Nivel <= 2) AND (CuentaContable LIKE '2%' OR  CuentaContable LIKE '3%') ORDER BY CuentaContable", Estado1PasivosCapital, "Contabilidad")
        cls_Datos.sp_llenarTabla("SELECT CuentaContable, Descripcion, Notas, ROUND(Periodo1, 2) AS Periodo1, ROUND(Periodo2, 2) AS Periodo2, Nivel, Acumulado FROM Estado2 WHERE (Nivel <= 2) AND (CuentaContable LIKE '4%' OR  CuentaContable LIKE '5%' OR  CuentaContable LIKE '6%') ORDER BY CuentaContable", Estado2, "Contabilidad")
        cls_Datos.sp_llenarTabla("SELECT e1.CuentaContable, e1.Descripcion, e1.Notas, e1.Periodo1, e1.Periodo2, e1.Nivel, e1.Acumulado FROM Estado1 AS e1 INNER JOIN  CuentaContable AS c ON e1.CuentaContable = c.CuentaContable INNER JOIN  SettingCuentaContable AS s ON c.id = s.IdImpuestoRenta", dtRenta, "Contabilidad")

        cls_Datos.sp_llenarTabla("SELECT tbConfiguracionFlujoEfectivo.Grupo, tbConfiguracionFlujoEfectivo.Descripción as Descripcion, SUM(Estado1.Periodo1) AS Periodo1, SUM(Estado1.Periodo2) AS Periodo2 FROM  Estado1 INNER JOIN tbConfiguracionFlujoEfectivo ON Estado1.CuentaContable = tbConfiguracionFlujoEfectivo.CuentaContable GROUP BY tbConfiguracionFlujoEfectivo.Grupo, tbConfiguracionFlujoEfectivo.Descripción ORDER BY tbConfiguracionFlujoEfectivo.Grupo", Me.dts_Flujo, "Contabilidad")

        sp_Totales()
        If empre.Rows.Count > 0 Then
            txtCompañia.Text = empre.Rows(0).Item("PersonaJuridica")
            txtDireccion.Text = empre.Rows(0).Item("Direccion")
        End If

        txtPeriodo1.Text = _pP1
        txtPeriodo2.Text = _pP2
    End Sub
    Sub sp_Totales()
        For i As Integer = 0 To Estado1Activos.Rows.Count - 1
            If Estado1Activos.Rows(i).Item("Nivel") = 0 And Estado1Activos.Rows(i).Item("cuentacontable").ToString.StartsWith("1-x") Then
                ActivoP1 = Estado1Activos.Rows(i).Item("Periodo1")
                ActivoP2 = Estado1Activos.Rows(i).Item("Periodo2")
                Exit For

            End If

        Next
        For i As Integer = 0 To Estado1PasivosCapital.Rows.Count - 1
            If Estado1PasivosCapital.Rows(i).Item("Nivel") = 0 And Estado1PasivosCapital.Rows(i).Item("CuentaContable").ToString.StartsWith("2-x") Then
                PasivoP1 = Estado1PasivosCapital.Rows(i).Item("Periodo1")
                PasivoP2 = Estado1PasivosCapital.Rows(i).Item("Periodo2")
            End If
            If Estado1PasivosCapital.Rows(i).Item("Nivel") = 0 And Estado1PasivosCapital.Rows(i).Item("CuentaContable").ToString.StartsWith("3-x") Then
                CapitalP1 = Estado1PasivosCapital.Rows(i).Item("Periodo1")
                CapitalP2 = Estado1PasivosCapital.Rows(i).Item("Periodo2")
            End If
        Next
        For i As Integer = 0 To Estado2.Rows.Count - 1
            If Estado2.Rows(i).Item("Nivel") = 0 And Estado2.Rows(i).Item("CuentaContable").ToString.StartsWith("4-x") Then
                IngresosP1 = Estado2.Rows(i).Item("Periodo1")
                IngresosP2 = Estado2.Rows(i).Item("Periodo2")
            End If
            If Estado2.Rows(i).Item("Nivel") = 0 And Estado2.Rows(i).Item("CuentaContable").ToString.StartsWith("5-x") Then
                CostosP1 = Estado2.Rows(i).Item("Periodo1")
                CostosP2 = Estado2.Rows(i).Item("Periodo2")
            End If
            If Estado2.Rows(i).Item("Nivel") = 0 And Estado2.Rows(i).Item("CuentaContable").ToString.StartsWith("6-x") Then
                GastosP1 = Estado2.Rows(i).Item("Periodo1")
                GastosP2 = Estado2.Rows(i).Item("Periodo2")
            End If
        Next
        If dtRenta.Rows.Count > 0 Then
            rentaP1 = dtRenta.Rows(0).Item("Periodo1")
            rentaP2 = dtRenta.Rows(0).Item("Periodo2")
        End If

    End Sub
#End Region

    Private Sub btnConfNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfNotas.Click
        Dim f As New frmConfigurarNotas
        f.ShowDialog()

    End Sub

    Dim archivo As String = ""

    Private Sub btnGenerarNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        abrirArchivo.Filter = "Plantilla (.docx)|*.docx"
        If Not abrirArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Exit Sub
        End If
        archivo = abrirArchivo.FileName
        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table()

        Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph, oPara3 As Word.Paragraph
        Dim oPara6 As Word.Paragraph, oPara7 As Word.Paragraph, oPara8 As Word.Paragraph
        Dim oRng As Word.Range : Dim oRng2 As Word.Range, oRng3 As Word.Range
        Dim oShape As Word.InlineShape
        Dim oChart As Object
        Dim Pos As Double

        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Open(archivo)

        oDoc.Bookmarks.Item("Compañia").Range.Text = txtCompañia.Text
        Dim dtNotas As New DataTable
        cls_Datos.sp_llenarTabla("Select * From tbNotasSecundaria ORDER BY Numero, Letra", dtNotas, "Contabilidad")
        ReDim oTable(dtNotas.Rows.Count)
        Dim p1 As String, p2 As String
        For i As Integer = 0 To dtNotas.Rows.Count - 1
            Dim nota As String = ("Nota" & dtNotas.Rows(i).Item("Numero") & "" & dtNotas.Rows(i).Item("Letra"))
            nota = nota.Trim(" ")

            If oDoc.Bookmarks.Exists(nota) Then
                Dim cuentas As New DataTable : Dim totales As New DataTable
                cls_Datos.sp_llenarTabla("SELECT n.ID_NotaSecundaria, e.CuentaContable, e.Descripcion, e.Periodo1, e.Periodo2 FROM tbNotasSecundariaDet AS n INNER JOIN  Estado1 AS e ON n.CuentaContable = e.CuentaContable Where ID_NotaSecundaria = " & dtNotas.Rows(i).Item("ID") & " ORDER BY n.ID", cuentas, "Contabilidad")
                cls_Datos.sp_llenarTabla("SELECT n.ID_NotaSecundaria, SUM(e.Periodo1) AS P1, SUM(e.Periodo2) AS P2 FROM tbNotasSecundariaDet AS n INNER JOIN  Estado1 AS e ON n.CuentaContable = e.CuentaContable GROUP BY n.ID_NotaSecundaria HAVING n.ID_NotaSecundaria = " & dtNotas.Rows(i).Item("ID") & " ", totales, "Contabilidad")
                If cuentas.Rows.Count > 0 Then

                    oTable(i) = oDoc.Tables.Add(oDoc.Bookmarks.Item(nota).Range, cuentas.Rows.Count + 2, 3)
                    oTable(i).Range.Font.Bold = False
                    oTable(i).Cell(1, 1).Range.Text = dtNotas.Rows(i).Item("Numero") & "." & dtNotas.Rows(i).Item("Letra").ToString.Trim(" ") & ") " & dtNotas.Rows(0).Item("Descripcion") : oTable(i).Cell(1, 2).Range.Text = _pP1 : oTable(i).Cell(1, 3).Range.Text = _pP2
                    oTable(i).Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable(i).Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable(i).Cell(1, 1).Width = 250 : oTable(i).Cell(1, 2).Width = 85 : oTable(i).Cell(1, 3).Width = 85
                    For ii As Integer = 0 To cuentas.Rows.Count - 1
                        p1 = Format(Math.Abs(CDbl(cuentas.Rows(ii).Item("Periodo1"))), "#,##00")
                        p2 = Format(Math.Abs(CDbl(cuentas.Rows(ii).Item("Periodo2"))), "#,##00")
                        Dim r As Integer = ii + 1
                        r = r + 1

                        oTable(i).Cell(r, 1).Range.Text = cuentas.Rows(ii).Item("Descripcion") : oTable(i).Cell(r, 1).Width = 250 : oTable(i).Cell(r, 2).Width = 85 : oTable(i).Cell(r, 3).Width = 85

                        oTable(i).Cell(r, 2).Range.Text = p1 : oTable(i).Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable(i).Cell(r, 3).Range.Text = p2 : oTable(i).Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    Next
                    If totales.Rows.Count > 0 Then
                        Dim f As Integer = cuentas.Rows.Count + 1

                        p1 = Format(Math.Abs(CDbl(totales.Rows(0).Item("P1"))), "#,##00")
                        p2 = Format(Math.Abs(CDbl(totales.Rows(0).Item("P2"))), "#,##00")

                        oTable(i).Cell(f, 1).Range.Text = "Total:" : oTable(i).Cell(f, 1).Width = 250 : oTable(i).Cell(f, 2).Width = 85 : oTable(i).Cell(f, 3).Width = 85
                        oTable(i).Cell(f, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable(i).Cell(f, 2).Range.Text = p1 : oTable(i).Cell(f, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable(i).Cell(f, 3).Range.Text = p2 : oTable(i).Cell(f, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    End If

                End If
            End If
        Next

    End Sub
    Dim pWord As Word.Application
    Dim pDoc As Word.Document


    Sub sp_Generar()
        Try
            abrirArchivo.Filter = "Plantilla (.docx)|*.docx"
            If Not abrirArchivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Exit Sub
            End If
            archivo = abrirArchivo.FileName
            pWord = CreateObject("Word.Application")
            pDoc = pWord.Documents.Open(archivo)
            pWord.Visible = True
            _pP1 = txtPeriodo1.Text
            _pP2 = txtPeriodo2.Text
            sp_GenerarEstados()
            sp_GenerarNotas()
            MsgBox("GENERACION CONCLUIDA!!!!!")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Sub sp_GenerarEstados()
        Dim p1 As String = 0
        Dim p2 As String = 0

        Dim r As Integer, c As Integer
        Dim oPara2 As Word.Paragraph, oPara3 As Word.Paragraph, oPara6 As Word.Paragraph
        Dim oTable As Word.Table : Dim oTable2 As Word.Table, oTable3, oTable4 As Word.Table
        'Balance situación 
        If chbEstado1.Checked Then

            oTable = pDoc.Tables.Add(pDoc.Bookmarks.Item("ESTADO1").Range, Estado1Activos.Rows.Count, 4)
            oTable.Range.ParagraphFormat.SpaceAfter = 6

            Dim temp1, temp2 As String
            For r = 1 To Estado1Activos.Rows.Count

                p1 = Format(Math.Abs(CDbl(Estado1Activos.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format(Math.Abs(CDbl(Estado1Activos.Rows(r - 1).Item("Periodo2"))), "#,##00")
                If CDbl(Estado1Activos.Rows(r - 1).Item("Nivel")) <= 1 Then
                    temp1 = p1
                    p1 = ""
                End If
                If CDbl(Estado1Activos.Rows(r - 1).Item("Nivel")) <= 1 Then
                    temp2 = p2
                    p2 = ""
                End If

                oTable.Cell(r, 1).Height = 2
                oTable.Cell(r, 1).Range.Text = Estado1Activos.Rows(r - 1).Item("Descripcion").ToString.ToUpper : oTable.Cell(r, 2).Range.Text = Estado1Activos.Rows(r - 1).Item("Notas") : oTable.Cell(r, 3).Range.Text = p1 : oTable.Cell(r, 4).Range.Text = p2
                oTable.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oTable.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                If Estado1Activos.Rows(r - 1).Item("Nivel") < 1 Or Estado1Activos.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                    oTable.Rows.Item(r).Range.Font.Bold = True
                    If Estado1Activos.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                        oTable.Cell(r, 3).Range.Text = temp1
                        oTable.Cell(r, 4).Range.Text = temp2
                        oTable.Cell(r, 3).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        oTable.Cell(r, 4).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                    End If
                Else
                    oTable.Rows.Item(r).Range.Font.Bold = False
                End If


            Next

            oTable.Cell(1, 2).Range.Text = "Notas" : oTable.Cell(1, 3).Range.Text = _pP1 : oTable.Cell(1, 4).Range.Text = _pP2
            oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)


            r = 0
            c = 0
            oTable2 = pDoc.Tables.Add(pDoc.Bookmarks.Item("Estado1B").Range, Estado1PasivosCapital.Rows.Count + 2, 4)
            oTable2.Range.ParagraphFormat.SpaceAfter = 6
            p1 = 0
            p2 = 0

            For r = 1 To Estado1PasivosCapital.Rows.Count

                p1 = Format(Math.Abs(CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format(Math.Abs(CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo2"))), "#,##00")
                If (CInt(Estado1PasivosCapital.Rows(r - 1).Item("Nivel")) <= 1) Then ' And CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo1")) = -1 Then
                    temp1 = p1
                    p1 = ""

                End If
                If (CInt(Estado1PasivosCapital.Rows(r - 1).Item("Nivel")) <= 1) Then ' And CDbl(Estado1PasivosCapital.Rows(r - 1).Item("Periodo2")) = -1 Then
                    temp2 = p2
                    p2 = ""

                End If

                oTable2.Cell(r, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                oTable2.Cell(r, 1).Range.Text = Estado1PasivosCapital.Rows(r - 1).Item("Descripcion") : oTable2.Cell(r, 2).Range.Text = Estado1PasivosCapital.Rows(r - 1).Item("Notas") : oTable2.Cell(r, 3).Range.Text = p1 : oTable2.Cell(r, 4).Range.Text = p2
                oTable2.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oTable2.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable2.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable2.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                If Estado1PasivosCapital.Rows(r - 1).Item("Nivel") < 1 Or Estado1PasivosCapital.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                    oTable2.Rows.Item(r).Range.Font.Bold = True
                    If Estado1PasivosCapital.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                        oTable2.Cell(r, 3).Range.Text = temp1
                        oTable2.Cell(r, 4).Range.Text = temp2
                        oTable2.Cell(r, 3).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        oTable2.Cell(r, 4).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                    End If
                Else
                    oTable2.Rows.Item(r).Range.Font.Bold = False
                End If
            Next

            oTable2.Cell(1, 2).Range.Text = "Notas" : oTable2.Cell(1, 3).Range.Text = _pP1 : oTable2.Cell(1, 4).Range.Text = _pP2
            Dim ul As Integer = Estado1PasivosCapital.Rows.Count + 1
            oTable2.Cell(ul, 1).Range.Text = "TOTAL PASIVO + PATRIMONIO" : oTable2.Cell(ul, 3).Range.Text = Format(PasivoP1 + CapitalP1, "#,##00") : oTable2.Cell(ul, 4).Range.Text = Format(PasivoP2 + CapitalP2, "#,##00")
            oTable2.Cell(ul, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
            oTable2.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            oTable2.Range.InsertParagraphAfter()

            '/* FIN PAGINA 2

        End If

        '/********* PAGINA 3
        'Estados Resultados 
        If chbEstado2.Checked Then

            r = 0
            c = 0
            Dim rFin As Integer = Estado2.Rows.Count + 3 : Dim utilidadAR_P1 As Double = 0 : Dim utilidadAR_P2 As Double : Dim renta_P1 As Double = 0 : Dim renta_P2 As Double = 0
            oTable3 = pDoc.Tables.Add(pDoc.Bookmarks.Item("Estado2").Range, rFin, 4)
            oTable3.Range.ParagraphFormat.SpaceAfter = 6
            p1 = 0
            p2 = 0
            Dim utilidadSinImpuesto As Double = 0


            For r = 1 To Estado2.Rows.Count

                p1 = Format(Math.Abs(CDbl(Estado2.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format(Math.Abs(CDbl(Estado2.Rows(r - 1).Item("Periodo2"))), "#,##00")
                If (CInt(Estado2.Rows(r - 1).Item("Nivel")) <= 0) And CDbl(Estado2.Rows(r - 1).Item("Periodo1")) = -1 Then
                    p1 = ""

                End If
                If (CInt(Estado2.Rows(r - 1).Item("Nivel")) <= 0) And CDbl(Estado2.Rows(r - 1).Item("Periodo2")) = -1 Then
                    p2 = ""

                End If

                oTable3.Cell(r, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                oTable3.Cell(r, 1).Range.Text = Estado2.Rows(r - 1).Item("Descripcion") : oTable3.Cell(r, 2).Range.Text = Estado2.Rows(r - 1).Item("Notas") : oTable3.Cell(r, 3).Range.Text = p1 : oTable3.Cell(r, 4).Range.Text = p2
                oTable3.Cell(r, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                oTable3.Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable3.Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                oTable3.Cell(r, 4).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                If Estado2.Rows(r - 1).Item("Nivel") < 1 Or Estado2.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                    oTable3.Rows.Item(r).Range.Font.Bold = True
                    If Estado2.Rows(r - 1).Item("CuentaContable").ToString.Contains("xx") Then
                        oTable3.Cell(r, 3).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                        oTable3.Cell(r, 4).Range.Font.Underline = Word.WdUnderline.wdUnderlineDouble
                    End If
                Else
                    oTable3.Rows.Item(r).Range.Font.Bold = False
                End If


            Next

            oTable3.Cell(1, 2).Range.Text = "Notas" : oTable3.Cell(1, 3).Range.Text = _pP1 : oTable3.Cell(1, 4).Range.Text = _pP2
            oTable3.Cell(rFin - 2, 1).Range.Text = "UTILIDAD NETA ANTES DE RENTA" : oTable3.Cell(rFin, 3).Range.Text = IngresosP1 - CostosP1 - GastosP1 : oTable3.Cell(rFin, 4).Range.Text = IngresosP2 - CostosP2 - GastosP2
            oTable3.Cell(rFin - 1, 1).Range.Text = dtRenta.Rows(0).Item("Descripcion") : oTable3.Cell(rFin - 1, 1).Range.Text = dtRenta.Rows(0).Item("Notas")
            If _pP1.StartsWith("12") Then
                oTable3.Cell(rFin, 3).Range.Text = renta_P1
            Else
                renta_P1 = 0
                oTable3.Cell(rFin, 3).Range.Text = 0
            End If
            If _pP2.StartsWith("12") Then
                oTable3.Cell(rFin, 4).Range.Text = renta_P2
            Else
                renta_P2 = 0
                oTable3.Cell(rFin, 4).Range.Text = 0
            End If
            oTable3.Cell(rFin, 1).Range.Text = "UTILIDAD NETA DESPUES DE RENTA" : oTable3.Cell(rFin, 1).Range.Text = dtRenta.Rows(0).Item("Notas")
            oTable3.Cell(rFin, 3).Range.Text = utilidadAR_P1 - renta_P1 : oTable3.Cell(rFin, 4).Range.Text = utilidadAR_P2 - renta_P2
            oTable3.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            oTable3.Range.InsertParagraphAfter()

            '/* FIN PAGINA 3

        End If

        If chbEstado3.Checked = True Then
            r = 0
            c = 0

            Dim rFin As Integer = Me.dts_Flujo.Rows.Count + 30 : Dim utilidadAR_P1 As Double = 0 : Dim utilidadAR_P2 As Double : Dim renta_P1 As Double = 0 : Dim renta_P2 As Double = 0
            oTable4 = pDoc.Tables.Add(pDoc.Bookmarks.Item("Estado3").Range, rFin, 3)
            oTable4.Range.ParagraphFormat.SpaceAfter = 7
            p1 = 0
            p2 = 0

            Dim Ultimo_Encabezado As String = ""
            Dim Linea As Integer = 1
            Dim TP1, TP2
            Dim GRUPO1, GRUPO2, GRUPO3, GRUPO4, GRUPO5, GRUPO6 As String
            For r = 1 To Me.dts_Flujo.Rows.Count

                p1 = Format((CDbl(dts_Flujo.Rows(r - 1).Item("Periodo1"))), "#,##00")
                p2 = Format((CDbl(dts_Flujo.Rows(r - 1).Item("Periodo2"))), "#,##00")

                GRUPO1 = "1-FLUJO DE EFECTIVO GENERADO POR LA OPERACION"
                GRUPO2 = "2-PARTIDAS QUE NO REQUIEREN USO DE EFECTIVO"
                GRUPO3 = "3-DISMINUCION O AUMENTO EN"
                GRUPO4 = "4-AUMENTO O DISMINUCION EN"
                GRUPO5 = "5-FLUJO DE EFECTIVO DE ACTIVIDADES DE FINANCIMIENTO"
                GRUPO6 = "6-FLUJO DE EFECTIVO EN ACTIVIDADES DE INVERSION"

                If Ultimo_Encabezado = Me.dts_Flujo.Rows(r - 1).Item("Grupo").ToString.Remove(0, 2) Then
                    'agrega detalle
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    oTable4.Rows.Item(r + Linea).Range.Font.Bold = False
                    oTable4.Cell(r + Linea, 1).Range.Text = Me.dts_Flujo.Rows(r - 1).Item("Descripcion")
                    oTable4.Cell(r + Linea, 2).Range.Text = p1
                    oTable4.Cell(r + Linea, 3).Range.Text = p2
                Else
                    'agrega encabezado
                    If Me.dts_Flujo.Rows(r - 1).Item("Grupo").ToString.Remove(0, 2) = "DISMINUCION O AUMENTO EN" Then
                        'crea totales
                        oTable4.Rows.Item(r + Linea).Range.Font.Bold = True
                        oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                        oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                        oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                        TP1 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO2 Select CDec(row.Item("Periodo1"))).Sum
                        TP2 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO2 Select CDec(row.Item("Periodo2"))).Sum

                        oTable4.Cell(r + Linea, 1).Range.Text = "TOTAL EFECTIVO PROVISTO POR LAS OPERACIONES "
                        oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(TP1)), "#,##00")
                        oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(TP2)), "#,##00")
                        Linea += 1
                    End If

                    If Me.dts_Flujo.Rows(r - 1).Item("Grupo").ToString.Remove(0, 2) = "FLUJO DE EFECTIVO DE ACTIVIDADES DE FINANCIMIENTO" Then
                        'crea totales
                        oTable4.Rows.Item(r + Linea).Range.Font.Bold = True
                        oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                        oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                        oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                        TP1 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO3 Or row.Item("Grupo") = GRUPO4 Select CDec(row.Item("Periodo1"))).Sum
                        TP2 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO3 Or row.Item("Grupo") = GRUPO4 Select CDec(row.Item("Periodo2"))).Sum

                        oTable4.Cell(r + Linea, 1).Range.Text = "TOTAL FLUJO DE EFECTIVO GENERADO (USADO) POR ACT. DE OPERACIÓN "
                        oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(TP1)), "#,##00")
                        oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(TP2)), "#,##00")
                        Linea += 1
                    End If

                    If Me.dts_Flujo.Rows(r - 1).Item("Grupo").ToString.Remove(0, 2) = "FLUJO DE EFECTIVO EN ACTIVIDADES DE INVERSION" Then
                        'crea totales
                        oTable4.Rows.Item(r + Linea).Range.Font.Bold = True
                        oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                        oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                        oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                        TP1 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO5 Select CDec(row.Item("Periodo1"))).Sum
                        TP2 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO5 Select CDec(row.Item("Periodo2"))).Sum

                        oTable4.Cell(r + Linea, 1).Range.Text = "TOTAL FLUJO DE EFECTIVO GENERADO POR ACTIVADES DE FINANCIAMIENTO "
                        oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(TP1)), "#,##00")
                        oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(TP2)), "#,##00")
                        Linea += 1
                    End If

                    oTable4.Rows.Item(r + Linea).Range.Font.Bold = True
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    oTable4.Cell(r + Linea, 1).Range.Text = Me.dts_Flujo.Rows(r - 1).Item("Grupo").ToString.Remove(0, 2)
                    Ultimo_Encabezado = Me.dts_Flujo.Rows(r - 1).Item("Grupo").ToString.Remove(0, 2)
                    Linea += 1

                    oTable4.Rows.Item(r + Linea).Range.Font.Bold = False
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    oTable4.Cell(r + Linea, 1).Range.Text = Me.dts_Flujo.Rows(r - 1).Item("Descripcion")
                    oTable4.Cell(r + Linea, 2).Range.Text = p1
                    oTable4.Cell(r + Linea, 3).Range.Text = p2

                End If

                If r = Me.dts_Flujo.Rows.Count Then
                    Linea += 1
                    oTable4.Rows.Item(r + Linea).Range.Font.Bold = True
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    TP1 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO6 Select CDec(row.Item("Periodo1"))).Sum
                    TP2 = (From row As DataRow In Me.dts_Flujo.Rows Where row.Item("Grupo") = GRUPO6 Select CDec(row.Item("Periodo2"))).Sum

                    oTable4.Cell(r + Linea, 1).Range.Text = "TOTAL FLUJO DE EFECTIVO USADO EN ACTIVIDADES DE INVERSION "
                    oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(TP1)), "#,##00")
                    oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(TP2)), "#,##00")
                    Linea += 1

                    oTable4.Rows.Item(r + Linea).Range.Font.Bold = True
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.SpaceAfter = 0.5
                    oTable4.Cell(r + Linea, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
                    oTable4.Cell(r + Linea, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable4.Cell(r + Linea, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                    TP1 = (From row As DataRow In Me.dts_Flujo.Rows Select CDec(row.Item("Periodo1"))).Sum
                    TP2 = (From row As DataRow In Me.dts_Flujo.Rows Select CDec(row.Item("Periodo2"))).Sum

                    oTable4.Cell(r + Linea, 1).Range.Text = "TOTAL EFECTIVO GENERADO EN EL EJERCICIO "
                    oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(TP1)), "#,##00")
                    oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(TP2)), "#,##00")
                    Linea += 1

                    Dim dt As New DataTable
                    Dim EfeP1, EfeP2 As Decimal
                    cFunciones.Llenar_Tabla_Generico("select isnull(EfectivoalFinalC,0) as EfectivoalFinalC, isnull(EfectivoalFinalD,0) as EfectivoalFinalD from Contabilidad.dbo.TotalesCierreMensual where IdPeriodo in(select An.Id_Periodo from Contabilidad.dbo.Periodo as Ac inner join Contabilidad.dbo.Periodo as An on an.Mes = (case ac.mes when 1 then 12 else ac.Mes - 1 end) and an.Anno = (case ac.mes when 1 then ac.Anno -1 else ac.Anno end) where ac.Id_Periodo = " & Me.id_periodo1 & ")", dt, Configuracion.Claves.Conexion("Contabilidad"))
                    If dt.Rows.Count > 0 Then
                        Select Case Me.cod_moneda
                            Case 1
                                EfeP1 = dt.Rows(0).Item("EfectivoalFinalC")
                            Case 2
                                EfeP1 = dt.Rows(0).Item("EfectivoalFinalD")
                        End Select
                    Else
                        EfeP1 = 0
                    End If

                    cFunciones.Llenar_Tabla_Generico("select isnull(EfectivoalFinalC,0) as EfectivoalFinalC, isnull(EfectivoalFinalD,0) as EfectivoalFinalD from Contabilidad.dbo.TotalesCierreMensual where IdPeriodo in(select An.Id_Periodo from Contabilidad.dbo.Periodo as Ac inner join Contabilidad.dbo.Periodo as An on an.Mes = (case ac.mes when 1 then 12 else ac.Mes - 1 end) and an.Anno = (case ac.mes when 1 then ac.Anno -1 else ac.Anno end) where ac.Id_Periodo = " & Me.id_periodo2 & ")", dt, Configuracion.Claves.Conexion("Contabilidad"))
                    If dt.Rows.Count > 0 Then
                        Select Case Me.cod_moneda
                            Case 1
                                EfeP2 = dt.Rows(0).Item("EfectivoalFinalC")
                            Case 2
                                EfeP2 = dt.Rows(0).Item("EfectivoalFinalD")
                        End Select
                    Else
                        EfeP2 = 0
                    End If

                    oTable4.Cell(r + Linea, 1).Range.Text = "EFECTIVO E INVERSIONES AL INICIO DEL EJERCICIO "
                    oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(EfeP1)), "#,##00")
                    oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(EfeP2)), "#,##00")
                    Linea += 1

                    oTable4.Cell(r + Linea, 1).Range.Text = "EFECTIVO E INVERSIONES AL FINAL DEL EJERCICIO "
                    oTable4.Cell(r + Linea, 2).Range.Text = Format((CDbl(EfeP1 + TP1)), "#,##00")
                    oTable4.Cell(r + Linea, 3).Range.Text = Format((CDbl(EfeP2 + TP2)), "#,##00")
                    Linea += 1
                    'aqui
                End If

            Next

            oTable4.Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable4.Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable4.Cell(1, 2).Range.Text = _pP1 : oTable4.Cell(1, 3).Range.Text = _pP2

            'oTable4.Cell(rFin - 2, 1).Range.Text = "UTILIDAD NETA ANTES DE RENTA" : oTable4.Cell(rFin, 3).Range.Text = IngresosP1 - CostosP1 - GastosP1 : oTable4.Cell(rFin, 4).Range.Text = IngresosP2 - CostosP2 - GastosP2
            'oTable4.Cell(rFin - 1, 1).Range.Text = dtRenta.Rows(0).Item("Descripcion") : oTable4.Cell(rFin - 1, 1).Range.Text = dtRenta.Rows(0).Item("Notas")

            If _pP1.StartsWith("12") Then
                oTable4.Cell(rFin, 3).Range.Text = renta_P1
            Else
                renta_P1 = 0
                oTable4.Cell(rFin, 3).Range.Text = 0
            End If
            'If _pP2.StartsWith("12") Then
            '    oTable4.Cell(rFin, 4).Range.Text = renta_P2
            'Else
            '    renta_P2 = 0
            '    oTable4.Cell(rFin, 4).Range.Text = 0
            'End If

            'oTable4.Cell(rFin, 1).Range.Text = "UTILIDAD NETA DESPUES DE RENTA" : oTable4.Cell(rFin, 1).Range.Text = dtRenta.Rows(0).Item("Notas")
            'oTable4.Cell(rFin, 3).Range.Text = utilidadAR_P1 - renta_P1 : oTable4.Cell(rFin, 4).Range.Text = utilidadAR_P2 - renta_P2
            oTable4.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitContent)
            oTable4.Range.InsertParagraphAfter()

            '/* FIN PAGINA 4

        End If


    End Sub

    Public cod_moneda As Integer
    Public id_periodo1 As Integer
    Public id_periodo2 As Integer
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

    Private Function GetTextoPeriodoTerminadoCorto(ByVal _periodo As String) As String
        Dim Pe() As String
        Pe = _periodo.Split("/")
        Select Case Pe(0)
            Case "1"
                Return "Octubre " & (CInt(Pe(1)) - 1).ToString
            Case "2"
                Return "Noviembre " & (CInt(Pe(1)) - 1).ToString
            Case "3"
                Return "Diciembre " & (CInt(Pe(1)) - 1).ToString
            Case "4"
                Return "Enero " & Pe(1)
            Case "5"
                Return Me.AnoyFebrero(Pe(1)) & " de Febrero del " & Pe(1)
            Case "6"
                Return "Marzo " & Pe(1)
            Case "7"
                Return "Abril " & Pe(1)
            Case "8"
                Return "Mayo " & Pe(1)
            Case "9"
                Return "Junio " & Pe(1)
            Case "10"
                Return "Julio " & Pe(1)
            Case "11"
                Return "Agosto " & Pe(1)
            Case "12"
                Return "Septiembre " & Pe(1)
        End Select
    End Function

    Private Sub getTipoCambio(ByVal _periodo As String, ByRef _compra As Decimal, ByRef _venta As Decimal)
        Dim dt As New DataTable
        Dim strSQL As String
        strSQL = "select ValorCompra, ValorVenta from Moneda where CodMoneda = 2"
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, Configuracion.Claves.Conexion("Seguridad"))
        If dt.Rows.Count > 0 Then
            _compra = dt.Rows(0).Item(0)
            _venta = dt.Rows(0).Item(0)
        End If
        Dim Pe() As String
        Pe = _periodo.Split("/")
        Select Case Pe(0)
            Case "1"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 10 and year(fecha) = " & Pe(1) - 1 & " order by Fecha desc"
            Case "2"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 11 and year(fecha) = " & Pe(1) - 1 & " order by Fecha desc"
            Case "3"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 12 and year(fecha) = " & Pe(1) - 1 & " order by Fecha desc"
            Case "4"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 1 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "5"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 2 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "6"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 3 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "7"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 4 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "8"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 5 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "9"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 6 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "10"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 7 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "11"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 8 and year(fecha) = " & Pe(1) & " order by Fecha desc"
            Case "12"
                strSQL = "select top 1 isnull(HistoricoMoneda.ValorCompra, 0) as ValorCompra, isnull(HistoricoMoneda.ValorVenta, 0) as ValorVenta from HistoricoMoneda  where Id_Moneda = 2 and month(Fecha) = 9 and year(fecha) = " & Pe(1) & " order by Fecha desc"
        End Select
        cFunciones.Llenar_Tabla_Generico(strSQL, dt, Configuracion.Claves.Conexion("Seguridad"))
        If dt.Rows.Count > 0 Then
            _compra = dt.Rows(0).Item(0)
            _venta = dt.Rows(0).Item(0)
        End If
    End Sub

    Sub sp_GenerarNotas()
        Dim oTable As Word.Table()
        Dim oTable2 As Word.Table()
        Try
            Dim VentaP1, VentaP2, CompraP1, CompraP2 As Decimal
            Me.getTipoCambio(Me._pP1, CompraP1, VentaP1)
            Me.getTipoCambio(Me._pP2, CompraP2, VentaP2)
            pDoc.Bookmarks.Item("Fecha1").Range.Text = Me.GetTextoPeriodoTerminado(Me._pP1)
            pDoc.Bookmarks.Item("Fecha2").Range.Text = Me.GetTextoPeriodoTerminado(Me._pP2)

            ReDim oTable2(1)

            oTable2(0) = pDoc.Tables.Add(pDoc.Bookmarks.Item("TipoCambio").Range, 3, 3)

            'oTable2(0).Range.Font.Bold = True
            oTable2(0).Cell(1, 1).Range.Text = "Descripción "
            oTable2(0).Cell(1, 2).Range.Text = GetTextoPeriodoTerminadoCorto(_pP1)
            oTable2(0).Cell(1, 3).Range.Text = GetTextoPeriodoTerminadoCorto(_pP2)
            oTable2(0).Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
            oTable2(0).Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable2(0).Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable2(0).Cell(1, 1).Width = 200 : oTable2(0).Cell(1, 2).Width = 100 : oTable2(0).Cell(1, 3).Width = 100

            'oTable2(0).Range.Font.Bold = False
            oTable2(0).Cell(2, 1).Range.Text = "Venta "
            oTable2(0).Cell(2, 2).Range.Text = VentaP1
            oTable2(0).Cell(2, 3).Range.Text = VentaP2
            oTable2(0).Cell(2, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable2(0).Cell(2, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable2(0).Cell(2, 1).Width = 200 : oTable2(0).Cell(2, 2).Width = 100 : oTable2(0).Cell(2, 3).Width = 100

            'oTable2(0).Range.Font.Bold = False
            oTable2(0).Cell(3, 1).Range.Text = "Compra "
            oTable2(0).Cell(3, 2).Range.Text = CompraP1
            oTable2(0).Cell(3, 3).Range.Text = CompraP2
            oTable2(0).Cell(3, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable2(0).Cell(3, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
            oTable2(0).Cell(3, 1).Width = 200 : oTable2(0).Cell(3, 2).Width = 100 : oTable2(0).Cell(3, 3).Width = 100

        Catch ex As Exception

        End Try


        ' pDoc.Bookmarks.Item("Compañia").Range.Text = txtCompañia.Text
        If pDoc.Bookmarks.Exists("Compañia2") Then
            pDoc.Bookmarks.Item("Compañia2").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia3") Then
            pDoc.Bookmarks.Item("Compañia3").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia4") Then
            pDoc.Bookmarks.Item("Compañia4").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia5") Then
            pDoc.Bookmarks.Item("Compañia5").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia6") Then
            pDoc.Bookmarks.Item("Compañia6").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia7") Then
            pDoc.Bookmarks.Item("Compañia7").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia8") Then
            pDoc.Bookmarks.Item("Compañia8").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia9") Then
            pDoc.Bookmarks.Item("Compañia9").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia10") Then
            pDoc.Bookmarks.Item("Compañia10").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia11") Then
            pDoc.Bookmarks.Item("Compañia11").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia12") Then
            pDoc.Bookmarks.Item("Compañia12").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia13") Then
            pDoc.Bookmarks.Item("Compañia13").Range.Text = txtCompañia.Text
        End If
        If pDoc.Bookmarks.Exists("Compañia14") Then
            pDoc.Bookmarks.Item("Compañia14").Range.Text = txtCompañia.Text
        End If
        Dim dtNotas As New DataTable
        cls_Datos.sp_llenarTabla("Select * From tbNotasSecundaria ORDER BY Numero, Letra", dtNotas, "Contabilidad")
        ReDim oTable(dtNotas.Rows.Count)
        Dim p1 As String, p2 As String
        For i As Integer = 0 To dtNotas.Rows.Count - 1
            Dim nota As String = ("Nota" & dtNotas.Rows(i).Item("Numero") & "" & dtNotas.Rows(i).Item("Letra"))
            nota = nota.Trim(" ")

            Dim T1, T2 As Decimal

            If pDoc.Bookmarks.Exists(nota) Then
                Dim cuentas As New DataTable : Dim totales As New DataTable
                cls_Datos.sp_llenarTabla("SELECT n.ID_NotaSecundaria, e.CuentaContable, n.Descripcion as Descripcion, e.Periodo1, e.Periodo2 FROM tbNotasSecundariaDet AS n INNER JOIN  Estado1 AS e ON n.CuentaContable = e.CuentaContable Where ID_NotaSecundaria =" & dtNotas.Rows(i).Item("ID") & " ORDER BY n.ID", cuentas, "Contabilidad")
                cls_Datos.sp_llenarTabla("SELECT n.ID_NotaSecundaria, SUM(e.Periodo1) AS P1, SUM(e.Periodo2) AS P2 FROM tbNotasSecundariaDet AS n INNER JOIN  Estado1 AS e ON n.CuentaContable = e.CuentaContable GROUP BY n.ID_NotaSecundaria HAVING n.ID_NotaSecundaria = " & dtNotas.Rows(i).Item("ID") & " ", totales, "Contabilidad")
                If cuentas.Rows.Count > 0 Then

                    oTable(i) = pDoc.Tables.Add(pDoc.Bookmarks.Item(nota).Range, cuentas.Rows.Count + 2, 3)
                    oTable(i).Range.Font.Bold = False
                    oTable(i).Cell(1, 1).Range.Text = dtNotas.Rows(i).Item("Numero") & "." & dtNotas.Rows(i).Item("Letra").ToString.Trim(" ") & ") " & dtNotas.Rows(i).Item("Descripcion") : oTable(i).Cell(1, 2).Range.Text = _pP1 : oTable(i).Cell(1, 3).Range.Text = _pP2
                    oTable(i).Cell(1, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable(i).Cell(1, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                    oTable(i).Cell(1, 1).Width = 250 : oTable(i).Cell(1, 2).Width = 85 : oTable(i).Cell(1, 3).Width = 85
                    For ii As Integer = 0 To cuentas.Rows.Count - 1
                        p1 = Format(Math.Abs(CDbl(cuentas.Rows(ii).Item("Periodo1"))), "#,##00")
                        p2 = Format(Math.Abs(CDbl(cuentas.Rows(ii).Item("Periodo2"))), "#,##00")
                        Dim r As Integer = ii + 1
                        r = r + 1

                        oTable(i).Cell(r, 1).Range.Text = cuentas.Rows(ii).Item("Descripcion") : oTable(i).Cell(r, 1).Width = 250 : oTable(i).Cell(r, 2).Width = 85 : oTable(i).Cell(r, 3).Width = 85

                        oTable(i).Cell(r, 2).Range.Text = p1 : oTable(i).Cell(r, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable(i).Cell(r, 3).Range.Text = p2 : oTable(i).Cell(r, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight

                        T1 += CDec(p1)
                        T2 += CDec(p2)
                    Next
                    If totales.Rows.Count > 0 Then
                        Dim f As Integer = cuentas.Rows.Count + 2

                        p1 = Format(Math.Abs(CDbl(totales.Rows(0).Item("P1"))), "#,##00")
                        p2 = Format(Math.Abs(CDbl(totales.Rows(0).Item("P2"))), "#,##00")

                        oTable(i).Cell(f, 1).Range.Text = "Total:" : oTable(i).Cell(f, 1).Width = 250 : oTable(i).Cell(f, 2).Width = 85 : oTable(i).Cell(f, 3).Width = 85
                        oTable(i).Cell(f, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable(i).Cell(f, 2).Range.Text = Format(Math.Abs(CDbl(T1)), "#,##00") 'p1
                        oTable(i).Cell(f, 2).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        oTable(i).Cell(f, 3).Range.Text = Format(Math.Abs(CDbl(T2)), "#,##00") 'p2
                        oTable(i).Cell(f, 3).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
                        T1 = 0 : T2 = 0
                    End If

                End If
            End If
        Next

    End Sub


    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        sp_Generar()

    End Sub
End Class
