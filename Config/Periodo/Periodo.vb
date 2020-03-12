Imports System.Data.SqlClient
Imports Utilidades

Public Class Periodo
    Inherits System.Windows.Forms.Form

    Dim Usua As Object


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
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents TextUsuario As System.Windows.Forms.TextBox
    Friend WithEvents LabelUsuario As System.Windows.Forms.Label
    Friend WithEvents smbGuardar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CBMes As System.Windows.Forms.ComboBox
    Friend WithEvents NUDAnno As System.Windows.Forms.NumericUpDown
    Friend WithEvents LMes As System.Windows.Forms.Label
    Friend WithEvents LAnoo As System.Windows.Forms.Label
    Friend WithEvents AdapterPeriodo As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DsPeriodo1 As Contabilidad.DsPeriodo
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.smbGuardar = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.TextUsuario = New System.Windows.Forms.TextBox
        Me.LabelUsuario = New System.Windows.Forms.Label
        Me.NUDAnno = New System.Windows.Forms.NumericUpDown
        Me.CBMes = New System.Windows.Forms.ComboBox
        Me.LMes = New System.Windows.Forms.Label
        Me.LAnoo = New System.Windows.Forms.Label
        Me.AdapterPeriodo = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DsPeriodo1 = New Contabilidad.DsPeriodo
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUDAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPeriodo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'smbGuardar
        '
        Me.smbGuardar.Enabled = False
        Me.smbGuardar.Location = New System.Drawing.Point(36, 55)
        Me.smbGuardar.Name = "smbGuardar"
        Me.smbGuardar.Size = New System.Drawing.Size(98, 31)
        Me.smbGuardar.TabIndex = 1
        Me.smbGuardar.Text = "Guardar"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(158, 56)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(98, 31)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Cerrar"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;data source=OSCAR;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusBar1.Location = New System.Drawing.Point(0, 107)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel2, Me.StatusBarPanel3})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(296, 24)
        Me.StatusBar1.TabIndex = 153
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.Text = "Usuario"
        Me.StatusBarPanel2.Width = 150
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel3.Width = 130
        '
        'TextUsuario
        '
        Me.TextUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextUsuario.Location = New System.Drawing.Point(46, 114)
        Me.TextUsuario.Name = "TextUsuario"
        Me.TextUsuario.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TextUsuario.Size = New System.Drawing.Size(98, 13)
        Me.TextUsuario.TabIndex = 0
        Me.TextUsuario.Text = ""
        '
        'LabelUsuario
        '
        Me.LabelUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.LabelUsuario.Location = New System.Drawing.Point(154, 111)
        Me.LabelUsuario.Name = "LabelUsuario"
        Me.LabelUsuario.Size = New System.Drawing.Size(137, 16)
        Me.LabelUsuario.TabIndex = 155
        '
        'NUDAnno
        '
        Me.NUDAnno.Location = New System.Drawing.Point(193, 23)
        Me.NUDAnno.Maximum = New Decimal(New Integer() {2050, 0, 0, 0})
        Me.NUDAnno.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.NUDAnno.Name = "NUDAnno"
        Me.NUDAnno.Size = New System.Drawing.Size(61, 20)
        Me.NUDAnno.TabIndex = 161
        Me.NUDAnno.Value = New Decimal(New Integer() {2008, 0, 0, 0})
        '
        'CBMes
        '
        Me.CBMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SETIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CBMes.Location = New System.Drawing.Point(35, 22)
        Me.CBMes.Name = "CBMes"
        Me.CBMes.Size = New System.Drawing.Size(142, 21)
        Me.CBMes.TabIndex = 162
        '
        'LMes
        '
        Me.LMes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMes.ForeColor = System.Drawing.Color.Blue
        Me.LMes.Location = New System.Drawing.Point(36, 8)
        Me.LMes.Name = "LMes"
        Me.LMes.Size = New System.Drawing.Size(139, 16)
        Me.LMes.TabIndex = 163
        Me.LMes.Text = "Mes"
        Me.LMes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LAnoo
        '
        Me.LAnoo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LAnoo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAnoo.ForeColor = System.Drawing.Color.Blue
        Me.LAnoo.Location = New System.Drawing.Point(193, 9)
        Me.LAnoo.Name = "LAnoo"
        Me.LAnoo.Size = New System.Drawing.Size(60, 16)
        Me.LAnoo.TabIndex = 164
        Me.LAnoo.Text = "Año"
        Me.LAnoo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AdapterPeriodo
        '
        Me.AdapterPeriodo.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterPeriodo.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterPeriodo.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterPeriodo.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Periodo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id_Periodo", "Id_Periodo"), New System.Data.Common.DataColumnMapping("Mes", "Mes"), New System.Data.Common.DataColumnMapping("Anno", "Anno"), New System.Data.Common.DataColumnMapping("Estado", "Estado")})})
        Me.AdapterPeriodo.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Periodo WHERE (Id_Periodo = @Original_Id_Periodo) AND (Anno = @Origin" & _
        "al_Anno) AND (Estado = @Original_Estado) AND (Mes = @Original_Mes)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Periodo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anno", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anno", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Periodo(Mes, Anno, Estado) VALUES (@Mes, @Anno, @Estado); SELECT Id_P" & _
        "eriodo, Mes, Anno, Estado FROM Periodo WHERE (Id_Periodo = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.Int, 4, "Mes"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anno", System.Data.SqlDbType.Int, 4, "Anno"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 1, "Estado"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id_Periodo, Mes, Anno, Estado FROM Periodo"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Periodo SET Mes = @Mes, Anno = @Anno, Estado = @Estado WHERE (Id_Periodo =" & _
        " @Original_Id_Periodo) AND (Anno = @Original_Anno) AND (Estado = @Original_Estad" & _
        "o) AND (Mes = @Original_Mes); SELECT Id_Periodo, Mes, Anno, Estado FROM Periodo " & _
        "WHERE (Id_Periodo = @Id_Periodo)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mes", System.Data.SqlDbType.Int, 4, "Mes"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anno", System.Data.SqlDbType.Int, 4, "Anno"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Estado", System.Data.SqlDbType.Bit, 1, "Estado"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id_Periodo", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id_Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anno", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anno", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Estado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Estado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mes", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id_Periodo", System.Data.SqlDbType.BigInt, 8, "Id_Periodo"))
        '
        'DsPeriodo1
        '
        Me.DsPeriodo1.DataSetName = "DsPeriodo"
        Me.DsPeriodo1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'Periodo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(296, 131)
        Me.Controls.Add(Me.LAnoo)
        Me.Controls.Add(Me.LMes)
        Me.Controls.Add(Me.CBMes)
        Me.Controls.Add(Me.NUDAnno)
        Me.Controls.Add(Me.LabelUsuario)
        Me.Controls.Add(Me.TextUsuario)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.smbGuardar)
        Me.MaximizeBox = False
        Me.Name = "Periodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Periodo de Trabajo"
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUDAnno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPeriodo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub Periodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        ValoresDefecto()
        AdapterPeriodo.Fill(DsPeriodo1.Periodo)
        TextUsuario.Focus()
    End Sub


    Public Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA PERIODO
        DsPeriodo1.Periodo.MesColumn.DefaultValue = Now.Month
        DsPeriodo1.Periodo.AnnoColumn.DefaultValue = Now.Year
        DsPeriodo1.Periodo.EstadoColumn.DefaultValue = 0
    End Sub
#End Region

#Region "Botones"
    Private Sub smbGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGuardar.Click
        If MessageBox.Show("¿Desea guardar el periodo de Trabajo?", "Contabilidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Guardar()
        End If
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
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
                    smbGuardar.Enabled = False
                    TextUsuario.Focus()
                Else
                    LabelUsuario.Text = rstReader.Item("Nombre")
                    smbGuardar.Enabled = True
                    smbGuardar.Focus()
                End If
                clsConexion.DesConectar(cnnConexion)

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Contabilidad - Entrada _Usuario")
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
#End Region

#Region "Funciones"
    Public Sub Guardar()
        GuardaPeriodo()
        If Transaccion() = False Then
            MsgBox("Error Guardando el Periodo de trabajo", MsgBoxStyle.Exclamation, "Contabilidad")
        End If
        MsgBox("Periodo guardado Satisfactoriamente", MsgBoxStyle.Information, "Contabilidad")
    End Sub


    Public Sub GuardaPeriodo()
        BindingContext(DsPeriodo1, "Periodo").EndCurrentEdit()
        BindingContext(DsPeriodo1, "Periodo").AddNew()
        BindingContext(DsPeriodo1, "Periodo").Current("Mes") = CBMes.SelectedIndex
        BindingContext(DsPeriodo1, "Periodo").Current("Anno") = NUDAnno.Value
        BindingContext(DsPeriodo1, "Periodo").Current("Estado") = 1
        BindingContext(DsPeriodo1, "Periodo").EndCurrentEdit()
    End Sub


    Function Transaccion() As Boolean
        Dim Trans As SqlTransaction

        Try
            If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()

            Trans = SqlConnection1.BeginTransaction

            AdapterPeriodo.UpdateCommand.Transaction = Trans
            AdapterPeriodo.DeleteCommand.Transaction = Trans
            AdapterPeriodo.InsertCommand.Transaction = Trans

            '-----------------------------------------------------------------------------------
            'Inicia Transacción....
            AdapterPeriodo.Update(DsPeriodo1.Periodo)
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

End Class
