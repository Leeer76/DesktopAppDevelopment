' Programmer: Erik Lee
' Date: Nov 16, 2016
' Program: Carla's Pizzeria
' Purpose: calculate order total

Option Explicit On
Option Infer Off
Option Strict On

Public Class pizzeriaForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click

        'calculate order total

        'declare variables
        Const MAMA As Decimal = 11.99D
        Const PAPA As Decimal = 12.99D
        Const VEGGIE As Decimal = 9.99D
        Const COUPOUN As Decimal = 3D
        Const MAMAGLUTEN As Decimal = 13.99D
        Const PAPAGLUTEN As Decimal = 14.99D
        Const VEGGIEGLUTEN As Decimal = 11.99D
        Const TAX As Double = 0.06
        Dim salesTax As Decimal
        Dim price As Decimal
        Dim mCarla As Integer
        Dim pGino As Integer
        Dim vClassic As Integer
        Dim mGluten As Integer
        Dim pGluten As Integer
        Dim vGluten As Integer
        Dim subtotal As Decimal

        'retreive user input
        Integer.TryParse(MamaTextBox.Text, mCarla)
        Integer.TryParse(mamaGlutenTextBox.Text, mGluten)
        Integer.TryParse(papaTextBox.Text, pGino)
        Integer.TryParse(papaGlutenTextBox.Text, pGluten)
        Integer.TryParse(classicTextBox.Text, vClassic)
        Integer.TryParse(veggieGlutenTextBox.Text, vGluten)

        'calcualte results
        subtotal = (mGluten * MAMAGLUTEN) + (pGluten * PAPAGLUTEN) + (vGluten * VEGGIEGLUTEN) + (mCarla * MAMA) + (pGino * PAPA) + (vClassic * VEGGIE)

        If mCarla > 0 OrElse mGluten > 0 OrElse pGluten > 0 OrElse pGino > 0 Then
            If couponCheckBox.Checked Then
                subtotal = (subtotal - COUPOUN)
                salesTax = Convert.ToDecimal(subtotal * TAX)
                price = subtotal + salesTax
            Else
                subtotal = subtotal
                salesTax = Convert.ToDecimal(subtotal * TAX)
                price = subtotal + salesTax
            End If
        Else
            subtotal = subtotal
            salesTax = Convert.ToDecimal(subtotal * TAX)
            price = subtotal + salesTax
        End If

        'display results
        taxOutPutLabel.Text = salesTax.ToString("c2")
        priceOutputLabel.Text = price.ToString("c2")

    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click

        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If

    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click

        'reset application
        MamaTextBox.Clear()
        mamaGlutenTextBox.Clear()
        papaTextBox.Clear()
        papaGlutenTextBox.Clear()
        veggieGlutenTextBox.Clear()
        classicTextBox.Clear()
        couponCheckBox.Checked = False
        taxOutPutLabel.Text = String.Empty
        priceOutputLabel.Text = String.Empty
        MamaTextBox.Focus()

    End Sub

End Class
