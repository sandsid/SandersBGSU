Option Strict Off
Public Class Form1
    'Sidney Sanders   Cs1010:12:30-1:20     10/11/17
    'This program asks the use to input player point values and then displays the total,
    '   average, highest score, and lowest score.   
    '   the input is from the user when they enter the player scores. it then puts the output into the listbox
    '   to show the snswer and at the end it shows information about the player points
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'button to end the program
        End
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' button to clear the list box
        lstBox.Items.Clear()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'calling the varibles and setting their value.

        Dim fmtStr As String = "{0,-12}{1,-7}"
        Dim points, player As Integer
        Dim total, average As Double
        Dim high, low As Integer
        Dim endValue As Integer

        endValue = -1
        player = 0
        total = 0

        lstBox.Items.Add(String.Format(fmtStr, "Player #", "Points"))
        points = InputBox("Enter points for player " & player & "  [enter -1 to end]")
        high = points
        low = points

        'begining of do while statement finding the highest and lowest score

        Do While points <> endValue
            lstBox.Items.Add(String.Format(fmtStr, "Player" & player, points))
            player = player + 1
            total = total + points

            If points > high Then
                high = points
            ElseIf points < low Then
                low = points
            End If

            points = InputBox("Enter points for player " & player & "  [enter -1 to end]")
        Loop

        'finding average
        average = total / player

        'Displaying the totals and end results into the list box.
        lstBox.Items.Add("")
        lstBox.Items.Add("Total points: " & total)
        lstBox.Items.Add("Average points/player:" & average)
        lstBox.Items.Add("Highest points scored: " & high)
        lstBox.Items.Add("Lowest points scored: " & low)

    End Sub
End Class
