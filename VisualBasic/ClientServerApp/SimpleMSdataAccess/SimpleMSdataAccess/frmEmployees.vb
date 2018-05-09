Public Class frmEmployees
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub

    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Order_Details' table. You can move, or remove it, as needed.
        Me.Order_DetailsTableAdapter.Fill(Me._NwindTables_1_DataSet.Order_Details)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me._NwindTables_1_DataSet.Orders)
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me._NwindTables_1_DataSet.Employees)

    End Sub
End Class