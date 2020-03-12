Imports System.Data.SqlClient
Imports Utilidades
Public Class FrmSettingCuentaContable
    Inherits Plantilla

    Dim caso As Integer 'sirve para indicar en cual textBox esta posisionado el cursor del teclado
    Dim idCuentaContable(11) As Integer ' saber los ids de las cuentas que seran guardadas en la tabla de contabilidad
    Dim usua As Object
    Dim NombreUsuario As String

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionInventario As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoInventario As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionTarjetaCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoTarjetaCredito As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionValorTransito As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoValorTransito As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoEfectivo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionImpuestoVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoImpuestoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents erpProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtDescripcionCompraExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCompraExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionCompraGrabado As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCompraGrabado As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionVentaExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoVentaExcento As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionVentaGrabada As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoVentaGrabada As System.Windows.Forms.TextBox
    Friend WithEvents tabCuentas As System.Windows.Forms.TabControl
    Friend WithEvents tabpageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents tabpageVenta As System.Windows.Forms.TabPage
    Friend WithEvents tabpageCompra As System.Windows.Forms.TabPage
    Friend WithEvents txtDescripcionCostoVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCostoVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionCuentaPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCuentaPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionCuentaCobrar As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigoCuentaCobrar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmSettingCuentaContable))
        Me.tabCuentas = New System.Windows.Forms.TabControl
        Me.tabpageGeneral = New System.Windows.Forms.TabPage
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDescripcionInventario = New System.Windows.Forms.TextBox
        Me.txtCodigoInventario = New System.Windows.Forms.TextBox
        Me.txtDescripcionTarjetaCredito = New System.Windows.Forms.TextBox
        Me.txtCodigoTarjetaCredito = New System.Windows.Forms.TextBox
        Me.txtDescripcionValorTransito = New System.Windows.Forms.TextBox
        Me.txtCodigoValorTransito = New System.Windows.Forms.TextBox
        Me.txtDescripcionEfectivo = New System.Windows.Forms.TextBox
        Me.txtCodigoEfectivo = New System.Windows.Forms.TextBox
        Me.txtDescripcionImpuestoVenta = New System.Windows.Forms.TextBox
        Me.txtCodigoImpuestoVenta = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.tabpageVenta = New System.Windows.Forms.TabPage
        Me.txtDescripcionCuentaCobrar = New System.Windows.Forms.TextBox
        Me.txtCodigoCuentaCobrar = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDescripcionCostoVenta = New System.Windows.Forms.TextBox
        Me.txtCodigoCostoVenta = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDescripcionVentaExcento = New System.Windows.Forms.TextBox
        Me.txtCodigoVentaExcento = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtDescripcionVentaGrabada = New System.Windows.Forms.TextBox
        Me.txtCodigoVentaGrabada = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.tabpageCompra = New System.Windows.Forms.TabPage
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDescripcionCuentaPagar = New System.Windows.Forms.TextBox
        Me.txtCodigoCuentaPagar = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDescripcionCompraExcento = New System.Windows.Forms.TextBox
        Me.txtCodigoCompraExcento = New System.Windows.Forms.TextBox
        Me.txtDescripcionCompraGrabado = New System.Windows.Forms.TextBox
        Me.txtCodigoCompraGrabado = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.erpProvider = New System.Windows.Forms.ErrorProvider
        Me.tabCuentas.SuspendLayout()
        Me.tabpageGeneral.SuspendLayout()
        Me.tabpageVenta.SuspendLayout()
        Me.tabpageCompra.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 344)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(778, 56)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Text = "Setting de cuenta contable Lcpymes"
        '
        
        '
        'tabCuentas
        '
        Me.tabCuentas.Controls.Add(Me.tabpageGeneral)
        Me.tabCuentas.Controls.Add(Me.tabpageVenta)
        Me.tabCuentas.Controls.Add(Me.tabpageCompra)
        Me.tabCuentas.Location = New System.Drawing.Point(32, 48)
        Me.tabCuentas.Name = "tabCuentas"
        Me.tabCuentas.SelectedIndex = 0
        Me.tabCuentas.Size = New System.Drawing.Size(704, 248)
        Me.tabCuentas.TabIndex = 71
        '
        'tabpageGeneral
        '
        Me.tabpageGeneral.Controls.Add(Me.Label9)
        Me.tabpageGeneral.Controls.Add(Me.txtDescripcionInventario)
        Me.tabpageGeneral.Controls.Add(Me.txtCodigoInventario)
        Me.tabpageGeneral.Controls.Add(Me.txtDescripcionTarjetaCredito)
        Me.tabpageGeneral.Controls.Add(Me.txtCodigoTarjetaCredito)
        Me.tabpageGeneral.Controls.Add(Me.txtDescripcionValorTransito)
        Me.tabpageGeneral.Controls.Add(Me.txtCodigoValorTransito)
        Me.tabpageGeneral.Controls.Add(Me.txtDescripcionEfectivo)
        Me.tabpageGeneral.Controls.Add(Me.txtCodigoEfectivo)
        Me.tabpageGeneral.Controls.Add(Me.txtDescripcionImpuestoVenta)
        Me.tabpageGeneral.Controls.Add(Me.txtCodigoImpuestoVenta)
        Me.tabpageGeneral.Controls.Add(Me.Label11)
        Me.tabpageGeneral.Controls.Add(Me.Label14)
        Me.tabpageGeneral.Controls.Add(Me.Label15)
        Me.tabpageGeneral.Controls.Add(Me.Label16)
        Me.tabpageGeneral.Controls.Add(Me.Label1)
        Me.tabpageGeneral.Controls.Add(Me.Label22)
        Me.tabpageGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabpageGeneral.Name = "tabpageGeneral"
        Me.tabpageGeneral.Size = New System.Drawing.Size(696, 222)
        Me.tabpageGeneral.TabIndex = 0
        Me.tabpageGeneral.Text = "General"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(24, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(144, 14)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Impuesto venta:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionInventario
        '
        Me.txtDescripcionInventario.AutoSize = False
        Me.txtDescripcionInventario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionInventario.Enabled = False
        Me.txtDescripcionInventario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionInventario.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionInventario.Location = New System.Drawing.Point(352, 168)
        Me.txtDescripcionInventario.Name = "txtDescripcionInventario"
        Me.txtDescripcionInventario.ReadOnly = True
        Me.txtDescripcionInventario.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionInventario.TabIndex = 128
        Me.txtDescripcionInventario.Text = ""
        '
        'txtCodigoInventario
        '
        Me.txtCodigoInventario.AutoSize = False
        Me.txtCodigoInventario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoInventario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoInventario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoInventario.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoInventario.Location = New System.Drawing.Point(176, 168)
        Me.txtCodigoInventario.Name = "txtCodigoInventario"
        Me.txtCodigoInventario.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoInventario.TabIndex = 127
        Me.txtCodigoInventario.Text = ""
        '
        'txtDescripcionTarjetaCredito
        '
        Me.txtDescripcionTarjetaCredito.AutoSize = False
        Me.txtDescripcionTarjetaCredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionTarjetaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionTarjetaCredito.Enabled = False
        Me.txtDescripcionTarjetaCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionTarjetaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionTarjetaCredito.Location = New System.Drawing.Point(352, 136)
        Me.txtDescripcionTarjetaCredito.Name = "txtDescripcionTarjetaCredito"
        Me.txtDescripcionTarjetaCredito.ReadOnly = True
        Me.txtDescripcionTarjetaCredito.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionTarjetaCredito.TabIndex = 119
        Me.txtDescripcionTarjetaCredito.Text = ""
        '
        'txtCodigoTarjetaCredito
        '
        Me.txtCodigoTarjetaCredito.AutoSize = False
        Me.txtCodigoTarjetaCredito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoTarjetaCredito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoTarjetaCredito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTarjetaCredito.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoTarjetaCredito.Location = New System.Drawing.Point(176, 136)
        Me.txtCodigoTarjetaCredito.Name = "txtCodigoTarjetaCredito"
        Me.txtCodigoTarjetaCredito.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoTarjetaCredito.TabIndex = 112
        Me.txtCodigoTarjetaCredito.Text = ""
        '
        'txtDescripcionValorTransito
        '
        Me.txtDescripcionValorTransito.AutoSize = False
        Me.txtDescripcionValorTransito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionValorTransito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionValorTransito.Enabled = False
        Me.txtDescripcionValorTransito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionValorTransito.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionValorTransito.Location = New System.Drawing.Point(352, 104)
        Me.txtDescripcionValorTransito.Name = "txtDescripcionValorTransito"
        Me.txtDescripcionValorTransito.ReadOnly = True
        Me.txtDescripcionValorTransito.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionValorTransito.TabIndex = 117
        Me.txtDescripcionValorTransito.Text = ""
        '
        'txtCodigoValorTransito
        '
        Me.txtCodigoValorTransito.AutoSize = False
        Me.txtCodigoValorTransito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoValorTransito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoValorTransito.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoValorTransito.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoValorTransito.Location = New System.Drawing.Point(176, 104)
        Me.txtCodigoValorTransito.Name = "txtCodigoValorTransito"
        Me.txtCodigoValorTransito.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoValorTransito.TabIndex = 111
        Me.txtCodigoValorTransito.Text = "5"
        '
        'txtDescripcionEfectivo
        '
        Me.txtDescripcionEfectivo.AutoSize = False
        Me.txtDescripcionEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionEfectivo.Enabled = False
        Me.txtDescripcionEfectivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionEfectivo.Location = New System.Drawing.Point(352, 72)
        Me.txtDescripcionEfectivo.Name = "txtDescripcionEfectivo"
        Me.txtDescripcionEfectivo.ReadOnly = True
        Me.txtDescripcionEfectivo.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionEfectivo.TabIndex = 116
        Me.txtDescripcionEfectivo.Text = ""
        '
        'txtCodigoEfectivo
        '
        Me.txtCodigoEfectivo.AutoSize = False
        Me.txtCodigoEfectivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoEfectivo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoEfectivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoEfectivo.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoEfectivo.Location = New System.Drawing.Point(176, 72)
        Me.txtCodigoEfectivo.Name = "txtCodigoEfectivo"
        Me.txtCodigoEfectivo.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoEfectivo.TabIndex = 110
        Me.txtCodigoEfectivo.Text = "4"
        '
        'txtDescripcionImpuestoVenta
        '
        Me.txtDescripcionImpuestoVenta.AutoSize = False
        Me.txtDescripcionImpuestoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionImpuestoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionImpuestoVenta.Enabled = False
        Me.txtDescripcionImpuestoVenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionImpuestoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionImpuestoVenta.Location = New System.Drawing.Point(352, 40)
        Me.txtDescripcionImpuestoVenta.Name = "txtDescripcionImpuestoVenta"
        Me.txtDescripcionImpuestoVenta.ReadOnly = True
        Me.txtDescripcionImpuestoVenta.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionImpuestoVenta.TabIndex = 115
        Me.txtDescripcionImpuestoVenta.Text = ""
        '
        'txtCodigoImpuestoVenta
        '
        Me.txtCodigoImpuestoVenta.AutoSize = False
        Me.txtCodigoImpuestoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoImpuestoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoImpuestoVenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoImpuestoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoImpuestoVenta.Location = New System.Drawing.Point(176, 40)
        Me.txtCodigoImpuestoVenta.Name = "txtCodigoImpuestoVenta"
        Me.txtCodigoImpuestoVenta.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoImpuestoVenta.TabIndex = 109
        Me.txtCodigoImpuestoVenta.Text = ""
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(24, 168)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 14)
        Me.Label11.TabIndex = 131
        Me.Label11.Text = "Inventario:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(24, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(144, 14)
        Me.Label14.TabIndex = 124
        Me.Label14.Text = "Tarjeta crédito:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(24, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(144, 14)
        Me.Label15.TabIndex = 123
        Me.Label15.Text = "Valores transito:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(24, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(144, 14)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "Efectivo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(352, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 14)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Descripción cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(176, 8)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(168, 14)
        Me.Label22.TabIndex = 87
        Me.Label22.Text = "Código cuenta"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabpageVenta
        '
        Me.tabpageVenta.Controls.Add(Me.txtDescripcionCuentaCobrar)
        Me.tabpageVenta.Controls.Add(Me.txtCodigoCuentaCobrar)
        Me.tabpageVenta.Controls.Add(Me.Label13)
        Me.tabpageVenta.Controls.Add(Me.txtDescripcionCostoVenta)
        Me.tabpageVenta.Controls.Add(Me.txtCodigoCostoVenta)
        Me.tabpageVenta.Controls.Add(Me.Label12)
        Me.tabpageVenta.Controls.Add(Me.Label4)
        Me.tabpageVenta.Controls.Add(Me.txtDescripcionVentaExcento)
        Me.tabpageVenta.Controls.Add(Me.txtCodigoVentaExcento)
        Me.tabpageVenta.Controls.Add(Me.Label25)
        Me.tabpageVenta.Controls.Add(Me.txtDescripcionVentaGrabada)
        Me.tabpageVenta.Controls.Add(Me.txtCodigoVentaGrabada)
        Me.tabpageVenta.Controls.Add(Me.Label26)
        Me.tabpageVenta.Controls.Add(Me.Label27)
        Me.tabpageVenta.Location = New System.Drawing.Point(4, 22)
        Me.tabpageVenta.Name = "tabpageVenta"
        Me.tabpageVenta.Size = New System.Drawing.Size(696, 222)
        Me.tabpageVenta.TabIndex = 1
        Me.tabpageVenta.Text = "Ventas"
        '
        'txtDescripcionCuentaCobrar
        '
        Me.txtDescripcionCuentaCobrar.AutoSize = False
        Me.txtDescripcionCuentaCobrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCuentaCobrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCuentaCobrar.Enabled = False
        Me.txtDescripcionCuentaCobrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCuentaCobrar.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionCuentaCobrar.Location = New System.Drawing.Point(352, 136)
        Me.txtDescripcionCuentaCobrar.Name = "txtDescripcionCuentaCobrar"
        Me.txtDescripcionCuentaCobrar.ReadOnly = True
        Me.txtDescripcionCuentaCobrar.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionCuentaCobrar.TabIndex = 154
        Me.txtDescripcionCuentaCobrar.Text = ""
        '
        'txtCodigoCuentaCobrar
        '
        Me.txtCodigoCuentaCobrar.AutoSize = False
        Me.txtCodigoCuentaCobrar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCuentaCobrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCuentaCobrar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCuentaCobrar.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoCuentaCobrar.Location = New System.Drawing.Point(176, 136)
        Me.txtCodigoCuentaCobrar.Name = "txtCodigoCuentaCobrar"
        Me.txtCodigoCuentaCobrar.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoCuentaCobrar.TabIndex = 153
        Me.txtCodigoCuentaCobrar.Text = ""
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(24, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 14)
        Me.Label13.TabIndex = 155
        Me.Label13.Text = "Cuentas por cobrar:"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionCostoVenta
        '
        Me.txtDescripcionCostoVenta.AutoSize = False
        Me.txtDescripcionCostoVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCostoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCostoVenta.Enabled = False
        Me.txtDescripcionCostoVenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCostoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionCostoVenta.Location = New System.Drawing.Point(352, 104)
        Me.txtDescripcionCostoVenta.Name = "txtDescripcionCostoVenta"
        Me.txtDescripcionCostoVenta.ReadOnly = True
        Me.txtDescripcionCostoVenta.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionCostoVenta.TabIndex = 151
        Me.txtDescripcionCostoVenta.Text = ""
        '
        'txtCodigoCostoVenta
        '
        Me.txtCodigoCostoVenta.AutoSize = False
        Me.txtCodigoCostoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCostoVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCostoVenta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCostoVenta.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoCostoVenta.Location = New System.Drawing.Point(176, 104)
        Me.txtCodigoCostoVenta.Name = "txtCodigoCostoVenta"
        Me.txtCodigoCostoVenta.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoCostoVenta.TabIndex = 150
        Me.txtCodigoCostoVenta.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(24, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 14)
        Me.Label12.TabIndex = 152
        Me.Label12.Text = "Costo venta:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 14)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Venta Excento:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionVentaExcento
        '
        Me.txtDescripcionVentaExcento.AutoSize = False
        Me.txtDescripcionVentaExcento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionVentaExcento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionVentaExcento.Enabled = False
        Me.txtDescripcionVentaExcento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionVentaExcento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionVentaExcento.Location = New System.Drawing.Point(352, 72)
        Me.txtDescripcionVentaExcento.Name = "txtDescripcionVentaExcento"
        Me.txtDescripcionVentaExcento.ReadOnly = True
        Me.txtDescripcionVentaExcento.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionVentaExcento.TabIndex = 143
        Me.txtDescripcionVentaExcento.Text = ""
        '
        'txtCodigoVentaExcento
        '
        Me.txtCodigoVentaExcento.AutoSize = False
        Me.txtCodigoVentaExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoVentaExcento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoVentaExcento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoVentaExcento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoVentaExcento.Location = New System.Drawing.Point(176, 72)
        Me.txtCodigoVentaExcento.Name = "txtCodigoVentaExcento"
        Me.txtCodigoVentaExcento.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoVentaExcento.TabIndex = 137
        Me.txtCodigoVentaExcento.Text = ""
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(24, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(144, 14)
        Me.Label25.TabIndex = 136
        Me.Label25.Text = "Venta grabada:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionVentaGrabada
        '
        Me.txtDescripcionVentaGrabada.AutoSize = False
        Me.txtDescripcionVentaGrabada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionVentaGrabada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionVentaGrabada.Enabled = False
        Me.txtDescripcionVentaGrabada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionVentaGrabada.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionVentaGrabada.Location = New System.Drawing.Point(352, 40)
        Me.txtDescripcionVentaGrabada.Name = "txtDescripcionVentaGrabada"
        Me.txtDescripcionVentaGrabada.ReadOnly = True
        Me.txtDescripcionVentaGrabada.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionVentaGrabada.TabIndex = 135
        Me.txtDescripcionVentaGrabada.Text = ""
        '
        'txtCodigoVentaGrabada
        '
        Me.txtCodigoVentaGrabada.AutoSize = False
        Me.txtCodigoVentaGrabada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoVentaGrabada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoVentaGrabada.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoVentaGrabada.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoVentaGrabada.Location = New System.Drawing.Point(176, 40)
        Me.txtCodigoVentaGrabada.Name = "txtCodigoVentaGrabada"
        Me.txtCodigoVentaGrabada.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoVentaGrabada.TabIndex = 132
        Me.txtCodigoVentaGrabada.Text = ""
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(352, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(292, 14)
        Me.Label26.TabIndex = 134
        Me.Label26.Text = "Descripción cuenta"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(176, 8)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(168, 14)
        Me.Label27.TabIndex = 133
        Me.Label27.Text = "Código cuenta"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tabpageCompra
        '
        Me.tabpageCompra.Controls.Add(Me.Label6)
        Me.tabpageCompra.Controls.Add(Me.txtDescripcionCuentaPagar)
        Me.tabpageCompra.Controls.Add(Me.txtCodigoCuentaPagar)
        Me.tabpageCompra.Controls.Add(Me.Label7)
        Me.tabpageCompra.Controls.Add(Me.Label8)
        Me.tabpageCompra.Controls.Add(Me.txtDescripcionCompraExcento)
        Me.tabpageCompra.Controls.Add(Me.txtCodigoCompraExcento)
        Me.tabpageCompra.Controls.Add(Me.txtDescripcionCompraGrabado)
        Me.tabpageCompra.Controls.Add(Me.txtCodigoCompraGrabado)
        Me.tabpageCompra.Controls.Add(Me.Label28)
        Me.tabpageCompra.Controls.Add(Me.Label29)
        Me.tabpageCompra.Location = New System.Drawing.Point(4, 22)
        Me.tabpageCompra.Name = "tabpageCompra"
        Me.tabpageCompra.Size = New System.Drawing.Size(696, 222)
        Me.tabpageCompra.TabIndex = 2
        Me.tabpageCompra.Text = "Compras"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 14)
        Me.Label6.TabIndex = 147
        Me.Label6.Text = "Cuenta por pagar:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionCuentaPagar
        '
        Me.txtDescripcionCuentaPagar.AutoSize = False
        Me.txtDescripcionCuentaPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCuentaPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCuentaPagar.Enabled = False
        Me.txtDescripcionCuentaPagar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCuentaPagar.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionCuentaPagar.Location = New System.Drawing.Point(352, 104)
        Me.txtDescripcionCuentaPagar.Name = "txtDescripcionCuentaPagar"
        Me.txtDescripcionCuentaPagar.ReadOnly = True
        Me.txtDescripcionCuentaPagar.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionCuentaPagar.TabIndex = 146
        Me.txtDescripcionCuentaPagar.Text = ""
        '
        'txtCodigoCuentaPagar
        '
        Me.txtCodigoCuentaPagar.AutoSize = False
        Me.txtCodigoCuentaPagar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCuentaPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCuentaPagar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCuentaPagar.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoCuentaPagar.Location = New System.Drawing.Point(176, 104)
        Me.txtCodigoCuentaPagar.Name = "txtCodigoCuentaPagar"
        Me.txtCodigoCuentaPagar.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoCuentaPagar.TabIndex = 145
        Me.txtCodigoCuentaPagar.Text = "4"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(24, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 14)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "Compra Excento:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 14)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Compra grabada:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcionCompraExcento
        '
        Me.txtDescripcionCompraExcento.AutoSize = False
        Me.txtDescripcionCompraExcento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCompraExcento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCompraExcento.Enabled = False
        Me.txtDescripcionCompraExcento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCompraExcento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionCompraExcento.Location = New System.Drawing.Point(352, 72)
        Me.txtDescripcionCompraExcento.Name = "txtDescripcionCompraExcento"
        Me.txtDescripcionCompraExcento.ReadOnly = True
        Me.txtDescripcionCompraExcento.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionCompraExcento.TabIndex = 137
        Me.txtDescripcionCompraExcento.Text = ""
        '
        'txtCodigoCompraExcento
        '
        Me.txtCodigoCompraExcento.AutoSize = False
        Me.txtCodigoCompraExcento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCompraExcento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCompraExcento.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCompraExcento.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoCompraExcento.Location = New System.Drawing.Point(176, 72)
        Me.txtCodigoCompraExcento.Name = "txtCodigoCompraExcento"
        Me.txtCodigoCompraExcento.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoCompraExcento.TabIndex = 132
        Me.txtCodigoCompraExcento.Text = ""
        '
        'txtDescripcionCompraGrabado
        '
        Me.txtDescripcionCompraGrabado.AutoSize = False
        Me.txtDescripcionCompraGrabado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcionCompraGrabado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcionCompraGrabado.Enabled = False
        Me.txtDescripcionCompraGrabado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCompraGrabado.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcionCompraGrabado.Location = New System.Drawing.Point(352, 40)
        Me.txtDescripcionCompraGrabado.Name = "txtDescripcionCompraGrabado"
        Me.txtDescripcionCompraGrabado.ReadOnly = True
        Me.txtDescripcionCompraGrabado.Size = New System.Drawing.Size(292, 14)
        Me.txtDescripcionCompraGrabado.TabIndex = 136
        Me.txtDescripcionCompraGrabado.Text = ""
        '
        'txtCodigoCompraGrabado
        '
        Me.txtCodigoCompraGrabado.AutoSize = False
        Me.txtCodigoCompraGrabado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCodigoCompraGrabado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigoCompraGrabado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoCompraGrabado.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtCodigoCompraGrabado.Location = New System.Drawing.Point(176, 40)
        Me.txtCodigoCompraGrabado.Name = "txtCodigoCompraGrabado"
        Me.txtCodigoCompraGrabado.Size = New System.Drawing.Size(168, 14)
        Me.txtCodigoCompraGrabado.TabIndex = 131
        Me.txtCodigoCompraGrabado.Text = ""
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(352, 8)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(292, 14)
        Me.Label28.TabIndex = 135
        Me.Label28.Text = "Descripción cuenta"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(176, 8)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(168, 14)
        Me.Label29.TabIndex = 134
        Me.Label29.Text = "Código cuenta"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(112, 320)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 104
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(32, 320)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(112, 304)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(192, 14)
        Me.Label17.TabIndex = 105
        Me.Label17.Text = "Usuario"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(32, 304)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 14)
        Me.Label18.TabIndex = 103
        Me.Label18.Text = "Clave"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'erpProvider
        '
        Me.erpProvider.ContainerControl = Me
        '
        'FrmSettingCuentaContable
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(778, 400)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.tabCuentas)
        Me.Name = "FrmSettingCuentaContable"
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
        Me.tabpageVenta.ResumeLayout(False)
        Me.tabpageCompra.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones Gui"

    Private Sub fmrSettingCuentaFacturaVenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)

            Case 1 : If PMU.Find Then LlamarFmrBuscarAsientoVenta() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : If PMU.Update Then registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Me.Close()
        End Select
    End Sub

#Region "Funciones KeyDown"

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Loggin_Usuario() Then
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarBuscar.Enabled = True


                Me.tabCuentas.Focus()
            End If
        End If
    End Sub

    Private Sub txtCodigoImpuestoVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoImpuestoVenta.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If

        If e.KeyCode = Keys.Enter Then

            If txtCodigoImpuestoVenta.Text.Length = 0 Then
                Me.txtDescripcionImpuestoVenta.Text = ""

                Exit Sub
            End If
            If Buscar(txtCodigoImpuestoVenta.Text) = False Then
                Me.txtCodigoImpuestoVenta.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoEfectivo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoEfectivo.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoEfectivo.Text.Length = 0 Then
                Me.txtDescripcionEfectivo.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoEfectivo.Text) = False Then
                Me.txtCodigoEfectivo.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoValorTransito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoValorTransito.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoValorTransito.Text.Length = 0 Then
                Me.txtDescripcionValorTransito.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoValorTransito.Text) = False Then
                Me.txtCodigoValorTransito.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoTarjetaCredito_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoTarjetaCredito.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoTarjetaCredito.Text.Length = 0 Then
                Me.txtDescripcionTarjetaCredito.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoTarjetaCredito.Text) = False Then
                Me.txtCodigoTarjetaCredito.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoInventario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoInventario.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoInventario.Text.Length = 0 Then
                Me.txtDescripcionInventario.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoInventario.Text) = False Then
                Me.txtCodigoInventario.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoVentaGrabada_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoVentaGrabada.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoVentaGrabada.Text.Length = 0 Then
                Me.txtDescripcionVentaGrabada.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoVentaGrabada.Text) = False Then
                Me.txtCodigoVentaGrabada.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoVentaExcento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoVentaExcento.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoVentaExcento.Text.Length = 0 Then
                Me.txtDescripcionVentaExcento.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoVentaExcento.Text) = False Then
                Me.txtCodigoVentaExcento.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoCostoVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCostoVenta.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoCostoVenta.Text.Length = 0 Then
                Me.txtDescripcionCostoVenta.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoCostoVenta.Text) = False Then
                Me.txtCodigoCostoVenta.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoCuentaCobrar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCuentaCobrar.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoCuentaCobrar.Text.Length = 0 Then
                Me.txtDescripcionCuentaCobrar.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoCuentaCobrar.Text) = False Then
                Me.txtCodigoCuentaCobrar.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoCompraGrabado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCompraGrabado.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoCompraGrabado.Text.Length = 0 Then
                Me.txtDescripcionCompraGrabado.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoCompraGrabado.Text) = False Then
                Me.txtCodigoCompraGrabado.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoCompraExcento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCompraExcento.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoCompraExcento.Text.Length = 0 Then
                Me.txtDescripcionCompraExcento.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoCompraExcento.Text) = False Then
                Me.txtCodigoCompraExcento.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCodigoCuentaPagar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigoCuentaPagar.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then

            If txtCodigoCuentaPagar.Text.Length = 0 Then
                Me.txtDescripcionCuentaPagar.Text = ""
                Exit Sub
            End If
            If Buscar(txtCodigoCuentaPagar.Text) = False Then
                Me.txtCodigoCuentaPagar.Focus()
            End If
            caso = -1
            SendKeys.Send("{TAB}")
        End If
    End Sub


#End Region

#Region "Funciones GotFocus"

    Private Sub txtCodigoImpuestoVenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoImpuestoVenta.GotFocus
        caso = 0
    End Sub

    Private Sub txtCodigoEfectivo_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoEfectivo.GotFocus
        caso = 1
    End Sub

    Private Sub txtCodigoValorTransito_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoValorTransito.GotFocus
        caso = 2
    End Sub

    Private Sub txtCodigoTarjetaCredito_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoTarjetaCredito.GotFocus
        caso = 3
    End Sub
    Private Sub txtCodigoInventario_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoInventario.GotFocus
        caso = 4
    End Sub
    Private Sub txtCodigoVentaGrabada_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoVentaGrabada.GotFocus
        caso = 5
    End Sub
    Private Sub txtCodigoVentaExcento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoVentaExcento.GotFocus
        caso = 6
    End Sub
    Private Sub txtCodigoCostoVenta_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCostoVenta.GotFocus
        caso = 7
    End Sub
    Private Sub txtCodigoCuentaCobrar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCuentaCobrar.GotFocus
        caso = 8
    End Sub
    Private Sub txtCodigoCompraGrabado_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCompraGrabado.GotFocus
        caso = 9
    End Sub
    Private Sub txtCodigoCompraExcento_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCompraExcento.GotFocus
        caso = 10
    End Sub
    Private Sub txtCodigoCuentaPagar_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCuentaPagar.GotFocus
        caso = 11
    End Sub
#End Region

#Region "Funciones LostFocus"
  
    Private Sub txtCodigoImpuestoVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoImpuestoVenta.LostFocus
        caso = -1
        If txtCodigoImpuestoVenta.Text.Length = 0 Then
            Me.txtDescripcionImpuestoVenta.Text = ""

            Exit Sub
        End If
        If Buscar(txtCodigoImpuestoVenta.Text) = False Then
            Me.txtCodigoImpuestoVenta.Focus()
        End If
    End Sub
    Private Sub txtCodigoEfectivo_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoEfectivo.LostFocus
        caso = -1
        If txtCodigoEfectivo.Text.Length = 0 Then
            Me.txtDescripcionEfectivo.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoEfectivo.Text) = False Then
            Me.txtCodigoEfectivo.Focus()
        End If
    End Sub
    Private Sub txtCodigoValorTransito_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoValorTransito.LostFocus
        caso = -1
        If txtCodigoValorTransito.Text.Length = 0 Then
            Me.txtDescripcionValorTransito.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoValorTransito.Text) = False Then
            Me.txtCodigoValorTransito.Focus()
        End If
    End Sub
    Private Sub txtCodigoTarjetaCredito_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoTarjetaCredito.LostFocus
        caso = -1
        If txtCodigoTarjetaCredito.Text.Length = 0 Then
            Me.txtDescripcionTarjetaCredito.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoTarjetaCredito.Text) = False Then
            Me.txtCodigoTarjetaCredito.Focus()
        End If
    End Sub
    Private Sub txtCodigoInventario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoInventario.LostFocus
        caso = -1
        If txtCodigoInventario.Text.Length = 0 Then
            Me.txtDescripcionInventario.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoInventario.Text) = False Then
            Me.txtCodigoInventario.Focus()
        End If
    End Sub
    Private Sub txtCodigoVentaGrabada_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoVentaGrabada.LostFocus
        caso = -1
        If txtCodigoVentaGrabada.Text.Length = 0 Then
            Me.txtDescripcionVentaGrabada.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoVentaGrabada.Text) = False Then
            Me.txtCodigoVentaGrabada.Focus()
        End If
    End Sub
    Private Sub txtCodigoVentaExcento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoVentaExcento.LostFocus
        caso = -1
        If txtCodigoVentaExcento.Text.Length = 0 Then
            Me.txtDescripcionVentaExcento.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoVentaExcento.Text) = False Then
            Me.txtCodigoVentaExcento.Focus()
        End If
    End Sub
    Private Sub txtCodigoCostoVenta_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCostoVenta.LostFocus
        caso = -1
        If txtCodigoCostoVenta.Text.Length = 0 Then
            Me.txtDescripcionCostoVenta.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoCostoVenta.Text) = False Then
            Me.txtCodigoCostoVenta.Focus()
        End If
    End Sub
    Private Sub txtCodigoCuentaCobrar_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCuentaCobrar.LostFocus
        caso = -1
        If txtCodigoCuentaCobrar.Text.Length = 0 Then
            Me.txtDescripcionCuentaCobrar.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoCuentaCobrar.Text) = False Then
            Me.txtCodigoCuentaCobrar.Focus()
        End If
    End Sub
    Private Sub txtCodigoCompraGrabado_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCompraGrabado.LostFocus
        caso = -1
        If txtCodigoCompraGrabado.Text.Length = 0 Then
            Me.txtDescripcionCompraGrabado.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoCompraGrabado.Text) = False Then
            Me.txtCodigoCompraGrabado.Focus()
        End If
    End Sub
    Private Sub txtCodigoCompraExcento_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCodigoCompraExcento.LostFocus
        caso = -1
        If txtCodigoCompraExcento.Text.Length = 0 Then
            Me.txtDescripcionCompraExcento.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoCompraExcento.Text) = False Then
            Me.txtCodigoCompraExcento.Focus()
        End If
    End Sub
    Private Sub txtCodigoCuentaPagar_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoCuentaPagar.LostFocus
        caso = -1
        If txtCodigoCuentaPagar.Text.Length = 0 Then
            Me.txtDescripcionCuentaPagar.Text = ""
            Exit Sub
        End If
        If Buscar(txtCodigoCuentaPagar.Text) = False Then
            Me.txtCodigoCuentaPagar.Focus()
        End If
    End Sub
#End Region

#End Region

#Region "Funciones Basicas"

    Private Sub LlamarFmrBuscarAsientoVenta()

        If caso = -1 Then
            MsgBox("Selecione el campo donde quiere ingresar la cuenta")
            Exit Sub
        End If

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1 " ' "select CuentaContable AS [Codigo cuenta],descripcion as Descripcion from Contabilidad.dbo.CuentaContable where  Movimiento = 1  "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub


        llenarTextBox(busca.codigo, busca.descrip, 0, caso)

        SendKeys.Send("{TAB}")

    End Sub

    Private Function Buscar(ByVal pCodigoCuenta As String, Optional ByVal pCaso As Integer = -1) As Boolean

        If pCodigoCuenta.Length = 0 Then Exit Function
        If pCaso = -1 Then pCaso = caso

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT Id,descripcion  FROM CuentaContable WHERE CuentaContable ='" & pCodigoCuenta & "'"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader Is Nothing Then
            llenarTextBox("", "", 0, pCaso)
            MsgBox("No existe ese codigo de cuenta", MsgBoxStyle.Information)
            Exit Function
        End If

        If rstReader.Read = False Then
            llenarTextBox("", "", 0, pCaso)
            MsgBox("No existe ese codigo de cuenta", MsgBoxStyle.Information)
            Exit Function
        End If

        If rstReader.IsDBNull(0) Then
            llenarTextBox("", "", 0, pCaso)
            MsgBox("No existe ese codigo de cuenta", MsgBoxStyle.Information)
            Exit Function
        End If

        llenarTextBox(pCodigoCuenta, rstReader("Descripcion"), rstReader("Id"), pCaso)
        cnnConexion.Close()
        Buscar = True
    End Function

    Private Sub registrar()
        Me.Refresh()
        Me.tabCuentas.Refresh()
        Me.erpProvider.Dispose()

        Buscar(txtCodigoImpuestoVenta.Text, 0)
        Buscar(txtCodigoEfectivo.Text, 1)
        Buscar(txtCodigoValorTransito.Text, 2)
        Buscar(txtCodigoTarjetaCredito.Text, 3)
        Buscar(txtCodigoInventario.Text, 4)
        Buscar(txtCodigoVentaGrabada.Text, 5)
        Buscar(txtCodigoVentaExcento.Text, 6)
        Buscar(txtCodigoCostoVenta.Text, 7)
        Buscar(txtCodigoCuentaCobrar.Text, 8)
        Buscar(txtCodigoCompraGrabado.Text, 9)
        Buscar(txtCodigoCompraExcento.Text, 10)
        Buscar(txtCodigoCuentaPagar.Text, 11)

        If ValidarCampos() = False Then
            Exit Sub
        End If

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim sql As String = "delete from SettingCuentaContable"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()
        clsConexion.SlqExecute(cnnConexion, sql)


        sql = "INSERT INTO SettingCuentaContable " & _
                   " (IdImpuestoVenta,IdEfectivo,IdValorTransito,IdTarjetaCredito,IdInventario,IdVentaGrabado,IdVentaExcento,IdCostoVenta,IdCuentaCobrar,IdCompraGrabado,IdCompraExcento,IdCuentaPagar)" & _
                   " VALUES (" & idCuentaContable(0) & "," & idCuentaContable(1) & "," & idCuentaContable(2) & "," & idCuentaContable(3) & "," & idCuentaContable(4) & "," & idCuentaContable(5) & "," & idCuentaContable(6) & "," & idCuentaContable(7) & "," & idCuentaContable(8) & "," & idCuentaContable(9) & "," & idCuentaContable(10) & "," & idCuentaContable(11) & ")"

        clsConexion.SlqExecute(cnnConexion, sql)

        cnnConexion.Close()

        MsgBox("Los datos han sido registrados correctamente", MsgBoxStyle.Information)

        Me.erpProvider.Dispose()
    End Sub

    Private Sub Buscar()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim cnnConexion2 As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim rstReader2 As System.Data.SqlClient.SqlDataReader
        Dim n As Integer = 0
        Dim sql As String = "SELECT *  FROM SettingCuentaContable"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion2.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")

        cnnConexion.Open()
        cnnConexion2.Open()
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Sub


        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdImpuestoVenta")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdImpuestoVenta"), 0)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdEfectivo")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdEfectivo"), 1)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdValorTransito")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdValorTransito"), 2)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdTarjetaCredito")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdTarjetaCredito"), 3)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdInventario")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdInventario"), 4)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdVentaGrabado")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdVentaGrabado"), 5)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdVentaExcento")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdVentaExcento"), 6)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdCostoVenta")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdCostoVenta"), 7)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdCuentaCobrar")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdCuentaCobrar"), 8)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdCompraGrabado")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdCompraGrabado"), 9)
        rstReader2.Close()

        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdCompraExcento")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdCompraExcento"), 10)
        rstReader2.Close()


        sql = "SELECT *  FROM CuentaContable where id = " & rstReader("IdCuentaPagar")
        rstReader2 = clsConexion.GetRecorset(cnnConexion2, sql)
        If rstReader2.Read() = False Then Exit Sub
        llenarTextBox(rstReader2("CuentaContable"), rstReader2("Descripcion"), rstReader("IdCuentaPagar"), 11)
        rstReader2.Close()

        cnnConexion2.Close()
        cnnConexion.Close()
    End Sub

#End Region

#Region "Funciones Iniciacion"

    Private Sub Cargar()
        ActivarGui()
        Limpiar()
        Buscar()
        caso = -1
    End Sub

    Private Sub Limpiar()
        Me.txtCodigoCuentaCobrar.Clear()
        Me.txtCodigoEfectivo.Clear()
        Me.txtCodigoImpuestoVenta.Clear()
        Me.txtCodigoCompraExcento.Clear()
        Me.txtCodigoCompraGrabado.Clear()
        Me.txtCodigoVentaExcento.Clear()
        Me.txtCodigoVentaGrabada.Clear()
        Me.txtCodigoTarjetaCredito.Clear()
        Me.txtCodigoValorTransito.Clear()
        Me.txtCodigoCostoVenta.Clear()
        Me.txtCodigoInventario.Clear()
        Me.txtCodigoCuentaPagar.Clear()

        Me.txtDescripcionCuentaCobrar.Clear()
        Me.txtDescripcionEfectivo.Clear()
        Me.txtDescripcionCompraExcento.Clear()
        Me.txtDescripcionCompraGrabado.Clear()
        Me.txtDescripcionVentaExcento.Clear()
        Me.txtDescripcionVentaGrabada.Clear()
        Me.txtDescripcionImpuestoVenta.Clear()
        Me.txtDescripcionTarjetaCredito.Clear()
        Me.txtDescripcionValorTransito.Clear()
        Me.txtDescripcionCostoVenta.Clear()
        Me.txtDescripcionInventario.Clear()
        Me.txtDescripcionCuentaPagar.Clear()

        Me.erpProvider.SetError(Me, "")

    End Sub

    Private Sub ActivarGui()
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
    End Sub
#End Region

#Region "Funciones Otras"

    Private Sub llenarTextBox(ByVal pCodigo As String, ByVal pDescripcion As String, ByVal pId As Integer, ByVal pcaso As Integer)
        Select Case pcaso

            Case 0 : Me.txtCodigoImpuestoVenta.Text = pCodigo
                Me.txtDescripcionImpuestoVenta.Text = pDescripcion
                idCuentaContable(0) = pId

            Case 1 : Me.txtCodigoEfectivo.Text = pCodigo
                Me.txtDescripcionEfectivo.Text = pDescripcion
                idCuentaContable(1) = pId

            Case 2 : Me.txtCodigoValorTransito.Text = pCodigo
                Me.txtDescripcionValorTransito.Text = pDescripcion
                idCuentaContable(2) = pId

            Case 3 : Me.txtCodigoTarjetaCredito.Text = pCodigo
                Me.txtDescripcionTarjetaCredito.Text = pDescripcion
                idCuentaContable(3) = pId

            Case 4 : Me.txtCodigoInventario.Text = pCodigo
                Me.txtDescripcionInventario.Text = pDescripcion
                idCuentaContable(4) = pId

            Case 5 : Me.txtCodigoVentaGrabada.Text = pCodigo
                Me.txtDescripcionVentaGrabada.Text = pDescripcion
                idCuentaContable(5) = pId

            Case 6 : Me.txtCodigoVentaExcento.Text = pCodigo
                Me.txtDescripcionVentaExcento.Text = pDescripcion
                idCuentaContable(6) = pId

            Case 7 : Me.txtCodigoCostoVenta.Text = pCodigo
                Me.txtDescripcionCostoVenta.Text = pDescripcion
                idCuentaContable(7) = pId

            Case 8 : Me.txtCodigoCuentaCobrar.Text = pCodigo
                Me.txtDescripcionCuentaCobrar.Text = pDescripcion
                idCuentaContable(8) = pId

            Case 9 : Me.txtCodigoCompraGrabado.Text = pCodigo
                Me.txtDescripcionCompraGrabado.Text = pDescripcion
                idCuentaContable(9) = pId

            Case 10 : Me.txtCodigoCompraExcento.Text = pCodigo
                Me.txtDescripcionCompraExcento.Text = pDescripcion
                idCuentaContable(10) = pId

            Case 11 : Me.txtCodigoCuentaPagar.Text = pCodigo
                Me.txtDescripcionCuentaPagar.Text = pDescripcion
                idCuentaContable(11) = pId

        End Select
    End Sub

    Private Sub MostrarErpProvider(ByRef ptextBox As TextBox, ByVal pMensaje As String, Optional ByVal pTipo As Integer = 0)

        If pTipo = 0 Then Me.erpProvider.Dispose()

        Me.erpProvider.SetError(ptextBox, pMensaje)
        ptextBox.Focus()
    End Sub

    Private Sub MostrarErrorCaso(ByVal pCaso As Integer)
        Select Case pCaso

            Case 0
                MostrarErpProvider(txtCodigoImpuestoVenta, "Cuenta repetida", 1)
            Case 1
                MostrarErpProvider(txtCodigoEfectivo, "Cuenta repetida", 1)
            Case 2
                MostrarErpProvider(txtCodigoValorTransito, "Cuenta repetida", 1)
            Case 3
                MostrarErpProvider(txtCodigoTarjetaCredito, "Cuenta repetida", 1)
            Case 4
                MostrarErpProvider(Me.txtCodigoInventario, "Cuenta repetida", 1)
            Case 5
                MostrarErpProvider(Me.txtCodigoVentaGrabada, "Cuenta repetida", 1)
            Case 6
                MostrarErpProvider(Me.txtCodigoVentaExcento, "Cuenta repetida", 1)
            Case 7
                MostrarErpProvider(Me.txtCodigoCostoVenta, "Cuenta repetida", 1)
            Case 8
                MostrarErpProvider(Me.txtCodigoCuentaCobrar, "Cuenta repetida", 1)
            Case 9
                MostrarErpProvider(Me.txtCodigoCompraGrabado, "Cuenta repetida", 1)
            Case 10
                MostrarErpProvider(Me.txtCodigoCompraExcento, "Cuenta repetida", 1)
            Case 11
                MostrarErpProvider(Me.txtCodigoCuentaPagar, "Cuenta repetida", 1)

        End Select

    End Sub
#End Region

#Region "Funciones Seguridad"

    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try

            If TxtClave.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT  Nombre from Usuarios where Clave_Interna ='" & TxtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        NombreUsuario = rs("Nombre")
                        'Cedula_usuario = rs("Cedula")
                        txtUsuario.Text = rs("Nombre")
                        txtUsuario.Enabled = False
                        TxtClave.Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        'dtFechaInicio.Focus()

                        'me.txt= rs("Nombre")
                        'Me.DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now.Date
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Me.txtUsuario.Focus()
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
        'Dim strConexion As String
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

        If Me.txtCodigoImpuestoVenta.Text = "" Or idCuentaContable(0) = 0 Then
            MostrarErpProvider(txtCodigoImpuestoVenta, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoEfectivo.Text = "" Or idCuentaContable(1) = 0 Then
            MostrarErpProvider(txtCodigoEfectivo, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoValorTransito.Text = "" Or idCuentaContable(2) = 0 Then
            MostrarErpProvider(txtCodigoValorTransito, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoTarjetaCredito.Text = "" Or idCuentaContable(3) = 0 Then
            MostrarErpProvider(txtCodigoTarjetaCredito, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoInventario.Text = "" Or idCuentaContable(4) = 0 Then
            MostrarErpProvider(txtCodigoInventario, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoVentaGrabada.Text = "" Or idCuentaContable(5) = 0 Then
            MostrarErpProvider(txtCodigoVentaGrabada, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoVentaExcento.Text = "" Or idCuentaContable(6) = 0 Then
            MostrarErpProvider(txtCodigoVentaExcento, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoCostoVenta.Text = "" Or idCuentaContable(7) = 0 Then
            MostrarErpProvider(txtCodigoCostoVenta, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoCuentaCobrar.Text = "" Or idCuentaContable(8) = 0 Then
            MostrarErpProvider(txtCodigoCuentaCobrar, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoCompraGrabado.Text = "" Or idCuentaContable(9) = 0 Then
            MostrarErpProvider(txtCodigoCompraGrabado, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoCompraExcento.Text = "" Or idCuentaContable(10) = 0 Then
            MostrarErpProvider(txtCodigoCompraExcento, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtCodigoCuentaPagar.Text = "" Or idCuentaContable(11) = 0 Then
            MostrarErpProvider(txtCodigoCuentaPagar, "Dato requerido")
            MsgBox("Hay cuentas que estan vacias" & vbCrLf & "No se puede registrar", MsgBoxStyle.Information)
            Exit Function
        End If

        Dim n, m As Integer

        For n = 0 To idCuentaContable.Length - 1
            For m = n + 1 To idCuentaContable.Length - 1
                If idCuentaContable(n) = idCuentaContable(m) Then
                    MsgBox("Las cuentas no se pueden repetir")
                    MostrarErrorCaso(n)
                    MostrarErrorCaso(m)
                    Exit Function
                End If
            Next
        Next

        ValidarCampos = True
    End Function

#End Region

End Class
