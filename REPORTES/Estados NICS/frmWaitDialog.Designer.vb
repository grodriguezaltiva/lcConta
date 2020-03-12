<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWaitDialog
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.prgBarraTransicion = New System.Windows.Forms.ProgressBar
        Me.ldNotas = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cargando..."
        '
        'prgBarraTransicion
        '
        Me.prgBarraTransicion.Location = New System.Drawing.Point(32, 123)
        Me.prgBarraTransicion.Name = "prgBarraTransicion"
        Me.prgBarraTransicion.Size = New System.Drawing.Size(492, 23)
        Me.prgBarraTransicion.Step = 1
        Me.prgBarraTransicion.TabIndex = 1
        '
        'ldNotas
        '
        Me.ldNotas.AutoSize = True
        Me.ldNotas.Location = New System.Drawing.Point(29, 97)
        Me.ldNotas.Name = "ldNotas"
        Me.ldNotas.Size = New System.Drawing.Size(16, 13)
        Me.ldNotas.TabIndex = 2
        Me.ldNotas.Text = "..."
        '
        'frmWaitDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 273)
        Me.ControlBox = False
        Me.Controls.Add(Me.ldNotas)
        Me.Controls.Add(Me.prgBarraTransicion)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWaitDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents prgBarraTransicion As System.Windows.Forms.ProgressBar
    Friend WithEvents ldNotas As System.Windows.Forms.Label
End Class
