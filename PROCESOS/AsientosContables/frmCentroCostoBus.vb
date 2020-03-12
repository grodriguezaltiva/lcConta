Public Class frmCentroCostoBus
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dtgCentros As System.Windows.Forms.DataGrid
    Friend WithEvents rdbDescripcion As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCodigo As System.Windows.Forms.RadioButton
    Friend WithEvents DatasetGasto1 As DatasetGasto
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents grbFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents rdbEvento As System.Windows.Forms.RadioButton
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtCentro As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtFiltro = New System.Windows.Forms.TextBox
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dtgCentros = New System.Windows.Forms.DataGrid
        Me.DataView1 = New System.Data.DataView
        Me.DatasetGasto1 = New Contabilidad.DatasetGasto
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.rdbDescripcion = New System.Windows.Forms.RadioButton
        Me.rdbCodigo = New System.Windows.Forms.RadioButton
        Me.grbFiltro = New System.Windows.Forms.GroupBox
        Me.rdbEvento = New System.Windows.Forms.RadioButton
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtCentro = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        CType(Me.dtgCentros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetGasto1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFiltro.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFiltro
        '
        Me.txtFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFiltro.Location = New System.Drawing.Point(8, 16)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(412, 20)
        Me.txtFiltro.TabIndex = 0
        Me.txtFiltro.Text = ""
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Location = New System.Drawing.Point(424, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(56, 23)
        Me.btnAgregar.TabIndex = 3
        Me.btnAgregar.Text = "Buscar"
        '
        'dtgCentros
        '
        Me.dtgCentros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtgCentros.DataMember = ""
        Me.dtgCentros.DataSource = Me.DataView1
        Me.dtgCentros.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtgCentros.Location = New System.Drawing.Point(8, 80)
        Me.dtgCentros.Name = "dtgCentros"
        Me.dtgCentros.PreferredColumnWidth = 150
        Me.dtgCentros.RowHeaderWidth = 15
        Me.dtgCentros.Size = New System.Drawing.Size(488, 232)
        Me.dtgCentros.TabIndex = 1
        Me.dtgCentros.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataView1
        '
        Me.DataView1.AllowDelete = False
        Me.DataView1.AllowEdit = False
        Me.DataView1.AllowNew = False
        Me.DataView1.Table = Me.DatasetGasto1.CentroCosto
        '
        'DatasetGasto1
        '
        Me.DatasetGasto1.DataSetName = "DatasetGasto"
        Me.DatasetGasto1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dtgCentros
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle1.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        Me.DataGridTableStyle1.PreferredColumnWidth = 150
        Me.DataGridTableStyle1.RowHeaderWidth = 150
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'rdbDescripcion
        '
        Me.rdbDescripcion.Checked = True
        Me.rdbDescripcion.Location = New System.Drawing.Point(8, 40)
        Me.rdbDescripcion.Name = "rdbDescripcion"
        Me.rdbDescripcion.TabIndex = 1
        Me.rdbDescripcion.TabStop = True
        Me.rdbDescripcion.Text = "Descripción"
        '
        'rdbCodigo
        '
        Me.rdbCodigo.Location = New System.Drawing.Point(112, 40)
        Me.rdbCodigo.Name = "rdbCodigo"
        Me.rdbCodigo.TabIndex = 2
        Me.rdbCodigo.Text = "Código"
        '
        'grbFiltro
        '
        Me.grbFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbFiltro.Controls.Add(Me.txtCodigo)
        Me.grbFiltro.Controls.Add(Me.rdbEvento)
        Me.grbFiltro.Controls.Add(Me.txtFiltro)
        Me.grbFiltro.Controls.Add(Me.btnAgregar)
        Me.grbFiltro.Controls.Add(Me.rdbDescripcion)
        Me.grbFiltro.Controls.Add(Me.rdbCodigo)
        Me.grbFiltro.Location = New System.Drawing.Point(8, 0)
        Me.grbFiltro.Name = "grbFiltro"
        Me.grbFiltro.Size = New System.Drawing.Size(488, 72)
        Me.grbFiltro.TabIndex = 0
        Me.grbFiltro.TabStop = False
        Me.grbFiltro.Text = "Filtro"
        '
        'rdbEvento
        '
        Me.rdbEvento.Enabled = False
        Me.rdbEvento.Location = New System.Drawing.Point(216, 40)
        Me.rdbEvento.Name = "rdbEvento"
        Me.rdbEvento.TabIndex = 4
        Me.rdbEvento.Text = "Eventos"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(8, 320)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(88, 320)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        '
        'txtID
        '
        Me.txtID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "Id"))
        Me.txtID.Location = New System.Drawing.Point(208, 320)
        Me.txtID.Name = "txtID"
        Me.txtID.TabIndex = 4
        Me.txtID.Text = "0"
        '
        'txtCentro
        '
        Me.txtCentro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCentro.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "Nombre"))
        Me.txtCentro.Location = New System.Drawing.Point(312, 320)
        Me.txtCentro.Name = "txtCentro"
        Me.txtCentro.ReadOnly = True
        Me.txtCentro.Size = New System.Drawing.Size(168, 20)
        Me.txtCentro.TabIndex = 5
        Me.txtCentro.Text = ""
        '
        'txtCodigo
        '
        Me.txtCodigo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DataView1, "Codigo"))
        Me.txtCodigo.Location = New System.Drawing.Point(368, 48)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(112, 20)
        Me.txtCodigo.TabIndex = 5
        Me.txtCodigo.Text = ""
        '
        'frmCentroCostoBus
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(504, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCentro)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grbFiltro)
        Me.Controls.Add(Me.dtgCentros)
        Me.Name = "frmCentroCostoBus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Centro Costo..."
        CType(Me.dtgCentros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetGasto1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFiltro.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCentroCosto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        sp_Filtro()
    End Sub
    Sub sp_Filtro()
        Dim where As String = ""
        If Me.rdbDescripcion.Checked Then
            where = " WHERE Nombre LIKE '%" & Me.txtFiltro.Text & "%'"

        End If
        If Me.rdbCodigo.Checked Then
            where = " WHERE Codigo LIKE '%" & Me.txtFiltro.Text & "%'"

        End If

        cFunciones.Llenar_Tabla_Generico("SELECT    Id, Codigo, Nombre, Observaciones " & _
        " FROM  CentroCosto " & where, Me.DatasetGasto1.CentroCosto, Configuracion.Claves.Conexion("Contabilidad"))

    End Sub

    Private Sub rdbCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCodigo.CheckedChanged, rdbDescripcion.CheckedChanged
        txtFiltro.Focus()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Me.sp_Filtro()

    End Sub

    Private Sub rdbDescripcion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDescripcion.CheckedChanged

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Me.DatasetGasto1.CentroCosto.Count > 0 Then
            DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        DialogResult = DialogResult.Cancel

    End Sub

    Private Sub txtFiltro_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFiltro.TextChanged
        sp_Filtro()

    End Sub

    Private Sub txtFiltro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFiltro.KeyDown

    End Sub
End Class
