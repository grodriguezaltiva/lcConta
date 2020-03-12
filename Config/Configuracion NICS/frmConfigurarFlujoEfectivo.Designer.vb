<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfigurarFlujoEfectivo
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
        Dim ColumnFilterInfo1 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo2 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim ColumnFilterInfo3 As DevExpress.XtraGrid.Columns.ColumnFilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConfigurarFlujoEfectivo))
        Me.grcConfiguracion = New DevExpress.XtraGrid.GridControl
        Me.DtsGeneraNotas1 = New Contabilidad.dtsGeneraNotas
        Me.grvConfiguracion = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.cGrupo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboGrupos = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.cCuentaContable = New DevExpress.XtraGrid.Columns.GridColumn
        Me.cboCuentaContable = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.bdsCuentaContable = New System.Windows.Forms.BindingSource(Me.components)
        Me.cDescripcion = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bdsGeneraNotas = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbConfiguracionFlujoEfectivoTableAdapter = New Contabilidad.dtsGeneraNotasTableAdapters.tbConfiguracionFlujoEfectivoTableAdapter
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.CuentaContableTableAdapter = New Contabilidad.dtsGeneraNotasTableAdapters.CuentaContableTableAdapter
        CType(Me.grcConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsGeneraNotas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grvConfiguracion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsCuentaContable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsGeneraNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grcConfiguracion
        '
        Me.grcConfiguracion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grcConfiguracion.DataMember = "tbConfiguracionFlujoEfectivo"
        Me.grcConfiguracion.DataSource = Me.DtsGeneraNotas1
        '
        '
        '
        Me.grcConfiguracion.EmbeddedNavigator.Name = ""
        Me.grcConfiguracion.Location = New System.Drawing.Point(17, 51)
        Me.grcConfiguracion.MainView = Me.grvConfiguracion
        Me.grcConfiguracion.Name = "grcConfiguracion"
        Me.grcConfiguracion.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cboGrupos, Me.cboCuentaContable})
        Me.grcConfiguracion.Size = New System.Drawing.Size(816, 275)
        Me.grcConfiguracion.TabIndex = 0
        '
        'DtsGeneraNotas1
        '
        Me.DtsGeneraNotas1.DataSetName = "dtsGeneraNotas"
        Me.DtsGeneraNotas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grvConfiguracion
        '
        Me.grvConfiguracion.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.cGrupo, Me.cCuentaContable, Me.cDescripcion})
        Me.grvConfiguracion.Name = "grvConfiguracion"
        Me.grvConfiguracion.OptionsView.ShowNewItemRow = True
        '
        'cGrupo
        '
        Me.cGrupo.Caption = "Grupo"
        Me.cGrupo.ColumnEdit = Me.cboGrupos
        Me.cGrupo.FieldName = "Grupo"
        Me.cGrupo.FilterInfo = ColumnFilterInfo1
        Me.cGrupo.Name = "cGrupo"
        Me.cGrupo.VisibleIndex = 0
        '
        'cboGrupos
        '
        Me.cboGrupos.AutoHeight = False
        Me.cboGrupos.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboGrupos.Items.AddRange(New Object() {"1-FLUJO DE EFECTIVO GENERADO POR LA OPERACION", "2-PARTIDAS QUE NO REQUIEREN USO DE EFECTIVO", "3-DISMINUCION O AUMENTO EN", "4-AUMENTO O DISMINUCION EN", "5-FLUJO DE EFECTIVO DE ACTIVIDADES DE FINANCIMIENTO", "6-FLUJO DE EFECTIVO EN ACTIVIDADES DE INVERSION"})
        Me.cboGrupos.Name = "cboGrupos"
        '
        'cCuentaContable
        '
        Me.cCuentaContable.Caption = "Cuenta Contable"
        Me.cCuentaContable.ColumnEdit = Me.cboCuentaContable
        Me.cCuentaContable.FieldName = "CuentaContable"
        Me.cCuentaContable.FilterInfo = ColumnFilterInfo2
        Me.cCuentaContable.Name = "cCuentaContable"
        Me.cCuentaContable.VisibleIndex = 1
        '
        'cboCuentaContable
        '
        Me.cboCuentaContable.AutoHeight = False
        Me.cboCuentaContable.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCuentaContable.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CuentaContable", "CuentaContable", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Descripcion", "Descripción", 20, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.[Default])})
        Me.cboCuentaContable.DataSource = Me.bdsCuentaContable
        Me.cboCuentaContable.DisplayMember = "Descripcion"
        Me.cboCuentaContable.Name = "cboCuentaContable"
        Me.cboCuentaContable.ValueMember = "CuentaContable"
        '
        'bdsCuentaContable
        '
        Me.bdsCuentaContable.DataMember = "CuentaContable"
        Me.bdsCuentaContable.DataSource = Me.DtsGeneraNotas1
        '
        'cDescripcion
        '
        Me.cDescripcion.Caption = "Descripción"
        Me.cDescripcion.FieldName = "Descripción"
        Me.cDescripcion.FilterInfo = ColumnFilterInfo3
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.VisibleIndex = 2
        '
        'bdsGeneraNotas
        '
        Me.bdsGeneraNotas.DataMember = "tbConfiguracionFlujoEfectivo"
        Me.bdsGeneraNotas.DataSource = Me.DtsGeneraNotas1
        '
        'TbConfiguracionFlujoEfectivoTableAdapter
        '
        Me.TbConfiguracionFlujoEfectivoTableAdapter.ClearBeforeFill = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(17, 1)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(74, 29)
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(97, 1)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 29)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Quitar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'CuentaContableTableAdapter
        '
        Me.CuentaContableTableAdapter.ClearBeforeFill = True
        '
        'frmConfigurarFlujoEfectivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 347)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grcConfiguracion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmConfigurarFlujoEfectivo"
        Me.Text = "Configuración Flujo Efectivo"
        CType(Me.grcConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsGeneraNotas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grvConfiguracion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsCuentaContable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsGeneraNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grcConfiguracion As DevExpress.XtraGrid.GridControl
    Friend WithEvents grvConfiguracion As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DtsGeneraNotas1 As Contabilidad.dtsGeneraNotas
    Friend WithEvents bdsGeneraNotas As System.Windows.Forms.BindingSource
    Friend WithEvents TbConfiguracionFlujoEfectivoTableAdapter As Contabilidad.dtsGeneraNotasTableAdapters.tbConfiguracionFlujoEfectivoTableAdapter
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents cGrupo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboGrupos As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cCuentaContable As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboCuentaContable As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents bdsCuentaContable As System.Windows.Forms.BindingSource
    Friend WithEvents CuentaContableTableAdapter As Contabilidad.dtsGeneraNotasTableAdapters.CuentaContableTableAdapter
    Friend WithEvents cDescripcion As DevExpress.XtraGrid.Columns.GridColumn
End Class
