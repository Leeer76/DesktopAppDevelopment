Public Class formMain
    Private Sub OrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles OrdersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.OrdersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub

    Private Sub formMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me._NwindTables_1_DataSet.Employees)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Shippers' table. You can move, or remove it, as needed.
        Me.ShippersTableAdapter.Fill(Me._NwindTables_1_DataSet.Shippers)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me._NwindTables_1_DataSet.Customers)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me._NwindTables_1_DataSet.Orders)

    End Sub

    Private Sub OrdersDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles OrdersDataGridView.MouseDoubleClick
        'declare instance of order details

        Dim myDetails As New frmOrdersDetails

        'pass current order id from the grid
        myDetails.intOrderID = Convert.ToInt32(Me.OrdersDataGridView.SelectedRows(0).Cells(0).Value)

        'display form
        myDetails.ShowDialog()

    End Sub
End Class
