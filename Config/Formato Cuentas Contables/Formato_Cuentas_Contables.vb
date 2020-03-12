Imports System.Data.SqlClient
Imports Utilidades
Public Class Formato_Cuentas_Contables
    Inherits Plantilla
    Dim t As String
    Dim separador As Char
    Dim usua As Object

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal Usuario_Parametro As Object)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        usua = Usuario_Parametro
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
    Friend WithEvents numNiveles As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtN1 As System.Windows.Forms.TextBox
    Friend WithEvents txtN2 As System.Windows.Forms.TextBox
    Friend WithEvents txtN3 As System.Windows.Forms.TextBox
    Friend WithEvents txtN5 As System.Windows.Forms.TextBox
    Friend WithEvents txtN6 As System.Windows.Forms.TextBox
    Friend WithEvents txtN7 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbtEspacio As System.Windows.Forms.RadioButton
    Friend WithEvents rbtGuion As System.Windows.Forms.RadioButton
    Friend WithEvents txtN4 As System.Windows.Forms.TextBox
    Friend WithEvents rbtOtro As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents AdapterFormatoCuenta As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents DataSetFormatoCuenta1 As Contabilidad.DataSetFormatoCuenta
    Friend WithEvents txtN8 As System.Windows.Forms.TextBox
    Friend WithEvents txtOtro As System.Windows.Forms.TextBox
    Friend WithEvents lblPrevia As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Formato_Cuentas_Contables))
        Me.numNiveles = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtN1 = New System.Windows.Forms.TextBox
        Me.txtN2 = New System.Windows.Forms.TextBox
        Me.txtN3 = New System.Windows.Forms.TextBox
        Me.txtN5 = New System.Windows.Forms.TextBox
        Me.txtN6 = New System.Windows.Forms.TextBox
        Me.txtN7 = New System.Windows.Forms.TextBox
        Me.txtN8 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.rbtEspacio = New System.Windows.Forms.RadioButton
        Me.rbtGuion = New System.Windows.Forms.RadioButton
        Me.txtN4 = New System.Windows.Forms.TextBox
        Me.rbtOtro = New System.Windows.Forms.RadioButton
        Me.txtOtro = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblPrevia = New System.Windows.Forms.Label
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.AdapterFormatoCuenta = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.DataSetFormatoCuenta1 = New Contabilidad.DataSetFormatoCuenta
        CType(Me.numNiveles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetFormatoCuenta1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TituloModulo
        '
        Me.TituloModulo.Name = "TituloModulo"
        Me.TituloModulo.Size = New System.Drawing.Size(392, 32)
        Me.TituloModulo.Text = "Formulario Formato Cuentas Contables"
        '
        'ToolBar1
        '
        Me.ToolBar1.Location = New System.Drawing.Point(0, 122)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.Size = New System.Drawing.Size(392, 52)
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'ToolBarBuscar
        '
        Me.ToolBarBuscar.Visible = False
        '
        'ToolBarEliminar
        '
        Me.ToolBarEliminar.Visible = False
        '
        'ToolBarImprimir
        '
        Me.ToolBarImprimir.Visible = False
        '
        'ToolBarNuevo
        '
        Me.ToolBarNuevo.Visible = False
        '
        'numNiveles
        '
        Me.numNiveles.Location = New System.Drawing.Point(0, 55)
        Me.numNiveles.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.numNiveles.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNiveles.Name = "numNiveles"
        Me.numNiveles.Size = New System.Drawing.Size(64, 20)
        Me.numNiveles.TabIndex = 60
        Me.numNiveles.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 61
        Me.Label1.Text = "Niveles"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(70, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(314, 16)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Niveles"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtN1
        '
        Me.txtN1.Location = New System.Drawing.Point(70, 56)
        Me.txtN1.MaxLength = 1
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(32, 20)
        Me.txtN1.TabIndex = 71
        Me.txtN1.Text = "1"
        Me.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN2
        '
        Me.txtN2.Location = New System.Drawing.Point(110, 56)
        Me.txtN2.MaxLength = 1
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(32, 20)
        Me.txtN2.TabIndex = 72
        Me.txtN2.Text = "0"
        Me.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN3
        '
        Me.txtN3.Location = New System.Drawing.Point(150, 56)
        Me.txtN3.MaxLength = 1
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(32, 20)
        Me.txtN3.TabIndex = 73
        Me.txtN3.Text = "0"
        Me.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN5
        '
        Me.txtN5.Location = New System.Drawing.Point(230, 56)
        Me.txtN5.MaxLength = 1
        Me.txtN5.Name = "txtN5"
        Me.txtN5.Size = New System.Drawing.Size(32, 20)
        Me.txtN5.TabIndex = 75
        Me.txtN5.Text = "0"
        Me.txtN5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN6
        '
        Me.txtN6.Location = New System.Drawing.Point(270, 56)
        Me.txtN6.MaxLength = 1
        Me.txtN6.Name = "txtN6"
        Me.txtN6.Size = New System.Drawing.Size(32, 20)
        Me.txtN6.TabIndex = 76
        Me.txtN6.Text = "0"
        Me.txtN6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN7
        '
        Me.txtN7.Location = New System.Drawing.Point(310, 56)
        Me.txtN7.MaxLength = 1
        Me.txtN7.Name = "txtN7"
        Me.txtN7.Size = New System.Drawing.Size(32, 20)
        Me.txtN7.TabIndex = 77
        Me.txtN7.Text = "0"
        Me.txtN7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN8
        '
        Me.txtN8.Location = New System.Drawing.Point(350, 56)
        Me.txtN8.MaxLength = 1
        Me.txtN8.Name = "txtN8"
        Me.txtN8.Size = New System.Drawing.Size(32, 20)
        Me.txtN8.TabIndex = 78
        Me.txtN8.Text = "0"
        Me.txtN8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(0, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 16)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Separador"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rbtEspacio
        '
        Me.rbtEspacio.Checked = True
        Me.rbtEspacio.Location = New System.Drawing.Point(2, 96)
        Me.rbtEspacio.Name = "rbtEspacio"
        Me.rbtEspacio.Size = New System.Drawing.Size(70, 24)
        Me.rbtEspacio.TabIndex = 80
        Me.rbtEspacio.TabStop = True
        Me.rbtEspacio.Text = "Espacio"
        '
        'rbtGuion
        '
        Me.rbtGuion.Location = New System.Drawing.Point(72, 96)
        Me.rbtGuion.Name = "rbtGuion"
        Me.rbtGuion.Size = New System.Drawing.Size(56, 24)
        Me.rbtGuion.TabIndex = 81
        Me.rbtGuion.Text = "Guión"
        '
        'txtN4
        '
        Me.txtN4.Location = New System.Drawing.Point(190, 56)
        Me.txtN4.MaxLength = 1
        Me.txtN4.Name = "txtN4"
        Me.txtN4.Size = New System.Drawing.Size(32, 20)
        Me.txtN4.TabIndex = 74
        Me.txtN4.Text = "0"
        Me.txtN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbtOtro
        '
        Me.rbtOtro.Location = New System.Drawing.Point(131, 96)
        Me.rbtOtro.Name = "rbtOtro"
        Me.rbtOtro.Size = New System.Drawing.Size(45, 24)
        Me.rbtOtro.TabIndex = 82
        Me.rbtOtro.Text = "Otro"
        '
        'txtOtro
        '
        Me.txtOtro.Enabled = False
        Me.txtOtro.Location = New System.Drawing.Point(176, 96)
        Me.txtOtro.MaxLength = 1
        Me.txtOtro.Name = "txtOtro"
        Me.txtOtro.Size = New System.Drawing.Size(32, 20)
        Me.txtOtro.TabIndex = 83
        Me.txtOtro.Text = "*"
        Me.txtOtro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(128, Byte), CType(255, Byte))
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(216, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "Vista Previa"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPrevia
        '
        Me.lblPrevia.BackColor = System.Drawing.Color.Transparent
        Me.lblPrevia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblPrevia.Location = New System.Drawing.Point(216, 97)
        Me.lblPrevia.Name = "lblPrevia"
        Me.lblPrevia.Size = New System.Drawing.Size(168, 16)
        Me.lblPrevia.TabIndex = 85
        Me.lblPrevia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DIEGO;packet size=4096;integrated security=SSPI;data source=DIEGO;" & _
        "persist security info=False;initial catalog=Contabilidad"
        '
        'AdapterFormatoCuenta
        '
        Me.AdapterFormatoCuenta.DeleteCommand = Me.SqlDeleteCommand1
        Me.AdapterFormatoCuenta.InsertCommand = Me.SqlInsertCommand1
        Me.AdapterFormatoCuenta.SelectCommand = Me.SqlSelectCommand1
        Me.AdapterFormatoCuenta.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "FormatoCuenta", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Id", "Id"), New System.Data.Common.DataColumnMapping("Niveles", "Niveles"), New System.Data.Common.DataColumnMapping("N1", "N1"), New System.Data.Common.DataColumnMapping("N2", "N2"), New System.Data.Common.DataColumnMapping("N3", "N3"), New System.Data.Common.DataColumnMapping("N4", "N4"), New System.Data.Common.DataColumnMapping("N5", "N5"), New System.Data.Common.DataColumnMapping("N6", "N6"), New System.Data.Common.DataColumnMapping("N7", "N7"), New System.Data.Common.DataColumnMapping("N8", "N8"), New System.Data.Common.DataColumnMapping("Separador", "Separador")})})
        Me.AdapterFormatoCuenta.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM FormatoCuenta WHERE (Id = @Original_Id) AND (N1 = @Original_N1) AND (" & _
        "N2 = @Original_N2) AND (N3 = @Original_N3) AND (N4 = @Original_N4) AND (N5 = @Or" & _
        "iginal_N5) AND (N6 = @Original_N6) AND (N7 = @Original_N7) AND (N8 = @Original_N" & _
        "8) AND (Niveles = @Original_Niveles) AND (Separador = @Original_Separador)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO FormatoCuenta(Niveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador) VAL" & _
        "UES (@Niveles, @N1, @N2, @N3, @N4, @N5, @N6, @N7, @N8, @Separador); SELECT Id, N" & _
        "iveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador FROM FormatoCuenta WHERE (Id =" & _
        " @@IDENTITY)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador"))
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT Id, Niveles, N1, N2, N3, N4, N5, N6, N7, N8, Separador FROM FormatoCuenta"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE FormatoCuenta SET Niveles = @Niveles, N1 = @N1, N2 = @N2, N3 = @N3, N4 = @" & _
        "N4, N5 = @N5, N6 = @N6, N7 = @N7, N8 = @N8, Separador = @Separador WHERE (Id = @" & _
        "Original_Id) AND (N1 = @Original_N1) AND (N2 = @Original_N2) AND (N3 = @Original" & _
        "_N3) AND (N4 = @Original_N4) AND (N5 = @Original_N5) AND (N6 = @Original_N6) AND" & _
        " (N7 = @Original_N7) AND (N8 = @Original_N8) AND (Niveles = @Original_Niveles) A" & _
        "ND (Separador = @Original_Separador); SELECT Id, Niveles, N1, N2, N3, N4, N5, N6" & _
        ", N7, N8, Separador FROM FormatoCuenta WHERE (Id = @Id)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Niveles", System.Data.SqlDbType.SmallInt, 2, "Niveles"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N1", System.Data.SqlDbType.SmallInt, 2, "N1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N2", System.Data.SqlDbType.SmallInt, 2, "N2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N3", System.Data.SqlDbType.SmallInt, 2, "N3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N4", System.Data.SqlDbType.SmallInt, 2, "N4"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N5", System.Data.SqlDbType.SmallInt, 2, "N5"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N6", System.Data.SqlDbType.SmallInt, 2, "N6"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N7", System.Data.SqlDbType.SmallInt, 2, "N7"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@N8", System.Data.SqlDbType.SmallInt, 2, "N8"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Separador", System.Data.SqlDbType.VarChar, 1, "Separador"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Id", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Id", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N1", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N2", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N3", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N4", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N4", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N5", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N5", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N6", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N6", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N7", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N7", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_N8", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "N8", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Niveles", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Niveles", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Separador", System.Data.SqlDbType.VarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Separador", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Id", System.Data.SqlDbType.Int, 4, "Id"))
        '
        'DataSetFormatoCuenta1
        '
        Me.DataSetFormatoCuenta1.DataSetName = "DataSetFormatoCuenta"
        Me.DataSetFormatoCuenta1.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'Formato_Cuentas_Contables
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(392, 174)
        Me.Controls.Add(Me.lblPrevia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtOtro)
        Me.Controls.Add(Me.rbtOtro)
        Me.Controls.Add(Me.rbtGuion)
        Me.Controls.Add(Me.rbtEspacio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtN8)
        Me.Controls.Add(Me.txtN7)
        Me.Controls.Add(Me.txtN6)
        Me.Controls.Add(Me.txtN5)
        Me.Controls.Add(Me.txtN4)
        Me.Controls.Add(Me.txtN3)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numNiveles)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 208)
        Me.MinimumSize = New System.Drawing.Size(400, 208)
        Me.Name = "Formato_Cuentas_Contables"
        Me.Text = "Formato Cuentas Contables"
        Me.Controls.SetChildIndex(Me.numNiveles, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtN1, 0)
        Me.Controls.SetChildIndex(Me.txtN2, 0)
        Me.Controls.SetChildIndex(Me.txtN3, 0)
        Me.Controls.SetChildIndex(Me.txtN4, 0)
        Me.Controls.SetChildIndex(Me.txtN5, 0)
        Me.Controls.SetChildIndex(Me.txtN6, 0)
        Me.Controls.SetChildIndex(Me.txtN7, 0)
        Me.Controls.SetChildIndex(Me.txtN8, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.rbtEspacio, 0)
        Me.Controls.SetChildIndex(Me.rbtGuion, 0)
        Me.Controls.SetChildIndex(Me.ToolBar1, 0)
        Me.Controls.SetChildIndex(Me.TituloModulo, 0)
        Me.Controls.SetChildIndex(Me.rbtOtro, 0)
        Me.Controls.SetChildIndex(Me.txtOtro, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblPrevia, 0)
        CType(Me.numNiveles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetFormatoCuenta1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "Load"
    Private Sub Formato_Cuentas_Contables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SqlConnection1.ConnectionString = Configuracion.Claves.Conexion("Contabilidad")
            '***************************************************VALORES POR DEFECTO***************************************************
            Me.DataSetFormatoCuenta1.FormatoCuenta.NivelesColumn.DefaultValue = 1
            Me.DataSetFormatoCuenta1.FormatoCuenta.N1Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N2Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N3Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N4Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N5Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N6Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N7Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.N8Column.DefaultValue = 0
            Me.DataSetFormatoCuenta1.FormatoCuenta.SeparadorColumn.DefaultValue = "-"
            'If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            cargar()
            control_campos(False)
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Me.SqlConnection1.Close()
        End Try
    End Sub
#End Region

#Region "Cargar"
    Sub cargar()
        Try
            Me.AdapterFormatoCuenta.Fill(Me.DataSetFormatoCuenta1.FormatoCuenta)
            If Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Count > 0 Then
                Me.numNiveles.Value = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("Niveles")
                Me.txtN1.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N1")
                Me.txtN2.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N2")
                Me.txtN3.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N3")
                Me.txtN4.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N4")
                Me.txtN5.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N5")
                Me.txtN6.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N6")
                Me.txtN7.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N7")
                Me.txtN8.Text = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N8")
                separador = Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("Separador")
                If separador = " " Then
                    Me.rbtEspacio.Checked = True
                ElseIf separador = "-" Then
                    Me.rbtGuion.Checked = True
                Else
                    Me.rbtOtro.Checked = True
                    Me.txtOtro.Enabled = True
                    Me.txtOtro.Text = separador
                End If
                vista_previa()
            Else
                Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").AddNew()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
#End Region

#Region "Validacion"
    Function validacion()
        Dim comando As New SqlCommand("Select * From CuentaContable", Me.SqlConnection1)
        Try
            If Me.SqlConnection1.State <> ConnectionState.Open Then Me.SqlConnection1.Open()
            Dim fila As String = comando.ExecuteScalar()
            If fila <> "" Then
                MsgBox("No se puede registrar Formato de Cuentas Contables ya que existen Cuentas", MsgBoxStyle.Information)
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            Me.SqlConnection1.Close()
        End Try
        Return True
    End Function
#End Region

#Region "Llenar"
    Sub llenar()
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("Niveles") = CInt(Me.numNiveles.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N1") = CInt(Me.txtN1.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N2") = CInt(Me.txtN2.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N3") = CInt(Me.txtN3.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N4") = CInt(Me.txtN4.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N5") = CInt(Me.txtN5.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N6") = CInt(Me.txtN6.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N7") = CInt(Me.txtN7.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("N8") = CInt(Me.txtN8.Text)
        Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").Current("Separador") = separador
    End Sub
#End Region

#Region "Habilita / Desabilita Campos"
    Sub control_campos(ByVal bool As Boolean)
        txtN2.Enabled = bool
        txtN3.Enabled = bool
        txtN4.Enabled = bool
        txtN5.Enabled = bool
        txtN6.Enabled = bool
        txtN7.Enabled = bool
        txtN8.Enabled = bool
    End Sub
#End Region

#Region "Toolbar"
    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
        PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modulo

        Select Case ToolBar1.Buttons.IndexOf(e.Button) + 1
            Case 3
                If validacion() Then
                    vista_previa()
                    llenar()
                    If PMU.Update Then registrar() Else MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub

                End If
            Case 7 : Me.Close()
        End Select
    End Sub
#End Region

#Region "Registrar"
    Sub registrar()
        Dim Trans As SqlTransaction
        Try
            Me.BindingContext(Me.DataSetFormatoCuenta1, "FormatoCuenta").EndCurrentEdit()
            If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            Trans = Me.SqlConnection1.BeginTransaction
            Me.AdapterFormatoCuenta.InsertCommand.Transaction = Trans
            Me.AdapterFormatoCuenta.UpdateCommand.Transaction = Trans
            Me.AdapterFormatoCuenta.Update(Me.DataSetFormatoCuenta1.FormatoCuenta)
            Me.DataSetFormatoCuenta1.AcceptChanges()
            Trans.Commit()
            MsgBox("Formato de Cuentas Contables registrado satisfactoriamente", MsgBoxStyle.Information)
        Catch ex As Exception
            Trans.Rollback()
            MsgBox(ex.ToString)
        Finally
            Me.SqlConnection1.Close()
        End Try
    End Sub
#End Region

#Region "Vista Previa"
    Sub vista_previa()
        Dim cont As Integer
        lblPrevia.Text = ""
        If rbtGuion.Checked = True Then
            separador = "-"
        ElseIf rbtEspacio.Checked = True Then
            separador = " "
        Else
            separador = txtOtro.Text
        End If
        For cont = 0 To CInt(txtN1.Text) - 1
            lblPrevia.Text += "9"
        Next
        lblPrevia.Text += separador
        If txtN2.Enabled = True Then
            For cont = 0 To CInt(txtN2.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
        lblPrevia.Text += separador
        If txtN3.Enabled = True Then
            For cont = 0 To CInt(txtN3.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
        lblPrevia.Text += separador
        If txtN4.Enabled = True Then
            For cont = 0 To CInt(txtN4.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
        lblPrevia.Text += separador
        If txtN5.Enabled = True Then
            For cont = 0 To CInt(txtN5.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
        lblPrevia.Text += separador
        If txtN6.Enabled = True Then
            For cont = 0 To CInt(txtN6.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
        lblPrevia.Text += separador
        If txtN7.Enabled = True Then
            For cont = 0 To CInt(txtN7.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
        lblPrevia.Text += separador
        If txtN8.Enabled = True Then
            For cont = 0 To CInt(txtN8.Text) - 1
                lblPrevia.Text += "9"
            Next
        Else
            lblPrevia.Text += "0"
        End If
    End Sub
#End Region

#Region "Eventos Controles"
    Private Sub numNiveles_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles numNiveles.ValueChanged
        Select Case Me.numNiveles.Value
            Case 1
                control_campos(False)
                txtN2.Text = "0"
                txtN3.Text = "0"
                txtN4.Text = "0"
                txtN5.Text = "0"
                txtN6.Text = "0"
                txtN7.Text = "0"
                txtN8.Text = "0"
            Case 2
                control_campos(False)
                Me.txtN2.Enabled = True
                txtN2.Text = "1"
                txtN3.Text = "0"
                txtN4.Text = "0"
                txtN5.Text = "0"
                txtN6.Text = "0"
                txtN7.Text = "0"
                txtN8.Text = "0"
            Case 3
                control_campos(False)
                Me.txtN2.Enabled = True
                Me.txtN3.Enabled = True
                txtN3.Text = "1"
                txtN4.Text = "0"
                txtN5.Text = "0"
                txtN6.Text = "0"
                txtN7.Text = "0"
                txtN8.Text = "0"
            Case 4
                control_campos(False)
                Me.txtN2.Enabled = True
                Me.txtN3.Enabled = True
                Me.txtN4.Enabled = True
                txtN4.Text = "1"
                txtN5.Text = "0"
                txtN6.Text = "0"
                txtN7.Text = "0"
                txtN8.Text = "0"
            Case 5
                control_campos(True)
                Me.txtN6.Enabled = False
                Me.txtN7.Enabled = False
                Me.txtN8.Enabled = False
                txtN5.Text = "1"
                txtN6.Text = "0"
                txtN7.Text = "0"
                txtN8.Text = "0"
            Case 6
                control_campos(True)
                Me.txtN7.Enabled = False
                Me.txtN8.Enabled = False
                txtN6.Text = "1"
                txtN7.Text = "0"
                txtN8.Text = "0"
            Case 7
                control_campos(True)
                Me.txtN8.Enabled = False
                txtN7.Text = "1"
                txtN8.Text = "0"
            Case 8
                control_campos(True)
                txtN8.Text = "1"
        End Select
    End Sub

    Private Sub txtN2_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN2.KeyUp
        If Me.txtN2.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN3.Focus()
        End If
    End Sub

    Private Sub txtN2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN2.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN2.Text
            txtN2.Text = e.KeyChar
            If CInt(txtN2.Text) = 0 Then
                txtN2.Text = t
            End If
        End If
    End Sub

    Private Sub txtN1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN1.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN1.Text
            txtN1.Text = e.KeyChar
            If CInt(txtN1.Text) = 0 Then
                txtN1.Text = t
            End If
        End If
    End Sub

    Private Sub txtN1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN1.KeyUp
        If Me.txtN1.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN2.Focus()
        End If
    End Sub

    Private Sub txtN3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN3.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN3.Text
            txtN3.Text = e.KeyChar
            If CInt(txtN3.Text) = 0 Then
                txtN3.Text = t
            End If
        End If
    End Sub

    Private Sub txtN3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN3.KeyUp
        If Me.txtN3.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN4.Focus()
        End If
    End Sub

    Private Sub txtN4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN4.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN4.Text
            txtN4.Text = e.KeyChar
            If CInt(txtN4.Text) = 0 Then
                txtN4.Text = t
            End If
        End If
    End Sub

    Private Sub txtN4_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN4.KeyUp
        If Me.txtN4.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN5.Focus()
        End If
    End Sub

    Private Sub txtN6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN6.KeyPress

        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN6.Text
            txtN6.Text = e.KeyChar
            If CInt(txtN6.Text) = 0 Then
                txtN6.Text = t
            End If
        End If
    End Sub

    Private Sub txtN6_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN6.KeyUp
        If Me.txtN6.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN7.Focus()
        End If
    End Sub

    Private Sub txtN5_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN5.KeyUp
        If Me.txtN5.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN6.Focus()
        End If
    End Sub

    Private Sub txtN5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN5.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN5.Text
            txtN5.Text = e.KeyChar
            If CInt(txtN5.Text) = 0 Then
                txtN5.Text = t
            End If
        End If
    End Sub

    Private Sub txtN7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN7.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN7.Text
            txtN7.Text = e.KeyChar
            If CInt(txtN7.Text) = 0 Then
                txtN7.Text = t
            End If
        End If
    End Sub

    Private Sub txtN7_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN7.KeyUp
        If Me.txtN7.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
        If e.KeyCode = Keys.Enter Then
            Me.txtN8.Focus()
        End If
    End Sub

    Private Sub txtN8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtN8.KeyPress
        If Not Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = True
        Else
            t = txtN8.Text
            txtN8.Text = e.KeyChar
            If CInt(txtN8.Text) = 0 Then
                txtN8.Text = t
            End If
        End If
    End Sub

    Private Sub numNiveles_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles numNiveles.KeyPress
        e.Handled = True
    End Sub

    Private Sub txtOtro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOtro.KeyPress
        If Not Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            txtOtro.Text = e.KeyChar
        End If

    End Sub

    Private Sub rbtOtro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtOtro.CheckedChanged
        Me.vista_previa()
        If rbtOtro.Checked = True Then
            txtOtro.Enabled = True
            txtOtro.Focus()
        Else
            txtOtro.Enabled = False
        End If
    End Sub

    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    vista_previa()
    'End Sub
#End Region


    Private Sub txtN1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN1.TextChanged

    End Sub

    Private Sub txtN8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN8.TextChanged

    End Sub

    Private Sub txtN8_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtN8.KeyUp
        If Me.txtN8.Text = "" Then
            Exit Sub
        End If
        Me.vista_previa()
    End Sub


    Private Sub rbtEspacio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtEspacio.CheckedChanged
        Me.vista_previa()
    End Sub

    Private Sub rbtGuion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtGuion.CheckedChanged
        Me.vista_previa()
    End Sub

    Private Sub txtOtro_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOtro.KeyUp
        Me.vista_previa()
    End Sub

    Private Sub txtN2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN2.TextChanged

    End Sub

    Private Sub txtN3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN3.TextChanged

    End Sub

    Private Sub txtN4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN4.TextChanged

    End Sub

    Private Sub txtN5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN5.TextChanged

    End Sub

    Private Sub txtN6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN6.TextChanged

    End Sub

    Private Sub txtN7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtN7.TextChanged

    End Sub
End Class
