Option Explicit On
Option Strict On
Option Infer Off

Public Class barclayForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        'list prices and calculate total
        'clear data
        pricesListBox.Items.Clear()
        outPutLabel.Text = String.Empty

        'declare variables
        Const PROMPT As String = "Please enter prices. Click cancel to end."
        Dim prices As Decimal
        Dim inputPrices As String
        Dim total As Decimal
        Dim totalPrices As Integer

        'calcualte results
        inputPrices = InputBox(PROMPT)

        Do While inputPrices <> String.Empty
            pricesListBox.Items.Add(inputPrices.ToString)

            Decimal.TryParse(inputPrices, prices)
            totalPrices += 1
            total += prices

            inputPrices = InputBox(PROMPT)
        Loop

        'display results
        outPutLabel.Text = total.ToString("c2")


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
