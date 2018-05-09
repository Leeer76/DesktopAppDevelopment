'File Name: Bingo.vb
'Created/Revised by: Erik Lee

Option Strict On
Option Infer Off
Option Explicit On


Public Class Bingo
    'The B column ranges from 1 to 15
    'The I column ranges from 16 To 30
    'The N column ranges from 31 To 45
    'The G column ranges from 46 To 60
    'The O column ranges from 61 To 75.


    Private _BingoNums(74) As Integer
    Private _newNum(74) As String
    Public _bNum(14) As String
    Public _iNum(14) As String
    Public _nNum(14) As String
    Public _gNum(14) As String
    Public _oNum(14) As String

    Public Function getNum(ByVal counter As Integer) As String
        'send new number to mainform
        Return _newNum(counter)
    End Function


    Public Sub New()
        'load all bingo numbers
        For value As Integer = 0 To _BingoNums.GetUpperBound(0)
            _BingoNums(value) = value + 1
        Next
        For x As Integer = 0 To _newNum.GetUpperBound(0)
            _newNum(x) = String.Empty
        Next
        For x As Integer = 0 To _bNum.GetUpperBound(0)
            _bNum(x) = String.Empty
        Next
        For x As Integer = 0 To _iNum.GetUpperBound(0)
            _iNum(x) = String.Empty
        Next
        For x As Integer = 0 To _nNum.GetUpperBound(0)
            _nNum(x) = String.Empty
        Next
        For x As Integer = 0 To _gNum.GetUpperBound(0)
            _gNum(x) = String.Empty
        Next
        For x As Integer = 0 To _oNum.GetUpperBound(0)
            _oNum(x) = String.Empty
        Next
    End Sub

    Public Sub shuffleNums()
        'shuffle numbers to be drawn
        For index As Integer = 0 To 14
            _newNum(index) = "B - " & _BingoNums(index)
        Next
        For index As Integer = 15 To 29
            _newNum(index) = "I - " & _BingoNums(index)
        Next
        For index As Integer = 30 To 44
            _newNum(index) = "N - " & _BingoNums(index)
        Next
        For index As Integer = 45 To 59
            _newNum(index) = "G - " & _BingoNums(index)
        Next
        For index As Integer = 60 To 74
            _newNum(index) = "O - " & _BingoNums(index)
        Next

        For index As Integer = 0 To 100
            Dim temp As String
            Dim rand As New Random
            Dim randnum As Integer


            For index2 As Integer = 0 To _newNum.GetUpperBound(0)
                randnum = rand.Next(1, 76) + 1
                If (index2 + randnum) < _newNum.GetUpperBound(0) Then
                    temp = _newNum(index2)
                    _newNum(index2) = _newNum(index2 + randnum)
                    _newNum(index2 + randnum) = temp
                End If
            Next
        Next
    End Sub
    Public Sub ShuffleBStack()
        'load b array and shuffle
        For x As Integer = 0 To _bNum.GetUpperBound(0)
            _bNum(x) = "B - " & _BingoNums(x)
        Next

        For index As Integer = 0 To 100
            Dim temp As String
            Dim rand As New Random
            Dim randnum As Integer

            For index2 As Integer = 0 To _bNum.GetUpperBound(0)
                randnum = rand.Next(1, 16) + 1
                If (index2 + randnum) < _bNum.GetUpperBound(0) Then
                    temp = _bNum(index2)
                    _bNum(index2) = _bNum(index2 + randnum)
                    _bNum(index2 + randnum) = temp
                End If
            Next
        Next
    End Sub

    Public Sub ShuffleIStack()
        'load b array and shuffle
        For x As Integer = 0 To _iNum.GetUpperBound(0)
            _iNum(x) = "I - " & _BingoNums(x + 15)
        Next

        For index As Integer = 0 To 100
            Dim temp As String
            Dim rand As New Random
            Dim randnum As Integer

            For index2 As Integer = 0 To _iNum.GetUpperBound(0)
                randnum = rand.Next(1, 16) + 1
                If (index2 + randnum) < _iNum.GetUpperBound(0) Then
                    temp = _iNum(index2)
                    _iNum(index2) = _iNum(index2 + randnum)
                    _iNum(index2 + randnum) = temp
                End If
            Next
        Next
    End Sub
    Public Sub ShuffleNStack()
        'load b array and shuffle
        For x As Integer = 0 To _nNum.GetUpperBound(0)
            _nNum(x) = "N - " & _BingoNums(x + 30)
        Next

        For index As Integer = 0 To 100
            Dim temp As String
            Dim rand As New Random
            Dim randnum As Integer

            For index2 As Integer = 0 To _nNum.GetUpperBound(0)
                randnum = rand.Next(1, 16) + 1
                If (index2 + randnum) < _nNum.GetUpperBound(0) Then
                    temp = _nNum(index2)
                    _nNum(index2) = _nNum(index2 + randnum)
                    _nNum(index2 + randnum) = temp
                End If
            Next
        Next
    End Sub
    Public Sub ShuffleGStack()
        'load b array and shuffle
        For x As Integer = 0 To _gNum.GetUpperBound(0)
            _gNum(x) = "G - " & _BingoNums(x + 45)
        Next

        For index As Integer = 0 To 100
            Dim temp As String
            Dim rand As New Random
            Dim randnum As Integer

            For index2 As Integer = 0 To _gNum.GetUpperBound(0)
                randnum = rand.Next(1, 16) + 1
                If (index2 + randnum) < _gNum.GetUpperBound(0) Then
                    temp = _gNum(index2)
                    _gNum(index2) = _gNum(index2 + randnum)
                    _gNum(index2 + randnum) = temp
                End If
            Next
        Next
    End Sub
    Public Sub ShuffleOStack()
        'load b array and shuffle
        For x As Integer = 0 To _oNum.GetUpperBound(0)
            _oNum(x) = "O - " & _BingoNums(x + 60)
        Next

        For index As Integer = 0 To 100
            Dim temp As String
            Dim rand As New Random
            Dim randnum As Integer

            For index2 As Integer = 0 To _oNum.GetUpperBound(0)
                randnum = rand.Next(1, 16) + 1
                If (index2 + randnum) < _oNum.GetUpperBound(0) Then
                    temp = _oNum(index2)
                    _oNum(index2) = _oNum(index2 + randnum)
                    _oNum(index2 + randnum) = temp
                End If
            Next
        Next
    End Sub

End Class
