Public Class Form1
    'Sidney Sanders
    'CS1010 12:30-1:20
    '9/1/17

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim age As Integer
        Dim restingRate As Integer
        Dim trainingRate As Double

        age = txtAge.Text
        restingRate = txtResting.Text

        trainingRate = 0.7 * (220 - age) + 0.3 * restingRate

        txtTraining.Text = trainingRate


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
