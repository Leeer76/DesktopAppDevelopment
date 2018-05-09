' Programmer: Erik Lee
' Date: Dec 13, 2016
' Program: Slot Machine Project
' Purpose: Simulates a slot machine

Option Explicit On
Option Infer Off
Option Strict On

Public Class slotForm
    Dim counter As Integer = 0

    Private Sub clickHereButton_Click(sender As Object, e As EventArgs) Handles clickHereButton.Click

        ' simulates a slot machine
        'declare variables
        Dim randGen As New Random
        Dim leftIndex As Integer
        Dim centerIndex As Integer
        Dim rightIndex As Integer

        'enact spin
        clickHereButton.Enabled = False
        spinsLabel.Text = String.Empty

        For spins As Integer = 1 To 10
            leftIndex = randGen.Next(0, 6)
            leftPictureBox.Image =
                ImageList1.Images.Item(leftIndex)
            Me.Refresh()
            System.Threading.Thread.Sleep(20)

            centerIndex = randGen.Next(0, 6)
            centerPictureBox.Image =
                ImageList1.Images.Item(centerIndex)
            Me.Refresh()
            System.Threading.Thread.Sleep(20)

            rightIndex = randGen.Next(0, 6)
            rightPictureBox.Image =
                ImageList1.Images.Item(rightIndex)
            Me.Refresh()
            System.Threading.Thread.Sleep(20)
        Next spins

        counter += 1


        If leftIndex = centerIndex AndAlso leftIndex = rightIndex Then
            MessageBox.Show("Congratulations!", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information)
            spinsLabel.Text = "Spins: " & counter
            counter = 0
        End If



        clickHereButton.Enabled = True
        clickHereButton.Focus()


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If

    End Sub
End Class
