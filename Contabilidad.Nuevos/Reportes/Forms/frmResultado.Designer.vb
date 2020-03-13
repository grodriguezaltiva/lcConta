<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmResultado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultado))
        Me.rbAnual = New System.Windows.Forms.RadioButton()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.crv = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.nuCantPeriodos = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMes = New System.Windows.Forms.Label()
        Me.cbMes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nuAño = New System.Windows.Forms.NumericUpDown()
        Me.chExcluirCierre = New System.Windows.Forms.CheckBox()
        Me.btMostrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbMoneda = New System.Windows.Forms.ComboBox()
        Me.MonedaBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.dts = New LcConta.Nuevos.dtsResultado()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbBalance = New System.Windows.Forms.RadioButton()
        Me.rbEstadoResultado = New System.Windows.Forms.RadioButton()
        Me.ResultadoBS = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nuNivel = New System.Windows.Forms.NumericUpDown()
        CType(Me.nuCantPeriodos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuAño, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MonedaBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ResultadoBS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nuNivel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbAnual
        '
        Me.rbAnual.AutoSize = True
        Me.rbAnual.Location = New System.Drawing.Point(77, 17)
        Me.rbAnual.Name = "rbAnual"
        Me.rbAnual.Size = New System.Drawing.Size(52, 17)
        Me.rbAnual.TabIndex = 0
        Me.rbAnual.Text = "Anual"
        Me.rbAnual.UseVisualStyleBackColor = True
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.Checked = True
        Me.rbMensual.Location = New System.Drawing.Point(6, 17)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(64, 17)
        Me.rbMensual.TabIndex = 1
        Me.rbMensual.TabStop = True
        Me.rbMensual.Text = "Mensual"
        Me.rbMensual.UseVisualStyleBackColor = True
        '
        'crv
        '
        Me.crv.ActiveViewIndex = -1
        Me.crv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crv.Cursor = System.Windows.Forms.Cursors.Default
        Me.crv.Location = New System.Drawing.Point(12, 85)
        Me.crv.Name = "crv"
        Me.crv.ShowParameterPanelButton = False
        Me.crv.Size = New System.Drawing.Size(810, 368)
        Me.crv.TabIndex = 2
        Me.crv.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'nuCantPeriodos
        '
        Me.nuCantPeriodos.Location = New System.Drawing.Point(334, 17)
        Me.nuCantPeriodos.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nuCantPeriodos.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nuCantPeriodos.Name = "nuCantPeriodos"
        Me.nuCantPeriodos.Size = New System.Drawing.Size(47, 21)
        Me.nuCantPeriodos.TabIndex = 3
        Me.nuCantPeriodos.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Periodos:"
        '
        'lbMes
        '
        Me.lbMes.AutoSize = True
        Me.lbMes.Location = New System.Drawing.Point(16, 57)
        Me.lbMes.Name = "lbMes"
        Me.lbMes.Size = New System.Drawing.Size(30, 13)
        Me.lbMes.TabIndex = 5
        Me.lbMes.Text = "Mes:"
        '
        'cbMes
        '
        Me.cbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMes.FormattingEnabled = True
        Me.cbMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cbMes.Location = New System.Drawing.Point(52, 57)
        Me.cbMes.Name = "cbMes"
        Me.cbMes.Size = New System.Drawing.Size(121, 21)
        Me.cbMes.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Año:"
        '
        'nuAño
        '
        Me.nuAño.Location = New System.Drawing.Point(215, 60)
        Me.nuAño.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nuAño.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.nuAño.Name = "nuAño"
        Me.nuAño.Size = New System.Drawing.Size(48, 21)
        Me.nuAño.TabIndex = 9
        Me.nuAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nuAño.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'chExcluirCierre
        '
        Me.chExcluirCierre.AutoSize = True
        Me.chExcluirCierre.Location = New System.Drawing.Point(451, 60)
        Me.chExcluirCierre.Name = "chExcluirCierre"
        Me.chExcluirCierre.Size = New System.Drawing.Size(89, 17)
        Me.chExcluirCierre.TabIndex = 10
        Me.chExcluirCierre.Text = "Excluir Cierre"
        Me.chExcluirCierre.UseVisualStyleBackColor = True
        '
        'btMostrar
        '
        Me.btMostrar.BackColor = System.Drawing.Color.RoyalBlue
        Me.btMostrar.FlatAppearance.BorderSize = 0
        Me.btMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMostrar.ForeColor = System.Drawing.Color.White
        Me.btMostrar.Location = New System.Drawing.Point(705, 11)
        Me.btMostrar.Name = "btMostrar"
        Me.btMostrar.Size = New System.Drawing.Size(126, 50)
        Me.btMostrar.TabIndex = 11
        Me.btMostrar.Text = "Mostrar"
        Me.btMostrar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbMoneda)
        Me.GroupBox1.Controls.Add(Me.rbMensual)
        Me.GroupBox1.Controls.Add(Me.rbAnual)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.nuCantPeriodos)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(401, 41)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comparación"
        '
        'cbMoneda
        '
        Me.cbMoneda.DataSource = Me.MonedaBS
        Me.cbMoneda.DisplayMember = "MonedaNombre"
        Me.cbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMoneda.FormattingEnabled = True
        Me.cbMoneda.Location = New System.Drawing.Point(149, 17)
        Me.cbMoneda.Name = "cbMoneda"
        Me.cbMoneda.Size = New System.Drawing.Size(121, 21)
        Me.cbMoneda.TabIndex = 14
        Me.cbMoneda.ValueMember = "CodMoneda"
        '
        'MonedaBS
        '
        Me.MonedaBS.DataMember = "Moneda"
        Me.MonedaBS.DataSource = Me.dts
        '
        'dts
        '
        Me.dts.DataSetName = "dtsResultado"
        Me.dts.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbBalance)
        Me.GroupBox2.Controls.Add(Me.rbEstadoResultado)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(269, 41)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reporte"
        '
        'rbBalance
        '
        Me.rbBalance.AutoSize = True
        Me.rbBalance.Checked = True
        Me.rbBalance.Location = New System.Drawing.Point(6, 17)
        Me.rbBalance.Name = "rbBalance"
        Me.rbBalance.Size = New System.Drawing.Size(108, 17)
        Me.rbBalance.TabIndex = 1
        Me.rbBalance.TabStop = True
        Me.rbBalance.Text = "Balance Situación"
        Me.rbBalance.UseVisualStyleBackColor = True
        '
        'rbEstadoResultado
        '
        Me.rbEstadoResultado.AutoSize = True
        Me.rbEstadoResultado.Location = New System.Drawing.Point(142, 17)
        Me.rbEstadoResultado.Name = "rbEstadoResultado"
        Me.rbEstadoResultado.Size = New System.Drawing.Size(109, 17)
        Me.rbEstadoResultado.TabIndex = 0
        Me.rbEstadoResultado.Text = "Estado Resultado"
        Me.rbEstadoResultado.UseVisualStyleBackColor = True
        '
        'ResultadoBS
        '
        Me.ResultadoBS.DataMember = "Resultados"
        Me.ResultadoBS.DataSource = Me.dts
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(272, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Niveles:"
        '
        'nuNivel
        '
        Me.nuNivel.Location = New System.Drawing.Point(330, 57)
        Me.nuNivel.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nuNivel.Minimum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.nuNivel.Name = "nuNivel"
        Me.nuNivel.Size = New System.Drawing.Size(47, 21)
        Me.nuNivel.TabIndex = 14
        Me.nuNivel.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'frmResultado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(834, 465)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nuNivel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btMostrar)
        Me.Controls.Add(Me.chExcluirCierre)
        Me.Controls.Add(Me.nuAño)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbMes)
        Me.Controls.Add(Me.lbMes)
        Me.Controls.Add(Me.crv)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(737, 446)
        Me.Name = "frmResultado"
        Me.Text = "Resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nuCantPeriodos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuAño, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MonedaBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ResultadoBS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nuNivel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbAnual As Windows.Forms.RadioButton
    Friend WithEvents rbMensual As Windows.Forms.RadioButton
    Friend WithEvents ResultadoBS As Windows.Forms.BindingSource
    Friend WithEvents crv As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents nuCantPeriodos As Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents lbMes As Windows.Forms.Label
    Friend WithEvents cbMes As Windows.Forms.ComboBox
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents nuAño As Windows.Forms.NumericUpDown
    Friend WithEvents chExcluirCierre As Windows.Forms.CheckBox
    Friend WithEvents btMostrar As Windows.Forms.Button
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As Windows.Forms.GroupBox
    Friend WithEvents rbBalance As Windows.Forms.RadioButton
    Friend WithEvents rbEstadoResultado As Windows.Forms.RadioButton
    Friend WithEvents cbMoneda As Windows.Forms.ComboBox
    Friend WithEvents dts As dtsResultado
    Friend WithEvents MonedaBS As Windows.Forms.BindingSource
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents nuNivel As Windows.Forms.NumericUpDown
End Class
