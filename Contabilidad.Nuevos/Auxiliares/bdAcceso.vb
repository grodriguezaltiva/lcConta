Public Class bdAcceso
    Public Shared Sub Cargar(cmd As SqlClient.SqlCommand, dt As DataTable)
        Try
            dt.Rows.Clear()

            Dim con As New SqlClient.SqlConnection(Configuracion.Claves.Conexion("Contabilidad"))
            con.Open()
            cmd.Connection = con
            Dim adap As New SqlClient.SqlDataAdapter
            adap.SelectCommand = cmd
            adap.Fill(dt)
            con.Close()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
