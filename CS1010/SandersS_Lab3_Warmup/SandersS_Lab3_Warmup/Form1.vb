Public Class Form1
    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click
        Dim origNum, result As Integer
        Dim a, b As Integer

        'get number from user
        origNum = txtEnterNum.Text

        'perform calculation
        a = origNum \ 10
        b = origNum Mod 10
        result = b * 10 + a

        'display 
        txtResult.Text = result

    End Sub
End Class
