Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class cFunciones
    Public Shared Descripcion As String
    Public Shared Fechaemp As Integer
    Public Function DamePeriodoFiscal(ByVal Fecha As DateTime) As Integer
        Dim cConexion As New Conexion                   'VALIDA SI ESTA EN EL MISMO PERIODO FISCAL
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try

            'BUSCA LOS PERIODOS FISCALES ABIERTOS
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), " SELECT Id, FechaInicio, FechaFinal FROM PeriodoFiscal ")

            While rs.Read
                If Fecha >= rs("FechaInicio") Then
                    If Fecha <= rs("FechaFinal") Then
                        Return rs("Id")    'SI ENCUENTRA UN PERIODO ABIERTO PARA LA FECHA
                    End If
                End If
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
        Return 0

    End Function
    Public Function BuscaNumeroAsiento(ByVal InicioAsiento As String, ByVal add As Integer) As String
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim Numero As String
        Dim Max As String = "0"
        Dim Ceros, Length As Integer

        Try
            'BUSCA LOS NUMEROS DE ASIENTOS EXISTENTES PARA EL AÑO Y MES ESTABLECIDOS
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT NumAsiento from AsientosContables Where NumAsiento Like '" & InicioAsiento & "%'")

            While rs.Read

                Numero = rs("NumAsiento").Substring(9)  'SELECCIONA SOLO EL NUMERO DE CONSECUTIVO DEL ASIENTO SIN EL AÑO Y MES
                If CInt(Max) < CInt(Numero) Then        'VERIFICA SI EL NUMERO QUE ESTA LEYENDO ES EL MAYOR
                    Max = (Numero)                       'DE SER MAYOR SE LO ASIGNA AL NUMERO MAX
                End If
            End While
            rs.Close()
            Max = (CInt(Max) + add)
            If Max = 0 Then
                BuscaNumeroAsiento = InicioAsiento & "0001"  'ENVIA EL SIGUIENTE NUMERO DE ASIENTO
            Else
                '-----------------------------------------------------------
                'PARA SABER LA CANTIDAD DE CEROS QUE DEBE HABER EN EL CONSECUTIVO DEL ASIENTO
                Ceros = Max.TrimStart("0").Length
                Max = CInt(Max)
                Length = Max.Length
                Max += 1
                If Max.Length <> Length Then
                    Ceros += 1
                End If
                For i As Integer = 0 To (3 - Ceros)
                    InicioAsiento = InicioAsiento & "0"
                Next
                '-----------------------------------------------------------
                BuscaNumeroAsiento = InicioAsiento & Max  'ENVIA EL SIGUIENTE NUMERO DE ASIENTO
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
            Return Nothing
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function
    Public Shared Sub Llenar_Tabla_Generico(ByVal comando As SqlCommand, ByRef Tabla As DataTable, Optional ByVal NuevaConexionStr As String = "")
        Dim StringConexion As String

        StringConexion = IIf(NuevaConexionStr = "", Configuracion.Claves.Conexion("Contabilidad"), NuevaConexionStr)

        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)

        Try
            ConexionX.Open()
            comando.Connection = ConexionX
            comando.CommandType = CommandType.Text
            comando.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = comando
            Tabla.Clear()
            da.Fill(Tabla)
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta..") ' Si hay error, devolvemos un valor nulo.
            Exit Sub
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub

    Public Function BuscarDatos(ByVal strConsulta As String, ByVal Campo As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0, Optional ByVal Adicional As String = "") As String
        Dim frmBuscar As New Buscar
        Dim codigo As String
        Fechaemp = Fecha
        frmBuscar.sqlstring = strConsulta
        frmBuscar.Text = nombre
        frmBuscar.campo = Campo
        frmBuscar.sqlStringAdicional = Adicional
        frmBuscar.NuevaConexion = NuevaConexionStr
        frmBuscar.ShowDialog()
        codigo = frmBuscar.codigo
        Descripcion = frmBuscar.descrip
        Return codigo
    End Function


    Public Function BuscarDatosGeneral(ByVal strConsulta As String, ByVal Campo As String, Optional ByVal nombre As String = "Buscar...", Optional ByVal NuevaConexionStr As String = "", Optional ByVal Fecha As Integer = 0, Optional ByVal Adicional As String = "") As String
        Dim FrmBusqueda As New FrmBusqueda
        Dim codigo As String
        Fechaemp = Fecha
        FrmBusqueda.sqlstring = strConsulta
        FrmBusqueda.Text = nombre
        FrmBusqueda.campo = Campo
        FrmBusqueda.sqlStringAdicional = Adicional
        FrmBusqueda.NuevaConexion = NuevaConexionStr
        FrmBusqueda.ShowDialog()
        codigo = FrmBusqueda.codigo
        Descripcion = FrmBusqueda.descrip
        Return codigo
    End Function

    Public Function Buscar_X_Descripcion_Fecha(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...") As String
        Dim frmBuscar As New FrmBuscador
        Dim codigo As String
        frmBuscar.SQLString = SQLString
        frmBuscar.Text = NombreBuscador
        frmBuscar.CampoFiltro = CampoFiltro
        frmBuscar.CampoFecha = CampoFechaFiltro
        frmBuscar.ShowDialog()
        If frmBuscar.Cancelado Then
            Return Nothing
        Else
            Return frmBuscar.Codigo
        End If
    End Function

    Public Function Buscar_X_Descripcion_Fecha5C(ByVal SQLString As String, ByVal CampoFiltro As String, ByVal CampoFechaFiltro As String, Optional ByVal NombreBuscador As String = "Buscar...") As String
        'BUSCADOR DISEÑADO PARA CINCO COLUMNAS
        Dim frmBuscar As New FrmBuscador5C
        Dim codigo As String
        frmBuscar.SQLString = SQLString
        frmBuscar.Text = NombreBuscador
        frmBuscar.CampoFiltro = CampoFiltro
        frmBuscar.CampoFecha = CampoFechaFiltro
        frmBuscar.ShowDialog()
        If frmBuscar.Cancelado Then
            Return Nothing
        Else
            Return frmBuscar.Codigo
        End If
    End Function


    'Esta Función Calcula el saldo de la factura
    Public Function Saldo_de_Factura(ByVal FacturaNo As Double, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal TipoCambRecibo As Double) As Double
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim MontoDevoluciones As Double
        Dim MontoAbonos As Double
        Dim MontoNCredito As Double
        Dim MontoNDebito As Double
        Dim InteresCob As Double
        Dim ConexionLocal As New Conexion
        Dim rs As SqlDataReader
        Dim id As Double
        sqlConexion = cConexion.Conectar
        If FacturaNo = 0 Then Exit Function
        rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT id from Ventas where Tipo = 'CRE' and Num_Factura = " & FacturaNo)
        If rs.Read Then
            id = rs("id")
            'Calcula Devoluciones
            MontoDevoluciones = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Monto) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & rs("id") & " AND Anulado = 0")
        Else
            MontoDevoluciones = 0
        End If
        'Calcula los Abonos
        'MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Abono_SuMoneda) as TotalAbono FROM Detalle_AbonoCCobrar WHERE Tipo = 'CRE' and Factura =" & FacturaNo & " AND Anulada = 0")
        MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(detalle_abonoccobrar.Abono_SuMoneda) AS TotalAbono FROM  detalle_abonoccobrar INNER JOIN  abonoccobrar ON detalle_abonoccobrar.Id_Recibo = abonoccobrar.Id_Recibo WHERE     (detalle_abonoccobrar.Tipo = 'CRE') AND (detalle_abonoccobrar.Factura = " & FacturaNo & ") AND (abonoccobrar.Anula = 0)")

        'NOTAS DE CREDITO
        'MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Ajuste) as TotalAjuste FROM Detalle_AjustesCCobrar WHERE Tipo = 'CRE' and Factura =" & FacturaNo & " AND Tipo='CRE' AND Anulada = 0")
        MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(detalle_ajustesccobrar.Ajuste) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE     (detalle_ajustesccobrar.Factura = " & FacturaNo & ") AND (detalle_ajustesccobrar.Tipo = 'CRE') AND (ajustesccobrar.Anula = 0) AND  (detalle_ajustesccobrar.TipoNota = 'CRE')")

        'NOTAS DE DEBITO
        'MontoNDebito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Ajuste) as TotalAjust FROM Detalle_AjustesCCobrar WHERE Tipo = 'CRE' and Factura =" & FacturaNo & " AND Tipo='DEB' AND Anulada = 0")
        MontoNDebito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(detalle_ajustesccobrar.Ajuste) AS TotalAjuste FROM detalle_ajustesccobrar INNER JOIN ajustesccobrar ON detalle_ajustesccobrar.Id_AjustecCobrar = ajustesccobrar.ID_Ajuste WHERE     (detalle_ajustesccobrar.Factura = " & FacturaNo & ") AND (detalle_ajustesccobrar.Tipo = 'CRE') AND (ajustesccobrar.Anula = 0) AND  (detalle_ajustesccobrar.TipoNota = 'DEB')")
        'Obtener el saldo final de la factura
        Saldo_de_Factura = MontoFactura + ((MontoNDebito - MontoNCredito - MontoAbonos - MontoDevoluciones) * TipoCambFact / TipoCambRecibo)
        'Saldo_de_Factura = ((MontoFactura - MontoDevoluciones) + InteresCob + MontoNDebito) - (MontoNCredito + MontoAbonos)
        cConexion.DesConectar(sqlConexion)
    End Function


    Public Function Saldo_de_Factura_Proveedor(ByVal FacturaNo As Double, ByVal MontoFactura As Double, ByVal TipoCambFact As Double, ByVal TipoCambRecibo As Double) As Double
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim MontoDevoluciones As Double
        Dim MontoAbonos As Double
        Dim MontoNCredito As Double
        Dim MontoNDebito As Double
        Dim InteresCob As Double
        Dim ConexionLocal As New Conexion
        Dim rs As SqlDataReader
        Dim id As Double
        sqlConexion = cConexion.Conectar
        If FacturaNo = 0 Then Exit Function
        rs = ConexionLocal.GetRecorset(ConexionLocal.Conectar, "SELECT id_compra from Compras where TipoCompra = 'CRE' and Factura = " & FacturaNo)
        If rs.Read Then
            id = rs!id_compra
            'Calcula Devoluciones
            MontoDevoluciones = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(Monto) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & rs("id_compra") & " AND Anulado = 0")
        Else
            MontoDevoluciones = 0
        End If
        'Calcula los Abonos
        MontoAbonos = cConexion.SlqExecuteScalar(sqlConexion, "SELECT  SUM(detalle_abonocpagar.Abono_SuMoneda) AS TotalAbono FROM  detalle_abonocpagar INNER JOIN  abonocpagar ON detalle_abonocpagar.id_abonocpagar = abonoccobrar.Id_Abonocpagar WHERE (detalle_abonocpagar.Factura = " & FacturaNo & ") AND (abonocpagar.Anulado = 0)")

        'NOTAS DE CREDITO
        MontoNCredito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(detalle_ajustescpagar.Ajuste) AS TotalAjuste FROM detalle_ajustescpagar INNER JOIN ajustescpagar ON detalle_ajustescpagar.Id_AjustecPagar = ajustescpagar.ID_Ajuste WHERE (detalle_ajustescpagar.Factura = " & FacturaNo & ") AND (detalle_ajustescpagar.Tipo = 'CRE') AND (ajustescpagar.Anula = 0) AND (detalle_ajustescpagar.TipoNota = 'CRE')")

        'NOTAS DE DEBITO
        MontoNDebito = cConexion.SlqExecuteScalar(sqlConexion, "SELECT SUM(detalle_ajustescpagar.Ajuste) AS TotalAjuste FROM detalle_ajustescpagar INNER JOIN ajustescpagar ON detalle_ajustescpagar.Id_Ajustecpagar = ajustescpagar.ID_Ajuste WHERE (detalle_ajustescpagar.Factura = " & FacturaNo & ") AND (detalle_ajustescpagar.Tipo = 'CRE') AND (ajustescpagar.Anula = 0) AND  (detalle_ajustescpagar.TipoNota = 'DEB')")
        'Obtener el saldo final de la factura
        Saldo_de_Factura_Proveedor = MontoFactura + ((MontoNDebito - MontoNCredito - MontoAbonos - MontoDevoluciones) * TipoCambFact / TipoCambRecibo)
        cConexion.DesConectar(sqlConexion)
    End Function


    Public Shared Function BuscarFacturas(ByVal CodigoCliente As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("SeePos")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String =
                "SELECT Num_Factura as Factura, Fecha, Total, Cod_Moneda from Ventas WHERE Tipo = 'CRE' and FacturaCancelado = 0 and Anulado = 0 and Cod_Cliente = @Codigo and (dbo.SaldoFactura(GETDATE(), Num_Factura) > 0)"

            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int))
            cmd.Parameters("@Codigo").Value = CodigoCliente
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try
        ' Devolvemos el objeto DataTable con los datos de la consulta
        Return dt
    End Function

    Public Shared Function GetPresupuesto(ByVal CuentaContable As String, ByVal DttxtId_PeridoFiscal As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String =
            "EXEC PROC_CARGARPRESUPUESTOS @CUENTA_CONTABLE, @txtId_PeridoFiscal"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@CUENTA_CONTABLE", SqlDbType.VarChar))
            cmd.Parameters("@CUENTA_CONTABLE").Value = CuentaContable

            cmd.Parameters.Add(New SqlParameter("@txtId_PeridoFiscal", SqlDbType.Int))
            cmd.Parameters("@txtId_PeridoFiscal").Value = DttxtId_PeridoFiscal
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

        Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function

    Public Shared Function GetCuentasContables_Tabla_Presupuesto2(ByVal DttxtId_PeridoFiscal As Integer) As DataSet
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataSet
        Dim DescripcionCuentaContable As String
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Distinct(Presupuestos.Descripcion),ModificacionesPresupuesto.Id_Periodo_Fiscal as Id_Periodo_Fiscal, ModificacionesPresupuesto.MontoAnterior as MontoAnterior, ModificacionesPresupuesto.MontoActual as  MontoActual FROM ModificacionesPresupuesto, Presupuestos WHERE ModificacionesPresupuesto.Cuenta_Contable = Presupuestos.Cuenta_Contable And ModificacionesPresupuesto.Id_Periodo_Fiscal =" & DttxtId_PeridoFiscal


            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            'cmd.Parameters.Add(New SqlParameter("@CUENTA_CONTABLE", SqlDbType.VarChar))
            'cmd.Parameters("@CUENTA_CONTABLE").Value = CuentaContable

            'cmd.Parameters.Add(New SqlParameter("@txtId_PeridoFiscal", SqlDbType.Int))
            'cmd.Parameters("@txtId_PeridoFiscal").Value = DttxtId_PeridoFiscal
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)






        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

        Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function


    Public Shared Function GetCuentasContables_Tabla_Presupuesto(ByVal DttxtId_PeridoFiscal As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim DescripcionCuentaContable As String
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String =
            "SELECT Cuenta_Contable, Descripcion  FROM PRESUPUESTOS WHERE Id_Periodo_Fiscal =" & DttxtId_PeridoFiscal & ""
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            'cmd.Parameters.Add(New SqlParameter("@CUENTA_CONTABLE", SqlDbType.VarChar))
            'cmd.Parameters("@CUENTA_CONTABLE").Value = CuentaContable

            'cmd.Parameters.Add(New SqlParameter("@txtId_PeridoFiscal", SqlDbType.Int))
            'cmd.Parameters("@txtId_PeridoFiscal").Value = DttxtId_PeridoFiscal
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)






        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

        Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function



    Public Function CargarPresupuestoPormes(ByVal Id_periodoFiscal As Integer, ByVal CuentaContable As String, ByVal txtmes As String) As Double



        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim DescripcionCuentaContable As String
        Dim MontoMes As Double = 0
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT " & txtmes & " FROM Presupuestos WHERE Id_Periodo_Fiscal =" & Id_periodoFiscal & " AND Cuenta_Contable = '" & CuentaContable & "' "
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)

            Dim fila As Integer = 0
            For fila = 0 To dt.Rows.Count - 1
                MontoMes = Convert.ToDouble(dt.Rows(fila)(txtmes).ToString())

            Next





        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

        Return MontoMes

    End Function


    Public Function CargarEstadoPresupuestoPormes(ByVal Id_periodoFiscal As Integer, ByVal CuentaContable As String, ByVal txtmes As String) As DataTable



        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        Dim DescripcionCuentaContable As String
        Dim Estado As String = ""
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")

            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String = "SELECT Estado, Anulado,Id FROM ModificacionesPresupuesto WHERE Id_Periodo_Fiscal =" & Id_periodoFiscal & " AND Cuenta_Contable = '" & CuentaContable & "'  AND Mes ='" & txtmes & "'"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90

            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)







        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

        Return dt

    End Function


    Public Shared Function BuscarFacturas_Proveedor(ByVal CodigoProv As Integer) As DataTable
        Dim cnn As SqlConnection = Nothing
        Dim dt As New DataTable
        ' Dentro de un Try/Catch por si se produce un error
        Try
            ' Obtenemos la cadena de conexión adecuada
            Dim sConn As String = Configuracion.Claves.Conexion("SeePos")
            cnn = New SqlConnection(sConn)
            cnn.Open()
            ' Creamos el comando para la consulta
            Dim cmd As SqlCommand = New SqlCommand
            Dim sel As String =
            "SELECT Factura, Fecha, TotalFactura, Cod_MonedaCompra FROM compras WHERE (FacturaCancelado = 0) AND (TipoCompra = 'CRE') AND (CodigoProv = " & CodigoProv & ") AND (dbo.SaldoFacturaCompra(GETDATE(), Factura, CodigoProv) <> 0)"
            cmd.CommandText = sel
            cmd.Connection = cnn
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 90
            ' Los parámetros usados en la cadena de la consulta 
            cmd.Parameters.Add(New SqlParameter("@Codigo", SqlDbType.Int))
            cmd.Parameters("@Codigo").Value = CodigoProv
            ' Creamos el dataAdapter y asignamos el comando de selección
            Dim da As New SqlDataAdapter
            da.SelectCommand = cmd
            ' Llenamos la tabla

            da.Fill(dt)

        Catch ex As System.Exception
            ' Si hay error, devolvemos un valor nulo.
            MsgBox(ex.ToString)
            Return Nothing
        Finally
            ' Por si se produce un error,
            ' comprobamos si en realidad el objeto Connection está iniciado,
            ' de ser así, lo cerramos.
            If Not cnn Is Nothing Then
                cnn.Close()
            End If
        End Try

        Return dt ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function


    Public Shared Function Cargar_Tabla_Generico(ByRef DataAdapter As SqlDataAdapter, ByVal SQLCommand As String, Optional ByVal NuevaConexionStr As String = "") As DataTable
        Dim StringConexion As String
        StringConexion = IIf(NuevaConexionStr = "", Configuracion.Claves.Conexion("SeePos"), NuevaConexionStr)
        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Tabla As New DataTable
        Dim Comando As SqlCommand = New SqlCommand
        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            DataAdapter.SelectCommand = Comando
            DataAdapter.Fill(Tabla)
        Catch ex As System.Exception
            MsgBox(ex.ToString) ' Si hay error, devolvemos un valor nulo.
            Return Nothing
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
        Return Tabla ' Devolvemos el objeto DataTable con los datos de la consulta
    End Function

    Public Shared Sub Llenar_Tabla_Generico(ByVal SQLCommand As String, ByRef Tabla As DataTable, Optional ByVal NuevaConexionStr As String = "")
        Dim StringConexion As String

        StringConexion = IIf(NuevaConexionStr = "", Configuracion.Claves.Conexion("Contabilidad"), NuevaConexionStr)

        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Comando As SqlCommand = New SqlCommand
        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = Comando
            Tabla.Clear()
            da.Fill(Tabla)
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta..") ' Si hay error, devolvemos un valor nulo.
            Exit Sub
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub

    Public Shared Sub Llenar_Tabla_Generico1(ByVal SQLCommand As String, ByRef Tabla As DataTable, Optional ByVal NuevaConexionStr As String = "")
        Dim StringConexion As String

        StringConexion = IIf(NuevaConexionStr = "", Configuracion.Claves.Conexion("SeePos"), NuevaConexionStr)

        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Comando As SqlCommand = New SqlCommand
        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = Comando
            Tabla.Clear()
            da.Fill(Tabla)
        Catch ex As System.Exception
            'MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta..") ' Si hay error, devolvemos un valor nulo.
            Exit Sub
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub
    Public Shared Sub Llenar_Tabla_SL(ByVal SQLCommand As String, ByRef Tabla As DataTable, Optional ByVal NuevaConexionStr As String = "")
        Dim StringConexion As String

        StringConexion = IIf(NuevaConexionStr = "", Configuracion.Claves.Conexion("SeePos"), NuevaConexionStr)

        Dim ConexionX As SqlConnection = New SqlConnection(StringConexion)
        Dim Comando As SqlCommand = New SqlCommand
        Try
            ConexionX.Open()
            Comando.CommandText = SQLCommand
            Comando.Connection = ConexionX
            Comando.CommandType = CommandType.Text
            Comando.CommandTimeout = 90
            Dim da As New SqlDataAdapter
            da.SelectCommand = Comando
            da.Fill(Tabla)
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Alerta..") ' Si hay error, devolvemos un valor nulo.
            Exit Sub
        Finally
            If Not ConexionX Is Nothing Then ' Por si se produce un error comprobamos si en realidad el objeto Connection está iniciado de ser así, lo cerramos.
                ConexionX.Close()
            End If
        End Try
    End Sub
    Public Function BuscaNumeroAsiento(ByVal InicioAsiento As String) As String
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim Numero As String
        Dim Max As String = "0"
        Dim Ceros, Length As Integer

        Try
            'BUSCA LOS NUMEROS DE ASIENTOS EXISTENTES PARA EL AÑO Y MES ESTABLECIDOS
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT NumAsiento from AsientosContables Where NumAsiento Like '" & InicioAsiento & "%'")

            While rs.Read

                Numero = rs("NumAsiento").Substring(9)  'SELECCIONA SOLO EL NUMERO DE CONSECUTIVO DEL ASIENTO SIN EL AÑO Y MES
                If CInt(Max) < CInt(Numero) Then        'VERIFICA SI EL NUMERO QUE ESTA LEYENDO ES EL MAYOR
                    Max = Numero                        'DE SER MAYOR SE LO ASIGNA AL NUMERO MAX
                End If
            End While
            rs.Close()

            If Max = 0 Then
                BuscaNumeroAsiento = InicioAsiento & "0001"  'ENVIA EL SIGUIENTE NUMERO DE ASIENTO
            Else
                '-----------------------------------------------------------
                'PARA SABER LA CANTIDAD DE CEROS QUE DEBE HABER EN EL CONSECUTIVO DEL ASIENTO
                Ceros = Max.TrimStart("0").Length
                Max = CInt(Max)
                Length = Max.Length
                Max += 1
                If Max.Length <> Length Then
                    Ceros += 1
                End If
                For i As Integer = 0 To (3 - Ceros)
                    InicioAsiento = InicioAsiento & "0"
                Next
                '-----------------------------------------------------------
                BuscaNumeroAsiento = InicioAsiento & Max  'ENVIA EL SIGUIENTE NUMERO DE ASIENTO
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Public Function ValidarPeriodo(ByVal Fecha As DateTime) As Boolean  'VALIDA SI ESTA EN EL MISMO PERIODO CONTABLE
        Dim cConexion As New Conexion                                   'O SI EL EL PERIODO ESTA CERRADO PARA PERMITIR O NO LA TRANSACCION
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try
            ValidarPeriodo = False
            'BUSCA EL MES Y EL AÑO DEL PERIODO QUE SE ENCUENTRA ACTIVO
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT Mes, Anno, Estado FROM Periodo where Estado = 0 and Cerrado=0")

            While rs.Read
                If Fecha.Year = rs("Anno") Then     'VERIFICA SI ESTA EN EL MISMO AÑO
                    If Fecha.Month = rs("Mes") Then 'VERIFICA SI ESTA EN EL MISMO MES
                        ValidarPeriodo = True       'EN CASO DE QUE SEA EL MISMO PERIODO
                    End If
                End If
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Public Function Periodo() As String
        Dim cConexion As New Conexion
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try
            'BUSCA EL MES Y EL AÑO DEL PERIODO QUE SE ENCUENTRA ACTIVO
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT Periodo FROM Periodo WHERE Activo = 1")

            While rs.Read
                Try
                    Periodo = rs("Periodo") 'OBTIENE EL PERIODO ACTUAL DE TRABAJO

                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Public Function TipoCambio(ByVal Fecha As DateTime, Optional ByVal Venta As Boolean = True) As Double
        Dim cConexion As New Conexion        'OBTIENE EL TIPO DE CAMBIO DE LA MONEDA DOLAR PARA LA FECHA
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim FechaMax As DateTime

        Try
            Fecha = FormatDateTime(Fecha, DateFormat.ShortDate)
            'BUSCA LOS TIPOS DE CAMBIO
            If Venta Then
                rs = cConexion.GetRecorset(cConexion.Conectar("", "Seguridad"), "SELECT ISNULL(ValorVenta,1) AS TipoCambio, Fecha FROM dbo.HistoricoMoneda WHERE Id_Moneda = 2 And Fecha <= dbo.DateOnlyFinal('" & Fecha & "') Order By Fecha Desc")
            Else
                rs = cConexion.GetRecorset(cConexion.Conectar("", "Seguridad"), "SELECT ISNULL(ValorCompra,1) AS TipoCambio, Fecha FROM dbo.HistoricoMoneda WHERE Id_Moneda = 2 And Fecha <= dbo.DateOnlyFinal('" & Fecha & "') Order By Fecha Desc")
            End If

            While rs.Read
                Try
                    If rs("Fecha") > FechaMax Then
                        FechaMax = rs("Fecha")
                        TipoCambio = rs("TipoCambio")
                        Return rs("TipoCambio")
                    End If

                Catch ex As SystemException
                    MsgBox(ex.Message)
                End Try
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Public Function ValidarPeriodoFiscal(ByVal Fecha As DateTime) As Boolean
        Dim cConexion As New Conexion                   'VALIDA SI ESTA EN EL MISMO PERIODO FISCAL
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try
            ValidarPeriodoFiscal = False
            'BUSCA LOS PERIODOS FISCALES ABIERTOS
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT FechaInicio, FechaFinal FROM PeriodoFiscal ")

            While rs.Read
                If Fecha >= rs("FechaInicio") Then
                    If Fecha <= rs("FechaFinal") Then
                        ValidarPeriodoFiscal = True     'SI ENCUENTRA UN PERIODO ABIERTO PARA LA FECHA
                    End If
                End If
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function


    Public Function BuscaPeriodo(ByVal Fecha As DateTime) As String
        Dim cConexion As New Conexion                   'BUSCA EL PERIODO DE LA TRANSACCIÓN DE ACUERDO AL PERIODO FISCAL
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader
        Dim Inicio, Final As DateTime

        Try
            'BUSCA LOS PERIODOS FISCALES ABIERTOS

            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT dbo.DateOnlyInicio(FechaInicio) AS FechaInicio, dbo.DateOnlyFinal(FechaFinal) AS FechaFinal FROM PeriodoFiscal WHERE '" & Fecha.ToString("dd/MM/yy") & "' BETWEEN FechaInicio AND FechaFinal")

            While rs.Read
                If Fecha >= rs("FechaInicio") Then
                    If Fecha <= rs("FechaFinal") Then
                        Inicio = rs("FechaInicio")
                        Final = rs("FechaFinal")
                        Fecha = CDate("01" & "/" & Fecha.Month & "/" & Fecha.Year)
                        Inicio = CDate("01" & "/" & Inicio.Month & "/" & Inicio.Year)
                        For i As Integer = 1 To 12
                            If Inicio < Fecha Then
                                Inicio = Inicio.AddMonths(1)
                            Else
                                BuscaPeriodo = i & "/" & Final.Year
                                Exit For
                            End If
                        Next
                    End If
                End If
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function

    Public Function ValidarPeriodoAsientoValuacion(ByVal Fecha As DateTime) As Boolean  'VALIDA SI ESTA EN EL MISMO PERIODO CONTABLE
        Dim cConexion As New Conexion                                   'O SI EL EL PERIODO ESTA CERRADO PARA PERMITIR O NO LA TRANSACCION
        Dim sqlConexion As New SqlConnection
        Dim rs As SqlDataReader

        Try
            ValidarPeriodoAsientoValuacion = False
            'BUSCA EL MES Y EL AÑO DEL PERIODO QUE SE ENCUENTRA ACTIVO
            rs = cConexion.GetRecorset(cConexion.Conectar("Contabilidad"), "SELECT Mes, Anno, Estado FROM Periodo where Activo = 1 and Cerrado=0")

            While rs.Read
                If Fecha.Year = rs("Anno") Then     'VERIFICA SI ESTA EN EL MISMO AÑO
                    If Fecha.Month = rs("Mes") Then 'VERIFICA SI ESTA EN EL MISMO MES
                        ValidarPeriodoAsientoValuacion = True       'EN CASO DE QUE SEA EL MISMO PERIODO
                    End If
                End If
            End While
            rs.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        Finally
            cConexion.DesConectar(sqlConexion)
        End Try
    End Function

    Public Shared Function ValidarAsientos(ByVal Asiento As DataTable, ByVal AsientoDetalle As DataTable, ByVal Moneda As Integer) As Boolean
        Try
            Dim TotalDebeEncabezadoDolar As Double = 0
            Dim TotalHaberEncabezadoDolar As Double = 0
            Dim TotalDebeDetalleDolar As Double = 0
            Dim TotalHaberDetalleDolar As Double = 0
            Dim TotalDebeEncabezadoColon As Double = 0
            Dim TotalHaberEncabezadoColon As Double = 0
            Dim TotalDebeDetalleColon As Double = 0
            Dim TotalHaberDetalleColon As Double = 0
            Dim TipoCambioEncabezado As Double = Asiento.Rows(0).Item("TipoCambio")
            Dim TipoCambioDetalle As Double = AsientoDetalle.Rows(0).Item("TipoCambio")

            If TipoCambioDetalle = TipoCambioEncabezado Then


                If Moneda = 1 Then
                    TotalDebeEncabezadoColon = Math.Round(Asiento.Rows(0).Item("TotalDebe"), 2)
                    TotalHaberEncabezadoColon = Math.Round(Asiento.Rows(0).Item("TotalHaber"), 2)
                    TotalDebeEncabezadoDolar = Math.Round(Asiento.Rows(0).Item("TotalDebe") / TipoCambioEncabezado, 2)
                    TotalHaberEncabezadoDolar = Math.Round(Asiento.Rows(0).Item("TotalHaber") / TipoCambioEncabezado, 2)
                Else
                    TotalDebeEncabezadoColon = Math.Round(Asiento.Rows(0).Item("TotalDebe") * TipoCambioEncabezado, 2)
                    TotalHaberEncabezadoColon = Math.Round(Asiento.Rows(0).Item("TotalHaber") * TipoCambioEncabezado, 2)
                    TotalDebeEncabezadoDolar = Math.Round(Asiento.Rows(0).Item("TotalDebe"), 2)
                    TotalHaberEncabezadoDolar = Math.Round(Asiento.Rows(0).Item("TotalHaber"), 2)
                End If


                For i As Integer = 0 To AsientoDetalle.Rows.Count - 1

                    If Moneda = 1 Then

                        If AsientoDetalle.Rows(i).Item("Debe") = True Then
                            TotalDebeDetalleColon += Math.Round(AsientoDetalle.Rows(i).Item("Monto"), 2)
                            TotalDebeDetalleDolar += Math.Round(AsientoDetalle.Rows(i).Item("Monto") / TipoCambioEncabezado, 2)
                        ElseIf AsientoDetalle.Rows(i).Item("Haber") Then
                            TotalHaberDetalleColon += Math.Round(AsientoDetalle.Rows(i).Item("Monto"))
                            TotalHaberDetalleDolar += Math.Round(AsientoDetalle.Rows(i).Item("Monto") / TipoCambioEncabezado, 2)
                        End If
                    Else

                        If AsientoDetalle.Rows(i).Item("Debe") = True Then
                            TotalDebeDetalleColon += Math.Round(AsientoDetalle.Rows(i).Item("Monto") * TipoCambioEncabezado, 2)
                            TotalDebeDetalleDolar += Math.Round(AsientoDetalle.Rows(i).Item("Monto"), 2)
                        ElseIf AsientoDetalle.Rows(i).Item("Haber") Then
                            TotalHaberDetalleColon += Math.Round(AsientoDetalle.Rows(i).Item("Monto") * TipoCambioEncabezado, 2)
                            TotalHaberDetalleDolar += Math.Round(AsientoDetalle.Rows(i).Item("Monto"), 2)
                        End If
                    End If

                Next

                If TotalDebeDetalleDolar = TotalDebeEncabezadoDolar And TotalHaberDetalleDolar = TotalHaberEncabezadoDolar And TotalDebeDetalleDolar = TotalHaberDetalleDolar And TotalDebeDetalleColon = TotalDebeEncabezadoColon And TotalHaberDetalleColon = TotalHaberEncabezadoColon And TotalDebeDetalleColon = TotalHaberDetalleColon Then
                    Return True

                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
