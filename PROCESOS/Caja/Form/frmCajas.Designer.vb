<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajas))
        Me.dgvGastos = New System.Windows.Forms.DataGridView()
        Me.btAgregar = New System.Windows.Forms.Button()
        Me.dtpF2 = New System.Windows.Forms.DateTimePicker()
        Me.dtpF1 = New System.Windows.Forms.DateTimePicker()
        Me.chEntreFechas = New System.Windows.Forms.CheckBox()
        Me.chVerReintegrosAnulados = New System.Windows.Forms.CheckBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btVer = New System.Windows.Forms.Button()
        Me.btBuscar = New System.Windows.Forms.Button()
        Me.IdTramite = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Documento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anulada = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvGastos
        '
        Me.dgvGastos.AllowUserToAddRows = False
        Me.dgvGastos.AllowUserToDeleteRows = False
        Me.dgvGastos.AllowUserToOrderColumns = True
        Me.dgvGastos.AllowUserToResizeRows = False
        Me.dgvGastos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.dgvGastos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdTramite, Me.Documento, Me.Descripcion, Me.Usuario, Me.Fecha, Me.Monto, Me.Anulada})
        Me.dgvGastos.EnableHeadersVisualStyles = False
        Me.dgvGastos.Location = New System.Drawing.Point(3, 28)
        Me.dgvGastos.Name = "dgvGastos"
        Me.dgvGastos.ReadOnly = True
        Me.dgvGastos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvGastos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvGastos.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgvGastos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvGastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGastos.Size = New System.Drawing.Size(745, 437)
        Me.dgvGastos.TabIndex = 5
        '
        'btAgregar
        '
        Me.btAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAgregar.ForeColor = System.Drawing.Color.White
        Me.btAgregar.Location = New System.Drawing.Point(754, 75)
        Me.btAgregar.Name = "btAgregar"
        Me.btAgregar.Size = New System.Drawing.Size(85, 42)
        Me.btAgregar.TabIndex = 6
        Me.btAgregar.Text = "Crear"
        Me.btAgregar.UseVisualStyleBackColor = False
        '
        'dtpF2
        '
        Me.dtpF2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpF2.Location = New System.Drawing.Point(623, 4)
        Me.dtpF2.Name = "dtpF2"
        Me.dtpF2.Size = New System.Drawing.Size(109, 20)
        Me.dtpF2.TabIndex = 2
        Me.dtpF2.Visible = False
        '
        'dtpF1
        '
        Me.dtpF1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpF1.Location = New System.Drawing.Point(508, 4)
        Me.dtpF1.Name = "dtpF1"
        Me.dtpF1.Size = New System.Drawing.Size(109, 20)
        Me.dtpF1.TabIndex = 1
        Me.dtpF1.Visible = False
        '
        'chEntreFechas
        '
        Me.chEntreFechas.AutoSize = True
        Me.chEntreFechas.Location = New System.Drawing.Point(413, 4)
        Me.chEntreFechas.Name = "chEntreFechas"
        Me.chEntreFechas.Size = New System.Drawing.Size(89, 17)
        Me.chEntreFechas.TabIndex = 23
        Me.chEntreFechas.Text = "Entre Fechas"
        Me.chEntreFechas.UseVisualStyleBackColor = True
        '
        'chVerReintegrosAnulados
        '
        Me.chVerReintegrosAnulados.AutoSize = True
        Me.chVerReintegrosAnulados.Location = New System.Drawing.Point(738, 4)
        Me.chVerReintegrosAnulados.Name = "chVerReintegrosAnulados"
        Me.chVerReintegrosAnulados.Size = New System.Drawing.Size(88, 17)
        Me.chVerReintegrosAnulados.TabIndex = 3
        Me.chVerReintegrosAnulados.Text = "Ver anulados"
        Me.chVerReintegrosAnulados.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.chVerReintegrosAnulados.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBuscar.Location = New System.Drawing.Point(50, 4)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(359, 20)
        Me.txtBuscar.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Buscar:"
        '
        'btVer
        '
        Me.btVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btVer.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btVer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btVer.ForeColor = System.Drawing.Color.White
        Me.btVer.Location = New System.Drawing.Point(754, 123)
        Me.btVer.Name = "btVer"
        Me.btVer.Size = New System.Drawing.Size(85, 42)
        Me.btVer.TabIndex = 7
        Me.btVer.Text = "Ver"
        Me.btVer.UseVisualStyleBackColor = False
        '
        'btBuscar
        '
        Me.btBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(177, Byte), Integer))
        Me.btBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBuscar.ForeColor = System.Drawing.Color.White
        Me.btBuscar.Location = New System.Drawing.Point(754, 27)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(85, 42)
        Me.btBuscar.TabIndex = 4
        Me.btBuscar.Text = "Buscar"
        Me.btBuscar.UseVisualStyleBackColor = False
        '
        'IdTramite
        '
        Me.IdTramite.DataPropertyName = "IdCaja"
        Me.IdTramite.HeaderText = "ID"
        Me.IdTramite.Name = "IdTramite"
        Me.IdTramite.ReadOnly = True
        '
        'Documento
        '
        Me.Documento.DataPropertyName = "Cheque"
        Me.Documento.HeaderText = "Cheque"
        Me.Documento.Name = "Documento"
        Me.Documento.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "CuentaBanc"
        Me.Descripcion.HeaderText = "CuentaBanc."
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.DataPropertyName = "Fecha"
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Monto
        '
        Me.Monto.DataPropertyName = "Monto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.Monto.DefaultCellStyle = DataGridViewCellStyle2
        Me.Monto.HeaderText = "Monto"
        Me.Monto.Name = "Monto"
        Me.Monto.ReadOnly = True
        '
        'Anulada
        '
        Me.Anulada.DataPropertyName = "Anulada"
        Me.Anulada.HeaderText = "Anulada"
        Me.Anulada.Name = "Anulada"
        Me.Anulada.ReadOnly = True
        '
        'frmCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(844, 469)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.btVer)
        Me.Controls.Add(Me.dtpF2)
        Me.Controls.Add(Me.dtpF1)
        Me.Controls.Add(Me.chEntreFechas)
        Me.Controls.Add(Me.chVerReintegrosAnulados)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAgregar)
        Me.Controls.Add(Me.dgvGastos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(860, 508)
        Me.Name = "frmCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajas"
        CType(Me.dgvGastos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvGastos As DataGridView
    Friend WithEvents btAgregar As Button
    Friend WithEvents dtpF2 As DateTimePicker
    Friend WithEvents dtpF1 As DateTimePicker
    Friend WithEvents chEntreFechas As CheckBox
    Friend WithEvents chVerReintegrosAnulados As CheckBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btVer As Button
    Friend WithEvents btBuscar As Button
    Friend WithEvents IdTramite As DataGridViewTextBoxColumn
    Friend WithEvents Documento As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Fecha As DataGridViewTextBoxColumn
    Friend WithEvents Monto As DataGridViewTextBoxColumn
    Friend WithEvents Anulada As DataGridViewCheckBoxColumn
End Class
