Public Class FormFechaDepositos
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonListo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormFechaDepositos))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.ButtonListo = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(8, 8)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(240, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'ButtonListo
        '
        Me.ButtonListo.Location = New System.Drawing.Point(88, 40)
        Me.ButtonListo.Name = "ButtonListo"
        Me.ButtonListo.TabIndex = 1
        Me.ButtonListo.Text = "Listo"
        '
        'FormFechaDepositos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(256, 69)
        Me.Controls.Add(Me.ButtonListo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormFechaDepositos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fecha para Dépositos Importados"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListo.Click
        Me.Close()
    End Sub
End Class
