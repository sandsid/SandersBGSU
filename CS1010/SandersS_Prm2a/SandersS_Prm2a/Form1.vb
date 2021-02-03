Option Strict Off
Public Class Form1
    'Sidney Sanders
    'CS1010
    '12:30-1:20
    'due 9/13/17 
    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'declare variables

        Dim numSeconds_lightning, distanceMiles As Double

        'get numbers from text box

        numSeconds_lightning = txtNumSeconds.Text

        'calculate

        distanceMiles = numSeconds_lightning / 5

        'display

        txtDistanceMiles.Text = distanceMiles

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
