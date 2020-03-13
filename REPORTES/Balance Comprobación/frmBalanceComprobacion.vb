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


Public Class frmBalanceComprobacion
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim ps As New DevExpress.XtraPrinting.PrintingSystem
    Dim link As New DevExpress.XtraPrinting.PrintableComponentLink(ps)
    Dim usua As Object
    Dim conectadobd As New SqlClient.SqlConnection
    Dim Cconexion As New Conexion
    Dim Reporte_ID As Integer
    Friend WithEvents btnContraerTodas As System.Windows.Forms.Button
    Friend WithEvents btnExpandirTodas As System.Windows.Forms.Button
    Dim Tipo As Integer
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, ByVal tip As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        Tipo = tip
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
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdCuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsBalances1 As Contabilidad.DsBalances
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarExportar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents Link1 As DevExpress.XtraPrinting.Link
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
	Private WithEvents TreeList2 As TreeList
	Friend WithEvents Label7 As System.Windows.Forms.Label
	Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSaldoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditos As System.Windows.Forms.TextBox
    Friend WithEvents txtDebitos As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoMes As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldoActual As System.Windows.Forms.TextBox
    Friend WithEvents AdTemporal2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents smbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Check_Cierre As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBalanceComprobacion))
		Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo8 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo9 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo10 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo11 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Me.TituloModulo = New System.Windows.Forms.Label()
		Me.DsBalances1 = New Contabilidad.DsBalances()
		Me.Panel1 = New System.Windows.Forms.Panel()
		Me.btnContraerTodas = New System.Windows.Forms.Button()
		Me.btnExpandirTodas = New System.Windows.Forms.Button()
		Me.Check_Cierre = New System.Windows.Forms.CheckBox()
		Me.Moneda = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.dtInicial = New System.Windows.Forms.DateTimePicker()
		Me.dtFinal = New System.Windows.Forms.DateTimePicker()
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.AdCuentas = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.AdAsientos = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.AdDetalleAsiento = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand()
		Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
		Me.ToolBar1 = New System.Windows.Forms.ToolBar()
		Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarExportar = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton()
		Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton()
		Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
		Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
		Me.Link1 = New DevExpress.XtraPrinting.Link(Me.components)
		Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
		Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.GridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.GridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.GridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.GridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
		Me.TreeList2 = New DevExpress.XtraTreeList.TreeList()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.txtSaldoAnterior = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCreditos = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtDebitos = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtSaldoMes = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.txtSaldoActual = New System.Windows.Forms.TextBox()
		Me.AdTemporal2 = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection()
		Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label13 = New System.Windows.Forms.Label()
		CType(Me.DsBalances1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Panel1.SuspendLayout()
		CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TituloModulo
		'
		Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(91, Byte), Integer), CType(CType(165, Byte), Integer))
		Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
		Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
		Me.TituloModulo.ForeColor = System.Drawing.Color.White
		Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
		Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
		Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
		Me.TituloModulo.Name = "TituloModulo"
		Me.TituloModulo.Size = New System.Drawing.Size(1020, 32)
		Me.TituloModulo.TabIndex = 0
		Me.TituloModulo.Text = "Balances de Comprobación"
		Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
		'
		'DsBalances1
		'
		Me.DsBalances1.DataSetName = "DsBalances"
		Me.DsBalances1.Locale = New System.Globalization.CultureInfo("es-CR")
		Me.DsBalances1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'Panel1
		'
		Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
		Me.Panel1.Controls.Add(Me.btnContraerTodas)
		Me.Panel1.Controls.Add(Me.btnExpandirTodas)
		Me.Panel1.Controls.Add(Me.Check_Cierre)
		Me.Panel1.Controls.Add(Me.Moneda)
		Me.Panel1.Controls.Add(Me.Label8)
		Me.Panel1.Controls.Add(Me.smbGenerar)
		Me.Panel1.Controls.Add(Me.Label2)
		Me.Panel1.Controls.Add(Me.Label1)
		Me.Panel1.Controls.Add(Me.dtInicial)
		Me.Panel1.Controls.Add(Me.dtFinal)
		Me.Panel1.Location = New System.Drawing.Point(4, 40)
		Me.Panel1.Name = "Panel1"
		Me.Panel1.Size = New System.Drawing.Size(1184, 72)
		Me.Panel1.TabIndex = 0
		'
		'btnContraerTodas
		'
		Me.btnContraerTodas.BackColor = System.Drawing.SystemColors.Control
		Me.btnContraerTodas.Location = New System.Drawing.Point(644, 37)
		Me.btnContraerTodas.Name = "btnContraerTodas"
		Me.btnContraerTodas.Size = New System.Drawing.Size(109, 23)
		Me.btnContraerTodas.TabIndex = 7
		Me.btnContraerTodas.Text = "Contraer Todas"
		Me.btnContraerTodas.UseVisualStyleBackColor = False
		'
		'btnExpandirTodas
		'
		Me.btnExpandirTodas.BackColor = System.Drawing.SystemColors.Control
		Me.btnExpandirTodas.Location = New System.Drawing.Point(529, 37)
		Me.btnExpandirTodas.Name = "btnExpandirTodas"
		Me.btnExpandirTodas.Size = New System.Drawing.Size(109, 23)
		Me.btnExpandirTodas.TabIndex = 6
		Me.btnExpandirTodas.Text = "Expandir Todas"
		Me.btnExpandirTodas.UseVisualStyleBackColor = False
		'
		'Check_Cierre
		'
		Me.Check_Cierre.Enabled = False
		Me.Check_Cierre.Location = New System.Drawing.Point(529, 8)
		Me.Check_Cierre.Name = "Check_Cierre"
		Me.Check_Cierre.Size = New System.Drawing.Size(96, 32)
		Me.Check_Cierre.TabIndex = 4
		Me.Check_Cierre.Text = "Excluir Cierre Anual"
		'
		'Moneda
		'
		Me.Moneda.DataSource = Me.DsBalances1.Moneda
		Me.Moneda.DisplayMember = "MonedaNombre"
		Me.Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.Moneda.Enabled = False
		Me.Moneda.Location = New System.Drawing.Point(300, 35)
		Me.Moneda.Name = "Moneda"
		Me.Moneda.Size = New System.Drawing.Size(121, 21)
		Me.Moneda.TabIndex = 2
		Me.Moneda.ValueMember = "CodMoneda"
		'
		'Label8
		'
		Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Label8.Location = New System.Drawing.Point(297, 8)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(72, 24)
		Me.Label8.TabIndex = 5
		Me.Label8.Text = "Moneda :"
		'
		'smbGenerar
		'
		Me.smbGenerar.Enabled = False
		Me.smbGenerar.Location = New System.Drawing.Point(438, 8)
		Me.smbGenerar.Name = "smbGenerar"
		Me.smbGenerar.Size = New System.Drawing.Size(75, 50)
		Me.smbGenerar.TabIndex = 3
		Me.smbGenerar.Text = "Generar"
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Label2.Location = New System.Drawing.Point(157, 8)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(169, 24)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Fecha Final :"
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
		Me.Label1.Location = New System.Drawing.Point(10, 8)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(96, 24)
		Me.Label1.TabIndex = 2
		Me.Label1.Text = "Fecha Inicial :"
		'
		'dtInicial
		'
		Me.dtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtInicial.Location = New System.Drawing.Point(10, 35)
		Me.dtInicial.Name = "dtInicial"
		Me.dtInicial.Size = New System.Drawing.Size(120, 22)
		Me.dtInicial.TabIndex = 0
		'
		'dtFinal
		'
		Me.dtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtFinal.Location = New System.Drawing.Point(160, 35)
		Me.dtFinal.Name = "dtFinal"
		Me.dtFinal.Size = New System.Drawing.Size(104, 22)
		Me.dtFinal.TabIndex = 1
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" &
	"rsist security info=False;initial catalog=Contabilidad"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'AdCuentas
		'
		Me.AdCuentas.DeleteCommand = Me.SqlDeleteCommand1
		Me.AdCuentas.InsertCommand = Me.SqlInsertCommand1
		Me.AdCuentas.SelectCommand = Me.SqlSelectCommand1
		Me.AdCuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre")})})
		Me.AdCuentas.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
		Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
		Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
		Me.SqlInsertCommand1.Connection = Me.SqlConnection1
		Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"), New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"), New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre")})
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PAR" &
	"ENTID, DescCuentaMadre FROM CuentaContable ORDER BY CuentaContable"
		Me.SqlSelectCommand1.Connection = Me.SqlConnection1
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
		Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
		Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"), New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"), New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"), New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing)})
		'
		'AdAsientos
		'
		Me.AdAsientos.DeleteCommand = Me.SqlDeleteCommand2
		Me.AdAsientos.InsertCommand = Me.SqlInsertCommand2
		Me.AdAsientos.SelectCommand = Me.SqlSelectCommand2
		Me.AdAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc")})})
		Me.AdAsientos.UpdateCommand = Me.SqlUpdateCommand2
		'
		'SqlDeleteCommand2
		'
		Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
		Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
		Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand2
		'
		Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
		Me.SqlInsertCommand2.Connection = Me.SqlConnection1
		Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc")})
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
		Me.SqlSelectCommand2.Connection = Me.SqlConnection1
		'
		'SqlUpdateCommand2
		'
		Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
		Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
		Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
		'
		'AdDetalleAsiento
		'
		Me.AdDetalleAsiento.DeleteCommand = Me.SqlDeleteCommand3
		Me.AdDetalleAsiento.InsertCommand = Me.SqlInsertCommand3
		Me.AdDetalleAsiento.SelectCommand = Me.SqlSelectCommand3
		Me.AdDetalleAsiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
		Me.AdDetalleAsiento.UpdateCommand = Me.SqlUpdateCommand3
		'
		'SqlDeleteCommand3
		'
		Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
		Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
		Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand3
		'
		Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
		Me.SqlInsertCommand3.Connection = Me.SqlConnection1
		Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
		'
		'SqlSelectCommand3
		'
		Me.SqlSelectCommand3.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" &
	"ionAsiento, TipoCambio FROM DetallesAsientosContable ORDER BY Cuenta"
		Me.SqlSelectCommand3.Connection = Me.SqlConnection1
		'
		'SqlUpdateCommand3
		'
		Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
		Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
		Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
		'
		'ImageList
		'
		Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
		Me.ImageList.Images.SetKeyName(0, "")
		Me.ImageList.Images.SetKeyName(1, "")
		Me.ImageList.Images.SetKeyName(2, "")
		Me.ImageList.Images.SetKeyName(3, "")
		Me.ImageList.Images.SetKeyName(4, "")
		Me.ImageList.Images.SetKeyName(5, "")
		Me.ImageList.Images.SetKeyName(6, "")
		Me.ImageList.Images.SetKeyName(7, "")
		Me.ImageList.Images.SetKeyName(8, "")
		Me.ImageList.Images.SetKeyName(9, "")
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
		Me.ToolBar1.Location = New System.Drawing.Point(0, 327)
		Me.ToolBar1.Name = "ToolBar1"
		Me.ToolBar1.ShowToolTips = True
		Me.ToolBar1.Size = New System.Drawing.Size(1020, 52)
		Me.ToolBar1.TabIndex = 1
		'
		'ToolBarNuevo
		'
		Me.ToolBarNuevo.ImageIndex = 0
		Me.ToolBarNuevo.Name = "ToolBarNuevo"
		Me.ToolBarNuevo.Text = "Nuevo"
		'
		'ToolBarExportar
		'
		Me.ToolBarExportar.ImageIndex = 5
		Me.ToolBarExportar.Name = "ToolBarExportar"
		Me.ToolBarExportar.Text = "Exportar"
		'
		'ToolBarImprimir
		'
		Me.ToolBarImprimir.ImageIndex = 7
		Me.ToolBarImprimir.Name = "ToolBarImprimir"
		Me.ToolBarImprimir.Text = "Imprimir"
		'
		'ToolBarCerrar
		'
		Me.ToolBarCerrar.ImageIndex = 6
		Me.ToolBarCerrar.Name = "ToolBarCerrar"
		Me.ToolBarCerrar.Text = "Cerrar"
		'
		'PrintingSystem1
		'
		Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1, Me.Link1})
		'
		'PrintableComponentLink1
		'
		Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
		'
		'Link1
		'
		Me.Link1.PrintingSystem = Me.PrintingSystem1
		'
		'BandedGridView1
		'
		Me.BandedGridView1.Name = "BandedGridView1"
		Me.BandedGridView1.OptionsPrint.PrintDetails = True
		Me.BandedGridView1.OptionsPrint.UsePrintStyles = True
		Me.BandedGridView1.OptionsView.ShowGroupedColumns = False
		'
		'GridColumn1
		'
		Me.GridColumn1.Caption = "Código"
		Me.GridColumn1.FieldName = "Codigo"
		Me.GridColumn1.FilterInfo = ColumnFilterInfo7
		Me.GridColumn1.Name = "GridColumn1"
		Me.GridColumn1.Visible = True
		Me.GridColumn1.Width = 154
		'
		'GridColumn2
		'
		Me.GridColumn2.Caption = "Descripción"
		Me.GridColumn2.FieldName = "Descripcion"
		Me.GridColumn2.FilterInfo = ColumnFilterInfo8
		Me.GridColumn2.Name = "GridColumn2"
		Me.GridColumn2.Visible = True
		Me.GridColumn2.Width = 25
		'
		'GridColumn3
		'
		Me.GridColumn3.Caption = "Saldo Anterior"
		Me.GridColumn3.DisplayFormat.FormatString = "#,##0.00"
		Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn3.FieldName = "SaldoAnterior"
		Me.GridColumn3.FilterInfo = ColumnFilterInfo9
		Me.GridColumn3.Name = "GridColumn3"
		Me.GridColumn3.Visible = True
		Me.GridColumn3.Width = 32
		'
		'GridColumn4
		'
		Me.GridColumn4.Caption = "Débitos"
		Me.GridColumn4.DisplayFormat.FormatString = "#,##0.00"
		Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn4.FieldName = "Debitos"
		Me.GridColumn4.FilterInfo = ColumnFilterInfo10
		Me.GridColumn4.Name = "GridColumn4"
		Me.GridColumn4.Visible = True
		Me.GridColumn4.Width = 38
		'
		'GridColumn5
		'
		Me.GridColumn5.Caption = "Créditos"
		Me.GridColumn5.DisplayFormat.FormatString = "#,##0.00"
		Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn5.FieldName = "Creditos"
		Me.GridColumn5.FilterInfo = ColumnFilterInfo11
		Me.GridColumn5.Name = "GridColumn5"
		Me.GridColumn5.Visible = True
		Me.GridColumn5.Width = 46
		'
		'GridColumn6
		'
		Me.GridColumn6.Caption = "Saldo Mes"
		Me.GridColumn6.DisplayFormat.FormatString = "#,##0.00"
		Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.GridColumn6.FieldName = "SaldoMes"
		Me.GridColumn6.FilterInfo = ColumnFilterInfo12
		Me.GridColumn6.Name = "GridColumn6"
		Me.GridColumn6.Visible = True
		Me.GridColumn6.Width = 56
		'
		'TreeList2
		'
		Me.TreeList2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TreeList2.BehaviorOptions = CType(((((((((DevExpress.XtraTreeList.BehaviorOptionsFlags.MoveOnEdit Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ExpandNodeOnDrag) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ResizeNodes) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoSelectAllInEditor) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoNodeHeight) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoChangeParent) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.CloseEditorOnLostFocus) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.KeepSelectedOnClick) _
			Or DevExpress.XtraTreeList.BehaviorOptionsFlags.SmartMouseHover), DevExpress.XtraTreeList.BehaviorOptionsFlags)
		Me.TreeList2.Location = New System.Drawing.Point(0, 120)
		Me.TreeList2.Name = "TreeList2"
		Me.TreeList2.ParentFieldName = "PARENTID"
		Me.TreeList2.Size = New System.Drawing.Size(1004, 149)
		Me.TreeList2.TabIndex = 2
		Me.TreeList2.Text = "TreeList2"
		'
		'Label7
		'
		Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label7.Location = New System.Drawing.Point(-78, 285)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(104, 16)
		Me.Label7.TabIndex = 149
		Me.Label7.Text = "Saldo Anterior¢"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtSaldoAnterior
		'
		Me.txtSaldoAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtSaldoAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaldoAnterior.Location = New System.Drawing.Point(-78, 301)
		Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
		Me.txtSaldoAnterior.ReadOnly = True
		Me.txtSaldoAnterior.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtSaldoAnterior.Size = New System.Drawing.Size(104, 18)
		Me.txtSaldoAnterior.TabIndex = 150
		'
		'Label3
		'
		Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label3.Location = New System.Drawing.Point(162, 285)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(104, 16)
		Me.Label3.TabIndex = 151
		Me.Label3.Text = "Créditos¢"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtCreditos
		'
		Me.txtCreditos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtCreditos.Location = New System.Drawing.Point(162, 301)
		Me.txtCreditos.Name = "txtCreditos"
		Me.txtCreditos.ReadOnly = True
		Me.txtCreditos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtCreditos.Size = New System.Drawing.Size(104, 18)
		Me.txtCreditos.TabIndex = 152
		'
		'Label4
		'
		Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label4.Location = New System.Drawing.Point(42, 285)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(104, 16)
		Me.Label4.TabIndex = 153
		Me.Label4.Text = "Débitos¢"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtDebitos
		'
		Me.txtDebitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtDebitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtDebitos.Location = New System.Drawing.Point(42, 301)
		Me.txtDebitos.Name = "txtDebitos"
		Me.txtDebitos.ReadOnly = True
		Me.txtDebitos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDebitos.Size = New System.Drawing.Size(104, 18)
		Me.txtDebitos.TabIndex = 154
		'
		'Label5
		'
		Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label5.Location = New System.Drawing.Point(282, 285)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(104, 16)
		Me.Label5.TabIndex = 155
		Me.Label5.Text = "Saldo del Mes¢"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtSaldoMes
		'
		Me.txtSaldoMes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtSaldoMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaldoMes.Location = New System.Drawing.Point(282, 301)
		Me.txtSaldoMes.Name = "txtSaldoMes"
		Me.txtSaldoMes.ReadOnly = True
		Me.txtSaldoMes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtSaldoMes.Size = New System.Drawing.Size(104, 18)
		Me.txtSaldoMes.TabIndex = 156
		'
		'Label6
		'
		Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label6.Location = New System.Drawing.Point(402, 285)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(104, 16)
		Me.Label6.TabIndex = 157
		Me.Label6.Text = "Saldo Actual¢"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'txtSaldoActual
		'
		Me.txtSaldoActual.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.txtSaldoActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtSaldoActual.Location = New System.Drawing.Point(402, 301)
		Me.txtSaldoActual.Name = "txtSaldoActual"
		Me.txtSaldoActual.ReadOnly = True
		Me.txtSaldoActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtSaldoActual.Size = New System.Drawing.Size(104, 18)
		Me.txtSaldoActual.TabIndex = 158
		'
		'AdTemporal2
		'
		Me.AdTemporal2.DeleteCommand = Me.SqlDeleteCommand4
		Me.AdTemporal2.InsertCommand = Me.SqlInsertCommand4
		Me.AdTemporal2.SelectCommand = Me.SqlSelectCommand4
		Me.AdTemporal2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Temporal2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("SaldoAnterior", "SaldoAnterior"), New System.Data.Common.DataColumnMapping("Debitos", "Debitos"), New System.Data.Common.DataColumnMapping("Creditos", "Creditos"), New System.Data.Common.DataColumnMapping("SaldoMes", "SaldoMes"), New System.Data.Common.DataColumnMapping("SaldoActual", "SaldoActual"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("SaldoAnteriorD", "SaldoAnteriorD"), New System.Data.Common.DataColumnMapping("DebitosD", "DebitosD"), New System.Data.Common.DataColumnMapping("CreditosD", "CreditosD"), New System.Data.Common.DataColumnMapping("SaldoMesD", "SaldoMesD"), New System.Data.Common.DataColumnMapping("SaldoActualD", "SaldoActualD")})})
		Me.AdTemporal2.UpdateCommand = Me.SqlUpdateCommand4
		'
		'SqlDeleteCommand4
		'
		Me.SqlDeleteCommand4.CommandText = resources.GetString("SqlDeleteCommand4.CommandText")
		Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
		Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CreditosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreditosD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DebitosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DebitosD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoActualD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActualD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnteriorD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnteriorD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoMesD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMesD", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand4
		'
		Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
		Me.SqlInsertCommand4.Connection = Me.SqlConnection1
		Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"), New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"), New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"), New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"), New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"), New System.Data.SqlClient.SqlParameter("@SaldoAnteriorD", System.Data.SqlDbType.Float, 8, "SaldoAnteriorD"), New System.Data.SqlClient.SqlParameter("@DebitosD", System.Data.SqlDbType.Float, 8, "DebitosD"), New System.Data.SqlClient.SqlParameter("@CreditosD", System.Data.SqlDbType.Float, 8, "CreditosD"), New System.Data.SqlClient.SqlParameter("@SaldoMesD", System.Data.SqlDbType.Float, 8, "SaldoMesD"), New System.Data.SqlClient.SqlParameter("@SaldoActualD", System.Data.SqlDbType.Float, 8, "SaldoActualD")})
		'
		'SqlSelectCommand4
		'
		Me.SqlSelectCommand4.CommandText = resources.GetString("SqlSelectCommand4.CommandText")
		Me.SqlSelectCommand4.Connection = Me.SqlConnection1
		'
		'SqlUpdateCommand4
		'
		Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
		Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
		Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"), New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"), New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"), New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"), New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"), New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"), New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"), New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"), New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"), New System.Data.SqlClient.SqlParameter("@SaldoAnteriorD", System.Data.SqlDbType.Float, 8, "SaldoAnteriorD"), New System.Data.SqlClient.SqlParameter("@DebitosD", System.Data.SqlDbType.Float, 8, "DebitosD"), New System.Data.SqlClient.SqlParameter("@CreditosD", System.Data.SqlDbType.Float, 8, "CreditosD"), New System.Data.SqlClient.SqlParameter("@SaldoMesD", System.Data.SqlDbType.Float, 8, "SaldoMesD"), New System.Data.SqlClient.SqlParameter("@SaldoActualD", System.Data.SqlDbType.Float, 8, "SaldoActualD"), New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CreditosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreditosD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DebitosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DebitosD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoActualD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActualD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoAnteriorD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnteriorD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SaldoMesD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMesD", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlConnection2
		'
		Me.SqlConnection2.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" &
	"rsist security info=False;initial catalog=Contabilidad"
		Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
		'
		'AdapterMoneda
		'
		Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand5
		Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand5
		Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
		'
		'SqlInsertCommand5
		'
		Me.SqlInsertCommand5.CommandText = "INSERT INTO Moneda(MonedaNombre, ValorVenta, CodMoneda, Simbolo) VALUES (@MonedaN" &
	"ombre, @ValorVenta, @CodMoneda, @Simbolo); SELECT MonedaNombre, ValorVenta, CodM" &
	"oneda, Simbolo FROM Moneda"
		Me.SqlInsertCommand5.Connection = Me.SqlConnection1
		Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo")})
		'
		'SqlSelectCommand5
		'
		Me.SqlSelectCommand5.CommandText = "SELECT MonedaNombre, ValorVenta, CodMoneda, Simbolo FROM Moneda"
		Me.SqlSelectCommand5.Connection = Me.SqlConnection1
		'
		'Label9
		'
		Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label9.Location = New System.Drawing.Point(1002, 285)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(104, 16)
		Me.Label9.TabIndex = 167
		Me.Label9.Text = "Saldo Actual$"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'TextBox1
		'
		Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox1.Location = New System.Drawing.Point(514, 301)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ReadOnly = True
		Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TextBox1.Size = New System.Drawing.Size(104, 18)
		Me.TextBox1.TabIndex = 168
		'
		'TextBox2
		'
		Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox2.Location = New System.Drawing.Point(634, 301)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.ReadOnly = True
		Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TextBox2.Size = New System.Drawing.Size(104, 18)
		Me.TextBox2.TabIndex = 166
		'
		'TextBox3
		'
		Me.TextBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox3.Location = New System.Drawing.Point(754, 301)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.ReadOnly = True
		Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TextBox3.Size = New System.Drawing.Size(104, 18)
		Me.TextBox3.TabIndex = 164
		'
		'TextBox4
		'
		Me.TextBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox4.Location = New System.Drawing.Point(874, 301)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.ReadOnly = True
		Me.TextBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TextBox4.Size = New System.Drawing.Size(104, 18)
		Me.TextBox4.TabIndex = 162
		'
		'TextBox5
		'
		Me.TextBox5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.TextBox5.Location = New System.Drawing.Point(1002, 301)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.ReadOnly = True
		Me.TextBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.TextBox5.Size = New System.Drawing.Size(104, 18)
		Me.TextBox5.TabIndex = 160
		'
		'Label10
		'
		Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label10.Location = New System.Drawing.Point(874, 285)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(104, 16)
		Me.Label10.TabIndex = 165
		Me.Label10.Text = "Saldo del Mes$"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label11
		'
		Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label11.Location = New System.Drawing.Point(634, 285)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(104, 16)
		Me.Label11.TabIndex = 163
		Me.Label11.Text = "Débitos$"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label12
		'
		Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label12.Location = New System.Drawing.Point(754, 285)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(104, 16)
		Me.Label12.TabIndex = 161
		Me.Label12.Text = "Créditos$"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label13
		'
		Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
		Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label13.Location = New System.Drawing.Point(514, 285)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(104, 16)
		Me.Label13.TabIndex = 159
		Me.Label13.Text = "Saldo Anterior$"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'frmBalanceComprobacion
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
		Me.ClientSize = New System.Drawing.Size(1020, 379)
		Me.Controls.Add(Me.Label9)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.txtSaldoActual)
		Me.Controls.Add(Me.txtSaldoMes)
		Me.Controls.Add(Me.txtDebitos)
		Me.Controls.Add(Me.txtCreditos)
		Me.Controls.Add(Me.txtSaldoAnterior)
		Me.Controls.Add(Me.Label10)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.Label12)
		Me.Controls.Add(Me.Label13)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.TreeList2)
		Me.Controls.Add(Me.ToolBar1)
		Me.Controls.Add(Me.Panel1)
		Me.Controls.Add(Me.TituloModulo)
		Me.Name = "frmBalanceComprobacion"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Balances de Comprobación"
		CType(Me.DsBalances1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Panel1.ResumeLayout(False)
		CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

#Region "Load"
	Private Sub frmBalanceComprobacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            conectadobd = Cconexion.Conectar("Contabilidad")
            Estado(False)
            InitData()
            AdapterMoneda.Fill(DsBalances1, "Moneda")
			If Tipo = 1 Then
				Me.Moneda.Visible = False
				Me.Label8.Visible = False
			End If
			WindowState = FormWindowState.Maximized
		Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub InitData()
        If Tipo = 1 Then
            CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Saldo Anterior ¢", "SaldoAnterior", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Débitos ¢", "Debitos", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Créditos ¢", "Creditos", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Saldo Mes ¢", "SaldoMes", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Saldo Actual ¢", "SaldoActual", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")

            CreateColumn(TreeList2, "Saldo Anterior $", "SaldoAnteriorD", 7, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Débitos $", "DebitosD", 8, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Créditos $", "CreditosD", 9, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Saldo Mes $", "SaldoMesD", 10, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Saldo Actual $", "SaldoActualD", 11, DevExpress.Utils.FormatType.Numeric, "#,##0.00")

            CreateColumn(TreeList2, "Nivel", "Nivel", -1, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        Else
            CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList2, "Saldo Anterior", "SaldoAnterior", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Débitos", "Debitos", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Créditos", "Creditos", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Saldo Mes", "SaldoMes", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList2, "Saldo Actual", "SaldoActual", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")

            CreateColumn(TreeList2, "Nivel", "Nivel", -1, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        End If

        TreeList2.BestFitColumns()
    End Sub


    Private Sub CreateColumn(ByVal tl As TreeList, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
        Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = tl.Columns.Add()
        col.Caption = caption
        col.FieldName = field
        col.VisibleIndex = visibleindex
        col.Format.FormatType = formatType
        If formatType = DevExpress.Utils.FormatType.Custom Then
            col.Format.Format = New BaseFormatter
        End If
        col.Format.FormatString = formatString
    End Sub
#End Region

#Region "Controles"
    Private Sub LLenarCeros()
        Dim n As Integer
        For n = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
            If Tipo = 1 Then
                DsBalances1.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
                DsBalances1.CuentaContable.Rows(n).Item("Debitos") = 0
                DsBalances1.CuentaContable.Rows(n).Item("Creditos") = 0
                DsBalances1.CuentaContable.Rows(n).Item("SaldoMes") = 0
                DsBalances1.CuentaContable.Rows(n).Item("SaldoActual") = 0

                DsBalances1.CuentaContable.Rows(n).Item("SaldoAnteriorD") = 0
                DsBalances1.CuentaContable.Rows(n).Item("DebitosD") = 0
                DsBalances1.CuentaContable.Rows(n).Item("CreditosD") = 0
                DsBalances1.CuentaContable.Rows(n).Item("SaldoMesD") = 0
                DsBalances1.CuentaContable.Rows(n).Item("SaldoActualD") = 0
            Else
                DsBalances1.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
                DsBalances1.CuentaContable.Rows(n).Item("Debitos") = 0
                DsBalances1.CuentaContable.Rows(n).Item("Creditos") = 0
                DsBalances1.CuentaContable.Rows(n).Item("SaldoMes") = 0
                DsBalances1.CuentaContable.Rows(n).Item("SaldoActual") = 0
            End If

        Next
    End Sub


    Function Estado(ByVal valor As Boolean)
        Me.dtFinal.Enabled = valor
        Me.dtInicial.Enabled = valor
        smbGenerar.Enabled = valor
        Check_Cierre.Enabled = valor

    End Function


    Private Sub dtInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtFinal.Focus()
        End If
    End Sub


    Private Sub dtFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Moneda.Focus()
        End If
    End Sub


    Private Sub Moneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Moneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            smbGenerar.Focus()
        End If
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()

            Case 1 : If PMU.Print Then Importar() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Generar Balance"
    Private Sub GeneraBalance()
        Try
            Dim Fecha1, Fecha2 As Date
            Fecha1 = Format(dtInicial.Value.Date, "dd/MM/yyyy H:mm:ss")
            Fecha2 = Format(dtFinal.Value.Date, "dd/MM/yyyy H:mm:ss")
            If Fecha1 > Fecha2 Then
                MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.DsBalances1.Temporal2.Clear()
            Me.DsBalances1.CuentaContable.Clear()
            Me.DsBalances1.Usuarios.Clear()
            Me.DsBalances1.DetallesAsientosContable.Clear()
            Me.DsBalances1.AsientosContables.Clear()
            AdCuentas.Fill(Me.DsBalances1.CuentaContable)
            'Me.AdDetalleAsiento.Fill(Me.DsBalances1.DetallesAsientosContable) 'Llenar solo lo del mes del período de trabajo
            TreeList2.Columns(1).Width = 300
            LLenarCeros()
            CargarAsientos(Fecha1)
            CargarDebitos(Fecha1, Fecha2)
            Calcular_Saldos()
            Calcular()

            TreeList2.DataSource = DsBalances1
            TreeList2.DataMember = "CuentaContable"
            Me.dtFinal.Enabled = False
            Me.dtInicial.Enabled = False
            Check_Cierre.Enabled = False
            If Configuracion.Claves.Configuracion("ExpandirTodas").Equals("1") Then
                TreeList2.FullExpand()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        Try
            Nuevo()
            Dim Fecha1, Fecha2 As Date
            Fecha1 = Format(dtInicial.Value.Date, "dd/MM/yyyy H:mm:ss")
            Fecha2 = Format(dtFinal.Value.Date, "dd/MM/yyyy H:mm:ss")
            If Fecha1 > Fecha2 Then
                MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.DsBalances1.Temporal2.Clear()
            Me.DsBalances1.CuentaContable.Clear()
            Me.DsBalances1.Usuarios.Clear()
            Me.DsBalances1.DetallesAsientosContable.Clear()
            Me.DsBalances1.AsientosContables.Clear()
            AdCuentas.Fill(Me.DsBalances1.CuentaContable)
            'Me.AdDetalleAsiento.Fill(Me.DsBalances1.DetallesAsientosContable) 'Llenar solo lo del mes del período de trabajo
            TreeList2.Columns(1).Width = 300
            LLenarCeros()
            CargarAsientos(Fecha1)
            CargarDebitos(Fecha1, Fecha2)
            Calcular_Saldos()
            Calcular()

            TreeList2.DataSource = DsBalances1
            TreeList2.DataMember = "CuentaContable"
            Me.dtFinal.Enabled = False
            Me.dtInicial.Enabled = False
            Check_Cierre.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Cargar Asientos"
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
            If Check_Cierre.Checked = False Then
                sel = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
                            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
                            " FROM         dbo.AsientoDC_DH INNER JOIN " & _
                            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
                            " WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) " & _
                            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
            Else
                sel = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
                                            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
                                            " FROM         dbo.AsientoDC_DH INNER JOIN " & _
                                            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
                                            " WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) AND (AsientoDC_DH.NumAsiento <> '" & CierreAnual() & "'" & _
                                            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
                ' Si hay que excluir el asiento cierre anual

            End If


            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(dtInicial.Value)
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
                For i = 0 To Me.DsBalances1.AsientoDC_DH_AG.Rows.Count - 1
                    If Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.Equals(Me.DsBalances1.CuentaContable(x).CuentaContable) Then
                        If Tipo = 1 Then
                            Debe += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                            Haber += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon
                            DebeD += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                            HaberD += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar
                        Else
                            If Moneda.SelectedValue = 1 Then
                                Debe += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                                Haber += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon

                            Else
                                Debe += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                                Haber += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar
                            End If

                        End If
                    End If
                Next

                If Tipo = 1 Then
                    If DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        DsBalances1.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                        DsBalances1.CuentaContable.Rows(x).Item("SaldoAnteriorD") = DebeD - HaberD
                    Else
                        DsBalances1.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                        DsBalances1.CuentaContable.Rows(x).Item("SaldoAnteriorD") = HaberD - DebeD
                    End If
                Else
                    If DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        DsBalances1.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                    Else
                        DsBalances1.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
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

            For x = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1

                For i = 0 To Me.DsBalances1.AsientoDC_DH_AG.Rows.Count - 1
                    Dim cuent As String = Me.DsBalances1.AsientoDC_DH_AG(i).Cuenta.TrimEnd(" ")
                    If cuent.Equals(Me.DsBalances1.CuentaContable(x).CuentaContable) Then
                        If Me.Tipo = 1 Then
                            DsBalances1.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                            DsBalances1.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon
                            DsBalances1.CuentaContable.Rows(x).Item("DebitosD") += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                            DsBalances1.CuentaContable.Rows(x).Item("CreditosD") += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar

                        Else
                            If Moneda.SelectedValue = 1 Then
                                DsBalances1.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances1.AsientoDC_DH_AG(i).Dcolon
                                DsBalances1.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances1.AsientoDC_DH_AG(i).Hcolon
                            Else
                                DsBalances1.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances1.AsientoDC_DH_AG(i).Ddolar
                                DsBalances1.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances1.AsientoDC_DH_AG(i).Hdolar

                            End If

                        End If

                    End If

                Next
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function


    Function CierreAnual() As String
        Try
            Dim cConexion As New Conexion       'BUSCA NUMERO DE ASIENTO DEL ULTIMO CIERRE ANUAL
            CierreAnual = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT NumAsiento FROM dbo.AsientosContables WHERE TipoDoc = 30 AND Anulado = 0 AND Mayorizado = 1 AND Fecha <= dbo.DateOnlyFinal('" & Format(dtFinal.Value, "dd/MM/yyyy H:mm:ss") & "') ORDER BY Fecha DESC")
            cConexion.DesConectar(cConexion.sQlconexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        End Try
    End Function
#End Region

#Region "Calculos"
    Private Sub Calcular()
        Dim i, n, j, k, h As Integer
        Dim SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual As Double
        Dim Total As String
        Dim SaldoAnterior1, Debitos1, Creditos1, SaldoMes1, SaldoActual1 As Double

        Try
            '-----------------------------------------------------------------------------------------------------------------------------------------
            Calcular(6)
            Calcular(5)
            Calcular(4)
            Calcular(3)
            Calcular(2)
            Calcular(1)

            For k = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                If Tipo = 0 Then
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
                Else
                    If Me.DsBalances1.CuentaContable.Rows(k).Item("Nivel") = 0 Then
                        If DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                            SaldoAnterior = SaldoAnterior + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            SaldoAnterior1 = SaldoAnterior1 + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnteriorD")
                            SaldoMes = SaldoMes + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                            SaldoMes1 = SaldoMes1 + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMesD")
                            SaldoActual = SaldoActual + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")
                            SaldoActual1 = SaldoActual1 + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActualD")

                        Else
                            SaldoAnterior = SaldoAnterior - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            SaldoMes = SaldoMes - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                            SaldoActual = SaldoActual - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")
                            SaldoAnterior1 = SaldoAnterior1 - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnteriorD")
                            SaldoMes1 = SaldoMes1 - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMesD")
                            SaldoActual1 = SaldoActual1 - Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActualD")
                        End If
                        Debitos = Debitos + Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                        Creditos = Creditos + Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                        Debitos1 = Debitos1 + Me.DsBalances1.CuentaContable.Rows(k).Item("DebitosD")
                        Creditos1 = Creditos1 + Me.DsBalances1.CuentaContable.Rows(k).Item("CreditosD")
                    End If
                End If
            Next

            Me.txtSaldoAnterior.Text = Format(SaldoAnterior, "#,#0.00")
            Me.txtDebitos.Text = Format(Debitos, "#,#0.00")
            Me.txtCreditos.Text = Format(Creditos, "#,#0.00")
            Me.txtSaldoMes.Text = Format(SaldoMes, "#,#0.00")
            Me.txtSaldoActual.Text = Format(SaldoActual, "#,#0.00")
            If Tipo = 1 Then
                Me.TextBox1.Text = Format(SaldoAnterior1, "#,#0.00")
                Me.TextBox2.Text = Format(Debitos1, "#,#0.00")
                Me.TextBox3.Text = Format(Creditos1, "#,#0.00")
                Me.TextBox4.Text = Format(SaldoMes1, "#,#0.00")
                Me.TextBox5.Text = Format(SaldoActual1, "#,#0.00")
            End If


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
                        If Me.Tipo = 1 Then
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalances1.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalances1.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMes") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActual") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")

                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnteriorD") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnteriorD") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnteriorD")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("DebitosD") = Me.DsBalances1.CuentaContable.Rows(j).Item("DebitosD") + Me.DsBalances1.CuentaContable.Rows(k).Item("DebitosD")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("CreditosD") = Me.DsBalances1.CuentaContable.Rows(j).Item("CreditosD") + Me.DsBalances1.CuentaContable.Rows(k).Item("CreditosD")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMesD") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMesD") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMesD")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActualD") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActualD") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActualD")
                        Else

                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalances1.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalances1.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoMes") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(j).Item("SaldoActual") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual")

                        End If
                    End If
                Next
            End If
        Next
    End Function


    Private Sub Calcular_Saldos()
        Dim k As Integer
        Try
            For k = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                If Tipo = 1 Then
                    If DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos") - Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMesD") = Me.DsBalances1.CuentaContable.Rows(k).Item("DebitosD") - Me.DsBalances1.CuentaContable.Rows(k).Item("CreditosD")

                    Else
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos") - Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMesD") = Me.DsBalances1.CuentaContable.Rows(k).Item("CreditosD") - Me.DsBalances1.CuentaContable.Rows(k).Item("DebitosD")

                    End If

                    Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")
                    Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActualD") = Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnteriorD") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMesD")


                Else
                    If DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances1.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos") - Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos")
                    Else
                        Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(k).Item("Creditos") - Me.DsBalances1.CuentaContable.Rows(k).Item("Debitos")
                    End If

                    Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.DsBalances1.CuentaContable.Rows(k).Item("SaldoMes")

                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Importar"
    Private Sub Importar()
        Try
            Cconexion.DeleteRecords("Temporal", "")
            cargar()
            DataTableToExcel(Me.DsBalances1.Temporal2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DataTableToExcel(ByVal pDataTable As DataTable)
        Try

            Dim vFileName As String = Path.GetTempFileName()

            FileOpen(1, vFileName, OpenMode.Output)

            Dim sb As String
            Dim dc As DataColumn
            For Each dc In pDataTable.Columns
                sb &= dc.Caption & Microsoft.VisualBasic.ControlChars.Tab
            Next
            PrintLine(1, sb)

            Dim i As Integer = 0
            Dim dr As DataRow
            For Each dr In pDataTable.Rows
                i = 0 : sb = ""
                For Each dc In pDataTable.Columns
                    If Not IsDBNull(dr(i)) Then
                        sb &= CStr(dr(i)) & Microsoft.VisualBasic.ControlChars.Tab
                    Else
                        sb &= Microsoft.VisualBasic.ControlChars.Tab
                    End If
                    i += 1
                Next
                PrintLine(1, sb)

            Next
            FileClose(1)
            TextToExcel(vFileName)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub TextToExcel(ByVal pFileName As String)
        Try
            Dim vFormato As Excel.XlRangeAutoFormat

            Dim vCultura As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

            Dim Exc As Excel.Application = New Excel.Application
            Exc.Workbooks.OpenText(pFileName, , , , Excel.XlTextQualifier.xlTextQualifierNone, , True)

            Dim Wb As Excel.Workbook = Exc.ActiveWorkbook
            Dim Ws As Excel.Worksheet = Wb.ActiveSheet

            'Se le indica el formato al que queremos exportarlo
            Dim valor As Integer = 1
            If valor > -1 Then
                Select Case valor
                    Case 0 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatNone
                    Case 1 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatSimple
                    Case 2 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1
                    Case 3 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2
                    Case 4 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic3
                    Case 5 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting1
                    Case 6 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting2
                    Case 7 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting3
                    Case 8 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting4
                    Case 9 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor1
                    Case 10 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor2
                    Case 11 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor3
                    Case 12 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList1
                    Case 13 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList2
                    Case 14 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList3
                    Case 15 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects1
                    Case 16 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects2
                End Select

                Ws.Range(Ws.Cells(1, 1), Ws.Cells(Ws.UsedRange.Rows.Count, Ws.UsedRange.Columns.Count)).AutoFormat(vFormato)
                pFileName = Path.GetTempFileName.Replace("tmp", "xls")
                File.Delete(pFileName)
                Exc.ActiveWorkbook.SaveAs(pFileName, Excel.XlTextQualifier.xlTextQualifierNone - 1)
            End If

            Exc.Quit()
            Ws = Nothing
            Wb = Nothing
            Exc = Nothing
            GC.Collect()

            If valor > -1 Then
                Dim p As System.Diagnostics.Process = New System.Diagnostics.Process
                p.EnableRaisingEvents = False
                p.Start("Excel.exe", pFileName)
            End If
            System.Threading.Thread.CurrentThread.CurrentCulture = vCultura

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function cargar()
        Dim i As Integer
        Dim trans As SqlTransaction
        Try
            DsBalances1.Temporal2.Clear()

            For i = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                If Tipo = 1 Then
                    If Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("DebitosD") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("CreditosD") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnteriorD") <> 0 Then
                        Me.BindingContext(Me.DsBalances1.Temporal2).AddNew()
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CuentaContable") = Me.DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Descripcion") = Me.DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Debitos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Creditos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoMes")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoActual")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Nivel") = Me.DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Movimiento") = Me.DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Id") = Me.DsBalances1.CuentaContable.Rows(i).Item("Id")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("PARENTID") = Me.DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnteriorD") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnteriorD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("DebitosD") = Me.DsBalances1.CuentaContable.Rows(i).Item("DebitosD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CreditosD") = Me.DsBalances1.CuentaContable.Rows(i).Item("CreditosD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMesD") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoMesD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActualD") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoActualD")

                        Me.BindingContext(Me.DsBalances1.Temporal2).EndCurrentEdit()
                    End If
                Else
                    If Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior") <> 0 Then
                        Me.BindingContext(Me.DsBalances1.Temporal2).AddNew()
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CuentaContable") = Me.DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Descripcion") = Me.DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Debitos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Creditos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoMes")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoActual")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Nivel") = Me.DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Movimiento") = Me.DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Id") = Me.DsBalances1.CuentaContable.Rows(i).Item("Id")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("PARENTID") = Me.DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnteriorD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("DebitosD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CreditosD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMesD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActualD") = 0

                        Me.BindingContext(Me.DsBalances1.Temporal2).EndCurrentEdit()
                    End If
                End If

            Next

            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            trans = Me.SqlConnection1.BeginTransaction
            Me.AdTemporal2.InsertCommand.Transaction = trans
            Me.AdTemporal2.UpdateCommand.Transaction = trans
            Me.AdTemporal2.DeleteCommand.Transaction = trans
            Me.AdTemporal2.Update(Me.DsBalances1, "Temporal2")
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            Me.SqlConnection1.Close()
        End Try
    End Function
#End Region

#Region "Nuevo"
    Private Sub Nuevo()
        Try
            If Me.ToolBarNuevo.Text = "Nuevo" Then
                Me.ToolBarNuevo.ImageIndex = "3"
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.TreeList2.DataSource = ""
                Me.TreeList2.DataMember = ""
                Estado(True)
                dtInicial.Focus()
            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.TreeList2.DataSource = ""
                Me.TreeList2.DataMember = ""
                Estado(False)
            End If

            Me.dtFinal.Enabled = True
            Me.dtInicial.Enabled = True
            Me.Moneda.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim Fecha1, Fecha2 As Date
        Fecha1 = Format(dtInicial.Value.Date, "dd/MM/yyyy H:mm:ss")
        Fecha2 = Format(Me.dtFinal.Value.Date, "dd/MM/yyyy H:mm:ss")
        If Fecha1 > Fecha2 Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            Cconexion.DeleteRecords("Temporal2", "")
            Dim nivel As New Nivel
            cargar()
            nivel.reporte = "Balance de Comprobación"
            nivel.Analitico = True
            nivel.saldoant = Me.txtSaldoAnterior.Text
            nivel.saldomes = Me.txtSaldoMes.Text
            nivel.saldoactual = Me.txtSaldoActual.Text
            nivel.debitos = Me.txtDebitos.Text
            nivel.creditos = Me.txtCreditos.Text
            nivel.saldoant1 = Me.TextBox1.Text
            nivel.saldomes1 = Me.TextBox4.Text
            nivel.saldoactual1 = Me.TextBox5.Text
            nivel.debitos1 = Me.TextBox2.Text
            nivel.creditos1 = Me.TextBox3.Text
            nivel.dtInicial.Text = Me.dtInicial.Text
            nivel.dtFinal.Text = Me.dtFinal.Text
            nivel.moneda = DsBalances1.Moneda(Moneda.SelectedIndex).MonedaNombre
            nivel.simbolo = DsBalances1.Moneda(Moneda.SelectedIndex).Simbolo
            nivel.CodMoneda = DsBalances1.Moneda(Moneda.SelectedIndex).CodMoneda
            nivel.Tipo = Me.Tipo
            nivel.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Analitico Detallado"
    Private Sub TreeList2_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList2.FocusedNodeChanged
        If e.Node.Id = Nothing Then
        Else
            Reporte_ID = e.Node.Id
        End If
        If e.Node.Id = 0 Then
            Reporte_ID = e.Node.Id
        End If
    End Sub

    Private WithEvents frm As New frmAnaliticoDetallado

    Private Sub frm_Refresca() Handles frm.Actualiza
        Cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.ReporteAnaliticoDetallado '" & DsBalances1.CuentaContable(Reporte_ID).CuentaContable & "'," & (DsBalances1.CuentaContable(Reporte_ID).Nivel + 1) & ",'" & Me.dtInicial.Value.Date & "','" & Me.dtFinal.Value.Date & "'," & DsBalances1.Moneda(Moneda.SelectedIndex).CodMoneda & "," & Check_Cierre.Checked)
    End Sub

    Private Sub TreeList2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList2.DoubleClick
        If DsBalances1.CuentaContable(Reporte_ID).Movimiento = False Then Exit Sub
        Try
			'Se ejecuta el procedimiento y llena la tabla TemporalAnaliticoDetallado 
			frm = New frmAnaliticoDetallado
			BanderaGeneral.ACTUALIZO_ASIENTO = False
			Cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.ReporteAnaliticoDetallado '" & DsBalances1.CuentaContable(Reporte_ID).CuentaContable & "'," & (DsBalances1.CuentaContable(Reporte_ID).Nivel + 1) & ",'" & Me.dtInicial.Value.Date & "','" & Me.dtFinal.Value.Date & "'," & DsBalances1.Moneda(Moneda.SelectedIndex).CodMoneda & ",'" & Check_Cierre.Checked & "'")
			frm.NombreMoneda = DsBalances1.Moneda(Moneda.SelectedIndex).MonedaNombre
            frm.SaldoMes = DsBalances1.CuentaContable(Reporte_ID).SaldoMes
            frm.SaldoAnterior = DsBalances1.CuentaContable(Reporte_ID).SaldoAnterior
            frm.CuentaContable = DsBalances1.CuentaContable(Reporte_ID).CuentaContable
            frm.NombreCuenta = DsBalances1.CuentaContable(Reporte_ID).Descripcion
            frm.usua = Me.usua
            frm.ShowDialog()
            If BanderaGeneral.ACTUALIZO_ASIENTO = True Then
                Me.GeneraBalance()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
#End Region


    Private Sub btnExpandirTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExpandirTodas.Click
        TreeList2.FullExpand()

    End Sub

    Private Sub btnContraerTodas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContraerTodas.Click
        TreeList2.FullCollapse()

    End Sub
End Class
