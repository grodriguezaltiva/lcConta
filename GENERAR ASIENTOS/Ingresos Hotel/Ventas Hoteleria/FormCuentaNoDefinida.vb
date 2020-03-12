Public Class FormCuentaNoDefinida

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
    Friend WithEvents Información As System.Windows.Forms.Label
    Friend WithEvents DataView1 As System.Data.DataView
    Friend WithEvents DsIngresos1 As Contabilidad.dsIngresos
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents ButtonListo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DsIngresos1 = New Contabilidad.dsIngresos
        Me.Información = New System.Windows.Forms.Label
        Me.DataView1 = New System.Data.DataView
        Me.ButtonListo = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid1)
        Me.GroupBox1.Controls.Add(Me.Información)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(408, 288)
        Me.GroupBox1.TabIndex = 251
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información x Contabilizar (2 Clic para elegir cuenta)"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = "PorContabilizar"
        Me.DataGrid1.DataSource = Me.DsIngresos1
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 40)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(392, 232)
        Me.DataGrid1.TabIndex = 1
        '
        'DsIngresos1
        '
        Me.DsIngresos1.DataSetName = "dsIngresos"
        Me.DsIngresos1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Información
        '
        Me.Información.Location = New System.Drawing.Point(8, 16)
        Me.Información.Name = "Información"
        Me.Información.Size = New System.Drawing.Size(392, 23)
        Me.Información.TabIndex = 0
        Me.Información.Text = "--"
        '
        'ButtonListo
        '
        Me.ButtonListo.Location = New System.Drawing.Point(16, 312)
        Me.ButtonListo.Name = "ButtonListo"
        Me.ButtonListo.Size = New System.Drawing.Size(88, 64)
        Me.ButtonListo.TabIndex = 252
        Me.ButtonListo.Text = "Listo"
        '
        'FormCuentaNoDefinida
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(416, 381)
        Me.Controls.Add(Me.ButtonListo)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormCuentaNoDefinida"
        Me.Text = "Cuenta no definida"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsIngresos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public cuenta As String = ""
    Public nombreCuenta As String = ""
    Private Sub ButtonEnviarCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        EscogeCuenta()
    End Sub
    Sub EscogeCuenta()
        Try
            Dim cx As New Conexion
            Dim funcion As New cFunciones
            Dim Id As String = funcion.BuscarDatos("Select * from CuentasContablesConMovimiento", "descripcion", "Buscar Cuenta Contable", Configuracion.Claves.Conexion("Contabilidad"))
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("SELECT CuentaContable, Descripcion FROM   CuentasContablesConMovimiento Where CuentaContable= '" & Id & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
            cuenta = dt.Rows(0).Item("CuentaContable")
            nombreCuenta = dt.Rows(0).Item("Descripcion")
            If Id Is Nothing Then
                Exit Sub
            Else

                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("CuentaAsignada") = cuenta
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("DescripcionCuenta") = nombreCuenta
                Me.BindingContext(Me.DsIngresos1, "PorContabilizar").EndCurrentEdit()

            End If

        Catch ex As Exception

        End Try
    End Sub
    Public ds As New dsIngresos

    Private Sub FormCuentaNoDefinida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 0 To Me.ds.PorContabilizar.Count - 1
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").EndCurrentEdit()
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").AddNew()
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Descripcion") = Me.ds.PorContabilizar(i).Descripcion
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Monto") = Me.ds.PorContabilizar(i).Monto
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("CuentaAsignada") = ""
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("DescripcionCuenta") = ""
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Haber") = Me.ds.PorContabilizar(i).Haber
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").Current("Debe") = Me.ds.PorContabilizar(i).Debe
            Me.BindingContext(Me.DsIngresos1, "PorContabilizar").EndCurrentEdit()
        Next

    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Me.EscogeCuenta()

    End Sub

    Private Sub ButtonListo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonListo.Click
        Me.DialogResult = DialogResult.OK

    End Sub
End Class
