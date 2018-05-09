Public Class shuffle
    Public _responseMale(9) As String
    Public _responseFemale(9) As String

    Public Sub New()
        'load male responses arrays
        _responseMale(0) = "Did I ever tell you about the time I went to mexico   Oh man  long story short I did serious prison time"
        _responseMale(1) = "The answer to everything is duct tape"
        _responseMale(2) = "The one thing you need to know about prison is to assert Dominance"
        _responseMale(3) = "You know what Einstein said  If at first the idea is not absurd  then there will be no hope for it"
        _responseMale(4) = "I dont know for sure but probably Russia"
        _responseMale(5) = "What do you mean by that  my mustache is super cool and totally masculine"
        _responseMale(6) = "Charlie Browns teachers were actually saying I am fire   I am death"
        _responseMale(7) = "No one can hear you scream in the woods"
        _responseMale(8) = "If you fist fight a bear the bear will most likely win"
        _responseMale(9) = "Crying is for weak willed women and small children  luckly for me i am not crying  my eyes are bleeding salt water okay BRENDA"

        'load female responses array
        _responseFemale(0) = "How many cats is too many cats  asking for a friend"
        _responseFemale(1) = "the answer to everything is Pumpkin spice"
        _responseFemale(2) = "You know what Einstein said  If at first the idea is not absurd  then there will be no hope for it"
        _responseFemale(3) = "I dont know for sure but probably China"
        _responseFemale(4) = "Why are you concerned about that when we should be fighting the patriarchy"
        _responseFemale(5) = "Charlie Browns teachers were actually saying I am fire   I am death"
        _responseFemale(6) = "Clowns will haunt your dreams if you are afraid of clowns"
        _responseFemale(7) = "Dont be so basic"
        _responseFemale(8) = "YYOOOOOOOOOOOLLOOOOOOOOOOOO"
        _responseFemale(9) = "What ever  we should get some chocolate"
    End Sub
    Public Sub ShuffleMale()
        For x As Integer = 0 To 100
            Dim tmp As String
            Dim rand As New Random
            Dim randNum As Integer

            For y As Integer = 0 To _responseMale.GetUpperBound(0)
                randNum = rand.Next(1, 11) + 1
                If (y + randNum) < _responseMale.GetUpperBound(0) Then
                    tmp = _responseMale(y)
                    _responseMale(y) = _responseMale(y + randNum)
                    _responseMale(y + randNum) = tmp
                End If
            Next
        Next
    End Sub
    Public Sub ShuffleFemale()
        For x As Integer = 0 To 100
            Dim tmp As String
            Dim rand As New Random
            Dim randNum As Integer

            For y As Integer = 0 To _responseFemale.GetUpperBound(0)
                randNum = rand.Next(1, 11) + 1
                If (y + randNum) < _responseFemale.GetUpperBound(0) Then
                    tmp = _responseFemale(y)
                    _responseMale(y) = _responseFemale(y + randNum)
                    _responseFemale(y + randNum) = tmp
                End If
            Next
        Next
    End Sub
End Class
