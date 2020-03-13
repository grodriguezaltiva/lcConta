Imports System.Drawing
Imports System.Data.SqlClient
Imports Utilidades

Public Class frmDepositos
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim usuario As New Usuario_Logeado
    Dim usua As Object
    Dim a, cuenta As String
    Dim Conta As Integer
    Dim i As Integer
    Public EditaAsiento As Boolean = False
    Public EditaCentro As Boolean = False
    Public id_deposito As String
    Dim FechaCon As DateTime
    Public cuentabancaria As String
    Public modificar As Boolean = False
    Public desdeConciliacion As Boolean = False
    Public nuevoMonto, TotalCentro As Double
    Public CedulaUsuario As String = ""
    Dim Conciliacion As Boolean
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents daCuentasbancarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsDepositos As BancosySucursales.dsDepositos
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents dgDeposito As DevExpress.XtraGrid.GridControl
    Friend WithEvents daCuentacontable As System.Data.SqlClient.SqlDataAdapter
    'Friend WithEvents daUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colCuentaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcionMov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtNumerodeposito As System.Windows.Forms.TextBox
    Friend WithEvents daUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cbobanco As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cboBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CalcEdit2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Anular As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents daDeposito As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daDeposito_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents balanceo As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEditar2 As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtNumConciliacion As System.Windows.Forms.Label
    Friend WithEvents ckConciliado As System.Windows.Forms.CheckBox
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents BCentroCosto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCentroCosto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCentroCostoMovimiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents PanelCentroCosto As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents BotonCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCentroCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents ButtonAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditDescripcionCC As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CBCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoCentroCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDepositos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit
        Me.DsDepositos = New BancosySucursales.dsDepositos
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit
        Me.cboBancos = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cboCuenta = New System.Windows.Forms.ComboBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cbobanco = New System.Windows.Forms.ComboBox
        Me.txtNumerodeposito = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.Anular = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtNumConciliacion = New System.Windows.Forms.Label
        Me.ckConciliado = New System.Windows.Forms.CheckBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.balanceo = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtCuenta = New System.Windows.Forms.TextBox
        Me.CalcEdit2 = New DevExpress.XtraEditors.CalcEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BCentroCosto = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgDeposito = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCuentaContable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcionMov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.daCuentasbancarias = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daCuentacontable = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.daUsuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Label48 = New System.Windows.Forms.Label
        Me.TxtCodUsuario = New System.Windows.Forms.TextBox
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.daDeposito = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daDeposito_Detalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Moneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEditar2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.AdapterCentroCosto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCentroCostoMovimiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.PanelCentroCosto = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.BNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.TxtDetalle = New System.Windows.Forms.TextBox
        Me.BotonCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.GridCentroCosto = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonAgregarDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.EditDescripcionCC = New DevExpress.XtraEditors.MemoExEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CBCentroCosto = New System.Windows.Forms.ComboBox
        Me.txtMontoCentroCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCentroCosto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditDescripcionCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CalcEdit1)
        Me.GroupBox1.Controls.Add(Me.cboBancos)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cboCuenta)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cbobanco)
        Me.GroupBox1.Controls.Add(Me.txtNumerodeposito)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(592, 136)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depósito"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsDepositos, "Deposito.TipoCambio"))
        Me.txtTipoCambio.EditValue = ""
        Me.txtTipoCambio.Location = New System.Drawing.Point(8, 112)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        '
        'txtTipoCambio.Properties
        '
        Me.txtTipoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTipoCambio.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtTipoCambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTipoCambio.Size = New System.Drawing.Size(96, 22)
        Me.txtTipoCambio.TabIndex = 207
        '
        'DsDepositos
        '
        Me.DsDepositos.DataSetName = "dsDepositos"
        Me.DsDepositos.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label23
        '
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(8, 96)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(96, 16)
        Me.Label23.TabIndex = 206
        Me.Label23.Text = "Tipo Cambio"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(320, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 16)
        Me.Label15.TabIndex = 204
        Me.Label15.Text = "Tipo"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(320, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 20)
        Me.Label16.TabIndex = 205
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Location = New System.Drawing.Point(456, 32)
        Me.CalcEdit1.Name = "CalcEdit1"
        '
        'CalcEdit1.Properties
        '
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.CalcEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CalcEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CalcEdit1.Size = New System.Drawing.Size(128, 19)
        Me.CalcEdit1.TabIndex = 124
        '
        'cboBancos
        '
        Me.cboBancos.DataSource = Me.DsDepositos
        Me.cboBancos.DisplayMember = "Cuentas_bancarias.Cuenta"
        Me.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBancos.Location = New System.Drawing.Point(8, 32)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.Size = New System.Drawing.Size(224, 21)
        Me.cboBancos.TabIndex = 1
        Me.cboBancos.ValueMember = "Cuentas_bancarias.Id_CuentaBancaria"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(8, 264)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(152, 64)
        Me.Button2.TabIndex = 121
        Me.Button2.Text = "Nuevo detalle"
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(464, -98)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 98)
        Me.Label13.TabIndex = 114
        Me.Label13.Text = "Nombre Cuenta"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(464, -74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 74)
        Me.Label14.TabIndex = 115
        Me.Label14.Text = "Nombre Cuenta"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCuenta
        '
        Me.cboCuenta.DisplayMember = "Bancos.BancosCuentas_bancarias.Cuenta"
        Me.cboCuenta.Enabled = False
        Me.cboCuenta.Location = New System.Drawing.Point(248, -78)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(200, 21)
        Me.cboCuenta.TabIndex = 113
        Me.cboCuenta.ValueMember = "Bancos.BancosCuentas_bancarias.Cuenta"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(8, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 64)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Nuevo detalle"
        '
        'cbobanco
        '
        Me.cbobanco.DisplayMember = "Bancos.Descripcion"
        Me.cbobanco.Enabled = False
        Me.cbobanco.Location = New System.Drawing.Point(8, -78)
        Me.cbobanco.Name = "cbobanco"
        Me.cbobanco.Size = New System.Drawing.Size(216, 21)
        Me.cbobanco.TabIndex = 112
        Me.cbobanco.ValueMember = "Bancos.Codigo_banco"
        '
        'txtNumerodeposito
        '
        Me.txtNumerodeposito.Location = New System.Drawing.Point(240, 32)
        Me.txtNumerodeposito.Name = "txtNumerodeposito"
        Me.txtNumerodeposito.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumerodeposito.Size = New System.Drawing.Size(104, 20)
        Me.txtNumerodeposito.TabIndex = 3
        Me.txtNumerodeposito.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(352, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(456, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Monto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(224, 16)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Cuenta Bancaria"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(352, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(240, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Número depósito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 112)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(472, 20)
        Me.txtObservaciones.TabIndex = 7
        Me.txtObservaciones.Text = ""
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(472, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Observaciones"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label20.Location = New System.Drawing.Point(8, 72)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 20)
        Me.Label20.TabIndex = 201
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 56)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(200, 16)
        Me.Label21.TabIndex = 200
        Me.Label21.Text = "Banco"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(216, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 202
        Me.Label19.Text = "Moneda"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(216, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 203
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(432, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(152, 16)
        Me.Label22.TabIndex = 198
        Me.Label22.Text = "Saldo Cuenta"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsDepositos, "Cuentas_bancarias.Saldo"))
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(432, 72)
        Me.TextEdit1.Name = "TextEdit1"
        '
        'TextEdit1.Properties
        '
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Enabled = False
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextEdit1.Size = New System.Drawing.Size(152, 22)
        Me.TextEdit1.TabIndex = 200
        '
        'Anular
        '
        Me.Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anular.ForeColor = System.Drawing.Color.Red
        Me.Anular.Location = New System.Drawing.Point(120, 120)
        Me.Anular.Name = "Anular"
        Me.Anular.Size = New System.Drawing.Size(320, 96)
        Me.Anular.TabIndex = 50
        Me.Anular.Text = "Anulado"
        Me.Anular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Anular.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNumConciliacion)
        Me.GroupBox4.Controls.Add(Me.ckConciliado)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.balanceo)
        Me.GroupBox4.Controls.Add(Me.Anular)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.TxtCuenta)
        Me.GroupBox4.Controls.Add(Me.CalcEdit2)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dgDeposito)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(592, 272)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle del Depósito"
        '
        'txtNumConciliacion
        '
        Me.txtNumConciliacion.Enabled = False
        Me.txtNumConciliacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumConciliacion.Location = New System.Drawing.Point(99, 248)
        Me.txtNumConciliacion.Name = "txtNumConciliacion"
        Me.txtNumConciliacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumConciliacion.Size = New System.Drawing.Size(32, 16)
        Me.txtNumConciliacion.TabIndex = 205
        '
        'ckConciliado
        '
        Me.ckConciliado.Enabled = False
        Me.ckConciliado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConciliado.Location = New System.Drawing.Point(8, 248)
        Me.ckConciliado.Name = "ckConciliado"
        Me.ckConciliado.Size = New System.Drawing.Size(88, 16)
        Me.ckConciliado.TabIndex = 204
        Me.ckConciliado.Text = "Conciliado"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(464, 248)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.TabIndex = 203
        Me.TextBox1.Text = ""
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(416, 248)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 16)
        Me.Label12.TabIndex = 202
        Me.Label12.Text = "Dif.:"
        '
        'balanceo
        '
        Me.balanceo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceo.Location = New System.Drawing.Point(304, 248)
        Me.balanceo.Name = "balanceo"
        Me.balanceo.Size = New System.Drawing.Size(100, 16)
        Me.balanceo.TabIndex = 200
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Deposito.DepositoDeposito_Detalle.NombreCuenta"))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(384, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(200, 20)
        Me.Label10.TabIndex = 199
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCuenta
        '
        Me.TxtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Deposito.DepositoDeposito_Detalle.CuentaContable"))
        Me.TxtCuenta.Location = New System.Drawing.Point(264, 76)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(120, 20)
        Me.TxtCuenta.TabIndex = 198
        Me.TxtCuenta.Text = ""
        '
        'CalcEdit2
        '
        Me.CalcEdit2.Location = New System.Drawing.Point(440, 34)
        Me.CalcEdit2.Name = "CalcEdit2"
        '
        'CalcEdit2.Properties
        '
        Me.CalcEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.CalcEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CalcEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CalcEdit2.Size = New System.Drawing.Size(136, 19)
        Me.CalcEdit2.TabIndex = 125
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(440, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Monto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(8, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(416, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Descripción General"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Location = New System.Drawing.Point(8, 34)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(416, 20)
        Me.txtDescripcion.TabIndex = 9
        Me.txtDescripcion.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BCentroCosto)
        Me.Panel1.Controls.Add(Me.SimpleEliminar)
        Me.Panel1.Controls.Add(Me.SimpleNuevo)
        Me.Panel1.Controls.Add(Me.SimpleGuardar)
        Me.Panel1.Location = New System.Drawing.Point(8, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 52)
        Me.Panel1.TabIndex = 197
        '
        'BCentroCosto
        '
        Me.BCentroCosto.Location = New System.Drawing.Point(80, 0)
        Me.BCentroCosto.Name = "BCentroCosto"
        Me.BCentroCosto.Size = New System.Drawing.Size(160, 23)
        Me.BCentroCosto.TabIndex = 68
        Me.BCentroCosto.Text = "Centro Costo"
        '
        'SimpleEliminar
        '
        Me.SimpleEliminar.Location = New System.Drawing.Point(160, 24)
        Me.SimpleEliminar.Name = "SimpleEliminar"
        Me.SimpleEliminar.TabIndex = 67
        Me.SimpleEliminar.Text = "Eliminar"
        '
        'SimpleNuevo
        '
        Me.SimpleNuevo.Location = New System.Drawing.Point(0, 24)
        Me.SimpleNuevo.Name = "SimpleNuevo"
        Me.SimpleNuevo.TabIndex = 65
        Me.SimpleNuevo.Text = "Nuevo"
        '
        'SimpleGuardar
        '
        Me.SimpleGuardar.Location = New System.Drawing.Point(80, 24)
        Me.SimpleGuardar.Name = "SimpleGuardar"
        Me.SimpleGuardar.TabIndex = 64
        Me.SimpleGuardar.Text = "Guardar"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(264, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(320, 16)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Cuenta Contable"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgDeposito
        '
        Me.dgDeposito.DataMember = "Deposito.DepositoDeposito_Detalle"
        Me.dgDeposito.DataSource = Me.DsDepositos
        '
        'dgDeposito.EmbeddedNavigator
        '
        Me.dgDeposito.EmbeddedNavigator.Name = ""
        Me.dgDeposito.Location = New System.Drawing.Point(8, 120)
        Me.dgDeposito.MainView = Me.GridView1
        Me.dgDeposito.Name = "dgDeposito"
        Me.dgDeposito.Size = New System.Drawing.Size(576, 120)
        Me.dgDeposito.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.dgDeposito.TabIndex = 66
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCuentaContable, Me.colDescripcionMov, Me.colMonto, Me.GridColumn1})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colCuentaContable
        '
        Me.colCuentaContable.Caption = "# Cta Contable"
        Me.colCuentaContable.FieldName = "CuentaContable"
        Me.colCuentaContable.Name = "colCuentaContable"
        Me.colCuentaContable.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCuentaContable.VisibleIndex = 0
        '
        'colDescripcionMov
        '
        Me.colDescripcionMov.Caption = "Descripción"
        Me.colDescripcionMov.FieldName = "DescripcionMov"
        Me.colDescripcionMov.Name = "colDescripcionMov"
        Me.colDescripcionMov.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcionMov.VisibleIndex = 2
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto.VisibleIndex = 3
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cta Nombre"
        Me.GridColumn1.FieldName = "NombreCuenta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 1
        '
        'daCuentasbancarias
        '
        Me.daCuentasbancarias.SelectCommand = Me.SqlSelectCommand1
        Me.daCuentasbancarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cuentas_bancarias.Cuenta, Cuentas_bancarias.Codigo_banco, Cuentas_bancaria" & _
        "s.NombreCuenta, Cuentas_bancarias.Id_CuentaBancaria, Bancos.Descripcion, Monedas" & _
        ".MonedaNombre, Monedas.Simbolo, dbo.SaldoCuentaBancaria(Cuentas_bancarias.Id_Cue" & _
        "ntaBancaria) AS Saldo, Cuentas_bancarias.tipoCuenta, Cuentas_bancarias.Cod_Moned" & _
        "a, Bancos.Codigo_banco AS Expr1, Cuentas_bancarias.CuentaContable, Cuentas_banca" & _
        "rias.NombreCuentaContable FROM Cuentas_bancarias INNER JOIN Bancos ON Cuentas_ba" & _
        "ncarias.Codigo_banco = Bancos.Codigo_banco INNER JOIN Monedas ON Cuentas_bancari" & _
        "as.Cod_Moneda = Monedas.CodMoneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Bancos"
        '
        'daCuentacontable
        '
        Me.daCuentacontable.SelectCommand = Me.SqlSelectCommand5
        Me.daCuentacontable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, PARENTID, DescCuentaMadre, Cuent" & _
        "aMadre, Movimiento, id FROM CuentaContable"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM Usuarios WHERE (Cedula = @Original_Cedula) AND (Clave_Interna = @Orig" & _
        "inal_Clave_Interna) AND (Nombre = @Original_Nombre)"
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO Usuarios(Cedula, Nombre, Clave_Interna) VALUES (@Cedula, @Nombre, @Cl" & _
        "ave_Interna); SELECT Cedula, Nombre, Clave_Interna FROM Usuarios WHERE (Cedula =" & _
        " @Cedula)"
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT Cedula, Nombre, Clave_Interna FROM Usuarios"
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE Usuarios SET Cedula = @Cedula, Nombre = @Nombre, Clave_Interna = @Clave_In" & _
        "terna WHERE (Cedula = @Original_Cedula) AND (Clave_Interna = @Original_Clave_Int" & _
        "erna) AND (Nombre = @Original_Nombre); SELECT Cedula, Nombre, Clave_Interna FROM" & _
        " Usuarios WHERE (Cedula = @Cedula)"
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 75, "Cedula"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 255, "Nombre"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Clave_Interna", System.Data.SqlDbType.VarChar, 30, "Clave_Interna"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cedula", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Clave_Interna", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Clave_Interna", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'daUsuarios
        '
        Me.daUsuarios.SelectCommand = Me.SqlSelectCommand4
        Me.daUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Nombre, Clave_Entrada, Clave_Interna, Cedula FROM Usuarios"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(359, 456)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 196
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodUsuario
        '
        Me.TxtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodUsuario.Location = New System.Drawing.Point(431, 456)
        Me.TxtCodUsuario.Name = "TxtCodUsuario"
        Me.TxtCodUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtCodUsuario.Size = New System.Drawing.Size(56, 13)
        Me.TxtCodUsuario.TabIndex = 194
        Me.TxtCodUsuario.Text = ""
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(432, 472)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.ReadOnly = True
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.TxtNombreUsuario.TabIndex = 195
        Me.TxtNombreUsuario.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'daDeposito
        '
        Me.daDeposito.DeleteCommand = Me.SqlDeleteCommand1
        Me.daDeposito.InsertCommand = Me.SqlInsertCommand1
        Me.daDeposito.SelectCommand = Me.SqlSelectCommand2
        Me.daDeposito.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deposito", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito"), New System.Data.Common.DataColumnMapping("NumeroDocumento", "NumeroDocumento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Concepto", "Concepto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Conciliado", "Conciliado"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("CodigoMoneda", "CodigoMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.daDeposito.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Deposito WHERE (Id_Deposito = @Original_Id_Deposito) AND (Anulado = @" & _
        "Original_Anulado) AND (Asiento = @Original_Asiento) AND (Ced_Usuario = @Original" & _
        "_Ced_Usuario) AND (CodigoMoneda = @Original_CodigoMoneda) AND (Concepto = @Origi" & _
        "nal_Concepto) AND (Conciliado = @Original_Conciliado) AND (Contabilizado = @Orig" & _
        "inal_Contabilizado) AND (Fecha = @Original_Fecha) AND (Id_CuentaBancaria = @Orig" & _
        "inal_Id_CuentaBancaria OR @Original_Id_CuentaBancaria IS NULL AND Id_CuentaBanca" & _
        "ria IS NULL) AND (Monto = @Original_Monto) AND (Num_Conciliacion = @Original_Num" & _
        "_Conciliacion) AND (NumeroDocumento = @Original_NumeroDocumento) AND (TipoCambio" & _
        " = @Original_TipoCambio)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Concepto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroDocumento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroDocumento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Deposito(NumeroDocumento, Fecha, Monto, Concepto, Anulado, Conciliado" & _
        ", Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion, Id_CuentaBancaria, Codi" & _
        "goMoneda, TipoCambio) VALUES (@NumeroDocumento, @Fecha, @Monto, @Concepto, @Anul" & _
        "ado, @Conciliado, @Contabilizado, @Ced_Usuario, @Asiento, @Num_Conciliacion, @Id" & _
        "_CuentaBancaria, @CodigoMoneda, @TipoCambio); SELECT Id_Deposito, NumeroDocument" & _
        "o, Fecha, Monto, Concepto, Anulado, Conciliado, Contabilizado, Ced_Usuario, Asie" & _
        "nto, Num_Conciliacion, Id_CuentaBancaria, CodigoMoneda, TipoCambio FROM Deposito" & _
        " WHERE (Id_Deposito = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroDocumento", System.Data.SqlDbType.BigInt, 8, "NumeroDocumento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 250, "Concepto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_Deposito, NumeroDocumento, Fecha, Monto, Concepto, Anulado, Conciliado," & _
        " Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion, Id_CuentaBancaria, Codig" & _
        "oMoneda, TipoCambio FROM Deposito"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Deposito SET NumeroDocumento = @NumeroDocumento, Fecha = @Fecha, Monto = @" & _
        "Monto, Concepto = @Concepto, Anulado = @Anulado, Conciliado = @Conciliado, Conta" & _
        "bilizado = @Contabilizado, Ced_Usuario = @Ced_Usuario, Asiento = @Asiento, Num_C" & _
        "onciliacion = @Num_Conciliacion, Id_CuentaBancaria = @Id_CuentaBancaria, CodigoM" & _
        "oneda = @CodigoMoneda, TipoCambio = @TipoCambio WHERE (Id_Deposito = @Original_I" & _
        "d_Deposito) AND (Anulado = @Original_Anulado) AND (Asiento = @Original_Asiento) " & _
        "AND (Ced_Usuario = @Original_Ced_Usuario) AND (CodigoMoneda = @Original_CodigoMo" & _
        "neda) AND (Concepto = @Original_Concepto) AND (Conciliado = @Original_Conciliado" & _
        ") AND (Contabilizado = @Original_Contabilizado) AND (Fecha = @Original_Fecha) AN" & _
        "D (Id_CuentaBancaria = @Original_Id_CuentaBancaria OR @Original_Id_CuentaBancari" & _
        "a IS NULL AND Id_CuentaBancaria IS NULL) AND (Monto = @Original_Monto) AND (Num_" & _
        "Conciliacion = @Original_Num_Conciliacion) AND (NumeroDocumento = @Original_Nume" & _
        "roDocumento) AND (TipoCambio = @Original_TipoCambio); SELECT Id_Deposito, Numero" & _
        "Documento, Fecha, Monto, Concepto, Anulado, Conciliado, Contabilizado, Ced_Usuar" & _
        "io, Asiento, Num_Conciliacion, Id_CuentaBancaria, CodigoMoneda, TipoCambio FROM " & _
        "Deposito WHERE (Id_Deposito = @Id_Deposito)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumeroDocumento", System.Data.SqlDbType.BigInt, 8, "NumeroDocumento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 250, "Concepto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodigoMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Concepto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumeroDocumento", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumeroDocumento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.BigInt, 8, "Id_Deposito"))
        '
        'daDeposito_Detalle
        '
        Me.daDeposito_Detalle.DeleteCommand = Me.SqlDeleteCommand3
        Me.daDeposito_Detalle.InsertCommand = Me.SqlInsertCommand3
        Me.daDeposito_Detalle.SelectCommand = Me.SqlSelectCommand3
        Me.daDeposito_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deposito_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DepositoDet", "Id_DepositoDet"), New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("DescripcionMov", "DescripcionMov"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta")})})
        Me.daDeposito_Detalle.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Deposito_Detalle WHERE (Id_DepositoDet = @Original_Id_DepositoDet) AN" & _
        "D (CuentaContable = @Original_CuentaContable) AND (DescripcionMov = @Original_De" & _
        "scripcionMov) AND (Id_Deposito = @Original_Id_Deposito) AND (Monto = @Original_M" & _
        "onto) AND (NombreCuenta = @Original_NombreCuenta)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_DepositoDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DepositoDet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionMov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionMov", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Deposito_Detalle(Id_Deposito, CuentaContable, DescripcionMov, Monto, " & _
        "NombreCuenta) VALUES (@Id_Deposito, @CuentaContable, @DescripcionMov, @Monto, @N" & _
        "ombreCuenta); SELECT Id_DepositoDet, Id_Deposito, CuentaContable, DescripcionMov" & _
        ", Monto, NombreCuenta FROM Deposito_Detalle WHERE (Id_DepositoDet = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.BigInt, 8, "Id_Deposito"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionMov", System.Data.SqlDbType.VarChar, 250, "DescripcionMov"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 350, "NombreCuenta"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id_DepositoDet, Id_Deposito, CuentaContable, DescripcionMov, Monto, Nombre" & _
        "Cuenta FROM Deposito_Detalle"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Deposito_Detalle SET Id_Deposito = @Id_Deposito, CuentaContable = @CuentaC" & _
        "ontable, DescripcionMov = @DescripcionMov, Monto = @Monto, NombreCuenta = @Nombr" & _
        "eCuenta WHERE (Id_DepositoDet = @Original_Id_DepositoDet) AND (CuentaContable = " & _
        "@Original_CuentaContable) AND (DescripcionMov = @Original_DescripcionMov) AND (I" & _
        "d_Deposito = @Original_Id_Deposito) AND (Monto = @Original_Monto) AND (NombreCue" & _
        "nta = @Original_NombreCuenta); SELECT Id_DepositoDet, Id_Deposito, CuentaContabl" & _
        "e, DescripcionMov, Monto, NombreCuenta FROM Deposito_Detalle WHERE (Id_DepositoD" & _
        "et = @Id_DepositoDet)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.BigInt, 8, "Id_Deposito"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionMov", System.Data.SqlDbType.VarChar, 250, "DescripcionMov"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 350, "NombreCuenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_DepositoDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_DepositoDet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionMov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionMov", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_DepositoDet", System.Data.SqlDbType.BigInt, 8, "Id_DepositoDet"))
        '
        'Moneda
        '
        Me.Moneda.InsertCommand = Me.SqlInsertCommand2
        Me.Moneda.SelectCommand = Me.SqlSelectCommand6
        Me.Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(600, 32)
        Me.TituloModulo.TabIndex = 197
        Me.TituloModulo.Text = "Depósitos"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarEditar2, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 450)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(600, 56)
        Me.ToolBar1.TabIndex = 198
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarEditar2
        '
        Me.ToolBarEditar2.Enabled = False
        Me.ToolBarEditar2.ImageIndex = 9
        Me.ToolBarEditar2.Text = "Editar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc")})})
        Me.AdapterAsientos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Origina" & _
        "l_Fecha) AND (FechaEntrada = @Original_FechaEntrada) AND (IdNumDoc = @Original_I" & _
        "dNumDoc) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo)" & _
        " AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) A" & _
        "ND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Obse" & _
        "rvaciones) AND (Periodo = @Original_Periodo) AND (TipoCambio = @Original_TipoCam" & _
        "bio) AND (TipoDoc = @Original_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND" & _
        " (TotalHaber = @Original_TotalHaber)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, A" & _
        "ccion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observ" & _
        "aciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc) " & _
        "VALUES (@NumAsiento, @Fecha, @NumDoc, @Beneficiario, @TipoDoc, @Accion, @Anulado" & _
        ", @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Observaciones," & _
        " @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio, @IdNumDoc); S" & _
        "ELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM AsientosContables"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, NumDoc = @" & _
        "NumDoc, Beneficiario = @Beneficiario, TipoDoc = @TipoDoc, Accion = @Accion, Anul" & _
        "ado = @Anulado, FechaEntrada = @FechaEntrada, Mayorizado = @Mayorizado, Periodo " & _
        "= @Periodo, NumMayorizado = @NumMayorizado, Modulo = @Modulo, Observaciones = @O" & _
        "bservaciones, NombreUsuario = @NombreUsuario, TotalDebe = @TotalDebe, TotalHaber" & _
        " = @TotalHaber, CodMoneda = @CodMoneda, TipoCambio = @TipoCambio, IdNumDoc = @Id" & _
        "NumDoc WHERE (NumAsiento = @Original_NumAsiento) AND (Accion = @Original_Accion)" & _
        " AND (Anulado = @Original_Anulado) AND (Beneficiario = @Original_Beneficiario) A" & _
        "ND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Original_Fecha) AND (FechaEnt" & _
        "rada = @Original_FechaEntrada) AND (IdNumDoc = @Original_IdNumDoc) AND (Mayoriza" & _
        "do = @Original_Mayorizado) AND (Modulo = @Original_Modulo) AND (NombreUsuario = " & _
        "@Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) AND (NumMayorizado = @O" & _
        "riginal_NumMayorizado) AND (Observaciones = @Original_Observaciones) AND (Period" & _
        "o = @Original_Periodo) AND (TipoCambio = @Original_TipoCambio) AND (TipoDoc = @O" & _
        "riginal_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND (TotalHaber = @Origin" & _
        "al_TotalHaber); SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion," & _
        " Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observacione" & _
        "s, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM As" & _
        "ientosContables WHERE (NumAsiento = @NumAsiento)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdapterDetallesAsientos
        '
        Me.AdapterDetallesAsientos.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterDetallesAsientos.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterDetallesAsientos.SelectCommand = Me.SqlSelectCommand9
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand4
        '
        'AdapterCentroCosto
        '
        Me.AdapterCentroCosto.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterCentroCosto.InsertCommand = Me.SqlInsertCommand8
        Me.AdapterCentroCosto.SelectCommand = Me.SqlSelectCommand11
        Me.AdapterCentroCosto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdapterCentroCosto.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM CentroCosto WHERE (Id = @Original_Id) AND (Codigo = @Original_Codigo)" & _
        " AND (Nombre = @Original_Nombre)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO CentroCosto(Codigo, Nombre) VALUES (@Codigo, @Nombre); SELECT Id, Cod" & _
        "igo, Nombre FROM CentroCosto WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection2
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Id, Codigo, Nombre FROM CentroCosto"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE CentroCosto SET Codigo = @Codigo, Nombre = @Nombre WHERE (Id = @Original_I" & _
        "d) AND (Codigo = @Original_Codigo) AND (Nombre = @Original_Nombre); SELECT Id, C" & _
        "odigo, Nombre FROM CentroCosto WHERE (Id = @Id)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'AdapterCentroCostoMovimiento
        '
        Me.AdapterCentroCostoMovimiento.DeleteCommand = Me.SqlDeleteCommand6
        Me.AdapterCentroCostoMovimiento.InsertCommand = Me.SqlInsertCommand9
        Me.AdapterCentroCostoMovimiento.SelectCommand = Me.SqlSelectCommand12
        Me.AdapterCentroCostoMovimiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto_Movimientos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAsiento", "IdAsiento"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdCentroCosto", "IdCentroCosto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("IdDetalle", "IdDetalle")})})
        Me.AdapterCentroCostoMovimiento.UpdateCommand = Me.SqlUpdateCommand6
        '
        'SqlDeleteCommand6
        '
        Me.SqlDeleteCommand6.CommandText = "DELETE FROM CentroCosto_Movimientos WHERE (Id = @Original_Id) AND (CuentaContable" & _
        " = @Original_CuentaContable) AND (Debe = @Original_Debe) AND (Descripcion = @Ori" & _
        "ginal_Descripcion OR @Original_Descripcion IS NULL AND Descripcion IS NULL) AND " & _
        "(Documento = @Original_Documento) AND (Fecha = @Original_Fecha) AND (Haber = @Or" & _
        "iginal_Haber) AND (IdAsiento = @Original_IdAsiento) AND (IdCentroCosto = @Origin" & _
        "al_IdCentroCosto) AND (IdDetalle = @Original_IdDetalle) AND (Monto = @Original_M" & _
        "onto) AND (NombreCuentaContable = @Original_NombreCuentaContable) AND (Tipo = @O" & _
        "riginal_Tipo)"
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCentroCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand9
        '
        Me.SqlInsertCommand9.CommandText = "INSERT INTO CentroCosto_Movimientos(IdAsiento, Documento, Fecha, IdCentroCosto, M" & _
        "onto, Debe, Haber, Descripcion, CuentaContable, NombreCuentaContable, Tipo, IdDe" & _
        "talle) VALUES (@IdAsiento, @Documento, @Fecha, @IdCentroCosto, @Monto, @Debe, @H" & _
        "aber, @Descripcion, @CuentaContable, @NombreCuentaContable, @Tipo, @IdDetalle); " & _
        "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descr" & _
        "ipcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_M" & _
        "ovimientos WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand9.Connection = Me.SqlConnection2
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"))
        Me.SqlInsertCommand9.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"))
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descri" & _
        "pcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_Mo" & _
        "vimientos"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand6
        '
        Me.SqlUpdateCommand6.CommandText = "UPDATE CentroCosto_Movimientos SET IdAsiento = @IdAsiento, Documento = @Documento" & _
        ", Fecha = @Fecha, IdCentroCosto = @IdCentroCosto, Monto = @Monto, Debe = @Debe, " & _
        "Haber = @Haber, Descripcion = @Descripcion, CuentaContable = @CuentaContable, No" & _
        "mbreCuentaContable = @NombreCuentaContable, Tipo = @Tipo, IdDetalle = @IdDetalle" & _
        " WHERE (Id = @Original_Id) AND (CuentaContable = @Original_CuentaContable) AND (" & _
        "Debe = @Original_Debe) AND (Descripcion = @Original_Descripcion OR @Original_Des" & _
        "cripcion IS NULL AND Descripcion IS NULL) AND (Documento = @Original_Documento) " & _
        "AND (Fecha = @Original_Fecha) AND (Haber = @Original_Haber) AND (IdAsiento = @Or" & _
        "iginal_IdAsiento) AND (IdCentroCosto = @Original_IdCentroCosto) AND (IdDetalle =" & _
        " @Original_IdDetalle) AND (Monto = @Original_Monto) AND (NombreCuentaContable = " & _
        "@Original_NombreCuentaContable) AND (Tipo = @Original_Tipo); SELECT Id, IdAsient" & _
        "o, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descripcion, CuentaConta" & _
        "ble, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_Movimientos WHERE (I" & _
        "d = @Id)"
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCentroCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'PanelCentroCosto
        '
        Me.PanelCentroCosto.BackColor = System.Drawing.Color.White
        Me.PanelCentroCosto.Controls.Add(Me.GroupBox2)
        Me.PanelCentroCosto.Controls.Add(Me.Label18)
        Me.PanelCentroCosto.Location = New System.Drawing.Point(-400, 144)
        Me.PanelCentroCosto.Name = "PanelCentroCosto"
        Me.PanelCentroCosto.Size = New System.Drawing.Size(395, 219)
        Me.PanelCentroCosto.TabIndex = 203
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BNuevo)
        Me.GroupBox2.Controls.Add(Me.TxtDetalle)
        Me.GroupBox2.Controls.Add(Me.BotonCerrar)
        Me.GroupBox2.Controls.Add(Me.GridCentroCosto)
        Me.GroupBox2.Controls.Add(Me.ButtonAgregarDetalle)
        Me.GroupBox2.Controls.Add(Me.EditDescripcionCC)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.CBCentroCosto)
        Me.GroupBox2.Controls.Add(Me.txtMontoCentroCosto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 200)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(120, 80)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(72, 20)
        Me.BNuevo.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.BNuevo.TabIndex = 204
        Me.BNuevo.Text = "Nuevo"
        '
        'TxtDetalle
        '
        Me.TxtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDetalle.Enabled = False
        Me.TxtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDetalle.ForeColor = System.Drawing.Color.Blue
        Me.TxtDetalle.Location = New System.Drawing.Point(8, 80)
        Me.TxtDetalle.Name = "TxtDetalle"
        Me.TxtDetalle.ReadOnly = True
        Me.TxtDetalle.Size = New System.Drawing.Size(96, 13)
        Me.TxtDetalle.TabIndex = 203
        Me.TxtDetalle.Text = "0.00"
        Me.TxtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BotonCerrar
        '
        Me.BotonCerrar.Location = New System.Drawing.Point(264, 80)
        Me.BotonCerrar.Name = "BotonCerrar"
        Me.BotonCerrar.Size = New System.Drawing.Size(72, 20)
        Me.BotonCerrar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.BotonCerrar.TabIndex = 202
        Me.BotonCerrar.Text = "Cerrar"
        '
        'GridCentroCosto
        '
        Me.GridCentroCosto.DataSource = Me.DsDepositos.CentroCostoDetalle
        '
        'GridCentroCosto.EmbeddedNavigator
        '
        Me.GridCentroCosto.EmbeddedNavigator.Name = ""
        Me.GridCentroCosto.Location = New System.Drawing.Point(8, 112)
        Me.GridCentroCosto.MainView = Me.GridView2
        Me.GridCentroCosto.Name = "GridCentroCosto"
        Me.GridCentroCosto.Size = New System.Drawing.Size(344, 80)
        Me.GridCentroCosto.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridCentroCosto.TabIndex = 201
        Me.GridCentroCosto.Text = "GridControl1"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn9, Me.GridColumn11, Me.GridColumn15})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "CentroCosto"
        Me.GridColumn9.FieldName = "CentroCosto"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.VisibleIndex = 0
        Me.GridColumn9.Width = 112
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Monto"
        Me.GridColumn11.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Monto"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 112
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Descripción"
        Me.GridColumn15.FieldName = "Descripcion"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.VisibleIndex = 2
        Me.GridColumn15.Width = 111
        '
        'ButtonAgregarDetalle
        '
        Me.ButtonAgregarDetalle.Enabled = False
        Me.ButtonAgregarDetalle.Location = New System.Drawing.Point(192, 80)
        Me.ButtonAgregarDetalle.Name = "ButtonAgregarDetalle"
        Me.ButtonAgregarDetalle.Size = New System.Drawing.Size(72, 20)
        Me.ButtonAgregarDetalle.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonAgregarDetalle.TabIndex = 200
        Me.ButtonAgregarDetalle.Text = "Agregar"
        '
        'EditDescripcionCC
        '
        Me.EditDescripcionCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsDepositos, "CentroCosto_Movimientos.Descripcion"))
        Me.EditDescripcionCC.Location = New System.Drawing.Point(120, 56)
        Me.EditDescripcionCC.Name = "EditDescripcionCC"
        '
        'EditDescripcionCC.Properties
        '
        Me.EditDescripcionCC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditDescripcionCC.Properties.Enabled = False
        Me.EditDescripcionCC.Properties.ShowIcon = False
        Me.EditDescripcionCC.Properties.ShowPopupShadow = False
        Me.EditDescripcionCC.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.EditDescripcionCC.Size = New System.Drawing.Size(216, 19)
        Me.EditDescripcionCC.TabIndex = 199
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(8, 40)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 59
        Me.Label11.Text = "Monto"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(120, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(216, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Descripción"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label17.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(8, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(96, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Centro de Costo"
        '
        'CBCentroCosto
        '
        Me.CBCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsDepositos, "CentroCosto_Movimientos.IdCentroCosto"))
        Me.CBCentroCosto.DataSource = Me.DsDepositos
        Me.CBCentroCosto.DisplayMember = "CentroCosto.Nombre"
        Me.CBCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCentroCosto.Enabled = False
        Me.CBCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCentroCosto.ForeColor = System.Drawing.Color.Blue
        Me.CBCentroCosto.ItemHeight = 13
        Me.CBCentroCosto.Location = New System.Drawing.Point(112, 15)
        Me.CBCentroCosto.Name = "CBCentroCosto"
        Me.CBCentroCosto.Size = New System.Drawing.Size(224, 21)
        Me.CBCentroCosto.TabIndex = 0
        Me.CBCentroCosto.ValueMember = "CentroCosto.Id"
        '
        'txtMontoCentroCosto
        '
        Me.txtMontoCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsDepositos, "CentroCosto_Movimientos.Monto"))
        Me.txtMontoCentroCosto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoCentroCosto.Location = New System.Drawing.Point(8, 56)
        Me.txtMontoCentroCosto.Name = "txtMontoCentroCosto"
        '
        'txtMontoCentroCosto.Properties
        '
        Me.txtMontoCentroCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCentroCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCentroCosto.Properties.Enabled = False
        Me.txtMontoCentroCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMontoCentroCosto.Size = New System.Drawing.Size(104, 19)
        Me.txtMontoCentroCosto.TabIndex = 5
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(48, 1)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(269, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "Centro de Costo"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection2
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "pocambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection2
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE DetallesAsientosContable SET NumAsiento = @NumAsiento, Cuenta = @Cuenta, N" & _
        "ombreCuenta = @NombreCuenta, Monto = @Monto, Debe = @Debe, Haber = @Haber, Descr" & _
        "ipcionAsiento = @DescripcionAsiento, Tipocambio = @Tipocambio WHERE (ID_Detalle " & _
        "= @Original_ID_Detalle) AND (Cuenta = @Original_Cuenta) AND (Debe = @Original_De" & _
        "be) AND (DescripcionAsiento = @Original_DescripcionAsiento) AND (Haber = @Origin" & _
        "al_Haber) AND (Monto = @Original_Monto) AND (NombreCuenta = @Original_NombreCuen" & _
        "ta) AND (NumAsiento = @Original_NumAsiento) AND (Tipocambio = @Original_Tipocamb" & _
        "io OR @Original_Tipocambio IS NULL AND Tipocambio IS NULL); SELECT ID_Detalle, N" & _
        "umAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocam" & _
        "bio FROM DetallesAsientosContable WHERE (ID_Detalle = @ID_Detalle)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle"))
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (Tipocambio = @Original_Tipocambio OR @Original_Tipocambio" & _
        " IS NULL AND Tipocambio IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'frmDepositos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(600, 506)
        Me.Controls.Add(Me.PanelCentroCosto)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.TxtCodUsuario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.MaximumSize = New System.Drawing.Size(608, 540)
        Me.MinimumSize = New System.Drawing.Size(608, 540)
        Me.Name = "frmDepositos"
        Me.Text = "Depósitos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCentroCosto.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditDescripcionCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub frmDeposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim filas As Integer
            Dim fx As New cFunciones
            SqlConnection1.ConnectionString = GetSetting("Seesoft", "Bancos", "Conexion")
            SqlConnection2.ConnectionString = GetSetting("Seesoft", "Contabilidad", "Conexion")
            Try
                Binding()
                InhabilitarChekes()
                TxtCodUsuario.Focus()
                daUsuarios.Fill(DsDepositos.Usuarios)
                daCuentasbancarias.Fill(DsDepositos.Cuentas_bancarias) ''0
                Moneda.Fill(DsDepositos.Moneda)
                'AdapterConfiguraciones.Fill(Me.DsDepositos.Configuraciones)
                AdapterCentroCosto.Fill(DsDepositos.CentroCosto)
                filas = DsDepositos.Cuentas_bancarias.Rows.Count()
                ValoresPorDefecto()

                'DEPOSITOS
                DsDepositos.Deposito.Id_DepositoColumn.AutoIncrement = True
                DsDepositos.Deposito.Id_DepositoColumn.AutoIncrementSeed = -1
                DsDepositos.Deposito.Id_DepositoColumn.AutoIncrementStep = -1
                'DEPOSITOS DETALLES
                DsDepositos.Deposito_Detalle.Id_DepositoDetColumn.AutoIncrement = True
                DsDepositos.Deposito_Detalle.Id_DepositoDetColumn.AutoIncrementSeed = -1
                DsDepositos.Deposito_Detalle.Id_DepositoDetColumn.AutoIncrementStep = -1
                txtTipoCambio.Text = fx.TipoCambio(DateTimePicker1.Value, True)
                If CedulaUsuario.Equals("") Then CedulaUsuario = usua.Cedula

                TxtCodUsuario.Text = CedulaUsuario
                Loggin_Usuario()

                If desdeConciliacion Then

                    If Me.modificar Then
                        Me.cargarDeposito(Me.id_deposito, Me.cuentabancaria)
                        Me.Editar()
                    End If
                End If

            Catch ex As Exception
                If filas = 0 Then
                    MsgBox("No se encuentra ninguna cuenta bancaria registrada, no es posible realizar ninguna transacción... ")
                Else
                    MsgBox("Problemas al cargar el Formulario, Intente abrir otra vez, si el problema persiste comuniqueselo al administrador del sistema ")
                    MsgBox(ex.ToString)
                End If
            End Try

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Function ValoresPorDefecto()
        Dim Fx As New cFunciones
        Me.DsDepositos.Deposito.AnuladoColumn.DefaultValue = 0
        Me.DsDepositos.Deposito.MontoColumn.DefaultValue = "0"
        Me.DsDepositos.Deposito.ConciliadoColumn.DefaultValue = 0
        Me.DsDepositos.Deposito_Detalle.DescripcionMovColumn.DefaultValue = "--"
        Me.DsDepositos.Deposito.ContabilizadoColumn.DefaultValue = 0
        Me.DsDepositos.Deposito.ConceptoColumn.DefaultValue = " "
        Me.DsDepositos.Deposito.AsientoColumn.DefaultValue = "0"
        Me.DsDepositos.Deposito.FechaColumn.DefaultValue = Me.DateTimePicker1.Value 'Date.Today
        Me.DsDepositos.Deposito.NumeroDocumentoColumn.DefaultValue = "0"
        Me.DsDepositos.Deposito.CodigoMonedaColumn.DefaultValue = 1
        Me.DsDepositos.Deposito.TipoCambioColumn.DefaultValue = Fx.TipoCambio(DateTimePicker1.Value, True)
        Me.DsDepositos.Deposito.Num_ConciliacionColumn.DefaultValue = "0"
        Me.DsDepositos.Deposito_Detalle.DescripcionMovColumn.DefaultValue = "--"
        Me.DsDepositos.Deposito_Detalle.MontoColumn.DefaultValue = "0"
        Me.DsDepositos.Deposito_Detalle.NombreCuentaColumn.DefaultValue = "--"
        Me.DsDepositos.Deposito_Detalle.CuentaContableColumn.DefaultValue = "0"
        Me.DsDepositos.Deposito.Id_CuentaBancariaColumn.DefaultValue = Me.DsDepositos.Cuentas_bancarias.Rows(0).Item("Id_CuentaBancaria")

        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsDepositos.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsDepositos.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsDepositos.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsDepositos.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsDepositos.AsientosContables.TipoDocColumn.DefaultValue = 2
        DsDepositos.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsDepositos.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsDepositos.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsDepositos.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsDepositos.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsDepositos.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsDepositos.AsientosContables.ModuloColumn.DefaultValue = "Depositos"
        DsDepositos.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsDepositos.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsDepositos.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsDepositos.AsientosContables.TotalHaberColumn.DefaultValue = 0

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsDepositos.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsDepositos.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsDepositos.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsDepositos.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsDepositos.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsDepositos.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsDepositos.DetallesAsientosContable.HaberColumn.DefaultValue = 0

        'VALORES POR DEFECTO PARA LA TABLA CENTROS DE COSTO MOVIMIENTOS
        DsDepositos.CentroCosto_Movimientos.IdAsientoColumn.DefaultValue = ""
        DsDepositos.CentroCosto_Movimientos.DocumentoColumn.DefaultValue = ""
        DsDepositos.CentroCosto_Movimientos.FechaColumn.DefaultValue = Now.Date
        DsDepositos.CentroCosto_Movimientos.IdCentroCostoColumn.DefaultValue = 0
        DsDepositos.CentroCosto_Movimientos.MontoColumn.DefaultValue = 0
        DsDepositos.CentroCosto_Movimientos.DebeColumn.DefaultValue = 0
        DsDepositos.CentroCosto_Movimientos.HaberColumn.DefaultValue = 0
        DsDepositos.CentroCosto_Movimientos.DescripcionColumn.DefaultValue = ""
        DsDepositos.CentroCosto_Movimientos.CuentaContableColumn.DefaultValue = ""
        DsDepositos.CentroCosto_Movimientos.NombreCuentaContableColumn.DefaultValue = ""
        DsDepositos.CentroCosto_Movimientos.TipoColumn.DefaultValue = 2
        DsDepositos.CentroCosto_Movimientos.IdDetalleColumn.DefaultValue = 0
    End Function


    Function Binding()
        'Depositos
        Me.CalcEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsDepositos, "Deposito.Monto"))
        Me.cboBancos.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsDepositos, "Deposito.Id_CuentaBancaria"))
        Me.txtNumerodeposito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Deposito.NumeroDocumento"))
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Deposito.Fecha"))
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Deposito.Concepto"))
        Me.ckConciliado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", DsDepositos, "Deposito.Conciliado"))
        Me.txtNumConciliacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsDepositos, "Deposito.Num_Conciliacion"))

        'Deposito Detalle
        Me.CalcEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsDepositos, "Deposito.DepositoDeposito_Detalle.Monto"))
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Deposito.DepositoDeposito_Detalle.DescripcionMov"))
        'Cuenta
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Cuentas_bancarias.tipoCuenta"))
        Me.Label20.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Cuentas_bancarias.Descripcion"))
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDepositos, "Cuentas_bancarias.MonedaNombre"))
    End Function
#End Region

#Region "Control de Controles"
    Function HabilitarChekes()
        GroupBox1.Enabled = True
        If Conciliacion = True Then
            CalcEdit2.Enabled = False
        Else
            CalcEdit2.Enabled = True
        End If
    End Function

    Function InhabilitarChekes()
        GroupBox1.Enabled = False
        INHabilitarDetallesCheques()
    End Function

    Function HabilitarDetallesCheques()
        GroupBox4.Enabled = True
        Me.SimpleGuardar.Enabled = False
        Me.SimpleEliminar.Enabled = True
        Me.SimpleNuevo.Enabled = True
    End Function

    Function INHabilitarDetallesCheques()
        GroupBox4.Enabled = False
        Me.SimpleGuardar.Enabled = False
        Me.SimpleEliminar.Enabled = True
        Me.SimpleNuevo.Enabled = True
    End Function
#End Region

#Region "Logiar Usuario"
    Private Sub TxtCodUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loggin_Usuario()
        End If
    End Sub

    Function Loggin_Usuario()
        Try
            If Me.BindingContext(Me.DsDepositos.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DsDepositos.Usuarios.Select("Cedula ='" & CedulaUsuario & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    TxtNombreUsuario.Text = Usua("Nombre")
                    Me.DsDepositos.Deposito.Ced_UsuarioColumn.DefaultValue = Usua("Cedula")
                    usuario.Cedula = Usua("Cedula")
                    usuario.Nombre = Usua("Nombre")
                    Me.ToolBarNuevo.Enabled = True
                    Me.ToolBarRegistrar.Enabled = False
                    Me.ToolBarBuscar.Enabled = True
                    Me.ToolBarEliminar.Enabled = False
                    If Me.desdeConciliacion Then
                        Me.ToolBarBuscar.Enabled = False
                    End If
                Else ' si no existe una contraseñla como esta
                    TxtCodUsuario.Text = ""
                    MsgBox("Contraseña interna incorrecta", MsgBoxStyle.Exclamation)
                End If
            Else
                MsgBox("No Existen Usuarios, ingrese datos")
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

#End Region

#Region "Imprimir"
    Function Imprimir()
        Dim Apertura_Cajas As New ReporteDepositoBancario
        Dim visor As New frmVisorReportes
        Dim servidor As String = Me.SqlConnection1.DataSource
        Dim NumeroDeposito As Long
        Apertura_Cajas.SetDatabaseLogon("sa", "", Me.SqlConnection1.DataSource, Me.SqlConnection1.Database)
        NumeroDeposito = Me.BindingContext(Me.DsDepositos, "Deposito").Current("Id_Deposito")
        Apertura_Cajas.SetParameterValue(0, NumeroDeposito)
        CrystalReportsConexion.LoadReportViewer(visor.rptViewer, Apertura_Cajas, False, Me.SqlConnection1.ConnectionString)
        visor.rptViewer.Visible = True
        Apertura_Cajas = Nothing
        visor.ShowDialog()
    End Function
#End Region

#Region "Anular"
    Function Anula()
        Try
            Dim Funciones As New Conexion
            If MsgBox("Desea Anular Deposito", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Function
            End If
            If BindingContext(DsDepositos, "Deposito").Current("Conciliado") = True Then
                MsgBox("No es Posible Anular este Deposito ya que ha sido Conciliado !!!!", MsgBoxStyle.Information, "Atención ....")
                Exit Function
            End If

            'VALIDA ASIENTO SI TIENE
            If Not Me.BindingContext(Me.DsDepositos, "Deposito").Current("Asiento").Equals("0") Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Mayorizado From AsientosContables WHERE NumAsiento = '" & Me.BindingContext(Me.DsDepositos, "Deposito").Current("Asiento") & "'", dt, GetSetting("SeeSoft", "Contabilidad", "Conexion"))
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item(0) Then
                        MsgBox("El asiento # " & Me.BindingContext(Me.DsDepositos, "Deposito").Current("Asiento") & " que corresponde a este ajuste ya esta mayorizado, NO se puede anular", MsgBoxStyle.OKOnly)
                        Exit Function
                    End If
                End If
            End If
            '---------------------------------------

            BindingContext(DsDepositos, "Deposito").Current("Anulado") = True
            BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
            Anular.Visible = True

            daDeposito.Update(DsDepositos.Deposito)
            MsgBox("Deposito Anulado satisfactoriamente", MsgBoxStyle.Information)
            'VALIDA ASIENTO SI TIENE Y ANUL
            If Not Me.BindingContext(Me.DsDepositos, "Deposito").Current("Asiento").Equals("0") Then
                Dim cx As New Conexion
                cx.Conectar("Contabilidad")
                cx.SlqExecute(cx.sQlconexion, "UPDATE AsientosContables Set Anulado = 1 WHERE NumAsiento = '" & Me.BindingContext(Me.DsDepositos, "Deposito").Current("Asiento") & "'")
                cx.DesConectar(cx.sQlconexion)
            End If
            '---------------------------------------
            If MsgBox("¿Desea borrar numero de concecutivo del deposito?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then
                Me.txtNumerodeposito.Text = "0"
                Dim cx As New Conexion
                cx.Conectar("Bancos")
                cx.SlqExecute(cx.sQlconexion, "UPDATE Deposito Set NumeroDocumento = 0 WHERE Id_Deposito = " & Me.BindingContext(Me.DsDepositos, "Deposito").Current("Id_Deposito") & "")
                cx.DesConectar(cx.sQlconexion)
            End If
            Return True

        Catch ex As Exception
            MsgBox("Error al tratar de anular el Deposito, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function
#End Region

#Region "Editar"
    Function Editar()
        Try
            If ToolBarEditar2.Text = "Editar" Then
                Dim Cx As New Conexion
                Dim Id_Cuenta As Integer = cboBancos.SelectedValue

                ToolBarEditar2.Text = "Cancelar"
                ToolBarEditar2.ImageIndex = 8
               
                If Anular.Visible = True Then
                    MsgBox("No se puede editar el depósito porque está anulado", MsgBoxStyle.Information, "Atención...")
                    ToolBarEditar2.Text = "Editar"
                    ToolBarEditar2.ImageIndex = 9
                    Exit Function
                End If
                Conciliacion = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Conciliado FROM Deposito WHERE(Id_CuentaBancaria = " & Id_Cuenta & "and NumeroDocumento =" & Me.txtNumerodeposito.Text & ")")
                Cx.DesConectar(Cx.sQlconexion)
                If Conciliacion = True Then
                    MsgBox("El documento está conciliado, no puede cambiar el monto", MsgBoxStyle.Information, "Atención...")
                End If
                If txtObservaciones.Text = "COBRO DE TARJETAS" Then
                    MsgBox("El Depósito no se puede editar porque se genero en el auxiliar de Operadores de Tarjeta", MsgBoxStyle.Information, "Atención...")
                    ToolBarEditar2.Text = "Editar"
                    ToolBarEditar2.ImageIndex = 9
                    Exit Function
                End If
                If DsDepositos.AsientosContables.Count > 0 Then
                    If BindingContext(DsDepositos, "AsientosContables").Current("Mayorizado") = True Then
                        MsgBox("No se puede editar el Deposito porque el Asiento esta Mayorizado", MsgBoxStyle.Information, "Atención...")
                        ToolBarEditar2.Text = "Editar"
                        ToolBarEditar2.ImageIndex = 9
                        Exit Function
                    End If
                End If
                Me.HabilitarChekes()
                Me.HabilitarDetallesCheques()
                Me.ToolBarNuevo.Enabled = False
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarImprimir.Enabled = False

            Else
                ToolBarEditar2.Text = "Editar"
                ToolBarEditar2.ImageIndex = 9
                Me.BindingContext(Me.DsDepositos, "Deposito").CancelCurrentEdit()
                Me.BindingContext(Me.DsDepositos, "Deposito").EndCurrentEdit()
                Me.InhabilitarChekes()
                Me.INHabilitarDetallesCheques()
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarImprimir.Enabled = True
                EditaAsiento = False
                EditaCentro = False
                If desdeConciliacion Then
                    DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al tratar de editar el depósito, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function

#End Region

#Region "Buscar id deposito"
    Public Function id(ByVal id1 As String, ByVal c As String)
        Dim cnn As SqlConnection = Nothing
        Dim sel As String
        Dim Cx1 As New Conexion
        Dim sent1 As String
        sent1 = "SELECT dbo.Deposito.Id_Deposito FROM dbo.Cuentas_bancarias INNER JOIN" & _
                      " dbo.Deposito ON dbo.Cuentas_bancarias.Id_CuentaBancaria = dbo.Deposito.Id_CuentaBancaria where dbo.Deposito.NumeroDocumento = '" & id1 & "' and dbo.Cuentas_bancarias.Cuenta ='" & cuentabancaria & "'"

        id_deposito = Cx1.SlqExecuteScalar(Cx1.Conectar("Bancos"), sent1)
        Cx1.DesConectar(Cx1.sQlconexion)
    End Function
#End Region

#Region "Buscar"
    Function Buscar()
        Dim F As New Buscadores
        Dim Id_Cheque As String
        Dim conn As String = Me.SqlConnection1.ConnectionString
        Id_Cheque = F.Buscar_X_Descripcion_F("SELECT dbo.Cuentas_bancarias.Cuenta,dbo.Deposito.NumeroDocumento AS Número, dbo.Deposito.Concepto, dbo.Deposito.Fecha FROM dbo.Deposito INNER JOIN dbo.Cuentas_bancarias ON dbo.Deposito.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria ORDER BY dbo.Deposito.Fecha DESC", "Concepto", "Fecha", "Buscar Depósito", conn)
        cuentabancaria = F.cuentabancaria
        If Id_Cheque <> "" Then
            Me.DsDepositos.Cuentas_bancarias.Clear()
            Me.daCuentasbancarias.Fill(DsDepositos.Cuentas_bancarias)
            DsDepositos.Deposito_Detalle.Clear()
            DsDepositos.Deposito.Clear()
            Me.cargarDeposito(Id_Cheque, cuentabancaria)
        End If
    End Function


    Sub cargarDeposito(ByVal Id_Che As String, ByVal cuentabanc As String)
        id(Id_Che, cuentabanc) ' SE BUSCA EL ID DEL DEPOSITO SELECCIONADO
        CargarCheques(id_deposito)
        CargarDetalleCheque(id_deposito)

        'If Me.DsDepositos.Deposito_Detalle.Rows.Count > 0 Or (Me.usuario.Cedula.Equals("1") Or Me.usuario.Cedula.Equals("6")) Then

        If DsDepositos.Deposito.Rows(0).Item("Anulado") = True Then
            Anular.Visible = True
            ToolBar1.Buttons(4).Enabled = False
        Else
            Anular.Visible = False
            ToolBar1.Buttons(4).Enabled = True
        End If
        ToolBarEditar2.Enabled = True
        ToolBarImprimir.Enabled = True
        ToolBarRegistrar.Enabled = False
    End Sub
#End Region

#Region "Cargar Cheques"
    Function CargarCheques(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Bancos", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from Deposito WHERE Id_Deposito = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(DsDepositos.Deposito)
            CargarAsiento(Id)

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally

            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

#Region "Cargar Detalle Cheque"
    Function CargarDetalleCheque(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        '  Dentro de unTry/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Bancos", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from Deposito_Detalle WHERE Id_Deposito = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DsDepositos.Deposito_Detalle)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally

            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

    End Function
#End Region

#Region "Nuevo"
    Function Nuevo()
        Anular.Visible = False
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Me.Anular.Visible = False
            EditaAsiento = False
            Try 'inicia la edicion
                Me.DsDepositos.Deposito_Detalle.Clear()
                Me.DsDepositos.Deposito.Clear()
                DsDepositos.CentroCostoDetalle.Clear()
                DsDepositos.CentroCosto_Movimientos.Clear()
                DsDepositos.AsientosContables.Clear()
                DsDepositos.DetallesAsientosContable.Clear()
                Me.BindingContext(DsDepositos, "Deposito").CancelCurrentEdit()
                Me.BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
                Me.BindingContext(DsDepositos, "Deposito").AddNew()
                Me.HabilitarChekes()
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                cboBancos.Text = GetSetting("SeeSOFT", "Bancos", "UltCuenta")
                Me.cboBancos.Focus()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                DsDepositos.CentroCostoDetalle.Clear()
                DsDepositos.CentroCosto_Movimientos.Clear()
                DsDepositos.AsientosContables.Clear()
                DsDepositos.DetallesAsientosContable.Clear()
                Me.BindingContext(DsDepositos, "Deposito").CancelCurrentEdit()
                Me.BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
                Me.InhabilitarChekes()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.SimpleNuevo.Text = "Nuevo"
                Me.SimpleGuardar.Enabled = False
                DialogResult = DialogResult.Cancel

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region

#Region "Validar"
    Function ValidarCheque() As Boolean
        Try
            If CalcEdit1.Value <= 0 Then
                MsgBox("introduce un monto adecuado", MsgBoxStyle.Information)
                CalcEdit1.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox("introduce un monto adecuado", MsgBoxStyle.Information)
            CalcEdit1.Focus()
            Return False
        End Try

        If txtObservaciones.Text.Length = 0 Then
            MsgBox("Debes Ingresar una Observación", MsgBoxStyle.Information)
            txtObservaciones.Focus()
            Return False
        End If

        If ToolBarEditar2.Text = "Editar" Then
            Dim Cx As New Conexion
            Dim Ajuste As String
            Dim Num_Ajuste As Integer = txtNumerodeposito.Text
            Ajuste = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Id_deposito FROM Deposito WHERE NumeroDocumento= " & Num_Ajuste & " AND Id_CuentaBancaria = " & cboBancos.SelectedValue)
            Cx.DesConectar(Cx.sQlconexion)
            If Ajuste = "" Then
            Else
                MsgBox("Ya existe un Deposito de cuenta con este numero")
                txtNumerodeposito.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Function numero() As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim sel As String
        a = txtNumerodeposito.Text
        cuenta = Me.cboBancos.Text
        Dim Cx As New Conexion
        Dim NumeroDeposito As String
        Dim sentence As String
        sentence = "SELECT * FROM dbo.Deposito INNER JOIN dbo.Cuentas_bancarias ON dbo.Deposito.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria WHERE dbo.Deposito.NumeroDocumento = " & a & " And dbo.Cuentas_bancarias.Cuenta = '" & cuenta & "'"
        NumeroDeposito = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), sentence)
        Cx.DesConectar(Cx.sQlconexion)
        If NumeroDeposito = "" Or Me.ToolBarEditar2.Text = "Cancelar" Then
            Return True
        Else
            Return False
        End If
    End Function
#End Region

#Region "Guardar"
    Function GuardarCabios() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Dim CodigoMoneda As Integer

        CodigoMoneda = DsDepositos.Cuentas_bancarias(BindingContext(DsDepositos, "Cuentas_bancarias").Position).Cod_Moneda
        DsDepositos.Deposito(0).CodigoMoneda = CodigoMoneda

        Try
            Me.daDeposito.InsertCommand.Transaction = Trans
            Me.daDeposito.UpdateCommand.Transaction = Trans
            Me.daDeposito.DeleteCommand.Transaction = Trans
            Me.daDeposito_Detalle.InsertCommand.Transaction = Trans
            Me.daDeposito_Detalle.UpdateCommand.Transaction = Trans
            Me.daDeposito_Detalle.DeleteCommand.Transaction = Trans

            ActualizaIDCentro()

            Me.daDeposito.Update(DsDepositos.Deposito)
            Me.daDeposito_Detalle.Update(DsDepositos.Deposito_Detalle)
            Trans.Commit()

            If Conta = 1 Or Conta = 2 Then
                GuardaAsiento()
                If TransAsiento() = False Then
                    Trans.Rollback()
                    MsgBox("Error en la Generación del Asiento", MsgBoxStyle.Critical, "Atencion...")
                    ToolBar1.Buttons(2).Enabled = True
                    Return False
                    Exit Function
                End If
            End If

            DsDepositos.AcceptChanges()
            MsgBox("Deposito guardado satisfactoriamente", MsgBoxStyle.Information)
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function


    Function GuardarDetalle()
        Dim i As Integer
        Dim Cx As New Conexion
        Dim Campos As String = "Id_Deposito, CuentaContable, DescripcionMov, Monto, NombreCuenta"
        Dim Datos As String
        Try
            For i = 0 To Me.DsDepositos.Deposito_Detalle.Rows.Count - 1
                Datos = Me.BindingContext(Me.DsDepositos, "Deposito").Current("Id_Deposito") & ", '" & _
                Me.DsDepositos.Deposito_Detalle.Rows(i).Item("CuentaContable") & "', '" & _
                Me.DsDepositos.Deposito_Detalle.Rows(i).Item("DescripcionMov") & "', " & _
                Me.DsDepositos.Deposito_Detalle.Rows(i).Item("Monto") & ", '" & _
                Me.DsDepositos.Deposito_Detalle.Rows(i).Item("NombreCuenta") & "'"
                Cx.AddNewRecord("Deposito_Detalle", Campos, Datos)
            Next
        Catch ex As Exception
            MsgBox("Error al tratar de Guardar los datos, Intente de nuevo, si el problema persiste, comuniqueselo al administrador de sistema ", MsgBoxStyle.Information)
            Return False
        End Try
    End Function


    Function Guardar()
        Dim Fx As New cFunciones
        Dim cConexion As New Conexion

        FechaConciliacion()
        If numero() Then ' valida si el numero de deposito existe
            If ValidarCheque() Then
                Me.BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
                If ValidarDetalleCheque(True) Then
                    If DateTimePicker1.Value <= FechaCon And ToolBar1.Buttons(0).Text = "Cancelar" Then
                        MsgBox("Fecha del Deposito no puede ser menor que la última conciliación")
                    Else
                        Me.BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
                        '------------------------------------------------------------------
                        'VERIFICA EL PERIODO DE TRABAJO
                        Conta = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "Select Contabilidad from Configuraciones")
                        cConexion.DesConectar(cConexion.sQlconexion)
                        If Conta = 1 Or Conta = 2 Then
                            If Fx.ValidarPeriodo(Me.BindingContext(DsDepositos, "Deposito").Current("Fecha")) = False Then
                                MsgBox("La Fecha del Deposito No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar el Deposito", MsgBoxStyle.Information, "Sistema SeeSoft")
                                Exit Function
                            End If
                        End If
                        '------------------------------------------------------------------
                        If Me.GuardarCabios() Then
                            Try
                                Me.BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
                                SaveSetting("SeeSOFT", "Bancos", "UltCuenta", cboBancos.Text)
                                Me.InhabilitarChekes()
                                Me.INHabilitarDetallesCheques()
                                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                                Me.ToolBar1.Buttons(0).ImageIndex = 0
                                Me.ToolBarBuscar.Enabled = True
                                Me.ToolBarNuevo.Enabled = True
                                Me.ToolBarEliminar.Enabled = False
                                Me.ToolBarRegistrar.Enabled = False
                                Me.ToolBarImprimir.Enabled = False
                                Me.ToolBarEliminar.Enabled = False
                                Me.ToolBarEditar2.Text = "Editar"
                                Me.ToolBarEditar2.ImageIndex = 9
                                Me.ToolBarEditar2.Enabled = False
                                EditaAsiento = False
                                EditaCentro = False

                                If MsgBox("Desea Imprimir el deposito", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Imprimir()
                                End If
                                If Me.desdeConciliacion Then
                                    If Me.modificar Then
                                        Me.nuevoMonto = CDbl(Me.CalcEdit1.Text)
                                    Else
                                    End If
                                    DialogResult = DialogResult.OK
                                    Me.Close()
                                    Exit Function
                                End If

                                DsDepositos.Deposito_Detalle.Clear()
                                DsDepositos.Deposito.Clear()
                                DsDepositos.Cuentas_bancarias.Clear()
                                DsDepositos.DetallesAsientosContable.Clear()
                                DsDepositos.AsientosContables.Clear()
                                ' DsDepositos.Configuraciones.Clear()
                                daCuentasbancarias.Fill(DsDepositos.Cuentas_bancarias)
                                'AdapterConfiguraciones.Fill(DsDepositos.Configuraciones)
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Function
#End Region

#Region "BuscarSaldoBanco"
    Function BuscarSaldoCuenta(ByVal Id_Cuenta_Bancaria As Integer)
        Dim cConexion As New Conexion
        Dim Saldo As Double
        Saldo = cConexion.SlqExecuteScalar(cConexion.Conectar, "Select dbo.SaldoCuentaBancaria(" & Id_Cuenta_Bancaria & ")")
        cConexion.DesConectar(cConexion.sQlconexion)
        TextEdit1.Text = Saldo
    End Function
#End Region

#Region "Terminar Edicion Cheques"
    Private Sub TxtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarCheque() Then
                Try
                    Me.BindingContext(DsDepositos, "Deposito").EndCurrentEdit()
                    Me.BindingContext(DsDepositos, "Deposito").AddNew()
                    Me.BindingContext(DsDepositos, "Deposito").CancelCurrentEdit()
                    Me.HabilitarDetallesCheques()
                    SimpleNuevo.Focus()
                Catch eEndEdit As System.Data.NoNullAllowedException
                    System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
                End Try
            End If
        End If
    End Sub
#End Region

#Region "Validar Detalle Cheque"
    Function ValidarDetalleCheque(Optional ByVal revisa As Boolean = False) As Boolean
        Dim Totalcheque As Double
        Dim Totaldetalle As Double
        Totalcheque = CalcEdit1.Value
        Totaldetalle = Me.colMonto.SummaryItem.SummaryValue
        If revisa = False Then
            If Totalcheque < Fix((Totaldetalle + CalcEdit2.EditValue) * 100) / 100 Then
                MsgBox("El monto excede el total del Depósito")
                CalcEdit2.Focus()
                Return False
            End If
        Else
            If Totalcheque = Totaldetalle Then
            Else
                MsgBox("El monto del cheque no concuerda con el detalle", MsgBoxStyle.Information)
                CalcEdit2.Focus()
                Return False
            End If
        End If
        Try
            If CalcEdit2.Value <= 0 Then
                MsgBox("Digite un monto Válido", MsgBoxStyle.Information)
                CalcEdit2.Focus()
                Return False
            End If
        Catch ex As Exception
        End Try

        Dim diferencia1 As Double
        Dim a As String
        If Totaldetalle = 0 Then
            diferencia1 = Math.Round(Totalcheque - (Totaldetalle + CalcEdit2.Value), 2)
            Me.TextBox1.Text = Format(diferencia1, "#,#.00")

        Else
            diferencia1 = Math.Round(Totalcheque - (Totaldetalle + CalcEdit2.Value), 2)
            Me.TextBox1.Text = Format(diferencia1, "#,#0.00")
        End If

        If diferencia1 <> 0 Then
            Me.balanceo.Text = "No Balanceado"
        Else
            Me.balanceo.Text = "Balanceado"
            Me.balanceo.ForeColor = Me.balanceo.ForeColor.Blue
        End If

        'Me.DsDepositos.cuentascontable.Clear()
        'BuscarCuentaCont(TxtCuenta.Text)
        'If Me.DsDepositos.cuentascontable.Rows.Count > 0 Then
        Me.SimpleGuardar.Focus()
        'Else
        '    MsgBox("Numero de Cuenta Invalido", MsgBoxStyle.Information)
        '    Me.TxtCuenta.Focus()
        '    Return False
        'End If
        Return True
    End Function
#End Region

#Region "Agregar detalles Cheques"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleNuevo.Click

        If Me.SimpleNuevo.Text = "Nuevo" Then
            Try
                SimpleNuevo.Text = "Cancelar"
                Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").EndCurrentEdit()
                Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").AddNew()
                Me.SimpleGuardar.Enabled = True
                Me.SimpleEliminar.Enabled = False
                dgDeposito.Enabled = False
                Me.txtDescripcion.Text = Me.txtObservaciones.Text()
                txtDescripcion.Focus()
                DsDepositos.CentroCostoDetalle.Clear()
                TotalCentro = 0

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        Else
            DsDepositos.CentroCostoDetalle.Clear()
            EliminaCentro(BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Current("Id_depositoDet"))
            TotalCentro = 0
            Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").CancelCurrentEdit()
            SimpleNuevo.Text = "Nuevo"
            Me.SimpleGuardar.Enabled = False
            Me.SimpleEliminar.Enabled = True
            dgDeposito.Enabled = True
        End If
    End Sub
#End Region

#Region "Guardar Detalles Cheques"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleGuardar.Click
        Try
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = Trim(TxtCuenta.Text)
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TxtCuenta.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.Label10.Text = nombre
                If ValidarDetalleCheque() Then
                    DsDepositos.CentroCostoDetalle.Clear()
                    TotalCentro = 0
                    Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").EndCurrentEdit()
                    SimpleNuevo.Text = "Nuevo"
                    Me.SimpleGuardar.Enabled = False
                    Me.SimpleEliminar.Enabled = True
                    dgDeposito.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Eliminar Detalles Cheques"
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleEliminar.Click
        If Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Count > 0 Then
            Try
                EliminaCentro(BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Current("Id_DepositoDet"))
                Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").RemoveAt(Me.BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Position)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("No existen detalles", MsgBoxStyle.Information)
        End If
    End Sub
#End Region

#Region "Mostrar Monto letras"
    Private Sub CalcEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalcEdit1.EditValueChanged
        'Dim cambio As New cNum2Text
        'Me.TxtMontoLetras.Text = cambio.Numero2Letra(Me.CalcEdit1.EditValue, 0, 2, "Colon", "Centimo", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)
    End Sub
#End Region

#Region "BuscarCuentaContable"
    Private Sub TxtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCuenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            '**********************************      Cambio Elias          ********************************

            'Dim codcue As String
            'Dim buscar As New cFunciones
            'codcue = buscar.BuscarDatos("Select CuentaContable,Descripcion From CuentaContable where Movimiento=1", "Descripcion", "Buscar Cuenta Contable .....", GetSetting("Seesoft", "Contabilidad", "Conexion"))
            'TxtCuenta.Text = codcue
            'Label10.Text = cFunciones.Descripcion

            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Contabilidad", "CONEXION")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
    " where Movimiento=1 " '"select CuentaContable AS [Codigo cuenta],descripcion as Descripcion from Contabilidad.dbo.CuentaContable where  Movimiento = 1  "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            TxtCuenta.Text = busca.codigo
            Label10.Text = busca.descrip

            '**********************************   FIN   Cambio Elias          ********************************

        End If

        If e.KeyCode = Keys.Enter Then

            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = TxtCuenta.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TxtCuenta.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.Label10.Text = nombre
                Me.SimpleGuardar.Focus()
            End If

            'Else
            '    MsgBox("Numero de Cuenta Invalido", MsgBoxStyle.Information)
            '    Me.TxtCuenta.Focus()
            ' End If
        End If
    End Sub


    Private Function BuscarCuentaCont(ByVal cuentaconta As String)
        Dim conectar As SqlConnection = Nothing
        Me.DsDepositos.cuentascontable.Clear()
        Try
            Dim strin As String = GetSetting("Seesoft", "Bancos", "Conexion")
            conectar = New SqlConnection(strin)
            conectar.Open()
            Dim comando As SqlCommand = New SqlCommand
            Dim busc As String = "Select * From cuentascontable where CuentaContable = '" & cuentaconta & "'"
            comando.CommandText = busc
            comando.Connection = conectar
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 90
            comando.Parameters.Add(New SqlParameter("@cuenta", SqlDbType.VarChar))
            comando.Parameters("@cuenta").Value = cuentaconta
            Dim dacuenta As New SqlDataAdapter
            dacuenta.SelectCommand = comando
            dacuenta.Fill(Me.DsDepositos.cuentascontable)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not conectar Is Nothing Then
                conectar.Close()
            End If
        End Try
        If DsDepositos.cuentascontable.Rows.Count > 0 Then
            Me.TxtCuenta.Text = cuentaconta
            Me.Label10.Text = Me.DsDepositos.cuentascontable.Rows(0).Item("Descripcion")
        End If
    End Function
#End Region

#Region "Tab"
    Private Sub CalcEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtCuenta.Focus()
        End If
    End Sub



    Private Sub cboBancos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboBancos.KeyDown

        If e.KeyCode = Keys.Enter Then
            Me.txtNumerodeposito.Focus()
        End If

        If e.KeyCode = Keys.F1 Then
            If Me.ToolBar1.Buttons(0).Text = "Cancelar" Then
                If e.KeyCode = Keys.F1 Then
                    BuscarCuenta()
                End If
            End If
        End If
    End Sub

    Function BuscarCuenta()

        Dim valor As String
        Dim BuscarCuentaBancaria As New BuscarCuentaBancaria
        If BuscarCuentaBancaria.ShowDialog = DialogResult.OK Then
            valor = BuscarCuentaBancaria.Label6.Text
        End If

        If valor = "" Then
            'Me.ComboBox1.SelectedIndex = -1
        Else
            Me.cboBancos.SelectedValue = valor
        End If
    End Function


    Private Sub txtNumerodeposito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumerodeposito.KeyDown
        If e.KeyCode = Keys.Enter Then
            If numero() Then
                Me.DateTimePicker1.Focus()
                Me.txtNumerodeposito.Text = a
            Else
                MessageBox.Show("El número de deposito digitado ya existe..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DateTimePicker1.Value > FechaCon Then
                Me.CalcEdit1.Focus()
            Else
                MsgBox("Fecha Incorrecta")
            End If
        End If
    End Sub

    Private Sub CalcEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtTipoCambio.Focus()
        End If
    End Sub


    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CalcEdit2.Focus()
        End If
    End Sub


    Private Sub txtTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtObservaciones.Focus()
        End If
    End Sub


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fx As New cFunciones
        txtTipoCambio.Text = fx.TipoCambio(DateTimePicker1.Value, True)
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then Anula() Else MsgBox("No tiene permiso para anular este deposito...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()

        End Select
    End Sub
#End Region

#Region "Validar Fecha Conciliacion"
    Function FechaConciliacion()
        Dim cConexion As New Conexion
        FechaCon = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT ISNULL(MAX(Hasta),0) AS FechaMax FROM dbo.Conciliacion where Id_CuentaBancaria = " & cboBancos.SelectedValue)
        cConexion.DesConectar(cConexion.sQlconexion)
    End Function
#End Region

#Region "Asientos Contables"
    Public Sub GuardaAsiento()
        Dim NumeroAsiento As String
        Dim Fx As New cFunciones
        Dim Funciones As New Conexion

        '------------------------------------------------------------------
        'CREA EL ASIENTO CONTABLE
        If EditaAsiento = False Then    'SI NO SE ESTA EDITANDO EL ASIENTO LO CREA NUEVO
            DsDepositos.AsientosContables.Clear()
            DsDepositos.DetallesAsientosContable.Clear()
            NumeroAsiento = Fx.BuscaNumeroAsiento("BCO-" & Format(DateTimePicker1.Value.Month, "00") & Format(DateTimePicker1.Value.Date, "yy") & "-")
            BindingContext(DsDepositos, "AsientosContables").CancelCurrentEdit()
            BindingContext(DsDepositos, "AsientosContables").AddNew()
            BindingContext(DsDepositos, "AsientosContables").Current("NumAsiento") = NumeroAsiento
        Else                            'SI SE ESTA EDITANDO EL ASIENTO BORRA LOS DETALLES PARA VOLVERLOS A CREAR
            If BindingContext(DsDepositos, "AsientosContables").Count < 1 Then
                Exit Sub
            Else
                Funciones.DeleteRecords("DetallesAsientosContable", "NumAsiento ='" & BindingContext(DsDepositos, "AsientosContables").Current("NumAsiento") & "'", "Contabilidad")
            End If
        End If
        BindingContext(DsDepositos, "AsientosContables").Current("Fecha") = DateTimePicker1.Value
        BindingContext(DsDepositos, "AsientosContables").Current("IdNumDoc") = DsDepositos.Deposito(0).Id_Deposito
        BindingContext(DsDepositos, "AsientosContables").Current("NumDoc") = DsDepositos.Deposito(0).NumeroDocumento
        BindingContext(DsDepositos, "AsientosContables").Current("Beneficiario") = ""
        BindingContext(DsDepositos, "AsientosContables").Current("TipoDoc") = 2
        BindingContext(DsDepositos, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsDepositos, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsDepositos, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsDepositos, "AsientosContables").Current("Mayorizado") = 0
        BindingContext(DsDepositos, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(DateTimePicker1.Value)
        BindingContext(DsDepositos, "AsientosContables").Current("NumMayorizado") = 0
        BindingContext(DsDepositos, "AsientosContables").Current("Modulo") = "Depositos"
        BindingContext(DsDepositos, "AsientosContables").Current("Observaciones") = "Deposito # " & DsDepositos.Deposito(0).NumeroDocumento
        BindingContext(DsDepositos, "AsientosContables").Current("NombreUsuario") = TxtNombreUsuario.Text
        BindingContext(DsDepositos, "AsientosContables").Current("TotalDebe") = DsDepositos.Deposito(0).Monto
        BindingContext(DsDepositos, "AsientosContables").Current("TotalHaber") = DsDepositos.Deposito(0).Monto
        BindingContext(DsDepositos, "AsientosContables").Current("CodMoneda") = DsDepositos.Deposito(0).CodigoMoneda
        BindingContext(DsDepositos, "AsientosContables").Current("TipoCambio") = CDbl(txtTipoCambio.Text)
        BindingContext(DsDepositos, "AsientosContables").EndCurrentEdit()
        '------------------------------------------------------------------

        'CREA TODOS LOS DETALLES DEL ASIENTO
        AsientoDetalle()

        '------------------------------------------------------------------
        'ACTUALIZA CENTROS DE COSTOS
        If DsDepositos.CentroCosto_Movimientos.Count > 0 Then
            For i As Integer = 0 To DsDepositos.CentroCosto_Movimientos.Count - 1 'LE ASIGNA EL NUMERO DE ASIENTO Y DE DOCUMENTO A LOS CENTROS DE COSTO
                DsDepositos.CentroCosto_Movimientos.Item(i).IdAsiento = BindingContext(DsDepositos, "AsientosContables").Current("NumAsiento")
                DsDepositos.CentroCosto_Movimientos.Item(i).Documento = DsDepositos.Deposito(0).NumeroDocumento
            Next i
        End If
        '------------------------------------------------------------------

        'ACTUALIZA EL NUMERO DE ASIENTO AL DEPOSITO
        Funciones.UpdateRecords("Deposito", "Contabilizado = 1, Asiento = '" & BindingContext(DsDepositos, "AsientosContables").Current("NumAsiento") & "'", "Id_Deposito = " & DsDepositos.Deposito(0).Id_Deposito, "Bancos")
    End Sub


    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String, ByVal Descripcion As String)
        If Monto <> 0 Then      'CREA LOS DETALLES DE ASIENTOS CONTABLES
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsDepositos, "AsientosContables").Current("NumAsiento")
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = Descripcion
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = CDbl(txtTipoCambio.Text)
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        End If
    End Sub


    Private Sub AsientoDetalle()
        Try
            If DsDepositos.Deposito_Detalle.Count > 0 Then
                '------------------------------------------------------------------
                'GUARDA EL DETALLE PARA LA CUENTA BANCARIA (DEBE)
                GuardaAsientoDetalle(DsDepositos.Deposito(0).Monto, True, False, BindingContext(DsDepositos, "Cuentas_bancarias").Current("CuentaContable"), BindingContext(DsDepositos, "Cuentas_bancarias").Current("NombreCuentaContable"), DsDepositos.Deposito(0).Concepto)
                '------------------------------------------------------------------

                '------------------------------------------------------------------
                'GUARDA ASIENTOS PARA LOS DETALLES DEL DEPOSITO (HABER)
                For i As Integer = 0 To DsDepositos.Deposito_Detalle.Count - 1
                    GuardaAsientoDetalle(DsDepositos.Deposito_Detalle(i).Monto, False, True, DsDepositos.Deposito_Detalle(i).CuentaContable, DsDepositos.Deposito_Detalle(i).NombreCuenta, DsDepositos.Deposito_Detalle(i).DescripcionMov)
                Next i
                '------------------------------------------------------------------
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Function TransAsiento() As Boolean  'REALIZA LA TRANSACCIÓN DE LOS ASIENTOS CONTABLES
        Dim Trans As SqlTransaction

        Try
            If SqlConnection2.State <> SqlConnection2.State.Open Then SqlConnection2.Open()

            Trans = SqlConnection2.BeginTransaction
            BindingContext(DsDepositos, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsDepositos, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = Trans
            AdapterDetallesAsientos.DeleteCommand.Transaction = Trans
            AdapterDetallesAsientos.InsertCommand.Transaction = Trans

            AdapterAsientos.UpdateCommand.Transaction = Trans
            AdapterAsientos.DeleteCommand.Transaction = Trans
            AdapterAsientos.InsertCommand.Transaction = Trans

            AdapterCentroCostoMovimiento.UpdateCommand.Transaction = Trans
            AdapterCentroCostoMovimiento.DeleteCommand.Transaction = Trans
            AdapterCentroCostoMovimiento.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterDetallesAsientos.Update(DsDepositos.DetallesAsientosContable)
            AdapterAsientos.Update(DsDepositos.AsientosContables)
            AdapterCentroCostoMovimiento.Update(DsDepositos.CentroCosto_Movimientos)
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function


    Function CargarAsiento(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Contabilidad", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "Select * From AsientosContables WHERE IdNumDoc = " & Id & " AND Modulo = 'Depositos'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            DsDepositos.DetallesAsientosContable.Clear()
            DsDepositos.AsientosContables.Clear()
            da.Fill(DsDepositos.AsientosContables)

            If DsDepositos.AsientosContables.Count < 1 Then
                DsDepositos.AsientosContables.Clear()
            Else
                EditaAsiento = True
                CargarCentroCosto(DsDepositos.AsientosContables(0).NumAsiento)
            End If

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

#Region "Centro de Costo"

#Region "Botones"
    Private Sub BCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCentroCosto.Click
        If BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Count > 0 Then
            If CalcEdit1.Value < 1 Then
                MsgBox("Por favor revise Monto", MsgBoxStyle.Critical, "Datos Incorrectos")
                Exit Sub
            End If

            If TxtCuenta.Text = "" Or Label10.Text = "" Then
                MsgBox("Por favor revise la Cuenta Contable", MsgBoxStyle.Critical, "Datos Incorrectos")
                Exit Sub
            End If

            CargaCentro(BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Current("Id_DepositoDet"))
            TxtDetalle.Text = CalcEdit2.Value
            Panel_Centrar()
            BNuevo.Focus()
        Else
            MsgBox("Debe de Agregar un detalle del Deposito", MsgBoxStyle.Critical, "Datos Incorrectos")
        End If
    End Sub


    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        If BNuevo.Text = "Nuevo" Then
            AgregaCentro()
            Controles(True)
            BNuevo.Text = "Cancelar"
            ButtonAgregarDetalle.Enabled = True
            EditDescripcionCC.Text = txtDescripcion.Text
            CBCentroCosto.Focus()
        Else
            BindingContext(DsDepositos, "CentroCosto_Movimientos").CancelCurrentEdit()
            TxtDetalle.Text = CalcEdit2.Value
            Controles(False)
            BNuevo.Text = "Nuevo"
            ButtonAgregarDetalle.Enabled = False
        End If
    End Sub


    Private Sub ButtonAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarDetalle.Click
        If TotalCentro > CDbl(TxtDetalle.Text) Or (CDbl(TxtDetalle.Text) < CDbl(txtMontoCentroCosto.Text) + TotalCentro) Then
            MsgBox("El monto es incorrecto, falta por asignar " & (CDbl(TxtDetalle.Text) - TotalCentro), MsgBoxStyle.Critical, "Favor Revisar el Monto")
            txtMontoCentroCosto.Focus()
            Exit Sub
        End If

        If CDbl(txtMontoCentroCosto.Text) <= 0 Then
            MsgBox("El monto no puede ser " & CDbl(txtMontoCentroCosto.Text), MsgBoxStyle.Critical, "Favor Revisar el Monto")
            txtMontoCentroCosto.Focus()
            Exit Sub
        End If

        TotalCentro += CDbl(txtMontoCentroCosto.Text)
        LlenaGridCentro(CBCentroCosto.Text, CDbl(txtMontoCentroCosto.Text), EditDescripcionCC.Text, BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("Id"))
5:      BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("IdCentroCosto") = CBCentroCosto.SelectedValue
        BindingContext(DsDepositos, "CentroCosto_Movimientos").EndCurrentEdit()
        TxtDetalle.Text = CalcEdit2.Value
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
        BNuevo.Focus()
    End Sub


    Private Sub BotonCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCerrar.Click
        BindingContext(DsDepositos, "CentroCosto_Movimientos").CancelCurrentEdit()
        Panel_Ocultar()
        SimpleGuardar.Focus()
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub
#End Region


#Region "Funciones"
    Public Sub AgregaCentro()
        BindingContext(DsDepositos, "CentroCosto_Movimientos").EndCurrentEdit()
        BindingContext(DsDepositos, "CentroCosto_Movimientos").AddNew()
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("IdAsiento") = "0"
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("Documento") = ""
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("Tipo") = 2
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("Debe") = False
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("Haber") = True
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("Fecha") = DateTimePicker1.Value
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("CuentaContable") = TxtCuenta.Text
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("NombreCuentaContable") = Label10.Text
        BindingContext(DsDepositos, "CentroCosto_Movimientos").Current("IdDetalle") = BindingContext(DsDepositos, "Deposito.DepositoDeposito_Detalle").Current("Id_DepositoDet")
        CBCentroCosto.SelectedIndex = 0
    End Sub


    Public Sub CargaCentro(ByVal id As Integer)
        Dim Centro() As System.Data.DataRow
        TotalCentro = 0
        DsDepositos.CentroCostoDetalle.Clear()
        If DsDepositos.CentroCosto_Movimientos.Count > 0 Then
            For i As Integer = 0 To DsDepositos.CentroCosto_Movimientos.Count - 1
                If DsDepositos.CentroCosto_Movimientos(i).IdDetalle = id Then
                    Centro = DsDepositos.CentroCosto.Select("Id = " & DsDepositos.CentroCosto_Movimientos(i).IdCentroCosto, "Nombre")
                    LlenaGridCentro(Centro(0)(2), DsDepositos.CentroCosto_Movimientos(i).Monto, DsDepositos.CentroCosto_Movimientos(i).Descripcion, DsDepositos.CentroCosto_Movimientos(i).Id)
                    TotalCentro += DsDepositos.CentroCosto_Movimientos(i).Monto
                End If
            Next i
        End If
    End Sub


    Public Sub LlenaGridCentro(ByVal Centro As String, ByVal monto As Double, ByVal descripcion As String, ByVal id As Integer)
        Dim NuevaFila As dsDepositos.CentroCostoDetalleRow
        NuevaFila = DsDepositos.CentroCostoDetalle.NewCentroCostoDetalleRow
        NuevaFila.CentroCosto = Centro
        NuevaFila.Monto = monto
        NuevaFila.Descripcion = descripcion
        NuevaFila.Id = id
        DsDepositos.CentroCostoDetalle.AddCentroCostoDetalleRow(NuevaFila)
    End Sub


    Public Sub EliminaCentro(ByVal id As Integer)
        If DsDepositos.CentroCosto_Movimientos.Count > 0 Then
            For i As Integer = 0 To DsDepositos.CentroCosto_Movimientos.Count - 1
                If DsDepositos.CentroCosto_Movimientos.Item(i).IdDetalle = id Then
                    BindingContext(DsDepositos.CentroCosto_Movimientos).RemoveAt(Me.BindingContext(DsDepositos.CentroCosto_Movimientos).Position)
                End If
            Next i
            If EditaCentro = True Then
                Dim Funcion As New Conexion
                Funcion.DeleteRecords("CentroCosto_Movimientos", "IdDetalle =" & id, "Contabilidad")
            End If
        End If
    End Sub


    Private Sub EliminarDetalleCentro()
        If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        If DsDepositos.CentroCostoDetalle.Count = 0 Then Exit Sub
        Dim posicion, pos, IdCentro As Integer
        posicion = BindingContext(DsDepositos.CentroCostoDetalle).Position()

        For i As Integer = 0 To DsDepositos.CentroCosto_Movimientos.Count - 1
            If DsDepositos.CentroCosto_Movimientos(i).Id = BindingContext(DsDepositos.CentroCostoDetalle).Current("Id") Then
                pos = i
            End If
        Next i
        TotalCentro = (TotalCentro - DsDepositos.CentroCosto_Movimientos(pos).Monto)
        IdCentro = DsDepositos.CentroCosto_Movimientos(pos).Id
        DsDepositos.CentroCosto_Movimientos.Rows.RemoveAt(pos)
        If EditaCentro = True Then
            Dim Funcion As New Conexion
            Funcion.DeleteRecords("CentroCosto_Movimientos", "Id = " & IdCentro, "Contabilidad")
        End If
        BindingContext(DsDepositos, "CentroCosto_Movimientos").EndCurrentEdit()
        DsDepositos.CentroCostoDetalle.Rows.RemoveAt(posicion)

        BindingContext(DsDepositos, "CentroCosto_Movimientos").CancelCurrentEdit()
        TxtDetalle.Text = CalcEdit2.Value
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub


    Function CargarCentroCosto(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Contabilidad", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from CentroCosto_Movimientos WHERE IdAsiento = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            DsDepositos.CentroCosto_Movimientos.Clear()
            DsDepositos.CentroCostoDetalle.Clear()
            da.Fill(DsDepositos.CentroCosto_Movimientos)
            If DsDepositos.CentroCosto_Movimientos.Count < 1 Then
                DsDepositos.CentroCosto_Movimientos.Clear()
                Exit Function
            End If
            EditaCentro = True

        Catch ex As System.Exception
            MsgBox(ex.ToString)

        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function


    Public Sub ActualizaIDCentro()
        If DsDepositos.CentroCosto_Movimientos.Count > 0 Then
            Dim j As Integer = -1
            Dim Id_detalle As Integer
            Dim cConexion As New Conexion
            Id_detalle = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT ISNULL(MAX(Id_DepositoDet),0) FROM dbo.Deposito_Detalle")
            cConexion.DesConectar(cConexion.sQlconexion)

            For i As Integer = 0 To DsDepositos.Deposito_Detalle.Count - 1
                Id_detalle += 1
                For x As Integer = 0 To DsDepositos.CentroCosto_Movimientos.Count - 1
                    If DsDepositos.CentroCosto_Movimientos.Item(x).IdDetalle = j Then
                        DsDepositos.CentroCosto_Movimientos.Item(x).IdDetalle = Id_detalle
                    End If
                Next x
                j -= 1
            Next i
        End If
    End Sub
#End Region


#Region "Otras"
    Private Sub CBCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBCentroCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMontoCentroCosto.Focus()
        End If
    End Sub


    Private Sub txtMontoCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoCentroCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditDescripcionCC.Focus()
        End If
    End Sub


    Private Sub GridCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridCentroCosto.KeyDown
        If e.KeyCode = Keys.Delete Then
            EliminarDetalleCentro()
        End If
    End Sub


    Private Sub EditDescripcionCC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EditDescripcionCC.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAgregarDetalle.Focus()
        End If
    End Sub


    Private Sub Panel_Centrar()
        PanelCentroCosto.Left = (Width - PanelCentroCosto.Width) \ 2
        PanelCentroCosto.Top = (Height - PanelCentroCosto.Height) \ 2
    End Sub


    Private Sub Panel_Ocultar()
        PanelCentroCosto.Left = -PanelCentroCosto.Width
    End Sub

    Private Sub Controles(ByVal estado As Boolean)
        CBCentroCosto.Enabled = estado
        txtMontoCentroCosto.Enabled = estado
        EditDescripcionCC.Enabled = estado
    End Sub
#End Region

#End Region

End Class
