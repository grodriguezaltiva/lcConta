Public Class FormCajas
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataSetCierreDiario1 As Contabilidad.DataSetCierreDiario
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ButtonAnular As System.Windows.Forms.Button
    Friend WithEvents ButtonCambiaFecha As System.Windows.Forms.Button
    Friend WithEvents ButtonVerOpciones As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonActualizar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataSetCierreDiario1 = New Contabilidad.DataSetCierreDiario
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.ButtonAnular = New System.Windows.Forms.Button
        Me.ButtonCambiaFecha = New System.Windows.Forms.Button
        Me.ButtonVerOpciones = New System.Windows.Forms.Button
        Me.ButtonActualizar = New System.Windows.Forms.Button
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetCierreDiario1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.DataMember = "CAJAS"
        Me.DataGrid1.DataSource = Me.DataSetCierreDiario1
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(568, 256)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataSetCierreDiario1
        '
        Me.DataSetCierreDiario1.DataSetName = "DataSetCierreDiario"
        Me.DataSetCierreDiario1.Locale = New System.Globalization.CultureInfo("es-MX")
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AlternatingBackColor = System.Drawing.SystemColors.Menu
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'ButtonAnular
        '
        Me.ButtonAnular.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAnular.Location = New System.Drawing.Point(8, 264)
        Me.ButtonAnular.Name = "ButtonAnular"
        Me.ButtonAnular.TabIndex = 1
        Me.ButtonAnular.Text = "Anular"
        '
        'ButtonCambiaFecha
        '
        Me.ButtonCambiaFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonCambiaFecha.Location = New System.Drawing.Point(96, 264)
        Me.ButtonCambiaFecha.Name = "ButtonCambiaFecha"
        Me.ButtonCambiaFecha.Size = New System.Drawing.Size(120, 23)
        Me.ButtonCambiaFecha.TabIndex = 2
        Me.ButtonCambiaFecha.Text = "Cambiarle la Fecha"
        '
        'ButtonVerOpciones
        '
        Me.ButtonVerOpciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonVerOpciones.Location = New System.Drawing.Point(224, 264)
        Me.ButtonVerOpciones.Name = "ButtonVerOpciones"
        Me.ButtonVerOpciones.Size = New System.Drawing.Size(144, 23)
        Me.ButtonVerOpciones.TabIndex = 3
        Me.ButtonVerOpciones.Text = "Ver Opciones de Pago"
        '
        'ButtonActualizar
        '
        Me.ButtonActualizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonActualizar.Location = New System.Drawing.Point(480, 264)
        Me.ButtonActualizar.Name = "ButtonActualizar"
        Me.ButtonActualizar.Size = New System.Drawing.Size(88, 23)
        Me.ButtonActualizar.TabIndex = 4
        Me.ButtonActualizar.Text = "Actualizar"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(384, 264)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePickerFecha.TabIndex = 5
        '
        'FormCajas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(576, 309)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Controls.Add(Me.ButtonActualizar)
        Me.Controls.Add(Me.ButtonVerOpciones)
        Me.Controls.Add(Me.ButtonCambiaFecha)
        Me.Controls.Add(Me.ButtonAnular)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "FormCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cajas Fecha:"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetCierreDiario1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public fecha As Date

    Private Sub FormCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Aperturas de Cajas ( Cajas " & fecha & " )"
        Me.DateTimePickerFecha.Value = fecha
        buscarCajas(fecha)
    End Sub
    Sub buscarCajas(ByVal Fecha_Consulta As Date)
        Dim puntoVenta As New DataTable
        cFunciones.Llenar_Tabla_Generico("SELECT BaseDatos AS BaseDatos FROM  PuntoVenta GROUP BY BaseDatos", puntoVenta, Configuracion.Claves.Conexion("Hotel"))
        Me.DataSetCierreDiario1.CAJAS.Clear()
        For i As Integer = 0 To puntoVenta.Rows.Count - 1
            cFunciones.Llenar_Tabla_SL("SELECT NApertura, Nombre AS [Nombre Usuario], Estado, Fecha, '" & puntoVenta.Rows(i).Item("BaseDatos") & "' AS BD FROM aperturacaja WHERE (Anulado = 0) AND dbo.dateOnly(Fecha) = '" & Format(Fecha_Consulta, "dd/MM/yyyy") & "' ", Me.DataSetCierreDiario1.CAJAS, Configuracion.Claves.Configuracion(puntoVenta.Rows(i).Item("BaseDatos")))
        Next
    End Sub

    Private Sub ButtonCambiaFecha_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonCambiaFecha.Click

        cambiarFecha()
        
    End Sub
    Sub cambiarFecha()
        If MsgBox("Desea cambiar la fecha de apertura de la apertura " & Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("NApertura") & " de " & Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("Nombre Usuario"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim fFecha As New FormFechaDepositos

            fFecha.Text = "Fecha a Cambiar"
            fFecha.ShowDialog()

            Dim fecha_Cambio As Date = fFecha.DateTimePicker1.Value.Date
            Dim cx As New Conexion
            cx.Conectar("SeeSoft", Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("BD"))
            cx.SlqExecute(cx.sQlconexion, "UPDATE aperturacaja Set Fecha = '" & Format(fecha_Cambio, "dd/MM/yyyy") & "' WHERE NApertura = " & Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("NApertura"))
            cx.DesConectar(cx.sQlconexion)
            actualizar()
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonActualizar.Click
        actualizar()
    End Sub
    Sub actualizar()
        Me.Text = "Aperturas de Cajas ( Cajas " & Me.DateTimePickerFecha.Value.Date & " )"
        Me.buscarCajas(DateTimePickerFecha.Value.Date)
    End Sub

    Private Sub ButtonAnular_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ButtonAnular.Click
        anular()
    End Sub
    Sub anular()
        If MsgBox("Desea cambiar a anulada la apertura, si realiza esta accion no podrá revertirla" & Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("NApertura") & " de " & Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("Nombre Usuario"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim cx As New Conexion
            cx.Conectar("SeeSoft", Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("BD"))
            cx.SlqExecute(cx.sQlconexion, "UPDATE aperturacaja Set Anulado = 1 WHERE NApertura = " & Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("NApertura"))
            cx.DesConectar(cx.sQlconexion)
            actualizar()

        End If
    End Sub

    Private Sub ButtonVerOpciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonVerOpciones.Click
        procesaOpcionesPago()

    End Sub
    Sub procesaOpcionesPago()
        Dim frmOpciones As New FormOpcionesPago
        frmOpciones.BaseDatos = Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("BD")
        frmOpciones.NApertura = Me.BindingContext(Me.DataSetCierreDiario1, "CAJAS").Current("NApertura")
        frmOpciones.ShowDialog()


    End Sub
End Class
