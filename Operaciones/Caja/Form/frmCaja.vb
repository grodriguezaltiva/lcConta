Public Class frmCaja
    Private enlaceCuentaBanc As BindingSource
    Private enlaceBanco As BindingSource
    Private enlaceCajaMovimiento As BindingSource
    Private enlaceUsuario As BindingSource
    Private datos As clsCaja
    Private IdCheque As Integer
    Sub New(Optional ByVal _IdCheque As Integer = 0)
        Me.IdCheque = _IdCheque
        InitializeComponent()
        datos = New clsCaja
        enlaceBanco = New BindingSource
        enlaceCuentaBanc = New BindingSource
        enlaceCajaMovimiento = New BindingSource
        enlaceUsuario = New BindingSource

        enlaceBanco.DataSource = datos
        enlaceBanco.DataMember = datos.Bancos.TableName

        enlaceCuentaBanc.DataSource = datos
        enlaceCuentaBanc.DataMember = datos.Cuentas_bancarias.TableName

        enlaceCajaMovimiento.DataSource = datos
        enlaceCajaMovimiento.DataMember = datos.vs_CO_CajaMovimiento.TableName

        enlaceUsuario.DataSource = datos
        enlaceUsuario.DataMember = datos.Usuarios.TableName

        cbBancos.DataSource = enlaceBanco
        cbBancos.ValueMember = datos.Bancos.Codigo_bancoColumn.ColumnName
        cbBancos.DisplayMember = datos.Bancos.DescripcionColumn.ColumnName

        cbCuentaBanc.DataSource = enlaceCuentaBanc
        cbCuentaBanc.ValueMember = datos.Cuentas_bancarias.Id_CuentaBancariaColumn.ColumnName
        cbCuentaBanc.DisplayMember = datos.Cuentas_bancarias.CuentaColumn.ColumnName

        cbUsuario.DataSource = enlaceUsuario
        cbUsuario.ValueMember = datos.Usuarios.IDColumn.ColumnName
        cbUsuario.DisplayMember = datos.Usuarios.NombreColumn.ColumnName

        dgvGastos.AutoGenerateColumns = False
        dgvGastos.DataSource = enlaceCajaMovimiento
        txtTipoCambioDolar.Text = datos.TipoCambioDolar

        datos.spUsuarios()
        If IdCheque = 0 Then
            spNuevo()
        Else
            spAbrir()
        End If



    End Sub
    Private Sub spNuevo()
        datos.spCajaMovimientosPendientes()
        datos.spBancos()
        cbBancos.SelectedValue = 24
        datos.spCuentaBanc(enlaceBanco.Current("Codigo_banco"))
        cbCuentaBanc.SelectedValue = 29
        txtPortador.Text = ""
        txtObservacion.Text = "REINTEGRO EFECTIVO CAJA"
        lbEstado.Text = ""
        spLimpiarCampos()
    End Sub
    Private Sub spAbrir()
        pnCheque.Enabled = False
        pnMovimiento.Enabled = False
        split.Panel1Collapsed = True

        dgvGastos.Enabled = False

        pnControles.Enabled = True

        btAceptar.Enabled = False
        btAnular.Enabled = True
        btImprimir.Enabled = True

        datos.spAbrir(IdCheque)
        dgvGastos.Columns("Pagada").ReadOnly = True
        txtTramiteID.Text = datos.tb_CO_Caja(0).IdCaja
        With datos.Cheques(0)
            txtCheque.Text = .Num_Cheque
            txtObservacion.Text = .Observaciones
            dtpFecha.Value = .Fecha
            txtMonto.Text = .Monto
            cbCuentaBanc.SelectedValue = .Id_CuentaBancaria
            If .Anulado Then
                lbANULADA.Visible = True
                btAnular.Enabled = False
            End If
        End With
        spLimpiarCampos()

    End Sub


    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Agregar()
    End Sub
    Dim IdCuenta As Integer = 0
    Private Sub Agregar()
        Try
            If Not (CDbl(txtMontoMovimiento.Text) > 0) Then
                MsgBox("El monto del movimiento debe ser mayor a cero")
                Exit Sub
            End If

            If IdCuenta = 0 Then
                MsgBox("Por favor completa la cuenta contable")
                Exit Sub
            End If
            Dim fila As dtsCaja.tb_CO_CajaMovimientoRow
            fila = datos.tb_CO_CajaMovimiento.Newtb_CO_CajaMovimientoRow
            fila.IdUsuarioCreador = Principal.IdUsuario
            fila.IdCaja = 0
            fila.IdCuenta = IdCuenta
            fila.IdUsuario = cbUsuario.SelectedValue
            fila.Pagada = 0
            fila.Documento = txtDocumento.Text
            fila.Descripcion = txtDescripcion.Text
            fila.Monto = txtMontoMovimiento.Text
            fila.Fecha = dtpFecha.Value
            datos.tb_CO_CajaMovimiento.Addtb_CO_CajaMovimientoRow(fila)
            datos.spGuardaMovimiento()
            datos.spCajaMovimientosPendientes()
            spLimpiarCampos()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub spLimpiarCampos()
        txtDocumento.Text = 0
        txtDescripcion.Text = ""
        txtMontoMovimiento.Text = 0
        IdCuenta = 0
        txtCuentaContable.Text = ""
        txtNombreCuenta.Text = ""
        txtDocumento.Focus()

    End Sub

    Private Sub txtCuentaContable_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCuentaContable.KeyDown
        If e.KeyCode = Keys.F1 Then
            BuscarCuentaContable()
        ElseIf e.KeyCode = Keys.Enter Then
            CargarCuentaBuscada()
        End If
    End Sub
    Private Sub CargarCuentaBuscada()
        Dim cu As CuentaContableEncontrada = datos.fnCuentaEncontrada(txtCheque.Text)
        If cu.IdCuenta > 0 Then
            txtNombreCuenta.Text = cu.Nombre
            txtCuentaContable.Text = cu.Cuenta
            IdCuenta = cu.IdCuenta

        End If
    End Sub
    Private Sub BuscarCuentaContable()
        Dim cu As New CuentaContableEncontrada
        cu = datos.fnCuentaContable
        If cu.IdCuenta > 0 Then
            txtNombreCuenta.Text = cu.Nombre
            txtCuentaContable.Text = cu.Cuenta
            IdCuenta = cu.IdCuenta

        End If
    End Sub

    Private Sub dgvGastos_KeyDown(sender As Object, e As KeyEventArgs) Handles dgvGastos.KeyDown
        If e.KeyCode = Keys.Delete Then
            BorrarMovimiento()
        End If
    End Sub
    Sub BorrarMovimiento()
        If MsgBox("Esto elimina permanentemente el movimiento, desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub

        End If
        If enlaceCajaMovimiento.Count > 0 Then
            datos.spEliminarCajaMovimiento(enlaceCajaMovimiento.Current("IdCajaMovimiento"))
            datos.spCajaMovimientosPendientes()
        End If
        spVerificar()
        spLimpiarCampos()


    End Sub

    Private Sub cbBancos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancos.SelectedIndexChanged
        spCambiaBanco()
    End Sub
    Sub spCambiaBanco()
        If enlaceBanco.Count > 0 Then
            datos.spCuentaBanc(cbBancos.SelectedValue)
        End If

    End Sub

    Sub spVerificar()
        Dim hayPagada As Boolean = False
        Dim total As Double = 0
        If datos Is Nothing Then
            Exit Sub
        End If
        With datos

            For Each fila As dtsCaja.vs_CO_CajaMovimientoRow In .vs_CO_CajaMovimiento
                If fila.Pagada Then
                    hayPagada = True
                    total += fila.Monto

                End If
            Next

        End With
        txtMonto.Text = total

        pnCheque.Enabled = hayPagada
        pnControles.Enabled = hayPagada
        btImprimir.Enabled = False
        btAnular.Enabled = False
        btAceptar.Enabled = hayPagada
    End Sub

    Private Sub dgvGastos_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGastos.CellValueChanged
        spVerificar()
    End Sub
    Private Sub dgvGastos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGastos.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            datos.vs_CO_CajaMovimiento(e.RowIndex).Pagada = Not datos.vs_CO_CajaMovimiento(e.RowIndex).Pagada
            datos.vs_CO_CajaMovimiento(e.RowIndex).EndEdit()

        End If
        spVerificar()

    End Sub

    Private Sub spVerificar_Leave(sender As Object, e As EventArgs) Handles dgvGastos.Leave
        spVerificar()

    End Sub

    Private Sub btAceptar_Click(sender As Object, e As EventArgs) Handles btAceptar.Click
        spGuardar()
    End Sub


    Sub spGuardar()
        Try
            If MsgBox("¿Desea guardar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            datos.crearCheque()

            With datos.ChequeActual
                .Portador = txtPortador.Text
                .Observaciones = txtObservacion.Text
                .Fecha = Now
                .FechaDeposito = Now
                .Monto = txtMonto.Text
                .Id_CuentaBancaria = cbCuentaBanc.SelectedValue
                .CodigoMoneda = datos.fnIdMoneda(cbCuentaBanc.SelectedValue)
                .TipoCambio = txtTipoCambioDolar.Text
                .Num_Cheque = txtCheque.Text

            End With

            datos.GuardarNuevo()
            IdCheque = datos.ChequeActual.Id_Cheque
            spAbrir()
            lbEstado.Text = "Datos Guardados Satisfactoriamente"


        Catch ex As Exception
            lbEstado.Text = ex.Message
        End Try
    End Sub
    Private Sub cbCuentaBanc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCuentaBanc.SelectedIndexChanged
        spNumeroCheque()
    End Sub
    Sub spNumeroCheque()
        txtCheque.Text = datos.fnNuevoCheque(cbCuentaBanc.SelectedValue)

    End Sub

    Private Sub btActualizar_Click(sender As Object, e As EventArgs) Handles btActualizar.Click
        spNumeroCheque()

    End Sub

    Private Sub btImprimir_Click(sender As Object, e As EventArgs) Handles btImprimir.Click
        datos.spImprimirCheque()
        datos.Imprimir()


    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles lbCuentaContable.Click
        BuscarCuentaContable()

    End Sub

    Private Sub frmCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btAnular_Click(sender As Object, e As EventArgs) Handles btAnular.Click
        Anular()
    End Sub
    Sub Anular()
        If MsgBox("Esto anula permanentemente el cheque, desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If
        datos.Anula()
        lbEstado.Text = "Datos Guardados Satisfactoriamente"
        lbANULADA.Visible = True
        btAnular.Enabled = False

    End Sub


End Class