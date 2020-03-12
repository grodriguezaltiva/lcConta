Public Class FrmVista
    Inherits System.Windows.Forms.Form
    Dim Tabla As String = "TiposDocumentos"
    Dim Criterio As String

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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents LblId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetTiposVista1 As DataSetTiposVista
    Friend WithEvents ButAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescripcion As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmVista))
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.LblId = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.TxtDescripcion = New System.Windows.Forms.TextBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.DataSetTiposVista1 = New Contabilidad.DataSetTiposVista
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ButAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.ButCancel = New DevExpress.XtraEditors.SimpleButton
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetTiposVista1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=FALCONLAPTOP;packet size=4096;integrated security=SSPI;data source" & _
        "=falconlaptop;persist security info=False;initial catalog=Contabilidad"
        '
        'LblId
        '
        Me.LblId.Location = New System.Drawing.Point(208, 312)
        Me.LblId.Name = "LblId"
        Me.LblId.Size = New System.Drawing.Size(64, 24)
        Me.LblId.TabIndex = 82
        Me.LblId.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(133, Byte), CType(242, Byte))
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 14)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Buscar Por Descripción"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "TiposDocumentos", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM TiposDocumentos WHERE (Id = @Original_Id) AND (Descripcion = @Origina" & _
        "l_Descripcion)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO TiposDocumentos(Id, Descripcion) VALUES (@Id, @Descripcion); SELECT I" & _
        "d, Descripcion FROM TiposDocumentos WHERE (Id = @Id)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, Descripcion FROM TiposDocumentos"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE TiposDocumentos SET Id = @Id, Descripcion = @Descripcion WHERE (Id = @Orig" & _
        "inal_Id) AND (Descripcion = @Original_Descripcion); SELECT Id, Descripcion FROM " & _
        "TiposDocumentos WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 50, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.AutoSize = False
        Me.TxtDescripcion.BackColor = System.Drawing.Color.White
        Me.TxtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDescripcion.Location = New System.Drawing.Point(16, 32)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(448, 14)
        Me.TxtDescripcion.TabIndex = 81
        Me.TxtDescripcion.Text = ""
        '
        'GridControl1
        '
        Me.GridControl1.DataMember = "TiposDocumentos"
        Me.GridControl1.DataSource = Me.DataSetTiposVista1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(16, 48)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(448, 256)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 83
        Me.GridControl1.Text = "GridControl1"
        '
        'DataSetTiposVista1
        '
        Me.DataSetTiposVista1.DataSetName = "DataSetTiposVista"
        Me.DataSetTiposVista1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDescripcion})
        Me.GridView1.GroupPanelText = ""
        Me.GridView1.Name = "GridView1"
        '
        'colId
        '
        Me.colId.Caption = "Id"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.VisibleIndex = 0
        Me.colId.Width = 50
        '
        'colDescripcion
        '
        Me.colDescripcion.Caption = "Descripcion"
        Me.colDescripcion.FieldName = "Descripcion"
        Me.colDescripcion.Name = "colDescripcion"
        Me.colDescripcion.VisibleIndex = 1
        Me.colDescripcion.Width = 384
        '
        'ButAceptar
        '
        Me.ButAceptar.Image = CType(resources.GetObject("ButAceptar.Image"), System.Drawing.Image)
        Me.ButAceptar.Location = New System.Drawing.Point(296, 320)
        Me.ButAceptar.Name = "ButAceptar"
        Me.ButAceptar.Size = New System.Drawing.Size(72, 24)
        Me.ButAceptar.TabIndex = 84
        Me.ButAceptar.Text = "Aceptar"
        '
        'ButCancel
        '
        Me.ButCancel.Image = CType(resources.GetObject("ButCancel.Image"), System.Drawing.Image)
        Me.ButCancel.Location = New System.Drawing.Point(384, 320)
        Me.ButCancel.Name = "ButCancel"
        Me.ButCancel.TabIndex = 85
        Me.ButCancel.Text = "Cancelar"
        '
        'FrmVista
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(480, 358)
        Me.Controls.Add(Me.ButCancel)
        Me.Controls.Add(Me.ButAceptar)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.TxtDescripcion)
        Me.Controls.Add(Me.LblId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmVista"
        Me.Text = "FrmVista"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetTiposVista1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FrmVista_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        Me.SqlDataAdapter1.Fill(Me.DataSetTiposVista1, "TiposDocumentos")
    End Sub

    Private Sub TxtDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDescripcion.TextChanged
        If TxtDescripcion.Text <> "" Then
            Criterio = "SELECT  * FROM TiposDocumentos WHERE Descripcion LIKE '%" & TxtDescripcion.Text & "%' ORDER BY Descripcion"
            Me.SqlDataAdapter1.SelectCommand.CommandText = Criterio
            Me.DataSetTiposVista1.TiposDocumentos.Clear()
            Me.SqlDataAdapter1.Fill(Me.DataSetTiposVista1, Tabla)
        Else
            Criterio = "SELECT  * FROM TiposDocumentos ORDER BY Descripcion"
            Me.SqlDataAdapter1.SelectCommand.CommandText = Criterio
            Me.DataSetTiposVista1.TiposDocumentos.Clear()
            Me.SqlDataAdapter1.Fill(Me.DataSetTiposVista1, Tabla)
        End If
    End Sub

    Private Sub ButAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAceptar.Click
        Aceptar()
    End Sub

    Private Sub Aceptar()
        If Me.BindingContext(DataSetTiposVista1, Tabla).Count <> 0 Then
            LblId.Text = Me.BindingContext(Me.DataSetTiposVista1, Tabla).Current("Id")
            Me.Close()
        Else
            MsgBox("No se ha seleccionado ningún Registro Para Editar...", MsgBoxStyle.Exclamation, "FalconvelaSoft")
        End If
    End Sub

    Private Sub ButCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButAceptar.Click
        Me.LblId.Text = ""
        Me.Close()
    End Sub

    Private Sub ButCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButCancel.Click
        Me.LblId.Text = ""
        Me.Close()
    End Sub
End Class
