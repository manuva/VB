Public Class clsRectangle

    'Inherits Carpet
    Private dblWidth As Double 'for width
    Private dblLength As Double 'for length
    Private dblArea As Double 'for area
    'Private dblTotalCost As Double


    'Constructor
    Public Sub New()
        dblWidth = 0
        dblLength = 0
        dblArea = 0
    End Sub

    Public Property Width() As Double 'width property
        Get
            Return dblWidth
        End Get
        Set(ByVal value As Double)
            dblWidth = value
        End Set

    End Property

    Public Property Length() As Double 'length property
        Get
            Return dblLength
        End Get
        Set(ByVal value As Double)
            dblLength = value
        End Set

    End Property

    Public Property Area() As Double 'area property
        Get
            Return dblArea
        End Get
        Set(ByVal value As Double)
            dblArea = value
        End Set
    End Property
    'function to calculate area
    Public Function CalcArea(ByVal vdblLength As Double, ByVal vdblWidth As Double) As Single
        CalcArea = CSng((vdblLength * vdblWidth))
    End Function
    'function to calculate total cost
    Public Function CalcTotal(ByVal vdblPrice As Double, ByVal vdblArea As Double) As Decimal
        CalcTotal = CDec(vdblArea * vdblPrice)
    End Function

End Class
