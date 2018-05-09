Public Class frmSpeakAssignment
    'global variable
    Public speak As New SpeechSynthesizer
    Dim user As String
    Dim gender As String
    Dim myShuffle As New shuffle
    Dim counter As Integer = 0
    Private Sub frmSpeakAssignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set speak variables
        speak.Rate = -1
        speak.Volume = 100

        'make the radial buttons invisble and diabled
        btnYes.Enabled = False
        btnYes.Visible = False
        btnNo.Enabled = False
        btnNo.Visible = False
        pbComp.Visible = False
        myShuffle.ShuffleFemale()
        myShuffle.ShuffleMale()

        'ask user for name and gender
        user = InputBox("What's your name?", "Name")
        gender = InputBox("What gender do you wnat your friend to be? (male or female)", "Gender")
        If gender.ToLower = "male" Then
            speak.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior)
        Else
            speak.SelectVoiceByHints(VoiceGender.Female)
        End If
        speak.Speak("Hello " & user & " do you have a question for you new best friend")

    End Sub

    Private Sub btnAsk_Click(sender As Object, e As EventArgs) Handles btnAsk.Click
        txtQuestion.Enabled = False
        txtQuestion.Visible = False
        Label1.Visible = False
        btnAsk.Enabled = False
        btnAsk.Visible = False
        pbComp.Visible = True
        If gender.ToLower = "male" Then
            speak.Speak(myShuffle._responseMale(counter))
        Else
            speak.Speak(myShuffle._responseFemale(counter))
        End If
        counter += 1
        speak.Speak("Did that answer help your situation " & user)
        pbComp.Visible = False
        btnNo.Enabled = True
        btnNo.Visible = True
        btnYes.Enabled = True
        btnYes.Visible = True
        btnYes.Focus()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        btnYes.Enabled = False
        btnYes.Visible = False
        btnNo.Enabled = False
        btnNo.Visible = False
        pbComp.Visible = True
        If counter = 1 Then
            speak.Speak("Your welcome")
            speak.Speak("I am a very wise and knowledgeable entity   try not to fear my superiority   Next question")
        Else
            speak.Speak("Your welcome")
            speak.Speak("Next question")
        End If
        pbComp.Visible = False
        txtQuestion.Enabled = True
        txtQuestion.Visible = True
        btnAsk.Enabled = True
        btnAsk.Visible = True
        Label1.Visible = True
        txtQuestion.Clear()
        txtQuestion.Focus()

        If counter > myShuffle._responseFemale.GetUpperBound(0) Then
            myShuffle.ShuffleFemale()
            myShuffle.ShuffleMale()
            counter = 0
        End If

    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        btnYes.Enabled = False
        btnYes.Visible = False
        btnNo.Enabled = False
        btnNo.Visible = False
        txtQuestion.Enabled = False
        txtQuestion.Visible = False
        btnAsk.Enabled = False
        btnAsk.Visible = False
        pbComp.Visible = True
        speak.Speak("Well then   bye Falicia")
        Me.Close()

    End Sub
End Class
