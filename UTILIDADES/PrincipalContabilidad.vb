Imports Utilidades
Public Module Principal
    Public Usuario As Usuario_Logeado
    Public IdUsuario As Integer = 0
    Public GetSettingConexion As String
    Public Login As New Frm_login("Seguridad")
    Public ModeExecute As String
    ' Private Declare Function GetVolumeInformation Lib "kernel32" Alias "GetVolumeInformationA" (ByVal lpRootPathName As String, ByVal pVolumeNameBuffer As String, ByVal nVolumeNameSize As Integer, ByRef lpVolumeSerialNumber As Integer, ByRef lpMaximumComponentLength As Integer, ByRef lpFileSystemFlags As Integer, ByVal lpFileSystemNameBuffer As String, ByVal nFileSystemNameSize As Integer) As Integer
    Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))

    Sub Main()
        Try
            Login.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Login.ShowDialog()
            If Login.conectado Then
                Usuario = Login.Usuario
                Dim dt As New DataTable
                Dim cm As New SqlClient.SqlCommand
                cm.CommandText = "Select ID From Usuarios where Id_Usuario = @Ced"
                cm.Parameters.AddWithValue("@Ced", Usuario.Cedula)
                cls_Datos.consulta(cm, dt, "Contabilidad")
                If dt.Rows.Count > 0 Then
                    IdUsuario = dt.Rows(0).Item("ID")
                End If

                If Environment.GetCommandLineArgs.Length > 1 Then ModeExecute = Environment.GetCommandLineArgs(1)
                Application.Run(New Contabilidad.MainForm(Login.Usuario))
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
