Imports System.Data.SqlClient
Imports Utilidades
Public Class frmAsientoPrepago
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

    Dim dt_Datos As New DataTable
    Dim dt_DatosCuenta As New DataTable
    Dim dt_DatosTAR As New DataTable

    Dim Monto_Colones As Double
    Dim Nombre As String
    Dim Cuenta As String
    Dim dt_DatosEFE As New DataTable
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
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adPuntoVenta As System.Data.SqlClient.SqlDataAdapter
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
    Friend WithEvents DsPrepago As Contabilidad.dsIngresos
    Friend WithEvents LabelNumAsiento As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAsientoPrepago))
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerarVenta = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.DsPrepago = New Contabilidad.dsIngresos
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
        Me.LabelNumAsiento = New System.Windows.Forms.Label
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPrepago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxDistribuirDiferencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(112, Byte), CType(122, Byte), CType(200, Byte))
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(680, 32)
        Me.TituloModulo.TabIndex = 71
        Me.TituloModulo.Text = " Asiento Prepago"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(120, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Location = New System.Drawing.Point(232, 40)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(152, 32)
        Me.btnGenerarVenta.TabIndex = 162
        Me.btnGenerarVenta.Text = "Generar Asiento Prepago"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(120, 56)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 161
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(8, 56)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 160
        '
        'griDetalle
        '
        Me.griDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.griDetalle.DataSource = Me.DsPrepago.DetallesAsientosContable
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(8, 88)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(664, 280)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 236
        Me.griDetalle.Text = "Asientos de venta"
        '
        'DsPrepago
        '
        Me.DsPrepago.DataSetName = "DsPrepago"
        Me.DsPrepago.Locale = New System.Globalization.CultureInfo("es-CR")
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
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 112
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "NombreCuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 285
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Debe"
        Me.GridColumn3.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "MontoDebe"
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
        Me.GridColumn3.Width = 114
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Haber"
        Me.GridColumn4.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "MontoHaber"
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
        Me.GridColumn4.Width = 136
        '
        'btnDetalle
        '
        Me.btnDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDetalle.Location = New System.Drawing.Point(8, 383)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(56, 23)
        Me.btnDetalle.TabIndex = 239
        Me.btnDetalle.Text = "Detalle"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(528, 375)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 238
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(376, 375)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 237
        Me.txtTotalDebe.Text = ""
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 417)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(680, 52)
        Me.ToolBar1.TabIndex = 240
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(472, 442)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 243
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(392, 442)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 241
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(472, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 244
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(392, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 242
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Contabilidad"
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Hotel"
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
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Origina" & _
        "l_Fecha) AND (FechaEntrada = @Original_FechaEntrada) AND (IdNumDoc = @Original_I" & _
        "dNumDoc) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo)" & _
        " AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) A" & _
        "ND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Obse" & _
        "rvaciones) AND (Periodo = @Original_Periodo) AND (TipoCambio = @Original_TipoCam" & _
        "bio) AND (TipoDoc = @Original_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND" & _
        " (TotalHaber = @Original_TotalHaber)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, " & _
        "TipoDoc, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modu" & _
        "lo, Observaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio) " & _
        "VALUES (@NumAsiento, @Fecha, @IdNumDoc, @NumDoc, @Beneficiario, @TipoDoc, @Accio" & _
        "n, @Anulado, @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Obs" & _
        "ervaciones, @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio); S" & _
        "ELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulad" & _
        "o, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nomb" & _
        "reUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulad" & _
        "o, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nomb" & _
        "reUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM AsientosContables"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, IdNumDoc =" & _
        " @IdNumDoc, NumDoc = @NumDoc, Beneficiario = @Beneficiario, TipoDoc = @TipoDoc, " & _
        "Accion = @Accion, Anulado = @Anulado, FechaEntrada = @FechaEntrada, Mayorizado =" & _
        " @Mayorizado, Periodo = @Periodo, NumMayorizado = @NumMayorizado, Modulo = @Modu" & _
        "lo, Observaciones = @Observaciones, NombreUsuario = @NombreUsuario, TotalDebe = " & _
        "@TotalDebe, TotalHaber = @TotalHaber, CodMoneda = @CodMoneda, TipoCambio = @Tipo" & _
        "Cambio WHERE (NumAsiento = @Original_NumAsiento) AND (Accion = @Original_Accion)" & _
        " AND (Anulado = @Original_Anulado) AND (Beneficiario = @Original_Beneficiario) A" & _
        "ND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Original_Fecha) AND (FechaEnt" & _
        "rada = @Original_FechaEntrada) AND (IdNumDoc = @Original_IdNumDoc) AND (Mayoriza" & _
        "do = @Original_Mayorizado) AND (Modulo = @Original_Modulo) AND (NombreUsuario = " & _
        "@Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) AND (NumMayorizado = @O" & _
        "riginal_NumMayorizado) AND (Observaciones = @Original_Observaciones) AND (Period" & _
        "o = @Original_Periodo) AND (TipoCambio = @Original_TipoCambio) AND (TipoDoc = @O" & _
        "riginal_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND (TotalHaber = @Origin" & _
        "al_TotalHaber); SELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDo" & _
        "c, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Ob" & _
        "servaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM As" & _
        "ientosContables WHERE (NumAsiento = @NumAsiento)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
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
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (Tipocambio = @Original_Tipocambio OR @Original_Tipocambio" & _
        " IS NULL AND Tipocambio IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "pocambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE DetallesAsientosContable SET NumAsiento = @NumAsiento, Cuenta = @Cuenta, N" & _
        "ombreCuenta = @NombreCuenta, Monto = @Monto, Debe = @Debe, Haber = @Haber, Descr" & _
        "ipcionAsiento = @DescripcionAsiento, Tipocambio = @Tipocambio WHERE (ID_Detalle " & _
        "= @Original_ID_Detalle) AND (Cuenta = @Original_Cuenta) AND (Debe = @Original_De" & _
        "be) AND (DescripcionAsiento = @Original_DescripcionAsiento) AND (Haber = @Origin" & _
        "al_Haber) AND (Monto = @Original_Monto) AND (NombreCuenta = @Original_NombreCuen" & _
        "ta) AND (NumAsiento = @Original_NumAsiento) AND (Tipocambio = @Original_Tipocamb" & _
        "io OR @Original_Tipocambio IS NULL AND Tipocambio IS NULL); SELECT ID_Detalle, N" & _
        "umAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocam" & _
        "bio FROM DetallesAsientosContable WHERE (ID_Detalle = @ID_Detalle)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle"))
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
        Me.TextBoxDiferencia.AutoSize = False
        Me.TextBoxDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxDiferencia.Enabled = False
        Me.TextBoxDiferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDiferencia.Location = New System.Drawing.Point(424, 399)
        Me.TextBoxDiferencia.Name = "TextBoxDiferencia"
        Me.TextBoxDiferencia.ReadOnly = True
        Me.TextBoxDiferencia.Size = New System.Drawing.Size(144, 18)
        Me.TextBoxDiferencia.TabIndex = 247
        Me.TextBoxDiferencia.Text = ""
        Me.TextBoxDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonEnviar
        '
        Me.ButtonEnviar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonEnviar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEnviar.Location = New System.Drawing.Point(576, 399)
        Me.ButtonEnviar.Name = "ButtonEnviar"
        Me.ButtonEnviar.Size = New System.Drawing.Size(88, 16)
        Me.ButtonEnviar.TabIndex = 248
        Me.ButtonEnviar.Text = "Enviar dif. a"
        Me.ButtonEnviar.Visible = False
        '
        'GroupBoxDistribuirDiferencia
        '
        Me.GroupBoxDistribuirDiferencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxDistribuirDiferencia.Controls.Add(Me.ButtonEnviarCuenta)
        Me.GroupBoxDistribuirDiferencia.Controls.Add(Me.TextBoxMontoEnviar)
        Me.GroupBoxDistribuirDiferencia.Location = New System.Drawing.Point(368, 304)
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
        'LabelNumAsiento
        '
        Me.LabelNumAsiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelNumAsiento.Location = New System.Drawing.Point(72, 384)
        Me.LabelNumAsiento.Name = "LabelNumAsiento"
        Me.LabelNumAsiento.Size = New System.Drawing.Size(192, 23)
        Me.LabelNumAsiento.TabIndex = 250
        Me.LabelNumAsiento.Text = "#"
        '
        'frmAsientoPrepago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 469)
        Me.Controls.Add(Me.LabelNumAsiento)
        Me.Controls.Add(Me.GroupBoxDistribuirDiferencia)
        Me.Controls.Add(Me.ButtonEnviar)
        Me.Controls.Add(Me.TextBoxDiferencia)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtTotalHaber)
        Me.Controls.Add(Me.txtTotalDebe)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarVenta)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.TituloModulo)
        Me.Name = "frmAsientoPrepago"
        Me.Text = "Asiento Prepago (No Deposito)"
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPrepago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxDistribuirDiferencia.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones Iniciacion"

    Private Sub IngresoGaleria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        SqlConnection2.ConnectionString = Configuracion.Claves.Conexion("Hotel")

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
        adPuntoVenta.Fill(DsPrepago.PuntoVenta)
    End Sub

    Private Sub ActivarGui()
        ToolBarNuevo.Enabled = False
        ToolBarRegistrar.Enabled = False
        btnGenerarVenta.Enabled = False
        btnDetalle.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
    End Sub

    Private Sub Limpiar()

        DsPrepago.DetallesAsientosContable.Clear()
        DsPrepago.AsientosContables.Clear()
        DsPrepago.DetallesAsientosContable.Clear()
        griDetalle.Refresh()
        txtTotalHaber.Text = ""
        txtTotalDebe.Text = ""
        txtTotalDebe.Text = Format(0, "¢###,##0.00")
        txtTotalHaber.Text = Format(0, "¢###,##0.00")
        Me.TextBoxDiferencia.Text = Format(0, "¢###,##0.00")
    End Sub

    Private Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsPrepago.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsPrepago.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsPrepago.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsPrepago.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsPrepago.AsientosContables.TipoDocColumn.DefaultValue = 5
        DsPrepago.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsPrepago.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsPrepago.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsPrepago.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsPrepago.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsPrepago.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsPrepago.AsientosContables.ModuloColumn.DefaultValue = "Asiento Compras"
        DsPrepago.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsPrepago.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsPrepago.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsPrepago.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DsPrepago.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DsPrepago.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsPrepago.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsPrepago.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsPrepago.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsPrepago.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsPrepago.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsPrepago.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsPrepago.DetallesAsientosContable.HaberColumn.DefaultValue = 0
        DsPrepago.DetallesAsientosContable.TipocambioColumn.DefaultValue = 1
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
        If Me.txtTotalHaber.Text <> Me.txtTotalDebe.Text Then
            MsgBox("No se puede registrar porque el balance no es correcto", MsgBoxStyle.Information)
            Exit Function
        End If

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

                ToolBarRegistrar.Enabled = False
                dtpFechaInicio.Enabled = True
                dtpFechaFinal.Enabled = True
                btnDetalle.Enabled = True
                dtpFechaInicio.Focus()
            Else
                ToolBarNuevo.ImageIndex = "0"
                ToolBarNuevo.Text = "Nuevo"
                btnGenerarVenta.Enabled = False
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


    'Encabezado de asiento prepago
    Private Sub GenerarAsiento()
        Dim Fx As New cFunciones
        Try
            DiferencialCambiario = 0
            Limpiar()
            TipoCambio = Fx.TipoCambio(dtpFechaFinal.Value)
            BindingContext(DsPrepago, "AsientosContables").EndCurrentEdit()
            BindingContext(DsPrepago, "AsientosContables").AddNew()
            BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("ING-" & Format(Now.Month, "00") & Format(Now.Date, "yy") & "-")

            BindingContext(DsPrepago, "AsientosContables").Current("Fecha") = dtpFechaFinal.Value
            BindingContext(DsPrepago, "AsientosContables").Current("IdNumDoc") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("NumDoc") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("Beneficiario") = "Prepago"
            BindingContext(DsPrepago, "AsientosContables").Current("TipoDoc") = 30
            BindingContext(DsPrepago, "AsientosContables").Current("Accion") = "AUT"
            BindingContext(DsPrepago, "AsientosContables").Current("Anulado") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("Mayorizado") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("FechaEntrada") = Now.Date
            BindingContext(DsPrepago, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(dtpFechaFinal.Value)
            BindingContext(DsPrepago, "AsientosContables").Current("NumMayorizado") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("Modulo") = "Asiento Prepago - Contabilidad"
            'If Not Me.asientoCosto Then
            BindingContext(DsPrepago, "AsientosContables").Current("Observaciones") = "Asiento de Prepago del " & dtpFechaInicio.Value.Date & " al " & dtpFechaInicio.Value.Date
            'Else
            '    BindingContext(DsPrepago, "AsientosContables").Current("Observaciones") = "Asiento de Gastos " & ComboBox1.Text & " del " & dtpFechaInicio.Value & " al " & dtpFechaInicio.Value
            'End If

            BindingContext(DsPrepago, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
            BindingContext(DsPrepago, "AsientosContables").Current("TotalDebe") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("TotalHaber") = 0
            BindingContext(DsPrepago, "AsientosContables").Current("CodMoneda") = 1
            BindingContext(DsPrepago, "AsientosContables").Current("TipoCambio") = TipoCambio
            BindingContext(DsPrepago, "AsientosContables").EndCurrentEdit()
            Me.LabelNumAsiento.Text = "# " & BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento") & " Proc = " & dt_Datos.Rows.Count
            For cont As Integer = 0 To dt_Datos.Rows.Count - 1

                'AGREGAR DETALLE
                ' Dolares

                If dt_Datos.Rows(cont).Item("CodMoneda") = 2 Then
                    'Calcula el monto en colones
                    Monto_Colones = dt_Datos.Rows(cont).Item("MontoPago") * dt_Datos.Rows(cont).Item("TipoCambio")

                    cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.Descripcion AS Descripcion, CuentaContable.CuentaContable AS CuentaContable FROM CuentaContable INNER JOIN SettingCuentaContable ON CuentaContable.id = SettingCuentaContable.IdPrepagoCol", dt_DatosCuenta, Configuracion.Claves.Conexion("Contabilidad"))
                    Nombre = dt_DatosCuenta.Rows(0).Item(0)
                    Cuenta = dt_DatosCuenta.Rows(0).Item(1)
                End If

                ' Colones
                If dt_Datos.Rows(cont).Item("CodMoneda") = 1 Then
                    Monto_Colones = dt_Datos.Rows(cont).Item("MontoPago")
                    cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.Descripcion AS Descripcion, CuentaContable.CuentaContable AS CuentaContable FROM CuentaContable INNER JOIN SettingCuentaContable ON CuentaContable.id = SettingCuentaContable.IdPrepagoDol", dt_DatosCuenta, Configuracion.Claves.Conexion("Contabilidad"))
                    Nombre = dt_DatosCuenta.Rows(0).Item(0)
                    Cuenta = dt_DatosCuenta.Rows(0).Item(1)
                End If

                'FALTAN LAS CONDICIONES 

                'Guarda haciendo detalle DEBE
                GuardaAsientoDetalle(Monto_Colones, False, True, Cuenta.Trim(" "), Nombre)

                Cuenta = "" : Nombre = ""
                If dt_Datos.Rows(cont).Item("FormaPago") = "TAR" Then
                    'obtener la cuenta y nombre de la tabla detalle prepago
                    'se debe seleccionar la cuenta y el nombre 

                    cFunciones.Llenar_Tabla_Generico("SELECT  TipoTarjeta.CuentaCXC , TipoTarjeta.NombreCXC , TipoTarjeta.Nombre FROM   Detalle_pago_caja INNER JOIN TipoTarjeta ON Detalle_pago_caja.ReferenciaTipo = TipoTarjeta.Id WHERE Detalle_pago_caja.Id_ODP = " & dt_Datos.Rows(cont).Item("Id"), dt_DatosTAR, Configuracion.Claves.Conexion("Hotel"))
                    If dt_DatosTAR.Rows.Count > 0 Then
                        Cuenta = dt_DatosTAR.Rows(0).Item("CuentaCXC")
                        Nombre = dt_DatosTAR.Rows(0).Item("NombreCXC")
                    Else
                        MsgBox("El registro #" & Me.dt_Datos.Rows(cont).Item("Documento") & " // ID= " & Me.dt_Datos.Rows(0).Item("ID") & " // Apertura = " & Me.dt_Datos.Rows(0).Item("Numapertura") & " la cuenta contable de tarjeta no existe o no ha sido configurada", MsgBoxStyle.OKOnly)
                    End If


                ElseIf dt_Datos.Rows(cont).Item("FormaPago") = "EFE" Or dt_Datos.Rows(cont).Item("FormaPago") = "CHE" Then

                    If dt_DatosEFE.Rows.Count > 0 Then
                        Cuenta = dt_DatosEFE.Rows(0).Item("CuentaContable")
                        Nombre = dt_DatosEFE.Rows(0).Item("Descripcion")

                    Else
                        MsgBox("El registro #" & Me.dt_Datos.Rows(cont).Item("Documento") & " // ID=" & Me.dt_Datos.Rows(0).Item("ID") & " // Apertura = " & Me.dt_Datos.Rows(0).Item("Numapertura") & " la cuenta contable de Efectivos y Cheques no existe o no ha sido configurada", MsgBoxStyle.OKOnly)

                    End If
                End If
                'Guarda haciendo detalle HABER
                GuardaAsientoDetalle(Monto_Colones, True, False, Cuenta.Trim(" "), Nombre)
            Next


            totalDebeHaber()
            Dim cx As New Conexion
            Dim dt As DataTable = cx.AlphabeticSort(Me.DsPrepago.DetallesAsientosContable.Copy, 1).Copy
            Me.DsPrepago.DetallesAsientosContable.Clear()
            Dim i As Integer = 0
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Debe") = True Then
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("Observaciones")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                End If

            Next
            For i = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("Debe") = False Then
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("Observaciones")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                    BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                End If

            Next
            totalDebeHaber()
            btnDetalle.Enabled = True
            ToolBarRegistrar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly)
        End Try

    End Sub
    
    Sub totalDebeHaber()
        Dim debe As Double = 0
        Dim haber As Double = 0

        For i As Integer = 0 To Me.DsPrepago.DetallesAsientosContable.Count - 1
            If Me.DsPrepago.DetallesAsientosContable(i).Debe Then
                debe += Me.DsPrepago.DetallesAsientosContable(i).Monto
                Me.DsPrepago.DetallesAsientosContable(i).MontoDebe = Me.DsPrepago.DetallesAsientosContable(i).Monto
                Me.DsPrepago.DetallesAsientosContable(i).MontoHaber = 0
            Else
                haber += Me.DsPrepago.DetallesAsientosContable(i).Monto
                Me.DsPrepago.DetallesAsientosContable(i).MontoHaber = Me.DsPrepago.DetallesAsientosContable(i).Monto
                Me.DsPrepago.DetallesAsientosContable(i).MontoDebe = 0
            End If
        Next
        BindingContext(DsPrepago, "AsientosContables").Current("TotalDebe") = debe
        BindingContext(DsPrepago, "AsientosContables").Current("TotalHaber") = haber
        BindingContext(DsPrepago, "AsientosContables").EndCurrentEdit()
        Me.txtTotalDebe.Text = Format(debe, "¢ ###,##0.00")
        Me.txtTotalHaber.Text = Format(haber, "¢ ###,##0.00")
        Me.TextBoxDiferencia.Text = "Dif: " & Format(debe - haber, "¢ ###,##0.00")
        diferencia = Math.Round(debe - haber, 2)
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
    Function BuscaCuentaServicios(ByVal Tipo As String, ByVal Id As Integer) As String
        Dim cConexion As New Conexion
        Try
            BuscaCuentaServicios = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSoft", "Hotel"), "SELECT Familias." & Tipo & " FROM Familias INNER JOIN Servicios " & _
            "ON Familias.Codigo = Servicios.CodigoSubFamilia WHERE Servicios.Codigo = " & Id)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function

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

    'Engrosar cuenta
    Function engrosarlacuenta(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        Try

            For i As Integer = 0 To Me.DsPrepago.DetallesAsientosContable.Count - 1

                If Me.DsPrepago.DetallesAsientosContable(i).Cuenta = Cuenta And Me.DsPrepago.DetallesAsientosContable(i).Debe = Debe And Me.DsPrepago.DetallesAsientosContable(i).Haber = Haber Then
                    Me.DsPrepago.DetallesAsientosContable(i).Monto += Monto
                    Return True
                End If

            Next
            Return False
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try
    End Function
    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String)
        Try
            If Monto <> 0 Then

                If engrosarlacuenta(Monto, Debe, Haber, Cuenta, NombreCuenta) Then

                    Exit Sub
                End If
                'CREA LOS DETALLES DE ASIENTOS CONTABLES
                'BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("Observaciones")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

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
        'Me.asientoCosto = False
        generarAsientosPrepago()

    End Sub

    Sub generarAsientosPrepago()

        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final")
            Exit Sub
        End If
        If Me.dtpFechaInicio.Value.Date <= Now.Date And Me.dtpFechaFinal.Value.Date <= Now.Date Then
        Else
            MsgBox("La fecha de inicio y final no pueden ser superiores a hoy ( " & Now.Date & " )")
            Exit Sub
        End If

        DsPrepago.DetallesAsientosContable.Clear()
        DsPrepago.AsientosContables.Clear()
        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable AS CuentaContable, CuentaContable.Descripcion AS Descripcion FROM SettingCuentaContable INNER JOIN CuentaContable ON SettingCuentaContable.IdCaja = CuentaContable.id", dt_DatosEFE, Configuracion.Claves.Conexion("Contabilidad"))

        If Me.buscarPrepagos() Then
            GenerarAsiento()
        Else
            MsgBox("No hay documentos que contabilizar o ya todos estan contabilizados", MsgBoxStyle.OKOnly)

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

    Function buscarPrepagos() As Boolean
        'Busca Check Outs si es Front Desk
        'cFunciones.Llenar_Tabla_Generico("Select Cedula From configuraciones", dt_Datos, Configuracion.Claves.Conexion("Hotel"))
        cFunciones.Llenar_Tabla_Generico("SELECT    id, Documento, TipoDocumento, MontoPago, FormaPago, CodMoneda, Nombremoneda, TipoCambio, Fecha, Numapertura, AsientoPrepago, Nombre, CuentaCXC, NombreCXC FROM  OpcionesPagoPrepago WHERE Documento > 0 AND MontoPago > 0 AND AsientoPrepago = '0' AND (Fecha >='" & dtpFechaInicio.Value.Date & "'and Fecha <='" & dtpFechaFinal.Value.Date & "')", dt_Datos, Configuracion.Claves.Conexion("Hotel"))
        If dt_Datos.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click

        imprimirDatos()
    End Sub
    Sub imprimirDatos()
        Dim reporte As New CrystalReportPrepago
        Dim frm As New frmVisorReportes
        Dim cuentaEfe As String = ""
        Dim nombrecuentaEfe As String = ""
        If dt_DatosEFE.Rows.Count > 0 Then
            cuentaEfe = dt_DatosEFE.Rows(0).Item("CuentaContable")
            nombrecuentaEfe = dt_DatosEFE.Rows(0).Item("Descripcion")
        End If
        reporte.SetParameterValue("CuentaEfectivos", cuentaEfe)
        reporte.SetParameterValue("NombreCuentaEfectivos", nombrecuentaEfe)
        reporte.SetParameterValue("FechaI", Me.dtpFechaInicio.Value.Date)
        reporte.SetParameterValue("Fecha2", Me.dtpFechaFinal.Value.Date)

        CrystalReportsConexion2.LoadReportViewer2(frm.rptViewer, reporte, False, Configuracion.Claves.Conexion("Hotel"))
        frm.rptViewer.ReportSource = reporte
        frm.Show()

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
                    Me.DsPrepago.CheckOut, Configuracion.Claves.Conexion("Hotel"))

        For i As Integer = 0 To Me.DsPrepago.CheckOut.Count - 1

            Dim dt As New DataTable

            cFunciones.Llenar_Tabla_Generico("SELECT     MontoPago, TipoCambio, FormaPago " & _
            " FROM OpcionesDePago " & _
            " WHERE     (TipoDocumento = 'CHF') AND (Documento = " & DsPrepago.CheckOut(i).Id & ")", dt, _
            Configuracion.Claves.Conexion("Hotel"))

            ' DsPrepago.CheckOut(i).TotalPrepago = DsPrepago.CheckOut(i).TotalPrepago * DsPrepago.CheckOut(i).TipoCambio
            DsPrepago.CheckOut(i).TotalPago = DsPrepago.CheckOut(i).TotalPago * DsPrepago.CheckOut(i).TipoCambio

            Dim sumaEfec As Double = 0
            Dim sumaTar As Double = 0
            Dim sumaOtros As Double = 0
            If dt.Rows.Count > 0 Then


                For i2 As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i2).Item("FormaPago") = "EFE" Then
                        sumaEfec += dt.Rows(i2).Item("MontoPago") * dt.Rows(i2).Item("TipoCambio")
                    ElseIf dt.Rows(i2).Item("FormaPago") = "TAR" Then

                        sumaTar += dt.Rows(i2).Item("MontoPago") * dt.Rows(i2).Item("TipoCambio")
                    Else
                        '  sumaOtros += dt.Rows(i2).Item("MontoPago") * dt.Rows(i2).Item("TipoCambio")
                    End If


                Next

            End If
            Me.DsPrepago.CheckOut(i).TotalEfectivo = sumaEfec
            Me.DsPrepago.CheckOut(i).TotalTarjeta = sumaTar
            Me.DsPrepago.CheckOut(i).TotalOtros = sumaOtros

            cFunciones.Llenar_Tabla_Generico("SELECT Ventas.Nombre_Cliente, Ventas.Num_Factura, Ventas.Total, Ventas.Tipo, Ventas.Tipo_Cambio, DetalleCheckOut.Id_Check_Out, Ventas.Proveniencia_Venta as PV" & _
            " FROM DetalleCheckOut INNER JOIN" & _
                                  " Ventas ON DetalleCheckOut.Id_Ventas = Ventas.Id WHERE Ventas.Anulado = 0 AND DetalleCheckOut.Id_Check_Out = " & DsPrepago.CheckOut(i).Id, dt, _
            Configuracion.Claves.Conexion("Hotel"))
            If i = 0 Then
                where &= " (DetalleCheckOut.Id_Check_Out = " & DsPrepago.CheckOut(i).Id & ") "
            Else
                where &= " OR (DetalleCheckOut.Id_Check_Out = " & DsPrepago.CheckOut(i).Id & ") "
            End If


            If dt.Rows.Count > 0 Then
                For i2 As Integer = 0 To dt.Rows.Count - 1
                    sumaEfec = 0
                    sumaTar = 0
                    sumaOtros = 0
                    If dt.Rows(i2).Item("PV") = 1 Then

                        If dt.Rows(i2).Item("Tipo") = "CRE" Then
                            Me.DsPrepago.CheckOut(i).TotalCredito = Me.DsPrepago.CheckOut(i).TotalPago '* Me.DsPrepago.CheckOut(i).TipoCambio  ' dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")
                        Else
                            Dim dt_Op As New DataTable

                            cFunciones.Llenar_Tabla_Generico("SELECT MontoPago, TipoCambio, FormaPago" & _
                            " FROM OpcionesDePago " & _
                            " WHERE     ( TipoDocumento = 'CHF' )AND (Documento = " & dt.Rows(i2).Item("Num_Factura") & ")", dt_Op, _
                            Configuracion.Claves.Conexion("Hotel"))

                            If dt_Op.Rows.Count > 0 Then

                                For i3 As Integer = 0 To dt_Op.Rows.Count - 1
                                    If dt_Op.Rows(i3).Item("FormaPago") = "EFE" Then
                                        sumaEfec += dt_Op.Rows(i3).Item("MontoPago") * dt_Op.Rows(i3).Item("TipoCambio")
                                    ElseIf dt_Op.Rows(i3).Item("FormaPago") = "TAR" Then
                                        sumaTar += dt_Op.Rows(i3).Item("MontoPago") * dt_Op.Rows(i3).Item("TipoCambio")
                                    ElseIf dt_Op.Rows(i3).Item("FormaPago") = "CHE" Then
                                        sumaOtros += dt_Op.Rows(i3).Item("MontoPago") * dt_Op.Rows(i3).Item("TipoCambio")
                                    End If

                                Next

                            End If
                        End If
                        Me.DsPrepago.CheckOut(i).TotalEfectivo = sumaEfec
                        Me.DsPrepago.CheckOut(i).TotalTarjeta = sumaTar
                        Me.DsPrepago.CheckOut(i).TotalOtros = sumaOtros
                        Me.DsPrepago.CheckOut(i).TotalFront = dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")

                    Else
                        Me.DsPrepago.CheckOut(i).TotalAdicionales += dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")
                        If dt.Rows(i2).Item("Tipo") = "CRE" Then
                            Me.DsPrepago.CheckOut(i).TotalCredito += dt.Rows(i2).Item("Total") * dt.Rows(i2).Item("Tipo_Cambio")
                        End If

                    End If

                Next

            End If


        Next

        cFunciones.Llenar_Tabla_Generico("SELECT Ventas.Id, Ventas.Num_Factura, Ventas.Nombre_Cliente, Ventas.Fecha, Ventas.Total, Ventas.Tipo, Ventas.Tipo_Cambio, DetalleCheckOut.Id_Check_Out, Ventas.Descripcion,  " & _
        " Ventas.Proveniencia_Venta AS PV " & _
        " FROM DetalleCheckOut INNER JOIN " & _
                      " Ventas ON DetalleCheckOut.Id_Ventas = Ventas.Id " & _
            where, Me.DsPrepago.Ventas_HECHO, _
            Configuracion.Claves.Conexion("Hotel"))




        Dim rtp As New CrystalReport_CheckOUTS
        Dim visor As New FormVisorReportesCrystal
        rtp.SetDataSource(DsPrepago)
        visor.CrystalReportViewerVisor.ReportSource = rtp
        visor.Show()

        Me.btnDetalle.Enabled = True
        Me.btnDetalle.Text = "Detalle"


    End Sub


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button.ImageIndex = 0 Or e.Button.ImageIndex = 4 Then
            NUEVO()
        ElseIf e.Button.ImageIndex = 6 Then
            Dispose(True)
            Close()
        ElseIf e.Button.ImageIndex = 2 Then
            Registrar()
        End If
    End Sub

    Private Sub Registrar()
        If ValidarCampos() Then
            If DsPrepago.DetallesAsientosContable.Count < 1 Then
                MsgBox("No se puede guardar el asiento porque no tiene detalles!", MsgBoxStyle.Exclamation, "Asiento de Devoluciones")
                Exit Sub
            End If
            If MsgBox("Desea Guardar asiento de prepago", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            If TransAsiento() = False Then
                MsgBox("Error Guardando el Asiento Contable", MsgBoxStyle.Exclamation, "Asiento de Devoluciones")
                Exit Sub
            End If
            If actualizarPrepagos() = False Then
                MsgBox("Error actualizando las prepagos", MsgBoxStyle.Exclamation, "Asiento de Devoluciones")
            End If
            MsgBox("Asiento Contable Guardado Satisfactoriamente", MsgBoxStyle.Information, "Asiento de Devoluciones")
            Limpiar()
            NUEVO()
        End If
    End Sub

    Function actualizarPrepagos() As Boolean
        Dim cx As New Conexion
        cx.Conectar("SeeSoft", "Hotel")

        For i As Integer = 0 To Me.dt_Datos.Rows.Count - 1
            If Not (cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set AsientoPrepago = '" & BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento") & "' where Id = " & Me.dt_Datos.Rows(i).Item("ID")) Is Nothing) Then
                Return False
            End If

        Next
        Return True
    End Function

    Function TransAsiento() As Boolean
        Dim Trans As SqlTransaction     'REALIZA LA TRANSACCION DE LOS ASIENTOS CONTABLES
        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsPrepago, "AsientosContables").EndCurrentEdit()
            Trans = SqlConnection1.BeginTransaction
            adDetalleAsiento.UpdateCommand.Transaction = Trans
            adDetalleAsiento.DeleteCommand.Transaction = Trans
            adDetalleAsiento.InsertCommand.Transaction = Trans

            adAsientos.UpdateCommand.Transaction = Trans
            adAsientos.DeleteCommand.Transaction = Trans
            adAsientos.InsertCommand.Transaction = Trans
            '-----------------------------------------------------------------------------------
            'INICIA LA TRANSACCION....
            adAsientos.Update(DsPrepago, "AsientosContables")
            adDetalleAsiento.Update(DsPrepago, "DetallesAsientosContable")
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Private Sub ButtonEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEnviar.Click
        Me.GroupBoxDistribuirDiferencia.Visible = True
        Me.ToolBarRegistrar.Enabled = False
        Me.ButtonEnviar.Enabled = False
        Me.TextBoxMontoEnviar.Text = Me.diferencia
    End Sub

    Sub enviarDiferenciaAsiento(ByVal difeEnviada As Double, ByVal CuentaContable As String, ByVal Nombre As String)
        Dim dt_CuentaContable As DataTable

        If difeEnviada > 0 Then
            GuardaAsientoDetalle(difeEnviada, False, True, CuentaContable, Nombre)
        Else
            GuardaAsientoDetalle(Math.Abs(difeEnviada), True, False, CuentaContable, Nombre)
        End If
        totalDebeHaber()
        Dim cx As New Conexion
        Dim dt As DataTable = cx.AlphabeticSort(Me.DsPrepago.DetallesAsientosContable.Copy, 1).Copy
        Me.DsPrepago.DetallesAsientosContable.Clear()
        Dim i As Integer = 0
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Debe") = True Then
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("Observaciones")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            End If

        Next
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Debe") = False Then
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("NumAsiento")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsPrepago, "AsientosContables").Current("Observaciones")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                BindingContext(DsPrepago, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            End If

        Next
        totalDebeHaber()
        btnDetalle.Enabled = True
        ToolBarRegistrar.Enabled = True
    End Sub
    Private Sub btnGenerarCostoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.asientoCosto = True
        Me.generarAsientosPrepago()
    End Sub



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

    Private Sub dtpFechaInicio_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFechaInicio.ValueChanged

    End Sub
End Class
