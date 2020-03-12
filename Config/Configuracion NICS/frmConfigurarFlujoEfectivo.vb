Public Class frmConfigurarFlujoEfectivo

    Private Sub frmConfigurarFlujoEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DtsGeneraNotas1.CuentaContable' Puede moverla o quitarla según sea necesario.
        CuentaContableTableAdapter.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        Me.CuentaContableTableAdapter.Fill(Me.DtsGeneraNotas1.CuentaContable)
        'TODO: esta línea de código carga datos en la tabla 'DtsGeneraNotas1.tbConfiguracionFlujoEfectivo' Puede moverla o quitarla según sea necesario.
        TbConfiguracionFlujoEfectivoTableAdapter.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        Me.TbConfiguracionFlujoEfectivoTableAdapter.Fill(Me.DtsGeneraNotas1.tbConfiguracionFlujoEfectivo)

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            If MsgBox("¿Desea guardar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            BindingContext(Me.DtsGeneraNotas1, "tbConfiguracionFlujoEfectivo").EndCurrentEdit()
            TbConfiguracionFlujoEfectivoTableAdapter.Update(DtsGeneraNotas1.tbConfiguracionFlujoEfectivo)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        If MsgBox("¿Desea quitar esta linea?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BindingContext(Me.DtsGeneraNotas1, "tbConfiguracionFlujoEfectivo").RemoveAt(BindingContext(Me.DtsGeneraNotas1, "tbConfiguracionFlujoEfectivo").Position)
            BindingContext(Me.DtsGeneraNotas1, "tbConfiguracionFlujoEfectivo").EndCurrentEdit()
        End If
    End Sub
End Class