Imports Utilidades
Imports System.Data.SqlClient

Public Class FrmCentroCosto
    Inherits FrmPlantilla   'System.Windows.Forms.Form
    Private sqlConexion As SqlConnection
    Public CConexion As New Conexion
    Dim usua As Usuario_Logeado
    'Dim ii As Integer
    Dim NuevaConexion As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        usua = Usuario_Parametro

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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodigo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExistenciaBodega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TextBoxNombre As System.Windows.Forms.TextBox
    Friend WithEvents LNombre As System.Windows.Forms.Label
    Friend WithEvents LObservaciones As System.Windows.Forms.Label
    Friend WithEvents TextBoxObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents LCodigo As System.Windows.Forms.Label
    Friend WithEvents TextBoxCodigo As System.Windows.Forms.TextBox
    Friend WithEvents AdapterCentroCosto As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DsCentroCosto1 As Contabilidad.DsCentroCosto
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmCentroCosto))
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colCodigo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colExistenciaBodega = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TextBoxNombre = New System.Windows.Forms.TextBox
        Me.DsCentroCosto1 = New Contabilidad.DsCentroCosto
        Me.LNombre = New System.Windows.Forms.Label
        Me.LObservaciones = New System.Windows.Forms.Label
        Me.TextBoxObservaciones = New System.Windows.Forms.TextBox
        Me.LCodigo = New System.Windows.Forms.Label
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox
        Me.AdapterCentroCosto = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsCentroCosto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(490, 24)
        Me.TituloModulo.Text = "Centro de Costo"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 140)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(490, 52)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodigo, Me.colDescripcion, Me.colExistenciaBodega})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'colCodigo
        '
        Me.colCodigo.Caption = "Codigo"
        Me.colCodigo.FieldName = "Codigo"
        Me.colCodigo.Name = "colCodigo"
        Me.colCodigo.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colCodigo.VisibleIndex = 0
        Me.colCodigo.Width = 73
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 356
        '
        'colExistenciaBodega
        '
        Me.colExistenciaBodega.Caption = "Existencia"
        Me.colExistenciaBodega.FieldName = "Existencia"
        Me.colExistenciaBodega.Name = "colExistenciaBodega"
        Me.colExistenciaBodega.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.colExistenciaBodega.VisibleIndex = 2
        Me.colExistenciaBodega.Width = 101
        '
        'TextBoxNombre
        '
        Me.TextBoxNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxNombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCentroCosto1, "CentroCosto.Nombre"))
        Me.TextBoxNombre.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.TextBoxNombre.Location = New System.Drawing.Point(10, 80)
        Me.TextBoxNombre.Name = "TextBoxNombre"
        Me.TextBoxNombre.Size = New System.Drawing.Size(486, 13)
        Me.TextBoxNombre.TabIndex = 1
        Me.TextBoxNombre.Text = ""
        '
        'DsCentroCosto1
        '
        Me.DsCentroCosto1.DataSetName = "DsCentroCosto"
        Me.DsCentroCosto1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'LNombre
        '
        Me.LNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNombre.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombre.ForeColor = System.Drawing.Color.Blue
        Me.LNombre.Location = New System.Drawing.Point(10, 64)
        Me.LNombre.Name = "LNombre"
        Me.LNombre.Size = New System.Drawing.Size(486, 16)
        Me.LNombre.TabIndex = 90
        Me.LNombre.Text = "Nombre"
        '
        'LObservaciones
        '
        Me.LObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LObservaciones.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LObservaciones.ForeColor = System.Drawing.Color.Blue
        Me.LObservaciones.Location = New System.Drawing.Point(8, 104)
        Me.LObservaciones.Name = "LObservaciones"
        Me.LObservaciones.Size = New System.Drawing.Size(488, 16)
        Me.LObservaciones.TabIndex = 95
        Me.LObservaciones.Text = "Observaciones"
        '
        'TextBoxObservaciones
        '
        Me.TextBoxObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxObservaciones.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCentroCosto1, "CentroCosto.Observaciones"))
        Me.TextBoxObservaciones.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.TextBoxObservaciones.Location = New System.Drawing.Point(8, 120)
        Me.TextBoxObservaciones.Name = "TextBoxObservaciones"
        Me.TextBoxObservaciones.Size = New System.Drawing.Size(480, 13)
        Me.TextBoxObservaciones.TabIndex = 94
        Me.TextBoxObservaciones.Text = ""
        '
        'LCodigo
        '
        Me.LCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LCodigo.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.LCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCodigo.ForeColor = System.Drawing.Color.Blue
        Me.LCodigo.Location = New System.Drawing.Point(10, 32)
        Me.LCodigo.Name = "LCodigo"
        Me.LCodigo.Size = New System.Drawing.Size(64, 16)
        Me.LCodigo.TabIndex = 97
        Me.LCodigo.Text = "Código"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsCentroCosto1, "CentroCosto.Codigo"))
        Me.TextBoxCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(0, Byte), CType(192, Byte))
        Me.TextBoxCodigo.Location = New System.Drawing.Point(88, 35)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.Size = New System.Drawing.Size(144, 13)
        Me.TextBoxCodigo.TabIndex = 0
        Me.TextBoxCodigo.Text = ""
        '
        'AdapterCentroCosto
        '
        Me.AdapterCentroCosto.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterCentroCosto.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterCentroCosto.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterCentroCosto.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CentroCosto", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Codigo", "Codigo"), New System.Data.Common.DataColumnMapping("Nombre", "Nombre"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones")})})
        Me.AdapterCentroCosto.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM CentroCosto WHERE (Id = @Original_Id) AND (Codigo = @Original_Codigo)" & _
        " AND (Nombre = @Original_Nombre) AND (Observaciones = @Original_Observaciones)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=OSCAR;packet size=4096;integrated security=SSPI;initial catalog=Co" & _
        "ntabilidad;persist security info=False"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CentroCosto(Codigo, Nombre, Observaciones) VALUES (@Codigo, @Nombre, " & _
        "@Observaciones); SELECT Id, Codigo, Nombre, Observaciones FROM CentroCosto WHERE" & _
        " (Id = @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, Codigo, Nombre, Observaciones FROM CentroCosto"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE CentroCosto SET Codigo = @Codigo, Nombre = @Nombre, Observaciones = @Obser" & _
        "vaciones WHERE (Id = @Original_Id) AND (Codigo = @Original_Codigo) AND (Nombre =" & _
        " @Original_Nombre) AND (Observaciones = @Original_Observaciones); SELECT Id, Cod" & _
        "igo, Nombre, Observaciones FROM CentroCosto WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Codigo", System.Data.SqlDbType.VarChar, 50, "Codigo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nombre", System.Data.SqlDbType.VarChar, 150, "Nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 250, "Observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Codigo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Codigo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nombre", System.Data.SqlDbType.VarChar, 150, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'FrmCentroCosto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(221, Byte), CType(221, Byte), CType(221, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(490, 192)
        Me.Controls.Add(Me.TextBoxCodigo)
        Me.Controls.Add(Me.LCodigo)
        Me.Controls.Add(Me.LObservaciones)
        Me.Controls.Add(Me.TextBoxObservaciones)
        Me.Controls.Add(Me.LNombre)
        Me.Controls.Add(Me.TextBoxNombre)
        Me.Name = "FrmCentroCosto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Centro de Costo"
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.TextBoxNombre, 0)
        Me.Controls.SetChildIndex(Me.LNombre, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TextBoxObservaciones, 0)
        Me.Controls.SetChildIndex(Me.LObservaciones, 0)
        Me.Controls.SetChildIndex(Me.LCodigo, 0)
        Me.Controls.SetChildIndex(Me.TextBoxCodigo, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsCentroCosto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmCentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CONFIGURACION.Claves.Conexion("Contabilidad"), NuevaConexion)
            Me.AdapterCentroCosto.Fill(Me.DsCentroCosto1.CentroCosto)
            Limpia()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try
            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0 : NuevaEntrada()
                Case 1 : If PMU.Find Then Buscar() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 2
                    If PMU.Update Then
                        ActualizarCentroCosto()
                        If MsgBox("Desea agregar un nuevo Centro de Costo...", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then NuevaEntrada() Else Limpia()
                    Else
                        MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 3
                    If PMU.Delete Then
                        EliminaCentroCosto()
                    Else
                        MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If
                Case 4
                    Try
                        If Me.BindingContext(Me.DsCentroCosto1.CentroCosto).Count > 0 Then
                            If PMU.Print Then
                                Dim Visor As New frmVisorReportes
                                Dim ReporteCentro As New Reporte_CentroCosto
                                CrystalReportsConexion2.LoadReportViewer2(Visor.rptViewer, ReporteCentro, , Me.SqlConnection1.ConnectionString)
                                Visor.rptViewer.ReportSource = ReporteCentro
                                Visor.Left = (Screen.PrimaryScreen.WorkingArea.Width - Visor.Width) \ 2
                                Visor.Top = (Screen.PrimaryScreen.WorkingArea.Height - Visor.Height) \ 2
                                Visor.MdiParent = Me.ParentForm
                                Visor.Show()

                            Else
                                MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                            End If
                        Else
                            MsgBox("No hay Centros de Costos registrados...", MsgBoxStyle.Information)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Critical, "")
                    End Try
                Case 6 : Me.Cerrar()
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Defecto()
        Me.DsCentroCosto1.CentroCosto.CodigoColumn.DefaultValue = ""
        Me.DsCentroCosto1.CentroCosto.NombreColumn.DefaultValue = ""
        Me.DsCentroCosto1.CentroCosto.ObservacionesColumn.DefaultValue = ""
    End Sub

    Private Sub NuevaEntrada()
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            Me.TextBoxCodigo.Enabled = True
            Me.TextBoxNombre.Enabled = True
            Me.TextBoxObservaciones.Enabled = True
        Else
            Me.TextBoxCodigo.Enabled = False
            Me.TextBoxNombre.Enabled = False
            Me.TextBoxObservaciones.Enabled = False
        End If
        Me.NuevosDatos(Me.DsCentroCosto1, Me.DsCentroCosto1.CentroCosto.ToString)
        Me.TextBoxCodigo.Focus()
    End Sub

    Private Sub Limpia()
        Defecto()
        Me.TextBoxCodigo.Enabled = False
        Me.TextBoxNombre.Enabled = False
        Me.TextBoxObservaciones.Enabled = False
        Me.TextBoxCodigo.Focus()
    End Sub

    Function ActualizarCentroCosto()
        Dim nombre As String = Me.TextBoxNombre.Text
        Dim codigo As String = Me.TextBoxCodigo.Text
        Dim Observaciones As String = Me.TextBoxObservaciones.Text
        Dim actualizado As Integer

        If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
        Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
        Try
            'Finaliza la edición
            Me.AdapterCentroCosto.UpdateCommand.Transaction = Trans
            Me.AdapterCentroCosto.InsertCommand.Transaction = Trans
            Me.AdapterCentroCosto.DeleteCommand.Transaction = Trans

            Me.BindingContext(Me.DsCentroCosto1, "CentroCosto").EndCurrentEdit()
            Me.AdapterCentroCosto.Update(Me.DsCentroCosto1, "CentroCosto")

            Trans.Commit()
            Me.DsCentroCosto1.AcceptChanges()

            ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            MsgBox("Datos Guardados Satisfactoriamente", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.ToString)
            Trans.Rollback()
        End Try

    End Function

    Private Sub EliminaCentroCosto()
        If Me.BindingContext(Me.DsCentroCosto1, "CentroCosto").Count > 0 Then
            Me.EliminarDatos(Me.AdapterCentroCosto, Me.DsCentroCosto1, Me.DsCentroCosto1.CentroCosto.ToString)
        End If
    End Sub

    Private Sub Buscar()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            If Me.BindingContext(Me.DsCentroCosto1, "CentroCosto").Count > 0 Then
                Me.BindingContext(Me.DsCentroCosto1, "CentroCosto").CancelCurrentEdit()
                ToolBar1.Buttons(0).Text = "Nuevo"
                ToolBar1.Buttons(0).ImageIndex = 0
            End If

            valor = Fx.BuscarDatos("Select Codigo, Nombre from CentroCosto", "Nombre", "Buscar Centro de Costo...", Me.SqlConnection1.ConnectionString)

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.DsCentroCosto1.CentroCosto.DefaultView
                vista.Sort = "Codigo"
                pos = vista.Find(valor)
                Me.BindingContext(Me.DsCentroCosto1, "CentroCosto").Position = pos
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

#Region "KeyDown"
    Private Sub TextBoxCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBoxNombre.Focus()
        End If
    End Sub

    Private Sub TextBoxNombre_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBoxObservaciones.Focus()
        End If
    End Sub
#End Region

End Class
