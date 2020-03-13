Public Class frmAsientosIndividuales
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
    Friend WithEvents cboTipos As System.Windows.Forms.ComboBox
    Friend WithEvents dtpF1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpF2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Public WithEvents dsAs As Contabilidad.DsAsientos
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents adpAS As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents cnxConta As System.Data.SqlClient.SqlConnection
    Friend WithEvents adpASD As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents grbDiferencias As System.Windows.Forms.GroupBox
    Friend WithEvents grdAsiento As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvAsiento As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Asiento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Doc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Tipo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Fecha As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Obs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Diferencia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Cuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnReporteXAsiento As System.Windows.Forms.Button
    Friend WithEvents btnReporteXCuenta As System.Windows.Forms.Button
    Friend WithEvents btnRptResumen As System.Windows.Forms.Button
    Friend WithEvents chbReimprimir As System.Windows.Forms.CheckBox
    Friend WithEvents cboServidor As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents chbUnirServidor As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
	Friend WithEvents DataSetAsientos1 As DsAsientos
	Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAsientosIndividuales))
		Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo4 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo5 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo6 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Dim ColumnFilterInfo7 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo()
		Me.cboTipos = New System.Windows.Forms.ComboBox()
		Me.dtpF1 = New System.Windows.Forms.DateTimePicker()
		Me.dtpF2 = New System.Windows.Forms.DateTimePicker()
		Me.btnGenerar = New System.Windows.Forms.Button()
		Me.imgList = New System.Windows.Forms.ImageList(Me.components)
		Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
		Me.btnGuardar = New System.Windows.Forms.Button()
		Me.adpAS = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.cnxConta = New System.Data.SqlClient.SqlConnection()
		Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
		Me.adpASD = New System.Data.SqlClient.SqlDataAdapter()
		Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
		Me.grbDiferencias = New System.Windows.Forms.GroupBox()
		Me.grdAsiento = New DevExpress.XtraGrid.GridControl()
		Me.dsAs = New Contabilidad.DsAsientos()
		Me.grvAsiento = New DevExpress.XtraGrid.Views.Grid.GridView()
		Me.Asiento = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Doc = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Tipo = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Fecha = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Obs = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Diferencia = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.Cuenta = New DevExpress.XtraGrid.Columns.GridColumn()
		Me.btnReporteXAsiento = New System.Windows.Forms.Button()
		Me.btnReporteXCuenta = New System.Windows.Forms.Button()
		Me.btnRptResumen = New System.Windows.Forms.Button()
		Me.chbReimprimir = New System.Windows.Forms.CheckBox()
		Me.cboServidor = New System.Windows.Forms.ComboBox()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TabControl1 = New System.Windows.Forms.TabControl()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.TabPage2 = New System.Windows.Forms.TabPage()
		Me.chbUnirServidor = New System.Windows.Forms.CheckBox()
		Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
		Me.DataSetAsientos1 = New Contabilidad.DsAsientos()
		Me.grbDiferencias.SuspendLayout()
		CType(Me.grdAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.dsAs, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.grvAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox1.SuspendLayout()
		Me.TabControl1.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		Me.TabPage2.SuspendLayout()
		CType(Me.DataSetAsientos1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'cboTipos
		'
		Me.cboTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboTipos.Items.AddRange(New Object() {"----", "CHEQUES", "DEPOSITOS", "AJUSTES BANC", "TRANSF ENTRE CUENTAS", "---- ", "FACTURAS GASTOS", "FACTURAS INVENTARIO", "AJUSTES A CXP", "DEVOLUCION COMPRAS", "AJUSTE INVENTARIO", "---- ", "FACTURAS VENTAS", "COSTO VENTAS", "AJUSTES A CXC", "ABONOS A CXC", "---"})
		Me.cboTipos.Location = New System.Drawing.Point(5, 38)
		Me.cboTipos.Name = "cboTipos"
		Me.cboTipos.Size = New System.Drawing.Size(320, 21)
		Me.cboTipos.TabIndex = 0
		'
		'dtpF1
		'
		Me.dtpF1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpF1.Location = New System.Drawing.Point(5, 62)
		Me.dtpF1.Name = "dtpF1"
		Me.dtpF1.Size = New System.Drawing.Size(96, 20)
		Me.dtpF1.TabIndex = 1
		'
		'dtpF2
		'
		Me.dtpF2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.dtpF2.Location = New System.Drawing.Point(109, 62)
		Me.dtpF2.Name = "dtpF2"
		Me.dtpF2.Size = New System.Drawing.Size(96, 20)
		Me.dtpF2.TabIndex = 2
		'
		'btnGenerar
		'
		Me.btnGenerar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnGenerar.ImageIndex = 0
		Me.btnGenerar.ImageList = Me.imgList
		Me.btnGenerar.Location = New System.Drawing.Point(332, 14)
		Me.btnGenerar.Name = "btnGenerar"
		Me.btnGenerar.Size = New System.Drawing.Size(75, 72)
		Me.btnGenerar.TabIndex = 3
		Me.btnGenerar.Text = "Generar"
		Me.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'imgList
		'
		Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.imgList.TransparentColor = System.Drawing.Color.Transparent
		Me.imgList.Images.SetKeyName(0, "Gear.png")
		Me.imgList.Images.SetKeyName(1, "HD.png")
		Me.imgList.Images.SetKeyName(2, "DiagPackage_dll_01_1310.png")
		'
		'CrystalReportViewer1
		'
		Me.CrystalReportViewer1.ActiveViewIndex = -1
		Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
		Me.CrystalReportViewer1.Location = New System.Drawing.Point(8, 16)
		Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
		Me.CrystalReportViewer1.SelectionFormula = ""
		Me.CrystalReportViewer1.Size = New System.Drawing.Size(547, 220)
		Me.CrystalReportViewer1.TabIndex = 4
		Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
		'
		'btnGuardar
		'
		Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.btnGuardar.ImageIndex = 1
		Me.btnGuardar.ImageList = Me.imgList
		Me.btnGuardar.Location = New System.Drawing.Point(413, 14)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(75, 72)
		Me.btnGuardar.TabIndex = 5
		Me.btnGuardar.Text = "Guardar"
		Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		'
		'adpAS
		'
		Me.adpAS.DeleteCommand = Me.SqlDeleteCommand1
		Me.adpAS.InsertCommand = Me.SqlInsertCommand1
		Me.adpAS.SelectCommand = Me.SqlSelectCommand1
		Me.adpAS.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
		Me.adpAS.UpdateCommand = Me.SqlUpdateCommand1
		'
		'SqlDeleteCommand1
		'
		Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
		Me.SqlDeleteCommand1.Connection = Me.cnxConta
		Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
		'
		'cnxConta
		'
		Me.cnxConta.ConnectionString = "Data Source=192.168.100.11;Initial Catalog=Contabilidad;Integrated Security=True"
		Me.cnxConta.FireInfoMessageEventOnUserErrors = False
		'
		'SqlInsertCommand1
		'
		Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
		Me.SqlInsertCommand1.Connection = Me.cnxConta
		Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
		'
		'SqlSelectCommand1
		'
		Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
		Me.SqlSelectCommand1.Connection = Me.cnxConta
		'
		'SqlUpdateCommand1
		'
		Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
		Me.SqlUpdateCommand1.Connection = Me.cnxConta
		Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
		'
		'adpASD
		'
		Me.adpASD.DeleteCommand = Me.SqlDeleteCommand2
		Me.adpASD.InsertCommand = Me.SqlInsertCommand2
		Me.adpASD.SelectCommand = Me.SqlSelectCommand2
		Me.adpASD.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
		Me.adpASD.UpdateCommand = Me.SqlUpdateCommand2
		'
		'SqlDeleteCommand2
		'
		Me.SqlDeleteCommand2.CommandText = "DELETE FROM [DetallesAsientosContable] WHERE (([ID_Detalle] = @Original_ID_Detall" &
	"e))"
		Me.SqlDeleteCommand2.Connection = Me.cnxConta
		Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing)})
		'
		'SqlInsertCommand2
		'
		Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
		Me.SqlInsertCommand2.Connection = Me.cnxConta
		Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 0, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 0, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 0, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 0, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 0, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 0, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 0, "Tipocambio")})
		'
		'SqlSelectCommand2
		'
		Me.SqlSelectCommand2.CommandText = "SELECT        ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, D" &
	"escripcionAsiento, Tipocambio" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            DetallesAsientosContable"
		Me.SqlSelectCommand2.Connection = Me.cnxConta
		'
		'SqlUpdateCommand2
		'
		Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
		Me.SqlUpdateCommand2.Connection = Me.cnxConta
		Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 0, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 0, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 0, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 0, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 0, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 0, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 0, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 0, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
		'
		'grbDiferencias
		'
		Me.grbDiferencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grbDiferencias.Controls.Add(Me.grdAsiento)
		Me.grbDiferencias.Location = New System.Drawing.Point(8, 8)
		Me.grbDiferencias.Name = "grbDiferencias"
		Me.grbDiferencias.Size = New System.Drawing.Size(567, 242)
		Me.grbDiferencias.TabIndex = 7
		Me.grbDiferencias.TabStop = False
		Me.grbDiferencias.Text = "Vista Previa"
		'
		'grdAsiento
		'
		Me.grdAsiento.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.grdAsiento.DataMember = "AsientosContables"
		Me.grdAsiento.DataSource = Me.dsAs
		'
		'
		'
		Me.grdAsiento.EmbeddedNavigator.Name = ""
		Me.grdAsiento.Location = New System.Drawing.Point(8, 16)
		Me.grdAsiento.MainView = Me.grvAsiento
		Me.grdAsiento.Name = "grdAsiento"
		Me.grdAsiento.Size = New System.Drawing.Size(551, 220)
		Me.grdAsiento.TabIndex = 0
		Me.grdAsiento.Text = "GridControl1"
		'
		'dsAs
		'
		Me.dsAs.DataSetName = "DataSetAsientos"
		Me.dsAs.Locale = New System.Globalization.CultureInfo("es-ES")
		Me.dsAs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'grvAsiento
		'
		Me.grvAsiento.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Asiento, Me.Doc, Me.Tipo, Me.Fecha, Me.Obs, Me.Diferencia, Me.Cuenta})
		Me.grvAsiento.Name = "grvAsiento"
		Me.grvAsiento.OptionsView.ShowFilterPanel = False
		Me.grvAsiento.OptionsView.ShowGroupPanel = False
		'
		'Asiento
		'
		Me.Asiento.Caption = "Asiento"
		Me.Asiento.FieldName = "NumAsiento"
		Me.Asiento.FilterInfo = ColumnFilterInfo1
		Me.Asiento.Name = "Asiento"
		Me.Asiento.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.Asiento.VisibleIndex = 0
		'
		'Doc
		'
		Me.Doc.Caption = "Doc"
		Me.Doc.FieldName = "NumDoc"
		Me.Doc.FilterInfo = ColumnFilterInfo2
		Me.Doc.Name = "Doc"
		Me.Doc.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.Doc.VisibleIndex = 2
		'
		'Tipo
		'
		Me.Tipo.Caption = "Modulo"
		Me.Tipo.FieldName = "Modulo"
		Me.Tipo.FilterInfo = ColumnFilterInfo3
		Me.Tipo.Name = "Tipo"
		Me.Tipo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.Tipo.VisibleIndex = 1
		'
		'Fecha
		'
		Me.Fecha.Caption = "Fecha"
		Me.Fecha.FieldName = "Fecha"
		Me.Fecha.FilterInfo = ColumnFilterInfo4
		Me.Fecha.Name = "Fecha"
		Me.Fecha.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.Fecha.VisibleIndex = 3
		'
		'Obs
		'
		Me.Obs.Caption = "Obs"
		Me.Obs.FieldName = "Observaciones"
		Me.Obs.FilterInfo = ColumnFilterInfo5
		Me.Obs.Name = "Obs"
		Me.Obs.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.[ReadOnly]) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
			Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
		Me.Obs.VisibleIndex = 4
		'
		'Diferencia
		'
		Me.Diferencia.Caption = "Dif."
		Me.Diferencia.FieldName = "Dif"
		Me.Diferencia.FilterInfo = ColumnFilterInfo6
		Me.Diferencia.Name = "Diferencia"
		Me.Diferencia.SortIndex = 0
		Me.Diferencia.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
		Me.Diferencia.VisibleIndex = 5
		'
		'Cuenta
		'
		Me.Cuenta.Caption = "Cuenta"
		Me.Cuenta.FieldName = "Cuenta"
		Me.Cuenta.FilterInfo = ColumnFilterInfo7
		Me.Cuenta.Name = "Cuenta"
		Me.Cuenta.VisibleIndex = 6
		'
		'btnReporteXAsiento
		'
		Me.btnReporteXAsiento.Location = New System.Drawing.Point(494, 14)
		Me.btnReporteXAsiento.Name = "btnReporteXAsiento"
		Me.btnReporteXAsiento.Size = New System.Drawing.Size(88, 24)
		Me.btnReporteXAsiento.TabIndex = 8
		Me.btnReporteXAsiento.Text = "Rpt x Asiento"
		Me.btnReporteXAsiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnReporteXCuenta
		'
		Me.btnReporteXCuenta.Location = New System.Drawing.Point(494, 38)
		Me.btnReporteXCuenta.Name = "btnReporteXCuenta"
		Me.btnReporteXCuenta.Size = New System.Drawing.Size(88, 24)
		Me.btnReporteXCuenta.TabIndex = 9
		Me.btnReporteXCuenta.Text = "Rpt x Cuenta"
		Me.btnReporteXCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'btnRptResumen
		'
		Me.btnRptResumen.Location = New System.Drawing.Point(494, 62)
		Me.btnRptResumen.Name = "btnRptResumen"
		Me.btnRptResumen.Size = New System.Drawing.Size(88, 24)
		Me.btnRptResumen.TabIndex = 10
		Me.btnRptResumen.Text = "Rpt Resumen"
		Me.btnRptResumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'chbReimprimir
		'
		Me.chbReimprimir.Location = New System.Drawing.Point(205, 62)
		Me.chbReimprimir.Name = "chbReimprimir"
		Me.chbReimprimir.Size = New System.Drawing.Size(104, 24)
		Me.chbReimprimir.TabIndex = 11
		Me.chbReimprimir.Text = "Re-imprimir"
		'
		'cboServidor
		'
		Me.cboServidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cboServidor.Items.AddRange(New Object() {"SUPER LA PARADA", "SUPER COMUNIDAD"})
		Me.cboServidor.Location = New System.Drawing.Point(109, 11)
		Me.cboServidor.Name = "cboServidor"
		Me.cboServidor.Size = New System.Drawing.Size(216, 21)
		Me.cboServidor.TabIndex = 14
		Me.cboServidor.Visible = False
		'
		'GroupBox1
		'
		Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.GroupBox1.Controls.Add(Me.CrystalReportViewer1)
		Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(563, 242)
		Me.GroupBox1.TabIndex = 15
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Vista Previa"
		'
		'TabControl1
		'
		Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.TabControl1.Controls.Add(Me.TabPage1)
		Me.TabControl1.Controls.Add(Me.TabPage2)
		Me.TabControl1.Location = New System.Drawing.Point(8, 92)
		Me.TabControl1.Name = "TabControl1"
		Me.TabControl1.SelectedIndex = 0
		Me.TabControl1.Size = New System.Drawing.Size(586, 279)
		Me.TabControl1.TabIndex = 16
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.grbDiferencias)
		Me.TabPage1.Location = New System.Drawing.Point(4, 22)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Size = New System.Drawing.Size(578, 253)
		Me.TabPage1.TabIndex = 0
		Me.TabPage1.Text = "Generar"
		'
		'TabPage2
		'
		Me.TabPage2.Controls.Add(Me.GroupBox1)
		Me.TabPage2.Location = New System.Drawing.Point(4, 22)
		Me.TabPage2.Name = "TabPage2"
		Me.TabPage2.Size = New System.Drawing.Size(578, 253)
		Me.TabPage2.TabIndex = 1
		Me.TabPage2.Text = "Vista Previa Reportes"
		'
		'chbUnirServidor
		'
		Me.chbUnirServidor.AutoSize = True
		Me.chbUnirServidor.Location = New System.Drawing.Point(5, 11)
		Me.chbUnirServidor.Name = "chbUnirServidor"
		Me.chbUnirServidor.Size = New System.Drawing.Size(99, 17)
		Me.chbUnirServidor.TabIndex = 17
		Me.chbUnirServidor.Text = "Incluir Servidor:"
		Me.chbUnirServidor.UseVisualStyleBackColor = True
		Me.chbUnirServidor.Visible = False
		'
		'ProgressBar1
		'
		Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ProgressBar1.Location = New System.Drawing.Point(8, 373)
		Me.ProgressBar1.Maximum = 30
		Me.ProgressBar1.Name = "ProgressBar1"
		Me.ProgressBar1.Size = New System.Drawing.Size(582, 23)
		Me.ProgressBar1.Step = 1
		Me.ProgressBar1.TabIndex = 8
		'
		'DataSetAsientos1
		'
		Me.DataSetAsientos1.DataSetName = "DataSetAsientos"
		Me.DataSetAsientos1.Locale = New System.Globalization.CultureInfo("es-ES")
		Me.DataSetAsientos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'frmAsientosIndividuales
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
		Me.ClientSize = New System.Drawing.Size(595, 400)
		Me.Controls.Add(Me.ProgressBar1)
		Me.Controls.Add(Me.chbUnirServidor)
		Me.Controls.Add(Me.TabControl1)
		Me.Controls.Add(Me.cboServidor)
		Me.Controls.Add(Me.chbReimprimir)
		Me.Controls.Add(Me.btnRptResumen)
		Me.Controls.Add(Me.btnReporteXCuenta)
		Me.Controls.Add(Me.btnReporteXAsiento)
		Me.Controls.Add(Me.btnGuardar)
		Me.Controls.Add(Me.btnGenerar)
		Me.Controls.Add(Me.dtpF2)
		Me.Controls.Add(Me.dtpF1)
		Me.Controls.Add(Me.cboTipos)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MinimumSize = New System.Drawing.Size(597, 427)
		Me.Name = "frmAsientosIndividuales"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Asientos Individuales"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.grbDiferencias.ResumeLayout(False)
		CType(Me.grdAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.dsAs, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.grvAsiento, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox1.ResumeLayout(False)
		Me.TabControl1.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage2.ResumeLayout(False)
		CType(Me.DataSetAsientos1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

#End Region

	Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        sp_GENERAR()
    End Sub

    Dim conexion As String

    Sub sp_GENERAR()

        Me.btnGenerar.Text = "Espere..."
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Refresh()


        If Not Me.chbUnirServidor.Checked Then
            Me.conexion = "Conexion"
        Else
            If Me.cboServidor.Text.Equals("SUPER LA PARADA") Then
                Me.conexion = "Empresa1"
            ElseIf Me.cboServidor.Text.Equals("SUPER COMUNIDAD") Then
                Me.conexion = "Empresa2"
            End If
        End If
      

        Try
            Me.dsAs.DetallesAsientosContable.Clear()
            Me.dsAs.AsientosContables.Clear()

            If fn_validaGenerar() Then

                sp_GenerarAsiento(Me.cboTipos.Text, dtpF1.Value, dtpF2.Value)
                Me.sp_imprimirPorAsiento()
            End If
            If dsAs.AsientosContables.Count > 0 Then
                btnGuardar.Enabled = True

            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly)

        End Try

        Me.btnGenerar.Text = "Generar"
        Me.btnGenerar.Enabled = True
        Me.btnGenerar.Refresh()

    End Sub
    Sub sp_reimprimir(ByVal _ptipo As String, ByVal _pF1 As Date, ByVal _pF2 As Date)
        Me.TabControl1.SelectedIndex = 1
        Dim modulo As String = ""
        Dim prefijo As String = ""
        Select Case _ptipo
            Case "CHEQUES"
                modulo = "a.Modulo LIKE '%CHEQUES%'" : prefijo = "BCO"
            Case "DEPOSITOS"
                modulo = "a.Modulo LIKE '%Depositos%'" : prefijo = "BCO"
            Case "AJUSTES BANC"
                modulo = "a.Modulo = 'AJUSTE DEB' OR a.Modulo = 'AJUSTE CRE' OR Modulo = 'Ajustes Bancarios'" : prefijo = "BCO"
            Case "TRANSF ENTRE CUENTAS"
                modulo = "a.Modulo = 'TRANS ENTRE BANC'" : prefijo = "BCO"
            Case "FACTURAS GASTOS"
                modulo = "a.Modulo = 'FACTURA GASTOS'" : prefijo = "CXP"
            Case "FACTURAS INVENTARIO"
                modulo = "a.Modulo = 'FACTURA INV'" : prefijo = "CXP"
            Case "AJUSTES A CXP"
                modulo = "a.Modulo = 'AJUSTE CXP CRE' OR a.Modulo = 'AJUSTE CXP DEB'" : prefijo = "CXP"

            Case "AJUSTES A CXC"
                modulo = "a.Modulo = 'AJUSTE CXC CRE' OR a.Modulo = 'AJUSTE CXC DEB'" : prefijo = "CXC"

            Case "FACTURAS VENTAS"
                modulo = "a.Modulo = 'FACTURACION' OR a.Modulo = 'FACTURA VENTAS' OR a.Modulo = 'FACTURACION MAN' OR a.Modulo = 'FACTURAS VENTAS'"
                'modulo = "a.Modulo LIKE '%%%'"
                prefijo = "ING"
            Case "FACTURAS VENTAS"
                modulo = "a.Modulo = 'FACTURACION' OR a.Modulo = 'FACTURA VENTAS' OR a.Modulo = 'FACTURACION MAN' OR a.Modulo = 'FACTURAS VENTAS'"
                'modulo = "a.Modulo LIKE '%%%'"
                prefijo = "ING"
            Case "COSTO VENTAS"
                modulo = "a.Modulo = 'COSTO VENTAS' "
                'modulo = "a.Modulo LIKE '%%%'"
                prefijo = "COS"
            Case "DEVOLUCION COMPRAS"
                modulo = "a.Modulo = 'DEV COM ' "
                'modulo = "a.Modulo LIKE '%%%'"
                prefijo = "DEV"
            Case "AJUSTE INVENTARIO"
                modulo = "a.Modulo = 'AJUST INV ' "
                'modulo = "a.Modulo LIKE '%%%'"
                prefijo = "INV"

            Case "PREPAGOS"
                modulo = "a.Modulo = 'Prepagos'" : prefijo = "CXC"
            Case "AJUSTES DE SALDOS MENORES"
                modulo = "a.Modulo = 'AJUSTE DE SALDO MENOR'" : prefijo = "CXC"
        End Select
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "Select a.* From AsientosContables AS a Where a.Anulado = 0 AND (" & modulo & ") AND  a.NumAsiento LIKE '" & prefijo & "%' AND dbo.DateOnly(a.Fecha) >= @F1 AND dbo.DateOnly(a.Fecha) <= @F2"
        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, Me.dsAs.AsientosContables, Configuracion.Claves.Conexion("Contabilidad"))
        cmd.CommandText = "Select d.* From AsientosContables AS a INNER JOIN  DetallesAsientosContable AS d ON a.NumAsiento = d.NumAsiento Where a.Anulado = 0 AND (" & modulo & ") AND  a.NumAsiento LIKE '" & prefijo & "%' AND dbo.DateOnly(a.Fecha) >= @F1 AND dbo.DateOnly(a.Fecha) <= @F2"
        cFunciones.Llenar_Tabla_Generico(cmd, Me.dsAs.DetallesAsientosContable, Configuracion.Claves.Conexion("Contabilidad"))
        Me.sp_reevaluarDife()


    End Sub
    Sub sp_reevaluarDife()
        For i As Integer = 0 To Me.dsAs.AsientosContables.Count - 1
            Me.BindingContext(Me.dsAs, "AsientosContables").Position = i
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next

    End Sub
    Dim rtp As Object
    Sub sp_imprimirPorAsiento()

        rtp = New rptPreviaAsiento
        rtp.SetDataSource(Me.dsAs)
        Me.CrystalReportViewer1.ReportSource = rtp
        Me.CrystalReportViewer1.Show()

    End Sub
    Sub sp_imprimirPorCuenta()
        rtp = New rptPreviaAsientoGlobal
        rtp.SetDataSource(Me.dsAs)
        Me.CrystalReportViewer1.ReportSource = rtp
        Me.CrystalReportViewer1.Show()

    End Sub
    Sub sp_imprimirResumen()
        rtp = New rptPreviaAsientoResumen
        rtp.SetDataSource(Me.dsAs)
        Me.CrystalReportViewer1.ReportSource = rtp
        Me.CrystalReportViewer1.Show()

    End Sub
    Function fn_validaGenerar() As Boolean
        If dtpF1.Value <= dtpF2.Value And Me.cboTipos.SelectedIndex >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function
    Dim mayo As Integer = 0

    Sub sp_GenerarAsiento(ByVal _ptipo As String, ByVal _pF1 As Date, ByVal _pF2 As Date)
        If Me.chbReimprimir.Checked Then
            Me.sp_reimprimir(_ptipo, _pF1, _pF2)
            Exit Sub
        End If
        mayo = nummayorizado()
        Me.ProgressBar1.Value = 0
        Select Case _ptipo
            Case "CHEQUES"
                sp_GenerarAsientoCHEQUES(_pF1, _pF2)
            Case "DEPOSITOS"
                sp_GenerarAsientoDEPOSITOS(_pF1, _pF2)
            Case "AJUSTES BANC"
                sp_GenerarAsientoAJUSTEBANC(_pF1, _pF2)
            Case "TRANSF ENTRE CUENTAS"
                sp_GenerarAsientoTRANSFERENCIASBANC(_pF1, _pF2)
            Case "FACTURAS GASTOS"
                sp_GenerarAsientoFACTURASGASTOS(_pF1, _pF2)
            Case "FACTURAS INVENTARIO"
                sp_GenerarAsientoFACTURASINVENTARIO(_pF1, _pF2)
            Case "AJUSTES A CXP"
                sp_GenerarAsientoAJUSTECXP(_pF1, _pF2)
            Case "AJUSTES A CXC"
                sp_GenerarAsientoAJUSTECXC(_pF1, _pF2)
            Case "FACTURAS VENTAS"
                sp_GenerarAsientoFACTURASVentasFelipe(_pF1, _pF2)
            Case "COSTO VENTAS"
                sp_GenerarAsientoCostoVentaFelipe(_pF1, _pF2)
            Case "ABONOS A CXC"
                sp_GenerarAsientoAbonosCXC(_pF1, _pF2)
            Case "DEVOLUCION COMPRAS"
                sp_GenerarAsientoDEVCOMPRAS(_pF1, _pF2)
            Case "AJUSTE INVENTARIO"
                sp_GenerarAsientoAjusteINV(_pF1, _pF2)

        End Select
        Me.ProgressBar1.Value = 0
    End Sub
    Sub sp_GenerarAsientoAbonosCXC(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT     op.id, op.Documento, op.TipoDocumento, op.MontoPago, op.FormaPago, op.Denominacion, op.Usuario, op.Nombre, op.CodMoneda, " & _
                 "     op.Nombremoneda, op.TipoCambio, op.Fecha, op.Numapertura, op.Vuelto, a.Nombre_Cliente, a.Id_Recibo, a.Num_Recibo, a.Observaciones,  a.Monto " & _
                 " FROM         OpcionesDePago AS op INNER JOIN abonoccobrar AS a ON op.Documento = a.Num_Recibo WHERE (op.Fecha >= @F1) AND (op.TipoDocumento = 'ABO') AND (op.Fecha <= @F2) AND (a.Contabilizado = 0) AND (a.Anula = 0 )"
        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion)

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones
        Dim stt As New DataTable

        'Buscar Información de Credito
        Dim cCre As String = ""
        Dim cDCre As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCuentaCobrar ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cCre = stt.Rows(0).Item("CuentaContable")
            cDCre = stt.Rows(0).Item("Descripcion")
        End If


        'Buscar Información de Pago de Efectivo.
        Dim cEfe As String = ""
        Dim cDEfe As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCaja ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cEfe = stt.Rows(0).Item("CuentaContable")
            cDEfe = stt.Rows(0).Item("Descripcion")
        End If


        'Buscar Información de Pago en Tarjeta.
        Dim cTar As String = ""
        Dim cDTar As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT     CuentaCXC, NombreCXC FROM         TipoTarjeta", stt, Configuracion.Claves.Conexion("SEEPOS"))
        If stt.Rows.Count > 0 Then
            cTar = stt.Rows(0).Item("CuentaCXC")
            cDTar = stt.Rows(0).Item("NombreCXC")
        End If

        'Buscar el period de trabajo
        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0

        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "FACTURA VENTAS"

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "CXC")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("Id_Recibo")
                .Current("NumDoc") = dt.Rows(ic).Item("Num_Recibo")
                .Current("Beneficiario") = dt.Rows(ic).Item("Nombre_Cliente")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = Now
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = 0
                .Current("Modulo") = modulo
                .Current("Observaciones") = "Abono en " & dt.Rows(ic).Item("FormaPago") & " " & dt.Rows(ic).Item("Observaciones")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = 1
                'TIPO DE CAMBIO DEL DIA
                tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()

                'CUENTA DE INGRESO
                GuardaAsientoDetalle(dt.Rows(ic).Item("MontoPago"), False, True, cCre, cDCre, tc)

                If dt.Rows(ic).Item("FormaPago").Equals("EFE") Then
                    GuardaAsientoDetalle(dt.Rows(ic).Item("MontoPago") * dt.Rows(ic).Item("TipoCambio"), True, False, cEfe, cDEfe, tc)

                End If
                If dt.Rows(ic).Item("FormaPago").Equals("TAR") Then
                    GuardaAsientoDetalle(dt.Rows(ic).Item("MontoPago") * dt.Rows(ic).Item("TipoCambio"), True, False, cTar, cDTar, tc)

                End If

            End With
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next
    End Sub
    'Sub sp_GenerarAsientoAJUSTEMENOR(ByVal _pF1 As Date, ByVal _pF2 As Date)
    '    Dim dt As New DataTable
    '    Dim cmd As New SqlClient.SqlCommand
    '    cmd.CommandText = "SELECT     m.Id_Movimiento AS ID, m.TipoDoc, m.Fecha, m.Anulado, m.Id_Creador, m.Id_Cliente, m.Monto, m.Observaciones, m.NoDocumento AS Documento, m.CodMoneda,  m.TipoCambioDolar, m.Id_DepositoEvento, c.Nombre, c.CuentaContableCxCColon AS CC, c.DescripcionCCxCColon AS DCC, c.CuentaContableCxCDolar AS CD, c.DescripcionCCxCDolar AS DCD FROM         tb_MovimientoCXC AS m INNER JOIN  tb_Clientes AS c ON m.Id_Cliente = c.Id" & _
    '    " WHERE m.Anulado = 0 AND  m.Contabilizado = 0 AND  ((m.TipoDoc = 'AMD') OR (m.TipoDoc = 'AMC')) AND (CAST(m.Fecha AS DATE)>= @F1 AND CAST(m.Fecha AS DATE) <= @F2)"

    '    cmd.Parameters.Add("@F1", _pF1.Date)
    '    cmd.Parameters.Add("@F2", _pF2.Date)
    '    cFunciones.Llenar_Tabla_Generico(cmd, dt,Configuracion.Claves.Conexion(conexion))

    '    If dt.Rows.Count = 0 Then
    '        MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OKOnly)
    '        Exit Sub

    '    End If
    '    Dim fx As New cFunciones

    '    Dim periodo As String = fx.BuscaPeriodo(_pF1)
    '    Dim tc As Double = 0
    '    For ic As Integer = 0 To dt.Rows.Count - 1
    '        Dim modulo As String = "AJUSTE DE SALDO MENOR"

    '        With Me.BindingContext(Me.dsAs, "AsientosContables")
    '            .AddNew()
    '            .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "CXC")
    '            .Current("Fecha") = dt.Rows(ic).Item("Fecha")
    '            .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
    '            .Current("NumDoc") = dt.Rows(ic).Item("Documento")
    '            .Current("Beneficiario") = dt.Rows(ic).Item("TipoDoc") & ": " & dt.Rows(ic).Item("Documento") & "  Cliente:  " & dt.Rows(ic).Item("Nombre")
    '            .Current("TipoDoc") = 0
    '            .Current("Accion") = "AUT"
    '            .Current("Anulado") = 0
    '            .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
    '            .Current("Mayorizado") = False
    '            .Current("Periodo") = periodo
    '            .Current("NumMayorizado") = 0
    '            .Current("Modulo") = modulo
    '            .Current("Observaciones") = modulo & ". " & dt.Rows(ic).Item("Observaciones") & " ID: " & dt.Rows(ic).Item("Id_DepositoEvento") & "  Cliente:  " & dt.Rows(ic).Item("Nombre") & " " & dt.Rows(ic).Item("TipoDoc")
    '            .Current("NombreUsuario") = Usuario.Nombre
    '            .Current("TotalDebe") = 0
    '            .Current("TotalHaber") = 0
    '            .Current("CodMoneda") = dt.Rows(ic).Item("CodMoneda")
    '            tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
    '            .Current("TipoCambio") = tc
    '            .EndCurrentEdit()

    '            Dim sql As String = "SELECT      IdDocVinc, MontoVinculo, TipoDocVinc, MontoMovimiento, FDoc, CD FROM vs_VinculoCxcDocs WHERE (IdDocVinc = " & dt.Rows(ic).Item("Id_DepositoEvento") & ") AND (TipoDocVinc = N'REC') AND (TipoDoc = N'DEB' OR TipoDoc = 'FAC')"

    '            'LINEA CUENTA DEL CLIENTE ACTIVO

    '            If dt.Rows(ic).Item("TipoDoc") = "AMC" Then
    '                If dt.Rows(ic).Item("CodMoneda") = 1 Then 'COLONES
    '                    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CC"), dt.Rows(ic).Item("DCC"), tc)
    '                Else
    '                    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CD"), dt.Rows(ic).Item("DCD"), tc)
    '                End If


    '            End If


    '            If dt.Rows(ic).Item("TipoDoc") = "AMD" Then
    '                Dim dtAMD As New DataTable
    '                cFunciones.Llenar_Tabla_Generico(sql, dtAMD, Configuracion.Claves.Conexion("SEEPOS"))
    '                If dtAMD.Rows(0).Item("CD") = 1 Then
    '                    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CC"), dt.Rows(ic).Item("DCC"), tc)
    '                Else
    '                    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CD"), dt.Rows(ic).Item("DCD"), tc)
    '                End If
    '            End If



    '            If dt.Rows(ic).Item("TipoDoc") = "AMD" Then
    '                Dim _dt As New DataTable
    '                cmd.CommandText = "SELECT   SettingCuentaContable.IdIngresoAjCXCMenor, CuentaContable.CuentaContable AS CC, CuentaContable.Descripcion AS NCC " & _
    '                                    " FROM  SettingCuentaContable INNER JOIN " & _
    '                                    " CuentaContable ON SettingCuentaContable.IdIngresoAjCXCMenor = CuentaContable.id"
    '                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion("Contabilidad"))
    '                If _dt.Rows.Count = 0 Then
    '                    MsgBox("Registro Incompleto " & dt.Rows(ic).Item("Documento"), MsgBoxStyle.OKOnly)
    '                    Exit For
    '                End If
    '                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, _dt.Rows(0).Item("CC"), _dt.Rows(0).Item("NCC"), tc)
    '            Else
    '                Dim _dt As New DataTable
    '                cmd.CommandText = "SELECT   SettingCuentaContable.IdPerdidaAjCXCMenor, CuentaContable.CuentaContable AS CC, CuentaContable.Descripcion AS NCC " & _
    '                                    " FROM  SettingCuentaContable INNER JOIN " & _
    '                                    " CuentaContable ON SettingCuentaContable.IdPerdidaAjCXCMenor = CuentaContable.id"
    '                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion("Contabilidad"))
    '                If _dt.Rows.Count = 0 Then
    '                    MsgBox("Registro Incompleto " & dt.Rows(ic).Item("Documento"), MsgBoxStyle.OKOnly)
    '                    Exit For
    '                End If
    '                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, _dt.Rows(0).Item("CC"), _dt.Rows(0).Item("NCC"), tc)
    '            End If

    '            Me.sp_totalesAsiento(.Current("NumAsiento"))
    '        End With

    '    Next


    'End Sub
    Sub sp_totalesAsiento(ByVal numAs As String)
        Dim tDebe As Double = 0
        Dim tHaber As Double = 0
        For i As Integer = 0 To Me.dsAs.DetallesAsientosContable.Count - 1
            If Me.dsAs.DetallesAsientosContable(i).NumAsiento = numAs Then
                If Me.dsAs.DetallesAsientosContable(i).Debe Then
                    tDebe += Me.dsAs.DetallesAsientosContable(i).Monto
                Else
                    tHaber += Me.dsAs.DetallesAsientosContable(i).Monto
                End If
            End If
        Next
        'tDebe = Math.Round(tDebe, 2)
        'tHaber = Math.Round(tHaber, 2)
        BindingContext(Me.dsAs, "AsientosContables").Current("TotalDebe") = tDebe
        BindingContext(Me.dsAs, "AsientosContables").Current("TotalHaber") = tHaber
        BindingContext(Me.dsAs, "AsientosContables").Current("Dif") = tDebe - tHaber
        BindingContext(Me.dsAs, "AsientosContables").EndCurrentEdit()
    End Sub

    Private Function NumeroAsiento(ByVal _pF As Date, ByVal pos As Integer, ByVal PreFijo As String) As String
        Try
            Dim Fx As New cFunciones
            Dim asi As String = Fx.BuscaNumeroAsiento(PreFijo & "-" & Format(_pF.Month, "00") & Format(_pF.Date, "yy") & "-", pos)
            Return asi
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ""
    End Function
    Private Function nummayorizado() As Integer
        If Configuracion.Claves.Configuracion("NoMayorizacion").Equals("") Then
            Return 0

        End If
        Dim dt As New DataTable
        Dim dato As New DataTable
        Dim resultado As Integer = 0
        cFunciones.Llenar_Tabla_Generico("select * from sysobjects where name = 'Mayorizacion'", dt, Configuracion.Claves.Conexion("Contabilidad"))
        If dt.Rows.Count > 0 Then
            cFunciones.Llenar_Tabla_Generico("select isnull(max(nummayorizacion),0)+1 as num from Mayorizacion ", dato, Configuracion.Claves.Conexion("Contabilidad"))
            resultado = dato.Rows(0).Item(0)
        Else
            cFunciones.Llenar_Tabla_Generico("select isnull(max(nummayorizado),0)+1 as num from AsientosContables", dato, Configuracion.Claves.Conexion("Contabilidad"))
            resultado = dato.Rows(0).Item(0)
        End If
        Return resultado
    End Function

    Sub sp_GenerarAsientoCHEQUES(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT Id_Cheque AS Id, Num_Cheque AS Documento,Tipo, Cheques.Fecha, Portador, Monto, Conciliado, Anulado, Observaciones, Ced_Usuario, Contabilizado, Asiento,  Num_Conciliacion, MontoLetras, CodigoMoneda, TipoCambio,Id_PlanDePago, Id_abonocpagar, Cuentas_bancarias.NombreCuentaContable, Cuentas_bancarias.CuentaContable FROM Cheques INNER JOIN Cuentas_bancarias ON Cheques.Id_CuentaBancaria = Cuentas_bancarias.Id_CuentaBancaria WHERE (dbo.DateOnly(Cheques.Fecha) >= @F1 AND dbo.DateOnly(Cheques.Fecha) <= @F2) AND Num_Cheque > 0 AND Anulado = 0 AND Contabilizado = 0 AND Id_abonocpagar = 0 "
        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(Me.conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen cheques pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "BCO")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Documento")
                .Current("Beneficiario") = dt.Rows(ic).Item("Portador")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = "CHEQUES"
                .Current("Observaciones") = dt.Rows(ic).Item("Tipo") & " " & dt.Rows(ic).Item("Observaciones")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("CodigoMoneda")

                If dt.Rows(ic).Item("TipoCambio") = 1 Or dt.Rows(ic).Item("TipoCambio") = 0 Then
                    tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), True)
                Else
                    tc = dt.Rows(ic).Item("TipoCambio")
                End If
                .Current("TipoCambio") = tc
                .EndCurrentEdit()
                'PRIMERA LINEA DE CUENTA DEL BANCO
                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("NombreCuentaContable"), tc)


            End With
            Dim CUENTAbANCO As String = dt.Rows(ic).Item("CuentaContable")
            Dim str As String = "SELECT     p.CuentaContable, p.DescripcionCuentaContable, ch.Id_Cheque " &
             " FROM         abonocpagar AS a INNER JOIN " &
             "                      Bancos.dbo.Cheques AS ch ON a.Documento = ch.Num_Cheque INNER JOIN " &
             "                      Bancos.dbo.Cuentas_bancarias AS ct ON ch.Id_CuentaBancaria = ct.Id_CuentaBancaria AND a.CuentaBancaria = ct.Cuenta INNER JOIN " &
             "                      Proveedores AS p ON a.Cod_Proveedor = p.CodigoProv where ch.Id_Cheque = " & dt.Rows(ic).Item("ID")
            Dim cuentaBuena As New DataTable
            cFunciones.Llenar_Tabla_Generico(str, cuentaBuena, Configuracion.Claves.Conexion(conexion))

            'DETALLE DEL CHEQUE
            Dim _dt As New DataTable
            cmd.CommandText = "SELECT Cheques.Fecha, Cheques_Detalle.Descripcion_Mov, Cheques_Detalle.Cuenta_Contable, Cheques_Detalle.Monto,Cheques_Detalle.Nombre_Cuenta, Cheques_Detalle.Debe, Cheques_Detalle.Haber, Cheques_Detalle.Principal, Cheques_Detalle.Id_ChequeDet FROM Cheques INNER JOIN Cuentas_bancarias ON Cheques.Id_CuentaBancaria = Cuentas_bancarias.Id_CuentaBancaria INNER JOIN Cheques_Detalle ON Cheques.Id_Cheque = Cheques_Detalle.Id_Cheque WHERE   Cheques_Detalle.Id_Cheque  = " & dt.Rows(ic).Item("ID") & " AND  (Cheques_Detalle.Principal = 0) "

            cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))
            For id As Integer = 0 To _dt.Rows.Count - 1
                'LINEAS DETALLE
                If CUENTAbANCO <> _dt.Rows(id).Item("Cuenta_Contable") And dt.Rows(ic).Item("CuentaContable") <> _dt.Rows(id).Item("Cuenta_Contable") And cuentaBuena.Rows.Count > 0 Then

                    'If dt.Rows(ic).Item("CodigoMoneda") = 1 Then
                    GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), _dt.Rows(id).Item("Debe"), _dt.Rows(id).Item("Haber"), _dt.Rows(id).Item("Cuenta_Contable"), _dt.Rows(id).Item("Nombre_Cuenta"), tc)
                    'Else
                    '    GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), _dt.Rows(id).Item("Debe"), _dt.Rows(id).Item("Haber"), cuentaBuena.Rows(0).Item("CuentaContableDolar"), cuentaBuena.Rows(0).Item("DescripcionCuentaContableDolar"), tc)
                    'End If

                ElseIf CUENTAbANCO <> _dt.Rows(id).Item("Cuenta_Contable") And dt.Rows(ic).Item("CuentaContable") <> _dt.Rows(id).Item("Cuenta_Contable") And (CStr(dt.Rows(ic).Item("CuentaContable")).IndexOf("2-01-01-") <> 6 Or cuentaBuena.Rows.Count = 0) Then

                    GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), _dt.Rows(id).Item("Debe"), _dt.Rows(id).Item("Haber"), _dt.Rows(id).Item("Cuenta_Contable"), _dt.Rows(id).Item("Nombre_Cuenta"), tc)


                End If


            Next
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))

        Next


    End Sub

    Sub sp_GenerarAsientoDEPOSITOS(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT dbo.Deposito.Id_Deposito AS ID, dbo.Deposito.NumeroDocumento AS Documento, dbo.Deposito.Id_CuentaBancaria, dbo.Deposito.Fecha,dbo.Deposito.Monto, dbo.Deposito.Concepto, dbo.Deposito.Anulado, dbo.Deposito.Conciliado, dbo.Deposito.Contabilizado, dbo.Deposito.Ced_Usuario, dbo.Deposito.Asiento, dbo.Deposito.Num_Conciliacion, dbo.Deposito.CodigoMoneda, dbo.Deposito.TipoCambio, dbo.Cuentas_bancarias.CuentaContable, dbo.Cuentas_bancarias.NombreCuentaContable  FROM  dbo.Deposito INNER JOIN dbo.Cuentas_bancarias ON dbo.Deposito.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria WHERE     (dbo.DateOnly(dbo.Deposito.Fecha) >= @F1) AND (dbo.DateOnly(dbo.Deposito.Fecha) <= @F2) AND (dbo.Deposito.NumeroDocumento > 0) AND  (dbo.Deposito.Anulado = 0) AND (dbo.Deposito.Contabilizado = 0)"
        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            If CStr(dt.Rows(ic).Item("Concepto")).Equals("9849") Then
                Dim d As String = ""
            End If
            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "BCO")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Documento")
                .Current("Beneficiario") = " " & dt.Rows(ic).Item("Concepto")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = "Depositos"
                .Current("Observaciones") = dt.Rows(ic).Item("Concepto")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("CodigoMoneda")


                If dt.Rows(ic).Item("TipoCambio") = 1 Or dt.Rows(ic).Item("TipoCambio") = 0 Then
                    tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                Else
                    tc = dt.Rows(ic).Item("TipoCambio")
                End If
                .Current("TipoCambio") = tc
                .EndCurrentEdit()
                'PRIMERA LINEA DE CUENTA DEL BANCO
                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("NombreCuentaContable"), tc)
                Dim montoCXC As Double = 0
                Dim _dt As New DataTable
                '*********DEPOSITOS DE BANCOS ***********
                cmd.CommandText = "SELECT     dbo.Deposito_Detalle.CuentaContable, dbo.Deposito_Detalle.DescripcionMov, dbo.Deposito_Detalle.Monto, dbo.Deposito_Detalle.NombreCuenta, dbo.Deposito_Detalle.TipoCambio, dbo.Deposito_Detalle.MontoOtro FROM dbo.Deposito INNER JOIN dbo.Cuentas_bancarias ON dbo.Deposito.Id_CuentaBancaria = dbo.Cuentas_bancarias.Id_CuentaBancaria INNER JOIN dbo.Deposito_Detalle ON dbo.Deposito.Id_Deposito = dbo.Deposito_Detalle.Id_Deposito WHERE     (dbo.Deposito.NumeroDocumento > 0) AND (dbo.Deposito.Anulado = 0) AND (dbo.Deposito.Contabilizado = 0) AND (dbo.Deposito.Id_Deposito = " & dt.Rows(ic).Item("ID") & ")"
                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))
                If _dt.Rows.Count = 0 Then

                    '****************  NO TIENE DETALLE DEL ASIENTO EN EL DEPOSITO
                    Dim stt As New DataTable
                    If dt.Rows(ic).Item("CodigoMoneda") = 1 Then
                        cFunciones.Llenar_Tabla_Generico("SELECT    CuentaContable.CuentaContable, CuentaContable.Descripcion " &
                            " FROM  SettingCuentaContable INNER JOIN " &
                          " CuentaContable ON SettingCuentaContable.IdCuentaCobrar = CuentaContable.id", stt, Configuracion.Claves.Conexion("Contabilidad"))
                        If stt.Rows.Count > 0 Then
                            If montoCXC = 0 Then
                                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"),
                                         False,
                                            True,
                                            stt.Rows(0).Item("CuentaContable"), stt.Rows(0).Item("Descripcion"), tc)
                            Else
                                GuardaAsientoDetalle(montoCXC, False, True, stt.Rows(0).Item("CuentaContable"), stt.Rows(0).Item("Descripcion"), tc)
                            End If



                        End If
                    Else
                        cFunciones.Llenar_Tabla_Generico("SELECT    CuentaContable.CuentaContable, CuentaContable.Descripcion " &
                                                    " FROM  SettingCuentaContable INNER JOIN " &
                                                  " CuentaContable ON SettingCuentaContable.IdCuentaPorCobrarD  = CuentaContable.id", stt, Configuracion.Claves.Conexion("Contabilidad"))
                        If stt.Rows.Count > 0 Then
                            If montoCXC = 0 Then
                                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, stt.Rows(0).Item("CuentaContable"), stt.Rows(0).Item("Descripcion"), tc)
                            Else
                                GuardaAsientoDetalle(montoCXC, False, True, stt.Rows(0).Item("CuentaContable"), stt.Rows(0).Item("Descripcion"), tc)
                            End If

                        End If
                    End If
                    '***/
                Else

                    '****INCLUYE DETALLE DEL DEPOSITO
                    For id As Integer = 0 To _dt.Rows.Count - 1
                        'LINEAS DETALLE CXC
                        If montoCXC = 0 Then
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), False, True, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("NombreCuenta"), tc)
                        Else
                            GuardaAsientoDetalle(montoCXC, False, True, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("NombreCuenta"), tc)

                        End If

                    Next
                    '*************/
                End If

                Me.sp_totalesAsiento(.Current("NumAsiento"))


            End With




        Next


    End Sub

    Sub sp_GenerarAsientoAJUSTEBANC(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT     AjusteBancario.Id_Ajuste AS ID, AjusteBancario.Num_Ajuste as Documento, AjusteBancario.Numero_Docum, AjusteBancario.Fecha, AjusteBancario.Monto, AjusteBancario.Concepto, AjusteBancario.Anula, AjusteBancario.Conciliacion, AjusteBancario.Contabilizado, AjusteBancario.Asiento, AjusteBancario.Id_CuentaBancaria, AjusteBancario.Num_Conciliacion, AjusteBancario.Debito, AjusteBancario.Credito, AjusteBancario.Ced_Usuario, AjusteBancario.CodigoMoneda, AjusteBancario.TipoCambio, Cuentas_bancarias.CuentaContable, Cuentas_bancarias.NombreCuentaContable FROM AjusteBancario INNER JOIN Cuentas_bancarias ON AjusteBancario.Id_CuentaBancaria = Cuentas_bancarias.Id_CuentaBancaria" &
                        " WHERE (dbo.DateOnly(AjusteBancario.Fecha) >= @F1 AND dbo.DateOnly(AjusteBancario.Fecha) <= @F2) AND Anula = 0 AND Contabilizado = 0 "

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "AJUSTE"
            If dt.Rows(ic).Item("Debito") Then
                modulo &= " DEB"

            Else
                modulo &= " CRE"

            End If

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "BCO")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Documento")
                .Current("Beneficiario") = " " & dt.Rows(ic).Item("Concepto")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & " " & dt.Rows(ic).Item("Concepto") & " # " & dt.Rows(ic).Item("Documento")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("CodigoMoneda")


                If dt.Rows(ic).Item("TipoCambio") = 1 Or dt.Rows(ic).Item("TipoCambio") = 0 Then
                    tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                Else
                    tc = dt.Rows(ic).Item("TipoCambio")
                End If
                .Current("TipoCambio") = tc
                .EndCurrentEdit()
                'PRIMERA LINEA DE CUENTA DEL BANCO
                If dt.Rows(ic).Item("Credito") Then
                    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("NombreCuentaContable"), tc)
                Else
                    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("NombreCuentaContable"), tc)
                End If

                Dim _dt As New DataTable

                cmd.CommandText = "Select AjusteBancario_Detalle.CuentaContable, AjusteBancario_Detalle.NombreCuenta, AjusteBancario_Detalle.Monto, AjusteBancario_Detalle.Descripcion_Mov, AjusteBancario_Detalle.Id_AjusteDet FROM AjusteBancario INNER JOIN Cuentas_bancarias ON AjusteBancario.Id_CuentaBancaria = Cuentas_bancarias.Id_CuentaBancaria INNER JOIN AjusteBancario_Detalle ON AjusteBancario.Id_Ajuste = AjusteBancario_Detalle.Id_Ajuste " &
                                      " WHERE AjusteBancario.Id_Ajuste = " & dt.Rows(ic).Item("ID") & " AND Anula = 0 AND Contabilizado = 0 "

                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))

                For id As Integer = 0 To _dt.Rows.Count - 1

                    'LINEAS DETALLE DEL AJUSTE

                    'LINEAS DETALLE DEL AJUSTE
                    If dt.Rows(ic).Item("Credito") Then
                        GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), False, True, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("NombreCuenta"), tc)
                    Else
                        GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), True, False, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("NombreCuenta"), tc)
                    End If

                Next
                Me.sp_totalesAsiento(.Current("NumAsiento"))

            End With
        Next


    End Sub

    Sub sp_GenerarAsientoTRANSFERENCIASBANC(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT TB.Id_Transferencia AS ID,  TB.Num_Transferencia, TB.Fecha, TB.Descripción, TB.Moneda_Origen, TB.Monto_Origen, TB.Monto_Destino, TB.Moneda_Destino, TB.TipoCambio, CBOri.CuentaContable AS CCOrigen, CBOri.NombreCuentaContable AS NCOrigen, CBDes.CuentaContable AS CCDestino, CBDes.NombreCuentaContable AS NCDestino, TB.Anula, TB.Contabilizado, TB.Num_Transferencia2 FROM TransferenciasBancarias AS TB INNER JOIN Cuentas_bancarias AS CBOri ON TB.Id_Cuenta_Origen = CBOri.Id_CuentaBancaria INNER JOIN Cuentas_bancarias AS CBDes ON TB.Id_Cuenta_Destino = CBDes.Id_CuentaBancaria " &
                        " WHERE (dbo.DateOnly(TB.Fecha) >= @F1 AND dbo.DateOnly(TB.Fecha) <= @F2) AND Anula = 0 AND Contabilizado = 0 "

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "TRANS ENTRE BANC"

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "BCO")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Num_Transferencia")
                .Current("Beneficiario") = " No. Transf Origen: " & dt.Rows(ic).Item("Num_Transferencia") & " -> No. Transf Destino: " & dt.Rows(ic).Item("Num_Transferencia2")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & " " & dt.Rows(ic).Item("Descripción") & " No. Transf Origen: " & dt.Rows(ic).Item("Num_Transferencia") & " No. Transf Destino: " & dt.Rows(ic).Item("Num_Transferencia2")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("Moneda_Origen")


                If dt.Rows(ic).Item("TipoCambio") = 1 Or dt.Rows(ic).Item("TipoCambio") = 0 Then
                    tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                Else
                    tc = dt.Rows(ic).Item("TipoCambio")
                End If
                .Current("TipoCambio") = tc
                .EndCurrentEdit()

                'LINEA CUENTA DEL BANCO DESTINO
                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto_Origen"), True, False, dt.Rows(ic).Item("CCDestino"), dt.Rows(ic).Item("NCDestino"), tc)
                'PRIMERA LINEA DE CUENTA DEL BANCO ORIGEN
                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto_Origen"), False, True, dt.Rows(ic).Item("CCOrigen"), dt.Rows(ic).Item("NCOrigen"), tc)

            End With
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next


    End Sub

    Sub sp_GenerarAsientoFACTURASGASTOS(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT     c.Id_Compra AS ID, c.Factura, c.CodigoProv, c.SubTotalGravado, c.SubTotalExento, c.Descuento, c.Impuesto, c.TotalFactura, c.Fecha, c.Vence, c.FechaIngreso, c.MotivoGasto, c.Compra, c.Contabilizado, c.ContaInve, c.TipoCompra, c.CedulaUsuario, c.Cod_MonedaCompra, c.FacturaCancelado,  c.Gasto, c.TipoCambio, p.CuentaContable, p.DescripcionCuentaContable, p.Nombre, c.MontoGasto, c.ImpuestoAplicable  FROM         compras AS c INNER JOIN    Proveedores AS p ON c.CodigoProv = p.CodigoProv" &
                " WHERE (c.Gasto = 1) AND (c.TotalFactura > 0) AND (dbo.DateOnly(c.Fecha) >= @F1 AND dbo.DateOnly(c.Fecha) <= @F2) AND  c.Contabilizado = 0 "

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim stt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCreditoComp ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "FACTURA GASTOS"

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "CXP")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Factura")
                .Current("Beneficiario") = " No. Fac : " & dt.Rows(ic).Item("Factura") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("FechaIngreso")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & " " & dt.Rows(ic).Item("MotivoGasto") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("Cod_MonedaCompra")


                If dt.Rows(ic).Item("TipoCambio") = 1 Or dt.Rows(ic).Item("TipoCambio") = 0 Then
                    tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                Else
                    tc = dt.Rows(ic).Item("TipoCambio")
                End If
                .Current("TipoCambio") = tc
                .EndCurrentEdit()

                ''LINEA CUENTA DEL PROVEEDOR PASIVO
                'If dt.Rows(ic).Item("Cod_MonedaCompra") = 1 Then 'COLONES

                GuardaAsientoDetalle(dt.Rows(ic).Item("TotalFactura"), False, True, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("DescripcionCuentaContable"), tc)

                'Else 'DOLARES 

                'GuardaAsientoDetalle(dt.Rows(ic).Item("TotalFactura"), False, True, dt.Rows(ic).Item("CuentaContableDolar"), dt.Rows(ic).Item("DescripcionCuentaContableDolar"), tc)

                'End If


                'LINEA CUENTA IMPUESTO
                If stt.Rows.Count > 0 And dt.Rows(ic).Item("ImpuestoAplicable") > 0 Then
                    GuardaAsientoDetalle(Math.Round(dt.Rows(ic).Item("ImpuestoAplicable"), 2), True, False, stt.Rows(0).Item("CuentaContable"), stt.Rows(0).Item("Descripcion"), tc)
                End If


                Dim _dt As New DataTable
                cmd.CommandText = "SELECT     a.Descripcion, a.Base, a.Monto_Flete, a.OtrosCargos, a.Costo, a.Cantidad, a.Gravado, a.Exento, a.Descuento_P, a.Descuento, a.Impuesto_P, a.Impuesto, a.Total, a.Devoluciones, a.CuentaContable,a.MontoGasto, a.ImpuestoAplicable, ccm.Descripcion AS DesCC FROM  compras AS c INNER JOIN  Proveedores AS p ON c.CodigoProv = p.CodigoProv INNER JOIN  Articulos_Gastos AS a ON c.Id_Compra = a.IdCompra INNER JOIN  CuentasContableMovimimiento AS ccm ON a.CuentaContable = ccm.CuentaContable COLLATE Modern_Spanish_CI_AS WHERE    (c.Id_Compra = " & dt.Rows(ic).Item("ID") & ") AND  (c.Gasto = 1) AND (c.TotalFactura > 0) AND (c.Contabilizado = 0)"
                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))
                If _dt.Rows.Count = 0 Then
                    MsgBox("Linea no valida en Factura # " & dt.Rows(ic).Item("Factura"), MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                For id As Integer = 0 To _dt.Rows.Count - 1

                    GuardaAsientoDetalle(Math.Round(_dt.Rows(id).Item("MontoGasto"), 2), True, False, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("DesCC"), tc)
                    'If _dt.Rows(id).Item("Gravado") + _dt.Rows(id).Item("Exento") = 0 Then
                    '	GuardaAsientoDetalle(_dt.Rows(id).Item("Total"), True, False, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("DesCC"), tc)
                    'Else
                    '	GuardaAsientoDetalle(_dt.Rows(id).Item("Gravado") + _dt.Rows(id).Item("Exento"), True, False, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("DesCC"), tc)
                    'End If

                Next



            End With
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next


    End Sub
    Sub sp_GenerarAsientoFACTURASVentasFelipe(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT     Fecha, SUM(Total) AS Total, SUM(SubTotal) AS ST, SUM(SubTotalGravada) AS SG, SUM(SubTotalExento) AS SE, SUM(Descuento) AS DES, SUM(Imp_Venta) AS IMP FROM         dbo.fVentasAsiento AS v GROUP BY Fecha " &
                        " HAVING      (Fecha <= @F2) AND (Fecha >= @F1)  ORDER BY Fecha "

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        ProgressBar1.Maximum = dt.Rows.Count
        Dim fx As New cFunciones
        Dim stt As New DataTable

        'DETALLE DE VENTAS
        Dim _dt As New DataTable
        Dim cn As String = "SELECT  SUM(MontoPago) AS MontoPago, Fecha, Tipo, FormaPago" &
         " FROM dbo.fVentasAsientoFP " &
        " GROUP BY Fecha, Tipo, FormaPago" &
        " HAVING      (Fecha >= @F1) AND (Fecha <= @F2) ORDER BY Fecha"

        Dim cmd1 As New SqlClient.SqlCommand
        cmd1.CommandText = cn
        cmd1.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd1.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd1, _dt, Configuracion.Claves.Conexion(conexion))
        Dim pos As Integer = 0

        'Buscar Información de Impuesto de Ventas
        Dim cIngGra As String = ""
        Dim cDIngGra As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT   CuentaGra, DescripcionGra  FROM Familia", stt, Configuracion.Claves.Conexion("SEEPOS"))

        If stt.Rows.Count > 0 Then
            cIngGra = stt.Rows(0).Item("CuentaGra")
            cDIngGra = stt.Rows(0).Item("DescripcionGra")
        End If
        'Buscar Información de Ingresos de Ventas Excentas
        Dim cIngExe As String = ""
        Dim cDIngExe As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT   CuentaExe, DescripcionExe  FROM Familia", stt, Configuracion.Claves.Conexion("SEEPOS"))

        If stt.Rows.Count > 0 Then
            cIngExe = stt.Rows(0).Item("CuentaExe")
            cDIngExe = stt.Rows(0).Item("DescripcionExe")
        End If

        'Buscar Información de Impuesto de Ventas
        Dim cIv As String = ""
        Dim cDIv As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdImpuestoVenta ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cIv = stt.Rows(0).Item("CuentaContable")
            cDIv = stt.Rows(0).Item("Descripcion")
        End If

        'Buscar Información de Diferencia Ingreso
        Dim cDifIng As String = ""
        Dim cDDifIng As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdDiferencial ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cDifIng = stt.Rows(0).Item("CuentaContable")
            cDDifIng = stt.Rows(0).Item("Descripcion")
        End If
        'Buscar Información de Diferencia Gasto
        Dim cDifGas As String = ""
        Dim cDDifGas As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdDiferencial ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cDifGas = stt.Rows(0).Item("CuentaContable")
            cDDifGas = stt.Rows(0).Item("Descripcion")
        End If

        'Buscar Información de Credito
        Dim cCre As String = ""
        Dim cDCre As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCuentaCobrar ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cCre = stt.Rows(0).Item("CuentaContable")
            cDCre = stt.Rows(0).Item("Descripcion")
        End If


        'Buscar Información de Pago de Efectivo.
        Dim cEfe As String = ""
        Dim cDEfe As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCaja ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        If stt.Rows.Count > 0 Then
            cEfe = stt.Rows(0).Item("CuentaContable")
            cDEfe = stt.Rows(0).Item("Descripcion")
        End If


        'Buscar Información de Pago en Tarjeta.
        Dim cTar As String = ""
        Dim cDTar As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT CuentaCXC, NombreCXC FROM TipoTarjeta", stt, Configuracion.Claves.Conexion("SEEPOS"))
        If stt.Rows.Count > 0 Then
            cTar = stt.Rows(0).Item("CuentaCXC")
            cDTar = stt.Rows(0).Item("NombreCXC")
        End If
        '
        'Buscar Información de Descuento
        Dim cDescuento As String = ""
        Dim cDescuentoNom As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM SettingCuentaContable INNER JOIN  CuentaContable ON SettingCuentaContable.IdCostoVPrep = CuentaContable.id", stt, Configuracion.Claves.Conexion("Contabilidad"))
        If stt.Rows.Count > 0 Then
            cDescuento = stt.Rows(0).Item("CuentaContable")
            cDescuentoNom = stt.Rows(0).Item("Descripcion")
        End If
        'Buscar el period de trabajo
        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0

        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "FACTURA VENTAS"

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = NumeroAsiento(_pF1, ic, "ING")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = CInt(Format(dt.Rows(ic).Item("Fecha"), "yyyy") + Format(dt.Rows(ic).Item("Fecha"), "MM") + Format(dt.Rows(ic).Item("Fecha"), "dd"))
                .Current("NumDoc") = CInt(Format(dt.Rows(ic).Item("Fecha"), "yyyy") + Format(dt.Rows(ic).Item("Fecha"), "MM") + Format(dt.Rows(ic).Item("Fecha"), "dd"))
                .Current("Beneficiario") = " Dia: : " & Format(dt.Rows(ic).Item("Fecha"), "dd/MM/yyyy")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = Now
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = " Dia: " & Format(dt.Rows(ic).Item("Fecha"), "dd/MM/yyyy")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = 1
                'TIPO DE CAMBIO DEL DIA
                tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()

                'CUENTA DE INGRESO
                GuardaAsientoDetalle(dt.Rows(ic).Item("SG"), False, True, cIngGra, cDIngGra, tc)
                GuardaAsientoDetalle(dt.Rows(ic).Item("SE"), False, True, cIngExe, cDIngExe, tc)

                GuardaAsientoDetalle(dt.Rows(ic).Item("DES"), True, False, cDescuento, cDescuentoNom, tc)


                'IMPUESTO DE VENTAS
                If dt.Rows(ic).Item("IMP") > 0 Then
                    GuardaAsientoDetalle(dt.Rows(ic).Item("IMP"), False, True, cIv, cDIv, tc)
                End If

                For iic As Integer = pos To _dt.Rows.Count - 1
                    If _dt.Rows(iic).Item("Fecha") = dt.Rows(ic).Item("Fecha") Then

                        If _dt.Rows(iic).Item("Tipo").ToString.Equals("CRE") Then
                            GuardaAsientoDetalle(_dt.Rows(iic).Item("MontoPago"), True, False, cCre, cDCre, tc)
                        Else

                            'If _dt.Rows(iic).Item("FormaPago").Equals("EFE") Then
                            GuardaAsientoDetalle(_dt.Rows(iic).Item("MontoPago"), True, False, cEfe, cDEfe, tc)
                            'End If
                            'If _dt.Rows(iic).Item("FormaPago").Equals("TAR") Then
                            '    GuardaAsientoDetalle(_dt.Rows(iic).Item("MontoPago"), True, False, cTar, cDTar, tc)

                            'End If

                        End If
                    Else
                        pos = 0
                    End If

                Next


            End With
            sp_totalesAsiento(BindingContext(dsAs, "AsientosContables").Current("NumAsiento"))
            GuardaAsientoDetalle(BindingContext(dsAs, "AsientosContables").Current("Dif") * -1, True, False, cEfe, cDEfe, tc)
            sp_totalesAsiento(BindingContext(dsAs, "AsientosContables").Current("NumAsiento"))

            ProgressBar1.Value = ProgressBar1.Value + 1
        Next


    End Sub
    Sub sp_GenerarAsientoCostoVentaFelipe(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT     Fecha, SUM(Total) AS Total, CuentaCosto, DescripcionCosto FROM         dbo.vVentasfCostoFiltrado AS v  GROUP BY CuentaCosto, DescripcionCosto, Fecha" &
                        " HAVING      (Fecha <= @F2) AND (Fecha >= @F1)  ORDER BY Fecha "

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))
        Dim f As Date = _pF1.Date

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        ProgressBar1.Maximum = dt.Rows.Count
        Dim fx As New cFunciones
        Dim stt As New DataTable

        Dim pos As Integer = 0

        'Buscar Información de Ingreso
        Dim cInv As String = ""
        Dim cDInv As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM SettingCuentaContable INNER JOIN  CuentaContable ON SettingCuentaContable.IdCompraGrabado = CuentaContable.id", stt, Configuracion.Claves.Conexion("Contabilidad"))
        If stt.Rows.Count > 0 Then
            cInv = stt.Rows(0).Item("CuentaContable")
            cDInv = stt.Rows(0).Item("Descripcion")
        End If

        ProgressBar1.Maximum = dt.Rows.Count

        'Buscar el period de trabajo
        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        Dim i As Integer = -1
        While f <= _pF2.Date

            i = i + 1

            Dim modulo As String = "COSTO VENTAS"

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = NumeroAsiento(_pF1, i, "COS")
                .Current("Fecha") = f
                .Current("IdNumDoc") = CInt(Format(f, "yyyy") + Format(f, "MM") + Format(f, "dd"))
                .Current("NumDoc") = CInt(Format(f, "yyyy") + Format(f, "MM") + Format(f, "dd"))
                .Current("Beneficiario") = " Dia: : " & Format(f, "dd/MM/yyyy")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = Now
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = " Dia: " & Format(f, "dd/MM/yyyy")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = 1
                'TIPO DE CAMBIO DEL DIA
                tc = fx.TipoCambio(f, False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()
                For ic As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(ic).Item("Fecha").Equals(f) Then


                        'Inventario
                        If dt.Rows(ic).Item("Total") > 0 Then
                            GuardaAsientoDetalle(dt.Rows(ic).Item("Total"), False, True, cInv, cDInv, tc)
                            'CUENTA DE COSTO
                            GuardaAsientoDetalle(dt.Rows(ic).Item("Total"), True, False, dt.Rows(ic).Item("CuentaCosto"), dt.Rows(ic).Item("DescripcionCosto"), tc)

                        End If


                    End If

                Next

            End With
            sp_totalesAsiento(BindingContext(dsAs, "AsientosContables").Current("NumAsiento"))
            ' GuardaAsientoDetalle(BindingContext(dsAs, "AsientosContables").Current("Dif") * -1, True, False, cEfe, cDEfe, tc)
            'sp_totalesAsiento(BindingContext(dsAs, "AsientosContables").Current("NumAsiento"))

            f = f.AddDays(1)
            ProgressBar1.Value = ProgressBar1.Value + 1
        End While

    End Sub
    Sub sp_GenerarAsientoFACTURASINVENTARIO(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT     c.Id_Compra AS ID, c.Factura, c.CodigoProv, c.SubTotalGravado, c.SubTotalExento, c.Descuento, c.Impuesto, c.TotalFactura, c.Fecha, c.Vence, c.FechaIngreso, c.MotivoGasto, c.Compra, c.Contabilizado, c.ContaInve, c.TipoCompra, c.CedulaUsuario, c.Cod_MonedaCompra, c.FacturaCancelado,  c.Gasto, c.TipoCambio, p.CuentaContable, p.DescripcionCuentaContable, p.Nombre FROM         compras AS c INNER JOIN    Proveedores AS p ON c.CodigoProv = p.CodigoProv" &
                " WHERE (c.Gasto = 0) AND (c.TotalFactura > 0) AND (dbo.DateOnly(c.Fecha) >= @F1 AND dbo.DateOnly(c.Fecha) <= @F2) AND  c.Contabilizado = 0 "

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim stt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdImpuestoVenta ", stt, Configuracion.Claves.Conexion("Contabilidad"))

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "FACTURA INV"

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "CXP")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Factura")
                .Current("Beneficiario") = " No. Fac : " & dt.Rows(ic).Item("Factura") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("FechaIngreso")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & ". " & dt.Rows(ic).Item("MotivoGasto") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("Cod_MonedaCompra")


                If dt.Rows(ic).Item("TipoCambio") = 1 Or dt.Rows(ic).Item("TipoCambio") = 0 Then
                    tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                Else
                    tc = dt.Rows(ic).Item("TipoCambio")
                End If
                .Current("TipoCambio") = tc
                .EndCurrentEdit()

                'LINEA CUENTA DEL PROVEEDOR PASIVO
                'If dt.Rows(ic).Item("Cod_MonedaCompra") = 1 Then 'COLONES

                GuardaAsientoDetalle(dt.Rows(ic).Item("TotalFactura"), False, True, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("DescripcionCuentaContable"), tc)

                'Else 'DOLARES 

                '    GuardaAsientoDetalle(dt.Rows(ic).Item("TotalFactura"), False, True, dt.Rows(ic).Item("CuentaContableDolar"), dt.Rows(ic).Item("DescripcionCuentaContableDolar"), tc)

                'End If


                'LINEA CUENTA IMPUESTO
                If stt.Rows.Count > 0 And dt.Rows(ic).Item("Impuesto") > 0 Then
                    GuardaAsientoDetalle(dt.Rows(ic).Item("Impuesto"), True, False, stt.Rows(0).Item("CuentaContable"), stt.Rows(0).Item("Descripcion"), tc)
                End If


                Dim _dt As New DataTable
                'cmd.CommandText = "SELECT     b.Nombre, b.CuentaContable, b.DescripcionCuentaContable, a.Gravado, a.Exento, a.Descripcion FROM compras AS c INNER JOIN Proveedores AS p ON c.CodigoProv = p.CodigoProv INNER JOIN articulos_comprados AS a ON c.Id_Compra = a.IdCompra INNER JOIN    Bodega AS b ON a.bodega_id = b.IdBodega WHERE (c.Id_Compra = " & dt.Rows(ic).Item("ID") & ") AND (c.Gasto = 0) AND (c.TotalFactura > 0) AND (c.Contabilizado = 0)"
                cmd.CommandText = "SELECT '1-01-07-00-00' AS CuentaContable, 'INVENTARIOS' AS DescripcionCuentaContable, a.Gravado, a.Exento, a.Descripcion FROM compras AS c INNER JOIN  Proveedores AS p ON c.CodigoProv = p.CodigoProv INNER JOIN  articulos_comprados AS a ON c.Id_Compra = a.IdCompra WHERE (c.Id_Compra = " & dt.Rows(ic).Item("ID") & ") AND (c.Gasto = 0) AND (c.TotalFactura > 0) AND (c.Contabilizado = 0)"
                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))

                Dim cComprasGravadas As String
                Dim dComprasGravadas As String
                Dim cComprasExentas As String
                Dim dComprasExentas As String
                Dim dts As New DataTable
                cFunciones.Llenar_Tabla_Generico("select g.CuentaContable as CGravado, g.Descripcion as DGravado, e.CuentaContable as CExento, e.Descripcion as DExento from SettingCuentaContable inner join CuentaContable as g on SettingCuentaContable.IdCompraGrabado = g.id inner join CuentaContable as e on SettingCuentaContable.IdCompraExcento = e.id", dts, Configuracion.Claves.Conexion("Contabilidad"))
                If dts.Rows.Count > 0 Then
                    cComprasGravadas = dts.Rows(0).Item("CGravado")
                    dComprasGravadas = dts.Rows(0).Item("DGravado")
                    cComprasExentas = dts.Rows(0).Item("CExento")
                    dComprasExentas = dts.Rows(0).Item("DExento")
                End If

                If _dt.Rows.Count = 0 Then
                    MsgBox("Linea no valida en Factura # " & dt.Rows(ic).Item("Factura"), MsgBoxStyle.OkOnly)
                    Exit Sub
                End If
                Dim haber As Double = dt.Rows(ic).Item("TotalFactura")
                Dim debe As Double = 0
                For id As Integer = 0 To _dt.Rows.Count - 1
                    GuardaAsientoDetalle(_dt.Rows(id).Item("Gravado"), True, False, cComprasGravadas, dComprasGravadas, tc)
                    GuardaAsientoDetalle(_dt.Rows(id).Item("Exento"), True, False, cComprasExentas, dComprasExentas, tc)
                    debe += _dt.Rows(id).Item("Gravado") + _dt.Rows(id).Item("Exento")
                Next

                debe += dt.Rows(ic).Item("Impuesto")
                Dim dif As Double = debe - haber
                If dif <> 0 Then
                    dif = dif * -1
                    Dim ban As Boolean = True
                    For id As Integer = 0 To _dt.Rows.Count - 1
                        If _dt.Rows(id).Item("Gravado") > 0 Then
                            GuardaAsientoDetalle(dif, True, False, cComprasGravadas, dComprasGravadas, tc)
                            ban = False
                            Exit For
                        End If
                    Next
                    If ban Then
                        GuardaAsientoDetalle(dif, True, False, cComprasGravadas, dComprasGravadas, tc)

                    End If
                End If

            End With
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next


    End Sub

    Sub sp_GenerarAsientoAJUSTECXP(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        'cmd.CommandText = "SELECT    a.ID_Ajuste AS ID, a.AjusteNo AS Documento, a.Tipo, a.Cod_Proveedor, a.Nombre_Proveedor, a.Fecha, a.Saldo_Prev, a.Monto, a.Saldo_Act, a.Observaciones, a.Anula, a.Cod_Usuario, a.Cod_Moneda, a.AsientoCre, a.AsientoDeb, a.ContaCre, a.ContaDeb, a.DocProveedor, p.Nombre, p.CuentaContable, p.DescripcionCuentaContable, p.CuentaContableDolar, p.DescripcionCuentaContableDolar FROM Ajustescpagar AS a INNER JOIN Proveedores AS p ON a.Cod_Proveedor = p.CodigoProv " & _
        '" WHERE     (a.Anula = 0) AND (a.ContaCre = 0) AND (a.ContaDeb = 0) AND (dbo.DateOnly(a.Fecha) >= @F1 AND dbo.DateOnly(a.Fecha) <= @F2)"
        cmd.CommandText = "SELECT a.ID_Ajuste AS ID, a.AjusteNo AS Documento, a.Tipo, a.Cod_Proveedor, a.Nombre_Proveedor, a.Fecha, a.Saldo_Prev, a.Monto, a.Saldo_Act,  a.Observaciones, a.Cod_Usuario, a.Cod_Moneda, p.Nombre, p.CuentaContable as CuentaContableProveedor, p.DescripcionCuentaContable as DescripcionCuentaContableProveedor, 
                          a.CuentaContable , a.DescripcionCuentaContable , ((a.SubTotalExcento + a.SubTotalGravado) - a.Descuento)  AS SubTotal,a.MontoImpuesto,a.Total,
                          a.TipoCambio  FROM Ajustescpagar AS a INNER JOIN  Proveedores AS p ON a.Cod_Proveedor = p.CodigoProv  WHERE (dbo.DateOnly(a.Fecha) >= @F1) AND (dbo.DateOnly(a.Fecha) <= @F2)  AND (a.Contabilizado = 0) AND (a.Anula = 0) "
        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))


        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0

        Dim dtConf As New DataTable
        Dim cuentaIv As String = ""
        Dim cuentaIvNom As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM SettingCuentaContable INNER JOIN  CuentaContable ON SettingCuentaContable.IdImpuestoVenta = CuentaContable.id", dtConf, Configuracion.Claves.Conexion("Contabilidad"))
        If dtConf.Rows.Count > 0 Then
            cuentaIv = dtConf.Rows(0).Item("CuentaContable")
            cuentaIvNom = dtConf.Rows(0).Item("Descripcion")
        End If

        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "AJUSTE CXP " & dt.Rows(ic).Item("Tipo")

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "CXP")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID")
                .Current("NumDoc") = dt.Rows(ic).Item("Documento")
                .Current("Beneficiario") = " Doc No.: " & dt.Rows(ic).Item("Documento") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & ". " & dt.Rows(ic).Item("Observaciones") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("Cod_Moneda")
                tc = dt.Rows(ic).Item("TipoCambio")
                .Current("TipoCambio") = tc
                .EndCurrentEdit()



                'LINEA CUENTA DEL PROVEEDOR PASIVO
                If dt.Rows(ic).Item("Cod_Moneda") = 1 Then 'COLONES
                    If dt.Rows(ic).Item("Tipo").ToString().Contains("CRE") Then
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Total"), True, False, dt.Rows(ic).Item("CuentaContableProveedor"), dt.Rows(ic).Item("DescripcionCuentaContableProveedor"), tc)

                        If CDbl(dt.Rows(ic).Item("MontoImpuesto")) > 0 Then
                            GuardaAsientoDetalle(CDbl(dt.Rows(ic).Item("MontoImpuesto")), False, True, cuentaIv, cuentaIvNom, tc)

                        End If

                    Else
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Total"), False, True, dt.Rows(ic).Item("CuentaContableProveedor"), dt.Rows(ic).Item("DescripcionCuentaContableProveedor"), tc)

                        If CDbl(dt.Rows(ic).Item("MontoImpuesto")) > 0 Then
                            GuardaAsientoDetalle(CDbl(dt.Rows(ic).Item("MontoImpuesto")), True, False, cuentaIv, cuentaIvNom, tc)

                        End If
                    End If


                Else 'DOLARES 
                    If dt.Rows(ic).Item("Tipo").ToString().Contains("CRE") Then
                        GuardaAsientoDetalle(CDbl(dt.Rows(ic).Item("Total")) * CDbl(dt.Rows(ic).Item("TipoCambio")), False, True, dt.Rows(ic).Item("CuentaContableProveedor"), dt.Rows(ic).Item("DescripcionCuentaContableProveedor"), tc)

                        If CDbl(dt.Rows(ic).Item("MontoImpuesto")) > 0 Then
                            GuardaAsientoDetalle(CDbl(dt.Rows(ic).Item("MontoImpuesto")) * CDbl(dt.Rows(ic).Item("TipoCambio")), False, True, cuentaIv, cuentaIvNom, tc)

                        End If
                    Else
                        GuardaAsientoDetalle(CDbl(dt.Rows(ic).Item("Total")) * CDbl(dt.Rows(ic).Item("TipoCambio")), True, False, dt.Rows(ic).Item("CuentaContableProveedor"), dt.Rows(ic).Item("DescripcionCuentaContableProveedor"), tc)

                        If CDbl(dt.Rows(ic).Item("MontoImpuesto")) > 0 Then
                            GuardaAsientoDetalle(CDbl(dt.Rows(ic).Item("MontoImpuesto")) * CDbl(dt.Rows(ic).Item("TipoCambio")), True, False, cuentaIv, cuentaIvNom, tc)

                        End If
                    End If


                End If


                If dt.Rows(ic).Item("Tipo").ToString().Contains("CRE") Then
                    GuardaAsientoDetalle(dt.Rows(ic).Item("SubTotal"), False, True, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("DescripcionCuentaContable"), tc)
                Else
                    GuardaAsientoDetalle(dt.Rows(ic).Item("SubTotal"), True, False, dt.Rows(ic).Item("CuentaContable"), dt.Rows(ic).Item("DescripcionCuentaContable"), tc)
                End If

                Me.sp_totalesAsiento(.Current("NumAsiento"))
            End With

        Next


    End Sub

    Sub sp_GenerarAsientoAJUSTECXC(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT [ID_Ajuste]  ,[AjusteNo]  ,[Tipo]  ,[Cod_Cliente]  ,[Nombre_Cliente]  ,[Fecha]  ,[Saldo_Prev]  ,[Monto]  ,[Saldo_Act]  ,[Observaciones]  ,[Anula]  ,[Cod_Usuario]  ,[Contabilizado]  ,[Cod_Moneda]  ,[Asiento]  FROM [SEEPOS].[dbo].[ajustesccobrar] Where anula = 0 and Contabilizado = 0 and dbo.DateOnly(FECHA) >= @F1 AND dbo.DateOnly(FECHA) <= @F2"
        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If
        Dim cxc As String = ""
        Dim cxcNom As String = ""

        Dim stt As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdCuentaCobrar ", stt, Configuracion.Claves.Conexion("Contabilidad"))
        If stt.Rows.Count > 0 Then
            cxc = stt.Rows(0).Item("CuentaContable")
            cxcNom = stt.Rows(0).Item("Descripcion")
        End If

        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "AJUSTE CXC " & dt.Rows(ic).Item("Tipo")

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "CXC")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("ID_Ajuste")
                .Current("NumDoc") = dt.Rows(ic).Item("AjusteNo")
                .Current("Beneficiario") = " Doc No.: " & dt.Rows(ic).Item("AjusteNo") & "  Cliente:  " & dt.Rows(ic).Item("Nombre_Cliente")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & ". " & dt.Rows(ic).Item("Observaciones") & "  Cliente:  " & dt.Rows(ic).Item("Nombre_Cliente")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("Cod_Moneda")
                tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()



                'LINEA CUENTA DEL CLIENTE ACTIVO
                If dt.Rows(ic).Item("Cod_Moneda") = 1 Then 'COLONES
                    If dt.Rows(ic).Item("Tipo") = "CRE" Then
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, cxc, cxcNom, tc)
                    Else
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, cxc, cxcNom, tc)
                    End If


                Else 'DOLARES 
                    If dt.Rows(ic).Item("Tipo") = "CRE" Then
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, cxc, cxcNom, tc)
                    Else
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, cxc, cxcNom, tc)
                    End If
                End If

                Dim _dt As New DataTable
                cmd.CommandText = "SELECT dj.Id_DetalleAjustecCobrar, dj.Id_AjustecCobrar, dj.Factura, dj.Tipo, dj.Monto, dj.Saldo_Ant, dj.Ajuste, dj.Ajuste_SuMoneda, dj.Saldo_Ajustado, dj.Observaciones,  dj.TipoNota, dj.CuentaContable, dj.IdCuentaC FROM dbo.detalle_ajustesccobrar AS dj " &
                "WHERE   (dj.Id_AjustecCobrar = " & dt.Rows(ic).Item("ID_Ajuste") & ") "
                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))
                If _dt.Rows.Count = 0 Then
                    MsgBox("Registro Incompleto " & dt.Rows(ic).Item("AjusteNo"), MsgBoxStyle.OkOnly)
                    Exit For
                End If

                For id As Integer = 0 To _dt.Rows.Count - 1
                    Dim nombreCuenta As New DataTable
                    cFunciones.Llenar_Tabla_Generico("Select * From CuentaContable Where CuentaContable = '" & _dt.Rows(id).Item("CuentaContable") & "'", nombreCuenta, Configuracion.Claves.Conexion("Contabilidad"))

                    If nombreCuenta.Rows.Count > 0 Then
                        If dt.Rows(ic).Item("Tipo") = "CRE" Then
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), True, False, _dt.Rows(id).Item("CuentaContable"), nombreCuenta.Rows(0).Item("Descripcion"), tc)
                        Else
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), False, True, _dt.Rows(id).Item("CuentaContable"), nombreCuenta.Rows(0).Item("Descripcion"), tc)
                        End If
                    End If
                Next
                Me.sp_totalesAsiento(.Current("NumAsiento"))
            End With

        Next


    End Sub

    Sub sp_GenerarAsientoDEVCOMPRAS(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT d.Devolucion, p.CuentaContable AS CC, p.DescripcionCuentaContable AS DCC, p.Nombre, d.Monto, d.Fecha, d.Impuesto, d.Descuento, d.SubTotalExcento,  d.SubTotalGravado, d.Cod_Moneda,  d.Contabilizado, d.Asiento FROM dbo.devoluciones_Compras AS d INNER JOIN  dbo.Proveedores AS p ON d.CodigoProv = p.CodigoProv WHERE (d.Anulado = 0) AND (d.Contabilizado = 0) AND (dbo.DateOnly(d.Fecha) >= @F1) AND (dbo.DateOnly(d.Fecha) <= @F2)"

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))
        Dim cuentaInv As String = ""
        Dim cuentaInvNom As String = ""

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        Dim cuentaIv As String = ""
        Dim cuentaIvNom As String = ""
        Dim dtConf As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM SettingCuentaContable INNER JOIN  CuentaContable ON SettingCuentaContable.IdCompraGrabado = CuentaContable.id", dtConf, Configuracion.Claves.Conexion("Contabilidad"))
        If dtConf.Rows.Count > 0 Then
            cuentaInv = dtConf.Rows(0).Item("CuentaContable")
            cuentaInvNom = dtConf.Rows(0).Item("Descripcion")
        End If

        Dim cComprasGravadas As String
        Dim dComprasGravadas As String
        Dim cComprasExentas As String
        Dim dComprasExentas As String
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select g.CuentaContable as CGravado, g.Descripcion as DGravado, e.CuentaContable as CExento, e.Descripcion as DExento from SettingCuentaContable inner join CuentaContable as g on SettingCuentaContable.IdCompraGrabado = g.id inner join CuentaContable as e on SettingCuentaContable.IdCompraExcento = e.id", dts, Configuracion.Claves.Conexion("Contabilidad"))
        If dts.Rows.Count > 0 Then
            cComprasGravadas = dts.Rows(0).Item("CGravado")
            dComprasGravadas = dts.Rows(0).Item("DGravado")
            cComprasExentas = dts.Rows(0).Item("CExento")
            dComprasExentas = dts.Rows(0).Item("DExento")
        End If

        cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM SettingCuentaContable INNER JOIN  CuentaContable ON SettingCuentaContable.IdImpuestoVenta = CuentaContable.id", dtConf, Configuracion.Claves.Conexion("Contabilidad"))
        If dtConf.Rows.Count > 0 Then
            cuentaIv = dtConf.Rows(0).Item("CuentaContable")
            cuentaIvNom = dtConf.Rows(0).Item("Descripcion")
        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "DEV COM "

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "DEV")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("Devolucion")
                .Current("NumDoc") = dt.Rows(ic).Item("Devolucion")
                .Current("Beneficiario") = " Doc No.: " & dt.Rows(ic).Item("Devolucion") & "  Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = mayo
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & ". Proveedor:  " & dt.Rows(ic).Item("Nombre")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = dt.Rows(ic).Item("Cod_Moneda")
                tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()



                ''LINEA CUENTA DEL PROVEEDOR PASIVO
                'If dt.Rows(ic).Item("Cod_Moneda") = 1 Then 'COLONES
                '   If dt.Rows(ic).Item("Tipo") = "CRE" Then
                GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CC"), dt.Rows(ic).Item("DCC"), tc)
                GuardaAsientoDetalle(dt.Rows(ic).Item("Impuesto"), False, True, cuentaIv, cuentaIvNom, tc)


                GuardaAsientoDetalle(dt.Rows(ic).Item("SubTotalExcento"), False, True, cComprasExentas, dComprasExentas, tc)
                GuardaAsientoDetalle(dt.Rows(ic).Item("SubTotalGravado"), False, True, cComprasGravadas, dComprasGravadas, tc)


                'GuardaAsientoDetalle(dt.Rows(ic).Item("Monto") - dt.Rows(ic).Item("Impuesto"), False, True, cuentaInv, cuentaInvNom, tc)

                'Else
                'GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CC"), dt.Rows(ic).Item("DCC"), tc)
                'GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, cuentaInv, cuentaInvNom, tc)
                'End If


                ''Else 'DOLARES 
                'If dt.Rows(ic).Item("Tipo") = "CRE" Then
                '    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CD"), dt.Rows(ic).Item("DCD"), tc)
                'Else
                '    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CD"), dt.Rows(ic).Item("DCD"), tc)
                'End If


                'End If

                'Dim _dt As New DataTable
                'cmd.CommandText = "SELECT a.ID_Ajuste, a.AjusteNo, d.CuentaContable, d.DescripcionCuentaContable, d.Ajuste FROM  Ajustescpagar AS a INNER JOIN      Proveedores AS p ON a.Cod_Proveedor = p.CodigoProv INNER JOIN  Detalle_AjustescPagar AS d ON a.ID_Ajuste = d.Id_AjustecPagar " & _
                '"WHERE   (a.ID_Ajuste = " & dt.Rows(ic).Item("ID") & ") AND  (a.Anula = 0) AND (a.ContaCre = 0) AND (a.ContaDeb = 0)"
                'cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))
                'For id As Integer = 0 To _dt.Rows.Count - 1
                '    If dt.Rows(ic).Item("Tipo") = "CRE" Then
                '        GuardaAsientoDetalle(_dt.Rows(id).Item("Ajuste"), False, True, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("DescripcionCuentaContable"), tc)
                '    Else
                '        GuardaAsientoDetalle(_dt.Rows(id).Item("Ajuste"), True, False, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("DescripcionCuentaContable"), tc)
                '    End If
                'Next
            End With
            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next
    End Sub

    Sub sp_GenerarAsientoAjusteINV(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT Consecutivo, Fecha, Imp, CodigoProv, CXP FROM AjusteInventario WHERE (CXP = 1) AND (ContaEntrada = 0) AND (ContaSalida = 0) AND (Anula = 0) AND (dbo.DateOnly(Fecha) >= @F1 AND dbo.DateOnly(Fecha) <= @F2)" '"SELECT d.Devolucion, p.CuentaContable AS CC, p.DescripcionCuentaContable AS DCC, p.Nombre, c.Factura, d.Monto, d.Fecha, d.Impuesto, d.Descuento, d.SubTotalExcento,  d.SubTotalGravado, d.Cod_Moneda, d.TipoCambio, d.Contabilizado, d.Asiento FROM dbo.devoluciones_Compras AS d INNER JOIN  dbo.compras AS c ON d.Id_Factura_Compra = c.Id_Compra INNER JOIN  dbo.Proveedores AS p ON c.CodigoProv = p.CodigoProv WHERE (d.Anulado = 0) AND (d.Contabilizado = 0) AND (CAST(d.Fecha AS DATE) >= @F1) AND (CAST(d.Fecha AS DATE) <= @F2)"

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))
        'Dim cuentaInv As String = ""
        'Dim cuentaInvNom As String = ""

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        'Dim cuentaIv As String = ""
        'Dim cuentaIvNom As String = ""

        Dim dtConf As New DataTable
        'cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable.CuentaContable, CuentaContable.Descripcion FROM SettingCuentaContable INNER JOIN  CuentaContable ON SettingCuentaContable.IdCompraGrabado = CuentaContable.id", dtConf, Configuracion.Claves.Conexion("Contabilidad"))
        'If dtConf.Rows.Count > 0 Then
        '    cuentaInv = dtConf.Rows(0).Item("CuentaContable")
        '    cuentaInvNom = dtConf.Rows(0).Item("Descripcion")
        'End If

        'Buscar Información de Impuesto de Ventas
        Dim cIv As String = ""
        Dim cDIv As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdImpuestoVenta ", dtConf, Configuracion.Claves.Conexion("Contabilidad"))
        If dtConf.Rows.Count > 0 Then
            cIv = dtConf.Rows(0).Item("CuentaContable")
            cDIv = dtConf.Rows(0).Item("Descripcion")
        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "AJUST INV "

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "INV")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("Consecutivo")
                .Current("NumDoc") = dt.Rows(ic).Item("Consecutivo")
                .Current("Beneficiario") = " Doc No.: " & dt.Rows(ic).Item("Consecutivo")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = 0
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & ". Ajuste Inv compra: " & dt.Rows(ic).Item("Consecutivo")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = 1
                tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()

                ' ''LINEA CUENTA DEL PROVEEDOR PASIVO
                ''If dt.Rows(ic).Item("Cod_Moneda") = 1 Then 'COLONES
                If dt.Rows(ic).Item("CXP") Then
                    Dim dtProv As New DataTable
                    cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, DescripcionCuentaContable FROM Proveedores WHERE (CodigoProv = " & dt.Rows(ic).Item("CodigoProv") & ")", dtProv)
                    If dtProv.Rows.Count > 0 Then
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Imp"), True, False, dtProv.Rows(0).Item("CuentaContable"), dtProv.Rows(0).Item("DescripcionCuentaContable"), tc)
                        GuardaAsientoDetalle(dt.Rows(ic).Item("Imp"), False, True, cIv, cDIv, tc)
                    End If

                End If


                ''Else 'DOLARES 
                'If dt.Rows(ic).Item("Tipo") = "CRE" Then
                '    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), True, False, dt.Rows(ic).Item("CD"), dt.Rows(ic).Item("DCD"), tc)
                'Else
                '    GuardaAsientoDetalle(dt.Rows(ic).Item("Monto"), False, True, dt.Rows(ic).Item("CD"), dt.Rows(ic).Item("DCD"), tc)
                'End If


                'End If

                Dim cComprasGravadas As String
                Dim dComprasGravadas As String
                Dim cComprasExentas As String
                Dim dComprasExentas As String
                Dim dts As New DataTable
                cFunciones.Llenar_Tabla_Generico("select g.CuentaContable as CGravado, g.Descripcion as DGravado, e.CuentaContable as CExento, e.Descripcion as DExento from SettingCuentaContable inner join CuentaContable as g on SettingCuentaContable.IdCompraGrabado = g.id inner join CuentaContable as e on SettingCuentaContable.IdCompraExcento = e.id", dts, Configuracion.Claves.Conexion("Contabilidad"))
                If dts.Rows.Count > 0 Then
                    cComprasGravadas = dts.Rows(0).Item("CGravado")
                    dComprasGravadas = dts.Rows(0).Item("DGravado")
                    cComprasExentas = dts.Rows(0).Item("CExento")
                    dComprasExentas = dts.Rows(0).Item("DExento")
                End If

                Dim _dt As New DataTable
                cmd.CommandText = "SELECT Cuenta_Contable, Nombre_Cuenta, TotalEntrada + TotalSalida AS Monto, Salida, observacion, iventa as Gravado FROM AjusteInventario_Detalle inner join inventario on inventario.codigo = AjusteInventario_Detalle.cod_Articulo  WHERE (Cons_Ajuste = " & dt.Rows(ic).Item("Consecutivo") & ")"
                '"SELECT a.ID_Ajuste, a.AjusteNo, d.CuentaContable, d.DescripcionCuentaContable, d.Ajuste FROM  Ajustescpagar AS a INNER JOIN      Proveedores AS p ON a.Cod_Proveedor = p.CodigoProv INNER JOIN  Detalle_AjustescPagar AS d ON a.ID_Ajuste = d.Id_AjustecPagar " & _
                '"WHERE   (a.ID_Ajuste = " & dt.Rows(ic).Item("Concecutivo") & ") AND  (a.Anula = 0) AND (a.ContaCre = 0) AND (a.ContaDeb = 0)"
                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))
                If _dt.Rows.Count > 0 Then
                    .Current("Observaciones") &= ". " & _dt.Rows(0).Item("observacion")
                    .EndCurrentEdit()
                End If

                For id As Integer = 0 To _dt.Rows.Count - 1
                    If _dt.Rows(id).Item("Salida") Then
                        GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), True, False, _dt.Rows(id).Item("Cuenta_Contable"), _dt.Rows(id).Item("Nombre_Cuenta"), tc)

                        If _dt.Rows(0).Item("Gravado") = 0 Then
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), False, True, cComprasExentas, dComprasExentas, tc)
                        Else
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), False, True, cComprasGravadas, dComprasGravadas, tc)
                        End If
                    Else
                        If _dt.Rows(0).Item("Gravado") = 0 Then
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), True, False, cComprasExentas, dComprasExentas, tc)
                        Else
                            GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), True, False, cComprasGravadas, dComprasGravadas, tc)
                        End If
                        GuardaAsientoDetalle(_dt.Rows(id).Item("Monto"), False, True, _dt.Rows(id).Item("Cuenta_Contable"), _dt.Rows(id).Item("Nombre_Cuenta"), tc)
                    End If
                Next
            End With

            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next


    End Sub
    Sub sp_GenerarAsientoRequisiciones(ByVal _pF1 As Date, ByVal _pF2 As Date)
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT Id_Requisicion, Requisiciones.Fecha, Requisiciones.BodegaOrigen, SUM(RequisicionesDetalles.PrecioBase * RequisicionesDetalles.cantidad) AS Monto FROM Requisiciones INNER JOIN  RequisicionesDetalles ON Requisiciones.Id_Requisicion = RequisicionesDetalles.Id_Requisicion WHERE (Requisiciones.Anulado = 0) AND (Requisiciones.Contabilizado = 0) AND (dbo.DateOnly(Fecha) >= @F1 AND dbo.DateOnly(Fecha) <= @F2) GROUP BY Id_Requisicion, Requisiciones.Fecha, Requisiciones.BodegaOrigen " '"SELECT d.Devolucion, p.CuentaContable AS CC, p.DescripcionCuentaContable AS DCC, p.Nombre, c.Factura, d.Monto, d.Fecha, d.Impuesto, d.Descuento, d.SubTotalExcento,  d.SubTotalGravado, d.Cod_Moneda, d.TipoCambio, d.Contabilizado, d.Asiento FROM dbo.devoluciones_Compras AS d INNER JOIN  dbo.compras AS c ON d.Id_Factura_Compra = c.Id_Compra INNER JOIN  dbo.Proveedores AS p ON c.CodigoProv = p.CodigoProv WHERE (d.Anulado = 0) AND (d.Contabilizado = 0) AND (CAST(d.Fecha AS DATE) >= @F1) AND (CAST(d.Fecha AS DATE) <= @F2)"

        cmd.Parameters.AddWithValue("@F1", _pF1.Date)
        cmd.Parameters.AddWithValue("@F2", _pF2.Date)
        cFunciones.Llenar_Tabla_Generico(cmd, dt, Configuracion.Claves.Conexion(conexion))
        Dim cuentaInv As String = ""
        Dim cuentaInvNom As String = ""

        If dt.Rows.Count = 0 Then
            MsgBox("No existen " & Me.cboTipos.Text & " pendientes para este rango de fechas", MsgBoxStyle.OkOnly)
            Exit Sub

        End If

        Dim cuentaIv As String = ""
        Dim cuentaIvNom As String = ""

        Dim dtConf As New DataTable


        'Buscar Información de Impuesto de Ventas
        Dim cIv As String = ""
        Dim cDIv As String = ""

        cFunciones.Llenar_Tabla_Generico("SELECT c.CuentaContable, c.Descripcion FROM CuentaContable AS c INNER JOIN    SettingCuentaContable AS s ON c.id = s.IdImpuestoVenta ", dtConf, Configuracion.Claves.Conexion("Contabilidad"))

        If dtConf.Rows.Count > 0 Then
            cIv = dtConf.Rows(0).Item("CuentaContable")
            cDIv = dtConf.Rows(0).Item("Descripcion")
        End If
        Dim fx As New cFunciones

        Dim periodo As String = fx.BuscaPeriodo(_pF1)
        Dim tc As Double = 0
        For ic As Integer = 0 To dt.Rows.Count - 1
            Dim modulo As String = "AJUST INV "

            With Me.BindingContext(Me.dsAs, "AsientosContables")
                .AddNew()
                .Current("NumAsiento") = Me.NumeroAsiento(_pF1, ic, "INV")
                .Current("Fecha") = dt.Rows(ic).Item("Fecha")
                .Current("IdNumDoc") = dt.Rows(ic).Item("Consecutivo")
                .Current("NumDoc") = dt.Rows(ic).Item("Consecutivo")
                .Current("Beneficiario") = " Doc No.: " & dt.Rows(ic).Item("Consecutivo")
                .Current("TipoDoc") = 0
                .Current("Accion") = "AUT"
                .Current("Anulado") = 0
                .Current("FechaEntrada") = dt.Rows(ic).Item("Fecha")
                .Current("Mayorizado") = mayo > 0
                .Current("Periodo") = periodo
                .Current("NumMayorizado") = 0
                .Current("Modulo") = modulo
                .Current("Observaciones") = modulo & ". Ajuste Inv compra: " & dt.Rows(ic).Item("Consecutivo")
                .Current("NombreUsuario") = Usuario.Nombre
                .Current("TotalDebe") = 0
                .Current("TotalHaber") = 0
                .Current("CodMoneda") = 1
                tc = fx.TipoCambio(dt.Rows(ic).Item("Fecha"), False)
                .Current("TipoCambio") = tc
                .EndCurrentEdit()



                cFunciones.Llenar_Tabla_Generico("SELECT IdBodega, Nombre, Descripcion, CuentaContable, DescripcionCuentaContable, Produccion FROM Bodega where IdBodega = " & dt.Rows(ic).Item("BodegaOrigen"), dtConf, Configuracion.Claves.Conexion("Contabilidad"))
                If dtConf.Rows.Count > 0 Then
                    cuentaInv = dtConf.Rows(0).Item("CuentaContable")
                    cuentaInvNom = dtConf.Rows(0).Item("DescripcionCuentaContable")
                End If


                Dim _dt As New DataTable
                cmd.CommandText = "SELECT cantidad * PrecioBase AS Total, CuentaContable, DescripcionCuentaContable, Id_Requisicion FROM RequisicionesDetalles Where Id_Requisicion = " & dt.Rows(ic).Item("Id_Requisicion") & " GROUP BY cantidad, PrecioBase, CuentaContable, DescripcionCuentaContable, Id_Requisicion)"
                '"SELECT a.ID_Ajuste, a.AjusteNo, d.CuentaContable, d.DescripcionCuentaContable, d.Ajuste FROM  Ajustescpagar AS a INNER JOIN      Proveedores AS p ON a.Cod_Proveedor = p.CodigoProv INNER JOIN  Detalle_AjustescPagar AS d ON a.ID_Ajuste = d.Id_AjustecPagar " & _
                '"WHERE   (a.ID_Ajuste = " & dt.Rows(ic).Item("Concecutivo") & ") AND  (a.Anula = 0) AND (a.ContaCre = 0) AND (a.ContaDeb = 0)"
                cFunciones.Llenar_Tabla_Generico(cmd, _dt, Configuracion.Claves.Conexion(conexion))

                For id As Integer = 0 To _dt.Rows.Count - 1

                    GuardaAsientoDetalle(_dt.Rows(id).Item("Total"), True, False, _dt.Rows(id).Item("CuentaContable"), _dt.Rows(id).Item("DescripcionCuentaContable"), tc)
                    GuardaAsientoDetalle(_dt.Rows(id).Item("Total"), False, True, cuentaInv, cuentaInvNom, tc)


                Next
            End With

            Me.sp_totalesAsiento(BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento"))
        Next


    End Sub
    Public Function GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String, ByVal TipoCambio As Double) As Boolean
        Try
            If Monto <> 0 And (Not Cuenta.Equals("0")) And (Not Cuenta.Equals("")) Then

				If engrosarlacuenta(Monto, Debe, Haber, Cuenta, NombreCuenta) Then

					Return True
				End If


				'CREA LOS DETALLES DE ASIENTOS CONTABLES
				BindingContext(dsAs, "DetallesAsientosContable").EndCurrentEdit()
                BindingContext(dsAs, "DetallesAsientosContable").AddNew()
                BindingContext(dsAs, "DetallesAsientosContable").Current("NumAsiento") = BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento")
                BindingContext(dsAs, "DetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(Me.dsAs, "AsientosContables").Current("Observaciones")
                BindingContext(dsAs, "DetallesAsientosContable").Current("Cuenta") = Cuenta
                BindingContext(dsAs, "DetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
                BindingContext(dsAs, "DetallesAsientosContable").Current("Monto") = Monto
                BindingContext(dsAs, "DetallesAsientosContable").Current("Debe") = Debe
                BindingContext(dsAs, "DetallesAsientosContable").Current("Haber") = Haber
                BindingContext(dsAs, "DetallesAsientosContable").Current("Tipocambio") = TipoCambio
                BindingContext(dsAs, "DetallesAsientosContable").EndCurrentEdit()
            Else
                Return False
            End If
        Catch ex As System.Exception
            'MsgBox("ERROR A INCLUIR DATO: " & ex.ToString, MsgBoxStyle.Information, "Atención...")
            BindingContext(dsAs, "DetallesAsientosContable").CancelCurrentEdit()
            Return False
        End Try
        Return True
    End Function

    Function engrosarlacuenta(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        Try

            For i As Integer = 0 To Me.dsAs.DetallesAsientosContable.Count - 1

                If BindingContext(Me.dsAs, "AsientosContables").Current("NumAsiento") = Me.dsAs.DetallesAsientosContable(i).NumAsiento And Me.dsAs.DetallesAsientosContable(i).Cuenta = Cuenta And Me.dsAs.DetallesAsientosContable(i).Debe = Debe And Me.dsAs.DetallesAsientosContable(i).Haber = Haber Then
                    Me.dsAs.DetallesAsientosContable(i).Monto += Monto
                    Return True
                End If

            Next
            Return False
        Catch ex As Exception
            ' MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        sp_guardarAsiento()
    End Sub

    Sub sp_guardarAsiento()

        If MsgBox("¿Desea guardar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        Try
            Me.btnGuardar.Enabled = False
			If TransAsiento() Then
				sp_actualizar_Datos()

				MessageBox.Show("La información se guardó correctamente.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If


		Catch ex As Exception
            Me.btnGuardar.Enabled = True
            MsgBox(ex.ToString, MsgBoxStyle.OkOnly)

        End Try

    End Sub

    Function TransAsiento() As Boolean
        Dim Trans As SqlClient.SqlTransaction      'REALIZA LA TRANSACCION DE LOS ASIENTOS CONTABLES
        Try
            If Me.cnxConta.State <> ConnectionState.Open Then cnxConta.Open()
            '
            BindingContext(dsAs, "DetallesAsientosContable").EndCurrentEdit()
            BindingContext(dsAs, "AsientosContables").EndCurrentEdit()
            Trans = cnxConta.BeginTransaction
            adpASD.UpdateCommand.Transaction = Trans
            adpASD.DeleteCommand.Transaction = Trans
            adpASD.InsertCommand.Transaction = Trans

            adpAS.UpdateCommand.Transaction = Trans
            adpAS.DeleteCommand.Transaction = Trans
            adpAS.InsertCommand.Transaction = Trans

            'INICIA LA TRANSACCION....
            adpAS.Update(dsAs, "AsientosContables")
            adpASD.Update(dsAs, "DetallesAsientosContable")
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Sub sp_actualizar_Datos()
        Select Case Me.cboTipos.Text
            Case "CHEQUES"
                sp_actualizarCHEQUES()
            Case "DEPOSITOS"
                Me.sp_actualizarDEPOSITOS()
            Case "AJUSTES BANC"
                Me.sp_actualizarAJUSTEBANC()
            Case "TRANSF ENTRE CUENTAS"
                Me.sp_actualizarTRANSFENTREBANC()
            Case "FACTURAS GASTOS"
                Me.sp_actualizarFACTURAGASTOS()
            Case "FACTURAS INVENTARIO" 'ES LA MISMA TABLA
                Me.sp_actualizarFACTURAGASTOS()
            Case "AJUSTES A CXP"
                Me.sp_actualizarAJUSTECXP()
            Case "AJUSTES A CXC"
                Me.sp_actualizarAJUSTECXC()
            Case "FACTURAS VENTAS"
                Me.sp_actualizarFACTURAVENTAS()
            Case "COSTO VENTAS"
                sp_actualizarCOSTOVENTAS()
            Case "ABONOS A CXC"
                Me.sp_actualizarABONOSCXC()
            Case "DEVOLUCION COMPRAS"
                sp_actualizarDEVOLUCIONCXP()
            Case "AJUSTE INVENTARIO"
                sp_actualizarAjusteInventario()
        End Select

    End Sub

    Sub sp_actualizarCHEQUES()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "Bancos")
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [Bancos].[dbo].[Cheques] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Cheque = " & dsAs.AsientosContables(ic).IdNumDoc & "")
        Next
        cnx.DesConectar(cnx.sQlconexion)
    End Sub

    Sub sp_actualizarDEPOSITOS()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "Bancos")
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [Bancos].[dbo].[Deposito] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Deposito = " & dsAs.AsientosContables(ic).IdNumDoc & "")
        Next
        cnx.DesConectar(cnx.sQlconexion)
    End Sub

    Sub sp_actualizarAJUSTEBANC()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "Bancos")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [Bancos].[dbo].[AjusteBancario] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Ajuste = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)
    End Sub

    Sub sp_actualizarTRANSFENTREBANC()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "Bancos")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [Bancos].[dbo].[TransferenciasBancarias ] SET [Contabilizado] = 1 ,[Num_Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Transferencia = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)
    End Sub

    Sub sp_actualizarFACTURAGASTOS()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [dbo].[compras] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Compra = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)
    End Sub

    Sub sp_actualizarFACTURAVENTAS()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SEEPOS")
        Dim msj As String
        ProgressBar1.Value = 0
        ProgressBar1.Maximum = dsAs.AsientosContables.Count

        cnx.SlqExecute(cnx.sQlconexion, "DISABLE TRIGGER Seepos.ActualizaKardexInventario_Anula_Ventas ON Seepos.dbo.Ventas;")

        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
                            "UPDATE [dbo].[Ventas] SET [Contabilizado] = 1 ,[AsientoVenta] = '" & dsAs.AsientosContables(ic).NumAsiento & "' " & _
                            " WHERE dbo.DateOnly(Fecha) = '" & Format(dsAs.AsientosContables(ic).Fecha, "dd/MM/yyyy") & "'")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If

            ProgressBar1.Value += 1
        Next

        cnx.SlqExecute(cnx.sQlconexion, "ENABLE Trigger Seepos.ActualizaKardexInventario_Anula_Ventas ON Seepos.dbo.Ventas;")

        MsgBox("Guardado Terminado", MsgBoxStyle.Information)
        ProgressBar1.Value = 0
        cnx.DesConectar(cnx.sQlconexion)    
    End Sub

    Sub sp_actualizarCOSTOVENTAS()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SEEPOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
                            "UPDATE [dbo].[Ventas] SET [ContabilizadoCVenta] = 1 " & _
                            " WHERE dbo.DateOnly(Fecha) = '" & Format(dsAs.AsientosContables(ic).Fecha, "dd/MM/yyyy") & "'")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)
    End Sub

    Public Shared Function Fn_ProcedimientosAlmacenadosSinResultados(ByVal p_nombreProcedimiento As String, Optional ByVal p_comando As SqlClient.SqlCommand = Nothing, Optional ByVal p_modulo As String = "SeePOS") As Integer
        Dim _conector As New SqlClient.SqlConnection
        Dim cnx As New Conexion
        _conector = cnx.Conectar("SeeSoft", "SeePOS")

        p_comando.Connection = _conector
        p_comando.CommandText = p_nombreProcedimiento
        p_comando.CommandType = CommandType.StoredProcedure

        Dim _dtsDatos As New DataSet

        If _conector.State <> ConnectionState.Open Then _conector.Open()
        Try
            Fn_ProcedimientosAlmacenadosSinResultados = p_comando.ExecuteNonQuery
            'MsgBox("Accion Completada Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        Finally
            cnx.DesConectar(_conector)
            p_comando.Dispose()
            p_comando = Nothing
        End Try

    End Function
    Sub sp_actualizarPREPAGOS()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [dbo].[tb_VinculoCXC] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE IdVinculo = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub
    Sub sp_actualizarAJUSTECXC()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [dbo].[ajustesccobrar] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE ID_Ajuste = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub
    Sub sp_actualizarABONOSCXC()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE dbo.abonoccobrar  SET  Contabilizado = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Recibo = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub
    Sub sp_actualizarDEVOLUCIONCXP()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String 'UPDATE devoluciones_Compras SET Contabilizado = 1, Asiento = '111' WHERE (Devolucion = 1) AND (Anulado = 0)
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE dbo.devoluciones_Compras  SET  Contabilizado = 1   WHERE Devolucion = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub
    Sub sp_actualizarAjusteInventario()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String 'UPDATE devoluciones_Compras SET Contabilizado = 1, Asiento = '111' WHERE (Devolucion = 1) AND (Anulado = 0)
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE dbo.AjusteInventario  SET  ContaEntrada = 1 , ContaSalida = 1,[AsientoSalida] = '" & dsAs.AsientosContables(ic).NumAsiento & "',[AsientoEntrada] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Consecutivo = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub
    Sub sp_actualizarAJUSTEMENOR()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [dbo].[tb_MovimientoCXC] SET [Contabilizado] = 1 ,[Asiento] = '" & dsAs.AsientosContables(ic).NumAsiento & "'  WHERE Id_Movimiento = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub
    Sub sp_actualizarAJUSTECXP()
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "SeePOS")
        Dim msj As String
        For ic As Integer = 0 To dsAs.AsientosContables.Count - 1
            msj = cnx.SlqExecute(cnx.sQlconexion, _
            "UPDATE [dbo].[Ajustescpagar] SET [Contabilizado] = 1 WHERE ID_Ajuste = " & dsAs.AsientosContables(ic).IdNumDoc & "")
            If Not (msj Is Nothing) Then
                MsgBox(msj, MsgBoxStyle.OkOnly)
                Exit For
            End If
        Next
        cnx.DesConectar(cnx.sQlconexion)

    End Sub

    Private Sub frmAsientosIndividuales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cnxConta.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")

    End Sub

    'Private Sub btnVerDif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    sp_Diferencias()
    'End Sub
    'Sub sp_Diferencias()
    '    Me.grbDiferencias.Visible = Not Me.grbDiferencias.Visible
    '    If Me.grbDiferencias.Visible Then
    '        Me.btnVerDif.BackColor = Color.Yellow
    '    Else
    '        Me.btnVerDif.BackColor = Color.Transparent
    '    End If
    'End Sub

    Private Sub grvAsiento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grvAsiento.KeyDown
        If e.KeyCode = Keys.F1 Then

            Dim frmBuscar As New fmrBuscarMayorizacionAsiento

            Dim sql As String = " select CC.cuentacontable as [Cuenta contable],CC.descripcion + ' ' + CC.cuentacontable as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
    " where Movimiento=1 "

            frmBuscar.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
            frmBuscar.sqlstring = sql
            frmBuscar.campo = "CC.descripcion"
            frmBuscar.ShowDialog()

            If frmBuscar.codigo = "" Then

            Else

                Me.BindingContext(Me.dsAs, "AsientosContables").Current("Cuenta") = frmBuscar.codigo
            End If
        End If
    End Sub

    Private Sub btnReporteXAsiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteXAsiento.Click
        Me.sp_imprimirPorAsiento()

    End Sub

    Private Sub btnReporteXCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReporteXCuenta.Click
        Me.sp_imprimirPorCuenta()
    End Sub

    Private Sub btnRptResumen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRptResumen.Click
        Me.sp_imprimirResumen()
    End Sub

    Private Sub chbReimprimir_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbReimprimir.CheckedChanged
        'Me.btnGenerar.Enabled = Not Me.chbReimprimir.Checked
        Me.btnGuardar.Enabled = Not Me.chbReimprimir.Checked
    End Sub

    Private Sub chbUnirServidor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbUnirServidor.CheckedChanged
        If Me.chbUnirServidor.Checked Then
            Me.cboServidor.Visible = True
        Else
            Me.cboServidor.Visible = False
        End If
    End Sub
End Class
