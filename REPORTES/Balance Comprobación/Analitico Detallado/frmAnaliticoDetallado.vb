Imports Utilidades
Public Class frmAnaliticoDetallado
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
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DtsAnaliticoDetallado1 As Contabilidad.dtsAnaliticoDetallado
    Friend WithEvents colAsiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colObs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colBeneficiario As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colFecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDebito As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreditos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNombreCuenta As System.Windows.Forms.Label
    Friend WithEvents lblDescripcionCuenta As System.Windows.Forms.Label
    Friend WithEvents lblAsiento As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents colMoneda As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDescripcionMoneda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblCreditos As System.Windows.Forms.Label
    Friend WithEvents lblDebitos As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
	Friend WithEvents colNoDocumentoDetalle As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSaldoAnt As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents colSaldoAct As DevExpress.XtraGrid.Columns.GridColumn
	Friend WithEvents Label6 As System.Windows.Forms.Label
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim ColumnFilterInfo12 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo13 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo14 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo15 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo16 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo17 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo18 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo19 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnaliticoDetallado))
		Dim ColumnFilterInfo20 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo21 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
		Me.DtsAnaliticoDetallado1 = New Contabilidad.dtsAnaliticoDetallado()
		Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.colAsiento = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colObs = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colBeneficiario = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colFecha = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDebito = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colCreditos = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colDescripcionMoneda = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colMoneda = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
		Me.colNoDocumentoDetalle = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.lblNombreCuenta = New System.Windows.Forms.Label()
		Me.lblDescripcionCuenta = New System.Windows.Forms.Label()
		Me.lblAsiento = New System.Windows.Forms.Label()
		Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.lblCreditos = New System.Windows.Forms.Label()
		Me.lblDebitos = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.colSaldoAnt = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.colSaldoAct = New DevExpress.XtraGrid.Columns.GridColumn()
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.DtsAnaliticoDetallado1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.colMoneda, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'GridControl2
		'
		Me.GridControl2.DataMember = "TemporalAnaliticoDetallado"
		Me.GridControl2.DataSource = Me.DtsAnaliticoDetallado1
		Me.GridControl2.Dock = System.Windows.Forms.DockStyle.Fill
		'
		'
		'
		Me.GridControl2.EmbeddedNavigator.Name = ""
		Me.GridControl2.Location = New System.Drawing.Point(3, 27)
		Me.GridControl2.MainView = Me.GridView2
		Me.GridControl2.Name = "GridControl2"
		Me.GridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.colMoneda})
		Me.GridControl2.Size = New System.Drawing.Size(1092, 442)
		Me.GridControl2.TabIndex = 86
		Me.GridControl2.Visible = False
		'
		'DtsAnaliticoDetallado1
		'
		Me.DtsAnaliticoDetallado1.DataSetName = "dtsAnaliticoDetallado"
		Me.DtsAnaliticoDetallado1.Locale = New System.Globalization.CultureInfo("es-ES")
		Me.DtsAnaliticoDetallado1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'GridView2
		'
		Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colAsiento, Me.colObs, Me.colBeneficiario, Me.colFecha, Me.colDocumento, Me.colDescripcionMoneda, Me.colSaldoAnt, Me.colDebito, Me.colCreditos, Me.colSaldoAct, Me.colNoDocumentoDetalle})
		Me.GridView2.Name = "GridView2"
		Me.GridView2.OptionsView.ShowGroupPanel = False
		Me.GridView2.ViewCaption = "Reservaciones"
		'
		'colAsiento
		'
		Me.colAsiento.Caption = "Asiento"
		Me.colAsiento.FieldName = "NumAsiento"
		Me.colAsiento.FilterInfo = ColumnFilterInfo12
		Me.colAsiento.Name = "colAsiento"
		Me.colAsiento.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colAsiento.VisibleIndex = 0
		Me.colAsiento.Width = 78
		'
		'colObs
		'
		Me.colObs.Caption = "Observaciones"
		Me.colObs.FieldName = "Observaciones"
		Me.colObs.FilterInfo = ColumnFilterInfo13
		Me.colObs.Name = "colObs"
		Me.colObs.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colObs.VisibleIndex = 1
		Me.colObs.Width = 179
		'
		'colBeneficiario
		'
		Me.colBeneficiario.Caption = "Beneficiario"
		Me.colBeneficiario.FieldName = "Beneficiario"
		Me.colBeneficiario.FilterInfo = ColumnFilterInfo14
		Me.colBeneficiario.Name = "colBeneficiario"
		Me.colBeneficiario.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colBeneficiario.VisibleIndex = 2
		Me.colBeneficiario.Width = 162
		'
		'colFecha
		'
		Me.colFecha.Caption = "Fecha"
		Me.colFecha.FieldName = "Fecha"
		Me.colFecha.FilterInfo = ColumnFilterInfo15
		Me.colFecha.Name = "colFecha"
		Me.colFecha.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colFecha.VisibleIndex = 3
		Me.colFecha.Width = 54
		'
		'colDocumento
		'
		Me.colDocumento.Caption = "Documento"
		Me.colDocumento.FieldName = "NumDoc"
		Me.colDocumento.FilterInfo = ColumnFilterInfo16
		Me.colDocumento.Name = "colDocumento"
		Me.colDocumento.Options = CType((DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly] Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colDocumento.VisibleIndex = 4
		Me.colDocumento.Width = 70
		'
		'colDebito
		'
		Me.colDebito.Caption = "Debitos"
		Me.colDebito.DisplayFormat.FormatString = "#,##0.00"
		Me.colDebito.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colDebito.FieldName = "Debitos"
		Me.colDebito.FilterInfo = ColumnFilterInfo17
		Me.colDebito.Name = "colDebito"
		Me.colDebito.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colDebito.VisibleIndex = 7
		Me.colDebito.Width = 114
		'
		'colCreditos
		'
		Me.colCreditos.Caption = "Creditos"
		Me.colCreditos.DisplayFormat.FormatString = "#,##0.00"
		Me.colCreditos.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colCreditos.FieldName = "Creditos"
		Me.colCreditos.FilterInfo = ColumnFilterInfo18
		Me.colCreditos.Name = "colCreditos"
		Me.colCreditos.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colCreditos.VisibleIndex = 8
		Me.colCreditos.Width = 114
		'
		'colDescripcionMoneda
		'
		Me.colDescripcionMoneda.Caption = "Moneda"
		Me.colDescripcionMoneda.ColumnEdit = Me.colMoneda
		Me.colDescripcionMoneda.FieldName = "Moneda"
		Me.colDescripcionMoneda.FilterInfo = ColumnFilterInfo19
		Me.colDescripcionMoneda.Name = "colDescripcionMoneda"
		Me.colDescripcionMoneda.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colDescripcionMoneda.VisibleIndex = 5
		Me.colDescripcionMoneda.Width = 70
		'
		'colMoneda
		'
		Me.colMoneda.AutoHeight = False
		Me.colMoneda.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
		Me.colMoneda.DataSource = Me.DtsAnaliticoDetallado1.Moneda
		Me.colMoneda.DisplayMember = "MonedaNombre"
		Me.colMoneda.Name = "colMoneda"
		Me.colMoneda.ReadOnly = True
		Me.colMoneda.ValueMember = "CodMoneda"
		'
		'colNoDocumentoDetalle
		'
		Me.colNoDocumentoDetalle.Caption = "Doc Referencia"
		Me.colNoDocumentoDetalle.FieldName = "NoDocumentoDetalle"
		Me.colNoDocumentoDetalle.FilterInfo = ColumnFilterInfo6
		Me.colNoDocumentoDetalle.Name = "colNoDocumentoDetalle"
		Me.colNoDocumentoDetalle.Options = CType((((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.FixedWidth) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colNoDocumentoDetalle.VisibleIndex = 10
		Me.colNoDocumentoDetalle.Width = 104
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.GridControl2)
		Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.GroupBox1.ForeColor = System.Drawing.Color.RoyalBlue
		Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(1098, 472)
		Me.GroupBox1.TabIndex = 87
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = " Detalle Analitico"
		'
		'Button1
		'
		Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Button1.Location = New System.Drawing.Point(882, 8)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(200, 64)
		Me.Button1.TabIndex = 88
		Me.Button1.Text = "Imprimir Analitico"
		'
		'SqlDataAdapter1
		'
		Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
		Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
		Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TemporalAnaliticoDetallado", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Moneda", "Moneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Debitos", "Debitos"), New System.Data.Common.DataColumnMapping("Creditos", "Creditos"), New System.Data.Common.DataColumnMapping("SaldoAnterior", "SaldoAnterior"), New System.Data.Common.DataColumnMapping("SaldoActual", "SaldoActual"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("NoDocumentoDetalle", "NoDocumentoDetalle")})})
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
		Me.SqlInsertCommand1.Connection = Me.SqlConnection1
		Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.SmallDateTime, 0, "Fecha"), New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 0, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Moneda", System.Data.SqlDbType.Int, 0, "Moneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 0, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 0, "Observaciones"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 0, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 0, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 0, "Debitos"), New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 0, "Creditos"), New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 0, "SaldoAnterior"), New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 0, "SaldoActual"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 0, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 0, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 0, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@NoDocumentoDetalle", System.Data.SqlDbType.VarChar, 0, "NoDocumentoDetalle")})
		'
		'SqlConnection1
		'
		Me.SqlConnection1.ConnectionString = "Data Source=SERVIDOR-PC\CARSERVICE;Initial Catalog=Contabilidad;Integrated Securi" &
	"ty=True"
		Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.SqlConnection1
		'
		'Label1
		'
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Label1.Location = New System.Drawing.Point(24, 16)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(112, 23)
		Me.Label1.TabIndex = 89
		Me.Label1.Text = "Cuenta :"
		'
		'Label2
		'
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Label2.Location = New System.Drawing.Point(24, 40)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(112, 23)
		Me.Label2.TabIndex = 90
		Me.Label2.Text = "Descripcion :"
		'
		'lblNombreCuenta
		'
		Me.lblNombreCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblNombreCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblNombreCuenta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblNombreCuenta.Location = New System.Drawing.Point(144, 16)
		Me.lblNombreCuenta.Name = "lblNombreCuenta"
		Me.lblNombreCuenta.Size = New System.Drawing.Size(544, 23)
		Me.lblNombreCuenta.TabIndex = 91
		'
		'lblDescripcionCuenta
		'
		Me.lblDescripcionCuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblDescripcionCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDescripcionCuenta.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDescripcionCuenta.Location = New System.Drawing.Point(144, 40)
		Me.lblDescripcionCuenta.Name = "lblDescripcionCuenta"
		Me.lblDescripcionCuenta.Size = New System.Drawing.Size(544, 23)
		Me.lblDescripcionCuenta.TabIndex = 92
		'
		'lblAsiento
		'
		Me.lblAsiento.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAnaliticoDetallado1, "TemporalAnaliticoDetallado.NumAsiento", True))
		Me.lblAsiento.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblAsiento.Location = New System.Drawing.Point(26, 70)
		Me.lblAsiento.Name = "lblAsiento"
		Me.lblAsiento.Size = New System.Drawing.Size(100, 16)
		Me.lblAsiento.TabIndex = 93
		'
		'SqlDataAdapter2
		'
		Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand2
		Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand2
		Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable")})})
		'
		'SqlInsertCommand2
		'
		Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
		Me.SqlInsertCommand2.Connection = Me.SqlConnection1
		Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"), New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"), New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"), New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"), New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable")})
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo, CuentaContable " &
	"FROM Moneda"
		Me.SqlSelectCommand2.Connection = Me.SqlConnection1
		'
		'lblCreditos
		'
		Me.lblCreditos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblCreditos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblCreditos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblCreditos.Location = New System.Drawing.Point(922, 584)
		Me.lblCreditos.Name = "lblCreditos"
		Me.lblCreditos.Size = New System.Drawing.Size(184, 24)
		Me.lblCreditos.TabIndex = 95
		Me.lblCreditos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'lblDebitos
		'
		Me.lblDebitos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblDebitos.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDebitos.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDebitos.Location = New System.Drawing.Point(730, 584)
		Me.lblDebitos.Name = "lblDebitos"
		Me.lblDebitos.Size = New System.Drawing.Size(184, 24)
		Me.lblDebitos.TabIndex = 96
		Me.lblDebitos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		'
		'Label5
		'
		Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Label5.Location = New System.Drawing.Point(722, 560)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(192, 23)
		Me.Label5.TabIndex = 97
		Me.Label5.Text = "Total Debitos"
		'
		'Label6
		'
		Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Label6.Location = New System.Drawing.Point(914, 560)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(192, 23)
		Me.Label6.TabIndex = 98
		Me.Label6.Text = "Total Creditos"
		'
		'Button2
		'
		Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.ForeColor = System.Drawing.Color.RoyalBlue
		Me.Button2.Location = New System.Drawing.Point(711, 8)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(165, 64)
		Me.Button2.TabIndex = 99
		Me.Button2.Text = "Actualizar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Datos"
		'
		'colSaldoAnt
		'
		Me.colSaldoAnt.Caption = "Saldo Ant"
		Me.colSaldoAnt.DisplayFormat.FormatString = "#,##0.00"
		Me.colSaldoAnt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSaldoAnt.FieldName = "SaldoAnterior"
		Me.colSaldoAnt.FilterInfo = ColumnFilterInfo20
		Me.colSaldoAnt.Name = "colSaldoAnt"
		Me.colSaldoAnt.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colSaldoAnt.VisibleIndex = 6
		Me.colSaldoAnt.Width = 62
		'
		'colSaldoAct
		'
		Me.colSaldoAct.Caption = "Saldo Act"
		Me.colSaldoAct.DisplayFormat.FormatString = "#,##0.00"
		Me.colSaldoAct.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
		Me.colSaldoAct.FieldName = "SaldoActual"
		Me.colSaldoAct.FilterInfo = ColumnFilterInfo21
		Me.colSaldoAct.Name = "colSaldoAct"
		Me.colSaldoAct.Options = CType(((DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.colSaldoAct.VisibleIndex = 9
		Me.colSaldoAct.Width = 71
		'
		'frmAnaliticoDetallado
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(1114, 613)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.lblDebitos)
		Me.Controls.Add(Me.lblCreditos)
		Me.Controls.Add(Me.lblDescripcionCuenta)
		Me.Controls.Add(Me.lblNombreCuenta)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.GroupBox1)
		Me.Controls.Add(Me.lblAsiento)
		Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DtsAnaliticoDetallado1, "TemporalAnaliticoDetallado.NumAsiento", True))
		Me.Name = "frmAnaliticoDetallado"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Analitico Detallado"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.DtsAnaliticoDetallado1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.colMoneda, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public NombreMoneda As String
    Public SaldoMes As Decimal
    Public SaldoAnterior As Decimal
    Public CuentaContable As String
    Public NombreCuenta As String
    Public usua As Object
    Public Event Actualiza()

    Private Sub CargaDatos()
        Dim dts As New DataTable
        Me.DtsAnaliticoDetallado1.TemporalAnaliticoDetallado.Clear()
        cFunciones.Llenar_Tabla_Generico("select * from TemporalAnaliticoDetallado order by fecha", Me.DtsAnaliticoDetallado1.TemporalAnaliticoDetallado, Configuracion.Claves.Conexion("Contabilidad"))
        cFunciones.Llenar_Tabla_Generico("select isnull(sum(debitos),0) as debitos, isnull(sum(creditos),0) as creditos from TemporalAnaliticoDetallado", dts, Configuracion.Claves.Conexion("Contabilidad"))
		If dts.Rows.Count > 0 Then
			Me.lblDebitos.Text = Format(Val(dts.Rows(0).Item("debitos")), "#,##0.00")
			Me.lblCreditos.Text = Format(Val(dts.Rows(0).Item("creditos")), "#,##0.00")
		Else
			Me.lblDebitos.Text = "0.00"
			Me.lblCreditos.Text = "0.00"
		End If
		For i As Integer = 0 To DtsAnaliticoDetallado1.TemporalAnaliticoDetallado.Rows.Count - 1
			If DtsAnaliticoDetallado1.TemporalAnaliticoDetallado(i).Beneficiario.ToString() <> "" Then
				colBeneficiario.VisibleIndex = 2
				Exit For
			Else
				colBeneficiario.VisibleIndex = -1
			End If
		Next
		GridControl2.Visible = True

	End Sub

    Private Sub frmAnaliticoDetallado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblNombreCuenta.Text = Me.CuentaContable
        Me.lblDescripcionCuenta.Text = Me.NombreCuenta
        Me.GroupBox1.Text = ""
        Me.GroupBox1.Text = " Detalle Analitico en " & Me.NombreMoneda
        cFunciones.Llenar_Tabla_Generico("select * from Moneda", Me.DtsAnaliticoDetallado1.Moneda, Configuracion.Claves.Conexion("Contabilidad"))
		Me.CargaDatos()

	End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rpt As New Detalle_Analitico_modificado2
        Dim visor As New frmVisorReportes
        rpt.SetParameterValue(0, Me.NombreMoneda)
        rpt.SetParameterValue(1, Me.SaldoMes)
        rpt.SetParameterValue(2, Me.SaldoAnterior)
        rpt.SetParameterValue(3, Me.CuentaContable)
        rpt.SetParameterValue(4, Me.NombreCuenta)

        CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
        visor.Show()
    End Sub

    Private Function GETMODULO() As String
        Dim DTS As New DataTable
        cFunciones.Llenar_Tabla_Generico("select modulo from asientoscontables where numasiento = '" & Me.lblAsiento.Text & "'", DTS, Configuracion.Claves.Conexion("Contabilidad"))
        If DTS.Rows.Count > 0 Then
            Return DTS.Rows(0).Item("modulo")
        Else
            Return ""
        End If
        Return ""
    End Function
    Private Function GetNumDocumento(ByVal _Modulo As String) As String
        Dim dts As New DataTable
        Select Case _Modulo
            Case "Depositos"
                cFunciones.Llenar_Tabla_Generico("select top 1  NumeroDocumento from dbo.Deposito where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "Ajustes Bancarios"
                cFunciones.Llenar_Tabla_Generico("select top 1  Num_Ajuste from dbo.AjusteBancario where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "AJUSTE CRE"
                cFunciones.Llenar_Tabla_Generico("select top 1  Num_Ajuste from dbo.AjusteBancario where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "AJUSTE DEB"
                cFunciones.Llenar_Tabla_Generico("select top 1  Num_Ajuste from dbo.AjusteBancario where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
        End Select
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return "0"
        End If
    End Function
    Private Function GetIdentificadores(ByVal _modulo As String) As Double
        Dim dts As New DataTable
        Select Case _modulo
            Case "Gastos"
                cFunciones.Llenar_Tabla_Generico("select top 1 id_compra from dbo.Compras where asiento = '" & Me.lblAsiento.Text & "'", dts, Configuracion.Claves.Conexion("Proveeduria"))
            Case "FACTURA GASTOS"
                cFunciones.Llenar_Tabla_Generico("select top 1 id_compra from dbo.Compras where asiento = '" & Me.lblAsiento.Text & "'", dts, Configuracion.Claves.Conexion("Proveeduria"))
            Case "Cheques/Transferencias"
                cFunciones.Llenar_Tabla_Generico("select top 1 id_cheque from  dbo.Cheques where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "CHEQUES"
                cFunciones.Llenar_Tabla_Generico("select top 1 id_cheque from  dbo.Cheques where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "Depositos"
                cFunciones.Llenar_Tabla_Generico("select top 1  Id_Deposito from dbo.Deposito where asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "Ajustes Bancarios"
                cFunciones.Llenar_Tabla_Generico("select top 1 Id_Ajuste FROM AjusteBancario WHERE Asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "AJUSTE CRE"
                cFunciones.Llenar_Tabla_Generico("select top 1 Id_Ajuste FROM AjusteBancario WHERE Asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "AJUSTE DEB"
                cFunciones.Llenar_Tabla_Generico("select top 1 Id_Ajuste FROM AjusteBancario WHERE Asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
            Case "Transferencias Bancarias"
                cFunciones.Llenar_Tabla_Generico("select top 1 Id_Transferencia from dbo.TransferenciasBancarias where Num_Asiento = '" & Me.lblAsiento.Text & "'", dts, GetSetting("SeeSOFT", "Bancos", "Conexion"))
        End Select

        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return 0
        End If
        Return 0
    End Function

    Private Sub GridView2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        Try
            Dim MODULO As String = Me.GETMODULO
            Dim ID As Double = Me.GetIdentificadores(MODULO)
            Dim Documento As String = ""

            If MODULO = "Gastos" Or MODULO = "FACTURA GASTOS" Then
                If ID > 0 Then
                    Dim frm As New frmGasto(Me.usua)
					frm.Identificador = ID
					frm.ToolBar1.Visible = False
					frm.Label17.Visible = False
					frm.txtClave.Visible = False
					frm.TxtNombreUsuario.Visible = False

					BanderaGeneral.ACTUALIZO_ASIENTO2 = False
                    frm.ShowDialog()
                    If BanderaGeneral.ACTUALIZO_ASIENTO2 = True Then
                        RaiseEvent Actualiza()
                        CargaDatos()
                    End If
                End If
            End If

            If MODULO = "Cheques/Transferencias" Or MODULO = "CHEQUES" Then
                If ID > 0 Then
                    Dim frm As New FrmCheques(Me.usua)
                    frm.Id_Cheque = ID
                    BanderaGeneral.ACTUALIZO_ASIENTO2 = False
                    frm.ShowDialog()
                    If BanderaGeneral.ACTUALIZO_ASIENTO2 = True Then
                        RaiseEvent Actualiza()
                        CargaDatos()
                    End If
                End If
            End If

            '**************************************************************************
            '                               AQUI
            'agregar depositos, ajustes, transferencias
            '**************************************************************************
            If MODULO = "Depositos" Then
                If ID > 0 Then
                    Dim frm As New frmDepositos(Me.usua)
                    frm.modificar = True
                    frm.id_deposito = GetNumDocumento(MODULO)
                    frm.cuentabancaria = Me.Cuenta_Bancaria_Deposito(ID)
                    If frm.cuentabancaria <> "0" Then
                        BanderaGeneral.ACTUALIZO_ASIENTO2 = False
                        frm.ShowDialog()
                        If BanderaGeneral.ACTUALIZO_ASIENTO2 = True Then
                            RaiseEvent Actualiza()
                            CargaDatos()
                        End If
                    End If
                End If
            End If

            If MODULO = "Ajustes Bancarios" Or MODULO = "AJUSTE CRE" Or MODULO = "AJUSTE DEB" Then
                If ID > 0 Then
                    Dim frm As New frmAjusteCuenta(Me.usua)
                    frm.modificar = True
                    frm.id_ajuste = GetNumDocumento(MODULO)
                    frm.cuentabancaria = Me.Cuenta_Bancaria_Ajuste(ID)
                    If frm.cuentabancaria <> "0" Then
                        BanderaGeneral.ACTUALIZO_ASIENTO2 = False
                        frm.ShowDialog()
                        If BanderaGeneral.ACTUALIZO_ASIENTO2 = True Then
                            RaiseEvent Actualiza()
                            CargaDatos()
                        End If
                    End If
                End If
            End If

			If MODULO = "Transferencias Bancarias" Then
				If ID > 0 Then
					Dim frm As FrmTranferencias
					frm = New FrmTranferencias(Me.usua)
					frm.modificar = True
					frm.id_trans = ID
					BanderaGeneral.ACTUALIZO_ASIENTO2 = False
					frm.ShowDialog()
					If BanderaGeneral.ACTUALIZO_ASIENTO2 = True Then
						RaiseEvent Actualiza()
						CargaDatos()
					End If
				End If
			End If

			If MODULO = "ASIENTO CONTABLE" Then

				Dim frm As New FrmAsientos(usua)
				frm.NumAsiento = Me.lblAsiento.Text

				BanderaGeneral.ACTUALIZO_ASIENTO2 = False
					frm.ShowDialog()
					If BanderaGeneral.ACTUALIZO_ASIENTO2 = True Then
						RaiseEvent Actualiza()
						CargaDatos()
					End If

				End If

		Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Text)
        End Try
    End Sub

    Private Function Cuenta_Bancaria_Deposito(ByVal _id As String) As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT dbo.Cuentas_bancarias.Cuenta FROM dbo.Cuentas_bancarias INNER JOIN dbo.Deposito ON dbo.Cuentas_bancarias.Id_CuentaBancaria = dbo.Deposito.Id_CuentaBancaria  where dbo.Deposito.Id_Deposito = " & _id, dts, GetSetting("SeeSOFt", "bancos", "Conexion"))
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return "0"
        End If
    End Function

    Private Function Cuenta_Bancaria_Ajuste(ByVal _id As String) As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT dbo.Cuentas_bancarias.Cuenta FROM dbo.Cuentas_bancarias INNER JOIN dbo.AjusteBancario ON dbo.Cuentas_bancarias.Id_CuentaBancaria = dbo.AjusteBancario.Id_CuentaBancaria  where dbo.AjusteBancario.Id_Ajuste = " & _id, dts, GetSetting("SeeSOFt", "bancos", "Conexion"))
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return "0"
        End If
    End Function

    Private Sub frmAnaliticoDetallado_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.CargaDatos()
    End Sub
End Class
