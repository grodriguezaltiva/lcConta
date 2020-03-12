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


Public Class frmBalanceCentroCosto
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim ps As New DevExpress.XtraPrinting.PrintingSystem
    Dim link As New DevExpress.XtraPrinting.PrintableComponentLink(ps)
    Dim usua As Object
    Dim conectadobd As New SqlClient.SqlConnection
    Dim Cconexion As New Conexion
    Dim Reporte_ID As Integer
#End Region

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
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdCuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
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
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
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
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Moneda As System.Windows.Forms.ComboBox
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents AdapterCentroCosto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsBalanceCentro As Contabilidad.DsBalaceCentro
    Friend WithEvents CBCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterMovimientoCentro As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBalanceCentroCosto))
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CBCentroCosto = New System.Windows.Forms.ComboBox
        Me.DsBalanceCentro = New Contabilidad.DsBalaceCentro
        Me.Label9 = New System.Windows.Forms.Label
        Me.Moneda = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtInicial = New System.Windows.Forms.DateTimePicker
        Me.dtFinal = New System.Windows.Forms.DateTimePicker
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdCuentas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExportar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.Link1 = New DevExpress.XtraPrinting.Link(Me.components)
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSaldoAnterior = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCreditos = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDebitos = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSaldoMes = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSaldoActual = New System.Windows.Forms.TextBox
        Me.AdTemporal2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCentroCosto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.AdapterMovimientoCentro = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Panel1.SuspendLayout()
        CType(Me.DsBalanceCentro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TituloModulo.Size = New System.Drawing.Size(1048, 32)
        Me.TituloModulo.TabIndex = 60
        Me.TituloModulo.Text = "Centro de Costo"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.CBCentroCosto)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Moneda)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.smbGenerar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtInicial)
        Me.Panel1.Controls.Add(Me.dtFinal)
        Me.Panel1.Location = New System.Drawing.Point(88, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(880, 56)
        Me.Panel1.TabIndex = 62
        '
        'CBCentroCosto
        '
        Me.CBCentroCosto.DataSource = Me.DsBalanceCentro.CentroCosto
        Me.CBCentroCosto.DisplayMember = "Nombre"
        Me.CBCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCentroCosto.Enabled = False
        Me.CBCentroCosto.Location = New System.Drawing.Point(392, 24)
        Me.CBCentroCosto.Name = "CBCentroCosto"
        Me.CBCentroCosto.Size = New System.Drawing.Size(192, 21)
        Me.CBCentroCosto.TabIndex = 8
        Me.CBCentroCosto.ValueMember = "Id"
        '
        'DsBalanceCentro
        '
        Me.DsBalanceCentro.DataSetName = "DsBalaceCentro"
        Me.DsBalanceCentro.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(432, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(124, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Centro de Costo :"
        '
        'Moneda
        '
        Me.Moneda.DataSource = Me.DsBalanceCentro.Moneda
        Me.Moneda.DisplayMember = "MonedaNombre"
        Me.Moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Moneda.Enabled = False
        Me.Moneda.Location = New System.Drawing.Point(624, 24)
        Me.Moneda.Name = "Moneda"
        Me.Moneda.Size = New System.Drawing.Size(121, 21)
        Me.Moneda.TabIndex = 6
        Me.Moneda.ValueMember = "CodMoneda"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(648, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Moneda :"
        '
        'smbGenerar
        '
        Me.smbGenerar.Enabled = False
        Me.smbGenerar.Location = New System.Drawing.Point(784, 24)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.TabIndex = 4
        Me.smbGenerar.Text = "Generar"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(248, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(72, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha Inicial :"
        '
        'dtInicial
        '
        Me.dtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtInicial.Location = New System.Drawing.Point(64, 24)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Size = New System.Drawing.Size(120, 22)
        Me.dtInicial.TabIndex = 1
        '
        'dtFinal
        '
        Me.dtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFinal.Location = New System.Drawing.Point(240, 24)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(104, 22)
        Me.dtFinal.TabIndex = 0
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
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
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM CuentaContable WHERE (CuentaContable = @Original_CuentaContable) AND " & _
        "(CuentaMadre = @Original_CuentaMadre) AND (DescCuentaMadre = @Original_DescCuent" & _
        "aMadre) AND (Descripcion = @Original_Descripcion) AND (Movimiento = @Original_Mo" & _
        "vimiento) AND (Nivel = @Original_Nivel) AND (PARENTID = @Original_PARENTID) AND " & _
        "(Tipo = @Original_Tipo) AND (id = @Original_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CuentaContable(CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre," & _
        " Movimiento, PARENTID, DescCuentaMadre) VALUES (@CuentaContable, @Descripcion, @" & _
        "Nivel, @Tipo, @CuentaMadre, @Movimiento, @PARENTID, @DescCuentaMadre); SELECT Cu" & _
        "entaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PARENTID, D" & _
        "escCuentaMadre FROM CuentaContable WHERE (CuentaContable = @CuentaContable)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PAR" & _
        "ENTID, DescCuentaMadre FROM CuentaContable ORDER BY CuentaContable"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE CuentaContable SET CuentaContable = @CuentaContable, Descripcion = @Descri" & _
        "pcion, Nivel = @Nivel, Tipo = @Tipo, CuentaMadre = @CuentaMadre, Movimiento = @M" & _
        "ovimiento, PARENTID = @PARENTID, DescCuentaMadre = @DescCuentaMadre WHERE (Cuent" & _
        "aContable = @Original_CuentaContable) AND (CuentaMadre = @Original_CuentaMadre) " & _
        "AND (DescCuentaMadre = @Original_DescCuentaMadre) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Original_Nivel" & _
        ") AND (PARENTID = @Original_PARENTID) AND (Tipo = @Original_Tipo); SELECT Cuenta" & _
        "Contable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PARENTID, DescC" & _
        "uentaMadre FROM CuentaContable WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 498)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1048, 52)
        Me.ToolBar1.TabIndex = 84
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
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.Width = 154
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Descripcion"
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
        Me.TreeList2.Location = New System.Drawing.Point(8, 120)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.ParentFieldName = "PARENTID"
        Me.TreeList2.Size = New System.Drawing.Size(1032, 320)
        Me.TreeList2.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyle("HeaderPanel", "TreeList", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight))
        Me.TreeList2.TabIndex = 86
        Me.TreeList2.Text = "TreeList2"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(256, 456)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 16)
        Me.Label7.TabIndex = 149
        Me.Label7.Text = "Saldo Anterior"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoAnterior
        '
        Me.txtSaldoAnterior.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtSaldoAnterior.Location = New System.Drawing.Point(256, 472)
        Me.txtSaldoAnterior.Name = "txtSaldoAnterior"
        Me.txtSaldoAnterior.ReadOnly = True
        Me.txtSaldoAnterior.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoAnterior.Size = New System.Drawing.Size(128, 20)
        Me.txtSaldoAnterior.TabIndex = 150
        Me.txtSaldoAnterior.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(544, 456)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "Créditos"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCreditos
        '
        Me.txtCreditos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtCreditos.Location = New System.Drawing.Point(544, 472)
        Me.txtCreditos.Name = "txtCreditos"
        Me.txtCreditos.ReadOnly = True
        Me.txtCreditos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCreditos.Size = New System.Drawing.Size(128, 20)
        Me.txtCreditos.TabIndex = 152
        Me.txtCreditos.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(400, 456)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 16)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Débitos"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDebitos
        '
        Me.txtDebitos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtDebitos.Location = New System.Drawing.Point(400, 472)
        Me.txtDebitos.Name = "txtDebitos"
        Me.txtDebitos.ReadOnly = True
        Me.txtDebitos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDebitos.Size = New System.Drawing.Size(128, 20)
        Me.txtDebitos.TabIndex = 154
        Me.txtDebitos.Text = ""
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(688, 456)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 155
        Me.Label5.Text = "Saldo del Mes"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoMes
        '
        Me.txtSaldoMes.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtSaldoMes.Location = New System.Drawing.Point(688, 472)
        Me.txtSaldoMes.Name = "txtSaldoMes"
        Me.txtSaldoMes.ReadOnly = True
        Me.txtSaldoMes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoMes.Size = New System.Drawing.Size(128, 20)
        Me.txtSaldoMes.TabIndex = 156
        Me.txtSaldoMes.Text = ""
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(832, 456)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 16)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "Saldo Actual"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSaldoActual
        '
        Me.txtSaldoActual.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtSaldoActual.Location = New System.Drawing.Point(832, 472)
        Me.txtSaldoActual.Name = "txtSaldoActual"
        Me.txtSaldoActual.ReadOnly = True
        Me.txtSaldoActual.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSaldoActual.Size = New System.Drawing.Size(128, 20)
        Me.txtSaldoActual.TabIndex = 158
        Me.txtSaldoActual.Text = ""
        '
        'AdTemporal2
        '
        Me.AdTemporal2.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdTemporal2.InsertCommand = Me.SqlInsertCommand4
        Me.AdTemporal2.SelectCommand = Me.SqlSelectCommand4
        Me.AdTemporal2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Temporal2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("SaldoAnterior", "SaldoAnterior"), New System.Data.Common.DataColumnMapping("Debitos", "Debitos"), New System.Data.Common.DataColumnMapping("Creditos", "Creditos"), New System.Data.Common.DataColumnMapping("SaldoMes", "SaldoMes"), New System.Data.Common.DataColumnMapping("SaldoActual", "SaldoActual"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID")})})
        Me.AdTemporal2.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Temporal2 WHERE (CuentaContable = @Original_CuentaContable) AND (Cred" & _
        "itos = @Original_Creditos) AND (Debitos = @Original_Debitos) AND (Descripcion = " & _
        "@Original_Descripcion) AND (Id = @Original_Id) AND (Movimiento = @Original_Movim" & _
        "iento) AND (Nivel = @Original_Nivel) AND (PARENTID = @Original_PARENTID) AND (Sa" & _
        "ldoActual = @Original_SaldoActual) AND (SaldoAnterior = @Original_SaldoAnterior)" & _
        " AND (SaldoMes = @Original_SaldoMes)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Temporal2(CuentaContable, Descripcion, SaldoAnterior, Debitos, Credit" & _
        "os, SaldoMes, SaldoActual, Nivel, Movimiento, Id, PARENTID) VALUES (@CuentaConta" & _
        "ble, @Descripcion, @SaldoAnterior, @Debitos, @Creditos, @SaldoMes, @SaldoActual," & _
        " @Nivel, @Movimiento, @Id, @PARENTID); SELECT CuentaContable, Descripcion, Saldo" & _
        "Anterior, Debitos, Creditos, SaldoMes, SaldoActual, Nivel, Movimiento, Id, PAREN" & _
        "TID FROM Temporal2 WHERE (CuentaContable = @CuentaContable)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CuentaContable, Descripcion, SaldoAnterior, Debitos, Creditos, SaldoMes, S" & _
        "aldoActual, Nivel, Movimiento, Id, PARENTID FROM Temporal2"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Temporal2 SET CuentaContable = @CuentaContable, Descripcion = @Descripcion" & _
        ", SaldoAnterior = @SaldoAnterior, Debitos = @Debitos, Creditos = @Creditos, Sald" & _
        "oMes = @SaldoMes, SaldoActual = @SaldoActual, Nivel = @Nivel, Movimiento = @Movi" & _
        "miento, Id = @Id, PARENTID = @PARENTID WHERE (CuentaContable = @Original_CuentaC" & _
        "ontable) AND (Creditos = @Original_Creditos) AND (Debitos = @Original_Debitos) A" & _
        "ND (Descripcion = @Original_Descripcion) AND (Id = @Original_Id) AND (Movimiento" & _
        " = @Original_Movimiento) AND (Nivel = @Original_Nivel) AND (PARENTID = @Original" & _
        "_PARENTID) AND (SaldoActual = @Original_SaldoActual) AND (SaldoAnterior = @Origi" & _
        "nal_SaldoAnterior) AND (SaldoMes = @Original_SaldoMes); SELECT CuentaContable, D" & _
        "escripcion, SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual, Nivel, Movi" & _
        "miento, Id, PARENTID FROM Temporal2 WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Moneda(MonedaNombre, ValorVenta, CodMoneda, Simbolo) VALUES (@MonedaN" & _
        "ombre, @ValorVenta, @CodMoneda, @Simbolo); SELECT MonedaNombre, ValorVenta, CodM" & _
        "oneda, Simbolo FROM Moneda"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT MonedaNombre, ValorVenta, CodMoneda, Simbolo FROM Moneda"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'AdapterCentroCosto
        '
        Me.AdapterCentroCosto.DeleteCommand = Me.SqlDeleteCommand5
        Me.AdapterCentroCosto.InsertCommand = Me.SqlInsertCommand6
        Me.AdapterCentroCosto.SelectCommand = Me.SqlSelectCommand6
        Me.AdapterCentroCosto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdapterCentroCosto.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = "DELETE FROM CentroCosto WHERE (Id = @Original_Id) AND (Codigo = @Original_Codigo)" & _
        " AND (Nombre = @Original_Nombre)"
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand6
        '
        Me.SqlInsertCommand6.CommandText = "INSERT INTO CentroCosto(Codigo, Nombre) VALUES (@Codigo, @Nombre); SELECT Id, Cod" & _
        "igo, Nombre FROM CentroCosto WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand6.Connection = Me.SqlConnection1
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlInsertCommand6.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT Id, Codigo, Nombre FROM CentroCosto"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = "UPDATE CentroCosto SET Codigo = @Codigo, Nombre = @Nombre WHERE (Id = @Original_I" & _
        "d) AND (Codigo = @Original_Codigo) AND (Nombre = @Original_Nombre); SELECT Id, C" & _
        "odigo, Nombre FROM CentroCosto WHERE (Id = @Id)"
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'AdapterMovimientoCentro
        '
        Me.AdapterMovimientoCentro.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterMovimientoCentro.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterMovimientoCentro.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCostoMovimientos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAsiento", "IdAsiento"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdCentroCosto", "IdCentroCosto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("IdDetalle", "IdDetalle"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descri" & _
        "pcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle, CodMoneda, TipoCam" & _
        "bio FROM CentroCostoMovimientos"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO CentroCostoMovimientos(IdAsiento, Documento, Fecha, IdCentroCosto, Mo" & _
        "nto, Debe, Haber, Descripcion, CuentaContable, NombreCuentaContable, Tipo, IdDet" & _
        "alle, CodMoneda, TipoCambio) VALUES (@IdAsiento, @Documento, @Fecha, @IdCentroCo" & _
        "sto, @Monto, @Debe, @Haber, @Descripcion, @CuentaContable, @NombreCuentaContable" & _
        ", @Tipo, @IdDetalle, @CodMoneda, @TipoCambio); SELECT Id, IdAsiento, Documento, " & _
        "Fecha, IdCentroCosto, Monto, Debe, Haber, Descripcion, CuentaContable, NombreCue" & _
        "ntaContable, Tipo, IdDetalle, CodMoneda, TipoCambio FROM CentroCostoMovimientos"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'frmBalanceCentroCosto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1048, 550)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSaldoActual)
        Me.Controls.Add(Me.txtSaldoMes)
        Me.Controls.Add(Me.txtDebitos)
        Me.Controls.Add(Me.txtCreditos)
        Me.Controls.Add(Me.txtSaldoAnterior)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TituloModulo)
        Me.Name = "frmBalanceCentroCosto"
        Me.Text = "Balance Centro Costo"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DsBalanceCentro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub frmBalanceCentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            conectadobd = Cconexion.Conectar("Contabilidad")
            Estado(False)
            InitData()
            AdapterMoneda.Fill(DsBalanceCentro, "Moneda")
            AdapterCentroCosto.Fill(DsBalanceCentro, "CentroCosto")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub InitData()
        CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Saldo Anterior", "SaldoAnterior", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Débitos", "Debitos", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Créditos", "Creditos", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Saldo Mes", "SaldoMes", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Saldo Actual", "SaldoActual", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Nivel", "Nivel", -1, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        TreeList2.BestFitColumns()
    End Sub


    Private Sub CreateColumn(ByVal tl As TreeList, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
        Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = tl.Columns.Add()
        col.Caption = caption
        col.FieldName = field
        col.visibleIndex = visibleindex
        col.Format.FormatType = formatType
        If formatType = DevExpress.Utils.FormatType.Custom Then
            col.Format.Format = New BaseFormatter
        End If
        col.Format.FormatString = formatString
    End Sub
#End Region

#Region "Controles"
    Function Estado(ByVal valor As Boolean)
        Me.dtFinal.Enabled = valor
        Me.dtInicial.Enabled = valor
        smbGenerar.Enabled = valor
        CBCentroCosto.Enabled = valor
        Moneda.Enabled = valor
    End Function


    Private Sub LLenarCeros()
        Dim n As Integer
        For n = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1
            DsBalanceCentro.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
            DsBalanceCentro.CuentaContable.Rows(n).Item("Debitos") = 0
            DsBalanceCentro.CuentaContable.Rows(n).Item("Creditos") = 0
            DsBalanceCentro.CuentaContable.Rows(n).Item("SaldoMes") = 0
            DsBalanceCentro.CuentaContable.Rows(n).Item("SaldoActual") = 0
        Next
    End Sub


    Private Sub dtInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtFinal.Focus()
        End If
    End Sub


    Private Sub dtFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBCentroCosto.Focus()
        End If
    End Sub


    Private Sub CBCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBCentroCosto.KeyDown
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Generar"
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        Try
            Dim Fecha1, Fecha2 As Date
            Fecha1 = dtInicial.Value.Date
            Fecha2 = Me.dtFinal.Value.Date
            If Fecha1 > Fecha2 Then
                MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
                Exit Sub
            End If

            Me.DsBalanceCentro.Temporal2.Clear()
            Me.DsBalanceCentro.CuentaContable.Clear()
            AdCuentas.Fill(Me.DsBalanceCentro.CuentaContable)
            TreeList2.Columns(1).Width = 300
            LLenarCeros()
            CargarAsientos(Fecha1)
            CargarDebitos(Fecha1, Fecha2)
            Calcular_Saldos()
            Calcular()

            TreeList2.DataSource = DsBalanceCentro
            TreeList2.DataMember = "CuentaContable"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Cargar Asientos"
    Function CargarAsientos(ByVal FechaInicio As String)
        Dim cnnv As SqlConnection = Nothing
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto As Double
        Dim i, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM CentroCostoMovimientos WHERE Fecha <= dbo.DateOnlyInicio(@Fecha) And IdCentroCosto = @CentroCosto"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@CentroCosto", SqlDbType.Int))
            cmdv.Parameters("@CentroCosto").Value = CBCentroCosto.SelectedValue
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsBalanceCentro.CentroCostoMovimientos.Clear()
            dv.Fill(Me.DsBalanceCentro.CentroCostoMovimientos)

            For x = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1

                For i = 0 To Me.DsBalanceCentro.CentroCostoMovimientos.Rows.Count - 1
                    If DsBalanceCentro.CuentaContable.Rows(x).Item("CuentaContable") = DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("CuentaContable") Then
                        If DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("CodMoneda") = Moneda.SelectedValue Then
                            Monto = DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Monto")
                        Else
                            If DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("CodMoneda") = 1 Then
                                Monto = (DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Monto") / DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("TipoCambio"))
                            Else
                                Monto = (DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Monto") * DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("TipoCambio"))
                            End If
                        End If

                        If DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Debe") = True Then
                            Debe = Debe + Monto
                        Else
                            Haber = Haber + Monto
                        End If
                    End If
                Next

                If DsBalanceCentro.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DsBalanceCentro.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DsBalanceCentro.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                    DsBalanceCentro.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                Else
                    DsBalanceCentro.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                End If

                Debe = 0
                Haber = 0
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
        Dim cnnv As SqlConnection = Nothing
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto As Double
        Dim i, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM CentroCostoMovimientos WHERE (Fecha >= dbo.DateOnlyInicio(@FechaIni)) AND (Fecha <= dbo.DateOnlyFinal(@FechaFin)) AND (IdCentroCosto = @CentroCosto)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@FechaIni", SqlDbType.DateTime))
            cmdv.Parameters("@FechaIni").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@FechaFin", SqlDbType.DateTime))
            cmdv.Parameters("@FechaFin").Value = FechaFinal
            cmdv.Parameters.Add(New SqlParameter("@CentroCosto", SqlDbType.Int))
            cmdv.Parameters("@CentroCosto").Value = CBCentroCosto.SelectedValue
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsBalanceCentro.CentroCostoMovimientos.Clear()

            dv.Fill(Me.DsBalanceCentro.CentroCostoMovimientos)
            Debe = 0
            Haber = 0

            For x = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1

                For i = 0 To Me.DsBalanceCentro.CentroCostoMovimientos.Rows.Count - 1

                    If DsBalanceCentro.CuentaContable.Rows(x).Item("CuentaContable") = DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("CuentaContable") Then
                        If DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("CodMoneda") = Moneda.SelectedValue Then
                            Monto = DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Monto")
                        Else
                            If DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("CodMoneda") = 1 Then
                                Monto = (DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Monto") / DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("TipoCambio"))
                            Else
                                Monto = (DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Monto") * DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("TipoCambio"))
                            End If
                        End If

                        If DsBalanceCentro.CentroCostoMovimientos.Rows(i).Item("Debe") = True Then
                            Debe = Debe + Monto
                        Else
                            Haber = Haber + Monto
                        End If
                    End If

                Next
                DsBalanceCentro.CuentaContable.Rows(x).Item("Debitos") = Debe
                DsBalanceCentro.CuentaContable.Rows(x).Item("Creditos") = Haber
                Debe = 0
                Haber = 0
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
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
            Calcular(5)
            Calcular(4)
            Calcular(3)
            Calcular(2)
            Calcular(1)

            For k = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1
                If Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Nivel") = 0 Then
                    If DsBalanceCentro.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalanceCentro.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalanceCentro.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Then
                        SaldoAnterior = SaldoAnterior + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoAnterior")
                        SaldoMes = SaldoMes + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoMes")
                        SaldoActual = SaldoActual + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoActual")
                    Else
                        SaldoAnterior = SaldoAnterior - Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoAnterior")
                        SaldoMes = SaldoMes - Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoMes")
                        SaldoActual = SaldoActual - Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoActual")
                    End If
                    Debitos = Debitos + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Debitos")
                    Creditos = Creditos + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Creditos")
                End If
            Next

            Me.txtSaldoAnterior.Text = Format(SaldoAnterior, "#,#0.00")
            Me.txtDebitos.Text = Format(Debitos, "#,#0.00")
            Me.txtCreditos.Text = Format(Creditos, "#,#0.00")
            Me.txtSaldoMes.Text = Format(SaldoMes, "#,#0.00")
            Me.txtSaldoActual.Text = Format(SaldoActual, "#,#0.00")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Function Calcular(ByVal Nivel As Integer)
        Dim k, j As Integer
        For k = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1
            If Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1
                    If Me.DsBalanceCentro.CuentaContable.Rows(j).Item("Id") = Me.DsBalanceCentro.CuentaContable.Rows(k).Item("PARENTID") Then
                        Me.DsBalanceCentro.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalanceCentro.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoAnterior")
                        Me.DsBalanceCentro.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalanceCentro.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Debitos")
                        Me.DsBalanceCentro.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalanceCentro.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Creditos")
                        Me.DsBalanceCentro.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalanceCentro.CuentaContable.Rows(j).Item("SaldoMes") + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoMes")
                        Me.DsBalanceCentro.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalanceCentro.CuentaContable.Rows(j).Item("SaldoActual") + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoActual")
                    End If
                Next
            End If
        Next
    End Function


    Private Sub Calcular_Saldos()
        Dim k As Integer
        Try
            For k = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1
                If DsBalanceCentro.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalanceCentro.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalanceCentro.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Then
                    Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Debitos") - Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Creditos")
                Else
                    Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Creditos") - Me.DsBalanceCentro.CuentaContable.Rows(k).Item("Debitos")
                End If

                Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoActual") = Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.DsBalanceCentro.CuentaContable.Rows(k).Item("SaldoMes")
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
            DataTableToExcel(Me.DsBalanceCentro.Temporal2)
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
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim Fecha1, Fecha2 As Date
        Fecha1 = dtInicial.Value.Date
        Fecha2 = Me.dtFinal.Value.Date
        If Fecha1 > Fecha2 Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            Cconexion.DeleteRecords("Temporal2", "")
            Dim nivel As New Nivel
            cargar()
            nivel.reporte = "Centro de Costo " & CBCentroCosto.Text
            nivel.Analitico = False
            nivel.saldoant = Me.txtSaldoAnterior.Text
            nivel.saldomes = Me.txtSaldoMes.Text
            nivel.saldoactual = Me.txtSaldoActual.Text
            nivel.debitos = Me.txtDebitos.Text
            nivel.creditos = Me.txtCreditos.Text
            nivel.dtInicial.Text = Me.dtInicial.Text
            nivel.dtFinal.Text = Me.dtFinal.Text
            nivel.moneda = DsBalanceCentro.Moneda(Moneda.SelectedIndex).MonedaNombre
            nivel.simbolo = DsBalanceCentro.Moneda(Moneda.SelectedIndex).Simbolo
            nivel.CodMoneda = DsBalanceCentro.Moneda(Moneda.SelectedIndex).CodMoneda
            nivel.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Function cargar()
        Dim i As Integer
        Dim trans As SqlTransaction
        Try
            DsBalanceCentro.Temporal2.Clear()

            For i = 0 To Me.DsBalanceCentro.CuentaContable.Rows.Count - 1
                If Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Debitos") <> 0 Or Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Creditos") <> 0 Then
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).AddNew()
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("CuentaContable") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("CuentaContable")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("Descripcion") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Descripcion")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("SaldoAnterior") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("SaldoAnterior")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("Debitos") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Debitos")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("Creditos") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Creditos")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("SaldoMes") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("SaldoMes")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("SaldoActual") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("SaldoActual")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("Nivel") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Nivel")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("Movimiento") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Movimiento")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("Id") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("Id")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).Current("PARENTID") = Me.DsBalanceCentro.CuentaContable.Rows(i).Item("PARENTID")
                    Me.BindingContext(Me.DsBalanceCentro.Temporal2).EndCurrentEdit()
                End If
            Next

            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            trans = Me.SqlConnection1.BeginTransaction
            Me.AdTemporal2.InsertCommand.Transaction = trans
            Me.AdTemporal2.UpdateCommand.Transaction = trans
            Me.AdTemporal2.DeleteCommand.Transaction = trans
            Me.AdTemporal2.Update(Me.DsBalanceCentro, "Temporal2")
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            Me.SqlConnection1.Close()
        End Try
    End Function
#End Region

#Region "Centro Costo Detallado"
    Private Sub TreeList2_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList2.FocusedNodeChanged
        If e.Node.Id = Nothing Then
        Else
            Reporte_ID = e.Node.Id
        End If
        If e.Node.Id = 0 Then
            Reporte_ID = e.Node.Id
        End If
    End Sub


    Private Sub TreeList2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList2.DoubleClick
        If DsBalanceCentro.CuentaContable(Reporte_ID).Movimiento = False Then Exit Sub

        Try
            Cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.ReporteAnaliticoDetalladoCentroCosto '" & DsBalanceCentro.CuentaContable(Reporte_ID).CuentaContable & "'," & (DsBalanceCentro.CuentaContable(Reporte_ID).Nivel + 1) & ",'" & Me.dtInicial.Value.Date & "','" & Me.dtFinal.Value.Date & "'," & DsBalanceCentro.Moneda(Moneda.SelectedIndex).CodMoneda & "," & CBCentroCosto.SelectedValue)
            Dim rpt As New rptCentroCostoDetallado
            Dim visor As New frmVisorReportes

            rpt.SetParameterValue(0, DsBalanceCentro.Moneda(Moneda.SelectedIndex).MonedaNombre)
            rpt.SetParameterValue(1, DsBalanceCentro.CuentaContable(Reporte_ID).SaldoMes)
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
#End Region

End Class
