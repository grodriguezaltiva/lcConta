Public Class clsCaja : Inherits dtsCaja
    Private cheque As clsCheque
    Sub spFiltros(Texto As String, PorFechas As Boolean, Desde As Date, Hasta As Date, VerAnulados As Boolean)
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From vs_CO_Caja WHERE CAST(Cheque as Varchar) LIKE '%' + @Texto + '%' #MASPARAMETROS ORDER BY IdCaja DESC"
        cm.Parameters.AddWithValue("@Texto", Texto)
        Dim masParametros As String = ""
        If PorFechas Then
            masParametros = "AND dbo.DateOnly(Fecha) >= @Desde AND dbo.DateOnly(Fecha) <= @Hasta"
            cm.Parameters.AddWithValue("@Desde", Desde.Date)
            cm.Parameters.AddWithValue("@Hasta", Hasta.Date)
        End If
        If Not VerAnulados Then
            masParametros &= " AND Anulada = 0"
        End If
        cm.CommandText = cm.CommandText.Replace("#MASPARAMETROS", masParametros)
        cls_Datos.consulta(cm, vs_CO_Caja, "Contabilidad")
    End Sub
    Sub spImprimirCheque()
        cheque.spImprimir()

    End Sub
    Sub Anula()
        Dim cm As New SqlClient.SqlCommand

        cm.CommandText = "UPDATE  tb_CO_Caja SET Anulado = 1  wHERE IdCaja = @IdCaja"
        cm.Parameters.AddWithValue("@IdCaja", tb_CO_Caja(0).IdCaja)
        cls_Datos.cambio(cm, "Contabilidad")

        cm.CommandText = "UPDATE  Cheques SET Anulado = 1  wHERE Id_Cheque = @IdCheque"
        cm.Parameters.AddWithValue("@IdCheque", tb_CO_Caja(0).IdCheque)
        cls_Datos.cambio(cm, "Bancos")
    End Sub
    Sub spAbrir(IdCheque As Integer)
        'ABRIR EL CHEQUE
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From Cheques Where Id_Cheque = @IdCheque"
        cm.Parameters.AddWithValue("@IdCheque", IdCheque)
        cls_Datos.consulta(cm, Me.Cheques, "Bancos")
        spCuentaBancCheque(Cheques(0).Id_CuentaBancaria)
        cheque = New clsCheque(IdCheque)
        'ABRIR LA CAJA
        cm.CommandText = "Select * From tb_CO_Caja Where IdCheque = @IdCheque"
        cls_Datos.consulta(cm, Me.tb_CO_Caja, "Contabilidad")
        cm.CommandText = "Select * From vs_CO_Caja Where IdCheque = @IdCheque"
        cls_Datos.consulta(cm, Me.vs_CO_Caja, "Contabilidad")
        'ABRIR MOVIMIENTOS DE LA CAJA
        cm.CommandText = "Select * From vs_CO_CajaMovimiento Where IdCaja = @IdCaja"
        cm.Parameters.AddWithValue("@IdCaja", tb_CO_Caja(0).IdCaja)
        cls_Datos.consulta(cm, Me.vs_CO_CajaMovimiento, "Contabilidad")


    End Sub
    Sub spBancos()
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From Bancos ORDER BY Descripcion"
        cls_Datos.consulta(cm, Me.Bancos, "Bancos")
    End Sub
    Sub spCuentaBanc(IdBanco As Integer)
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From Cuentas_bancarias WHERE Codigo_banco = @IdBanco AND Cod_Moneda = 1 ORDER BY Cuenta"
        cm.Parameters.AddWithValue("@IdBanco", IdBanco)
        cls_Datos.consulta(cm, Me.Cuentas_bancarias, "Bancos")

    End Sub
    Sub spCuentaBancCheque(IdCuentaBanc As Integer)
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From Cuentas_bancarias WHERE Id_CuentaBancaria = @IdCuentaBanc ORDER BY Cuenta"
        cm.Parameters.AddWithValue("@IdCuentaBanc", IdCuentaBanc)
        cls_Datos.consulta(cm, Me.Cuentas_bancarias, "Bancos")
        cm.CommandText = "Select * From Bancos WHERE Codigo_banco = @CodigoBanco"
        cm.Parameters.AddWithValue("@CodigoBanco", Cuentas_bancarias(0).Codigo_banco)
        cls_Datos.consulta(cm, Me.Bancos, "Bancos")
        cm.CommandText = "Select * From Cuentas_bancarias WHERE Id_CuentaBancaria = @IdCuentaBanc ORDER BY Cuenta"
        cls_Datos.consulta(cm, Me.Cuentas_bancarias, "Bancos")
    End Sub
    Sub sCuentaCont()
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From CuentaContable ORDER BY CuentaContable"
        cls_Datos.consulta(cm, Me.CuentaContable, "Contabilidad")
    End Sub
    Sub spCajaMovimientosPendientes()
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From vs_CO_CajaMovimiento WHERE Pagada = 0 ORDER BY IdCajaMovimiento DESC"
        cls_Datos.consulta(cm, Me.vs_CO_CajaMovimiento, "Contabilidad")
    End Sub
    Sub spUsuarios()
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "Select * From Usuarios WHERE NOT (Nombre LIKE 'xx%')"
        cls_Datos.consulta(cm, Me.Usuarios, "Contabilidad")
    End Sub
    Sub spGuardaMovimiento()
        Dim adp As New dtsCajaTableAdapters.tb_CO_CajaMovimientoTableAdapter
        adp.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        adp.Update(Me.tb_CO_CajaMovimiento)
    End Sub
    Function fnCuentaContable() As CuentaContableEncontrada

        Dim frmBuscar As New fmrBuscarMayorizacionAsiento
        Dim sql As String = " select cuentacontable as [Cuenta contable],Nombre,[Cuenta madre] from vs_CuentaConta  "
        frmBuscar.NuevaConexion = Configuracion.Claves.Conexion("Contabilidad")
        frmBuscar.sqlstring = sql
        frmBuscar.campo = "Descripcion"
        frmBuscar.ShowDialog()
        Return fnCuentaEncontrada(frmBuscar.codigo)

    End Function
    Function fnCuentaEncontrada(codigo As String) As CuentaContableEncontrada
        Dim cu As New CuentaContableEncontrada
        Try

            If codigo.Equals("") Then
                Return cu
            End If
            Dim dt As New DataTable
            Dim cmd As New SqlClient.SqlCommand
            cmd.CommandText = "Select CuentaContable, Descripcion, Id From CuentaContable WHERE CuentaContable =@Cuenta"
            cmd.Parameters.AddWithValue("@Cuenta", codigo)
            cls_Datos.consulta(cmd, dt, "Contabilidad")
            If dt.Rows.Count > 0 Then

                cu.IdCuenta = dt.Rows(0).Item("Id")
                cu.Nombre = dt.Rows(0).Item("Descripcion")
                cu.Cuenta = dt.Rows(0).Item("CuentaContable")

            End If
            Return cu
        Catch ex As Exception
            Return cu
        End Try

    End Function

    Sub spEliminarCajaMovimiento(IdCajaMovimiento As Integer)
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "DELETE FROM tb_CO_CajaMovimiento WHERE IdCajaMovimiento = @Id AND IdCaja = 0"
        cmd.Parameters.AddWithValue("@Id", IdCajaMovimiento)
        cls_Datos.cambio(cmd, "Contabilidad")


    End Sub
    Function fnNuevoCheque(_Cuenta As Integer) As Integer
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT ISNULL(MAX([Num_Cheque]),0) AS NUMERO FROM [Bancos].[dbo].[Cheques] WHERE Tipo = 'CHEQUE' AND Id_CuentaBancaria = @IdCuentaBanc"
        cmd.Parameters.AddWithValue("@IdCuentaBanc", _Cuenta)
        cls_Datos.consulta(cmd, dt, "Bancos")
        Dim numeroCheque As Integer = 0
        If dt.Rows.Count > 0 Then
            numeroCheque = dt.Rows(0).Item("NUMERO")
        End If
        numeroCheque += 1
        Return numeroCheque

    End Function
    Function TipoCambioDolar() As Double
        Dim dt As New DataTable
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = "SELECT * FROM Moneda WHERE [CodMoneda] = @ID"
        cmd.Parameters.AddWithValue("@ID", 2)
        cls_Datos.consulta(cmd, dt, "Seguridad")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item("ValorVenta")
        Else
            Return 1
        End If

    End Function
    Function fnIdMoneda(IdCuentaBanc As Integer) As Integer
        Dim dt As New DataTable
        Dim str As String = "Select Cod_Moneda From Cuentas_bancarias WHERE Id_CuentaBancaria = @IdCuentaBanc"
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = str
        cmd.Parameters.AddWithValue("@IdCuentaBanc", IdCuentaBanc)
        cls_Datos.consulta(cmd, dt, "Bancos")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return 1
        End If

    End Function
    Sub crearCheque()
        cheque = New clsCheque

    End Sub
    Function ChequeActual() As dtsCaja.ChequesRow
        Return cheque.fnCheque()
    End Function
    Function fnNombreCuentaContable(Cuenta As String) As String
        Dim dt As New DataTable
        Dim str As String = "Select Descripcion From CuentaContable WHERE CuentaContable.CuentaContable = @Cuenta"
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = str
        cmd.Parameters.AddWithValue("@Cuenta", Cuenta)
        cls_Datos.consulta(cmd, dt, "Contabilidad")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return Cuenta
        End If

    End Function
    Function fnCodigoCuentaContable(Cuenta As String) As String
        Dim dt As New DataTable
        Dim str As String = "Select CuentaContable From CuentaContable WHERE CuentaContable.CuentaContable = @Cuenta"
        Dim cmd As New SqlClient.SqlCommand
        cmd.CommandText = str
        cmd.Parameters.AddWithValue("@Cuenta", Cuenta)
        cls_Datos.consulta(cmd, dt, "Contabilidad")
        If dt.Rows.Count > 0 Then
            Return dt.Rows(0).Item(0)
        Else
            Return Cuenta
        End If

    End Function
    Function fnCuentaBanc(IdCuentaBanc As Integer) As Cuentas_bancariasRow
        For Each linea As Cuentas_bancariasRow In Cuentas_bancarias
            If linea.Id_CuentaBancaria = IdCuentaBanc Then
                Return linea
            End If
        Next
        Return Nothing

    End Function
    Sub GuardarNuevo()

        For Each fila As dtsCaja.vs_CO_CajaMovimientoRow In vs_CO_CajaMovimiento
            If fila.Pagada Then
                cheque.spCrearChequeDetalle(cheque.fnCheque.Observaciones, fila.Monto,
                                      fnCodigoCuentaContable(fila.CuentaContable),
                                      fnNombreCuentaContable(fila.CuentaContable), True, False, False)

            End If

        Next


        cheque.spCrearChequeDetalle(cheque.fnCheque.Observaciones, cheque.fnCheque.Monto,
                                    fnCuentaBanc(cheque.fnCheque.Id_CuentaBancaria).CuentaContable,
                                    fnCuentaBanc(cheque.fnCheque.Id_CuentaBancaria).NombreCuenta, False, True, True)

        cheque.spGuardarTodo()

        Dim reintegro As dtsCaja.tb_CO_CajaRow
        reintegro = Me.tb_CO_Caja.Newtb_CO_CajaRow
        reintegro.IdCheque = ChequeActual.Id_Cheque
        reintegro.IdUsuario = Principal.IdUsuario
        reintegro.FechaCreacion = Now
        reintegro.Anulado = False
        tb_CO_Caja.Addtb_CO_CajaRow(reintegro)
        Dim adp As New dtsCajaTableAdapters.tb_CO_CajaTableAdapter
        adp.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        adp.Update(Me.tb_CO_Caja)
        For Each fila As dtsCaja.vs_CO_CajaMovimientoRow In vs_CO_CajaMovimiento
            If fila.Pagada Then
                spActualizarIdCajaMovimiento(reintegro.IdCaja, fila.IdCajaMovimiento)
            End If
        Next
        tb_CO_CajaMovimiento.EndInit()
        spGuardaMovimiento()
        Imprimir()
    End Sub
    Public Sub Imprimir()
        If MsgBox("¿Desea ver el comprobante?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim frm As New frmVisorReportes
                frm.Text = "Comprobante Caja"
                Dim recibo As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                Dim ruta As String = Configuracion.Claves.Configuracion("ComprobanteCaja")
                recibo.Load(ruta)

                recibo.SetParameterValue("IdCaja", Me.tb_CO_Caja(0).IdCaja)
                recibo.SetParameterValue("Usuario", Principal.Usuario.Nombre)
                CrystalReportsConexion2.LoadReportViewer(Nothing, recibo, True, cls_Datos.fn_StrConexionBase("Bancos"))
                frm.rptViewer.ReportSource = recibo
                frm.Show()
            Catch ex As Exception
                MsgBox("ARCHIVO DESCONFIGURADO: Contabilidad/ComprobanteCaja - " & ex.ToString, MsgBoxStyle.OkOnly, "Reporte de Reintegro")
            End Try

        End If
    End Sub
    Sub spActualizarIdCajaMovimiento(IdCaja As Integer, IdCajaMovimiento As Integer)
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "UPDATE  tb_CO_CajaMovimiento SET IdCaja = @IdCaja, Pagada=1 WHERE IdCajaMovimiento = @IdCajaMovimiento"
        cm.Parameters.AddWithValue("@IdCajaMovimiento", IdCajaMovimiento)
        cm.Parameters.AddWithValue("@IdCaja", IdCaja)
        cls_Datos.cambio(cm, "Contabilidad")

    End Sub
End Class
Public Class CuentaContableEncontrada
    Public IdCuenta As Integer = 0
    Public Cuenta As String = ""
    Public Nombre As String = ""

End Class
