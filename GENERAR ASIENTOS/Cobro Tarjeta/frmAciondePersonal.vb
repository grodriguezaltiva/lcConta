Imports System.Data.SqlClient
Imports Utilidades
Public Class frmAciondePersonal

    Dim TipoCambio As Double = 0
    Dim DiferencialCambiario As Double = 0
    Dim diferencia As Double = 0
    Private Depositos As New DataTable

    Function TransAsiento() As Boolean
        Dim Trans As SqlTransaction     'REALIZ LA TRANSACCION DE LOS ASIENTOS CONTABLES
        Try
            BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
            BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()

            Dim con As New SqlConnection(Configuracion.Claves.Conexion("Contabilidad"))
            Dim cmd As SqlDataAdapter
            con.Open()
            Trans = con.BeginTransaction

            cmd = New SqlDataAdapter("INSERT INTO AsientosContables(NumAsiento, Fecha, IdNumDoc, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio) VALUES (@NumAsiento, @Fecha, @IdNumDoc, @NumDoc, @Beneficiario, @TipoDoc, @Accion, @Anulado, @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Observaciones, @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio);", con)
            cmd.SelectCommand.Transaction = Trans
            cmd.SelectCommand.Parameters.Add("@NumAsiento", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).NumAsiento
            cmd.SelectCommand.Parameters.Add("@Fecha", SqlDbType.Date).Value = Me.DsIngresos1.AsientosContables(0).Fecha
            cmd.SelectCommand.Parameters.Add("@IdNumDoc", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).IdNumDoc
            cmd.SelectCommand.Parameters.Add("@NumDoc", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).NumDoc
            cmd.SelectCommand.Parameters.Add("@Beneficiario", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).Beneficiario
            cmd.SelectCommand.Parameters.Add("@TipoDoc", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).TipoDoc
            cmd.SelectCommand.Parameters.Add("@Accion", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).Accion
            cmd.SelectCommand.Parameters.Add("@Anulado", SqlDbType.Bit).Value = Me.DsIngresos1.AsientosContables(0).Anulado
            cmd.SelectCommand.Parameters.Add("@FechaEntrada", SqlDbType.Date).Value = Me.DsIngresos1.AsientosContables(0).FechaEntrada
            cmd.SelectCommand.Parameters.Add("@Mayorizado", SqlDbType.Bit).Value = Me.DsIngresos1.AsientosContables(0).Mayorizado
            cmd.SelectCommand.Parameters.Add("@Periodo", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).Periodo
            cmd.SelectCommand.Parameters.Add("@NumMayorizado", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).NumMayorizado
            cmd.SelectCommand.Parameters.Add("@Modulo", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).Modulo
            cmd.SelectCommand.Parameters.Add("@Observaciones", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).Observaciones
            cmd.SelectCommand.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar).Value = Me.DsIngresos1.AsientosContables(0).NombreUsuario
            cmd.SelectCommand.Parameters.Add("@TotalDebe", SqlDbType.Float).Value = Me.DsIngresos1.AsientosContables(0).TotalDebe
            cmd.SelectCommand.Parameters.Add("@TotalHaber", SqlDbType.Float).Value = Me.DsIngresos1.AsientosContables(0).TotalHaber
            cmd.SelectCommand.Parameters.Add("@CodMoneda", SqlDbType.Float).Value = Me.DsIngresos1.AsientosContables(0).CodMoneda
            cmd.SelectCommand.Parameters.Add("@TipoCambio", SqlDbType.Float).Value = Me.DsIngresos1.AsientosContables(0).TipoCambio
            cmd.SelectCommand.ExecuteNonQuery()

            For Each f As dsIngresos.DetallesAsientosContableRow In Me.DsIngresos1.DetallesAsientosContable.Rows
                cmd = New SqlDataAdapter("INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Tipocambio) VALUES (@NumAsiento, @Cuenta, @NombreCuenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @Tipocambio)", con)
                cmd.SelectCommand.Transaction = Trans
                cmd.SelectCommand.Parameters.Add("@NumAsiento", SqlDbType.NVarChar).Value = f.NumAsiento
                cmd.SelectCommand.Parameters.Add("@Cuenta", SqlDbType.NVarChar).Value = f.Cuenta
                cmd.SelectCommand.Parameters.Add("@NombreCuenta", SqlDbType.NVarChar).Value = f.NombreCuenta
                cmd.SelectCommand.Parameters.Add("@Monto", SqlDbType.Float).Value = f.Monto
                cmd.SelectCommand.Parameters.Add("@Debe", SqlDbType.Bit).Value = f.Debe
                cmd.SelectCommand.Parameters.Add("@Haber", SqlDbType.Bit).Value = f.Haber
                cmd.SelectCommand.Parameters.Add("@DescripcionAsiento", SqlDbType.NVarChar).Value = f.DescripcionAsiento
                cmd.SelectCommand.Parameters.Add("@Tipocambio", SqlDbType.Float).Value = f.Tipocambio
                cmd.SelectCommand.ExecuteNonQuery()
            Next

            Trans.Commit()
            con.Close()

            Return True
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Return False
        End Try
    End Function

    Private Function buscarFacturas() As Boolean
        Me.Depositos = New DataTable
        Me.Depositos.Rows.Clear()
        cFunciones.Llenar_Tabla_Generico("exec dbo.GetAccionedePersonal '" & Me.dtpFechaInicio.Value.ToShortDateString & "','" & Me.dtpFechaFinal.Value.ToShortDateString & "'", Me.Depositos, Configuracion.Claves.Conexion("Contabilidad"))
        If Me.Depositos.Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub generarAsientosVenta()

        DsIngresos1.DetallesAsientosContable.Clear()
        DsIngresos1.AsientosContables.Clear()

        If buscarFacturas() Then
            If MsgBox("Desea generar los asientos de operadores tarjetas", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion!!!") = MsgBoxResult.Yes Then
                Me.Generar_Asientos()
            End If
        Else
            MsgBox("No hay documentos que contabilizar o ya todos estan contabilizados", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub Limpiar()
        DsIngresos1.DetallesAsientosContable.Clear()
        DsIngresos1.AsientosContables.Clear()
        DsIngresos1.DetallesAsientosContable.Clear()
        DsIngresos1.PorContabilizar.Clear()
    End Sub

    Private Function ExisteCuenta(ByVal _cuenta As String) As Boolean
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select * from contabilidad.dbo.CuentaContable where cuentacontable = '" & _cuenta & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
        If dt.Rows.Count > 0 Then
            Return True
        Else
            MsgBox("Verificar cuenta " & _cuenta, MsgBoxStyle.Information, Text)
            Return False
        End If
    End Function

    Private Sub Generar_Asientos()
        Try

            Dim Fx As New cFunciones
            Dim db As New Conexion

            Dim NumAsiento As String = ""

            Dim Index As Integer = 0
            Me.ProgressBar1.Maximum = Me.Depositos.Rows.Count - 1
            Me.ProgressBar1.Minimum = 0

            For Each F As DataRow In Me.Depositos.Rows
                Me.ProgressBar1.Value = Index
                Index += 1

                Limpiar()
                TipoCambio = Fx.TipoCambio(F.Item("Fecha"))
                BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()
                BindingContext(DsIngresos1, "AsientosContables").AddNew()

                NumAsiento = Fx.BuscaNumeroAsiento("PLA-" & Format(CDate(F.Item("Fecha")).Month, "00") & Format(CDate(F.Item("Fecha")).Date, "yy") & "-")

                BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento") = NumAsiento
                BindingContext(DsIngresos1, "AsientosContables").Current("Beneficiario") = F.Item("Nombre_Empleado")
                BindingContext(DsIngresos1, "AsientosContables").Current("Modulo") = "Acciones de Personal Vacaciones"
                BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones") = "Accion de personal #" & F.Item("Num_Accion")
                BindingContext(DsIngresos1, "AsientosContables").Current("Fecha") = F.Item("Fecha")
                BindingContext(DsIngresos1, "AsientosContables").Current("IdNumDoc") = F.Item("Num_Accion")
                BindingContext(DsIngresos1, "AsientosContables").Current("NumDoc") = F.Item("Num_Accion")
                BindingContext(DsIngresos1, "AsientosContables").Current("TipoDoc") = 2
                BindingContext(DsIngresos1, "AsientosContables").Current("Accion") = "AUT"
                BindingContext(DsIngresos1, "AsientosContables").Current("Anulado") = 0
                BindingContext(DsIngresos1, "AsientosContables").Current("Mayorizado") = 0
                BindingContext(DsIngresos1, "AsientosContables").Current("FechaEntrada") = Now.Date
                BindingContext(DsIngresos1, "AsientosContables").Current("Periodo") = Fx.BuscaPeriodo(CDate(F.Item("Fecha")))
                BindingContext(DsIngresos1, "AsientosContables").Current("NumMayorizado") = 0
                BindingContext(DsIngresos1, "AsientosContables").Current("NombreUsuario") = txtUsuario.Text
                BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = 0
                BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = 0
                BindingContext(DsIngresos1, "AsientosContables").Current("CodMoneda") = 1
                BindingContext(DsIngresos1, "AsientosContables").Current("TipoCambio") = TipoCambio
                BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()

                '------------------------------------------------------------------
                'GUARDA ASIENTO DETALLE PARA CUENTA DEL DEPOSITO
                Me.GuardaAsientoDetalle(F.Item("MontoVacaciones"), True, False, F.Item("CuentaContable"), F.Item("Descripcion"))
                '------------------------------------------------------------------
                'GUARDA ASIENTO DETALLE PARA EL RETENCION DE LA TARJETA
                Me.GuardaAsientoDetalle(F.Item("MontoVacaciones"), True, False, F.Item("Cuenta2"), F.Item("Descripcion2"))

                BindingContext(DsIngresos1, "AsientosContables").Current("TotalDebe") = F.Item("MontoVacaciones")
                BindingContext(DsIngresos1, "AsientosContables").Current("TotalHaber") = F.Item("MontoVacaciones")
                BindingContext(DsIngresos1, "AsientosContables").EndCurrentEdit()

                Dim cx As New Conexion
                Dim dt As DataTable = cx.AlphabeticSort(Me.DsIngresos1.DetallesAsientosContable.Copy, 1).Copy
                Me.DsIngresos1.DetallesAsientosContable.Clear()
                Dim i As Integer = 0
                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("Debe") = True Then
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    End If
                Next

                For i = 0 To dt.Rows.Count - 1
                    If dt.Rows(i).Item("Debe") = False Then
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = dt.Rows(i).Item("Cuenta")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = dt.Rows(i).Item("NombreCuenta")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = dt.Rows(i).Item("Monto")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = dt.Rows(i).Item("Debe")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = dt.Rows(i).Item("Haber")
                        BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                    End If
                Next

                If Me.TransAsiento() = True Then
                    db.UpdateRecords("Planilla.dbo.AccionPersonal", "Contabilizado = 1, Asiento = '" & NumAsiento & "'", "Num_Accion = " & F.Item("Num_Accion"), "Planilla")
                End If

            Next
            MsgBox("Asientos generados correctamente!!!", MsgBoxStyle.Information, Text)
            Me.ProgressBar1.Value = 0
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Sub

    Public Function GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        Try
            If ExisteCuenta(Cuenta) = False Then
                Exit Function
            End If
            If Monto <> 0 And (Not Cuenta.Equals("0")) And (Not Cuenta.Equals("")) Then

                If engrosarlacuenta(Monto, Debe, Haber, Cuenta, NombreCuenta) Then

                    Return True
                End If
                'CREA LOS DETALLES DE ASIENTOS CONTABLES
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").AddNew()
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NumAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("NumAsiento")
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("DescripcionAsiento") = BindingContext(DsIngresos1, "AsientosContables").Current("Observaciones")
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Cuenta") = Cuenta
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("NombreCuenta") = NombreCuenta
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Monto") = Monto
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Debe") = Debe
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Haber") = Haber
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").Current("Tipocambio") = TipoCambio
                BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").EndCurrentEdit()

            End If
        Catch ex As System.Exception
            'MsgBox("ERROR A INCLUIR DATO: " & ex.ToString, MsgBoxStyle.Information, "Atención...")
            BindingContext(DsIngresos1, "AsientosContables.AsientosContablesDetallesAsientosContable").CancelCurrentEdit()
            Return False
        End Try
        Return True
    End Function

    Function engrosarlacuenta(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String) As Boolean
        Try

            For i As Integer = 0 To Me.DsIngresos1.DetallesAsientosContable.Count - 1

                If Me.DsIngresos1.DetallesAsientosContable(i).Cuenta = Cuenta And Me.DsIngresos1.DetallesAsientosContable(i).Debe = Debe And Me.DsIngresos1.DetallesAsientosContable(i).Haber = Haber Then
                    Me.DsIngresos1.DetallesAsientosContable(i).Monto += Monto
                    Return True
                End If

            Next
            Return False
        Catch ex As Exception
            ' MsgBox(ex.ToString, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function

    Private Sub btnGenerarVenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarVenta.Click
        Me.generarAsientosVenta()
    End Sub

    Private Sub ValoresDefecto()
        'VALORES POR DEFECTO PARA LA TABLA ASIENTOS
        DsIngresos1.AsientosContables.FechaColumn.DefaultValue = Now.Date
        DsIngresos1.AsientosContables.NumDocColumn.DefaultValue = "0"
        DsIngresos1.AsientosContables.IdNumDocColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.BeneficiarioColumn.DefaultValue = ""
        DsIngresos1.AsientosContables.TipoDocColumn.DefaultValue = 5
        DsIngresos1.AsientosContables.AccionColumn.DefaultValue = "AUT"
        DsIngresos1.AsientosContables.AnuladoColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.FechaEntradaColumn.DefaultValue = Now.Date
        DsIngresos1.AsientosContables.MayorizadoColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.PeriodoColumn.DefaultValue = Now.Month & "/" & Now.Year
        DsIngresos1.AsientosContables.NumMayorizadoColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.ModuloColumn.DefaultValue = "Asiento Compras"
        DsIngresos1.AsientosContables.ObservacionesColumn.DefaultValue = ""
        DsIngresos1.AsientosContables.NombreUsuarioColumn.DefaultValue = ""
        DsIngresos1.AsientosContables.TotalDebeColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.TotalHaberColumn.DefaultValue = 0
        DsIngresos1.AsientosContables.CodMonedaColumn.DefaultValue = 1
        DsIngresos1.AsientosContables.TipoCambioColumn.DefaultValue = 1

        'VALORES POR DEFECTO PARA LA TABLA DETALLES ASIENTOS
        DsIngresos1.DetallesAsientosContable.NumAsientoColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.DescripcionAsientoColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.CuentaColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.NombreCuentaColumn.DefaultValue = ""
        DsIngresos1.DetallesAsientosContable.MontoColumn.DefaultValue = 0
        DsIngresos1.DetallesAsientosContable.DebeColumn.DefaultValue = 0
        DsIngresos1.DetallesAsientosContable.HaberColumn.DefaultValue = 0
        DsIngresos1.DetallesAsientosContable.TipocambioColumn.DefaultValue = 1
    End Sub

    Private Sub frmCobroTarjeta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ValoresDefecto()
        Me.dtpFechaFinal.MaxDate = Now
        Me.dtpFechaInicio.MaxDate = Now
    End Sub

    Function Conectando() As SqlConnection
        Dim sQlconexion As New SqlConnection
        Dim SQLStringConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            SQLStringConexion = Configuracion.Claves.Conexion("Seguridad")
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function

    Function Loggin_Usuario() As Boolean
        Dim cConexion As New Conexion
        Dim rs As SqlDataReader
        Try
            If txtClave.Text <> "" Then
                rs = cConexion.GetRecorset(Conectando, "SELECT  Nombre from Usuarios where Clave_Interna ='" & txtClave.Text & "'")
                If rs.HasRows = False Then
                    MsgBox("Clave Incorrecta....", MsgBoxStyle.Information, "Atención...")
                    txtUsuario.Focus()
                    txtUsuario.Text = ""
                    Return False
                End If
                While rs.Read
                    Try
                        txtUsuario.Text = rs("Nombre")
                        txtUsuario.Enabled = False
                        txtClave.Enabled = False
                        txtUsuario.Focus()
                        Return True
                    Catch ex As SystemException
                        MsgBox(ex.Message)
                    End Try
                End While
                rs.Close()
                cConexion.DesConectar(cConexion.Conectar)
            Else
                MsgBox("Debe de digitar la clave de usuario", MsgBoxStyle.Exclamation)
                txtUsuario.Focus()
            End If

        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub txtClave_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Loggin_Usuario() Then
                Me.btnGenerarVenta.Enabled = True
                Me.dtpFechaInicio.Enabled = True
                Me.dtpFechaFinal.Enabled = True
                dtpFechaInicio.Focus()
            End If
        End If
    End Sub

End Class
