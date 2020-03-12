<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCobroTarjeta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCobroTarjeta))
        Me.DsIngresos1 = New Contabilidad.dsIngresos
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.adAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.adDetalleAsiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.adPuntoVenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.cboOperadorTarjeta = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerarVenta = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsIngresos1
        '
        Me.DsIngresos1.DataSetName = "dsIngresos"
        Me.DsIngresos1.Locale = New System.Globalization.CultureInfo("es-CR")
        Me.DsIngresos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Contabilidad"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
            "rsist security info=False;initial catalog=Hotel"
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'adAsientos
        '
        Me.adAsientos.DeleteCommand = Me.SqlDeleteCommand1
        Me.adAsientos.InsertCommand = Me.SqlInsertCommand1
        Me.adAsientos.SelectCommand = Me.SqlSelectCommand1
        Me.adAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.adAsientos.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio")})
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
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"), New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"), New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"), New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 250, "Beneficiario"), New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"), New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"), New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"), New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"), New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"), New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"), New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing), New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"), New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"), New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"), New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"), New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"), New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"), New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.[Decimal], 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing)})
        '
        'adDetalleAsiento
        '
        Me.adDetalleAsiento.DeleteCommand = Me.SqlDeleteCommand2
        Me.adDetalleAsiento.InsertCommand = Me.SqlInsertCommand2
        Me.adDetalleAsiento.SelectCommand = Me.SqlSelectCommand2
        Me.adDetalleAsiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("Tipocambio", "Tipocambio")})})
        Me.adDetalleAsiento.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing)})
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
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"), New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"), New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"), New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"), New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"), New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"), New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"), New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"), New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle")})
        '
        'adPuntoVenta
        '
        Me.adPuntoVenta.SelectCommand = Me.SqlSelectCommand3
        Me.adPuntoVenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PuntoVenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdPuntoVenta", "IdPuntoVenta"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("Id_Bodega", "Id_Bodega"), New System.Data.Common.DataColumnMapping("IdventaGrabado", "IdventaGrabado"), New System.Data.Common.DataColumnMapping("idVentaExento", "idVentaExento"), New System.Data.Common.DataColumnMapping("IdCostoVenta", "IdCostoVenta"), New System.Data.Common.DataColumnMapping("CobroFront", "CobroFront"), New System.Data.Common.DataColumnMapping("BaseDatos", "BaseDatos"), New System.Data.Common.DataColumnMapping("ContaGeneral", "ContaGeneral")})})
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT IdPuntoVenta, Nombre, Tipo, Id_Bodega, IdventaGrabado, idVentaExento, IdCo" & _
            "stoVenta, CobroFront, BaseDatos, ContaGeneral FROM PuntoVenta ORDER BY Nombre"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection2
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(97, 185)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(190, 20)
        Me.txtUsuario.TabIndex = 263
        '
        'txtClave
        '
        Me.txtClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtClave.Location = New System.Drawing.Point(17, 185)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 20)
        Me.txtClave.TabIndex = 261
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboOperadorTarjeta
        '
        Me.cboOperadorTarjeta.DataSource = Me.DsIngresos1.PuntoVenta
        Me.cboOperadorTarjeta.DisplayMember = "Nombre"
        Me.cboOperadorTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboOperadorTarjeta.Enabled = False
        Me.cboOperadorTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOperadorTarjeta.ForeColor = System.Drawing.Color.Black
        Me.cboOperadorTarjeta.Location = New System.Drawing.Point(16, 37)
        Me.cboOperadorTarjeta.Name = "cboOperadorTarjeta"
        Me.cboOperadorTarjeta.Size = New System.Drawing.Size(271, 24)
        Me.cboOperadorTarjeta.TabIndex = 266
        Me.cboOperadorTarjeta.ValueMember = "IdPuntoVenta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(271, 24)
        Me.Label3.TabIndex = 265
        Me.Label3.Text = "Operador de Tarjeta"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(97, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(190, 14)
        Me.Label9.TabIndex = 264
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 262
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(183, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 255
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 254
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenerarVenta
        '
        Me.btnGenerarVenta.Enabled = False
        Me.btnGenerarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGenerarVenta.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarVenta.Location = New System.Drawing.Point(16, 106)
        Me.btnGenerarVenta.Name = "btnGenerarVenta"
        Me.btnGenerarVenta.Size = New System.Drawing.Size(271, 39)
        Me.btnGenerarVenta.TabIndex = 252
        Me.btnGenerarVenta.Text = "Generar Asientos"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(183, 80)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 251
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(16, 80)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 250
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(17, 149)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(270, 18)
        Me.ProgressBar1.TabIndex = 267
        '
        'frmCobroTarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 214)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.cboOperadorTarjeta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnGenerarVenta)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.txtUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCobroTarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Operador de Tarjeta"
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsIngresos1 As Contabilidad.dsIngresos
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents adAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents adPuntoVenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents cboOperadorTarjeta As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGenerarVenta As System.Windows.Forms.Button
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
