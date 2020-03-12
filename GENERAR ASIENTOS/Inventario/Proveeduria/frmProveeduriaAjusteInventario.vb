Imports Utilidades
Imports System.Data.SqlClient

Public Class frmProveeduriaAjusteInventario
    Inherits Plantilla

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
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHaber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDebe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtsAsientoVenta As Contabilidad.DatasetAsientoVenta
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAsiento1 As System.Windows.Forms.Button
    Friend WithEvents btnAsiento2 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProveeduriaAjusteInventario))
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtHaber = New DevExpress.XtraEditors.TextEdit
        Me.txtDebe = New DevExpress.XtraEditors.TextEdit
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.txtTotalHaber = New System.Windows.Forms.TextBox
        Me.txtTotalDebe = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnModificar = New System.Windows.Forms.Button
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.dtsAsientoVenta = New Contabilidad.DatasetAsientoVenta
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.btnAsiento1 = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnAsiento2 = New System.Windows.Forms.Button
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 378)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(632, 52)
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(632, 32)
        Me.TituloModulo.Text = "Ajuste de inventario"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(24, 344)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.TabIndex = 254
        Me.btnDetalle.Text = "Detalle"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 246
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 245
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(32, 128)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 19)
        Me.txtCodigo.TabIndex = 240
        Me.txtCodigo.Text = ""
        Me.txtCodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'txtHaber
        '
        Me.txtHaber.EditValue = ""
        Me.txtHaber.Location = New System.Drawing.Point(472, 128)
        Me.txtHaber.Name = "txtHaber"
        '
        'txtHaber.Properties
        '
        Me.txtHaber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Size = New System.Drawing.Size(132, 19)
        Me.txtHaber.TabIndex = 243
        Me.txtHaber.Visible = False
        '
        'txtDebe
        '
        Me.txtDebe.EditValue = ""
        Me.txtDebe.Location = New System.Drawing.Point(336, 128)
        Me.txtDebe.Name = "txtDebe"
        '
        'txtDebe.Properties
        '
        Me.txtDebe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Size = New System.Drawing.Size(131, 19)
        Me.txtDebe.TabIndex = 242
        Me.txtDebe.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(184, 128)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(148, 19)
        Me.txtDescripcion.TabIndex = 241
        Me.txtDescripcion.Text = ""
        Me.txtDescripcion.Visible = False
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(472, 344)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 249
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(320, 344)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 248
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(472, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 253
        Me.Label6.Text = "Haber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(336, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 252
        Me.Label5.Text = "Debe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(184, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 14)
        Me.Label4.TabIndex = 251
        Me.Label4.Text = "Descripción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(280, 152)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 244
        Me.btnModificar.Text = "Agregar"
        Me.btnModificar.Visible = False
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(16, 104)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(600, 232)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 247
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
        'btnAsiento1
        '
        Me.btnAsiento1.Location = New System.Drawing.Point(368, 40)
        Me.btnAsiento1.Name = "btnAsiento1"
        Me.btnAsiento1.Size = New System.Drawing.Size(176, 23)
        Me.btnAsiento1.TabIndex = 3
        Me.btnAsiento1.Text = "Asiento de entrada"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(248, 72)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(248, 40)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(424, 400)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 257
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(344, 400)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(424, 384)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 258
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(344, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 256
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAsiento2
        '
        Me.btnAsiento2.Location = New System.Drawing.Point(368, 72)
        Me.btnAsiento2.Name = "btnAsiento2"
        Me.btnAsiento2.Size = New System.Drawing.Size(176, 23)
        Me.btnAsiento2.TabIndex = 4
        Me.btnAsiento2.Text = "Asiento de salida"
        '
        'frmProveeduriaAjusteInventario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(632, 430)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.btnAsiento2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
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
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAsiento1)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Name = "frmProveeduriaAjusteInventario"
        Me.Text = "Ajuste de inventario: Generación automática de asiento"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.btnAsiento1, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
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
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.btnAsiento2, 0)
        Me.Controls.SetChildIndex(Me.griDetalle, 0)
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"
    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String
    Dim IdCuenta1a() As String
    Dim IdCuenta1b() As String
    Dim IdCuenta2a() As String
    Dim IdCuenta2b() As String
    Dim caso As Byte ' para indica si lo que va ha registrar es un asiento de venta o una asiento de costo de venta, 0 = venta, 1 = costo venta
    Dim Accion As String
    Dim Fx As New cFunciones
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

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsiento1.Click
        Generar()
    End Sub

    Private Sub btnAsiento1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnAsiento1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Generar()
        End If
    End Sub

    Private Sub btnGenerarCostoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsiento2.Click
        GenerarSalida()
    End Sub

    Private Sub btnAsiento2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnAsiento2.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenerarSalida()
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

    Private Sub dtpFechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtpFechaFinal.Focus()
        End If
    End Sub

    Private Sub dtpFechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAsiento1.Focus()
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
        cnnConexion.Close()

        txtHaber.Text = Format(0, "###,##0.00")
        txtDebe.Text = Format(0, "###,##0.00")
        txtCodigo.Clear()
        txtDescripcion.Clear()

        LlenarTotalesAsiento()
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
                Me.btnAsiento1.Enabled = True
                Me.btnAsiento2.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                Me.btnModificar.Enabled = False
                Me.btnDetalle.Enabled = False
                dtpFechaInicio.Focus()
            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnAsiento1.Enabled = False
                Me.btnAsiento2.Enabled = False
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

        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Fx.ValidarPeriodo(dtpFechaFinal.Value) = False Then
            MsgBox("La fecha del asiento NO corresponde al periodo de trabajo! O el periodo esta cerrado!" & vbCrLf & "No se puede Generar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
            Exit Sub
        End If

        If BuscarCaso0() = False Then
            MsgBox("No se encontraron ajustes de entrada para esta fecha", MsgBoxStyle.Information)
            Exit Sub
        End If

        Me.LlenarGriDetalleAsiento1()
        If LlenarTotalesAsiento() = True Then
            Accion = "AUT"
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFinal.Enabled = False
            Me.ToolBarRegistrar.Enabled = True
            Me.txtDebe.Text = Format(0, "###,##0.00")
            Me.txtHaber.Text = Format(0, "###,##0.00")
            Me.btnModificar.Enabled = True
            Me.btnDetalle.Enabled = True
            caso = 0
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub GenerarSalida()
        Dim Fx As New cFunciones

        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If

        If Fx.ValidarPeriodo(dtpFechaFinal.Value) = False Then
            MsgBox("La fecha del asiento NO corresponde al periodo de trabajo! O el periodo esta cerrado!" & vbCrLf & "No se puede Generar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
            Exit Sub
        End If

        If BuscarCaso1() = False Then
            MsgBox("No se encontraron ajustes de salida para esta fecha", MsgBoxStyle.Information)
            Exit Sub
        End If

        Me.LlenarGriDetalleAsiento2()
        If LlenarTotalesAsiento() = True Then
            Accion = "AUT"
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFinal.Enabled = False
            Me.ToolBarRegistrar.Enabled = True
            Me.txtDebe.Text = Format(0, "###,##0.00")
            Me.txtHaber.Text = Format(0, "###,##0.00")
            Me.btnModificar.Enabled = True
            Me.btnDetalle.Enabled = True
            caso = 1
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Function BuscarCaso0() As Boolean
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer

        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        sql = " select distinct IdBodega from AjusteInventario A ,AjusteInventario_Detalle AD where " & _
            " A.Consecutivo = AD.Cons_Ajuste  " & _
            " AND A.Fecha >=  " & fecIni & _
            " AND A.Fecha <= " & fecFin & _
            " AND A.Anula = 0 AND ContaEntrada = 0 " & _
            " AND entrada = 1 "

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 1
        Do While rstReader.Read()
            ReDim Preserve IdCuenta1a(n)
            IdCuenta1a(n - 1) = rstReader(0)
            n = n + 1
        Loop

        rstReader.Close()

        If n = 1 Then
            cnnConexion.Close()
            Exit Function
        End If

        sql = " select distinct AD.Cuenta_Contable from AjusteInventario A ,AjusteInventario_Detalle AD where " & _
        " A.Consecutivo = AD.Cons_Ajuste  " & _
        " AND A.Fecha >=  " & fecIni & _
        " AND A.Fecha <= " & fecFin & _
        " AND A.Anula = 0 AND ContaEntrada = 0 " & _
        " AND entrada = 1 "

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 1
        Do While rstReader.Read()
            ReDim Preserve IdCuenta1b(n)
            IdCuenta1b(n - 1) = rstReader(0)
            n = n + 1
        Loop

        rstReader.Close()

        If n = 1 Then
            cnnConexion.Close()
            Exit Function
        End If

        cnnConexion.Close()
        BuscarCaso0 = True
    End Function

    Private Function BuscarCaso1() As Boolean
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer

        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        sql = " select distinct IdBodega from AjusteInventario A ,AjusteInventario_Detalle AD where " & _
            " A.Consecutivo = AD.Cons_Ajuste  " & _
            " AND A.Fecha >=  " & fecIni & _
            " AND A.Fecha <= " & fecFin & _
            " AND A.Anula = 0 AND ContaSalida = 0 " & _
            " AND salida = 1 "

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 1
        Do While rstReader.Read()
            ReDim Preserve IdCuenta2a(n)
            IdCuenta2a(n - 1) = rstReader(0)
            n = n + 1
        Loop

        rstReader.Close()

        If n = 1 Then
            cnnConexion.Close()
            Exit Function
        End If

        sql = " select distinct AD.Cuenta_Contable from AjusteInventario A ,AjusteInventario_Detalle AD where " & _
        " A.Consecutivo = AD.Cons_Ajuste  " & _
        " AND A.Fecha >=  " & fecIni & _
        " AND A.Fecha <= " & fecFin & _
        " AND A.Anula = 0 AND ContaSalida = 0 " & _
        " AND salida = 1 "

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 1
        Do While rstReader.Read()
            ReDim Preserve IdCuenta2b(n)
            IdCuenta2b(n - 1) = rstReader(0)
            n = n + 1
        Loop

        rstReader.Close()

        If n = 1 Then
            cnnConexion.Close()
            Exit Function
        End If
        cnnConexion.Close()
        BuscarCaso1 = True
    End Function

    Private Sub Registrar()
        If caso = 0 Then
            RegistrarAsiento1()
        Else
            RegistrarAsiento2()
        End If
    End Sub

    Private Sub RegistrarAsiento1()
        If ValidarCampos() = False Then Exit Sub

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As SqlClient.SqlDataReader
        Dim sql As String
        Dim periodo As String
        Dim NumAsiento As String
        Dim fecIni, fecFin As String
        If MsgBox("Desea Guardar asiento de Ajuste de Inventario", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"
        periodo = Fx.BuscaPeriodo(dtpFechaFinal.Value)
        NumAsiento = Fx.BuscaNumeroAsiento("INV-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " INSERT INTO AsientosContables " & _
" (NumAsiento,Fecha,NumDoc,Beneficiario,TipoDoc, " & _
" Accion,Anulado,FechaEntrada,Mayorizado, " & _
" Periodo,NumMayorizado,Modulo,Observaciones, " & _
" NombreUsuario,TotalDebe,TotalHaber,TipoCambio) " & _
" VALUES('" & NumAsiento & "','" & dtpFechaFinal.Value.Date & "',9999,'BENE',11, " & _
" '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
" 'Ajuste Inventario de proveeduría','Asiento automático Ajuste Entrada de Inventario de proveeduría desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "','" & Me.txtUsuario.Text & "' " & _
" ," & MonedaToDouble(Me.txtTotalDebe.Text) & "," & MonedaToDouble(Me.txtTotalHaber.Text) & "," & Fx.TipoCambio(dtpFechaFinal.Value) & ") "

        clsConexion.SlqExecute(cnnConexion, sql)
        cnnConexion.Close()

        RegistrarDetalleAsiento1(NumAsiento)

        cnnConexion.Open()
        sql = " UPDATE Proveeduria.dbo.AjusteInventario SET ContaEntrada = 1 ,AsientoEntrada  = '" & NumAsiento & "'  WHERE ContaEntrada = 0 AND " & _
                " fecha >= " & fecIni & " and fecha <= " & fecFin
        clsConexion.SlqExecute(cnnConexion, sql)
        cnnConexion.Close()

        MsgBox("Los datos han sido registrados correctamente", MsgBoxStyle.Information)
        NUEVO()
    End Sub

    Private Sub RegistrarDetalleAsiento1(ByVal pNumAsiento As String)
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
                    sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento,tipoCambio) " & _
                    " VALUES('" & pNumAsiento & "','" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático Ajustes de Entrada desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "'," & Fx.TipoCambio(dtpFechaFinal.Value) & ") "
                    clsConexion.SlqExecute(cnnConexion, sql)
                    cnnConexion.Close()
                End If
            End With
        Next
    End Sub

    Private Sub RegistrarAsiento2()
        If ValidarCampos() = False Then Exit Sub

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As SqlClient.SqlDataReader
        Dim sql As String
        Dim periodo As String
        Dim NumAsiento As String
        Dim fecIni, fecFin As String
        Dim Fx As New cFunciones
        If MsgBox("Desea Guardar asiento de Ajuste de Inventario", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"
        periodo = Fx.BuscaPeriodo(dtpFechaFinal.Value)
        NumAsiento = Fx.BuscaNumeroAsiento("INV-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " INSERT INTO AsientosContables " & _
" (NumAsiento,Fecha,NumDoc,Beneficiario,TipoDoc, " & _
" Accion,Anulado,FechaEntrada,Mayorizado, " & _
" Periodo,NumMayorizado,Modulo,Observaciones, " & _
" NombreUsuario,TotalDebe,TotalHaber,TipoCambio) " & _
" VALUES('" & NumAsiento & "','" & dtpFechaFinal.Value.Date & "',9999,'BENE',12, " & _
" '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
" 'Ajuste Inventario de proveeduría','Asiento automático Ajuste Salida de Inventario de proveeduría desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "','" & Me.txtUsuario.Text & "' " & _
" ," & MonedaToDouble(Me.txtTotalDebe.Text) & "," & MonedaToDouble(Me.txtTotalHaber.Text) & "," & Fx.TipoCambio(dtpFechaFinal.Value) & ") "

        clsConexion.SlqExecute(cnnConexion, sql)
        cnnConexion.Close()

        RegistrarDetalleAsiento2(NumAsiento)

        cnnConexion.Open()
        sql = " UPDATE Proveeduria.dbo.AjusteInventario SET ContaSalida = 1 ,AsientoSalida  = '" & NumAsiento & "'  WHERE ContaSalida = 0 AND " & _
                " fecha >= " & fecIni & " and fecha <= " & fecFin

        clsConexion.SlqExecute(cnnConexion, sql)
        cnnConexion.Close()

        MsgBox("Los datos han sido registrados correctamente", MsgBoxStyle.Information)
        NUEVO()
    End Sub

    Private Sub RegistrarDetalleAsiento2(ByVal pNumAsiento As String)
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
                    sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento,tipocambio) " & _
                    " VALUES('" & pNumAsiento & "','" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático Ajustes de Salida desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "'," & Fx.TipoCambio(dtpFechaFinal.Value) & ") "
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
        Me.btnAsiento1.Enabled = False
        Me.btnAsiento2.Enabled = False
        Me.btnModificar.Enabled = False
        Me.btnDetalle.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
    End Sub

    Private Sub Limpiar()
        Accion = "AUT"
        Dim n As Integer
        ' se inicializa el venctor donde se guardan las cuentas que estan guardadas en Contabilidad.SettingCuentaFacturaVenta
        For n = 0 To IdCuenta1a.Length - 1
            IdCuenta1a(n) = -1
        Next

        For n = 0 To IdCuenta2a.Length - 1
            IdCuenta2a(n) = -1
        Next

        For n = 0 To IdCuenta1b.Length - 1
            IdCuenta1b(n) = -1
        Next

        For n = 0 To IdCuenta2b.Length - 1
            IdCuenta2b(n) = -1
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
        For n = 0 To Me.IdCuenta1a.Length - 2
            If n <> 0 Then sql = sql & " UNION "
            sql = sql & " ( " & _
" SELECT " & (n + 1) & " AS Id,C.CuentaContable as Codigo,C.Descripcion, " & _
" ( " & _
" select isnull(SUM(AD.CostoUnit*ad.cantidad*Tipo_Cambio),0) from AjusteInventario A ,AjusteInventario_Detalle AD where  " & _
" A.Consecutivo = AD.Cons_Ajuste  " & _
" AND A.Fecha >=  " & fecIni & _
" AND A.Fecha <= " & fecFin & _
" AND A.Anula = 0 AND ContaEntrada = 0 " & _
" AND entrada = 1 and AD.IdBodega = B.IdBodega " & _
" ) as Debe, 0 as Haber  " & _
" from  Contabilidad.dbo.CuentaContable C ,Bodega B " & _
" WHERE C.CuentaContable = B.CuentaContable  " & _
" AND B.IdBodega = " & IdCuenta1a(n) & _
" GROUP BY C.CuentaContable,C.Descripcion,B.IdBodega " & _
" ) "
        Next

        m = n

        For n = 0 To Me.IdCuenta1b.Length - 2
            sql = sql & " UNION " & _
            " ( " & _
            " SELECT " & (n + 1 + m) & " AS Id,C.CuentaContable as Codigo,C.Descripcion,0 AS Debe, " & _
            " ( " & _
            " select isnull(SUM(AD.CostoUnit*ad.cantidad*Tipo_Cambio),0) from AjusteInventario A ,AjusteInventario_Detalle AD where  " & _
            " A.Consecutivo = AD.Cons_Ajuste  " & _
            " AND A.Fecha >= " & fecIni & _
            " AND A.Fecha <= " & fecFin & _
            " AND A.Anula = 0 AND ContaEntrada = 0 " & _
            " AND entrada = 1 and AD.Cuenta_Contable COLLATE Traditional_Spanish_CI_AS = C.CuentaContable " & _
            " ) as Haber  " & _
            " from  Contabilidad.dbo.CuentaContable C  " & _
            " WHERE C.CuentaContable = '" & IdCuenta1b(n) & "'  " & _
            " GROUP BY C.CuentaContable,C.Descripcion " & _
            " ) "
        Next


        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta")
    End Sub

    ' para calcular los totales del debe y haber de los asientos de venta
    Private Function LlenarTotalesAsiento() As Boolean
        LlenarTotalesAsiento = True

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
            LlenarTotalesAsiento = False
        End If
    End Function

    'para llenar el gird con los asientos del costo de venta
    Private Sub LlenarGriDetalleAsiento2()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String
        Dim n, m As Integer
        Dim fecIni, fecFin As String

        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        sql = ""
        For n = 0 To Me.IdCuenta2a.Length - 2
            If n <> 0 Then sql = sql & " UNION "
            sql = sql & " ( " & _
" SELECT " & (n + 1) & " AS Id,C.CuentaContable as Codigo,C.Descripcion, " & _
" ( " & _
" select isnull(SUM(AD.CostoUnit*ad.cantidad*Tipo_Cambio),0) from AjusteInventario A ,AjusteInventario_Detalle AD where  " & _
" A.Consecutivo = AD.Cons_Ajuste  " & _
" AND A.Fecha >=  " & fecIni & _
" AND A.Fecha <= " & fecFin & _
" AND A.Anula = 0 AND ContaSalida = 0 " & _
" AND salida = 1 and AD.IdBodega = B.IdBodega " & _
" ) as Debe, 0 as Haber  " & _
" from  Contabilidad.dbo.CuentaContable C ,Bodega B " & _
" WHERE C.CuentaContable = B.CuentaContable  " & _
" AND B.IdBodega = " & IdCuenta2a(n) & _
" GROUP BY C.CuentaContable,C.Descripcion,B.IdBodega " & _
" ) "
        Next

        m = n

        For n = 0 To Me.IdCuenta2b.Length - 2
            sql = sql & " UNION " & _
            " ( " & _
            " SELECT " & (n + 1 + m) & " AS Id,C.CuentaContable as Codigo,C.Descripcion,0 AS Debe, " & _
            " ( " & _
            " select isnull(SUM(AD.CostoUnit*ad.cantidad*Tipo_Cambio),0) from AjusteInventario A ,AjusteInventario_Detalle AD where  " & _
            " A.Consecutivo = AD.Cons_Ajuste  " & _
            " AND A.Fecha >= " & fecIni & _
            " AND A.Fecha <= " & fecFin & _
            " AND A.Anula = 0 AND ContaSalida = 0 " & _
            " AND salida = 1 and AD.Cuenta_Contable COLLATE Traditional_Spanish_CI_AS = C.CuentaContable " & _
            " ) as Haber  " & _
            " from  Contabilidad.dbo.CuentaContable C  " & _
            " WHERE C.CuentaContable = '" & IdCuenta2b(n) & "'  " & _
            " GROUP BY C.CuentaContable,C.Descripcion " & _
            " ) "
        Next

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta")
    End Sub
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
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
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
            Dim ReporteAjuste As New rptProveeduriaAjusteInventarioDetalle
            Dim visor As New frmVisorReportes
            Dim fecIni, fecFin As String
            fecIni = "  DateTime(" & dtpFechaInicio.Value.Year & "," & dtpFechaInicio.Value.Month & "," & dtpFechaInicio.Value.Day & " ,00,00,00)"
            fecFin = "  DateTime( " & dtpFechaFinal.Value.Year & "," & dtpFechaFinal.Value.Month & "," & dtpFechaFinal.Value.Day & ", 23,59,59)"

            If caso = 0 Then
                ReporteAjuste.SetParameterValue(0, True)
                ReporteAjuste.RecordSelectionFormula = " {AjusteInventario.Fecha} in " & fecIni & " to " & fecFin & " and not {AjusteInventario.Anula} and not {AjusteInventario.ContaEntrada} AND {AjusteInventario_Detalle.Entrada}  "
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, ReporteAjuste, False,Configuracion.Claves.Conexion("Proveeduria"))
            End If

            If caso = 1 Then
                ReporteAjuste.SetParameterValue(0, False)
                ReporteAjuste.RecordSelectionFormula = " {AjusteInventario.Fecha} in " & fecIni & " to " & fecFin & " and not {AjusteInventario.Anula} and not {AjusteInventario.ContaSalida} AND {AjusteInventario_Detalle.Salida} "
                CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, ReporteAjuste, False,Configuracion.Claves.Conexion("Proveeduria"))
            End If
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
#End Region

End Class
