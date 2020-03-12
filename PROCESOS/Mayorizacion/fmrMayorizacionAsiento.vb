Imports Utilidades
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base

Public Class fmrMayorizacionAsiento
    Inherits System.Windows.Forms.Form

    Dim cedula As String
    Dim usua As New Usuario_Logeado
    Dim dr As DataRow
    Dim NombreUsuario As String
    Dim clave As String = ""
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
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnEjecutar As System.Windows.Forms.Button
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents sqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents chkPeriodo As System.Windows.Forms.CheckBox
    Protected WithEvents ImageList As System.Windows.Forms.ImageList
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents txtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents dtsMayorizacionAsiento As Contabilidad.DatasetMayorizacionAsiento
    Friend WithEvents B_Marca As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents B_Desmarcar As DevExpress.XtraEditors.SimpleButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(fmrMayorizacionAsiento))
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNumero = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnEjecutar = New System.Windows.Forms.Button
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox
        Me.sqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.dtsMayorizacionAsiento = New Contabilidad.DatasetMayorizacionAsiento
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.chkPeriodo = New System.Windows.Forms.CheckBox
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.TxtClave = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.B_Marca = New DevExpress.XtraEditors.SimpleButton
        Me.B_Desmarcar = New DevExpress.XtraEditors.SimpleButton
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtsMayorizacionAsiento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(704, 32)
        Me.TituloModulo.TabIndex = 61
        Me.TituloModulo.Text = "Mayorización de asientos"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 56)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mayorización"
        '
        'txtFecha
        '
        Me.txtFecha.AutoSize = False
        Me.txtFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtFecha.Location = New System.Drawing.Point(136, 32)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(120, 14)
        Me.txtFecha.TabIndex = 2
        Me.txtFecha.Text = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(136, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Fecha"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Número"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNumero
        '
        Me.txtNumero.AutoSize = False
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNumero.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(16, 32)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.Size = New System.Drawing.Size(112, 14)
        Me.txtNumero.TabIndex = 1
        Me.txtNumero.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEjecutar)
        Me.GroupBox2.Controls.Add(Me.dtpFechaFinal)
        Me.GroupBox2.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 56)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Periodo"
        '
        'btnEjecutar
        '
        Me.btnEjecutar.Location = New System.Drawing.Point(312, 24)
        Me.btnEjecutar.Name = "btnEjecutar"
        Me.btnEjecutar.Size = New System.Drawing.Size(56, 24)
        Me.btnEjecutar.TabIndex = 6
        Me.btnEjecutar.Text = "Ejecutar"
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Enabled = False
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaFinal.Location = New System.Drawing.Point(160, 32)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(136, 20)
        Me.dtpFechaFinal.TabIndex = 5
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFechaInicio.Location = New System.Drawing.Point(16, 32)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(136, 20)
        Me.dtpFechaInicio.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(160, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Fecha final"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 16)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Fecha inicio"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNombreUsuario)
        Me.GroupBox3.Location = New System.Drawing.Point(504, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(192, 40)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hecho por"
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.AutoSize = False
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtNombreUsuario.Location = New System.Drawing.Point(16, 16)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.ReadOnly = True
        Me.txtNombreUsuario.Size = New System.Drawing.Size(152, 14)
        Me.txtNombreUsuario.TabIndex = 67
        Me.txtNombreUsuario.Text = ""
        '
        'sqlDataAdapter
        '
        Me.sqlDataAdapter.AcceptChangesDuringFill = False
        Me.sqlDataAdapter.DeleteCommand = Me.SqlDeleteCommand1
        Me.sqlDataAdapter.InsertCommand = Me.SqlInsertCommand1
        Me.sqlDataAdapter.SelectCommand = Me.SqlSelectCommand1
        Me.sqlDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber")})})
        Me.sqlDataAdapter.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (Fecha = @Original_Fecha) AND (FechaEntrada = @Original" & _
        "_FechaEntrada) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_M" & _
        "odulo) AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_Num" & _
        "Doc) AND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Origina" & _
        "l_Observaciones) AND (Periodo = @Original_Periodo) AND (TipoDoc = @Original_Tipo" & _
        "Doc) AND (TotalDebe = @Original_TotalDebe) AND (TotalHaber = @Original_TotalHabe" & _
        "r)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, A" & _
        "ccion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observ" & _
        "aciones, NombreUsuario, TotalDebe, TotalHaber) VALUES (@NumAsiento, @Fecha, @Num" & _
        "Doc, @Beneficiario, @TipoDoc, @Accion, @Anulado, @FechaEntrada, @Mayorizado, @Pe" & _
        "riodo, @NumMayorizado, @Modulo, @Observaciones, @NombreUsuario, @TotalDebe, @Tot" & _
        "alHaber); SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anula" & _
        "do, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, Nom" & _
        "breUsuario, TotalDebe, TotalHaber FROM AsientosContables WHERE (NumAsiento = @Nu" & _
        "mAsiento)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
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
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber FROM AsientosContables"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, NumDoc = @" & _
        "NumDoc, Beneficiario = @Beneficiario, TipoDoc = @TipoDoc, Accion = @Accion, Anul" & _
        "ado = @Anulado, FechaEntrada = @FechaEntrada, Mayorizado = @Mayorizado, Periodo " & _
        "= @Periodo, NumMayorizado = @NumMayorizado, Modulo = @Modulo, Observaciones = @O" & _
        "bservaciones, NombreUsuario = @NombreUsuario, TotalDebe = @TotalDebe, TotalHaber" & _
        " = @TotalHaber WHERE (NumAsiento = @Original_NumAsiento) AND (Accion = @Original" & _
        "_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Original_Benefic" & _
        "iario) AND (Fecha = @Original_Fecha) AND (FechaEntrada = @Original_FechaEntrada)" & _
        " AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo) AND (No" & _
        "mbreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) AND (NumM" & _
        "ayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Observacione" & _
        "s) AND (Periodo = @Original_Periodo) AND (TipoDoc = @Original_TipoDoc) AND (Tota" & _
        "lDebe = @Original_TotalDebe) AND (TotalHaber = @Original_TotalHaber); SELECT Num" & _
        "Asiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEntrada, Ma" & _
        "yorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario, TotalDeb" & _
        "e, TotalHaber FROM AsientosContables WHERE (NumAsiento = @NumAsiento)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
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
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'griDetalle
        '
        Me.griDetalle.DataSource = Me.dtsMayorizacionAsiento.AsientosContables
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(8, 160)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.griDetalle.Size = New System.Drawing.Size(688, 200)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 66
        Me.griDetalle.Text = "GridControl1"
        '
        'dtsMayorizacionAsiento
        '
        Me.dtsMayorizacionAsiento.DataSetName = "DatasetMayorizacionAsiento"
        Me.dtsMayorizacionAsiento.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AutoUpdateTotalSummary = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Mayorizado"
        Me.GridColumn1.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.GridColumn1.FieldName = "Mayorizado"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.VisibleIndex = 0
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Num. asiento"
        Me.GridColumn2.FieldName = "NumAsiento"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.VisibleIndex = 1
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.FieldName = "Fecha"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.VisibleIndex = 2
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Fecha entrada"
        Me.GridColumn4.FieldName = "FechaEntrada"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.VisibleIndex = 3
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Descripción"
        Me.GridColumn5.FieldName = "Observaciones"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.VisibleIndex = 4
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Total debe"
        Me.GridColumn6.FieldName = "TotalDebe"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.VisibleIndex = 5
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Total haber"
        Me.GridColumn7.FieldName = "TotalHaber"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.VisibleIndex = 6
        '
        'chkPeriodo
        '
        Me.chkPeriodo.AccessibleRole = System.Windows.Forms.AccessibleRole.WhiteSpace
        Me.chkPeriodo.Location = New System.Drawing.Point(384, 40)
        Me.chkPeriodo.Name = "chkPeriodo"
        Me.chkPeriodo.Size = New System.Drawing.Size(16, 24)
        Me.chkPeriodo.TabIndex = 3
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 402)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(704, 52)
        Me.ToolBar1.TabIndex = 68
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Mayorizar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(504, 368)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 14)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Usuario"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUsuario
        '
        Me.txtUsuario.AutoSize = False
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(504, 384)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(192, 14)
        Me.txtUsuario.TabIndex = 100
        Me.txtUsuario.Text = ""
        '
        'TxtClave
        '
        Me.TxtClave.AutoSize = False
        Me.TxtClave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtClave.Location = New System.Drawing.Point(424, 384)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(72, 14)
        Me.TxtClave.TabIndex = 0
        Me.TxtClave.Text = ""
        Me.TxtClave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(424, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "Clave"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'B_Marca
        '
        Me.B_Marca.Enabled = False
        Me.B_Marca.Location = New System.Drawing.Point(8, 368)
        Me.B_Marca.Name = "B_Marca"
        Me.B_Marca.Size = New System.Drawing.Size(96, 23)
        Me.B_Marca.TabIndex = 102
        Me.B_Marca.Text = "Marcar Todos"
        '
        'B_Desmarcar
        '
        Me.B_Desmarcar.Enabled = False
        Me.B_Desmarcar.Location = New System.Drawing.Point(112, 368)
        Me.B_Desmarcar.Name = "B_Desmarcar"
        Me.B_Desmarcar.Size = New System.Drawing.Size(120, 23)
        Me.B_Desmarcar.TabIndex = 103
        Me.B_Desmarcar.Text = "Desmarcar Todos"
        '
        'fmrMayorizacionAsiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(704, 454)
        Me.Controls.Add(Me.B_Desmarcar)
        Me.Controls.Add(Me.B_Marca)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.TxtClave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkPeriodo)
        Me.Controls.Add(Me.griDetalle)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.ToolBar1)
        Me.MaximizeBox = False
        Me.Name = "fmrMayorizacionAsiento"
        Me.Text = "Mayorización de asientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtsMayorizacionAsiento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Funciones Gui"
    Private Sub fmrMayorizacionAsiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        Cargar()
        clave = Configuracion.Claves.Configuracion("Clave")
        If clave.Equals("") Then
            SaveSetting("seesoft", "seguridad", "clave", "1")
        End If
        If Configuracion.Claves.Configuracion("Clave") = "0" Then
            NombreUsuario = usua.Nombre
            txtUsuario.Text = usua.Nombre
            txtUsuario.Enabled = False
            TxtClave.Enabled = False
            ToolBar1.Buttons(0).Enabled = True
            ToolBar1.Buttons(1).Enabled = True

            Me.dtsMayorizacionAsiento.AsientosContables.NombreUsuarioColumn.DefaultValue = usua.Nombre
        Else
            Me.TxtClave.Focus()
        End If

    End Sub

    Private Sub btnEjecutar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEjecutar.Click
        LlenarGriDetalle("")
    End Sub

    Private Sub chkPeriodo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPeriodo.CheckedChanged
        If Me.chkPeriodo.Checked = True Then
            Me.dtpFechaFinal.Enabled = True
            Me.dtpFechaInicio.Enabled = True
        Else
            Me.dtpFechaFinal.Enabled = False
            Me.dtpFechaInicio.Enabled = False
        End If
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()

            Case 1 : If PMU.Find Then LlamarFmrBuscarMayoriazazionAsiento() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : If PMU.Update Then
                    If VerificarBalance() Then
                        Registrar()
                    Else
                        MsgBox("No se puede mayorizar, porque uno de los asiento marcados no esta balanceado.", MsgBoxStyle.Information, "Atención...")
                    End If
                Else
                    MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...")
                    Exit Sub
                End If

            Case 3 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 5 : Me.Close()

        End Select
    End Sub

    Private Sub TxtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Loggin_Usuario() Then
                Me.ToolBarNuevo.Enabled = True
                Me.ToolBarBuscar.Enabled = True
            End If
        End If
    End Sub


    Private Sub B_Marca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Marca.Click
        Marca_Desmarca(True)
    End Sub


    Private Sub B_Desmarcar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Desmarcar.Click
        Marca_Desmarca(False)
    End Sub
#End Region

#Region "Funciones Iniciacion"
    Private Sub limpiar()
        Me.txtNumero.Clear()
    End Sub

    Private Sub Cargar()
        limpiar()

        Me.ToolBarImprimir.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarBuscar.Enabled = False
        Me.ToolBarNuevo.Enabled = False
        Me.btnEjecutar.Enabled = False
        Me.dtsMayorizacionAsiento.AsientosContables.Clear()
        Me.txtFecha.Text = Date.Now.Date

    End Sub
#End Region

#Region "Funciones Llenar"
    Private Sub LlenarGriDetalle(ByVal pCodigo As String)
        Try

            Dim sqlCommand As New System.Data.SqlClient.SqlCommand
            Dim sql As String
            Dim funcion As New cFunciones
            Dim Fechaini, FechaFin As String

            sql = "SELECT * FROM dbo.asientoscontables WHERE Anulado = 0 AND Mayorizado = 0" ' ORDER BY NumAsiento"

            If Me.chkPeriodo.Checked = True Then
                Fechaini = " CONVERT(DATETIME, '" & dtpFechaInicio.Value.Year & "-" & dtpFechaInicio.Value.Month & "-" & dtpFechaInicio.Value.Day & " 00:00:00', 102)"
                FechaFin = " CONVERT(DATETIME, '" & dtpFechaFinal.Value.Year & "-" & dtpFechaFinal.Value.Month & "-" & dtpFechaFinal.Value.Day & " 23:59:59', 102)"
                sql = "SELECT     AsientosContables.NumAsiento, AsientosContables.Fecha, AsientosContables.IdNumDoc, AsientosContables.NumDoc, AsientosContables.Beneficiario, " & _
                      " AsientosContables.TipoDoc, AsientosContables.Accion, AsientosContables.Anulado, AsientosContables.FechaEntrada, AsientosContables.Mayorizado, " & _
                      " AsientosContables.Periodo, AsientosContables.NumMayorizado, AsientosContables.Modulo, AsientosContables.Observaciones, " & _
                " AsientosContables.NombreUsuario, AsientosContables.CodMoneda, AsientosContables.TipoCambio, SUM(AsientoDC_DH_MAYO.DebeColon) " & _
                      " AS TotalDebe, SUM(AsientoDC_DH_MAYO.HaberColon) AS TotalHaber  " & _
" FROM         AsientosContables INNER JOIN " & _
                      " AsientoDC_DH_MAYO ON AsientosContables.NumAsiento = AsientoDC_DH_MAYO.NumAsiento " & _
" GROUP BY AsientosContables.NumAsiento, AsientosContables.Fecha, AsientosContables.IdNumDoc, AsientosContables.NumDoc, " & _
                      " AsientosContables.Beneficiario, AsientosContables.TipoDoc, AsientosContables.Accion, AsientosContables.FechaEntrada, AsientosContables.Periodo, " & _
                      " AsientosContables.NumMayorizado, AsientosContables.Modulo, AsientosContables.Observaciones, AsientosContables.NombreUsuario, " & _
                      " AsientosContables.CodMoneda, AsientosContables.TipoCambio, AsientosContables.Anulado, AsientosContables.Mayorizado HaVING AsientosContables.Anulado = 0 AND AsientosContables.Mayorizado = 0 AND AsientosContables.Fecha BETWEEN " & Fechaini & " AND  " & FechaFin & " ORDER BY AsientosContables.NumAsiento"
            End If

            If pCodigo <> "" Then
                ' sql = "SELECT dbo.asientoscontables.Mayorizado, dbo.asientoscontables.NumAsiento, dbo.asientoscontables.Fecha, dbo.asientoscontables.FechaEntrada, dbo.asientoscontables.Observaciones, dbo.AsientosDC.COLON AS TotalDebe,dbo.AsientosDC.COLON AS TotalHaber FROM dbo.asientoscontables, dbo.AsientosDC  WHERE dbo.AsientosDC.NumAsiento = dbo.asientoscontables.NumAsiento AND dbo.asientoscontables.Anulado = 0 AND dbo.asientoscontables.Mayorizado =1 AND NumMayorizado=" & Me.txtNumero.Text & " ORDER BY dbo.asientoscontables.NumAsiento"
                sql = "SELECT     AsientosContables.NumAsiento, AsientosContables.Fecha, AsientosContables.IdNumDoc, AsientosContables.NumDoc, AsientosContables.Beneficiario, " & _
                      " AsientosContables.TipoDoc, AsientosContables.Accion, AsientosContables.Anulado, AsientosContables.FechaEntrada, AsientosContables.Mayorizado, " & _
                      " AsientosContables.Periodo, AsientosContables.NumMayorizado, AsientosContables.Modulo, AsientosContables.Observaciones, " & _
                " AsientosContables.NombreUsuario, AsientosContables.CodMoneda, AsientosContables.TipoCambio, SUM(AsientoDC_DH_MAYO.DebeColon) " & _
                      " AS TotalDebe, SUM(AsientoDC_DH_MAYO.HaberColon) AS TotalHaber  " & _
" FROM         AsientosContables INNER JOIN " & _
                      " AsientoDC_DH_MAYO ON AsientosContables.NumAsiento = AsientoDC_DH_MAYO.NumAsiento " & _
" GROUP BY AsientosContables.NumAsiento, AsientosContables.Fecha, AsientosContables.IdNumDoc, AsientosContables.NumDoc, " & _
                      " AsientosContables.Beneficiario, AsientosContables.TipoDoc, AsientosContables.Accion, AsientosContables.FechaEntrada, AsientosContables.Periodo, " & _
                      " AsientosContables.NumMayorizado, AsientosContables.Modulo, AsientosContables.Observaciones, AsientosContables.NombreUsuario, " & _
                      " AsientosContables.CodMoneda, AsientosContables.TipoCambio, AsientosContables.Anulado, AsientosContables.Mayorizado HaVING AsientosContables.Anulado = 0 AND AsientosContables.NumMayorizado = " & pCodigo & " AND AsientosContables.Mayorizado =1 ORDER BY AsientosContables.NumAsiento"
            End If
            SqlConnection.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            dtsMayorizacionAsiento.AsientosContables.Clear()
            sqlCommand.Connection = SqlConnection
            sqlCommand.CommandText = sql
            sqlDataAdapter.SelectCommand = sqlCommand
            Me.sqlDataAdapter.Fill(Me.dtsMayorizacionAsiento, "AsientosContables")

        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.OKOnly)

        End Try
        If dtsMayorizacionAsiento.AsientosContables.Count > 0 Then
            B_Marca.Enabled = True
            B_Desmarcar.Enabled = True
        End If
    End Sub
#End Region

#Region "Funciones Basicas"

    Private Function VerificarBalance() As Boolean

        Try
            Dim n As Integer
            Dim Diferencia As Double
            GridView1.CloseEditor()
            GridView1.UpdateCurrentRow()


            For n = 0 To Me.dtsMayorizacionAsiento.AsientosContables.Count - 1
                With dtsMayorizacionAsiento.AsientosContables(n)
                    If dtsMayorizacionAsiento.AsientosContables.Rows(n).Item("Mayorizado") = True Then
                        Diferencia = Math.Abs(dtsMayorizacionAsiento.AsientosContables.Rows(n).Item("TotalHaber") - dtsMayorizacionAsiento.AsientosContables.Rows(n).Item("TotalDebe"))
                        If Diferencia > 0.5 Then
                            MsgBox("El asiento " & dtsMayorizacionAsiento.AsientosContables.Rows(n).Item("NumAsiento") & " no esta balencado.", MsgBoxStyle.Information, "Atención...")
                            Return False
                        End If
                    End If
                End With
            Next
            Return True
        Catch ex As Exception
            MsgBox("Error al verificar balances.", MsgBoxStyle.Information)
            Return False
        End Try

    End Function

    Private Sub Nuevo()
        Try
            Me.ToolBarRegistrar.Text = "Mayorizar"
            Me.ToolBarRegistrar.ImageIndex = "2"
            If Me.ToolBarNuevo.Text = "Nuevo" Then
                Me.ToolBarNuevo.ImageIndex = "3"
                Me.ToolBarNuevo.Text = "Cancelar"
                Me.btnEjecutar.Enabled = True
                Me.ToolBarRegistrar.Enabled = True
                Me.ToolBarImprimir.Enabled = False
                BuscarNumeroMayorizacion()
            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                Me.btnEjecutar.Enabled = False
                Me.ToolBarRegistrar.Enabled = False
                Me.ToolBarImprimir.Enabled = False
                Me.txtNumero.Text = ""
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        dtsMayorizacionAsiento.AsientosContables.Clear()
        Me.griDetalle.Refresh()
        B_Marca.Enabled = False
        B_Desmarcar.Enabled = False

        Me.ToolBarNuevo.Enabled = True
        Me.ToolBarBuscar.Enabled = True
        Me.txtNombreUsuario.Text = Me.txtUsuario.Text
    End Sub

    Private Function BuscaTabla() As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from sysobjects where name = 'MAYORIZACIONES' ", dt, Configuracion.Claves.Conexion("Contabilidad"))
        Return IIf(dt.Rows.Count > 0, True, False)
    End Function

    Public Sub LlamarFmrBuscarMayoriazazionAsiento()
        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.campo = "NumMayorizado"

        If BuscaTabla() = True Then
            busca.sqlstring = "SELECT  NumMayorizado AS [Numero de mayorizacion], Fecha FROM MAYORIZACIONES "
            busca.buscaMayo = True
            ' busca.sqlStringAdicional = " GROUP BY NumMayorizado ORDER BY NumMayorizado DESC"
        Else
            busca.sqlstring = "SELECT NumMayorizado as [Numero de mayorizacion],Max(Fecha) as Fecha FROM ASIENTOSCONTABLES where Mayorizado = 1 AND NumMayorizado <> 0 AND Anulado = 0 "
            busca.sqlStringAdicional = " GROUP BY NumMayorizado ORDER BY NumMayorizado DESC"
        End If

        busca.ShowDialog()

        If busca.codigo Is Nothing Then Exit Sub
        Me.txtNumero.Text = busca.codigo
        Buscar(busca.codigo)
        Me.ToolBarRegistrar.Enabled = True
        Me.ToolBarImprimir.Enabled = True
        Me.ToolBarNuevo.Enabled = True
        Me.btnEjecutar.Enabled = True
    End Sub

    Private Sub Buscar(ByVal pcodigo As String)
        Dim clsConexion As New Conexion
        Dim sqlConexion2 As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        'sqlConexion2.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        'sqlConexion2.Open()

        sql = "SELECT      Usuario, Fecha FROM         Mayorizacion WHERE     (NumMayorizacion = " & pcodigo & ")"

        'rstReader = clsConexion.GetRecorset(sqlConexion2, sql)
        'rstReader.Read()
        Dim dtM As New DataTable
        cFunciones.Llenar_Tabla_Generico1(sql, dtM, Configuracion.Claves.Conexion("Contabilidad"))
        If dtM.Rows.Count > 0 Then
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("Select * From Usuarios Where Id_Usuario = '" & dtM.Rows(0).Item("Usuario") & "'", dt, Configuracion.Claves.Conexion("Seguridad"))
            If dt.Rows.Count > 0 Then
                Me.txtNombreUsuario.Text = dt.Rows(0).Item("Nombre")
            End If
        Else
            Me.txtNombreUsuario.Text = "ADM"
        End If

        '  rstReader.Close()
        '   sqlConexion2.Close()
        LlenarGriDetalle(pcodigo)
        Me.ToolBarRegistrar.Text = "DesMayorizar"
        Me.ToolBarRegistrar.ImageIndex = "8"
    End Sub


    Private Sub Registrar()

        Dim n As Integer
        Dim sqlConexion2 As New System.Data.SqlClient.SqlConnection
        Dim clsConexion As New Conexion
        Dim sql As String

        GridView1.CloseEditor()
        GridView1.UpdateCurrentRow()

        AsignarNumeroMayorizacion()

        sqlConexion2.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        sqlConexion2.Open()

        For n = 0 To Me.dtsMayorizacionAsiento.AsientosContables.Count - 1
            With dtsMayorizacionAsiento.AsientosContables(n)
                If .Mayorizado = True Then
                    sql = "update ASIENTOSCONTABLES SET Mayorizado = 1, NumMayorizado=" & .NumMayorizado & " WHERE NumAsiento = '" & .NumAsiento & "'"
                    clsConexion.SlqExecute(sqlConexion2, sql)
                Else
                    sql = "update ASIENTOSCONTABLES SET Mayorizado = 0, NumMayorizado=" & .NumMayorizado & " WHERE NumAsiento = '" & .NumAsiento & "'"
                    clsConexion.SlqExecute(sqlConexion2, sql)
                End If
            End With
        Next
        If Me.ToolBarNuevo.Text.Equals("Cancelar") Then
            sql = "INSERT INTO Mayorizacion (Usuario, NumMayorizacion) VALUES     ('" & cedula & "', " & txtNumero.Text & ")"
            clsConexion.SlqExecute(sqlConexion2, sql)
        End If


        sqlConexion2.Close()
        LlenarGriDetalle(txtNumero.Text)

        ToolBarNuevo.ImageIndex = "0"
        ToolBarNuevo.Text = "Nuevo"
        ToolBarImprimir.Enabled = True
        ToolBarRegistrar.Enabled = False
        ToolBarNuevo.Enabled = True
        btnEjecutar.Enabled = False
        B_Marca.Enabled = False
        B_Desmarcar.Enabled = False
    End Sub


    Private Sub Imprimir()
        Try
            Dim rptMayorizacionAsiento As New rptMayorizacionAsiento
            Dim visor As New frmVisorReportes

            ' rptMayorizacionAsiento.RecordSelectionFormula = "{AsientosContables.Mayorizado}= true and {AsientosContables.NumMayorizado} =" & Me.txtNumero.Text
            'CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rptMayorizacionAsiento, False, Configuracion.Claves.Conexion("Contabilidad"))
            rptMayorizacionAsiento.SetDataSource(dtsMayorizacionAsiento)
            rptMayorizacionAsiento.SetParameterValue(0, Me.txtNombreUsuario.Text)
            visor.rptViewer.ReportSource = rptMayorizacionAsiento
            visor.rptViewer.Visible = True
            rptMayorizacionAsiento = Nothing
            visor.MdiParent = Me.MdiParent
            visor.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub


    Private Sub BuscarNumeroMayorizacion()
        Dim clsConexion As New Conexion
        Dim sql As String
        Dim rstReader As System.Data.SqlClient.SqlDataReader

        sql = "select max(nummayorizado) from asientoscontables WHERE Mayorizado = 1  "
        If Me.SqlConnection.State = ConnectionState.Closed Then
            Me.SqlConnection.Open()
        End If

        rstReader = clsConexion.GetRecorset(Me.SqlConnection, sql)
        If rstReader.Read() Then
            If rstReader.IsDBNull(0) Then
                Me.txtNumero.Text = 1
            Else
                Me.txtNumero.Text = rstReader(0) + 1
            End If
        Else
            Me.txtNumero.Text = 1
        End If

        Me.SqlConnection.Close()
    End Sub

#End Region

#Region "Funciones Otras"
    Private Sub AsignarNumeroMayorizacion()
        Dim n As Integer
        For n = 0 To Me.dtsMayorizacionAsiento.AsientosContables.Count - 1
            dtsMayorizacionAsiento.AsientosContables(n).NumMayorizado = Me.txtNumero.Text
            dtsMayorizacionAsiento.AsientosContables(n).NombreUsuario = Me.txtUsuario.Text
        Next
    End Sub


    Private Sub Marca_Desmarca(ByVal Estado As Boolean)
        For i As Integer = 0 To dtsMayorizacionAsiento.AsientosContables.Count - 1
            dtsMayorizacionAsiento.AsientosContables(i).Mayorizado = Estado
        Next
    End Sub
#End Region

#Region "Funciones Seguridad"

    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try

            If TxtClave.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT Id_Usuario, Nombre from Usuarios where Clave_Interna ='" & TxtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        Me.cedula = rs("Id_Usuario")
                        NombreUsuario = rs("Nombre")
                        txtUsuario.Text = rs("Nombre")
                        txtUsuario.Enabled = False
                        TxtClave.Enabled = False
                        ToolBar1.Buttons(0).Enabled = True
                        ToolBar1.Buttons(1).Enabled = True

                        Me.dtsMayorizacionAsiento.AsientosContables.NombreUsuarioColumn.DefaultValue = rs("Nombre")
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


    Private Sub TxtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtClave.TextChanged

    End Sub
End Class
