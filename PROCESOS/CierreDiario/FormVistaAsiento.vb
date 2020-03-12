Public Class FormVistaAsiento
    Inherits System.Windows.Forms.Form

    Public cuentaEnviaDiferencial As String
    Public diferencia As Double
#Region " Código generado por el Diseñador de Windows Forms "
    Dim ds As New dsIngresos
    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByRef dsIngreso As dsIngresos)
        MyBase.New()
        ds = dsIngreso.Copy
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
    Friend WithEvents griDetalle As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsIngresos1 As Contabilidad.dsIngresos
    Friend WithEvents LabelDebe As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxDebe As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHaber As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDiferencia As System.Windows.Forms.TextBox
    Friend WithEvents LabelDif As System.Windows.Forms.Label
    Friend WithEvents ButtonDif As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.griDetalle = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.DsIngresos1 = New Contabilidad.dsIngresos
        Me.LabelDebe = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBoxDebe = New System.Windows.Forms.TextBox
        Me.TextBoxHaber = New System.Windows.Forms.TextBox
        Me.TextBoxDiferencia = New System.Windows.Forms.TextBox
        Me.LabelDif = New System.Windows.Forms.Label
        Me.ButtonDif = New System.Windows.Forms.Button
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'griDetalle
        '
        Me.griDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.griDetalle.DataMember = "DetallesAsientosContable"
        Me.griDetalle.DataSource = Me.DsIngresos1
        '
        'griDetalle.EmbeddedNavigator
        '
        Me.griDetalle.EmbeddedNavigator.Name = ""
        Me.griDetalle.Location = New System.Drawing.Point(0, 0)
        Me.griDetalle.MainView = Me.GridView1
        Me.griDetalle.Name = "griDetalle"
        Me.griDetalle.Size = New System.Drawing.Size(616, 264)
        Me.griDetalle.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.griDetalle.TabIndex = 237
        Me.griDetalle.Text = "Asientos de venta"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.GridView1.GroupPanelText = "Detalle del Asiento"
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "Cuenta"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 101
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "NombreCuenta"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 266
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Debe"
        Me.GridColumn3.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "MontoDebe"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn3.SortIndex = 0
        Me.GridColumn3.SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        Me.GridColumn3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 100
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Haber"
        Me.GridColumn4.DisplayFormat.FormatString = "¢###,##0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "MontoHaber"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Options = CType((((((((DevExpress.XtraGrid.Columns.ColumnOptions.CanFiltered Or DevExpress.XtraGrid.Columns.ColumnOptions.CanMoved) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanGrouped) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanResized) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanSorted) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.CanFocused) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.ShowInCustomizationForm) _
                    Or DevExpress.XtraGrid.Columns.ColumnOptions.NonEditable), DevExpress.XtraGrid.Columns.ColumnOptions)
        Me.GridColumn4.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 116
        '
        'DsIngresos1
        '
        Me.DsIngresos1.DataSetName = "dsIngresos"
        Me.DsIngresos1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'LabelDebe
        '
        Me.LabelDebe.Location = New System.Drawing.Point(352, 264)
        Me.LabelDebe.Name = "LabelDebe"
        Me.LabelDebe.Size = New System.Drawing.Size(96, 16)
        Me.LabelDebe.TabIndex = 238
        Me.LabelDebe.Text = "Debe:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(456, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 239
        Me.Label1.Text = "- Haber:"
        '
        'TextBoxDebe
        '
        Me.TextBoxDebe.Location = New System.Drawing.Point(352, 280)
        Me.TextBoxDebe.Name = "TextBoxDebe"
        Me.TextBoxDebe.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxDebe.TabIndex = 240
        Me.TextBoxDebe.Text = "0"
        Me.TextBoxDebe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxHaber
        '
        Me.TextBoxHaber.Location = New System.Drawing.Point(464, 280)
        Me.TextBoxHaber.Name = "TextBoxHaber"
        Me.TextBoxHaber.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxHaber.TabIndex = 241
        Me.TextBoxHaber.Text = "0"
        Me.TextBoxHaber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBoxDiferencia
        '
        Me.TextBoxDiferencia.Location = New System.Drawing.Point(408, 304)
        Me.TextBoxDiferencia.Name = "TextBoxDiferencia"
        Me.TextBoxDiferencia.Size = New System.Drawing.Size(96, 20)
        Me.TextBoxDiferencia.TabIndex = 242
        Me.TextBoxDiferencia.Text = "0"
        Me.TextBoxDiferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabelDif
        '
        Me.LabelDif.Location = New System.Drawing.Point(328, 304)
        Me.LabelDif.Name = "LabelDif"
        Me.LabelDif.Size = New System.Drawing.Size(72, 23)
        Me.LabelDif.TabIndex = 243
        Me.LabelDif.Text = "Diferencia:"
        '
        'ButtonDif
        '
        Me.ButtonDif.Location = New System.Drawing.Point(512, 304)
        Me.ButtonDif.Name = "ButtonDif"
        Me.ButtonDif.Size = New System.Drawing.Size(72, 24)
        Me.ButtonDif.TabIndex = 244
        Me.ButtonDif.Text = "Diferencial"
        Me.ButtonDif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FormVistaAsiento
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(616, 333)
        Me.Controls.Add(Me.ButtonDif)
        Me.Controls.Add(Me.LabelDif)
        Me.Controls.Add(Me.TextBoxDiferencia)
        Me.Controls.Add(Me.TextBoxHaber)
        Me.Controls.Add(Me.TextBoxDebe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelDebe)
        Me.Controls.Add(Me.griDetalle)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(624, 360)
        Me.Name = "FormVistaAsiento"
        Me.Text = "Vista Asiento"
        CType(Me.griDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FormVistaAsiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        totalDebeHaber()
    End Sub
    Sub totalDebeHaber()

        Dim debe As Double = 0
        Dim haber As Double = 0

        For i As Integer = 0 To Me.DsIngresos1.DetallesAsientosContable.Count - 1
            If Me.DsIngresos1.DetallesAsientosContable(i).Debe Then
                debe += Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoDebe = Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoHaber = 0
            Else
                haber += Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoHaber = Me.DsIngresos1.DetallesAsientosContable(i).Monto
                Me.DsIngresos1.DetallesAsientosContable(i).MontoDebe = 0
            End If
        Next
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = debe
        BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = haber
        BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()

        Me.griDetalle.DataSource = Me.DsIngresos1
        Me.griDetalle.DataMember = "DetallesAsientosContable"

        Me.TextBoxDebe.Text = Format(debe, "¢ ###,##0.00")
        Me.TextBoxHaber.Text = Format(haber, "¢ ###,##0.00")
        Me.diferencia = debe - haber
        Me.TextBoxDiferencia.Text = Format(diferencia, "¢ ###,##0.00")
    End Sub

    Private Sub ButtonDif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDif.Click
        Dim cx As New Conexion
        Dim funcion As New cFunciones
        Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Buscar Cuenta Contable", Configuracion.Claves.Conexion("Contabilidad"))
        If Id Is Nothing Then Exit Sub
        cuentaEnviaDiferencial = Id
        DialogResult = DialogResult.OK
    End Sub

End Class
