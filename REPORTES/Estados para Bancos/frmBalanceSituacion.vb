Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraTreeList
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports Utilidades
Imports DevExpress.XtraTreeList.Columns

Public Class frmBalanceSituacion
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim ps As New DevExpress.XtraPrinting.PrintingSystem
    Dim link As New DevExpress.XtraPrinting.PrintableComponentLink(ps)
    Dim usua As Object
    Dim conectadobd As New SqlClient.SqlConnection
    Dim Cconexion As New Conexion
    Dim Reporte_ID As Integer
    Dim Tipo As Integer
    Dim EstadoResultado As Boolean = False
    Dim sub1 As Integer = 0
    Dim sub2 As Integer = 0
    Dim sub3 As Integer = 0
    Dim sub4 As Integer = 0
    Dim sub5 As Integer = 0
    Dim lI As Integer, lC As Integer, lG As Integer

#End Region
    Dim dst As New dtBalanceSituacion


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, ByVal tip As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        If tip = 2 Then
            Me.EstadoResultado = True
            Tipo = 0
        Else
            Tipo = tip
        End If

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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Check_Cierre As System.Windows.Forms.CheckBox
    Friend WithEvents Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents smbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarExportar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DtBalanceSituacion1 As Contabilidad.dtBalanceSituacion
    Friend WithEvents adTempSituacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adCuentaSituacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Public WithEvents GuardaTemporal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CheckBoxPrintBanco As System.Windows.Forms.CheckBox
    Friend WithEvents RadioButtonAnos As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonMeses As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioButtonXMes As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButtonXAno As System.Windows.Forms.RadioButton
    Friend WithEvents cbAno2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbAno1 As System.Windows.Forms.ComboBox
    Friend WithEvents TimeMes2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TimeMes1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPageREP As System.Windows.Forms.TabPage
    Friend WithEvents TabPageSPT As System.Windows.Forms.TabPage
    Friend WithEvents TabPageMA As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents fin2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxAño2 As System.Windows.Forms.ComboBox
    Friend WithEvents fin1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComboBoxAño1 As System.Windows.Forms.ComboBox
    Friend WithEvents TabPageCOMME As System.Windows.Forms.TabPage
    Friend WithEvents TabPageCOMANU As System.Windows.Forms.TabPage
    Friend WithEvents FechaMensual As System.Windows.Forms.DateTimePicker
    Friend WithEvents NumCantPeriodosMensuales As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NumCantPeriodosAnuales As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMESES As System.Windows.Forms.ComboBox
    Friend WithEvents DesdeAMES As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBalanceSituacion))
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RadioButtonAnos = New System.Windows.Forms.RadioButton
        Me.RadioButtonMeses = New System.Windows.Forms.RadioButton
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown
        Me.dtFinal = New System.Windows.Forms.DateTimePicker
        Me.CheckBoxPrintBanco = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown
        Me.Moneda = New System.Windows.Forms.ComboBox
        Me.DtBalanceSituacion1 = New Contabilidad.dtBalanceSituacion
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cbAno2 = New System.Windows.Forms.ComboBox
        Me.cbAno1 = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.TimeMes2 = New System.Windows.Forms.DateTimePicker
        Me.TimeMes1 = New System.Windows.Forms.DateTimePicker
        Me.Check_Cierre = New System.Windows.Forms.CheckBox
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExportar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adTempSituacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adCuentaSituacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GuardaTemporal = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RadioButtonXAno = New System.Windows.Forms.RadioButton
        Me.RadioButtonXMes = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPageSPT = New System.Windows.Forms.TabPage
        Me.TabPageMA = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.fin2 = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxAño2 = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.fin1 = New System.Windows.Forms.DateTimePicker
        Me.ComboBoxAño1 = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabPageREP = New System.Windows.Forms.TabPage
        Me.TabPageCOMME = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.NumCantPeriodosMensuales = New System.Windows.Forms.NumericUpDown
        Me.FechaMensual = New System.Windows.Forms.DateTimePicker
        Me.TabPageCOMANU = New System.Windows.Forms.TabPage
        Me.ComboBoxMESES = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.NumCantPeriodosAnuales = New System.Windows.Forms.NumericUpDown
        Me.DesdeAMES = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtBalanceSituacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPageSPT.SuspendLayout()
        Me.TabPageMA.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPageREP.SuspendLayout()
        Me.TabPageCOMME.SuspendLayout()
        CType(Me.NumCantPeriodosMensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageCOMANU.SuspendLayout()
        CType(Me.NumCantPeriodosAnuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(1080, 32)
        Me.TituloModulo.TabIndex = 61
        Me.TituloModulo.Text = "Balances de Situación"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.dtFinal)
        Me.Panel1.Controls.Add(Me.CheckBoxPrintBanco)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(728, 56)
        Me.Panel1.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButtonAnos)
        Me.GroupBox1.Controls.Add(Me.RadioButtonMeses)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(104, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 40)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Comparativo"
        '
        'RadioButtonAnos
        '
        Me.RadioButtonAnos.Location = New System.Drawing.Point(144, 16)
        Me.RadioButtonAnos.Name = "RadioButtonAnos"
        Me.RadioButtonAnos.Size = New System.Drawing.Size(64, 16)
        Me.RadioButtonAnos.TabIndex = 1
        Me.RadioButtonAnos.Text = "Años"
        '
        'RadioButtonMeses
        '
        Me.RadioButtonMeses.Checked = True
        Me.RadioButtonMeses.Location = New System.Drawing.Point(72, 16)
        Me.RadioButtonMeses.Name = "RadioButtonMeses"
        Me.RadioButtonMeses.Size = New System.Drawing.Size(72, 16)
        Me.RadioButtonMeses.TabIndex = 0
        Me.RadioButtonMeses.TabStop = True
        Me.RadioButtonMeses.Text = "Meses"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(8, 16)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown1.TabIndex = 91
        Me.NumericUpDown1.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'dtFinal
        '
        Me.dtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFinal.Location = New System.Drawing.Point(8, 8)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(88, 22)
        Me.dtFinal.TabIndex = 0
        '
        'CheckBoxPrintBanco
        '
        Me.CheckBoxPrintBanco.Location = New System.Drawing.Point(336, 16)
        Me.CheckBoxPrintBanco.Name = "CheckBoxPrintBanco"
        Me.CheckBoxPrintBanco.Size = New System.Drawing.Size(128, 24)
        Me.CheckBoxPrintBanco.TabIndex = 91
        Me.CheckBoxPrintBanco.Text = "Imprime para banco"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(768, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 24)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Cantidad de Niveles:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(904, 96)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDown2.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(48, 20)
        Me.NumericUpDown2.TabIndex = 89
        Me.NumericUpDown2.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'Moneda
        '
        Me.Moneda.DataSource = Me.DtBalanceSituacion1.Moneda
        Me.Moneda.DisplayMember = "MonedaNombre"
        Me.Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Moneda.Enabled = False
        Me.Moneda.Location = New System.Drawing.Point(840, 40)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Size = New System.Drawing.Size(121, 21)
        Me.Moneda.TabIndex = 6
        Me.Moneda.ValueMember = "CodMoneda"
        '
        'DtBalanceSituacion1
        '
        Me.DtBalanceSituacion1.DataSetName = "dtBalanceSituacion"
        Me.DtBalanceSituacion1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(768, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Moneda :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbAno2)
        Me.GroupBox3.Controls.Add(Me.cbAno1)
        Me.GroupBox3.Location = New System.Drawing.Point(384, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(144, 40)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Años"
        '
        'cbAno2
        '
        Me.cbAno2.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cbAno2.Location = New System.Drawing.Point(80, 16)
        Me.cbAno2.Name = "cbAno2"
        Me.cbAno2.Size = New System.Drawing.Size(56, 21)
        Me.cbAno2.TabIndex = 1
        Me.cbAno2.Text = "2012"
        '
        'cbAno1
        '
        Me.cbAno1.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cbAno1.Location = New System.Drawing.Point(8, 16)
        Me.cbAno1.Name = "cbAno1"
        Me.cbAno1.Size = New System.Drawing.Size(56, 21)
        Me.cbAno1.TabIndex = 0
        Me.cbAno1.Text = "2011"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TimeMes2)
        Me.GroupBox2.Controls.Add(Me.TimeMes1)
        Me.GroupBox2.Location = New System.Drawing.Point(72, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(216, 40)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = " Meses"
        '
        'TimeMes2
        '
        Me.TimeMes2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.TimeMes2.Location = New System.Drawing.Point(112, 16)
        Me.TimeMes2.Name = "TimeMes2"
        Me.TimeMes2.Size = New System.Drawing.Size(96, 20)
        Me.TimeMes2.TabIndex = 1
        '
        'TimeMes1
        '
        Me.TimeMes1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.TimeMes1.Location = New System.Drawing.Point(8, 16)
        Me.TimeMes1.Name = "TimeMes1"
        Me.TimeMes1.Size = New System.Drawing.Size(96, 20)
        Me.TimeMes1.TabIndex = 0
        '
        'Check_Cierre
        '
        Me.Check_Cierre.Enabled = False
        Me.Check_Cierre.Location = New System.Drawing.Point(768, 64)
        Me.Check_Cierre.Name = "Check_Cierre"
        Me.Check_Cierre.Size = New System.Drawing.Size(128, 32)
        Me.Check_Cierre.TabIndex = 7
        Me.Check_Cierre.Text = "Excluir Cierre Anual"
        '
        'smbGenerar
        '
        Me.smbGenerar.Enabled = False
        Me.smbGenerar.Location = New System.Drawing.Point(968, 48)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.Size = New System.Drawing.Size(96, 64)
        Me.smbGenerar.TabIndex = 4
        Me.smbGenerar.Text = "Generar"
        '
        'TreeList2
        '
        Me.TreeList2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList2.BehaviorOptions = DevExpress.XtraTreeList.BehaviorOptionsFlags.None
        Me.TreeList2.DataSource = CType((((((((DevExpress.XtraTreeList.BehaviorOptionsFlags.MoveOnEdit Or DevExpress.XtraTreeList.BehaviorOptionsFlags.DragNodes) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ExpandNodeOnDrag) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ResizeNodes) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoNodeHeight) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoChangeParent) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.KeepSelectedOnClick) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.SmartMouseHover), DevExpress.XtraTreeList.BehaviorOptionsFlags)
        Me.TreeList2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeList2.Location = New System.Drawing.Point(0, 128)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.ParentFieldName = "PARENTID"
        Me.TreeList2.Size = New System.Drawing.Size(1072, 312)
        Me.TreeList2.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyle("HeaderPanel", "TreeList", New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight))
        Me.TreeList2.TabIndex = 87
        Me.TreeList2.Text = "TreeList2"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarExportar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(100, 50)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 434)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1080, 52)
        Me.ToolBar1.TabIndex = 88
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarExportar
        '
        Me.ToolBarExportar.ImageIndex = 5
        Me.ToolBarExportar.Text = "Exportar"
        Me.ToolBarExportar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=IALVAREZ;packet size=4096;integrated security=SSPI;data source="".""" & _
        ";persist security info=False;initial catalog=Contabilidad"
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo, Cue" & _
        "ntaContable) VALUES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simb" & _
        "olo, @CuentaContable); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, " & _
        "Simbolo, CuentaContable FROM Moneda"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo, CuentaContable " & _
        "FROM Moneda"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'adTempSituacion
        '
        Me.adTempSituacion.DeleteCommand = Me.SqlDeleteCommand1
        Me.adTempSituacion.InsertCommand = Me.SqlInsertCommand2
        Me.adTempSituacion.SelectCommand = Me.SqlSelectCommand2
        Me.adTempSituacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TempSituacion", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Notas", "Notas"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("Comparativo", "Comparativo")})})
        Me.adTempSituacion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM TempSituacion WHERE (Cuenta = @Original_Cuenta) AND (Comparativo = @O" & _
        "riginal_Comparativo) AND (Mes = @Original_Mes) AND (NombreCuenta = @Original_Nom" & _
        "breCuenta) AND (Notas = @Original_Notas)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comparativo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comparativo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Notas", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notas", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO TempSituacion(Cuenta, NombreCuenta, Notas, Mes, Comparativo) VALUES (" & _
        "@Cuenta, @NombreCuenta, @Notas, @Mes, @Comparativo); SELECT Cuenta, NombreCuenta" & _
        ", Notas, Mes, Comparativo FROM TempSituacion WHERE (Cuenta = @Cuenta)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 100, "Cuenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Notas", System.Data.SqlDbType.VarChar, 15, "Notas"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.Float, 8, "Mes"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comparativo", System.Data.SqlDbType.Float, 8, "Comparativo"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Cuenta, NombreCuenta, Notas, Mes, Comparativo FROM TempSituacion"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE TempSituacion SET Cuenta = @Cuenta, NombreCuenta = @NombreCuenta, Notas = " & _
        "@Notas, Mes = @Mes, Comparativo = @Comparativo WHERE (Cuenta = @Original_Cuenta)" & _
        " AND (Comparativo = @Original_Comparativo) AND (Mes = @Original_Mes) AND (Nombre" & _
        "Cuenta = @Original_NombreCuenta) AND (Notas = @Original_Notas); SELECT Cuenta, N" & _
        "ombreCuenta, Notas, Mes, Comparativo FROM TempSituacion WHERE (Cuenta = @Cuenta)" & _
        ""
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 100, "Cuenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Notas", System.Data.SqlDbType.VarChar, 15, "Notas"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.Float, 8, "Mes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Comparativo", System.Data.SqlDbType.Float, 8, "Comparativo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Comparativo", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Comparativo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Notas", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Notas", System.Data.DataRowVersion.Original, Nothing))
        '
        'adCuentaSituacion
        '
        Me.adCuentaSituacion.DeleteCommand = Me.SqlDeleteCommand2
        Me.adCuentaSituacion.InsertCommand = Me.SqlInsertCommand3
        Me.adCuentaSituacion.SelectCommand = Me.SqlSelectCommand3
        Me.adCuentaSituacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Evaluacion", "Evaluacion"), New System.Data.Common.DataColumnMapping("CodTipoCompra", "CodTipoCompra"), New System.Data.Common.DataColumnMapping("DescTipoCompra", "DescTipoCompra")})})
        Me.adCuentaSituacion.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM CuentaContable WHERE (CuentaContable = @Original_CuentaContable) AND " & _
        "(CodTipoCompra = @Original_CodTipoCompra) AND (CuentaMadre = @Original_CuentaMad" & _
        "re) AND (DescCuentaMadre = @Original_DescCuentaMadre) AND (DescTipoCompra = @Ori" & _
        "ginal_DescTipoCompra) AND (Descripcion = @Original_Descripcion) AND (Evaluacion " & _
        "= @Original_Evaluacion) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Or" & _
        "iginal_Nivel) AND (PARENTID = @Original_PARENTID) AND (Tipo = @Original_Tipo) AN" & _
        "D (id = @Original_id)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodTipoCompra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodTipoCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescTipoCompra", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescTipoCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Evaluacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Evaluacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO CuentaContable(CuentaContable, Descripcion, Nivel, Tipo, PARENTID, Cu" & _
        "entaMadre, DescCuentaMadre, Movimiento, Evaluacion, CodTipoCompra, DescTipoCompr" & _
        "a) VALUES (@CuentaContable, @Descripcion, @Nivel, @Tipo, @PARENTID, @CuentaMadre" & _
        ", @DescCuentaMadre, @Movimiento, @Evaluacion, @CodTipoCompra, @DescTipoCompra); " & _
        "SELECT CuentaContable, Descripcion, Nivel, Tipo, PARENTID, CuentaMadre, DescCuen" & _
        "taMadre, Movimiento, id, Evaluacion, CodTipoCompra, DescTipoCompra FROM CuentaCo" & _
        "ntable WHERE (CuentaContable = @CuentaContable) ORDER BY CuentaContable"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Evaluacion", System.Data.SqlDbType.Bit, 1, "Evaluacion"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodTipoCompra", System.Data.SqlDbType.Int, 4, "CodTipoCompra"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescTipoCompra", System.Data.SqlDbType.VarChar, 75, "DescTipoCompra"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, PARENTID, CuentaMadre, DescCuent" & _
        "aMadre, Movimiento, id, Evaluacion, CodTipoCompra, DescTipoCompra FROM CuentaCon" & _
        "table ORDER BY CuentaContable"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE CuentaContable SET CuentaContable = @CuentaContable, Descripcion = @Descri" & _
        "pcion, Nivel = @Nivel, Tipo = @Tipo, PARENTID = @PARENTID, CuentaMadre = @Cuenta" & _
        "Madre, DescCuentaMadre = @DescCuentaMadre, Movimiento = @Movimiento, Evaluacion " & _
        "= @Evaluacion, CodTipoCompra = @CodTipoCompra, DescTipoCompra = @DescTipoCompra " & _
        "WHERE (CuentaContable = @Original_CuentaContable) AND (CodTipoCompra = @Original" & _
        "_CodTipoCompra) AND (CuentaMadre = @Original_CuentaMadre) AND (DescCuentaMadre =" & _
        " @Original_DescCuentaMadre) AND (DescTipoCompra = @Original_DescTipoCompra) AND " & _
        "(Descripcion = @Original_Descripcion) AND (Evaluacion = @Original_Evaluacion) AN" & _
        "D (Movimiento = @Original_Movimiento) AND (Nivel = @Original_Nivel) AND (PARENTI" & _
        "D = @Original_PARENTID) AND (Tipo = @Original_Tipo); SELECT CuentaContable, Desc" & _
        "ripcion, Nivel, Tipo, PARENTID, CuentaMadre, DescCuentaMadre, Movimiento, id, Ev" & _
        "aluacion, CodTipoCompra, DescTipoCompra FROM CuentaContable WHERE (CuentaContabl" & _
        "e = @CuentaContable) ORDER BY CuentaContable"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Evaluacion", System.Data.SqlDbType.Bit, 1, "Evaluacion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodTipoCompra", System.Data.SqlDbType.Int, 4, "CodTipoCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescTipoCompra", System.Data.SqlDbType.VarChar, 75, "DescTipoCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodTipoCompra", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodTipoCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescTipoCompra", System.Data.SqlDbType.VarChar, 75, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescTipoCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Evaluacion", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Evaluacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'GuardaTemporal
        '
        Me.GuardaTemporal.DeleteCommand = Me.SqlDeleteCommand3
        Me.GuardaTemporal.InsertCommand = Me.SqlInsertCommand4
        Me.GuardaTemporal.SelectCommand = Me.SqlSelectCommand4
        Me.GuardaTemporal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TemporalBalance", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("SaldoP", "SaldoP"), New System.Data.Common.DataColumnMapping("SaldoPD", "SaldoPD"), New System.Data.Common.DataColumnMapping("SaldoP2", "SaldoP2"), New System.Data.Common.DataColumnMapping("SaldoPD2", "SaldoPD2"), New System.Data.Common.DataColumnMapping("SaldoP3", "SaldoP3"), New System.Data.Common.DataColumnMapping("SaldoPD3", "SaldoPD3"), New System.Data.Common.DataColumnMapping("SaldoP4", "SaldoP4"), New System.Data.Common.DataColumnMapping("SaldoPD4", "SaldoPD4"), New System.Data.Common.DataColumnMapping("SaldoP5", "SaldoP5"), New System.Data.Common.DataColumnMapping("SaldoPD5", "SaldoPD5"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo")})})
        Me.GuardaTemporal.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM TemporalBalance WHERE (CuentaContable = @Original_CuentaContable) AND" & _
        " (Descripcion = @Original_Descripcion) AND (Id = @Original_Id) AND (Movimiento =" & _
        " @Original_Movimiento) AND (Nivel = @Original_Nivel) AND (PARENTID = @Original_P" & _
        "ARENTID) AND (SaldoP = @Original_SaldoP) AND (SaldoP2 = @Original_SaldoP2) AND (" & _
        "SaldoP3 = @Original_SaldoP3) AND (SaldoP4 = @Original_SaldoP4) AND (SaldoP5 = @O" & _
        "riginal_SaldoP5) AND (SaldoPD = @Original_SaldoPD) AND (SaldoPD2 = @Original_Sal" & _
        "doPD2) AND (SaldoPD3 = @Original_SaldoPD3) AND (SaldoPD4 = @Original_SaldoPD4) A" & _
        "ND (SaldoPD5 = @Original_SaldoPD5) AND (Tipo = @Original_Tipo OR @Original_Tipo " & _
        "IS NULL AND Tipo IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP3", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP4", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP5", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD3", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD4", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD5", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO TemporalBalance(CuentaContable, Descripcion, Nivel, Movimiento, Id, P" & _
        "ARENTID, SaldoP, SaldoPD, SaldoP2, SaldoPD2, SaldoP3, SaldoPD3, SaldoP4, SaldoPD" & _
        "4, SaldoP5, SaldoPD5, Tipo) VALUES (@CuentaContable, @Descripcion, @Nivel, @Movi" & _
        "miento, @Id, @PARENTID, @SaldoP, @SaldoPD, @SaldoP2, @SaldoPD2, @SaldoP3, @Saldo" & _
        "PD3, @SaldoP4, @SaldoPD4, @SaldoP5, @SaldoPD5, @Tipo); SELECT CuentaContable, De" & _
        "scripcion, Nivel, Movimiento, Id, PARENTID, SaldoP, SaldoPD, SaldoP2, SaldoPD2, " & _
        "SaldoP3, SaldoPD3, SaldoP4, SaldoPD4, SaldoP5, SaldoPD5, Tipo FROM TemporalBalan" & _
        "ce WHERE (CuentaContable = @CuentaContable)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP", System.Data.SqlDbType.Float, 8, "SaldoP"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD", System.Data.SqlDbType.Float, 8, "SaldoPD"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP2", System.Data.SqlDbType.Float, 8, "SaldoP2"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD2", System.Data.SqlDbType.Float, 8, "SaldoPD2"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP3", System.Data.SqlDbType.Float, 8, "SaldoP3"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD3", System.Data.SqlDbType.Float, 8, "SaldoPD3"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP4", System.Data.SqlDbType.Float, 8, "SaldoP4"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD4", System.Data.SqlDbType.Float, 8, "SaldoPD4"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP5", System.Data.SqlDbType.Float, 8, "SaldoP5"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD5", System.Data.SqlDbType.Float, 8, "SaldoPD5"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Movimiento, Id, PARENTID, SaldoP, Sald" & _
        "oPD, SaldoP2, SaldoPD2, SaldoP3, SaldoPD3, SaldoP4, SaldoPD4, SaldoP5, SaldoPD5," & _
        " Tipo FROM TemporalBalance"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE TemporalBalance SET CuentaContable = @CuentaContable, Descripcion = @Descr" & _
        "ipcion, Nivel = @Nivel, Movimiento = @Movimiento, Id = @Id, PARENTID = @PARENTID" & _
        ", SaldoP = @SaldoP, SaldoPD = @SaldoPD, SaldoP2 = @SaldoP2, SaldoPD2 = @SaldoPD2" & _
        ", SaldoP3 = @SaldoP3, SaldoPD3 = @SaldoPD3, SaldoP4 = @SaldoP4, SaldoPD4 = @Sald" & _
        "oPD4, SaldoP5 = @SaldoP5, SaldoPD5 = @SaldoPD5, Tipo = @Tipo WHERE (CuentaContab" & _
        "le = @Original_CuentaContable) AND (Descripcion = @Original_Descripcion) AND (Id" & _
        " = @Original_Id) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Original_" & _
        "Nivel) AND (PARENTID = @Original_PARENTID) AND (SaldoP = @Original_SaldoP) AND (" & _
        "SaldoP2 = @Original_SaldoP2) AND (SaldoP3 = @Original_SaldoP3) AND (SaldoP4 = @O" & _
        "riginal_SaldoP4) AND (SaldoP5 = @Original_SaldoP5) AND (SaldoPD = @Original_Sald" & _
        "oPD) AND (SaldoPD2 = @Original_SaldoPD2) AND (SaldoPD3 = @Original_SaldoPD3) AND" & _
        " (SaldoPD4 = @Original_SaldoPD4) AND (SaldoPD5 = @Original_SaldoPD5) AND (Tipo =" & _
        " @Original_Tipo OR @Original_Tipo IS NULL AND Tipo IS NULL); SELECT CuentaContab" & _
        "le, Descripcion, Nivel, Movimiento, Id, PARENTID, SaldoP, SaldoPD, SaldoP2, Sald" & _
        "oPD2, SaldoP3, SaldoPD3, SaldoP4, SaldoPD4, SaldoP5, SaldoPD5, Tipo FROM Tempora" & _
        "lBalance WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP", System.Data.SqlDbType.Float, 8, "SaldoP"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD", System.Data.SqlDbType.Float, 8, "SaldoPD"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP2", System.Data.SqlDbType.Float, 8, "SaldoP2"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD2", System.Data.SqlDbType.Float, 8, "SaldoPD2"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP3", System.Data.SqlDbType.Float, 8, "SaldoP3"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD3", System.Data.SqlDbType.Float, 8, "SaldoPD3"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP4", System.Data.SqlDbType.Float, 8, "SaldoP4"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD4", System.Data.SqlDbType.Float, 8, "SaldoPD4"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoP5", System.Data.SqlDbType.Float, 8, "SaldoP5"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoPD5", System.Data.SqlDbType.Float, 8, "SaldoPD5"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 50, "Tipo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP3", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP4", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoP5", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoP5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD2", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD3", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD4", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoPD5", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoPD5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButtonXAno)
        Me.Panel2.Controls.Add(Me.RadioButtonXMes)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Location = New System.Drawing.Point(8, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(536, 56)
        Me.Panel2.TabIndex = 95
        '
        'RadioButtonXAno
        '
        Me.RadioButtonXAno.Location = New System.Drawing.Point(312, 16)
        Me.RadioButtonXAno.Name = "RadioButtonXAno"
        Me.RadioButtonXAno.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonXAno.TabIndex = 96
        Me.RadioButtonXAno.Text = "Por año"
        '
        'RadioButtonXMes
        '
        Me.RadioButtonXMes.Location = New System.Drawing.Point(8, 16)
        Me.RadioButtonXMes.Name = "RadioButtonXMes"
        Me.RadioButtonXMes.Size = New System.Drawing.Size(64, 24)
        Me.RadioButtonXMes.TabIndex = 95
        Me.RadioButtonXMes.Text = "Por mes"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPageSPT)
        Me.TabControl1.Controls.Add(Me.TabPageMA)
        Me.TabControl1.Controls.Add(Me.TabPageREP)
        Me.TabControl1.Controls.Add(Me.TabPageCOMME)
        Me.TabControl1.Controls.Add(Me.TabPageCOMANU)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(752, 96)
        Me.TabControl1.TabIndex = 96
        '
        'TabPageSPT
        '
        Me.TabPageSPT.Controls.Add(Me.Panel1)
        Me.TabPageSPT.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSPT.Name = "TabPageSPT"
        Me.TabPageSPT.Size = New System.Drawing.Size(744, 70)
        Me.TabPageSPT.TabIndex = 1
        Me.TabPageSPT.Text = "Saldos entre periodos hasta"
        '
        'TabPageMA
        '
        Me.TabPageMA.Controls.Add(Me.GroupBox5)
        Me.TabPageMA.Controls.Add(Me.GroupBox4)
        Me.TabPageMA.Location = New System.Drawing.Point(4, 22)
        Me.TabPageMA.Name = "TabPageMA"
        Me.TabPageMA.Size = New System.Drawing.Size(744, 70)
        Me.TabPageMA.TabIndex = 2
        Me.TabPageMA.Text = "Comparativo mes - año"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.fin2)
        Me.GroupBox5.Controls.Add(Me.ComboBoxAño2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(216, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(208, 49)
        Me.GroupBox5.TabIndex = 96
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Segundo año - mes"
        '
        'fin2
        '
        Me.fin2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fin2.Location = New System.Drawing.Point(104, 16)
        Me.fin2.Name = "fin2"
        Me.fin2.Size = New System.Drawing.Size(96, 20)
        Me.fin2.TabIndex = 2
        '
        'ComboBoxAño2
        '
        Me.ComboBoxAño2.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBoxAño2.Location = New System.Drawing.Point(8, 16)
        Me.ComboBoxAño2.Name = "ComboBoxAño2"
        Me.ComboBoxAño2.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxAño2.TabIndex = 0
        Me.ComboBoxAño2.Text = "2012"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(64, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "hasta:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.fin1)
        Me.GroupBox4.Controls.Add(Me.ComboBoxAño1)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(208, 49)
        Me.GroupBox4.TabIndex = 95
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Primer año - mes"
        '
        'fin1
        '
        Me.fin1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.fin1.Location = New System.Drawing.Point(104, 16)
        Me.fin1.Name = "fin1"
        Me.fin1.Size = New System.Drawing.Size(96, 20)
        Me.fin1.TabIndex = 2
        '
        'ComboBoxAño1
        '
        Me.ComboBoxAño1.Items.AddRange(New Object() {"2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.ComboBoxAño1.Location = New System.Drawing.Point(8, 16)
        Me.ComboBoxAño1.Name = "ComboBoxAño1"
        Me.ComboBoxAño1.Size = New System.Drawing.Size(56, 21)
        Me.ComboBoxAño1.TabIndex = 0
        Me.ComboBoxAño1.Text = "2011"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "hasta:"
        '
        'TabPageREP
        '
        Me.TabPageREP.Controls.Add(Me.Panel2)
        Me.TabPageREP.Location = New System.Drawing.Point(4, 22)
        Me.TabPageREP.Name = "TabPageREP"
        Me.TabPageREP.Size = New System.Drawing.Size(744, 70)
        Me.TabPageREP.TabIndex = 0
        Me.TabPageREP.Text = "Resultados entre periodos"
        '
        'TabPageCOMME
        '
        Me.TabPageCOMME.Controls.Add(Me.Label5)
        Me.TabPageCOMME.Controls.Add(Me.Label4)
        Me.TabPageCOMME.Controls.Add(Me.NumCantPeriodosMensuales)
        Me.TabPageCOMME.Controls.Add(Me.FechaMensual)
        Me.TabPageCOMME.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCOMME.Name = "TabPageCOMME"
        Me.TabPageCOMME.Size = New System.Drawing.Size(744, 70)
        Me.TabPageCOMME.TabIndex = 3
        Me.TabPageCOMME.Text = "Comparativo Mensual"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Desde:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(384, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "meses"
        '
        'NumCantPeriodosMensuales
        '
        Me.NumCantPeriodosMensuales.Enabled = False
        Me.NumCantPeriodosMensuales.Location = New System.Drawing.Point(328, 24)
        Me.NumCantPeriodosMensuales.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumCantPeriodosMensuales.Name = "NumCantPeriodosMensuales"
        Me.NumCantPeriodosMensuales.Size = New System.Drawing.Size(48, 20)
        Me.NumCantPeriodosMensuales.TabIndex = 1
        '
        'FechaMensual
        '
        Me.FechaMensual.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaMensual.Location = New System.Drawing.Point(232, 24)
        Me.FechaMensual.Name = "FechaMensual"
        Me.FechaMensual.Size = New System.Drawing.Size(88, 20)
        Me.FechaMensual.TabIndex = 0
        '
        'TabPageCOMANU
        '
        Me.TabPageCOMANU.Controls.Add(Me.ComboBoxMESES)
        Me.TabPageCOMANU.Controls.Add(Me.Label7)
        Me.TabPageCOMANU.Controls.Add(Me.NumCantPeriodosAnuales)
        Me.TabPageCOMANU.Controls.Add(Me.DesdeAMES)
        Me.TabPageCOMANU.Controls.Add(Me.Label6)
        Me.TabPageCOMANU.Location = New System.Drawing.Point(4, 22)
        Me.TabPageCOMANU.Name = "TabPageCOMANU"
        Me.TabPageCOMANU.Size = New System.Drawing.Size(744, 70)
        Me.TabPageCOMANU.TabIndex = 4
        Me.TabPageCOMANU.Text = "Comparativo Anual por meses"
        '
        'ComboBoxMESES
        '
        Me.ComboBoxMESES.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.ComboBoxMESES.Location = New System.Drawing.Point(464, 24)
        Me.ComboBoxMESES.Name = "ComboBoxMESES"
        Me.ComboBoxMESES.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMESES.TabIndex = 4
        Me.ComboBoxMESES.Visible = False
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(384, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "meses"
        '
        'NumCantPeriodosAnuales
        '
        Me.NumCantPeriodosAnuales.Enabled = False
        Me.NumCantPeriodosAnuales.Location = New System.Drawing.Point(328, 24)
        Me.NumCantPeriodosAnuales.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.NumCantPeriodosAnuales.Name = "NumCantPeriodosAnuales"
        Me.NumCantPeriodosAnuales.Size = New System.Drawing.Size(48, 20)
        Me.NumCantPeriodosAnuales.TabIndex = 2
        '
        'DesdeAMES
        '
        Me.DesdeAMES.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DesdeAMES.Location = New System.Drawing.Point(232, 24)
        Me.DesdeAMES.Name = "DesdeAMES"
        Me.DesdeAMES.Size = New System.Drawing.Size(88, 20)
        Me.DesdeAMES.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(176, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Desde:"
        '
        'frmBalanceSituacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1080, 486)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.smbGenerar)
        Me.Controls.Add(Me.Check_Cierre)
        Me.Controls.Add(Me.Moneda)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmBalanceSituacion"
        Me.Text = "Balance de Situación"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtBalanceSituacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPageSPT.ResumeLayout(False)
        Me.TabPageMA.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TabPageREP.ResumeLayout(False)
        Me.TabPageCOMME.ResumeLayout(False)
        CType(Me.NumCantPeriodosMensuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageCOMANU.ResumeLayout(False)
        CType(Me.NumCantPeriodosAnuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"

    Function Estado(ByVal valor As Boolean)
        dtFinal.Enabled = valor
        smbGenerar.Enabled = valor
        Check_Cierre.Enabled = valor
        NumericUpDown2.Enabled = valor
    End Function

    Private Sub CreateColumn(ByVal tl As TreeList, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
        Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = tl.Columns.Add()
        col.Caption = caption
        col.FieldName = field

        col.AbsoluteIndex = visibleindex
        col.VisibleIndex = visibleindex
        col.Format.FormatType = formatType
        If formatType = DevExpress.Utils.FormatType.Custom Then
            col.Format.Format = New BaseFormatter
        End If
        col.Format.FormatString = formatString
    End Sub
    Sub definirColumnas(ByVal FormaFecha As String, ByVal conDolar As Boolean)
        Dim i As Int16 = NumericUpDown1.Value
        Dim simb As String = " ¢"
        If Tipo = 1 Then
        Else
            If Moneda.SelectedValue = 2 Then
                simb = " $"
            Else
                simb = " ¢"
            End If

        End If
        If FormaFecha.Equals("Meses") Then

            CreateColumn(TreeList2, Format(dtFinal.Value, "MMMM,yyyy") & " " & simb, "Saldo", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value, "MMMM,yyyy") & " $", "SaldoD", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            If i >= 1 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " " & simb, "SaldoP2", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " $", "SaldoDP2", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If

            If i >= 2 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " " & simb, "SaldoP3", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " $", "SaldoDP3", 7, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If
            If i >= 3 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " " & simb, "SaldoP4", 8, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " $", "SaldoDP4", 9, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If
            If i >= 4 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " " & simb, "SaldoP5", 10, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " $", "SaldoDP5", 11, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If
            If i >= 5 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-5), "MMMM,yyyy") & " " & simb, "SaldoP6", 12, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-5), "MMMM,yyyy") & " $", "SaldoDP6", 13, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If
        Else

            CreateColumn(TreeList2, Format(dtFinal.Value, "yyyy") & " " & simb, "Saldo", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value, "yyyy") & " $", "SaldoD", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")


            If i >= 1 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-1), "yyyy") & " " & simb, "SaldoP2", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-1), "yyyy") & " $", "SaldoDP2", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If

            If i >= 2 Then
                CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-2), "yyyy") & " " & simb, "SaldoP3", 7, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                If conDolar Then CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-2), "yyyy") & " $", "SaldoDP3", 8, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            End If

        End If
    End Sub
    Private Sub InitData()
        'Cuando tipo = 1 monta los colones y dólares
        TreeList2.Columns.Clear()
        If Tipo = 1 Then

            CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
            ' CreateColumn(TreeList2, Format(dtFinal.Value, "MMMM,yyyy") & " ¢", "Saldo", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            'Se defini si es meses o años
            If RadioButtonMeses.Checked = True Then
                'CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " ¢", "Saldo", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                'CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " $", "SaldoD", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                definirColumnas("Meses", True)


            Else
                'CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-1), "MMMM,yyyy") & " ¢", "SaldoP2", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                'CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-1), "MMMM,yyyy") & " $", "SaldoDP2", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                definirColumnas("Años", True)
            End If
            'CreateColumn(TreeList2, Format(dtFinal.Value, "MMMM,yyyy") & " $", "SaldoD", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        Else
            CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
            ' CreateColumn(TreeList2, Format(dtFinal.Value, "MMMM,yyyy"), "Saldo", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            If RadioButtonMeses.Checked = True Then
                'CreateColumn(TreeList2, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy"), "Saldo", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                definirColumnas("Meses", False)
            Else
                'CreateColumn(TreeList2, Format(dtFinal.Value.AddYears(-1), "MMMM,yyyy"), "SaldoP2", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
                definirColumnas("Años", False)
            End If
        End If
        TreeList2.BestFitColumns()
    End Sub

    Private Sub frmBalanceSituacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Conexión a la base de datos
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            conectadobd = Cconexion.Conectar("Contabilidad")
            'Inhabilitar o habilitar los componentes
            Estado(False)
            AdapterMoneda.Fill(DtBalanceSituacion1, "Moneda")
            If EstadoResultado Then
                Text = "ESTADO RESULTADOS COMPARATIVO"
                TituloModulo.Text = "ESTADO RESULTADOS COMPARATIVO"
                Moneda.Visible = True
                Label8.Visible = True
            Else
                If Tipo = 1 Then
                    Moneda.Visible = False
                    Label8.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Generar Comparativo mes - año"
    Dim pM1A1 As Date
    Dim pM2A1 As Date
    Dim pM3A1 As Date

    Dim pM1A2 As Date
    Dim pM2A2 As Date
    Dim pM3A2 As Date
    Sub generarMA()
        Try
            Me.pM1A1 = CDate(Format(Me.fin1.Value, "dd/MM/") & Me.ComboBoxAño1.Text)
            Me.pM2A1 = CDate(Format(Me.fin1.Value.AddMonths(-1), "dd/MM/") & Me.ComboBoxAño1.Text)
            Me.pM3A1 = CDate(Format(Me.fin1.Value.AddMonths(-2), "dd/MM/") & Me.ComboBoxAño1.Text)

            Me.pM1A2 = CDate(Format(Me.fin2.Value, "dd/MM/") & Me.ComboBoxAño2.Text)
            Me.pM2A2 = CDate(Format(Me.fin2.Value.AddMonths(-1), "dd/MM/") & Me.ComboBoxAño2.Text)
            Me.pM3A2 = CDate(Format(Me.fin2.Value.AddMonths(-2), "dd/MM/") & Me.ComboBoxAño2.Text)

        Catch ex As Exception
            MsgBox("Rangos no validos")

        End Try

        InitDataCompartivoMA()
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        cargarSaldosPeriodoMovimientos(Me.pM1A1, "SM1A1")
        cargarSaldosPeriodoMovimientos(Me.pM2A1, "SM2A1")
        cargarSaldosPeriodoMovimientos(Me.pM3A1, "SM3A1")

        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        cargarSaldosPeriodoMovimientos(Me.pM1A2, "SM1A2")
        cargarSaldosPeriodoMovimientos(Me.pM2A2, "SM2A2")
        cargarSaldosPeriodoMovimientos(Me.pM3A2, "SM3A2")
        calcularHaciaArriba()
        Me.TreeList2.Refresh()

    End Sub
    Sub generarAMES()
        Dim f1 As Date
        Dim f2 As Date
        Try
            pM1A1 = Me.DesdeAMES.Value
            Me.casaFechas(Me.pM1A1, f1, f2, False)
            Me.pM1A1 = f2
            Me.casaFechas(Me.pM1A1.AddMonths(-1), f1, f2, False)
            Me.pM2A1 = f2
            Me.casaFechas(Me.pM1A1.AddMonths(-2), f1, f2, False)
            Me.pM3A1 = f2

            Me.casaFechas(Me.pM1A1.AddYears(-1), f1, f2, False)
            Me.pM1A2 = f2
            Me.casaFechas(f1.AddMonths(-1), f1, f2, False)
            Me.pM2A2 = f2
            Me.casaFechas(f1.AddMonths(-1), f1, f2, False)
            Me.pM3A2 = f2



        Catch ex As Exception
            MsgBox("Rangos no validos")

        End Try

        InitDataCompartivoMA()
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

        Me.casaFechas(Me.pM1A1, f1, f2, False)
        Me.GenerarMovimientosPeriodo(f1, f2, "SM1A1", "H", "D")
        cargarSaldosPeriodoMovimientos(f2, "ACUMM1A1")

        Me.casaFechas(Me.pM2A1, f1, f2, False)
        Me.GenerarMovimientosPeriodo(f1, f2, "SM2A1", "H", "D")
        Me.casaFechas(Me.pM3A1, f1, f2, False)
        Me.GenerarMovimientosPeriodo(f1, f2, "SM3A1", "H", "D")

        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        Me.casaFechas(Me.pM1A2, f1, f2, False)
        Me.GenerarMovimientosPeriodo(f1, f2, "SM1A2", "H", "D")
        cargarSaldosPeriodoMovimientos(f2, "ACUMM1A2")
        Me.casaFechas(Me.pM2A2, f1, f2, False)
        Me.GenerarMovimientosPeriodo(f1, f2, "SM2A2", "H", "D")

        Me.casaFechas(Me.pM3A2, f1, f2, False)
        Me.GenerarMovimientosPeriodo(f1, f2, "SM3A2", "H", "D")

        calcularHaciaArriba()
        Me.TreeList2.Refresh()

    End Sub
    Sub generarMesxMes()
        Dim f1 As Date
        Dim f2 As Date
        Try
            pM1A1 = Me.FechaMensual.Value
            Me.casaFechas(Me.pM1A1, f1, f2, False)
            Me.pM1A1 = f2
            Me.casaFechas(Me.pM1A1.AddMonths(-1), f1, f2, False)
            Me.pM2A1 = f2
            Me.casaFechas(Me.pM1A1.AddMonths(-2), f1, f2, False)
            Me.pM3A1 = f2
        Catch ex As Exception
            MsgBox("Rangos no validos")

        End Try
        Try

            InitDataCompartivoMA()
            '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
            Me.casaFechas(Me.pM1A1, f1, f2, False)
            Me.GenerarMovimientosPeriodo(f1, f2, "SM1A1", "H", "D")
            cargarSaldosPeriodoMovimientos(f2, "ACUMM1A1")
            Me.casaFechas(Me.pM2A1, f1, f2, False)
            Me.GenerarMovimientosPeriodo(f1, f2, "SM2A1", "H", "D")
            Me.casaFechas(Me.pM3A1, f1, f2, False)
            Me.GenerarMovimientosPeriodo(f1, f2, "SM3A1", "H", "D")
            calcularHaciaArriba()
            Me.TreeList2.Refresh()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub InitDataCompartivoMA()
        'Cuando tipo = 1 monta los colones y dólares
        TreeList2.Columns.Clear()

        TreeList2.DataSource = Me.dstP
        TreeList2.DataMember = "MesAno"
        Dim tipo As String
        If Not Me.EstadoResultado Then
            tipo = " WHERE Tipo = 'ACTIVOS' OR Tipo = 'PASIVOS' OR Tipo = 'CAPITAL' "
        Else
            tipo = " WHERE Tipo = 'INGRESOS' OR Tipo = 'COSTO VENTA' OR Tipo = 'GASTOS' OR Tipo = 'OTROS INGRESOS' OR Tipo = 'OTROS GASTOS' "
        End If
        cFunciones.Llenar_Tabla_Generico("Select CuentaContable, Descripcion,PARENTID,Id,Tipo,Movimiento,Nivel, 0 As SM1A1, 0 AS SM2A1, 0 AS SM2A1, 0 AS SM3A1, 0 AS SM1A2, 0 AS SM2A2, 0 AS SM3A2, 0 As D, 0 as H, 0 as ACUMM1A2, 0 as ACUMM1A1 From CuentaContable " & tipo, dstP.MesAno, Configuracion.Claves.Conexion("Contabilidad"))

        CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")

        If Me.TabControl1.SelectedIndex = 3 Then
            DefinirColumnasMxM()
        Else
            DefinirColumnasMA()
        End If





    End Sub
    Sub DefinirColumnasMxM()

        CreateColumn(TreeList2, Format(Me.pM3A1, "MM/yyyy"), "SM3A1", 2, DevExpress.Utils.FormatType.None, "")

        CreateColumn(TreeList2, Format(Me.pM2A1, "MM/yyyy"), "SM2A1", 3, DevExpress.Utils.FormatType.None, "")

        CreateColumn(TreeList2, Format(Me.pM1A1, "MM/yyyy"), "SM1A1", 4, DevExpress.Utils.FormatType.None, "")

        CreateColumn(TreeList2, "Acum. " & Format(Me.pM1A1, "MM/yyyy"), "ACUMM1A1", 5, DevExpress.Utils.FormatType.None, "")


    End Sub
    Sub DefinirColumnasMA()

        CreateColumn(TreeList2, Format(Me.pM3A2, "MM/yyyy"), "SM3A2", 2, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, Format(Me.pM3A1, "MM/yyyy"), "SM3A1", 3, DevExpress.Utils.FormatType.None, "")

        CreateColumn(TreeList2, Format(Me.pM2A2, "MM/yyyy"), "SM2A2", 4, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, Format(Me.pM2A1, "MM/yyyy"), "SM2A1", 5, DevExpress.Utils.FormatType.None, "")

        CreateColumn(TreeList2, Format(Me.pM1A2, "MM/yyyy"), "SM1A2", 6, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, Format(Me.pM1A1, "MM/yyyy"), "SM1A1", 7, DevExpress.Utils.FormatType.None, "")
        If Me.TabControl1.SelectedIndex >= 3 Then
            CreateColumn(TreeList2, "Acum. " & Format(Me.pM1A2, "MM/yyyy"), "ACUMM1A2", 8, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Acum. " & Format(Me.pM1A1, "MM/yyyy"), "ACUMM1A1", 9, DevExpress.Utils.FormatType.None, "")
        End If


    End Sub
#End Region

#Region "Generar Resultados"
    Sub generarResultadosPeriodos()
        InitDataCompartivoSaldos()
        Dim f1 As Date
        Dim f2 As Date
        Dim f11 As Date
        Dim f22 As Date
        If Me.RadioButtonXAno.Checked Then
            Me.casaFechas("01/01/" & Me.cbAno1.Text, f1, f2, True)
            Me.casaFechas("01/01/" & Me.cbAno2.Text, f11, f22, True)
        Else
            Me.casaFechas(TimeMes1.Value.Date, f1, f2, False)
            Me.casaFechas(TimeMes2.Value.Date, f11, f22, False)
        End If
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        GenerarMovimientosPeriodo(f1, f2, True)
        GenerarMovimientosPeriodo(f11, f22, False)
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        cargarSaldosPeriodoMovimientos(f1, True, True)
        cargarSaldosPeriodoMovimientos(f2, True, False)
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        cargarSaldosPeriodoMovimientos(f11, False, True)
        cargarSaldosPeriodoMovimientos(f22, False, False)
        calcularHaciaArriba()
        Me.TreeList2.Refresh()


    End Sub
    Sub calcularHaciaArriba()
        Try
            '-----------------------------------------------------------------------------------------------------------------------------------------
            Dim y As Integer = NumericUpDown2.Maximum

            While y > 0
                If Me.TabControl1.SelectedIndex = 1 Then
                    calculoRecursivoMA(y - 1)
                ElseIf Me.TabControl1.SelectedIndex = 4 Or Me.TabControl1.SelectedIndex = 3 Then
                    Me.calculoRecursivoAMES(y - 1)
                Else

                    calculoRecursivo(y - 1)
                End If

                y = y - 1
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub calculoRecursivo(ByVal Nivel As Integer)
        Dim k, j As Integer
        For k = 0 To dstP.ResultadosPeriodos.Rows.Count - 1
            If dstP.ResultadosPeriodos.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To dstP.ResultadosPeriodos.Rows.Count - 1
                    If dstP.ResultadosPeriodos.Rows(j).Item("Id") = dstP.ResultadosPeriodos.Rows(k).Item("PARENTID") Then
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        dstP.ResultadosPeriodos.Rows(j).Item("SAP1") = dstP.ResultadosPeriodos.Rows(j).Item("SAP1") + dstP.ResultadosPeriodos.Rows(k).Item("SAP1")
                        dstP.ResultadosPeriodos.Rows(j).Item("DP1") = dstP.ResultadosPeriodos.Rows(j).Item("DP1") + dstP.ResultadosPeriodos.Rows(k).Item("DP1")
                        dstP.ResultadosPeriodos.Rows(j).Item("HP1") = dstP.ResultadosPeriodos.Rows(j).Item("HP1") + dstP.ResultadosPeriodos.Rows(k).Item("HP1")
                        dstP.ResultadosPeriodos.Rows(j).Item("SPP1") = dstP.ResultadosPeriodos.Rows(j).Item("SPP1") + dstP.ResultadosPeriodos.Rows(k).Item("SPP1")
                        dstP.ResultadosPeriodos.Rows(j).Item("SP1") = dstP.ResultadosPeriodos.Rows(j).Item("SP1") + dstP.ResultadosPeriodos.Rows(k).Item("SP1")
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        dstP.ResultadosPeriodos.Rows(j).Item("SAP2") = dstP.ResultadosPeriodos.Rows(j).Item("SAP2") + dstP.ResultadosPeriodos.Rows(k).Item("SAP2")
                        dstP.ResultadosPeriodos.Rows(j).Item("DP2") = dstP.ResultadosPeriodos.Rows(j).Item("DP2") + dstP.ResultadosPeriodos.Rows(k).Item("DP2")
                        dstP.ResultadosPeriodos.Rows(j).Item("HP2") = dstP.ResultadosPeriodos.Rows(j).Item("HP2") + dstP.ResultadosPeriodos.Rows(k).Item("HP2")
                        dstP.ResultadosPeriodos.Rows(j).Item("SPP2") = dstP.ResultadosPeriodos.Rows(j).Item("SPP2") + dstP.ResultadosPeriodos.Rows(k).Item("SPP2")
                        dstP.ResultadosPeriodos.Rows(j).Item("SP2") = dstP.ResultadosPeriodos.Rows(j).Item("SP2") + dstP.ResultadosPeriodos.Rows(k).Item("SP2")
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                    End If
                Next
            End If
        Next
    End Sub
    Sub calculoRecursivoMA(ByVal Nivel As Integer)
        Dim k, j As Integer
        For k = 0 To dstP.MesAno.Rows.Count - 1
            If dstP.MesAno.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To dstP.MesAno.Rows.Count - 1
                    If dstP.MesAno.Rows(j).Item("Id") = dstP.MesAno.Rows(k).Item("PARENTID") Then
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        dstP.MesAno(j).SM1A1 = dstP.MesAno(j).SM1A1 + dstP.MesAno(k).SM1A1
                        dstP.MesAno(j).SM2A1 = dstP.MesAno(j).SM1A1 + dstP.MesAno(k).SM2A1
                        dstP.MesAno(j).SM3A1 = dstP.MesAno(j).SM1A1 + dstP.MesAno(k).SM3A1
                        dstP.MesAno(j).SM1A2 = dstP.MesAno(j).SM1A2 + dstP.MesAno(k).SM1A2
                        dstP.MesAno(j).SM2A2 = dstP.MesAno(j).SM2A2 + dstP.MesAno(k).SM2A2
                        dstP.MesAno(j).SM3A2 = dstP.MesAno(j).SM3A2 + dstP.MesAno(k).SM3A2
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                    End If
                Next
            End If
        Next
    End Sub
    Sub calculoRecursivoAMES(ByVal Nivel As Integer)
        Dim k, j As Integer
        For k = 0 To dstP.MesAno.Rows.Count - 1
            If dstP.MesAno.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To dstP.MesAno.Rows.Count - 1
                    If dstP.MesAno.Rows(j).Item("Id") = dstP.MesAno.Rows(k).Item("PARENTID") Then
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                        dstP.MesAno(j).SM1A1 = dstP.MesAno(j).SM1A1 + dstP.MesAno(k).SM1A1
                        dstP.MesAno(j).SM2A1 = dstP.MesAno(j).SM2A1 + dstP.MesAno(k).SM2A1
                        dstP.MesAno(j).SM3A1 = dstP.MesAno(j).SM3A1 + dstP.MesAno(k).SM3A1
                        dstP.MesAno(j).SM1A2 = dstP.MesAno(j).SM1A2 + dstP.MesAno(k).SM1A2
                        dstP.MesAno(j).SM2A2 = dstP.MesAno(j).SM2A2 + dstP.MesAno(k).SM2A2
                        dstP.MesAno(j).SM3A2 = dstP.MesAno(j).SM3A2 + dstP.MesAno(k).SM3A2
                        dstP.MesAno(j).ACUMM1A1 = dstP.MesAno(j).ACUMM1A1 + dstP.MesAno(k).ACUMM1A1
                        dstP.MesAno(j).ACUMM1A2 = dstP.MesAno(j).ACUMM1A2 + dstP.MesAno(k).ACUMM1A2
                        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                    End If
                Next
            End If
        Next
    End Sub
    Sub casaFechas(ByVal d As Date, ByRef F1 As Date, ByRef F2 As Date, ByVal year As Boolean)
        If Not year Then
            F1 = "01/" & Format(d, "MM/yyyy")
            F2 = F1.AddMonths(1)
            F2 = F2.AddDays(-1)
        Else
            F1 = "01/" & Format(d, "01/yyyy")
            F2 = F1.AddYears(1)
            F2 = F2.AddDays(-1)

        End If

    End Sub
    Sub cargarSaldosPeriodoMovimientos(ByVal fecha As Date, ByVal nPeriodo As String)
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
            Dim wMas As String = ""
            If Check_Cierre.Checked Then
                wMas = " AND (AsientoDC_DH.NumAsiento NOT LIKE 'CAN%')"
            End If
            Dim sel As String = " SELECT dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
            " FROM dbo.AsientoDC_DH INNER JOIN " & _
            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
            " WHERE (dbo.DateOnlyInicio(Fecha) <= dbo.DateOnlyInicio(@Fecha)) " & wMas & " " & _
            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
            ' Si hay que excluir el asiento cierre anual

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = fecha
            'cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            'cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(fecha)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            DtBalanceSituacion1.AsientoDC_DH_AG.Clear()
            dv.Fill(DtBalanceSituacion1.AsientoDC_DH_AG)
            If DtBalanceSituacion1.AsientoDC_DH_AG.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim Periodo As String = nPeriodo


            For x = 0 To dstP.MesAno.Rows.Count - 1
                For i = 0 To DtBalanceSituacion1.AsientoDC_DH_AG.Rows.Count - 1
                    'Si la cuenta es hija se cálcula diferente
                    If dstP.MesAno(x).Movimiento = False Then

                    Else
                        If DtBalanceSituacion1.AsientoDC_DH_AG(i).Cuenta.Equals(dstP.MesAno(x).CuentaContable) Then
                            If Tipo = 1 Then
                                Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Dcolon
                                Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hcolon
                                DebeD += DtBalanceSituacion1.AsientoDC_DH_AG(i).Ddolar
                                HaberD += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hdolar
                            Else
                                If Moneda.SelectedValue = 1 Then
                                    Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Dcolon
                                    Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hcolon
                                Else
                                    Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Ddolar
                                    Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hdolar
                                End If
                            End If
                        End If
                    End If
                Next


                If dstP.MesAno.Rows(x).Item("Tipo") = "ACTIVOS" Or dstP.MesAno.Rows(x).Item("Tipo") = "COSTO VENTA" Or dstP.MesAno.Rows(x).Item("Tipo") = "GASTOS" Then
                    dstP.MesAno.Rows(x).Item(Periodo) = Debe - Haber
                Else
                    dstP.MesAno.Rows(x).Item(Periodo) = Haber - Debe
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
    End Sub
    Sub cargarSaldosPeriodoMovimientos(ByVal fecha As Date, ByVal p1 As Boolean, ByVal antes As Boolean)
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
            Dim wMas As String = ""
            If Check_Cierre.Checked Then
                wMas = " AND (AsientoDC_DH.NumAsiento NOT LIKE 'CAN%')"
            End If
            Dim sel As String = " SELECT dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
            " FROM dbo.AsientoDC_DH INNER JOIN " & _
            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
            " WHERE (dbo.DateOnlyInicio(Fecha) <= dbo.DateOnlyInicio(@Fecha)) " & wMas & " " & _
            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
            ' Si hay que excluir el asiento cierre anual

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = fecha
            'cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            'cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(fecha)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            DtBalanceSituacion1.AsientoDC_DH_AG.Clear()
            dv.Fill(DtBalanceSituacion1.AsientoDC_DH_AG)
            If DtBalanceSituacion1.AsientoDC_DH_AG.Rows.Count = 0 Then
                Exit Sub
            End If
            Dim Periodo As String = "SAP1"
            If Not p1 Then
                If Not antes Then
                    Periodo = "SP1"
                End If
            Else
                If Not antes Then
                    Periodo = "SP2"
                Else
                    Periodo = "SAP2"
                End If
            End If

            For x = 0 To dstP.ResultadosPeriodos.Rows.Count - 1
                For i = 0 To DtBalanceSituacion1.AsientoDC_DH_AG.Rows.Count - 1
                    'Si la cuenta es hija se cálcula diferente
                    If dstP.ResultadosPeriodos(x).Movimiento = False Then

                    Else
                        If DtBalanceSituacion1.AsientoDC_DH_AG(i).Cuenta.Equals(dstP.ResultadosPeriodos(x).CuentaContable) Then
                            If Tipo = 1 Then
                                Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Dcolon
                                Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hcolon
                                DebeD += DtBalanceSituacion1.AsientoDC_DH_AG(i).Ddolar
                                HaberD += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hdolar
                            Else
                                If Moneda.SelectedValue = 1 Then
                                    Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Dcolon
                                    Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hcolon
                                Else
                                    Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Ddolar
                                    Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hdolar
                                End If
                            End If
                        End If
                    End If
                Next


                If dstP.ResultadosPeriodos.Rows(x).Item("Tipo") = "ACTIVOS" Or dstP.ResultadosPeriodos.Rows(x).Item("Tipo") = "COSTO VENTA" Or dstP.ResultadosPeriodos.Rows(x).Item("Tipo") = "GASTOS" Then
                    dstP.ResultadosPeriodos.Rows(x).Item(Periodo) = Debe - Haber
                Else
                    dstP.ResultadosPeriodos.Rows(x).Item(Periodo) = Haber - Debe
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
    End Sub
    Dim dstP As New dtBalanceSituacion
    Private Sub InitDataCompartivoSaldos()
        'Cuando tipo = 1 monta los colones y dólares
        TreeList2.Columns.Clear()

        TreeList2.DataSource = Me.dstP
        TreeList2.DataMember = "ResultadosPeriodos"
        cFunciones.Llenar_Tabla_Generico("Select CuentaContable, Descripcion,PARENTID,Id,Tipo,Movimiento,Nivel, 0 As SAP1, 0 AS DP1, 0 AS HP1, 0 AS SP1, 0 AS SAP2, 0 AS DP2, 0 AS HP2, 0 AS SP2, 0 AS SPP1, 0 AS SPP2 From CuentaContable", dstP.ResultadosPeriodos, Configuracion.Claves.Conexion("Contabilidad"))

        CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
        If Me.RadioButtonXMes.Checked Then
            DefinirColumnasMeses()
        ElseIf Me.RadioButtonXAno.Checked Then
            DefinirColumnasAnos()
        End If


    End Sub
    Sub GenerarMovimientosPeriodo(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal desP As String, ByVal desHaber As String, ByVal desDebe As String)
        Dim cnnV As SqlConnection
        Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
        cnnV = New SqlConnection(sConn)
        cnnV.Open()
        'Creamos el comando para la consulta
        Dim cmdv As SqlCommand = New SqlCommand
        Dim sel As String = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
" SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
" FROM         dbo.AsientoDC_DH INNER JOIN " & _
" dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
" WHERE     (Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)) " & _
" GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

        'Dim sel As String = "SELECT * FROM AsientoDC_DH_AG WHERE Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)"
        If Check_Cierre.Checked Then
            sel = sel & " AND (AsientosContables.NumAsiento <> '" & CierreAnual() & "')"
        End If
        cmdv.CommandText = sel
        cmdv.Connection = cnnV
        cmdv.CommandType = CommandType.Text
        cmdv.CommandTimeout = 90
        'Los parámetros usados en la cadena de la consulta 
        cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
        'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
        cmdv.Parameters("@Fecha").Value = Fecha1
        cmdv.Parameters.Add(New SqlParameter("@Fecha2", SqlDbType.DateTime))
        'cmdv.Parameters("@Fecha2").Value = Format(FechaFinal, "dd/MM/yyyy H:mm:ss")
        cmdv.Parameters("@Fecha2").Value = Fecha2
        'Creamos el dataAdapter y asignamos el comando de selección
        Dim dv As New SqlDataAdapter
        dv.SelectCommand = cmdv
        ' Llenamos la tabla

        Me.DsBalances1.AsientoDC_DH_AG.Clear()

        dv.Fill(Me.DsBalances1.AsientoDC_DH_AG)
        Dim cHaber As String = desHaber
        Dim cDebe As String = desDebe

        Dim sPP As String = desP

        For x As Integer = 0 To Me.dstP.MesAno.Rows.Count - 1

            For i As Integer = 0 To Me.DsBalances1.AsientoDC_DH_AG.Rows.Count - 1
                Dim cuent As String = Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.TrimEnd(" ")
                If cuent.Equals(Me.dstP.MesAno(x).CuentaContable) Then

                    If Moneda.SelectedValue = 1 Then
                        Me.dstP.MesAno.Rows(x).Item(cDebe) += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                        Me.dstP.MesAno.Rows(x).Item(cHaber) += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon
                    Else
                        Me.dstP.MesAno.Rows(x).Item(cDebe) += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                        Me.dstP.MesAno.Rows(x).Item(cHaber) += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar

                    End If
                End If


            Next
            If Me.dstP.MesAno(x).Item("Tipo") = "ACTIVOS" Or Me.dstP.MesAno(x).Item("Tipo") = "COSTO VENTA" Or Me.dstP.MesAno(x).Item("Tipo") = "GASTOS" Or Me.dstP.MesAno(x).Item("Tipo") = "OTROS GASTOS" Then
                Me.dstP.MesAno(x).Item(sPP) = Me.dstP.MesAno(x).Item(cDebe) - Me.dstP.MesAno(x).Item(cHaber)
            Else
                Me.dstP.MesAno(x).Item(sPP) = Me.dstP.MesAno(x).Item(cHaber) - Me.dstP.MesAno(x).Item(cDebe)
            End If
            Me.dstP.MesAno(x).Item(cDebe) = 0
            Me.dstP.MesAno(x).Item(cHaber) = 0


        Next



    End Sub
    Sub GenerarMovimientosPeriodo(ByVal Fecha1 As Date, ByVal Fecha2 As Date, ByVal p1 As Boolean)
        Dim cnnV As SqlConnection
        Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
        cnnV = New SqlConnection(sConn)
        cnnV.Open()
        'Creamos el comando para la consulta
        Dim cmdv As SqlCommand = New SqlCommand
        Dim sel As String = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
" SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
" FROM         dbo.AsientoDC_DH INNER JOIN " & _
" dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
" WHERE     (Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)) " & _
" GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

        'Dim sel As String = "SELECT * FROM AsientoDC_DH_AG WHERE Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)"
        If Check_Cierre.Checked Then
            sel = sel & " AND (AsientosContables.NumAsiento <> '" & CierreAnual() & "')"
        End If
        cmdv.CommandText = sel
        cmdv.Connection = cnnV
        cmdv.CommandType = CommandType.Text
        cmdv.CommandTimeout = 90
        'Los parámetros usados en la cadena de la consulta 
        cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
        'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
        cmdv.Parameters("@Fecha").Value = Fecha1
        cmdv.Parameters.Add(New SqlParameter("@Fecha2", SqlDbType.DateTime))
        'cmdv.Parameters("@Fecha2").Value = Format(FechaFinal, "dd/MM/yyyy H:mm:ss")
        cmdv.Parameters("@Fecha2").Value = Fecha2
        'Creamos el dataAdapter y asignamos el comando de selección
        Dim dv As New SqlDataAdapter
        dv.SelectCommand = cmdv
        ' Llenamos la tabla

        Me.DsBalances1.AsientoDC_DH_AG.Clear()

        dv.Fill(Me.DsBalances1.AsientoDC_DH_AG)
        Dim cHaber As String = "HP1"
        Dim cDebe As String = "DP1"

        Dim sPP As String = "SPP1"
        If Not p1 Then
            cHaber = "HP2"
            cDebe = "DP2"
            sPP = "SPP2"
        End If
        For x As Integer = 0 To Me.dstP.ResultadosPeriodos.Rows.Count - 1

            For i As Integer = 0 To Me.DsBalances1.AsientoDC_DH_AG.Rows.Count - 1
                Dim cuent As String = Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.TrimEnd(" ")
                If cuent.Equals(Me.dstP.ResultadosPeriodos(x).CuentaContable) Then

                    If Moneda.SelectedValue = 1 Then
                        dstP.ResultadosPeriodos.Rows(x).Item(cDebe) += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                        dstP.ResultadosPeriodos.Rows(x).Item(cHaber) += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon
                    Else
                        dstP.ResultadosPeriodos.Rows(x).Item(cDebe) += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                        dstP.ResultadosPeriodos.Rows(x).Item(cHaber) += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar

                    End If
                End If


            Next
            If dstP.ResultadosPeriodos(x).Item("Tipo") = "ACTIVOS" Or dstP.ResultadosPeriodos(x).Item("Tipo") = "COSTO VENTA" Or dstP.ResultadosPeriodos(x).Item("Tipo") = "GASTOS" Or dstP.ResultadosPeriodos(x).Item("Tipo") = "OTROS GASTOS" Then
                dstP.ResultadosPeriodos(x).Item(sPP) = dstP.ResultadosPeriodos(x).Item(cDebe) - dstP.ResultadosPeriodos(x).Item(cHaber)
            Else
                dstP.ResultadosPeriodos(x).Item(sPP) = dstP.ResultadosPeriodos(x).Item(cHaber) - dstP.ResultadosPeriodos(x).Item(cDebe)
            End If



        Next



    End Sub

    Dim DsBalances1 As New DsBalances

    Sub DefinirColumnasMeses()

        CreateColumn(TreeList2, "Saldo Anterior Mes " & Format(Me.TimeMes1.Value, "MM/yyyy"), "SAP1", 2, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Debitos Mes " & Format(Me.TimeMes1.Value, "MM/yyyy"), "DP1", 3, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Creditos Mes " & Format(Me.TimeMes1.Value, "MM/yyyy"), "HP1", 4, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Mes " & Format(Me.TimeMes1.Value, "MM/yyyy"), "SPP1", 5, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Final " & Format(Me.TimeMes1.Value, "MM/yyyy"), "SP1", 6, DevExpress.Utils.FormatType.None, "")

        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        CreateColumn(TreeList2, "Saldo Anterior Mes " & Format(Me.TimeMes2.Value, "MM/yyyy"), "SAP2", 7, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Debitos Mes " & Format(Me.TimeMes2.Value, "MM/yyyy"), "DP2", 8, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Creditos Mes " & Format(Me.TimeMes2.Value, "MM/yyyy"), "HP2", 9, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Mes " & Format(Me.TimeMes1.Value, "MM/yyyy"), "SPP2", 10, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Final " & Format(Me.TimeMes2.Value, "MM/yyyy"), "SP2", 11, DevExpress.Utils.FormatType.None, "")


    End Sub
    Sub DefinirColumnasAnos()
        CreateColumn(TreeList2, "Saldo Anterior Año " & Me.cbAno1.Text, "SAP1", 2, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Debitos Año " & Me.cbAno1.Text, "DP1", 3, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Creditos Año " & Me.cbAno1.Text, "HP1", 4, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Año " & Me.cbAno1.Text, "SPP1", 5, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Final " & Me.cbAno1.Text, "SP1", 6, DevExpress.Utils.FormatType.None, "")
        '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        CreateColumn(TreeList2, "Saldo Anterior Año " & Me.cbAno2.Text, "SAP2", 7, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Debitos Año " & Me.cbAno2.Text, "DP2", 8, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Creditos Año " & Me.cbAno2.Text, "HP2", 9, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Año " & Me.cbAno2.Text, "SPP2", 10, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "S. Final " & Me.cbAno2.Text, "SP2", 11, DevExpress.Utils.FormatType.None, "")


    End Sub
#End Region

#Region "Generar Balance"
    Private Sub LLenarCeros()
        Dim n As Integer
        For n = 0 To DtBalanceSituacion1.CuentaContable.Rows.Count - 1
            If Tipo = 1 Then
                DtBalanceSituacion1.CuentaContable.Rows(n).Item("Saldo") = 0
                DtBalanceSituacion1.CuentaContable.Rows(n).Item("SaldoD") = 0
                DtBalanceSituacion1.CuentaContable.Rows(n).Item("SaldoP2") = 0
                DtBalanceSituacion1.CuentaContable.Rows(n).Item("SaldoDP2") = 0
            Else
                DtBalanceSituacion1.CuentaContable.Rows(n).Item("Saldo") = 0
                DtBalanceSituacion1.CuentaContable.Rows(n).Item("SaldoP2") = 0
            End If
        Next
    End Sub

    Function CierreAnual() As String
        Try
            Dim cConexion As New Conexion       'BUSCA NUMERO DE ASIENTO DEL ULTIMO CIERRE ANUAL
            CierreAnual = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT NumAsiento FROM dbo.AsientosContables WHERE TipoDoc = 30 AND Anulado = 0 AND Mayorizado = 1 AND Fecha <= dbo.DateOnlyFinal('" & Format(dtFinal.Value, "dd/MM/yyyy H:mm:ss") & "') ORDER BY Fecha DESC")
            cConexion.DesConectar(cConexion.sQlconexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        End Try
    End Function

    Function CargarAsientos(ByVal FechaInicio As String, ByVal Periodo As String, ByVal PeriodoD As String)
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
            Dim wMas As String = ""
            If Check_Cierre.Checked Then
                wMas = " AND (AsientoDC_DH.NumAsiento NOT LIKE 'CAN%')"
            End If
            Dim sel As String = " SELECT dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
            " FROM dbo.AsientoDC_DH INNER JOIN " & _
            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
            " WHERE (dbo.DateOnlyInicio(Fecha) <= dbo.DateOnlyInicio(@Fecha)) " & wMas & " " & _
            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
            ' Si hay que excluir el asiento cierre anual

            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(dtFinal.Value)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            DtBalanceSituacion1.AsientoDC_DH_AG.Clear()
            dv.Fill(DtBalanceSituacion1.AsientoDC_DH_AG)
            If DtBalanceSituacion1.AsientoDC_DH_AG.Rows.Count = 0 Then
                Exit Function
            End If

            For x = 0 To DtBalanceSituacion1.CuentaContable.Rows.Count - 1
                For i = 0 To DtBalanceSituacion1.AsientoDC_DH_AG.Rows.Count - 1
                    'Si la cuenta es hija se cálcula diferente
                    If DtBalanceSituacion1.CuentaContable(x).Movimiento = False Then

                    Else
                        If DtBalanceSituacion1.AsientoDC_DH_AG(i).Cuenta.Equals(DtBalanceSituacion1.CuentaContable(x).CuentaContable) Then
                            If Tipo = 1 Then
                                Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Dcolon
                                Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hcolon
                                DebeD += DtBalanceSituacion1.AsientoDC_DH_AG(i).Ddolar
                                HaberD += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hdolar
                            Else
                                If Moneda.SelectedValue = 1 Then
                                    Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Dcolon
                                    Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hcolon
                                Else
                                    Debe += DtBalanceSituacion1.AsientoDC_DH_AG(i).Ddolar
                                    Haber += DtBalanceSituacion1.AsientoDC_DH_AG(i).Hdolar
                                End If
                            End If
                        End If
                    End If
                Next

                If Tipo = 1 Then
                    If DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Or DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "Otros Gastos" Then
                        DtBalanceSituacion1.CuentaContable.Rows(x).Item(Periodo) = Debe - Haber
                        DtBalanceSituacion1.CuentaContable.Rows(x).Item(PeriodoD) = DebeD - HaberD
                    Else
                        DtBalanceSituacion1.CuentaContable.Rows(x).Item(Periodo) = Haber - Debe
                        DtBalanceSituacion1.CuentaContable.Rows(x).Item(PeriodoD) = HaberD - DebeD
                    End If
                Else
                    If DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DtBalanceSituacion1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        DtBalanceSituacion1.CuentaContable.Rows(x).Item(Periodo) = Debe - Haber
                    Else
                        DtBalanceSituacion1.CuentaContable.Rows(x).Item(Periodo) = Haber - Debe
                    End If

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
    Sub accionGeneracion()
        smbGenerar.Enabled = False
        smbGenerar.Text = "Espere..."
        Dim str As String = Me.Text
        Text = "ESPERE POR FAVOR....."
        Refresh()

        If TabControl1.SelectedIndex = 0 Then
            If Not Me.EstadoResultado Then
                GENERARBALANCE()
            Else
                GenerarEstadoResultado()
            End If
        ElseIf Me.TabControl1.SelectedIndex = 2 Then
            If Not Me.EstadoResultado Then
                Me.generarResultadosPeriodos()
            Else
                Me.generarResultadosPeriodos()
            End If
        ElseIf Me.TabControl1.SelectedIndex = 1 Then
            If Not Me.EstadoResultado Then
                Me.generarMA()
            Else
                Me.generarMA()
            End If
        ElseIf Me.TabControl1.SelectedIndex = 4 Then
            Me.generarAMES()
        ElseIf Me.TabControl1.SelectedIndex = 3 Then
            Me.generarMesxMes()
        End If
        Me.smbGenerar.Enabled = True
        Me.smbGenerar.Text = "GENERAR"
        Me.Text = str
        Me.Refresh()
    End Sub
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        accionGeneracion()
    End Sub
    Sub GENERARBALANCE()
        Try
            Dim cf As New cFunciones
            Dim Fecha2 As Date
            InitData()
            Fecha2 = Format(dtFinal.Value.Date, "dd/MM/yyyy H:mm:ss")
            DtBalanceSituacion1.TempSituacion.Clear()
            DtBalanceSituacion1.CuentaContable.Clear()
            cf.Llenar_Tabla_Generico("SELECT *, 0 As Saldo, 0 As SaldoD, 0 As SaldoP2, 0 As SaldoDP2, 0 As SaldoP3, 0 As SaldoDP3, 0 As SaldoP4, 0 As SaldoDP4, 0 As SaldoP5, 0 As SaldoDP5, 0 As SaldoP6, 0 As SaldoDP6 FROM CuentaContable WHERE (Tipo = 'ACTIVOS'OR Tipo = 'PASIVOS' OR Tipo = 'CAPITAL' OR Tipo = 'INGRESOS' OR Tipo = 'COSTO VENTA' OR  Tipo = 'GASTOS' ) AND (Nivel <= " & NumericUpDown2.Maximum & ")", DtBalanceSituacion1.CuentaContable, Configuracion.Claves.Conexion("Contabilidad"))
            TreeList2.Columns(1).Width = 320
            LLenarCeros()
            Dim i As Int16 = NumericUpDown1.Value
            If RadioButtonMeses.Checked Then
                CargarAsientos(Fecha2, "Saldo", "SaldoD")
                If i >= 1 Then
                    CargarAsientos(Fecha2.AddMonths(-1), "SaldoP2", "SaldoDP2")
                End If
                If i >= 2 Then
                    CargarAsientos(Fecha2.AddMonths(-2), "SaldoP3", "SaldoDP3")
                End If
                If i >= 3 Then
                    CargarAsientos(Fecha2.AddMonths(-3), "SaldoP4", "SaldoDP4")
                End If
                If i >= 4 Then
                    CargarAsientos(Fecha2.AddMonths(-4), "SaldoP5", "SaldoDP5")
                End If
                If i >= 5 Then
                    CargarAsientos(Fecha2.AddMonths(-5), "SaldoP6", "SaldoDP6")
                End If
                If i >= 6 Then

                End If
            Else
                CargarAsientos(Fecha2, "Saldo", "SaldoD")
                If i >= 1 Then
                    CargarAsientos(Fecha2.AddYears(-1), "SaldoP2", "SaldoDP2")
                End If
                If i >= 2 Then
                    CargarAsientos(Fecha2.AddYears(-2), "SaldoP3", "SaldoDP3")
                End If
                If i >= 3 Then

                End If

            End If

            Calcular()
            'subtotalesEstadoResultado(DtBalanceSituacion1)
            dst = DtBalanceSituacion1.Copy


            For h As Integer = 0 To dst.CuentaContable.Count - 1

                If h >= BindingContext(dst, "CuentaContable").Count Then Exit For

                BindingContext(dst, "CuentaContable").Position = h
                If NumericUpDown2.Value <> NumericUpDown2.Maximum Then

                    If BindingContext(dst, "CuentaContable").Current("Nivel") > NumericUpDown2.Value Then

                        BindingContext(dst, "CuentaContable").RemoveAt(h)
                        BindingContext(dst, "CuentaContable").EndCurrentEdit()
                        h -= 1

                    End If


                End If

                If BindingContext(dst, "CuentaContable").Current("Tipo").Equals("INGRESOS") Or BindingContext(dst, "CuentaContable").Current("Tipo").Equals("GASTOS") Or BindingContext(dst, "CuentaContable").Current("Tipo").Equals("COSTO VENTA") Then
                    BindingContext(dst, "CuentaContable").RemoveAt(h)
                    BindingContext(dst, "CuentaContable").EndCurrentEdit()

                    h -= 1
                End If
            Next

            TreeList2.DataSource = dst


            TreeList2.DataMember = "CuentaContable"
            TreeList2.Show()
            dtFinal.Enabled = False
            Check_Cierre.Enabled = False
            smbGenerar.Enabled = False
            TreeList2.FullExpand()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub GenerarEstadoResultado()
        Try
            Dim cf As New cFunciones
            Dim Fecha2 As Date
            InitData()
            Fecha2 = Format(dtFinal.Value.Date, "dd/MM/yyyy")
            DtBalanceSituacion1.TempSituacion.Clear()
            DtBalanceSituacion1.CuentaContable.Clear()
            cf.Llenar_Tabla_Generico("SELECT *, 0 As Saldo, 0 As SaldoD, 0 As SaldoP2, 0 As SaldoDP2, 0 As SaldoP3, 0 As SaldoDP3, 0 As SaldoP4, 0 As SaldoDP4, 0 As SaldoP5, 0 As SaldoDP5, 0 As SaldoP6, 0 As SaldoDP6 FROM CuentaContable WHERE (Tipo = 'Ingresos'OR Tipo = 'COSTO VENTA' OR Tipo = 'Gastos' OR Tipo = 'Otros Gastos' OR Tipo = 'Otros Ingresos') AND (Nivel <= " & NumericUpDown2.Maximum & ")", DtBalanceSituacion1.CuentaContable, Configuracion.Claves.Conexion("Contabilidad"))
            TreeList2.Columns(1).Width = 320
            LLenarCeros()
            Dim i As Int16 = NumericUpDown1.Value
            If RadioButtonMeses.Checked Then
                CargarAsientos(Fecha2, "Saldo", "SaldoD")
                If i >= 1 Then
                    CargarAsientos(Fecha2.AddMonths(-1), "SaldoP2", "SaldoDP2")
                End If
                If i >= 2 Then
                    CargarAsientos(Fecha2.AddMonths(-2), "SaldoP3", "SaldoDP3")
                End If
                If i >= 3 Then
                    CargarAsientos(Fecha2.AddMonths(-3), "SaldoP4", "SaldoDP4")
                End If
                If i >= 4 Then
                    CargarAsientos(Fecha2.AddMonths(-4), "SaldoP5", "SaldoDP5")
                End If
                If i >= 5 Then
                    CargarAsientos(Fecha2.AddMonths(-5), "SaldoP6", "SaldoDP6")
                End If
                If i >= 6 Then

                End If
            Else
                CargarAsientos(Fecha2, "Saldo", "SaldoD")
                If i >= 1 Then
                    CargarAsientos(Fecha2.AddYears(-1), "SaldoP2", "SaldoDP2")
                End If
                If i >= 2 Then
                    CargarAsientos(Fecha2.AddYears(-2), "SaldoP3", "SaldoDP3")
                End If
                If i >= 3 Then

                End If

            End If


            'CargarDebitos(Fecha1, Fecha2)
            'Calcular_Saldos()
            Calcular()

            dst = DtBalanceSituacion1.Copy
            If NumericUpDown2.Value <> NumericUpDown2.Maximum Then
                For h As Integer = 0 To dst.CuentaContable.Count - 1

                    If h >= BindingContext(dst, "CuentaContable").Count Then Exit For

                    BindingContext(dst, "CuentaContable").Position = h
                    If BindingContext(dst, "CuentaContable").Current("Nivel") > NumericUpDown2.Value Then
                        BindingContext(dst, "CuentaContable").RemoveAt(h)
                        BindingContext(dst, "CuentaContable").EndCurrentEdit()
                        h -= 1
                    End If
                Next
            End If
            TreeList2.DataSource = dst


            TreeList2.DataMember = "CuentaContable"
            TreeList2.Show()
            dtFinal.Enabled = False
            Check_Cierre.Enabled = False
            smbGenerar.Enabled = False
            TreeList2.FullExpand()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "ToolBar"

    Private Sub Nuevo()
        Try
            If ToolBarNuevo.Text = "Nuevo" Then
                ToolBarNuevo.ImageIndex = "3"
                ToolBarNuevo.Text = "Cancelar"
                TreeList2.DataSource = ""
                TreeList2.DataMember = ""
                Estado(True)
                dtFinal.Focus()
            Else
                ToolBarNuevo.ImageIndex = "0"
                ToolBarNuevo.Text = "Nuevo"
                TreeList2.DataSource = ""
                TreeList2.DataMember = ""
                Estado(False)
            End If

            dtFinal.Enabled = True
            Moneda.Enabled = True
            Me.DtBalanceSituacion1 = New dtBalanceSituacion
            Me.dst = New dtBalanceSituacion
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function EstaEnCero(ByVal row As dtBalanceSituacion.CuentaContableRow) As Boolean
        Try


            If row.Saldo = 0 And row.SaldoP2 = 0 And row.SaldoP3 = 0 And row.SaldoP4 = 0 And row.SaldoP5 = 0 And row.SaldoP6 = 0 And row.SaldoP5 = 0 And row.SaldoD = 0 And row.SaldoDP2 = 0 And row.SaldoDP3 = 0 And row.SaldoDP4 = 0 And row.SaldoDP5 = 0 And row.SaldoDP6 = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly)

        End Try
    End Function
    Function conc(ByVal num As Integer) As String
        Dim n As String = num
        If n.Length = 1 Then
            Return "00" & n
        ElseIf n.Length = 2 Then
            Return "0" & n
        Else
            Return n
        End If
    End Function
    Sub subtotalesEstadoResultado(ByVal d As dtBalanceSituacion)
        Dim s1 As Double = 0
        Dim s2 As Double = 0
        Dim s3 As Double = 0
        Dim s4 As Double = 0
        Dim s5 As Double = 0
        Dim s6 As Double = 0
        Dim s1D As Double = 0
        Dim s2D As Double = 0
        Dim s3D As Double = 0
        Dim s4D As Double = 0
        Dim s5D As Double = 0
        Dim s6D As Double = 0
        'COSTO DE VENTAS
        Dim s1CV As Double = 0
        Dim s2CV As Double = 0
        Dim s3CV As Double = 0
        Dim s4CV As Double = 0
        Dim s5CV As Double = 0
        Dim s6CV As Double = 0
        Dim s1DCV As Double = 0
        Dim s2DCV As Double = 0
        Dim s3DCV As Double = 0
        Dim s4DCV As Double = 0
        Dim s5DCV As Double = 0
        Dim s6DCV As Double = 0
        'GASTOS
        Dim s1GA As Double = 0
        Dim s2GA As Double = 0
        Dim s3GA As Double = 0
        Dim s4GA As Double = 0
        Dim s5GA As Double = 0
        Dim s6GA As Double = 0
        Dim s1DGA As Double = 0
        Dim s2DGA As Double = 0
        Dim s3DGA As Double = 0
        Dim s4DGA As Double = 0
        Dim s5DGA As Double = 0
        Dim s6DGA As Double = 0

        Dim numero As Integer = 1
        For i As Integer = 0 To d.TemporalBalance.Count - 1
            'INGRESOS
            If d.TemporalBalance(i).Tipo.Equals("INGRESOS") And d.TemporalBalance(i).Nivel = 0 Then
                Me.cargaTemporalDato("4x" & conc(numero) & "Ingresos", "Total Ingresos:", 0, "INGRESOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1

            ElseIf d.TemporalBalance(i).Tipo.Equals("INGRESOS") And d.TemporalBalance(i).Nivel = 1 Then
                Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "4x" & conc(numero) & "INGRESOS", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "INGRESOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1

            End If

            'COSTO DE VENTAS
            If d.TemporalBalance(i).Tipo.Equals("COSTO VENTA") And d.TemporalBalance(i).Nivel = 0 Then
                cargaTemporalDato("5x" & conc(numero) & "CostoV", "Total COSTO VENTA:", 0, "COSTO VENTA", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1

            ElseIf d.TemporalBalance(i).Tipo.Equals("COSTO VENTA") And d.TemporalBalance(i).Nivel = 1 Then
                cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "5x" & conc(numero) & "CostoV", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "COSTO VENTA", -1, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1

            End If

            'GASTOS
            If d.TemporalBalance(i).Tipo.Equals("GASTOS") And d.TemporalBalance(i).Nivel = 0 Then
                Me.cargaTemporalDato("6x" & conc(numero) & "GASTOS", "Total GASTOS:", 0, "GASTOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1

            ElseIf d.TemporalBalance(i).Tipo.Equals("GASTOS") And d.TemporalBalance(i).Nivel = 1 Then
                Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "6x" & conc(numero) & "GASTOS", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "GASTOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1

            End If

        Next
        For h As Integer = 0 To d.TemporalBalance.Count - 1
            If d.TemporalBalance(h).Tipo.Equals("INGRESOS") And d.TemporalBalance(h).Nivel = 0 Then
                s1 = d.TemporalBalance(h).SaldoP
                s2 = d.TemporalBalance(h).SaldoP2
                s3 = d.TemporalBalance(h).SaldoP3
                s4 = d.TemporalBalance(h).SaldoP4
                s5 = d.TemporalBalance(h).SaldoP5
                s1D = d.TemporalBalance(h).SaldoPD
                s2D = d.TemporalBalance(h).SaldoPD2
                s3D = d.TemporalBalance(h).SaldoPD3
                s4D = d.TemporalBalance(h).SaldoPD4
                s5D = d.TemporalBalance(h).SaldoPD5
            End If
            If d.TemporalBalance(h).Tipo.Equals("COSTO VENTA") And d.TemporalBalance(h).Nivel = 0 Then
                s1CV = d.TemporalBalance(h).SaldoP
                s2CV = d.TemporalBalance(h).SaldoP2
                s3CV = d.TemporalBalance(h).SaldoP3
                s4CV = d.TemporalBalance(h).SaldoP4
                s5CV = d.TemporalBalance(h).SaldoP5
                s1DCV = d.TemporalBalance(h).SaldoPD
                s2DCV = d.TemporalBalance(h).SaldoPD2
                s3DCV = d.TemporalBalance(h).SaldoPD3
                s4DCV = d.TemporalBalance(h).SaldoPD4
                s5DCV = d.TemporalBalance(h).SaldoPD5

            End If
            If d.TemporalBalance(h).Tipo.Equals("GASTOS") And d.TemporalBalance(h).Nivel = 0 Then
                s1GA = d.TemporalBalance(h).SaldoP
                s2GA = d.TemporalBalance(h).SaldoP2
                s3GA = d.TemporalBalance(h).SaldoP3
                s4GA = d.TemporalBalance(h).SaldoP4
                s5GA = d.TemporalBalance(h).SaldoP5
                s1DGA = d.TemporalBalance(h).SaldoPD
                s2DGA = d.TemporalBalance(h).SaldoPD2
                s3DGA = d.TemporalBalance(h).SaldoPD3
                s4DGA = d.TemporalBalance(h).SaldoPD4
                s5DGA = d.TemporalBalance(h).SaldoPD5

            End If

        Next
        numero = numero + 1
        cargaTemporalDato("5x" & conc(numero) & "CostoV", "Utilidad Bruta:", 0, "COSTO VENTA", -1 * numero, 0, s1 - s1CV, s1D - s1DCV, s2 - s2CV, s2D - s2DCV, s3 - s3CV, s3D - s3CV, s4 - s4CV, s4D - s4CV, s5 - s5CV, s5D - s5DCV, d)
        numero = numero + 1
        cargaTemporalDato("6x" & conc(numero) & "Gastos", "Utilidad antes impuestos:", 0, "GASTOS", -1 * numero, 0, s1 - s1CV - s1GA, s1D - s1DCV - s1DGA, s2 - s2CV - s2GA, s2D - s2DCV - s2DGA, s3 - s3CV - s3GA, s3D - s3CV - s3GA, s4 - s4CV - s4GA, s4D - s4CV - s4GA, s5 - s5CV - s5GA, s5D - s5DCV - s5GA, d)
        numero = numero + 1
        cargaTemporalDato("6x" & conc(numero) & "Gastos", "Impuesto de Renta:", 0, "GASTOS", -1 * numero, 0, (s1 - s1CV - s1GA) * 0.3, (s1D - s1DCV - s1DGA) * 0.14, (s2 - s2CV - s2GA) * 0.3, (s2D - s2DCV - s2DGA) * 0.3, (s3 - s3CV - s3GA) * 0.3, (s3D - s3CV - s3GA) * 0.3, (s4 - s4CV - s4GA) * 0.3, (s4D - s4CV - s4GA) * 0.3, (s5 - s5CV - s5GA) * 0.3, (s5D - s5DCV - s5GA) * 0.3, d)
        numero = numero + 1
        cargaTemporalDato("6x" & conc(numero) & "Gastos", "Ganancia o perdida del perriodo:", 0, "GASTOS", -1 * numero, 0, (s1 - s1CV - s1GA) - ((s1 - s1CV - s1GA) * 0.3), (s1D - s1DCV - s1DGA) - ((s1D - s1DCV - s1DGA) * 0.3), (s2 - s2CV - s2GA) - ((s2 - s2CV - s2GA) * 0.3), (s2D - s2DCV - s2DGA) - ((s2D - s2DCV - s2DGA) * 0.3), (s3 - s3CV - s3GA) - ((s3 - s3CV - s3GA) * 0.3), (s3D - s3CV - s3GA) - ((s3D - s3CV - s3GA) * 0.3), (s4 - s4CV - s4GA) - ((s4 - s4CV - s4GA) * 0.3), (s4D - s4CV - s4GA) - ((s4D - s4CV - s4GA) * 0.3), (s5 - s5CV - s5GA) - ((s5 - s5CV - s5GA) * 0.3), (s5D - s5DCV - s5GA) - ((s5D - s5DCV - s5GA) * 0.3), d)
        numero = numero + 1
    End Sub
    Sub subtotalesEstadoResultadoENBalance(ByVal d As dtBalanceSituacion, ByVal d1 As dtBalanceSituacion, ByVal numero As Integer)
        Dim s1 As Double = 0
        Dim s2 As Double = 0
        Dim s3 As Double = 0
        Dim s4 As Double = 0
        Dim s5 As Double = 0
        Dim s6 As Double = 0
        Dim s1D As Double = 0
        Dim s2D As Double = 0
        Dim s3D As Double = 0
        Dim s4D As Double = 0
        Dim s5D As Double = 0
        Dim s6D As Double = 0
        'COSTO DE VENTAS
        Dim s1CV As Double = 0
        Dim s2CV As Double = 0
        Dim s3CV As Double = 0
        Dim s4CV As Double = 0
        Dim s5CV As Double = 0
        Dim s6CV As Double = 0
        Dim s1DCV As Double = 0
        Dim s2DCV As Double = 0
        Dim s3DCV As Double = 0
        Dim s4DCV As Double = 0
        Dim s5DCV As Double = 0
        Dim s6DCV As Double = 0
        'GASTOS
        Dim s1GA As Double = 0
        Dim s2GA As Double = 0
        Dim s3GA As Double = 0
        Dim s4GA As Double = 0
        Dim s5GA As Double = 0
        Dim s6GA As Double = 0
        Dim s1DGA As Double = 0
        Dim s2DGA As Double = 0
        Dim s3DGA As Double = 0
        Dim s4DGA As Double = 0
        Dim s5DGA As Double = 0
        Dim s6DGA As Double = 0

        ' Dim numero As Integer = 1
        'For i As Integer = 0 To d.TemporalBalance.Count - 1
        '    'INGRESOS
        '    If d.TemporalBalance(i).Tipo.Equals("INGRESOS") And d.TemporalBalance(i).Nivel = 0 Then
        '        Me.cargaTemporalDato("4x" & conc(numero) & "Ingresos", "Total Ingresos:", 0, "INGRESOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
        '        numero = numero + 1

        '    ElseIf d.TemporalBalance(i).Tipo.Equals("INGRESOS") And d.TemporalBalance(i).Nivel = 1 Then
        '        Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "4x" & conc(numero) & "INGRESOS", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "INGRESOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
        '        numero = numero + 1

        '    End If

        '    'COSTO DE VENTAS
        '    If d.TemporalBalance(i).Tipo.Equals("COSTO VENTA") And d.TemporalBalance(i).Nivel = 0 Then
        '        cargaTemporalDato("5x" & conc(numero) & "CostoV", "Total COSTO VENTA:", 0, "COSTO VENTA", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
        '        numero = numero + 1

        '    ElseIf d.TemporalBalance(i).Tipo.Equals("COSTO VENTA") And d.TemporalBalance(i).Nivel = 1 Then
        '        cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "5x" & conc(numero) & "CostoV", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "COSTO VENTA", -1, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
        '        numero = numero + 1

        '    End If

        '    'GASTOS
        '    If d.TemporalBalance(i).Tipo.Equals("GASTOS") And d.TemporalBalance(i).Nivel = 0 Then
        '        Me.cargaTemporalDato("6x" & conc(numero) & "GASTOS", "Total GASTOS:", 0, "GASTOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
        '        numero = numero + 1

        '    ElseIf d.TemporalBalance(i).Tipo.Equals("GASTOS") And d.TemporalBalance(i).Nivel = 1 Then
        '        Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "6x" & conc(numero) & "GASTOS", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "GASTOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
        '        numero = numero + 1

        '    End If

        'Next
        For h As Integer = 0 To d.CuentaContable.Count - 1
            If d.CuentaContable(h).Tipo.Equals("INGRESOS") And d.CuentaContable(h).Nivel = 0 Then
                s1 = d.CuentaContable(h).Saldo
                s2 = d.CuentaContable(h).SaldoP2
                s3 = d.CuentaContable(h).SaldoP3
                s4 = d.CuentaContable(h).SaldoP4
                s5 = d.CuentaContable(h).SaldoP5
                s1D = d.CuentaContable(h).SaldoD
                s2D = d.CuentaContable(h).SaldoDP2
                s3D = d.CuentaContable(h).SaldoDP3
                s4D = d.CuentaContable(h).SaldoDP4
                s5D = d.CuentaContable(h).SaldoDP5

            End If
            If d.CuentaContable(h).Tipo.Equals("COSTO VENTA") And d.CuentaContable(h).Nivel = 0 Then
                s1CV = d.CuentaContable(h).Saldo
                s2CV = d.CuentaContable(h).SaldoP2
                s3CV = d.CuentaContable(h).SaldoP3
                s4CV = d.CuentaContable(h).SaldoP4
                s5CV = d.CuentaContable(h).SaldoP5
                s1DCV = d.CuentaContable(h).SaldoD
                s2DCV = d.CuentaContable(h).SaldoDP2
                s3DCV = d.CuentaContable(h).SaldoDP3
                s4DCV = d.CuentaContable(h).SaldoDP4
                s5DCV = d.CuentaContable(h).SaldoDP5

            End If
            If d.CuentaContable(h).Tipo.Equals("GASTOS") And d.CuentaContable(h).Nivel = 0 Then
                s1GA = d.CuentaContable(h).Saldo
                s2GA = d.CuentaContable(h).SaldoP2
                s3GA = d.CuentaContable(h).SaldoP3
                s4GA = d.CuentaContable(h).SaldoP4
                s5GA = d.CuentaContable(h).SaldoP5
                s1DGA = d.CuentaContable(h).SaldoD
                s2DGA = d.CuentaContable(h).SaldoDP2
                s3DGA = d.CuentaContable(h).SaldoDP3
                s4DGA = d.CuentaContable(h).SaldoDP4
                s5DGA = d.CuentaContable(h).SaldoDP5

            End If

        Next
        'numero = numero + 1
        'cargaTemporalDato("5x" & conc(numero) & "CostoV", "Utilidad Bruta:", 0, "COSTO VENTA", -1 * numero, 0, s1 - s1CV, s1D - s1DCV, s2 - s2CV, s2D - s2DCV, s3 - s3CV, s3D - s3CV, s4 - s4CV, s4D - s4CV, s5 - s5CV, s5D - s5DCV, d)
        'numero = numero + 1
        cargaTemporalDato("3x" & conc(numero) & "CAPITAL", "Utilidad:", 0, "CAPITAL", -1 * numero, 0, s1 - s1CV - s1GA, s1D - s1DCV - s1DGA, s2 - s2CV - s2GA, s2D - s2DCV - s2DGA, s3 - s3CV - s3GA, s3D - s3CV - s3GA, s4 - s4CV - s4GA, s4D - s4CV - s4GA, s5 - s5CV - s5GA, s5D - s5DCV - s5GA, d1)
        numero = numero + 1
        'cargaTemporalDato("6x" & conc(numero) & "Gastos", "Impuesto de Renta:", 0, "GASTOS", -1 * numero, 0, (s1 - s1CV - s1GA) * 0.3, (s1D - s1DCV - s1DGA) * 0.14, (s2 - s2CV - s2GA) * 0.3, (s2D - s2DCV - s2DGA) * 0.3, (s3 - s3CV - s3GA) * 0.3, (s3D - s3CV - s3GA) * 0.3, (s4 - s4CV - s4GA) * 0.3, (s4D - s4CV - s4GA) * 0.3, (s5 - s5CV - s5GA) * 0.3, (s5D - s5DCV - s5GA) * 0.3, d)
        'numero = numero + 1
        'cargaTemporalDato("6x" & conc(numero) & "Gastos", "Ganancia o perdida del perriodo:", 0, "GASTOS", -1 * numero, 0, (s1 - s1CV - s1GA) - ((s1 - s1CV - s1GA) * 0.3), (s1D - s1DCV - s1DGA) - ((s1D - s1DCV - s1DGA) * 0.3), (s2 - s2CV - s2GA) - ((s2 - s2CV - s2GA) * 0.3), (s2D - s2DCV - s2DGA) - ((s2D - s2DCV - s2DGA) * 0.3), (s3 - s3CV - s3GA) - ((s3 - s3CV - s3GA) * 0.3), (s3D - s3CV - s3GA) - ((s3D - s3CV - s3GA) * 0.3), (s4 - s4CV - s4GA) - ((s4 - s4CV - s4GA) * 0.3), (s4D - s4CV - s4GA) - ((s4D - s4CV - s4GA) * 0.3), (s5 - s5CV - s5GA) - ((s5 - s5CV - s5GA) * 0.3), (s5D - s5DCV - s5GA) - ((s5D - s5DCV - s5GA) * 0.3), d)
        'numero = numero + 1
    End Sub
    Sub subtotalesBalance(ByVal d As dtBalanceSituacion)
        'INGRESOS
        Dim s1 As Double = 0
        Dim s2 As Double = 0
        Dim s3 As Double = 0
        Dim s4 As Double = 0
        Dim s5 As Double = 0
        Dim s6 As Double = 0
        Dim s1D As Double = 0
        Dim s2D As Double = 0
        Dim s3D As Double = 0
        Dim s4D As Double = 0
        Dim s5D As Double = 0
        Dim s6D As Double = 0

        Dim numero As Integer = 1
        For i As Integer = 0 To d.TemporalBalance.Count - 1
            'ACTIVOS
            If d.TemporalBalance(i).Tipo.Equals("ACTIVOS") And d.TemporalBalance(i).Nivel = 0 Then
                Me.cargaTemporalDato("1x" & numero & "Activos", "Total Activos:", 0, "ACTIVOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1
            ElseIf d.TemporalBalance(i).Tipo.Equals("ACTIVOS") And d.TemporalBalance(i).Nivel = 1 Then
                Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "1x" & numero & "Activos", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "ACTIVOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1
            End If
            'PASIVOS
            If d.TemporalBalance(i).Tipo.Equals("PASIVOS") And d.TemporalBalance(i).Nivel = 0 Then
                Me.cargaTemporalDato("2x" & numero & "Pasivos", "Total Pasivos:", 0, "PASIVOS", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1
            ElseIf d.TemporalBalance(i).Tipo.Equals("PASIVOS") And d.TemporalBalance(i).Nivel = 1 Then
                Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "2x" & numero & "PASIVOS", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "PASIVOS", -1, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1
            End If
            'CAPITAL
            If d.TemporalBalance(i).Tipo.Equals("CAPITAL") And d.TemporalBalance(i).Nivel = 0 Then
                Me.cargaTemporalDato("4x" & numero & "Patrimonio", "Total PATRIMONIO:", 0, "PATRIMONIO", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                For h As Integer = 0 To d.TemporalBalance.Count - 1
                    If d.TemporalBalance(h).Tipo.Equals("PASIVOS") And d.TemporalBalance(h).Nivel = 0 Then
                        s1 = d.TemporalBalance(h).SaldoP
                        s2 = d.TemporalBalance(h).SaldoP2
                        s3 = d.TemporalBalance(h).SaldoP3
                        s4 = d.TemporalBalance(h).SaldoP4
                        s5 = d.TemporalBalance(h).SaldoP5
                        s1D = d.TemporalBalance(h).SaldoPD
                        s2D = d.TemporalBalance(h).SaldoPD2
                        s3D = d.TemporalBalance(h).SaldoPD3
                        s4D = d.TemporalBalance(h).SaldoPD4
                        s5D = d.TemporalBalance(h).SaldoPD5
                    End If
                Next
                numero = numero + 1
                Me.cargaTemporalDato("5x" & numero & "Patrimonio", "Total (Pasivo y Patrimonio):", 0, "PATRIMONIO", -1 * numero, 0, d.TemporalBalance(i).SaldoP + s1, d.TemporalBalance(i).SaldoPD + s1D, d.TemporalBalance(i).SaldoP2 + s2, d.TemporalBalance(i).SaldoPD2 + s2D, d.TemporalBalance(i).SaldoP3 + s3, d.TemporalBalance(i).SaldoPD3 + s3D, d.TemporalBalance(i).SaldoP4 + s4, d.TemporalBalance(i).SaldoPD4 + s4D, d.TemporalBalance(i).SaldoP5 + s5, d.TemporalBalance(i).SaldoPD5 + s5D, d)
                numero = numero + 1
            ElseIf d.TemporalBalance(i).Tipo.Equals("CAPITAL") And d.TemporalBalance(i).Nivel = 1 Then
                Me.cargaTemporalDato(d.TemporalBalance(i).CuentaContable.Substring(0, 4) & "3x" & numero & "Capital", "Total " & d.TemporalBalance(i).Descripcion & " :", 1, "CAPITAL", -1 * numero, 0, d.TemporalBalance(i).SaldoP, d.TemporalBalance(i).SaldoPD, d.TemporalBalance(i).SaldoP2, d.TemporalBalance(i).SaldoPD2, d.TemporalBalance(i).SaldoP3, d.TemporalBalance(i).SaldoPD3, d.TemporalBalance(i).SaldoP4, d.TemporalBalance(i).SaldoPD4, d.TemporalBalance(i).SaldoP5, d.TemporalBalance(i).SaldoPD5, d)
                numero = numero + 1
            End If

        Next
        Me.subtotalesEstadoResultadoENBalance(DtBalanceSituacion1, d, numero)

    End Sub
    Function cargar(ByVal DsBalances1 As dtBalanceSituacion)
        Dim i As Integer
        Dim trans As SqlTransaction
        Try

            DsBalances1.TemporalBalance.Clear()
            Dim cx As New Conexion
            cx.Conectar()
            cx.SlqExecute(cx.sQlconexion, "DELETE FROM TemporalBalance")
            cx.DesConectar(cx.sQlconexion)

            For i = 0 To DsBalances1.CuentaContable.Rows.Count - 1
                If Not DsBalances1.CuentaContable(i).RowState = DataRowState.Deleted Then


                    If Tipo = 1 Then
                        If Not EstaEnCero(DsBalances1.CuentaContable(i)) Then
                            BindingContext(DsBalances1.TemporalBalance).AddNew()
                            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                            BindingContext(DsBalances1.TemporalBalance).Current("Tipo") = DsBalances1.CuentaContable.Rows(i).Item("Tipo")
                            BindingContext(DsBalances1.TemporalBalance).Current("Id") = DsBalances1.CuentaContable.Rows(i).Item("Id")
                            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = DsBalances1.CuentaContable(i).Saldo
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = DsBalances1.CuentaContable(i).SaldoD
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = DsBalances1.CuentaContable(i).SaldoP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = DsBalances1.CuentaContable(i).SaldoDP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = DsBalances1.CuentaContable(i).SaldoP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = DsBalances1.CuentaContable(i).SaldoDP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = DsBalances1.CuentaContable(i).SaldoP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = DsBalances1.CuentaContable(i).SaldoDP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = DsBalances1.CuentaContable(i).SaldoP5
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = DsBalances1.CuentaContable(i).SaldoDP5
                            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
                        End If
                    Else
                        If Not EstaEnCero(DsBalances1.CuentaContable(i)) Then
                            BindingContext(DsBalances1.TemporalBalance).AddNew()
                            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                            BindingContext(DsBalances1.TemporalBalance).Current("Tipo") = DsBalances1.CuentaContable.Rows(i).Item("Tipo")
                            BindingContext(DsBalances1.TemporalBalance).Current("Id") = DsBalances1.CuentaContable.Rows(i).Item("Id")
                            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = DsBalances1.CuentaContable(i).Saldo
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = DsBalances1.CuentaContable(i).SaldoD
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = DsBalances1.CuentaContable(i).SaldoP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = DsBalances1.CuentaContable(i).SaldoDP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = DsBalances1.CuentaContable(i).SaldoP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = DsBalances1.CuentaContable(i).SaldoDP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = DsBalances1.CuentaContable(i).SaldoP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = DsBalances1.CuentaContable(i).SaldoDP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = DsBalances1.CuentaContable(i).SaldoP5
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = DsBalances1.CuentaContable(i).SaldoDP5
                            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
                        End If
                    End If
                End If
            Next
            subtotalesBalance(DsBalances1)

            If SqlConnection1.State <> ConnectionState.Open Then SqlConnection1.Open()
            trans = SqlConnection1.BeginTransaction
            Me.GuardaTemporal.InsertCommand.Transaction = trans
            Me.GuardaTemporal.UpdateCommand.Transaction = trans
            Me.GuardaTemporal.DeleteCommand.Transaction = trans
            Me.GuardaTemporal.Update(DsBalances1, "TemporalBalance")
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            SqlConnection1.Close()
        End Try
    End Function
    Sub CargaSubTotal(ByVal dt As dtBalanceSituacion.CuentaContableDataTable, ByVal i As Integer, ByVal DsBalances1 As dtBalanceSituacion)
        Dim s1 As Double = 0
        Dim s2 As Double = 0
        Dim s3 As Double = 0
        Dim s4 As Double = 0
        Dim s5 As Double = 0
        Dim s6 As Double = 0
        Dim s1D As Double = 0
        Dim s2D As Double = 0
        Dim s3D As Double = 0
        Dim s4D As Double = 0
        Dim s5D As Double = 0
        Dim s6D As Double = 0

        If dt(i).Tipo.Equals("INGRESOS") And sub1 = 0 Then
            If sub1 = 0 Then sub1 = 1
        ElseIf dt(i).Tipo.Equals("COSTO VENTA") And Me.sub2 = 0 Then
            If sub2 = 0 Then
                sub2 = i
            End If
            If sub1 = 1 Then
                For j As Integer = (sub1 - 1) To i - 1
                    If Not (dt(j).RowState = DataRowState.Deleted) Then
                        If dt(j).Movimiento = True Then
                            s1 += dt(j).Saldo
                            s2 += dt(j).SaldoP2
                            s3 += dt(j).SaldoP3
                            s4 += dt(j).SaldoP4
                            s5 += dt(j).SaldoP5
                            s6 += dt(j).SaldoP6
                            '---------------------------
                            s1D += dt(j).SaldoD
                            s2D += dt(j).SaldoDP2
                            s3D += dt(j).SaldoDP3
                            s4D += dt(j).SaldoDP4
                            s5D += dt(j).SaldoDP5
                            s6D += dt(j).SaldoDP6
                        End If
                    End If

                Next
                cargaTemporalDato("4xIngresos", "Total Ingresos: ", 0, "INGRESOS", -1, 0, s1, s1D, s2, s2D, s3, s3D, s4, s4D, s5, s5D, DsBalances1)

            End If
        ElseIf dt(i).Tipo.Equals("GASTOS") And Me.sub3 = 0 Then
            If sub3 = 0 Then
                sub3 = i
            End If
            If sub2 > 0 Then
                For j As Integer = (sub2) To i - 1
                    If dt(j).Movimiento = True Then
                        s1 += dt(j).Saldo
                        s2 += dt(j).SaldoP2
                        s3 += dt(j).SaldoP3
                        s4 += dt(j).SaldoP4
                        s5 += dt(j).SaldoP5
                        s6 += dt(j).SaldoP6
                        '---------------------------
                        s1D += dt(j).SaldoD
                        s2D += dt(j).SaldoDP2
                        s3D += dt(j).SaldoDP3
                        s4D += dt(j).SaldoDP4
                        s5D += dt(j).SaldoDP5
                        s6D += dt(j).SaldoDP6
                    End If
                Next
                cargaTemporalDato("5x1CostoVenta", "Total costo venta: ", 0, "COSTO VENTA", -2, 0, s1, s1D, s2, s2D, s3, s3D, s4, s4D, s5, s5D, DsBalances1)

            End If
        ElseIf sub3 > 0 Then

            For j As Integer = (sub3) To DsBalances1.CuentaContable.Count - 1
                If Not (dt(j).RowState = DataRowState.Deleted) Then
                    If dt(j).Movimiento = True Then
                        s1 += dt(j).Saldo
                        s2 += dt(j).SaldoP2
                        s3 += dt(j).SaldoP3
                        s4 += dt(j).SaldoP4
                        s5 += dt(j).SaldoP5
                        s6 += dt(j).SaldoP6
                        '---------------------------
                        s1D += dt(j).SaldoD
                        s2D += dt(j).SaldoDP2
                        s3D += dt(j).SaldoDP3
                        s4D += dt(j).SaldoDP4
                        s5D += dt(j).SaldoDP5
                        s6D += dt(j).SaldoDP6
                    End If
                End If
            Next
            cargaTemporalDato("6x1Gastos", "Total Gastos: ", 0, "GASTOS", -3, 0, s1, s1D, s2, s2D, s3, s3D, s4, s4D, s5, s5D, DsBalances1)
            sub3 = -1

        End If
    End Sub
    Sub cargaTemporalDato(ByVal Cuenta As String, ByVal Descripcion As String, ByVal Nivel As Integer, ByVal Tipo As String, ByVal id As Integer, ByVal ParentID As Integer, ByVal s1 As Double, ByVal s1D As Double, ByVal s2 As Double, ByVal s2D As Double, ByVal s3 As Double, ByVal s3D As Double, ByVal s4 As Double, ByVal s4D As Double, ByVal s5 As Double, ByVal s5D As Double, ByVal DsBalances1 As dtBalanceSituacion)

        BindingContext(DsBalances1.TemporalBalance).AddNew()
        BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = Cuenta
        BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = Descripcion
        BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = Nivel
        BindingContext(DsBalances1.TemporalBalance).Current("Tipo") = Tipo
        BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = False
        BindingContext(DsBalances1.TemporalBalance).Current("Id") = id
        BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = 0
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = s1
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = s1D
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = s2
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = s2D
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = s3
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = s3D
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = s4
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = s4D
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = s5
        BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = s5D
        BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
        If Cuenta.Equals("4xIngresos") Then
            lI = BindingContext(DsBalances1.TemporalBalance).Count - 1
        End If
        If Cuenta.Equals("5xCostoVenta") Then

            lC = BindingContext(DsBalances1.TemporalBalance).Count - 1
            BindingContext(DsBalances1.TemporalBalance).AddNew()
            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = "5xUtilidadBruta"
            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = " Utilidad Bruta: "
            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = Nivel
            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = False
            BindingContext(DsBalances1.TemporalBalance).Current("Id") = id
            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = 0
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = DsBalances1.TemporalBalance(lI).SaldoP - s1
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = DsBalances1.TemporalBalance(lI).SaldoPD - s1D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = DsBalances1.TemporalBalance(lI).SaldoP2 - s2
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = DsBalances1.TemporalBalance(lI).SaldoPD2 - s2D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = DsBalances1.TemporalBalance(lI).SaldoP3 - s3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = DsBalances1.TemporalBalance(lI).SaldoPD3 - s3D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = DsBalances1.TemporalBalance(lI).SaldoP4 - s4
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = DsBalances1.TemporalBalance(lI).SaldoPD4 - s4D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = DsBalances1.TemporalBalance(lI).SaldoP5 - s5
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = DsBalances1.TemporalBalance(lI).SaldoPD5 - s5D
            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
            lI = BindingContext(DsBalances1.TemporalBalance).Count - 1
        End If
        If Cuenta.Equals("6x1Gastos") Then
            lG = BindingContext(DsBalances1.TemporalBalance).Count - 1
            BindingContext(DsBalances1.TemporalBalance).AddNew()
            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = "6x2UtilidadAntesImp"
            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = " Utilidad antes impuestos: "
            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = Nivel
            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = False
            BindingContext(DsBalances1.TemporalBalance).Current("Id") = id
            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = 0
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = DsBalances1.TemporalBalance(lI).SaldoP - s1
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = DsBalances1.TemporalBalance(lI).SaldoPD - s1D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = DsBalances1.TemporalBalance(lI).SaldoP2 - s2
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = DsBalances1.TemporalBalance(lI).SaldoPD2 - s2D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = DsBalances1.TemporalBalance(lI).SaldoP3 - s3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = DsBalances1.TemporalBalance(lI).SaldoPD3 - s3D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = DsBalances1.TemporalBalance(lI).SaldoP4 - s4
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = DsBalances1.TemporalBalance(lI).SaldoPD4 - s4D
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = DsBalances1.TemporalBalance(lI).SaldoP5 - s5
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = DsBalances1.TemporalBalance(lI).SaldoPD5 - s5D
            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
            lC = BindingContext(DsBalances1.TemporalBalance).Count - 1
            BindingContext(DsBalances1.TemporalBalance).AddNew()
            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = "6x3Impuesto"
            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = " Impuesto sobre la renta: "
            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = Nivel
            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = False
            BindingContext(DsBalances1.TemporalBalance).Current("Id") = id
            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = 0
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = (DsBalances1.TemporalBalance(lI).SaldoP - s1) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = (DsBalances1.TemporalBalance(lI).SaldoPD - s1D) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = (DsBalances1.TemporalBalance(lI).SaldoP2 - s2) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = (DsBalances1.TemporalBalance(lI).SaldoPD2 - s2D) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = (DsBalances1.TemporalBalance(lI).SaldoP3 - s3) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = (DsBalances1.TemporalBalance(lI).SaldoPD3 - s3D) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = (DsBalances1.TemporalBalance(lI).SaldoP4 - s4) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = (DsBalances1.TemporalBalance(lI).SaldoPD4 - s4D) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = (DsBalances1.TemporalBalance(lI).SaldoP5 - s5) * 0.3
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = (DsBalances1.TemporalBalance(lI).SaldoPD5 - s5D) * 0.3
            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
            lC = BindingContext(DsBalances1.TemporalBalance).Count - 1
            BindingContext(DsBalances1.TemporalBalance).AddNew()
            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = "6x4UtilidadNeta"
            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = " Utilidad Neta: "
            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = Nivel
            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = False
            BindingContext(DsBalances1.TemporalBalance).Current("Id") = id
            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = 0
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = (DsBalances1.TemporalBalance(lI).SaldoP - s1) - ((DsBalances1.TemporalBalance(lI).SaldoP - s1) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = (DsBalances1.TemporalBalance(lI).SaldoPD - s1D) - ((DsBalances1.TemporalBalance(lI).SaldoPD - s1D) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = (DsBalances1.TemporalBalance(lI).SaldoP2 - s2) - ((DsBalances1.TemporalBalance(lI).SaldoP2 - s2) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = (DsBalances1.TemporalBalance(lI).SaldoPD2 - s2D) - ((DsBalances1.TemporalBalance(lI).SaldoPD2 - s2D) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = (DsBalances1.TemporalBalance(lI).SaldoP3 - s3) - ((DsBalances1.TemporalBalance(lI).SaldoP3 - s3) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = (DsBalances1.TemporalBalance(lI).SaldoPD3 - s3D) - ((DsBalances1.TemporalBalance(lI).SaldoPD3 - s3D) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = (DsBalances1.TemporalBalance(lI).SaldoP4 - s4) - ((DsBalances1.TemporalBalance(lI).SaldoP4 - s4) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = (DsBalances1.TemporalBalance(lI).SaldoPD4 - s4D) - ((DsBalances1.TemporalBalance(lI).SaldoPD4 - s4D) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = (DsBalances1.TemporalBalance(lI).SaldoP5 - s5) - ((DsBalances1.TemporalBalance(lI).SaldoP5 - s5) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = (DsBalances1.TemporalBalance(lI).SaldoPD5 - s5D) - ((DsBalances1.TemporalBalance(lI).SaldoPD5 - s5D) * 0.3)
            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
            lC = BindingContext(DsBalances1.TemporalBalance).Count - 1
        End If


    End Sub
    Function cargarEstadoResultado(ByVal DsBalances1 As dtBalanceSituacion)
        Dim i As Integer
        Dim trans As SqlTransaction
        Try

            DsBalances1.TemporalBalance.Clear()
            Dim cx As New Conexion
            cx.Conectar()
            cx.SlqExecute(cx.sQlconexion, "DELETE FROM TemporalBalance")
            cx.DesConectar(cx.sQlconexion)


            For i = 0 To DsBalances1.CuentaContable.Rows.Count - 1
                If Not DsBalances1.CuentaContable(i).RowState = DataRowState.Deleted Then


                    If Tipo = 1 Then
                        If Not EstaEnCero(DsBalances1.CuentaContable(i)) Then

                            BindingContext(DsBalances1.TemporalBalance).AddNew()
                            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                            BindingContext(DsBalances1.TemporalBalance).Current("Id") = DsBalances1.CuentaContable.Rows(i).Item("Id")
                            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = DsBalances1.CuentaContable(i).Saldo
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = DsBalances1.CuentaContable(i).SaldoD
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = DsBalances1.CuentaContable(i).SaldoP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = DsBalances1.CuentaContable(i).SaldoDP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = DsBalances1.CuentaContable(i).SaldoP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = DsBalances1.CuentaContable(i).SaldoDP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = DsBalances1.CuentaContable(i).SaldoP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = DsBalances1.CuentaContable(i).SaldoDP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = DsBalances1.CuentaContable(i).SaldoP5
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = DsBalances1.CuentaContable(i).SaldoDP5
                            BindingContext(DsBalances1.TemporalBalance).Current("Tipo") = DsBalances1.CuentaContable(i).Tipo
                            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
                            ' Me.CargaSubTotal(DsBalances1.CuentaContable, i, DsBalances1)

                        End If
                    Else
                        If Not EstaEnCero(DsBalances1.CuentaContable(i)) Then
                            BindingContext(DsBalances1.TemporalBalance).AddNew()
                            BindingContext(DsBalances1.TemporalBalance).Current("CuentaContable") = DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                            BindingContext(DsBalances1.TemporalBalance).Current("Descripcion") = DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                            BindingContext(DsBalances1.TemporalBalance).Current("Nivel") = DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                            BindingContext(DsBalances1.TemporalBalance).Current("Movimiento") = DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                            BindingContext(DsBalances1.TemporalBalance).Current("Id") = DsBalances1.CuentaContable.Rows(i).Item("Id")
                            BindingContext(DsBalances1.TemporalBalance).Current("PARENTID") = DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP") = DsBalances1.CuentaContable(i).Saldo
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD") = DsBalances1.CuentaContable(i).SaldoD
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP2") = DsBalances1.CuentaContable(i).SaldoP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD2") = DsBalances1.CuentaContable(i).SaldoDP2
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP3") = DsBalances1.CuentaContable(i).SaldoP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD3") = DsBalances1.CuentaContable(i).SaldoDP3
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP4") = DsBalances1.CuentaContable(i).SaldoP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD4") = DsBalances1.CuentaContable(i).SaldoDP4
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoP5") = DsBalances1.CuentaContable(i).SaldoP5
                            BindingContext(DsBalances1.TemporalBalance).Current("SaldoPD5") = DsBalances1.CuentaContable(i).SaldoDP5
                            BindingContext(DsBalances1.TemporalBalance).Current("Tipo") = DsBalances1.CuentaContable(i).Tipo
                            BindingContext(DsBalances1.TemporalBalance).EndCurrentEdit()
                            ' Me.CargaSubTotal(DsBalances1.CuentaContable, i, DsBalances1)
                        End If
                    End If

                End If
            Next
            subtotalesEstadoResultado(DsBalances1)
            If SqlConnection1.State <> ConnectionState.Open Then SqlConnection1.Open()
            trans = SqlConnection1.BeginTransaction
            Me.GuardaTemporal.InsertCommand.Transaction = trans
            Me.GuardaTemporal.UpdateCommand.Transaction = trans
            Me.GuardaTemporal.DeleteCommand.Transaction = trans
            Me.GuardaTemporal.Update(DsBalances1, "TemporalBalance")
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            SqlConnection1.Close()
        End Try
    End Function
    Sub imprimirEstadoResultado()
        
        Dim Asientos As Object
        Dim asientos1 As New BalanceSituacionDolarYColon
        If Me.CheckBoxPrintBanco.Checked Then
            Asientos = New BalanceSituacionBanco
        Else
            If Me.NumericUpDown1.Value = 0 Then
                Asientos = New EstadoResultad1p
            ElseIf Me.NumericUpDown1.Value = 1 Then
                Asientos = New EstadoResultad2p
            ElseIf Me.NumericUpDown1.Value = 2 Then
                Asientos = New EstadoResultad2p
            ElseIf Me.NumericUpDown1.Value = 3 Then
                Asientos = New EstadoResultad3p
            ElseIf Me.NumericUpDown1.Value = 4 Then
                Asientos = New EstadoResultad4p
            Else
                Asientos = New EstadoResultad5p
            End If


        End If
        Dim f As String
        If Me.RadioButtonMeses.Checked Then
            f = "MMMM yyyy"
        Else
            f = "yyyy"
        End If

        Dim visor As New frmVisorReportes
        Me.cargarEstadoResultado(dst)
        Me.lC = 0 : Me.lI = 0 : Me.lG = 0 : Me.sub3 = 0 : Me.sub1 = 0 : Me.sub2 = 0
        If Tipo = 1 Then
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, asientos1, False, conectadobd.ConnectionString)
            '
            asientos1.SetParameterValue(0, dtFinal.Text)
            asientos1.SetParameterValue(1, dtFinal.Text)
            asientos1.SetParameterValue(2, 0) : asientos1.SetParameterValue(3, 0) : asientos1.SetParameterValue(4, 0) : asientos1.SetParameterValue(5, 0) : asientos1.SetParameterValue(6, 0) : asientos1.SetParameterValue(7, NumericUpDown2.Value)
            asientos1.SetParameterValue(8, "Balance Situación")
            asientos1.SetParameterValue(9, Moneda.Text)


            Dim i As Int16 = NumericUpDown1.Value
            Dim simb As String = " ¢"
            If Tipo = 1 Then
            Else
                If Moneda.SelectedValue = 2 Then
                    simb = " $"
                Else
                    simb = " ¢"
                End If

            End If
            If RadioButtonMeses.Checked Then
                asientos1.SetParameterValue(10, Format(dtFinal.Value, "MMMM,yyyy") & " " & simb)

                If Tipo = 1 Then
                    asientos1.SetParameterValue(15, Format(dtFinal.Value, "MMMM,yyyy") & " $")
                Else
                    asientos1.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    asientos1.SetParameterValue(11, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(16, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " $")
                    Else
                        asientos1.SetParameterValue(16, "")
                    End If
                Else
                    asientos1.SetParameterValue(16, "")
                    asientos1.SetParameterValue(11, "")
                End If
                If i >= 2 Then

                    asientos1.SetParameterValue(12, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then

                        asientos1.SetParameterValue(17, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " $")

                    Else
                        asientos1.SetParameterValue(17, "")

                    End If
                Else
                    asientos1.SetParameterValue(17, "")
                    asientos1.SetParameterValue(12, "")

                End If
                If i >= 3 Then
                    asientos1.SetParameterValue(13, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then
                        asientos1.SetParameterValue(18, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " $")

                    Else
                        asientos1.SetParameterValue(18, "")

                    End If
                Else
                    asientos1.SetParameterValue(13, "")
                    asientos1.SetParameterValue(18, "")
                End If

                If i >= 4 Then
                    asientos1.SetParameterValue(14, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(19, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " $")

                    Else
                        asientos1.SetParameterValue(19, "")

                    End If
                Else
                    asientos1.SetParameterValue(14, "")
                    asientos1.SetParameterValue(19, "")

                End If
                'If i >= 5 Then
                '    asientos1.SetParameterValue(15, Format(dtFinal.Value.AddMonths(-5), "MMMM,yyyy") & " " & simb)
                '    If Tipo = 1 Then
                '        asientos1.SetParameterValue(20, Format(dtFinal.Value.AddMonths(-5), "MMMM,yyyy") & " $")
                '    Else
                '        asientos1.SetParameterValue(20, "")
                '    End If
                'Else
                '    asientos1.SetParameterValue(19, "")
                'End If
            Else
                asientos1.SetParameterValue(10, Format(dtFinal.Value, "yyyy") & " " & simb)
                If Tipo = 1 Then

                    asientos1.SetParameterValue(15, Format(dtFinal.Value, "yyyy") & " $")
                Else
                    asientos1.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    asientos1.SetParameterValue(11, Format(dtFinal.Value.AddYears(-1), "yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(16, Format(dtFinal.Value.AddYears(-1), "yyyy") & " $")
                    Else
                        asientos1.SetParameterValue(16, "")
                    End If
                Else
                    asientos1.SetParameterValue(11, "")
                End If

                If i >= 2 Then
                    asientos1.SetParameterValue(12, Format(dtFinal.Value.AddYears(-2), "yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(17, Format(dtFinal.Value.AddYears(-2), "yyyy") & " $")
                    Else
                        asientos1.SetParameterValue(17, "")
                    End If
                Else
                    asientos1.SetParameterValue(12, "")

                End If
                asientos1.SetParameterValue(13, "")
                asientos1.SetParameterValue(14, "")
                asientos1.SetParameterValue(18, "")
                asientos1.SetParameterValue(19, "")

            End If
        Else
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Asientos, False, conectadobd.ConnectionString)
            '
            Asientos.SetParameterValue(0, dtFinal.Text)
            Asientos.SetParameterValue(1, dtFinal.Text)
            Asientos.SetParameterValue(2, 0) : Asientos.SetParameterValue(3, 0) : Asientos.SetParameterValue(4, 0) : Asientos.SetParameterValue(5, 0) : Asientos.SetParameterValue(6, 0) : Asientos.SetParameterValue(7, NumericUpDown2.Value)
            If Me.NumericUpDown1.Value = 1 Then
                If Me.RadioButtonMeses.Checked Then
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                                            & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddMonths(-1), f) & "   ")
                Else
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                   & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddYears(-1), f) & "   ")
                End If


            ElseIf Me.NumericUpDown1.Value = 2 Then
                If Me.RadioButtonMeses.Checked Then
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                    & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & " y " & Format(dtFinal.Value.AddMonths(-2), f))
                Else
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                                            & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & " y " & Format(dtFinal.Value.AddYears(-2), f))
                End If


            ElseIf Me.NumericUpDown1.Value = 3 Then
                If Me.RadioButtonMeses.Checked Then
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                                           & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y " & Format(dtFinal.Value.AddMonths(-1), f))
                Else
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
& "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM"))
                End If


            ElseIf Me.NumericUpDown1.Value = 4 Then
                If Me.RadioButtonMeses.Checked Then
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                                           & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & ", " & Format(dtFinal.Value.AddMonths(-3), f) & " y " & Format(dtFinal.Value.AddMonths(-4), f))
                Else
                    Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                    & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & ", " & Format(dtFinal.Value.AddYears(-2), f) & ", " & Format(dtFinal.Value.AddYears(-3), f) & " y " & Format(dtFinal.Value.AddYears(-4), f))
                End If

            Else
                Asientos.SetParameterValue(8, "Estado Resultado " & vbCrLf _
                                                   & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy"))


            End If

            Asientos.SetParameterValue(9, Moneda.Text)


            Dim i As Int16 = NumericUpDown1.Value
            Dim simb As String = " ¢"
            If Tipo = 1 Then
            Else
                If Moneda.SelectedValue = 2 Then
                    simb = " $"
                Else
                    simb = " ¢"
                End If

            End If
            If RadioButtonMeses.Checked Then
                Asientos.SetParameterValue(10, Format(dtFinal.Value, "MMMM,yyyy") & " " & simb)

                If Tipo = 1 Then
                    Asientos.SetParameterValue(15, Format(dtFinal.Value, "MMMM,yyyy") & " $")
                Else
                    Asientos.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    Asientos.SetParameterValue(11, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(16, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " $")
                    Else
                        Asientos.SetParameterValue(16, "")
                    End If
                Else
                    Asientos.SetParameterValue(11, "")
                End If
                If i >= 2 Then

                    Asientos.SetParameterValue(12, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then

                        Asientos.SetParameterValue(17, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " $")

                    Else
                        Asientos.SetParameterValue(17, "")

                    End If
                Else
                    Asientos.SetParameterValue(12, "")

                End If
                If i >= 3 Then
                    Asientos.SetParameterValue(13, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then
                        Asientos.SetParameterValue(18, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " $")

                    Else
                        Asientos.SetParameterValue(18, "")

                    End If
                Else
                    Asientos.SetParameterValue(13, "")

                End If

                If i >= 4 Then
                    Asientos.SetParameterValue(14, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(19, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " $")

                    Else
                        Asientos.SetParameterValue(19, "")

                    End If
                Else
                    Asientos.SetParameterValue(14, "")

                End If
                'If i >= 5 Then
                '    Asientos.SetParameterValue(15, Format(dtFinal.Value.AddMonths(-5), "MMMM,yyyy") & " " & simb)
                '    If Tipo = 1 Then
                '        Asientos.SetParameterValue(20, Format(dtFinal.Value.AddMonths(-5), "MMMM,yyyy") & " $")
                '    Else
                '        Asientos.SetParameterValue(20, "")
                '    End If
                'Else
                '    Asientos.SetParameterValue(19, "")
                'End If
            Else
                Asientos.SetParameterValue(10, Format(dtFinal.Value, "yyyy") & " " & simb)
                If Tipo = 1 Then

                    Asientos.SetParameterValue(15, Format(dtFinal.Value, "yyyy") & " $")
                Else
                    Asientos.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    Asientos.SetParameterValue(11, Format(dtFinal.Value.AddYears(-1), "yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(16, Format(dtFinal.Value.AddYears(-1), "yyyy") & " $")
                    Else
                        Asientos.SetParameterValue(16, "")
                    End If
                Else
                    Asientos.SetParameterValue(11, "")
                End If

                If i >= 2 Then
                    Asientos.SetParameterValue(12, Format(dtFinal.Value.AddYears(-2), "yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(17, Format(dtFinal.Value.AddYears(-2), "yyyy") & " $")
                    Else
                        Asientos.SetParameterValue(17, "")
                    End If
                Else
                    Asientos.SetParameterValue(12, "")

                End If
                Asientos.SetParameterValue(13, "")
                Asientos.SetParameterValue(14, "")
                Asientos.SetParameterValue(18, "")
                Asientos.SetParameterValue(19, "")

            End If
        End If

        visor.Show()
    End Sub
    Sub imprimirBalance()
        Dim Asientos As Object
        Dim asientos1 As Object
        If Me.NumericUpDown1.Value = 0 Then
            asientos1 = New BalanceSituacionDolarYColon1P
        Else
            asientos1 = New BalanceSituacionDolarYColon
        End If

        Dim f As String
        If Me.RadioButtonMeses.Checked Then
            f = "MMMM yyyy"
        Else
            f = "yyyy"
        End If
        If Me.CheckBoxPrintBanco.Checked Then
            Asientos = New BalanceSituacionBanco
        Else
            If Me.NumericUpDown1.Value = 0 Then
                Asientos = New BalanceSituacion1p

            ElseIf Me.NumericUpDown1.Value = 1 Then
                Asientos = New BalanceSituacion2p
            ElseIf Me.NumericUpDown1.Value = 2 Then
                Asientos = New BalanceSituacion3p
            ElseIf Me.NumericUpDown1.Value = 3 Then
                Asientos = New BalanceSituacion4p
            ElseIf Me.NumericUpDown1.Value = 4 Then
                Asientos = New BalanceSituacion4p
            Else
                Asientos = New BalanceSituacion5p
            End If


        End If

        Dim visor As New frmVisorReportes
        Me.cargar(Me.dst)

        If Tipo = 1 Then
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, asientos1, False, conectadobd.ConnectionString)
            '
            asientos1.SetParameterValue(0, dtFinal.Text)
            asientos1.SetParameterValue(1, dtFinal.Text)
            asientos1.SetParameterValue(2, 0) : asientos1.SetParameterValue(3, 0) : asientos1.SetParameterValue(4, 0) : asientos1.SetParameterValue(5, 0) : asientos1.SetParameterValue(6, 0) : asientos1.SetParameterValue(7, NumericUpDown2.Value)
            If Me.CheckBoxPrintBanco.Checked Then
                If Me.RadioButtonMeses.Checked Then
                    asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                            & "Por el periodo terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddMonths(-1), f) & "   ")
                Else
                    asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                    & "Por el periodo terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddYears(-1), f) & "   ")
                End If

            Else
                asientos1.SetParameterValue(8, "Balance General")
                If Me.NumericUpDown1.Value = 1 Then
                    If Me.RadioButtonMeses.Checked Then
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                                & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddMonths(-1), f) & "   ")
                    Else
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                                                        & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddYears(-1), f) & "   ")
                    End If


                ElseIf Me.NumericUpDown1.Value = 2 Then
                    If Me.RadioButtonMeses.Checked Then
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                        & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & " y " & Format(dtFinal.Value.AddMonths(-2), f))
                    Else
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                                & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & " y " & Format(dtFinal.Value.AddYears(-2), f))
                    End If


                ElseIf Me.NumericUpDown1.Value = 3 Then
                    If Me.RadioButtonMeses.Checked Then
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                               & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & " y " & Format(dtFinal.Value.AddMonths(-3), f))
                    Else
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                      & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & ", " & Format(dtFinal.Value.AddYears(-2), f) & " y " & Format(dtFinal.Value.AddYears(-3), f))
                    End If


                ElseIf Me.NumericUpDown1.Value = 4 Then
                    If Me.RadioButtonMeses.Checked Then
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                           & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & ", " & Format(dtFinal.Value.AddMonths(-3), f) & " y " & Format(dtFinal.Value.AddMonths(-4), f))
                    Else
                        asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
        & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & ", " & Format(dtFinal.Value.AddYears(-2), f) & ", " & Format(dtFinal.Value.AddYears(-3), f) & " y " & Format(dtFinal.Value.AddYears(-4), f))
                    End If
                Else
                    asientos1.SetParameterValue(8, "Balance General " & vbCrLf _
                                                       & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & ", " & Format(dtFinal.Value.AddMonths(-3), f) & ", " & Format(dtFinal.Value.AddMonths(-4), f) & "  y " & Format(dtFinal.Value.AddMonths(-5), f))
                End If
            End If
            asientos1.SetParameterValue(9, Moneda.Text)


            Dim i As Int16 = NumericUpDown1.Value
            Dim simb As String = " ¢"
            If Tipo = 1 Then
            Else
                If Moneda.SelectedValue = 2 Then
                    simb = " $"
                Else
                    simb = " ¢"
                End If

            End If
            If RadioButtonMeses.Checked Then
                asientos1.SetParameterValue(10, Format(dtFinal.Value, "MMMM,yyyy") & " " & simb)

                If Tipo = 1 Then
                    asientos1.SetParameterValue(15, Format(dtFinal.Value, "MMMM,yyyy") & " $")
                Else
                    asientos1.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    asientos1.SetParameterValue(11, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(16, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " $")
                    Else
                        asientos1.SetParameterValue(16, "")
                    End If
                Else
                    asientos1.SetParameterValue(16, "")
                    asientos1.SetParameterValue(11, "")
                End If
                If i >= 2 Then

                    asientos1.SetParameterValue(12, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then

                        asientos1.SetParameterValue(17, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " $")

                    Else
                        asientos1.SetParameterValue(17, "")

                    End If
                Else
                    asientos1.SetParameterValue(17, "")
                    asientos1.SetParameterValue(12, "")

                End If
                If i >= 3 Then
                    asientos1.SetParameterValue(13, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then
                        asientos1.SetParameterValue(18, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " $")

                    Else
                        asientos1.SetParameterValue(18, "")

                    End If
                Else
                    asientos1.SetParameterValue(13, "")
                    asientos1.SetParameterValue(18, "")
                End If

                If i >= 4 Then
                    asientos1.SetParameterValue(14, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(19, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " $")

                    Else
                        asientos1.SetParameterValue(19, "")

                    End If
                Else
                    asientos1.SetParameterValue(14, "")
                    asientos1.SetParameterValue(19, "")

                End If

            Else '%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  PLAZOS POR AÑOS  %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

                asientos1.SetParameterValue(10, Format(dtFinal.Value, "MMMM yyyy") & " " & simb)
                If Tipo = 1 Then

                    asientos1.SetParameterValue(15, Format(dtFinal.Value, "MMMM yyyy") & " $")
                Else
                    asientos1.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    asientos1.SetParameterValue(11, Format(dtFinal.Value.AddYears(-1), "MMMM yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(16, Format(dtFinal.Value.AddYears(-1), "MMMM yyyy") & " $")
                    Else
                        asientos1.SetParameterValue(16, "")
                    End If
                Else
                    asientos1.SetParameterValue(11, "")
                End If

                If i >= 2 Then
                    asientos1.SetParameterValue(12, Format(dtFinal.Value.AddYears(-2), "MMMM yyyy") & " " & simb)
                    If Tipo = 1 Then
                        asientos1.SetParameterValue(17, Format(dtFinal.Value.AddYears(-2), "MMMM yyyy") & " $")
                    Else
                        asientos1.SetParameterValue(17, "")
                    End If
                Else
                    asientos1.SetParameterValue(12, "")

                End If
                asientos1.SetParameterValue(13, "")
                asientos1.SetParameterValue(14, "")
                asientos1.SetParameterValue(18, "")
                asientos1.SetParameterValue(19, "")

            End If
        Else
            '------------------------------------------------------------ BALANCE DE SITUACION -----------------------------------
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Asientos, False, conectadobd.ConnectionString)
            '
            Asientos.SetParameterValue(0, dtFinal.Text)
            Asientos.SetParameterValue(1, dtFinal.Text)
            Asientos.SetParameterValue(2, 0) : Asientos.SetParameterValue(3, 0) : Asientos.SetParameterValue(4, 0) : Asientos.SetParameterValue(5, 0) : Asientos.SetParameterValue(6, 0) : Asientos.SetParameterValue(7, NumericUpDown2.Value)
            If Me.CheckBoxPrintBanco.Checked Then
                Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                        & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddMonths(-1), f) & "   ")
            Else
                Asientos.SetParameterValue(8, "Balance General")
                If Me.NumericUpDown1.Value = 1 Then
                    If Me.RadioButtonMeses.Checked Then
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                                & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddMonths(-1), f) & "   ")
                    Else
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                       & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & " y  " & Format(dtFinal.Value.AddYears(-1), f) & "   ")
                    End If


                ElseIf Me.NumericUpDown1.Value = 2 Then
                    If Me.RadioButtonMeses.Checked Then
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                        & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & " y " & Format(dtFinal.Value.AddMonths(-2), f))
                    Else
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                                & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & " y " & Format(dtFinal.Value.AddYears(-2), f))
                    End If


                ElseIf Me.NumericUpDown1.Value = 3 Then
                    If Me.RadioButtonMeses.Checked Then
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                               & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & " y " & Format(dtFinal.Value.AddMonths(-3), f))
                    Else
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
& "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & " y " & Format(dtFinal.Value.AddYears(-2), f))
                    End If


                ElseIf Me.NumericUpDown1.Value = 4 Then
                    If Me.RadioButtonMeses.Checked Then
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                                               & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & ", " & Format(dtFinal.Value.AddMonths(-3), f) & " y " & Format(dtFinal.Value.AddMonths(-4), f))
                    Else
                        Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                        & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddYears(-1), f) & ", " & Format(dtFinal.Value.AddYears(-2), f) & ", " & Format(dtFinal.Value.AddYears(-3), f) & " y " & Format(dtFinal.Value.AddYears(-4), f))
                    End If

                Else
                    Asientos.SetParameterValue(8, "Balance General " & vbCrLf _
                                                       & "Por el período terminado el " & Format(dtFinal.Value, "dd MMMM yyyy") & ", " & Format(dtFinal.Value.AddMonths(-1), f) & ", " & Format(dtFinal.Value.AddMonths(-2), f) & ", " & Format(dtFinal.Value.AddMonths(-3), f) & ", " & Format(dtFinal.Value.AddMonths(-4), f) & "  y " & Format(dtFinal.Value.AddMonths(-5), f))
                End If
            End If
            Asientos.SetParameterValue(9, Moneda.Text)


            Dim i As Int16 = NumericUpDown1.Value
            Dim simb As String = " ¢"
            If Tipo = 1 Then
            Else
                If Moneda.SelectedValue = 2 Then
                    simb = " $"
                Else
                    simb = " ¢"
                End If

            End If
            If RadioButtonMeses.Checked Then
                Asientos.SetParameterValue(10, Format(dtFinal.Value, "MMMM,yyyy") & " " & simb)

                If Tipo = 1 Then
                    Asientos.SetParameterValue(15, Format(dtFinal.Value, "MMMM,yyyy") & " $")
                Else
                    Asientos.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    Asientos.SetParameterValue(11, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(16, Format(dtFinal.Value.AddMonths(-1), "MMMM,yyyy") & " $")
                    Else
                        Asientos.SetParameterValue(16, "")
                    End If
                Else
                    Asientos.SetParameterValue(11, "")
                End If
                If i >= 2 Then

                    Asientos.SetParameterValue(12, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then

                        Asientos.SetParameterValue(17, Format(dtFinal.Value.AddMonths(-2), "MMMM,yyyy") & " $")

                    Else
                        Asientos.SetParameterValue(17, "")

                    End If
                Else
                    Asientos.SetParameterValue(12, "")

                End If
                If i >= 3 Then
                    Asientos.SetParameterValue(13, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " " & simb)

                    If Tipo = 1 Then
                        Asientos.SetParameterValue(18, Format(dtFinal.Value.AddMonths(-3), "MMMM,yyyy") & " $")

                    Else
                        Asientos.SetParameterValue(18, "")

                    End If
                Else
                    Asientos.SetParameterValue(13, "")

                End If

                If i >= 4 Then
                    Asientos.SetParameterValue(14, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(19, Format(dtFinal.Value.AddMonths(-4), "MMMM,yyyy") & " $")

                    Else
                        Asientos.SetParameterValue(19, "")

                    End If
                Else
                    Asientos.SetParameterValue(14, "")

                End If

            Else '%%%%%%%%%%%%%%%%%%%%%%%%% PLAZOS POR AÑOS %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
                Asientos.SetParameterValue(10, Format(dtFinal.Value, "MMMM yyyy") & " " & simb)
                If Tipo = 1 Then

                    Asientos.SetParameterValue(15, Format(dtFinal.Value, "MMMM yyyy") & " $")
                Else
                    Asientos.SetParameterValue(15, "")
                End If


                If i >= 1 Then
                    Asientos.SetParameterValue(11, Format(dtFinal.Value.AddYears(-1), "MMMM yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(16, Format(dtFinal.Value.AddYears(-1), "MMMM yyyy") & " $")
                    Else
                        Asientos.SetParameterValue(16, "")
                    End If
                Else
                    Asientos.SetParameterValue(11, "")
                End If

                If i >= 2 Then
                    Asientos.SetParameterValue(12, Format(dtFinal.Value.AddYears(-2), "MMMM yyyy") & " " & simb)
                    If Tipo = 1 Then
                        Asientos.SetParameterValue(17, Format(dtFinal.Value.AddYears(-2), "MMMM yyyy") & " $")
                    Else
                        Asientos.SetParameterValue(17, "")
                    End If
                Else
                    Asientos.SetParameterValue(12, "")

                End If
                Asientos.SetParameterValue(13, "")
                Asientos.SetParameterValue(14, "")
                Asientos.SetParameterValue(18, "")
                Asientos.SetParameterValue(19, "")

            End If
        End If

        visor.Show()
    End Sub
    Dim dstpCopy as dtBalanceSituacion 
    Sub ImpresionSeleccion()

        If Me.TabControl1.SelectedIndex = 2 Then

            Dim r As New ResultadosPeriodo
            Dim v As New frmVisorReportes
            v.rptViewer.ReportSource = r
            r.SetDataSource(Me.dstP)
            If Me.RadioButtonXMes.Checked Then
                r.SetParameterValue(0, Format(Me.TimeMes1.Value, "MM/yyyy"))
                r.SetParameterValue(1, Format(Me.TimeMes2.Value, "MM/yyyy"))
            Else
                r.SetParameterValue(0, Me.cbAno1.Text)
                r.SetParameterValue(1, Me.cbAno2.Text)
            End If
            v.Show()
            Exit Sub

        End If
        If Me.TabControl1.SelectedIndex = 4 Then
            ImpresionBalancesAMES()
            Exit Sub

        End If

        If Me.TabControl1.SelectedIndex = 1 Then
            ImpresionBalancesAMES()
            Exit Sub
        End If
        If Me.TabControl1.SelectedIndex = 3 Then
            ImpresionBalancesMesXMes()
            Exit Sub
        End If
        If Not Me.EstadoResultado Then : imprimirBalance() : Else : Me.imprimirEstadoResultado() : End If


    End Sub

    Sub incluirSubtotalesAMES()
        Dim sActivosM1A1 As Double = 0
        Dim sActivosM2A1 As Double = 0
        Dim sActivosM3A1 As Double = 0
        Dim sActivosM1A2 As Double = 0
        Dim sActivosM2A2 As Double = 0
        Dim sActivosM3A2 As Double = 0
        Dim sActivosAcuM1A1 As Double = 0
        Dim sActivosAcuM1A2 As Double = 0
        Dim sPasivosM1A1 As Double = 0
        Dim sPasivosM2A1 As Double = 0
        Dim sPasivosM3A1 As Double = 0
        Dim sPasivosM1A2 As Double = 0
        Dim sPasivosM2A2 As Double = 0
        Dim sPasivosM3A2 As Double = 0
        Dim sPasivosAcuM1A1 As Double = 0
        Dim sPasivosAcuM1A2 As Double = 0
        Dim sCapitalM1A1 As Double = 0
        Dim sCapitalM2A1 As Double = 0
        Dim sCapitalM3A1 As Double = 0
        Dim sCapitalM1A2 As Double = 0
        Dim sCapitalM2A2 As Double = 0
        Dim sCapitalM3A2 As Double = 0
        Dim sCapitalAcuM1A1 As Double = 0
        Dim sCapitalAcuM1A2 As Double = 0
        Dim sIngresosM1A1 As Double = 0
        Dim sIngresosM2A1 As Double = 0
        Dim sIngresosM3A1 As Double = 0
        Dim sIngresosM1A2 As Double = 0
        Dim sIngresosM2A2 As Double = 0
        Dim sIngresosM3A2 As Double = 0
        Dim sIngresosAcuM1A1 As Double = 0
        Dim sIngresosAcuM1A2 As Double = 0
        Dim sCostoVentasM1A1 As Double = 0
        Dim sCostoVentasM2A1 As Double = 0
        Dim sCostoVentasM3A1 As Double = 0
        Dim sCostoVentasM1A2 As Double = 0
        Dim sCostoVentasM2A2 As Double = 0
        Dim sCostoVentasM3A2 As Double = 0
        Dim sCostoVentasAcuM1A1 As Double = 0
        Dim sCostoVentasAcuM1A2 As Double = 0
        Dim sGastosM1A1 As Double = 0
        Dim sGastosM2A1 As Double = 0
        Dim sGastosM3A1 As Double = 0
        Dim sGastosM1A2 As Double = 0
        Dim sGastosM2A2 As Double = 0
        Dim sGastosM3A2 As Double = 0
        Dim sGastosAcuM1A1 As Double = 0
        Dim sGastosAcuM1A2 As Double = 0
        Dim sOtrosIngresosM1A1 As Double = 0
        Dim sOtrosIngresosM2A1 As Double = 0
        Dim sOtrosIngresosM3A1 As Double = 0
        Dim sOtrosIngresosM1A2 As Double = 0
        Dim sOtrosIngresosM2A2 As Double = 0
        Dim sOtrosIngresosM3A2 As Double = 0
        Dim sOtrosIngresosAcuM1A1 As Double = 0
        Dim sOtrosIngresosAcuM1A2 As Double = 0
        Dim sOtrosGastosM1A1 As Double = 0
        Dim sOtrosGastosM2A1 As Double = 0
        Dim sOtrosGastosM3A1 As Double = 0
        Dim sOtrosGastosM1A2 As Double = 0
        Dim sOtrosGastosM2A2 As Double = 0
        Dim sOtrosGastosM3A2 As Double = 0
        Dim sOtrosGastosAcuM1A1 As Double = 0
        Dim sOtrosGastosAcuM1A2 As Double = 0
        Dim numero As Integer = 0
        Dim rw As DataRow()

        For i As Integer = 0 To Me.dstpCopy.MesAno.Count - 1
            If Me.dstpCopy.MesAno(i).Tipo.Equals("ACTIVOS") And dstpCopy.MesAno(i).Movimiento Then
                sActivosM1A1 += dstpCopy.MesAno(i).SM1A1 : sActivosM2A1 += dstpCopy.MesAno(i).SM2A1 : sActivosM3A1 += dstpCopy.MesAno(i).SM3A1 : sActivosM1A2 += dstpCopy.MesAno(i).SM1A2 : sActivosM2A2 += dstpCopy.MesAno(i).SM2A2 : sActivosM3A2 += dstpCopy.MesAno(i).SM3A2 : sActivosAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sActivosAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("COSTO VENTA") And dstpCopy.MesAno(i).Movimiento Then
                sCostoVentasM1A1 += dstpCopy.MesAno(i).SM1A1 : sCostoVentasM2A1 += dstpCopy.MesAno(i).SM2A1 : sCostoVentasM3A1 += dstpCopy.MesAno(i).SM3A1 : sCostoVentasM1A2 += dstpCopy.MesAno(i).SM1A2 : sCostoVentasM2A2 += dstpCopy.MesAno(i).SM2A2 : sCostoVentasM3A2 += dstpCopy.MesAno(i).SM3A2 : sCostoVentasAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sCostoVentasAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("PASIVOS") And dstpCopy.MesAno(i).Movimiento Then
                sPasivosM1A1 += dstpCopy.MesAno(i).SM1A1 : sPasivosM2A1 += dstpCopy.MesAno(i).SM2A1 : sPasivosM3A1 += dstpCopy.MesAno(i).SM3A1 : sPasivosM1A2 += dstpCopy.MesAno(i).SM1A2 : sPasivosM2A2 += dstpCopy.MesAno(i).SM2A2 : sPasivosM3A2 += dstpCopy.MesAno(i).SM3A2 : sPasivosAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sPasivosAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("GASTOS") And dstpCopy.MesAno(i).Movimiento Then
                sGastosM1A1 += dstpCopy.MesAno(i).SM1A1 : sGastosM2A1 += dstpCopy.MesAno(i).SM2A1 : sGastosM3A1 += dstpCopy.MesAno(i).SM3A1 : sGastosM1A2 += dstpCopy.MesAno(i).SM1A2 : sGastosM2A2 += dstpCopy.MesAno(i).SM2A2 : sGastosM3A2 += dstpCopy.MesAno(i).SM3A2 : sGastosAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sGastosAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("CAPITAL") And dstpCopy.MesAno(i).Movimiento Then
                sCapitalM1A1 += dstpCopy.MesAno(i).SM1A1 : sCapitalM2A1 += dstpCopy.MesAno(i).SM2A1 : sCapitalM3A1 += dstpCopy.MesAno(i).SM3A1 : sCapitalM1A2 += dstpCopy.MesAno(i).SM1A2 : sCapitalM2A2 += dstpCopy.MesAno(i).SM2A2 : sCapitalM3A2 += dstpCopy.MesAno(i).SM3A2 : sCapitalAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sCapitalAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("INGRESOS") And dstpCopy.MesAno(i).Movimiento Then
                sIngresosM1A1 += dstpCopy.MesAno(i).SM1A1 : sIngresosM2A1 += dstpCopy.MesAno(i).SM2A1 : sIngresosM3A1 += dstpCopy.MesAno(i).SM3A1 : sIngresosM1A2 += dstpCopy.MesAno(i).SM1A2 : sIngresosM2A2 += dstpCopy.MesAno(i).SM2A2 : sIngresosM3A2 += dstpCopy.MesAno(i).SM3A2 : sIngresosAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sIngresosAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2

            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("OTROS GASTOS") And dstpCopy.MesAno(i).Movimiento Then
                sOtrosGastosM1A1 += dstpCopy.MesAno(i).SM1A1 : sOtrosGastosM2A1 += dstpCopy.MesAno(i).SM2A1 : sOtrosGastosM3A1 += dstpCopy.MesAno(i).SM3A1 : sOtrosGastosM1A2 += dstpCopy.MesAno(i).SM1A2 : sOtrosGastosM2A2 += dstpCopy.MesAno(i).SM2A2 : sOtrosGastosM3A2 += dstpCopy.MesAno(i).SM3A2 : sOtrosGastosAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sOtrosGastosAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("OTROS INGRESOS") And dstpCopy.MesAno(i).Movimiento Then
                sOtrosIngresosM1A1 += dstpCopy.MesAno(i).SM1A1 : sOtrosIngresosM2A1 += dstpCopy.MesAno(i).SM2A1 : sOtrosIngresosM3A1 += dstpCopy.MesAno(i).SM3A1 : sOtrosIngresosM1A2 += dstpCopy.MesAno(i).SM1A2 : sOtrosIngresosM2A2 += dstpCopy.MesAno(i).SM2A2 : sOtrosIngresosM3A2 += dstpCopy.MesAno(i).SM3A2 : sOtrosIngresosAcuM1A1 += dstpCopy.MesAno(i).ACUMM1A1 : sOtrosIngresosAcuM1A2 += dstpCopy.MesAno(i).ACUMM1A2
            End If

            If Me.dstpCopy.MesAno(i).Tipo.Equals("ACTIVOS") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "ACTIVOS", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("PASIVOS") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "PASIVOS", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("CAPITAL") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "CAPITAL", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("INGRESOS") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "INGRESOS", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("COSTO VENTA") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "COSTO VENTA", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("GASTOS") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "GASTOS", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("OTROS INGRESOS") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "OTROS INGRESOS", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1
            ElseIf Me.dstpCopy.MesAno(i).Tipo.Equals("OTROS GASTOS") And (dstpCopy.MesAno(i).Nivel = 0 Or dstpCopy.MesAno(i).Nivel = 1) Then
                cargaTemporalDatoAMES(dstpCopy.MesAno(i).CuentaContable.Replace("0", "x"), "Total " & dstpCopy.MesAno(i).Descripcion & ":", dstpCopy.MesAno(i).Nivel, "OTROS GASTOS", -1 * numero, 0, dstpCopy.MesAno(i).SM1A1, dstpCopy.MesAno(i).SM2A1, dstpCopy.MesAno(i).SM3A1, dstpCopy.MesAno(i).SM1A2, dstpCopy.MesAno(i).SM2A2, dstpCopy.MesAno(i).SM3A2, dstpCopy.MesAno(i).ACUMM1A1, dstpCopy.MesAno(i).ACUMM1A2)
                numero += 1

            End If
        Next

        If Not Me.EstadoResultado Then
            'Me.cargaTemporalDatoAMES("CARGA UTILIDAD", "Utilidad antes de impuestos:", 0, "CAPITAL", -1 * numero, 0, (sIngresosM1A1 - sCostoVentasM1A1 - sGastosM1A1), sIngresosM2A1 - sCostoVentasM2A1 - sGastosM2A1, sIngresosM3A1 - sCostoVentasM3A1 - sGastosM3A1, sIngresosM1A2 - sCostoVentasM1A2 - sGastosM1A2, sIngresosM2A2 - sCostoVentasM2A2 - sGastosM2A2, sIngresosM3A2 - sCostoVentasM3A2 - sGastosM3A2, sIngresosAcuM1A1 - sCostoVentasAcuM1A1 - -sGastosAcuM1A1, sIngresosAcuM1A1 - sCostoVentasAcuM1A2 - sGastosM1A2, True)
            Me.cargaTemporalDatoAMES("3-zx" & numero & "CAPITAL", "Total Pasivo y Patrimonio:", 0, "CAPITAL", -1 * numero, 0, sPasivosM1A1 + sCapitalM1A1, sPasivosM2A1 + sCapitalM2A1, sPasivosM3A1 + sCapitalM3A1, sPasivosM1A2 + sCapitalM1A2, sPasivosM2A2 + sCapitalM2A2, sPasivosM3A2 + sCapitalM3A2, sPasivosAcuM1A1 + sCapitalAcuM1A1, sPasivosAcuM1A1 + sCapitalAcuM1A2)
            numero += 1
        Else
            Me.cargaTemporalDatoAMES("5-zx" & numero & "COSTO VENTA", "Utilidad Bruta:", 0, "COSTO VENTA", -1 * numero, 0, sIngresosM1A1 - sCostoVentasM1A1, sIngresosM2A1 - sCostoVentasM2A1, sIngresosM3A1 - sCostoVentasM3A1, sIngresosM1A2 - sCostoVentasM1A2, sIngresosM2A2 - sCostoVentasM2A2, sIngresosM3A2 - sCostoVentasM3A2, sIngresosAcuM1A1 - sCostoVentasAcuM1A1, sIngresosAcuM1A1 - sCostoVentasAcuM1A2)
            numero += 1
            Me.cargaTemporalDatoAMES("6-zx" & numero & "GASTOS", "Utilidad antes de impuestos:", 0, "GASTOS", -1 * numero, 0, (sIngresosM1A1 - sCostoVentasM1A1 - sGastosM1A1), sIngresosM2A1 - sCostoVentasM2A1 - sGastosM2A1, sIngresosM3A1 - sCostoVentasM3A1 - sGastosM3A1, sIngresosM1A2 - sCostoVentasM1A2 - sGastosM1A2, sIngresosM2A2 - sCostoVentasM2A2 - sGastosM2A2, sIngresosM3A2 - sCostoVentasM3A2 - sGastosM3A2, sIngresosAcuM1A1 - sCostoVentasAcuM1A1 - sGastosAcuM1A1, sIngresosAcuM1A2 - sCostoVentasAcuM1A2 - sGastosAcuM1A2)
            numero += 1
        End If
    End Sub

    Sub cargaTemporalDatoAMES(ByVal Cuenta As String, ByVal Descripcion As String, ByVal Nivel As Integer, ByVal Tipo As String, ByVal id As Integer, ByVal ParentID As Integer, ByVal SM1A1 As Double, ByVal SM2A1 As Double, ByVal SM3A1 As Double, ByVal SM1A2 As Double, ByVal SM2A2 As Double, ByVal SM3A2 As Double, ByVal AcumM1A1 As Double, ByVal AcumM1A2 As Double, Optional ByVal CargaUtilidad As Boolean = False)
        If CargaUtilidad Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT     CuentaContable.CuentaContable, CuentaContable.Descripcion FROM         SettingCuentaContable INNER JOIN CuentaContable ON SettingCuentaContable.IdPeriodo = CuentaContable.id", dt)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To Me.dstP.MesAno.Count - 1
                    If dstP.MesAno(i).CuentaContable.Equals(dt.Rows(0).Item("CuentaContable")) Then
                        dstP.MesAno(i).SM1A1 += SM1A1
                        dstP.MesAno(i).SM2A1 += SM2A1
                        dstP.MesAno(i).SM3A1 += SM3A1
                        dstP.MesAno(i).SM1A1 += SM1A2
                        dstP.MesAno(i).SM2A2 += SM2A2
                        dstP.MesAno(i).SM3A2 += SM3A2
                        dstP.MesAno(i).ACUMM1A2 += AcumM1A2
                        dstP.MesAno(i).ACUMM1A1 += AcumM1A1
                    End If
                Next
            End If


            Exit Sub
        End If
        BindingContext(dstpCopy.MesAno).AddNew()
        If Nivel > 0 Then
            BindingContext(dstpCopy.MesAno).Current("CuentaContable") = Cuenta.Replace("-x", "-0")
        Else
            BindingContext(dstpCopy.MesAno).Current("CuentaContable") = Cuenta
        End If

        BindingContext(dstpCopy.MesAno).Current("Descripcion") = Descripcion
        BindingContext(dstpCopy.MesAno).Current("Nivel") = Nivel
        BindingContext(dstpCopy.MesAno).Current("Tipo") = Tipo
        BindingContext(dstpCopy.MesAno).Current("Movimiento") = False
        BindingContext(dstpCopy.MesAno).Current("Id") = id
        BindingContext(dstpCopy.MesAno).Current("PARENTID") = 0
        BindingContext(dstpCopy.MesAno).Current("SM1A1") = SM1A1
        BindingContext(dstpCopy.MesAno).Current("SM2A1") = SM2A1
        BindingContext(dstpCopy.MesAno).Current("SM3A1") = SM3A1
        BindingContext(dstpCopy.MesAno).Current("SM1A2") = SM1A2
        BindingContext(dstpCopy.MesAno).Current("SM2A2") = SM2A2
        BindingContext(dstpCopy.MesAno).Current("SM3A2") = SM3A2
        BindingContext(dstpCopy.MesAno).Current("ACUMM1A1") = AcumM1A1
        BindingContext(dstpCopy.MesAno).Current("ACUMM1A2") = AcumM1A2
        BindingContext(dstpCopy.MesAno).EndCurrentEdit()
    End Sub

    Sub ImpresionBalancesAMES()
        Dim r As New Comparativo_Balance
        Dim v As New frmVisorReportes
        v.rptViewer.ReportSource = r
        Me.dstpCopy = dstP.Copy
        cFunciones.Llenar_Tabla_Generico("Select * From configuraciones", Me.dstpCopy.configuraciones, Configuracion.Claves.Conexion("Hotel"))
        incluirSubtotalesAMES()
        r.SetDataSource(Me.dstpCopy)
        r.SetParameterValue(0, NumericUpDown2.Value)
        If Not Me.EstadoResultado Then
            r.SetParameterValue(1, "Balance Situacion comparativo mes - año")
        Else
            r.SetParameterValue(1, "Estado resultado comparativo mes - año")
        End If

        r.SetParameterValue(2, Format(Me.pM1A1, "MMM-yyyy"))
        r.SetParameterValue(3, Format(Me.pM2A1, "MMM-yyyy"))
        r.SetParameterValue(4, Format(Me.pM3A1, "MMM-yyyy"))
        r.SetParameterValue(5, Format(Me.pM1A2, "MMM-yyyy"))
        r.SetParameterValue(6, Format(Me.pM2A2, "MMM-yyyy"))
        r.SetParameterValue(7, Format(Me.pM3A2, "MMM-yyyy"))
        If Me.TabControl1.SelectedIndex = 1 Then
            r.SetParameterValue(8, "")
        Else
            r.SetParameterValue(8, " Acum." & Format(Me.pM1A1, "MMM-yyyy"))
        End If
        If Me.TabControl1.SelectedIndex = 1 Then
            r.SetParameterValue(9, "")

        Else
            r.SetParameterValue(9, " Acum." & Format(Me.pM1A2, "MMM-yyyy"))

        End If
        v.Show()
    End Sub

    Sub ImpresionBalancesMesXMes()
        Dim r As New ComparativoMesAMes
        Dim v As New frmVisorReportes
        v.rptViewer.ReportSource = r
        Me.dstpCopy = dstP.Copy
        cFunciones.Llenar_Tabla_Generico("Select * From configuraciones", Me.dstpCopy.configuraciones, Configuracion.Claves.Conexion("Hotel"))
        incluirSubtotalesAMES()
        r.SetDataSource(Me.dstpCopy)
        r.SetParameterValue(0, NumericUpDown2.Value)
        If Not Me.EstadoResultado Then
            r.SetParameterValue(1, "Balance Situacion comparativo mes a mes")
        Else
            r.SetParameterValue(1, "Estado resultado comparativo mes a mes")
        End If

        r.SetParameterValue(2, Format(Me.pM1A1, "MMM-yyyy"))
        r.SetParameterValue(3, Format(Me.pM2A1, "MMM-yyyy"))
        r.SetParameterValue(4, Format(Me.pM3A1, "MMM-yyyy"))
        r.SetParameterValue(5, "")
        r.SetParameterValue(6, "")
        r.SetParameterValue(7, "")
        r.SetParameterValue(8, " Acum." & Format(Me.pM1A1, "MMM-yyyy"))
        r.SetParameterValue(9, "")
        v.Show()
        Exit Sub
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Name) 'Carga los privilegios del usuario con el modulo
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()

            Case 1 'If PMU.Print Then Importar() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : ImpresionSeleccion()

            Case 3 : Close()
        End Select
    End Sub

#End Region

    Private Sub Calcular()
        Dim i, n, j, k, h As Integer
        Dim SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual As Double
        Dim Total As String
        Dim SaldoAnterior1, Debitos1, Creditos1, SaldoMes1, SaldoActual1 As Double

        Try
            '-----------------------------------------------------------------------------------------------------------------------------------------
            Dim y As Integer = NumericUpDown2.Maximum
            While y > 0
                Calcular(y - 1)
                y = y - 1
            End While

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Function Calcular(ByVal Nivel As Integer)
        Dim k, j As Integer
        For k = 0 To DtBalanceSituacion1.CuentaContable.Rows.Count - 1
            If DtBalanceSituacion1.CuentaContable.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To DtBalanceSituacion1.CuentaContable.Rows.Count - 1

                    If DtBalanceSituacion1.CuentaContable.Rows(j).Item("Id") = DtBalanceSituacion1.CuentaContable.Rows(k).Item("PARENTID") Then

                        If Tipo = 1 Then

                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("Saldo") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("Saldo") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("Saldo")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoD") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoD") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoD")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP2") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP2") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP2")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP2") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP2") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoDP2")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP3") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP3") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP3")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP3") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP3") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoDP3")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP4") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP4") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP4")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP4") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP4") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoDP4")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP5") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP5") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP5")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP5") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP5") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoDP5")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP6") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP6") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP6")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP6") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoDP6") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoDP6")

                        Else

                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("Saldo") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("Saldo") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("Saldo")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP2") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP2") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP2")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP3") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP3") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP3")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP4") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP4") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP4")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP5") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP5") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP5")
                            DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP6") = DtBalanceSituacion1.CuentaContable.Rows(j).Item("SaldoP6") + DtBalanceSituacion1.CuentaContable.Rows(k).Item("SaldoP6")

                        End If
                    End If
                Next
            End If
        Next
    End Function

    Private Sub RadioButtonMeses_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButtonMeses.CheckedChanged
        If RadioButtonMeses.Checked Then
            NumericUpDown1.Maximum = 6
        Else
            NumericUpDown1.Maximum = 3
        End If
    End Sub

    
End Class

