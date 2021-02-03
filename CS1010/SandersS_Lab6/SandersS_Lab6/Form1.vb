Option Strict Off
Public Class Form1
    'Sidney Sanders     CS1010 12:30-1:20       date: 10/6/17
    'this program is used to take the user input and make it so that every transaction, 
    '   it will subtract the transactiong And display the withdraw and remaining balence in a listbox.
    '   It will also show the total amount withdrawn, how many withdraws it had, and the average withdraw 
    '   during the program running.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRunATM.Click

        ' calling the variables and using the values to get the start cash 
        Dim startCash, count, withdraw, endValue, amountLeft, totalWithdraw, average As Integer
        lstBoxATM.Items.Add("Cash Withdrawn     Amount Left")
        startCash = txtStartCash.Text
        count = 0
        endValue = -1
        withdraw = InputBox("Enter cash to withdraw (-1 to end)")
        amountLeft = startCash

        ' Calculating the withdraw and displaying the withdraw and answer in the list box

        Do While withdraw <> endValue
            count = count + 1
            totalWithdraw = totalWithdraw + withdraw
            amountLeft = amountLeft - withdraw

            lstBoxATM.Items.Add("           " & withdraw & "                " & amountLeft)
            withdraw = InputBox("Enter cash to withdraw (-1 to end)")
        Loop

        'displaying the total withdraw, how many withdraws, and the average.

        lstBoxATM.Items.Add("")
        lstBoxATM.Items.Add("Total cash Withdrawn today is $" & totalWithdraw & ".")
        lstBoxATM.Items.Add("")

        'bonus****

        lstBoxATM.Items.Add("Total  number of withdraws today is " & count & ".")
        lstBoxATM.Items.Add("")
        average = totalWithdraw / count
        lstBoxATM.Items.Add("The average withdraw value is $" & average & ".")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBoxATM.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
