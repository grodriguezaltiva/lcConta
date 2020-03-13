
Imports Utilidades

Public Class frmNavegadorAsientos



	Dim usua As Usuario_Logeado


	Public Sub New(ByVal Usuario_Parametro As Object)
		MyBase.New()

		'El Diseñador de Windows Forms requiere esta llamada.
		InitializeComponent()
		usua = Usuario_Parametro
		'Agregar cualquier inicialización después de la llamada a InitializeComponent()

	End Sub


	Private Sub frmNavegadorAsientos_Load(sender As Object, e As EventArgs) Handles Me.Load

		Me.DetallesAsientosContableTableAdapter.Connection.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
		Vs_AsientoTableAdapter.Connection.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
		TiposDocumentosTableAdapter.Connection.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
		spCargarTipoDocumentos()

		spIniciarForm()

		WindowState = FormWindowState.Maximized
	End Sub

	Private Sub spIniciarForm()
		Try
			dtpFechaInicio.Value = DateSerial(Year(Now), Month(Now), 1)
			dtpFechaFinal.Value = Now
			cbOrigen.SelectedIndex = 0
		Catch ex As Exception
			MsgBox(ex.Message)
		End Try
	End Sub

	Public Sub spCargarTipoDocumentos()
		Try
			Dim row As Data.DataRow
			row = DtsNavegadorAsientos1.TiposDocumentos.NewRow



			TiposDocumentosTableAdapter.Fill(DtsNavegadorAsientos1.TiposDocumentos)

			row.Item("Id") = "0"
			row.Item("Descripcion") = "TODOS"
			row.Item("Sistema") = 0

			DtsNavegadorAsientos1.TiposDocumentos.Rows.Add(row)
		Catch ex As Exception

		End Try
	End Sub


	Private Sub spIniciarBusqueda()
		Try

			DtsNavegadorAsientos1.vs_Asiento.Clear()
			DtsNavegadorAsientos1.DetallesAsientosContable.Clear()
			lblDetalleAsiento.Text = "Detalle de Asiento"
			Dim sql As New SqlClient.SqlCommand

			sql.CommandText = " SELECT        AsientosContables.NumAsiento, dbo.DateOnly(AsientosContables.Fecha) As Fecha, LEFT(AsientosContables.NumAsiento, 3) As Origen, TiposDocumentos.Descripcion As TiposDocumento, AsientosContables.Observaciones, " &
							   " AsientosContables.TotalDebe, AsientosContables.TotalHaber, Moneda.MonedaNombre, AsientosContables.TipoCambio, AsientosContables.Anulado From AsientosContables INNER Join TiposDocumentos On AsientosContables.TipoDoc = TiposDocumentos.Id INNER Join " &
							   " Moneda On AsientosContables.CodMoneda = Moneda.CodMoneda"

			sql.CommandText += " where Fecha >= '" & dtpFechaInicio.Value.Date & "' and Fecha <= '" & dtpFechaFinal.Value.Date & "'"

			If cbOrigen.Text <> "TODOS" Then
				sql.CommandText += " and LEFT(AsientosContables.NumAsiento, 3) = '" & cbOrigen.Text.Substring(0, 3) & "'"

			End If

			If cbTipoDocumento.Visible And cbTipoDocumento.Text <> "TODOS" Then
				sql.CommandText += " and AsientosContables.TipoDoc = '" & cbTipoDocumento.SelectedValue & "'"
			End If


			sql.CommandText += " and  AsientosContables.NumAsiento like '%" & txtAsiento.Text & "%'"



			cFunciones.Llenar_Tabla_Generico(sql, DtsNavegadorAsientos1.vs_Asiento)
			dgvAsientos.Refresh()


		Catch ex As Exception

		End Try
	End Sub




	Private Sub dtpFechaInicio_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaInicio.ValueChanged
		spIniciarBusqueda()
	End Sub

	Private Sub dtpFechaFinal_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaFinal.ValueChanged
		spIniciarBusqueda()
	End Sub

	Private Sub dgvAsientos_SelectionChanged(sender As Object, e As EventArgs) Handles dgvAsientos.SelectionChanged
		Try
			DetallesAsientosContableTableAdapter.FillByNumAsiento(DtsNavegadorAsientos1.DetallesAsientosContable, bsAsiento.Current("NumAsiento"))
			lblDetalleAsiento.Text = "Detalle de Asiento " & bsAsiento.Current("NumAsiento")
		Catch ex As Exception

		End Try
	End Sub

	Private Sub cbOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOrigen.SelectedIndexChanged
		Try
			If cbOrigen.SelectedIndex = 6 Then
				cbTipoDocumento.Visible = True
				lblTipoDocumento.Visible = True
				cbTipoDocumento.Focus()
			Else
				cbTipoDocumento.Visible = False
				lblTipoDocumento.Visible = False

			End If
			spIniciarBusqueda()
		Catch ex As Exception

		End Try

	End Sub

	Private Sub cbTipoDocumento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoDocumento.SelectedIndexChanged
		Try
			spIniciarBusqueda()
		Catch ex As Exception

		End Try
	End Sub

	Private Sub txtAsiento_TextChanged(sender As Object, e As EventArgs) Handles txtAsiento.TextChanged

		spIniciarBusqueda()

	End Sub

	Private Sub dtpFechaInicio_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaInicio.KeyDown
		If e.KeyCode = Keys.Enter Then
			dtpFechaFinal.Focus()
		End If
	End Sub

	Private Sub dtpFechaFinal_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpFechaFinal.KeyDown
		If e.KeyCode = Keys.Enter Then
			cbOrigen.Focus()
		End If
	End Sub

	Private Sub cbOrigen_KeyDown(sender As Object, e As KeyEventArgs) Handles cbOrigen.KeyDown
		If e.KeyCode = Keys.Enter Then
			If cbOrigen.SelectedIndex = 6 Then
				cbTipoDocumento.Focus()
			Else
				txtAsiento.Focus()
			End If
		End If
	End Sub

	Private Sub txtAsiento_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAsiento.KeyDown
		If e.KeyCode = Keys.Enter Then
			dgvAsientos.Focus()
		End If
	End Sub

	Private Sub dgvAsientos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAsientos.CellDoubleClick
		Try

			Dim frm As New FrmAsientos(usua)
			frm.Show()
			frm.TxtUsuario.Text = usua.Clave_Interna
			frm.Loggin_Usuario()
			frm.Nuevo()
			frm.Buscar(bsAsiento.Current("NumAsiento"))

			spIniciarBusqueda()

		Catch ex As Exception

		End Try
	End Sub

End Class