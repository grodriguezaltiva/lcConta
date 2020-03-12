<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Me.pnControles = New System.Windows.Forms.Panel()
        Me.btAnular = New System.Windows.Forms.Button()
        Me.btAceptar = New System.Windows.Forms.Button()
        Me.btImprimir = New System.Windows.Forms.Button()
        Me.pnCheque = New System.Windows.Forms.Panel()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtPortador = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTipoCambioDolar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btActualizar = New System.Windows.Forms.Button()
        Me.txtTramiteID = New System.Windows.Forms.TextBox()
        Me.lbTramiteID = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCheque = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCuentaBanc = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBancos = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuentaCont = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Pagada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDocumento = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtMontoMovimiento = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCuentaContable = New System.Windows.Forms.TextBox()
        Me.lbCuentaContable = New System.Windows.Forms.Label()
        Me.txtNombreCuenta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.pnMovimiento = New System.Windows.Forms.Panel()
        Me.split = New System.Windows.Forms.SplitContainer()
        Me.lbANULADA = New System.Windows.Forms.Label()
        Me.pnControles.SuspendLayout()
        Me.pnCheque.SuspendLayout()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnMovimiento.SuspendLayout()
        Me.split.Panel1.SuspendLayout()
        Me.split.Panel2.SuspendLayout()
        Me.split.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnControles
        '
        Me.pnControles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnControles.Controls.Add(Me.btAnular)
        Me.pnControles.Controls.Add(Me.btAceptar)
        Me.pnControles.Controls.Add(Me.btImprimir)
        Me.pnControles.Enabled = False
        Me.pnControles.Location = New System.Drawing.Point(633, 307)
        Me.pnControles.Name = "pnControles"
        Me.pnControles.Size = New System.Drawing.Size(97, 147)
        Me.pnControles.TabIndex = 16
        '
        'btAnular
        '
        Me.btAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAnular.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAnular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAnular.ForeColor = System.Drawing.Color.White
        Me.btAnular.Location = New System.Drawing.Point(9, 4)
        Me.btAnular.Name = "btAnular"
        Me.btAnular.Size = New System.Drawing.Size(85, 42)
        Me.btAnular.TabIndex = 2
        Me.btAnular.Text = "Anular"
        Me.btAnular.UseVisualStyleBackColor = False
        '
        'btAceptar
        '
        Me.btAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAceptar.ForeColor = System.Drawing.Color.White
        Me.btAceptar.Location = New System.Drawing.Point(9, 100)
        Me.btAceptar.Name = "btAceptar"
        Me.btAceptar.Size = New System.Drawing.Size(85, 42)
        Me.btAceptar.TabIndex = 0
        Me.btAceptar.Text = "Guardar"
        Me.btAceptar.UseVisualStyleBackColor = False
        '
        'btImprimir
        '
        Me.btImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btImprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btImprimir.ForeColor = System.Drawing.Color.White
        Me.btImprimir.Location = New System.Drawing.Point(9, 52)
        Me.btImprimir.Name = "btImprimir"
        Me.btImprimir.Size = New System.Drawing.Size(85, 42)
        Me.btImprimir.TabIndex = 1
        Me.btImprimir.Text = "Imprimir"
        Me.btImprimir.UseVisualStyleBackColor = False
        '
        'pnCheque
        '
        Me.pnCheque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnCheque.Controls.Add(Me.txtObservacion)
        Me.pnCheque.Controls.Add(Me.Label14)
        Me.pnCheque.Controls.Add(Me.txtPortador)
        Me.pnCheque.Controls.Add(Me.Label13)
        Me.pnCheque.Controls.Add(Me.txtTipoCambioDolar)
        Me.pnCheque.Controls.Add(Me.Label6)
        Me.pnCheque.Controls.Add(Me.btActualizar)
        Me.pnCheque.Controls.Add(Me.txtTramiteID)
        Me.pnCheque.Controls.Add(Me.lbTramiteID)
        Me.pnCheque.Controls.Add(Me.dtpFecha)
        Me.pnCheque.Controls.Add(Me.Label5)
        Me.pnCheque.Controls.Add(Me.txtMonto)
        Me.pnCheque.Controls.Add(Me.Label4)
        Me.pnCheque.Controls.Add(Me.txtCheque)
        Me.pnCheque.Controls.Add(Me.Label3)
        Me.pnCheque.Controls.Add(Me.cbCuentaBanc)
        Me.pnCheque.Controls.Add(Me.Label2)
        Me.pnCheque.Controls.Add(Me.cbBancos)
        Me.pnCheque.Controls.Add(Me.Label1)
        Me.pnCheque.Enabled = False
        Me.pnCheque.Location = New System.Drawing.Point(12, 277)
        Me.pnCheque.Name = "pnCheque"
        Me.pnCheque.Size = New System.Drawing.Size(615, 177)
        Me.pnCheque.TabIndex = 8
        '
        'txtObservacion
        '
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.Location = New System.Drawing.Point(93, 28)
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(501, 20)
        Me.txtObservacion.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Observación:"
        '
        'txtPortador
        '
        Me.txtPortador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPortador.Location = New System.Drawing.Point(93, 3)
        Me.txtPortador.Name = "txtPortador"
        Me.txtPortador.Size = New System.Drawing.Size(501, 20)
        Me.txtPortador.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 3)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Portador:"
        '
        'txtTipoCambioDolar
        '
        Me.txtTipoCambioDolar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipoCambioDolar.Location = New System.Drawing.Point(433, 54)
        Me.txtTipoCambioDolar.Name = "txtTipoCambioDolar"
        Me.txtTipoCambioDolar.Size = New System.Drawing.Size(162, 20)
        Me.txtTipoCambioDolar.TabIndex = 5
        Me.txtTipoCambioDolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tipo Cambio $"
        '
        'btActualizar
        '
        Me.btActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btActualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btActualizar.ForeColor = System.Drawing.Color.White
        Me.btActualizar.Location = New System.Drawing.Point(93, 138)
        Me.btActualizar.Name = "btActualizar"
        Me.btActualizar.Size = New System.Drawing.Size(85, 30)
        Me.btActualizar.TabIndex = 9
        Me.btActualizar.Text = "Actualizar"
        Me.btActualizar.UseVisualStyleBackColor = False
        '
        'txtTramiteID
        '
        Me.txtTramiteID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTramiteID.Location = New System.Drawing.Point(433, 148)
        Me.txtTramiteID.Name = "txtTramiteID"
        Me.txtTramiteID.ReadOnly = True
        Me.txtTramiteID.Size = New System.Drawing.Size(162, 20)
        Me.txtTramiteID.TabIndex = 8
        '
        'lbTramiteID
        '
        Me.lbTramiteID.AutoSize = True
        Me.lbTramiteID.Location = New System.Drawing.Point(355, 148)
        Me.lbTramiteID.Name = "lbTramiteID"
        Me.lbTramiteID.Size = New System.Drawing.Size(59, 13)
        Me.lbTramiteID.TabIndex = 10
        Me.lbTramiteID.Text = "ID Tramite:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(433, 110)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(162, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(355, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha:"
        '
        'txtMonto
        '
        Me.txtMonto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMonto.Location = New System.Drawing.Point(433, 84)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.ReadOnly = True
        Me.txtMonto.Size = New System.Drawing.Size(162, 20)
        Me.txtMonto.TabIndex = 7
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Monto:"
        '
        'txtCheque
        '
        Me.txtCheque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCheque.Location = New System.Drawing.Point(93, 110)
        Me.txtCheque.Name = "txtCheque"
        Me.txtCheque.Size = New System.Drawing.Size(242, 20)
        Me.txtCheque.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cheque:"
        '
        'cbCuentaBanc
        '
        Me.cbCuentaBanc.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbCuentaBanc.DisplayMember = "Cuenta"
        Me.cbCuentaBanc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCuentaBanc.FormattingEnabled = True
        Me.cbCuentaBanc.Location = New System.Drawing.Point(93, 81)
        Me.cbCuentaBanc.Name = "cbCuentaBanc"
        Me.cbCuentaBanc.Size = New System.Drawing.Size(242, 21)
        Me.cbCuentaBanc.TabIndex = 3
        Me.cbCuentaBanc.ValueMember = "Id_CuentaBancaria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cuenta Banc:"
        '
        'cbBancos
        '
        Me.cbBancos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbBancos.DisplayMember = "Descripcion"
        Me.cbBancos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbBancos.FormattingEnabled = True
        Me.cbBancos.Location = New System.Drawing.Point(93, 54)
        Me.cbBancos.Name = "cbBancos"
        Me.cbBancos.Size = New System.Drawing.Size(242, 21)
        Me.cbBancos.TabIndex = 2
        Me.cbBancos.ValueMember = "Codigo_banco"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bancos:"
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToOrderColumns = True
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvGastos.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvGastos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvGastos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvGastos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGastos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvGastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Fecha, Me.Documento, Me.Descripcion, Me.CuentaCont, Me.Usuario, Me.Monto, Me.Pagada})
        Me.dgvGastos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGastos.EnableHeadersVisualStyles = False
        Me.dgvGastos.Location = New System.Drawing.Point(0, 0)
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGastos.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGastos.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGastos.Size = New System.Drawing.Size(726, 169)
        Me.dgvGastos.TabIndex = 7
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Fecha.DefaultCellStyle = DataGridViewCellStyle2
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Documento
        '
        Me.Documento.DataPropertyName = "Documento"
        Me.Documento.HeaderText = "Documento"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'CuentaCont
        '
        Me.CuentaCont.DataPropertyName = "CuentaCont"
        Me.CuentaCont.HeaderText = "CuentaCont"
        Me.CuentaCont.Name = "CuentaCont"
        Me.CuentaCont.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "0"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle3
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Pagada
        '
        Me.Pagada.DataPropertyName = "Pagada"
        Me.Pagada.HeaderText = "Pagada"
        Me.Pagada.Name = "Pagada"
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregar.ForeColor = System.Drawing.Color.White
        Me.btAgregar.Location = New System.Drawing.Point(630, 13)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(85, 42)
        Me.btAgregar.TabIndex = 6
        Me.btAgregar.Text = "Agregar"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Documento:"
        '
        'txtDocumento
        '
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumento.Location = New System.Drawing.Point(83, 13)
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Size = New System.Drawing.Size(108, 20)
        Me.txtDocumento.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(397, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Fecha:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(443, 38)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(162, 20)
        Me.DateTimePicker2.TabIndex = 5
        '
        'txtMontoMovimiento
        '
        Me.txtMontoMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMontoMovimiento.Location = New System.Drawing.Point(443, 13)
        Me.txtMontoMovimiento.Name = "txtMontoMovimiento"
        Me.txtMontoMovimiento.Size = New System.Drawing.Size(162, 20)
        Me.txtMontoMovimiento.TabIndex = 4
        Me.txtMontoMovimiento.Text = "0"
        Me.txtMontoMovimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(397, 13)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Monto:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(83, 38)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(308, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 38)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Descripción:"
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuentaContable.Location = New System.Drawing.Point(83, 63)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(242, 20)
        Me.txtCuentaContable.TabIndex = 3
        '
        'lbCuentaContable
        '
        Me.lbCuentaContable.AutoSize = True
        Me.lbCuentaContable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCuentaContable.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lbCuentaContable.Location = New System.Drawing.Point(8, 63)
        Me.lbCuentaContable.Name = "lbCuentaContable"
        Me.lbCuentaContable.Size = New System.Drawing.Size(75, 13)
        Me.lbCuentaContable.TabIndex = 28
        Me.lbCuentaContable.Text = "Cuenta Conta:"
        '
        'txtNombreCuenta
        '
        Me.txtNombreCuenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCuenta.Location = New System.Drawing.Point(331, 63)
        Me.txtNombreCuenta.Name = "txtNombreCuenta"
        Me.txtNombreCuenta.ReadOnly = True
        Me.txtNombreCuenta.Size = New System.Drawing.Size(274, 20)
        Me.txtNombreCuenta.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(197, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Usuario:"
        '
        'cbUsuario
        '
        Me.cbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbUsuario.DisplayMember = "Cuenta"
        Me.cbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(249, 12)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(142, 21)
        Me.cbUsuario.TabIndex = 1
        Me.cbUsuario.ValueMember = "Id_CuentaBancaria"
        '
        'lbEstado
        '
        Me.lbEstado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(12, 458)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(29, 13)
        Me.lbEstado.TabIndex = 33
        Me.lbEstado.Text = "Listo"
        '
        'pnMovimiento
        '
        Me.pnMovimiento.Controls.Add(Me.Label7)
        Me.pnMovimiento.Controls.Add(Me.btAgregar)
        Me.pnMovimiento.Controls.Add(Me.cbUsuario)
        Me.pnMovimiento.Controls.Add(Me.txtDocumento)
        Me.pnMovimiento.Controls.Add(Me.Label12)
        Me.pnMovimiento.Controls.Add(Me.Label8)
        Me.pnMovimiento.Controls.Add(Me.txtNombreCuenta)
        Me.pnMovimiento.Controls.Add(Me.DateTimePicker2)
        Me.pnMovimiento.Controls.Add(Me.txtCuentaContable)
        Me.pnMovimiento.Controls.Add(Me.Label9)
        Me.pnMovimiento.Controls.Add(Me.lbCuentaContable)
        Me.pnMovimiento.Controls.Add(Me.txtMontoMovimiento)
        Me.pnMovimiento.Controls.Add(Me.txtDescripcion)
        Me.pnMovimiento.Controls.Add(Me.Label10)
        Me.pnMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnMovimiento.Location = New System.Drawing.Point(0, 0)
        Me.pnMovimiento.Name = "pnMovimiento"
        Me.pnMovimiento.Size = New System.Drawing.Size(726, 92)
        Me.pnMovimiento.TabIndex = 0
        '
        'split
        '
        Me.split.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.split.Location = New System.Drawing.Point(12, 3)
        Me.split.Name = "split"
        Me.split.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'split.Panel1
        '
        Me.split.Panel1.Controls.Add(Me.pnMovimiento)
        '
        'split.Panel2
        '
        Me.split.Panel2.Controls.Add(Me.lbANULADA)
        Me.split.Panel2.Controls.Add(Me.dgvGastos)
        Me.split.Size = New System.Drawing.Size(726, 265)
        Me.split.SplitterDistance = 92
        Me.split.TabIndex = 34
        '
        'lbANULADA
        '
        Me.lbANULADA.AutoSize = True
        Me.lbANULADA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbANULADA.ForeColor = System.Drawing.Color.Red
        Me.lbANULADA.Location = New System.Drawing.Point(327, 78)
        Me.lbANULADA.Name = "lbANULADA"
        Me.lbANULADA.Size = New System.Drawing.Size(106, 24)
        Me.lbANULADA.TabIndex = 8
        Me.lbANULADA.Text = "ANULADA"
        Me.lbANULADA.Visible = False
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(742, 480)
        Me.Controls.Add(Me.split)
        Me.Controls.Add(Me.lbEstado)
        Me.Controls.Add(Me.pnControles)
        Me.Controls.Add(Me.pnCheque)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(758, 519)
        Me.Name = "frmCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja Chica"
        Me.pnControles.ResumeLayout(False)
        Me.pnCheque.ResumeLayout(False)
        Me.pnCheque.PerformLayout()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnMovimiento.ResumeLayout(False)
        Me.pnMovimiento.PerformLayout()
        Me.split.Panel1.ResumeLayout(False)
        Me.split.Panel2.ResumeLayout(False)
        Me.split.Panel2.PerformLayout()
        Me.split.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnControles As Panel
    Friend WithEvents btAnular As Button
    Friend WithEvents btAceptar As Button
    Friend WithEvents btImprimir As Button
    Friend WithEvents pnCheque As Panel
    Friend WithEvents txtTipoCambioDolar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btActualizar As Button
    Friend WithEvents txtTramiteID As TextBox
    Friend WithEvents lbTramiteID As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCheque As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCuentaBanc As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbBancos As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvGastos As DataGridView
    Friend WithEvents btAgregar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDocumento As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents txtMontoMovimiento As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtCuentaContable As TextBox
    Friend WithEvents lbCuentaContable As Label
    Friend WithEvents txtNombreCuenta As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents lbEstado As Label
    Friend WithEvents txtObservacion As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtPortador As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents CuentaCont As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Pagada As DataGridViewCheckBoxColumn
    Friend WithEvents pnMovimiento As Panel
    Friend WithEvents split As SplitContainer
    Friend WithEvents lbANULADA As Label
End Class
