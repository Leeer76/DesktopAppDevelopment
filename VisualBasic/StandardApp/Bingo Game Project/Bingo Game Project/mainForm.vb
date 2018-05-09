' Project name:         Bingo Game
' Project purpose:      simulate a game of Bingo
' Created/revised by:   Erik Lee on Apr 28, 2017

Option Strict On
Option Infer Off
Option Explicit On

Public Class mainForm
    Dim newNum As String
    Dim counter As Integer
    Dim myBingo As New Bingo
    Dim isWinner As Boolean
    Dim BingoBoard(24) As Integer
    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub Winner(sender As Object, e As EventArgs) Handles bOneLabel.Click, bTwoLabel.Click, bThreeLabel.Click, bFourLabel.Click, bFiveLabel.Click, iOneLabel.Click, iTwoLabel.Click, iThreeLabel.Click, iFourLabel.Click, iFiveLabel.Click, nOneLabel.Click, nTwoLabel.Click, nThreeLabel.Click, nFourLabel.Click, nFiveLabel.Click, gOneLabel.Click, gTwoLabel.Click, gThreeLabel.Click, GFourLabel.Click, gFiveLabel.Click, oOneLabel.Click, oTwoLabel.Click, oThreeLabel.Click, oFourLabel.Click, oFiveLabel.Click
        'determin the winner
        'declare variables
        Dim currentLabel As Label
        Dim subscript As Integer
        Static dobber As Color = Color.LightGreen

        'convert sender to label
        currentLabel = TryCast(sender, Label)

        If currentLabel.Text = newNum OrElse currentLabel.Text = "Free" Then
            'change backcolor when dabbed
            currentLabel.BackColor = dobber
            'locks label
            currentLabel.Enabled = False

            Select Case currentLabel.Name
                Case "bOneLabel"
                    subscript = 0
                Case "bTwoLabel"
                    subscript = 1
                Case "bThreeLabel"
                    subscript = 2
                Case "bFourLabel"
                    subscript = 3
                Case "bFiveLabel"
                    subscript = 4
                Case "iOneLabel"
                    subscript = 5
                Case "iTwoLabel"
                    subscript = 6
                Case "iThreeLabel"
                    subscript = 7
                Case "iFourLabel"
                    subscript = 8
                Case "iFiveLabel"
                    subscript = 9
                Case "nOneLabel"
                    subscript = 10
                Case "nTwoLabel"
                    subscript = 11
                Case "nThreeLabel"
                    subscript = 12
                Case "nFourLabel"
                    subscript = 13
                Case "nFiveLabel"
                    subscript = 14
                Case "gOneLabel"
                    subscript = 15
                Case "gTwoLabel"
                    subscript = 16
                Case "gThreeLabel"
                    subscript = 17
                Case "GFourLabel"
                    subscript = 18
                Case "gFiveLabel"
                    subscript = 19
                Case "oOneLabel"
                    subscript = 20
                Case "oTwoLabel"
                    subscript = 21
                Case "oThreeLabel"
                    subscript = 22
                Case "oFourLabel"
                    subscript = 23
                Case "oFiveLabel"
                    subscript = 24
            End Select
            'enter array data
            BingoBoard(subscript) = subscript
            'determine winning sequence
            If BingoBoard(0) = 0 AndAlso BingoBoard(1) = 1 AndAlso BingoBoard(2) = 2 AndAlso BingoBoard(3) = 3 AndAlso BingoBoard(4) = 4 Then
                isWinner = True
            ElseIf BingoBoard(5) = 5 AndAlso BingoBoard(6) = 6 AndAlso BingoBoard(7) = 7 AndAlso BingoBoard(8) = 8 AndAlso BingoBoard(9) = 9 Then
                isWinner = True
            ElseIf BingoBoard(10) = 10 AndAlso BingoBoard(11) = 11 AndAlso BingoBoard(12) = 12 AndAlso BingoBoard(13) = 13 AndAlso BingoBoard(14) = 14 Then
                isWinner = True
            ElseIf BingoBoard(15) = 15 AndAlso BingoBoard(16) = 16 AndAlso BingoBoard(17) = 17 AndAlso BingoBoard(18) = 18 AndAlso BingoBoard(19) = 19 Then
                isWinner = True
            ElseIf BingoBoard(20) = 20 AndAlso BingoBoard(21) = 21 AndAlso BingoBoard(22) = 22 AndAlso BingoBoard(23) = 23 AndAlso BingoBoard(24) = 24 Then
                isWinner = True
            ElseIf BingoBoard(0) = 0 AndAlso BingoBoard(5) = 5 AndAlso BingoBoard(10) = 10 AndAlso BingoBoard(15) = 15 AndAlso BingoBoard(20) = 20 Then
                isWinner = True
            ElseIf BingoBoard(1) = 1 AndAlso BingoBoard(6) = 6 AndAlso BingoBoard(11) = 11 AndAlso BingoBoard(16) = 16 AndAlso BingoBoard(21) = 21 Then
                isWinner = True
            ElseIf BingoBoard(2) = 2 AndAlso BingoBoard(7) = 7 AndAlso BingoBoard(12) = 12 AndAlso BingoBoard(17) = 17 AndAlso BingoBoard(22) = 22 Then
                isWinner = True
            ElseIf BingoBoard(3) = 3 AndAlso BingoBoard(8) = 8 AndAlso BingoBoard(13) = 13 AndAlso BingoBoard(18) = 18 AndAlso BingoBoard(23) = 23 Then
                isWinner = True
            ElseIf BingoBoard(4) = 4 AndAlso BingoBoard(9) = 9 AndAlso BingoBoard(14) = 14 AndAlso BingoBoard(19) = 19 AndAlso BingoBoard(24) = 24 Then
                isWinner = True
            ElseIf BingoBoard(0) = 0 AndAlso BingoBoard(6) = 6 AndAlso BingoBoard(12) = 12 AndAlso BingoBoard(18) = 18 AndAlso BingoBoard(24) = 24 Then
                isWinner = True
            ElseIf BingoBoard(4) = 4 AndAlso BingoBoard(8) = 8 AndAlso BingoBoard(12) = 12 AndAlso BingoBoard(16) = 16 AndAlso BingoBoard(20) = 20 Then
                isWinner = True
            End If

            If isWinner = True Then
                MessageBox.Show("B - I - N - G - O", "Winner", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                newGameButton.PerformClick()
            End If
        Else
            MessageBox.Show("No No No, that number was not drawn!", "Cheater", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If



    End Sub

    Private Sub newGameButton_Click(sender As Object, e As EventArgs) Handles newGameButton.Click
        'load new gameboard and shuffle number
        'clears output and reactivates labels and colors
        newNumOutPutLabel.Text = String.Empty

        bOneLabel.Enabled = True
        bTwoLabel.Enabled = True
        bThreeLabel.Enabled = True
        bFourLabel.Enabled = True
        bFiveLabel.Enabled = True

        iOneLabel.Enabled = True
        iTwoLabel.Enabled = True
        iThreeLabel.Enabled = True
        iFourLabel.Enabled = True
        iFiveLabel.Enabled = True

        nOneLabel.Enabled = True
        nTwoLabel.Enabled = True
        nThreeLabel.Enabled = True
        nFourLabel.Enabled = True
        nFiveLabel.Enabled = True

        gOneLabel.Enabled = True
        gTwoLabel.Enabled = True
        gThreeLabel.Enabled = True
        GFourLabel.Enabled = True
        gFiveLabel.Enabled = True

        oOneLabel.Enabled = True
        oTwoLabel.Enabled = True
        oThreeLabel.Enabled = True
        oFourLabel.Enabled = True
        oFiveLabel.Enabled = True

        bOneLabel.BackColor = DefaultBackColor
        bTwoLabel.BackColor = DefaultBackColor
        bThreeLabel.BackColor = DefaultBackColor
        bFourLabel.BackColor = DefaultBackColor
        bFiveLabel.BackColor = DefaultBackColor

        iOneLabel.BackColor = DefaultBackColor
        iTwoLabel.BackColor = DefaultBackColor
        iThreeLabel.BackColor = DefaultBackColor
        iFourLabel.BackColor = DefaultBackColor
        iFiveLabel.BackColor = DefaultBackColor

        nOneLabel.BackColor = DefaultBackColor
        nTwoLabel.BackColor = DefaultBackColor
        nFourLabel.BackColor = DefaultBackColor
        nFiveLabel.BackColor = DefaultBackColor

        gOneLabel.BackColor = DefaultBackColor
        gTwoLabel.BackColor = DefaultBackColor
        gThreeLabel.BackColor = DefaultBackColor
        GFourLabel.BackColor = DefaultBackColor
        gFiveLabel.BackColor = DefaultBackColor

        oOneLabel.BackColor = DefaultBackColor
        oTwoLabel.BackColor = DefaultBackColor
        oThreeLabel.BackColor = DefaultBackColor
        oFourLabel.BackColor = DefaultBackColor
        oFiveLabel.BackColor = DefaultBackColor

        'initiate shuffles
        myBingo.shuffleNums()
        myBingo.ShuffleBStack()
        myBingo.ShuffleIStack()
        myBingo.ShuffleNStack()
        myBingo.ShuffleGStack()
        myBingo.ShuffleOStack()

        'load bingo card
        bOneLabel.Text = myBingo._bNum(0)
        bTwoLabel.Text = myBingo._bNum(1)
        bThreeLabel.Text = myBingo._bNum(2)
        bFourLabel.Text = myBingo._bNum(3)
        bFiveLabel.Text = myBingo._bNum(4)

        iOneLabel.Text = myBingo._iNum(0)
        iTwoLabel.Text = myBingo._iNum(1)
        iThreeLabel.Text = myBingo._iNum(2)
        iFourLabel.Text = myBingo._iNum(3)
        iFiveLabel.Text = myBingo._iNum(4)

        nOneLabel.Text = myBingo._nNum(0)
        nTwoLabel.Text = myBingo._nNum(1)
        nThreeLabel.BackColor = Color.PaleVioletRed
        nFourLabel.Text = myBingo._nNum(3)
        nFiveLabel.Text = myBingo._nNum(4)

        gOneLabel.Text = myBingo._gNum(0)
        gTwoLabel.Text = myBingo._gNum(1)
        gThreeLabel.Text = myBingo._gNum(2)
        GFourLabel.Text = myBingo._gNum(3)
        gFiveLabel.Text = myBingo._gNum(4)

        oOneLabel.Text = myBingo._oNum(0)
        oTwoLabel.Text = myBingo._oNum(1)
        oThreeLabel.Text = myBingo._oNum(2)
        oFourLabel.Text = myBingo._oNum(3)
        oFiveLabel.Text = myBingo._oNum(4)

        For x As Integer = 0 To BingoBoard.GetUpperBound(0)
            BingoBoard(x) = 0
        Next

        isWinner = False

        counter = 0


    End Sub

    Private Sub numDrawButton_Click(sender As Object, e As EventArgs) Handles numDrawButton.Click
        'draw a new number


        If counter < 75 Then
            newNum = myBingo.getNum(counter)
            newNumOutPutLabel.Text = newNum
            counter += 1
        Else
            MessageBox.Show("Sorry, you didn't win", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            newGameButton.PerformClick()
        End If




    End Sub

End Class
