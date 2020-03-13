Imports System.data.SqlClient
Imports Utilidades

Public Class frmAjusteCuenta
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim editando As Integer
    Dim usua As Object
    Dim usuario As New Usuario_Logeado
    Dim a, cuenta As String
    Dim i As Integer
    Public id_ajuste As String
    Public cuentabancaria As String
    Dim FechaCon As DateTime
    Public desdeConciliacion As Boolean = False
    Public modificar As Boolean = False
    Public nuevoMonto As Double = 0
    Public EditaAsiento As Boolean = False
    Dim Debe, Haber As Boolean
    Dim Trans As SqlTransaction
    Dim Trans2 As SqlTransaction
    Dim Conta As Integer
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'usua = Usuario_Parametro
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
    Friend WithEvents dgDeposito As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumerodeposito As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rbDebito As System.Windows.Forms.RadioButton
    Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents colDescripcion_Mov As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuentaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents TxtCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SimpleNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleEliminar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Anular As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents CalcEdit1 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents CalcEdit2 As DevExpress.XtraEditors.CalcEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daAjusteBancario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daAjusteDetalleBancario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daCuentaContable As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents daUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsAjusteBancario As dsAjusteBancario
    Friend WithEvents daCuentaBancaria As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents balanceo As System.Windows.Forms.Label
    Friend WithEvents ToolBarEditar As System.Windows.Forms.ToolBarButton
    Friend WithEvents daMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents btnCentroCosto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelCentroCosto As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCentroCosto As System.Windows.Forms.TextBox
    Friend WithEvents BNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents BotonCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCentroCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents ButtonAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditDescripcionCC As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCentroCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents adpCuentaMov As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdpCC As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAjusteCuenta))
        Me.dgDeposito = New DevExpress.XtraGrid.GridControl
        Me.DsAjusteBancario = New Contabilidad.dsAjusteBancario
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colDescripcion_Mov = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuentaContable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Anular = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PanelCentroCosto = New System.Windows.Forms.Panel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCentroCosto = New System.Windows.Forms.TextBox
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
        Me.txtMontoCentroCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtNumConciliacion = New System.Windows.Forms.Label
        Me.ckConciliado = New System.Windows.Forms.CheckBox
        Me.balanceo = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CalcEdit2 = New DevExpress.XtraEditors.CalcEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnCentroCosto = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleEliminar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtCuenta = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.CalcEdit1 = New DevExpress.XtraEditors.CalcEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.rbCredito = New System.Windows.Forms.RadioButton
        Me.rbDebito = New System.Windows.Forms.RadioButton
        Me.txtNumerodeposito = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboCuenta = New System.Windows.Forms.ComboBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.TxtCodUsuario = New System.Windows.Forms.TextBox
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.daAjusteBancario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.daAjusteDetalleBancario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.daCuentaContable = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.daUsuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.daCuentaBancaria = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.ToolBarEditar = New System.Windows.Forms.ToolBarButton
        Me.daMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
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
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.adpCuentaMov = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdpCC = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        CType(Me.dgDeposito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAjusteBancario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.PanelCentroCosto.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditDescripcionCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgDeposito
        '
        Me.dgDeposito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgDeposito.DataMember = "AjusteBancario.AjusteBancarioAjusteBancario_Detalle"
        Me.dgDeposito.DataSource = Me.DsAjusteBancario
        '
        '
        '
        Me.dgDeposito.EmbeddedNavigator.Name = ""
        Me.dgDeposito.Location = New System.Drawing.Point(8, 120)
        Me.dgDeposito.MainView = Me.GridView1
        Me.dgDeposito.Name = "dgDeposito"
        Me.dgDeposito.Size = New System.Drawing.Size(600, 200)
        Me.dgDeposito.TabIndex = 50
        '
        'DsAjusteBancario
        '
        Me.DsAjusteBancario.DataSetName = "dsAjusteBancario"
        Me.DsAjusteBancario.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DsAjusteBancario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDescripcion_Mov, Me.GridColumn1, Me.colCuentaContable, Me.colMonto})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colDescripcion_Mov
        '
        Me.colDescripcion_Mov.Caption = "Descripción"
        Me.colDescripcion_Mov.FieldName = "Descripcion_Mov"
        Me.colDescripcion_Mov.FilterInfo = ColumnFilterInfo1
        Me.colDescripcion_Mov.Name = "colDescripcion_Mov"
        Me.colDescripcion_Mov.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion_Mov.VisibleIndex = 2
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cta Nombre"
        Me.GridColumn1.FieldName = "NombreCuenta"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo2
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 1
        '
        'colCuentaContable
        '
        Me.colCuentaContable.Caption = "# Cta Contable"
        Me.colCuentaContable.FieldName = "CuentaContable"
        Me.colCuentaContable.FilterInfo = ColumnFilterInfo3
        Me.colCuentaContable.Name = "colCuentaContable"
        Me.colCuentaContable.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCuentaContable.VisibleIndex = 0
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo4
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.colMonto.VisibleIndex = 3
        '
        'Anular
        '
        Me.Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anular.ForeColor = System.Drawing.Color.Red
        Me.Anular.Location = New System.Drawing.Point(112, 112)
        Me.Anular.Name = "Anular"
        Me.Anular.Size = New System.Drawing.Size(320, 96)
        Me.Anular.TabIndex = 50
        Me.Anular.Text = "Anulado"
        Me.Anular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Anular.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.PanelCentroCosto)
        Me.GroupBox4.Controls.Add(Me.txtNumConciliacion)
        Me.GroupBox4.Controls.Add(Me.ckConciliado)
        Me.GroupBox4.Controls.Add(Me.balanceo)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Anular)
        Me.GroupBox4.Controls.Add(Me.CalcEdit2)
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtDescripcion)
        Me.GroupBox4.Controls.Add(Me.dgDeposito)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 349)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle  Depósito"
        '
        'PanelCentroCosto
        '
        Me.PanelCentroCosto.BackColor = System.Drawing.Color.White
        Me.PanelCentroCosto.Controls.Add(Me.GroupBox2)
        Me.PanelCentroCosto.Controls.Add(Me.Label22)
        Me.PanelCentroCosto.Location = New System.Drawing.Point(-400, 8)
        Me.PanelCentroCosto.Name = "PanelCentroCosto"
        Me.PanelCentroCosto.Size = New System.Drawing.Size(370, 219)
        Me.PanelCentroCosto.TabIndex = 208
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtCentroCosto)
        Me.GroupBox2.Controls.Add(Me.BNuevo)
        Me.GroupBox2.Controls.Add(Me.TxtDetalle)
        Me.GroupBox2.Controls.Add(Me.BotonCerrar)
        Me.GroupBox2.Controls.Add(Me.GridCentroCosto)
        Me.GroupBox2.Controls.Add(Me.ButtonAgregarDetalle)
        Me.GroupBox2.Controls.Add(Me.EditDescripcionCC)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtMontoCentroCosto)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Location = New System.Drawing.Point(4, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(356, 200)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'txtCentroCosto
        '
        Me.txtCentroCosto.Location = New System.Drawing.Point(120, 16)
        Me.txtCentroCosto.Name = "txtCentroCosto"
        Me.txtCentroCosto.ReadOnly = True
        Me.txtCentroCosto.Size = New System.Drawing.Size(216, 20)
        Me.txtCentroCosto.TabIndex = 205
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
        Me.GridCentroCosto.DataMember = "CentroCostoDetalle"
        Me.GridCentroCosto.DataSource = Me.DsAjusteBancario
        '
        '
        '
        Me.GridCentroCosto.EmbeddedNavigator.Name = ""
        Me.GridCentroCosto.Location = New System.Drawing.Point(8, 112)
        Me.GridCentroCosto.MainView = Me.GridView2
        Me.GridCentroCosto.Name = "GridCentroCosto"
        Me.GridCentroCosto.Size = New System.Drawing.Size(344, 80)
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
        Me.GridColumn9.FilterInfo = ColumnFilterInfo5
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
        Me.GridColumn11.FilterInfo = ColumnFilterInfo6
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 112
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Descripción"
        Me.GridColumn15.FieldName = "Descripcion"
        Me.GridColumn15.FilterInfo = ColumnFilterInfo7
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
        Me.EditDescripcionCC.Location = New System.Drawing.Point(120, 56)
        Me.EditDescripcionCC.Name = "EditDescripcionCC"
        '
        '
        '
        Me.EditDescripcionCC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditDescripcionCC.Properties.Enabled = False
        Me.EditDescripcionCC.Properties.ShowIcon = False
        Me.EditDescripcionCC.Properties.ShowPopupShadow = False
        Me.EditDescripcionCC.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
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
        'txtMontoCentroCosto
        '
        Me.txtMontoCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteBancario, "CentroCosto_Movimientos.Monto", True))
        Me.txtMontoCentroCosto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoCentroCosto.Location = New System.Drawing.Point(8, 56)
        Me.txtMontoCentroCosto.Name = "txtMontoCentroCosto"
        '
        '
        '
        Me.txtMontoCentroCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCentroCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCentroCosto.Properties.Enabled = False
        Me.txtMontoCentroCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
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
        'txtNumConciliacion
        '
        Me.txtNumConciliacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtNumConciliacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.Num_Conciliacion", True))
        Me.txtNumConciliacion.Enabled = False
        Me.txtNumConciliacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumConciliacion.Location = New System.Drawing.Point(96, 328)
        Me.txtNumConciliacion.Name = "txtNumConciliacion"
        Me.txtNumConciliacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumConciliacion.Size = New System.Drawing.Size(32, 16)
        Me.txtNumConciliacion.TabIndex = 207
        '
        'ckConciliado
        '
        Me.ckConciliado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckConciliado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteBancario, "AjusteBancario.Conciliacion", True))
        Me.ckConciliado.Enabled = False
        Me.ckConciliado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConciliado.Location = New System.Drawing.Point(8, 328)
        Me.ckConciliado.Name = "ckConciliado"
        Me.ckConciliado.Size = New System.Drawing.Size(88, 16)
        Me.ckConciliado.TabIndex = 206
        Me.ckConciliado.Text = "Conciliado"
        '
        'balanceo
        '
        Me.balanceo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.balanceo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceo.Location = New System.Drawing.Point(256, 320)
        Me.balanceo.Name = "balanceo"
        Me.balanceo.Size = New System.Drawing.Size(100, 16)
        Me.balanceo.TabIndex = 205
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(464, 320)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 204
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(408, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 16)
        Me.Label9.TabIndex = 203
        Me.Label9.Text = "Dif.:"
        '
        'CalcEdit2
        '
        Me.CalcEdit2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle.Monto", True))
        Me.CalcEdit2.Location = New System.Drawing.Point(464, 40)
        Me.CalcEdit2.Name = "CalcEdit2"
        '
        '
        '
        Me.CalcEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.CalcEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CalcEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CalcEdit2.Size = New System.Drawing.Size(144, 21)
        Me.CalcEdit2.TabIndex = 178
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCentroCosto)
        Me.Panel1.Controls.Add(Me.SimpleNuevo)
        Me.Panel1.Controls.Add(Me.SimpleGuardar)
        Me.Panel1.Controls.Add(Me.SimpleEliminar)
        Me.Panel1.Location = New System.Drawing.Point(8, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(240, 48)
        Me.Panel1.TabIndex = 68
        '
        'btnCentroCosto
        '
        Me.btnCentroCosto.Location = New System.Drawing.Point(80, 0)
        Me.btnCentroCosto.Name = "btnCentroCosto"
        Me.btnCentroCosto.Size = New System.Drawing.Size(152, 23)
        Me.btnCentroCosto.TabIndex = 67
        Me.btnCentroCosto.Text = "Centro Costo"
        '
        'SimpleNuevo
        '
        Me.SimpleNuevo.Location = New System.Drawing.Point(0, 24)
        Me.SimpleNuevo.Name = "SimpleNuevo"
        Me.SimpleNuevo.Size = New System.Drawing.Size(75, 23)
        Me.SimpleNuevo.TabIndex = 65
        Me.SimpleNuevo.Text = "Nuevo"
        '
        'SimpleGuardar
        '
        Me.SimpleGuardar.Location = New System.Drawing.Point(80, 24)
        Me.SimpleGuardar.Name = "SimpleGuardar"
        Me.SimpleGuardar.Size = New System.Drawing.Size(75, 23)
        Me.SimpleGuardar.TabIndex = 64
        Me.SimpleGuardar.Text = "Guardar"
        '
        'SimpleEliminar
        '
        Me.SimpleEliminar.Location = New System.Drawing.Point(160, 24)
        Me.SimpleEliminar.Name = "SimpleEliminar"
        Me.SimpleEliminar.Size = New System.Drawing.Size(72, 23)
        Me.SimpleEliminar.TabIndex = 66
        Me.SimpleEliminar.Text = "Eliminar"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.Label19)
        Me.GroupBox5.Controls.Add(Me.TxtCuenta)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(280, 64)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(328, 56)
        Me.GroupBox5.TabIndex = 51
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contabilidad"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle.NombreCuenta", True))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(120, 32)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(200, 20)
        Me.Label19.TabIndex = 165
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCuenta
        '
        Me.TxtCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCuenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle.CuentaContable", True))
        Me.TxtCuenta.Location = New System.Drawing.Point(8, 32)
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(112, 20)
        Me.TxtCuenta.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(8, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(312, 16)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Cuenta Contable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(464, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Monto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(448, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Descripción General"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle.Descripcion_Mov", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(8, 40)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(448, 20)
        Me.txtDescripcion.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(128, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(480, 16)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = "Observaciones"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.Concepto", True))
        Me.txtObservaciones.Location = New System.Drawing.Point(128, 120)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(480, 20)
        Me.txtObservaciones.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtTipoCambio)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextEdit1)
        Me.GroupBox1.Controls.Add(Me.CalcEdit1)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.rbCredito)
        Me.GroupBox1.Controls.Add(Me.rbDebito)
        Me.GroupBox1.Controls.Add(Me.txtNumerodeposito)
        Me.GroupBox1.Controls.Add(Me.txtObservaciones)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboCuenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Depósito"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteBancario, "AjusteBancario.TipoCambio", True))
        Me.txtTipoCambio.EditValue = ""
        Me.txtTipoCambio.Location = New System.Drawing.Point(376, 80)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        '
        '
        '
        Me.txtTipoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTipoCambio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTipoCambio.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtTipoCambio.Size = New System.Drawing.Size(80, 21)
        Me.txtTipoCambio.TabIndex = 181
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(376, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 179
        Me.Label13.Text = "Tipo Cambio"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit1
        '
        Me.TextEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteBancario, "Cuentas_bancarias.Saldo", True))
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(464, 80)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Enabled = False
        Me.TextEdit1.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextEdit1.Size = New System.Drawing.Size(144, 21)
        Me.TextEdit1.TabIndex = 178
        '
        'CalcEdit1
        '
        Me.CalcEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CalcEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DsAjusteBancario, "AjusteBancario.Monto", True))
        Me.CalcEdit1.Location = New System.Drawing.Point(472, 32)
        Me.CalcEdit1.Name = "CalcEdit1"
        '
        '
        '
        Me.CalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.CalcEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.CalcEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.CalcEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CalcEdit1.Size = New System.Drawing.Size(136, 21)
        Me.CalcEdit1.TabIndex = 177
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 176
        Me.Label11.Text = "Tipo"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Location = New System.Drawing.Point(288, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 20)
        Me.Label16.TabIndex = 175
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(288, 64)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 16)
        Me.Label18.TabIndex = 174
        Me.Label18.Text = "Moneda"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Location = New System.Drawing.Point(8, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(272, 20)
        Me.Label14.TabIndex = 173
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(8, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(272, 16)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "Banco"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(464, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 16)
        Me.Label4.TabIndex = 170
        Me.Label4.Text = "Saldo Cuenta"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbCredito
        '
        Me.rbCredito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteBancario, "AjusteBancario.Credito", True))
        Me.rbCredito.Location = New System.Drawing.Point(64, 120)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(64, 16)
        Me.rbCredito.TabIndex = 6
        Me.rbCredito.Text = "Crédito"
        '
        'rbDebito
        '
        Me.rbDebito.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsAjusteBancario, "AjusteBancario.Debito", True))
        Me.rbDebito.Location = New System.Drawing.Point(8, 120)
        Me.rbDebito.Name = "rbDebito"
        Me.rbDebito.Size = New System.Drawing.Size(56, 16)
        Me.rbDebito.TabIndex = 5
        Me.rbDebito.Text = "Débito"
        '
        'txtNumerodeposito
        '
        Me.txtNumerodeposito.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumerodeposito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.Num_Ajuste", True))
        Me.txtNumerodeposito.Location = New System.Drawing.Point(368, 32)
        Me.txtNumerodeposito.Name = "txtNumerodeposito"
        Me.txtNumerodeposito.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumerodeposito.Size = New System.Drawing.Size(96, 20)
        Me.txtNumerodeposito.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "AjusteBancario.Fecha", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(256, 32)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(104, 20)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(472, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Monto"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(256, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Fecha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(368, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Número Ajuste"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 16)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Número Cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cboCuenta
        '
        Me.cboCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCuenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsAjusteBancario, "AjusteBancario.Id_CuentaBancaria", True))
        Me.cboCuenta.DataSource = Me.DsAjusteBancario
        Me.cboCuenta.DisplayMember = "Cuentas_bancarias.Cuenta"
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.Location = New System.Drawing.Point(8, 32)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(240, 21)
        Me.cboCuenta.TabIndex = 2
        Me.cboCuenta.ValueMember = "Cuentas_bancarias.Id_CuentaBancaria"
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(368, 552)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 196
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodUsuario
        '
        Me.TxtCodUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodUsuario.Location = New System.Drawing.Point(440, 552)
        Me.TxtCodUsuario.Name = "TxtCodUsuario"
        Me.TxtCodUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtCodUsuario.Size = New System.Drawing.Size(56, 13)
        Me.TxtCodUsuario.TabIndex = 194
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(496, 552)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.ReadOnly = True
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(112, 13)
        Me.TxtNombreUsuario.TabIndex = 195
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
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Bancos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'daAjusteBancario
        '
        Me.daAjusteBancario.DeleteCommand = Me.SqlDeleteCommand1
        Me.daAjusteBancario.InsertCommand = Me.SqlInsertCommand1
        Me.daAjusteBancario.SelectCommand = Me.SqlSelectCommand1
        Me.daAjusteBancario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AjusteBancario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Ajuste", "Id_Ajuste"), New System.Data.Common.DataColumnMapping("Num_Ajuste", "Num_Ajuste"), New System.Data.Common.DataColumnMapping("Numero_Docum", "Numero_Docum"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Concepto", "Concepto"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Conciliacion", "Conciliacion"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Credito", "Credito"), New System.Data.Common.DataColumnMapping("Debito", "Debito"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("CodigoMoneda", "CodigoMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.daAjusteBancario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Conciliacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero_Docum", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Docum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Ajuste", System.Data.SqlDbType.BigInt, 8, "Num_Ajuste"), New System.Data.SqlClient.SqlParameter("@Numero_Docum", System.Data.SqlDbType.BigInt, 8, "Numero_Docum"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 250, "Concepto"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Conciliacion", System.Data.SqlDbType.Bit, 1, "Conciliacion"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"), New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"), New System.Data.SqlClient.SqlParameter("@Debito", System.Data.SqlDbType.Bit, 1, "Debito"), New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Ajuste", System.Data.SqlDbType.BigInt, 8, "Num_Ajuste"), New System.Data.SqlClient.SqlParameter("@Numero_Docum", System.Data.SqlDbType.BigInt, 8, "Numero_Docum"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Concepto", System.Data.SqlDbType.VarChar, 250, "Concepto"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Conciliacion", System.Data.SqlDbType.Bit, 1, "Conciliacion"), New System.Data.SqlClient.SqlParameter("@Contabilizado", System.Data.SqlDbType.Bit, 1, "Contabilizado"), New System.Data.SqlClient.SqlParameter("@Asiento", System.Data.SqlDbType.VarChar, 15, "Asiento"), New System.Data.SqlClient.SqlParameter("@Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, "Id_CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Credito", System.Data.SqlDbType.Bit, 1, "Credito"), New System.Data.SqlClient.SqlParameter("@Debito", System.Data.SqlDbType.Bit, 1, "Debito"), New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"), New System.Data.SqlClient.SqlParameter("@Ced_Usuario", System.Data.SqlDbType.VarChar, 75, "Ced_Usuario"), New System.Data.SqlClient.SqlParameter("@CodigoMoneda", System.Data.SqlDbType.Int, 4, "CodigoMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_Id_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Ced_Usuario", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Ced_Usuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodigoMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodigoMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Concepto", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Concepto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Conciliacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Contabilizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Contabilizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Credito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Credito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debito", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CuentaBancaria", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Numero_Docum", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Numero_Docum", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Ajuste", System.Data.SqlDbType.BigInt, 8, "Id_Ajuste")})
        '
        'daAjusteDetalleBancario
        '
        Me.daAjusteDetalleBancario.DeleteCommand = Me.SqlDeleteCommand2
        Me.daAjusteDetalleBancario.InsertCommand = Me.SqlInsertCommand2
        Me.daAjusteDetalleBancario.SelectCommand = Me.SqlSelectCommand2
        Me.daAjusteDetalleBancario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AjusteBancario_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_AjusteDet", "Id_AjusteDet"), New System.Data.Common.DataColumnMapping("Id_Ajuste", "Id_Ajuste"), New System.Data.Common.DataColumnMapping("Descripcion_Mov", "Descripcion_Mov"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta")})})
        Me.daAjusteDetalleBancario.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_AjusteDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjusteDet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion_Mov", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Ajuste", System.Data.SqlDbType.BigInt, 8, "Id_Ajuste"), New System.Data.SqlClient.SqlParameter("@Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, "Descripcion_Mov"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 350, "NombreCuenta")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id_AjusteDet, Id_Ajuste, Descripcion_Mov, CuentaContable, Monto, NombreCue" & _
            "nta FROM AjusteBancario_Detalle"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_Ajuste", System.Data.SqlDbType.BigInt, 8, "Id_Ajuste"), New System.Data.SqlClient.SqlParameter("@Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, "Descripcion_Mov"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 350, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Original_Id_AjusteDet", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_AjusteDet", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion_Mov", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion_Mov", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Ajuste", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Ajuste", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 350, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_AjusteDet", System.Data.SqlDbType.BigInt, 8, "Id_AjusteDet")})
        '
        'daCuentaContable
        '
        Me.daCuentaContable.SelectCommand = Me.SqlSelectCommand4
        Me.daCuentaContable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, Des" & _
            "cCuentaMadre, PARENTID FROM CuentaContable"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'daUsuarios
        '
        Me.daUsuarios.SelectCommand = Me.SqlSelectCommand5
        Me.daUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Nombre, Clave_Entrada, Clave_Interna, Cedula FROM Usuarios"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'daCuentaBancaria
        '
        Me.daCuentaBancaria.SelectCommand = Me.SqlSelectCommand3
        Me.daCuentaBancaria.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = resources.GetString("SqlSelectCommand3.CommandText")
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.ImageIndex = 6
        Me.ToolBarEditar.Name = "ToolBarEditar"
        Me.ToolBarEditar.Text = "Cerrar"
        '
        'daMoneda
        '
        Me.daMoneda.InsertCommand = Me.SqlInsertCommand3
        Me.daMoneda.SelectCommand = Me.SqlSelectCommand6
        Me.daMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
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
        Me.TituloModulo.Size = New System.Drawing.Size(624, 32)
        Me.TituloModulo.TabIndex = 198
        Me.TituloModulo.Text = "Ajustes Bancarios"
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 518)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(624, 56)
        Me.ToolBar1.TabIndex = 199
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Name = "ToolBarNuevo"
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Name = "ToolBarBuscar"
        Me.ToolBarBuscar.Text = "Buscar"
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEditar2
        '
        Me.ToolBarEditar2.Enabled = False
        Me.ToolBarEditar2.ImageIndex = 9
        Me.ToolBarEditar2.Name = "ToolBarEditar2"
        Me.ToolBarEditar2.Text = "Editar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Name = "ToolBarRegistrar"
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Name = "ToolBarEliminar"
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Name = "ToolBarImprimir"
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Name = "ToolBarCerrar"
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdapterAsientos.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection3
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = resources.GetString("SqlSelectCommand8.CommandText")
        Me.SqlSelectCommand8.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterDetallesAsientos
        '
        Me.AdapterDetallesAsientos.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterDetallesAsientos.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterDetallesAsientos.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection3
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
            "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'adpCuentaMov
        '
        Me.adpCuentaMov.DeleteCommand = Me.SqlDeleteCommand5
        Me.adpCuentaMov.InsertCommand = Me.SqlInsertCommand6
        Me.adpCuentaMov.SelectCommand = Me.SqlSelectCommand9
        Me.adpCuentaMov.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto_Movimientos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAsiento", "IdAsiento"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdCentroCosto", "IdCentroCosto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("IdDetalle", "IdDetalle"), New System.Data.Common.DataColumnMapping("IdDetalleAux", "IdDetalleAux")})})
        Me.adpCuentaMov.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCentroCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCosto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdDetalleAux", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalleAux", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection3
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"), New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"), New System.Data.SqlClient.SqlParameter("@IdDetalleAux", System.Data.SqlDbType.BigInt, 8, "IdDetalleAux")})
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descri" & _
            "pcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle, IdDetalleAux FROM " & _
            "CentroCosto_Movimientos"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"), New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"), New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"), New System.Data.SqlClient.SqlParameter("@IdDetalleAux", System.Data.SqlDbType.BigInt, 8, "IdDetalleAux"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCentroCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCosto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdDetalleAux", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalleAux", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'AdpCC
        '
        Me.AdpCC.SelectCommand = Me.SqlSelectCommand10
        Me.AdpCC.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = "SELECT Id, Codigo, Nombre, Observaciones FROM CentroCosto"
        Me.SqlSelectCommand10.Connection = Me.SqlConnection3
        '
        'frmAjusteCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 574)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.TxtCodUsuario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(608, 520)
        Me.Name = "frmAjusteCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ajuste Cuenta"
        CType(Me.dgDeposito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAjusteBancario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.PanelCentroCosto.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditDescripcionCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
            If Me.BindingContext(Me.DsAjusteBancario.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DsAjusteBancario.Usuarios.Select("Cedula ='" & Me.usua.Cedula & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    TxtNombreUsuario.Text = Usua("Nombre")
                    Me.DsAjusteBancario.AjusteBancario.Ced_UsuarioColumn.DefaultValue = Usua("Cedula")
                    usuario.Cedula = Usua("Cedula")
                    usuario.Nombre = Usua("Nombre")
                    Me.ToolBarNuevo.Enabled = True
                    Me.ToolBarRegistrar.Enabled = False
                    Me.ToolBarBuscar.Enabled = True
                    Me.ToolBarEliminar.Enabled = False
                    If Me.desdeConciliacion Then
                        Me.ToolBarNuevo.Enabled = Not modificar
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

#Region "Load"
    Private Sub FrmCheques_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = GetSetting("Seesoft", "Bancos", "Conexion")
            SqlConnection3.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            InhabilitarChekes()
            TxtCodUsuario.Focus()
            Me.daUsuarios.Fill(Me.DsAjusteBancario.Usuarios)
            Me.daCuentaBancaria.Fill(Me.DsAjusteBancario.Cuentas_bancarias)
            Me.daMoneda.Fill(Me.DsAjusteBancario.Moneda)
            ValoresPorDefecto()

            'CHEQUES
            Me.DsAjusteBancario.AjusteBancario.Id_AjusteColumn.AutoIncrement = True
            Me.DsAjusteBancario.AjusteBancario.Id_AjusteColumn.AutoIncrementSeed = -1
            Me.DsAjusteBancario.AjusteBancario.Id_AjusteColumn.AutoIncrementStep = -1
            Me.DsAjusteBancario.AjusteBancario.CodigoMonedaColumn.DefaultValue = 1
            Me.DsAjusteBancario.AjusteBancario.TipoCambioColumn.DefaultValue = 1
            'CHEQUES DETALLES
            Me.DsAjusteBancario.AjusteBancario_Detalle.Id_AjusteDetColumn.AutoIncrement = True
            Me.DsAjusteBancario.AjusteBancario_Detalle.Id_AjusteDetColumn.AutoIncrementSeed = -1
            Me.DsAjusteBancario.AjusteBancario_Detalle.Id_AjusteDetColumn.AutoIncrementStep = -1
            Me.Loggin_Usuario()

            'If Me.desdeConciliacion Then
            If Me.modificar Then
                Me.cargarAjuste(Me.id_ajuste, Me.cuentabancaria)
                Me.ToolBarNuevo.Enabled = False
            Else
                Me.ToolBarBuscar.Enabled = False
            End If
            'End If
            Dim fx As New cFunciones
            txtTipoCambio.Text = fx.TipoCambio(DateTimePicker1.Value, True)
            Me.AdpCC.Fill(Me.DsAjusteBancario.CentroCosto)


        Catch ex As Exception
            MsgBox("Problemas al cargar el Formulario, Intente abrir otra vez, si el problema persiste comuniqueselo al administrador del sistema ")
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function ValoresPorDefecto()
        Dim Funcion As New cFunciones
        'Ajuste Bancario
        Me.DsAjusteBancario.AjusteBancario.FechaColumn.DefaultValue = Me.DateTimePicker1.Value
        Me.DsAjusteBancario.AjusteBancario.Numero_DocumColumn.DefaultValue = 0
        Me.DsAjusteBancario.AjusteBancario.Num_AjusteColumn.DefaultValue = 0
        Me.DsAjusteBancario.AjusteBancario.ConciliacionColumn.DefaultValue = 0
        Me.DsAjusteBancario.AjusteBancario.MontoColumn.DefaultValue = 0
        Me.DsAjusteBancario.AjusteBancario.AnulaColumn.DefaultValue = False
        Me.DsAjusteBancario.AjusteBancario.Num_ConciliacionColumn.DefaultValue = "0"
        Me.DsAjusteBancario.AjusteBancario.ContabilizadoColumn.DefaultValue = 0
        Me.DsAjusteBancario.AjusteBancario.AsientoColumn.DefaultValue = "0"
        Me.DsAjusteBancario.AjusteBancario.ConceptoColumn.DefaultValue = "--"
        Me.DsAjusteBancario.AjusteBancario.DebitoColumn.DefaultValue = False
        Me.DsAjusteBancario.AjusteBancario.CreditoColumn.DefaultValue = True
        Me.DsAjusteBancario.AjusteBancario.TipoCambioColumn.DefaultValue = Funcion.TipoCambio(DateTimePicker1.Value, True)

        If Me.DsAjusteBancario.Cuentas_bancarias.Rows.Count > 0 Then
            Me.DsAjusteBancario.AjusteBancario.Id_CuentaBancariaColumn.DefaultValue = Me.DsAjusteBancario.Cuentas_bancarias.Rows(0).Item("Id_CuentaBancaria")
        End If

        'Detalle Ajuste Bancario
        Me.DsAjusteBancario.AjusteBancario_Detalle.MontoColumn.DefaultValue = "0"
        Me.DsAjusteBancario.AjusteBancario_Detalle.CuentaContableColumn.DefaultValue = "0"
        Me.DsAjusteBancario.AjusteBancario_Detalle.Descripcion_MovColumn.DefaultValue = "--"
        Me.DsAjusteBancario.AjusteBancario_Detalle.NombreCuentaColumn.DefaultValue = "--"
        Me.DsAjusteBancario.AjusteBancario_Detalle.CuentaContableColumn.DefaultValue = "0"
        'Cuenta Bancaria
        Me.Label16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "Cuentas_bancarias.MonedaNombre"))
        Me.Label14.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAjusteBancario, "Cuentas_bancarias.Descripcion"))

        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsAjusteBancario.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsAjusteBancario.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsAjusteBancario.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsAjusteBancario.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsAjusteBancario.AsientosContables.TipoDocColumn.DefaultValue = 3
        DsAjusteBancario.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsAjusteBancario.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsAjusteBancario.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsAjusteBancario.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsAjusteBancario.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsAjusteBancario.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsAjusteBancario.AsientosContables.ModuloColumn.DefaultValue = "Ajustes Bancarios"
        DsAjusteBancario.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsAjusteBancario.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsAjusteBancario.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsAjusteBancario.AsientosContables.TotalHaberColumn.DefaultValue = 0

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsAjusteBancario.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsAjusteBancario.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsAjusteBancario.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsAjusteBancario.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsAjusteBancario.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsAjusteBancario.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsAjusteBancario.DetallesAsientosContable.HaberColumn.DefaultValue = 0
        'VALORES POR DEFECTO PARA LA TABLA CENTROS DE COSTO MOVIMIENTOS
        DsAjusteBancario.CentroCosto_Movimientos.IdAsientoColumn.DefaultValue = ""
        DsAjusteBancario.CentroCosto_Movimientos.DocumentoColumn.DefaultValue = ""
        DsAjusteBancario.CentroCosto_Movimientos.FechaColumn.DefaultValue = Now.Date
        DsAjusteBancario.CentroCosto_Movimientos.IdCentroCostoColumn.DefaultValue = 0
        DsAjusteBancario.CentroCosto_Movimientos.MontoColumn.DefaultValue = 0
        DsAjusteBancario.CentroCosto_Movimientos.DebeColumn.DefaultValue = 0
        DsAjusteBancario.CentroCosto_Movimientos.HaberColumn.DefaultValue = 0
        DsAjusteBancario.CentroCosto_Movimientos.DescripcionColumn.DefaultValue = ""
        DsAjusteBancario.CentroCosto_Movimientos.CuentaContableColumn.DefaultValue = ""
        DsAjusteBancario.CentroCosto_Movimientos.NombreCuentaContableColumn.DefaultValue = ""
        DsAjusteBancario.CentroCosto_Movimientos.TipoColumn.DefaultValue = 2
        DsAjusteBancario.CentroCosto_Movimientos.IdDetalleColumn.DefaultValue = 0
    End Function
#End Region

#Region "Control de Controles"
    Function HabilitarChekes()
        GroupBox1.Enabled = True
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

#Region "Anular"
    Function Anula()
        Try
            Dim Funciones As New Conexion
            If MsgBox("Desea Anular Ajuste Bancario", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Function
            End If
            If Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Conciliacion") = True Then
                MsgBox("No es Posible Anular este Ajuste ya que ha sido Conciliado !!!!", MsgBoxStyle.Information, "Atención...")
                Exit Function
            End If

            'VALIDA ASIENTO SI TIENE
            'If Not Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Asiento").Equals("0") Then
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("Select Mayorizado From AsientosContables WHERE NumAsiento = '" & Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Asiento") & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
            '    If dt.Rows.Count > 0 Then
            '        If dt.Rows(0).Item(0) Then
            '            MsgBox("El asiento # " & Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Asiento") & " que corresponde a este ajuste ya esta mayorizado, NO se puede anular", MsgBoxStyle.OKOnly)
            '            Exit Function
            '        End If
            '    End If
            'End If
            '---------------------------------------


            Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Anula") = True
            Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()
            Anular.Visible = True

            Me.daAjusteBancario.Update(Me.DsAjusteBancario.AjusteBancario)
            MsgBox("Ajuste Anulado satisfactoriamente", MsgBoxStyle.Information)
            'VALIDA ASIENTO SI TIENE Y ANULA
            If Not Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Asiento").Equals("0") Then
                Dim cx As New Conexion
                cx.Conectar("Contabilidad")
                cx.SlqExecute(cx.sQlconexion, "UPDATE AsientosContables Set Mayorizado = 0, Anulado = 1 WHERE NumAsiento = '" & Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Asiento") & "'")
                cx.DesConectar(cx.sQlconexion)
            End If
            '---------------------------------------
            BanderaGeneral.ACTUALIZO_ASIENTO2 = True
            BanderaGeneral.ACTUALIZO_ASIENTO = True

            Return True

        Catch ex As Exception
            MsgBox("Error al tratar de anular el Ajuste, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function
#End Region

#Region "Editar"
    Function Editar()
        Try
            If ToolBarEditar2.Text = "Editar" Then
                Dim Cx As New Conexion
                Dim Conciliacion As Boolean
                Dim Id_Cuenta As Integer = cboCuenta.SelectedValue

                ToolBarEditar2.Text = "Cancelar"
                ToolBarEditar2.ImageIndex = 8
                If Anular.Visible = True Then
                    MsgBox("No se puede editar el depósito porque está anulado", MsgBoxStyle.Information, "Atención...")
                    ToolBarEditar2.Text = "Editar"
                    ToolBarEditar2.ImageIndex = 9
                    Exit Function
                End If
                Conciliacion = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Conciliacion FROM bancos.dbo.AjusteBancario WHERE(Id_CuentaBancaria = " & Id_Cuenta & "and Num_Ajuste =" & Me.txtNumerodeposito.Text & ")")
                Cx.DesConectar(Cx.sQlconexion)
                If Conciliacion = True Then
                    MsgBox("No se puede editar el ajuste bancario porque está conciliado", MsgBoxStyle.Information, "Atención...")
                    ToolBarEditar2.Text = "Editar"
                    ToolBarEditar2.ImageIndex = 9
                    Exit Function
                End If
                If DsAjusteBancario.AsientosContables.Count > 0 Then
                    'If BindingContext(DsAjusteBancario, "AsientosContables").Current("Mayorizado") = True Then
                    '    MsgBox("No se puede editar el Ajuste Bancario porque el Asiento esta Mayorizado", MsgBoxStyle.Information, "Atención...")
                    '    ToolBarEditar2.Text = "Editar"
                    '    ToolBarEditar2.ImageIndex = 9
                    '    Exit Function
                    'End If
                End If

                Me.HabilitarChekes()
                Me.HabilitarDetallesCheques()
                Me.ToolBarNuevo.Enabled = False
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                EditaAsiento = True

            Else
                ToolBarEditar2.Text = "Editar"
                ToolBarEditar2.ImageIndex = 9
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").CancelCurrentEdit()
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()
                Me.InhabilitarChekes()
                Me.INHabilitarDetallesCheques()
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarImprimir.Enabled = True
                EditaAsiento = False
                EditaCentro = False
            End If

        Catch ex As Exception
            MsgBox("Error al tratar de editar el ajuste bancario, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function

#End Region

#Region "Buscar id deposito"
    Public Function id(ByVal id1 As String, ByVal c As String)
        Dim cnn As SqlConnection = Nothing
        Dim sel As String
        'a = txtNumerodeposito.Text
        'cuenta = Me.cboBancos.Text
        Dim Cx1 As New Conexion
        'Dim NumeroDeposito As String
        Dim sent1 As String
        sent1 = "SELECT bancos.dbo.AjusteBancario.Id_Ajuste FROM bancos.dbo.Cuentas_bancarias INNER JOIN" & _
                      " bancos.dbo.AjusteBancario ON bancos.dbo.Cuentas_bancarias.Id_CuentaBancaria = bancos.dbo.AjusteBancario.Id_CuentaBancaria where bancos.dbo.AjusteBancario.Num_Ajuste = '" & id1 & "' and bancos.dbo.Cuentas_bancarias.Cuenta ='" & cuentabancaria & "'"

        id_ajuste = Cx1.SlqExecuteScalar(Cx1.Conectar("Bancos"), sent1)
        Cx1.DesConectar(Cx1.sQlconexion)
    End Function
#End Region

#Region "Buscar"
    Function Buscar()
        'Dim Fx As New Buscadores
        'Dim Id_Cheque As String
        'Id_Cheque = Fx.Buscar_X_Descripcion_Fecha2("SELECT dbo.Cuentas_bancarias.Cuenta,dbo.AjusteBancario.Num_Ajuste AS Número, dbo.AjusteBancario.Concepto, dbo.AjusteBancario.Fecha FROM dbo.AjusteBancario INNER JOIN dbo.Cuentas_bancarias ON dbo.AjusteBancario.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria ORDER BY AjusteBancario.Fecha DESC", "Concepto", "Fecha", "Buscar Ajuste", Me.SqlConnection1.ConnectionString)
        'cuentabancaria = Fx.cuentabancaria
        'If Id_Cheque <> "" Then
        '    Me.DsAjusteBancario.Cuentas_bancarias.Clear()
        '    Me.daCuentaBancaria.Fill(Me.DsAjusteBancario.Cuentas_bancarias)
        '    Me.DsAjusteBancario.AjusteBancario_Detalle.Clear()
        '    Me.DsAjusteBancario.AjusteBancario.Clear()
        '    cargarAjuste(Id_Cheque, cuentabancaria)
        'End If
    End Function


    Sub cargarAjuste(ByVal Num_Ajuste As String, ByVal cuentabanc As String)
        id(Num_Ajuste, cuentabanc) ' SE BUSCA EL ID DEL AJUSTE SELECCIONADO
        CargarCheques(id_ajuste)
        CargarDetalleCheque(id_ajuste)

        If Me.DsAjusteBancario.AjusteBancario.Rows.Count > 0 Then
            If Me.DsAjusteBancario.AjusteBancario.Rows(0).Item("Anula") = True Then
                Anular.Visible = True
                Me.ToolBarEliminar.Enabled = False
            Else
                Anular.Visible = False
                Me.ToolBarEliminar.Enabled = True
            End If
            Me.ToolBarImprimir.Enabled = True
            Me.ToolBarRegistrar.Enabled = False
            Me.ToolBarEditar2.Enabled = True
            Me.ToolBarCerrar.Enabled = True
        End If
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
            Dim sel As String = "select * from AjusteBancario WHERE Id_Ajuste = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DsAjusteBancario.AjusteBancario)
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
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Bancos", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from AjusteBancario_Detalle WHERE Id_Ajuste = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DsAjusteBancario.AjusteBancario_Detalle)
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
        Dim Fx As New cFunciones
        Anular.Visible = False
        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            Me.Anular.Visible = False
            EditaAsiento = False
            Try 'inicia la edicion
                Me.DsAjusteBancario.AjusteBancario_Detalle.Clear()
                Me.DsAjusteBancario.AjusteBancario.Clear()
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").CancelCurrentEdit()
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").AddNew()
                Me.HabilitarChekes()
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarCerrar.Enabled = True
                Me.dgDeposito.Enabled = True
                txtTipoCambio.Text = Fx.TipoCambio(DateTimePicker1.Value, True)
                cboCuenta.Text = GetSetting("SeeSOFT", "Bancos", "UltCuenta")
                Me.cboCuenta.Focus()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").CancelCurrentEdit()
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()
                Me.InhabilitarChekes()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarBuscar.Enabled = True
                Me.dgDeposito.Enabled = False
                If Me.desdeConciliacion Then
                    DialogResult = DialogResult.Cancel
                    Me.Close()
                End If

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
            Ajuste = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Id_Ajuste FROM AjusteBancario WHERE Num_Ajuste = " & Num_Ajuste & "AND Id_CuentaBancaria = " & cboCuenta.SelectedValue)
            Cx.DesConectar(Cx.sQlconexion)
            If Ajuste = "" Then
            Else
                MsgBox("Ya existe un ajuste de cuenta con este numero")
                txtNumerodeposito.Focus()
                Return False
            End If
        End If
        Return True
    End Function

    Function numero() As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim sel As String
        cuenta = Me.cboCuenta.Text
        a = txtNumerodeposito.Text
        Dim Cx As New Conexion
        Dim NumeroAjuste As String
        NumeroAjuste = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT * FROM dbo.AjusteBancario INNER JOIN dbo.Cuentas_bancarias ON dbo.AjusteBancario.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria WHERE dbo.AjusteBancario.Num_Ajuste = " & a & " And dbo.Cuentas_bancarias.Cuenta = '" & cuenta & "'")
        Cx.DesConectar(Cx.sQlconexion)
        If NumeroAjuste = "" Then
            Return True
        Else
            If ToolBarEditar2.Text = "Cancelar" Then
                Return True
            End If
            MsgBox("Este número de ajuste ya existe, favor revisar...", MsgBoxStyle.Information, "Atención...")
            Return False
        End If
    End Function
#End Region

#Region "Guardar"
    Function GuardarCabios() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Trans = Me.SqlConnection1.BeginTransaction

        Dim CodigoMoneda As Integer
        Dim ValorCompra As Double
        CodigoMoneda = Me.DsAjusteBancario.Cuentas_bancarias(BindingContext(DsAjusteBancario, "Cuentas_bancarias").Position).Cod_Moneda

        Dim n As Integer
        For n = 0 To DsAjusteBancario.Moneda.Count - 1
            If CodigoMoneda = DsAjusteBancario.Moneda(n).CodMoneda Then
                ValorCompra = DsAjusteBancario.Moneda(n).ValorCompra
                Exit For
            End If
        Next

        DsAjusteBancario.AjusteBancario(0).CodigoMoneda = CodigoMoneda
        DsAjusteBancario.AjusteBancario(0).TipoCambio = CDbl(txtTipoCambio.Text)
        Try
            Me.daAjusteBancario.InsertCommand.Transaction = Trans
            Me.daAjusteBancario.UpdateCommand.Transaction = Trans
            Me.daAjusteBancario.DeleteCommand.Transaction = Trans
            Me.daAjusteDetalleBancario.InsertCommand.Transaction = Trans
            Me.daAjusteDetalleBancario.UpdateCommand.Transaction = Trans
            Me.daAjusteDetalleBancario.DeleteCommand.Transaction = Trans
            Me.daAjusteBancario.Update(Me.DsAjusteBancario.AjusteBancario)
            Me.daAjusteDetalleBancario.Update(Me.DsAjusteBancario.AjusteBancario_Detalle)
            Trans.Commit()
            If SqlConnection3.State <> SqlConnection3.State.Open Then SqlConnection3.Open()
            ActualizaDocCentro()
            Me.adpCuentaMov.Update(DsAjusteBancario.CentroCosto_Movimientos)
            ''------------------------------------------------------------------
            'SI EN CONFIGURACION ESTA ACTIVO CONTABILIDAD REALIZA EL ASIENTO - ORA
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
            ''------------------------------------------------------------------

            DsAjusteBancario.AcceptChanges()
            MsgBox("Ajuste guardado satisfactoriamente", MsgBoxStyle.Information)
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox("Error al tratar de guardar los datos, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function


    Function GuardarDetalle()
        Dim i As Integer
        Dim Cx As New Conexion
        Dim Campos As String = "Id_Ajuste, Descripcion_Mov, CuentaContable, Monto, NombreCuenta"
        Dim Datos As String
        Try
            For i = 0 To Me.DsAjusteBancario.AjusteBancario_Detalle.Rows.Count - 1
                Datos = Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Id_Ajuste") & ", '" & _
                Me.DsAjusteBancario.AjusteBancario_Detalle.Rows(i).Item("Descripcion_Mov") & "', '" & _
                Me.DsAjusteBancario.AjusteBancario_Detalle.Rows(i).Item("CuentaContable") & "', " & _
                Me.DsAjusteBancario.AjusteBancario_Detalle.Rows(i).Item("Monto") & ", '" & _
                Me.DsAjusteBancario.AjusteBancario_Detalle.Rows(i).Item("NombreCuenta") & "'"
                Cx.AddNewRecord("AjusteBancario_Detalle", Campos, Datos)
            Next
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function

    Function Guardar()
        Dim Fx As New cFunciones
        Dim cConexion As New Conexion

        FechaConciliacion()
        If numero() Then ' se valida si el numero de ajuste ya existe
            If Me.ValidarCheque Then
                If ValidarDetalleCheque(True) Then
                    If DateTimePicker1.Value <= FechaCon And Me.ToolBar1.Buttons(0).Text = "Cancelar" Then
                        MsgBox("La Fecha del ajuste no es valida porque existe una conciliación con una fecha mayor, favor revisar")
                    Else
                        Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()

                        '------------------------------------------------------------------
                        'VERIFICA EL PERIODO DE TRABAJO - ORA
                        Conta = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "Select Contabilidad from bancos.dbo.Configuraciones")
                        cConexion.DesConectar(cConexion.sQlconexion)
                        If Conta = 1 Or Conta = 2 Then
                            If Fx.ValidarPeriodo(Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Fecha")) = False Then
                                MsgBox("La Fecha del Ajuste No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar el Ajuste", MsgBoxStyle.Information, "Sistema SeeSoft")
                                Exit Function
                            End If
                        End If
                        '------------------------------------------------------------------
                        If Me.GuardarCabios() Then
                            Try
                                BanderaGeneral.ACTUALIZO_ASIENTO2 = True
                                BanderaGeneral.ACTUALIZO_ASIENTO = True
                                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()
                                SaveSetting("SeeSOFT", "Bancos", "UltCuenta", cboCuenta.Text)
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
                                EditaCentro = False
                                Me.SimpleNuevo.Text = "Nuevo"
                                Me.SimpleGuardar.Enabled = False
                                Me.dgDeposito.Enabled = True
                                EditaAsiento = False
                                If MsgBox("Desea Imprimir el Ajuste Bancario", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Imprimir()
                                End If
                                Me.Close()
                                If Me.desdeConciliacion Then
                                    If Me.modificar Then
                                        Me.nuevoMonto = CDbl(Me.CalcEdit1.Text)
                                    End If
                                    DialogResult = DialogResult.OK

                                    Me.Close()
                                    Exit Function
                                End If
                                DsAjusteBancario.AjusteBancario_Detalle.Clear()
                                DsAjusteBancario.AjusteBancario.Clear()
                                DsAjusteBancario.DetallesAsientosContable.Clear()
                                DsAjusteBancario.AsientosContables.Clear()
                                DsAjusteBancario.Cuentas_bancarias.Clear()
                                daCuentaBancaria.Fill(DsAjusteBancario.Cuentas_bancarias)
                            Catch ex As Exception
                            End Try
                        End If
                    End If
                End If
            End If
        End If
    End Function
#End Region

#Region "Imprimir"
    Function Imprimir()
        Dim Apertura_Cajas As New ReporteAjusteBancario
        Dim visor As New frmVisorReportes
        Dim servidor As String = Me.SqlConnection1.DataSource
        Apertura_Cajas.SetDatabaseLogon("sa", "", Me.SqlConnection1.DataSource, Me.SqlConnection1.Database)
        Apertura_Cajas.SetParameterValue(0, Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").Current("Id_Ajuste"))
        CrystalReportsConexion2.LoadReportBancos(visor.rptViewer, Apertura_Cajas, , GetSetting("SeeSOFT", "Bancos", "Conexion"))
        visor.rptViewer.Visible = True
        Apertura_Cajas = Nothing
        visor.ShowDialog()
    End Function
#End Region

#Region "Terminar Edicion Cheques"
    Private Sub TxtObservaciones_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarCheque() Then
                Try
                    Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").EndCurrentEdit()
                    Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").AddNew()
                    Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario").CancelCurrentEdit()
                    Me.HabilitarDetallesCheques()
                    SimpleNuevo.Focus()
                    Me.txtDescripcion.Text = Me.txtObservaciones.Text()
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
                MsgBox("El monto excede el total del cheque")
                CalcEdit2.Focus()
                Return False
            End If
        Else
            If Totalcheque = Totaldetalle Then
            Else
                MsgBox("El monto del Ajuste no concuerda con el detalle", MsgBoxStyle.Information)
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
        Return True
    End Function


#End Region

#Region "Agregar detalles Cheques"
    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleNuevo.Click

        If Me.SimpleNuevo.Text = "Nuevo" Then
            Try
                SimpleNuevo.Text = "Cancelar"
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").EndCurrentEdit()
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").AddNew()
                Me.SimpleGuardar.Enabled = True
                Me.SimpleEliminar.Enabled = False
                Me.dgDeposito.Enabled = False
                Me.TxtCuenta.Text = ""
                Me.txtDescripcion.Text = Me.txtObservaciones.Text()
                txtDescripcion.Focus()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").CancelCurrentEdit()
            SimpleNuevo.Text = "Nuevo"
            Me.SimpleGuardar.Enabled = False
            Me.SimpleEliminar.Enabled = True
            Me.dgDeposito.Enabled = True
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
                Me.Label19.Text = nombre
                If ValidarDetalleCheque() Then
                    Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").EndCurrentEdit()
                    Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").AddNew()
                    Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").CancelCurrentEdit()
                    SimpleNuevo.Text = "Nuevo"
                    Me.SimpleGuardar.Enabled = False
                    Me.SimpleEliminar.Enabled = True
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Eliminar Detalles Cheques"
    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleEliminar.Click
        If Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").Count > 0 Then
            Try
                Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").RemoveAt(Me.BindingContext(Me.DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").Position)
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

#Region "Buscar Cuenta Contable"

    Private Sub TxtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtCuenta.KeyDown
        If e.KeyCode = Keys.F1 Then
            '**********************************      Cambio Elias          ********************************

            'Dim codcue As String
            'Dim buscar As New cFunciones
            'codcue = buscar.BuscarDatos("Select CuentaContable,Descripcion From CuentaContable where Movimiento=1", "Descripcion", "Buscar Cuenta Contable .....", Configuracion.Claves.Conexion("Contabilidad"))
            'TxtCuenta.Text = codcue
            'Label19.Text = cFunciones.Descripcion

            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = GetSetting("SeeSoft", "Bancos", "CONEXION")
            busca.sqlstring = " select CuentaContable as [Cuenta contable],Nombre, [Cuenta madre] from [vs_CuentaConta_Bancos] CC "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            TxtCuenta.Text = busca.codigo
            Label19.Text = busca.descrip

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
                Me.Label19.Text = nombre
                Me.SimpleGuardar.Focus()
            End If
        End If
    End Sub


    Private Function BuscarCuentaCont(ByVal cuentaconta As String)
        Dim conectar As SqlConnection = Nothing
        Me.DsAjusteBancario.cuentascontable.Clear()
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
            dacuenta.Fill(Me.DsAjusteBancario.cuentascontable)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            If Not conectar Is Nothing Then
                conectar.Close()
            End If
        End Try
        If DsAjusteBancario.cuentascontable.Rows.Count > 0 Then
            Me.TxtCuenta.Text = cuentaconta
            Me.Label19.Text = Me.DsAjusteBancario.cuentascontable.Rows(0).Item("Descripcion")
        End If
    End Function
#End Region

#Region "Tab"
    Private Sub cboCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.DateTimePicker1.Focus()
        End If

        If e.KeyCode = Keys.F1 Then
            If Me.ToolBar1.Buttons(0).Text = "Cancelar" Then
                If e.KeyCode = Keys.F1 Then
                    BuscarCuenta()
                End If
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Dim Fx As New cFunciones
        txtTipoCambio.Text = Fx.TipoCambio(DateTimePicker1.Value, True)
    End Sub

    Function BuscarCuenta()

        'Dim valor As String
        'Dim BuscarCuentaBancaria As New BuscarCuentaBancaria
        'If BuscarCuentaBancaria.ShowDialog = DialogResult.OK Then
        '    valor = BuscarCuentaBancaria.Label6.Text
        'End If

        'If valor = "" Then
        '    '            Me.ComboBox1.SelectedIndex = -1
        'Else
        '    Me.cboCuenta.SelectedValue = valor
        'End If
    End Function


    Private Sub DateTimePicker1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DateTimePicker1.Value > FechaCon Then
                Me.txtNumerodeposito.Focus()
            Else
                MsgBox("Fecha Incorrecta")
            End If
        End If
    End Sub


    Private Sub txtNumerodeposito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumerodeposito.KeyDown
        If e.KeyCode = Keys.Enter Then
            If numero() Then
                Me.txtNumerodeposito.Text = a
                Me.CalcEdit1.Focus()
            Else
                MessageBox.Show("El número de ajuste digitado ya existe..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub


    Private Sub CalcEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcEdit1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtTipoCambio.Focus()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.CalcEdit2.Focus()
        End If
    End Sub

    Private Sub CalcEdit2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CalcEdit2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TxtCuenta.Focus()
        End If
    End Sub

    Private Sub txtTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.txtObservaciones.Focus()
        End If
    End Sub
#End Region

#Region "ToolBar1"
    Private Sub ToolBar1_ButtonClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1

            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Editar()

            Case 4 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Delete Then Anula() Else MsgBox("No tiene permiso para anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 7 : Me.Close()

        End Select
    End Sub
#End Region

#Region "Validar Fecha Conciliacion"
    Function FechaConciliacion()
        Dim cConexion As New Conexion
        FechaCon = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT ISNULL(MAX(Hasta),0) AS FechaMax FROM bancos.dbo.Conciliacion where Id_CuentaBancaria =" & cboCuenta.SelectedValue)
        cConexion.DesConectar(cConexion.sQlconexion)
    End Function
#End Region

#Region "Asientos Contables"
    Public Sub GuardaAsiento()
        Dim Fx As New cFunciones
        Dim Tipo As Integer
        Dim Funciones As New Conexion

        If rbCredito.Checked = True Then
            Tipo = 3
            Debe = True : Haber = False
        Else
            Tipo = 4
            Debe = False : Haber = True
        End If

        If BindingContext(DsAjusteBancario, "AsientosContables").Count < 1 Then
            DsAjusteBancario.AsientosContables.Clear()
            DsAjusteBancario.DetallesAsientosContable.Clear()
            BindingContext(DsAjusteBancario, "AsientosContables").CancelCurrentEdit()
            BindingContext(DsAjusteBancario, "AsientosContables").AddNew()
            BindingContext(DsAjusteBancario, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("BCO-" & Format(DateTimePicker1.Value.Month, "00") & Format(DateTimePicker1.Value.Date, "yy") & "-")
        Else
            Funciones.DeleteRecords("DetallesAsientosContable", "NumAsiento ='" & BindingContext(DsAjusteBancario, "AsientosContables").Current("NumAsiento") & "'")
        End If
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Fecha") = DateTimePicker1.Value
        BindingContext(DsAjusteBancario, "AsientosContables").Current("IdNumDoc") = DsAjusteBancario.AjusteBancario(0).Id_Ajuste
        BindingContext(DsAjusteBancario, "AsientosContables").Current("NumDoc") = DsAjusteBancario.AjusteBancario(0).Num_Ajuste
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Beneficiario") = ""
        BindingContext(DsAjusteBancario, "AsientosContables").Current("TipoDoc") = Tipo
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsAjusteBancario, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Mayorizado") = 1
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(DateTimePicker1.Value)
        BindingContext(DsAjusteBancario, "AsientosContables").Current("NumMayorizado") = 1
        BindingContext(DsAjusteBancario, "AsientosContables").Current("Modulo") = "Ajustes Bancarios"
        If Me.rbCredito.Checked = True Then
            BindingContext(DsAjusteBancario, "AsientosContables").Current("Observaciones") = "Nota de Credito por Ajuste Bancario # " & DsAjusteBancario.AjusteBancario(0).Num_Ajuste
        End If
        If Me.rbDebito.Checked = True Then
            BindingContext(DsAjusteBancario, "AsientosContables").Current("Observaciones") = "Nota de Debito por Ajuste Bancario # " & DsAjusteBancario.AjusteBancario(0).Num_Ajuste
        End If
        BindingContext(DsAjusteBancario, "AsientosContables").Current("NombreUsuario") = TxtNombreUsuario.Text
        BindingContext(DsAjusteBancario, "AsientosContables").Current("TotalDebe") = DsAjusteBancario.AjusteBancario(0).Monto
        BindingContext(DsAjusteBancario, "AsientosContables").Current("TotalHaber") = DsAjusteBancario.AjusteBancario(0).Monto
        BindingContext(DsAjusteBancario, "AsientosContables").Current("CodMoneda") = DsAjusteBancario.AjusteBancario(0).CodigoMoneda
        BindingContext(DsAjusteBancario, "AsientosContables").Current("TipoCambio") = CDbl(txtTipoCambio.Text)
        BindingContext(DsAjusteBancario, "AsientosContables").EndCurrentEdit()

        'CREA TODOS LOS DETALLES DEL ASIENTO
        AsientoDetalle()

        'ACTUALIZA EL NUMERO DE ASIENTO AL AJUSTE
        Funciones.UpdateRecords("bancos.dbo.AjusteBancario", "Contabilizado = 1, Asiento = '" & BindingContext(DsAjusteBancario, "AsientosContables").Current("NumAsiento") & "'", "Id_Ajuste = " & DsAjusteBancario.AjusteBancario(0).Id_Ajuste, "Bancos")
    End Sub


    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String, ByVal Descripcion As String)
        If Monto <> 0 Then  'CREA LOS DETALLES DE ASIENTOS CONTABLES
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsAjusteBancario, "AsientosContables").Current("NumAsiento")
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = Descripcion
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = CDbl(txtTipoCambio.Text)
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        End If
    End Sub


    Private Sub AsientoDetalle()
        Try
            If DsAjusteBancario.AjusteBancario_Detalle.Count > 0 Then
                If Not Me.rbCredito.Checked Then
                    '------------------------------------------------------------------
                    'GUARDA ASIENTOS PARA LOS DETALLES DEL AJUSTE
                    For i As Integer = 0 To DsAjusteBancario.AjusteBancario_Detalle.Count - 1
                        GuardaAsientoDetalle(DsAjusteBancario.AjusteBancario_Detalle(i).Monto, Haber, Debe, DsAjusteBancario.AjusteBancario_Detalle(i).CuentaContable, DsAjusteBancario.AjusteBancario_Detalle(i).NombreCuenta, DsAjusteBancario.AjusteBancario_Detalle(i).Descripcion_Mov)
                    Next i
                    '------------------------------------------------------------------

                    '------------------------------------------------------------------
                    'GUARDA ASIENTOS PARA LA CUENTA BANCARIA
                    GuardaAsientoDetalle(DsAjusteBancario.AjusteBancario(0).Monto, Debe, Haber, BindingContext(DsAjusteBancario, "Cuentas_bancarias").Current("CuentaContable"), BindingContext(DsAjusteBancario, "Cuentas_bancarias").Current("NombreCuentaContable"), DsAjusteBancario.AjusteBancario(0).Concepto)
                    '------------------------------------------------------------------
                Else
                    '------------------------------------------------------------------
                    'GUARDA ASIENTOS PARA LA CUENTA BANCARIA
                    GuardaAsientoDetalle(DsAjusteBancario.AjusteBancario(0).Monto, Debe, Haber, BindingContext(DsAjusteBancario, "Cuentas_bancarias").Current("CuentaContable"), BindingContext(DsAjusteBancario, "Cuentas_bancarias").Current("NombreCuentaContable"), DsAjusteBancario.AjusteBancario(0).Concepto)
                    '------------------------------------------------------------------

                    '------------------------------------------------------------------
                    'GUARDA ASIENTOS PARA LOS DETALLES DEL AJUSTE
                    For i As Integer = 0 To DsAjusteBancario.AjusteBancario_Detalle.Count - 1
                        GuardaAsientoDetalle(DsAjusteBancario.AjusteBancario_Detalle(i).Monto, Haber, Debe, DsAjusteBancario.AjusteBancario_Detalle(i).CuentaContable, DsAjusteBancario.AjusteBancario_Detalle(i).NombreCuenta, DsAjusteBancario.AjusteBancario_Detalle(i).Descripcion_Mov)
                    Next i
                    '------------------------------------------------------------------


                End If

            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Function TransAsiento() As Boolean

        Try
            If SqlConnection3.State <> SqlConnection3.State.Open Then SqlConnection3.Open()

            Trans2 = SqlConnection3.BeginTransaction
            BindingContext(DsAjusteBancario, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsAjusteBancario, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = Trans2
            AdapterDetallesAsientos.DeleteCommand.Transaction = Trans2
            AdapterDetallesAsientos.InsertCommand.Transaction = Trans2

            AdapterAsientos.UpdateCommand.Transaction = Trans2
            AdapterAsientos.DeleteCommand.Transaction = Trans2
            AdapterAsientos.InsertCommand.Transaction = Trans2

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterDetallesAsientos.Update(DsAjusteBancario.DetallesAsientosContable)
            AdapterAsientos.Update(DsAjusteBancario.AsientosContables)
            '-----------------------------------------------------------------------------------
            Trans2.Commit()
            Return True

        Catch ex As Exception
            Trans2.Rollback()
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
            Dim sel As String = "Select * From AsientosContables WHERE IdNumDoc = " & Id & " AND Modulo = 'Ajustes Bancarios'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            DsAjusteBancario.DetallesAsientosContable.Clear()
            DsAjusteBancario.AsientosContables.Clear()
            da.Fill(DsAjusteBancario.AsientosContables)
            If DsAjusteBancario.AsientosContables.Count < 1 Then
                DsAjusteBancario.AsientosContables.Clear()
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

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub rbDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDebito.CheckedChanged

    End Sub

    Private Sub TxtCuenta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCuenta.TextChanged

    End Sub
    Private Sub Panel_Centrar()
        PanelCentroCosto.Left = (Width - PanelCentroCosto.Width) \ 2
        'PanelCentroCosto.Top = (Height - PanelCentroCosto.Height) \ 2
    End Sub
    Dim TotalCentro As Double = 0
    Public Sub LlenaGridCentro(ByVal Centro As String, ByVal monto As Double, ByVal descripcion As String, ByVal id As Integer)
        Dim NuevaFila As dsAjusteBancario.CentroCostoDetalleRow
        NuevaFila = Me.DsAjusteBancario.CentroCostoDetalle.NewCentroCostoDetalleRow
        NuevaFila.CentroCosto = Centro
        NuevaFila.Monto = monto
        NuevaFila.Descripcion = descripcion
        NuevaFila.Id = id
        DsAjusteBancario.CentroCostoDetalle.AddCentroCostoDetalleRow(NuevaFila)
    End Sub

    Public Sub CargaCentro(ByVal id As Integer)
        Dim Centro() As System.Data.DataRow
        TotalCentro = 0
        Me.DsAjusteBancario.CentroCostoDetalle.Clear()
        If DsAjusteBancario.CentroCosto_Movimientos.Count > 0 Then
            For i As Integer = 0 To DsAjusteBancario.CentroCosto_Movimientos.Count - 1
                If Not DsAjusteBancario.CentroCosto_Movimientos(i).RowState = DataRowState.Deleted Then
                    If DsAjusteBancario.CentroCosto_Movimientos(i).IdDetalle = id Then
                        Centro = DsAjusteBancario.CentroCosto.Select("Id = " & DsAjusteBancario.CentroCosto_Movimientos(i).IdCentroCosto, "Nombre")
                        LlenaGridCentro(Centro(0)(2), DsAjusteBancario.CentroCosto_Movimientos(i).Monto, DsAjusteBancario.CentroCosto_Movimientos(i).Descripcion, DsAjusteBancario.CentroCosto_Movimientos(i).Id)
                        TotalCentro += DsAjusteBancario.CentroCosto_Movimientos(i).Monto
                    End If
                End If
            Next i
        End If
    End Sub
    Private Sub btnCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentroCosto.Click
        Dim num_cuenta As String = Me.TxtCuenta.Text
        If num_cuenta.StartsWith("1") Or num_cuenta.StartsWith("2") Or num_cuenta.StartsWith("3") Then
            MsgBox("No es posible incluir centro costo para esta cuenta", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

       
        If CalcEdit2.Value < 0 Then
            MsgBox("Por favor revise Monto", MsgBoxStyle.Critical, "Datos Incorrectos")
            Exit Sub
        End If

        If TxtCuenta.Text = "" Or Me.Label19.Text = "" Then
            MsgBox("Por favor revise la Cuenta Contable", MsgBoxStyle.Critical, "Datos Incorrectos")
            Exit Sub
        End If
        ' BindingContext(DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").EndCurrentEdit()
        If BindingContext(DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").Count > 0 Then
            CargaCentro(BindingContext(DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").Current("Id_AjusteDet"))

        End If
        TxtDetalle.Text = CalcEdit2.Value
        txtMontoCentroCosto.Text = CalcEdit2.Value
        Panel_Centrar()
        BNuevo.Focus()
        '
    End Sub

#Region "Centro de Costo"

#Region "Botones"
    Dim id_CentroCosto As Integer = 0
    'Private Sub BCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCentroCosto.Click
    '    Dim num_cuenta As String = Me.TxtCuenta.Text
    '    If num_cuenta.StartsWith("1") Or num_cuenta.StartsWith("2") Or num_cuenta.StartsWith("3") Then
    '        MsgBox("No es posible incluir centro costo para esta cuenta", MsgBoxStyle.OKOnly)
    '        Exit Sub
    '    End If
    '    If CalcEdit2.Value < 0 Then
    '        MsgBox("Por favor revise Monto", MsgBoxStyle.Critical, "Datos Incorrectos")
    '        Exit Sub
    '    End If

    '    If TxtCuenta.Text = "" Or Label19.Text = "" Then
    '        MsgBox("Por favor revise la Cuenta Contable", MsgBoxStyle.Critical, "Datos Incorrectos")
    '        Exit Sub
    '    End If

    '    If BindingContext(Me.DsAjusteBancario, "AjusteBancario_Detalle").Count > 0 Then

    '        CargaCentro(BindingContext(DsAjusteBancario, "AjusteBancario_Detalle").Current("Id_AjusteDet"))

    '        'Else
    '        '    MsgBox("Debe de Agregar un detalle del ajuste", MsgBoxStyle.Critical, "Datos Incorrectos")
    '    End If
    '    TxtDetalle.Text = CalcEdit2.Value
    '    Panel_Centrar()
    '    BNuevo.Focus()
    'End Sub
    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        If BNuevo.Text = "Nuevo" Then
            AgregaCentro()
            Controles(True)
            BNuevo.Text = "Cancelar"
            ButtonAgregarDetalle.Enabled = True
            EditDescripcionCC.Text = txtDescripcion.Text
            Me.txtCentroCosto.Focus()
        Else
            BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").CancelCurrentEdit()
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
        LlenaGridCentro(Me.id_CentroCosto, CDbl(txtMontoCentroCosto.Text), EditDescripcionCC.Text, BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Id"))
5:      BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("IdCentroCosto") = Me.id_CentroCosto
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").EndCurrentEdit()
        TxtDetalle.Text = CalcEdit2.Value
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
        BNuevo.Focus()
    End Sub


    Private Sub BotonCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCerrar.Click
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").CancelCurrentEdit()
        Panel_Ocultar()
        SimpleGuardar.Focus()
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub
#End Region


#Region "Funciones"
    Public Sub AgregaCentro()
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").EndCurrentEdit()
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").AddNew()
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("IdAsiento") = "0"
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Documento") = ""
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Tipo") = 9
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Debe") = False
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Haber") = True
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Fecha") = DateTimePicker1.Value
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("Monto") = Me.txtMontoCentroCosto.Text
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("CuentaContable") = TxtCuenta.Text
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("NombreCuentaContable") = Label19.Text
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("IdDetalle") = BindingContext(DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").Current("Id_AjusteDet")
        BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").Current("IdDetalleAux") = BindingContext(DsAjusteBancario, "AjusteBancario.AjusteBancarioAjusteBancario_Detalle").Current("Id_AjusteDet")

    End Sub
    Public EditaCentro As Boolean = False
    Public Sub EliminaCentro(ByVal id As Integer)
        'If DsAjusteBancario.CentroCosto_Movimientos.Count > 0 Then
        '    For i As Integer = 0 To DsAjusteBancario.CentroCosto_Movimientos.Count - 1
        '        If Not DsAjusteBancario.CentroCosto_Movimientos(i).RowState = DataRowState.Deleted Then
        '            If DsAjusteBancario.CentroCosto_Movimientos.Item(i).IdDetalle = id Then
        '                BindingContext(DsAjusteBancario.CentroCosto_Movimientos).RemoveAt(Me.BindingContext(DsAjusteBancario.CentroCosto_Movimientos).Position)
        '            End If

        '        End If

        '    Next i
        '    If EditaCentro = True Then
        '        Dim Funcion As New Conexion
        '        Funcion.DeleteRecords("CentroCosto_Movimientos", "IdDetalleAux =" & id, "Contabilidad")
        '    End If
        'End If
    End Sub


    Private Sub EliminarDetalleCentro()
        'If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
        '    Exit Sub
        'End If

        'If Me.DsAjusteBancario.CentroCostoDetalle.Count = 0 Then Exit Sub
        'Dim posicion, pos, IdCentro As Integer
        'posicion = BindingContext(DsAjusteBancario.CentroCostoDetalle).Position()

        'For i As Integer = 0 To DsAjusteBancario.CentroCosto_Movimientos.Count - 1
        '    If Not Me.DsAjusteBancario.CentroCosto_Movimientos(i).RowState = DataRowState.Deleted Then
        '        If DsAjusteBancario.CentroCosto_Movimientos(i).Id = BindingContext(DsAjusteBancario.CentroCostoDetalle).Current("Id") Then
        '            pos = i
        '        End If
        '    End If
        'Next i
        'TotalCentro = (TotalCentro - DsAjusteBancario.CentroCosto_Movimientos(pos).Monto)
        'IdCentro = DsAjusteBancario.CentroCosto_Movimientos(pos).Id
        'DsAjusteBancario.CentroCosto_Movimientos.Rows.RemoveAt(pos)
        'If EditaCentro = True Then
        '    Dim Funcion As New Conexion
        '    Funcion.DeleteRecords("CentroCosto_Movimientos", "Id = " & IdCentro, "Contabilidad")
        'End If
        'BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").EndCurrentEdit()
        'DsAjusteBancario.CentroCostoDetalle.Rows.RemoveAt(posicion)

        'BindingContext(DsAjusteBancario, "CentroCosto_Movimientos").CancelCurrentEdit()
        'TxtDetalle.Text = CalcEdit2.Value
        'Controles(False)
        'BNuevo.Text = "Nuevo"
        'ButtonAgregarDetalle.Enabled = False
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
            DsAjusteBancario.CentroCosto_Movimientos.Clear()
            DsAjusteBancario.CentroCostoDetalle.Clear()
            da.Fill(DsAjusteBancario.CentroCosto_Movimientos)
            If DsAjusteBancario.CentroCosto_Movimientos.Count < 1 Then
                DsAjusteBancario.CentroCosto_Movimientos.Clear()
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

    Public Sub ActualizaDocCentro()
        For x As Integer = 0 To DsAjusteBancario.CentroCosto_Movimientos.Count - 1
            If Not Me.DsAjusteBancario.CentroCosto_Movimientos(i).RowState = DataRowState.Deleted Then
                If BindingContext(DsAjusteBancario, "AsientosContables").Count > 0 Then
                    DsAjusteBancario.CentroCosto_Movimientos.Item(i).IdAsiento = BindingContext(DsAjusteBancario, "AsientosContables").Current("NumAsiento")
                End If


                DsAjusteBancario.CentroCosto_Movimientos.Item(x).Documento = Me.DsAjusteBancario.AjusteBancario(0).Id_Ajuste
            End If

        Next x
    End Sub
    Public Sub ActualizaIDCentro()
        If DsAjusteBancario.CentroCosto_Movimientos.Count > 0 Then
            Dim j As Integer = -1
            Dim Id_detalle As Integer

            Dim cConexion As New Conexion
            Id_detalle = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT ISNULL(MAX(Id_DepositoDet),0) FROM dbo.Deposito_Detalle")
            'cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT ISNULL(MAX(Id_DepositoDet),0) FROM dbo.Deposito_Detalle")
            cConexion.DesConectar(cConexion.sQlconexion)

            For i As Integer = 0 To DsAjusteBancario.AjusteBancario_Detalle.Count - 1
                Id_detalle += 1
                For x As Integer = 0 To DsAjusteBancario.CentroCosto_Movimientos.Count - 1
                    If Not Me.DsAjusteBancario.CentroCosto_Movimientos(i).RowState = DataRowState.Deleted Then
                        If DsAjusteBancario.CentroCosto_Movimientos.Item(x).IdDetalle = j Then
                            DsAjusteBancario.CentroCosto_Movimientos.Item(x).IdDetalle = Id_detalle
                            DsAjusteBancario.CentroCosto_Movimientos.Item(x).IdDetalleAux = Id_detalle
                            DsAjusteBancario.CentroCosto_Movimientos.Item(x).Documento = Me.DsAjusteBancario.AjusteBancario_Detalle(0).Id_Ajuste
                        End If
                    End If

                Next x
                j -= 1
            Next i
        End If
    End Sub
#End Region
    Private Sub txtCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCentroCosto.KeyDown

        'If e.KeyCode = Keys.Enter Then
        '    txtMontoCentroCosto.Text = CalcEdit2.Value
        '    txtMontoCentroCosto.SelectAll()
        '    txtMontoCentroCosto.Focus()
        'ElseIf e.KeyCode = Keys.F1 Then
        '    Dim bus As New frmCentroCosto
        '    If bus.ShowDialog = DialogResult.OK Then
        '        id_CentroCosto = bus.txtID.Text
        '        txtCentroCosto.Text = bus.txtCentro.Text

        '    End If
        'End If

    End Sub


#Region "Otras"
    Private Sub CBCentroCosto_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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



    Private Sub Panel_Ocultar()
        PanelCentroCosto.Left = -PanelCentroCosto.Width
    End Sub

    Private Sub Controles(ByVal estado As Boolean)
        txtCentroCosto.Enabled = estado
        txtMontoCentroCosto.Enabled = estado
        EditDescripcionCC.Enabled = estado
    End Sub
#End Region

#End Region
End Class
