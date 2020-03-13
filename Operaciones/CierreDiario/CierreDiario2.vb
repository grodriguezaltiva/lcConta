Imports System.Data.SqlClient
Imports Utilidades
Public Class CierreDiario2
    Inherits System.Windows.Forms.Form
    Dim usua As Object
    Dim Identificacion As String
    Dim TipoCambioE As Double
    Dim TipoCambioD As Double
    Dim MontoDeposito As Double
    Dim totalArqueo As Double = 0
    Dim NombreUsuario As String
    Dim Faltante As Double = 0
    Dim Sobrante As Double = 0
    Dim totalSistema As Double = 0
    Dim clave As String = ""
    Dim travelCheke As Double = 0
    Dim tranColones As Double = 0
    Dim tranDolares As Double = 0
    Dim dtTranferencias As New DataTable
    Dim DifAsiento As Double
    Dim CodMoneda As Integer
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
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotalVentas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtVentasCredito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVentasContado As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEurosColones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtEuros As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDolaresColones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDolares As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalColones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colNombreCajero As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDeposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMontoDeposito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents TextEdit8 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TextEdit9 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextEdit10 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adCierreDiario As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adCierreDepositos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adCierreTarjetas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents adCierreCajas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adCuentasBancarias As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents DsCierreDiario1 As Contabilidad.dsCierreDiario
    Friend WithEvents txtTarjetaDolares As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalTarjetas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTarjetaDolaresColones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTarjetaColones As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtTotalEfectivo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCobroFacturas As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtSobrante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtFaltante As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cbCuentaBancaria As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoDep As DevExpress.XtraEditors.TextEdit
    Friend WithEvents dtFechaDeposito As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar2 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtDeposito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents colMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents labeldeposito As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrepagos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtVentasInHouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtCobroClientes As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPrepagosApli As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents TextEditMontoDeposito As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TextEditDepositar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents TextBoxComisiones As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents ButtonVer As System.Windows.Forms.Button
    Friend WithEvents DsIngresos1 As Contabilidad.dsIngresos
    Friend WithEvents ButtonVerAsiento As System.Windows.Forms.Button
    Friend WithEvents GroupBoxRevisar As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxCheck1 As System.Windows.Forms.CheckBox
    Friend WithEvents ButtonDiferencias As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxDistribuirDiferencial As System.Windows.Forms.GroupBox
    Friend WithEvents GridControlDiferencias As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelDeferencialC As System.Windows.Forms.Label
    Friend WithEvents TextBoxDiferencial As System.Windows.Forms.TextBox
    Friend WithEvents ButtonConta As System.Windows.Forms.Button
    Friend WithEvents ButtonListo As System.Windows.Forms.Button
    Friend WithEvents adAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ButtonGasto As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents TextEditTravelCheck As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ButtonImportarDep As System.Windows.Forms.Button
    Friend WithEvents ButtonAperturas As System.Windows.Forms.Button
    Friend WithEvents TextEditAdelantos As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label38 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CierreDiario2))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.DsCierreDiario1 = New Contabilidad.dsCierreDiario
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ButtonVer = New System.Windows.Forms.Button
        Me.Label34 = New System.Windows.Forms.Label
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.txtPrepagosApli = New DevExpress.XtraEditors.TextEdit
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtPrepagos = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.txtCobroClientes = New DevExpress.XtraEditors.TextEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCobroFacturas = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.txtTarjetaDolares = New DevExpress.XtraEditors.TextEdit
        Me.txtTotalTarjetas = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTarjetaDolaresColones = New DevExpress.XtraEditors.TextEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtTarjetaColones = New DevExpress.XtraEditors.TextEdit
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.TextEdit8 = New DevExpress.XtraEditors.TextEdit
        Me.Label15 = New System.Windows.Forms.Label
        Me.TextEdit9 = New DevExpress.XtraEditors.TextEdit
        Me.Label16 = New System.Windows.Forms.Label
        Me.TextEdit10 = New DevExpress.XtraEditors.TextEdit
        Me.Label17 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TextEditAdelantos = New DevExpress.XtraEditors.TextEdit
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtSobrante = New DevExpress.XtraEditors.TextEdit
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtFaltante = New DevExpress.XtraEditors.TextEdit
        Me.Label18 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colNombreCajero = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.TextEditTravelCheck = New DevExpress.XtraEditors.TextEdit
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtTotalEfectivo = New DevExpress.XtraEditors.TextEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEurosColones = New DevExpress.XtraEditors.TextEdit
        Me.txtEuros = New DevExpress.XtraEditors.TextEdit
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDolaresColones = New DevExpress.XtraEditors.TextEdit
        Me.txtDolares = New DevExpress.XtraEditors.TextEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTotalColones = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtVentasInHouse = New DevExpress.XtraEditors.TextEdit
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalVentas = New DevExpress.XtraEditors.TextEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtVentasCredito = New DevExpress.XtraEditors.TextEdit
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtVentasContado = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxComisiones = New System.Windows.Forms.TextBox
        Me.ButtonVerAsiento = New System.Windows.Forms.Button
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.ButtonGasto = New System.Windows.Forms.Button
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.TextEditDepositar = New DevExpress.XtraEditors.TextEdit
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextEditMontoDeposito = New DevExpress.XtraEditors.TextEdit
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtDeposito = New DevExpress.XtraEditors.TextEdit
        Me.labeldeposito = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ToolBar2 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.cbCuentaBancaria = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtMontoDep = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtFechaDeposito = New System.Windows.Forms.DateTimePicker
        Me.Label21 = New System.Windows.Forms.Label
        Me.cbMoneda = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.GridControl3 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colMoneda = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colMontoDeposito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDeposito = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.adCierreDiario = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adCierreDepositos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adCierreTarjetas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.adCierreCajas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.adMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.adCuentasBancarias = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.txtId = New System.Windows.Forms.TextBox
        Me.DsIngresos1 = New Contabilidad.dsIngresos
        Me.GroupBoxRevisar = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.ButtonDiferencias = New System.Windows.Forms.Button
        Me.CheckBoxCheck1 = New System.Windows.Forms.CheckBox
        Me.GroupBoxDistribuirDiferencial = New System.Windows.Forms.GroupBox
        Me.ButtonListo = New System.Windows.Forms.Button
        Me.ButtonConta = New System.Windows.Forms.Button
        Me.TextBoxDiferencial = New System.Windows.Forms.TextBox
        Me.LabelDeferencialC = New System.Windows.Forms.Label
        Me.GridControlDiferencias = New DevExpress.XtraGrid.GridControl
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.adAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand4 = New System.Data.SqlClient.SqlCommand
        Me.adDetalleAsiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand8 = New System.Data.SqlClient.SqlCommand
        Me.ButtonImportarDep = New System.Windows.Forms.Button
        Me.ButtonAperturas = New System.Windows.Forms.Button
        CType(Me.DsCierreDiario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.txtPrepagosApli.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrepagos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.txtCobroClientes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCobroFacturas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.txtTarjetaDolares.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalTarjetas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarjetaDolaresColones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTarjetaColones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.TextEditAdelantos.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSobrante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFaltante.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TextEditTravelCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalEfectivo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEurosColones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEuros.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolaresColones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDolares.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalColones.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtVentasInHouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalVentas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVentasCredito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVentasContado.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.TextEditDepositar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextEditMontoDeposito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeposito.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtMontoDep.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxRevisar.SuspendLayout()
        Me.GroupBoxDistribuirDiferencial.SuspendLayout()
        CType(Me.GridControlDiferencias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(960, 32)
        Me.TituloModulo.TabIndex = 70
        Me.TituloModulo.Text = "Cierre Diario General Fecha:"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 514)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(960, 52)
        Me.ToolBar1.TabIndex = 71
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
        'ToolBarImprimir
        '
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
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(608, 8)
        Me.dtFecha.MaxDate = New Date(2090, 1, 1, 0, 0, 0, 0)
        Me.dtFecha.MinDate = New Date(1999, 1, 1, 0, 0, 0, 0)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtFecha.TabIndex = 73
        Me.dtFecha.Value = New Date(2007, 11, 29, 0, 0, 0, 0)
        '
        'DsCierreDiario1
        '
        Me.DsCierreDiario1.DataSetName = "dsCierreDiario"
        Me.DsCierreDiario1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DsCierreDiario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.ButtonVer)
        Me.Panel1.Controls.Add(Me.Label34)
        Me.Panel1.Controls.Add(Me.GroupBox7)
        Me.Panel1.Controls.Add(Me.GroupBox6)
        Me.Panel1.Controls.Add(Me.GroupBox9)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.TextBoxComisiones)
        Me.Panel1.Location = New System.Drawing.Point(8, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 480)
        Me.Panel1.TabIndex = 74
        '
        'ButtonVer
        '
        Me.ButtonVer.Location = New System.Drawing.Point(104, 192)
        Me.ButtonVer.Name = "ButtonVer"
        Me.ButtonVer.Size = New System.Drawing.Size(40, 23)
        Me.ButtonVer.TabIndex = 94
        Me.ButtonVer.Text = "Ver"
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 176)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(100, 16)
        Me.Label34.TabIndex = 93
        Me.Label34.Text = "Comisiones"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtPrepagosApli)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.txtPrepagos)
        Me.GroupBox7.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox7.Location = New System.Drawing.Point(280, 0)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(120, 96)
        Me.GroupBox7.TabIndex = 92
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Prepagos"
        '
        'txtPrepagosApli
        '
        Me.txtPrepagosApli.EditValue = "0.00"
        Me.txtPrepagosApli.Location = New System.Drawing.Point(16, 72)
        Me.txtPrepagosApli.Name = "txtPrepagosApli"
        '
        '
        '
        Me.txtPrepagosApli.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPrepagosApli.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrepagosApli.Properties.ReadOnly = True
        Me.txtPrepagosApli.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtPrepagosApli.Size = New System.Drawing.Size(88, 17)
        Me.txtPrepagosApli.TabIndex = 95
        '
        'Label29
        '
        Me.Label29.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label29.Location = New System.Drawing.Point(8, 56)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(99, 16)
        Me.Label29.TabIndex = 94
        Me.Label29.Text = "Aplicados"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label28.Location = New System.Drawing.Point(8, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(99, 16)
        Me.Label28.TabIndex = 93
        Me.Label28.Text = "Recibidos"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrepagos
        '
        Me.txtPrepagos.EditValue = "0.00"
        Me.txtPrepagos.Location = New System.Drawing.Point(15, 31)
        Me.txtPrepagos.Name = "txtPrepagos"
        '
        '
        '
        Me.txtPrepagos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtPrepagos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtPrepagos.Properties.ReadOnly = True
        Me.txtPrepagos.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtPrepagos.Size = New System.Drawing.Size(88, 17)
        Me.txtPrepagos.TabIndex = 92
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.txtCobroClientes)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txtCobroFacturas)
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox6.Location = New System.Drawing.Point(152, 0)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(120, 96)
        Me.GroupBox6.TabIndex = 91
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cobros"
        '
        'txtCobroClientes
        '
        Me.txtCobroClientes.EditValue = "0.00"
        Me.txtCobroClientes.Location = New System.Drawing.Point(8, 72)
        Me.txtCobroClientes.Name = "txtCobroClientes"
        '
        '
        '
        Me.txtCobroClientes.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCobroClientes.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCobroClientes.Properties.ReadOnly = True
        Me.txtCobroClientes.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtCobroClientes.Size = New System.Drawing.Size(104, 17)
        Me.txtCobroClientes.TabIndex = 94
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(11, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 16)
        Me.Label11.TabIndex = 93
        Me.Label11.Text = "Clientes"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label10.Location = New System.Drawing.Point(13, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 16)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "In House"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCobroFacturas
        '
        Me.txtCobroFacturas.EditValue = "0.00"
        Me.txtCobroFacturas.Location = New System.Drawing.Point(12, 32)
        Me.txtCobroFacturas.Name = "txtCobroFacturas"
        '
        '
        '
        Me.txtCobroFacturas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtCobroFacturas.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtCobroFacturas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCobroFacturas.Properties.ReadOnly = True
        Me.txtCobroFacturas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtCobroFacturas.Size = New System.Drawing.Size(100, 17)
        Me.txtCobroFacturas.TabIndex = 91
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.txtTarjetaDolares)
        Me.GroupBox9.Controls.Add(Me.txtTotalTarjetas)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.txtTarjetaDolaresColones)
        Me.GroupBox9.Controls.Add(Me.Label13)
        Me.GroupBox9.Controls.Add(Me.txtTarjetaColones)
        Me.GroupBox9.Controls.Add(Me.Label14)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox9.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(312, 88)
        Me.GroupBox9.TabIndex = 87
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Detalle Tarjetas"
        '
        'txtTarjetaDolares
        '
        Me.txtTarjetaDolares.EditValue = "0.00"
        Me.txtTarjetaDolares.Location = New System.Drawing.Point(96, 35)
        Me.txtTarjetaDolares.Name = "txtTarjetaDolares"
        '
        '
        '
        Me.txtTarjetaDolares.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTarjetaDolares.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTarjetaDolares.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTarjetaDolares.Properties.ReadOnly = True
        Me.txtTarjetaDolares.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTarjetaDolares.Size = New System.Drawing.Size(72, 17)
        Me.txtTarjetaDolares.TabIndex = 88
        '
        'txtTotalTarjetas
        '
        Me.txtTotalTarjetas.EditValue = "0.00"
        Me.txtTotalTarjetas.Location = New System.Drawing.Point(174, 56)
        Me.txtTotalTarjetas.Name = "txtTotalTarjetas"
        '
        '
        '
        Me.txtTotalTarjetas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotalTarjetas.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotalTarjetas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalTarjetas.Properties.ReadOnly = True
        Me.txtTotalTarjetas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTotalTarjetas.Size = New System.Drawing.Size(120, 17)
        Me.txtTotalTarjetas.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label12.Location = New System.Drawing.Point(8, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Total Tarjetas"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTarjetaDolaresColones
        '
        Me.txtTarjetaDolaresColones.EditValue = "0.00"
        Me.txtTarjetaDolaresColones.Location = New System.Drawing.Point(174, 34)
        Me.txtTarjetaDolaresColones.Name = "txtTarjetaDolaresColones"
        '
        '
        '
        Me.txtTarjetaDolaresColones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTarjetaDolaresColones.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTarjetaDolaresColones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTarjetaDolaresColones.Properties.ReadOnly = True
        Me.txtTarjetaDolaresColones.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTarjetaDolaresColones.Size = New System.Drawing.Size(120, 17)
        Me.txtTarjetaDolaresColones.TabIndex = 74
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label13.Location = New System.Drawing.Point(11, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Total Dólares:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTarjetaColones
        '
        Me.txtTarjetaColones.EditValue = "0.00"
        Me.txtTarjetaColones.Location = New System.Drawing.Point(175, 16)
        Me.txtTarjetaColones.Name = "txtTarjetaColones"
        '
        '
        '
        Me.txtTarjetaColones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTarjetaColones.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTarjetaColones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTarjetaColones.Properties.ReadOnly = True
        Me.txtTarjetaColones.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTarjetaColones.Size = New System.Drawing.Size(118, 17)
        Me.txtTarjetaColones.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(7, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 16)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Total Colones:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.TextEdit8)
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.TextEdit9)
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Controls.Add(Me.TextEdit10)
        Me.GroupBox10.Controls.Add(Me.Label17)
        Me.GroupBox10.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox10.Location = New System.Drawing.Point(0, 144)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(136, 136)
        Me.GroupBox10.TabIndex = 87
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Ventas del Día"
        '
        'TextEdit8
        '
        Me.TextEdit8.EditValue = "0.00"
        Me.TextEdit8.Location = New System.Drawing.Point(8, 112)
        Me.TextEdit8.Name = "TextEdit8"
        '
        '
        '
        Me.TextEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit8.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit8.Properties.ReadOnly = True
        Me.TextEdit8.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit8.Size = New System.Drawing.Size(120, 17)
        Me.TextEdit8.TabIndex = 76
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label15.Location = New System.Drawing.Point(8, 96)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(120, 16)
        Me.Label15.TabIndex = 75
        Me.Label15.Text = "Total Ventas"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit9
        '
        Me.TextEdit9.EditValue = "0.00"
        Me.TextEdit9.Location = New System.Drawing.Point(8, 71)
        Me.TextEdit9.Name = "TextEdit9"
        '
        '
        '
        Me.TextEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit9.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit9.Properties.ReadOnly = True
        Me.TextEdit9.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit9.Size = New System.Drawing.Size(120, 17)
        Me.TextEdit9.TabIndex = 74
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label16.Location = New System.Drawing.Point(11, 55)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 16)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Ventas Crédito"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextEdit10
        '
        Me.TextEdit10.EditValue = "0.00"
        Me.TextEdit10.Location = New System.Drawing.Point(7, 32)
        Me.TextEdit10.Name = "TextEdit10"
        '
        '
        '
        Me.TextEdit10.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEdit10.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit10.Properties.ReadOnly = True
        Me.TextEdit10.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEdit10.Size = New System.Drawing.Size(118, 17)
        Me.TextEdit10.TabIndex = 72
        '
        'Label17
        '
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label17.Location = New System.Drawing.Point(7, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 16)
        Me.Label17.TabIndex = 71
        Me.Label17.Text = "Ventas Contado"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TextEditAdelantos)
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.txtSobrante)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtFaltante)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.GridControl1)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox4.Location = New System.Drawing.Point(8, 312)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(432, 160)
        Me.GroupBox4.TabIndex = 86
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Diferencias en Caja"
        '
        'TextEditAdelantos
        '
        Me.TextEditAdelantos.EditValue = "0.00"
        Me.TextEditAdelantos.Location = New System.Drawing.Point(88, 136)
        Me.TextEditAdelantos.Name = "TextEditAdelantos"
        '
        '
        '
        Me.TextEditAdelantos.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEditAdelantos.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditAdelantos.Properties.ReadOnly = True
        Me.TextEditAdelantos.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEditAdelantos.Size = New System.Drawing.Size(88, 17)
        Me.TextEditAdelantos.TabIndex = 79
        '
        'Label38
        '
        Me.Label38.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label38.Location = New System.Drawing.Point(8, 136)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 16)
        Me.Label38.TabIndex = 78
        Me.Label38.Text = "Tot. Adelantos:"
        Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSobrante
        '
        Me.txtSobrante.EditValue = "0.00"
        Me.txtSobrante.Location = New System.Drawing.Point(328, 120)
        Me.txtSobrante.Name = "txtSobrante"
        '
        '
        '
        Me.txtSobrante.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtSobrante.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtSobrante.Properties.ReadOnly = True
        Me.txtSobrante.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtSobrante.Size = New System.Drawing.Size(88, 17)
        Me.txtSobrante.TabIndex = 77
        '
        'Label19
        '
        Me.Label19.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label19.Location = New System.Drawing.Point(232, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 16)
        Me.Label19.TabIndex = 76
        Me.Label19.Text = "Total Sobrante:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFaltante
        '
        Me.txtFaltante.EditValue = "0.00"
        Me.txtFaltante.Location = New System.Drawing.Point(88, 112)
        Me.txtFaltante.Name = "txtFaltante"
        '
        '
        '
        Me.txtFaltante.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtFaltante.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtFaltante.Properties.ReadOnly = True
        Me.txtFaltante.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtFaltante.Size = New System.Drawing.Size(88, 17)
        Me.txtFaltante.TabIndex = 75
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label18.Location = New System.Drawing.Point(8, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 16)
        Me.Label18.TabIndex = 72
        Me.Label18.Text = "Total Faltante:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "CierreDiario_DiferenciaCaja"
        Me.GridControl1.DataSource = Me.DsCierreDiario1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 16)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(416, 88)
        Me.GridControl1.TabIndex = 12
        Me.GridControl1.Text = "GridControl2"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNombreCajero, Me.colMonto})
        Me.GridView1.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsCustomization.AllowGroup = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colNombreCajero
        '
        Me.colNombreCajero.Caption = "Nombre del Cajero"
        Me.colNombreCajero.FieldName = "NombreCajero"
        Me.colNombreCajero.FilterInfo = ColumnFilterInfo1
        Me.colNombreCajero.Name = "colNombreCajero"
        Me.colNombreCajero.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colNombreCajero.VisibleIndex = 0
        Me.colNombreCajero.Width = 300
        '
        'colMonto
        '
        Me.colMonto.Caption = "Monto"
        Me.colMonto.DisplayFormat.FormatString = "#,#0.00"
        Me.colMonto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMonto.FieldName = "Monto"
        Me.colMonto.FilterInfo = ColumnFilterInfo2
        Me.colMonto.Name = "colMonto"
        Me.colMonto.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMonto.VisibleIndex = 1
        Me.colMonto.Width = 99
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label37)
        Me.GroupBox3.Controls.Add(Me.TextEditTravelCheck)
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.txtTotalEfectivo)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.txtEurosColones)
        Me.GroupBox3.Controls.Add(Me.txtEuros)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.txtDolaresColones)
        Me.GroupBox3.Controls.Add(Me.txtDolares)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtTotalColones)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox3.Location = New System.Drawing.Point(152, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(265, 112)
        Me.GroupBox3.TabIndex = 85
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle de Efectivos"
        '
        'Label37
        '
        Me.Label37.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label37.Location = New System.Drawing.Point(136, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(8, 16)
        Me.Label37.TabIndex = 98
        Me.Label37.Text = "¢"
        '
        'TextEditTravelCheck
        '
        Me.TextEditTravelCheck.EditValue = "0.00"
        Me.TextEditTravelCheck.Location = New System.Drawing.Point(144, 88)
        Me.TextEditTravelCheck.Name = "TextEditTravelCheck"
        '
        '
        '
        Me.TextEditTravelCheck.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEditTravelCheck.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditTravelCheck.Properties.ReadOnly = True
        Me.TextEditTravelCheck.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEditTravelCheck.Size = New System.Drawing.Size(112, 17)
        Me.TextEditTravelCheck.TabIndex = 97
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label35.Location = New System.Drawing.Point(8, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(104, 16)
        Me.Label35.TabIndex = 96
        Me.Label35.Text = "Travel Cheque:"
        '
        'Label27
        '
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label27.Location = New System.Drawing.Point(136, 72)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(8, 16)
        Me.Label27.TabIndex = 95
        Me.Label27.Text = "¢"
        '
        'Label26
        '
        Me.Label26.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label26.Location = New System.Drawing.Point(56, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(8, 16)
        Me.Label26.TabIndex = 94
        Me.Label26.Text = "€"
        '
        'Label25
        '
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label25.Location = New System.Drawing.Point(56, 32)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(8, 16)
        Me.Label25.TabIndex = 93
        Me.Label25.Text = "$"
        '
        'Label24
        '
        Me.Label24.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label24.Location = New System.Drawing.Point(136, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(8, 16)
        Me.Label24.TabIndex = 92
        Me.Label24.Text = "¢"
        '
        'txtTotalEfectivo
        '
        Me.txtTotalEfectivo.EditValue = "0.00"
        Me.txtTotalEfectivo.Location = New System.Drawing.Point(144, 72)
        Me.txtTotalEfectivo.Name = "txtTotalEfectivo"
        '
        '
        '
        Me.txtTotalEfectivo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotalEfectivo.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotalEfectivo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalEfectivo.Properties.ReadOnly = True
        Me.txtTotalEfectivo.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTotalEfectivo.Size = New System.Drawing.Size(112, 17)
        Me.txtTotalEfectivo.TabIndex = 91
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label9.Location = New System.Drawing.Point(4, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 16)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "Total Efectivo:"
        '
        'txtEurosColones
        '
        Me.txtEurosColones.EditValue = "0.00"
        Me.txtEurosColones.Location = New System.Drawing.Point(144, 48)
        Me.txtEurosColones.Name = "txtEurosColones"
        '
        '
        '
        Me.txtEurosColones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtEurosColones.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtEurosColones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEurosColones.Properties.ReadOnly = True
        Me.txtEurosColones.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtEurosColones.Size = New System.Drawing.Size(112, 17)
        Me.txtEurosColones.TabIndex = 89
        '
        'txtEuros
        '
        Me.txtEuros.EditValue = "0.00"
        Me.txtEuros.Location = New System.Drawing.Point(64, 48)
        Me.txtEuros.Name = "txtEuros"
        '
        '
        '
        Me.txtEuros.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtEuros.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtEuros.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtEuros.Properties.ReadOnly = True
        Me.txtEuros.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtEuros.Size = New System.Drawing.Size(80, 17)
        Me.txtEuros.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label8.Location = New System.Drawing.Point(7, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 16)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Euros:"
        '
        'txtDolaresColones
        '
        Me.txtDolaresColones.EditValue = "0.00"
        Me.txtDolaresColones.Location = New System.Drawing.Point(144, 32)
        Me.txtDolaresColones.Name = "txtDolaresColones"
        '
        '
        '
        Me.txtDolaresColones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDolaresColones.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDolaresColones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolaresColones.Properties.ReadOnly = True
        Me.txtDolaresColones.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDolaresColones.Size = New System.Drawing.Size(112, 17)
        Me.txtDolaresColones.TabIndex = 86
        '
        'txtDolares
        '
        Me.txtDolares.EditValue = "0.00"
        Me.txtDolares.Location = New System.Drawing.Point(64, 32)
        Me.txtDolares.Name = "txtDolares"
        '
        '
        '
        Me.txtDolares.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDolares.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDolares.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDolares.Properties.ReadOnly = True
        Me.txtDolares.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDolares.Size = New System.Drawing.Size(80, 17)
        Me.txtDolares.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label7.Location = New System.Drawing.Point(7, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 16)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Dólares:"
        '
        'txtTotalColones
        '
        Me.txtTotalColones.EditValue = "0.00"
        Me.txtTotalColones.Location = New System.Drawing.Point(152, 16)
        Me.txtTotalColones.Name = "txtTotalColones"
        '
        '
        '
        Me.txtTotalColones.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotalColones.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotalColones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalColones.Properties.ReadOnly = True
        Me.txtTotalColones.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTotalColones.Size = New System.Drawing.Size(104, 17)
        Me.txtTotalColones.TabIndex = 83
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label6.Location = New System.Drawing.Point(7, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 16)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Colones:"
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "Colones:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtVentasInHouse)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTotalVentas)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtVentasCredito)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtVentasContado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 160)
        Me.GroupBox1.TabIndex = 84
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ventas del Día"
        '
        'txtVentasInHouse
        '
        Me.txtVentasInHouse.EditValue = "0.00"
        Me.txtVentasInHouse.Location = New System.Drawing.Point(8, 64)
        Me.txtVentasInHouse.Name = "txtVentasInHouse"
        '
        '
        '
        Me.txtVentasInHouse.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtVentasInHouse.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVentasInHouse.Properties.ReadOnly = True
        Me.txtVentasInHouse.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtVentasInHouse.Size = New System.Drawing.Size(120, 17)
        Me.txtVentasInHouse.TabIndex = 78
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(8, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 16)
        Me.Label3.TabIndex = 77
        Me.Label3.Text = "Ventas In House"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalVentas
        '
        Me.txtTotalVentas.EditValue = "0.00"
        Me.txtTotalVentas.Location = New System.Drawing.Point(8, 135)
        Me.txtTotalVentas.Name = "txtTotalVentas"
        '
        '
        '
        Me.txtTotalVentas.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtTotalVentas.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtTotalVentas.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTotalVentas.Properties.ReadOnly = True
        Me.txtTotalVentas.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtTotalVentas.Size = New System.Drawing.Size(120, 17)
        Me.txtTotalVentas.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Total Ventas"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVentasCredito
        '
        Me.txtVentasCredito.EditValue = "0.00"
        Me.txtVentasCredito.Location = New System.Drawing.Point(8, 100)
        Me.txtVentasCredito.Name = "txtVentasCredito"
        '
        '
        '
        Me.txtVentasCredito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtVentasCredito.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtVentasCredito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVentasCredito.Properties.ReadOnly = True
        Me.txtVentasCredito.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtVentasCredito.Size = New System.Drawing.Size(120, 17)
        Me.txtVentasCredito.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Location = New System.Drawing.Point(11, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Ventas Crédito"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtVentasContado
        '
        Me.txtVentasContado.EditValue = "0.00"
        Me.txtVentasContado.Location = New System.Drawing.Point(7, 29)
        Me.txtVentasContado.Name = "txtVentasContado"
        '
        '
        '
        Me.txtVentasContado.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtVentasContado.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtVentasContado.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtVentasContado.Properties.ReadOnly = True
        Me.txtVentasContado.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtVentasContado.Size = New System.Drawing.Size(118, 17)
        Me.txtVentasContado.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(7, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Ventas Contado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBoxComisiones
        '
        Me.TextBoxComisiones.ForeColor = System.Drawing.Color.DarkRed
        Me.TextBoxComisiones.Location = New System.Drawing.Point(16, 192)
        Me.TextBoxComisiones.Name = "TextBoxComisiones"
        Me.TextBoxComisiones.Size = New System.Drawing.Size(88, 20)
        Me.TextBoxComisiones.TabIndex = 89
        Me.TextBoxComisiones.Text = "0"
        '
        'ButtonVerAsiento
        '
        Me.ButtonVerAsiento.Location = New System.Drawing.Point(8, 40)
        Me.ButtonVerAsiento.Name = "ButtonVerAsiento"
        Me.ButtonVerAsiento.Size = New System.Drawing.Size(72, 23)
        Me.ButtonVerAsiento.TabIndex = 95
        Me.ButtonVerAsiento.Text = "Asientos"
        Me.ButtonVerAsiento.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.txtObservaciones)
        Me.GroupBox11.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox11.Location = New System.Drawing.Point(600, 440)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(344, 72)
        Me.GroupBox11.TabIndex = 88
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Enabled = False
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 16)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(328, 48)
        Me.txtObservaciones.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(584, 544)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(72, 13)
        Me.Label36.TabIndex = 153
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Enabled = False
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreUsuario.Location = New System.Drawing.Point(712, 544)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(144, 13)
        Me.txtNombreUsuario.TabIndex = 154
        '
        'txtUsuario
        '
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(656, 544)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUsuario.Size = New System.Drawing.Size(48, 13)
        Me.txtUsuario.TabIndex = 152
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ButtonGasto)
        Me.GroupBox5.Controls.Add(Me.Label33)
        Me.GroupBox5.Controls.Add(Me.Label32)
        Me.GroupBox5.Controls.Add(Me.TextEditDepositar)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.TextEditMontoDeposito)
        Me.GroupBox5.Controls.Add(Me.Label31)
        Me.GroupBox5.Controls.Add(Me.txtDeposito)
        Me.GroupBox5.Controls.Add(Me.labeldeposito)
        Me.GroupBox5.Controls.Add(Me.Panel2)
        Me.GroupBox5.Controls.Add(Me.cbCuentaBancaria)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtMontoDep)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.dtFechaDeposito)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.cbMoneda)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.GridControl3)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox5.Location = New System.Drawing.Point(440, 32)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(512, 232)
        Me.GroupBox5.TabIndex = 155
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Detalle de Depósitos"
        '
        'ButtonGasto
        '
        Me.ButtonGasto.Enabled = False
        Me.ButtonGasto.Location = New System.Drawing.Point(312, 200)
        Me.ButtonGasto.Name = "ButtonGasto"
        Me.ButtonGasto.Size = New System.Drawing.Size(56, 23)
        Me.ButtonGasto.TabIndex = 185
        Me.ButtonGasto.Text = "Gasto"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label33.Location = New System.Drawing.Point(384, 192)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(104, 16)
        Me.Label33.TabIndex = 184
        Me.Label33.Text = "Total Depositos:"
        '
        'Label32
        '
        Me.Label32.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label32.Location = New System.Drawing.Point(176, 208)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(8, 16)
        Me.Label32.TabIndex = 183
        Me.Label32.Text = "¢"
        '
        'TextEditDepositar
        '
        Me.TextEditDepositar.EditValue = "0.00"
        Me.TextEditDepositar.Location = New System.Drawing.Point(192, 208)
        Me.TextEditDepositar.Name = "TextEditDepositar"
        '
        '
        '
        Me.TextEditDepositar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEditDepositar.Properties.DisplayFormat.FormatString = "##,#0.00"
        Me.TextEditDepositar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditDepositar.Properties.ReadOnly = True
        Me.TextEditDepositar.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEditDepositar.Size = New System.Drawing.Size(112, 17)
        Me.TextEditDepositar.TabIndex = 182
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label30.Location = New System.Drawing.Point(376, 208)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(8, 16)
        Me.Label30.TabIndex = 181
        Me.Label30.Text = "¢"
        '
        'TextEditMontoDeposito
        '
        Me.TextEditMontoDeposito.EditValue = "0.00"
        Me.TextEditMontoDeposito.Location = New System.Drawing.Point(392, 208)
        Me.TextEditMontoDeposito.Name = "TextEditMontoDeposito"
        '
        '
        '
        Me.TextEditMontoDeposito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TextEditMontoDeposito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEditMontoDeposito.Properties.ReadOnly = True
        Me.TextEditMontoDeposito.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.TextEditMontoDeposito.Size = New System.Drawing.Size(112, 17)
        Me.TextEditMontoDeposito.TabIndex = 180
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label31.Location = New System.Drawing.Point(176, 192)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(136, 16)
        Me.Label31.TabIndex = 179
        Me.Label31.Text = "Efectivo a Depositar:"
        '
        'txtDeposito
        '
        Me.txtDeposito.EditValue = ""
        Me.txtDeposito.Location = New System.Drawing.Point(432, 32)
        Me.txtDeposito.Name = "txtDeposito"
        '
        '
        '
        Me.txtDeposito.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtDeposito.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDeposito.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtDeposito.Size = New System.Drawing.Size(72, 17)
        Me.txtDeposito.TabIndex = 178
        '
        'labeldeposito
        '
        Me.labeldeposito.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.labeldeposito.Location = New System.Drawing.Point(424, 16)
        Me.labeldeposito.Name = "labeldeposito"
        Me.labeldeposito.Size = New System.Drawing.Size(72, 16)
        Me.labeldeposito.TabIndex = 177
        Me.labeldeposito.Text = "# Deposito"
        Me.labeldeposito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolBar2)
        Me.Panel2.Location = New System.Drawing.Point(8, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(168, 32)
        Me.Panel2.TabIndex = 176
        '
        'ToolBar2
        '
        Me.ToolBar2.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar2.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.ToolBarButton3, Me.ToolBarButton2})
        Me.ToolBar2.Divider = False
        Me.ToolBar2.DropDownArrows = True
        Me.ToolBar2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolBar2.ImageList = Me.ImageList2
        Me.ToolBar2.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar2.Name = "ToolBar2"
        Me.ToolBar2.ShowToolTips = True
        Me.ToolBar2.Size = New System.Drawing.Size(168, 40)
        Me.ToolBar2.TabIndex = 0
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 2
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Nuevo"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 0
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Text = "Eliminar"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Text = "Guardar"
        Me.ToolBarButton2.Visible = False
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "")
        Me.ImageList2.Images.SetKeyName(1, "")
        Me.ImageList2.Images.SetKeyName(2, "")
        '
        'cbCuentaBancaria
        '
        Me.cbCuentaBancaria.DataSource = Me.DsCierreDiario1.Cuentas_bancarias
        Me.cbCuentaBancaria.DisplayMember = "Cuenta"
        Me.cbCuentaBancaria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbCuentaBancaria.Location = New System.Drawing.Point(271, 31)
        Me.cbCuentaBancaria.Name = "cbCuentaBancaria"
        Me.cbCuentaBancaria.Size = New System.Drawing.Size(160, 21)
        Me.cbCuentaBancaria.TabIndex = 88
        Me.cbCuentaBancaria.ValueMember = "Cuenta"
        '
        'Label23
        '
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label23.Location = New System.Drawing.Point(271, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(160, 16)
        Me.Label23.TabIndex = 87
        Me.Label23.Text = "Cuenta Bancaria"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMontoDep
        '
        Me.txtMontoDep.EditValue = "0.00"
        Me.txtMontoDep.Location = New System.Drawing.Point(176, 32)
        Me.txtMontoDep.Name = "txtMontoDep"
        '
        '
        '
        Me.txtMontoDep.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txtMontoDep.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMontoDep.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoDep.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.RoyalBlue)
        Me.txtMontoDep.Size = New System.Drawing.Size(88, 17)
        Me.txtMontoDep.TabIndex = 86
        '
        'Label22
        '
        Me.Label22.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label22.Location = New System.Drawing.Point(169, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 76
        Me.Label22.Text = "Monto"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtFechaDeposito
        '
        Me.dtFechaDeposito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaDeposito.Location = New System.Drawing.Point(79, 32)
        Me.dtFechaDeposito.Name = "dtFechaDeposito"
        Me.dtFechaDeposito.Size = New System.Drawing.Size(87, 20)
        Me.dtFechaDeposito.TabIndex = 75
        '
        'Label21
        '
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label21.Location = New System.Drawing.Point(79, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(79, 16)
        Me.Label21.TabIndex = 74
        Me.Label21.Text = "Fecha"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbMoneda
        '
        Me.cbMoneda.DataSource = Me.DsCierreDiario1.Moneda
        Me.cbMoneda.DisplayMember = "MonedaNombre"
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.Location = New System.Drawing.Point(8, 32)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(64, 21)
        Me.cbMoneda.TabIndex = 73
        Me.cbMoneda.ValueMember = "CodMoneda"
        '
        'Label20
        '
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label20.Location = New System.Drawing.Point(4, 16)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 72
        Me.Label20.Text = "Moneda"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl3
        '
        Me.GridControl3.DataMember = "CierreDiario_Depositos"
        Me.GridControl3.DataSource = Me.DsCierreDiario1
        '
        '
        '
        Me.GridControl3.EmbeddedNavigator.Name = ""
        Me.GridControl3.Location = New System.Drawing.Point(8, 64)
        Me.GridControl3.MainView = Me.GridView3
        Me.GridControl3.Name = "GridControl3"
        Me.GridControl3.Size = New System.Drawing.Size(496, 128)
        Me.GridControl3.TabIndex = 12
        Me.GridControl3.Text = "GridControl2"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMoneda, Me.colFecha, Me.colMontoDeposito, Me.colDeposito, Me.colCuenta})
        Me.GridView3.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsCustomization.AllowGroup = False
        Me.GridView3.OptionsView.ShowFilterPanel = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        '
        'colMoneda
        '
        Me.colMoneda.Caption = "Moneda"
        Me.colMoneda.FieldName = "Moneda"
        Me.colMoneda.FilterInfo = ColumnFilterInfo3
        Me.colMoneda.Name = "colMoneda"
        Me.colMoneda.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMoneda.VisibleIndex = 0
        Me.colMoneda.Width = 65
        '
        'colFecha
        '
        Me.colFecha.Caption = "Fecha"
        Me.colFecha.FieldName = "Fecha"
        Me.colFecha.FilterInfo = ColumnFilterInfo4
        Me.colFecha.Name = "colFecha"
        Me.colFecha.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colFecha.VisibleIndex = 1
        Me.colFecha.Width = 73
        '
        'colMontoDeposito
        '
        Me.colMontoDeposito.Caption = "Monto"
        Me.colMontoDeposito.DisplayFormat.FormatString = "#,##0.00"
        Me.colMontoDeposito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colMontoDeposito.FieldName = "Monto"
        Me.colMontoDeposito.FilterInfo = ColumnFilterInfo5
        Me.colMontoDeposito.Name = "colMontoDeposito"
        Me.colMontoDeposito.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colMontoDeposito.VisibleIndex = 4
        Me.colMontoDeposito.Width = 84
        '
        'colDeposito
        '
        Me.colDeposito.Caption = "Depósito #"
        Me.colDeposito.FieldName = "Deposito"
        Me.colDeposito.FilterInfo = ColumnFilterInfo6
        Me.colDeposito.Name = "colDeposito"
        Me.colDeposito.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDeposito.VisibleIndex = 2
        Me.colDeposito.Width = 81
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta Ban."
        Me.colCuenta.FieldName = "CuentaBancaria"
        Me.colCuenta.FilterInfo = ColumnFilterInfo7
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCuenta.VisibleIndex = 3
        Me.colCuenta.Width = 98
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridControl2)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox2.Location = New System.Drawing.Point(448, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 168)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles Tarjetas de Crédito"
        '
        'GridControl2
        '
        Me.GridControl2.DataMember = "CierreDiario_DetalleTarjeta"
        Me.GridControl2.DataSource = Me.DsCierreDiario1
        '
        '
        '
        Me.GridControl2.EmbeddedNavigator.Name = ""
        Me.GridControl2.Location = New System.Drawing.Point(8, 16)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(488, 144)
        Me.GridControl2.TabIndex = 12
        Me.GridControl2.Text = "GridControl2"
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2})
        Me.GridView2.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsCustomization.AllowGroup = False
        Me.GridView2.OptionsView.ShowFilterPanel = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Monto"
        Me.GridColumn1.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn1.FieldName = "Monto"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo8
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 120
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Tipo Tarjeta"
        Me.GridColumn2.FieldName = "Tipo_Tarjeta"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo9
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 200
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=ISACC;packet size=4096;integrated security=SSPI;data source=Server" & _
            ";persist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'adCierreDiario
        '
        Me.adCierreDiario.DeleteCommand = Me.SqlDeleteCommand1
        Me.adCierreDiario.InsertCommand = Me.SqlInsertCommand1
        Me.adCierreDiario.SelectCommand = Me.SqlSelectCommand1
        Me.adCierreDiario.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreDiario", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("VentaContado", "VentaContado"), New System.Data.Common.DataColumnMapping("VentaCredito", "VentaCredito"), New System.Data.Common.DataColumnMapping("TotalVenta", "TotalVenta"), New System.Data.Common.DataColumnMapping("Colones", "Colones"), New System.Data.Common.DataColumnMapping("Dolares", "Dolares"), New System.Data.Common.DataColumnMapping("Euros", "Euros"), New System.Data.Common.DataColumnMapping("DolaresColones", "DolaresColones"), New System.Data.Common.DataColumnMapping("EurosColones", "EurosColones"), New System.Data.Common.DataColumnMapping("TotalEfectivo", "TotalEfectivo"), New System.Data.Common.DataColumnMapping("TarjetaColones", "TarjetaColones"), New System.Data.Common.DataColumnMapping("TarjetaDolares", "TarjetaDolares"), New System.Data.Common.DataColumnMapping("TotalTarjetas", "TotalTarjetas"), New System.Data.Common.DataColumnMapping("TotalFaltante", "TotalFaltante"), New System.Data.Common.DataColumnMapping("TotalSobrante", "TotalSobrante"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TarjetaDolaresCol", "TarjetaDolaresCol"), New System.Data.Common.DataColumnMapping("TotalCobro", "TotalCobro")})})
        Me.adCierreDiario.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Colones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Colones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DolaresColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DolaresColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Euros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Euros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EurosColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EurosColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolaresCol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolaresCol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCobro", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalEfectivo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalEfectivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalFaltante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalFaltante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalSobrante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalSobrante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalTarjetas", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalTarjetas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaContado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaCredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaCredito", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@VentaContado", System.Data.SqlDbType.Float, 8, "VentaContado"), New System.Data.SqlClient.SqlParameter("@VentaCredito", System.Data.SqlDbType.Float, 8, "VentaCredito"), New System.Data.SqlClient.SqlParameter("@TotalVenta", System.Data.SqlDbType.Float, 8, "TotalVenta"), New System.Data.SqlClient.SqlParameter("@Colones", System.Data.SqlDbType.Float, 8, "Colones"), New System.Data.SqlClient.SqlParameter("@Dolares", System.Data.SqlDbType.Float, 8, "Dolares"), New System.Data.SqlClient.SqlParameter("@Euros", System.Data.SqlDbType.Float, 8, "Euros"), New System.Data.SqlClient.SqlParameter("@DolaresColones", System.Data.SqlDbType.Float, 8, "DolaresColones"), New System.Data.SqlClient.SqlParameter("@EurosColones", System.Data.SqlDbType.Float, 8, "EurosColones"), New System.Data.SqlClient.SqlParameter("@TotalEfectivo", System.Data.SqlDbType.Float, 8, "TotalEfectivo"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@TotalTarjetas", System.Data.SqlDbType.Float, 8, "TotalTarjetas"), New System.Data.SqlClient.SqlParameter("@TotalFaltante", System.Data.SqlDbType.Float, 8, "TotalFaltante"), New System.Data.SqlClient.SqlParameter("@TotalSobrante", System.Data.SqlDbType.Float, 8, "TotalSobrante"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 500, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TarjetaDolaresCol", System.Data.SqlDbType.Float, 8, "TarjetaDolaresCol"), New System.Data.SqlClient.SqlParameter("@TotalCobro", System.Data.SqlDbType.Float, 8, "TotalCobro")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@VentaContado", System.Data.SqlDbType.Float, 8, "VentaContado"), New System.Data.SqlClient.SqlParameter("@VentaCredito", System.Data.SqlDbType.Float, 8, "VentaCredito"), New System.Data.SqlClient.SqlParameter("@TotalVenta", System.Data.SqlDbType.Float, 8, "TotalVenta"), New System.Data.SqlClient.SqlParameter("@Colones", System.Data.SqlDbType.Float, 8, "Colones"), New System.Data.SqlClient.SqlParameter("@Dolares", System.Data.SqlDbType.Float, 8, "Dolares"), New System.Data.SqlClient.SqlParameter("@Euros", System.Data.SqlDbType.Float, 8, "Euros"), New System.Data.SqlClient.SqlParameter("@DolaresColones", System.Data.SqlDbType.Float, 8, "DolaresColones"), New System.Data.SqlClient.SqlParameter("@EurosColones", System.Data.SqlDbType.Float, 8, "EurosColones"), New System.Data.SqlClient.SqlParameter("@TotalEfectivo", System.Data.SqlDbType.Float, 8, "TotalEfectivo"), New System.Data.SqlClient.SqlParameter("@TarjetaColones", System.Data.SqlDbType.Float, 8, "TarjetaColones"), New System.Data.SqlClient.SqlParameter("@TarjetaDolares", System.Data.SqlDbType.Float, 8, "TarjetaDolares"), New System.Data.SqlClient.SqlParameter("@TotalTarjetas", System.Data.SqlDbType.Float, 8, "TotalTarjetas"), New System.Data.SqlClient.SqlParameter("@TotalFaltante", System.Data.SqlDbType.Float, 8, "TotalFaltante"), New System.Data.SqlClient.SqlParameter("@TotalSobrante", System.Data.SqlDbType.Float, 8, "TotalSobrante"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 500, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 250, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TarjetaDolaresCol", System.Data.SqlDbType.Float, 8, "TarjetaDolaresCol"), New System.Data.SqlClient.SqlParameter("@TotalCobro", System.Data.SqlDbType.Float, 8, "TotalCobro"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Colones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Colones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Dolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Dolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DolaresColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DolaresColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Euros", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Euros", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_EurosColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "EurosColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 500, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaColones", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaColones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolares", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolares", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TarjetaDolaresCol", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TarjetaDolaresCol", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalCobro", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalCobro", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalEfectivo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalEfectivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalFaltante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalFaltante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalSobrante", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalSobrante", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalTarjetas", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalTarjetas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalVenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaContado", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaContado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_VentaCredito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "VentaCredito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'adCierreDepositos
        '
        Me.adCierreDepositos.DeleteCommand = Me.SqlDeleteCommand2
        Me.adCierreDepositos.InsertCommand = Me.SqlInsertCommand2
        Me.adCierreDepositos.SelectCommand = Me.SqlSelectCommand2
        Me.adCierreDepositos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreDiario_Depositos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_CierreDiario", "Id_CierreDiario"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("Deposito", "Deposito"), New System.Data.Common.DataColumnMapping("CuentaBancaria", "CuentaBancaria"), New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito")})})
        Me.adCierreDepositos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Deposito", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreDiario", System.Data.SqlDbType.Int, 4, "Id_CierreDiario"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.VarChar, 75, "Moneda"), New System.Data.SqlClient.SqlParameter("@Deposito", System.Data.SqlDbType.VarChar, 50, "Deposito"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 250, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.Int, 4, "Id_Deposito")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Id_CierreDiario, Fecha, Monto, Moneda, Deposito, CuentaBancaria, Id_De" & _
            "posito FROM CierreDiario_Depositos"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreDiario", System.Data.SqlDbType.Int, 4, "Id_CierreDiario"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.VarChar, 75, "Moneda"), New System.Data.SqlClient.SqlParameter("@Deposito", System.Data.SqlDbType.VarChar, 50, "Deposito"), New System.Data.SqlClient.SqlParameter("@CuentaBancaria", System.Data.SqlDbType.VarChar, 250, "CuentaBancaria"), New System.Data.SqlClient.SqlParameter("@Id_Deposito", System.Data.SqlDbType.Int, 4, "Id_Deposito"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaBancaria", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaBancaria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Deposito", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Deposito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Deposito", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'adCierreTarjetas
        '
        Me.adCierreTarjetas.DeleteCommand = Me.SqlDeleteCommand3
        Me.adCierreTarjetas.InsertCommand = Me.SqlInsertCommand3
        Me.adCierreTarjetas.SelectCommand = Me.SqlSelectCommand3
        Me.adCierreTarjetas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreDiario_DetalleTarjeta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_CierreDiario", "Id_CierreDiario"), New System.Data.Common.DataColumnMapping("Documentos", "Documentos"), New System.Data.Common.DataColumnMapping("Tipo_Tarjeta", "Tipo_Tarjeta"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        Me.adCierreTarjetas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documentos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documentos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Tarjeta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Tarjeta", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreDiario", System.Data.SqlDbType.Int, 4, "Id_CierreDiario"), New System.Data.SqlClient.SqlParameter("@Documentos", System.Data.SqlDbType.Int, 4, "Documentos"), New System.Data.SqlClient.SqlParameter("@Tipo_Tarjeta", System.Data.SqlDbType.VarChar, 250, "Tipo_Tarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Id_CierreDiario, Documentos, Tipo_Tarjeta, Monto FROM CierreDiario_Det" & _
            "alleTarjeta"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreDiario", System.Data.SqlDbType.Int, 4, "Id_CierreDiario"), New System.Data.SqlClient.SqlParameter("@Documentos", System.Data.SqlDbType.Int, 4, "Documentos"), New System.Data.SqlClient.SqlParameter("@Tipo_Tarjeta", System.Data.SqlDbType.VarChar, 250, "Tipo_Tarjeta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Documentos", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documentos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo_Tarjeta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo_Tarjeta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'adCierreCajas
        '
        Me.adCierreCajas.DeleteCommand = Me.SqlDeleteCommand4
        Me.adCierreCajas.InsertCommand = Me.SqlInsertCommand4
        Me.adCierreCajas.SelectCommand = Me.SqlSelectCommand4
        Me.adCierreCajas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CierreDiario_DiferenciaCaja", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Id_CierreDiario", "Id_CierreDiario"), New System.Data.Common.DataColumnMapping("NombreCajero", "NombreCajero"), New System.Data.Common.DataColumnMapping("Monto", "Monto")})})
        Me.adCierreCajas.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM CierreDiario_DiferenciaCaja WHERE (Id = @Original_Id) AND (Id_CierreD" & _
            "iario = @Original_Id_CierreDiario) AND (Monto = @Original_Monto) AND (NombreCaje" & _
            "ro = @Original_NombreCajero)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCajero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCajero", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreDiario", System.Data.SqlDbType.Int, 4, "Id_CierreDiario"), New System.Data.SqlClient.SqlParameter("@NombreCajero", System.Data.SqlDbType.VarChar, 250, "NombreCajero"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT Id, Id_CierreDiario, NombreCajero, Monto FROM CierreDiario_DiferenciaCaja"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Id_CierreDiario", System.Data.SqlDbType.Int, 4, "Id_CierreDiario"), New System.Data.SqlClient.SqlParameter("@NombreCajero", System.Data.SqlDbType.VarChar, 250, "NombreCajero"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_CierreDiario", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_CierreDiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCajero", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCajero", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'adMoneda
        '
        Me.adMoneda.InsertCommand = Me.SqlInsertCommand5
        Me.adMoneda.SelectCommand = Me.SqlSelectCommand5
        Me.adMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable")})})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo, CuentaContable " & _
            "FROM Moneda"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'adCuentasBancarias
        '
        Me.adCuentasBancarias.InsertCommand = Me.SqlInsertCommand6
        Me.adCuentasBancarias.SelectCommand = Me.SqlSelectCommand6
        Me.adCuentasBancarias.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("SaldoInicial", "SaldoInicial"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("ChequeInicial", "ChequeInicial"), New System.Data.Common.DataColumnMapping("ChequeFinal", "ChequeFinal"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha")})})
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = resources.GetString("SqlInsertCommand6.CommandText")
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 75, "Cuenta"), New System.Data.SqlClient.SqlParameter("@Codigo_banco", System.Data.SqlDbType.BigInt, 8, "Codigo_banco"), New System.Data.SqlClient.SqlParameter("@tipoCuenta", System.Data.SqlDbType.VarChar, 20, "tipoCuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@SaldoInicial", System.Data.SqlDbType.Float, 8, "SaldoInicial"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@ChequeInicial", System.Data.SqlDbType.Int, 4, "ChequeInicial"), New System.Data.SqlClient.SqlParameter("@ChequeFinal", System.Data.SqlDbType.Int, 4, "ChequeFinal"), New System.Data.SqlClient.SqlParameter("@Cod_Moneda", System.Data.SqlDbType.Int, 4, "Cod_Moneda"), New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 350, "NombreCuentaContable"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Cuenta, Codigo_banco, tipoCuenta, NombreCuenta, SaldoInicial, CuentaContab" & _
            "le, ChequeInicial, ChequeFinal, Cod_Moneda, Id_CuentaBancaria, NombreCuentaConta" & _
            "ble, Fecha FROM Cuentas_bancarias"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Location = New System.Drawing.Point(8, 16)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(144, 13)
        Me.txtId.TabIndex = 159
        '
        'DsIngresos1
        '
        Me.DsIngresos1.DataSetName = "dsIngresos"
        Me.DsIngresos1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsIngresos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBoxRevisar
        '
        Me.GroupBoxRevisar.Controls.Add(Me.CheckBox1)
        Me.GroupBoxRevisar.Controls.Add(Me.ButtonDiferencias)
        Me.GroupBoxRevisar.Controls.Add(Me.CheckBoxCheck1)
        Me.GroupBoxRevisar.Controls.Add(Me.ButtonVerAsiento)
        Me.GroupBoxRevisar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxRevisar.Location = New System.Drawing.Point(448, 440)
        Me.GroupBoxRevisar.Name = "GroupBoxRevisar"
        Me.GroupBoxRevisar.Size = New System.Drawing.Size(144, 72)
        Me.GroupBoxRevisar.TabIndex = 160
        Me.GroupBoxRevisar.TabStop = False
        Me.GroupBoxRevisar.Text = "Revisar"
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(80, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(56, 24)
        Me.CheckBox1.TabIndex = 98
        Me.CheckBox1.Text = "Listo"
        '
        'ButtonDiferencias
        '
        Me.ButtonDiferencias.Location = New System.Drawing.Point(8, 16)
        Me.ButtonDiferencias.Name = "ButtonDiferencias"
        Me.ButtonDiferencias.Size = New System.Drawing.Size(72, 23)
        Me.ButtonDiferencias.TabIndex = 97
        Me.ButtonDiferencias.Text = "Dif. Cajas"
        Me.ButtonDiferencias.Visible = False
        '
        'CheckBoxCheck1
        '
        Me.CheckBoxCheck1.Location = New System.Drawing.Point(80, 16)
        Me.CheckBoxCheck1.Name = "CheckBoxCheck1"
        Me.CheckBoxCheck1.Size = New System.Drawing.Size(48, 24)
        Me.CheckBoxCheck1.TabIndex = 96
        Me.CheckBoxCheck1.Text = "Listo"
        Me.CheckBoxCheck1.Visible = False
        '
        'GroupBoxDistribuirDiferencial
        '
        Me.GroupBoxDistribuirDiferencial.Controls.Add(Me.ButtonListo)
        Me.GroupBoxDistribuirDiferencial.Controls.Add(Me.ButtonConta)
        Me.GroupBoxDistribuirDiferencial.Controls.Add(Me.TextBoxDiferencial)
        Me.GroupBoxDistribuirDiferencial.Controls.Add(Me.LabelDeferencialC)
        Me.GroupBoxDistribuirDiferencial.Controls.Add(Me.GridControlDiferencias)
        Me.GroupBoxDistribuirDiferencial.Location = New System.Drawing.Point(624, 328)
        Me.GroupBoxDistribuirDiferencial.Name = "GroupBoxDistribuirDiferencial"
        Me.GroupBoxDistribuirDiferencial.Size = New System.Drawing.Size(408, 160)
        Me.GroupBoxDistribuirDiferencial.TabIndex = 161
        Me.GroupBoxDistribuirDiferencial.TabStop = False
        Me.GroupBoxDistribuirDiferencial.Text = "Contabilizar Diferencial"
        '
        'ButtonListo
        '
        Me.ButtonListo.Location = New System.Drawing.Point(320, 16)
        Me.ButtonListo.Name = "ButtonListo"
        Me.ButtonListo.Size = New System.Drawing.Size(72, 23)
        Me.ButtonListo.TabIndex = 17
        Me.ButtonListo.Text = "Listo"
        '
        'ButtonConta
        '
        Me.ButtonConta.Location = New System.Drawing.Point(232, 16)
        Me.ButtonConta.Name = "ButtonConta"
        Me.ButtonConta.Size = New System.Drawing.Size(56, 23)
        Me.ButtonConta.TabIndex = 16
        Me.ButtonConta.Text = "Distribuir"
        '
        'TextBoxDiferencial
        '
        Me.TextBoxDiferencial.Location = New System.Drawing.Point(128, 16)
        Me.TextBoxDiferencial.Name = "TextBoxDiferencial"
        Me.TextBoxDiferencial.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxDiferencial.TabIndex = 15
        Me.TextBoxDiferencial.Text = "0"
        Me.TextBoxDiferencial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDeferencialC
        '
        Me.LabelDeferencialC.Location = New System.Drawing.Point(16, 16)
        Me.LabelDeferencialC.Name = "LabelDeferencialC"
        Me.LabelDeferencialC.Size = New System.Drawing.Size(88, 23)
        Me.LabelDeferencialC.TabIndex = 14
        Me.LabelDeferencialC.Text = "Diferencial Caja:"
        '
        'GridControlDiferencias
        '
        Me.GridControlDiferencias.DataMember = "ContaDiferencial"
        Me.GridControlDiferencias.DataSource = Me.DsCierreDiario1
        '
        '
        '
        Me.GridControlDiferencias.EmbeddedNavigator.Name = ""
        Me.GridControlDiferencias.Location = New System.Drawing.Point(8, 40)
        Me.GridControlDiferencias.MainView = Me.GridView4
        Me.GridControlDiferencias.Name = "GridControlDiferencias"
        Me.GridControlDiferencias.Size = New System.Drawing.Size(384, 112)
        Me.GridControlDiferencias.TabIndex = 13
        Me.GridControlDiferencias.Text = "GridControl4"
        '
        'GridView4
        '
        Me.GridView4.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn3, Me.GridColumn4})
        Me.GridView4.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsCustomization.AllowGroup = False
        Me.GridView4.OptionsView.ShowFilterPanel = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Monto"
        Me.GridColumn3.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Monto"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo10
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 120
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Cuenta"
        Me.GridColumn4.FieldName = "NombreCuenta"
        Me.GridColumn4.FilterInfo = ColumnFilterInfo11
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 0
        Me.GridColumn4.Width = 200
        '
        'adAsientos
        '
        Me.adAsientos.DeleteCommand = Me.SqlCommand1
        Me.adAsientos.InsertCommand = Me.SqlCommand2
        Me.adAsientos.SelectCommand = Me.SqlCommand3
        Me.adAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.adAsientos.UpdateCommand = Me.SqlCommand4
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.SqlConnection1
        Me.SqlCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand2
        '
        Me.SqlCommand2.CommandText = resources.GetString("SqlCommand2.CommandText")
        Me.SqlCommand2.Connection = Me.SqlConnection1
        Me.SqlCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlCommand3
        '
        Me.SqlCommand3.CommandText = resources.GetString("SqlCommand3.CommandText")
        Me.SqlCommand3.Connection = Me.SqlConnection1
        '
        'SqlCommand4
        '
        Me.SqlCommand4.CommandText = resources.GetString("SqlCommand4.CommandText")
        Me.SqlCommand4.Connection = Me.SqlConnection1
        Me.SqlCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'adDetalleAsiento
        '
        Me.adDetalleAsiento.DeleteCommand = Me.SqlCommand5
        Me.adDetalleAsiento.InsertCommand = Me.SqlCommand6
        Me.adDetalleAsiento.SelectCommand = Me.SqlCommand7
        Me.adDetalleAsiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.adDetalleAsiento.UpdateCommand = Me.SqlCommand8
        '
        'SqlCommand5
        '
        Me.SqlCommand5.CommandText = resources.GetString("SqlCommand5.CommandText")
        Me.SqlCommand5.Connection = Me.SqlConnection1
        Me.SqlCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlCommand6
        '
        Me.SqlCommand6.CommandText = resources.GetString("SqlCommand6.CommandText")
        Me.SqlCommand6.Connection = Me.SqlConnection1
        Me.SqlCommand6.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio")})
        '
        'SqlCommand7
        '
        Me.SqlCommand7.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
            "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlCommand7.Connection = Me.SqlConnection1
        '
        'SqlCommand8
        '
        Me.SqlCommand8.CommandText = resources.GetString("SqlCommand8.CommandText")
        Me.SqlCommand8.Connection = Me.SqlConnection1
        Me.SqlCommand8.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'ButtonImportarDep
        '
        Me.ButtonImportarDep.Image = CType(resources.GetObject("ButtonImportarDep.Image"), System.Drawing.Image)
        Me.ButtonImportarDep.Location = New System.Drawing.Point(904, 0)
        Me.ButtonImportarDep.Name = "ButtonImportarDep"
        Me.ButtonImportarDep.Size = New System.Drawing.Size(40, 40)
        Me.ButtonImportarDep.TabIndex = 162
        Me.ButtonImportarDep.Visible = False
        '
        'ButtonAperturas
        '
        Me.ButtonAperturas.Image = CType(resources.GetObject("ButtonAperturas.Image"), System.Drawing.Image)
        Me.ButtonAperturas.Location = New System.Drawing.Point(696, 0)
        Me.ButtonAperturas.Name = "ButtonAperturas"
        Me.ButtonAperturas.Size = New System.Drawing.Size(40, 40)
        Me.ButtonAperturas.TabIndex = 186
        Me.ButtonAperturas.TextAlign = System.Drawing.ContentAlignment.TopLeft
        '
        'CierreDiario2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(960, 566)
        Me.Controls.Add(Me.ButtonAperturas)
        Me.Controls.Add(Me.ButtonImportarDep)
        Me.Controls.Add(Me.GroupBoxDistribuirDiferencial)
        Me.Controls.Add(Me.GroupBoxRevisar)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.GroupBox11)
        Me.MaximizeBox = False
        Me.Name = "CierreDiario2"
        Me.Text = "Cierre Diario"
        CType(Me.DsCierreDiario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.txtPrepagosApli.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrepagos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.txtCobroClientes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCobroFacturas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.txtTarjetaDolares.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalTarjetas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarjetaDolaresColones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTarjetaColones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.TextEdit8.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit9.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEdit10.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.TextEditAdelantos.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSobrante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFaltante.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.TextEditTravelCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalEfectivo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEurosColones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEuros.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolaresColones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDolares.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalColones.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.txtVentasInHouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalVentas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVentasCredito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVentasContado.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.TextEditDepositar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextEditMontoDeposito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeposito.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txtMontoDep.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxRevisar.ResumeLayout(False)
        Me.GroupBoxDistribuirDiferencial.ResumeLayout(False)
        Me.GroupBoxDistribuirDiferencial.PerformLayout()
        CType(Me.GridControlDiferencias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub CierreDiario2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            Bloquear()

            adMoneda.Fill(DsCierreDiario1, "Moneda")
            adCuentasBancarias.Fill(DsCierreDiario1, "Cuentas_bancarias")
            DefaulValue() 'valores por defecto
            bindings()

            ToolBar1.Buttons(0).Enabled = False
            ToolBar1.Buttons(1).Enabled = False
            ToolBar1.Buttons(2).Enabled = False
            ToolBar1.Buttons(3).Enabled = False
            ToolBar1.Buttons(4).Enabled = True
            DeshabilitarDepositos()
            clave = Configuracion.Claves.Configuracion("Clave")
            If clave.Equals("") Then
                SaveSetting("seesoft", "seguridad", "clave", "1")
            End If
            If Configuracion.Claves.Configuracion("Clave") = "0" Then
                NombreUsuario = usua.Nombre
                txtNombreUsuario.Text = usua.Nombre
                txtUsuario.Enabled = False
                ToolBar1.Buttons(0).Enabled = True
                ToolBar1.Buttons(1).Enabled = True
            Else
                txtUsuario.Focus()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DefaulValue()
        'Cierre Diario
        DsCierreDiario1.CierreDiario.FechaColumn.DefaultValue = Now
        DsCierreDiario1.CierreDiario.VentaContadoColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.VentaCreditoColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TotalVentaColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.ColonesColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.DolaresColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.EurosColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.DolaresColonesColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.EurosColonesColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TotalEfectivoColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TarjetaColonesColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TarjetaDolaresColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TarjetaDolaresColColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TotalTarjetasColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TotalFaltanteColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.TotalSobranteColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.ObservacionesColumn.DefaultValue = ""
        DsCierreDiario1.CierreDiario.NombreUsuarioColumn.DefaultValue = ""
        DsCierreDiario1.CierreDiario.TotalCobroColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario.ObservacionesColumn.DefaultValue = ""

        'Cierre Diario Depositos
        DsCierreDiario1.CierreDiario_Depositos.FechaColumn.DefaultValue = Now
        DsCierreDiario1.CierreDiario_Depositos.MontoColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario_Depositos.MonedaColumn.DefaultValue = ""
        DsCierreDiario1.CierreDiario_Depositos.DepositoColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario_Depositos.CuentaBancariaColumn.DefaultValue = ""
        DsCierreDiario1.CierreDiario_Depositos.NuevoColumn.DefaultValue = 0


        'Cierre Diario DetalleTarjeta
        DsCierreDiario1.CierreDiario_DetalleTarjeta.DocumentosColumn.DefaultValue = 0
        DsCierreDiario1.CierreDiario_DetalleTarjeta.Tipo_TarjetaColumn.DefaultValue = ""
        DsCierreDiario1.CierreDiario_DetalleTarjeta.MontoColumn.DefaultValue = 0

        'Cierre Diario Diferencia Caja
        DsCierreDiario1.CierreDiario_DiferenciaCaja.NombreCajeroColumn.DefaultValue = ""
        DsCierreDiario1.CierreDiario_DiferenciaCaja.MontoColumn.DefaultValue = 0

        DsCierreDiario1.CierreDiario.IdColumn.AutoIncrement = True
        DsCierreDiario1.CierreDiario.IdColumn.AutoIncrementSeed = -1
        DsCierreDiario1.CierreDiario.IdColumn.AutoIncrementStep = -1

        DsCierreDiario1.CierreDiario_Depositos.IdColumn.AutoIncrement = True
        DsCierreDiario1.CierreDiario_Depositos.IdColumn.AutoIncrementSeed = -1
        DsCierreDiario1.CierreDiario_Depositos.IdColumn.AutoIncrementStep = -1

        DsCierreDiario1.CierreDiario_DetalleTarjeta.IdColumn.AutoIncrement = True
        DsCierreDiario1.CierreDiario_DetalleTarjeta.IdColumn.AutoIncrementSeed = -1
        DsCierreDiario1.CierreDiario_DetalleTarjeta.IdColumn.AutoIncrementStep = -1

        DsCierreDiario1.CierreDiario_DiferenciaCaja.IdColumn.AutoIncrement = True
        DsCierreDiario1.CierreDiario_DiferenciaCaja.IdColumn.AutoIncrementSeed = -1
        DsCierreDiario1.CierreDiario_DiferenciaCaja.IdColumn.AutoIncrementStep = -1

        Me.GroupBoxDistribuirDiferencial.Visible = False

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
    Private Sub bindings()
        'Cierre Diario
        txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCierreDiario1, "CierreDiario.Id"))
        dtFecha.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCierreDiario1, "CierreDiario.Fecha"))
        txtVentasContado.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.VentaContado"))
        txtVentasCredito.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.VentaCredito"))
        txtTotalVentas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TotalVenta"))
        txtTotalColones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.Colones"))
        txtDolares.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.Dolares"))
        txtEuros.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.Euros"))
        txtDolaresColones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.DolaresColones"))
        txtEurosColones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.EurosColones"))
        txtTotalEfectivo.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TotalEfectivo"))
        txtTarjetaColones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TarjetaColones"))
        txtTarjetaDolares.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TarjetaDolares"))
        txtTarjetaDolaresColones.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TarjetaDolaresCol"))
        txtTotalTarjetas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TotalTarjetas"))
        txtFaltante.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TotalFaltante"))
        txtSobrante.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TotalSobrante"))
        txtObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCierreDiario1, "CierreDiario.Observaciones"))
        txtNombreUsuario.DataBindings.Add(New System.Windows.Forms.Binding("text", DsCierreDiario1, "CierreDiario.NombreUsuario"))
        txtCobroFacturas.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.TotalCobro"))

        DsCierreDiario1.CierreDiario_Depositos.MonedaColumn.DefaultValue = "COLON"
        cbMoneda.Text = "COLON"
        DsCierreDiario1.CierreDiario_Depositos.FechaColumn.DefaultValue = Now
        DsCierreDiario1.CierreDiario_Depositos.CuentaBancariaColumn.DefaultValue = DsCierreDiario1.Cuentas_bancarias(0).Cuenta
        DsCierreDiario1.CierreDiario_Depositos.DepositoColumn.DefaultValue = 0
        'cbMoneda.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos.Moneda"))
        ''CierreDiario_Depositos
        'cbMoneda.DataSource = DsCierreDiario1.Moneda
        'cbMoneda.DisplayMember = "MonedaNombre"
        'cbMoneda.ValueMember = "CodMoneda"
        'Try
        'Catch ex As Exception

        'End Try
        'dtFechaDeposito.DataBindings.Add(New System.Windows.Forms.Binding("Text", DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos.Fecha"))
        'txtMontoDep.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos.Monto"))
        'cbCuentaBancaria.DataSource = DsCierreDiario1.Cuentas_bancarias
        'cbCuentaBancaria.DisplayMember = "Cuenta"
        'cbCuentaBancaria.ValueMember = "Cuenta"
        'cbCuentaBancaria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos.CuentaBancaria"))
        ' txtDeposito.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos.Deposito"))


    End Sub
    Private Sub Bloquear()
        dtFecha.Enabled = False
        Panel1.Enabled = False
        GroupBox5.Enabled = False
        GroupBox2.Enabled = False
        Me.GroupBoxDistribuirDiferencial.Enabled = False
        Me.GroupBoxRevisar.Enabled = False
    End Sub
    Private Sub DesBloquear()
        dtFecha.Enabled = True
        Panel1.Enabled = True
        GroupBox5.Enabled = True
        GroupBox2.Enabled = True
        Me.GroupBoxDistribuirDiferencial.Enabled = True
        Me.GroupBoxRevisar.Enabled = True
    End Sub
    Private Sub HabilitarDepositos()
        cbMoneda.Enabled = True
        dtFechaDeposito.Enabled = False
        txtMontoDep.Enabled = False
        txtDeposito.Enabled = False
        cbCuentaBancaria.Enabled = False
    End Sub
    Private Sub DeshabilitarDepositos()
        cbMoneda.Enabled = False
        dtFechaDeposito.Enabled = False
        txtMontoDep.Enabled = False
        txtDeposito.Enabled = False
        cbCuentaBancaria.Enabled = False
    End Sub

#End Region

#Region "Funciones"

    Private Sub verCajas()
        Dim vCajas As New FormCajas
        vCajas.fecha = dtFecha.Value
        vCajas.ShowDialog()
    End Sub
    Private Sub CargarDatos()
        totalArqueo = 0
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim VentaContado, VentaInHouse, VentaCredito, TotalVenta, TotalAdicionales As Double
        Faltante = 0 : Sobrante = 0
        Dim FechaNueva As Date
        Dim Colones, Dolares, Euros, DolaresColones, EurosColones As Double
        Dim BaseDatos As SqlDataReader
        Dim sqlconexion1 As SqlClient.SqlConnection
        Dim cconexion1 As New Conexion
        Dim sqlconexion2 As SqlClient.SqlConnection
        Dim cconexion2 As New Conexion
        Dim TarjetaColones, TarjetaDolares, TarjetaDolaresColones As Double
        Dim CajasAbiertas As Double
        Dim NumeroAperturas As SqlDataReader
        Dim MontoArqueo, MontoCierre, DifCaja, dAbonos As Double
        Dim totalComisiones As Double = 0
        travelCheke = 0
        tranColones = 0
        tranDolares = 0

        Dim TarjetasCredito As SqlDataReader
        Dim Depositos As SqlDataReader
        totalSistema = 0
        FechaNueva = dtFecha.Value.Date.AddDays(1)
        DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
        sqlconexion = cconexion.Conectar("SeeSoft", "Hotel")
        'Consulta Efectivo en Colones en tabla arqueo caja
        BaseDatos = cconexion.GetRecorset(sqlconexion, "Select distinct(BaseDatos) from PuntoVenta Where Nombre <> 'FICUS' and Nombre <> 'AMIRADOR' and Nombre <> 'MONTAÑA' and Nombre <> 'BAR HUMEDO' and Nombre <> 'GSNACK SPA' and Nombre <> 'SPA HUMEDO' and Nombre <> 'DCANOPY' and Nombre <> 'EFotografia'")
        Colones = 0 : Dolares = 0 : Euros = 0 : DolaresColones = 0 : EurosColones = 0 : Faltante = 0 : Sobrante = 0
        DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
        While BaseDatos.Read
            cconexion1.SQLStringConexion = ""
            sqlconexion1 = cconexion1.Conectar(, BaseDatos("BaseDatos"))
            CajasAbiertas = CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT ISNULL(SUM(NApertura),0) AS Apertura FROM aperturacaja WHERE Anulado = 0 AND Estado <> 'C' AND aperturacaja.Fecha >='" & dtFecha.Value.Date & "' AND aperturacaja.Fecha <='" & FechaNueva & "'"))
            If CajasAbiertas <> 0 Then
                Me.ButtonAperturas.Visible = True
                MsgBox("No se puede realizar el cierre diario porque hay cajas abiertas, favor revisar...", MsgBoxStyle.Information, "Atención...")
                dtFecha.Focus()
                Me.ButtonImportarDep.Visible = False
                Exit Sub
            End If
            Me.ButtonImportarDep.Visible = True
            totalArqueo += CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT SUM(ArqueoCajas.Total) AS Colones FROM ArqueoCajas INNER JOIN aperturacaja ON ArqueoCajas.IdApertura = aperturacaja.NApertura WHERE ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) ='" & dtFecha.Value.Date & "'"))
            Colones = Colones + CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT SUM(ArqueoCajas.EfectivoColones) AS Colones FROM ArqueoCajas INNER JOIN aperturacaja ON ArqueoCajas.IdApertura = aperturacaja.NApertura WHERE ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) ='" & dtFecha.Value.Date & "'"))
            Dolares = Dolares + CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT SUM(ArqueoCajas.EfectivoDolares) AS Dolares FROM ArqueoCajas INNER JOIN aperturacaja ON ArqueoCajas.IdApertura = aperturacaja.NApertura WHERE ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) ='" & dtFecha.Value.Date & "'"))
            Euros = Euros + CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT SUM(ArqueoCajas.EfectivoEuros) AS Euros FROM ArqueoCajas INNER JOIN aperturacaja ON ArqueoCajas.IdApertura = aperturacaja.NApertura WHERE ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) ='" & dtFecha.Value.Date & "'"))
            TarjetaColones = TarjetaColones + CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT SUM(ArqueoCajas.TarjetaColones) AS TarjetaColones FROM ArqueoCajas INNER JOIN aperturacaja ON ArqueoCajas.IdApertura = aperturacaja.NApertura WHERE ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) ='" & dtFecha.Value.Date & "'"))
            TarjetaDolares = TarjetaDolares + CDbl(cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT SUM(ArqueoCajas.TarjetaDolares) AS TarjetaDolares FROM ArqueoCajas INNER JOIN aperturacaja ON ArqueoCajas.IdApertura = aperturacaja.NApertura WHERE ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) ='" & dtFecha.Value.Date & "'"))

            'Para poder sacar los faltantes de cajeros
            NumeroAperturas = cconexion1.GetRecorset(sqlconexion1, "SELECT NApertura, Nombre FROM aperturacaja WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <'" & FechaNueva & "'")
            While NumeroAperturas.Read
                sqlconexion2 = cconexion2.Conectar(, BaseDatos("BaseDatos"))
                MontoArqueo = CDbl(cconexion2.SlqExecuteScalar(sqlconexion2, "Select Total from " & BaseDatos("BaseDatos") & ".dbo.ArqueoCajas where Anulado = 0 and IdApertura = " & NumeroAperturas("NApertura")))
                MontoCierre = CDbl(cconexion2.SlqExecuteScalar(sqlconexion2, "Select TotalSistema from " & BaseDatos("BaseDatos") & ".dbo.cierrecaja where Anulado = 0 and Apertura = " & NumeroAperturas("NApertura")))

                totalSistema += MontoCierre
                travelCheke += CDbl(cconexion2.SlqExecuteScalar(sqlconexion2, "Select TravelCheckCajero from " & BaseDatos("BaseDatos") & ".dbo.cierrecaja where Anulado = 0 and Apertura = " & NumeroAperturas("NApertura")))
                tranColones += CDbl(cconexion2.SlqExecuteScalar(sqlconexion2, "Select transfColones from " & BaseDatos("BaseDatos") & ".dbo.cierrecaja where Anulado = 0 and Apertura = " & NumeroAperturas("NApertura")))
                tranDolares += CDbl(cconexion2.SlqExecuteScalar(sqlconexion2, "Select transfDolares from " & BaseDatos("BaseDatos") & ".dbo.cierrecaja where Anulado = 0 and Apertura = " & NumeroAperturas("NApertura")))

                If CStr(BaseDatos("BaseDatos")).Equals("HOTEL") = True Then

                    'llena sin limpiar las opciones de pago de transferencia
                    cFunciones.Llenar_Tabla_SL("SELECT     OpcionesDePago.MontoPago * OpcionesDePago.TipoCambio AS Monto, Detalle_pago_caja.CuentaBancaria, OpcionesDePago.TipoCambio" &
                    " FROM         OpcionesDePago INNER JOIN " &
                      "Detalle_pago_caja ON OpcionesDePago.id = Detalle_pago_caja.Id_ODP " &
                " WHERE     (OpcionesDePago.Numapertura = " & NumeroAperturas("NApertura") & " ) AND (OpcionesDePago.FormaPago = 'TRA') ",
                dtTranferencias, Configuracion.Claves.Configuracion(BaseDatos("BaseDatos")))

                    'Carga Comisiones pagadas
                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico("SELECT Montotal,CodigoMoneda,CambioDolar FROM ComisionesPagadas WHERE NApertura = '" & NumeroAperturas("NApertura") & "'", dt, Configuracion.Claves.Conexion("Hotel"))

                    For i As Integer = 0 To dt.Rows.Count - 1

                        If dt.Rows(i).Item("CodigoMoneda") = 2 Then
                            totalComisiones += dt.Rows(i).Item("Montotal") * dt.Rows(i).Item("CambioDolar")
                        Else
                            totalComisiones += dt.Rows(i).Item("Montotal")
                        End If
                    Next
                End If

                If MontoArqueo <> MontoCierre Then
                    DifCaja = MontoCierre - MontoArqueo
                    If DifCaja > 0 Then
                        Faltante = Faltante + DifCaja
                    End If
                    If DifCaja < 0 Then
                        Sobrante = Sobrante + DifCaja
                    End If
                    'Cargar el dataset de cierre
                    BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").AddNew()
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").Current("Id_CierreDiario") = BindingContext(DsCierreDiario1, "CierreDiario").Current("Id")
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").Current("NombreCajero") = NumeroAperturas("Nombre")
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").Current("Monto") = DifCaja
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").Current("MontoDistribuido") = 0
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").EndCurrentEdit()
                End If
                cconexion2.DesConectar(sqlconexion2)
            End While
            cconexion1.DesConectar(sqlconexion1)
        End While
        Me._sp_GENERAR_ADELANTOS()

        BaseDatos.Close()
        'Consulta para Ventas de Contado
        VentaContado = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT SUM(Total * Tipo_Cambio) AS Total FROM Ventas WHERE Tipo = 'CON' AND Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
        txtVentasContado.Text = Format(VentaContado, "#,##.00")
        'Consulta para Ventas In House
        VentaInHouse = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT SUM(Total * Tipo_Cambio) AS Total FROM Ventas WHERE Tipo = 'CAR' AND Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
        txtVentasInHouse.Text = Format(VentaInHouse, "#,##.00")
        'Consulta para Ventas de Crédtio
        VentaCredito = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT SUM(Total * Tipo_Cambio) AS Total FROM Ventas WHERE Tipo = 'CRE' AND Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
        txtVentasCredito.Text = Format(VentaCredito, "#,##.00")
        'Ventas Totales
        TotalVenta = VentaContado + VentaCredito + VentaInHouse
        txtTotalVentas.Text = Format(TotalVenta, "#,##.00")

        'Consulta Total Adicionales
        TotalAdicionales = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT SUM(dbo.Ventas.Total * dbo.Ventas.Tipo_Cambio) AS TotalAdicionales FROM dbo.Ventas INNER JOIN dbo.Cuentas ON dbo.Ventas.Id_Reservacion = dbo.Cuentas.Id INNER JOIN dbo.Check_Out ON dbo.Cuentas.Id = dbo.Check_Out.Id_Cuenta WHERE dbo.Ventas.Anulado = 0 AND dbo.Check_Out.Fecha >= '" & dtFecha.Value.Date & "' AND dbo.Check_Out.Fecha < '" & FechaNueva & "' AND dbo.Ventas.Proveniencia_Venta <> 1"))
        txtCobroFacturas.Text = Format(TotalAdicionales, "#,##.00")
        'Consulta Total Recibos de Dinero

        dAbonos = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT isnull(SUM(abonoccobrar.Monto * Moneda.ValorCompra),0) AS MontoRecibo FROM abonoccobrar INNER JOIN Moneda ON abonoccobrar.Cod_Moneda = Moneda.CodMoneda WHERE (abonoccobrar.Anula = 0) AND (abonoccobrar.Fecha > '" & dtFecha.Value.Date & "' AND abonoccobrar.Fecha < '" & FechaNueva & "')"))
        txtCobroClientes.Text = Format(dAbonos, "#,##.00")

        'Para Pizzería de Jonny no tienen arqueos en hotel lo tienen en Restaurante.
        Dim CedulaJuridica As String
        Dim fx As New cFunciones
        CedulaJuridica = cconexion.SlqExecuteScalar(sqlconexion, "Select Cedula from configuraciones")
        If CedulaJuridica = "3-101-280-294" Then
            sqlconexion1 = cconexion1.Conectar(, "Restaurante")
            'Consulta para Cambio del Dolar y Euros se trae del arqueo de caja
            TipoCambioD = CDbl(cconexion.SlqExecuteScalar(sqlconexion1, "SELECT TipoCambioD FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
            TipoCambioE = CDbl(cconexion.SlqExecuteScalar(sqlconexion1, "SELECT TipoCambioE FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
            cconexion2.DesConectar(sqlconexion1)
        Else
            TipoCambioD = fx.TipoCambio(dtFecha.Value, False)   'CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT TipoCambioD FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
            TipoCambioE = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT TipoCambioE FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva & "'"))
        End If


        'Prepagos Recibidos
        txtPrepagos.Text = Format(CDbl(cconexion.SlqExecuteScalar(sqlconexion, "select isnull(sum(monto),0) as monto from prepagos where fecha between '" & dtFecha.Value & "' and '" & FechaNueva & "'")) * TipoCambioD, "#,##.00")
        'Prepagos Aplicados
        txtPrepagosApli.Text = Format(CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT isnull(SUM(Cuentas.MontoPrepago * Check_Out.Tipo_Cambio),0) AS Total FROM Check_Out INNER JOIN Cuentas ON Check_Out.Id_Cuenta = Cuentas.Id WHERE (Check_Out.Fecha >='" & dtFecha.Value.Date & "' AND Check_Out.Fecha <'" & FechaNueva & "')")), "#,##.00")

        txtTotalColones.Text = Format(Colones, "#,##.00")
        txtDolares.Text = Format(Dolares, "#,##.00") : txtDolaresColones.Text = Format(Dolares * TipoCambioD, "#,##.00")
        txtEuros.Text = Format(Euros, "#,##.00") : txtEurosColones.Text = Format(Euros * TipoCambioE, "#,##.00")
        txtTotalEfectivo.Text = Format(Colones + (Dolares * TipoCambioD) + (Euros * TipoCambioE), "#,##.00")
        TextEditTravelCheck.Text = Format(travelCheke, "#,##.00")
        TextEditDepositar.EditValue = Colones + (Dolares * TipoCambioD) + (Euros * TipoCambioE) + travelCheke * TipoCambioD

        txtTarjetaColones.Text = Format(TarjetaColones, "#,##.00")
        txtTarjetaDolares.Text = Format(TarjetaDolares, "#,##.00")
        TarjetaDolaresColones = TarjetaDolares * TipoCambioD
        txtTarjetaDolaresColones.Text = Format(TarjetaDolaresColones, "#,##.00")
        txtTotalTarjetas.Text = Format(TarjetaDolaresColones + TarjetaColones, "#,##.00")
        txtFaltante.Text = Format(Faltante, "#,##.00")
        txtSobrante.Text = Format(Sobrante, "#,##.00")


        BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
        DsCierreDiario1.CierreDiario_DetalleTarjeta.Clear()
        'Cargas Tarjetas de Créditos
        TarjetasCredito = cconexion.GetRecorset(sqlconexion, "SELECT dbo.TipoTarjeta.Nombre,dbo.ArqueoTarjeta.Id_Tarjeta, dbo.TipoTarjeta.Moneda, SUM(dbo.ArqueoTarjeta.Monto) AS Monto FROM dbo.ArqueoCajas INNER JOIN dbo.ArqueoTarjeta ON dbo.ArqueoCajas.Id = dbo.ArqueoTarjeta.Id_Arqueo INNER JOIN dbo.TipoTarjeta ON dbo. ArqueoTarjeta.Id_Tarjeta = dbo.TipoTarjeta.Id INNER JOIN dbo.aperturacaja ON dbo.ArqueoCajas.IdApertura = dbo.aperturacaja.NApertura WHERE dbo.ArqueoCajas.Anulado = 0 AND dbo.DateOnly(aperturacaja.Fecha) >='" & dtFecha.Value.Date & "' AND dbo.DateOnly(aperturacaja.Fecha) < '" & FechaNueva & "' GROUP BY dbo.TipoTarjeta.Nombre,dbo.ArqueoTarjeta.Id_Tarjeta, dbo.TipoTarjeta.Moneda ORDER BY dbo.TipoTarjeta.Nombre")
        While TarjetasCredito.Read
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").AddNew()
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("Documentos") = 0
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("Tipo_Tarjeta") = TarjetasCredito("Nombre")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("Monto") = TarjetasCredito("Monto")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("Cod_Tarjeta") = TarjetasCredito("Id_Tarjeta")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("Moneda") = TarjetasCredito("Moneda")
            If TarjetasCredito("Moneda") = 2 Then
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("TipoCambio") = Me.TipoCambioD
            Else
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").Current("TipoCambio") = 1
            End If


            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").EndCurrentEdit()
        End While
        TarjetasCredito.Close()
        Me.TextBoxComisiones.Text = totalComisiones
        'Cargar Depositos aplicados
        BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
        'depositosMontos()
        cargarDepositosGuardados()

        txtObservaciones.Focus()
        cconexion.DesConectar(sqlconexion)

    End Sub
    'bandera
    Sub cargarDepositosGuardados()
        Dim dtDepositos As New DataTable

        cFunciones.Llenar_Tabla_Generico("SELECT Deposito.Fecha, Deposito.Id_Deposito, Deposito.Monto, Deposito.CodigoMoneda, Moneda.MonedaNombre AS Moneda, Deposito.NumeroDocumento AS Deposito," &
                      "Cuentas_bancarias.Cuenta AS CuentaBancaria, TipoCambio " &
                        " FROM         Deposito INNER JOIN " &
                      " Moneda ON Deposito.CodigoMoneda = Moneda.CodMoneda INNER JOIN " &
                      "Cuentas_bancarias ON Deposito.Id_CuentaBancaria = Cuentas_bancarias.Id_CuentaBancaria" &
                        " WHERE     (Deposito.Concepto LIKE '%automático%') AND (Deposito.Concepto LIKE '%" & Format(Me.dtFecha.Value.Day, "00") & "/" & Format(Me.dtFecha.Value.Month, "00") & "/" & Format(Me.dtFecha.Value.Year, "00") & "%')",
                        dtDepositos, Configuracion.Claves.Conexion("Bancos"))
        For i As Integer = 0 To dtDepositos.Rows.Count - 1
            Dim monto As Double = 0
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").AddNew()
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Moneda") = dtDepositos.Rows(i).Item("Moneda")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Fecha") = dtDepositos.Rows(i).Item("Fecha")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Nuevo") = False

            'monto = dtDepositos.Rows(i).Item("Monto") * dtDepositos.Rows(i).Item("TipoCambio")
            If dtDepositos.Rows(i).Item("CodigoMoneda") = 2 Then
                monto = dtDepositos.Rows(i).Item("Monto") * TipoCambioD
            Else
                monto = dtDepositos.Rows(i).Item("Monto")
            End If


            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = monto
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Deposito") = dtDepositos.Rows(i).Item("Deposito")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("CuentaBancaria") = dtDepositos.Rows(i).Item("CuentaBancaria")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Id_Deposito") = dtDepositos.Rows(i).Item("Id_Deposito")
            'BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Moneda") = dtDepositos.Rows(i).Item("CodigoMoneda")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = monto
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("MontoM") = dtDepositos.Rows(i).Item("Monto")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Nuevo") = False
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("TipoCambio") = TipoCambioD




            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").EndCurrentEdit()
        Next

        TotalDepositos()
        TextEditDepositar.EditValue = TextEditDepositar.EditValue - Me.TextEditMontoDeposito.EditValue

    End Sub
    Sub depositosMontos()
        Dim dtDepositos As New DataTable

        'Transaciones de los Check Out
        cFunciones.Llenar_Tabla_Generico("SELECT   OpcionesDePago.id, OpcionesDePago.Documento, OpcionesDePago.TipoDocumento, OpcionesDePago.MontoPago, OpcionesDePago.FormaPago,  OpcionesDePago.Denominacion, OpcionesDePago.Usuario, OpcionesDePago.CodMoneda, OpcionesDePago.Nombre, OpcionesDePago.TipoCambio,  OpcionesDePago.Nombremoneda, OpcionesDePago.Fecha, OpcionesDePago.Numapertura, Detalle_pago_caja.NumeroFactura,  Detalle_pago_caja.TipoFactura, Detalle_pago_caja.Referencia, Detalle_pago_caja.Documento AS Doc, Detalle_pago_caja.ReferenciaTipo,  Detalle_pago_caja.Moneda, Detalle_pago_caja.ReferenciaDoc, Detalle_pago_caja.TipoCambio AS TC_D, Detalle_pago_caja.CuentaBancaria,  Detalle_pago_caja.Cancelado, Detalle_pago_caja.Deposito FROM OpcionesDePago INNER JOIN  Detalle_pago_caja ON OpcionesDePago.id = Detalle_pago_caja.Id_ODP WHERE (dbo.DateOnly(OpcionesDePago.Fecha) = CONVERT(DATETIME, '" & Format(Me.dtFecha.Value.Date, "yyyy-MM-dd") & " 00:00:00', 102)) AND OpcionesDePago.FormaPago = 'TRA'", dtDepositos, Configuracion.Claves.Conexion("Hotel"))
        For i As Integer = 0 To dtDepositos.Rows.Count - 1
            Dim monto As Double = 0
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").AddNew()
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Moneda") = dtDepositos.Rows(i).Item("NombreMoneda")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Fecha") = dtFecha.Value.Date

            If dtDepositos.Rows(i).Item("CodMoneda") = 1 Then
                monto = dtDepositos.Rows(i).Item("MontoPago")
            Else
                monto = dtDepositos.Rows(i).Item("MontoPago") * dtDepositos.Rows(i).Item("TipoCambio")

            End If

            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = monto
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Deposito") = dtDepositos.Rows(i).Item("Doc")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("CuentaBancaria") = dtDepositos.Rows(i).Item("CuentaBancaria")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Id_Deposito") = dtDepositos.Rows(i).Item("Deposito")
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").EndCurrentEdit()
        Next
        Me.TotalDepositos()
    End Sub

    Sub TotalDepositos()
        Dim monto As Double = 0
        For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_Depositos.Count - 1
            monto += Me.DsCierreDiario1.CierreDiario_Depositos(i).Monto

        Next

        Me.TextEditMontoDeposito.EditValue = monto

    End Sub

    Private Function Nuevo()
        Me.TextBoxComisiones.Text = 0
        If ToolBar1.Buttons(0).Text = "Nuevo" Then  'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 4
            Try 'inicia la edicion
                DsCierreDiario1.CierreDiario_Depositos.Id_DepositoColumn.DefaultValue = 0
                DsCierreDiario1.CierreDiario_Depositos.Clear()
                DsCierreDiario1.CierreDiario_DetalleTarjeta.Clear()
                DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
                DsCierreDiario1.CierreDiario.Clear()
                DsCierreDiario1.CierreDiario.FechaColumn.DefaultValue = Now

                BindingContext(DsCierreDiario1, "CierreDiario").CancelCurrentEdit()
                BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
                BindingContext(DsCierreDiario1, "CierreDiario").AddNew()

                txtNombreUsuario.Text = NombreUsuario
                ToolBar1.Buttons(1).Enabled = False
                ToolBar1.Buttons(2).Enabled = True
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = True
                DesBloquear()
                DeshabilitarDepositos()
                dtFecha.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                DsCierreDiario1.CierreDiario_Depositos.Clear()
                DsCierreDiario1.CierreDiario_DetalleTarjeta.Clear()
                DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
                DsCierreDiario1.CierreDiario.Clear()

                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                ToolBar1.Buttons(1).Enabled = True
                ToolBar1.Buttons(2).Enabled = False
                ToolBar1.Buttons(3).Enabled = False
                ToolBar1.Buttons(4).Enabled = True
                Bloquear()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
        Me.ButtonImportarDep.Visible = False
    End Function
    Function Validar() As Boolean
        If Me.TextEditDepositar.EditValue > 0 Then
            'MsgBox("Debe depositar el monto completo de lo reportado por los cajeros", MsgBoxStyle.OKOnly)
            'Return False
        End If
        If Not (Me.CheckBox1.Checked) Then 'And Me.CheckBoxCheck1.Checked) Then
            MsgBox("Debe checkear si reviso") : Return False
        End If
        Return True
    End Function
#Region "NUEVOS ASIENTOS"
    Dim numAsiento As String = ""
    Sub _sp_GENERACIONASIENTOS2()
        Try
            Me.DsIngresos1.DetallesAsientosContable.Clear()
            Me.DsIngresos1.AsientosContables.Clear()
            Me.numAsiento = ""
            _sp_GENERACIONASIENTOSDEP()
            Dim v As New frmVisorReportes
            Dim cr As New _crp_AsientosContablesCierre
            cr.SetDataSource(Me.DsIngresos1)
            v.rptViewer.ReportSource = cr
            v.Show()
        Catch ex As Exception
            MsgBox(" ASIENTOS: " & ex.ToString, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Sub _sp_GENERACIONASIENTOS()
        Try
            Me.DsIngresos1.DetallesAsientosContable.Clear()
            Me.DsIngresos1.AsientosContables.Clear()
            'Me.numAsiento = ""
            _sp_GENERACIONASIENTOSDEP()
            'Dim v As New frmVisorReportes
            'Dim cr As New _crp_AsientosContablesCierre
            'cr.SetDataSource(Me.DsIngresos1)
            'v.rptViewer.ReportSource = cr
            'v.Show()
        Catch ex As Exception
            MsgBox(" ASIENTOS: " & ex.ToString, MsgBoxStyle.OkOnly)
        End Try
    End Sub
    Sub _sp_GENERACIONASIENTOSDEP()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM CuentaContable INNER JOIN SettingCuentaContable ON CuentaContable.id = SettingCuentaContable.IdCaja", dt, Configuracion.Claves.Conexion("Contabilidad"))

        For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_Depositos.Count - 1
            Me._sp_ASIENTODEPOSITO(i, dt)
        Next
        _SP_GENERACIONASIENTOSDIFERENCIAL(dt)

        'SI HAY ADELANTOS
        If TextEditAdelantos.Text > 0 Then
            Dim DTS As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT MONTOADELANTO FROM SettingCuentaContable", DTS, Configuracion.Claves.Conexion("Contabilidad"))
            'SI TRAE EL MONTO DEL SETTING CONTABLE
            If DTS.Rows.Count > 0 Then
                'SI EL MONTO DEL SETTING CONTABLE ES MAYOR O IGUAL AL ADELANTO
                If CDec(Me.TextEditAdelantos.Text) >= DTS.Rows(0).Item("MONTOADELANTO") Then
                    'GENERA EL ASIENTO DE ADELANTO
                    _SP_GENERACIONASIENTO_ADELANTO(dt)
                End If
            End If
        End If


    End Sub

    Function _fn_SIGUIENTENUMERO(ByVal p_N As String, ByVal Fecha As Date) As String
        If numAsiento.Equals("") Then
            Return p_N
        End If
        Dim _n As String = numAsiento.Substring(p_N.Length - 4, 4)
        Dim _numN As Integer = _n
        _numN = _numN + 1
        _n = _numN


        _n = Format(_numN, "0000")
        Return "BCO-" & Format(Fecha.Month, "00") & Format(Fecha, "yy") & "-" & _n

    End Function
    Sub _sp_ASIENTODEPOSITO(ByVal p As Integer, ByVal p_cCaja As DataTable)
        Dim Fx As New cFunciones
        Dim TipoCambio As Decimal
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        BindingContext(DsIngresos1, "AsientosContables").AddNew()
        Me.numAsiento = Me._fn_SIGUIENTENUMERO(Fx.BuscaNumeroAsiento("BCO-" & Format(DsCierreDiario1.CierreDiario_Depositos(p).Fecha.Month, "00") & Format(DsCierreDiario1.CierreDiario_Depositos(p).Fecha, "yy") & "-"), DsCierreDiario1.CierreDiario_Depositos(p).Fecha)
        'Me.numAsiento = Fx.BuscaNumeroAsiento("BCO-" & Format(DsCierreDiario1.CierreDiario_Depositos(p).Fecha.Month, "00") & Format(DsCierreDiario1.CierreDiario_Depositos(p).Fecha.Date, "yy") & "-")
        BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = Me.numAsiento
        BindingContext(DsIngresos1, "AsientosContables").Current("Fecha") = DsCierreDiario1.CierreDiario_Depositos(p).Fecha
        BindingContext(DsIngresos1, "AsientosContables").Current("IdNumDoc") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("NumDoc") = DsCierreDiario1.CierreDiario_Depositos(p).Deposito
        BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = "CIERRE DIARIO " & Format(Me.dtFecha.Value.Date, "dd/MM/yyyy") & " "
        BindingContext(DsIngresos1, "AsientosContables").Current("TipoDoc") = 15
        BindingContext(DsIngresos1, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsIngresos1, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Mayorizado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsIngresos1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(DsCierreDiario1.CierreDiario_Depositos(p).Fecha)
        BindingContext(DsIngresos1, "AsientosContables").Current("NumMayorizado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "CIERRE CAJAS"
        BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = " Dep: " & DsCierreDiario1.CierreDiario_Depositos(p).Deposito & " CIERRE DIARIO " & Format(Me.dtFecha.Value.Date, "dd/MM/yyyy")
        BindingContext(DsIngresos1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text

        BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = Me.DsCierreDiario1.CierreDiario_Depositos(p).MontoM
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = Me.DsCierreDiario1.CierreDiario_Depositos(p).MontoM
        If Me.DsCierreDiario1.CierreDiario_Depositos(p).Moneda.Equals("DOLAR") Then
            BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 2
            CodMoneda = 2
            TipoCambio = TipoCambioD
        Else
            BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 1
            CodMoneda = 1
            TipoCambio = 1
        End If

        BindingContext(DsIngresos1, "AsientosContables").Current("TipoCambio") = TipoCambio  'Me.DsCierreDiario1.CierreDiario_Depositos(p).TipoCambio
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        'CREA LOS DETALLES DE ASIENTOS CONTABLES
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT     NombreCuentaContable, CuentaContable FROM         Cuentas_bancarias WHERE     (Cuenta = '" & Me.DsCierreDiario1.CierreDiario_Depositos(p).CuentaBancaria & "') ", dt, Configuracion.Claves.Conexion("Bancos"))

        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(0).Item("CuentaContable")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(0).Item("NombreCuentaContable")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = DsCierreDiario1.CierreDiario_Depositos(p).MontoM
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = True
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = False
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = TipoCambio 'Fx.TipoCambio(Me.dtFecha.Value) 'Me.DsCierreDiario1.CierreDiario_Depositos(p).TipoCambio
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()

        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = p_cCaja.Rows(0).Item("CuentaContable")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = p_cCaja.Rows(0).Item("Descripcion")
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = DsCierreDiario1.CierreDiario_Depositos(p).MontoM
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = False
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = True
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = TipoCambio ' Fx.TipoCambio(Me.dtFecha.Value)
        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        Me.DsCierreDiario1.CierreDiario_Depositos(p).Asiento = numAsiento

    End Sub

    Sub _SP_GENERACIONASIENTO_ADELANTO(ByVal p_cCaja As DataTable)
        Dim Fx As New cFunciones
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        BindingContext(DsIngresos1, "AsientosContables").AddNew()
        Me.numAsiento = Fx.BuscaNumeroAsiento("ADE-" & Format(Me.dtFecha.Value.Month, "00") & Format(Me.dtFecha.Value, "yy") & "-")
        BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = Me.numAsiento
        BindingContext(DsIngresos1, "AsientosContables").Current("Fecha") = Me.dtFecha.Value
        BindingContext(DsIngresos1, "AsientosContables").Current("IdNumDoc") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("NumDoc") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = "CIERRE DIARIO " & Format(Me.dtFecha.Value.Date, "dd/MM/yyyy") & " "
        BindingContext(DsIngresos1, "AsientosContables").Current("TipoDoc") = 15
        BindingContext(DsIngresos1, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsIngresos1, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Mayorizado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsIngresos1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(Me.dtFecha.Value)
        BindingContext(DsIngresos1, "AsientosContables").Current("NumMayorizado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "CIERRE CAJAS"
        BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = " ADELANTO"
        BindingContext(DsIngresos1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
        BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 1
        CodMoneda = 1
        BindingContext(DsIngresos1, "AsientosContables").Current("TipoCambio") = 1
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        'CREA LOS DETALLES DE ASIENTOS CONTABLES
        'Asientos del diferencial
        Dim Sobrante As Double = 0 : Dim Faltante As Double = 0
        Dim totalPrestamo As Double = 0
        For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_DiferenciaCaja.Count - 1
            If DsCierreDiario1.CierreDiario_DiferenciaCaja(i).MontoDistribuido > 0 Then
                totalPrestamo += DsCierreDiario1.CierreDiario_DiferenciaCaja(i).MontoDistribuido
            ElseIf DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto <> 0 Then
                If DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto < 0 Then
                    Sobrante = Sobrante + Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto)
                Else
                    Faltante = Faltante + Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto)
                End If
            End If
        Next

        Dim dtPresEmp As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM CuentaContable INNER JOIN SettingCuentaContable ON CuentaContable.id = SettingCuentaContable.IdCXCEmpCol", dtPresEmp, Configuracion.Claves.Conexion("Contabilidad"))
        If dtPresEmp.Rows.Count > 0 Then
            GuardaAsientoDetalle(Math.Round(totalPrestamo, 2), True, False, dtPresEmp.Rows(0).Item("CuentaContable"), dtPresEmp.Rows(0).Item("Descripcion"))
        End If
        GuardaAsientoDetalle(Math.Round(totalPrestamo, 2), False, True, p_cCaja.Rows(0).Item("CuentaContable"), p_cCaja.Rows(0).Item("Descripcion"))

        BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = Math.Abs(totalPrestamo)
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = Math.Abs(totalPrestamo)
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
    End Sub

    Sub _SP_GENERACIONASIENTOSDIFERENCIAL(ByVal p_cCaja As DataTable)
        Dim Fx As New cFunciones
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        BindingContext(DsIngresos1, "AsientosContables").AddNew()
        Me.numAsiento = Fx.BuscaNumeroAsiento("CDS-" & Format(Me.dtFecha.Value.Month, "00") & Format(Me.dtFecha.Value, "yy") & "-")
        BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = Me.numAsiento
        BindingContext(DsIngresos1, "AsientosContables").Current("Fecha") = Me.dtFecha.Value
        BindingContext(DsIngresos1, "AsientosContables").Current("IdNumDoc") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("NumDoc") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = "CIERRE DIARIO " & Format(Me.dtFecha.Value.Date, "dd/MM/yyyy") & " "
        BindingContext(DsIngresos1, "AsientosContables").Current("TipoDoc") = 15
        BindingContext(DsIngresos1, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsIngresos1, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Mayorizado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsIngresos1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(Me.dtFecha.Value)
        BindingContext(DsIngresos1, "AsientosContables").Current("NumMayorizado") = 0
        BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "CIERRE CAJAS"
        BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = " DIFERENCIAL CAJAS - CIERRE DIARIO " & Format(Me.dtFecha.Value.Date, "dd/MM/yyyy")
        BindingContext(DsIngresos1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
        BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 1
        CodMoneda = 1
        BindingContext(DsIngresos1, "AsientosContables").Current("TipoCambio") = 1
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
        'CREA LOS DETALLES DE ASIENTOS CONTABLES
        'Asientos del diferencial
        Dim Sobrante As Double = 0 : Dim Faltante As Double = 0
        Dim totalPrestamo As Double = 0
        For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_DiferenciaCaja.Count - 1
            If DsCierreDiario1.CierreDiario_DiferenciaCaja(i).MontoDistribuido > 0 Then

                totalPrestamo += DsCierreDiario1.CierreDiario_DiferenciaCaja(i).MontoDistribuido


            ElseIf DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto <> 0 Then
                If DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto < 0 Then
                    Sobrante = Sobrante + Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto)

                Else
                    Faltante = Faltante + Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Monto)
                End If
            End If
        Next
        Sobrante = -1 * Sobrante
        If Math.Round(Faltante + Sobrante - totalPrestamo, 2) > 0 Then
            'detalle uno bandera
            Dim funcion As New cFunciones
            Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Distribuir Monto " & Format(Sobrante + Faltante, "###.00"), Configuracion.Claves.Conexion("Contabilidad"))
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
            If dt.Rows.Count > 0 Then
                GuardaAsientoDetalle(Math.Abs(Math.Round(Sobrante + Faltante - totalPrestamo, 2)), True, False, dt.Rows(0).Item("CuentaContable"), dt.Rows(0).Item("Descripcion"))
            End If
            GuardaAsientoDetalle(Math.Abs(Math.Round(Sobrante + Faltante - totalPrestamo, 2)), False, True, p_cCaja.Rows(0).Item("CuentaContable"), p_cCaja.Rows(0).Item("Descripcion"))
        ElseIf Math.Round(Faltante + Sobrante - totalPrestamo, 2) < 0 Then
            'detalle uno
            Dim funcion As New cFunciones
            Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Distribuir Monto " & Format(Sobrante + Faltante, "###.00"), Configuracion.Claves.Conexion("Contabilidad"))
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
            If dt.Rows.Count > 0 Then
                GuardaAsientoDetalle(Math.Abs(Math.Round(Sobrante + Faltante - totalPrestamo, 2)), False, True, dt.Rows(0).Item("CuentaContable"), dt.Rows(0).Item("Descripcion"))
            End If
            GuardaAsientoDetalle(Math.Abs(Math.Round(Sobrante + Faltante - totalPrestamo, 2)), True, False, p_cCaja.Rows(0).Item("CuentaContable"), p_cCaja.Rows(0).Item("Descripcion"))
        End If
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = Math.Abs((-1 * Sobrante) + Faltante - totalPrestamo)
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = Math.Abs((-1 * Sobrante) + Faltante - totalPrestamo)
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
    End Sub

    Sub _sp_GENERAR_ADELANTOS()
        If DsCierreDiario1.CierreDiario_DiferenciaCaja.Count = 0 Then Exit Sub
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim Mensaje As String
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer
        Dim CedulaUsuario, Nombre, Puesto, Observaciones As String
        Dim Salario As Double
        Dim Empleado As SqlDataReader
        Dim dia, mes, ano As String
        Dim Fechacobro As Date
        Dim Limite As Double
        DsCierreDiario1.Adelantos.Clear()
        DsCierreDiario1.Adelantos.NumeroColumn.AutoIncrement = True
        DsCierreDiario1.Adelantos.NumeroColumn.AutoIncrementSeed = -1
        DsCierreDiario1.Adelantos.NumeroColumn.AutoIncrementStep = -1

        Observaciones = "Cierre Diario automático del " & dtFecha.Value.Date
        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Planilla")
        cnnConexion.Open()

        dia = dtFecha.Value.Day
        mes = dtFecha.Value.Month
        ano = dtFecha.Value.Year

        If dia < 15 Then
            Fechacobro = "15/" & mes & "/" & ano
        End If
        If dia >= 15 And dia <> 30 And dia <> 31 Then
            If mes = "2" Then
                Fechacobro = "28/" & mes & "/" & ano
            Else
                Fechacobro = "30/" & mes & "/" & ano
            End If
        End If
        If dia = 30 Or dia = 31 Then
            If (mes + 1) = 13 Then
                mes = 0
                ano = ano + 1
            End If
            Fechacobro = "15/" & (mes + 1) & "/" & ano
        End If
        sqlconexion = cconexion.Conectar(, "Contabilidad")
        Limite = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "Select MontoAdelanto from SettingCuentaContable"))
        cconexion.DesConectar(sqlconexion)

        For n = 0 To DsCierreDiario1.CierreDiario_DiferenciaCaja.Count - 1
            With DsCierreDiario1.CierreDiario_DiferenciaCaja(n)
                If DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto") >= Limite Then
                    Me.Faltante -= DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto")
                    Me.TextEditAdelantos.EditValue += DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto")
                    DsCierreDiario1.CierreDiario_DiferenciaCaja(n).MontoDistribuido = DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Monto
                    sqlconexion = cconexion.Conectar(, "Bancos")
                    CedulaUsuario = cconexion.SlqExecuteScalar(sqlconexion, "Select Cedula from Usuarios where Nombre = '" & DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("NombreCajero") & "'")
                    cconexion.DesConectar(sqlconexion)

                    sqlconexion = cconexion.Conectar(, "Planilla")
                    Empleado = cconexion.GetRecorset(sqlconexion, "Select Nombre, Puesto, Salario From Empleado where Identificacion = '" & CedulaUsuario & "'")
                    While Empleado.Read
                        Nombre = Empleado("Nombre")
                        Puesto = Empleado("Puesto")
                        Salario = Empleado("Salario")
                        'sql = "INSERT INTO Adelantos (Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo) VALUES 
                        '('" & CedulaUsuario & "','" & Empleado("Nombre") & "', 1, 0, '" & Empleado("Puesto") & "'," & Empleado("Salario") & ",'" & dtFecha.Text & "', 0," & Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto")) & ",'-' ,'" & Fechacobro & "','" & Observaciones & "', 0, '-','" & txtNombreUsuario.Text & "', 1, 0, " & Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto")) & ")"

                        ' Mensaje = clsConexion.SlqExecute(cnnConexion, sql)
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").AddNew()
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Identificacion") = CedulaUsuario
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Nombre") = Empleado("Nombre")
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Adelanto") = 1
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Prestamo") = 0
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Puesto") = Empleado("Puesto")
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Salario") = Empleado("Salario")
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("FechaComprobante") = dtFecha.Value
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Num_Pago") = 0
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Monto") = Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto"))
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("MontoEnLetras") = "-"
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("FechaCobro") = Fechacobro
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Observaciones") = Observaciones
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("DeducirxPago") = Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto"))
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Usuario") = 0
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("NombreUsuario") = txtNombreUsuario.Text
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Cod_Moneda") = 1
                        CodMoneda = 1
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Anulado") = 0
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("Saldo") = Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto"))
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").Current("InteresPrestamo") = 0
                        Me.BindingContext(Me.DsCierreDiario1, "Adelantos").EndCurrentEdit()
                    End While
                    cconexion.DesConectar(sqlconexion)
                End If
            End With
        Next
        clsConexion.DesConectar(cnnConexion)
    End Sub
#End Region

    Private Function Guardar()
        If Validar() = False Then
            Exit Function
        End If
        If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
        Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
        Try
            'bandera
            Me._sp_GENERACIONASIENTOS()
            'finaliza la edición
            BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
            adCierreDiario.UpdateCommand.Transaction = Trans
            adCierreDiario.InsertCommand.Transaction = Trans
            adCierreDiario.DeleteCommand.Transaction = Trans
            adCierreCajas.UpdateCommand.Transaction = Trans
            adCierreCajas.InsertCommand.Transaction = Trans
            adCierreCajas.DeleteCommand.Transaction = Trans
            adCierreDepositos.UpdateCommand.Transaction = Trans
            adCierreDepositos.InsertCommand.Transaction = Trans
            adCierreDepositos.DeleteCommand.Transaction = Trans

            adCierreTarjetas.UpdateCommand.Transaction = Trans
            adCierreTarjetas.InsertCommand.Transaction = Trans
            adCierreTarjetas.DeleteCommand.Transaction = Trans

            adAsientos.UpdateCommand.Transaction = Trans
            adAsientos.InsertCommand.Transaction = Trans
            adAsientos.DeleteCommand.Transaction = Trans
            adDetalleAsiento.UpdateCommand.Transaction = Trans
            adDetalleAsiento.InsertCommand.Transaction = Trans
            adDetalleAsiento.DeleteCommand.Transaction = Trans

            BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DiferenciaCaja").EndCurrentEdit()
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_DetalleTarjeta").EndCurrentEdit()
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").EndCurrentEdit()

            adCierreDiario.Update(DsCierreDiario1, "CierreDiario")
            For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_DiferenciaCaja.Count - 1
                Me.DsCierreDiario1.CierreDiario_DiferenciaCaja(i).Id_CierreDiario = Me.DsCierreDiario1.CierreDiario(0).Id
            Next
            adCierreCajas.Update(DsCierreDiario1, "CierreDiario_DiferenciaCaja")

            For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_Depositos.Count - 1
                Me.DsCierreDiario1.CierreDiario_Depositos(i).Id_CierreDiario = Me.DsCierreDiario1.CierreDiario(0).Id
            Next
            adCierreDepositos.Update(DsCierreDiario1, "CierreDiario_Depositos")

            For i As Integer = 0 To Me.DsCierreDiario1.CierreDiario_DetalleTarjeta.Count - 1
                Me.DsCierreDiario1.CierreDiario_DetalleTarjeta(i).Id_CierreDiario = Me.DsCierreDiario1.CierreDiario(0).Id
            Next
            adCierreTarjetas.Update(DsCierreDiario1, "CierreDiario_DetalleTarjeta")


            If cFunciones.ValidarAsientos(DsIngresos1.AsientosContables, DsIngresos1.DetallesAsientosContable, CodMoneda) Then

                Me.adAsientos.Update(Me.DsIngresos1, "AsientosContables")
                Me.adDetalleAsiento.Update(Me.DsIngresos1, "DetallesAsientosContable")
            Else

                MsgBox("El Asiento Debe Estar Balanceado", MsgBoxStyle.Information, "Sistema SeeSoft")
                Exit Function
            End If

            Trans.Commit()

            '++++++++++++++++++++++++++++++++++++++++++++++++++            
            Dim v As New frmVisorReportes
            Dim cr As New _crp_AsientosContablesCierre
            cr.SetDataSource(Me.DsIngresos1)
            v.TopMost = True
            v.rptViewer.ReportSource = cr
            v.Show()
            '++++++++++++++++++++++++++++++++++++++++++++++++++

            GuardarDepositos()
            GuardarAdelantos()

            DsCierreDiario1.AcceptChanges()
            DsIngresos1.AcceptChanges()
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)

            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            Bloquear()
            'nuevo
            ToolBar1.Buttons(0).Enabled = True
            'buscar
            ToolBar1.Buttons(1).Enabled = True
            'Registrar
            ToolBar1.Buttons(2).Enabled = False
            'Imprimir
            ToolBar1.Buttons(3).Enabled = False
            'Cerrar
            ToolBar1.Buttons(4).Enabled = True

            'Limpiar el dataset
            DsCierreDiario1.CierreDiario_Depositos.Clear()
            DsCierreDiario1.CierreDiario_DetalleTarjeta.Clear()
            DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
            DsCierreDiario1.CierreDiario.Clear()
            Me.DsIngresos1.DetallesAsientosContable.Clear()
            Me.DsIngresos1.AsientosContables.Clear()

        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try

        Dim frm As New CierreDiario2(Me.usua)
        frm.MdiParent = Me.MdiParent
        frm.CenterToScreen()
        frm.Show()
        Me.Close()

    End Function
    Private Sub GenerarAsiento()
        Dim Fx As New cFunciones
        Try
            DsIngresos1.DetallesAsientosContable.Clear()
            DsIngresos1.AsientosContables.Clear()
            Dim TipoCambio As Double = Fx.TipoCambio(dtFecha.Value)
            BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
            BindingContext(DsIngresos1, "AsientosContables").AddNew()
            BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("ING-" & Format(Now.Month, "00") & Format(Now.Date, "yy") & "-")
            BindingContext(DsIngresos1, "AsientosContables").Current("Fecha") = Me.dtFecha.Value
            BindingContext(DsIngresos1, "AsientosContables").Current("IdNumDoc") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("NumDoc") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = "INGRESOS GENERALES"
            BindingContext(DsIngresos1, "AsientosContables").Current("TipoDoc") = 15
            BindingContext(DsIngresos1, "AsientosContables").Current("Accion") = "AUT"
            BindingContext(DsIngresos1, "AsientosContables").Current("Anulado") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("Mayorizado") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("FechaEntrada") = Now.Date
            BindingContext(DsIngresos1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(Me.dtFecha.Value)
            BindingContext(DsIngresos1, "AsientosContables").Current("NumMayorizado") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "Asiento Ingreso"
            BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = "Asiento de Cierre Diario " & Me.dtFecha.Value.Date
            BindingContext(DsIngresos1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
            BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = 0
            BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 1
            CodMoneda = 1
            BindingContext(DsIngresos1, "AsientosContables").Current("TipoCambio") = TipoCambio
            BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
            AsientoDetalle()
            totalDebeHaber()
            Dim frmVista As New FormVistaAsiento(Me.DsIngresos1)
            'frmVista.MdiParent = MdiParent
            frmVista.DsIngresos1 = Me.DsIngresos1.Copy

            'frmVista.Show()
            If frmVista.ShowDialog = DialogResult.OK Then

                If frmVista.cuentaEnviaDiferencial Is Nothing Then Exit Sub

                Dim dt As New DataTable

                cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & frmVista.cuentaEnviaDiferencial & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))

                BindingContext(DsCierreDiario1, "ContaDiferencial").AddNew()
                BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Cierre") = "0"
                BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Monto") = frmVista.diferencia * -1
                DifAsiento = frmVista.diferencia * -1
                BindingContext(DsCierreDiario1, "ContaDiferencial").Current("CuentaContable") = dt.Rows(0).Item("CuentaContable")
                BindingContext(DsCierreDiario1, "ContaDiferencial").Current("NombreCuenta") = dt.Rows(0).Item("Descripcion")
                BindingContext(DsCierreDiario1, "ContaDiferencial").EndCurrentEdit()

                Dim total As Double = 0
                For i As Integer = 0 To Me.DsCierreDiario1.ContaDiferencial.Count - 1
                    total += DsCierreDiario1.ContaDiferencial(i).Monto
                Next
                GenerarAsiento()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly)
        End Try

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
    End Sub

    Private Sub AsientoDetalle()
        Dim fx As New cFunciones
        Dim TipoCambio As Double = fx.TipoCambio(dtFecha.Value)
        'Asientos de los depositos Bancarios
        Dim i As Integer = 0
        For i = 0 To Me.DsCierreDiario1.CierreDiario_Depositos.Count - 1
            GuardaAsientoDetalle(Math.Round(DsCierreDiario1.CierreDiario_Depositos(i).Monto, 2), True, False, Me.BuscaCuentaTransferencia("CuentaContable", Me.DsCierreDiario1.CierreDiario_Depositos(i).CuentaBancaria), BuscaCuentaTransferencia("NombreCuentaContable", Me.DsCierreDiario1.CierreDiario_Depositos(i).CuentaBancaria))

        Next

        'Asientos del diferencial
        Dim Sobrante As Double = 0 : Dim Faltante As Double = 0
        For i = 0 To Me.DsCierreDiario1.ContaDiferencial.Count - 1
            If DsCierreDiario1.ContaDiferencial(i).Monto <> 0 Then
                If DsCierreDiario1.ContaDiferencial(i).Monto < 0 Then
                    Sobrante = Sobrante + Math.Abs(DsCierreDiario1.ContaDiferencial(i).Monto)
                    GuardaAsientoDetalle(Math.Abs(DsCierreDiario1.ContaDiferencial(i).Monto), False, True, Me.DsCierreDiario1.ContaDiferencial(i).CuentaContable, Me.DsCierreDiario1.ContaDiferencial(i).NombreCuenta)
                Else
                    Faltante = Faltante + Math.Abs(DsCierreDiario1.ContaDiferencial(i).Monto)
                    GuardaAsientoDetalle(Math.Abs(DsCierreDiario1.ContaDiferencial(i).Monto), True, False, Me.DsCierreDiario1.ContaDiferencial(i).CuentaContable, Me.DsCierreDiario1.ContaDiferencial(i).NombreCuenta)
                End If
            End If
        Next
        'Asientos de Comisiones
        'GuardaAsientoDetalle(Math.Round(CDbl(Me.TextBoxComisiones.Text), 2), True, False, "5-07-012-001-000-000", "Comisiones Varias")
        'Asientos de lo reportado
        'GuardaAsientoDetalle(Math.Round(txtTotalEfectivo.EditValue + CDbl(Me.TextBoxComisiones.Text) - Sobrante + Faltante - DifAsiento, 2), False, True, Me.BuscaCuenta("CuentaContable", "IdCaja"), BuscaCuenta("Descripcion", "IdCaja"))
    End Sub
    Function BuscaCuenta(ByVal Tipo As String, ByVal Id As String) As String
        Dim cConexion As New Conexion
        Try
            cConexion.DesConectar(cConexion.sQlconexion)
            BuscaCuenta = cConexion.SlqExecuteScalar(cConexion.Conectar("", "Contabilidad"), "SELECT TOP 1 (SELECT " & Tipo & " FROM cuentacontable " &
                            " WHERE (Id = (SELECT " & Id & " FROM settingcuentacontable))) AS Cuenta FROM CuentaContable ")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
    Private Sub GuardarDepositos()

        If MsgBox("Desea guardar estos depositos en el libro de bancos", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim dt_CuentaContable As DataTable

        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim Mensaje As String
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer
        Dim IdCuenta, CodigoMoneda As Integer
        Dim Concepto, CedUsuario As String
        Dim TipoCambio As Double
        Dim FechaNueva1 As Date

        FechaNueva1 = dtFecha.Value.Date.AddDays(1)
        Concepto = "Cierre Diario automático del " & dtFecha.Value.Date
        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Bancos")
        cnnConexion.Open()

        sqlconexion = cconexion.Conectar(, "Bancos")
        CedUsuario = cconexion.SlqExecuteScalar(sqlconexion, "Select Cedula from Usuarios where Clave_Interna = '" & txtUsuario.Text & "'")
        TipoCambio = 1 : CodigoMoneda = 1
        For n = 0 To DsCierreDiario1.CierreDiario_Depositos.Count - 1
            With DsCierreDiario1.CierreDiario_Depositos(n)

                If .Nuevo = True Then

                    IdCuenta = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT Id_CuentaBancaria FROM Cuentas_bancarias WHERE Cuenta = '" & DsCierreDiario1.CierreDiario_Depositos(n).Item("CuentaBancaria") & "'"))
                    If CStr(DsCierreDiario1.CierreDiario_Depositos(n).Item("Moneda")).Trim(" ").Equals("COLON") Then
                        TipoCambio = 1 : CodigoMoneda = 1
                    End If
                    If CStr(DsCierreDiario1.CierreDiario_Depositos(n).Item("Moneda")).Trim(" ").Equals("DOLAR") Then
                        'TipoCambio = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT TipoCambioD FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva1 & "'"))
                        TipoCambio = TipoCambioD
                        CodigoMoneda = 2
                    End If
                    If CStr(DsCierreDiario1.CierreDiario_Depositos(n).Item("Moneda")).Trim(" ").Equals("EURO") Then
                        TipoCambio = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT TipoCambioE FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva1 & "'"))
                        CodigoMoneda = 3
                    End If

                    sql = "INSERT INTO Deposito (NumeroDocumento, Id_CuentaBancaria, Fecha, Monto, Concepto, Anulado, Conciliado, Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion, CodigoMoneda, TipoCambio) " &
                    "VALUES (" & .Deposito & "," & IdCuenta & ",'" & .Fecha.Date & "'," & .MontoM & ",'" & Concepto & "', 0, 0, 1,'" & CedUsuario & " ', '" & .Asiento & "', 0, " & CodigoMoneda & "," & TipoCambio & ")"

                    Mensaje = clsConexion.SlqExecute(cnnConexion, sql)
                    Dim Id_Dep As Integer = 0
                    If Mensaje Is Nothing Then
                        .Nuevo = False
                        MsgBox("Transaccion realizada satisfactoriamente", MsgBoxStyle.OkOnly)
                        Id_Dep = CDbl(cconexion.SlqExecuteScalar(cnnConexion, "select MAX(id_Deposito) from deposito"))
                    End If
                    'Aqui hay que guardar el detalle del deposito
                    sql = "INSERT INTO Deposito_Detalle (Id_Deposito, CuentaContable, DescripcionMov, Monto, NombreCuenta, TipoCambio, MontoOtro) VALUES (" & Id_Dep & ",'" & BuscaCuenta("CuentaContable", "IdCaja") & "','CIERRE DIARIO AUTOMÁTICO DEL  " & dtFecha.Value.Date & "'," & .MontoM & ",'" & BuscaCuenta("Descripcion", "IdCaja") & "', " & TipoCambio & ", '0')"
                    clsConexion.SlqExecute(cnnConexion, sql)

                End If
            End With
        Next
        clsConexion.DesConectar(cnnConexion)
        cconexion.DesConectar(sqlconexion)

    End Sub

    Private Sub GuardarAdelantos()
        If DsCierreDiario1.CierreDiario_DiferenciaCaja.Count = 0 Then Exit Sub
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim Mensaje As String
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer
        Dim CedulaUsuario, Nombre, Puesto, Observaciones As String
        Dim Salario As Double
        Dim Empleado As SqlDataReader
        Dim dia, mes, ano As String
        Dim Fechacobro As Date
        Dim Limite As Double


        Observaciones = "Cierre Diario automático del " & dtFecha.Value.Date
        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Planilla")
        cnnConexion.Open()

        dia = dtFecha.Value.Day
        mes = dtFecha.Value.Month
        ano = dtFecha.Value.Year

        If dia < 15 Then
            Fechacobro = "15/" & mes & "/" & ano
        End If
        If dia >= 15 And dia <> 30 And dia <> 31 Then
            If mes = "2" Then
                Fechacobro = "28/" & mes & "/" & ano
            Else
                Fechacobro = "30/" & mes & "/" & ano
            End If
        End If
        If dia = 30 Or dia = 31 Then
            If (mes + 1) = 13 Then
                mes = 0
                ano = ano + 1
            End If
            Fechacobro = "15/" & (mes + 1) & "/" & ano
        End If
        sqlconexion = cconexion.Conectar(, "Contabilidad")
        Limite = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "Select MontoAdelanto from SettingCuentaContable"))
        cconexion.DesConectar(sqlconexion)

        For n = 0 To DsCierreDiario1.CierreDiario_DiferenciaCaja.Count - 1
            With DsCierreDiario1.CierreDiario_DiferenciaCaja(n)
                If DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto") >= Limite Then
                    sqlconexion = cconexion.Conectar(, "Bancos")
                    CedulaUsuario = cconexion.SlqExecuteScalar(sqlconexion, "Select Cedula from Usuarios where Nombre = '" & DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("NombreCajero") & "'")
                    cconexion.DesConectar(sqlconexion)

                    sqlconexion = cconexion.Conectar(, "Planilla")
                    Empleado = cconexion.GetRecorset(sqlconexion, "Select Nombre, Puesto, Salario From Empleado where Identificacion = '" & CedulaUsuario & "'")
                    While Empleado.Read
                        Nombre = Empleado("Nombre")
                        Puesto = Empleado("Puesto")
                        Salario = Empleado("Salario")
                        sql = "INSERT INTO Adelantos (Identificacion, Nombre, Adelanto, Prestamo, Puesto, Salario, FechaComprobante, Num_Pago, Monto, MontoEnLetras, FechaCobro, Observaciones, DeducirxPago, Usuario, NombreUsuario, Cod_Moneda, Anulado, Saldo) VALUES ('" & CedulaUsuario & "','" & Empleado("Nombre") & "', 1, 0, '" & Empleado("Puesto") & "'," & Empleado("Salario") & ",'" & dtFecha.Text & "', 0," & Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto")) & ",'-' ,'" & Fechacobro & "','" & Observaciones & "', 0, '-','" & txtNombreUsuario.Text & "', 1, 0, " & Math.Abs(DsCierreDiario1.CierreDiario_DiferenciaCaja(n).Item("Monto")) & ")"
                        Mensaje = clsConexion.SlqExecute(cnnConexion, sql)
                    End While
                    cconexion.DesConectar(sqlconexion)
                End If
            End With
        Next
        clsConexion.DesConectar(cnnConexion)
    End Sub

    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim Id As Integer
        Try
            If BindingContext(DsCierreDiario1, "CierreDiario").Count > 0 Then
                If (MsgBox("Actualmente se está realizando un ingreso Nuevo, si continúa se perderan los datos, ¿desea continuar?", MsgBoxStyle.YesNo)) = MsgBoxResult.No Then
                    Exit Function
                End If
            End If
            DsCierreDiario1.CierreDiario_Depositos.Clear()
            DsCierreDiario1.CierreDiario_DetalleTarjeta.Clear()
            DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
            DsCierreDiario1.CierreDiario.Clear()
            Id = funcion.BuscarDatos("Select id, fecha from cierrediario order by fecha desc", "Fecha", "Buscar Cierre Diario...", SqlConnection1.ConnectionString)

            If Id = 0 Then ' si se dio en el boton de cancelar
                Exit Function
            End If
            LlenarCierreDiario(Id)
            Bloquear()
            'DesActivarControlesSucursales()
            'nuevo
            ToolBar1.Buttons(0).Enabled = True
            'buscar
            ToolBar1.Buttons(1).Enabled = True
            'registrar
            ToolBar1.Buttons(2).Enabled = False
            'imprimir
            ToolBar1.Buttons(3).Enabled = True
            'cerrar
            ToolBar1.Buttons(4).Enabled = True
            DeshabilitarDepositos()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
    Function LlenarCierreDiario(ByVal Id As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim cConexion As New Conexion
        'Dentro de un Try/Catch por si se produce un error
        Try
            '''''''''LLENAR CIERRE''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            'Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM CierreDiario WHERE (Id = @Id)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmdv.Parameters("@Id").Value = Id
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(DsCierreDiario1, "CierreDiario")

            '''''''''LLENAR FALTANTES CAJA''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            sel = "SELECT * FROM CierreDiario_DiferenciaCaja WHERE (Id_CierreDiario = @Id) "
            cmd.CommandText = sel
            cmd.Connection = cnnv
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmd.Parameters("@Id").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla
            da.Fill(DsCierreDiario1.CierreDiario_DiferenciaCaja)

            '''''''''LLENAR DEPOSITOS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmda As SqlCommand = New SqlCommand
            sel = "SELECT * FROM CierreDiario_Depositos WHERE (Id_CierreDiario = @Id)"
            cmda.CommandText = sel
            cmda.Connection = cnnv
            cmda.CommandType = CommandType.Text
            cmda.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmda.Parameters.Add(New SqlParameter("@Id", SqlDbType.Int))
            cmda.Parameters("@Id").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim daa As New SqlDataAdapter
            daa.SelectCommand = cmda
            ' Llenamos la tabla
            daa.Fill(DsCierreDiario1.CierreDiario_Depositos)

            '''''''''LLENAR TARJETAS''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            ' Creamos el comando para la consulta
            Dim cmdl As SqlCommand = New SqlCommand
            sel = "SELECT * FROM CierreDiario_DetalleTarjeta WHERE (Id_CierreDiario = @Id) "
            cmdl.CommandText = sel
            cmdl.Connection = cnnv
            cmdl.CommandType = CommandType.Text
            cmdl.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmdl.Parameters.Add(New SqlParameter("@Id", SqlDbType.VarChar))
            cmdl.Parameters("@Id").Value = Id
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim dal As New SqlDataAdapter
            dal.SelectCommand = cmdl
            ' Llenamos la tabla
            dal.Fill(DsCierreDiario1.CierreDiario_DetalleTarjeta)
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

    Private Function imprimir()
        Dim CierreDiario As New ReporteCierreDiario
        Dim visor As New frmVisorReportes

        Try
            CierreDiario.SetParameterValue(0, txtId.Text)
            CierreDiario.SetParameterValue(1, txtId.Text)
            CierreDiario.SetParameterValue(2, txtId.Text)
            CierreDiario.SetParameterValue(3, txtId.Text)

            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, CierreDiario, False, SqlConnection1.ConnectionString)

            visor.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try
    End Function

#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Name)  'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()

            Case 1
                Buscar()
                'If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 2
                Guardar()
                'If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3
                imprimir()
                'If PMU.Delete Then eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : Close()

        End Select
    End Sub

    Private Sub txtUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        If e.KeyCode = Keys.Enter Then
            If txtUsuario.Text <> "" Then
                rs = cConexion.GetRecorset(cConexion.Conectar, "select id_Usuario,Nombre from seguridad.dbo.usuarios where Clave_Interna ='" & txtUsuario.Text & "'")
                While rs.Read

                    Try
                        NombreUsuario = rs("Nombre")
                        txtNombreUsuario.Text = rs("Nombre")
                        Identificacion = rs("id_Usuario")

                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True

                        txtUsuario.Enabled = False ' se inabilita el campo de la contraseña

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.sQlconexion)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If
        End If

    End Sub

    Private Sub dtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFecha.KeyDown
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim Cierre As Double

        If e.KeyCode = Keys.Enter Then
            Dim fechaConsultada As Date = Me.dtFecha.Value.Date
            DsCierreDiario1.CierreDiario_Depositos.Clear()
            DsCierreDiario1.CierreDiario_DetalleTarjeta.Clear()
            DsCierreDiario1.CierreDiario_DiferenciaCaja.Clear()
            DsCierreDiario1.CierreDiario.Clear()
            Me.TextEditAdelantos.EditValue = 0

            BindingContext(DsCierreDiario1, "CierreDiario").CancelCurrentEdit()
            BindingContext(DsCierreDiario1, "CierreDiario").EndCurrentEdit()
            BindingContext(DsCierreDiario1, "CierreDiario").AddNew()
            dtFecha.Value = fechaConsultada : DifAsiento = 0
            sqlconexion = cconexion.Conectar(, "Contabilidad")
            Cierre = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "Select id from cierrediario where fecha ='" & dtFecha.Value.Date & "'"))
            cconexion.DesConectar(sqlconexion)
            If Cierre = 0 Then
                CargarDatos()
            Else
                MsgBox("Ya se registro un cierre con esta fecha, favor revisar...", MsgBoxStyle.Information, "Atención...")
                dtFecha.Focus()
            End If
        End If
    End Sub

    Private Sub ToolBar2_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar2.ButtonClick
        Select Case ToolBar2.Buttons.IndexOf(e.Button)
            Case 0
                NuevoDeposito()
            Case 1
                EliminarDepositos()
            Case 2
                GuardarDepositos()
        End Select
    End Sub

    Private Sub NuevoDeposito()
        If ToolBar2.Buttons(0).Text = "Nuevo" Then  'n si ya hay un registropendiente por agregar
            'cambia la imagen de nuevo y desabilita los botones
            ToolBar2.Buttons(0).Text = "Cancelar"
            Try 'inicia la edicion
                'Dim id As Integer = Me.BindingContext(Me.DsCierreDiario1, "CierreDiario").Current("Id")
                Me.cbCuentaBancaria.SelectedValue = Me.DsCierreDiario1.Cuentas_bancarias(0).Cuenta
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").AddNew()
                txtMontoDep.EditValue = TextEditDepositar.EditValue
                HabilitarDepositos()
                cbCuentaBancaria.SelectedIndex = -1
                cbMoneda.Focus()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").CancelCurrentEdit()
                ToolBar2.Buttons(0).Text = "Nuevo"
                'juego de botones
                DeshabilitarDepositos()
            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub


    Private Sub RegistrarDepositos()
        Dim cx As New Conexion

        cx.Conectar("SEESOFT", "BANCOS")
        Dim IdCuenta As Integer = 0
        Dim TipoCambio As Double = 0
        Dim CodigoMoneda As Integer = 0
        Try
            If ToolBar2.Buttons(0).Text = "Cancelar" Then
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = txtMontoDep.EditValue
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Fecha") = dtFechaDeposito.Value
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Deposito") = txtDeposito.Text
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("CuentaBancaria") = cbCuentaBancaria.Text
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Moneda") = cbMoneda.Text
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("MontoM") = BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto")
                If cbMoneda.Text = "DOLAR" Then
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") * TipoCambioD
                Else
                    BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto")
                End If

                'BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") * BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("TipoCambio")
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Nuevo") = True
                BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").EndCurrentEdit()
                'Dim n As Integer = BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Count - 1
                'With Me.DsCierreDiario1.CierreDiario_Depositos(n)
                '    If .Nuevo Then
                '        Dim sql As String = "INSERT INTO Deposito (NumeroDocumento, Id_CuentaBancaria, Fecha, Monto, Concepto, Anulado, Conciliado, Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion, CodigoMoneda, TipoCambio) VALUES (" & .Deposito & "," & IdCuenta & ",'" & .Fecha.Date & "'," & .MontoM & ",'" & Concepto & "', 0, 0, 1,'" & CedUsuario & " ', 0, 0, " & CodigoMoneda & "," & .TipoCambio & ")"
                '    IdCuenta = CDbl(cx.SlqExecuteScalar(cx.sQlconexion, "SELECT Id_CuentaBancaria FROM Cuentas_bancarias WHERE Cuenta = '" & DsCierreDiario1.CierreDiario_Depositos(n).Item("CuentaBancaria") & "'"))
                '    If DsCierreDiario1.CierreDiario_Depositos(n).Item("Moneda") = "COLON " Then
                '        TipoCambio = 1 : CodigoMoneda = 1
                '    End If
                '    If DsCierreDiario1.CierreDiario_Depositos(n).Item("Moneda") = "DOLAR" Then
                '        TipoCambio = CDbl(cx.SlqExecuteScalar(cx.sQlconexion, "SELECT TipoCambioD FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva1 & "'"))
                '        CodigoMoneda = 2
                '    End If
                '    If DsCierreDiario1.CierreDiario_Depositos(n).Item("Moneda") = "EURO" Then
                '        TipoCambio = CDbl(cx.SlqExecuteScalar(cx.sQlconexion, "SELECT TipoCambioE FROM ArqueoCajas WHERE Anulado = 0 AND Fecha >='" & dtFecha.Value.Date & "' AND Fecha <='" & FechaNueva1 & "'"))
                '        CodigoMoneda = 3
                '    End If
                '    sql = "INSERT INTO Deposito (NumeroDocumento, Id_CuentaBancaria, Fecha, Monto, Concepto, Anulado, Conciliado, Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion, CodigoMoneda, TipoCambio) VALUES (" & .Deposito & "," & IdCuenta & ",'" & .Fecha.Date & "'," & .MontoM & ",'" & Concepto & "', 0, 0, 1,'" & CedUsuario & " ', 0, 0, " & CodigoMoneda & "," & .TipoCambio & ")"
                '    Dim mensaje As String = cx.SlqExecute(cx.sQlconexion, sql)
                '        If mensaje.Equals("") Then
                '            .Nuevo = False
                '        End If

                '    End If
                'End With
                DeshabilitarDepositos()
                If cbMoneda.Text = "DOLAR" Then
                    TextEditDepositar.EditValue = TextEditDepositar.EditValue - (txtMontoDep.EditValue * TipoCambioD)
                Else
                    TextEditDepositar.EditValue = TextEditDepositar.EditValue - txtMontoDep.EditValue
                End If
                Me.txtDeposito.Text = ""
                ToolBar2.Buttons(0).Text = "Nuevo"
                TotalDepositos()
            End If
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub EliminarDepositos()
        Dim resp As Integer
        If BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Count > 0 Then    ' si hay ubicaciones
            resp = MessageBox.Show("¿Desea eliminar este Depósito?", "SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            If resp = 6 Then
                Dim o As Integer = BindingContext(DsCierreDiario1, "CierreDiario_Depositos").Position
                Dim cx As New Conexion
                Dim IdCuenta As Double = CDbl(cx.SlqExecuteScalar(cx.sQlconexion, "SELECT Id_CuentaBancaria FROM Cuentas_bancarias WHERE Cuenta = '" & DsCierreDiario1.CierreDiario_Depositos(o).Item("CuentaBancaria") & "'"))

                cx.Conectar("SeeSoft", "Bancos")
                cx.SlqExecute(cx.sQlconexion, "DELETE FROM Deposito " &
                    " WHERE (Id_CuentaBancaria = " & IdCuenta & ") AND (NumeroDocumento = " & BindingContext(DsCierreDiario1, "CierreDiario_Depositos").Current("Deposito") & ")")


                TextEditDepositar.EditValue = TextEditDepositar.EditValue + BindingContext(DsCierreDiario1, "CierreDiario_Depositos").Current("Monto")

                BindingContext(DsCierreDiario1, "CierreDiario_Depositos").RemoveAt(o)
                BindingContext(DsCierreDiario1, "CierreDiario_Depositos").EndCurrentEdit()
            End If
        End If
    End Sub

    Private Sub cbCuentaBancaria_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbCuentaBancaria.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtDeposito.Focus()
        End If
    End Sub

    Private Sub GridControl3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControl3.KeyDown
        If e.KeyCode = Keys.Delete Then
            EliminarDepositos()
        End If
    End Sub

    Private Sub cbMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbMoneda.KeyDown
        Dim TOTAL As Double
        Dim N As Integer
        If e.KeyCode = Keys.Enter Then
            Dim montoPendiente As Double = Me.TextEditDepositar.EditValue
            If Me.cbMoneda.SelectedValue = 2 Then
                montoPendiente = montoPendiente / Me.TipoCambioD
            End If
            txtMontoDep.EditValue = montoPendiente
            dtFechaDeposito.Enabled = True
            txtMontoDep.Enabled = True
            txtDeposito.Enabled = True
            cbCuentaBancaria.Enabled = True

            cFunciones.Llenar_Tabla_Generico("SELECT * FROM Cuentas_bancarias WHERE (Cod_Moneda = " & Me.cbMoneda.SelectedValue & ")", Me.DsCierreDiario1.Cuentas_bancarias, Configuracion.Claves.Conexion("Bancos"))
            BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("TipoCambio") = Me.DsCierreDiario1.Moneda(Me.cbMoneda.SelectedIndex).ValorVenta
            dtFechaDeposito.Value = dtFecha.Value
            dtFechaDeposito.Focus()

        End If

    End Sub

    Private Sub dtFechaDeposito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFechaDeposito.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMontoDep.Focus()
        End If
    End Sub
    Private Sub txtMontoDep_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoDep.KeyDown
        If e.KeyCode = Keys.Enter Then
            'If txtMontoDep.Text > Me.TextEditDepositar.EditValue Then
            '    MsgBox("El monto digitado es mayor que el reporte de los cajeros, Favor Revisar...", MsgBoxStyle.Information, "Atención...")
            '    txtMontoDep.Text = Format(MontoDeposito, "#,#0.00")
            '    txtMontoDep.Focus()
            '    Exit Sub
            'End If
            cbCuentaBancaria.Focus()
        End If
    End Sub

    Private Sub txtDeposito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDeposito.KeyDown
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim Id_Cuenta As Integer
        Dim Depositos As Double
        'ojo


        If e.KeyCode = Keys.Enter Then

            For Each X As dsCierreDiario.CierreDiario_DepositosRow In Me.DsCierreDiario1.CierreDiario_Depositos
                If Me.txtDeposito.Text = X.Deposito And Me.cbCuentaBancaria.Text = X.CuentaBancaria Then
                    MsgBox("El deposito ya se encuentra registrado, Favor Revisar....", MsgBoxStyle.Information, "Atención...")
                    txtDeposito.Focus()
                    Exit Sub
                End If
            Next

            sqlconexion = cconexion.Conectar(, "Bancos")
            Id_Cuenta = CInt(cconexion.SlqExecuteScalar(sqlconexion, "SELECT Id_CuentaBancaria FROM Cuentas_bancarias WHERE Cuenta = '" & cbCuentaBancaria.Text & "'"))
            Depositos = CDbl(cconexion.SlqExecuteScalar(sqlconexion, "SELECT NumeroDocumento FROM Deposito WHERE Id_CuentaBancaria = '" & Id_Cuenta & "' and NumeroDocumento =" & txtDeposito.Text))

            If Depositos <> 0 Then
                MsgBox("El deposito ya se encuentra registrado, Favor Revisar....", MsgBoxStyle.Information, "Atención...")
                txtDeposito.Focus()
                Exit Sub
            Else
                RegistrarDepositos()
            End If
            cconexion.DesConectar(sqlconexion)
            cbCuentaBancaria.Focus()
        End If
    End Sub
    Private Sub txtMontoDep_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoDep.KeyPress
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then ' valida que en este campo solo se digiten numeros y/o "-"
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) And Not (e.KeyChar = "."c) Then
                e.Handled = True  ' esto invalida la tecla pulsada
            End If
        End If
    End Sub


    Private Sub ButtonVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVer.Click
        Dim frm As New FormVistaComisiones
        frm.fecha = Me.dtFecha.Value
        frm.MdiParent = Me.MdiParent
        frm.Show()
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
    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String)
        Dim fx As New cFunciones
        Dim TipoCambio As Double = TipoCambioD
        Try
            If Monto <> 0 Then

                'If engrosarlacuenta(Monto, Debe, Haber, Cuenta, NombreCuenta) Then

                '    Exit Sub
                'End If
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
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = TipoCambio
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()

            End If
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

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
            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try
    End Function


    Private Sub cbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbMoneda.SelectedIndexChanged

    End Sub

    Private Sub txtDeposito_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDeposito.EditValueChanged

    End Sub

    Private Sub ButtonVerAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerAsiento.Click
        'Me.GenerarAsiento()
        Me._sp_GENERACIONASIENTOS2()
    End Sub


    Private Sub ButtonConta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonConta.Click
        agregarCuentadeDiferencial()

    End Sub
    Sub agregarCuentadeDiferencial()
        Dim cx As New Conexion
        Dim funcion As New cFunciones
        Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Buscar Cuenta Contable", Configuracion.Claves.Conexion("Contabilidad"))
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))

        If Id Is Nothing Then Exit Sub

        BindingContext(DsCierreDiario1, "ContaDiferencial").AddNew()
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Cierre") = "0"
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Monto") = CDbl(TextBoxDiferencial.Text)
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("CuentaContable") = dt.Rows(0).Item("CuentaContable")
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("NombreCuenta") = dt.Rows(0).Item("Descripcion")
        BindingContext(DsCierreDiario1, "ContaDiferencial").EndCurrentEdit()

        Dim total As Double = 0
        For i As Integer = 0 To Me.DsCierreDiario1.ContaDiferencial.Count - 1
            total += Me.DsCierreDiario1.ContaDiferencial(i).Monto

        Next

        TextBoxDiferencial.Text = Sobrante + Faltante - total

    End Sub

    Private Sub ButtonDiferencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDiferencias.Click
        Me.GroupBoxDistribuirDiferencial.Visible = True
        Me.TextBoxDiferencial.Text = Format(Sobrante + Faltante, "#,##0.00")

    End Sub

    Private Sub ButtonListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListo.Click
        Me.GroupBoxDistribuirDiferencial.Visible = False
    End Sub

    Private Sub ButtonGasto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonGasto.Click
        Dim cx As New Conexion
        Dim funcion As New cFunciones
        Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Buscar Cuenta Contable", Configuracion.Claves.Conexion("Contabilidad"))
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))

        If Id Is Nothing Then Exit Sub

        BindingContext(DsCierreDiario1, "ContaDiferencial").AddNew()
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Cierre") = "0"
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Monto") = CDbl(TextBoxDiferencial.Text)
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("CuentaContable") = dt.Rows(0).Item("CuentaContable")
        BindingContext(DsCierreDiario1, "ContaDiferencial").Current("NombreCuenta") = dt.Rows(0).Item("Descripcion")
        BindingContext(DsCierreDiario1, "ContaDiferencial").EndCurrentEdit()

        Dim total As Double = 0
        For i As Integer = 0 To Me.DsCierreDiario1.ContaDiferencial.Count - 1
            total += Me.DsCierreDiario1.ContaDiferencial(i).Monto

        Next


    End Sub


    Private Sub GridControlDiferencias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridControlDiferencias.KeyDown
        TextBoxDiferencial.Text = CDbl(TextBoxDiferencial.Text) + BindingContext(DsCierreDiario1, "ContaDiferencial").Current("Monto")
        BindingContext(DsCierreDiario1, "ContaDiferencial").RemoveAt(BindingContext(DsCierreDiario1, "ContaDiferencial").Position)
        BindingContext(DsCierreDiario1, "ContaDiferencial").EndCurrentEdit()

    End Sub

    Private Sub ButtonImportarDep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonImportarDep.Click
        importarDepositos()
    End Sub
    Sub importarDepositos()
        Dim vFechas As New FormFechaDepositos
        vFechas.ShowDialog()
        Dim fecha As DateTime
        fecha = vFechas.DateTimePicker1.Value
        Dim cconexion As New Conexion
        Dim sqlconexion As New SqlClient.SqlConnection
        Dim BaseDatos As SqlDataReader
        Dim sqlconexion1 As SqlClient.SqlConnection
        Dim cconexion1 As New Conexion
        Dim sqlconexion2 As SqlClient.SqlConnection
        Dim cconexion2 As New Conexion
        sqlconexion = cconexion.Conectar("SeeSoft", "Hotel")
        'Consulta Efectivo en Colones en tabla arqueo caja
        BaseDatos = cconexion.GetRecorset(sqlconexion, "Select distinct(BaseDatos) from PuntoVenta")
        Dim dt_CuentasBancarias As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT * FROM  CuentaDepositosCajas INNER JOIN " &
                      " Bancos.dbo.Cuentas_bancarias ON CuentaDepositosCajas.Id_Cuenta_Depositos_Cajas = Bancos.dbo.Cuentas_bancarias.Id_CuentaBancaria", dt_CuentasBancarias, Configuracion.Claves.Conexion("Contabilidad"))
        Dim idCuentaColon As Integer = 0
        Dim idcuentaDolar As Integer = 0

        If dt_CuentasBancarias.Rows.Count > 0 Then

            idCuentaColon = dt_CuentasBancarias.Rows(0).Item(0)

            If dt_CuentasBancarias.Rows.Count > 1 Then
                idcuentaDolar = dt_CuentasBancarias.Rows(1).Item(0)

            Else
                idcuentaDolar = idCuentaColon

            End If

        Else
            MsgBox("Falta Configuracion de cuentas", MsgBoxStyle.OkOnly, "Atención")
            Exit Sub

        End If

        While BaseDatos.Read

            Dim dt_InformacionImportar As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT     aperturacaja.NApertura, dbo.DateOnly(aperturacaja.Fecha) AS Fecha, ArqueoCajas.EfectivoColones, ArqueoCajas.NumDepColon, " &
              "          ArqueoCajas.EfectivoDolares,ArqueoCajas.TipoCambioD, ArqueoCajas.NumDepDolar, aperturacaja.Anulado " &
                " FROM         aperturacaja INNER JOIN " &
                "                    ArqueoCajas ON aperturacaja.NApertura = ArqueoCajas.IdApertura " &
                " WHERE     (dbo.DateOnly(aperturacaja.Fecha) = '" & dtFecha.Value.Date & "') AND (aperturacaja.Anulado = 0) AND (ArqueoCajas.Anulado = 0)", dt_InformacionImportar, Configuracion.Claves.Configuracion(BaseDatos("BaseDatos")))

            If dt_InformacionImportar.Rows.Count > 0 Then
                For i As Integer = 0 To dt_InformacionImportar.Rows.Count - 1
                    If dt_InformacionImportar.Rows(i).Item("EfectivoDolares") > 0 Then

                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").AddNew()
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = dt_InformacionImportar.Rows(i).Item("EfectivoDolares") * TipoCambioD
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Fecha") = fecha
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Deposito") = dt_InformacionImportar.Rows(i).Item("NumDepDolar")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("CuentaBancaria") = dt_CuentasBancarias.Rows(1).Item("Cuenta")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Moneda") = "DOLAR"
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("MontoM") = dt_InformacionImportar.Rows(i).Item("EfectivoDolares")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Nuevo") = True
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("TipoCambio") = dt_InformacionImportar.Rows(i).Item("TipoCambioD")
                        TextEditDepositar.EditValue = TextEditDepositar.EditValue - dt_InformacionImportar.Rows(i).Item("EfectivoDolares") * TipoCambioD

                    End If
                    If dt_InformacionImportar.Rows(i).Item("EfectivoColones") > 0 Then
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").AddNew()
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Monto") = dt_InformacionImportar.Rows(i).Item("EfectivoColones")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Fecha") = fecha
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Deposito") = dt_InformacionImportar.Rows(i).Item("NumDepColon")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("CuentaBancaria") = dt_CuentasBancarias.Rows(0).Item("Cuenta")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Moneda") = "COLON"
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("MontoM") = dt_InformacionImportar.Rows(i).Item("EfectivoColones")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("Nuevo") = True
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").Current("TipoCambio") = dt_InformacionImportar.Rows(i).Item("TipoCambioD")
                        BindingContext(DsCierreDiario1, "CierreDiario.CierreDiarioCierreDiario_Depositos").EndCurrentEdit()
                        TextEditDepositar.EditValue = TextEditDepositar.EditValue - dt_InformacionImportar.Rows(i).Item("EfectivoColones")


                    End If


                Next
            End If

        End While
        TotalDepositos()

    End Sub

    Private Sub dtFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtFecha.ValueChanged

    End Sub

    Private Sub ButtonAperturas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAperturas.Click
        Me.verCajas()
    End Sub

    Private Sub txtUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsuario.TextChanged

    End Sub
End Class

