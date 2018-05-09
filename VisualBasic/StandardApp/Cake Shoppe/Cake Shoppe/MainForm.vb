' Programmer: Erik Lee
' Date: August 30, 2016
' Program: Cake Shoppe Application
' Purpose: Displays the cakes available at the Cake Shoppe

Public Class mainForm
    Private Sub bdayButton_Click(sender As Object, e As EventArgs) Handles bdayButton.Click

        'displays bday picture
        displayPictureBox.Image = bdayPictureBox.Image

        'display title
        Me.typeLabel.Text = "Birthday"

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Closes the Application
        Me.Close()

    End Sub

    Private Sub weddingButton_Click(sender As Object, e As EventArgs) Handles weddingButton.Click

        'displays wedding picture
        displayPictureBox.Image = weddingPictureBox.Image

        'display title
        Me.typeLabel.Text = "Wedding"

    End Sub
End Class
