Imports System.Collections.ObjectModel
Imports System.Configuration
Imports AdventureWorks.EntityLayer
Imports Common.Library


Public Class ProductManager
    Inherits DataManagerBase

    Function LoadProducts() As ObservableCollection(Of Product)
        Return LoadProducts(Nothing)
    End Function

    Function LoadProducts(ByVal startingFilePath As String) As ObservableCollection(Of Product)
        ' Create a new instance of products
        Dim ret = New ObservableCollection(Of Product)()

        Try
            ' Attempt to read from XML file
            Dim doc = MyBase.LoadXElement(
                ConfigurationManager.AppSettings("ProductsFile"),
                startingFilePath)

            Dim products = From prod In doc.<Product>
                           Select New Product With {
                               .ProductID = Convert.ToInt32(prod.Element("ProductID").Value),
                               .Name = prod.Element("Name").Value,
                               .ProductNumber = prod.Element("ProductNumber").Value,
                               .Color = prod.Element("Colour").Value,
                               .Weight = Convert.ToDecimal(prod.Element("Weight").Value),
                               .StandardCost = Convert.ToDecimal(prod.Element("StandardCost").Value),
                               .SellStartDate = Convert.ToDateTime(prod.Element("SellStartDate").Value),
                               .SellEndDate = Convert.ToDateTime(prod.Element("SellEndDate").Value)
                           }


            ret = New ObservableCollection(Of Product)(products.ToList)
        Catch ex As Exception
            System.Diagnostics.Debug.WriteLine(ex.ToString())

        End Try

        Return ret
    End Function

End Class
