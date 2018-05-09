' Project name:         Pig Latin Project
' Project purpose:      Translate word entered by user into pig latin
' Created/revised by:   Erik Lee on Apr 10, 2017

Option Strict On
Option Infer Off
Option Explicit On

Public Class mainForm
    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        'convert users word into pig latin
        'declare variables
        Const WAY As String = "way"
        Const AY As String = "ay"
        Dim userWord As String
        Dim outPut As String
        Dim index As Integer

        'retreive user input
        userWord = inPutTextBox.Text.ToLower
        'convert to pig latin
        If userWord = String.Empty Then
            MessageBox.Show("Please enter a word.", "Pig Latin Translator", MessageBoxButtons.OK, MessageBoxIcon.Information)
            outPutLabel.Text = String.Empty
            inPutTextBox.SelectAll()
            inPutTextBox.Focus()
        Else
            If userWord.Substring(0, 1) Like "[aeiou]" Then
                outPut = userWord.Substring(0, 1).ToUpper & userWord.Substring(1) & WAY
                outPutLabel.Text = outPut
                inPutTextBox.SelectAll()
                inPutTextBox.Focus()
            Else
                For letter As Integer = 0 To userWord.Length - 1
                    If userWord.Substring(letter, 1) Like "[aeiouy]" Then
                        index = letter
                        letter = userWord.Length - 1
                        outPut = userWord.Remove(0, index) & userWord.Substring(0, index) & AY
                        outPut = outPut.Substring(0, 1).ToUpper & outPut.Substring(1)
                        outPutLabel.Text = outPut
                        inPutTextBox.SelectAll()
                        inPutTextBox.Focus()
                    End If
                Next letter
            End If
        End If


    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub KeyPressText(sender As Object, e As KeyPressEventArgs) Handles inPutTextBox.KeyPress
        'only allow one word to be entered
        If e.KeyChar Like "[!A-Za-z]" AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextSelect(sender As Object, e As EventArgs) Handles inPutTextBox.Enter
        'select all text
        inPutTextBox.SelectAll()
    End Sub

End Class
