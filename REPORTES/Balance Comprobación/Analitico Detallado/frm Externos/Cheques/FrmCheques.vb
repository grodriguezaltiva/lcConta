Imports System.Data.SqlClient
Imports Utilidades
Imports System.Drawing.Printing
Imports System
Imports System.Data
Imports System.Threading
Imports System.IO

Public Class FrmCheques
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim usuario As New Usuario_Logeado
    Dim usua As Object
    Dim FechaCon As DateTime
    Public desdeConciliacion As Boolean
    Public NumCheque As String = ""
    Public CuentaBancaria As String = ""
    Public modificar As Boolean = True
    Public nuevoMonto As Double = 0
    Public EditaAsiento As Boolean = False
    Public EditaCentro As Boolean = False
    Public CedulaUsuario As String
    Dim TotalCentro As Double = 0
    Dim Conta As Integer = 0
    Dim Conciliacion As Boolean = False
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro
        AddHandler BindingContext(DataSetCheque1, "Cuentas_bancarias").PositionChanged, AddressOf Position_Changed
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtPagese As System.Windows.Forms.TextBox
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtNumCheque As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents DaCuentaBancaria As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaCuentaContable As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaUsuario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Anular As System.Windows.Forms.LinkLabel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CalcEdit2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents SimpleNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LabelSaldo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TxtMontoLetras As System.Windows.Forms.TextBox
    Friend WithEvents DataSetCheque1 As DataSetCheque
    Friend WithEvents DaCheque As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DaChequeDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents diferencia As System.Windows.Forms.Label
    Friend WithEvents Dif As System.Windows.Forms.Label
    Friend WithEvents Balanceo As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DaMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents AdapterConfiguraciones As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtNumConciliacion As System.Windows.Forms.Label
    Friend WithEvents ckConciliado As System.Windows.Forms.CheckBox
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCentroCosto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCentroCostoMovimiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents BCentroCosto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PanelCentroCosto As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents BotonCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCentroCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents ButtonAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditDescripcionCC As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CBCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoCentroCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LTipoCambio As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents RB_Haber As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Debe As System.Windows.Forms.RadioButton
    Friend WithEvents colHaber As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ButtonDep As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCheques))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit
        Me.DataSetCheque1 = New Contabilidad.DataSetCheque
        Me.LTipoCambio = New System.Windows.Forms.Label
        Me.TxtMontoLetras = New System.Windows.Forms.TextBox
        Me.LabelSaldo = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtNumCheque = New DevExpress.XtraEditors.TextEdit
        Me.TxtPagese = New System.Windows.Forms.TextBox
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.CbTipo = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DtFecha = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Anular = New System.Windows.Forms.LinkLabel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.ButtonDep = New System.Windows.Forms.Button
        Me.RB_Haber = New System.Windows.Forms.RadioButton
        Me.RB_Debe = New System.Windows.Forms.RadioButton
        Me.txtNumConciliacion = New System.Windows.Forms.Label
        Me.ckConciliado = New System.Windows.Forms.CheckBox
        Me.Balanceo = New System.Windows.Forms.Label
        Me.Dif = New System.Windows.Forms.Label
        Me.diferencia = New System.Windows.Forms.Label
        Me.CalcEdit2 = New DevExpress.XtraEditors.CalcEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.BCentroCosto = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.Label17 = New System.Windows.Forms.LinkLabel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtCuenta = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colHaber = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.DaCuentaBancaria = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.DaCuentaContable = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.DaUsuario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Label48 = New System.Windows.Forms.Label
        Me.TxtCodUsuario = New System.Windows.Forms.TextBox
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DaCheque = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaChequeDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.DaMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEditar2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.AdapterConfiguraciones = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCentroCosto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCentroCostoMovimiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
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
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.CBCentroCosto = New System.Windows.Forms.ComboBox
        Me.txtMontoCentroCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCheque1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelSaldo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNumCheque.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Controls.Add(Me.LTipoCambio)
        Me.GroupBox1.Controls.Add(Me.TxtMontoLetras)
        Me.GroupBox1.Controls.Add(Me.LabelSaldo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.CalcEdit1)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtNumCheque)
        Me.GroupBox1.Controls.Add(Me.TxtPagese)
        Me.GroupBox1.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox1.Controls.Add(Me.CbTipo)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.DtFecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(0, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cheque"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCheque1, "Cheques.TipoCambio"))
        Me.txtTipoCambio.EditValue = ""
        Me.txtTipoCambio.Location = New System.Drawing.Point(392, 74)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        '
        'txtTipoCambio.Properties
        '
        Me.txtTipoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTipoCambio.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtTipoCambio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTipoCambio.Size = New System.Drawing.Size(80, 24)
        Me.txtTipoCambio.TabIndex = 173
        '
        'DataSetCheque1
        '
        Me.DataSetCheque1.DataSetName = "DataSetCheque"
        Me.DataSetCheque1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'LTipoCambio
        '
        Me.LTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTipoCambio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTipoCambio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LTipoCambio.Location = New System.Drawing.Point(392, 60)
        Me.LTipoCambio.Name = "LTipoCambio"
        Me.LTipoCambio.Size = New System.Drawing.Size(80, 16)
        Me.LTipoCambio.TabIndex = 172
        Me.LTipoCambio.Text = "Tipo Cambio"
        Me.LTipoCambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtMontoLetras
        '
        Me.TxtMontoLetras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMontoLetras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMontoLetras.Enabled = False
        Me.TxtMontoLetras.Location = New System.Drawing.Point(8, 153)
        Me.TxtMontoLetras.Name = "TxtMontoLetras"
        Me.TxtMontoLetras.Size = New System.Drawing.Size(616, 23)
        Me.TxtMontoLetras.TabIndex = 171
        Me.TxtMontoLetras.Text = ""
        Me.TxtMontoLetras.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSaldo
        '
        Me.LabelSaldo.EditValue = ""
        Me.LabelSaldo.Location = New System.Drawing.Point(480, 72)
        Me.LabelSaldo.Name = "LabelSaldo"
        '
        'LabelSaldo.Properties
        '
        Me.LabelSaldo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.LabelSaldo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.LabelSaldo.Properties.Enabled = False
        Me.LabelSaldo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.LabelSaldo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelSaldo.Size = New System.Drawing.Size(144, 24)
        Me.LabelSaldo.TabIndex = 170
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(304, 75)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 20)
        Me.Label16.TabIndex = 169
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(304, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 16)
        Me.Label18.TabIndex = 168
        Me.Label18.Text = "Moneda"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(8, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(288, 20)
        Me.Label14.TabIndex = 167
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(288, 16)
        Me.Label15.TabIndex = 166
        Me.Label15.Text = "Banco"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataSetCheque1
        Me.ComboBox1.DisplayMember = "Cuentas_bancarias.Cuenta"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(8, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(368, 24)
        Me.ComboBox1.TabIndex = 165
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(480, 59)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 16)
        Me.Label13.TabIndex = 162
        Me.Label13.Text = "Saldo Cuenta"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Location = New System.Drawing.Point(448, 115)
        Me.CalcEdit1.Name = "CalcEdit1"
        '
        'CalcEdit1.Properties
        '
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.CalcEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CalcEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.CalcEdit1.Properties.StyleBorder = New DevExpress.Utils.ViewStyle("ControlStyleBorder", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), False, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.WindowText, System.Drawing.SystemColors.Control)
        Me.CalcEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CalcEdit1.Size = New System.Drawing.Size(180, 21)
        Me.CalcEdit1.TabIndex = 161
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(616, 16)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "Observaciones"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNumCheque
        '
        Me.TxtNumCheque.EditValue = ""
        Me.TxtNumCheque.Location = New System.Drawing.Point(528, 32)
        Me.TxtNumCheque.Name = "TxtNumCheque"
        Me.TxtNumCheque.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtNumCheque.Size = New System.Drawing.Size(96, 21)
        Me.TxtNumCheque.TabIndex = 4
        '
        'TxtPagese
        '
        Me.TxtPagese.AutoSize = False
        Me.TxtPagese.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPagese.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtPagese.Location = New System.Drawing.Point(120, 116)
        Me.TxtPagese.Name = "TxtPagese"
        Me.TxtPagese.Size = New System.Drawing.Size(320, 20)
        Me.TxtPagese.TabIndex = 7
        Me.TxtPagese.Text = ""
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.AutoSize = False
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtObservaciones.Location = New System.Drawing.Point(8, 196)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TxtObservaciones.Size = New System.Drawing.Size(616, 20)
        Me.TxtObservaciones.TabIndex = 9
        Me.TxtObservaciones.Text = ""
        '
        'CbTipo
        '
        Me.CbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbTipo.Items.AddRange(New Object() {"CHEQUE", "TRANSFERENCIA"})
        Me.CbTipo.Location = New System.Drawing.Point(381, 32)
        Me.CbTipo.Name = "CbTipo"
        Me.CbTipo.Size = New System.Drawing.Size(144, 24)
        Me.CbTipo.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Label11.Location = New System.Drawing.Point(381, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 16)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Tipo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DtFecha.Location = New System.Drawing.Point(8, 116)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(104, 23)
        Me.DtFecha.TabIndex = 152
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(616, 16)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Monto en letras"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(120, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(320, 16)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Paguese a la orden de:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(448, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(180, 16)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Monto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(8, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(528, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "Documento Nº"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Cuenta Bancaria"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Anular
        '
        Me.Anular.Font = New System.Drawing.Font("Arial", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anular.ForeColor = System.Drawing.Color.Firebrick
        Me.Anular.LinkColor = System.Drawing.Color.Red
        Me.Anular.Location = New System.Drawing.Point(128, 112)
        Me.Anular.Name = "Anular"
        Me.Anular.Size = New System.Drawing.Size(328, 96)
        Me.Anular.TabIndex = 16
        Me.Anular.TabStop = True
        Me.Anular.Text = "ANULADO"
        Me.Anular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Anular.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ButtonDep)
        Me.GroupBox4.Controls.Add(Me.Anular)
        Me.GroupBox4.Controls.Add(Me.RB_Haber)
        Me.GroupBox4.Controls.Add(Me.RB_Debe)
        Me.GroupBox4.Controls.Add(Me.txtNumConciliacion)
        Me.GroupBox4.Controls.Add(Me.ckConciliado)
        Me.GroupBox4.Controls.Add(Me.Balanceo)
        Me.GroupBox4.Controls.Add(Me.Dif)
        Me.GroupBox4.Controls.Add(Me.diferencia)
        Me.GroupBox4.Controls.Add(Me.CalcEdit2)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox4.Controls.Add(Me.GridControl1)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox4.Location = New System.Drawing.Point(0, 263)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(632, 257)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de cheque"
        '
        'ButtonDep
        '
        Me.ButtonDep.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDep.Location = New System.Drawing.Point(160, 232)
        Me.ButtonDep.Name = "ButtonDep"
        Me.ButtonDep.Size = New System.Drawing.Size(56, 23)
        Me.ButtonDep.TabIndex = 177
        Me.ButtonDep.Text = "Dep"
        '
        'RB_Haber
        '
        Me.RB_Haber.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetCheque1, "Cheques.ChequesCheques_Detalle.Haber"))
        Me.RB_Haber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Haber.Location = New System.Drawing.Point(400, 32)
        Me.RB_Haber.Name = "RB_Haber"
        Me.RB_Haber.Size = New System.Drawing.Size(64, 16)
        Me.RB_Haber.TabIndex = 176
        Me.RB_Haber.Text = "Haber"
        '
        'RB_Debe
        '
        Me.RB_Debe.Checked = True
        Me.RB_Debe.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetCheque1, "Cheques.ChequesCheques_Detalle.Debe"))
        Me.RB_Debe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_Debe.Location = New System.Drawing.Point(400, 16)
        Me.RB_Debe.Name = "RB_Debe"
        Me.RB_Debe.Size = New System.Drawing.Size(64, 16)
        Me.RB_Debe.TabIndex = 175
        Me.RB_Debe.TabStop = True
        Me.RB_Debe.Text = "Debe"
        '
        'txtNumConciliacion
        '
        Me.txtNumConciliacion.Enabled = False
        Me.txtNumConciliacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumConciliacion.Location = New System.Drawing.Point(104, 233)
        Me.txtNumConciliacion.Name = "txtNumConciliacion"
        Me.txtNumConciliacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumConciliacion.Size = New System.Drawing.Size(32, 16)
        Me.txtNumConciliacion.TabIndex = 172
        '
        'ckConciliado
        '
        Me.ckConciliado.Enabled = False
        Me.ckConciliado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConciliado.Location = New System.Drawing.Point(8, 235)
        Me.ckConciliado.Name = "ckConciliado"
        Me.ckConciliado.Size = New System.Drawing.Size(88, 16)
        Me.ckConciliado.TabIndex = 171
        Me.ckConciliado.Text = "Conciliado"
        '
        'Balanceo
        '
        Me.Balanceo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balanceo.Location = New System.Drawing.Point(488, 233)
        Me.Balanceo.Name = "Balanceo"
        Me.Balanceo.Size = New System.Drawing.Size(96, 16)
        Me.Balanceo.TabIndex = 165
        '
        'Dif
        '
        Me.Dif.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dif.Location = New System.Drawing.Point(320, 232)
        Me.Dif.Name = "Dif"
        Me.Dif.Size = New System.Drawing.Size(32, 16)
        Me.Dif.TabIndex = 164
        Me.Dif.Text = "Dif.:"
        '
        'diferencia
        '
        Me.diferencia.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diferencia.Location = New System.Drawing.Point(360, 232)
        Me.diferencia.Name = "diferencia"
        Me.diferencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.diferencia.Size = New System.Drawing.Size(88, 16)
        Me.diferencia.TabIndex = 163
        '
        'CalcEdit2
        '
        Me.CalcEdit2.Location = New System.Drawing.Point(472, 32)
        Me.CalcEdit2.Name = "CalcEdit2"
        '
        'CalcEdit2.Properties
        '
        Me.CalcEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.CalcEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CalcEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CalcEdit2.Size = New System.Drawing.Size(152, 21)
        Me.CalcEdit2.TabIndex = 162
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BCentroCosto)
        Me.Panel1.Controls.Add(Me.SimpleNuevo)
        Me.Panel1.Controls.Add(Me.SimpleGuardar)
        Me.Panel1.Controls.Add(Me.SimpleEliminar)
        Me.Panel1.Location = New System.Drawing.Point(8, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 48)
        Me.Panel1.TabIndex = 67
        '
        'BCentroCosto
        '
        Me.BCentroCosto.Location = New System.Drawing.Point(80, 0)
        Me.BCentroCosto.Name = "BCentroCosto"
        Me.BCentroCosto.Size = New System.Drawing.Size(160, 23)
        Me.BCentroCosto.TabIndex = 67
        Me.BCentroCosto.Text = "Centro Costo"
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
        'SimpleEliminar
        '
        Me.SimpleEliminar.Location = New System.Drawing.Point(160, 24)
        Me.SimpleEliminar.Name = "SimpleEliminar"
        Me.SimpleEliminar.TabIndex = 66
        Me.SimpleEliminar.Text = "Eliminar"
        '
        'Label17
        '
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.LinkColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(8, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(384, 16)
        Me.Label17.TabIndex = 62
        Me.Label17.TabStop = True
        Me.Label17.Text = "Descripción General"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.TxtCuenta)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Location = New System.Drawing.Point(256, 56)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(368, 56)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contabilidad"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(144, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(216, 23)
        Me.Label19.TabIndex = 165
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCuenta
        '
        Me.TxtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCuenta.Location = New System.Drawing.Point(8, 32)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(136, 23)
        Me.TxtCuenta.TabIndex = 13
        Me.TxtCuenta.Text = ""
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(352, 16)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Cuenta Contable"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AutoSize = False
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(8, 32)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(384, 20)
        Me.TxtDescripcion.TabIndex = 11
        Me.TxtDescripcion.Text = ""
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "Cheques.ChequesCheques_Detalle"
        Me.GridControl1.DataSource = Me.DataSetCheque1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 112)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(616, 120)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.Text = "Detalle Cheque"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn4, Me.GridColumn1, Me.GridColumn3, Me.GridColumn2, Me.colHaber})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cta Nombre"
        Me.GridColumn4.FieldName = "Nombre_Cuenta"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 132
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Descripción"
        Me.GridColumn1.FieldName = "Descripcion_Mov"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 2
        Me.GridColumn1.Width = 132
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "# Cta Contable"
        Me.GridColumn3.FieldName = "Cuenta_Contable"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 0
        Me.GridColumn3.Width = 132
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Debe"
        Me.GridColumn2.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn2.FieldName = "MDebe"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 100
        '
        'colHaber
        '
        Me.colHaber.Caption = "Haber"
        Me.colHaber.DisplayFormat.FormatString = "#,#0.00"
        Me.colHaber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colHaber.FieldName = "MHaber"
        Me.colHaber.Name = "colHaber"
        Me.colHaber.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colHaber.SortIndex = 0
        Me.colHaber.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending
        Me.colHaber.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colHaber.VisibleIndex = 4
        Me.colHaber.Width = 100
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(472, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 16)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Monto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(400, 16)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Cuenta Contable"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DaCuentaBancaria
        '
        Me.DaCuentaBancaria.SelectCommand = Me.SqlSelectCommand1
        Me.DaCuentaBancaria.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cuentas_bancarias.Cuenta, Cuentas_bancarias.Codigo_banco, Cuentas_bancaria" & _
        "s.NombreCuenta, Cuentas_bancarias.Id_CuentaBancaria, Bancos.Descripcion, Monedas" & _
        ".MonedaNombre, Monedas.Simbolo, dbo.SaldoCuentaBancaria(Cuentas_bancarias.Id_Cue" & _
        "ntaBancaria) AS Saldo, Cuentas_bancarias.Cod_Moneda, Bancos.Codigo_banco AS Expr" & _
        "1, Cuentas_bancarias.CuentaContable, Cuentas_bancarias.NombreCuentaContable FROM" & _
        " Cuentas_bancarias INNER JOIN Bancos ON Cuentas_bancarias.Codigo_banco = Bancos." & _
        "Codigo_banco INNER JOIN Monedas ON Cuentas_bancarias.Cod_Moneda = Monedas.CodMon" & _
        "eda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Bancos"
        '
        'DaCuentaContable
        '
        Me.DaCuentaContable.SelectCommand = Me.SqlSelectCommand2
        Me.DaCuentaContable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("id", "id")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, PARENTI" & _
        "D, DescCuentaMadre, id FROM CuentaContable"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'DaUsuario
        '
        Me.DaUsuario.SelectCommand = Me.SqlSelectCommand3
        Me.DaUsuario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Cedula, Nombre, Clave_Entrada, Clave_Interna FROM Usuarios"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(336, 544)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 193
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodUsuario
        '
        Me.TxtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodUsuario.Location = New System.Drawing.Point(408, 544)
        Me.TxtCodUsuario.Name = "TxtCodUsuario"
        Me.TxtCodUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtCodUsuario.Size = New System.Drawing.Size(56, 13)
        Me.TxtCodUsuario.TabIndex = 191
        Me.TxtCodUsuario.Text = ""
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(464, 544)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.ReadOnly = True
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.TxtNombreUsuario.TabIndex = 192
        Me.TxtNombreUsuario.Text = ""
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DaCheque
        '
        Me.DaCheque.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaCheque.InsertCommand = Me.SqlInsertCommand1
        Me.DaCheque.SelectCommand = Me.SqlSelectCommand4
        Me.DaCheque.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cheques", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Cheque", "Id_Cheque"), New System.Data.Common.DataColumnMapping("Num_Cheque", "Num_Cheque"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Portador", "Portador"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Conciliado", "Conciliado"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Cuenta_Destino", "Cuenta_Destino"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion"), New System.Data.Common.DataColumnMapping("MontoLetras", "MontoLetras"), New System.Data.Common.DataColumnMapping("CodigoMoneda", "CodigoMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.DaCheque.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Cheques WHERE (Id_Cheque = @Original_Id_Cheque)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cheque", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Cheques(Num_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Concil" & _
        "iado, Anulado, Observaciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destin" & _
        "o, Tipo, Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio) VALUES (@Num_C" & _
        "heque, @Id_CuentaBancaria, @Fecha, @Portador, @Monto, @Conciliado, @Anulado, @Ob" & _
        "servaciones, @Ced_Usuario, @Contabilizado, @Asiento, @Cuenta_Destino, @Tipo, @Nu" & _
        "m_Conciliacion, @MontoLetras, @CodigoMoneda, @TipoCambio); SELECT Id_Cheque, Num" & _
        "_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Conciliado, Anulado, Observa" & _
        "ciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destino, Tipo, Num_Conciliac" & _
        "ion, MontoLetras, CodigoMoneda, TipoCambio FROM Cheques WHERE (Id_Cheque = @@IDE" & _
        "NTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Cheque", System.Data.SqlDbType.BigInt, 8, "Num_Cheque"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Portador", System.Data.SqlDbType.VarChar, 250, "Portador"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Destino", System.Data.SqlDbType.VarChar, 100, "Cuenta_Destino"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoLetras", System.Data.SqlDbType.VarChar, 350, "MontoLetras"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id_Cheque, Num_Cheque, Id_CuentaBancaria, Fecha, Portador, Monto, Concilia" & _
        "do, Anulado, Observaciones, Ced_Usuario, Contabilizado, Asiento, Cuenta_Destino," & _
        " Tipo, Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio FROM Cheques"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Cheques SET Num_Cheque = @Num_Cheque, Id_CuentaBancaria = @Id_CuentaBancar" & _
        "ia, Fecha = @Fecha, Portador = @Portador, Monto = @Monto, Conciliado = @Concilia" & _
        "do, Anulado = @Anulado, Observaciones = @Observaciones, Ced_Usuario = @Ced_Usuar" & _
        "io, Contabilizado = @Contabilizado, Asiento = @Asiento, Cuenta_Destino = @Cuenta" & _
        "_Destino, Tipo = @Tipo, Num_Conciliacion = @Num_Conciliacion, MontoLetras = @Mon" & _
        "toLetras, CodigoMoneda = @CodigoMoneda, TipoCambio = @TipoCambio WHERE (Id_Chequ" & _
        "e = @Original_Id_Cheque); SELECT Id_Cheque, Num_Cheque, Id_CuentaBancaria, Fecha" & _
        ", Portador, Monto, Conciliado, Anulado, Observaciones, Ced_Usuario, Contabilizad" & _
        "o, Asiento, Cuenta_Destino, Tipo, Num_Conciliacion, MontoLetras, CodigoMoneda, T" & _
        "ipoCambio FROM Cheques WHERE (Id_Cheque = @Id_Cheque)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Cheque", System.Data.SqlDbType.BigInt, 8, "Num_Cheque"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Portador", System.Data.SqlDbType.VarChar, 250, "Portador"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Destino", System.Data.SqlDbType.VarChar, 100, "Cuenta_Destino"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 20, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoLetras", System.Data.SqlDbType.VarChar, 350, "MontoLetras"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Cheque", System.Data.SqlDbType.BigInt, 8, "Id_Cheque"))
        '
        'DaChequeDetalle
        '
        Me.DaChequeDetalle.DeleteCommand = Me.SqlDeleteCommand3
        Me.DaChequeDetalle.InsertCommand = Me.SqlInsertCommand4
        Me.DaChequeDetalle.SelectCommand = Me.SqlSelectCommand5
        Me.DaChequeDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cheques_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_ChequeDet", "Id_ChequeDet"), New System.Data.Common.DataColumnMapping("Id_Cheque", "Id_Cheque"), New System.Data.Common.DataColumnMapping("Descripcion_Mov", "Descripcion_Mov"), New System.Data.Common.DataColumnMapping("Cuenta_Contable", "Cuenta_Contable"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Nombre_Cuenta", "Nombre_Cuenta"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Principal", "Principal")})})
        Me.DaChequeDetalle.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Cheques_Detalle WHERE (Id_ChequeDet = @Original_Id_ChequeDet) AND (Cu" & _
        "enta_Contable = @Original_Cuenta_Contable) AND (Debe = @Original_Debe) AND (Desc" & _
        "ripcion_Mov = @Original_Descripcion_Mov) AND (Haber = @Original_Haber) AND (Id_C" & _
        "heque = @Original_Id_Cheque) AND (Monto = @Original_Monto) AND (Nombre_Cuenta = " & _
        "@Original_Nombre_Cuenta) AND (Principal = @Original_Principal)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_ChequeDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ChequeDet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Contable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Contable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion_Mov", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Principal", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Principal", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Cheques_Detalle(Id_Cheque, Descripcion_Mov, Cuenta_Contable, Monto, N" & _
        "ombre_Cuenta, Haber, Debe, Principal) VALUES (@Id_Cheque, @Descripcion_Mov, @Cue" & _
        "nta_Contable, @Monto, @Nombre_Cuenta, @Haber, @Debe, @Principal); SELECT Id_Cheq" & _
        "ueDet, Id_Cheque, Descripcion_Mov, Cuenta_Contable, Monto, Nombre_Cuenta, Haber," & _
        " Debe, Principal FROM Cheques_Detalle WHERE (Id_ChequeDet = @@IDENTITY)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Cheque", System.Data.SqlDbType.BigInt, 8, "Id_Cheque"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, "Descripcion_Mov"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Contable", System.Data.SqlDbType.VarChar, 75, "Cuenta_Contable"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cuenta", System.Data.SqlDbType.VarChar, 250, "Nombre_Cuenta"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Principal", System.Data.SqlDbType.Bit, 1, "Principal"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id_ChequeDet, Id_Cheque, Descripcion_Mov, Cuenta_Contable, Monto, Nombre_C" & _
        "uenta, Haber, Debe, Principal FROM Cheques_Detalle"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Cheques_Detalle SET Id_Cheque = @Id_Cheque, Descripcion_Mov = @Descripcion" & _
        "_Mov, Cuenta_Contable = @Cuenta_Contable, Monto = @Monto, Nombre_Cuenta = @Nombr" & _
        "e_Cuenta, Haber = @Haber, Debe = @Debe, Principal = @Principal WHERE (Id_ChequeD" & _
        "et = @Original_Id_ChequeDet) AND (Cuenta_Contable = @Original_Cuenta_Contable) A" & _
        "ND (Debe = @Original_Debe) AND (Descripcion_Mov = @Original_Descripcion_Mov) AND" & _
        " (Haber = @Original_Haber) AND (Id_Cheque = @Original_Id_Cheque) AND (Monto = @O" & _
        "riginal_Monto) AND (Nombre_Cuenta = @Original_Nombre_Cuenta) AND (Principal = @O" & _
        "riginal_Principal); SELECT Id_ChequeDet, Id_Cheque, Descripcion_Mov, Cuenta_Cont" & _
        "able, Monto, Nombre_Cuenta, Haber, Debe, Principal FROM Cheques_Detalle WHERE (I" & _
        "d_ChequeDet = @Id_ChequeDet)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Cheque", System.Data.SqlDbType.BigInt, 8, "Id_Cheque"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, "Descripcion_Mov"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Contable", System.Data.SqlDbType.VarChar, 75, "Cuenta_Contable"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Cuenta", System.Data.SqlDbType.VarChar, 250, "Nombre_Cuenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Principal", System.Data.SqlDbType.Bit, 1, "Principal"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_ChequeDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_ChequeDet", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Contable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Contable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion_Mov", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Cheque", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cheque", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Cuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Principal", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Principal", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_ChequeDet", System.Data.SqlDbType.BigInt, 8, "Id_ChequeDet"))
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand6
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monedas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Monedas"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'DaMoneda
        '
        Me.DaMoneda.InsertCommand = Me.SqlInsertCommand2
        Me.DaMoneda.SelectCommand = Me.SqlSelectCommand7
        Me.DaMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
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
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
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
        Me.TituloModulo.Size = New System.Drawing.Size(632, 32)
        Me.TituloModulo.TabIndex = 198
        Me.TituloModulo.Text = "Cheques / Trasferencias"
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 533)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(632, 56)
        Me.ToolBar1.TabIndex = 199
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
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
        'AdapterConfiguraciones
        '
        Me.AdapterConfiguraciones.InsertCommand = Me.SqlInsertCommand6
        Me.AdapterConfiguraciones.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterConfiguraciones.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Configuraciones", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cedula", "Cedula"), New System.Data.Common.DataColumnMapping("Empresa", "Empresa"), New System.Data.Common.DataColumnMapping("FormatoCheck", "FormatoCheck")})})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO Configuraciones(Cedula, Empresa, FormatoCheck) VALUES (@Cedula, @Empr" & _
        "esa, @FormatoCheck); SELECT Cedula, Empresa, FormatoCheck FROM Configuraciones"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cedula", System.Data.SqlDbType.VarChar, 255, "Cedula"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Empresa", System.Data.SqlDbType.VarChar, 255, "Empresa"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormatoCheck", System.Data.SqlDbType.Bit, 1, "FormatoCheck"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT Cedula, Empresa, FormatoCheck FROM Configuraciones"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand9
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
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection3
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
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, A" & _
        "ccion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observ" & _
        "aciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc) " & _
        "VALUES (@NumAsiento, @Fecha, @NumDoc, @Beneficiario, @TipoDoc, @Accion, @Anulado" & _
        ", @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Observaciones," & _
        " @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio, @IdNumDoc); S" & _
        "ELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection3
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM AsientosContables"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection3
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
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection3
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
        Me.AdapterDetallesAsientos.SelectCommand = Me.SqlSelectCommand10
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (Tipocambio = @Original_Tipocambio OR @Original_Tipocambio" & _
        " IS NULL AND Tipocambio IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection3
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
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "pocambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection3
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection3
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
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection3
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
        'AdapterCentroCosto
        '
        Me.AdapterCentroCosto.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterCentroCosto.InsertCommand = Me.SqlInsertCommand7
        Me.AdapterCentroCosto.SelectCommand = Me.SqlSelectCommand11
        Me.AdapterCentroCosto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdapterCentroCosto.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM CentroCosto WHERE (Id = @Original_Id) AND (Codigo = @Original_Codigo)" & _
        " AND (Nombre = @Original_Nombre)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO CentroCosto(Codigo, Nombre) VALUES (@Codigo, @Nombre); SELECT Id, Cod" & _
        "igo, Nombre FROM CentroCosto WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection3
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = "SELECT Id, Codigo, Nombre FROM CentroCosto"
        Me.SqlSelectCommand11.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE CentroCosto SET Codigo = @Codigo, Nombre = @Nombre WHERE (Id = @Original_I" & _
        "d) AND (Codigo = @Original_Codigo) AND (Nombre = @Original_Nombre); SELECT Id, C" & _
        "odigo, Nombre FROM CentroCosto WHERE (Id = @Id)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection3
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
        Me.AdapterCentroCostoMovimiento.InsertCommand = Me.SqlInsertCommand8
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
        Me.SqlDeleteCommand6.Connection = Me.SqlConnection3
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
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO CentroCosto_Movimientos(IdAsiento, Documento, Fecha, IdCentroCosto, M" & _
        "onto, Debe, Haber, Descripcion, CuentaContable, NombreCuentaContable, Tipo, IdDe" & _
        "talle) VALUES (@IdAsiento, @Documento, @Fecha, @IdCentroCosto, @Monto, @Debe, @H" & _
        "aber, @Descripcion, @CuentaContable, @NombreCuentaContable, @Tipo, @IdDetalle); " & _
        "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descr" & _
        "ipcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_M" & _
        "ovimientos WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection3
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"))
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descri" & _
        "pcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_Mo" & _
        "vimientos"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection3
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
        Me.SqlUpdateCommand6.Connection = Me.SqlConnection3
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
        Me.PanelCentroCosto.Controls.Add(Me.Label22)
        Me.PanelCentroCosto.Location = New System.Drawing.Point(-400, 184)
        Me.PanelCentroCosto.Name = "PanelCentroCosto"
        Me.PanelCentroCosto.Size = New System.Drawing.Size(400, 219)
        Me.PanelCentroCosto.TabIndex = 202
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
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label21)
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
        Me.GridCentroCosto.DataSource = Me.DataSetCheque1.CentroCostoDetalle
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
        Me.EditDescripcionCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCheque1, "CentroCosto_Movimientos.Descripcion"))
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
        Me.EditDescripcionCC.Size = New System.Drawing.Size(216, 21)
        Me.EditDescripcionCC.TabIndex = 199
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Monto"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(8, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Centro de Costo"
        '
        'CBCentroCosto
        '
        Me.CBCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetCheque1, "CentroCosto_Movimientos.IdCentroCosto"))
        Me.CBCentroCosto.DataSource = Me.DataSetCheque1
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
        Me.txtMontoCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetCheque1, "CentroCosto_Movimientos.Monto"))
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
        Me.txtMontoCentroCosto.Size = New System.Drawing.Size(104, 21)
        Me.txtMontoCentroCosto.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(48, 1)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(269, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Centro de Costo"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCheques
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(632, 589)
        Me.Controls.Add(Me.PanelCentroCosto)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.TxtCodUsuario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.MaximumSize = New System.Drawing.Size(640, 616)
        Me.MinimumSize = New System.Drawing.Size(640, 616)
        Me.Name = "FrmCheques"
        Me.Text = "Debitos (Cheques / Transferencias)"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCheque1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelSaldo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNumCheque.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private Sub FrmCheques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filas As Integer
        Dim Fx As New cFunciones
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Bancos")
            SqlConnection3.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            Binding()
            InhabilitarChekes()
            TxtCodUsuario.Focus()
            DaUsuario.Fill(DataSetCheque1.Usuarios)
            DaCuentaBancaria.Fill(DataSetCheque1.Cuentas_bancarias)
            DaMoneda.Fill(DataSetCheque1.Moneda)
            AdapterConfiguraciones.Fill(DataSetCheque1.Configuraciones)
            AdapterCentroCosto.Fill(DataSetCheque1.CentroCosto)
            filas = DataSetCheque1.Cuentas_bancarias.Rows.Count()
            ValoresPorDefecto()

            CedulaUsuario = usua.Cedula

            TxtCodUsuario.Text = CedulaUsuario
            If TxtCodUsuario.Text <> "" Then
                Loggin_Usuario()

            End If
            If Me.desdeConciliacion Then
                procesaSolicitud()
            End If

            txtTipoCambio.Text = Fx.TipoCambio(DtFecha.Value, True)

            Me.cargarCheque(Me.Id_Cheque)

        Catch ex As Exception
            If filas = 0 Then
                MsgBox("No se encuentra ninguna cuenta bancaria registrada, no es posible realizar ninguna transacción... ")
            Else
                MsgBox("Problemas al cargar el Formulario, Intente abrir otra vez, si el problema persiste comuniqueselo al administrador del sistema ")
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Sub procesaSolicitud()
        If Me.modificar Then
            Dim dt As New DataTable
            Dim cf As New cFunciones
            'Loggin_Usuario()
            cf.Llenar_Tabla_Generico("SELECT Id_Cheque, Id_CuentaBancaria FROM Cheques WHERE (Num_Cheque = " & Me.NumCheque & ")", dt, Me.SqlConnection1.ConnectionString)
            If dt.Rows.Count = 0 Then
                MsgBox("No se cargo el documento de cheque, Se modifico los datos", MsgBoxStyle.OKOnly)
                Exit Sub
            End If
            Dim IdCheque As String = dt.Rows(0).Item(0)
            Dim IdCuentaBancaria As String = dt.Rows(0).Item(1)
            Me.cargarCheque(IdCheque)
            Editar()
        Else

        End If
    End Sub


    Function ValoresPorDefecto()
        Dim Fx As New cFunciones
        'CHEQUES
        DataSetCheque1.Cheques.Id_ChequeColumn.AutoIncrement = True
        DataSetCheque1.Cheques.Id_ChequeColumn.AutoIncrementSeed = -1
        DataSetCheque1.Cheques.Id_ChequeColumn.AutoIncrementStep = -1
        DataSetCheque1.Cheques.CodigoMonedaColumn.DefaultValue = 1
        DataSetCheque1.Cheques.TipoCambioColumn.DefaultValue = 1
        'CHEQUES DETALLES
        DataSetCheque1.Cheques_Detalle.Id_ChequeDetColumn.AutoIncrement = True
        DataSetCheque1.Cheques_Detalle.Id_ChequeDetColumn.AutoIncrementSeed = -1
        DataSetCheque1.Cheques_Detalle.Id_ChequeDetColumn.AutoIncrementStep = -1
        'CENTRO DE COSTO
        DataSetCheque1.CentroCosto_Movimientos.IdColumn.AutoIncrement = True
        DataSetCheque1.CentroCosto_Movimientos.IdColumn.AutoIncrementSeed = -1
        DataSetCheque1.CentroCosto_Movimientos.IdColumn.AutoIncrementStep = -1

        'Cheques
        DataSetCheque1.Cheques.TipoColumn.DefaultValue = "CHEQUE"
        DataSetCheque1.Cheques.ConciliadoColumn.DefaultValue = 0
        DataSetCheque1.Cheques.ContabilizadoColumn.DefaultValue = 0
        DataSetCheque1.Cheques.AnuladoColumn.DefaultValue = 0
        DataSetCheque1.Cheques.AsientoColumn.DefaultValue = "0"
        DataSetCheque1.Cheques.FechaColumn.DefaultValue = DtFecha.Value
        DataSetCheque1.Cheques.PortadorColumn.DefaultValue = ""
        DataSetCheque1.Cheques.TipoCambioColumn.DefaultValue = Fx.TipoCambio(DtFecha.Value, True)
        DataSetCheque1.Cheques.Num_ChequeColumn.DefaultValue = "0"
        DataSetCheque1.Cheques.MontoColumn.DefaultValue = "0"
        DataSetCheque1.Cheques.ObservacionesColumn.DefaultValue = "--"
        DataSetCheque1.Cheques_Detalle.Descripcion_MovColumn.DefaultValue = "--"
        DataSetCheque1.Cheques.AsientoColumn.DefaultValue = "0"
        DataSetCheque1.Cheques.Cuenta_DestinoColumn.DefaultValue = "0"
        DataSetCheque1.Cheques.Num_ConciliacionColumn.DefaultValue = "0"
        DataSetCheque1.Cheques.Id_CuentaBancariaColumn.DefaultValue = DataSetCheque1.Cuentas_bancarias.Rows(0).Item("Id_CuentaBancaria")
        DataSetCheque1.Cheques_Detalle.MontoColumn.DefaultValue = 0.0
        DataSetCheque1.Cheques_Detalle.Cuenta_ContableColumn.DefaultValue = "0"
        DataSetCheque1.Cheques_Detalle.Nombre_CuentaColumn.DefaultValue = "--"
        DataSetCheque1.Cheques_Detalle.DebeColumn.DefaultValue = True
        DataSetCheque1.Cheques_Detalle.HaberColumn.DefaultValue = False
        DataSetCheque1.Cheques_Detalle.MDebeColumn.DefaultValue = 0.0
        DataSetCheque1.Cheques_Detalle.MHaberColumn.DefaultValue = 0.0
        DataSetCheque1.Cheques_Detalle.PrincipalColumn.DefaultValue = False

        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DataSetCheque1.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DataSetCheque1.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DataSetCheque1.AsientosContables.NumDocColumn.DefaultValue = "0"
        DataSetCheque1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DataSetCheque1.AsientosContables.TipoDocColumn.DefaultValue = 1
        DataSetCheque1.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DataSetCheque1.AsientosContables.AnuladoColumn.DefaultValue = 0
        DataSetCheque1.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DataSetCheque1.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DataSetCheque1.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DataSetCheque1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DataSetCheque1.AsientosContables.ModuloColumn.DefaultValue = "Cheques/Transferencias"
        DataSetCheque1.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DataSetCheque1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DataSetCheque1.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DataSetCheque1.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DataSetCheque1.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DataSetCheque1.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DataSetCheque1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DataSetCheque1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DataSetCheque1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DataSetCheque1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DataSetCheque1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DataSetCheque1.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DataSetCheque1.DetallesAsientosContable.HaberColumn.DefaultValue = 0

        'VALORES POR DEFECTO PARA LA TABLA CENTROS DE COSTO MOVIMIENTOS
        DataSetCheque1.CentroCosto_Movimientos.IdAsientoColumn.DefaultValue = ""
        DataSetCheque1.CentroCosto_Movimientos.DocumentoColumn.DefaultValue = ""
        DataSetCheque1.CentroCosto_Movimientos.FechaColumn.DefaultValue = Now.Date
        DataSetCheque1.CentroCosto_Movimientos.IdCentroCostoColumn.DefaultValue = 0
        DataSetCheque1.CentroCosto_Movimientos.MontoColumn.DefaultValue = 0
        DataSetCheque1.CentroCosto_Movimientos.DebeColumn.DefaultValue = 0
        DataSetCheque1.CentroCosto_Movimientos.HaberColumn.DefaultValue = 0
        DataSetCheque1.CentroCosto_Movimientos.DescripcionColumn.DefaultValue = ""
        DataSetCheque1.CentroCosto_Movimientos.CuentaContableColumn.DefaultValue = ""
        DataSetCheque1.CentroCosto_Movimientos.NombreCuentaContableColumn.DefaultValue = ""
        DataSetCheque1.CentroCosto_Movimientos.TipoColumn.DefaultValue = 1
        DataSetCheque1.CentroCosto_Movimientos.IdDetalleColumn.DefaultValue = 0
    End Function


    Function Binding()
        'Cheques
        TxtNumCheque.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.Num_Cheque"))
        TxtPagese.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.Portador"))
        TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.Observaciones"))
        CbTipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.Tipo"))
        DtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.Fecha"))
        ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DataSetCheque1, "Cheques.Id_CuentaBancaria"))
        ComboBox1.DataSource = DataSetCheque1
        ComboBox1.DisplayMember = "Cuentas_bancarias.Cuenta"
        ComboBox1.ValueMember = "Cuentas_bancarias.Id_CuentaBancaria"
        TxtMontoLetras.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.MontoLetras"))
        Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.ChequesCheques_Detalle.Nombre_Cuenta"))
        CalcEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCheque1, "Cheques.Monto"))
        ckConciliado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", DataSetCheque1, "Cheques.Conciliado"))
        txtNumConciliacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.Num_Conciliacion"))

        'Cheques Detalles
        TxtCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.ChequesCheques_Detalle.Cuenta_Contable"))
        TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cheques.ChequesCheques_Detalle.Descripcion_Mov"))
        CalcEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCheque1, "Cheques.ChequesCheques_Detalle.Monto"))

        'Cuenta Bancaria
        Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cuentas_bancarias.MonedaNombre"))
        Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", DataSetCheque1, "Cuentas_bancarias.Descripcion"))
    End Function
#End Region

#Region "Position Changed"
    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ToolBarNuevo.Text = "Cancelar" Then
            MostrarMontoLetras()
        End If
    End Sub
#End Region

#Region "Logiar Usuario"
    Private Sub TxtCodUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCodUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Loggin_Usuario()
        End If
    End Sub

    Function Loggin_Usuario()
        Try
            If BindingContext(DataSetCheque1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow
                Usuario_autorizadores = DataSetCheque1.Usuarios.Select("Cedula ='" & Me.CedulaUsuario & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    If Me.desdeConciliacion = False Or Me.modificar = False Then
                        ToolBarNuevo.Enabled = True
                        ToolBarRegistrar.Enabled = False
                        ToolBarBuscar.Enabled = True
                        ToolBarEliminar.Enabled = False
                    End If
                    If Me.desdeConciliacion Then
                        ToolBarBuscar.Enabled = False
                    End If
                    Usua = Usuario_autorizadores(0)
                    TxtNombreUsuario.Text = Usua("Nombre")
                    DataSetCheque1.Cheques.Ced_UsuarioColumn.DefaultValue = Usua("Cedula")
                    usuario.Cedula = Usua("Cedula")
                    usuario.Nombre = Usua("Nombre")
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

#Region "Control de Controles"
    Function HabilitarChekes()
        GroupBox1.Enabled = True
        If Conciliacion = True Then
            CalcEdit1.Enabled = False
        Else
            CalcEdit1.Enabled = True
        End If
    End Function

    Function InhabilitarChekes()
        GroupBox1.Enabled = False
        INHabilitarDetallesCheques()
    End Function

    Function HabilitarDetallesCheques()
        GroupBox4.Enabled = True
        SimpleGuardar.Enabled = False
        SimpleEliminar.Enabled = True
        SimpleNuevo.Enabled = True
    End Function

    Function INHabilitarDetallesCheques()
        GroupBox4.Enabled = False
        SimpleGuardar.Enabled = False
        SimpleEliminar.Enabled = True
        SimpleNuevo.Enabled = True
    End Function
#End Region

#Region "Tab"
    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            CbTipo.Focus()
        End If
        If e.KeyCode = Keys.F1 Then
            If ToolBar1.Buttons(0).Text = "Cancelar" Then
                If e.KeyCode = Keys.F1 Then
                    BuscarCuenta()
                End If
            End If
        End If
    End Sub

    Function BuscarCuenta()

        'Dim valor As String
        'Dim BuscarCuentaBancaria As New BuscarCuentaBancaria
        'If BuscarCuentaBancaria.ShowDialog = DialogResult.OK Then
        '    valor = BuscarCuentaBancaria.Label6.Text
        'End If

        'If valor = "" Then
        '    '            ComboBox1.SelectedIndex = -1
        'Else
        '    ComboBox1.SelectedValue = valor
        '    If CbTipo.Text = "CHEQUE" Then
        '        NumeroCheques()
        '    Else
        '        TxtNumCheque.Text = "0"
        '    End If
        'End If
    End Function

    Private Sub CbTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CbTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            BindingContext(DataSetCheque1, "Cheques").Current("Tipo") = CbTipo.Text
            TxtNumCheque.Focus()
        End If
    End Sub

    Private Sub TxtNumCheque_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumCheque.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim Cheque As String
            Dim Num_Cheque As Long = TxtNumCheque.Text
            Cheque = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Id_Cheque FROM Cheques   WHERE Num_CHEQUE = " & Num_Cheque & "AND Id_CuentaBancaria = " & ComboBox1.SelectedValue)
            Cx.DesConectar(Cx.sQlconexion)
            If Cheque = "" Then
                DtFecha.Focus()
            Else
                MsgBox("Ya existe un cheque de esta cuenta con este numero")
                TxtNumCheque.Focus()
            End If
        End If
    End Sub

    Private Sub DtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DtFecha.Value > FechaCon Then
                txtTipoCambio.Focus()
            Else
                MsgBox("Fecha Incorrecta")
            End If
        End If
    End Sub

    Private Sub CalcEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ToolBarEditar2.Text = "Editar" Then
                If ValidarMontoSaldo() Then
                    If GroupBox4.Enabled = True Then
                        IngresaHaber(True)
                    End If
                    TxtObservaciones.Focus()
                End If
            Else
                IngresaHaber(True)
                TxtObservaciones.Focus()
            End If
        End If
    End Sub


    Private Sub DtFecha_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtFecha.ValueChanged
        Dim fx As New cFunciones
        txtTipoCambio.Text = fx.TipoCambio(DtFecha.Value, True)
    End Sub


    Function ValidarMontoSaldo() As Boolean
        Dim Saldo As Double = LabelSaldo.EditValue
        If CalcEdit1.Value > Saldo Then
            If MsgBox("Desea Girar un cheque sin fondos?, Revise el monto¡", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Return True
            Else
                CalcEdit1.Focus()
                Return False
            End If
        Else
            Return True
        End If
    End Function

    Private Sub TxtPagese_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtPagese.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalcEdit1.Focus()
        ElseIf e.KeyCode = Keys.F1 Then
            Dim cf As New cFunciones
            Dim cod As String = cf.BuscarDatos("SELECT CodigoProv AS Identificación, Nombre AS Proveedor FROM Proveedores", "Nombre", "Busqueda de Proveedor...",Configuracion.Claves.Conexion("Proveeduria"))
            Dim dt As New DataTable
            cf.Llenar_Tabla_Generico("SELECT CodigoProv, Nombre, Observaciones FROM Proveedores WHERE CodigoProv = " & cod, dt,Configuracion.Claves.Conexion("Proveeduria"))
            If dt.Rows.Count > 0 Then
                Me.TxtPagese.Text = dt.Rows(0).Item("Observaciones")
                Me.TxtObservaciones.Text = dt.Rows(0).Item("Nombre")
            End If

        End If
    End Sub

    Private Sub TxtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            CalcEdit2.Focus()
        End If
    End Sub

    Private Sub CalcEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtCuenta.Focus()
        End If
    End Sub

    Private Sub txtTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtPagese.Focus()
        End If
    End Sub

    Private Sub CbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbTipo.SelectedIndexChanged
        If ToolBar1.Buttons(0).Text = "Cancelar" Then
            BindingContext(DataSetCheque1, "Cheques").Current("Tipo") = CbTipo.Text
            If CbTipo.Text = "CHEQUE" Then
                NumeroCheques()
            Else
                TxtNumCheque.EditValue = "0"
            End If
        End If
    End Sub

    Private Sub ComboBox1_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedValueChanged
        If ToolBar1.Buttons(0).Text = "Cancelar" Then
            If CbTipo.Text = "CHEQUE" Then
                NumeroCheques()
            Else
                TxtNumCheque.EditValue = "0"
            End If
            Dim cambio As New cNum2Text
            TxtMontoLetras.Text = cambio.Numero2Letra(CalcEdit1.EditValue, 0, 2, Label16.Text, "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)
        End If
    End Sub

    Private Sub CbTipo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CbTipo.KeyPress
        If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Or Not (e.KeyChar = Convert.ToChar(Keys.Enter)) Then e.Handled = True
    End Sub

    Private Sub RB_Debe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Debe.Click, RB_Haber.Click
        CalcEdit2.Focus()
    End Sub
#End Region

#Region "Anular"
    Function Anula()
        Try
            Dim Funciones As New Conexion
            If MsgBox("Desea Anular Cheque\Transferencia", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Function
            End If
            If BindingContext(DataSetCheque1, "Cheques").Current("Conciliado") = True Then
                MsgBox("No es Posible Anular este Cheque ya que ha sido Conciliado !!!!", MsgBoxStyle.Information)
                Exit Function
            End If
            'VALIDA ASIENTO SI TIENE
            If Not Me.BindingContext(Me.DataSetCheque1, "Cheques").Current("Asiento").Equals("0") Then
                Dim dt As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select Mayorizado From AsientosContables WHERE NumAsiento = '" & Me.BindingContext(Me.DataSetCheque1, "Cheques").Current("Asiento") & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item(0) Then
                        MsgBox("El asiento # " & Me.BindingContext(Me.DataSetCheque1, "Cheques").Current("Asiento") & " que corresponde a este ajuste ya esta mayorizado, NO se puede anular", MsgBoxStyle.OKOnly)
                        Exit Function
                    End If
                End If
            End If
            '---------------------------------------
            BindingContext(DataSetCheque1, "Cheques").Current("Anulado") = True
            BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
            Anular.Visible = True

            DaCheque.Update(DataSetCheque1.Cheques)
            MsgBox("Cheque Anulado satisfactoriamente", MsgBoxStyle.Information)
            'VALIDA ASIENTO SI TIENE Y ANULA
            If Not Me.BindingContext(Me.DataSetCheque1, "Cheques").Current("Asiento").Equals("0") Then
                Dim cx As New Conexion
                cx.Conectar("Contabilidad")
                cx.SlqExecute(cx.sQlconexion, "UPDATE AsientosContables Set Anulado = 1 WHERE NumAsiento = '" & BindingContext(DataSetCheque1, "Cheques").Current("Asiento") & "'")
                cx.DesConectar(cx.sQlconexion)
            End If
            '---------------------------------------

            Return True

        Catch ex As Exception
            MsgBox("Error al tratar de anular el cheque, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function
#End Region

#Region "Editar"
    Function Editar()
        Try
            If ToolBarEditar2.Text = "Editar" Then
                Dim Cx As New Conexion

                Dim Id_Cuenta As Integer = ComboBox1.SelectedValue
                ToolBarEditar2.Text = "Cancelar"
                ToolBarEditar2.ImageIndex = 8
                If Me.desdeConciliacion And NumCheque <> "" Then
                    TxtNumCheque.Text = Me.NumCheque
                End If
                
                If Anular.Visible = True Then
                    MsgBox("No se puede editar el cheque porque está anulado", MsgBoxStyle.Information, "Atención...")
                    ToolBarEditar2.Text = "Editar"
                    ToolBarEditar2.ImageIndex = 9
                    Exit Function
                End If

                'Conciliacion = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Conciliado FROM Bancos.dbo.Cheques WHERE(Id_CuentaBancaria = " & Id_Cuenta & "and Num_Cheque =" & TxtNumCheque.Text & ")")
                'Cx.DesConectar(Cx.sQlconexion)
                'If Conciliacion = True Then
                '    MsgBox("El documento está conciliado, no puede cambiar el monto", MsgBoxStyle.Information, "Atención...")
                'End If
                'If DataSetCheque1.AsientosContables.Count > 0 Then
                '    If BindingContext(DataSetCheque1, "AsientosContables").Current("Mayorizado") = True Then
                '        MsgBox("No se puede editar el cheque porque el Asiento esta Mayorizado", MsgBoxStyle.Information, "Atención...")
                '        ToolBarEditar2.Text = "Editar"
                '        ToolBarEditar2.ImageIndex = 9
                '        Exit Function
                '    End If
                'End If
                HabilitarChekes()
                HabilitarDetallesCheques()
                ToolBarNuevo.Enabled = False
                ToolBarBuscar.Enabled = False
                ToolBarRegistrar.Enabled = True
                ToolBarEliminar.Enabled = False
                ToolBarImprimir.Enabled = False
                EditaAsiento = True
            Else
                ToolBarEditar2.Text = "Editar"
                ToolBarEditar2.ImageIndex = 9
                BindingContext(DataSetCheque1, "Cheques").CancelCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
                InhabilitarChekes()
                INHabilitarDetallesCheques()
                ToolBarNuevo.Enabled = True
                ToolBarBuscar.Enabled = True
                ToolBarRegistrar.Enabled = False
                ToolBarEliminar.Enabled = True
                ToolBarImprimir.Enabled = True
                If Me.desdeConciliacion Then
                    DialogResult = DialogResult.Cancel
                End If
                EditaAsiento = False
                EditaCentro = False
            End If

        Catch ex As Exception
            MsgBox("Error al tratar de editar el cheque, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function

#End Region

#Region "Buscar"
    'Function Buscar()
        '    Dim Id_Cheque As String
        '    Dim CuentaBancaria As String
        '    Dim frmBuscar As New FrmBuscador2
        '    Dim codigo As String

        '    frmBuscar.SQLString = "SELECT Cheques.Num_Cheque AS Cheque, Cuentas_bancarias.Cuenta, Cheques.Portador, Cheques.Fecha, Cheques.Monto FROM Cheques INNER JOIN Cuentas_bancarias ON Cheques.Id_CuentaBancaria = Cuentas_bancarias.Id_CuentaBancaria ORDER BY Cheques.Fecha DESC"
        '    frmBuscar.Text = "Buscar Cheques"
        '    frmBuscar.CampoFiltro = "Portador"
        '    frmBuscar.CampoFecha = "Fecha"
        '    frmBuscar.NuevaConexion = SqlConnection1.ConnectionString
        '    frmBuscar.pongaleEsta = "Cheque"
        '    frmBuscar.GridColumn1.Width = 20
        '    frmBuscar.GridColumn4.Width = 50
        '    frmBuscar.GridColumn5.Width = 30
        '    frmBuscar.ShowDialog()

        '    If frmBuscar.Cancelado Then
        '        Exit Function
        '    Else
        '        If IsNothing(frmBuscar.cuentabancaria) Or IsNothing(frmBuscar.Codigo) Then
        '            Exit Function
        '        End If

        '        Id_Cheque = frmBuscar.cuentabancaria
        '        CuentaBancaria = frmBuscar.Codigo
        '    End If
        'cargarCheque(Id_Cheque, CuentaBancaria)
        'End Function


    Public Id_Cheque As String
    Sub cargarCheque(ByVal Id_Cheque As String)
        If Id_Cheque <> "" Then
            Anular.Visible = False
            LabelSaldo.DataBindings.Clear()
            LabelSaldo.Text = ""

            DataSetCheque1.Cuentas_bancarias.Clear()
            DaCuentaBancaria.Fill(DataSetCheque1.Cuentas_bancarias)
            DataSetCheque1.Cheques_Detalle.Clear()
            DataSetCheque1.Cheques.Clear()
            CargarCheques(Id_Cheque)
            CargarDetalleCheque(Id_Cheque)
            If Me.DataSetCheque1.Cheques_Detalle.Count < 1 Then
                CargarDetalle2(Id_Cheque, BindingContext(DataSetCheque1, "Cheques").Current("Asiento"))
            End If

            If DataSetCheque1.Cheques.Rows.Count > 0 Then
                If DataSetCheque1.Cheques.Rows(0).Item("Anulado") = True Then
                    Anular.Visible = True
                    ToolBar1.Buttons(4).Enabled = False
                Else
                    Anular.Visible = False
                    ToolBar1.Buttons(4).Enabled = True
                End If
                MostrarMontoLetras()
                ToolBarImprimir.Enabled = True
                ToolBarRegistrar.Enabled = False
                ToolBarEditar2.Enabled = True
            End If
        End If
    End Sub
#End Region

#Region "Cargar Cheques"
    Function CargarCheques(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Bancos")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from Cheques WHERE Id_Cheque = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(DataSetCheque1.Cheques)
            CargarAsiento(DataSetCheque1.Cheques.Rows(0).Item("Asiento"))

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

    Private Sub CargarDetalle2(ByVal Id As String, ByVal _numAsiento As String)
        Dim dts As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Dim sel As String = "select -1 as Id_ChequeDet, 0 as Id_Cheque, DescripcionAsiento as Descripcion_Mov, Cuenta as Cuenta_Contable, Monto, NombreCuenta as Nombre_Cuenta, Debe, Haber, 0 as Principal, CASE Haber when 0 then 0 else monto end as MHaber, CASE Debe when 0 then 0 else monto end as MDebe  from  dbo.DetallesAsientosContable where NumAsiento = '" & _numAsiento & "'"
        cFunciones.Llenar_Tabla_Generico(sel, dts, Configuracion.Claves.Conexion("Contabilidad"))

        For Each X As DataRow In dts.Rows
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").EndCurrentEdit()
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").AddNew()
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Id_Cheque") = Id
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Descripcion_Mov") = X.Item("Descripcion_Mov")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Cuenta_Contable") = X.Item("Cuenta_Contable")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Monto") = X.Item("Monto")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Nombre_Cuenta") = X.Item("Nombre_Cuenta")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Debe") = X.Item("Debe")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Haber") = X.Item("Haber")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Principal") = False
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MHaber") = X.Item("MHaber")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MDebe") = X.Item("MDebe")
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").EndCurrentEdit()
        Next

    End Sub

    Function CargarDetalleCheque(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Bancos")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select *, Haber * Monto as MHaber, Debe * Monto as MDebe from Cheques_Detalle WHERE Id_Cheque = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(DataSetCheque1.Cheques_Detalle)

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
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8
            Anular.Visible = False
            EditaAsiento = False
            Try 'inicia la edicion

                LabelSaldo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DataSetCheque1, "Cuentas_bancarias.Saldo"))
                DataSetCheque1.Cheques_Detalle.Clear()
                DataSetCheque1.Cheques.Clear()
                DataSetCheque1.CentroCostoDetalle.Clear()
                DataSetCheque1.CentroCosto_Movimientos.Clear()
                DataSetCheque1.AsientosContables.Clear()
                DataSetCheque1.DetallesAsientosContable.Clear()
                BindingContext(DataSetCheque1, "Cheques").CancelCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques").AddNew()
                HabilitarChekes()
                ToolBarBuscar.Enabled = False
                ToolBarNuevo.Enabled = True
                ToolBarEliminar.Enabled = False
                ToolBarRegistrar.Enabled = True
                ToolBarImprimir.Enabled = False
                ToolBarEliminar.Enabled = False
                ToolBarRegistrar.Enabled = True
                NumeroCheques()
                GridControl1.Enabled = True
                ComboBox1.Text = Configuracion.Claves.Configuracion("UltCuenta")
                ComboBox1.Focus()
                diferencia.Text = Format(0, "#,#0.00")

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try

        Else

            Try
                LabelSaldo.DataBindings.Clear()
                LabelSaldo.Text = ""
                DataSetCheque1.CentroCostoDetalle.Clear()
                DataSetCheque1.CentroCosto_Movimientos.Clear()
                DataSetCheque1.AsientosContables.Clear()
                DataSetCheque1.DetallesAsientosContable.Clear()
                BindingContext(DataSetCheque1, "Cheques").CancelCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
                InhabilitarChekes()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                ToolBarBuscar.Enabled = True
                ToolBarNuevo.Enabled = True
                ToolBarEliminar.Enabled = False
                ToolBarRegistrar.Enabled = False
                ToolBarImprimir.Enabled = False
                ToolBarEliminar.Enabled = False
                SimpleNuevo.Text = "Nuevo"
                SimpleGuardar.Enabled = False
                GridControl1.Enabled = True

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function
#End Region

#Region "Validar Cheque"
    Function ValidarCheque() As Boolean
        Try
            If TxtPagese.Text.Length <= 0 Then
                MsgBox("Debes digitar el nombre de a quien se paga ", MsgBoxStyle.Information)
                TxtPagese.Focus()
                Return False
            End If
            If CalcEdit1.Value <= 0 Then
                MsgBox("introduce un monto adecuado", MsgBoxStyle.Information)
                CalcEdit1.Focus()
                Return False
            End If

            If TxtObservaciones.Text.Length = 0 Then
                MsgBox("Debes Ingresar una Observación", MsgBoxStyle.Information)
                TxtObservaciones.Focus()
                Return False
            End If

        Catch ex As Exception
            MsgBox("introduce un monto adecuado", MsgBoxStyle.Information)
            Return False
        End Try

        Dim Cx As New Conexion
        Dim Cheque As String
        Dim Num_Cheque As Integer = TxtNumCheque.Text
        Cheque = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Id_Cheque FROM Cheques WHERE Num_CHEQUE = " & Num_Cheque & "AND Id_CuentaBancaria = " & ComboBox1.SelectedValue)
        Cx.DesConectar(Cx.sQlconexion)
        If Cheque = "" Then
        Else
            MsgBox("Ya existe un cheque de esta cuenta con este numero")
            TxtNumCheque.Focus()
            Return False
        End If
        Return True
    End Function

#End Region

#Region "Validar_Eliminar_DetalleCheque"
    Private Sub spValidarEliminarDetalleCheque(ByVal _Bandera As Integer)
        Dim Cx As New Conexion
        Dim Sql As String
        Sql = "Update Cheques_Detalle set Bandera = " & _Bandera & " where Id_Cheque = (SELECT Id_Cheque FROM [Bancos].[dbo].[Cheques] where [Num_Cheque] = '" & Me.TxtNumCheque.Text & "') "
        Cx.Conectar("Bancos")
        Cx.SlqExecute(Cx.sQlconexion, Sql)
        Cx.DesConectar(cx.sQlconexion)
    End Sub
#End Region

#Region "Guardar"
    Function GuardarCabios() As Boolean
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Dim CodigoMoneda As Integer
        If ToolBar1.Buttons(0).Text = "Cancelar" Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * From Cheques Where Num_Cheque = " & Me.TxtNumCheque.Text & " AND Id_CuentaBancaria = " & Me.ComboBox1.SelectedValue, dt, Configuracion.Claves.Conexion("Bancos"))
            If dt.Rows.Count > 0 Then MsgBox("Ese cheque ya existe", MsgBoxStyle.OKOnly) : Exit Function
        End If


        CodigoMoneda = DataSetCheque1.Cuentas_bancarias(BindingContext(DataSetCheque1, "Cuentas_bancarias").Position).Cod_Moneda
        DataSetCheque1.Cheques(0).CodigoMoneda = CodigoMoneda

        Try
            spValidarEliminarDetalleCheque(1) ' Valida que se pueda eliminar un registro de Cheque_Detalle
            DaCheque.InsertCommand.Transaction = Trans
            DaCheque.UpdateCommand.Transaction = Trans
            DaCheque.DeleteCommand.Transaction = Trans
            DaChequeDetalle.InsertCommand.Transaction = Trans
            DaChequeDetalle.UpdateCommand.Transaction = Trans
            DaChequeDetalle.DeleteCommand.Transaction = Trans

            ActualizaIDCentro()
            DaCheque.Update(DataSetCheque1.Cheques)
            DaChequeDetalle.Update(DataSetCheque1.Cheques_Detalle)
            Trans.Commit()
            spValidarEliminarDetalleCheque(0) ' Valida que no se pueda eliminar un registro de Cheque_Detalle
            'If Conta = 1 Or Conta = 2 Then
            Dim Fx As New cFunciones
            If Fx.ValidarPeriodo(Convert.ToDateTime(DtFecha.Value)) = False Then
                MsgBox("La fecha no corresponde al período fiscal o el período esta cerrado! No se puede guardar", MsgBoxStyle.Information)
                Exit Function
            End If
            GuardaAsiento()
            If TransAsiento() = False Then
                Trans.Rollback()
                MsgBox("Error en la Generación del Asiento", MsgBoxStyle.Critical, "Atencion...")
                ToolBar1.Buttons(2).Enabled = True
                Return False
                Exit Function
            End If
            ' End If
            DataSetCheque1.AcceptChanges()
            diferencia.Text = "0.00"
            Balanceo.Text = "Balanceado"
            Balanceo.ForeColor = Balanceo.ForeColor.Blue
            MsgBox("Cheque/Transferencia guardada satisfactoriamente", MsgBoxStyle.Information)
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message)
            ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function

    Function Guardar()
        Dim ofrecerImpresion As Boolean = True
        Dim Fx As New cFunciones
        Dim cConexion As New Conexion

        FechaConciliacion()
        If ValidarDetalleCheque(True) Then
            If DtFecha.Value <= FechaCon And ToolBar1.Buttons(0).Text = "Cancelar" Then
                MsgBox("Fecha del documento no puede ser menor que la última conciliación")
            Else
                BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
                '------------------------------------------------------------------
                'VERIFICA EL PERIODO DE TRABAJO
                Conta = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSOFT", "Bancos"), "Select Contabilidad from Configuraciones")
                cConexion.DesConectar(cConexion.sQlconexion)
                If Conta = 1 Or Conta = 2 Then
                    If Fx.ValidarPeriodo(BindingContext(DataSetCheque1, "Cheques").Current("Fecha")) = False Then
                        MsgBox("La Fecha del Cheque/Transferencia No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar el Cheque/Transferencia", MsgBoxStyle.Information, "Sistema SeeSoft")
                        Exit Function
                    End If
                End If
                BanderaGeneral.ACTUALIZO_ASIENTO = True
                BanderaGeneral.ACTUALIZO_ASIENTO2 = True
                '------------------------------------------------------------------
                If GuardarCabios() Then
                    Try
                        BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
                        SaveSetting("SeeSOFT", "Bancos", "UltCuenta", ComboBox1.Text)
                        InhabilitarChekes()
                        INHabilitarDetallesCheques()
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0
                        ToolBarBuscar.Enabled = True
                        ToolBarNuevo.Enabled = True
                        ToolBarEliminar.Enabled = False
                        ToolBarRegistrar.Enabled = False
                        ToolBarImprimir.Enabled = False
                        ToolBarEliminar.Enabled = False
                        ToolBarEditar2.Text = "Editar"
                        ToolBarEditar2.ImageIndex = 9
                        ToolBarEditar2.Enabled = False
                        SimpleNuevo.Text = "Nuevo"
                        SimpleGuardar.Enabled = False
                        EditaAsiento = False
                        EditaCentro = False
                        'If BindingContext(DataSetCheque1, "Cheques").Current("Tipo") = "CHEQUE" Then
                        If MsgBox("Desea Imprimir el Cheque", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Imprimir()
                        End If
                        'End If
                        If Me.desdeConciliacion Then
                            If Me.modificar Then
                                Me.nuevoMonto = CDbl(Me.CalcEdit1.Text)
                            End If
                            DialogResult = DialogResult.OK
                            Me.Close()
                            Exit Function
                        End If
                        DataSetCheque1.Cheques_Detalle.Clear()
                        DataSetCheque1.Cheques.Clear()
                        DataSetCheque1.Cuentas_bancarias.Clear()
                        DataSetCheque1.DetallesAsientosContable.Clear()
                        DataSetCheque1.AsientosContables.Clear()
                        DataSetCheque1.Configuraciones.Clear()
                        DaCuentaBancaria.Fill(DataSetCheque1.Cuentas_bancarias)
                        AdapterConfiguraciones.Fill(DataSetCheque1.Configuraciones)
                        LabelSaldo.DataBindings.Clear()
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Function
#End Region

#Region "BuscarSaldoBanco"
    Function BuscarSaldoCuenta(ByVal Id_Cuenta_Bancaria As Integer)
        Dim cConexion As New Conexion
        Dim Saldo As Double
        Saldo = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSOFT", "Bancos"), "Select dbo.SaldoCuentaBancaria(" & Id_Cuenta_Bancaria & ")")
        cConexion.DesConectar(cConexion.sQlconexion)
        LabelSaldo.EditValue = Saldo
    End Function
#End Region

#Region "Terminar Edicion Cheques"
    Private Sub TxtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarCheque() Then
                Try
                    BindingContext(DataSetCheque1, "Cheques").EndCurrentEdit()
                    'BindingContext(DataSetCheque1, "Cheques").AddNew()
                    'BindingContext(DataSetCheque1, "Cheques").CancelCurrentEdit()
                    If GroupBox4.Enabled = False Then
                        IngresaHaber()
                    Else
                        IngresaHaber(True)
                    End If
                    HabilitarDetallesCheques()
                    TxtDescripcion.Text = TxtObservaciones.Text
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
        Dim Totalcheque, Debe, Haber As Double

        Totalcheque = CalcEdit1.Value
        Haber = colHaber.SummaryItem.SummaryValue
        Debe = GridColumn2.SummaryItem.SummaryValue

        If revisa = False Then
            'If Totalcheque < Fix((Totaldetalle + CalcEdit2.EditValue) * 100) / 100 Then
            'MsgBox("El monto excede el total del cheque")
            'CalcEdit2.Focus()
            'Return False
            'End If
        Else
            If Debe = Haber Then
            Else
                MsgBox("El monto del debe y el haber no coinciden!", MsgBoxStyle.Information)
                Return False
            End If
        End If
        Try
            If CalcEdit2.Value <= 0 Then
                CalcEdit2.Focus()
                MsgBox("Digite un monto Válido", MsgBoxStyle.Information)
                Return False
            End If
        Catch ex As Exception
        End Try

        ' SE CALCULA EL SALDO DISPONIBLE DEL CHEQUE
        Dim diferencia1 As Double

        If RB_Haber.Checked Then
            diferencia1 = Debe - (Haber + CalcEdit2.Value)
        Else
            diferencia1 = (Debe + CalcEdit2.Value) - Haber
        End If
        diferencia.Text = Format(diferencia1, "#,#0.00")

        ' SE DETERMINA EL BALANCEO DEL CHEQUE
        If diferencia1 <> 0 Then
            Balanceo.Text = "No Balanceado"
        Else
            Balanceo.Text = "Balanceado"
            Balanceo.ForeColor = Balanceo.ForeColor.Blue
        End If
        Return True
    End Function

    Private Sub CalcularBalance()
        Try
            Dim Totalcheque, Debe, Haber As Double

            Totalcheque = CalcEdit1.Value
            Haber = colHaber.SummaryItem.SummaryValue
            Debe = GridColumn2.SummaryItem.SummaryValue

            ' SE CALCULA EL SALDO DISPONIBLE DEL CHEQUE
            Dim diferencia1 As Double
            diferencia1 = Debe - Haber
            diferencia.Text = Format(diferencia1, "#,#0.00")

            ' SE DETERMINA EL BALANCEO DEL CHEQUE
            If diferencia1 <> 0 Then
                Balanceo.Text = "No Balanceado"
            Else
                Balanceo.Text = "Balanceado"
                Balanceo.ForeColor = Balanceo.ForeColor.Blue
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Agregar detalles Cheques"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleNuevo.Click
        If SimpleNuevo.Text = "Nuevo" Then
            Try

                SimpleNuevo.Text = "Cancelar"
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").EndCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").AddNew()
                SimpleGuardar.Enabled = True
                SimpleEliminar.Enabled = False
                GridControl1.Enabled = False
                TxtDescripcion.Focus()
                TxtDescripcion.Text = TxtObservaciones.Text
                DataSetCheque1.CentroCostoDetalle.Clear()
                TotalCentro = 0

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            DataSetCheque1.CentroCostoDetalle.Clear()
            EliminaCentro(BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Id_ChequeDet"))
            TotalCentro = 0
            BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").CancelCurrentEdit()
            SimpleNuevo.Text = "Nuevo"
            SimpleGuardar.Enabled = False
            SimpleEliminar.Enabled = True
            GridControl1.Enabled = True
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
                TxtCuenta.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Label19.Text = nombre
                If ValidarDetalleCheque() Then
                    DataSetCheque1.CentroCostoDetalle.Clear()
                    TotalCentro = 0

                    If RB_Haber.Checked Then
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MDebe") = 0
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MHaber") = CalcEdit2.Value
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MHaber") = CalcEdit2.Value
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Principal") = Me.comparaCuentas

                    Else
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MDebe") = CalcEdit2.Value
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MHaber") = 0
                        BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Principal") = Me.comparaCuentas

                    End If

                    BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").EndCurrentEdit()
                    SimpleNuevo.Text = "Nuevo"
                    SimpleGuardar.Enabled = False
                    SimpleEliminar.Enabled = True
                    SimpleNuevo.Focus()
                    GridControl1.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

    Function comparaCuentas() As Boolean
        Dim dt_Cuentas As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT     CuentaContable   FROM Cuentas_bancarias WHERE  Id_CuentaBancaria = " & Me.ComboBox1.SelectedValue, dt_Cuentas, Configuracion.Claves.Conexion("Bancos"))

        If dt_Cuentas.Rows.Count > 0 Then
            If BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Cuenta_Contable") = dt_Cuentas.Rows(0).Item("CuentaContable") Then
                Return True
            Else
                Return False

            End If
        End If
    End Function
#Region "Eliminar Detalles Cheques"
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleEliminar.Click
        If BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Count > 0 Then
            Try
                EliminaCentro(BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Id_ChequeDet"))
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").RemoveAt(BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Position)
                CalcularBalance()

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
        Try
            Dim Total As Double = CDbl(CalcEdit1.EditValue)
            MostrarMontoLetras()
        Catch ex As Exception
            CalcEdit1.EditValue = 0
            MostrarMontoLetras()
        End Try
    End Sub


    Function MostrarMontoLetras()
        Dim cambio As New cNum2Text
        TxtMontoLetras.Text = cambio.Numero2Letra(CalcEdit1.EditValue, 0, 2, Label16.Text, "CENTIMO", cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino)
    End Function
#End Region

#Region "Imprimir"
    Function Imprimir()

        DataSetCheque1.Configuraciones.Clear()
        AdapterConfiguraciones.Fill(DataSetCheque1.Configuraciones)
        If Not DataSetCheque1.Configuraciones(0).FormatoCheck Then 'PARA LOS QUE NO USAN PAPEL PRE IMPRESO
            Try
                Dim Apertura_Cajas As New ReporteCheque
                Dim visor As New frmVisorReportes
                Dim servidor As String = SqlConnection1.DataSource
                Apertura_Cajas.SetParameterValue(0, BindingContext(DataSetCheque1, "Cheques").Current("Id_Cheque"))
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Apertura_Cajas, False, SqlConnection1.ConnectionString)
                visor.rptViewer.Visible = True
                Apertura_Cajas = Nothing
                visor.MdiParent = ParentForm
                visor.Show()
            Catch ex As Exception
                MsgBox(ex.ToString)

            End Try
        Else
            Try
                If DataSetCheque1.Configuraciones(0).Cedula.Equals("3-101-374928-30") Then 'SI ES ARENAL SPRING
                    Dim Apertura_Cajas As Object
                    If Me.BindingContext(Me.DataSetCheque1, "Cuentas_bancarias").Current("Cod_Moneda") = 2 Then
                        Apertura_Cajas = New ReporteChequesEstructura_Dolar
                    Else
                        Apertura_Cajas = New ReporteChequesEstructura
                    End If
                    Dim servidor As String = SqlConnection1.DataSource
                    Dim visor As New frmVisorReportes

                    Apertura_Cajas.SetParameterValue(0, BindingContext(DataSetCheque1, "Cheques").Current("Id_Cheque"))
                    CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Apertura_Cajas, False, SqlConnection1.ConnectionString)

                    Apertura_Cajas.PrintToPrinter(1, False, 0, 0)
                    Exit Function
                End If
                If DataSetCheque1.Configuraciones(0).Cedula.Equals("3-101-188056") Then 'SI ES TURTLE BEACH LODGE
                    If Me.CbTipo.Text.Equals("CHEQUE") Then
                        Dim Apertura_Cajas As New ReporteChequesEstructura_TBL
                        Dim servidor As String = SqlConnection1.DataSource
                        Dim visor As New frmVisorReportes

                        Apertura_Cajas.SetParameterValue(0, BindingContext(DataSetCheque1, "Cheques").Current("Id_Cheque"))

                        CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Apertura_Cajas, False, SqlConnection1.ConnectionString)
                        CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Apertura_Cajas, False, SqlConnection1.ConnectionString)

                        visor.rptViewer.Visible = True
                        Apertura_Cajas = Nothing
                        visor.MdiParent = ParentForm

                        visor.Show()

                    Else

                        Dim Apertura_Cajas As New ReporteCheque
                        Dim visor As New frmVisorReportes
                        Dim servidor As String = SqlConnection1.DataSource
                        Apertura_Cajas.SetParameterValue(0, BindingContext(DataSetCheque1, "Cheques").Current("Id_Cheque"))
                        CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Apertura_Cajas, False, SqlConnection1.ConnectionString)
                        visor.rptViewer.Visible = True
                        Apertura_Cajas = Nothing
                        visor.MdiParent = ParentForm
                        visor.Show()
                    End If
                    Exit Function

                End If
                Try 'PARA LOS DEMAS

                    If MsgBox("SI: PREIMPRESION || NO: COMPROBANTE", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Dim pre As String = Me.SubCargarPrinter
                        Dim print As String = Configuracion.Claves.Configuracion("ImpresoraCheque")
                        Me.Establecer_Impresora(print)
                        Dim rtp As New ReporteChequesEstructura_ECOLE
                        Dim v As New frmVisorReportes
                        rtp.SetParameterValue(0, BindingContext(DataSetCheque1, "Cheques").Current("Id_Cheque"))
                        CrystalReportsConexion2.LoadReportViewer2(v.rptViewer, rtp, False, Configuracion.Claves.Conexion("Bancos"))
                        rtp.PrintOptions.PrinterName = print
                        rtp.PrintToPrinter(1, False, 0, 0)
                        Me.Establecer_Impresora(pre)
                        Exit Function
                    End If

                    Dim Apertura_Cajas As New ReporteCheque
                    Dim visor As New frmVisorReportes
                    Dim servidor As String = SqlConnection1.DataSource
                    Apertura_Cajas.SetParameterValue(0, BindingContext(DataSetCheque1, "Cheques").Current("Id_Cheque"))
                    CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Apertura_Cajas, False, SqlConnection1.ConnectionString)
                    visor.rptViewer.Visible = True
                    Apertura_Cajas = Nothing
                    visor.MdiParent = ParentForm
                    visor.Show()
                Catch ex As Exception
                    MsgBox(ex.ToString)

                End Try

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.OkOnly, "Atención...")
            End Try
        End If
    End Function
#Region "Cambio impresoras"


    Public Function SubCargarPrinter() As String

        Dim aImpresoras(Printing.PrinterSettings.InstalledPrinters.Count - 1) As String

        Dim instance As New Printing.PrinterSettings

        For i As Integer = 0 To Printing.PrinterSettings.InstalledPrinters.Count - 1

            aImpresoras(i) = Printing.PrinterSettings.InstalledPrinters.Item(i)

            '-->> instance.PrinterName=instance.InstalledPrinters.Item(i)

            If instance.IsDefaultPrinter() Then

                ' MsgBox(aImpresoras(i))
                Return instance.PrinterName
            End If

        Next
        Return ""


    End Function

    Private Function Establecer_Impresora(ByVal NamePrinter As String) As Boolean
        On Error GoTo errSub

        'Variable de referencia  
        Dim obj_Impresora As Object

        'Creamos la referencia  
        obj_Impresora = CreateObject("WScript.Network")
        obj_Impresora.setdefaultprinter(NamePrinter)

        obj_Impresora = Nothing

        'La función devuelve true y se cambió con éxito  
        Establecer_Impresora = True
        '   MsgBox("La impresora se cambió correctamente", vbInformation)
        Exit Function


        'Error al cambiar la impresora  
errSub:
        If Err.Number = 0 Then Exit Function
        Establecer_Impresora = False
        MsgBox("error: " & Err.Number & Chr(13) & "Description: " & Err.Description)
        On Error GoTo 0
    End Function

#End Region

    Private Function Automatic_Printer_Dialog(ByVal PrinterToSelect As Byte) As String 'SAJ 01092006 
        Dim PrintDocument1 As New PrintDocument
        Dim DefaultPrinter As String = PrintDocument1.PrinterSettings.PrinterName
        Dim PrinterInstalled As String
        'BUSCA LA IMPRESORA PREDETERMINADA PARA EL SISTEMA
        For Each PrinterInstalled In PrinterSettings.InstalledPrinters

            Select Case Split(PrinterInstalled.ToUpper, "\").GetValue(Split(PrinterInstalled.ToUpper, "\").GetLength(0) - 1)
                Case "FACTURACION"
                    If PrinterToSelect = 0 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "CONTADO"
                    If PrinterToSelect = 1 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "Samsung ML-1740 Series"
                    If PrinterToSelect = 2 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "PUNTOVENTA"
                    If PrinterToSelect = 3 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
                Case "FAX"
                    If PrinterToSelect = 4 Then
                        Return PrinterInstalled.ToString
                        Exit Function
                    End If
            End Select
        Next

        If MsgBox("No se ha encontrado las impresoras predeterminadas para el sistema..." & vbCrLf & "Desea proceder a selecionar una impresora....", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Atención...") = MsgBoxResult.Yes Then
            Dim PrinterDialog As New PrintDialog
            Dim DocPrint As New PrintDocument
            PrinterDialog.Document = DocPrint
            PrinterDialog.ShowDialog()
            If PrinterDialog.ShowDialog.Yes Then
                Return PrinterDialog.PrinterSettings.PrinterName 'DEVUELVE LA IMPRESORA  SELECCIONADA
            Else
                Return DefaultPrinter 'NO SE SELECCIONO IMPRESORA ALGUNA
            End If
        End If
    End Function
#End Region

#Region "Buscar Cuenta Contable"

    Private Sub TxtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCuenta.KeyDown
        If e.KeyCode = Keys.F1 Then

            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
    " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            TxtCuenta.Text = busca.codigo
            Label19.Text = busca.descrip
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = TxtCuenta.Text
            valida = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                TxtCuenta.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Label19.Text = nombre
                SimpleGuardar.Focus()
            End If
        End If
    End Sub


    Private Function BuscarCuentaCont(ByVal cuentaconta As String)
        Dim conectar As SqlConnection = Nothing
        DataSetCheque1.cuentascontable.Clear()
        Try
            Dim strin As String = Configuracion.Claves.Conexion("Bancos")
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
            dacuenta.Fill(DataSetCheque1.cuentascontable)

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not conectar Is Nothing Then
                conectar.Close()
            End If
        End Try
        If DataSetCheque1.cuentascontable.Rows.Count > 0 Then
            TxtCuenta.Text = cuentaconta
            Label19.Text = DataSetCheque1.cuentascontable.Rows(0).Item("Descripcion")
        End If
    End Function
#End Region

#Region "Funciones"
    Function NumeroCheques()
        Dim Cx As New Conexion
        Dim NumeroCheque As String
        Dim Id_Cuenta As Integer = ComboBox1.SelectedValue
        NumeroCheque = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT ISNULL(MAX(Num_Cheque), 0) + 1 AS Num_Nueva_Factura FROM Cheques WHERE(Id_CuentaBancaria = " & Id_Cuenta & " ) AND (Tipo ='CHEQUE') ")
        Cx.DesConectar(Cx.sQlconexion)
        If NumeroCheque = 1 Then
            NumeroCheque = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT ChequeInicial FROM Cuentas_bancarias WHERE(Id_CuentaBancaria = " & Id_Cuenta & ")")
        End If
        TxtNumCheque.EditValue = NumeroCheque
    End Function


    Public Function id(ByVal id1 As String, ByVal c As String) As String
        Dim cnn As SqlConnection = Nothing
        Dim sel As String
        Dim Cx1 As New Conexion
        Dim sent1 As String

        sent1 = " select id_cheque from cheques C, cuentas_bancarias CB  " & _
                " where cb.id_cuentabancaria = c.id_cuentabancaria and " & _
                " c.Num_Cheque = " & id1 & " and cb.cuenta = '" & c & "' "

        id = Cx1.SlqExecuteScalar(Cx1.Conectar("Bancos"), sent1)
        Cx1.DesConectar(Cx1.sQlconexion)
    End Function

    Private Sub IngresaHaber(Optional ByVal Modifica As Boolean = False)
        Try
            If Modifica = False Then
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").CancelCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").EndCurrentEdit()
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").AddNew()
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Descripcion_Mov") = TxtObservaciones.Text
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Cuenta_Contable") = BindingContext(DataSetCheque1, "Cuentas_bancarias").Current("CuentaContable")
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Nombre_Cuenta") = BindingContext(DataSetCheque1, "Cuentas_bancarias").Current("NombreCuentaContable")
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Monto") = Format(CalcEdit1.Value, "#,#0.00")
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Debe") = False
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Haber") = True
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MHaber") = Format(CalcEdit1.Value, "#,#0.00")
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("MDebe") = 0
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Principal") = True
                BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").EndCurrentEdit()
            Else
                For i As Integer = 0 To DataSetCheque1.Cheques_Detalle.Count - 1
                    If DataSetCheque1.Cheques_Detalle(i).Principal Then
                        DataSetCheque1.Cheques_Detalle(i).Monto = Format(CalcEdit1.Value, "#,#0.00")
                        DataSetCheque1.Cheques_Detalle(i).MHaber = Format(CalcEdit1.Value, "#,#0.00")
                    End If
                Next
            End If
            CalcularBalance()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ToolBar1"
    Private Sub ToolBar1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usuario.Cedula, Name) 'Carga los privilegios del usuario con el módulo
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

                'Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then Anula() Else MsgBox("No tiene permiso para anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Close()
        End Select
    End Sub
#End Region

#Region "Validar Fecha Conciliacion"
    Function FechaConciliacion()
        Dim cConexion As New Conexion
        FechaCon = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSOFT", "Bancos"), "SELECT ISNULL(MAX(Hasta),0) AS FechaMax FROM dbo.Conciliacion where Id_CuentaBancaria =" & ComboBox1.SelectedValue)
        cConexion.DesConectar(cConexion.sQlconexion)
    End Function
#End Region

#Region "Asientos Contables"
    Public Sub GuardaAsiento()
        Dim NumeroAsiento As String
        Dim Fx As New cFunciones
        Dim Funciones As New Conexion

        Try
            '------------------------------------------------------------------
            'CREA EL ASIENTO CONTABLE cambiar a false DIEGO
            If EditaAsiento = False Then    'SI NO SE ESTA EDITANDO EL ASIENTO LO CREA NUEVO
                DataSetCheque1.AsientosContables.Clear()
                DataSetCheque1.DetallesAsientosContable.Clear()
                NumeroAsiento = Fx.BuscaNumeroAsiento("BCO-" & Format(DtFecha.Value.Month, "00") & Format(DtFecha.Value.Date, "yy") & "-")
                BindingContext(DataSetCheque1, "AsientosContables").EndCurrentEdit()
                BindingContext(DataSetCheque1, "AsientosContables").AddNew()
                BindingContext(DataSetCheque1, "AsientosContables").Current("NumAsiento") = NumeroAsiento
            Else                            'SI SE ESTA EDITANDO EL ASIENTO BORRA LOS DETALLES PARA VOLVERLOS A CREAR
                If BindingContext(DataSetCheque1, "AsientosContables").Count < 1 Then
                    DataSetCheque1.AsientosContables.Clear()
                    DataSetCheque1.DetallesAsientosContable.Clear()
                    NumeroAsiento = Fx.BuscaNumeroAsiento("BCO-" & Format(DtFecha.Value.Month, "00") & Format(DtFecha.Value.Date, "yy") & "-")
                    BindingContext(DataSetCheque1, "AsientosContables").EndCurrentEdit()
                    BindingContext(DataSetCheque1, "AsientosContables").AddNew()
                    BindingContext(DataSetCheque1, "AsientosContables").Current("NumAsiento") = NumeroAsiento
                Else
                    Funciones.DeleteRecords("DetallesAsientosContable", "NumAsiento ='" & BindingContext(DataSetCheque1, "AsientosContables").Current("NumAsiento") & "'")
                End If
            End If

            BindingContext(DataSetCheque1, "AsientosContables").Current("Fecha") = DtFecha.Value
            BindingContext(DataSetCheque1, "AsientosContables").Current("IdNumDoc") = DataSetCheque1.Cheques(0).Id_Cheque
            BindingContext(DataSetCheque1, "AsientosContables").Current("NumDoc") = DataSetCheque1.Cheques(0).Num_Cheque
            BindingContext(DataSetCheque1, "AsientosContables").Current("Beneficiario") = TxtPagese.Text
            BindingContext(DataSetCheque1, "AsientosContables").Current("TipoDoc") = 1
            BindingContext(DataSetCheque1, "AsientosContables").Current("Accion") = "AUT"
            BindingContext(DataSetCheque1, "AsientosContables").Current("Anulado") = 0
            BindingContext(DataSetCheque1, "AsientosContables").Current("FechaEntrada") = Now.Date
            'BindingContext(DataSetCheque1, "AsientosContables").Current("Mayorizado") = 0
            BindingContext(DataSetCheque1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(DtFecha.Value)
            'BindingContext(DataSetCheque1, "AsientosContables").Current("NumMayorizado") = 0
            BindingContext(DataSetCheque1, "AsientosContables").Current("Modulo") = "Cheques/Transferencias"
            If CbTipo.Text = "CHEQUE" Then
                BindingContext(DataSetCheque1, "AsientosContables").Current("Observaciones") = "Cheque # " & DataSetCheque1.Cheques(0).Num_Cheque
            Else
                BindingContext(DataSetCheque1, "AsientosContables").Current("Observaciones") = "Transferencia # " & DataSetCheque1.Cheques(0).Num_Cheque
            End If
            BindingContext(DataSetCheque1, "AsientosContables").Current("NombreUsuario") = TxtNombreUsuario.Text
            BindingContext(DataSetCheque1, "AsientosContables").Current("TotalDebe") = DataSetCheque1.Cheques(0).Monto
            BindingContext(DataSetCheque1, "AsientosContables").Current("TotalHaber") = DataSetCheque1.Cheques(0).Monto
            BindingContext(DataSetCheque1, "AsientosContables").Current("CodMoneda") = DataSetCheque1.Cheques(0).CodigoMoneda
            BindingContext(DataSetCheque1, "AsientosContables").Current("TipoCambio") = CDbl(txtTipoCambio.Text)
            BindingContext(DataSetCheque1, "AsientosContables").EndCurrentEdit()
            '------------------------------------------------------------------

            'CREA TODOS LOS DETALLES DEL ASIENTO
            AsientoDetalle()

            '------------------------------------------------------------------
            'ACTUALIZA CENTROS DE COSTOS
            If DataSetCheque1.CentroCosto_Movimientos.Count > 0 Then
                For i As Integer = 0 To DataSetCheque1.CentroCosto_Movimientos.Count - 1    'LE ASIGNA EL NUMERO DE ASIENTO Y DE DOCUMENTO A LOS CENTROS DE COSTO
                    DataSetCheque1.CentroCosto_Movimientos.Item(i).IdAsiento = BindingContext(DataSetCheque1, "AsientosContables").Current("NumAsiento")
                    DataSetCheque1.CentroCosto_Movimientos.Item(i).Documento = DataSetCheque1.Cheques(0).Num_Cheque
                Next i
            End If
            '------------------------------------------------------------------

            'ACTUALIZA EL NUMERO DE ASIENTO AL CHEQUE
            Funciones.UpdateRecords("Bancos.dbo.Cheques", "Contabilizado = 1, Asiento = '" & BindingContext(DataSetCheque1, "AsientosContables").Current("NumAsiento") & "'", "Id_Cheque = " & DataSetCheque1.Cheques(0).Id_Cheque, "Bancos")

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String, ByVal Observacion As String)
        If Monto <> 0 Then       'CREA LOS DETALLES DE ASIENTOS CONTABLES
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DataSetCheque1, "AsientosContables").Current("NumAsiento")
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = Observacion
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = CDbl(txtTipoCambio.Text)
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        End If
    End Sub


    Private Sub AsientoDetalle()
        Try
            If DataSetCheque1.Cheques_Detalle.Count > 0 Then
                '------------------------------------------------------------------
                'GUARDA ASIENTOS PARA LOS DETALLES DEL CHEQUE (DEBE)
                For i As Integer = 0 To DataSetCheque1.Cheques_Detalle.Count - 1
                    If DataSetCheque1.Cheques_Detalle(i).Debe = True Then
                        GuardaAsientoDetalle(DataSetCheque1.Cheques_Detalle(i).Monto, True, False, DataSetCheque1.Cheques_Detalle(i).Cuenta_Contable, DataSetCheque1.Cheques_Detalle(i).Nombre_Cuenta, DataSetCheque1.Cheques_Detalle(i).Descripcion_Mov)
                    Else
                        GuardaAsientoDetalle(DataSetCheque1.Cheques_Detalle(i).Monto, False, True, DataSetCheque1.Cheques_Detalle(i).Cuenta_Contable, DataSetCheque1.Cheques_Detalle(i).Nombre_Cuenta, DataSetCheque1.Cheques_Detalle(i).Descripcion_Mov)
                    End If
                Next i
                '------------------------------------------------------------------

                '------------------------------------------------------------------
                'GUARDA EL DETALLE PARA LA CUENTA BANCARIA (HABER)
                'GuardaAsientoDetalle(DataSetCheque1.Cheques(0).Monto, False, True, BindingContext(DataSetCheque1, "Cuentas_bancarias").Current("CuentaContable"), BindingContext(DataSetCheque1, "Cuentas_bancarias").Current("NombreCuentaContable"), DataSetCheque1.Cheques(0).Observaciones)
                '------------------------------------------------------------------
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Function TransAsiento() As Boolean  'REALIZA LA TRANSACCIÓN DE LOS ASIENTOS CONTABLES
        Dim Trans As SqlTransaction

        Try
            If SqlConnection3.State <> SqlConnection3.State.Open Then SqlConnection3.Open()

            Trans = SqlConnection3.BeginTransaction
            BindingContext(DataSetCheque1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DataSetCheque1, "AsientosContables").EndCurrentEdit()

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
            AdapterDetallesAsientos.Update(DataSetCheque1.DetallesAsientosContable)
            AdapterAsientos.Update(DataSetCheque1.AsientosContables)
            AdapterCentroCostoMovimiento.Update(DataSetCheque1.CentroCosto_Movimientos)
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
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "Select * From AsientosContables WHERE NumAsiento='" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            DataSetCheque1.DetallesAsientosContable.Clear()
            DataSetCheque1.AsientosContables.Clear()
            da.Fill(DataSetCheque1.AsientosContables)
            If DataSetCheque1.AsientosContables.Count < 1 Then
                DataSetCheque1.AsientosContables.Clear()
                Exit Try
            End If
            CargarCentroCosto(DataSetCheque1.AsientosContables(0).NumAsiento)

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
        If BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Count > 0 Then
            If CalcEdit1.Value < 1 Then
                MsgBox("Por favor revise Monto", MsgBoxStyle.Critical, "Datos Incorrectos")
                Exit Sub
            End If

            If TxtCuenta.Text = "" Or Label19.Text = "" Then
                MsgBox("Por favor revise la Cuenta Contable", MsgBoxStyle.Critical, "Datos Incorrectos")
                Exit Sub
            End If

            CargaCentro(BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Id_ChequeDet"))
            TxtDetalle.Text = CalcEdit2.Value
            Panel_Centrar()
            BNuevo.Focus()
        Else
            MsgBox("Debe de Agregar un detalle del Cheque", MsgBoxStyle.Critical, "Datos Incorrectos")
        End If
    End Sub


    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        If BNuevo.Text = "Nuevo" Then
            AgregaCentro()
            Controles(True)
            BNuevo.Text = "Cancelar"
            ButtonAgregarDetalle.Enabled = True
            EditDescripcionCC.Text = TxtDescripcion.Text
            CBCentroCosto.Focus()
        Else
            BindingContext(DataSetCheque1, "CentroCosto_Movimientos").CancelCurrentEdit()
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
        LlenaGridCentro(CBCentroCosto.Text, CDbl(txtMontoCentroCosto.Text), EditDescripcionCC.Text, BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("Id"))
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").EndCurrentEdit()
        TxtDetalle.Text = CalcEdit2.Value
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
        BNuevo.Focus()
    End Sub


    Private Sub BotonCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCerrar.Click
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").CancelCurrentEdit()
        Panel_Ocultar()
        SimpleGuardar.Focus()
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub
#End Region

#Region "Funciones"
    Public Sub AgregaCentro()
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").EndCurrentEdit()
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").AddNew()
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("IdAsiento") = "0"
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("Documento") = ""
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("Fecha") = DtFecha.Value
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("Debe") = True
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("Haber") = False
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("CuentaContable") = TxtCuenta.Text
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("NombreCuentaContable") = Label19.Text
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("Tipo") = 1
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").Current("IdDetalle") = BindingContext(DataSetCheque1, "Cheques.ChequesCheques_Detalle").Current("Id_ChequeDet")
        CBCentroCosto.SelectedIndex = 0
    End Sub


    Public Sub CargaCentro(ByVal id As Integer)
        Dim Centro() As System.Data.DataRow
        TotalCentro = 0
        DataSetCheque1.CentroCostoDetalle.Clear()
        If DataSetCheque1.CentroCosto_Movimientos.Count > 0 Then
            For i As Integer = 0 To DataSetCheque1.CentroCosto_Movimientos.Count - 1
                If DataSetCheque1.CentroCosto_Movimientos(i).IdDetalle = id Then
                    Centro = DataSetCheque1.CentroCosto.Select("Id = " & DataSetCheque1.CentroCosto_Movimientos(i).IdCentroCosto, "Nombre")
                    LlenaGridCentro(Centro(0)(2), DataSetCheque1.CentroCosto_Movimientos(i).Monto, DataSetCheque1.CentroCosto_Movimientos(i).Descripcion, DataSetCheque1.CentroCosto_Movimientos(i).Id)
                    TotalCentro += DataSetCheque1.CentroCosto_Movimientos(i).Monto
                End If
            Next i
        End If
    End Sub


    Public Sub LlenaGridCentro(ByVal Centro As String, ByVal monto As Double, ByVal descripcion As String, ByVal id As Integer)
        Dim NuevaFila As DataSetCheque.CentroCostoDetalleRow
        NuevaFila = DataSetCheque1.CentroCostoDetalle.NewCentroCostoDetalleRow
        NuevaFila.CentroCosto = Centro
        NuevaFila.Monto = monto
        NuevaFila.Descripcion = descripcion
        NuevaFila.Id = id
        DataSetCheque1.CentroCostoDetalle.AddCentroCostoDetalleRow(NuevaFila)
    End Sub


    Public Sub EliminaCentro(ByVal id As Integer)
        If DataSetCheque1.CentroCosto_Movimientos.Count > 0 Then
            For i As Integer = 0 To DataSetCheque1.CentroCosto_Movimientos.Count - 1
                If DataSetCheque1.CentroCosto_Movimientos.Item(i).IdDetalle = id Then
                    BindingContext(DataSetCheque1.CentroCosto_Movimientos).RemoveAt(Me.BindingContext(DataSetCheque1.CentroCosto_Movimientos).Position)
                End If
            Next i
            If EditaCentro = True Then
                Dim Funcion As New Conexion
                Funcion.DeleteRecords("CentroCosto_Movimientos", "IdDetalle =" & id)
            End If
        End If
    End Sub


    Private Sub EliminarDetalleCentro()
        If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        If DataSetCheque1.CentroCostoDetalle.Count = 0 Then Exit Sub
        Dim posicion, pos, IdCentro As Integer
        posicion = BindingContext(DataSetCheque1.CentroCostoDetalle).Position()

        For i As Integer = 0 To DataSetCheque1.CentroCosto_Movimientos.Count - 1
            If DataSetCheque1.CentroCosto_Movimientos(i).Id = BindingContext(DataSetCheque1.CentroCostoDetalle).Current("Id") Then
                pos = i
            End If
        Next i
        TotalCentro = (TotalCentro - DataSetCheque1.CentroCosto_Movimientos(pos).Monto)
        IdCentro = DataSetCheque1.CentroCosto_Movimientos(pos).Id
        DataSetCheque1.CentroCosto_Movimientos.Rows.RemoveAt(pos)
        If EditaCentro = True Then
            Dim Funcion As New Conexion
            Funcion.DeleteRecords("CentroCosto_Movimientos", "Id = " & IdCentro)
        End If
        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").EndCurrentEdit()
        DataSetCheque1.CentroCostoDetalle.Rows.RemoveAt(posicion)

        BindingContext(DataSetCheque1, "CentroCosto_Movimientos").CancelCurrentEdit()
        TxtDetalle.Text = CalcEdit2.Value
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub


    Function CargarCentroCosto(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
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
            DataSetCheque1.CentroCosto_Movimientos.Clear()
            DataSetCheque1.CentroCostoDetalle.Clear()
            da.Fill(DataSetCheque1.CentroCosto_Movimientos)
            If DataSetCheque1.CentroCosto_Movimientos.Count < 1 Then
                DataSetCheque1.CentroCosto_Movimientos.Clear()
                Exit Try
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
        If DataSetCheque1.CentroCosto_Movimientos.Count > 0 Then
            Dim j As Integer = -1
            Dim Id_detalle As Integer
            Dim cConexion As New Conexion
            Id_detalle = cConexion.SlqExecuteScalar(cConexion.Conectar("SeeSOFT", "Bancos"), "SELECT ISNULL(MAX(Id_ChequeDet),0) FROM dbo.Cheques_Detalle")
            cConexion.DesConectar(cConexion.sQlconexion)

            For i As Integer = 0 To DataSetCheque1.Cheques_Detalle.Count - 1
                Id_detalle += 1
                For x As Integer = 0 To DataSetCheque1.CentroCosto_Movimientos.Count - 1
                    If DataSetCheque1.CentroCosto_Movimientos.Item(x).IdDetalle = j Then
                        DataSetCheque1.CentroCosto_Movimientos.Item(x).IdDetalle = Id_detalle
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

    Private Sub ButtonDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDep.Click
        Dim frmDep As New FormCargarDeposito
        frmDep.id_che = Me.BindingContext(Me.DataSetCheque1, "Cheques").Current("Id_Cheque")
        frmDep.MdiParent = Me.MdiParent
        frmDep.Show()
    End Sub

    Private Sub TxtPagese_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPagese.TextChanged

    End Sub

    Private Sub TxtObservaciones_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtObservaciones.TextChanged

    End Sub
End Class

