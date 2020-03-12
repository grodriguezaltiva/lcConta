Public Class frmGastosComparativo

    Private Function GetMesContable(ByVal _Mes As Integer) As Integer
        Select Case _Mes
            Case 1 : Return 4
            Case 2 : Return 5
            Case 3 : Return 6
            Case 4 : Return 7
            Case 5 : Return 8
            Case 6 : Return 9
            Case 7 : Return 10
            Case 8 : Return 11
            Case 9 : Return 12
            Case 10 : Return 1
            Case 11 : Return 2
            Case 12 : Return 3
        End Select
    End Function

    Private Sub Cargar_Datos()
        Dim dtAnyos As New DataTable
        Dim dtMeses As New DataTable

        cFunciones.Llenar_Tabla_Generico("select distinct anno from contabilidad.dbo.Periodo order by anno", dtAnyos, Configuracion.Claves.Conexion("Contabilidad"))
        cFunciones.Llenar_Tabla_Generico("select distinct mes from contabilidad.dbo.Periodo order by mes", dtMeses, Configuracion.Claves.Conexion("Contabilidad"))

        Me.cboAnyo1.Items.Clear()
        Me.cboAnyo2.Items.Clear()
        Me.cboAnyoContable.Items.Clear()
        For Each r As DataRow In dtAnyos.Rows
            Me.cboAnyo1.Items.Add(r.Item("Anno"))
            Me.cboAnyo2.Items.Add(r.Item("Anno"))
            Me.cboAnyoContable.Items.Add(r.Item("Anno"))
        Next

        Me.cboMes1.Items.Clear()
        Me.cboMes2.Items.Clear()
        For Each r As DataRow In dtMeses.Rows
            Me.cboMes1.Items.Add(MonthName(r.Item("mes")).ToString.ToUpper)
            Me.cboMes2.Items.Add(MonthName(r.Item("mes")).ToString.ToUpper)
        Next

        Me.cboAnyo1.Text = Date.Now.Year
        Me.cboAnyo2.Text = Date.Now.Year
        Me.cboAnyoContable.Text = Date.Now.Year
        Me.cboMes1.Text = MonthName(Date.Now.Month)
        Me.cboMes2.Text = MonthName(Date.Now.Month)
    End Sub

    Private Sub frmGastosComparativo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.Cargar_Datos()
    End Sub

    Private Sub btnMostrarGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarGastos.Click
        Dim p01, p02, t01, t02 As String

        p01 = Me.GetMesContable(cboMes1.SelectedIndex + 1) & "/" & Me.cboAnyo1.Text
        p02 = Me.GetMesContable(cboMes2.SelectedIndex + 1) & "/" & Me.cboAnyo2.Text
        t01 = Me.cboMes1.Text.Substring(0, 3) & "-" & Me.cboAnyo1.Text
        t02 = Me.cboMes2.Text.Substring(0, 3) & "-" & Me.cboAnyo2.Text

        Dim rpt As New rptAnalisisGastoPeriodo
        rpt.SetParameterValue(0, p01)
        rpt.SetParameterValue(1, p02)
        rpt.SetParameterValue(2, t01)
        rpt.SetParameterValue(3, t02)
        rpt.SetParameterValue(4, True)
        CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
    End Sub

    Private Sub btnMostrarReporteGastos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostrarReporteGastos.Click
        Dim rpt As New rptAnalisisGastoxAnnyo
        rpt.SetParameterValue(0, Me.cboAnyoContable.Text)
        CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
    End Sub

End Class