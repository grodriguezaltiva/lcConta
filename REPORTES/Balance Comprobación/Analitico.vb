Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraTreeList
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports Utilidades
Imports DevExpress.XtraTreeList.Columns

Public Class Analitico
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String
    Dim Valor As Double
    Dim Simbolo As String
    Dim Cconexion As New Conexion
    Dim Reporte_ID As Integer
    Dim conectadobd As New SqlClient.SqlConnection
    Dim Tipo As Integer
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtInicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents smbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdCuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdTemporal2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents AdAnalitico1 As Contabilidad.AdAnalitico
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Monedas As System.Windows.Forms.ComboBox
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtInicial = New System.Windows.Forms.DateTimePicker
        Me.dtFinal = New System.Windows.Forms.DateTimePicker
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.AdCuentas = New System.Data.SqlClient.SqlDataAdapter
        Me.AdAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.AdDetalleAsiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.AdTemporal2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdAnalitico1 = New Contabilidad.AdAnalitico
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList
        Me.Label3 = New System.Windows.Forms.Label
        Me.Monedas = New System.Windows.Forms.ComboBox
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        CType(Me.AdAnalitico1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label4.Location = New System.Drawing.Point(96, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(208, 24)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Reporte Analitico General"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(32, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Fecha Final :"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(32, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Fecha Inicial :"
        '
        'dtInicial
        '
        Me.dtInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtInicial.Location = New System.Drawing.Point(176, 88)
        Me.dtInicial.Name = "dtInicial"
        Me.dtInicial.Size = New System.Drawing.Size(120, 22)
        Me.dtInicial.TabIndex = 0
        '
        'dtFinal
        '
        Me.dtFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtFinal.Location = New System.Drawing.Point(176, 120)
        Me.dtFinal.Name = "dtFinal"
        Me.dtFinal.Size = New System.Drawing.Size(121, 22)
        Me.dtFinal.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(200, 192)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 31)
        Me.SimpleButton1.TabIndex = 101
        Me.SimpleButton1.Text = "Cancelar"
        '
        'smbGenerar
        '
        Me.smbGenerar.Location = New System.Drawing.Point(32, 192)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.Size = New System.Drawing.Size(98, 31)
        Me.smbGenerar.TabIndex = 3
        Me.smbGenerar.Text = "Generar"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, PARENTID, CuentaMadre, DescCuent" & _
        "aMadre, Movimiento, id FROM CuentaContable"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CuentaContable(CuentaContable, Descripcion, Nivel, Tipo, PARENTID, Cu" & _
        "entaMadre, DescCuentaMadre, Movimiento) VALUES (@CuentaContable, @Descripcion, @" & _
        "Nivel, @Tipo, @PARENTID, @CuentaMadre, @DescCuentaMadre, @Movimiento); SELECT Cu" & _
        "entaContable, Descripcion, Nivel, Tipo, PARENTID, CuentaMadre, DescCuentaMadre, " & _
        "Movimiento, id FROM CuentaContable WHERE (CuentaContable = @CuentaContable)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE CuentaContable SET CuentaContable = @CuentaContable, Descripcion = @Descri" & _
        "pcion, Nivel = @Nivel, Tipo = @Tipo, PARENTID = @PARENTID, CuentaMadre = @Cuenta" & _
        "Madre, DescCuentaMadre = @DescCuentaMadre, Movimiento = @Movimiento WHERE (Cuent" & _
        "aContable = @Original_CuentaContable) AND (CuentaMadre = @Original_CuentaMadre) " & _
        "AND (DescCuentaMadre = @Original_DescCuentaMadre) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Original_Nivel" & _
        ") AND (PARENTID = @Original_PARENTID) AND (Tipo = @Original_Tipo); SELECT Cuenta" & _
        "Contable, Descripcion, Nivel, Tipo, PARENTID, CuentaMadre, DescCuentaMadre, Movi" & _
        "miento, id FROM CuentaContable WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM CuentaContable WHERE (CuentaContable = @Original_CuentaContable) AND " & _
        "(CuentaMadre = @Original_CuentaMadre) AND (DescCuentaMadre = @Original_DescCuent" & _
        "aMadre) AND (Descripcion = @Original_Descripcion) AND (Movimiento = @Original_Mo" & _
        "vimiento) AND (Nivel = @Original_Nivel) AND (PARENTID = @Original_PARENTID) AND " & _
        "(Tipo = @Original_Tipo) AND (id = @Original_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdCuentas
        '
        Me.AdCuentas.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdCuentas.InsertCommand = Me.SqlInsertCommand1
        Me.AdCuentas.SelectCommand = Me.SqlSelectCommand1
        Me.AdCuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id")})})
        Me.AdCuentas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'AdAsientos
        '
        Me.AdAsientos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdAsientos.InsertCommand = Me.SqlInsertCommand2
        Me.AdAsientos.SelectCommand = Me.SqlSelectCommand2
        Me.AdAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdAsientos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Origina" & _
        "l_Fecha) AND (FechaEntrada = @Original_FechaEntrada) AND (IdNumDoc = @Original_I" & _
        "dNumDoc) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo)" & _
        " AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) A" & _
        "ND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Obse" & _
        "rvaciones) AND (Periodo = @Original_Periodo) AND (TipoCambio = @Original_TipoCam" & _
        "bio) AND (TipoDoc = @Original_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND" & _
        " (TotalHaber = @Original_TotalHaber)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, A" & _
        "ccion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observ" & _
        "aciones, NombreUsuario, TotalDebe, TotalHaber, IdNumDoc, CodMoneda, TipoCambio) " & _
        "VALUES (@NumAsiento, @Fecha, @NumDoc, @Beneficiario, @TipoDoc, @Accion, @Anulado" & _
        ", @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Observaciones," & _
        " @NombreUsuario, @TotalDebe, @TotalHaber, @IdNumDoc, @CodMoneda, @TipoCambio); S" & _
        "ELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, IdNumDoc, CodMoneda, TipoCambio FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, IdNumDoc, CodMoneda, TipoCambio FROM AsientosContables"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, NumDoc = @" & _
        "NumDoc, Beneficiario = @Beneficiario, TipoDoc = @TipoDoc, Accion = @Accion, Anul" & _
        "ado = @Anulado, FechaEntrada = @FechaEntrada, Mayorizado = @Mayorizado, Periodo " & _
        "= @Periodo, NumMayorizado = @NumMayorizado, Modulo = @Modulo, Observaciones = @O" & _
        "bservaciones, NombreUsuario = @NombreUsuario, TotalDebe = @TotalDebe, TotalHaber" & _
        " = @TotalHaber, IdNumDoc = @IdNumDoc, CodMoneda = @CodMoneda, TipoCambio = @Tipo" & _
        "Cambio WHERE (NumAsiento = @Original_NumAsiento) AND (Accion = @Original_Accion)" & _
        " AND (Anulado = @Original_Anulado) AND (Beneficiario = @Original_Beneficiario) A" & _
        "ND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Original_Fecha) AND (FechaEnt" & _
        "rada = @Original_FechaEntrada) AND (IdNumDoc = @Original_IdNumDoc) AND (Mayoriza" & _
        "do = @Original_Mayorizado) AND (Modulo = @Original_Modulo) AND (NombreUsuario = " & _
        "@Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) AND (NumMayorizado = @O" & _
        "riginal_NumMayorizado) AND (Observaciones = @Original_Observaciones) AND (Period" & _
        "o = @Original_Periodo) AND (TipoCambio = @Original_TipoCambio) AND (TipoDoc = @O" & _
        "riginal_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND (TotalHaber = @Origin" & _
        "al_TotalHaber); SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion," & _
        " Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observacione" & _
        "s, NombreUsuario, TotalDebe, TotalHaber, IdNumDoc, CodMoneda, TipoCambio FROM As" & _
        "ientosContables WHERE (NumAsiento = @NumAsiento)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdDetalleAsiento
        '
        Me.AdDetalleAsiento.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdDetalleAsiento.InsertCommand = Me.SqlInsertCommand3
        Me.AdDetalleAsiento.SelectCommand = Me.SqlSelectCommand3
        Me.AdDetalleAsiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdDetalleAsiento.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (TipoCambio = @Original_TipoCambio OR @Original_TipoCambio" & _
        " IS NULL AND TipoCambio IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, TipoCambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @TipoCambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "poCambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, TipoCambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE DetallesAsientosContable SET NumAsiento = @NumAsiento, Cuenta = @Cuenta, N" & _
        "ombreCuenta = @NombreCuenta, Monto = @Monto, Debe = @Debe, Haber = @Haber, Descr" & _
        "ipcionAsiento = @DescripcionAsiento, TipoCambio = @TipoCambio WHERE (ID_Detalle " & _
        "= @Original_ID_Detalle) AND (Cuenta = @Original_Cuenta) AND (Debe = @Original_De" & _
        "be) AND (DescripcionAsiento = @Original_DescripcionAsiento) AND (Haber = @Origin" & _
        "al_Haber) AND (Monto = @Original_Monto) AND (NombreCuenta = @Original_NombreCuen" & _
        "ta) AND (NumAsiento = @Original_NumAsiento) AND (TipoCambio = @Original_TipoCamb" & _
        "io OR @Original_TipoCambio IS NULL AND TipoCambio IS NULL); SELECT ID_Detalle, N" & _
        "umAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, TipoCam" & _
        "bio FROM DetallesAsientosContable WHERE (ID_Detalle = @ID_Detalle)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle"))
        '
        'AdTemporal2
        '
        Me.AdTemporal2.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdTemporal2.InsertCommand = Me.SqlInsertCommand4
        Me.AdTemporal2.SelectCommand = Me.SqlSelectCommand4
        Me.AdTemporal2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Temporal2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("SaldoAnterior", "SaldoAnterior"), New System.Data.Common.DataColumnMapping("Debitos", "Debitos"), New System.Data.Common.DataColumnMapping("Creditos", "Creditos"), New System.Data.Common.DataColumnMapping("SaldoMes", "SaldoMes"), New System.Data.Common.DataColumnMapping("SaldoActual", "SaldoActual"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento")})})
        Me.AdTemporal2.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Temporal2 WHERE (CuentaContable = @Original_CuentaContable) AND (Cred" & _
        "itos = @Original_Creditos) AND (Debitos = @Original_Debitos) AND (Descripcion = " & _
        "@Original_Descripcion) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Ori" & _
        "ginal_Nivel) AND (SaldoActual = @Original_SaldoActual) AND (SaldoAnterior = @Ori" & _
        "ginal_SaldoAnterior) AND (SaldoMes = @Original_SaldoMes)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Temporal2(CuentaContable, Descripcion, SaldoAnterior, Debitos, Credit" & _
        "os, SaldoMes, SaldoActual, Nivel, Movimiento) VALUES (@CuentaContable, @Descripc" & _
        "ion, @SaldoAnterior, @Debitos, @Creditos, @SaldoMes, @SaldoActual, @Nivel, @Movi" & _
        "miento); SELECT CuentaContable, Descripcion, SaldoAnterior, Debitos, Creditos, S" & _
        "aldoMes, SaldoActual, Nivel, Movimiento FROM Temporal2 WHERE (CuentaContable = @" & _
        "CuentaContable)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CuentaContable, Descripcion, SaldoAnterior, Debitos, Creditos, SaldoMes, S" & _
        "aldoActual, Nivel, Movimiento FROM Temporal2"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Temporal2 SET CuentaContable = @CuentaContable, Descripcion = @Descripcion" & _
        ", SaldoAnterior = @SaldoAnterior, Debitos = @Debitos, Creditos = @Creditos, Sald" & _
        "oMes = @SaldoMes, SaldoActual = @SaldoActual, Nivel = @Nivel, Movimiento = @Movi" & _
        "miento WHERE (CuentaContable = @Original_CuentaContable) AND (Creditos = @Origin" & _
        "al_Creditos) AND (Debitos = @Original_Debitos) AND (Descripcion = @Original_Desc" & _
        "ripcion) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Original_Nivel) A" & _
        "ND (SaldoActual = @Original_SaldoActual) AND (SaldoAnterior = @Original_SaldoAnt" & _
        "erior) AND (SaldoMes = @Original_SaldoMes); SELECT CuentaContable, Descripcion, " & _
        "SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual, Nivel, Movimiento FROM " & _
        "Temporal2 WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdAnalitico1
        '
        Me.AdAnalitico1.DataSetName = "AdAnalitico"
        Me.AdAnalitico1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'TreeList2
        '
        Me.TreeList2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TreeList2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TreeList2.BehaviorOptions = CType(((((((((DevExpress.XtraTreeList.BehaviorOptionsFlags.MoveOnEdit Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ExpandNodeOnDrag) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ResizeNodes) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoSelectAllInEditor) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoNodeHeight) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoChangeParent) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.CloseEditorOnLostFocus) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.KeepSelectedOnClick) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.SmartMouseHover), DevExpress.XtraTreeList.BehaviorOptionsFlags)
        Me.TreeList2.Location = New System.Drawing.Point(344, 200)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.ParentFieldName = "PARENTID"
        Me.TreeList2.Size = New System.Drawing.Size(10, 20)
        Me.TreeList2.Styles.AddReplace("HeaderPanel", New DevExpress.Utils.ViewStyle("HeaderPanel", "TreeList", New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte)), "", DevExpress.Utils.StyleOptions.StyleEnabled, True, False, False, DevExpress.Utils.HorzAlignment.Center, DevExpress.Utils.VertAlignment.Center, Nothing, System.Drawing.SystemColors.Control, System.Drawing.SystemColors.Highlight))
        Me.TreeList2.TabIndex = 102
        Me.TreeList2.Text = "TreeList2"
        Me.TreeList2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(32, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Moneda :"
        '
        'Monedas
        '
        Me.Monedas.DataSource = Me.AdAnalitico1.Moneda
        Me.Monedas.DisplayMember = "MonedaNombre"
        Me.Monedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Monedas.Location = New System.Drawing.Point(176, 152)
        Me.Monedas.Name = "Monedas"
        Me.Monedas.Size = New System.Drawing.Size(121, 21)
        Me.Monedas.TabIndex = 2
        Me.Monedas.ValueMember = "CodMoneda"
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorVenta, Simbolo) VALUES (@CodMone" & _
        "da, @MonedaNombre, @ValorVenta, @Simbolo); SELECT CodMoneda, MonedaNombre, Valor" & _
        "Venta, Simbolo FROM Moneda"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT CodMoneda, MonedaNombre, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'Analitico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(376, 254)
        Me.Controls.Add(Me.Monedas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TreeList2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.smbGenerar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtInicial)
        Me.Controls.Add(Me.dtFinal)
        Me.Name = "Analitico"
        Me.Text = "Reporte análitico"
        CType(Me.AdAnalitico1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub frmBalanceComprobacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            InitData()
            conectadobd = Cconexion.Conectar("Contabilidad")
            AdapterMoneda.Fill(AdAnalitico1.Moneda)
            dtInicial.Focus()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub InitData()
        CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList2, "Saldo Anterior", "SaldoAnterior", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Débitos", "Debitos", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Créditos", "Creditos", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Saldo Mes", "SaldoMes", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Saldo Actual", "SaldoActual", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList2, "Nivel", "Nivel", -1, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        TreeList2.BestFitColumns()
    End Sub


    Private Sub CreateColumn(ByVal tl As TreeList, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
        Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = tl.Columns.Add()
        col.Caption = caption
        col.FieldName = field
        col.VisibleIndex = visibleindex
        col.Format.FormatType = formatType
        If formatType = DevExpress.Utils.FormatType.Custom Then
            col.Format.Format = New BaseFormatter
        End If
        col.Format.FormatString = formatString
    End Sub
#End Region

#Region "Generar"
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        Try
            Dim Fecha1, Fecha2 As Date
            Fecha1 = dtInicial.Value.Date
            Fecha2 = Me.dtFinal.Value.Date
            If Fecha1 > Fecha2 Then
                MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.AdAnalitico1.DetallesAsientosContable.Clear()
            Me.AdAnalitico1.AsientosContables.Clear()
            Me.AdAnalitico1.CuentaContable.Clear()
            Me.AdAnalitico1.Temporal2.Clear()
            AdCuentas.Fill(Me.AdAnalitico1.CuentaContable)
            Me.AdDetalleAsiento.Fill(Me.AdAnalitico1.DetallesAsientosContable)
            TreeList2.DataSource = AdAnalitico1.CuentaContable
            TreeList2.DataMember = "CuentaContable"
            TreeList2.Columns(1).Width = 300
            LLenarCeros()
            CargarAsientos(Fecha1)
            CargarDebitos(Fecha1, Fecha2)
            Calcular_Saldos()
            Calcular()
            Imprimir()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Cargar Asientos"
    Function CargarAsientos(ByVal FechaInicio As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES PARA EL CALCULO DEL SALDO ANTERIOR
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Dim i, n, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand

            Dim sel As String = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
            " FROM         dbo.AsientoDC_DH INNER JOIN " & _
            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
            " WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) " & _
            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
            ' Si hay que excluir el asiento cierre anual
            'If Check_Cierre.Checked Then
            '    sel = sel & " AND (AsientosContables.NumAsiento <> '" & CierreAnual() & "')"
            'End If
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(dtInicial.Value)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla

            Me.AdAnalitico1.AsientoDC_DH_AG.Clear()
            dv.Fill(Me.AdAnalitico1.AsientoDC_DH_AG)
            If Me.AdAnalitico1.AsientoDC_DH_AG.Rows.Count = 0 Then
                Exit Function
            End If
            For x = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                For i = 0 To Me.AdAnalitico1.AsientoDC_DH_AG.Rows.Count - 1
                    If Me.AdAnalitico1.AsientoDC_DH_AG(i).Cuenta.Equals(Me.AdAnalitico1.CuentaContable(x).CuentaContable) Then
                        If Tipo = 1 Then
                            Debe += Me.AdAnalitico1.AsientoDC_DH_AG(i).Dcolon
                            Haber += Me.AdAnalitico1.AsientoDC_DH_AG(i).Hcolon
                            DebeD += Me.AdAnalitico1.AsientoDC_DH_AG(i).Ddolar
                            HaberD += Me.AdAnalitico1.AsientoDC_DH_AG(i).HDolar
                        Else
                            Debe += Me.AdAnalitico1.AsientoDC_DH_AG(i).Dcolon
                            Haber += Me.AdAnalitico1.AsientoDC_DH_AG(i).Hcolon
                        End If
                    End If
                Next

                If Tipo = 1 Then
                    If AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                        AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnteriorD") = DebeD - HaberD
                    Else
                        AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                        AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnteriorD") = HaberD - DebeD
                    End If
                Else
                    If AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                    Else
                        AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                    End If

                End If
                Debe = 0
                Haber = 0
                DebeD = 0
                HaberD = 0
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Function CargarAsientos1(ByVal FechaInicio As String)
        Dim cnnv As SqlConnection = Nothing
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto As Double
        Dim i, n, x As Integer
        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM AsientosContables INNER JOIN Periodo ON AsientosContables.Periodo = Periodo.Periodo WHERE (AsientosContables.Anulado = 0) AND (AsientosContables.Mayorizado = 1) AND (Periodo.Estado = 1) AND (AsientosContables.Periodo <> @Periodo) AND Fecha <= dbo.DateOnlyInicio(@Fecha)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))
            cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(dtInicial.Value)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.AdAnalitico1.AsientosContables.Clear()
            dv.Fill(Me.AdAnalitico1.AsientosContables)

            For x = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1

                For i = 0 To Me.AdAnalitico1.AsientosContables.Rows.Count - 1
                    If Me.AdAnalitico1.AsientosContables(i).TipoDoc = 29 And AdAnalitico1.AsientosContables(i).CodMoneda <> Monedas.SelectedValue Then

                    Else
                        For n = 0 To Me.AdAnalitico1.DetallesAsientosContable.Rows.Count - 1
                            If AdAnalitico1.AsientosContables.Rows(i).Item("NumAsiento") = AdAnalitico1.DetallesAsientosContable.Rows(n).Item("NumAsiento") And AdAnalitico1.CuentaContable.Rows(x).Item("CuentaContable") = AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Cuenta") Then
                                If AdAnalitico1.AsientosContables.Rows(i).Item("CodMoneda") = Monedas.SelectedValue Then
                                    Monto = AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto")
                                Else
                                    If AdAnalitico1.AsientosContables.Rows(i).Item("CodMoneda") = 1 Then
                                        If Me.AdAnalitico1.AsientosContables(i).TipoDoc = 27 Then
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") / AdAnalitico1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                                        Else
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") / AdAnalitico1.AsientosContables.Rows(i).Item("TipoCambio"))
                                        End If
                                    Else
                                        If Me.AdAnalitico1.AsientosContables(i).TipoDoc = 27 Then
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") * AdAnalitico1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                                        Else
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") * AdAnalitico1.AsientosContables.Rows(i).Item("TipoCambio"))
                                        End If
                                    End If
                                End If

                                If AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Debe") = True Then
                                    Debe = Debe + Monto
                                Else
                                    Haber = Haber + Monto
                                End If
                            End If
                        Next
                    End If
                Next

                If AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or AdAnalitico1.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                    AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                Else
                    AdAnalitico1.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                End If

                Debe = 0
                Haber = 0
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Function CargarDebitos(ByVal FechaInicio As String, ByVal FechaFinal As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES DEL PERIODO
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Dim i, n, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
" SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
" FROM         dbo.AsientoDC_DH INNER JOIN " & _
" dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
" WHERE     (Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)) " & _
" GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

            'Dim sel As String = "SELECT * FROM AsientoDC_DH_AG WHERE Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)"
            'If Check_Cierre.Checked Then
            '    sel = sel & " AND (AsientosContables.NumAsiento <> '" & CierreAnual() & "')"
            'End If
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Fecha2", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha2").Value = Format(FechaFinal, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha2").Value = FechaFinal
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.AdAnalitico1.AsientoDC_DH_AG.Clear()

            dv.Fill(Me.AdAnalitico1.AsientoDC_DH_AG)

            For x = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1

                For i = 0 To Me.AdAnalitico1.AsientoDC_DH_AG.Rows.Count - 1
                    Dim cuent As String = Me.AdAnalitico1.AsientoDC_DH_AG(i).Cuenta.TrimEnd(" ")
                    If cuent.Equals(Me.AdAnalitico1.CuentaContable(x).CuentaContable) Then
                        If Me.Tipo = 1 Then
                            AdAnalitico1.CuentaContable.Rows(x).Item("Debitos") += Me.AdAnalitico1.AsientoDC_DH_AG(i).Dcolon
                            AdAnalitico1.CuentaContable.Rows(x).Item("Creditos") += Me.AdAnalitico1.AsientoDC_DH_AG(i).Hcolon
                            AdAnalitico1.CuentaContable.Rows(x).Item("DebitosD") += Me.AdAnalitico1.AsientoDC_DH_AG(i).Ddolar
                            AdAnalitico1.CuentaContable.Rows(x).Item("CreditosD") += Me.AdAnalitico1.AsientoDC_DH_AG(i).HDolar
                        Else
                            AdAnalitico1.CuentaContable.Rows(x).Item("Debitos") += Me.AdAnalitico1.AsientoDC_DH_AG(i).Dcolon
                            AdAnalitico1.CuentaContable.Rows(x).Item("Creditos") += Me.AdAnalitico1.AsientoDC_DH_AG(i).Hcolon
                        End If
                    End If
                Next
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function

    Function CargarDebitos1(ByVal FechaInicio As String, ByVal FechaFinal As String)
        Dim cnnv As SqlConnection = Nothing
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto As Double
        Dim i, n, x As Integer

        Try

            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM AsientosContables WHERE Anulado = 0 AND Mayorizado = 1 AND Fecha >= dbo.DateOnlyInicio(@Fecha) and Fecha <= dbo.DateOnlyFinal(@Fecha2)"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Fecha2", SqlDbType.DateTime))
            cmdv.Parameters("@Fecha2").Value = FechaFinal
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.AdAnalitico1.AsientosContables.Clear()

            dv.Fill(Me.AdAnalitico1.AsientosContables)
            Debe = 0
            Haber = 0

            For x = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                For i = 0 To Me.AdAnalitico1.AsientosContables.Rows.Count - 1
                    If Me.AdAnalitico1.AsientosContables(i).TipoDoc = 29 And AdAnalitico1.AsientosContables(i).CodMoneda <> Monedas.SelectedValue Then

                    Else
                        For n = 0 To Me.AdAnalitico1.DetallesAsientosContable.Rows.Count - 1

                            If AdAnalitico1.AsientosContables.Rows(i).Item("NumAsiento") = AdAnalitico1.DetallesAsientosContable.Rows(n).Item("NumAsiento") And AdAnalitico1.CuentaContable.Rows(x).Item("CuentaContable") = AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Cuenta") Then
                                If AdAnalitico1.AsientosContables.Rows(i).Item("CodMoneda") = Monedas.SelectedValue Then
                                    Monto = AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto")
                                Else
                                    If AdAnalitico1.AsientosContables.Rows(i).Item("CodMoneda") = 1 Then
                                        If Me.AdAnalitico1.AsientosContables(i).TipoDoc = 27 Then
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") / AdAnalitico1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                                        Else
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") / AdAnalitico1.AsientosContables.Rows(i).Item("TipoCambio"))
                                        End If
                                    Else
                                        If Me.AdAnalitico1.AsientosContables(i).TipoDoc = 27 Then
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") * AdAnalitico1.DetallesAsientosContable.Rows(n).Item("TipoCambio"))
                                        Else
                                            Monto = (AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Monto") * AdAnalitico1.AsientosContables.Rows(i).Item("TipoCambio"))
                                        End If
                                    End If
                                End If

                                If AdAnalitico1.DetallesAsientosContable.Rows(n).Item("Debe") = True Then
                                    Debe = Debe + Monto
                                Else
                                    Haber = Haber + Monto
                                End If
                            End If

                        Next
                    End If
                Next

                AdAnalitico1.CuentaContable.Rows(x).Item("Debitos") = Debe
                AdAnalitico1.CuentaContable.Rows(x).Item("Creditos") = Haber
                Debe = 0
                Haber = 0
            Next

        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function


    Function cargar()
        Dim i As Integer
        Dim trans As SqlTransaction
        Try
            AdAnalitico1.Temporal2.Clear()

            For i = 0 To AdAnalitico1.CuentaContable.Rows.Count - 1
                If AdAnalitico1.CuentaContable.Rows(i).Item("Movimiento") <> 0 Then
                    BindingContext(AdAnalitico1.Temporal2).AddNew()
                    BindingContext(AdAnalitico1.Temporal2).Current("CuentaContable") = AdAnalitico1.CuentaContable.Rows(i).Item("CuentaContable")
                    BindingContext(AdAnalitico1.Temporal2).Current("Descripcion") = AdAnalitico1.CuentaContable.Rows(i).Item("Descripcion")
                    BindingContext(AdAnalitico1.Temporal2).Current("SaldoAnterior") = AdAnalitico1.CuentaContable.Rows(i).Item("SaldoAnterior")
                    BindingContext(AdAnalitico1.Temporal2).Current("Debitos") = AdAnalitico1.CuentaContable.Rows(i).Item("Debitos")
                    BindingContext(AdAnalitico1.Temporal2).Current("Creditos") = AdAnalitico1.CuentaContable.Rows(i).Item("Creditos")
                    BindingContext(AdAnalitico1.Temporal2).Current("SaldoMes") = AdAnalitico1.CuentaContable.Rows(i).Item("SaldoMes")
                    BindingContext(AdAnalitico1.Temporal2).Current("SaldoActual") = AdAnalitico1.CuentaContable.Rows(i).Item("SaldoActual")
                    BindingContext(AdAnalitico1.Temporal2).Current("Nivel") = AdAnalitico1.CuentaContable.Rows(i).Item("Nivel")
                    BindingContext(AdAnalitico1.Temporal2).Current("Movimiento") = AdAnalitico1.CuentaContable.Rows(i).Item("Movimiento")
                    BindingContext(AdAnalitico1.Temporal2).EndCurrentEdit()
                End If
            Next

            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            trans = Me.SqlConnection1.BeginTransaction
            Me.AdTemporal2.InsertCommand.Transaction = trans
            Me.AdTemporal2.UpdateCommand.Transaction = trans
            Me.AdTemporal2.DeleteCommand.Transaction = trans
            Me.AdTemporal2.Update(Me.AdAnalitico1, "Temporal2")
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            Me.SqlConnection1.Close()
        End Try
    End Function
#End Region

#Region "Calculos"
    Private Sub Calcular()
        Dim i, n, j, k, h As Integer
        Dim SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual As Double

        Try
            For k = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                If Me.AdAnalitico1.CuentaContable.Rows(k).Item("Nivel") = 4 Then
                    For j = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                        If Me.AdAnalitico1.CuentaContable.Rows(j).Item("Id") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("PARENTID") Then
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoActual")
                        End If
                    Next
                End If
            Next

            For k = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                If Me.AdAnalitico1.CuentaContable.Rows(k).Item("Nivel") = 3 Then
                    For j = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                        If Me.AdAnalitico1.CuentaContable.Rows(j).Item("Id") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("PARENTID") Then
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoActual")
                        End If
                    Next
                End If
            Next

            For k = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                If Me.AdAnalitico1.CuentaContable.Rows(k).Item("Nivel") = 2 Then
                    For j = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                        If Me.AdAnalitico1.CuentaContable.Rows(j).Item("Id") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("PARENTID") Then
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoActual")
                        End If
                    Next
                End If
            Next

            For k = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                If Me.AdAnalitico1.CuentaContable.Rows(k).Item("Nivel") = 1 Then
                    For j = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                        If Me.AdAnalitico1.CuentaContable.Rows(j).Item("Id") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("PARENTID") Then
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Debitos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("Creditos") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoMes") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") = Me.AdAnalitico1.CuentaContable.Rows(j).Item("SaldoActual") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoActual")
                        End If
                    Next
                End If
            Next
            For k = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                If Me.AdAnalitico1.CuentaContable.Rows(k).Item("Nivel") = 0 Then
                    SaldoAnterior = SaldoAnterior + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoAnterior")
                    Debitos = Debitos + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos")
                    Creditos = Creditos + Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos")
                    SaldoMes = SaldoMes + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes")
                    SaldoActual = SaldoActual + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoActual")
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Calcular_Saldos()
        Dim k As Integer
        Try
            For k = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
                If AdAnalitico1.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or AdAnalitico1.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or AdAnalitico1.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or AdAnalitico1.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                    Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos") - Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos")
                Else
                    Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("Creditos") - Me.AdAnalitico1.CuentaContable.Rows(k).Item("Debitos")
                End If
                Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoActual") = Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.AdAnalitico1.CuentaContable.Rows(k).Item("SaldoMes")
            Next

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Controles"
    Private Sub LLenarCeros()
        Dim n As Integer
        For n = 0 To Me.AdAnalitico1.CuentaContable.Rows.Count - 1
            AdAnalitico1.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
            AdAnalitico1.CuentaContable.Rows(n).Item("Debitos") = 0
            AdAnalitico1.CuentaContable.Rows(n).Item("Creditos") = 0
            AdAnalitico1.CuentaContable.Rows(n).Item("SaldoMes") = 0
            AdAnalitico1.CuentaContable.Rows(n).Item("SaldoActual") = 0
        Next
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim Analitico As New AnaliticoGeneral
        Dim visor As New frmVisorReportes
        Dim Fecha1, Fecha2 As Date
        Fecha1 = dtInicial.Value.Date
        Fecha2 = Me.dtFinal.Value.Date
        If Fecha1 > Fecha2 Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        Try
            Cconexion.DeleteRecords("Temporal2", "")
            cargar()
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, Analitico, False, Me.conectadobd.ConnectionString)
            Analitico.SetParameterValue(0, Me.dtInicial.Text)
            Analitico.SetParameterValue(1, Me.dtFinal.Text)
            Analitico.SetParameterValue("Moneda", AdAnalitico1.Moneda(Monedas.SelectedIndex).MonedaNombre)
            Analitico.SetParameterValue("Valor", AdAnalitico1.Moneda(Monedas.SelectedIndex).CodMoneda)
            Analitico.SetParameterValue("Simb", AdAnalitico1.Moneda(Monedas.SelectedIndex).Simbolo)
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "KeyDown"
    Private Sub dtInicial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtInicial.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtFinal.Focus()
        End If
    End Sub

    Private Sub dtFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Monedas.Focus()
        End If
    End Sub

    Private Sub Monedas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Monedas.KeyDown
        If e.KeyCode = Keys.Enter Then
            smbGenerar.Focus()
        End If
    End Sub
#End Region

End Class
