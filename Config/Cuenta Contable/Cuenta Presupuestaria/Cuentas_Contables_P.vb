Imports System.Data.SqlClient

Imports Utilidades

Public Class Cuentas_Contables_P
    Inherits Plantilla

#Region "Variables"
    Dim Entrar As Boolean = True
    Public TablaCuentas As New DataTable
    Public TablaCuenta As New DataTable
    Public TablaEliminar As New DataTable
    Public TablaNiveles As New DataTable
    Dim Reporte_ID As Integer
    Dim ContadorNivel, s, Padre, h, r, Editando, Posicion As Integer
    Dim usua As Object
    Dim strModulo As String : Dim nuevaconexion As String
    Dim posi As Integer = 0
    Dim separador As Char
    Dim n1, n2, n3, n4, n5, n6, n7, n8 As Integer
    Dim cuenta, nodo, Mascara As String
    Dim niveles, pos As Integer
    Dim movimiento As Boolean = False
    Dim tipo As String
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
        nuevaconexion = conexion


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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMovimiento As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterFormatoCuenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtCuenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNivel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCuentaMadre As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlControles As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterTipoCuenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtPadre As System.Windows.Forms.TextBox
    Friend WithEvents colCuentaContable As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colTipo As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents AdapterCuentasContables As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents txtDescripcionMadre As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ButAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ButNuevoDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents colCuenta As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colDescripcion As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents colMovimiento As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents adTipoCompra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetCuentasContables1 As DataSetCuentasContables_P
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Cuentas_Contables_P))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbMovimiento = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterFormatoCuenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.txtCuenta = New DevExpress.XtraEditors.TextEdit
        Me.txtNivel = New DevExpress.XtraEditors.TextEdit
        Me.txtCuentaMadre = New DevExpress.XtraEditors.TextEdit
        Me.pnlControles = New System.Windows.Forms.Panel
        Me.ButNuevoDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButAgregarDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtDescripcionMadre = New System.Windows.Forms.TextBox
        Me.AdapterTipoCuenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TxtPadre = New System.Windows.Forms.TextBox
        Me.colCuentaContable = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colTipo = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.colCuenta = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colDescripcion = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.colMovimiento = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.DataSetCuentasContables1 = New DataSetCuentasContables_P
        Me.AdapterCuentasContables = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.adTipoCompra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNivel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCuentaMadre.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlControles.SuspendLayout()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCuentasContables1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Visible = False
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 442)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(696, 52)
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Text = "Editar"
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(696, 32)
        Me.TituloModulo.Text = "Cuentas Contables Presupuestarias"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 16)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Código Cuenta"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(345, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 16)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "Descripción"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(10, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Nivel"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(76, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 93
        Me.Label5.Text = "Movimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMovimiento
        '
        Me.cmbMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMovimiento.Items.AddRange(New Object() {"SÍ", "NO"})
        Me.cmbMovimiento.Location = New System.Drawing.Point(76, 64)
        Me.cmbMovimiento.Name = "cmbMovimiento"
        Me.cmbMovimiento.Size = New System.Drawing.Size(80, 21)
        Me.cmbMovimiento.TabIndex = 94
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(160, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 16)
        Me.Label6.TabIndex = 95
        Me.Label6.Text = "Cuenta Madre"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(344, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(328, 16)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "Descripción Cta. Madre"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DRAGONS;packet size=4096;integrated security=SSPI;data source="".\s" & _
        "ql2000"";persist security info=False;initial catalog=Contabilidad"
        '
        'AdapterFormatoCuenta
        '
        Me.AdapterFormatoCuenta.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterFormatoCuenta.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterFormatoCuenta.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterFormatoCuenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FormatoCuenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Niveles", "Niveles"), New System.Data.Common.DataColumnMapping("N1", "N1"), New System.Data.Common.DataColumnMapping("N2", "N2"), New System.Data.Common.DataColumnMapping("N3", "N3"), New System.Data.Common.DataColumnMapping("N4", "N4"), New System.Data.Common.DataColumnMapping("N5", "N5"), New System.Data.Common.DataColumnMapping("N6", "N6"), New System.Data.Common.DataColumnMapping("N7", "N7"), New System.Data.Common.DataColumnMapping("N8", "N8"), New System.Data.Common.DataColumnMapping("Separador", "Separador")})})
        Me.AdapterFormatoCuenta.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM FormatoCuenta WHERE (Id = @Original_Id) AND (N1 = @Original_N1) AND (" & _
        "N2 = @Original_N2) AND (N3 = @Original_N3) AND (N4 = @Original_N4) AND (N5 = @Or" & _
        "iginal_N5) AND (N6 = @Original_N6) AND (N7 = @Original_N7) AND (N8 = @Original_N" & _
        "8) AND (Niveles = @Original_Niveles) AND (Separador = @Original_Separador)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO FormatoCuenta(Niveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador) VAL" & _
        "UES (@Niveles, @N1, @N2, @N3, @N4, @N5, @N6, @N7, @N8, @Separador); SELECT Id, N" & _
        "iveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador FROM FormatoCuenta WHERE (Id =" & _
        " @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, Niveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador FROM FormatoCuenta"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE FormatoCuenta SET Niveles = @Niveles, N1 = @N1, N2 = @N2, N3 = @N3, N4 = @" & _
        "N4, N5 = @N5, N6 = @N6, N7 = @N7, N8 = @N8, Separador = @Separador WHERE (Id = @" & _
        "Original_Id) AND (N1 = @Original_N1) AND (N2 = @Original_N2) AND (N3 = @Original" & _
        "_N3) AND (N4 = @Original_N4) AND (N5 = @Original_N5) AND (N6 = @Original_N6) AND" & _
        " (N7 = @Original_N7) AND (N8 = @Original_N8) AND (Niveles = @Original_Niveles) A" & _
        "ND (Separador = @Original_Separador); SELECT Id, Niveles, N1, N2, N3, N4, N5, N6" & _
        ", N7, N8, Separador FROM FormatoCuenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'txtCuenta
        '
        Me.txtCuenta.EditValue = ""
        Me.txtCuenta.Location = New System.Drawing.Point(8, 16)
        Me.txtCuenta.Name = "txtCuenta"
        '
        'txtCuenta.Properties
        '
        Me.txtCuenta.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuenta.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuenta.Properties.Enabled = False
        Me.txtCuenta.Properties.MaskData.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCuenta.Size = New System.Drawing.Size(312, 19)
        Me.txtCuenta.TabIndex = 0
        '
        'txtNivel
        '
        Me.txtNivel.EditValue = ""
        Me.txtNivel.Location = New System.Drawing.Point(10, 64)
        Me.txtNivel.Name = "txtNivel"
        '
        'txtNivel.Properties
        '
        Me.txtNivel.Properties.ReadOnly = True
        Me.txtNivel.Size = New System.Drawing.Size(56, 19)
        Me.txtNivel.TabIndex = 105
        '
        'txtCuentaMadre
        '
        Me.txtCuentaMadre.EditValue = ""
        Me.txtCuentaMadre.Location = New System.Drawing.Point(160, 64)
        Me.txtCuentaMadre.Name = "txtCuentaMadre"
        '
        'txtCuentaMadre.Properties
        '
        Me.txtCuentaMadre.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaMadre.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCuentaMadre.Properties.Enabled = False
        Me.txtCuentaMadre.Properties.MaskData.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple
        Me.txtCuentaMadre.Size = New System.Drawing.Size(175, 19)
        Me.txtCuentaMadre.TabIndex = 106
        '
        'pnlControles
        '
        Me.pnlControles.Controls.Add(Me.ButNuevoDetalle)
        Me.pnlControles.Controls.Add(Me.ButAgregarDetalle)
        Me.pnlControles.Controls.Add(Me.txtDescripcion)
        Me.pnlControles.Controls.Add(Me.txtDescripcionMadre)
        Me.pnlControles.Controls.Add(Me.Label5)
        Me.pnlControles.Controls.Add(Me.Label3)
        Me.pnlControles.Controls.Add(Me.Label4)
        Me.pnlControles.Controls.Add(Me.txtCuenta)
        Me.pnlControles.Controls.Add(Me.cmbMovimiento)
        Me.pnlControles.Controls.Add(Me.Label6)
        Me.pnlControles.Controls.Add(Me.Label8)
        Me.pnlControles.Controls.Add(Me.txtNivel)
        Me.pnlControles.Controls.Add(Me.txtCuentaMadre)
        Me.pnlControles.Controls.Add(Me.Label1)
        Me.pnlControles.Location = New System.Drawing.Point(0, 32)
        Me.pnlControles.Name = "pnlControles"
        Me.pnlControles.Size = New System.Drawing.Size(688, 120)
        Me.pnlControles.TabIndex = 110
        '
        'ButNuevoDetalle
        '
        Me.ButNuevoDetalle.ImageIndex = 2
        Me.ButNuevoDetalle.ImageList = Me.ImageList1
        Me.ButNuevoDetalle.Location = New System.Drawing.Point(440, 88)
        Me.ButNuevoDetalle.Name = "ButNuevoDetalle"
        Me.ButNuevoDetalle.Size = New System.Drawing.Size(112, 24)
        Me.ButNuevoDetalle.TabIndex = 111
        Me.ButNuevoDetalle.Text = "Nueva Cuenta"
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ButAgregarDetalle
        '
        Me.ButAgregarDetalle.ImageIndex = 0
        Me.ButAgregarDetalle.ImageList = Me.ImageList1
        Me.ButAgregarDetalle.Location = New System.Drawing.Point(560, 88)
        Me.ButAgregarDetalle.Name = "ButAgregarDetalle"
        Me.ButAgregarDetalle.Size = New System.Drawing.Size(112, 24)
        Me.ButAgregarDetalle.TabIndex = 110
        Me.ButAgregarDetalle.Text = "Agregar Cuenta"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(345, 16)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcion.Size = New System.Drawing.Size(327, 20)
        Me.txtDescripcion.TabIndex = 109
        Me.txtDescripcion.Text = ""
        '
        'txtDescripcionMadre
        '
        Me.txtDescripcionMadre.Location = New System.Drawing.Point(344, 64)
        Me.txtDescripcionMadre.Name = "txtDescripcionMadre"
        Me.txtDescripcionMadre.ReadOnly = True
        Me.txtDescripcionMadre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescripcionMadre.Size = New System.Drawing.Size(328, 20)
        Me.txtDescripcionMadre.TabIndex = 108
        Me.txtDescripcionMadre.Text = ""
        '
        'AdapterTipoCuenta
        '
        Me.AdapterTipoCuenta.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterTipoCuenta.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterTipoCuenta.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterTipoCuenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoCuenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        Me.AdapterTipoCuenta.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM TipoCuenta WHERE (Id = @Original_Id)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO TipoCuenta(Nombre) VALUES (@Nombre); SELECT Id, Nombre FROM TipoCuent" & _
        "a WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id, Nombre FROM TipoCuenta"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE TipoCuenta SET Nombre = @Nombre WHERE (Id = @Original_Id); SELECT Id, Nomb" & _
        "re FROM TipoCuenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 50, "Nombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'TxtPadre
        '
        Me.TxtPadre.Location = New System.Drawing.Point(392, 0)
        Me.TxtPadre.Name = "TxtPadre"
        Me.TxtPadre.Size = New System.Drawing.Size(24, 20)
        Me.TxtPadre.TabIndex = 111
        Me.TxtPadre.Text = ""
        '
        'colCuentaContable
        '
        Me.colCuentaContable.Caption = "CuentaContable"
        Me.colCuentaContable.FieldName = "CuentaContable"
        Me.colCuentaContable.Name = "colCuentaContable"
        Me.colCuentaContable.Options = CType((((((DevExpress.XtraTreeList.Columns.ColumnOptions.CanMoved Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanMovedToCustomizationForm), DevExpress.XtraTreeList.Columns.ColumnOptions)
        Me.colCuentaContable.VisibleIndex = 0
        Me.colCuentaContable.Width = 29
        '
        'colTipo
        '
        Me.colTipo.Caption = "Tipo"
        Me.colTipo.FieldName = "Tipo"
        Me.colTipo.Format.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colTipo.Name = "colTipo"
        Me.colTipo.Options = CType((((((DevExpress.XtraTreeList.Columns.ColumnOptions.CanMoved Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraTreeList.Columns.ColumnOptions.CanMovedToCustomizationForm), DevExpress.XtraTreeList.Columns.ColumnOptions)
        Me.colTipo.VisibleIndex = 1
        Me.colTipo.Width = 30
        '
        'TreeList1
        '
        Me.TreeList1.AllowDrop = True
        Me.TreeList1.BehaviorOptions = CType(((((((((DevExpress.XtraTreeList.BehaviorOptionsFlags.MoveOnEdit Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ExpandNodeOnDrag) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ResizeNodes) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoSelectAllInEditor) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoNodeHeight) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoChangeParent) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.CloseEditorOnLostFocus) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.KeepSelectedOnClick) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.SmartMouseHover), DevExpress.XtraTreeList.BehaviorOptionsFlags)
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colCuenta, Me.colDescripcion, Me.colMovimiento})
        Me.TreeList1.CustomizationRowCount = 6
        Me.TreeList1.DataMember = "CuentaContable_Presupuestaria"
        Me.TreeList1.DataSource = Me.DataSetCuentasContables1
        Me.TreeList1.KeyFieldName = "id"
        Me.TreeList1.Location = New System.Drawing.Point(8, 160)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "PARENTID"
        Me.TreeList1.RootValue = "0"
        Me.TreeList1.Size = New System.Drawing.Size(680, 272)
        Me.TreeList1.TabIndex = 112
        Me.TreeList1.Text = "TreeList1"
        '
        'colCuenta
        '
        Me.colCuenta.Caption = "Cuenta"
        Me.colCuenta.FieldName = "CuentaContable"
        Me.colCuenta.Name = "colCuenta"
        Me.colCuenta.SortOrder = System.Windows.Forms.SortOrder.Ascending
        Me.colCuenta.VisibleIndex = 0
        Me.colCuenta.Width = 266
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Nombre"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 275
        '
        'colMovimiento
        '
        Me.colMovimiento.Caption = "Movimiento"
        Me.colMovimiento.FieldName = "Movimiento"
        Me.colMovimiento.Name = "colMovimiento"
        Me.colMovimiento.VisibleIndex = 2
        Me.colMovimiento.Width = 151
        '
        'DataSetCuentasContables1
        '
        Me.DataSetCuentasContables1.DataSetName = "DataSetCuentasContables_P"
        Me.DataSetCuentasContables1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'AdapterCuentasContables
        '
        Me.AdapterCuentasContables.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterCuentasContables.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterCuentasContables.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterCuentasContables.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable_Presupuestaria", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("Nombre_Usuario", "Nombre_Usuario")})})
        Me.AdapterCuentasContables.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM CuentaContable_Presupuestaria WHERE (CuentaContable = @Original_Cuent" & _
        "aContable) AND (CuentaMadre = @Original_CuentaMadre) AND (DescCuentaMadre = @Ori" & _
        "ginal_DescCuentaMadre) AND (Descripcion = @Original_Descripcion) AND (Movimiento" & _
        " = @Original_Movimiento) AND (Nivel = @Original_Nivel) AND (Nombre_Usuario = @Or" & _
        "iginal_Nombre_Usuario OR @Original_Nombre_Usuario IS NULL AND Nombre_Usuario IS " & _
        "NULL) AND (PARENTID = @Original_PARENTID) AND (id = @Original_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CuentaContable_Presupuestaria(CuentaContable, Descripcion, Nivel, PAR" & _
        "ENTID, CuentaMadre, DescCuentaMadre, Movimiento, Nombre_Usuario) VALUES (@Cuenta" & _
        "Contable, @Descripcion, @Nivel, @PARENTID, @CuentaMadre, @DescCuentaMadre, @Movi" & _
        "miento, @Nombre_Usuario); SELECT CuentaContable, Descripcion, Nivel, PARENTID, C" & _
        "uentaMadre, DescCuentaMadre, Movimiento, id, Nombre_Usuario FROM CuentaContable_" & _
        "Presupuestaria WHERE (CuentaContable = @CuentaContable)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 255, "Nombre_Usuario"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CuentaContable, Descripcion, Nivel, PARENTID, CuentaMadre, DescCuentaMadre" & _
        ", Movimiento, id, Nombre_Usuario FROM CuentaContable_Presupuestaria"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE CuentaContable_Presupuestaria SET CuentaContable = @CuentaContable, Descri" & _
        "pcion = @Descripcion, Nivel = @Nivel, PARENTID = @PARENTID, CuentaMadre = @Cuent" & _
        "aMadre, DescCuentaMadre = @DescCuentaMadre, Movimiento = @Movimiento, Nombre_Usu" & _
        "ario = @Nombre_Usuario WHERE (CuentaContable = @Original_CuentaContable) AND (Cu" & _
        "entaMadre = @Original_CuentaMadre) AND (DescCuentaMadre = @Original_DescCuentaMa" & _
        "dre) AND (Descripcion = @Original_Descripcion) AND (Movimiento = @Original_Movim" & _
        "iento) AND (Nivel = @Original_Nivel) AND (Nombre_Usuario = @Original_Nombre_Usua" & _
        "rio OR @Original_Nombre_Usuario IS NULL AND Nombre_Usuario IS NULL) AND (PARENTI" & _
        "D = @Original_PARENTID); SELECT CuentaContable, Descripcion, Nivel, PARENTID, Cu" & _
        "entaMadre, DescCuentaMadre, Movimiento, id, Nombre_Usuario FROM CuentaContable_P" & _
        "resupuestaria WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre_Usuario", System.Data.SqlDbType.VarChar, 255, "Nombre_Usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre_Usuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre_Usuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand4
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre")})})
        Me.AdapterMoneda.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection2
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Seguridad"
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre) VALUES (@CodMoneda, @MonedaNombre); S" & _
        "ELECT CodMoneda, MonedaNombre FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection2
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CodMoneda, MonedaNombre FROM Moneda"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection2
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre WHERE (Cod" & _
        "Moneda = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre); SELEC" & _
        "T CodMoneda, MonedaNombre FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection2
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'adTipoCompra
        '
        Me.adTipoCompra.InsertCommand = Me.SqlInsertCommand5
        Me.adTipoCompra.SelectCommand = Me.SqlSelectCommand5
        Me.adTipoCompra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TipoCompra", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO TipoCompra(Codigo, Descripcion) VALUES (@Codigo, @Descripcion); SELEC" & _
        "T Codigo, Descripcion FROM TipoCompra"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.Int, 4, "Codigo"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Codigo, Descripcion FROM TipoCompra"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'Cuentas_Contables_P
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(696, 494)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.pnlControles)
        Me.Controls.Add(Me.TxtPadre)
        Me.MaximizeBox = False
        Me.Name = "Cuentas_Contables_P"
        Me.Text = "Cuentas Contables"
        Me.Controls.SetChildIndex(Me.TxtPadre, 0)
        Me.Controls.SetChildIndex(Me.pnlControles, 0)
        Me.Controls.SetChildIndex(Me.TreeList1, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        CType(Me.txtCuenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNivel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCuentaMadre.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlControles.ResumeLayout(False)
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCuentasContables1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"



    Private Sub FrmCargarLoad()
        Try
            SqlConnection1.ConnectionString = IIf(nuevaconexion = "", Configuracion.Claves.Conexion("Contabilidad"), nuevaconexion)
            SqlConnection2.ConnectionString = IIf(nuevaconexion = "", Configuracion.Claves.Conexion("Contabilidad"), nuevaconexion)

            '*******************************************************VALORES POR DEFECTO***********************************************************
            DataSetCuentasContables1.CuentaContable_Presupuestaria.CuentaContableColumn.DefaultValue = "100"
            DataSetCuentasContables1.CuentaContable_Presupuestaria.DescripcionColumn.DefaultValue = ""
            DataSetCuentasContables1.CuentaContable_Presupuestaria.NivelColumn.DefaultValue = 1
            'DataSetCuentasContables1.CuentaContable.TipoColumn.DefaultValue = 1
            DataSetCuentasContables1.CuentaContable_Presupuestaria.DescCuentaMadreColumn.DefaultValue = ""
            DataSetCuentasContables1.CuentaContable_Presupuestaria.MovimientoColumn.DefaultValue = False
            DataSetCuentasContables1.CuentaContable_Presupuestaria.PARENTIDColumn.DefaultValue = 0
            DataSetCuentasContables1.CuentaContable_Presupuestaria.CuentaMadreColumn.DefaultValue = "0"
            'DataSetCuentasContables1.CuentaContable.EvaluacionColumn.DefaultValue = False
            'DataSetCuentasContables1.CuentaContable.CodTipoCompraColumn.DefaultValue = 0
            'DataSetCuentasContables1.CuentaContable.DescTipoCompraColumn.DefaultValue = ""
            '*******************************************************Llenar Tablas***********************************************************
            AdapterFormatoCuenta.Fill(DataSetCuentasContables1.FormatoCuenta)
            AdapterCuentasContables.Fill(DataSetCuentasContables1.CuentaContable_Presupuestaria)
            AdapterTipoCuenta.Fill(DataSetCuentasContables1.TipoCuenta)
            AdapterMoneda.Fill(DataSetCuentasContables1.Moneda)
            adTipoCompra.Fill(DataSetCuentasContables1.TipoCompra)
            ToolBarRegistrar.Enabled = False
            obtiene_formato()

            If Not BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Count > 0 Then
                ToolBarEliminar.Enabled = False
                ToolBarExcel.Enabled = False
            End If

            ToolBarEliminar.Enabled = False
            ToolBarExcel.Enabled = False
            'cmbTipo.SelectedIndex = 0
            cmbMovimiento.SelectedIndex = 0
            BLOQUEAR()
            ButNuevoDetalle.Focus()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



    Private Sub Cuentas_Contables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        FrmCargarLoad()

        'Try
        '    SqlConnection1.ConnectionString = IIf(nuevaconexion = "", Configuracion.Claves.Conexion("Contabilidad"), nuevaconexion)
        '    SqlConnection2.ConnectionString = IIf(nuevaconexion = "", Configuracion.Claves.Conexion("Seguridad"), nuevaconexion)

        '    '*******************************************************VALORES POR DEFECTO***********************************************************
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.CuentaContableColumn.DefaultValue = "100"
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.DescripcionColumn.DefaultValue = ""
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.NivelColumn.DefaultValue = 1
        '    'DataSetCuentasContables1.CuentaContable.TipoColumn.DefaultValue = 1
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.DescCuentaMadreColumn.DefaultValue = ""
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.MovimientoColumn.DefaultValue = False
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.PARENTIDColumn.DefaultValue = 0
        '    DataSetCuentasContables1.CuentaContable_Presupuestaria.CuentaMadreColumn.DefaultValue = "0"
        '    'DataSetCuentasContables1.CuentaContable.EvaluacionColumn.DefaultValue = False
        '    'DataSetCuentasContables1.CuentaContable.CodTipoCompraColumn.DefaultValue = 0
        '    'DataSetCuentasContables1.CuentaContable.DescTipoCompraColumn.DefaultValue = ""
        '    '*******************************************************Llenar Tablas***********************************************************
        '    AdapterFormatoCuenta.Fill(DataSetCuentasContables1.FormatoCuenta)
        '    AdapterCuentasContables.Fill(DataSetCuentasContables1.CuentaContable_Presupuestaria)
        '    AdapterTipoCuenta.Fill(DataSetCuentasContables1.TipoCuenta)
        '    AdapterMoneda.Fill(DataSetCuentasContables1.Moneda)
        '    adTipoCompra.Fill(DataSetCuentasContables1.TipoCompra)
        '    ToolBarRegistrar.Enabled = False
        '    obtiene_formato()

        '    If Not BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Count > 0 Then
        '        ToolBarEliminar.Enabled = False
        '        ToolBarExcel.Enabled = False
        '    End If

        '    ToolBarEliminar.Enabled = False
        '    ToolBarExcel.Enabled = False
        '    'cmbTipo.SelectedIndex = 0
        '    cmbMovimiento.SelectedIndex = 0
        '    BLOQUEAR()
        '    ButNuevoDetalle.Focus()

        'Catch ex As Exception
        '    MsgBox(ex.ToString)
        'End Try
    End Sub


#Region "Obtiene Formato"
    Sub obtiene_formato()
        If Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Count > 0 Then
            separador = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("Separador")
            n1 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N1")
            n2 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N2")
            n3 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N3")
            n4 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N4")
            n5 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N5")
            n6 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N6")
            n7 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N7")
            n8 = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("N8")
            niveles = Me.BindingContext(Me.DataSetCuentasContables1, "FormatoCuenta").Current("Niveles")
        Else
            control_toolbar(False)
            MsgBox("No se puede ingresar ninguna Cuenta Contable debido a que no se ha determinado su formato." &
            Chr(13) & "Sugerencia: Ve al 'Formulario de Formato de Cuentas Contables' y crea un formato.", MsgBoxStyle.Exclamation)
        End If
    End Sub
#End Region

#End Region

#Region "Controles"
    Function BLOQUEAR()
        txtCuenta.Enabled = False : txtDescripcion.Enabled = False : txtNivel.Enabled = False
        cmbMovimiento.Enabled = False : txtCuentaMadre.Enabled = False
        ButAgregarDetalle.Enabled = False 'CheckBox1.Enabled = False : cbTipoCuenta.Enabled = False
    End Function

    Function DESBLOQUEAR()
        txtCuenta.Enabled = True : txtDescripcion.Enabled = True : txtNivel.Enabled = True
        cmbMovimiento.Enabled = True : txtCuentaMadre.Enabled = True
        ButAgregarDetalle.Enabled = True ': CheckBox1.Enabled = True : cbTipoCuenta.Enabled = True
    End Function


    Function Limpiar()
        txtCuenta.Text = ""
        txtNivel.Text = ""
        cmbMovimiento.Text = ""
        txtDescripcion.Text = ""
        'cmbTipo.Text = ""
        txtCuentaMadre.Text = ""
        txtDescripcionMadre.Text = ""
        'CheckBox1.Checked = False
    End Function
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : nuevo()

            Case 2 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3
                llenar_campos()
                If PMU.Update Then registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Editar()

            Case 7 : Me.Close()
        End Select
    End Sub

#Region "Control Toolbar"
    Sub control_toolbar(ByVal bool As Boolean)
        Me.ToolBarBuscar.Enabled = bool
        Me.ToolBarEliminar.Enabled = bool
        Me.ToolBarExcel.Enabled = bool
        Me.ToolBarNuevo.Enabled = bool
        Me.ToolBarRegistrar.Enabled = bool
    End Sub
#End Region

#End Region

#Region "Imprimir"
    Private Function Imprimir()
        Try
            Dim Cuentas As New Cuentas
            Dim visor As New frmVisorReportes

            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Cuentas, False, Configuracion.Claves.Conexion("Contabilidad"))
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try

    End Function
#End Region

#Region "Editar"
    Private Function Editar()
        pnlControles.Enabled = True : ButAgregarDetalle.Enabled = False : cmbMovimiento.Enabled = True
        txtDescripcion.Enabled = True : ButAgregarDetalle.Enabled = True
        txtCuenta.Enabled = True : txtCuentaMadre.Enabled = True ': CheckBox1.Enabled = True
        txtDescripcion.Focus()
    End Function
#End Region

#Region "Eliminar"
    Private Function Eliminar()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String
        If Me.txtCuenta.Text <> "" Then

            If MessageBox.Show(" ¿ Desea Eliminar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Function
            Resultado = Cconexion.SlqExecute(Cconexion.Conectar, "Delete from CuentaContable where CuentaContable ='" & Me.txtCuenta.Text & "'")
            If Resultado = vbNullString Then
                MessageBox.Show("La Cuenta Fue Eliminada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DataSetCuentasContables1.Clear()
                Me.Limpiar()
                'Me.Bloquear()
                'nuevo
                Me.ToolBar1.Buttons(0).Enabled = True
                'buscar
                Me.ToolBar1.Buttons(1).Enabled = True
                'editar
                Me.ToolBar1.Buttons(2).Enabled = False
                'registrar
                Me.ToolBar1.Buttons(3).Enabled = False
                'eliminar
                'Me.ToolBar1.Buttons(4).Enabled = False
                'imprimir
                Me.ToolBar1.Buttons(5).Enabled = False
                'Cerrar
                Me.ToolBar1.Buttons(6).Enabled = True
            Else
                MessageBox.Show(Resultado)
                Exit Function
            End If
        Else
            MessageBox.Show("No hay Cuenta Que Eliminar ", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function
#End Region

#Region "Buscar"
    Private Function Buscar()
        Dim funcion As New cFunciones
        Dim Id As String
        Dim FechaEmplea As String
        Dim Identificacion As Integer
        Dim n As Integer
        Dim Cuenta As String
        Try
            Me.DataSetCuentasContables1.Clear()

            Id = funcion.BuscarDatos("Select * from CuentaContable", "descripcion", "Buscar Cuenta Contable", SqlConnection1.ConnectionString)
            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable)
            If Id = Nothing Then ' si se dio en el boton de cancelar
                Exit Function
            End If

            funcion.Llenar_Tabla_Generico("Select * from CuentaContable", Me.TablaCuentas, Me.SqlConnection1.ConnectionString)
            For n = 0 To Me.TablaCuentas.Rows.Count - 1
                If Id = TablaCuentas.Rows(n).Item("CuentaContable") Then
                    Posicion = n
                    Exit Function
                End If
            Next

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function


    Private Sub LlamarFmrBuscarAsientoVenta()
        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " &
        " where Movimiento=0 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        Me.txtCuentaMadre.Text = busca.codigo
        Me.txtDescripcionMadre.Text = busca.descrip
    End Sub
#End Region

#Region "Nuevo"
    Sub nuevo()
        If Me.ToolBarNuevo.Text = "Nuevo" Then
            Me.ToolBarNuevo.ImageIndex = 8
            Me.ToolBarNuevo.Text = "Cancelar"
            cuenta = ""
            Me.txtCuenta.Focus()
            Me.Limpiar()
            cuenta = "1"
            Mascara = "#"
            For i As Integer = 0 To n1 - 2
                cuenta += "0"
                Mascara += "#"
            Next
            If n2 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n2 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n3 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n3 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n4 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n4 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n5 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n5 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n6 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n6 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n7 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n7 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n8 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n8 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            txtNivel.Text = niveles
            Me.txtCuenta.Properties.MaskData.EditMask = Mascara
            Me.txtCuenta.Text = cuenta

            Me.txtCuentaMadre.Text = "0"
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").AddNew()
            Me.pnlControles.Enabled = True
            Me.txtCuentaMadre.Properties.ReadOnly = True
            Me.txtDescripcionMadre.ReadOnly = True
            ButAgregarDetalle.Enabled = True
        Else
            Me.ToolBarNuevo.Text = "Nuevo"
            Me.ToolBarNuevo.ImageIndex = 0
            Me.Limpiar()
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").CancelCurrentEdit()
            Me.ToolBarRegistrar.Enabled = False
            ButAgregarDetalle.Enabled = False
            Me.pnlControles.Enabled = False
        End If
    End Sub


    Sub nuevo_nodo(ByVal bool As Boolean)
        cuenta = ""
        Dim control As Boolean = False
        If pos >= 0 Then
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N1") = TreeList1.FindNodeByID(pos).Item("N1").ToString
            cuenta = TreeList1.FindNodeByID(pos).Item("N1")
            If niveles > 1 Then
                cuenta += separador
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N2")) = 0 Then
                If niveles >= 2 Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N2")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N2")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")) + 1)
                    End If
                    If niveles > 2 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N2") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N2")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N3")) = 0 Then
                If niveles >= 3 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N3")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N3")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")) + 1)
                    End If
                    If niveles > 3 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N3") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N3")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N4")) = 0 Then
                If niveles >= 4 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N4")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N4")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")) + 1)
                    End If
                    If niveles > 4 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N4") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N4")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N5")) = 0 Then
                If niveles >= 5 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N5")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N5")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")) + 1)
                    End If
                    If niveles > 5 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N5") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N5")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N6")) = 0 Then
                If niveles >= 6 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N6")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N6")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")) + 1)
                    End If
                    If niveles > 6 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N6") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N6")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N7")) = 0 Then
                If niveles >= 7 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N7")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N7")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")) + 1)
                    End If
                    If niveles > 7 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") = "0"
                End If
                control = True
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")))
                cuenta += separador
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N7") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N7")))
            End If

            If CInt(TreeList1.FindNodeByID(pos).Item("N8")) = 0 Then
                If niveles >= 8 And control = False Then
                    If bool Then
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N8")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Nodes.LastNode.Item("N8")) + 1)
                    Else
                        cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")) + 1)
                        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") =
                                        CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")) + 1)
                    End If
                    If niveles > 8 Then
                        cuenta += separador
                    End If
                Else
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") = "0"
                End If
            Else
                cuenta += CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")))
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("N8") =
                CStr(CInt(TreeList1.FindNodeByID(pos).Item("N8")))
            End If
        End If
    End Sub
#End Region

#Region "Ordena"
    'Sub ordena(ByVal nivel As Integer)
    '    Dim str, format As String
    '    Select Case nivel
    '        Case 1
    '            For i As Integer = 0 To n2 - 1
    '                format += "0"
    '            Next
    '            str = "N2"
    '        Case 2
    '            format = ""
    '            For i As Integer = 0 To n3 - 1
    '                format += "0"
    '            Next
    '            str = "N3"
    '        Case 3
    '            format = ""
    '            For i As Integer = 0 To n4 - 1
    '                format += "0"
    '            Next
    '            str = "N4"
    '        Case 4
    '            format = ""
    '            For i As Integer = 0 To n5 - 1
    '                format += "0"
    '            Next
    '            str = "N5"
    '        Case 5
    '            format = ""
    '            For i As Integer = 0 To n6 - 1
    '                format += "0"
    '            Next
    '            str = "N6"
    '        Case 6
    '            format = ""
    '            For i As Integer = 0 To n7 - 1
    '                format += "0"
    '            Next
    '            str = "N7"
    '        Case 7
    '            format = ""
    '            For i As Integer = 0 To n8 - 1
    '                format += "0"
    '            Next
    '            str = "N8"
    '            'Case 8
    '            '    format = ""
    '            '    For i As Integer = 0 To n8 - 1
    '            '        format += "0"
    '            '    Next
    '            '    str = "N8"
    '    End Select
    '    Dim vista As DataView
    '    Dim aux As String = str
    '    aux += " = "
    '    aux += format
    '    vista = Me.DataSetCuentasContables1.CuentaContable.DefaultView
    '    With vista
    '        .RowFilter = aux
    '        str += " Desc"
    '        .Sort = str
    '    End With
    '    If Not nivel > niveles - 1 Then
    '        If nivel = 1 Then
    '            Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    '            Dim fila As DataRow
    '            ' TODO: BUSCAR LOS VALORES ENTRE VISTA Y TABLA DEL BINDING
    '        End If
    '        ordena(nivel + 1)
    '    End If

    'End Sub
#End Region

#Region "Llenar Campos"
    Sub llenar_campos()


        ''******************
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select  id from CuentaContable_Presupuestaria WHERE CuentaContable = '" & txtCuentaMadre.Text & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
        If dt.Rows.Count > 0 Then '
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = dt.Rows(0).Item("id")
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()
            'Padre = dt.Rows(0).Item("id")
            'BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = 2

        Else ' ID = 0
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = 0
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()

        End If
        ''******************
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("CuentaContable") = txtCuenta.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Descripcion") = txtDescripcion.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nivel") = CInt(txtNivel.Text)
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("CuentaMadre") = txtCuentaMadre.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("DescCuentaMadre") = txtDescripcionMadre.Text
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Movimiento") = movimiento
        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nombre_Usuario") = Usuario.Nombre
        'BindingContext(DataSetCuentasContables1, "CuentaContable").Current("Tipo") = tipo
        'If cbTipoCuenta.Visible Then
        '    BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CodTipoCompra") = cbTipoCuenta.SelectedValue
        '    BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescTipoCompra") = cbTipoCuenta.Text
        'Else
        '    BindingContext(DataSetCuentasContables1, "CuentaContable").Current("CodTipoCompra") = 0
        '    BindingContext(DataSetCuentasContables1, "CuentaContable").Current("DescTipoCompra") = ""
        'End If

        'If movimiento = False And CheckBox1.Checked = True Then
        '    MessageBox.Show("Una Cuenta sin Movimiento no puede tener Valuación, Se desactivara Automaticamente", "Sistema SeeSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    CheckBox1.Checked = False
        'End If
        'Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Current("Evaluacion") = CheckBox1.Checked
    End Sub
#End Region

#Region "Registrar"
    Sub registrar()
        Dim trans As SqlTransaction
        Try
            If Editando = 1 Then
                If MessageBox.Show(" ¿ Desea Actualizar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            Else
                If MessageBox.Show(" ¿ Desea Registrar Esta Cuenta ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
            End If
            Entrar = False
            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            trans = Me.SqlConnection1.BeginTransaction
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()
            Me.AdapterCuentasContables.InsertCommand.Transaction = trans
            Me.AdapterCuentasContables.UpdateCommand.Transaction = trans
            Me.AdapterCuentasContables.DeleteCommand.Transaction = trans
            Me.AdapterCuentasContables.Update(Me.DataSetCuentasContables1.CuentaContable_Presupuestaria)
            Me.DataSetCuentasContables1.AcceptChanges()
            trans.Commit()
            control_toolbar(False)
            Me.ToolBarNuevo.Enabled = True
            Me.ToolBarNuevo.ImageIndex = 0
            Me.ToolBarNuevo.Text = "Nuevo"
            MsgBox("Cuenta Contable Registrada exitosamente", MsgBoxStyle.Information)
            Me.TreeList1.Enabled = True
            Me.DataSetCuentasContables1.CuentaContable_Presupuestaria.Clear()
            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable_Presupuestaria)
            Me.BLOQUEAR()
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Position = Me.posi
            Me.ToolBarBuscar.Enabled = True

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()

        Finally
            Me.SqlConnection1.Close()
        End Try
    End Sub
#End Region

#Region "Eventos Controles"

    Private Sub cmbMovimiento_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMovimiento.SelectedIndexChanged
        If Not Me.cmbMovimiento.SelectedIndex < 0 Then
            If Me.cmbMovimiento.Text = "SÍ" Then
                movimiento = True
            Else
                movimiento = False
            End If
        End If
        If Editando = 1 Then

        Else
            If cmbMovimiento.Text = "NO" Then
                txtCuentaMadre.Text = txtCuenta.Text
                txtDescripcionMadre.Text = ""
                txtDescripcionMadre.ReadOnly = True
            End If
            If cmbMovimiento.Text = "SÍ" Then
                txtCuentaMadre.Text = ""
                txtDescripcionMadre.Text = ""
            End If
        End If
    End Sub

    Private Sub TreeList1_AfterFocusNode(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs)
        If Entrar = True Then
            pos = e.Node.Id
            If Me.ToolBarNuevo.Text = "Cancelar" Then
                Try
                    If TreeList1.FindNodeByID(pos).HasChildren Then
                        nuevo_nodo(True)
                    Else
                        nuevo_nodo(False)
                    End If
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                txtCuenta.Text = cuenta
                txtCuentaMadre.Text = TreeList1.FindNodeByID(pos).Item("CuentaContable_Presupuestaria")
                txtDescripcionMadre.Text = TreeList1.FindNodeByID(pos).Item("DescCuentaMadre")
                txtNivel.Text = TreeList1.FindNodeByID(pos).Level + 1
            End If
        End If
    End Sub

    Private Sub txtCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuenta.KeyDown
        Try


            If e.KeyCode = Keys.Enter Then
                '
                Dim Cx As New Conexion
                Dim valida As String
                Dim num_cuenta As String = txtCuenta.Text
                Dim cont As Integer
                cont = 0
                Dim numero As String : Dim leng As Integer : Dim x As Integer

                Dim ee As Array = num_cuenta.ToCharArray
                leng = num_cuenta.Length
                ' CUENTA EL # DE ARREGLOS EN LA CUENTA
                For x = 0 To leng - 1
                    If ee(x) = "-" Then
                        cont = cont + 1
                    End If
                Next
                '*************************************
                'DETERMINA EL NIVEL DE LA CUENTA
                Dim ii As Array = num_cuenta.Split("-")
                Dim nn As Integer
                Dim val As String
                Dim nivel As Integer = 0
                Dim str As String : Dim lon As Integer : Dim xx As Integer
                For nn = 1 To cont '
                    val = ""
                    str = ii(nn)
                    lon = str.Length
                    For xx = 0 To lon - 1
                        val = val + "0"
                    Next
                    If str <> val Then
                        nivel = nivel + 1
                    End If
                Next
                Me.txtNivel.Text = nivel
                '********************************
                ' SE VALIDA SI LA CUENTA DIGITADA EXISTE
                Dim conn As New Conexion
                Dim cuenta As String
                Dim Num_Cuentas As String = Me.txtCuenta.Text
                cuenta = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable_Presupuestaria WHERE (CuentaContable = '" & Num_Cuentas & "' ) ")
                Cx.DesConectar(Cx.sQlconexion)
                If cuenta = 0 Then ' SI NO EXISTE
                    If nivel = 0 Then ' SI ES UNA CUENTA DE NIVEL 0
                        Me.txtCuentaMadre.Text = Me.txtCuenta.Text
                        Me.cmbMovimiento.Text = "NO"
                        txtDescripcion.Focus()
                    Else ' SI NO
                        If nivel = cont Then ' SE INICIA LA VALIDACION DE LA CUENTA MADRE
                            Dim ll As Integer : Dim str1 As String : Dim ee1 As Integer
                            Dim comp As String = ""
                            str1 = ii(cont)
                            ll = str1.Length
                            For ee1 = 1 To ll
                                comp = comp + "0"
                            Next
                            numero = Mid(num_cuenta, 1, leng - ll)
                            numero = numero + comp
                            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable_Presupuestaria WHERE CuentaContable= '" & numero & "'")
                            Cx.DesConectar(Cx.sQlconexion)
                            If valida = "" Then
                                MessageBox.Show("La cuenta digitada no posee una cuenta madre..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtCuenta.Focus()
                            Else
                                Dim nombre As String
                                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable_Presupuestaria WHERE CuentaContable= '" & numero & "'")
                                Cx.DesConectar(Cx.sQlconexion)
                                Me.txtDescripcionMadre.Text = nombre
                                Me.txtCuentaMadre.Text = numero
                                txtDescripcion.Focus()
                            End If
                        Else
                            Dim uu As Integer : Dim cuent As String : Dim cuent1 As String : Dim mm As Integer
                            For uu = 0 To nivel - 1
                                If uu = 0 Then
                                    cuent = ii(uu)
                                Else
                                    cuent = cuent + "-" + ii(uu)
                                End If
                            Next

                            For mm = nivel To cont
                                Dim str2 As String : Dim ll1, ee2 As Integer
                                Dim comp As String = ""
                                str2 = ii(mm)
                                ll1 = str2.Length
                                For ee2 = 1 To ll1
                                    comp = comp + "0"
                                Next
                                If mm = nivel Then
                                    cuent1 = comp
                                Else
                                    cuent1 = cuent1 + "-" + comp
                                End If
                            Next
                            '

                            Dim validar As String
                            validar = cuent + "-" + cuent1
                            valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable_Presupuestaria WHERE CuentaContable= '" & validar & "'")
                            Cx.DesConectar(Cx.sQlconexion)
                            If valida = "" Then
                                MessageBox.Show("La cuenta digitada no posee una cuenta madre..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                                Me.txtCuenta.Focus()
                            Else
                                Dim nombre As String
                                nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable_Presupuestaria WHERE CuentaContable= '" & validar & "'")
                                Cx.DesConectar(Cx.sQlconexion)
                                Me.txtDescripcionMadre.Text = nombre
                                Me.txtCuentaMadre.Text = valida
                                txtDescripcion.Focus()
                            End If
                        End If

                    End If

                Else ' SI EXISTE ENTONCES
                    txtCuenta.Focus()
                    MsgBox("La cuenta digitada ya existe...", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmbMovimiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMovimiento.KeyDown
        If e.KeyCode = Keys.Enter Then
            'cmbTipo.Focus()
            txtCuentaMadre.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmbMovimiento.Focus()
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If Editando = 1 Then
                ButAgregarDetalle.Focus()
            Else
                'ckTipoCompra.Focus()
            End If
        End If
    End Sub


    Private Sub txtCuentaMadre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaMadre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim funcion As New cFunciones
            Dim Id, n As Integer
            Dim Cuenta As String
            funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaCuenta, Me.SqlConnection1.ConnectionString)
            For n = 0 To Me.TablaCuenta.Rows.Count - 1
                If Me.txtCuentaMadre.Text = TablaCuenta.Rows(n).Item("CuentaContable") Then
                    txtDescripcionMadre.Text = TablaCuenta.Rows(n).Item("Descripcion")
                    ButAgregarDetalle.Focus()
                    Exit Sub
                End If
            Next
            If cmbMovimiento.Text = "NO" And txtCuentaMadre.Text = txtCuenta.Text Then
                txtDescripcionMadre.Text = txtDescripcion.Text
                ButAgregarDetalle.Focus()
                Exit Sub
            End If
            If cmbMovimiento.Text <> "NO" And txtCuentaMadre.Text <> txtCuenta.Text Then
                MsgBox("La Cuenta Madre Digitada No Es Valida, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")
                txtCuentaMadre.Focus()
                Exit Sub
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            LlamarFmrBuscarAsientoVenta()
            ButAgregarDetalle.Focus()
        End If
    End Sub


    Private Sub txtDescripcionMadre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDescripcionMadre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.ButAgregarDetalle.Focus()
        End If
    End Sub


    Private Sub ButAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAgregarDetalle.Click
        If Me.txtNivel.Text = 0 And Me.cmbMovimiento.Text = "NO" And Me.txtCuenta.Text = Me.txtCuentaMadre.Text Then
            If Me.txtNivel.Text = 0 And Me.cmbMovimiento.Text = "SÍ" Then
                MsgBox("Una cuenta madre no puede tener movimiento...")
                Exit Sub
            End If
            CargarDatos()
            Exit Sub
        End If
        CargarDatos()
    End Sub


    Private Sub ButNuevoDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButNuevoDetalle.Click
        Editando = 0
        If ButNuevoDetalle.Text = "Nueva Cuenta" Then
            ButNuevoDetalle.ImageIndex = 1
            ButNuevoDetalle.Text = "Cancelar"
            cuenta = ""
            txtCuenta.Focus()
            Limpiar()
            Mascaras()
            txtCuentaMadre.Text = cuenta
            txtCuenta.Text = cuenta
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").AddNew()
            DESBLOQUEAR()
            'cbTipoCuenta.Visible = False
            pnlControles.Enabled = True
            txtDescripcionMadre.ReadOnly = True
            ButAgregarDetalle.Enabled = True
            TreeList1.Enabled = False
            txtCuenta.Focus() '<<<<
        Else
            ButNuevoDetalle.Text = "Nueva Cuenta"
            ButNuevoDetalle.ImageIndex = 2
            Limpiar()
            'ckTipoCompra.Checked = False : cbTipoCuenta.Visible = False
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").CancelCurrentEdit()
            ToolBarRegistrar.Enabled = False
            ButAgregarDetalle.Enabled = False
            BLOQUEAR()
            TreeList1.Enabled = True
        End If
    End Sub


    Private Sub txtCuentaMadre_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaMadre.EditValueChanged
        Dim cnx As New Conexion
        Dim cuenta As String
        Dim Num_Cuentas As String = Me.txtCuentaMadre.Text
        cuenta = cnx.SlqExecuteScalar(cnx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable_Presupuestaria WHERE (CuentaContable = '" & Num_Cuentas & "' ) ")
        cnx.DesConectar(cnx.sQlconexion)
        If cuenta = "" Then
            txtDescripcionMadre.Text = ""
        End If
    End Sub


    Private Sub TreeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeList1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim funcion As New cFunciones
            Dim Id, n As Integer
            Dim Cuenta As String
            funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaEliminar, Me.SqlConnection1.ConnectionString)
            For n = 0 To TablaEliminar.Rows.Count - 1
                If TablaEliminar.Rows(Reporte_ID).Item("id") = TablaEliminar.Rows(n).Item("PARENTID") Then
                    MessageBox.Show("Esta Cuenta Con Cuentas Hijas, Revise", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            Next
            Elimina()
        End If
        If e.KeyCode = Keys.F1 Then
            Buscar()
            BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Position = Posicion
        End If
    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged
        Try
            If e.Node.Id = Nothing Then
            Else
                Reporte_ID = e.Node.Id
            End If
            If e.Node.Id = 0 Then
                Reporte_ID = e.Node.Id
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick
        Dim funcion As New cFunciones
        Dim Id, n, k, x, m, z As Integer
        Dim mov, Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaNiveles, Me.SqlConnection1.ConnectionString)
        '
        If TablaNiveles.Rows(Reporte_ID).Item("Movimiento") = False Then
            mov = "NO"
        End If
        If TablaNiveles.Rows(Reporte_ID).Item("Movimiento") = True Then
            mov = "Sí"
        End If
        '
        Mascaras()
        txtCuenta.Text = TablaNiveles.Rows(Reporte_ID).Item("CuentaContable")
        txtDescripcion.Text = TablaNiveles.Rows(Reporte_ID).Item("Descripcion")
        txtNivel.Text = TablaNiveles.Rows(Reporte_ID).Item("Nivel")
        cmbMovimiento.Text = mov '<<<
        'cmbTipo.Text = TablaNiveles.Rows(Reporte_ID).Item("Tipo")
        txtCuentaMadre.Text = TablaNiveles.Rows(Reporte_ID).Item("CuentaMadre")
        txtDescripcionMadre.Text = TablaNiveles.Rows(Reporte_ID).Item("DescCuentaMadre")
        'CheckBox1.Checked = TablaNiveles.Rows(Reporte_ID).Item("Evaluacion")
        Editando = 1
        Me.ButNuevoDetalle.ImageIndex = 1 '<<<
        Me.ButNuevoDetalle.Text = "Cancelar" '<<<
        Me.Editar()
    End Sub


    Private Sub txtCuenta_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCuenta.Click
        Mascaras()
    End Sub


    Private Sub txtDescripcion_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescripcion.GotFocus
        Try
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = txtCuenta.Text
            Dim cont As Integer
            cont = 0
            Dim numero As String : Dim leng As Integer : Dim x As Integer

            Dim ee As Array = num_cuenta.ToCharArray
            leng = num_cuenta.Length
            ' CUENTA EL # DE ARREGLOS EN LA CUENTA
            For x = 0 To leng - 1
                If ee(x) = "-" Then
                    cont = cont + 1
                End If
            Next
            '*************************************
            'DETERMINA EL NIVEL DE LA CUENTA
            Dim ii As Array = num_cuenta.Split("-")
            Dim nn As Integer
            Dim val As String
            Dim nivel As Integer = 0
            Dim str As String : Dim lon As Integer : Dim xx As Integer
            For nn = 1 To cont '
                val = ""
                str = ii(nn)
                lon = str.Length
                For xx = 0 To lon - 1
                    val = val + "0"
                Next
                If str <> val Then
                    nivel = nivel + 1
                End If
            Next
            Me.txtNivel.Text = nivel

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbTipoCuenta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtCuentaMadre.Focus()
        End If
    End Sub
#End Region

#Region "Validar"
    Function Validar()
        If Me.txtCuenta.Text = "" Then
            MsgBox("Digite el Número de Cuenta", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf cmbMovimiento.Text = "" Then
            MsgBox("Seleccione el Movimiento", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf txtDescripcion.Text = "" Then
            MsgBox("Digite la Descripción de la Cuenta", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        ElseIf txtCuentaMadre.Text = "" Then
            MsgBox("Seleccione la Cuenta Madre", MsgBoxStyle.Exclamation, "Seepos")
            Return False
        Else : Return True
        End If
    End Function


    Function ValidarNumeroCuenta()
        Dim funcion As New cFunciones
        Dim Id, n As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaCuentas, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaCuentas.Rows.Count - 1
            If Me.txtCuenta.Text = TablaCuentas.Rows(n).Item("CuentaContable") Then
                Return False
                Exit Function
            End If
        Next
        Return True
    End Function


    Function RevisarCodigoCuenta()
        Dim i As Integer

        For i = 0 To Me.TablaCuentas.Rows.Count - 1
            If Me.txtCuentaMadre.Text = TablaCuentas.Rows(i).Item("CuentaContable") Then
                TxtPadre.Text = TablaCuentas.Rows(i).Item("id")
                Exit Function
            Else
                'Return True
            End If
        Next
    End Function


    Function RevisarPadre()
        Dim n As Integer
        For n = 0 To Me.TablaCuentas.Rows.Count - 1
            If Me.TxtPadre.Text = TablaCuentas.Rows(n).Item("id") Then
                If TablaCuentas.Rows(n).Item("Movimiento") = True Then
                    Return False
                    Exit Function
                End If
            End If
        Next
        Return True
    End Function
#End Region

#Region "Funciones"
    Function AsignarNivel()
        Dim funcion As New cFunciones
        Dim Id, n, k, x, m, z As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaNiveles, Me.SqlConnection1.ConnectionString)
        If TablaNiveles.Rows.Count < 0 Then
            ContadorNivel = 0
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nivel") = ContadorNivel
            txtNivel.Text = ContadorNivel
            Exit Function
        End If
        For n = 0 To Me.TablaNiveles.Rows.Count - 1
            h = n
            If Me.TxtPadre.Text = TablaNiveles.Rows(n).Item("id") Then
                m = 1
            End If
            If Me.TxtPadre.Text <> TablaNiveles.Rows(n).Item("id") And m <> 1 Then
                ContadorNivel = 0
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nivel") = ContadorNivel
                txtNivel.Text = ContadorNivel
            End If
        Next
        For n = 0 To Me.TablaNiveles.Rows.Count - 1
            If Me.TxtPadre.Text = TablaNiveles.Rows(n).Item("id") Then
                Padre = TablaNiveles.Rows(n).Item("id")
            End If
        Next
        For k = 0 To Me.TablaNiveles.Rows.Count - 1
            If r = 2 Then
                r = 0
                Exit Function
            End If
            If r = 1 Then
                k = 0
                r = 0
            End If
            If Padre = TablaNiveles.Rows(k).Item("id") Then
                ContadorNivel = ContadorNivel + 1
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = Padre
                Padre = TablaNiveles.Rows(k).Item("PARENTID")
                s = k
                Calc()
                k = 0
            End If
        Next

        Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nivel") = ContadorNivel
        txtNivel.Text = ContadorNivel
        ContadorNivel = 0
    End Function


    Function Calc()
        Dim x, a As Integer
        For x = 0 To Me.TablaNiveles.Rows.Count - 1
            If s = x Then
            Else
                If Padre = TablaNiveles.Rows(x).Item("id") Then
                    a = 1
                End If
                If Padre <> TablaNiveles.Rows(x).Item("id") And x = h And a <> 1 Then
                    Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nivel") = ContadorNivel
                    txtNivel.Text = ContadorNivel
                    ContadorNivel = 0
                    r = 2
                    Exit Function
                Else

                End If
            End If
        Next
        r = 1
    End Function


    Function VerificaHijos()
        Dim funcion As New cFunciones
        Dim Id, n As Integer
        Dim Cuenta As String
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaCuentas, Me.SqlConnection1.ConnectionString)
        For n = 0 To Me.TablaCuentas.Rows.Count - 1
            If n <> Reporte_ID Then
                If Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("id") = TablaCuentas.Rows(n).Item("PARENTID") Then
                    Return False
                    Exit Function
                End If
            End If
        Next

        Return True
    End Function


    Function CargarDatos()
        If Validar() Then
            Try
                If Editando <> 1 Then
                    If ValidarNumeroCuenta() Then
                    Else
                        MsgBox("El Número De Cuenta Ya Existe, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")
                        txtCuenta.Text = ""
                        txtCuenta.Focus()
                        Exit Function
                    End If
                End If
                If Editando = 1 Then
                    If VerificaHijos() Then
                    Else
                        If MessageBox.Show("Esta es una cuenta madre y posee cuentas hijas, desea modificarla", "Sistema SeeSoft", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                            If cmbMovimiento.Text = "SÍ" Then
                                MessageBox.Show("Una Cuenta Madre no puede tener Movimiento, Se desactivara Automaticamente", "Sistema SeeSoft", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Movimiento") = False
                                'CheckBox1.Checked = False
                            End If
                            BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Descripcion") = txtDescripcion.Text
                            BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Nombre_Usuario") = Usuario.Nombre
                            'BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("Tipo") = cmbTipo.Text




                            Dim trans As SqlTransaction
                            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
                            trans = Me.SqlConnection1.BeginTransaction
                            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()
                            Me.AdapterCuentasContables.InsertCommand.Transaction = trans
                            Me.AdapterCuentasContables.UpdateCommand.Transaction = trans
                            Me.AdapterCuentasContables.DeleteCommand.Transaction = trans
                            Me.AdapterCuentasContables.Update(Me.DataSetCuentasContables1.CuentaContable_Presupuestaria)
                            Me.DataSetCuentasContables1.AcceptChanges()
                            trans.Commit()
                            Me.DataSetCuentasContables1.CuentaContable_Presupuestaria.Clear()
                            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable_Presupuestaria)
                            BLOQUEAR()
                            ButNuevoDetalle.Text = "Nueva Cuenta"
                            ButNuevoDetalle.ImageIndex = "2"
                            ButAgregarDetalle.Enabled = False
                        End If
                        cmbMovimiento.Focus()
                        Exit Function
                    End If
                Else
                    '
                    Dim dt As New DataTable
                    cFunciones.Llenar_Tabla_Generico("select  id from CuentaContable_Presupuestaria WHERE CuentaContable = '" & txtCuentaMadre.Text & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
                    If dt.Rows.Count > 0 Then '
                        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = dt.Rows(0).Item("id")
                        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()
                        'Padre = dt.Rows(0).Item("id")
                        'BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = 2

                    Else ' ID = 0
                        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Current("PARENTID") = 0
                        BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()

                    End If
                End If

                RevisarCodigoCuenta()
                If RevisarPadre() Then
                Else
                    MsgBox("La Cuenta Madre Seleccionada No Es Valida, Favor Revisar", MsgBoxStyle.Information, "Sistema SeeSoft")
                    txtCuentaMadre.Text = ""
                    txtDescripcionMadre.Text = ""
                    txtCuentaMadre.Focus()
                    Exit Function
                End If
                AsignarNivel()
                llenar_campos()
                posi = BindingContext(DataSetCuentasContables1, "CuentaContable_Presupuestaria").Position

                Me.ToolBar1.Buttons(2).Enabled = True
                Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable_Presupuestaria").EndCurrentEdit()
                registrar()
                BLOQUEAR()
                ButNuevoDetalle.Text = "Nueva Cuenta"
                ButNuevoDetalle.ImageIndex = "2"
                ButAgregarDetalle.Enabled = False

            Catch ex As System.Exception
                Me.ToolBar1.Buttons(3).Enabled = True
                MsgBox(ex.Message)
            End Try
        End If
    End Function

    Private Sub Mascaras()
        Try
            cuenta = "4"
            Mascara = "#"
            For i As Integer = 0 To n1 - 2
                cuenta += "0"
                Mascara += "#"
            Next
            If n2 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n2 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n3 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n3 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n4 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n4 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n5 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n5 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n6 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n6 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n7 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n7 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            If n8 <> 0 Then
                cuenta += separador
                Mascara += "-"
            End If
            For i As Integer = 0 To n8 - 1
                cuenta += "0"
                Mascara += "#"
            Next
            txtNivel.Text = 0
            Me.txtCuenta.Properties.MaskData.EditMask = Mascara
            Me.txtCuentaMadre.Properties.MaskData.EditMask = Mascara

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Elimina"
    Private Function Elimina()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String
        'Dim TBL_DataSetCuentasContables1 As DataTable
        'TBL_DataSetCuentasContables1 = DataSetCuentasContables1.Tables(0)
        'MsgBox("" & TBL_DataSetCuentasContables1.Rows(Reporte_ID).Item("Movimiento"))

        Dim funcion As New cFunciones
        funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaNiveles, Me.SqlConnection1.ConnectionString)
        Dim ptxtCuenta As String = TablaNiveles.Rows(Reporte_ID).Item("CuentaContable")
        Dim ptxtCuentaDescripcion As String = TablaNiveles.Rows(Reporte_ID).Item("Descripcion")
        If MessageBox.Show(" ¿ Desea Eliminar Esta Cuenta ? " & ptxtCuentaDescripcion, "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Function

        RutinaEliminar(ptxtCuenta)

        'Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").RemoveAt(Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").Position)
        'Me.RegistraEliminar()
        'If Resultado = vbNullString Then
        '    MessageBox.Show("La Cuenta Fue Eliminada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Me.Limpiar()
        'Else
        '    MessageBox.Show(Resultado)
        '    Exit Function
        'End If
    End Function

    Sub RutinaEliminar(ByVal txtidCuenta As String)
        Try
            ''''Anulado(1)
            ''''No Anulado(0)
            'If (IdP2 <> "") Then
            'Dim Resultado As Integer = 0
            'Resultado = MsgBox("Eata seguro que si desea Anular este Presupuesto", MsgBoxStyle.OKCancel, "Anular")
            'If (Resultado = 1) Then
            Dim up As String = "DELETE FROM CuentaContable_Presupuestaria where CuentaContable ='" & txtidCuenta & "'"
            Dim cnx As New Conexion
            cnx.Conectar("SeeSoft", "Contabilidad")
            cnx.SlqExecute(cnx.sQlconexion, up)
            MsgBox("Cuenta Eliminada", MsgBoxStyle.Information, "Cuenta Eliminada")
            'End If
            'Else
            '    MsgBox("Debe seleccionar Un presupuesto a Anular")
            'End If


            Me.DataSetCuentasContables1.CuentaContable_Presupuestaria.Clear()
            Me.AdapterCuentasContables.Fill(Me.DataSetCuentasContables1.CuentaContable_Presupuestaria)
            Me.Limpiar()
            'Dim funcion As New cFunciones

            'funcion.Llenar_Tabla_Generico("Select * from CuentaContable_Presupuestaria", Me.TablaNiveles, Me.SqlConnection1.ConnectionString)
            ''Dim ptxtCuenta As String = TablaNiveles.Rows(Reporte_ID).Item("CuentaContable")
            'TreeList1.DataSource = Me.TablaNiveles.DataSet
            'FrmCargarLoad()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Function RegistraEliminar() As Boolean
        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            Me.AdapterCuentasContables.InsertCommand.Transaction = Trans
            Me.AdapterCuentasContables.UpdateCommand.Transaction = Trans
            Me.AdapterCuentasContables.DeleteCommand.Transaction = Trans
            Me.AdapterCuentasContables.SelectCommand.Transaction = Trans
            Me.BindingContext(Me.DataSetCuentasContables1, "CuentaContable").EndCurrentEdit()
            Me.AdapterCuentasContables.Update(Me.DataSetCuentasContables1, "CuentaContable")
            Trans.Commit()

            Me.ToolBar1.Buttons(0).Text = "Nuevo"
            Me.ToolBar1.Buttons(0).ImageIndex = 0
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox("No se puede eliminar, o error de red", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            Me.ToolBar1.Buttons(2).Enabled = True
            Return False
        End Try
    End Function
#End Region

    Private Sub AdapterCuentasContables_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles AdapterCuentasContables.RowUpdated

    End Sub

    Private Sub txtCuenta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuenta.EditValueChanged

    End Sub

    Private Sub pnlControles_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlControles.Paint

    End Sub
End Class
