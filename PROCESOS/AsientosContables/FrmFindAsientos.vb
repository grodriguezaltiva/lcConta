Imports System.Drawing
Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Public Class FrmFindAsientos
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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsAsientos1 As Contabilidad.DsAsientos
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFindAsientos))
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DsAsientos1 = New Contabilidad.DsAsientos
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rdbDocumento = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAsientos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(723, 296)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 42)
        Me.btnCancelar.TabIndex = 6
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(621, 296)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 40)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(5, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "Criterios de Busqueda"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "AsientosContablesBus"
        Me.GridControl1.DataSource = Me.DsAsientos1
        '
        '
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 8)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(832, 234)
        Me.GridControl1.TabIndex = 96
        Me.GridControl1.Text = "GridControl"
        '
        'DsAsientos1
        '
        Me.DsAsientos1.DataSetName = "DsAsientos"
        Me.DsAsientos1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DsAsientos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6})
        Me.GridView1.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {New DevExpress.XtraGrid.StyleFormatCondition(DevExpress.XtraGrid.FormatConditionEnum.Equal, Nothing, "Style1", True, Nothing, Me.GridColumn6, True)})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "# Asiento"
        Me.GridColumn1.FieldName = "NumAsiento"
        Me.GridColumn1.FilterInfo = ColumnFilterInfo1
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 102
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.FilterInfo = ColumnFilterInfo2
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 476
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Periodo"
        Me.GridColumn3.FieldName = "Periodo"
        Me.GridColumn3.FilterInfo = ColumnFilterInfo3
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha"
        Me.GridColumn4.FieldName = "Fecha"
        Me.GridColumn4.FilterInfo = ColumnFilterInfo4
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 84
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "NumDoc"
        Me.GridColumn5.FieldName = "NumDoc"
        Me.GridColumn5.FilterInfo = ColumnFilterInfo5
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 81
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Anulo"
        Me.GridColumn6.FieldName = "Anulado"
        Me.GridColumn6.FilterInfo = ColumnFilterInfo6
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 5
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContablesBus", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 522, "Descripcion"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha")})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source="".\jea" & _
            "n"";persist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NumAsiento, Descripcion, NumDoc, Periodo, Fecha FROM AsientosContablesBus"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rdbDocumento)
        Me.Panel2.Controls.Add(Me.RadioButton1)
        Me.Panel2.Controls.Add(Me.CheckBox2)
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.RadioButton5)
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Location = New System.Drawing.Point(144, 248)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(696, 42)
        Me.Panel2.TabIndex = 100
        '
        'rdbDocumento
        '
        Me.rdbDocumento.Checked = True
        Me.rdbDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbDocumento.Location = New System.Drawing.Point(3, 8)
        Me.rdbDocumento.Name = "rdbDocumento"
        Me.rdbDocumento.Size = New System.Drawing.Size(51, 16)
        Me.rdbDocumento.TabIndex = 106
        Me.rdbDocumento.TabStop = True
        Me.rdbDocumento.Text = "Doc"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(199, 7)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton1.TabIndex = 105
        Me.RadioButton1.Text = "#Asiento"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(464, 8)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(204, 16)
        Me.CheckBox2.TabIndex = 104
        Me.CheckBox2.Text = "Todos los periodos"
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(386, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(72, 16)
        Me.CheckBox1.TabIndex = 103
        Me.CheckBox1.Text = "Periodo Actual"
        '
        'RadioButton5
        '
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(285, 8)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(80, 16)
        Me.RadioButton5.TabIndex = 102
        Me.RadioButton5.Text = "Fecha"
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(88, 8)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(105, 16)
        Me.RadioButton3.TabIndex = 100
        Me.RadioButton3.Text = "Descripción"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtFiltro)
        Me.Panel3.Location = New System.Drawing.Point(144, 296)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(424, 40)
        Me.Panel3.TabIndex = 101
        Me.Panel3.Visible = False
        '
        'txtFiltro
        '
        Me.txtFiltro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFiltro.Location = New System.Drawing.Point(16, 8)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(392, 20)
        Me.txtFiltro.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(152, 296)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(416, 40)
        Me.Panel4.TabIndex = 102
        Me.Panel4.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.DateTimePicker2)
        Me.Panel5.Location = New System.Drawing.Point(16, 8)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(222, 24)
        Me.Panel5.TabIndex = 89
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(121, -1)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 84
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(91, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "<-->"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(1, -1)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker2.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        '
        'SimpleButton2
        '
        Me.SimpleButton2.ImageIndex = 0
        Me.SimpleButton2.ImageList = Me.ImageList1
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 296)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(104, 40)
        Me.SimpleButton2.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsAsientos1, "AsientosContablesBus.NumAsiento", True))
        Me.Label3.Location = New System.Drawing.Point(856, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 23)
        Me.Label3.TabIndex = 109
        '
        'FrmFindAsientos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(850, 350)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.SimpleButton2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmFindAsientos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Asientos"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAsientos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public Dv As System.Data.DataView
    Public Dv1 As System.Data.DataView
    Public Codigo As String = ""
    Dim bol As Boolean = False
    Private Sub FrmFindAsientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim funcion As New cFunciones
        'Me.SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        ''Me.AdapterAsientos.Fill(Me.DsAsientos1.AsientosContablesBus)
        ''Me.DsAsientos1.AsientosContablesBus.Clear()
        'funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  Periodo = '" & funcion.Periodo & "'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))

        Me.RadioButton3.Checked = True
        Me.txtFiltro.Text = ""
        Me.txtFiltro.Focus()
        Me.cargando = False

    End Sub

    Dim cargando As Boolean = True


    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If cargando Then Exit Sub

        Dim funcion As New cFunciones
        If Me.CheckBox2.Checked = True Then
            Me.CheckBox1.Checked = False
            funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))
            Me.txtFiltro.Text = ""
            Me.txtFiltro.Focus()
        Else
            If Me.CheckBox1.Checked = False Then
                Me.CheckBox2.Checked = True
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Dim funcion As New cFunciones
        If Me.CheckBox1.Checked = True Then
            Me.CheckBox2.Checked = False
            funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  Periodo = '" & funcion.Periodo & "'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))
            Me.txtFiltro.Text = ""
            Me.txtFiltro.Focus()
        Else
            If Me.CheckBox2.Checked = False Then
                Me.CheckBox1.Checked = True
            End If
        End If

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If Me.RadioButton3.Checked = True Then
            Me.Panel3.Visible = True
            Me.Panel4.Visible = False
            Me.txtFiltro.Text = ""
            Me.txtFiltro.Focus()
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged
        If Me.RadioButton5.Checked = True Then
            Me.Panel4.Visible = True
            Me.Panel3.Visible = False
            Me.SimpleButton2.Visible = True
            Me.DateTimePicker2.Focus()
        End If
    End Sub

    Private Sub txtFiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            sp_Filtro()
        End If

    End Sub

 
    Sub sp_Filtro()
        If cargando Then Exit Sub

        Dim funcion As New cFunciones
        If txtFiltro.Text.Length = 0 Then
            Me.DsAsientos1.AsientosContablesBus.Clear()
        Else

            If Me.rdbDocumento.Checked = True Then
                If Me.CheckBox1.Checked = True Then
                    funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  NumDoc LIKE '%" & Me.txtFiltro.Text & "%'AND  Periodo = '" & funcion.Periodo & "'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))

                End If
                If Me.CheckBox2.Checked = True Then
                    funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  NumDoc LIKE '%" & Me.txtFiltro.Text & "%'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))
                End If
            End If

            If Me.RadioButton1.Checked = True Then
                If Me.CheckBox1.Checked = True Then
                    funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  NumAsiento LIKE '%" & Me.txtFiltro.Text & "%'AND  Periodo = '" & funcion.Periodo & "'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))

                End If
                If Me.CheckBox2.Checked = True Then
                    funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  NumAsiento LIKE '%" & Me.txtFiltro.Text & "%'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))
                End If
            End If
            If Me.RadioButton3.Checked = True Then
                If Me.CheckBox1.Checked = True Then
                    funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  Descripcion LIKE '%" & Me.txtFiltro.Text & "%'AND  Periodo = '" & funcion.Periodo & "'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))

                End If
                If Me.CheckBox2.Checked = True Then
                    funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  Descripcion LIKE '%" & Me.txtFiltro.Text & "%'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))
                End If

            End If

        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'Dim funcion As New cFunciones
        'Dim fecha1, fecha2 As DateTime
        'If Me.RadioButton3.Checked = True Then

        'ElseIf Me.RadioButton5.Checked = True Then
        '    fecha1 = Me.DateTimePicker1.Value
        '    fecha1 = fecha1.Date
        '    fecha2 = Me.DateTimePicker2.Value
        '    fecha2 = fecha2.Date
        '    If Me.CheckBox1.Checked = True Then
        '        funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  (Fecha >= '" & fecha2 & "' and Fecha <= '" & fecha1 & "' )AND  Periodo = '" & funcion.Periodo & "'ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))
        '    End If
        '    If Me.CheckBox2.Checked = True Then
        '        funcion.Llenar_Tabla_Generico("SELECT * FROM AsientosContablesBus where  (Fecha >= '" & fecha2 & "' and Fecha <= '" & fecha1 & "' ) ORDER BY NumAsiento DESC", Me.DsAsientos1.AsientosContablesBus, Configuracion.Claves.Conexion("Contabilidad"))

        '    End If
        'End If
        sp_Filtro()

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If Me.RadioButton1.Checked = True Then
            Me.Panel3.Visible = True
            Me.Panel4.Visible = False
            Me.txtFiltro.Text = ""
            Me.txtFiltro.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        bol = False
        Me.Label3.Text = ""
    End Sub

    Private Sub FrmFindAsientos_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If bol = False Then
            Me.Label3.Text = ""
        End If
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        bol = True
    End Sub

    Private Sub rdbDocumento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDocumento.CheckedChanged
        If Me.rdbDocumento.Checked = True Then
            Me.Panel3.Visible = True
            Me.Panel4.Visible = False

            Me.txtFiltro.Text = ""
            Me.txtFiltro.Focus()
        End If
    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged

    End Sub
End Class
