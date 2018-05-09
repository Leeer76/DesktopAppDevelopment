' Project name:         Cable Solution
' Project purpose:      calculate the total due on a cable bill
' Created/revised by:   Erik Lee on Feb 13, 2017

Option Infer Off
Option Strict On
Option Explicit On

Public Class cableForm

    Private Function RESFUNCTION(ByVal processFee As Decimal, ByVal proccessPremiumFee As Decimal, ByVal basicFee As Decimal, ByRef channels As Integer) As Decimal
        'calculate results for residential total
        Return processFee + basicFee + (channels * proccessPremiumFee)

    End Function
    Private Function BUSFUNCTION(ByVal processFee As Decimal, ByVal proccessPremiumFee As Decimal, ByVal basicFee As Decimal, ByVal basicFee2 As Decimal, ByRef channels As Integer, ByRef connections As Integer) As Decimal
        'calculate results for business
        'declare variables
        Dim amount As Decimal
        Dim connect As Integer
        'calculate results
        If connections > 10 Then
            connect = 10 - connections
            amount = processFee + (channels * proccessPremiumFee) + basicFee + (connect * basicFee2)
        Else
            amount = processFee + (channels * proccessPremiumFee) + basicFee
        End If

        Return amount

    End Function

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub ValueChange(sender As Object, e As EventArgs) Handles premiumchannelsListBox.SelectedValueChanged, connectionsListBox.SelectedValueChanged, businessRadioButton.CheckedChanged, residentRadioButton.CheckedChanged
        'clear output upon selection change
        outPutLabel.Text = String.Empty

    End Sub

    Private Sub LoadValues(sender As Object, e As EventArgs) Handles MyBase.Load
        'load values for the list boxes

        'load channels box
        For channels As Integer = 0 To 10
            premiumchannelsListBox.Items.Add(channels)
        Next

        'load connections box
        For connections As Integer = 1 To 20
            connectionsListBox.Items.Add(connections)
        Next
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'calculate  the total due for the cable bill

        'declare variables
        Const RESPROCESSFEE As Decimal = 4.5D
        Const RESBASICFEE As Decimal = 30
        Const RESPREMIUMFEE As Decimal = 5
        Const BUSPROCESSFEE As Decimal = 16.5D
        Const BUSBASICFEE As Decimal = 80
        Const BUSBASICFEE2 As Decimal = 4
        Const BUSPREMIUMFEE As Decimal = 50
        Dim premiumChannels As Integer
        Dim connections As Integer
        Dim totalDue As Decimal

        'retriver user input
        Integer.TryParse(premiumchannelsListBox.Text, premiumChannels)
        Integer.TryParse(connectionsListBox.Text, connections)

        'calculate results
        If residentRadioButton.Checked Then
            totalDue = RESFUNCTION(RESPROCESSFEE, RESPREMIUMFEE, RESBASICFEE, premiumChannels)
        ElseIf businessRadioButton.Checked Then
            totalDue = BUSFUNCTION(BUSPROCESSFEE, BUSPREMIUMFEE, BUSBASICFEE, BUSBASICFEE2, premiumChannels, connections)
        End If

        'display results
        outPutLabel.Text = totalDue.ToString("c2")

    End Sub
End Class
