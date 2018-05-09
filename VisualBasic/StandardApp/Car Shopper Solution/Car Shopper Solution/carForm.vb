' Project name:         Car Shopper Solution
' Project purpose:      calculate the payment of dealer rate vs. bank rate
' Created/revised by:   Erik Lee on Feb 8, 2017

Option Infer Off
Option Strict On
Option Explicit On

Public Class carForm

    Private Function BANKPAYMENT(ByRef price As Decimal) As Decimal
        'calculate bank payment

        'declare varables
        Dim rate As Decimal
        Dim year As Integer
        Dim month As Integer
        Dim monthlyinterest As Decimal
        Dim monthlypayment As Decimal

        'retrive user input
        Decimal.TryParse(bankRateComboBox.Text, rate)
        Integer.TryParse(termComboBox.Text, year)

        'calculate results
        monthlyinterest = rate / 12 / 100
        month = year * 12
        monthlypayment = Convert.ToDecimal(Financial.Pmt(monthlyinterest, month, -price))
        Return monthlypayment
    End Function

    Private Function DEALERPAYMENT(ByRef price As Decimal) As Decimal
        'calculate dealer payment

        'declare varables
        Dim rate As Decimal
        Dim year As Integer
        Dim month As Integer
        Dim monthlyinterest As Decimal
        Dim monthlypayment As Decimal

        'retrive user input
        Decimal.TryParse(dealerRateComboBox.Text, rate)
        Integer.TryParse(termComboBox.Text, year)

        'calculate results
        monthlyinterest = rate / 12 / 100
        month = year * 12
        monthlypayment = Convert.ToDecimal(Financial.Pmt(monthlyinterest, month, -price))
        Return monthlypayment
    End Function

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub LockKeys(sender As Object, e As KeyPressEventArgs) Handles priceTextBox.KeyPress, rebateTextBox.KeyPress, termComboBox.KeyPress, bankRateComboBox.KeyPress, dealerRateComboBox.KeyPress
        'only allow numbers to be entered
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        'reset application
        dealerOutPutLabel.Text = String.Empty
        bankOutPutLabel.Text = String.Empty
        priceTextBox.Clear()
        rebateTextBox.Clear()
        bankRateComboBox.SelectedIndex = -1
        dealerRateComboBox.SelectedIndex = -1
        termComboBox.SelectedIndex = -1
        priceTextBox.Focus()

    End Sub

    Private Sub SelectText(sender As Object, e As EventArgs) Handles priceTextBox.Enter, rebateTextBox.Enter
        'selects text on current field
        Dim thisTextBox As TextBox
        thisTextBox = TryCast(sender, TextBox)
        thisTextBox.SelectAll()

    End Sub

    Private Sub LoadValues(sender As Object, e As EventArgs) Handles MyBase.Load
        'load the comboboxes with numbers
        Dim years As Integer = 6
        Dim dealerRate As Integer = 12
        Dim bankRate As Integer = 12

        For variable As Integer = 1 To years
            termComboBox.Items.Add(variable)
        Next

        For variable2 As Double = 3 To dealerRate Step 0.25
            dealerRateComboBox.Items.Add(variable2.ToString("n2"))
        Next

        For variable3 As Double = 3 To bankRate Step 0.25
            bankRateComboBox.Items.Add(variable3.ToString("n2"))
        Next

    End Sub

    Private Sub TextChange(sender As Object, e As EventArgs) Handles termComboBox.SelectedIndexChanged, bankRateComboBox.SelectedIndexChanged, dealerRateComboBox.SelectedIndexChanged, priceTextBox.TextChanged, rebateTextBox.TextChanged
        'clear output values upon change
        dealerOutPutLabel.Text = String.Empty
        bankOutPutLabel.Text = String.Empty

    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculate payments for both

        'declare variables
        Dim price As Decimal
        Dim rebate As Decimal
        Dim loanAmount As Decimal
        Dim bankPay As Decimal
        Dim dealerPay As Decimal

        'retrieve user input
        Decimal.TryParse(priceTextBox.Text, price)
        Decimal.TryParse(rebateTextBox.Text, rebate)

        'calculate results
        If priceTextBox.Text = String.Empty OrElse (priceTextBox.Text = String.Empty AndAlso rebateTextBox.Text = String.Empty = False) OrElse bankRateComboBox.Text = String.Empty OrElse
            dealerRateComboBox.Text = String.Empty OrElse termComboBox.Text = String.Empty Then
            MessageBox.Show("Please enter all values", "Missing info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rebateTextBox.Clear()
            priceTextBox.Focus()
        ElseIf price <= rebate Then
            MessageBox.Show("Rebate can not be larger than price", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            rebateTextBox.Clear()
            priceTextBox.Focus()
        Else
            loanAmount = price - rebate
            bankPay = BANKPAYMENT(loanAmount)
            dealerPay = DEALERPAYMENT(loanAmount)
            'display results
            bankOutPutLabel.Text = bankPay.ToString("c2")
            dealerOutPutLabel.Text = dealerPay.ToString("c2")
        End If

    End Sub
End Class
