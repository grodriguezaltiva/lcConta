Imports System.Data.SqlClient
Imports DevExpress.XtraTreeList
Imports Utilidades
Imports Utilidades_DB

Public Class Cuentas_Contables
    Inherits Plantilla

#Region "Variables"
    Dim Entrar As Boolean = True
    Public TablaCuentas As New DataTable
    Public TablaCuenta As New DataTable
    Public TablaEliminar As New DataTable
    Public TablaNiveles As New DataTable
    Public TablaDescripcionCuentaPresupuesto As New DataTable
    Dim Reporte_ID As Integer
    Dim ContadorNivel, s, Padre, h, r, Editando, Posicion As Integer
    Dim usua As Object
    Dim strModulo As String : Dim nuevaconexion As String
    Dim posi As Integer = 0
    Dim separador As Char
    Dim n1, n2, n3, n4, n5, n6, n7, n8 As Integer
    Dim cuenta, nodo, Mascara As String
    Dim niveles, pos As Integer
    Dim movimiento As Boolean = False
    Friend WithEvents pnPresupuesto As System.Windows.Forms.Panel
    Friend WithEvents grbPermisos As System.Windows.Forms.GroupBox
    Friend WithEvents chbConfigurar As System.Windows.Forms.CheckBox
    Friend WithEvents chbFactura As System.Windows.Forms.CheckBox
    Friend WithEvents chbContabilidad As System.Windows.Forms.CheckBox
    Friend WithEvents chbInventario As System.Windows.Forms.CheckBox
    Friend WithEvents chbCompras As System.Windows.Forms.CheckBox
    Friend WithEvents chbActFijo As System.Windows.Forms.CheckBox
    Friend WithEvents chbPlanilla As System.Windows.Forms.CheckBox
    Friend WithEvents chbCxP As System.Windows.Forms.CheckBox
    Friend WithEvents chbCXC As System.Windows.Forms.CheckBox
    Friend WithEvents chbBancos As System.Windows.Forms.CheckBox
    Friend WithEvents chbCheques As System.Windows.Forms.CheckBox
    Friend WithEvents btnPermisos As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents chbInactivar As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboTipoConversion As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents TreeListColumnInactiva As Columns.TreeListColumn
    Friend WithEvents txtNotas As System.Windows.Forms.ComboBox
    Friend WithEvents chbGastoNoDeducible As System.Windows.Forms.CheckBox
    Dim tipo As String
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        nuevaconexion = conexion


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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataSetCuentasContables1 As Contabilidad.DataSetCuentasContables
    Friend WithEvents AdapterFormatoCuenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNivel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuentaMadre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlControles As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterTipoCuenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtPadre As System.Windows.Forms.TextBox
    Private WithEvents colCuentaContable As Columns.TreeListColumn
    Private WithEvents colTipo As Columns.TreeListColumn
    Private WithEvents TreeList1 As TreeList
    Friend WithEvents AdapterCuentasContables As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtDescripcionMadre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ButAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ButNuevoDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Private WithEvents colCuenta As Columns.TreeListColumn
    Private WithEvents colDescripcion As Columns.TreeListColumn
    Private WithEvents colMovimiento As Columns.TreeListColumn
    Private WithEvents colEvaluacion As Columns.TreeListColumn
    Private WithEvents TreeListTipo As Columns.TreeListColumn
    Friend WithEvents adTipoCompra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cbTipoCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents lbTipoCuenta As System.Windows.Forms.Label
    Friend WithEvents ckTipoCompra As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtcuentaPresupuestaria As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnBuecarCuentaPresupuesto As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescripcioncuentaPresupuesto As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuentas_Contables))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbMovimiento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.DataSetCuentasContables1 = New Contabilidad.DataSetCuentasContables()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.AdapterFormatoCuenta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.txtCuenta = New DevExpress.XtraEditors.TextEdit()
        Me.txtNivel = New DevExpress.XtraEditors.TextEdit()
        Me.txtCuentaMadre = New DevExpress.XtraEditors.TextEdit()
        Me.pnlControles = New System.Windows.Forms.Panel()
        Me.btnPermisos = New System.Windows.Forms.Button()
        Me.ckTipoCompra = New System.Windows.Forms.CheckBox()
        Me.cbTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.lbTipoCuenta = New System.Windows.Forms.Label()
        Me.ButNuevoDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButAgregarDetalle = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.chbInactivar = New System.Windows.Forms.CheckBox()
        Me.txtDescripcionMadre = New System.Windows.Forms.TextBox()
        Me.grbPermisos = New System.Windows.Forms.GroupBox()
        Me.chbGastoNoDeducible = New System.Windows.Forms.CheckBox()
        Me.txtNotas = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pnPresupuesto = New System.Windows.Forms.Panel()
        Me.btnBuecarCuentaPresupuesto = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescripcioncuentaPresupuesto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcuentaPresupuestaria = New DevExpress.XtraEditors.TextEdit()
        Me.cboTipoConversion = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboMoneda = New System.Windows.Forms.ComboBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.chbConfigurar = New System.Windows.Forms.CheckBox()
        Me.chbFactura = New System.Windows.Forms.CheckBox()
        Me.chbContabilidad = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.chbInventario = New System.Windows.Forms.CheckBox()
        Me.chbCompras = New System.Windows.Forms.CheckBox()
        Me.chbActFijo = New System.Windows.Forms.CheckBox()
        Me.chbPlanilla = New System.Windows.Forms.CheckBox()
        Me.chbCxP = New System.Windows.Forms.CheckBox()
        Me.chbCXC = New System.Windows.Forms.CheckBox()
        Me.chbBancos = New System.Windows.Forms.CheckBox()
        Me.chbCheques = New System.Windows.Forms.CheckBox()
        Me.AdapterTipoCuenta = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.TxtPadre = New System.Windows.Forms.TextBox()
        Me.colCuentaContable = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colTipo = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me.colCuenta = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colDescripcion = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colMovimiento = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.colEvaluacion = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListTipo = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.TreeListColumnInactiva = New DevExpress.XtraTreeList.Columns.TreeListColumn()
        Me.AdapterCuentasContables = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
        Me.adTipoCompra = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
        CType(Me.DataSetCuentasContables1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaMadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControles.SuspendLayout()
        Me.grbPermisos.SuspendLayout()
        Me.pnPresupuesto.SuspendLayout()
        CType(Me.txtcuentaPresupuestaria.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 442)
        Me.ToolBar1.Size = New System.Drawing.Size(839, 52)
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Text = "Editar"
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.White
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.Size = New System.Drawing.Size(839, 32)
        Me.TituloModulo.Text = "Formulario Cuentas Contables"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Código Cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(327, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(506, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Descripción"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(9, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Nivel"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(75, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Movimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMovimiento
        '
        Me.cmbMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMovimiento.Items.AddRange(New Object() {"SÍ", "NO"})
        Me.cmbMovimiento.Location = New System.Drawing.Point(75, 54)
        Me.cmbMovimiento.Name = "cmbMovimiento"
        Me.cmbMovimiento.Size = New System.Drawing.Size(106, 21)
        Me.cmbMovimiento.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(6, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 16)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Cuenta Madre"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(188, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(527, 16)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Descripción Cta. Madre"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(188, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 99
        Me.Label7.Text = "Tipo Cuenta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipo
        '
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Items.AddRange(New Object() {"ACTIVOS", "PASIVOS", "CAPITAL", "INGRESOS", "COSTO VENTA", "GASTOS", "OTROS INGRESOS", "OTROS GASTOS"})
        Me.cmbTipo.Location = New System.Drawing.Point(188, 54)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(131, 21)
        Me.cmbTipo.TabIndex = 100
        '
        'DataSetCuentasContables1
        '
        Me.DataSetCuentasContables1.DataSetName = "DataSetCuentasContables"
        Me.DataSetCuentasContables1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSetCuentasContables1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=IALVAREZ\MOTOR4;Initial Catalog=Contabilidad;Integrated Security=True" &
    ""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'AdapterFormatoCuenta
        '
        Me.AdapterFormatoCuenta.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterFormatoCuenta.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterFormatoCuenta.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterFormatoCuenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FormatoCuenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Niveles", "Niveles"), New System.Data.Common.DataColumnMapping("N1", "N1"), New System.Data.Common.DataColumnMapping("N2", "N2"), New System.Data.Common.DataColumnMapping("N3", "N3"), New System.Data.Common.DataColumnMapping("N4", "N4"), New System.Data.Common.DataColumnMapping("N5", "N5"), New System.Data.Common.DataColumnMapping("N6", "N6"), New System.Data.Common.DataColumnMapping("N7", "N7"), New System.Data.Common.DataColumnMapping("N8", "N8"), New System.Data.Common.DataColumnMapping("Separador", "Separador")})})
        Me.AdapterFormatoCuenta.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"), New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"), New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"), New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"), New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"), New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"), New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"), New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"), New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"), New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Niveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador FROM FormatoCuenta"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"), New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"), New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"), New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"), New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"), New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"), New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"), New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"), New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"), New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'txtCuenta
        '
        Me.txtCuenta.EditValue = ""
        Me.txtCuenta.Location = New System.Drawing.Point(8, 16)
        Me.txtCuenta.Name = "txtCuenta"
        '
        '
        '
        Me.txtCuenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuenta.Properties.Enabled = False
        Me.txtCuenta.Properties.MaskData.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCuenta.Size = New System.Drawing.Size(312, 19)
        Me.txtCuenta.TabIndex = 0
        '
        'txtNivel
        '
        Me.txtNivel.EditValue = ""
        Me.txtNivel.Location = New System.Drawing.Point(9, 54)
        Me.txtNivel.Name = "txtNivel"
        '
        '
        '
        Me.txtNivel.Properties.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(56, 19)
        Me.txtNivel.TabIndex = 105
        '
        'txtCuentaMadre
        '
        Me.txtCuentaMadre.EditValue = ""
        Me.txtCuentaMadre.Location = New System.Drawing.Point(6, 92)
        Me.txtCuentaMadre.Name = "txtCuentaMadre"
        '
        '
        '
        Me.txtCuentaMadre.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaMadre.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaMadre.Properties.Enabled = False
        Me.txtCuentaMadre.Properties.MaskData.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCuentaMadre.Size = New System.Drawing.Size(175, 19)
        Me.txtCuentaMadre.TabIndex = 106
        '
        'pnlControles
        '
        Me.pnlControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlControles.Controls.Add(Me.btnPermisos)
        Me.pnlControles.Controls.Add(Me.ckTipoCompra)
        Me.pnlControles.Controls.Add(Me.cbTipoCuenta)
        Me.pnlControles.Controls.Add(Me.lbTipoCuenta)
        Me.pnlControles.Controls.Add(Me.ButNuevoDetalle)
        Me.pnlControles.Controls.Add(Me.ButAgregarDetalle)
        Me.pnlControles.Controls.Add(Me.txtDescripcion)
        Me.pnlControles.Controls.Add(Me.chbInactivar)
        Me.pnlControles.Controls.Add(Me.txtDescripcionMadre)
        Me.pnlControles.Controls.Add(Me.Label5)
        Me.pnlControles.Controls.Add(Me.Label3)
        Me.pnlControles.Controls.Add(Me.Label4)
        Me.pnlControles.Controls.Add(Me.txtCuenta)
        Me.pnlControles.Controls.Add(Me.cmbMovimiento)
        Me.pnlControles.Controls.Add(Me.Label6)
        Me.pnlControles.Controls.Add(Me.Label8)
        Me.pnlControles.Controls.Add(Me.Label7)
        Me.pnlControles.Controls.Add(Me.cmbTipo)
        Me.pnlControles.Controls.Add(Me.txtNivel)
        Me.pnlControles.Controls.Add(Me.txtCuentaMadre)
        Me.pnlControles.Controls.Add(Me.Label1)
        Me.pnlControles.Location = New System.Drawing.Point(0, 32)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(839, 120)
        Me.pnlControles.TabIndex = 110
        '
        'btnPermisos
        '
        Me.btnPermisos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPermisos.Enabled = False
        Me.btnPermisos.Location = New System.Drawing.Point(721, 94)
        Me.btnPermisos.Name = "btnPermisos"
        Me.btnPermisos.Size = New System.Drawing.Size(112, 23)
        Me.btnPermisos.TabIndex = 124
        Me.btnPermisos.Text = "Config."
        Me.btnPermisos.UseVisualStyleBackColor = True
        '
        'ckTipoCompra
        '
        Me.ckTipoCompra.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ckTipoCompra.Location = New System.Drawing.Point(329, 38)
        Me.ckTipoCompra.Name = "ckTipoCompra"
        Me.ckTipoCompra.Size = New System.Drawing.Size(16, 16)
        Me.ckTipoCompra.TabIndex = 117
        Me.ckTipoCompra.UseVisualStyleBackColor = False
        '
        'cbTipoCuenta
        '
        Me.cbTipoCuenta.DataSource = Me.DataSetCuentasContables1
        Me.cbTipoCuenta.DisplayMember = "TipoCompra.Descripcion"
        Me.cbTipoCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoCuenta.Location = New System.Drawing.Point(327, 54)
        Me.cbTipoCuenta.Name = "cbTipoCuenta"
        Me.cbTipoCuenta.Size = New System.Drawing.Size(236, 21)
        Me.cbTipoCuenta.TabIndex = 116
        Me.cbTipoCuenta.ValueMember = "TipoCompra.Codigo"
        Me.cbTipoCuenta.Visible = False
        '
        'lbTipoCuenta
        '
        Me.lbTipoCuenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbTipoCuenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTipoCuenta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbTipoCuenta.Location = New System.Drawing.Point(326, 38)
        Me.lbTipoCuenta.Name = "lbTipoCuenta"
        Me.lbTipoCuenta.Size = New System.Drawing.Size(237, 16)
        Me.lbTipoCuenta.TabIndex = 115
        Me.lbTipoCuenta.Text = "Tipo Cuenta"
        Me.lbTipoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButNuevoDetalle
        '
        Me.ButNuevoDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButNuevoDetalle.ImageIndex = 2
        Me.ButNuevoDetalle.ImageList = Me.ImageList1
        Me.ButNuevoDetalle.Location = New System.Drawing.Point(721, 38)
        Me.ButNuevoDetalle.Name = "ButNuevoDetalle"
        Me.ButNuevoDetalle.Size = New System.Drawing.Size(112, 24)
        Me.ButNuevoDetalle.TabIndex = 111
        Me.ButNuevoDetalle.Text = "Nueva Cuenta"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        '
        'ButAgregarDetalle
        '
        Me.ButAgregarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButAgregarDetalle.ImageIndex = 0
        Me.ButAgregarDetalle.ImageList = Me.ImageList1
        Me.ButAgregarDetalle.Location = New System.Drawing.Point(721, 67)
        Me.ButAgregarDetalle.Name = "ButAgregarDetalle"
        Me.ButAgregarDetalle.Size = New System.Drawing.Size(112, 24)
        Me.ButAgregarDetalle.TabIndex = 110
        Me.ButAgregarDetalle.Text = "Guardar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcion.Location = New System.Drawing.Point(326, 16)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(507, 20)
        Me.txtDescripcion.TabIndex = 109
        '
        'chbInactivar
        '
        Me.chbInactivar.AutoSize = True
        Me.chbInactivar.Location = New System.Drawing.Point(569, 38)
        Me.chbInactivar.Name = "chbInactivar"
        Me.chbInactivar.Size = New System.Drawing.Size(64, 17)
        Me.chbInactivar.TabIndex = 12
        Me.chbInactivar.Text = "Inactiva"
        Me.chbInactivar.UseVisualStyleBackColor = True
        '
        'txtDescripcionMadre
        '
        Me.txtDescripcionMadre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescripcionMadre.Location = New System.Drawing.Point(188, 92)
        Me.txtDescripcionMadre.Name = "txtDescripcionMadre"
        Me.txtDescripcionMadre.ReadOnly = True
        Me.txtDescripcionMadre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcionMadre.Size = New System.Drawing.Size(527, 20)
        Me.txtDescripcionMadre.TabIndex = 108
        '
        'grbPermisos
        '
        Me.grbPermisos.Controls.Add(Me.chbGastoNoDeducible)
        Me.grbPermisos.Controls.Add(Me.txtNotas)
        Me.grbPermisos.Controls.Add(Me.Label12)
        Me.grbPermisos.Controls.Add(Me.Label10)
        Me.grbPermisos.Controls.Add(Me.pnPresupuesto)
        Me.grbPermisos.Controls.Add(Me.cboTipoConversion)
        Me.grbPermisos.Controls.Add(Me.Label11)
        Me.grbPermisos.Controls.Add(Me.cboMoneda)
        Me.grbPermisos.Controls.Add(Me.btnCerrar)
        Me.grbPermisos.Controls.Add(Me.chbConfigurar)
        Me.grbPermisos.Controls.Add(Me.chbFactura)
        Me.grbPermisos.Controls.Add(Me.chbContabilidad)
        Me.grbPermisos.Controls.Add(Me.CheckBox1)
        Me.grbPermisos.Controls.Add(Me.chbInventario)
        Me.grbPermisos.Controls.Add(Me.chbCompras)
        Me.grbPermisos.Controls.Add(Me.chbActFijo)
        Me.grbPermisos.Controls.Add(Me.chbPlanilla)
        Me.grbPermisos.Controls.Add(Me.chbCxP)
        Me.grbPermisos.Controls.Add(Me.chbCXC)
        Me.grbPermisos.Controls.Add(Me.chbBancos)
        Me.grbPermisos.Controls.Add(Me.chbCheques)
        Me.grbPermisos.Location = New System.Drawing.Point(6, 150)
        Me.grbPermisos.Name = "grbPermisos"
        Me.grbPermisos.Size = New System.Drawing.Size(595, 190)
        Me.grbPermisos.TabIndex = 124
        Me.grbPermisos.TabStop = False
        Me.grbPermisos.Text = "Configuración y Permisos "
        Me.grbPermisos.Visible = False
        '
        'chbGastoNoDeducible
        '
        Me.chbGastoNoDeducible.AutoSize = True
        Me.chbGastoNoDeducible.Location = New System.Drawing.Point(466, 58)
        Me.chbGastoNoDeducible.Name = "chbGastoNoDeducible"
        Me.chbGastoNoDeducible.Size = New System.Drawing.Size(89, 17)
        Me.chbGastoNoDeducible.TabIndex = 130
        Me.chbGastoNoDeducible.Text = "No deducible"
        Me.chbGastoNoDeducible.UseVisualStyleBackColor = True
        '
        'txtNotas
        '
        Me.txtNotas.FormattingEnabled = True
        Me.txtNotas.Items.AddRange(New Object() {"", "4-A", "4-B", "4-C", "4-D", "4-E", "4-F", "4-G", "4-H", "4-I", "4-J", "4-K", "4-L"})
        Me.txtNotas.Location = New System.Drawing.Point(345, 60)
        Me.txtNotas.Name = "txtNotas"
        Me.txtNotas.Size = New System.Drawing.Size(112, 21)
        Me.txtNotas.TabIndex = 129
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(345, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 16)
        Me.Label12.TabIndex = 127
        Me.Label12.Text = "# Nota"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(345, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 16)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "Tipo Conversión"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnPresupuesto
        '
        Me.pnPresupuesto.Controls.Add(Me.btnBuecarCuentaPresupuesto)
        Me.pnPresupuesto.Controls.Add(Me.txtDescripcioncuentaPresupuesto)
        Me.pnPresupuesto.Controls.Add(Me.Label2)
        Me.pnPresupuesto.Controls.Add(Me.Label9)
        Me.pnPresupuesto.Controls.Add(Me.txtcuentaPresupuestaria)
        Me.pnPresupuesto.Location = New System.Drawing.Point(4, 135)
        Me.pnPresupuesto.Name = "pnPresupuesto"
        Me.pnPresupuesto.Size = New System.Drawing.Size(585, 45)
        Me.pnPresupuesto.TabIndex = 123
        Me.pnPresupuesto.Visible = False
        '
        'btnBuecarCuentaPresupuesto
        '
        Me.btnBuecarCuentaPresupuesto.Enabled = False
        Me.btnBuecarCuentaPresupuesto.ImageList = Me.ImageList1
        Me.btnBuecarCuentaPresupuesto.Location = New System.Drawing.Point(497, 6)
        Me.btnBuecarCuentaPresupuesto.Name = "btnBuecarCuentaPresupuesto"
        Me.btnBuecarCuentaPresupuesto.Size = New System.Drawing.Size(80, 36)
        Me.btnBuecarCuentaPresupuesto.TabIndex = 120
        Me.btnBuecarCuentaPresupuesto.Text = "Buscar.Cta.P"
        '
        'txtDescripcioncuentaPresupuesto
        '
        Me.txtDescripcioncuentaPresupuesto.Location = New System.Drawing.Point(187, 22)
        Me.txtDescripcioncuentaPresupuesto.Name = "txtDescripcioncuentaPresupuesto"
        Me.txtDescripcioncuentaPresupuesto.ReadOnly = True
        Me.txtDescripcioncuentaPresupuesto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcioncuentaPresupuesto.Size = New System.Drawing.Size(303, 20)
        Me.txtDescripcioncuentaPresupuesto.TabIndex = 122
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(3, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 16)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Cuenta Presupuestaria"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(187, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(303, 16)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Descripción Cta. Presupuesto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcuentaPresupuestaria
        '
        Me.txtcuentaPresupuestaria.EditValue = ""
        Me.txtcuentaPresupuestaria.Location = New System.Drawing.Point(3, 22)
        Me.txtcuentaPresupuestaria.Name = "txtcuentaPresupuestaria"
        '
        '
        '
        Me.txtcuentaPresupuestaria.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtcuentaPresupuestaria.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtcuentaPresupuestaria.Properties.Enabled = False
        Me.txtcuentaPresupuestaria.Properties.MaskData.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtcuentaPresupuestaria.Size = New System.Drawing.Size(175, 19)
        Me.txtcuentaPresupuestaria.TabIndex = 119
        '
        'cboTipoConversion
        '
        Me.cboTipoConversion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoConversion.Items.AddRange(New Object() {"CONVERSION", "PROMEDIO", "HISTORICO", "NO APLICA"})
        Me.cboTipoConversion.Location = New System.Drawing.Point(345, 106)
        Me.cboTipoConversion.Name = "cboTipoConversion"
        Me.cboTipoConversion.Size = New System.Drawing.Size(112, 21)
        Me.cboTipoConversion.TabIndex = 124
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(463, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 16)
        Me.Label11.TabIndex = 125
        Me.Label11.Text = "Moneda"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboMoneda
        '
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.Items.AddRange(New Object() {"NOMINAL", "DOLAR"})
        Me.cboMoneda.Location = New System.Drawing.Point(463, 106)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(112, 21)
        Me.cboMoneda.TabIndex = 123
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(501, 7)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(80, 32)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Listo"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'chbConfigurar
        '
        Me.chbConfigurar.Checked = True
        Me.chbConfigurar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbConfigurar.Location = New System.Drawing.Point(8, 68)
        Me.chbConfigurar.Name = "chbConfigurar"
        Me.chbConfigurar.Size = New System.Drawing.Size(101, 17)
        Me.chbConfigurar.TabIndex = 10
        Me.chbConfigurar.Text = "Ajustes Bancos"
        '
        'chbFactura
        '
        Me.chbFactura.Checked = True
        Me.chbFactura.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbFactura.Location = New System.Drawing.Point(250, 61)
        Me.chbFactura.Name = "chbFactura"
        Me.chbFactura.Size = New System.Drawing.Size(79, 24)
        Me.chbFactura.TabIndex = 8
        Me.chbFactura.Text = "Factura"
        Me.chbFactura.Visible = False
        '
        'chbContabilidad
        '
        Me.chbContabilidad.Checked = True
        Me.chbContabilidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbContabilidad.Location = New System.Drawing.Point(115, 87)
        Me.chbContabilidad.Name = "chbContabilidad"
        Me.chbContabilidad.Size = New System.Drawing.Size(104, 24)
        Me.chbContabilidad.TabIndex = 9
        Me.chbContabilidad.Text = "Asiento Manual"
        '
        'CheckBox1
        '
        Me.CheckBox1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.CheckBox1.Location = New System.Drawing.Point(345, 10)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(80, 24)
        Me.CheckBox1.TabIndex = 114
        Me.CheckBox1.Text = "Valuación"
        '
        'chbInventario
        '
        Me.chbInventario.Checked = True
        Me.chbInventario.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbInventario.Location = New System.Drawing.Point(8, 87)
        Me.chbInventario.Name = "chbInventario"
        Me.chbInventario.Size = New System.Drawing.Size(80, 24)
        Me.chbInventario.TabIndex = 6
        Me.chbInventario.Text = "Inventario"
        '
        'chbCompras
        '
        Me.chbCompras.Checked = True
        Me.chbCompras.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbCompras.Location = New System.Drawing.Point(115, 64)
        Me.chbCompras.Name = "chbCompras"
        Me.chbCompras.Size = New System.Drawing.Size(72, 24)
        Me.chbCompras.TabIndex = 7
        Me.chbCompras.Text = "Gastos"
        '
        'chbActFijo
        '
        Me.chbActFijo.Checked = True
        Me.chbActFijo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbActFijo.Location = New System.Drawing.Point(250, 12)
        Me.chbActFijo.Name = "chbActFijo"
        Me.chbActFijo.Size = New System.Drawing.Size(79, 24)
        Me.chbActFijo.TabIndex = 4
        Me.chbActFijo.Text = "Activos Fijos"
        Me.chbActFijo.Visible = False
        '
        'chbPlanilla
        '
        Me.chbPlanilla.Checked = True
        Me.chbPlanilla.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPlanilla.Location = New System.Drawing.Point(250, 37)
        Me.chbPlanilla.Name = "chbPlanilla"
        Me.chbPlanilla.Size = New System.Drawing.Size(79, 24)
        Me.chbPlanilla.TabIndex = 5
        Me.chbPlanilla.Text = "Planillas"
        Me.chbPlanilla.Visible = False
        '
        'chbCxP
        '
        Me.chbCxP.Checked = True
        Me.chbCxP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbCxP.Location = New System.Drawing.Point(115, 16)
        Me.chbCxP.Name = "chbCxP"
        Me.chbCxP.Size = New System.Drawing.Size(120, 24)
        Me.chbCxP.TabIndex = 2
        Me.chbCxP.Text = "Cuentas por Pagar"
        '
        'chbCXC
        '
        Me.chbCXC.Checked = True
        Me.chbCXC.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbCXC.Location = New System.Drawing.Point(115, 42)
        Me.chbCXC.Name = "chbCXC"
        Me.chbCXC.Size = New System.Drawing.Size(129, 21)
        Me.chbCXC.TabIndex = 3
        Me.chbCXC.Text = "Cuentas por Cobrar"
        '
        'chbBancos
        '
        Me.chbBancos.Checked = True
        Me.chbBancos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbBancos.Location = New System.Drawing.Point(8, 16)
        Me.chbBancos.Name = "chbBancos"
        Me.chbBancos.Size = New System.Drawing.Size(80, 24)
        Me.chbBancos.TabIndex = 0
        Me.chbBancos.Text = "Depositos"
        '
        'chbCheques
        '
        Me.chbCheques.Checked = True
        Me.chbCheques.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbCheques.Location = New System.Drawing.Point(8, 42)
        Me.chbCheques.Name = "chbCheques"
        Me.chbCheques.Size = New System.Drawing.Size(72, 24)
        Me.chbCheques.TabIndex = 1
        Me.chbCheques.Text = "Cheques"
        '
        'AdapterTipoCuenta
        '
        Me.AdapterTipoCuenta.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterTipoCuenta.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterTipoCuenta.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterTipoCuenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoCuenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdapterTipoCuenta.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM TipoCuenta WHERE (Id = @Original_Id)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO TipoCuenta(Nombre) VALUES (@Nombre); SELECT Id, Nombre FROM TipoCuent" &
    "a WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Nombre FROM TipoCuenta"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE TipoCuenta SET Nombre = @Nombre WHERE (Id = @Original_Id); SELECT Id, Nomb" &
    "re FROM TipoCuenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id")})
        '
        'TxtPadre
        '
        Me.TxtPadre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetCuentasContables1, "CuentaContable.PARENTID", True))
        Me.TxtPadre.Location = New System.Drawing.Point(392, 0)
        Me.TxtPadre.Name = "TxtPadre"
        Me.TxtPadre.Size = New System.Drawing.Size(24, 20)
        Me.TxtPadre.TabIndex = 111
        '
        'colCuentaContable
        '
        Me.colCuentaContable.Caption = "CuentaContable"
        Me.colCuentaContable.FieldName = "CuentaContable"
        Me.colCuentaContable.Name = "colCuentaContable"
        Me.colCuentaContable.Options = CType((((((DevExpress.XtraTreeList.Columns.ColumnOptions.CanMoved Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanMovedToCustomizationForm), DevExpress.XtraTreeList.Columns.ColumnOptions)
        Me.colCuentaContable.VisibleIndex = 0
        Me.colCuentaContable.Width = 29
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Options = CType((((((DevExpress.XtraTreeList.Columns.ColumnOptions.CanMoved Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanResized) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanSorted) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.[ReadOnly]) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.ShowInCustomizationForm) _
            Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanMovedToCustomizationForm), DevExpress.XtraTreeList.Columns.ColumnOptions)
        Me.colTipo.VisibleIndex = 1
        Me.colTipo.Width = 30
        '
        'TreeList1
        '
        Me.TreeList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList1.BehaviorOptions = CType(((((((((DevExpress.XtraTreeList.BehaviorOptionsFlags.MoveOnEdit Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ExpandNodeOnDrag) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ResizeNodes) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoSelectAllInEditor) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoNodeHeight) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoChangeParent) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.CloseEditorOnLostFocus) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.KeepSelectedOnClick) _
            Or DevExpress.XtraTreeList.BehaviorOptionsFlags.SmartMouseHover), DevExpress.XtraTreeList.BehaviorOptionsFlags)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCuenta, Me.colDescripcion, Me.colMovimiento, Me.colEvaluacion, Me.TreeListTipo, Me.TreeListColumnInactiva})
        Me.TreeList1.CustomizationRowCount = 6
        Me.TreeList1.DataMember = "CuentaContable"
        Me.TreeList1.DataSource = Me.DataSetCuentasContables1
        Me.TreeList1.Location = New System.Drawing.Point(0, 158)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.RootValue = "0"
        Me.TreeList1.Size = New System.Drawing.Size(833, 278)
        Me.TreeList1.TabIndex = 112
        Me.TreeList1.Text = "TreeList1"
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta"
        Me.colCuenta.FieldName = "CuentaContable"
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.colCuenta.VisibleIndex = 0
        Me.colCuenta.Width = 266
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Nombre"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 275
        '
        'colMovimiento
        '
        Me.colMovimiento.Caption = "Movimiento"
        Me.colMovimiento.FieldName = "Movimiento"
        Me.colMovimiento.Name = "colMovimiento"
        Me.colMovimiento.VisibleIndex = 3
        Me.colMovimiento.Width = 120
        '
        'colEvaluacion
        '
        Me.colEvaluacion.Caption = "Valuación"
        Me.colEvaluacion.FieldName = "Evaluacion"
        Me.colEvaluacion.Name = "colEvaluacion"
        Me.colEvaluacion.VisibleIndex = 4
        Me.colEvaluacion.Width = 120
        '
        'TreeListTipo
        '
        Me.TreeListTipo.Caption = "Tipo"
        Me.TreeListTipo.FieldName = "Tipo"
        Me.TreeListTipo.Name = "TreeListTipo"
        Me.TreeListTipo.VisibleIndex = 2
        Me.TreeListTipo.Width = 156
        '
        'TreeListColumnInactiva
        '
        Me.TreeListColumnInactiva.Caption = "Inactiva"
        Me.TreeListColumnInactiva.FieldName = "Inactivo"
        Me.TreeListColumnInactiva.Name = "TreeListColumnInactiva"
        Me.TreeListColumnInactiva.VisibleIndex = 5
        Me.TreeListColumnInactiva.Width = 120
        '
        'AdapterCuentasContables
        '
        Me.AdapterCuentasContables.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterCuentasContables.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterCuentasContables.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterCuentasContables.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Evaluacion", "Evaluacion"), New System.Data.Common.DataColumnMapping("CodTipoCompra", "CodTipoCompra"), New System.Data.Common.DataColumnMapping("DescTipoCompra", "DescTipoCompra"), New System.Data.Common.DataColumnMapping("CuentaContable_Presupuesto", "CuentaContable_Presupuesto"), New System.Data.Common.DataColumnMapping("PermisoCheque", "PermisoCheque"), New System.Data.Common.DataColumnMapping("PermisoBancos", "PermisoBancos"), New System.Data.Common.DataColumnMapping("PermisoCont", "PermisoCont"), New System.Data.Common.DataColumnMapping("PermisoCxP", "PermisoCxP"), New System.Data.Common.DataColumnMapping("PermisoCxC", "PermisoCxC"), New System.Data.Common.DataColumnMapping("PermisoAcF", "PermisoAcF"), New System.Data.Common.DataColumnMapping("PermisoInv", "PermisoInv"), New System.Data.Common.DataColumnMapping("PermisoGAS", "PermisoGAS"), New System.Data.Common.DataColumnMapping("PermisoFac", "PermisoFac"), New System.Data.Common.DataColumnMapping("PermisoPla", "PermisoPla"), New System.Data.Common.DataColumnMapping("PermisoConf", "PermisoConf"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("TipoConversion", "TipoConversion"), New System.Data.Common.DataColumnMapping("Inactivo", "Inactivo"), New System.Data.Common.DataColumnMapping("Notas", "Notas"), New System.Data.Common.DataColumnMapping("GastoNoDeducible", "GastoNoDeducible")})})
        Me.AdapterCuentasContables.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Evaluacion", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Evaluacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodTipoCompra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodTipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescTipoCompra", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescTipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable_Presupuesto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable_Presupuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCheque", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCheque", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoBancos", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoBancos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCont", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCont", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCxP", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCxP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCxC", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCxC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoAcF", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoAcF", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoInv", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoInv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoGAS", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoGAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoFac", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoFac", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoPla", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoPla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoConf", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoConversion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoConversion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Inactivo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Inactivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Notas", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_GastoNoDeducible", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GastoNoDeducible", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 0, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 0, "Nivel"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 0, "PARENTID"), New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 0, "CuentaMadre"), New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 0, "DescCuentaMadre"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 0, "Movimiento"), New System.Data.SqlClient.SqlParameter("@Evaluacion", System.Data.SqlDbType.Bit, 0, "Evaluacion"), New System.Data.SqlClient.SqlParameter("@CodTipoCompra", System.Data.SqlDbType.Int, 0, "CodTipoCompra"), New System.Data.SqlClient.SqlParameter("@DescTipoCompra", System.Data.SqlDbType.VarChar, 0, "DescTipoCompra"), New System.Data.SqlClient.SqlParameter("@CuentaContable_Presupuesto", System.Data.SqlDbType.VarChar, 0, "CuentaContable_Presupuesto"), New System.Data.SqlClient.SqlParameter("@PermisoCheque", System.Data.SqlDbType.Bit, 0, "PermisoCheque"), New System.Data.SqlClient.SqlParameter("@PermisoBancos", System.Data.SqlDbType.Bit, 0, "PermisoBancos"), New System.Data.SqlClient.SqlParameter("@PermisoCont", System.Data.SqlDbType.Bit, 0, "PermisoCont"), New System.Data.SqlClient.SqlParameter("@PermisoCxP", System.Data.SqlDbType.Bit, 0, "PermisoCxP"), New System.Data.SqlClient.SqlParameter("@PermisoCxC", System.Data.SqlDbType.Bit, 0, "PermisoCxC"), New System.Data.SqlClient.SqlParameter("@PermisoAcF", System.Data.SqlDbType.Bit, 0, "PermisoAcF"), New System.Data.SqlClient.SqlParameter("@PermisoInv", System.Data.SqlDbType.Bit, 0, "PermisoInv"), New System.Data.SqlClient.SqlParameter("@PermisoGAS", System.Data.SqlDbType.Bit, 0, "PermisoGAS"), New System.Data.SqlClient.SqlParameter("@PermisoFac", System.Data.SqlDbType.Bit, 0, "PermisoFac"), New System.Data.SqlClient.SqlParameter("@PermisoPla", System.Data.SqlDbType.Bit, 0, "PermisoPla"), New System.Data.SqlClient.SqlParameter("@PermisoConf", System.Data.SqlDbType.Bit, 0, "PermisoConf"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.VarChar, 0, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoConversion", System.Data.SqlDbType.VarChar, 0, "TipoConversion"), New System.Data.SqlClient.SqlParameter("@Inactivo", System.Data.SqlDbType.Bit, 0, "Inactivo"), New System.Data.SqlClient.SqlParameter("@Notas", System.Data.SqlDbType.VarChar, 0, "Notas"), New System.Data.SqlClient.SqlParameter("@GastoNoDeducible", System.Data.SqlDbType.Bit, 0, "GastoNoDeducible")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 0, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 0, "Nivel"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 0, "Tipo"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 0, "PARENTID"), New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 0, "CuentaMadre"), New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 0, "DescCuentaMadre"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 0, "Movimiento"), New System.Data.SqlClient.SqlParameter("@Evaluacion", System.Data.SqlDbType.Bit, 0, "Evaluacion"), New System.Data.SqlClient.SqlParameter("@CodTipoCompra", System.Data.SqlDbType.Int, 0, "CodTipoCompra"), New System.Data.SqlClient.SqlParameter("@DescTipoCompra", System.Data.SqlDbType.VarChar, 0, "DescTipoCompra"), New System.Data.SqlClient.SqlParameter("@CuentaContable_Presupuesto", System.Data.SqlDbType.VarChar, 0, "CuentaContable_Presupuesto"), New System.Data.SqlClient.SqlParameter("@PermisoCheque", System.Data.SqlDbType.Bit, 0, "PermisoCheque"), New System.Data.SqlClient.SqlParameter("@PermisoBancos", System.Data.SqlDbType.Bit, 0, "PermisoBancos"), New System.Data.SqlClient.SqlParameter("@PermisoCont", System.Data.SqlDbType.Bit, 0, "PermisoCont"), New System.Data.SqlClient.SqlParameter("@PermisoCxP", System.Data.SqlDbType.Bit, 0, "PermisoCxP"), New System.Data.SqlClient.SqlParameter("@PermisoCxC", System.Data.SqlDbType.Bit, 0, "PermisoCxC"), New System.Data.SqlClient.SqlParameter("@PermisoAcF", System.Data.SqlDbType.Bit, 0, "PermisoAcF"), New System.Data.SqlClient.SqlParameter("@PermisoInv", System.Data.SqlDbType.Bit, 0, "PermisoInv"), New System.Data.SqlClient.SqlParameter("@PermisoGAS", System.Data.SqlDbType.Bit, 0, "PermisoGAS"), New System.Data.SqlClient.SqlParameter("@PermisoFac", System.Data.SqlDbType.Bit, 0, "PermisoFac"), New System.Data.SqlClient.SqlParameter("@PermisoPla", System.Data.SqlDbType.Bit, 0, "PermisoPla"), New System.Data.SqlClient.SqlParameter("@PermisoConf", System.Data.SqlDbType.Bit, 0, "PermisoConf"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.VarChar, 0, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoConversion", System.Data.SqlDbType.VarChar, 0, "TipoConversion"), New System.Data.SqlClient.SqlParameter("@Inactivo", System.Data.SqlDbType.Bit, 0, "Inactivo"), New System.Data.SqlClient.SqlParameter("@Notas", System.Data.SqlDbType.VarChar, 0, "Notas"), New System.Data.SqlClient.SqlParameter("@GastoNoDeducible", System.Data.SqlDbType.Bit, 0, "GastoNoDeducible"), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Evaluacion", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Evaluacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodTipoCompra", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodTipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescTipoCompra", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescTipoCompra", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable_Presupuesto", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable_Presupuesto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCheque", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCheque", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoBancos", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoBancos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCont", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCont", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCxP", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCxP", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoCxC", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoCxC", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoAcF", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoAcF", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoInv", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoInv", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoGAS", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoGAS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoFac", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoFac", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoPla", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoPla", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PermisoConf", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PermisoConf", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoConversion", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoConversion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Inactivo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Inactivo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Notas", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notas", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_GastoNoDeducible", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "GastoNoDeducible", System.Data.DataRowVersion.Original, Nothing)})
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        Me.AdapterMoneda.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" &
    "riginal_MonedaNombre)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" &
    "persist security info=False;initial catalog=Seguridad"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre) VALUES (@CodMoneda, @MonedaNombre); S" &
    "ELECT CodMoneda, MonedaNombre FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre")})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CodMoneda, MonedaNombre FROM Moneda"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing)})
        '
        'adTipoCompra
        '
        Me.adTipoCompra.InsertCommand = Me.SqlInsertCommand5
        Me.adTipoCompra.SelectCommand = Me.SqlSelectCommand5
        Me.adTipoCompra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoCompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO TipoCompra(Codigo, Descripcion) VALUES (@Codigo, @Descripcion); SELEC" &
    "T Codigo, Descripcion FROM TipoCompra"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Codigo, Descripcion FROM TipoCompra"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'Cuentas_Contables
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(839, 494)
        Me.Controls.Add(Me.grbPermisos)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.TxtPadre)
        Me.Name = "Cuentas_Contables"
        Me.Text = "Cuentas Contables"
        Me.Controls.SetChildIndex(Me.TxtPadre, 0)
        Me.Controls.SetChildIndex(Me.pnlControles, 0)
        Me.Controls.SetChildIndex(Me.TreeList1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.grbPermisos, 0)
        CType(Me.DataSetCuentasContables1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaMadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControles.ResumeLayout(False)
        Me.pnlControles.PerformLayout()
        Me.grbPermisos.ResumeLayout(False)
        Me.grbPermisos.PerformLayout()
        Me.pnPresupuesto.ResumeLayout(False)
        Me.pnPresupuesto.PerformLayout()
        CType(Me.txtcuentaPresupuestaria.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub Cuentas_Contables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = IIf(nuevaconexion = "", Configuracion.Claves.Conexion("Contabilidad"), nuevaconexion)
            SqlConnection2.ConnectionString = IIf(nuevaconexion = "", Configuracion.Claves.Conexion("Seguridad"), nuevaconexion)

            If Configuracion.Claves.Configuracion("ConPresupuesto").Equals("SI") Then
                Me.pnPresupuesto.Visible = True
            End If

            '*******************************************************VALORES POR DEFECTO***********************************************************
            btnBuecarCuentaPresupuesto.Enabled = False
            DataSetCuentasContables1.CuentaContable.CuentaContableColumn.DefaultValue = "100"
            DataSetCuentasContables1.CuentaContable.DescripcionColumn.DefaultValue = ""
            DataSetCuentasContables1.CuentaContable.NivelColumn.DefaultValue = 1
            DataSetCuentasContables1.CuentaContable.TipoColumn.DefaultValue = 1
            DataSetCuentasContables1.CuentaContable.DescCuentaMadreColumn.DefaultValue = ""
            DataSetCuentasContables1.CuentaContable.MovimientoColumn.DefaultValue = False
            DataSetCuentasContables1.CuentaContable.PARENTIDColumn.DefaultValue = 0
            DataSetCuentasContables1.CuentaContable.CuentaMadreColumn.DefaultValue = "0"
            DataSetCuentasContables1.CuentaContable.EvaluacionColumn.DefaultValue = False
            DataSetCuentasContables1.CuentaContable.CodTipoCompraColumn.DefaultValue = 0
            DataSetCuentasContables1.CuentaContable.DescTipoCompraColumn.DefaultValue = ""

            '*******************************************************Llenar Tablas***********************************************************
            AdapterFormatoCuenta.Fill(DataSetCuentasContables1.FormatoCuenta)
            AdapterCuentasContables.Fill(DataSetCuentasContables1.CuentaContable)
            AdapterTipoCuenta.Fill(DataSetCuentasContables1.TipoCuenta)
            AdapterMoneda.Fill(DataSetCuentasContables1.Moneda)

            adTipoCompra.Fill(DataSetCuentasContables1.TipoCompra)

            ToolBarRegistrar.Enabled = False
            obtiene_formato()

            If Not BindingContext(DataSetCuentasContables1, "CuentaContable").Count > 0 Then
                ToolBarEliminar.Enabled = False
                ToolBarExcel.Enabled = False
            End If

            ToolBarEliminar.Enabled = False
            ToolBarExcel.Enabled = False
            cmbTipo.SelectedIndex = 0
            cmbMovimiento.SelectedIndex = 0
            BLOQUEAR()
            ButNuevoDetalle.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


#Region "Obtiene Formato"
    Sub obtiene_formato()
        If Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Count > 0 Then
            separador = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("Separador")
            n1 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N1")
            n2 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N2")
            n3 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N3")
            n4 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N4")
            n5 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N5")
            n6 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N6")
            n7 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N7")
            n8 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N8")
            niveles = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("Niveles")
        Else
            control_toolbar(False)
            MsgBox("No se puede ingresar ninguna Cuenta Contable debido a que no se ha determinado su formato." &
            Chr(13) & "Sugerencia: Ve al 'Formulario de Formato de Cuentas Contables' y crea un formato.", MsgBoxStyle.Exclamation)
        End If
    End Sub
#End Region

#End Region

#Region "Controles"
    Function BLOQUEAR()
        txtCuenta.Enabled = False : txtDescripcion.Enabled = False : txtNivel.Enabled = False
        cmbMovimiento.Enabled = False : cmbTipo.Enabled = False : txtCuentaMadre.Enabled = False
        ButAgregarDetalle.Enabled = False : CheckBox1.Enabled = False : cbTipoCuenta.Enabled = False
    End Function

    Function DESBLOQUEAR()
        txtCuenta.Enabled = True : txtDescripcion.Enabled = True : txtNivel.Enabled = True
        cmbMovimiento.Enabled = True : cmbTipo.Enabled = True : txtCuentaMadre.Enabled = True
        ButAgregarDetalle.Enabled = True : CheckBox1.Enabled = True : cbTipoCuenta.Enabled = True
    End Function


    Function Limpiar()
        txtCuenta.Text = ""
        txtNivel.Text = ""
        cmbMovimiento.Text = ""
        txtDescripcion.Text = ""
        cmbTipo.Text = ""
        txtCuentaMadre.Text = ""
        txtDescripcionMadre.Text = ""
        txtcuentaPresupuestaria.Text = ""
        txtDescripcioncuentaPresupuesto.Text = ""
        CheckBox1.Checked = False
    End Function
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3
                llenar_campos()
                If PMU.Update Then registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Editar()

            Case 7 : Me.Close()
        End Select
    End Sub

#Region "Control Toolbar"
    Sub control_toolbar(ByVal bool As Boolean)
        Me.ToolBarBuscar.Enabled = bool
        Me.ToolBarEliminar.Enabled = bool
        Me.ToolBarExcel.Enabled = bool
        Me.ToolBarNuevo.Enabled = bool
        Me.ToolBarRegistrar.Enabled = bool
    End Sub
#End Region

#End Region

#Region "Imprimir"
    Private Function Imprimir()
        Try
            Dim Cuentas As New Cuentas
            Dim visor As New frmVisorReportes

            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Cuentas, False, Configuracion.Claves.Conexion("Contabilidad"))
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try

    End Function
#End Region

#Region "Editar"
    Private Function Editar()
        pnlControles.Enabled = True : ButAgregarDetalle.Enabled = False : cmbMovimiento.Enabled = True
        txtDescripcion.Enabled = True : cmbTipo.Enabled = True : ButAgregarDetalle.Enabled = True
        txtCuenta.Enabled = True : txtCuentaMadre.Enabled = True : CheckBox1.Enabled = True
        cbTipoCuenta.Enabled = True : txtDescripcion.Focus()

        btnPermisos.Enabled = True
    End Function
#End Region

#Region "Eliminar"
    Private Function Eliminar()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String
        If Me.txtCuenta.Text <> "" Then

            If MessageBox.Show(" ¿ Desea Eliminar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Function
            Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from CuentaContable where CuentaContable ='" & Me.txtCuenta.Text & "'")
            If Resultado = vbNullString Then
                MessageBox.Show("La Cuenta Fue Eliminada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DataSetCuentasContables1.Clear()
                Me.Limpiar()
                'Me.Bloquear()
                'nuevo
                Me.ToolBar1.Buttons(0).Enabled = True
                'buscar
                Me.ToolBar1.Buttons(1).Enabled = True
                'editar
                Me.ToolBar1.Buttons(2).Enabled = False
                'registrar
                Me.ToolBar1.Buttons(3).Enabled = False
                'eliminar
                'Me.ToolBar1.Buttons(4).Enabled = False
                'imprimir
                Me.ToolBar1.Buttons(5).Enabled = False
                'Cerrar
                Me.ToolBar1.Buttons(6).Enabled = True
            Else
                MessageBox.Show(Resultado)
                Exit Function
            End If
        Else
            MessageBox.Show("No hay Cuenta Que Eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
#End Region

#Region "Buscar"
    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Dim FechaEmplea As String
        Dim Identificacion As Integer
        Dim n As Integer
        Dim Cuenta As String
        Try
            Me.DataSetCuentasContables1.Clear()

            Id = funcion.BuscarDatos("Select * from CuentaContable", "descripcion", "Buscar Cuenta Contable", SqlConnection1.ConnectionString)
            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable)
            If Id = Nothing Then ' si se dio en el boton de cancelar
                Exit Function
            End If

            funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaCuentas, Me.SqlConnection1.ConnectionString)
            For n = 0 To Me.TablaCuentas.Rows.Count - 1
                If Id = TablaCuentas.Rows(n).Item("CuentaContable") Then
                    Posicion = n
                    Exit Function
                End If
            Next

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub LlamarFmrBuscarAsientoVenta()
        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " &
        " where Movimiento=0 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        Me.txtCuentaMadre.Text = busca.codigo
        Me.txtDescripcionMadre.Text = busca.descrip
    End Sub
#End Region

#Region "Nuevo"
    Sub nuevo()
        If Me.ToolBarNuevo.Text = "Nuevo" Then
            Me.ToolBarNuevo.ImageIndex = 8
            Me.ToolBarNuevo.Text = "Cancelar"
            cuenta = ""
            Me.txtCuenta.Focus()
            Me.Limpiar()
            cuenta = "1"
            Mascara = "#"
            For i As Integer = 0 To n1 - 2
                cuenta += "0"
                Mascara += "#"
            Next
            If n2 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n2 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n3 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n3 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n4 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n4 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n5 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n5 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n6 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n6 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n7 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n7 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n8 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n8 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            txtNivel.Text = niveles
            Me.txtCuenta.Properties.MaskData.EditMask = Mascara
            Me.txtCuenta.Text = cuenta

            Me.txtCuentaMadre.Text = "0"
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").AddNew()
            Me.pnlControles.Enabled = True
            Me.txtCuentaMadre.Properties.ReadOnly = True
            Me.txtDescripcionMadre.ReadOnly = True
            ButAgregarDetalle.Enabled = True
        Else
            Me.ToolBarNuevo.Text = "Nuevo"
            Me.ToolBarNuevo.ImageIndex = 0
            Me.Limpiar()
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").CancelCurrentEdit()
            Me.ToolBarRegistrar.Enabled = False
            ButAgregarDetalle.Enabled = False
            Me.pnlControles.Enabled = False
        End If
    End Sub


    Sub nuevo_nodo(ByVal bool As Boolean)
        cuenta = ""
        Dim control As Boolean = False
        If pos >= 0 Then
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N1") = TreeList1.FindNodeByID(pos).Item("N1").ToString
            cuenta = TreeList1.FindNodeByID(pos).Item("N1")
            If niveles > 1 Then
                cuenta += separador
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N2")) = 0 Then
                If niveles >= 2 Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N2")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N2")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")) + 1)
                    End If
                    If niveles > 2 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N3")) = 0 Then
                If niveles >= 3 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N3")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N3")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")) + 1)
                    End If
                    If niveles > 3 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N4")) = 0 Then
                If niveles >= 4 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N4")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N4")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")) + 1)
                    End If
                    If niveles > 4 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N5")) = 0 Then
                If niveles >= 5 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N5")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N5")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")) + 1)
                    End If
                    If niveles > 5 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N6")) = 0 Then
                If niveles >= 6 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N6")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N6")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")) + 1)
                    End If
                    If niveles > 6 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N7")) = 0 Then
                If niveles >= 7 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N7")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N7")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")) + 1)
                    End If
                    If niveles > 7 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N8")) = 0 Then
                If niveles >= 8 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N8")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N8")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")) + 1)
                    End If
                    If niveles > 8 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") = "0"
                End If
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")))
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")))
            End If
        End If
    End Sub
#End Region

#Region "Ordena"
    'Sub ordena(ByVal nivel As Integer)
    '    Dim str, format As String
    '    Select Case nivel
    '        Case 1
    '            For i As Integer = 0 To n2 - 1
    '                format += "0"
    '            Next
    '            str = "N2"
    '        Case 2
    '            format = ""
    '            For i As Integer = 0 To n3 - 1
    '                format += "0"
    '            Next
    '            str = "N3"
    '        Case 3
    '            format = ""
    '            For i As Integer = 0 To n4 - 1
    '                format += "0"
    '            Next
    '            str = "N4"
    '        Case 4
    '            format = ""
    '            For i As Integer = 0 To n5 - 1
    '                format += "0"
    '            Next
    '            str = "N5"
    '        Case 5
    '            format = ""
    '            For i As Integer = 0 To n6 - 1
    '                format += "0"
    '            Next
    '            str = "N6"
    '        Case 6
    '            format = ""
    '            For i As Integer = 0 To n7 - 1
    '                format += "0"
    '            Next
    '            str = "N7"
    '        Case 7
    '            format = ""
    '            For i As Integer = 0 To n8 - 1
    '                format += "0"
    '            Next
    '            str = "N8"
    '            'Case 8
    '            '    format = ""
    '            '    For i As Integer = 0 To n8 - 1
    '            '        format += "0"
    '            '    Next
    '            '    str = "N8"
    '    End Select
    '    Dim vista As DataView
    '    Dim aux As String = str
    '    aux += " = "
    '    aux += format
    '    vista = Me.DataSetCuentasContables1.CuentaContable.DefaultView
    '    With vista
    '        .RowFilter = aux
    '        str += " Desc"
    '        .Sort = str
    '    End With
    '    If Not nivel > niveles - 1 Then
    '        If nivel = 1 Then
    '            Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    '            Dim fila As DataRow
    '            ' TODO: BUSCAR LOS VALORES ENTRE VISTA Y TABLA DEL BINDING
    '        End If
    '        ordena(nivel + 1)
    '    End If

    'End Sub
#End Region

#Region "Llenar Campos"
    Sub llenar_campos()
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CuentaContable") = txtCuenta.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CUENTACONTABLE_PRESUPUESTO") = txtcuentaPresupuestaria.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Descripcion") = txtDescripcion.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Nivel") = CInt(txtNivel.Text)
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CuentaMadre") = txtCuentaMadre.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescCuentaMadre") = txtDescripcionMadre.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Movimiento") = movimiento
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Tipo") = tipo
        If cbTipoCuenta.Visible Then
            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CodTipoCompra") = cbTipoCuenta.SelectedValue
            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescTipoCompra") = cbTipoCuenta.Text
        Else
            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CodTipoCompra") = 0
            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescTipoCompra") = ""
        End If
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCheque") = Me.chbCheques.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoBancos") = Me.chbBancos.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCont") = Me.chbContabilidad.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCxP") = Me.chbCxP.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCxC") = Me.chbCXC.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoAcF") = Me.chbActFijo.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoInv") = Me.chbInventario.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoGAS") = Me.chbCompras.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoPla") = Me.chbPlanilla.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoFac") = Me.chbFactura.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoConf") = Me.chbConfigurar.Checked
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCxC") = Me.chbCXC.Checked

        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Inactivo") = Me.chbInactivar.Checked

        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Moneda") = Me.cboMoneda.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("TipoConversion") = Me.cboTipoConversion.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Notas") = Me.txtNotas.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable").Current("GastoNoDeducible") = Me.chbGastoNoDeducible.Checked
        If movimiento = False And CheckBox1.Checked = True Then
            MessageBox.Show("Una Cuenta sin Movimiento no puede tener Valuación, Se desactivara Automaticamente", "Sistema SeeSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            CheckBox1.Checked = False
        End If
        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Evaluacion") = CheckBox1.Checked
        grbPermisos.Visible = False

    End Sub
#End Region

#Region "Registrar"
    Sub registrar()
        Dim trans As SqlTransaction
        Try
            If Editando = 1 Then
                If MessageBox.Show(" ¿ Desea Actualizar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            Else
                If MessageBox.Show(" ¿ Desea Registrar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            End If
            Entrar = False
            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            trans = Me.SqlConnection1.BeginTransaction
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
            Me.AdapterCuentasContables.InsertCommand.Transaction = trans
            Me.AdapterCuentasContables.UpdateCommand.Transaction = trans
            Me.AdapterCuentasContables.DeleteCommand.Transaction = trans
            Me.AdapterCuentasContables.Update(Me.DataSetCuentasContables1.CuentaContable)
            id = Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("id")
            Me.DataSetCuentasContables1.AcceptChanges()
            trans.Commit()
            control_toolbar(False)
            Me.ToolBarNuevo.Enabled = True
            Me.ToolBarNuevo.ImageIndex = 0
            Me.ToolBarNuevo.Text = "Nuevo"
            MsgBox("Cuenta Contable Registrada exitosamente", MsgBoxStyle.Information)
            Me.TreeList1.Enabled = True
            Me.DataSetCuentasContables1.CuentaContable.Clear()
            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable)
            Me.BLOQUEAR()
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Position = Me.posi
            Me.ToolBarBuscar.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()

        Finally
            Me.SqlConnection1.Close()
            Entrar = True
        End Try
    End Sub
#End Region

#Region "Eventos Controles"
    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If Not Me.cmbTipo.SelectedIndex < 0 Then
            tipo = Me.cmbTipo.Text
        End If
    End Sub


    Private Sub cmbMovimiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMovimiento.SelectedIndexChanged
        If Not Me.cmbMovimiento.SelectedIndex < 0 Then
            If Me.cmbMovimiento.Text = "SÍ" Then
                movimiento = True
                If txtDescripcion.Text <> "" Then
                    grbPermisos.Visible = True
                End If
                btnBuecarCuentaPresupuesto.Enabled = True
            Else
                movimiento = False
                grbPermisos.Visible = False
                btnBuecarCuentaPresupuesto.Enabled = False
            End If
        End If
    End Sub

    Private Sub TreeList1_AfterFocusNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs)
        If Entrar = True Then
            pos = e.Node.Id
            If Me.ToolBarNuevo.Text = "Cancelar" Then
                Try
                    If TreeList1.FindNodeByID(pos).HasChildren Then
                        nuevo_nodo(True)
                    Else
                        nuevo_nodo(False)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                txtCuenta.Text = cuenta
                txtCuentaMadre.Text = TreeList1.FindNodeByID(pos).Item("CuentaContable")
                txtDescripcionMadre.Text = TreeList1.FindNodeByID(pos).Item("DescCuentaMadre")
                txtNivel.Text = TreeList1.FindNodeByID(pos).Level + 1
            End If
        End If
    End Sub

    Private Sub txtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            '
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = txtCuenta.Text
            Dim cont As Integer
            cont = 0
            Dim numero As String : Dim leng As Integer : Dim x As Integer

            Dim ee As Array = num_cuenta.ToCharArray
            leng = num_cuenta.Length
            ' CUENTA EL # DE ARREGLOS EN LA CUENTA
            For x = 0 To leng - 1
                If ee(x) = "-" Then
                    cont = cont + 1
                End If
            Next
            '*************************************
            'DETERMINA EL NIVEL DE LA CUENTA
            Dim ii As Array = num_cuenta.Split("-")
            Dim nn As Integer
            Dim val As String
            Dim nivel As Integer = 0
            Dim str As String : Dim lon As Integer : Dim xx As Integer
            For nn = 1 To cont '
                val = ""
                str = ii(nn)
                lon = str.Length
                For xx = 0 To lon - 1
                    val = val + "0"
                Next
                If str <> val Then
                    nivel = nivel + 1
                End If
            Next
            Me.txtNivel.Text = nivel
            '********************************
            ' SE VALIDA SI LA CUENTA DIGITADA EXISTE
            Dim conn As New Conexion
            Dim cuenta As String
            Dim Num_Cuentas As String = Me.txtCuenta.Text
            cuenta = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE (CuentaContable = '" & Num_Cuentas & "' ) ")
            Cx.DesConectar(Cx.sQlconexion)
            If cuenta = 0 Then ' SI NO EXISTE
                If nivel = 0 Then ' SI ES UNA CUENTA DE NIVEL 0
                    Me.txtCuentaMadre.Text = Me.txtCuenta.Text
                    Me.cmbMovimiento.Text = "NO"
                    txtDescripcion.Focus()
                Else ' SI NO
                    If nivel = cont Then ' SE INICIA LA VALIDACION DE LA CUENTA MADRE
                        Dim ll As Integer : Dim str1 As String : Dim ee1 As Integer
                        Dim comp As String = ""
                        str1 = ii(cont)
                        ll = str1.Length
                        For ee1 = 1 To ll
                            comp = comp + "0"
                        Next
                        numero = Mid(num_cuenta, 1, leng - ll)
                        numero = numero + comp
                        valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & numero & "'")
                        Cx.DesConectar(Cx.sQlconexion)
                        If valida = "" Then
                            MessageBox.Show("La cuenta digitada no posee una cuenta madre..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtCuenta.Focus()
                        Else
                            Dim nombre As String
                            nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & numero & "'")
                            Cx.DesConectar(Cx.sQlconexion)
                            Me.txtDescripcionMadre.Text = nombre
                            Me.txtCuentaMadre.Text = numero
                            txtDescripcion.Focus()
                        End If
                    Else
                        Dim uu As Integer : Dim cuent As String : Dim cuent1 As String : Dim mm As Integer
                        For uu = 0 To nivel - 1
                            If uu = 0 Then
                                cuent = ii(uu)
                            Else
                                cuent = cuent + "-" + ii(uu)
                            End If
                        Next

                        For mm = nivel To cont
                            Dim str2 As String : Dim ll1, ee2 As Integer
                            Dim comp As String = ""
                            str2 = ii(mm)
                            ll1 = str2.Length
                            For ee2 = 1 To ll1
                                comp = comp + "0"
                            Next
                            If mm = nivel Then
                                cuent1 = comp
                            Else
                                cuent1 = cuent1 + "-" + comp
                            End If
                        Next
                        '

                        Dim validar As String
                        validar = cuent + "-" + cuent1
                        valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & validar & "'")
                        Cx.DesConectar(Cx.sQlconexion)
                        If valida = "" Then
                            MessageBox.Show("La cuenta digitada no posee una cuenta madre..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                            Me.txtCuenta.Focus()
                        Else
                            Dim nombre As String
                            nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & validar & "'")
                            Cx.DesConectar(Cx.sQlconexion)
                            Me.txtDescripcionMadre.Text = nombre
                            Me.txtCuentaMadre.Text = valida
                            txtDescripcion.Focus()
                        End If
                    End If

                End If

            Else ' SI EXISTE ENTONCES
                txtCuenta.Focus()
                MsgBox("La cuenta digitada ya existe...", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub cmbMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMovimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbTipo.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbMovimiento.Focus()
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Editando = 1 Then
                ButAgregarDetalle.Focus()
            Else
                If cbTipoCuenta.Visible = True Then
                    ckTipoCompra.Focus()
                Else
                    ButAgregarDetalle.Focus()
                End If
            End If
        End If
    End Sub


    Private Sub txtCuentaMadre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaMadre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim funcion As New cFunciones
            Dim Id, n As Integer
            Dim Cuenta As String
            funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaCuenta, Me.SqlConnection1.ConnectionString)
            For n = 0 To Me.TablaCuenta.Rows.Count - 1
                If Me.txtCuentaMadre.Text = TablaCuenta.Rows(n).Item("CuentaContable") Then
                    txtDescripcionMadre.Text = TablaCuenta.Rows(n).Item("Descripcion")
                    ButAgregarDetalle.Focus()
                    Exit Sub
                End If
            Next
            If cmbMovimiento.Text = "NO" And txtCuentaMadre.Text = txtCuenta.Text Then
                txtDescripcionMadre.Text = txtDescripcion.Text
                ButAgregarDetalle.Focus()
                Exit Sub
            End If
            If cmbMovimiento.Text <> "NO" And txtCuentaMadre.Text <> txtCuenta.Text Then
                MsgBox("La Cuenta Madre Digitada No Es Valida, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")
                txtCuentaMadre.Focus()
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            LlamarFmrBuscarAsientoVenta()
            ButAgregarDetalle.Focus()
        End If
    End Sub


    Private Sub txtDescripcionMadre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionMadre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ButAgregarDetalle.Focus()
        End If
    End Sub


    Private Sub ButAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAgregarDetalle.Click
        If Me.txtNivel.Text = 0 And Me.cmbMovimiento.Text = "NO" And Me.txtCuenta.Text = Me.txtCuentaMadre.Text Then
            If Me.txtNivel.Text = 0 And Me.cmbMovimiento.Text = "SÍ" Then
                MsgBox("Una cuenta madre no puede tener movimiento...")
                Exit Sub
            End If
            If Me.txtNivel.Text = 0 And Me.CheckBox1.Checked = True Then
                MsgBox("Una cuenta madre no puede tener Valuación...")
                Exit Sub
            End If
            CargarDatos()
            Exit Sub
        End If
        CargarDatos()
        Me.btnPermisos.Enabled = False
    End Sub


    Private Sub ButNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNuevoDetalle.Click
        Editando = 0

        If ButNuevoDetalle.Text = "Nueva Cuenta" Then
            ButNuevoDetalle.ImageIndex = 1
            ButNuevoDetalle.Text = "Cancelar"
            cuenta = ""
            txtCuenta.Focus()
            Limpiar()
            Mascaras()
            txtCuentaMadre.Text = cuenta
            txtCuenta.Text = cuenta
            BindingContext(DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
            BindingContext(DataSetCuentasContables1, "CuentaContable").AddNew()
            DESBLOQUEAR()
            cbTipoCuenta.Visible = False
            pnlControles.Enabled = True
            txtDescripcionMadre.ReadOnly = True
            ButAgregarDetalle.Enabled = True
            TreeList1.Enabled = False
            txtCuenta.Focus() '<<<<
        Else
            ButNuevoDetalle.Text = "Nueva Cuenta"
            ButNuevoDetalle.ImageIndex = 2
            Limpiar()
            ckTipoCompra.Checked = False : cbTipoCuenta.Visible = False
            BindingContext(DataSetCuentasContables1, "CuentaContable").CancelCurrentEdit()
            ToolBarRegistrar.Enabled = False
            ButAgregarDetalle.Enabled = False
            BLOQUEAR()
            TreeList1.Enabled = True

        End If
        btnPermisos.Enabled = True
    End Sub


    Private Sub txtCuentaMadre_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaMadre.EditValueChanged
        Dim cnx As New Conexion
        Dim cuenta As String
        Dim Num_Cuentas As String = Me.txtCuentaMadre.Text
        cuenta = cnx.SlqExecuteScalar(cnx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE (CuentaContable = '" & Num_Cuentas & "' ) ")
        cnx.DesConectar(cnx.sQlconexion)
        If cuenta = "" Then
            txtDescripcionMadre.Text = ""
        End If
    End Sub


    Private Sub TreeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeList1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim funcion As New cFunciones
            Dim Id, n As Integer
            Dim Cuenta As String
            funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaEliminar, Me.SqlConnection1.ConnectionString)
            For n = 0 To TablaEliminar.Rows.Count - 1
                If TablaEliminar.Rows(Reporte_ID).Item("id") = TablaEliminar.Rows(n).Item("PARENTID") Then
                    MessageBox.Show("Esta Cuenta Con Cuentas Hijas, Revise", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next
            Elimina()
        End If
        If e.KeyCode = Keys.F1 Then
            Buscar()
            BindingContext(DataSetCuentasContables1, "CuentaContable").Position = Posicion
        End If
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        If Entrar = True Then
            If e.Node Is Nothing Then
                Exit Sub
            Else
                Reporte_ID = e.Node.Id
            End If
            If e.Node.Id = 0 Then
                Reporte_ID = e.Node.Id
            End If
        End If
    End Sub

    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        Try
            Dim funcion As New cFunciones
            Dim Id, n, k, x, m, z As Integer
            Dim mov, Cuenta As String
            funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaNiveles, Me.SqlConnection1.ConnectionString)
            '
            If TablaNiveles.Rows(Reporte_ID).Item("Movimiento") = False Then
                mov = "NO"
                btnBuecarCuentaPresupuesto.Enabled = False
            End If
            If TablaNiveles.Rows(Reporte_ID).Item("Movimiento") = True Then
                mov = "Sí"


                If (TablaNiveles.Rows(Reporte_ID).Item("CuentaContable") >= "4-00-00-00-00-00-0") Then
                    btnBuecarCuentaPresupuesto.Enabled = True
                Else
                    btnBuecarCuentaPresupuesto.Enabled = False
                End If
            End If
            '
            Mascaras()
            txtDescripcioncuentaPresupuesto.Text = ""
            txtcuentaPresupuestaria.Text = ""
            If (Convert.ToString(TablaNiveles.Rows(Reporte_ID).Item("CuentaContable_Presupuesto")) = "") Then
            Else
                txtcuentaPresupuestaria.Text = TablaNiveles.Rows(Reporte_ID).Item("CuentaContable_Presupuesto")
                txtDescripcioncuentaPresupuesto.Text = GetDescripcionCuentaPresupuestaria(txtcuentaPresupuestaria.Text)
            End If


            txtCuenta.Text = TablaNiveles.Rows(Reporte_ID).Item("CuentaContable")
            txtDescripcion.Text = TablaNiveles.Rows(Reporte_ID).Item("Descripcion")
            txtNivel.Text = TablaNiveles.Rows(Reporte_ID).Item("Nivel")
            cmbMovimiento.Text = mov '<<<
            cmbTipo.Text = TablaNiveles.Rows(Reporte_ID).Item("Tipo")
            txtCuentaMadre.Text = TablaNiveles.Rows(Reporte_ID).Item("CuentaMadre")
            txtDescripcionMadre.Text = TablaNiveles.Rows(Reporte_ID).Item("DescCuentaMadre")
            CheckBox1.Checked = TablaNiveles.Rows(Reporte_ID).Item("Evaluacion")
            If CheckBox1.Checked Then
                Label10.Visible = True
                Label11.Visible = True
                cboMoneda.Visible = True
                cboTipoConversion.Visible = True
            Else
                Label10.Visible = False
                Label11.Visible = False
                cboMoneda.Visible = False
                cboTipoConversion.Visible = False
            End If
            If TablaNiveles.Rows(Reporte_ID).Item("CodTipoCompra") <> 0 Then
                ckTipoCompra.Checked = True : cbTipoCuenta.Visible = True
                cbTipoCuenta.SelectedValue = TablaNiveles.Rows(Reporte_ID).Item("CodTipoCompra")
                cbTipoCuenta.Text = TablaNiveles.Rows(Reporte_ID).Item("DescTipoCompra")
            Else
                ckTipoCompra.Checked = False : cbTipoCuenta.Visible = False
                cbTipoCuenta.SelectedValue = 0 : cbTipoCuenta.Text = ""
            End If
            txtNotas.Text = TablaNiveles.Rows(Reporte_ID).Item("Notas")
            Me.cboTipoConversion.Text = TablaNiveles.Rows(Reporte_ID).Item("TipoConversion")
            Me.cboMoneda.Text = TablaNiveles.Rows(Reporte_ID).Item("Moneda")
            Me.chbCheques.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoCheque")
            Me.chbBancos.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoBancos")
            Me.chbContabilidad.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoCont")
            Me.chbCxP.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoCxP")
            Me.chbCXC.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoCxC")
            Me.chbActFijo.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoAcF")
            Me.chbInventario.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoInv")
            Me.chbPlanilla.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoPla")
            Me.chbFactura.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoFac")
            Me.chbConfigurar.Checked = TablaNiveles.Rows(Reporte_ID).Item("PermisoConf")
            Me.chbInactivar.Checked = TablaNiveles.Rows(Reporte_ID).Item("Inactivo")
            Me.chbGastoNoDeducible.Checked = TablaNiveles.Rows(Reporte_ID).Item("GastoNoDeducible")

            Editando = 1
            Me.ButNuevoDetalle.ImageIndex = 1 '<<<
            Me.ButNuevoDetalle.Text = "Cancelar" '<<<
            Me.Editar()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Function GetDescripcionCuentaPresupuestaria(ByVal StrCuenta As String) As String
        Try

            Dim StrCuentaDescripcion As String = ""
            Dim Funcion As New cFunciones
            Dim SqlConsulta As String = "SELECT Descripcion fROM  CuentaContable_Presupuestaria WHERE CuentaContable='" & StrCuenta & "'"

            Funcion.Llenar_Tabla_Generico(SqlConsulta, Me.TablaDescripcionCuentaPresupuesto, Me.SqlConnection1.ConnectionString)
            StrCuentaDescripcion = TablaDescripcionCuentaPresupuesto.Rows(0).Item("Descripcion")
            Return StrCuentaDescripcion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function


    Private Sub txtCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.Click
        Mascaras()
    End Sub


    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        Try
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = txtCuenta.Text
            Dim cont As Integer
            cont = 0
            Dim numero As String : Dim leng As Integer : Dim x As Integer

            Dim ee As Array = num_cuenta.ToCharArray
            leng = num_cuenta.Length
            ' CUENTA EL # DE ARREGLOS EN LA CUENTA
            For x = 0 To leng - 1
                If ee(x) = "-" Then
                    cont = cont + 1
                End If
            Next
            '*************************************
            'DETERMINA EL NIVEL DE LA CUENTA
            Dim ii As Array = num_cuenta.Split("-")
            Dim nn As Integer
            Dim val As String
            Dim nivel As Integer = 0
            Dim str As String : Dim lon As Integer : Dim xx As Integer
            For nn = 1 To cont '
                val = ""
                str = ii(nn)
                lon = str.Length
                For xx = 0 To lon - 1
                    val = val + "0"
                Next
                If str <> val Then
                    nivel = nivel + 1
                End If
            Next
            Me.txtNivel.Text = nivel

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ckTipoCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckTipoCompra.CheckedChanged
        If ckTipoCompra.Checked = True Then
            cbTipoCuenta.Visible = True
            cbTipoCuenta.Focus()
        Else
            cbTipoCuenta.Visible = False
            txtCuentaMadre.Focus()
        End If
    End Sub

    Private Sub cbTipoCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTipoCuenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCuentaMadre.Focus()
        End If
    End Sub
#End Region

#Region "Validar"
    Function Validar()
        If Me.txtCuenta.Text = "" Then
            MsgBox("Digite el Número de Cuenta", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf cmbMovimiento.Text = "" Then
            MsgBox("Seleccione el Movimiento", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf txtDescripcion.Text = "" Then
            MsgBox("Digite la Descripción de la Cuenta", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf cmbTipo.Text = "" Then
            MsgBox("Seleccione el Tipo de Cuenta", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf txtCuentaMadre.Text = "" Then
            MsgBox("Seleccione la Cuenta Madre", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        Else : Return True
        End If
    End Function

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label10.Visible = True
            Label11.Visible = True
            cboMoneda.Visible = True
            cboTipoConversion.Visible = True
        Else
            Label10.Visible = False
            Label11.Visible = False
            cboMoneda.Visible = False
            cboTipoConversion.Visible = False
        End If

    End Sub


    Function ValidarNumeroCuenta()
        Dim funcion As New cFunciones
        Dim Id, n As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaCuentas, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaCuentas.Rows.Count - 1
            If Me.txtCuenta.Text = TablaCuentas.Rows(n).Item("CuentaContable") Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function


    Function RevisarCodigoCuenta()
        Dim i As Integer

        For i = 0 To Me.TablaCuentas.Rows.Count - 1
            If Me.txtCuentaMadre.Text = TablaCuentas.Rows(i).Item("CuentaContable") Then
                TxtPadre.Text = TablaCuentas.Rows(i).Item("id")
                Exit Function
            Else
                'Return True
            End If
        Next
    End Function


    Function RevisarPadre()
        Dim n As Integer
        For n = 0 To Me.TablaCuentas.Rows.Count - 1
            If Me.TxtPadre.Text = TablaCuentas.Rows(n).Item("id") Then
                If TablaCuentas.Rows(n).Item("Movimiento") = True Then
                    Return False
                    Exit Function
                End If
            End If
        Next
        Return True
    End Function
#End Region

#Region "Funciones"
    Function AsignarNivel()
        Dim funcion As New cFunciones
        Dim Id, n, k, x, m, z As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaNiveles, Me.SqlConnection1.ConnectionString)
        If TablaNiveles.Rows.Count < 0 Then
            ContadorNivel = 0
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Nivel") = ContadorNivel
            txtNivel.Text = ContadorNivel
            Exit Function
        End If
        For n = 0 To Me.TablaNiveles.Rows.Count - 1
            h = n
            If Me.TxtPadre.Text = TablaNiveles.Rows(n).Item("id") Then
                m = 1
            End If
            If Me.TxtPadre.Text <> TablaNiveles.Rows(n).Item("id") And m <> 1 Then
                ContadorNivel = 0
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Nivel") = ContadorNivel
                txtNivel.Text = ContadorNivel
            End If
        Next
        For n = 0 To Me.TablaNiveles.Rows.Count - 1
            If Me.TxtPadre.Text = TablaNiveles.Rows(n).Item("id") Then
                Padre = TablaNiveles.Rows(n).Item("id")
            End If
        Next
        For k = 0 To Me.TablaNiveles.Rows.Count - 1
            If r = 2 Then
                r = 0
                Exit Function
            End If
            If r = 1 Then
                k = 0
                r = 0
            End If
            If Padre = TablaNiveles.Rows(k).Item("id") Then
                ContadorNivel = ContadorNivel + 1
                Padre = TablaNiveles.Rows(k).Item("PARENTID")
                s = k
                Calc()
                k = 0
            End If
        Next

        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Nivel") = ContadorNivel
        txtNivel.Text = ContadorNivel
        ContadorNivel = 0
    End Function


    Function Calc()
        Dim x, a As Integer
        For x = 0 To Me.TablaNiveles.Rows.Count - 1
            If s = x Then
            Else
                If Padre = TablaNiveles.Rows(x).Item("id") Then
                    a = 1
                End If
                If Padre <> TablaNiveles.Rows(x).Item("id") And x = h And a <> 1 Then
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Nivel") = ContadorNivel
                    txtNivel.Text = ContadorNivel
                    ContadorNivel = 0
                    r = 2
                    Exit Function
                Else

                End If
            End If
        Next
        r = 1
    End Function


    Function VerificaHijos()
        Dim funcion As New cFunciones
        Dim Id, n As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaCuentas, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaCuentas.Rows.Count - 1
            If n <> Reporte_ID Then
                If Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("id") = TablaCuentas.Rows(n).Item("PARENTID") Then
                    Return False
                    Exit Function
                End If
            End If
        Next

        Return True
    End Function
    Dim id As Integer = 0

    Function CargarDatos()
        If Validar() Then


            Try
                If Editando <> 1 Then
                    If ValidarNumeroCuenta() Then
                    Else
                        MsgBox("El Número De Cuenta Ya Existe, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")
                        txtCuenta.Text = ""
                        txtCuenta.Focus()
                        Exit Function
                    End If
                End If
                If Editando = 1 Then

                    If VerificaHijos() Then
                    Else
                        If MessageBox.Show("Esta es una cuenta madre y posee cuentas hijas, desea modificarla", "Sistema SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            If cmbMovimiento.Text = "SÍ" Then
                                MessageBox.Show("Una Cuenta Madre no puede tener Movimiento, Se desactivara Automaticamente", "Sistema SeeSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Movimiento") = False
                                CheckBox1.Checked = False
                            End If
                            BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Descripcion") = txtDescripcion.Text
                            BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Tipo") = cmbTipo.Text
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCheque") = Me.chbCheques.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoBancos") = Me.chbBancos.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCont") = Me.chbContabilidad.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCxP") = Me.chbCxP.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCxC") = Me.chbCXC.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoAcF") = Me.chbActFijo.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoInv") = Me.chbInventario.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoGAS") = Me.chbCompras.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoPla") = Me.chbPlanilla.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoFac") = Me.chbFactura.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoConf") = Me.chbConfigurar.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("PermisoCxC") = Me.chbCXC.Checked '

                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Inactivo") = Me.chbInactivar.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("GastoNoDeducible") = Me.chbGastoNoDeducible.Checked
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Moneda") = Me.cboMoneda.Text
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("TipoConversion") = Me.cboTipoConversion.Text
                            BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Notas") = Me.txtNotas.Text
                            If cbTipoCuenta.Visible = True Then
                                BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescTipoCompra") = cbTipoCuenta.Text
                                BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CodTipoCompra") = cbTipoCuenta.SelectedValue
                            Else
                                BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescTipoCompra") = ""
                                BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CodTipoCompra") = 0
                            End If
                            If CheckBox1.Checked = True And cmbMovimiento.Text = "NO" Then
                                MessageBox.Show("Una Cuenta sin Movimiento no puede tener Valuación, Se desactivara Automaticamente", "Sistema SeeSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Evaluacion") = False
                                CheckBox1.Checked = False
                            End If
                            Dim trans As SqlTransaction
                            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
                            trans = Me.SqlConnection1.BeginTransaction

                            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
                            id = TreeList1.FocusedNode.Id
                            Me.AdapterCuentasContables.InsertCommand.Transaction = trans
                            Me.AdapterCuentasContables.UpdateCommand.Transaction = trans
                            Me.AdapterCuentasContables.DeleteCommand.Transaction = trans
                            Me.AdapterCuentasContables.Update(Me.DataSetCuentasContables1.CuentaContable)

                            Me.DataSetCuentasContables1.AcceptChanges()
                            trans.Commit()
                            Me.DataSetCuentasContables1.CuentaContable.Clear()
                            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable)
                            BLOQUEAR()
                            ButNuevoDetalle.Text = "Nueva Cuenta"
                            ButNuevoDetalle.ImageIndex = "2"
                            ButAgregarDetalle.Enabled = False
                        End If
                        cmbMovimiento.Focus()
                        Exit Function
                    End If
                End If

                RevisarCodigoCuenta()
                If RevisarPadre() Then
                Else
                    MsgBox("La Cuenta Madre Seleccionada No Es Valida, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")
                    txtCuentaMadre.Text = ""
                    txtDescripcionMadre.Text = ""
                    txtCuentaMadre.Focus()
                    Exit Function
                End If
                AsignarNivel()
                llenar_campos()
                posi = BindingContext(DataSetCuentasContables1, "CuentaContable").Position

                Me.ToolBar1.Buttons(2).Enabled = True
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
                registrar()
                BLOQUEAR()
                ButNuevoDetalle.Text = "Nueva Cuenta"
                ButNuevoDetalle.ImageIndex = "2"
                ButAgregarDetalle.Enabled = False
                btnPermisos.Enabled = True

            Catch ex As System.Exception
                Me.ToolBar1.Buttons(3).Enabled = True
                MsgBox(ex.Message)
            Finally
                TreeList1.FocusedNode = TreeList1.FindNodeByID(id)
                TreeList1.FocusedNode.Expanded = True

            End Try
        End If
    End Function

    Private Sub Mascaras()
        Try
            cuenta = "1"
            Mascara = "#"
            For i As Integer = 0 To n1 - 2
                cuenta += "0"
                Mascara += "#"
            Next
            If n2 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n2 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n3 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n3 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n4 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n4 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n5 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n5 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n6 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n6 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n7 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n7 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n8 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n8 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            txtNivel.Text = 0
            Me.txtCuenta.Properties.MaskData.EditMask = Mascara
            Me.txtCuentaMadre.Properties.MaskData.EditMask = Mascara

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Elimina"
    Private Function Elimina()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String

        If MessageBox.Show(" ¿ Desea Eliminar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Function
        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").RemoveAt(Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Position)
        Me.RegistraEliminar()
        If Resultado = vbNullString Then
            MessageBox.Show("La Cuenta Fue Eliminada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Limpiar()
        Else
            MessageBox.Show(Resultado)
            Exit Function
        End If
    End Function


    Function RegistraEliminar() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.AdapterCuentasContables.InsertCommand.Transaction = Trans
            Me.AdapterCuentasContables.UpdateCommand.Transaction = Trans
            Me.AdapterCuentasContables.DeleteCommand.Transaction = Trans
            Me.AdapterCuentasContables.SelectCommand.Transaction = Trans
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
            Me.AdapterCuentasContables.Update(Me.DataSetCuentasContables1, "CuentaContable")
            Trans.Commit()

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox("No se puede eliminar, o error de red", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
#End Region

    Private Sub btnBuecarCuentaPresupuesto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuecarCuentaPresupuesto.Click

        Try


            Dim fx As New cFunciones
            Dim IdP As String = ""

            IdP = fx.BuscarDatos("SELECT CUENTACONTABLE, DESCRIPCION FROM CuentaContable_Presupuestaria  ", "Movimiento <> 0 and Descripcion", "Buscar Cuenta Presupuestaria...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")

            If IdP <> "" Then
                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                par.Add("@ID", IdP)
                db.Fill_Generic_Table("Contabilidad", dt, "SELECT CUENTACONTABLE, DESCRIPCION FROM CuentaContable_Presupuestaria  WHERE (Movimiento <> 0 and CUENTACONTABLE = @ID)", CommandType.Text, par)
                If dt.Rows.Count > 0 Then
                    txtcuentaPresupuestaria.Text = dt.Rows(0).Item(0)
                    txtDescripcioncuentaPresupuesto.Text = dt.Rows(0).Item(1)
                Else
                    MsgBox("Esta Cuenta en una cuenta Madre  y no tiene movimiento", MsgBoxStyle.Critical, "")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pnlControles_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlControles.Paint

    End Sub

    Private Sub TituloModulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TituloModulo.Click

    End Sub

    Private Sub btnPermisos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermisos.Click

        If Not cmbMovimiento.Text.Equals("NO") And (txtCuenta.Text.StartsWith("4") Or txtCuenta.Text.StartsWith("6")) Then

            Me.chbGastoNoDeducible.Visible = True
            If cmbMovimiento.Text <> "SÍ" Then
                grbPermisos.Visible = False
            Else
                grbPermisos.Visible = True
            End If


        Else
                Me.chbGastoNoDeducible.Visible = False
            If cmbMovimiento.Text <> "SÍ" Then
                grbPermisos.Visible = False
            Else
                grbPermisos.Visible = True
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        grbPermisos.Visible = False
    End Sub
End Class
