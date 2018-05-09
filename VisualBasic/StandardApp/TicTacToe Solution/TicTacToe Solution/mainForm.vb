' Project name:         TicTacToe Solution
' Project purpose:      simulate a game of tic tac toe
' Created/revised by:   Erik Lee on Mar 22, 2017

Option Strict On
Option Infer Off
Option Explicit On

Public Class mainForm
    'declare variable
    Dim gameBoard() As Label = {New Label, New Label, New Label, New Label, New Label, New Label, New Label, New Label, New Label}
    Dim isWinner As Boolean

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'close application
        Dim response As Integer
        response = MessageBox.Show("Do you want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If response = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub newButton_Click(sender As Object, e As EventArgs) Handles newButton.Click
        'clears fields and to creat new game
        mainTableLayoutPanel.Enabled = True
        leftTopLabel.Text = String.Empty
        leftTopLabel.Enabled = True
        leftTopLabel.BackColor = DefaultBackColor
        leftMiddleLabel.Text = String.Empty
        leftMiddleLabel.Enabled = True
        leftMiddleLabel.BackColor = DefaultBackColor
        leftBottomLabel.Text = String.Empty
        leftBottomLabel.Enabled = True
        leftBottomLabel.BackColor = DefaultBackColor
        middleTopLabel.Text = String.Empty
        middleTopLabel.Enabled = True
        middleTopLabel.BackColor = DefaultBackColor
        middleMiddleLabel.Text = String.Empty
        middleMiddleLabel.Enabled = True
        middleMiddleLabel.BackColor = DefaultBackColor
        middleBottomLabel.Text = String.Empty
        middleBottomLabel.Enabled = True
        middleBottomLabel.BackColor = DefaultBackColor
        rightTopLabel.Text = String.Empty
        rightTopLabel.Enabled = True
        rightTopLabel.BackColor = DefaultBackColor
        rightMiddleLabel.Text = String.Empty
        rightMiddleLabel.Enabled = True
        rightMiddleLabel.BackColor = DefaultBackColor
        rightBottomLabel.Text = String.Empty
        rightBottomLabel.Enabled = True
        rightBottomLabel.BackColor = DefaultBackColor
        gameBoard(0).Text = String.Empty
        gameBoard(1).Text = String.Empty
        gameBoard(2).Text = String.Empty
        gameBoard(3).Text = String.Empty
        gameBoard(4).Text = String.Empty
        gameBoard(5).Text = String.Empty
        gameBoard(6).Text = String.Empty
        gameBoard(7).Text = String.Empty
        gameBoard(8).Text = String.Empty
        isWinner = False


    End Sub

    Private Sub Winner(sender As Object, e As EventArgs) Handles leftTopLabel.Click, leftMiddleLabel.Click, leftBottomLabel.Click, middleTopLabel.Click, middleMiddleLabel.Click, middleBottomLabel.Click, rightTopLabel.Click, rightMiddleLabel.Click, rightBottomLabel.Click
        'determine the winner
        'declare variables
        Dim currentLable As Label
        Dim subscript As Integer
        Static player As String = "X"
        Static squareColor As Color = Color.LightGreen

        'convert sender to label
        currentLable = TryCast(sender, Label)
        'declares x or o in label
        currentLable.Text = player
        'changes back color
        currentLable.BackColor = squareColor
        'does not allow use of the label again
        currentLable.Enabled = False

        Select Case currentLable.Name
            Case "leftTopLabel"
                subscript = 0
            Case "leftMiddleLabel"
                subscript = 1
            Case "leftBottomLabel"
                subscript = 2
            Case "middleTopLabel"
                subscript = 3
            Case "middleMiddleLabel"
                subscript = 4
            Case "middleBottomLabel"
                subscript = 5
            Case "rightTopLabel"
                subscript = 6
            Case "rightMiddleLabel"
                subscript = 7
            Case "rightBottomLabel"
                subscript = 8
        End Select

        'enter array data
        gameBoard(subscript).Text = player

        Select Case player & player & player
            Case gameBoard(0).Text & gameBoard(1).Text & gameBoard(2).Text
                isWinner = True
            Case gameBoard(3).Text & gameBoard(4).Text & gameBoard(5).Text
                isWinner = True
            Case gameBoard(6).Text & gameBoard(7).Text & gameBoard(8).Text
                isWinner = True
            Case gameBoard(0).Text & gameBoard(3).Text & gameBoard(6).Text
                isWinner = True
            Case gameBoard(1).Text & gameBoard(4).Text & gameBoard(7).Text
                isWinner = True
            Case gameBoard(2).Text & gameBoard(5).Text & gameBoard(8).Text
                isWinner = True
            Case gameBoard(0).Text & gameBoard(4).Text & gameBoard(8).Text
                isWinner = True
            Case gameBoard(6).Text & gameBoard(4).Text & gameBoard(2).Text
                isWinner = True
        End Select

        If isWinner Then
            MessageBox.Show("Game over! Player " & player & " is the winner", "End of Game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            mainTableLayoutPanel.Enabled = False
        ElseIf (TIETEST()) Then
            MessageBox.Show("Stalemate, No Winners!", "Tie", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            newButton.PerformClick()
        Else
            If player = "X" Then
                player = "O"
                squareColor = Color.LightPink
            Else
                player = "X"
                squareColor = Color.LightGreen
            End If
        End If


    End Sub

    Private Function TIETEST() As Boolean
        'test if a tie has happened
        For i As Integer = 0 To gameBoard.GetUpperBound(0)
            If (Not (gameBoard(i).Text = "X" OrElse gameBoard(i).Text = "O")) Then
                Return False
            End If
        Next
        Return True
    End Function

End Class
