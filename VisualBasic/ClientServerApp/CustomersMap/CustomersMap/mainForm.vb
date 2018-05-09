Public Class mainForm
    Private Sub CustomersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CustomersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CustomersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CustomersDS)

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'CustomersDS.Customers' table. You can move, or remove it, as needed.
        Me.CustomersTableAdapter.Fill(Me.CustomersDS.Customers)

    End Sub

    Private Sub searchBtn_Click(sender As Object, e As EventArgs) Handles searchBtn.Click
        Try
            'grab user info for map
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty
            Dim country As String = String.Empty
            Dim addressQuery As String

            addressQuery &= "http://maps.google.com/maps?q="

            'build address from database
            If AddressTextBox.Text <> String.Empty Then
                street = AddressTextBox.Text.Replace(" ", "+")
                addressQuery &= street & "," & "+"
            End If
            If CityTextBox.Text <> String.Empty Then
                city = CityTextBox.Text.Replace(" ", "+")
                addressQuery &= city & "," & "+"
            End If
            If RegionTextBox.Text <> String.Empty Then
                state = RegionTextBox.Text.Replace(" ", "+")
                addressQuery &= state & "," & "+"
            End If
            If PostalCodeTextBox.Text <> String.Empty Then
                zip = PostalCodeTextBox.Text.Replace(" ", "+")
                addressQuery &= zip & "," & "+"
            End If
            If CountryTextBox.Text <> String.Empty Then
                country = CountryTextBox.Text.Replace(" ", "+")
                addressQuery &= country & "," & "+"
            End If

            WebBrowser1.Navigate(addressQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to retrieve map")
        End Try
    End Sub
End Class
