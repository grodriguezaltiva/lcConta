Imports System.Data.SqlClient
Imports Utilidades

Public Class FrmSettingHotelCuentaContable
    Inherits Plantilla

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
    Friend WithEvents tabCuentas As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents erpProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtMontoAdelanto As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents LPrepagoDol As System.Windows.Forms.Label
    Friend WithEvents tbpPlanilla As System.Windows.Forms.TabPage
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tbpImpuestos As System.Windows.Forms.TabPage
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cboCredCompServ As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DtsSetting1 As Contabilidad.dtsSetting
    Friend WithEvents bdsSetting As System.Windows.Forms.BindingSource
    Friend WithEvents cboUtilidadPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents bsdCuentas As System.Windows.Forms.BindingSource
    Friend WithEvents cboDiferencialGasto As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiferencialIngreso As System.Windows.Forms.ComboBox
    Friend WithEvents cboCxCInHouse As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrepagoDolares As System.Windows.Forms.ComboBox
    Friend WithEvents cboPrepagoColones As System.Windows.Forms.ComboBox
    Friend WithEvents cboCaja As System.Windows.Forms.ComboBox
    Friend WithEvents cboDiferencialCaja As System.Windows.Forms.ComboBox
    Friend WithEvents cboTravelCheck As System.Windows.Forms.ComboBox
    Friend WithEvents cboCompraExcenta As System.Windows.Forms.ComboBox
    Friend WithEvents cboCompraGravada As System.Windows.Forms.ComboBox
    Friend WithEvents cboTransitoriaCXC As System.Windows.Forms.ComboBox
    Friend WithEvents cboCuentasPorCobrar As System.Windows.Forms.ComboBox
    Friend WithEvents cboRetencionRenta As System.Windows.Forms.ComboBox
    Friend WithEvents cboInteresePrestamosEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents cboCxCEmpleadoDolar As System.Windows.Forms.ComboBox
    Friend WithEvents cboCxCEmpleadoColones As System.Windows.Forms.ComboBox
    Friend WithEvents cboOtroIngresoEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents cboExtraPropina As System.Windows.Forms.ComboBox
    Friend WithEvents cboImpuestoRenta As System.Windows.Forms.ComboBox
    Friend WithEvents cboImpuestoServicio As System.Windows.Forms.ComboBox
    Friend WithEvents cboImpuestoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents BindingSource14 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource13 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource11 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource10 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource9 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource19 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource18 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource17 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource16 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource15 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource23 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource22 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource21 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource20 As System.Windows.Forms.BindingSource
    Friend WithEvents BindingSource12 As System.Windows.Forms.BindingSource
    Friend WithEvents txtPorcImpRenta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label22 As Label
    Friend WithEvents ComboAdelantoCliente As ComboBox
    Friend WithEvents SettingCuentaContableTableAdapter As Contabilidad.dtsSettingTableAdapters.SettingCuentaContableTableAdapter
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSettingHotelCuentaContable))
        Me.tabCuentas = New System.Windows.Forms.TabControl()
        Me.tabpageGeneral = New System.Windows.Forms.TabPage()
        Me.ComboAdelantoCliente = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cboUtilidadPeriodo = New System.Windows.Forms.ComboBox()
        Me.bdsSetting = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsSetting1 = New Contabilidad.dtsSetting()
        Me.BindingSource14 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDiferencialGasto = New System.Windows.Forms.ComboBox()
        Me.BindingSource13 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDiferencialIngreso = New System.Windows.Forms.ComboBox()
        Me.BindingSource11 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCxCInHouse = New System.Windows.Forms.ComboBox()
        Me.BindingSource10 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPrepagoDolares = New System.Windows.Forms.ComboBox()
        Me.BindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPrepagoColones = New System.Windows.Forms.ComboBox()
        Me.BindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.BindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboDiferencialCaja = New System.Windows.Forms.ComboBox()
        Me.BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboTravelCheck = New System.Windows.Forms.ComboBox()
        Me.BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCompraExcenta = New System.Windows.Forms.ComboBox()
        Me.BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCompraGravada = New System.Windows.Forms.ComboBox()
        Me.BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboTransitoriaCXC = New System.Windows.Forms.ComboBox()
        Me.BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCuentasPorCobrar = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCredCompServ = New System.Windows.Forms.ComboBox()
        Me.bsdCuentas = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label29 = New System.Windows.Forms.Label()
        Me.LPrepagoDol = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbpPlanilla = New System.Windows.Forms.TabPage()
        Me.cboRetencionRenta = New System.Windows.Forms.ComboBox()
        Me.BindingSource19 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboInteresePrestamosEmpleado = New System.Windows.Forms.ComboBox()
        Me.BindingSource18 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCxCEmpleadoDolar = New System.Windows.Forms.ComboBox()
        Me.BindingSource17 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboCxCEmpleadoColones = New System.Windows.Forms.ComboBox()
        Me.BindingSource16 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboOtroIngresoEmpleado = New System.Windows.Forms.ComboBox()
        Me.BindingSource15 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMontoAdelanto = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbpImpuestos = New System.Windows.Forms.TabPage()
        Me.txtPorcImpRenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboExtraPropina = New System.Windows.Forms.ComboBox()
        Me.BindingSource23 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboImpuestoRenta = New System.Windows.Forms.ComboBox()
        Me.BindingSource22 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboImpuestoServicio = New System.Windows.Forms.ComboBox()
        Me.BindingSource21 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboImpuestoVenta = New System.Windows.Forms.ComboBox()
        Me.BindingSource20 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.erpProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SettingCuentaContableTableAdapter = New Contabilidad.dtsSettingTableAdapters.SettingCuentaContableTableAdapter()
        Me.BindingSource12 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabCuentas.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        CType(Me.bdsSetting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsSetting1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsdCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpPlanilla.SuspendLayout()
        CType(Me.BindingSource19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpImpuestos.SuspendLayout()
        CType(Me.BindingSource23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource12, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ToolBar1.Enabled = False
        Me.ToolBar1.Location = New System.Drawing.Point(0, 454)
        Me.ToolBar1.Size = New System.Drawing.Size(667, 60)
        Me.ToolBar1.TabIndex = 1
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(667, 32)
        Me.TituloModulo.Text = "Setting de cuenta contable "
        '
        'tabCuentas
        '
        Me.tabCuentas.Controls.Add(Me.tabpageGeneral)
        Me.tabCuentas.Controls.Add(Me.tbpPlanilla)
        Me.tabCuentas.Controls.Add(Me.tbpImpuestos)
        Me.tabCuentas.Location = New System.Drawing.Point(0, 35)
        Me.tabCuentas.Name = "tabCuentas"
        Me.tabCuentas.SelectedIndex = 0
        Me.tabCuentas.Size = New System.Drawing.Size(658, 416)
        Me.tabCuentas.TabIndex = 2
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.ComboAdelantoCliente)
        Me.tabpageGeneral.Controls.Add(Me.Label22)
        Me.tabpageGeneral.Controls.Add(Me.cboUtilidadPeriodo)
        Me.tabpageGeneral.Controls.Add(Me.cboDiferencialGasto)
        Me.tabpageGeneral.Controls.Add(Me.cboDiferencialIngreso)
        Me.tabpageGeneral.Controls.Add(Me.cboCxCInHouse)
        Me.tabpageGeneral.Controls.Add(Me.cboPrepagoDolares)
        Me.tabpageGeneral.Controls.Add(Me.cboPrepagoColones)
        Me.tabpageGeneral.Controls.Add(Me.cboCaja)
        Me.tabpageGeneral.Controls.Add(Me.cboDiferencialCaja)
        Me.tabpageGeneral.Controls.Add(Me.cboTravelCheck)
        Me.tabpageGeneral.Controls.Add(Me.cboCompraExcenta)
        Me.tabpageGeneral.Controls.Add(Me.cboCompraGravada)
        Me.tabpageGeneral.Controls.Add(Me.cboTransitoriaCXC)
        Me.tabpageGeneral.Controls.Add(Me.cboCuentasPorCobrar)
        Me.tabpageGeneral.Controls.Add(Me.cboCredCompServ)
        Me.tabpageGeneral.Controls.Add(Me.Label29)
        Me.tabpageGeneral.Controls.Add(Me.LPrepagoDol)
        Me.tabpageGeneral.Controls.Add(Me.Label23)
        Me.tabpageGeneral.Controls.Add(Me.Label21)
        Me.tabpageGeneral.Controls.Add(Me.Label20)
        Me.tabpageGeneral.Controls.Add(Me.Label19)
        Me.tabpageGeneral.Controls.Add(Me.Label12)
        Me.tabpageGeneral.Controls.Add(Me.Label10)
        Me.tabpageGeneral.Controls.Add(Me.Label6)
        Me.tabpageGeneral.Controls.Add(Me.Label5)
        Me.tabpageGeneral.Controls.Add(Me.Label4)
        Me.tabpageGeneral.Controls.Add(Me.Label7)
        Me.tabpageGeneral.Controls.Add(Me.Label8)
        Me.tabpageGeneral.Controls.Add(Me.Label13)
        Me.tabpageGeneral.Controls.Add(Me.Label1)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Size = New System.Drawing.Size(650, 390)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        Me.tabpageGeneral.UseVisualStyleBackColor = True
        '
        'ComboAdelantoCliente
        '
        Me.ComboAdelantoCliente.FormattingEnabled = True
        Me.ComboAdelantoCliente.Location = New System.Drawing.Point(174, 357)
        Me.ComboAdelantoCliente.Name = "ComboAdelantoCliente"
        Me.ComboAdelantoCliente.Size = New System.Drawing.Size(469, 21)
        Me.ComboAdelantoCliente.TabIndex = 214
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(25, 360)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(144, 14)
        Me.Label22.TabIndex = 213
        Me.Label22.Text = "Adelanto Cliente:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboUtilidadPeriodo
        '
        Me.cboUtilidadPeriodo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdPeriodo", True))
        Me.cboUtilidadPeriodo.DataSource = Me.BindingSource14
        Me.cboUtilidadPeriodo.DisplayMember = "Descripción"
        Me.cboUtilidadPeriodo.FormattingEnabled = True
        Me.cboUtilidadPeriodo.Location = New System.Drawing.Point(174, 333)
        Me.cboUtilidadPeriodo.Name = "cboUtilidadPeriodo"
        Me.cboUtilidadPeriodo.Size = New System.Drawing.Size(469, 21)
        Me.cboUtilidadPeriodo.TabIndex = 13
        Me.cboUtilidadPeriodo.ValueMember = "Id"
        '
        'bdsSetting
        '
        Me.bdsSetting.DataMember = "SettingCuentaContable"
        Me.bdsSetting.DataSource = Me.DtsSetting1
        '
        'DtsSetting1
        '
        Me.DtsSetting1.DataSetName = "dtsSetting"
        Me.DtsSetting1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource14
        '
        Me.BindingSource14.DataMember = "dtCuentaContable"
        Me.BindingSource14.DataSource = Me.DtsSetting1
        '
        'cboDiferencialGasto
        '
        Me.cboDiferencialGasto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdDiferencialGasto", True))
        Me.cboDiferencialGasto.DataSource = Me.BindingSource13
        Me.cboDiferencialGasto.DisplayMember = "Descripción"
        Me.cboDiferencialGasto.FormattingEnabled = True
        Me.cboDiferencialGasto.Location = New System.Drawing.Point(174, 309)
        Me.cboDiferencialGasto.Name = "cboDiferencialGasto"
        Me.cboDiferencialGasto.Size = New System.Drawing.Size(469, 21)
        Me.cboDiferencialGasto.TabIndex = 12
        Me.cboDiferencialGasto.ValueMember = "Id"
        '
        'BindingSource13
        '
        Me.BindingSource13.DataMember = "dtCuentaContable"
        Me.BindingSource13.DataSource = Me.DtsSetting1
        '
        'cboDiferencialIngreso
        '
        Me.cboDiferencialIngreso.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdDiferencial", True))
        Me.cboDiferencialIngreso.DataSource = Me.BindingSource11
        Me.cboDiferencialIngreso.DisplayMember = "Descripción"
        Me.cboDiferencialIngreso.FormattingEnabled = True
        Me.cboDiferencialIngreso.Location = New System.Drawing.Point(174, 285)
        Me.cboDiferencialIngreso.Name = "cboDiferencialIngreso"
        Me.cboDiferencialIngreso.Size = New System.Drawing.Size(469, 21)
        Me.cboDiferencialIngreso.TabIndex = 11
        Me.cboDiferencialIngreso.ValueMember = "Id"
        '
        'BindingSource11
        '
        Me.BindingSource11.DataMember = "dtCuentaContable"
        Me.BindingSource11.DataSource = Me.DtsSetting1
        '
        'cboCxCInHouse
        '
        Me.cboCxCInHouse.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCxCHabitacion", True))
        Me.cboCxCInHouse.DataSource = Me.BindingSource10
        Me.cboCxCInHouse.DisplayMember = "Descripción"
        Me.cboCxCInHouse.FormattingEnabled = True
        Me.cboCxCInHouse.Location = New System.Drawing.Point(174, 261)
        Me.cboCxCInHouse.Name = "cboCxCInHouse"
        Me.cboCxCInHouse.Size = New System.Drawing.Size(469, 21)
        Me.cboCxCInHouse.TabIndex = 10
        Me.cboCxCInHouse.ValueMember = "Id"
        '
        'BindingSource10
        '
        Me.BindingSource10.DataMember = "dtCuentaContable"
        Me.BindingSource10.DataSource = Me.DtsSetting1
        '
        'cboPrepagoDolares
        '
        Me.cboPrepagoDolares.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdPrepagoDol", True))
        Me.cboPrepagoDolares.DataSource = Me.BindingSource9
        Me.cboPrepagoDolares.DisplayMember = "Descripción"
        Me.cboPrepagoDolares.FormattingEnabled = True
        Me.cboPrepagoDolares.Location = New System.Drawing.Point(174, 234)
        Me.cboPrepagoDolares.Name = "cboPrepagoDolares"
        Me.cboPrepagoDolares.Size = New System.Drawing.Size(469, 21)
        Me.cboPrepagoDolares.TabIndex = 9
        Me.cboPrepagoDolares.ValueMember = "Id"
        '
        'BindingSource9
        '
        Me.BindingSource9.DataMember = "dtCuentaContable"
        Me.BindingSource9.DataSource = Me.DtsSetting1
        '
        'cboPrepagoColones
        '
        Me.cboPrepagoColones.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdPrepagoCol", True))
        Me.cboPrepagoColones.DataSource = Me.BindingSource8
        Me.cboPrepagoColones.DisplayMember = "Descripción"
        Me.cboPrepagoColones.FormattingEnabled = True
        Me.cboPrepagoColones.Location = New System.Drawing.Point(174, 210)
        Me.cboPrepagoColones.Name = "cboPrepagoColones"
        Me.cboPrepagoColones.Size = New System.Drawing.Size(469, 21)
        Me.cboPrepagoColones.TabIndex = 8
        Me.cboPrepagoColones.ValueMember = "Id"
        '
        'BindingSource8
        '
        Me.BindingSource8.DataMember = "dtCuentaContable"
        Me.BindingSource8.DataSource = Me.DtsSetting1
        '
        'cboCaja
        '
        Me.cboCaja.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCaja", True))
        Me.cboCaja.DataSource = Me.BindingSource7
        Me.cboCaja.DisplayMember = "Descripción"
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(174, 186)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(469, 21)
        Me.cboCaja.TabIndex = 7
        Me.cboCaja.ValueMember = "Id"
        '
        'BindingSource7
        '
        Me.BindingSource7.DataMember = "dtCuentaContable"
        Me.BindingSource7.DataSource = Me.DtsSetting1
        '
        'cboDiferencialCaja
        '
        Me.cboDiferencialCaja.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdDiferenciaCaja", True))
        Me.cboDiferencialCaja.DataSource = Me.BindingSource6
        Me.cboDiferencialCaja.DisplayMember = "Descripción"
        Me.cboDiferencialCaja.FormattingEnabled = True
        Me.cboDiferencialCaja.Location = New System.Drawing.Point(174, 162)
        Me.cboDiferencialCaja.Name = "cboDiferencialCaja"
        Me.cboDiferencialCaja.Size = New System.Drawing.Size(469, 21)
        Me.cboDiferencialCaja.TabIndex = 6
        Me.cboDiferencialCaja.ValueMember = "Id"
        '
        'BindingSource6
        '
        Me.BindingSource6.DataMember = "dtCuentaContable"
        Me.BindingSource6.DataSource = Me.DtsSetting1
        '
        'cboTravelCheck
        '
        Me.cboTravelCheck.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdTravelCheck", True))
        Me.cboTravelCheck.DataSource = Me.BindingSource5
        Me.cboTravelCheck.DisplayMember = "Descripción"
        Me.cboTravelCheck.FormattingEnabled = True
        Me.cboTravelCheck.Location = New System.Drawing.Point(174, 141)
        Me.cboTravelCheck.Name = "cboTravelCheck"
        Me.cboTravelCheck.Size = New System.Drawing.Size(469, 21)
        Me.cboTravelCheck.TabIndex = 5
        Me.cboTravelCheck.ValueMember = "Id"
        '
        'BindingSource5
        '
        Me.BindingSource5.DataMember = "dtCuentaContable"
        Me.BindingSource5.DataSource = Me.DtsSetting1
        '
        'cboCompraExcenta
        '
        Me.cboCompraExcenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCompraExcento", True))
        Me.cboCompraExcenta.DataSource = Me.BindingSource4
        Me.cboCompraExcenta.DisplayMember = "Descripción"
        Me.cboCompraExcenta.FormattingEnabled = True
        Me.cboCompraExcenta.Location = New System.Drawing.Point(174, 117)
        Me.cboCompraExcenta.Name = "cboCompraExcenta"
        Me.cboCompraExcenta.Size = New System.Drawing.Size(469, 21)
        Me.cboCompraExcenta.TabIndex = 4
        Me.cboCompraExcenta.ValueMember = "Id"
        '
        'BindingSource4
        '
        Me.BindingSource4.DataMember = "dtCuentaContable"
        Me.BindingSource4.DataSource = Me.DtsSetting1
        '
        'cboCompraGravada
        '
        Me.cboCompraGravada.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCompraGrabado", True))
        Me.cboCompraGravada.DataSource = Me.BindingSource3
        Me.cboCompraGravada.DisplayMember = "Descripción"
        Me.cboCompraGravada.FormattingEnabled = True
        Me.cboCompraGravada.Location = New System.Drawing.Point(174, 93)
        Me.cboCompraGravada.Name = "cboCompraGravada"
        Me.cboCompraGravada.Size = New System.Drawing.Size(469, 21)
        Me.cboCompraGravada.TabIndex = 3
        Me.cboCompraGravada.ValueMember = "Id"
        '
        'BindingSource3
        '
        Me.BindingSource3.DataMember = "dtCuentaContable"
        Me.BindingSource3.DataSource = Me.DtsSetting1
        '
        'cboTransitoriaCXC
        '
        Me.cboTransitoriaCXC.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdTCXC", True))
        Me.cboTransitoriaCXC.DataSource = Me.BindingSource2
        Me.cboTransitoriaCXC.DisplayMember = "Descripción"
        Me.cboTransitoriaCXC.FormattingEnabled = True
        Me.cboTransitoriaCXC.Location = New System.Drawing.Point(174, 69)
        Me.cboTransitoriaCXC.Name = "cboTransitoriaCXC"
        Me.cboTransitoriaCXC.Size = New System.Drawing.Size(469, 21)
        Me.cboTransitoriaCXC.TabIndex = 2
        Me.cboTransitoriaCXC.ValueMember = "Id"
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "dtCuentaContable"
        Me.BindingSource2.DataSource = Me.DtsSetting1
        '
        'cboCuentasPorCobrar
        '
        Me.cboCuentasPorCobrar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCuentaCobrar", True))
        Me.cboCuentasPorCobrar.DataSource = Me.BindingSource1
        Me.cboCuentasPorCobrar.DisplayMember = "Descripción"
        Me.cboCuentasPorCobrar.FormattingEnabled = True
        Me.cboCuentasPorCobrar.Location = New System.Drawing.Point(175, 45)
        Me.cboCuentasPorCobrar.Name = "cboCuentasPorCobrar"
        Me.cboCuentasPorCobrar.Size = New System.Drawing.Size(469, 21)
        Me.cboCuentasPorCobrar.TabIndex = 1
        Me.cboCuentasPorCobrar.ValueMember = "Id"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "dtCuentaContable"
        Me.BindingSource1.DataSource = Me.DtsSetting1
        '
        'cboCredCompServ
        '
        Me.cboCredCompServ.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCreditoComp", True))
        Me.cboCredCompServ.DataSource = Me.bsdCuentas
        Me.cboCredCompServ.DisplayMember = "Descripción"
        Me.cboCredCompServ.FormattingEnabled = True
        Me.cboCredCompServ.Location = New System.Drawing.Point(175, 25)
        Me.cboCredCompServ.Name = "cboCredCompServ"
        Me.cboCredCompServ.Size = New System.Drawing.Size(469, 21)
        Me.cboCredCompServ.TabIndex = 0
        Me.cboCredCompServ.ValueMember = "Id"
        '
        'bsdCuentas
        '
        Me.bsdCuentas.DataMember = "dtCuentaContable"
        Me.bsdCuentas.DataSource = Me.DtsSetting1
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(25, 25)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(144, 14)
        Me.Label29.TabIndex = 212
        Me.Label29.Text = "Crédito Comp. y Serv."
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LPrepagoDol
        '
        Me.LPrepagoDol.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.LPrepagoDol.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPrepagoDol.ForeColor = System.Drawing.Color.White
        Me.LPrepagoDol.Location = New System.Drawing.Point(25, 237)
        Me.LPrepagoDol.Name = "LPrepagoDol"
        Me.LPrepagoDol.Size = New System.Drawing.Size(144, 14)
        Me.LPrepagoDol.TabIndex = 211
        Me.LPrepagoDol.Text = "Prepago Dolares :"
        Me.LPrepagoDol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(23, 69)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(144, 14)
        Me.Label23.TabIndex = 205
        Me.Label23.Text = "Transistoria CXC:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(25, 333)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 14)
        Me.Label21.TabIndex = 202
        Me.Label21.Text = "Utilidad Periodo : "
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(25, 309)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(144, 14)
        Me.Label20.TabIndex = 199
        Me.Label20.Text = "Diferencial Camb. Gasto :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(25, 285)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(144, 14)
        Me.Label19.TabIndex = 196
        Me.Label19.Text = "Diferencial Camb. Ingre. :"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(25, 213)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 14)
        Me.Label12.TabIndex = 179
        Me.Label12.Text = "Prepago Colones :"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(25, 261)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 14)
        Me.Label10.TabIndex = 176
        Me.Label10.Text = "C x C In House:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(25, 189)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 14)
        Me.Label6.TabIndex = 173
        Me.Label6.Text = "Caja :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 14)
        Me.Label5.TabIndex = 170
        Me.Label5.Text = "Diferencial caja:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 14)
        Me.Label4.TabIndex = 167
        Me.Label4.Text = "Travel check:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(25, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 14)
        Me.Label7.TabIndex = 164
        Me.Label7.Text = "Compra Excento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(25, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 14)
        Me.Label8.TabIndex = 163
        Me.Label8.Text = "Compra gravada:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(25, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 14)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Cuentas por cobrar:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(175, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 14)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Descripción cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbpPlanilla
        '
        Me.tbpPlanilla.Controls.Add(Me.cboRetencionRenta)
        Me.tbpPlanilla.Controls.Add(Me.cboInteresePrestamosEmpleado)
        Me.tbpPlanilla.Controls.Add(Me.cboCxCEmpleadoDolar)
        Me.tbpPlanilla.Controls.Add(Me.cboCxCEmpleadoColones)
        Me.tbpPlanilla.Controls.Add(Me.cboOtroIngresoEmpleado)
        Me.tbpPlanilla.Controls.Add(Me.Label28)
        Me.tbpPlanilla.Controls.Add(Me.Label27)
        Me.tbpPlanilla.Controls.Add(Me.Label25)
        Me.tbpPlanilla.Controls.Add(Me.Label16)
        Me.tbpPlanilla.Controls.Add(Me.txtMontoAdelanto)
        Me.tbpPlanilla.Controls.Add(Me.Label15)
        Me.tbpPlanilla.Controls.Add(Me.Label14)
        Me.tbpPlanilla.Controls.Add(Me.Label2)
        Me.tbpPlanilla.Location = New System.Drawing.Point(4, 22)
        Me.tbpPlanilla.Name = "tbpPlanilla"
        Me.tbpPlanilla.Size = New System.Drawing.Size(650, 390)
        Me.tbpPlanilla.TabIndex = 1
        Me.tbpPlanilla.Text = "Planilla"
        Me.tbpPlanilla.UseVisualStyleBackColor = True
        '
        'cboRetencionRenta
        '
        Me.cboRetencionRenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdRenta", True))
        Me.cboRetencionRenta.DataSource = Me.BindingSource19
        Me.cboRetencionRenta.DisplayMember = "Descripción"
        Me.cboRetencionRenta.FormattingEnabled = True
        Me.cboRetencionRenta.Location = New System.Drawing.Point(175, 118)
        Me.cboRetencionRenta.Name = "cboRetencionRenta"
        Me.cboRetencionRenta.Size = New System.Drawing.Size(469, 21)
        Me.cboRetencionRenta.TabIndex = 4
        Me.cboRetencionRenta.ValueMember = "Id"
        '
        'BindingSource19
        '
        Me.BindingSource19.DataMember = "dtCuentaContable"
        Me.BindingSource19.DataSource = Me.DtsSetting1
        '
        'cboInteresePrestamosEmpleado
        '
        Me.cboInteresePrestamosEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdInteresPres", True))
        Me.cboInteresePrestamosEmpleado.DataSource = Me.BindingSource18
        Me.cboInteresePrestamosEmpleado.DisplayMember = "Descripción"
        Me.cboInteresePrestamosEmpleado.FormattingEnabled = True
        Me.cboInteresePrestamosEmpleado.Location = New System.Drawing.Point(175, 93)
        Me.cboInteresePrestamosEmpleado.Name = "cboInteresePrestamosEmpleado"
        Me.cboInteresePrestamosEmpleado.Size = New System.Drawing.Size(469, 21)
        Me.cboInteresePrestamosEmpleado.TabIndex = 3
        Me.cboInteresePrestamosEmpleado.ValueMember = "Id"
        '
        'BindingSource18
        '
        Me.BindingSource18.DataMember = "dtCuentaContable"
        Me.BindingSource18.DataSource = Me.DtsSetting1
        '
        'cboCxCEmpleadoDolar
        '
        Me.cboCxCEmpleadoDolar.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCXCEmpDol", True))
        Me.cboCxCEmpleadoDolar.DataSource = Me.BindingSource17
        Me.cboCxCEmpleadoDolar.DisplayMember = "Descripción"
        Me.cboCxCEmpleadoDolar.FormattingEnabled = True
        Me.cboCxCEmpleadoDolar.Location = New System.Drawing.Point(175, 73)
        Me.cboCxCEmpleadoDolar.Name = "cboCxCEmpleadoDolar"
        Me.cboCxCEmpleadoDolar.Size = New System.Drawing.Size(469, 21)
        Me.cboCxCEmpleadoDolar.TabIndex = 2
        Me.cboCxCEmpleadoDolar.ValueMember = "Id"
        '
        'BindingSource17
        '
        Me.BindingSource17.DataMember = "dtCuentaContable"
        Me.BindingSource17.DataSource = Me.DtsSetting1
        '
        'cboCxCEmpleadoColones
        '
        Me.cboCxCEmpleadoColones.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdCXCEmpCol", True))
        Me.cboCxCEmpleadoColones.DataSource = Me.BindingSource16
        Me.cboCxCEmpleadoColones.DisplayMember = "Descripción"
        Me.cboCxCEmpleadoColones.FormattingEnabled = True
        Me.cboCxCEmpleadoColones.Location = New System.Drawing.Point(175, 49)
        Me.cboCxCEmpleadoColones.Name = "cboCxCEmpleadoColones"
        Me.cboCxCEmpleadoColones.Size = New System.Drawing.Size(469, 21)
        Me.cboCxCEmpleadoColones.TabIndex = 1
        Me.cboCxCEmpleadoColones.ValueMember = "Id"
        '
        'BindingSource16
        '
        Me.BindingSource16.DataMember = "dtCuentaContable"
        Me.BindingSource16.DataSource = Me.DtsSetting1
        '
        'cboOtroIngresoEmpleado
        '
        Me.cboOtroIngresoEmpleado.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdOtrosIng", True))
        Me.cboOtroIngresoEmpleado.DataSource = Me.BindingSource15
        Me.cboOtroIngresoEmpleado.DisplayMember = "Descripción"
        Me.cboOtroIngresoEmpleado.FormattingEnabled = True
        Me.cboOtroIngresoEmpleado.Location = New System.Drawing.Point(175, 27)
        Me.cboOtroIngresoEmpleado.Name = "cboOtroIngresoEmpleado"
        Me.cboOtroIngresoEmpleado.Size = New System.Drawing.Size(469, 21)
        Me.cboOtroIngresoEmpleado.TabIndex = 0
        Me.cboOtroIngresoEmpleado.ValueMember = "Id"
        '
        'BindingSource15
        '
        Me.BindingSource15.DataMember = "dtCuentaContable"
        Me.BindingSource15.DataSource = Me.DtsSetting1
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(23, 96)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(144, 14)
        Me.Label28.TabIndex = 208
        Me.Label28.Text = "Intereses s/préstamos:"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(24, 27)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(144, 14)
        Me.Label27.TabIndex = 205
        Me.Label27.Text = "Otros Ingresos Emp."
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(175, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(469, 14)
        Me.Label25.TabIndex = 202
        Me.Label25.Text = "Descripción cuenta"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(22, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(251, 14)
        Me.Label16.TabIndex = 192
        Me.Label16.Text = "A partir de este monto es Adelanto Salario:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMontoAdelanto
        '
        Me.txtMontoAdelanto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoAdelanto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoAdelanto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSetting, "MontoAdelanto", True))
        Me.txtMontoAdelanto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoAdelanto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMontoAdelanto.Location = New System.Drawing.Point(276, 142)
        Me.txtMontoAdelanto.Name = "txtMontoAdelanto"
        Me.txtMontoAdelanto.Size = New System.Drawing.Size(168, 13)
        Me.txtMontoAdelanto.TabIndex = 5
        Me.txtMontoAdelanto.Text = "0"
        Me.txtMontoAdelanto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(23, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 14)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "Retencion de Renta:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(23, 73)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 14)
        Me.Label14.TabIndex = 198
        Me.Label14.Text = "Cta. x Cobrar Emp. $:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 196
        Me.Label2.Text = "Cta. x Cobrar Emp. ¢"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbpImpuestos
        '
        Me.tbpImpuestos.Controls.Add(Me.txtPorcImpRenta)
        Me.tbpImpuestos.Controls.Add(Me.Label3)
        Me.tbpImpuestos.Controls.Add(Me.cboExtraPropina)
        Me.tbpImpuestos.Controls.Add(Me.cboImpuestoRenta)
        Me.tbpImpuestos.Controls.Add(Me.cboImpuestoServicio)
        Me.tbpImpuestos.Controls.Add(Me.cboImpuestoVenta)
        Me.tbpImpuestos.Controls.Add(Me.Label32)
        Me.tbpImpuestos.Controls.Add(Me.Label30)
        Me.tbpImpuestos.Controls.Add(Me.Label9)
        Me.tbpImpuestos.Controls.Add(Me.Label11)
        Me.tbpImpuestos.Controls.Add(Me.Label24)
        Me.tbpImpuestos.Location = New System.Drawing.Point(4, 22)
        Me.tbpImpuestos.Name = "tbpImpuestos"
        Me.tbpImpuestos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpImpuestos.Size = New System.Drawing.Size(650, 390)
        Me.tbpImpuestos.TabIndex = 2
        Me.tbpImpuestos.Text = "Impuestos y Extra Propina Salonero"
        Me.tbpImpuestos.UseVisualStyleBackColor = True
        '
        'txtPorcImpRenta
        '
        Me.txtPorcImpRenta.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bdsSetting, "PorcImpuestoRenta", True))
        Me.txtPorcImpRenta.Location = New System.Drawing.Point(173, 120)
        Me.txtPorcImpRenta.Name = "txtPorcImpRenta"
        Me.txtPorcImpRenta.Size = New System.Drawing.Size(63, 20)
        Me.txtPorcImpRenta.TabIndex = 215
        Me.txtPorcImpRenta.Text = "0"
        Me.txtPorcImpRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 14)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Impuesto de Renta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboExtraPropina
        '
        Me.cboExtraPropina.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdPropina", True))
        Me.cboExtraPropina.DataSource = Me.BindingSource23
        Me.cboExtraPropina.DisplayMember = "Descripción"
        Me.cboExtraPropina.FormattingEnabled = True
        Me.cboExtraPropina.Location = New System.Drawing.Point(173, 155)
        Me.cboExtraPropina.Name = "cboExtraPropina"
        Me.cboExtraPropina.Size = New System.Drawing.Size(469, 21)
        Me.cboExtraPropina.TabIndex = 3
        Me.cboExtraPropina.ValueMember = "Id"
        '
        'BindingSource23
        '
        Me.BindingSource23.DataMember = "dtCuentaContable"
        Me.BindingSource23.DataSource = Me.DtsSetting1
        '
        'cboImpuestoRenta
        '
        Me.cboImpuestoRenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdImpuestoRenta", True))
        Me.cboImpuestoRenta.DataSource = Me.BindingSource22
        Me.cboImpuestoRenta.DisplayMember = "Descripción"
        Me.cboImpuestoRenta.FormattingEnabled = True
        Me.cboImpuestoRenta.Location = New System.Drawing.Point(173, 86)
        Me.cboImpuestoRenta.Name = "cboImpuestoRenta"
        Me.cboImpuestoRenta.Size = New System.Drawing.Size(469, 21)
        Me.cboImpuestoRenta.TabIndex = 2
        Me.cboImpuestoRenta.ValueMember = "Id"
        '
        'BindingSource22
        '
        Me.BindingSource22.DataMember = "dtCuentaContable"
        Me.BindingSource22.DataSource = Me.DtsSetting1
        '
        'cboImpuestoServicio
        '
        Me.cboImpuestoServicio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdServicio", True))
        Me.cboImpuestoServicio.DataSource = Me.BindingSource21
        Me.cboImpuestoServicio.DisplayMember = "Descripción"
        Me.cboImpuestoServicio.FormattingEnabled = True
        Me.cboImpuestoServicio.Location = New System.Drawing.Point(173, 59)
        Me.cboImpuestoServicio.Name = "cboImpuestoServicio"
        Me.cboImpuestoServicio.Size = New System.Drawing.Size(469, 21)
        Me.cboImpuestoServicio.TabIndex = 1
        Me.cboImpuestoServicio.ValueMember = "Id"
        '
        'BindingSource21
        '
        Me.BindingSource21.DataMember = "dtCuentaContable"
        Me.BindingSource21.DataSource = Me.DtsSetting1
        '
        'cboImpuestoVenta
        '
        Me.cboImpuestoVenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bdsSetting, "IdImpuestoVenta", True))
        Me.cboImpuestoVenta.DataSource = Me.BindingSource20
        Me.cboImpuestoVenta.DisplayMember = "Descripción"
        Me.cboImpuestoVenta.FormattingEnabled = True
        Me.cboImpuestoVenta.Location = New System.Drawing.Point(173, 32)
        Me.cboImpuestoVenta.Name = "cboImpuestoVenta"
        Me.cboImpuestoVenta.Size = New System.Drawing.Size(469, 21)
        Me.cboImpuestoVenta.TabIndex = 0
        Me.cboImpuestoVenta.ValueMember = "Id"
        '
        'BindingSource20
        '
        Me.BindingSource20.DataMember = "dtCuentaContable"
        Me.BindingSource20.DataSource = Me.DtsSetting1
        '
        'Label32
        '
        Me.Label32.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.White
        Me.Label32.Location = New System.Drawing.Point(23, 86)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(144, 14)
        Me.Label32.TabIndex = 213
        Me.Label32.Text = "Impuesto de Renta:"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label30
        '
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(173, 12)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(470, 14)
        Me.Label30.TabIndex = 210
        Me.Label30.Text = "Descripción cuenta"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(23, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 14)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Impuesto venta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(23, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 14)
        Me.Label11.TabIndex = 182
        Me.Label11.Text = "Impuesto Servicio:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(23, 154)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(144, 14)
        Me.Label24.TabIndex = 208
        Me.Label24.Text = "Extra Propina:"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(200, 476)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 20)
        Me.txtUsuario.TabIndex = 108
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(120, 476)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 13)
        Me.txtClave.TabIndex = 0
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(200, 462)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 14)
        Me.Label17.TabIndex = 109
        Me.Label17.Text = "Usuario"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(120, 460)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 14)
        Me.Label18.TabIndex = 107
        Me.Label18.Text = "Clave"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'erpProvider
        '
        Me.erpProvider.ContainerControl = Me
        '
        'SettingCuentaContableTableAdapter
        '
        Me.SettingCuentaContableTableAdapter.ClearBeforeFill = True
        '
        'BindingSource12
        '
        Me.BindingSource12.DataMember = "dtCuentaContable"
        Me.BindingSource12.DataSource = Me.DtsSetting1
        '
        'FrmSettingHotelCuentaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(667, 514)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tabCuentas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmSettingHotelCuentaContable"
        Me.Text = "Setting de cuenta contable"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.tabCuentas, 0)
        Me.Controls.SetChildIndex(Me.Label18, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.tabCuentas.ResumeLayout(False)
        Me.tabpageGeneral.ResumeLayout(False)
        CType(Me.bdsSetting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsSetting1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsdCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpPlanilla.ResumeLayout(False)
        Me.tbpPlanilla.PerformLayout()
        CType(Me.BindingSource19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpImpuestos.ResumeLayout(False)
        Me.tbpImpuestos.PerformLayout()
        CType(Me.BindingSource23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Variables"
    Dim caso As Integer 'sirve para indicar en cual textBox esta posisionado el cursor del teclado
    Dim idCuentaContable(22) As Integer ' saber los ids de las cuentas que seran guardadas en la tabla de contabilidad
    Dim usua As Object
    Dim NombreUsuario As String
#End Region

#Region "Funciones Gui"
    Private Sub fmrSettingCuentaFacturaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: esta línea de código carga datos en la tabla 'DtsSetting1.SettingCuentaContable' Puede moverla o quitarla según sea necesario.
        SettingCuentaContableTableAdapter.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        Me.SettingCuentaContableTableAdapter.Fill(Me.DtsSetting1.SettingCuentaContable)
        txtPorcImpRenta.Text = Me.BindingContext(bdsSetting, "PorcImpuestoRenta").Current
        LlenarComboPrepagoCuentaCliente()
        Dim dtIdPrepagoCuentaCliente As New DataTable

        cFunciones.Llenar_Tabla_Generico("Select IdPrepagoCuentaCliente from SettingCuentaContable", dtIdPrepagoCuentaCliente)
        If dtIdPrepagoCuentaCliente.Rows.Count > 0 Then

            ComboAdelantoCliente.SelectedValue = CStr(dtIdPrepagoCuentaCliente.Rows(0).Item("IdPrepagoCuentaCliente"))

        End If
        Cargar()
    End Sub


#End Region


#Region "Funciones Iniciacion"
    Private Sub Cargar()
        cls_Datos.sp_llenarTabla("Select CuentaContable + ' ' + Descripcion AS Descripción, id From CuentaContable WHERE Movimiento = 1", DtsSetting1.dtCuentaContable, "Contabilidad")
        tabCuentas.TabPages.Clear()
        ToolBarRegistrar.Enabled = False
        'tabCuentas.TabPages.Add(tabpageGeneral)
        'tabCuentas.TabPages.Add(tbpImpuestos)
        'tabCuentas.TabPages.Add(tbpPlanilla)
        txtClave.Focus()



    End Sub


#End Region

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        If e.Button.Text.Equals("Registrar") Then

            Try
                If CDbl(txtPorcImpRenta.Text) > 100 Then
                    MsgBox("No se admite un porcentaje mayor a 100", MsgBoxStyle.OkOnly)
                    tabCuentas.TabIndex = 1
                    txtPorcImpRenta.Focus()

                    Exit Sub
                ElseIf CDbl(txtPorcImpRenta.Text) < 0 Then
                    MsgBox("No se admite un porcentaje menor a cero", MsgBoxStyle.OkOnly)
                    tabCuentas.TabIndex = 1
                    txtPorcImpRenta.Focus()
                    Exit Sub
                End If
                BindingContext(Me.DtsSetting1, "SettingCuentaContable").EndCurrentEdit()
                bdsSetting.EndEdit()
                If MsgBox("¿Desea guardar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    For i As Integer = 0 To tabCuentas.TabPages.Count - 1
                        tabCuentas.TabIndex = i
                        bdsSetting.EndEdit()
                        BindingContext(Me.DtsSetting1, "SettingCuentaContable").EndCurrentEdit()
                    Next

                    Try
                        Dim Cconexion As New Conexion
                        Cconexion.SlqExecute(Cconexion.Conectar("Contabilidad"), "Update dbo.SettingCuentaContable set IdPrepagoCuentaCliente = " & Convert.ToInt32(ComboAdelantoCliente.SelectedValue) & "")

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try

                    Me.SettingCuentaContableTableAdapter.Update(DtsSetting1.SettingCuentaContable)
                    MsgBox("Datos guardados!!!", MsgBoxStyle.OkOnly)
                    ' Close()

                End If

            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.OkOnly)

            End Try
        Else
            Close()

        End If
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then

            Loggin_Usuario()

        End If
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
    Sub Loggin_Usuario()
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try

            If txtClave.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT  Id_Usuario,Nombre from Usuarios where Clave_Interna ='" & txtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta...", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Exit Sub
                End If



                While rs.Read
                    Try
                        If Seguridad.VSMA(rs("Id_Usuario"), Me.Name, 1) Then
                            NombreUsuario = rs("Nombre")
                            txtClave.Enabled = False
                            txtUsuario.Text = NombreUsuario
                            ToolBarRegistrar.Enabled = True
                            ToolBar1.Enabled = True
                            tabCuentas.TabPages.Add(tabpageGeneral)
                            tabCuentas.TabPages.Add(tbpImpuestos)
                            tabCuentas.TabPages.Add(tbpPlanilla)
                        Else
                            MsgBox("No tiene acceso a este modulo", MsgBoxStyle.OkOnly)

                        End If

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
    End Sub

    Private Sub cboCredCompServ_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cboCredCompServ.KeyDown, cboCaja.KeyDown, cboCompraExcenta.KeyDown, cboCompraGravada.KeyDown, cboCuentasPorCobrar.KeyDown, cboCxCEmpleadoColones.KeyDown, cboCxCEmpleadoDolar.KeyDown, cboCxCInHouse.KeyDown, cboDiferencialCaja.KeyDown, cboDiferencialGasto.KeyDown, cboExtraPropina.KeyDown, cboImpuestoRenta.KeyDown, cboImpuestoServicio.KeyDown, cboImpuestoVenta.KeyDown, cboInteresePrestamosEmpleado.KeyDown, cboOtroIngresoEmpleado.KeyDown, cboPrepagoColones.KeyDown, cboPrepagoDolares.KeyDown, cboPrepagoDolares.KeyDown, cboRetencionRenta.KeyDown, cboTransitoriaCXC.KeyDown, cboTravelCheck.KeyDown, cboUtilidadPeriodo.KeyDown
        If e.KeyCode = Keys.F1 Then
            sp_BuscaCuenta(sender)

        End If
    End Sub
    Sub sp_BuscaCuenta(ByVal cbo As ComboBox)
        Dim fr As New fmrBuscarMayorizacionAsiento
        Dim sql As String = " select cuentacontable as [Cuenta contable],Nombre,[Cuenta madre] from vs_CuentaConta  "

        fr.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        fr.sqlstring = sql
        fr.campo = "Descripcion"
        fr.ShowDialog()

        If fr.codigo = "" Or fr.codigo Is Nothing Then
            Exit Sub
        End If

        Dim dt As New DataTable

        cls_Datos.sp_llenarTabla("Select Id From CuentaContable Where CuentaContable = '" & fr.codigo & "'", dt, "Contabilidad")
        If dt.Rows.Count > 0 Then
            cbo.SelectedValue = dt.Rows(0).Item(0)
        End If


    End Sub
    Public Sub LlenarComboPrepagoCuentaCliente()
        Try
            Dim dtSettingsCuenta As New DataTable

            'dtSettingsCuenta.Clear()
            cFunciones.Llenar_Tabla_Generico("Select CuentaContable + ' ' + Descripcion AS Descripcion, id From CuentaContable WHERE Movimiento = 1", dtSettingsCuenta)
            ComboAdelantoCliente.ValueMember = "id"
            ComboAdelantoCliente.DisplayMember = "Descripcion"
            ComboAdelantoCliente.DataSource = dtSettingsCuenta

        Catch ex As Exception

        End Try
    End Sub


End Class
