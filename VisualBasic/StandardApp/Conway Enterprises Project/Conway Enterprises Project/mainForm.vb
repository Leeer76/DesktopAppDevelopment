' Project name:         Conway Enterprises
' Project purpose:      calculate and display totals for domestic, internation, and grandtotal
' Created/revised by:   Erik Lee on Mar 20, 2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class mainForm
    'declare class-level variables
    Dim sales(,) As Decimal = {{100000, 150000},
                                    {90000, 120000},
                                    {75000, 210000},
                                    {88000, 50000},
                                    {125000, 220000},
                                    {63000, 80000}}
    Private Sub displayButton_Click(sender As Object, e As EventArgs) Handles displayButton.Click
        'calculate and dispaly sales
        'declare variables
        Dim highrow As Integer = sales.GetUpperBound(0)
        Dim domesticSold As Decimal
        Dim intsold As Decimal
        Dim grandTotal As Decimal

        'calculate results
        For row As Integer = 0 To highrow
            domesticSold += sales(row, 0)
            intsold += sales(row, 1)
        Next row

        For Each item As Integer In sales
            grandTotal += item
        Next

        domesticTotalLabel.Text = domesticSold.ToString("c0")
        intTotalLabel.Text = intsold.ToString("c0")
        grandTotalLabel.Text = grandTotal.ToString("c0")
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
