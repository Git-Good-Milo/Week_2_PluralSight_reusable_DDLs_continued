Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel1
    Inherits ViewModelBase

    Sub New()
        LoadProduct(680)
    End Sub

    Public Property Entity As Product

    Function LoadProduct(ByVal productID As Integer) As Product
        Return LoadProduct(productID, Nothing)
    End Function

    Function LoadProduct(ByVal produtID As Integer, ByVal startingFilePath As String) As Product

        ' Hard code an entity
        Entity = New Product() With {
            .ProductID = 680,
            .Name = "l Rad Frame - black, 58",
            .ProductNumber = "FR-R92B-58",
            .Color = "Black",
            .Size = "58",
            .Weight = 1016.04D,
            .StandardCost = 1059.31D
        }

        Return Entity
    End Function

End Class
