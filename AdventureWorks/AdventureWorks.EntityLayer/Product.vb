Imports Common.Library ' This import statement is only necissary if you dont import it fro My Project, References

Public Class Product
    ' This Product Class inherits from the CommonBase Class
    Inherits CommonBase

    ' This is how you can initialse variables with a constructor.
    ' By intialising you can set the default values for variables in a class.
    Sub New()
        StandardCost = 500
        ListPrice = 900
        SellStartDate = DateTime.Now
    End Sub

    Public Property ProductID As Integer
    Public Property Name As String
    Public Property ProductNumber As String
    Public Property Color As String
    Public Property ListPrice As Decimal
    Public Property StandardCost As Decimal
    Public Property Size As String
    Public Property Weight As Decimal
    Public Property SellStartDate As DateTime
    Public Property SellEndDate As DateTime

    Public ReadOnly Property NameAndNumber() As String
        ' This can be used when your property only needs to be read (Get) and not Set

        Get
            Return Name + "-" + ProductNumber
        End Get
    End Property

    ' This next fucntion demonstartes how to use a shared method
    Shared Function CalculateTheProfit(ByVal cost As Decimal, ByVal price As Decimal) As Decimal
        Return price - cost
        ' When this function is called, an instace of the class does not need to be made
        ' In this case we can simply add values to cost and price when we call the function
        ' ie, Product.CalculateTheProfit(900, 1400)
    End Function

    Function CalculateSellEndDate(ByVal days As Integer) As DateTime ' Functions have to have a datatype assgined to them unlike Sub qu
        ' This does not return a value, only performs some kind of operation 
        SellEndDate = SellStartDate.AddDays(days)

        Return SellEndDate
        ' Instead of using Return, you can assgin the ouptput you want to the name of the function
        ' ie, <CalculateSellEndDate = SellEndDate>
        ' This will provide the same output as the Return parameter
    End Function

    ' The folowing functions will be used to demonstarte Overloading methods

    Overloads Function CalculateProfit() As Decimal
        Return CalculateProfit(StandardCost)
    End Function

    Overloads Function CalculateProfit(ByVal newCost As Decimal)
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function



    'This Is a function to demonstarte optional methods
    Function CalculateProfit2(Optional ByVal newCost As Decimal = 0) As Decimal
        If newCost <> 0 Then
            StandardCost = newCost
        End If

        Return ListPrice - StandardCost
    End Function

    ' This function utilises inheritance from the CommonBase Class
    ' The overides keyword here allows us to reduce the amount of code we use by using MyBase.GetClassData
    ' This gets from the overridible function on CommonBase.
    ' The same is done on the Customer Class
    Protected Overrides Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Product ID: " + ProductID.ToString)
        sb.AppendLine("Product Name: " + Name)
        sb.AppendLine("Product Number: " + ProductNumber)
        sb.AppendLine(MyBase.GetClassData())

        Return sb.ToString()

    End Function

End Class
