


Imports System.Data.SqlClient
Imports DevExpress.Utils
Imports DevExpress.XtraTreeList
Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports Utilidades
Imports Utilidades_DB
Imports DevExpress.XtraTreeList.Columns

Public Class FrmEstadoResultadovsPresupuesto
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AdAsientos As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents AdTemporal2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdDetalleAsiento As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PrintableComponentLink1 As DevExpress.XtraPrinting.PrintableComponentLink
    Friend WithEvents PrintingSystem1 As DevExpress.XtraPrinting.PrintingSystem
    Friend WithEvents Link1 As DevExpress.XtraPrinting.Link
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents AdapterMoneda As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Protected Friend WithEvents ToolBarExportar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Public WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents DsBalances1 As Contabilidad.DsBalances
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Check_Cierre As System.Windows.Forms.CheckBox
    Friend WithEvents smbGenerar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents AdCuentas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Friend WithEvents DsBalances11 As Contabilidad.DsBalances
    Friend WithEvents btnImprimir As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblPeriodoFiscal As System.Windows.Forms.Label
    Friend WithEvents txtPeriodoFiscal As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarPeriodoFiscal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LblMes As System.Windows.Forms.Label
    Friend WithEvents CboMes As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents DataSet1 As System.Data.DataSet
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmEstadoResultadovsPresupuesto))
        Me.Label12 = New System.Windows.Forms.Label
        Me.GridColumn6 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.Label11 = New System.Windows.Forms.Label
        Me.AdAsientos = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.GridColumn5 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Label9 = New System.Windows.Forms.Label
        Me.GridColumn4 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.AdTemporal2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.AdDetalleAsiento = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.PrintableComponentLink1 = New DevExpress.XtraPrinting.PrintableComponentLink(Me.components)
        Me.PrintingSystem1 = New DevExpress.XtraPrinting.PrintingSystem(Me.components)
        Me.Link1 = New DevExpress.XtraPrinting.Link(Me.components)
        Me.Label7 = New System.Windows.Forms.Label
        Me.AdapterMoneda = New System.Data.SqlClient.SqlDataAdapter
        Me.GridColumn3 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarExportar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CboMes = New System.Windows.Forms.ComboBox
        Me.LblMes = New System.Windows.Forms.Label
        Me.btnBuscarPeriodoFiscal = New DevExpress.XtraEditors.SimpleButton
        Me.txtPeriodoFiscal = New System.Windows.Forms.TextBox
        Me.LblPeriodoFiscal = New System.Windows.Forms.Label
        Me.btnImprimir = New DevExpress.XtraEditors.SimpleButton
        Me.Check_Cierre = New System.Windows.Forms.CheckBox
        Me.smbGenerar = New DevExpress.XtraEditors.SimpleButton
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.AdCuentas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GridColumn1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.BandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.DsBalances11 = New Contabilidad.DsBalances
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.DataSet1 = New System.Data.DataSet
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsBalances11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(784, 428)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 16)
        Me.Label12.TabIndex = 185
        Me.Label12.Text = "Créditos$"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Saldo Mes"
        Me.GridColumn6.DisplayFormat.FormatString = "#,##0.00"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "SaldoMes"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.Width = 56
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(904, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 16)
        Me.Label10.TabIndex = 189
        Me.Label10.Text = "Saldo del Mes$"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE CuentaContable SET CuentaContable = @CuentaContable, Descripcion = @Descri" & _
        "pcion, Nivel = @Nivel, Tipo = @Tipo, CuentaMadre = @CuentaMadre, Movimiento = @M" & _
        "ovimiento, PARENTID = @PARENTID, DescCuentaMadre = @DescCuentaMadre WHERE (Cuent" & _
        "aContable = @Original_CuentaContable) AND (CuentaMadre = @Original_CuentaMadre) " & _
        "AND (DescCuentaMadre = @Original_DescCuentaMadre) AND (Descripcion = @Original_D" & _
        "escripcion) AND (Movimiento = @Original_Movimiento) AND (Nivel = @Original_Nivel" & _
        ") AND (PARENTID = @Original_PARENTID) AND (Tipo = @Original_Tipo); SELECT Cuenta" & _
        "Contable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PARENTID, DescC" & _
        "uentaMadre FROM CuentaContable WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DRAGONS;packet size=4096;integrated security=SSPI;data source="".\s" & _
        "ql2000"";persist security info=False;initial catalog=Contabilidad"
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = "INSERT INTO Temporal2(CuentaContable, Descripcion, SaldoAnterior, Debitos, Credit" & _
        "os, SaldoMes, SaldoActual, Nivel, Movimiento, Id, PARENTID, SaldoAnteriorD, Debi" & _
        "tosD, CreditosD, SaldoMesD, SaldoActualD) VALUES (@CuentaContable, @Descripcion," & _
        " @SaldoAnterior, @Debitos, @Creditos, @SaldoMes, @SaldoActual, @Nivel, @Movimien" & _
        "to, @Id, @PARENTID, @SaldoAnteriorD, @DebitosD, @CreditosD, @SaldoMesD, @SaldoAc" & _
        "tualD); SELECT CuentaContable, Descripcion, SaldoAnterior, Debitos, Creditos, Sa" & _
        "ldoMes, SaldoActual, Nivel, Movimiento, Id, PARENTID, SaldoAnteriorD, DebitosD, " & _
        "CreditosD, SaldoMesD, SaldoActualD FROM Temporal2 WHERE (CuentaContable = @Cuent" & _
        "aContable)"
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnteriorD", System.Data.SqlDbType.Float, 8, "SaldoAnteriorD"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DebitosD", System.Data.SqlDbType.Float, 8, "DebitosD"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreditosD", System.Data.SqlDbType.Float, 8, "CreditosD"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMesD", System.Data.SqlDbType.Float, 8, "SaldoMesD"))
        Me.SqlInsertCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActualD", System.Data.SqlDbType.Float, 8, "SaldoActualD"))
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT CuentaContable, Descripcion, SaldoAnterior, Debitos, Creditos, SaldoMes, S" & _
        "aldoActual, Nivel, Movimiento, Id, PARENTID, SaldoAnteriorD, DebitosD, CreditosD" & _
        ", SaldoMesD, SaldoActualD, 0 AS Diferencia FROM Temporal2"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlConnection2
        '
        Me.SqlConnection2.ConnectionString = "workstation id=JANKA;packet size=4096;integrated security=SSPI;data source=""."";pe" & _
        "rsist security info=False;initial catalog=Contabilidad"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(852, 432)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 16)
        Me.Label11.TabIndex = 187
        Me.Label11.Text = "Débitos$"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdAsientos
        '
        Me.AdAsientos.DeleteCommand = Me.SqlDeleteCommand2
        Me.AdAsientos.InsertCommand = Me.SqlInsertCommand2
        Me.AdAsientos.SelectCommand = Me.SqlSelectCommand2
        Me.AdAsientos.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "AsientosContables", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Fecha", "Fecha"), New System.Data.Common.DataColumnMapping("NumDoc", "NumDoc"), New System.Data.Common.DataColumnMapping("Beneficiario", "Beneficiario"), New System.Data.Common.DataColumnMapping("TipoDoc", "TipoDoc"), New System.Data.Common.DataColumnMapping("Accion", "Accion"), New System.Data.Common.DataColumnMapping("Anulado", "Anulado"), New System.Data.Common.DataColumnMapping("FechaEntrada", "FechaEntrada"), New System.Data.Common.DataColumnMapping("Mayorizado", "Mayorizado"), New System.Data.Common.DataColumnMapping("Periodo", "Periodo"), New System.Data.Common.DataColumnMapping("NumMayorizado", "NumMayorizado"), New System.Data.Common.DataColumnMapping("Modulo", "Modulo"), New System.Data.Common.DataColumnMapping("Observaciones", "Observaciones"), New System.Data.Common.DataColumnMapping("NombreUsuario", "NombreUsuario"), New System.Data.Common.DataColumnMapping("TotalDebe", "TotalDebe"), New System.Data.Common.DataColumnMapping("TotalHaber", "TotalHaber"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio"), New System.Data.Common.DataColumnMapping("IdNumDoc", "IdNumDoc")})})
        Me.AdAsientos.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM AsientosContables WHERE (NumAsiento = @Original_NumAsiento) AND (Acci" & _
        "on = @Original_Accion) AND (Anulado = @Original_Anulado) AND (Beneficiario = @Or" & _
        "iginal_Beneficiario) AND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Origina" & _
        "l_Fecha) AND (FechaEntrada = @Original_FechaEntrada) AND (IdNumDoc = @Original_I" & _
        "dNumDoc) AND (Mayorizado = @Original_Mayorizado) AND (Modulo = @Original_Modulo)" & _
        " AND (NombreUsuario = @Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) A" & _
        "ND (NumMayorizado = @Original_NumMayorizado) AND (Observaciones = @Original_Obse" & _
        "rvaciones) AND (Periodo = @Original_Periodo) AND (TipoCambio = @Original_TipoCam" & _
        "bio) AND (TipoDoc = @Original_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND" & _
        " (TotalHaber = @Original_TotalHaber)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO AsientosContables(NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, A" & _
        "ccion, Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observ" & _
        "aciones, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc) " & _
        "VALUES (@NumAsiento, @Fecha, @NumDoc, @Beneficiario, @TipoDoc, @Accion, @Anulado" & _
        ", @FechaEntrada, @Mayorizado, @Periodo, @NumMayorizado, @Modulo, @Observaciones," & _
        " @NombreUsuario, @TotalDebe, @TotalHaber, @CodMoneda, @TipoCambio, @IdNumDoc); S" & _
        "ELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM AsientosContables W" & _
        "HERE (NumAsiento = @NumAsiento)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion, Anulado, FechaEn" & _
        "trada, Mayorizado, Periodo, NumMayorizado, Modulo, Observaciones, NombreUsuario," & _
        " TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM AsientosContables"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE AsientosContables SET NumAsiento = @NumAsiento, Fecha = @Fecha, NumDoc = @" & _
        "NumDoc, Beneficiario = @Beneficiario, TipoDoc = @TipoDoc, Accion = @Accion, Anul" & _
        "ado = @Anulado, FechaEntrada = @FechaEntrada, Mayorizado = @Mayorizado, Periodo " & _
        "= @Periodo, NumMayorizado = @NumMayorizado, Modulo = @Modulo, Observaciones = @O" & _
        "bservaciones, NombreUsuario = @NombreUsuario, TotalDebe = @TotalDebe, TotalHaber" & _
        " = @TotalHaber, CodMoneda = @CodMoneda, TipoCambio = @TipoCambio, IdNumDoc = @Id" & _
        "NumDoc WHERE (NumAsiento = @Original_NumAsiento) AND (Accion = @Original_Accion)" & _
        " AND (Anulado = @Original_Anulado) AND (Beneficiario = @Original_Beneficiario) A" & _
        "ND (CodMoneda = @Original_CodMoneda) AND (Fecha = @Original_Fecha) AND (FechaEnt" & _
        "rada = @Original_FechaEntrada) AND (IdNumDoc = @Original_IdNumDoc) AND (Mayoriza" & _
        "do = @Original_Mayorizado) AND (Modulo = @Original_Modulo) AND (NombreUsuario = " & _
        "@Original_NombreUsuario) AND (NumDoc = @Original_NumDoc) AND (NumMayorizado = @O" & _
        "riginal_NumMayorizado) AND (Observaciones = @Original_Observaciones) AND (Period" & _
        "o = @Original_Periodo) AND (TipoCambio = @Original_TipoCambio) AND (TipoDoc = @O" & _
        "riginal_TipoDoc) AND (TotalDebe = @Original_TotalDebe) AND (TotalHaber = @Origin" & _
        "al_TotalHaber); SELECT NumAsiento, Fecha, NumDoc, Beneficiario, TipoDoc, Accion," & _
        " Anulado, FechaEntrada, Mayorizado, Periodo, NumMayorizado, Modulo, Observacione" & _
        "s, NombreUsuario, TotalDebe, TotalHaber, CodMoneda, TipoCambio, IdNumDoc FROM As" & _
        "ientosContables WHERE (NumAsiento = @NumAsiento)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Fecha", System.Data.SqlDbType.DateTime, 4, "Fecha"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumDoc", System.Data.SqlDbType.VarChar, 50, "NumDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Beneficiario", System.Data.SqlDbType.VarChar, 50, "Beneficiario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoDoc", System.Data.SqlDbType.Int, 4, "TipoDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Accion", System.Data.SqlDbType.VarChar, 50, "Accion"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Anulado", System.Data.SqlDbType.Bit, 1, "Anulado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@FechaEntrada", System.Data.SqlDbType.DateTime, 4, "FechaEntrada"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Mayorizado", System.Data.SqlDbType.Bit, 1, "Mayorizado"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Periodo", System.Data.SqlDbType.VarChar, 8, "Periodo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Current, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Modulo", System.Data.SqlDbType.VarChar, 50, "Modulo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Observaciones", System.Data.SqlDbType.VarChar, 255, "Observaciones"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreUsuario", System.Data.SqlDbType.VarChar, 255, "NombreUsuario"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalDebe", System.Data.SqlDbType.Float, 8, "TotalDebe"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TotalHaber", System.Data.SqlDbType.Float, 8, "TotalHaber"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@IdNumDoc", System.Data.SqlDbType.BigInt, 8, "IdNumDoc"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Accion", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Accion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Anulado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Anulado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Beneficiario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Beneficiario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Fecha", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Fecha", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_FechaEntrada", System.Data.SqlDbType.DateTime, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "FechaEntrada", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_IdNumDoc", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdNumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Mayorizado", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Mayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Modulo", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Modulo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreUsuario", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreUsuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumDoc", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumMayorizado", System.Data.SqlDbType.Decimal, 9, System.Data.ParameterDirection.Input, False, CType(18, Byte), CType(0, Byte), "NumMayorizado", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Periodo", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Periodo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoDoc", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoDoc", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalDebe", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalDebe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TotalHaber", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TotalHaber", System.Data.DataRowVersion.Original, Nothing))
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Créditos"
        Me.GridColumn5.DisplayFormat.FormatString = "#,##0.00"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Creditos"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.Width = 46
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO CuentaContable(CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre," & _
        " Movimiento, PARENTID, DescCuentaMadre) VALUES (@CuentaContable, @Descripcion, @" & _
        "Nivel, @Tipo, @CuentaMadre, @Movimiento, @PARENTID, @DescCuentaMadre); SELECT Cu" & _
        "entaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PARENTID, D" & _
        "escCuentaMadre FROM CuentaContable WHERE (CuentaContable = @CuentaContable)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.SmallInt, 2, "Nivel"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Tipo", System.Data.SqlDbType.VarChar, 250, "Tipo"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaMadre", System.Data.SqlDbType.VarChar, 50, "CuentaMadre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, "DescCuentaMadre"))
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(868, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 16)
        Me.Label9.TabIndex = 191
        Me.Label9.Text = "Saldo Actual$"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Débitos"
        Me.GridColumn4.DisplayFormat.FormatString = "#,##0.00"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn4.FieldName = "Debitos"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.Width = 38
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT CuentaContable, Descripcion, Nivel, Tipo, CuentaMadre, Movimiento, id, PAR" & _
        "ENTID, DescCuentaMadre FROM CuentaContable ORDER BY CuentaContable"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM Temporal2 WHERE (CuentaContable = @Original_CuentaContable) AND (Cred" & _
        "itos = @Original_Creditos) AND (CreditosD = @Original_CreditosD) AND (Debitos = " & _
        "@Original_Debitos) AND (DebitosD = @Original_DebitosD) AND (Descripcion = @Origi" & _
        "nal_Descripcion) AND (Id = @Original_Id) AND (Movimiento = @Original_Movimiento)" & _
        " AND (Nivel = @Original_Nivel) AND (PARENTID = @Original_PARENTID) AND (SaldoAct" & _
        "ual = @Original_SaldoActual) AND (SaldoActualD = @Original_SaldoActualD) AND (Sa" & _
        "ldoAnterior = @Original_SaldoAnterior) AND (SaldoAnteriorD = @Original_SaldoAnte" & _
        "riorD) AND (SaldoMes = @Original_SaldoMes) AND (SaldoMesD = @Original_SaldoMesD)" & _
        ""
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreditosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreditosD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DebitosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DebitosD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActualD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActualD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnteriorD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnteriorD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMesD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMesD", System.Data.DataRowVersion.Original, Nothing))
        '
        'AdTemporal2
        '
        Me.AdTemporal2.DeleteCommand = Me.SqlDeleteCommand4
        Me.AdTemporal2.InsertCommand = Me.SqlInsertCommand4
        Me.AdTemporal2.SelectCommand = Me.SqlSelectCommand4
        Me.AdTemporal2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Temporal2", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("SaldoAnterior", "SaldoAnterior"), New System.Data.Common.DataColumnMapping("Debitos", "Debitos"), New System.Data.Common.DataColumnMapping("Creditos", "Creditos"), New System.Data.Common.DataColumnMapping("SaldoMes", "SaldoMes"), New System.Data.Common.DataColumnMapping("SaldoActual", "SaldoActual"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("SaldoAnteriorD", "SaldoAnteriorD"), New System.Data.Common.DataColumnMapping("DebitosD", "DebitosD"), New System.Data.Common.DataColumnMapping("CreditosD", "CreditosD"), New System.Data.Common.DataColumnMapping("SaldoMesD", "SaldoMesD"), New System.Data.Common.DataColumnMapping("SaldoActualD", "SaldoActualD")})})
        Me.AdTemporal2.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = "UPDATE Temporal2 SET CuentaContable = @CuentaContable, Descripcion = @Descripcion" & _
        ", SaldoAnterior = @SaldoAnterior, Debitos = @Debitos, Creditos = @Creditos, Sald" & _
        "oMes = @SaldoMes, SaldoActual = @SaldoActual, Nivel = @Nivel, Movimiento = @Movi" & _
        "miento, Id = @Id, PARENTID = @PARENTID, SaldoAnteriorD = @SaldoAnteriorD, Debito" & _
        "sD = @DebitosD, CreditosD = @CreditosD, SaldoMesD = @SaldoMesD, SaldoActualD = @" & _
        "SaldoActualD WHERE (CuentaContable = @Original_CuentaContable) AND (Creditos = @" & _
        "Original_Creditos) AND (CreditosD = @Original_CreditosD) AND (Debitos = @Origina" & _
        "l_Debitos) AND (DebitosD = @Original_DebitosD) AND (Descripcion = @Original_Desc" & _
        "ripcion) AND (Id = @Original_Id) AND (Movimiento = @Original_Movimiento) AND (Ni" & _
        "vel = @Original_Nivel) AND (PARENTID = @Original_PARENTID) AND (SaldoActual = @O" & _
        "riginal_SaldoActual) AND (SaldoActualD = @Original_SaldoActualD) AND (SaldoAnter" & _
        "ior = @Original_SaldoAnterior) AND (SaldoAnteriorD = @Original_SaldoAnteriorD) A" & _
        "ND (SaldoMes = @Original_SaldoMes) AND (SaldoMesD = @Original_SaldoMesD); SELECT" & _
        " CuentaContable, Descripcion, SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoA" & _
        "ctual, Nivel, Movimiento, Id, PARENTID, SaldoAnteriorD, DebitosD, CreditosD, Sal" & _
        "doMesD, SaldoActualD FROM Temporal2 WHERE (CuentaContable = @CuentaContable)"
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CuentaContable", System.Data.SqlDbType.VarChar, 255, "CuentaContable"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.VarChar, 250, "Descripcion"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnterior", System.Data.SqlDbType.Float, 8, "SaldoAnterior"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debitos", System.Data.SqlDbType.Float, 8, "Debitos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Creditos", System.Data.SqlDbType.Float, 8, "Creditos"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMes", System.Data.SqlDbType.Float, 8, "SaldoMes"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActual", System.Data.SqlDbType.Float, 8, "SaldoActual"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Nivel", System.Data.SqlDbType.Int, 4, "Nivel"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Movimiento", System.Data.SqlDbType.Bit, 1, "Movimiento"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@PARENTID", System.Data.SqlDbType.Int, 4, "PARENTID"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoAnteriorD", System.Data.SqlDbType.Float, 8, "SaldoAnteriorD"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DebitosD", System.Data.SqlDbType.Float, 8, "DebitosD"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CreditosD", System.Data.SqlDbType.Float, 8, "CreditosD"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoMesD", System.Data.SqlDbType.Float, 8, "SaldoMesD"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SaldoActualD", System.Data.SqlDbType.Float, 8, "SaldoActualD"))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Creditos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Creditos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CreditosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CreditosD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debitos", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debitos", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DebitosD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DebitosD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActual", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActual", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoActualD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoActualD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnterior", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnterior", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoAnteriorD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoAnteriorD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMes", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMes", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand4.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SaldoMesD", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SaldoMesD", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT MonedaNombre, ValorVenta, CodMoneda, Simbolo FROM Moneda"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = "INSERT INTO Moneda(MonedaNombre, ValorVenta, CodMoneda, Simbolo) VALUES (@MonedaN" & _
        "ombre, @ValorVenta, @CodMoneda, @Simbolo); SELECT MonedaNombre, ValorVenta, CodM" & _
        "oneda, Simbolo FROM Moneda"
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand5.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(544, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 16)
        Me.Label13.TabIndex = 183
        Me.Label13.Text = "Saldo Anterior$"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(312, 428)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 16)
        Me.Label5.TabIndex = 179
        Me.Label5.Text = "Saldo del Mes¢"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdDetalleAsiento
        '
        Me.AdDetalleAsiento.DeleteCommand = Me.SqlDeleteCommand3
        Me.AdDetalleAsiento.InsertCommand = Me.SqlInsertCommand3
        Me.AdDetalleAsiento.SelectCommand = Me.SqlSelectCommand3
        Me.AdDetalleAsiento.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "DetallesAsientosContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ID_Detalle", "ID_Detalle"), New System.Data.Common.DataColumnMapping("NumAsiento", "NumAsiento"), New System.Data.Common.DataColumnMapping("Cuenta", "Cuenta"), New System.Data.Common.DataColumnMapping("NombreCuenta", "NombreCuenta"), New System.Data.Common.DataColumnMapping("Monto", "Monto"), New System.Data.Common.DataColumnMapping("Debe", "Debe"), New System.Data.Common.DataColumnMapping("Haber", "Haber"), New System.Data.Common.DataColumnMapping("DescripcionAsiento", "DescripcionAsiento"), New System.Data.Common.DataColumnMapping("TipoCambio", "TipoCambio")})})
        Me.AdDetalleAsiento.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM DetallesAsientosContable WHERE (ID_Detalle = @Original_ID_Detalle) AN" & _
        "D (Cuenta = @Original_Cuenta) AND (Debe = @Original_Debe) AND (DescripcionAsient" & _
        "o = @Original_DescripcionAsiento) AND (Haber = @Original_Haber) AND (Monto = @Or" & _
        "iginal_Monto) AND (NombreCuenta = @Original_NombreCuenta) AND (NumAsiento = @Ori" & _
        "ginal_NumAsiento) AND (TipoCambio = @Original_TipoCambio OR @Original_TipoCambio" & _
        " IS NULL AND TipoCambio IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO DetallesAsientosContable(NumAsiento, Cuenta, NombreCuenta, Monto, Deb" & _
        "e, Haber, DescripcionAsiento, TipoCambio) VALUES (@NumAsiento, @Cuenta, @NombreC" & _
        "uenta, @Monto, @Debe, @Haber, @DescripcionAsiento, @TipoCambio); SELECT ID_Detal" & _
        "le, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, Ti" & _
        "poCambio FROM DetallesAsientosContable WHERE (ID_Detalle = @@IDENTITY) ORDER BY " & _
        "Cuenta"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT ID_Detalle, NumAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, Descripc" & _
        "ionAsiento, TipoCambio FROM DetallesAsientosContable ORDER BY Cuenta"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE DetallesAsientosContable SET NumAsiento = @NumAsiento, Cuenta = @Cuenta, N" & _
        "ombreCuenta = @NombreCuenta, Monto = @Monto, Debe = @Debe, Haber = @Haber, Descr" & _
        "ipcionAsiento = @DescripcionAsiento, TipoCambio = @TipoCambio WHERE (ID_Detalle " & _
        "= @Original_ID_Detalle) AND (Cuenta = @Original_Cuenta) AND (Debe = @Original_De" & _
        "be) AND (DescripcionAsiento = @Original_DescripcionAsiento) AND (Haber = @Origin" & _
        "al_Haber) AND (Monto = @Original_Monto) AND (NombreCuenta = @Original_NombreCuen" & _
        "ta) AND (NumAsiento = @Original_NumAsiento) AND (TipoCambio = @Original_TipoCamb" & _
        "io OR @Original_TipoCambio IS NULL AND TipoCambio IS NULL); SELECT ID_Detalle, N" & _
        "umAsiento, Cuenta, NombreCuenta, Monto, Debe, Haber, DescripcionAsiento, TipoCam" & _
        "bio FROM DetallesAsientosContable WHERE (ID_Detalle = @ID_Detalle) ORDER BY Cuen" & _
        "ta"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NumAsiento", System.Data.SqlDbType.VarChar, 15, "NumAsiento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Cuenta", System.Data.SqlDbType.VarChar, 255, "Cuenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@NombreCuenta", System.Data.SqlDbType.VarChar, 250, "NombreCuenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Monto", System.Data.SqlDbType.Float, 8, "Monto"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Debe", System.Data.SqlDbType.Bit, 1, "Debe"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Haber", System.Data.SqlDbType.Bit, 1, "Haber"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, "DescripcionAsiento"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TipoCambio", System.Data.SqlDbType.Float, 8, "TipoCambio"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ID_Detalle", System.Data.SqlDbType.BigInt, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ID_Detalle", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Cuenta", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Cuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Debe", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Debe", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescripcionAsiento", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescripcionAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Haber", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Haber", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Monto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Monto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NombreCuenta", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NombreCuenta", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_NumAsiento", System.Data.SqlDbType.VarChar, 15, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NumAsiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TipoCambio", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TipoCambio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ID_Detalle", System.Data.SqlDbType.BigInt, 8, "ID_Detalle"))
        '
        'PrintableComponentLink1
        '
        Me.PrintableComponentLink1.PrintingSystem = Me.PrintingSystem1
        '
        'PrintingSystem1
        '
        Me.PrintingSystem1.Links.AddRange(New Object() {Me.PrintableComponentLink1, Me.Link1})
        '
        'Link1
        '
        Me.Link1.PrintingSystem = Me.PrintingSystem1
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(-48, 428)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 16)
        Me.Label7.TabIndex = 173
        Me.Label7.Text = "Saldo Anterior¢"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AdapterMoneda
        '
        Me.AdapterMoneda.InsertCommand = Me.SqlInsertCommand5
        Me.AdapterMoneda.SelectCommand = Me.SqlSelectCommand5
        Me.AdapterMoneda.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Saldo Anterior"
        Me.GridColumn3.DisplayFormat.FormatString = "#,##0.00"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn3.FieldName = "SaldoAnterior"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.Width = 32
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Enabled = False
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarExportar, Me.ToolBarImprimir, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(100, 50)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 406)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(1072, 52)
        Me.ToolBar1.TabIndex = 171
        '
        'ToolBarExportar
        '
        Me.ToolBarExportar.Enabled = False
        Me.ToolBarExportar.ImageIndex = 5
        Me.ToolBarExportar.Text = "Exportar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Panel1.Controls.Add(Me.CboMes)
        Me.Panel1.Controls.Add(Me.LblMes)
        Me.Panel1.Controls.Add(Me.btnBuscarPeriodoFiscal)
        Me.Panel1.Controls.Add(Me.txtPeriodoFiscal)
        Me.Panel1.Controls.Add(Me.LblPeriodoFiscal)
        Me.Panel1.Controls.Add(Me.btnImprimir)
        Me.Panel1.Controls.Add(Me.Check_Cierre)
        Me.Panel1.Controls.Add(Me.smbGenerar)
        Me.Panel1.Location = New System.Drawing.Point(-116, 36)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1176, 76)
        Me.Panel1.TabIndex = 170
        '
        'CboMes
        '
        Me.CboMes.Items.AddRange(New Object() {"ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE"})
        Me.CboMes.Location = New System.Drawing.Point(568, 24)
        Me.CboMes.Name = "CboMes"
        Me.CboMes.Size = New System.Drawing.Size(121, 21)
        Me.CboMes.TabIndex = 31
        '
        'LblMes
        '
        Me.LblMes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMes.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblMes.Location = New System.Drawing.Point(528, 24)
        Me.LblMes.Name = "LblMes"
        Me.LblMes.Size = New System.Drawing.Size(40, 24)
        Me.LblMes.TabIndex = 12
        Me.LblMes.Text = "Mes:"
        '
        'btnBuscarPeriodoFiscal
        '
        Me.btnBuscarPeriodoFiscal.Location = New System.Drawing.Point(464, 24)
        Me.btnBuscarPeriodoFiscal.Name = "btnBuscarPeriodoFiscal"
        Me.btnBuscarPeriodoFiscal.Size = New System.Drawing.Size(48, 23)
        Me.btnBuscarPeriodoFiscal.TabIndex = 11
        Me.btnBuscarPeriodoFiscal.Text = "Buscar"
        '
        'txtPeriodoFiscal
        '
        Me.txtPeriodoFiscal.Enabled = False
        Me.txtPeriodoFiscal.Location = New System.Drawing.Point(200, 24)
        Me.txtPeriodoFiscal.Name = "txtPeriodoFiscal"
        Me.txtPeriodoFiscal.Size = New System.Drawing.Size(232, 20)
        Me.txtPeriodoFiscal.TabIndex = 10
        Me.txtPeriodoFiscal.Text = ""
        '
        'LblPeriodoFiscal
        '
        Me.LblPeriodoFiscal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPeriodoFiscal.ForeColor = System.Drawing.SystemColors.Highlight
        Me.LblPeriodoFiscal.Location = New System.Drawing.Point(128, 24)
        Me.LblPeriodoFiscal.Name = "LblPeriodoFiscal"
        Me.LblPeriodoFiscal.Size = New System.Drawing.Size(64, 24)
        Me.LblPeriodoFiscal.TabIndex = 9
        Me.LblPeriodoFiscal.Text = "Periodo :"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(800, 24)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        '
        'Check_Cierre
        '
        Me.Check_Cierre.Enabled = False
        Me.Check_Cierre.Location = New System.Drawing.Point(1080, 8)
        Me.Check_Cierre.Name = "Check_Cierre"
        Me.Check_Cierre.Size = New System.Drawing.Size(96, 32)
        Me.Check_Cierre.TabIndex = 7
        Me.Check_Cierre.Text = "Excluir Cierre Anual"
        '
        'smbGenerar
        '
        Me.smbGenerar.Location = New System.Drawing.Point(712, 24)
        Me.smbGenerar.Name = "smbGenerar"
        Me.smbGenerar.TabIndex = 4
        Me.smbGenerar.Text = "Mostrar"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 112)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1056, 16)
        Me.ProgressBar1.TabIndex = 33
        Me.ProgressBar1.Visible = False
        '
        'AdCuentas
        '
        Me.AdCuentas.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdCuentas.InsertCommand = Me.SqlInsertCommand1
        Me.AdCuentas.SelectCommand = Me.SqlSelectCommand1
        Me.AdCuentas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CuentaContable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CuentaContable", "CuentaContable"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion"), New System.Data.Common.DataColumnMapping("Nivel", "Nivel"), New System.Data.Common.DataColumnMapping("Tipo", "Tipo"), New System.Data.Common.DataColumnMapping("CuentaMadre", "CuentaMadre"), New System.Data.Common.DataColumnMapping("Movimiento", "Movimiento"), New System.Data.Common.DataColumnMapping("id", "id"), New System.Data.Common.DataColumnMapping("PARENTID", "PARENTID"), New System.Data.Common.DataColumnMapping("DescCuentaMadre", "DescCuentaMadre")})})
        Me.AdCuentas.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM CuentaContable WHERE (CuentaContable = @Original_CuentaContable) AND " & _
        "(CuentaMadre = @Original_CuentaMadre) AND (DescCuentaMadre = @Original_DescCuent" & _
        "aMadre) AND (Descripcion = @Original_Descripcion) AND (Movimiento = @Original_Mo" & _
        "vimiento) AND (Nivel = @Original_Nivel) AND (PARENTID = @Original_PARENTID) AND " & _
        "(Tipo = @Original_Tipo) AND (id = @Original_id)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaContable", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaContable", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CuentaMadre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_DescCuentaMadre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "DescCuentaMadre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Movimiento", System.Data.SqlDbType.Bit, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Movimiento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Nivel", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Nivel", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_PARENTID", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PARENTID", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Tipo", System.Data.SqlDbType.VarChar, 250, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Tipo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "id", System.Data.DataRowVersion.Original, Nothing))
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Código"
        Me.GridColumn1.FieldName = "Codigo"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.Width = 154
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Descripción"
        Me.GridColumn2.FieldName = "Descripcion"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.Width = 25
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(72, 428)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 177
        Me.Label4.Text = "Débitos¢"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(432, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 181
        Me.Label6.Text = "Saldo Actual¢"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BandedGridView1
        '
        Me.BandedGridView1.Name = "BandedGridView1"
        Me.BandedGridView1.OptionsPrint.PrintDetails = True
        Me.BandedGridView1.OptionsPrint.UsePrintStyles = True
        Me.BandedGridView1.OptionsView.ShowGroupedColumns = False
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.Color.FromArgb(CType(56, Byte), CType(91, Byte), CType(165, Byte))
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(1072, 32)
        Me.TituloModulo.TabIndex = 169
        Me.TituloModulo.Text = "Estado Resultados vs Presupuesto"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DsBalances11
        '
        Me.DsBalances11.DataSetName = "DsBalances"
        Me.DsBalances11.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'TreeList1
        '
        Me.TreeList1.BehaviorOptions = CType(((((((((DevExpress.XtraTreeList.BehaviorOptionsFlags.MoveOnEdit Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ExpandNodeOnDrag) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.ResizeNodes) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoSelectAllInEditor) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoNodeHeight) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.AutoChangeParent) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.CloseEditorOnLostFocus) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.KeepSelectedOnClick) _
                    Or DevExpress.XtraTreeList.BehaviorOptionsFlags.SmartMouseHover), DevExpress.XtraTreeList.BehaviorOptionsFlags)
        Me.TreeList1.Location = New System.Drawing.Point(0, 128)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "PARENTID"
        Me.TreeList1.Size = New System.Drawing.Size(1056, 256)
        Me.TreeList1.TabIndex = 193
        Me.TreeList1.Text = "TreeList1"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        Me.DataSet1.Locale = New System.Globalization.CultureInfo("es-ES")
        '
        'FrmEstadoResultadovsPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1072, 458)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "FrmEstadoResultadovsPresupuesto"
        Me.Text = "FrmEstadoResultadovsPresupuesto"
        CType(Me.PrintingSystem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.BandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsBalances11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


#Region "Variables"
    Dim ps As New DevExpress.XtraPrinting.PrintingSystem
    Dim link As New DevExpress.XtraPrinting.PrintableComponentLink(ps)
    Dim usua As Object
    Dim conectadobd As New SqlClient.SqlConnection
    Dim Cconexion As New Conexion
    Dim Reporte_ID As Integer
    Dim Tipo As Integer
    Dim txtFechaInicial As String = ""
    Dim txtFechaFinal As String = ""
    Dim AnaliticotxtFechaInicial As String = ""
    Dim AnaliticotxtFechaFinal As String = ""
    Dim IDPeriodo As Integer = 0
    Dim StrPeriodoFiscal As String = ""
    Dim CtxtFechaInicial As String = ""
    Dim dtsCuentaPresupuesto As DataSet
    Public DtstbCuentaPresupuesto As New DataTable

#End Region


#Region "Load"




    Private Sub progressBar()


        'Perform 1 step. One step is specified above as 1/10 increase of the ProgressBar
        'In most cases you'd place the performstep command in a loop (that copies files, to use the example above)
        ProgressBar1.PerformStep()

    End Sub

    Private Sub crearColumnas()
        Dim i As Integer
        Dim tabla As DataTable
        Dim campo As DataColumn
        Dim registro As DataRow
        campo = New DataColumn("MontoPresupuesto", GetType(System.Double))
        DtstbCuentaPresupuesto.Columns.Add(campo)
    End Sub


    Private Sub frmBalanceComprobacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try



            'On form load: configure the progressbar
            ProgressBar1.Minimum = 0
            'In most cases you wouldnt use a fixed maximum. For example: count the number of files you want to copy and set that as the maximum
            ProgressBar1.Maximum = 8
            'Adjust the speed at which the progressbar fills up
            ProgressBar1.Step = 1

            Tipo = 1
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            conectadobd = Cconexion.Conectar("Contabilidad")
            Estado(False)
            InitData()
            AdapterMoneda.Fill(DsBalances11, "Moneda")
            Tipo = 1
            If Tipo = 1 Then
                'Me.Moneda.Visible = False
                'Me.Label8.Visible = False
            End If
            'TreeList1.DataSource = DtstbCuentaPresupuesto

            smbGenerar.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub InitData()
        If Tipo = 1 Then
         
            CreateColumn(TreeList1, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList1, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
            CreateColumn(TreeList1, "Saldo Mes ¢", "SaldoMes", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")

         

            CreateColumn(TreeList1, "Presupuestado ¢", "MontoPresupuesto", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList1, "Diferencia ¢", "Diferencia", 7, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            CreateColumn(TreeList1, "% ¢", "Porcentaje", 8, Convert.ToDouble(DevExpress.Utils.FormatType.Numeric), "#,##0.00")
            CreateColumn(TreeList1, "Nivel", "Nivel", -1, DevExpress.Utils.FormatType.Numeric, "#,##0.00")




        Else
            'CreateColumn(TreeList2, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
            'CreateColumn(TreeList2, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
            'CreateColumn(TreeList2, "Saldo Anterior", "SaldoAnterior", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            'CreateColumn(TreeList2, "Débitos", "Debitos", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            'CreateColumn(TreeList2, "Créditos", "Creditos", 4, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            'CreateColumn(TreeList2, "Saldo Mes", "SaldoMes", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
            'CreateColumn(TreeList2, "Saldo Actual", "SaldoActual", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")

            'CreateColumn(TreeList2, "Nivel", "Nivel", -1, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        End If

        'TreeList2.BestFitColumns()
        TreeList1.BestFitColumns()
    End Sub


    Private Sub CreateColumn(ByVal tl As TreeList, ByVal caption As String, ByVal field As String, ByVal visibleindex As Integer, ByVal formatType As DevExpress.Utils.FormatType, ByVal formatString As String)
        Dim col As DevExpress.XtraTreeList.Columns.TreeListColumn = tl.Columns.Add()
        col.Caption = caption
        col.FieldName = field
        col.VisibleIndex = visibleindex
        col.Format.FormatType = formatType
        If formatType = DevExpress.Utils.FormatType.Custom Then
            col.Format.Format = New BaseFormatter
        End If
        col.Format.FormatString = formatString
    End Sub
#End Region

#Region "Controles"
    Private Sub LLenarCeros()
        Dim n As Integer
        For n = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1


            If Tipo = 1 Then
                DsBalances11.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
                DsBalances11.CuentaContable.Rows(n).Item("Debitos") = 0
                DsBalances11.CuentaContable.Rows(n).Item("Creditos") = 0
                DsBalances11.CuentaContable.Rows(n).Item("SaldoMes") = 0
                DsBalances11.CuentaContable.Rows(n).Item("SaldoActual") = 0

                DsBalances11.CuentaContable.Rows(n).Item("SaldoAnteriorD") = 0
                DsBalances11.CuentaContable.Rows(n).Item("DebitosD") = 0
                DsBalances11.CuentaContable.Rows(n).Item("CreditosD") = 0
                DsBalances11.CuentaContable.Rows(n).Item("SaldoMesD") = 0
                DsBalances11.CuentaContable.Rows(n).Item("SaldoActualD") = 0
            Else
                DsBalances11.CuentaContable.Rows(n).Item("SaldoAnterior") = 0
                DsBalances11.CuentaContable.Rows(n).Item("Debitos") = 0
                DsBalances11.CuentaContable.Rows(n).Item("Creditos") = 0
                DsBalances11.CuentaContable.Rows(n).Item("SaldoMes") = 0
                DsBalances11.CuentaContable.Rows(n).Item("SaldoActual") = 0
            End If

        Next

    End Sub


    Function Estado(ByVal valor As Boolean)
        'Me.dtFinal.Enabled = valor
        'Me.dtInicial.Enabled = valor
        smbGenerar.Enabled = valor
        Check_Cierre.Enabled = valor

    End Function


    Private Sub dtInicial_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'dtFinal.Focus()
        End If
    End Sub


    Private Sub dtFinal_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            'Moneda.Focus()
        End If
    End Sub


    Private Sub Moneda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            smbGenerar.Focus()
        End If
    End Sub
#End Region

#Region "ToolBar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(Usuario.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0 : Nuevo()

            Case 1 : If PMU.Print Then Importar() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 2 : If PMU.Print Then Imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

            Case 3 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Generar Balance"
    Private Sub smbGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles smbGenerar.Click
        Try
            If txtPeriodoFiscal.Text <> "" And CboMes.Text <> "" Then
                Me.ProgressBar1.Visible = True
                Me.ProgressBar1.Value = 0
                TreeList1.Refresh()
                'TreeList2.Refresh()
                'Me.TreeList2.DataSource = ""
                'Me.TreeList2.DataMember = ""
                Me.TreeList1.DataSource = ""
                Me.TreeList1.DataMember = ""

                'Dim Fecha1, Fecha2 As Date
                'Dim Fecha1, Fecha2 As DateTime
                'MsgBox(dtFinal.Value)
                'Fecha1 = Format(dtInicial.Value, "dd/MM/yyyy H:mm:ss")
                'Fecha2 = Format(dtFinal.Value, "dd/MM/yyyy H:mm:ss")
                'If Fecha1 > Fecha2 Then
                'Msg'Box("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
                'Exit Sub
                'End If

                'Fecha1 = Format(txtFechaInicial, "dd/MM/yyyy H:mm:ss")
                'Fecha2 = Format(txtFechaFinal, "dd/MM/yyyy H:mm:ss")

                Me.DsBalances11.Temporal2.Clear()
                Me.DsBalances11.CuentaContable.Clear()
                Me.DsBalances11.Usuarios.Clear()
                Me.DsBalances11.DetallesAsientosContable.Clear()
                Me.DsBalances11.AsientosContables.Clear()
                AdCuentas.Fill(Me.DsBalances11.CuentaContable)
                'Me.AdDetalleAsiento.Fill(Me.DsBalances1.DetallesAsientosContable) 'Llenar solo lo del mes del período de trabajo
                'TreeList2.Columns(1).Width = 300
                LLenarCeros()
                CargarAsientos(txtFechaInicial)
                CargarDebitos(txtFechaInicial, txtFechaFinal)
                Calcular_Saldos()
                'Calcular()

                'TreeList2.DataSource = DsBalances11
                'TreeList2.DataMember = "CuentaContable"

                'TreeList1.DataSource = DsBalances11
                'TreeList1.DataMember = "CuentaContable"
                TreeList1.DataSource = DtstbCuentaPresupuesto
                'Me.dtFinal.Enabled = False
                'Me.dtInicial.Enabled = False
                Check_Cierre.Enabled = False


                Me.ProgressBar1.Visible = False



            Else
                MsgBox("Debe Seleccionar Periodo Fiscal y Mes", MsgBoxStyle.Exclamation, "")
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Cargar Asientos"
    Function CargarAsientos(ByVal FechaInicio As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES PARA EL CALCULO DEL SALDO ANTERIOR
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Dim i, n, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String
            If Check_Cierre.Checked = False Then
                sel = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
                            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
                            " FROM         dbo.AsientoDC_DH INNER JOIN " & _
                            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
                            " WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) " & _
                            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
            Else
                sel = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon)AS Dcolon, " & _
                                            " SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
                                            " FROM         dbo.AsientoDC_DH INNER JOIN " & _
                                            " dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
                                            " WHERE     (Fecha < dbo.DateOnlyInicio(@Fecha)) AND (AsientoDC_DH.NumAsiento <> '" & CierreAnual() & "'" & _
                                            " GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "
                ' Si hay que excluir el asiento cierre anual

            End If


            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Periodo", SqlDbType.VarChar, 10))

            cmdv.Parameters("@Periodo").Value = funcion.BuscaPeriodo(CtxtFechaInicial)
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsBalances11.AsientoDC_DH_AG.Clear()
            dv.Fill(Me.DsBalances11.AsientoDC_DH_AG)
            If Me.DsBalances11.AsientoDC_DH_AG.Rows.Count = 0 Then
                Exit Function
            End If
            For x = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1
                For i = 0 To Me.DsBalances11.AsientoDC_DH_AG.Rows.Count - 1
                    If Me.DsBalances11.AsientoDC_DH_AG(i).Cuenta.Equals(Me.DsBalances11.CuentaContable(x).CuentaContable) Then
                        If Tipo = 1 Then
                            Debe += Me.DsBalances11.AsientoDC_DH_AG(i).Dcolon
                            Haber += Me.DsBalances11.AsientoDC_DH_AG(i).Hcolon
                            DebeD += Me.DsBalances11.AsientoDC_DH_AG(i).Ddolar
                            HaberD += Me.DsBalances11.AsientoDC_DH_AG(i).Hdolar
                        Else
                            'If Moneda.SelectedValue = 1 Then
                            '    Debe += Me.DsBalances11.AsientoDC_DH_AG(i).Dcolon
                            '    Haber += Me.DsBalances11.AsientoDC_DH_AG(i).Hcolon

                            'Else
                            '    Debe += Me.DsBalances11.AsientoDC_DH_AG(i).Ddolar
                            '    Haber += Me.DsBalances11.AsientoDC_DH_AG(i).Hdolar
                            'End If

                        End If
                    End If
                Next

                If Tipo = 1 Then
                    If DsBalances11.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DsBalances11.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DsBalances11.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        DsBalances11.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                        DsBalances11.CuentaContable.Rows(x).Item("SaldoAnteriorD") = DebeD - HaberD
                    Else
                        DsBalances11.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                        DsBalances11.CuentaContable.Rows(x).Item("SaldoAnteriorD") = HaberD - DebeD
                    End If
                Else
                    If DsBalances11.CuentaContable.Rows(x).Item("Tipo") = "ACTIVOS" Or DsBalances11.CuentaContable.Rows(x).Item("Tipo") = "COSTO VENTA" Or DsBalances11.CuentaContable.Rows(x).Item("Tipo") = "GASTOS" Then
                        DsBalances11.CuentaContable.Rows(x).Item("SaldoAnterior") = Debe - Haber
                    Else
                        DsBalances11.CuentaContable.Rows(x).Item("SaldoAnterior") = Haber - Debe
                    End If

                End If
                Debe = 0
                Haber = 0
                DebeD = 0
                HaberD = 0
            Next
            progressBar()
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function


    Function CargarDebitos(ByVal FechaInicio As String, ByVal FechaFinal As String)
        Dim cnnv As SqlConnection = Nothing     'CARGA LOS ASIENTOS CONTABLES DEL PERIODO
        Dim cConexion As New Conexion
        Dim funcion As New cFunciones
        Dim Debe, Haber, Monto, DebeD, HaberD As Double
        Dim i, n, x As Integer

        Try
            Dim sConn As String = Configuracion.Claves.Conexion("Contabilidad")
            cnnv = New SqlConnection(sConn)
            cnnv.Open()
            'Creamos el comando para la consulta
            Dim cmdv As SqlCommand = New SqlCommand
            Dim sel As String = " SELECT     dbo.AsientoDC_DH.Cuenta, SUM(dbo.AsientoDC_DH.DebeDolar) AS Ddolar, SUM(dbo.AsientoDC_DH.DebeColon) AS Dcolon, " & _
" SUM(dbo.AsientoDC_DH.HaberColon) AS Hcolon, SUM(dbo.AsientoDC_DH.HaberDolar) AS Hdolar, dbo.CuentaContable.Descripcion " & _
" FROM         dbo.AsientoDC_DH INNER JOIN " & _
" dbo.CuentaContable ON dbo.AsientoDC_DH.Cuenta = dbo.CuentaContable.CuentaContable " & _
" WHERE     (Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)) " & _
" GROUP BY dbo.AsientoDC_DH.Cuenta, dbo.CuentaContable.Descripcion "

            'Dim sel As String = "SELECT * FROM AsientoDC_DH_AG WHERE Fecha >= dbo.DateOnlyInicio(@Fecha) AND Fecha <= dbo.DateOnlyFinal(@Fecha2)"
            If Check_Cierre.Checked Then
                sel = sel & " AND (AsientosContables.NumAsiento <> '" & CierreAnual() & "')"
            End If
            cmdv.CommandText = sel
            cmdv.Connection = cnnv
            cmdv.CommandType = CommandType.Text
            cmdv.CommandTimeout = 90
            'Los parámetros usados en la cadena de la consulta 
            cmdv.Parameters.Add(New SqlParameter("@Fecha", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha").Value = Format(FechaInicio, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha").Value = FechaInicio
            cmdv.Parameters.Add(New SqlParameter("@Fecha2", SqlDbType.DateTime))
            'cmdv.Parameters("@Fecha2").Value = Format(FechaFinal, "dd/MM/yyyy H:mm:ss")
            cmdv.Parameters("@Fecha2").Value = FechaFinal
            'Creamos el dataAdapter y asignamos el comando de selección
            Dim dv As New SqlDataAdapter
            dv.SelectCommand = cmdv
            ' Llenamos la tabla
            Me.DsBalances11.AsientoDC_DH_AG.Clear()

            dv.Fill(Me.DsBalances11.AsientoDC_DH_AG)

            For x = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1

                For i = 0 To Me.DsBalances11.AsientoDC_DH_AG.Rows.Count - 1
                    Dim cuent As String = Me.DsBalances11.AsientoDC_DH_AG(i).Cuenta.TrimEnd(" ")
                    If cuent.Equals(Me.DsBalances11.CuentaContable(x).CuentaContable) Then
                        If Me.Tipo = 1 Then
                            DsBalances11.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances11.AsientoDC_DH_AG(i).Dcolon
                            DsBalances11.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances11.AsientoDC_DH_AG(i).Hcolon
                            DsBalances11.CuentaContable.Rows(x).Item("DebitosD") += Me.DsBalances11.AsientoDC_DH_AG(i).Ddolar
                            DsBalances11.CuentaContable.Rows(x).Item("CreditosD") += Me.DsBalances11.AsientoDC_DH_AG(i).Hdolar

                        Else
                            'If Moneda.SelectedValue = 1 Then
                            '    DsBalances11.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances11.AsientoDC_DH_AG(i).Dcolon
                            '    DsBalances11.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances11.AsientoDC_DH_AG(i).Hcolon
                            'Else
                            '    DsBalances11.CuentaContable.Rows(x).Item("Debitos") += Me.DsBalances11.AsientoDC_DH_AG(i).Ddolar
                            '    DsBalances11.CuentaContable.Rows(x).Item("Creditos") += Me.DsBalances11.AsientoDC_DH_AG(i).Hdolar

                            'End If

                        End If

                    End If

                Next
            Next

            progressBar()
        Catch ex As System.Exception
            MsgBox(ex.ToString)
        Finally
            If Not cnnv Is Nothing Then
                cnnv.Close()
            End If
        End Try
    End Function


    Function CierreAnual() As String
        Try
            Dim cConexion As New Conexion       'BUSCA NUMERO DE ASIENTO DEL ULTIMO CIERRE ANUAL
            CierreAnual = cConexion.SlqExecuteScalar(cConexion.Conectar("Contabilidad"), "SELECT NumAsiento FROM dbo.AsientosContables WHERE TipoDoc = 30 AND Anulado = 0 AND Mayorizado = 1 AND Fecha <= dbo.DateOnlyFinal('" & Format(txtFechaFinal, "dd/MM/yyyy H:mm:ss") & "') ORDER BY Fecha DESC")
            cConexion.DesConectar(cConexion.sQlconexion)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Comunique el siguiente error a su Empresa Proveedora de Software")
        End Try
    End Function
#End Region

#Region "Calculos"
    Private Sub Calcular()
        Dim i, n, j, k, h As Integer
        Dim SaldoAnterior, Debitos, Creditos, SaldoMes, SaldoActual As Double
        Dim Total As String
        Dim SaldoAnterior1, Debitos1, Creditos1, SaldoMes1, SaldoActual1 As Double

        Try
            '-----------------------------------------------------------------------------------------------------------------------------------------
            Calcular(6)
            progressBar()
            Calcular(5)
            progressBar()
            Calcular(4)
            progressBar()
            Calcular(3)
            Calcular(2)
            progressBar()
            Calcular(1)

            For k = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1
                If Tipo = 0 Then
                    If Me.DsBalances11.CuentaContable.Rows(k).Item("Nivel") = 0 Then
                        If DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                            SaldoAnterior = SaldoAnterior + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            SaldoMes = SaldoMes + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                            SaldoActual = SaldoActual + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual")
                        Else
                            SaldoAnterior = SaldoAnterior - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            SaldoMes = SaldoMes - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                            SaldoActual = SaldoActual - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual")
                        End If
                        Debitos = Debitos + Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                        Creditos = Creditos + Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                    End If
                Else
                    If Me.DsBalances11.CuentaContable.Rows(k).Item("Nivel") = 0 Then
                        If DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                            SaldoAnterior = SaldoAnterior + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            SaldoAnterior1 = SaldoAnterior1 + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnteriorD")
                            SaldoMes = SaldoMes + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                            SaldoMes1 = SaldoMes1 + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMesD")
                            SaldoActual = SaldoActual + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual")
                            SaldoActual1 = SaldoActual1 + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActualD")

                        Else
                            SaldoAnterior = SaldoAnterior - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            SaldoMes = SaldoMes - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                            SaldoActual = SaldoActual - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual")
                            SaldoAnterior1 = SaldoAnterior1 - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnteriorD")
                            SaldoMes1 = SaldoMes1 - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMesD")
                            SaldoActual1 = SaldoActual1 - Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActualD")
                        End If
                        Debitos = Debitos + Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                        Creditos = Creditos + Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                        Debitos1 = Debitos1 + Me.DsBalances11.CuentaContable.Rows(k).Item("DebitosD")
                        Creditos1 = Creditos1 + Me.DsBalances11.CuentaContable.Rows(k).Item("CreditosD")
                    End If
                End If
            Next

            'Me.txtSaldoAnterior.Text = Format(SaldoAnterior, "#,#0.00")
            'Me.txtDebitos.Text = Format(Debitos, "#,#0.00")
            'Me.txtCreditos.Text = Format(Creditos, "#,#0.00")
            'Me.txtSaldoMes.Text = Format(SaldoMes, "#,#0.00")
            'Me.txtSaldoActual.Text = Format(SaldoActual, "#,#0.00")
            If Tipo = 1 Then
                'Me.TextBox1.Text = Format(SaldoAnterior1, "#,#0.00")
                ''Me.TextBox2.Text = Format(Debitos1, "#,#0.00")
                'Me.TextBox3.Text = Format(Creditos1, "#,#0.00")
                'Me.TextBox4.Text = Format(SaldoMes1, "#,#0.00")
                'Me.TextBox5.Text = Format(SaldoActual1, "#,#0.00")
            End If

            progressBar()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub


    Function Calcular(ByVal Nivel As Integer)
        Dim k, j As Integer
        Dim txtMontoPresupuestoMes As Double = 0.0
        For k = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1
            If Me.DsBalances11.CuentaContable.Rows(k).Item("Nivel") = Nivel Then
                For j = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1


                    'If (Me.DsBalances11.CuentaContable.Rows(k).Item("CuentaContable") = Me.DsBalances11.CuentaContable.Rows(j).Item("CuentaContable")) Then
                    '    If Me.DsBalances11.CuentaContable.Rows(j).Item("Id") = Me.DsBalances11.CuentaContable.Rows(k).Item("PARENTID") Then
                    '        Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") + txtMontoPresupuestoMes


                    '    Else
                    '        Dim DtsTPresupuestos As New DataTable
                    '        Dim sel As String = ""
                    '        txtMontoPresupuestoMes = 0.0
                    '        sel = "SELECT  " & CboMes.Text & " as MONTO  FROM CUENTACONTABLE AS CC, PRESUPUESTOS AS P " _
                    '        & " WHERE P.Id_Periodo_Fiscal=5 AND  P.CUENTA_CONTABLE=CC.CuentaContable_Presupuesto AND CC.CuentaContable_Presupuesto <> '' and CC.CUENTACONTABLE ='" & Me.DsBalances11.CuentaContable.Rows(j).Item("CuentaContable") & "'"
                    '        'sel = "SELECT SUM(P.ENERO) AS MONTO FROM CUENTACONTABLE AS CC, PRESUPUESTOS AS P" _
                    '        '& " WHERE P.Id_Periodo_Fiscal=5 AND  P.CUENTA_CONTABLE=CC.CuentaContable_Presupuesto AND CC.CuentaContable_Presupuesto <> '' and  CC.PARENTID =(SELECT id FROM CUENTACONTABLE WHERE Movimiento =0 and CUENTACONTABLE ='" & Me.DsBalances11.CuentaContable.Rows(k).Item("Cuentacontable") & "')"

                    '        cFunciones.Llenar_Tabla_Generico(sel, DtsTPresupuestos, Configuracion.Claves.Conexion("Contabilidad"))
                    '        For Fila As Integer = 0 To DtsTPresupuestos.Rows.Count - 1

                    '            txtMontoPresupuestoMes = Convert.ToDouble(DtsTPresupuestos.Rows(Fila)("MONTO").ToString())
                    '        Next

                    '        Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") + txtMontoPresupuestoMes
                    '        'Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = txtMontoPresupuestoMes

                    '    End If


                    'End If

                    If Me.DsBalances11.CuentaContable.Rows(j).Item("Id") = Me.DsBalances11.CuentaContable.Rows(k).Item("PARENTID") Then
                        If Me.Tipo = 1 Then


                            'Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            'Me.DsBalances11.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalances11.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                            'Me.DsBalances11.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalances11.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                            ''Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") + 2000
                            'Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActual") + txtMontoPresupuestoMes


                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalances11.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalances11.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActual") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual")

                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnteriorD") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnteriorD") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnteriorD")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("DebitosD") = Me.DsBalances11.CuentaContable.Rows(j).Item("DebitosD") + Me.DsBalances11.CuentaContable.Rows(k).Item("DebitosD")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("CreditosD") = Me.DsBalances11.CuentaContable.Rows(j).Item("CreditosD") + Me.DsBalances11.CuentaContable.Rows(k).Item("CreditosD")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMesD") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMesD") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMesD")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActualD") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActualD") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActualD")
                        Else

                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnterior") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoAnterior") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("Debitos") = Me.DsBalances11.CuentaContable.Rows(j).Item("Debitos") + Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("Creditos") = Me.DsBalances11.CuentaContable.Rows(j).Item("Creditos") + Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                            'Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = 5000
                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoMes") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                            Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActual") = Me.DsBalances11.CuentaContable.Rows(j).Item("SaldoActual") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual")

                        End If



                    End If
                Next
            End If
        Next

    End Function


    Private Sub CargarDtstbCuentaPresupuesto()
        Dim selSQL As String = ""
        selSQL = "select *,0.0 as MontoPresupuesto, 0.0 as SaldoMes, 0.0 AS Diferencia, 0.0 as  Porcentaje from CuentaContable_Presupuestaria  "
        '''sel = "select *, 0.0 as SaldoMes, 0.0 AS Diferencia, 0.0 as  Porcentaje  from CuentaContable_Presupuestaria  where Movimiento <> 0 "
        cFunciones.Llenar_Tabla_Generico(selSQL, DtstbCuentaPresupuesto, Configuracion.Claves.Conexion("Contabilidad"))
        '''crearColumnas()
    End Sub


    Private Sub CalcularNivel(ByVal txtnivel As Integer)
        '''Sumar Cuenta Madre
        For dttfila As Integer = 0 To DtstbCuentaPresupuesto.Rows.Count - 1
            Dim SumaSaldoMes As Double = 0.0
            If DtstbCuentaPresupuesto.Rows(dttfila)("Movimiento") = False Then
                Dim id As Integer = DtstbCuentaPresupuesto.Rows(dttfila)("id")

                For dtxfila As Integer = 0 To DtstbCuentaPresupuesto.Rows.Count - 1
                    If (txtnivel = DtstbCuentaPresupuesto.Rows(dtxfila)("Nivel")) Then
                        If (id = DtstbCuentaPresupuesto.Rows(dtxfila)("PARENTID")) Then
                            DtstbCuentaPresupuesto.Rows(dttfila)("SaldoMes") = DtstbCuentaPresupuesto.Rows(dttfila)("SaldoMes") + DtstbCuentaPresupuesto.Rows(dtxfila)("SaldoMes")
                            DtstbCuentaPresupuesto.Rows(dttfila)("MontoPresupuesto") = DtstbCuentaPresupuesto.Rows(dttfila)("MontoPresupuesto") + DtstbCuentaPresupuesto.Rows(dtxfila)("MontoPresupuesto")
                            DtstbCuentaPresupuesto.Rows(dttfila)("Diferencia") = DtstbCuentaPresupuesto.Rows(dttfila)("MontoPresupuesto") - DtstbCuentaPresupuesto.Rows(dttfila)("SaldoMes")
                            If (DtstbCuentaPresupuesto.Rows(dttfila)("MontoPresupuesto") <> 0.0) Then
                                DtstbCuentaPresupuesto.Rows(dttfila)("Porcentaje") = ((Convert.ToDouble(DtstbCuentaPresupuesto.Rows(dttfila)("Diferencia")) * Convert.ToDouble(100)) / DtstbCuentaPresupuesto.Rows(dttfila)("MontoPresupuesto"))
                                'SumaSaldoMes = SumaSaldoMes + Convert.ToDouble(DtstbCuentaPresupuesto.Rows(dtxfila)("SaldoMes"))
                            Else
                                DtstbCuentaPresupuesto.Rows(dttfila)("Porcentaje") = 0.0
                            End If
                        End If
                    End If
                Next

            End If
            'DtstbCuentaPresupuesto.Rows(dttfila)("SaldoMes") = SumaSaldoMes

        Next
    End Sub




    Public Function TruncarCuenta() As DataTable

        Try
            '''Truncar o quitar Ceros  a las cuentas 
            Dim AuxDtstbCuentaPresupuesto As New DataTable
            AuxDtstbCuentaPresupuesto = DtstbCuentaPresupuesto
            For dtxfila As Integer = 0 To AuxDtstbCuentaPresupuesto.Rows.Count - 1
                Dim Auxcuentacontable = AuxDtstbCuentaPresupuesto.Rows(dtxfila)("CuentaContable")

                Auxcuentacontable = Replace(Auxcuentacontable, "-00", "")
                Dim sentence As String = Auxcuentacontable
                Dim charsToTrim() As Char = {"0", "-"}
                Dim words() As String = sentence.Split()
                For Each word As String In words
                    '''Console.WriteLine(word.TrimEnd(charsToTrim))
                    Auxcuentacontable = word.TrimEnd(charsToTrim)
                Next
                AuxDtstbCuentaPresupuesto.Rows(dtxfila)("CuentaContable") = Auxcuentacontable
            Next


            ''Dim sentence As String = "The dog had a bone, a ball, and other toys."
            '''Dim charsToTrim() As Char = {","c, "."c, " "c}

            Return AuxDtstbCuentaPresupuesto
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        

    End Function




    Private Sub Calcular_Saldos()
        Dim k As Integer
        Try


            '''Cargar DataTable  DtstbCuentaPresupuesto

            CargarDtstbCuentaPresupuesto()

            ProgressBar1.Minimum = 0
            'In most cases you wouldnt use a fixed maximum. For example: count the number of files you want to copy and set that as the maximum
            ProgressBar1.Maximum = Me.DsBalances11.CuentaContable.Rows.Count - 1

            'Adjust the speed at which the progressbar fills up
            ProgressBar1.Step = 1



            For k = 0 To Me.DsBalances11.CuentaContable.Rows.Count - 1
                progressBar()
                If Tipo = 1 Then
                    If DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                        Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos") - Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                        'Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMesD") = Me.DsBalances11.CuentaContable.Rows(k).Item("DebitosD") - Me.DsBalances11.CuentaContable.Rows(k).Item("CreditosD")

                    Else
                        Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos") - Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                        ' Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMesD") = Me.DsBalances11.CuentaContable.Rows(k).Item("CreditosD") - Me.DsBalances11.CuentaContable.Rows(k).Item("DebitosD")

                    End If

                    '''-----------------
                    Dim txtMontoPresupuestoMes As Double = 0.0
                    Dim DBDiferencia As Double = 0.0
                    Dim DbStrDecripcion As String = ""



                    If (DsBalances11.CuentaContable.Rows(k).Item("Movimiento") = True) Then

                        Dim DtsTPresupuestos As New DataTable
                        Dim sel As String = ""
                        txtMontoPresupuestoMes = 0.0
                        sel = "SELECT  P." & CboMes.Text & " as MONTO, P.Descripcion, CC.cuentaContable_Presupuesto  FROM CUENTACONTABLE AS CC, PRESUPUESTOS AS P " _
                        & " WHERE P.Id_Periodo_Fiscal=" & IDPeriodo & "  AND  P.CUENTA_CONTABLE=CC.CuentaContable_Presupuesto AND CC.CuentaContable_Presupuesto <> '' and CC.CUENTACONTABLE ='" & Me.DsBalances11.CuentaContable.Rows(k).Item("CuentaContable") & "'"

                        cFunciones.Llenar_Tabla_Generico(sel, DtsTPresupuestos, Configuracion.Claves.Conexion("Contabilidad"))
                        Dim cuentaContable_Presupuesto As String = ""
                        For Fila As Integer = 0 To DtsTPresupuestos.Rows.Count - 1

                            txtMontoPresupuestoMes = Convert.ToDouble(DtsTPresupuestos.Rows(Fila)("MONTO").ToString())
                            DbStrDecripcion = DtsTPresupuestos.Rows(Fila)("Descripcion").ToString()
                            cuentaContable_Presupuesto = DtsTPresupuestos.Rows(Fila)("cuentaContable_Presupuesto").ToString()
                            'Me.DsBalances11.CuentaContable.Rows(k).Item("Descrip") = DtsTPresupuestos.Rows(Fila)("Descripcion").ToString()
                        Next




                        For dtfila As Integer = 0 To DtstbCuentaPresupuesto.Rows.Count - 1

                            If DtstbCuentaPresupuesto.Rows(dtfila)("CuentaContable").ToString() = cuentaContable_Presupuesto Then

                                DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto") = txtMontoPresupuestoMes
                                DtstbCuentaPresupuesto.Rows(dtfila)("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")

                                If (DtstbCuentaPresupuesto.Rows(dtfila)("SaldoMes") >= DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto")) Then
                                    DtstbCuentaPresupuesto.Rows(dtfila)("Diferencia") = DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto") - DtstbCuentaPresupuesto.Rows(dtfila)("SaldoMes")

                                Else
                                    DtstbCuentaPresupuesto.Rows(dtfila)("Diferencia") = DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto") - DtstbCuentaPresupuesto.Rows(dtfila)("SaldoMes")

                                    'DtstbCuentaPresupuesto.Rows(dtfila)("Diferencia") = DtstbCuentaPresupuesto.Rows(dtfila)("SaldoMes") - DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto")
                                    'DtstbCuentaPresupuesto.Rows(dtfila)("Diferencia") = (DtstbCuentaPresupuesto.Rows(dtfila)("Diferencia") * -1)
                                End If

                                If (DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto") > 0.0) Then
                                    Dim p As Double = (DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto") * Convert.ToDouble(100))
                                    Dim Porcentaje As Double = 0.0
                                    Dim mes As Double = DtstbCuentaPresupuesto.Rows(dtfila)("SaldoMes")
                                    Porcentaje = Convert.ToDouble(((Convert.ToDouble(DtstbCuentaPresupuesto.Rows(dtfila)("Diferencia")) * Convert.ToDouble(100)) / Convert.ToDouble(DtstbCuentaPresupuesto.Rows(dtfila)("MontoPresupuesto"))))
                                    DtstbCuentaPresupuesto.Rows(dtfila)("Porcentaje") = Porcentaje

                                Else
                                    DtstbCuentaPresupuesto.Rows(dtfila)("Porcentaje") = 0.0
                                End If

                            End If
                            'DtstbCuentaPresupuesto.Rows(dtfila)("Monto1") = txtMontoPresupuestoMes
                        Next






                    End If


                    '''----------------
                    'Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual") = Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")
                    'Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActualD") = Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnteriorD") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMesD")


                Else
                    If DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "ACTIVOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "COSTO VENTA" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "GASTOS" Or DsBalances11.CuentaContable.Rows(k).Item("Tipo") = "OTROS GASTOS" Then
                        Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos") - Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos")
                    Else
                        Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes") = Me.DsBalances11.CuentaContable.Rows(k).Item("Creditos") - Me.DsBalances11.CuentaContable.Rows(k).Item("Debitos")
                    End If

                    Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoActual") = Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoAnterior") + Me.DsBalances11.CuentaContable.Rows(k).Item("SaldoMes")

                End If
            Next

            ''''''Calcular nivel
            Dim idNivel As Integer = 9
            For inivel As Integer = 0 To 8
                CalcularNivel(idNivel)
                idNivel = idNivel - 1
            Next



        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



#End Region

#Region "Importar"
    Private Sub Importar()
        Try
            Cconexion.DeleteRecords("Temporal", "")
            cargar()
            DataTableToExcel(Me.DsBalances11.Temporal2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub DataTableToExcel(ByVal pDataTable As DataTable)
        Try

            Dim vFileName As String = Path.GetTempFileName()

            FileOpen(1, vFileName, OpenMode.Output)

            Dim sb As String
            Dim dc As DataColumn
            For Each dc In pDataTable.Columns
                sb &= dc.Caption & Microsoft.VisualBasic.ControlChars.Tab
            Next
            PrintLine(1, sb)

            Dim i As Integer = 0
            Dim dr As DataRow
            For Each dr In pDataTable.Rows
                i = 0 : sb = ""
                For Each dc In pDataTable.Columns
                    If Not IsDBNull(dr(i)) Then
                        sb &= CStr(dr(i)) & Microsoft.VisualBasic.ControlChars.Tab
                    Else
                        sb &= Microsoft.VisualBasic.ControlChars.Tab
                    End If
                    i += 1
                Next
                PrintLine(1, sb)

            Next
            FileClose(1)
            TextToExcel(vFileName)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Public Sub TextToExcel(ByVal pFileName As String)
        Try
            Dim vFormato As Excel.XlRangeAutoFormat

            Dim vCultura As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US")

            Dim Exc As Excel.Application = New Excel.Application
            Exc.Workbooks.OpenText(pFileName, , , , Excel.XlTextQualifier.xlTextQualifierNone, , True)

            Dim Wb As Excel.Workbook = Exc.ActiveWorkbook
            Dim Ws As Excel.Worksheet = Wb.ActiveSheet

            'Se le indica el formato al que queremos exportarlo
            Dim valor As Integer = 1
            If valor > -1 Then
                Select Case valor
                    Case 0 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatNone
                    Case 1 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatSimple
                    Case 2 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1
                    Case 3 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic2
                    Case 4 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic3
                    Case 5 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting1
                    Case 6 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting2
                    Case 7 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting3
                    Case 8 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatAccounting4
                    Case 9 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor1
                    Case 10 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor2
                    Case 11 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatColor3
                    Case 12 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList1
                    Case 13 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList2
                    Case 14 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormatList3
                    Case 15 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects1
                    Case 16 : vFormato = Excel.XlRangeAutoFormat.xlRangeAutoFormat3DEffects2
                End Select

                Ws.Range(Ws.Cells(1, 1), Ws.Cells(Ws.UsedRange.Rows.Count, Ws.UsedRange.Columns.Count)).AutoFormat(vFormato)
                pFileName = Path.GetTempFileName.Replace("tmp", "xls")
                File.Delete(pFileName)
                Exc.ActiveWorkbook.SaveAs(pFileName, Excel.XlTextQualifier.xlTextQualifierNone - 1)
            End If

            Exc.Quit()
            Ws = Nothing
            Wb = Nothing
            Exc = Nothing
            GC.Collect()

            If valor > -1 Then
                Dim p As System.Diagnostics.Process = New System.Diagnostics.Process
                p.EnableRaisingEvents = False
                p.Start("Excel.exe", pFileName)
            End If
            System.Threading.Thread.CurrentThread.CurrentCulture = vCultura

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Function cargar()
        Dim i As Integer
        Dim trans As SqlTransaction
        Try
            DsBalances1.Temporal2.Clear()

            For i = 0 To Me.DsBalances1.CuentaContable.Rows.Count - 1
                If Tipo = 1 Then
                    If Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("DebitosD") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("CreditosD") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnteriorD") <> 0 Then
                        Me.BindingContext(Me.DsBalances1.Temporal2).AddNew()
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CuentaContable") = Me.DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Descripcion") = Me.DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Debitos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Creditos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoMes")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoActual")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Nivel") = Me.DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Movimiento") = Me.DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Id") = Me.DsBalances1.CuentaContable.Rows(i).Item("Id")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("PARENTID") = Me.DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnteriorD") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnteriorD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("DebitosD") = Me.DsBalances1.CuentaContable.Rows(i).Item("DebitosD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CreditosD") = Me.DsBalances1.CuentaContable.Rows(i).Item("CreditosD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMesD") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoMesD")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActualD") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoActualD")

                        Me.BindingContext(Me.DsBalances1.Temporal2).EndCurrentEdit()
                    End If
                Else
                    If Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos") <> 0 Or Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior") <> 0 Then
                        Me.BindingContext(Me.DsBalances1.Temporal2).AddNew()
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CuentaContable") = Me.DsBalances1.CuentaContable.Rows(i).Item("CuentaContable")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Descripcion") = Me.DsBalances1.CuentaContable.Rows(i).Item("Descripcion")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnterior") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoAnterior")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Debitos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Debitos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Creditos") = Me.DsBalances1.CuentaContable.Rows(i).Item("Creditos")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMes") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoMes")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActual") = Me.DsBalances1.CuentaContable.Rows(i).Item("SaldoActual")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Nivel") = Me.DsBalances1.CuentaContable.Rows(i).Item("Nivel")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Movimiento") = Me.DsBalances1.CuentaContable.Rows(i).Item("Movimiento")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("Id") = Me.DsBalances1.CuentaContable.Rows(i).Item("Id")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("PARENTID") = Me.DsBalances1.CuentaContable.Rows(i).Item("PARENTID")
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoAnteriorD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("DebitosD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("CreditosD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoMesD") = 0
                        Me.BindingContext(Me.DsBalances1.Temporal2).Current("SaldoActualD") = 0

                        Me.BindingContext(Me.DsBalances1.Temporal2).EndCurrentEdit()
                    End If
                End If

            Next

            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            trans = Me.SqlConnection1.BeginTransaction
            Me.AdTemporal2.InsertCommand.Transaction = trans
            Me.AdTemporal2.UpdateCommand.Transaction = trans
            Me.AdTemporal2.DeleteCommand.Transaction = trans
            Me.AdTemporal2.Update(Me.DsBalances1, "Temporal2")
            trans.Commit()

        Catch ex As Exception
            MsgBox(ex.ToString)
            trans.Rollback()
        Finally
            Me.SqlConnection1.Close()
        End Try
    End Function
#End Region

#Region "Nuevo"
    Private Sub Nuevo()
        Try
            If Me.ToolBarNuevo.Text = "Nuevo" Then
                Me.ToolBarNuevo.ImageIndex = "3"
                Me.ToolBarNuevo.Text = "Cancelar"
                'Me.TreeList2.DataSource = ""
                'Me.TreeList2.DataMember = ""
                Estado(True)
                'dtInicial.Focus()
            Else
                Me.ToolBarNuevo.ImageIndex = "0"
                Me.ToolBarNuevo.Text = "Nuevo"
                'Me.TreeList2.DataSource = ""
                'Me.TreeList2.DataMember = ""
                Estado(False)
            End If

            'Me.dtFinal.Enabled = True
            'Me.dtInicial.Enabled = True
            'Me.Moneda.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "Imprimir"
    Private Sub Imprimir()
        Dim Fecha1, Fecha2 As Date
        'Fecha1 = Format(dtInicial.Value.Date, "dd/MM/yyyy H:mm:ss")
        'Fecha2 = Format(Me.dtFinal.Value.Date, "dd/MM/yyyy H:mm:ss")
        If Fecha1 > Fecha2 Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final", MsgBoxStyle.Information)
            Exit Sub
        End If

        Try
            Cconexion.DeleteRecords("Temporal2", "")
            Dim nivel As New Nivel
            cargar()
            nivel.reporte = "Balance de Comprobación"
            nivel.Analitico = True
            'nivel.saldoant = Me.txtSaldoAnterior.Text
            'nivel.saldomes = Me.txtSaldoMes.Text
            'nivel.saldoactual = Me.txtSaldoActual.Text
            'nivel.debitos = Me.txtDebitos.Text
            'nivel.creditos = Me.txtCreditos.Text
            'nivel.saldoant1 = Me.TextBox1.Text
            'nivel.saldomes1 = Me.TextBox4.Text
            'nivel.saldoactual1 = Me.TextBox5.Text
            ''nivel.debitos1 = Me.TextBox2.Text
            'nivel.creditos1 = Me.TextBox3.Text
            'nivel.dtInicial.Text = Me.dtInicial.Text
            'nivel.dtFinal.Text = Me.dtFinal.Text
            'nivel.moneda = DsBalances1.Moneda(Moneda.SelectedIndex).MonedaNombre
            'nivel.simbolo = DsBalances1.Moneda(Moneda.SelectedIndex).Simbolo
            'nivel.CodMoneda = DsBalances1.Moneda(Moneda.SelectedIndex).CodMoneda
            nivel.Tipo = Me.Tipo
            nivel.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Analitico Detallado"
    Private Sub TreeList2_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs)
        If e.Node.Id = Nothing Then
        Else
            Reporte_ID = e.Node.Id
        End If
        If e.Node.Id = 0 Then
            Reporte_ID = e.Node.Id
        End If
    End Sub


    Private Sub TreeList2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DsBalances1.CuentaContable(Reporte_ID).Movimiento = False Then Exit Sub

        Try
            'Se ejecuta el procedimiento y llena la tabla TemporalAnaliticoDetallado 
            'Cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.ReporteAnaliticoDetallado '" & DsBalances1.CuentaContable(Reporte_ID).CuentaContable & "'," & (DsBalances1.CuentaContable(Reporte_ID).Nivel + 1) & ",'" & txtFechaInicial & "','" & txtFechaFinal & "'," & DsBalances1.Moneda(Moneda.SelectedIndex).CodMoneda & "," & Check_Cierre.Checked)
            'Dim rpt As New rptAnaliticoDetalladoModificado
            'Dim visor As New frmVisorReportes
            'rpt.SetParameterValue(0, DsBalances1.Moneda(Moneda.SelectedIndex).MonedaNombre)
            'rpt.SetParameterValue(1, DsBalances1.CuentaContable(Reporte_ID).SaldoMes)
            'rpt.SetParameterValue(2, DsBalances1.CuentaContable(Reporte_ID).SaldoAnterior)
            'rpt.SetParameterValue(3, DsBalances1.CuentaContable(Reporte_ID).CuentaContable)
            'rpt.SetParameterValue(4, DsBalances1.CuentaContable(Reporte_ID).Descripcion)

            'CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
            'visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub
#End Region


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub AdCuentas_RowUpdated(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs) Handles AdCuentas.RowUpdated

    End Sub

    Private Sub SqlConnection2_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs) Handles SqlConnection2.InfoMessage

    End Sub

    Private Sub Check_Cierre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check_Cierre.CheckedChanged

    End Sub

    Private Sub CboMes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboMes.SelectedIndexChanged

        Try

            Dim txtlong As Integer = 0
            Dim StrLongFecha As String = ""
            Dim AuxStrLongFecha As String = ""
            Dim srtint As Integer = 0
            Dim Band As Boolean = False
            Dim anno As Integer = 0
            Dim strTem As String = ""
            StrLongFecha = StrPeriodoFiscal
            txtlong = StrLongFecha.Length - 1
            For srtint = 0 To txtlong
                If (StrLongFecha.Chars(srtint) = "1") Then
                    srtint = srtint + 1
                    Band = True
                    If (Band = True) Then
                        strTem = StrLongFecha.Chars(srtint + 1) & StrLongFecha.Chars(srtint + 2) & StrLongFecha.Chars(srtint + 3) & StrLongFecha.Chars(srtint + 4)
                        srtint = txtlong + 2
                    End If



                Else

                End If


            Next



            anno = Convert.ToInt32(RTrim(strTem)) + 1

            Select Case CboMes.Text
                Case "ENERO"
                    'txtFechaInicial = "01/01/" & anno + 1 & " 00:00:00"
                    'txtFechaFinal = "01/02/" & anno  & " 00:00:00"
                    txtFechaInicial = "01/01/" & anno & " 00:00:00"
                    txtFechaFinal = "01/02/" & anno & " 00:00:00"

                    Dim d, y As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d
                    AnaliticotxtFechaInicial = ""
                    AnaliticotxtFechaFinal = ""

                    CtxtFechaInicial = "01/01/" & anno & " 00:00:00"


                Case "FEBRERO"
                    txtFechaInicial = "01/02/" & anno & " 00:00:00"
                    txtFechaFinal = "01/03/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/02/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "MARZO"
                    txtFechaInicial = "01/03/" & anno & " 00:00:00"
                    txtFechaFinal = "01/04/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/03/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "ABRIL"
                    txtFechaInicial = "01/04/" & anno & " 00:00:00"
                    txtFechaFinal = "01/05/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/04/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "MAYO"
                    txtFechaInicial = "01/05/" & anno & " 00:00:00"
                    txtFechaFinal = "01/06/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/05/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "JUNIO"
                    txtFechaInicial = "01/06/" & anno & " 00:00:00"
                    txtFechaFinal = "01/07/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/06/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "JULIO"
                    txtFechaInicial = "01/07/" & anno & " 00:00:00"
                    txtFechaFinal = "01/08/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/07/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "AGOSTO"
                    txtFechaInicial = "01/08/" & anno & " 00:00:00"
                    txtFechaFinal = "01/09/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/08/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "SEPTIEMBRE"
                    txtFechaInicial = "01/09/" & anno & " 00:00:00"
                    txtFechaFinal = "01/10/" & anno & " 00:00:00"
                    CtxtFechaInicial = "01/09/" & anno & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "OCTUBRE"
                    txtFechaInicial = "01/10/" & anno - 1 & " 00:00:00"
                    txtFechaFinal = "01/11/" & anno - 1 & " 00:00:00"
                    CtxtFechaInicial = "01/10/" & anno - 1 & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "NOVIEMBRE"
                    txtFechaInicial = "01/11/" & anno - 1 & " 00:00:00"
                    txtFechaFinal = "01/12/" & anno - 1 & " 00:00:00"
                    CtxtFechaInicial = "01/11/" & anno - 1 & " 00:00:00"
                    Dim d As DateTime
                    d = txtFechaFinal
                    d = d.AddDays(-1)
                    txtFechaFinal = d

                Case "DICIEMBRE"
                    txtFechaInicial = "01/12/" & anno - 1 & " 00:00:00"
                    txtFechaFinal = "31/12/" & anno - 1 & " 00:00:00"
                    CtxtFechaInicial = "01/12/" & anno - 1 & " 00:00:00"

            End Select


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnBuscarPeriodoFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPeriodoFiscal.Click
        RutinaBuscarPeriodoFiscal()
    End Sub

    Private Sub RutinaBuscarPeriodoFiscal()
        Try
            'SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal WHERE Id = @Id
            Dim fx As New cFunciones
            Dim IdP As String = ""

            IdP = fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "(CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11)))", "Buscar Periodo Fiscal...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")

            If IdP <> "" Then
                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                par.Add("@ID", IdP)

                db.Fill_Generic_Table("Contabilidad", dt, "SELECT Id, CAST(CONVERT(datetime, FechaInicio, 103) AS char(11)) + ' - ' + CAST(CONVERT(datetime, FechaFinal, 103) AS Char(11)) AS PeriodoFiscal FROM PeriodoFiscal WHERE (Id = @ID)", CommandType.Text, par)
                IDPeriodo = 0
                StrPeriodoFiscal = ""
                If dt.Rows.Count > 0 Then
                    txtPeriodoFiscal.Text = dt.Rows(0).Item(1)
                    StrPeriodoFiscal = dt.Rows(0).Item(1)
                    IDPeriodo = dt.Rows(0).Item(0)
                End If



            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dtInicial_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub SqlConnection1_InfoMessage(ByVal sender As System.Object, ByVal e As System.Data.SqlClient.SqlInfoMessageEventArgs) Handles SqlConnection1.InfoMessage

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Dim ta As New DataTable
        'ta = operacion.Recuperar(Conexion.Conexion, query6)

        'Dim reporte As New RptEstadoResultadovsPresupuesto
        'reporte.SetDataSource(DtstbCuentaPresupuesto)
        'Me.DataGridView1.DataSource = ta
        'Me.CrystalReportViewer1.ReportSource = reporte

        'Me.CrystalReportViewer1.RefreshReport()
        'Me.CrystalReportViewer1.Refresh()

        'rpt.SetParameterValue(0, Convert.ToInt32(codigo))
        'rpt.SetParameterValue(1, Me.DateTimePicker2.Value)
        'rpt.SetParameterValue(2, Not Me.CheckBoxConta.Checked)
        'CrystalReportsConexion2.LoadReportViewer2(Me.CrystalReportViewer1, reporte, False, Configuracion.Claves.Conexion("Contabilidad"))
        Try

            Dim rpt As New RptEstadoResultadovsPresupuesto
            Dim visor As New frmVisorReportes
            '''******Cambiar DataTable Cuenta Truncada *******''
            Dim AuxDtstbCuentaPresupuesto As New DataTable
            AuxDtstbCuentaPresupuesto = TruncarCuenta()
            '''******Cambiar DataTable Cuenta Truncada *******''
            rpt.SetDataSource(AuxDtstbCuentaPresupuesto)
            rpt.SetParameterValue(0, txtPeriodoFiscal.Text)
            rpt.SetParameterValue(1, CboMes.Text)
            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
            visor.Show()

            If (CboMes.Text <> "") Then
                Calcular_Saldos()
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub TreeList1_FocusedNodeChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.FocusedNodeChangedEventArgs) Handles TreeList1.FocusedNodeChanged


        If e.Node.Id = Nothing Then
        Else
            Reporte_ID = e.Node.Id
        End If
        If e.Node.Id = 0 Then
            Reporte_ID = e.Node.Id
        End If
    End Sub

    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick

        Dim index As Integer = 0

        If DtstbCuentaPresupuesto.Rows(Reporte_ID)("Movimiento") = False Then Exit Sub

        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select  CuentaContable from CuentaContable WHERE CuentaContable_Presupuesto = '" & DtstbCuentaPresupuesto.Rows(Reporte_ID)("CuentaContable") & "'", dt, Configuracion.Claves.Conexion("Contabilidad"))
            Dim DtFila As Integer = 0
            Dim CuentaContableAnalitico As String = ""
            For DtFila = 0 To dt.Rows.Count - 1
                CuentaContableAnalitico = dt.Rows(DtFila)("CuentaContable").ToString
            Next

            'Se ejecuta el procedimiento y llena la tabla TemporalAnaliticoDetallado 
            Cconexion.SlqExecuteScalar(conectadobd, "EXEC dbo.ReporteAnaliticoDetallado '" & CuentaContableAnalitico & "'," & DtstbCuentaPresupuesto.Rows(Reporte_ID)("Nivel") + 1 & ",'" & txtFechaInicial & "','" & txtFechaFinal & "'," & 1 & "," & Check_Cierre.Checked)
            Dim rpt As New DBKrptAnaliticoDetalladoModificado
            Dim visor As New frmVisorReportes

            rpt.SetParameterValue(0, 1) 'DsBalances1.Moneda(Moneda.SelectedIndex).MonedaNombre)
            rpt.SetParameterValue(1, DtstbCuentaPresupuesto.Rows(Reporte_ID)("SaldoMes"))
            rpt.SetParameterValue(2, DtstbCuentaPresupuesto.Rows(Reporte_ID)("MontoPresupuesto"))
            rpt.SetParameterValue(3, CuentaContableAnalitico) ''DtstbCuentaPresupuesto.Rows(Reporte_ID)("CuentaContable"))
            rpt.SetParameterValue(4, DtstbCuentaPresupuesto.Rows(Reporte_ID)("Descripcion"))

            CrystalReportsConexion2.LoadReportViewer2(visor.rptViewer, rpt, False, Configuracion.Claves.Conexion("Contabilidad"))
            visor.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Atención...")
        End Try
    End Sub

  
    Private Sub TreeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeList1.KeyDown

       

    End Sub
End Class
