Public Class Form1
    'Sidney Sanders
    'CS1010 12:30-1:20
    '9/1/17

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim wonNumber As Integer
        Dim lostNumber As Integer
        Dim totalGames As Integer
        Dim winningPercent As Double

        wonNumber = txtWon.Text
        lostNumber = txtLost.Text

        totalGames = wonNumber + lostNumber
        winningPercent = (wonNumber / totalGames) * 100

        txtTotal.Text = totalGames
        txtPercentage.Text = winningPercent


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
