
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

'Imports Utilidades_DB
Public Class frmPresupuesto
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
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents DtsPresupuesto1 As Contabilidad.dtsPresupuesto
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnGenerar As System.Windows.Forms.Button
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents CuentaContable As DevExpress.XtraTreeList.Columns.TreeListColumn
    Friend WithEvents Descripcion As DevExpress.XtraTreeList.Columns.TreeListColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DtsPresupuesto1 = New Contabilidad.dtsPresupuesto
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPeriodo = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnGenerar = New System.Windows.Forms.Button
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList
        Me.CuentaContable = New DevExpress.XtraTreeList.Columns.TreeListColumn
        Me.Descripcion = New DevExpress.XtraTreeList.Columns.TreeListColumn
        CType(Me.DtsPresupuesto1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtsPresupuesto1
        '
        Me.DtsPresupuesto1.DataSetName = "dtsPresupuesto"
        Me.DtsPresupuesto1.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Periodo Fiscal:"
        '
        'txtPeriodo
        '
        Me.txtPeriodo.Enabled = False
        Me.txtPeriodo.Location = New System.Drawing.Point(104, 16)
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.ReadOnly = True
        Me.txtPeriodo.Size = New System.Drawing.Size(208, 20)
        Me.txtPeriodo.TabIndex = 2
        Me.txtPeriodo.TabStop = False
        Me.txtPeriodo.Text = ""
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(320, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(408, 16)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.TabIndex = 4
        Me.btnGenerar.Text = "Generar"
        '
        'TreeList1
        '
        Me.TreeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.CuentaContable, Me.Descripcion})
        Me.TreeList1.Location = New System.Drawing.Point(0, 56)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.ParentFieldName = "PARENTID"
        Me.TreeList1.Size = New System.Drawing.Size(1320, 272)
        Me.TreeList1.TabIndex = 5
        Me.TreeList1.Text = "TreeList1"
        '
        'CuentaContable
        '
        Me.CuentaContable.Caption = "CuentaContable"
        Me.CuentaContable.FieldName = "CuentaContable"
        Me.CuentaContable.Name = "CuentaContable"
        Me.CuentaContable.VisibleIndex = 0
        Me.CuentaContable.Width = 175
        '
        'Descripcion
        '
        Me.Descripcion.Caption = "Descripcion"
        Me.Descripcion.FieldName = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.VisibleIndex = 1
        Me.Descripcion.Width = 175
        '
        'frmPresupuesto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1328, 338)
        Me.Controls.Add(Me.TreeList1)
        Me.Controls.Add(Me.btnGenerar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmPresupuesto"
        Me.Text = "frmPresupuesto"
        CType(Me.DtsPresupuesto1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Variables Para presupuesto"
    Dim Dt_Presupuesto_Enero As Double = 0.0
    Dim Dt_Presupuesto_Febrero As Double = 0.0
    Dim Dt_Presupuesto_Marzo As Double = 0.0
    Dim Dt_Presupuesto_Abril As Double = 0.0
    Dim Dt_Presupuesto_Mayo As Double = 0.0
    Dim Dt_Presupuesto_Junio As Double = 0.0
    Dim Dt_Presupuesto_Julio As Double = 0.0
    Dim Dt_Presupuesto_Agosto As Double = 0.0
    Dim Dt_Presupuesto_Septiembre As Double = 0.0
    Dim Dt_Presupuesto_Octubre As Double = 0.0
    Dim Dt_Presupuesto_Noviembre As Double = 0.0
    Dim Dt_Presupuesto_Diciembre As Double = 0.0
    Dim Dt_Presupuesto_TOTAL As Double = 0.0
    Dim Dt_Presupuesto_Estado As String = ""
    Dim BanderaCambio As Boolean = False
    Dim txtId_PeridoFiscal As Integer = 0
    Dim Reporte_ID As Integer
    Public TablaNiveles As New DataTable
    Dim DtsTreeListPresupuestos As New DataTable
#End Region
    



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

    Private Sub frmPresupuesto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '''CreateColumn(TreeList1, "Cuenta Contable", "CuentaContable", 0, DevExpress.Utils.FormatType.None, "")
        ''CreateColumn(TreeList1, "Descripción", "Descripcion", 1, DevExpress.Utils.FormatType.None, "")
        CreateColumn(TreeList1, "ENERO      ", "ENERO", 2, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "FEBRERO    ", "FEBRERO", 3, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "MARZO      ", "MARZO", 5, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "ABRIL      ", "ABRIL", 6, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "MAYO       ", "MAYO", 7, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "JUNIO      ", "JUNIO", 8, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "JULIO      ", "JULIO", 9, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "AGOSTO     ", "AGOSTO", 10, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "SEPTIEMBRE ", "SEPTIEMBRE", 11, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "OCTUBRE    ", "OCTUBRE", 12, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "NOVIEMBRE  ", "NOVIEMBRE", 13, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "DICIEMBRE  ", "DICIEMBRE", 14, DevExpress.Utils.FormatType.Numeric, "#,##0.00")
        CreateColumn(TreeList1, "TOTAL", "TOTAL", 15, DevExpress.Utils.FormatType.Numeric, "#,##0.00")




    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)



    End Sub

    Dim IDPeriodo = 0

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'SELECT Id, FechaInicio, FechaFinal, Estado FROM PeriodoFiscal WHERE Id = @Id

        Try
            Me.DtsPresupuesto1.Presupuestos.Clear()
            Me.DtsPresupuesto1.CuentaContable_Presupuestaria.Clear()
            'Me.DtsPresupuesto1.Presupuestos.OCTUBREColumn.Conta()


            Dim fx As New cFunciones
            Dim IdP As String = ""
            txtId_PeridoFiscal = 0
            IdP = fx.BuscarDatos("SELECT Id, (CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11))) AS PeriodoFiscal FROM PeriodoFiscal", "(CAST(CONVERT (datetime, FechaInicio, 103) AS char(11))) + ' - ' + (CAST(CONVERT (datetime, FechaFinal, 103) AS Char(11)))", "Buscar Periodo Fiscal...", Configuracion.Claves.Conexion("Contabilidad"), 0, "Order by Id DESC")
            txtId_PeridoFiscal = Convert.ToInt32(IdP)
            If IdP <> "" Then
                Dim dt As New DataTable
                Dim db As New SeeDBMaster
                Dim par As New Dictionaries
                par.Add("@ID", IdP)
                db.Fill_Generic_Table("Contabilidad", dt, "SELECT Id, CAST(CONVERT(datetime, FechaInicio, 103) AS char(11)) + ' - ' + CAST(CONVERT(datetime, FechaFinal, 103) AS Char(11)) AS PeriodoFiscal FROM PeriodoFiscal WHERE (Id = @ID)", CommandType.Text, par)
                If dt.Rows.Count > 0 Then
                    txtPeriodo.Text = dt.Rows(0).Item(1)
                    IDPeriodo = dt.Rows(0).Item(0)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub




    Private Sub CalcularNivel(ByVal txtnivel As Integer)
        '''Sumar Cuenta Madre
        For dttfila As Integer = 0 To DtsTreeListPresupuestos.Rows.Count - 1
            Dim SumaSaldoMes As Double = 0.0
            If DtsTreeListPresupuestos.Rows(dttfila)("Movimiento") = False Then
                Dim id As Integer = DtsTreeListPresupuestos.Rows(dttfila)("id")

                For dtxfila As Integer = 0 To DtsTreeListPresupuestos.Rows.Count - 1
                    If (txtnivel = DtsTreeListPresupuestos.Rows(dtxfila)("Nivel")) Then
                        If (id = DtsTreeListPresupuestos.Rows(dtxfila)("PARENTID")) Then
                            DtsTreeListPresupuestos.Rows(dttfila)("ENERO") = DtsTreeListPresupuestos.Rows(dttfila)("ENERO") + DtsTreeListPresupuestos.Rows(dtxfila)("ENERO")
                            DtsTreeListPresupuestos.Rows(dttfila)("FEBRERO") = DtsTreeListPresupuestos.Rows(dttfila)("FEBRERO") + DtsTreeListPresupuestos.Rows(dtxfila)("FEBRERO")
                            DtsTreeListPresupuestos.Rows(dttfila)("MARZO") = DtsTreeListPresupuestos.Rows(dttfila)("MARZO") + DtsTreeListPresupuestos.Rows(dtxfila)("MARZO")
                            DtsTreeListPresupuestos.Rows(dttfila)("ABRIL") = DtsTreeListPresupuestos.Rows(dttfila)("ABRIL") + DtsTreeListPresupuestos.Rows(dtxfila)("ABRIL")
                            DtsTreeListPresupuestos.Rows(dttfila)("MAYO") = DtsTreeListPresupuestos.Rows(dttfila)("MAYO") + DtsTreeListPresupuestos.Rows(dtxfila)("MAYO")
                            DtsTreeListPresupuestos.Rows(dttfila)("JUNIO") = DtsTreeListPresupuestos.Rows(dttfila)("JUNIO") + DtsTreeListPresupuestos.Rows(dtxfila)("JUNIO")
                            DtsTreeListPresupuestos.Rows(dttfila)("JULIO") = DtsTreeListPresupuestos.Rows(dttfila)("JULIO") + DtsTreeListPresupuestos.Rows(dtxfila)("JULIO")
                            DtsTreeListPresupuestos.Rows(dttfila)("AGOSTO") = DtsTreeListPresupuestos.Rows(dttfila)("AGOSTO") + DtsTreeListPresupuestos.Rows(dtxfila)("AGOSTO")
                            DtsTreeListPresupuestos.Rows(dttfila)("SEPTIEMBRE") = DtsTreeListPresupuestos.Rows(dttfila)("SEPTIEMBRE") + DtsTreeListPresupuestos.Rows(dtxfila)("SEPTIEMBRE")
                            DtsTreeListPresupuestos.Rows(dttfila)("OCTUBRE") = DtsTreeListPresupuestos.Rows(dttfila)("OCTUBRE") + DtsTreeListPresupuestos.Rows(dtxfila)("OCTUBRE")
                            DtsTreeListPresupuestos.Rows(dttfila)("NOVIEMBRE") = DtsTreeListPresupuestos.Rows(dttfila)("NOVIEMBRE") + DtsTreeListPresupuestos.Rows(dtxfila)("NOVIEMBRE")
                            DtsTreeListPresupuestos.Rows(dttfila)("DICIEMBRE") = DtsTreeListPresupuestos.Rows(dttfila)("DICIEMBRE") + DtsTreeListPresupuestos.Rows(dtxfila)("DICIEMBRE")
                            DtsTreeListPresupuestos.Rows(dttfila)("TOTAL") = DtsTreeListPresupuestos.Rows(dttfila)("TOTAL") + DtsTreeListPresupuestos.Rows(dtxfila)("TOTAL")
                        End If
                    End If
                Next

            End If
            'DtstbCuentaPresupuesto.Rows(dttfila)("SaldoMes") = SumaSaldoMes

        Next
    End Sub


    Private Sub Rutina_generar()

        Try


            If (txtPeriodo.Text <> "" And txtId_PeridoFiscal <> 0) Then
                Dt_Presupuesto_Estado = "N"
                Dim db As New SeeDBMaster
                Me.DtsPresupuesto1.Presupuestos.Clear()
                Me.DtsPresupuesto1.CuentaContable_Presupuestaria.Clear()

                db.Fill_Generic_Table("Contabilidad", Me.DtsPresupuesto1.CuentaContable_Presupuestaria, "SELECT * FROM CuentaContable_Presupuestaria --WHERE (PARENTID <> 0)", CommandType.Text)
                Dim i As Integer = 0
                'For Each f As dtsPresupuesto.CuentaContable_PresupuestariaRow In Me.DtsPresupuesto1.CuentaContable_Presupuestaria.Rows

                '    Me.DtsPresupuesto1.Presupuestos.AddPresupuestosRow(i, f.CuentaContable, f.Descripcion, f.Nivel, f.PARENTID, f.id, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)

                '    i += 1
                'Next
                '''''Lo del load
                ''db.Fill_Generic_Table("Contabilidad", Me.DtsPresupuesto1.CuentaContable_Presupuestaria, "SELECT CuentaContable, Descripcion, Nivel, PARENTID, id FROM CuentaContable_Presupuestaria WHERE (PARENTID <> 0)", CommandType.Text)
                ''db.Fill_Generic_Table("Contabilidad", Me.DtsPresupuesto1.CuentaContable_Presupuestaria, "SELECT CuentaContable, Descripcion, Nivel, PARENTID, id FROM CuentaContable_Presupuestaria )", CommandType.Text)

                Dim fila As Integer = 0
                Dim Class_cFunciones As New cFunciones

                Me.DtsPresupuesto1.Presupuestos.Clear()
                For Each f As dtsPresupuesto.CuentaContable_PresupuestariaRow In Me.DtsPresupuesto1.CuentaContable_Presupuestaria.Rows
                    Dim CuentaContable As String = f.CuentaContable
                    Dim tbl_tabla As DataTable = Class_cFunciones.GetPresupuesto(CuentaContable, txtId_PeridoFiscal)
                    Dt_Presupuesto_Enero = 0.0
                    Dt_Presupuesto_Febrero = 0.0
                    Dt_Presupuesto_Marzo = 0.0
                    Dt_Presupuesto_Abril = 0.0
                    Dt_Presupuesto_Mayo = 0.0
                    Dt_Presupuesto_Junio = 0.0
                    Dt_Presupuesto_Julio = 0.0
                    Dt_Presupuesto_Agosto = 0.0
                    Dt_Presupuesto_Septiembre = 0.0
                    Dt_Presupuesto_Octubre = 0.0
                    Dt_Presupuesto_Noviembre = 0.0
                    Dt_Presupuesto_Diciembre = 0.0
                    Dt_Presupuesto_TOTAL = 0.0
                    For fila = 0 To tbl_tabla.Rows.Count - 1
                        Dt_Presupuesto_Enero = Convert.ToDouble(tbl_tabla.Rows(fila)("ENERO").ToString())
                        Dt_Presupuesto_Febrero = Convert.ToDouble(tbl_tabla.Rows(fila)("FEBRERO").ToString())
                        Dt_Presupuesto_Marzo = Convert.ToDouble(tbl_tabla.Rows(fila)("MARZO").ToString())
                        Dt_Presupuesto_Abril = Convert.ToDouble(tbl_tabla.Rows(fila)("ABRIL").ToString())
                        Dt_Presupuesto_Mayo = Convert.ToDouble(tbl_tabla.Rows(fila)("MAYO").ToString())
                        Dt_Presupuesto_Junio = Convert.ToDouble(tbl_tabla.Rows(fila)("JUNIO").ToString())
                        Dt_Presupuesto_Julio = Convert.ToDouble(tbl_tabla.Rows(fila)("JULIO").ToString())
                        Dt_Presupuesto_Agosto = Convert.ToDouble(tbl_tabla.Rows(fila)("AGOSTO").ToString())
                        Dt_Presupuesto_Septiembre = Convert.ToDouble(tbl_tabla.Rows(fila)("SEPTIEMBRE").ToString())
                        Dt_Presupuesto_Octubre = Convert.ToDouble(tbl_tabla.Rows(fila)("OCTUBRE").ToString())
                        Dt_Presupuesto_Noviembre = Convert.ToDouble(tbl_tabla.Rows(fila)("NOVIEMBRE").ToString())
                        Dt_Presupuesto_Diciembre = Convert.ToDouble(tbl_tabla.Rows(fila)("DICIEMBRE").ToString())
                        Dt_Presupuesto_TOTAL = Convert.ToDouble(tbl_tabla.Rows(fila)("TOTAL").ToString())
                        Dt_Presupuesto_Estado = tbl_tabla.Rows(fila)("Estado").ToString()
                    Next


                    Me.DtsPresupuesto1.Presupuestos.AddPresupuestosRow(i, f.CuentaContable, f.Descripcion, f.Nivel, f.PARENTID, f.id, Dt_Presupuesto_Octubre, Dt_Presupuesto_Noviembre, Dt_Presupuesto_Diciembre, Dt_Presupuesto_Enero, Dt_Presupuesto_Febrero, Dt_Presupuesto_Marzo, Dt_Presupuesto_Abril, Dt_Presupuesto_Mayo, Dt_Presupuesto_Junio, Dt_Presupuesto_Julio, Dt_Presupuesto_Agosto, Dt_Presupuesto_Septiembre, Dt_Presupuesto_TOTAL)

                    i += 1
                Next
                '''''End
                If (Dt_Presupuesto_Estado = "S") Then
                    ''GridControl1.Enabled = False

                Else
                    ''GridControl1.Enabled = True
                End If

            Else
                MsgBox("Estimado usuario debe seleccionar un Periodo Fiscal", MsgBoxStyle.Exclamation, "")

            End If


            Dim selSQL As String = ""
            selSQL = "SELECT * , 0.0  as ENERO, 0.0 as FEBRERO, 0.0 as MARZO, 0.0 as ABRIL, 0.0 as MAYO , 0.0  as JUNIO, 0.0 as JULIO, 0.0 AS AGOSTO, 0.0 AS SEPTIEMBRE, 0.0 AS OCTUBRE, 0.0 AS NOVIEMBRE, 0.0 AS DICIEMBRE, 0.0 AS TOTAL FROM CuentaContable_Presupuestaria"
            cFunciones.Llenar_Tabla_Generico(selSQL, DtsTreeListPresupuestos, Configuracion.Claves.Conexion("Contabilidad"))

            Dim xfila As Integer = 0
            Dim zFila As Integer = 0
            For xfila = 0 To DtsTreeListPresupuestos.Rows.Count - 1
                For zFila = 0 To DtsPresupuesto1.Presupuestos.Rows.Count - 1
                    If (DtsTreeListPresupuestos.Rows(zFila)("CUENTACONTABLE") = DtsPresupuesto1.Presupuestos.Rows(xfila)("CUENTA_CONTABLE")) Then
                        DtsTreeListPresupuestos.Rows(xfila)("ENERO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("ENERO")
                        DtsTreeListPresupuestos.Rows(xfila)("FEBRERO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("FEBRERO")
                        DtsTreeListPresupuestos.Rows(xfila)("MARZO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("MARZO")
                        DtsTreeListPresupuestos.Rows(xfila)("ABRIL") = DtsPresupuesto1.Presupuestos.Rows(zFila)("ABRIL")
                        DtsTreeListPresupuestos.Rows(xfila)("MAYO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("MAYO")
                        DtsTreeListPresupuestos.Rows(xfila)("JUNIO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("JUNIO")
                        DtsTreeListPresupuestos.Rows(xfila)("JULIO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("JULIO")
                        DtsTreeListPresupuestos.Rows(xfila)("AGOSTO") = DtsPresupuesto1.Presupuestos.Rows(zFila)("AGOSTO")
                        DtsTreeListPresupuestos.Rows(xfila)("SEPTIEMBRE") = DtsPresupuesto1.Presupuestos.Rows(zFila)("SEPTIEMBRE")
                        DtsTreeListPresupuestos.Rows(xfila)("OCTUBRE") = DtsPresupuesto1.Presupuestos.Rows(zFila)("OCTUBRE")
                        DtsTreeListPresupuestos.Rows(xfila)("DICIEMBRE") = DtsPresupuesto1.Presupuestos.Rows(zFila)("DICIEMBRE")
                        DtsTreeListPresupuestos.Rows(xfila)("NOVIEMBRE") = DtsPresupuesto1.Presupuestos.Rows(zFila)("NOVIEMBRE")
                        DtsTreeListPresupuestos.Rows(xfila)("TOTAL") = DtsPresupuesto1.Presupuestos.Rows(zFila)("TOTAL")
                    End If
                Next
            Next

            ''''CALCULAR SUMA NIVELES

            Dim idNivel As Integer = 9
            For inivel As Integer = 0 To 8
                CalcularNivel(idNivel)
                idNivel = idNivel - 1

            Next



            TreeList1.DataSource = DtsTreeListPresupuestos

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar.Click

        Rutina_generar()


    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridControl1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GridControl1_DockChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub GridView1_CellValueChanging(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
        'Dim f As dtsPresupuesto.PresupuestosRow = Me.GridView1.GetDataRow(GridView1.FocusedRowHandle)



        'If (f.ENERO > 0) Then
        '    'Dim CellAux As Double = f.ENERO
        '    'f.ENERO = CellAux
        '    BanderaCambio = True

        'End If


        'If (f.FEBRERO > 0) Then
        '    'Dim CellAux As Double = f.FEBRERO
        '    'f.FEBRERO = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.MARZO > 0) Then
        '    'Dim CellAux As Double = f.MARZO
        '    'f.MARZO = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.ABRIL > 0) Then
        '    'Dim CellAux As Double = f.ABRIL
        '    'f.ABRIL = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.MAYO > 0) Then
        '    'Dim CellAux As Double = f.MAYO
        '    'f.MAYO = CellAux
        '    BanderaCambio = True
        'End If
        'If (f.JUNIO > 0) Then
        '    'Dim CellAux As Double = f.JUNIO
        '    'f.JUNIO = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.JULIO > 0) Then
        '    'Dim CellAux As Double = f.JULIO
        '    'f.JULIO = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.AGOSTO > 0) Then
        '    'Dim CellAux As Double = f.AGOSTO
        '    'f.AGOSTO = CellAux
        '    BanderaCambio = True
        'End If
        'If (f.SEPTIEMBRE > 0) Then
        '    'Dim CellAux As Double = f.SEPTIEMBRE
        '    'f.SEPTIEMBRE = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.OCTUBRE > 0) Then
        '    'Dim CellAux As Double = f.OCTUBRE
        '    'f.OCTUBRE = CellAux
        '    BanderaCambio = True
        'End If
        'If (f.NOVIEMBRE > 0) Then
        '    'Dim CellAux As Double = f.NOVIEMBRE
        '    'f.NOVIEMBRE = CellAux
        '    BanderaCambio = True
        'End If

        'If (f.DICIEMBRE > 0) Then
        '    'Dim CellAux As Double = f.DICIEMBRE
        '    'f.DICIEMBRE = CellAux
        '    BanderaCambio = True
        'End If





    End Sub

    Private Sub GridView1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

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

    Private Sub GridView1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)


    End Sub


    Private Sub TreeList1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles TreeList1.DoubleClick


    End Sub

    Private Sub TreeList1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TreeList1.KeyDown
        If (e.KeyCode = Keys.Enter) Then

            Dim funcion As New cFunciones
            Dim Id, n, k, x, m, z As Integer
            Dim mov, Cuenta As String

            Try
 
         
                If DtsTreeListPresupuestos.Rows(Reporte_ID).Item("Movimiento") = True Then

                    If (txtId_PeridoFiscal <> 0) Then



                        Dim ClassConexion As New Conexion

                        'MsgBox(DtsTreeListPresupuestos.Rows(Reporte_ID).Item("CuentaContable") & " " & DtsTreeListPresupuestos.Rows(Reporte_ID).Item("Descripcion") & " " & DtsTreeListPresupuestos.Rows(Reporte_ID).Item("Nivel") & " " & DtsTreeListPresupuestos.Rows(Reporte_ID).Item("ParentId"))
                        DtsTreeListPresupuestos.Rows(Reporte_ID).Item("TOTAL") = DtsTreeListPresupuestos.Rows(Reporte_ID).Item("OCTUBRE") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("NOVIEMBRE") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("DICIEMBRE") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("ENERO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("FEBRERO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("MARZO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("ABRIL") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("MAYO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("JUNIO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("JULIO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("AGOSTO") + DtsTreeListPresupuestos.Rows(Reporte_ID).Item("SEPTIEMBRE")
                        ClassConexion.AgregarValoresPresupuestos(txtId_PeridoFiscal, DtsTreeListPresupuestos.Rows(Reporte_ID).Item("CuentaContable"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("Descripcion"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("Nivel"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("ParentId"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("id"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("OCTUBRE"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("NOVIEMBRE"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("DICIEMBRE"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("ENERO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("FEBRERO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("MARZO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("ABRIL"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("MAYO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("JUNIO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("JULIO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("AGOSTO"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("SEPTIEMBRE"), DtsTreeListPresupuestos.Rows(Reporte_ID).Item("TOTAL"), "N")
                    Else
                        MsgBox("Estimado Usuario Usted no ha seleccionado un perodo Fiscal", MsgBoxStyle.Exclamation, "")
                    End If

                Else
                    Rutina_generar()
                    MsgBox("Estimado Usuario Esta cuenta no puede ser actualizada por que Corresponde a una cuenta madre")

                End If

            Catch ex As Exception


                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
