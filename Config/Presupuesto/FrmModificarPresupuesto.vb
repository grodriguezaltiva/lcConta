


Imports Utilidades_DB
Imports System.Data.SqlClient
Imports Utilidades

Public Class FrmModificarPresupuesto
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_perodoFiscal As System.Windows.Forms.Label
    Friend WithEvents txtcentroCostos As System.Windows.Forms.TextBox
    Friend WithEvents btnPeriodoFiscal As System.Windows.Forms.Button
    Friend WithEvents LblCentrodecostos As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo_fiscal As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtMontoActual As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMontoAnterior As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_MontoAnterior As System.Windows.Forms.Label
    Friend WithEvents Lbl_mes As System.Windows.Forms.Label
    Friend WithEvents LblEstado As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents LbltClave As System.Windows.Forms.Label
    Friend WithEvents TxClave As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmModificarPresupuesto))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtMontoActual = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMontoAnterior = New System.Windows.Forms.TextBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.Lbl_MontoAnterior = New System.Windows.Forms.Label
        Me.Lbl_mes = New System.Windows.Forms.Label
        Me.LblEstado = New System.Windows.Forms.Label
        Me.txtcentroCostos = New System.Windows.Forms.TextBox
        Me.btnPeriodoFiscal = New System.Windows.Forms.Button
        Me.LblCentrodecostos = New System.Windows.Forms.Label
        Me.txtPeriodo_fiscal = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.lbl_perodoFiscal = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.TxClave = New System.Windows.Forms.TextBox
        Me.LbltClave = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtMontoActual)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtMontoAnterior)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Lbl_MontoAnterior)
        Me.Panel1.Controls.Add(Me.Lbl_mes)
        Me.Panel1.Controls.Add(Me.LblEstado)
        Me.Panel1.Controls.Add(Me.txtcentroCostos)
        Me.Panel1.Controls.Add(Me.btnPeriodoFiscal)
        Me.Panel1.Controls.Add(Me.LblCentrodecostos)
        Me.Panel1.Controls.Add(Me.txtPeriodo_fiscal)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.lbl_perodoFiscal)
        Me.Panel1.Location = New System.Drawing.Point(8, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 200)
        Me.Panel1.TabIndex = 30
        '
        'txtMontoActual
        '
        Me.txtMontoActual.Location = New System.Drawing.Point(120, 136)
        Me.txtMontoActual.Name = "txtMontoActual"
        Me.txtMontoActual.Size = New System.Drawing.Size(168, 20)
        Me.txtMontoActual.TabIndex = 33
        Me.txtMontoActual.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Monto  Nuevo"
        '
        'txtMontoAnterior
        '
        Me.txtMontoAnterior.Enabled = False
        Me.txtMontoAnterior.Location = New System.Drawing.Point(120, 104)
        Me.txtMontoAnterior.Name = "txtMontoAnterior"
        Me.txtMontoAnterior.Size = New System.Drawing.Size(168, 20)
        Me.txtMontoAnterior.TabIndex = 31
        Me.txtMontoAnterior.Text = ""
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.ComboBox2.Location = New System.Drawing.Point(120, 72)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 30
        '
        'Lbl_MontoAnterior
        '
        Me.Lbl_MontoAnterior.Location = New System.Drawing.Point(8, 104)
        Me.Lbl_MontoAnterior.Name = "Lbl_MontoAnterior"
        Me.Lbl_MontoAnterior.TabIndex = 29
        Me.Lbl_MontoAnterior.Text = "Monto Actual"
        '
        'Lbl_mes
        '
        Me.Lbl_mes.Location = New System.Drawing.Point(8, 72)
        Me.Lbl_mes.Name = "Lbl_mes"
        Me.Lbl_mes.TabIndex = 28
        Me.Lbl_mes.Text = "Mes"
        '
        'LblEstado
        '
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.Location = New System.Drawing.Point(16, 176)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(368, 23)
        Me.LblEstado.TabIndex = 34
        Me.LblEstado.Text = "Estado"
        Me.LblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcentroCostos
        '
        Me.txtcentroCostos.Enabled = False
        Me.txtcentroCostos.Location = New System.Drawing.Point(120, 48)
        Me.txtcentroCostos.Name = "txtcentroCostos"
        Me.txtcentroCostos.Size = New System.Drawing.Size(200, 20)
        Me.txtcentroCostos.TabIndex = 27
        Me.txtcentroCostos.Text = ""
        '
        'btnPeriodoFiscal
        '
        Me.btnPeriodoFiscal.Location = New System.Drawing.Point(344, 8)
        Me.btnPeriodoFiscal.Name = "btnPeriodoFiscal"
        Me.btnPeriodoFiscal.Size = New System.Drawing.Size(48, 23)
        Me.btnPeriodoFiscal.TabIndex = 25
        Me.btnPeriodoFiscal.Text = "Buscar"
        '
        'LblCentrodecostos
        '
        Me.LblCentrodecostos.Location = New System.Drawing.Point(8, 48)
        Me.LblCentrodecostos.Name = "LblCentrodecostos"
        Me.LblCentrodecostos.Size = New System.Drawing.Size(96, 16)
        Me.LblCentrodecostos.TabIndex = 24
        Me.LblCentrodecostos.Text = "Centro De Costos "
        '
        'txtPeriodo_fiscal
        '
        Me.txtPeriodo_fiscal.Enabled = False
        Me.txtPeriodo_fiscal.Location = New System.Drawing.Point(120, 16)
        Me.txtPeriodo_fiscal.Name = "txtPeriodo_fiscal"
        Me.txtPeriodo_fiscal.Size = New System.Drawing.Size(200, 20)
        Me.txtPeriodo_fiscal.TabIndex = 23
        Me.txtPeriodo_fiscal.Text = ""
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Buscar"
        '
        'lbl_perodoFiscal
        '
        Me.lbl_perodoFiscal.Location = New System.Drawing.Point(8, 16)
        Me.lbl_perodoFiscal.Name = "lbl_perodoFiscal"
        Me.lbl_perodoFiscal.Size = New System.Drawing.Size(88, 23)
        Me.lbl_perodoFiscal.TabIndex = 1
        Me.lbl_perodoFiscal.Text = "Periodo Fiscal"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.btnAnular)
        Me.Panel2.Controls.Add(Me.btnBuscar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.TxClave)
        Me.Panel2.Controls.Add(Me.LbltClave)
        Me.Panel2.Location = New System.Drawing.Point(8, 224)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(448, 120)
        Me.Panel2.TabIndex = 31
        '
        'btnImprimir
        '
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnImprimir.Location = New System.Drawing.Point(323, 17)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 48)
        Me.btnImprimir.TabIndex = 34
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnAnular
        '
        Me.btnAnular.Image = CType(resources.GetObject("btnAnular.Image"), System.Drawing.Image)
        Me.btnAnular.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAnular.Location = New System.Drawing.Point(243, 17)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(75, 48)
        Me.btnAnular.TabIndex = 33
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBuscar.Location = New System.Drawing.Point(163, 17)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 48)
        Me.btnBuscar.TabIndex = 32
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.Location = New System.Drawing.Point(11, 17)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(64, 48)
        Me.btnNuevo.TabIndex = 31
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.Location = New System.Drawing.Point(91, 17)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(64, 48)
        Me.btnGuardar.TabIndex = 30
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TxClave
        '
        Me.TxClave.Location = New System.Drawing.Point(152, 88)
        Me.TxClave.Name = "TxClave"
        Me.TxClave.PasswordChar = Microsoft.VisualBasic.ChrW(42)
        Me.TxClave.Size = New System.Drawing.Size(144, 20)
        Me.TxClave.TabIndex = 37
        Me.TxClave.Text = ""
        '
        'LbltClave
        '
        Me.LbltClave.Location = New System.Drawing.Point(32, 88)
        Me.LbltClave.Name = "LbltClave"
        Me.LbltClave.Size = New System.Drawing.Size(72, 23)
        Me.LbltClave.TabIndex = 36
        Me.LbltClave.Text = "Clave"
        '
        'FrmModificarPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(464, 346)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmModificarPresupuesto"
        Me.Text = "Modificar Presupuesto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables"
    Dim txtId_PeridoFiscal As Integer = 0
    Dim IDPeriodo = 0
    Dim Class_cFunciones As New cFunciones
    Dim Cuenta_Contable As String = ""
    Dim PermisoGuardar As Boolean = False
    Dim PermisoModificar As Boolean = False
    Dim PermisoAnular As Boolean = False
    Dim PermisoImprimir As Boolean = False
    Dim PermisoLeer As Boolean = True
    Dim txtMesSeleccionado As String = ""
    Dim EstadoPeriodoFiscal As String = ""
    Dim IdP2 As String = ""


#End Region

    Private Sub FrmModificarPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'txtMontoAnterior.FormatString = "#,#0.00"
        txtMontoAnterior.Text = Format(CDbl("0" & txtMontoAnterior.Text), "#,#0.00")
        txtMontoActual.Text = Format(CDbl("0" & txtMontoActual.Text), "#,#0.00")

        btnGuardar.Enabled = False
        btnAnular.Enabled = False
        btnImprimir.Enabled = False
        btnBuscar.Enabled = False
        btnNuevo.Enabled = False
        LbltClave.Visible = False
        TxClave.Visible = False


        RutinaAutenticarPrivilegiosUsuario("Load")

    End Sub

    Private Sub btnPeriodoFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        RutinaBuscarPeriodoFiscal()
    End Sub



    Private Sub RutinaBuscarPeriodoFiscal()
        Try
            'SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal WHERE Id = @Id
            Dim fx As New cFunciones
            Dim IdP As String = ""
            txtId_PeridoFiscal = 0
            IdP = fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "(CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11)))", "Buscar Periodo Fiscal...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")
            txtId_PeridoFiscal = Convert.ToInt32(IdP)


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


                'If (IDPeriodo <> 0) Then
                '    Dim tbl_tabla As DataTable = Class_cFunciones.GetCuentasContables_Tabla_Presupuesto(IDPeriodo)

                '    Dim fila As Integer = 0

                '    For fila = 0 To tbl_tabla.Rows.Count - 1
                '        CbocentrosDeCostos.Items.Add(tbl_tabla.Rows(fila)("Descripcion").ToString())
                '    Next

                'End If


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub RutinaBusquedaGenaral()
        Try
            'SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal WHERE Id = @Id
           

            Dim fx As New cFunciones
            Dim IdP As String = ""
            txtId_PeridoFiscal = 0
            IdP = fx.BuscarDatosGeneral("SELECT Id, Mes,MontoAnterior, MontoActual  FROM ModificacionesPresupuesto", "PeriodoFiscal", "Buscar Presupuestos...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")
            IdP2 = IdP



            If IdP <> "" Then
                btnNuevo.Enabled = True
                btnGuardar.Enabled = True

                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                Dim AuxEstado As String = ""
                Dim Anular As String = ""
                par.Add("@ID", IdP)
                db.Fill_Generic_Table("Contabilidad", dt, "SELECT MP.Id_Periodo_Fiscal as Id , CAST(CONVERT(datetime, P.FechaInicio, 103) AS char(11)) + ' - ' + CAST(CONVERT(datetime, P.FechaFinal, 103) AS Char(11)) AS PeriodoFiscal, PreS.Cuenta_Contable, PreS.Descripcion, MP.Mes ,MP.MontoAnterior, MP.MontoActual,MP.Estado, MP.Anulado, P.Estado as EstadoPeriodoFiscal FROM PeriodoFiscal as P,ModificacionesPresupuesto  as MP, PRESUPUESTOS as PreS WHERE P.Id = MP.Id_Periodo_Fiscal AND PreS.Id_Periodo_Fiscal=MP.Id_Periodo_Fiscal AND PreS.Cuenta_Contable=MP.Cuenta_Contable AND MP.Id =@ID", CommandType.Text, par)
                IDPeriodo = 0
                If dt.Rows.Count > 0 Then
                    txtPeriodo_fiscal.Text = dt.Rows(0).Item(1)
                    IDPeriodo = dt.Rows(0).Item(0)
                    Cuenta_Contable = dt.Rows(0).Item(2)
                    txtcentroCostos.Text = dt.Rows(0).Item(3)
                    ComboBox2.Text = dt.Rows(0).Item(4)
                    txtMesSeleccionado = dt.Rows(0).Item(4)
                    txtMontoAnterior.Text = dt.Rows(0).Item(5)
                    txtMontoActual.Text = dt.Rows(0).Item(6)
                    AuxEstado = dt.Rows(0).Item(7)
                    Anular = dt.Rows(0).Item(8)
                    EstadoPeriodoFiscal = dt.Rows(0).Item(9)
                End If
                txtMontoAnterior.Text = Format(CDbl("0" & txtMontoAnterior.Text), "#,#0.00")
                txtMontoActual.Text = Format(CDbl("0" & txtMontoActual.Text), "#,#0.00")
                '''RutinaCargarMonto(IDPeriodo, Cuenta_Contable, ComboBox2.Text)

                Select Case AuxEstado
                    Case "P"
                        LblEstado.Text = "Pendiente de Aprobar "
                        'LblEstado.BackColor = Color.Gray
                    Case "R"
                        LblEstado.Text = "Presupuesto en Estado Rechazado"
                        'LblEstado.BackColor = Color.Red
                    Case "A"
                        'LblEstado.BackColor = Color.LightBlue
                        LblEstado.Text = "Presupuesto en estado aprobado"
                        txtMontoActual.Enabled = True
                End Select

               

                If (EstadoPeriodoFiscal = True) Then
                    btnNuevo.Enabled = False
                    btnGuardar.Enabled = False
                    btnAnular.Enabled = False
                    btnImprimir.Enabled = False
                    ComboBox2.Enabled = False
                    btnPeriodoFiscal.Enabled = False
                    Button2.Enabled = False
                    txtMontoActual.Enabled = False
                    MsgBox("Este Presupuesto seleccionado Corresponde a un Periodo Fiscal Inactiovo")
                Else
                    btnNuevo.Enabled = True
                    btnGuardar.Enabled = True
                    btnAnular.Enabled = True
                    btnImprimir.Enabled = True
                    ComboBox2.Enabled = True
                    btnPeriodoFiscal.Enabled = True
                    Button2.Enabled = True
                    ''Carga Permisos se usuario
                    RutinaAutenticarPrivilegiosUsuario("Load")
                    If (Anular = "1") Then
                        LblEstado.Text = "Presupuesto Anualdo"
                        btnNuevo.Enabled = False
                        btnGuardar.Enabled = False
                    End If

                End If

            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        txtMontoAnterior.Text = ""
        txtMontoActual.Text = ""
        Try
            'LblEstado.BackColor = Color.WhiteSmoke
            If (IDPeriodo <> 0 And txtcentroCostos.Text <> "") Then
                Dim class_cfunciones As New cFunciones
                Dim AuxEstado As String = ""
                Dim Anular As String = ""
                txtMontoAnterior.Text = class_cfunciones.CargarPresupuestoPormes(IDPeriodo, Cuenta_Contable, ComboBox2.Text)
                Dim DTabla As New DataTable
                DTabla = class_cfunciones.CargarEstadoPresupuestoPormes(IDPeriodo, Cuenta_Contable, ComboBox2.Text)
                Dim fila As Integer = 0
                For fila = 0 To DTabla.Rows.Count - 1
                    AuxEstado = DTabla.Rows(fila)("Estado").ToString()
                    Anular = DTabla.Rows(fila)("Anulado").ToString()
                    IdP2 = DTabla.Rows(fila)("Id").ToString()
                Next

                Select Case AuxEstado
                    Case "P"
                        LblEstado.Text = "Pendiente de Aprobar "
                        'LblEstado.BackColor = Color.Gray
                    Case "R"
                        LblEstado.Text = "Presupuesto en Estado Rechazado"
                        'LblEstado.BackColor = Color.Red
                    Case "A"
                        'LblEstado.BackColor = Color.LightBlue
                        LblEstado.Text = "Presupuesto en estado aprobado"
                End Select

                If (Anular = "1") Then
                    LblEstado.Text = "Presupuesto Anualdo"
                    btnNuevo.Enabled = False
                    btnGuardar.Enabled = False
                End If

            Else

            End If

            txtMontoAnterior.Text = Format(CDbl("0" & txtMontoAnterior.Text), "#,#0.00")
            txtMontoActual.Text = Format(CDbl("0" & txtMontoActual.Text), "#,#0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If (IDPeriodo <> 0 And ComboBox2.Text <> "" And Cuenta_Contable <> "" And Usuario.Nombre <> "" And txtcentroCostos.Text <> "" And txtPeriodo_fiscal.Text <> "" And txtMontoAnterior.Text <> "" And txtMontoActual.Text <> "") Then

                Dim Result As String = ""
                Result = MsgBox("Esta Seguro de Aplicar este nuevo presupuesto para el Mes de " & ComboBox2.Text & " Por un nuevo Monto  de " & _
                txtMontoActual.Text, MsgBoxStyle.YesNoCancel, "Nuevo Presupuesto")

                Select Case Result
                    Case 6
                        '''Aplicar Cambios
                        Dim ClassConexion As New Conexion
                        Dim Fecha As New Date
                        Dim FechaHora As String
                        FechaHora = Fecha.Day() & "/" & Month(Now) & "/" & Year(Now)
                        'Fecha.GetDateTimeFormats()
                        ClassConexion.ActualizarPresupuestos(IDPeriodo, ComboBox2.Text, Cuenta_Contable, Usuario.Nombre, "0", Convert.ToDouble(txtMontoAnterior.Text), Convert.ToDouble(txtMontoActual.Text), "P")


                    Case 7
                        '''No hace cambios
                    Case 2
                        '''No hace cambios
                End Select

                btnNuevo.Enabled = True
            Else
                MsgBox("Información Incompleta...", MsgBoxStyle.Information, "Datos en blanco...")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub RutinaInsertarNuevoPresupuesto(ByVal txtPeriodoFiscal As Integer, ByVal txtCuenta As String, ByVal txtMes As String, ByVal txtMontoAnterior As Double, ByVal txtMontoActual As Double, ByVal txtUsuario As String, ByVal txtFecha As String)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub txtPeriodo_fiscal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lbl_perodoFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        RutinaCrearNuevo()

    End Sub

    Sub RutinaCrearNuevo()
        btnImprimir.Enabled = False
        btnAnular.Enabled = False
        btnNuevo.Enabled = False
        txtcentroCostos.Text = ""
        txtMontoActual.Text = ""
        txtMontoAnterior.Text = ""
        txtPeriodo_fiscal.Text = ""
        ComboBox2.Text = ""


    End Sub

    Private Sub txtMontoActual_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtMontoActual.Text = Format(CDbl("0" & txtMontoActual.Text), "#,#0.00")
        txtMontoAnterior.Text = Format(CDbl("0" & txtMontoAnterior.Text), "#,#0.00")
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Sub RutinaAnular()
        Try
            ''''Anulado(1)
            ''''No Anulado(0)
            If (IdP2 <> "") Then
                Dim Resultado As Integer = 0
                Resultado = MsgBox("Eata seguro que si desea Anular este Presupuesto", MsgBoxStyle.OKCancel, "Anular")
                If (Resultado = 1) Then
                    Dim up As String = "update ModificacionesPresupuesto set Anulado = '1', Estado ='R',FechaAprobacion=GETDATE() Where Id =" & IdP2
                    Dim cnx As New Conexion
                    cnx.Conectar("SeeSoft", "Contabilidad")
                    cnx.SlqExecute(cnx.sQlconexion, up)
                    MsgBox("Anulado", MsgBoxStyle.Information, "Presupuesto Anulado")
                End If
            Else
                MsgBox("Debe seleccionar Un presupuesto a Anular")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

 
    Private Sub RutinaAutenticarPrivilegiosUsuario(ByVal TipoAutenticacion As String)
        Try
            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario

            If (TipoAutenticacion = "Load") Then
                PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo
            ElseIf (TipoAutenticacion = "AutenTicar") Then


                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                Dim Id_usuario_Buscar As String = ""
                Dim NombreUsiario_Buscar As String = ""

                par.Add("@ID", TxClave.Text)
                db.Fill_Generic_Table("Seguridad", dt, "SELECT Id_Usuario,Nombre FROM dbo.Usuarios WHERE Clave_Entrada = @ID", CommandType.Text, par)
                IDPeriodo = 0
                If dt.Rows.Count > 0 Then
                    NombreUsiario_Buscar = dt.Rows(0).Item(1)
                    Id_usuario_Buscar = dt.Rows(0).Item(0)
                End If

                PMU = VSM(Id_usuario_Buscar, Me.Name) 'Carga los privilegios del usuario con el modulo


            End If





            If PMU.Find Then
                btnBuscar.Enabled = True
            Else
                'MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...")
                TxClave.Visible = True
                TxClave.Visible = True
            End If

            If PMU.Update Then
                btnGuardar.Enabled = True
                btnNuevo.Enabled = True
            Else
                'MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...")
                LbltClave.Visible = True
                TxClave.Visible = True
            End If

            If PMU.Delete Then
                btnAnular.Enabled = True
            Else
                'MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...")
                LbltClave.Visible = True
                TxClave.Visible = True
            End If

            If PMU.Print Then
                btnImprimir.Enabled = True
            Else
                'MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...")
                LbltClave.Visible = True
                TxClave.Visible = True
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub








 





    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim fx As New cFunciones
        Dim IdP As String = ""

        Cuenta_Contable = ""
        IdP = fx.BuscarDatos("SELECT Cuenta_Contable, Descripcion  FROM PRESUPUESTOS WHERE  Id_Periodo_Fiscal =" & txtId_PeridoFiscal, "Cuenta_Contable", "Buscar Cuenta Centro Costos...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Cuenta_Contable DESC")

        If IdP <> "" Then
            Dim dt As New DataTable
            Dim db As New SeeDBMaster
            Dim par As New Dictionaries
            par.Add("@ID", IdP)
            db.Fill_Generic_Table("Contabilidad", dt, "SELECT Cuenta_Contable, Descripcion  FROM PRESUPUESTOS WHERE (Cuenta_Contable = @ID)", CommandType.Text, par)
            If dt.Rows.Count > 0 Then
                txtcentroCostos.Text = dt.Rows(0).Item(1)
                Cuenta_Contable = dt.Rows(0).Item(0)
            End If
        End If
    End Sub




    Private Sub btnPeriodoFiscal_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPeriodoFiscal.Click
        RutinaBuscarPeriodoFiscal()
    End Sub




    Private Sub txtMontoActual_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMontoActual.TextChanged



    End Sub

    Private Sub btnNuevo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        RutinaBusquedaGenaral()
    End Sub


    Private Sub RutinaCargarMonto(ByVal txtIdPeriodo As Integer, ByVal txtCuentaContable As String, ByVal txtcomboMes As String)
        Try
            'LblEstado.BackColor = Color.WhiteSmoke
            If (IDPeriodo <> 0 And txtcentroCostos.Text <> "") Then
                Dim class_cfunciones As New cFunciones
                Dim AuxEstado As String = ""
                Dim Anular As String = ""
                txtMontoAnterior.Text = class_cfunciones.CargarPresupuestoPormes(txtIdPeriodo, txtCuentaContable, txtcomboMes)
                txtMontoAnterior.Text = Format(CDbl("0" & txtMontoAnterior.Text), "#,#0.00")
                txtMontoActual.Text = Format(CDbl("0" & txtMontoActual.Text), "#,#0.00")
                Dim DTabla As New DataTable
                DTabla = class_cfunciones.CargarEstadoPresupuestoPormes(IDPeriodo, Cuenta_Contable, ComboBox2.Text)
                Dim fila As Integer = 0
                For fila = 0 To DTabla.Rows.Count - 1
                    AuxEstado = DTabla.Rows(fila)("Estado").ToString()
                    Anular = DTabla.Rows(fila)("Anulado").ToString()
                Next

                Select Case AuxEstado
                    Case "P"
                        LblEstado.Text = "Pendiente de Aprobar "
                        'LblEstado.BackColor = Color.Gray
                    Case "R"
                        LblEstado.Text = "Presupuesto en Estado Rechazado"
                        'LblEstado.BackColor = Color.Red
                    Case "A"
                        'LblEstado.BackColor = Color.LightBlue
                        LblEstado.Text = "Presupuesto en estado aprobado"
                End Select

                If (Anular = "1") Then
                    LblEstado.Text = "Presupuesto Anualdo"
                    btnNuevo.Enabled = False
                    btnGuardar.Enabled = False
                End If

            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    

    Private Sub txtClave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        'txtClave.Text = ""
        'txtClave.Visible = False
        'LblClave.Visible = False
    End Sub

    Private Sub txtClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtclaveU_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TxClave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxClave.TextChanged

    End Sub
    'ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs
    Private Sub TxClave_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            RutinaAutenticarPrivilegiosUsuario("AutenTicar")
            TxClave.Text = ""
            TxClave.Visible = False
            LbltClave.Visible = False

        End If

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_BindingContextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub btnAnular_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click
        RutinaAnular()
    End Sub

    Private Sub txtMontoActual_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtMontoActual.KeyDown
        Try
            If (e.KeyCode = Keys.Enter) Then
                txtMontoAnterior.Text = Format(CDbl("0" & txtMontoAnterior.Text), "#,#0.00")
                txtMontoActual.Text = Format(CDbl("0" & txtMontoActual.Text), "#,#0.00")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Try
            Dim rpt As New RptAutorizacion
            Dim visor As New frmVisorReportes
            rpt.SetParameterValue(0, IdP2)
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        ''Dim rpt As New RptAutorizacion
        'Dim rpt As New RptAutorizacion
        'rpt.SetParameterValue(0, Convert.ToInt32(codigo))
        ''rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
        ''rpt.SetParameterValue(2, Not Me.CheckBoxConta.Checked)
        'CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))






        'Try
        '    If (IdP2 <> "") Then
        '        Dim FormReporte As New FrmReporte
        '        FormReporte.codigo = IdP2
        '        FormReporte.ShowDialog()
        '    Else
        '        MsgBox("Debe seleccionar un Presupuesto", MsgBoxStyle.Information, "")
        '    End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
