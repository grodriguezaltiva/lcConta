<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceSituancionNuevo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceSituancionNuevo))
        Me.cboPeriodoT = New System.Windows.Forms.ComboBox
        Me.PeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsReportes = New Contabilidad.dtsReportesNuevos
        Me.cboPeriodoFiscal = New System.Windows.Forms.ComboBox
        Me.PeriodoFiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.btnCantidadNivel = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.getBalance = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdGetBalance = New Contabilidad.dtsReportesNuevosTableAdapters.getBalanceSituacionTableAdapter
        Me.PeriodoFiscalTableAdapter = New Contabilidad.dtsReportesNuevosTableAdapters.PeriodoFiscalTableAdapter
        Me.DtsReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodoTableAdapter = New Contabilidad.dtsReportesNuevosTableAdapters.PeriodoTableAdapter
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboComparativo = New System.Windows.Forms.ComboBox
        CType(Me.PeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodoFiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.getBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPeriodoT
        '
        Me.cboPeriodoT.DataSource = Me.PeriodoBindingSource
        Me.cboPeriodoT.DisplayMember = "Periodo"
        Me.cboPeriodoT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodoT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriodoT.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodoT.FormattingEnabled = True
        Me.cboPeriodoT.Location = New System.Drawing.Point(128, 80)
        Me.cboPeriodoT.Name = "cboPeriodoT"
        Me.cboPeriodoT.Size = New System.Drawing.Size(179, 26)
        Me.cboPeriodoT.TabIndex = 15
        Me.cboPeriodoT.ValueMember = "Id_Periodo"
        '
        'PeriodoBindingSource
        '
        Me.PeriodoBindingSource.DataMember = "Periodo"
        Me.PeriodoBindingSource.DataSource = Me.DtsReportes
        '
        'DtsReportes
        '
        Me.DtsReportes.DataSetName = "dtsReportesNuevos"
        Me.DtsReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cboPeriodoFiscal
        '
        Me.cboPeriodoFiscal.DataSource = Me.PeriodoFiscalBindingSource
        Me.cboPeriodoFiscal.DisplayMember = "Anno"
        Me.cboPeriodoFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodoFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriodoFiscal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodoFiscal.FormattingEnabled = True
        Me.cboPeriodoFiscal.Location = New System.Drawing.Point(128, 44)
        Me.cboPeriodoFiscal.Name = "cboPeriodoFiscal"
        Me.cboPeriodoFiscal.Size = New System.Drawing.Size(179, 26)
        Me.cboPeriodoFiscal.TabIndex = 14
        Me.cboPeriodoFiscal.ValueMember = "Id"
        '
        'PeriodoFiscalBindingSource
        '
        Me.PeriodoFiscalBindingSource.DataMember = "PeriodoFiscal"
        Me.PeriodoFiscalBindingSource.DataSource = Me.DtsReportes
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label14.Location = New System.Drawing.Point(29, 83)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 18)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Periodo Fiscal:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(29, 47)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 18)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Año Fiscal:"
        '
        'btnCantidadNivel
        '
        Me.btnCantidadNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidadNivel.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidadNivel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnCantidadNivel.Location = New System.Drawing.Point(29, 154)
        Me.btnCantidadNivel.Name = "btnCantidadNivel"
        Me.btnCantidadNivel.Size = New System.Drawing.Size(278, 73)
        Me.btnCantidadNivel.TabIndex = 16
        Me.btnCantidadNivel.Text = "Mostrar Balance"
        Me.btnCantidadNivel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(29, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "Moneda :"
        '
        'getBalance
        '
        Me.getBalance.DataMember = "getBalanceSituacion"
        Me.getBalance.DataSource = Me.DtsReportes
        '
        'cmdGetBalance
        '
        Me.cmdGetBalance.ClearBeforeFill = True
        '
        'PeriodoFiscalTableAdapter
        '
        Me.PeriodoFiscalTableAdapter.ClearBeforeFill = True
        '
        'DtsReportesBindingSource
        '
        Me.DtsReportesBindingSource.DataSource = Me.DtsReportes
        Me.DtsReportesBindingSource.Position = 0
        '
        'PeriodoTableAdapter
        '
        Me.PeriodoTableAdapter.ClearBeforeFill = True
        '
        'cboMoneda
        '
        Me.cboMoneda.DataSource = Me.PeriodoBindingSource
        Me.cboMoneda.DisplayMember = "Periodo"
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMoneda.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(128, 117)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(179, 26)
        Me.cboMoneda.TabIndex = 95
        Me.cboMoneda.ValueMember = "Id_Periodo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(29, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Tipo Reporte :"
        '
        'cboComparativo
        '
        Me.cboComparativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboComparativo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboComparativo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComparativo.FormattingEnabled = True
        Me.cboComparativo.Items.AddRange(New Object() {"Comparativo Mes Anterior", "Comparativo Año Anterior"})
        Me.cboComparativo.Location = New System.Drawing.Point(128, 11)
        Me.cboComparativo.Name = "cboComparativo"
        Me.cboComparativo.Size = New System.Drawing.Size(179, 26)
        Me.cboComparativo.TabIndex = 97
        '
        'frmBalanceSituancionNuevo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 229)
        Me.Controls.Add(Me.cboComparativo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCantidadNivel)
        Me.Controls.Add(Me.cboPeriodoT)
        Me.Controls.Add(Me.cboPeriodoFiscal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmBalanceSituancionNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balance de Situacion"
        CType(Me.PeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodoFiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.getBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboPeriodoT As System.Windows.Forms.ComboBox
    Friend WithEvents cboPeriodoFiscal As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnCantidadNivel As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DtsReportesNuevos As Contabilidad.dtsReportesNuevos
    Friend WithEvents GetBalanceSituacionTableAdapter As Contabilidad.dtsReportesNuevosTableAdapters.getBalanceSituacionTableAdapter
    Friend WithEvents getBalance As System.Windows.Forms.BindingSource
    Friend WithEvents DtsReportes As Contabilidad.dtsReportesNuevos
    Friend WithEvents cmdGetBalance As Contabilidad.dtsReportesNuevosTableAdapters.getBalanceSituacionTableAdapter
    Friend WithEvents PeriodoFiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodoFiscalTableAdapter As Contabilidad.dtsReportesNuevosTableAdapters.PeriodoFiscalTableAdapter
    Friend WithEvents DtsReportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodoTableAdapter As Contabilidad.dtsReportesNuevosTableAdapters.PeriodoTableAdapter
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboComparativo As System.Windows.Forms.ComboBox
End Class
