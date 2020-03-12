Public Class FormVisorReportesCrystal
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
    Friend WithEvents CrystalReportViewerVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.CrystalReportViewerVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewerVisor
        '
        Me.CrystalReportViewerVisor.ActiveViewIndex = -1
        Me.CrystalReportViewerVisor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewerVisor.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewerVisor.Name = "CrystalReportViewerVisor"
        Me.CrystalReportViewerVisor.ReportSource = Nothing
        Me.CrystalReportViewerVisor.Size = New System.Drawing.Size(704, 493)
        Me.CrystalReportViewerVisor.TabIndex = 0
        '
        'FormVisorReportesCrystal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 493)
        Me.Controls.Add(Me.CrystalReportViewerVisor)
        Me.Name = "FormVisorReportesCrystal"
        Me.Text = "Contabilidad Reporte"
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
