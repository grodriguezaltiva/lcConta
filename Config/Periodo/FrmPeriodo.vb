Imports Utilidades
Imports System.Data.SqlClient

Public Class FrmPeriodo
    Inherits FrmPlantilla

    Dim usua As Usuario_Logeado
    Dim Nuevo As Boolean
    Friend WithEvents chbCerradoFinal As System.Windows.Forms.CheckBox
    Friend WithEvents lbPeriodoCodigo As System.Windows.Forms.Label
    Friend WithEvents btReversarCierre As System.Windows.Forms.Button
    Dim clave As String = ""

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
    Friend WithEvents LAnoo As System.Windows.Forms.Label
    Friend WithEvents LMes As System.Windows.Forms.Label
    Friend WithEvents CBMes As System.Windows.Forms.ComboBox
    Friend WithEvents NUDAnno As System.Windows.Forms.NumericUpDown
    Friend WithEvents AdapterPeriodo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents LabelUsuario As System.Windows.Forms.Label
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents DsPeriodo2 As Contabilidad.DsPeriodo
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CheckActivo As System.Windows.Forms.CheckBox
    Friend WithEvents CheckCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPeriodo))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExistenciaBodega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LAnoo = New System.Windows.Forms.Label
        Me.LMes = New System.Windows.Forms.Label
        Me.CBMes = New System.Windows.Forms.ComboBox
        Me.DsPeriodo2 = New Contabilidad.DsPeriodo
        Me.NUDAnno = New System.Windows.Forms.NumericUpDown
        Me.AdapterPeriodo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.LabelUsuario = New System.Windows.Forms.Label
        Me.TextUsuario = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.CheckCerrado = New System.Windows.Forms.CheckBox
        Me.CheckActivo = New System.Windows.Forms.CheckBox
        Me.chbCerradoFinal = New System.Windows.Forms.CheckBox
        Me.lbPeriodoCodigo = New System.Windows.Forms.Label
        Me.btReversarCierre = New System.Windows.Forms.Button
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPeriodo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'TituloModulo
        '
        Me.TituloModulo.Size = New System.Drawing.Size(406, 24)
        Me.TituloModulo.Text = "Periodo de Trabajo"
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Enabled = False
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Text = "Cerrar Periodo"
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.Enabled = False
        Me.ToolBarExcel.Text = "Editar"
        Me.ToolBarExcel.Visible = True
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 127)
        Me.ToolBar1.Size = New System.Drawing.Size(406, 52)
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
        Me.colCodigo.FilterInfo = ColumnFilterInfo1
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 73
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.FilterInfo = ColumnFilterInfo2
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 356
        '
        'colExistenciaBodega
        '
        Me.colExistenciaBodega.Caption = "Existencia"
        Me.colExistenciaBodega.FieldName = "Existencia"
        Me.colExistenciaBodega.FilterInfo = ColumnFilterInfo3
        Me.colExistenciaBodega.Name = "colExistenciaBodega"
        Me.colExistenciaBodega.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExistenciaBodega.VisibleIndex = 2
        Me.colExistenciaBodega.Width = 101
        '
        'LAnoo
        '
        Me.LAnoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LAnoo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnoo.ForeColor = System.Drawing.Color.Blue
        Me.LAnoo.Location = New System.Drawing.Point(176, 40)
        Me.LAnoo.Name = "LAnoo"
        Me.LAnoo.Size = New System.Drawing.Size(60, 16)
        Me.LAnoo.TabIndex = 168
        Me.LAnoo.Text = "Año"
        Me.LAnoo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LMes
        '
        Me.LMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMes.ForeColor = System.Drawing.Color.Blue
        Me.LMes.Location = New System.Drawing.Point(16, 40)
        Me.LMes.Name = "LMes"
        Me.LMes.Size = New System.Drawing.Size(139, 16)
        Me.LMes.TabIndex = 167
        Me.LMes.Text = "Mes"
        Me.LMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CBMes
        '
        Me.CBMes.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DsPeriodo2, "Periodo.Mes", True))
        Me.CBMes.DataSource = Me.DsPeriodo2.Meses
        Me.CBMes.DisplayMember = "Mes"
        Me.CBMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMes.Enabled = False
        Me.CBMes.Location = New System.Drawing.Point(16, 56)
        Me.CBMes.Name = "CBMes"
        Me.CBMes.Size = New System.Drawing.Size(139, 21)
        Me.CBMes.TabIndex = 1
        Me.CBMes.ValueMember = "Valor"
        '
        'DsPeriodo2
        '
        Me.DsPeriodo2.DataSetName = "DsPeriodo"
        Me.DsPeriodo2.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DsPeriodo2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NUDAnno
        '
        Me.NUDAnno.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPeriodo2, "Periodo.Anno", True))
        Me.NUDAnno.Enabled = False
        Me.NUDAnno.Location = New System.Drawing.Point(176, 56)
        Me.NUDAnno.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NUDAnno.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NUDAnno.Name = "NUDAnno"
        Me.NUDAnno.Size = New System.Drawing.Size(61, 20)
        Me.NUDAnno.TabIndex = 2
        Me.NUDAnno.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'AdapterPeriodo
        '
        Me.AdapterPeriodo.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterPeriodo.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterPeriodo.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterPeriodo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Periodo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Periodo", "Id_Periodo"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("Anno", "Anno"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Activo", "Activo"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("Id_PeriodoFiscal", "Id_PeriodoFiscal"), New System.Data.Common.DataColumnMapping("Cerrado", "Cerrado")})})
        Me.AdapterPeriodo.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id_Periodo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Activo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Activo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_PeriodoFiscal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PeriodoFiscal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cerrado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cerrado", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=25.127.5.89;Initial Catalog=Contabilidad;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.Int, 0, "Mes"), New System.Data.SqlClient.SqlParameter("@Anno", System.Data.SqlDbType.Int, 0, "Anno"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 0, "Estado"), New System.Data.SqlClient.SqlParameter("@Activo", System.Data.SqlDbType.Bit, 0, "Activo"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 0, "Periodo"), New System.Data.SqlClient.SqlParameter("@Id_PeriodoFiscal", System.Data.SqlDbType.Int, 0, "Id_PeriodoFiscal"), New System.Data.SqlClient.SqlParameter("@Cerrado", System.Data.SqlDbType.Bit, 0, "Cerrado")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     Id_Periodo, Mes, Anno, Estado, Activo, Periodo, Id_PeriodoFiscal, Cerr" & _
            "ado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         Periodo"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.Int, 0, "Mes"), New System.Data.SqlClient.SqlParameter("@Anno", System.Data.SqlDbType.Int, 0, "Anno"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 0, "Estado"), New System.Data.SqlClient.SqlParameter("@Activo", System.Data.SqlDbType.Bit, 0, "Activo"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 0, "Periodo"), New System.Data.SqlClient.SqlParameter("@Id_PeriodoFiscal", System.Data.SqlDbType.Int, 0, "Id_PeriodoFiscal"), New System.Data.SqlClient.SqlParameter("@Cerrado", System.Data.SqlDbType.Bit, 0, "Cerrado"), New System.Data.SqlClient.SqlParameter("@Original_Id_Periodo", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mes", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anno", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anno", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Activo", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Activo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Id_PeriodoFiscal", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_PeriodoFiscal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cerrado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cerrado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id_Periodo", System.Data.SqlDbType.BigInt, 8, "Id_Periodo")})
        '
        'LabelUsuario
        '
        Me.LabelUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(263, 159)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(137, 16)
        Me.LabelUsuario.TabIndex = 170
        '
        'TextUsuario
        '
        Me.TextUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsuario.Location = New System.Drawing.Point(319, 143)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextUsuario.Size = New System.Drawing.Size(80, 13)
        Me.TextUsuario.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(263, 143)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckCerrado
        '
        Me.CheckCerrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CheckCerrado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPeriodo2, "Periodo.Estado", True))
        Me.CheckCerrado.Enabled = False
        Me.CheckCerrado.Location = New System.Drawing.Point(16, 83)
        Me.CheckCerrado.Name = "CheckCerrado"
        Me.CheckCerrado.Size = New System.Drawing.Size(85, 24)
        Me.CheckCerrado.TabIndex = 3
        Me.CheckCerrado.Text = "Bloqueado"
        Me.CheckCerrado.UseVisualStyleBackColor = False
        '
        'CheckActivo
        '
        Me.CheckActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CheckActivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPeriodo2, "Periodo.Activo", True))
        Me.CheckActivo.Enabled = False
        Me.CheckActivo.Location = New System.Drawing.Point(198, 83)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(72, 24)
        Me.CheckActivo.TabIndex = 4
        Me.CheckActivo.Text = "Activo"
        Me.CheckActivo.UseVisualStyleBackColor = False
        '
        'chbCerradoFinal
        '
        Me.chbCerradoFinal.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.chbCerradoFinal.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPeriodo2, "Periodo.Cerrado", True))
        Me.chbCerradoFinal.Enabled = False
        Me.chbCerradoFinal.Location = New System.Drawing.Point(107, 83)
        Me.chbCerradoFinal.Name = "chbCerradoFinal"
        Me.chbCerradoFinal.Size = New System.Drawing.Size(85, 24)
        Me.chbCerradoFinal.TabIndex = 172
        Me.chbCerradoFinal.Text = "Cerrado"
        Me.chbCerradoFinal.UseVisualStyleBackColor = False
        '
        'lbPeriodoCodigo
        '
        Me.lbPeriodoCodigo.AutoSize = True
        Me.lbPeriodoCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsPeriodo2, "Periodo.Periodo", True))
        Me.lbPeriodoCodigo.Location = New System.Drawing.Point(243, 59)
        Me.lbPeriodoCodigo.Name = "lbPeriodoCodigo"
        Me.lbPeriodoCodigo.Size = New System.Drawing.Size(0, 13)
        Me.lbPeriodoCodigo.TabIndex = 173
        '
        'btReversarCierre
        '
        Me.btReversarCierre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btReversarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReversarCierre.Location = New System.Drawing.Point(276, 84)
        Me.btReversarCierre.Name = "btReversarCierre"
        Me.btReversarCierre.Size = New System.Drawing.Size(107, 23)
        Me.btReversarCierre.TabIndex = 174
        Me.btReversarCierre.Text = "Reversar Cierre"
        Me.btReversarCierre.UseVisualStyleBackColor = True
        Me.btReversarCierre.Visible = False
        '
        'FrmPeriodo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(406, 179)
        Me.Controls.Add(Me.btReversarCierre)
        Me.Controls.Add(Me.lbPeriodoCodigo)
        Me.Controls.Add(Me.chbCerradoFinal)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.CheckCerrado)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.CBMes)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.LAnoo)
        Me.Controls.Add(Me.LMes)
        Me.Controls.Add(Me.NUDAnno)
        Me.MaximizeBox = True
        Me.Name = "FrmPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodo de Trabajo"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.NUDAnno, 0)
        Me.Controls.SetChildIndex(Me.LMes, 0)
        Me.Controls.SetChildIndex(Me.LAnoo, 0)
        Me.Controls.SetChildIndex(Me.LabelUsuario, 0)
        Me.Controls.SetChildIndex(Me.CBMes, 0)
        Me.Controls.SetChildIndex(Me.TextUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.CheckCerrado, 0)
        Me.Controls.SetChildIndex(Me.CheckActivo, 0)
        Me.Controls.SetChildIndex(Me.chbCerradoFinal, 0)
        Me.Controls.SetChildIndex(Me.lbPeriodoCodigo, 0)
        Me.Controls.SetChildIndex(Me.btReversarCierre, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPeriodo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDAnno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Cedula As String = ""
    Private Sub CargarCedula()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Configuraciones", dt, Configuracion.Claves.Conexion("Hotel"))
        If dt.Rows.Count > 0 Then
            Me.Cedula = dt.Rows(0).Item("Cedula")
        End If
    End Sub

#Region "Load"
    Private Sub FrmPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            ValoresDefecto()
            AdapterPeriodo.Fill(DsPeriodo2.Periodo)
            CargaAdapter()
            clave = Configuracion.Claves.Configuracion("Clave")
            If clave.Equals("") Then
                SaveSetting("seesoft", "seguridad", "clave", "1")
            End If
            If Configuracion.Claves.Configuracion("Clave") = "0" Then
                Me.LabelUsuario.Text = usua.Nombre
                Me.TextUsuario.Enabled = False
                ToolBar1.Buttons(0).Enabled = True
                ToolBar1.Buttons(1).Enabled = True
                Me.ToolBarExcel.Enabled = True
                Me.ToolBarRegistrar.Enabled = True
            Else
                Me.TextUsuario.Focus()
            End If
            Me.CargarCedula()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA PERIODO
        DsPeriodo2.Periodo.MesColumn.DefaultValue = Now.Month
        DsPeriodo2.Periodo.AnnoColumn.DefaultValue = Now.Year
        DsPeriodo2.Periodo.EstadoColumn.DefaultValue = 0
        DsPeriodo2.Periodo.ActivoColumn.DefaultValue = 1
        DsPeriodo2.Periodo.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year

        LlenarMes("ENERO", 1)
        LlenarMes("FEBRERO", 2)
        LlenarMes("MARZO", 3)
        LlenarMes("ABRIL", 4)
        LlenarMes("MAYO", 5)
        LlenarMes("JUNIO", 6)
        LlenarMes("JULIO", 7)
        LlenarMes("AGOSTO", 8)
        LlenarMes("SETIEMBRE", 9)
        LlenarMes("OCTUBRE", 10)
        LlenarMes("NOVIEMBRE", 11)
        LlenarMes("DICIEMBRE", 12)
    End Sub


    Public Sub LlenarMes(ByVal Mes As String, ByVal Valor As Integer)
        Dim NuevaFila As DsPeriodo.MesesRow
        NuevaFila = DsPeriodo2.Meses.NewMesesRow
        NuevaFila.Mes = Mes
        NuevaFila.Valor = Valor
        DsPeriodo2.Meses.AddMesesRow(NuevaFila)
    End Sub


    Private Sub CargaAdapter()
        Try                 'VIERIFICA SI HAY PERIODOS CONTABLES EN LA BASE DE DATOS PARA CARGARLOS
            Dim Fx As New cFunciones
            Dim valor As Integer
            Dim cConexion As New Conexion

            valor = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT COUNT(Id_Periodo) FROM Periodo")
            cConexion.DesConectar(cConexion.sQlconexion)

            If valor <= 0 Then
                Exit Sub
            Else
                AdapterPeriodo.Fill(DsPeriodo2, "Periodo")
                BuscaAbierto()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BuscaAbierto()
        Try                 'BUSCA EL PERIODO QUE ESTE ABIERTO PARA MOSTRARLO AL INICIAR
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            Dim cConexion As New Conexion

            valor = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT Id_Periodo FROM Periodo WHERE Activo = 1 ORDER BY Id_Periodo DESC")
            cConexion.DesConectar(cConexion.sQlconexion)

            If valor = "" Then
                Exit Sub
            Else
                vista = DsPeriodo2.Periodo.DefaultView
                vista.Sort = "Id_Periodo"
                pos = vista.Find(valor)
                BindingContext(DsPeriodo2, "Periodo").Position = pos
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0 : NuevaEntrada()

                Case 1
                    If PMU.Find Then
                        Buscar()

                    Else
                        MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...")
                        Exit Sub

                    End If


                Case 2
                    If PMU.Update Then
                        If MessageBox.Show("¿Desea guardar el periodo de Trabajo?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                            Guardar()
                        End If
                    Else
                        MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If

                Case 5 : Editar()

                Case 6 : Me.Cerrar()
            End Select

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Validación Usuario"
    Private Sub TextUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sql As String
                Dim clsConexion As New Conexion
                Dim cnnConexion As New SqlConnection
                Dim rstReader As SqlDataReader

                cnnConexion = clsConexion.Conectar("", "Seguridad")
                sql = " SELECT Nombre FROM Usuarios WHERE Clave_Interna ='" & TextUsuario.Text & "'"
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)

                If rstReader.Read() = False Then
                    MsgBox("Usuario Incorrecto", MsgBoxStyle.Critical, "Contabilidad")
                    LabelUsuario.Text = Nothing
                    ToolBarNuevo.Enabled = False
                    ToolBarBuscar.Enabled = False
                    ToolBarRegistrar.Enabled = False
                    ToolBarExcel.Enabled = False
                    TextUsuario.Focus()
                Else
                    LabelUsuario.Text = rstReader.Item("Nombre")
                    ToolBarNuevo.Enabled = True
                    ToolBarBuscar.Enabled = True
                    ToolBarRegistrar.Enabled = True
                    ToolBarExcel.Enabled = True
                    CBMes.Focus()
                End If
                clsConexion.DesConectar(cnnConexion)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Contabilidad - Entrada _Usuario")
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
#End Region

#Region "Guardar"
    Public Sub Guardar()
        Dim Funcion As New cFunciones
        Try
            If Funcion.ValidarPeriodoFiscal(CDate("02" & "/" & CBMes.SelectedValue & "/" & NUDAnno.Value)) <> True Then
                MsgBox("No puede guardar el Periodo!" & vbCrLf & "!Porque no esta dentro de ningún periodo fiscal abierto!", MsgBoxStyle.Exclamation, "Contabilidad")
                Exit Sub
            End If

            BindingContext(DsPeriodo2, "Periodo").Current("Periodo") = Funcion.BuscaPeriodo(CDate("01" & "/" & CBMes.SelectedValue & "/" & NUDAnno.Value))

            BindingContext(DsPeriodo2, "Periodo").Current("Id_PeriodoFiscal") = Funcion.DamePeriodoFiscal(CDate("01" & "/" & CBMes.SelectedValue & "/" & NUDAnno.Value))

            If Nuevo Then
                If VerificaExistencia() Then
                    MsgBox("No puede guardar el Periodo porque ya existe", MsgBoxStyle.Exclamation, "Contabilidad")
                    Exit Sub
                End If
            End If

            Me.BindingContext(Me.DsPeriodo2, "Periodo").Current("Cerrado") = Me.chbCerradoFinal.Checked
            BindingContext(DsPeriodo2, "Periodo").EndCurrentEdit()

            If CheckActivo.Checked = True Then
                ActualizaActivo()
            End If

            If CheckCerrado.Checked = True Then
                If MessageBox.Show("¿Desea hacer Cierre de Periodo?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                    CheckCerrado.Checked = False
                    Exit Sub
                End If
                If VerificaFinalPeriodo() Then
                    MsgBox("No puede cerrar el Periodo porque no ha terminado!!", MsgBoxStyle.Exclamation, "Contabilidad")
                    CheckCerrado.Checked = False
                    Exit Sub
                End If

                If VerificaCierre() Then
                    MsgBox("No puede cerrar el Periodo porque hay periodos anteriores Abiertos!!", MsgBoxStyle.Exclamation, "Contabilidad")
                    CheckCerrado.Checked = False
                    Exit Sub
                End If

                If Me.Cedula <> "3-101-1486-2900" And Me.Cedula <> "3-102-622891" Then 'si es ecole travel o ksa plastica no entra aqui
                    If VerificaMayorización() Then
                        MsgBox("No puede Cerrar el Periodo porque hay Asientos Contables del periodo que No estan Mayorizados!!", MsgBoxStyle.Exclamation, "Contabilidad")
                        CheckCerrado.Checked = False
                        Exit Sub
                    End If

                    If VerificaTomaFisica() Then
                        Dim resp As Integer = MsgBox("No puede Cerrar el Periodo porque hay Tomas Fisicas que no se les ha aplicado el asiento!!¿Desea continuar?", MsgBoxStyle.YesNoCancel, "Contabilidad")
                        If resp = MsgBoxResult.No Then
                            CheckCerrado.Checked = False

                            Exit Sub
                        End If
                    End If

                End If

            End If

            If Transaccion() = False Then
                MsgBox("Error Guardando el Periodo de trabajo", MsgBoxStyle.Exclamation, "Contabilidad")
            End If

            MsgBox("Periodo guardado Satisfactoriamente", MsgBoxStyle.Information, "Contabilidad")
            CBMes.Enabled = False
            NUDAnno.Enabled = False
            CheckActivo.Enabled = False
            CheckCerrado.Enabled = False
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            Nuevo = False

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Contabilidad")
        End Try
    End Sub


    Function Transaccion() As Boolean
        Dim Trans As SqlTransaction

        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()

            Trans = SqlConnection1.BeginTransaction

            AdapterPeriodo.UpdateCommand.Transaction = Trans
            AdapterPeriodo.DeleteCommand.Transaction = Trans
            AdapterPeriodo.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....

            'chbCerradoFinal            
            AdapterPeriodo.Update(DsPeriodo2.Periodo)
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function
#End Region

#Region "Buscar"
    Private Sub Buscar()
        Try
            Dim f As New FormBusPeriodo
            If f.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Dim id As Integer = f.PeriodoBDS.Current("Id_Periodo")
                For i As Integer = 0 To BindingContext(DsPeriodo2, "Periodo").Count - 1
                    BindingContext(DsPeriodo2, "Periodo").Position = i
                    If BindingContext(DsPeriodo2, "Periodo").Current("Id_Periodo") = id Then
                        chbCerradoFinal.Checked = BindingContext(DsPeriodo2, "Periodo").Current("Cerrado")
                        If Not chbCerradoFinal.Checked Then
                            btReversarCierre.Visible = False
                        Else
                            spEvaluarReversar()
                        End If
                        Exit Sub
                    End If
                Next
                MsgBox("No se encontro el periodo", MsgBoxStyle.OkOnly)

            End If


            'Dim Fx As New cFunciones
            'Dim valor As String
            'Dim pos As Integer
            'Dim vista As DataView

            'If Me.BindingContext(Me.DsPeriodo2, "Periodo").Count > 0 Then
            '    Me.BindingContext(Me.DsPeriodo2, "Periodo").CancelCurrentEdit()
            '    ToolBar1.Buttons(0).Text = "Nuevo"
            '    ToolBar1.Buttons(0).ImageIndex = 0
            'End If

            'valor = Fx.BuscarDatos("SELECT Periodo AS PeriodoFiscal, LTRIM(Str(Mes)) + '/' + LTRIM(Str(Anno)) AS Fecha  FROM Periodo", "Periodo", "Buscar Periodo...", Me.SqlConnection1.ConnectionString, 0)

            'If valor = "" Then
            '    Exit Sub
            'Else
            '    vista = DsPeriodo2.Periodo.DefaultView
            '    vista.Sort = "Periodo"
            '    pos = vista.Find(valor)
            '    BindingContext(DsPeriodo2, "Periodo").Position = pos - 1
            'End If

            'CheckActivo.Enabled = True
            'CheckCerrado.Enabled = True
            'Nuevo = False

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

#End Region

#Region "Controles"
    Private Sub CBMes_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBMes.KeyDown
        If e.KeyCode = Keys.Enter Then
            NUDAnno.Focus()
        End If
    End Sub


    Private Sub Editar()
        CheckActivo.Enabled = True
        CheckCerrado.Enabled = True
    End Sub
#End Region

#Region "Validaciones"
    Private Sub ActualizaActivo()
        Try                     'PONE LOS PERIODOS QUE ESTEN ABIERTOS CERRADOS
            For i As Integer = 0 To DsPeriodo2.Periodo.Count - 1
                DsPeriodo2.Periodo(i).Activo = False
            Next i
            BindingContext(DsPeriodo2, "Periodo").Current("Activo") = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub


    Function VerificaMayorización() As Boolean
        Dim cConexion As New Conexion       'VERIFICA QUE NO HAYAN ASIENTOS SIN MAYORIZAR DEL PERIODO
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try
            VerificaMayorización = False
            'BUSCA LOS ASIENTOS DEL PERIODO QUE NO ESTEN MAYORIZADOS
            rs = cConexion.GetRecorset(cConexion.Conectar("", "Contabilidad"), "SELECT COUNT(*) AS Cantidad FROM AsientosContables WHERE NumAsiento IN(Select NumAsiento From DetallesAsientosContable) and Anulado = 0 AND Mayorizado = 0 AND Periodo = '" & BindingContext(DsPeriodo2, "Periodo").Current("Periodo") & "'")

            If rs.Read Then
                If rs("Cantidad") > 0 Then
                    VerificaMayorización = True
                End If
            End If
            rs.Close()

        Catch ex As SystemException
            MsgBox(ex.Message)
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Function VerificaTomaFisica() As Boolean
        Dim cConexion As New Conexion       'VERIFICA SI NO SE HA APLICADO EL ASIENTO DE LA TOMA FISICA
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim Fecha As DateTime = "01/" & BindingContext(DsPeriodo2, "Periodo").Current("Mes") & "/" & BindingContext(DsPeriodo2, "Periodo").Current("Anno")

        Try
            VerificaTomaFisica = False
            'BUSCA LAS TOMAS FISICAS HECHAS EN EL PERIODO QUE NO SE HAYAN APLICADO EL ASIENTO
            Fecha = Fecha.AddMonths(1)
            Fecha = Fecha.AddDays(-1)
            rs = cConexion.GetRecorset(cConexion.Conectar("", "Proveeduria"), "SELECT COUNT(*) AS Cantidad FROM TomaFisica WHERE Anulado = 0 AND Asiento = 0 AND Periodo BETWEEN (CAST (CONVERT(DATETIME, '" & BindingContext(DsPeriodo2, "Periodo").Current("Anno") & "' + '-' + '" & BindingContext(DsPeriodo2, "Periodo").Current("Mes") & "' + '-' + '01' + ' 00:00:00', 102) AS SMALLDATETIME)) AND (CAST (CONVERT(DATETIME, '" & Fecha.Year & "' + '-' + '" & Fecha.Month & "' + '-' + '" & Fecha.Day & "' + ' 23:58:59', 102) AS SMALLDATETIME))")

            If rs.Read Then
                If rs("Cantidad") > 0 Then
                    VerificaTomaFisica = True
                End If
            End If
            rs.Close()

        Catch ex As SystemException
            MsgBox(ex.Message)
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Function VerificaCierre() As Boolean
        Try                     'VERIFICA QUE NO HAYAN PERIODOS ANTERIORES ABIERTOS
            VerificaCierre = False
            For i As Integer = 0 To DsPeriodo2.Periodo.Count - 1
                If DsPeriodo2.Periodo(i).Estado = False Then
                    If DsPeriodo2.Periodo(i).Anno < BindingContext(DsPeriodo2, "Periodo").Current("Anno") Then
                        VerificaCierre = True
                    ElseIf DsPeriodo2.Periodo(i).Anno = BindingContext(DsPeriodo2, "Periodo").Current("Anno") And DsPeriodo2.Periodo(i).Mes <= BindingContext(DsPeriodo2, "Periodo").Current("Mes") Then
                        VerificaCierre = True
                    End If
                End If
            Next i

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function


    Function VerificaFinalPeriodo() As Boolean
        Try
            VerificaFinalPeriodo = False
            If Now.Year <= BindingContext(DsPeriodo2, "Periodo").Current("Anno") Then
                If Now.Month <= BindingContext(DsPeriodo2, "Periodo").Current("Mes") Then
                    VerificaFinalPeriodo = True
                End If
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function


    Function VerificaExistencia() As Boolean
        Try                     'VERIFICA QUE EL PERIODO NO ESTE CREADO
            VerificaExistencia = False
            For i As Integer = 0 To DsPeriodo2.Periodo.Count - 1
                If BindingContext(DsPeriodo2, "Periodo").Current("Periodo") = DsPeriodo2.Periodo(i).Periodo Then
                    VerificaExistencia = True
                End If
            Next i

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function
#End Region

#Region "Nuevo"
    Private Sub NuevaEntrada()
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 3
            CBMes.Enabled = True
            NUDAnno.Enabled = True
            CheckActivo.Enabled = True
            CheckCerrado.Enabled = True
            BindingContext(DsPeriodo2, "Periodo").EndCurrentEdit()
            BindingContext(DsPeriodo2, "Periodo").AddNew()
            CBMes.Focus()
            Nuevo = True
        Else
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            CBMes.Enabled = False
            NUDAnno.Enabled = False
            CheckActivo.Enabled = False
            CheckCerrado.Enabled = False
            BindingContext(DsPeriodo2, "Periodo").CancelCurrentEdit()
            Nuevo = False
        End If
    End Sub
#End Region

    Private Sub chbCerradoFinal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbCerradoFinal.CheckedChanged

    End Sub
    Sub spEvaluarReversar()
        Dim cmd As String = "SELECT MAX(Anno*100 + mes) as Ultimo  FROM [Contabilidad].[dbo].[Periodo]  Where Cerrado = 1"
        Dim dt As New DataTable
        cls_Datos.sp_llenarTabla(cmd, dt, "Contabilidad")
        Dim suma As Integer = (NUDAnno.Value * 100 + CBMes.SelectedValue)
        If dt.Rows.Count > 0 Then
            If Not dt.Rows(0).Item("Ultimo") = suma Then
                btReversarCierre.Visible = False
            Else
                btReversarCierre.Visible = True
            End If
        End If
    End Sub

    Private Sub btResersarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReversarCierre.Click
        spAplicarReversion()
    End Sub
    Sub spAplicarReversion()
        If MsgBox("Desea realmente reversar el cierre de este periodo", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '   cls_Datos.Sp_EjecutarSQL("UPDATE From Periodo set Cerrado = 0 Where Id_Periodo = " & BindingContext(DsPeriodo2, "Periodo").Current("Id_Periodo"), "Contabilidad")
            chbCerradoFinal.Checked = False
            BindingContext(DsPeriodo2, "Periodo").Current("Cerrado") = False
            BindingContext(DsPeriodo2, "Periodo").EndCurrentEdit()
            If Transaccion() Then
                cls_Datos.Sp_EjecutarSQL("UPDATE  CierresPeriodos set Reversado = 1 Where IdPeriodoTrabajo = " & BindingContext(DsPeriodo2, "Periodo").Current("Id_Periodo"), "Contabilidad")
                Dim dtIdAsientos As New DataTable()

                cFunciones.Llenar_Tabla_Generico("Select NumAsiento from dbo.AsientosContables where TipoDoc=29 and Periodo='" & BindingContext(DsPeriodo2, "Periodo").Current("Periodo") & "'", dtIdAsientos)

                Dim count As Integer
                If dtIdAsientos.Rows.Count > 0 Then
                    For count = 0 To dtIdAsientos.Rows.Count - 1
                        cls_Datos.Sp_EjecutarSQL("Delete from dbo.DetallesAsientosContable where NumAsiento='" & dtIdAsientos.Rows(count).Item("NumAsiento") & "'", "Contabilidad")

                    Next

                    cls_Datos.Sp_EjecutarSQL("Delete from dbo.AsientosContables where TipoDoc=29 and Periodo='" & BindingContext(DsPeriodo2, "Periodo").Current("Periodo") & "'", "Contabilidad")

                End If

                MsgBox("Periodo guardado de forma satisfactoria", MsgBoxStyle.OkOnly)
                btReversarCierre.Visible = False

            End If

        End If
    End Sub
End Class
