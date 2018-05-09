Public Class mainForm
    Private Sub BtnCategories_Click(sender As Object, e As EventArgs) Handles BtnCategories.Click
        Dim myCat As New frmCategories
        myCat.Show()
    End Sub

    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Dim myCust As New frmCustomers
        myCust.Show()
    End Sub

    Private Sub BtnEmployees_Click(sender As Object, e As EventArgs) Handles BtnEmployees.Click
        Dim myEmployee As New frmEmployees
        myEmployee.Show()
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        Dim mySupplier As New frmsupplier
        mySupplier.Show()
    End Sub
End Class
