<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurarNotas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.A")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1", New System.Windows.Forms.TreeNode() {TreeNode3})
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Me.trvNotas = New System.Windows.Forms.TreeView
        Me.btnPrimario = New System.Windows.Forms.Button
        Me.btnSegundario = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tbRaiz = New System.Windows.Forms.TabPage
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.txtTitulo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNotaRaiz = New System.Windows.Forms.NumericUpDown
        Me.btnListoRaiz = New System.Windows.Forms.Button
        Me.txtDetalleRaiz = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbSecundaria = New System.Windows.Forms.TabPage
        Me.btnQuitarSecun = New System.Windows.Forms.Button
        Me.txtPapa = New System.Windows.Forms.Label
        Me.btnListoSecund = New System.Windows.Forms.Button
        Me.txtDetalleSecund = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNotaSecund = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.detalleCuentas = New DevExpress.XtraGrid.GridControl
        Me.dts1 = New Contabilidad.dtsGeneraNotas
        Me.grvDetalleCuentas = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboCuentaContable = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.bdsCuenta = New System.Windows.Forms.BindingSource(Me.components)
        Me.cDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bdsNotasDet = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentaContableTableAdapter = New Contabilidad.dtsGeneraNotasTableAdapters.CuentaContableTableAdapter
        Me.TbNotasSecundariaDetTableAdapter = New Contabilidad.dtsGeneraNotasTableAdapters.tbNotasSecundariaDetTableAdapter
        Me.bdsNotasRaiz = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbNotasRaizTableAdapter = New Contabilidad.dtsGeneraNotasTableAdapters.tbNotasRaizTableAdapter
        Me.TbNotasSecundariaTableAdapter = New Contabilidad.dtsGeneraNotasTableAdapters.tbNotasSecundariaTableAdapter
        Me.TabControl1.SuspendLayout()
        Me.tbRaiz.SuspendLayout()
        CType(Me.txtNotaRaiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbSecundaria.SuspendLayout()
        CType(Me.detalleCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dts1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvDetalleCuentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsCuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsNotasDet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsNotasRaiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trvNotas
        '
        Me.trvNotas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvNotas.Location = New System.Drawing.Point(2, 39)
        Me.trvNotas.Name = "trvNotas"
        TreeNode3.Name = "1-A"
        TreeNode3.Text = "1.A"
        TreeNode4.Name = "1"
        TreeNode4.Text = "1"
        Me.trvNotas.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.trvNotas.Size = New System.Drawing.Size(169, 280)
        Me.trvNotas.TabIndex = 0
        '
        'btnPrimario
        '
        Me.btnPrimario.Location = New System.Drawing.Point(2, 1)
        Me.btnPrimario.Name = "btnPrimario"
        Me.btnPrimario.Size = New System.Drawing.Size(75, 32)
        Me.btnPrimario.TabIndex = 1
        Me.btnPrimario.Text = "+ Primario"
        Me.btnPrimario.UseVisualStyleBackColor = True
        '
        'btnSegundario
        '
        Me.btnSegundario.Enabled = False
        Me.btnSegundario.Location = New System.Drawing.Point(83, 1)
        Me.btnSegundario.Name = "btnSegundario"
        Me.btnSegundario.Size = New System.Drawing.Size(88, 32)
        Me.btnSegundario.TabIndex = 2
        Me.btnSegundario.Text = "+ Secundario"
        Me.btnSegundario.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbRaiz)
        Me.TabControl1.Controls.Add(Me.tbSecundaria)
        Me.TabControl1.Location = New System.Drawing.Point(177, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(506, 315)
        Me.TabControl1.TabIndex = 3
        '
        'tbRaiz
        '
        Me.tbRaiz.Controls.Add(Me.btnQuitar)
        Me.tbRaiz.Controls.Add(Me.txtTitulo)
        Me.tbRaiz.Controls.Add(Me.Label5)
        Me.tbRaiz.Controls.Add(Me.txtNotaRaiz)
        Me.tbRaiz.Controls.Add(Me.btnListoRaiz)
        Me.tbRaiz.Controls.Add(Me.txtDetalleRaiz)
        Me.tbRaiz.Controls.Add(Me.Label2)
        Me.tbRaiz.Controls.Add(Me.Label1)
        Me.tbRaiz.Location = New System.Drawing.Point(4, 22)
        Me.tbRaiz.Name = "tbRaiz"
        Me.tbRaiz.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRaiz.Size = New System.Drawing.Size(498, 289)
        Me.tbRaiz.TabIndex = 0
        Me.tbRaiz.Text = "Nota Raiz"
        Me.tbRaiz.UseVisualStyleBackColor = True
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(187, 2)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(58, 26)
        Me.btnQuitar.TabIndex = 8
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(67, 41)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(373, 20)
        Me.txtTitulo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre"
        '
        'txtNotaRaiz
        '
        Me.txtNotaRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaRaiz.Location = New System.Drawing.Point(67, 3)
        Me.txtNotaRaiz.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtNotaRaiz.Name = "txtNotaRaiz"
        Me.txtNotaRaiz.Size = New System.Drawing.Size(50, 24)
        Me.txtNotaRaiz.TabIndex = 5
        Me.txtNotaRaiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnListoRaiz
        '
        Me.btnListoRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListoRaiz.Location = New System.Drawing.Point(123, 2)
        Me.btnListoRaiz.Name = "btnListoRaiz"
        Me.btnListoRaiz.Size = New System.Drawing.Size(58, 26)
        Me.btnListoRaiz.TabIndex = 4
        Me.btnListoRaiz.Text = "Listo"
        Me.btnListoRaiz.UseVisualStyleBackColor = True
        '
        'txtDetalleRaiz
        '
        Me.txtDetalleRaiz.Location = New System.Drawing.Point(17, 97)
        Me.txtDetalleRaiz.Multiline = True
        Me.txtDetalleRaiz.Name = "txtDetalleRaiz"
        Me.txtDetalleRaiz.Size = New System.Drawing.Size(423, 182)
        Me.txtDetalleRaiz.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Observaciones:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota:"
        '
        'tbSecundaria
        '
        Me.tbSecundaria.Controls.Add(Me.btnQuitarSecun)
        Me.tbSecundaria.Controls.Add(Me.txtPapa)
        Me.tbSecundaria.Controls.Add(Me.btnListoSecund)
        Me.tbSecundaria.Controls.Add(Me.txtDetalleSecund)
        Me.tbSecundaria.Controls.Add(Me.Label3)
        Me.tbSecundaria.Controls.Add(Me.txtNotaSecund)
        Me.tbSecundaria.Controls.Add(Me.Label4)
        Me.tbSecundaria.Controls.Add(Me.detalleCuentas)
        Me.tbSecundaria.Location = New System.Drawing.Point(4, 22)
        Me.tbSecundaria.Name = "tbSecundaria"
        Me.tbSecundaria.Padding = New System.Windows.Forms.Padding(3)
        Me.tbSecundaria.Size = New System.Drawing.Size(498, 289)
        Me.tbSecundaria.TabIndex = 1
        Me.tbSecundaria.Text = "Nota Secundaria"
        Me.tbSecundaria.UseVisualStyleBackColor = True
        '
        'btnQuitarSecun
        '
        Me.btnQuitarSecun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarSecun.Location = New System.Drawing.Point(202, 2)
        Me.btnQuitarSecun.Name = "btnQuitarSecun"
        Me.btnQuitarSecun.Size = New System.Drawing.Size(58, 26)
        Me.btnQuitarSecun.TabIndex = 11
        Me.btnQuitarSecun.Text = "Quitar"
        Me.btnQuitarSecun.UseVisualStyleBackColor = True
        '
        'txtPapa
        '
        Me.txtPapa.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPapa.Location = New System.Drawing.Point(60, 3)
        Me.txtPapa.Name = "txtPapa"
        Me.txtPapa.Size = New System.Drawing.Size(36, 22)
        Me.txtPapa.TabIndex = 10
        Me.txtPapa.Text = "0"
        '
        'btnListoSecund
        '
        Me.btnListoSecund.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListoSecund.Location = New System.Drawing.Point(138, 2)
        Me.btnListoSecund.Name = "btnListoSecund"
        Me.btnListoSecund.Size = New System.Drawing.Size(58, 26)
        Me.btnListoSecund.TabIndex = 9
        Me.btnListoSecund.Text = "Listo"
        Me.btnListoSecund.UseVisualStyleBackColor = True
        '
        'txtDetalleSecund
        '
        Me.txtDetalleSecund.Location = New System.Drawing.Point(18, 56)
        Me.txtDetalleSecund.Name = "txtDetalleSecund"
        Me.txtDetalleSecund.Size = New System.Drawing.Size(471, 20)
        Me.txtDetalleSecund.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Detalle:"
        '
        'txtNotaSecund
        '
        Me.txtNotaSecund.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNotaSecund.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotaSecund.Location = New System.Drawing.Point(99, 3)
        Me.txtNotaSecund.Name = "txtNotaSecund"
        Me.txtNotaSecund.Size = New System.Drawing.Size(33, 24)
        Me.txtNotaSecund.TabIndex = 5
        Me.txtNotaSecund.Text = "A"
        Me.txtNotaSecund.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nota:"
        '
        'detalleCuentas
        '
        Me.detalleCuentas.DataMember = "tbNotasSecundariaDet"
        Me.detalleCuentas.DataSource = Me.dts1
        '
        '
        '
        Me.detalleCuentas.EmbeddedNavigator.Name = ""
        Me.detalleCuentas.Location = New System.Drawing.Point(18, 82)
        Me.detalleCuentas.MainView = Me.grvDetalleCuentas
        Me.detalleCuentas.Name = "detalleCuentas"
        Me.detalleCuentas.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboCuentaContable})
        Me.detalleCuentas.Size = New System.Drawing.Size(471, 193)
        Me.detalleCuentas.TabIndex = 8
        '
        'dts1
        '
        Me.dts1.DataSetName = "dtsGeneraNotas"
        Me.dts1.Locale = New System.Globalization.CultureInfo("es-EC")
        Me.dts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grvDetalleCuentas
        '
        Me.grvDetalleCuentas.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cCuenta, Me.cDescripcion})
        Me.grvDetalleCuentas.Name = "grvDetalleCuentas"
        Me.grvDetalleCuentas.OptionsView.ShowGroupPanel = False
        Me.grvDetalleCuentas.OptionsView.ShowNewItemRow = True
        '
        'cCuenta
        '
        Me.cCuenta.Caption = "Cuenta"
        Me.cCuenta.ColumnEdit = Me.cboCuentaContable
        Me.cCuenta.FieldName = "CuentaContable"
        Me.cCuenta.FilterInfo = ColumnFilterInfo3
        Me.cCuenta.Name = "cCuenta"
        Me.cCuenta.VisibleIndex = 0
        '
        'cboCuentaContable
        '
        Me.cboCuentaContable.AutoHeight = False
        Me.cboCuentaContable.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCuentaContable.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaContable", "Cuenta", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Nombre", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboCuentaContable.DataSource = Me.bdsCuenta
        Me.cboCuentaContable.DisplayMember = "Descripcion"
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.NullString = "[Busque la cuenta aquí]"
        Me.cboCuentaContable.ValueMember = "CuentaContable"
        '
        'bdsCuenta
        '
        Me.bdsCuenta.DataMember = "CuentaContable"
        Me.bdsCuenta.DataSource = Me.dts1
        '
        'cDescripcion
        '
        Me.cDescripcion.Caption = "Descripción"
        Me.cDescripcion.FieldName = "Descripcion"
        Me.cDescripcion.FilterInfo = ColumnFilterInfo1
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.VisibleIndex = 1
        '
        'bdsNotasDet
        '
        Me.bdsNotasDet.DataMember = "tbNotasSecundaria"
        Me.bdsNotasDet.DataSource = Me.dts1
        '
        'CuentaContableTableAdapter
        '
        Me.CuentaContableTableAdapter.ClearBeforeFill = True
        '
        'TbNotasSecundariaDetTableAdapter
        '
        Me.TbNotasSecundariaDetTableAdapter.ClearBeforeFill = True
        '
        'bdsNotasRaiz
        '
        Me.bdsNotasRaiz.DataMember = "tbNotasRaiz"
        Me.bdsNotasRaiz.DataSource = Me.dts1
        '
        'TbNotasRaizTableAdapter
        '
        Me.TbNotasRaizTableAdapter.ClearBeforeFill = True
        '
        'TbNotasSecundariaTableAdapter
        '
        Me.TbNotasSecundariaTableAdapter.ClearBeforeFill = True
        '
        'frmConfigurarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 320)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSegundario)
        Me.Controls.Add(Me.btnPrimario)
        Me.Controls.Add(Me.trvNotas)
        Me.Name = "frmConfigurarNotas"
        Me.ShowIcon = False
        Me.Text = "Configurar Notas"
        Me.TabControl1.ResumeLayout(False)
        Me.tbRaiz.ResumeLayout(False)
        Me.tbRaiz.PerformLayout()
        CType(Me.txtNotaRaiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbSecundaria.ResumeLayout(False)
        Me.tbSecundaria.PerformLayout()
        CType(Me.detalleCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dts1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvDetalleCuentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsCuenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsNotasDet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsNotasRaiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents trvNotas As System.Windows.Forms.TreeView
    Friend WithEvents btnPrimario As System.Windows.Forms.Button
    Friend WithEvents btnSegundario As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tbRaiz As System.Windows.Forms.TabPage
    Friend WithEvents txtDetalleRaiz As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSecundaria As System.Windows.Forms.TabPage
    Friend WithEvents txtDetalleSecund As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNotaSecund As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dts1 As dtsGeneraNotas
    Friend WithEvents bdsNotasDet As System.Windows.Forms.BindingSource
    Friend WithEvents bdsCuenta As System.Windows.Forms.BindingSource
    Friend WithEvents CuentaContableTableAdapter As dtsGeneraNotasTableAdapters.CuentaContableTableAdapter
    Friend WithEvents TbNotasSecundariaDetTableAdapter As dtsGeneraNotasTableAdapters.tbNotasSecundariaDetTableAdapter
    Friend WithEvents bdsNotasRaiz As System.Windows.Forms.BindingSource
    Friend WithEvents TbNotasRaizTableAdapter As dtsGeneraNotasTableAdapters.tbNotasRaizTableAdapter
    Friend WithEvents TbNotasSecundariaTableAdapter As dtsGeneraNotasTableAdapters.tbNotasSecundariaTableAdapter
    Friend WithEvents btnListoRaiz As System.Windows.Forms.Button
    Friend WithEvents btnListoSecund As System.Windows.Forms.Button
    Friend WithEvents txtNotaRaiz As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtPapa As System.Windows.Forms.Label
    Friend WithEvents detalleCuentas As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvDetalleCuentas As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents cCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCuentaContable As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnQuitarSecun As System.Windows.Forms.Button
    Friend WithEvents cDescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
