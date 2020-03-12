Public Class FrmPlantilla
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
    Protected WithEvents ImageList As System.Windows.Forms.ImageList
    Protected Friend WithEvents DataNavigator As DevExpress.XtraEditors.DataNavigator
    Protected Friend WithEvents TituloModulo As System.Windows.Forms.Label
    Protected Friend WithEvents ToolBarNuevo As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarBuscar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarRegistrar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarEliminar As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarImprimir As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarExcel As System.Windows.Forms.ToolBarButton
    Protected Friend WithEvents ToolBarCerrar As System.Windows.Forms.ToolBarButton
    Public WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmPlantilla))
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarNuevo = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBuscar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarRegistrar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarEliminar = New System.Windows.Forms.ToolBarButton
        Me.ToolBarImprimir = New System.Windows.Forms.ToolBarButton
        Me.ToolBarExcel = New System.Windows.Forms.ToolBarButton
        Me.ToolBarCerrar = New System.Windows.Forms.ToolBarButton
        Me.TituloModulo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ImageList
        '
        Me.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit
        Me.ImageList.ImageSize = New System.Drawing.Size(32, 32)
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarNuevo, Me.ToolBarBuscar, Me.ToolBarRegistrar, Me.ToolBarEliminar, Me.ToolBarImprimir, Me.ToolBarExcel, Me.ToolBarCerrar})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(77, 30)
        Me.ToolBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList
        Me.ToolBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolBar1.Location = New System.Drawing.Point(0, 394)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(632, 52)
        Me.ToolBar1.TabIndex = 57
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.ImageIndex = 0
        Me.ToolBarNuevo.Text = "Nuevo"
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.ImageIndex = 1
        Me.ToolBarBuscar.Text = "Buscar"
        '
        'ToolBarRegistrar
        '
        Me.ToolBarRegistrar.ImageIndex = 2
        Me.ToolBarRegistrar.Text = "Registrar"
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.ImageIndex = 3
        Me.ToolBarEliminar.Text = "Eliminar"
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.ImageIndex = 7
        Me.ToolBarImprimir.Text = "Imprimir"
        '
        'ToolBarExcel
        '
        Me.ToolBarExcel.ImageIndex = 5
        Me.ToolBarExcel.Text = "Exportar"
        Me.ToolBarExcel.Visible = False
        '
        'ToolBarCerrar
        '
        Me.ToolBarCerrar.ImageIndex = 6
        Me.ToolBarCerrar.Text = "Cerrar"
        '
        'TituloModulo
        '
        Me.TituloModulo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TituloModulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.TituloModulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.TituloModulo.ForeColor = System.Drawing.Color.White
        Me.TituloModulo.Image = CType(resources.GetObject("TituloModulo.Image"), System.Drawing.Image)
        Me.TituloModulo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TituloModulo.Location = New System.Drawing.Point(0, 0)
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(632, 32)
        Me.TituloModulo.TabIndex = 58
        Me.TituloModulo.Text = "Titulo del Módulo"
        Me.TituloModulo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FrmPlantilla
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.ClientSize = New System.Drawing.Size(632, 446)
        Me.Controls.Add(Me.TituloModulo)
        Me.Controls.Add(Me.ToolBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPlantilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Plantilla"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Friend Sub NuevosDatos(ByRef DataSet As DataSet, ByRef Tabla As String)
        'Define dataset y tablas para crear  un nuevo campo
        If ToolBar1.Buttons(0).Text = "Nuevo" Then
            ToolBar1.Buttons(0).Text = "Cancelar"
            ToolBar1.Buttons(0).ImageIndex = 8
            Try
                BindingContext(DataSet, Tabla).EndCurrentEdit()
                BindingContext(DataSet, Tabla).AddNew()
            Catch ex As Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try
        Else
            Me.BindingContext(DataSet, Tabla).CancelCurrentEdit()
            ToolBar1.Buttons(0).Text = "Nuevo"
            ToolBar1.Buttons(0).ImageIndex = 0
        End If
    End Sub

    Friend Sub EliminarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String)
        Dim resp As Integer

        If MsgBox("Desea eliminar el registrto actual...", MsgBoxStyle.YesNo, "Atención...") = MsgBoxResult.Yes Then
            Try
                BindingContext(DataSet, Tabla).RemoveAt(BindingContext(DataSet, Tabla).Position)
                BindingContext(DataSet, Tabla).EndCurrentEdit()
                Adaptador.Update(DataSet, Tabla)
                Adaptador.Fill(DataSet, Tabla)

                MsgBox("Los datos se eliminaron satisfactoriamente", MsgBoxStyle.Information)

            Catch eEndEdit As System.Data.NoNullAllowedException
                System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
            End Try
        End If
    End Sub

    Friend Sub RegistrarDatos(ByRef Adaptador As System.Data.SqlClient.SqlDataAdapter, ByRef DataSet As DataSet, ByRef Tabla As String, Optional ByVal ActivarNuevo As Boolean = True, Optional ByVal VerMsg As Boolean = True)

        Try
            BindingContext(DataSet, Tabla).EndCurrentEdit()
            Adaptador.Update(DataSet, Tabla)
            Adaptador.Fill(DataSet, Tabla)

            If ActivarNuevo Then ToolBar1.Buttons(0).Text = "Nuevo" : ToolBar1.Buttons(0).ImageIndex = 0
            If VerMsg Then MsgBox("Los datos se actualiazaron satisfactoriamente...", MsgBoxStyle.Information, "Atención...")

        Catch eEndEdit As System.Exception
            System.Windows.Forms.MessageBox.Show(eEndEdit.Message)
        End Try
    End Sub

    Friend Sub Cerrar()
        Close()
    End Sub

    Private Sub FrmPlantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
