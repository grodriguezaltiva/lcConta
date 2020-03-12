Imports Utilidades
Imports System.Data.SqlClient

Public Class FrmDistribucionIngresos
    Inherits FrmPlantilla   'System.Windows.Forms.Form
    Private sqlConexion As SqlConnection
    Public CConexion As New Conexion
    Dim usua As Usuario_Logeado
    'Dim ii As Integer
    Dim NuevaConexion As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciaBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LCIngreso As System.Windows.Forms.Label
    Friend WithEvents TextBoxIngreso As System.Windows.Forms.TextBox
    Friend WithEvents LDIngreso As System.Windows.Forms.Label
    Friend WithEvents LDCosto As System.Windows.Forms.Label
    Friend WithEvents TextBoxCosto As System.Windows.Forms.TextBox
    Friend WithEvents LCostoVenta As System.Windows.Forms.Label
    Friend WithEvents AdapterDistribucion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsDistribucionIngresos As Contabilidad.DsDistribucionIngresos
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmDistribucionIngresos))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExistenciaBodega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextBoxNombre = New System.Windows.Forms.TextBox
        Me.DsDistribucionIngresos = New Contabilidad.DsDistribucionIngresos
        Me.LNombre = New System.Windows.Forms.Label
        Me.LCIngreso = New System.Windows.Forms.Label
        Me.TextBoxIngreso = New System.Windows.Forms.TextBox
        Me.LDIngreso = New System.Windows.Forms.Label
        Me.LDCosto = New System.Windows.Forms.Label
        Me.TextBoxCosto = New System.Windows.Forms.TextBox
        Me.LCostoVenta = New System.Windows.Forms.Label
        Me.AdapterDistribucion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsDistribucionIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(490, 24)
        Me.TituloModulo.Text = "Distribucion de Ingresos"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 116)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(490, 52)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colExistenciaBodega})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 73
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 356
        '
        'colExistenciaBodega
        '
        Me.colExistenciaBodega.Caption = "Existencia"
        Me.colExistenciaBodega.FieldName = "Existencia"
        Me.colExistenciaBodega.Name = "colExistenciaBodega"
        Me.colExistenciaBodega.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExistenciaBodega.VisibleIndex = 2
        Me.colExistenciaBodega.Width = 101
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDistribucionIngresos, "DistribucionIngresos.Nombre"))
        Me.TextBoxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(10, 48)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(486, 13)
        Me.TextBoxNombre.TabIndex = 1
        Me.TextBoxNombre.Text = ""
        '
        'DsDistribucionIngresos
        '
        Me.DsDistribucionIngresos.DataSetName = "DsDistribucionIngresos"
        Me.DsDistribucionIngresos.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'LNombre
        '
        Me.LNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNombre.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.Blue
        Me.LNombre.Location = New System.Drawing.Point(10, 32)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(486, 16)
        Me.LNombre.TabIndex = 90
        Me.LNombre.Text = "Nombre"
        '
        'LCIngreso
        '
        Me.LCIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCIngreso.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LCIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCIngreso.ForeColor = System.Drawing.Color.Blue
        Me.LCIngreso.Location = New System.Drawing.Point(8, 72)
        Me.LCIngreso.Name = "LCIngreso"
        Me.LCIngreso.Size = New System.Drawing.Size(96, 16)
        Me.LCIngreso.TabIndex = 95
        Me.LCIngreso.Text = "Cuenta Ingreso"
        '
        'TextBoxIngreso
        '
        Me.TextBoxIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxIngreso.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxIngreso.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDistribucionIngresos, "DistribucionIngresos.Cuenta_Ingreso"))
        Me.TextBoxIngreso.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.TextBoxIngreso.Location = New System.Drawing.Point(112, 72)
        Me.TextBoxIngreso.Name = "TextBoxIngreso"
        Me.TextBoxIngreso.Size = New System.Drawing.Size(120, 13)
        Me.TextBoxIngreso.TabIndex = 98
        Me.TextBoxIngreso.Text = ""
        '
        'LDIngreso
        '
        Me.LDIngreso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LDIngreso.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LDIngreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDistribucionIngresos, "DistribucionIngresos.NCuenta_Ingreso"))
        Me.LDIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDIngreso.ForeColor = System.Drawing.Color.DarkBlue
        Me.LDIngreso.Location = New System.Drawing.Point(240, 72)
        Me.LDIngreso.Name = "LDIngreso"
        Me.LDIngreso.Size = New System.Drawing.Size(248, 16)
        Me.LDIngreso.TabIndex = 99
        '
        'LDCosto
        '
        Me.LDCosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LDCosto.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LDCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDistribucionIngresos, "DistribucionIngresos.NCuenta_CostoV"))
        Me.LDCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDCosto.ForeColor = System.Drawing.Color.DarkBlue
        Me.LDCosto.Location = New System.Drawing.Point(240, 96)
        Me.LDCosto.Name = "LDCosto"
        Me.LDCosto.Size = New System.Drawing.Size(248, 16)
        Me.LDCosto.TabIndex = 102
        '
        'TextBoxCosto
        '
        Me.TextBoxCosto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCosto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCosto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCosto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsDistribucionIngresos, "DistribucionIngresos.Cuenta_CostoV"))
        Me.TextBoxCosto.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.TextBoxCosto.Location = New System.Drawing.Point(112, 96)
        Me.TextBoxCosto.Name = "TextBoxCosto"
        Me.TextBoxCosto.Size = New System.Drawing.Size(120, 13)
        Me.TextBoxCosto.TabIndex = 101
        Me.TextBoxCosto.Text = ""
        '
        'LCostoVenta
        '
        Me.LCostoVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCostoVenta.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LCostoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCostoVenta.ForeColor = System.Drawing.Color.Blue
        Me.LCostoVenta.Location = New System.Drawing.Point(8, 96)
        Me.LCostoVenta.Name = "LCostoVenta"
        Me.LCostoVenta.Size = New System.Drawing.Size(96, 16)
        Me.LCostoVenta.TabIndex = 100
        Me.LCostoVenta.Text = "Cuenta Costo Venta"
        '
        'AdapterDistribucion
        '
        Me.AdapterDistribucion.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterDistribucion.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterDistribucion.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterDistribucion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DistribucionIngresos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Cuenta_Ingreso", "Cuenta_Ingreso"), New System.Data.Common.DataColumnMapping("Cuenta_CostoV", "Cuenta_CostoV"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("NCuenta_Ingreso", "NCuenta_Ingreso"), New System.Data.Common.DataColumnMapping("NCuenta_CostoV", "NCuenta_CostoV")})})
        Me.AdapterDistribucion.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM DistribucionIngresos WHERE (Id = @Original_Id) AND (Cuenta_CostoV = @" & _
        "Original_Cuenta_CostoV) AND (Cuenta_Ingreso = @Original_Cuenta_Ingreso) AND (NCu" & _
        "enta_CostoV = @Original_NCuenta_CostoV) AND (NCuenta_Ingreso = @Original_NCuenta" & _
        "_Ingreso) AND (Nombre = @Original_Nombre)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_CostoV", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_CostoV", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Ingreso", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NCuenta_CostoV", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCuenta_CostoV", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NCuenta_Ingreso", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCuenta_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO DistribucionIngresos(Nombre, Cuenta_Ingreso, Cuenta_CostoV, NCuenta_I" & _
        "ngreso, NCuenta_CostoV) VALUES (@Nombre, @Cuenta_Ingreso, @Cuenta_CostoV, @NCuen" & _
        "ta_Ingreso, @NCuenta_CostoV); SELECT Nombre, Cuenta_Ingreso, Cuenta_CostoV, Id, " & _
        "NCuenta_Ingreso, NCuenta_CostoV FROM DistribucionIngresos WHERE (Id = @@IDENTITY" & _
        ")"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Ingreso", System.Data.SqlDbType.VarChar, 255, "Cuenta_Ingreso"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_CostoV", System.Data.SqlDbType.VarChar, 255, "Cuenta_CostoV"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NCuenta_Ingreso", System.Data.SqlDbType.VarChar, 250, "NCuenta_Ingreso"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NCuenta_CostoV", System.Data.SqlDbType.VarChar, 250, "NCuenta_CostoV"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Nombre, Cuenta_Ingreso, Cuenta_CostoV, Id, NCuenta_Ingreso, NCuenta_CostoV" & _
        " FROM DistribucionIngresos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE DistribucionIngresos SET Nombre = @Nombre, Cuenta_Ingreso = @Cuenta_Ingres" & _
        "o, Cuenta_CostoV = @Cuenta_CostoV, NCuenta_Ingreso = @NCuenta_Ingreso, NCuenta_C" & _
        "ostoV = @NCuenta_CostoV WHERE (Id = @Original_Id) AND (Cuenta_CostoV = @Original" & _
        "_Cuenta_CostoV) AND (Cuenta_Ingreso = @Original_Cuenta_Ingreso) AND (NCuenta_Cos" & _
        "toV = @Original_NCuenta_CostoV) AND (NCuenta_Ingreso = @Original_NCuenta_Ingreso" & _
        ") AND (Nombre = @Original_Nombre); SELECT Nombre, Cuenta_Ingreso, Cuenta_CostoV," & _
        " Id, NCuenta_Ingreso, NCuenta_CostoV FROM DistribucionIngresos WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 250, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_Ingreso", System.Data.SqlDbType.VarChar, 255, "Cuenta_Ingreso"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta_CostoV", System.Data.SqlDbType.VarChar, 255, "Cuenta_CostoV"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NCuenta_Ingreso", System.Data.SqlDbType.VarChar, 250, "NCuenta_Ingreso"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NCuenta_CostoV", System.Data.SqlDbType.VarChar, 250, "NCuenta_CostoV"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_CostoV", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_CostoV", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta_Ingreso", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NCuenta_CostoV", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCuenta_CostoV", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NCuenta_Ingreso", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NCuenta_Ingreso", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'FrmDistribucionIngresos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(221, Byte), CType(221, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(490, 168)
        Me.Controls.Add(Me.LDCosto)
        Me.Controls.Add(Me.TextBoxCosto)
        Me.Controls.Add(Me.LCostoVenta)
        Me.Controls.Add(Me.LDIngreso)
        Me.Controls.Add(Me.TextBoxIngreso)
        Me.Controls.Add(Me.LCIngreso)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.MaximizeBox = True
        Me.Name = "FrmDistribucionIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Distribución de Ingresos"
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNombre, 0)
        Me.Controls.SetChildIndex(Me.LNombre, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.LCIngreso, 0)
        Me.Controls.SetChildIndex(Me.TextBoxIngreso, 0)
        Me.Controls.SetChildIndex(Me.LDIngreso, 0)
        Me.Controls.SetChildIndex(Me.LCostoVenta, 0)
        Me.Controls.SetChildIndex(Me.TextBoxCosto, 0)
        Me.Controls.SetChildIndex(Me.LDCosto, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsDistribucionIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmDistribucionIngresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = IIf(NuevaConexion = "", Configuracion.Claves.Conexion("Contabilidad"), NuevaConexion)
            Me.AdapterDistribucion.Fill(Me.DsDistribucionIngresos.DistribucionIngresos)
            Limpia()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0 : NuevaEntrada()
                Case 1 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 2
                    If PMU.Update Then
                        ActualizarDistribucionIngresos()
                        If MsgBox("Desea agregar una nueva Distribucion de Ingresos...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then NuevaEntrada() Else Limpia()
                    Else
                        MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 3
                    If PMU.Delete Then
                        EliminaDistribucionIngresos()
                    Else
                        MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 4
                    Try
                        If Me.BindingContext(Me.DsDistribucionIngresos.DistribucionIngresos).Count > 0 Then
                            If PMU.Print Then
                                Dim Visor As New frmVisorReportes
                                Dim ReporteDistribucion As New Reporte_DistribucionIngresos
                                CrystalReportsConexion2.LoadReportViewer2(Visor.rptViewer, ReporteDistribucion, , Me.SqlConnection1.ConnectionString)
                                Visor.rptViewer.ReportSource = ReporteDistribucion
                                Visor.Left = (Screen.PrimaryScreen.WorkingArea.Width - Visor.Width) \ 2
                                Visor.Top = (Screen.PrimaryScreen.WorkingArea.Height - Visor.Height) \ 2
                                Visor.MdiParent = Me.ParentForm
                                Visor.Show()

                            Else
                                MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                            End If
                        Else
                            MsgBox("No hay Distribucion de Ingresos registradas...", MsgBoxStyle.Information)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "")
                    End Try
                Case 6 : Me.Cerrar()
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Defecto()
        Me.DsDistribucionIngresos.DistribucionIngresos.NombreColumn.DefaultValue = ""
        Me.DsDistribucionIngresos.DistribucionIngresos.Cuenta_IngresoColumn.DefaultValue = ""
        Me.DsDistribucionIngresos.DistribucionIngresos.Cuenta_CostoVColumn.DefaultValue = ""
    End Sub

    Private Sub NuevaEntrada()
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            Me.TextBoxNombre.Enabled = True
            Me.TextBoxIngreso.Enabled = True
            Me.TextBoxCosto.Enabled = True
        Else
            Me.TextBoxNombre.Enabled = False
            Me.TextBoxIngreso.Enabled = False
            Me.TextBoxCosto.Enabled = False
        End If
        Me.NuevosDatos(Me.DsDistribucionIngresos, Me.DsDistribucionIngresos.DistribucionIngresos.ToString)
        Me.TextBoxNombre.Focus()
    End Sub

    Private Sub Limpia()
        Defecto()
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxIngreso.Enabled = False
        Me.TextBoxCosto.Enabled = False
        Me.TextBoxNombre.Text = ""
        Me.TextBoxIngreso.Text = ""
        Me.TextBoxCosto.Text = ""
        Me.LDIngreso.Text = ""
        Me.LDCosto.Text = ""
        Me.TextBoxNombre.Focus()
    End Sub

    Function ActualizarDistribucionIngresos()
        Dim nombre As String = Me.TextBoxNombre.Text
        'Dim Id As String = Me.TextBoxCodigo.Text
        Dim Ingreso As String = Me.TextBoxIngreso.Text
        Dim Costo As String = Me.TextBoxCosto.Text
        Dim actualizado As Integer

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'Finaliza la edición
            Me.AdapterDistribucion.UpdateCommand.Transaction = Trans
            Me.AdapterDistribucion.InsertCommand.Transaction = Trans
            Me.AdapterDistribucion.DeleteCommand.Transaction = Trans

            Me.BindingContext(Me.DsDistribucionIngresos, "DistribucionIngresos").EndCurrentEdit()
            Me.AdapterDistribucion.Update(Me.DsDistribucionIngresos, "DistribucionIngresos")

            Trans.Commit()
            Me.DsDistribucionIngresos.AcceptChanges()

            ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try

    End Function

    Private Sub EliminaDistribucionIngresos()
        If Me.BindingContext(Me.DsDistribucionIngresos, "DistribucionIngresos").Count > 0 Then
            Me.EliminarDatos(Me.AdapterDistribucion, Me.DsDistribucionIngresos, Me.DsDistribucionIngresos.DistribucionIngresos.ToString)
        End If
    End Sub

    Private Sub Buscar()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            If Me.BindingContext(Me.DsDistribucionIngresos, "DistribucionIngresos").Count > 0 Then
                Me.BindingContext(Me.DsDistribucionIngresos, "DistribucionIngresos").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
            End If

            valor = Fx.BuscarDatos("Select Id, Nombre from DistribucionIngresos", "Nombre", "Buscar Distribucion de Ingresos...", Me.SqlConnection1.ConnectionString)

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DsDistribucionIngresos.DistribucionIngresos.DefaultView
                vista.Sort = "Id"
                pos = vista.Find(CDbl(valor))
                Me.BindingContext(Me.DsDistribucionIngresos, "DistribucionIngresos").Position = pos
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "KeyDown"
    Private Sub TextBoxIngreso_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxIngreso.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
            " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            Me.TextBoxIngreso.Text = busca.codigo
            Me.LDIngreso.Text = busca.descrip
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = Me.TextBoxIngreso.Text
            valida = Cx.SQLExeScalar("SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TextBoxIngreso.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SQLExeScalar("SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.LDIngreso.Text = nombre
                Me.TextBoxCosto.Focus()
            End If
        End If
    End Sub

    Private Sub TextBoxCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxCosto.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim busca As New fmrBuscarMayorizacionAsiento
            busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
            busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
            " where Movimiento=1 "
            busca.campo = "descripcion"
            busca.sqlStringAdicional = " ORDER BY CuentaContable  "
            busca.ShowDialog()

            If busca.codigo Is Nothing Then Exit Sub

            Me.TextBoxCosto.Text = busca.codigo
            Me.LDCosto.Text = busca.descrip
        End If

        If e.KeyCode = Keys.Enter Then
            Dim Cx As New Conexion
            Dim valida As String
            Dim num_cuenta As String = Me.TextBoxCosto.Text
            valida = Cx.SQLExeScalar("SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
            Cx.DesConectar(Cx.sQlconexion)
            If valida = "" Then
                MessageBox.Show("La cuenta contable digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Me.TextBoxCosto.Focus()
            Else
                Dim nombre As String
                nombre = Cx.SQLExeScalar("SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.LDCosto.Text = nombre
            End If
        End If
    End Sub

    Private Sub TextBoxNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBoxIngreso.Focus()
        End If
    End Sub
#End Region

End Class
