Public Class mainForm
    Private Sub txtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        'check if it's a number or control number or period
        If Char.IsNumber(e.KeyChar) OrElse Char.IsControl(e.KeyChar) OrElse Char.IsPunctuation(e.KeyChar) Then
            'get out - don't do anything
            Exit Sub
        Else
            'annoy user
            MessageBox.Show("Only numbers are allowed silly", "Numeric Field", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If

    End Sub
End Class
