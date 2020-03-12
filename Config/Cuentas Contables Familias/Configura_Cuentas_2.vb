Imports System.Data.SqlClient
Imports System.Data

Public Class Configura_Cuentas_2
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim codigo_servicio As String
    Dim id_usuario As String
    Dim paso As Boolean = False
    Dim usua As Object
#End Region

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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    ' Friend WithEvents DataSetConfiguraServicios1 As Hotel52.DataSetConfiguraServicios
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarEditar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents ColumnaFamilia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColumnaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdapterFamiliaCuentasContable As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents conexion_adapter As System.Data.SqlClient.SqlConnection
    Friend WithEvents ComboBoxFamilias As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBoxPuntoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxCuenta As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ColumnaDepartamentos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtDescripcionCuenta As System.Windows.Forms.TextBox
    Friend WithEvents DatasetConfiguraCuentas1 As Contabilidad.DatasetConfiguraCuentas
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Configura_Cuentas_2))
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtDescripcionCuenta = New System.Windows.Forms.TextBox
        Me.TextBoxCuenta = New System.Windows.Forms.TextBox
        Me.ComboBoxFamilias = New System.Windows.Forms.ComboBox
        Me.DatasetConfiguraCuentas1 = New Contabilidad.DatasetConfiguraCuentas
        Me.Label4 = New System.Windows.Forms.Label
        Me.ComboBoxPuntoVenta = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColumnaFamilia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColumnaContable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColumnaDepartamentos = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemLookUpEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEditar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.AdapterFamiliaCuentasContable = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.conexion_adapter = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox2.SuspendLayout()
        CType(Me.DatasetConfiguraCuentas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(816, 40)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "Formulario Cuentas Contables Familias"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-72, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(888, 16)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Información Cuenta Contable"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label19.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(8, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(208, 16)
        Me.Label19.TabIndex = 98
        Me.Label19.Text = "Familia"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.txtDescripcionCuenta)
        Me.GroupBox2.Controls.Add(Me.TextBoxCuenta)
        Me.GroupBox2.Controls.Add(Me.ComboBoxFamilias)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.ComboBoxPuntoVenta)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox2.Location = New System.Drawing.Point(0, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(832, 72)
        Me.GroupBox2.TabIndex = 133
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "General"
        '
        'txtDescripcionCuenta
        '
        Me.txtDescripcionCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionCuenta.Location = New System.Drawing.Point(576, 48)
        Me.txtDescripcionCuenta.Name = "txtDescripcionCuenta"
        Me.txtDescripcionCuenta.ReadOnly = True
        Me.txtDescripcionCuenta.Size = New System.Drawing.Size(232, 20)
        Me.txtDescripcionCuenta.TabIndex = 275
        Me.txtDescripcionCuenta.Text = ""
        '
        'TextBoxCuenta
        '
        Me.TextBoxCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCuenta.Location = New System.Drawing.Point(424, 48)
        Me.TextBoxCuenta.Name = "TextBoxCuenta"
        Me.TextBoxCuenta.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxCuenta.TabIndex = 274
        Me.TextBoxCuenta.Text = ""
        '
        'ComboBoxFamilias
        '
        Me.ComboBoxFamilias.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable.IdFamilia"))
        Me.ComboBoxFamilias.DataSource = Me.DatasetConfiguraCuentas1.Familias
        Me.ComboBoxFamilias.DisplayMember = "Descripcion"
        Me.ComboBoxFamilias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFamilias.Location = New System.Drawing.Point(8, 48)
        Me.ComboBoxFamilias.Name = "ComboBoxFamilias"
        Me.ComboBoxFamilias.Size = New System.Drawing.Size(208, 21)
        Me.ComboBoxFamilias.TabIndex = 1
        Me.ComboBoxFamilias.ValueMember = "Codigo"
        '
        'DatasetConfiguraCuentas1
        '
        Me.DatasetConfiguraCuentas1.DataSetName = "DatasetConfiguraCuentas"
        Me.DatasetConfiguraCuentas1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(424, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(384, 16)
        Me.Label4.TabIndex = 272
        Me.Label4.Text = "Cuenta Contable:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBoxPuntoVenta
        '
        Me.ComboBoxPuntoVenta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable.IdDepartamento"))
        Me.ComboBoxPuntoVenta.DataSource = Me.DatasetConfiguraCuentas1.Departamentos
        Me.ComboBoxPuntoVenta.DisplayMember = "Departamento"
        Me.ComboBoxPuntoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxPuntoVenta.Location = New System.Drawing.Point(224, 48)
        Me.ComboBoxPuntoVenta.Name = "ComboBoxPuntoVenta"
        Me.ComboBoxPuntoVenta.Size = New System.Drawing.Size(192, 21)
        Me.ComboBoxPuntoVenta.TabIndex = 2
        Me.ComboBoxPuntoVenta.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(224, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 16)
        Me.Label2.TabIndex = 270
        Me.Label2.Text = "Departamento"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "FamiliasCuentaContable"
        Me.GridControl1.DataSource = Me.DatasetConfiguraCuentas1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(0, 104)
        Me.GridControl1.MainView = Me.GridView3
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.RepositoryItemLookUpEdit2, Me.RepositoryItemLookUpEdit3})
        Me.GridControl1.Size = New System.Drawing.Size(816, 352)
        Me.GridControl1.Styles.AddReplace("Preview", New DevExpress.Utils.ViewStyleEx("Preview", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, True, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Top, Nothing, System.Drawing.Color.FromArgb(CType(217, Byte), CType(245, Byte), CType(255, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FooterPanel", New DevExpress.Utils.ViewStyleEx("FooterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupButton", New DevExpress.Utils.ViewStyleEx("GroupButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterCloseButton", New DevExpress.Utils.ViewStyleEx("FilterCloseButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(125, Byte), CType(125, Byte), CType(125, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("EvenRow", New DevExpress.Utils.ViewStyleEx("EvenRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.GhostWhite, System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("HideSelectionRow", New DevExpress.Utils.ViewStyleEx("HideSelectionRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FixedLine", New DevExpress.Utils.ViewStyleEx("FixedLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(15, Byte), CType(58, Byte), CType(81, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyleEx("HeaderPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupPanel", New DevExpress.Utils.ViewStyleEx("GroupPanel", "Grid", New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.SteelBlue, System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Empty", New DevExpress.Utils.ViewStyleEx("Empty", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupFooter", New DevExpress.Utils.ViewStyleEx("GroupFooter", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Far, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(167, Byte), CType(195, Byte), CType(210, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("GroupRow", New DevExpress.Utils.ViewStyleEx("GroupRow", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Silver, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("HorzLine", New DevExpress.Utils.ViewStyleEx("HorzLine", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButton", New DevExpress.Utils.ViewStyleEx("ColumnFilterButton", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedRow", New DevExpress.Utils.ViewStyleEx("FocusedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(135, Byte), CType(178, Byte), CType(201, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("VertLine", New DevExpress.Utils.ViewStyleEx("VertLine", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(157, Byte), CType(185, Byte), CType(200, Byte)), System.Drawing.Color.FromArgb(CType(85, Byte), CType(128, Byte), CType(151, Byte)), System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FocusedCell", New DevExpress.Utils.ViewStyleEx("FocusedCell", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("OddRow", New DevExpress.Utils.ViewStyleEx("OddRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(206, Byte), CType(220, Byte), CType(227, Byte)), System.Drawing.Color.Black, System.Drawing.Color.White, System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal))
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Arial", 8.0!), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.Color.FromArgb(CType(95, Byte), CType(138, Byte), CType(161, Byte)), System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("Row", New DevExpress.Utils.ViewStyleEx("Row", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("FilterPanel", New DevExpress.Utils.ViewStyleEx("FilterPanel", "Grid", New System.Drawing.Font("Arial", 8.0!), "", True, False, False, DevExpress.Utils.HorzAlignment.Near, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.Color.FromArgb(CType(35, Byte), CType(35, Byte), CType(35, Byte)), System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(212, Byte), CType(208, Byte), CType(200, Byte)), System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal))
        Me.GridControl1.Styles.AddReplace("RowSeparator", New DevExpress.Utils.ViewStyleEx("RowSeparator", "Grid", New System.Drawing.Font("Arial", 8.0!), DevExpress.Utils.StyleOptions.StyleEnabled, System.Drawing.Color.White, System.Drawing.Color.Gray, System.Drawing.Color.FromArgb(CType(177, Byte), CType(205, Byte), CType(220, Byte)), System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.LightGray, System.Drawing.Color.Blue, System.Drawing.Color.WhiteSmoke, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("DetailTip", New DevExpress.Utils.ViewStyleEx("DetailTip", "Grid", New System.Drawing.Font("Arial", 8.0!), System.Drawing.Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(225, Byte)), System.Drawing.Color.Black, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 134
        Me.GridControl1.Text = "GridControlTarifasServicios"
        '
        'GridView3
        '
        Me.GridView3.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColumnaFamilia, Me.ColumnaContable, Me.ColumnaDepartamentos})
        Me.GridView3.GroupPanelText = "Agrupe de acuerdo a una columna si lo desea"
        Me.GridView3.Name = "GridView3"
        '
        'ColumnaFamilia
        '
        Me.ColumnaFamilia.Caption = "Familia"
        Me.ColumnaFamilia.ColumnEdit = Me.RepositoryItemLookUpEdit1
        Me.ColumnaFamilia.FieldName = "IdFamilia"
        Me.ColumnaFamilia.Name = "ColumnaFamilia"
        Me.ColumnaFamilia.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.ColumnaFamilia.VisibleIndex = 0
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.DataSource = Me.DatasetConfiguraCuentas1.Familias
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Descripcion"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Codigo"
        '
        'ColumnaContable
        '
        Me.ColumnaContable.Caption = "Cuenta Contable"
        Me.ColumnaContable.ColumnEdit = Me.RepositoryItemLookUpEdit2
        Me.ColumnaContable.FieldName = "IdCuenta"
        Me.ColumnaContable.Name = "ColumnaContable"
        Me.ColumnaContable.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.ColumnaContable.VisibleIndex = 2
        '
        'RepositoryItemLookUpEdit2
        '
        Me.RepositoryItemLookUpEdit2.AutoHeight = False
        Me.RepositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit2.DataSource = Me.DatasetConfiguraCuentas1.CuentaContable
        Me.RepositoryItemLookUpEdit2.DisplayMember = "Descripcion"
        Me.RepositoryItemLookUpEdit2.Name = "RepositoryItemLookUpEdit2"
        Me.RepositoryItemLookUpEdit2.ValueMember = "id"
        '
        'ColumnaDepartamentos
        '
        Me.ColumnaDepartamentos.Caption = "Departamento"
        Me.ColumnaDepartamentos.ColumnEdit = Me.RepositoryItemLookUpEdit3
        Me.ColumnaDepartamentos.FieldName = "IdDepartamento"
        Me.ColumnaDepartamentos.Name = "ColumnaDepartamentos"
        Me.ColumnaDepartamentos.Options = CType(((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.ColumnaDepartamentos.VisibleIndex = 1
        '
        'RepositoryItemLookUpEdit3
        '
        Me.RepositoryItemLookUpEdit3.AutoHeight = False
        Me.RepositoryItemLookUpEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit3.DataSource = Me.DatasetConfiguraCuentas1.Departamentos
        Me.RepositoryItemLookUpEdit3.DisplayMember = "Departamento"
        Me.RepositoryItemLookUpEdit3.Name = "RepositoryItemLookUpEdit3"
        Me.RepositoryItemLookUpEdit3.ValueMember = "id"
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarEditar, Me.ToolBarRegistrar, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 458)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(816, 56)
        Me.ToolBar1.TabIndex = 6
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarEditar
        '
        Me.ToolBarEditar.ImageIndex = 5
        Me.ToolBarEditar.Text = "Editar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'AdapterFamiliaCuentasContable
        '
        Me.AdapterFamiliaCuentasContable.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterFamiliaCuentasContable.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterFamiliaCuentasContable.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterFamiliaCuentasContable.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FamiliasCuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdFamilia", "IdFamilia"), New System.Data.Common.DataColumnMapping("IdCuenta", "IdCuenta"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdDepartamento", "IdDepartamento")})})
        Me.AdapterFamiliaCuentasContable.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM FamiliasCuentaContable WHERE (Id = @Original_Id)"
        Me.SqlDeleteCommand1.Connection = Me.conexion_adapter
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        '
        'conexion_adapter
        '
        Me.conexion_adapter.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO FamiliasCuentaContable(IdFamilia, IdCuenta, IdDepartamento) VALUES (@" & _
        "IdFamilia, @IdCuenta, @IdDepartamento); SELECT IdFamilia, IdCuenta, Id, IdDepart" & _
        "amento FROM FamiliasCuentaContable WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.conexion_adapter
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdFamilia", System.Data.SqlDbType.Int, 4, "IdFamilia"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCuenta", System.Data.SqlDbType.Int, 4, "IdCuenta"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDepartamento", System.Data.SqlDbType.Int, 4, "IdDepartamento"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT IdFamilia, IdCuenta, Id, IdDepartamento FROM FamiliasCuentaContable"
        Me.SqlSelectCommand1.Connection = Me.conexion_adapter
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE FamiliasCuentaContable SET IdFamilia = @IdFamilia, IdCuenta = @IdCuenta, I" & _
        "dDepartamento = @IdDepartamento WHERE (Id = @Original_Id); SELECT IdFamilia, IdC" & _
        "uenta, Id, IdDepartamento FROM FamiliasCuentaContable WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.conexion_adapter
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdFamilia", System.Data.SqlDbType.Int, 4, "IdFamilia"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCuenta", System.Data.SqlDbType.Int, 4, "IdCuenta"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDepartamento", System.Data.SqlDbType.Int, 4, "IdDepartamento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'Configura_Cuentas_2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(816, 514)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "Configura_Cuentas_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de  Cuentas Contables Familias"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DatasetConfiguraCuentas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Sub llenarDatos()
        Dim cf As New cFunciones
        cf.Llenar_Tabla_Generico("Select * From Familia", Me.DatasetConfiguraCuentas1.Familias, Configuracion.Claves.Conexion("Proveeduria"))
        cf.Llenar_Tabla_Generico("Select * From Departamentos", Me.DatasetConfiguraCuentas1.Departamentos, Configuracion.Claves.Conexion("Proveeduria"))
        cf.Llenar_Tabla_Generico("Select * From CuentaContable Where Movimiento = 1", Me.DatasetConfiguraCuentas1.CuentaContable, Configuracion.Claves.Conexion("Contabilidad"))
    End Sub

    Private Sub Configura_Servicios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.conexion_adapter.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            Me.AdapterFamiliaCuentasContable.Fill(Me.DatasetConfiguraCuentas1.FamiliasCuentaContable)
            Me.llenarDatos()

            'Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.IdColumn.AutoIncrement = True
            'Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.IdColumn.AutoIncrementSeed = -1
            'Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.IdColumn.AutoIncrementStep = -1
            Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.IdCuentaColumn.DefaultValue = 0
            Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.IdFamiliaColumn.DefaultValue = Me.DatasetConfiguraCuentas1.Familias(0).Codigo
            Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.IdDepartamentoColumn.DefaultValue = Me.DatasetConfiguraCuentas1.Departamentos(0).id

            Me.GroupBox2.Enabled = False
            mostrar()

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Sub mostrar()
        Dim i As Integer = 0
        For i = 0 To Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.Count - 1
            Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Position = i
        Next
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : Nuevo()
            Case 2 : Me.Editar()
            Case 3 : Me.Registrar()
            Case 4 : Me.Cerrar()
        End Select
    End Sub
#End Region

#Region "Controles"
    Private Sub Inabilitar_botones()
        Me.GroupBox2.Enabled = False
        Me.ToolBar1.Buttons(0).Enabled = False
        Me.ToolBar1.Buttons(1).Enabled = False
        Me.ToolBar1.Buttons(2).Enabled = False
        Me.ToolBar1.Buttons(3).Enabled = False
    End Sub

    Private Sub ComboBoxFamilias_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxFamilias.KeyDown
        If e.KeyCode = Keys.Enter Then  'PASA AL SIGUIENTE CONTROL
            ComboBoxPuntoVenta.Focus()
        End If
    End Sub

    Private Sub ComboBoxPuntoVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ComboBoxPuntoVenta.KeyDown
        If e.KeyCode = Keys.Enter Then  'PASA AL SIGUIENTE CONTROL
            TextBoxCuenta.Focus()
        End If
    End Sub

    Private Sub TextBoxCuenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxCuenta.KeyDown
        Try
            If e.KeyCode = Keys.F1 Then
                '-----------------------------------------------------------------------------------
                'ABRE BUSCARDOR DE LA CUENTA CONTABLE CUANDO SE PRESIONA F1
                Dim busca As New fmrBuscarMayorizacionAsiento
                busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
                busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
                                " where Movimiento=1 "
                busca.campo = "descripcion"
                busca.sqlStringAdicional = " ORDER BY CuentaContable  "
                busca.ShowDialog()

                If busca.codigo Is Nothing Then Exit Sub

                TextBoxCuenta.Text = busca.codigo
                txtDescripcionCuenta.Text = busca.descrip

                Dim idCuenta As Integer
                Dim Cx As New Conexion
                idCuenta = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Id FROM CuentaContable WHERE CuentaContable= '" & TextBoxCuenta.Text & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Current("IdCuenta") = idCuenta
                '-----------------------------------------------------------------------------------
            End If

            If e.KeyCode = Keys.Enter Then
                '-----------------------------------------------------------------------------------
                'VALIDA LA CUENTA CONTABLE DIGITADA AL PRECIONAR ENTER Y PASA AL SIGUIENTE CONTROL
                Dim Cx As New Conexion
                Dim valida As String
                Dim num_cuenta As String = TextBoxCuenta.Text
                valida = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                Cx.DesConectar(Cx.sQlconexion)
                If valida = "" Then
                    MessageBox.Show("La cuenta digitada no esta registrada..", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    Dim nombre As String
                    Dim idCuenta As Integer
                    nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                    Cx.DesConectar(Cx.sQlconexion)
                    txtDescripcionCuenta.Text = nombre
                    idCuenta = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Id FROM CuentaContable WHERE CuentaContable= '" & num_cuenta & "' AND Movimiento=1")
                    Cx.DesConectar(Cx.sQlconexion)
                    Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Current("IdCuenta") = idCuenta
                    ToolBar1.Focus()
                End If
                '-----------------------------------------------------------------------------------
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        End Try
    End Sub

    Private Sub GridView3_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView3.FocusedRowChanged
        Dim nombre, cuenta As String        'ACTUALIZA EL NOMBRE Y DESCRIPCION DE LA CUENTA EN LOS TEXTBOX
        Dim Cx As New Conexion              'CUANDO SE CAMBIA DE POSICION EN EL BINDING
        cuenta = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT CuentaContable FROM CuentaContable WHERE id= " & Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Current("IdCuenta"))
        Cx.DesConectar(Cx.sQlconexion)
        TextBoxCuenta.Text = cuenta
        nombre = Cx.SlqExecuteScalar(Cx.Conectar("Contabilidad"), "SELECT Descripcion FROM CuentaContable WHERE id= " & Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Current("IdCuenta"))
        Cx.DesConectar(Cx.sQlconexion)
        txtDescripcionCuenta.Text = nombre
    End Sub

    Private Sub GridView3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridView3.KeyDown
        If e.KeyCode = Keys.Delete Then
            Elimina()
        End If
    End Sub
#End Region

#Region "Nuevo"
    Public Sub Nuevo()
        Try
            If Me.ToolBarNuevo.ImageIndex = 0 Then
                Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").CancelCurrentEdit()
                Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").AddNew()
                ToolBar1.Buttons(0).Text = "Cancelar"
                ToolBar1.Buttons(0).ImageIndex = 4
                Me.GroupBox2.Enabled = True
                Me.GridControl1.Enabled = False
                Me.ToolBarEditar.Enabled = False
                Me.ToolBarRegistrar.Enabled = True
                ComboBoxFamilias.Focus()
            Else
                Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
                Me.GroupBox2.Enabled = False
                Me.GridControl1.Enabled = True
                Me.ToolBarEditar.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Editar"
    Function Editar()
        If Me.ToolBarEditar.ImageIndex = 5 Then
            Me.ToolBarEditar.Text = "Cancelar"
            Me.ToolBarEditar.ImageIndex = 4
            Me.GroupBox2.Enabled = True
            Me.GridControl1.Enabled = False
            Me.ToolBarRegistrar.Enabled = True
            ComboBoxFamilias.Focus()
        Else
            Me.ToolBarEditar.Text = "Editar"
            Me.ToolBarEditar.ImageIndex = 5
            Me.GroupBox2.Enabled = False
            Me.GridControl1.Enabled = True
            Me.ToolBarRegistrar.Enabled = False
        End If
    End Function
#End Region

#Region "Registrar"
    Function Registrar()
        Dim Trans As SqlTransaction

        Try
            If Me.ToolBarRegistrar.Text = "Registrar" Then
                If ValidarNoRepetidos() Then
                    If MsgBox("¿Desea guardas los cambios?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        If Me.conexion_adapter.State <> Me.conexion_adapter.State.Open Then Me.conexion_adapter.Open()
                        Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").EndCurrentEdit()
                        Trans = Me.conexion_adapter.BeginTransaction
                        Me.AdapterFamiliaCuentasContable.SelectCommand.Transaction = Trans
                        Me.AdapterFamiliaCuentasContable.UpdateCommand.Transaction = Trans
                        Me.AdapterFamiliaCuentasContable.DeleteCommand.Transaction = Trans
                        Me.AdapterFamiliaCuentasContable.InsertCommand.Transaction = Trans
                        Me.AdapterFamiliaCuentasContable.Update(Me.DatasetConfiguraCuentas1.FamiliasCuentaContable)
                        Trans.Commit()
                        Me.ToolBarEditar.ImageIndex = 5
                        Me.ToolBarEditar.Text = "Editar"
                        Me.ToolBarNuevo.ImageIndex = 0
                        Me.ToolBarNuevo.Text = "Nuevo"
                        Me.GroupBox2.Enabled = False
                        Me.ToolBarRegistrar.Enabled = False
                        Me.ToolBarEditar.Enabled = True
                        Me.ToolBarNuevo.Enabled = True
                        Me.GridControl1.Enabled = True
                    End If
                End If
            End If

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.ToString)
        End Try
    End Function
#End Region

#Region "Eliminar"
    Private Function Elimina()
        Dim Cconexion As New Conexion
        Dim Resultado, Identificacion As String

        If MessageBox.Show(" ¿Desea Eliminar Esta Familia ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Function
        Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").RemoveAt(Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Position)
        Me.RegistraEliminar()
        If Resultado = vbNullString Then
            MessageBox.Show("La Familia Fue Eliminada", "Atención...", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(Resultado)
            Exit Function
        End If
    End Function


    Function RegistraEliminar() As Boolean
        Dim Trans As SqlTransaction
        Try
            If Me.conexion_adapter.State <> Me.conexion_adapter.State.Open Then Me.conexion_adapter.Open()
            Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").EndCurrentEdit()
            Trans = Me.conexion_adapter.BeginTransaction
            Me.AdapterFamiliaCuentasContable.SelectCommand.Transaction = Trans
            Me.AdapterFamiliaCuentasContable.UpdateCommand.Transaction = Trans
            Me.AdapterFamiliaCuentasContable.DeleteCommand.Transaction = Trans
            Me.AdapterFamiliaCuentasContable.InsertCommand.Transaction = Trans
            Me.AdapterFamiliaCuentasContable.Update(Me.DatasetConfiguraCuentas1.FamiliasCuentaContable)
            Trans.Commit()
            Me.ToolBarEditar.ImageIndex = 5
            Me.ToolBarEditar.Text = "Editar"
            Me.ToolBarNuevo.ImageIndex = 0
            Me.ToolBarNuevo.Text = "Nuevo"
            Me.GroupBox2.Enabled = False
            Me.ToolBarRegistrar.Enabled = False
            Me.ToolBarEditar.Enabled = True
            Me.ToolBarNuevo.Enabled = True
            Me.GridControl1.Enabled = True
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.ToString)
            Return False
        End Try
    End Function
#End Region

#Region "Cerrar"
    Function Cerrar()
        If Me.ToolBarCerrar.Text = "Cerrar" Then Me.Close()
    End Function
#End Region

#Region "Validar"
    Function ValidarNoRepetidos() As Boolean
        Dim dr() As DataRow
        If Me.ToolBarNuevo.ImageIndex = 4 Then
            dr = Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.Select("IdFamilia = " & Me.ComboBoxFamilias.SelectedValue & " and IdDepartamento = " & Me.ComboBoxPuntoVenta.SelectedValue)
        End If

        If Me.ToolBarEditar.ImageIndex = 4 Then
            dr = Me.DatasetConfiguraCuentas1.FamiliasCuentaContable.Select("IdFamilia = " & Me.ComboBoxFamilias.SelectedValue & " and IdDepartamento = " & Me.ComboBoxPuntoVenta.SelectedValue & " and Id <> " & Me.BindingContext(Me.DatasetConfiguraCuentas1, "FamiliasCuentaContable").Current("Id").ToString)
        End If

        If dr.Length <> 0 Then
            MsgBox("Ya existe una esta familia con el mismo departamento!", MsgBoxStyle.Critical, "Sistema SeeSoft")
            Return False
        Else
            Return True
        End If
    End Function
#End Region

End Class
