Public Class frmResultado
    Sub New(ByRef _dts As dtsResultado)
        InitializeComponent()
        dts = _dts
        MonedaBS.DataSource = dts
        MonedaBS.DataMember = dts.Moneda.TableName
    End Sub

    Private Sub btMostrar_Click(sender As Object, e As EventArgs) Handles btMostrar.Click
        btMostrar.Enabled = False

        Reporte.Reporte(crv, rbBalance.Checked, rbMensual.Checked,
                        cbMoneda.SelectedValue, cbMoneda.Text, nuCantPeriodos.Value,
                        cbMes.SelectedIndex + 1, cbMes.Text, nuAño.Value, chExcluirCierre.Checked, nuNivel.Value)
        btMostrar.Enabled = True

    End Sub

    Private Sub frmResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuAño.Value = Now.Year
        cbMes.SelectedIndex = Now.Month - 1
        cbMoneda.SelectedIndex = 0

    End Sub
End Class