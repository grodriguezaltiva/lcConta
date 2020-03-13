Imports Utilidades
Imports System.Data.SqlClient

Public Class PeriodoFiscal
    Inherits FrmPlantilla

    Dim usua As Usuario_Logeado
    Dim Nuevo As Boolean
    Friend WithEvents btReversarCierre As System.Windows.Forms.Button
    Friend WithEvents chCerrado As System.Windows.Forms.CheckBox
    Friend WithEvents btReversarBloqueo As System.Windows.Forms.Button
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
    Friend WithEvents LMes As System.Windows.Forms.Label
    Friend WithEvents LabelUsuario As System.Windows.Forms.Label
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents CheckActivo As System.Windows.Forms.CheckBox
    Friend WithEvents DTP_Final As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTP_Inicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents AdapterPeridoFiscal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsPeriodoFiscal1 As Contabilidad.DsPeriodoFiscal


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeriodoFiscal))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExistenciaBodega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LMes = New System.Windows.Forms.Label
        Me.LabelUsuario = New System.Windows.Forms.Label
        Me.TextUsuario = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.CheckActivo = New System.Windows.Forms.CheckBox
        Me.DsPeriodoFiscal1 = New Contabilidad.DsPeriodoFiscal
        Me.DTP_Inicio = New System.Windows.Forms.DateTimePicker
        Me.DTP_Final = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.AdapterPeridoFiscal = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.btReversarCierre = New System.Windows.Forms.Button
        Me.chCerrado = New System.Windows.Forms.CheckBox
        Me.btReversarBloqueo = New System.Windows.Forms.Button
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPeriodoFiscal1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TituloModulo.Size = New System.Drawing.Size(390, 24)
        Me.TituloModulo.Text = "Periodo Fiscal"
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
        Me.ToolBar1.Location = New System.Drawing.Point(0, 130)
        Me.ToolBar1.Size = New System.Drawing.Size(390, 52)
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
        'LMes
        '
        Me.LMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMes.ForeColor = System.Drawing.Color.Blue
        Me.LMes.Location = New System.Drawing.Point(26, 34)
        Me.LMes.Name = "LMes"
        Me.LMes.Size = New System.Drawing.Size(96, 16)
        Me.LMes.TabIndex = 167
        Me.LMes.Text = "Inicio"
        Me.LMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelUsuario
        '
        Me.LabelUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(248, 144)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(137, 16)
        Me.LabelUsuario.TabIndex = 170
        '
        'TextUsuario
        '
        Me.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsuario.Location = New System.Drawing.Point(304, 128)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextUsuario.Size = New System.Drawing.Size(80, 13)
        Me.TextUsuario.TabIndex = 0
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(248, 128)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 13)
        Me.Label36.TabIndex = 171
        Me.Label36.Text = "Usuario->"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CheckActivo
        '
        Me.CheckActivo.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.CheckActivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPeriodoFiscal1, "PeriodoFiscal.Estado", True))
        Me.CheckActivo.Enabled = False
        Me.CheckActivo.Location = New System.Drawing.Point(26, 80)
        Me.CheckActivo.Name = "CheckActivo"
        Me.CheckActivo.Size = New System.Drawing.Size(107, 20)
        Me.CheckActivo.TabIndex = 3
        Me.CheckActivo.Text = "Bloqueado"
        Me.CheckActivo.UseVisualStyleBackColor = False
        '
        'DsPeriodoFiscal1
        '
        Me.DsPeriodoFiscal1.DataSetName = "DsPeriodoFiscal"
        Me.DsPeriodoFiscal1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DsPeriodoFiscal1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTP_Inicio
        '
        Me.DTP_Inicio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPeriodoFiscal1, "PeriodoFiscal.FechaInicio", True))
        Me.DTP_Inicio.Enabled = False
        Me.DTP_Inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Inicio.Location = New System.Drawing.Point(26, 53)
        Me.DTP_Inicio.Name = "DTP_Inicio"
        Me.DTP_Inicio.Size = New System.Drawing.Size(96, 20)
        Me.DTP_Inicio.TabIndex = 1
        Me.DTP_Inicio.Value = New Date(2009, 3, 18, 0, 0, 0, 0)
        '
        'DTP_Final
        '
        Me.DTP_Final.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsPeriodoFiscal1, "PeriodoFiscal.FechaFinal", True))
        Me.DTP_Final.Enabled = False
        Me.DTP_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Final.Location = New System.Drawing.Point(150, 53)
        Me.DTP_Final.Name = "DTP_Final"
        Me.DTP_Final.Size = New System.Drawing.Size(96, 20)
        Me.DTP_Final.TabIndex = 2
        Me.DTP_Final.Value = New Date(2009, 3, 18, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(150, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 175
        Me.Label1.Text = "Final"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AdapterPeridoFiscal
        '
        Me.AdapterPeridoFiscal.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterPeridoFiscal.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterPeridoFiscal.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterPeridoFiscal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PeriodoFiscal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("FechaInicio", "FechaInicio"), New System.Data.Common.DataColumnMapping("FechaFinal", "FechaFinal"), New System.Data.Common.DataColumnMapping("Estado", "Estado"), New System.Data.Common.DataColumnMapping("Cerrado", "Cerrado")})})
        Me.AdapterPeridoFiscal.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaInicio", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cerrado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cerrado", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cerrado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cerrado", System.Data.DataRowVersion.Original, Nothing)})
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
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FechaInicio", System.Data.SqlDbType.DateTime, 0, "FechaInicio"), New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 0, "FechaFinal"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 0, "Estado"), New System.Data.SqlClient.SqlParameter("@Cerrado", System.Data.SqlDbType.Bit, 0, "Cerrado")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT     Id, FechaInicio, FechaFinal, Estado, Cerrado" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         PeriodoFisc" & _
            "al"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FechaInicio", System.Data.SqlDbType.DateTime, 0, "FechaInicio"), New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 0, "FechaFinal"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 0, "Estado"), New System.Data.SqlClient.SqlParameter("@Cerrado", System.Data.SqlDbType.Bit, 0, "Cerrado"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaInicio", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Cerrado", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Cerrado", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Cerrado", System.Data.SqlDbType.Bit, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cerrado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'btReversarCierre
        '
        Me.btReversarCierre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btReversarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReversarCierre.Location = New System.Drawing.Point(150, 101)
        Me.btReversarCierre.Name = "btReversarCierre"
        Me.btReversarCierre.Size = New System.Drawing.Size(96, 23)
        Me.btReversarCierre.TabIndex = 176
        Me.btReversarCierre.Text = "Reversar Cierre"
        Me.btReversarCierre.UseVisualStyleBackColor = True
        Me.btReversarCierre.Visible = False
        '
        'chCerrado
        '
        Me.chCerrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.chCerrado.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.DsPeriodoFiscal1, "PeriodoFiscal.Cerrado", True))
        Me.chCerrado.Enabled = False
        Me.chCerrado.Location = New System.Drawing.Point(150, 79)
        Me.chCerrado.Name = "chCerrado"
        Me.chCerrado.Size = New System.Drawing.Size(96, 20)
        Me.chCerrado.TabIndex = 177
        Me.chCerrado.Text = "Cerrado"
        Me.chCerrado.UseVisualStyleBackColor = False
        '
        'btReversarBloqueo
        '
        Me.btReversarBloqueo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btReversarBloqueo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReversarBloqueo.Location = New System.Drawing.Point(26, 101)
        Me.btReversarBloqueo.Name = "btReversarBloqueo"
        Me.btReversarBloqueo.Size = New System.Drawing.Size(107, 23)
        Me.btReversarBloqueo.TabIndex = 178
        Me.btReversarBloqueo.Text = "Reversar Bloqueo"
        Me.btReversarBloqueo.UseVisualStyleBackColor = True
        Me.btReversarBloqueo.Visible = False
        '
        'PeriodoFiscal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(390, 182)
        Me.Controls.Add(Me.btReversarBloqueo)
        Me.Controls.Add(Me.chCerrado)
        Me.Controls.Add(Me.btReversarCierre)
        Me.Controls.Add(Me.DTP_Final)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DTP_Inicio)
        Me.Controls.Add(Me.CheckActivo)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.LMes)
        Me.Name = "PeriodoFiscal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Periodo Fiscal"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.LMes, 0)
        Me.Controls.SetChildIndex(Me.LabelUsuario, 0)
        Me.Controls.SetChildIndex(Me.TextUsuario, 0)
        Me.Controls.SetChildIndex(Me.Label36, 0)
        Me.Controls.SetChildIndex(Me.CheckActivo, 0)
        Me.Controls.SetChildIndex(Me.DTP_Inicio, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.DTP_Final, 0)
        Me.Controls.SetChildIndex(Me.btReversarCierre, 0)
        Me.Controls.SetChildIndex(Me.chCerrado, 0)
        Me.Controls.SetChildIndex(Me.btReversarBloqueo, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPeriodoFiscal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub PeriodoFiscal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            ValoresDefecto()
            DsPeriodoFiscal1.PeriodoFiscal.IdColumn.AutoIncrement = True
            DsPeriodoFiscal1.PeriodoFiscal.IdColumn.AutoIncrementSeed = -1
            DsPeriodoFiscal1.PeriodoFiscal.IdColumn.AutoIncrementStep = -1
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA PERIODO
        DsPeriodoFiscal1.PeriodoFiscal.FechaInicioColumn.DefaultValue = Now
        DsPeriodoFiscal1.PeriodoFiscal.FechaFinalColumn.DefaultValue = Now
        DsPeriodoFiscal1.PeriodoFiscal.EstadoColumn.DefaultValue = 0
    End Sub


    Private Sub BuscaAbierto()
        Try                 'BUSCA EL PERIODO FISCAL QUE ESTE ABIERTO PARA MOSTRARLO AL INICIAR
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView
            Dim cConexion As New Conexion

            valor = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT Id FROM PeriodoFiscal WHERE Estado = 1 ORDER BY Id DESC")
            cConexion.DesConectar(cConexion.sQlconexion)

            If valor = "" Or valor = "0" Then
                Exit Sub
            Else
                vista = DsPeriodoFiscal1.PeriodoFiscal.DefaultView
                vista.Sort = "Id"
                pos = vista.Find(valor)
                BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Position = pos
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargaAdapter()
        Try                 'VIERIFICA SI HAY PERIODOS CONTABLES EN LA BASE DE DATOS PARA CARGARLOS
            Dim Fx As New cFunciones
            Dim valor As Integer
            Dim cConexion As New Conexion

            valor = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT COUNT(Id) FROM PeriodoFiscal")
            cConexion.DesConectar(cConexion.sQlconexion)

            If valor <= 0 Then
                Exit Sub
            Else
                AdapterPeridoFiscal.Fill(DsPeriodoFiscal1, "PeriodoFiscal")
                BuscaAbierto()
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

                Case 1 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

                Case 2
                    If PMU.Update Then
                        If MessageBox.Show("¿Desea guardar el periodo Fiscal?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
                    DTP_Inicio.Focus()
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
        Try
            If Nuevo Then
                If VerificaExistencia() Then
                    MsgBox("No puede guardar el Periodo Fiscal porque esta dentro del Periodo de otro", MsgBoxStyle.Exclamation, "Contabilidad")
                    Exit Sub
                End If
            End If

            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Current("Cerrado") = chCerrado.Checked
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Current("FechaInicio") = DTP_Inicio.Value.Date
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Current("FechaFinal") = DTP_Final.Value.Date
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").EndCurrentEdit()

            If Transaccion() = False Then
                MsgBox("Error Guardando el Periodo Fiscal", MsgBoxStyle.Exclamation, "Contabilidad")
            End If

            MsgBox("Periodo fiscal guardado Satisfactoriamente", MsgBoxStyle.Information, "Contabilidad")
            DTP_Inicio.Enabled = False
            DTP_Final.Enabled = False
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

            AdapterPeridoFiscal.UpdateCommand.Transaction = Trans
            AdapterPeridoFiscal.DeleteCommand.Transaction = Trans
            AdapterPeridoFiscal.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterPeridoFiscal.Update(DsPeriodoFiscal1.PeriodoFiscal)
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
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            If Me.BindingContext(Me.DsPeriodoFiscal1, "PeriodoFiscal").Count > 0 Then
                Me.BindingContext(Me.DsPeriodoFiscal1, "PeriodoFiscal").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
            End If

            valor = Fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "PeriodoFiscal", "Buscar Periodo Fiscal...", Me.SqlConnection1.ConnectionString, 0, "Order by Id DESC")

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DsPeriodoFiscal1.PeriodoFiscal.DefaultView
                vista.Sort = "Id"
                pos = vista.Find(valor)
                Me.BindingContext(Me.DsPeriodoFiscal1, "PeriodoFiscal").Position = pos
            End If
            If Not chCerrado.Checked Then
                btReversarCierre.Visible = False
            Else
                btReversarCierre.Visible = True

            End If
            If Not CheckActivo.Checked Then
                btReversarBloqueo.Visible = False
            Else
                btReversarBloqueo.Visible = True

            End If
            Nuevo = False

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Controles"
    Private Sub DTP_Inicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DTP_Inicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            DTP_Final.Focus()
        End If
    End Sub

    Private Sub Editar()
        DTP_Inicio.Enabled = True
        DTP_Final.Enabled = True
    End Sub
#End Region

#Region "Validaciones"
    Function VerificaExistencia() As Boolean
        Try                     'VERIFICA QUE EL PERIODO FISCAL NO ESTE CREADO
            VerificaExistencia = False
            For i As Integer = 0 To DsPeriodoFiscal1.PeriodoFiscal.Count - 1
                If BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Current("FechaInicio") <= DsPeriodoFiscal1.PeriodoFiscal(i).FechaFinal Then
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
            DTP_Inicio.Enabled = True
            DTP_Final.Enabled = True
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").CancelCurrentEdit()
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").AddNew()
            DTP_Inicio.Focus()
            Nuevo = True
        Else
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
            DTP_Inicio.Enabled = False
            DTP_Final.Enabled = False
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").CancelCurrentEdit()
            Nuevo = False
        End If
    End Sub
#End Region

    Private Sub btReversarCierre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReversarCierre.Click
        spReversarCierre()
    End Sub
    Sub spReversarCierre()
        If MsgBox("Esta seguro que desea reversar el cierre?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Current("Cerrado") = False
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").EndCurrentEdit()
            If Transaccion() Then
                MsgBox("Reversión realizada de forma correcta", MsgBoxStyle.OkOnly)
                btReversarCierre.Visible = False
            End If
        End If
    End Sub

    Private Sub btReversarBloqueo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btReversarBloqueo.Click
        spReversarBloqueo()
    End Sub
    Sub spReversarBloqueo()
        If MsgBox("Esta seguro que desea reversar el bloqueo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").Current("Estado") = False
            BindingContext(DsPeriodoFiscal1, "PeriodoFiscal").EndCurrentEdit()

            If Transaccion() Then
                MsgBox("Desbloqueo realizado de forma correcta", MsgBoxStyle.OkOnly)
                btReversarBloqueo.Visible = False
            End If

        End If
    End Sub

End Class
