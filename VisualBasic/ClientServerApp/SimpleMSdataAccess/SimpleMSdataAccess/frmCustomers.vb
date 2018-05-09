Public Class frmCustomers
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub

    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me._NwindTables_1_DataSet.Customers)

    End Sub
End Class