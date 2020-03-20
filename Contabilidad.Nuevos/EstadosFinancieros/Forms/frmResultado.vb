Imports System.ComponentModel

Public Class frmResultado
    Sub New(ByRef _dts As dtsEstadosFinancieros)
        InitializeComponent()
        dts = _dts
        MonedaBS.DataSource = dts
        MonedaBS.DataMember = dts.Moneda.TableName
    End Sub
    Dim EsBalance As Boolean, EsMensual As Boolean, Moneda As Integer, MonedaNombre As String, CantPeriodos As Integer, Mes As Integer, MesNombre As String, Año As Integer, ExcluirCierre As Boolean, Nivel As Integer
    Private Sub btMostrar_Click(sender As Object, e As EventArgs) Handles btMostrar.Click
        mostrar()
    End Sub
    Sub mostrar()
        lbCargando.Visible = True
        pnParametros.Enabled = False
        crv.Enabled = False
        EsBalance = rbBalance.Checked : EsMensual = rbMensual.Checked : Moneda = cbMoneda.SelectedValue
        MonedaNombre = cbMoneda.Text : CantPeriodos = 2 : Mes = cbMes.SelectedIndex
        MesNombre = cbMes.Text : Año = nuAño.Value : ExcluirCierre = False : Nivel = nuNivel.Value

        bwCargar.RunWorkerAsync()

    End Sub
    Dim rtp As rptBalanceSituacion
    Private Sub frmResultado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nuAño.Value = Now.Year
        cbMes.SelectedIndex = Now.Month - 1
        cbMoneda.SelectedIndex = 0

    End Sub

    Private Sub bwCargar_DoWork(sender As Object, e As ComponentModel.DoWorkEventArgs) Handles bwCargar.DoWork
        cargar()
    End Sub
    Private Sub cargar()

        rtp = EstadosFinancieros.BalanceSitacion(EsBalance, EsMensual,
                        Moneda, MonedaNombre, CantPeriodos,
                        Mes + 1, MesNombre, Año, ExcluirCierre, Nivel)

    End Sub

    Private Sub bwCargar_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwCargar.RunWorkerCompleted
        lbCargando.Visible = False
        crv.ReportSource = rtp
        crv.Enabled = True

        pnParametros.Enabled = True

    End Sub
End Class