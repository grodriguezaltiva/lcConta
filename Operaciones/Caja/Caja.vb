Public Class Caja
    Public Shared Sub Lista(MDI As Form)
        Dim frm As New frmCajas
        If Not (MDI Is Nothing) Then
            If MDI.IsMdiContainer Then
                frm.MdiParent = MDI
            End If
        End If

        frm.Show()


    End Sub
    Public Shared Sub Crear()
        Dim frm As New frmCaja
        frm.ShowDialog()


    End Sub
    Public Shared Sub Abrir(IdCheque As Integer)
        Dim frm As New frmCaja(IdCheque)
        frm.ShowDialog()
    End Sub
End Class
