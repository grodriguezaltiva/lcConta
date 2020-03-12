Imports System.data.SqlClient

Public Class CierreDiario
    Inherits Plantilla
    'Dim PMU As PerfilModulo_Class
    Dim Identificacion As String

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
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Cierre As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMonedaNombre1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCantidad As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetCierreDiario1 As Contabilidad.DataSetCierreDiario
    Friend WithEvents AdapterPuntoVenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Monto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDeposito As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents AdapterArqueo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterArqueoTarjeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterTipoTarjeta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterDepositoDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CuentasBancarias As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents AdapterDetalleTarjetas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCierreDiario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterDepositoCierre As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colCuentaBancaria As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterCuentaContable As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cuenta As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CuentaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection4 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CierreDiario))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DataSetCierreDiario1 = New Contabilidad.DataSetCierreDiario
        Me.Cierre = New System.Windows.Forms.GroupBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMonedaNombre1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCantidad = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuentaBancaria = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CuentasBancarias = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Monto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.CuentaContable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Cuenta = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterPuntoVenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.AdapterDeposito = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCuentas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.AdapterArqueo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection4 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdapterArqueoTarjeta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdapterTipoTarjeta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDepositoDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetalleTarjetas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCierreDiario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDepositoCierre = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.AdapterCuentaContable = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DataSetCierreDiario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Cierre.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentasBancarias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 465)
        Me.ToolBar1.Size = New System.Drawing.Size(672, 52)
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(672, 32)
        Me.TituloModulo.Text = "Cierre Diario"
        '
        'RadioButton1
        '
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton1.Location = New System.Drawing.Point(16, 8)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(88, 24)
        Me.RadioButton1.TabIndex = 59
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "General"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton2.Location = New System.Drawing.Point(128, 8)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(104, 24)
        Me.RadioButton2.TabIndex = 60
        Me.RadioButton2.Text = "Punto Venta"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(648, 40)
        Me.Panel1.TabIndex = 61
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(528, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(456, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Fecha"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetCierreDiario1, "CierreDiario.PuntoVenta", True))
        Me.ComboBox1.DataSource = Me.DataSetCierreDiario1
        Me.ComboBox1.DisplayMember = "PuntoVenta.Nombre"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.Location = New System.Drawing.Point(248, 8)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(192, 21)
        Me.ComboBox1.TabIndex = 61
        Me.ComboBox1.ValueMember = "PuntoVenta.IdPuntoVenta"
        '
        'DataSetCierreDiario1
        '
        Me.DataSetCierreDiario1.DataSetName = "DataSetCierreDiario"
        Me.DataSetCierreDiario1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetCierreDiario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cierre
        '
        Me.Cierre.Controls.Add(Me.GridControl1)
        Me.Cierre.Enabled = False
        Me.Cierre.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Cierre.Location = New System.Drawing.Point(0, 72)
        Me.Cierre.Name = "Cierre"
        Me.Cierre.Size = New System.Drawing.Size(648, 200)
        Me.Cierre.TabIndex = 62
        Me.Cierre.TabStop = False
        Me.Cierre.Text = "Detalle Cierre"
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "CierreDiario.CierreDiarioDepositoCierreDiario"
        Me.GridControl1.DataSource = Me.DataSetCierreDiario1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 24)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.CuentasBancarias, Me.Cuenta})
        Me.GridControl1.Size = New System.Drawing.Size(632, 168)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMonedaNombre1, Me.colCantidad, Me.colCuentaBancaria, Me.Monto, Me.colTotal, Me.CuentaContable})
        Me.GridView1.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colMonedaNombre1
        '
        Me.colMonedaNombre1.Caption = "Fecha"
        Me.colMonedaNombre1.FieldName = "Fecha"
        Me.colMonedaNombre1.FilterInfo = ColumnFilterInfo1
        Me.colMonedaNombre1.Name = "colMonedaNombre1"
        Me.colMonedaNombre1.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonedaNombre1.VisibleIndex = 0
        '
        'colCantidad
        '
        Me.colCantidad.Caption = "Documento"
        Me.colCantidad.DisplayFormat.FormatString = "#,#0.00"
        Me.colCantidad.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colCantidad.FieldName = "Documento"
        Me.colCantidad.FilterInfo = ColumnFilterInfo2
        Me.colCantidad.Name = "colCantidad"
        Me.colCantidad.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCantidad.StyleName = "Style1"
        Me.colCantidad.VisibleIndex = 1
        Me.colCantidad.Width = 80
        '
        'colCuentaBancaria
        '
        Me.colCuentaBancaria.Caption = "Cuenta Bancaria"
        Me.colCuentaBancaria.ColumnEdit = Me.CuentasBancarias
        Me.colCuentaBancaria.FieldName = "CuentaBancaria"
        Me.colCuentaBancaria.FilterInfo = ColumnFilterInfo3
        Me.colCuentaBancaria.Name = "colCuentaBancaria"
        Me.colCuentaBancaria.VisibleIndex = 2
        Me.colCuentaBancaria.Width = 169
        '
        'CuentasBancarias
        '
        Me.CuentasBancarias.AutoHeight = False
        Me.CuentasBancarias.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CuentasBancarias.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Cuenta", "Cuenta", 150, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreCuenta", "NombreCuenta", 220, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.CuentasBancarias.DataSource = Me.DataSetCierreDiario1.Cuentas_bancarias
        Me.CuentasBancarias.DisplayMember = "Cuenta"
        Me.CuentasBancarias.Name = "CuentasBancarias"
        Me.CuentasBancarias.NullString = ""
        Me.CuentasBancarias.ValueMember = "Id_CuentaBancaria"
        '
        'Monto
        '
        Me.Monto.Caption = "Monto"
        Me.Monto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Monto.FieldName = "Monto"
        Me.Monto.FilterInfo = ColumnFilterInfo4
        Me.Monto.Name = "Monto"
        Me.Monto.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.Monto.VisibleIndex = 3
        Me.Monto.Width = 80
        '
        'colTotal
        '
        Me.colTotal.Caption = "Moneda"
        Me.colTotal.FieldName = "Moneda"
        Me.colTotal.FilterInfo = ColumnFilterInfo5
        Me.colTotal.Name = "colTotal"
        Me.colTotal.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colTotal.VisibleIndex = 4
        Me.colTotal.Width = 90
        '
        'CuentaContable
        '
        Me.CuentaContable.Caption = "Cuenta Contable"
        Me.CuentaContable.ColumnEdit = Me.Cuenta
        Me.CuentaContable.FieldName = "CuentaContable"
        Me.CuentaContable.FilterInfo = ColumnFilterInfo6
        Me.CuentaContable.Name = "CuentaContable"
        Me.CuentaContable.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.CuentaContable.VisibleIndex = 5
        Me.CuentaContable.Width = 124
        '
        'Cuenta
        '
        Me.Cuenta.AutoHeight = False
        Me.Cuenta.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Cuenta.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaContable"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NombreCuenta")})
        Me.Cuenta.DataSource = Me.DataSetCierreDiario1.Cuentas_bancarias
        Me.Cuenta.DisplayMember = "CuentaContable"
        Me.Cuenta.Name = "Cuenta"
        Me.Cuenta.NullString = ""
        Me.Cuenta.ValueMember = "CuentaContable"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(8, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(768, 184)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=LUIFER;packet size=4096;integrated security=SSPI;initial catalog=H" & _
            "otel;persist security info=False"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'AdapterPuntoVenta
        '
        Me.AdapterPuntoVenta.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterPuntoVenta.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterPuntoVenta.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterPuntoVenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PuntoVenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdPuntoVenta", "IdPuntoVenta"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.AdapterPuntoVenta.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM PuntoVenta WHERE (IdPuntoVenta = @Original_IdPuntoVenta) AND (Nombre " & _
            "= @Original_Nombre) AND (Tipo = @Original_Tipo)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_IdPuntoVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO PuntoVenta(Nombre, Tipo) VALUES (@Nombre, @Tipo); SELECT IdPuntoVenta" & _
            ", Nombre, Tipo FROM PuntoVenta WHERE (IdPuntoVenta = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 300, "Nombre"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT IdPuntoVenta, Nombre, Tipo FROM PuntoVenta"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 300, "Nombre"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo"), New System.Data.SqlClient.SqlParameter("@Original_IdPuntoVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdPuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 300, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IdPuntoVenta", System.Data.SqlDbType.Int, 4, "IdPuntoVenta")})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=LUIFER;packet size=4096;integrated security=SSPI;data source=LUIFE" & _
            "R;persist security info=False;initial catalog=Bancos"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterDeposito
        '
        Me.AdapterDeposito.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterDeposito.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterDeposito.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterDeposito.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deposito", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito"), New System.Data.Common.DataColumnMapping("NumeroDocumento", "NumeroDocumento"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Concepto", "Concepto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Conciliado", "Conciliado"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion")})})
        Me.AdapterDeposito.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroDocumento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroDocumento", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection2
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumeroDocumento", System.Data.SqlDbType.BigInt, 8, "NumeroDocumento"), New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 250, "Concepto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id_Deposito, NumeroDocumento, Id_CuentaBancaria, Fecha, Monto, Concepto, A" & _
            "nulado, Conciliado, Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion FROM D" & _
            "eposito"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumeroDocumento", System.Data.SqlDbType.BigInt, 8, "NumeroDocumento"), New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 250, "Concepto"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.BigInt, 8, "Asiento"), New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"), New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumeroDocumento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroDocumento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.BigInt, 8, "Id_Deposito")})
        '
        'AdapterCuentas
        '
        Me.AdapterCuentas.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterCuentas.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterCuentas.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterCuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("SaldoInicial", "SaldoInicial"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("ChequeInicial", "ChequeInicial"), New System.Data.Common.DataColumnMapping("ChequeFinal", "ChequeFinal"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        Me.AdapterCuentas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequeFinal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequeFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequeInicial", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequeInicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoInicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoInicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoCuenta", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoCuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@SaldoInicial", System.Data.SqlDbType.Float, 8, "SaldoInicial"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 50, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@ChequeInicial", System.Data.SqlDbType.Int, 4, "ChequeInicial"), New System.Data.SqlClient.SqlParameter("@ChequeFinal", System.Data.SqlDbType.Int, 4, "ChequeFinal"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 350, "NombreCuentaContable")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Cuenta, Codigo_banco, tipoCuenta, NombreCuenta, SaldoInicial, CuentaContab" & _
            "le, ChequeInicial, ChequeFinal, Cod_Moneda, Id_CuentaBancaria, NombreCuentaConta" & _
            "ble FROM Cuentas_bancarias"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@SaldoInicial", System.Data.SqlDbType.Float, 8, "SaldoInicial"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 50, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@ChequeInicial", System.Data.SqlDbType.Int, 4, "ChequeInicial"), New System.Data.SqlClient.SqlParameter("@ChequeFinal", System.Data.SqlDbType.Int, 4, "ChequeFinal"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 350, "NombreCuentaContable"), New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequeFinal", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequeFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ChequeInicial", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ChequeInicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cod_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cod_Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Codigo_banco", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo_banco", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoInicial", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoInicial", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_tipoCuenta", System.Data.SqlDbType.VarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria")})
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.GridColumn2})
        Me.GridView2.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Monto"
        Me.GridColumn1.FieldName = "Monto"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo7
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 100
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Documento"
        Me.GridColumn5.DisplayFormat.FormatString = "#,#0"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Voucher"
        Me.GridColumn5.FilterInfo = ColumnFilterInfo8
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
        Me.GridColumn5.VisibleIndex = 0
        Me.GridColumn5.Width = 122
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo Tarjeta"
        Me.GridColumn2.FieldName = "TipoTarjeta"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo9
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 204
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridControl2)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(456, 168)
        Me.GroupBox2.TabIndex = 61
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Tarjetas de Crédito"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "DetalleTarjetasCredito"
        Me.GridControl2.DataSource = Me.DataSetCierreDiario1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 16)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(440, 144)
        Me.GridControl2.TabIndex = 12
        Me.GridControl2.Text = "GridControl2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TextEdit2)
        Me.GroupBox3.Controls.Add(Me.TextEdit1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Enabled = False
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(472, 288)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 168)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Tarjeta"
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreDiario1, "CierreDiario.TarjetaDolares", True))
        Me.TextEdit2.EditValue = "0.00"
        Me.TextEdit2.Location = New System.Drawing.Point(8, 120)
        Me.TextEdit2.Name = "TextEdit2"
        '
        '
        '
        Me.TextEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.ReadOnly = True
        Me.TextEdit2.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit2.Size = New System.Drawing.Size(152, 21)
        Me.TextEdit2.TabIndex = 44
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCierreDiario1, "CierreDiario.TarjetaColones", True))
        Me.TextEdit1.EditValue = "0.00"
        Me.TextEdit1.Location = New System.Drawing.Point(8, 56)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.ReadOnly = True
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit1.Size = New System.Drawing.Size(152, 21)
        Me.TextEdit1.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Dolares"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(8, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Colones"
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(440, 474)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 150
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(440, 490)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(200, 13)
        Me.txtNombreUsuario.TabIndex = 151
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.ForeColor = System.Drawing.Color.Blue
        Me.TextBox6.Location = New System.Drawing.Point(520, 474)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox6.Size = New System.Drawing.Size(120, 13)
        Me.TextBox6.TabIndex = 149
        '
        'AdapterArqueo
        '
        Me.AdapterArqueo.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterArqueo.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterArqueo.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterArqueo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoCajas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("EfectivoColones", "EfectivoColones"), New System.Data.Common.DataColumnMapping("EfectivoDolares", "EfectivoDolares"), New System.Data.Common.DataColumnMapping("TarjetaColones", "TarjetaColones"), New System.Data.Common.DataColumnMapping("TarjetaDolares", "TarjetaDolares"), New System.Data.Common.DataColumnMapping("TravelCheck", "TravelCheck"), New System.Data.Common.DataColumnMapping("Total", "Total"), New System.Data.Common.DataColumnMapping("IdApertura", "IdApertura"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Cajero", "Cajero"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado")})})
        Me.AdapterArqueo.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection4
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajero", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TravelCheck", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TravelCheck", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection4
        '
        Me.SqlConnection4.ConnectionString = "workstation id=SOFTWARE;packet size=4096;integrated security=SSPI;data source="".""" & _
            ";persist security info=False;initial catalog=Hotel"
        Me.SqlConnection4.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection4
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EfectivoColones", System.Data.SqlDbType.Float, 8, "EfectivoColones"), New System.Data.SqlClient.SqlParameter("@EfectivoDolares", System.Data.SqlDbType.Float, 8, "EfectivoDolares"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@TravelCheck", System.Data.SqlDbType.Float, 8, "TravelCheck"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@IdApertura", System.Data.SqlDbType.Int, 4, "IdApertura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cajero", System.Data.SqlDbType.VarChar, 100, "Cajero"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id, EfectivoColones, EfectivoDolares, TarjetaColones, TarjetaDolares, Trav" & _
            "elCheck, Total, IdApertura, Fecha, Cajero, Anulado FROM ArqueoCajas WHERE (Anula" & _
            "do = 0)"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection4
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection4
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@EfectivoColones", System.Data.SqlDbType.Float, 8, "EfectivoColones"), New System.Data.SqlClient.SqlParameter("@EfectivoDolares", System.Data.SqlDbType.Float, 8, "EfectivoDolares"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@TravelCheck", System.Data.SqlDbType.Float, 8, "TravelCheck"), New System.Data.SqlClient.SqlParameter("@Total", System.Data.SqlDbType.Float, 8, "Total"), New System.Data.SqlClient.SqlParameter("@IdApertura", System.Data.SqlDbType.Int, 4, "IdApertura"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Cajero", System.Data.SqlDbType.VarChar, 100, "Cajero"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cajero", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EfectivoDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EfectivoDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdApertura", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdApertura", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Total", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Total", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TravelCheck", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TravelCheck", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'AdapterArqueoTarjeta
        '
        Me.AdapterArqueoTarjeta.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterArqueoTarjeta.InsertCommand = Me.SqlInsertCommand6
        Me.AdapterArqueoTarjeta.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterArqueoTarjeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ArqueoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_Arqueo", "Id_Arqueo"), New System.Data.Common.DataColumnMapping("Id_Tarjeta", "Id_Tarjeta"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        Me.AdapterArqueoTarjeta.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM ArqueoTarjeta WHERE (Id = @Original_Id) AND (Id_Arqueo = @Original_Id" & _
            "_Arqueo) AND (Id_Tarjeta = @Original_Id_Tarjeta) AND (Monto = @Original_Monto)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Arqueo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Arqueo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Tarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Tarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO ArqueoTarjeta(Id_Arqueo, Id_Tarjeta, Monto) VALUES (@Id_Arqueo, @Id_T" & _
            "arjeta, @Monto); SELECT Id, Id_Arqueo, Id_Tarjeta, Monto FROM ArqueoTarjeta WHER" & _
            "E (Id = @@IDENTITY)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Arqueo", System.Data.SqlDbType.BigInt, 8, "Id_Arqueo"), New System.Data.SqlClient.SqlParameter("@Id_Tarjeta", System.Data.SqlDbType.Int, 4, "Id_Tarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Id, Id_Arqueo, Id_Tarjeta, Monto FROM ArqueoTarjeta"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Arqueo", System.Data.SqlDbType.BigInt, 8, "Id_Arqueo"), New System.Data.SqlClient.SqlParameter("@Id_Tarjeta", System.Data.SqlDbType.Int, 4, "Id_Tarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Arqueo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Arqueo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Tarjeta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Tarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'AdapterTipoTarjeta
        '
        Me.AdapterTipoTarjeta.DeleteCommand = Me.SqlDeleteCommand6
        Me.AdapterTipoTarjeta.InsertCommand = Me.SqlInsertCommand7
        Me.AdapterTipoTarjeta.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterTipoTarjeta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta")})})
        Me.AdapterTipoTarjeta.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = resources.GetString("SqlDeleteCommand6.CommandText")
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Id, Nombre, Moneda, Observaciones, CuentaContable, NombreCuenta FROM TipoT" & _
            "arjeta"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 4, "Moneda"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'AdapterDepositoDetalle
        '
        Me.AdapterDepositoDetalle.DeleteCommand = Me.SqlDeleteCommand7
        Me.AdapterDepositoDetalle.InsertCommand = Me.SqlInsertCommand8
        Me.AdapterDepositoDetalle.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterDepositoDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deposito_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DepositoDet", "Id_DepositoDet"), New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("DescripcionMov", "DescripcionMov"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta")})})
        Me.AdapterDepositoDetalle.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_DepositoDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DepositoDet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionMov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionMov", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = resources.GetString("SqlInsertCommand8.CommandText")
        Me.SqlInsertCommand8.Connection = Me.SqlConnection2
        Me.SqlInsertCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.BigInt, 8, "Id_Deposito"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@DescripcionMov", System.Data.SqlDbType.VarChar, 250, "DescripcionMov"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 350, "NombreCuenta")})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Id_DepositoDet, Id_Deposito, CuentaContable, DescripcionMov, Monto, Nombre" & _
            "Cuenta FROM Deposito_Detalle"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.BigInt, 8, "Id_Deposito"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@DescripcionMov", System.Data.SqlDbType.VarChar, 250, "DescripcionMov"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 350, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Original_Id_DepositoDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DepositoDet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionMov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionMov", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_DepositoDet", System.Data.SqlDbType.BigInt, 8, "Id_DepositoDet")})
        '
        'AdapterDetalleTarjetas
        '
        Me.AdapterDetalleTarjetas.DeleteCommand = Me.SqlDeleteCommand8
        Me.AdapterDetalleTarjetas.InsertCommand = Me.SqlInsertCommand9
        Me.AdapterDetalleTarjetas.SelectCommand = Me.SqlSelectCommand9
        Me.AdapterDetalleTarjetas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetalleTarjetasCredito", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Voucher", "Voucher"), New System.Data.Common.DataColumnMapping("TipoTarjeta", "TipoTarjeta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("IdCierreDiario", "IdCierreDiario")})})
        Me.AdapterDetalleTarjetas.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = resources.GetString("SqlDeleteCommand8.CommandText")
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoTarjeta", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoTarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Voucher", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Voucher", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = resources.GetString("SqlInsertCommand9.CommandText")
        Me.SqlInsertCommand9.Connection = Me.SqlConnection1
        Me.SqlInsertCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Voucher", System.Data.SqlDbType.BigInt, 8, "Voucher"), New System.Data.SqlClient.SqlParameter("@TipoTarjeta", System.Data.SqlDbType.VarChar, 50, "TipoTarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@IdCierreDiario", System.Data.SqlDbType.Int, 4, "IdCierreDiario")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id, Voucher, TipoTarjeta, Monto, IdCierreDiario FROM DetalleTarjetasCredit" & _
            "o"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = resources.GetString("SqlUpdateCommand8.CommandText")
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Voucher", System.Data.SqlDbType.BigInt, 8, "Voucher"), New System.Data.SqlClient.SqlParameter("@TipoTarjeta", System.Data.SqlDbType.VarChar, 50, "TipoTarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@IdCierreDiario", System.Data.SqlDbType.Int, 4, "IdCierreDiario"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoTarjeta", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoTarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Voucher", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Voucher", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'AdapterCierreDiario
        '
        Me.AdapterCierreDiario.DeleteCommand = Me.SqlDeleteCommand9
        Me.AdapterCierreDiario.InsertCommand = Me.SqlInsertCommand10
        Me.AdapterCierreDiario.SelectCommand = Me.SqlSelectCommand10
        Me.AdapterCierreDiario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreDiario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("PuntoVenta", "PuntoVenta"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("TarjetaColones", "TarjetaColones"), New System.Data.Common.DataColumnMapping("TarjetaDolares", "TarjetaDolares"), New System.Data.Common.DataColumnMapping("Id_Usuario", "Id_Usuario")})})
        Me.AdapterCierreDiario.UpdateCommand = Me.SqlUpdateCommand9
        '
        'SqlDeleteCommand9
        '
        Me.SqlDeleteCommand9.CommandText = resources.GetString("SqlDeleteCommand9.CommandText")
        Me.SqlDeleteCommand9.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PuntoVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand10
        '
        Me.SqlInsertCommand10.CommandText = resources.GetString("SqlInsertCommand10.CommandText")
        Me.SqlInsertCommand10.Connection = Me.SqlConnection1
        Me.SqlInsertCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@PuntoVenta", System.Data.SqlDbType.Int, 4, "PuntoVenta"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Bit, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario")})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Id, Fecha, PuntoVenta, Tipo, TarjetaColones, TarjetaDolares, Id_Usuario FR" & _
            "OM CierreDiario"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand9
        '
        Me.SqlUpdateCommand9.CommandText = resources.GetString("SqlUpdateCommand9.CommandText")
        Me.SqlUpdateCommand9.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@PuntoVenta", System.Data.SqlDbType.Int, 4, "PuntoVenta"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Bit, 1, "Tipo"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@Id_Usuario", System.Data.SqlDbType.VarChar, 50, "Id_Usuario"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PuntoVenta", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PuntoVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'AdapterDepositoCierre
        '
        Me.AdapterDepositoCierre.DeleteCommand = Me.SqlDeleteCommand10
        Me.AdapterDepositoCierre.InsertCommand = Me.SqlInsertCommand11
        Me.AdapterDepositoCierre.SelectCommand = Me.SqlSelectCommand11
        Me.AdapterDepositoCierre.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DepositoCierreDiario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("CuentaBancaria", "CuentaBancaria"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("IdCierreDiario", "IdCierreDiario"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable")})})
        Me.AdapterDepositoCierre.UpdateCommand = Me.SqlUpdateCommand10
        '
        'SqlDeleteCommand10
        '
        Me.SqlDeleteCommand10.CommandText = resources.GetString("SqlDeleteCommand10.CommandText")
        Me.SqlDeleteCommand10.Connection = Me.SqlConnection4
        Me.SqlDeleteCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand11
        '
        Me.SqlInsertCommand11.CommandText = resources.GetString("SqlInsertCommand11.CommandText")
        Me.SqlInsertCommand11.Connection = Me.SqlConnection4
        Me.SqlInsertCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.Float, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.Int, 4, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.VarChar, 50, "Moneda"), New System.Data.SqlClient.SqlParameter("@IdCierreDiario", System.Data.SqlDbType.Int, 4, "IdCierreDiario"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable")})
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Id, Fecha, Documento, CuentaBancaria, Monto, Moneda, IdCierreDiario, Cuent" & _
            "aContable FROM DepositoCierreDiario"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection4
        '
        'SqlUpdateCommand10
        '
        Me.SqlUpdateCommand10.CommandText = resources.GetString("SqlUpdateCommand10.CommandText")
        Me.SqlUpdateCommand10.Connection = Me.SqlConnection4
        Me.SqlUpdateCommand10.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.Float, 8, "Documento"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.Int, 4, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.VarChar, 50, "Moneda"), New System.Data.SqlClient.SqlParameter("@IdCierreDiario", System.Data.SqlDbType.Int, 4, "IdCierreDiario"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=LUIFER;packet size=4096;integrated security=SSPI;data source=LUIFE" & _
            "R;persist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterCuentaContable
        '
        Me.AdapterCuentaContable.DeleteCommand = Me.SqlDeleteCommand11
        Me.AdapterCuentaContable.InsertCommand = Me.SqlInsertCommand12
        Me.AdapterCuentaContable.SelectCommand = Me.SqlSelectCommand12
        Me.AdapterCuentaContable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.AdapterCuentaContable.UpdateCommand = Me.SqlUpdateCommand11
        '
        'SqlDeleteCommand11
        '
        Me.SqlDeleteCommand11.CommandText = "DELETE FROM CuentaContable WHERE (CuentaContable = @Original_CuentaContable) AND " & _
            "(Descripcion = @Original_Descripcion)"
        Me.SqlDeleteCommand11.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand12
        '
        Me.SqlInsertCommand12.CommandText = "INSERT INTO CuentaContable(CuentaContable, Descripcion) VALUES (@CuentaContable, " & _
            "@Descripcion); SELECT CuentaContable, Descripcion FROM CuentaContable WHERE (Cue" & _
            "ntaContable = @CuentaContable)"
        Me.SqlInsertCommand12.Connection = Me.SqlConnection3
        Me.SqlInsertCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion")})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT CuentaContable, Descripcion FROM CuentaContable"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand11
        '
        Me.SqlUpdateCommand11.CommandText = resources.GetString("SqlUpdateCommand11.CommandText")
        Me.SqlUpdateCommand11.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'CierreDiario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(672, 517)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Cierre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "CierreDiario"
        Me.Text = "Cierre Diario"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Cierre, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.TextBox6, 0)
        Me.Controls.SetChildIndex(Me.txtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataSetCierreDiario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Cierre.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentasBancarias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub CierreDiario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Hotel")
        Me.SqlConnection2.ConnectionString = Configuracion.Claves.Conexion("Bancos")
        Me.SqlConnection3.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        Me.AdapterPuntoVenta.Fill(Me.DataSetCierreDiario1.PuntoVenta)
        Me.AdapterArqueoTarjeta.Fill(Me.DataSetCierreDiario1, "ArqueoTarjeta")
        Me.AdapterTipoTarjeta.Fill(Me.DataSetCierreDiario1.TipoTarjeta)
        Me.AdapterCuentas.Fill(Me.DataSetCierreDiario1.Cuentas_bancarias)
        Me.AdapterMoneda.Fill(Me.DataSetCierreDiario1.Moneda)
        Me.AdapterCuentaContable.Fill(Me.DataSetCierreDiario1.CuentaContable)

        ValoresDefecto()
    End Sub

    Function ValoresDefecto()
        Me.DataSetCierreDiario1.CierreDiario.FechaColumn.DefaultValue = Date.Today
        Me.DataSetCierreDiario1.CierreDiario.PuntoVentaColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.CierreDiario.Id_UsuarioColumn.DefaultValue = "0"
        Me.DataSetCierreDiario1.CierreDiario.TarjetaColonesColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.CierreDiario.TarjetaDolaresColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.CierreDiario.TipoColumn.DefaultValue = True
        Me.DataSetCierreDiario1.DepositoCierreDiario.FechaColumn.DefaultValue = Date.Today
        Me.DataSetCierreDiario1.DepositoCierreDiario.DocumentoColumn.DefaultValue = 1
        Me.DataSetCierreDiario1.DepositoCierreDiario.CuentaBancariaColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.DepositoCierreDiario.MontoColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.DepositoCierreDiario.MonedaColumn.DefaultValue = ""
        Me.DataSetCierreDiario1.DetalleTarjetasCredito.VoucherColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.DetalleTarjetasCredito.VoucherColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.DetalleTarjetasCredito.TipoTarjetaColumn.DefaultValue = 0
        Me.DataSetCierreDiario1.DetalleTarjetasCredito.MontoColumn.DefaultValue = 0

    End Function

    Private Sub TextBox6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If TextBox6.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "select id_Usuario,Nombre from seguridad.dbo.usuarios where Clave_Interna ='" & TextBox6.Text & "'")
                'If rs.HasRows = False Then
                '    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                '    TextBox6.Text = ""
                '    TextBox6.Focus()
                'End If
                While rs.Read

                    Try
                        'PMU = VSM(rs("Cedula"), Me.Name) 'Carga los privilegios del usuario con el modulo 
                        'If Not PMU.Execute Then MsgBox("No tiene permiso ejecutar el módulo " & Me.Text, MsgBoxStyle.Information, "Atención...") : Exit Sub

                        'Me.BindingContext(Me.AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
                        'Me.BindingContext(Me.AjusteCxC1, "ajustesccobrar").AddNew()
                        'Me.txtNum_Ajuste.Text = Numero_de_Ajuste()
                        txtNombreUsuario.Text = rs("Nombre")
                        Identificacion = rs("id_Usuario")

                        'If rs("AnuAjustecCobrar") = 1 Then Anular = True Else Anular = False
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        TextBox6.Enabled = False ' se inabilita el campo de la contraseña

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                TextBox6.Focus()
            End If
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            ComboBox1.Enabled = False

        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            ComboBox1.Enabled = True

        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            DataSetCierreDiario1.DetalleTarjetasCredito.Clear()
            CargarCierreDiario()
        End If
    End Sub

    Function CargarCierreDiario()
        Dim cFunciones As New cFunciones
        Dim Fecha As Date
        Dim IdArqueo, j, i, k As Integer
        'Me.DataSetCierreDiario1.ArqueoTarjeta.Clear()
        'Me.DataSetCierreDiario1.ArqueoCajas.Clear()
        Fecha = Me.DateTimePicker1.Value.ToShortDateString
        cFunciones.Llenar_Tabla_Generico("Select * from ArqueoCajas Where Anulado = 0 and Fecha = '" & Fecha & "'", Me.DataSetCierreDiario1.ArqueoCajas, SqlConnection1.ConnectionString)

        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").AddNew()

        If RadioButton1.Checked = True Then
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("Tipo") = True
        Else
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("Tipo") = False
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("PuntoVenta") = Me.BindingContext(Me.DataSetCierreDiario1.PuntoVenta).Current("IdPuntoVenta")
        End If

        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("TarjetaColones") = 0
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("TarjetaDolares") = 0
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("Fecha") = Fecha
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("Id_Usuario") = Me.Identificacion
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").EndCurrentEdit()
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").CancelCurrentEdit()
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").CancelCurrentEdit()

        For j = 0 To Me.DataSetCierreDiario1.Moneda.Rows.Count - 1
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").AddNew()
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Fecha") = Fecha
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Documento") = 0
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("CuentaBancaria") = Me.BindingContext(Me.DataSetCierreDiario1.Cuentas_bancarias).Current("Id_CuentaBancaria")
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("CuentaContable") = Me.BindingContext(Me.DataSetCierreDiario1.Cuentas_bancarias).Current("CuentaContable")
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Monto") = 0
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Moneda") = Me.DataSetCierreDiario1.Moneda.Rows(j).Item("MonedaNombre")
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").EndCurrentEdit()
        Next

        For j = 0 To Me.DataSetCierreDiario1.TipoTarjeta.Rows.Count - 1
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").AddNew()
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").Current("Voucher") = 0
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").Current("TipoTarjeta") = " "
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").Current("Monto") = 0
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").EndCurrentEdit()
        Next
        For j = 0 To Me.DataSetCierreDiario1.ArqueoCajas.Rows.Count - 1
            For i = 0 To Me.DataSetCierreDiario1.ArqueoTarjeta.Rows.Count - 1
                If Me.DataSetCierreDiario1.ArqueoTarjeta.Rows(i).Item("Id_Arqueo") = Me.DataSetCierreDiario1.ArqueoCajas.Rows(j).Item("Id") Then
                    For k = 0 To Me.DataSetCierreDiario1.TipoTarjeta.Rows.Count - 1
                        If Me.DataSetCierreDiario1.ArqueoTarjeta.Rows(i).Item("Id_Tarjeta") = Me.DataSetCierreDiario1.TipoTarjeta.Rows(k).Item("Id") Then
                            If Me.DataSetCierreDiario1.DetalleTarjetasCredito.Rows(k).Item("Monto") <> 0 Then
                                Me.DataSetCierreDiario1.DetalleTarjetasCredito.Rows(k).Item("Voucher") = Me.DataSetCierreDiario1.DetalleTarjetasCredito.Rows(k).Item("Voucher") + 1
                            End If
                            Me.DataSetCierreDiario1.DetalleTarjetasCredito.Rows(k).Item("TipoTarjeta") = Me.DataSetCierreDiario1.TipoTarjeta.Rows(k).Item("Nombre")
                            Me.DataSetCierreDiario1.DetalleTarjetasCredito.Rows(k).Item("Monto") += Me.DataSetCierreDiario1.ArqueoTarjeta.Rows(i).Item("Monto")
                        End If
                    Next
                End If
            Next
            Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(0).Item("Monto") += Me.DataSetCierreDiario1.ArqueoCajas.Rows(j).Item("EfectivoColones")
            Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(1).Item("Monto") += Me.DataSetCierreDiario1.ArqueoCajas.Rows(j).Item("EfectivoDolares")
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("TarjetaColones") += Me.DataSetCierreDiario1.ArqueoCajas.Rows(j).Item("TarjetaColones")
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("TarjetaDolares") += Me.DataSetCierreDiario1.ArqueoCajas.Rows(j).Item("TarjetaDolares")
            Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").EndCurrentEdit()
        Next


        TextEdit1.EditValue = Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("TarjetaColones")
        TextEdit2.EditValue = Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("TarjetaDolares")
    End Function

 

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Me.Nuevo()
            Case 2 : Me.Buscar()
            Case 3 : Me.Registrar()

            Case 5 : Me.Imprimir()
                '  Case 6 : Me.Anular()
            Case 7 : Me.Close()
        End Select
    End Sub
    Function Nuevo()
        If Me.ToolBarNuevo.Text = "Nuevo" Then 'n si ya hay un registropendiente por agregar
            Try 'inicia la edicion
                'Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").CancelCurrentEdit()
                ' Me.BindingContext(Me.DataSetCierreDiario1.DetalleTarjetasCredito).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetCierreDiario1.CierreDiario).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetCierreDiario1.CierreDiario).AddNew()
                ' Me.BindingContext(Me.DataSetCierreDiario1, "DetalleTarjetasCredito").AddNew()
                ' Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").AddNew()
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.ToolBarNuevo.ImageIndex = 8

                ' Me.GridControl1.Enabled = False

                'Me.ToolBarEditar.Enabled = False
                'Me.ToolBarBuscar.Enabled = False
                'Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True

                Habilitar()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").CancelCurrentEdit()
                'Me.BindingContext(Me.DataSetCierreDiario1.DetalleTarjetasCredito).CancelCurrentEdit()
                Me.BindingContext(Me.DataSetCierreDiario1.CierreDiario).CancelCurrentEdit()

                Me.ToolBarNuevo.Text = "Nuevo"
                Me.ToolBarNuevo.ImageIndex = 0
                '  Me.GridControl1.Enabled = True


                '  Me.ToolBarEditar.Enabled = True
                'Me.ToolBarBuscar.Enabled = True
                'Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False

                Me.inhabilitar()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If

    End Function
    Function Validar()
        Return True
    End Function
    Function Buscar()

    End Function
    Function EfectuarDeposito()
        Dim j As Integer
        If Me.SqlConnection2.State <> Me.SqlConnection2.State.Open Then Me.SqlConnection2.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection2.BeginTransaction
        Try
            For j = 0 To Me.DataSetCierreDiario1.DepositoCierreDiario.Rows.Count - 1
                If Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("Monto") > 0 Then
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").AddNew()
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("NumeroDocumento") = Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("Documento")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Id_CuentaBancaria") = Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("CuentaBancaria")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Fecha") = Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("Fecha")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Monto") = Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("Monto")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Concepto") = "CIERRE DIARIO"
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Anulado") = 0
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Conciliado") = 0
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Contabilizado") = 0
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Ced_Usuario") = Me.Identificacion
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Asiento") = 0
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").Current("Num_Conciliacion") = 0
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito.DepositoDeposito_Detalle").AddNew()
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito.DepositoDeposito_Detalle").Current("CuentaContable") = Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("CuentaContable")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito.DepositoDeposito_Detalle").Current("DescripcionMov") = "CIERRE DIARIO"
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito.DepositoDeposito_Detalle").Current("Monto") = Me.DataSetCierreDiario1.DepositoCierreDiario.Rows(j).Item("Monto")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito.DepositoDeposito_Detalle").Current("NombreCuenta") = Me.BindingContext(Me.DataSetCierreDiario1, "CuentaContable").Current("Descripcion")
                    Me.BindingContext(Me.DataSetCierreDiario1, "Deposito.DepositoDeposito_Detalle").EndCurrentEdit()
                End If                
            Next


            'Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").EndCurrentEdit()
            'Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").EndCurrentEdit()
            ' Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").EndCurrentEdit()
            Me.AdapterDeposito.InsertCommand.Transaction = Trans
            Me.AdapterDepositoDetalle.InsertCommand.Transaction = Trans

            Me.AdapterDeposito.UpdateCommand.Transaction = Trans
            Me.AdapterDepositoDetalle.UpdateCommand.Transaction = Trans

            Me.AdapterDeposito.Update(Me.DataSetCierreDiario1, "Deposito")
            Me.AdapterDepositoDetalle.Update(Me.DataSetCierreDiario1, "Deposito_Detalle")

            Trans.Commit()
            'Para boton Nuevo

        Catch eEndEdit As System.Data.NoNullAllowedException
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try

    End Function
    Function Registrar()
        Dim resp As Integer
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        If Validar() Then
            resp = MessageBox.Show("¿Deseas Guardar los cambios?", "Hotel", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Try

                    Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").EndCurrentEdit()
                    Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDetalleTarjetasCredito").EndCurrentEdit()
                    Me.AdapterCierreDiario.InsertCommand.Transaction = Trans
                    Me.AdapterDepositoCierre.InsertCommand.Transaction = Trans
                    Me.AdapterDetalleTarjetas.InsertCommand.Transaction = Trans
                    Me.AdapterCierreDiario.UpdateCommand.Transaction = Trans
                    Me.AdapterDetalleTarjetas.UpdateCommand.Transaction = Trans
                    Me.AdapterDepositoDetalle.UpdateCommand.Transaction = Trans
                    Me.AdapterCierreDiario.Update(Me.DataSetCierreDiario1, "CierreDiario")
                    Me.AdapterDepositoCierre.Update(Me.DataSetCierreDiario1, "DepositoCierreDiario")
                    Me.AdapterDetalleTarjetas.Update(Me.DataSetCierreDiario1, "DetalleTarjetasCredito")
                    EfectuarDeposito()
                    Trans.Commit()
                    'Para boton Nuevo
                    Me.ToolBarNuevo.Text = "Nuevo"
                    Me.ToolBarNuevo.ImageIndex = 0
                    'Para boton Acualizar
                    Me.ToolBarRegistrar.Enabled = False
                    Me.ToolBarEliminar.ImageIndex = 5
                    '  Me.GridControl1.Enabled = True
                    Me.inhabilitar()
                    MsgBox("Datos Ingresados Satisfactoriamente....", MsgBoxStyle.Information, "Atención...")

                    Me.Imprimir()

                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
            Else
                Me.BindingContext(Me.DataSetCierreDiario1.CierreDiario).CancelCurrentEdit()
                Me.DataSetCierreDiario1.RejectChanges()
                'Para boton Nuevo
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                'Para boton Acualizar
                Me.ToolBarEliminar.Text = "Editar"
                Me.ToolBarEliminar.ImageIndex = 5
                Me.inhabilitar()
                'CancelarErrorProvider()
                'Me.ToolBarNuevo.Enabled = True
                'Me.ToolBarEditar.Enabled = True
                'Me.ToolBarBuscar.Enabled = True
                'Me.ToolBarEliminar.Enabled = True
                'Me.ToolBarRegistrar.Enabled = False
            End If
        Else
            MsgBox("Debes Ingresar Campos....", MsgBoxStyle.Information, "Atención...")

        End If
    End Function
    Function Imprimir()
        'Try
        '    Dim RptCierreDiario As New RptCierreDiario
        '    Dim visor As New frmVisorReportes
        '    visor.MdiParent = Me.ParentForm
        '    CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, RptCierreDiario)
        '    RptCierreDiario.SetParameterValue(0, Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario").Current("Id"))
        '    visor.Show()
        'Catch ex As SystemException
        '    MsgBox(ex.Message)
        'End Try
    End Function
    Function Habilitar()
        Panel1.Enabled = True
        Cierre.Enabled = True
        GroupBox2.Enabled = True
        GroupBox3.Enabled = True
    End Function
    Function inhabilitar()
        Panel1.Enabled = False
        Cierre.Enabled = False
        GroupBox2.Enabled = False
        GroupBox3.Enabled = False
    End Function


    Private Sub GridControl1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridControl1.DoubleClick
        Dim fecha As Date
        fecha = Me.DateTimePicker1.Value.ToShortDateString

        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").AddNew()
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Fecha") = fecha
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Documento") = 0
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("CuentaBancaria") = Me.BindingContext(Me.DataSetCierreDiario1.Cuentas_bancarias).Current("Id_CuentaBancaria")
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("CuentaContable") = Me.BindingContext(Me.DataSetCierreDiario1.Cuentas_bancarias).Current("CuentaContable")
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Monto") = 0
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Current("Moneda") = Me.DataSetCierreDiario1.Moneda.Rows(0).Item("MonedaNombre")
        Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").EndCurrentEdit()
    End Sub

    Private Sub GridControl1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl1.KeyDown

        If e.KeyValue = 46 Then
            If MessageBox.Show("Desea eliminar esta linea", "", MessageBoxButtons.YesNo) Then
                Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").RemoveAt(Me.BindingContext(Me.DataSetCierreDiario1, "CierreDiario.CierreDiarioDepositoCierreDiario").Position)
            End If
        End If

    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class
