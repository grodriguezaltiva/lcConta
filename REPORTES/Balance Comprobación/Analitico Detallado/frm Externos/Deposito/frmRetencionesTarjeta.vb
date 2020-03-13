Public Class frmRetencionesTarjeta
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnMostrar As System.Windows.Forms.Button
    Friend WithEvents crvVisor As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRetencionesTarjeta))
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker
        Me.btnMostrar = New System.Windows.Forms.Button
        Me.crvVisor = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpDesde.Location = New System.Drawing.Point(48, 8)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(88, 20)
        Me.dtpDesde.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Desde:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(144, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hasta:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpHasta.Location = New System.Drawing.Point(184, 8)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(88, 20)
        Me.dtpHasta.TabIndex = 2
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(280, 8)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.TabIndex = 4
        Me.btnMostrar.Text = "Ver"
        '
        'crvVisor
        '
        Me.crvVisor.ActiveViewIndex = -1
        Me.crvVisor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.crvVisor.DisplayGroupTree = False
        Me.crvVisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crvVisor.Location = New System.Drawing.Point(0, 32)
        Me.crvVisor.Name = "crvVisor"
        Me.crvVisor.ReportSource = Nothing
        Me.crvVisor.ShowCloseButton = False
        Me.crvVisor.ShowGotoPageButton = False
        Me.crvVisor.ShowGroupTreeButton = False
        Me.crvVisor.ShowRefreshButton = False
        Me.crvVisor.Size = New System.Drawing.Size(448, 408)
        Me.crvVisor.TabIndex = 5
        '
        'frmRetencionesTarjeta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 446)
        Me.Controls.Add(Me.crvVisor)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDesde)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRetencionesTarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Retenciones pagadas"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        Dim rtp As New rptDepositosTarjetas
        rtp.SetParameterValue("Titulo", "Reporte de Tarjetas")
        rtp.SetParameterValue("Empresa", "Salaberry S.A")
        rtp.SetParameterValue("Filtro", "Depositos de Tarjetas, Desde:" & Format(Me.dtpDesde.Value, "dd/MM/yyyy") & " - Hasta: " & Format(Me.dtpDesde.Value, "dd/MM/yyyy"))
        rtp.SetParameterValue("Desde", Me.dtpDesde.Value)
        rtp.SetParameterValue("Hasta", Me.dtpHasta.Value)
        CrystalReportsConexion2.LoadReportViewer2(Me.crvVisor, rtp, False)
        Me.crvVisor.Show()

    End Sub
End Class
