Public Class frmConfigurarNotas
    Dim nuevo As Boolean = False
    Private Sub btnPrimario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimario.Click
        Me.txtNotaRaiz.Value = 0
        Me.txtTitulo.Text = ""
        TabControl1.TabPages.Clear()
        TabControl1.TabPages.Add(tbRaiz)
        txtNotaRaiz.ReadOnly = False
        nuevo = True
    End Sub
    Dim vou As String = ""
    Private Sub trvNotas_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles trvNotas.AfterSelect
        vou = e.Node.Text 'trvNotas.SelectedNode.Name


        If IsNumeric(vou) Then
            btnSegundario.Enabled = True
            sp_cargarNotaRaiz(vou)
            txtNotaRaiz.ReadOnly = True
        Else
            sp_cargarNotaSecundaria(trvNotas.SelectedNode.Parent.Name, vou)
            btnSegundario.Enabled = False
        End If
        nuevo = False
    End Sub
    Dim currentID As String = "0"
    Sub sp_cargarNotaRaiz(ByVal num As String)
        Dim dt As New DataTable

        cls_Datos.sp_llenarTabla("Select * From tbNotasRaiz Where Numero = " & num, dt, "Contabilidad")
        If dt.Rows.Count > 0 Then
            txtNotaRaiz.Value = dt.Rows(0).Item("Numero")
            txtDetalleRaiz.Text = dt.Rows(0).Item("Descripcion")
            txtTitulo.Text = dt.Rows(0).Item("Titulo")
            currentID = dt.Rows(0).Item("Id")
            TabControl1.TabPages.Clear()
            TabControl1.TabPages.Add(tbRaiz)

        End If
    End Sub
    Sub sp_cargarNotaSecundaria(ByVal num As String, ByVal letra As String)
        Dim dt As New DataTable

        cls_Datos.sp_llenarTabla("Select * From tbNotasSecundaria Where Numero = " & num & " AND Letra = '" & letra & "'", dt, "Contabilidad")
        If dt.Rows.Count > 0 Then
            currentID = dt.Rows(0).Item("ID")
            txtPapa.Text = dt.Rows(0).Item("Numero")
            txtDetalleSecund.Text = dt.Rows(0).Item("Descripcion")
            txtNotaSecund.Text = dt.Rows(0).Item("Letra")
            cls_Datos.sp_llenarTabla("Select * From tbNotasSecundariaDet Where Id_NotaSecundaria = " & dt.Rows(0).Item("ID"), dts1.tbNotasSecundariaDet, "Contabilidad")
            TabControl1.TabPages.Clear()
            TabControl1.TabPages.Add(tbSecundaria)
        End If
    End Sub
    Private Sub frmConfigurarNotas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        'TODO: esta línea de código carga datos en la tabla 'dts1.CuentaContable' Puede moverla o quitarla según sea necesario.
        CuentaContableTableAdapter.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        CuentaContableTableAdapter.Fill(Me.dts1.CuentaContable)

        sp_mostrarArbol()
    End Sub
    Sub sp_mostrarArbol()
        trvNotas.Nodes.Clear()
        cls_Datos.sp_llenarTabla("Select * From tbNotasRaiz Order By Numero", dts1.tbNotasRaiz, "Contabilidad")

        For i As Integer = 0 To dts1.tbNotasRaiz.Count - 1
            Dim neew As New TreeNode(dts1.tbNotasRaiz(i).Numero)
            neew.Name = dts1.tbNotasRaiz(i).Numero
            trvNotas.Nodes.Add(neew)

        Next

        'Dim newNode As TreeNode = New TreeNode(dts1.tbNotasSecundaria(i).Numero & "." & dts1.tbNotasSecundaria(i).Letra)
        'newNode.Name = dts1.tbNotasSecundaria(i).Letra
        'trvNotas.Nodes.Item(dts1.tbNotasSecundaria(i).Numero - 1).Nodes.Add(newNode)

        For i As Integer = 0 To Me.trvNotas.Nodes.Count - 1
            cls_Datos.sp_llenarTabla("Select * From tbNotasSecundaria where Numero = " & Me.trvNotas.Nodes(i).Text, dts1.tbNotasSecundaria, "Contabilidad")
            For Each F As dtsGeneraNotas.tbNotasSecundariaRow In dts1.tbNotasSecundaria.Rows
                trvNotas.Nodes.Item(i).Nodes.Add(F.Letra)
            Next
        Next

        TabControl1.TabPages.Clear()
    End Sub


    Private Sub btnListoRaiz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListoRaiz.Click
        sp_GuardaRaiz()
    End Sub
    Sub sp_GuardaRaiz()
        If MsgBox("¿Desea guardar la nota?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If nuevo Then
                If fn_ValidaRaiz() Then
                    ' cls_Datos.Sp_EjecutarSQL("UPDATE [dbo].[tbNotasRaiz]  SET [Numero] = " & txtNotaRaiz.Text & "  ,[Descripcion] = '" & txtDetalleRaiz.Text & "'  WHERE <Search Conditions,,>")
                    cls_Datos.Sp_EjecutarSQL("INSERT INTO [dbo].[tbNotasRaiz]  (Numero,Titulo,Descripcion )  VALUES  (" & txtNotaRaiz.Value & " ,'" & txtTitulo.Text & "','" & txtDetalleSecund.Text & "')", "Contabilidad")
                    sp_mostrarArbol()
                    nuevo = False
                Else
                    MsgBox("Ya existe este numero de raíz")
                End If
            Else
                cls_Datos.Sp_EjecutarSQL("UPDATE [dbo].[tbNotasRaiz]  SET [Numero] = " & txtNotaRaiz.Value & " ,Titulo = '" & txtTitulo.Text & "',[Descripcion] = '" & txtDetalleRaiz.Text & "' WHERE Numero = " & txtNotaRaiz.Value & "", "Contabilidad")
                sp_mostrarArbol()
            End If


        End If
    End Sub
    Sub sp_GuardaSecundarioDet(ByVal ID As Integer)
        BindingContext(dts1, "tbNotasSecundariaDet").EndCurrentEdit()

        For i As Integer = 0 To dts1.tbNotasSecundariaDet.Count - 1
            If Not dts1.tbNotasSecundariaDet(i).RowState = DataRowState.Deleted Then
                dts1.tbNotasSecundariaDet(i).ID_NotaSecundaria = ID
            End If
        Next
        TbNotasSecundariaDetTableAdapter.Connection.ConnectionString = cls_Datos.fn_StrConexionBase("Contabilidad")
        TbNotasSecundariaDetTableAdapter.Update(dts1.tbNotasSecundariaDet)
    End Sub
    Sub sp_GuardaSecundario()
        If MsgBox("¿Desea guardar la nota?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If nuevo Then


                If fn_ValidaRaiz("SECUND") Then

                    cls_Datos.Sp_EjecutarSQL("INSERT INTO [dbo].[tbNotasSecundaria]  ([Letra]  ,[Numero]  ,[Descripcion])  VALUES  ('" & txtNotaSecund.Text & "'  , " & txtPapa.Text & "  ,'" & txtDetalleSecund.Text & "')", "Contabilidad")
                    Dim dt As New DataTable
                    cls_Datos.sp_llenarTabla("Select MAX(Id) AS ID From tbNotasSecundaria", dt, "Contabilidad")

                    BindingContext(dts1, "tbNotasSecundariaDet").EndCurrentEdit()
                    If dt.Rows.Count > 0 Then
                        sp_GuardaSecundarioDet(dt.Rows(0).Item("ID"))

                    End If

                Else
                    MsgBox("Ya existe este número de raíz")
                    Exit Sub
                End If
            Else
                cls_Datos.Sp_EjecutarSQL("UPDATE [dbo].[tbNotasSecundaria]  SET [Descripcion] = '" & txtDetalleSecund.Text & "', Letra = '" & txtNotaSecund.Text & "'  WHERE ID = " & currentID, "Contabilidad")
                sp_GuardaSecundarioDet(currentID)


            End If

            sp_mostrarArbol()
            nuevo = False
        End If
    End Sub

    Function fn_ValidaRaiz(Optional ByVal tipo As String = "RAIZ") As Boolean
        If tipo.Equals("RAIZ") Then
            For i As Integer = 0 To dts1.tbNotasRaiz.Count - 1
                If dts1.tbNotasRaiz(i).Numero = txtNotaRaiz.Value Then
                    Return False
                End If

            Next
        Else
            For i As Integer = 0 To dts1.tbNotasSecundaria.Count - 1
                If dts1.tbNotasSecundaria(i).Numero = txtPapa.Text And dts1.tbNotasSecundaria(i).Letra.Equals(txtNotaSecund.Text) Then
                    Return False
                End If

            Next
        End If
        Return True

    End Function

    Private Sub btnSegundario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSegundario.Click
        If trvNotas.Nodes.Count > 0 Then
            TabControl1.TabPages.Clear()
            TabControl1.TabPages.Add(tbSecundaria)
            txtNotaRaiz.ReadOnly = False
            txtPapa.Text = vou
            dts1.tbNotasSecundariaDet.Clear()
            txtTitulo.Text = ""
            txtNotaSecund.Text = "" : txtNotaSecund.Focus()
            nuevo = True
        End If
    End Sub

    Private Sub detalleCuentas_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles detalleCuentas.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MsgBox("¿Desea quitar esta cuenta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BindingContext(dts1, "tbNotasSecundariaDet").RemoveAt(BindingContext(dts1, "tbNotasSecundariaDet").Position)
                BindingContext(dts1, "tbNotasSecundariaDet").EndCurrentEdit()
            End If
        End If
    End Sub

    Private Sub btnListoSecund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListoSecund.Click
        sp_GuardaSecundario()

    End Sub


    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        sp_Quitar("RAIZ")
    End Sub
    Sub sp_Quitar(ByVal tipo As String)
        If MsgBox("Esta transacción eliminará tambíen las dependencias ¿Desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            If tipo.Equals("RAIZ") Then
                Dim dtss As New DataTable
                cFunciones.Llenar_Tabla_Generico("Select ID from tbNotasSecundaria where Numero = " & Me.trvNotas.SelectedNode.Text, dtss, Configuracion.Claves.Conexion("Contabilidad"))
                If dtss.Rows.Count > 0 Then
                    cls_Datos.Sp_EjecutarSQL("DELETE FROM [dbo].[tbNotasSecundaria] WHERE Numero = " & Me.trvNotas.SelectedNode.Text & " DELETE FROM [dbo].[tbNotasSecundariaDet] WHERE Id_NotaSecundaria = " & dtss.Rows(0).Item("ID"), "Contabilidad")
                    cls_Datos.Sp_EjecutarSQL("DELETE FROM [dbo].[tbNotasRaiz] WHERE Id = " & currentID, "Contabilidad")
                End If                
            Else
                cls_Datos.Sp_EjecutarSQL("DELETE FROM [dbo].[tbNotasSecundaria] WHERE ID = " & currentID & " DELETE FROM [dbo].[tbNotasSecundariaDet] WHERE ID_NotaSecundaria = " & currentID, "Contabilidad")

            End If
            sp_mostrarArbol()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarSecun.Click
        sp_Quitar("SECUNDARIA")
    End Sub


End Class