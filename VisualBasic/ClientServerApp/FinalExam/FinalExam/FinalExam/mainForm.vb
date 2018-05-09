Public Class mainForm
    Public intX As Integer
    Public intY As Integer

    Private Sub frmFinal_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        intX = e.X
        intY = e.Y

    End Sub

    Private Sub frmFinal_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Me.Left += e.X - intX
            Me.Top += e.Y - intY
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim tabsForm As New tabsForm

        tabsForm.Show()
        Me.Hide()
    End Sub
End Class
