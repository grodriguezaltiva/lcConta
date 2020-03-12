Imports Utilidades
Public Class FormChequeoAsientosBancos
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
    Friend WithEvents RadioButtonDepositos As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonCheques As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAjustesCRE As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonAjustesDebito As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBoxParametros As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ButtonMostrar As System.Windows.Forms.Button
    Friend WithEvents RadioButtonCXP As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonTrans As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBoxConta As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FormChequeoAsientosBancos))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.RadioButtonDepositos = New System.Windows.Forms.RadioButton
        Me.RadioButtonCheques = New System.Windows.Forms.RadioButton
        Me.RadioButtonAjustesCRE = New System.Windows.Forms.RadioButton
        Me.RadioButtonAjustesDebito = New System.Windows.Forms.RadioButton
        Me.GroupBoxParametros = New System.Windows.Forms.GroupBox
        Me.RadioButtonTrans = New System.Windows.Forms.RadioButton
        Me.RadioButtonCXP = New System.Windows.Forms.RadioButton
        Me.ButtonMostrar = New System.Windows.Forms.Button
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.CheckBoxConta = New System.Windows.Forms.CheckBox
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
        'RadioButtonDepositos
        '
        Me.RadioButtonDepositos.Location = New System.Drawing.Point(304, 16)
        Me.RadioButtonDepositos.Name = "RadioButtonDepositos"
        Me.RadioButtonDepositos.Size = New System.Drawing.Size(80, 24)
        Me.RadioButtonDepositos.TabIndex = 4
        Me.RadioButtonDepositos.Text = "Depósitos"
        '
        'RadioButtonCheques
        '
        Me.RadioButtonCheques.Location = New System.Drawing.Point(384, 16)
        Me.RadioButtonCheques.Name = "RadioButtonCheques"
        Me.RadioButtonCheques.Size = New System.Drawing.Size(72, 24)
        Me.RadioButtonCheques.TabIndex = 5
        Me.RadioButtonCheques.Text = "Cheques"
        '
        'RadioButtonAjustesCRE
        '
        Me.RadioButtonAjustesCRE.Location = New System.Drawing.Point(472, 16)
        Me.RadioButtonAjustesCRE.Name = "RadioButtonAjustesCRE"
        Me.RadioButtonAjustesCRE.TabIndex = 6
        Me.RadioButtonAjustesCRE.Text = "Ajustes de CRE"
        '
        'RadioButtonAjustesDebito
        '
        Me.RadioButtonAjustesDebito.Location = New System.Drawing.Point(592, 16)
        Me.RadioButtonAjustesDebito.Name = "RadioButtonAjustesDebito"
        Me.RadioButtonAjustesDebito.TabIndex = 8
        Me.RadioButtonAjustesDebito.Text = "Ajustes DEB"
        '
        'GroupBoxParametros
        '
        Me.GroupBoxParametros.Controls.Add(Me.CheckBoxConta)
        Me.GroupBoxParametros.Controls.Add(Me.RadioButtonTrans)
        Me.GroupBoxParametros.Controls.Add(Me.RadioButtonCXP)
        Me.GroupBoxParametros.Controls.Add(Me.ButtonMostrar)
        Me.GroupBoxParametros.Controls.Add(Me.Label1)
        Me.GroupBoxParametros.Controls.Add(Me.Label2)
        Me.GroupBoxParametros.Controls.Add(Me.RadioButtonDepositos)
        Me.GroupBoxParametros.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxParametros.Controls.Add(Me.RadioButtonAjustesCRE)
        Me.GroupBoxParametros.Controls.Add(Me.RadioButtonAjustesDebito)
        Me.GroupBoxParametros.Controls.Add(Me.RadioButtonCheques)
        Me.GroupBoxParametros.Controls.Add(Me.DateTimePicker2)
        Me.GroupBoxParametros.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBoxParametros.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxParametros.Name = "GroupBoxParametros"
        Me.GroupBoxParametros.Size = New System.Drawing.Size(992, 56)
        Me.GroupBoxParametros.TabIndex = 9
        Me.GroupBoxParametros.TabStop = False
        Me.GroupBoxParametros.Text = "Parametros"
        '
        'RadioButtonTrans
        '
        Me.RadioButtonTrans.Location = New System.Drawing.Point(752, 16)
        Me.RadioButtonTrans.Name = "RadioButtonTrans"
        Me.RadioButtonTrans.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonTrans.TabIndex = 11
        Me.RadioButtonTrans.Text = "Trans"
        '
        'RadioButtonCXP
        '
        Me.RadioButtonCXP.Location = New System.Drawing.Point(688, 16)
        Me.RadioButtonCXP.Name = "RadioButtonCXP"
        Me.RadioButtonCXP.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonCXP.TabIndex = 10
        Me.RadioButtonCXP.Text = "CxP"
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(928, 8)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(56, 40)
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
        'CheckBoxConta
        '
        Me.CheckBoxConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxConta.ForeColor = System.Drawing.Color.Red
        Me.CheckBoxConta.Location = New System.Drawing.Point(816, 16)
        Me.CheckBoxConta.Name = "CheckBoxConta"
        Me.CheckBoxConta.Size = New System.Drawing.Size(112, 24)
        Me.CheckBoxConta.TabIndex = 12
        Me.CheckBoxConta.Text = "solo Pendientes"
        '
        'FormChequeoAsientosBancos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(992, 341)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBoxParametros)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormChequeoAsientosBancos"
        Me.Text = "Reportes Bancos Contabilizados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBoxParametros.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        mostrar()
    End Sub
    Sub mostrar()
        If Me.RadioButtonDepositos.Checked Then
            Dim rpt As New rptHotelDetalleDeposito_Generado
            rpt.SetParameterValue(0, Me.DateTimePicker1.Value)
            rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            rpt.SetParameterValue(2, Not Me.CheckBoxConta.Checked)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Bancos"))
        ElseIf Me.RadioButtonCheques.Checked Then
            Dim rpt As New rptHotelDetalleCheque_Generado
            rpt.SetParameterValue(0, Me.DateTimePicker1.Value)
            rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            rpt.SetParameterValue(2, CDate(Me.DateTimePicker2.Value))
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Bancos"))
        ElseIf Me.RadioButtonAjustesCRE.Checked Then
            Dim rpt As New rptHotelDetalleAjusteBancarioCredito_Generado
            Dim fecIni, fecFin As String
            fecIni = "  DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & " ,00,00,00)"
            fecFin = "  DateTime( " & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23,59,59)"

            Dim es As String = False
            If Not Me.CheckBoxConta.Checked Then es = "true"
            rpt.RecordSelectionFormula = "{AjusteBancario.Fecha} in  " & fecIni & "  to  " & fecFin & "  and {AjusteBancario.Debito} = true and {AjusteBancario.Credito} = false and not {AjusteBancario.Anula} AND ( {AjusteBancario.Contabilizado} = false OR {AjusteBancario.Contabilizado} = " & es & " )"

            rpt.RecordSelectionFormula = "{AjusteBancario.Fecha} in  " & fecIni & "  to " & fecFin & " and {AjusteBancario.Debito} = false and {AjusteBancario.Credito} = true and not {AjusteBancario.Anula} AND ( {AjusteBancario.Contabilizado} = false OR {AjusteBancario.Contabilizado} = " & es & " )"
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Bancos"))

        ElseIf Me.RadioButtonAjustesDebito.Checked Then
            Dim rpt As New rptHotelDetalleAjusteBancarioDebito_Generado
            Dim fecIni, fecFin As String
            fecIni = "  DateTime(" & DateTimePicker1.Value.Year & "," & DateTimePicker1.Value.Month & "," & DateTimePicker1.Value.Day & " ,00,00,00)"
            fecFin = "  DateTime( " & DateTimePicker2.Value.Year & "," & DateTimePicker2.Value.Month & "," & DateTimePicker2.Value.Day & ", 23,59,59)"
            Dim es As String = False
            If Not Me.CheckBoxConta.Checked Then es = "true"
            rpt.RecordSelectionFormula = "{AjusteBancario.Fecha} in  " & fecIni & "  to  " & fecFin & "  and {AjusteBancario.Debito} = true and {AjusteBancario.Credito} = false and not {AjusteBancario.Anula} AND ( {AjusteBancario.Contabilizado} = false OR {AjusteBancario.Contabilizado} = " & es & " )"

            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Bancos"))
        ElseIf Me.RadioButtonCXP.Checked Then
            Dim rpt As New CrystalReportCuentasXPagar
            rpt.SetParameterValue(0, Me.DateTimePicker1.Value)
            rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            rpt.SetParameterValue(2, Not Me.CheckBoxConta.Checked)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Bancos"))
        ElseIf Me.RadioButtonTrans.Checked Then
            Dim rpt As New CrystalReportTransferencias
            rpt.SetParameterValue(0, Me.DateTimePicker1.Value)
            rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
            rpt.SetParameterValue(2, Not Me.CheckBoxConta.Checked)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Bancos"))

        End If

    End Sub
End Class
