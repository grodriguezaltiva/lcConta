Imports Utilidades_DB
Imports System.Data.SqlClient
Imports Utilidades


Public Class FrmBusqueda
    Inherits System.Windows.Forms.Form
    Public Shared NuevaConexion As String

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub


#Region "Variables"
    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
    Friend codigo As String
    Friend descrip As String
    Friend campo As String
    Friend sqlstring As String
    Public sqlStringAdicional As String
    Dim IDPeriodo As Integer = 0
    Dim Cuenta_Contable As String = ""
    Dim ds As DataSet
    Dim bandera As Boolean = False
    Dim AuxStrLongFecha As String = ""
#End Region

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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dg As System.Windows.Forms.DataGrid
    Friend WithEvents txtcentroCostos As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnPeriodoFiscal As System.Windows.Forms.Button
    Friend WithEvents LblCentrodecostos As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo_fiscal As System.Windows.Forms.TextBox
    Friend WithEvents lbl_perodoFiscal As System.Windows.Forms.Label
    Friend WithEvents LblFechaInicio As System.Windows.Forms.Label
    Friend WithEvents LblFechaFin As System.Windows.Forms.Label
    Friend WithEvents FechaInicioDateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaFinDateTimePicker2 As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmBusqueda))
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.dg = New System.Windows.Forms.DataGrid
        Me.txtcentroCostos = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnPeriodoFiscal = New System.Windows.Forms.Button
        Me.LblCentrodecostos = New System.Windows.Forms.Label
        Me.txtPeriodo_fiscal = New System.Windows.Forms.TextBox
        Me.lbl_perodoFiscal = New System.Windows.Forms.Label
        Me.FechaInicioDateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.FechaFinDateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.LblFechaInicio = New System.Windows.Forms.Label
        Me.LblFechaFin = New System.Windows.Forms.Label
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.ForeColor = System.Drawing.Color.Transparent
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Location = New System.Drawing.Point(320, 408)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.TabIndex = 7
        '
        'btnAceptar
        '
        Me.btnAceptar.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.ForeColor = System.Drawing.Color.Transparent
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.Location = New System.Drawing.Point(8, 408)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(96, 24)
        Me.btnAceptar.TabIndex = 6
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(8, 376)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(424, 23)
        Me.txtBusqueda.TabIndex = 4
        Me.txtBusqueda.Text = ""
        '
        'dg
        '
        Me.dg.AllowDrop = True
        Me.dg.AlternatingBackColor = System.Drawing.Color.Lavender
        Me.dg.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dg.BackgroundColor = System.Drawing.Color.LightGray
        Me.dg.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg.CaptionBackColor = System.Drawing.Color.LightSteelBlue
        Me.dg.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.CaptionForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.CaptionText = "Resultado de la Búsqueda"
        Me.dg.DataMember = ""
        Me.dg.FlatMode = True
        Me.dg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.GridLineColor = System.Drawing.Color.Gainsboro
        Me.dg.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.dg.HeaderForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.LinkColor = System.Drawing.Color.Teal
        Me.dg.Location = New System.Drawing.Point(0, 160)
        Me.dg.Name = "dg"
        Me.dg.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg.PreferredColumnWidth = 150
        Me.dg.ReadOnly = True
        Me.dg.SelectionBackColor = System.Drawing.Color.CadetBlue
        Me.dg.SelectionForeColor = System.Drawing.Color.WhiteSmoke
        Me.dg.Size = New System.Drawing.Size(432, 208)
        Me.dg.TabIndex = 5
        '
        'txtcentroCostos
        '
        Me.txtcentroCostos.Enabled = False
        Me.txtcentroCostos.Location = New System.Drawing.Point(128, 48)
        Me.txtcentroCostos.Name = "txtcentroCostos"
        Me.txtcentroCostos.Size = New System.Drawing.Size(240, 20)
        Me.txtcentroCostos.TabIndex = 28
        Me.txtcentroCostos.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(392, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Buscar"
        '
        'btnPeriodoFiscal
        '
        Me.btnPeriodoFiscal.Location = New System.Drawing.Point(392, 8)
        Me.btnPeriodoFiscal.Name = "btnPeriodoFiscal"
        Me.btnPeriodoFiscal.Size = New System.Drawing.Size(48, 23)
        Me.btnPeriodoFiscal.TabIndex = 26
        Me.btnPeriodoFiscal.Text = "Buscar"
        '
        'LblCentrodecostos
        '
        Me.LblCentrodecostos.Location = New System.Drawing.Point(16, 48)
        Me.LblCentrodecostos.Name = "LblCentrodecostos"
        Me.LblCentrodecostos.Size = New System.Drawing.Size(96, 16)
        Me.LblCentrodecostos.TabIndex = 25
        Me.LblCentrodecostos.Text = "Centro De Costos "
        '
        'txtPeriodo_fiscal
        '
        Me.txtPeriodo_fiscal.Enabled = False
        Me.txtPeriodo_fiscal.Location = New System.Drawing.Point(128, 16)
        Me.txtPeriodo_fiscal.Name = "txtPeriodo_fiscal"
        Me.txtPeriodo_fiscal.Size = New System.Drawing.Size(240, 20)
        Me.txtPeriodo_fiscal.TabIndex = 24
        Me.txtPeriodo_fiscal.Text = ""
        '
        'lbl_perodoFiscal
        '
        Me.lbl_perodoFiscal.Location = New System.Drawing.Point(16, 16)
        Me.lbl_perodoFiscal.Name = "lbl_perodoFiscal"
        Me.lbl_perodoFiscal.Size = New System.Drawing.Size(88, 23)
        Me.lbl_perodoFiscal.TabIndex = 23
        Me.lbl_perodoFiscal.Text = "Periodo Fiscal"
        '
        'FechaInicioDateTimePicker1
        '
        Me.FechaInicioDateTimePicker1.Location = New System.Drawing.Point(128, 88)
        Me.FechaInicioDateTimePicker1.Name = "FechaInicioDateTimePicker1"
        Me.FechaInicioDateTimePicker1.Size = New System.Drawing.Size(240, 20)
        Me.FechaInicioDateTimePicker1.TabIndex = 29
        '
        'FechaFinDateTimePicker2
        '
        Me.FechaFinDateTimePicker2.Location = New System.Drawing.Point(128, 120)
        Me.FechaFinDateTimePicker2.Name = "FechaFinDateTimePicker2"
        Me.FechaFinDateTimePicker2.Size = New System.Drawing.Size(240, 20)
        Me.FechaFinDateTimePicker2.TabIndex = 30
        '
        'LblFechaInicio
        '
        Me.LblFechaInicio.Location = New System.Drawing.Point(16, 88)
        Me.LblFechaInicio.Name = "LblFechaInicio"
        Me.LblFechaInicio.Size = New System.Drawing.Size(80, 23)
        Me.LblFechaInicio.TabIndex = 31
        Me.LblFechaInicio.Text = "Fecha Inicio"
        '
        'LblFechaFin
        '
        Me.LblFechaFin.Location = New System.Drawing.Point(16, 128)
        Me.LblFechaFin.Name = "LblFechaFin"
        Me.LblFechaFin.Size = New System.Drawing.Size(80, 23)
        Me.LblFechaFin.TabIndex = 32
        Me.LblFechaFin.Text = "Fecha Fin"
        '
        'FrmBusqueda
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 450)
        Me.Controls.Add(Me.LblFechaFin)
        Me.Controls.Add(Me.LblFechaInicio)
        Me.Controls.Add(Me.FechaFinDateTimePicker2)
        Me.Controls.Add(Me.FechaInicioDateTimePicker1)
        Me.Controls.Add(Me.txtcentroCostos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnPeriodoFiscal)
        Me.Controls.Add(Me.LblCentrodecostos)
        Me.Controls.Add(Me.txtPeriodo_fiscal)
        Me.Controls.Add(Me.lbl_perodoFiscal)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.dg)
        Me.Name = "FrmBusqueda"
        Me.Text = "FrmBusqueda"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If dg.VisibleRowCount > 0 Then
            codigo = CStr(dg(dg.CurrentRowIndex, 0))
            descrip = CStr(dg(dg.CurrentRowIndex, 1))
        End If
        Close()
    End Sub

    Private Sub FrmBusqueda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cConexion = New Conexion
        sqlConexion = New SqlConnection

        If NuevaConexion = "" Then
            sqlConexion = cConexion.Conectar
        Else
            sqlConexion.ConnectionString = NuevaConexion
            sqlConexion.Open()
        End If

        cargarInformacion("")
        Me.txtBusqueda.Focus()
    End Sub



    Private Sub Rutina_BuscarCuentaCostos()
        Try
            Dim fx As New cFunciones
            Dim IdP As String = ""

            Cuenta_Contable = ""

            IdP = fx.BuscarDatos("SELECT Cuenta_Contable, Descripcion  FROM PRESUPUESTOS WHERE  Id_Periodo_Fiscal =" & IDPeriodo, "Cuenta_Contable", "Buscar Cuenta Centro Costos...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Cuenta_Contable DESC")

            If IdP <> "" And IDPeriodo <> 0 Then
                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                par.Add("@ID", IdP)
                db.Fill_Generic_Table("Contabilidad", dt, "SELECT Cuenta_Contable, Descripcion  FROM PRESUPUESTOS WHERE (Cuenta_Contable = @ID)", CommandType.Text, par)
                If dt.Rows.Count > 0 Then
                    txtcentroCostos.Text = dt.Rows(0).Item(1)
                    Cuenta_Contable = dt.Rows(0).Item(0)
                End If

                cargarInformacion("  WHERE Id_Periodo_Fiscal =" & IDPeriodo & " AND  Cuenta_Contable ='" & Cuenta_Contable & "'")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub cargarInformacion(ByVal sWhere As String)
        Try
            Dim myCommand1 As SqlDataAdapter = New SqlDataAdapter(sqlstring & sWhere & " " & sqlStringAdicional, sqlConexion)
            Dim ds As DataSet = New DataSet

            myCommand1.Fill(ds, "Informacion")

            If bandera = False Then
                Dim tbl As New DataGridTableStyle
                tbl.MappingName = "Informacion"
                Dim Column As New DataGridTextBoxColumn
                If cFunciones.Fechaemp = 1 Then
                    Column.MappingName = ds.Tables(0).Columns(1).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                    Column.Width = 80
                    Column.Alignment = HorizontalAlignment.Center
                    tbl.GridColumnStyles.Add(Column)

                    Column = New DataGridTextBoxColumn
                    Column.MappingName = ds.Tables(0).Columns(7).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(7).Caption()
                    Column.Width = 300
                    Column.Alignment = HorizontalAlignment.Center
                    tbl.GridColumnStyles.Add(Column)
                    dg.TableStyles.Add(tbl)
                    tbl = Nothing
                    bandera = True
                Else
                    Column.MappingName = ds.Tables(0).Columns(0).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(0).Caption()
                    Column.Width = 60
                    Column.ReadOnly = True
                    Column.Alignment = HorizontalAlignment.Center
                    tbl.GridColumnStyles.Add(Column)


                    Column = New DataGridTextBoxColumn
                    Column.MappingName = ds.Tables(0).Columns(1).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(1).Caption()
                    Column.Width = 90
                    Column.ReadOnly = True
                    tbl.GridColumnStyles.Add(Column)

                    Column = New DataGridTextBoxColumn
                    Column.MappingName = ds.Tables(0).Columns(2).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(2).Caption()
                    Column.Width = 90
                    Column.ReadOnly = True
                    tbl.GridColumnStyles.Add(Column)

                    Column = New DataGridTextBoxColumn
                    Column.MappingName = ds.Tables(0).Columns(3).Caption()
                    Column.HeaderText = ds.Tables(0).Columns(3).Caption()
                    Column.Width = 90
                    Column.ReadOnly = True
                    tbl.GridColumnStyles.Add(Column)
                    dg.TableStyles.Add(tbl)
                    tbl = Nothing
                    bandera = True
                End If
            End If

            dg.DataSource = ds.Tables(0)
            ds = Nothing
            dg.AllowSorting = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        If Len(txtBusqueda.Text) >= 1 Then
            campo = "Id"
            If sqlstring.IndexOf("where") > 0 Then
                cargarInformacion(" and " & campo & " like '%" & txtBusqueda.Text & "%'")
            Else
                cargarInformacion(" where " & campo & " like '%" & txtBusqueda.Text & "%'")
            End If

        ElseIf Trim(txtBusqueda.Text) = vbNullString Then
            cargarInformacion("")
        End If
    End Sub

    Private Sub btnPeriodoFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodoFiscal.Click
        Rutina_BuscarPeriodoFiscal()
    End Sub


    Private Sub Rutina_BuscarPeriodoFiscal()

        Dim fx As New cFunciones
        Dim IdP As String = ""

        IdP = fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "PeriodoFiscal", "Buscar Periodo Fiscal...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")
        'txtId_PeridoFiscal = Convert.ToInt32(IdP)


        If IdP <> "" Then
            Dim dt As New DataTable
            Dim db As New SeeDBMaster
            Dim par As New Dictionaries
            par.Add("@ID", IdP)
            db.Fill_Generic_Table("Contabilidad", dt, "SELECT Id, CAST(CONVERT(datetime, FechaInicio, 103) AS char(11)) + ' - ' + CAST(CONVERT(datetime, FechaFinal, 103) AS Char(11)) AS PeriodoFiscal FROM PeriodoFiscal WHERE (Id = @ID)", CommandType.Text, par)
            IDPeriodo = 0
            If dt.Rows.Count > 0 Then
                txtPeriodo_fiscal.Text = dt.Rows(0).Item(1)
                IDPeriodo = dt.Rows(0).Item(0)
            End If
            cargarInformacion("  WHERE Id_Periodo_Fiscal =" & IDPeriodo)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Rutina_BuscarCuentaCostos()
    End Sub

    Private Sub Rutina_BusquedaXRangoFecha()
        Try
            Dim txtlong As Integer = 0
            Dim StrLongFecha As String = ""
            AuxStrLongFecha = ""
            Dim srtint As Integer = 0
            Dim Band As Boolean = False
            StrLongFecha = FechaInicioDateTimePicker1.Value
            txtlong = StrLongFecha.Length - 1
            For srtint = 0 To txtlong
                If (StrLongFecha.Chars(srtint) <> " " And Band = False) Then
                    AuxStrLongFecha &= StrLongFecha.Chars(srtint)
                Else
                    Band = True
                End If


            Next


            cargarInformacion("  WHERE Id_Periodo_Fiscal =" & IDPeriodo & " AND Fecha >='" & AuxStrLongFecha & "'  AND Fecha <='" & FechaFinDateTimePicker2.Value & "'")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

       End Sub


    Private Sub FechaInicioDateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaInicioDateTimePicker1.ValueChanged
        Rutina_BusquedaXRangoFecha()
    End Sub

    Private Sub FechaFinDateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FechaFinDateTimePicker2.ValueChanged
        Rutina_BusquedaXRangoFecha()
    End Sub
End Class
