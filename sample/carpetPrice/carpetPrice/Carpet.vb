Public Class Carpet
    Private strColor As String  ' To hold the color
    Private strStyle As String  ' To hold the style
    Private decPrice As Decimal ' To hold the price

    ' Constructor
    Public Sub New()
        strColor = String.Empty
        strStyle = String.Empty
        decPrice = 0D
    End Sub

    ' Color property
    Public Property Color As String
        Get
            Return strColor
        End Get
        Set(ByVal value As String)
            strColor = value
        End Set
    End Property

    ' Style property
    Public Property Style As String
        Get
            Return strStyle
        End Get
        Set(ByVal value As String)
            strStyle = value
        End Set
    End Property

    ' Price property
    Public Property Price As Decimal
        Get
            Return decPrice
        End Get
        Set(ByVal value As Decimal)
            decPrice = value
        End Set
    End Property
End Class
