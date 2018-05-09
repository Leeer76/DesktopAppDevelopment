Public Class ProductsListForm
    'global variables
    Public speak As New SpeechSynthesizer

    Private Sub ProductsListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set speak settings
        speak.Rate = 1
        speak.Volume = 100
        speak.SelectVoiceByHints(VoiceGender.Female)
        'TODO: This line of code loads data into the 'ProductsListBox_DataSet.ProductsList' table. You can move, or remove it, as needed.
        Me.ProductsListTableAdapter.Fill(Me.ProductsListBox_DataSet.ProductsList)

        'auto select first item in list
        Me.ProductListBox.SelectedIndex = 0

        'fill products data set
        Me.ProductsTableAdapter.Fill(Me.ProductsListBox_DataSet.Products, Me.ProductListBox.SelectedValue.ToString())

    End Sub

    Private Sub ProductListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductListBox.SelectedIndexChanged
        'ensure user actually clicked on something
        If Me.ProductListBox.SelectedIndex >= 0 Then
            'fill textboxes with record user clicked on
            Me.ProductsTableAdapter.Fill(Me.ProductsListBox_DataSet.Products, Me.ProductListBox.SelectedValue)
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'use input box to get user input
        Dim strSearch As String
        strSearch = InputBox("Enter your search criteria", "Product Name", "Enter your search here")

        'fill list box with matches
        Me.ProductsListTableAdapter.FillLikeProductName(Me.ProductsListBox_DataSet.ProductsList, strSearch)

        'fill text boxes with selected company info
        If Me.ProductListBox.SelectedIndex >= 0 Then
            Me.ProductsTableAdapter.Fill(Me.ProductsListBox_DataSet.Products, Me.ProductListBox.SelectedValue)
        Else
            'if no result loop through controls on form
            For Each p In Me.Controls
                'if control is txt, clear it
                If TypeOf (p) Is TextBox Then
                    DirectCast(p, TextBox).Text = ""
                End If
            Next
            'no results found let user know
            Me.txtProductName.Text = "No results found"
            MessageBox.Show("No results found")

            'search results again
            If Me.txtSupplier.Text = "" Then
                btnSearch.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            'update items
            ProductsTableAdapter.Update(Me.txtProductName.Text, Me.txtSupplier.Text, Me.txtCategory.Text, Me.txtQtyUnit.Text, Me.txtUnitPrice.Text, Me.txtUnitStock.Text, Me.txtUnitOrder.Text, Me.txtReorderLevel.Text, Me.ProductListBox.SelectedValue)

            'confirm changes
            MessageBox.Show("Your changes have been saved", "Changes Sucessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Changes", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            'get users product name
            Dim strProdName As String = InputBox("Enter new Product name", "New Record")

            'insert new product
            Me.ProductsTableAdapter.Insert(strProdName)

            'refresh list box
            Me.ProductsListTableAdapter.Fill(Me.ProductsListBox_DataSet.ProductsList)

            'try to get new product record
            Me.ProductListBox.SelectedIndex = Me.ProductListBox.Items.Count - 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Insert Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            'display message
            If MessageBox.Show("Are you sure you wan to delete this record? This will be permenant!", "Delete Record", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.OK Then
                Me.ProductsTableAdapter.Delete(Me.ProductListBox.SelectedValue)
                'annoy user with confirmation msg
                MessageBox.Show("Record was deleted", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'refresh list box
                Me.ProductsListTableAdapter.Fill(Me.ProductsListBox_DataSet.ProductsList)
                'select first record in list box
                Me.ProductListBox.SelectedIndex = 0
                'fill textboxes
                Me.ProductsTableAdapter.Fill(Me.ProductsListBox_DataSet.Products, Me.ProductListBox.SelectedValue)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Delete Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnProductName_Click(sender As Object, e As EventArgs) Handles btnProductName.Click
        speak.Speak(Label2.Text & txtProductName.Text)
    End Sub

    Private Sub btnSupplier_Click(sender As Object, e As EventArgs) Handles btnSupplier.Click
        speak.Speak(Label3.Text & txtSupplier.Text)
    End Sub

    Private Sub btnCategoryId_Click(sender As Object, e As EventArgs) Handles btnCategoryId.Click
        speak.Speak(Label4.Text & txtCategory.Text)
    End Sub

    Private Sub btnQtyUnit_Click(sender As Object, e As EventArgs) Handles btnQtyUnit.Click
        speak.Speak(Label5.Text & txtQtyUnit.Text)
    End Sub

    Private Sub btnUnitPrice_Click(sender As Object, e As EventArgs) Handles btnUnitPrice.Click
        speak.Speak(Label6.Text & txtUnitPrice.Text)
    End Sub

    Private Sub btnUnitStock_Click(sender As Object, e As EventArgs) Handles btnUnitStock.Click
        speak.Speak(Label7.Text & txtUnitStock.Text)
    End Sub

    Private Sub btnUnitsOrder_Click(sender As Object, e As EventArgs) Handles btnUnitsOrder.Click
        speak.Speak(Label8.Text & txtUnitOrder.Text)
    End Sub

    Private Sub btnReorderLevel_Click(sender As Object, e As EventArgs) Handles btnReorderLevel.Click
        speak.Speak(Label9.Text & txtReorderLevel.Text)
    End Sub

    Private Sub Units_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReorderLevel.KeyPress, txtUnitOrder.KeyPress, txtUnitPrice.KeyPress, txtUnitStock.KeyPress
        'check if it's a number or control or puncuation
        If Char.IsNumber(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar) Then
            'get out of sub
            Exit Sub
        Else
            MessageBox.Show("Only numbers or decimals may be entered in this field", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If

    End Sub
    Private Sub ids_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress, txtSupplier.KeyPress
        If Char.IsNumber(e.KeyChar) OrElse Char.IsControl(e.KeyChar) Then
            'get out of sub
            Exit Sub
        Else
            MessageBox.Show("Only numbers or decimals may be entered in this field", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub
    Private Sub MaxChar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress, txtSupplier.KeyPress, txtProductName.KeyPress, txtQtyUnit.KeyPress, txtReorderLevel.KeyPress, txtUnitOrder.KeyPress, txtUnitPrice.KeyPress, txtUnitStock.KeyPress
        'get max values for columns
        Dim maxCat As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("CategoryID").MaxLength
        Dim maxSupp As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("SupplierID").MaxLength
        Dim maxProdName As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("ProductName").MaxLength
        Dim maxQtyUnit As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("QuantityPerUnit").MaxLength
        Dim maxReor As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("ReorderLevel").MaxLength
        Dim maxUnitOrd As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("UnitsOnOrder").MaxLength
        Dim maxUnitPrice As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("UnitPrice").MaxLength
        Dim maxUnitStock As Integer = Me.ProductsListBox_DataSet.Tables("products").Columns("UnitsInStock").MaxLength

        'check that data entered in no more than allowed by database
        'If txtCategory.Text.Length >= maxCat AndAlso Not Char.IsControl(e.KeyChar) Then
        'MessageBox.Show("Only " & maxCat & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'e.Handled = True
        'End If
        'If txtSupplier.Text.Length >= maxSupp AndAlso Not Char.IsControl(e.KeyChar) Then
        'MessageBox.Show("Only " & maxSupp & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'e.Handled = True
        'End If
        If txtProductName.Text.Length >= maxProdName AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only " & maxProdName & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
        If txtQtyUnit.Text.Length >= maxQtyUnit AndAlso Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Only " & maxQtyUnit & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
        'If txtReorderLevel.Text.Length >= maxReor AndAlso Not Char.IsControl(e.KeyChar) Then
        'MessageBox.Show("Only " & maxReor & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'e.Handled = True
        'End If
        'If txtUnitOrder.Text.Length >= maxUnitOrd AndAlso Not Char.IsControl(e.KeyChar) Then
        'MessageBox.Show("Only " & maxUnitOrd & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'e.Handled = True
        'End If
        'If txtUnitPrice.Text.Length >= maxUnitPrice AndAlso Not Char.IsControl(e.KeyChar) Then
        'MessageBox.Show("Only " & maxUnitPrice & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'e.Handled = True
        'End If
        'If txtUnitStock.Text.Length >= maxUnitStock AndAlso Not Char.IsControl(e.KeyChar) Then
        'MessageBox.Show("Only " & maxUnitStock & " characters can be entered", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'e.Handled = True
        'End If

    End Sub
End Class
