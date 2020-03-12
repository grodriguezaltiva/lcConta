Imports Utilidades
Imports System.Data.SqlClient
Public Class frmComparativoCuenta
    Inherits FrmPlantilla

    Dim usua As Object
    Dim CedulaUsuario As String
    Dim NombreUsuario As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCantidadTiempo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCodigo As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents radMes As System.Windows.Forms.RadioButton
    Friend WithEvents radAno As System.Windows.Forms.RadioButton
    Friend WithEvents radMesAno As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmComparativoCuenta))
        Me.txtCodigo = New DevExpress.XtraEditors.TextEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.radMes = New System.Windows.Forms.RadioButton
        Me.radAno = New System.Windows.Forms.RadioButton
        Me.radMesAno = New System.Windows.Forms.RadioButton
        Me.txtCantidadTiempo = New DevExpress.XtraEditors.TextEdit
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCantidadTiempo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(546, 32)
        Me.TituloModulo.Text = "      Comparativo de cuentas"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.Visible = False
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 164)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(546, 52)
        Me.ToolBar1.Visible = False
        '
        'txtCodigo
        '
        Me.txtCodigo.EditValue = ""
        Me.txtCodigo.Location = New System.Drawing.Point(104, 40)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(128, 19)
        Me.txtCodigo.TabIndex = 71
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(16, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cuenta contable:"
        '
        'radMes
        '
        Me.radMes.BackColor = System.Drawing.Color.Transparent
        Me.radMes.Checked = True
        Me.radMes.Location = New System.Drawing.Point(32, 16)
        Me.radMes.Name = "radMes"
        Me.radMes.Size = New System.Drawing.Size(56, 24)
        Me.radMes.TabIndex = 74
        Me.radMes.TabStop = True
        Me.radMes.Text = "Meses"
        '
        'radAno
        '
        Me.radAno.BackColor = System.Drawing.Color.Transparent
        Me.radAno.Location = New System.Drawing.Point(160, 16)
        Me.radAno.Name = "radAno"
        Me.radAno.Size = New System.Drawing.Size(48, 24)
        Me.radAno.TabIndex = 75
        Me.radAno.Text = "Años"
        '
        'radMesAno
        '
        Me.radMesAno.BackColor = System.Drawing.Color.Transparent
        Me.radMesAno.Location = New System.Drawing.Point(256, 16)
        Me.radMesAno.Name = "radMesAno"
        Me.radMesAno.Size = New System.Drawing.Size(88, 24)
        Me.radMesAno.TabIndex = 76
        Me.radMesAno.Text = "Mes por año"
        '
        'txtCantidadTiempo
        '
        Me.txtCantidadTiempo.EditValue = ""
        Me.txtCantidadTiempo.Location = New System.Drawing.Point(168, 48)
        Me.txtCantidadTiempo.Name = "txtCantidadTiempo"
        '
        'txtCantidadTiempo.Properties
        '
        Me.txtCantidadTiempo.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidadTiempo.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCantidadTiempo.Size = New System.Drawing.Size(128, 19)
        Me.txtCantidadTiempo.TabIndex = 77
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radMes)
        Me.GroupBox1.Controls.Add(Me.radAno)
        Me.GroupBox1.Controls.Add(Me.radMesAno)
        Me.GroupBox1.Controls.Add(Me.txtCantidadTiempo)
        Me.GroupBox1.Location = New System.Drawing.Point(88, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 72)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rango de tiempo"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(48, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 23)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Cantidad de tiempo:"
        '
        'btnGenerar
        '
        Me.btnGenerar.Enabled = False
        Me.btnGenerar.Location = New System.Drawing.Point(248, 176)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.TabIndex = 79
        Me.btnGenerar.Text = "Generar"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AutoSize = False
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(240, 40)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        Me.txtDescripcion.Size = New System.Drawing.Size(292, 19)
        Me.txtDescripcion.TabIndex = 116
        Me.txtDescripcion.Text = ""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(104, 64)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 118
        '
        'frmComparativoCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(546, 216)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmComparativoCuenta"
        Me.Text = "Reporte comparativos de cuentas"
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.txtCodigo, 0)
        Me.Controls.SetChildIndex(Me.btnGenerar, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        CType(Me.txtCodigo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCantidadTiempo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim idcuentas(0) As String
    Dim idcuenta As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        If Me.txtCantidadTiempo.Text = "" Then
            MsgBox("La cantidad de tiempo es un campo requerido", MsgBoxStyle.Information)
            Me.txtCantidadTiempo.Focus()
            Exit Sub
        End If



        LimpiarTemporal()
        BuscarIdCuentaContable(idcuenta)

        If Me.radMes.Checked Then
            CalcularSaldoMes()
        End If

        If Me.radAno.Checked Then
            calcularsaldoano()
        End If

        If Me.radMesAno.Checked Then
            calcularsaldomesano()
        End If

    End Sub

    'Es una funcion recursiva que busca las cuentas contables que se tiene que tomar en cuenta para la comparacion
    Private Sub BuscarIdCuentaContable(ByVal pIdCuentaContable As Integer)
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        If TieneMovimiento(pIdCuentaContable) = True Then

            sql = "select cuentacontable from contabilidad.dbo.cuentacontable where id =" & pIdCuentaContable
            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            Dim n As Integer = idcuentas.Length
            ReDim Preserve idcuentas(n)
            rstReader.Read()
            idcuentas(n - 1) = rstReader(0)
            rstReader.Close()
        End If

        '--------------

        sql = "select id from contabilidad.dbo.cuentacontable where parentid =" & pIdCuentaContable
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        Do While rstReader.Read()
            BuscarIdCuentaContable(rstReader("ID"))
        Loop
        cnnConexion.Close()

    End Sub

    'Determina si la cuenta contable pude tener movimiento
    Private Function TieneMovimiento(ByVal pIdCuentaContable As Integer) As Boolean
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = "select movimiento from contabilidad.dbo.cuentacontable where id =" & pIdCuentaContable
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read Then
            If rstReader(0) = True Then
                TieneMovimiento = True
            End If

        End If

        cnnConexion.Close()
    End Function

    'limpia la tabla temporal en la base de datos
    Private Function LimpiarTemporal()
        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()

        sql = " DELETE FROM contabilidad.dbo.Temporal3 "

        clsConexion.SlqExecute(cnnConexion, sql)
        cnnConexion.Close()
    End Function

    Private Sub CalcularSaldoMes()
        Dim n, m As Integer
        Dim fechaFinal, fechaInicio As Date
        Dim cuentacontable, fecini, fecfin As String
        Dim saldomes As Double
        Dim Meses(12) As String

        Meses(0) = "Enero"
        Meses(1) = "Febrero"
        Meses(2) = "Marzo"
        Meses(3) = "Abril"
        Meses(4) = "Mayo"
        Meses(5) = "Junio"
        Meses(6) = "Julio"
        Meses(7) = "Agosto"
        Meses(8) = "Septiembre"
        Meses(9) = "Octubre"
        Meses(10) = "Noviembre"
        Meses(11) = "Diciembre"
        For n = 0 To idcuentas.Length - 2
            If n <> 0 Then cuentacontable = cuentacontable & ","
            cuentacontable = cuentacontable & "'" & idcuentas(n) & "'"
        Next


        fechaFinal = Me.dtpFecha.Value

        For m = 0 To 4
            If IsDate(31 - m & "/" & fechaFinal.Month & "/" & fechaFinal.Year) Then
                fechaFinal = 31 - m & "/" & fechaFinal.Month & "/" & fechaFinal.Year
                fechaInicio = "1/" & fechaFinal.Month & "/" & fechaFinal.Year
                Exit For
            End If
        Next


        For n = 0 To Me.txtCantidadTiempo.Text

            'este for es para buscar la fecha inicial y final de cada mes para buscar en asiento contable
            If n <> 0 Then
                fechaFinal = fechaFinal.AddDays(-fechaFinal.DaysInMonth(fechaFinal.Year, fechaFinal.Month))
                fechaInicio = "1/" & fechaFinal.Month & "/" & fechaFinal.Year
            End If

            'se comvierte la fecha a formato fecha y hora
            fecini = "  CONVERT(DATETIME, '" & fechaInicio.Year & "-" & fechaInicio.Month & "-" & fechaInicio.Day & " 00:00:00', 102)"
            fecfin = "  CONVERT(DATETIME, '" & fechaFinal.Year & "-" & fechaFinal.Month & "-" & fechaFinal.Day & " 23:59:59', 102)"

            'se realiza la consulta para calcular el saldo del mes para esta fecha

            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader
            Dim sql As String
            Dim PrimerDigito As String

            PrimerDigito = cuentacontable.Substring(1, 1)

            If PrimerDigito = "1" Or PrimerDigito = "5" Or PrimerDigito = "6" Then
                sql = " select isnull(sum(Saldomes),0) from  " & _
                            " ( " & _
                            " select  " & _
                            " ( select isnull( sum(DAC.debecolon),0) from AsientoDC_DH DAC where DAC.debe = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                            " AND AC.NumAsiento = DAC.NumAsiento ) -  " & _
                            " ( select isnull( sum(DAC.habercolon),0) from AsientoDC_DH DAC where DAC.haber = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                            " AND AC.NumAsiento = DAC.NumAsiento ) " & _
                            " as saldomes " & _
                            " from asientoscontables AC  " & _
                            " where AC.mayorizado = 1 and AC.anulado = 0  " & _
                            " AND AC.fecha >= " & fecini & _
                            " and AC.fecha <= " & fecfin & _
                            " ) as Vista "
            Else
                sql = " select isnull(sum(Saldomes),0) from  " & _
                            " ( " & _
                            " select  " & _
                            " ( select isnull( sum(DAC.habercolon),0) from AsientoDC_DH DAC where DAC.haber = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                            " AND AC.NumAsiento = DAC.NumAsiento ) -  " & _
                            " ( select isnull( sum(DAC.debecolon),0) from AsientoDC_DH DAC where DAC.debe = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                            " AND AC.NumAsiento = DAC.NumAsiento ) " & _
                            " as saldomes " & _
                            " from asientoscontables AC  " & _
                            " where AC.mayorizado = 1 and AC.anulado = 0  " & _
                            " AND AC.fecha >= " & fecini & _
                            " and AC.fecha <= " & fecfin & _
                            " ) as Vista "
            End If


            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            cnnConexion.Open()

            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            rstReader.Read()
            saldomes = rstReader(0)
            rstReader.Close()

            sql = "INSERT INTO Temporal3 VALUES(" & txtCantidadTiempo.Text - n & ",'" & Meses(fechaFinal.Month - 1) & " - " & fechaFinal.Year & "'," & FormatoDouble(saldomes) & ")"
            clsConexion.SlqExecute(cnnConexion, sql)

            cnnConexion.Close()

        Next

        LlamarReporte()

    End Sub

    Private Sub CalcularSaldoAno()
        Dim n As Integer
        Dim fechaFinal, fechaInicio As Date
        Dim cuentacontable, fecini, fecfin As String
        Dim saldomes As Double

        For n = 0 To idcuentas.Length - 2
            If n <> 0 Then cuentacontable = cuentacontable & ","
            cuentacontable = cuentacontable & "'" & idcuentas(n) & "'"
        Next


        fechaFinal = Me.dtpFecha.Value


        If IsDate("31/12/" & fechaFinal.Year) Then
            fechaFinal = "31/12/" & fechaFinal.Year
            fechaInicio = "1/1/" & fechaFinal.Year
        End If


        For n = 0 To Me.txtCantidadTiempo.Text

            'este for es para buscar la fecha inicial y final de cada mes para buscar en asiento contable
            If n <> 0 Then
                fechaFinal = "31/12/" & fechaFinal.Year - 1
                fechaInicio = "1/1/" & fechaFinal.Year

            End If

            'se comvierte la fecha a formato fecha y hora
            fecini = "  CONVERT(DATETIME, '" & fechaInicio.Year & "-" & fechaInicio.Month & "-" & fechaInicio.Day & " 00:00:00', 102)"
            fecfin = "  CONVERT(DATETIME, '" & fechaFinal.Year & "-" & fechaFinal.Month & "-" & fechaFinal.Day & " 23:59:59', 102)"

            'se realiza la consulta para calcular el saldo del mes para esta fecha

            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader
            Dim sql As String
            Dim PrimerDigito As String

            PrimerDigito = cuentacontable.Substring(1, 1)

            If PrimerDigito = "1" Or PrimerDigito = "5" Or PrimerDigito = "6" Then
                sql = " select isnull(sum(Saldomes),0) from  " & _
                            " ( " & _
                            " select  " & _
                            " ( select isnull( sum(DAC.debecolon),0) from AsientoDC_DH DAC where DAC.debe = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                            " AND AC.NumAsiento = DAC.NumAsiento ) -  " & _
                            " ( select isnull( sum(DAC.habercolon),0) from AsientoDC_DH DAC where DAC.haber = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                            " AND AC.NumAsiento = DAC.NumAsiento ) " & _
                            " as saldomes " & _
                            " from asientoscontables AC  " & _
                            " where AC.mayorizado = 1 and AC.anulado = 0  " & _
                            " AND AC.fecha >= " & fecini & _
                            " and AC.fecha <= " & fecfin & _
                            " ) as Vista "
            Else
                sql = " select isnull(sum(Saldomes),0) from  " & _
                                            " ( " & _
                                            " select  " & _
                                            " ( select isnull( sum(DAC.habercolon),0) from AsientoDC_DH DAC where DAC.haber = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                                            " AND AC.NumAsiento = DAC.NumAsiento ) -  " & _
                                            " ( select isnull( sum(DAC.debecolon),0) from AsientoDC_DH DAC where DAC.debe = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
                                            " AND AC.NumAsiento = DAC.NumAsiento ) " & _
                                            " as saldomes " & _
                                            " from asientoscontables AC  " & _
                                            " where AC.mayorizado = 1 and AC.anulado = 0  " & _
                                            " AND AC.fecha >= " & fecini & _
                                            " and AC.fecha <= " & fecfin & _
                                            " ) as Vista "
            End If




            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            cnnConexion.Open()

            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            rstReader.Read()
            saldomes = rstReader(0)
            rstReader.Close()

            sql = "INSERT INTO Temporal3 VALUES(" & txtCantidadTiempo.Text - n & ",'" & fechaFinal.Year & "'," & FormatoDouble(saldomes) & ")"
            clsConexion.SlqExecute(cnnConexion, sql)

            cnnConexion.Close()

        Next

        LlamarReporte()

    End Sub

    Private Sub CalcularSaldoMesAno()
        Dim n, m As Integer
        Dim fechaFinal, fechaInicio As Date
        Dim cuentacontable, fecini, fecfin As String
        Dim saldomes As Double
        Dim Meses(12) As String

        Meses(0) = "Enero"
        Meses(1) = "Febrero"
        Meses(2) = "Marzo"
        Meses(3) = "Abril"
        Meses(4) = "Mayo"
        Meses(5) = "Junio"
        Meses(6) = "Julio"
        Meses(7) = "Agosto"
        Meses(8) = "Septiembre"
        Meses(9) = "Octubre"
        Meses(10) = "Noviembre"
        Meses(11) = "Diciembre"

        For n = 0 To idcuentas.Length - 2
            If n <> 0 Then cuentacontable = cuentacontable & ","
            cuentacontable = cuentacontable & "'" & idcuentas(n) & "'"
        Next

        fechaFinal = Me.dtpFecha.Value

        For m = 0 To 4
            If IsDate(31 - m & "/" & fechaFinal.Month & "/" & fechaFinal.Year) Then
                fechaFinal = 31 - m & "/" & fechaFinal.Month & "/" & fechaFinal.Year
                fechaInicio = "1/" & fechaFinal.Month & "/" & fechaFinal.Year
                Exit For
            End If
        Next


        For n = 0 To Me.txtCantidadTiempo.Text

            'este for es para buscar la fecha inicial y final de cada mes para buscar en asiento contable
            If n <> 0 Then

                For m = 0 To 4
                    If IsDate(31 - m & "/" & fechaFinal.Month & "/" & fechaFinal.Year - 1) Then
                        fechaFinal = 31 - m & "/" & fechaFinal.Month & "/" & fechaFinal.Year - 1
                        fechaInicio = "1/" & fechaFinal.Month & "/" & fechaFinal.Year
                        Exit For
                    End If
                Next
            End If

            'se comvierte la fecha a formato fecha y hora
            fecini = "  CONVERT(DATETIME, '" & fechaInicio.Year & "-" & fechaInicio.Month & "-" & fechaInicio.Day & " 00:00:00', 102)"
            fecfin = "  CONVERT(DATETIME, '" & fechaFinal.Year & "-" & fechaFinal.Month & "-" & fechaFinal.Day & " 23:59:59', 102)"

            'se realiza la consulta para calcular el saldo del mes para esta fecha

            Dim clsConexion As New Conexion
            Dim cnnConexion As New System.Data.SqlClient.SqlConnection
            Dim rstReader As System.Data.SqlClient.SqlDataReader
            Dim sql As String
            Dim PrimerDigito As String

            PrimerDigito = cuentacontable.Substring(1, 1)

            If PrimerDigito = "1" Or PrimerDigito = "5" Or PrimerDigito = "6" Then
                sql = " select isnull(sum(Saldomes),0) from  " & _
              " ( " & _
              " select  " & _
              " ( select isnull( sum(DAC.debecolon),0) from AsientoDC_DH DAC where DAC.debe = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
              " AND AC.NumAsiento = DAC.NumAsiento ) -  " & _
              " ( select isnull( sum(DAC.habercolon),0) from AsientoDC_DH DAC where DAC.haber = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
              " AND AC.NumAsiento = DAC.NumAsiento ) " & _
              " as saldomes " & _
              " from asientoscontables AC  " & _
              " where AC.mayorizado = 1 and AC.anulado = 0  " & _
              " AND AC.fecha >= " & fecini & _
              " and AC.fecha <= " & fecfin & _
              " ) as Vista "
            Else
                sql = " select isnull(sum(Saldomes),0) from  " & _
            " ( " & _
            " select  " & _
            " ( select isnull( sum(DAC.habercolon),0) from AsientoDC_DH DAC where DAC.haber = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
            " AND AC.NumAsiento = DAC.NumAsiento ) -  " & _
            " ( select isnull( sum(DAC.debecolon),0) from AsientoDC_DH DAC where DAC.debe = 1 and DAC.cuenta in (" & cuentacontable & ") " & _
            " AND AC.NumAsiento = DAC.NumAsiento ) " & _
            " as saldomes " & _
            " from asientoscontables AC  " & _
            " where AC.mayorizado = 1 and AC.anulado = 0  " & _
            " AND AC.fecha >= " & fecini & _
            " and AC.fecha <= " & fecfin & _
            " ) as Vista "
            End If



            cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            cnnConexion.Open()

            rstReader = clsConexion.GetRecorset(cnnConexion, sql)

            rstReader.Read()
            saldomes = rstReader(0)
            rstReader.Close()

            sql = "INSERT INTO Temporal3 VALUES(" & txtCantidadTiempo.Text - n & ",'" & Meses(fechaFinal.Month - 1) & " - " & fechaFinal.Year & "'," & FormatoDouble(saldomes) & ")"
            clsConexion.SlqExecute(cnnConexion, sql)

            cnnConexion.Close()

        Next

        LlamarReporte()
    End Sub

    Private Function FormatoDouble(ByVal valor As String) As String

        Dim n As Integer = -1
        n = valor.IndexOf(",")
        If n <> -1 Then
            valor = valor.Remove(n, 1)
            valor = valor.Insert(n, ".")
        End If
        Return valor
    End Function

    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = 112 Then
            LlamarFmrBuscarAsiento()
        End If

        If e.KeyCode = Keys.Enter Then
            If txtCodigo.Text.Length = 0 Then
                Me.txtDescripcion.Text = ""
                btnGenerar.Enabled = False
                Exit Sub
            End If
            If Buscar(txtCodigo.Text) = False Then
                Me.txtCodigo.Focus()
                Me.txtDescripcion.Text = ""
                Me.txtCodigo.Text = ""
                btnGenerar.Enabled = False
                MsgBox("No exites esa cuenta contable", MsgBoxStyle.Information)
            Else
                SendKeys.Send("{TAB}")
                btnGenerar.Enabled = True
            End If

        End If
    End Sub

    Private Sub LlamarFmrBuscarAsiento()
        Dim sql As String = " select CC.cuentacontable as [Cuenta contable],CC.descripcion as Descripcion,(SELECT descripcion from cuentacontable where id = cc.parentid) as [Cuenta madre] from cuentacontable CC " & _
       " where Movimiento=1"


        Dim busca As New fmrBuscarMayorizacionAsiento
        busca.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        busca.sqlstring = "select CuentaContable AS [Codigo cuenta],descripcion as Descripcion from Contabilidad.dbo.CuentaContable   "
        busca.sqlstring = sql
        busca.campo = "CC.descripcion"
        busca.ShowDialog()

        If busca.codigo Is Nothing Then
            btnGenerar.Enabled = False
            Exit Sub
        End If


        Me.txtCodigo.Text = busca.codigo
        Me.txtDescripcion.Text = busca.descrip
        Buscar(busca.codigo)
        SendKeys.Send("{TAB}")
        btnGenerar.Enabled = True

    End Sub

    Private Function Buscar(ByVal pCodigoCuenta As String) As Boolean

        If pCodigoCuenta.Length = 0 Then Exit Function

        Dim clsConexion As New Conexion
        Dim cnnConexion As New System.Data.SqlClient.SqlConnection
        Dim rstReader As System.Data.SqlClient.SqlDataReader
        Dim sql As String = "SELECT Id,descripcion  FROM CuentaContable WHERE CuentaContable ='" & pCodigoCuenta & "'"

        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        cnnConexion.Open()
        rstReader = clsConexion.GetRecorset(cnnConexion, sql)

        If rstReader.Read() = False Then Exit Function

        Me.txtDescripcion.Text = rstReader("Descripcion")
        idcuenta = rstReader("id")
        cnnConexion.Close()
        Buscar = True
    End Function

    Private Sub LlamarReporte()

        Try
            Dim rpt As New rptComparaCuentaXMes
            Dim visor As New frmVisorReportes
            rpt.SetParameterValue(0, Me.txtCodigo.Text)
            rpt.SetParameterValue(1, Me.txtDescripcion.Text)

            If Me.radMes.Checked Then rpt.SummaryInfo.ReportTitle = "Comparación de cuentas contables por mes"

            If Me.radAno.Checked Then rpt.SummaryInfo.ReportTitle = "Comparación de cuentas contables por año"

            If Me.radMesAno.Checked Then rpt.SummaryInfo.ReportTitle = "Comparación de cuentas contables de mes por año"

            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))

            visor.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try

    End Sub



    Private Sub frmComparativoCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
