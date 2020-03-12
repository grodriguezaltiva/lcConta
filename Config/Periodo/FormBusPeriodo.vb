Public Class FormBusPeriodo

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        cFunciones.Llenar_Tabla_Generico("Select * From Periodo  WHERE Anno LIKE '%" & TextBox1.Text & "%' OR Mes LIKE '%" & Me.TextBox1.Text & "%' Order By Anno, Mes", DsPeriodo.Periodo, Configuracion.Claves.Conexion("Contabilidad"))

    End Sub

    Private Sub FormBusPeriodo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cFunciones.Llenar_Tabla_Generico("Select * From Periodo Order By Anno DESC, Mes DESC", DsPeriodo.Periodo, Configuracion.Claves.Conexion("Contabilidad"))


    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        DialogResult = Windows.Forms.DialogResult.OK
        Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Close()

    End Sub
End Class