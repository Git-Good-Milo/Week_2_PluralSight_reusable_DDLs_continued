Imports Common.Library

Public Class Customer
    Inherits CommonBase

    Sub New()
        MyBase.New() ' This Allows us to use the Sub New from the Inherited Class, Common Base

        CustomerID = 1
    End Sub

    Public Property CustomerID As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property CompanyName As String

    Protected Overrides Function GetClassData() As String
        Dim sb As New Text.StringBuilder(1024)

        sb.AppendLine("Customer ID: " + CustomerID.ToString)
        sb.AppendLine("CompanyName Name: " + CompanyName)
        sb.AppendLine("First Name: " + FirstName)
        sb.AppendLine("Last Name: " + LastName)
        sb.AppendLine(MyBase.GetClassData())

        Return sb.ToString()

    End Function

End Class
