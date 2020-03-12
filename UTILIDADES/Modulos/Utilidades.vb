Imports System.Data.SqlClient
Public Class Utilidades
    Public SQLConex As New SqlConnection
    Dim SQLStr As String
    Public Command As SqlCommand

    Public Function Conectar() As SqlConnection
        If SQLConex.State <> ConnectionState.Open Then
            SQLConex.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            SQLConex.Open()
            Return SQLConex
        End If
    End Function

    Public Sub Desconectar()
        SQLConex.Close()
        SQLConex.Dispose()
    End Sub

    Public Function Existe(ByVal Pid As Integer) As Boolean
        Existe = False
        SQLStr = "SELECT* FROM TiposDocumentos WHERE Id = " & Pid
        Command = New SqlCommand(SQLStr, Conectar)
        If Command.ExecuteScalar() = Pid Then
            Existe = True
        End If
        Desconectar()
    End Function

    Public Sub RegistrarTiposDoc(ByVal Pid As Integer, ByVal Pdesc As String)
        Command = New SqlCommand("INSERT INTO TiposDocumentos (Id, Descripcion) Values (" & Pid & ", '" & Pdesc & "')", Conectar)
        Command.ExecuteNonQuery()
        Desconectar()
    End Sub

    Public Sub ModificarTiposDoc(ByVal Pid As Integer, ByVal Pdesc As String)
        Command = New SqlCommand("UPDATE TiposDocumentos SET Descripcion = '" & Pdesc & "' WHERE Id = " & Pid, Conectar)
        Command.ExecuteNonQuery()
        Desconectar()
    End Sub

    Public Sub EliminarTiposDoc(ByVal Pid As Integer)
        Command = New SqlCommand("DELETE FROM TiposDocumentos WHERE Id = " & Pid, Conectar)
        Command.ExecuteNonQuery()
        Desconectar()
    End Sub
End Class
