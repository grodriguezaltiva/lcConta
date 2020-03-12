Imports Utilidades
Imports System.Data.SqlClient
Public Class frmAjusteInventarioGeneracionAutomatica
    Inherits Plantilla

    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String
    Dim IdCuenta1(1) As Integer  ' saber los ids de las cuentas que correspondes a los asientos de venta guardadas en la tabla de Contabilidad.SettingCuentaFacturaVenta
    Dim IdCuenta2(1) As Integer   ' saber los ids de las cuentas que correspondes a los asientos de costo de venta guardadas en la tabla de Contabilidad.SettingCuentaFacturaVenta
    Dim caso As Byte ' para indica si lo que va ha registrar es un asiento de venta o una asiento de costo de venta, 0 = venta, 1 = costo venta
    Dim Accion As String


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
    Friend WithEvents dtsAsientoVenta As Contabilidad.DatasetAsientoVenta
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents btnGenerarCostoVenta As System.Windows.Forms.Button
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarVenta As System.Windows.Forms.Button
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAjusteInventarioGeneracionAutomatica))
        Me.dtsAsientoVenta = New Contabilidad.DatasetAsientoVenta
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
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
        Me.btnGenerarCostoVenta = New System.Windows.Forms.Button
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnGenerarVenta = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.btnModificar = New System.Windows.Forms.Button
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(634, 32)
        Me.TituloModulo.Text = "Ajuste de inventario"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 404)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(634, 52)
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'dtsAsientoVenta
        '
        Me.dtsAsientoVenta.DataSetName = "DatasetAsientoVenta"
        Me.dtsAsientoVenta.Locale = New System.Globalization.CultureInfo("en-US")
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 178
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(88, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 177
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(32, 136)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 19)
        Me.txtCodigo.TabIndex = 5
        Me.txtCodigo.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(32, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 186
        Me.Label3.Text = "Codigo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHaber
        '
        Me.txtHaber.EditValue = ""
        Me.txtHaber.Location = New System.Drawing.Point(472, 136)
        Me.txtHaber.Name = "txtHaber"
        '
        'txtHaber.Properties
        '
        Me.txtHaber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Size = New System.Drawing.Size(132, 19)
        Me.txtHaber.TabIndex = 8
        '
        'txtDebe
        '
        Me.txtDebe.EditValue = ""
        Me.txtDebe.Location = New System.Drawing.Point(336, 136)
        Me.txtDebe.Name = "txtDebe"
        '
        'txtDebe.Properties
        '
        Me.txtDebe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Size = New System.Drawing.Size(131, 19)
        Me.txtDebe.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(184, 136)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(148, 19)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.Text = ""
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(472, 352)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 184
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(320, 352)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 183
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(112, 384)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 180
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(32, 384)
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
        Me.Label6.Location = New System.Drawing.Point(472, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 190
        Me.Label6.Text = "Haber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(336, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Debe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(184, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 14)
        Me.Label4.TabIndex = 188
        Me.Label4.Text = "Descripcion"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarCostoVenta
        '
        Me.btnGenerarCostoVenta.Enabled = False
        Me.btnGenerarCostoVenta.Location = New System.Drawing.Point(368, 80)
        Me.btnGenerarCostoVenta.Name = "btnGenerarCostoVenta"
        Me.btnGenerarCostoVenta.Size = New System.Drawing.Size(184, 23)
        Me.btnGenerarCostoVenta.TabIndex = 4
        Me.btnGenerarCostoVenta.Text = "Generar asiento salida"
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(16, 192)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(600, 152)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 10
        Me.griDetalle.Text = "Asientos de venta"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GroupPanelText = "Detalle del Asiento"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.Label9.Location = New System.Drawing.Point(112, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 181
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(32, 368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Location = New System.Drawing.Point(368, 48)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(184, 23)
        Me.btnGenerarVenta.TabIndex = 3
        Me.btnGenerarVenta.Text = "Generarar asiento entrada"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(248, 80)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 2
        Me.dtpFechaFinal.Value = New Date(2007, 5, 15, 17, 38, 13, 140)
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(248, 48)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 1
        Me.dtpFechaInicio.Value = New Date(2007, 5, 15, 17, 38, 13, 140)
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(280, 160)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 9
        Me.btnModificar.Text = "Agregar"
        '
        'frmAjusteInventarioGeneracionAutomatica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(634, 456)
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
        Me.Controls.Add(Me.btnGenerarCostoVenta)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnGenerarVenta)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Name = "frmAjusteInventarioGeneracionAutomatica"
        Me.Text = "Ajuste de inventario: Generación automática de asiento"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarVenta, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.griDetalle, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarCostoVenta, 0)
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
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones GUI"

    Private Sub frmAsientoVentaGeneracionAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

            Case 2 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Me.Close()
        End Select
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarVenta.Click
        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        caso = 0
        If Buscar() = False Then
            MsgBox("No se encontraron ajustes de inventario de entrada para esta fecha")
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
            Me.btnModificar.Enabled = True
            caso = 0
            Me.txtCodigo.Focus()
        End If
    End Sub

    Private Sub btnGenerarCostoVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCostoVenta.Click
        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        caso = 1
        If Buscar() = False Then
            MsgBox("No se encontraron ajustes de inventario de salida para esta fecha")
            Exit Sub
        End If
        Me.LlenarGriDetalleAsiento2()
        If LlenarTotalesAsiento2() = True Then
            Accion = "AUT"
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFinal.Enabled = False
            Me.ToolBarRegistrar.Enabled = True
            Me.txtDebe.Text = Format(0, "###,##0.00")
            Me.txtHaber.Text = Format(0, "###,##0.00")
            Me.btnModificar.Enabled = True
            caso = 1
            Me.txtCodigo.Focus()

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
                Me.btnGenerarCostoVenta.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                Me.btnModificar.Enabled = False


            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnGenerarVenta.Enabled = False
                Me.btnGenerarCostoVenta.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                Me.btnModificar.Enabled = False

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



        Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()
        Me.griDetalle.Refresh()
        Me.txtTotalHaber.Text = ""
        Me.txtTotalDebe.Text = ""

    End Sub

    Private Function Buscar() As Boolean
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim n As Integer

        Dim sql As String = "SELECT IdInventario FROM contabilidad.dbo.SettingCuentaContable"

        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Exit Function
        ' se buscan los que correspondes al asiento de venta
        IdCuenta1(0) = rstReader("IdInventario")
        IdCuenta2(0) = rstReader("IdInventario")
        rstReader.Close()


        'Busco las cuentas contables que digito el usuario
        If caso = 0 Then


        sql = " SELECT c.id " & _
" FROM SeePOS.dbo.AjusteInventario AI, SeePOS.dbo.AjusteInventario_Detalle DI " & _
",contabilidad.dbo.cuentacontable c " & _
" where AI.Contabilizado = 0 and AI.Anula = 0  " & _
" AND AI.fecha >= " & fecIni & _
" and AI.fecha <= " & fecFin & _
" AND AI.Consecutivo = DI.Cons_Ajuste and entrada = 1 " & _
" and c.cuentacontable = DI.cuentacontable  COLLATE Traditional_Spanish_CI_AS " & _
" GROUP BY c.id "

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 1

        Do While rstReader.Read()
            ReDim Preserve IdCuenta1(n + 1)
            IdCuenta1(n) = rstReader(0)
            n = n + 1
        Loop
        rstReader.Close()
        If n = 1 Then Exit Function
        End If

        If caso = 1 Then

            sql = " SELECT c.id " & _
  " FROM SeePOS.dbo.AjusteInventario AI, SeePOS.dbo.AjusteInventario_Detalle DI " & _
  ",contabilidad.dbo.cuentacontable c " & _
  " where AI.Contabilizado = 0 and AI.Anula = 0  " & _
  " AND AI.fecha >= " & fecIni & _
  " and AI.fecha <= " & fecFin & _
  " AND AI.Consecutivo = DI.Cons_Ajuste and salida = 1 " & _
  " and c.cuentacontable = DI.cuentacontable  COLLATE Traditional_Spanish_CI_AS " & _
  " GROUP BY c.id "

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        n = 1

        Do While rstReader.Read()
            ReDim Preserve IdCuenta2(n + 1)
            IdCuenta2(n) = rstReader(0)
            n = n + 1
        Loop
        rstReader.Close()
        If n = 1 Then Exit Function
        End If

        cnnConexion.Close()
        Buscar = True
    End Function

    Private Sub Registrar()
        If caso = 0 Then
            RegistrarAsiento1()
        Else
            RegistrarAsiento2()
        End If

    End Sub

    Private Sub RegistrarAsiento1()

        '  If ValidarCampos() = False Then Exit Sub


        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As SqlClient.SqlDataReader
        Dim sql As String
        Dim periodo As String
        Dim NumAsiento As Double
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        periodo = Date.Now.Month & "/" & Date.Now.Year

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " INSERT INTO AsientosContables " & _
" (Fecha,NumDoc,Beneficiario,TipoDoc, " & _
" Accion,Anulado,FechaEntrada,Mayorizado, " & _
" Periodo,NumMayorizado,Modulo,Observaciones, " & _
" NombreUsuario,TotalDebe,TotalHaber) " & _
" VALUES('" & dtpFechaFinal.Value.Date & "',9999,'BENE',9999, " & _
" '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
" 'Asiento ajuste de inventario','Asiento automático ajuste de inventario de entrada desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "','" & Me.txtUsuario.Text & "' " & _
" ," & MonedaToDouble(Me.txtTotalDebe.Text) & "," & MonedaToDouble(Me.txtTotalHaber.Text) & ") "

        clsConexion.SlqExecute(cnnConexion, sql)

        sql = "SELECT MAX(NumAsiento) FROM AsientosContables WHERE Fecha = '" & dtpFechaFinal.Value.Date & "' AND Periodo = '" & periodo & "' and NombreUsuario = '" & txtUsuario.Text & "'"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        rstReader.Read()

        NumAsiento = rstReader(0)

        rstReader.Close()

        cnnConexion.Close()

        RegistrarDetalleAsiento1(NumAsiento)

        cnnConexion.Open()
        sql = " UPDATE SeePOS.dbo.AjusteInventario SET Contabilizado = 1 ,asiento  = " & NumAsiento & "  WHERE Contabilizado = 0 and anula = 0 AND " & _
                " fecha >= " & fecIni & " and fecha <= " & fecFin

        clsConexion.SlqExecute(cnnConexion, sql)

        cnnConexion.Close()

        MsgBox("Los datos han sido registrados correctamente", MsgBoxStyle.Information)

        NUEVO()


    End Sub

    Private Sub RegistrarDetalleAsiento1(ByVal pNumAsiento As Double)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim sql As String
        Dim n As Integer

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")

        n = 0
        With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
            cnnConexion.Open()
            sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
            " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & FormatoDouble(.Debe) & ",1,0,'Asiento automático ajuste de inventario entrada desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()
        End With


        Dim m As Integer
        If Accion = "MAN" Then
            m = 1
        End If

        For n = 1 To dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Count - 1 - m
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                cnnConexion.Open()
                sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
                " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & FormatoDouble(.Haber) & ",0,1,'Asiento automático ajuste de inventario entrada desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
                clsConexion.SlqExecute(cnnConexion, sql)
                cnnConexion.Close()
            End With
        Next


        If Accion = "MAN" Then
            Dim debe, haber As Byte
            Dim monto As String
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                If .Debe = 0 Then
                    haber = 1
                    debe = 0
                    monto = FormatoDouble(.Haber)
                Else
                    debe = 1
                    haber = 0
                    monto = FormatoDouble(.Debe)
                End If

                cnnConexion.Open()
                sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
                " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático ajuste de inventario entrada desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
                clsConexion.SlqExecute(cnnConexion, sql)
                cnnConexion.Close()
            End With
        End If


    End Sub

    Private Sub RegistrarAsiento2()

        ' If ValidarCampos() = False Then Exit Sub

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As SqlClient.SqlDataReader
        Dim sql As String
        Dim periodo As String
        Dim NumAsiento As Double
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"


        periodo = Date.Now.Month & "/" & Date.Now.Year

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " INSERT INTO AsientosContables " & _
" (Fecha,NumDoc,Beneficiario,TipoDoc, " & _
" Accion,Anulado,FechaEntrada,Mayorizado, " & _
" Periodo,NumMayorizado,Modulo,Observaciones, " & _
" NombreUsuario,TotalDebe,TotalHaber) " & _
" VALUES('" & dtpFechaFinal.Value.Date & "',9999,'BENE',9999, " & _
" '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
" 'Asiento de ajuste de inventario','Asiento automático ajuste de inventario salida desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "','" & Me.txtUsuario.Text & "' " & _
" ," & MonedaToDouble(Me.txtTotalDebe.Text) & "," & MonedaToDouble(Me.txtTotalHaber.Text) & ") "

        clsConexion.SlqExecute(cnnConexion, sql)

        sql = "SELECT MAX(NumAsiento) FROM AsientosContables WHERE Fecha = '" & dtpFechaFinal.Value.Date & "' AND Periodo = '" & periodo & "' and NombreUsuario = '" & txtUsuario.Text & "'"
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        rstReader.Read()

        NumAsiento = rstReader(0)

        rstReader.Close()

        cnnConexion.Close()

        RegistrarDetalleAsiento2(NumAsiento)

        cnnConexion.Open()
        sql = " UPDATE SeePOS.dbo.AjusteInventario SET Contabilizado = 1 ,asiento  = " & NumAsiento & "  WHERE Contabilizado = 0 and anula = 0 AND " & _
            " fecha >= " & fecIni & " and fecha <= " & fecFin

        clsConexion.SlqExecute(cnnConexion, sql)

        cnnConexion.Close()

        MsgBox("Los datos han sido registrados correctamente", MsgBoxStyle.Information)
        NUEVO()

    End Sub

    Private Sub RegistrarDetalleAsiento2(ByVal pNumAsiento As Double)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim sql As String
        Dim n As Integer

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        n = 0
        With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
            cnnConexion.Open()
            sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
            " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & FormatoDouble(.Haber) & ",0,1,'Asiento automático ajuste de inventario salida desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()
        End With

        Dim m As Integer
        If Accion = "MAN" Then
            m = 1
        End If

        For n = 1 To dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Count - 1 - m
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                cnnConexion.Open()
                sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
                " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & FormatoDouble(.Debe) & ",1,0,'Asiento automático ajuste de inventario salida desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
                clsConexion.SlqExecute(cnnConexion, sql)
                cnnConexion.Close()
            End With
        Next


        If Accion = "MAN" Then
            Dim debe, haber As Byte
            Dim monto As String
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                If .Debe = 0 Then
                    haber = 1
                    debe = 0
                    monto = FormatoDouble(.Haber)
                Else
                    debe = 1
                    haber = 0
                    monto = FormatoDouble(.Debe)
                End If

                cnnConexion.Open()
                sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
                " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático ajuste de inventario salida desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
                clsConexion.SlqExecute(cnnConexion, sql)
                cnnConexion.Close()
            End With
        End If


    End Sub

#End Region

#Region "Funciones Iniciacion"

    Private Sub Cargar()
        Limpiar()
        ActivarGui()

    End Sub

    Private Sub ActivarGui()
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
        Me.btnGenerarVenta.Enabled = False
        Me.btnGenerarCostoVenta.Enabled = False
        Me.btnModificar.Enabled = False
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
        Dim n As Integer
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        If ValidarIdCuenta1() = False Then
            MsgBox("No se puede generar asientos de ventas automáticamente si no se a configurado los asientos en Setting cuenta factura venta")
            Exit Sub
        End If

        sql = " ( " & _
" select 1 AS ID, C.CuentaContable AS Codigo,C.Descripcion, " & _
" (  " & _
" SELECT  isnull(SUM(DI.TotalEntrada*M.ValorCompra),0) " & _
" FROM SeePOS.dbo.AjusteInventario AI, SeePOS.dbo.AjusteInventario_Detalle DI " & _
" ,SEEPOS.DBO.Inventario I,seepos.dbo.Moneda M " & _
" where AI.Contabilizado = 0 and AI.Anula = 0  " & _
"  AND AI.fecha >= " & fecIni & _
"  and AI.fecha <= " & fecFin & _
" AND AI.Consecutivo = DI.Cons_Ajuste " & _
" AND DI.Entrada = 1 and  I.cODIGO = DI.Cod_Articulo and M.CodMoneda = I.MonedaCosto " & _
" )  " & _
" as debe, 0 as haber " & _
" from  Contabilidad.dbo.CuentaContable C  " & _
" where  C.ID =  " & IdCuenta1(0) & _
" GROUP BY C.CuentaContable,C.Descripcion " & _
" ) "
        For n = 1 To IdCuenta1.Length - 2
            sql = sql & " UNION " & _
            " ( " & _
            " select " & (n + 1) & " AS ID, C.CuentaContable AS Codigo,C.Descripcion,0 AS DEBE, " & _
            " (  " & _
            " SELECT  isnull(SUM(DI.TotalEntrada*M.ValorCompra),0) " & _
            " FROM SeePOS.dbo.AjusteInventario AI, SeePOS.dbo.AjusteInventario_Detalle DI " & _
            " ,SEEPOS.DBO.Inventario I,seepos.dbo.Moneda M " & _
            " where AI.Contabilizado = 0 and AI.Anula = 0  " & _
            "  AND AI.fecha >= " & fecIni & _
            "  and AI.fecha <= " & fecFin & _
            " AND AI.Consecutivo = DI.Cons_Ajuste " & _
            " AND DI.Entrada = 1  " & _
            " and  I.cODIGO = DI.Cod_Articulo and M.CodMoneda = I.MonedaCosto " & _
            " and c.cuentacontable = di.cuentacontable  COLLATE Traditional_Spanish_CI_AS " & _
            "  )  " & _
            " as haber " & _
            " from  Contabilidad.dbo.CuentaContable C  " & _
            " where  C.ID = " & IdCuenta1(n) & _
            " GROUP BY C.CuentaContable,C.Descripcion " & _
            " ) "

        Next
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

    'para llenar el gird con los asientos del costo de venta
    Private Sub LlenarGriDetalleAsiento2()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String
        Dim n As Integer
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        If ValidarIdCuenta2() = False Then
            MsgBox("No se puede generar asientos de ventas automáticamente si no se a configurado los asientos en Setting cuenta factura venta")
            Exit Sub
        End If

        sql = " ( " & _
" select 1 AS ID, C.CuentaContable AS Codigo,C.Descripcion,0 as debe, " & _
" (  " & _
" SELECT  isnull(SUM(DI.Totalsalida*M.ValorCompra),0) " & _
" FROM SeePOS.dbo.AjusteInventario AI, SeePOS.dbo.AjusteInventario_Detalle DI " & _
" ,SEEPOS.DBO.Inventario I,seepos.dbo.Moneda M " & _
" where AI.Contabilizado = 0 and AI.Anula = 0  " & _
"  AND AI.fecha >= " & fecIni & _
"  and AI.fecha <= " & fecFin & _
" AND AI.Consecutivo = DI.Cons_Ajuste " & _
" AND DI.salida = 1 and  I.cODIGO = DI.Cod_Articulo and M.CodMoneda = I.MonedaCosto " & _
" )  " & _
" as haber " & _
" from  Contabilidad.dbo.CuentaContable C  " & _
" where  C.ID =  " & IdCuenta2(0) & _
" GROUP BY C.CuentaContable,C.Descripcion " & _
" ) "
        For n = 1 To IdCuenta2.Length - 2
            sql = sql & " UNION " & _
            " ( " & _
            " select " & (n + 1) & " AS ID, C.CuentaContable AS Codigo,C.Descripcion, " & _
            " (  " & _
            " SELECT  isnull(SUM(DI.Totalsalida*M.ValorCompra),0) " & _
            " FROM SeePOS.dbo.AjusteInventario AI, SeePOS.dbo.AjusteInventario_Detalle DI " & _
            " ,SEEPOS.DBO.Inventario I,seepos.dbo.Moneda M " & _
            " where AI.Contabilizado = 0 and AI.Anula = 0  " & _
            "  AND AI.fecha >= " & fecIni & _
            "  and AI.fecha <= " & fecFin & _
            " AND AI.Consecutivo = DI.Cons_Ajuste " & _
            " AND DI.salida = 1  " & _
            " and  I.cODIGO = DI.Cod_Articulo and M.CodMoneda = I.MonedaCosto " & _
            " and c.cuentacontable = di.cuentacontable  COLLATE Traditional_Spanish_CI_AS " & _
            "  )  " & _
            " as debe, 0 as haber " & _
            " from  Contabilidad.dbo.CuentaContable C  " & _
            " where  C.ID = " & IdCuenta2(n) & _
            " GROUP BY C.CuentaContable,C.Descripcion " & _
            " ) "

        Next
        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.Clear()

        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsAsientoVenta, "GeneracionAutomaticaAsientoVenta")

    End Sub

    Private Function LlenarTotalesAsiento2() As Boolean

        LlenarTotalesAsiento2 = True

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
            LlenarTotalesAsiento2 = False
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
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
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

        If caso = 0 Then
            LlenarTotalesAsiento1()
        End If

        If caso = 1 Then
            LlenarTotalesAsiento2()
        End If

        Me.btnModificar.Enabled = False
    End Sub

End Class
