Imports Utilidades
Public Class FormListadoAsiento
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
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxParametros As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ButtonMostrar As System.Windows.Forms.Button
    Friend WithEvents CheckBoxAgrup As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBoxParametros = New System.Windows.Forms.GroupBox
        Me.ButtonMostrar = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CheckBoxAgrup = New System.Windows.Forms.CheckBox
        Me.GroupBoxParametros.SuspendLayout()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(200, 16)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(160, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'GroupBoxParametros
        '
        Me.GroupBoxParametros.Controls.Add(Me.CheckBoxAgrup)
        Me.GroupBoxParametros.Controls.Add(Me.ButtonMostrar)
        Me.GroupBoxParametros.Controls.Add(Me.Label1)
        Me.GroupBoxParametros.Controls.Add(Me.Label2)
        Me.GroupBoxParametros.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxParametros.Controls.Add(Me.DateTimePicker2)
        Me.GroupBoxParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxParametros.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxParametros.Name = "GroupBoxParametros"
        Me.GroupBoxParametros.Size = New System.Drawing.Size(992, 56)
        Me.GroupBoxParametros.TabIndex = 9
        Me.GroupBoxParametros.TabStop = False
        Me.GroupBoxParametros.Text = "Parametros"
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(888, 8)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(96, 40)
        Me.ButtonMostrar.TabIndex = 9
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 56)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(992, 285)
        Me.CrystalReportViewer1.TabIndex = 10
        '
        'CheckBoxAgrup
        '
        Me.CheckBoxAgrup.Location = New System.Drawing.Point(320, 16)
        Me.CheckBoxAgrup.Name = "CheckBoxAgrup"
        Me.CheckBoxAgrup.TabIndex = 10
        Me.CheckBoxAgrup.Text = "Agrupado"
        '
        'FormListadoAsiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 341)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBoxParametros)
        Me.Name = "FormListadoAsiento"
        Me.Text = "Reportes Asiento Contables"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxParametros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        mostrar()
    End Sub
    Sub mostrar()
        If Me.CheckBoxAgrup.Checked Then
            Dim rpt As New ListadoAsientosAgrupo
            rpt.SetParameterValue(0, Me.DateTimePicker1.Value)
            rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
        Else
            Dim rpt As New ListadoAsientos
            rpt.SetParameterValue(0, Me.DateTimePicker1.Value)
            rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
        End If
        
    End Sub
End Class
