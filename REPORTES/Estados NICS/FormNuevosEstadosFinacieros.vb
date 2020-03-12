Public Class FormNuevosEstadosFinacieros

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click
        sp_Generar()
        sp_Imprimir()
    End Sub
    Sub sp_Imprimir()
        Dim f As New frmReporteEstadosFinancieros
        f.cod_moneda = cboMoneda.SelectedValue
        f.id_periodo1 = cboPeriodoT1.SelectedValue
        f.id_periodo2 = cboPeriodoT2.SelectedValue
        f._pP1 = cboPeriodoT1.Text
        f._pP2 = cboPeriodoT2.Text
        f._IdP1 = cboPeriodoT1.SelectedValue
        f._IdP2 = cboPeriodoT2.SelectedValue
        f.Show()

    End Sub
    Function fn_Periodo2(ByVal cuenta As String, ByVal cierre As Boolean) As Double
        Dim saldo As Double = 0
        If cierre Then
            For i As Integer = 0 To periodo2_cierre.Rows.Count - 1
                If cuenta.Equals(periodo2_cierre.Rows(i).Item("CuentaContable")) Then

                    If cboMoneda.SelectedValue = 1 Then

                        Return periodo2_cierre.Rows(i).Item("SaldoPeriodo")

                    Else
                        Return periodo2_cierre.Rows(i).Item("SaldoPeriodoD")

                    End If

                End If

            Next
        Else
            For i As Integer = 0 To periodo2_sinCierre.Rows.Count - 1
                If cuenta.Equals(periodo2_sinCierre.Rows(i).Item("CuentaContable")) Then

                    If cboMoneda.SelectedValue = 1 Then

                        Return periodo2_sinCierre.Rows(i).Item("SaldoPeriodo")

                    Else
                        Return periodo2_sinCierre.Rows(i).Item("SaldoPeriodoD")

                    End If

                End If

            Next
        End If
    End Function
    Sub sp_Generar()
        sp_llenarPeriodo(cboPeriodoT1.SelectedValue, periodo1_cierre, 0)
        sp_llenarPeriodo(cboPeriodoT2.SelectedValue, periodo2_cierre, 0)

        sp_llenarPeriodo(cboPeriodoT1.SelectedValue, periodo1_sinCierre, 1)
        sp_llenarPeriodo(cboPeriodoT2.SelectedValue, periodo2_sinCierre, 1)
        Dim cnx As New Conexion
        cnx.Conectar("SeeSoft", "Contabilidad")

        Dim str As String = "DELETE FROM [Contabilidad].[dbo].[Estado1] DELETE FROM  [Contabilidad].[dbo].[Estado2]"
        For i As Integer = 0 To periodo1_cierre.Rows.Count - 1
            periodo1_cierre.Rows(i).Item("Periodo2") = fn_Periodo2(periodo1_cierre.Rows(i).Item("CuentaContable"), True)

        Next
        For i As Integer = 0 To periodo1_sinCierre.Rows.Count - 1
            periodo1_sinCierre.Rows(i).Item("Periodo2") = fn_Periodo2(periodo1_sinCierre.Rows(i).Item("CuentaContable"), False)
        Next
        str &= fnCrearEstado(periodo1_cierre, "Estado1")
        str &= fnCrearEstado(periodo2_sinCierre, "Estado2")
        Dim mensaje As String = ""
        mensaje &= cnx.SlqExecute(cnx.sQlconexion, str)
        If mensaje.Equals("") Then
            MsgBox("Datos Generados", MsgBoxStyle.OkOnly)
        Else
            MsgBox(mensaje, MsgBoxStyle.OkOnly)
        End If        
    End Sub

    Private ConConta As String = Configuracion.Claves.Conexion("Contabilidad")
    Private CuentaUtilidad As String
    Private CuentaMadreUtilidad As String
    Private CuentaMadreUtilidad2 As String

    Private Sub GetCuentaUtilidad()
        Dim dts As New DataTable
        cFunciones.Llenar_Tabla_Generico("select cc.CuentaContable, cc.CuentaMadre from SettingCuentaContable as sc inner join CuentaContable  as cc on cc.id = sc.IdPeriodo", dts, Me.ConConta)
        If dts.Rows.Count > 0 Then
            Me.CuentaUtilidad = dts.Rows(0).Item(0)
            Me.CuentaMadreUtilidad = dts.Rows(0).Item(1)
            Dim dd As New DataTable
            cFunciones.Llenar_Tabla_Generico("select CuentaMadre from CuentaContable where CuentaContable = '" & Me.CuentaMadreUtilidad & "'", dd, Me.ConConta)
            If dd.Rows.Count > 0 Then
                Me.CuentaMadreUtilidad2 = dd.Rows(0).Item(0)
            End If            
        Else
            MsgBox("Antes de proseguir debe de configurar una cuenta de utilidad.", MsgBoxStyle.Exclamation, Text)
        End If
    End Sub
    Private Function getUtilidad(ByVal _periodo1 As String, ByVal _periodo2 As Integer) As DataTable
        Try
            Dim dts As New DataTable
            cFunciones.Llenar_Tabla_Generico("EXEC getUtilidadPerio2 " & _periodo1 & ", " & _periodo2, dts, Me.ConConta)
            Return dts
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Text)
        End Try
    End Function

    Function fnCrearEstado(ByVal periodo1 As DataTable, ByVal Estado As String) As String
        Dim UtiP1, UtiP2, temp1, temp2 As Decimal
        Dim str As String = ""

        Dim dts1 As New DataTable
        dts1 = Me.getUtilidad(cboPeriodoT1.SelectedValue, cboPeriodoT2.SelectedValue)
        If Me.cboMoneda.SelectedValue = 1 Then
            UtiP1 = dts1.Rows(0).Item("Utilidad1C")
            UtiP2 = dts1.Rows(0).Item("Utilidad2C")
        ElseIf Me.cboMoneda.SelectedValue = 2 Then
            UtiP1 = dts1.Rows(0).Item("Utilidad1D")
            UtiP2 = dts1.Rows(0).Item("Utilidad2D")
        End If

        For i As Integer = 0 To periodo1.Rows.Count - 1
            If cboMoneda.SelectedValue = 1 Then

                If periodo1.Rows(i).Item("CuentaContable") = Me.CuentaMadreUtilidad Or periodo1.Rows(i).Item("CuentaContable") = Me.CuentaUtilidad Or periodo1.Rows(i).Item("CuentaContable") = Me.CuentaMadreUtilidad2 Then
                    temp1 = UtiP1
                    temp2 = UtiP2
                Else
                    temp1 = 0
                    temp2 = 0
                End If

                If periodo1.Rows(i).Item("Nivel") <= 1 Then

                    str &= " INSERT INTO [Contabilidad].[dbo].[" & Estado & "]  ([CuentaContable]  ,[Descripcion]  ,[Notas]  ,[Periodo1]  ,[Periodo2]  ,[Nivel]  ,[Acumulado]) " & _
      "  VALUES ('" & periodo1.Rows(i).Item("CuentaContable") & "' ,'" & periodo1.Rows(i).Item("Descripcion") & "','" & periodo1.Rows(i).Item("Notas") & "'," & periodo1.Rows(i).Item("SaldoPeriodo") + temp1 & ",'" & periodo1.Rows(i).Item("Periodo2") + temp2 & "', " & periodo1.Rows(i).Item("Nivel") & ",0)"

                    Dim xCuenta As String = periodo1.Rows(i).Item("CuentaContable")
                    xCuenta = xCuenta.Replace("00", "xx")
                    str &= " INSERT INTO [Contabilidad].[dbo].[" & Estado & "]  ([CuentaContable]  ,[Descripcion]  ,[Notas]  ,[Periodo1]  ,[Periodo2]  ,[Nivel]  ,[Acumulado]) " & _
            "  VALUES ('" & xCuenta & "' ,'Total " & periodo1.Rows(i).Item("Descripcion") & "','" & periodo1.Rows(i).Item("Notas") & "'," & periodo1.Rows(i).Item("SaldoPeriodo") + temp1 & ",'" & periodo1.Rows(i).Item("Periodo2") + temp2 & "', " & periodo1.Rows(i).Item("Nivel") & ",0)"

                Else

                    str &= " INSERT INTO [Contabilidad].[dbo].[" & Estado & "]  ([CuentaContable]  ,[Descripcion]  ,[Notas]  ,[Periodo1]  ,[Periodo2]  ,[Nivel]  ,[Acumulado]) " & _
         "  VALUES ('" & periodo1.Rows(i).Item("CuentaContable") & "' ,'" & periodo1.Rows(i).Item("Descripcion") & "','" & periodo1.Rows(i).Item("Notas") & "'," & periodo1.Rows(i).Item("SaldoPeriodo") + temp1 & ",'" & periodo1.Rows(i).Item("Periodo2") + temp2 & "', " & periodo1.Rows(i).Item("Nivel") & ",0)"

                End If

            Else

                If periodo1.Rows(i).Item("CuentaContable") = Me.CuentaMadreUtilidad Or periodo1.Rows(i).Item("CuentaContable") = Me.CuentaUtilidad Or periodo1.Rows(i).Item("CuentaContable") = Me.CuentaMadreUtilidad2 Then
                    temp1 = UtiP1
                    temp2 = UtiP2
                Else
                    temp1 = 0
                    temp2 = 0
                End If

                If periodo1.Rows(i).Item("Nivel") <= 1 Then

                    str &= " INSERT INTO [Contabilidad].[dbo].[" & Estado & "]  ([CuentaContable]  ,[Descripcion]  ,[Notas]  ,[Periodo1]  ,[Periodo2]  ,[Nivel]  ,[Acumulado]) " & _
    "  VALUES ('" & periodo1.Rows(i).Item("CuentaContable") & "' ,'" & periodo1.Rows(i).Item("Descripcion") & "','" & periodo1.Rows(i).Item("Notas") & "'," & periodo1.Rows(i).Item("SaldoPeriodoD") + temp1 & ",'" & periodo1.Rows(i).Item("Periodo2") + temp2 & "', " & periodo1.Rows(i).Item("Nivel") & ",0)"

                    Dim xCuenta As String = periodo1.Rows(i).Item("CuentaContable")
                    xCuenta = xCuenta.Replace("00", "xx")
                    str &= " INSERT INTO [Contabilidad].[dbo].[" & Estado & "]  ([CuentaContable]  ,[Descripcion]  ,[Notas]  ,[Periodo1]  ,[Periodo2]  ,[Nivel]  ,[Acumulado]) " & _
    "  VALUES ('" & xCuenta & "' ,'Total " & periodo1.Rows(i).Item("Descripcion") & "','" & periodo1.Rows(i).Item("Notas") & "'," & periodo1.Rows(i).Item("SaldoPeriodoD") + temp1 & ",'" & periodo1.Rows(i).Item("Periodo2") + temp2 & "', " & periodo1.Rows(i).Item("Nivel") & ",0)"
                Else
                    str &= " INSERT INTO [Contabilidad].[dbo].[" & Estado & "]  ([CuentaContable]  ,[Descripcion]  ,[Notas]  ,[Periodo1]  ,[Periodo2]  ,[Nivel]  ,[Acumulado]) " & _
       "  VALUES ('" & periodo1.Rows(i).Item("CuentaContable") & "' ,'" & periodo1.Rows(i).Item("Descripcion") & "','" & periodo1.Rows(i).Item("Notas") & "'," & periodo1.Rows(i).Item("SaldoPeriodoD") + temp1 & ",'" & periodo1.Rows(i).Item("Periodo2") + temp2 & "', " & periodo1.Rows(i).Item("Nivel") & ",0)"

                End If

            End If
        Next
        Return str
    End Function

    Dim periodo1_cierre As New DataTable
    Dim periodo2_cierre As New DataTable
    Dim periodo1_sinCierre As New DataTable
    Dim periodo2_sinCierre As New DataTable

    Sub sp_llenarPeriodo(ByVal Periodo As Integer, ByRef p As DataTable, ByRef sinCierre As Integer)
        Dim sqlCMD As New SqlClient.SqlCommand
        sqlCMD.CommandText = "SELECT c.Id, c.FechaGenerado, c.Reversado, c.IdPeriodoFiscal, c.IdPeriodoTrabajo, c.CuentaContable, c.Descripcion, c.Nivel, c.Tipo, cc.Notas, c.IdCuenta, c.ParentId,  c.Inactivo, c.SaldoAnterior, c.MovHaber, c.MovDebe, c.SaldoMov, c.SaldoPeriodo, c.SinAsientoCierre, c.SaldoAnteriorD, c.MovHaberD, c.MovDebeD, c.SaldoMovD,  c.SaldoPeriodoD, 0 as Periodo2 FROM CierresPeriodos AS c INNER JOIN  CuentaContable AS cc ON c.CuentaContable = cc.CuentaContable WHERE (c.IdPeriodoTrabajo = " & Periodo & ") AND (c.Reversado = 0) AND (c.SinAsientoCierre = " & sinCierre & ")"
        cFunciones.Llenar_Tabla_Generico(sqlCMD, p, Configuracion.Claves.Conexion("Contabilidad"))

    End Sub

    Dim formato As New DataTable
    Private Sub FormNuevosEstadosFinacieros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DstNICs1.Periodo1' Puede moverla o quitarla según sea necesario.
        Periodo1TableAdapter.Connection.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
        Me.Periodo1TableAdapter.Fill(Me.DstNICs1.Periodo1)
        'TODO: esta línea de código carga datos en la tabla 'DstNICs1.Moneda' Puede moverla o quitarla según sea necesario.
        'Me.MonedaTableAdapter.Fill(Me.DstNICs1.Moneda)
        'TODO: esta línea de código carga datos en la tabla 'DstNICs1.PeriodoFiscal' Puede moverla o quitarla según sea necesario.
        ' Me.PeriodoFiscalTableAdapter.Fill(Me.DstNICs1.PeriodoFiscal)
        cargarPeriodosFiscales()
        'TODO: esta línea de código carga datos en la tabla 'DstNICs1.Periodo' Puede moverla o quitarla según sea necesario.
        'Me.PeriodoTableAdapter.Fill(Me.DstNICs1.Periodo)
        cFunciones.Llenar_Tabla_Generico("Select * From Moneda", DstNICs1.Moneda, Configuracion.Claves.Conexion("Seguridad"))
        'cFunciones.Llenar_Tabla_Generico("Select * From FormatoCuenta", formato, Configuracion.Claves.Conexion("Contabilidad"))
        'If formato.Rows.Count > 0 Then
        '    Me.numNiveles.Maximum = formato.Rows(0).Item("Niveles")
        '    Me.numNiveles.Value = formato.Rows(0).Item("Niveles")
        'End If
        Me.GetCuentaUtilidad()
    End Sub
    Sub cargarPeriodosFiscales()
        cFunciones.Llenar_Tabla_Generico("Select * From PeriodoFiscal ", DstNICs1.PeriodoFiscal, Configuracion.Claves.Conexion("Contabilidad"))
        For i As Integer = 0 To DstNICs1.PeriodoFiscal.Count - 1
            DstNICs1.PeriodoFiscal(i).Anno = Format(DstNICs1.PeriodoFiscal(i).FechaFinal.Date, "yyyy")

        Next
    End Sub

    Private Sub cboPeriodoFiscal1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoFiscal1.SelectedIndexChanged
        cargarPeriodo1()
    End Sub

    Private Sub cboPeriodoFiscal2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoFiscal2.SelectedIndexChanged
        cargarPeriodo2()

    End Sub
    Sub cargarPeriodo1()
        If bdsPeriodoF1.Count > 0 And cboPeriodoFiscal1.SelectedIndex >= 0 Then
            cFunciones.Llenar_Tabla_Generico("Select * From Periodo Where Cerrado = 1 AND Id_PeriodoFiscal = " & cboPeriodoFiscal1.SelectedValue & " Order By Anno, Mes", DstNICs1.Periodo, Configuracion.Claves.Conexion("Contabilidad"))

        End If


    End Sub
    Sub cargarPeriodo2()
        If bdsPeriodoF2.Count > 0 And cboPeriodoFiscal2.SelectedIndex >= 0 Then
            cFunciones.Llenar_Tabla_Generico("Select * From Periodo Where Cerrado = 1 AND Id_PeriodoFiscal = " & cboPeriodoFiscal2.SelectedValue & " Order By Anno, Mes", DstNICs1.Periodo1, Configuracion.Claves.Conexion("Contabilidad"))

        End If
    End Sub

    Private Sub cboPeriodoT1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPeriodoT1.SelectedIndexChanged

    End Sub
End Class