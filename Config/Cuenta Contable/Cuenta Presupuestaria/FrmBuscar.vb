
Imports System.Data.SqlClient

Public Class FrmBuscar
    Inherits System.Windows.Forms.Form
    Public Shared NuevaConexion As String

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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBuscar))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.dg = New System.Windows.Forms.DataGrid
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(304, 328)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 7
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(0, 328)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 24)
        Me.btnAceptar.TabIndex = 6
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(0, 296)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(424, 23)
        Me.txtBusqueda.TabIndex = 4
        Me.txtBusqueda.Text = ""
        '
        'dg
        '
        Me.dg.AllowDrop = True
        Me.dg.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dg.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.CaptionText = "Resultado de la Búsqueda"
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dg.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.LinkColor = System.Drawing.Color.Teal
        Me.dg.Location = New System.Drawing.Point(0, 0)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.PreferredColumnWidth = 150
        Me.dg.ReadOnly = True
        Me.dg.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dg.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.Size = New System.Drawing.Size(440, 288)
        Me.dg.TabIndex = 5
        '
        'FrmBuscar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(440, 370)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dg)
        Me.Name = "FrmBuscar"
        Me.Text = "FrmBuscar"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables"
    Private cConexion As ClassConexion
    Private sqlConexion As SqlConnection
    Friend codigo As String
    Friend descrip As String
    Friend campo As String
    Friend sqlstring As String
    Public sqlStringAdicional As String

    Dim ds As DataSet
    Dim bandera As Boolean = False
#End Region

    Private Sub Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cConexion = New ClassConexion
        sqlConexion = New SqlConnection

        If NuevaConexion = "" Then
            sqlConexion = cConexion.Conectar
        Else
            sqlConexion.ConnectionString = NuevaConexion
            sqlConexion.Open()
        End If

        cargarInformacion("")
        Me.txtBusqueda.Focus()
    End Sub


    Private Sub cargarInformacion(ByVal sWhere As String)
        Try
            Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(sqlstring & sWhere & " " & sqlStringAdicional, sqlConexion)
            Dim ds As DataSet = New DataSet

            myCommand1.Fill(ds, "Informacion")

            If bandera = False Then
                Dim tbl As New DataGridTableStyle
                tbl.MappingName = "Informacion"
                Dim Column As New DataGridTextBoxColumn
                If cFunciones.Fechaemp = 1 Then
                    Column.MappingName = ds.Tables(0).Columns(1).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                    Column.Width = 80
                    Column.Alignment = HorizontalAlignment.Center
                    tbl.GridColumnStyles.Add(Column)

                    Column = New DataGridTextBoxColumn
                    Column.MappingName = ds.Tables(0).Columns(7).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(7).Caption()
                    Column.Width = 300
                    Column.Alignment = HorizontalAlignment.Center
                    tbl.GridColumnStyles.Add(Column)
                    dg.TableStyles.Add(tbl)
                    tbl = Nothing
                    bandera = True
                Else
                    Column.MappingName = ds.Tables(0).Columns(0).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(0).Caption()
                    Column.Width = 90
                    Column.ReadOnly = True
                    Column.Alignment = HorizontalAlignment.Center
                    tbl.GridColumnStyles.Add(Column)


                    Column = New DataGridTextBoxColumn
                    Column.MappingName = ds.Tables(0).Columns(1).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                    Column.Width = 300
                    Column.ReadOnly = True
                    tbl.GridColumnStyles.Add(Column)
                    dg.TableStyles.Add(tbl)
                    tbl = Nothing
                    bandera = True
                End If
            End If

            dg.DataSource = ds.Tables(0)
            ds = Nothing
            dg.AllowSorting = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click, dg.DoubleClick
        If dg.VisibleRowCount > 0 Then
            codigo = CStr(dg(dg.CurrentRowIndex, 0))
            descrip = CStr(dg(dg.CurrentRowIndex, 1))
        End If
        Close()
    End Sub


    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Close()
    End Sub


    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        If Len(txtBusqueda.Text) > 2 Then
            If sqlstring.IndexOf("where") > 0 Then
                cargarInformacion(" and " & campo & " like '%" & txtBusqueda.Text & "%'")
            Else
                cargarInformacion(" where " & campo & " like '%" & txtBusqueda.Text & "%'")
            End If

        ElseIf Trim(txtBusqueda.Text) = vbNullString Then
            cargarInformacion("")
        End If
    End Sub


    Private Sub Buscar_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        cConexion.DesConectar(sqlConexion)
        sqlConexion = Nothing
        cConexion = Nothing
    End Sub

    Private Sub dg_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles dg.Navigate

    End Sub
End Class
