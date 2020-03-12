Imports Utilidades
Imports System.Data.SqlClient
Public Class frmHotelPlanillaGeneracionAutomatica
    Inherits FrmPlantilla



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
    Friend WithEvents dtsAsientoVenta As Contabilidad.DatasetAsientoVenta

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHotelPlanillaGeneracionAutomatica))
        Me.btnModificar = New System.Windows.Forms.Button
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
        Me.dtsAsientoVenta = New Contabilidad.DatasetAsientoVenta
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
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(630, 32)
        Me.TituloModulo.Text = "Planilla"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 375)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(630, 52)
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(279, 159)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 221
        Me.btnModificar.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(87, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 224
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(87, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 223
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(31, 135)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 19)
        Me.txtCodigo.TabIndex = 217
        Me.txtCodigo.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 230
        Me.Label3.Text = "Codigo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHaber
        '
        Me.txtHaber.EditValue = ""
        Me.txtHaber.Location = New System.Drawing.Point(471, 135)
        Me.txtHaber.Name = "txtHaber"
        '
        'txtHaber.Properties
        '
        Me.txtHaber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Size = New System.Drawing.Size(132, 21)
        Me.txtHaber.TabIndex = 220
        '
        'txtDebe
        '
        Me.txtDebe.EditValue = ""
        Me.txtDebe.Location = New System.Drawing.Point(335, 135)
        Me.txtDebe.Name = "txtDebe"
        '
        'txtDebe.Properties
        '
        Me.txtDebe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Size = New System.Drawing.Size(131, 21)
        Me.txtDebe.TabIndex = 219
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(183, 135)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(148, 19)
        Me.txtDescripcion.TabIndex = 218
        Me.txtDescripcion.Text = ""
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(471, 351)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 229
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(319, 351)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 228
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(423, 403)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 226
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(343, 403)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 213
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(471, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 233
        Me.Label6.Text = "Haber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(335, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 232
        Me.Label5.Text = "Debe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(183, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 14)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Descripcion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(15, 191)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(600, 152)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 222
        Me.griDetalle.Text = "Asientos de venta"
        '
        'dtsAsientoVenta
        '
        Me.dtsAsientoVenta.DataSetName = "DatasetAsientoVenta"
        Me.dtsAsientoVenta.Locale = New System.Globalization.CultureInfo("en-US")
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
        Me.Label9.Location = New System.Drawing.Point(423, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 227
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(343, 387)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 225
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Location = New System.Drawing.Point(367, 47)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(184, 23)
        Me.btnGenerarVenta.TabIndex = 216
        Me.btnGenerarVenta.Text = "Generar asiento "
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(247, 79)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 215
        Me.dtpFechaFinal.Value = New Date(2007, 5, 15, 17, 38, 13, 140)
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(247, 47)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 214
        Me.dtpFechaInicio.Value = New Date(2007, 5, 15, 17, 38, 13, 140)
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(18, 347)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.TabIndex = 234
        Me.btnDetalle.Text = "Detalle"
        Me.btnDetalle.Visible = False
        '
        'frmHotelPlanillaGeneracionAutomatica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(630, 427)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.btnModificar)
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
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnGenerarVenta)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Name = "frmHotelPlanillaGeneracionAutomatica"
        Me.Text = "Planilla: Generación automática de asiento"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarVenta, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.griDetalle, 0)
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
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.btnDetalle, 0)
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String
    Dim IdCuenta1a(1) As Integer
    Dim IdCuenta1b(1) As Integer
    Dim caso As Byte ' para indica si lo que va ha registrar es un asiento de venta o una asiento de costo de venta, 0 = venta, 1 = costo venta
    Dim Accion As String
    Dim nPlanilla As String
    Dim Tipocambio As Double

#Region "Funciones GUI"

    Private Sub frmAsientoVentaGeneracionAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim x As Utilidades
        Cargar()
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

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : NUEVO()

            Case 2 : Registrar()

            Case 6 : Close()
        End Select
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarVenta.Click
        If dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        caso = 0
        LlenarGriDetalleAsiento1()
        If LlenarTotalesAsiento1() = True Then
            Accion = "AUT"
            dtpFechaInicio.Enabled = False
            dtpFechaFinal.Enabled = False
            ToolBarRegistrar.Enabled = True
            txtDebe.Text = Format(0, "###,##0.00")
            txtHaber.Text = Format(0, "###,##0.00")
            btnModificar.Enabled = True
            btnDetalle.Enabled = True
            caso = 0
            txtCodigo.Focus()
        End If
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

            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnGenerarVenta.Enabled = False

                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
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

 

    Private Sub Registrar()
        If caso = 0 Then
            RegistrarAsiento1()
        End If

    End Sub

    Private Sub RegistrarAsiento1()
        If ValidarCampos() = False Then Exit Sub
        Dim clsConexion As New Conexion : Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As SqlClient.SqlDataReader : Dim sql As String : Dim periodo As String
        Dim NumAsiento As String : Dim fecIni, fecFin As String
        Dim Fx As New cFunciones
        If MsgBox("Desea Guardar asiento de Planilla", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        Try
            fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
            fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"
            periodo = Fx.BuscaPeriodo(dtpFechaFinal.Value)

            '-------------------------------------------------------------------------------
            'VALIDA EL PERIODO DE TRABAJO
            If Fx.ValidarPeriodo(dtpFechaFinal.Value) = False Then
                MsgBox("La Fecha del Asiento No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
                Exit Sub
            End If
            '-------------------------------------------------------------------------------

            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            cnnConexion.Open()

            NumAsiento = Fx.BuscaNumeroAsiento("PLA-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")
            sql = " INSERT INTO AsientosContables " & _
    " (NumAsiento,Fecha,NumDoc,Beneficiario,TipoDoc, " & _
    " Accion,Anulado,FechaEntrada,Mayorizado, " & _
    " Periodo,NumMayorizado,Modulo,Observaciones, " & _
    " NombreUsuario,TotalDebe,TotalHaber, CodMoneda, TipoCambio) " & _
    " VALUES('" & NumAsiento & "' ,'" & dtpFechaFinal.Value.Date & "',9999,'BENE',14, " & _
    " '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
    " 'Asiento Planilla','Asiento automático Planilla desde: " & dtpFechaInicio.Value.Date & " hasta: " & dtpFechaFinal.Value.Date & "','" & txtUsuario.Text & "' " & _
    " ," & MonedaToDouble(txtTotalDebe.Text) & "," & MonedaToDouble(txtTotalHaber.Text) & ", 1 ," & Tipocambio & " ) "
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()

            RegistrarDetalleAsiento1(NumAsiento, Tipocambio)

            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Planilla")
            cnnConexion.Open()
            sql = " UPDATE Planilla SET Contabilizado = 1 ,num_asiento  = '" & NumAsiento & "'  WHERE Contabilizado = 0 and anulado = 0  AND  " &
                    " fecha >= " & fecIni & " and fecha <= " & fecFin & " and FormaPago = 1"
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()

            MsgBox("El asiento de Planilla se generó correctamente", MsgBoxStyle.Information)
            NUEVO()
        Catch ex As Exception
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Alerta...")
        End Try
    End Sub

    Private Sub RegistrarDetalleAsiento1(ByVal pNumAsiento As String, ByVal TipoCambioD As Double)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim sql As String
        Dim n As Integer
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
                    sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento,tipocambio) " &
                    " VALUES('" & pNumAsiento & "','" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático planilla desde: " & dtpFechaInicio.Value.Date & " hasta: " & dtpFechaFinal.Value.Date & "'," & TipoCambioD & ") "
                    clsConexion.SlqExecute(cnnConexion, sql)
                    cnnConexion.Close()
                End If
            End With
        Next


    End Sub


#End Region

#Region "Funciones Iniciacion"

    Private Sub Cargar()

        ActivarGui()
        Me.dtpFechaFinal.Value = Date.Now.Date
        Me.dtpFechaInicio.Value = Date.Now.Date
    End Sub

    Private Sub ActivarGui()
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
        Me.btnGenerarVenta.Enabled = False
        Me.btnDetalle.Enabled = False

        Me.btnModificar.Enabled = False
    End Sub


#End Region

#Region "Funciones Llenar"
    ' este es para llenar el grid con los asientos de venta
    Private Sub LlenarGriDetalleAsiento1()
        Try


            Dim cnnConexion As New SqlClient.SqlConnection
            Dim adpAdapter1 As New SqlClient.SqlDataAdapter
            Dim sqlCommand As New System.Data.SqlClient.SqlCommand
            Dim rs As System.Data.SqlClient.SqlDataReader
            Dim sql As String
            Dim dts1 As New DataSet
            Dim i As Integer
            Dim nombreCuenta As String

            Dim fecIni, fecFin As String

            Dim cuentaAdelanto, cuentaPrestamo, desAdelanto, desPretamo, CuentaRenta, desRenta, CuentaOtrosIng, DescOtrosIng, CuentaInteresPres, DescInteresPres, CuentaCuentaCobrar, DescCuentaCobrar As String
            Dim iAdelanto, iPrestamo, iRenta, icxccol, icxcdol, iRentaCol, iRentaDol, iOtrosIngc, iInteresPresc, iCxCc, iOtrosIngd, iInteresPresd, iCxCd, iOtrosIng, iInteresPres, iCxC As Double

            fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
            fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"



            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Planilla")
            cnnConexion.Open()

            sqlCommand.Connection = cnnConexion

            sqlCommand.CommandText = "Delete from temporal"
            sqlCommand.ExecuteNonQuery()


            sqlCommand.CommandText = "Select id_planilla from planilla where FechaFinal BETWEEN " & fecIni & " AND " & fecFin & "and Contabilizado = 0 and Serv_Prof = 0"
            rs = sqlCommand.ExecuteReader
            While rs.Read
                If nPlanilla = vbNullString Then
                    nPlanilla = rs(0)
                Else
                    nPlanilla = nPlanilla & "," & rs(0)
                End If
            End While
            rs.Close()

            If Trim(nPlanilla) = vbNullString Then
                Exit Sub
            End If

            sql = "Select * from vistaEmpleado where id_planilla in(" & nPlanilla & ")"

            sqlCommand.Connection = cnnConexion
            sqlCommand.CommandText = sql
            adpAdapter1.SelectCommand = sqlCommand

            adpAdapter1.Fill(dts1, "Planilla")
            'Datos para la planilla en General
            For i = 0 To dts1.Tables("Planilla").Rows.Count() - 1
                sqlCommand.CommandText = "Select descripcion from contabilidad.dbo.cuentaContable where cuentaContable = '" & dts1.Tables("Planilla").Rows(i).Item(4) & "'"
                nombreCuenta = sqlCommand.ExecuteScalar
                If dts1.Tables("Planilla").Rows(i).Item(12) = 100 Then '100 es el porcentaje del 100% que corresponde a Salario Bruto.
                    RegistraCuentaContable(sqlCommand, dts1.Tables("Planilla").Rows(i).Item(13), dts1.Tables("Planilla").Rows(i).Item(4), nombreCuenta, (dts1.Tables("Planilla").Rows(i).Item(5) * -1), 0) 'salario
                Else
                    RegistraCuentaContable(sqlCommand, dts1.Tables("Planilla").Rows(i).Item(6), dts1.Tables("Planilla").Rows(i).Item(4), nombreCuenta, (dts1.Tables("Planilla").Rows(i).Item(5) * -1), 0) 'salario
                End If

            Next
            '-----------------------------------------------------------------------------------
            Dim r As Integer = 0

            'Devuelve las cuentas de los Adelantos
            sqlCommand.CommandText = "select cc.cuentacontable,cc.descripcion from contabilidad.dbo.cuentacontable as cc, contabilidad.dbo.SettingCuentaContable as sc where cc.id = sc.idCXCEmpCol"
            rs = sqlCommand.ExecuteReader
            While rs.Read()
                cuentaAdelanto = rs(0)
                desAdelanto = rs(1)
            End While
            rs.Close()

            'Devuelve las cuentas de los Préstamos
            sqlCommand.CommandText = "select cc.cuentacontable,cc.descripcion from contabilidad.dbo.cuentacontable as cc, contabilidad.dbo.SettingCuentaContable as sc where cc.id = sc.idCXCEmpDol"
            rs = sqlCommand.ExecuteReader
            While rs.Read
                cuentaPrestamo = rs(0)
                desPretamo = rs(1)
            End While
            rs.Close()

            'Devuelve la cuenta y descripción de la Renta
            sqlCommand.CommandText = "select cc.cuentacontable,cc.descripcion from contabilidad.dbo.cuentacontable as cc, contabilidad.dbo.SettingCuentaContable as sc where cc.id=sc.idrenta"
            rs = sqlCommand.ExecuteReader
            While rs.Read
                CuentaRenta = rs(0)
                desRenta = rs(1)
            End While
            rs.Close()

            'Devuelve la cuenta y descripción de Otros Ingresos
            sqlCommand.CommandText = "select cc.cuentacontable,cc.descripcion from contabilidad.dbo.cuentacontable as cc, contabilidad.dbo.SettingCuentaContable as sc where cc.id = sc.IdOtrosIng"
            rs = sqlCommand.ExecuteReader
            While rs.Read
                CuentaOtrosIng = rs(0)
                DescOtrosIng = rs(1)
            End While
            rs.Close()

            'Devuelve la cuenta y descripción de Intereses sobre préstamos
            sqlCommand.CommandText = "select cc.cuentacontable,cc.descripcion from contabilidad.dbo.cuentacontable as cc, contabilidad.dbo.SettingCuentaContable as sc where cc.id=sc.IdInteresPres"
            rs = sqlCommand.ExecuteReader
            While rs.Read
                CuentaInteresPres = rs(0)
                DescInteresPres = rs(1)
            End While
            rs.Close()

            'Devuelve la cuenta y descripción de Cuentas x Cobrar comerciales
            sqlCommand.CommandText = "select cc.cuentacontable,cc.descripcion from contabilidad.dbo.cuentacontable as cc, contabilidad.dbo.SettingCuentaContable as sc where cc.id=sc.IdCuentaCobrar"
            rs = sqlCommand.ExecuteReader
            While rs.Read
                CuentaCuentaCobrar = rs(0)
                DescCuentaCobrar = rs(1)
            End While
            rs.Close()

            'Devuelve el tipo cambio del día
            sqlCommand.CommandText = "Select ValorVenta from Moneda where CodMoneda =2"
            rs = sqlCommand.ExecuteReader
            While rs.Read()
                Tipocambio = rs(0)
            End While
            rs.Close()

            'Devuelve el acumulado de adelantos prestamos y renta de las planillas seleccionadas de la moneda colones
            sqlCommand.CommandText = "Select isnull(sum(adelantos),0) as Adelantos,isnull(sum(prestamos),0) as Prestamos,isnull(sum(renta),0) as Renta, isnull(sum(Otros_Ingresos),0) as OtrosIngresos, isnull(sum(Prestamos_Int),0) as IntPrestamos, isnull(sum(CuentasxCobrar),0) as CtaxCobrar from planilla_detalle where id_planilla in(" & nPlanilla & ") and Cod_Moneda =1"
            rs = sqlCommand.ExecuteReader
            While rs.Read()
                iAdelanto = rs(0)
                iPrestamo = rs(1)
                iRentaCol = Math.Round(rs(2), 2)
                iOtrosIngc = Math.Round(rs(3), 2)
                iInteresPresc = Math.Round(rs(4), 2)
                iCxCc = Math.Round(rs(5), 2)
            End While
            rs.Close()
            icxccol = iAdelanto + iPrestamo

            'Devuelve el acumulado de adelantos prestamos y renta de las planillas seleccionadas de la moneda dolares
            sqlCommand.CommandText = "Select isnull(sum(adelantos),0) as Adelantos,isnull(sum(prestamos),0) as Prestamos,isnull(sum(renta),0) as Renta, isnull(sum(Otros_Ingresos),0) as OtrosIngresos, isnull(sum(Prestamos_Int),0) as IntPrestamos, isnull(sum(CuentasxCobrar),0) as CtaxCobrar from planilla_detalle where id_planilla in(" & nPlanilla & ") and Cod_Moneda =2"
            rs = sqlCommand.ExecuteReader
            While rs.Read()
                iAdelanto = (rs(0) * Tipocambio)
                iPrestamo = (rs(1) * Tipocambio)
                iRentaDol = (Math.Round(rs(2), 2) * Tipocambio)
                iOtrosIngd = (Math.Round(rs(3), 2) * Tipocambio)
                iInteresPresd = (Math.Round(rs(4), 2) * Tipocambio)
                iCxCd = (Math.Round(rs(5), 2) * Tipocambio)
            End While
            rs.Close()
            icxcdol = iAdelanto + iPrestamo
            iRenta = iRentaCol + iRentaDol
            iOtrosIng = iOtrosIngc + iOtrosIngd
            iInteresPres = iInteresPresc + iInteresPresd
            iCxC = iCxCc + iCxCd

            RegistraCuentaContable(sqlCommand, iOtrosIng, CuentaOtrosIng, DescOtrosIng, 1, 0) 'Otros ingresos del empleado
            RegistraCuentaContable(sqlCommand, icxccol, cuentaAdelanto, desAdelanto, 0, 1)  'adelantos
            RegistraCuentaContable(sqlCommand, icxcdol, cuentaPrestamo, desPretamo, 0, 1) 'prestamos
            RegistraCuentaContable(sqlCommand, iInteresPres, CuentaInteresPres, DescInteresPres, 0, 1)
            RegistraCuentaContable(sqlCommand, iCxC, CuentaCuentaCobrar, DescCuentaCobrar, 0, 1) 'Cuentas x Cobrar de consumo del empleado
            RegistraCuentaContable(sqlCommand, iRenta, CuentaRenta, desRenta, 0, 1) 'Renta


            '--------------------------------------------------------------------------


            'Datos para las deducciones
            sql = "Select sum(monto)as monto, cuentaContable, descripcion " &
              "from VistaDeducciones " &
              "where Id_Planilla in(" & nPlanilla & ") group by cuentaContable, descripcion"

            dts1.Clear()
            sqlCommand.CommandText = sql
            adpAdapter1.SelectCommand = sqlCommand
            adpAdapter1.Fill(dts1, "datos")

            For i = 0 To dts1.Tables("datos").Rows.Count() - 1
                RegistraCuentaContable(sqlCommand, dts1.Tables("datos").Rows(i).Item(0), dts1.Tables("datos").Rows(i).Item(1), dts1.Tables("datos").Rows(i).Item(2), 0, 1)
            Next
            '--------------------------------------------------------------------------


            'Datos para la Forma de Pago
            sql = "Select sum(monto) as monto, CuentaContable, descripcion from vistaPago  " &
              "where id_planilla in (" & nPlanilla & ") group by cuentaContable, descripcion"

            dts1.Clear()
            sqlCommand.CommandText = sql
            adpAdapter1.SelectCommand = sqlCommand
            adpAdapter1.Fill(dts1, "datos1")

            For i = 0 To dts1.Tables("datos1").Rows.Count() - 1
                RegistraCuentaContable(sqlCommand, dts1.Tables("datos1").Rows(i).Item(0), dts1.Tables("datos1").Rows(i).Item(1), dts1.Tables("datos1").Rows(i).Item(2), 0, 1)
            Next
            '--------------------------------------------------------------------------

            dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()
            sqlCommand.Connection = cnnConexion
            sqlCommand.CommandText = "Select CuentaContable as Codigo, Descripcion, Debe, Haber from temporal "
            adpAdapter1.SelectCommand = sqlCommand
            adpAdapter1.Fill(dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta")

            adpAdapter1.Dispose()
            cnnConexion.Close()
        Catch ex As Exception
            MsgBox("ERROR: " & ex.ToString, MsgBoxStyle.OkOnly)

        End Try
    End Sub

    Private Sub RegistraCuentaContable(ByRef comando As SqlCommand, ByVal monto As Double, ByVal cuentacontable As String, ByVal nombreCuenta As String, ByVal debe As Double, ByVal haber As Double)
        Dim sql As String
        Dim tipo As String
        Dim iTipo As Integer

        If debe = 1 Then
            tipo = "debe"
            debe = monto
            iTipo = 1
        Else
            tipo = "Haber"
            haber = monto
            iTipo = 0
        End If
        'Dim dt As New DataTable
        'cFunciones.Llenar_Tabla_Generico("select * from temporal where cuentaContable = '" & cuentacontable & "' and tipo=" & iTipo & "", dt, Configuracion.Claves.Conexion("Planilla"))
        'If dt.Rows.Count > 0 Then
        '    comando.CommandText = "    update temporal set " & tipo & "=" & tipo & " + " & monto & " where cuentaContable='" & cuentacontable & "' and tipo=" & iTipo
        'Else
        '    comando.CommandText = "       insert into temporal (cuentaContable,descripcion,monto,debe,haber,tipo)values('" & cuentacontable & "','" & nombreCuenta & "',0," & debe & "," & haber & "," & iTipo & ") "
        'End If

        sql = "IF (EXISTS(select * from temporal where cuentaContable = '" & cuentacontable & "' and tipo=" & iTipo & ")) " &
              "        BEGIN " &
              "    update temporal set " & tipo & "=" & tipo & " + " & monto & " where cuentaContable='" & cuentacontable & "' and tipo=" & iTipo &
              "        End " &
              "        Else " &
              "            BEGIN " &
              "       insert into temporal (cuentaContable,descripcion,monto,debe,haber,tipo)values('" & cuentacontable & "','" & nombreCuenta & "',0," & debe & "," & haber & "," & iTipo & ") " &
              "            End "
        comando.CommandText = sql
        comando.ExecuteNonQuery()
    End Sub

    ' para calcular los totales del debe y haber de los asientos de venta
    Private Function LlenarTotalesAsiento1() As Boolean

        LlenarTotalesAsiento1 = True

        Dim THaber, TDebe As Double
        Dim n As Integer
        THaber = 0
        TDebe = 0
        For n = 0 To Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Count - 1

            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)

                THaber = THaber + .Haber
                TDebe = TDebe + .Debe
            End With
        Next

        Me.txtTotalDebe.Text = Format(TDebe, "¢###,##0.00")
        Me.txtTotalHaber.Text = Format(THaber, "¢###,##0.00")

        If THaber = 0 Or TDebe = 0 Then
            LlenarTotalesAsiento1 = False
        End If
    End Function


#End Region

#Region "Funciones Validar"


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
                        'Cedula_usuario = rs("Cedula")
                        txtUsuario.Text = rs("Nombre")
                        txtUsuario.Enabled = False
                        txtClave.Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True
                        'dtFechaInicio.Focus()

                        'me.txt= rs("Nombre")
                        'Me.DsPlanilla1.Planilla.FechaColumn.DefaultValue = Now.Date
                        Me.ToolBarNuevo.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Me.txtUsuario.Focus()
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
        'Dim strConexion As String
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

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown

        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable()
        End If

    End Sub

    Private Sub LlamarFmrBuscarAsientoVenta()

        If caso = -1 Then
            MsgBox("Selecione el campo donde quiere ingresar la cuenta")
            Exit Sub
        End If

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " &
                          " where Movimiento=1 " '"select CuentaContable AS [Codigo cuenta],descripcion as Descripcion from Contabilidad.dbo.CuentaContable where  Movimiento = 1  "
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

        cnnConexion.Close()

        txtHaber.Text = Format(0, "###,##0.00")
        txtDebe.Text = Format(0, "###,##0.00")
        txtCodigo.Clear()
        txtDescripcion.Clear()

        If caso = 0 Then
            LlenarTotalesAsiento1()
        End If

        Me.btnModificar.Enabled = False
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        Reporte()
    End Sub

    Private Sub Reporte()
        Try
            Dim reporte As New rptPlanillaAutomaico
            Dim visor As New frmVisorReportes
            Dim fecIni, fecFin As String


            reporte.SetParameterValue("Planillas", nPlanilla, "DetallePlanilla")
            reporte.SetParameterValue("Planillas", nPlanilla, "Deducciones1")
            reporte.SetParameterValue("Planillas", nPlanilla, "opcionesPago")

            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, reporte, False, Configuracion.Claves.Conexion("Planilla"))

            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
End Class
