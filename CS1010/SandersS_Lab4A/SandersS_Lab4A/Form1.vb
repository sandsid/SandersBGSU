Public Class Form1
    'Sidney Sanders
    'CS1010 12:30-1:20
    '9/15/17
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTotalCostofBagels.Click
        'declare variable

        Dim numBagels As Integer
        Dim totalCost As Double

        'get user input

        numBagels = txtNumBagels.Text

        'calculate

        If numBagels < 6 Then
            totalCost = numBagels * 0.75
            txtTotalCost.Text = totalCost
        Else
            totalCost = numBagels * 0.6
            txtTotalCost.Text = totalCost
        End If

        'display
    End Sub
End Class
