<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNavegadorAsientos
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
		Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.lblTipoDocumento = New System.Windows.Forms.Label()
		Me.cbOrigen = New System.Windows.Forms.ComboBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtAsiento = New System.Windows.Forms.TextBox()
		Me.dgvAsientos = New System.Windows.Forms.DataGridView()
		Me.NumAsientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.OrigenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TiposDocumentoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.ObservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TotalDebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TotalHaberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.MonedaNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.TipoCambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.AnuladoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.bsAsiento = New System.Windows.Forms.BindingSource(Me.components)
		Me.DtsNavegadorAsientos1 = New Contabilidad.dtsNavegadorAsientos()
		Me.DataGridView2 = New System.Windows.Forms.DataGridView()
		Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.NombreCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.HaberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.DescripcionAsientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.bsDetalleAsiento = New System.Windows.Forms.BindingSource(Me.components)
		Me.cbTipoDocumento = New System.Windows.Forms.ComboBox()
		Me.bsTidoDocumento = New System.Windows.Forms.BindingSource(Me.components)
		Me.TiposDocumentosTableAdapter = New Contabilidad.dtsNavegadorAsientosTableAdapters.TiposDocumentosTableAdapter()
		Me.Vs_AsientoTableAdapter = New Contabilidad.dtsNavegadorAsientosTableAdapters.vs_AsientoTableAdapter()
		Me.DetallesAsientosContableTableAdapter = New Contabilidad.dtsNavegadorAsientosTableAdapters.DetallesAsientosContableTableAdapter()
		Me.bwCargar = New System.ComponentModel.BackgroundWorker()
		Me.lblDetalleAsiento = New System.Windows.Forms.Label()
		CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DtsNavegadorAsientos1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsDetalleAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.bsTidoDocumento, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dtpFechaInicio
		'
		Me.dtpFechaInicio.CustomFormat = "yyyy"
		Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaInicio.Location = New System.Drawing.Point(91, 24)
		Me.dtpFechaInicio.Name = "dtpFechaInicio"
		Me.dtpFechaInicio.Size = New System.Drawing.Size(88, 20)
		Me.dtpFechaInicio.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(14, 25)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(71, 13)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Fecha Inicio :"
		'
		'dtpFechaFinal
		'
		Me.dtpFechaFinal.CustomFormat = ""
		Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpFechaFinal.Location = New System.Drawing.Point(267, 23)
		Me.dtpFechaFinal.Name = "dtpFechaFinal"
		Me.dtpFechaFinal.Size = New System.Drawing.Size(88, 20)
		Me.dtpFechaFinal.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(193, 24)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(68, 13)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Fecha Final :"
		'
		'lblTipoDocumento
		'
		Me.lblTipoDocumento.AutoSize = True
		Me.lblTipoDocumento.Location = New System.Drawing.Point(658, 25)
		Me.lblTipoDocumento.Name = "lblTipoDocumento"
		Me.lblTipoDocumento.Size = New System.Drawing.Size(92, 13)
		Me.lblTipoDocumento.TabIndex = 8
		Me.lblTipoDocumento.Text = "Tipo Documento :"
		Me.lblTipoDocumento.Visible = False
		'
		'cbOrigen
		'
		Me.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbOrigen.FormattingEnabled = True
		Me.cbOrigen.Items.AddRange(New Object() {"TODOS", "CXC - Cuentas por Cobrar", "CXP - Cuentas por Pagar", "BCO - Módulo de Bancos", "PLA - Módulo de Planilla", "COM - Compras o Gastos", "CON - Asiento Manual"})
		Me.cbOrigen.Location = New System.Drawing.Point(439, 21)
		Me.cbOrigen.Name = "cbOrigen"
		Me.cbOrigen.Size = New System.Drawing.Size(188, 21)
		Me.cbOrigen.TabIndex = 9
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(389, 24)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(44, 13)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "Origen :"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(34, 75)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(51, 13)
		Me.Label7.TabIndex = 12
		Me.Label7.Text = "Asiento : "
		'
		'txtAsiento
		'
		Me.txtAsiento.Location = New System.Drawing.Point(91, 72)
		Me.txtAsiento.Name = "txtAsiento"
		Me.txtAsiento.Size = New System.Drawing.Size(264, 20)
		Me.txtAsiento.TabIndex = 13
		'
		'dgvAsientos
		'
		Me.dgvAsientos.AllowUserToAddRows = False
		Me.dgvAsientos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.dgvAsientos.AutoGenerateColumns = False
		Me.dgvAsientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.dgvAsientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvAsientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumAsientoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.OrigenDataGridViewTextBoxColumn, Me.TiposDocumentoDataGridViewTextBoxColumn, Me.ObservacionesDataGridViewTextBoxColumn, Me.TotalDebeDataGridViewTextBoxColumn, Me.TotalHaberDataGridViewTextBoxColumn, Me.MonedaNombreDataGridViewTextBoxColumn, Me.TipoCambioDataGridViewTextBoxColumn, Me.AnuladoDataGridViewCheckBoxColumn})
		Me.dgvAsientos.DataSource = Me.bsAsiento
		Me.dgvAsientos.Location = New System.Drawing.Point(9, 98)
		Me.dgvAsientos.Name = "dgvAsientos"
		Me.dgvAsientos.ReadOnly = True
		Me.dgvAsientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
		Me.dgvAsientos.Size = New System.Drawing.Size(963, 204)
		Me.dgvAsientos.TabIndex = 14
		'
		'NumAsientoDataGridViewTextBoxColumn
		'
		Me.NumAsientoDataGridViewTextBoxColumn.DataPropertyName = "NumAsiento"
		Me.NumAsientoDataGridViewTextBoxColumn.HeaderText = "Asiento"
		Me.NumAsientoDataGridViewTextBoxColumn.Name = "NumAsientoDataGridViewTextBoxColumn"
		Me.NumAsientoDataGridViewTextBoxColumn.ReadOnly = True
		'
		'FechaDataGridViewTextBoxColumn
		'
		Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
		Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
		Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
		Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
		'
		'OrigenDataGridViewTextBoxColumn
		'
		Me.OrigenDataGridViewTextBoxColumn.DataPropertyName = "Origen"
		Me.OrigenDataGridViewTextBoxColumn.HeaderText = "Origen"
		Me.OrigenDataGridViewTextBoxColumn.Name = "OrigenDataGridViewTextBoxColumn"
		Me.OrigenDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TiposDocumentoDataGridViewTextBoxColumn
		'
		Me.TiposDocumentoDataGridViewTextBoxColumn.DataPropertyName = "TiposDocumento"
		Me.TiposDocumentoDataGridViewTextBoxColumn.HeaderText = "Tipo Documento"
		Me.TiposDocumentoDataGridViewTextBoxColumn.Name = "TiposDocumentoDataGridViewTextBoxColumn"
		Me.TiposDocumentoDataGridViewTextBoxColumn.ReadOnly = True
		'
		'ObservacionesDataGridViewTextBoxColumn
		'
		Me.ObservacionesDataGridViewTextBoxColumn.DataPropertyName = "Observaciones"
		Me.ObservacionesDataGridViewTextBoxColumn.HeaderText = "Observaciones"
		Me.ObservacionesDataGridViewTextBoxColumn.Name = "ObservacionesDataGridViewTextBoxColumn"
		Me.ObservacionesDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TotalDebeDataGridViewTextBoxColumn
		'
		Me.TotalDebeDataGridViewTextBoxColumn.DataPropertyName = "TotalDebe"
		DataGridViewCellStyle11.Format = "N2"
		Me.TotalDebeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle11
		Me.TotalDebeDataGridViewTextBoxColumn.HeaderText = "Total Debe"
		Me.TotalDebeDataGridViewTextBoxColumn.Name = "TotalDebeDataGridViewTextBoxColumn"
		Me.TotalDebeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TotalHaberDataGridViewTextBoxColumn
		'
		Me.TotalHaberDataGridViewTextBoxColumn.DataPropertyName = "TotalHaber"
		DataGridViewCellStyle12.Format = "N2"
		DataGridViewCellStyle12.NullValue = Nothing
		Me.TotalHaberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle12
		Me.TotalHaberDataGridViewTextBoxColumn.HeaderText = "Total Haber"
		Me.TotalHaberDataGridViewTextBoxColumn.Name = "TotalHaberDataGridViewTextBoxColumn"
		Me.TotalHaberDataGridViewTextBoxColumn.ReadOnly = True
		'
		'MonedaNombreDataGridViewTextBoxColumn
		'
		Me.MonedaNombreDataGridViewTextBoxColumn.DataPropertyName = "MonedaNombre"
		Me.MonedaNombreDataGridViewTextBoxColumn.HeaderText = "Moneda"
		Me.MonedaNombreDataGridViewTextBoxColumn.Name = "MonedaNombreDataGridViewTextBoxColumn"
		Me.MonedaNombreDataGridViewTextBoxColumn.ReadOnly = True
		'
		'TipoCambioDataGridViewTextBoxColumn
		'
		Me.TipoCambioDataGridViewTextBoxColumn.DataPropertyName = "TipoCambio"
		DataGridViewCellStyle13.Format = "N2"
		Me.TipoCambioDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle13
		Me.TipoCambioDataGridViewTextBoxColumn.HeaderText = "Tipo Cambio"
		Me.TipoCambioDataGridViewTextBoxColumn.Name = "TipoCambioDataGridViewTextBoxColumn"
		Me.TipoCambioDataGridViewTextBoxColumn.ReadOnly = True
		'
		'AnuladoDataGridViewCheckBoxColumn
		'
		Me.AnuladoDataGridViewCheckBoxColumn.DataPropertyName = "Anulado"
		Me.AnuladoDataGridViewCheckBoxColumn.HeaderText = "Anulado"
		Me.AnuladoDataGridViewCheckBoxColumn.Name = "AnuladoDataGridViewCheckBoxColumn"
		Me.AnuladoDataGridViewCheckBoxColumn.ReadOnly = True
		'
		'bsAsiento
		'
		Me.bsAsiento.DataMember = "vs_Asiento"
		Me.bsAsiento.DataSource = Me.DtsNavegadorAsientos1
		'
		'DtsNavegadorAsientos1
		'
		Me.DtsNavegadorAsientos1.DataSetName = "dtsNavegadorAsientos"
		Me.DtsNavegadorAsientos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'DataGridView2
		'
		Me.DataGridView2.AllowUserToAddRows = False
		Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.DataGridView2.AutoGenerateColumns = False
		Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
		Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CuentaDataGridViewTextBoxColumn, Me.NombreCuentaDataGridViewTextBoxColumn, Me.DebeDataGridViewTextBoxColumn, Me.HaberDataGridViewTextBoxColumn, Me.DescripcionAsientoDataGridViewTextBoxColumn})
		Me.DataGridView2.DataSource = Me.bsDetalleAsiento
		Me.DataGridView2.Location = New System.Drawing.Point(9, 339)
		Me.DataGridView2.Name = "DataGridView2"
		Me.DataGridView2.Size = New System.Drawing.Size(963, 212)
		Me.DataGridView2.TabIndex = 15
		'
		'CuentaDataGridViewTextBoxColumn
		'
		Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
		Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta Contable"
		Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
		'
		'NombreCuentaDataGridViewTextBoxColumn
		'
		Me.NombreCuentaDataGridViewTextBoxColumn.DataPropertyName = "NombreCuenta"
		Me.NombreCuentaDataGridViewTextBoxColumn.HeaderText = "Nombre Cuenta"
		Me.NombreCuentaDataGridViewTextBoxColumn.Name = "NombreCuentaDataGridViewTextBoxColumn"
		'
		'DebeDataGridViewTextBoxColumn
		'
		Me.DebeDataGridViewTextBoxColumn.DataPropertyName = "Debe"
		DataGridViewCellStyle14.Format = "N2"
		Me.DebeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
		Me.DebeDataGridViewTextBoxColumn.HeaderText = "Debe"
		Me.DebeDataGridViewTextBoxColumn.Name = "DebeDataGridViewTextBoxColumn"
		Me.DebeDataGridViewTextBoxColumn.ReadOnly = True
		'
		'HaberDataGridViewTextBoxColumn
		'
		Me.HaberDataGridViewTextBoxColumn.DataPropertyName = "Haber"
		DataGridViewCellStyle15.Format = "N2"
		Me.HaberDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
		Me.HaberDataGridViewTextBoxColumn.HeaderText = "Haber"
		Me.HaberDataGridViewTextBoxColumn.Name = "HaberDataGridViewTextBoxColumn"
		Me.HaberDataGridViewTextBoxColumn.ReadOnly = True
		'
		'DescripcionAsientoDataGridViewTextBoxColumn
		'
		Me.DescripcionAsientoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionAsiento"
		Me.DescripcionAsientoDataGridViewTextBoxColumn.HeaderText = "Observación"
		Me.DescripcionAsientoDataGridViewTextBoxColumn.Name = "DescripcionAsientoDataGridViewTextBoxColumn"
		'
		'bsDetalleAsiento
		'
		Me.bsDetalleAsiento.DataMember = "DetallesAsientosContable"
		Me.bsDetalleAsiento.DataSource = Me.DtsNavegadorAsientos1
		'
		'cbTipoDocumento
		'
		Me.cbTipoDocumento.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsTidoDocumento, "Id", True))
		Me.cbTipoDocumento.DataSource = Me.bsTidoDocumento
		Me.cbTipoDocumento.DisplayMember = "Descripcion"
		Me.cbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbTipoDocumento.Location = New System.Drawing.Point(756, 22)
		Me.cbTipoDocumento.Name = "cbTipoDocumento"
		Me.cbTipoDocumento.Size = New System.Drawing.Size(216, 21)
		Me.cbTipoDocumento.TabIndex = 101
		Me.cbTipoDocumento.ValueMember = "Id"
		Me.cbTipoDocumento.Visible = False
		'
		'bsTidoDocumento
		'
		Me.bsTidoDocumento.DataMember = "TiposDocumentos"
		Me.bsTidoDocumento.DataSource = Me.DtsNavegadorAsientos1
		'
		'TiposDocumentosTableAdapter
		'
		Me.TiposDocumentosTableAdapter.ClearBeforeFill = True
		'
		'Vs_AsientoTableAdapter
		'
		Me.Vs_AsientoTableAdapter.ClearBeforeFill = True
		'
		'DetallesAsientosContableTableAdapter
		'
		Me.DetallesAsientosContableTableAdapter.ClearBeforeFill = True
		'
		'lblDetalleAsiento
		'
		Me.lblDetalleAsiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblDetalleAsiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.lblDetalleAsiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDetalleAsiento.Location = New System.Drawing.Point(9, 313)
		Me.lblDetalleAsiento.Name = "lblDetalleAsiento"
		Me.lblDetalleAsiento.Size = New System.Drawing.Size(963, 23)
		Me.lblDetalleAsiento.TabIndex = 102
		Me.lblDetalleAsiento.Text = "Detalle de Asiento"
		Me.lblDetalleAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'frmNavegadorAsientos
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(984, 561)
		Me.Controls.Add(Me.lblDetalleAsiento)
		Me.Controls.Add(Me.cbTipoDocumento)
		Me.Controls.Add(Me.DataGridView2)
		Me.Controls.Add(Me.dgvAsientos)
		Me.Controls.Add(Me.txtAsiento)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.cbOrigen)
		Me.Controls.Add(Me.lblTipoDocumento)
		Me.Controls.Add(Me.dtpFechaFinal)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.dtpFechaInicio)
		Me.Controls.Add(Me.Label3)
		Me.Name = "frmNavegadorAsientos"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Navegador Asientos"
		CType(Me.dgvAsientos, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DtsNavegadorAsientos1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsDetalleAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.bsTidoDocumento, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dtpFechaInicio As DateTimePicker
	Friend WithEvents Label3 As Label
	Friend WithEvents dtpFechaFinal As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents lblTipoDocumento As Label
	Friend WithEvents cbOrigen As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents Label7 As Label
	Friend WithEvents txtAsiento As TextBox
	Friend WithEvents dgvAsientos As DataGridView
	Friend WithEvents DataGridView2 As DataGridView
	Friend WithEvents cbTipoDocumento As ComboBox
	Friend WithEvents DtsNavegadorAsientos1 As dtsNavegadorAsientos
	Friend WithEvents bsTidoDocumento As BindingSource
	Friend WithEvents TiposDocumentosTableAdapter As dtsNavegadorAsientosTableAdapters.TiposDocumentosTableAdapter
	Friend WithEvents bsAsiento As BindingSource
	Friend WithEvents Vs_AsientoTableAdapter As dtsNavegadorAsientosTableAdapters.vs_AsientoTableAdapter
	Friend WithEvents NumAsientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents OrigenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TiposDocumentoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents ObservacionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TotalDebeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TotalHaberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents MonedaNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents TipoCambioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents AnuladoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
	Friend WithEvents bsDetalleAsiento As BindingSource
	Friend WithEvents DetallesAsientosContableTableAdapter As dtsNavegadorAsientosTableAdapters.DetallesAsientosContableTableAdapter
	Friend WithEvents CuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents NombreCuentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DebeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents HaberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents DescripcionAsientoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
	Friend WithEvents bwCargar As System.ComponentModel.BackgroundWorker
	Friend WithEvents lblDetalleAsiento As Label
End Class
