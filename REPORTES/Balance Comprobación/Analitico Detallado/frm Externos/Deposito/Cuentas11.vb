
Imports System.Drawing
Imports System.Data.SqlClient
Imports Utilidades
Public Class Cuentas11
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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsCuentas1 As dsCuentas
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents adDeposito As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adDepositoDetalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cbCuentas As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbCuentas = New System.Windows.Forms.ComboBox
        Me.DsCuentas1 = New dsCuentas
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.adDeposito = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adDepositoDetalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        CType(Me.DsCuentas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la cuenta bancaria"
        '
        'cbCuentas
        '
        Me.cbCuentas.DataSource = Me.DsCuentas1
        Me.cbCuentas.DisplayMember = "Cuentas_bancarias.Cuenta"
        Me.cbCuentas.Location = New System.Drawing.Point(40, 40)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(224, 21)
        Me.cbCuentas.TabIndex = 1
        '
        'DsCuentas1
        '
        Me.DsCuentas1.DataSetName = "dsCuentas"
        Me.DsCuentas1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=PI3E;packet size=4096;integrated security=SSPI;data source=PI3E;pe" & _
        "rsist security info=False;initial catalog=Bancos"
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Cuentas_bancarias", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("Codigo_banco", "Codigo_banco"), New System.Data.Common.DataColumnMapping("tipoCuenta", "tipoCuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("SaldoInicial", "SaldoInicial"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("ChequeInicial", "ChequeInicial"), New System.Data.Common.DataColumnMapping("ChequeFinal", "ChequeFinal"), New System.Data.Common.DataColumnMapping("Cod_Moneda", "Cod_Moneda"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Cuenta, Codigo_banco, tipoCuenta, NombreCuenta, Id_CuentaBancaria, SaldoIn" & _
        "icial, CuentaContable, ChequeInicial, ChequeFinal, Cod_Moneda, NombreCuentaConta" & _
        "ble FROM Cuentas_bancarias"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(96, 72)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Aceptar"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(192, 72)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Cancelar"
        '
        'adDeposito
        '
        Me.adDeposito.SelectCommand = Me.SqlSelectCommand2
        Me.adDeposito.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deposito", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumeroDocumento", "NumeroDocumento"), New System.Data.Common.DataColumnMapping("Id_CuentaBancaria", "Id_CuentaBancaria"), New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Concepto", "Concepto"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("Conciliado", "Conciliado"), New System.Data.Common.DataColumnMapping("Contabilizado", "Contabilizado"), New System.Data.Common.DataColumnMapping("Ced_Usuario", "Ced_Usuario"), New System.Data.Common.DataColumnMapping("Asiento", "Asiento"), New System.Data.Common.DataColumnMapping("Num_Conciliacion", "Num_Conciliacion")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT NumeroDocumento, Id_CuentaBancaria, Id_Deposito, Fecha, Monto, Concepto, A" & _
        "nulado, Conciliado, Contabilizado, Ced_Usuario, Asiento, Num_Conciliacion FROM D" & _
        "eposito"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'adDepositoDetalle
        '
        Me.adDepositoDetalle.SelectCommand = Me.SqlSelectCommand3
        Me.adDepositoDetalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Deposito_Detalle", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_DepositoDet", "Id_DepositoDet"), New System.Data.Common.DataColumnMapping("Id_Deposito", "Id_Deposito"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("DescripcionMov", "DescripcionMov"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id_DepositoDet, Id_Deposito, CuentaContable, DescripcionMov, Monto, Nombre" & _
        "Cuenta FROM Deposito_Detalle"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'Cuentas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(304, 125)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Cuentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas"
        CType(Me.DsCuentas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public uno As String
    Public ident As String

    Private Sub Cuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCuentas(uno)
    End Sub
    Function CargarCuentas(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = GetSetting("Seesoft", "Bancos", "Conexion")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim sel As String
            Dim cmd As SqlCommand = New SqlCommand

            If ident = "Deposito" Then
                sel = "SELECT     * FROM dbo.Cuentas_bancarias INNER JOIN" & _
                          " dbo.Deposito ON dbo.Cuentas_bancarias.Id_CuentaBancaria = dbo.Deposito.Id_CuentaBancaria where dbo.Deposito.NumeroDocumento = '" & Id & "'"
            End If

            If ident = "Ajuste" Then
                sel = "SELECT     * FROM dbo.Cuentas_bancarias INNER JOIN" & _
                          " dbo.AjusteBancario ON dbo.Cuentas_bancarias.Id_CuentaBancaria = dbo.AjusteBancario.Id_CuentaBancaria where dbo.AjusteBancario.Num_Ajuste = '" & Id & "'"
            End If

            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            da.Fill(Me.DsCuentas1.Cuentas_bancarias)
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally

            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Me.Close()
    End Sub
End Class
