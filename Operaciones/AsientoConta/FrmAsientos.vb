Imports System.Data.SqlClient
Imports Utilidades

Public Class FrmAsientos
	Inherits System.Windows.Forms.Form

#Region "Variables"
	Dim TablaTipos, TablaAsientos, TablaDetalles, StrSql As String
	Dim logeado, Nuev As Boolean
	Dim movimiento As Boolean = False
	Dim Cedula_usuario, NombreUsuario, separador As String
	Dim Cuents, nodo, Mascara, niveles, pos, tipo As String
	Public TablaAsiento, TablaBuscar As New DataTable
	Dim n1, n2, n3, n4, n5, n6, n7, n8, a, NumeroDoc As Integer
	Dim dr As DataRow
	Dim usua As Usuario_Logeado
	Dim Funcion As New cFunciones
	Dim cero As Boolean = False
	Dim clave As String = ""
	Friend WithEvents txtNoDocumentoDetalle As TextBox
	Friend WithEvents Label25 As Label
	Public NumAsiento As String = ""
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

	Public Sub New(ByVal Usuario_Parametro As Object)
		MyBase.New()

		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
		usua = Usuario_Parametro
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
	Friend WithEvents LblPeriodo As System.Windows.Forms.Label
	Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
	Friend WithEvents Label20 As System.Windows.Forms.Label
	Friend WithEvents Label21 As System.Windows.Forms.Label
	Friend WithEvents TxtBenef As System.Windows.Forms.TextBox
	Friend WithEvents DPTrans As System.Windows.Forms.DateTimePicker
	Friend WithEvents Label22 As System.Windows.Forms.Label
	Friend WithEvents Label23 As System.Windows.Forms.Label
	Friend WithEvents Label26 As System.Windows.Forms.Label
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents RadHaber As System.Windows.Forms.RadioButton
	Friend WithEvents RadDebe As System.Windows.Forms.RadioButton
	Friend WithEvents Label13 As System.Windows.Forms.Label
	Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
	Friend WithEvents Label15 As System.Windows.Forms.Label
	Friend WithEvents Label16 As System.Windows.Forms.Label
	Friend WithEvents TxtDescAsiento As System.Windows.Forms.TextBox
	Friend WithEvents Label17 As System.Windows.Forms.Label
	Friend WithEvents Label18 As System.Windows.Forms.Label
	Friend WithEvents AdapAsientos As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents AdapTiposDoc As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents AdapDetalles As System.Data.SqlClient.SqlDataAdapter
	Public WithEvents ImageList As System.Windows.Forms.ImageList
	Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
	Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
	Protected Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
	Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
	Protected Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
	Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
	Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
	Friend WithEvents FrameEncabezado As System.Windows.Forms.GroupBox
	Friend WithEvents FrameDetalles As System.Windows.Forms.GroupBox
	Friend WithEvents LblConsecutivo As System.Windows.Forms.Label
	Friend WithEvents ButAgregarDetalle As DevExpress.XtraEditors.SimpleButton
	Friend WithEvents AdapCuentas As System.Data.SqlClient.SqlDataAdapter
	Friend WithEvents LblDescCuenta As System.Windows.Forms.Label
	Friend WithEvents Label1 As System.Windows.Forms.Label
	Friend WithEvents TxtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents DataSetAsientos1 As DataSetAsientos
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblMayor As System.Windows.Forms.Label
    Friend WithEvents TxtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents TxtDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtEstado As System.Windows.Forms.TextBox
    Friend WithEvents ComboTiposDoc As System.Windows.Forms.TextBox
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ButNuevoDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtNumCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents AdapFormato As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents butEliminarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnReporteDetalle As System.Windows.Forms.Button
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents CBMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents CheckAnulado As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTipoCambio As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTotalHaber2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalDebe2 As System.Windows.Forms.TextBox
    Friend WithEvents txtDif2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolBarDesmay As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCargar As System.Windows.Forms.ToolBarButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMontoCentro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents grControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents grdVCCosto As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCentro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcNombreCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents gcMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDescripción As System.Windows.Forms.TextBox
    Friend WithEvents btnVerCentroC As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents AdapCentroMovimiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAsientos))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
        Me.FrameEncabezado = New System.Windows.Forms.GroupBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DPTrans = New System.Windows.Forms.DateTimePicker()
        Me.DataSetAsientos1 = New Contabilidad.DataSetAsientos()
        Me.CBMoneda = New System.Windows.Forms.ComboBox()
		Me.txtTipoCambio = New System.Windows.Forms.TextBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.ComboTiposDoc = New System.Windows.Forms.TextBox()
		Me.LblMayor = New System.Windows.Forms.Label()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.TxtDocumento = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TxtBenef = New System.Windows.Forms.TextBox()
		Me.TxtObservaciones = New System.Windows.Forms.TextBox()
		Me.LblPeriodo = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.TituloModulo = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.FrameDetalles = New System.Windows.Forms.GroupBox()
		Me.txtNoDocumentoDetalle = New System.Windows.Forms.TextBox()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.btnVerCentroC = New System.Windows.Forms.Button()
		Me.TextBoxTipoCambio = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.butEliminarDetalle = New DevExpress.XtraEditors.SimpleButton()
		Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
		Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
		Me.TxtNumCuenta = New DevExpress.XtraEditors.TextEdit()
		Me.ButNuevoDetalle = New DevExpress.XtraEditors.SimpleButton()
		Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
		Me.LblDescCuenta = New System.Windows.Forms.Label()
		Me.ButAgregarDetalle = New DevExpress.XtraEditors.SimpleButton()
		Me.RadHaber = New System.Windows.Forms.RadioButton()
		Me.RadDebe = New System.Windows.Forms.RadioButton()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.TxtMonto = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.TxtDescAsiento = New System.Windows.Forms.TextBox()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.LblTipo = New System.Windows.Forms.Label()
		Me.AdapAsientos = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.AdapTiposDoc = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.AdapDetalles = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.ToolBar1 = New System.Windows.Forms.ToolBar()
		Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarDesmay = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarCargar = New System.Windows.Forms.ToolBarButton()
		Me.LblConsecutivo = New System.Windows.Forms.Label()
		Me.AdapCuentas = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.TxtTotalHaber = New System.Windows.Forms.TextBox()
		Me.TxtTotalDebe = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
		Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.TxtDiferencia = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.TxtEstado = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TxtUsuario = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.AdapFormato = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.btnReporteDetalle = New System.Windows.Forms.Button()
		Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.CheckAnulado = New System.Windows.Forms.CheckBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.TxtTotalHaber2 = New System.Windows.Forms.TextBox()
		Me.TxtTotalDebe2 = New System.Windows.Forms.TextBox()
		Me.txtDif2 = New System.Windows.Forms.TextBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnCerrar = New System.Windows.Forms.Button()
		Me.txtDescripción = New System.Windows.Forms.TextBox()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.grControl = New DevExpress.XtraGrid.GridControl()
		Me.grdVCCosto = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.gcCodigo = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcCentro = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcNombreCuenta = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.gcMonto = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnQuitar = New System.Windows.Forms.Button()
		Me.btnAgregar = New System.Windows.Forms.Button()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.txtMontoCentro = New System.Windows.Forms.TextBox()
		Me.AdapCentroMovimiento = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand()
		Me.FrameEncabezado.SuspendLayout()
		CType(Me.DataSetAsientos1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.FrameDetalles.SuspendLayout()
		CType(Me.TxtNumCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		CType(Me.grControl, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grdVCCosto, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'FrameEncabezado
		'
		Me.FrameEncabezado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FrameEncabezado.Controls.Add(Me.Label26)
		Me.FrameEncabezado.Controls.Add(Me.DPTrans)
		Me.FrameEncabezado.Controls.Add(Me.CBMoneda)
		Me.FrameEncabezado.Controls.Add(Me.txtTipoCambio)
		Me.FrameEncabezado.Controls.Add(Me.Label8)
		Me.FrameEncabezado.Controls.Add(Me.ComboTiposDoc)
		Me.FrameEncabezado.Controls.Add(Me.LblMayor)
		Me.FrameEncabezado.Controls.Add(Me.CheckBox2)
		Me.FrameEncabezado.Controls.Add(Me.Label19)
		Me.FrameEncabezado.Controls.Add(Me.TxtDocumento)
		Me.FrameEncabezado.Controls.Add(Me.Label1)
		Me.FrameEncabezado.Controls.Add(Me.TxtBenef)
		Me.FrameEncabezado.Controls.Add(Me.TxtObservaciones)
		Me.FrameEncabezado.Controls.Add(Me.LblPeriodo)
		Me.FrameEncabezado.Controls.Add(Me.Label20)
		Me.FrameEncabezado.Controls.Add(Me.Label21)
		Me.FrameEncabezado.Controls.Add(Me.Label22)
		Me.FrameEncabezado.Controls.Add(Me.Label23)
		Me.FrameEncabezado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameEncabezado.ForeColor = System.Drawing.Color.Gray
		Me.FrameEncabezado.Location = New System.Drawing.Point(8, 32)
		Me.FrameEncabezado.Name = "FrameEncabezado"
		Me.FrameEncabezado.Size = New System.Drawing.Size(1091, 94)
		Me.FrameEncabezado.TabIndex = 86
		Me.FrameEncabezado.TabStop = False
		Me.FrameEncabezado.Text = "Asiento Contable"
		'
		'Label26
		'
		Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label26.BackColor = System.Drawing.Color.White
		Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.ForeColor = System.Drawing.Color.Black
		Me.Label26.Location = New System.Drawing.Point(178, 13)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(99, 14)
		Me.Label26.TabIndex = 0
		Me.Label26.Text = "Fecha Transac"
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'DPTrans
		'
		Me.DPTrans.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.DPTrans.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.Fecha", True))
		Me.DPTrans.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DPTrans.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.DPTrans.Location = New System.Drawing.Point(178, 29)
		Me.DPTrans.Name = "DPTrans"
		Me.DPTrans.Size = New System.Drawing.Size(99, 18)
		Me.DPTrans.TabIndex = 1
		'
		'DataSetAsientos1
		'
		Me.DataSetAsientos1.DataSetName = "DataSetAsientos"
		Me.DataSetAsientos1.Locale = New System.Globalization.CultureInfo("es-ES")
		Me.DataSetAsientos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'CBMoneda
		'
		Me.CBMoneda.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.CBMoneda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetAsientos1, "AsientosContables.CodMoneda", True))
		Me.CBMoneda.DataSource = Me.DataSetAsientos1.Moneda
		Me.CBMoneda.DisplayMember = "MonedaNombre"
		Me.CBMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CBMoneda.Location = New System.Drawing.Point(960, 32)
		Me.CBMoneda.Name = "CBMoneda"
		Me.CBMoneda.Size = New System.Drawing.Size(116, 22)
		Me.CBMoneda.TabIndex = 4
		Me.CBMoneda.ValueMember = "CodMoneda"
		'
		'txtTipoCambio
		'
		Me.txtTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txtTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.TipoCambio", True))
		Me.txtTipoCambio.Enabled = False
		Me.txtTipoCambio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtTipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.txtTipoCambio.Location = New System.Drawing.Point(827, 72)
		Me.txtTipoCambio.Name = "txtTipoCambio"
		Me.txtTipoCambio.Size = New System.Drawing.Size(107, 13)
		Me.txtTipoCambio.TabIndex = 115
		Me.txtTipoCambio.Text = "0.00"
		Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label8
		'
		Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label8.BackColor = System.Drawing.Color.White
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.Color.Black
		Me.Label8.Location = New System.Drawing.Point(827, 56)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(107, 14)
		Me.Label8.TabIndex = 114
		Me.Label8.Text = "Tipo de Cambio"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ComboTiposDoc
		'
		Me.ComboTiposDoc.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.ComboTiposDoc.BackColor = System.Drawing.Color.White
		Me.ComboTiposDoc.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.ComboTiposDoc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboTiposDoc.Location = New System.Drawing.Point(410, 31)
		Me.ComboTiposDoc.Name = "ComboTiposDoc"
		Me.ComboTiposDoc.ReadOnly = True
		Me.ComboTiposDoc.Size = New System.Drawing.Size(221, 14)
		Me.ComboTiposDoc.TabIndex = 2
		'
		'LblMayor
		'
		Me.LblMayor.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.LblMayor.BackColor = System.Drawing.Color.White
		Me.LblMayor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.NumMayorizado", True))
		Me.LblMayor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblMayor.ForeColor = System.Drawing.Color.White
		Me.LblMayor.Location = New System.Drawing.Point(663, 72)
		Me.LblMayor.Name = "LblMayor"
		Me.LblMayor.Size = New System.Drawing.Size(123, 14)
		Me.LblMayor.TabIndex = 24
		Me.LblMayor.Text = "000000"
		Me.LblMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CheckBox2
		'
		Me.CheckBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.CheckBox2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAsientos1, "AsientosContables.Mayorizado", True))
		Me.CheckBox2.Enabled = False
		Me.CheckBox2.Location = New System.Drawing.Point(671, 56)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(13, 14)
		Me.CheckBox2.TabIndex = 23
		Me.CheckBox2.Text = "CheckBox1"
		'
		'Label19
		'
		Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label19.BackColor = System.Drawing.Color.White
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.ForeColor = System.Drawing.Color.Black
		Me.Label19.Location = New System.Drawing.Point(663, 56)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(122, 14)
		Me.Label19.TabIndex = 21
		Me.Label19.Text = "Mayorización #"
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'TxtDocumento
		'
		Me.TxtDocumento.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.NumDoc", True))
		Me.TxtDocumento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDocumento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TxtDocumento.Location = New System.Drawing.Point(8, 32)
		Me.TxtDocumento.Name = "TxtDocumento"
		Me.TxtDocumento.Size = New System.Drawing.Size(152, 13)
		Me.TxtDocumento.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(7, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(153, 14)
		Me.Label1.TabIndex = 87
		Me.Label1.Text = "Documento"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtBenef
		'
		Me.TxtBenef.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtBenef.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtBenef.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtBenef.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.Beneficiario", True))
		Me.TxtBenef.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtBenef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TxtBenef.Location = New System.Drawing.Point(661, 29)
		Me.TxtBenef.Name = "TxtBenef"
		Me.TxtBenef.Size = New System.Drawing.Size(274, 13)
		Me.TxtBenef.TabIndex = 3
		'
		'TxtObservaciones
		'
		Me.TxtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.Observaciones", True))
		Me.TxtObservaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TxtObservaciones.Location = New System.Drawing.Point(9, 72)
		Me.TxtObservaciones.Name = "TxtObservaciones"
		Me.TxtObservaciones.Size = New System.Drawing.Size(622, 13)
		Me.TxtObservaciones.TabIndex = 5
		'
		'LblPeriodo
		'
		Me.LblPeriodo.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.LblPeriodo.BackColor = System.Drawing.Color.White
		Me.LblPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.Periodo", True))
		Me.LblPeriodo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPeriodo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.LblPeriodo.Location = New System.Drawing.Point(300, 31)
		Me.LblPeriodo.Name = "LblPeriodo"
		Me.LblPeriodo.Size = New System.Drawing.Size(85, 14)
		Me.LblPeriodo.TabIndex = 13
		Me.LblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label20
		'
		Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label20.BackColor = System.Drawing.Color.White
		Me.Label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label20.ForeColor = System.Drawing.Color.Black
		Me.Label20.Location = New System.Drawing.Point(300, 15)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(85, 14)
		Me.Label20.TabIndex = 11
		Me.Label20.Text = "Período"
		Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label21
		'
		Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label21.BackColor = System.Drawing.Color.White
		Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label21.ForeColor = System.Drawing.Color.Black
		Me.Label21.Location = New System.Drawing.Point(9, 56)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(622, 14)
		Me.Label21.TabIndex = 10
		Me.Label21.Text = "Observaciones"
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label22
		'
		Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label22.BackColor = System.Drawing.Color.White
		Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label22.ForeColor = System.Drawing.Color.Black
		Me.Label22.Location = New System.Drawing.Point(659, 15)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(276, 14)
		Me.Label22.TabIndex = 4
		Me.Label22.Text = "Beneficiario"
		Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label23
		'
		Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label23.BackColor = System.Drawing.Color.White
		Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.ForeColor = System.Drawing.Color.Black
		Me.Label23.Location = New System.Drawing.Point(409, 15)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(222, 14)
		Me.Label23.TabIndex = 3
		Me.Label23.Text = "Tipo Documento"
		Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TituloModulo
		'
		Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
		Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
		Me.TituloModulo.ForeColor = System.Drawing.Color.White
		Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
		Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.TituloModulo.Location = New System.Drawing.Point(-664, 0)
		Me.TituloModulo.Name = "TituloModulo"
		Me.TituloModulo.Size = New System.Drawing.Size(2100, 32)
		Me.TituloModulo.TabIndex = 68
		Me.TituloModulo.Text = "Asientos Contables"
		Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'Label7
		'
		Me.Label7.BackColor = System.Drawing.Color.White
		Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.Color.Gray
		Me.Label7.Location = New System.Drawing.Point(0, 15)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(64, 16)
		Me.Label7.TabIndex = 79
		Me.Label7.Text = "Asiento :"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'FrameDetalles
		'
		Me.FrameDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.FrameDetalles.Controls.Add(Me.txtNoDocumentoDetalle)
		Me.FrameDetalles.Controls.Add(Me.Label25)
		Me.FrameDetalles.Controls.Add(Me.btnVerCentroC)
		Me.FrameDetalles.Controls.Add(Me.TextBoxTipoCambio)
		Me.FrameDetalles.Controls.Add(Me.Label10)
		Me.FrameDetalles.Controls.Add(Me.butEliminarDetalle)
		Me.FrameDetalles.Controls.Add(Me.SimpleButton1)
		Me.FrameDetalles.Controls.Add(Me.TxtNumCuenta)
		Me.FrameDetalles.Controls.Add(Me.ButNuevoDetalle)
		Me.FrameDetalles.Controls.Add(Me.LblDescCuenta)
		Me.FrameDetalles.Controls.Add(Me.ButAgregarDetalle)
		Me.FrameDetalles.Controls.Add(Me.RadHaber)
		Me.FrameDetalles.Controls.Add(Me.RadDebe)
		Me.FrameDetalles.Controls.Add(Me.Label13)
		Me.FrameDetalles.Controls.Add(Me.TxtMonto)
		Me.FrameDetalles.Controls.Add(Me.Label15)
		Me.FrameDetalles.Controls.Add(Me.Label16)
		Me.FrameDetalles.Controls.Add(Me.TxtDescAsiento)
		Me.FrameDetalles.Controls.Add(Me.Label17)
		Me.FrameDetalles.Controls.Add(Me.Label18)
		Me.FrameDetalles.Controls.Add(Me.LblTipo)
		Me.FrameDetalles.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.FrameDetalles.ForeColor = System.Drawing.Color.Gray
		Me.FrameDetalles.Location = New System.Drawing.Point(8, 128)
		Me.FrameDetalles.Name = "FrameDetalles"
		Me.FrameDetalles.Size = New System.Drawing.Size(1090, 120)
		Me.FrameDetalles.TabIndex = 80
		Me.FrameDetalles.TabStop = False
		Me.FrameDetalles.Text = "Detalles de Asiento"
		'
		'txtNoDocumentoDetalle
		'
		Me.txtNoDocumentoDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.txtNoDocumentoDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtNoDocumentoDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtNoDocumentoDetalle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtNoDocumentoDetalle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.txtNoDocumentoDetalle.Location = New System.Drawing.Point(505, 67)
		Me.txtNoDocumentoDetalle.Name = "txtNoDocumentoDetalle"
		Me.txtNoDocumentoDetalle.Size = New System.Drawing.Size(142, 13)
		Me.txtNoDocumentoDetalle.TabIndex = 28
		'
		'Label25
		'
		Me.Label25.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label25.BackColor = System.Drawing.Color.White
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.ForeColor = System.Drawing.Color.Black
		Me.Label25.Location = New System.Drawing.Point(505, 52)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(142, 14)
		Me.Label25.TabIndex = 27
		Me.Label25.Text = "# Documento"
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'btnVerCentroC
		'
		Me.btnVerCentroC.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.btnVerCentroC.Enabled = False
		Me.btnVerCentroC.ForeColor = System.Drawing.Color.Black
		Me.btnVerCentroC.Location = New System.Drawing.Point(261, 86)
		Me.btnVerCentroC.Name = "btnVerCentroC"
		Me.btnVerCentroC.Size = New System.Drawing.Size(100, 23)
		Me.btnVerCentroC.TabIndex = 26
		Me.btnVerCentroC.Text = "Centro Costo"
		'
		'TextBoxTipoCambio
		'
		Me.TextBoxTipoCambio.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TextBoxTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBoxTipoCambio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBoxTipoCambio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TextBoxTipoCambio.Location = New System.Drawing.Point(11, 96)
		Me.TextBoxTipoCambio.Name = "TextBoxTipoCambio"
		Me.TextBoxTipoCambio.Size = New System.Drawing.Size(138, 13)
		Me.TextBoxTipoCambio.TabIndex = 24
		Me.TextBoxTipoCambio.Text = "0.00"
		Me.TextBoxTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label10
		'
		Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label10.BackColor = System.Drawing.Color.White
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.Color.Black
		Me.Label10.Location = New System.Drawing.Point(11, 81)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(138, 14)
		Me.Label10.TabIndex = 25
		Me.Label10.Text = "Tipo Cambio"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'butEliminarDetalle
		'
		Me.butEliminarDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.butEliminarDetalle.Enabled = False
		Me.butEliminarDetalle.ImageIndex = 3
		Me.butEliminarDetalle.ImageList = Me.ImageList
		Me.butEliminarDetalle.Location = New System.Drawing.Point(848, 86)
		Me.butEliminarDetalle.Name = "butEliminarDetalle"
		Me.butEliminarDetalle.Size = New System.Drawing.Size(129, 24)
		Me.butEliminarDetalle.TabIndex = 8
		Me.butEliminarDetalle.Text = "Eliminar"
		'
		'ImageList
		'
		Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList.Images.SetKeyName(0, "")
		Me.ImageList.Images.SetKeyName(1, "")
		Me.ImageList.Images.SetKeyName(2, "")
		Me.ImageList.Images.SetKeyName(3, "")
		Me.ImageList.Images.SetKeyName(4, "")
		Me.ImageList.Images.SetKeyName(5, "")
		Me.ImageList.Images.SetKeyName(6, "")
		Me.ImageList.Images.SetKeyName(7, "")
		Me.ImageList.Images.SetKeyName(8, "")
		Me.ImageList.Images.SetKeyName(9, "")
		'
		'SimpleButton1
		'
		Me.SimpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.SimpleButton1.Enabled = False
		Me.SimpleButton1.ImageIndex = 9
		Me.SimpleButton1.ImageList = Me.ImageList
		Me.SimpleButton1.Location = New System.Drawing.Point(711, 86)
		Me.SimpleButton1.Name = "SimpleButton1"
		Me.SimpleButton1.Size = New System.Drawing.Size(129, 24)
		Me.SimpleButton1.TabIndex = 7
		Me.SimpleButton1.Text = "Editar"
		'
		'TxtNumCuenta
		'
		Me.TxtNumCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtNumCuenta.EditValue = ""
		Me.TxtNumCuenta.Location = New System.Drawing.Point(10, 31)
		Me.TxtNumCuenta.Name = "TxtNumCuenta"
		'
		'
		'
		Me.TxtNumCuenta.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
		Me.TxtNumCuenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.TxtNumCuenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.TxtNumCuenta.Properties.Enabled = False
		Me.TxtNumCuenta.Properties.MaskData.Blank = " "
		Me.TxtNumCuenta.Size = New System.Drawing.Size(269, 17)
		Me.TxtNumCuenta.TabIndex = 0
		'
		'ButNuevoDetalle
		'
		Me.ButNuevoDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.ButNuevoDetalle.ImageIndex = 2
		Me.ButNuevoDetalle.ImageList = Me.ImageList1
		Me.ButNuevoDetalle.Location = New System.Drawing.Point(445, 87)
		Me.ButNuevoDetalle.Name = "ButNuevoDetalle"
		Me.ButNuevoDetalle.Size = New System.Drawing.Size(129, 24)
		Me.ButNuevoDetalle.TabIndex = 0
		Me.ButNuevoDetalle.Text = "Nuevo Detalle"
		'
		'ImageList1
		'
		Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList1.Images.SetKeyName(0, "")
		Me.ImageList1.Images.SetKeyName(1, "")
		Me.ImageList1.Images.SetKeyName(2, "")
		'
		'LblDescCuenta
		'
		Me.LblDescCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.LblDescCuenta.BackColor = System.Drawing.SystemColors.ActiveBorder
		Me.LblDescCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblDescCuenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.LblDescCuenta.Location = New System.Drawing.Point(303, 32)
		Me.LblDescCuenta.Name = "LblDescCuenta"
		Me.LblDescCuenta.Size = New System.Drawing.Size(773, 14)
		Me.LblDescCuenta.TabIndex = 23
		Me.LblDescCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ButAgregarDetalle
		'
		Me.ButAgregarDetalle.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.ButAgregarDetalle.ImageIndex = 0
		Me.ButAgregarDetalle.ImageList = Me.ImageList1
		Me.ButAgregarDetalle.Location = New System.Drawing.Point(577, 87)
		Me.ButAgregarDetalle.Name = "ButAgregarDetalle"
		Me.ButAgregarDetalle.Size = New System.Drawing.Size(129, 24)
		Me.ButAgregarDetalle.TabIndex = 6
		Me.ButAgregarDetalle.Text = "Agregar Detalle"
		'
		'RadHaber
		'
		Me.RadHaber.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.RadHaber.BackColor = System.Drawing.Color.White
		Me.RadHaber.Enabled = False
		Me.RadHaber.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadHaber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.RadHaber.Location = New System.Drawing.Point(796, 68)
		Me.RadHaber.Name = "RadHaber"
		Me.RadHaber.Size = New System.Drawing.Size(60, 12)
		Me.RadHaber.TabIndex = 4
		Me.RadHaber.Text = "&Haber"
		Me.RadHaber.UseVisualStyleBackColor = False
		'
		'RadDebe
		'
		Me.RadDebe.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.RadDebe.BackColor = System.Drawing.Color.White
		Me.RadDebe.Checked = True
		Me.RadDebe.Enabled = False
		Me.RadDebe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.RadDebe.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.RadDebe.Location = New System.Drawing.Point(700, 68)
		Me.RadDebe.Name = "RadDebe"
		Me.RadDebe.Size = New System.Drawing.Size(83, 12)
		Me.RadDebe.TabIndex = 3
		Me.RadDebe.TabStop = True
		Me.RadDebe.Text = "&Debe"
		Me.RadDebe.UseVisualStyleBackColor = False
		'
		'Label13
		'
		Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label13.BackColor = System.Drawing.Color.White
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.Color.Black
		Me.Label13.Location = New System.Drawing.Point(684, 52)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(177, 14)
		Me.Label13.TabIndex = 17
		Me.Label13.Text = "Tipo Movimiento"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtMonto
		'
		Me.TxtMonto.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtMonto.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtMonto.Enabled = False
		Me.TxtMonto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtMonto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TxtMonto.Location = New System.Drawing.Point(893, 67)
		Me.TxtMonto.Name = "TxtMonto"
		Me.TxtMonto.Size = New System.Drawing.Size(182, 13)
		Me.TxtMonto.TabIndex = 5
		Me.TxtMonto.Text = "0.00"
		Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label15
		'
		Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label15.BackColor = System.Drawing.Color.White
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.ForeColor = System.Drawing.Color.Black
		Me.Label15.Location = New System.Drawing.Point(303, 16)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(773, 14)
		Me.Label15.TabIndex = 11
		Me.Label15.Text = "Nombre Cuenta Contable"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label16
		'
		Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label16.BackColor = System.Drawing.Color.White
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.ForeColor = System.Drawing.Color.Black
		Me.Label16.Location = New System.Drawing.Point(893, 52)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(182, 14)
		Me.Label16.TabIndex = 10
		Me.Label16.Text = "Monto"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtDescAsiento
		'
		Me.TxtDescAsiento.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.TxtDescAsiento.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtDescAsiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.TxtDescAsiento.Enabled = False
		Me.TxtDescAsiento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TxtDescAsiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TxtDescAsiento.Location = New System.Drawing.Point(12, 67)
		Me.TxtDescAsiento.Name = "TxtDescAsiento"
		Me.TxtDescAsiento.Size = New System.Drawing.Size(452, 13)
		Me.TxtDescAsiento.TabIndex = 2
		'
		'Label17
		'
		Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label17.BackColor = System.Drawing.Color.White
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.ForeColor = System.Drawing.Color.Black
		Me.Label17.Location = New System.Drawing.Point(12, 52)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(452, 14)
		Me.Label17.TabIndex = 4
		Me.Label17.Text = "Descripción del Asiento"
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label18
		'
		Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label18.BackColor = System.Drawing.Color.White
		Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.ForeColor = System.Drawing.Color.Black
		Me.Label18.Location = New System.Drawing.Point(9, 16)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(270, 14)
		Me.Label18.TabIndex = 0
		Me.Label18.Text = "Cuenta Contable"
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'LblTipo
		'
		Me.LblTipo.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.LblTipo.BackColor = System.Drawing.Color.White
		Me.LblTipo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblTipo.Location = New System.Drawing.Point(685, 67)
		Me.LblTipo.Name = "LblTipo"
		Me.LblTipo.Size = New System.Drawing.Size(175, 14)
		Me.LblTipo.TabIndex = 21
		'
		'AdapAsientos
		'
		Me.AdapAsientos.DeleteCommand = Me.SqlDeleteCommand1
		Me.AdapAsientos.InsertCommand = Me.SqlInsertCommand1
		Me.AdapAsientos.SelectCommand = Me.SqlSelectCommand1
		Me.AdapAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
		Me.AdapAsientos.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento)"
		Me.SqlDeleteCommand1.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlConnection2
		'
		Me.SqlConnection2.ConnectionString = "Data Source=SERVIDOR-PC\CARSERVICE;Initial Catalog=Contabilidad;Integrated Securi" &
	"ty=True"
		Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
		Me.SqlInsertCommand1.Connection = Me.SqlConnection2
		Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.SqlConnection2
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
		Me.SqlUpdateCommand1.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing)})
		'
		'AdapTiposDoc
		'
		Me.AdapTiposDoc.DeleteCommand = Me.SqlDeleteCommand2
		Me.AdapTiposDoc.InsertCommand = Me.SqlInsertCommand2
		Me.AdapTiposDoc.SelectCommand = Me.SqlSelectCommand2
		Me.AdapTiposDoc.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TiposDocumentos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
		Me.AdapTiposDoc.UpdateCommand = Me.SqlUpdateCommand2
		'
		'SqlDeleteCommand2
		'
		Me.SqlDeleteCommand2.CommandText = "DELETE FROM TiposDocumentos WHERE (Id = @Original_Id) AND (Descripcion = @Origina" &
	"l_Descripcion)"
		Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand2
		'
		Me.SqlInsertCommand2.CommandText = "INSERT INTO TiposDocumentos(Id, Descripcion) VALUES (@Id, @Descripcion); SELECT I" &
	"d, Descripcion FROM TiposDocumentos WHERE (Id = @Id)"
		Me.SqlInsertCommand2.Connection = Me.SqlConnection2
		Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion")})
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = "SELECT Id, Descripcion FROM TiposDocumentos"
		Me.SqlSelectCommand2.Connection = Me.SqlConnection2
		'
		'SqlUpdateCommand2
		'
		Me.SqlUpdateCommand2.CommandText = "UPDATE TiposDocumentos SET Id = @Id, Descripcion = @Descripcion WHERE (Id = @Orig" &
	"inal_Id) AND (Descripcion = @Original_Descripcion); SELECT Id, Descripcion FROM " &
	"TiposDocumentos WHERE (Id = @Id)"
		Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
		'
		'AdapDetalles
		'
		Me.AdapDetalles.DeleteCommand = Me.SqlDeleteCommand3
		Me.AdapDetalles.InsertCommand = Me.SqlInsertCommand3
		Me.AdapDetalles.SelectCommand = Me.SqlSelectCommand3
		Me.AdapDetalles.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio"), New System.Data.Common.DataColumnMapping("NoDocumentoDetalle", "NoDocumentoDetalle")})})
		Me.AdapDetalles.UpdateCommand = Me.SqlUpdateCommand3
		'
		'SqlDeleteCommand3
		'
		Me.SqlDeleteCommand3.CommandText = "DELETE FROM [DetallesAsientosContable] WHERE (([ID_Detalle] = @Original_ID_Detall" &
	"e))"
		Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand3
		'
		Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
		Me.SqlInsertCommand3.Connection = Me.SqlConnection2
		Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 0, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 0, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 0, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 0, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 0, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 0, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 0, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@NoDocumentoDetalle", System.Data.SqlDbType.VarChar, 0, "NoDocumentoDetalle")})
		'
		'SqlSelectCommand3
		'
		Me.SqlSelectCommand3.CommandText = "SELECT        ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, D" &
	"escripcionAsiento, Tipocambio, NoDocumentoDetalle" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            DetallesAsien" &
	"tosContable"
		Me.SqlSelectCommand3.Connection = Me.SqlConnection2
		'
		'SqlUpdateCommand3
		'
		Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
		Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 0, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 0, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 0, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 0, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 0, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 0, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 0, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@NoDocumentoDetalle", System.Data.SqlDbType.VarChar, 0, "NoDocumentoDetalle"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
		'
		'ToolBar1
		'
		Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
		Me.ToolBar1.AutoSize = False
		Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarDesmay, Me.ToolBarCerrar, Me.ToolBarCargar})
		Me.ToolBar1.ButtonSize = New System.Drawing.Size(100, 50)
		Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.ToolBar1.DropDownArrows = True
		Me.ToolBar1.ImageList = Me.ImageList
		Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.ToolBar1.Location = New System.Drawing.Point(0, 521)
		Me.ToolBar1.Name = "ToolBar1"
		Me.ToolBar1.ShowToolTips = True
		Me.ToolBar1.Size = New System.Drawing.Size(1106, 52)
		Me.ToolBar1.TabIndex = 83
		'
		'ToolBarNuevo
		'
		Me.ToolBarNuevo.ImageIndex = 0
		Me.ToolBarNuevo.Name = "ToolBarNuevo"
		Me.ToolBarNuevo.Text = "Nuevo"
		'
		'ToolBarBuscar
		'
		Me.ToolBarBuscar.ImageIndex = 1
		Me.ToolBarBuscar.Name = "ToolBarBuscar"
		Me.ToolBarBuscar.Text = "Buscar"
		'
		'ToolBarRegistrar
		'
		Me.ToolBarRegistrar.ImageIndex = 2
		Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
		Me.ToolBarRegistrar.Text = "Registrar"
		'
		'ToolBarEliminar
		'
		Me.ToolBarEliminar.ImageIndex = 3
		Me.ToolBarEliminar.Name = "ToolBarEliminar"
		Me.ToolBarEliminar.Text = "Anular"
		'
		'ToolBarImprimir
		'
		Me.ToolBarImprimir.ImageIndex = 7
		Me.ToolBarImprimir.Name = "ToolBarImprimir"
		Me.ToolBarImprimir.Text = "Imprimir"
		'
		'ToolBarDesmay
		'
		Me.ToolBarDesmay.ImageIndex = 9
		Me.ToolBarDesmay.Name = "ToolBarDesmay"
		Me.ToolBarDesmay.Text = "DesMayorizar"
		'
		'ToolBarCerrar
		'
		Me.ToolBarCerrar.ImageIndex = 6
		Me.ToolBarCerrar.Name = "ToolBarCerrar"
		Me.ToolBarCerrar.Text = "Cerrar"
		'
		'ToolBarCargar
		'
		Me.ToolBarCargar.Name = "ToolBarCargar"
		Me.ToolBarCargar.Text = "Cargar"
		'
		'LblConsecutivo
		'
		Me.LblConsecutivo.BackColor = System.Drawing.Color.White
		Me.LblConsecutivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetAsientos1, "AsientosContables.NumAsiento", True))
		Me.LblConsecutivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblConsecutivo.ForeColor = System.Drawing.Color.Gray
		Me.LblConsecutivo.Location = New System.Drawing.Point(64, 15)
		Me.LblConsecutivo.Name = "LblConsecutivo"
		Me.LblConsecutivo.Size = New System.Drawing.Size(104, 16)
		Me.LblConsecutivo.TabIndex = 84
		'
		'AdapCuentas
		'
		Me.AdapCuentas.DeleteCommand = Me.SqlDeleteCommand4
		Me.AdapCuentas.InsertCommand = Me.SqlInsertCommand4
		Me.AdapCuentas.SelectCommand = Me.SqlSelectCommand4
		Me.AdapCuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id")})})
		Me.AdapCuentas.UpdateCommand = Me.SqlUpdateCommand4
		'
		'SqlDeleteCommand4
		'
		Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
		Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand4
		'
		Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
		Me.SqlInsertCommand4.Connection = Me.SqlConnection2
		Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"), New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"), New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento")})
		'
		'SqlSelectCommand4
		'
		Me.SqlSelectCommand4.CommandText = "SELECT CuentaContable, Descripcion, Nivel, PARENTID, Tipo, CuentaMadre, DescCuent" &
	"aMadre, Movimiento, id FROM CuentaContable"
		Me.SqlSelectCommand4.Connection = Me.SqlConnection2
		'
		'SqlUpdateCommand4
		'
		Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
		Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"), New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"), New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
		'
		'TxtTotalHaber
		'
		Me.TxtTotalHaber.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TxtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtTotalHaber.Location = New System.Drawing.Point(607, 504)
		Me.TxtTotalHaber.Name = "TxtTotalHaber"
		Me.TxtTotalHaber.ReadOnly = True
		Me.TxtTotalHaber.Size = New System.Drawing.Size(120, 13)
		Me.TxtTotalHaber.TabIndex = 77777
		Me.TxtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TxtTotalDebe
		'
		Me.TxtTotalDebe.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TxtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtTotalDebe.Location = New System.Drawing.Point(471, 504)
		Me.TxtTotalDebe.Name = "TxtTotalDebe"
		Me.TxtTotalDebe.ReadOnly = True
		Me.TxtTotalDebe.Size = New System.Drawing.Size(128, 13)
		Me.TxtTotalDebe.TabIndex = 22222
		Me.TxtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label5.BackColor = System.Drawing.Color.White
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Black
		Me.Label5.Location = New System.Drawing.Point(471, 488)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(256, 14)
		Me.Label5.TabIndex = 85
		Me.Label5.Text = "Total Debe¢                Total Haber¢"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'GridControl2
		'
		Me.GridControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GridControl2.DataMember = Nothing
		'
		'
		'
		Me.GridControl2.EmbeddedNavigator.Name = ""
		Me.GridControl2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GridControl2.ForeColor = System.Drawing.Color.Gray
		Me.GridControl2.Location = New System.Drawing.Point(8, 256)
		Me.GridControl2.MainView = Me.GridView1
		Me.GridControl2.Name = "GridControl2"
		Me.GridControl2.Size = New System.Drawing.Size(1090, 224)
		Me.GridControl2.TabIndex = 89
		Me.GridControl2.Text = "GridControl1"
		'
		'GridView1
		'
		Me.GridView1.GroupPanelText = ""
		Me.GridView1.Name = "GridView1"
		Me.GridView1.OptionsPrint.AutoWidth = False
		Me.GridView1.OptionsView.ColumnAutoWidth = False
		'
		'TxtDiferencia
		'
		Me.TxtDiferencia.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TxtDiferencia.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtDiferencia.Location = New System.Drawing.Point(295, 504)
		Me.TxtDiferencia.Name = "TxtDiferencia"
		Me.TxtDiferencia.ReadOnly = True
		Me.TxtDiferencia.Size = New System.Drawing.Size(80, 13)
		Me.TxtDiferencia.TabIndex = 8888
		Me.TxtDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(295, 488)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(80, 14)
		Me.Label3.TabIndex = 90
		Me.Label3.Text = "Dif ¢"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtEstado
		'
		Me.TxtEstado.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtEstado.Location = New System.Drawing.Point(189, 504)
		Me.TxtEstado.Name = "TxtEstado"
		Me.TxtEstado.ReadOnly = True
		Me.TxtEstado.Size = New System.Drawing.Size(90, 13)
		Me.TxtEstado.TabIndex = 32323
		Me.TxtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label2
		'
		Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Black
		Me.Label2.Location = New System.Drawing.Point(183, 488)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(104, 14)
		Me.Label2.TabIndex = 92
		Me.Label2.Text = "Estado"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtUsuario
		'
		Me.TxtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TxtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtUsuario.Location = New System.Drawing.Point(656, 552)
		Me.TxtUsuario.Name = "TxtUsuario"
		Me.TxtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.TxtUsuario.Size = New System.Drawing.Size(72, 13)
		Me.TxtUsuario.TabIndex = 0
		Me.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label4
		'
		Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.Color.Black
		Me.Label4.Location = New System.Drawing.Point(656, 536)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(72, 14)
		Me.Label4.TabIndex = 94
		Me.Label4.Text = "Clave"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TextBox1.Enabled = False
		Me.TextBox1.Location = New System.Drawing.Point(736, 552)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(144, 13)
		Me.TextBox1.TabIndex = 96
		'
		'Label9
		'
		Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
		Me.Label9.BackColor = System.Drawing.Color.White
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.Black
		Me.Label9.Location = New System.Drawing.Point(736, 536)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(144, 14)
		Me.Label9.TabIndex = 97
		Me.Label9.Text = "Usuario"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'AdapFormato
		'
		Me.AdapFormato.DeleteCommand = Me.SqlDeleteCommand5
		Me.AdapFormato.InsertCommand = Me.SqlInsertCommand5
		Me.AdapFormato.SelectCommand = Me.SqlSelectCommand5
		Me.AdapFormato.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FormatoCuenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Niveles", "Niveles"), New System.Data.Common.DataColumnMapping("N1", "N1"), New System.Data.Common.DataColumnMapping("N2", "N2"), New System.Data.Common.DataColumnMapping("N3", "N3"), New System.Data.Common.DataColumnMapping("N4", "N4"), New System.Data.Common.DataColumnMapping("N5", "N5"), New System.Data.Common.DataColumnMapping("N6", "N6"), New System.Data.Common.DataColumnMapping("N7", "N7"), New System.Data.Common.DataColumnMapping("N8", "N8"), New System.Data.Common.DataColumnMapping("Separador", "Separador")})})
		Me.AdapFormato.UpdateCommand = Me.SqlUpdateCommand5
		'
		'SqlDeleteCommand5
		'
		Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
		Me.SqlDeleteCommand5.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand5
		'
		Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
		Me.SqlInsertCommand5.Connection = Me.SqlConnection2
		Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"), New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"), New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"), New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"), New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"), New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"), New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"), New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"), New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"), New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador")})
		'
		'SqlSelectCommand5
		'
		Me.SqlSelectCommand5.CommandText = "SELECT Id, Niveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador FROM FormatoCuenta"
		Me.SqlSelectCommand5.Connection = Me.SqlConnection2
		'
		'SqlUpdateCommand5
		'
		Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
		Me.SqlUpdateCommand5.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"), New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"), New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"), New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"), New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"), New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"), New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"), New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"), New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"), New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
		'
		'btnReporteDetalle
		'
		Me.btnReporteDetalle.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.btnReporteDetalle.Enabled = False
		Me.btnReporteDetalle.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnReporteDetalle.ForeColor = System.Drawing.Color.Black
		Me.btnReporteDetalle.Image = CType(resources.GetObject("btnReporteDetalle.Image"), System.Drawing.Image)
		Me.btnReporteDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.btnReporteDetalle.Location = New System.Drawing.Point(103, 488)
		Me.btnReporteDetalle.Name = "btnReporteDetalle"
		Me.btnReporteDetalle.Size = New System.Drawing.Size(80, 32)
		Me.btnReporteDetalle.TabIndex = 77778
		Me.btnReporteDetalle.Text = "Detalle"
		Me.btnReporteDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.btnReporteDetalle.Visible = False
		'
		'AdapterMoneda
		'
		Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand6
		Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand6
		Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta")})})
		'
		'SqlInsertCommand6
		'
		Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
		Me.SqlInsertCommand6.Connection = Me.SqlConnection2
		Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta")})
		'
		'SqlSelectCommand6
		'
		Me.SqlSelectCommand6.CommandText = "SELECT CodMoneda, MonedaNombre, Simbolo, ValorCompra, ValorVenta FROM Moneda"
		Me.SqlSelectCommand6.Connection = Me.SqlConnection2
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
		Me.Label6.BackColor = System.Drawing.Color.White
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.Black
		Me.Label6.Location = New System.Drawing.Point(968, 48)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(116, 14)
		Me.Label6.TabIndex = 77780
		Me.Label6.Text = "Moneda"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'CheckAnulado
		'
		Me.CheckAnulado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetAsientos1, "AsientosContables.Anulado", True))
		Me.CheckAnulado.Enabled = False
		Me.CheckAnulado.Location = New System.Drawing.Point(795, 0)
		Me.CheckAnulado.Name = "CheckAnulado"
		Me.CheckAnulado.Size = New System.Drawing.Size(74, 26)
		Me.CheckAnulado.TabIndex = 77783
		Me.CheckAnulado.Text = "Anulado"
		'
		'Label11
		'
		Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label11.BackColor = System.Drawing.Color.White
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.Color.Black
		Me.Label11.Location = New System.Drawing.Point(735, 488)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(256, 14)
		Me.Label11.TabIndex = 77784
		Me.Label11.Text = "Total Debe$                Total Haber$"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TxtTotalHaber2
		'
		Me.TxtTotalHaber2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TxtTotalHaber2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtTotalHaber2.Location = New System.Drawing.Point(871, 504)
		Me.TxtTotalHaber2.Name = "TxtTotalHaber2"
		Me.TxtTotalHaber2.ReadOnly = True
		Me.TxtTotalHaber2.Size = New System.Drawing.Size(120, 13)
		Me.TxtTotalHaber2.TabIndex = 77785
		Me.TxtTotalHaber2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'TxtTotalDebe2
		'
		Me.TxtTotalDebe2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TxtTotalDebe2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.TxtTotalDebe2.Location = New System.Drawing.Point(735, 504)
		Me.TxtTotalDebe2.Name = "TxtTotalDebe2"
		Me.TxtTotalDebe2.ReadOnly = True
		Me.TxtTotalDebe2.Size = New System.Drawing.Size(120, 13)
		Me.TxtTotalDebe2.TabIndex = 77786
		Me.TxtTotalDebe2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'txtDif2
		'
		Me.txtDif2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtDif2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.txtDif2.Location = New System.Drawing.Point(383, 504)
		Me.txtDif2.Name = "txtDif2"
		Me.txtDif2.ReadOnly = True
		Me.txtDif2.Size = New System.Drawing.Size(80, 13)
		Me.txtDif2.TabIndex = 77788
		Me.txtDif2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label12
		'
		Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label12.BackColor = System.Drawing.Color.White
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.Color.Black
		Me.Label12.Location = New System.Drawing.Point(383, 488)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(80, 14)
		Me.Label12.TabIndex = 77787
		Me.Label12.Text = "Dif $"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.btnCerrar)
		Me.GroupBox1.Controls.Add(Me.txtDescripción)
		Me.GroupBox1.Controls.Add(Me.Label24)
		Me.GroupBox1.Controls.Add(Me.grControl)
		Me.GroupBox1.Controls.Add(Me.btnQuitar)
		Me.GroupBox1.Controls.Add(Me.btnAgregar)
		Me.GroupBox1.Controls.Add(Me.Label14)
		Me.GroupBox1.Controls.Add(Me.txtMontoCentro)
		Me.GroupBox1.Location = New System.Drawing.Point(80, 248)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(472, 224)
		Me.GroupBox1.TabIndex = 77789
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Centros de Costo"
		Me.GroupBox1.Visible = False
		'
		'btnCerrar
		'
		Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnCerrar.BackColor = System.Drawing.Color.Gold
		Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCerrar.Location = New System.Drawing.Point(328, 192)
		Me.btnCerrar.Name = "btnCerrar"
		Me.btnCerrar.Size = New System.Drawing.Size(128, 24)
		Me.btnCerrar.TabIndex = 7
		Me.btnCerrar.Text = "Terminar"
		Me.btnCerrar.UseVisualStyleBackColor = False
		'
		'txtDescripción
		'
		Me.txtDescripción.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtDescripción.Location = New System.Drawing.Point(128, 40)
		Me.txtDescripción.Name = "txtDescripción"
		Me.txtDescripción.Size = New System.Drawing.Size(184, 20)
		Me.txtDescripción.TabIndex = 6
		'
		'Label24
		'
		Me.Label24.Location = New System.Drawing.Point(128, 16)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(104, 24)
		Me.Label24.TabIndex = 5
		Me.Label24.Text = "Descripción"
		'
		'grControl
		'
		Me.grControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grControl.DataMember = "Centro"
		Me.grControl.DataSource = Me.DataSetAsientos1
		'
		'
		'
		Me.grControl.EmbeddedNavigator.Name = ""
		Me.grControl.Location = New System.Drawing.Point(8, 72)
		Me.grControl.MainView = Me.grdVCCosto
		Me.grControl.Name = "grControl"
		Me.grControl.Size = New System.Drawing.Size(456, 120)
		Me.grControl.TabIndex = 4
		Me.grControl.Text = "GridControl1"
		'
		'grdVCCosto
		'
		Me.grdVCCosto.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcCodigo, Me.gcCentro, Me.gcCuenta, Me.gcNombreCuenta, Me.gcMonto})
		Me.grdVCCosto.Name = "grdVCCosto"
		Me.grdVCCosto.OptionsView.ShowFilterPanel = False
		Me.grdVCCosto.OptionsView.ShowGroupPanel = False
		'
		'gcCodigo
		'
		Me.gcCodigo.Caption = "Código"
		Me.gcCodigo.FieldName = "Codigo"
		Me.gcCodigo.FilterInfo = ColumnFilterInfo1
		Me.gcCodigo.Name = "gcCodigo"
		Me.gcCodigo.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.gcCodigo.VisibleIndex = 0
		'
		'gcCentro
		'
		Me.gcCentro.Caption = "Centro"
		Me.gcCentro.FieldName = "Nombre"
		Me.gcCentro.FilterInfo = ColumnFilterInfo2
		Me.gcCentro.Name = "gcCentro"
		Me.gcCentro.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.gcCentro.VisibleIndex = 1
		'
		'gcCuenta
		'
		Me.gcCuenta.Caption = "Cuenta Contable"
		Me.gcCuenta.FieldName = "Cuenta"
		Me.gcCuenta.FilterInfo = ColumnFilterInfo3
		Me.gcCuenta.Name = "gcCuenta"
		Me.gcCuenta.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.gcCuenta.VisibleIndex = 2
		'
		'gcNombreCuenta
		'
		Me.gcNombreCuenta.Caption = "Descripción"
		Me.gcNombreCuenta.FieldName = "NombreC"
		Me.gcNombreCuenta.FilterInfo = ColumnFilterInfo4
		Me.gcNombreCuenta.Name = "gcNombreCuenta"
		Me.gcNombreCuenta.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.gcNombreCuenta.VisibleIndex = 3
		'
		'gcMonto
		'
		Me.gcMonto.Caption = "Monto"
		Me.gcMonto.FieldName = "Monto"
		Me.gcMonto.FilterInfo = ColumnFilterInfo5
		Me.gcMonto.Name = "gcMonto"
		Me.gcMonto.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.gcMonto.VisibleIndex = 4
		'
		'btnQuitar
		'
		Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnQuitar.Location = New System.Drawing.Point(392, 32)
		Me.btnQuitar.Name = "btnQuitar"
		Me.btnQuitar.Size = New System.Drawing.Size(72, 32)
		Me.btnQuitar.TabIndex = 3
		Me.btnQuitar.Text = "Quitar"
		'
		'btnAgregar
		'
		Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnAgregar.Location = New System.Drawing.Point(320, 32)
		Me.btnAgregar.Name = "btnAgregar"
		Me.btnAgregar.Size = New System.Drawing.Size(72, 32)
		Me.btnAgregar.TabIndex = 2
		Me.btnAgregar.Text = "Agregar"
		'
		'Label14
		'
		Me.Label14.Location = New System.Drawing.Point(16, 16)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(40, 23)
		Me.Label14.TabIndex = 1
		Me.Label14.Text = "Monto:"
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopRight
		'
		'txtMontoCentro
		'
		Me.txtMontoCentro.Location = New System.Drawing.Point(16, 40)
		Me.txtMontoCentro.Name = "txtMontoCentro"
		Me.txtMontoCentro.Size = New System.Drawing.Size(100, 20)
		Me.txtMontoCentro.TabIndex = 0
		Me.txtMontoCentro.Text = "0"
		Me.txtMontoCentro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'AdapCentroMovimiento
		'
		Me.AdapCentroMovimiento.DeleteCommand = Me.SqlDeleteCommand6
		Me.AdapCentroMovimiento.InsertCommand = Me.SqlInsertCommand7
		Me.AdapCentroMovimiento.SelectCommand = Me.SqlSelectCommand7
		Me.AdapCentroMovimiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto_Movimientos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAsiento", "IdAsiento"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdCentroCosto", "IdCentroCosto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("IdDetalle", "IdDetalle")})})
		Me.AdapCentroMovimiento.UpdateCommand = Me.SqlUpdateCommand6
		'
		'SqlDeleteCommand6
		'
		Me.SqlDeleteCommand6.CommandText = "DELETE FROM CentroCosto_Movimientos WHERE (Id = @Original_Id)"
		Me.SqlDeleteCommand6.Connection = Me.SqlConnection2
		Me.SqlDeleteCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand7
		'
		Me.SqlInsertCommand7.CommandText = resources.GetString("SqlInsertCommand7.CommandText")
		Me.SqlInsertCommand7.Connection = Me.SqlConnection2
		Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"), New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle")})
		'
		'SqlSelectCommand7
		'
		Me.SqlSelectCommand7.CommandText = "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descri" &
	"pcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_Mo" &
	"vimientos"
		Me.SqlSelectCommand7.Connection = Me.SqlConnection2
		'
		'SqlUpdateCommand6
		'
		Me.SqlUpdateCommand6.CommandText = resources.GetString("SqlUpdateCommand6.CommandText")
		Me.SqlUpdateCommand6.Connection = Me.SqlConnection2
		Me.SqlUpdateCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"), New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
		'
		'FrmAsientos
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(1106, 573)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.txtDif2)
		Me.Controls.Add(Me.TxtTotalDebe2)
		Me.Controls.Add(Me.TxtTotalHaber2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.TxtUsuario)
		Me.Controls.Add(Me.TxtEstado)
		Me.Controls.Add(Me.TxtDiferencia)
		Me.Controls.Add(Me.TxtTotalHaber)
		Me.Controls.Add(Me.TxtTotalDebe)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.CheckAnulado)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.GridControl2)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.LblConsecutivo)
		Me.Controls.Add(Me.ToolBar1)
		Me.Controls.Add(Me.FrameDetalles)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TituloModulo)
		Me.Controls.Add(Me.FrameEncabezado)
		Me.Controls.Add(Me.btnReporteDetalle)
		Me.MinimumSize = New System.Drawing.Size(917, 612)
		Me.Name = "FrmAsientos"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Módulo Asientos Contables..."
		Me.FrameEncabezado.ResumeLayout(False)
		Me.FrameEncabezado.PerformLayout()
		CType(Me.DataSetAsientos1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.FrameDetalles.ResumeLayout(False)
		Me.FrameDetalles.PerformLayout()
		CType(Me.TxtNumCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.grControl, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grdVCCosto, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

#Region "Load"
	Private Sub FrmAsientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		spIniciarForm()

	End Sub

	Public Sub spIniciarForm()
		Try
			SqlConnection2.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
			TablaTipos = "TiposDocumentos"
			TablaAsientos = "AsientosContables"
			TablaDetalles = "DetallesAsientosContable"
			Me.AdapTiposDoc.Fill(Me.DataSetAsientos1, TablaTipos)
			Me.AdapCuentas.Fill(Me.DataSetAsientos1.CuentaContable)
			Me.AdapFormato.Fill(Me.DataSetAsientos1.FormatoCuenta)
			AdapterMoneda.Fill(Me.DataSetAsientos1.Moneda)
			DesActivarEncabezado()
			DesActivarDetalles()
			ValoresDefault()
			Me.CrearTabla()
			Me.GridControl2.DataSource = Me.TablaAsiento
			Me.SimpleButton1.Enabled = False
			Me.ToolBarBuscar.Enabled = False
			Me.ToolBarNuevo.Enabled = False
			Me.ToolBarEliminar.Enabled = False
			Me.ToolBarImprimir.Enabled = False
			Me.ToolBarRegistrar.Enabled = False
			Me.ButNuevoDetalle.Enabled = False
			Me.DPTrans.Value = Now
			Me.LblPeriodo.Text = Funcion.BuscaPeriodo(DPTrans.Value)
			txtTipoCambio.Text = Funcion.TipoCambio(DPTrans.Value, True)
			obtiene_formato()
			BLOQUEAR()
			clave = GetSetting("SeeSoft", "Seguridad", "Clave")
			If clave.Equals("") Then
				SaveSetting("seesoft", "seguridad", "clave", "1")
			End If

			If NumAsiento <> "" Then
				NombreUsuario = usua.Nombre
				TextBox1.Text = usua.Nombre
				TxtUsuario.Enabled = False
				TextBox1.Enabled = False
				ToolBar1.Buttons(0).Enabled = True
				ToolBar1.Buttons(1).Enabled = True

				Buscar(NumAsiento)

			Else
				If GetSetting("SeeSoft", "Seguridad", "Clave") = "0" Then
					NombreUsuario = usua.Nombre
					TextBox1.Text = usua.Nombre
					TxtUsuario.Enabled = False
					TextBox1.Enabled = False
					ToolBar1.Buttons(0).Enabled = True
					ToolBar1.Buttons(1).Enabled = True
				Else
					TxtUsuario.Focus()
				End If
			End If

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub


	Sub obtiene_formato()

		If Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Count > 0 Then
			separador = ""
			separador = Me.DataSetAsientos1.FormatoCuenta.Rows(0).Item("Separador")
			n1 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N1")
			n2 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N2")
			n3 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N3")
			n4 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N4")
			n5 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N5")
			n6 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N6")
			n7 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N7")
			n8 = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("N8")
			niveles = Me.BindingContext(Me.DataSetAsientos1, "FormatoCuenta").Current("Niveles")
		Else
			'control_toolbar(False)
			MsgBox("No se puede ingresar ninguna Cuenta Contable debido a que no se ha determinado su formato." &
			Chr(13) & "Sugerencia: Ve al 'Formulario de Formato de Cuentas Contables' y crea un formato.", MsgBoxStyle.Exclamation)
		End If
	End Sub

	Private Sub ValoresDefault()
		Dim Fx As New cFunciones
		'Asiento Contable
		Me.DataSetAsientos1.AsientosContables.NumAsientoColumn.DefaultValue = Fx.BuscaNumeroAsiento("CON-" & Format(DPTrans.Value.Month, "00") & Format(DPTrans.Value.Date, "yy") & "-")
		Me.DataSetAsientos1.AsientosContables.PeriodoColumn.DefaultValue = Fx.BuscaPeriodo(DPTrans.Value)
		Me.DataSetAsientos1.AsientosContables.FechaColumn.DefaultValue = Now
		Me.DataSetAsientos1.AsientosContables.IdNumDocColumn.DefaultValue = 0
		Me.DataSetAsientos1.AsientosContables.NumDocColumn.DefaultValue = "0"
		Me.DataSetAsientos1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
		Me.DataSetAsientos1.AsientosContables.TipoDocColumn.DefaultValue = 0
		Me.DataSetAsientos1.AsientosContables.AccionColumn.DefaultValue = "MAN"
		Me.DataSetAsientos1.AsientosContables.AnuladoColumn.DefaultValue = False
		Me.DataSetAsientos1.AsientosContables.FechaEntradaColumn.DefaultValue = Now
		Me.DataSetAsientos1.AsientosContables.MayorizadoColumn.DefaultValue = False
		Me.DataSetAsientos1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
		Me.DataSetAsientos1.AsientosContables.ModuloColumn.DefaultValue = "ASIENTO CONTABLE"
		Me.DataSetAsientos1.AsientosContables.ObservacionesColumn.DefaultValue = ""
		Me.DataSetAsientos1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
		Me.DataSetAsientos1.AsientosContables.TotalDebeColumn.DefaultValue = 0
		Me.DataSetAsientos1.AsientosContables.TotalHaberColumn.DefaultValue = 0
		Me.DataSetAsientos1.AsientosContables.CodMonedaColumn.DefaultValue = 1
		Me.DataSetAsientos1.AsientosContables.TipocambioColumn.DefaultValue = Fx.TipoCambio(DPTrans.Value, True)

		'Detalle Asiento Contable
		Me.DataSetAsientos1.DetallesAsientosContable.ID_DetalleColumn.AutoIncrement = True
		Me.DataSetAsientos1.DetallesAsientosContable.ID_DetalleColumn.AutoIncrementSeed = -1
		Me.DataSetAsientos1.DetallesAsientosContable.ID_DetalleColumn.AutoIncrementStep = -1
		Me.DataSetAsientos1.DetallesAsientosContable.IdTempColumn.AutoIncrement = True
		Me.DataSetAsientos1.DetallesAsientosContable.IdTempColumn.AutoIncrementSeed = -1
		Me.DataSetAsientos1.DetallesAsientosContable.IdTempColumn.AutoIncrementStep = -1
		Me.DataSetAsientos1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = "0"
		Me.DataSetAsientos1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
		Me.DataSetAsientos1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
		Me.DataSetAsientos1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
		Me.DataSetAsientos1.DetallesAsientosContable.DebeColumn.DefaultValue = True
		Me.DataSetAsientos1.DetallesAsientosContable.HaberColumn.DefaultValue = False
		Me.DataSetAsientos1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
		Me.DataSetAsientos1.DetallesAsientosContable.TipocambioColumn.DefaultValue = Fx.TipoCambio(DPTrans.Value, True)
	End Sub

	Private Sub Mascaras()
		Try
			Cuents = "1"
			Mascara = "#"
			For i As Integer = 0 To n1 - 2
				Cuents += "0"
				Mascara += "#"
			Next
			If n2 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n2 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			If n3 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n3 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			If n4 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n4 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			If n5 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n5 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			If n6 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n6 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			If n7 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n7 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			If n8 <> 0 Then
				Cuents += separador
				Mascara += separador
			End If
			For i As Integer = 0 To n8 - 1
				Cuents += "0"
				Mascara += "#"
			Next
			Me.TxtNumCuenta.Properties.MaskData.EditMask = Mascara
			Me.TxtNumCuenta.Text = Cuents

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub


	Function CrearTabla()
		Me.TablaAsiento.Clear()
		Me.TablaAsiento.Columns.Clear()

		Me.CrearColumnas("Cuenta", "Cuenta", 130, 1, "Cuenta", False, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Cuenta", GetType(String)))

		Me.CrearColumnas("NombreCuenta", "Nombre Cuenta", 250, 2, "NombreCuenta", False, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("NombreCuenta", GetType(String)))

		Me.CrearColumnas("Debe", "Debe", 100, 3, "Debe", True, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Debe", GetType(Double)))

		Me.CrearColumnas("Haber", "Haber", 100, 4, "Haber", True, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Haber", GetType(Double)))

		Me.CrearColumnas("Descripcion", "Descripción", 270, 5, "Descripcion", False, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Descripcion", GetType(String)))

		Me.CrearColumnas("NoDocumentoDetalle", "Documento", 100, 6, "NoDocumentoDetalle", False, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("NoDocumentoDetalle", GetType(String)))

		Me.CrearColumnas("Tipocambio", "Tipo Cambio", 80, 7, "Tipocambio", True, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Tipocambio", GetType(Double)))

		Me.CrearColumnas("Debe$", "Debe$", 100, 8, "Debe$", True, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Debe$", GetType(Double)))

		Me.CrearColumnas("Haber$", "Haber$", 100, 9, "Haber$", True, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("Haber$", GetType(Double)))

		Me.CrearColumnas("ID_Detalle", "Cuenta", 0, 10, "ID_Detalle", False, False, False)
		Me.TablaAsiento.Columns.Add(New DataColumn("ID_Detalle", GetType(Integer)))


		'Me.CrearColumnas("IdTemp", "T", 0, 10, "IdTemp", False, False, False)
		'Me.TablaAsiento.Columns.Add(New DataColumn("IdTemp", GetType(Integer)))

	End Function


	Function CrearColumnas(ByVal Nombre As String, ByVal Titulo As String, ByVal Tamano As Int16, ByVal Orden As Int16, ByVal Campo As String, ByVal Numerico As Boolean, ByVal Editable As Boolean, ByVal Calculadora As Boolean)
		Dim Column = Me.GridView1.Columns.Add
		Column.Caption = Titulo
		Column.fieldname = Campo
		Column.Name = Nombre
		Column.VisibleIndex = Orden
		Column.width = Tamano
		If Numerico = True Then
			Column.displayformat.formattype = DevExpress.Utils.FormatType.Numeric
			Column.displayformat.formatstring = "#,#0.00"
		End If
		If Editable = False Then
			Column.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions) Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
		Else
			Column.options = DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused
		End If
	End Function
#End Region

#Region "Validacion Usuario"
	Public Function Loggin_Usuario() As Boolean
		Dim cConexion As New Conexion
		Dim rs As SqlDataReader
		Try

			If TxtUsuario.Text <> "" Then
				rs = cConexion.GetRecorset(Conectando, "SELECT  Nombre from Usuarios where Clave_Interna ='" & TxtUsuario.Text & "'")
				If rs.HasRows = False Then
					MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
					TxtUsuario.Focus()
					TxtUsuario.Text = ""
					Return False
				End If
				While rs.Read
					Try
						NombreUsuario = rs("Nombre")
						TextBox1.Text = rs("Nombre")
						TxtUsuario.Enabled = False
						TextBox1.Enabled = False
						ToolBar1.Buttons(0).Enabled = True
						ToolBar1.Buttons(1).Enabled = True

						Me.DataSetAsientos1.AsientosContables.NombreUsuarioColumn.DefaultValue = rs("Nombre")
						Me.ToolBarNuevo.Enabled = True
						Me.ToolBarBuscar.Enabled = True
						Me.TxtUsuario.Focus()
						Return True

					Catch ex As SystemException
						MsgBox(ex.Message)
					End Try
				End While
				rs.Close()
				cConexion.DesConectar(cConexion.Conectar)
			Else
				MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
				TxtUsuario.Focus()
			End If

		Catch ex As SystemException
			MsgBox(ex.Message)
		End Try
	End Function
#End Region

#Region "Controles"
	Function BLOQUEAR()
		FrameDetalles.Enabled = False
		FrameEncabezado.Enabled = False
		GridControl2.Enabled = False
	End Function

	Function DESBLOQUEAR()
		FrameDetalles.Enabled = True
		FrameEncabezado.Enabled = True
		GridControl2.Enabled = True
	End Function

	Function LIMPIAR()
		ComboTiposDoc.Text = ""
		TxtEstado.Text = ""
		TxtDiferencia.Text = ""
		txtDif2.Text = ""
		TxtTotalDebe.Text = ""
		TxtTotalHaber.Text = ""
		CheckBox2.CheckState = CheckState.Unchecked
	End Function

	Private Sub DesActivarEncabezado()
		Me.TxtBenef.Text = ""
		Me.TxtObservaciones.Text = ""
		TxtDocumento.Text = ""
		Me.DPTrans.Enabled = False
		Me.ComboTiposDoc.Enabled = False
		Me.TxtBenef.Enabled = False
		Me.TxtObservaciones.Enabled = False
		TxtDocumento.Enabled = False
		Me.CBMoneda.Enabled = False
		txtTipoCambio.Enabled = False
	End Sub

	Private Sub ActivarEncabezado()
		Me.DPTrans.Enabled = True
		Me.ComboTiposDoc.Enabled = True
		Me.TxtBenef.Enabled = True
		Me.TxtObservaciones.Enabled = True
		TxtDocumento.Enabled = True
		Me.CBMoneda.Enabled = True
		txtTipoCambio.Enabled = True
	End Sub

	Private Sub DesActivarDetalles()
		Me.TxtNumCuenta.Enabled = False
		Me.TxtDescAsiento.Enabled = False
		Me.RadDebe.Enabled = False
		Me.RadHaber.Enabled = False
		Me.TxtMonto.Enabled = False
		Me.ButAgregarDetalle.Enabled = False
	End Sub

	Private Sub ActivarDetalles()
		Me.TxtNumCuenta.Enabled = True
		Me.TxtDescAsiento.Enabled = True
		Me.RadDebe.Enabled = True
		Me.RadHaber.Enabled = True
		Me.TxtMonto.Enabled = True
		Me.ButAgregarDetalle.Enabled = True
	End Sub

	Private Sub DPTrans_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DPTrans.ValueChanged
		If Nuev Then
			Dim Fx As New cFunciones
			Me.LblPeriodo.Text = Fx.BuscaPeriodo(DPTrans.Value)
			NumeroAsiento()
			txtTipoCambio.Text = Funcion.TipoCambio(DPTrans.Value, True)
		End If
	End Sub


	Private Sub DPTrans_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DPTrans.KeyDown
		If e.KeyCode = Keys.Enter Then
			ComboTiposDoc.Focus()
		End If
	End Sub

	Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteDetalle.Click
		MostrarReporteDetalle()
	End Sub


	Private Sub CBMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBMoneda.KeyDown
		If e.KeyCode = Keys.Enter Then

			TxtObservaciones.Focus()
		End If
	End Sub


	Private Sub RadDebe_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadDebe.Click
		Me.RadHaber.Checked = False
		Me.TxtMonto.Focus()
	End Sub


	Private Sub RadHaber_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadHaber.Click
		Me.RadDebe.Checked = False
		Me.TxtMonto.Focus()
	End Sub


	Private Function ActivarDetalle(ByVal pAccion As Boolean)
		TxtDescAsiento.Enabled = pAccion
		RadDebe.Enabled = pAccion
		RadHaber.Enabled = pAccion
		TxtMonto.Enabled = pAccion
	End Function


	Private Sub LimpiarDetalles()
		TxtNumCuenta.Text = ""
		LblDescCuenta.Text = ""
		TxtMonto.Text = ""
		TxtMonto.Text = "0.00"
		txtNoDocumentoDetalle.Text = ""
		' TxtDescAsiento.Text = ""
	End Sub

	Sub ComprobarArchivoTemporal()
		If System.IO.File.Exists("temp.xml") Then
			Dim r = MsgBox("Hay un archivo de autorecuperación de datos, ¿Desea cargarlo?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo)
			If r = MsgBoxResult.Yes Then
				cargarTemporal()
			Else
				System.IO.File.Delete("temp.xml")
			End If
		End If
	End Sub


	Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
		If e.KeyChar.IsDigit(e.KeyChar) Or (Asc(e.KeyChar)) = System.Windows.Forms.Keys.Back Or (Asc(e.KeyChar)) = 46 Then
			e.Handled = False
		Else
			e.Handled = True
		End If
	End Sub


	Private Sub TxtMonto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtMonto.KeyDown
		If e.KeyCode = Keys.Enter Then
			Dim variable As Double
			Try
				variable = TxtMonto.Text
				TextBoxTipoCambio.Text = txtTipoCambio.Text
				Me.TextBoxTipoCambio.Focus()
				'TxtMonto.Text = Format(variable, "#,#0.0000000000000000000000")
			Catch ex As Exception
				MessageBox.Show("Verifique el formato del monto del asiento", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End Try
		End If
	End Sub


	Private Sub TxtNumCuenta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
		If (Not e.KeyChar.IsDigit(e.KeyChar)) Then
			If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "-") And Not (e.KeyChar = "(") And Not (e.KeyChar = ")") And Not (e.KeyChar = " ") Then
				e.Handled = True
				StrSql = "SELECT * FROM CuentaContable WHERE CuentaContable LIKE '" & Me.TxtNumCuenta.Text & "'"
				Me.AdapCuentas.SelectCommand.CommandText = StrSql
				Me.AdapCuentas.Fill(Me.DataSetAsientos1, "CuentaContable")
				If Me.BindingContext(Me.DataSetAsientos1, "CuentaContable").Count <> 0 Then
					If Me.BindingContext(Me.DataSetAsientos1, "CuentaContable").Current("Movimiento") = "1" Then
						Me.LblDescCuenta.Text = Me.BindingContext(Me.DataSetAsientos1, "CuentaContable").Current("Descripcion")
						Me.TxtDescAsiento.Focus()
					Else
						MsgBox("El Número de Cuenta Ingresado no Puede ser Utilizado Para Esta Operación...Por Favor Verifique", MsgBoxStyle.Exclamation, "Error de Verificación")
						Me.TxtNumCuenta.SelectAll()
					End If
				Else
					MsgBox("Número de Cuenta no Existe...Por Favor Verifique", MsgBoxStyle.Exclamation, "Error de Verificación")
					Me.TxtNumCuenta.SelectAll()
				End If
			End If
		End If
	End Sub


	Private Sub TxtDocumento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDocumento.KeyDown
		If e.KeyCode = Keys.Enter Then
			Me.DPTrans.Focus()
		End If
	End Sub


	'Private Sub TxtNumCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
	'    If e.KeyCode = Keys.Enter Then
	'        TxtDescAsiento.Focus()
	'    End If
	'    If e.KeyCode = Keys.F1 Then
	'        Dim Fx As New cFunciones
	'        Dim valor As String
	'        Dim Id As String
	'        valor = Fx.BuscarDatos("Select Descripcion, CuentaContable from CuentaContable ", "Descripcion", "Buscar Cuenta Madre...", Me.SqlConnection2.ConnectionString)
	'        If valor = "" Then

	'        Else
	'            TxtNumCuenta.Text = valor
	'            LblDescCuenta.Text = cFunciones.Descripcion
	'        End If
	'        TxtDescAsiento.Focus()
	'    End If
	'End Sub


	Private Sub TxtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtUsuario.KeyDown
		If e.KeyCode = Keys.Enter Then
			If Me.Loggin_Usuario() Then
				Nuevo()
				ComprobarArchivoTemporal()
			End If
		End If
	End Sub


	Private Sub TxtBenef_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtBenef.KeyDown
		If e.KeyCode = Keys.Enter Then
			Me.CBMoneda.Focus()
		End If
	End Sub


	Private Sub TxtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtObservaciones.KeyDown
		If e.KeyCode = Keys.Enter Then
			txtTipoCambio.Focus()
		End If
	End Sub


	Private Sub TxtDescAsiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDescAsiento.KeyDown
		If e.KeyCode = Keys.Enter Then
			txtNoDocumentoDetalle.Focus()
		End If
	End Sub


	Private Sub txtTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoCambio.KeyDown
		If e.KeyCode = Keys.Enter Then
			ButNuevoDetalle.Enabled = True
			If NumeroDoc = 15 Then
				spCargarCierreCaja()
			End If
			ButNuevoDetalle.Focus()
		End If
	End Sub


	Private Sub TxtNumCuenta_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtNumCuenta.KeyDown
		If e.KeyCode = Keys.Enter Then
			TxtDescAsiento.Focus()
			Dim funcion As New cFunciones
			Dim Id, n, m As Integer
			Dim Cuenta As String
			Me.TablaBuscar.Clear()
			funcion.Llenar_Tabla_Generico("Select * from vs_CuentaConta where Movimiento = 1", Me.TablaBuscar, Me.SqlConnection2.ConnectionString)
			For n = 0 To Me.TablaBuscar.Rows.Count - 1
				If Me.TxtNumCuenta.Text = TablaBuscar.Rows(n).Item("CuentaContable") Then
					ActivarDetalle(True)
					LblDescCuenta.Text = TablaBuscar.Rows(n).Item("Descripcion")
					TxtDescAsiento.Focus()

					Select Case TablaBuscar.Rows(n).Item("Tipo")
						Case "ACTIVOS"
							RadDebe.Checked = True
						Case "CAPITAL"
							RadHaber.Checked = True
						Case "COSTO VENTA"
							RadDebe.Checked = True
						Case "GASTOS"
							RadDebe.Checked = True
						Case "OTROS GASTOS"
							RadDebe.Checked = True
						Case "INGRESOS"
							RadHaber.Checked = True
						Case "OTROS INGRESOS"
							RadHaber.Checked = True
						Case "PASIVOS"
							RadHaber.Checked = True
					End Select
					Exit Sub
				End If
			Next
			MsgBox("La Cuenta Contable No Es Valida, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")

			TxtNumCuenta.Focus()
			LimpiarDetalles()
			Exit Sub
		End If
		If e.KeyCode = Keys.F1 Then

			Dim frmBuscar As New fmrBuscarMayorizacionAsiento

			Dim sql As String = " select cuentacontable as [Cuenta contable],Nombre,[Cuenta madre] from vs_CuentaConta  "

			frmBuscar.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
			frmBuscar.sqlstring = sql
			frmBuscar.campo = "Descripcion"
			frmBuscar.ShowDialog()

			If frmBuscar.codigo = "" Then

			Else
				ActivarDetalle(True)
				LimpiarDetalles()
				TxtNumCuenta.Text = frmBuscar.codigo
				LblDescCuenta.Text = frmBuscar.descrip

				Dim clsConexion As New Conexion
				Dim cnnConexion As New System.Data.SqlClient.SqlConnection
				Dim rstReader As System.Data.SqlClient.SqlDataReader
				sql = "SELECT tipo  FROM CuentaContable where CuentaContable = '" & frmBuscar.codigo & "'"

				cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
				cnnConexion.Open()

				rstReader = clsConexion.GetRecorset(cnnConexion, sql)

				If rstReader.Read() = False Then Exit Sub

				Select Case rstReader(0)
					Case "ACTIVOS"
						RadDebe.Checked = True
					Case "CAPITAL"
						RadHaber.Checked = True
					Case "COSTO VENTA"
						RadDebe.Checked = True
					Case "GASTOS"
						RadDebe.Checked = True
					Case "INGRESOS"
						RadHaber.Checked = True
					Case "PASIVOS"
						RadHaber.Checked = True
				End Select

				cnnConexion.Close()
			End If

			TxtDescAsiento.Focus()
		End If
	End Sub


	Private Sub ComboTiposDoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboTiposDoc.KeyDown
		Dim Fx As New cFunciones

		Try
			If e.KeyCode = Keys.F1 Then
				NumeroDoc = Fx.BuscarDatos("Select Id, Descripcion from TiposDocumentos ", "Descripcion", "Buscar Tipo de Documento...", Me.SqlConnection2.ConnectionString)
				ComboTiposDoc.Text = cFunciones.Descripcion
				If NumeroDoc = 15 Then
					TxtDescAsiento.Text = "Cierre de Caja del " & DPTrans.Text
					TxtObservaciones.Text = "Cierre de Caja del " & DPTrans.Text
				End If
				CBMoneda.Focus()
			End If


		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Private Sub spCargarCierreCaja()
		Try
			Dim dt As New DataTable
			Dim sql As New SqlCommand
			Dim SubTotalExcento As Double = 0
			Dim SubTotalGravada As Double = 0
			Dim ImpVenta As Double = 0
			Dim Cobro As Double = 0
			Dim Credito As Double = 0
			Dim TipoCambio As Double = 1

			If CBMoneda.SelectedValue > 1 Then
				TipoCambio = CDbl(txtTipoCambio.Text)
			End If

			sql.CommandText = "EXEC [dbo].[SpVentasXFechas2] " & CBMoneda.SelectedValue & ",N'" & DPTrans.Value.Date & "', N'" & DPTrans.Value.Date & "', " & GetSetting("SeeSoft", "SeePos", "Sucursal") & "," & TipoCambio
			cFunciones.Llenar_Tabla_Generico(sql, dt, GetSetting("SeeSoft", "SeePos", "Conexion"))

			For i As Integer = 0 To dt.Rows.Count - 1
				SubTotalExcento += CDbl(dt.Rows(i).Item("SubTotalExcento"))
				SubTotalGravada += CDbl(dt.Rows(i).Item("SubTotalGravada"))
				ImpVenta += CDbl(dt.Rows(i).Item("ImpVenta"))
				Cobro += CDbl(dt.Rows(i).Item("Cobro"))
				Credito += CDbl(dt.Rows(i).Item("Credito"))
			Next

			'Buscar Información de Ingresos de Ventas Gravadas
			Dim cIngGra As String = ""
			Dim cDIngGra As String = ""

			dt.Clear()
			cFunciones.Llenar_Tabla_Generico("SELECT   CuentaGra, DescripcionGra  FROM Familia", dt, GetSetting("SeeSoft", "SeePOS", "Conexion"))

			If dt.Rows.Count > 0 Then
				cIngGra = dt.Rows(0).Item("CuentaGra")
				cDIngGra = dt.Rows(0).Item("DescripcionGra")
			End If
			'Buscar Información de Ingresos de Ventas Excentas
			Dim cIngExe As String = ""
			Dim cDIngExe As String = ""

			dt.Clear()
			cFunciones.Llenar_Tabla_Generico("SELECT   CuentaExe, DescripcionExe  FROM Familia", dt, GetSetting("SeeSoft", "SeePOS", "Conexion"))

			If dt.Rows.Count > 0 Then
				cIngExe = dt.Rows(0).Item("CuentaExe")
				cDIngExe = dt.Rows(0).Item("DescripcionExe")
			End If

			'Buscar Información de Impuesto de Ventas
			Dim cIv As String = ""
			Dim cDIv As String = ""

			dt.Clear()
			cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdImpuestoVenta ", dt, Configuracion.Claves.Conexion("Contabilidad"))

			If dt.Rows.Count > 0 Then
				cIv = dt.Rows(0).Item("CuentaContable")
				cDIv = dt.Rows(0).Item("Descripcion")
			End If

			'Buscar Información de Cuentas x Cobrar
			Dim cCxC As String = ""
			Dim cDCxC As String = ""

			dt.Clear()
			cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCuentaCobrar ", dt, Configuracion.Claves.Conexion("Contabilidad"))

			If dt.Rows.Count > 0 Then
				cCxC = dt.Rows(0).Item("CuentaContable")
				cDCxC = dt.Rows(0).Item("Descripcion")
			End If

			If SubTotalExcento > 0 Then
				spIngresarDatosCierre(Math.Round(SubTotalExcento, 2), cIngExe, cDIngExe, False, True)
			ElseIf SubTotalExcento < 0 Then
				spIngresarDatosCierre(Math.Round(SubTotalExcento * -1, 2), cIngExe, cDIngExe, True, False)
			End If

			If SubTotalGravada > 0 Then
				spIngresarDatosCierre(Math.Round(SubTotalGravada, 2), cIngGra, cDIngGra, False, True)
			ElseIf SubTotalGravada < 0 Then
				spIngresarDatosCierre(Math.Round(SubTotalGravada * -1, 2), cIngGra, cDIngGra, True, False)
			End If

			If ImpVenta > 0 Then
				spIngresarDatosCierre(Math.Round(ImpVenta, 2), cIv, cDIv, False, True)
			ElseIf ImpVenta < 0 Then
				spIngresarDatosCierre(Math.Round(ImpVenta * -1, 2), cIv, cDIv, True, False)
			End If

			If Cobro > 0 Then
				spIngresarDatosCierre(Math.Round(Cobro, 2), cCxC, cDCxC, True, False)
			ElseIf Cobro < 0 Then
				spIngresarDatosCierre(Math.Round(Cobro * -1, 2), cCxC, cDCxC, False, True)
			End If

			If Credito > 0 Then
				spIngresarDatosCierre(Math.Round(Credito, 2), cCxC, cDCxC, True, False)
			ElseIf Credito < 0 Then
				spIngresarDatosCierre(Math.Round(Credito * -1, 2), cCxC, cDCxC, False, True)
			End If

		Catch ex As Exception

		End Try
	End Sub
	Private Sub spIngresarDatosCierre(ByVal Monto As Double, ByVal Cuenta As String, Descripcion As String, ByVal Debe As Boolean, ByVal Haber As Boolean)
		dr = Me.TablaAsiento.NewRow
		dr("ID_Detalle") = id
		dr("Cuenta") = Cuenta
		dr("Descripcion") = TxtDescAsiento.Text
		dr("NombreCuenta") = Descripcion
		dr("Tipocambio") = Me.txtTipoCambio.Text
		dr("NoDocumentoDetalle") = ""
		If Debe Then
			If Me.CBMoneda.SelectedValue = 1 Then
				dr("Debe") = Monto
				dr("Haber") = 0
				If CDbl(Me.txtTipoCambio.Text) = 0 Then
					dr("Debe$") = 0
				Else
					dr("Debe$") = Math.Round(Monto / CDbl(Me.txtTipoCambio.Text), 2)
				End If
				dr("Haber$") = 0
			Else
				If CDbl(Me.txtTipoCambio.Text) = 0 Then
					dr("Debe") = 0
				Else
					dr("Debe") = Math.Round(CDbl(Monto) * CDbl(Me.txtTipoCambio.Text), 2)
				End If

				dr("Haber") = 0
				dr("Debe$") = CDbl(Monto)
				dr("Haber$") = 0
			End If

		Else
			If Me.CBMoneda.SelectedValue = 1 Then
				dr("Debe") = 0
				dr("Haber") = Monto
				dr("Debe$") = 0
				If CDbl(Me.txtTipoCambio.Text) = 0 Then
					dr("Haber$") = 0
				Else
					dr("Haber$") = Math.Round(Monto / CDbl(Me.txtTipoCambio.Text), 2)
				End If

			Else
				dr("Debe") = 0
				If CDbl(Me.txtTipoCambio.Text) = 0 Then
					dr("Haber") = 0
				Else
					dr("Haber") = Math.Round(CDbl(Monto) * CDbl(Me.txtTipoCambio.Text), 2)
				End If
				dr("Debe$") = 0
				dr("Haber$") = CDbl(Monto)
			End If

		End If
		TablaAsiento.Rows.Add(dr)
		id = id - 1

		AgregarDetalle()

		LimpiarDetalles()
		ButAgregarDetalle.Enabled = False
		ActivarDetalle(False)
		ButNuevoDetalle.Focus()

		salvarTemporal()

	End Sub


	Private Sub GridControl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl2.Click
		Dim i As Integer

		Try

			a = Me.BindingContext(TablaAsiento).Position()

			If a = -1 Then
				SimpleButton1.Enabled = False
				butEliminarDetalle.Enabled = False
				Exit Sub
			End If
			Me.ButNuevoDetalle.Text = "Nuevo Detalle"
			Me.ButNuevoDetalle.ImageIndex = "2"
			SimpleButton1.Text = "Editar"
			SimpleButton1.ImageIndex = "9"
			SimpleButton1.Enabled = True
			DesActivarDetalles()
			DESBLOQUEAR()
			TxtNumCuenta.Text = TablaAsiento.Rows(a).Item("Cuenta")
			LblDescCuenta.Text = TablaAsiento.Rows(a).Item("NombreCuenta")
			TxtDescAsiento.Text = TablaAsiento.Rows(a).Item("Descripcion")
			If TablaAsiento.Rows(a).Item("Debe") > 0 Then
				RadDebe.Checked = True
				If Me.CBMoneda.SelectedValue = 1 Then
					TxtMonto.Text = TablaAsiento.Rows(a).Item("Debe")
				Else
					TxtMonto.Text = TablaAsiento.Rows(a).Item("Debe$")
				End If

			Else
				RadHaber.Checked = True
				If Me.CBMoneda.SelectedValue = 1 Then
					TxtMonto.Text = TablaAsiento.Rows(a).Item("Haber")
				Else
					TxtMonto.Text = TablaAsiento.Rows(a).Item("Haber$")
				End If

			End If

			txtNoDocumentoDetalle.Text = TablaAsiento.Rows(a).Item("NoDocumentoDetalle")
			Me.TextBoxTipoCambio.Text = TablaAsiento.Rows(a).Item("Tipocambio")
			Id_Temp = TablaAsiento.Rows(a).Item("ID_Detalle")
			SimpleButton1.Enabled = True
			butEliminarDetalle.Enabled = True
			ButNuevoDetalle.Enabled = True

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Dim Id_Temp As Integer = 0
#End Region

	Private Function nummayorizado() As Integer
		Dim dt As New DataTable
		Dim dato As New DataTable
		Dim resultado As Integer = 0
		cFunciones.Llenar_Tabla_Generico("select * from sysobjects where name = 'Mayorizacion'", dt, Configuracion.Claves.Conexion("Contabilidad"))
		If dt.Rows.Count > 0 Then
			cFunciones.Llenar_Tabla_Generico("select isnull(max(nummayorizacion),0)+1 as num from Mayorizacion ", dato, Configuracion.Claves.Conexion("Contabilidad"))
			resultado = dato.Rows(0).Item(0)
		Else
			cFunciones.Llenar_Tabla_Generico("select isnull(max(nummayorizado),0)+1 as num from AsientosContables", dato, Configuracion.Claves.Conexion("Contabilidad"))
			resultado = dato.Rows(0).Item(0)
		End If
		Return resultado
	End Function

	Private Sub Mayorizacion()
		Dim dt As New DataTable
		Dim dato As New DataTable
		Dim Cconexion As New Conexion
		cFunciones.Llenar_Tabla_Generico("select * from sysobjects where name = 'Mayorizacion'", dt, Configuracion.Claves.Conexion("Contabilidad"))
		Dim num_mayorizacion As Integer = nummayorizado()
		If dt.Rows.Count > 0 Then
			Dim nc1 As String = Cconexion.SlqExecute(Cconexion.Conectar, "insert into Mayorizacion(usuario, fecha, nummayorizacion) values('" & usua.Nombre & "', getdate(), " & num_mayorizacion & ")")

		End If
		Dim nc As String = Cconexion.SlqExecute(Cconexion.Conectar, "Update AsientosContables set Mayorizado = 1, nummayorizado = " & num_mayorizacion & "  where NumAsiento ='" & Me.LblConsecutivo.Text & "'")

	End Sub

	Sub cargaTabla()
		Me.TablaAsiento.Clear()
		For Each f As DataRow In Me.DataSetAsientos1.DetallesAsientosContable.Rows
			dr = Me.TablaAsiento.NewRow
			dr("Cuenta") = f.Item("Cuenta")
			dr("Descripcion") = f.Item("DescripcionAsiento")
			dr("NombreCuenta") = f.Item("NombreCuenta")
			dr("Tipocambio") = f.Item("Tipocambio")
			If Me.CBMoneda.SelectedValue = 1 Then
				If CBool(f.Item("Debe")) = True Then
					dr("Debe") = f.Item("Monto")
					dr("Haber") = 0
					dr("Debe$") = CDbl(f.Item("Monto")) / CDbl(f.Item("Tipocambio"))
					dr("Haber$") = 0
				Else
					dr("Debe") = 0
					dr("Haber") = f.Item("Monto")
					dr("Debe$") = 0
					dr("Haber$") = CDbl(f.Item("Monto")) / CDbl(f.Item("Tipocambio"))
				End If
			Else
				If CBool(f.Item("Debe")) = True Then
					dr("Debe") = CDbl(f.Item("Monto")) * CDbl(f.Item("Tipocambio"))
					dr("Haber") = 0
					dr("Debe$") = f.Item("Monto")
					dr("Haber$") = 0
				Else
					dr("Debe") = 0
					dr("Haber") = CDbl(f.Item("Monto")) * CDbl(f.Item("Tipocambio"))
					dr("Debe$") = 0
					dr("Haber$") = f.Item("Monto")
				End If
			End If


			TablaAsiento.Rows.Add(dr)
		Next

		Me.DataSetAsientos1.DetallesAsientosContable.Clear()
	End Sub

	Sub cargarTemporalEstado(ByVal numAsiento As String, ByVal doc As String)
		Try
			Dim tbl As New DataTable

			Dim cmd As New SqlCommand("Select * from AsientosContables where NumAsiento = @asiento and NumDoc = @doc", SqlConnection2)
			cmd.Parameters.Add("@asiento", SqlDbType.VarChar).Value = numAsiento
			cmd.Parameters.Add("@doc", SqlDbType.VarChar).Value = doc
			cmd.CommandTimeout = 90

			Dim adp As New SqlDataAdapter(cmd)

			adp.Fill(tbl)

			If tbl.Rows.Count > 0 Then
				Me.ToolBar1.Buttons(2).Text = "Actualizar"
			Else
				NumeroAsiento()
				Me.DataSetAsientos1.AsientosContables.Rows(0).Item("NumAsiento") = LblConsecutivo.Text
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("NumAsiento") = LblConsecutivo.Text
				'MsgBox(Me.DataSetAsientos1.AsientosContables.Item(0).NumAsiento)
			End If

		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Exclamation)
		End Try
	End Sub

	Sub cargarTemporal()
		Try
			Me.DataSetAsientos1.Clear()

			Me.DataSetAsientos1.ReadXml("temp.xml", XmlReadMode.DiffGram)
			Dim tipoDoc As Integer = Me.DataSetAsientos1.AsientosContables.Item(0).TipoDoc

			Me.AdapCuentas.Fill(Me.DataSetAsientos1.CuentaContable)

			cargarTemporalEstado(Me.DataSetAsientos1.AsientosContables.Item(0).NumAsiento, Me.DataSetAsientos1.AsientosContables.Item(0).NumDoc)

			For Each f As DataRow In Me.DataSetAsientos1.TiposDocumentos.Rows
				If CInt(f.Item("Id")) = tipoDoc Then
					ComboTiposDoc.Text = f.Item("Descripcion")
				End If
			Next

			cargaTabla()


			ButNuevoDetalle.Enabled = True
			ButNuevoDetalle.Focus()
			Me.ToolBarRegistrar.Enabled = True

			CalculaDiferencia()
			Me.TxtDiferencia.Text = Format(Me.TxtTotalHaber.Text - Me.TxtTotalDebe.Text, "#,#0.00")
			Me.txtDif2.Text = Format(Me.TxtTotalHaber2.Text - Me.TxtTotalDebe2.Text, "#,#0.00")
			If Me.TxtDiferencia.Text = "0.00" And Me.txtDif2.Text = "0.00" Then Me.TxtEstado.Text = "BALANCEADO" Else Me.TxtEstado.Text = "NO BALANCEADO"
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

#Region "ToolBar"
	Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
		Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
		PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

		Select Case ToolBar1.Buttons.IndexOf(e.Button)
			Case 0 : Nuevo()

			Case 1 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

			Case 2 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

			Case 3 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

			Case 4 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

			Case 7 : cargarTemporal()

			Case 6 : Me.Close()

			Case 5

				Dim Cconexion As New Conexion
				If MsgBox("Desea " & Me.ToolBar1.Buttons(5).Text & " el Asiento", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion") = MsgBoxResult.Yes Then
					If Me.ToolBar1.Buttons(5).Text = "Mayorizar" Then
						Mayorizacion()
					Else
						Dim nc As String = Cconexion.SlqExecute(Cconexion.Conectar, "Update AsientosContables set Mayorizado = 0, nummayorizado = 0  where NumAsiento ='" & Me.LblConsecutivo.Text & "'")
					End If
					Buscar(LblConsecutivo.Text)
				End If

		End Select
	End Sub
#End Region

#Region "Imprimir"
	Private Function Imprimir()
		Try
			Dim Asient As New Asientos
			Dim AsientTB As New AsientosTB
            Dim visor As New frmVisorReportes()
            If MsgBox("Desea Los Asientos Colón y Dolar", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
				AsientTB.SetParameterValue(0, LblConsecutivo.Text)
				CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, AsientTB, False, Configuracion.Claves.Conexion("Contabilidad"))
			Else
				Asient.SetParameterValue(0, LblConsecutivo.Text)
				CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Asient, False, Configuracion.Claves.Conexion("Contabilidad"))
			End If

			visor.Show()
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
		End Try
	End Function

	Private Sub MostrarReporteDetalle()
		Dim rptHotelCheque As New rptHotelDetalleCheque
		Dim rptHotelDeposito As New rptHotelDetalleDeposito
		Dim rptHotelAjusteBancarioCredito As New rptHotelDetalleAjusteBancarioCredito
		Dim rptHotelAjusteBancarioDebito As New rptHotelDetalleAjusteBancarioDebito
		Dim rptCompras As New rptProveeduriaDetalleCompra
		Dim rptComprasInventario As New rptProveeduriaDetalleCompraInventario
		Dim rptDevolucionCompra As New rptProveeduriaDevolucionDetalle
		Dim rptDevolucionCompraGravada As New rptProveeduriaDevolucionDetalleGravado
		Dim rptRequisiciones As New rptProveeduriaRequisicionesDetalle
		Dim rptTraslado As New rptProveeduriaTrasladoDetalle
		Dim rptNotasCtasxCobrar As New rptHotelDetalleAjusteCxCAj

		Dim visor As New frmVisorReportes

		If DataSetAsientos1.AsientosContables.Count = 0 Then Exit Sub

		Try
			Select Case DataSetAsientos1.AsientosContables(0).TipoDoc

				Case 1
					rptHotelCheque.RecordSelectionFormula = "not {Cheques.Anulado} and {Cheques.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento()
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptHotelCheque, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 2
					rptHotelDeposito.RecordSelectionFormula = "{Deposito.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento() & " and not {Deposito.Anulado}"
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptHotelDeposito, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 3
					rptHotelAjusteBancarioCredito.RecordSelectionFormula = "{AjusteBancario.Asiento} =  " & DataSetAsientos1.AsientosContables(0).NumAsiento() & "  and {AjusteBancario.Debito} = false and {AjusteBancario.Credito} = true and not {AjusteBancario.Anula} "
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptHotelAjusteBancarioCredito, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 4
					rptHotelAjusteBancarioDebito.RecordSelectionFormula = "{AjusteBancario.Asiento} =  " & DataSetAsientos1.AsientosContables(0).NumAsiento() & "  and {AjusteBancario.Debito} = true and {AjusteBancario.Credito} = false and not {AjusteBancario.Anula} "
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptHotelAjusteBancarioDebito, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 5
					'Compras
					rptCompras.RecordSelectionFormula = " {Compras.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento() & " and {compras.Contabilizado} "
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptCompras, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 6
					'Compras(Inventario
					rptComprasInventario.RecordSelectionFormula = " {compras.ContaInve} and  {compras.AsientoInve} = " & DataSetAsientos1.AsientosContables(0).NumAsiento()
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptComprasInventario, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 7
					'Devolucion compra
					rptDevolucionCompra.RecordSelectionFormula = "{devoluciones_Compras.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento() & " and {devoluciones_Compras.Contabilizado}  "
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptDevolucionCompra, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 8
					'devolucion compra gravada
					rptDevolucionCompraGravada.RecordSelectionFormula = "{devoluciones_Compras.AsientoInventario} = " & DataSetAsientos1.AsientosContables(0).NumAsiento() & " and  {devoluciones_Compras.ContaInventario}  "
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptDevolucionCompraGravada, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 9
					'requisiciones
					rptRequisiciones.RecordSelectionFormula = "{VistaRequisiciones.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento() & " and {VistaRequisiciones.Contabilizado} "
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptRequisiciones, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()

				Case 10
					'traslado
					rptTraslado.RecordSelectionFormula = "{VistaTraslado.Contabilizado} and {VistaTraslado.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento()
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptTraslado, False, GetSetting("SeeSoft", "Bancos", "CONEXION"))
					visor.Show()
				Case 19
					rptNotasCtasxCobrar.RecordSelectionFormula = "{ajustesccobrar.Asiento} = " & DataSetAsientos1.AsientosContables(0).NumAsiento()
					CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptNotasCtasxCobrar, False, GetSetting("hotel", "hotel", "CONEXION"))
					visor.Show()

				Case Else

					MsgBox("La opción de ver el detalle es exclusivo para asientos automáticos")

			End Select
		Catch ex As Exception
			MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
		End Try
	End Sub
#End Region

#Region "Eliminar"
	Sub sp_desbloquearDocumento()
		Dim consulta As String = ""
		Dim modulo As String = "Contabilidad"
		Dim pTipo As String = Me.DataSetAsientos1.AsientosContables(0).Modulo
		pTipo = pTipo.TrimEnd(" ").TrimStart(" ")
		If Not GetSetting("SeeSoft", "Contabilidad", "Tipo").Equals("LCPYMES") Then
			Exit Sub
		End If

		Dim nAs As String = Me.DataSetAsientos1.AsientosContables(0).NumAsiento
		Select Case pTipo
			Case "PLANILLA"
				MsgBox("El asiento de planilla, debe generarse desde el modulo")
				Exit Sub
			Case "CHEQUES"
				consulta = "UPDATE Cheques Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "Bancos"
			Case "Depositos"
				consulta = "UPDATE Deposito Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "Bancos"
			Case "AJUSTE DEB"
				consulta = "UPDATE AjusteBancario Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "Bancos"
			Case "AJUSTE CRE"
				consulta = "UPDATE AjusteBancario Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "Bancos"
			Case "TRANS ENTRE BANC"
				consulta = "UPDATE TransferenciasBancarias Set Num_Asiento = '0', Contabilizado = 0 Where Num_Asiento = '" & nAs & "'"
				modulo = "Bancos"
			Case "FACTURA GASTOS"
				consulta = "UPDATE compras Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "SeePOS"
			Case "Gastos"
				consulta = "UPDATE compras Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "SeePOS"
			Case "FACTURA INV"
				consulta = "UPDATE compras Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "SeePOS"
			Case "FACTURA INV"
				consulta = "UPDATE compras Set Asiento = '0', Contabilizado = 0 Where Asiento = '" & nAs & "'"
				modulo = "SeePOS"

			Case "AJUSTE CXP CRE"
				consulta = "UPDATE Ajustescpagar Set AsientoCre = '0', AsientoDeb = '0', ContaCre = 0, ContaDeb = 0 Where AsientoDeb = '" & nAs & "'"
				modulo = "SeePOS"

			Case "AJUSTE CXP DEB"
				consulta = "UPDATE Ajustescpagar Set AsientoCre = '0', AsientoDeb = '0', ContaCre = 0, ContaDeb = 0 Where AsientoDeb = '" & nAs & "'"
				modulo = "SeePOS"

			Case "AJUSTE CXC CRE"
				consulta = "UPDATE [dbo].[tb_MovimientoCXC] SET [Contabilizado] = 0 ,[Asiento] = '0'  WHERE Asiento = '" & nAs & "'"
				modulo = "Salaberry"

			Case "AJUSTE CXC DEB"
				consulta = "UPDATE [dbo].[tb_MovimientoCXC] SET [Contabilizado] = 0 ,[Asiento] = '0'  WHERE Asiento = '" & nAs & "'"
				modulo = "Salaberry"

			Case "FACTURA VENTAS"
				consulta = "UPDATE [dbo].[Ventas] SET [Contabilizado] = 0 ,[AsientoVenta] = '0'  WHERE AsientoVenta = '" & nAs & "'"
				modulo = "Salaberry"
			Case "FACTURACION MAN"
				consulta = "UPDATE [dbo].[Ventas] SET [Contabilizado] = 0 ,[AsientoVenta] = '0'  WHERE AsientoVenta = '" & nAs & "'"
				modulo = "Salaberry"
			Case "FACTURACION"
				consulta = "UPDATE [dbo].[Ventas] SET [Contabilizado] = 0 ,[AsientoVenta] = '0'  WHERE AsientoVenta = '" & nAs & "'"
				modulo = "Salaberry"

			Case "FACTURAS VENTAS"
				consulta = "UPDATE [dbo].[Ventas] SET [Contabilizado] = 0 ,[AsientoVenta] = '0'  WHERE AsientoVenta = '" & nAs & "'"
				modulo = "Salaberry"

			Case "Prepagos"
				consulta = "UPDATE [dbo].[tb_VinculoCXC] SET [Contabilizado] = 0 ,[Asiento] = '0'  WHERE IdVinculo = '" & nAs & "'"
				modulo = "Salaberry"
			Case "AJUSTE DE SALDO MENOR"
				consulta = "UPDATE [dbo].[tb_MovimientoCXC] SET [Contabilizado] = 0 ,[Asiento] = '0'  WHERE Id_Movimiento = '" & nAs & "'"
				modulo = "Salaberry"

			Case "Asiento de Requisiones"
				consulta = " UPDATE Proveeduria.dbo.Requisiciones SET Contabilizado = 0 ,asiento  =  '0' WHERE asiento  = '" & nAs & "' "
				modulo = "SeePOS"
			Case "Requisiciones"
				consulta = " UPDATE Proveeduria.dbo.Requisiciones SET Contabilizado = 0 ,asiento  =  '0' WHERE asiento  = '" & nAs & "' "
				modulo = "SeePOS"
			Case "Requesiciones" 'ASIENTO BAJADO EN FORMA AGRUPADA
				consulta = " UPDATE Proveeduria.dbo.Requisiciones SET Contabilizado = 0 ,asiento  =  '0' WHERE asiento  = '" & nAs & "' "
				modulo = "SeePOS"
			Case "Asiento Devolucion Compras" 'ASIENTO BAJADO EN FORMA AGRUPADA
				consulta = " UPDATE Proveeduria.dbo.devoluciones_Compras SET Contabilizado = 0 ,Asiento  =  '0' WHERE Asiento  = '" & nAs & "' "
				modulo = "SeePOS"

			Case "Ajuste Entrada Inventario"
				consulta = " UPDATE Proveeduria.dbo.AjusteInventario SET  ContaEntrada = 0 ,AsientoEntrada  = '0' WHERE AsientoEntrada  = '" & nAs & "' "
				modulo = "SeePOS"
			Case "Ajuste Inventario de proveeduría" 'ASIENTO BAJADO EN FORMA AGRUPADA
				consulta = " UPDATE Proveeduria.dbo.AjusteInventario SET  ContaEntrada = 0 ,AsientoEntrada  = '0' WHERE AsientoEntrada  = '" & nAs & "' "
				modulo = "SeePOS"

			Case "Ajuste Salida Inventario" 'ASIENTO BAJADO EN FORMA AGRUPADA
				consulta = " UPDATE Proveeduria.dbo.AjusteInventario SET ContaSalida = 0 ,AsientoSalida  =  '0' WHERE AsientoSalida  = '" & nAs & "' "
				modulo = "SeePOS"

			Case "Asiento de Traslados" 'ASIENTO BAJADO EN FORMA AGRUPADA
				consulta = "UPDATE Proveeduria.dbo.Traslados SET Contabilizado = 1 ,asiento  = '0'  WHERE asiento = '" & nAs & "' "
				modulo = "SeePOS"
			Case "Asiento de Traslados" 'ASIENTO BAJADO EN FORMA AGRUPADA
				consulta = "UPDATE Proveeduria.dbo.Traslados SET Contabilizado = 1 ,asiento  = '0'  WHERE asiento = '" & nAs & "' "
				modulo = "SeePOS"

		End Select
		Dim cnx As New Conexion
		cnx.Conectar(, modulo)
		If consulta <> "" Then
			Dim msj As String = cnx.SlqExecute(cnx.sQlconexion, consulta)
			If Not msj Is Nothing Then
				MsgBox(msj, MsgBoxStyle.OkOnly)

			End If
		End If



	End Sub
	Private Function Eliminar()
		Dim Cconexion As New Conexion
		Dim Resultado, Identificacion As String
		If Me.LblConsecutivo.Text <> "" Then
			If CheckBox2.CheckState = CheckState.Unchecked Then

				If MessageBox.Show(" ¿ Desea Anular Este Asiento ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Function
				Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Update AsientosContables set Anulado = 1  where NumAsiento ='" & Me.LblConsecutivo.Text & "'")
				sp_desbloquearDocumento()
				If Resultado = vbNullString Then
					MessageBox.Show("El Asiento Fue Anulado", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
					Me.DataSetAsientos1.CentroCosto_Movimientos.Clear()
					Me.DataSetAsientos1.DetallesAsientosContable.Clear()
					Me.DataSetAsientos1.AsientosContables.Clear()
					Me.LIMPIAR()
					Me.BLOQUEAR()
					'nuevo
					Me.ToolBar1.Buttons(0).Enabled = True
					'buscar
					Me.ToolBar1.Buttons(1).Enabled = True
					'editar
					Me.ToolBar1.Buttons(2).Enabled = False
					'registrar
					Me.ToolBar1.Buttons(3).Enabled = False
					'eliminar
					Me.ToolBar1.Buttons(4).Enabled = False
					'imprimir
					Me.ToolBar1.Buttons(5).Enabled = True
					'Cerrar
					'Me.ToolBar1.Buttons(6).Enabled = True
				Else
					MessageBox.Show(Resultado)
					Exit Function
				End If
			Else

				MsgBox("No es Posible anular el asiento  porque ya que esta Mayorizado", MsgBoxStyle.Information)
			End If
		Else
			MessageBox.Show("No hay Cuenta Que Eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
		End If
	End Function
#End Region

#Region "Buscar"
	Private NumAsientoParaEliminar As String = ""

	Private Function Buscar()
		Dim funcion As New cFunciones
		Dim Id As String
		Dim Identificacion As Integer

		Try
			Nuev = False
			LIMPIAR()
			DESBLOQUEAR()
			Me.DataSetAsientos1.Centro.Clear()
			Me.DataSetAsientos1.CentroCosto_Movimientos.Clear()
			Me.DataSetAsientos1.DetallesAsientosContable.Clear()
			Me.DataSetAsientos1.AsientosContables.Clear()
			TablaAsiento.Clear()

			' Dim frmBuscar As New Buscar
			'frmBuscar.sqlstring = "SELECT NumAsiento, Descripcion FROM AsientosContablesBus where (NOT(NumAsiento LIKE 'VAL%')) AND  Periodo = '" & funcion.Periodo & "'"
			' frmBuscar.Text = "Buscar Asiento Contable"
			'frmBuscar.campo = "Descripcion"
			'frmBuscar.NuevaConexion = SqlConnection2.ConnectionString
			'frmBuscar.sqlStringAdicional = " ORDER BY NumAsiento DESC"
			'frmBuscar.ShowDialog()
			' Id = frmBuscar.codigo
			Dim frmBuscar As New FrmFindAsientos
			frmBuscar.ShowDialog()
			Id = frmBuscar.Label3.Text
			If Id = Nothing Then ' si se dio en el boton de cancelar
				Exit Function
			End If
			Me.LlenarAsiento(Id)
			Me.LlenarAsientoDetalle(Id)
			LlenarCentroCosto(Id)
			Me.NumAsientoParaEliminar = Id

			Me.BuscarTipoDocumento(Id)
			'mayorizar / desmayorizar
			Me.ToolBar1.Buttons(5).Enabled = True
			Me.ToolBar1.Buttons(5).Text = IIf(Me.CheckBox2.Checked = True, "DesMayorizar", "Mayorizar")
			'nuevo
			Me.ToolBar1.Buttons(0).Enabled = True
			'buscar
			Me.ToolBar1.Buttons(1).Enabled = True
			'editar
			Me.ToolBar1.Buttons(2).Enabled = True
			Me.btnReporteDetalle.Enabled = True
			Me.ToolBar1.Buttons(2).Text = "Actualizar"

			'Anular
			If Me.CheckAnulado.Checked = False Then
				Me.ToolBar1.Buttons(3).Enabled = True
			Else
				Me.ToolBar1.Buttons(3).Enabled = False
			End If
			ActivarEncabezado()
			'eliminar
			Me.ToolBar1.Buttons(4).Enabled = True
			'Imprimir
			Me.ToolBar1.Buttons(5).Enabled = True
			Me.TextBox1.Focus()
			'Cerrar
			If CheckBox2.CheckState = CheckState.Unchecked Then
				Me.GridControl2.Enabled = True

			End If
			Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
			PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo
			editaAutomaticos = PMU.Others

			CalculaDiferencia()
			Me.TxtDiferencia.Text = Me.TxtTotalHaber.Text - Me.TxtTotalDebe.Text
			Me.txtDif2.Text = Me.TxtTotalHaber2.Text - Me.TxtTotalDebe2.Text
			If Me.TxtDiferencia.Text = "0" And Me.txtDif2.Text = "0" Then Me.TxtEstado.Text = "BALANCEADO" Else Me.TxtEstado.Text = "NO BALANCEADO"
			Nuev = True
		Catch ex As SystemException
			MsgBox(ex.Message)
		End Try
	End Function

	Public Function Buscar(ByVal id As String)
		Dim funcion As New cFunciones
		Dim Identificacion As Integer

		Try
			Nuev = False
			LIMPIAR()
			DESBLOQUEAR()
			Me.DataSetAsientos1.DetallesAsientosContable.Clear()
			Me.DataSetAsientos1.AsientosContables.Clear()
			TablaAsiento.Clear()

			NumAsientoParaEliminar = id
			' Dim frmBuscar As New Buscar
			'frmBuscar.sqlstring = "SELECT NumAsiento, Descripcion FROM AsientosContablesBus where (NOT(NumAsiento LIKE 'VAL%')) AND  Periodo = '" & funcion.Periodo & "'"
			' frmBuscar.Text = "Buscar Asiento Contable"
			'frmBuscar.campo = "Descripcion"
			'frmBuscar.NuevaConexion = SqlConnection2.ConnectionString
			'frmBuscar.sqlStringAdicional = " ORDER BY NumAsiento DESC"
			'frmBuscar.ShowDialog()
			' Id = frmBuscar.codigo
			Me.LlenarAsiento(id)
			Me.ToolBar1.Buttons(5).Text = IIf(Me.CheckBox2.Checked = True, "DesMayorizar", "Mayorizar")
			Me.LlenarAsientoDetalle(id)
			Me.BuscarTipoDocumento(id)
			'nuevo
			Me.ToolBar1.Buttons(0).Enabled = True
			'buscar
			Me.ToolBar1.Buttons(1).Enabled = True
			'editar
			Me.ToolBar1.Buttons(2).Enabled = True
			Me.btnReporteDetalle.Enabled = True
			Me.ToolBar1.Buttons(2).Text = "Actualizar"

			'Anular
			If Me.CheckAnulado.Checked = False Then
				Me.ToolBar1.Buttons(3).Enabled = True
			Else
				Me.ToolBar1.Buttons(3).Enabled = False
			End If

			'eliminar
			Me.ToolBar1.Buttons(4).Enabled = True
			'Imprimir
			Me.ToolBar1.Buttons(5).Enabled = True
			Me.TextBox1.Focus()
			'Cerrar
			If CheckBox2.CheckState = CheckState.Unchecked Then
				Me.GridControl2.Enabled = True

			End If

			CalculaDiferencia()
			Me.TxtDiferencia.Text = Me.TxtTotalHaber.Text - Me.TxtTotalDebe.Text
			Me.txtDif2.Text = Me.TxtTotalHaber2.Text - Me.TxtTotalDebe2.Text
			If Me.TxtDiferencia.Text = "0" And Me.txtDif2.Text = "0" Then Me.TxtEstado.Text = "BALANCEADO" Else Me.TxtEstado.Text = "NO BALANCEADO"
			Nuev = True
		Catch ex As SystemException
			MsgBox(ex.Message)
		End Try
	End Function

	Function LlenarAsiento(ByVal Id As String)
		Dim cnnv As SqlConnection = Nothing
		Dim Tipo As Integer
		'Dentro de un Try/Catch por si se produce un error
		Try
			'''''''''LLENAR ASIENTO''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			'Obtenemos la cadena de conexión adecuada
			Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
			cnnv = New SqlConnection(sConn)
			cnnv.Open()
			'Creamos el comando para la consulta
			Dim cmdv As SqlCommand = New SqlCommand
			Dim sel As String = "SELECT * FROM AsientosContables where NumAsiento = @Id"
			cmdv.CommandText = sel
			cmdv.Connection = cnnv
			cmdv.CommandType = CommandType.Text
			cmdv.CommandTimeout = 90
			'Los parámetros usados en la cadena de la consulta 
			cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
			cmdv.Parameters("@Id").Value = Id
			'Creamos el dataAdapter y asignamos el comando de selección
			Dim dv As New SqlDataAdapter
			dv.SelectCommand = cmdv
			' Llenamos la tabla
			dv.Fill(Me.DataSetAsientos1, "AsientosContables")
			NumeroDoc = Me.BindingContext(Me.DataSetAsientos1, "AsientosContables").Current("TipoDoc")
			If Not Me.LblMayor.Text.Equals("0") Then
				Me.LblMayor.ForeColor = ForeColor.Black
			Else
				Me.LblMayor.ForeColor = ForeColor.White
			End If
		Catch ex As System.Exception
			' Si hay error, devolvemos un valor nulo.
			MsgBox(ex.ToString)
		Finally
			' Por si se produce un error,
			' comprobamos si en realidad el objeto Connection está iniciado,
			' de ser así, lo cerramos.
			If Not cnnv Is Nothing Then
				cnnv.Close()
			End If
		End Try
	End Function


	Function LlenarAsientoDetalle(ByVal Id As String)
		Dim cnnv As SqlConnection = Nothing
		'Dentro de un Try/Catch por si se produce un error
		Try
			'''''''''LLENAR ASIENTO DETALLE''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			'Obtenemos la cadena de conexión adecuada
			Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
			cnnv = New SqlConnection(sConn)
			cnnv.Open()
			'Creamos el comando para la consulta
			Dim cmdv As SqlCommand = New SqlCommand
			Dim sel As String = "SELECT * FROM DetallesAsientosContable where NumAsiento = @Id order by Debe desc, Cuenta"
			cmdv.CommandText = sel
			cmdv.Connection = cnnv
			cmdv.CommandType = CommandType.Text
			cmdv.CommandTimeout = 90
			'Los parámetros usados en la cadena de la consulta 
			cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
			cmdv.Parameters("@Id").Value = Id
			'Creamos el dataAdapter y asignamos el comando de selección
			Dim dv As New SqlDataAdapter
			dv.SelectCommand = cmdv
			' Llenamos la tabla
			dv.Fill(Me.DataSetAsientos1, "DetallesAsientosContable")
			Llenar_Campos()

		Catch ex As System.Exception
			' Si hay error, devolvemos un valor nulo.
			MsgBox(ex.ToString)
		Finally
			' Por si se produce un error,
			' comprobamos si en realidad el objeto Connection está iniciado,
			' de ser así, lo cerramos.
			If Not cnnv Is Nothing Then
				cnnv.Close()
			End If
		End Try
	End Function

	Function LlenarCentroCosto(ByVal Id As String)
		Dim cnnv As SqlConnection = Nothing
		'Dentro de un Try/Catch por si se produce un error
		Try
			'''''''''LLENAR ASIENTO DETALLE''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
			'Obtenemos la cadena de conexión adecuada
			Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
			cnnv = New SqlConnection(sConn)
			cnnv.Open()
			'Creamos el comando para la consulta
			Dim cmdv As SqlCommand = New SqlCommand
			DataSetAsientos1.CentroCosto_Movimientos.Clear()

			Dim sel As String = "SELECT * FROM vs_CentroCostoMovimientos where IdAsiento = @Id "
			cmdv.CommandText = sel
			cmdv.Connection = cnnv
			cmdv.CommandType = CommandType.Text
			cmdv.CommandTimeout = 90
			'Los parámetros usados en la cadena de la consulta 
			cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
			cmdv.Parameters("@Id").Value = Id
			'Creamos el dataAdapter y asignamos el comando de selección
			Dim dv As New SqlDataAdapter
			dv.SelectCommand = cmdv
			' Llenamos la tabla
			dv.Fill(Me.DataSetAsientos1, "CentroCosto_Movimientos")


		Catch ex As System.Exception
			' Si hay error, devolvemos un valor nulo.
			MsgBox(ex.ToString)
		Finally
			' Por si se produce un error,
			' comprobamos si en realidad el objeto Connection está iniciado,
			' de ser así, lo cerramos.
			If Not cnnv Is Nothing Then
				cnnv.Close()
			End If
		End Try
	End Function

	Private Sub BuscarTipoDocumento(ByVal pId As String)
		Dim clsConexion As New Conexion
		Dim cnnConexion As New System.Data.SqlClient.SqlConnection
		Dim rstReader As SqlClient.SqlDataReader
		Dim sql As String
		sql = "SELECT Descripcion FROM AsientosContables A , TiposDocumentos T where T.id = A.Tipodoc AND  A.NumAsiento = '" & pId & "'"

		cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
		cnnConexion.Open()

		rstReader = clsConexion.GetRecorset(cnnConexion, sql)
		If rstReader.Read() = False Then Exit Sub

		Me.ComboTiposDoc.Text = rstReader("Descripcion")
	End Sub


	Private Sub Llenar_Campos()
		Dim i As Integer
		TablaAsiento.Clear()

		For i = 0 To DataSetAsientos1.DetallesAsientosContable.Rows.Count - 1
			dr = Me.TablaAsiento.NewRow
			dr("Cuenta") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Cuenta")
			dr("Descripcion") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("DescripcionAsiento")
			dr("NombreCuenta") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("NombreCuenta")
			If DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Debe") Then
				If DataSetAsientos1.AsientosContables.Rows(0).Item("CodMoneda") = 1 Then
					dr("Debe") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto")
					dr("Haber") = 0
					If CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio")) = 0 Then
						dr("Debe$") = 0
					Else
						dr("Debe$") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto") / CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio"))
					End If
					dr("Haber$") = 0
				Else
					If CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio")) = 0 Then
						dr("Debe") = 0
					Else
						dr("Debe") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto") * CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio"))
					End If
					dr("Haber") = 0
					dr("Debe$") = CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto"))
					dr("Haber$") = 0
				End If

			Else
				If DataSetAsientos1.AsientosContables.Rows(0).Item("CodMoneda") = 1 Then
					dr("Haber") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto")
					dr("debe") = 0
					If CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio")) = 0 Then
						dr("Haber$") = 0
					Else
						dr("Haber$") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto") / CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio"))
					End If
					dr("debe$") = 0
				Else
					If CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio")) = 0 Then
						dr("Haber") = 0
					Else
						dr("Haber") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto") * CDbl(DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio"))
					End If
					dr("debe") = 0
					dr("Haber$") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Monto")
					dr("debe$") = 0
				End If

			End If

			dr("ID_Detalle") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("ID_Detalle")
			DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("IdTemp") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("ID_Detalle")
			dr("Tipocambio") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("Tipocambio")
			dr("NoDocumentoDetalle") = DataSetAsientos1.DetallesAsientosContable.Rows(i).Item("NoDocumentoDetalle")
			TablaAsiento.Rows.Add(dr)
		Next
	End Sub
#End Region

#Region "Guardar"
	Private Sub Registrar()
		Dim trans As SqlTransaction
		Dim Fx As New cFunciones

		Try
			If Configuracion.Claves.Conexion("Contabilidad").Equals("") Then
				If CheckBox2.Checked = True Then
					MsgBox("El Asiento no se puede actualizar porque ya esta mayorizado", MsgBoxStyle.Information, "Sistema SeeSoft")
					Exit Sub

				End If
			End If


			If ValidarAsiento() Then
			Else
				MsgBox("El Asiento Debe Estar Balanceado", MsgBoxStyle.Information, "Sistema SeeSoft")
				Exit Sub
			End If


			'-------------------------------------------------------------------------------
			'VALIDA EL PERIODO DE TRABAJO
			If Fx.ValidarPeriodo(DPTrans.Value) = False Then
				MsgBox("La Fecha del Asiento No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
				Exit Sub
			End If
			'-------------------------------------------------------------------------------
			If Me.DataSetAsientos1.AsientosContables.Item(0).TipoDoc = 0 Then
				Me.DataSetAsientos1.AsientosContables.Item(0).TipoDoc = NumeroDoc
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("TipoDoc") = NumeroDoc
			End If
			'BindingContext(DataSetAsientos1, "AsientosContables").Current("TipoDoc") = NumeroDoc
			If Me.CBMoneda.SelectedValue = 1 Then
				Me.DataSetAsientos1.AsientosContables.Item(0).TotalDebe = CDbl(TxtTotalDebe.Text)
				Me.DataSetAsientos1.AsientosContables.Item(0).TotalHaber = CDbl(TxtTotalHaber.Text)
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("TotalDebe") = CDbl(TxtTotalDebe.Text)
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("TotalHaber") = CDbl(TxtTotalHaber.Text)
			Else
				Me.DataSetAsientos1.AsientosContables.Item(0).TotalDebe = CDbl(TxtTotalDebe2.Text)
				Me.DataSetAsientos1.AsientosContables.Item(0).TotalHaber = CDbl(TxtTotalHaber2.Text)
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("TotalDebe") = CDbl(TxtTotalDebe2.Text)
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("TotalHaber") = CDbl(TxtTotalHaber2.Text)
			End If
			'  BindingContext(DataSetAsientos1, "AsientosContables").EndCurrentEdit()

			Nuev = False

			If Me.ToolBar1.Buttons(2).Text = "Actualizar" Then
				'DIEGO
				'If BindingContext(DataSetAsientos1, "AsientosContables").Current("Accion") = "AUT" Then
				'    MsgBox("No se puede modificar el asiento contable!" & vbCrLf & "Porque fue creado automaticamente por el sistema", MsgBoxStyle.Information, "Sistema SeeSoft")
				'    Exit Sub
				'End If
				DataSetAsientos1.DetallesAsientosContable.Clear()
				BindingContext(DataSetAsientos1, "AsientosContables").EndCurrentEdit()
				AdapAsientos.Update(DataSetAsientos1, "AsientosContables")
				ActualizaDatos()
				Llenar()
				AdapDetalles.Update(DataSetAsientos1, "DetallesAsientosContable")
				For i As Integer = 0 To Me.DataSetAsientos1.DetallesAsientosContable.Count - 1
					For j As Integer = 0 To Me.DataSetAsientos1.CentroCosto_Movimientos.Count - 1
						If Me.DataSetAsientos1.CentroCosto_Movimientos(j).IdDetalle = Me.DataSetAsientos1.DetallesAsientosContable(i).IdTemp Then
							Me.DataSetAsientos1.CentroCosto_Movimientos(j).IdDetalle = Me.DataSetAsientos1.DetallesAsientosContable(i).ID_Detalle
						End If
					Next
				Next
				Me.DataSetAsientos1.CentroCosto_Movimientos.EndInit()
				For x As Integer = 0 To Me.DataSetAsientos1.CentroCosto_Movimientos.Count - 1
					If Not Me.DataSetAsientos1.CentroCosto_Movimientos(x).RowState = DataRowState.Deleted Then
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").AddNew()
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("IdAsiento") = Me.LblConsecutivo.Text
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Documento") = Me.TxtDocumento.Text
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Fecha") = Now
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("IdCentroCosto") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).IdCentroCosto
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Monto") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).Monto
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Debe") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).Debe
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Haber") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).Haber
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Descripcion") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).Descripcion
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("CuentaContable") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).CuentaContable
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("NombreCuentaContable") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).NombreCuentaContable
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Tipo") = 33
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("IdDetalle") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).IdDetalle
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").Current("Nombre") = Me.DataSetAsientos1.CentroCosto_Movimientos(x).NombreCuentaContable
						Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_MovimientosUP").EndCurrentEdit()

					End If

				Next

				Me.AdapCentroMovimiento.Update(Me.DataSetAsientos1.CentroCosto_MovimientosUP)

				ToolBar1.Buttons(2).Text = "Registrar"
				If Me.ToolBar1.Buttons(5).Text = "Mayorizar" Then
					If MsgBox("¿Desea mayorizar el asiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						Mayorizacion()
					End If

				End If
				If MsgBox("¿Desea imprmir el asiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
					Me.Imprimir()

				End If

				MsgBox("Asiento Contable Actualizado exitosamente", MsgBoxStyle.Information)

				LIMPIAR()
				BLOQUEAR()
				TablaAsiento.Clear()
				ToolBarRegistrar.Enabled = False
				ToolBarBuscar.Enabled = True
			Else
				NumeroAsiento()
				Me.DataSetAsientos1.AsientosContables.Rows(0).Item("NumAsiento") = LblConsecutivo.Text
				'BindingContext(DataSetAsientos1, "AsientosContables").Current("NumAsiento") = LblConsecutivo.Text
				'BindingContext(DataSetAsientos1, "AsientosContables").EndCurrentEdit()
				If SqlConnection2.State <> ConnectionState.Open Then SqlConnection2.Open()
				trans = Me.SqlConnection2.BeginTransaction
				Me.AdapAsientos.InsertCommand.Transaction = trans
				Me.AdapAsientos.UpdateCommand.Transaction = trans
				Me.AdapAsientos.DeleteCommand.Transaction = trans
				Me.AdapAsientos.Update(Me.DataSetAsientos1, "AsientosContables")
				Llenar()
				Me.AdapDetalles.InsertCommand.Transaction = trans
				Me.AdapDetalles.UpdateCommand.Transaction = trans
				Me.AdapDetalles.DeleteCommand.Transaction = trans
				Me.AdapDetalles.Update(Me.DataSetAsientos1, "DetallesAsientosContable")

				For i As Integer = 0 To Me.DataSetAsientos1.DetallesAsientosContable.Count - 1
					For j As Integer = 0 To Me.DataSetAsientos1.CentroCosto_Movimientos.Count - 1
						If Me.DataSetAsientos1.CentroCosto_Movimientos(j).IdDetalle = Me.DataSetAsientos1.DetallesAsientosContable(i).IdTemp Then
							Me.DataSetAsientos1.CentroCosto_Movimientos(j).IdDetalle = Me.DataSetAsientos1.DetallesAsientosContable(i).ID_Detalle
						End If
					Next
				Next
				Me.DataSetAsientos1.CentroCosto_Movimientos.EndInit()

				Me.AdapCentroMovimiento.InsertCommand.Transaction = trans
				Me.AdapCentroMovimiento.UpdateCommand.Transaction = trans
				Me.AdapCentroMovimiento.DeleteCommand.Transaction = trans
				Me.AdapCentroMovimiento.Update(Me.DataSetAsientos1, "CentroCosto_Movimientos")

				Me.DataSetAsientos1.AcceptChanges()

				trans.Commit()
				Me.ToolBarNuevo.Enabled = True
				Me.ToolBarNuevo.ImageIndex = 0
				Me.ToolBarNuevo.Text = "Nuevo"
				If Me.ToolBar1.Buttons(5).Text = "Mayorizar" Then
					If MsgBox("¿Desea mayorizar el asiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
						Mayorizacion()
					End If

				End If
				If MsgBox("¿Desea imprmir el asiento?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
					Me.Imprimir()

				End If

				MsgBox("Asiento Contable Registrado exitosamente", MsgBoxStyle.Information)
				Me.DataSetAsientos1.DetallesAsientosContable.Clear()
				Me.DataSetAsientos1.AsientosContables.Clear()
				LIMPIAR()
				BLOQUEAR()
				Me.TablaAsiento.Clear()
				Me.ToolBarRegistrar.Enabled = False
				Me.ToolBarBuscar.Enabled = True
				Me.btnReporteDetalle.Enabled = False
			End If

			System.IO.File.Delete("temp.xml")
		Catch ex As Exception
			MsgBox(ex.ToString)
			trans.Rollback()
		Finally
			Nuev = True
			Me.SqlConnection2.Close()
		End Try
	End Sub


	Function ValidarAsiento()
		If TxtEstado.Text = "BALANCEADO" Then
			Return True
		End If
		Return False
	End Function

	Private Sub ActualizaDatos()
		Dim Funciones As New Conexion
		Funciones.SlqExecute(Funciones.Conectar, "exec [dbo].[spEliminarDeposito] '" & Me.NumAsientoParaEliminar & "'")
		Funciones.DeleteRecords("DetallesAsientosContable", "NumAsiento ='" & Me.NumAsientoParaEliminar & "'")
		Funciones.DeleteRecords("CentroCosto_Movimientos", "IdAsiento ='" & Me.NumAsientoParaEliminar & "'")

	End Sub

	Private Sub Llenar()
		Dim i, n As Integer

		For i = 0 To TablaAsiento.Rows.Count - 1

			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").AddNew()
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("NumAsiento") = LblConsecutivo.Text
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Cuenta") = TablaAsiento.Rows(i).Item("Cuenta")
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("NombreCuenta") = TablaAsiento.Rows(i).Item("NombreCuenta")
			If Me.CBMoneda.SelectedValue = 1 Then
				If TablaAsiento.Rows(i).Item("Debe") > 0 Then
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Monto") = TablaAsiento.Rows(i).Item("Debe")
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Debe") = True
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Haber") = False
				Else
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Monto") = TablaAsiento.Rows(i).Item("Haber")
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Debe") = False
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Haber") = True
				End If
			Else
				If TablaAsiento.Rows(i).Item("Debe$") > 0 Then
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Monto") = TablaAsiento.Rows(i).Item("Debe$")
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Debe") = True
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Haber") = False
				Else
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Monto") = TablaAsiento.Rows(i).Item("Haber$")
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Debe") = False
					Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Haber") = True
				End If
			End If

			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("DescripcionAsiento") = TablaAsiento.Rows(i).Item("Descripcion")
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("Tipocambio") = TablaAsiento.Rows(i).Item("Tipocambio")
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("IdTemp") = TablaAsiento.Rows(i).Item("ID_Detalle")
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").Current("NoDocumentoDetalle") = TablaAsiento.Rows(i).Item("NoDocumentoDetalle")
			Me.BindingContext(Me.DataSetAsientos1, "DetallesAsientosContable").EndCurrentEdit()
		Next
	End Sub
#End Region

#Region "Nuevo"
	Public Sub Nuevo()
		Me.ToolBar1.Buttons(5).Text = IIf(Me.CheckBox2.Checked = True, "DesMayorizar", "Mayorizar")
		Me.btnReporteDetalle.Enabled = True
		If Me.ToolBarNuevo.Text = "Nuevo" Then
			Me.ToolBar1.Buttons(5).Enabled = False
			Nuev = False
			Me.ToolBarNuevo.ImageIndex = "8"
			Me.ToolBarNuevo.Text = "Cancelar"
			Me.DataSetAsientos1.Centro.Clear()
			Me.DataSetAsientos1.CentroCosto_Movimientos.Clear()
			Me.DataSetAsientos1.DetallesAsientosContable.Clear()
			ActivarEncabezado()
			Me.DataSetAsientos1.AsientosContables.Clear()
			Me.BindingContext(Me.DataSetAsientos1, "AsientosContables").EndCurrentEdit()
			Me.BindingContext(Me.DataSetAsientos1, "AsientosContables").AddNew()
			Me.ToolBar1.Buttons(2).Text = "Registrar"
			LIMPIAR()
			DESBLOQUEAR()
			ButNuevoDetalle.Enabled = False
			ButAgregarDetalle.Enabled = False
			Me.TxtDocumento.Focus()
			TablaAsiento.Clear()

			Nuev = True
		Else
			Nuev = False
			Me.ToolBarNuevo.ImageIndex = "0"
			Me.ToolBarNuevo.Text = "Nuevo"
			BindingContext(Me.DataSetAsientos1, "AsientosContables").CancelCurrentEdit()
			LIMPIAR()
			BLOQUEAR()
			Me.DataSetAsientos1.DetallesAsientosContable.Clear()
			Me.DataSetAsientos1.AsientosContables.Clear()
			Me.ToolBarRegistrar.Enabled = False
			Nuev = True
		End If
	End Sub

#End Region

#Region "Nuevo Detalle"
	Private Sub ButNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNuevoDetalle.Click
		Me.AdapCuentas.Fill(Me.DataSetAsientos1.CuentaContable)
		If Me.BindingContext(DataSetAsientos1, "AsientosContables").Current("Accion") = "AUT" And (Not editaAutomaticos) Then
			MsgBox("No se puede modificar el asiento contable!" & vbCrLf & "Porque fue creado automaticamente por el sistema", MsgBoxStyle.Information, "Sistema SeeSoft")
			Exit Sub
		End If
		ActivarDetalles()
		Dim consecutivo As String = LblConsecutivo.Text
		If Me.ButNuevoDetalle.Text = "Nuevo Detalle" Then
			Me.ToolBarRegistrar.Enabled = True
			Me.ButNuevoDetalle.Text = "Cancelar Detalle"
			Me.ButNuevoDetalle.ImageIndex = "1"
			Me.BindingContext(Me.DataSetAsientos1, "AsientosContables").Current("TipoDoc") = NumeroDoc
			Me.BindingContext(Me.DataSetAsientos1, "AsientosContables").EndCurrentEdit()
			Me.LblConsecutivo.Text = consecutivo
			Me.TxtNumCuenta.Focus()
			SimpleButton1.Enabled = False
			butEliminarDetalle.Enabled = False
			SimpleButton1.Text = "Editar"
			Me.btnVerCentroC.Enabled = False

			SimpleButton1.ImageIndex = "9"
			Mascaras()
			TxtNumCuenta.Enabled = True

		Else
			Me.DataSetAsientos1.DetallesAsientosContable.Clear()
			ButAgregarDetalle.Enabled = False
			Me.BindingContext(DataSetAsientos1, "DetallesAsientosContable").CancelCurrentEdit()
			Me.ButNuevoDetalle.Text = "Nuevo Detalle"
			Me.ButNuevoDetalle.ImageIndex = "2"
			SimpleButton1.Enabled = False
			butEliminarDetalle.Enabled = False
			TxtNumCuenta.Enabled = False
		End If

		ActivarDetalle(False)
		LimpiarDetalles()
	End Sub
#End Region

	Sub salvarTemporal()
		Me.DataSetAsientos1.DetallesAsientosContable.Clear()
		Llenar()
		Me.DataSetAsientos1.WriteXml("temp.xml", XmlWriteMode.DiffGram)
		Me.DataSetAsientos1.DetallesAsientosContable.Clear()
	End Sub

	Private Sub txtNoDocumentoDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNoDocumentoDetalle.KeyDown

		If e.KeyCode = Keys.Enter Then
			If fnValidarNoDocumentoDetalle() Then
				If txtNoDocumentoDetalle.Text.Replace(" ", "").Length = 0 Then
					MessageBox.Show("Por favor, ingrese un número de documento.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
					txtNoDocumentoDetalle.Focus()
				Else
					If fnValidarNoDocumentoDetalleDeposito() Then
						MessageBox.Show("El número de documento ya esta registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
						txtNoDocumentoDetalle.Focus()
					Else
						TxtMonto.Focus()
					End If

				End If
			Else
				TxtMonto.Focus()
			End If
		End If
	End Sub

	Private Function fnValidarNoDocumentoDetalle() As Boolean
		Try
			Dim cx As New Conexion
			Dim existe As Integer

			existe = cx.SlqExecuteScalar(cx.Conectar("Bancos"), "SELECT COUNT(*) FROM [Bancos].[dbo].[Cuentas_bancarias] where CuentaContable = '" & TxtNumCuenta.Text & "'")

			If existe > 0 Then
				Return True
			End If
			Return False
		Catch ex As Exception
			Return False
		End Try
	End Function

	Private Function fnValidarNoDocumentoDetalleDeposito() As Boolean
		Try
			Dim cx As New Conexion
			Dim existe As Integer

			existe = cx.SlqExecuteScalar(cx.Conectar(), "select COUNT(*) from [Bancos].[dbo].Deposito as d inner join [Bancos].[dbo].Cuentas_bancarias as c  on d.Id_CuentaBancaria = c.Id_CuentaBancaria where d.Anulado = 0 and  c.CuentaContable = '" & TxtNumCuenta.Text & "' and d.NumeroDocumento = '" & txtNoDocumentoDetalle.Text & "'")

			If existe > 0 Then
				Return True
			End If
			Return False
		Catch ex As Exception
			Return False
		End Try
	End Function

#Region "Agrega Detalle"
	Private Sub ButAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAgregarDetalle.Click
		If fnValidarNoDocumentoDetalle() Then
			If txtNoDocumentoDetalle.Text.Replace(" ", "").Length = 0 Then
				MessageBox.Show("Por Favor, ingrese un número de documento.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
				txtNoDocumentoDetalle.Focus()
				Exit Sub
			Else
				If fnValidarNoDocumentoDetalleDeposito() Then
					MessageBox.Show("El número de documento ya esta registrado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
					txtNoDocumentoDetalle.Focus()
					Exit Sub
				End If
			End If

		End If

		If DetallesVerificado() Then
			If Me.TxtMonto.Text <> 0 Then
				CargarDatos()
				AgregarDetalle()

				LimpiarDetalles()
				ButAgregarDetalle.Enabled = False
				ActivarDetalle(False)
				ButNuevoDetalle.Focus()

				salvarTemporal()
			Else
				MsgBox("El Monto del Asiento No Puede ser Cero. Por Favor Verifique...", 16, "Error de Validación de Datos...")
			End If
		Else
			MsgBox("Captura de Datos Incompleta. Por Favor Verifique...", 16, "Error de Validación de Datos...")
		End If
	End Sub

	Private Sub spCarlcularDirefenciaPorTipoCambio()
		Try
			If CBMoneda.SelectedValue = 1 Then

				If CDbl(TxtDiferencia.Text) = 0 Then

					If CDbl(txtDif2.Text) <= 0.02 And CDbl(txtDif2.Text) > 0 Then

						For i As Integer = 0 To TablaAsiento.Rows.Count - 1
							If CDbl(TablaAsiento.Rows(i).Item("Debe$")) > 0 Then
								TablaAsiento.Rows(i).Item("Debe$") = CDbl(TablaAsiento.Rows(i).Item("Debe$")) + CDbl(txtDif2.Text)
								AgregarDetalle()
								Exit Sub
							End If

						Next
					End If
					If CDbl(txtDif2.Text) >= -0.02 And CDbl(txtDif2.Text) < 0 Then

						For i As Integer = 0 To TablaAsiento.Rows.Count - 1
							If CDbl(TablaAsiento.Rows(i).Item("Haber$")) > 0 Then
								TablaAsiento.Rows(i).Item("Haber$") = CDbl(TablaAsiento.Rows(i).Item("Haber$")) + Math.Abs(CDbl(txtDif2.Text))
								AgregarDetalle()
								Exit Sub
							End If

						Next
					End If
				End If


			Else

				If CDbl(txtDif2.Text) = 0 Then

					If CDbl(TxtDiferencia.Text) <= 0.02 And CDbl(TxtDiferencia.Text) > 0 Then

						For i As Integer = 0 To TablaAsiento.Rows.Count - 1
							If CDbl(TablaAsiento.Rows(i).Item("Debe")) > 0 Then
								TablaAsiento.Rows(i).Item("Debe") = CDbl(TablaAsiento.Rows(i).Item("Debe")) + CDbl(TxtDiferencia.Text)
								AgregarDetalle()
								Exit Sub
							End If

						Next
					End If
					If CDbl(TxtDiferencia.Text) >= -0.02 And CDbl(TxtDiferencia.Text) < 0 Then

						For i As Integer = 0 To TablaAsiento.Rows.Count - 1
							If CDbl(TablaAsiento.Rows(i).Item("Haber")) > 0 Then
								TablaAsiento.Rows(i).Item("Haber") = CDbl(TablaAsiento.Rows(i).Item("Haber")) + Math.Abs(CDbl(TxtDiferencia.Text))
								AgregarDetalle()
								Exit Sub
							End If

						Next
					End If
				End If

			End If
		Catch ex As Exception

		End Try
	End Sub

	Private Function DetallesVerificado() As Boolean
		DetallesVerificado = False
		If Me.TxtNumCuenta.Text <> "" And Me.TxtMonto.Text <> "" Then
			DetallesVerificado = True
		End If
	End Function

	Private Sub AgregarDetalle()
		Try

			Me.ButNuevoDetalle.Text = "Nuevo Detalle"
			Me.ButNuevoDetalle.ImageIndex = "2"
			If RadDebe.Checked = True Then
				Me.TxtTotalDebe.Text = Format(TxtMonto.Text, "#,#0.00")
			Else
				TxtTotalDebe.Text = Format(0, "#,#0.00")
			End If

			If RadHaber.Checked = True Then
				Me.TxtTotalHaber.Text = Format(TxtMonto.Text, "#,#0.00")
			Else
				TxtTotalHaber.Text = Format(0, "#,#0.00")
			End If

			CalculaDiferencia()
			Me.TxtDiferencia.Text = Format(Me.TxtTotalHaber.Text - Me.TxtTotalDebe.Text, "#,#0.00")
			Me.txtDif2.Text = Format(Me.TxtTotalHaber2.Text - Me.TxtTotalDebe2.Text, "#,#0.00")
			If Me.TxtDiferencia.Text = "0.00" And Me.txtDif2.Text = "0.00" Then Me.TxtEstado.Text = "BALANCEADO" Else Me.TxtEstado.Text = "NO BALANCEADO"
			spCarlcularDirefenciaPorTipoCambio()
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Dim id As Integer = -1

	Private Sub CargarDatos()
		dr = Me.TablaAsiento.NewRow
		dr("ID_Detalle") = id
		dr("Cuenta") = TxtNumCuenta.Text
		dr("Descripcion") = TxtDescAsiento.Text
		dr("NombreCuenta") = LblDescCuenta.Text
		dr("Tipocambio") = Me.TextBoxTipoCambio.Text
		dr("NoDocumentoDetalle") = Me.txtNoDocumentoDetalle.Text
		If RadDebe.Checked Then
			If Me.CBMoneda.SelectedValue = 1 Then
				dr("Debe") = TxtMonto.Text
				dr("Haber") = 0
				If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
					dr("Debe$") = 0
				Else
					dr("Debe$") = Math.Round(TxtMonto.Text / CDbl(Me.TextBoxTipoCambio.Text), 2)
				End If
				dr("Haber$") = 0
			Else
				If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
					dr("Debe") = 0
				Else
					dr("Debe") = Math.Round(CDbl(TxtMonto.Text) * CDbl(Me.TextBoxTipoCambio.Text), 2)
				End If

				dr("Haber") = 0
				dr("Debe$") = CDbl(TxtMonto.Text)
				dr("Haber$") = 0
			End If

		Else
			If Me.CBMoneda.SelectedValue = 1 Then
				dr("Debe") = 0
				dr("Haber") = TxtMonto.Text
				dr("Debe$") = 0
				If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
					dr("Haber$") = 0
				Else
					dr("Haber$") = Math.Round(TxtMonto.Text / CDbl(Me.TextBoxTipoCambio.Text), 2)
				End If

			Else
				dr("Debe") = 0
				If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
					dr("Haber") = 0
				Else
					dr("Haber") = Math.Round(CDbl(TxtMonto.Text) * CDbl(Me.TextBoxTipoCambio.Text), 2)
				End If
				dr("Debe$") = 0
				dr("Haber$") = CDbl(TxtMonto.Text)
			End If

		End If
		TablaAsiento.Rows.Add(dr)
		id = id - 1

	End Sub
#End Region

#Region "Editar Detalle"
	Dim editaAutomaticos As Boolean = False
	Sub EditarDetalle()
		'Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
		'PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

		Dim Consecutivo As Integer
		Try

			If (Not editaAutomaticos) And Me.BindingContext(DataSetAsientos1, "AsientosContables").Current("Accion") = "AUT" Then

				'Me.BindingContext(DataSetAsientos1, "AsientosContables").Current("Accion") = "MOD"
				MsgBox("No se puede modificar el asiento contable!" & vbCrLf & "Porque fue creado automaticamente por el sistema", MsgBoxStyle.Information, "Sistema SeeSoft")
				Exit Sub
			Else
				Me.BindingContext(DataSetAsientos1, "AsientosContables").Current("Accion") = "MOD"

			End If
			If CheckBox2.CheckState = CheckState.Unchecked Then
				ActivarDetalles()
				If SimpleButton1.Text = "Editar" Then
					SimpleButton1.Text = "Actualizar"
					Me.btnVerCentroC.Enabled = True
					SimpleButton1.ImageIndex = "2"
					Me.ButAgregarDetalle.Enabled = False
					ActivarDetalle(True)
				Else
					Me.ButAgregarDetalle.Enabled = False
					SimpleButton1.Text = "Editar"
					Me.btnVerCentroC.Enabled = False
					SimpleButton1.ImageIndex = "9"
					Actualiza()
					SimpleButton1.Enabled = False
					butEliminarDetalle.Enabled = False
					CalculaDiferencia()
					Me.TxtDiferencia.Text = Format(Me.TxtTotalHaber.Text - Me.TxtTotalDebe.Text, "#,#0.00")
					Me.txtDif2.Text = Format(Me.TxtTotalHaber2.Text - Me.TxtTotalDebe2.Text, "#,#0.00")
					If Me.TxtDiferencia.Text = "0.00" And Me.txtDif2.Text = "0.00" Then Me.TxtEstado.Text = "BALANCEADO" Else Me.TxtEstado.Text = "NO BALANCEADO"
					ActivarDetalle(False)
					Me.LimpiarDetalles()
				End If
				salvarTemporal()
			Else
				MsgBox("No es Posible Editar Esta Linea ya que esta Mayorizado", MsgBoxStyle.Information)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
	Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
		Me.EditarDetalle()
	End Sub


	Private Sub Actualiza()
		Try
			TablaAsiento.Rows(a).Item("Cuenta") = TxtNumCuenta.Text
			TablaAsiento.Rows(a).Item("NombreCuenta") = LblDescCuenta.Text
			TablaAsiento.Rows(a).Item("Descripcion") = TxtDescAsiento.Text
			TablaAsiento.Rows(a).Item("Tipocambio") = Me.TextBoxTipoCambio.Text
			If RadDebe.Checked Then
				If Me.CBMoneda.SelectedValue = 1 Then
					TablaAsiento.Rows(a).Item("Debe") = TxtMonto.Text
					If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
						TablaAsiento.Rows(a).Item("Debe$") = 0
					Else
						TablaAsiento.Rows(a).Item("Debe$") = Format(TxtMonto.Text / TextBoxTipoCambio.Text, "#,#0.00")
					End If
					TablaAsiento.Rows(a).Item("Haber") = 0
					TablaAsiento.Rows(a).Item("Haber$") = 0
				Else
					TablaAsiento.Rows(a).Item("Debe$") = TxtMonto.Text
					If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
						TablaAsiento.Rows(a).Item("Debe") = 0
					Else
						TablaAsiento.Rows(a).Item("Debe") = Format(TxtMonto.Text * TextBoxTipoCambio.Text, "#,#0.00")
					End If
					TablaAsiento.Rows(a).Item("Haber") = 0
					TablaAsiento.Rows(a).Item("Haber$") = 0
				End If

			Else
				If Me.CBMoneda.SelectedValue = 1 Then
					TablaAsiento.Rows(a).Item("Debe") = 0
					TablaAsiento.Rows(a).Item("Debe$") = 0
					TablaAsiento.Rows(a).Item("Haber") = TxtMonto.Text
					If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
						TablaAsiento.Rows(a).Item("Haber$") = 0
					Else
						TablaAsiento.Rows(a).Item("Haber$") = Format(TxtMonto.Text / TextBoxTipoCambio.Text, "#,#0.00")
					End If
				Else
					TablaAsiento.Rows(a).Item("Debe") = 0
					TablaAsiento.Rows(a).Item("Debe$") = 0
					TablaAsiento.Rows(a).Item("Haber$") = TxtMonto.Text
					If CDbl(Me.TextBoxTipoCambio.Text) = 0 Then
						TablaAsiento.Rows(a).Item("Haber") = 0
					Else
						TablaAsiento.Rows(a).Item("Haber") = Format(TxtMonto.Text * TextBoxTipoCambio.Text, "#,#0.00")
					End If
				End If
			End If

			CalculaDiferencia()
			spCarlcularDirefenciaPorTipoCambio()
		Catch ex As Exception
			MsgBox(ex.ToString)

		End Try
	End Sub
#End Region

#Region "Elimina Detalle"
	Private Sub butEliminarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEliminarDetalle.Click
		If Me.BindingContext(DataSetAsientos1, "AsientosContables").Current("Accion") = "AUT" And Not editaAutomaticos Then
			MsgBox("No se puede modificar el asiento contable!" & vbCrLf & "Porque fue creado automaticamente por el sistema", MsgBoxStyle.Information, "Sistema SeeSoft")
			Exit Sub
		End If
		If MessageBox.Show(" ¿ Eliminar la cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub

		Try
			If CheckBox2.CheckState = CheckState.Unchecked Then

				Try
					TablaAsiento.Rows(a).Delete()
					salvarTemporal()
				Catch ex As Exception
					MsgBox(ex.ToString)

				End Try
				SimpleButton1.Enabled = False
				butEliminarDetalle.Enabled = False
				CalculaDiferencia()
				Me.TxtDiferencia.Text = Format(Me.TxtTotalHaber.Text - Me.TxtTotalDebe.Text, "#,#0.00")
				Me.txtDif2.Text = Format(Me.TxtTotalHaber2.Text - Me.TxtTotalDebe2.Text, "#,#0.00")
				If Me.TxtDiferencia.Text = "0.00" And Me.txtDif2.Text = "0.00" Then Me.TxtEstado.Text = "BALANCEADO" Else Me.TxtEstado.Text = "NO BALANCEADO"
				Me.LimpiarDetalles()
			Else
				MsgBox("No es Posible eliminar Esta Linea ya que esta Mayorizado", MsgBoxStyle.Information)
			End If
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub
#End Region

#Region "Funciones"
	Private Sub CalculaDiferencia()
		Dim i As Integer
		Dim Debe, Debe2, Haber, Haber2 As Double
		Try
			For i = 0 To TablaAsiento.Rows.Count - 1
				If TablaAsiento.Rows(i).Item("Debe") > 0 Or TablaAsiento.Rows(i).Item("Debe$") > 0 Then
					Debe = Debe + TablaAsiento.Rows(i).Item("Debe")
					Debe2 = Debe2 + TablaAsiento.Rows(i).Item("Debe$")
				Else
					Haber = Haber + TablaAsiento.Rows(i).Item("Haber")
					Haber2 = Haber2 + TablaAsiento.Rows(i).Item("Haber$")
				End If
			Next

			Me.TxtTotalDebe.Text = Format(Debe, "#,#0.00")
			Me.TxtTotalHaber.Text = Format(Haber, "#,#0.00")
			Me.TxtTotalDebe2.Text = Format(Debe2, "#,#0.00")
			Me.TxtTotalHaber2.Text = Format(Haber2, "#,#0.00")

		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub


	Private Sub NumeroAsiento()
		Try
			Dim Fx As New cFunciones
			LblConsecutivo.Text = Fx.BuscaNumeroAsiento("CON-" & Format(DPTrans.Value.Month, "00") & Format(DPTrans.Value.Date, "yy") & "-")
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub


	Public Function Conectando() As SqlConnection
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

	Private Sub TextBoxTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxTipoCambio.KeyDown
		If e.KeyCode = Keys.Enter Then
			Dim variable As Double
			Try
				variable = TxtMonto.Text
				Me.ButAgregarDetalle.Focus()
				'  TxtMonto.Text = Format(variable, "#,#0.00")
			Catch ex As Exception
				MessageBox.Show("Verifique el formato del monto del asiento", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
			End Try
		End If
	End Sub

	Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
		Me.ToolBar1.Buttons(5).Text = IIf(Me.CheckBox2.Checked = True, "Mayorizar", "DesMayorizar")
	End Sub

	Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
		Dim frm As New frmCentroCostoBus

		If frm.ShowDialog = DialogResult.OK Then
			BindingContext(DataSetAsientos1, "DetallesAsientosContable").EndCurrentEdit()

			BindingContext(DataSetAsientos1, "Centro").AddNew()
			BindingContext(DataSetAsientos1, "Centro").Current("Codigo") = frm.txtCodigo.Text
			BindingContext(DataSetAsientos1, "Centro").Current("IdCentro") = frm.txtID.Text
			BindingContext(DataSetAsientos1, "Centro").Current("Nombre") = frm.txtCentro.Text
			BindingContext(DataSetAsientos1, "Centro").Current("Monto") = txtMontoCentro.Text
			BindingContext(DataSetAsientos1, "Centro").Current("Cuenta") = TxtNumCuenta.Text
			BindingContext(DataSetAsientos1, "Centro").Current("NombreC") = LblDescCuenta.Text
			BindingContext(DataSetAsientos1, "Centro").Current("Observacion") = TxtObservaciones.Text
			BindingContext(DataSetAsientos1, "Centro").Current("IdDetalle") = Id_Temp
			BindingContext(DataSetAsientos1, "Centro").EndCurrentEdit()

		End If
	End Sub
	Dim IDCentroCosto As Integer = 0

	Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
		BindingContext(DataSetAsientos1, "Centro").RemoveAt(BindingContext(DataSetAsientos1, "Centro").Position)
		BindingContext(DataSetAsientos1, "Centro").EndCurrentEdit()
	End Sub

	Private Sub btnVerCentroC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerCentroC.Click

		Me.GroupBox1.Visible = Not Me.GroupBox1.Visible
		Me.txtDescripción.Text = Me.TxtDescAsiento.Text
		Me.txtMontoCentro.Text = Me.TxtMonto.Text

		Me.DataSetAsientos1.Centro.Clear()


		For i As Integer = 0 To DataSetAsientos1.CentroCosto_Movimientos.Count - 1
			If Id_Temp = Me.DataSetAsientos1.CentroCosto_Movimientos(i).IdDetalle Then

				Me.BindingContext(Me.DataSetAsientos1, "Centro").AddNew()
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("Codigo") = ""
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("IdCentro") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).IdCentroCosto
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("Nombre") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).Nombre
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("Monto") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).Monto
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("Cuenta") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).CuentaContable
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("NombreC") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).NombreCuentaContable
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("IdDetalle") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).IdDetalle
				Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("Observacion") = Me.DataSetAsientos1.CentroCosto_Movimientos(i).Descripcion
				Me.BindingContext(Me.DataSetAsientos1, "Centro").EndCurrentEdit()

			End If
		Next
		If Me.GroupBox1.Visible Then
			Me.btnVerCentroC.BackColor = Color.Yellow
		Else
			Me.btnVerCentroC.BackColor = Color.Transparent

		End If
	End Sub

	Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
		Me.GroupBox1.Visible = Not Me.GroupBox1.Visible
		For i As Int16 = 0 To Me.DataSetAsientos1.CentroCosto_Movimientos.Count - 1
			If i >= Me.DataSetAsientos1.CentroCosto_Movimientos.Count Or i < 0 Then
				Exit For
			End If
			If Me.DataSetAsientos1.CentroCosto_Movimientos(i).IdDetalle = Me.Id_Temp Then
				Me.DataSetAsientos1.CentroCosto_Movimientos.RemoveCentroCosto_MovimientosRow(DataSetAsientos1.CentroCosto_Movimientos(i))
				Me.DataSetAsientos1.CentroCosto_Movimientos.EndInit()
				i = 0
			End If
		Next

		For i As Integer = 0 To Me.DataSetAsientos1.Centro.Count - 1
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").AddNew()
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("IdAsiento") = LblConsecutivo.Text
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Documento") = TxtDocumento.Text
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Fecha") = Now
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("IdCentroCosto") = Me.BindingContext(Me.DataSetAsientos1, "Centro").Current("IdCentro")
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Monto") = Me.DataSetAsientos1.Centro(i).Monto
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Debe") = Me.RadDebe.Checked
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Haber") = Me.RadHaber.Checked
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Descripcion") = Me.DataSetAsientos1.Centro(i).Observacion
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("CuentaContable") = Me.DataSetAsientos1.Centro(i).Cuenta
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("NombreCuentaContable") = Me.DataSetAsientos1.Centro(i).NombreC
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Tipo") = 33
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("IdDetalle") = Me.DataSetAsientos1.Centro(i).IdDetalle
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").Current("Nombre") = Me.DataSetAsientos1.Centro(i).Nombre
			Me.BindingContext(Me.DataSetAsientos1, "CentroCosto_Movimientos").EndCurrentEdit()
		Next
		Me.DataSetAsientos1.Centro.Clear()

	End Sub

	Private Sub TxtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUsuario.TextChanged

	End Sub

	Private Sub FrmAsientos_Closed(sender As Object, e As EventArgs) Handles Me.Closed
		DialogResult = DialogResult.OK
	End Sub
End Class
