Public Class mainForm
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsNorthwinds)

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsNorthwinds.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.DsNorthwinds.Employees)

    End Sub

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        Try
            'grab user info to feed to google maps
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty
            Dim queryAddress As String

            queryAddress &= "http://maps.google.com/maps?q="

            'build stree part of query
            If AddressTextBox.Text <> String.Empty Then
                street = AddressTextBox.Text.Replace(" ", "+")
                queryAddress &= street & "," & "+"
            End If
            If CityTextBox.Text <> String.Empty Then
                city = CityTextBox.Text.Replace(" ", "+")
                queryAddress &= city & "," & "+"
            End If
            If RegionTextBox.Text <> String.Empty Then
                state = RegionTextBox.Text.Replace(" ", "+")
                queryAddress &= state & "," & "+"
            End If
            If PostalCodeTextBox.Text <> String.Empty Then
                zip = PostalCodeTextBox.Text.Replace(" ", "+")
                queryAddress &= zip & "," & "+"
            End If

            WebBrowser1.Navigate(queryAddress)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to retrieve map")
        End Try
    End Sub
End Class
