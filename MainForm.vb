Imports System.Data.SqlClient
Imports System.Globalization
Imports Utilidades

Public Class MainForm
    Inherits System.Windows.Forms.Form

#Region "Variables"
    Dim Contador As Integer
    Dim TITULO As String
    Friend WithEvents stVersion As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As MenuItem
    Friend WithEvents MenuItemEstadosFinancieros As MenuItem
    Friend WithEvents StatusBarPanel1 As StatusBarPanel
    Friend WithEvents StatusBarPanel4 As StatusBarPanel
    Friend WithEvents StatusBarPanel2 As StatusBarPanel
    Friend WithEvents StatusBarPanel3 As StatusBarPanel
    Friend WithEvents StatusBarPanel5 As StatusBarPanel
    Friend WithEvents MenuItem12 As MenuItem
    Dim conexionConta As String
#End Region

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal Usuario_Parametro)
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()
        'usua = Usuario_Parametro
        'Add any initialization after the InitializeComponent() call
        conexionConta = Configuracion.Claves.Conexion("Contabilidad")

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
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu


    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBoxFondo As System.Windows.Forms.PictureBox
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents MenuItemCuentaContable As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemMayorizacionAsiento As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAsientos As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemBalanceComprobacion As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButtonCuentaContable As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonAsientos As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonMayorizacionAsiento As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonBalanceComprobacion As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonEstadoR As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButtonBalance As System.Windows.Forms.ToolBarButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents mniSeeposConfiguracionCuenta As System.Windows.Forms.MenuItem
    Friend WithEvents mniHotelGeneracionAutomatica As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem

    Friend WithEvents mniHotelConfiguracionCuenta As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCentroCosto As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemPeriodoTrabajo As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemPeriodoFiscal As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemReporteCC As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCierreAnual As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemCuentasFamilias As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemPagoProveedores As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItemAsientoPrepago As System.Windows.Forms.MenuItem
    Friend WithEvents mitmPresupuesto As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents mitmBajarAsientosLCPYMES As System.Windows.Forms.MenuItem


    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem26 = New System.Windows.Forms.MenuItem()
        Me.MenuItem10 = New System.Windows.Forms.MenuItem()
        Me.MenuItem31 = New System.Windows.Forms.MenuItem()
        Me.MenuItem37 = New System.Windows.Forms.MenuItem()
        Me.mniSeeposConfiguracionCuenta = New System.Windows.Forms.MenuItem()
        Me.mniHotelConfiguracionCuenta = New System.Windows.Forms.MenuItem()
        Me.MenuItemCuentasFamilias = New System.Windows.Forms.MenuItem()
        Me.MenuItem25 = New System.Windows.Forms.MenuItem()
        Me.MenuItem9 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCuentaContable = New System.Windows.Forms.MenuItem()
        Me.MenuItemCentroCosto = New System.Windows.Forms.MenuItem()
        Me.MenuItem27 = New System.Windows.Forms.MenuItem()
        Me.MenuItemPeriodoFiscal = New System.Windows.Forms.MenuItem()
        Me.MenuItemPeriodoTrabajo = New System.Windows.Forms.MenuItem()
        Me.MenuItemAsientos = New System.Windows.Forms.MenuItem()
        Me.MenuItem44 = New System.Windows.Forms.MenuItem()
        Me.MenuItem22 = New System.Windows.Forms.MenuItem()
        Me.MenuItemCierreAnual = New System.Windows.Forms.MenuItem()
        Me.MenuItemMayorizacionAsiento = New System.Windows.Forms.MenuItem()
        Me.MenuItem65 = New System.Windows.Forms.MenuItem()
        Me.MenuItem21 = New System.Windows.Forms.MenuItem()
        Me.mniHotelGeneracionAutomatica = New System.Windows.Forms.MenuItem()
        Me.MenuItem5 = New System.Windows.Forms.MenuItem()
        Me.MenuItem3 = New System.Windows.Forms.MenuItem()
        Me.MenuItem46 = New System.Windows.Forms.MenuItem()
        Me.MenuItem40 = New System.Windows.Forms.MenuItem()
        Me.MenuItem8 = New System.Windows.Forms.MenuItem()
        Me.MenuItem39 = New System.Windows.Forms.MenuItem()
        Me.MenuItem47 = New System.Windows.Forms.MenuItem()
        Me.MenuItem48 = New System.Windows.Forms.MenuItem()
        Me.MenuItem49 = New System.Windows.Forms.MenuItem()
        Me.MenuItem50 = New System.Windows.Forms.MenuItem()
        Me.MenuItem41 = New System.Windows.Forms.MenuItem()
        Me.MenuItem30 = New System.Windows.Forms.MenuItem()
        Me.MenuItemPagoProveedores = New System.Windows.Forms.MenuItem()
        Me.MenuItem52 = New System.Windows.Forms.MenuItem()
        Me.MenuItem35 = New System.Windows.Forms.MenuItem()
        Me.MenuItem32 = New System.Windows.Forms.MenuItem()
        Me.MenuItem33 = New System.Windows.Forms.MenuItem()
        Me.MenuItem42 = New System.Windows.Forms.MenuItem()
        Me.MenuItem53 = New System.Windows.Forms.MenuItem()
        Me.MenuItem54 = New System.Windows.Forms.MenuItem()
        Me.MenuItem23 = New System.Windows.Forms.MenuItem()
        Me.MenuItem36 = New System.Windows.Forms.MenuItem()
        Me.MenuItem56 = New System.Windows.Forms.MenuItem()
        Me.MenuItem62 = New System.Windows.Forms.MenuItem()
        Me.MenuItem61 = New System.Windows.Forms.MenuItem()
        Me.MenuItemAsientoPrepago = New System.Windows.Forms.MenuItem()
        Me.MenuItem57 = New System.Windows.Forms.MenuItem()
        Me.MenuItem2 = New System.Windows.Forms.MenuItem()
        Me.MenuItem45 = New System.Windows.Forms.MenuItem()
        Me.MenuItem59 = New System.Windows.Forms.MenuItem()
        Me.MenuItem63 = New System.Windows.Forms.MenuItem()
        Me.MenuItem64 = New System.Windows.Forms.MenuItem()
        Me.MenuItem7 = New System.Windows.Forms.MenuItem()
        Me.MenuItem38 = New System.Windows.Forms.MenuItem()
        Me.mitmBajarAsientosLCPYMES = New System.Windows.Forms.MenuItem()
        Me.MenuItem28 = New System.Windows.Forms.MenuItem()
        Me.MenuItemBalanceComprobacion = New System.Windows.Forms.MenuItem()
        Me.MenuItemEstadosFinancieros = New System.Windows.Forms.MenuItem()
        Me.MenuItem34 = New System.Windows.Forms.MenuItem()
        Me.MenuItem20 = New System.Windows.Forms.MenuItem()
        Me.MenuItem1 = New System.Windows.Forms.MenuItem()
        Me.MenuItem60 = New System.Windows.Forms.MenuItem()
        Me.MenuItemReporteCC = New System.Windows.Forms.MenuItem()
        Me.MenuItem4 = New System.Windows.Forms.MenuItem()
        Me.MenuItem6 = New System.Windows.Forms.MenuItem()
        Me.mitmPresupuesto = New System.Windows.Forms.MenuItem()
        Me.MenuItem19 = New System.Windows.Forms.MenuItem()
        Me.MenuItem14 = New System.Windows.Forms.MenuItem()
        Me.MenuItem15 = New System.Windows.Forms.MenuItem()
        Me.MenuItem16 = New System.Windows.Forms.MenuItem()
        Me.MenuItem17 = New System.Windows.Forms.MenuItem()
        Me.MenuItem18 = New System.Windows.Forms.MenuItem()
        Me.MenuItem43 = New System.Windows.Forms.MenuItem()
        Me.MenuItem55 = New System.Windows.Forms.MenuItem()
        Me.MenuItem11 = New System.Windows.Forms.MenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.ToolBarButtonCuentaContable = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButtonAsientos = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButtonMayorizacionAsiento = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButtonBalanceComprobacion = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButtonEstadoR = New System.Windows.Forms.ToolBarButton()
        Me.ToolBarButtonBalance = New System.Windows.Forms.ToolBarButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBar1 = New System.Windows.Forms.StatusBar()
        Me.StatusBarPanel1 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel()
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel()
        Me.stVersion = New System.Windows.Forms.StatusBarPanel()
        Me.PictureBoxFondo = New System.Windows.Forms.PictureBox()
        Me.MenuItem12 = New System.Windows.Forms.MenuItem()
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stVersion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem26, Me.MenuItem27, Me.MenuItem28, Me.mitmPresupuesto, Me.MenuItem43})
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 0
        Me.MenuItem26.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem10, Me.MenuItem31, Me.MenuItem37, Me.mniSeeposConfiguracionCuenta, Me.mniHotelConfiguracionCuenta, Me.MenuItemCuentasFamilias, Me.MenuItem25})
        Me.MenuItem26.Text = "Configuraciones"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 0
        Me.MenuItem10.Text = "Tipo Documentos"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 1
        Me.MenuItem31.Text = "Configuración para Notas"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 2
        Me.MenuItem37.Text = "Configuración para Flujo Efectivo"
        '
        'mniSeeposConfiguracionCuenta
        '
        Me.mniSeeposConfiguracionCuenta.Index = 3
        Me.mniSeeposConfiguracionCuenta.Text = "Configuración de cuentas"
        Me.mniSeeposConfiguracionCuenta.Visible = False
        '
        'mniHotelConfiguracionCuenta
        '
        Me.mniHotelConfiguracionCuenta.Index = 4
        Me.mniHotelConfiguracionCuenta.Text = "Configuración de Cuentas"
        Me.mniHotelConfiguracionCuenta.Visible = False
        '
        'MenuItemCuentasFamilias
        '
        Me.MenuItemCuentasFamilias.Index = 5
        Me.MenuItemCuentasFamilias.Text = "Configuración de Cuentas Familias"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 6
        Me.MenuItem25.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItemCuentaContable, Me.MenuItemCentroCosto})
        Me.MenuItem25.Text = "Cuentas Contables"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "Formato Cuentas"
        '
        'MenuItemCuentaContable
        '
        Me.MenuItemCuentaContable.Index = 1
        Me.MenuItemCuentaContable.Text = "Catalogo de Cuentas"
        '
        'MenuItemCentroCosto
        '
        Me.MenuItemCentroCosto.Index = 2
        Me.MenuItemCentroCosto.Text = "Centro de Costo"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 1
        Me.MenuItem27.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemPeriodoFiscal, Me.MenuItemPeriodoTrabajo, Me.MenuItemAsientos, Me.MenuItem44, Me.MenuItem22, Me.MenuItemCierreAnual, Me.MenuItemMayorizacionAsiento, Me.MenuItem65, Me.MenuItem21, Me.mniHotelGeneracionAutomatica, Me.MenuItem7, Me.MenuItem38, Me.mitmBajarAsientosLCPYMES, Me.MenuItem12})
        Me.MenuItem27.Text = "Operaciones"
        '
        'MenuItemPeriodoFiscal
        '
        Me.MenuItemPeriodoFiscal.Index = 0
        Me.MenuItemPeriodoFiscal.Text = "Periodo Fiscal"
        '
        'MenuItemPeriodoTrabajo
        '
        Me.MenuItemPeriodoTrabajo.Index = 1
        Me.MenuItemPeriodoTrabajo.Text = "Periodo Trabajo"
        '
        'MenuItemAsientos
        '
        Me.MenuItemAsientos.Index = 2
        Me.MenuItemAsientos.Text = "Asientos"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 3
        Me.MenuItem44.Text = "Cierre Cajas"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 4
        Me.MenuItem22.Text = "Cierre Mensual"
        '
        'MenuItemCierreAnual
        '
        Me.MenuItemCierreAnual.Index = 5
        Me.MenuItemCierreAnual.Text = "Cierre Anual"
        '
        'MenuItemMayorizacionAsiento
        '
        Me.MenuItemMayorizacionAsiento.Index = 6
        Me.MenuItemMayorizacionAsiento.Text = "Mayorización"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 7
        Me.MenuItem65.Text = "Caja Chica"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 8
        Me.MenuItem21.Text = "-"
        '
        'mniHotelGeneracionAutomatica
        '
        Me.mniHotelGeneracionAutomatica.Index = 9
        Me.mniHotelGeneracionAutomatica.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem40, Me.MenuItem8, Me.MenuItem41, Me.MenuItem30, Me.MenuItem32, Me.MenuItem33, Me.MenuItem36, Me.MenuItem56, Me.MenuItem57, Me.MenuItem2, Me.MenuItem45, Me.MenuItem59, Me.MenuItem63, Me.MenuItem64})
        Me.mniHotelGeneracionAutomatica.Text = "Generación "
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem46})
        Me.MenuItem5.Text = "Asientos Ctas x Cobrar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "Asiento Recibo Dinero"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 1
        Me.MenuItem46.Text = "Asiento Ajuste Ctas x Cobrar"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 1
        Me.MenuItem40.Text = "-"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 2
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem39, Me.MenuItem47, Me.MenuItem48, Me.MenuItem49, Me.MenuItem50})
        Me.MenuItem8.Text = "Asientos Proveeduría"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 0
        Me.MenuItem39.Text = "Asiento de Compras"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 1
        Me.MenuItem47.Text = "Asiento Dev. de Compras"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 2
        Me.MenuItem48.Text = "Asiento Requisiciones"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 3
        Me.MenuItem49.Text = "Asiento Traslados"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 4
        Me.MenuItem50.Text = "Asiento Ajuste Inventario"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 3
        Me.MenuItem41.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 4
        Me.MenuItem30.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemPagoProveedores, Me.MenuItem52, Me.MenuItem35})
        Me.MenuItem30.Text = "Asientos Ctas x Pagar"
        '
        'MenuItemPagoProveedores
        '
        Me.MenuItemPagoProveedores.Index = 0
        Me.MenuItemPagoProveedores.Text = "Asiento Pago a Proveedores"
        Me.MenuItemPagoProveedores.Visible = False
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 1
        Me.MenuItem52.Text = "Asiento Ajuste Ctas x Pagar"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 2
        Me.MenuItem35.Text = "Asiento de Otras CXP"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 5
        Me.MenuItem32.Text = "-"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 6
        Me.MenuItem33.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem42, Me.MenuItem53, Me.MenuItem54, Me.MenuItem23})
        Me.MenuItem33.Text = "Asientos Bancos"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 0
        Me.MenuItem42.Text = "Asientos Cheques"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 1
        Me.MenuItem53.Text = "Asientos Deposito"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 2
        Me.MenuItem54.Text = "Asientos Ajuste Bancario"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 3
        Me.MenuItem23.Text = "Asiento Trasferencias"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 7
        Me.MenuItem36.Text = "-"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 8
        Me.MenuItem56.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem62, Me.MenuItem61, Me.MenuItemAsientoPrepago})
        Me.MenuItem56.Text = "Asientos Ventas"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 0
        Me.MenuItem62.Text = "Ingresos"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 1
        Me.MenuItem61.Text = "Cortesia"
        '
        'MenuItemAsientoPrepago
        '
        Me.MenuItemAsientoPrepago.Index = 2
        Me.MenuItemAsientoPrepago.Text = "Prepago"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 9
        Me.MenuItem57.Text = "-"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 10
        Me.MenuItem2.Text = "Asiento Planilla"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 11
        Me.MenuItem45.Text = "-"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 12
        Me.MenuItem59.Text = "Asiento Cobro Tarjeta"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 13
        Me.MenuItem63.Text = "-"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 14
        Me.MenuItem64.Text = "Asiento de Vacaciones"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 10
        Me.MenuItem7.Text = "Asiento de Planilla"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 11
        Me.MenuItem38.Text = "Asiento de Requisiciones"
        Me.MenuItem38.Visible = False
        '
        'mitmBajarAsientosLCPYMES
        '
        Me.mitmBajarAsientosLCPYMES.Index = 12
        Me.mitmBajarAsientosLCPYMES.Text = "Bajar Asientos"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 2
        Me.MenuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItemBalanceComprobacion, Me.MenuItemEstadosFinancieros, Me.MenuItem34, Me.MenuItem20, Me.MenuItem1, Me.MenuItem60, Me.MenuItemReporteCC, Me.MenuItem4, Me.MenuItem6})
        Me.MenuItem28.Text = "Reportes"
        '
        'MenuItemBalanceComprobacion
        '
        Me.MenuItemBalanceComprobacion.Index = 0
        Me.MenuItemBalanceComprobacion.Text = "Balance Comprobación"
        '
        'MenuItemEstadosFinancieros
        '
        Me.MenuItemEstadosFinancieros.Index = 1
        Me.MenuItemEstadosFinancieros.Text = "Estados Financieros"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 2
        Me.MenuItem34.Text = "Analitico General"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 3
        Me.MenuItem20.Text = "Analitico x Cuenta"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 4
        Me.MenuItem1.Text = "Comparación de Cuentas"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 5
        Me.MenuItem60.Text = "Analisis de Gastos"
        '
        'MenuItemReporteCC
        '
        Me.MenuItemReporteCC.Index = 6
        Me.MenuItemReporteCC.Text = "Centro de Costos"
        Me.MenuItemReporteCC.Visible = False
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.Text = "Contabilidad Bancos"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 8
        Me.MenuItem6.Text = "Listado de Asientos"
        '
        'mitmPresupuesto
        '
        Me.mitmPresupuesto.Index = 3
        Me.mitmPresupuesto.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem14, Me.MenuItem15, Me.MenuItem16, Me.MenuItem17, Me.MenuItem18})
        Me.mitmPresupuesto.Text = "Presupuesto"
        Me.mitmPresupuesto.Visible = False
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 0
        Me.MenuItem19.Text = "Catalogo de Presupuesto"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 1
        Me.MenuItem14.Text = "Inclusión de Presupuesto"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 2
        Me.MenuItem15.Text = "Aprobar Presupuesto"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 3
        Me.MenuItem16.Text = "Modificar Presupuesto"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 4
        Me.MenuItem17.Text = "Autorizar Modificación"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 5
        Me.MenuItem18.Text = "Estado Resultado vrs Presupuestado"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 4
        Me.MenuItem43.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem55, Me.MenuItem11})
        Me.MenuItem43.Text = "Interfaz"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 0
        Me.MenuItem55.Text = "Respaldar BD"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 1
        Me.MenuItem11.Text = "Salir"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ToolBar1
        '
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButtonCuentaContable, Me.ToolBarButtonAsientos, Me.ToolBarButtonMayorizacionAsiento, Me.ToolBarButtonBalanceComprobacion, Me.ToolBarButtonEstadoR, Me.ToolBarButtonBalance})
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(766, 58)
        Me.ToolBar1.TabIndex = 16
        '
        'ToolBarButtonCuentaContable
        '
        Me.ToolBarButtonCuentaContable.ImageIndex = 9
        Me.ToolBarButtonCuentaContable.Name = "ToolBarButtonCuentaContable"
        Me.ToolBarButtonCuentaContable.Text = "Catalogo Cuenta"
        '
        'ToolBarButtonAsientos
        '
        Me.ToolBarButtonAsientos.ImageIndex = 22
        Me.ToolBarButtonAsientos.Name = "ToolBarButtonAsientos"
        Me.ToolBarButtonAsientos.Text = "Asientos"
        '
        'ToolBarButtonMayorizacionAsiento
        '
        Me.ToolBarButtonMayorizacionAsiento.ImageIndex = 12
        Me.ToolBarButtonMayorizacionAsiento.Name = "ToolBarButtonMayorizacionAsiento"
        Me.ToolBarButtonMayorizacionAsiento.Text = "Mayorización"
        '
        'ToolBarButtonBalanceComprobacion
        '
        Me.ToolBarButtonBalanceComprobacion.ImageIndex = 20
        Me.ToolBarButtonBalanceComprobacion.Name = "ToolBarButtonBalanceComprobacion"
        Me.ToolBarButtonBalanceComprobacion.Text = "Balance Comprobación"
        '
        'ToolBarButtonEstadoR
        '
        Me.ToolBarButtonEstadoR.ImageIndex = 11
        Me.ToolBarButtonEstadoR.Name = "ToolBarButtonEstadoR"
        Me.ToolBarButtonEstadoR.Text = "Estado Resultado"
        Me.ToolBarButtonEstadoR.Visible = False
        '
        'ToolBarButtonBalance
        '
        Me.ToolBarButtonBalance.ImageIndex = 10
        Me.ToolBarButtonBalance.Name = "ToolBarButtonBalance"
        Me.ToolBarButtonBalance.Text = "Balance General"
        Me.ToolBarButtonBalance.Visible = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        Me.ImageList1.Images.SetKeyName(13, "")
        Me.ImageList1.Images.SetKeyName(14, "")
        Me.ImageList1.Images.SetKeyName(15, "")
        Me.ImageList1.Images.SetKeyName(16, "")
        Me.ImageList1.Images.SetKeyName(17, "")
        Me.ImageList1.Images.SetKeyName(18, "")
        Me.ImageList1.Images.SetKeyName(19, "")
        Me.ImageList1.Images.SetKeyName(20, "")
        Me.ImageList1.Images.SetKeyName(21, "")
        Me.ImageList1.Images.SetKeyName(22, "")
        '
        'StatusBar1
        '
        Me.StatusBar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.StatusBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusBar1.Location = New System.Drawing.Point(0, 284)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel1, Me.StatusBarPanel4, Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel5, Me.stVersion})
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(766, 16)
        Me.StatusBar1.TabIndex = 18
        '
        'StatusBarPanel1
        '
        Me.StatusBarPanel1.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel1.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel1.Name = "StatusBarPanel1"
        Me.StatusBarPanel1.Width = 10
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel2.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Width = 10
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Contents
        Me.StatusBarPanel3.BorderStyle = System.Windows.Forms.StatusBarPanelBorderStyle.None
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Width = 10
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 519
        '
        'stVersion
        '
        Me.stVersion.Name = "stVersion"
        Me.stVersion.Text = "v13.02.2020"
        '
        'PictureBoxFondo
        '
        Me.PictureBoxFondo.Image = CType(resources.GetObject("PictureBoxFondo.Image"), System.Drawing.Image)
        Me.PictureBoxFondo.Location = New System.Drawing.Point(8, 48)
        Me.PictureBoxFondo.Name = "PictureBoxFondo"
        Me.PictureBoxFondo.Size = New System.Drawing.Size(100, 100)
        Me.PictureBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxFondo.TabIndex = 14
        Me.PictureBoxFondo.TabStop = False
        Me.PictureBoxFondo.Visible = False
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 13
        Me.MenuItem12.Text = "Navegador de Asientos"
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(766, 300)
        Me.Controls.Add(Me.StatusBar1)
        Me.Controls.Add(Me.ToolBar1)
        Me.Controls.Add(Me.PictureBoxFondo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stVersion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "Load"

    Sub spForzarConfiguracionRegionl()
        Dim oldDecimalSeparator As String =
            Application.CurrentCulture.NumberFormat.NumberDecimalSeparator

        Dim forceDotCulture As CultureInfo
        forceDotCulture = Application.CurrentCulture.Clone()
        forceDotCulture.NumberFormat.NumberDecimalSeparator = "."
        forceDotCulture.NumberFormat.NumberGroupSeparator = ","

        forceDotCulture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy"
        forceDotCulture.DateTimeFormat.AMDesignator = "a.m."
        forceDotCulture.DateTimeFormat.PMDesignator = "p.m."
        forceDotCulture.DateTimeFormat.ShortTimePattern = "hh:mm tt"
        Application.CurrentCulture = forceDotCulture

    End Sub

    Public Shared Function fnVersion() As String
        Dim ver As String = ""
        Try

            If (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed) Then
                Dim ad As System.Deployment.Application.ApplicationDeployment =
        System.Deployment.Application.ApplicationDeployment.CurrentDeployment

                ver = ad.CurrentVersion.ToString()

            End If
        Catch ex As Exception
            ver = ""
        End Try

        Return ver

    End Function
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        spForzarConfiguracionRegionl()
        StatusBarPanel4.Text = Usuario.Nombre
        StatusBarPanel3.Text = Usuario.Cedula

        mniHotelConfiguracionCuenta.Visible = True
        mniHotelGeneracionAutomatica.Visible = True
        stVersion.Text = fnVersion()

        Dim segura As String = "0"
        Try
            segura = Configuracion.Claves.Configuracion("seguro")
        Catch ex As Exception
            SaveSetting("SeeSOFT", "Seguridad", "segura", "0")
            segura = "0"
        End Try
        If segura = "0" Then
            StatusBarPanel5.Text = "Habilitando acceso a sistema Contabilidad.."
            MenuItemAsientos.Enabled = VerificandoAcceso_a_Modulos("FrmAsientos", "Asiento Manuales", Usuario.Cedula, "Contabilidad")
            MenuItemMayorizacionAsiento.Enabled = VerificandoAcceso_a_Modulos("fmrMayorizacionAsiento", "Mayorización de Asientos", Usuario.Cedula, "Contabilidad")
            MenuItemBalanceComprobacion.Enabled = VerificandoAcceso_a_Modulos("frmBalanceComprobacion", "Balance de Comprobación", Usuario.Cedula, "Contabilidad")
            MenuItem9.Enabled = VerificandoAcceso_a_Modulos("Formato_Cuentas_Contables", "Formato de Cuentas Contables", Usuario.Cedula, "Contabilidad")
            MenuItem10.Enabled = VerificandoAcceso_a_Modulos("FrmTiposDocumentos", "Tipos Documentos", Usuario.Cedula, "Contabilidad")
            MenuItemCuentaContable.Enabled = VerificandoAcceso_a_Modulos("Cuentas_Contables", "Cuentas Contables", Usuario.Cedula, "Contabilidad")

            MenuItemEstadosFinancieros.Enabled = VerificandoAcceso_a_Modulos("frmEstadoR", "Estado Fincenciero", Usuario.Cedula, "Contabilidad")
            MenuItem34.Enabled = VerificandoAcceso_a_Modulos("Analitico", "Reporte Analítico", Usuario.Cedula, "Contabilidad")
            MenuItem1.Enabled = VerificandoAcceso_a_Modulos("frmComparativoCuenta", "Reporte Comparativo Cuenta", Usuario.Cedula, "Contabilidad")
            MenuItemCentroCosto.Enabled = VerificandoAcceso_a_Modulos("FrmCentroCosto", "Centro Costo", Usuario.Cedula, "Contabilidad")
            MenuItemReporteCC.Enabled = VerificandoAcceso_a_Modulos("frmBalanceCentroCosto", "Balance Centro Costo", Usuario.Cedula, "Contabilidad")
            MenuItemPeriodoTrabajo.Enabled = VerificandoAcceso_a_Modulos("FrmPeriodo", "Periodo de Trabajo", Usuario.Cedula, "Contabilidad")
            MenuItemPeriodoFiscal.Enabled = VerificandoAcceso_a_Modulos("PeriodoFiscal", "Periodo Fiscal", Usuario.Cedula, "Contabilidad")
            MenuItemCierreAnual.Enabled = VerificandoAcceso_a_Modulos("FrmCierreAnual", "Cierre Anual", Usuario.Cedula, "Contabilidad")
            MenuItemCuentasFamilias.Enabled = VerificandoAcceso_a_Modulos("Configura_Cuentas_2", "Setting de Cuentas", Usuario.Cedula, "Contabilidad")
            '-----------HOTEL---------
            mniHotelConfiguracionCuenta.Enabled = VerificandoAcceso_a_Modulos("FrmSettingHotelCuentaContable", "Setting de Cuentas", Usuario.Cedula, "Contabilidad")
            MenuItem5.Enabled = VerificandoAcceso_a_Modulos("frmHotelReciboDineroGeneracionAutomatica", "Asiento Recibos Dinero", Usuario.Cedula, "Contabilidad")
            MenuItem30.Enabled = VerificandoAcceso_a_Modulos("frmHotelAjusteCuentaPagarGeneracionAutomatica", "Asiento Ajuste Cuenta por Pagar", Usuario.Cedula, "Contabilidad")
            MenuItem33.Enabled = VerificandoAcceso_a_Modulos("frmHotelChequeGeneracionAutomatica", "Asiento Cheque", Usuario.Cedula, "Contabilidad")
            MenuItem53.Enabled = VerificandoAcceso_a_Modulos("frmHotelDepositoGeneracionAutomatica", "Asiento Depositos", Usuario.Cedula, "Contabilidad")
            MenuItem54.Enabled = VerificandoAcceso_a_Modulos("frmHotelAjusteBancarioGeneracionAutomatica", "Asiento Ajuste Bancario", Usuario.Cedula, "Contabilidad")
            MenuItem61.Enabled = VerificandoAcceso_a_Modulos("frmHotelCortesiaAutomatica", "Asiento Cortesía", Usuario.Cedula, "Contabilidad")
            '------------PROVEDURIA----------
            MenuItem39.Enabled = VerificandoAcceso_a_Modulos("frmProveeduriaGeneracionAutomatica", "Asiento Compras", Usuario.Cedula, "Contabilidad")
            MenuItem47.Enabled = VerificandoAcceso_a_Modulos("frmProveeduriaDevolucionGeneracionAutomatica", "Asiento Devolución de Compras", Usuario.Cedula, "Contabilidad")
            MenuItem48.Enabled = VerificandoAcceso_a_Modulos("frmRequisicionesGeneracionAutomatica", "Asiento de Requisición", Usuario.Cedula, "Contabilidad")
            MenuItem49.Enabled = VerificandoAcceso_a_Modulos("frmTrasladoGeneracionAutomatica", "Asiento Traslado", Usuario.Cedula, "Contabilidad")
            MenuItem35.Enabled = VerificandoAcceso_a_Modulos("frmHotelGasto", "Asiento Gasto", Usuario.Cedula, "Contabilidad")
            MenuItem50.Enabled = VerificandoAcceso_a_Modulos("frmProveeduriaAjusteInventario", "Asiento Ajuste Inventario", Usuario.Cedula, "Contabilidad")
            MenuItem46.Enabled = VerificandoAcceso_a_Modulos("frmHotelAjusteCuentaCobrarGeneracionAutomatica", "Asiento Ajuste Cuenta por Cobrar", Usuario.Cedula, "Contabilidad")
            MenuItem52.Enabled = VerificandoAcceso_a_Modulos("frmHotelAjusteCuentaPagarGeneracionAutomatica", "Asiento Ajuste Cuenta por Pagar", Usuario.Cedula, "Contabilidad")
            '---------FIN PROVEDURIA---------------
        End If

        '3-101-374928-30
        Me.MenuItemAsientoPrepago.Visible = False
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select Cedula From configuraciones", dt, Configuracion.Claves.Conexion("Contabilidad"))
        If dt.Rows.Count > 0 Then
            Me.Cedula_Empresa = dt.Rows(0).Item("Cedula")
            If dt.Rows(0).Item("Cedula").Equals("3-101-374928-30") Then
                Me.MenuItemAsientoPrepago.Visible = True
            End If

        End If

        If Configuracion.Claves.Configuracion("ConPresupuesto").Equals("SI") Then
            Me.mitmPresupuesto.Visible = True
        End If

        If MenuItemAsientos.Enabled = False Then ToolBarButtonAsientos.Enabled = False
        If MenuItemMayorizacionAsiento.Enabled = False Then ToolBarButtonMayorizacionAsiento.Enabled = False
        If MenuItemBalanceComprobacion.Enabled = False Then ToolBarButtonBalanceComprobacion.Enabled = False
        If MenuItemCuentaContable.Enabled = False Then ToolBarButtonCuentaContable.Enabled = False

        StatusBarPanel5.Text = ""
        If Not Configuracion.Claves.Configuracion("TipoConta").Equals("LCPYMES") Then
            Me.MenuItem7.Visible = False
            Me.mitmBajarAsientosLCPYMES.Visible = False
            mniHotelGeneracionAutomatica.Visible = True

        Else
            Me.MenuItem7.Visible = True
            Me.mitmBajarAsientosLCPYMES.Visible = True
            mniHotelGeneracionAutomatica.Visible = False

        End If

        If Me.Cedula_Empresa = "3-102-622891" Or Me.Cedula_Empresa = "3-101-629600" Then
            'si es ksa plastico 
            Me.MenuItem7.Visible = True
            Me.mitmBajarAsientosLCPYMES.Visible = True
            mniHotelGeneracionAutomatica.Visible = False

            Me.MenuItem38.Visible = True
        End If

    End Sub
    Public Cedula_Empresa As String = ""

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Text = Microsoft.VisualBasic.Mid("CONTABILIDAD -- SISTEMAS ESTRUCTURALES DE SOFTWARE  ", 1, Contador)
        Contador = Contador + 1
        If Contador = Microsoft.VisualBasic.Len("CONTABILIDAD -- SISTEMAS ESTRUCTURALES DE SOFTWARE") Then Contador = 1
        StatusBarPanel1.Text = Date.Now
    End Sub


    Private Sub MainForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Dim imagen As New Drawing.Bitmap(PictureBoxFondo.Image, Width, Height)
        BackgroundImage = imagen
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 1 : CargarForm(New Cuentas_Contables(Usuario))
            Case 2 : CargarForm(New FrmAsientos(Usuario))
            Case 3 : CargarForm(New fmrMayorizacionAsiento(Usuario))
            Case 4
                If MsgBox("Desea Balance de Comprobación en Colón y Dolar", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                    CargarForm(New frmBalanceComprobacion(Usuario, 0))
                Else
                    CargarForm(New frmBalanceComprobacion(Usuario, 1))
                End If

                'Case 5 : CargarForm(New frmEstadoR(Usuario))
                'Case 6 : CargarForm(New frmBalance(Usuario)) 'cargaInfo() 
        End Select
    End Sub


    Private Sub cargaInfo()
        Dim cnnConexion As New SqlClient.SqlConnection
        Dim adpAdapter1 As New SqlClient.SqlDataAdapter
        Dim sqlCommand As New System.Data.SqlClient.SqlCommand
        Dim rs As System.Data.SqlClient.SqlDataReader
        Dim dts1 As New DataSet
        Dim i As Integer


        cnnConexion.ConnectionString = Configuracion.Claves.Conexion("Proveeduria")
        cnnConexion.Open()

        sqlCommand.Connection = cnnConexion


        sqlCommand.CommandText = "SELECT Codigo, Cantidad, bodega_id FROM VISTASININGRESAR"
        adpAdapter1.SelectCommand = sqlCommand
        adpAdapter1.Fill(dts1, "INFORMACION")

        For i = 0 To dts1.Tables("INFORMACION").Rows.Count() - 1
            Try
                sqlCommand.CommandText = "Update Inventario set existencia=existencia + " & dts1.Tables("INFORMACION").Rows(i).Item(1) & " where codigo=" & dts1.Tables("INFORMACION").Rows(i).Item(0)
                sqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error en Inventario")
            End Try

            Try
                sqlCommand.CommandText = "update articulosxBodega set existencia=existencia+ " & dts1.Tables("INFORMACION").Rows(i).Item(1) & " where codigo= " & dts1.Tables("INFORMACION").Rows(i).Item(0) & " and idBodega=" & dts1.Tables("INFORMACION").Rows(i).Item(2)
                sqlCommand.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox("Error en articulosxbodega")
            End Try

        Next
        MsgBox("Conclusion Satisfactoria")
        cnnConexion.Close()
        dts1.Clear()
    End Sub
#End Region

#Region "Funciones"
    Private Sub CargarForm(ByVal Form As Form)
        Try
            Form.MdiParent = Me
            Form.Left = (Screen.PrimaryScreen.WorkingArea.Width - Form.Width) \ 2
            Form.Top = (Screen.PrimaryScreen.WorkingArea.Height - Form.Height) \ 2
            Form.StartPosition = FormStartPosition.CenterScreen
            Form.Show()
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub
#End Region

#Region "MenuItem"
    Private Sub mniHotelConfiguracionCuenta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniHotelConfiguracionCuenta.Click
        CargarForm(New FrmSettingHotelCuentaContable(Usuario))
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAsientos.Click
        CargarForm(New FrmAsientos(Usuario))
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemMayorizacionAsiento.Click
        CargarForm(New fmrMayorizacionAsiento(Usuario))
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemBalanceComprobacion.Click
        If MsgBox("Desea Balance de Comprobación en Colón y Dolar", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            CargarForm(New frmBalanceComprobacion(Usuario, 0))
        Else
            CargarForm(New frmBalanceComprobacion(Usuario, 1))
        End If

    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmAsientoVentaGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmDevolucionVentaGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        CargarForm(New Formato_Cuentas_Contables(Usuario))
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        CargarForm(New FrmTiposDocumentos(Usuario))
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        If MessageBox.Show(" ¿ Esta seguro que desea salir de esta aplicación ? ", "Atención...", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmAsientoCompraGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmDevolucionCompraGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmReciboDineroGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCuentaContable.Click
        CargarForm(New Cuentas_Contables(Usuario))
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmEstadoR(Usuario))
    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniSeeposConfiguracionCuenta.Click
        CargarForm(New FrmSettingCuentaContable(Usuario))
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmBalance(Usuario))
    End Sub

    Private Sub MenuItem1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        CargarForm(New frmComparativoCuenta(Usuario))
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        CargarForm(New frmHotelChequeGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem48_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        CargarForm(New frmRequisicionesGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        CargarForm(New frmTrasladoGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
        CargarForm(New frmProveeduriaGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem47.Click
        CargarForm(New frmProveeduriaDevolucionGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        CargarForm(New frmHotelChequeGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        CargarForm(New frmHotelDepositoGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        CargarForm(New frmHotelAjusteBancarioGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        CargarForm(New frmHotelAjusteCuentaPagarGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        CargarForm(New frmHotelAjusteCuentaCobrarGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        CargarForm(New Analitico(Usuario))
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        CargarForm(New frmHotelGasto(Usuario))
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Dim frm As New FrmRespaldo()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New FrmRespaldo)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem50.Click
        CargarForm(New frmProveeduriaAjusteInventario(Usuario))
    End Sub

    Private Sub MenuItem2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem2.Click
        CargarForm(New frmHotelPlanillaGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem23_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem23.Click
        CargarForm(New frmHotelTransferenciaGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New CierreDiario()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New CierreDiario)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CargarForm(New frmHotelCostoVentaAutomatica(Usuario))
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        CargarForm(New frmHotelCortesiaAutomatica(Usuario))
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click

        Dim frm As New CierreDiario2(Usuario)
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New CierreDiario2(Usuario))
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        CargarForm(New frmHotelReciboDineroGeneracionAutomatica(Usuario))
    End Sub

    Private Sub MenuItemCentroCosto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCentroCosto.Click
        CargarForm(New FrmCentroCosto(Usuario))
    End Sub

    Private Sub MenuItemReporteCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemReporteCC.Click
        CargarForm(New frmBalanceCentroCosto(Usuario))
    End Sub

    Private Sub MenuItemPeriodoTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPeriodoTrabajo.Click
        CargarForm(New FrmPeriodo(Usuario))
    End Sub

    Private Sub MenuItemPeriodoFiscal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemPeriodoFiscal.Click
        CargarForm(New PeriodoFiscal(Usuario))
    End Sub

    Private Sub MenuItemValuacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItemCierreAnual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCierreAnual.Click
        CargarForm(New FrmCierreAnual(Usuario))
    End Sub

    Private Sub MenuItemCuentasFamilias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemCuentasFamilias.Click
        CargarForm(New Configura_Cuentas_2(Usuario))
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        CargarForm(New AsientosIngresos)
    End Sub

#End Region

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim frm As New FormChequeoAsientosBancos
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then

            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click

        Dim frm As New FormListadoAsiento
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then

            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub


    Private Sub mniHotelGeneracionAutomatica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mniHotelGeneracionAutomatica.Click

    End Sub

    Private Sub MenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItemAsientoPrepago.Click

        Dim frm As New frmAsientoPrepago()

        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmAsientoPrepago)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim frm As New frmBalanceSituacion(Usuario, 0)
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            If MsgBox("Desea Balance de Comprobación en Colón y Dolar", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                CargarForm(New frmBalanceSituacion(Usuario, 0))
            Else
                CargarForm(New frmBalanceSituacion(Usuario, 1))
            End If
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmBalanceSituacion(Usuario, 2)
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmBalanceSituacion(Usuario, 2))
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        Dim frm As New frmPresupuesto()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmPresupuesto)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem15_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click

        Dim frm As New FrmAprobarPresupuesto()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New FrmAprobarPresupuesto)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem16.Click
        Dim frm As New FrmModificarPresupuesto()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New FrmModificarPresupuesto)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim frm As New FrmMantenimientoPresupuesto()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New FrmMantenimientoPresupuesto)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem18_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim frm As New FrmEstadoResultadovsPresupuesto()
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New FrmEstadoResultadovsPresupuesto)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim frm As New Cuentas_Contables_P(Usuario)
        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New Cuentas_Contables_P(Usuario))
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim frm As New frmAnaliticoxCuenta


        If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
            frm.usua = Usuario
            CargarForm(frm)

        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub mitmBajarAsientosLCPYMES_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitmBajarAsientosLCPYMES.Click
        Select Case Me.Cedula_Empresa
            Case "3-101-624701"
                'cedula de tms repuestos
                'esta vercion tiene cotroles de facturas pendientes de pago, devoluciones
                'y esta ajustada a la operacion de esta empresa
                'facturas de inventario cuando son de contado van a una cuenta transitoria por distribuir y si son de credito van a la de proveedores general
                Dim frm As New frmAsientosIndividualesTMS

                If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
                    frm.MdiParent = Me
                    frm.Show()
                Else
                    MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
                End If
            Case "3-102-622891"
            Case "3-101-629600"
                'cedula de Casa Plastico Liberia
                'estavercion tiene cotroles apartados, abonos apartados, devoluciones
                'y esta ajustada a la operacion de esta empresa
                Dim frm As New frmAsientosIndividualesCasaPlastico
                If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
                    frm.MdiParent = Me
                    frm.Show()
                Else
                    MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
                End If
            Case Else
                'versiones generales y la de felipe(comunidad,bramadero,la parada).
                Dim frm As New frmAsientosIndividualesFelipe
                If VerificandoAcceso_a_Modulos(frm.Name, frm.Text, Usuario.Cedula, "Contabilidad") Then
                    frm.MdiParent = Me
                    frm.Show()
                Else
                    MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
                End If
        End Select


    End Sub

    Private Sub MenuItem7_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem7.Click
        Dim f As New frmHotelPlanillaGeneracionAutomatica(Usuario)
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmHotelPlanillaGeneracionAutomatica(Usuario))

        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem22.Click
        Dim f As New frmGeneraDatosCierre(Usuario, 1)

        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmGeneraDatosCierre(Usuario, 1))

        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem24_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New FormNuevosEstadosFinacieros()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New FormNuevosEstadosFinacieros)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem31.Click
        Dim f As New frmConfigurarNotas
        f.MdiParent = Me
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            f.Show()
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Dim f As New frmConfigurarFlujoEfectivo
        f.MdiParent = Me
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            f.Show()
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Dim f As New frmRequisicionesLcpymes(Usuario)
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmRequisicionesLcpymes(Usuario))
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim f As New frmBalanceSituancionNuevo()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmBalanceSituancionNuevo)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem58_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim f As New frmEstadosResultados1()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmEstadosResultados1)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim f As New frmEstadosResultados2()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            CargarForm(New frmEstadosResultados2)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem59_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click

        Dim f As New frmCobroTarjeta()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            Me.CargarForm(New frmCobroTarjeta)
        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem60_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Dim f As New frmGastosComparativo()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            Me.CargarForm(New frmGastosComparativo)

        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Dim f As New frmAciondePersonal()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            Me.CargarForm(New frmAciondePersonal)

        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If

    End Sub

    Private Sub MenuItem65_Click(sender As Object, e As EventArgs) Handles MenuItem65.Click
        Dim f As New frmCajas()
        If VerificandoAcceso_a_Modulos(f.Name, f.Text, Usuario.Cedula, "Contabilidad") Then
            Caja.Lista(Me)

        Else
            MsgBox("No tiene permiso ejecutar el módulo", MsgBoxStyle.Information, "Atención...")
        End If
    End Sub

    Private Sub MenuItem12_Click_1(sender As Object, e As EventArgs) Handles MenuItemEstadosFinancieros.Click
        LcConta.Nuevos.EstadosFinancieros.Abrir(Me, Usuario.Nombre)
    End Sub

    Private Sub MenuItem12_Click_2(sender As Object, e As EventArgs) Handles MenuItem12.Click
        Dim f As New frmNavegadorAsientos(Usuario)
        f.MdiParent = Me
        f.Show()

    End Sub
End Class
