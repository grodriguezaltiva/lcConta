Imports System.Data.SqlClient
Public Class FrmBuscador
    Inherits System.Windows.Forms.Form
#Region "Variables Globales"
    Dim DV As DataView 'Vista del contenedor y Busqueda 
    Public CampoFecha As String 'Nombre del campo que contiene la fecha para efectuar el Filtro
    Public CampoFiltro As String 'Nombre del campo que contiene cadena de texto para la busqueda 

    Public SQLString As String ' Sentencia SQL para el llenado del buscador.
    Public CanColums As Byte '  Columnas a Mostrar.
    Public Codigo As String 'Codigo del registro a devolver
    Public Cancelado As Boolean 'Si la operacion fue cancelada por el Usuario.

#End Region
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()
        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.SqlConnection.ConnectionString = Configuracion.Claves.Conexion("SeePos")
        'CampoFiltro = "Nombre_Cliente"
        'CampoFecha = "Fecha"
        'SQLString = "Select Id, cast(num_factura as varchar) + '-' + TIPO, Nombre_Cliente,Fecha from Ventas Order by Nombre_Cliente"
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
    Friend WithEvents TxtCodigo As ValidText.ValidText
    Friend WithEvents TextBoxBuscar As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancelar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtonAceptar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataView As System.Data.DataView
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SqlConnection As System.Data.SqlClient.SqlConnection
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SqlDataAdapter As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CkeckBuscaFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Fecha1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Fecha2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TxtCodigo = New ValidText.ValidText
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox
        Me.ButtonCancelar = New DevExpress.XtraEditors.SimpleButton
        Me.ButtonAceptar = New DevExpress.XtraEditors.SimpleButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Fecha2 = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Fecha1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataView = New System.Data.DataView
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SqlConnection = New System.Data.SqlClient.SqlConnection
        Me.SqlDataAdapter = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.CkeckBuscaFecha = New System.Windows.Forms.CheckBox
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider
        Me.Panel1.SuspendLayout()
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCodigo
        '
        Me.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCodigo.FieldReference = Nothing
        Me.TxtCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodigo.ForeColor = System.Drawing.Color.Blue
        Me.TxtCodigo.Location = New System.Drawing.Point(600, 312)
        Me.TxtCodigo.MaskEdit = ""
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.RegExPattern = ValidText.ValidText.RegularExpressionModes.Custom
        Me.TxtCodigo.Required = False
        Me.TxtCodigo.ShowErrorIcon = False
        Me.TxtCodigo.Size = New System.Drawing.Size(64, 13)
        Me.TxtCodigo.TabIndex = 81
        Me.TxtCodigo.Text = ""
        Me.TxtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtCodigo.ValidationMode = ValidText.ValidText.ValidationModes.Numbers
        Me.TxtCodigo.ValidText = "#0"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBoxBuscar.Location = New System.Drawing.Point(186, 296)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(478, 13)
        Me.TextBoxBuscar.TabIndex = 78
        Me.TextBoxBuscar.Text = ""
        '
        'ButtonCancelar
        '
        Me.ButtonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancelar.Location = New System.Drawing.Point(669, 321)
        Me.ButtonCancelar.Name = "ButtonCancelar"
        Me.ButtonCancelar.Size = New System.Drawing.Size(64, 22)
        Me.ButtonCancelar.TabIndex = 83
        Me.ButtonCancelar.Text = "Cancelar"
        '
        'ButtonAceptar
        '
        Me.ButtonAceptar.Location = New System.Drawing.Point(669, 296)
        Me.ButtonAceptar.Name = "ButtonAceptar"
        Me.ButtonAceptar.Size = New System.Drawing.Size(64, 22)
        Me.ButtonAceptar.TabIndex = 82
        Me.ButtonAceptar.Text = "Aceptar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Fecha2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Fecha1)
        Me.Panel1.Enabled = False
        Me.Panel1.Location = New System.Drawing.Point(186, 312)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(222, 24)
        Me.Panel1.TabIndex = 80
        '
        'Fecha2
        '
        Me.Fecha2.CustomFormat = "dd/MM/yyyy"
        Me.Fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha2.Location = New System.Drawing.Point(121, -1)
        Me.Fecha2.Name = "Fecha2"
        Me.Fecha2.Size = New System.Drawing.Size(88, 20)
        Me.Fecha2.TabIndex = 84
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(91, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "<-->"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fecha1
        '
        Me.Fecha1.CustomFormat = "dd/MM/yyyy"
        Me.Fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.Fecha1.Location = New System.Drawing.Point(1, -1)
        Me.Fecha1.Name = "Fecha1"
        Me.Fecha1.Size = New System.Drawing.Size(88, 20)
        Me.Fecha1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 16)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Descripción de la Busqueda..."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(531, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 12)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Código"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridControl1
        '
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 8)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(728, 280)
        Me.GridControl1.Styles.AddReplace("SelectedRow", New DevExpress.Utils.ViewStyleEx("SelectedRow", "Grid", New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold), CType((((((DevExpress.Utils.StyleOptions.StyleEnabled Or DevExpress.Utils.StyleOptions.UseBackColor) _
                            Or DevExpress.Utils.StyleOptions.UseDrawFocusRect) _
                            Or DevExpress.Utils.StyleOptions.UseFont) _
                            Or DevExpress.Utils.StyleOptions.UseForeColor) _
                            Or DevExpress.Utils.StyleOptions.UseImage), DevExpress.Utils.StyleOptions), System.Drawing.SystemColors.HotTrack, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 86
        Me.GridControl1.Text = "GridControl"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn3})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.OptionsView.ShowVertLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn4
        '
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 72
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 484
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Fecha"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 83
        '
        'SqlConnection
        '
        Me.SqlConnection.ConnectionString = "workstation id=SKULL;packet size=4096;integrated security=SSPI;data source=SEESER" & _
        "VER;persist security info=False;initial catalog=Seepos"
        '
        'SqlDataAdapter
        '
        Me.SqlDataAdapter.SelectCommand = Me.SqlSelectCommand1
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.Connection = Me.SqlConnection
        '
        'CkeckBuscaFecha
        '
        Me.CkeckBuscaFecha.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.CkeckBuscaFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CkeckBuscaFecha.ForeColor = System.Drawing.Color.White
        Me.CkeckBuscaFecha.Location = New System.Drawing.Point(8, 314)
        Me.CkeckBuscaFecha.Name = "CkeckBuscaFecha"
        Me.CkeckBuscaFecha.Size = New System.Drawing.Size(176, 14)
        Me.CkeckBuscaFecha.TabIndex = 88
        Me.CkeckBuscaFecha.Text = "Buscar entre las Fechas"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'FrmBuscador
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(746, 349)
        Me.Controls.Add(Me.CkeckBuscaFecha)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.TextBoxBuscar)
        Me.Controls.Add(Me.ButtonCancelar)
        Me.Controls.Add(Me.ButtonAceptar)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBuscador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub FrmBuscador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim DataSet As New DataSet

        '-------------------------------------------------
        If SQLString = "" Then
            MsgBox("No se ha especificado la Sentencia  SQL base para la Busqueda" & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        If CampoFiltro = "" Then
            MsgBox("No se ha especificado el nombre del campo de Busqueda por Decripción..." & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        If CampoFecha = "" Then
            MsgBox("No se ha especificado el nombre del campo Fecha para la Busqueda" & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        '-------------------------------------------------
        Try
            Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(SQLString, Me.SqlConnection)
            myCommand1.Fill(DataSet, SqlDataAdapter.DefaultSourceTableName.ToString)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        If DataSet.Tables(0).Columns.Count() < 3 Then
            MsgBox("Cantidad de columnas definidas en la consulta es insuficiente" & vbCrLf & "Error de Programación....", MsgBoxStyle.Critical, "Alerta..")
            Exit Sub
        End If
        ''''''''''''''''''''''''''''

        Me.GridColumn1.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)


        Me.GridColumn2.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

        Me.GridColumn3.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)

        Me.GridColumn4.Options = CType((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ReadOnly) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                           Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        '''''''''''''''''''''''''''''''''''''''''

        CanColums = DataSet.Tables(0).Columns.Count()
        Select Case CanColums
            Case 4 : Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn4, Me.GridColumn2, Me.GridColumn3})
                Me.GridColumn1.FieldName = DataSet.Tables(0).Columns(0).Caption()
                Me.GridColumn4.FieldName = DataSet.Tables(0).Columns(1).Caption()
                Me.GridColumn2.FieldName = DataSet.Tables(0).Columns(2).Caption()
                Me.GridColumn3.FieldName = DataSet.Tables(0).Columns(3).Caption()
            Case Else
                Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
                Me.GridColumn1.FieldName = DataSet.Tables(0).Columns(0).Caption()
                Me.GridColumn2.FieldName = DataSet.Tables(0).Columns(1).Caption()
                Me.GridColumn3.FieldName = DataSet.Tables(0).Columns(2).Caption()
                Me.GridColumn4.MinWidth = 0
                Me.GridColumn4.Width = 0
        End Select
        DV = DataSet.Tables(0).DefaultView
        DV.AllowDelete = False
        DV.AllowEdit = False
        DV.AllowNew = False
        Me.GridControl1.DataSource = DV
        Me.TxtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DV, DataSet.Tables(0).Columns(0).Caption()))
        DataSet = Nothing
        Fecha1.Value = "01/" & Date.Now.Month & "/" & Date.Now.Year
        Fecha2.Value = Now.Date
        'Me.CkeckBuscaFecha.Checked = True
    End Sub
    Private Sub BuscarDatos(ByVal Descripcion As String)
        'DV.RowFilter = CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " between " & CType(Fecha1.Value, Date) & " AND " & CType(Fecha2.Value, Date) & "", "")
        DV.RowFilter = CampoFiltro & " lIKE '%" & Descripcion & "%'" & IIf(Me.CkeckBuscaFecha.Checked = True, " AND " & CampoFecha & " >= '" & CType(Fecha1.Value, Date) & "' AND " & CampoFecha & " <= '" & DateAdd(DateInterval.Day, 1, Fecha2.Value) & "'", "")
    End Sub
    Private Sub TextBoxBuscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxBuscar.TextChanged
        BuscarDatos(Me.TextBoxBuscar.Text)
    End Sub

    Private Sub ButtonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAceptar.Click
        If GridView1.RowCount <> 0 Then
            Codigo = TxtCodigo.Text
            Cancelado = False
        Else
            Cancelado = True
        End If
        Close()
    End Sub

    Private Sub CkeckBuscaFecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CkeckBuscaFecha.CheckedChanged
        If CkeckBuscaFecha.Checked = True Then Panel1.Enabled = True Else Panel1.Enabled = False
    End Sub


    Private Sub Fecha1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fecha1.ValueChanged, Fecha2.ValueChanged
        If Me.Validate() Then BuscarDatos(Me.TextBoxBuscar.Text)

    End Sub


    Private Sub ButtonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelar.Click
        Cancelado = True
    End Sub

    Private Sub Fecha1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Fecha1.Validating
        If CType(Fecha1.Value, Date) > CType(Fecha2.Value, Date) Then
            ErrorProvider.SetError(sender, "La fecha Inicial no puede ser mayor que la fecha Final...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
            e.Cancel = False
        End If
    End Sub
    Private Sub Fecha2_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Fecha2.Validating
        If CType(Fecha2.Value, Date) < CType(Fecha1.Value, Date) Then
            ErrorProvider.SetError(sender, "La fecha Final no puede ser Menor que la fecha Inicial...")
            e.Cancel = True
        Else
            ErrorProvider.SetError(sender, "")
            e.Cancel = False
        End If

    End Sub
End Class
