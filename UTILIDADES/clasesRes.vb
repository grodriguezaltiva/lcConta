Public Class Record
    Private _payment As Double
    Private _lenght As Long
    Private _purchaseDate As DateTime
    Private _number As Integer

    Public Sub New(ByVal payment As Double, ByVal lenght As Long, ByVal purchaseDate As DateTime, ByVal number As Integer)
        _payment = payment
        _lenght = lenght
        _purchaseDate = purchaseDate
        _number = number
    End Sub

    Public Property Payment() As Double
        Get
            Return _payment
        End Get
        Set(ByVal Value As Double)
            _payment = Value
        End Set
    End Property

    Public Property Lenght() As Long
        Get
            Return _lenght
        End Get
        Set(ByVal Value As Long)
            _lenght = Value
        End Set
    End Property

    Public Property PurchaseDate() As DateTime
        Get
            Return _purchaseDate
        End Get
        Set(ByVal Value As DateTime)
            _purchaseDate = Value
        End Set
    End Property

    Public Property Number() As Integer
        Get
            Return _number
        End Get
        Set(ByVal Value As Integer)
            _number = Value
        End Set
    End Property
End Class

Public Class BaseFormatter : Implements IFormatProvider, ICustomFormatter

    Public Function GetFormat(ByVal format As Type) As Object Implements IFormatProvider.GetFormat
        If format.ToString() = GetType(ICustomFormatter).ToString() Then
            GetFormat = Me
        Else
            GetFormat = Nothing
        End If
    End Function

    Public Function Format(ByVal formatString As String, ByVal arg As Object, ByVal provider As IFormatProvider) As String Implements ICustomFormatter.Format
        If (formatString = Nothing) Then
            If TypeOf arg Is IFormattable Then
                Format = CType(arg, IFormattable).ToString(formatString, provider)
            Else
                Format = arg.ToString()
            End If
            Exit Function
        End If

        If Not formatString.StartsWith("B") Then
            If TypeOf arg Is IFormattable Then
                Format = CType(arg, IFormattable).ToString(formatString, provider)
            Else
                Format = arg.ToString()
            End If
            Exit Function
        End If

        formatString = formatString.Trim(New Char() {"B"})
        Dim b As Integer = Convert.ToInt32(formatString)
        Format = Convert.ToString(Convert.ToInt32(arg), b)
    End Function
End Class
