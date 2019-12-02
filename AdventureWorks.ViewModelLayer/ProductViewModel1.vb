Imports System.Collections.ObjectModel
Imports AdventureWorks.DataLayer
Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel1
    Inherits ViewModelBase

    Sub New()
        LoadProducts()
    End Sub

    Public Property Products As ObservableCollection(Of Product)
    Public Property Entity As Product

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function


    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        ' Create a new instnace of the product manager class
        Dim mgr = New ProductManager

        Products = mgr.LoadProducts(startingFilePath)

        Return Products
    End Function

End Class
