

Imports Utilidades_DB
Imports Microsoft.VisualBasic
Public Class FrmMantenimientoPresupuesto
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents btnPeriodoFiscal As System.Windows.Forms.Button
    Friend WithEvents txtPeriodo_fiscal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_perodoFiscal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DtsPresupuesto1 As Contabilidad.dtsPresupuesto
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnPeriodoFiscal = New System.Windows.Forms.Button
        Me.txtPeriodo_fiscal = New System.Windows.Forms.TextBox
        Me.lbl_perodoFiscal = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DtsPresupuesto1 = New Contabilidad.dtsPresupuesto
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsPresupuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPeriodoFiscal
        '
        Me.btnPeriodoFiscal.Location = New System.Drawing.Point(376, 32)
        Me.btnPeriodoFiscal.Name = "btnPeriodoFiscal"
        Me.btnPeriodoFiscal.Size = New System.Drawing.Size(48, 23)
        Me.btnPeriodoFiscal.TabIndex = 15
        Me.btnPeriodoFiscal.Text = "Buscar"
        '
        'txtPeriodo_fiscal
        '
        Me.txtPeriodo_fiscal.Enabled = False
        Me.txtPeriodo_fiscal.Location = New System.Drawing.Point(120, 32)
        Me.txtPeriodo_fiscal.Name = "txtPeriodo_fiscal"
        Me.txtPeriodo_fiscal.Size = New System.Drawing.Size(240, 20)
        Me.txtPeriodo_fiscal.TabIndex = 14
        Me.txtPeriodo_fiscal.Text = ""
        '
        'lbl_perodoFiscal
        '
        Me.lbl_perodoFiscal.Location = New System.Drawing.Point(8, 32)
        Me.lbl_perodoFiscal.Name = "lbl_perodoFiscal"
        Me.lbl_perodoFiscal.Size = New System.Drawing.Size(88, 23)
        Me.lbl_perodoFiscal.TabIndex = 13
        Me.lbl_perodoFiscal.Text = "Periodo Fiscal"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(432, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(56, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Aprobar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(496, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Rechazar"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "datos"
        Me.GridControl1.DataSource = Me.DtsPresupuesto1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(24, 56)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(544, 320)
        Me.GridControl1.Styles.AddReplace("Style1", New DevExpress.Utils.ViewStyleEx("Style1", "", "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.Lime, System.Drawing.SystemColors.WindowText, System.Drawing.Color.Lime, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 21
        Me.GridControl1.Text = "GridControl1"
        '
        'DtsPresupuesto1
        '
        Me.DtsPresupuesto1.DataSetName = "dtsPresupuesto"
        Me.DtsPresupuesto1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {New DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, Nothing, "Style1", True, Nothing, Me.GridColumn2, True)})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "nombre"
        Me.GridColumn1.FieldName = "n"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 1
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "check"
        Me.GridColumn2.FieldName = "ch"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 2
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "monto cambio"
        Me.GridColumn3.FieldName = "m"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 4
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "id_periodo"
        Me.GridColumn4.FieldName = "id"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 0
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "montoanterior"
        Me.GridColumn5.FieldName = "ma"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn5.VisibleIndex = 3
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = " Mes"
        Me.GridColumn6.FieldName = "Mes"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 5
        '
        'FrmMantenimientoPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(584, 394)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPeriodoFiscal)
        Me.Controls.Add(Me.txtPeriodo_fiscal)
        Me.Controls.Add(Me.lbl_perodoFiscal)
        Me.Name = "FrmMantenimientoPresupuesto"
        Me.Text = "Autorizar Modificaciones de Presupuesto"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsPresupuesto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables"
    Dim txtId_PeridoFiscal As Integer = 0
    Dim IDPeriodo = 0
    Dim Class_cFunciones As New cFunciones
    Dim Cuenta_Contable As String = ""

#End Region

    Private Sub RutinaBuscarPeriodoFiscal()
        Try
            'SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal WHERE Id = @Id
            Dim fx As New cFunciones
            Dim IdP As String = ""
            txtId_PeridoFiscal = 0
            IdP = fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "(CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11)))", "Buscar Periodo Fiscal...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")
            txtId_PeridoFiscal = Convert.ToInt32(IdP)


            If IdP <> "" Then
                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                par.Add("@ID", IdP)
                db.Fill_Generic_Table("Contabilidad", dt, "SELECT Id, CAST(CONVERT(datetime, FechaInicio, 103) AS char(11)) + ' - ' + CAST(CONVERT(datetime, FechaFinal, 103) AS Char(11)) AS PeriodoFiscal FROM PeriodoFiscal WHERE (Id = @ID)", CommandType.Text, par)
                IDPeriodo = 0
                If dt.Rows.Count > 0 Then
                    txtPeriodo_fiscal.Text = dt.Rows(0).Item(1)
                    IDPeriodo = dt.Rows(0).Item(0)
                End If

                '''Dim TblDataSet As DataSet = Class_cFunciones.GetCuentasContables_Tabla_Presupuesto2(IDPeriodo)

                '''montaCausas(TblDataSet)
                '''Dim DateFecha As String = ""
                '''Dim d As String = ""
                '''DateFecha = Format(Now, "h:m:s")

               
                Dim sel As String = "SELECT Distinct(Presupuestos.Descripcion) as n ,ModificacionesPresupuesto.Id, ModificacionesPresupuesto.MontoAnterior as ma, ModificacionesPresupuesto.MontoActual as  m, 0 as ch, ModificacionesPresupuesto.Mes as Mes FROM ModificacionesPresupuesto, Presupuestos WHERE  ModificacionesPresupuesto.Estado ='P' AND  ModificacionesPresupuesto.Cuenta_Contable = Presupuestos.Cuenta_Contable And ModificacionesPresupuesto.Id_Periodo_Fiscal =" & Me.IDPeriodo
                cFunciones.Llenar_Tabla_Generico(sel, Me.DtsPresupuesto1.datos, Configuracion.Claves.Conexion("Contabilidad"))





            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnPeriodoFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodoFiscal.Click
        RutinaBuscarPeriodoFiscal()
    End Sub



    Private Sub FrmMantenimientoPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)
        
    End Sub

    Private Sub DataGrid1_ChangeUICues(ByVal sender As System.Object, ByVal e As System.Windows.Forms.UICuesEventArgs)

    End Sub


  


    Dim dtsPredefinidas As New DataSet
    Private Sub montaCausas(ByRef Datos As DataSet)
        Try
            Dim i As Integer
            Dim tabla As DataTable
            Dim campo As DataColumn
            Dim registro As DataRow



            tabla = New DataTable("Periodo fiscal " & txtPeriodo_fiscal.Text)
            campo = New DataColumn("Seleccionado", GetType(System.Boolean))
            campo.DefaultValue = False
            tabla.Columns.Add(campo)
            campo = New DataColumn("Id_Periodo_Fiscal", GetType(System.String))
            tabla.Columns.Add(campo)
            campo = New DataColumn("Des", GetType(System.String))
            tabla.Columns.Add(campo)
            'campo.DefaultValue = ""
            campo = New DataColumn("Monto1", GetType(System.Double))
            tabla.Columns.Add(campo)
            'campo.DefaultValue = ""
            campo = New DataColumn("MontoActual", GetType(System.Double))
            'campo.DefaultValue = ""
            tabla.Columns.Add(campo)

            'For i = 0 To causas.Tables("Textos").Rows.Count - 1
            For i = 0 To Datos.Tables(0).Rows.Count - 1
                registro = tabla.NewRow
                registro("Seleccionado") = False
                registro("Id_Periodo_Fiscal") = CStr(Datos.Tables(0).Rows(i)("Id_Periodo_Fiscal"))
                registro("Des") = CStr(Datos.Tables(0).Rows(i)("Descripcion"))
                registro("Monto1") = CDbl(Datos.Tables(0).Rows(i)("MontoAnterior"))
                registro("MontoActual") = CStr(Datos.Tables(0).Rows(i)("MontoActual"))
                tabla.Rows.Add(registro)
            Next
            dtsPredefinidas.Tables.Add(tabla)
            'dtgObservaciones.DataSource = dtsPredefinidas

            ' DataGrid1.DataSource = New DataView(dtsPredefinidas.Tables("Periodo fiscal " & txtPeriodo_fiscal.Text), "", "Des", DataViewRowState.CurrentRows)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub





    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            Dim ExisteSeleccionado As Boolean = False

            For i As Integer = 0 To Me.DtsPresupuesto1.datos.Count - 1
                If Me.DtsPresupuesto1.datos(i).ch Then
                    ExisteSeleccionado = True
                End If

            Next
            If ExisteSeleccionado = True Then
                Dim Confirmar As Integer = 0
                Confirmar = MsgBox("Estimado Usuario Esta seguro que desea Aprobar los Presupuesto Seleccionados ", MsgBoxStyle.YesNoCancel, "Aprobar Presupuesto")
                Select Case Confirmar
                    Case 6
                        For i As Integer = 0 To Me.DtsPresupuesto1.datos.Count - 1
                            If Me.DtsPresupuesto1.datos(i).ch Then
                                Dim up As String = "update ModificacionesPresupuesto set Estado = 'A', FechaAprobacion=GETDATE() Where Id =" & Convert.ToInt32(Me.DtsPresupuesto1.datos(i).id)
                                Dim cnx As New Conexion
                                cnx.Conectar("SeeSoft", "Contabilidad")
                                cnx.SlqExecute(cnx.sQlconexion, up)

                            End If

                        Next
                        Dim sel As String = "SELECT Distinct(Presupuestos.Descripcion) as n ,ModificacionesPresupuesto.Id, ModificacionesPresupuesto.MontoAnterior as ma, ModificacionesPresupuesto.MontoActual as  m, 0 as ch, ModificacionesPresupuesto.Mes as Mes FROM ModificacionesPresupuesto, Presupuestos WHERE  ModificacionesPresupuesto.Estado ='P' AND  ModificacionesPresupuesto.Cuenta_Contable = Presupuestos.Cuenta_Contable And ModificacionesPresupuesto.Id_Periodo_Fiscal =" & Me.IDPeriodo
                        cFunciones.Llenar_Tabla_Generico(sel, Me.DtsPresupuesto1.datos, Configuracion.Claves.Conexion("Contabilidad"))

                        MsgBox("Presupuesto Aprobado", MsgBoxStyle.Exclamation, "Aprobado..")
                    Case 7

                    Case 2

                End Select

            End If

        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try



    End Sub

    Private Sub DataGrid1_Navigate_1(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs)

    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Try
            Dim ExisteSeleccionado As Boolean = False

            For i As Integer = 0 To Me.DtsPresupuesto1.datos.Count - 1
                If Me.DtsPresupuesto1.datos(i).ch Then

                    ExisteSeleccionado = True
                End If

            Next
            If ExisteSeleccionado = True Then
                Dim Confirmar As Integer = 0
                Confirmar = MsgBox("Estimado Usuario Esta seguro que desea Rechazar los Presupuesto Seleccionados ", MsgBoxStyle.YesNoCancel, "Rechazar Presupuesto")
                Select Case Confirmar
                    Case 6
                        For i As Integer = 0 To Me.DtsPresupuesto1.datos.Count - 1
                            If Me.DtsPresupuesto1.datos(i).ch Then
                                Dim up As String = "update ModificacionesPresupuesto set Estado = 'R', FechaAprobacion=GETDATE() Where Id =" & Me.DtsPresupuesto1.datos(i).id
                                Dim cnx As New Conexion
                                cnx.Conectar("SeeSoft", "Contabilidad")
                                cnx.SlqExecute(cnx.sQlconexion, up)

                            End If

                        Next
                        Dim sel As String = "SELECT Distinct(Presupuestos.Descripcion) as n ,ModificacionesPresupuesto.Id, ModificacionesPresupuesto.MontoAnterior as ma, ModificacionesPresupuesto.MontoActual as  m, 0 as ch, ModificacionesPresupuesto.Mes as Mes FROM ModificacionesPresupuesto, Presupuestos WHERE  ModificacionesPresupuesto.Estado ='P' AND  ModificacionesPresupuesto.Cuenta_Contable = Presupuestos.Cuenta_Contable And ModificacionesPresupuesto.Id_Periodo_Fiscal =" & Me.IDPeriodo
                        cFunciones.Llenar_Tabla_Generico(sel, Me.DtsPresupuesto1.datos, Configuracion.Claves.Conexion("Contabilidad"))

                        MsgBox("Presupuesto Rechazado", MsgBoxStyle.Information, "Rechazado..")
                    Case 7
                    Case 2

                End Select

            End If


        Catch ex As Exception
            MsgBox("" & ex.Message)
        End Try
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class
