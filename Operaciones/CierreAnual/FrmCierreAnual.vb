Imports System.Data.SqlClient
Imports Utilidades

Public Class FrmCierreAnual
    Inherits System.Windows.Forms.Form

    Dim Usua As Object
    Dim cconexion As New Conexion
    Dim conectadobd As New SqlClient.SqlConnection
    Dim Utilidad As Double
    Dim CuentaPeriodo, NombreCuentaPeriodo As String
    Dim clave As String = ""
    Dim currentSaldoC As Double = 0
    Dim currentSaldoD As Double = 0
    Dim acumTotalC As Double = 0
    Dim acumTotalD As Double = 0
    Dim periodo As String = ""
    Dim periodoSiguiente As String = ""
    Dim dtCuentaRenta As New DataTable
    Friend WithEvents dgAsientoDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents IDDetalleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumAsientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreCuentaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MontoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebeDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents HaberDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DescripcionAsientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipocambioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bsAsientoDetalle As System.Windows.Forms.BindingSource
    Dim dtPorcRenta As New DataTable
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Usua = Usuario_Parametro
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
    Friend WithEvents smbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LabelUsuario As System.Windows.Forms.Label
    Friend WithEvents DsCierreAnual1 As Contabilidad.DsCierreAnual
    Friend WithEvents AdapterUtilidad As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterCuentasUtilidad As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DTP_FechaInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTP_Final As System.Windows.Forms.DateTimePicker
    Friend WithEvents B_Periodo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AdapterPeriodoFiscal As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCierreAnual))
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.btGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.TextUsuario = New System.Windows.Forms.TextBox
        Me.LabelUsuario = New System.Windows.Forms.Label
        Me.AdapterUtilidad = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.DsCierreAnual1 = New Contabilidad.DsCierreAnual
        Me.AdapterCuentasUtilidad = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.DTP_FechaInicial = New System.Windows.Forms.DateTimePicker
        Me.DTP_Final = New System.Windows.Forms.DateTimePicker
        Me.B_Periodo = New DevExpress.XtraEditors.SimpleButton
        Me.AdapterPeriodoFiscal = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.dgAsientoDetalle = New System.Windows.Forms.DataGridView
        Me.IDDetalleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumAsientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreCuentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DebeDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.HaberDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DescripcionAsientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipocambioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bsAsientoDetalle = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCierreAnual1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAsientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAsientoDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'smbGenerar
        '
        Me.smbGenerar.Enabled = False
        Me.smbGenerar.Location = New System.Drawing.Point(8, 41)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.Size = New System.Drawing.Size(98, 31)
        Me.smbGenerar.TabIndex = 1
        Me.smbGenerar.Text = "Generar"
        '
        'btGuardar
        '
        Me.btGuardar.Enabled = False
        Me.btGuardar.Location = New System.Drawing.Point(112, 41)
        Me.btGuardar.Name = "btGuardar"
        Me.btGuardar.Size = New System.Drawing.Size(98, 31)
        Me.btGuardar.TabIndex = 2
        Me.btGuardar.Text = "Guardar"
        '
        'AdapterAsientos
        '
        Me.AdapterAsientos.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterAsientos.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterAsientos.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdapterAsientos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=IALVAREZ\MOTOR4;Initial Catalog=Contabilidad;Integrated Security=True" & _
            ""
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'AdapterDetallesAsientos
        '
        Me.AdapterDetallesAsientos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdapterDetallesAsientos.InsertCommand = Me.SqlInsertCommand2
        Me.AdapterDetallesAsientos.SelectCommand = Me.SqlSelectCommand2
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
            "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 391)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(692, 24)
        Me.StatusBar1.TabIndex = 153
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "Usuario"
        Me.StatusBarPanel2.Width = 150
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Width = 526
        '
        'TextUsuario
        '
        Me.TextUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsuario.Location = New System.Drawing.Point(50, 399)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextUsuario.Size = New System.Drawing.Size(98, 13)
        Me.TextUsuario.TabIndex = 0
        '
        'LabelUsuario
        '
        Me.LabelUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(163, 397)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(127, 16)
        Me.LabelUsuario.TabIndex = 155
        '
        'AdapterUtilidad
        '
        Me.AdapterUtilidad.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterUtilidad.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterUtilidad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaUtilidad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO CuentaUtilidad(CuentaContable, Descripcion) VALUES (@CuentaContable, " & _
            "@Descripcion); SELECT CuentaContable, Descripcion FROM CuentaUtilidad"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CuentaContable, Descripcion FROM CuentaUtilidad"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'DsCierreAnual1
        '
        Me.DsCierreAnual1.DataSetName = "DsCierreAnual"
        Me.DsCierreAnual1.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DsCierreAnual1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdapterCuentasUtilidad
        '
        Me.AdapterCuentasUtilidad.SelectCommand = Me.SqlSelectCommand4
        Me.AdapterCuentasUtilidad.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentasDeUtilidad", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("NoDeducible", "NoDeducible")})})
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT     CuentaContable, Descripcion, Tipo, Nivel, GastoNoDeducible AS NoDeduci" & _
            "ble" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM         CuentasDeUtilidad"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'DTP_FechaInicial
        '
        Me.DTP_FechaInicial.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsCierreAnual1, "PeriodoFiscal.FechaInicio", True))
        Me.DTP_FechaInicial.Enabled = False
        Me.DTP_FechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_FechaInicial.Location = New System.Drawing.Point(8, 15)
        Me.DTP_FechaInicial.Name = "DTP_FechaInicial"
        Me.DTP_FechaInicial.Size = New System.Drawing.Size(98, 20)
        Me.DTP_FechaInicial.TabIndex = 156
        '
        'DTP_Final
        '
        Me.DTP_Final.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DsCierreAnual1, "PeriodoFiscal.FechaFinal", True))
        Me.DTP_Final.Enabled = False
        Me.DTP_Final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP_Final.Location = New System.Drawing.Point(112, 16)
        Me.DTP_Final.Name = "DTP_Final"
        Me.DTP_Final.Size = New System.Drawing.Size(102, 20)
        Me.DTP_Final.TabIndex = 157
        '
        'B_Periodo
        '
        Me.B_Periodo.Enabled = False
        Me.B_Periodo.Location = New System.Drawing.Point(220, 15)
        Me.B_Periodo.Name = "B_Periodo"
        Me.B_Periodo.Size = New System.Drawing.Size(76, 21)
        Me.B_Periodo.TabIndex = 158
        Me.B_Periodo.Text = "Periodo"
        '
        'AdapterPeriodoFiscal
        '
        Me.AdapterPeriodoFiscal.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdapterPeriodoFiscal.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterPeriodoFiscal.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterPeriodoFiscal.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PeriodoFiscal", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("FechaInicio", "FechaInicio"), New System.Data.Common.DataColumnMapping("FechaFinal", "FechaFinal"), New System.Data.Common.DataColumnMapping("Estado", "Estado")})})
        Me.AdapterPeriodoFiscal.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM PeriodoFiscal WHERE (Id = @Original_Id) AND (Estado = @Original_Estad" & _
            "o) AND (FechaFinal = @Original_FechaFinal) AND (FechaInicio = @Original_FechaIni" & _
            "cio)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaInicio", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO PeriodoFiscal(FechaInicio, FechaFinal, Estado) VALUES (@FechaInicio, " & _
            "@FechaFinal, @Estado); SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFi" & _
            "scal WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FechaInicio", System.Data.SqlDbType.DateTime, 8, "FechaInicio"), New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 1, "Estado")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@FechaInicio", System.Data.SqlDbType.DateTime, 8, "FechaInicio"), New System.Data.SqlClient.SqlParameter("@FechaFinal", System.Data.SqlDbType.DateTime, 8, "FechaFinal"), New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 1, "Estado"), New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaFinal", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaFinal", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaInicio", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaInicio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.BigInt, 8, "Id")})
        '
        'dgAsientoDetalle
        '
        Me.dgAsientoDetalle.AllowUserToAddRows = False
        Me.dgAsientoDetalle.AllowUserToDeleteRows = False
        Me.dgAsientoDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgAsientoDetalle.AutoGenerateColumns = False
        Me.dgAsientoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAsientoDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDetalleDataGridViewTextBoxColumn, Me.NumAsientoDataGridViewTextBoxColumn, Me.CuentaDataGridViewTextBoxColumn, Me.NombreCuentaDataGridViewTextBoxColumn, Me.MontoDataGridViewTextBoxColumn, Me.DebeDataGridViewCheckBoxColumn, Me.HaberDataGridViewCheckBoxColumn, Me.DescripcionAsientoDataGridViewTextBoxColumn, Me.TipocambioDataGridViewTextBoxColumn})
        Me.dgAsientoDetalle.DataSource = Me.bsAsientoDetalle
        Me.dgAsientoDetalle.Location = New System.Drawing.Point(9, 92)
        Me.dgAsientoDetalle.Name = "dgAsientoDetalle"
        Me.dgAsientoDetalle.Size = New System.Drawing.Size(666, 293)
        Me.dgAsientoDetalle.TabIndex = 159
        '
        'IDDetalleDataGridViewTextBoxColumn
        '
        Me.IDDetalleDataGridViewTextBoxColumn.DataPropertyName = "ID_Detalle"
        Me.IDDetalleDataGridViewTextBoxColumn.HeaderText = "ID_Detalle"
        Me.IDDetalleDataGridViewTextBoxColumn.Name = "IDDetalleDataGridViewTextBoxColumn"
        Me.IDDetalleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumAsientoDataGridViewTextBoxColumn
        '
        Me.NumAsientoDataGridViewTextBoxColumn.DataPropertyName = "NumAsiento"
        Me.NumAsientoDataGridViewTextBoxColumn.HeaderText = "NumAsiento"
        Me.NumAsientoDataGridViewTextBoxColumn.Name = "NumAsientoDataGridViewTextBoxColumn"
        '
        'CuentaDataGridViewTextBoxColumn
        '
        Me.CuentaDataGridViewTextBoxColumn.DataPropertyName = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta"
        Me.CuentaDataGridViewTextBoxColumn.Name = "CuentaDataGridViewTextBoxColumn"
        '
        'NombreCuentaDataGridViewTextBoxColumn
        '
        Me.NombreCuentaDataGridViewTextBoxColumn.DataPropertyName = "NombreCuenta"
        Me.NombreCuentaDataGridViewTextBoxColumn.HeaderText = "NombreCuenta"
        Me.NombreCuentaDataGridViewTextBoxColumn.Name = "NombreCuentaDataGridViewTextBoxColumn"
        '
        'MontoDataGridViewTextBoxColumn
        '
        Me.MontoDataGridViewTextBoxColumn.DataPropertyName = "Monto"
        Me.MontoDataGridViewTextBoxColumn.HeaderText = "Monto"
        Me.MontoDataGridViewTextBoxColumn.Name = "MontoDataGridViewTextBoxColumn"
        '
        'DebeDataGridViewCheckBoxColumn
        '
        Me.DebeDataGridViewCheckBoxColumn.DataPropertyName = "Debe"
        Me.DebeDataGridViewCheckBoxColumn.HeaderText = "Debe"
        Me.DebeDataGridViewCheckBoxColumn.Name = "DebeDataGridViewCheckBoxColumn"
        '
        'HaberDataGridViewCheckBoxColumn
        '
        Me.HaberDataGridViewCheckBoxColumn.DataPropertyName = "Haber"
        Me.HaberDataGridViewCheckBoxColumn.HeaderText = "Haber"
        Me.HaberDataGridViewCheckBoxColumn.Name = "HaberDataGridViewCheckBoxColumn"
        '
        'DescripcionAsientoDataGridViewTextBoxColumn
        '
        Me.DescripcionAsientoDataGridViewTextBoxColumn.DataPropertyName = "DescripcionAsiento"
        Me.DescripcionAsientoDataGridViewTextBoxColumn.HeaderText = "DescripcionAsiento"
        Me.DescripcionAsientoDataGridViewTextBoxColumn.Name = "DescripcionAsientoDataGridViewTextBoxColumn"
        '
        'TipocambioDataGridViewTextBoxColumn
        '
        Me.TipocambioDataGridViewTextBoxColumn.DataPropertyName = "Tipocambio"
        Me.TipocambioDataGridViewTextBoxColumn.HeaderText = "Tipocambio"
        Me.TipocambioDataGridViewTextBoxColumn.Name = "TipocambioDataGridViewTextBoxColumn"
        '
        'bsAsientoDetalle
        '
        Me.bsAsientoDetalle.DataMember = "DetallesAsientosContable"
        Me.bsAsientoDetalle.DataSource = Me.DsCierreAnual1
        '
        'FrmCierreAnual
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(692, 415)
        Me.Controls.Add(Me.dgAsientoDetalle)
        Me.Controls.Add(Me.B_Periodo)
        Me.Controls.Add(Me.DTP_Final)
        Me.Controls.Add(Me.DTP_FechaInicial)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.btGuardar)
        Me.Controls.Add(Me.smbGenerar)
        Me.Name = "FrmCierreAnual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cierre Anual"
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCierreAnual1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAsientoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAsientoDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub FrmCierreAnual_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        conectadobd = cconexion.Conectar("Contabilidad")
        ValoresDefecto()
        AdapterUtilidad.Fill(DsCierreAnual1.CuentaUtilidad)
        AdapterCuentasUtilidad.Fill(DsCierreAnual1.CuentasDeUtilidad)
        AdapterPeriodoFiscal.Fill(DsCierreAnual1.PeriodoFiscal)
        cls_Datos.sp_llenarTabla("Select PorcImpuestoRenta AS Porc From SettingCuentaContable", dtPorcRenta, "Contabilidad")
        cls_Datos.sp_llenarTabla("SELECT CuentaContable, Descripcion FROM dbo.CuentaContable WHERE (id =  (SELECT idImpuestoRenta  FROM settingcuentacontable))", dtCuentaRenta, "Contabilidad")
        clave = Configuracion.Claves.Configuracion("Clave")
        If clave.Equals("") Then
            SaveSetting("seesoft", "seguridad", "clave", "1")
        End If
        If Configuracion.Claves.Configuracion("Clave") = "0" Then
            Me.LabelUsuario.Text = Usua.Nombre
            B_Periodo.Enabled = True
            smbGenerar.Focus()
        Else
            TextUsuario.Focus()
        End If
    End Sub


    Public Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsCierreAnual1.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsCierreAnual1.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsCierreAnual1.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsCierreAnual1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsCierreAnual1.AsientosContables.TipoDocColumn.DefaultValue = 30
        DsCierreAnual1.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsCierreAnual1.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsCierreAnual1.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsCierreAnual1.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsCierreAnual1.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsCierreAnual1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsCierreAnual1.AsientosContables.ModuloColumn.DefaultValue = "Valuación"
        DsCierreAnual1.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsCierreAnual1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsCierreAnual1.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsCierreAnual1.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DsCierreAnual1.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DsCierreAnual1.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsCierreAnual1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsCierreAnual1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsCierreAnual1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsCierreAnual1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsCierreAnual1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsCierreAnual1.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsCierreAnual1.DetallesAsientosContable.HaberColumn.DefaultValue = 0
    End Sub
#End Region

#Region "Botones"
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        If MessageBox.Show("¿Desea Generar el Cierre Anual?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If ValidaPeriodoFiscal() Then
                MsgBox("No puede Cerrar el periodo fiscal porque hay periodos anteriores abiertos!!!", MsgBoxStyle.Exclamation, "Cierre Anual")
                Exit Sub
            End If
            If ValidaPeriodo() Then
                If MsgBox("Advertencia hay periodos de trabajo abiertos!!!, ¿DESEA CONTINUAR DE TODOS MODOS?", MsgBoxStyle.YesNo, "Cierre Anual") = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            GuardaAsiento()          
        End If
    End Sub


    Private Sub B_Periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Periodo.Click
        Buscar()
    End Sub


    Private Sub btGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btGuardar.Click
        If MsgBox("¿Desea guardar y cerrar el periodo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            If TransAsiento() = False Then
                MsgBox("Error en la generación del Cierre Anual", MsgBoxStyle.Exclamation, "Cierre Anual")
                Exit Sub
            Else
                MsgBox("Cierre anual generado Satisfactoriamente", MsgBoxStyle.Information, "Cierre Anual")
                Exit Sub
            End If
            Me.Close()


        End If

    End Sub
#End Region

#Region "Buscar Periodo"
    Private Sub Buscar()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            If Me.BindingContext(Me.DsCierreAnual1, "PeriodoFiscal").Count > 0 Then
                Me.BindingContext(Me.DsCierreAnual1, "PeriodoFiscal").CancelCurrentEdit()
            End If

            valor = Fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal where Estado = 0", "FechaInicio", "Buscar Periodo Fiscal...", Me.SqlConnection1.ConnectionString, 0, " Order by Id DESC")

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DsCierreAnual1.PeriodoFiscal.DefaultView
                vista.Sort = "Id"
                pos = vista.Find(valor)
                Me.BindingContext(Me.DsCierreAnual1, "PeriodoFiscal").Position = pos
            End If

            smbGenerar.Enabled = True

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Validaciones"
    Function ValidaPeriodoFiscal() As Boolean
        Try                     'VERIFICA QUE NO HAYAN PERIODOS FISCALES ANTERIORES ABIERTOS
            ValidaPeriodoFiscal = False
            For i As Integer = 0 To DsCierreAnual1.PeriodoFiscal.Count - 1
                If DsCierreAnual1.PeriodoFiscal(i).Estado = False Then
                    If DsCierreAnual1.PeriodoFiscal(i).FechaFinal < BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaInicio") Then
                        ValidaPeriodoFiscal = True
                    End If
                End If
            Next i

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function


    Function ValidaPeriodo() As Boolean
        Dim cConexion As New Conexion       'VERIFICA QUE NO HAYAN MESES ABIERTOS PARA EL PERIODO FISCAL
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try
            ValidaPeriodo = False
            'BUSCA EL MES Y EL AÑO DEL PERIODO QUE SE ENCUENTRA ABIERTO PARA EL PERIODO FISCAL
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT COUNT(Periodo) AS Abiertos FROM Periodo WHERE ((CAST (CONVERT(DATETIME, '01' + '/' + STR(Mes) + '/' + STR(Anno), 103) AS DATETIME)) BETWEEN '" & Format(BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaInicio"), "dd/MM/yyyy") & "' AND '" & Format(BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaFinal"), "dd/MM/yyyy") & "')  AND (Estado = 0)")

            While rs.Read
                Try
                    If rs("Abiertos") > 0 Then
                        ValidaPeriodo = True
                    End If

                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function
#End Region

#Region "Validación Usuario"
    Private Sub TextUsuario_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                Dim sql As String
                Dim clsConexion As New Conexion
                Dim cnnConexion As New SqlConnection
                Dim rstReader As SqlDataReader

                cnnConexion = clsConexion.Conectar("", "Seguridad")
                sql = " SELECT Nombre FROM Usuarios WHERE Clave_Interna ='" & TextUsuario.Text & "'"
                rstReader = clsConexion.GetRecorset(cnnConexion, sql)
                If rstReader.Read() = False Then
                    MsgBox("Usuario Incorrecto", MsgBoxStyle.Critical, "Asiento Valuación")
                    LabelUsuario.Text = Nothing
                    B_Periodo.Enabled = False
                    TextUsuario.Focus()
                Else
                    LabelUsuario.Text = rstReader.Item("Nombre")
                    B_Periodo.Enabled = True
                    smbGenerar.Focus()
                End If
                clsConexion.DesConectar(cnnConexion)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Contabilidad - Entrada _Usuario")
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
#End Region

#Region "Asientos Contables"
    Public Sub GuardaAsiento()
        Dim NumeroAsiento As String     'CREA EL ASIENTO CONTABLE
        Dim Fx As New cFunciones

        'BUSCA EL NUMERO DE ASIENTO
        NumeroAsiento = Fx.BuscaNumeroAsiento("CAN-" & Format(DTP_Final.Value.Month, "00") & Format(DTP_Final.Value.Date, "yy") & "-")
        periodo = Fx.BuscaPeriodo(Format(BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaFinal"), "dd/MM/yyyy"))

        BindingContext(DsCierreAnual1, "AsientosContables").EndCurrentEdit()
        BindingContext(DsCierreAnual1, "AsientosContables").AddNew()
        BindingContext(DsCierreAnual1, "AsientosContables").Current("NumAsiento") = NumeroAsiento
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Fecha") = BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaFinal")
        BindingContext(DsCierreAnual1, "AsientosContables").Current("IdNumDoc") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("NumDoc") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Beneficiario") = ""
        BindingContext(DsCierreAnual1, "AsientosContables").Current("TipoDoc") = 30
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Mayorizado") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Periodo") = periodo
        BindingContext(DsCierreAnual1, "AsientosContables").Current("NumMayorizado") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Modulo") = "Cierre Anual"
        BindingContext(DsCierreAnual1, "AsientosContables").Current("Observaciones") = "Asiento de Cierre Anual # " & BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaInicio") & " - " & BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaFinal")
        BindingContext(DsCierreAnual1, "AsientosContables").Current("NombreUsuario") = LabelUsuario.Text
        BindingContext(DsCierreAnual1, "AsientosContables").Current("TotalDebe") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("TotalHaber") = 0
        BindingContext(DsCierreAnual1, "AsientosContables").Current("CodMoneda") = 1
        BindingContext(DsCierreAnual1, "AsientosContables").Current("TipoCambio") = TipoCambio()
        BindingContext(DsCierreAnual1, "AsientosContables").EndCurrentEdit()

        AsientoDetalle()    'CREA LOS DETALLES DEL ASIENTO

        BindingContext(DsCierreAnual1, "AsientosContables").Current("TotalDebe") = TotalDebe()
        BindingContext(DsCierreAnual1, "AsientosContables").Current("TotalHaber") = TotalHaber()
        BindingContext(DsCierreAnual1, "AsientosContables").EndCurrentEdit()

        BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("Estado") = 1
        BindingContext(DsCierreAnual1, "PeriodoFiscal").EndCurrentEdit()
    End Sub


    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String, ByVal TipoCambio As Double)
        If Monto <> 0 Then   'GUARDA LOS DETALLES DEL ASIENTO CONTABLE
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsCierreAnual1, "AsientosContables").Current("NumAsiento")
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsCierreAnual1, "AsientosContables").Current("Observaciones")
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Tipocambio") = TipoCambio
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
        End If
    End Sub
    Sub SaldoAnterior(ByVal Fecha As Date, ByVal cuenta As String, ByVal TipoCuenta As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES PARA EL CALCULO DEL SALDO ANTERIOR
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim dt As New DataTable
        currentSaldoC = 0
        currentSaldoD = 0
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Debe = 0 : Haber = 0 : Monto = 0 : DebeD = 0 : HaberD = 0

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand

            Dim sql As String = ""
            sql = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
    " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
    " FROM         dbo.AsientoDC_DH INNER JOIN  dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
    " WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) AND (dbo.AsientoDC_DH.Cuenta = '" & cuenta & "') " & _
    " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

            cmdv.CommandText = sql
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            cmdv.Parameters("@Fecha").Value = Fecha
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            dv.Fill(dt)

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try


        If dt.Rows.Count = 0 Then
            currentSaldoC = 0
            currentSaldoD = 0
            Exit Sub
        End If

        For i As Integer = 0 To dt.Rows.Count - 1
            Debe += dt.Rows(i).Item("Dcolon")
            Haber += dt.Rows(i).Item("Hcolon")
            DebeD += dt.Rows(i).Item("Ddolar")
            HaberD += dt.Rows(i).Item("Hdolar")

        Next
        If TipoCuenta.Equals("ACTIVOS") Or TipoCuenta.Equals("GASTOS") Or TipoCuenta.Equals("COSTO VENTA") Then
            Me.currentSaldoC = Debe - Haber
            Me.currentSaldoD = DebeD - HaberD
        Else
            Me.currentSaldoC = Haber - Debe
            Me.currentSaldoD = HaberD - DebeD
        End If




    End Sub

    Public Sub AsientoDetalle()
        Dim TDebeC, THaberC, TDebeD, THaberD As Double
        Dim TIngNoDeduc As Double = 0 : Dim TGasNoDeduc As Double = 0
        Dim Debe, Haber As Boolean
        Dim Fecha As DateTime = BindingContext(DsCierreAnual1, "PeriodoFiscal").Current("FechaFinal")
        Dim f As Date = Fecha.AddDays(1)
        Dim fx As New cFunciones
        periodoSiguiente = fx.BuscaPeriodo(Format(f, "dd/MM/yyyy"))
        Try
            For i As Integer = 0 To DsCierreAnual1.CuentasDeUtilidad.Count - 1

                Me.SaldoAnterior(f, DsCierreAnual1.CuentasDeUtilidad(i).CuentaContable, DsCierreAnual1.CuentasDeUtilidad(i).Tipo)

                If DsCierreAnual1.CuentasDeUtilidad(i).Tipo = "INGRESOS" Or DsCierreAnual1.CuentasDeUtilidad(i).Tipo = "OTROS INGRESOS" Then

                    If currentSaldoC > 0 Then
                        Debe = True
                        Haber = False

                    Else
                        currentSaldoC = Math.Abs(currentSaldoC)
                        Debe = False
                        Haber = True

                    End If

                    If DsCierreAnual1.CuentasDeUtilidad(i).NoDeducible Then
                        TIngNoDeduc += Math.Abs(currentSaldoC)

                    End If

                Else

                    If currentSaldoC > 0 Then
                        Debe = False
                        Haber = True

                    Else

                        If DsCierreAnual1.CuentasDeUtilidad(i).CuentaContable.StartsWith("7") Then
                            Debe = False
                            Haber = True

                        Else
                            currentSaldoC = Math.Abs(currentSaldoC)
                            Debe = True
                            Haber = False

                        End If

                    End If

                    If DsCierreAnual1.CuentasDeUtilidad(i).NoDeducible Then
                        TGasNoDeduc += Math.Abs(currentSaldoC)
                    End If

                End If
                'GUARDA EL DETALLE DEL ASIENTO CONTABLE PARA LA CUENTA
                Dim tc As Double = 0
                If currentSaldoD = 0 Then
                    tc = 0
                Else
                    tc = Me.currentSaldoC / Me.currentSaldoD

                End If
                GuardaAsientoDetalle(currentSaldoC, Debe, Haber, DsCierreAnual1.CuentasDeUtilidad(i).CuentaContable, DsCierreAnual1.CuentasDeUtilidad(i).Descripcion, Math.Abs(tc))

            Next
            
            'SUMA TODOS LOS MONTOS DEL DEBE Y DEL HABER PARA CALCULAR LA UTILIDAD
            For i As Integer = 0 To DsCierreAnual1.DetallesAsientosContable.Count - 1
                If DsCierreAnual1.DetallesAsientosContable(i).Debe Then
                    TDebeC += DsCierreAnual1.DetallesAsientosContable(i).Monto
                    If DsCierreAnual1.DetallesAsientosContable(i).Tipocambio <> 0 Then
                        TDebeD += (DsCierreAnual1.DetallesAsientosContable(i).Monto / DsCierreAnual1.DetallesAsientosContable(i).Tipocambio)
                    End If


                Else
                    THaberC += DsCierreAnual1.DetallesAsientosContable(i).Monto
                    If DsCierreAnual1.DetallesAsientosContable(i).Tipocambio <> 0 Then
                        THaberD += (DsCierreAnual1.DetallesAsientosContable(i).Monto / DsCierreAnual1.DetallesAsientosContable(i).Tipocambio)
                    End If

                End If
            Next
            'calcula utilidad
            Dim utilidadC As Double = (TDebeC - THaberC)
            Dim utilidadD As Double = (TDebeD - THaberD)
            'caldula tipoCambipo

            Dim tipoCambio As Double = utilidadC / utilidadD
           
            'VERIFICA SI EL MONTO VA AL DEBE O AL HABER
            If utilidadC > 0 Then
                Debe = False
                Haber = True

            Else
                Debe = True
                Haber = False
            End If
            'CALCULA IMPUESTO DE RENTA
            Dim renta As Double = 0
            Dim utilidadRenta As Double = (TDebeC - TIngNoDeduc) - (THaberC - TGasNoDeduc)
            If utilidadRenta > 0 Then
                renta = utilidadC * (dtPorcRenta.Rows(0).Item("Porc") / 100)
            End If

            'GUARDA EL MONTO DE LA UTILIDAD DEL PERIODO
            GuardaAsientoDetalle(Math.Abs(utilidadC - renta), Debe, Haber, DsCierreAnual1.CuentaUtilidad(0).CuentaContable, DsCierreAnual1.CuentaUtilidad(0).Descripcion, Math.Abs(tipoCambio))
            'GUARDA EL MONTO DE LA RENTA DEL PERIODO
            GuardaAsientoDetalle(renta, False, True, dtCuentaRenta.Rows(0).Item("CuentaContable"), dtCuentaRenta.Rows(0).Item("Descripcion"), Math.Abs(tipoCambio))
            Me.btGuardar.Enabled = True

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Comunique el siguiente error a su empresa proveedora de software")
        End Try
    End Sub


    Function TransAsiento() As Boolean
        Dim Trans As SqlTransaction

        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()

            Trans = SqlConnection1.BeginTransaction
            BindingContext(DsCierreAnual1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            'BindingContext(DsCierreAnual1, "AsientosContables").Current("TipoCambio") = Me.acumTotalC / Me.acumTotalD
            BindingContext(DsCierreAnual1, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = Trans
            AdapterDetallesAsientos.DeleteCommand.Transaction = Trans
            AdapterDetallesAsientos.InsertCommand.Transaction = Trans

            AdapterAsientos.UpdateCommand.Transaction = Trans
            AdapterAsientos.DeleteCommand.Transaction = Trans
            AdapterAsientos.InsertCommand.Transaction = Trans

            AdapterPeriodoFiscal.UpdateCommand.Transaction = Trans
            AdapterPeriodoFiscal.DeleteCommand.Transaction = Trans
            AdapterPeriodoFiscal.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            If cFunciones.ValidarAsientos(DsCierreAnual1.AsientosContables, DsCierreAnual1.DetallesAsientosContable, 1) Then
                AdapterDetallesAsientos.Update(DsCierreAnual1.DetallesAsientosContable)
                AdapterAsientos.Update(DsCierreAnual1.AsientosContables)
            Else
                MsgBox("No se pudo guardar el asiento. Anule el movimiento y vuelva a crearlo. Y contacte a soporte.")
            End If

            AdapterPeriodoFiscal.Update(DsCierreAnual1.PeriodoFiscal)
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function


    Function TipoCambio() As Double
        Try
            Dim Fx As New cFunciones
            TipoCambio = Fx.TipoCambio(DTP_Final.Value, True)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Function


    Function TotalDebe() As Double
        Dim total As Double = 0
        For i As Integer = 0 To DsCierreAnual1.DetallesAsientosContable.Count - 1
            If DsCierreAnual1.DetallesAsientosContable(i).Debe Then
                total += DsCierreAnual1.DetallesAsientosContable(i).Monto
            End If

        Next i
        Return total

    End Function
    Function TotalHaber() As Double
        Dim total As Double = 0
        For i As Integer = 0 To DsCierreAnual1.DetallesAsientosContable.Count - 1
            If DsCierreAnual1.DetallesAsientosContable(i).Debe Then
                total += DsCierreAnual1.DetallesAsientosContable(i).Monto
            End If
        Next i
        Return total

    End Function
#End Region

    Private Sub TextUsuario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextUsuario.TextChanged

    End Sub
End Class
