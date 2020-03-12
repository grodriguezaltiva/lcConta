Imports Utilidades
Imports System.Data.SqlClient
Public Class frmBalance
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "
    Dim usua As Object
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
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents FechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents fechafinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ButAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Protected Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsGeneral1 As Contabilidad.DsGeneral
    Friend WithEvents AdapterCuentasMadres As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCuentaUtilidad As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CheckCuentas As System.Windows.Forms.CheckBox
    Friend WithEvents DsBalances1 As Contabilidad.DsBalances
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBalance))
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.fechafinal = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.ButAgregarDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.FechaInicial = New System.Windows.Forms.DateTimePicker
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.CheckCuentas = New System.Windows.Forms.CheckBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Moneda = New System.Windows.Forms.ComboBox
        Me.DsGeneral1 = New Contabilidad.DsGeneral
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCuentasMadres = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCuentaUtilidad = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DsBalances1 = New Contabilidad.DsBalances
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DsGeneral1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBalances1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(752, 32)
        Me.TituloModulo.TabIndex = 70
        Me.TituloModulo.Text = "                                           Balance General"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(645, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 32)
        Me.Label1.TabIndex = 71
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.fechafinal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.ButAgregarDetalle)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(800, 72)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Estado"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(432, 24)
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
        Me.Label2.Location = New System.Drawing.Point(232, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 89
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(48, 40)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown1.TabIndex = 3
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'fechafinal
        '
        Me.fechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fechafinal.Location = New System.Drawing.Point(432, 40)
        Me.fechafinal.Name = "fechafinal"
        Me.fechafinal.Size = New System.Drawing.Size(120, 20)
        Me.fechafinal.TabIndex = 1
        Me.fechafinal.Value = New Date(2007, 5, 17, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Nivel:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButAgregarDetalle
        '
        Me.ButAgregarDetalle.ImageIndex = 0
        Me.ButAgregarDetalle.Location = New System.Drawing.Point(648, 32)
        Me.ButAgregarDetalle.Name = "ButAgregarDetalle"
        Me.ButAgregarDetalle.Size = New System.Drawing.Size(129, 24)
        Me.ButAgregarDetalle.TabIndex = 74
        Me.ButAgregarDetalle.Text = "Mostrar"
        '
        'FechaInicial
        '
        Me.FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicial.Location = New System.Drawing.Point(165, 40)
        Me.FechaInicial.Name = "FechaInicial"
        Me.FechaInicial.Size = New System.Drawing.Size(120, 20)
        Me.FechaInicial.TabIndex = 0
        Me.FechaInicial.Value = New Date(2007, 5, 17, 0, 0, 0, 0)
        Me.FechaInicial.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 120)
        Me.Panel1.TabIndex = 74
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.CheckCuentas)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Moneda)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btnMostrar)
        Me.GroupBox2.Controls.Add(Me.FechaInicial)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.Location = New System.Drawing.Point(163, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(800, 72)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Estado"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(214, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Hasta:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(214, 40)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker2.TabIndex = 1
        Me.DateTimePicker2.Value = New Date(2007, 5, 17, 0, 0, 0, 0)
        '
        'CheckCuentas
        '
        Me.CheckCuentas.Location = New System.Drawing.Point(522, 35)
        Me.CheckCuentas.Name = "CheckCuentas"
        Me.CheckCuentas.Size = New System.Drawing.Size(115, 24)
        Me.CheckCuentas.TabIndex = 93
        Me.CheckCuentas.Text = "Mostrar Cuentas"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(379, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 92
        Me.Label11.Text = "Moneda :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Moneda
        '
        Me.Moneda.DataSource = Me.DsGeneral1.Moneda
        Me.Moneda.DisplayMember = "MonedaNombre"
        Me.Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Moneda.Location = New System.Drawing.Point(379, 37)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Size = New System.Drawing.Size(121, 22)
        Me.Moneda.TabIndex = 2
        Me.Moneda.ValueMember = "CodMoneda"
        '
        'DsGeneral1
        '
        Me.DsGeneral1.DataSetName = "DsGeneral"
        Me.DsGeneral1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(165, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Desde:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label7.Visible = False
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(48, 40)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(104, 20)
        Me.NumericUpDown2.TabIndex = 0
        Me.NumericUpDown2.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(165, 40)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 1
        Me.DateTimePicker1.Value = New Date(2007, 5, 17, 0, 0, 0, 0)
        Me.DateTimePicker1.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(48, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 16)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "Nivel:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMostrar
        '
        Me.btnMostrar.ImageIndex = 0
        Me.btnMostrar.Location = New System.Drawing.Point(648, 32)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(129, 24)
        Me.btnMostrar.TabIndex = 3
        Me.btnMostrar.Text = "Generar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(744, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(400, 32)
        Me.Label9.TabIndex = 70
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = CType(resources.GetObject("Label10.Image"), System.Drawing.Image)
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(-8, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(752, 32)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "                                           Balance General"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 120)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.CrystalReportViewer1.ShowGroupTreeButton = False
        Me.CrystalReportViewer1.ShowRefreshButton = False
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(995, 486)
        Me.CrystalReportViewer1.TabIndex = 75
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorVenta, Simbolo) VALUES (@CodMone" & _
        "da, @MonedaNombre, @ValorVenta, @Simbolo); SELECT CodMoneda, MonedaNombre, Valor" & _
        "Venta, Simbolo FROM Moneda"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
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
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CuentaContable, Descripcion, TipoCuenta FROM CuentasMadres"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'AdapterCuentaUtilidad
        '
        Me.AdapterCuentaUtilidad.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterCuentaUtilidad.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterCuentaUtilidad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaUtilidad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO CuentaUtilidad(CuentaContable, Descripcion, Nivel, Tipo, PARENTID) VA" & _
        "LUES (@CuentaContable, @Descripcion, @Nivel, @Tipo, @PARENTID); SELECT CuentaCon" & _
        "table, Descripcion, Nivel, Tipo, PARENTID FROM CuentaUtilidad"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, PARENTID FROM CuentaUtilidad"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'DsBalances1
        '
        Me.DsBalances1.DataSetName = "DsBalances"
        Me.DsBalances1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'frmBalance
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(995, 606)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TituloModulo)
        Me.Name = "frmBalance"
        Me.Text = "Balance General"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DsGeneral1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBalances1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim cconexion As New Conexion
    Dim conectadobd As New SqlClient.SqlConnection
    Dim rss As SqlClient.SqlDataReader
    Dim formato As Integer
    Dim descpas, primera_actdescripcion, primera_pasdesc, primera_capdesc As String
    Dim primera_activos, primera_pasivos, primera_capital, CuentaPeriodo, NombreCuentaPeriodo As String
    Dim Diferencia, TotalActivo, Utilidad As Double
    Dim saldoanting, saldomesing, saldoantgastos, saldomesgastos, saldoantcost, saldomescost As Double
#End Region

#Region "Load"
    Private Sub frmBalance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        conectadobd = cconexion.Conectar("Contabilidad")
        formato = cconexion.SlqExecuteScalar(conectadobd, "Select Niveles from FormatoCuenta")
        Me.NumericUpDown2.Maximum = formato
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        AdapterMoneda.Fill(DsGeneral1.Moneda)
        AdapterCuentasMadres.Fill(DsGeneral1.CuentasMadres)
        AdapterCuentaUtilidad.Fill(DsGeneral1.CuentaUtilidad)
        NumericUpDown2.Select()
        NumericUpDown2.Focus()
    End Sub
#End Region

#Region "Calculos"
    Private Sub estado(ByVal str As String)
        Dim dt As New DataSet
        dt.Tables.Clear()
        Dim adapter As New SqlClient.SqlDataAdapter(str, conectadobd)
        adapter.Fill(dt, "CuentaContable")
        Dim fila As DataRow
        Dim cuenta, fechaI, fechaF, primeracuenta, descripcion, tipo As String
        Dim montoant, montomes, montototal, paspat, SaldoCapital As Double
        fechaI = Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss")
        fechaF = Format(CDate(Me.DateTimePicker2.Value), "dd/MM/yyyy H:mm:ss")
        Dim g As Integer = 0
        Dim TotalmontoAnt, TotalmontoMes As Double
        Dim ii As Integer = 0
        For Each fila In dt.Tables("CuentaContable").Rows
            Try
                If g = 0 Then
                    If fila("Tipo") = "ACTIVOS" Then
                        primera_activos = fila("CuentaContable")
                        primera_actdescripcion = fila("descripcion")
                    ElseIf fila("Tipo") = "PASIVOS" Then
                        primera_pasivos = fila("CuentaContable")
                        primera_pasdesc = fila("descripcion")
                    ElseIf fila("Tipo") = "CAPITAL" Then
                        primera_capital = fila("CuentaContable")
                        primera_capdesc = fila("descripcion")
                    End If
                    primeracuenta = fila("CuentaContable")
                    descripcion = fila("Descripcion")
                    tipo = fila("Tipo")

                    montoant = Me.BuscarMonto(fila("CuentaContable"), "ANTERIOR") '(cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & fechaI & "','" & fila("CuentaContable") & "'," & (fila("Nivel") + 1) & "," & Moneda.SelectedValue))
                    montomes = Me.BuscarMonto(fila("CuentaContable"), "ACTUAL") '(cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & fechaI & "','" & fechaF & "','" & fila("CuentaContable") & "'," & (fila("Nivel") + 1) & "," & Moneda.SelectedValue))
                    cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & fila("CuentaContable") & "','" & fila("Descripcion") & "',0,0,0,'" & fila("Tipo") & "'," & fila("Nivel") & "," & fila("PARENTID")) 'psv

                Else
                    montoant = Me.BuscarMonto(fila("CuentaContable"), "ANTERIOR") '(cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & fechaI & "','" & fila("CuentaContable") & "'," & (fila("Nivel") + 1) & "," & Moneda.SelectedValue))
                    montomes = Me.BuscarMonto(fila("CuentaContable"), "ACTUAL") '(cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & fechaI & "','" & fechaF & "','" & fila("CuentaContable") & "'," & (fila("Nivel") + 1) & "," & Moneda.SelectedValue))
                    cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & fila("CuentaContable") & "','" & fila("Descripcion") & "'," & montoant & "," & montomes & "," & (montoant + montomes) & ",'" & fila("Tipo") & "'," & fila("Nivel") & "," & fila("PARENTID")) 'psv
                End If

                montoant = 0
                montomes = 0
                g += 1

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next

        montoant = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & fechaI & "','" & primeracuenta & "',1," & Moneda.SelectedValue))
        montomes = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & Format(CDate(DateTimePicker2.Text), "dd/MM/yyyy H:mm:ss") & "','" & primeracuenta & "',1," & Moneda.SelectedValue))
        If tipo = "ACTIVOS" Then
            TotalActivo = (montoant + montomes)
        End If

        If tipo = DsGeneral1.CuentaUtilidad(0).Tipo Then
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & DsGeneral1.CuentaUtilidad(0).CuentaContable & "','" & DsGeneral1.CuentaUtilidad(0).Descripcion & "'," & 0 & "," & 0 & "," & Utilidad & ",'" & tipo & "'," & DsGeneral1.CuentaUtilidad(0).Nivel & ",0")
            SaldoCapital = Utilidad + (montoant + montomes)
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & primeracuenta & "','TOTAL " & tipo & "'," & montoant & "," & montomes & "," & SaldoCapital & ",'" & tipo & "',0,0")
        Else
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & primeracuenta & "','TOTAL " & tipo & "'," & montoant & "," & montomes & "," & (montoant + montomes) & ",'" & tipo & "',0,0")
        End If
        cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','',0,0,0,'  ',0,0") 'psv ESPACIO SEPARADOR

        If tipo = "CAPITAL" Then
            Dim saldoantpas, saldoantpat, saldomespas, saldomespat, saldoactpas, saldoactpat As Double

            saldoantpas = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoAnt from Temporal where Descripcion = 'TOTAL PASIVOS'")
            saldoantpat = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoAnt from Temporal where Descripcion = 'TOTAL CAPITAL'")

            saldomespat = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoMes from Temporal where Descripcion = 'TOTAL CAPITAL'")
            saldomespas = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoMes from Temporal where Descripcion = 'TOTAL PASIVOS'")

            saldoactpas = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoAct from Temporal where Descripcion = 'TOTAL PASIVOS'")
            saldoactpat = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoAct from Temporal where Descripcion = 'TOTAL CAPITAL'")

            Dim totalant, totalmes, totalact As Double
            totalant = saldoantpas + saldoantpat
            totalmes = saldomespat + saldomespas
            totalact = saldoactpat + saldoactpas
            Diferencia = (TotalActivo - totalact)
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "'" & primeracuenta & "','TOTAL " & tipo & "+ PASIVOS'," & totalant & "," & totalmes & "," & totalact & ",'" & tipo & "',0,0") 'psv
        End If
    End Sub
    Private Sub Calcular_Saldos()
        Dim k As Integer
        Try
            For k = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
               
                    If DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos") - Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                    Else
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos") - Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                    End If

                    Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")

            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub generarBalance()
        Try
            Dim Fecha1, Fecha2 As Date
            Fecha1 = Format(Me.DateTimePicker2.Value.Date.AddDays(-10).Date, "dd/MM/yyyy H:mm:ss")
            Fecha2 = Format(Me.DateTimePicker2.Value.Date, "dd/MM/yyyy H:mm:ss")
            If Fecha1 > Fecha2 Then
                MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.DsBalances1.Temporal2.Clear()
            Me.DsBalances1.CuentaContable.Clear()
            Me.DsBalances1.Usuarios.Clear()
            Me.DsBalances1.DetallesAsientosContable.Clear()
            Me.DsBalances1.AsientosContables.Clear()
            cFunciones.Llenar_Tabla_Generico("Select * From CuentaContable", Me.DsBalances1.CuentaContable, Configuracion.Claves.Conexion("Contabilidad"))
            'Me.AdDetalleAsiento.Fill(Me.DsBalances1.DetallesAsientosContable) 'Llenar solo lo del mes del período de trabajo
            ' TreeList2.Columns(1).Width = 300
            LLenarCeros()
            CargarAsientos(Fecha1)
            CargarDebitos(Fecha1, Fecha2)
            Calcular_Saldos()
            Calcular()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Calcular()
        Dim i, n, j, k, h As Integer
        Dim SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual As Double
        Dim Total As String
        Dim SaldoAnterior1, Debitos1, Creditos1, SaldoMes1, SaldoActual1 As Double

        Try
            '-----------------------------------------------------------------------------------------------------------------------------------------
            Calcular(5)
            Calcular(4)
            Calcular(3)
            Calcular(2)
            Calcular(1)

            For k = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                If Me.DsBalances1.CuentaContable.Rows(k).Item("Nivel") = 0 Then
                    If DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                        SaldoAnterior = SaldoAnterior + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                        SaldoMes = SaldoMes + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                        SaldoActual = SaldoActual + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")
                    Else
                        SaldoAnterior = SaldoAnterior - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                        SaldoMes = SaldoMes - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                        SaldoActual = SaldoActual - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")
                    End If
                    Debitos = Debitos + Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                    Creditos = Creditos + Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                End If

            Next


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function Calcular(ByVal Nivel As Integer)
        Dim k, j As Integer
        For k = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
            If Me.DsBalances1.CuentaContable.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                    If Me.DsBalances1.CuentaContable.Rows(j).Item("Id") = Me.DsBalances1.CuentaContable.Rows(k).Item("PARENTID") Then

                        Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                        Me.DsBalances1.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalances1.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                        Me.DsBalances1.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalances1.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                        Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMes") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                        Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActual") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")

                    End If
                Next
            End If
        Next
    End Function

    Function CargarAsientos(ByVal FechaInicio As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES PARA EL CALCULO DEL SALDO ANTERIOR
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Dim i, n, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String

            
                sel = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
" SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
" FROM         dbo.AsientoDC_DH INNER JOIN " & _
" dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
" WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) " & _
" GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(Me.DateTimePicker2.Value)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsBalances1.AsientoDC_DH_AG.Clear()
            dv.Fill(Me.DsBalances1.AsientoDC_DH_AG)
            If Me.DsBalances1.AsientoDC_DH_AG.Rows.Count = 0 Then
                Exit Function
            End If
            For x = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1

                'For i = 0 To Me.DsBalances1.AsientosContables.Rows.Count - 1
                '    If Me.DsBalances1.AsientosContables(i).TipoDoc = 29 And DsBalances1.AsientosContables(i).CodMoneda <> Moneda.SelectedValue Then

                '    Else
                '        For n = 0 To Me.DsBalances1.DetallesAsientosContable.Rows.Count - 1
                '            If DsBalances1.AsientosContables.Rows(i).Item("NumAsiento") = DsBalances1.DetallesAsientosContable.Rows(n).Item("NumAsiento") And DsBalances1.CuentaContable.Rows(x).Item("CuentaContable") = DsBalances1.DetallesAsientosContable.Rows(n).Item("Cuenta") Then
                '                If DsBalances1.AsientosContables.Rows(i).Item("CodMoneda") = Moneda.SelectedValue Then
                '                    Monto = DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto")
                '                Else
                '                    If DsBalances1.AsientosContables.Rows(i).Item("CodMoneda") = 1 Then
                '                        If Me.DsBalances1.AsientosContables(i).TipoDoc = 27 Then
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") / DsBalances1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                '                        Else
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") / DsBalances1.AsientosContables.Rows(i).Item("TipoCambio"))
                '                        End If
                '                    Else
                '                        If Me.DsBalances1.AsientosContables(i).TipoDoc = 27 Then
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") * DsBalances1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                '                        Else
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") * DsBalances1.AsientosContables.Rows(i).Item("TipoCambio"))
                '                        End If
                '                    End If
                '                End If
                '                If DsBalances1.DetallesAsientosContable.Rows(n).Item("Debe") = True Then
                '                    Debe = Debe + Monto
                '                Else
                '                    Haber = Haber + Monto
                '                End If
                '            End If
                '        Next
                '    End If
                'Next
                For i = 0 To Me.DsBalances1.AsientoDC_DH_AG.Rows.Count - 1
                    If Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.Equals(Me.DsBalances1.CuentaContable(x).CuentaContable) Then
                       
                            If Moneda.SelectedValue = 1 Then
                                Debe += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                                Haber += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon

                            Else
                                Debe += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                                Haber += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar
                            End If

                        End If



                Next

                If DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                    DsBalances1.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                Else
                    DsBalances1.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                End If
                Debe = 0
                Haber = 0
                DebeD = 0
                HaberD = 0
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function


    Function CargarDebitos(ByVal FechaInicio As String, ByVal FechaFinal As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES DEL PERIODO
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Dim i, n, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = ""

            'Dim sel As String = "SELECT * FROM AsientoDC_DH_AG WHERE Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)"

            sel = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
            " FROM         dbo.AsientoDC_DH INNER JOIN " & _
            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
            " WHERE     (Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)) " & _
            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Fecha2", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha2").Value = Format(FechaFinal, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha2").Value = FechaFinal
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsBalances1.AsientoDC_DH_AG.Clear()

            dv.Fill(Me.DsBalances1.AsientoDC_DH_AG)
            Debe = 0
            Haber = 0
            DebeD = 0
            HaberD = 0

            For x = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                'For i = 0 To Me.DsBalances1.AsientosContables.Rows.Count - 1
                '    If Me.DsBalances1.AsientosContables(i).TipoDoc = 29 And DsBalances1.AsientosContables(i).CodMoneda <> Moneda.SelectedValue Then

                '    Else
                '        For n = 0 To Me.DsBalances1.DetallesAsientosContable.Rows.Count - 1
                '            If DsBalances1.AsientosContables.Rows(i).Item("NumAsiento") = DsBalances1.DetallesAsientosContable.Rows(n).Item("NumAsiento") And DsBalances1.CuentaContable.Rows(x).Item("CuentaContable") = DsBalances1.DetallesAsientosContable.Rows(n).Item("Cuenta") Then
                '                If DsBalances1.AsientosContables.Rows(i).Item("CodMoneda") = Moneda.SelectedValue Then
                '                    Monto = DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto")
                '                Else
                '                    If DsBalances1.AsientosContables.Rows(i).Item("CodMoneda") = 1 Then
                '                        If Me.DsBalances1.AsientosContables(i).TipoDoc = 27 Then
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") / DsBalances1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                '                        Else
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") / DsBalances1.AsientosContables.Rows(i).Item("TipoCambio"))
                '                        End If
                '                    Else
                '                        If Me.DsBalances1.AsientosContables(i).TipoDoc = 27 Then
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") * DsBalances1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                '                        Else
                '                            Monto = (DsBalances1.DetallesAsientosContable.Rows(n).Item("Monto") * DsBalances1.AsientosContables.Rows(i).Item("TipoCambio"))
                '                        End If
                '                    End If
                '                End If

                '                If DsBalances1.DetallesAsientosContable.Rows(n).Item("Debe") = True Then
                '                    Debe = Debe + Monto
                '                Else
                '                    Haber = Haber + Monto
                '                End If
                '            End If
                '        Next
                '    End If
                'Next

                For i = 0 To Me.DsBalances1.AsientoDC_DH_AG.Rows.Count - 1
                    Dim cuent As String = Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.TrimEnd(" ")
                    If cuent.Equals(Me.DsBalances1.CuentaContable(x).CuentaContable) Then
                       
                            If Moneda.SelectedValue = 1 Then
                                DsBalances1.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                                DsBalances1.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon
                            Else
                                DsBalances1.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                                DsBalances1.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar

                            End If

                    End If
                    'DsBalances1.CuentaContable.Rows(x).Item("Debitos") = Debe
                    'DsBalances1.CuentaContable.Rows(x).Item("Creditos") = Haber
                Next
                'DsBalances1.CuentaContable.Rows(x).Item("Debitos") = Debe
                'DsBalances1.CuentaContable.Rows(x).Item("Creditos") = Haber
                Debe = 0
                Haber = 0
                DebeD = 0
                HaberD = 0
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Private Sub LLenarCeros()
        Dim n As Integer
        For n = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
            DsBalances1.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
            DsBalances1.CuentaContable.Rows(n).Item("Debitos") = 0
            DsBalances1.CuentaContable.Rows(n).Item("Creditos") = 0
            DsBalances1.CuentaContable.Rows(n).Item("SaldoMes") = 0
            DsBalances1.CuentaContable.Rows(n).Item("SaldoActual") = 0
        Next
    End Sub
    Private Sub UtilidadPeriodo(ByVal TipoCuen As String)
        Dim DrCuentas() As System.Data.DataRow
        Dim DrCuenta As System.Data.DataRow
        Dim montoant, montomes, AcumuladoAnt, AcumuladoMes As Double

        Try
            If Me.DsGeneral1.CuentasMadres.Count > 0 Then
                DrCuentas = Me.DsGeneral1.CuentasMadres.Select("TipoCuenta = '" & TipoCuen & "'")

                If DrCuentas.Length <> 0 Then 'Si existe
                    For i As Integer = 0 To DrCuentas.Length - 1
                        montoant = Me.BuscarMonto(DrCuentas(i)(0), "ANTERIOR")
                        '(cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & DrCuentas(i)(0) & "',1," & Moneda.SelectedValue))
                        montomes = Me.BuscarMonto(DrCuentas(i)(0), "ACTUAL") '(cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & Format(CDate(Me.DateTimePicker2.Text), "dd/MM/yyyy H:mm:ss") & "','" & DrCuentas(i)(0) & "',1," & Moneda.SelectedValue))
                        AcumuladoAnt += montoant
                        AcumuladoMes += montomes
                    Next

                    If TipoCuen = "INGRESOS" Or TipoCuen = "OTROS INGRESOS" Then
                        saldoanting += AcumuladoAnt
                        saldomesing += AcumuladoMes
                    ElseIf TipoCuen = "GASTOS" Or TipoCuen = "OTROS GASTOS" Then
                        saldoantgastos += AcumuladoAnt
                        saldomesgastos += AcumuladoMes
                    Else
                        saldoantcost = AcumuladoAnt
                        saldomescost = AcumuladoMes
                    End If
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub
#End Region
    Function BuscarMonto(ByVal cuenta As String, ByVal tipo As String) As Double
        For i As Integer = 0 To Me.DsBalances1.AsientoDC_DH_AG.Count - 1
            If Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.Equals(cuenta) Then
                'If tipo.Equals("ACTUAL") Then
                '    Return DsBalances1.CuentaContable(i).SaldoActual
                'ElseIf tipo.Equals("ANTERIOR") Then
                Return DsBalances1.CuentaContable(i).SaldoActual
                ' End If

            End If

        Next


    End Function
#Region "Generar"
    Private Sub btnMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrar.Click
        Try
            Me.generarBalance()

            cconexion.DeleteRecords("Temporal", "") 'BORRA LA TABLA TEMPORAL
            Dim saldoantact, saldomesact As Double
            Dim saldoantpas, saldomespas As Double
            Dim saldoantcap, saldomescap As Double
            Dim str As String = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown2.Value & " and (Tipo='ACTIVOS') ORDER BY CuentaContable"

            'CALCULO DE LA UTILIDAD DEL PERIODO
            saldoanting = 0 : saldomesing = 0 : saldoantgastos = 0 : saldomesgastos = 0
            UtilidadPeriodo("INGRESOS")
            UtilidadPeriodo("COSTO VENTA")
            UtilidadPeriodo("GASTOS")
            UtilidadPeriodo("OTROS INGRESOS")
            UtilidadPeriodo("OTROS GASTOS")
            Utilidad = ((saldoanting - saldoantcost) - (saldoantgastos)) + ((saldomesing - saldomescost) - (saldomesgastos))

            estado(str)
            str = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown2.Value & " and (Tipo='PASIVOS')  ORDER BY CuentaContable"
            estado(str)
            str = "Select * from CuentaContable where Nivel < " & Me.NumericUpDown2.Value & " and (Tipo='CAPITAL') ORDER BY CuentaContable"
            estado(str)
            'TOTAL INGRESOS
            saldoantact = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & primera_activos & "',1," & Moneda.SelectedValue))
            saldomesact = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & Format(CDate(Me.DateTimePicker2.Value), "dd/MM/yyyy H:mm:ss") & "','" & primera_activos & "',1," & Moneda.SelectedValue))
            'TOTAL PASIVOS
            saldoantpas = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoAnterior '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & primera_pasivos & "',1," & Moneda.SelectedValue))
            saldomespas = (cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.SaldoMes '" & Format(CDate(Me.DateTimePicker1.Value), "dd/MM/yyyy H:mm:ss") & "','" & Format(CDate(Me.DateTimePicker2.Value), "dd/MM/yyyy H:mm:ss") & "','" & primera_pasivos & "',1," & Moneda.SelectedValue & ")"))
            'UTILIDAD BRUTA                           
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','UTILIDAD BRUTA'," & (saldoantact + saldoantpas) & "," & (saldomesact + saldomespas) & "," & (saldoantact + saldoantpas) + (saldomesact + saldomespas) & ",'UTILIDAD BRUTA',0, 0") 'psv

            'TOTAL CAPITAL      
            saldoantcap = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoAnt from Temporal where Descripcion = 'TOTAL CAPITAL'")
            saldomescap = cconexion.SlqExecuteScalar(conectadobd, "select Temporal.MontoMes from Temporal where Descripcion = 'TOTAL CAPITAL'")
            'UTILIDAD NETA
            cconexion.AddNewRecord("Temporal", "Cuenta, Descripcion, MontoAnt, MontoMes, MontoAct, Tipo, Nivel, parentid", "' ','UTILIDAD NETA'," & ((saldoantact + saldoantpas) + (saldoantcap)) & "," & ((saldomesact + saldomespas) + (saldomescap)) & "," & ((saldoantact + saldoantpas) + (saldoantcap)) + ((saldomesact + saldomespas) + (saldomescap)) & ",'UTILIDAD NETA',0, 0")

            Dim rptestado As New BalanceGeneral2
            rptestado.SetParameterValue(0, Me.NumericUpDown2.Value)
            rptestado.SetParameterValue(1, DateTimePicker2.Value)
            rptestado.SetParameterValue(2, DsGeneral1.Moneda(Me.Moneda.SelectedIndex).MonedaNombre)
            rptestado.SetParameterValue(3, Diferencia)
            rptestado.SetParameterValue(4, CheckCuentas.Checked)
            CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rptestado, False, Me.conectadobd.ConnectionString)
            Me.CrystalReportViewer1.Refresh()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "KeyDown"
    Private Sub NumericUpDown2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDown2.KeyDown
        If e.KeyCode = Keys.Enter Then
            DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DateTimePicker2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Moneda.Focus()
        End If
    End Sub

    Private Sub Moneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnMostrar.Focus()
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        DateTimePicker1.Value = "01" & "/" & DateTimePicker2.Value.Month & "/" & DateTimePicker2.Value.Year
    End Sub
#End Region

End Class
