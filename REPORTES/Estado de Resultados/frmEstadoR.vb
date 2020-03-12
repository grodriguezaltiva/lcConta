Imports Utilidades
Imports System.Data.SqlClient

Public Class frmEstadoR
    Inherits System.Windows.Forms.Form
    Dim usua As Object

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetMoneda As Contabilidad.DataSetMoneda
    Friend WithEvents AdapterCuentasMadres As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CheckCuentas As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEstadoR))
        Me.fechafinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicial = New System.Windows.Forms.DateTimePicker
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckCuentas = New System.Windows.Forms.CheckBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.DataSetMoneda = New Contabilidad.DataSetMoneda
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.ButAgregarDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCuentasMadres = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fechafinal
        '
        Me.fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fechafinal.Location = New System.Drawing.Point(288, 40)
        Me.fechafinal.Name = "fechafinal"
        Me.fechafinal.Size = New System.Drawing.Size(120, 20)
        Me.fechafinal.TabIndex = 2
        Me.fechafinal.Value = New Date(2007, 5, 17, 0, 0, 0, 0)
        '
        'FechaInicial
        '
        Me.FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicial.Location = New System.Drawing.Point(144, 40)
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.Size = New System.Drawing.Size(120, 20)
        Me.FechaInicial.TabIndex = 1
        Me.FechaInicial.Value = New Date(2007, 5, 17, 0, 0, 0, 0)
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(16, 40)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TituloModulo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1284, 120)
        Me.Panel1.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1024, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(264, 32)
        Me.Label4.TabIndex = 73
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckCuentas)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.FechaInicial)
        Me.GroupBox1.Controls.Add(Me.fechafinal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButAgregarDetalle)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(752, 72)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Estado"
        '
        'CheckCuentas
        '
        Me.CheckCuentas.Location = New System.Drawing.Point(600, 16)
        Me.CheckCuentas.Name = "CheckCuentas"
        Me.CheckCuentas.Size = New System.Drawing.Size(128, 24)
        Me.CheckCuentas.TabIndex = 93
        Me.CheckCuentas.Text = "Ocultar Cuentas"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DataSetMoneda.Moneda
        Me.ComboBox1.DisplayMember = "MonedaNombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Location = New System.Drawing.Point(440, 40)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 22)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "CodMoneda"
        '
        'DataSetMoneda
        '
        Me.DataSetMoneda.DataSetName = "DataSetMoneda"
        Me.DataSetMoneda.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(440, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Moneda:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(288, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(144, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Nivel:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButAgregarDetalle
        '
        Me.ButAgregarDetalle.ImageIndex = 0
        Me.ButAgregarDetalle.Location = New System.Drawing.Point(592, 40)
        Me.ButAgregarDetalle.Name = "ButAgregarDetalle"
        Me.ButAgregarDetalle.Size = New System.Drawing.Size(129, 24)
        Me.ButAgregarDetalle.TabIndex = 4
        Me.ButAgregarDetalle.Text = "Generar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(744, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 32)
        Me.Label1.TabIndex = 70
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(-8, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(752, 32)
        Me.TituloModulo.TabIndex = 69
        Me.TituloModulo.Text = "                                           Estado de Resultados"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 120)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1284, 486)
        Me.Panel2.TabIndex = 7
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1284, 486)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda")})})
        Me.AdapterMoneda.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Seguridad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Moneda(MonedaNombre, ValorVenta, CodMoneda) VALUES (@MonedaNombre, @V" & _
        "alorVenta, @CodMoneda); SELECT MonedaNombre, ValorVenta, CodMoneda FROM Moneda W" & _
        "HERE (CodMoneda = @CodMoneda)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT MonedaNombre, ValorVenta, CodMoneda FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Moneda SET MonedaNombre = @MonedaNombre, ValorVenta = @ValorVenta, CodMone" & _
        "da = @CodMoneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @Ori" & _
        "ginal_MonedaNombre) AND (ValorVenta = @Original_ValorVenta); SELECT MonedaNombre" & _
        ", ValorVenta, CodMoneda FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdapterCuentasMadres
        '
        Me.AdapterCuentasMadres.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterCuentasMadres.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterCuentasMadres.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentasMadres", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("TipoCuenta", "TipoCuenta")})})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO CuentasMadres(CuentaContable, Descripcion, TipoCuenta) VALUES (@Cuent" & _
        "aContable, @Descripcion, @TipoCuenta); SELECT CuentaContable, Descripcion, TipoC" & _
        "uenta FROM CuentasMadres"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCuenta", System.Data.SqlDbType.VarChar, 250, "TipoCuenta"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CuentaContable, Descripcion, TipoCuenta FROM CuentasMadres"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'frmEstadoR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1284, 606)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEstadoR"
        Me.Text = "Estados Financieros - Estado de Resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetMoneda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim cconexion As New Conexion
    Dim conectadobd As New SqlClient.SqlConnection
    Dim rss As SqlClient.SqlDataReader
    Dim formato As Integer
    Dim saldoanting, saldomesing, saldoantgastos, saldomesgastos, saldoantcost, saldomescost As Double
    Dim saldoantingotros, saldomesingotros, saldoantgastosotros, saldomesgastosotros As Double
#End Region

#Region "Load"
    Private Sub frmEstadoR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conectadobd = cconexion.Conectar("Contabilidad")
        SqlConnection.ConnectionString = Configuracion.Claves.Conexion("Seguridad")
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        formato = cconexion.SlqExecuteScalar(conectadobd, "Select Niveles from FormatoCuenta")
        Me.NumericUpDown1.Maximum = formato
        FechaInicial.Value = Now
        fechafinal.Value = Now
        AdapterMoneda.Fill(DataSetMoneda.Moneda)
        AdapterCuentasMadres.Fill(DataSetMoneda.CuentasMadres)
        NumericUpDown1.Focus()
    End Sub
#End Region

#Region "Generar"
    Private Sub ButAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAgregarDetalle.Click
        Try
            cconexion.DeleteRecords("Temporal", "") 'BORRA LA TABLA TEMPORAL
            Dim str As String = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown1.Value & " and (Tipo='INGRESOS') ORDER BY CuentaContable"

            estado(str)
            str = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown1.Value & " and (Tipo='COSTO VENTA') ORDER BY CuentaContable"
            estado(str)

            'UTILIDAD BRUTA
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','UTILIDAD BRUTA'," & (saldoanting - saldoantcost) & "," & (saldomesing - saldomescost) & "," & ((saldoanting - saldoantcost) + (saldomesing - saldomescost)) & ",'UTILIDAD BRUTA',0, 0") 'psv
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','',0,0,0,'  ',0,0") 'psv ESPACIO SEPARADOR

            str = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown1.Value & " and (Tipo='GASTOS') ORDER BY CuentaContable"
            estado(str)

            'RESULTADO DE OPERACIONES
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','RESULTADO DE OPERACIONES'," & ((saldoanting - saldoantcost) - (saldoantgastos)) & "," & ((saldomesing - saldomescost) - (saldomesgastos)) & "," & ((saldoanting - saldoantcost) - (saldoantgastos)) + ((saldomesing - saldomescost) - (saldomesgastos)) & ",'UTILIDAD NETA',0, 0") 'psv
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','',0,0,0,'  ',0,0") 'ESPACIO SEPARADOR

            str = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown1.Value & " and (Tipo='OTROS INGRESOS') ORDER BY CuentaContable"
            estado(str)

            str = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown1.Value & " and (Tipo='OTROS GASTOS') ORDER BY CuentaContable"
            estado(str)

            'UTILIDAD NETA
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','UTILIDAD NETA'," & ((saldoanting - saldoantcost) - (saldoantgastos) + (saldoantingotros) - (saldoantgastosotros)) & "," & ((saldomesing - saldomescost) - (saldomesgastos) + (saldomesingotros) - (saldomesgastosotros)) & "," & ((saldoanting - saldoantcost) - (saldoantgastos) + (saldoantingotros) - (saldoantgastosotros)) + ((saldomesing - saldomescost) - (saldomesgastos) + (saldomesingotros) - (saldomesgastosotros)) & ",'UTILIDAD NETA',0, 0") 'psv
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','',0,0,0,'  ',0,0") 'ESPACIO SEPARADOR

            Dim rptestado As New EstadoResultados
            rptestado.SetParameterValue(0, NumericUpDown1.Value)
            rptestado.SetParameterValue(1, FechaInicial.Text)
            rptestado.SetParameterValue(2, fechafinal.Text)
            rptestado.SetParameterValue(3, DataSetMoneda.Moneda(Me.ComboBox1.SelectedIndex).MonedaNombre)
            rptestado.SetParameterValue(4, CheckCuentas.Checked)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rptestado, False, Me.conectadobd.ConnectionString)
            CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Calculos"
    Private Sub estado(ByVal str As String)
        Dim dt As New DataSet
        dt.Tables.Clear()
        Dim adapter As New SqlClient.SqlDataAdapter(str, conectadobd)
        adapter.Fill(dt, "CuentaContable")
        Dim fila As DataRow
        Dim fechaI, fechaF, primeracuenta, descripcion, tipo As String
        Dim montoant, montomes As Double
        fechaI = CDate(Me.FechaInicial.Text)
        fechaF = CDate(Me.fechafinal.Text)
        Dim TotalmontoAnt, TotalmontoMes As Double
        Dim CuentaMadre As Boolean = False
        For Each fila In dt.Tables("CuentaContable").Rows
            Try
                If fila("Nivel") = 0 Then
                    If CuentaMadre Then
                        montoant = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & fechaI & "','" & primeracuenta & "',1," & ComboBox1.SelectedValue))
                        montomes = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & fechaI & "','" & fechaF & "','" & primeracuenta & "',1," & ComboBox1.SelectedValue))
                        If montoant <> 0 Or montomes <> 0 Then
                            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & primeracuenta & "','TOTAL " & descripcion & "'," & montoant & "," & montomes & "," & (montoant + montomes) & ",'" & tipo & "',0,0")
                        End If
                    End If
                    primeracuenta = fila("CuentaContable")
                    descripcion = fila("Descripcion")
                    tipo = fila("Tipo")
                    CuentaMadre = True
                    cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & fila("CuentaContable") & "','" & fila("Descripcion") & "',0,0,0,'" & fila("Tipo") & "'," & fila("Nivel") & "," & fila("PARENTID")) 'psv
                Else
                    montoant = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & fechaI & "','" & fila("CuentaContable") & "'," & (fila("Nivel") + 1) & "," & ComboBox1.SelectedValue))
                    montomes = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & fechaI & "','" & fechaF & "','" & fila("CuentaContable") & "'," & (fila("Nivel") + 1) & "," & ComboBox1.SelectedValue))
                    cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & fila("CuentaContable") & "','" & fila("Descripcion") & "'," & montoant & "," & montomes & "," & (montoant + montomes) & ",'" & fila("Tipo") & "'," & fila("Nivel") & "," & fila("PARENTID")) 'psv
                End If

                montoant = 0
                montomes = 0

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        TotalCuentaMadre(tipo)
    End Sub


    Public Sub TotalCuentaMadre(ByVal TipoCuen As String)
        Dim DrCuentas() As System.Data.DataRow
        Dim DrCuenta As System.Data.DataRow
        Dim montoant, montomes, AcumuladoAnt, AcumuladoMes As Double

        Try
            If Me.DataSetMoneda.CuentasMadres.Count > 0 Then
                DrCuentas = Me.DataSetMoneda.CuentasMadres.Select("TipoCuenta = '" & TipoCuen & "'")

                If DrCuentas.Length <> 0 Then 'Si existe
                    For i As Integer = 0 To DrCuentas.Length - 1
                        montoant = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & CDate(Me.FechaInicial.Text) & "','" & DrCuentas(i)(0) & "',1," & ComboBox1.SelectedValue))
                        montomes = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & CDate(Me.FechaInicial.Text) & "','" & CDate(Me.fechafinal.Text) & "','" & DrCuentas(i)(0) & "',1," & ComboBox1.SelectedValue))
                        AcumuladoAnt += montoant
                        AcumuladoMes += montomes
                    Next

                    If TipoCuen = "INGRESOS" Then
                        saldoanting = AcumuladoAnt
                        saldomesing = AcumuladoMes
                    ElseIf TipoCuen = "COSTO VENTA" Then
                        saldoantcost = AcumuladoAnt
                        saldomescost = AcumuladoMes
                    ElseIf TipoCuen = "GASTOS" Then
                        saldoantgastos = AcumuladoAnt
                        saldomesgastos = AcumuladoMes
                    ElseIf TipoCuen = "OTROS INGRESOS" Then
                        saldoantingotros = AcumuladoAnt
                        saldomesingotros = AcumuladoMes
                    Else
                        saldoantgastosotros = AcumuladoAnt
                        saldomesgastosotros = AcumuladoMes
                    End If

                    cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'','TOTAL " & TipoCuen & "'," & AcumuladoAnt & "," & AcumuladoMes & "," & (AcumuladoAnt + AcumuladoMes) & ",'" & TipoCuen & "',0,0")
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region

#Region "KeyDown"
    Private Sub NumericUpDown1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDown1.KeyDown
        If e.KeyCode = Keys.Enter Then
            FechaInicial.Focus()
        End If
    End Sub

    Private Sub FechaInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles FechaInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            fechafinal.Focus()
        End If
    End Sub

    Private Sub fechafinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles fechafinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub ComboBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButAgregarDetalle.Focus()
        End If
    End Sub
#End Region

End Class
