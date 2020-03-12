<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstadosResultados2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstadosResultados2))
        Me.cboMoneda = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCantidadNivel = New System.Windows.Forms.Button
        Me.cboPeriodoFiscal = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.PeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtsReportes = New Contabilidad.dtsReportesNuevos
        Me.PeriodoFiscalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.getBalance = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdGetBalance = New Contabilidad.dtsReportesNuevosTableAdapters.getBalanceSituacionTableAdapter
        Me.PeriodoFiscalTableAdapter = New Contabilidad.dtsReportesNuevosTableAdapters.PeriodoFiscalTableAdapter
        Me.DtsReportesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PeriodoTableAdapter = New Contabilidad.dtsReportesNuevosTableAdapters.PeriodoTableAdapter
        Me.PeriodoFiscalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodoFiscalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.getBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsReportesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodoFiscalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMoneda
        '
        Me.cboMoneda.DisplayMember = "Periodo"
        Me.cboMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMoneda.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMoneda.FormattingEnabled = True
        Me.cboMoneda.Location = New System.Drawing.Point(163, 59)
        Me.cboMoneda.Name = "cboMoneda"
        Me.cboMoneda.Size = New System.Drawing.Size(127, 26)
        Me.cboMoneda.TabIndex = 109
        Me.cboMoneda.ValueMember = "Id_Periodo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(30, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 108
        Me.Label1.Text = "Moneda :"
        '
        'btnCantidadNivel
        '
        Me.btnCantidadNivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCantidadNivel.Font = New System.Drawing.Font("Trebuchet MS", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCantidadNivel.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnCantidadNivel.Location = New System.Drawing.Point(30, 103)
        Me.btnCantidadNivel.Name = "btnCantidadNivel"
        Me.btnCantidadNivel.Size = New System.Drawing.Size(260, 73)
        Me.btnCantidadNivel.TabIndex = 107
        Me.btnCantidadNivel.Text = "Mostrar Balance"
        Me.btnCantidadNivel.UseVisualStyleBackColor = True
        '
        'cboPeriodoFiscal
        '
        Me.cboPeriodoFiscal.DataSource = Me.PeriodoFiscalBindingSource1
        Me.cboPeriodoFiscal.DisplayMember = "Anno"
        Me.cboPeriodoFiscal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriodoFiscal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPeriodoFiscal.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriodoFiscal.FormattingEnabled = True
        Me.cboPeriodoFiscal.Location = New System.Drawing.Point(163, 17)
        Me.cboPeriodoFiscal.Name = "cboPeriodoFiscal"
        Me.cboPeriodoFiscal.Size = New System.Drawing.Size(127, 26)
        Me.cboPeriodoFiscal.TabIndex = 105
        Me.cboPeriodoFiscal.ValueMember = "Id"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label15.Location = New System.Drawing.Point(30, 20)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 18)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Periodo Fiscal:"
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
        'PeriodoFiscalBindingSource
        '
        Me.PeriodoFiscalBindingSource.DataMember = "PeriodoFiscal"
        Me.PeriodoFiscalBindingSource.DataSource = Me.DtsReportes
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
        'PeriodoFiscalBindingSource1
        '
        Me.PeriodoFiscalBindingSource1.DataMember = "PeriodoFiscal"
        Me.PeriodoFiscalBindingSource1.DataSource = Me.DtsReportesBindingSource
        '
        'frmEstadosResultados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 201)
        Me.Controls.Add(Me.cboMoneda)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCantidadNivel)
        Me.Controls.Add(Me.cboPeriodoFiscal)
        Me.Controls.Add(Me.Label15)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmEstadosResultados2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado Resultados"
        CType(Me.PeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodoFiscalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.getBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsReportesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodoFiscalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCantidadNivel As System.Windows.Forms.Button
    Friend WithEvents cboPeriodoFiscal As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PeriodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DtsReportes As Contabilidad.dtsReportesNuevos
    Friend WithEvents PeriodoFiscalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents getBalance As System.Windows.Forms.BindingSource
    Friend WithEvents cmdGetBalance As Contabilidad.dtsReportesNuevosTableAdapters.getBalanceSituacionTableAdapter
    Friend WithEvents PeriodoFiscalTableAdapter As Contabilidad.dtsReportesNuevosTableAdapters.PeriodoFiscalTableAdapter
    Friend WithEvents DtsReportesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PeriodoTableAdapter As Contabilidad.dtsReportesNuevosTableAdapters.PeriodoTableAdapter
    Friend WithEvents PeriodoFiscalBindingSource1 As System.Windows.Forms.BindingSource
End Class
