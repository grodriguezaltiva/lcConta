Public Class FormRepDepositosPago
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxBancos As System.Windows.Forms.ComboBox
    Friend WithEvents TextBoxDepositos As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxMayorista As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As System.Windows.Forms.Button
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ButtonPrine As System.Windows.Forms.Button
    Friend WithEvents GridColumnNumDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFactura As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnFile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnMonto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumnCuenta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DsReporteD1 As DsReporteD
    Friend WithEvents GridColumnMontoDep As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents CheckBoxMayorista As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxNumDep As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxBanco As System.Windows.Forms.CheckBox
    Friend WithEvents GridColumnMotivo As DevExpress.XtraGrid.Columns.GridColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ButtonPrine = New System.Windows.Forms.Button
        Me.ButtonMostrar = New System.Windows.Forms.Button
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.ComboBoxMayorista = New System.Windows.Forms.ComboBox
        Me.DsReporteD1 = New DsReporteD
        Me.CheckBoxMayorista = New System.Windows.Forms.CheckBox
        Me.TextBoxDepositos = New System.Windows.Forms.TextBox
        Me.ComboBoxBancos = New System.Windows.Forms.ComboBox
        Me.CheckBoxNumDep = New System.Windows.Forms.CheckBox
        Me.CheckBoxBanco = New System.Windows.Forms.CheckBox
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumnNumDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnFDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnCuenta = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnMontoDep = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnFactura = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnFile = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnMonto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumnMotivo = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GroupBox1.SuspendLayout()
        CType(Me.DsReporteD1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ButtonPrine)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBoxMayorista)
        Me.GroupBox1.Controls.Add(Me.CheckBoxMayorista)
        Me.GroupBox1.Controls.Add(Me.TextBoxDepositos)
        Me.GroupBox1.Controls.Add(Me.ComboBoxBancos)
        Me.GroupBox1.Controls.Add(Me.CheckBoxNumDep)
        Me.GroupBox1.Controls.Add(Me.CheckBoxBanco)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 96)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parametros"
        '
        'ButtonPrine
        '
        Me.ButtonPrine.Location = New System.Drawing.Point(560, 56)
        Me.ButtonPrine.Name = "ButtonPrine"
        Me.ButtonPrine.Size = New System.Drawing.Size(64, 32)
        Me.ButtonPrine.TabIndex = 10
        Me.ButtonPrine.Text = "Imprimir"
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(560, 16)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(64, 32)
        Me.ButtonMostrar.TabIndex = 9
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker2.Location = New System.Drawing.Point(448, 48)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker2.TabIndex = 8
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePicker1.Location = New System.Drawing.Point(448, 16)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(280, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha del Deposito entre:"
        '
        'ComboBoxMayorista
        '
        Me.ComboBoxMayorista.DataSource = Me.DsReporteD1.Cliente
        Me.ComboBoxMayorista.DisplayMember = "Nombre"
        Me.ComboBoxMayorista.Location = New System.Drawing.Point(136, 64)
        Me.ComboBoxMayorista.Name = "ComboBoxMayorista"
        Me.ComboBoxMayorista.Size = New System.Drawing.Size(288, 21)
        Me.ComboBoxMayorista.TabIndex = 5
        Me.ComboBoxMayorista.ValueMember = "Id"
        '
        'DsReporteD1
        '
        Me.DsReporteD1.DataSetName = "DsReporteD"
        Me.DsReporteD1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'CheckBoxMayorista
        '
        Me.CheckBoxMayorista.Location = New System.Drawing.Point(8, 64)
        Me.CheckBoxMayorista.Name = "CheckBoxMayorista"
        Me.CheckBoxMayorista.Size = New System.Drawing.Size(104, 16)
        Me.CheckBoxMayorista.TabIndex = 4
        Me.CheckBoxMayorista.Text = "x Mayorista"
        '
        'TextBoxDepositos
        '
        Me.TextBoxDepositos.Location = New System.Drawing.Point(136, 40)
        Me.TextBoxDepositos.Name = "TextBoxDepositos"
        Me.TextBoxDepositos.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxDepositos.TabIndex = 3
        Me.TextBoxDepositos.Text = "0"
        '
        'ComboBoxBancos
        '
        Me.ComboBoxBancos.DataSource = Me.DsReporteD1.Bancos
        Me.ComboBoxBancos.DisplayMember = "Descripcion"
        Me.ComboBoxBancos.Location = New System.Drawing.Point(136, 16)
        Me.ComboBoxBancos.Name = "ComboBoxBancos"
        Me.ComboBoxBancos.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxBancos.TabIndex = 2
        Me.ComboBoxBancos.ValueMember = "Codigo_banco"
        '
        'CheckBoxNumDep
        '
        Me.CheckBoxNumDep.Location = New System.Drawing.Point(8, 40)
        Me.CheckBoxNumDep.Name = "CheckBoxNumDep"
        Me.CheckBoxNumDep.Size = New System.Drawing.Size(128, 16)
        Me.CheckBoxNumDep.TabIndex = 1
        Me.CheckBoxNumDep.Text = "x Numero Deposito"
        '
        'CheckBoxBanco
        '
        Me.CheckBoxBanco.Location = New System.Drawing.Point(8, 16)
        Me.CheckBoxBanco.Name = "CheckBoxBanco"
        Me.CheckBoxBanco.Size = New System.Drawing.Size(80, 16)
        Me.CheckBoxBanco.TabIndex = 0
        Me.CheckBoxBanco.Text = "x Banco"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataMember = "PagoDep"
        Me.GridControl1.DataSource = Me.DsReporteD1
        '
        'GridControl1.EmbeddedNavigator
        '
        Me.GridControl1.EmbeddedNavigator.Name = ""
        Me.GridControl1.Location = New System.Drawing.Point(8, 112)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(632, 360)
        Me.GridControl1.Styles.AddReplace("ColumnFilterButtonActive", New DevExpress.Utils.ViewStyleEx("ColumnFilterButtonActive", "Grid", System.Drawing.SystemColors.Control, System.Drawing.Color.Blue, System.Drawing.SystemColors.ControlLightLight, System.Drawing.Drawing2D.LinearGradientMode.Horizontal))
        Me.GridControl1.TabIndex = 1
        Me.GridControl1.Text = "GridControl1"
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumnNumDep, Me.GridColumnFDep, Me.GridColumnCuenta, Me.GridColumnMontoDep, Me.GridColumnFactura, Me.GridColumnFile, Me.GridColumnMonto, Me.GridColumnMotivo})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFilterPanel = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'GridColumnNumDep
        '
        Me.GridColumnNumDep.Caption = "#Deposito"
        Me.GridColumnNumDep.FieldName = "NumDeposito"
        Me.GridColumnNumDep.Name = "GridColumnNumDep"
        Me.GridColumnNumDep.VisibleIndex = 0
        '
        'GridColumnFDep
        '
        Me.GridColumnFDep.Caption = "F-Dep"
        Me.GridColumnFDep.FieldName = "FechaDep"
        Me.GridColumnFDep.Name = "GridColumnFDep"
        Me.GridColumnFDep.VisibleIndex = 1
        '
        'GridColumnCuenta
        '
        Me.GridColumnCuenta.Caption = "CuentaBanc"
        Me.GridColumnCuenta.FieldName = "CuentaBan"
        Me.GridColumnCuenta.Name = "GridColumnCuenta"
        Me.GridColumnCuenta.VisibleIndex = 2
        '
        'GridColumnMontoDep
        '
        Me.GridColumnMontoDep.Caption = "MontoDep"
        Me.GridColumnMontoDep.FieldName = "Monto"
        Me.GridColumnMontoDep.Name = "GridColumnMontoDep"
        Me.GridColumnMontoDep.VisibleIndex = 6
        '
        'GridColumnFactura
        '
        Me.GridColumnFactura.Caption = "#Factura"
        Me.GridColumnFactura.FieldName = "Factura"
        Me.GridColumnFactura.Name = "GridColumnFactura"
        Me.GridColumnFactura.VisibleIndex = 3
        '
        'GridColumnFile
        '
        Me.GridColumnFile.Caption = "File"
        Me.GridColumnFile.FieldName = "ID"
        Me.GridColumnFile.Name = "GridColumnFile"
        Me.GridColumnFile.VisibleIndex = 4
        '
        'GridColumnMonto
        '
        Me.GridColumnMonto.Caption = "Monto"
        Me.GridColumnMonto.FieldName = "MontoFac"
        Me.GridColumnMonto.Name = "GridColumnMonto"
        Me.GridColumnMonto.VisibleIndex = 5
        '
        'GridColumnMotivo
        '
        Me.GridColumnMotivo.Caption = "Motivo"
        Me.GridColumnMotivo.FieldName = "Concepto"
        Me.GridColumnMotivo.Name = "GridColumnMotivo"
        Me.GridColumnMotivo.VisibleIndex = 7
        '
        'FormRepDepositosPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(648, 485)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormRepDepositosPago"
        Me.Text = "Pagos en Depositos "
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DsReporteD1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click

        Dim where As String = ""

        If Me.CheckBoxBanco.Checked Then
            If where.Equals("") Then
                where = "WHERE Bancos.dbo.Cuentas_bancarias.Codigo_banco = " & Me.ComboBoxBancos.SelectedValue
            Else
                where &= " AND Bancos.dbo.Cuentas_bancarias.Codigo_banco = " & Me.ComboBoxBancos.SelectedValue

            End If
        End If

        If Me.CheckBoxMayorista.Checked Then
            If where.Equals("") Then
                where = "WHERE dbo.PagadoConTRA.Cod_Cliente = " & Me.ComboBoxMayorista.SelectedValue
            Else
                where &= " AND dbo.PagadoConTRA.Cod_Cliente = " & Me.ComboBoxMayorista.SelectedValue

            End If
        End If

        If Me.CheckBoxNumDep.Checked Then
            If where.Equals("") Then
                where = "WHERE Bancos.dbo.Deposito.NumeroDocumento = '" & Me.TextBoxDepositos.Text & "' "
            Else
                where &= " AND Bancos.dbo.Deposito.NumeroDocumento = '" & Me.TextBoxDepositos.Text & "' "

            End If

        End If
        If where.Equals("") Then
            where = "  WHERE (dbo.DateOnly(Bancos.dbo.Deposito.Fecha) >= '" & Me.DateTimePicker1.Value.Date & "' AND dbo.DateOnly(Bancos.dbo.Deposito.Fecha) <= '" & Me.DateTimePicker2.Value.Date & "')"

        Else
            where &= "  AND (dbo.DateOnly(Bancos.dbo.Deposito.Fecha) >= '" & Me.DateTimePicker1.Value.Date & "' AND dbo.DateOnly(Bancos.dbo.Deposito.Fecha) <= '" & Me.DateTimePicker2.Value.Date & "')"

        End If

        Dim sql As String = "SELECT     Bancos.dbo.Deposito.NumeroDocumento As NumDeposito, Bancos.dbo.Deposito.Fecha As FechaDep, Bancos.dbo.Deposito.Monto, Bancos.dbo.Deposito.Concepto, " & _
                        " Bancos.dbo.Deposito.Anulado, PagadoConTRA.Factura, PagadoConTRA.Id_Reservacion As ID, PagadoConTRA.Nombre_Cliente AS Mayorista, PagadoConTRA.Total As MontoFac, " & _
                        " Bancos.dbo.Cuentas_bancarias.Cuenta, Bancos.dbo.Cuentas_bancarias.Codigo_banco, Bancos.dbo.Cuentas_bancarias.NombreCuenta CuentaBan" & _
                        " FROM         Bancos.dbo.Cuentas_bancarias INNER JOIN " & _
                      " Bancos.dbo.Deposito ON Bancos.dbo.Cuentas_bancarias.Id_CuentaBancaria = Bancos.dbo.Deposito.Id_CuentaBancaria LEFT OUTER JOIN " & _
                      " PagadoConTRA ON Bancos.dbo.Deposito.NumeroDocumento = PagadoConTRA.Documento AND " & _
                      " Bancos.dbo.Deposito.Id_CuentaBancaria = PagadoConTRA.Id_CuentaBancaria"

        cFunciones.Llenar_Tabla_Generico(sql & " " & where, Me.DsReporteD1.PagoDep, Configuracion.Claves.Conexion("Hotel"))


    End Sub

    Private Sub FormRepDepositosPago_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "Select * From Bancos"

        cFunciones.Llenar_Tabla_Generico(sql, Me.DsReporteD1.Bancos, Configuracion.Claves.Conexion("Bancos"))
        sql = "Select * From Cliente"

        cFunciones.Llenar_Tabla_Generico(sql, Me.DsReporteD1.Cliente, Configuracion.Claves.Conexion("Hotel"))

    End Sub

    Private Sub ButtonPrine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrine.Click
        Dim visor As New frmVisorReportes
        Dim rtp As New CrystalReportDepPag
        rtp.SetDataSource(Me.DsReporteD1)
        rtp.SetParameterValue(0, Me.DateTimePicker1.Value.Date)
        rtp.SetParameterValue(1, Me.DateTimePicker2.Value.Date)
        visor.rptViewer.ReportSource = rtp
        visor.MdiParent = Me.MdiParent
        visor.rptViewer.Show()
        visor.Show()


    End Sub

End Class
