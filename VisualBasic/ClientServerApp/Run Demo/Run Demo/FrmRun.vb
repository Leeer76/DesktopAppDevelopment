Public Class FrmRun
    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles BtnCalc.Click
        'run windows calculator
        Process.Start("calc.exe")
    End Sub

    Private Sub mnuRun_Click(sender As Object, e As EventArgs) Handles mnuRun.Click
        'run notepad
        Process.Start("notepad.exe")
    End Sub

    Private Sub mnuControl_Click(sender As Object, e As EventArgs) Handles mnuControl.Click
        'run control panel
        Process.Start("control.exe")
    End Sub
End Class