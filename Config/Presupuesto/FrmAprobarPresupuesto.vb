
Imports Utilidades_DB
Public Class FrmAprobarPresupuesto
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
    Friend WithEvents Lbl_Periodo As System.Windows.Forms.Label
    Friend WithEvents btnAprobar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Lbl_Periodo = New System.Windows.Forms.Label
        Me.txtPeriodo = New System.Windows.Forms.TextBox
        Me.btnAprobar = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Lbl_Periodo
        '
        Me.Lbl_Periodo.Location = New System.Drawing.Point(8, 32)
        Me.Lbl_Periodo.Name = "Lbl_Periodo"
        Me.Lbl_Periodo.TabIndex = 0
        Me.Lbl_Periodo.Text = "Periodo Fiscal :"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Enabled = False
        Me.txtPeriodo.Location = New System.Drawing.Point(104, 32)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Size = New System.Drawing.Size(176, 20)
        Me.txtPeriodo.TabIndex = 1
        Me.txtPeriodo.Text = ""
        '
        'btnAprobar
        '
        Me.btnAprobar.Location = New System.Drawing.Point(368, 32)
        Me.btnAprobar.Name = "btnAprobar"
        Me.btnAprobar.TabIndex = 2
        Me.btnAprobar.Text = "Aprobar"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(288, 32)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        '
        'FrmAprobarPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 130)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnAprobar)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.Lbl_Periodo)
        Me.Name = "FrmAprobarPresupuesto"
        Me.Text = "Aprobar Presupuesto"
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim txtId_PeridoFiscal As Integer
    Dim IDPeriodo = 0
#End Region




    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal WHERE Id = @Id
        Dim fx As New cFunciones
        Dim IdP As String = ""
        txtId_PeridoFiscal = 0
        IdP = fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "PeriodoFiscal", "Buscar Periodo Fiscal...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")
        txtId_PeridoFiscal = Convert.ToInt32(IdP)
        If IdP <> "" Then
            Dim dt As New DataTable
            Dim db As New SeeDBMaster
            Dim par As New Dictionaries
            par.Add("@ID", IdP)
            db.Fill_Generic_Table("Contabilidad", dt, "SELECT Id, CAST(CONVERT(datetime, FechaInicio, 103) AS char(11)) + ' - ' + CAST(CONVERT(datetime, FechaFinal, 103) AS Char(11)) AS PeriodoFiscal FROM PeriodoFiscal WHERE (Id = @ID)", CommandType.Text, par)
            If dt.Rows.Count > 0 Then
                txtPeriodo.Text = dt.Rows(0).Item(1)
                IDPeriodo = dt.Rows(0).Item(0)
            End If

            

        End If
    End Sub

    Private Sub btnAprobar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAprobar.Click

        RutinaAprobarPresupuestoPeriodoFiscal()
    End Sub

    Private Sub RutinaAprobarPresupuestoPeriodoFiscal()

        Try
            If (txtId_PeridoFiscal <> 0) Then

                Dim Resultado As Integer = 0
                Resultado = MsgBox("Estimado usuario esta seguro que si desea aprobar el presupuesto de este periodo fiscal", MsgBoxStyle.YesNo, "")
                Select Case Resultado
                    Case 6
                        Dim ClassConexion As New Conexion
                        ClassConexion.AprobarPresupuesto(txtId_PeridoFiscal, "S")
                        txtPeriodo.Text = ""
                        MsgBox("Presupuesto Aprobado", MsgBoxStyle.Information, "")

                    Case 7
                        txtPeriodo.Text = ""
                End Select

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub FrmAprobarPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


End Class
