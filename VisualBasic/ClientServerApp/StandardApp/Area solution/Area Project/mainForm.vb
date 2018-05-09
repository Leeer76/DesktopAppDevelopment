' Programmer: Erik Lee
' Date: Sept 1, 2016
' Program: Area Formulas
' Purpose: Display the area formulas

Public Class mainForm
    Private Sub circleButton_Click(sender As Object, e As EventArgs) Handles circleButton.Click

        'display formula for circle
        formulaLabel.Text = "Area = π × r(sq)"

        'displays image of circle
        displayPictureBox.Image = circlePictureBox.Image


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        'exit application
        Me.Close()

    End Sub

    Private Sub paralleButton_Click(sender As Object, e As EventArgs) Handles paralleButton.Click

        'display formula for parallelogram
        formulaLabel.Text = "Area = b × h"

        'display image of parallelogram
        displayPictureBox.Image = parallePictureBox.Image

    End Sub

    Private Sub rectangleButton_Click(sender As Object, e As EventArgs) Handles rectangleButton.Click

        'display formula for rectangle
        formulaLabel.Text = "Area = w × h"

        'display image of rectangle
        displayPictureBox.Image = rectanglePictureBox.Image

    End Sub

    Private Sub triangleButton_Click(sender As Object, e As EventArgs) Handles triangleButton.Click

        'display formula for triangle
        formulaLabel.Text = "Area = ½ × b × h"

        'display image of triangle
        displayPictureBox.Image = trianglePictureBox.Image

    End Sub
End Class
