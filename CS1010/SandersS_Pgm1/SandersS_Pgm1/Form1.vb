Public Class Form1
    'Program 1: Colorful Text
    'Sidney Sanders
    'CS1010 12:30-1:20
    'Due date: 8/30/17
    Private Sub btnRed_Click(sender As Object, e As EventArgs) Handles btnRed.Click
        txtPhrase.BackColor = Color.Red

    End Sub

    Private Sub btnBlue_Click(sender As Object, e As EventArgs) Handles btnBlue.Click
        txtPhrase.BackColor = Color.Blue
    End Sub

    Private Sub btnWhite_Click(sender As Object, e As EventArgs) Handles btnWhite.Click
        txtPhrase.ForeColor = Color.White
    End Sub

    Private Sub btnYellow_Click(sender As Object, e As EventArgs) Handles btnYellow.Click
        txtPhrase.ForeColor = Color.Yellow
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
