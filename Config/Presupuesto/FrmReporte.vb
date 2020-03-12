
Imports Utilidades
Public Class FrmReporte
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
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(920, 474)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'FrmReporte
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(920, 474)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmReporte"
        Me.Text = "FrmReporte"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend codigo As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FrmReporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RutinaCargarReporte()

    End Sub

    Private Sub RutinaCargarReporte()
        Try
            'Dim rpt As New RptAutorizacion
            Dim rpt As New RptAutorizacion
            rpt.SetParameterValue(0, Convert.ToInt32(codigo))
            'rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            'rpt.SetParameterValue(2, Not Me.CheckBoxConta.Checked)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub
End Class
