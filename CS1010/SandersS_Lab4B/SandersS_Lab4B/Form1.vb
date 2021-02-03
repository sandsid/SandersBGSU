Public Class Form1
    'Sidney Sanders
    'CS1010 12:30-1:20
    '9/15/17

    Private Sub btnCloudConditions_Click(sender As Object, e As EventArgs) Handles btnCloudConditions.Click
        'declare variables

        Dim cloudCover As Integer
        Dim weather As String = ""

        'get input

        cloudCover = txtCloudCoverage.Text

        'calculate and display

        If cloudCover < 31 Then
            weather = "Clear"
        ElseIf cloudCover < 100 Then
            weather = "Cloudy"
        Else
            weather = "Overcast"
        End If

        'Display 

        txtWeatherD.Text = weather

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End

    End Sub
End Class
