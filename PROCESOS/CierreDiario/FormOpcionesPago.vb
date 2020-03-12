Imports System.Data.SqlClient

Public Class FormOpcionesPago
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataSetCierreDiario1 As Contabilidad.DataSetCierreDiario
    Friend WithEvents ButtonPasarA As System.Windows.Forms.Button
    Friend WithEvents TextBoxApertura As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCambiarForma As System.Windows.Forms.Button
    Friend WithEvents GroupBoxMover As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxNuevoNumAper As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxTipoPago As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxPagoTarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCambiarTP As System.Windows.Forms.Button
    Friend WithEvents GroupBoxMP As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCambiarMP As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxTipoTarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxNumTarj As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAutorizacion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxVoucher As System.Windows.Forms.TextBox
    Friend WithEvents ButtonListo As System.Windows.Forms.Button
    Friend WithEvents GroupBoxControles As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents TextBoxMontoPago As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxMoneda As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonMoneda As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxPREPAGO As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonCerrar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBoxReserva As System.Windows.Forms.TextBox
    Friend WithEvents RadioButtonTAR As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonPRE As System.Windows.Forms.RadioButton
    Friend WithEvents TextBoxMontoPrepago As System.Windows.Forms.TextBox
    Friend WithEvents pTransferencia As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDocumento As System.Windows.Forms.TextBox
    Friend WithEvents dtpDia As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboCuenta As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboBancos As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCancelarTra As System.Windows.Forms.Button
    Friend WithEvents btnListoTra As System.Windows.Forms.Button
    Friend WithEvents cboMonedaTra As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtMontoTra As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCliente As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataSetCierreDiario1 = New Contabilidad.DataSetCierreDiario
        Me.ButtonPasarA = New System.Windows.Forms.Button
        Me.TextBoxApertura = New System.Windows.Forms.TextBox
        Me.ButtonCambiarForma = New System.Windows.Forms.Button
        Me.GroupBoxMover = New System.Windows.Forms.GroupBox
        Me.TextBoxNuevoNumAper = New System.Windows.Forms.TextBox
        Me.GroupBoxTipoPago = New System.Windows.Forms.GroupBox
        Me.ComboBoxTipoPago = New System.Windows.Forms.ComboBox
        Me.ButtonCambiarTP = New System.Windows.Forms.Button
        Me.GroupBoxPagoTarjeta = New System.Windows.Forms.GroupBox
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.ButtonListo = New System.Windows.Forms.Button
        Me.TextBoxVoucher = New System.Windows.Forms.TextBox
        Me.TextBoxAutorizacion = New System.Windows.Forms.TextBox
        Me.TextBoxNumTarj = New System.Windows.Forms.TextBox
        Me.ComboBoxTipoTarjeta = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBoxMP = New System.Windows.Forms.GroupBox
        Me.TextBoxMontoPago = New System.Windows.Forms.TextBox
        Me.ButtonCambiarMP = New System.Windows.Forms.Button
        Me.GroupBoxControles = New System.Windows.Forms.GroupBox
        Me.RadioButtonPRE = New System.Windows.Forms.RadioButton
        Me.RadioButtonTAR = New System.Windows.Forms.RadioButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBoxMoneda = New System.Windows.Forms.GroupBox
        Me.ComboBoxMoneda = New System.Windows.Forms.ComboBox
        Me.ButtonMoneda = New System.Windows.Forms.Button
        Me.GroupBoxPREPAGO = New System.Windows.Forms.GroupBox
        Me.ButtonCerrar = New System.Windows.Forms.Button
        Me.TextBoxMontoPrepago = New System.Windows.Forms.TextBox
        Me.TextBoxCliente = New System.Windows.Forms.TextBox
        Me.TextBoxReserva = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.pTransferencia = New System.Windows.Forms.GroupBox
        Me.cboMonedaTra = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnCancelarTra = New System.Windows.Forms.Button
        Me.btnListoTra = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtDocumento = New System.Windows.Forms.TextBox
        Me.dtpDia = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.cboCuenta = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboBancos = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtMontoTra = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCierreDiario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxMover.SuspendLayout()
        Me.GroupBoxTipoPago.SuspendLayout()
        Me.GroupBoxPagoTarjeta.SuspendLayout()
        Me.GroupBoxMP.SuspendLayout()
        Me.GroupBoxControles.SuspendLayout()
        Me.GroupBoxMoneda.SuspendLayout()
        Me.GroupBoxPREPAGO.SuspendLayout()
        Me.pTransferencia.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.DataMember = "OpcionesPago"
        Me.DataGrid1.DataSource = Me.DataSetCierreDiario1
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(840, 349)
        Me.DataGrid1.TabIndex = 0
        '
        'DataSetCierreDiario1
        '
        Me.DataSetCierreDiario1.DataSetName = "DataSetCierreDiario"
        Me.DataSetCierreDiario1.Locale = New System.Globalization.CultureInfo("es-MX")
        Me.DataSetCierreDiario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ButtonPasarA
        '
        Me.ButtonPasarA.Location = New System.Drawing.Point(136, 16)
        Me.ButtonPasarA.Name = "ButtonPasarA"
        Me.ButtonPasarA.Size = New System.Drawing.Size(56, 23)
        Me.ButtonPasarA.TabIndex = 1
        Me.ButtonPasarA.Text = "Guardar"
        '
        'TextBoxApertura
        '
        Me.TextBoxApertura.Location = New System.Drawing.Point(8, 16)
        Me.TextBoxApertura.Name = "TextBoxApertura"
        Me.TextBoxApertura.ReadOnly = True
        Me.TextBoxApertura.Size = New System.Drawing.Size(56, 20)
        Me.TextBoxApertura.TabIndex = 2
        Me.TextBoxApertura.Text = "0"
        '
        'ButtonCambiarForma
        '
        Me.ButtonCambiarForma.Location = New System.Drawing.Point(8, 24)
        Me.ButtonCambiarForma.Name = "ButtonCambiarForma"
        Me.ButtonCambiarForma.Size = New System.Drawing.Size(72, 23)
        Me.ButtonCambiarForma.TabIndex = 4
        Me.ButtonCambiarForma.Text = "Eliminar"
        '
        'GroupBoxMover
        '
        Me.GroupBoxMover.Controls.Add(Me.TextBoxNuevoNumAper)
        Me.GroupBoxMover.Controls.Add(Me.ButtonPasarA)
        Me.GroupBoxMover.Controls.Add(Me.TextBoxApertura)
        Me.GroupBoxMover.Location = New System.Drawing.Point(88, 16)
        Me.GroupBoxMover.Name = "GroupBoxMover"
        Me.GroupBoxMover.Size = New System.Drawing.Size(200, 48)
        Me.GroupBoxMover.TabIndex = 6
        Me.GroupBoxMover.TabStop = False
        Me.GroupBoxMover.Text = "Mover a otra apertura"
        '
        'TextBoxNuevoNumAper
        '
        Me.TextBoxNuevoNumAper.Location = New System.Drawing.Point(72, 16)
        Me.TextBoxNuevoNumAper.Name = "TextBoxNuevoNumAper"
        Me.TextBoxNuevoNumAper.Size = New System.Drawing.Size(64, 20)
        Me.TextBoxNuevoNumAper.TabIndex = 2
        Me.TextBoxNuevoNumAper.Text = "0"
        Me.TextBoxNuevoNumAper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBoxTipoPago
        '
        Me.GroupBoxTipoPago.Controls.Add(Me.ComboBoxTipoPago)
        Me.GroupBoxTipoPago.Controls.Add(Me.ButtonCambiarTP)
        Me.GroupBoxTipoPago.Location = New System.Drawing.Point(296, 16)
        Me.GroupBoxTipoPago.Name = "GroupBoxTipoPago"
        Me.GroupBoxTipoPago.Size = New System.Drawing.Size(160, 48)
        Me.GroupBoxTipoPago.TabIndex = 7
        Me.GroupBoxTipoPago.TabStop = False
        Me.GroupBoxTipoPago.Text = "Cambiar tipo pago"
        '
        'ComboBoxTipoPago
        '
        Me.ComboBoxTipoPago.Items.AddRange(New Object() {"EFE", "TAR", "TRA"})
        Me.ComboBoxTipoPago.Location = New System.Drawing.Point(8, 16)
        Me.ComboBoxTipoPago.Name = "ComboBoxTipoPago"
        Me.ComboBoxTipoPago.Size = New System.Drawing.Size(80, 21)
        Me.ComboBoxTipoPago.TabIndex = 2
        '
        'ButtonCambiarTP
        '
        Me.ButtonCambiarTP.Location = New System.Drawing.Point(96, 16)
        Me.ButtonCambiarTP.Name = "ButtonCambiarTP"
        Me.ButtonCambiarTP.Size = New System.Drawing.Size(56, 23)
        Me.ButtonCambiarTP.TabIndex = 1
        Me.ButtonCambiarTP.Text = "Guardar"
        '
        'GroupBoxPagoTarjeta
        '
        Me.GroupBoxPagoTarjeta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.ButtonCancel)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.ButtonListo)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.TextBoxVoucher)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.TextBoxAutorizacion)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.TextBoxNumTarj)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.ComboBoxTipoTarjeta)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.Label4)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.Label3)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.Label2)
        Me.GroupBoxPagoTarjeta.Controls.Add(Me.Label1)
        Me.GroupBoxPagoTarjeta.Location = New System.Drawing.Point(352, 144)
        Me.GroupBoxPagoTarjeta.Name = "GroupBoxPagoTarjeta"
        Me.GroupBoxPagoTarjeta.Size = New System.Drawing.Size(256, 200)
        Me.GroupBoxPagoTarjeta.TabIndex = 8
        Me.GroupBoxPagoTarjeta.TabStop = False
        Me.GroupBoxPagoTarjeta.Text = "Información Pago Tarjeta"
        Me.GroupBoxPagoTarjeta.Visible = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.Location = New System.Drawing.Point(168, 120)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCancel.TabIndex = 9
        Me.ButtonCancel.Text = "Cancel"
        '
        'ButtonListo
        '
        Me.ButtonListo.Location = New System.Drawing.Point(88, 120)
        Me.ButtonListo.Name = "ButtonListo"
        Me.ButtonListo.Size = New System.Drawing.Size(75, 23)
        Me.ButtonListo.TabIndex = 8
        Me.ButtonListo.Text = "Listo"
        '
        'TextBoxVoucher
        '
        Me.TextBoxVoucher.Location = New System.Drawing.Point(88, 88)
        Me.TextBoxVoucher.Name = "TextBoxVoucher"
        Me.TextBoxVoucher.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxVoucher.TabIndex = 7
        Me.TextBoxVoucher.Text = "0"
        '
        'TextBoxAutorizacion
        '
        Me.TextBoxAutorizacion.Location = New System.Drawing.Point(88, 64)
        Me.TextBoxAutorizacion.Name = "TextBoxAutorizacion"
        Me.TextBoxAutorizacion.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxAutorizacion.TabIndex = 6
        Me.TextBoxAutorizacion.Text = "0"
        '
        'TextBoxNumTarj
        '
        Me.TextBoxNumTarj.Location = New System.Drawing.Point(88, 40)
        Me.TextBoxNumTarj.Name = "TextBoxNumTarj"
        Me.TextBoxNumTarj.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxNumTarj.TabIndex = 5
        Me.TextBoxNumTarj.Text = "0"
        '
        'ComboBoxTipoTarjeta
        '
        Me.ComboBoxTipoTarjeta.DataSource = Me.DataSetCierreDiario1.TipoTarjeta
        Me.ComboBoxTipoTarjeta.DisplayMember = "Nombre"
        Me.ComboBoxTipoTarjeta.Location = New System.Drawing.Point(88, 16)
        Me.ComboBoxTipoTarjeta.Name = "ComboBoxTipoTarjeta"
        Me.ComboBoxTipoTarjeta.Size = New System.Drawing.Size(152, 21)
        Me.ComboBoxTipoTarjeta.TabIndex = 4
        Me.ComboBoxTipoTarjeta.ValueMember = "Id"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Voucher:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Autorización:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tarjeta:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TipoTarjeta:"
        '
        'GroupBoxMP
        '
        Me.GroupBoxMP.Controls.Add(Me.TextBoxMontoPago)
        Me.GroupBoxMP.Controls.Add(Me.ButtonCambiarMP)
        Me.GroupBoxMP.Location = New System.Drawing.Point(472, 16)
        Me.GroupBoxMP.Name = "GroupBoxMP"
        Me.GroupBoxMP.Size = New System.Drawing.Size(160, 48)
        Me.GroupBoxMP.TabIndex = 11
        Me.GroupBoxMP.TabStop = False
        Me.GroupBoxMP.Text = "Cambiar Monto Pago"
        '
        'TextBoxMontoPago
        '
        Me.TextBoxMontoPago.Location = New System.Drawing.Point(8, 16)
        Me.TextBoxMontoPago.Name = "TextBoxMontoPago"
        Me.TextBoxMontoPago.Size = New System.Drawing.Size(80, 20)
        Me.TextBoxMontoPago.TabIndex = 3
        Me.TextBoxMontoPago.Text = "0"
        Me.TextBoxMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ButtonCambiarMP
        '
        Me.ButtonCambiarMP.Location = New System.Drawing.Point(96, 16)
        Me.ButtonCambiarMP.Name = "ButtonCambiarMP"
        Me.ButtonCambiarMP.Size = New System.Drawing.Size(56, 23)
        Me.ButtonCambiarMP.TabIndex = 1
        Me.ButtonCambiarMP.Text = "Guardar"
        '
        'GroupBoxControles
        '
        Me.GroupBoxControles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxControles.Controls.Add(Me.RadioButtonPRE)
        Me.GroupBoxControles.Controls.Add(Me.RadioButtonTAR)
        Me.GroupBoxControles.Controls.Add(Me.Label5)
        Me.GroupBoxControles.Controls.Add(Me.GroupBoxMoneda)
        Me.GroupBoxControles.Controls.Add(Me.GroupBoxMP)
        Me.GroupBoxControles.Controls.Add(Me.ButtonCambiarForma)
        Me.GroupBoxControles.Controls.Add(Me.GroupBoxMover)
        Me.GroupBoxControles.Controls.Add(Me.GroupBoxTipoPago)
        Me.GroupBoxControles.Location = New System.Drawing.Point(8, 352)
        Me.GroupBoxControles.Name = "GroupBoxControles"
        Me.GroupBoxControles.Size = New System.Drawing.Size(840, 96)
        Me.GroupBoxControles.TabIndex = 13
        Me.GroupBoxControles.TabStop = False
        Me.GroupBoxControles.Text = "controles"
        '
        'RadioButtonPRE
        '
        Me.RadioButtonPRE.Location = New System.Drawing.Point(152, 72)
        Me.RadioButtonPRE.Name = "RadioButtonPRE"
        Me.RadioButtonPRE.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonPRE.TabIndex = 15
        Me.RadioButtonPRE.Text = "Info PRE"
        '
        'RadioButtonTAR
        '
        Me.RadioButtonTAR.Checked = True
        Me.RadioButtonTAR.Location = New System.Drawing.Point(80, 72)
        Me.RadioButtonTAR.Name = "RadioButtonTAR"
        Me.RadioButtonTAR.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonTAR.TabIndex = 14
        Me.RadioButtonTAR.TabStop = True
        Me.RadioButtonTAR.Text = "Info TAR"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Al 2 Clic:"
        '
        'GroupBoxMoneda
        '
        Me.GroupBoxMoneda.Controls.Add(Me.ComboBoxMoneda)
        Me.GroupBoxMoneda.Controls.Add(Me.ButtonMoneda)
        Me.GroupBoxMoneda.Location = New System.Drawing.Point(648, 16)
        Me.GroupBoxMoneda.Name = "GroupBoxMoneda"
        Me.GroupBoxMoneda.Size = New System.Drawing.Size(184, 48)
        Me.GroupBoxMoneda.TabIndex = 12
        Me.GroupBoxMoneda.TabStop = False
        Me.GroupBoxMoneda.Text = "Cambiar Moneda"
        '
        'ComboBoxMoneda
        '
        Me.ComboBoxMoneda.Items.AddRange(New Object() {"COLON", "DOLAR"})
        Me.ComboBoxMoneda.Location = New System.Drawing.Point(8, 16)
        Me.ComboBoxMoneda.Name = "ComboBoxMoneda"
        Me.ComboBoxMoneda.Size = New System.Drawing.Size(80, 21)
        Me.ComboBoxMoneda.TabIndex = 2
        '
        'ButtonMoneda
        '
        Me.ButtonMoneda.Location = New System.Drawing.Point(96, 16)
        Me.ButtonMoneda.Name = "ButtonMoneda"
        Me.ButtonMoneda.Size = New System.Drawing.Size(56, 23)
        Me.ButtonMoneda.TabIndex = 1
        Me.ButtonMoneda.Text = "Guardar"
        '
        'GroupBoxPREPAGO
        '
        Me.GroupBoxPREPAGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxPREPAGO.Controls.Add(Me.ButtonCerrar)
        Me.GroupBoxPREPAGO.Controls.Add(Me.TextBoxMontoPrepago)
        Me.GroupBoxPREPAGO.Controls.Add(Me.TextBoxCliente)
        Me.GroupBoxPREPAGO.Controls.Add(Me.TextBoxReserva)
        Me.GroupBoxPREPAGO.Controls.Add(Me.Label6)
        Me.GroupBoxPREPAGO.Controls.Add(Me.Label7)
        Me.GroupBoxPREPAGO.Controls.Add(Me.Label8)
        Me.GroupBoxPREPAGO.Location = New System.Drawing.Point(552, 120)
        Me.GroupBoxPREPAGO.Name = "GroupBoxPREPAGO"
        Me.GroupBoxPREPAGO.Size = New System.Drawing.Size(256, 200)
        Me.GroupBoxPREPAGO.TabIndex = 14
        Me.GroupBoxPREPAGO.TabStop = False
        Me.GroupBoxPREPAGO.Text = "Información Prepago"
        Me.GroupBoxPREPAGO.Visible = False
        '
        'ButtonCerrar
        '
        Me.ButtonCerrar.Location = New System.Drawing.Point(168, 120)
        Me.ButtonCerrar.Name = "ButtonCerrar"
        Me.ButtonCerrar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCerrar.TabIndex = 9
        Me.ButtonCerrar.Text = "Cerrar"
        '
        'TextBoxMontoPrepago
        '
        Me.TextBoxMontoPrepago.Location = New System.Drawing.Point(88, 88)
        Me.TextBoxMontoPrepago.Name = "TextBoxMontoPrepago"
        Me.TextBoxMontoPrepago.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxMontoPrepago.TabIndex = 7
        Me.TextBoxMontoPrepago.Text = "0"
        '
        'TextBoxCliente
        '
        Me.TextBoxCliente.Location = New System.Drawing.Point(88, 64)
        Me.TextBoxCliente.Name = "TextBoxCliente"
        Me.TextBoxCliente.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxCliente.TabIndex = 6
        Me.TextBoxCliente.Text = "0"
        '
        'TextBoxReserva
        '
        Me.TextBoxReserva.Location = New System.Drawing.Point(88, 40)
        Me.TextBoxReserva.Name = "TextBoxReserva"
        Me.TextBoxReserva.Size = New System.Drawing.Size(152, 20)
        Me.TextBoxReserva.TabIndex = 5
        Me.TextBoxReserva.Text = "0"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Monto Prepago:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Cliente:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Reservación:"
        '
        'pTransferencia
        '
        Me.pTransferencia.Controls.Add(Me.Label14)
        Me.pTransferencia.Controls.Add(Me.txtMontoTra)
        Me.pTransferencia.Controls.Add(Me.cboMonedaTra)
        Me.pTransferencia.Controls.Add(Me.Label13)
        Me.pTransferencia.Controls.Add(Me.btnCancelarTra)
        Me.pTransferencia.Controls.Add(Me.btnListoTra)
        Me.pTransferencia.Controls.Add(Me.Label12)
        Me.pTransferencia.Controls.Add(Me.txtDocumento)
        Me.pTransferencia.Controls.Add(Me.dtpDia)
        Me.pTransferencia.Controls.Add(Me.Label11)
        Me.pTransferencia.Controls.Add(Me.cboCuenta)
        Me.pTransferencia.Controls.Add(Me.Label10)
        Me.pTransferencia.Controls.Add(Me.cboBancos)
        Me.pTransferencia.Controls.Add(Me.Label9)
        Me.pTransferencia.Location = New System.Drawing.Point(57, 140)
        Me.pTransferencia.Name = "pTransferencia"
        Me.pTransferencia.Size = New System.Drawing.Size(276, 204)
        Me.pTransferencia.TabIndex = 15
        Me.pTransferencia.TabStop = False
        Me.pTransferencia.Text = "Informacion Transferencia"
        Me.pTransferencia.Visible = False
        '
        'cboMonedaTra
        '
        Me.cboMonedaTra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedaTra.FormattingEnabled = True
        Me.cboMonedaTra.Location = New System.Drawing.Point(101, 21)
        Me.cboMonedaTra.Name = "cboMonedaTra"
        Me.cboMonedaTra.Size = New System.Drawing.Size(152, 21)
        Me.cboMonedaTra.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(52, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Moneda :"
        '
        'btnCancelarTra
        '
        Me.btnCancelarTra.Location = New System.Drawing.Point(178, 177)
        Me.btnCancelarTra.Name = "btnCancelarTra"
        Me.btnCancelarTra.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelarTra.TabIndex = 7
        Me.btnCancelarTra.Text = "Cancel"
        '
        'btnListoTra
        '
        Me.btnListoTra.Location = New System.Drawing.Point(101, 177)
        Me.btnListoTra.Name = "btnListoTra"
        Me.btnListoTra.Size = New System.Drawing.Size(75, 23)
        Me.btnListoTra.TabIndex = 6
        Me.btnListoTra.Text = "Listo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 131)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "# Documento :"
        '
        'txtDocumento
        '
        Me.txtDocumento.Location = New System.Drawing.Point(101, 128)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(152, 20)
        Me.txtDocumento.TabIndex = 4
        '
        'dtpDia
        '
        Me.dtpDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDia.Location = New System.Drawing.Point(101, 101)
        Me.dtpDia.Name = "dtpDia"
        Me.dtpDia.Size = New System.Drawing.Size(152, 20)
        Me.dtpDia.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Dia :"
        '
        'cboCuenta
        '
        Me.cboCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCuenta.FormattingEnabled = True
        Me.cboCuenta.Location = New System.Drawing.Point(101, 74)
        Me.cboCuenta.Name = "cboCuenta"
        Me.cboCuenta.Size = New System.Drawing.Size(152, 21)
        Me.cboCuenta.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(16, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Cuenta :"
        '
        'cboBancos
        '
        Me.cboBancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBancos.FormattingEnabled = True
        Me.cboBancos.Location = New System.Drawing.Point(101, 49)
        Me.cboBancos.Name = "cboBancos"
        Me.cboBancos.Size = New System.Drawing.Size(152, 21)
        Me.cboBancos.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Banco :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(17, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Monto :"
        '
        'txtMontoTra
        '
        Me.txtMontoTra.Location = New System.Drawing.Point(101, 153)
        Me.txtMontoTra.Name = "txtMontoTra"
        Me.txtMontoTra.Size = New System.Drawing.Size(152, 20)
        Me.txtMontoTra.TabIndex = 5
        '
        'FormOpcionesPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(856, 453)
        Me.Controls.Add(Me.pTransferencia)
        Me.Controls.Add(Me.GroupBoxPREPAGO)
        Me.Controls.Add(Me.GroupBoxControles)
        Me.Controls.Add(Me.GroupBoxPagoTarjeta)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "FormOpcionesPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opciones Pago"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCierreDiario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxMover.ResumeLayout(False)
        Me.GroupBoxMover.PerformLayout()
        Me.GroupBoxTipoPago.ResumeLayout(False)
        Me.GroupBoxPagoTarjeta.ResumeLayout(False)
        Me.GroupBoxPagoTarjeta.PerformLayout()
        Me.GroupBoxMP.ResumeLayout(False)
        Me.GroupBoxMP.PerformLayout()
        Me.GroupBoxControles.ResumeLayout(False)
        Me.GroupBoxMoneda.ResumeLayout(False)
        Me.GroupBoxPREPAGO.ResumeLayout(False)
        Me.GroupBoxPREPAGO.PerformLayout()
        Me.pTransferencia.ResumeLayout(False)
        Me.pTransferencia.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public NApertura As Integer = 0
    Public BaseDatos As String

    Dim tipo As String = "EFE"
    Private Sub FormOpcionesPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizar()
        Me.TextBoxApertura.Text = Me.NApertura
        Me.Text = "Opciones de Pago : " & Me.NApertura

        cFunciones.Llenar_Tabla_Generico("Select * From TipoTarjeta", Me.DataSetCierreDiario1.TipoTarjeta, Configuracion.Claves.Conexion("Hotel"))

    End Sub
    Sub actualizar()
        Me.DataSetCierreDiario1.OpcionesPago.Clear()
        cFunciones.Llenar_Tabla_Generico("SELECT OpcionesDePago.id AS Id_Opciones, OpcionesDePago.Documento, OpcionesDePago.FormaPago AS [Tipo Pago], OpcionesDePago.MontoPago AS Monto," &
                       " Moneda.MonedaNombre AS Moneda, '" & BaseDatos & "' AS BD, TipoDocumento As TipoDoc, OpcionesDePago.CodMoneda As MonedaCod, TipoCambio, Fecha" &
                        " FROM OpcionesDePago INNER JOIN " &
                      " Moneda ON OpcionesDePago.CodMoneda = Moneda.CodMoneda WHERE Numapertura = " & NApertura, Me.DataSetCierreDiario1.OpcionesPago, Configuracion.Claves.Configuracion(BaseDatos))
    End Sub
    Private Sub ButtonPasarA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPasarA.Click
        If MsgBox("¿Desea realmente cambiar esta apertura por la apertura digitada?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cx As New Conexion
            cx.Conectar(, Me.BaseDatos)
            cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set Numapertura = " & Me.TextBoxNuevoNumAper.Text & " WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
            cx.DesConectar(cx.sQlconexion)
            Me.actualizar()
        End If
    End Sub

    Private Sub ButtonCambiarTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCambiarTP.Click
        tipo = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Tipo Pago")
        If tipo.Equals("TAR") Then
            mostrarForma()
        End If

        If Me.ComboBoxTipoPago.Text.Equals("TRA") Then
            Me.Muestra_Panel_Transferencia(Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("MonedaCod"))
        End If

        If Me.ComboBoxTipoPago.Text.Equals("TAR") Then
            Me.GroupBoxControles.Enabled = False
            Me.GroupBoxPagoTarjeta.Enabled = True
            Me.GroupBoxPagoTarjeta.Visible = True
        ElseIf Me.ComboBoxTipoPago.Text.Equals("EFE") And tipo = "EFE" Then
            MsgBox("Ya esta en EFE")
            If Me.GetEmpresa = "3-101-104775" Then
                Me.CambiarConsecutivoFactura(Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("MonedaCod"))
                Me.actualizar()
            End If
            Me.actualizar()
        ElseIf tipo.Equals("TAR") And Me.ComboBoxTipoPago.Text.Equals("EFE") Then
            If MsgBox("¿Desea realmente la opcion de pago?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim cx As New Conexion
                cx.Conectar("SEESOFT", Me.BaseDatos)
                cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set FormaPago = 'EFE' WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
                cx.SlqExecute(cx.sQlconexion, "Delete Detalle_pago_caja WHERE id_ODP = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
                cx.DesConectar(cx.sQlconexion)
                If Me.GetEmpresa = "3-101-104775" Then
                    Me.CambiarConsecutivoFactura(Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Documento"))
                    Me.actualizar()
                End If
                Me.actualizar()
            End If
        End If

    End Sub

    Private Function GetEmpresa() As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Cedula from Hotel.dbo.Configuraciones", dt, Configuracion.Claves.Conexion("Hotel"))
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("Cedula")
        Else
            Return ""
        End If
    End Function

    Private Sub CambiarConsecutivoFactura(ByVal _Doc As String)
        Dim dt As New DataTable
        Dim IdPuntoVenta, NumFactura As String

        If _Doc < 1000000 Then ' si la factura es menor a un millon
            cFunciones.Llenar_Tabla_Generico("Select * From " & Me.BaseDatos & ".dbo.Opcionesdepago where Documento =  " & _Doc & " and FormaPago <> 'EFE'", dt, Configuracion.Claves.Conexion("Hotel"))
            If Not dt.Rows.Count > 0 Then ' si se pago solo en efectivo
                dt = New DataTable
                cFunciones.Llenar_Tabla_Generico("Select IdPuntoVenta From Hotel.dbo.PuntoVenta where BaseDatos = '" & Me.BaseDatos & "' and Tipo = 'RESTAURANTE' and IdPuntoVenta In(Select IdPuntoVenta From Hotel.dbo.viewNoPuntoVenta)", dt, Configuracion.Claves.Conexion("Hotel"))
                If dt.Rows.Count > 0 Then 'si la forma de pago proviene de un punto de venta correcto
                    IdPuntoVenta = dt.Rows(0).Item("IdPuntoVenta")
                    dt = New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select IsNull(MAX(Num_Factura),0) + 1 From Hotel.dbo.ventas where Proveniencia_Venta = " & IdPuntoVenta, dt, Configuracion.Claves.Conexion("Hotel"))
                    If dt.Rows.Count > 0 Then 'obtiene el proximo numero de factura
                        NumFactura = dt.Rows(0).Item(0)
                        Dim cx As New Conexion
                        cx.Conectar("SEESOFT", Me.BaseDatos) 'actualizamos consecutivos
                        cx.SlqExecute(cx.sQlconexion, "Update Hotel.dbo.Ventas set Num_Factura = " & NumFactura & ", Contabilizado = 1 where Num_Factura = " & _Doc & " and Proveniencia_Venta = " & IdPuntoVenta)
                        cx.SlqExecute(cx.sQlconexion, "Update " & BaseDatos & ".dbo.OpcionesDePago set Documento = " & NumFactura & " where Documento = " & _Doc)
                        cx.DesConectar(cx.sQlconexion)
                    End If
                End If
            End If
        End If

        If _Doc > 1000000 Then
            cFunciones.Llenar_Tabla_Generico("Select * From " & Me.BaseDatos & ".dbo.Opcionesdepago where Documento =  " & _Doc & " and FormaPago = 'TAR'", dt, Configuracion.Claves.Conexion("Hotel"))
            If dt.Rows.Count > 0 Then ' si tiene pago en tarjeta
                dt = New DataTable
                cFunciones.Llenar_Tabla_Generico("Select IdPuntoVenta From Hotel.dbo.PuntoVenta where BaseDatos = '" & Me.BaseDatos & "' and Tipo = 'RESTAURANTE' and IdPuntoVenta In(Select IdPuntoVenta From Hotel.dbo.viewNoPuntoVenta)", dt, Configuracion.Claves.Conexion("Hotel"))
                If dt.Rows.Count > 0 Then 'si la forma de pago proviene de un punto de venta correcto
                    IdPuntoVenta = dt.Rows(0).Item("IdPuntoVenta")
                    dt = New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select IsNull(MAX(Num_Factura),0) + 1 From Hotel.dbo.ventas where Num_Factura < 1000000 and  Proveniencia_Venta = " & IdPuntoVenta, dt, Configuracion.Claves.Conexion("Hotel"))
                    If dt.Rows.Count > 0 Then 'obtiene el proximo numero de factura
                        NumFactura = dt.Rows(0).Item(0)
                        Dim cx As New Conexion
                        cx.Conectar("SEESOFT", Me.BaseDatos) 'actualizamos consecutivos
                        cx.SlqExecute(cx.sQlconexion, "Update Hotel.dbo.Ventas set Num_Factura = " & NumFactura & ", Contabilizado = 0 where Num_Factura = " & _Doc & " and Proveniencia_Venta = " & IdPuntoVenta)
                        cx.SlqExecute(cx.sQlconexion, "Update " & BaseDatos & ".dbo.OpcionesDePago set Documento = " & NumFactura & " where Documento = " & _Doc)
                        cx.DesConectar(cx.sQlconexion)
                    End If
                End If
            End If
        End If

    End Sub

    Sub mostrarForma()
        DataSetCierreDiario1.Detalle_pago_caja.Clear()
        cFunciones.Llenar_Tabla_Generico("Select * From Detalle_pago_caja WHERE Id_ODP = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"), Me.DataSetCierreDiario1.Detalle_pago_caja, Configuracion.Claves.Configuracion(BaseDatos))
        If Me.DataSetCierreDiario1.Detalle_pago_caja.Count > 0 Then
            Me.TextBoxNumTarj.Text = Me.DataSetCierreDiario1.Detalle_pago_caja(0).Referencia
            Me.TextBoxVoucher.Text = Me.DataSetCierreDiario1.Detalle_pago_caja(0).Documento
            Me.TextBoxAutorizacion.Text = Me.DataSetCierreDiario1.Detalle_pago_caja(0).ReferenciaDoc
            Me.ComboBoxTipoTarjeta.SelectedValue = Me.DataSetCierreDiario1.Detalle_pago_caja(0).ReferenciaTipo
        End If
    End Sub

    Private Sub ButtonCambiarForma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCambiarForma.Click
        If MsgBox("¿Desea realmente eliminar esta opcion de pago?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cx As New Conexion
            cx.Conectar(, Me.BaseDatos)
            cx.SlqExecute(cx.sQlconexion, "Delete OpcionesDePago WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))

            cx.DesConectar(cx.sQlconexion)
            Me.actualizar()
        End If
    End Sub

    Private Sub ButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancel.Click
        Me.GroupBoxControles.Enabled = True
        Me.GroupBoxPagoTarjeta.Enabled = True
        Me.GroupBoxPagoTarjeta.Visible = False
        Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Tipo Pago") = tipo
        ButtonListo.Visible = True

    End Sub

    Private Sub ButtonListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListo.Click

        If MsgBox("¿Desea realmente cambiar la opcion de pago?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim factura As String = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Documento")
            Dim tipoFactura As String = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("TipoDoc")

            Dim cx As New Conexion
            cx.Conectar(, Me.BaseDatos)
            cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set FormaPago = 'TAR' WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
            cx.SlqExecute(cx.sQlconexion, "DELETE Detalle_pago_caja WHERE id_ODP = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
            Dim ingresa As String = ""
            If tipo.Equals("TAR") Then

                If Me.DataSetCierreDiario1.Detalle_pago_caja.Count > 0 Then
                    ingresa = "INSERT INTO Detalle_pago_caja" & _
                                                " (NumeroFactura, TipoFactura, FormaPago, Referencia, Documento, ReferenciaTipo, ReferenciaDoc, Moneda, TipoCambio, Id_ODP, Cancelado, " & _
                                                " Deposito)" & _
                                                        " VALUES     (" & factura & ", '" & tipoFactura & "', '" & tipo & "','" & Me.TextBoxNumTarj.Text & "','" & Me.TextBoxVoucher.Text & "', " & Me.ComboBoxTipoTarjeta.SelectedValue & ", '" & Me.TextBoxAutorizacion.Text & "', " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("MonedaCod") & ", " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("TipoCambio") & ", " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones") & ", " & Me.DataSetCierreDiario1.Detalle_pago_caja(0).Cancelado & "," & Me.DataSetCierreDiario1.Detalle_pago_caja(0).Deposito & ")"
                Else
                    ingresa = "INSERT INTO Detalle_pago_caja" & _
                                                " (NumeroFactura, TipoFactura, FormaPago, Referencia, Documento, ReferenciaTipo, ReferenciaDoc, Moneda, TipoCambio, Id_ODP, Cancelado, " & _
                                                " Deposito)" & _
                                                        " VALUES     (" & factura & ", '" & tipoFactura & "', '" & tipo & "','" & Me.TextBoxNumTarj.Text & "','" & Me.TextBoxVoucher.Text & "', " & Me.ComboBoxTipoTarjeta.SelectedValue & ", '" & Me.TextBoxAutorizacion.Text & "', " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("MonedaCod") & ", " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("TipoCambio") & ", " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones") & ",0,0)"
                End If



            Else

                ingresa = "INSERT INTO Detalle_pago_caja" & _
                                                                " (NumeroFactura, TipoFactura, FormaPago, Referencia, Documento, ReferenciaTipo, ReferenciaDoc, Moneda, TipoCambio, Id_ODP, Cancelado, " & _
                                                                " Deposito)" & _
                                                                        " VALUES     (" & factura & ", '" & tipoFactura & "', '" & tipo & "','" & Me.TextBoxNumTarj.Text & "','" & Me.TextBoxVoucher.Text & "', " & Me.ComboBoxTipoTarjeta.SelectedValue & ", '" & Me.TextBoxAutorizacion.Text & "', " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("MonedaCod") & ", " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("TipoCambio") & ", " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones") & ",0,0)"
            End If
            cx.SlqExecute(cx.sQlconexion, ingresa)
            cx.DesConectar(cx.sQlconexion)
            If Me.GetEmpresa = "3-101-104775" Then
                Me.CambiarConsecutivoFactura(Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Documento"))
                Me.actualizar()
            End If
            Me.actualizar()
        End If
        Me.GroupBoxControles.Enabled = True
        Me.GroupBoxPagoTarjeta.Enabled = True
        Me.GroupBoxPagoTarjeta.Visible = False


    End Sub

    Private Sub ButtonCambiarMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCambiarMP.Click
        If MsgBox("¿Desea realmente cambiar el monto de la opcion de pago?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim cx As New Conexion
            cx.Conectar(, Me.BaseDatos)
            cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set MontoPago = " & Me.TextBoxMontoPago.Text & " WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
            cx.DesConectar(cx.sQlconexion)
            Me.actualizar()
        End If
    End Sub

    Private Sub ButtonMoneda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMoneda.Click
        If MsgBox("Desea cambiar la moneda", MsgBoxStyle.YesNo) Then
            Dim cx As New Conexion
            cx.Conectar(, Me.BaseDatos)
            If Me.ComboBoxMoneda.Text.Equals("COLON") Then
                cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set CodMoneda = 1, TipoCambio = 1 WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
                cx.SlqExecute(cx.sQlconexion, "UPDATE Detalle_pago_caja Set Moneda = 1, TipoCambio = 1 WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
            Else
                Dim Cconexion1 As New Conexion
                Dim sqlconexion1 As SqlClient.SqlConnection
                Dim TipoCambio As Double
                sqlconexion1 = Cconexion1.Conectar(, "Seguridad")
                TipoCambio = Cconexion1.SlqExecuteScalar(sqlconexion1, "SELECT ValorCompra FROM HistoricoMoneda WHERE Fecha = dbo.DateOnlyFinal('" & BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Fecha") & "')")
                cx.SlqExecute(cx.sQlconexion, "UPDATE OpcionesDePago Set CodMoneda = 2, NombreMoneda = 'DOLAR', TipoCambio =" & TipoCambio & "WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
                cx.SlqExecute(cx.sQlconexion, "UPDATE Detalle_pago_caja Set Moneda = 2, TipoCambio =" & TipoCambio & " WHERE id = " & Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones"))
                Cconexion1.DesConectar(sqlconexion1)
            End If
            cx.DesConectar(cx.sQlconexion)
            actualizar()

        End If
    End Sub


    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        If RadioButtonTAR.Checked Then
            tipo = BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Tipo Pago")
            If tipo.Equals("TAR") Then
                mostrarForma()
                GroupBoxControles.Enabled = False
                GroupBoxPagoTarjeta.Enabled = True
                GroupBoxPagoTarjeta.Visible = True
                ButtonListo.Visible = False
            Else
                GroupBoxControles.Enabled = True
                GroupBoxPagoTarjeta.Enabled = False
                GroupBoxPagoTarjeta.Visible = False
                ButtonListo.Visible = True
            End If
        Else
            Dim TipoDoc As String = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("TipoDoc")
            If TipoDoc.Equals("PRE") Then
                muestraPRE()
                GroupBoxControles.Enabled = False
                GroupBoxPREPAGO.Visible = True
            Else
                GroupBoxControles.Enabled = True
                GroupBoxPREPAGO.Visible = False
            End If
        End If
    End Sub
    Sub muestraPRE()
        Dim doc As Integer = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Documento")
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * From Cuentas Where MontoPrepago > 0 AND Id = " & doc, dt, Configuracion.Claves.Conexion("Hotel"))
        If dt.Rows.Count > 0 Then
            Me.TextBoxReserva.Text = dt.Rows(0).Item("Id_Reservacion")
            Me.TextBoxMontoPrepago.Text = dt.Rows(0).Item("MontoPrepago")
            Me.TextBoxCliente.Text = dt.Rows(0).Item("Nombre")
        Else
            cFunciones.Llenar_Tabla_Generico("Select * From Reservacion Where Id_Reservacion = " & doc, dt, Configuracion.Claves.Conexion("Hotel"))
            If dt.Rows.Count > 0 Then
                Me.TextBoxReserva.Text = dt.Rows(0).Item("Id_Reservacion")
                Me.TextBoxCliente.Text = dt.Rows(0).Item("Nombre_Cliente")
                cFunciones.Llenar_Tabla_Generico("Select * From Prepagos Where Id_Reservacion = " & doc, dt, Configuracion.Claves.Conexion("Hotel"))
                If dt.Rows.Count > 0 Then
                    Me.TextBoxMontoPrepago.Text = dt.Rows(0).Item("Monto")
                Else
                    MsgBox("No se encuentra el monto de la reserva")
                End If
            End If
        End If
    End Sub

    Private Sub ButtonCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCerrar.Click
        Me.GroupBoxControles.Enabled = True
        Me.GroupBoxPREPAGO.Visible = False
    End Sub

    Private Sub CargarMoneda()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select CodMoneda, MonedaNombre from seguridad.dbo.Moneda where CodMoneda in(select c.Cod_Moneda from bancos.dbo.Cuentas_bancarias c)", dt, Configuracion.Claves.Conexion("Seguridad"))
        Me.cboMonedaTra.DataSource = dt
        Me.cboMonedaTra.DisplayMember = "MonedaNombre"
        Me.cboMonedaTra.ValueMember = "CodMoneda"
    End Sub

    Private Sub CargarBancos()
        On Error Resume Next
        Dim dt As New DataTable
        Dim CodMoneda As String = Me.cboMonedaTra.SelectedValue
        If CodMoneda <> "" Then
            cFunciones.Llenar_Tabla_Generico("select distinct b.Codigo_banco, b.Descripcion from bancos.dbo.Bancos b inner join bancos.dbo.Cuentas_bancarias c on c.Codigo_banco = b.Codigo_banco where c.Cod_Moneda = " & CodMoneda, dt, Configuracion.Claves.Conexion("Bancos"))
            Me.cboBancos.DataSource = dt
            Me.cboBancos.DisplayMember = "Descripcion"
            Me.cboBancos.ValueMember = "Codigo_banco"
        End If
    End Sub

    Private Sub CargarCuentas()
        On Error Resume Next
        Dim dt As New DataTable
        Dim CodBanco As String = Me.cboBancos.SelectedValue
        Dim CodMoneda As String = Me.cboMonedaTra.SelectedValue
        If CodMoneda <> "" And CodBanco <> "" Then
            cFunciones.Llenar_Tabla_Generico("select c.Id_CuentaBancaria, Cuenta from bancos.dbo.Bancos b inner join bancos.dbo.Cuentas_bancarias c on c.Codigo_banco = b.Codigo_banco where c.Cod_Moneda = " & CodMoneda & " and b.Codigo_banco = " & CodBanco, dt, Configuracion.Claves.Conexion("Bancos"))
            Me.cboCuenta.DataSource = dt
            Me.cboCuenta.DisplayMember = "Cuenta"
            Me.cboCuenta.ValueMember = "Id_CuentaBancaria"
        End If
    End Sub

    Private IdOdP As String = "0"
    Private Sub Muestra_Panel_Transferencia(ByVal _IdMoneda As Integer)
        pTransferencia.Visible = True
        Me.CargarMoneda()
        Me.CargarBancos()
        Me.CargarCuentas()
        Me.cboMonedaTra.SelectedValue = _IdMoneda
        Me.txtMontoTra.Text = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Monto")
        Me.IdOdP = Me.BindingContext(Me.DataSetCierreDiario1, "OpcionesPago").Current("Id_Opciones")
    End Sub

    Private Function PasaTra() As Boolean
        Dim dt As New DataTable
        'validar que la informacion este digitada
        If IsNumeric(Me.txtDocumento.Text) = False Then
            MsgBox("El numero del Documento debe ser un valor numerico.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
            Return False
        End If
        If IsNumeric(Me.txtMontoTra.Text) = False Then
            MsgBox("El numero del Monto debe ser un valor numerico.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
            Return False
        End If
        'validar que el documento no exista
        cFunciones.Llenar_Tabla_Generico("Select * from bancos.dbo.Deposito d where d.numerodocumento = " & Me.txtDocumento.Text & " and Id_CuentaBancaria = " & Me.cboCuenta.SelectedValue, dt, Configuracion.Claves.Conexion("Bancos"))
        If dt.Rows.Count > 0 Then
            MsgBox("El documento '" & Me.txtDocumento.Text & "' ya esta registrado", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
            Return False
        End If
        'validar conciliaciones
        cFunciones.Llenar_Tabla_Generico("select * from bancos.dbo.Conciliacion c Where Anulado = 0 and c.Id_CuentaBancaria = " & Me.cboCuenta.SelectedValue & " and dbo.DateOnly(Fecha) >= dbo.DateOnly('" & Me.dtpDia.Value.ToShortDateString & "')", dt, Configuracion.Claves.Conexion("Bancos"))
        If dt.Rows.Count > 0 Then
            MsgBox("Existe una conciliacion bancaria posterior a la fecha '" & Me.dtpDia.Value.ToShortDateString & "'", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
            Return False
        End If
        'validar que el periodo contable no este abierto y no este bloqueado
        cFunciones.Llenar_Tabla_Generico("select Estado from contabilidad.dbo.Periodo where estado = 0 and Mes = " & Me.dtpDia.Value.Month & " and Anno = " & Me.dtpDia.Value.Year, dt, Configuracion.Claves.Conexion("Bancos"))
        If dt.Rows.Count > 0 Then

        Else
            MsgBox("El periodo contable no esta registrado o esta cerrado.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion.")
            Return False
        End If

        Return True
    End Function

    Private Sub Registrar_Transferencia()
        'Insertar Deposito y Asiento
        If Me.RegistrarDepositoAsiento() = True Then
            'Actualizar Forma de pago
            Dim cx As New Conexion
            cx.Conectar("SeeSOFT", Me.BaseDatos)
            cx.SlqExecute(cx.sQlconexion, "Update " & BaseDatos & ".dbo.OpcionesDePago set MontoPago = " & Me.txtMontoTra.Text & ", Denominacion = " & Me.txtMontoTra.Text & ", FormaPago = 'TRA', CodMoneda = " & Me.cboMonedaTra.SelectedValue & ", Nombremoneda = '" & Me.cboMonedaTra.Text & "' where Id = " & Me.IdOdP)
            cx.DesConectar(cx.sQlconexion)
            Me.pTransferencia.Visible = False
            Me.actualizar()
        End If
        'Vuelva a cargar la informacion        
    End Sub

    Function RegistrarDepositoAsiento() As Boolean
        Dim Trans As SqlTransaction     'REALIZ LA TRANSACCION DE LOS ASIENTOS CONTABLES
        Try

            Dim Fx As New cFunciones
            Dim NumAsiento As String = ""

            NumAsiento = Fx.BuscaNumeroAsiento("BCO-" & Format(Me.dtpDia.Value.Month, "00") & Format(Me.dtpDia.Value.Date, "yy") & "-")
            Dim TipoCambio As Decimal = Fx.TipoCambio(Me.dtpDia.Value)

            Dim CuentaDebe, DescripcionDebe As String
            Dim CuentaHaber, DescripcionHaber As String

            Dim dtDebe As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select CuentaContable, NombreCuentaContable from bancos.dbo.Cuentas_bancarias Where Id_CuentaBancaria = " & Me.cboCuenta.SelectedValue, dtDebe, Configuracion.Claves.Conexion("Bancos"))
            If dtDebe.Rows.Count > 0 Then
                CuentaDebe = dtDebe.Rows(0).Item(0)
                DescripcionDebe = dtDebe.Rows(0).Item(1)
            End If

            Dim dtHaber As New DataTable
            cFunciones.Llenar_Tabla_Generico("select c.CuentaContable, c.Descripcion from Contabilidad.dbo.SettingCuentaContable s inner join Contabilidad.dbo.CuentaContable c on s.IdCaja = c.id", dtHaber, Configuracion.Claves.Conexion("Contabilidad"))
            If dtHaber.Rows.Count > 0 Then
                CuentaHaber = dtHaber.Rows(0).Item(0)
                DescripcionHaber = dtHaber.Rows(0).Item(1)
            End If

            Dim con As New SqlConnection(Configuracion.Claves.Conexion("Contabilidad"))
            Dim cmd As SqlDataAdapter
            con.Open()
            Trans = con.BeginTransaction

            cmd = New SqlDataAdapter("Insert Into Bancos.dbo.Deposito(NumeroDocumento, Id_CuentaBancaria, Fecha, Monto, Concepto, Anulado, Conciliado, Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion, CodigoMoneda, TipoCambio, OtrasDeducciones, Renta, Comision, Retencion, CuentaDeduccion, Id_Operador) Values(@NumeroDocumento, @Id_CuentaBancaria, @Fecha, @Monto, @Concepto, @Anulado, @Conciliado, @Contabilizado, @Ced_Usuario, @Asiento, @Num_Conciliacion, @CodigoMoneda, @TipoCambio, @OtrasDeducciones, @Renta, @Comision, @Retencion, @CuentaDeduccion, @Id_Operador);", con)
            cmd.SelectCommand.Transaction = Trans
            cmd.SelectCommand.Parameters.Add("@NumeroDocumento", SqlDbType.BigInt).Value = Me.txtDocumento.Text
            cmd.SelectCommand.Parameters.Add("@Id_CuentaBancaria", SqlDbType.Int).Value = Me.cboCuenta.SelectedValue
            cmd.SelectCommand.Parameters.Add("@Fecha", SqlDbType.DateTime).Value = Me.dtpDia.Value
            cmd.SelectCommand.Parameters.Add("@Monto", SqlDbType.Decimal).Value = CDec(Me.txtMontoTra.Text)
            cmd.SelectCommand.Parameters.Add("@Concepto", SqlDbType.NVarChar).Value = "Factura Venta"
            cmd.SelectCommand.Parameters.Add("@Anulado", SqlDbType.Bit).Value = 0
            cmd.SelectCommand.Parameters.Add("@Conciliado", SqlDbType.Bit).Value = 0
            cmd.SelectCommand.Parameters.Add("@Contabilizado", SqlDbType.Bit).Value = 0
            cmd.SelectCommand.Parameters.Add("@Ced_Usuario", SqlDbType.NVarChar).Value = Usuario.Cedula
            cmd.SelectCommand.Parameters.Add("@Asiento", SqlDbType.NVarChar).Value = NumAsiento
            cmd.SelectCommand.Parameters.Add("@Num_Conciliacion", SqlDbType.Int).Value = 0
            cmd.SelectCommand.Parameters.Add("@CodigoMoneda", SqlDbType.Int).Value = Me.cboMonedaTra.SelectedValue
            cmd.SelectCommand.Parameters.Add("@TipoCambio", SqlDbType.Decimal).Value = TipoCambio
            cmd.SelectCommand.Parameters.Add("@OtrasDeducciones", SqlDbType.Decimal).Value = 0
            cmd.SelectCommand.Parameters.Add("@Renta", SqlDbType.Decimal).Value = 0
            cmd.SelectCommand.Parameters.Add("@Comision", SqlDbType.Decimal).Value = 0
            cmd.SelectCommand.Parameters.Add("@Retencion", SqlDbType.Decimal).Value = 0
            cmd.SelectCommand.Parameters.Add("@CuentaDeduccion", SqlDbType.NVarChar).Value = ""
            cmd.SelectCommand.Parameters.Add("@Id_Operador", SqlDbType.Decimal).Value = 0
            cmd.SelectCommand.ExecuteNonQuery()

            cmd = New SqlDataAdapter("INSERT INTO Contabilidad.dbo.AsientosContables(NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio) VALUES (@NumAsiento, @Fecha, @IdNumDoc, @NumDoc, @Beneficiario, @TipoDoc, @Accion, @Anulado, @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Observaciones, @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio);", con)
            cmd.SelectCommand.Transaction = Trans
            cmd.SelectCommand.Parameters.Add("@NumAsiento", SqlDbType.NVarChar).Value = NumAsiento
            cmd.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = Me.dtpDia.Value.ToShortDateString
            cmd.SelectCommand.Parameters.Add("@IdNumDoc", SqlDbType.NVarChar).Value = 0
            cmd.SelectCommand.Parameters.Add("@NumDoc", SqlDbType.NVarChar).Value = Me.txtDocumento.Text
            cmd.SelectCommand.Parameters.Add("@Beneficiario", SqlDbType.NVarChar).Value = ""
            cmd.SelectCommand.Parameters.Add("@TipoDoc", SqlDbType.NVarChar).Value = 2
            cmd.SelectCommand.Parameters.Add("@Accion", SqlDbType.NVarChar).Value = "AUT"
            cmd.SelectCommand.Parameters.Add("@Anulado", SqlDbType.Bit).Value = 0
            cmd.SelectCommand.Parameters.Add("@FechaEntrada", SqlDbType.Date).Value = Date.Now
            cmd.SelectCommand.Parameters.Add("@Mayorizado", SqlDbType.Bit).Value = 0
            cmd.SelectCommand.Parameters.Add("@Periodo", SqlDbType.NVarChar).Value = Fx.BuscaPeriodo(Me.dtpDia.Value)
            cmd.SelectCommand.Parameters.Add("@NumMayorizado", SqlDbType.NVarChar).Value = 0
            cmd.SelectCommand.Parameters.Add("@Modulo", SqlDbType.NVarChar).Value = "Depositos"
            cmd.SelectCommand.Parameters.Add("@Observaciones", SqlDbType.NVarChar).Value = ""
            cmd.SelectCommand.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = Usuario.Nombre
            cmd.SelectCommand.Parameters.Add("@TotalDebe", SqlDbType.Float).Value = CDec(Me.txtMontoTra.Text)
            cmd.SelectCommand.Parameters.Add("@TotalHaber", SqlDbType.Float).Value = CDec(Me.txtMontoTra.Text)
            cmd.SelectCommand.Parameters.Add("@CodMoneda", SqlDbType.Float).Value = Me.cboMonedaTra.SelectedValue
            cmd.SelectCommand.Parameters.Add("@TipoCambio", SqlDbType.Float).Value = TipoCambio
            cmd.SelectCommand.ExecuteNonQuery()

            cmd = New SqlDataAdapter("INSERT INTO Contabilidad.dbo.DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreCuenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio)", con)
            cmd.SelectCommand.Transaction = Trans
            cmd.SelectCommand.Parameters.Add("@NumAsiento", SqlDbType.NVarChar).Value = NumAsiento
            cmd.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.NVarChar).Value = CuentaDebe
            cmd.SelectCommand.Parameters.Add("@NombreCuenta", SqlDbType.NVarChar).Value = DescripcionDebe
            cmd.SelectCommand.Parameters.Add("@Monto", SqlDbType.Float).Value = CDec(Me.txtMontoTra.Text)
            cmd.SelectCommand.Parameters.Add("@Debe", SqlDbType.Bit).Value = True
            cmd.SelectCommand.Parameters.Add("@Haber", SqlDbType.Bit).Value = False
            cmd.SelectCommand.Parameters.Add("@DescripcionAsiento", SqlDbType.NVarChar).Value = ""
            cmd.SelectCommand.Parameters.Add("@Tipocambio", SqlDbType.Float).Value = TipoCambio
            cmd.SelectCommand.ExecuteNonQuery()

            cmd = New SqlDataAdapter("INSERT INTO Contabilidad.dbo.DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreCuenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio)", con)
            cmd.SelectCommand.Transaction = Trans
            cmd.SelectCommand.Parameters.Add("@NumAsiento", SqlDbType.NVarChar).Value = NumAsiento
            cmd.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.NVarChar).Value = CuentaHaber
            cmd.SelectCommand.Parameters.Add("@NombreCuenta", SqlDbType.NVarChar).Value = DescripcionHaber
            cmd.SelectCommand.Parameters.Add("@Monto", SqlDbType.Float).Value = CDec(Me.txtMontoTra.Text)
            cmd.SelectCommand.Parameters.Add("@Debe", SqlDbType.Bit).Value = False
            cmd.SelectCommand.Parameters.Add("@Haber", SqlDbType.Bit).Value = True
            cmd.SelectCommand.Parameters.Add("@DescripcionAsiento", SqlDbType.NVarChar).Value = ""
            cmd.SelectCommand.Parameters.Add("@Tipocambio", SqlDbType.Float).Value = TipoCambio
            cmd.SelectCommand.ExecuteNonQuery()

            Trans.Commit()
            con.Close()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Private Sub btnCancelarTra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarTra.Click
        Me.pTransferencia.Visible = False
    End Sub

    Private Sub cboMonedaTra_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMonedaTra.SelectedIndexChanged
        Me.CargarBancos()
    End Sub

    Private Sub cboBancos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBancos.SelectedIndexChanged
        Me.CargarCuentas()
    End Sub

    Private Sub btnListoTra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListoTra.Click
        If Me.PasaTra = True Then Me.Registrar_Transferencia()
    End Sub

End Class
