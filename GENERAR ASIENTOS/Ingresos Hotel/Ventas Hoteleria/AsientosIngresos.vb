Imports System.Data.SqlClient
Imports Utilidades
Public Class AsientosIngresos
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim ced As String
    Dim usua As Object
    Dim TipoCambio As Double = 0
    Dim DiferencialCambiario As Double = 0
    Dim conectadobd As New SqlClient.SqlConnection
    Dim diferencia As Double = 0
    Dim asientoCosto As Boolean = False
    Dim diferencia_distribuida As Double = 0
    Dim Comision As Boolean = False
#End Region

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
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarCostoVenta As System.Windows.Forms.Button
    Friend WithEvents btnGenerarVenta As System.Windows.Forms.Button
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adPuntoVenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsIngresos1 As dsIngresos
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBoxDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEnviar As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBoxDistribuirDiferencia As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxMontoEnviar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonEnviarCuenta As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AsientosIngresos))
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerarCostoVenta = New System.Windows.Forms.Button
        Me.btnGenerarVenta = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.DsIngresos1 = New Contabilidad.dsIngresos
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.txtTotalHaber = New System.Windows.Forms.TextBox
        Me.txtTotalDebe = New System.Windows.Forms.TextBox
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.adAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adDetalleAsiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adPuntoVenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TextBoxDiferencia = New System.Windows.Forms.TextBox
        Me.ButtonEnviar = New System.Windows.Forms.Button
        Me.GroupBoxDistribuirDiferencia = New System.Windows.Forms.GroupBox
        Me.ButtonEnviarCuenta = New System.Windows.Forms.Button
        Me.TextBoxMontoEnviar = New System.Windows.Forms.TextBox
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDistribuirDiferencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(624, 32)
        Me.TituloModulo.TabIndex = 71
        Me.TituloModulo.Text = "Asientos de Ingresos"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(184, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarCostoVenta
        '
        Me.btnGenerarCostoVenta.Location = New System.Drawing.Point(304, 88)
        Me.btnGenerarCostoVenta.Name = "btnGenerarCostoVenta"
        Me.btnGenerarCostoVenta.Size = New System.Drawing.Size(152, 23)
        Me.btnGenerarCostoVenta.TabIndex = 163
        Me.btnGenerarCostoVenta.Text = "Generar Asiento Costo"
        Me.btnGenerarCostoVenta.Visible = False
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Location = New System.Drawing.Point(304, 56)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(152, 23)
        Me.btnGenerarVenta.TabIndex = 162
        Me.btnGenerarVenta.Text = "Generar Asiento Ingreso"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(184, 96)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 161
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(16, 96)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 160
        '
        'griDetalle
        '
        Me.griDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.griDetalle.DataSource = Me.DsIngresos1.DetallesAsientosContable
        '
        '
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(8, 119)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(608, 245)
        Me.griDetalle.TabIndex = 236
        Me.griDetalle.Text = "Asientos de venta"
        '
        'DsIngresos1
        '
        Me.DsIngresos1.DataSetName = "dsIngresos"
        Me.DsIngresos1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsIngresos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GroupPanelText = "Detalle del Asiento"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo5
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 101
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "NombreCuenta"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo6
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 266
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Debe"
        Me.GridColumn3.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "MontoDebe"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo7
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Haber"
        Me.GridColumn4.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "MontoHaber"
        Me.GridColumn4.FilterInfo = ColumnFilterInfo8
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 116
        '
        'btnDetalle
        '
        Me.btnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetalle.Location = New System.Drawing.Point(8, 375)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnDetalle.TabIndex = 239
        Me.btnDetalle.Text = "Detalle"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(472, 367)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 20)
        Me.txtTotalHaber.TabIndex = 238
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(320, 367)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 20)
        Me.txtTotalDebe.TabIndex = 237
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarRegistrar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 409)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(624, 52)
        Me.ToolBar1.TabIndex = 240
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(416, 434)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 20)
        Me.txtUsuario.TabIndex = 243
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(336, 434)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 13)
        Me.txtClave.TabIndex = 241
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(416, 418)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 244
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(336, 418)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 242
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(272, 24)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Punto de Venta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DsIngresos1.PuntoVenta
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.Location = New System.Drawing.Point(16, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(272, 24)
        Me.ComboBox1.TabIndex = 246
        Me.ComboBox1.ValueMember = "IdPuntoVenta"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Hotel"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'adAsientos
        '
        Me.adAsientos.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAsientos.InsertCommand = Me.SqlInsertCommand1
        Me.adAsientos.SelectCommand = Me.SqlSelectCommand1
        Me.adAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.adAsientos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'adDetalleAsiento
        '
        Me.adDetalleAsiento.DeleteCommand = Me.SqlDeleteCommand2
        Me.adDetalleAsiento.InsertCommand = Me.SqlInsertCommand2
        Me.adDetalleAsiento.SelectCommand = Me.SqlSelectCommand2
        Me.adDetalleAsiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.adDetalleAsiento.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
            "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'adPuntoVenta
        '
        Me.adPuntoVenta.SelectCommand = Me.SqlSelectCommand3
        Me.adPuntoVenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PuntoVenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdPuntoVenta", "IdPuntoVenta"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Id_Bodega", "Id_Bodega"), New System.Data.Common.DataColumnMapping("IdventaGrabado", "IdventaGrabado"), New System.Data.Common.DataColumnMapping("idVentaExento", "idVentaExento"), New System.Data.Common.DataColumnMapping("IdCostoVenta", "IdCostoVenta"), New System.Data.Common.DataColumnMapping("CobroFront", "CobroFront"), New System.Data.Common.DataColumnMapping("BaseDatos", "BaseDatos"), New System.Data.Common.DataColumnMapping("ContaGeneral", "ContaGeneral")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT IdPuntoVenta, Nombre, Tipo, Id_Bodega, IdventaGrabado, idVentaExento, IdCo" & _
            "stoVenta, CobroFront, BaseDatos, ContaGeneral FROM PuntoVenta ORDER BY Nombre"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'TextBoxDiferencia
        '
        Me.TextBoxDiferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDiferencia.Enabled = False
        Me.TextBoxDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDiferencia.Location = New System.Drawing.Point(368, 391)
        Me.TextBoxDiferencia.Name = "TextBoxDiferencia"
        Me.TextBoxDiferencia.ReadOnly = True
        Me.TextBoxDiferencia.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxDiferencia.TabIndex = 247
        Me.TextBoxDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEnviar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.Location = New System.Drawing.Point(520, 391)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(88, 16)
        Me.ButtonEnviar.TabIndex = 248
        Me.ButtonEnviar.Text = "Enviar dif. a"
        Me.ButtonEnviar.Visible = False
        '
        'GroupBoxDistribuirDiferencia
        '
        Me.GroupBoxDistribuirDiferencia.Controls.Add(Me.ButtonEnviarCuenta)
        Me.GroupBoxDistribuirDiferencia.Controls.Add(Me.TextBoxMontoEnviar)
        Me.GroupBoxDistribuirDiferencia.Location = New System.Drawing.Point(312, 296)
        Me.GroupBoxDistribuirDiferencia.Name = "GroupBoxDistribuirDiferencia"
        Me.GroupBoxDistribuirDiferencia.Size = New System.Drawing.Size(304, 88)
        Me.GroupBoxDistribuirDiferencia.TabIndex = 249
        Me.GroupBoxDistribuirDiferencia.TabStop = False
        Me.GroupBoxDistribuirDiferencia.Text = "Distribuir Diferencia"
        Me.GroupBoxDistribuirDiferencia.Visible = False
        '
        'ButtonEnviarCuenta
        '
        Me.ButtonEnviarCuenta.Location = New System.Drawing.Point(168, 48)
        Me.ButtonEnviarCuenta.Name = "ButtonEnviarCuenta"
        Me.ButtonEnviarCuenta.Size = New System.Drawing.Size(120, 23)
        Me.ButtonEnviarCuenta.TabIndex = 1
        Me.ButtonEnviarCuenta.Text = "Cuenta Contable"
        '
        'TextBoxMontoEnviar
        '
        Me.TextBoxMontoEnviar.Location = New System.Drawing.Point(16, 24)
        Me.TextBoxMontoEnviar.Name = "TextBoxMontoEnviar"
        Me.TextBoxMontoEnviar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBoxMontoEnviar.Size = New System.Drawing.Size(272, 20)
        Me.TextBoxMontoEnviar.TabIndex = 0
        Me.TextBoxMontoEnviar.Text = "0"
        '
        'AsientosIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(624, 461)
        Me.Controls.Add(Me.GroupBoxDistribuirDiferencia)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.TextBoxDiferencia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtTotalHaber)
        Me.Controls.Add(Me.txtTotalDebe)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarCostoVenta)
        Me.Controls.Add(Me.btnGenerarVenta)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.TituloModulo)
        Me.Name = "AsientosIngresos"
        Me.Text = "Asientos de Ingresos"
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDistribuirDiferencia.ResumeLayout(False)
        Me.GroupBoxDistribuirDiferencia.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Funciones Iniciacion"

    Private Sub IngresoGaleria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        SqlConnection2.ConnectionString = Configuracion.Claves.Conexion("Hotel")
        If Configuracion.Claves.Configuracion("ComisionPuntoVenta").Equals("1") Then
            Comision = True
        End If

        dtpFechaFinal.MaxDate = Now
        dtpFechaInicio.MaxDate = Now
        ValoresDefecto()
        Cargar()
        txtClave.TabIndex = 0
        txtClave.Focus()
    End Sub

    Private Sub Cargar()
        Limpiar()
        ActivarGui()
        adPuntoVenta.Fill(DsIngresos1.PuntoVenta)
    End Sub

    Private Sub ActivarGui()
        ToolBarNuevo.Enabled = False
        ToolBarRegistrar.Enabled = False
        btnGenerarVenta.Enabled = False
        btnGenerarCostoVenta.Enabled = False
        btnDetalle.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
    End Sub

    Private Sub Limpiar()

        DsIngresos1.DetallesAsientosContable.Clear()
        DsIngresos1.AsientosContables.Clear()
        DsIngresos1.DetallesAsientosContable.Clear()
        DsIngresos1.PorContabilizar.Clear()

        griDetalle.Refresh()
        txtTotalHaber.Text = ""
        txtTotalDebe.Text = ""
        txtTotalDebe.Text = Format(0, "¢###,##0.00")
        txtTotalHaber.Text = Format(0, "¢###,##0.00")
        Me.TextBoxDiferencia.Text = Format(0, "¢###,##0.00")
    End Sub

    Private Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsIngresos1.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsIngresos1.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsIngresos1.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsIngresos1.AsientosContables.TipoDocColumn.DefaultValue = 5
        DsIngresos1.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsIngresos1.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsIngresos1.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsIngresos1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.ModuloColumn.DefaultValue = "Asiento Compras"
        DsIngresos1.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsIngresos1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsIngresos1.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DsIngresos1.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsIngresos1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsIngresos1.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsIngresos1.DetallesAsientosContable.HaberColumn.DefaultValue = 0
        DsIngresos1.DetallesAsientosContable.TipocambioColumn.DefaultValue = 1
    End Sub

#End Region

#Region "Funciones Seguridad"
    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try
            If txtClave.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT  Nombre from Usuarios where Clave_Interna ='" & txtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        txtUsuario.Text = rs("Nombre")
                        txtUsuario.Enabled = False
                        txtClave.Enabled = False
                        ToolBarNuevo.Enabled = True
                        txtUsuario.Focus()
                        Return True
                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Function Conectando() As SqlConnection
        Dim sQlconexion As New SqlConnection
        Dim SQLStringConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = Configuracion.Claves.Conexion("Seguridad")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

#End Region

#Region "Funciones Validar"
    Private Function ValidarCampos() As Boolean
        'If Me.txtTotalHaber.Text <> Me.txtTotalDebe.Text Then
        '    MsgBox("No se puede registrar porque el balance no es correcto", MsgBoxStyle.Information)
        '    Exit Function
        'End If

        If Me.txtTotalHaber.Text = "" Or Me.txtTotalDebe.Text = "" Then
            MsgBox("No se puede registrar porque el balance no es correcto", MsgBoxStyle.Information)
            Exit Function
        End If
        ValidarCampos = True
    End Function
#End Region

#Region "Funciones Basicas"
    Private Sub NUEVO()
        Try
            Me.ButtonEnviar.Enabled = True
            Me.GroupBoxDistribuirDiferencia.Visible = False
            If ToolBarNuevo.Text = "Nuevo" Then
                ToolBarNuevo.ImageIndex = "4"
                ToolBarNuevo.Text = "Cancelar"
                btnGenerarVenta.Enabled = True
                btnGenerarCostoVenta.Enabled = True
                ToolBarRegistrar.Enabled = False
                dtpFechaInicio.Enabled = True
                dtpFechaFinal.Enabled = True
                btnDetalle.Enabled = True
                dtpFechaInicio.Focus()
            Else
                ToolBarNuevo.ImageIndex = "0"
                ToolBarNuevo.Text = "Nuevo"
                btnGenerarVenta.Enabled = False
                btnGenerarCostoVenta.Enabled = False
                ToolBarRegistrar.Enabled = False
                dtpFechaInicio.Enabled = False
                dtpFechaFinal.Enabled = False
                btnDetalle.Enabled = True
            End If
            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "GenerarAsiento"
    Private Sub GenerarCompra()
        Dim Fx As New cFunciones
        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Fx.ValidarPeriodo(dtpFechaFinal.Value) = False Then
            MsgBox("La fecha del asiento NO corresponde al periodo de trabajo! O el periodo esta cerrado!" & vbCrLf & "No se puede Generar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
            Exit Sub
        End If
        GenerarAsiento()
        btnDetalle.Enabled = True
        ToolBarRegistrar.Enabled = True
    End Sub

    Private Sub GenerarAsiento()
        Dim Fx As New cFunciones
        Try
            DiferencialCambiario = 0
            Limpiar()
            TipoCambio = Fx.TipoCambio(dtpFechaFinal.Value)
            BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
            BindingContext(DsIngresos1, "AsientosContables").AddNew()
            If Not Me.asientoCosto Then
                BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("ING-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")
                BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = "INGRESOS GENERALES"
                BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "Asiento Ingreso"
                BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = "Asiento de Ingresos " & ComboBox1.Text & " del " & dtpFechaInicio.Value & " al " & dtpFechaInicio.Value
            Else
                BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("COS-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")
                BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = "COSTO DE VENTA"
                BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "Asiento Costo de Venta"
                BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = "Asiento de Costo de Venta " & ComboBox1.Text & " del " & dtpFechaInicio.Value & " al " & dtpFechaInicio.Value
            End If

            BindingContext(DsIngresos1, "AsientosContables").Current("Fecha") = dtpFechaFinal.Value
            BindingContext(DsIngresos1, "AsientosContables").Current("IdNumDoc") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("NumDoc") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("TipoDoc") = 15
            BindingContext(DsIngresos1, "AsientosContables").Current("Accion") = "AUT"
            BindingContext(DsIngresos1, "AsientosContables").Current("Anulado") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("Mayorizado") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("FechaEntrada") = Now.Date
            BindingContext(DsIngresos1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(dtpFechaFinal.Value)
            BindingContext(DsIngresos1, "AsientosContables").Current("NumMayorizado") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
            BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 1
            BindingContext(DsIngresos1, "AsientosContables").Current("TipoCambio") = TipoCambio
            BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()

            'TOTAL DEBE y HABER
            If DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "FRONT DESK" And Not ced.Equals("3-101-188056") Then
                AsientosFrontDesk()
            ElseIf Me.asientoCosto = True Then
                Me.AsientoDetalleCosto()
            Else

                'CREA LOS DETALLES DEL ASIENTO DE OTROS PUNTO DE VENTA
                AsientoDetalle()

            End If
            totalDebeHaber()
            Dim cx As New Conexion
            Dim dt As DataTable = cx.AlphabeticSort(Me.DsIngresos1.DetallesAsientosContable.Copy, 1).Copy
            Me.DsIngresos1.DetallesAsientosContable.Clear()
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Debe") = True Then
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                End If

            Next
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Debe") = False Then
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                End If

            Next
            totalDebeHaber()
            If Me.DsIngresos1.PorContabilizar.Count > 0 Then
                Dim c As New FormCuentaNoDefinida
                c.ds = Me.DsIngresos1.Copy
                If c.ShowDialog() = DialogResult.OK Then

                    For j As Integer = 0 To c.DsIngresos1.PorContabilizar.Count - 1

                        Me.GuardaAsientoDetalle(c.DsIngresos1.PorContabilizar(j).Monto, c.DsIngresos1.PorContabilizar(j).Debe, c.DsIngresos1.PorContabilizar(j).Haber, c.DsIngresos1.PorContabilizar(j).CuentaAsignada, c.DsIngresos1.PorContabilizar(j).DescripcionCuenta)

                    Next
                    totalDebeHaber()
                End If

            End If
            
            btnDetalle.Enabled = True
            ToolBarRegistrar.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly)
        End Try

    End Sub
    Sub AsientosFrontDesk()
        'BUSCA CHECK OUTS
        Dim dtCheckOuts As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT Check_Out.Id,Check_Out.Fecha, Check_Out.Codigo, Check_Out.Total, Check_Out.Cod_Moneda, Check_Out.Tipo_Cambio, Cuentas.Total AS Total_Cuentas,  Cuentas.MontoPrepago, Cuentas.Id_Reservacion, Check_Out.Id_Cuenta FROM Check_Out INNER JOIN  Cuentas ON Check_Out.Id_Cuenta = Cuentas.Id " & _
                " WHERE Asiento= '0' AND " & _
                "   (dbo.DateOnly(Check_Out.Fecha) >= CONVERT(DATETIME, '" & Me.dtpFechaInicio.Value.Year & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) ) " & _
                " AND (dbo.DateOnly(Check_Out.Fecha)  <= CONVERT(DATETIME, '" & Me.dtpFechaFinal.Value.Year & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102)) ", _
                dtCheckOuts, Configuracion.Claves.Conexion("Hotel"))

        Dim anterior As String = ""

        For i As Integer = 0 To dtCheckOuts.Rows.Count - 1
            Dim cuenta_madre As Boolean = False
            Dim sinfac As Boolean = True

            'EVALUA FACTURAS LIGADAS

            Dim dtFacs As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT Ventas.Total,Ventas.Cod_Moneda,Ventas.Imp_Venta,Ventas.Monto_Saloero,Ventas.Tipo, Ventas.SubTotalGravada, Ventas.SubTotalExento, Ventas.Num_Factura, Ventas.Id, Ventas.Tipo_Cambio, Ventas.Fecha,  Ventas.TipoCambioDolar, " & dtCheckOuts.Rows(i).Item("MontoPrepago") & " AS MontoPrepago, Ventas.Id_Reservacion AS Id_Cuenta, Cuentas.Id_Reservacion,Ventas.Proveniencia_Venta FROM DetalleCheckOut INNER JOIN  Ventas ON DetalleCheckOut.Id_Ventas = Ventas.Id INNER JOIN  Cuentas ON Ventas.Id_Reservacion = Cuentas.Id " & _
                                             " WHERE  (DetalleCheckOut.Id_Check_Out = " & dtCheckOuts.Rows(i).Item("Id") & ") AND (Ventas.Anulado = 0)", dtFacs, Configuracion.Claves.Conexion("Hotel"))

            For j As Integer = 0 To dtFacs.Rows.Count - 1
                sinfac = False
                If dtFacs.Rows(j).Item("Tipo") = "CRE" Then
                    If dtFacs.Rows(j).Item("Proveniencia_Venta") = Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).IdPuntoVenta Then
                        If dtCheckOuts.Rows(i).Item("MontoPrepago") > 0 Then
                            '------------------------------------------------------------------
                            'busca el prepago
                            detallesContadoCheckOuts(dtFacs.Rows(j).Item("Num_Factura"), dtFacs.Rows(j).Item("Fecha"), dtFacs.Rows(j).Item("Tipo_Cambio"), dtFacs.Rows(j).Item("Cod_Moneda"), dtFacs.Rows(j).Item("TipoCambioDolar"), dtFacs, j)
                            '------------------------------------------------------------------
                        Else
                            '------------------------------------------------------------------
                            'GUARDA ASIENTO DETALLE PARA EL TOTAL DE CREDITO
                            If Not GuardaAsientoDetalle(Math.Round(dtCheckOuts.Rows(i).Item("Total"), 2) * dtCheckOuts.Rows(i).Item("Tipo_Cambio"), True, False, BuscaCuenta("CuentaContable", "IdCuentaCobrar"), BuscaCuenta("Descripcion", "IdCuentaCobrar")) Then
                                Me.incluirListaXContabilizar("Monto de credito (Debe)", Math.Round(dtCheckOuts.Rows(i).Item("Total"), 2) * dtCheckOuts.Rows(i).Item("Tipo_Cambio"), True, False)

                            End If
                            '------------------------------------------------------------------
                            cuenta_madre = True
                        End If

                    Else
                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL TOTAL CARGO A HABITACION

                        Dim montoC_Fac As Double = dtFacs.Rows(j).Item("Total") * dtFacs.Rows(j).Item("Tipo_Cambio")
                        'Dim montoNCheck As Double = dtFacs.Rows(j).Item("Total") * dtCheckOuts.Rows(i).Item("Tipo_Cambio")

                        'If dtFacs.Rows(j).Item("Tipo_Cambio") = 1 Then
                        '    montoC_Fac = dtFacs.Rows(j).Item("Total")
                        '    montoNCheck = dtFacs.Rows(j).Item("Total")
                        'End If
                        'Dim dif As Double = montoNCheck - montoC_Fac

                        'If dif > 0 Then
                        '    GuardaAsientoDetalle(dif, False, True, BuscaCuenta("CuentaContable", "IdDiferencial"), BuscaCuenta("Descripcion", "IdDiferencial"))
                        'ElseIf dif <> 0 Then
                        '    GuardaAsientoDetalle(Math.Abs(dif), True, False, BuscaCuenta("CuentaContable", "IdDiferencialGasto"), BuscaCuenta("Descripcion", "IdDiferencialGasto"))
                        'End If

                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL TOTAL CARGO A HABITACION
                        If Not GuardaAsientoDetalle(Math.Round(montoC_Fac, 2), False, True, BuscaCuenta("CuentaContable", "IdCxCHabitacion"), BuscaCuenta("Descripcion", "IdCxCHabitacion")) Then
                            Me.incluirListaXContabilizar("Monto de cargo habitacion", Math.Round(montoC_Fac, 2), False, True)

                        End If
                        '------------------------------------------------------------------
                        '------------------------------------------------------------------
                    End If



                ElseIf dtFacs.Rows(j).Item("Tipo") = "CAR" Then


                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL TOTAL CARGO A HABITACION
                    Dim montoC_Fac As Double = dtFacs.Rows(j).Item("Total") * dtFacs.Rows(j).Item("Tipo_Cambio")
                    'Dim montoNCheck As Double = dtFacs.Rows(j).Item("Total") * dtCheckOuts.Rows(i).Item("Tipo_Cambio")

                    'If dtFacs.Rows(j).Item("Tipo_Cambio") = 1 Then
                    '    montoC_Fac = dtFacs.Rows(j).Item("Total")
                    '    montoNCheck = dtFacs.Rows(j).Item("Total")
                    'End If


                    'Dim dif As Double = montoNCheck - montoC_Fac

                    'If dif > 0 Then
                    '    GuardaAsientoDetalle(dif, False, True, BuscaCuenta("CuentaContable", "IdDiferencial"), BuscaCuenta("Descripcion", "IdDiferencial"))
                    'ElseIf dif <> 0 Then
                    '    GuardaAsientoDetalle(Math.Abs(dif), True, False, BuscaCuenta("CuentaContable", "IdDiferencialGasto"), BuscaCuenta("Descripcion", "IdDiferencialGasto"))
                    'End If

                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL TOTAL CARGO A HABITACION
                    Dim m As Double = Math.Round(montoC_Fac, 2)
                    If Not GuardaAsientoDetalle(Math.Round(montoC_Fac, 2), False, True, BuscaCuenta("CuentaContable", "IdCxCHabitacion"), BuscaCuenta("Descripcion", "IdCxCHabitacion")) Then
                        Me.incluirListaXContabilizar("Monto de cargo habitacion", Math.Round(montoC_Fac, 2), False, True)

                    End If
                    '------------------------------------------------------------------
                    '------------------------------------------------------------------
                Else
                    If dtFacs.Rows(j).Item("Proveniencia_Venta") = Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).IdPuntoVenta Then
                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL TOTAL DE CONTADO
                        detallesContadoCheckOuts(dtFacs.Rows(j).Item("Num_Factura"), dtFacs.Rows(j).Item("Fecha"), dtFacs.Rows(j).Item("Tipo_Cambio"), dtFacs.Rows(j).Item("Cod_Moneda"), dtFacs.Rows(j).Item("TipoCambioDolar"), dtFacs, j)
                        '------------------------------------------------------------------
                    End If

                End If

                If dtFacs.Rows(j).Item("Proveniencia_Venta") = Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).IdPuntoVenta Then
                    cFunciones.Llenar_Tabla_Generico("Select * From Ventas Where Id = " & dtFacs.Rows(j).Item("Id"), Me.DsIngresos1.Ventas, Configuracion.Claves.Conexion("Hotel"))
                    cFunciones.Llenar_Tabla_Generico("Select * From ventas_detalle Where Id_Factura = " & dtFacs.Rows(j).Item("Id"), Me.DsIngresos1.Ventas_Detalle, Configuracion.Claves.Conexion("Hotel"))
                    detalleServicios(dtFacs.Rows(j).Item("Id"))
                    If Not dtFacs.Rows(j).Item("Num_Factura") = "0" Then
                        cuenta_madre = True
                    End If

                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL IMPUESTO DE VENTA
                    Dim mIV As Double = Math.Round(dtFacs.Rows(j).Item("Imp_Venta") * dtFacs.Rows(j).Item("Tipo_Cambio"), 2)
                    If Not GuardaAsientoDetalle(mIV, False, True, BuscaCuenta("CuentaContable", "IdImpuestoVenta"), BuscaCuenta("Descripcion", "IdImpuestoVenta")) Then
                        Me.incluirListaXContabilizar("Monto de Impuesto ventas (Haber)", mIV, False, True)
                    End If
                    '------------------------------------------------------------------

                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL IMPUESTO DE SERVICIO
                    Dim mIS As Double = Math.Round(dtFacs.Rows(j).Item("Monto_Saloero") * dtFacs.Rows(j).Item("Tipo_Cambio"), 2)
                    If Not GuardaAsientoDetalle(mIS, False, True, BuscaCuenta("CuentaContable", "IdServicio"), BuscaCuenta("Descripcion", "IdServicio")) Then
                        Me.incluirListaXContabilizar("Monto de Salonero (Haber)", mIS, False, True)
                    End If
                    '------------------------------------------------------------------

                End If

            Next

            If (Not cuenta_madre) And (Not sinfac) Then
                Dim cf As New cFunciones
                detallesContadoCheckOuts(dtCheckOuts.Rows(i).Item("Id"), dtCheckOuts.Rows(i).Item("fecha"), dtCheckOuts.Rows(i).Item("Tipo_Cambio"), dtCheckOuts.Rows(i).Item("Cod_Moneda"), cf.TipoCambio(dtCheckOuts.Rows(i).Item("fecha"), True), dtCheckOuts, i)
                anterior = dtCheckOuts.Rows(i).Item("Id")

            End If

        Next

        Me.DsIngresos1.Ventas.Clear()
        Me.DsIngresos1.Ventas_Detalle.Clear()


    End Sub


    Sub detallesContadoCheckOuts(ByVal doc As String, ByVal fecha As Date, ByVal Tipo_C As Double, ByVal Cod_moneda As Integer, ByVal TipoC_D As Double, ByVal dtCheckOut As DataTable, ByVal pos As Integer)
        Dim MontoE As Double = 0
        Dim MontoTar As Double = 0
        Try

        Catch ex As Exception

        End Try
        cargarOpcionesdePago(doc, fecha)

        For i As Integer = 0 To DsIngresos1.OpcionesDePago.Count - 1

            If DsIngresos1.OpcionesDePago(i).FormaPago = "TAR" Then
                '------------------------------------------------------------------
                'BUSCA LO PAGADO CON TARJETA

                cargarDetalle_pago(DsIngresos1.OpcionesDePago(i).id)

                For x As Integer = 0 To DsIngresos1.Detalle_pago_caja.Count - 1
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL SUBTOTAL DE TARJETA
                    If Cod_moneda = DsIngresos1.OpcionesDePago(i).CodMoneda Then
                        Dim m As Double = DsIngresos1.OpcionesDePago(i).MontoPago * Tipo_C
                        MontoTar += m
                        If Not GuardaAsientoDetalle(m, True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then
                            Me.incluirListaXContabilizar("Error cuenta (Debe) tarjeta Doc:" & DsIngresos1.OpcionesDePago(i).Documento, m, True, False)
                        End If
                    ElseIf Cod_moneda = 1 Then
                        Dim m As Double = (DsIngresos1.OpcionesDePago(i).MontoPago * TipoC_D)
                        If Not GuardaAsientoDetalle(m, True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then
                            Me.incluirListaXContabilizar("Error cuenta (Debe) tarjeta Doc:" & DsIngresos1.OpcionesDePago(i).Documento, m, True, False)
                        End If
                        MontoTar += DsIngresos1.OpcionesDePago(i).MontoPago * Tipo_C
                    Else
                        Dim m As Double = (DsIngresos1.OpcionesDePago(i).MontoPago)
                        If Not GuardaAsientoDetalle(m, True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then
                            Me.incluirListaXContabilizar("Error cuenta (Debe) tarjeta Doc:" & DsIngresos1.OpcionesDePago(i).Documento, m, True, False)
                        End If
                        MontoTar += DsIngresos1.OpcionesDePago(i).MontoPago * Tipo_C
                    End If
                    '------------------------------------------------------------------

                Next

            ElseIf DsIngresos1.OpcionesDePago(i).FormaPago = "TRA" Then
                '------------------------------------------------------------------
                'BUSCA LO PAGADO CON TRANSFERENCIA

                cargarDetalle_pago(DsIngresos1.OpcionesDePago(i).id)

                For x As Integer = 0 To DsIngresos1.Detalle_pago_caja.Count - 1
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL TRANSFERENCIA
                    If Cod_moneda = DsIngresos1.OpcionesDePago(i).CodMoneda Then

                        If Not GuardaAsientoDetalle(DsIngresos1.OpcionesDePago(i).MontoPago * Tipo_C, True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                            Me.incluirListaXContabilizar("Error enviado la cuenta de bancos (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), True, False)

                        End If

                    ElseIf Cod_moneda = 1 Then
                        If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago * TipoC_D), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then

                            Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar")), True, False)
                        End If

                    Else
                        If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                            Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, (DsIngresos1.OpcionesDePago(i).MontoPago), True, False)
                        End If
                    End If
                    '------------------------------------------------------------------

                Next
            Else
                '------------------------------------------------------------------
                'BUSCA LO PAGADO CON EFECTIVO Y CHEQUE
                If Cod_moneda = DsIngresos1.OpcionesDePago(i).CodMoneda Then
                    MontoE += DsIngresos1.OpcionesDePago(i).MontoPago * Tipo_C

                ElseIf DsIngresos1.OpcionesDePago(i).CodMoneda = 1 Then
                    MontoE += (DsIngresos1.OpcionesDePago(i).MontoPago)
                Else
                    MontoE += (DsIngresos1.OpcionesDePago(i).MontoPago * TipoC_D)

                End If
                '------------------------------------------------------------------

            End If
        Next


        '------------------------------------------------------------------
        'GUARDA ASIENTO DETALLE PARA EL SUBTOTAL DE CAJA
        If Not GuardaAsientoDetalle(MontoE, True, False, BuscaCuenta("CuentaContable", "IdCaja"), BuscaCuenta("Descripcion", "IdCaja")) Then
            Me.incluirListaXContabilizar("Monto Efectivo", MontoE, True, False)

        End If
        '------------------------------------------------------------------


        If dtCheckOut.Rows(pos).Item("MontoPrepago") > 0 Then

            'BUSCA PREPAGO

            'cFunciones.Llenar_Tabla_Generico("SELECT Id_Reservacion, Fecha, ISNULL(Id_Deposito,0) AS Id_Deposito, ISNULL(PrepagoGrupo,0) AS PrepagoGrupo, Monto FROM Prepagos WHERE (Id_Reservacion = " & dtCheckOut.Rows(pos).Item("Id_Reservacion") & ")", dtPrepago, Configuracion.Claves.Conexion("Hotel"))

            'If dtPrepago.Rows.Count = 0 Then
            'If dtCheckOut.Rows(pos).Item("Proveniencia_Venta") = 1 Then
            Dim m As Double = Math.Round(CDbl(dtCheckOut.Rows(pos).Item("MontoPrepago") * dtCheckOut.Rows(pos).Item("Tipo_Cambio")), 2)
            If Not GuardaAsientoDetalle(m, True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                Me.incluirListaXContabilizar("Monto de Prepago", m, True, False)

            End If
            'NO ENCONTRO EL DEPOSITO BANCARIO MEJOR SE SALE.
            If dtCheckOut.Rows(pos).Item("MontoPrepago") >= dtCheckOut.Rows(pos).Item("Total") Then Exit Sub

            'End If
        End If



    End Sub
    Sub totalDebeHaber()
        Dim debe As Double = 0
        Dim haber As Double = 0

        For i As Integer = 0 To Me.DsIngresos1.DetallesAsientosContable.Count - 1
            If Me.DsIngresos1.DetallesAsientosContable(i).Debe Then
                debe += Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoDebe = Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoHaber = 0
            Else
                haber += Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoHaber = Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoDebe = 0
            End If
        Next
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = debe
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = haber
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        Me.txtTotalDebe.Text = Format(debe, "¢ ###,##0.00")
        Me.txtTotalHaber.Text = Format(haber, "¢ ###,##0.00")
        Me.TextBoxDiferencia.Text = "Dif: " & Format(debe - haber, "¢ ###,##0.0000")
        diferencia = Math.Round(debe - haber, 6)
        If diferencia = 0 Then
            Me.ButtonEnviar.Visible = False
        ElseIf diferencia < 0 Then
            Me.ButtonEnviar.Text = "Enviar dif (debe)"
            Me.ButtonEnviar.Visible = True
        ElseIf diferencia > 0 Then
            Me.ButtonEnviar.Text = "Enviar dif (haber)"
            Me.ButtonEnviar.Visible = True
        End If


    End Sub
    Function prepagosTBL() As Boolean
        Dim dtPrepago As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT Id_Reservacion, Fecha, ISNULL(Id_Deposito,0) AS Id_Deposito, ISNULL(PrepagoGrupo,0) AS PrepagoGrupo, Monto FROM Prepagos WHERE (Id_Reservacion = " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id_Reservacion") & ")", dtPrepago, Configuracion.Claves.Conexion("Hotel"))
        Dim lohizo As Boolean = False
        If dtPrepago.Rows.Count = 0 Then
            Return False
        End If
        For j As Integer = 0 To dtPrepago.Rows.Count - 1
            If dtPrepago.Rows(j).Item("Id_Deposito") > 0 Then
                Dim dtDeposito As New DataTable
                'Busca el deposito en bancos
                cFunciones.Llenar_Tabla_Generico("SELECT Monto, TipoCambio, CodigoMoneda FROM Deposito WHERE (Id_Deposito = " & dtPrepago.Rows(j).Item("Id_Deposito") & ")", dtDeposito, Configuracion.Claves.Conexion("Bancos"))
                If dtDeposito.Rows.Count > 0 Then
                    If (dtDeposito.Rows(0).Item("Monto") - dtPrepago.Rows(j).Item("Monto")) < 100 Then
                        Dim cf As New cFunciones

                        Dim tipoC_eseDia As Double = cf.TipoCambio(dtPrepago.Rows(j).Item("Fecha"))
                        Dim montoC_Dep As Double = dtDeposito.Rows(0).Item("Monto") * dtDeposito.Rows(0).Item("TipoCambio") 'tipoC_eseDia
                        Dim montoNCheck As Double = dtDeposito.Rows(0).Item("Monto") * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")

                        Dim dif As Double = montoNCheck - montoC_Dep
                        GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                        lohizo = True
                    Else
                        If dtDeposito.Rows(0).Item("CodigoMoneda") = 2 Then

                            Dim montoC_Dep As Double = dtDeposito.Rows(0).Item("Monto") * dtDeposito.Rows(0).Item("TipoCambio")
                            GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                            lohizo = True
                        Else
                            GuardaAsientoDetalle(Math.Round(CDbl(dtDeposito.Rows(0).Item("Monto")), 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                            lohizo = True
                        End If

                    End If


                End If
            ElseIf dtPrepago.Rows(j).Item("PrepagoGrupo") > 0 Then
                Dim dt_Prep As New DataTable
                cFunciones.Llenar_Tabla_Generico("SELECT Id_GrupoPrepago, NombreCliente, IdCliente, TotalPrepado, Id_Deposito, Anulado, Fecha  FROM         Prepagos_Grupo WHERE     (Id_GrupoPrepago = " & dtPrepago.Rows(j).Item("PrepagoGrupo") & ")", dt_Prep, Configuracion.Claves.Conexion("Hotel"))
                If dt_Prep.Rows.Count > 0 Then
                    Dim dtDeposito As New DataTable
                    'Busca el deposito en bancos
                    cFunciones.Llenar_Tabla_Generico("SELECT Monto, TipoCambio, CodigoMoneda FROM Deposito WHERE (Id_Deposito = " & dt_Prep.Rows(0).Item("Id_Deposito") & ")", dtDeposito, Configuracion.Claves.Conexion("Bancos"))
                    If dtDeposito.Rows.Count > 0 Then
                        If (dtDeposito.Rows(0).Item("Monto") - dtPrepago.Rows(j).Item("Monto")) < 100 Then
                            Dim cf As New cFunciones

                            Dim tipoC_eseDia As Double = cf.TipoCambio(dtPrepago.Rows(j).Item("Fecha"))
                            Dim montoC_Dep As Double = dtPrepago.Rows(j).Item("Monto") * dtDeposito.Rows(0).Item("TipoCambio") 'tipoC_eseDia
                            Dim montoNCheck As Double = dtPrepago.Rows(j).Item("Monto") * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")

                            Dim dif As Double = montoNCheck - montoC_Dep
                            GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                            lohizo = True
                        Else
                            If dtDeposito.Rows(0).Item("CodigoMoneda") = 2 Then

                                Dim montoC_Dep As Double = dtPrepago.Rows(j).Item("Monto") * dtDeposito.Rows(0).Item("TipoCambio")
                                GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                                lohizo = True
                            Else
                                Dim montoC_Dep As Double = dtPrepago.Rows(j).Item("Monto") * dtDeposito.Rows(0).Item("TipoCambio")
                                GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                                lohizo = True
                            End If

                        End If


                    End If

                End If

            Else
                'EVALUA LOS PREPAGOS EN EFECTIVO O TARJETA
                cFunciones.Llenar_Tabla_Generico("Select * From OpcionesDePago WHERE (Documento = " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id_Cuenta") & ") AND FormaPago = 'PRE'", DsIngresos1.OpcionesDePago, Configuracion.Claves.Conexion(DsIngresos1.PuntoVenta(ComboBox1.SelectedIndex).BaseDatos))
                If DsIngresos1.OpcionesDePago.Count > 0 Then
                    For i As Integer = 0 To DsIngresos1.OpcionesDePago.Count - 1
                        If DsIngresos1.OpcionesDePago(i).CodMoneda = 2 Then
                            Dim montoC_Dep As Double = DsIngresos1.OpcionesDePago(i).MontoPago * DsIngresos1.OpcionesDePago(i).TipoCambio

                            GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                            lohizo = True
                        Else
                            GuardaAsientoDetalle(Math.Round(DsIngresos1.OpcionesDePago(i).MontoPago, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                            lohizo = True
                        End If

                    Next
                Else
                    'If dtCheckOut.Rows(pos).Item("Proveniencia_Venta") = 1 Then
                    GuardaAsientoDetalle(Math.Round(CDbl(Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Total") * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")), 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol"))
                    'NO ENCONTRO EL DEPOSITO BANCARIO MEJOR SE SALE.
                    Return True
                End If

            End If
        Next
        Return lohizo
    End Function

    Private Sub AsientoDetalle()
        Try
            For I As Integer = 0 To Me.DsIngresos1.Ventas.Count - 1
                BindingContext(DsIngresos1, "Ventas").Position = I
                If BindingContext(DsIngresos1, "Ventas").Current("Tipo") = "CRE" Then
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL TOTAL DE CREDITO
                    Dim mCre As Double = BindingContext(Me.DsIngresos1, "Ventas").Current("Total") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                    If Not GuardaAsientoDetalle(mCre, True, False, BuscaCuenta("CuentaContable", "IdCuentaCobrar"), BuscaCuenta("Descripcion", "IdCuentaCobrar")) Then
                        Me.incluirListaXContabilizar("Monto credito Debe ", mCre, True, False)
                    End If
                    '------------------------------------------------------------------
                ElseIf BindingContext(DsIngresos1, "Ventas").Current("Tipo") = "CAR" Then
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL TOTAL CARGO A HABITACION
                    Dim mGH As Double = BindingContext(Me.DsIngresos1, "Ventas").Current("Total") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                    If Not GuardaAsientoDetalle(mGH, True, False, BuscaCuenta("CuentaContable", "IdCxCHabitacion"), BuscaCuenta("Descripcion", "IdCxCHabitacion")) Then
                        Me.incluirListaXContabilizar("Monto cargo habitación Debe", mGH, True, False)
                    End If
                    '------------------------------------------------------------------
                Else
                    If ced.Equals("3-101-188056") Then
                        If Not Me.prepagosTBL Then

                            GuardaAsientoDetalle(BindingContext(Me.DsIngresos1, "Ventas").Current("Total") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), True, False, BuscaCuenta("CuentaContable", "IdPrepagoDol"), BuscaCuenta("Descripcion", "IdPrepagoDol"))
                        End If

                    Else
                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL TOTAL DE CONTADO
                        DetallesContado()
                        '------------------------------------------------------------------
                    End If

                End If
                If Not Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).ContaGeneral Then
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA LAS VENTAS GRAVADAS
                    Dim mvG As Double = BindingContext(Me.DsIngresos1, "Ventas").Current("SubTotalGravada") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                    If Not GuardaAsientoDetalle(mvG, False, True, BuscaCuentaPV("CuentaContable", "IdVentaGrabado"), BuscaCuentaPV("Descripcion", "IdVentaGrabado")) Then
                        Me.incluirListaXContabilizar("Monto Gravado Haber", mvG, False, True)

                    End If
                    '------------------------------------------------------------------
                    Dim mvE As Double = BindingContext(Me.DsIngresos1, "Ventas").Current("SubTotalExento") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA LAS VENTAS EXENTAS
                    If Not GuardaAsientoDetalle(mvE, False, True, BuscaCuentaPV("CuentaContable", "IdVentaExento"), BuscaCuentaPV("Descripcion", "IdVentaExento")) Then
                        Me.incluirListaXContabilizar("Monto Gravado Haber", mvE, False, True)
                    End If
                    '------------------------------------------------------------------
                Else
                    Me.detalleServicios(BindingContext(Me.DsIngresos1, "Ventas").Current("Id"))
                End If

                Dim montoIV As Double = BindingContext(DsIngresos1, "Ventas").Current("Imp_Venta") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                '------------------------------------------------------------------
                'GUARDA ASIENTO DETALLE PARA EL IMPUESTO DE VENTA
                If Not GuardaAsientoDetalle(montoIV, False, True, BuscaCuenta("CuentaContable", "IdImpuestoVenta"), BuscaCuenta("Descripcion", "IdImpuestoVenta")) Then
                    Me.incluirListaXContabilizar("Monto Salonero Haber", montoIV, False, True)

                End If
                '------------------------------------------------------------------

                Dim montoS As Double = BindingContext(DsIngresos1, "Ventas").Current("Monto_Saloero") * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                '------------------------------------------------------------------
                'GUARDA ASIENTO DETALLE PARA EL IMPUESTO DE SERVICIO
                If Not GuardaAsientoDetalle(montoS, False, True, BuscaCuenta("CuentaContable", "IdServicio"), BuscaCuenta("Descripcion", "IdServicio")) Then
                    Me.incluirListaXContabilizar("Monto Salonero Haber", montoS, False, True)

                End If
                '------------------------------------------------------------------

                '------------------------------------------------------------------
                Dim montoTip As Double = Math.Round(BindingContext(DsIngresos1, "Ventas").Current("ExtraPropina"), 2) * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                'GUARDA ASIENTO DETALLE PARA EL EXTRA TIP
                If Not GuardaAsientoDetalle(montoTip, False, True, BuscaCuenta("CuentaContable", "IdPropina"), BuscaCuenta("Descripcion", "IdPropina")) Then
                    Me.incluirListaXContabilizar("Extra tipo Haber", montoTip, False, True)

                End If
                '------------------------------------------------------------------

            Next

            If Me.DiferencialCambiario > 0 Then
                Dim monto As Double = Math.Abs(DiferencialCambiario)
                If Not GuardaAsientoDetalle(monto, False, True, BuscaCuenta("CuentaContable", "IdDiferencial"), BuscaCuenta("Descripcion", "IdDiferencial")) Then
                    Me.incluirListaXContabilizar("Diferencial cambiario Haber", monto, False, True)

                End If
            ElseIf Me.DiferencialCambiario < 0 Then
                Dim monto As Double = Math.Abs(DiferencialCambiario)
                If Not GuardaAsientoDetalle(monto, True, False, BuscaCuenta("CuentaContable", "IdDiferencialGasto"), BuscaCuenta("Descripcion", "IdDiferencialGasto")) Then
                    Me.incluirListaXContabilizar("Diferencial cambiario Debe", monto, True, False)

                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Private Sub spComision(ByVal _Factura As String, ByVal _Monto As Decimal, ByVal _PuntoVenta As Integer)
        Try
            Dim sql As New SqlClient.SqlCommand
            Dim dt As New DataTable

            sql.CommandText = ("select CuentaContable , Descripcion  from contabilidad.dbo.CuentaContable where CuentaContable  =  (select  CuentaContable from tb_FD_CuentaComisionista)")
            cFunciones.Llenar_Tabla_Generico(sql, dt, Configuracion.Claves.Conexion("Hotel"))
            If dt.Rows.Count > 0 Then
                GuardaAsientoDetalle(_Monto, True, False, dt.Rows(0).Item("CuentaContable"), dt.Rows(0).Item("Descripcion"))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub detalleServicios(ByVal Id_Ventas As Integer)
        Dim DrCuentas() As System.Data.DataRow
        Dim DrCuenta As System.Data.DataRow
        DrCuentas = DsIngresos1.Ventas_Detalle.Select("Id_Factura = " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id"))
        Dim ASD As String = Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id")

        If DrCuentas.Length <> 0 Then 'SI EXISTE
            For i As Integer = 0 To DrCuentas.Length - 1
                DrCuenta = DrCuentas(i)

                Dim descripcion As String = DrCuenta("Descripcion")
                If (descripcion.LastIndexOf("PERSONA ADICIONAL") > -1) Or (descripcion.LastIndexOf("ADIC ADULTO") > -1) Or (descripcion.LastIndexOf("ADIC NIÑO") > -1) Then
                    '----------------------------------------------------------------------------
                    'GUARDA EL DETALLE PARA LA CUENTA CONTABLE DEL SERVICIO
                    If DrCuenta("Codigo") = 0 Then
                        Dim monto As Double = Math.Round(Math.Abs(CDbl(DrCuenta("SubTotalGravado")) + CDbl(DrCuenta("SubTotalExcento"))) * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), 2)
                        If Not GuardaAsientoDetalle(monto, False, True, Me.BuscaCuentaHospedaje("CuentaContable", determinaCategoria("ADICIONAL")), BuscaCuentaHospedaje("DescripcionCuenta", determinaCategoria("ADICIONAL"))) Then
                            incluirListaXContabilizar(descripcion, monto, False, True)
                        End If
                    Else
                        Dim monto As Double = Math.Round(Math.Abs(CDbl(DrCuenta("SubTotalGravado")) + CDbl(DrCuenta("SubTotalExcento"))) * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), 2)
                        If Not GuardaAsientoDetalle(monto, False, True, Me.BuscaCuentaHospedaje("CuentaContable", DrCuenta("Codigo")), BuscaCuentaHospedaje("DescripcionCuenta", DrCuenta("Codigo"))) Then
                            incluirListaXContabilizar(descripcion, monto, False, True)
                        End If
                    End If

                    '----------------------------------------------------------------------------

                ElseIf (descripcion.LastIndexOf("NOCHES") > -1) Or (descripcion.LastIndexOf("NOCHE(S)") > -1) Then

                    'BuscaCuentaHospedajeHab
                    Dim monto As Double = Math.Round(Math.Abs(CDbl(DrCuenta("SubTotalGravado")) + CDbl(DrCuenta("SubTotalExcento"))) * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), 2)
                    If Not GuardaAsientoDetalle(monto, False, True, BuscaCuentaHospedaje("CuentaContable", determinaCategoria(descripcion)), BuscaCuentaHospedaje("DescripcionCuenta", determinaCategoria(descripcion))) Then
                        incluirListaXContabilizar(descripcion, monto, False, True)
                    End If
                Else
                    If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "RESTAURANTE" Or Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "BAR" Or Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "SPA" Then
                        '----------------------------------------------------------------------------
                        'GUARDA EL DETALLE PARA LA CUENTA CONTABLE DEL SERVICIO
                        Dim monto As Double = Math.Round(Math.Abs(CDbl(DrCuenta("SubTotal")) - (CDbl(DrCuenta("Monto_Descuento")) * CDbl(DrCuenta("Cantidad")))) * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), 2)
                        If Not GuardaAsientoDetalle(monto, False, True, BuscaCuentaGrupoMenu("CuentaIngreso", DrCuenta("Codigo")), BuscaCuentaGrupoMenu("DescripcionCuentaIngreso", DrCuenta("Codigo"))) Then
                            incluirListaXContabilizar(descripcion, monto, False, True)
                        End If
                        '----------------------------------------------------------------------------
                    Else
                        '----------------------------------------------------------------------------
                        'GUARDA EL DETALLE PARA LA CUENTA CONTABLE DEL SERVICIO
                        If Not GuardaAsientoDetalle(CDbl(DrCuenta("SubTotal")) * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), False, True, BuscaCuentaServicios("CuentaContable", DrCuenta("Codigo"), DrCuenta("Descripcion")), BuscaCuentaServicios("DescripcionCuenta", DrCuenta("Codigo"), DrCuenta("Descripcion"))) Then
                            incluirListaXContabilizar(descripcion, CDbl(DrCuenta("SubTotal")) * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), False, True)

                        End If
                        '----------------------------------------------------------------------------
                    End If

                End If

            Next
        End If
    End Sub
    Sub incluirListaXContabilizar(ByVal Descripcion As String, ByVal monto As Double, ByVal debe As Boolean, ByVal haber As Boolean)

        Try
            If monto > 0 Then
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").EndCurrentEdit()
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").AddNew()
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Descripcion") = Descripcion
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Monto") = monto
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("CuentaAsignada") = ""
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("DescripcionCuenta") = ""
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Haber") = haber
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Debe") = debe
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").EndCurrentEdit()
            End If

        Catch ex As Exception
            MsgBox(ex.ToString(), MsgBoxStyle.OkOnly)
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").CancelCurrentEdit()

        End Try


    End Sub

    Function BuscaCuentaGrupoMenu(ByVal Tipo As String, ByVal Id As Integer) As String
        Dim cConexion As New Conexion
        Try

            BuscaCuentaGrupoMenu = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSoft", DsIngresos1.PuntoVenta(ComboBox1.SelectedIndex).BaseDatos), "SELECT " & Tipo & " FROM Categorias_Menu INNER JOIN  Grupos_Menu ON Categorias_Menu.IdGrupo = Grupos_Menu.Id INNER JOIN  Menu_Restaurante ON Categorias_Menu.Id = Menu_Restaurante.Id_Categoria WHERE (Menu_Restaurante.Id_Menu = " & Id & " )")

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function

    Function determinaCategoria(ByVal Descripcion As String) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * From Tipo_Habitacion", dt, Configuracion.Claves.Conexion("Hotel"))

        For i As Integer = 0 To dt.Rows.Count - 1

            If Descripcion.LastIndexOf(dt.Rows(i).Item("Descripcion")) >= 0 Then
                Return dt.Rows(i).Item("Codigo")

            End If
        Next
        Return dt.Rows(0).Item("Codigo")

    End Function
    Function BuscaCuentaServicios(ByVal Tipo As String, ByVal Id As Integer, ByVal descrip As String) As String
        Dim cConexion As New Conexion
        Dim n As String
        Try
            n = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSoft", "Hotel"), "SELECT Familias." & Tipo & " FROM Familias INNER JOIN Servicios " &
            "ON Familias.Codigo = Servicios.CodigoSubFamilia WHERE Servicios.Codigo = " & Id)
            If n Is Nothing Then
                n = cConexion.SlqExecuteScalar(cConexion.sQlconexion, "SELECT Familias." & Tipo & " FROM Familias INNER JOIN Servicios " &
                            "ON Familias.Codigo = Servicios.CodigoSubFamilia WHERE Servicios.Descripcion = '" & descrip & "'")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
        Return n
    End Function
    Function BuscaCuentaPV(ByVal Tipo As String, ByVal Id As String) As String
        Dim cConexion As New Conexion
        Try

            cConexion.DesConectar(cConexion.sQlconexion)

            BuscaCuentaPV = cConexion.SlqExecuteScalar(cConexion.Conectar("", "Contabilidad"), "SELECT TOP 1 (SELECT " & Tipo & " FROM cuentacontable " &
                                        "WHERE (Id = (SELECT " & Id & " FROM Hotel.dbo.PuntoVenta WHERE IdPuntoVenta = " & Me.ComboBox1.SelectedValue & "))) AS Cuenta FROM CuentaContable")





        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
    Sub cargarOpcionesdePago(ByVal Num_Doc As String, ByVal Fecha As Date)
        Dim BaseDDatos As String = Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).BaseDatos
        Dim consulta As String = " SELECT FormaPago, Documento, id, TipoDocumento, MontoPago, Denominacion, CodMoneda, Nombremoneda, TipoCambio, dbo.DateOnly(Fecha) AS Fecha " &
        " FROM OpcionesDePago " &
        " WHERE     (Documento = '" & Num_Doc & "' ) AND (dbo.DateOnly(Fecha) = CONVERT(DATETIME, '" & Format(Fecha.Year, "00") & "-" & Format(Fecha.Month, "00") & "-" & Format(Fecha.Day, "00") & " 00:00:00', 102))"
        cFunciones.Llenar_Tabla_Generico(consulta, Me.DsIngresos1.OpcionesDePago, Configuracion.Claves.Conexion(BaseDDatos))
    End Sub
    Sub cargarOpcionesdePago_Directo(ByVal Num_Doc As String, ByVal usuario As String)
        Dim BaseDDatos As String = Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).BaseDatos
        Dim Consulta As String
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "TIENDA" Then
            Consulta = " SELECT FormaPago, Documento, id, TipoDocumento, MontoPago, Denominacion, CodMoneda, Nombremoneda, TipoCambio, dbo.DateOnly(Fecha) AS Fecha " &
                    " FROM OpcionesDePago " &
                    " WHERE   (TipoDocumento = 'FVC') AND (Documento = '" & Num_Doc & "' ) AND (Usuario = '" & usuario & "')"

        End If
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "TOUR DESK" Then
            Consulta = " SELECT FormaPago, Documento, id, TipoDocumento, MontoPago, Denominacion, CodMoneda, Nombremoneda, TipoCambio, dbo.DateOnly(Fecha) AS Fecha " &
                                " FROM OpcionesDePago " &
                                " WHERE   (((dbo.DateOnly(Fecha)>'01/10/2010') )AND (TipoDocumento = 'FVT')) AND (Documento = '" & Num_Doc & "') "
        End If
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "FRONT DESK" Then
            Consulta = " SELECT FormaPago, Documento, id, TipoDocumento, MontoPago, Denominacion, CodMoneda, Nombremoneda, TipoCambio, dbo.DateOnly(Fecha) AS Fecha " &
                                " FROM OpcionesDePago " &
                                " WHERE   (TipoDocumento = 'CHF') AND (Documento = '" & Num_Doc & "' )"
        End If
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "RESTAURANTE" Or Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "BAR" Or Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "SPA" Then
            Consulta = " SELECT FormaPago, Documento, id, TipoDocumento, MontoPago, Denominacion, CodMoneda, Nombremoneda, TipoCambio, dbo.DateOnly(Fecha) AS Fecha " &
                                " FROM OpcionesDePago " &
                                " WHERE  (Documento = '" & Num_Doc & "' )"
        End If
        cFunciones.Llenar_Tabla_Generico(Consulta, Me.DsIngresos1.OpcionesDePago, Configuracion.Claves.Conexion(BaseDDatos))
    End Sub

    Sub cargarDetalle_pago(ByVal Id_Opcion As Integer)
        Dim BaseDDatos As String = Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).BaseDatos
        Dim consulta As String = "SELECT *  FROM Detalle_pago_caja WHERE (Id_ODP = " & Id_Opcion & ")"
        cFunciones.Llenar_Tabla_Generico(consulta, Me.DsIngresos1.Detalle_pago_caja, Configuracion.Claves.Conexion(BaseDDatos))

    End Sub
    Sub evaluarCheckOuts()
        Dim MontoE As Double = 0
        Dim totalPagado As Double = 0
        Dim totalFactura As Double = 0
        'CARGAR EL CHECK OUT DE LA FACTURA
        Dim dtCheckOut As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT Check_Out.*, Cuentas.MontoPrepago AS Prepago FROM Check_Out " &
        "INNER JOIN  DetalleCheckOut ON Check_Out.Id = DetalleCheckOut.Id_Check_Out INNER JOIN  Cuentas ON Check_Out.Id_Cuenta = Cuentas.Id " &
        " WHERE (DetalleCheckOut.Id_Ventas = " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id") & ")",
        dtCheckOut, Configuracion.Claves.Conexion("Hotel"))

        If dtCheckOut.Rows.Count > 0 Then
            totalFactura = (dtCheckOut.Rows(0).Item("Total") + dtCheckOut.Rows(0).Item("Prepago")) * dtCheckOut.Rows(0).Item("Tipo_Cambio")
            Dim dtDetalleCheckOut As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT DetalleCheckOut.Id_Check_Out, Ventas.Id, Ventas.Num_Factura, Ventas.Tipo, Ventas.Orden, Ventas.Cedula_Usuario, Ventas.Total, Ventas.Tipo_Cambio FROM DetalleCheckOut INNER JOIN  Ventas ON DetalleCheckOut.Id_Ventas = Ventas.Id WHERE (DetalleCheckOut.Id_Ventas <> " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id") & ") " &
            "AND (DetalleCheckOut.Id_Check_Out = " & dtCheckOut.Rows(0).Item(0) & ")", dtDetalleCheckOut, Configuracion.Claves.Conexion("Hotel"))
            If dtDetalleCheckOut.Rows.Count > 0 Then
                For i As Integer = 0 To dtDetalleCheckOut.Rows.Count - 1

                    Dim monto_adicional As Double = dtDetalleCheckOut.Rows(i).Item("Total") * dtDetalleCheckOut.Rows(i).Item("Tipo_Cambio")
                    Dim monto_adic_actual As Double = dtDetalleCheckOut.Rows(i).Item("Total") * dtCheckOut.Rows(i).Item("Tipo_Cambio")
                    '------------------------------------------------------------------
                    'GUARDA ASIENTO DETALLE PARA EL TOTAL CARGO A HABITACION
                    If Not GuardaAsientoDetalle(monto_adicional, False, True, BuscaCuenta("CuentaContable", "IdCxCHabitacion"), BuscaCuenta("Descripcion", "IdCxCHabitacion")) Then
                        Me.incluirListaXContabilizar("Monto cargo habitacion (Haber)", monto_adicional, False, True)

                    End If
                    '------------------------------------------------------------------

                    ''EVALUA DIFERENCIAL CAMBIARIO
                    'Dim dif As Double = monto_adic_actual - monto_adicional
                    'If dif > 0 Then
                    '    GuardaAsientoDetalle(Math.Abs(dif), False, True, BuscaCuenta("CuentaContable", "IdDiferencial"), BuscaCuenta("Descripcion", "IdDiferencial"))
                    'ElseIf dif <> 0 Then
                    '    GuardaAsientoDetalle(Math.Abs(dif), True, False, BuscaCuenta("CuentaContable", "IdDiferencialGasto"), BuscaCuenta("Descripcion", "IdDiferencialGasto"))
                    'End If


                Next

            End If
            Dim fecha As Date = Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Fecha")
            cFunciones.Llenar_Tabla_Generico("SELECT FormaPago, Documento, id, TipoDocumento, MontoPago, Denominacion, CodMoneda, Nombremoneda, TipoCambio, dbo.DateOnly(Fecha) AS Fecha, Cod_MonedaCompra FROM OpcionesDePago " &
            " WHERE     (Documento = '" & BindingContext(DsIngresos1, "Ventas").Current("Num_Factura") & "' ) AND (dbo.DateOnly(Fecha) = CONVERT(DATETIME, '" & Format(fecha.Year, "00") & "-" & Format(fecha.Month, "00") & "-" & Format(fecha.Day, "00") & " 00:00:00', 102))",
                Me.DsIngresos1.OpcionesDePago, Configuracion.Claves.Conexion("Hotel"))


            For i As Integer = 0 To DsIngresos1.OpcionesDePago.Count - 1
                If DsIngresos1.OpcionesDePago(i).FormaPago = "TAR" Then
                    '------------------------------------------------------------------
                    'BUSCA LO PAGADO CON TARJETA

                    cargarDetalle_pago(DsIngresos1.OpcionesDePago(i).id)

                    For x As Integer = 0 To DsIngresos1.Detalle_pago_caja.Count - 1
                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL SUBTOTAL DE TARJETA
                        If Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = DsIngresos1.OpcionesDePago(i).CodMoneda Then

                            Dim m As Double = DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                            totalPagado += m
                            If Not GuardaAsientoDetalle(m, True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then
                                Me.incluirListaXContabilizar("Monto tarjeta (Debe)", m, True, False)
                            End If
                        ElseIf Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = 1 Then
                            Dim m As Double = (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar"))
                            totalPagado += m
                            If Not GuardaAsientoDetalle(m, True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then
                                Me.incluirListaXContabilizar("Monto tarjeta (Debe)", m, True, False)
                            End If
                        Else
                            totalPagado += DsIngresos1.OpcionesDePago(i).MontoPago '* BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")
                            Dim m As Double = (DsIngresos1.OpcionesDePago(i).MontoPago)
                            If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago), True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then
                                Me.incluirListaXContabilizar("Monto tarjeta (Debe)", m, True, False)
                            End If
                        End If
                        '------------------------------------------------------------------

                    Next

                Else
                    '------------------------------------------------------------------
                    'BUSCA LO PAGADO CON EFECTIVO Y CHEQUE
                    If Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = DsIngresos1.OpcionesDePago(i).CodMoneda Then
                        MontoE += DsIngresos1.OpcionesDePago(i).MontoPago * DsIngresos1.OpcionesDePago(i).TipoCambio

                    ElseIf Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = 1 Then
                        MontoE += (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar"))
                    Else
                        MontoE += (DsIngresos1.OpcionesDePago(i).MontoPago)
                    End If
                    '------------------------------------------------------------------
                End If

            Next
            '------------------------------------------------------------------
            'GUARDA ASIENTO DETALLE PARA EL SUBTOTAL DE CAJA
            If Not GuardaAsientoDetalle(MontoE, True, False, BuscaCuenta("CuentaContable", "IdCaja"), BuscaCuenta("Descripcion", "IdCaja")) Then
                Me.incluirListaXContabilizar("Monto de efectivo (Debe)", MontoE, True, False)

            End If
            '------------------------------------------------------------------
            totalPagado += MontoE

            Dim montoPrepago As Double = 0
            Dim diferenciaMonto As Double = totalFactura - totalPagado
            If diferenciaMonto <> 0 Then

                If BindingContext(DsIngresos1, "Ventas").Current("Id_Reservacion") <> 0 Then

                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select MontoPrepago,Id_Reservacion From Cuentas Where Id = " & BindingContext(DsIngresos1, "Ventas").Current("Id_Reservacion"), dt, Configuracion.Claves.Conexion("Hotel"))

                    If dt.Rows.Count > 0 Then
                        montoPrepago = dt.Rows(0).Item("MontoPrepago")
                        If montoPrepago > 0 Then
                            'Busca ingreso del prepago
                            Dim dtPrepago As New DataTable
                            cFunciones.Llenar_Tabla_Generico("Select * From Prepagos Where Id_Reservacion = " & dt.Rows(0).Item("Id_Reservacion"), dtPrepago, Configuracion.Claves.Conexion("Hotel"))
                            montoPrepago = 0
                            For i As Integer = 0 To dtPrepago.Rows.Count - 1

                                'Busca la opcion de pago del prepago
                                Dim dtOpcionPago As New DataTable
                                cFunciones.Llenar_Tabla_Generico("SELECT MontoPago, TipoCambio FROM OpcionesDePago WHERE (TipoDocumento = 'PRE') AND (Documento = " & dtPrepago.Rows(i).Item("Id") & ")", dtOpcionPago, Configuracion.Claves.Conexion("Hotel"))
                                If dtOpcionPago.Rows.Count > 0 Then
                                    For j As Integer = 0 To dtOpcionPago.Rows.Count - 1
                                        montoPrepago += CDbl(dtOpcionPago.Rows(j).Item("MontoPago")) * CDbl(dtOpcionPago.Rows(j).Item("TipoCambio"))
                                    Next
                                Else


                                    Dim dtDeposito As New DataTable
                                    'Busca el deposito en bancos
                                    cFunciones.Llenar_Tabla_Generico("SELECT Monto, TipoCambio, CodigoMoneda FROM Deposito WHERE (Id_Deposito = " & dtPrepago.Rows(i).Item("Id_Deposito") & ")", dtDeposito, Configuracion.Claves.Conexion("Bancos"))
                                    If dtDeposito.Rows.Count > 0 Then
                                        If dtDeposito.Rows(0).Item("CodigoMoneda") = 2 Then
                                            montoPrepago += CDbl(dtDeposito.Rows(0).Item("Monto")) * CDbl(dtDeposito.Rows(0).Item("TipoCambio"))
                                        Else
                                            montoPrepago += CDbl(dtDeposito.Rows(0).Item("Monto"))
                                        End If

                                    End If

                                End If
                            Next
                            Dim dtPrepagoEstadoCuenta As New DataTable
                            cFunciones.Llenar_Tabla_Generico("SELECT MontoPago, TipoCambio, CodMoneda FROM OpcionesDePago WHERE (TipoDocumento = 'PRE') AND (Documento = " & dtCheckOut.Rows(0).Item("Id_Cuenta") & ")", dtPrepagoEstadoCuenta, Configuracion.Claves.Conexion("Hotel"))
                            If dtPrepagoEstadoCuenta.Rows.Count > 0 Then
                                For j As Integer = 0 To dtPrepagoEstadoCuenta.Rows.Count - 1
                                    If dtPrepagoEstadoCuenta.Rows(j).Item("CodMoneda") = 2 Then
                                        montoPrepago += CDbl(dtPrepagoEstadoCuenta.Rows(j).Item("MontoPago")) * CDbl(dtPrepagoEstadoCuenta.Rows(j).Item("TipoCambio"))
                                    Else
                                        montoPrepago += CDbl(dtPrepagoEstadoCuenta.Rows(j).Item("MontoPago"))
                                    End If

                                Next
                            End If

                        End If

                    End If

                End If

            End If
            Dim difTipoCambio As Double = diferenciaMonto - montoPrepago

            If montoPrepago > 0 Then

                Me.DiferencialCambiario += difTipoCambio
                If Not GuardaAsientoDetalle(montoPrepago, True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                    Me.incluirListaXContabilizar("Monto de prepago (Debe)", montoPrepago, True, False)
                End If


            End If


        End If


    End Sub
    Private Sub DetallesContado()
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "FRONT DESK" Then
            evaluarCheckOuts()
            Exit Sub
        End If
        Dim MontoE As Double = 0
        Dim montoTarj As Double = 0
        Dim montoTRA As Double = 0
        Dim montoCOM As Double = 0
        Try
            cargarOpcionesdePago_Directo(Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Num_Factura"), Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cedula_Usuario")) ', Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Num_Apertura"))

            For i As Integer = 0 To DsIngresos1.OpcionesDePago.Count - 1
                If DsIngresos1.OpcionesDePago(i).FormaPago = "TAR" Then
                    '------------------------------------------------------------------
                    'BUSCA LO PAGADO CON TARJETA

                    cargarDetalle_pago(DsIngresos1.OpcionesDePago(i).id)

                    For x As Integer = 0 To DsIngresos1.Detalle_pago_caja.Count - 1
                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL SUBTOTAL DE TARJETA
                        If Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = DsIngresos1.OpcionesDePago(i).CodMoneda Then


                            If Not GuardaAsientoDetalle(DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then

                                Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), True, False)

                            End If
                            montoTarj = 1
                        ElseIf Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = 1 Then
                            If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar")), True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then

                                Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar")), True, False)

                            End If
                            montoTarj = 1
                        Else
                            If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago), True, False, BuscaCuentaTarjeta("CuentaCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo), BuscaCuentaTarjeta("NombreCXC", DsIngresos1.Detalle_pago_caja(x).ReferenciaTipo)) Then

                                Me.incluirListaXContabilizar("Error enviado la cuenta de cxc (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, (DsIngresos1.OpcionesDePago(i).MontoPago), True, False)

                            End If
                            montoTarj = 1
                        End If
                        '------------------------------------------------------------------

                    Next
                ElseIf DsIngresos1.OpcionesDePago(i).FormaPago = "TRA" Then
                    '------------------------------------------------------------------
                    'BUSCA LO PAGADO CON TRANSFERENCIA

                    cargarDetalle_pago(DsIngresos1.OpcionesDePago(i).id)

                    For x As Integer = 0 To DsIngresos1.Detalle_pago_caja.Count - 1
                        '------------------------------------------------------------------
                        'GUARDA ASIENTO DETALLE PARA EL TRANSFERENCIA
                        If Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = DsIngresos1.OpcionesDePago(i).CodMoneda Then

                            If Not GuardaAsientoDetalle(DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                Me.incluirListaXContabilizar("Error enviado la cuenta de bancos (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio"), True, False)

                            End If
                            montoTRA = 1
                        ElseIf Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = 1 Then
                            If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar")), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then

                                Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar")), True, False)
                            End If
                            montoTRA = 1
                        Else
                            If Not GuardaAsientoDetalle((DsIngresos1.OpcionesDePago(i).MontoPago), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) Doc:" & DsIngresos1.OpcionesDePago(i).Documento, (DsIngresos1.OpcionesDePago(i).MontoPago), True, False)
                            End If
                            montoTRA = 1
                        End If
                        '------------------------------------------------------------------

                    Next
                Else
                    '------------------------------------------------------------------
                    'BUSCA LO PAGADO CON EFECTIVO Y CHEQUE
                    If DsIngresos1.OpcionesDePago(i).FormaPago = "EFE" Then
                        If Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = DsIngresos1.OpcionesDePago(i).CodMoneda Then
                            MontoE += DsIngresos1.OpcionesDePago(i).MontoPago * DsIngresos1.OpcionesDePago(i).TipoCambio

                        ElseIf Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = 1 Then
                            MontoE += (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar"))
                        Else
                            MontoE += (DsIngresos1.OpcionesDePago(i).MontoPago)
                        End If
                    End If
                    If DsIngresos1.OpcionesDePago(i).FormaPago = "COM" Then
                        If Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = DsIngresos1.OpcionesDePago(i).CodMoneda Then
                            MontoE -= DsIngresos1.OpcionesDePago(i).MontoPago * DsIngresos1.OpcionesDePago(i).TipoCambio
                            montoCOM += DsIngresos1.OpcionesDePago(i).MontoPago * DsIngresos1.OpcionesDePago(i).TipoCambio

                        ElseIf Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Cod_Moneda") = 1 Then
                            MontoE -= (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar"))
                            montoCOM += (DsIngresos1.OpcionesDePago(i).MontoPago * BindingContext(Me.DsIngresos1, "Ventas").Current("TipoCambioDolar"))

                        Else
                            MontoE -= (DsIngresos1.OpcionesDePago(i).MontoPago)
                            montoCOM += (DsIngresos1.OpcionesDePago(i).MontoPago)
                        End If
                    End If

                    '------------------------------------------------------------------
                End If
            Next

            If montoCOM > 0 Then
                spComision(BindingContext(DsIngresos1, "Ventas").Current("Num_Factura"), montoCOM, ComboBox1.SelectedValue)
            End If

            '------------------------------------------------------------------
            'GUARDA ASIENTO DETALLE PARA EL SUBTOTAL DE CAJA
            If Not GuardaAsientoDetalle(MontoE, True, False, BuscaCuenta("CuentaContable", "IdCaja"), BuscaCuenta("Descripcion", "IdCaja")) Then
                'If MsgBox("Error enviado la cuenta de tarjetas (Debe) ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                '    End
                'End If
                Me.incluirListaXContabilizar("Error enviado la cuenta de tarjetas (Debe) ", MontoE, True, False)
            End If
            '------------------------------------------------------------------
            If montoTarj = 0 And MontoE = 0 And montoTRA = 0 Then
                'BUSCA PREPAGO
                Dim dtPrepago As New DataTable
                cFunciones.Llenar_Tabla_Generico("SELECT Id_Reservacion, Fecha, ISNULL(Id_Deposito,0) AS Id_Deposito, ISNULL(PrepagoGrupo,0) AS PrepagoGrupo, Monto FROM Prepagos WHERE (Id_Reservacion = " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id_Reservacion") & ")", dtPrepago, Configuracion.Claves.Conexion("Hotel"))
                If dtPrepago.Rows.Count = 0 Then

                End If
                For j As Integer = 0 To dtPrepago.Rows.Count - 1
                    If dtPrepago.Rows(j).Item("Id_Deposito") > 0 Then
                        Dim dtDeposito As New DataTable
                        'Busca el deposito en bancos
                        cFunciones.Llenar_Tabla_Generico("SELECT Monto,TipoCambio, CodigoMoneda FROM Deposito WHERE (Id_Deposito = " & dtPrepago.Rows(j).Item("Id_Deposito") & ")", dtDeposito, Configuracion.Claves.Conexion("Bancos"))
                        If dtDeposito.Rows.Count > 0 Then
                            If (dtDeposito.Rows(0).Item("Monto") - dtPrepago.Rows(j).Item("Monto")) < 100 Then
                                Dim cf As New cFunciones

                                Dim tipoC_eseDia As Double = cf.TipoCambio(dtPrepago.Rows(j).Item("Fecha"))
                                Dim montoC_Dep As Double = dtDeposito.Rows(0).Item("Monto") * tipoC_eseDia
                                Dim montoNCheck As Double = dtDeposito.Rows(0).Item("Monto") * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")

                                Dim dif As Double = montoNCheck - montoC_Dep
                                If Not GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                    Me.incluirListaXContabilizar("Error enviado la cuenta del banco (Debe) ", Math.Round(montoC_Dep, 2), True, False)

                                End If
                            Else
                                If dtDeposito.Rows(0).Item("CodigoMoneda") = 2 Then

                                    Dim montoC_Dep As Double = dtDeposito.Rows(0).Item("Monto") * dtDeposito.Rows(0).Item("TipoCambio")
                                    If Not GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                        Me.incluirListaXContabilizar("Error enviado la cuenta del banco (Debe) ", Math.Round(montoC_Dep, 2), True, False)
                                    End If

                                Else
                                    If Not GuardaAsientoDetalle(Math.Round(CDbl(dtDeposito.Rows(0).Item("Monto")), 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then

                                        Me.incluirListaXContabilizar("Error enviado la cuenta del banco (Debe) ", Math.Round(CDbl(dtDeposito.Rows(0).Item("Monto")), 2), True, False)

                                    End If

                                End If

                            End If


                        End If
                    Else
                        'EVALUA LOS PREPAGOS EN EFECTIVO O TARJETA
                        cFunciones.Llenar_Tabla_Generico("Select * From OpcionesDePago WHERE (Documento = " & Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Id_Cuenta") & ") AND FormaPago = 'PRE'", DsIngresos1.OpcionesDePago, Configuracion.Claves.Conexion(DsIngresos1.PuntoVenta(ComboBox1.SelectedIndex).BaseDatos))
                        If DsIngresos1.OpcionesDePago.Count > 0 Then
                            For i As Integer = 0 To DsIngresos1.OpcionesDePago.Count - 1
                                If DsIngresos1.OpcionesDePago(i).CodMoneda = 2 Then
                                    Dim montoC_Dep As Double = DsIngresos1.OpcionesDePago(i).MontoPago * DsIngresos1.OpcionesDePago(i).TipoCambio

                                    If Not GuardaAsientoDetalle(Math.Round(montoC_Dep, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                        Me.incluirListaXContabilizar("Error enviado la prepagos cuenta del banco (Debe) ", Math.Round(montoC_Dep, 2), True, False)

                                    End If
                                Else
                                    If Not GuardaAsientoDetalle(Math.Round(DsIngresos1.OpcionesDePago(i).MontoPago, 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                        Me.incluirListaXContabilizar("Error enviado la prepagos cuenta del banco (Debe) ", Math.Round(DsIngresos1.OpcionesDePago(i).MontoPago, 2), True, False)

                                    End If

                                End If

                            Next
                        Else
                            'If dtCheckOut.Rows(pos).Item("Proveniencia_Venta") = 1 Then
                            If Not GuardaAsientoDetalle(Math.Round(CDbl(Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Total") * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")), 2), True, False, BuscaCuenta("CuentaContable", "IdPrepagoCol"), BuscaCuenta("Descripcion", "IdPrepagoCol")) Then
                                Me.incluirListaXContabilizar("Error enviado la prepagos cuenta del banco (Debe) ", Math.Round(CDbl(Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Total") * Me.BindingContext(Me.DsIngresos1, "Ventas").Current("Tipo_Cambio")), 2), True, False)
                            End If
                            'NO ENCONTRO EL DEPOSITO BANCARIO MEJOR SE SALE.
                            Exit Sub
                        End If

                    End If
                Next

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Function BuscaCuentaHospedaje(ByVal Tipo As String, ByVal Id As Integer) As String
        Dim cConexion As New Conexion   'BUSCA LA CUENTA CONTABLE O DESCRIPCION DE LA CUENTA PARA EL HOSPEDAJE
        Try
            BuscaCuentaHospedaje = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSoft", "Hotel"), "SELECT " & Tipo & " FROM Tipo_Habitacion WHERE Codigo = " & Id)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
    Function BuscaCuentaHospedajeHab(ByVal Tipo As String, ByVal Id As Integer) As String
        Dim cConexion As New Conexion   'BUSCA LA CUENTA CONTABLE O DESCRIPCION DE LA CUENTA PARA EL HOSPEDAJE
        Dim BuscaCuentaHospedajeHabi As String = ""
        Dim codigoFamilia As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select CodigoHabitacion From Habitacion1 Where Codigo = " & Id, dt, Configuracion.Claves.Conexion("Hotel"))
        If dt.Rows.Count > 0 Then
            codigoFamilia = dt.Rows(0).Item("CodigoHabitacion")

        End If
        Try
            BuscaCuentaHospedajeHabi = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSoft", "Hotel"), "SELECT " & Tipo & " FROM Tipo_Habitacion WHERE Codigo = " & codigoFamilia)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
        Return BuscaCuentaHospedajeHabi
    End Function

    Function BuscaCuenta(ByVal Tipo As String, ByVal Id As String) As String
        Dim cConexion As New Conexion
        Try
            cConexion.DesConectar(cConexion.sQlconexion)
            BuscaCuenta = cConexion.SlqExecuteScalar(cConexion.Conectar("", "Contabilidad"), "SELECT TOP 1 (SELECT " & Tipo & " FROM cuentacontable " & _
                            "WHERE (Id = (SELECT " & Id & " FROM settingcuentacontable))) AS Cuenta FROM CuentaContable")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
    Function engrosarlacuenta(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        Try

            For i As Integer = 0 To Me.DsIngresos1.DetallesAsientosContable.Count - 1

                If Me.DsIngresos1.DetallesAsientosContable(i).Cuenta = Cuenta And Me.DsIngresos1.DetallesAsientosContable(i).Debe = Debe And Me.DsIngresos1.DetallesAsientosContable(i).Haber = Haber Then
                    Me.DsIngresos1.DetallesAsientosContable(i).Monto += Monto
                    Return True
                End If

            Next
            Return False
        Catch ex As Exception
            ' MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
    Public Function GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        Try
            If Monto <> 0 And (Not Cuenta.Equals("0")) And (Not Cuenta.Equals("")) Then

                If engrosarlacuenta(Monto, Debe, Haber, Cuenta, NombreCuenta) Then

                    Return True
                End If
                'CREA LOS DETALLES DE ASIENTOS CONTABLES
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Tipocambio") = TipoCambio
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()

            End If
        Catch ex As System.Exception
            'MsgBox("ERROR A INCLUIR DATO: " & ex.ToString, MsgBoxStyle.Information, "Atención...")
            BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").CancelCurrentEdit()
            Return False
        End Try
        Return True
    End Function

#End Region

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
                ToolBarNuevo.Enabled = True
                NUEVO()
                dtpFechaInicio.Focus()
            End If
        End If
    End Sub

    Private Sub btnGenerarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarVenta.Click
        Me.asientoCosto = False
        generarAsientosVenta()

    End Sub

    Sub generarAsientosVenta()

        DsIngresos1.DetallesAsientosContable.Clear()
        DsIngresos1.AsientosContables.Clear()

        If buscarFacturas() Then
            GenerarAsiento()
        Else
            MsgBox("No hay documentos que contabilizar o ya todos estan contabilizados", MsgBoxStyle.OkOnly)

        End If


    End Sub

    Function BuscaCuentaTarjeta(ByVal Tipo As String, ByVal Id As Integer) As String
        Dim cConexion As New Conexion
        Try
            cConexion.DesConectar(cConexion.sQlconexion)
            BuscaCuentaTarjeta = cConexion.SlqExecuteScalar(cConexion.Conectar("", "Hotel"), "SELECT " & Tipo & " FROM TipoTarjeta WHERE Id = " & Id)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function

    Function BuscaCuentaTransferencia(ByVal Tipo As String, ByVal Cuenta As String) As String
        Dim cConexion As New Conexion
        Try
            cConexion.DesConectar(cConexion.sQlconexion)
            BuscaCuentaTransferencia = cConexion.SlqExecuteScalar(cConexion.Conectar("", "Bancos"), "SELECT " & Tipo & " FROM Cuentas_Bancarias WHERE Cuenta = '" & Cuenta & "'")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function

    Function buscarFacturas() As Boolean

        'Busca Check Outs si es Front Desk
        Dim dt_Datos As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Cedula From configuraciones", dt_Datos, Configuracion.Claves.Conexion("Hotel"))

        If dt_Datos.Rows.Count > 0 Then
            ced = dt_Datos.Rows(0).Item(0)
        End If
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "FRONT DESK" And Not ced.Equals("3-101-188056") Then
            Dim dtCheckOuts As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT Check_Out.Id, Check_Out.Codigo, Check_Out.Total, Check_Out.Cod_Moneda, Check_Out.Tipo_Cambio, Cuentas.Total AS Total_Cuentas,  Cuentas.MontoPrepago, Cuentas.Id_Reservacion FROM Check_Out INNER JOIN  Cuentas ON Check_Out.Id_Cuenta = Cuentas.Id " & _
            " WHERE  Asiento= '0' AND " & _
            " (dbo.DateOnly(Check_Out.Fecha) >= CONVERT(DATETIME, '" & Me.dtpFechaInicio.Value.Year & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) ) " & _
            " AND (dbo.DateOnly(Check_Out.Fecha)  <= CONVERT(DATETIME, '" & Me.dtpFechaFinal.Value.Year & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102)) ", _
            dtCheckOuts, Configuracion.Claves.Conexion("Hotel"))
            If dtCheckOuts.Rows.Count > 0 Then
                Return True

            Else
                Return False

            End If
        End If

        If Not asientoCosto Or ced.Equals("3-101-188056") Then
            Dim consulta As String = " WHERE     (Contabilizado = 0) AND (Anulado = 0) AND (dbo.DateOnly(Fecha) >= CONVERT(DATETIME, '" & Format(Me.dtpFechaInicio.Value.Year, "00") & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) AND dbo.DateOnly(Fecha) <= CONVERT(DATETIME, " & _
                    " '" & Format(Me.dtpFechaFinal.Value.Year, "00") & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102)) AND (Proveniencia_Venta = " & Me.ComboBox1.SelectedValue & ")"

            cFunciones.Llenar_Tabla_Generico("Select * From Ventas" & consulta, Me.DsIngresos1.Ventas, Configuracion.Claves.Conexion("Hotel"))

            consulta = "SELECT Ventas_Detalle.* FROM Ventas INNER JOIN Ventas_Detalle ON Ventas.Id = Ventas_Detalle.Id_Factura" & _
                        " WHERE (Ventas.Contabilizado = 0) AND (Ventas.Anulado = 0) AND (Ventas.Proveniencia_Venta = " & Me.ComboBox1.SelectedValue & ") AND (dbo.DateOnly(Ventas.Fecha) >= CONVERT(DATETIME, '" & Format(Me.dtpFechaInicio.Value.Year, "00") & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) AND dbo.DateOnly(Ventas.Fecha) <= CONVERT(DATETIME, '" & Format(Me.dtpFechaFinal.Value.Year, "00") & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102))"

            cFunciones.Llenar_Tabla_Generico(consulta, Me.DsIngresos1.Ventas_Detalle, Configuracion.Claves.Conexion("Hotel"))
        Else
            Dim consulta As String = " WHERE     (ContabilizadoCVenta = 0) AND (Anulado = 0) AND (dbo.DateOnly(Fecha) >= CONVERT(DATETIME, '" & Format(Me.dtpFechaInicio.Value.Year, "00") & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) AND dbo.DateOnly(Fecha) <= CONVERT(DATETIME, " & _
        " '" & Format(Me.dtpFechaFinal.Value.Year, "00") & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102)) AND (Proveniencia_Venta = " & Me.ComboBox1.SelectedValue & ")"

            cFunciones.Llenar_Tabla_Generico("Select * From Ventas" & consulta, Me.DsIngresos1.Ventas, Configuracion.Claves.Conexion("Hotel"))

            consulta = "SELECT Ventas_Detalle.* FROM Ventas INNER JOIN Ventas_Detalle ON Ventas.Id = Ventas_Detalle.Id_Factura" & _
                        " WHERE (Ventas.ContabilizadoCVenta = 0) AND (Ventas.Anulado = 0) AND (Ventas.Proveniencia_Venta = " & Me.ComboBox1.SelectedValue & ") AND (dbo.DateOnly(Ventas.Fecha) >= CONVERT(DATETIME, '" & Format(Me.dtpFechaInicio.Value.Year, "00") & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) AND dbo.DateOnly(Ventas.Fecha) <= CONVERT(DATETIME, '" & Format(Me.dtpFechaFinal.Value.Year, "00") & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102))"

            cFunciones.Llenar_Tabla_Generico(consulta, Me.DsIngresos1.Ventas_Detalle, Configuracion.Claves.Conexion("Hotel"))
        End If


        If Me.DsIngresos1.Ventas.Count = 0 Then


            MsgBox("No hay facturas pendientes de contabilizar", MsgBoxStyle.OkOnly)
            Return False

        End If

        Return True

    End Function

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        imprimirDatos()
    End Sub
    Sub cargarDatos()
        Me.btnDetalle.Enabled = False
        Me.btnDetalle.Text = "CARGANDO..."

        Dim where As String = " WHERE "
        cFunciones.Llenar_Tabla_Generico("SELECT  Check_Out.Id,Cuentas.Nombre, Check_Out.Total AS TotalPago, Check_Out.Tipo_Cambio AS TipoCambio, Cuentas.MontoPrepago AS TotalPrepago, Check_Out.Fecha, " & _
                      " 0 AS TotalFront, 0 AS TotalAdicionales, 0 AS TotalEfectivo, 0 AS TotalTarjeta, 0 AS TotalOtros, 0 AS TotalCredito FROM Check_Out INNER JOIN  Cuentas ON Check_Out.Id_Cuenta = Cuentas.Id " & _
                    " WHERE  Asiento= '0' AND " & _
                    " (dbo.DateOnly(Check_Out.Fecha) >= CONVERT(DATETIME, '" & Me.dtpFechaInicio.Value.Year & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) ) " & _
                    " AND (dbo.DateOnly(Check_Out.Fecha)  <= CONVERT(DATETIME, '" & Me.dtpFechaFinal.Value.Year & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102)) ", _
                    Me.DsIngresos1.CheckOut, Configuracion.Claves.Conexion("Hotel"))

        For i As Integer = 0 To Me.DsIngresos1.CheckOut.Count - 1

            Dim dt As New DataTable

            cFunciones.Llenar_Tabla_Generico("SELECT CodMoneda, MontoPago, TipoCambio, FormaPago " & _
            " FROM OpcionesDePago " & _
            " WHERE     (TipoDocumento = 'CHF') AND (Documento = " & DsIngresos1.CheckOut(i).Id & ") AND (dbo.DateOnly(Fecha) = '" & Format(DsIngresos1.CheckOut(i).Fecha, "dd/MM/yyyy") & "')", dt, _
            Configuracion.Claves.Conexion("Hotel"))

            ' DsIngresos1.CheckOut(i).TotalPrepago = DsIngresos1.CheckOut(i).TotalPrepago * DsIngresos1.CheckOut(i).TipoCambio
            DsIngresos1.CheckOut(i).TotalPago = DsIngresos1.CheckOut(i).TotalPago * DsIngresos1.CheckOut(i).TipoCambio

            Dim sumaEfec As Double = 0
            Dim sumaTar As Double = 0
            Dim sumaOtros As Double = 0
            If dt.Rows.Count > 0 Then


                For i2 As Integer = 0 To dt.Rows.Count - 1
                    Dim tc1 As Double = 1
                    If dt.Rows(i2).Item("CodMoneda") = 2 Then
                        tc1 = dt.Rows(i2).Item("TipoCambio")
                    End If
                    If dt.Rows(i2).Item("FormaPago") = "EFE" Then
                        sumaEfec += dt.Rows(i2).Item("MontoPago") * tc1
                    ElseIf dt.Rows(i2).Item("FormaPago") = "TAR" Then

                        sumaTar += dt.Rows(i2).Item("MontoPago") * tc1
                    Else
                        sumaOtros += dt.Rows(i2).Item("MontoPago") * tc1
                    End If


                Next

            End If
            Me.DsIngresos1.CheckOut(i).TotalEfectivo = sumaEfec
            Me.DsIngresos1.CheckOut(i).TotalTarjeta = sumaTar
            Me.DsIngresos1.CheckOut(i).TotalOtros = sumaOtros

            cFunciones.Llenar_Tabla_Generico("SELECT Ventas.Nombre_Cliente,Ventas.Fecha, Ventas.Num_Factura, Ventas.Total, Ventas.Tipo, Ventas.Tipo_Cambio, DetalleCheckOut.Id_Check_Out, Ventas.Proveniencia_Venta as PV" & _
            " FROM DetalleCheckOut INNER JOIN" & _
                                  " Ventas ON DetalleCheckOut.Id_Ventas = Ventas.Id WHERE Ventas.Anulado = 0 AND DetalleCheckOut.Id_Check_Out = " & DsIngresos1.CheckOut(i).Id, dt, _
            Configuracion.Claves.Conexion("Hotel"))
            If i = 0 Then
                where &= " (DetalleCheckOut.Id_Check_Out = " & DsIngresos1.CheckOut(i).Id & ") "
            Else
                where &= " OR (DetalleCheckOut.Id_Check_Out = " & DsIngresos1.CheckOut(i).Id & ") "
            End If


            If dt.Rows.Count > 0 Then
                For i2 As Integer = 0 To dt.Rows.Count - 1
                    sumaEfec = 0
                    sumaTar = 0
                    sumaOtros = 0
                    If dt.Rows(i2).Item("PV") = 1 Then

                        If dt.Rows(i2).Item("Tipo") = "CRE" Then
                            Me.DsIngresos1.CheckOut(i).TotalCredito = Me.DsIngresos1.CheckOut(i).TotalPago '* Me.DsIngresos1.CheckOut(i).TipoCambio  ' dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")
                        Else
                            Dim dt_Op As New DataTable

                            cFunciones.Llenar_Tabla_Generico("SELECT CodMoneda, MontoPago, TipoCambio, FormaPago" & _
                            " FROM OpcionesDePago " & _
                            " WHERE     ( TipoDocumento = 'CHF' )AND (Documento = " & dt.Rows(i2).Item("Num_Factura") & ") AND (Fecha = '" & Format(dt.Rows(i2).Item("Fecha"), "dd/MM/yyyy") & "' )", dt_Op, _
                            Configuracion.Claves.Conexion("Hotel"))

                            If dt_Op.Rows.Count > 0 Then

                                For i3 As Integer = 0 To dt_Op.Rows.Count - 1
                                    Dim tc As Double = 1
                                    If dt_Op.Rows(i3).Item("CodMoneda") = 2 Then
                                        tc = dt_Op.Rows(i3).Item("TipoCambio")
                                    End If
                                    If dt_Op.Rows(i3).Item("FormaPago") = "EFE" Then
                                        sumaEfec += dt_Op.Rows(i3).Item("MontoPago") * tc
                                    ElseIf dt_Op.Rows(i3).Item("FormaPago") = "TAR" Then
                                        sumaTar += dt_Op.Rows(i3).Item("MontoPago") * tc
                                    Else
                                        sumaOtros += dt_Op.Rows(i3).Item("MontoPago") * tc
                                    End If

                                Next

                            End If
                        End If
                        Me.DsIngresos1.CheckOut(i).TotalEfectivo = sumaEfec
                        Me.DsIngresos1.CheckOut(i).TotalTarjeta = sumaTar
                        Me.DsIngresos1.CheckOut(i).TotalOtros = sumaOtros
                        Me.DsIngresos1.CheckOut(i).TotalFront = dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")

                    Else
                        Me.DsIngresos1.CheckOut(i).TotalAdicionales += dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")
                        If dt.Rows(i2).Item("Tipo") = "CRE" Then
                            Me.DsIngresos1.CheckOut(i).TotalCredito += dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")
                        End If

                    End If

                Next

            End If


        Next

        cFunciones.Llenar_Tabla_Generico("SELECT Ventas.Id, Ventas.Num_Factura, Ventas.Nombre_Cliente, Ventas.Fecha, Ventas.Total, Ventas.Tipo, Ventas.Tipo_Cambio, DetalleCheckOut.Id_Check_Out, Ventas.Descripcion,  " & _
        " Ventas.Proveniencia_Venta AS PV " & _
        " FROM DetalleCheckOut INNER JOIN " & _
                      " Ventas ON DetalleCheckOut.Id_Ventas = Ventas.Id " & _
            where, Me.DsIngresos1.Ventas_HECHO, _
            Configuracion.Claves.Conexion("Hotel"))




        Dim rtp As New CrystalReport_CheckOUTS
        Dim visor As New FormVisorReportesCrystal
        rtp.SetDataSource(DsIngresos1)
        visor.CrystalReportViewerVisor.ReportSource = rtp
        visor.Show()

        Me.btnDetalle.Enabled = True
        Me.btnDetalle.Text = "Detalle"
    End Sub

    Sub imprimirDatos()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * From configuraciones", dt, Configuracion.Claves.Conexion("Hotel"))

        If dt.Rows.Count > 0 Then
            If dt.Rows(0).Item("Cedula").Equals("3-101-188056") Then
                Dim visor_3 As New frmVisorReportes
                visor_3.Text = "DETALLES VENTA"
                Dim Reporte1 As New Ventas_Detalladas_General_PuntoVenta
                Reporte1.SetParameterValue(0, "REPORTE DE VENTAS BRUTAS DESDE EL '" & Me.dtpFechaInicio.Text & "' HASTA EL '" & Me.dtpFechaFinal.Text & "'")
                Reporte1.SetParameterValue(1, 1)
                Reporte1.SetParameterValue(2, "COLON")
                Reporte1.SetParameterValue(3, CDate(Me.dtpFechaInicio.Value))
                Reporte1.SetParameterValue(4, CDate(Me.dtpFechaFinal.Value))
                Reporte1.SetParameterValue(5, Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).IdPuntoVenta)
                Reporte1.SetParameterValue(6, Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Nombre)
                CrystalReportsConexion2.LoadReportViewer2(visor_3.rptViewer, Reporte1, False, Configuracion.Claves.Conexion("Hotel"))
                visor_3.rptViewer.ReportSource = Reporte1
                visor_3.Show()
                Exit Sub
            End If
        End If
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "FRONT DESK" Then
            cargarDatos()
            Exit Sub
        End If
        Dim visor As New frmVisorReportes
        visor.Text = "FORMAS DE PAGO"
        Dim reporte_tipoPago As New CrystalReportFormaPago
        reporte_tipoPago.SetParameterValue("FechaInicio", CDate(Me.dtpFechaInicio.Value))
        reporte_tipoPago.SetParameterValue("FechaFinal", CDate(Me.dtpFechaFinal.Value))
        reporte_tipoPago.SetParameterValue("TipoCambio", 1)
        reporte_tipoPago.SetParameterValue("Moneda", "COLON")
        reporte_tipoPago.SetParameterValue("PuntoVenta", Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Nombre)
        CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, reporte_tipoPago, False, Configuracion.Claves.Conexion("Hotel"))
        visor.rptViewer.ReportSource = reporte_tipoPago

        Dim visor_2 As New frmVisorReportes
        visor_2.Text = "DETALLES VENTA"
        Dim Reporte As New Ventas_Detalladas_General_PuntoVenta
        Reporte.SetParameterValue(0, "REPORTE DE VENTAS BRUTAS DESDE EL '" & Me.dtpFechaInicio.Text & "' HASTA EL '" & Me.dtpFechaFinal.Text & "'")
        Reporte.SetParameterValue(1, 1)
        Reporte.SetParameterValue(2, "COLON")
        Reporte.SetParameterValue(3, CDate(Me.dtpFechaInicio.Value))
        Reporte.SetParameterValue(4, CDate(Me.dtpFechaFinal.Value))
        Reporte.SetParameterValue(5, Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).IdPuntoVenta)
        Reporte.SetParameterValue(6, Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Nombre)
        CrystalReportsConexion2.LoadReportViewer2(visor_2.rptViewer, Reporte, False, Configuracion.Claves.Conexion("Hotel"))
        visor_2.rptViewer.ReportSource = Reporte
        visor_2.Show()
        visor.Show()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button.ImageIndex = 0 Or e.Button.ImageIndex = 4 Then
            NUEVO()
        ElseIf e.Button.ImageIndex = 6 Then
            Dispose(True)
            Close() : Me.Dispose(True)
        ElseIf e.Button.ImageIndex = 2 Then
            Registrar()
        End If
    End Sub

    Private Sub Registrar()
        If ValidarCampos() Then
            If DsIngresos1.DetallesAsientosContable.Count < 1 Then
                MsgBox("No se puede guardar el asiento porque no tiene detalles!", MsgBoxStyle.Exclamation, "Asiento de Devoluciones")
                Exit Sub
            End If
            If MsgBox("Desea Guardar asiento de ingreso", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            If TransAsiento() = False Then
                MsgBox("Error Guardando el Asiento Contable", MsgBoxStyle.Exclamation, "Asiento de Devoluciones")
                Exit Sub
            End If
            If ActualizaVentas() = False Then
                MsgBox("Error Actualizando las Ventas", MsgBoxStyle.Exclamation, "Asiento de Devoluciones")
            End If
            MsgBox("Asiento Contable Guardado Satisfactoriamente", MsgBoxStyle.Information, "Asiento de Devoluciones")
            Limpiar()
            NUEVO()
        End If
    End Sub

    Function ActualizaVentas() As Boolean
        Dim Fx As New Conexion     'REALIZA LA ACTUALIZACION DE LAS DEVOLUCIONES DE COMPRAS
        Try
            Dim Asiento As String
            Asiento = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
            For i As Integer = 0 To DsIngresos1.Ventas.Count - 1
                If asientoCosto Then
                    Fx.UpdateRecords("Ventas", "ContabilizadoCVenta = 1 , AsientoCosto = '1'", "Id = " & DsIngresos1.Ventas(i).Id, "Hotel")
                Else
                    Fx.UpdateRecords("Ventas", "Contabilizado = 1, AsientoVenta = 1 , Asiento = '" & Asiento & "'", "Id = " & DsIngresos1.Ventas(i).Id, "Hotel")
                End If
            Next

            If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "FRONT DESK" Then
                Dim condicion As String = " Asiento= '0' AND " & _
                                "   (dbo.DateOnly(Check_Out.Fecha) >= CONVERT(DATETIME, '" & Me.dtpFechaInicio.Value.Year & "-" & Format(Me.dtpFechaInicio.Value.Month, "00") & "-" & Format(Me.dtpFechaInicio.Value.Day, "00") & " 00:00:00', 102) ) " & _
                                " AND (dbo.DateOnly(Check_Out.Fecha)  <= CONVERT(DATETIME, '" & Me.dtpFechaFinal.Value.Year & "-" & Format(Me.dtpFechaFinal.Value.Month, "00") & "-" & Format(Me.dtpFechaFinal.Value.Day, "00") & " 00:00:00', 102)) "
                Fx.UpdateRecords("Check_Out", "Asiento = 1 , NumAsiento ='" & Asiento & "'", condicion, "Hotel")
            End If
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Function TransAsiento() As Boolean
        Dim Trans As SqlTransaction     'REALIZA LA TRANSACCION DE LOS ASIENTOS CONTABLES
        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
            Trans = SqlConnection1.BeginTransaction
            adDetalleAsiento.UpdateCommand.Transaction = Trans
            adDetalleAsiento.DeleteCommand.Transaction = Trans
            adDetalleAsiento.InsertCommand.Transaction = Trans

            adAsientos.UpdateCommand.Transaction = Trans
            adAsientos.DeleteCommand.Transaction = Trans
            adAsientos.InsertCommand.Transaction = Trans
            '-----------------------------------------------------------------------------------
            'INICIA LA TRANSACCION....
            adAsientos.Update(DsIngresos1, "AsientosContables")
            adDetalleAsiento.Update(DsIngresos1, "DetallesAsientosContable")
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).Tipo = "TIENDA" Then
            Me.btnGenerarCostoVenta.Visible = True
        Else
            Me.btnGenerarCostoVenta.Visible = False
        End If


    End Sub

    Private Sub ButtonEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnviar.Click
        Me.GroupBoxDistribuirDiferencia.Visible = True
        Me.ToolBarRegistrar.Enabled = False
        Me.ButtonEnviar.Enabled = False
        Me.TextBoxMontoEnviar.Text = Me.diferencia
    End Sub
    Sub enviarDiferenciaAsiento(ByVal difeEnviada As Double, ByVal CuentaContable As String, ByVal Nombre As String)
        Dim dt_CuentaContable As DataTable

        If difeEnviada > 0 Then

            If Not GuardaAsientoDetalle(difeEnviada, False, True, CuentaContable, Nombre) Then
                If MsgBox("Error enviado la cuenta de diferencial cambiario (Haber)", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    End
                End If
            End If
        Else
            If Not GuardaAsientoDetalle(Math.Abs(difeEnviada), True, False, CuentaContable, Nombre) Then
                If MsgBox("Error enviado la cuenta de diferencial cambiario (Debe)", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    End
                End If
            End If
        End If
        totalDebeHaber()
        Dim cx As New Conexion
        Dim dt As DataTable = cx.AlphabeticSort(Me.DsIngresos1.DetallesAsientosContable.Copy, 1).Copy
        Me.DsIngresos1.DetallesAsientosContable.Clear()
        Dim i As Integer = 0
        Try


            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Debe") = True Then
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                End If

            Next
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Debe") = False Then
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                    BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                End If

            Next
        Catch ex As Exception
            MsgBox("Problema incluyendo diferencial: " & ex.ToString)

        End Try
        totalDebeHaber()
        btnDetalle.Enabled = True
        ToolBarRegistrar.Enabled = True
    End Sub
    Private Sub btnGenerarCostoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCostoVenta.Click
        Me.asientoCosto = True
        Me.generarAsientosVenta()
    End Sub

    Private Sub AsientoDetalleCosto()
        Dim CostoTotal As Double = 0
        Try

            For x As Integer = 0 To Me.DsIngresos1.Ventas.Count - 1
                CostoTotal = 0
                For i As Integer = 0 To Me.DsIngresos1.Ventas_Detalle.Count - 1
                    If Me.DsIngresos1.Ventas(x).Id = Me.DsIngresos1.Ventas_Detalle(i).Id_Factura Then
                        If Me.DsIngresos1.Ventas(x).Cod_Moneda = 2 Then
                            CostoTotal += (DsIngresos1.Ventas_Detalle(i).Cantidad * DsIngresos1.Ventas_Detalle(i).Precio_Costo * Me.DsIngresos1.Ventas(x).Tipo_Cambio)
                        Else
                            CostoTotal += (DsIngresos1.Ventas_Detalle(i).Cantidad * DsIngresos1.Ventas_Detalle(i).Precio_Costo)
                        End If

                    End If

                Next

                '------------------------------------------------------------------
                'GUARDA ASIENTO DETALLE PARA LA CUENTA DE COSTO
                If Not GuardaAsientoDetalle(CostoTotal, True, False, BuscaCuentaPV("CuentaContable", "IdCostoVenta"), BuscaCuentaPV("Descripcion", "IdCostoVenta")) Then
                    Me.incluirListaXContabilizar("Error costo: cuenta de la bodega (Haber) Monto: " & CostoTotal, CostoTotal, True, False)
                End If
                '------------------------------------------------------------------

                '------------------------------------------------------------------
                'GUARDA ASIENTO DETALLE PARA LA CUENTA DE LA BODEGA
                If Not GuardaAsientoDetalle(CostoTotal, False, True, BuscaCuentaBodega("CuentaContable"), BuscaCuentaBodega("DescripcionCuentaContable")) Then
                    'If MsgBox("Error costo: cuenta de la bodega (Haber) Monto: " & CostoTotal & " ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    '    End
                    'End If
                    Me.incluirListaXContabilizar("Error costo: cuenta de la bodega (Haber) Monto: " & CostoTotal, CostoTotal, True, False)
                End If
                '------------------------------------------------------------------
            Next

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
    Function BuscaCuentaBodega(ByVal Tipo As String) As String
        Dim cConexion As New Conexion
        Try
            cConexion.DesConectar(cConexion.sQlconexion)
            BuscaCuentaBodega = cConexion.SlqExecuteScalar(cConexion.Conectar("", "Proveeduria"), "SELECT " & Tipo & " FROM Bodega " & _
                            "WHERE (IdBodega = (SELECT Id_Bodega FROM Hotel.dbo.PuntoVenta WHERE IdPuntoVenta = " & Me.DsIngresos1.PuntoVenta(Me.ComboBox1.SelectedIndex).IdPuntoVenta & "))")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function

    Private Sub ButtonEnviarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnviarCuenta.Click
        evaluaMontoCuenta()
    End Sub
    Sub evaluaMontoCuenta()
        Try
            Dim montoEnviar As Double = Me.TextBoxMontoEnviar.Text

            If Me.diferencia > 0 Then
                If montoEnviar < 0 Then
                    MsgBox("El monto no puede ser negativo") : Exit Sub
                End If
                If montoEnviar > Me.diferencia Then
                    MsgBox("El monto a distribuir no ser superior a la diferencia") : Exit Sub
                End If

                Dim cx As New Conexion
                Dim funcion As New cFunciones
                Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Buscar Cuenta Contable", Configuracion.Claves.Conexion("Contabilidad"))
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
                If Id Is Nothing Then Exit Sub

                Me.enviarDiferenciaAsiento(montoEnviar, dt.Rows(0).Item("CuentaContable"), dt.Rows(0).Item("Descripcion"))

            ElseIf diferencia < 0 Then

                If montoEnviar > 0 Then
                    MsgBox("El monto no puede ser positivo") : Exit Sub
                End If
                If Not (montoEnviar >= Me.diferencia) Then
                    MsgBox("El monto a distribuir no ser superior a la diferencia") : Exit Sub
                End If
                Dim cx As New Conexion
                Dim funcion As New cFunciones
                Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Buscar Cuenta Contable", Configuracion.Claves.Conexion("Contabilidad"))
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
                If Id Is Nothing Then Exit Sub

                Me.enviarDiferenciaAsiento(montoEnviar, dt.Rows(0).Item("CuentaContable"), dt.Rows(0).Item("Descripcion"))

            End If

            Me.TextBoxMontoEnviar.Text = Me.diferencia
            Me.GroupBoxDistribuirDiferencia.Visible = False
            Me.ToolBarRegistrar.Enabled = True
            Me.ButtonEnviar.Enabled = True

        Catch ex As Exception

        End Try
    End Sub
End Class
