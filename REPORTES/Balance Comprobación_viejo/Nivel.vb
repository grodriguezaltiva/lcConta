Imports Utilidades

Public Class Nivel
    Inherits System.Windows.Forms.Form

#Region "Varibles"
    Dim cconexion As New Conexion
    Dim formato As Integer
    Dim conectadobd As New SqlClient.SqlConnection
    Public saldoant, debitos, creditos, saldomes, saldoactual, moneda, simbolo, reporte As String
    Public saldoant1, debitos1, creditos1, saldomes1, saldoactual1 As String
    Public CodMoneda As Double
    Public Analitico As Boolean
    Public Tipo As Integer
#End Region

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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents smbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RB_Balance As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtInicial = New System.Windows.Forms.DateTimePicker
        Me.dtFinal = New System.Windows.Forms.DateTimePicker
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RB_Balance = New System.Windows.Forms.RadioButton
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(18, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha Inicial :"
        '
        'dtInicial
        '
        Me.dtInicial.Enabled = False
        Me.dtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtInicial.Location = New System.Drawing.Point(158, 66)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Size = New System.Drawing.Size(120, 22)
        Me.dtInicial.TabIndex = 5
        '
        'dtFinal
        '
        Me.dtFinal.Enabled = False
        Me.dtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFinal.Location = New System.Drawing.Point(158, 94)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(121, 22)
        Me.dtFinal.TabIndex = 4
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(349, 70)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown2.TabIndex = 89
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(289, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 18)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Nivel :"
        '
        'smbGenerar
        '
        Me.smbGenerar.Location = New System.Drawing.Point(236, 165)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.Size = New System.Drawing.Size(98, 31)
        Me.smbGenerar.TabIndex = 91
        Me.smbGenerar.Text = "Generar"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(44, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 24)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Seleccione el nivel a que quiere visualizar el reporte"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(350, 165)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 31)
        Me.SimpleButton1.TabIndex = 93
        Me.SimpleButton1.Text = "Cancelar"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RadioButton1.Location = New System.Drawing.Point(21, 132)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(218, 24)
        Me.RadioButton1.TabIndex = 94
        Me.RadioButton1.Text = "Reporte Analitico General"
        '
        'RB_Balance
        '
        Me.RB_Balance.Font = New System.Drawing.Font("Century Schoolbook", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RB_Balance.ForeColor = System.Drawing.SystemColors.Highlight
        Me.RB_Balance.Location = New System.Drawing.Point(23, 32)
        Me.RB_Balance.Name = "RB_Balance"
        Me.RB_Balance.Size = New System.Drawing.Size(218, 24)
        Me.RB_Balance.TabIndex = 95
        Me.RB_Balance.Text = "Balance de Comprobación"
        '
        'Nivel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(465, 224)
        Me.Controls.Add(Me.RB_Balance)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.smbGenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtInicial)
        Me.Controls.Add(Me.dtFinal)
        Me.Name = "Nivel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NIVEL"
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub Nivel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectadobd = cconexion.Conectar("Contabilidad")
        formato = cconexion.SlqExecuteScalar(conectadobd, "Select Niveles from FormatoCuenta")
        Me.NumericUpDown2.Maximum = formato
        RadioButton1.Enabled = Analitico
        RadioButton1.Visible = Analitico
        RB_Balance.Checked = True
    End Sub
#End Region

#Region "Generar"
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        Dim Asientos As New BalanceComprobacion
        Dim asientos1 As New BalanceComprobacion1
        Dim Analitico As New AnaliticoGeneral
        Dim Analitico1 As New AnaliticoGeneral1

        Dim visor As New frmVisorReportes

        If Me.RadioButton1.Checked Then
            If Tipo = 1 Then
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Analitico1, False, Me.conectadobd.ConnectionString)
                Analitico1.SetParameterValue(0, Me.dtInicial.Text)
                Analitico1.SetParameterValue(1, Me.dtFinal.Text)
                Analitico1.SetParameterValue(2, Me.moneda)
                Analitico1.SetParameterValue(3, Me.CodMoneda)
                Analitico1.SetParameterValue(4, Me.simbolo)
            Else
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Analitico, False, Me.conectadobd.ConnectionString)
                Analitico.SetParameterValue(0, Me.dtInicial.Text)
                Analitico.SetParameterValue(1, Me.dtFinal.Text)
                Analitico.SetParameterValue(2, Me.moneda)
                Analitico.SetParameterValue(3, Me.CodMoneda)
                Analitico.SetParameterValue(4, Me.simbolo)
            End If


        Else
            If Tipo = 1 Then
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, asientos1, False, Me.conectadobd.ConnectionString)

                asientos1.SetParameterValue(0, dtInicial.Text)
                asientos1.SetParameterValue(1, dtFinal.Text)
                asientos1.SetParameterValue(2, saldoant)
                asientos1.SetParameterValue(3, debitos)
                asientos1.SetParameterValue(4, creditos)
                asientos1.SetParameterValue(5, saldomes)
                asientos1.SetParameterValue(6, saldoactual)
                asientos1.SetParameterValue(7, NumericUpDown2.Value)
                asientos1.SetParameterValue(8, reporte)
                asientos1.SetParameterValue(9, saldoant1)
                asientos1.SetParameterValue(10, debitos1)
                asientos1.SetParameterValue(11, creditos1)
                asientos1.SetParameterValue(12, saldomes1)
                asientos1.SetParameterValue(13, saldoactual1)
            Else
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Asientos, False, Me.conectadobd.ConnectionString)
                '
                Asientos.SetParameterValue(0, dtInicial.Text)
                Asientos.SetParameterValue(1, dtFinal.Text)
                Asientos.SetParameterValue(2, saldoant)
                Asientos.SetParameterValue(3, debitos)
                Asientos.SetParameterValue(4, creditos)
                Asientos.SetParameterValue(5, saldomes)
                Asientos.SetParameterValue(6, saldoactual)
                Asientos.SetParameterValue(7, NumericUpDown2.Value)
                Asientos.SetParameterValue(8, reporte)
                Asientos.SetParameterValue(9, moneda)
            End If

        End If
        visor.Show()
    End Sub
#End Region

#Region "Funciones Controles"
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        NumericUpDown2.Enabled = RB_Balance.Checked
    End Sub

    Private Sub RB_Balance_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RB_Balance.CheckedChanged
        NumericUpDown2.Enabled = RB_Balance.Checked
    End Sub
#End Region

End Class
