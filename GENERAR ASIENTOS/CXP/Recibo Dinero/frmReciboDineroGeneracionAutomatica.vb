Imports Utilidades
Imports System.Data.SqlClient


Public Class frmReciboDineroGeneracionAutomatica
    'Inherits System.Windows.Forms.Form
    Inherits Plantilla

    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String
    Dim IdCuenta1(4) As Integer  ' saber los ids de las cuentas que correspondes a los asientos de venta guardadas en la tabla de Contabilidad.SettingCuentaFacturaVenta
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
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    'Protected WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtsAsientoVenta As Contabilidad.DatasetAsientoVenta
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    'System.Windows.Forms.TextBox
    Friend WithEvents txtDebe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtHaber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnGenerarAsiento1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReciboDineroGeneracionAutomatica))
        Me.txtTotalHaber = New System.Windows.Forms.TextBox
        Me.txtTotalDebe = New System.Windows.Forms.TextBox
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.dtsAsientoVenta = New Contabilidad.DatasetAsientoVenta
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerarAsiento1 = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtHaber = New DevExpress.XtraEditors.TextEdit
        Me.txtDebe = New DevExpress.XtraEditors.TextEdit
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
      
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 407)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(624, 59)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(624, 32)
        Me.TituloModulo.Text = "Recibo de dinero"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(464, 339)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 121
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(313, 339)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 120
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'griDetalle
        '
        Me.griDetalle.DataMember = Nothing
        Me.griDetalle.DataSource = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(10, 181)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(600, 146)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 9
        '
        'dtsAsientoVenta
        '
        Me.dtsAsientoVenta.DataSetName = "DatasetAsientoVenta"
        Me.dtsAsientoVenta.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
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
        Me.Label9.Location = New System.Drawing.Point(105, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(105, 386)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 117
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(25, 386)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(25, 370)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(241, 82)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(241, 50)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(81, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(81, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarAsiento1
        '
        Me.btnGenerarAsiento1.Location = New System.Drawing.Point(370, 51)
        Me.btnGenerarAsiento1.Name = "btnGenerarAsiento1"
        Me.btnGenerarAsiento1.Size = New System.Drawing.Size(107, 23)
        Me.btnGenerarAsiento1.TabIndex = 3
        Me.btnGenerarAsiento1.Text = "Generar"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(270, 153)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Agregar"
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(26, 128)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 19)
        Me.txtCodigo.TabIndex = 4
        Me.txtCodigo.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(179, 127)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(148, 19)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(179, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 14)
        Me.Label4.TabIndex = 128
        Me.Label4.Text = "Descripción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(332, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 130
        Me.Label5.Text = "Debe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(467, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "Haber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtHaber
        '
        Me.txtHaber.EditValue = ""
        Me.txtHaber.Location = New System.Drawing.Point(467, 127)
        Me.txtHaber.Name = "txtHaber"
        '
        'txtHaber.Properties
        '
        Me.txtHaber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Size = New System.Drawing.Size(132, 19)
        Me.txtHaber.TabIndex = 7
        '
        'txtDebe
        '
        Me.txtDebe.EditValue = ""
        Me.txtDebe.Location = New System.Drawing.Point(332, 127)
        Me.txtDebe.Name = "txtDebe"
        '
        'txtDebe.Properties
        '
        Me.txtDebe.Properties.DisplayFormat.FormatString = "#,#0.00"
        Me.txtDebe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Properties.EditFormat.FormatString = "#,#0.00"
        Me.txtDebe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Size = New System.Drawing.Size(132, 19)
        Me.txtDebe.TabIndex = 6
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmReciboDineroGeneracionAutomatica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(624, 466)
        Me.Controls.Add(Me.txtHaber)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDebe)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnGenerarAsiento1)
        Me.Controls.Add(Me.txtTotalHaber)
        Me.Controls.Add(Me.txtTotalDebe)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmReciboDineroGeneracionAutomatica"
        Me.Text = "Recibo de dinero: Generación automática de asiento"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.griDetalle, 0)
        Me.Controls.SetChildIndex(Me.txtClave, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.txtTotalDebe, 0)
        Me.Controls.SetChildIndex(Me.txtTotalHaber, 0)
        Me.Controls.SetChildIndex(Me.btnGenerarAsiento1, 0)
        Me.Controls.SetChildIndex(Me.btnModificar, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtDebe, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtHaber, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)

        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsAsientoVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarAsiento1.Click
        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        Me.LlenarGriDetalleAsiento1()
        If LlenarTotalesAsiento1() = True Then
            Accion = "AUT"
            Me.dtpFechaInicio.Enabled = False
            Me.dtpFechaFinal.Enabled = False
            Me.ToolBarRegistrar.Enabled = True
            Me.btnModificar.Enabled = True
            Me.txtDebe.Text = Format(0, "###,##0.00")
            Me.txtHaber.Text = Format(0, "###,##0.00")
            caso = 0
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
                Me.btnGenerarAsiento1.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                Me.btnModificar.Enabled = False


            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnGenerarAsiento1.Enabled = False
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
        Me.txtTotalHaber.Text = "0"
        Me.txtTotalDebe.Text = "0"

    End Sub

    Private Sub Buscar()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim cnnConexion2 As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT *  FROM SettingCuentaContable"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Sub
        ' se buscan los que correspondes al asiento de venta
        IdCuenta1(0) = rstReader("IdCuentaCobrar")
        IdCuenta1(1) = rstReader("IdEfectivo")
        IdCuenta1(2) = rstReader("IdValorTransito")
        IdCuenta1(3) = rstReader("IdTarjetaCredito")

        cnnConexion.Close()
    End Sub

    Private Sub Registrar()
        If caso = 0 Then
            RegistrarAsiento1()
        End If

    End Sub

    Private Sub RegistrarAsiento1()

        If ValidarCampos() = False Then Exit Sub


        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As SqlClient.SqlDataReader
        Dim sql As String
        Dim periodo As String
        Dim NumAsiento As Double
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        periodo = Date.Now.Month & " / " & Date.Now.Year

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " INSERT INTO AsientosContables " & _
" (Fecha,NumDoc,Beneficiario,TipoDoc, " & _
" Accion,Anulado,FechaEntrada,Mayorizado, " & _
" Periodo,NumMayorizado,Modulo,Observaciones, " & _
" NombreUsuario,TotalDebe,TotalHaber) " & _
" VALUES('" & dtpFechaFinal.Value.Date & "',9999,'BENE',9999, " & _
" '" & Accion & "',0,'" & Date.Now.Date & "',0,'" & periodo & "',0, " & _
" 'Recibo de dinero','Asiento automático de recibo de dinero desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "','" & Me.txtUsuario.Text & "' " & _
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
        sql = " UPDATE SeePOS.dbo.abonoccobrar SET Contabilizado = 1 ,Asiento  = " & NumAsiento & "  WHERE Anula = 0 AND Contabilizado = 0 AND " & _
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
            " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & FormatoDouble(.Haber) & ",0,1,'Asiento automático recibo dinero desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
            clsConexion.SlqExecute(cnnConexion, sql)
            cnnConexion.Close()
        End With


        For n = 1 To 3
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(n)
                cnnConexion.Open()
                sql = " insert into DetallesAsientosContable (NumAsiento,Cuenta,NombreCuenta,Monto,Debe,Haber,DescripcionAsiento) " & _
                " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & FormatoDouble(.Debe) & ",1,0,'Asiento automático recibo dinero desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
                clsConexion.SlqExecute(cnnConexion, sql)
                cnnConexion.Close()
            End With
        Next

        If Accion = "MAN" Then
            Dim debe, haber As Byte
            Dim monto As String
            With dtsAsientoVenta.GeneracionAutomaticaAsientoVenta(4)
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
                " VALUES(" & pNumAsiento & ",'" & .Codigo & "','" & .Descripcion & "'," & monto & "," & debe & "," & haber & ",'Asiento automático recibo dinero desde: " & Me.dtpFechaInicio.Value.Date & " hasta: " & Me.dtpFechaFinal.Value.Date & "') "
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
        Buscar()
    End Sub

    Private Sub ActivarGui()
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
        Me.btnGenerarAsiento1.Enabled = False
        Me.btnModificar.Enabled = False

    End Sub

    Private Sub Limpiar()

        Accion = "AUT"
        Dim n As Integer
        ' se inicializa el venctor donde se guardan las cuentas que estan guardadas en Contabilidad.SettingCuentaFacturaVenta
        For n = 0 To IdCuenta1.Length - 2
            IdCuenta1(n) = -1
        Next

        Me.txtTotalDebe.Text = Format(0, "¢###,##0.00")
        Me.txtTotalHaber.Text = Format(0, "¢###,##0.00")
    End Sub

#End Region

#Region "Funciones Llenar"
    ' este es para llenar el grid con los asientos de venta
    Private Sub LlenarGriDetalleAsiento1()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String
        Dim fecIni, fecFin As String
        fecIni = "  CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
        fecFin = "  CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"

        If ValidarIdCuenta1() = False Then
            MsgBox("No se puede generar asientos de ventas automáticamente si no se a configurado los asientos en Setting cuenta factura venta")
            Exit Sub
        End If

        sql = " (   " & _
" select 1 AS ID,  C.CuentaContable AS Codigo,C.Descripcion,0 as debe,  " & _
" (    " & _
" select " & _
" ISNULL(sum(AC.Monto*Moneda ),0) " & _
" from SeePOS.dbo.abonoccobrar AC, " & _
" ( " & _
" select AC.ID_RECIBO,(abono / abono_sumoneda) as Moneda " & _
" from seepos.dbo.detalle_abonoccobrar DAC,SeePOS.dbo.abonoccobrar AC " & _
" where DAC.ID_RECIBO = AC.id_recibo and contabilizado = 0 and anula = 0  " & _
" AND AC.fecha >=     " & fecIni & " and AC.fecha " & _
" <= " & fecFin & _
" and dac.abono <> 0 " & _
" GROUP BY AC.ID_RECIBO,(abono / abono_sumoneda)  " & _
" ) AS M " & _
" where ac.contabilizado = 0 and ac.anula = 0   " & _
" AND AC.fecha >=  " & fecIni & " and AC.fecha  " & _
" <=  " & fecFin & _
" AND M.Id_recibo = ac.id_recibo  " & _
" ) as Haber   " & _
" from  Contabilidad.dbo.CuentaContable C   " & _
" where  C.ID = " & IdCuenta1(0) & " GROUP BY C.CuentaContable,C.Descripcion  " & _
" ) " & _
" UNION " & _
" ( " & _
" select  2 AS ID,C.CuentaContable AS Codigo,C.Descripcion, " & _
" (  " & _
" SELECT     ISNULL(SUM(OP.MontoPago*OP.TipoCambio),0) " & _
" FROM         SeePOS.dbo.OpcionesDePago OP, SeePOS.dbo.abonoccobrar AC " & _
" WHERE     (OP.Fecha >= " & fecIni & " AND OP.Fecha <= " & fecFin & ") AND  " & _
" (OP.TipoDocumento = 'ABO') AND (OP.FormaPago = 'EFE') and OP.Documento = AC.Num_Recibo and ac.contabilizado = 0 and anula = 0" & _
" ) as DEBE,  " & _
" 0 AS HABER " & _
" from  Contabilidad.dbo.CuentaContable C  " & _
" where  C.ID = " & IdCuenta1(1) & _
" GROUP BY C.CuentaContable,C.Descripcion " & _
" ) " & _
" UNION " & _
" ( " & _
" select  3 AS ID,C.CuentaContable AS Codigo,C.Descripcion, " & _
" (  " & _
" SELECT     ISNULL(SUM(OP.MontoPago*OP.TipoCambio),0) " & _
" FROM         SeePOS.dbo.OpcionesDePago OP, SeePOS.dbo.abonoccobrar AC " & _
" WHERE     (OP.Fecha >= " & fecIni & " AND OP.Fecha <=  " & fecFin & ") AND  " & _
" (OP.TipoDocumento = 'ABO') AND (OP.FormaPago = 'CHE')and OP.Documento = AC.Num_Recibo and ac.contabilizado = 0 and anula = 0 " & _
" ) as DEBE,  " & _
" 0 AS HABER " & _
" from  Contabilidad.dbo.CuentaContable C " & _
" where  C.ID = " & IdCuenta1(2) & _
" GROUP BY C.CuentaContable,C.Descripcion " & _
" ) " & _
" UNION " & _
" ( " & _
" select  4 AS ID,C.CuentaContable AS Codigo,C.Descripcion, " & _
" (  " & _
" SELECT     ISNULL(SUM(OP.MontoPago*OP.TipoCambio),0) " & _
" FROM         SeePOS.dbo.OpcionesDePago OP, SeePOS.dbo.abonoccobrar AC " & _
" WHERE     (OP.Fecha >= " & fecIni & " AND OP.Fecha <=  " & fecFin & ") AND  " & _
" (OP.TipoDocumento = 'ABO') AND (OP.FormaPago = 'TRA')and OP.Documento = AC.Num_Recibo and ac.contabilizado = 0 and anula = 0 " & _
" ) as DEBE,  " & _
" 0 AS HABER " & _
" from  Contabilidad.dbo.CuentaContable C  " & _
" where  C.ID = " & IdCuenta1(3) & _
" GROUP BY C.CuentaContable,C.Descripcion " & _
" ) "
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
            valor = valor.Remove(n, 1)
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

        'SendKeys.Send("{TAB}")
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

        ReDim Preserve IdCuenta1(5)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT id  FROM CuentaContable where CuentaContable = '" & Me.txtCodigo.Text & "' "

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Sub

        IdCuenta1(4) = rstReader(0)

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
End Class

