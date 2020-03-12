Imports System.Data.SqlClient
Imports System.Configuration

Public Class cls_Conexiones

   
    Public Shared Function Fn_Conector() As SqlConnection
        Dim _sqlconnection As New SqlConnection
        Try
            _sqlconnection.ConnectionString = cls_Datos.fn_StrConexion

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return _sqlconnection
    End Function

    Public Shared Sub Sp_CerrarConector(ByRef p_conector As SqlConnection)
        If p_conector.State <> ConnectionState.Closed Then
            p_conector.Close()
            p_conector.Dispose()
        End If
    End Sub
End Class
