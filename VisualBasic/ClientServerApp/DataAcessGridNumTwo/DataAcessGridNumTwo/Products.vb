Public Class Products
    Private Sub ProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub

    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me._NwindTables_1_DataSet.Categories)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me._NwindTables_1_DataSet.Suppliers)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me._NwindTables_1_DataSet.Products)

    End Sub

    Private Sub Products_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ProductsDataGridView.MouseDoubleClick
        'declare instance of product details
        Dim myDetails As New ProductDetails

        'pass current product id from the grid
        myDetails.intProductID = Convert.ToInt32(Me.ProductsDataGridView.SelectedRows(0).Cells(0).Value)

        myDetails.ShowDialog()
    End Sub
End Class
