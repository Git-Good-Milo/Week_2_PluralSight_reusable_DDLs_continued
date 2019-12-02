Imports AdventureWorks.ViewModelLayer

Public Class ProductDetailControl

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _viewModel = DirectCast(Me.Resources("viewmodel"), ProductViewModel1)
    End Sub

    Private _viewmodel As ProductViewModel1
    Private Sub UserControl_Loaded(sender As Object, e As RoutedEventArgs)
        _viewmodel.LoadProducts(706)
    End Sub
End Class
