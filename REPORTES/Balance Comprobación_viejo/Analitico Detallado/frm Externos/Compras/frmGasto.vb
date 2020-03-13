Imports System.Data.SqlClient
Imports System.Data
Imports Utilidades

Public Class frmGasto
    Inherits System.Windows.Forms.Form

#Region "variables"
    Dim Usua As New Object
    Dim idProveedor() As Integer
    Dim idTipoCompra() As Integer
    Dim IdMoneda() As Integer
    Dim impuesto, TotalCentro As Double
    Dim IdDetalle, CodOperacion, IdGasto As Integer
    Public EditaCentro As Boolean = False
    Dim NumAsiento As String = ""
    Dim tipocambio As Double = 0
    Dim Conta As Integer
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()
        InitializeComponent() 'This call is required by the Windows Form Designer.
        Usua = Usuario_Parametro
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
    Protected Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonSeparador1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarImportar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonSeparador2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtNumeroFactura As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents txtCuentaContableDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtCuentaContable As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtDetallePrecioUnidad As System.Windows.Forms.TextBox
    Friend WithEvents gridDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents tlbNuevo As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbRegistrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbEliminar As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbImprimir As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbRecalcular As System.Windows.Forms.ToolBarButton
    Friend WithEvents tlbCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents dtsGasto As DatasetGasto
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtDetalleArticuloDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtImpuesto As System.Windows.Forms.TextBox
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda4 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda3 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda2 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda1 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.Label
    Friend WithEvents cbTipoOperacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BCentroCosto As System.Windows.Forms.Button
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterCentroCostoMovimiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdapterCentroCosto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PanelCentroCosto As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BNuevo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents BotonCerrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridCentroCosto As DevExpress.XtraGrid.GridControl
    Friend WithEvents ButtonAgregarDetalle As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EditDescripcionCC As DevExpress.XtraEditors.MemoExEdit
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents CBCentroCosto As System.Windows.Forms.ComboBox
    Friend WithEvents txtMontoCentroCosto As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGasto))
        Me.Label46 = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.tlbNuevo = New System.Windows.Forms.ToolBarButton
        Me.tlbBuscar = New System.Windows.Forms.ToolBarButton
        Me.tlbRegistrar = New System.Windows.Forms.ToolBarButton
        Me.tlbEliminar = New System.Windows.Forms.ToolBarButton
        Me.tlbImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonSeparador1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImportar = New System.Windows.Forms.ToolBarButton
        Me.tlbRecalcular = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButtonSeparador2 = New System.Windows.Forms.ToolBarButton
        Me.tlbCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.cmbTipo = New System.Windows.Forms.ComboBox
        Me.txtNumeroFactura = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbMoneda = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbProveedor = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PanelCentroCosto = New System.Windows.Forms.Panel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BNuevo = New DevExpress.XtraEditors.SimpleButton
        Me.TxtDetalle = New System.Windows.Forms.TextBox
        Me.BotonCerrar = New DevExpress.XtraEditors.SimpleButton
        Me.GridCentroCosto = New DevExpress.XtraGrid.GridControl
        Me.dtsGasto = New Contabilidad.DatasetGasto
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonAgregarDetalle = New DevExpress.XtraEditors.SimpleButton
        Me.EditDescripcionCC = New DevExpress.XtraEditors.MemoExEdit
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.CBCentroCosto = New System.Windows.Forms.ComboBox
        Me.txtMontoCentroCosto = New DevExpress.XtraEditors.TextEdit
        Me.Label22 = New System.Windows.Forms.Label
        Me.BCentroCosto = New System.Windows.Forms.Button
        Me.cbTipoOperacion = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblMoneda1 = New System.Windows.Forms.Label
        Me.lblMoneda2 = New System.Windows.Forms.Label
        Me.lblMoneda3 = New System.Windows.Forms.Label
        Me.lblMoneda4 = New System.Windows.Forms.Label
        Me.txtImpuesto = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCuentaContableDescripcion = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCuentaContable = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTotalImpuesto = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTotalDescuento = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDetalleSubTotal = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDetalleDescuento = New System.Windows.Forms.TextBox
        Me.txtDetallePrecioUnidad = New System.Windows.Forms.TextBox
        Me.txtDetalleArticuloDescripcion = New System.Windows.Forms.TextBox
        Me.txtDetalleCantidad = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.gridDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.TxtNombreUsuario = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterCentroCostoMovimiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterCentroCosto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelCentroCosto.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridCentroCosto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsGasto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EditDescripcionCC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMontoCentroCosto.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label46
        '
        Me.Label46.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.Label46.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Label46.ForeColor = System.Drawing.Color.White
        Me.Label46.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(0, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(976, 24)
        Me.Label46.TabIndex = 0
        Me.Label46.Text = "Registro de Gastos"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tlbNuevo, Me.tlbBuscar, Me.tlbRegistrar, Me.tlbEliminar, Me.tlbImprimir, Me.ToolBarExcel, Me.ToolBarButtonSeparador1, Me.ToolBarImportar, Me.tlbRecalcular, Me.ToolBarButtonSeparador2, Me.tlbCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(60, 55)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 368)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1128, 61)
        Me.ToolBar1.TabIndex = 3
        '
        'tlbNuevo
        '
        Me.tlbNuevo.Enabled = False
        Me.tlbNuevo.ImageIndex = 0
        Me.tlbNuevo.Text = "Nuevo"
        Me.tlbNuevo.Visible = False
        '
        'tlbBuscar
        '
        Me.tlbBuscar.Enabled = False
        Me.tlbBuscar.ImageIndex = 1
        Me.tlbBuscar.Text = "Buscar"
        Me.tlbBuscar.Visible = False
        '
        'tlbRegistrar
        '
        Me.tlbRegistrar.Enabled = False
        Me.tlbRegistrar.ImageIndex = 2
        Me.tlbRegistrar.Text = "Registrar"
        '
        'tlbEliminar
        '
        Me.tlbEliminar.Enabled = False
        Me.tlbEliminar.ImageIndex = 3
        Me.tlbEliminar.Text = "Eliminar"
        '
        'tlbImprimir
        '
        Me.tlbImprimir.Enabled = False
        Me.tlbImprimir.ImageIndex = 7
        Me.tlbImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarButtonSeparador1
        '
        Me.ToolBarButtonSeparador1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        Me.ToolBarButtonSeparador1.Visible = False
        '
        'ToolBarImportar
        '
        Me.ToolBarImportar.ImageIndex = 9
        Me.ToolBarImportar.Text = "Importar"
        Me.ToolBarImportar.Visible = False
        '
        'tlbRecalcular
        '
        Me.tlbRecalcular.Enabled = False
        Me.tlbRecalcular.ImageIndex = 10
        Me.tlbRecalcular.Text = "ReCalcular"
        Me.tlbRecalcular.Visible = False
        '
        'ToolBarButtonSeparador2
        '
        Me.ToolBarButtonSeparador2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        Me.ToolBarButtonSeparador2.Visible = False
        '
        'tlbCerrar
        '
        Me.tlbCerrar.ImageIndex = 6
        Me.tlbCerrar.Text = "Cerrar"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(536, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Factura #"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(677, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(8, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(400, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Proveedor"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label39
        '
        Me.Label39.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label39.Location = New System.Drawing.Point(438, 13)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(64, 15)
        Me.Label39.TabIndex = 2
        Me.Label39.Text = "Tipo"
        Me.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbTipo
        '
        Me.cmbTipo.DisplayMember = "CON"
        Me.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipo.ForeColor = System.Drawing.Color.Blue
        Me.cmbTipo.Items.AddRange(New Object() {"CON", "CRE"})
        Me.cmbTipo.Location = New System.Drawing.Point(438, 29)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(64, 21)
        Me.cmbTipo.TabIndex = 3
        Me.cmbTipo.ValueMember = "CON"
        '
        'txtNumeroFactura
        '
        Me.txtNumeroFactura.Location = New System.Drawing.Point(536, 29)
        Me.txtNumeroFactura.Name = "txtNumeroFactura"
        Me.txtNumeroFactura.Size = New System.Drawing.Size(112, 20)
        Me.txtNumeroFactura.TabIndex = 5
        Me.txtNumeroFactura.Text = ""
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(677, 29)
        Me.dtpFecha.MaxDate = New Date(2020, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2009, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(128, 20)
        Me.dtpFecha.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMoneda)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbProveedor)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.txtNumeroFactura)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label39)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(960, 57)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encabezado"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.DisplayMember = "CON"
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMoneda.ForeColor = System.Drawing.Color.Blue
        Me.cmbMoneda.Location = New System.Drawing.Point(838, 29)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(104, 21)
        Me.cmbMoneda.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label15.Location = New System.Drawing.Point(838, 13)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 15)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Moneda"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbProveedor
        '
        Me.cmbProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProveedor.DisplayMember = "Proveedores.CodigoProv"
        Me.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProveedor.ForeColor = System.Drawing.Color.Blue
        Me.cmbProveedor.ItemHeight = 13
        Me.cmbProveedor.Location = New System.Drawing.Point(8, 29)
        Me.cmbProveedor.Name = "cmbProveedor"
        Me.cmbProveedor.Size = New System.Drawing.Size(400, 21)
        Me.cmbProveedor.TabIndex = 1
        Me.cmbProveedor.ValueMember = "Proveedores.CodigoProv"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelCentroCosto)
        Me.GroupBox2.Controls.Add(Me.BCentroCosto)
        Me.GroupBox2.Controls.Add(Me.cbTipoOperacion)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblMoneda1)
        Me.GroupBox2.Controls.Add(Me.lblMoneda2)
        Me.GroupBox2.Controls.Add(Me.lblMoneda3)
        Me.GroupBox2.Controls.Add(Me.lblMoneda4)
        Me.GroupBox2.Controls.Add(Me.txtImpuesto)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtCuentaContableDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtCuentaContable)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtTotalDescuento)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDetalleSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtDetalleDescuento)
        Me.GroupBox2.Controls.Add(Me.txtDetallePrecioUnidad)
        Me.GroupBox2.Controls.Add(Me.txtDetalleArticuloDescripcion)
        Me.GroupBox2.Controls.Add(Me.txtDetalleCantidad)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.gridDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(960, 258)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalle"
        '
        'PanelCentroCosto
        '
        Me.PanelCentroCosto.BackColor = System.Drawing.Color.White
        Me.PanelCentroCosto.Controls.Add(Me.GroupBox3)
        Me.PanelCentroCosto.Controls.Add(Me.Label22)
        Me.PanelCentroCosto.Location = New System.Drawing.Point(-400, 24)
        Me.PanelCentroCosto.Name = "PanelCentroCosto"
        Me.PanelCentroCosto.Size = New System.Drawing.Size(374, 219)
        Me.PanelCentroCosto.TabIndex = 203
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BNuevo)
        Me.GroupBox3.Controls.Add(Me.TxtDetalle)
        Me.GroupBox3.Controls.Add(Me.BotonCerrar)
        Me.GroupBox3.Controls.Add(Me.GridCentroCosto)
        Me.GroupBox3.Controls.Add(Me.ButtonAgregarDetalle)
        Me.GroupBox3.Controls.Add(Me.EditDescripcionCC)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.CBCentroCosto)
        Me.GroupBox3.Controls.Add(Me.txtMontoCentroCosto)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox3.Location = New System.Drawing.Point(4, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(356, 200)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'BNuevo
        '
        Me.BNuevo.Location = New System.Drawing.Point(120, 80)
        Me.BNuevo.Name = "BNuevo"
        Me.BNuevo.Size = New System.Drawing.Size(72, 20)
        Me.BNuevo.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.BNuevo.TabIndex = 204
        Me.BNuevo.Text = "Nuevo"
        '
        'TxtDetalle
        '
        Me.TxtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDetalle.Enabled = False
        Me.TxtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDetalle.ForeColor = System.Drawing.Color.Blue
        Me.TxtDetalle.Location = New System.Drawing.Point(8, 80)
        Me.TxtDetalle.Name = "TxtDetalle"
        Me.TxtDetalle.ReadOnly = True
        Me.TxtDetalle.Size = New System.Drawing.Size(96, 13)
        Me.TxtDetalle.TabIndex = 203
        Me.TxtDetalle.Text = "0.00"
        Me.TxtDetalle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BotonCerrar
        '
        Me.BotonCerrar.Location = New System.Drawing.Point(264, 80)
        Me.BotonCerrar.Name = "BotonCerrar"
        Me.BotonCerrar.Size = New System.Drawing.Size(72, 20)
        Me.BotonCerrar.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.BotonCerrar.TabIndex = 202
        Me.BotonCerrar.Text = "Cerrar"
        '
        'GridCentroCosto
        '
        Me.GridCentroCosto.DataSource = Me.dtsGasto.CentroCostoDetalle
        '
        'GridCentroCosto.EmbeddedNavigator
        '
        Me.GridCentroCosto.EmbeddedNavigator.Name = ""
        Me.GridCentroCosto.Location = New System.Drawing.Point(8, 112)
        Me.GridCentroCosto.MainView = Me.GridView2
        Me.GridCentroCosto.Name = "GridCentroCosto"
        Me.GridCentroCosto.Size = New System.Drawing.Size(344, 80)
        Me.GridCentroCosto.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridCentroCosto.TabIndex = 201
        Me.GridCentroCosto.Text = "GridControl1"
        '
        'dtsGasto
        '
        Me.dtsGasto.DataSetName = "DatasetGasto"
        Me.dtsGasto.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView2
        '
        Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn10, Me.GridColumn11, Me.GridColumn15})
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsView.ShowGroupPanel = False
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "CentroCosto"
        Me.GridColumn10.FieldName = "CentroCosto"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.VisibleIndex = 0
        Me.GridColumn10.Width = 112
        '
        'GridColumn11
        '
        Me.GridColumn11.Caption = "Monto"
        Me.GridColumn11.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn11.FieldName = "Monto"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 112
        '
        'GridColumn15
        '
        Me.GridColumn15.Caption = "Descripción"
        Me.GridColumn15.FieldName = "Descripcion"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.VisibleIndex = 2
        Me.GridColumn15.Width = 111
        '
        'ButtonAgregarDetalle
        '
        Me.ButtonAgregarDetalle.Enabled = False
        Me.ButtonAgregarDetalle.Location = New System.Drawing.Point(192, 80)
        Me.ButtonAgregarDetalle.Name = "ButtonAgregarDetalle"
        Me.ButtonAgregarDetalle.Size = New System.Drawing.Size(72, 20)
        Me.ButtonAgregarDetalle.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.0!), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.Color.RoyalBlue)
        Me.ButtonAgregarDetalle.TabIndex = 200
        Me.ButtonAgregarDetalle.Text = "Agregar"
        '
        'EditDescripcionCC
        '
        Me.EditDescripcionCC.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dtsGasto, "CentroCosto_Movimientos.Descripcion"))
        Me.EditDescripcionCC.Location = New System.Drawing.Point(120, 56)
        Me.EditDescripcionCC.Name = "EditDescripcionCC"
        '
        'EditDescripcionCC.Properties
        '
        Me.EditDescripcionCC.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.EditDescripcionCC.Properties.Enabled = False
        Me.EditDescripcionCC.Properties.ShowIcon = False
        Me.EditDescripcionCC.Properties.ShowPopupShadow = False
        Me.EditDescripcionCC.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.EditDescripcionCC.Size = New System.Drawing.Size(216, 21)
        Me.EditDescripcionCC.TabIndex = 199
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(8, 40)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 13)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "Monto"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(120, 40)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(216, 13)
        Me.Label28.TabIndex = 54
        Me.Label28.Text = "Descripción"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label21.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(8, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Centro de Costo"
        '
        'CBCentroCosto
        '
        Me.CBCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.dtsGasto, "CentroCosto_Movimientos.IdCentroCosto"))
        Me.CBCentroCosto.DataSource = Me.dtsGasto
        Me.CBCentroCosto.DisplayMember = "CentroCosto.Nombre"
        Me.CBCentroCosto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBCentroCosto.Enabled = False
        Me.CBCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCentroCosto.ForeColor = System.Drawing.Color.Blue
        Me.CBCentroCosto.ItemHeight = 13
        Me.CBCentroCosto.Location = New System.Drawing.Point(112, 15)
        Me.CBCentroCosto.Name = "CBCentroCosto"
        Me.CBCentroCosto.Size = New System.Drawing.Size(224, 21)
        Me.CBCentroCosto.TabIndex = 0
        Me.CBCentroCosto.ValueMember = "CentroCosto.Id"
        '
        'txtMontoCentroCosto
        '
        Me.txtMontoCentroCosto.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dtsGasto, "CentroCosto_Movimientos.Monto"))
        Me.txtMontoCentroCosto.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMontoCentroCosto.Location = New System.Drawing.Point(8, 56)
        Me.txtMontoCentroCosto.Name = "txtMontoCentroCosto"
        '
        'txtMontoCentroCosto.Properties
        '
        Me.txtMontoCentroCosto.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCentroCosto.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtMontoCentroCosto.Properties.Enabled = False
        Me.txtMontoCentroCosto.Properties.Style = New DevExpress.Utils.ViewStyle("ControlStyle", Nothing, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Default, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Window, System.Drawing.Color.Blue)
        Me.txtMontoCentroCosto.Size = New System.Drawing.Size(104, 21)
        Me.txtMontoCentroCosto.TabIndex = 5
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(48, 1)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(269, 13)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "Centro de Costo"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BCentroCosto
        '
        Me.BCentroCosto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCentroCosto.ForeColor = System.Drawing.Color.RoyalBlue
        Me.BCentroCosto.Location = New System.Drawing.Point(592, 56)
        Me.BCentroCosto.Name = "BCentroCosto"
        Me.BCentroCosto.Size = New System.Drawing.Size(120, 23)
        Me.BCentroCosto.TabIndex = 140
        Me.BCentroCosto.Text = "Centro de Costo"
        '
        'cbTipoOperacion
        '
        Me.cbTipoOperacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipoOperacion.DisplayMember = "TipoCompra.Descripcion"
        Me.cbTipoOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTipoOperacion.Enabled = False
        Me.cbTipoOperacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipoOperacion.ForeColor = System.Drawing.Color.Blue
        Me.cbTipoOperacion.ItemHeight = 13
        Me.cbTipoOperacion.Location = New System.Drawing.Point(767, 32)
        Me.cbTipoOperacion.Name = "cbTipoOperacion"
        Me.cbTipoOperacion.Size = New System.Drawing.Size(185, 21)
        Me.cbTipoOperacion.TabIndex = 28
        Me.cbTipoOperacion.ValueMember = "TipoCompra.Codigo"
        '
        'Label16
        '
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label16.Location = New System.Drawing.Point(767, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(185, 16)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "Tipo Operación:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMoneda1
        '
        Me.lblMoneda1.Location = New System.Drawing.Point(152, 216)
        Me.lblMoneda1.Name = "lblMoneda1"
        Me.lblMoneda1.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda1.TabIndex = 16
        Me.lblMoneda1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda2
        '
        Me.lblMoneda2.Location = New System.Drawing.Point(328, 216)
        Me.lblMoneda2.Name = "lblMoneda2"
        Me.lblMoneda2.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda2.TabIndex = 19
        Me.lblMoneda2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda3
        '
        Me.lblMoneda3.Location = New System.Drawing.Point(496, 216)
        Me.lblMoneda3.Name = "lblMoneda3"
        Me.lblMoneda3.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda3.TabIndex = 22
        Me.lblMoneda3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblMoneda4
        '
        Me.lblMoneda4.Location = New System.Drawing.Point(680, 216)
        Me.lblMoneda4.Name = "lblMoneda4"
        Me.lblMoneda4.Size = New System.Drawing.Size(24, 23)
        Me.lblMoneda4.TabIndex = 25
        Me.lblMoneda4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(322, 32)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(64, 20)
        Me.txtImpuesto.TabIndex = 7
        Me.txtImpuesto.Text = ""
        Me.txtImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label14.Location = New System.Drawing.Point(322, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Impuesto"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaContableDescripcion
        '
        Me.txtCuentaContableDescripcion.BackColor = System.Drawing.Color.White
        Me.txtCuentaContableDescripcion.Enabled = False
        Me.txtCuentaContableDescripcion.Location = New System.Drawing.Point(593, 32)
        Me.txtCuentaContableDescripcion.Name = "txtCuentaContableDescripcion"
        Me.txtCuentaContableDescripcion.Size = New System.Drawing.Size(168, 20)
        Me.txtCuentaContableDescripcion.TabIndex = 13
        Me.txtCuentaContableDescripcion.Text = ""
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(593, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(168, 16)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Descripción"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuentaContable
        '
        Me.txtCuentaContable.Location = New System.Drawing.Point(469, 32)
        Me.txtCuentaContable.Name = "txtCuentaContable"
        Me.txtCuentaContable.Size = New System.Drawing.Size(120, 20)
        Me.txtCuentaContable.TabIndex = 11
        Me.txtCuentaContable.Text = ""
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label12.Location = New System.Drawing.Point(469, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 16)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Cuenta contable"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(704, 224)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtTotal.TabIndex = 26
        Me.txtTotal.Text = ""
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label11.Location = New System.Drawing.Point(704, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Total:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalImpuesto
        '
        Me.txtTotalImpuesto.BackColor = System.Drawing.Color.White
        Me.txtTotalImpuesto.Enabled = False
        Me.txtTotalImpuesto.Location = New System.Drawing.Point(520, 224)
        Me.txtTotalImpuesto.Name = "txtTotalImpuesto"
        Me.txtTotalImpuesto.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalImpuesto.TabIndex = 23
        Me.txtTotalImpuesto.Text = ""
        Me.txtTotalImpuesto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label10.Location = New System.Drawing.Point(520, 208)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Impuesto:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotalDescuento
        '
        Me.txtTotalDescuento.BackColor = System.Drawing.Color.White
        Me.txtTotalDescuento.Enabled = False
        Me.txtTotalDescuento.Location = New System.Drawing.Point(352, 224)
        Me.txtTotalDescuento.Name = "txtTotalDescuento"
        Me.txtTotalDescuento.Size = New System.Drawing.Size(120, 20)
        Me.txtTotalDescuento.TabIndex = 20
        Me.txtTotalDescuento.Text = ""
        Me.txtTotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(352, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Descuento:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDetalleSubTotal
        '
        Me.txtDetalleSubTotal.Enabled = False
        Me.txtDetalleSubTotal.Location = New System.Drawing.Point(176, 224)
        Me.txtDetalleSubTotal.Name = "txtDetalleSubTotal"
        Me.txtDetalleSubTotal.Size = New System.Drawing.Size(120, 20)
        Me.txtDetalleSubTotal.TabIndex = 17
        Me.txtDetalleSubTotal.Text = ""
        Me.txtDetalleSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label8.Location = New System.Drawing.Point(176, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Sub total:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDetalleDescuento
        '
        Me.txtDetalleDescuento.Location = New System.Drawing.Point(391, 32)
        Me.txtDetalleDescuento.Name = "txtDetalleDescuento"
        Me.txtDetalleDescuento.Size = New System.Drawing.Size(72, 20)
        Me.txtDetalleDescuento.TabIndex = 9
        Me.txtDetalleDescuento.Text = ""
        Me.txtDetalleDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetallePrecioUnidad
        '
        Me.txtDetallePrecioUnidad.Location = New System.Drawing.Point(230, 32)
        Me.txtDetallePrecioUnidad.Name = "txtDetallePrecioUnidad"
        Me.txtDetallePrecioUnidad.Size = New System.Drawing.Size(88, 20)
        Me.txtDetallePrecioUnidad.TabIndex = 5
        Me.txtDetallePrecioUnidad.Text = ""
        Me.txtDetallePrecioUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDetalleArticuloDescripcion
        '
        Me.txtDetalleArticuloDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalleArticuloDescripcion.Enabled = False
        Me.txtDetalleArticuloDescripcion.Location = New System.Drawing.Point(51, 32)
        Me.txtDetalleArticuloDescripcion.Name = "txtDetalleArticuloDescripcion"
        Me.txtDetalleArticuloDescripcion.Size = New System.Drawing.Size(176, 20)
        Me.txtDetalleArticuloDescripcion.TabIndex = 3
        Me.txtDetalleArticuloDescripcion.Text = ""
        '
        'txtDetalleCantidad
        '
        Me.txtDetalleCantidad.Location = New System.Drawing.Point(8, 32)
        Me.txtDetalleCantidad.Name = "txtDetalleCantidad"
        Me.txtDetalleCantidad.Size = New System.Drawing.Size(40, 20)
        Me.txtDetalleCantidad.TabIndex = 1
        Me.txtDetalleCantidad.Text = ""
        Me.txtDetalleCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label7.Location = New System.Drawing.Point(391, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Descuento"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label6.Location = New System.Drawing.Point(230, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Precio Unit."
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(51, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Descripción:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(8, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cant."
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gridDetalle
        '
        Me.gridDetalle.DataSource = Me.dtsGasto.GastoDetalle
        '
        'gridDetalle.EmbeddedNavigator
        '
        Me.gridDetalle.EmbeddedNavigator.Name = ""
        Me.gridDetalle.Location = New System.Drawing.Point(5, 88)
        Me.gridDetalle.MainView = Me.GridView1
        Me.gridDetalle.Name = "gridDetalle"
        Me.gridDetalle.Size = New System.Drawing.Size(947, 114)
        Me.gridDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.gridDetalle.TabIndex = 14
        Me.gridDetalle.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn8, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn9})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cantidad"
        Me.GridColumn1.FieldName = "Cantidad"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 50
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripcion"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Precio unidad"
        Me.GridColumn3.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "Costo"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 68
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "% Des"
        Me.GridColumn4.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Descuento_P"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 68
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "% Imp"
        Me.GridColumn8.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Impuesto_p"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn8.VisibleIndex = 4
        Me.GridColumn8.Width = 68
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Sub total"
        Me.GridColumn5.DisplayFormat.FormatString = "#,#0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Total"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 92
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Cuenta contable"
        Me.GridColumn6.FieldName = "CuentaContable"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 115
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Descripción"
        Me.GridColumn7.FieldName = "CuentaContableDescripcion"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 154
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "TipoCompra"
        Me.GridColumn9.FieldName = "DescTipoCompra"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Options = CType(((((DevExpress.XtraGrid.Columns.ColumnOptions.CanResized Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn9.VisibleIndex = 8
        Me.GridColumn9.Width = 168
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(816, 384)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(76, 13)
        Me.Label17.TabIndex = 122
        Me.Label17.Text = "Usuario->"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtClave
        '
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClave.ForeColor = System.Drawing.Color.Blue
        Me.txtClave.Location = New System.Drawing.Point(896, 384)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 13)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.ForeColor = System.Drawing.Color.Blue
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(816, 408)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(152, 13)
        Me.TxtNombreUsuario.TabIndex = 126
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'AdapterCentroCostoMovimiento
        '
        Me.AdapterCentroCostoMovimiento.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterCentroCostoMovimiento.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterCentroCostoMovimiento.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterCentroCostoMovimiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto_Movimientos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("IdAsiento", "IdAsiento"), New System.Data.Common.DataColumnMapping("Documento", "Documento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdCentroCosto", "IdCentroCosto"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuentaContable", "NombreCuentaContable"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("IdDetalle", "IdDetalle")})})
        Me.AdapterCentroCostoMovimiento.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM CentroCosto_Movimientos WHERE (Id = @Original_Id) AND (CuentaContable" & _
        " = @Original_CuentaContable) AND (Debe = @Original_Debe) AND (Descripcion = @Ori" & _
        "ginal_Descripcion OR @Original_Descripcion IS NULL AND Descripcion IS NULL) AND " & _
        "(Documento = @Original_Documento) AND (Fecha = @Original_Fecha) AND (Haber = @Or" & _
        "iginal_Haber) AND (IdAsiento = @Original_IdAsiento) AND (IdCentroCosto = @Origin" & _
        "al_IdCentroCosto) AND (IdDetalle = @Original_IdDetalle) AND (Monto = @Original_M" & _
        "onto) AND (NombreCuentaContable = @Original_NombreCuentaContable) AND (Tipo = @O" & _
        "riginal_Tipo)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCentroCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CentroCosto_Movimientos(IdAsiento, Documento, Fecha, IdCentroCosto, M" & _
        "onto, Debe, Haber, Descripcion, CuentaContable, NombreCuentaContable, Tipo, IdDe" & _
        "talle) VALUES (@IdAsiento, @Documento, @Fecha, @IdCentroCosto, @Monto, @Debe, @H" & _
        "aber, @Descripcion, @CuentaContable, @NombreCuentaContable, @Tipo, @IdDetalle); " & _
        "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descr" & _
        "ipcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_M" & _
        "ovimientos WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT Id, IdAsiento, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descri" & _
        "pcion, CuentaContable, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_Mo" & _
        "vimientos"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE CentroCosto_Movimientos SET IdAsiento = @IdAsiento, Documento = @Documento" & _
        ", Fecha = @Fecha, IdCentroCosto = @IdCentroCosto, Monto = @Monto, Debe = @Debe, " & _
        "Haber = @Haber, Descripcion = @Descripcion, CuentaContable = @CuentaContable, No" & _
        "mbreCuentaContable = @NombreCuentaContable, Tipo = @Tipo, IdDetalle = @IdDetalle" & _
        " WHERE (Id = @Original_Id) AND (CuentaContable = @Original_CuentaContable) AND (" & _
        "Debe = @Original_Debe) AND (Descripcion = @Original_Descripcion OR @Original_Des" & _
        "cripcion IS NULL AND Descripcion IS NULL) AND (Documento = @Original_Documento) " & _
        "AND (Fecha = @Original_Fecha) AND (Haber = @Original_Haber) AND (IdAsiento = @Or" & _
        "iginal_IdAsiento) AND (IdCentroCosto = @Original_IdCentroCosto) AND (IdDetalle =" & _
        " @Original_IdDetalle) AND (Monto = @Original_Monto) AND (NombreCuentaContable = " & _
        "@Original_NombreCuentaContable) AND (Tipo = @Original_Tipo); SELECT Id, IdAsient" & _
        "o, Documento, Fecha, IdCentroCosto, Monto, Debe, Haber, Descripcion, CuentaConta" & _
        "ble, NombreCuentaContable, Tipo, IdDetalle FROM CentroCosto_Movimientos WHERE (I" & _
        "d = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdAsiento", System.Data.SqlDbType.VarChar, 15, "IdAsiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Documento", System.Data.SqlDbType.VarChar, 50, "Documento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdCentroCosto", System.Data.SqlDbType.Int, 4, "IdCentroCosto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 100, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 200, "CuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, "NombreCuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.Int, 4, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdDetalle", System.Data.SqlDbType.BigInt, 8, "IdDetalle"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 200, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Documento", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Documento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdCentroCosto", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCentroCosto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdDetalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdDetalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuentaContable", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id"))
        '
        'AdapterCentroCosto
        '
        Me.AdapterCentroCosto.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterCentroCosto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, Codigo, Nombre FROM CentroCosto"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.DeleteCommand = Me.SqlDeleteCommand7
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand7
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand8
        Me.AdapterAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdapterAsientos.UpdateCommand = Me.SqlUpdateCommand7
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Origina" & _
        "l_Fecha) AND (FechaEntrada = @Original_FechaEntrada) AND (IdNumDoc = @Original_I" & _
        "dNumDoc) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo)" & _
        " AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) A" & _
        "ND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Obse" & _
        "rvaciones) AND (Periodo = @Original_Periodo) AND (TipoCambio = @Original_TipoCam" & _
        "bio) AND (TipoDoc = @Original_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND" & _
        " (TotalHaber = @Original_TotalHaber)"
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=IALVAREZ;packet size=4096;integrated security=SSPI;data source="".""" & _
        ";persist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, " & _
        "TipoDoc, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modu" & _
        "lo, Observaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio) " & _
        "VALUES (@NumAsiento, @Fecha, @IdNumDoc, @NumDoc, @Beneficiario, @TipoDoc, @Accio" & _
        "n, @Anulado, @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Obs" & _
        "ervaciones, @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio); S" & _
        "ELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulad" & _
        "o, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nomb" & _
        "reUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection3
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulad" & _
        "o, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nomb" & _
        "reUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM AsientosContables"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, IdNumDoc =" & _
        " @IdNumDoc, NumDoc = @NumDoc, Beneficiario = @Beneficiario, TipoDoc = @TipoDoc, " & _
        "Accion = @Accion, Anulado = @Anulado, FechaEntrada = @FechaEntrada, Mayorizado =" & _
        " @Mayorizado, Periodo = @Periodo, NumMayorizado = @NumMayorizado, Modulo = @Modu" & _
        "lo, Observaciones = @Observaciones, NombreUsuario = @NombreUsuario, TotalDebe = " & _
        "@TotalDebe, TotalHaber = @TotalHaber, CodMoneda = @CodMoneda, TipoCambio = @Tipo" & _
        "Cambio WHERE (NumAsiento = @Original_NumAsiento) AND (Accion = @Original_Accion)" & _
        " AND (Anulado = @Original_Anulado) AND (Beneficiario = @Original_Beneficiario) A" & _
        "ND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Original_Fecha) AND (FechaEnt" & _
        "rada = @Original_FechaEntrada) AND (IdNumDoc = @Original_IdNumDoc) AND (Mayoriza" & _
        "do = @Original_Mayorizado) AND (Modulo = @Original_Modulo) AND (NombreUsuario = " & _
        "@Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) AND (NumMayorizado = @O" & _
        "riginal_NumMayorizado) AND (Observaciones = @Original_Observaciones) AND (Period" & _
        "o = @Original_Periodo) AND (TipoCambio = @Original_TipoCambio) AND (TipoDoc = @O" & _
        "riginal_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND (TotalHaber = @Origin" & _
        "al_TotalHaber); SELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDo" & _
        "c, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Ob" & _
        "servaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM As" & _
        "ientosContables WHERE (NumAsiento = @NumAsiento)"
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand7.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdapterDetallesAsientos
        '
        Me.AdapterDetallesAsientos.DeleteCommand = Me.SqlDeleteCommand8
        Me.AdapterDetallesAsientos.InsertCommand = Me.SqlInsertCommand8
        Me.AdapterDetallesAsientos.SelectCommand = Me.SqlSelectCommand9
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand8
        '
        'SqlDeleteCommand8
        '
        Me.SqlDeleteCommand8.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (Tipocambio = @Original_Tipocambio OR @Original_Tipocambio" & _
        " IS NULL AND Tipocambio IS NULL)"
        Me.SqlDeleteCommand8.Connection = Me.SqlConnection3
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand8
        '
        Me.SqlInsertCommand8.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "pocambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand8.Connection = Me.SqlConnection3
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection3
        '
        'SqlUpdateCommand8
        '
        Me.SqlUpdateCommand8.CommandText = "UPDATE DetallesAsientosContable SET NumAsiento = @NumAsiento, Cuenta = @Cuenta, N" & _
        "ombreCuenta = @NombreCuenta, Monto = @Monto, Debe = @Debe, Haber = @Haber, Descr" & _
        "ipcionAsiento = @DescripcionAsiento, Tipocambio = @Tipocambio WHERE (ID_Detalle " & _
        "= @Original_ID_Detalle) AND (Cuenta = @Original_Cuenta) AND (Debe = @Original_De" & _
        "be) AND (DescripcionAsiento = @Original_DescripcionAsiento) AND (Haber = @Origin" & _
        "al_Haber) AND (Monto = @Original_Monto) AND (NombreCuenta = @Original_NombreCuen" & _
        "ta) AND (NumAsiento = @Original_NumAsiento) AND (Tipocambio = @Original_Tipocamb" & _
        "io OR @Original_Tipocambio IS NULL AND Tipocambio IS NULL); SELECT ID_Detalle, N" & _
        "umAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocam" & _
        "bio FROM DetallesAsientosContable WHERE (ID_Detalle = @ID_Detalle)"
        Me.SqlUpdateCommand8.Connection = Me.SqlConnection3
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand8.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle"))
        '
        'frmGasto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(976, 430)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Label46)
        Me.MaximizeBox = False
        Me.Name = "frmGasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de gastos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.PanelCentroCosto.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GridCentroCosto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsGasto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EditDescripcionCC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMontoCentroCosto.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones GUI"
    Public Identificador As Decimal
    Private Sub frmGasto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        SqlConnection3.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        Cargar()
        ValoresDefecto()
        AdapterCentroCosto.Fill(dtsGasto, "CentroCosto")
        dtpFecha.Value = Now.Date
        If ValidarUsuario() = False Then
            Me.DesactivarCabezera()
            DesactivarToolBar()
            MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
            Me.txtClave.Text = ""
        Else
            Me.tlbNuevo.Enabled = True
            Me.tlbBuscar.Enabled = True
            Nuevo()
        End If
        Buscar(Identificador)
    End Sub

    Private Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA CENTROS DE COSTO MOVIMIENTOS
        dtsGasto.CentroCosto_Movimientos.IdColumn.AutoIncrement = True
        dtsGasto.CentroCosto_Movimientos.IdColumn.AutoIncrementSeed = -1
        dtsGasto.CentroCosto_Movimientos.IdColumn.AutoIncrementStep = -1
        dtsGasto.CentroCosto_Movimientos.IdAsientoColumn.DefaultValue = ""
        dtsGasto.CentroCosto_Movimientos.DocumentoColumn.DefaultValue = ""
        dtsGasto.CentroCosto_Movimientos.FechaColumn.DefaultValue = Now.Date
        dtsGasto.CentroCosto_Movimientos.IdCentroCostoColumn.DefaultValue = 0
        dtsGasto.CentroCosto_Movimientos.MontoColumn.DefaultValue = 0
        dtsGasto.CentroCosto_Movimientos.DebeColumn.DefaultValue = 0
        dtsGasto.CentroCosto_Movimientos.HaberColumn.DefaultValue = 0
        dtsGasto.CentroCosto_Movimientos.DescripcionColumn.DefaultValue = ""
        dtsGasto.CentroCosto_Movimientos.CuentaContableColumn.DefaultValue = ""
        dtsGasto.CentroCosto_Movimientos.NombreCuentaContableColumn.DefaultValue = ""
        dtsGasto.CentroCosto_Movimientos.TipoColumn.DefaultValue = 13
        dtsGasto.CentroCosto_Movimientos.IdDetalleColumn.DefaultValue = 0
    End Sub

    Private Sub gridDetalle_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gridDetalle.KeyDown
        If e.KeyCode = Keys.Delete Then
            EliminarDetalle()
        End If

        If e.KeyCode = Keys.F1 Then
            If GridView1.FocusedColumn.Caption = "Cuenta contable" Then
                Dim busca As New fmrBuscarMayorizacionAsiento
                busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
                busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
                " where Movimiento=1 "
                busca.campo = "descripcion"
                busca.sqlStringAdicional = " ORDER BY CuentaContable  "
                busca.ShowDialog()

                If busca.codigo Is Nothing Then Exit Sub

                Me.dtsGasto.GastoDetalle(GridView1.FocusedRowHandle).CuentaContable = busca.codigo
                Me.dtsGasto.GastoDetalle(GridView1.FocusedRowHandle).CuentaContableDescripcion = busca.descrip
            End If
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()
            Case 1 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 2 : If PMU.Update Then AgregarEncabezadoBD() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 3 : If PMU.Delete Then EliminarBD() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 4 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
            Case 8 : Me.CalcularTotales()
            Case 10 : Me.Close()
        End Select
    End Sub


    Private Sub cmbMoneda_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMoneda.SelectedIndexChanged
        If Me.cmbMoneda.SelectedIndex = -1 Then Exit Sub
        ObtenerFormatoMoneda(IdMoneda(Me.cmbMoneda.SelectedIndex))
    End Sub

#Region "Funciones KeyDown"

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarUsuario() = False Then
                Me.DesactivarCabezera()
                DesactivarToolBar()
                MsgBox("Contraseña incorrecta", MsgBoxStyle.Information)
                Me.txtClave.Text = ""
            Else
                Me.tlbNuevo.Enabled = True
                Me.tlbBuscar.Enabled = True
                Nuevo()
            End If

        End If
    End Sub

    Private Sub txtNumeroFactura_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNumeroFactura.KeyDown
        If Me.cmbProveedor.SelectedIndex = -1 Then
            MsgBox("Elija primero el proveedor", MsgBoxStyle.Information)
            Me.txtNumeroFactura.Text = ""
            cmbProveedor.Focus()
            Exit Sub
        End If
        If e.KeyCode = Keys.Enter Then
            If txtNumeroFactura.Text = "" Then Exit Sub
            If ValidarFactura() = False Then
                MsgBox("El número de factura ya existe", MsgBoxStyle.Information)
                txtNumeroFactura.Text = ""
                txtNumeroFactura.Focus()
                Exit Sub
            End If
            SendKeys.Send("{TAB}")
        End If

    End Sub

    Private Sub dtpFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbTipo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cmbProveedor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        End If
        If e.KeyCode = Keys.F1 Then
            Dim Fx As New cFunciones
            Dim valor As String
            valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...",Configuracion.Claves.Conexion("Proveeduria"))

            If valor = "" Then
                Me.cmbProveedor.SelectedIndex = -1
            Else
                Me.BuscarProveedor(valor)

            End If
        End If
    End Sub

    Private Sub cmbMoneda_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbMoneda.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarCabezera() = True Then
                ActivarDetalle()
                Me.txtDetalleCantidad.Focus()
            End If

        End If
    End Sub
    Private Sub txtCantidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetalleCantidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescripcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetalleArticuloDescripcion.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtPrecioUnidad_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetallePrecioUnidad.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtDescuento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDetalleDescuento.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtImpuesto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtImpuesto.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtCuentaContable_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable(txtCuentaContable.Text)
            cbTipoOperacion.Focus()
        End If

        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
    End Sub

    Private Sub cbTipoOperacion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub cbTipoOperacion_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbTipoOperacion.KeyDown
        If e.KeyCode = Keys.Enter Then
            If ValidarDetalle() = True Then
                AgregarDetalle()
                CalcularTotales()
                LimpiarDetalle()
                txtDetalleCantidad.Focus()
                IdDetalle = -1
            End If
        End If
    End Sub
#End Region

#End Region

#Region "Funciones Basicas"

    Private Sub AgregarDetalle()
        Dim Descuento, PrecioUnidad, TotalImpuesto As Double
        Dim Cantidad As Double
        Descuento = txtDetalleDescuento.Text
        Cantidad = txtDetalleCantidad.Text
        PrecioUnidad = txtDetallePrecioUnidad.Text
        impuesto = txtImpuesto.Text
        Dim Cx As New Conexion
        Dim NuevaFila As DatasetGasto.GastoDetalleRow
        NuevaFila = dtsGasto.GastoDetalle.NewGastoDetalleRow
        NuevaFila.Cantidad = txtDetalleCantidad.Text
        NuevaFila.IdDetalle = ((dtsGasto.GastoDetalle.Count) + 1 * -1)
        NuevaFila.IdCompra = -1
        NuevaFila.Descuento = (Descuento / 100) * (PrecioUnidad * Cantidad)
        NuevaFila.Impuesto = (impuesto / 100) * ((PrecioUnidad * Cantidad) - NuevaFila.Descuento)
        NuevaFila.Impuesto_p = impuesto
        NuevaFila.Total = (PrecioUnidad * Cantidad) - NuevaFila.Descuento
        NuevaFila.CuentaContable = txtCuentaContable.Text
        NuevaFila.Descripcion = txtDetalleArticuloDescripcion.Text
        NuevaFila.CuentaContableDescripcion = txtCuentaContableDescripcion.Text
        NuevaFila.Descuento_P = Descuento
        If impuesto = 0 Then
            NuevaFila.Gravado = 0
            NuevaFila.Exento = NuevaFila.Total
        Else
            NuevaFila.Gravado = NuevaFila.Total
            NuevaFila.Exento = 0
        End If
        NuevaFila.Costo = txtDetallePrecioUnidad.Text
        NuevaFila.NuevoCostoBase = NuevaFila.Total / Cantidad
        CodOperacion = Cx.SlqExecuteScalar(Cx.Conectar("Proveeduria"), "Select Codigo from TipoCompra where Descripcion ='" & cbTipoOperacion.Text & "'")
        Cx.DesConectar(Cx.sQlconexion)
        NuevaFila.CodTipoCompra = CodOperacion
        NuevaFila.DescTipoCompra = cbTipoOperacion.Text
        dtsGasto.GastoDetalle.AddGastoDetalleRow(NuevaFila)
    End Sub

    Private Sub EliminarDetalle()
        If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        Dim posicion As Integer
        If Me.dtsGasto.GastoDetalle.Count = 0 Then Exit Sub
        posicion = Me.BindingContext(dtsGasto.GastoDetalle).Position()
        EliminaCentro(BindingContext(dtsGasto.GastoDetalle).Current("IdDetalle"))
        dtsGasto.GastoDetalle.Rows.RemoveAt(posicion)
        CalcularTotales()
    End Sub

    Private Sub BuscarEncabezado(ByVal pIdGasto As Double)

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader


        sql = "SELECT Factura,CodigoProv,Fecha,TipoCompra,Cod_MonedaCompra,Asiento FROM Proveeduria.dbo.Compras  WHERE ID_Compra = " & pIdGasto

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Sub
        NumAsiento = rsReader("Asiento")
        txtNumeroFactura.Text = rsReader("Factura")
        dtpFecha.Value = rsReader("Fecha")
        If rsReader("TipoCompra") = "CON" Then
            cmbTipo.SelectedIndex = 0
        Else
            cmbTipo.SelectedIndex = 1
        End If
        BuscarProveedor(rsReader("CodigoProv"))
        BuscarMoneda(rsReader("Cod_MonedaCompra"))
        ObtenerFormatoMoneda(rsReader("Cod_MonedaCompra"))

        cnnConexion.Close()
        CargarGridDetalle(pIdGasto)
        CalcularTotales()
        CargarCentroCosto(pIdGasto)
    End Sub

    Private Sub BuscarProveedor(ByVal pIdProveedor)
        Dim n As Integer


        For n = 0 To cmbProveedor.Items.Count - 1
            If idProveedor(n) = pIdProveedor Then
                Me.cmbProveedor.SelectedIndex = n
            End If
        Next

    End Sub

    Private Sub BuscarMoneda(ByVal pIdMoneda)
        Dim n As Integer


        For n = 0 To cmbMoneda.Items.Count - 1
            If IdMoneda(n) = pIdMoneda Then
                Me.cmbMoneda.SelectedIndex = n
            End If
        Next

    End Sub

    Private Function BuscarTipoCambio(ByVal pIdMoneda As Double) As Double

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader

        BuscarTipoCambio = 1
        sql = "SELECT ValorCompra FROM Proveeduria.dbo.Moneda  WHERE CodMoneda = " & pIdMoneda

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Function

        BuscarTipoCambio = rsReader("ValorCompra")

        cnnConexion.Close()


    End Function

    Private Sub AgregarEncabezadoBD()

        If Me.dtsGasto.GastoDetalle.Count = 0 Then
            MsgBox("No se llenaron los item del gasto, no se pude registrar el gasto", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Contabilidad From configuraciones ", dt, Configuracion.Claves.Conexion("Hotel"))
        Conta = dt.Rows(0).Item("Contabilidad")

        'If ValidarModificarElimar() = False Then
        '    MsgBox("No se puede modificar la factura")
        '    Exit Sub
        'End If

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim Grabado, exento, TotalImpuesto, TotalDescuento, Total As Double
        Dim FechaVence As Date
        Dim Plazo As Double
        Dim Cx As New Conexion
        Dim n As Integer
        Dim Fx As New cFunciones
        TotalImpuesto = txtTotalImpuesto.Text
        Total = txtTotal.Text
        TotalDescuento = txtTotalDescuento.Text

        If Fx.ValidarPeriodo(Convert.ToDateTime(dtpFecha.Value)) = False Then
            MsgBox("La fecha del asiento NO corresponde al periodo de trabajo! O el periodo esta cerrado!" & vbCrLf & "No se puede Generar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
            Exit Sub
        End If

        For n = 0 To dtsGasto.GastoDetalle.Count - 1
            With dtsGasto.GastoDetalle(n)
                Grabado = Grabado + .Gravado
                exento = exento + .Exento
            End With
        Next

        Dim TipoFactura(2) As String
        TipoFactura(0) = "CON"
        TipoFactura(1) = "CRE"
        Plazo = Cx.SlqExecuteScalar(Cx.Conectar("Proveeduria"), "SELECT Plazo FROM Proveedores WHERE CodigoProv = " & idProveedor.GetValue(cmbProveedor.SelectedIndex))
        Cx.DesConectar(Cx.sQlconexion)
        FechaVence = dtpFecha.Value.Date.AddDays(Plazo)
        BanderaGeneral.ACTUALIZO_ASIENTO = True
        BanderaGeneral.ACTUALIZO_ASIENTO2 = True
        If IdGasto = -1 Then
            sql = " INSERT INTO Compras (Factura,CodigoProv,SubTotalGravado,SubTotalExento,Descuento,Impuesto" & _
                " ,TotalFactura, Fecha,Vence,FechaIngreso,Gasto,TipoCompra,Cod_MonedaCompra,TipoCambio) " & _
                " VALUES (" & txtNumeroFactura.Text & "," & idProveedor(cmbProveedor.SelectedIndex) & "," & _
                Grabado & "," & exento & "," & TotalDescuento & "," & _
                TotalImpuesto & "," & Total & ",'" & dtpFecha.Value.Date & "','" & _
                FechaVence & "','" & Date.Now.Date & "',1,'" & TipoFactura(cmbTipo.SelectedIndex) & "'," & IdMoneda(cmbMoneda.SelectedIndex) & "," & BuscarTipoCambio(IdMoneda(cmbMoneda.SelectedIndex)) & ")"
        Else
            Dim FactCanc As Integer
            If cmbTipo.SelectedIndex = 0 Then
                FactCanc = 1
            Else
                FactCanc = 0
            End If

            'Dim asi As String = GetNumasiento(Me.IdGasto)
            'If EstaMayorizado(asi) = True Then
            '    MsgBox("La operacion no se puede realizar", MsgBoxStyle.Exclamation, "El Asiento esta Mayorizado")
            '    Exit Sub
            'End If

            sql = "UPDATE Compras SET Factura =" & txtNumeroFactura.Text & ",CodigoProv=" & idProveedor(Me.cmbProveedor.SelectedIndex) & "," & _
                    "SubTotalGravado=" & Grabado & ",SubTotalExento=" & exento & ",Descuento=" & TotalDescuento & "," & _
                    "Impuesto =" & TotalImpuesto & ", TotalFactura=" & Total & ",Fecha ='" & dtpFecha.Value.Date & "'," & _
                    "Vence = '" & FechaVence & "', FechaIngreso='" & dtpFecha.Value.Date & "'" & _
                    ",TipoCompra='" & TipoFactura(cmbTipo.SelectedIndex) & "', FacturaCancelado =" & FactCanc & ",Cod_MonedaCompra=" & IdMoneda(cmbMoneda.SelectedIndex) & ", TipoCambio = " & BuscarTipoCambio(IdMoneda(cmbMoneda.SelectedIndex)) & "  WHERE ID_Compra =" & IdGasto
            '                    ", NombreOperacion ='" & cbTipoOperacion.Text & "'" & _
        End If

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()
        clsConexion.SlqExecute(cnnConexion, sql)

        If IdGasto = -1 Then
            sql = "Select max(id_compra) from compras where Factura = " & Me.txtNumeroFactura.Text & " and codigoprov = " & idProveedor(Me.cmbProveedor.SelectedIndex) & " and gasto = 1"
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            rstReader.Read()
            IdGasto = rstReader(0)
        End If

        cnnConexion.Close()
        ActualizaIDCentro(IdGasto)
        AgregarDetalleBD(IdGasto)

        'If Conta = 1 Then 'SI EL SISTEMA PERMITE LA GENERACION (En caso de conta tiene que hacerlo siempre asi)

        GuardaAsiento()

        If TransAsiento() = False Then
            MsgBox("Error en la Generación del Centro Costo!", MsgBoxStyle.Critical)
            Exit Sub
        Else
            dtsGasto.CentroCosto_Movimientos.AcceptChanges()
            dtsGasto.CentroCosto_Movimientos.Clear()
            TotalCentro = 0
        End If
        ' End If


        MsgBox("La factura de gasto ha sido registrado correctamente", MsgBoxStyle.Information)

        tlbNuevo.Enabled = True
        tlbBuscar.Enabled = True
        tlbRegistrar.Enabled = True
        tlbEliminar.Enabled = True
        tlbImprimir.Enabled = True
        EditaCentro = False

        LimpiarCabezera()
        ActivarCabezera()
        DesactivarDetalle()
        dtsGasto.GastoDetalle.Clear()
        dtsGasto.CentroCostoDetalle.Clear()
    End Sub

    Private Function ExisteAsiento(ByVal _asiento As String) As Boolean
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from asientoscontables where numasiento = '" & _asiento & "'", dts, Configuracion.Claves.Conexion("Contabilidad"))
            If dts.Rows.Count > 0 Then
                Me.nummayorizado = dts.Rows(0).Item("nummayorizado")
                Me.tipo_cambio = dts.Rows(0).Item("tipocambio")
                Me.mayorizado = True
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function GetNumasiento(ByVal _id As Long) As String
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select asiento from compras where gasto = 1 and id_compra = " & _id, dts,Configuracion.Claves.Conexion("Proveeduria"))
            If dts.Rows.Count > 0 Then
                Return dts.Rows(0).Item(0)
            Else
                Return "0"
            End If
        Catch ex As Exception
            Return "0"
        End Try
    End Function

    Private Function EstaMayorizado(ByVal _asiento As String) As Boolean
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("select mayorizado from asientoscontables where numasiento = '" & _asiento & "'", dts, Configuracion.Claves.Conexion("Contabilidad"))
            If dts.Rows.Count > 0 Then
                If dts.Rows(0).Item(0) = True Then
                    Return True
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub AgregarDetalleBD(ByVal pIdGasto As Double)
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer


        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        sql = "DELETE FROM Articulos_Gastos WHERE IDCOMPRA = " & pIdGasto
        clsConexion.SlqExecute(cnnConexion, sql)


        For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            With dtsGasto.GastoDetalle(n)
                sql = "INSERT INTO Articulos_Gastos(IdCompra,Descripcion,Base,Costo,Cantidad,Gravado,Exento," & _
                        "Descuento_p,Descuento,Impuesto_p,Impuesto,Total,NuevoCostoBase,CuentaContable, CodTipoCompra, DescTipoCompra)" & _
                        " VALUES(" & pIdGasto & ",'" & .Descripcion & _
                        "'," & .Costo & "," & .Costo & "," & .Cantidad & "," & .Gravado & "," & .Exento & _
                        "," & .Descuento_P & "," & .Descuento & "," & .Impuesto_p & "," & .Impuesto & _
                        "," & .Total & "," & .NuevoCostoBase & ",'" & .CuentaContable & "'," & .CodTipoCompra & ",'" & .DescTipoCompra & "')"
                clsConexion.SlqExecute(cnnConexion, sql)
            End With
        Next
        cnnConexion.Close()

    End Sub

    Private Sub EliminarBD()
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim n As Integer

        If IdGasto = -1 Then Exit Sub
        If ValidarModificarElimar() = False Then
            MsgBox("No se puede eliminar la factura")
            Exit Sub
        End If

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()


        If MessageBox.Show("¿Desea eliminar esta Factura de gasto ?", "Proveeduria", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = 6 Then

            Me.eliminarAnteriorAsiento()
            'Elimnar los detalles
            sql = "Delete from Articulos_Gastos where IdCompra=" & IdGasto
            clsConexion.SlqExecute(cnnConexion, sql)

            'Eliminar la cabezara
            sql = "DELETE FROM  Compras where id_compra =" & IdGasto
            clsConexion.SlqExecute(cnnConexion, sql)

            Dim Funcion As New Conexion
            Funcion.DeleteRecords("CentroCosto_Movimientos", "Tipo = 13 AND Documento = " & IdGasto)

            cnnConexion.Close()

            Me.tlbNuevo.Enabled = True
            Me.tlbBuscar.Enabled = True
            Me.tlbRegistrar.Enabled = False
            Me.tlbEliminar.Enabled = False
            Me.tlbImprimir.Enabled = False

            Me.LimpiarCabezera()
            Me.DesactivarCabezera()
        End If
    End Sub

    Private Sub Nuevo()
        Try

            Me.dtsGasto.GastoDetalle.Clear()
            If Me.ToolBar1.Buttons(0).Text = "Nuevo" Then
                Me.ToolBar1.Buttons(0).Text = "Cancelar"
                Me.ToolBar1.Buttons(0).ImageIndex = 8
                Me.LimpiarCabezera()
                Me.ActivarCabezera()
                Me.DesactivarDetalle()

                Me.tlbNuevo.Enabled = True
                Me.tlbBuscar.Enabled = True
                Me.tlbRegistrar.Enabled = True
                Me.tlbEliminar.Enabled = False
                Me.tlbImprimir.Enabled = False
                Me.cmbProveedor.Focus()
            Else
                Me.ToolBar1.Buttons(0).Text = "Nuevo"
                Me.ToolBar1.Buttons(0).ImageIndex = 0
                Me.LimpiarCabezera()
                Me.DesactivarCabezera()

                Me.tlbNuevo.Enabled = True
                Me.tlbBuscar.Enabled = True
                Me.tlbRegistrar.Enabled = False
                Me.tlbEliminar.Enabled = False
                Me.tlbImprimir.Enabled = False
            End If



        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Buscar(Optional ByVal identificador As Double = 0.0)
        'Me.LimpiarCabezera()
        'Me.dtsGasto.GastoDetalle.Clear()
        Try

            '    Dim identificador As Double
            '    Dim Fx As New cFunciones
            '    identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select Id_Compra, (cast(cast(Factura as decimal) as varchar) + '-' + TipoCompra) as Factura,Proveedores.nombre,Fecha from compras inner join Proveedores on compras.CodigoProv = Proveedores.CodigoProv WHERE Compras.Gasto = 1 Order by Fecha DESC", "nombre", "Fecha", "Buscar Factura de Compra",Configuracion.Claves.Conexion("Proveeduria")))


            If identificador = 0.0 Then ' si se dio en el boton de cancelar
                IdGasto = -1
                Exit Sub
            End If
            IdGasto = identificador

            'llenar las compras
            BuscarEncabezado(IdGasto)

            ToolBar1.Buttons(2).Enabled = True
            ToolBar1.Buttons(3).Enabled = True
            ToolBar1.Buttons(4).Enabled = True


        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try


        tlbNuevo.Enabled = True
        tlbBuscar.Enabled = True
        tlbRegistrar.Enabled = True
        tlbEliminar.Enabled = True
        tlbImprimir.Enabled = True

        ActivarCabezera()
        ActivarDetalle()

    End Sub

    Private Sub Imprimir()
        If IdGasto = -1 Then Exit Sub

        Try
            Dim rptReporte As New rptGasto2
            rptReporte.SetParameterValue(0, IdGasto)
            CrystalReportsConexion.LoadShow(rptReporte, MdiParent,Configuracion.Claves.Conexion("Proveeduria"))

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EditarDetalle()
        If IdDetalle = -1 Then Exit Sub
        impuesto = Me.txtImpuesto.Text
        With Me.dtsGasto.GastoDetalle(IdDetalle)
            Dim Descuento, PrecioUnidad, TotalImpuesto As Double
            Dim Cantidad As Integer
            .Cantidad = Me.txtDetalleCantidad.Text
            .IdCompra = -1
            .Descuento = (Descuento / 100) * (PrecioUnidad * Cantidad)
            .Impuesto = (impuesto / 100) * ((PrecioUnidad * Cantidad) - .Descuento)
            .Impuesto_p = impuesto
            .Total = (PrecioUnidad * Cantidad) - .Descuento + .Impuesto
            .CuentaContable = Me.txtCuentaContable.Text
            .Descripcion = Me.txtDetalleArticuloDescripcion.Text
            .CuentaContableDescripcion = Me.txtCuentaContableDescripcion.Text
            .Descuento_P = Me.txtDetalleDescuento.Text

            If impuesto = 0 Then
                .Gravado = 0
                .Exento = .Total
            Else
                .Gravado = .Total
                .Exento = 0
            End If

            .Costo = Me.txtDetallePrecioUnidad.Text
            .NuevoCostoBase = .Total / Cantidad
        End With
        CalcularTotales()
    End Sub

    Private Sub BuscarCuentaContable(ByVal cuenta As String)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT descripcion, DescTipoCompra  FROM CuentaContable where CuentaContable = '" & cuenta & "' "

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then
            txtCuentaContable.Text = ""
            txtCuentaContableDescripcion.Text = ""
            Exit Sub
        End If

        txtCuentaContableDescripcion.Text = rstReader(0)
        cbTipoOperacion.Text = rstReader(1)

        cnnConexion.Close()
    End Sub

    Private Sub LlamarFmrBuscarAsientoVenta()

        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1"
        busca.campo = "descripcion"
        busca.sqlStringAdicional = " ORDER BY CuentaContable  "
        busca.ShowDialog()
        If busca.codigo Is Nothing Then Exit Sub
        txtCuentaContable.Text = busca.codigo
        txtCuentaContableDescripcion.Text = busca.descrip
    End Sub

    Private Sub ObtenerFormatoMoneda(ByVal pIdMoneda)

        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        sql = "SELECT Simbolo FROM Moneda where CodMoneda =" & pIdMoneda
        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Sub

        lblMoneda1.Text = rstReader("Simbolo")
        lblMoneda2.Text = rstReader("Simbolo")
        lblMoneda3.Text = rstReader("Simbolo")
        lblMoneda4.Text = rstReader("Simbolo")
        cnnConexion.Close()

    End Sub
#End Region

#Region "Funciones Validar"

    Private Function ValidarFactura() As Boolean
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion = clsConexion.Conectar("Proveeduria")
        Dim sepuede As Boolean = False
        sql = " SELECT COUNT(*) FROM Compras where factura = " & Me.txtNumeroFactura.Text & " AND CodigoProv=" & idProveedor(cmbProveedor.SelectedIndex)

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Return False
        If rstReader(0) = 0 Then
            sepuede = True
        Else
            sepuede = False
        End If
        clsConexion.DesConectar(cnnConexion)
        'Dim dtAsiento As New DataTable

        'Dim sumaTareas As Double

        'cFunciones.Llenar_Tabla_Generico("SELECT Mayorizado, NumAsiento FROM AsientosContables WHERE NumAsiento = '" & Me.NumAsiento & "'", dtAsiento, Configuracion.Claves.Conexion("Contabilidad"))
        'If dtAsiento.Rows.Count > 0 Then
        '    sepuede = (sepuede And dtAsiento.Rows(0).Item(0))

        'End If
        Return sepuede
    End Function


    Private Function ValidarCabezera() As Boolean

        If Me.txtNumeroFactura.Text = "" Then
            MensajeError(txtNumeroFactura, "No se han completado los datos de la cabezera")
            Exit Function
        End If

        If Me.cmbTipo.SelectedIndex = -1 Then
            MensajeError(cmbTipo, "No se han completado los datos de la cabezera")
            Exit Function
        End If

        If Me.cmbProveedor.SelectedIndex = -1 Then
            MensajeError(cmbProveedor, "No se han completado los datos de la cabezera")
            Exit Function
        End If

        If Me.cmbMoneda.SelectedIndex = -1 Then
            MensajeError(cmbMoneda, "No se han completado los datos de la cabezera")
            Exit Function
        End If
        ValidarCabezera = True

    End Function

    Private Function ValidarDetalle() As Boolean

        If Me.txtDetalleCantidad.Text = "" Then
            MensajeError(txtDetalleCantidad, "No se han completado los datos del detalle")
            Exit Function
        End If


        If Me.txtDetalleArticuloDescripcion.Text = "" Then
            MensajeError(txtDetalleArticuloDescripcion, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtDetallePrecioUnidad.Text = "" Then
            MensajeError(txtDetallePrecioUnidad, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtDetalleDescuento.Text = "" Then
            MensajeError(txtDetalleDescuento, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtImpuesto.Text = "" Then
            MensajeError(txtImpuesto, "No se han completado los datos del detalle")
            Exit Function
        End If

        If Me.txtCuentaContable.Text = "" Then
            MensajeError(txtCuentaContable, "No se han completado los datos del detalle")
            Exit Function
        End If

        ValidarDetalle = True
    End Function

    Private Sub MensajeError(ByVal pObjeto As Object, ByVal pMensaje As String)
        MsgBox(pMensaje, MsgBoxStyle.Information)
        pObjeto.focus()
    End Sub

    Private Function ValidarUsuario() As Boolean
        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rsReader As SqlClient.SqlDataReader


        sql = "SELECT Nombre FROM USUARIOS WHERE ID_USUARIO ='" & Usua.Cedula & "'"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Seguridad")
        cnnConexion.Open()
        rsReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rsReader.Read() = False Then Exit Function

        Me.TxtNombreUsuario.Text = rsReader(0)

        cnnConexion.Close()

        ValidarUsuario = True
    End Function

    Private Function ValidarModificarElimar() As Boolean

        If IdGasto = -1 Then
            Return True
        End If

        Dim sql As String
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()
        sql = " select Contabilizado, Asiento from compras where (Contabilizado = 1 or facturacancelado = 1  " & _
        " ) AND ID_compra = " & IdGasto

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        If rstReader.Read() = False Then Return True
        Dim Contabilizado As Boolean = rstReader("Contabilizado")
        Dim asiento As String = rstReader("Asiento")
        rstReader.Close()

        'Si son asientos agrupados
        If Conta = 0 Then
            If Contabilizado = True Then
                Return False
            End If
        End If

        'SI ES ASIENTO ESTA MAYORIZADO
        Dim dtA As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Mayorizado From AsientosContables Where NumAsiento = '" & asiento & "'", dtA, Configuracion.Claves.Conexion("Contabilidad"))
        If dtA.Rows.Count > 0 Then
            Return Not dtA.Rows(0).Item(0)

        Else
            Return True

        End If

    End Function


#End Region

#Region "Funciones Calculos"

    Private Sub CalcularTotales()
        Dim n As Integer = 0
        Dim subtotal, descuento, impuesto As Double

        For n = 0 To Me.dtsGasto.GastoDetalle.Count - 1
            With dtsGasto.GastoDetalle(n)
                impuesto = .Impuesto + impuesto
                descuento = .Descuento + descuento
                subtotal = (.Cantidad * .Costo) + subtotal

            End With
        Next
        Me.txtTotalDescuento.Text = Format(descuento, "###,##0.00")
        Me.txtTotalImpuesto.Text = Format(impuesto, "###,##0.00")
        Me.txtDetalleSubTotal.Text = Format(subtotal, "###,##0.00")
        Me.txtTotal.Text = Format(subtotal - descuento + impuesto, "###,##0.00")
    End Sub

#End Region

#Region "Funciones Cargar"

    Private Sub ActivarCabezera()
        txtNumeroFactura.Enabled = True
        dtpFecha.Enabled = True
        cmbTipo.Enabled = True
        cmbProveedor.Enabled = True
        cbTipoOperacion.Enabled = True
        cmbMoneda.Enabled = True
    End Sub

    Private Sub DesactivarCabezera()
        txtNumeroFactura.Enabled = False
        dtpFecha.Enabled = False
        cmbTipo.Enabled = False
        cmbProveedor.Enabled = False
        cbTipoOperacion.Enabled = False
        cmbMoneda.Enabled = False
        DesactivarDetalle()
    End Sub

    Private Sub ActivarDetalle()
        txtDetalleCantidad.Enabled = True
        txtDetalleArticuloDescripcion.Enabled = True
        txtDetallePrecioUnidad.Enabled = True
        txtDetalleDescuento.Enabled = True
        txtCuentaContable.Enabled = True
        txtImpuesto.Enabled = True
        BCentroCosto.Enabled = True
    End Sub

    Private Sub DesactivarDetalle()
        txtDetalleCantidad.Enabled = False
        txtDetalleArticuloDescripcion.Enabled = False
        txtDetallePrecioUnidad.Enabled = False
        txtDetalleDescuento.Enabled = False
        txtCuentaContable.Enabled = False
        txtImpuesto.Enabled = False
        BCentroCosto.Enabled = False
    End Sub

    Private Sub LimpiarCabezera()
        IdGasto = -1
        cmbProveedor.SelectedIndex = -1
        cbTipoOperacion.SelectedIndex = -1
        cmbTipo.SelectedIndex = -1
        cmbMoneda.SelectedIndex = -1
        txtNumeroFactura.Text = ""
        dtpFecha.Value = Date.Now
        txtDetalleSubTotal.Text = "0"
        txtTotal.Text = Format(0, "###,##0.00")
        txtTotalDescuento.Text = Format(0, "###,##0.00")
        txtTotalImpuesto.Text = Format(0, "###,##0.00")
        lblMoneda1.Text = ""
        lblMoneda2.Text = ""
        lblMoneda3.Text = ""
        lblMoneda4.Text = ""
        NumAsiento = ""
        LimpiarDetalle()
    End Sub

    Private Sub LimpiarDetalle()
        txtDetalleCantidad.Text = "1" : txtDetalleArticuloDescripcion.Text = ""
        txtDetallePrecioUnidad.Text = "0" : txtDetalleDescuento.Text = "0"
        txtCuentaContable.Text = "" : txtDetalleArticuloDescripcion.Text = ""
        txtCuentaContableDescripcion.Text = "" : txtImpuesto.Text = "13"
        cbTipoOperacion.Text = ""
    End Sub

    Private Sub DesactivarToolBar()
        tlbNuevo.Enabled = False
        tlbImprimir.Enabled = False
        tlbEliminar.Enabled = False
        tlbBuscar.Enabled = False
    End Sub

    Private Sub CargarTxtDetalle()

        If Me.dtsGasto.GastoDetalle.Count = 0 Then Exit Sub
        IdDetalle = Me.BindingContext(dtsGasto.GastoDetalle).Position()

        With dtsGasto.GastoDetalle(IdDetalle)
            Me.txtCuentaContable.Text = .CuentaContable
            Me.txtCuentaContableDescripcion.Text = .CuentaContableDescripcion
            Me.txtDetalleCantidad.Text = .Descuento_P
            impuesto = .Impuesto_p
            Me.txtImpuesto.Text = .Impuesto_p
            Me.txtDetalleArticuloDescripcion.Text = .Descripcion

        End With
    End Sub

    Private Sub CargarGridDetalle(ByVal pIdGasto)
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim sql As String
        Dim n As Integer


        sql = " SELECT  A.Id_ArticuloComprados AS IdDetalle, A.Cantidad,A.IdCompra,A.Gravado, " & _
" A.Exento,A.Descuento,A.Impuesto,A.Total,A.CuentaContable, " & _
" A.Impuesto_p,A.NuevoCostoBase,A.Costo,A.CodTipoCompra, A.DescTipoCompra, A.Descuento_P ,A.Descripcion, " & _
" c.Descripcion as CuentaContableDescripcion " & _
" from Articulos_Gastos A, Contabilidad.dbo.cuentacontable C " & _
" WHERE  " & _
" C.cuentacontable  COLLATE Traditional_Spanish_CI_AS  = a.cuentacontable " & _
" and idcompra = " & pIdGasto

        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        Me.dtsGasto.GastoDetalle.Clear()
        sqlCommand.Connection = cnnConexion
        sqlCommand.CommandText = sql
        adpAdapter.SelectCommand = sqlCommand
        adpAdapter.Fill(dtsGasto, "GastoDetalle")
    End Sub

#Region "FuncionesLLenar"

    Private Sub Cargar()
        DesactivarCabezera()
        LlenarCmbProveedor()
        LlenarCbTipoOperacion()
        LlenarCmbMoneda()
        LimpiarCabezera()
    End Sub

    Private Sub LlenarCmbProveedor()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer
        sql = "SELECT CodigoProv,Nombre FROM Proveedores ORDER BY Nombre"
        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        n = 0
        Do While rstReader.Read
            cmbProveedor.Items.Add(rstReader("Nombre"))
            ReDim Preserve idProveedor(n + 1)
            idProveedor(n) = rstReader("CodigoProv")
            n = n + 1
        Loop
        cnnConexion.Close()
    End Sub

    Private Sub LlenarCbTipoOperacion()

        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer
        sql = "SELECT Codigo, Descripcion FROM TipoCompra ORDER BY Codigo"
        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        n = 0
        Do While rstReader.Read
            cbTipoOperacion.Items.Add(rstReader("Descripcion"))
            ReDim Preserve idTipoCompra(n + 1)
            idTipoCompra(n) = rstReader("Codigo")
            n = n + 1
        Loop
        cnnConexion.Close()

    End Sub

    Private Sub LlenarCmbMoneda()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String
        Dim n As Integer
        sql = "SELECT CodMoneda,MonedaNombre FROM Moneda "
        cnnConexion.ConnectionString =Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)
        n = 0
        Do While rstReader.Read
            cmbMoneda.Items.Add(rstReader("MonedaNombre"))
            ReDim Preserve IdMoneda(n + 1)
            IdMoneda(n) = rstReader("CodMoneda")
            n = n + 1
        Loop
        cnnConexion.Close()
    End Sub

#End Region

#End Region

#Region "Asientos Contables"
    Sub eliminarAnteriorAsiento()
        'If Me.NumAsiento.Equals("") Or Me.NumAsiento.Equals("0") Then Exit Sub
        'Dim cx As New Conexion
        'cx.Conectar("Contabilidad")
        'cx.SlqExecute(cx.sQlconexion, "UPDATE AsientosContables SET Anulado = 1, Observaciones = Observaciones + '(ANULADO*)' WHERE NumAsiento = '" & Me.NumAsiento & "'")
        'cx.DesConectar(cx.sQlconexion)
    End Sub
    Dim nummayorizado As Integer
    Dim mayorizado As Boolean
    Dim tipo_cambio As Decimal
    Public Sub GuardaAsiento()
        Dim asiento As String
        Dim fecha As Date = Me.dtpFecha.Text
        
        Dim Fx As New cFunciones

        If ExisteAsiento(NumAsiento) = True Then
            Dim cx As New Conexion
            cx.Conectar("Contabilidad")
            cx.SlqExecute(cx.sQlconexion, "delete from  AsientosContables WHERE NumAsiento = '" & Me.NumAsiento & "'")
            cx.SlqExecute(cx.sQlconexion, "delete from DetallesAsientosContable WHERE NumAsiento = '" & Me.NumAsiento & "'")
            cx.DesConectar(cx.sQlconexion)
            asiento = NumAsiento
        Else
            asiento = Fx.BuscaNumeroAsiento("COM-" & Format(fecha, "MM") & Format(fecha, "yy") & "-")
        End If

        Me.NumAsiento = asiento

        Dim dtG As New DataTable
        Dim dtGDet As New DataTable
        Dim dtProv As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT Id_Compra, Factura, CodigoProv, Cod_MonedaCompra, SubTotalGravado, SubTotalExento, Impuesto, Fecha, TotalFactura as Total, Contabilizado, Asiento, Compra, Gasto, ContaInve, AsientoInve FROM compras WHERE Gasto = 1 AND Id_Compra = " & Me.IdGasto, dtG,Configuracion.Claves.Conexion("Proveeduria"))
        If dtG.Rows.Count <= 0 Then
            MsgBox("No se encontro la factura, para hacer el asiento", MsgBoxStyle.OKOnly)
            Exit Sub
        End If
        cFunciones.Llenar_Tabla_Generico("Select CodigoProv, Nombre, CuentaContable, DescripcionCuentaContable From Proveedores WHERE CodigoProv = " & dtG.Rows(0).Item("CodigoProv"), dtProv,Configuracion.Claves.Conexion("Proveeduria"))
        If dtProv.Rows.Count <= 0 Then
            MsgBox("No se encontro el proveedor, para hacer el asiento", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        cFunciones.Llenar_Tabla_Generico("SELECT SUM(Total) AS Total, CuentaContable FROM Articulos_Gastos WHERE (IdCompra = " & Me.IdGasto & ") GROUP BY CuentaContable ", dtGDet,Configuracion.Claves.Conexion("Proveeduria"))
        If dtGDet.Rows.Count <= 0 Then
            MsgBox("No se los detalles de la factura, para hacer el asiento", MsgBoxStyle.OKOnly)
            Exit Sub
        End If

        BindingContext(dtsGasto, "AsientosContables").EndCurrentEdit()
        BindingContext(dtsGasto, "AsientosContables").AddNew()
        BindingContext(dtsGasto, "AsientosContables").Current("NumAsiento") = asiento
        BindingContext(dtsGasto, "AsientosContables").Current("Fecha") = fecha
        BindingContext(dtsGasto, "AsientosContables").Current("IdNumDoc") = IdGasto
        BindingContext(dtsGasto, "AsientosContables").Current("NumDoc") = dtG.Rows(0).Item("Factura")
        BindingContext(dtsGasto, "AsientosContables").Current("Beneficiario") = dtProv.Rows(0).Item("Nombre")
        BindingContext(dtsGasto, "AsientosContables").Current("TipoDoc") = 13
        BindingContext(dtsGasto, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(dtsGasto, "AsientosContables").Current("Anulado") = 0
        BindingContext(dtsGasto, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(dtsGasto, "AsientosContables").Current("Mayorizado") = True
        BindingContext(dtsGasto, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(fecha)
        BindingContext(dtsGasto, "AsientosContables").Current("NumMayorizado") = Me.nummayorizado
        BindingContext(dtsGasto, "AsientosContables").Current("Modulo") = "Gastos"
        BindingContext(dtsGasto, "AsientosContables").Current("Observaciones") = "Asiento de Gastos # " & dtG.Rows(0).Item("Factura")
        BindingContext(dtsGasto, "AsientosContables").Current("NombreUsuario") = TxtNombreUsuario.Text
        BindingContext(dtsGasto, "AsientosContables").Current("TotalDebe") = dtG.Rows(0).Item("Total")
        BindingContext(dtsGasto, "AsientosContables").Current("TotalHaber") = dtG.Rows(0).Item("Total")
        BindingContext(dtsGasto, "AsientosContables").Current("CodMoneda") = dtG.Rows(0).Item("Cod_MonedaCompra")
        BindingContext(dtsGasto, "AsientosContables").Current("TipoCambio") = Me.tipo_cambio
        tipocambio = Me.tipo_cambio
        BindingContext(dtsGasto, "AsientosContables").EndCurrentEdit()

        'ASIENTO CUENTA PROVEEDOR

        'ASIENTO DETALLES GASTOS
        For i As Integer = 0 To dtGDet.Rows.Count - 1
            Dim nomC As String
            Dim dtC As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select Descripcion From [dbo].[CuentaContable] WHERE CuentaContable = '" & dtGDet.Rows(i).Item("CuentaContable") & "'", dtC, Configuracion.Claves.Conexion("Contabilidad"))
            If dtC.Rows.Count > 0 Then
                nomC = dtC.Rows(0).Item("Descripcion")
            End If
            Me.GuardaAsientoDetalle(dtGDet.Rows(i).Item("Total"), True, False, dtGDet.Rows(i).Item("CuentaContable"), nomC)
        Next
        GuardaAsientoDetalle(dtG.Rows(0).Item("Impuesto"), True, False, BuscaCuenta("CuentaContable", "IdCreditoComp"), BuscaCuenta("Descripcion", "IdCreditoComp"))
        GuardaAsientoDetalle(dtG.Rows(0).Item("Total"), False, True, dtProv.Rows(0).Item("CuentaContable"), dtProv.Rows(0).Item("DescripcionCuentaContable"))

        If Not TransAsiento_ASIENTO() Then
            MsgBox("No se pudo registrar el asiento")
        Else
            Me.NumAsiento = Me.BindingContext(Me.dtsGasto, "AsientosContables").Current("NumAsiento")
            Dim cx As New Conexion
            cx.Conectar("Proveeduria")
            cx.SlqExecute(cx.sQlconexion, "UPDATE compras Set Asiento = '" & NumAsiento & "', Contabilizado = 1 WHERE Id_Compra = " & Me.IdGasto)
            cx.DesConectar(cx.sQlconexion)
        End If
    End Sub

    Function BuscaCuenta(ByVal Tipo As String, ByVal Id As String) As String
        Dim cConexion As New Conexion
        Try
            BuscaCuenta = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT TOP 1 (SELECT " & Tipo & " FROM cuentacontable " & _
                            "WHERE (Id = (SELECT " & Id & " FROM settingcuentacontable))) AS Cuenta FROM CuentaContable")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cConexion.DesConectar(cConexion.sQlconexion)
        End Try
    End Function
    Function TransAsiento_ASIENTO() As Boolean
        Dim Trans As SqlTransaction

        Try
            If SqlConnection3.State <> SqlConnection3.State.Open Then SqlConnection3.Open()

            Trans = SqlConnection3.BeginTransaction
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(dtsGasto, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = Trans
            AdapterDetallesAsientos.DeleteCommand.Transaction = Trans
            AdapterDetallesAsientos.InsertCommand.Transaction = Trans
            AdapterAsientos.UpdateCommand.Transaction = Trans
            AdapterAsientos.DeleteCommand.Transaction = Trans
            AdapterAsientos.InsertCommand.Transaction = Trans
            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterDetallesAsientos.Update(dtsGasto.DetallesAsientosContable)
            AdapterAsientos.Update(dtsGasto.AsientosContables)
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String)
        If Monto > 0 Then
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(dtsGasto, "AsientosContables").Current("NumAsiento")
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(dtsGasto, "AsientosContables").Current("Observaciones")
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = Me.tipo_cambio
            BindingContext(dtsGasto, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        End If
    End Sub

    Private Sub asignaNumAsiento()
        For i As Integer = 0 To Me.dtsGasto.CentroCosto_Movimientos.Rows.Count - 1
            BindingContext(dtsGasto, "CentroCosto_Movimientos").Position = i
            BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("idasiento") = Me.NumAsiento
            BindingContext(dtsGasto, "CentroCosto_Movimientos").EndCurrentEdit()
        Next
    End Sub

    Function TransAsiento() As Boolean  'REALIZA LA TRANSACCIÓN DE LOS ASIENTOS CONTABLES
        asignaNumAsiento()
        Dim Trans As SqlTransaction
        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            Trans = SqlConnection1.BeginTransaction
            AdapterCentroCostoMovimiento.UpdateCommand.Transaction = Trans
            AdapterCentroCostoMovimiento.DeleteCommand.Transaction = Trans
            AdapterCentroCostoMovimiento.InsertCommand.Transaction = Trans
            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterCentroCostoMovimiento.Update(dtsGasto.CentroCosto_Movimientos)
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

#Region "Centro de Costo"

#Region "Botones"
    Private Sub BCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BCentroCosto.Click
        Try
            If txtDetallePrecioUnidad.Text = "" Or CDbl(txtDetallePrecioUnidad.Text) < 1 Or txtDetalleCantidad.Text = "" Or CDbl(txtDetalleCantidad.Text) < 1 Then
                MsgBox("Por favor revise el precio unitario y la cantidad", MsgBoxStyle.Critical, "Datos Incorrectos")
                txtDetallePrecioUnidad.Focus()
                Exit Sub
            End If

            If txtCuentaContable.Text = "" Or txtCuentaContableDescripcion.Text = "" Then
                MsgBox("Por favor revise La Cuenta Contable asignada", MsgBoxStyle.Critical, "Datos Incorrectos")
                txtCuentaContable.Focus()
                Exit Sub
            End If

            CargaCentro()
            TxtDetalle.Text = (CDbl(txtDetallePrecioUnidad.Text) * CDbl(txtDetalleCantidad.Text))
            Panel_Centrar()
            BNuevo.Focus()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub BNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BNuevo.Click
        If BNuevo.Text = "Nuevo" Then
            AgregaCentro()
            Controles(True)
            BNuevo.Text = "Cancelar"
            ButtonAgregarDetalle.Enabled = True
            EditDescripcionCC.Text = txtDetalleArticuloDescripcion.Text
            CBCentroCosto.Focus()
        Else
            BindingContext(dtsGasto, "CentroCosto_Movimientos").CancelCurrentEdit()
            TxtDetalle.Text = (CDbl(txtDetallePrecioUnidad.Text) * CDbl(txtDetalleCantidad.Text))
            Controles(False)
            BNuevo.Text = "Nuevo"
            ButtonAgregarDetalle.Enabled = False
        End If
    End Sub


    Private Sub ButtonAgregarDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAgregarDetalle.Click
        If TotalCentro > CDbl(TxtDetalle.Text) Or (CDbl(TxtDetalle.Text) < CDbl(txtMontoCentroCosto.Text) + TotalCentro) Then
            MsgBox("El monto es incorrecto, falta por asignar " & (CDbl(TxtDetalle.Text) - TotalCentro), MsgBoxStyle.Critical, "Favor Revisar el Monto")
            txtMontoCentroCosto.Focus()
            Exit Sub
        End If

        If CDbl(txtMontoCentroCosto.Text) <= 0 Then
            MsgBox("El monto no puede ser " & CDbl(txtMontoCentroCosto.Text), MsgBoxStyle.Critical, "Favor Revisar el Monto")
            txtMontoCentroCosto.Focus()
            Exit Sub
        End If

        TotalCentro += CDbl(txtMontoCentroCosto.Text)
        LlenaGridCentro(CBCentroCosto.Text, CDbl(txtMontoCentroCosto.Text), EditDescripcionCC.Text, BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("Id"))
        BindingContext(dtsGasto, "CentroCosto_Movimientos").EndCurrentEdit()
        TxtDetalle.Text = (CDbl(txtDetallePrecioUnidad.Text) * CDbl(txtDetalleCantidad.Text))
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
        BNuevo.Focus()
    End Sub


    Private Sub BotonCerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCerrar.Click
        BindingContext(dtsGasto, "CentroCosto_Movimientos").CancelCurrentEdit()
        Panel_Ocultar()
        cbTipoOperacion.Focus()
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub
#End Region

#Region "Funciones"
    Public Sub AgregaCentro()
        BindingContext(dtsGasto, "CentroCosto_Movimientos").EndCurrentEdit()
        BindingContext(dtsGasto, "CentroCosto_Movimientos").AddNew()
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("IdAsiento") = "0"
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("Documento") = ""
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("Fecha") = dtpFecha.Value
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("Debe") = True
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("Haber") = False
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("CuentaContable") = txtCuentaContable.Text
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("NombreCuentaContable") = txtCuentaContableDescripcion.Text
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("Tipo") = 13
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("IdDetalle") = ((dtsGasto.GastoDetalle.Count + 1) * -1)
        CBCentroCosto.SelectedIndex = 0
        BindingContext(dtsGasto, "CentroCosto_Movimientos").Current("IdCentroCosto") = CBCentroCosto.SelectedValue
    End Sub


    Public Sub CargaCentro()
        Dim Centro() As System.Data.DataRow
        TotalCentro = 0
        dtsGasto.CentroCostoDetalle.Clear()
    End Sub


    Public Sub LlenaGridCentro(ByVal Centro As String, ByVal monto As Double, ByVal descripcion As String, ByVal id As Integer)
        Dim NuevaFila As DatasetGasto.CentroCostoDetalleRow
        NuevaFila = dtsGasto.CentroCostoDetalle.NewCentroCostoDetalleRow()
        NuevaFila.CentroCosto = Centro
        NuevaFila.Monto = monto
        NuevaFila.Descripcion = descripcion
        NuevaFila.id = id
        dtsGasto.CentroCostoDetalle.AddCentroCostoDetalleRow(NuevaFila)
    End Sub


    Public Sub EliminaCentro(ByVal id As Integer)
        Try
x:
            If dtsGasto.CentroCosto_Movimientos.Count > 0 Then
                For i As Integer = 0 To dtsGasto.CentroCosto_Movimientos.Count - 1
                    If dtsGasto.CentroCosto_Movimientos.Item(i).IdDetalle = id Then
                        BindingContext(dtsGasto.CentroCosto_Movimientos).RemoveAt(i)
                        GoTo x
                    End If
                Next
                If EditaCentro = True Then
                    Dim Funcion As New Conexion
                    Funcion.DeleteRecords("CentroCosto_Movimientos", "IdDetalle =" & id)
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub EliminarDetalleCentro()
        If MsgBox("Desea Eliminar este item del detalle..", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        If dtsGasto.CentroCostoDetalle.Count = 0 Then Exit Sub
        Dim posicion, pos, IdCentro As Integer
        posicion = BindingContext(dtsGasto.CentroCostoDetalle).Position()

        For i As Integer = 0 To dtsGasto.CentroCosto_Movimientos.Count - 1
            If dtsGasto.CentroCosto_Movimientos(i).Id = BindingContext(dtsGasto.CentroCostoDetalle).Current("Id") Then
                pos = i
            End If
        Next i
        TotalCentro = (TotalCentro - dtsGasto.CentroCosto_Movimientos(pos).Monto)
        IdCentro = dtsGasto.CentroCosto_Movimientos(pos).Id
        dtsGasto.CentroCosto_Movimientos.Rows.RemoveAt(pos)
        If EditaCentro = True Then
            Dim Funcion As New Conexion
            Funcion.DeleteRecords("CentroCosto_Movimientos", "Id = " & IdCentro)
        End If
        BindingContext(dtsGasto, "CentroCosto_Movimientos").EndCurrentEdit()
        dtsGasto.CentroCostoDetalle.Rows.RemoveAt(posicion)

        BindingContext(dtsGasto, "CentroCosto_Movimientos").CancelCurrentEdit()
        TxtDetalle.Text = (CDbl(txtDetallePrecioUnidad.Text) * CDbl(txtDetalleCantidad.Text))
        Controles(False)
        BNuevo.Text = "Nuevo"
        ButtonAgregarDetalle.Enabled = False
    End Sub


    Function CargarCentroCosto(ByVal Id As String)
        Dim cnn As SqlConnection = Nothing
        ' Dentro de un Try/Catch por si se produce un error
        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "select * from CentroCosto_Movimientos WHERE (Tipo = 13) AND Documento = '" & Id & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            dtsGasto.CentroCosto_Movimientos.Clear()
            dtsGasto.CentroCostoDetalle.Clear()
            da.Fill(dtsGasto.CentroCosto_Movimientos)
            If dtsGasto.CentroCosto_Movimientos.Count < 1 Then
                dtsGasto.CentroCosto_Movimientos.Clear()
                Exit Try
            End If
            EditaCentro = True

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
    End Function


    Public Sub ActualizaIDCentro(ByVal IdGasto As Integer)
        If dtsGasto.CentroCosto_Movimientos.Count > 0 Then
            Dim j As Integer = -1
            Dim Id_detalle As Integer
            Dim cConexion As New Conexion
            Id_detalle = cConexion.SlqExecuteScalar(cConexion.Conectar("Proveeduria"), "SELECT ISNULL(MAX(Id_ArticuloComprados),0) FROM dbo.Articulos_Gastos")
            cConexion.DesConectar(cConexion.sQlconexion)

            For i As Integer = 0 To dtsGasto.GastoDetalle.Count - 1
                Id_detalle += 1
                For x As Integer = 0 To dtsGasto.CentroCosto_Movimientos.Count - 1
                    If dtsGasto.CentroCosto_Movimientos.Item(x).IdDetalle = j Then
                        dtsGasto.CentroCosto_Movimientos.Item(x).IdDetalle = Id_detalle
                        dtsGasto.CentroCosto_Movimientos.Item(x).Documento = IdGasto
                    End If
                Next
                j -= 1
            Next
        End If
    End Sub
#End Region

#Region "Otras"
    Private Sub CBCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CBCentroCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtMontoCentroCosto.Focus()
        End If
    End Sub


    Private Sub txtMontoCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoCentroCosto.KeyDown
        If e.KeyCode = Keys.Enter Then
            EditDescripcionCC.Focus()
        End If
    End Sub


    Private Sub txtMontoCentroCosto_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCentroCosto.GotFocus
        txtMontoCentroCosto.SelectAll()
    End Sub


    Private Sub GridCentroCosto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridCentroCosto.KeyDown
        If e.KeyCode = Keys.Delete Then
            EliminarDetalleCentro()
        End If
    End Sub


    Private Sub EditDescripcionCC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles EditDescripcionCC.KeyDown
        If e.KeyCode = Keys.Enter Then
            ButtonAgregarDetalle.Focus()
        End If
    End Sub


    Private Sub Panel_Centrar()
        PanelCentroCosto.Left = (Width - PanelCentroCosto.Width) \ 2
    End Sub


    Private Sub Panel_Ocultar()
        PanelCentroCosto.Left = -PanelCentroCosto.Width
    End Sub

    Private Sub Controles(ByVal estado As Boolean)
        CBCentroCosto.Enabled = estado
        txtMontoCentroCosto.Enabled = estado
        EditDescripcionCC.Enabled = estado
    End Sub
#End Region

#End Region

    Private Sub cmbTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.SelectedText = "CRE" Then

        Else

        End If
    End Sub

    Private Sub txtCuentaContable_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCuentaContable.TextChanged

    End Sub

    Private Sub cbTipoOperacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbTipoOperacion.SelectedIndexChanged

    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClave.TextChanged

    End Sub
End Class
