' Project name:         Carpet Sales Price Calculator
' Project purpose:      calculate the square feet, linear feet, and pricing of carpet per the users input
' Created/revised by:   Erik Lee on Apr 7, 2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class mainForm
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub DelivryCheckLoad(sender As Object, e As EventArgs) Handles yesDeliveryRadioButton.CheckedChanged
        'enables delivery options

        If yesDeliveryRadioButton.Checked = True Then
            deliveryComboBox.Enabled = True
            deliveryComboBox.SelectedIndex = 0
        Else
            deliveryComboBox.Enabled = False
        End If
    End Sub

    Private Sub TextchangeEvent(sender As Object, e As EventArgs) Handles widthTextBox.TextChanged, lengthTextBox.TextChanged, foamRadioButton.CheckedChanged, standardRadioButton.CheckedChanged, urethaneRadioButton.CheckedChanged, juteRadioButton.CheckedChanged, basicRadioButton.CheckedChanged, primeRadioButton.CheckedChanged, yesDeliveryRadioButton.CheckedChanged, noDeliveryRadioButton.CheckedChanged, yesScotchRadioButton.CheckedChanged, noScotchRadioButton1.CheckedChanged, deliveryComboBox.SelectedIndexChanged
        'clears output upon change
        outputListBox.Items.Clear()
    End Sub

    Private Sub SelectAllText(sender As Object, e As EventArgs) Handles lengthTextBox.Enter, widthTextBox.Enter
        'selects all text
        lengthTextBox.SelectAll()
        widthTextBox.SelectAll()
    End Sub

    Private Sub KeyPressLock(sender As Object, e As KeyPressEventArgs) Handles widthTextBox.KeyPress, lengthTextBox.KeyPress
        'only allow numbers to be entered
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        ' calculate the cost and footage of the users entry
        'declare variables

        Dim width As Double
        Dim length As Double
        Dim squareFeet As Double
        Dim linearFeet As Double
        Dim squrePrice As Decimal
        Dim basePrice As Decimal
        Dim deliveryCost As Decimal
        Dim scotchgard As Decimal
        Dim total As Decimal

        outputListBox.Items.Clear()
        'retrieve user input
        Double.TryParse(lengthTextBox.Text, length)
        Double.TryParse(widthTextBox.Text, width)

        'calculate results
        If length = 0 OrElse width = 0 Then
            MessageBox.Show("Please enter dimensions", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lengthTextBox.Focus()
            outputListBox.Items.Clear()
        Else

            If yesDeliveryRadioButton.Checked And deliveryComboBox.SelectedIndex = -1 Then
                MessageBox.Show("Please select a delivery option", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                deliveryComboBox.Focus()
            Else
                squareFeet = length * width
                linearFeet = squareFeet / 12
                'find square price
                squrePrice = squreFeetPrice()
                basePrice = squrePrice * Convert.ToDecimal(squareFeet)
                deliveryCost = DeliveryFee(basePrice)

                If yesScotchRadioButton.Checked Then
                    scotchgard = Convert.ToDecimal(0.07 * squareFeet)
                Else
                    scotchgard = 0
                End If
                total = basePrice + deliveryCost + scotchgard

                'display results
                outputListBox.Items.Add("Total Square Feet:" & ControlChars.Tab & ControlChars.Tab & squareFeet.ToString("n0"))
                outputListBox.Items.Add("Total Linear Feet:" & ControlChars.Tab & ControlChars.Tab & linearFeet.ToString("n2"))
                outputListBox.Items.Add("Unit Price:" & ControlChars.Tab & ControlChars.Tab & squrePrice.ToString("c2"))
                outputListBox.Items.Add("Base Price:" & ControlChars.Tab & ControlChars.Tab & basePrice.ToString("c2"))
                outputListBox.Items.Add("Delivery Fee:" & ControlChars.Tab & ControlChars.Tab & deliveryCost.ToString("c2"))
                outputListBox.Items.Add("Scotchguard Fee:" & ControlChars.Tab & ControlChars.Tab & scotchgard.ToString("c2"))
                outputListBox.Items.Add("Subtotal:" & ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & total.ToString("c2"))
            End If
        End If




    End Sub

    Private Function squreFeetPrice() As Decimal
        'declare variables
        Dim foamPriceing() As Double = {0.59, 0.69, 0.79}
        Dim urethanePricing() As Double = {0.89, 0.99, 1.09}
        Dim jutePricing() As Double = {1.19, 1.29, 1.39}
        Dim squarePrice As Decimal
        'find square price
        If foamRadioButton.Checked AndAlso basicRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(foamPriceing(0))
        ElseIf foamRadioButton.Checked AndAlso standardRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(foamPriceing(1))
        ElseIf foamRadioButton.Checked AndAlso primeRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(foamPriceing(2))
        ElseIf urethaneRadioButton.Checked AndAlso basicRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(urethanePricing(0))
        ElseIf urethaneRadioButton.Checked AndAlso standardRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(urethanePricing(1))
        ElseIf urethaneRadioButton.Checked AndAlso primeRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(urethanePricing(2))
        ElseIf juteRadioButton.Checked AndAlso basicRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(jutePricing(0))
        ElseIf juteRadioButton.Checked AndAlso standardRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(jutePricing(1))
        ElseIf juteRadioButton.Checked AndAlso primeRadioButton.Checked Then
            squarePrice = Convert.ToDecimal(jutePricing(2))
        End If

        Return squarePrice
    End Function

    Private Function DeliveryFee(ByRef basefee As Decimal) As Decimal
        'calculate delivery fee
        'declare variable
        Dim fee As Decimal
        'retrive user input


        If deliveryComboBox.SelectedIndex = 0 AndAlso yesDeliveryRadioButton.Checked Then
            fee = 0
        ElseIf deliveryComboBox.SelectedIndex = 1 AndAlso yesDeliveryRadioButton.Checked Then
            fee = 10
        ElseIf deliveryComboBox.SelectedIndex = 2 AndAlso yesDeliveryRadioButton.Checked Then
            fee = 20
        ElseIf deliveryComboBox.SelectedIndex = 3 AndAlso yesDeliveryRadioButton.Checked Then
            If basefee * 0.2 < 20 Then
                fee = 20
            Else
                fee = Convert.ToDecimal(0.2) * basefee
            End If

        Else
            fee = 0
        End If

        Return fee
    End Function
End Class
