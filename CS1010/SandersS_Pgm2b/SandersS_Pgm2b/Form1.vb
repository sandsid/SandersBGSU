Option Strict Off
Public Class Form1
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'declare  variables

        Dim numHours_cycling, numHours_running, numHours_swimming As Integer
        Dim caloriesLost, poundsLost As Double

        'get numbers from text

        numHours_cycling = txtHoursCycling.Text
        numHours_running = txtHoursRunning.Text
        numHours_swimming = txtHoursSwimming.Text

        'calculate

        caloriesLost = (numHours_cycling * 200) + (numHours_running * 475) + (numHours_swimming * 275)
        poundsLost = caloriesLost / 3500

        'display

        txtCaloriesBurned.Text = caloriesLost
        txtPoundsLost.Text = poundsLost

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
