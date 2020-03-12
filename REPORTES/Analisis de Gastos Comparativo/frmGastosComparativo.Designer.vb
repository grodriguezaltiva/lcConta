<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGastosComparativo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.cboMes1 = New System.Windows.Forms.ComboBox
        Me.cboMes2 = New System.Windows.Forms.ComboBox
        Me.cboAnyo1 = New System.Windows.Forms.ComboBox
        Me.cboAnyo2 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnMostrarGastos = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnMostrarReporteGastos = New System.Windows.Forms.Button
        Me.cboAnyoContable = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(2, 114)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.SelectionFormula = ""
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(890, 332)
        Me.CrystalReportViewer1.TabIndex = 11
        Me.CrystalReportViewer1.ViewTimeSelectionFormula = ""
        '
        'cboMes1
        '
        Me.cboMes1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes1.FormattingEnabled = True
        Me.cboMes1.Location = New System.Drawing.Point(34, 59)
        Me.cboMes1.Name = "cboMes1"
        Me.cboMes1.Size = New System.Drawing.Size(124, 21)
        Me.cboMes1.TabIndex = 12
        '
        'cboMes2
        '
        Me.cboMes2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMes2.FormattingEnabled = True
        Me.cboMes2.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.cboMes2.Location = New System.Drawing.Point(205, 59)
        Me.cboMes2.Name = "cboMes2"
        Me.cboMes2.Size = New System.Drawing.Size(124, 21)
        Me.cboMes2.TabIndex = 13
        '
        'cboAnyo1
        '
        Me.cboAnyo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnyo1.FormattingEnabled = True
        Me.cboAnyo1.Location = New System.Drawing.Point(34, 32)
        Me.cboAnyo1.Name = "cboAnyo1"
        Me.cboAnyo1.Size = New System.Drawing.Size(124, 21)
        Me.cboAnyo1.TabIndex = 14
        '
        'cboAnyo2
        '
        Me.cboAnyo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnyo2.FormattingEnabled = True
        Me.cboAnyo2.Location = New System.Drawing.Point(205, 32)
        Me.cboAnyo2.Name = "cboAnyo2"
        Me.cboAnyo2.Size = New System.Drawing.Size(124, 21)
        Me.cboAnyo2.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Año"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mes"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(174, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Mes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(174, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Año"
        '
        'btnMostrarGastos
        '
        Me.btnMostrarGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarGastos.Location = New System.Drawing.Point(335, 13)
        Me.btnMostrarGastos.Name = "btnMostrarGastos"
        Me.btnMostrarGastos.Size = New System.Drawing.Size(234, 67)
        Me.btnMostrarGastos.TabIndex = 20
        Me.btnMostrarGastos.Text = "Mostrar Reporte Gastos"
        Me.btnMostrarGastos.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(6, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 15)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Periodo 1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(177, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 15)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Periodo 2"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(131, 20)
        Me.TabControl1.Location = New System.Drawing.Point(2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(890, 110)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 23
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.cboMes1)
        Me.TabPage1.Controls.Add(Me.cboMes2)
        Me.TabPage1.Controls.Add(Me.btnMostrarGastos)
        Me.TabPage1.Controls.Add(Me.cboAnyo1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.cboAnyo2)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(882, 82)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Comparativo Mes vs Mes"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.btnMostrarReporteGastos)
        Me.TabPage2.Controls.Add(Me.cboAnyoContable)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(882, 82)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gastos por Año"
        '
        'btnMostrarReporteGastos
        '
        Me.btnMostrarReporteGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarReporteGastos.Location = New System.Drawing.Point(13, 34)
        Me.btnMostrarReporteGastos.Name = "btnMostrarReporteGastos"
        Me.btnMostrarReporteGastos.Size = New System.Drawing.Size(235, 42)
        Me.btnMostrarReporteGastos.TabIndex = 21
        Me.btnMostrarReporteGastos.Text = "Mostrar Reporte Gastos"
        Me.btnMostrarReporteGastos.UseVisualStyleBackColor = True
        '
        'cboAnyoContable
        '
        Me.cboAnyoContable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAnyoContable.FormattingEnabled = True
        Me.cboAnyoContable.Location = New System.Drawing.Point(88, 7)
        Me.cboAnyoContable.Name = "cboAnyoContable"
        Me.cboAnyoContable.Size = New System.Drawing.Size(160, 21)
        Me.cboAnyoContable.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Año Contable"
        '
        'frmGastosComparativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 447)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "frmGastosComparativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gastos Comparativos"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents cboMes1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboMes2 As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnyo1 As System.Windows.Forms.ComboBox
    Friend WithEvents cboAnyo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnMostrarGastos As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents btnMostrarReporteGastos As System.Windows.Forms.Button
    Friend WithEvents cboAnyoContable As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
