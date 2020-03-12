Imports System.data.SqlClient
Imports Utilidades
Public Class FrmTiposDocumentos
    Inherits System.Windows.Forms.Form
    Dim Tabla As String
    Dim StrSQl As String
    Dim Tools As New Utilidades
    Dim usua As Object
    Dim Buscando As Boolean ' indica si se carbo un tipo de documeto del buscador

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdaptadorTiposDoc As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataSetTiposDoc1 As DataSetTiposDoc
    Friend WithEvents DataNavigator1 As DevExpress.XtraEditors.DataNavigator
    Friend WithEvents TxtId As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmTiposDocumentos))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.DataSetTiposDoc1 = New Contabilidad.DataSetTiposDoc
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdaptadorTiposDoc = New System.Data.SqlClient.SqlDataAdapter
        Me.DataNavigator1 = New DevExpress.XtraEditors.DataNavigator
        Me.TxtId = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSetTiposDoc1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 72)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AutoSize = False
        Me.TxtDescripcion.BackColor = System.Drawing.Color.White
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTiposDoc1, "TiposDocumentos.Descripcion"))
        Me.TxtDescripcion.Enabled = False
        Me.TxtDescripcion.Location = New System.Drawing.Point(16, 40)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(392, 16)
        Me.TxtDescripcion.TabIndex = 70
        Me.TxtDescripcion.Text = ""
        '
        'DataSetTiposDoc1
        '
        Me.DataSetTiposDoc1.DataSetName = "DataSetTiposDoc"
        Me.DataSetTiposDoc1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(392, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Descripción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
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
        Me.TituloModulo.Size = New System.Drawing.Size(456, 32)
        Me.TituloModulo.TabIndex = 66
        Me.TituloModulo.Text = "Tipos de Documentos"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(100, 50)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 138)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(456, 52)
        Me.ToolBar1.TabIndex = 65
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
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESOFTELIAS;packet size=4096;integrated security=SSPI;data source" & _
        "=""."";persist security info=False;initial catalog=Contabilidad"
        '
        'AdaptadorTiposDoc
        '
        Me.AdaptadorTiposDoc.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdaptadorTiposDoc.InsertCommand = Me.SqlInsertCommand1
        Me.AdaptadorTiposDoc.SelectCommand = Me.SqlSelectCommand1
        Me.AdaptadorTiposDoc.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TiposDocumentos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.AdaptadorTiposDoc.UpdateCommand = Me.SqlUpdateCommand1
        '
        'DataNavigator1
        '
        Me.DataNavigator1.Buttons.Append.Visible = False
        Me.DataNavigator1.Buttons.CancelEdit.Visible = False
        Me.DataNavigator1.Buttons.EndEdit.Visible = False
        Me.DataNavigator1.Buttons.NextPage.Visible = False
        Me.DataNavigator1.Buttons.PrevPage.Visible = False
        Me.DataNavigator1.Buttons.Remove.Visible = False
        Me.DataNavigator1.DataMember = "TiposDocumentos"
        Me.DataNavigator1.DataSource = Me.DataSetTiposDoc1
        Me.DataNavigator1.Location = New System.Drawing.Point(328, 152)
        Me.DataNavigator1.Name = "DataNavigator1"
        Me.DataNavigator1.Size = New System.Drawing.Size(112, 24)
        Me.DataNavigator1.TabIndex = 68
        Me.DataNavigator1.Text = "DataNavigator1"
        '
        'TxtId
        '
        Me.TxtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataSetTiposDoc1, "TiposDocumentos.Id"))
        Me.TxtId.Location = New System.Drawing.Point(400, 0)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(16, 20)
        Me.TxtId.TabIndex = 69
        Me.TxtId.Text = "TextBox1"
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, Descripcion FROM TiposDocumentos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO TiposDocumentos(Descripcion) VALUES (@Descripcion); SELECT Id, Descri" & _
        "pcion FROM TiposDocumentos WHERE (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE TiposDocumentos SET Descripcion = @Descripcion WHERE (Id = @Original_Id) A" & _
        "ND (Descripcion = @Original_Descripcion); SELECT Id, Descripcion FROM TiposDocum" & _
        "entos WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM TiposDocumentos WHERE (Id = @Original_Id) AND (Descripcion = @Origina" & _
        "l_Descripcion)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'FrmTiposDocumentos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 190)
        Me.Controls.Add(Me.DataNavigator1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.TxtId)
        Me.MaximizeBox = False
        Me.Name = "FrmTiposDocumentos"
        Me.Text = "FrmTiposDocumentos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataSetTiposDoc1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmTiposDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        Tabla = "TiposDocumentos"
        Me.AdaptadorTiposDoc.Fill(Me.DataSetTiposDoc1, "TiposDocumentos")
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarRegistrar.Enabled = False
    End Sub


    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : NuevoReg()
           
            Case 1 : If PMU.Find Then Vista() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : If PMU.Update Then Registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 4 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub


            Case 5 : Me.Close()

        End Select
    End Sub

    Private Sub NuevoReg()
        If Me.ToolBarNuevo.Text = "Nuevo" Then
            Me.ToolBarNuevo.Text = "Cancelar"
            Me.ToolBarNuevo.ImageIndex = 8
            'Me.TxtId.Enabled = True
            Me.TxtDescripcion.Enabled = True
            Me.ToolBarRegistrar.Enabled = True
            Me.DataSetTiposDoc1.TiposDocumentos.Clear()
            Me.BindingContext(Me.DataSetTiposDoc1, Tabla).EndCurrentEdit()
            Me.BindingContext(Me.DataSetTiposDoc1, Tabla).AddNew()
            Me.TxtDescripcion.Focus()
        Else
            Me.ToolBarNuevo.Text = "Nuevo"
            Me.ToolBarNuevo.ImageIndex = 0
            Me.BindingContext(DataSetTiposDoc1, Tabla).CancelCurrentEdit()
            IniciarBotones()
            Me.TxtDescripcion.Focus()
        End If

        Me.Buscando = False
    End Sub

    Private Sub Vista()
        Dim Vista As New FrmVista
        Vista.ShowDialog()
        If Vista.LblId.Text <> "" Then
            StrSQl = "SELECT * FROM TiposDocumentos WHERE Id =" & Vista.LblId.Text
            Me.AdaptadorTiposDoc.SelectCommand.CommandText = StrSQl
            Me.DataSetTiposDoc1.TiposDocumentos.Clear()
            Me.AdaptadorTiposDoc.Fill(DataSetTiposDoc1, Tabla)
            Me.ToolBarRegistrar.ImageIndex = 9
            Me.ToolBarRegistrar.Text = "Editar"
            Me.ToolBarNuevo.Text = "Cancelar"
            Me.ToolBarNuevo.ImageIndex = 8
            Me.ToolBarRegistrar.Enabled = True
            Me.ToolBarEliminar.Enabled = True
            'pMe.TxtId.Enabled = False
            Me.TxtDescripcion.Enabled = True
            Me.TxtDescripcion.Focus()
            Buscando = True
        Else
            IniciarBotones()
        End If
    End Sub

    Private Sub Registrar()
        If Me.TxtDescripcion.Text <> "" Then
            Try

                If Buscando = True Then

                    Dim RegPos As Integer
                RegPos = Me.BindingContext(DataSetTiposDoc1, Tabla).Position
                    If CumpleEliminarModificar(DataSetTiposDoc1.TiposDocumentos(RegPos).Id) = False Then
                        MsgBox("No se puede modificar este tipo de documento" & vbCrLf & "porque es necesario para los asientos automáticos", MsgBoxStyle.Information)
                        Exit Sub
                    End If
                End If

                BindingContext(DataSetTiposDoc1, Tabla).EndCurrentEdit()
                Me.AdaptadorTiposDoc.Update(Me.DataSetTiposDoc1, Tabla)
                Me.DataSetTiposDoc1.TiposDocumentos.Clear()
                Me.AdaptadorTiposDoc.Fill(DataSetTiposDoc1, Tabla)
                IniciarBotones()
                MsgBox("Datos Ingresados Exitosamente", MsgBoxStyle.Information)
                Me.AdaptadorTiposDoc.Fill(Me.DataSetTiposDoc1, "TiposDocumentos")
                Me.Buscando = False
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al Intentar Guardar")
            End Try
        Else
            MsgBox("Debe Ingresar La Descripción", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Imprimir()
        'Dim InstRPTiposDoc As New RptTipos
        'InstRPTiposDoc.Show()
        Try
            Dim RpTiposDocumentos As New RpTiposDocumentos
            Dim visor As New frmVisorReportes
            visor.rptViewer.ReportSource = RpTiposDocumentos
            visor.Show()
            Me.Buscando = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub

    Private Sub IniciarBotones()
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        Me.ToolBarNuevo.Enabled = True
        Me.ToolBarBuscar.Enabled = True
        Me.ToolBarRegistrar.Enabled = False
        Me.ToolBarEliminar.Enabled = False
        Me.ToolBarImprimir.Enabled = True
        TxtDescripcion.Text = ""
        TxtDescripcion.Enabled = False
    End Sub

    Private Sub TxtId_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Not e.KeyChar.IsDigit(e.KeyChar)) Then
            If Not (e.KeyChar = Convert.ToChar(Keys.Back)) Then
                'If Me.TxtId.Text <> "" Then
                If Tools.Existe(Me.TxtDescripcion.Text) Then
                    Me.AdaptadorTiposDoc.SelectCommand.CommandText = "SELECT * FROM TiposDocumentos WHERE Id = " & Me.TxtId.Text
                    Me.AdaptadorTiposDoc.Update(DataSetTiposDoc1, Tabla)
                    Me.AdaptadorTiposDoc.Fill(DataSetTiposDoc1, Tabla)
                    'Me.TxtId.Enabled = False
                    Me.ToolBarRegistrar.Text = "Editar"
                    Me.ToolBarRegistrar.ImageIndex = 9
                    Me.ToolBarEliminar.Enabled = True
                    Me.TxtDescripcion.Focus()
                Else
                    Me.TxtDescripcion.Text = ""
                    Me.TxtDescripcion.Focus()
                End If
                'End If
            End If
        End If
    End Sub

    Private Sub Eliminar()
        Dim RegPos As Integer
        RegPos = Me.BindingContext(DataSetTiposDoc1, Tabla).Position
        If CumpleEliminarModificar(DataSetTiposDoc1.TiposDocumentos(RegPos).Id) = False Then
            MsgBox("No se puede eliminar este tipo de documento" & vbCrLf & "porque es necesario para los asientos automáticos", MsgBoxStyle.Information)
            Exit Sub
        End If

        If MessageBox.Show("¿Desea Eliminar el Registro Seleccionado?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = 6 Then


            Me.BindingContext(DataSetTiposDoc1, Tabla).RemoveAt(RegPos)
            Me.AdaptadorTiposDoc.Update(DataSetTiposDoc1.TiposDocumentos)
            Me.AdaptadorTiposDoc.Fill(DataSetTiposDoc1, Tabla)
            IniciarBotones()
            MsgBox("Datos Eliminados Con Exito", MsgBoxStyle.Information)
            Me.AdaptadorTiposDoc.Fill(Me.DataSetTiposDoc1, "TiposDocumentos")
            Me.Buscando = False
        End If
    End Sub

    Public Function CumpleEliminarModificar(ByVal pid As Integer) As Boolean
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = "SELECT Sistema from TiposDocumentos WHERE ID =" & pid

        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read = False Then Exit Function


        If rstReader("Sistema") = True Then
            CumpleEliminarModificar = False
        Else
            CumpleEliminarModificar = True
        End If

    End Function


End Class
