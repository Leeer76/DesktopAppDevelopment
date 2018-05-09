Public Class mainForm
    Private Sub bdayButton_Click(sender As Object, e As EventArgs) Handles bdayButton.Click
        displayPictureBox.Image = bdayPictureBox.Image
        typeLabel.Text = "Birthday
"
    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()

    End Sub

    Private Sub weddingButton_Click(sender As Object, e As EventArgs) Handles weddingButton.Click
        displayPictureBox.Image = weddingPictureBox.Image
        typeLabel.Text = "Wedding
"
    End Sub
End Class
