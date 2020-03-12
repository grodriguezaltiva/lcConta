Public Class cls_AnaliticoDetallado

    'Definimos los campos de la clase.. 
    Dim Fecha As DateTime
    Dim NumAsiento As String
    Dim Moneda As Integer
    Dim TipoCambio As Double
    Dim Observaciones As String
    Dim TipoDoc As Integer
    Dim NumDoc As String
    Dim Debitos As Double
    Dim Creditos As Double
    Dim SaldoAnterior As Double
    Dim SaldoActual As Double

    'Esta variable ejectua las sentencias SQL ..
    Dim f As New cls_Broker
    'tala con los datos..
    Public Detalle As DataTable


    'Creamos el constructor de la clase..
    Public Sub New()
        Me.Fecha = Nothing
        Me.NumAsiento = ""
        Me.Moneda = 0
        Me.TipoCambio = 0
        Me.Observaciones = ""
        Me.TipoDoc = 0
        Me.NumDoc = ""
        Me.Debitos = 0
        Me.Creditos = 0
        Me.SaldoAnterior = 0
        Me.SaldoActual = 0
    End Sub

    'Obtenemos la informacion del detalle..
    Public Function obtenerDetalle(ByRef _conexion As Conexion, ByRef _conectado As SqlClient.SqlConnection, ByRef _cuentaContable As String, ByRef _nivel As Integer, ByRef _fechaInicial As Date, ByRef _fechaFinal As Date, ByRef _codMoneda As Integer, ByRef _cierre As Boolean) As DataTable

        Dim dt As New DataTable
        'Ejecutamos un procedimiento almacenado que carga un tabla con datos sobre el detalle..
        _conexion.SlqExecuteScalar(_conectado, "EXEC dbo.ReporteAnaliticoDetallado '" & _cuentaContable & "'," & _nivel & ",'" & _fechaInicial & "','" & _fechaFinal & "'," & _codMoneda & "," & _cierre)
        'Con esto obtenemos el detalle 
        Me.Detalle = Me.f.fireSQL("Select numAsiento as 'Asiento', Observaciones,Fecha, TipoCambio as 'T.C', numDoc as 'Documento', Debitos, Creditos  from TemporalAnaliticoDetallado")

        Return Me.Detalle

    End Function





End Class
