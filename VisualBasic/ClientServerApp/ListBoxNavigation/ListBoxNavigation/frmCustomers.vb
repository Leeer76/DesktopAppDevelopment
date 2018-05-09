Public Class frmCustomers
    Private Sub frmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNorthwind.CustomerList' table. You can move, or remove it, as needed.
        Me.CustomerListTableAdapter.Fill(Me.DsNorthwind.CustomerList)

        'automagically (nice wording Trey) select the first item in the list
        Me.lstCustomers.SelectedIndex = 0

        'fill the customers dataset (as if the user had clicked the first item)
        Me.CustomersTableAdapter.Fill(Me.DsNorthwind.Customers, Me.lstCustomers.SelectedValue.ToString())

    End Sub

    Private Sub lstCustomers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCustomers.SelectedIndexChanged
        'ensure user actually clicked on something
        If Me.lstCustomers.SelectedIndex >= 0 Then
            'fill textboxes with record user clicked on
            Me.CustomersTableAdapter.Fill(Me.DsNorthwind.Customers, Me.lstCustomers.SelectedValue)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'use input box to get search string from user
        Dim strSearch As String
        strSearch = InputBox("Enter your search criteria", "Company Name", "name goes here")

        'fill list box with matches from the users entry
        Me.CustomerListTableAdapter.FILLLikeCompany(Me.DsNorthwind.CustomerList, strSearch)

        'fill text boxes with selected company info
        If Me.lstCustomers.SelectedIndex >= 0 Then
            Me.CustomersTableAdapter.Fill(Me.DsNorthwind.Customers, Me.lstCustomers.SelectedValue)
        Else
            'if no results were found, loop through all the controls on the form
            For Each c In Me.Controls
                'if control is text clear it
                If TypeOf (c) Is TextBox Then
                    DirectCast(c, TextBox).Text = ""
                End If
            Next

            'no results found let user know
            Me.txtCompanyName.Text = "No results found"
            MessageBox.Show("No results found")

            'search again if no results
            If Me.txtContactName.Text = "" Then
                btnSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'update values in database
            Me.CustomersTableAdapter.Update(Me.txtCompanyName.Text, Me.txtContactName.Text, Me.txtContact.Text, Me.txtAddress.Text, Me.txtCity.Text, Me.txtState.Text, Me.txtZip.Text, Me.lstCustomers.SelectedValue)

            'annoy the user
            MessageBox.Show("Your changes are saved", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            'error message
            MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            'pop messagebox asking for custID
            Dim strCustID As String = InputBox("Enter ne Customer ID", "New Record")

            'insert new customer id into database
            Me.CustomersTableAdapter.Insert(strCustID)

            'refresh list box
            Me.CustomerListTableAdapter.Fill(Me.DsNorthwind.CustomerList)

            'select new customer in list box
            Me.lstCustomers.SelectedIndex = Me.lstCustomers.FindStringExact(strCustID)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'question users choice
            If MessageBox.Show("This record will be permanently deleted, Are you sure?", "Delete Record?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                'delete record from database
                Me.CustomersTableAdapter.Delete(Me.lstCustomers.SelectedValue)
                'annoy user
                MessageBox.Show("Record was deleted", "Delete Success!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'refresh list box
                Me.CustomerListTableAdapter.Fill(Me.DsNorthwind.CustomerList)

                'select first record in list box
                Me.lstCustomers.SelectedIndex = 0

                'fill textboxes
                Me.CustomersTableAdapter.Fill(Me.DsNorthwind.Customers, Me.lstCustomers.SelectedValue)

            End If
        Catch ex As Exception
            'error message
            MessageBox.Show(ex.Message, "Delete Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtZip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtZip.KeyPress
        'get max numbe characters from database
        Dim intMax As Integer = Me.DsNorthwind.Tables("customers").Columns("PostalCode").MaxLength

        'only allow max number of characters
        If Me.txtZip.Text.Length >= intMax AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only " & intMax & " characters are allowed", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub
End Class
