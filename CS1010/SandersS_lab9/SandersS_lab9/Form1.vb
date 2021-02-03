Option Strict Off
'Sidney Sanders CS 1010 12:30-1:20

Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        lstRainData.Items.Clear()
    End Sub

    Private Sub btnProcessRain_Click(sender As Object, e As EventArgs) Handles btnProcessRain.Click
        'creating the array
        Dim rain() As Double = {0.0, 2.88, 1.7, 3.92, 5.47, 3.56, 6.73, 5.42, 3.59, 3.21, 2.68, 1.47, 2.7}
        Dim month As Integer = 1
        Dim totalRain As Double = 0.0
        Dim average As Double = 0.0
        Dim mostRain As Double = 0.0
        Dim mostRainMonth As Integer = 1
        Dim fmtCategory As String = "{0,20}{1,20}"
        Dim fmtNum As String = "{0,20}{1,25}"

        lstRainData.Items.Add("                  Rainfall per Month")
        lstRainData.Items.Add(String.Format(fmtCategory, "Month", "Inches"))

        For month = 1 To 12
            lstRainData.Items.Add(String.Format(fmtNum, month, rain(month)))

            'Bonus**
            addTotalRain(totalRain, rain(month))

            ' Finding the most rain and month *bonus
            If rain(month) > mostRain Then
                mostRain = rain(month)
                mostRainMonth = month
            End If

        Next
        'Displaying results of the rainfall.
        lstRainData.Items.Add("")
        lstRainData.Items.Add("Total rainfall = " & totalRain & " inches.")
        lstRainData.Items.Add("Average monthly rainfall = " & totalRain / 12 & " inches.")
        lstRainData.Items.Add("Highest Monthly rainfall = " & mostRain & " inches in month " & mostRainMonth)
        lstRainData.Items.Add("")



    End Sub
    Sub addTotalRain(ByRef totalRain As Double, ByVal rain As Double)
        totalRain = totalRain + rain
    End Sub
End Class
