Imports System.Data.SqlClient
Imports Utilidades

Public Class Valuacion
    Inherits System.Windows.Forms.Form


#Region "Variables"
    Dim Usua As Usuario_Logeado
    Dim _FechaFinal As DateTime
    Dim _FechaInicial As DateTime
    Public _Cerrar As String
    Dim MontoDiferencial, MontoDiferencialGasto, TipoCambioAnterior, TipoCambioAnteriorVenta As Double
    Dim CuentaDiferencial, NombreCuentaDiferencial, CuentaDiferencialGasto, NombreCuentaDiferencialGasto As String
    Dim NumeroAsiento, Periodo, NumeroAsientoDol As String
    Dim cconexion As New Conexion
    Dim conectadobd As New SqlClient.SqlConnection
    Friend WithEvents Label1 As Label
    Dim clave As String = ""
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, ByVal FechaInicial As DateTime, ByVal FechaCierre As DateTime)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        Usua = Usuario_Parametro
        _FechaFinal = FechaCierre
        _FechaInicial = FechaInicial

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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsValuacion As Contabilidad.DsValuacion
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LabelUsuario As System.Windows.Forms.Label
    Friend WithEvents AdapterSettings As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtVenta As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Valuacion))
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.AdapterAsientos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.AdapterDetallesAsientos = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand()
        Me.DsValuacion = New Contabilidad.DsValuacion()
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.TextUsuario = New System.Windows.Forms.TextBox()
        Me.LabelUsuario = New System.Windows.Forms.Label()
        Me.AdapterSettings = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand()
        Me.txtVenta = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DsValuacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtVenta.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'smbGenerar
        '
        Me.smbGenerar.Enabled = False
        Me.smbGenerar.Location = New System.Drawing.Point(84, 70)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.Size = New System.Drawing.Size(98, 31)
        Me.smbGenerar.TabIndex = 5
        Me.smbGenerar.Text = "Generar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(216, 70)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 31)
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Cerrar"
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
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" &
    "persist security info=False;initial catalog=Contabilidad"
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
        Me.AdapterDetallesAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdapterDetallesAsientos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" &
    "ionAsiento, TipoCambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'DsValuacion
        '
        Me.DsValuacion.DataSetName = "DsValuacion"
        Me.DsValuacion.Locale = New System.Globalization.CultureInfo("es-ES")
        Me.DsValuacion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 107)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(383, 24)
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
        Me.StatusBarPanel3.Width = 216
        '
        'TextUsuario
        '
        Me.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsuario.Location = New System.Drawing.Point(46, 114)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextUsuario.Size = New System.Drawing.Size(98, 13)
        Me.TextUsuario.TabIndex = 0
        '
        'LabelUsuario
        '
        Me.LabelUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(154, 111)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(142, 16)
        Me.LabelUsuario.TabIndex = 155
        '
        'AdapterSettings
        '
        Me.AdapterSettings.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterSettings.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterSettings.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SettingCuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdDiferencial", "IdDiferencial"), New System.Data.Common.DataColumnMapping("IdDiferencialGasto", "IdDiferencialGasto"), New System.Data.Common.DataColumnMapping("IdPeriodo", "IdPeriodo")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdDiferencial", System.Data.SqlDbType.Int, 4, "IdDiferencial"), New System.Data.SqlClient.SqlParameter("@IdDiferencialGasto", System.Data.SqlDbType.Int, 4, "IdDiferencialGasto"), New System.Data.SqlClient.SqlParameter("@IdPeriodo", System.Data.SqlDbType.Int, 4, "IdPeriodo")})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT IdDiferencial, IdDiferencialGasto, IdPeriodo FROM SettingCuentaContable"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'txtVenta
        '
        Me.txtVenta.EditValue = "0.00"
        Me.txtVenta.Location = New System.Drawing.Point(157, 35)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtVenta.Size = New System.Drawing.Size(76, 19)
        Me.txtVenta.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 177
        Me.Label1.Text = "Tipo de cambio valuación"
        '
        'Valuacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(383, 131)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.smbGenerar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.Name = "Valuacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VALUACIÓN"
        CType(Me.DsValuacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtVenta.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"
    Private Sub Valuacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        ValoresDefecto()
        conectadobd = cconexion.Conectar("Contabilidad")
        AdapterSettings.Fill(DsValuacion.SettingCuentaContable)
        Cuenta()
        CuentaGasto()
        CargarTipoCambio()
        clave = Configuracion.Claves.Configuracion("Clave")
        If clave.Equals("") Then
            SaveSetting("seesoft", "seguridad", "clave", "1")
        End If
        If Configuracion.Claves.Configuracion("Clave") = "0" Then
            Me.LabelUsuario.Text = Usua.Nombre
            Me.TextUsuario.Enabled = False
            smbGenerar.Enabled = True
        Else
            Me.TextUsuario.Focus()
        End If
    End Sub

    Private Sub CargarTipoCambio()
        Dim fx As New cFunciones

        Try

            txtVenta.Text = fx.TipoCambio(_FechaFinal, True)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsValuacion.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsValuacion.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsValuacion.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsValuacion.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsValuacion.AsientosContables.TipoDocColumn.DefaultValue = 29
        DsValuacion.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsValuacion.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsValuacion.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsValuacion.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsValuacion.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsValuacion.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsValuacion.AsientosContables.ModuloColumn.DefaultValue = "Valuación"
        DsValuacion.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsValuacion.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsValuacion.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsValuacion.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DsValuacion.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DsValuacion.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsValuacion.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsValuacion.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsValuacion.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsValuacion.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsValuacion.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsValuacion.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsValuacion.DetallesAsientosContable.HaberColumn.DefaultValue = 0
        DsValuacion.DetallesAsientosContable.TipoCambioColumn.DefaultValue = 1
    End Sub


    Public Sub Cuenta()
        Try
            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New SqlConnection
            Dim rstReader As SqlDataReader

            cnnConexion = clsConexion.Conectar("Contabilidad")
            sql = " SELECT CuentaContable, Descripcion FROM CuentaContable WHERE Id =" & DsValuacion.SettingCuentaContable(0).Item("IdDiferencial")
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            If rstReader.Read() = True Then
                CuentaDiferencial = rstReader("CuentaContable")
                NombreCuentaDiferencial = rstReader("Descripcion")
            Else
                MsgBox("No se encuentra la Cuenta de Diferencial Cambiario", MsgBoxStyle.Critical, "Asiento Valuación")
            End If
            clsConexion.DesConectar(cnnConexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Asiento Valuación")
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub


    Public Sub CuentaGasto()
        Try
            Dim sql As String
            Dim clsConexion As New Conexion
            Dim cnnConexion As New SqlConnection
            Dim rstReader As SqlDataReader

            cnnConexion = clsConexion.Conectar("Contabilidad")
            sql = " SELECT CuentaContable, Descripcion FROM CuentaContable WHERE Id =" & DsValuacion.SettingCuentaContable(0).Item("IdDiferencialGasto")
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)
            If rstReader.Read() = True Then
                CuentaDiferencialGasto = rstReader("CuentaContable")
                NombreCuentaDiferencialGasto = rstReader("Descripcion")
            Else
                MsgBox("No se encuentra la Cuenta de Diferencial Cambiario", MsgBoxStyle.Critical, "Asiento Valuación")
            End If
            clsConexion.DesConectar(cnnConexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Asiento Valuación")
            Console.WriteLine(ex.StackTrace)
        End Try
    End Sub
#End Region

#Region "Botones"
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        If MessageBox.Show("¿Desea Generar el Asiento de Valuación?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim Fx As New cFunciones
            If Fx.ValidarPeriodoAsientoValuacion(_FechaFinal) = False Then
                MsgBox("La Fecha del Asiento No Corresponde al Periodo de Trabajo! O el Periodo esta Cerrado!" & vbCrLf & "No se puede Guardar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
                Exit Sub
            End If

            Dim dtExisteCuentas As New DataTable()
            dtExisteCuentas.Clear()
            cFunciones.Llenar_Tabla_Generico("select * from CuentaContable where Evaluacion=1 ", dtExisteCuentas)

            If dtExisteCuentas.Rows.Count > 0 Then


                GuardaAsiento()
                If TransAsiento() = False Then
                    MsgBox("Error en la Generación del Asiento Contable", MsgBoxStyle.Exclamation, "Asiento de Valuacion")
                End If
                MsgBox("Asiento Contable Generado Satisfactoriamente", MsgBoxStyle.Information, "Asiento de Valuacion")
                smbGenerar.Enabled = False
                SimpleButton1.Focus()
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MsgBox("No hay cuentas contables afectadas.", MsgBoxStyle.Information, "Asiento de Valuacion")
                Me.DialogResult = DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
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
                    smbGenerar.Enabled = False
                    TextUsuario.Focus()
                Else
                    LabelUsuario.Text = rstReader.Item("Nombre")
                    smbGenerar.Enabled = True
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
        Dim Fx As New cFunciones
        Dim dt As New DataTable()
        Dim Moneda As String

        BuscaTipoCambio()
        Periodo = Fx.BuscaPeriodo(_FechaFinal)

        For i As Integer = 1 To 2

            If i = 1 Then
                Moneda = "NOMINAL"
                NumeroAsientoDol = Fx.BuscaNumeroAsiento("VAL-" & Format(_FechaFinal.Month, "00") & Format(_FechaFinal.Date, "yy") & "-")

            Else
                Moneda = "DOLAR"
                NumeroAsiento = Fx.BuscaNumeroAsiento("VLC-" & Format(_FechaFinal.Month, "00") & Format(_FechaFinal.Date, "yy") & "-")
            End If

            dt.Clear()
            cFunciones.Llenar_Tabla_Generico("select * from CuentaContable where Evaluacion=1 and Moneda='" & Moneda & "'", dt)

            If dt.Rows.Count > 0 Then
                GuardarAsientos(i)
            End If
        Next
    End Sub


    Private Sub GuardarAsientos(ByVal Moneda As Integer)
        Try
            BindingContext(DsValuacion, "AsientosContables").EndCurrentEdit()
            BindingContext(DsValuacion, "AsientosContables").AddNew()
            BindingContext(DsValuacion, "AsientosContables").Current("Fecha") = _FechaFinal
            BindingContext(DsValuacion, "AsientosContables").Current("IdNumDoc") = 0
            BindingContext(DsValuacion, "AsientosContables").Current("NumDoc") = 0
            BindingContext(DsValuacion, "AsientosContables").Current("Beneficiario") = ""
            BindingContext(DsValuacion, "AsientosContables").Current("TipoDoc") = 29
            BindingContext(DsValuacion, "AsientosContables").Current("Accion") = "AUT"
            BindingContext(DsValuacion, "AsientosContables").Current("Anulado") = 0
            BindingContext(DsValuacion, "AsientosContables").Current("FechaEntrada") = Now.Date
            BindingContext(DsValuacion, "AsientosContables").Current("Periodo") = Periodo
            BindingContext(DsValuacion, "AsientosContables").Current("NumMayorizado") = 0
            BindingContext(DsValuacion, "AsientosContables").Current("Modulo") = "Valuación"
            BindingContext(DsValuacion, "AsientosContables").Current("Observaciones") = "Asiento de Valuación del " & _FechaInicial & " al " & _FechaFinal
            BindingContext(DsValuacion, "AsientosContables").Current("NombreUsuario") = LabelUsuario.Text
            BindingContext(DsValuacion, "AsientosContables").Current("TotalDebe") = 0
            BindingContext(DsValuacion, "AsientosContables").Current("TotalHaber") = 0

            If Moneda = 1 Then
                BindingContext(DsValuacion, "AsientosContables").Current("CodMoneda") = 2
                BindingContext(DsValuacion, "AsientosContables").Current("NumAsiento") = NumeroAsientoDol
                BindingContext(DsValuacion, "AsientosContables").Current("Mayorizado") = 1
            Else
                BindingContext(DsValuacion, "AsientosContables").Current("CodMoneda") = 1
                BindingContext(DsValuacion, "AsientosContables").Current("NumAsiento") = NumeroAsiento
                BindingContext(DsValuacion, "AsientosContables").Current("Mayorizado") = 1
            End If

            BindingContext(DsValuacion, "AsientosContables").Current("TipoCambio") = CDbl(txtVenta.Text)
            BindingContext(DsValuacion, "AsientosContables").EndCurrentEdit()

            'CREA LOS DETALLES DEL ASIENTO PARA LA MONEDA
            AsientoDetalle(Moneda)

            BindingContext(DsValuacion, "AsientosContables").Current("TotalDebe") = Total(BindingContext(DsValuacion, "AsientosContables").Current("NumAsiento"))
            BindingContext(DsValuacion, "AsientosContables").Current("TotalHaber") = BindingContext(DsValuacion, "AsientosContables").Current("TotalDebe")

            If BindingContext(DsValuacion, "AsientosContables").Current("TotalDebe") <= 0 Then
                BindingContext(DsValuacion, "AsientosContables").CancelCurrentEdit()
            Else
                BindingContext(DsValuacion, "AsientosContables").EndCurrentEdit()
            End If

            MontoDiferencial = 0
            MontoDiferencialGasto = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub


    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String)
        If Monto > 0 Then   'GUARDA LOS DETALLES DEL ASIENTO CONTABLE
            If Not ActualizarFilas(Monto, Debe, Haber, Cuenta, NombreCuenta) Then
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsValuacion, "AsientosContables").Current("NumAsiento")
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsValuacion, "AsientosContables").Current("Observaciones")
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = 0
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()

            End If
        End If
    End Sub

    Function ActualizarFilas(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        For i As Integer = 0 To BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Count - 1
            BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Position = i

            If BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta").Equals(Cuenta) And BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe Then
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsValuacion, "AsientosContables").Current("NumAsiento")
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsValuacion, "AsientosContables").Current("Observaciones")
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") += Monto
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = 0
                BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub AsientoDetalle(ByVal Moneda As String)


        Try
            Dim dt As New DataTable
            Dim _Moneda As Integer
            Dim NombreCuenta As String


            If Moneda = "1" Then
                Moneda = "NOMINAL"
            Else
                Moneda = "DOLAR"
            End If

            dt.Clear()
            cFunciones.Llenar_Tabla_Generico("select * from CuentaContable where Evaluacion=1 and Moneda='" & Moneda & "'", dt)

            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1

                    If dt.Rows(i).Item("Moneda") = "NOMINAL" Then
                        _Moneda = 1
                    Else
                        _Moneda = 2
                    End If

                    NombreCuenta = dt.Rows(i).Item("Descripcion")
                    BuscaMontoCuenta(dt.Rows(i).Item("CuentaContable"), _Moneda, NombreCuenta, dt.Rows(i).Item("TipoConversion"))
                Next

                'GUARDA EL DETALLE PARA LA CUENTA DIFERENCIAL GASTO
                GuardaAsientoDetalle(MontoDiferencialGasto, 1, 0, CuentaDiferencialGasto, NombreCuentaDiferencialGasto)

                'GUARDA EL DETALLE PARA LA CUENTA DIFERENCIAL INGRESO
                GuardaAsientoDetalle(MontoDiferencial, 0, 1, CuentaDiferencial, NombreCuentaDiferencial)
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub BuscaMontoCuenta(ByVal Cuenta As String, ByVal Moneda As Integer, ByVal NombreCuenta As String, ByVal TipoConversion As String)

        Dim Monto, SaldoOriginalDolar, SaldoOriginalColon, SaldoAjustado As Double
        Dim Debe, Haber As Boolean

        Try


            SaldoOriginalColon = (cconexion.SlqExecuteScalar(conectadobd, "SELECT   SUM(AsientoDC_DH.DebeColon) - SUM(AsientoDC_DH.HaberColon) as Diferencia FROM AsientoDC_DH INNER JOIN CuentaContable ON AsientoDC_DH.Cuenta = CuentaContable.CuentaContable WHERE     (AsientoDC_DH.Fecha < dbo.DateOnlyInicio('" & CDate(_FechaFinal) & "'))
                GROUP BY AsientoDC_DH.Cuenta, CuentaContable.Descripcion HAVING      (AsientoDC_DH.Cuenta = '" & Cuenta & "')"))
            SaldoOriginalDolar = (cconexion.SlqExecuteScalar(conectadobd, "SELECT SUM(AsientoDC_DH.DebeDolar) - SUM(AsientoDC_DH.HaberDolar) as Diferencia FROM AsientoDC_DH INNER JOIN CuentaContable ON AsientoDC_DH.Cuenta = CuentaContable.CuentaContable WHERE     (AsientoDC_DH.Fecha < dbo.DateOnlyInicio('" & CDate(_FechaFinal) & "'))
                GROUP BY AsientoDC_DH.Cuenta, CuentaContable.Descripcion HAVING      (AsientoDC_DH.Cuenta = '" & Cuenta & "')"))




            If Moneda = 1 Then
                If TipoConversion = "HISTORICO" Then
                    SaldoAjustado = (cconexion.SlqExecuteScalar(conectadobd, "SELECT SUM(AsientoDC_DH_Historico.DebeDolar) - SUM(AsientoDC_DH_Historico.HaberDolar) as Diferencia FROM AsientoDC_DH_Historico INNER JOIN CuentaContable ON AsientoDC_DH_Historico.Cuenta = CuentaContable.CuentaContable WHERE (AsientoDC_DH_Historico.Fecha < dbo.DateOnlyInicio('" & CDate(_FechaFinal) & "'))
                    GROUP BY AsientoDC_DH_Historico.Cuenta, CuentaContable.Descripcion HAVING      (AsientoDC_DH_Historico.Cuenta = '" & Cuenta & "')"))

                    Monto = (SaldoAjustado - SaldoOriginalDolar)
                Else
                    SaldoAjustado = (SaldoOriginalColon / TipoCambio(TipoConversion, Cuenta))
                    Monto = (SaldoAjustado - SaldoOriginalDolar)
                End If

            Else
                If TipoConversion = "HISTORICO" Then
                    SaldoAjustado = (cconexion.SlqExecuteScalar(conectadobd, "SELECT SUM(AsientoDC_DH_Historico.DebeColon) - SUM(AsientoDC_DH_Historico.HaberColon) as Diferencia FROM AsientoDC_DH_Historico INNER JOIN CuentaContable ON AsientoDC_DH_Historico.Cuenta = CuentaContable.CuentaContable WHERE (AsientoDC_DH_Historico.Fecha < dbo.DateOnlyInicio('" & CDate(_FechaFinal) & "'))
                    GROUP BY AsientoDC_DH_Historico.Cuenta, CuentaContable.Descripcion HAVING      (AsientoDC_DH_Historico.Cuenta = '" & Cuenta & "')"))

                    Monto = (SaldoAjustado - SaldoOriginalColon)
                Else
                    SaldoAjustado = (SaldoOriginalDolar * TipoCambio(TipoConversion, Cuenta))
                    Monto = (SaldoAjustado - SaldoOriginalColon)
                End If

            End If




            '----------------------------------------------------------------------------

            '---------------------------------------------------------------------------
            If Monto >= 0 Then  'EN CASO DE SER POSITIVO AUMENTA EL INGRESO
                Debe = True
                Haber = False
                MontoDiferencial += Monto

                '------------------------------------------------------------------------
            Else                'EN CASO DE SER NEGATIVO AUMENTA EL GASTO
                Debe = False
                Haber = True
                MontoDiferencialGasto += Math.Abs(Monto)
            End If
            '----------------------------------------------------------------------------

            '----------------------------------------------------------------------------
            'GUARDA EL DETALLE PARA LA CUENTA CONTABLE
            GuardaAsientoDetalle(Math.Abs(Monto), Debe, Haber, Cuenta, NombreCuenta)
            '---------------------------------------------------------------------------


        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub

    Function TipoCambio(ByVal TipoConversion As String, ByVal Cuenta As String) As Double

        Dim _TipoCambio As Double = 0

        Select Case TipoConversion
            Case "PROMEDIO"
                _TipoCambio = (cconexion.SlqExecuteScalar(conectadobd, "SELECT   SUM(AsientoDC_DH.Tipocambio)/ COUNT(AsientoDC_DH.Tipocambio) as TipoCambio FROM AsientoDC_DH INNER JOIN CuentaContable ON AsientoDC_DH.Cuenta = CuentaContable.CuentaContable WHERE (AsientoDC_DH.Fecha < dbo.DateOnlyInicio('" & CDate(_FechaFinal) & "'))
                GROUP BY AsientoDC_DH.Cuenta, CuentaContable.Descripcion HAVING (AsientoDC_DH.Cuenta = '" & Cuenta & "')"))
            Case "CONVERSION"
                _TipoCambio = CDbl(txtVenta.Text)
            Case "HISTORICO"
                _TipoCambio = CDbl(txtVenta.Text)
        End Select
        Return _TipoCambio
    End Function

    Function Total(ByVal Asiento As String) As Double   'CALCULA EL MONTO TOTAL DEL ASIENTO
        For i As Integer = 0 To DsValuacion.DetallesAsientosContable.Count - 1
            If DsValuacion.DetallesAsientosContable(i).NumAsiento = Asiento Then
                Total += DsValuacion.DetallesAsientosContable(i).Monto
            End If
        Next i
    End Function


    Function TransAsiento() As Boolean
        Dim Trans As SqlTransaction     'REALIZA LA TRANSACCION DE LOS ASIENTOS CONTABLES

        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()

            Trans = SqlConnection1.BeginTransaction
            BindingContext(DsValuacion, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsValuacion, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = Trans
            AdapterDetallesAsientos.DeleteCommand.Transaction = Trans
            AdapterDetallesAsientos.InsertCommand.Transaction = Trans

            AdapterAsientos.UpdateCommand.Transaction = Trans
            AdapterAsientos.DeleteCommand.Transaction = Trans
            AdapterAsientos.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'INICIA LA TRANSACCION....
            AdapterDetallesAsientos.Update(DsValuacion.DetallesAsientosContable)
            AdapterAsientos.Update(DsValuacion.AsientosContables)
            '-----------------------------------------------------------------------------------
            Trans.Commit()
            Return True

        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function


    Function CargarAsientos_Detalle(ByVal Moneda As Integer)
        Dim cnnv As SqlConnection = Nothing
        Dim cConexion As New Conexion

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT DetallesAsientosContable.*, CuentaContable.Tipo, CuentaContable.Nivel, AsientosContables.TipoCambio AS TC FROM DetallesAsientosContable INNER JOIN CuentaContable ON DetallesAsientosContable.Cuenta = CuentaContable.CuentaContable INNER JOIN AsientosContables ON DetallesAsientosContable.NumAsiento = AsientosContables.NumAsiento WHERE (AsientosContables.Mayorizado = 1) AND (AsientosContables.Anulado = 0) AND (AsientosContables.TipoDoc <> 29) AND (AsientosContables.CodMoneda = " & Moneda & ") AND (CuentaContable.Id <> " & DsValuacion.SettingCuentaContable(0).IdPeriodo & ") AND (CuentaContable.Evaluacion = 1) AND (AsientosContables.Fecha BETWEEN dbo.DateOnlyInicio(@FechaInicio) AND dbo.DateOnlyFinal(@FechaFinal))"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime))
            cmdv.Parameters.Add(New SqlParameter("@FechaFinal", SqlDbType.DateTime))
            cmdv.Parameters("@FechaInicio").Value = _FechaInicial
            cmdv.Parameters("@FechaFinal").Value = _FechaFinal
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            'Llenamos la tabla
            Me.DsValuacion.DetallesAsientosContable1.Clear()
            dv.Fill(DsValuacion.DetallesAsientosContable1)

            '----------------------------------------------------------------------------
            'RECORRE LOS DETALLES DE LOS ASIENTOS
            For n As Integer = 0 To Me.DsValuacion.DetallesAsientosContable1.Rows.Count - 1
                '----------------------------------------------------------------------------
                If Moneda = 1 Then      'SI ES EN COLONES DIVIDE
                    Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("MontoAsiento") = (Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Monto") / Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("TC"))
                    If Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Tipo") = "ACTIVOS" Then
                        Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("MontoHoy") = (Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Monto") / CDbl(txtVenta.Text))
                    Else
                        Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("MontoHoy") = (Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Monto") / CDbl(txtVenta.Text))
                    End If
                    '----------------------------------------------------------------------------
                Else                    'SI ES EN DOLARES MULTIPLICA
                    Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("MontoAsiento") = (Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Monto") * Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("TC"))
                    If Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Tipo") = "ACTIVOS" Then
                        Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("MontoHoy") = (Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Monto") * CDbl(txtVenta.Text))
                    Else
                        Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("MontoHoy") = (Me.DsValuacion.DetallesAsientosContable1.Rows(n).Item("Monto") * CDbl(txtVenta.Text))
                    End If
                End If
                '----------------------------------------------------------------------------
            Next
            '----------------------------------------------------------------------------

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function
#End Region

#Region "KeyDown"
    Private Sub dtInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub dtFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            CargarTipoCambio()

        End If
    End Sub

    Private Sub txtCompra_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            txtVenta.Focus()
        End If
    End Sub

    Private Sub txtVenta_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            smbGenerar.Focus()
        End If
    End Sub
#End Region

#Region "Funciones"
    Public Sub BuscaTipoCambio()
        Dim Fx As New cFunciones
        Try
            '----------------------------------------------------------------------------
            'TIPOS DE CAMBIO DE ANTERIOR
            TipoCambioAnterior = Fx.TipoCambio(_FechaInicial.AddDays(-1))
            TipoCambioAnteriorVenta = Fx.TipoCambio(_FechaInicial.AddDays(-1), True)
            '----------------------------------------------------------------------------

            '----------------------------------------------------------------------------
            'VALIDACIONES
            If TipoCambioAnterior = 0 Then
                TipoCambioAnterior = 1
            End If

            If TipoCambioAnteriorVenta = 0 Then
                TipoCambioAnteriorVenta = 1
            End If
            '----------------------------------------------------------------------------

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

End Class
