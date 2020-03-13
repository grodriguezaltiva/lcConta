Public Class frmAnaliticoxCuenta
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDescripcionCuenta As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.lblDescripcionCuenta = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 24)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Cuenta :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(88, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(536, 26)
        Me.TextBox1.TabIndex = 96
        Me.TextBox1.Text = ""
        '
        'lblDescripcionCuenta
        '
        Me.lblDescripcionCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescripcionCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionCuenta.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescripcionCuenta.Location = New System.Drawing.Point(88, 48)
        Me.lblDescripcionCuenta.Name = "lblDescripcionCuenta"
        Me.lblDescripcionCuenta.Size = New System.Drawing.Size(536, 23)
        Me.lblDescripcionCuenta.TabIndex = 98
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 24)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "Desc. :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(312, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 26)
        Me.DateTimePicker1.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(248, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 24)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "Inicio :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(440, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 24)
        Me.Label4.TabIndex = 102
        Me.Label4.Text = "Final :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(504, 79)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(120, 26)
        Me.DateTimePicker2.TabIndex = 101
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(408, 64)
        Me.Button1.TabIndex = 103
        Me.Button1.Text = "Mostrar "
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Moneda :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBox1
        '
        Me.ComboBox1.Location = New System.Drawing.Point(88, 79)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 28)
        Me.ComboBox1.TabIndex = 105
        '
        'frmAnaliticoxCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(8, 19)
        Me.ClientSize = New System.Drawing.Size(640, 197)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.lblDescripcionCuenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Name = "frmAnaliticoxCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analitico x Cuenta"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public usua As Object
    Private Nivel As Integer
    Private Tipo As String

    Private Sub CargarMoneda()
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select codmoneda, monedanombre from moneda", dts, Configuracion.Claves.Conexion("Contabilidad"))
            Me.ComboBox1.DataSource = dts
            Me.ComboBox1.DisplayMember = "monedanombre"
            Me.ComboBox1.ValueMember = "codmoneda"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private SaldoAnterior As Double
    Private SaldoMes As Double
    Private SaldoActual As Double

    Private Sub CalculaSaldos()
        Dim dts As New DataTable

		cFunciones.Llenar_Tabla_Generico("select isnull(max(SaldoAnterior),0) as SaldoAnterior from dbo.TemporalAnaliticoDetallado", dts, Configuracion.Claves.Conexion("Contabilidad"))
		If dts.Rows.Count > 0 Then
            Me.SaldoAnterior = dts.Rows(0).Item("SaldoAnterior")
        Else
            Me.SaldoAnterior = 0
        End If

		cFunciones.Llenar_Tabla_Generico("select isnull(sum(Debitos),0) as Debitos, isnull(sum(Creditos),0) as Creditos from dbo.TemporalAnaliticoDetallado", dts, Configuracion.Claves.Conexion("Contabilidad"))
		Dim debitos, creditos As Decimal
        If dts.Rows.Count > 0 Then
            debitos = dts.Rows(0).Item("Debitos")
            creditos = dts.Rows(0).Item("Creditos")
        Else
            debitos = 0
            creditos = 0
        End If

        If Me.Tipo = "ACTIVOS" Or Me.Tipo = "COSTO VENTA" Or Me.Tipo = "GASTOS" Then
            Me.SaldoMes = debitos - creditos
        End If

        If Me.Tipo = "PASIVOS" Or Me.Tipo = "CAPITAL" Or Me.Tipo = "INGRESOS" Then
            Me.SaldoMes = creditos - debitos
        End If

        Me.SaldoActual = Me.SaldoAnterior + Me.SaldoMes

    End Sub

    Private Sub PoneDescripcion(ByVal _codigo As String)
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select Descripcion, Nivel, Tipo from dbo.CuentaContable  where cuentacontable = '" & _codigo & "'", dts, Configuracion.Claves.Conexion("Contabilidad"))
            If dts.Rows.Count > 0 Then
                Me.lblDescripcionCuenta.Text = dts.Rows(0).Item("Descripcion")
                Me.Nivel = dts.Rows(0).Item("Nivel")
                Me.Tipo = dts.Rows(0).Item("Tipo")
                Me.TextBox1.Text = _codigo
                Me.TextBox1.ReadOnly = True
            Else
                Nivel = 0
                MsgBox("Nose encontro la cuenta", MsgBoxStyle.Exclamation, Text)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private WithEvents frm As New frmAnaliticoDetallado
    Dim Cconexion As New Conexion

    Private Sub frm_Refresca() Handles frm.Actualiza
        Cconexion.SlqExecuteScalar(Cconexion.Conectar(), "EXEC dbo.ReporteAnaliticoDetallado '" & Me.TextBox1.Text & "'," & Me.Nivel + 1 & ",'" & Me.DateTimePicker1.Value.Date & "','" & Me.DateTimePicker2.Value.Date & "'," & Me.ComboBox1.SelectedValue & "," & False)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Cconexion.SlqExecuteScalar(Cconexion.Conectar(), "EXEC dbo.ReporteAnaliticoDetallado '" & Me.TextBox1.Text & "'," & Me.Nivel + 1 & ",'" & Me.DateTimePicker1.Value.Date & "','" & Me.DateTimePicker2.Value.Date & "'," & Me.ComboBox1.SelectedValue & "," & False)
            Me.CalculaSaldos()
            frm.NombreMoneda = Me.ComboBox1.Text

            frm.SaldoMes = Me.SaldoMes
            frm.SaldoAnterior = Me.SaldoAnterior

            frm.CuentaContable = Me.TextBox1.Text
            frm.NombreCuenta = Me.lblDescripcionCuenta.Text
            frm.usua = Me.usua
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Private Sub frmAnaliticoxCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarMoneda()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
            " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub
            PoneDescripcion(busca.codigo)
        End If

        If e.KeyCode = Keys.Enter Then
            PoneDescripcion(Me.TextBox1.Text)
        End If
    End Sub

End Class
