' Programmer: Erik Lee
' Date: Dec 6, 2016
' Program: Auto Loan Calculator
' Purpose: Display payment options for payment

Option Explicit On
Option Infer Off
Option Strict On

Public Class autoForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        'display payment options for payment
        'declare variables
        Dim principle As Decimal
        Dim downPayment As Decimal
        Dim interest As Decimal
        Dim loanAmount As Decimal
        Dim monthlyPayment As Decimal
        Dim year As Integer = 2
        Dim monthlyInterest As Decimal
        Dim month As Integer
        Dim output As String

        'retreive user input
        Decimal.TryParse(principleTextBox.Text, principle)
        Decimal.TryParse(downTextBox.Text, downPayment)
        Decimal.TryParse(interestTextBox.Text, interest)
        output = "Months" & ControlChars.Tab & "Monthly payment" & ControlChars.Tab & ControlChars.NewLine
        'calculate results
        loanAmount = principle - downPayment
        monthlyInterest = interest / 12 / 100

        For year = 10 To 25 Step 5
            month = year * 12

            monthlyPayment = Convert.ToDecimal(Financial.Pmt(monthlyInterest, month, -loanAmount))
            output &= ControlChars.NewLine & month & ControlChars.Tab & monthlyPayment.ToString("c2") & ControlChars.Tab & ControlChars.Tab

        Next year

        'display results
        paymentTextBox.Text = output


    End Sub
End Class
