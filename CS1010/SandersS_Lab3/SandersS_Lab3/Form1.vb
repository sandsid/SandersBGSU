Public Class Form1
    'Sidney Sanders
    'CS1010 12:30-1:30
    '9/8/17

    Private Sub btnCoinsNeeded_Click(sender As Object, e As EventArgs) Handles btnCoinsNeeded.Click
        Dim changeNeeded, result As Integer
        Dim quarters, dimes, nickels, pennies As Integer

        'get amount of change from user
        changeNeeded = txtChangeAmount.Text

        ' do calculations 
        quarters = changeNeeded \ 25
        result = changeNeeded Mod 25

        dimes = result \ 10
        result = result Mod 10

        nickels = result \ 5
        result = result Mod 5

        pennies = result

        'display the change needed
        txtQuarters.Text = quarters
        txtDimes.Text = dimes
        txtNickels.Text = nickels
        txtPennies.Text = pennies

    End Sub
End Class
