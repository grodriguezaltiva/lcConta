<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteEstadosFinancieros
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
        Me.chbEstado1 = New System.Windows.Forms.CheckBox
        Me.chbEstado2 = New System.Windows.Forms.CheckBox
        Me.chbEstado4 = New System.Windows.Forms.CheckBox
        Me.chbEstado3 = New System.Windows.Forms.CheckBox
        Me.lbCompañia = New System.Windows.Forms.Label
        Me.txtCompañia = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDetalle = New System.Windows.Forms.TextBox
        Me.Detalle = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnConfNotas = New System.Windows.Forms.Button
        Me.abrirArchivo = New System.Windows.Forms.OpenFileDialog
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.txtPeriodo1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPeriodo2 = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbEstado1
        '
        Me.chbEstado1.AutoSize = True
        Me.chbEstado1.Checked = True
        Me.chbEstado1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEstado1.Location = New System.Drawing.Point(486, 4)
        Me.chbEstado1.Name = "chbEstado1"
        Me.chbEstado1.Size = New System.Drawing.Size(68, 17)
        Me.chbEstado1.TabIndex = 1
        Me.chbEstado1.Text = "Estado 1"
        Me.chbEstado1.UseVisualStyleBackColor = True
        '
        'chbEstado2
        '
        Me.chbEstado2.AutoSize = True
        Me.chbEstado2.Checked = True
        Me.chbEstado2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEstado2.Location = New System.Drawing.Point(486, 36)
        Me.chbEstado2.Name = "chbEstado2"
        Me.chbEstado2.Size = New System.Drawing.Size(68, 17)
        Me.chbEstado2.TabIndex = 2
        Me.chbEstado2.Text = "Estado 2"
        Me.chbEstado2.UseVisualStyleBackColor = True
        '
        'chbEstado4
        '
        Me.chbEstado4.AutoSize = True
        Me.chbEstado4.Location = New System.Drawing.Point(486, 101)
        Me.chbEstado4.Name = "chbEstado4"
        Me.chbEstado4.Size = New System.Drawing.Size(68, 17)
        Me.chbEstado4.TabIndex = 4
        Me.chbEstado4.Text = "Estado 4"
        Me.chbEstado4.UseVisualStyleBackColor = True
        '
        'chbEstado3
        '
        Me.chbEstado3.AutoSize = True
        Me.chbEstado3.Location = New System.Drawing.Point(486, 69)
        Me.chbEstado3.Name = "chbEstado3"
        Me.chbEstado3.Size = New System.Drawing.Size(68, 17)
        Me.chbEstado3.TabIndex = 3
        Me.chbEstado3.Text = "Estado 3"
        Me.chbEstado3.UseVisualStyleBackColor = True
        '
        'lbCompañia
        '
        Me.lbCompañia.AutoSize = True
        Me.lbCompañia.Location = New System.Drawing.Point(3, 17)
        Me.lbCompañia.Name = "lbCompañia"
        Me.lbCompañia.Size = New System.Drawing.Size(57, 13)
        Me.lbCompañia.TabIndex = 5
        Me.lbCompañia.Text = "Compañia:"
        '
        'txtCompañia
        '
        Me.txtCompañia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompañia.Location = New System.Drawing.Point(6, 40)
        Me.txtCompañia.Name = "txtCompañia"
        Me.txtCompañia.Size = New System.Drawing.Size(409, 20)
        Me.txtCompañia.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Location = New System.Drawing.Point(6, 98)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(409, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Dirección."
        '
        'txtDetalle
        '
        Me.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle.Location = New System.Drawing.Point(6, 153)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(409, 20)
        Me.txtDetalle.TabIndex = 10
        '
        'Detalle
        '
        Me.Detalle.AutoSize = True
        Me.Detalle.Location = New System.Drawing.Point(3, 130)
        Me.Detalle.Name = "Detalle"
        Me.Detalle.Size = New System.Drawing.Size(43, 13)
        Me.Detalle.TabIndex = 9
        Me.Detalle.Text = "Detalle."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPeriodo2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtPeriodo1)
        Me.GroupBox1.Controls.Add(Me.Detalle)
        Me.GroupBox1.Controls.Add(Me.txtDetalle)
        Me.GroupBox1.Controls.Add(Me.lbCompañia)
        Me.GroupBox1.Controls.Add(Me.txtCompañia)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 242)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Titulo"
        '
        'btnConfNotas
        '
        Me.btnConfNotas.Location = New System.Drawing.Point(486, 120)
        Me.btnConfNotas.Name = "btnConfNotas"
        Me.btnConfNotas.Size = New System.Drawing.Size(120, 52)
        Me.btnConfNotas.TabIndex = 12
        Me.btnConfNotas.Text = "Configuración Notas"
        Me.btnConfNotas.UseVisualStyleBackColor = True
        '
        'abrirArchivo
        '
        Me.abrirArchivo.FileName = "Plantilla.docx"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(486, 178)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(120, 64)
        Me.btnGenerar.TabIndex = 14
        Me.btnGenerar.Text = "Generar Reporte"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'txtPeriodo1
        '
        Me.txtPeriodo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeriodo1.Location = New System.Drawing.Point(6, 201)
        Me.txtPeriodo1.Name = "txtPeriodo1"
        Me.txtPeriodo1.Size = New System.Drawing.Size(123, 20)
        Me.txtPeriodo1.TabIndex = 11
        Me.txtPeriodo1.Text = "2011"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Periodo1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Periodo2"
        '
        'txtPeriodo2
        '
        Me.txtPeriodo2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeriodo2.Location = New System.Drawing.Point(135, 201)
        Me.txtPeriodo2.Name = "txtPeriodo2"
        Me.txtPeriodo2.Size = New System.Drawing.Size(123, 20)
        Me.txtPeriodo2.TabIndex = 13
        Me.txtPeriodo2.Text = "2012"
        '
        'frmReporteEstadosFinancieros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 244)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnConfNotas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chbEstado4)
        Me.Controls.Add(Me.chbEstado3)
        Me.Controls.Add(Me.chbEstado2)
        Me.Controls.Add(Me.chbEstado1)
        Me.Name = "frmReporteEstadosFinancieros"
        Me.Text = "Reporte Estados Financieros"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chbEstado1 As System.Windows.Forms.CheckBox
    Friend WithEvents chbEstado2 As System.Windows.Forms.CheckBox
    Friend WithEvents chbEstado4 As System.Windows.Forms.CheckBox
    Friend WithEvents chbEstado3 As System.Windows.Forms.CheckBox
    Friend WithEvents lbCompañia As System.Windows.Forms.Label
    Friend WithEvents txtCompañia As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Detalle As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnConfNotas As System.Windows.Forms.Button
    Friend WithEvents abrirArchivo As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo1 As System.Windows.Forms.TextBox

End Class
