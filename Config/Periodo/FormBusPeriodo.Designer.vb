<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBusPeriodo
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
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.PeriodoBDS = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPeriodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPeriodo = New Contabilidad.DsPeriodo
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.IdPeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PeriodoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.ActivoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Cerrado = New System.Windows.Forms.DataGridViewCheckBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeriodoBDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPeriodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPeriodo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(395, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 59)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(476, 12)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 59)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancelar"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPeriodoDataGridViewTextBoxColumn, Me.PeriodoDataGridViewTextBoxColumn, Me.AnnoDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn, Me.ActivoDataGridViewCheckBoxColumn, Me.Cerrado})
        Me.DataGridView1.DataSource = Me.PeriodoBDS
        Me.DataGridView1.Location = New System.Drawing.Point(12, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(539, 290)
        Me.DataGridView1.TabIndex = 3
        '
        'PeriodoBDS
        '
        Me.PeriodoBDS.DataMember = "Periodo"
        Me.PeriodoBDS.DataSource = Me.DsPeriodoBindingSource
        '
        'DsPeriodoBindingSource
        '
        Me.DsPeriodoBindingSource.DataSource = Me.DsPeriodo
        Me.DsPeriodoBindingSource.Position = 0
        '
        'DsPeriodo
        '
        Me.DsPeriodo.DataSetName = "DsPeriodo"
        Me.DsPeriodo.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DsPeriodo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(377, 26)
        Me.TextBox1.TabIndex = 0
        '
        'IdPeriodoDataGridViewTextBoxColumn
        '
        Me.IdPeriodoDataGridViewTextBoxColumn.DataPropertyName = "Id_Periodo"
        Me.IdPeriodoDataGridViewTextBoxColumn.HeaderText = "Id_Periodo"
        Me.IdPeriodoDataGridViewTextBoxColumn.Name = "IdPeriodoDataGridViewTextBoxColumn"
        Me.IdPeriodoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PeriodoDataGridViewTextBoxColumn
        '
        Me.PeriodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.HeaderText = "Periodo"
        Me.PeriodoDataGridViewTextBoxColumn.Name = "PeriodoDataGridViewTextBoxColumn"
        Me.PeriodoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnnoDataGridViewTextBoxColumn
        '
        Me.AnnoDataGridViewTextBoxColumn.DataPropertyName = "Anno"
        Me.AnnoDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AnnoDataGridViewTextBoxColumn.Name = "AnnoDataGridViewTextBoxColumn"
        Me.AnnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "Mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "Bloqueado"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        Me.EstadoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ActivoDataGridViewCheckBoxColumn
        '
        Me.ActivoDataGridViewCheckBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewCheckBoxColumn.Name = "ActivoDataGridViewCheckBoxColumn"
        Me.ActivoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'Cerrado
        '
        Me.Cerrado.DataPropertyName = "Cerrado"
        Me.Cerrado.HeaderText = "Cerrado"
        Me.Cerrado.Name = "Cerrado"
        Me.Cerrado.ReadOnly = True
        '
        'FormBusPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 379)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Name = "FormBusPeriodo"
        Me.ShowIcon = False
        Me.Text = "Buscar"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeriodoBDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPeriodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPeriodo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PeriodoBDS As System.Windows.Forms.BindingSource
    Friend WithEvents DsPeriodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsPeriodo As Contabilidad.DsPeriodo
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents IdPeriodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PeriodoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnnoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents ActivoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Cerrado As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
