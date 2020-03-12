Public Class frmCajas
    Private datos As clsCaja
    Private enlaceCaja As BindingSource

    Sub New()

        InitializeComponent()
        enlaceCaja = New BindingSource
        datos = New clsCaja
        enlaceCaja.DataSource = datos
        enlaceCaja.DataMember = datos.vs_CO_Caja.TableName
        dgvGastos.AutoGenerateColumns = False
        dgvGastos.DataSource = enlaceCaja
        dtpF1.Value = Now.AddDays(-30).Date
        dtpF2.Value = Now.Date
        chEntreFechas.Checked = True


    End Sub
    Private Sub spBuscar()
        datos.spFiltros(txtBuscar.Text, chEntreFechas.Checked, dtpF1.Value, dtpF2.Value, chVerReintegrosAnulados.Checked)

    End Sub
    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        Caja.Crear()

    End Sub

    Private Sub btBuscar_Click(sender As Object, e As EventArgs) Handles btBuscar.Click
        spBuscar()

    End Sub
    Private Sub AccionBuscar(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged, chEntreFechas.CheckedChanged, chVerReintegrosAnulados.CheckedChanged, dtpF1.ValueChanged, dtpF2.ValueChanged
        spActivarFechas()
        spBuscar()

    End Sub

    Sub spActivarFechas()
        dtpF1.Visible = chEntreFechas.Checked
        dtpF2.Visible = chEntreFechas.Checked
    End Sub
    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            spBuscar()

        End If
    End Sub

    Private Sub btVer_Click(sender As Object, e As EventArgs) Handles btVer.Click
        spAbrir()

    End Sub

    Sub spAbrir()
        Caja.Abrir(enlaceCaja.Current("IdCheque"))

    End Sub

    Private Sub dgvGastos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGastos.CellDoubleClick
        spAbrir()

    End Sub
End Class