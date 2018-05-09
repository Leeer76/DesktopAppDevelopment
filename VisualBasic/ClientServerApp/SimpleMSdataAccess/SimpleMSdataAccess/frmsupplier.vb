Public Class frmsupplier
    Private Sub SuppliersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SuppliersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SuppliersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub

    Private Sub frmsupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Products' table. You can move, or remove it, as needed.
        Me.ProductsTableAdapter.Fill(Me._NwindTables_1_DataSet.Products)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Suppliers' table. You can move, or remove it, as needed.
        Me.SuppliersTableAdapter.Fill(Me._NwindTables_1_DataSet.Suppliers)

    End Sub

    Private Sub SuppliersBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles SuppliersBindingNavigator.RefreshItems

    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub CompanyNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CompanyNameTextBox.TextChanged

    End Sub

    Private Sub ContactNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactNameTextBox.TextChanged

    End Sub

    Private Sub ContactTitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles ContactTitleTextBox.TextChanged

    End Sub

    Private Sub AddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles AddressTextBox.TextChanged

    End Sub

    Private Sub SupplierIDTextBox_TextChanged(sender As Object, e As EventArgs) Handles SupplierIDTextBox.TextChanged

    End Sub

    Private Sub RegionTextBox_TextChanged(sender As Object, e As EventArgs) Handles RegionTextBox.TextChanged

    End Sub

    Private Sub PostalCodeTextBox_TextChanged(sender As Object, e As EventArgs) Handles PostalCodeTextBox.TextChanged

    End Sub

    Private Sub CountryTextBox_TextChanged(sender As Object, e As EventArgs) Handles CountryTextBox.TextChanged

    End Sub

    Private Sub PhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles PhoneTextBox.TextChanged

    End Sub

    Private Sub FaxTextBox_TextChanged(sender As Object, e As EventArgs) Handles FaxTextBox.TextChanged

    End Sub

    Private Sub HomePageTextBox_TextChanged(sender As Object, e As EventArgs) Handles HomePageTextBox.TextChanged

    End Sub
End Class