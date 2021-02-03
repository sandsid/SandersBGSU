Option Strict Off
Public Class Form1
    'Sidney Sanders     CS1010       12:30-1:20
    'Assignment program 5      Due: 10/25/17
    'Purpose : program to judge the scores of the bowling green bowling team.  It will be able to 
    '   determine the top scorer, how many bowlers, and average score.
    'Input : The input comes from the text file with the names and game scores of all the bowlers. 
    'Processing : When starting the program it takes the information from the text file by reading it line by line
    '   and then it calculates the total score of the person and then calculates the average. 
    '   while the program is reding the lines, it will be checking for the highest scoring bowling by going
    '   through an if statement and if true then making that bowler the new winner.
    'Output : as the file id being read, it will be adding the players to the text file before it goes back to
    '   read the lext name, after it is done reading the file it then writes the final lines in the program 
    '   and then the program ends.

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'calling the variables and assigning them to the 
        Dim gameTotal As Integer = 0
        Dim game1, game2, game3, totalPlayers As Integer
        Dim name As String = ""
        Dim winner As String = ""
        Dim gameAverage, totalAverage, totalScore As Double
        Dim winningScore As Integer
        Dim fmtSandersFile As String = "{0, -20}{1, -20}{2, -20}"
        Dim fmtPlayerPoints As String = "{0, -23}{1, -22}{2, -5}"
        Dim bowlingFile As IO.StreamReader = IO.File.OpenText("pgm5.txt")
        Dim sw As IO.StreamWriter = IO.File.CreateText("SandersS_rpt5.txt")

        'this is the start of the input, gathering infrofation from the file and printing it into the new file

        totalPlayers = 0
        winningScore = 0
        sw.WriteLine("            BGSU Bowling Tournament Report")
        sw.WriteLine("             Prepared by:  Sidney Sanders")
        sw.WriteLine(String.Format(fmtSandersFile, "    Name", "Total Score", "Average score"))
        sw.WriteLine("    -------------------------------------------------")

        Do Until bowlingFile.EndOfStream
            totalPlayers = totalPlayers + 1
            name = bowlingFile.ReadLine
            game1 = bowlingFile.ReadLine
            game2 = bowlingFile.ReadLine
            game3 = bowlingFile.ReadLine
            gameTotal = game1 + game2 + game3
            gameAverage = gameTotal \ 3

            'finding the highest scoring player

            If gameTotal > winningScore Then
                winner = name
                winningScore = gameTotal
            End If
            sw.WriteLine(String.Format(fmtPlayerPoints, "    " & name, gameTotal, gameAverage))
            totalScore = totalScore + gameTotal

        Loop

        'finding average after all has been completed

        totalAverage = totalScore \ totalPlayers

        'all calculations are complete and this is the part were it prints the final scores and winner.

        sw.WriteLine("    ")
        sw.WriteLine("    Numbers of Bowlers    " & totalPlayers)
        sw.WriteLine("    Average total score    " & totalAverage)
        sw.WriteLine("    ")
        sw.WriteLine("    Tournament Winner:    " & winner)
        sw.WriteLine("    Winners total score:    " & winningScore)

        sw.Close()

    End Sub
End Class
