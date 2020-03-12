Public Class clsCheque : Inherits dtsCaja
    Public ID As Integer = 0
    Public IDCaja As Integer = 0
    Sub New()
        spCargar()
    End Sub
    Sub New(_IdCheque As Integer)
        ID = _IdCheque

        spCargar()


    End Sub
    Sub spCargar()
        If ID = 0 Then
            Dim linea As dtsCaja.ChequesRow
            linea = Cheques.NewChequesRow
            linea.Fecha = Now
            linea.FechaDeposito = Now

            Cheques.AddChequesRow(linea)

        Else
            Dim cmd As New SqlClient.SqlCommand("SELECT * FROM Cheques WHERE Id_Cheque = @ID")
            cmd.Parameters.AddWithValue("@ID", ID)
            cls_Datos.consulta(cmd, Cheques, "Bancos")
            cmd.CommandText = "SELECT * FROM Cheques_Detalle WHERE Id_Cheque = @ID"
            cls_Datos.consulta(cmd, Cheques_Detalle, "Bancos")

            cmd.CommandText = "SELECT * FROM Cuentas_bancarias WHERE Id_CuentaBancaria = " & fnCheque.Id_CuentaBancaria
            cls_Datos.consulta(cmd, Cuentas_bancarias, "Bancos")
            cmd.CommandText = "SELECT * FROM Bancos WHERE Codigo_banco = " & Cuentas_bancarias(0).Codigo_banco
            cls_Datos.consulta(cmd, Bancos, "Bancos")
        End If


    End Sub

    Sub spImprimir()
        If MsgBox("¿Desea imprimir el cheque?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Dim print As String = Configuracion.Claves.Configuracion("ChequeImpresora")
                Dim pre As String = Me.SubCargarPrinter
                Me.Establecer_Impresora(print)
                Dim REPORT As New CrystalDecisions.CrystalReports.Engine.ReportDocument
                Dim path As String = Configuracion.Claves.Configuracion("ChequeArchivo")
                REPORT.Load(path)
                REPORT.SetParameterValue(0, ID)
                CrystalReportsConexion2.LoadReportViewer(Nothing, REPORT, True, cls_Datos.fn_StrConexionBase("Bancos"))
                If Not print.Equals("") Then
                    REPORT.PrintOptions.PrinterName = print
                End If

                REPORT.PrintOptions.PrinterName = print
                REPORT.PrintToPrinter(1, True, 0, 0)
                Me.Establecer_Impresora(pre)
            Catch ex As Exception
                MsgBox("ARCHIVO DESCONFIGURADO: Bancos/ChequeArchivo -" & ex.ToString, MsgBoxStyle.OkOnly, "CHEQUE PREIMPRESO")

            End Try
        End If


    End Sub
    Private Function Establecer_Impresora(ByVal NamePrinter As String) As Boolean
        On Error GoTo errSub

        'Variable de referencia  
        Dim obj_Impresora As Object

        'Creamos la referencia  
        obj_Impresora = CreateObject("WScript.Network")
        obj_Impresora.setdefaultprinter(NamePrinter)

        obj_Impresora = Nothing

        'La función devuelve true y se cambió con éxito  
        Establecer_Impresora = True
        '   MsgBox("La impresora se cambió correctamente", vbInformation)
        Exit Function


        'Error al cambiar la impresora  
errSub:
        If Err.Number = 0 Then Exit Function
        Establecer_Impresora = False
        MsgBox("error: " & Err.Number & Chr(13) & "Description: " & Err.Description)
        On Error GoTo 0
    End Function
    Public Function SubCargarPrinter() As String

        Dim aImpresoras(Printing.PrinterSettings.InstalledPrinters.Count - 1) As String

        Dim instance As New Printing.PrinterSettings

        For i As Integer = 0 To Printing.PrinterSettings.InstalledPrinters.Count - 1

            aImpresoras(i) = Printing.PrinterSettings.InstalledPrinters.Item(i)

            '-->> instance.PrinterName=instance.InstalledPrinters.Item(i)

            If instance.IsDefaultPrinter() Then

                ' MsgBox(aImpresoras(i))
                Return instance.PrinterName
            End If

        Next
        Return ""


    End Function
    Sub spCrearCheque()
        Dim linea As dtsCaja.ChequesRow
        linea = Cheques.NewChequesRow
        With linea
            .Num_Cheque = 0
            .Id_CuentaBancaria = 0
            .Fecha = Now
            .Portador = ""
            .Monto = 0
            .Conciliado = 0
            .Anulado = 0
            .Observaciones = ""
            .Ced_Usuario = Principal.Usuario.Cedula
            .Contabilizado = 0
            .Asiento = "0"
            .Cuenta_Destino = ""
            .Tipo = "CHEQUE"
            .Num_Conciliacion = 0
            .MontoLetras = ""
            .CodigoMoneda = 1
            .TipoCambio = 573.5
            .InfoBanco = ""
            .MonedaDep = 1
            .MontoDep = 0
            .FechaDeposito = Now
            .EndEdit()
        End With
        Cheques.AddChequesRow(linea)

    End Sub
    Function fnCheque() As ChequesRow
        Return Cheques(0)
    End Function
    Sub spCrearChequeDetalle(Descripcion As String, Monto As Double, Cuenta As String, NombreCuenta As String, debe As Boolean, haber As Boolean,
                             principal As Boolean)
        Dim lineaDetalle As dtsCaja.Cheques_DetalleRow
        lineaDetalle = Me.Cheques_Detalle.NewCheques_DetalleRow
        With lineaDetalle
            .Id_Cheque = fnCheque.Id_Cheque
            .Monto = Monto
            .Descripcion_Mov = Descripcion
            .Cuenta_Contable = Cuenta
            .Nombre_Cuenta = NombreCuenta
            .Debe = debe
            .Haber = haber
            .Principal = principal
        End With
        Cheques_Detalle.AddCheques_DetalleRow(lineaDetalle)

    End Sub
    Function fnValidar() As Boolean
        If fnCheque.Num_Cheque = 0 Or
            fnCheque.Monto = 0 Or
            fnCheque.Id_CuentaBancaria = 0 Then
            Return False
        End If
        Return True
    End Function
    Sub spGuardarTodo()

        If ID = 0 Then
            If fnValidar() Then
                Dim num2text As New cNum2Text
                fnCheque.MontoLetras = num2text.Numero2Letra(fnCheque.Monto, 0, 2, fnTextoMoneda(fnCheque.Id_CuentaBancaria), "CENTIMO",
                                                     cNum2Text.eSexo.Masculino, cNum2Text.eSexo.Masculino).ToUpper.ToString
                fnCheque.Fecha = Now
                fnCheque.FechaDeposito = Now
                fnCheque.Anulado = 0
                fnCheque.Tipo = "CHEQUE"
            End If
        End If
        spRegistraBD()
        GuardaAsiento()
        spImprimir()
    End Sub

    Sub spRegistraBD()
        Dim adp As New dtsCajaTableAdapters.ChequesTableAdapter
        adp.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Bancos")
        adp.Update(Me.Cheques)
        spActualizarIndicesSecundarios()

        Dim adpDet As New dtsCajaTableAdapters.Cheques_DetalleTableAdapter
        adpDet.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Bancos")
        adpDet.Update(Me.Cheques_Detalle)


        ID = fnCheque.Id_Cheque

    End Sub
    Private Sub spActualizarIndicesSecundarios()

        For Each linea As Cheques_DetalleRow In Cheques_Detalle
            linea.Id_Cheque = fnCheque.Id_Cheque
        Next
    End Sub

    Private Function fnTextoMoneda(ByVal _id As Integer) As String
        Dim dts As New DataTable
        cls_Datos.sp_llenarTabla("SELECT ISNULL(CASE WHEN COD_MONEDA = 1 THEN 'COLON' WHEN COD_MONEDA = 2 THEN 'DOLAR' END, '') AS TEXTO FROM CUENTAS_BANCARIAS WHERE ID_CUENTABANCARIA = " & _id, dts, "BANCOS")
        If dts.Rows.Count > 0 Then
            Return dts.Rows(0).Item(0)
        Else
            Return ""
        End If
    End Function
#Region "Asientos Contables"
    Function fnAsiento() As AsientosContablesRow
        Return AsientosContables(0)
    End Function
    Public Sub GuardaAsiento()
        Dim Fecha As DateTime = fnCheque.Fecha
        Dim Fx As New cFunciones
        Dim monto As Double = 0
        monto = fnCheque.Monto
        Dim asiento As dtsCaja.AsientosContablesRow
        asiento = Me.AsientosContables.NewAsientosContablesRow

        If Fx.ValidarPeriodo(Fecha) = False Then
            MsgBox("La fecha no corresponde al período fiscal o el período esta cerrado! No se puede guardar", MsgBoxStyle.Information)
            Exit Sub
        End If

        With asiento

            .NumAsiento = Fx.BuscaNumeroAsiento("BCO-" & Format(Fecha, "MM") & Format(Fecha, "yy") & "-")
            .Fecha = Fecha
            .IdNumDoc = fnCheque.Id_Cheque
            .NumDoc = fnCheque.Num_Cheque
            .Beneficiario = fnCheque.Portador
            .TipoDoc = 1
            .Accion = "AUT"
            .Accion = 0
            .FechaEntrada = Now.Date
            .Mayorizado = 0
            .Periodo = Fx.BuscaPeriodo(Fecha)
            .NumMayorizado = 0
            .Modulo = "Reintegro caja Chica"
            .Observaciones = fnCheque.Observaciones
            .NombreUsuario = fnCheque.Ced_Usuario
            .TotalDebe = monto
            .TotalHaber = monto
            .CodMoneda = fnCheque.CodigoMoneda
            .TipoCambio = Fx.TipoCambio(Fecha, True)
            .EndEdit()
        End With
        AsientosContables.AddAsientosContablesRow(asiento)
        Dim lineaCheque As dtsCaja.Cheques_DetalleRow
        For Each lineaCheque In Cheques_Detalle
            With lineaCheque
                GuardaAsientoDetalle(.Monto, .Debe, .Haber, .Cuenta_Contable, .Nombre_Cuenta)
            End With
        Next
        Dim adp As New dtsCajaTableAdapters.AsientosContablesTableAdapter
        adp.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        adp.Update(Me.AsientosContables)
        Dim adpDet As New dtsCajaTableAdapters.DetallesAsientosContableTableAdapter
        adpDet.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        adpDet.Update(Me.DetallesAsientosContable)
        ActualizarAsientoAux(fnCheque.Id_Cheque, asiento.NumAsiento)
    End Sub
    Public Sub ActualizarAsientoAux(Id As Integer, Asiento As String)
        Dim cm As New SqlClient.SqlCommand
        cm.CommandText = "UPDATE  Cheques SET Asiento = @Asiento, Contabilizado = 1 WHERE Id_Cheque = @Id"
        cm.Parameters.AddWithValue("@Id", Id)
        cm.Parameters.AddWithValue("@Asiento", Asiento)
        cls_Datos.cambio(cm, "Bancos")
    End Sub

    Public Sub GuardaAsientoDetalle(ByVal Monto As Double, ByVal Debe As Boolean, ByVal Haber As Boolean, ByVal Cuenta As String, ByVal NombreCuenta As String)
        If Monto > 0 Then
            Dim linea As dtsCaja.DetallesAsientosContableRow
            linea = DetallesAsientosContable.NewDetallesAsientosContableRow
            With linea

                .NumAsiento = fnAsiento.NumAsiento
                .DescripcionAsiento = fnAsiento.Observaciones
                .Cuenta = Cuenta
                .NombreCuenta = NombreCuenta
                .Monto = Monto
                .Debe = Debe
                .Haber = Haber
                .Tipocambio = fnAsiento.TipoCambio
                .EndEdit()
            End With
            DetallesAsientosContable.AddDetallesAsientosContableRow(linea)
        End If
    End Sub



#End Region
End Class