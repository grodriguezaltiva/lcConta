Public Class FormConfEstadoResultadoBanco
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
    Friend WithEvents LabelIngresos As System.Windows.Forms.Label
    Friend WithEvents TextBoxIngresos As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxIngresos As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxCostoV As System.Windows.Forms.TextBox
    Friend WithEvents LabelCostoVenta As System.Windows.Forms.Label
    Friend WithEvents GroupBoxGOperacion As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCuentaMadre As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelIngresos = New System.Windows.Forms.Label
        Me.TextBoxIngresos = New System.Windows.Forms.TextBox
        Me.TextBoxCostoV = New System.Windows.Forms.TextBox
        Me.LabelCostoVenta = New System.Windows.Forms.Label
        Me.GroupBoxIngresos = New System.Windows.Forms.GroupBox
        Me.GroupBoxGOperacion = New System.Windows.Forms.GroupBox
        Me.LabelCuentaMadre = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBoxIngresos.SuspendLayout()
        Me.GroupBoxGOperacion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelIngresos
        '
        Me.LabelIngresos.Location = New System.Drawing.Point(8, 24)
        Me.LabelIngresos.Name = "LabelIngresos"
        Me.LabelIngresos.TabIndex = 0
        Me.LabelIngresos.Text = "Ingresos"
        '
        'TextBoxIngresos
        '
        Me.TextBoxIngresos.Location = New System.Drawing.Point(112, 24)
        Me.TextBoxIngresos.Name = "TextBoxIngresos"
        Me.TextBoxIngresos.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxIngresos.TabIndex = 1
        Me.TextBoxIngresos.Text = ""
        '
        'TextBoxCostoV
        '
        Me.TextBoxCostoV.Location = New System.Drawing.Point(112, 56)
        Me.TextBoxCostoV.Name = "TextBoxCostoV"
        Me.TextBoxCostoV.Size = New System.Drawing.Size(168, 20)
        Me.TextBoxCostoV.TabIndex = 3
        Me.TextBoxCostoV.Text = ""
        '
        'LabelCostoVenta
        '
        Me.LabelCostoVenta.Location = New System.Drawing.Point(8, 56)
        Me.LabelCostoVenta.Name = "LabelCostoVenta"
        Me.LabelCostoVenta.TabIndex = 2
        Me.LabelCostoVenta.Text = "Costo Venta"
        '
        'GroupBoxIngresos
        '
        Me.GroupBoxIngresos.Controls.Add(Me.LabelIngresos)
        Me.GroupBoxIngresos.Controls.Add(Me.TextBoxIngresos)
        Me.GroupBoxIngresos.Controls.Add(Me.TextBoxCostoV)
        Me.GroupBoxIngresos.Controls.Add(Me.LabelCostoVenta)
        Me.GroupBoxIngresos.Location = New System.Drawing.Point(8, 8)
        Me.GroupBoxIngresos.Name = "GroupBoxIngresos"
        Me.GroupBoxIngresos.Size = New System.Drawing.Size(400, 88)
        Me.GroupBoxIngresos.TabIndex = 4
        Me.GroupBoxIngresos.TabStop = False
        Me.GroupBoxIngresos.Text = "Ingresos"
        '
        'GroupBoxGOperacion
        '
        Me.GroupBoxGOperacion.Controls.Add(Me.LabelCuentaMadre)
        Me.GroupBoxGOperacion.Controls.Add(Me.TextBox2)
        Me.GroupBoxGOperacion.Location = New System.Drawing.Point(8, 104)
        Me.GroupBoxGOperacion.Name = "GroupBoxGOperacion"
        Me.GroupBoxGOperacion.Size = New System.Drawing.Size(400, 56)
        Me.GroupBoxGOperacion.TabIndex = 5
        Me.GroupBoxGOperacion.TabStop = False
        Me.GroupBoxGOperacion.Text = "Gastos Operación"
        '
        'LabelCuentaMadre
        '
        Me.LabelCuentaMadre.Location = New System.Drawing.Point(8, 24)
        Me.LabelCuentaMadre.Name = "LabelCuentaMadre"
        Me.LabelCuentaMadre.TabIndex = 0
        Me.LabelCuentaMadre.Text = "Cuenta Madre"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(112, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 20)
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 56)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gastos Operación"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta Madre"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(112, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = ""
        '
        'FormConfEstadoResultadoBanco
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 333)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxGOperacion)
        Me.Controls.Add(Me.GroupBoxIngresos)
        Me.Name = "FormConfEstadoResultadoBanco"
        Me.Text = "Configuración Estado Resultado"
        Me.GroupBoxIngresos.ResumeLayout(False)
        Me.GroupBoxGOperacion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GroupBoxIngresos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBoxIngresos.Enter

    End Sub
End Class
