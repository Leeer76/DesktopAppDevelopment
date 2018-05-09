Public Class FrmMain
    Private Sub BtnHello_Click(sender As Object, e As EventArgs) Handles BtnHello.Click
        'declare a form object
        Dim myForm As New FrmRun

        'modify hello label text on form 2
        myForm.LblHello.Text &= ", " & Me.txtName.Text

        'show new form (form 2)
        myForm.Show()
    End Sub
End Class
