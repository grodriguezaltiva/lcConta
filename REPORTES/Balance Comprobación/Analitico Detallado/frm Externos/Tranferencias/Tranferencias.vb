Imports System.data.SqlClient
Imports Utilidades

Public Class FrmTranferencias
    Inherits FrmPlantilla

#Region "Variables"
    Dim usuario As New Usuario_Logeado
    Dim usua As Object
    Dim FechaCon As DateTime
    Dim Conta As Integer
    Public id_trans As String
    Public cuentabancaria As String
    Public desdeconciliacion As Boolean = False
    Public TransCredito As Boolean
    Public modificar As Boolean = False
    Public nuevoMonto As Double = 0
    Public EditaAsiento As Boolean = False
    Public CedulaUsuario As String = ""
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro
        AddHandler Me.BindingContext(Me.DataSetTransferencia1, "Cuentas_bancariasOrigen").PositionChanged, AddressOf Me.Position_Changed
        AddHandler Me.BindingContext(Me.DataSetTransferencia1, "Cuentas_bancariasDestino").PositionChanged, AddressOf Me.Position_Changed
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
    Friend WithEvents ID_Tranferencia As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label

    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ComboCuentaOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombreMonOrigen As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCodMonedaOrigen1 As System.Windows.Forms.Label
    Friend WithEvents ComboCuentaDestino As System.Windows.Forms.ComboBox
    Friend WithEvents txtSimboloOrigen As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSimboloDestino As System.Windows.Forms.TextBox
    Friend WithEvents txtNumTransf As System.Windows.Forms.TextBox
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Dadestino As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtCodUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Anular As System.Windows.Forms.Label
    Friend WithEvents DaTransferencia As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetTransferencia1 As DataSetTransferencia
    Friend WithEvents DaOrigen As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTipoCambio As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtMontoOrigen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents daUsuarios As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtMontoDestino As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TextEdit2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Moneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtNumConciliacion As System.Windows.Forms.Label
    Friend WithEvents ckConciliado As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents ckConciliado_Destino As System.Windows.Forms.CheckBox
    Friend WithEvents txtNumConciliacion_Destino As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtNumTransf2 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTranferencias))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNumTransf = New System.Windows.Forms.TextBox
        Me.DataSetTransferencia1 = New Contabilidad.DataSetTransferencia
        Me.ID_Tranferencia = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboCuentaOrigen = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit
        Me.txtMontoOrigen = New DevExpress.XtraEditors.TextEdit
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSimboloOrigen = New System.Windows.Forms.Label
        Me.txtCodMonedaOrigen1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNombreMonOrigen = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Anular = New System.Windows.Forms.Label
        Me.TextEdit2 = New DevExpress.XtraEditors.TextEdit
        Me.txtMontoDestino = New DevExpress.XtraEditors.TextEdit
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtSimboloDestino = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.ComboCuentaDestino = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.Dadestino = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label48 = New System.Windows.Forms.Label
        Me.TxtCodUsuario = New System.Windows.Forms.TextBox
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox
        Me.DaTransferencia = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DaOrigen = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtNumTransf2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtNumConciliacion_Destino = New System.Windows.Forms.Label
        Me.ckConciliado_Destino = New System.Windows.Forms.CheckBox
        Me.txtNumConciliacion = New System.Windows.Forms.Label
        Me.ckConciliado = New System.Windows.Forms.CheckBox
        Me.txtTipoCambio = New DevExpress.XtraEditors.TextEdit
        Me.daUsuarios = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Moneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        CType(Me.DataSetTransferencia1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoOrigen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoDestino.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(650, 32)
        Me.TituloModulo.Text = "Transferencias entre Cuentas"
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarEliminar.Text = "Anular"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Enabled = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 259)
        Me.ToolBar1.Size = New System.Drawing.Size(650, 52)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Nº de Tranferencia"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNumTransf
        '
        Me.txtNumTransf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumTransf.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "TransferenciasBancarias.Num_Transferencia", True))
        Me.txtNumTransf.Location = New System.Drawing.Point(0, 23)
        Me.txtNumTransf.Name = "txtNumTransf"
        Me.txtNumTransf.Size = New System.Drawing.Size(182, 20)
        Me.txtNumTransf.TabIndex = 85
        '
        'DataSetTransferencia1
        '
        Me.DataSetTransferencia1.DataSetName = "DataSetTransferencia"
        Me.DataSetTransferencia1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DataSetTransferencia1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ID_Tranferencia
        '
        Me.ID_Tranferencia.BackColor = System.Drawing.SystemColors.Window
        Me.ID_Tranferencia.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "TransferenciasBancarias.Id_Transferencia", True))
        Me.ID_Tranferencia.Enabled = False
        Me.ID_Tranferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_Tranferencia.ForeColor = System.Drawing.Color.White
        Me.ID_Tranferencia.Location = New System.Drawing.Point(8, 16)
        Me.ID_Tranferencia.Name = "ID_Tranferencia"
        Me.ID_Tranferencia.Size = New System.Drawing.Size(80, 16)
        Me.ID_Tranferencia.TabIndex = 87
        Me.ID_Tranferencia.Text = "000000"
        Me.ID_Tranferencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(232, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Fecha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(2, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(502, 16)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Motivo  de la Tranferencia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "TransferenciasBancarias.Descripción", True))
        Me.txtDescripcion.Location = New System.Drawing.Point(2, 197)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(502, 13)
        Me.txtDescripcion.TabIndex = 90
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(8, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 93
        Me.Label4.Text = "Moneda"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'ComboCuentaOrigen
        '
        Me.ComboCuentaOrigen.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetTransferencia1, "TransferenciasBancarias.Id_Cuenta_Origen", True))
        Me.ComboCuentaOrigen.DataSource = Me.DataSetTransferencia1
        Me.ComboCuentaOrigen.DisplayMember = "Cuentas_bancariasOrigen.Cuenta"
        Me.ComboCuentaOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCuentaOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCuentaOrigen.ForeColor = System.Drawing.Color.Blue
        Me.ComboCuentaOrigen.Location = New System.Drawing.Point(64, 24)
        Me.ComboCuentaOrigen.Name = "ComboCuentaOrigen"
        Me.ComboCuentaOrigen.Size = New System.Drawing.Size(176, 21)
        Me.ComboCuentaOrigen.TabIndex = 94
        Me.ComboCuentaOrigen.ValueMember = "Cuentas_bancariasOrigen.Id_CuentaBancaria"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 95
        Me.Label5.Text = "Cuenta:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextEdit1)
        Me.Panel1.Controls.Add(Me.txtMontoOrigen)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtSimboloOrigen)
        Me.Panel1.Controls.Add(Me.txtCodMonedaOrigen1)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtNombreMonOrigen)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ComboCuentaOrigen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(0, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(316, 128)
        Me.Panel1.TabIndex = 96
        '
        'TextEdit1
        '
        Me.TextEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetTransferencia1, "Cuentas_bancariasOrigen.Saldo", True))
        Me.TextEdit1.EditValue = ""
        Me.TextEdit1.Location = New System.Drawing.Point(208, 72)
        Me.TextEdit1.Name = "TextEdit1"
        '
        '
        '
        Me.TextEdit1.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit1.Properties.Enabled = False
        Me.TextEdit1.Properties.StyleBorder = New DevExpress.Utils.ViewStyle("ControlStyleBorder", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), False, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control)
        Me.TextEdit1.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextEdit1.Size = New System.Drawing.Size(104, 21)
        Me.TextEdit1.TabIndex = 204
        '
        'txtMontoOrigen
        '
        Me.txtMontoOrigen.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetTransferencia1, "TransferenciasBancarias.Monto_Origen", True))
        Me.txtMontoOrigen.EditValue = ""
        Me.txtMontoOrigen.Location = New System.Drawing.Point(168, 98)
        Me.txtMontoOrigen.Name = "txtMontoOrigen"
        '
        '
        '
        Me.txtMontoOrigen.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMontoOrigen.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoOrigen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoOrigen.Size = New System.Drawing.Size(128, 21)
        Me.txtMontoOrigen.TabIndex = 203
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasOrigen.tipoCuenta", True))
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(240, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 107
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasOrigen.Descripcion", True))
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(64, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(248, 16)
        Me.Label8.TabIndex = 106
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtSimboloOrigen
        '
        Me.txtSimboloOrigen.BackColor = System.Drawing.Color.White
        Me.txtSimboloOrigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtSimboloOrigen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasOrigen.Simbolo", True))
        Me.txtSimboloOrigen.Enabled = False
        Me.txtSimboloOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimboloOrigen.ForeColor = System.Drawing.Color.Blue
        Me.txtSimboloOrigen.Location = New System.Drawing.Point(149, 99)
        Me.txtSimboloOrigen.Name = "txtSimboloOrigen"
        Me.txtSimboloOrigen.Size = New System.Drawing.Size(18, 16)
        Me.txtSimboloOrigen.TabIndex = 105
        Me.txtSimboloOrigen.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtCodMonedaOrigen1
        '
        Me.txtCodMonedaOrigen1.BackColor = System.Drawing.Color.White
        Me.txtCodMonedaOrigen1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtCodMonedaOrigen1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasOrigen.ValorCompra", True))
        Me.txtCodMonedaOrigen1.Enabled = False
        Me.txtCodMonedaOrigen1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodMonedaOrigen1.ForeColor = System.Drawing.Color.Blue
        Me.txtCodMonedaOrigen1.Location = New System.Drawing.Point(64, 72)
        Me.txtCodMonedaOrigen1.Name = "txtCodMonedaOrigen1"
        Me.txtCodMonedaOrigen1.Size = New System.Drawing.Size(56, 16)
        Me.txtCodMonedaOrigen1.TabIndex = 104
        Me.txtCodMonedaOrigen1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(8, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 102
        Me.Label16.Text = "Banco:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(3, 100)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 16)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Monto de la Tranferencia"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNombreMonOrigen
        '
        Me.txtNombreMonOrigen.BackColor = System.Drawing.Color.White
        Me.txtNombreMonOrigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtNombreMonOrigen.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasOrigen.MonedaNombre", True))
        Me.txtNombreMonOrigen.Enabled = False
        Me.txtNombreMonOrigen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreMonOrigen.ForeColor = System.Drawing.Color.Blue
        Me.txtNombreMonOrigen.Location = New System.Drawing.Point(120, 72)
        Me.txtNombreMonOrigen.Name = "txtNombreMonOrigen"
        Me.txtNombreMonOrigen.Size = New System.Drawing.Size(88, 16)
        Me.txtNombreMonOrigen.TabIndex = 98
        Me.txtNombreMonOrigen.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(320, 16)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Cuenta a Debitar"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Anular)
        Me.Panel2.Controls.Add(Me.TextEdit2)
        Me.Panel2.Controls.Add(Me.txtMontoDestino)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txtSimboloDestino)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.ComboCuentaDestino)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Location = New System.Drawing.Point(328, 47)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(316, 128)
        Me.Panel2.TabIndex = 97
        '
        'Anular
        '
        Me.Anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 34.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Anular.ForeColor = System.Drawing.Color.Red
        Me.Anular.Location = New System.Drawing.Point(8, 64)
        Me.Anular.Name = "Anular"
        Me.Anular.Size = New System.Drawing.Size(248, 32)
        Me.Anular.TabIndex = 200
        Me.Anular.Text = "Anulado"
        Me.Anular.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Anular.Visible = False
        '
        'TextEdit2
        '
        Me.TextEdit2.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetTransferencia1, "Cuentas_bancariasDestino.Saldo", True))
        Me.TextEdit2.EditValue = ""
        Me.TextEdit2.Location = New System.Drawing.Point(200, 69)
        Me.TextEdit2.Name = "TextEdit2"
        '
        '
        '
        Me.TextEdit2.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.TextEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TextEdit2.Properties.Enabled = False
        Me.TextEdit2.Properties.StyleBorder = New DevExpress.Utils.ViewStyle("ControlStyleBorder", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", CType((((((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                        Or DevExpress.Utils.StyleOptions.UseDrawEndEllipsis) _
                        Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                        Or DevExpress.Utils.StyleOptions.UseFont) _
                        Or DevExpress.Utils.StyleOptions.UseForeColor) _
                        Or DevExpress.Utils.StyleOptions.UseHorzAlignment) _
                        Or DevExpress.Utils.StyleOptions.UseImage) _
                        Or DevExpress.Utils.StyleOptions.UseWordWrap) _
                        Or DevExpress.Utils.StyleOptions.UseVertAlignment), DevExpress.Utils.StyleOptions), False, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Control)
        Me.TextEdit2.Properties.StyleDisabled = New DevExpress.Utils.ViewStyle("ControlStyleDisabled", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.[Default], DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.TextEdit2.Size = New System.Drawing.Size(112, 21)
        Me.TextEdit2.TabIndex = 205
        '
        'txtMontoDestino
        '
        Me.txtMontoDestino.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetTransferencia1, "TransferenciasBancarias.Monto_Destino", True))
        Me.txtMontoDestino.EditValue = ""
        Me.txtMontoDestino.Location = New System.Drawing.Point(176, 96)
        Me.txtMontoDestino.Name = "txtMontoDestino"
        '
        '
        '
        Me.txtMontoDestino.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtMontoDestino.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoDestino.Properties.Enabled = False
        Me.txtMontoDestino.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMontoDestino.Size = New System.Drawing.Size(128, 21)
        Me.txtMontoDestino.TabIndex = 204
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.White
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasDestino.ValorCompra", True))
        Me.Label21.Enabled = False
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(56, 70)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 16)
        Me.Label21.TabIndex = 110
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.White
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasDestino.MonedaNombre", True))
        Me.Label22.Enabled = False
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(112, 70)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(88, 16)
        Me.Label22.TabIndex = 109
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.White
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasDestino.tipoCuenta", True))
        Me.Label19.Enabled = False
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Blue
        Me.Label19.Location = New System.Drawing.Point(237, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 108
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasDestino.Descripcion", True))
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(56, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(256, 16)
        Me.Label11.TabIndex = 107
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtSimboloDestino
        '
        Me.txtSimboloDestino.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSimboloDestino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "Cuentas_bancariasDestino.Simbolo", True))
        Me.txtSimboloDestino.Enabled = False
        Me.txtSimboloDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSimboloDestino.ForeColor = System.Drawing.Color.Blue
        Me.txtSimboloDestino.Location = New System.Drawing.Point(152, 96)
        Me.txtSimboloDestino.Name = "txtSimboloDestino"
        Me.txtSimboloDestino.ReadOnly = True
        Me.txtSimboloDestino.Size = New System.Drawing.Size(24, 20)
        Me.txtSimboloDestino.TabIndex = 105
        Me.txtSimboloDestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(8, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Banco:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(4, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(141, 16)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "Monto de la Tranferencia"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(344, 16)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "Cuenta a Creditar"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboCuentaDestino
        '
        Me.ComboCuentaDestino.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DataSetTransferencia1, "TransferenciasBancarias.Id_Cuenta_Destino", True))
        Me.ComboCuentaDestino.DataSource = Me.DataSetTransferencia1
        Me.ComboCuentaDestino.DisplayMember = "Cuentas_bancariasDestino.Cuenta"
        Me.ComboCuentaDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCuentaDestino.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboCuentaDestino.ForeColor = System.Drawing.Color.Blue
        Me.ComboCuentaDestino.Location = New System.Drawing.Point(64, 24)
        Me.ComboCuentaDestino.Name = "ComboCuentaDestino"
        Me.ComboCuentaDestino.Size = New System.Drawing.Size(176, 21)
        Me.ComboCuentaDestino.TabIndex = 94
        Me.ComboCuentaDestino.ValueMember = "Cuentas_bancariasDestino.Id_CuentaBancaria"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(5, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 16)
        Me.Label14.TabIndex = 95
        Me.Label14.Text = "Cuenta:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(3, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 16)
        Me.Label15.TabIndex = 93
        Me.Label15.Text = "Moneda"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(328, 7)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(128, 16)
        Me.Label17.TabIndex = 98
        Me.Label17.Text = "Tipo de Cambio"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGOGAMBOA;packet size=4096;integrated security=SSPI;data source=" & _
            """."";persist security info=False;initial catalog=Bancos"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'Dadestino
        '
        Me.Dadestino.SelectCommand = Me.SqlSelectCommand1
        Me.Dadestino.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlCommand1
        '
        Me.SqlCommand1.CommandText = resources.GetString("SqlCommand1.CommandText")
        Me.SqlCommand1.Connection = Me.SqlConnection1
        '
        'Label48
        '
        Me.Label48.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.White
        Me.Label48.Location = New System.Drawing.Point(360, 280)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(72, 13)
        Me.Label48.TabIndex = 199
        Me.Label48.Text = "Usuario->"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCodUsuario
        '
        Me.TxtCodUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodUsuario.Location = New System.Drawing.Point(432, 280)
        Me.TxtCodUsuario.Name = "TxtCodUsuario"
        Me.TxtCodUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtCodUsuario.Size = New System.Drawing.Size(56, 13)
        Me.TxtCodUsuario.TabIndex = 197
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TxtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNombreUsuario.Enabled = False
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(488, 280)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.ReadOnly = True
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(163, 13)
        Me.TxtNombreUsuario.TabIndex = 198
        '
        'DaTransferencia
        '
        Me.DaTransferencia.DeleteCommand = Me.SqlDeleteCommand1
        Me.DaTransferencia.InsertCommand = Me.SqlInsertCommand1
        Me.DaTransferencia.SelectCommand = Me.SqlSelectCommand2
        Me.DaTransferencia.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TransferenciasBancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Transferencia", "Id_Transferencia"), New System.Data.Common.DataColumnMapping("Num_Transferencia", "Num_Transferencia"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Descripción", "Descripción"), New System.Data.Common.DataColumnMapping("Moneda_Origen", "Moneda_Origen"), New System.Data.Common.DataColumnMapping("Monto_Origen", "Monto_Origen"), New System.Data.Common.DataColumnMapping("Monto_Destino", "Monto_Destino"), New System.Data.Common.DataColumnMapping("Moneda_Destino", "Moneda_Destino"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Id_Cuenta_Origen", "Id_Cuenta_Origen"), New System.Data.Common.DataColumnMapping("Id_Cuenta_Destino", "Id_Cuenta_Destino"), New System.Data.Common.DataColumnMapping("Anula", "Anula"), New System.Data.Common.DataColumnMapping("Conciliado", "Conciliado"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion"), New System.Data.Common.DataColumnMapping("Num_Asiento", "Num_Asiento"), New System.Data.Common.DataColumnMapping("ConciliadoDestino", "ConciliadoDestino"), New System.Data.Common.DataColumnMapping("Num_ConciliacionDes", "Num_ConciliacionDes"), New System.Data.Common.DataColumnMapping("Num_Transferencia2", "Num_Transferencia2")})})
        Me.DaTransferencia.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Transferencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Transferencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConciliadoDestino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConciliadoDestino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripción", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripción", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta_Destino", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta_Destino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta_Origen", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta_Origen", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda_Destino", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Destino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda_Origen", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Origen", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Destino", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Destino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Origen", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Origen", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_ConciliacionDes", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_ConciliacionDes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Transferencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Transferencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Transferencia2", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Transferencia2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Transferencia", System.Data.SqlDbType.BigInt, 8, "Num_Transferencia"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Descripción", System.Data.SqlDbType.VarChar, 250, "Descripción"), New System.Data.SqlClient.SqlParameter("@Moneda_Origen", System.Data.SqlDbType.Int, 4, "Moneda_Origen"), New System.Data.SqlClient.SqlParameter("@Monto_Origen", System.Data.SqlDbType.Float, 8, "Monto_Origen"), New System.Data.SqlClient.SqlParameter("@Monto_Destino", System.Data.SqlDbType.Float, 8, "Monto_Destino"), New System.Data.SqlClient.SqlParameter("@Moneda_Destino", System.Data.SqlDbType.Int, 4, "Moneda_Destino"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Id_Cuenta_Origen", System.Data.SqlDbType.Int, 4, "Id_Cuenta_Origen"), New System.Data.SqlClient.SqlParameter("@Id_Cuenta_Destino", System.Data.SqlDbType.Int, 4, "Id_Cuenta_Destino"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"), New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"), New System.Data.SqlClient.SqlParameter("@Num_Asiento", System.Data.SqlDbType.VarChar, 15, "Num_Asiento"), New System.Data.SqlClient.SqlParameter("@ConciliadoDestino", System.Data.SqlDbType.Bit, 1, "ConciliadoDestino"), New System.Data.SqlClient.SqlParameter("@Num_ConciliacionDes", System.Data.SqlDbType.BigInt, 8, "Num_ConciliacionDes"), New System.Data.SqlClient.SqlParameter("@Num_Transferencia2", System.Data.SqlDbType.BigInt, 8, "Num_Transferencia2")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Num_Transferencia", System.Data.SqlDbType.BigInt, 8, "Num_Transferencia"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"), New System.Data.SqlClient.SqlParameter("@Descripción", System.Data.SqlDbType.VarChar, 250, "Descripción"), New System.Data.SqlClient.SqlParameter("@Moneda_Origen", System.Data.SqlDbType.Int, 4, "Moneda_Origen"), New System.Data.SqlClient.SqlParameter("@Monto_Origen", System.Data.SqlDbType.Float, 8, "Monto_Origen"), New System.Data.SqlClient.SqlParameter("@Monto_Destino", System.Data.SqlDbType.Float, 8, "Monto_Destino"), New System.Data.SqlClient.SqlParameter("@Moneda_Destino", System.Data.SqlDbType.Int, 4, "Moneda_Destino"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Id_Cuenta_Origen", System.Data.SqlDbType.Int, 4, "Id_Cuenta_Origen"), New System.Data.SqlClient.SqlParameter("@Id_Cuenta_Destino", System.Data.SqlDbType.Int, 4, "Id_Cuenta_Destino"), New System.Data.SqlClient.SqlParameter("@Anula", System.Data.SqlDbType.Bit, 1, "Anula"), New System.Data.SqlClient.SqlParameter("@Conciliado", System.Data.SqlDbType.Bit, 1, "Conciliado"), New System.Data.SqlClient.SqlParameter("@Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, "Num_Conciliacion"), New System.Data.SqlClient.SqlParameter("@Num_Asiento", System.Data.SqlDbType.VarChar, 15, "Num_Asiento"), New System.Data.SqlClient.SqlParameter("@ConciliadoDestino", System.Data.SqlDbType.Bit, 1, "ConciliadoDestino"), New System.Data.SqlClient.SqlParameter("@Num_ConciliacionDes", System.Data.SqlDbType.BigInt, 8, "Num_ConciliacionDes"), New System.Data.SqlClient.SqlParameter("@Num_Transferencia2", System.Data.SqlDbType.BigInt, 8, "Num_Transferencia2"), New System.Data.SqlClient.SqlParameter("@Original_Id_Transferencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Transferencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anula", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anula", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Conciliado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Conciliado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ConciliadoDestino", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ConciliadoDestino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripción", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripción", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta_Destino", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta_Destino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_Cuenta_Origen", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Cuenta_Origen", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda_Destino", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Destino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Moneda_Origen", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Moneda_Origen", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Destino", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Destino", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto_Origen", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto_Origen", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Asiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Asiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Conciliacion", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Conciliacion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_ConciliacionDes", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_ConciliacionDes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Transferencia", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Transferencia", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Num_Transferencia2", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Num_Transferencia2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Transferencia", System.Data.SqlDbType.BigInt, 8, "Id_Transferencia")})
        '
        'DaOrigen
        '
        Me.DaOrigen.SelectCommand = Me.SqlSelectCommand4
        Me.DaOrigen.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("Saldo", "Saldo"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'DateEdit1
        '
        Me.DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetTransferencia1, "TransferenciasBancarias.Fecha", True))
        Me.DateEdit1.EditValue = New Date(2006, 7, 3, 0, 0, 0, 0)
        Me.DateEdit1.Location = New System.Drawing.Point(232, 23)
        Me.DateEdit1.Name = "DateEdit1"
        '
        '
        '
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Size = New System.Drawing.Size(88, 21)
        Me.DateEdit1.TabIndex = 201
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNumTransf2)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txtNumConciliacion_Destino)
        Me.Panel3.Controls.Add(Me.ckConciliado_Destino)
        Me.Panel3.Controls.Add(Me.txtNumConciliacion)
        Me.Panel3.Controls.Add(Me.ckConciliado)
        Me.Panel3.Controls.Add(Me.txtTipoCambio)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.DateEdit1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtNumTransf)
        Me.Panel3.Controls.Add(Me.txtDescripcion)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Location = New System.Drawing.Point(0, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(648, 226)
        Me.Panel3.TabIndex = 202
        '
        'txtNumTransf2
        '
        Me.txtNumTransf2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumTransf2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "TransferenciasBancarias.Num_Transferencia2", True))
        Me.txtNumTransf2.Location = New System.Drawing.Point(512, 196)
        Me.txtNumTransf2.Name = "txtNumTransf2"
        Me.txtNumTransf2.Size = New System.Drawing.Size(128, 20)
        Me.txtNumTransf2.TabIndex = 208
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(512, 181)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 16)
        Me.Label18.TabIndex = 207
        Me.Label18.Text = "Nº de Tranferencia"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtNumConciliacion_Destino
        '
        Me.txtNumConciliacion_Destino.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "TransferenciasBancarias.Num_ConciliacionDes", True))
        Me.txtNumConciliacion_Destino.Enabled = False
        Me.txtNumConciliacion_Destino.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumConciliacion_Destino.Location = New System.Drawing.Point(608, 24)
        Me.txtNumConciliacion_Destino.Name = "txtNumConciliacion_Destino"
        Me.txtNumConciliacion_Destino.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumConciliacion_Destino.Size = New System.Drawing.Size(32, 16)
        Me.txtNumConciliacion_Destino.TabIndex = 206
        '
        'ckConciliado_Destino
        '
        Me.ckConciliado_Destino.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetTransferencia1, "TransferenciasBancarias.ConciliadoDestino", True))
        Me.ckConciliado_Destino.Enabled = False
        Me.ckConciliado_Destino.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConciliado_Destino.Location = New System.Drawing.Point(464, 24)
        Me.ckConciliado_Destino.Name = "ckConciliado_Destino"
        Me.ckConciliado_Destino.Size = New System.Drawing.Size(136, 16)
        Me.ckConciliado_Destino.TabIndex = 205
        Me.ckConciliado_Destino.Text = "Conciliado Debito"
        '
        'txtNumConciliacion
        '
        Me.txtNumConciliacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTransferencia1, "TransferenciasBancarias.Num_Conciliacion", True))
        Me.txtNumConciliacion.Enabled = False
        Me.txtNumConciliacion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumConciliacion.Location = New System.Drawing.Point(608, 8)
        Me.txtNumConciliacion.Name = "txtNumConciliacion"
        Me.txtNumConciliacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNumConciliacion.Size = New System.Drawing.Size(32, 16)
        Me.txtNumConciliacion.TabIndex = 204
        '
        'ckConciliado
        '
        Me.ckConciliado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DataSetTransferencia1, "TransferenciasBancarias.Conciliado", True))
        Me.ckConciliado.Enabled = False
        Me.ckConciliado.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckConciliado.Location = New System.Drawing.Point(464, 8)
        Me.ckConciliado.Name = "ckConciliado"
        Me.ckConciliado.Size = New System.Drawing.Size(136, 16)
        Me.ckConciliado.TabIndex = 203
        Me.ckConciliado.Text = "Conciliado Credito"
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.DataSetTransferencia1, "TransferenciasBancarias.TipoCambio", True))
        Me.txtTipoCambio.EditValue = ""
        Me.txtTipoCambio.Location = New System.Drawing.Point(328, 23)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        '
        '
        '
        Me.txtTipoCambio.Properties.DisplayFormat.FormatString = "#,#0.000000"
        Me.txtTipoCambio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtTipoCambio.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.SystemColors.WindowText)
        Me.txtTipoCambio.Size = New System.Drawing.Size(128, 21)
        Me.txtTipoCambio.TabIndex = 202
        '
        'daUsuarios
        '
        Me.daUsuarios.SelectCommand = Me.SqlSelectCommand3
        Me.daUsuarios.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Usuarios", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Clave_Entrada", "Clave_Entrada"), New System.Data.Common.DataColumnMapping("Clave_Interna", "Clave_Interna"), New System.Data.Common.DataColumnMapping("Cedula", "Cedula")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Nombre, Clave_Entrada, Clave_Interna, Cedula FROM Usuarios"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Moneda
        '
        Me.Moneda.SelectCommand = Me.SqlSelectCommand5
        Me.Moneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Monedas", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta")})})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, Simbolo, ValorVenta FROM Monedas"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdapterAsientos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection2
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = resources.GetString("SqlSelectCommand6.CommandText")
        Me.SqlSelectCommand6.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterDetallesAsientos
        '
        Me.AdapterDetallesAsientos.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterDetallesAsientos.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterDetallesAsientos.SelectCommand = Me.SqlSelectCommand7
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection2
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio")})
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
            "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'FrmTranferencias
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(650, 311)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label48)
        Me.Controls.Add(Me.TxtCodUsuario)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.ID_Tranferencia)
        Me.MaximumSize = New System.Drawing.Size(656, 336)
        Me.MinimumSize = New System.Drawing.Size(656, 336)
        Me.Name = "FrmTranferencias"
        Me.Text = "Tranferencias"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.ID_Tranferencia, 0)
        Me.Controls.SetChildIndex(Me.TxtNombreUsuario, 0)
        Me.Controls.SetChildIndex(Me.TxtCodUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label48, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        CType(Me.DataSetTransferencia1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoOrigen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TextEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoDestino.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.txtTipoCambio.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub Tranferencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filas1, filas2 As Integer
        Dim fx As New cFunciones
        Try
            SqlConnection1.ConnectionString = GetSetting("Seesoft", "Bancos", "Conexion")
            SqlConnection2.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            DaOrigen.Fill(DataSetTransferencia1.Cuentas_bancariasOrigen)
            filas1 = DataSetTransferencia1.Cuentas_bancariasOrigen.Rows.Count()
            Dadestino.Fill(DataSetTransferencia1.Cuentas_bancariasDestino)
            filas2 = DataSetTransferencia1.Cuentas_bancariasDestino.Rows.Count()
            daUsuarios.Fill(DataSetTransferencia1.Usuarios)
            ValoresDefecto()
            InhabilitarTransferencia()
            If CedulaUsuario.Equals("") Then CedulaUsuario = usua.cedula
            TxtCodUsuario.Text = CedulaUsuario
            If TxtCodUsuario.Text <> "" Then
                Loggin_Usuario()
            End If

            'If desdeconciliacion Then
            If modificar Then
                CargarCheques(id_trans)
                ToolBarNuevo.Enabled = False
                ToolBarExcel.Enabled = True
                Editar()
            Else
                Nuevo()
            End If
            ToolBarBuscar.Enabled = False
            'End If
        Catch ex As Exception
            If filas1 = 0 Or filas2 = 0 Then
                MsgBox("No se encuentra ninguna cuenta bancaria registrada, no es posible realizar ninguna transacción... ")
            Else
                MsgBox("Problemas al cargar el Formulario, Intente abrir otra vez, si el problema persiste comuniqueselo al administrador del sistema ")
                MsgBox(ex.ToString)
            End If
        End Try
    End Sub


    Public Sub ValoresDefecto()
        'Establecer valores por defecto TransferenciasBancarias
        If desdeconciliacion = True Then
            If modificar <> True Then
                If TransCredito = True Then
                    DataSetTransferencia1.TransferenciasBancarias.Id_Cuenta_OrigenColumn.DefaultValue = cuentabancaria
                    ComboCuentaOrigen.Enabled = False
                End If
                If TransCredito = False Then
                    DataSetTransferencia1.TransferenciasBancarias.Id_Cuenta_DestinoColumn.DefaultValue = cuentabancaria
                    ComboCuentaDestino.Enabled = False
                End If
            End If
        Else
            ComboCuentaOrigen.Enabled = True : ComboCuentaDestino.Enabled = True
            DataSetTransferencia1.TransferenciasBancarias.Id_Cuenta_OrigenColumn.DefaultValue = Me.DataSetTransferencia1.Cuentas_bancariasOrigen.Rows(0).Item("Id_CuentaBancaria")
            DataSetTransferencia1.TransferenciasBancarias.Id_Cuenta_DestinoColumn.DefaultValue = Me.DataSetTransferencia1.Cuentas_bancariasDestino.Rows(0).Item("Id_CuentaBancaria")
        End If
        DataSetTransferencia1.TransferenciasBancarias.Num_TransferenciaColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.FechaColumn.DefaultValue = Now
        DataSetTransferencia1.TransferenciasBancarias.DescripciónColumn.DefaultValue = ""
        DataSetTransferencia1.TransferenciasBancarias.Moneda_OrigenColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.Moneda_DestinoColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.Monto_OrigenColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.Monto_DestinoColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.TipoCambioColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.AnulaColumn.DefaultValue = False
        DataSetTransferencia1.TransferenciasBancarias.ConciliadoColumn.DefaultValue = False
        DataSetTransferencia1.TransferenciasBancarias.Num_ConciliacionColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.ConciliadoDestinoColumn.DefaultValue = False
        DataSetTransferencia1.TransferenciasBancarias.Num_ConciliacionDesColumn.DefaultValue = 0
        DataSetTransferencia1.TransferenciasBancarias.Num_AsientoColumn.DefaultValue = "0"
        DataSetTransferencia1.TransferenciasBancarias.Num_Transferencia2Column.DefaultValue = "0"

        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DataSetTransferencia1.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DataSetTransferencia1.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DataSetTransferencia1.AsientosContables.NumDocColumn.DefaultValue = "0"
        DataSetTransferencia1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DataSetTransferencia1.AsientosContables.TipoDocColumn.DefaultValue = 24
        DataSetTransferencia1.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DataSetTransferencia1.AsientosContables.AnuladoColumn.DefaultValue = 0
        DataSetTransferencia1.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DataSetTransferencia1.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DataSetTransferencia1.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DataSetTransferencia1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DataSetTransferencia1.AsientosContables.ModuloColumn.DefaultValue = "Transferencias Bancarias"
        DataSetTransferencia1.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DataSetTransferencia1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DataSetTransferencia1.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DataSetTransferencia1.AsientosContables.TotalHaberColumn.DefaultValue = 0

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DataSetTransferencia1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DataSetTransferencia1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DataSetTransferencia1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DataSetTransferencia1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DataSetTransferencia1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DataSetTransferencia1.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DataSetTransferencia1.DetallesAsientosContable.HaberColumn.DefaultValue = 0
    End Sub
#End Region

#Region "Position Changed"
    Private Sub Position_Changed(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ToolBarNuevo.Text = "Cancelar" Or Me.ToolBarExcel.Text = "Cancelar" Then
            Me.Cambio()
        End If
    End Sub
#End Region

#Region "Calculos"
    Function Cambio()
        Try
            If Me.txtSimboloOrigen.Text = Me.txtSimboloDestino.Text Then
                Me.txtMontoDestino.Text = Me.txtMontoOrigen.Text
            Else
                If Me.txtSimboloOrigen.Text = "$" And Me.txtSimboloDestino.Text = "¢" Then
                    Dim Monto As Double = CDbl(txtMontoOrigen.Text)
                    Dim FactorCambio As Double = txtTipoCambio.Text
                    Dim MontoTotal As Double = Monto * FactorCambio
                    txtMontoDestino.Text = Format(MontoTotal, "#,#0.00")
                End If

                If Me.txtSimboloOrigen.Text = "¢" And Me.txtSimboloDestino.Text = "$" Then
                    Dim Monto As Double = CDbl(txtMontoOrigen.Text)
                    Dim FactorCambio As Double = txtTipoCambio.Text
                    Dim MontoTotal As Double = Monto / FactorCambio
                    txtMontoDestino.Text = Format(MontoTotal, "#,#0.00")
                End If

                If Me.txtSimboloOrigen.Text = "¢" And Me.txtSimboloDestino.Text = "€" Then
                    Dim Monto As Double = CDbl(txtMontoOrigen.Text)
                    Dim FactorCambio As Double = txtTipoCambio.Text
                    Dim MontoTotal As Double = Monto / FactorCambio
                    txtMontoDestino.Text = Format(MontoTotal, "#,#0.00")
                End If

                If Me.txtSimboloOrigen.Text = "€" And Me.txtSimboloDestino.Text = "¢" Then
                    Dim Monto As Double = CDbl(txtMontoOrigen.Text)
                    Dim FactorCambio As Double = txtTipoCambio.Text
                    Dim MontoTotal As Double = Monto * FactorCambio
                    txtMontoDestino.Text = Format(MontoTotal, "#,#0.00")
                End If

                If Me.txtSimboloOrigen.Text = "€" And Me.txtSimboloDestino.Text = "$" Then
                    Dim Monto As Double = CDbl(txtMontoOrigen.Text)
                    Dim FactorCambio As Double = txtTipoCambio.Text
                    Dim MontoTotal As Double = Monto * FactorCambio
                    txtMontoDestino.Text = Format(MontoTotal, "#,#0.00")
                End If

                If Me.txtSimboloOrigen.Text = "€" And Me.txtSimboloDestino.Text = "$" Then
                    Dim Monto As Double = CDbl(txtMontoOrigen.Text)
                    Dim FactorCambio As Double = txtTipoCambio.Text
                    Dim MontoTotal As Double = Monto / FactorCambio
                    txtMontoDestino.Text = Format(MontoTotal, "#,#0.00")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Function
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Update Then Guardar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then Anula() Else MsgBox("No tiene permiso para anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Editar()

            Case 7 : Me.Close()
        End Select
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
            If Me.BindingContext(Me.DataSetTransferencia1.Usuarios).Count > 0 Then
                Dim Usuario_autorizadores() As System.Data.DataRow
                Dim Usua As System.Data.DataRow

                Usuario_autorizadores = Me.DataSetTransferencia1.Usuarios.Select("Cedula ='" & CedulaUsuario & "'")
                If Usuario_autorizadores.Length <> 0 Then
                    Usua = Usuario_autorizadores(0)
                    TxtNombreUsuario.Text = Usua("Nombre")
                    usuario.Cedula = Usua("Cedula")
                    usuario.Nombre = Usua("Nombre")
                    ToolBarNuevo.Enabled = True
                    If ToolBar1.Buttons(0).Text = "Cancelar" Then
                        ToolBarRegistrar.Enabled = True
                    Else
                        ToolBarRegistrar.Enabled = False
                    End If
                    ToolBarBuscar.Enabled = True
                    ToolBarEliminar.Enabled = False
                    If desdeconciliacion Then
                        ToolBarNuevo.Enabled = Not modificar
                        ToolBarBuscar.Enabled = False
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

#Region "Buscar"
    Function Buscar()
        'Try
        '    Dim Fx As New cFunciones
        '    Dim Id_Cheque As String
        '    Id_Cheque = Fx.Buscar_X_Descripcion_Fecha("SELECT  Id_Transferencia AS Id, cast(cast(Num_Transferencia as decimal) as varchar) AS Número, Descripción, Fecha  FROM  TransferenciasBancarias ORDER BY Fecha DESC", "Descripción", "Fecha", "Buscar Transferencia", Me.SqlConnection1.ConnectionString)
        '    If Id_Cheque <> "" Then
        '        cargarTrans(Id_Cheque)
        '    End If
        'Catch ex As System.Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Function


    Sub cargarTrans(ByVal Id_Che As String)
        Try
            Me.DataSetTransferencia1.TransferenciasBancarias.Clear()
            Me.DataSetTransferencia1.Cuentas_bancariasOrigen.Clear()
            Me.DataSetTransferencia1.Cuentas_bancariasDestino.Clear()
            Me.Dadestino.Fill(Me.DataSetTransferencia1.Cuentas_bancariasDestino)
            Me.DaOrigen.Fill(Me.DataSetTransferencia1.Cuentas_bancariasOrigen)
            CargarCheques(Id_Che)
            If Me.DataSetTransferencia1.TransferenciasBancarias.Rows.Count > 0 Then
                If Me.DataSetTransferencia1.TransferenciasBancarias.Rows(0).Item("Anula") = True Then
                    Anular.Visible = True
                Else
                    Anular.Visible = False
                End If
                Me.ToolBarImprimir.Enabled = True
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                ToolBarExcel.Enabled = True
            End If
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Cargar Transferencia"
    Function CargarCheques(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Bancos", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from TransferenciasBancarias WHERE Id_Transferencia = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DataSetTransferencia1.TransferenciasBancarias)
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

#Region "Imprimir"
    Function Imprimir()
        Dim Apertura_Cajas As New ReporteTransferencias
        Dim visor As New frmVisorReportes
        Dim servidor As String = Me.SqlConnection1.DataSource
        Apertura_Cajas.SetDatabaseLogon("sa", "", Me.SqlConnection1.DataSource, Me.SqlConnection1.Database)
        Apertura_Cajas.SetParameterValue(0, Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia"))
        CrystalReportsConexion2.LoadReportBancos(visor.rptViewer, Apertura_Cajas, False, GetSetting("SeeSOFT", "Bancos", "Conexion"))
        visor.rptViewer.Visible = True
        Apertura_Cajas = Nothing
        visor.MdiParent = Me.ParentForm
        visor.Show()
    End Function
#End Region

#Region "Anular"
    Function Anula()
        Try
            Dim Funciones As New Conexion
            If MsgBox(" ¿ Desea Anular Transferencia entre Cuentas ?", MsgBoxStyle.YesNo, "Atensión....") = MsgBoxResult.No Then
                Exit Function
            End If
            If Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Conciliado") = True Or Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("ConciliadoDestino") = True Then
                MsgBox("No es Posible Anular esta Transferencia ya que ha sido Conciliada !!!!", MsgBoxStyle.Information)
                Exit Function
            End If

            ''VALIDA ASIENTO SI TIENE
            'If Not Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Asiento").Equals("0") Then
            '    Dim dt As New DataTable
            '    cFunciones.Llenar_Tabla_Generico("Select Mayorizado From AsientosContables WHERE NumAsiento = '" & Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Asiento") & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
            '    If dt.Rows.Count > 0 Then
            '        If dt.Rows(0).Item(0) Then
            '            MsgBox("El asiento # " & Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Asiento") & " que corresponde a este ajuste ya esta mayorizado, NO se puede anular", MsgBoxStyle.OKOnly)
            '            Exit Function
            '        End If
            '    End If
            'End If
            '---------------------------------------


            Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Anula") = True
            Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").EndCurrentEdit()
            Anular.Visible = True

            DaTransferencia.Update(DataSetTransferencia1.TransferenciasBancarias)
            MsgBox("Cheque Anulado satisfactoriamente", MsgBoxStyle.Information)
            'VALIDA ASIENTO SI TIENE Y ANUL
            If Not Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Asiento").Equals("0") Then
                Dim cx As New Conexion
                cx.Conectar("Contabilidad")
                cx.SlqExecute(cx.sQlconexion, "UPDATE AsientosContables Set Mayorizado = 0, Anulado = 1 WHERE NumAsiento = '" & Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Asiento") & "'")
                cx.DesConectar(cx.sQlconexion)
            End If
            '---------------------------------------
            BanderaGeneral.ACTUALIZO_ASIENTO2 = True
            BanderaGeneral.ACTUALIZO_ASIENTO = True

            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Function
#End Region

#Region "Controles"
    Function InhabilitarTransferencia()
        Me.Panel3.Enabled = False
    End Function

    Function HabilitarTransferencia()
        Me.Panel3.Enabled = True
    End Function

    Private Sub txtMontoOrigen_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMontoOrigen.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or e.KeyChar = Chr(Keys.Back) Or e.KeyChar = Chr(Keys.Right) Or e.KeyChar = Chr(Keys.Left) Or e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
#End Region

#Region "Validar"
    Function ValidarTransferencia() As Boolean
        Dim TipoCambio As Double
        Dim MontoDestino As Double
        If ComboCuentaOrigen.SelectedValue = ComboCuentaDestino.SelectedValue Then
            MsgBox("La cuenta de origen y la de destino no pueden ser la misma", MsgBoxStyle.Information)
            ComboCuentaOrigen.Focus()
            Return False
        End If
        Try
            TipoCambio = CDbl(txtTipoCambio.Text)
            If TipoCambio = 0 Then
                MsgBox("El tipo de cambio no puede ser 0")
                txtTipoCambio.Focus()
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        Try
            MontoDestino = CDbl(txtMontoDestino.EditValue)
            If MontoDestino = 0 Then
                MsgBox("El monto a transferir no puede ser 0")
                txtTipoCambio.Focus()
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        Try
            Dim Cx As New Conexion
            Dim Ajuste As String
            Dim Num_Transferencia As Integer = CDbl(txtNumTransf.Text)
            Ajuste = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Id_Transferencia FROM bancos.dbo.TransferenciasBancarias WHERE (Id_Cuenta_Origen = " & ComboCuentaOrigen.SelectedValue & " ) AND (Num_Transferencia = " & Num_Transferencia & " )")
            Cx.DesConectar(Cx.sQlconexion)
            If Ajuste = "" Or Ajuste = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Id_Transferencia") Then
            Else
                MsgBox("Ya existe una Transferencia de cuenta con este número", MsgBoxStyle.Information)
                txtNumTransf.Focus()
                Return False
            End If
        Catch ex As Exception
            MsgBox("Número de transferencia invalido", MsgBoxStyle.Information)
            txtNumTransf.Focus()
            Return False
        End Try

        If txtDescripcion.Text.Length = 0 Then
            MsgBox("Debes Ingresar un motivo de la transferencia", MsgBoxStyle.Information)
            txtDescripcion.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub ValidarNumero()
        Try
            Dim Cx As New Conexion
            Dim Transferencia As String
            Dim Num_Transf As Integer = Me.txtNumTransf.Text
            Transferencia = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT Id_Transferencia FROM TransferenciasBancarias WHERE (Id_Cuenta_Origen = " & ComboCuentaOrigen.SelectedValue & " ) AND (Num_Transferencia = " & Me.txtNumTransf.Text & " )")
            Cx.DesConectar(Cx.sQlconexion)
            If Transferencia = "" Then
                Me.DateEdit1.Focus()
            Else
                MsgBox("Ya existe una transferencia con este número de esta cuenta con este numero")
                Me.txtNumTransf.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly)
        End Try
    End Sub
#End Region

#Region "Guardar"
    Function GuardarCabios() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.DaTransferencia.InsertCommand.Transaction = Trans
            Me.DaTransferencia.UpdateCommand.Transaction = Trans
            Me.DaTransferencia.Update(Me.DataSetTransferencia1.TransferenciasBancarias)
            Trans.Commit()
            '------------------------------------------------------------------
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
            '------------------------------------------------------------------

            Me.DataSetTransferencia1.AcceptChanges()
            MsgBox("Transferencia guardada satisfactoriamente", MsgBoxStyle.Information)
            If MessageBox.Show("Desea imprimir la transferencia?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Imprimir()
            End If

            'If desdeconciliacion Then
            If modificar Then
                If BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Id_Cuenta_Origen") = cuentabancaria Then
                    TransCredito = True
                    Me.nuevoMonto = CDbl(txtMontoOrigen.Text)
                Else
                    TransCredito = False
                    Me.nuevoMonto = CDbl(txtMontoDestino.Text)
                End If
            Else
            End If
            DialogResult = DialogResult.OK
            Close()
            Exit Function
            'End If

            Me.DataSetTransferencia1.Clear()
            Return True

        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
            MsgBox("Error al tratar de guardar los datos, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
            Return False
        End Try
    End Function

    Function Guardar()
        Dim Fx As New cFunciones
        Dim cConexion As New Conexion
        FechaConciliacion()

        If ValidarTransferencia() Then
            BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Moneda_Origen") = BindingContext(DataSetTransferencia1, "Cuentas_bancariasOrigen").Current("CodMoneda")
            BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Moneda_Destino") = BindingContext(DataSetTransferencia1, "Cuentas_bancariasDestino").Current("CodMoneda")
            If BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia2") = "0" Then
                BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia2") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia")
            End If
            Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").EndCurrentEdit()

            If DateEdit1.DateTime.Date <= FechaCon And Me.ToolBar1.Buttons(0).Text = "Cancelar" Then
                MsgBox("La Fecha de la Transferencia no es válida porque existe conciliación con fecha mayor, favor revisar")
            Else
                '------------------------------------------------------------------
                'VERIFICA EL PERIODO DE TRABAJO
                Conta = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "Select Contabilidad from bancos.dbo.Configuraciones")
                cConexion.DesConectar(cConexion.sQlconexion)
                If Conta = 1 Or Conta = 2 Then
                    If Fx.ValidarPeriodo(Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Fecha")) = False Then
                        MsgBox("La Fecha de la Trnasferencia No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar la Tranferencia", MsgBoxStyle.Information, "Sistema SeeSoft")
                        Exit Function
                    End If
                End If
                '------------------------------------------------------------------

                If desdeconciliacion Then
                    If modificar Then
                        If BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Id_Cuenta_Origen") <> cuentabancaria And BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Id_Cuenta_Destino") <> cuentabancaria Then
                            MsgBox("La cuenta bancaria a conciliar no esta seleccionada!" & vbCrLf & "No se puede Guardar la Tranferencia", MsgBoxStyle.Information, "Sistema SeeSoft")
                            Exit Function
                        End If
                    End If
                End If

                If Me.GuardarCabios() Then
                    Try
                        BanderaGeneral.ACTUALIZO_ASIENTO = True
                        BanderaGeneral.ACTUALIZO_ASIENTO2 = True
                        Me.InhabilitarTransferencia()
                        Me.ToolBar1.Buttons(0).Text = "Nuevo"
                        Me.ToolBar1.Buttons(0).ImageIndex = 0
                        ToolBarExcel.Text = "Editar"
                        ToolBarExcel.ImageIndex = 5
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarEliminar.Enabled = False
                        Me.ToolBarRegistrar.Enabled = False
                        Me.ToolBarImprimir.Enabled = False
                        Me.ToolBarEliminar.Enabled = False
                        Me.ToolBarExcel.Enabled = False
                        EditaAsiento = False

                        Me.DataSetTransferencia1.TransferenciasBancarias.Clear()
                        Me.Dadestino.Fill(Me.DataSetTransferencia1.Cuentas_bancariasDestino)
                        Me.DaOrigen.Fill(Me.DataSetTransferencia1.Cuentas_bancariasOrigen)
                    Catch ex As Exception
                    End Try
                End If
            End If
        End If
    End Function
#End Region

#Region "Nuevo"
    Function Nuevo()
        Dim fx As New cFunciones
        Anular.Visible = False

        If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
            Me.ToolBar1.Buttons(0).Text = "Cancelar"
            Me.ToolBar1.Buttons(0).ImageIndex = 8
            ToolBarExcel.Enabled = False
            Me.Anular.Visible = False
            EditaAsiento = False

            Try 'inicia la edicion
                Me.DataSetTransferencia1.Clear()
                Me.DataSetTransferencia1.TransferenciasBancarias.Clear()
                Me.Dadestino.Fill(Me.DataSetTransferencia1.Cuentas_bancariasDestino)
                Me.DaOrigen.Fill(Me.DataSetTransferencia1.Cuentas_bancariasOrigen)
                daUsuarios.Fill(DataSetTransferencia1.Usuarios)
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").CancelCurrentEdit()
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").EndCurrentEdit()
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").AddNew()
                Me.HabilitarTransferencia()
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Cambio()
                txtTipoCambio.Text = fx.TipoCambio(DateEdit1.DateTime, True)
                txtNumTransf.Focus()

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        Else
            Try
                'cambia la imagen a nuevo y habilita los botones del toolbar1
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").CancelCurrentEdit()
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").EndCurrentEdit()
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                Me.ToolBarEliminar.Enabled = False
                InhabilitarTransferencia()
                If Me.desdeconciliacion Then
                    DialogResult = DialogResult.Cancel
                    Me.Close()
                End If

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Function

    Function numero()
        Dim Cx As New Conexion
        Dim NumeroTrans As String
        NumeroTrans = Cx.SlqExecuteScalar(Cx.Conectar("Bancos"), "SELECT ISNULL(MAX(Num_Transferencia), 0) + 1  FROM TransferenciasBancarias ")
        Cx.DesConectar(Cx.sQlconexion)
        Me.txtNumTransf.Text = NumeroTrans
    End Function
#End Region

#Region "Editar"
    Function Editar()
        Try
            If ToolBarExcel.Text = "Editar" Then
                ToolBarExcel.Text = "Cancelar"
                ToolBarExcel.ImageIndex = 8

                If Anular.Visible = True Then
                    MsgBox("No se puede editar el depósito porque está anulado", MsgBoxStyle.Information, "Atención...")
                    ToolBarExcel.Text = "Editar"
                    ToolBarExcel.ImageIndex = 5
                    Exit Function
                End If

                If Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("Conciliado") = True Or Me.BindingContext(Me.DataSetTransferencia1, "TransferenciasBancarias").Current("ConciliadoDestino") = True Then
                    MsgBox("No es Posible Editar esta Transferencia ya que ha sido Conciliada !!!!", MsgBoxStyle.Information)
                    ToolBarExcel.Text = "Editar"
                    ToolBarExcel.ImageIndex = 5
                    Exit Function
                End If

                'If DataSetTransferencia1.AsientosContables.Count > 0 Then
                '    If BindingContext(DataSetTransferencia1, "AsientosContables").Current("Mayorizado") = True Then
                '        MsgBox("No se puede editar la Tranferencia porque el Asiento esta Mayorizado", MsgBoxStyle.Information, "Atención...")
                '        ToolBarExcel.Text = "Editar"
                '        ToolBarExcel.ImageIndex = 5
                '        Exit Function
                '    End If
                'End If

                Me.HabilitarTransferencia()
                Me.ToolBarNuevo.Enabled = False
                Me.ToolBarBuscar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarEliminar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                EditaAsiento = True
                txtMontoOrigen.Focus()

            Else
                ToolBarExcel.Text = "Editar"
                ToolBarExcel.ImageIndex = 5
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").CancelCurrentEdit()
                Me.BindingContext(DataSetTransferencia1, "TransferenciasBancarias").EndCurrentEdit()
                Me.InhabilitarTransferencia()
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarEliminar.Enabled = True
                Me.ToolBarImprimir.Enabled = True
                EditaAsiento = False
                If desdeconciliacion Then
                    DialogResult = DialogResult.Cancel
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            MsgBox("Error al tratar de editar la transferencia bancaria, Intente de nuevo, Si el problema persite, Comuniqueselo al administrador de sistema")
        End Try
    End Function
#End Region

#Region "Tab"
    Private Sub txtMontoOrigen_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoOrigen.TextChanged
        If Me.ToolBarNuevo.Text = "Cancelar" Or Me.ToolBarExcel.Text = "Cancelar" Then
            Cambio()
        End If
    End Sub

    Private Sub txtTipoCambio_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTipoCambio.TextChanged
        If Me.ToolBarNuevo.Text = "Cancelar" Or Me.ToolBarExcel.Text = "Cancelar" Then
            Cambio()
        End If
    End Sub

    Private Sub txtNumTransf_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumTransf.KeyDown
        If e.KeyCode = Keys.Enter Then
            ValidarNumero()
        End If
    End Sub

    Private Sub DateEdit1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateEdit1.KeyDown
        Dim fx As New cFunciones
        If e.KeyCode = Keys.Enter Then
            If DateEdit1.DateTime.Date > FechaCon Then
                txtTipoCambio.Text = fx.TipoCambio(DateEdit1.DateTime, True)
                txtTipoCambio.Focus()
            Else
                MsgBox("Fecha Incorrecta")
            End If
        End If
    End Sub

    Private Sub txtTipoCambio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtTipoCambio.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboCuentaOrigen.Focus()
        End If
    End Sub

    Private Sub ComboCuentaOrigen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboCuentaOrigen.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cambio()
            txtMontoOrigen.Focus()
        End If
    End Sub

    Private Sub txtMontoOrigen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoOrigen.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboCuentaDestino.Focus()
        End If
    End Sub

    Private Sub ComboCuentaDestino_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboCuentaDestino.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cambio()
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMontoOrigen.Focus()
        End If
    End Sub
#End Region

#Region "Validar Fecha Conciliacion"
    Function FechaConciliacion()
        Try
            Dim cConexion As New Conexion
            FechaCon = cConexion.SlqExecuteScalar(cConexion.Conectar("Bancos"), "SELECT ISNULL(MAX(Hasta),0) AS FechaMax FROM bancos.dbo.Conciliacion where Id_CuentaBancaria = " & ComboCuentaOrigen.SelectedValue & " or id_cuentabancaria = " & ComboCuentaDestino.SelectedValue)
            cConexion.DesConectar(cConexion.sQlconexion)
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly)
        End Try
    End Function
#End Region

#Region "Asientos Contables"
    Public Sub GuardaAsiento()
        Dim NumeroAsiento As String
        Dim Fx As New cFunciones
        Dim Funciones As New Conexion

        Try
            '------------------------------------------------------------------
            'CREA EL ASIENTO CONTABLE - ORA
            If EditaAsiento = False Then
                DataSetTransferencia1.AsientosContables.Clear()
                DataSetTransferencia1.DetallesAsientosContable.Clear()
                BindingContext(DataSetTransferencia1, "AsientosContables").CancelCurrentEdit()
                BindingContext(DataSetTransferencia1, "AsientosContables").AddNew()
                BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("BCO-" & Format(DateEdit1.DateTime.Month, "00") & Format(DateEdit1.DateTime, "yy") & "-")
            Else
                If BindingContext(DataSetTransferencia1, "AsientosContables").Count < 1 Then
                    DataSetTransferencia1.AsientosContables.Clear()
                    DataSetTransferencia1.DetallesAsientosContable.Clear()
                    BindingContext(DataSetTransferencia1, "AsientosContables").CancelCurrentEdit()
                    BindingContext(DataSetTransferencia1, "AsientosContables").AddNew()
                    BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("BCO-" & Format(DateEdit1.DateTime.Month, "00") & Format(DateEdit1.DateTime, "yy") & "-")
                Else
                    Funciones.DeleteRecords("DetallesAsientosContable", "NumAsiento ='" & BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumAsiento") & "'")
                End If
            End If

            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Fecha") = DateEdit1.DateTime
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("IdNumDoc") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Id_Transferencia")
            If BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia2") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia") Then
                BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumDoc") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia")
                BindingContext(DataSetTransferencia1, "AsientosContables").Current("Observaciones") = "Transferencia Bancaria # " & BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia")
            Else
                BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumDoc") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia") & "/" & BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia2")
                BindingContext(DataSetTransferencia1, "AsientosContables").Current("Observaciones") = "Transferencia Bancaria # " & BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia") & "/" & BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Num_Transferencia2")
            End If
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Beneficiario") = ""
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("TipoDoc") = 24
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Accion") = "AUT"
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Anulado") = 0
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("FechaEntrada") = Now.Date
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Mayorizado") = 1
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(DateEdit1.DateTime)
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumMayorizado") = 1
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("Modulo") = "Transferencias Bancarias"
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("NombreUsuario") = TxtNombreUsuario.Text
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("TotalDebe") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Monto_Origen")
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("TotalHaber") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Monto_Origen")
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("CodMoneda") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Moneda_Origen")
            BindingContext(DataSetTransferencia1, "AsientosContables").Current("TipoCambio") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("TipoCambio")
            BindingContext(DataSetTransferencia1, "AsientosContables").EndCurrentEdit()
            '------------------------------------------------------------------

            '------------------------------------------------------------------
            'GUARDA EL DETALLE PARA LA CUENTA ACREDITADA (DEBE)
            GuardaAsientoDetalle(BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Monto_Origen"), True, False, BindingContext(DataSetTransferencia1, "Cuentas_bancariasDestino").Current("CuentaContable"), BindingContext(DataSetTransferencia1, "Cuentas_bancariasDestino").Current("NombreCuentaContable"), BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Descripción"))
            '------------------------------------------------------------------

            '------------------------------------------------------------------
            'GUARDA EL DETALLE PARA LA CUENTA DEBITADA (HABER)
            GuardaAsientoDetalle(BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Monto_Origen"), False, True, BindingContext(DataSetTransferencia1, "Cuentas_bancariasOrigen").Current("CuentaContable"), BindingContext(DataSetTransferencia1, "Cuentas_bancariasOrigen").Current("NombreCuentaContable"), BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Descripción"))
            '------------------------------------------------------------------

            'ACTUALIZA EL NUMERO DE ASIENTO AL DEPOSITO
            Funciones.UpdateRecords("bancos.dbo.TransferenciasBancarias", "Contabilizado = 1, Num_Asiento = '" & BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumAsiento") & "'", "Id_Transferencia = " & BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("Id_Transferencia"), "Bancos")
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
   

    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String, ByVal Descripcion As String)
        If Monto <> 0 Then  'CREA LOS DETALLES DE ASIENTOS CONTABLES
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DataSetTransferencia1, "AsientosContables").Current("NumAsiento")
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = Descripcion
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = BindingContext(DataSetTransferencia1, "TransferenciasBancarias").Current("TipoCambio")

            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        End If
    End Sub


    Function TransAsiento() As Boolean  'REALIZA LA TRANSACCIÓN DE LOS ASIENTOS CONTABLES
        If SqlConnection2.State <> SqlConnection2.State.Open Then SqlConnection2.Open()
        Dim TransConta As SqlTransaction = Me.SqlConnection2.BeginTransaction

        Try
            BindingContext(DataSetTransferencia1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DataSetTransferencia1, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = TransConta
            AdapterDetallesAsientos.DeleteCommand.Transaction = TransConta
            AdapterDetallesAsientos.InsertCommand.Transaction = TransConta

            AdapterAsientos.UpdateCommand.Transaction = TransConta
            AdapterAsientos.DeleteCommand.Transaction = TransConta
            AdapterAsientos.InsertCommand.Transaction = TransConta

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterDetallesAsientos.Update(DataSetTransferencia1.DetallesAsientosContable)
            AdapterAsientos.Update(DataSetTransferencia1.AsientosContables)
            '-----------------------------------------------------------------------------------
            TransConta.Commit()
            Return True

        Catch ex As Exception
            TransConta.Rollback()
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
            Dim sel As String = "Select * From AsientosContables WHERE IdNumDoc = " & Id & " AND Modulo = 'Transferencias Bancarias'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            DataSetTransferencia1.DetallesAsientosContable.Clear()
            DataSetTransferencia1.AsientosContables.Clear()
            da.Fill(DataSetTransferencia1.AsientosContables)
            If DataSetTransferencia1.AsientosContables.Count < 1 Then
                DataSetTransferencia1.AsientosContables.Clear()
                Exit Function
            End If
            EditaAsiento = True

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function
#End Region

    Private Sub txtMontoOrigen_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoOrigen.EditValueChanged

    End Sub
End Class
