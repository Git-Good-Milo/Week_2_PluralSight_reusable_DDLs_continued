Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class CustomerViewModel
    Inherits ViewModelBase

    Sub New()
        LoadCustomer(1)
    End Sub

    Public Property Entity As Customer

    Function LoadCustomer(ByVal customerID As Integer) As Customer

        ' Hard code entity
        Entity = New Customer() With {
            .CustomerID = 1,
            .FirstName = "Bruce",
            .LastName = "Jones",
            .CompanyName = "Beach Computer Consultants"
        }

        Return Entity
    End Function

End Class
