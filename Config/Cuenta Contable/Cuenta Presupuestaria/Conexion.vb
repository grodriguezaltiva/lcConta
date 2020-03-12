Imports System.Data.SqlClient
Public Class ClassConexion
    Public sQlconexion As New SqlConnection
    Public SQLStringConexion As String

    Public Function Conectar(Optional ByVal Empresa As String = "SeeSOFT", Optional ByVal Modulo As String = "Contabilidad") As SqlConnection
        'Dim strConexion As String
        If sQlconexion.State <> ConnectionState.Open Then
            If Modulo = "SeePOS" Then
                SQLStringConexion = Configuracion.Claves.Conexion("Contabilidad")
            Else
                SQLStringConexion = Configuracion.Claves.Conexion(Modulo)
            End If
            sQlconexion.ConnectionString = SQLStringConexion
            sQlconexion.Open()
        Else
        End If
        Return sQlconexion
    End Function
    Public Function AlphabeticSort(ByVal dtTable As DataTable, ByVal sortOrder As Integer) As DataTable
        Dim dsSorted As New DataSet
        Dim columnKey As String = "MontoDebe"
        Dim sortDirection As String = ""
        Dim sortFormat As String = "{0} {1}"
        Select Case sortOrder
            Case 0
                sortDirection = "ASC"
            Case 1
                sortDirection = "DESC"
            Case Else
                sortDirection = "ASC"
        End Select
        dtTable.DefaultView.Sort = String.Format(sortFormat, columnKey, sortDirection)

        Return dtTable.DefaultView.Table
    End Function

    Public Sub DesConectar(ByRef sqlConexion As SqlConnection)
        sqlConexion.Close()
        sqlConexion.Dispose()
    End Sub

    ' DEVUELVE EL DataReader DE LA CONSULTA
    Public Function GetRecorset(ByRef conexion As SqlConnection, ByVal StrQuery As String) As SqlDataReader
        Dim Command As SqlCommand
        Dim SqlDatos As SqlDataReader
        Dim Mensaje As String
        Try
            Command = New SqlCommand(StrQuery, conexion)
            SqlDatos = Command.ExecuteReader
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return SqlDatos
    End Function

    'DEVUELVE  EL RESULTADO DE LA CONSULTA
    Public Function SlqExecuteScalar(ByRef Conexion As SqlConnection, ByVal StrQuery As String) As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Command = New SqlCommand(StrQuery, Conexion)
        Try
            Dato = Command.ExecuteScalar()
            If IsDBNull(Dato) Then Dato = 0
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Dato
    End Function

    Public Function SQLExeScalar(ByVal StrQuery As String) As String
        Dim Command As SqlCommand
        Dim Dato As String
        Dim Mensaje As String
        Command = New SqlCommand(StrQuery, Conectar)
        Try
            Dato = Command.ExecuteScalar()
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Dato
    End Function

    Public Function SlqExecute(ByRef conexion As SqlConnection, ByVal strQuery As String) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand(strQuery, conexion)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function

    Public Function AddNewRecord(ByRef Table As Object, ByRef Campos As Object, ByRef Datos As Object) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand("INSERT INTO " & Table & " (" & Campos & ") VALUES (" & Datos & ")", Conectar)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje

    End Function



    Public Function AgregarValoresPresupuestos(ByVal Id_PeriodoFiscal As Integer, ByVal CuentaContable As String, ByVal Descripcion As String, ByVal Id_nivel As Integer, ByVal ParentId As Integer, ByVal IdCuenta As Integer, ByVal OCTUBRE As Double, _
    ByVal NOVIEMBRE As Double, ByVal DICIEMBRE As Double, ByVal ENERO As Double, ByVal FEBRERO As Double, ByVal MARZO As Double, ByVal ABRIL As Double, ByVal MAYO As Double, ByVal JUNIO As Double, ByVal JULIO As Double, ByVal AGOSTO As Double, ByVal SEPTIEMBRE As Double, ByVal TOTAL As Double, ByVal Estado As String) As String


        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand("Exec  Proc_CrearPresupuesto  " & Id_PeriodoFiscal & ",'" & CuentaContable & "','" & Descripcion & "'," & Id_nivel & "," & ParentId & "," & IdCuenta & "," & OCTUBRE & "," & NOVIEMBRE & "," & DICIEMBRE & "," & ENERO & " ," & FEBRERO & "," & MARZO & "," & ABRIL & "," & MAYO & " ," & JUNIO & "," & JULIO & "," & AGOSTO & "," & SEPTIEMBRE & "," & TOTAL & "," & Estado, Conectar)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje

    End Function


    Public Function ActualizarPresupuestos(ByVal pId_Periodo_Fiscal As Integer, ByVal pMes As String, ByVal pCuenta_Contable As String, ByVal pId_Usuario As String, ByVal pAnulado As String, ByVal pMontoAnterior As Double, ByVal pMontoActual As Double, ByVal pEstado As String) As String

        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand("Exec  MODIFICAR_PRESUPUESTO  " & pId_Periodo_Fiscal & ",'" & pMes & "','" & pCuenta_Contable & "','" & pId_Usuario & "','" & pAnulado & "'," & pMontoAnterior & "," & pMontoActual & ",'" & pEstado & "'", Conectar)
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje

    End Function





    Public Function AprobarPresupuesto(ByVal Id_PeriodoFiscal As Integer, ByVal Estado As String) As String


        Dim Command As SqlCommand
        Dim Mensaje As String
        Command = New SqlCommand("Exec  PROC_APROBAR_PRESUPUESTO  @Id_PeriodoFiscal , @Estado ", Conectar)
        Try
            Command.Parameters.Add(New SqlParameter("@Id_PeriodoFiscal", SqlDbType.Int))
            Command.Parameters("@Id_PeriodoFiscal").Value = Id_PeriodoFiscal

            Command.Parameters.Add(New SqlParameter("@Estado", SqlDbType.Char))
            Command.Parameters("@Estado").Value = Estado

            Command.ExecuteNonQuery()
            MsgBox("Presupuestos Aprobados Satisfactoriamente", MsgBoxStyle.Exclamation, "Aprobados...")
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje

    End Function

    '*******************************************************************
    'FUNCION QUE PERMITE LA ACTUALIZACION DE REGISTROS SEGUN DETERMINADA
    '*******************************************************************
    Public Function UpdateRecords(ByRef Table As Object, ByRef Datos As Object, ByRef Condicion As Object, Optional ByVal Modulo As String = "SeePOS") As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        If Condicion <> "" Then
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos & " WHERE " & Condicion, Conectar("", Modulo))
        Else
            Command = New SqlCommand("UPDATE " & Table & " SET " & Datos, Conectar("", Modulo))
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function

    '*******************************************************************
    'FUNCION DEFINIDA PARA LA ELIMINACION DE UNO O VARIOS REGISTROS 
    '*******************************************************************
    Public Function DeleteRecords(ByRef Table As String, ByRef Condicion As Object) As String
        Dim Command As SqlCommand
        Dim Mensaje As String
        If Condicion = "" Then
            Command = New SqlCommand("DELETE FROM " & Table, Conectar)
        Else
            Command = New SqlCommand("DELETE FROM " & Table & " WHERE " & Condicion, Conectar)
        End If
        Try
            Command.ExecuteNonQuery()
        Catch ex As Exception
            Mensaje = ex.Message
            'MsgBox("Favor Comunicar el siguiente Error a su Empresa Proveedora de Software.:" & vbCrLf & Mensaje, MsgBoxStyle.Critical, "Alerta...")
        Finally
            Command.Dispose()
            Command = Nothing
        End Try
        Return Mensaje
    End Function

    Public Sub GetDataSet(ByRef conexion As SqlConnection, ByVal StrQuery As String, ByRef DataS As DataSet, ByVal tabla As String)
        Dim mensaje As String
        Dim adapter As New SqlDataAdapter(StrQuery, conexion)
        If conexion.State <> ConnectionState.Open Then conexion.Open()
        Try
            adapter.Fill(DataS, tabla)
        Catch ex As Exception
            mensaje = ex.Message
        Finally
            adapter.Dispose()
            adapter = Nothing
        End Try
    End Sub
End Class


