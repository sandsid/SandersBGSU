Option Strict Off
Public Class Form1

    '********************************************************
    ' Purpose: This program reads in scores from a data file and stores
    ' them in an array.  It displays the values in the array in a listbox.
    ' Input: Test scores are read in from a data file.  Each test score
    '   is on a separate line.
    ' Processing: The main program calls procedures to:
    '   1. Read the scores from a file and store them in an array
    '   2. Display the values stored in the array of scores in a listbox
    '   3. Find the average of the scores
    '   4. Search the names array for a name entered by the user.
    '   5. Sort the scores in ascending order
    ' Output: 
    '   1. Displays a list of the scores after they are read In
    '      from the file.
    '   2. Display the average score.
    '   3. Displays a student name and the student's score if the name
    '      is found.  Displays an error message is the name is not in
    '      the list.
    '   4. Sorts the arrays in ascending order by the scores.
    '   5. Displays the scores in sorted order.
    '********************************************************

    Private Sub btnGetScores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetScores.Click
        Const MAX_SIZE As Integer = 5
        Dim names(MAX_SIZE) As String
        Dim scores(MAX_SIZE) As Integer
        Dim avgScore As Double
        Dim searchName As String
        Dim position As Integer

        ' Read in scores and store in array
        ReadScores(names, scores, MAX_SIZE)

        ' Print scores read in to list box
        PrintScores(names, scores, MAX_SIZE)

        ' Find the average score
        findAvgScore(avgScore, scores, MAX_SIZE)

        lstScores.Items.Add("")
        lstScores.Items.Add("The average score is " & avgScore)

        ' Find student's score
        searchName = InputBox("Enter name to search for")
        findName(searchName, names, MAX_SIZE, position)

        lstScores.Items.Add("")
        If position = -1 Then
            lstScores.Items.Add("The name " & searchName & " was not found.")
        Else
            lstScores.Items.Add(searchName & " has a score of " & scores(position))
        End If

        ' Sort the arrays in ascending score order
        sortScores(names, scores, MAX_SIZE)

        ' Display scores after they have been sorted
        PrintScores(names, scores, MAX_SIZE)

    End Sub

    '----------------------------------------------------------
    ' This subroutine reads scores from a text file and stores
    ' them in an array.
    '----------------------------------------------------------
    Sub ReadScores(ByRef names() As String, ByRef scores() As Integer,
                   ByVal MAX_SIZE As Integer)
        Dim sr As IO.StreamReader = IO.File.OpenText("scores2.txt")
        Dim x As Integer

        'For x = 1 To MAX_SIZE
        '    names(x) = sr.ReadLine
        '    scores(x) = sr.ReadLine
        'Next

        x = 0
        Do Until sr.EndOfStream
            x = x + 1
            names(x) = sr.ReadLine
            scores(x) = sr.ReadLine
        Loop

        lstScores.Items.Add(x & " names and scores read from file")
        sr.Close()
    End Sub
    '----------------------------------------------------------
    ' This subroutine displays the scores stored in the array.
    '----------------------------------------------------------
    Sub PrintScores(ByRef names() As String, ByRef scores() As Integer,
                   ByVal MAX_SIZE As Integer)
        Dim fmtStr As String = "{0, 3}{1, 3}{2, -10}{3, 6}"
        Dim k As Integer

        lstScores.Items.Add("")
        lstScores.Items.Add(" Pos  Names       Scores")

        For k = 1 To MAX_SIZE
            lstScores.Items.Add(String.Format(fmtStr, k, " ", names(k), scores(k)))
        Next
    End Sub

    '----------------------------------------------------------
    ' This subroutine finds the average score and passes it back.
    '----------------------------------------------------------
    Sub findAvgScore(ByRef avgScore As Double, ByRef scores() As Integer,
                      ByVal MAX_SIZE As Integer)
        Dim total As Integer
        Dim x As Integer

        For x = 1 To MAX_SIZE
            total = total + scores(x)
        Next

        avgScore = total / MAX_SIZE
    End Sub

    '----------------------------------------------------------
    ' This subroutine searches for a name and passes back the
    ' position (element number) of the name if it is found.
    ' It passes back -1 if the name was not found.
    '----------------------------------------------------------
    Sub findName(ByVal searchName As String, ByRef names() As String,
                 ByVal MAX_SIZE As Integer, ByRef position As Integer)
        Dim k As Integer

        position = -1

        For k = 1 To MAX_SIZE
            If names(k) = searchName Then
                position = k
            End If
        Next
    End Sub

    '----------------------------------------------------------
    ' This subroutine sorts the names and scores array in 
    ' ascending order by score.
    '----------------------------------------------------------
    Sub sortScores(ByRef names() As String, ByRef scores() As Integer,
                      ByVal MAX_SIZE As Integer)
        Dim holdScore As Integer
        Dim holdName As String
        Dim numPairs As Integer
        Dim sorted As String
        Dim k As Integer
        numPairs = MAX_SIZE - 1

        sorted = "N"
        Do While sorted = "N"
            ' Make a pass through the array, comparing consecutive pairs
            sorted = "Y"
            For k = 1 To numPairs
                If scores(k) > scores(k + 1) Then
                    holdScore = scores(k)
                    scores(k) = scores(k + 1)
                    scores(k + 1) = holdScore

                    holdName = names(k)
                    names(k) = names(k + 1)
                    names(k + 1) = holdName

                    sorted = "N"
                End If
            Next
            numPairs = numPairs - 1
        Loop
    End Sub

End Class
