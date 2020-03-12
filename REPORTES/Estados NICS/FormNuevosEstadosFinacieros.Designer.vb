<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNuevosEstadosFinacieros
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormNuevosEstadosFinacieros))
        Me.bdsMoneda = New System.Windows.Forms.BindingSource(Me.components)
        Me.DstNICs1 = New Contabilidad.dstNICs
        Me.grpPeriodo1 = New System.Windows.Forms.GroupBox
        Me.cboPeriodoT1 = New System.Windows.Forms.ComboBox
        Me.bdsPeriodo1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPeriodoFiscal1 = New System.Windows.Forms.ComboBox
        Me.bdsPeriodoF1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.grpPeriodo2 = New System.Windows.Forms.GroupBox
        Me.cboPeriodoT2 = New System.Windows.Forms.ComboBox
        Me.bdsPeriodo2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cboPeriodoFiscal2 = New System.Windows.Forms.ComboBox
        Me.bdsPeriodoF2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodoTableAdapter = New Contabilidad.dstNICsTableAdapters.PeriodoTableAdapter
        Me.PeriodoFiscalTableAdapter = New Contabilidad.dstNICsTableAdapters.PeriodoFiscalTableAdapter
        Me.MonedaTableAdapter = New Contabilidad.dstNICsTableAdapters.MonedaTableAdapter
        Me.Periodo1TableAdapter = New Contabilidad.dstNICsTableAdapters.Periodo1TableAdapter
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.grbMoneda = New System.Windows.Forms.GroupBox
        CType(Me.bdsMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DstNICs1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriodo1.SuspendLayout()
        CType(Me.bdsPeriodo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsPeriodoF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPeriodo2.SuspendLayout()
        CType(Me.bdsPeriodo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsPeriodoF2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'bdsMoneda
        '
        Me.bdsMoneda.DataMember = "Moneda"
        Me.bdsMoneda.DataSource = Me.DstNICs1
        '
        'DstNICs1
        '
        Me.DstNICs1.DataSetName = "dstNICs"
        Me.DstNICs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpPeriodo1
        '
        Me.grpPeriodo1.Controls.Add(Me.cboPeriodoT1)
        Me.grpPeriodo1.Controls.Add(Me.cboPeriodoFiscal1)
        Me.grpPeriodo1.Location = New System.Drawing.Point(12, 68)
        Me.grpPeriodo1.Name = "grpPeriodo1"
        Me.grpPeriodo1.Size = New System.Drawing.Size(200, 78)
        Me.grpPeriodo1.TabIndex = 1
        Me.grpPeriodo1.TabStop = False
        Me.grpPeriodo1.Text = "Periodo 1"
        '
        'cboPeriodoT1
        '
        Me.cboPeriodoT1.DataSource = Me.bdsPeriodo1
        Me.cboPeriodoT1.DisplayMember = "Periodo"
        Me.cboPeriodoT1.FormattingEnabled = True
        Me.cboPeriodoT1.Location = New System.Drawing.Point(6, 51)
        Me.cboPeriodoT1.Name = "cboPeriodoT1"
        Me.cboPeriodoT1.Size = New System.Drawing.Size(188, 21)
        Me.cboPeriodoT1.TabIndex = 1
        Me.cboPeriodoT1.ValueMember = "Id_Periodo"
        '
        'bdsPeriodo1
        '
        Me.bdsPeriodo1.DataMember = "Periodo"
        Me.bdsPeriodo1.DataSource = Me.DstNICs1
        '
        'cboPeriodoFiscal1
        '
        Me.cboPeriodoFiscal1.DataSource = Me.bdsPeriodoF1
        Me.cboPeriodoFiscal1.DisplayMember = "Anno"
        Me.cboPeriodoFiscal1.FormattingEnabled = True
        Me.cboPeriodoFiscal1.Location = New System.Drawing.Point(6, 19)
        Me.cboPeriodoFiscal1.Name = "cboPeriodoFiscal1"
        Me.cboPeriodoFiscal1.Size = New System.Drawing.Size(188, 21)
        Me.cboPeriodoFiscal1.TabIndex = 0
        Me.cboPeriodoFiscal1.ValueMember = "Id"
        '
        'bdsPeriodoF1
        '
        Me.bdsPeriodoF1.DataMember = "PeriodoFiscal"
        Me.bdsPeriodoF1.DataSource = Me.DstNICs1
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(237, 12)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(127, 40)
        Me.btnGenerar.TabIndex = 3
        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'grpPeriodo2
        '
        Me.grpPeriodo2.Controls.Add(Me.cboPeriodoT2)
        Me.grpPeriodo2.Controls.Add(Me.cboPeriodoFiscal2)
        Me.grpPeriodo2.Location = New System.Drawing.Point(237, 68)
        Me.grpPeriodo2.Name = "grpPeriodo2"
        Me.grpPeriodo2.Size = New System.Drawing.Size(200, 78)
        Me.grpPeriodo2.TabIndex = 7
        Me.grpPeriodo2.TabStop = False
        Me.grpPeriodo2.Text = "Periodo 2"
        '
        'cboPeriodoT2
        '
        Me.cboPeriodoT2.DataSource = Me.bdsPeriodo2
        Me.cboPeriodoT2.DisplayMember = "Periodo"
        Me.cboPeriodoT2.FormattingEnabled = True
        Me.cboPeriodoT2.Location = New System.Drawing.Point(6, 51)
        Me.cboPeriodoT2.Name = "cboPeriodoT2"
        Me.cboPeriodoT2.Size = New System.Drawing.Size(188, 21)
        Me.cboPeriodoT2.TabIndex = 1
        Me.cboPeriodoT2.ValueMember = "Id_Periodo"
        '
        'bdsPeriodo2
        '
        Me.bdsPeriodo2.DataMember = "Periodo1"
        Me.bdsPeriodo2.DataSource = Me.DstNICs1
        '
        'cboPeriodoFiscal2
        '
        Me.cboPeriodoFiscal2.DataSource = Me.bdsPeriodoF2
        Me.cboPeriodoFiscal2.DisplayMember = "Anno"
        Me.cboPeriodoFiscal2.FormattingEnabled = True
        Me.cboPeriodoFiscal2.Location = New System.Drawing.Point(6, 19)
        Me.cboPeriodoFiscal2.Name = "cboPeriodoFiscal2"
        Me.cboPeriodoFiscal2.Size = New System.Drawing.Size(188, 21)
        Me.cboPeriodoFiscal2.TabIndex = 0
        Me.cboPeriodoFiscal2.ValueMember = "Id"
        '
        'bdsPeriodoF2
        '
        Me.bdsPeriodoF2.DataMember = "PeriodoFiscal"
        Me.bdsPeriodoF2.DataSource = Me.DstNICs1
        '
        'PeriodoTableAdapter
        '
        Me.PeriodoTableAdapter.ClearBeforeFill = True
        '
        'PeriodoFiscalTableAdapter
        '
        Me.PeriodoFiscalTableAdapter.ClearBeforeFill = True
        '
        'MonedaTableAdapter
        '
        Me.MonedaTableAdapter.ClearBeforeFill = True
        '
        'Periodo1TableAdapter
        '
        Me.Periodo1TableAdapter.ClearBeforeFill = True
        '
        'cboMoneda
        '
        Me.cboMoneda.DataSource = Me.bdsMoneda
        Me.cboMoneda.DisplayMember = "MonedaNombre"
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(6, 19)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(188, 21)
        Me.cboMoneda.TabIndex = 0
        Me.cboMoneda.ValueMember = "CodMoneda"
        '
        'grbMoneda
        '
        Me.grbMoneda.Controls.Add(Me.cboMoneda)
        Me.grbMoneda.Location = New System.Drawing.Point(12, 12)
        Me.grbMoneda.Name = "grbMoneda"
        Me.grbMoneda.Size = New System.Drawing.Size(200, 50)
        Me.grbMoneda.TabIndex = 0
        Me.grbMoneda.TabStop = False
        Me.grbMoneda.Text = "Moneda"
        '
        'FormNuevosEstadosFinacieros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 160)
        Me.Controls.Add(Me.grpPeriodo2)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.grpPeriodo1)
        Me.Controls.Add(Me.grbMoneda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormNuevosEstadosFinacieros"
        Me.Text = "Generar Estados Financieros NICS"
        CType(Me.bdsMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DstNICs1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriodo1.ResumeLayout(False)
        CType(Me.bdsPeriodo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsPeriodoF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPeriodo2.ResumeLayout(False)
        CType(Me.bdsPeriodo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsPeriodoF2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbMoneda.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpPeriodo1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPeriodoFiscal1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents cboPeriodoT1 As System.Windows.Forms.ComboBox
    Friend WithEvents DstNICs1 As dstNICs
    Friend WithEvents bdsPeriodo1 As System.Windows.Forms.BindingSource
    Friend WithEvents grpPeriodo2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboPeriodoT2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboPeriodoFiscal2 As System.Windows.Forms.ComboBox
    Friend WithEvents bdsPeriodo2 As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodoTableAdapter As dstNICsTableAdapters.PeriodoTableAdapter
    Friend WithEvents bdsPeriodoF1 As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodoFiscalTableAdapter As dstNICsTableAdapters.PeriodoFiscalTableAdapter
    Friend WithEvents bdsPeriodoF2 As System.Windows.Forms.BindingSource
    Friend WithEvents bdsMoneda As System.Windows.Forms.BindingSource
    Friend WithEvents MonedaTableAdapter As dstNICsTableAdapters.MonedaTableAdapter
    Friend WithEvents Periodo1TableAdapter As dstNICsTableAdapters.Periodo1TableAdapter
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents grbMoneda As System.Windows.Forms.GroupBox
End Class
