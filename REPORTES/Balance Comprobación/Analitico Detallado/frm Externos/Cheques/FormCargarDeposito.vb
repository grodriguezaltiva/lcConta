Public Class FormCargarDeposito
    Inherits System.Windows.Forms.Form
    Public id_che As Integer = 0
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
    Friend WithEvents LabelCB As System.Windows.Forms.Label
    Friend WithEvents ButtonRegistrar As System.Windows.Forms.Button
    Friend WithEvents LabelCheque As System.Windows.Forms.Label
    Friend WithEvents TextBoxdeposito As System.Windows.Forms.TextBox
    Friend WithEvents LabelDep As System.Windows.Forms.Label
    Friend WithEvents TextBoxMonto As System.Windows.Forms.TextBox
    Friend WithEvents LabelMont As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents LabelMoneda As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxCuentaBanc As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.LabelCB = New System.Windows.Forms.Label
        Me.ButtonRegistrar = New System.Windows.Forms.Button
        Me.LabelCheque = New System.Windows.Forms.Label
        Me.TextBoxdeposito = New System.Windows.Forms.TextBox
        Me.LabelDep = New System.Windows.Forms.Label
        Me.TextBoxMonto = New System.Windows.Forms.TextBox
        Me.LabelMont = New System.Windows.Forms.Label
        Me.ComboBoxMoneda = New System.Windows.Forms.ComboBox
        Me.LabelMoneda = New System.Windows.Forms.Label
        Me.DateTimePickerFecha = New System.Windows.Forms.DateTimePicker
        Me.TextBoxCuentaBanc = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'LabelCB
        '
        Me.LabelCB.Location = New System.Drawing.Point(24, 32)
        Me.LabelCB.Name = "LabelCB"
        Me.LabelCB.TabIndex = 1
        Me.LabelCB.Text = "Cuenta Banc.:"
        '
        'ButtonRegistrar
        '
        Me.ButtonRegistrar.Location = New System.Drawing.Point(280, 56)
        Me.ButtonRegistrar.Name = "ButtonRegistrar"
        Me.ButtonRegistrar.Size = New System.Drawing.Size(72, 48)
        Me.ButtonRegistrar.TabIndex = 4
        Me.ButtonRegistrar.Text = "Guardar"
        '
        'LabelCheque
        '
        Me.LabelCheque.Location = New System.Drawing.Point(112, 104)
        Me.LabelCheque.Name = "LabelCheque"
        Me.LabelCheque.Size = New System.Drawing.Size(48, 16)
        Me.LabelCheque.TabIndex = 5
        '
        'TextBoxdeposito
        '
        Me.TextBoxdeposito.Location = New System.Drawing.Point(128, 8)
        Me.TextBoxdeposito.Name = "TextBoxdeposito"
        Me.TextBoxdeposito.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxdeposito.TabIndex = 2
        Me.TextBoxdeposito.Text = ""
        '
        'LabelDep
        '
        Me.LabelDep.Location = New System.Drawing.Point(24, 8)
        Me.LabelDep.Name = "LabelDep"
        Me.LabelDep.TabIndex = 0
        Me.LabelDep.Text = "Deposito:"
        '
        'TextBoxMonto
        '
        Me.TextBoxMonto.Location = New System.Drawing.Point(128, 56)
        Me.TextBoxMonto.Name = "TextBoxMonto"
        Me.TextBoxMonto.Size = New System.Drawing.Size(144, 20)
        Me.TextBoxMonto.TabIndex = 7
        Me.TextBoxMonto.Text = ""
        '
        'LabelMont
        '
        Me.LabelMont.Location = New System.Drawing.Point(24, 56)
        Me.LabelMont.Name = "LabelMont"
        Me.LabelMont.TabIndex = 6
        Me.LabelMont.Text = "Monto:"
        '
        'ComboBoxMoneda
        '
        Me.ComboBoxMoneda.Items.AddRange(New Object() {"COLON", "DOLAR"})
        Me.ComboBoxMoneda.Location = New System.Drawing.Point(128, 80)
        Me.ComboBoxMoneda.Name = "ComboBoxMoneda"
        Me.ComboBoxMoneda.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxMoneda.TabIndex = 9
        '
        'LabelMoneda
        '
        Me.LabelMoneda.Location = New System.Drawing.Point(24, 80)
        Me.LabelMoneda.Name = "LabelMoneda"
        Me.LabelMoneda.TabIndex = 8
        Me.LabelMoneda.Text = "Moneda:"
        '
        'DateTimePickerFecha
        '
        Me.DateTimePickerFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.DateTimePickerFecha.Location = New System.Drawing.Point(256, 8)
        Me.DateTimePickerFecha.Name = "DateTimePickerFecha"
        Me.DateTimePickerFecha.Size = New System.Drawing.Size(96, 20)
        Me.DateTimePickerFecha.TabIndex = 10
        '
        'TextBoxCuentaBanc
        '
        Me.TextBoxCuentaBanc.Location = New System.Drawing.Point(128, 32)
        Me.TextBoxCuentaBanc.Name = "TextBoxCuentaBanc"
        Me.TextBoxCuentaBanc.Size = New System.Drawing.Size(224, 20)
        Me.TextBoxCuentaBanc.TabIndex = 11
        Me.TextBoxCuentaBanc.Text = ""
        '
        'FormCargarDeposito
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(368, 118)
        Me.Controls.Add(Me.TextBoxCuentaBanc)
        Me.Controls.Add(Me.DateTimePickerFecha)
        Me.Controls.Add(Me.ComboBoxMoneda)
        Me.Controls.Add(Me.LabelMoneda)
        Me.Controls.Add(Me.TextBoxMonto)
        Me.Controls.Add(Me.TextBoxdeposito)
        Me.Controls.Add(Me.LabelMont)
        Me.Controls.Add(Me.LabelCheque)
        Me.Controls.Add(Me.ButtonRegistrar)
        Me.Controls.Add(Me.LabelCB)
        Me.Controls.Add(Me.LabelDep)
        Me.Name = "FormCargarDeposito"
        Me.Text = "Registrar Deposito"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ButtonRegistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRegistrar.Click
        Dim codM As Integer = 1
        If Me.ComboBoxMoneda.Text.Equals("DOLAR") Then codM = 2
        Dim cx As New Conexion
        cx.Conectar("Bancos")

        Dim resp As String = cx.SlqExecute(cx.sQlconexion, "UPDATE Cheques SET InfoDep = '" & Me.TextBoxdeposito.Text & "', InfoBanco = '" & Me.TextBoxCuentaBanc.Text & "', MontoDep = " & Me.TextBoxMonto.Text & ", MonedaDep = " & codM & ", FechaDeposito = '" & Me.DateTimePickerFecha.Value.Date & "'  WHERE Id_Cheque = " & Me.id_che)

        cx.DesConectar(cx.sQlconexion)
        If Not (resp Is Nothing) Then
            MsgBox("No se completo la operacion correctamente")
        Else
            MsgBox("Se completo la operacion correctamente " & resp)
            Me.Close()
        End If

    End Sub

    Private Sub FormCargarDeposito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * FROM Cheques WHERE Id_Cheque = " & Me.id_che, dt, GetSetting("SeeSoft", "Bancos", "Conexion"))
        Me.TextBoxCuentaBanc.Text = dt.Rows(0).Item("Cuenta_Destino")
        Me.TextBoxMonto.Text = dt.Rows(0).Item("Monto")
        If dt.Rows(0).Item("CodigoMoneda") = 2 Then
            Me.ComboBoxMoneda.Text = "DOLAR"
        Else
            Me.ComboBoxMoneda.Text = "DOLAR"
        End If

    End Sub
End Class
