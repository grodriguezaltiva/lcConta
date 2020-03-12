Imports Utilidades
Imports System.Data.SqlClient

Public Class frmHotelCortesiaAutomatica
    Inherits Contabilidad.Plantilla

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
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents dtsAsientoVenta As Contabilidad.DatasetAsientoVenta
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHaber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarVenta As System.Windows.Forms.Button
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHotelCortesiaAutomatica))
        Me.btnModificar = New System.Windows.Forms.Button
        Me.dtsAsientoVenta = New Contabilidad.DatasetAsientoVenta
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtHaber = New DevExpress.XtraEditors.TextEdit
        Me.txtDebe = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtTotalHaber = New System.Windows.Forms.TextBox
        Me.txtTotalDebe = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnGenerarVenta = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 363)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(620, 52)
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(620, 32)
        Me.TituloModulo.Text = "Asiento Cortesia"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(288, 150)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 200
        Me.btnModificar.Text = "Agregar"
        Me.btnModificar.Visible = False
        '
        'dtsAsientoVenta
        '
        Me.dtsAsientoVenta.DataSetName = "DatasetAsientoVenta"
        Me.dtsAsientoVenta.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(280, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 14)
        Me.Label1.TabIndex = 203
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(279, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 14)
        Me.Label2.TabIndex = 202
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(32, 126)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 19)
        Me.txtCodigo.TabIndex = 196
        Me.txtCodigo.Text = ""
        Me.txtCodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 209
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'txtHaber
        '
        Me.txtHaber.EditValue = ""
        Me.txtHaber.Location = New System.Drawing.Point(472, 126)
        Me.txtHaber.Name = "txtHaber"
        '
        'txtHaber.Properties
        '
        Me.txtHaber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Size = New System.Drawing.Size(132, 21)
        Me.txtHaber.TabIndex = 199
        Me.txtHaber.Visible = False
        '
        'txtDebe
        '
        Me.txtDebe.EditValue = ""
        Me.txtDebe.Location = New System.Drawing.Point(336, 126)
        Me.txtDebe.Name = "txtDebe"
        '
        'txtDebe.Properties
        '
        Me.txtDebe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Size = New System.Drawing.Size(131, 21)
        Me.txtDebe.TabIndex = 198
        Me.txtDebe.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(184, 126)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(148, 19)
        Me.txtDescripcion.TabIndex = 197
        Me.txtDescripcion.Text = ""
        Me.txtDescripcion.Visible = False
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(472, 342)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 208
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(320, 342)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 207
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(420, 396)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 205
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(340, 396)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(472, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 212
        Me.Label6.Text = "Haber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(336, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 211
        Me.Label5.Text = "Debe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(184, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 14)
        Me.Label4.TabIndex = 210
        Me.Label4.Text = "Descripción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(16, 99)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(600, 235)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 201
        Me.griDetalle.Text = "Asientos de venta"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GroupPanelText = "Detalle del Asiento"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Debe"
        Me.GridColumn3.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Debe"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.SortIndex = 0
        Me.GridColumn3.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Haber"
        Me.GridColumn4.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Haber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 3
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(420, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 206
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(340, 380)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 204
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Location = New System.Drawing.Point(479, 36)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(91, 54)
        Me.btnGenerarVenta.TabIndex = 3
        Me.btnGenerarVenta.Text = "Generar Asiento Cortesia"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(366, 68)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 2
        Me.dtpFechaFinal.Value = New Date(2007, 5, 15, 17, 38, 13, 140)
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(366, 41)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 1
        Me.dtpFechaInicio.Value = New Date(2007, 5, 15, 17, 38, 13, 140)
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(30, 337)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.TabIndex = 213
        Me.btnDetalle.Text = "Detalle"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.dtsAsientoVenta.PuntoVenta
        Me.ComboBox1.DisplayMember = "Nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.Location = New System.Drawing.Point(16, 62)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(251, 24)
        Me.ComboBox1.TabIndex = 248
        Me.ComboBox1.ValueMember = "IdPuntoVenta"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(250, 22)
        Me.Label7.TabIndex = 247
        Me.Label7.Text = "Punto de Venta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmHotelCortesiaAutomatica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(620, 415)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHaber)
        Me.Controls.Add(Me.txtDebe)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtTotalHaber)
        Me.Controls.Add(Me.txtTotalDebe)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnGenerarVenta)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.btnModificar)
        Me.Name = "frmHotelCortesiaAutomatica"
        Me.Text = "Cortesia: Generación automática de asiento"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarVenta, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtTotalDebe, 0)
        Me.Controls.SetChildIndex(Me.txtTotalHaber, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtDebe, 0)
        Me.Controls.SetChildIndex(Me.txtHaber, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.btnDetalle, 0)
        Me.Controls.SetChildIndex(Me.griDetalle, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.ComboBox1, 0)
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String
    Dim IdCuenta1(1) As String
    Dim IdCuenta2(1) As Integer
    Dim caso As Byte
    Dim Accion As String
    Dim Fx As New cFunciones
    Dim bd As String = ""
#End Region

#Region "Funciones GUI"
    Private Sub frmAsientoVentaGeneracionAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar()

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : NUEVO()

            Case 2 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Me.Close()
        End Select
    End Sub

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Loggin_Usuario() Then
                Me.ToolBarNuevo.Enabled = True
                NUEVO()
                dtpFechaInicio.Focus()
            End If
        End If
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarVenta.Click
        Generar()
    End Sub

    Private Sub btnGenerarVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnGenerarVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            Generar()
        End If
    End Sub

    Private Sub dtpFechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechaFinal.Focus()
        End If
    End Sub

    Private Sub dtpFechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGenerarVenta.Focus()
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable()
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If Me.txtCodigo.Text = "" Or Me.txtDescripcion.Text = "" Then
            MsgBox("No hay cuenta cuntable que agregar")
            Exit Sub
        End If

        If txtDebe.Text <> 0 And txtHaber.Text <> 0 Then
            MsgBox("Alguno de los montos del debe o el haber tiene que ser 0" & vbCrLf & "No se puede agregar la cuenta", MsgBoxStyle.Information)
            Exit Sub
        End If

        If txtDebe.Text = 0 And txtHaber.Text = 0 Then
            MsgBox("Debe ingresar un monto en el debo o el haber" & vbCrLf & "No se puede agregar la cuenta", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            Dim NuevaFila As DatasetAsientoVenta.GeneracionAutomaticaAsientoVentaRow
            NuevaFila = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.NewGeneracionAutomaticaAsientoVentaRow
            NuevaFila.Codigo = Me.txtCodigo.Text
            NuevaFila.Descripcion = Me.txtDescripcion.Text
            NuevaFila.Haber = txtHaber.Text
            NuevaFila.Debe = txtDebe.Text
            Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.AddGeneracionAutomaticaAsientoVentaRow(NuevaFila)
            Accion = "MAN"
        Catch ex As Exception
        End Try


        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT id  FROM CuentaContable where CuentaContable = '" & Me.txtCodigo.Text & "' "

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Sub
        Dim n As Integer

        If caso = 0 Then
            n = IdCuenta1.Length
            ReDim Preserve IdCuenta1(n)
            IdCuenta1(n - 1) = rstReader(0)
        Else
            n = IdCuenta2.Length
            ReDim Preserve IdCuenta2(n)
            IdCuenta2(n - 1) = rstReader(0)
        End If

        cnnConexion.Close()

        txtHaber.Text = Format(0, "###,##0.00")
        txtDebe.Text = Format(0, "###,##0.00")
        txtCodigo.Clear()
        txtDescripcion.Clear()
        LlenarTotalesAsiento1()
        Me.btnModificar.Enabled = False
    End Sub
#End Region

#Region "Funciones Basicas"
    Private Sub NUEVO()
        Accion = "AUT"
        Try
            If Me.ToolBarNuevo.Text = "Nuevo" Then
                Me.ToolBarNuevo.ImageIndex = "3"
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.btnGenerarVenta.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnDetalle.Enabled = False
                dtpFechaInicio.Focus()

            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnGenerarVenta.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                Me.dtpFechaFinal.Enabled = False
                Me.btnModificar.Enabled = False
                Me.btnDetalle.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()
        Me.griDetalle.Refresh()
        Me.txtTotalHaber.Text = ""
        Me.txtTotalDebe.Text = ""
    End Sub

    Private Sub Generar()
        Dim Fx As New cFunciones
        bd = dtsAsientoVenta.PuntoVenta(ComboBox1.SelectedIndex).BaseDatos

        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Fx.ValidarPeriodo(dtpFechaFinal.Value) = False Then
            MsgBox("La fecha del asiento NO corresponde al periodo de trabajo! O el periodo esta cerrado!" & vbCrLf & "No se puede Generar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
            Exit Sub
        End If
        caso = 0

        If Buscar() = False Then
            MsgBox("No se encontraron Cortesias para esta fecha")
            Exit Sub
        End If

        Me.LlenarGriDetalleAsiento1()
        If LlenarTotalesAsiento1() = True Then
            Accion = "AUT"
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFinal.Enabled = False
            Me.ToolBarRegistrar.Enabled = True
            Me.txtDebe.Text = Format(0, "###,##0.00")
            Me.txtHaber.Text = Format(0, "###,##0.00")
            Me.btnDetalle.Enabled = True
            caso = 0
        End If
    End Sub

    Private Function Buscar() As Boolean
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer
        Dim sql As String
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " SELECT " & Me.bd & ".dbo.Comanda.CuentaContable FROM " & Me.bd & ".dbo.Comanda INNER JOIN " & Me.bd & ".dbo.DetalleMenuComanda " & _
                "ON " & Me.bd & ".dbo.Comanda.Idcomanda = " & Me.bd & ".dbo.DetalleMenuComanda.IdComanda INNER JOIN " & _
                "" & Me.bd & ".dbo.Menu_Restaurante ON " & Me.bd & ".dbo.DetalleMenuComanda.Idmenu = " & Me.bd & ".dbo.Menu_Restaurante.Id_Menu " & _
                "INNER JOIN " & Me.bd & ".dbo.Cortesia ON " & Me.bd & ".dbo.Comanda.NumeroCortesia = " & Me.bd & ".dbo.Cortesia.Numero_Cortesia " & _
                "WHERE (" & Me.bd & ".dbo.Comanda.Cortesia = 1) AND (" & Me.bd & ".dbo.Comanda.Anulado = 0) AND (" & Me.bd & ".dbo.Cortesia.Contabilizado = 0) AND " & _
                "" & Me.bd & ".dbo.Comanda.Fecha BETWEEN " & fecIni & " AND " & fecFin & _
                "GROUP BY " & Me.bd & ".dbo.Comanda.CuentaContable"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 0
        Do While rstReader.Read
            ReDim Preserve IdCuenta1(n + 1)
            IdCuenta1(n) = rstReader(0)
            n = n + 1
        Loop

        rstReader.Close()
        If n = 0 Then Exit Function

        sql = " SELECT " & Me.bd & ".dbo.Menu_Restaurante.bodega FROM " & Me.bd & ".dbo.Comanda INNER JOIN " & Me.bd & ".dbo.DetalleMenuComanda " & _
                "ON " & Me.bd & ".dbo.Comanda.Idcomanda = " & Me.bd & ".dbo.DetalleMenuComanda.IdComanda INNER JOIN " & _
                "" & Me.bd & ".dbo.Menu_Restaurante ON " & Me.bd & ".dbo.DetalleMenuComanda.Idmenu = " & Me.bd & ".dbo.Menu_Restaurante.Id_Menu " & _
                "INNER JOIN " & Me.bd & ".dbo.Cortesia ON " & Me.bd & ".dbo.Comanda.NumeroCortesia = " & Me.bd & ".dbo.Cortesia.Numero_Cortesia " & _
                "WHERE (" & Me.bd & ".dbo.Menu_Restaurante.Tipo = 2) AND (" & Me.bd & ".dbo.Comanda.Cortesia = 1) AND (" & Me.bd & ".dbo.Comanda.Anulado = 0) AND (" & Me.bd & ".dbo.Cortesia.Contabilizado = 0) AND " & _
                "" & Me.bd & ".dbo.Comanda.Fecha BETWEEN " & fecIni & " AND " & fecFin & _
                "GROUP BY " & Me.bd & ".dbo.Menu_Restaurante.bodega"
        sql &= " UNION " & _
        " SELECT " & Me.bd & ".dbo.MenuRecetaBodega.bodega FROM " & Me.bd & ".dbo.Comanda INNER JOIN " & Me.bd & ".dbo.DetalleMenuComanda " & _
                        "ON " & Me.bd & ".dbo.Comanda.Idcomanda = " & Me.bd & ".dbo.DetalleMenuComanda.IdComanda INNER JOIN " & _
                        "" & Me.bd & ".dbo.MenuRecetaBodega ON " & Me.bd & ".dbo.DetalleMenuComanda.Idmenu = " & Me.bd & ".dbo.MenuRecetaBodega.Id_Menu " & _
                        "INNER JOIN " & Me.bd & ".dbo.Cortesia ON " & Me.bd & ".dbo.Comanda.NumeroCortesia = " & Me.bd & ".dbo.Cortesia.Numero_Cortesia " & _
                        "WHERE (" & Me.bd & ".dbo.Comanda.Cortesia = 1) AND (" & Me.bd & ".dbo.Comanda.Anulado = 0) AND (" & Me.bd & ".dbo.Cortesia.Contabilizado = 0) AND " & _
                        "" & Me.bd & ".dbo.Comanda.Fecha BETWEEN " & fecIni & " AND " & fecFin & _
                        "GROUP BY " & Me.bd & ".dbo.MenuRecetaBodega.bodega"

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 0
        Do While rstReader.Read
            ReDim Preserve IdCuenta2(n + 1)
            IdCuenta2(n) = rstReader(0)
            n = n + 1
        Loop
        If n = 0 Then Exit Function
        cnnConexion.Close()
        Buscar = True
    End Function

    Private Sub Registrar()
        If caso = 0 Then
            RegistrarAsiento1()
        End If
    End Sub

    Private Sub RegistrarAsiento1()
        If ValidarCampos() = False Then Exit Sub

        Dim clsConexion As New Conexion
        Dim clsConexion2 As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim cnnConexion2 As New System.Data.SqlClient.SqlConnection
        Dim rstReader, rstReader2 As SqlClient.SqlDataReader
        Dim sql, sql2 As String
        Dim periodo As String
        Dim NumAsiento As String
        Dim fecIni, fecFin As String
        If MsgBox("Desea Guardar asiento de Cortesia", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"
        periodo = Fx.BuscaPeriodo(dtpFechaFinal.Value)
        NumAsiento = Fx.BuscaNumeroAsiento("COR-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " INSERT INTO AsientosContables " & _
" (NumAsiento,Fecha,NumDoc,Beneficiario,TipoDoc, " & _
" Accion,Anulado,FechaEntrada,Mayorizado, " & _
" Periodo,NumMayorizado,Modulo,Observaciones, " & _
" NombreUsuario,TotalDebe,TotalHaber,TipoCambio) " & _
" VALUES('" & NumAsiento & "','" & dtpFechaFinal.Value.Date & "',9999,'BENE',21, " & _
" '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
" 'Asiento de Cortesia','Asiento automático de Cortesia desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "','" & Me.txtUsuario.Text & "' " & _
" ," & MonedaToDouble(Me.txtTotalDebe.Text) & "," & MonedaToDouble(Me.txtTotalHaber.Text) & "," & Fx.TipoCambio(dtpFechaFinal.Value) & ") "

        clsConexion.SlqExecute(cnnConexion, sql)
        cnnConexion.Close()

        RegistrarDetalleAsiento1(NumAsiento)

        cnnConexion2.ConnectionString = Configuracion.Claves.Conexion("Restaurante")
        cnnConexion2.Open()

        sql = " SELECT " & Me.bd & ".dbo.Comanda.NumeroCortesia FROM " & Me.bd & ".dbo.Comanda INNER JOIN " & Me.bd & ".dbo.DetalleMenuComanda " &
                        "ON " & Me.bd & ".dbo.Comanda.Idcomanda = " & Me.bd & ".dbo.DetalleMenuComanda.IdComanda INNER JOIN " &
                        "" & Me.bd & ".dbo.Menu_Restaurante ON " & Me.bd & ".dbo.DetalleMenuComanda.Idmenu = " & Me.bd & ".dbo.Menu_Restaurante.Id_Menu " &
                        "INNER JOIN " & Me.bd & ".dbo.Cortesia ON " & Me.bd & ".dbo.Comanda.NumeroCortesia = " & Me.bd & ".dbo.Cortesia.Numero_Cortesia " &
                        "WHERE (" & Me.bd & ".dbo.Comanda.Cortesia = 1) AND (" & Me.bd & ".dbo.Comanda.Anulado = 0) AND (" & Me.bd & ".dbo.Cortesia.Contabilizado = 0) AND " &
                        "" & Me.bd & ".dbo.Comanda.Fecha BETWEEN " & fecIni & " AND " & fecFin &
                        "GROUP BY " & Me.bd & ".dbo.Comanda.NumeroCortesia"
        rstReader2 = clsConexion2.GetRecorset(cnnConexion2, sql)

        Do While rstReader2.Read
            cnnConexion.Open()
            sql = "UPDATE " & Me.bd & ".dbo.Cortesia SET Contabilizado = 1 ,num_asiento  = '" & NumAsiento & "' WHERE Numero_Cortesia = " & rstReader2(0)
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()
        Loop
        cnnConexion2.Close()


        MsgBox("Los datos han sido registrados correctamente", MsgBoxStyle.Information)
        NUEVO()
    End Sub

    Private Sub RegistrarDetalleAsiento1(ByVal pNumAsiento As String)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim sql As String
        Dim n, m As Integer
        Dim debe, haber As Byte
        Dim monto As Double

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")

        For n = 0 To Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Count - 1
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                If .Debe = 0 Then
                    haber = 1
                    debe = 0
                    monto = .Haber
                Else
                    debe = 1
                    haber = 0
                    monto = .Debe
                End If

                If monto <> 0 Then
                    cnnConexion.Open()
                    sql = " INSERT INTO DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento,TipoCambio) " &
                    " VALUES('" & pNumAsiento & "','" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático de Cortesia desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "'," & Fx.TipoCambio(dtpFechaFinal.Value) & ") "
                    clsConexion.SlqExecute(cnnConexion, sql)
                    cnnConexion.Close()
                End If
            End With
        Next
    End Sub
#End Region

#Region "Funciones Iniciacion"
    Private Sub Cargar()
        Limpiar()
        ActivarGui()
        Me.dtpFechaFinal.Value = Date.Now.Date
        Me.dtpFechaInicio.Value = Date.Now.Date
        cFunciones.Llenar_Tabla_Generico("Select * From PuntoVenta WHERE (Tipo = 'RESTAURANTE' OR Tipo = 'BAR')", Me.dtsAsientoVenta.PuntoVenta, Configuracion.Claves.Conexion("Hotel"))

    End Sub

    Private Sub ActivarGui()
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
        Me.btnGenerarVenta.Enabled = False
        Me.btnModificar.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
    End Sub

    Private Sub Limpiar()
        Accion = "AUT"
        Dim n As Integer
        ' se inicializa el venctor donde se guardan las cuentas que estan guardadas en Contabilidad.SettingCuentaFacturaVenta
        For n = 0 To IdCuenta1.Length - 2
            IdCuenta1(n) = -1
        Next

        For n = 0 To IdCuenta2.Length - 2
            IdCuenta2(n) = -1
        Next

        Me.txtTotalDebe.Text = ""
        Me.txtTotalHaber.Text = ""
    End Sub
#End Region

#Region "Funciones Llenar"
    ' este es para llenar el grid con los asientos de venta
    Private Sub LlenarGriDetalleAsiento1()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String
        Dim n, m As Integer
        Dim fecIni, fecFin As String

        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"
        sql = ""

        For n = 0 To IdCuenta1.Length - 2
            If n > 0 Then sql = sql & " UNION "
            sql = sql & " " &
            " ( " &
            " select " & (n + 1) & " AS ID, C.CuentaContable AS Codigo,C.Descripcion, " &
" ( " &
" SELECT SUM(CD.Costo_real) FROM " & Me.bd & ".dbo.Comanda R, " & Me.bd & ".dbo.DetalleMenuComanda CD , " & Me.bd & ".dbo.Cortesia RD " &
" WHERE  R.Anulado = 0 And RD.Contabilizado = 0 " &
" AND r.fecha >=  " & fecIni &
" and r.fecha <= " & fecFin &
" AND RD.Numero_Cortesia = r.NumeroCortesia AND R.idComanda = CD.Idcomanda AND " &
" R.CuentaContable = C.CuentaContable COLLATE Traditional_Spanish_CI_AS) as Debe, 0 as Haber " &
" from  Contabilidad.dbo.CuentaContable C   " &
" WHERE C.CuentaContable = '" & IdCuenta1(n) & "'" &
" GROUP BY C.CuentaContable,C.Descripcion " &
" ) "
        Next

        m = n

        For n = 0 To IdCuenta2.Length - 2

            sql = sql & " UNION ( " &
              " SELECT " & (n + 1) + m & " AS ID,C.CuentaContable AS Codigo,C.Descripcion,0 as Debe, " &
" ( " &
" SELECT ISNULL(SUM(R.Costo_Real),0) FROM " & Me.bd & ".dbo.DetalleMenuComanda R , " & Me.bd & ".dbo.Comanda RD, " & Me.bd & ".dbo.Cortesia CT, " & Me.bd & ".dbo.Menu_Restaurante M, Proveeduria.dbo.Bodega B " &
" WHERE  M.Tipo = 2  AND RD.Anulado = 0 And CT.Contabilizado = 0 " &
" AND RD.fecha >=  " & fecIni &
" and RD.fecha <= " & fecFin &
" AND RD.idComanda = R.IdComanda AND RD.NumeroCortesia = CT.Numero_Cortesia AND R.IdMenu = M.Id_Menu AND M.Bodega = B.IdBodega AND B.IdBodega = " & IdCuenta2(n) & ") + " &
" ( " &
" SELECT ISNULL(SUM(R.Costo_Real),0) FROM " & Me.bd & ".dbo.DetalleMenuComanda R , " & Me.bd & ".dbo.Comanda RD, " & Me.bd & ".dbo.Cortesia CT, " & Me.bd & ".dbo.MenuRecetaBodega M, Proveeduria.dbo.Bodega B " &
" WHERE  RD.Anulado = 0 And CT.Contabilizado = 0 " &
" AND RD.fecha >=  " & fecIni &
" and RD.fecha <= " & fecFin &
" AND RD.idComanda = R.IdComanda AND RD.NumeroCortesia = CT.Numero_Cortesia AND R.IdMenu = M.Id_Menu AND M.Bodega = B.IdBodega AND B.IdBodega = " & IdCuenta2(n) & ")  as Haber " &
" FROM  Contabilidad.dbo.CuentaContable C, Proveeduria.dbo.Bodega B " &
" WHERE C.CuentaContable = B.CuentaContable COLLATE Traditional_Spanish_CI_AS AND B.IdBodega = " & IdCuenta2(n) & " " &
" GROUP BY C.CuentaContable,C.Descripcion,B.IdBodega " &
    " ) "
        Next

        '        For n = 0 To IdCuenta2.Length - 2

        '            sql = sql & " UNION ( " & _
        '              " SELECT " & (n + 1) + m & " AS ID,C.CuentaContable AS Codigo,C.Descripcion,0 as Debe, " & _
        '" ( " & _
        '" SELECT ISNULL(SUM(R.Costo_Real),0) FROM " & Me.bd & ".dbo.DetalleMenuComanda R , " & Me.bd & ".dbo.Comanda RD, " & Me.bd & ".dbo.Cortesia CT, " & Me.bd & ".dbo.MenuRecetaBodega M, Proveeduria.dbo.Bodega B " & _
        '" WHERE  RD.Anulado = 0 And CT.Contabilizado = 0 " & _
        '" AND RD.fecha >=  " & fecIni & _
        '" and RD.fecha <= " & fecFin & _
        '" AND RD.idComanda = R.IdComanda AND RD.NumeroCortesia = CT.Numero_Cortesia AND R.IdMenu = M.Id_Menu AND M.Bodega = B.IdBodega AND B.IdBodega = " & IdCuenta2(n) & ") as Haber " & _
        '" FROM  Contabilidad.dbo.CuentaContable C, Proveeduria.dbo.Bodega B " & _
        '" WHERE C.CuentaContable = B.CuentaContable COLLATE Traditional_Spanish_CI_AS AND B.IdBodega = " & IdCuenta2(n) & "  " & _
        '" GROUP BY C.CuentaContable,C.Descripcion,B.IdBodega " & _
        '    " ) "
        '        Next

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta")
    End Sub

    ' para calcular los totales del debe y haber de los asientos de venta
    Private Function LlenarTotalesAsiento1() As Boolean
        LlenarTotalesAsiento1 = True
        Dim THaber, TDebe As Double
        Dim n As Integer
        THaber = 0
        TDebe = 0

        For n = 0 To Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Count - 1
            ' If Not dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n).RowState = DataRowState.Deleted Then

            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                THaber = THaber + .Haber
                TDebe = TDebe + .Debe
            End With

            ' End If
        Next
        'For n = 0 To Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Count - 1
        '    If Not dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n).RowState = DataRowState.Deleted Then
        '        If dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n).Debe = 0 And dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n).Haber = 0 Then
        '            Me.BindingContext(Me.dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta").Position = n
        '            Me.BindingContext(Me.dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta").RemoveAt(n)
        '            Me.BindingContext(Me.dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta").EndCurrentEdit()



        '        End If

        '    End If
        'Next

        Me.txtTotalDebe.Text = Format(TDebe, "¢###,##0.00")
        Me.txtTotalHaber.Text = Format(THaber, "¢###,##0.00")

        If THaber = 0 Or TDebe = 0 Then
            LlenarTotalesAsiento1 = False
        End If
    End Function
#End Region

#Region "Funciones Validar"
    Private Function ValidarIdCuenta1() As Boolean
        Dim n As Integer

        For n = 0 To IdCuenta1.Length - 2
            If IdCuenta1(n) = -1 Then
                Exit Function
            End If
        Next
        ValidarIdCuenta1 = True
    End Function

    Private Function ValidarIdCuenta2() As Boolean
        Dim n As Integer

        For n = 0 To IdCuenta2.Length - 2
            If IdCuenta2(n) = -1 Then
                Exit Function
            End If
        Next
        ValidarIdCuenta2 = True
    End Function

    Private Function ValidarCampos() As Boolean
        If Me.txtTotalHaber.Text <> Me.txtTotalDebe.Text Then
            MsgBox("No se puede registrar porque el balance no es correcto", MsgBoxStyle.Information)
            Exit Function
        End If

        If Me.txtTotalHaber.Text = "" Or Me.txtTotalDebe.Text = "" Then
            MsgBox("No se puede registrar porque el balance no es correcto", MsgBoxStyle.Information)
            Exit Function
        End If
        ValidarCampos = True
    End Function
#End Region

#Region "Funciones Seguridad"
    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try

            If txtClave.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT  Nombre from Usuarios where Clave_Interna ='" & txtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        NombreUsuario = rs("Nombre")
                        txtUsuario.Text = rs("Nombre")
                        txtUsuario.Enabled = False
                        txtClave.Enabled = False
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Return True

                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Function Conectando() As SqlConnection
        Dim sQlconexion As New SqlConnection
        Dim SQLStringConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = Configuracion.Claves.Conexion("Seguridad")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function
#End Region

#Region "Funciones Otras"
    Private Sub LlamarFmrBuscarAsientoVenta()
        If caso = -1 Then
            MsgBox("Selecione el campo donde quiere ingresar la cuenta")
            Exit Sub
        End If

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " &
                            " where Movimiento=1 "
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub

        Me.txtCodigo.Text = busca.codigo
        Me.txtDescripcion.Text = busca.descrip
        Me.txtDebe.Focus()
    End Sub

    Private Sub BuscarCuentaContable()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT descripcion  FROM CuentaContable where CuentaContable = '" & Me.txtCodigo.Text & "' "

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then
            Me.txtCodigo.Text = ""
            Me.txtDescripcion.Text = ""
            Exit Sub
        End If

        Me.txtDescripcion.Text = rstReader(0)
        Me.txtDebe.Focus()
        cnnConexion.Close()
    End Sub

    Private Function FormatoDouble(ByVal valor As String) As String
        Dim n As Integer = -1
        n = valor.IndexOf(",")
        If n <> -1 Then
            valor = valor.Remove(n, 1)
            valor = valor.Insert(n, ".")
        End If
        Return valor
    End Function

    Private Function MonedaToDouble(ByVal valor As String) As String
        Dim n As Integer = -1
        n = valor.IndexOf(",")

        Do While n <> -1
            valor = valor.Remove(n, 2)
            n = valor.IndexOf(",")
        Loop

        If valor.Length > 1 Then valor = Mid(valor, 2)
        Return valor
    End Function
#End Region

#Region "Reporte"
    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Reporte()
    End Sub

    Private Sub Reporte()
        Try
            If Me.bd.Equals("RESTAURANTE") Then
                Dim reporte As New rptAsientoCortesia
                Dim visor As New frmVisorReportes
                Dim fecIni, fecFin As String

                fecIni = "  DateTime(" & dtpFechaInicio.Value.Year & "," & dtpFechaInicio.Value.Month & "," & dtpFechaInicio.Value.Day & " ,00,00,00)"
                fecFin = "  DateTime( " & dtpFechaFinal.Value.Year & "," & dtpFechaFinal.Value.Month & "," & dtpFechaFinal.Value.Day & ", 23,59,59)"

                reporte.RecordSelectionFormula = " {VistaCortesia.Fecha} in " & fecIni & " to " & fecFin
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, reporte, False, Configuracion.Claves.Conexion("Restaurante"))

                visor.Show()
            ElseIf Me.bd.Equals("BAR") Then
                Dim reporte As New rptAsientoCortesiaBAR
                Dim visor As New frmVisorReportes
                Dim fecIni, fecFin As String

                fecIni = "  DateTime(" & dtpFechaInicio.Value.Year & "," & dtpFechaInicio.Value.Month & "," & dtpFechaInicio.Value.Day & " ,00,00,00)"
                fecFin = "  DateTime( " & dtpFechaFinal.Value.Year & "," & dtpFechaFinal.Value.Month & "," & dtpFechaFinal.Value.Day & ", 23,59,59)"

                reporte.RecordSelectionFormula = " {VistaCortesia.Fecha} in " & fecIni & " to " & fecFin
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, reporte, False, Configuracion.Claves.Configuracion("Bar"))

                visor.Show()
            Else
                Dim reporte As New rptAsientoCortesiaBarSeco
                Dim visor As New frmVisorReportes
                Dim fecIni, fecFin As String

                fecIni = "  DateTime(" & dtpFechaInicio.Value.Year & "," & dtpFechaInicio.Value.Month & "," & dtpFechaInicio.Value.Day & " ,00,00,00)"
                fecFin = "  DateTime( " & dtpFechaFinal.Value.Year & "," & dtpFechaFinal.Value.Month & "," & dtpFechaFinal.Value.Day & ", 23,59,59)"

                reporte.RecordSelectionFormula = " {VistaCortesia.Fecha} in " & fecIni & " to " & fecFin
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, reporte, False, Configuracion.Claves.Configuracion("BarSeco"))

                visor.Show()

            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
#End Region

End Class
