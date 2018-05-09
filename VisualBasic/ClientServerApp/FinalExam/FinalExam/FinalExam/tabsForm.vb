Public Class tabsForm
    Public speaker As New SpeechSynthesizer

    Private Sub TitlesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TitlesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.PubsDataSet)

    End Sub

    Private Sub tabsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PubsDataSet.employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.PubsDataSet.employee)
        'TODO: This line of code loads data into the 'PubsDataSet.publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.PubsDataSet.publishers)
        'TODO: This line of code loads data into the 'PubsDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.PubsDataSet.authors)
        'TODO: This line of code loads data into the 'PubsDataSet.titles' table. You can move, or remove it, as needed.
        Me.TitlesTableAdapter.Fill(Me.PubsDataSet.titles)

        speaker.Rate = 2
        speaker.Volume = 100
        speaker.SelectVoiceByHints(VoiceGender.Female)


    End Sub

    Private Sub btnLocate_Click(sender As Object, e As EventArgs) Handles btnLocate.Click
        Try
            'grab user info for map
            Dim street As String = String.Empty
            Dim city As String = String.Empty
            Dim state As String = String.Empty
            Dim zip As String = String.Empty
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
            If StateTextBox.Text <> String.Empty Then
                state = StateTextBox.Text.Replace(" ", "+")
                addressQuery &= state & "," & "+"
            End If
            If ZipTextBox.Text <> String.Empty Then
                zip = ZipTextBox.Text.Replace(" ", "+")
                addressQuery &= zip & "," & "+"
            End If

            WebBrowser1.Navigate(addressQuery)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Unable to retrieve map")
        End Try
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        mainForm.Close()
    End Sub

    Private Sub btnTitle_Click(sender As Object, e As EventArgs) Handles btnTitle.Click
        speaker.Speak(TitleTextBox.Text & " is in the genre of " & TypeTextBox.Text & " and costs " & PriceTextBox.Text & " dollars. year to date sales are " & Ytd_salesTextBox.Text & ". notes on this book are " & NotesTextBox.Text & ". this book was published on " & PubdateDateTimePicker.Value)
    End Sub

    Private Sub btnAuthor_Click(sender As Object, e As EventArgs) Handles btnAuthor.Click
        speaker.Speak(Au_fnameTextBox.Text & " " & Au_lnameTextBox.Text & " is located at " & AddressTextBox.Text & " " & CityTextBox.Text & " " & StateTextBox.Text & " " & ZipTextBox.Text & ". you can contact them at " & PhoneTextBox.Text)
    End Sub

    Private Sub btnPub_Click(sender As Object, e As EventArgs) Handles btnPub.Click
        speaker.Speak(Pub_nameTextBox.Text & " is located in " & CityTextBox1.Text & " " & StateTextBox1.Text & " " & CountryTextBox.Text)
    End Sub

    Private Sub btnEmp_Click(sender As Object, e As EventArgs) Handles btnEmp.Click
        speaker.Speak(FnameTextBox.Text & " " & MinitTextBox.Text & " " & LnameTextBox.Text & " was hired on " & Hire_dateDateTimePicker.Value)
    End Sub

    Private Sub tabsForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        mainForm.Close()

    End Sub

    Private Sub tabsForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        speaker.Speak("Hello How can I be of service today?")
    End Sub
End Class