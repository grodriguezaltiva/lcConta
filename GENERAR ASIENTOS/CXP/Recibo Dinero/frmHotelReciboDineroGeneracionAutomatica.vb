Imports Utilidades
Imports System.Data.SqlClient

Public Class frmHotelReciboDineroGeneracionAutomatica
    Inherits Contabilidad.Plantilla

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
    Friend WithEvents txtHaber As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDebe As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGenerarAsiento1 As System.Windows.Forms.Button
    Friend WithEvents txtTotalHaber As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalDebe As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdapterDetallesAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsAsientoReciboCxC1 As Contabilidad.DsAsientoReciboCxC
    Friend WithEvents AdapterReciboCxC As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ButtonImprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmHotelReciboDineroGeneracionAutomatica))
        Me.txtHaber = New DevExpress.XtraEditors.TextEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDebe = New DevExpress.XtraEditors.TextEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnGenerarAsiento1 = New System.Windows.Forms.Button
        Me.txtTotalHaber = New System.Windows.Forms.TextBox
        Me.txtTotalDebe = New System.Windows.Forms.TextBox
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.txtClave = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.DsAsientoReciboCxC1 = New Contabilidad.DsAsientoReciboCxC
        Me.AdapterReciboCxC = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButtonImprimir = New System.Windows.Forms.Button
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsAsientoReciboCxC1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 408)
        Me.ToolBar1.Name = "ToolBar1"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Text = "Recibo de dinero"
        '
        'txtHaber
        '
        Me.txtHaber.EditValue = ""
        Me.txtHaber.Location = New System.Drawing.Point(472, 124)
        Me.txtHaber.Name = "txtHaber"
        '
        'txtHaber.Properties
        '
        Me.txtHaber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtHaber.Size = New System.Drawing.Size(132, 21)
        Me.txtHaber.TabIndex = 140
        Me.txtHaber.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(472, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 14)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Haber"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label6.Visible = False
        '
        'txtDebe
        '
        Me.txtDebe.EditValue = ""
        Me.txtDebe.Location = New System.Drawing.Point(337, 124)
        Me.txtDebe.Name = "txtDebe"
        '
        'txtDebe.Properties
        '
        Me.txtDebe.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtDebe.Size = New System.Drawing.Size(132, 21)
        Me.txtDebe.TabIndex = 139
        Me.txtDebe.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(337, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 14)
        Me.Label5.TabIndex = 152
        Me.Label5.Text = "Debe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(184, 124)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(148, 19)
        Me.txtDescripcion.TabIndex = 138
        Me.txtDescripcion.Text = ""
        Me.txtDescripcion.Visible = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(184, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 14)
        Me.Label4.TabIndex = 151
        Me.Label4.Text = "Descripción"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.AutoSize = False
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(31, 125)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(148, 19)
        Me.txtCodigo.TabIndex = 137
        Me.txtCodigo.Text = ""
        Me.txtCodigo.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 14)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Código"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(275, 150)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.TabIndex = 141
        Me.btnModificar.Text = "Agregar"
        Me.btnModificar.Visible = False
        '
        'btnGenerarAsiento1
        '
        Me.btnGenerarAsiento1.Location = New System.Drawing.Point(375, 48)
        Me.btnGenerarAsiento1.Name = "btnGenerarAsiento1"
        Me.btnGenerarAsiento1.Size = New System.Drawing.Size(107, 23)
        Me.btnGenerarAsiento1.TabIndex = 3
        Me.btnGenerarAsiento1.Text = "Generar"
        '
        'txtTotalHaber
        '
        Me.txtTotalHaber.AutoSize = False
        Me.txtTotalHaber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalHaber.Enabled = False
        Me.txtTotalHaber.Location = New System.Drawing.Point(469, 373)
        Me.txtTotalHaber.Name = "txtTotalHaber"
        Me.txtTotalHaber.ReadOnly = True
        Me.txtTotalHaber.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalHaber.TabIndex = 149
        Me.txtTotalHaber.Text = ""
        Me.txtTotalHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalDebe
        '
        Me.txtTotalDebe.AutoSize = False
        Me.txtTotalDebe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalDebe.Enabled = False
        Me.txtTotalDebe.Location = New System.Drawing.Point(318, 373)
        Me.txtTotalDebe.Name = "txtTotalDebe"
        Me.txtTotalDebe.ReadOnly = True
        Me.txtTotalDebe.Size = New System.Drawing.Size(144, 18)
        Me.txtTotalDebe.TabIndex = 148
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(433, 442)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 146
        Me.txtUsuario.Text = ""
        '
        'txtClave
        '
        Me.txtClave.AutoSize = False
        Me.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtClave.Location = New System.Drawing.Point(353, 442)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(72, 14)
        Me.txtClave.TabIndex = 0
        Me.txtClave.Text = ""
        Me.txtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(433, 426)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 147
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(353, 426)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 14)
        Me.Label10.TabIndex = 145
        Me.Label10.Text = "Clave"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(246, 79)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaFinal.TabIndex = 2
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(246, 47)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(104, 20)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(86, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 14)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Fecha final:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(86, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 14)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Fecha inicio:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Origina" & _
        "l_Fecha) AND (FechaEntrada = @Original_FechaEntrada) AND (IdNumDoc = @Original_I" & _
        "dNumDoc) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo)" & _
        " AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) A" & _
        "ND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Obse" & _
        "rvaciones) AND (Periodo = @Original_Periodo) AND (TipoCambio = @Original_TipoCam" & _
        "bio) AND (TipoDoc = @Original_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND" & _
        " (TotalHaber = @Original_TotalHaber)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, " & _
        "TipoDoc, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modu" & _
        "lo, Observaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio) " & _
        "VALUES (@NumAsiento, @Fecha, @IdNumDoc, @NumDoc, @Beneficiario, @TipoDoc, @Accio" & _
        "n, @Anulado, @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Obs" & _
        "ervaciones, @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio); S" & _
        "ELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulad" & _
        "o, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nomb" & _
        "reUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulad" & _
        "o, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nomb" & _
        "reUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio FROM AsientosContables"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, IdNumDoc =" & _
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
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
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
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (Tipocambio = @Original_Tipocambio OR @Original_Tipocambio" & _
        " IS NULL AND Tipocambio IS NULL)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "pocambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, Tipocambio FROM DetallesAsientosContable"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE DetallesAsientosContable SET NumAsiento = @NumAsiento, Cuenta = @Cuenta, N" & _
        "ombreCuenta = @NombreCuenta, Monto = @Monto, Debe = @Debe, Haber = @Haber, Descr" & _
        "ipcionAsiento = @DescripcionAsiento, Tipocambio = @Tipocambio WHERE (ID_Detalle " & _
        "= @Original_ID_Detalle) AND (Cuenta = @Original_Cuenta) AND (Debe = @Original_De" & _
        "be) AND (DescripcionAsiento = @Original_DescripcionAsiento) AND (Haber = @Origin" & _
        "al_Haber) AND (Monto = @Original_Monto) AND (NombreCuenta = @Original_NombreCuen" & _
        "ta) AND (NumAsiento = @Original_NumAsiento) AND (Tipocambio = @Original_Tipocamb" & _
        "io OR @Original_Tipocambio IS NULL AND Tipocambio IS NULL); SELECT ID_Detalle, N" & _
        "umAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocam" & _
        "bio FROM DetallesAsientosContable WHERE (ID_Detalle = @ID_Detalle)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipocambio", System.Data.SqlDbType.Float, 8, "Tipocambio"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipocambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipocambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle"))
        '
        'DsAsientoReciboCxC1
        '
        Me.DsAsientoReciboCxC1.DataSetName = "DsAsientoReciboCxC"
        Me.DsAsientoReciboCxC1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'AdapterReciboCxC
        '
        Me.AdapterReciboCxC.InsertCommand = Me.SqlInsertCommand3
        Me.AdapterReciboCxC.SelectCommand = Me.SqlSelectCommand3
        Me.AdapterReciboCxC.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientoReciboCxC", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Recibo", "Id_Recibo"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("MontoPago", "MontoPago"), New System.Data.Common.DataColumnMapping("FormaPago", "FormaPago"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("DescripcionCuenta", "DescripcionCuenta")})})
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO AsientoReciboCxC(Id_Recibo, Fecha, MontoPago, FormaPago, CodMoneda, C" & _
        "uentaContable, DescripcionCuenta) VALUES (@Id_Recibo, @Fecha, @MontoPago, @Forma" & _
        "Pago, @CodMoneda, @CuentaContable, @DescripcionCuenta); SELECT Id_Recibo, Fecha," & _
        " MontoPago, FormaPago, CodMoneda, CuentaContable, DescripcionCuenta FROM Asiento" & _
        "ReciboCxC"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Recibo", System.Data.SqlDbType.Int, 8, "Id_Recibo"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 8, "Fecha"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MontoPago", System.Data.SqlDbType.Float, 8, "MontoPago"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FormaPago", System.Data.SqlDbType.VarChar, 50, "FormaPago"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Float, 8, "CodMoneda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 75, "CuentaContable"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionCuenta", System.Data.SqlDbType.VarChar, 350, "DescripcionCuenta"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT Id_Recibo, Fecha, MontoPago, FormaPago, CodMoneda, CuentaContable, Descrip" & _
        "cionCuenta FROM AsientoReciboCxC"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.DsAsientoReciboCxC1.Detalles
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(15, 107)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(600, 259)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 164
        Me.griDetalle.Text = "Asientos de venta"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GroupPanelText = "Detalle del Asiento"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "CuentaContable"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 98
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "DescripcionCuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 300
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
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 93
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
        Me.GridColumn4.Width = 95
        '
        'ButtonImprimir
        '
        Me.ButtonImprimir.Location = New System.Drawing.Point(14, 374)
        Me.ButtonImprimir.Name = "ButtonImprimir"
        Me.ButtonImprimir.TabIndex = 165
        Me.ButtonImprimir.Text = "Revisar"
        '
        'frmHotelReciboDineroGeneracionAutomatica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(630, 460)
        Me.Controls.Add(Me.ButtonImprimir)
        Me.Controls.Add(Me.griDetalle)
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
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmHotelReciboDineroGeneracionAutomatica"
        Me.Text = "Recibo de dinero: Generación automática de asiento"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
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
        Me.Controls.SetChildIndex(Me.griDetalle, 0)
        Me.Controls.SetChildIndex(Me.ButtonImprimir, 0)
        CType(Me.txtHaber.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDebe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsAsientoReciboCxC1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim usua As Object
    Dim CuentaCXC, DescripcionCXC, CuentaTCXC, DescripcionTCXC As String
    Dim TipoCambio As Double
#End Region

#Region "Load"
    Private Sub frmAsientoVentaGeneracionAutomatica_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        ValoresDefecto()
        Cargar()
    End Sub

    Private Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsAsientoReciboCxC1.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsAsientoReciboCxC1.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsAsientoReciboCxC1.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsAsientoReciboCxC1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsAsientoReciboCxC1.AsientosContables.TipoDocColumn.DefaultValue = 28
        DsAsientoReciboCxC1.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsAsientoReciboCxC1.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsAsientoReciboCxC1.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsAsientoReciboCxC1.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsAsientoReciboCxC1.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsAsientoReciboCxC1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsAsientoReciboCxC1.AsientosContables.ModuloColumn.DefaultValue = "Asiento Recibos de Dinero"
        DsAsientoReciboCxC1.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsAsientoReciboCxC1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsAsientoReciboCxC1.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsAsientoReciboCxC1.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DsAsientoReciboCxC1.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DsAsientoReciboCxC1.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsAsientoReciboCxC1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsAsientoReciboCxC1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsAsientoReciboCxC1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsAsientoReciboCxC1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsAsientoReciboCxC1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsAsientoReciboCxC1.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsAsientoReciboCxC1.DetallesAsientosContable.HaberColumn.DefaultValue = 0
        DsAsientoReciboCxC1.DetallesAsientosContable.TipocambioColumn.DefaultValue = 1
    End Sub


    Private Sub Buscar()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        Try
            Dim sql As String = "SELECT TOP 1 (SELECT CuentaContable FROM cuentacontable WHERE (Id = (SELECT IdCuentacobrar " & _
                "FROM settingcuentacontable))) AS CuentaCXC, (SELECT Descripcion FROM cuentacontable WHERE (Id = (SELECT IdCuentacobrar " & _
                "FROM settingcuentacontable))) AS DescripcionCXC, (SELECT CuentaContable FROM cuentacontable WHERE (Id = (SELECT Idtcxc " & _
                "FROM settingcuentacontable))) AS CuentaTCXC, (SELECT Descripcion FROM cuentacontable WHERE (Id = (SELECT Idtcxc " & _
                "FROM settingcuentacontable))) AS DescripcionTCXC FROM CuentaContable"

            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            cnnConexion.Open()

            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            If rstReader.Read() = False Then Exit Sub

            CuentaCXC = rstReader("CuentaCXC")
            DescripcionCXC = rstReader("DescripcionCXC")
            CuentaTCXC = rstReader("CuentaTCXC")
            DescripcionTCXC = rstReader("DescripcionTCXC")
            

        Catch ex As System.Exception
            'MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        Finally
            cnnConexion.Close()
        End Try
    End Sub


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
        dtpFechaInicio.Enabled = False
        dtpFechaFinal.Enabled = False
    End Sub


    Private Sub Limpiar()
        DsAsientoReciboCxC1.DetallesAsientosContable.Clear()
        DsAsientoReciboCxC1.AsientosContables.Clear()
        DsAsientoReciboCxC1.AsientoReciboCxC.Clear()
        DsAsientoReciboCxC1.Detalles.Clear()
        Me.griDetalle.Refresh()
        Me.txtTotalHaber.Text = ""
        Me.txtTotalDebe.Text = ""
        Me.txtTotalDebe.Text = Format(0, "¢###,##0.00")
        Me.txtTotalHaber.Text = Format(0, "¢###,##0.00")
    End Sub
#End Region

#Region "Funciones GUI"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : NUEVO()

            Case 2 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 6 : Me.Close()
        End Select
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


    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarAsiento1.Click
        GenerarRecibo()
    End Sub


    Private Sub btnGenerarAsiento1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btnGenerarAsiento1.KeyDown
        If e.KeyCode = Keys.Enter Then
            GenerarRecibo()
        End If
    End Sub


    Private Sub dtpFechaInicio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaInicio.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.dtpFechaFinal.Focus()
        End If
    End Sub


    Private Sub dtpFechaFinal_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtpFechaFinal.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.btnGenerarAsiento1.Focus()
        End If
    End Sub


    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsientoVenta()
        End If
        If e.KeyCode = Keys.Enter Then
            BuscarCuentaContable()
        End If
    End Sub


    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        'If Me.txtCodigo.Text = "" Or Me.txtDescripcion.Text = "" Then
        '    MsgBox("No hay cuenta cuntable que agregar")
        '    Exit Sub
        'End If

        'If txtDebe.Text <> 0 And txtHaber.Text <> 0 Then
        '    MsgBox("Alguno de los montos del debe o el haber tiene que ser 0" & vbCrLf & "No se puede agregar la cuenta", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'If txtDebe.Text = 0 And txtHaber.Text = 0 Then
        '    MsgBox("Debe ingresar un monto en el debo o el haber" & vbCrLf & "No se puede agregar la cuenta", MsgBoxStyle.Information)
        '    Exit Sub
        'End If

        'Try
        '    Dim NuevaFila As DatasetAsientoVenta.GeneracionAutomaticaAsientoVentaRow
        '    NuevaFila = Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.NewGeneracionAutomaticaAsientoVentaRow
        '    NuevaFila.Codigo = Me.txtCodigo.Text
        '    NuevaFila.Descripcion = Me.txtDescripcion.Text
        '    NuevaFila.Haber = txtHaber.Text
        '    NuevaFila.Debe = txtDebe.Text
        '    Me.dtsAsientoVenta.GeneracionAutomaticaAsientoVenta.AddGeneracionAutomaticaAsientoVentaRow(NuevaFila)
        '    Accion = "MAN"
        'Catch ex As Exception
        'End Try

        'ReDim Preserve IdCuenta1(5)
        'Dim clsConexion As New Conexion
        'Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        'Dim rstReader As System.Data.SqlClient.SqlDataReader
        'Dim sql As String = "SELECT id  FROM CuentaContable where CuentaContable = '" & Me.txtCodigo.Text & "' "

        'cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        'cnnConexion.Open()

        'rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        'If rstReader.Read() = False Then Exit Sub

        'IdCuenta1(4) = rstReader(0)

        'cnnConexion.Close()

        'txtHaber.Text = Format(0, "###,##0.00")
        'txtDebe.Text = Format(0, "###,##0.00")
        'txtCodigo.Clear()
        'txtDescripcion.Clear()

        'If caso = 0 Then
        '    LlenarTotalesAsiento1()
        'End If
        'Me.btnModificar.Enabled = False
    End Sub
#End Region

#Region "Funciones Basicas"
    Private Sub NUEVO()
        Try
            If Me.ToolBarNuevo.Text = "Nuevo" Then
                Me.ToolBarNuevo.ImageIndex = "3"
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.btnGenerarAsiento1.Enabled = True
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                Me.btnModificar.Enabled = False
                dtpFechaInicio.Focus()

            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnGenerarAsiento1.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.dtpFechaInicio.Enabled = False
                Me.dtpFechaFinal.Enabled = False
                Me.btnModificar.Enabled = False
            End If

            Limpiar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Registrar()
        If ValidarCampos() Then
            If DsAsientoReciboCxC1.DetallesAsientosContable.Count < 1 Then
                MsgBox("No se puede guardar el asiento porque no tiene detalles!", MsgBoxStyle.Exclamation, "Asiento de Recibos de Dinero")
                Exit Sub
            End If
            If MsgBox("Desea Guardar asiento de Recibo de Dinero", MsgBoxStyle.OKCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            If TransAsiento() = False Then
                MsgBox("Error Guardando el Asiento Contable", MsgBoxStyle.Exclamation, "Asiento de Recibos de Dinero")
                Exit Sub
            End If
            If ActualizaRecibos() = False Then
                MsgBox("Error Actualizando los recibos de dinero", MsgBoxStyle.Exclamation, "Asiento de Recibos de Dinero")
            End If

            MsgBox("Asiento Contable Guardado Satisfactoriamente", MsgBoxStyle.Information, "Asiento de Recibos de Dinero")
            Limpiar()
            NUEVO()
        End If
    End Sub
#End Region

#Region "Funciones Llenar"
    Function Cargar_Recibos()
        Dim cnnv As SqlConnection = Nothing
        Dim cConexion As New Conexion
        Dim Fx As New cFunciones

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT * FROM AsientoReciboCxC WHERE (AsientoReciboCxC.Fecha BETWEEN dbo.DateOnlyInicio(@FechaInicio) AND dbo.DateOnlyFinal(@FechaFinal))"
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@FechaInicio", SqlDbType.DateTime))
            cmdv.Parameters.Add(New SqlParameter("@FechaFinal", SqlDbType.DateTime))
            cmdv.Parameters("@FechaInicio").Value = dtpFechaInicio.Value
            cmdv.Parameters("@FechaFinal").Value = dtpFechaFinal.Value
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsAsientoReciboCxC1.AsientoReciboCxC.Clear()
            dv.Fill(DsAsientoReciboCxC1.AsientoReciboCxC)

            '----------------------------------------------------------------------------
            'RECORRE LOS DETALLES DE LOS ASIENTOS
            For n As Integer = 0 To Me.DsAsientoReciboCxC1.AsientoReciboCxC.Rows.Count - 1
                If Me.DsAsientoReciboCxC1.AsientoReciboCxC.Rows(n).Item("CodMoneda") = 2 Then  'SI ES EN DOLARES MULTIPLICA
                    Me.DsAsientoReciboCxC1.AsientoReciboCxC.Rows(n).Item("MontoPago") = (Me.DsAsientoReciboCxC1.AsientoReciboCxC.Rows(n).Item("MontoPago") * Fx.TipoCambio(Me.DsAsientoReciboCxC1.AsientoReciboCxC.Rows(n).Item("Fecha")))
                End If
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

#Region "Funciones Validar"
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


    Private Function ValidarSetting() As Boolean
        If Me.CuentaCXC = "" Or Me.CuentaTCXC = "" Then
            MsgBox("No se puede generar asientos de Recibos automáticamente si no se a configurado los asientos en Setting cuenta!", MsgBoxStyle.Information)
            Exit Function
        End If

        ValidarSetting = True
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
                        If ValidarSetting() Then
                            txtUsuario.Text = rs("Nombre")
                            txtUsuario.Enabled = False
                            txtClave.Enabled = False
                            Me.ToolBarNuevo.Enabled = True
                            Me.ToolBarBuscar.Enabled = True
                            Me.dtpFechaInicio.Focus()
                            Return True
                        End If

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
    Function ActualizaRecibos() As Boolean
        Dim Fx As New Conexion     'REALIZA LA ACTUALIZACION DE LAS COMPRAS

        Try
            For i As Integer = 0 To DsAsientoReciboCxC1.AsientoReciboCxC.Count - 1
                Fx.UpdateRecords("abonoccobrar", "Contabilizado = 1, Asiento = '" & BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("NumAsiento") & "'", "Id_Recibo = " & DsAsientoReciboCxC1.AsientoReciboCxC(i).Id_Recibo, "Hotel")
            Next
            Return True

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function


    Public Sub LlenaGridDetalles(ByVal Cuenta As String, ByVal Descripcion As String, ByVal Debe As Double, ByVal Haber As Double)
        Dim NuevaFila As DsAsientoReciboCxC.DetallesRow
        NuevaFila = DsAsientoReciboCxC1.Detalles.NewDetallesRow
        NuevaFila.CuentaContable = Cuenta
        NuevaFila.DescripcionCuenta = Descripcion
        NuevaFila.Debe = Math.Abs(Debe)
        NuevaFila.Haber = Math.Abs(Haber)
        DsAsientoReciboCxC1.Detalles.AddDetallesRow(NuevaFila)
    End Sub


    Private Sub LlamarFmrBuscarAsientoVenta()
        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
" where Movimiento=1 "
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
#End Region

#Region "Generar Asiento Recibo"
    Private Sub GenerarRecibo()
        Dim Fx As New cFunciones
        If Me.dtpFechaInicio.Value > Me.dtpFechaFinal.Value Then
            MsgBox("La fecha de inicio no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If
        If Fx.ValidarPeriodo(dtpFechaFinal.Value) = False Then
            MsgBox("La fecha del asiento NO corresponde al periodo de trabajo! O el periodo esta cerrado!" & vbCrLf & "No se puede Generar el Asiento", MsgBoxStyle.Information, "Sistema SeeSoft")
            Exit Sub
        End If
        GuardaAsiento()
        ToolBarRegistrar.Enabled = True
    End Sub
#End Region

#Region "Asiento de Recibos"
    Public Sub GuardaAsiento()
        Dim Fx As New cFunciones

        DsAsientoReciboCxC1.DetallesAsientosContable.Clear()
        DsAsientoReciboCxC1.AsientosContables.Clear()
        TipoCambio = Fx.TipoCambio(dtpFechaFinal.Value)

        BindingContext(DsAsientoReciboCxC1, "AsientosContables").EndCurrentEdit()
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").AddNew()
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("NumAsiento") = Fx.BuscaNumeroAsiento("CXC-" & Format(dtpFechaFinal.Value.Month, "00") & Format(dtpFechaFinal.Value.Date, "yy") & "-")
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Fecha") = dtpFechaFinal.Value
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("IdNumDoc") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("NumDoc") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Beneficiario") = ""
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TipoDoc") = 28
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Accion") = "AUT"
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Anulado") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Mayorizado") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("FechaEntrada") = Now.Date
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(dtpFechaFinal.Value)
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("NumMayorizado") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Modulo") = "Asiento Recibos de Dinero"
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Observaciones") = "Asiento Recibos de Dinero del " & dtpFechaInicio.Value & " al " & dtpFechaInicio.Value
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TotalDebe") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TotalHaber") = 0
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("CodMoneda") = 1
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TipoCambio") = TipoCambio
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").EndCurrentEdit()

        'CREA LOS DETALLES DEL ASIENTO
        AsientoDetalle()

        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TotalDebe") = Total()
        BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TotalHaber") = BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TotalDebe")

        If BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("TotalDebe") <= 0 Then
            BindingContext(DsAsientoReciboCxC1, "AsientosContables").CancelCurrentEdit()
        Else
            BindingContext(DsAsientoReciboCxC1, "AsientosContables").EndCurrentEdit()
        End If
    End Sub


    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String)
        If Monto > 0 Then   'GUARDA LOS DETALLES DEL ASIENTO CONTABLE
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("NumAsiento")
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsAsientoReciboCxC1, "AsientosContables").Current("Observaciones")
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("TipoCambio") = TipoCambio
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            LlenaGridDetalles(Cuenta, NombreCuenta, (Monto * Debe), (Monto * Haber))
        End If
    End Sub


    Public Sub AsientoDetalle()
        Cargar_Recibos()

        Dim DrCuentas() As System.Data.DataRow
        Dim DrCuenta As System.Data.DataRow
        Dim Cuentas(DsAsientoReciboCxC1.AsientoReciboCxC.Count - 1) As String
        Dim Encontrado As Boolean = False
        Dim C As Integer = 0

        Try
            If DsAsientoReciboCxC1.AsientoReciboCxC.Count > 0 Then
                '----------------------------------------------------------------------------
                'CREA EL DETALLE PARA LOS RECIBOS EN EFECTIVO O CHEQUE
                BuscaMontoTipo()
                '----------------------------------------------------------------------------

                DrCuentas = DsAsientoReciboCxC1.AsientoReciboCxC.Select("FormaPago = 'TRA' OR FormaPago = 'TAR'")
                If DrCuentas.Length <> 0 Then 'SI EXISTE
                    For i As Integer = 0 To DrCuentas.Length - 1
                        DrCuenta = DrCuentas(i)

                        '----------------------------------------------------------------------------
                        'RECORRE TODOS LOS DETALLES DE ASIENTOS PARA LAS CUENTAS
                        For b As Integer = 0 To Cuentas.Length - 1
                            If Cuentas(b) = DrCuenta("CuentaContable") Then
                                Encontrado = True
                            End If
                        Next
                        '----------------------------------------------------------------------------

                        '----------------------------------------------------------------------------
                        If Encontrado = False Then  'SI TODAVIA NO SE REALIZADO EL ASIENTO PARA LA CUENTA
                            Cuentas(C) = DrCuenta("CuentaContable")
                            C += 1
                            BuscaMontoCuenta(DrCuenta("CuentaContable")) 'GUARDA EL DETALLE DEL ASIENTO PARA LA CUENTA
                            '----------------------------------------------------------------------------
                            '----------------------------------------------------------------------------
                        Else    'SI YA HA SIDO TOMADO EN CUENTA
                            Encontrado = False
                        End If
                        '----------------------------------------------------------------------------
                    Next
                End If

                '----------------------------------------------------------------------------
                'GUARDA EL DETALLE PARA LA CXC
                GuardaAsientoDetalle(Total(), False, True, CuentaCXC, DescripcionCXC)
                '----------------------------------------------------------------------------
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub BuscaMontoTipo()
        Dim DrCuentas() As System.Data.DataRow
        Dim Monto As Double

        Try
            If DsAsientoReciboCxC1.AsientoReciboCxC.Count > 0 Then
                DrCuentas = DsAsientoReciboCxC1.AsientoReciboCxC.Select("FormaPago = 'EFE' OR FormaPago = 'CHE'")
                
                If DrCuentas.Length <> 0 Then 'SI EXISTE
                    '----------------------------------------------------------------------------
                    For i As Integer = 0 To DrCuentas.Length - 1
                        Monto += DrCuentas(i)(2)
                    Next
                    '----------------------------------------------------------------------------

                    '----------------------------------------------------------------------------
                    'GUARDA EL DETALLE PARA LA CUENTA CONTABLE DE LA BODEGA
                    GuardaAsientoDetalle(Math.Abs(Monto), True, False, CuentaTCXC, DescripcionTCXC)
                    '----------------------------------------------------------------------------
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Private Sub BuscaMontoCuenta(ByVal Cuenta As String)
        Dim DrCuentas() As System.Data.DataRow
        Dim Monto As Double

        Try
            If DsAsientoReciboCxC1.AsientoReciboCxC.Count > 0 Then
                DrCuentas = DsAsientoReciboCxC1.AsientoReciboCxC.Select("CuentaContable = '" & Cuenta & "'")

                If DrCuentas.Length <> 0 Then 'SI EXISTE
                    '----------------------------------------------------------------------------
                    For i As Integer = 0 To DrCuentas.Length - 1
                        Monto += DrCuentas(i)(2)
                    Next i
                    '----------------------------------------------------------------------------

                    '----------------------------------------------------------------------------
                    'GUARDA EL DETALLE PARA LA CUENTA CONTABLE DE LA BODEGA
                    GuardaAsientoDetalle(Math.Abs(Monto), True, False, DrCuentas(0)(5), DrCuentas(0)(6))
                    '----------------------------------------------------------------------------
                End If
            End If

        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
        End Try
    End Sub


    Function Total() As Double   'CALCULA EL MONTO TOTAL
        Dim Debe, Haber As Double
        For i As Integer = 0 To DsAsientoReciboCxC1.DetallesAsientosContable.Count - 1
            Total += DsAsientoReciboCxC1.DetallesAsientosContable(i).Monto
            If DsAsientoReciboCxC1.DetallesAsientosContable(i).Debe Then
                Debe += DsAsientoReciboCxC1.DetallesAsientosContable(i).Monto
            Else
                Haber += DsAsientoReciboCxC1.DetallesAsientosContable(i).Monto
            End If
        Next i
        Me.txtTotalDebe.Text = Format(Debe, "¢###,##0.00")
        Me.txtTotalHaber.Text = Format(Haber, "¢###,##0.00")
    End Function


    Function TransAsiento() As Boolean
        Dim Trans As SqlTransaction     'REALIZA LA TRANSACCION DE LOS ASIENTOS CONTABLES

        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()

            Trans = SqlConnection1.BeginTransaction
            BindingContext(DsAsientoReciboCxC1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsAsientoReciboCxC1, "AsientosContables").EndCurrentEdit()

            AdapterDetallesAsientos.UpdateCommand.Transaction = Trans
            AdapterDetallesAsientos.DeleteCommand.Transaction = Trans
            AdapterDetallesAsientos.InsertCommand.Transaction = Trans

            AdapterAsientos.UpdateCommand.Transaction = Trans
            AdapterAsientos.DeleteCommand.Transaction = Trans
            AdapterAsientos.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'INICIA LA TRANSACCION....
            AdapterDetallesAsientos.Update(DsAsientoReciboCxC1.DetallesAsientosContable)
            AdapterAsientos.Update(DsAsientoReciboCxC1.AsientosContables)
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

    
    Private Sub ButtonImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonImprimir.Click
        imprimir()

    End Sub
    Sub imprimir()
        Dim visor As New frmVisorReportes
        Dim reporte As New CrystalReportRecibodDinero
        reporte.SetParameterValue(0, Me.dtpFechaInicio.Value)
        reporte.SetParameterValue(1, Me.dtpFechaFinal.Value)

        CrystalReportsConexion2.LoadReportViewer(visor.rptViewer, reporte, True)
        visor.rptViewer.ReportSource = reporte
        visor.MdiParent = Me.MdiParent
        visor.Show()
        visor.rptViewer.Show()


    End Sub

    Private Sub TituloModulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TituloModulo.Click

    End Sub
End Class
