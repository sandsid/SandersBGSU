Option Strict Off
Public Class Form1
    Private Sub btnEvenSum_Click(sender As Object, e As EventArgs) Handles btnEvenSum.Click
        '-----------------------------------------------------------
        ' Sidney Sanders        CS1010: Lab 5          Class time: 12:30-1:20
        '
        ' Change this procedure so that it correctly finds and
        ' displays the sum described.
        '-----------------------------------------------------------
        ' Purpose: Find the sum of the even numbers from 2 to 10
        '   (i.e., 2 + 4 + ... + 10) using a Do While loop.
        ' Input: None
        ' Processing: Uses a Do While loop to add the even numbers
        '   from 2 to 10 to find a total, using the loop counter 
        '   variable as the value to be added each time.
        ' Output: Displays the count added to the sum and the new
        '   value of the sum each time through the loop.  When the
        '   loop is finished the final sum of the even numbers from
        '   2 to 10 is displayed.
        '-----------------------------------------------------------
        Dim count As Integer
        Dim sum As Integer

        count = 2
        sum = 0
        lstSums.Items.Add("Count  Sum so far")

        Do While count < 10
            sum = sum + count
            lstSums.Items.Add(count & "         " & sum)
            count = count + 2
        Loop

        lstSums.Items.Add("")
        lstSums.Items.Add("Sum of even numbers 2 to 10 = " & sum)

    End Sub

    Private Sub btnSumsEvenOdd_Click(sender As Object, e As EventArgs) Handles btnSumsEvenOdd.Click
        '-----------------------------------------------------------
        ' 1. First modify the program below so that it CORRECTLY finds
        '    the sum of all the numbers entered (except the sentinel 
        '    value) using a sentinel-controlled loop.  
        ' 2. Then modify the program so that it finds the sums described 
        '    in the header comments below.
        ' 3. Finally, add the code to find the average of all numbers
        '    entered.
        '-----------------------------------------------------------
        ' Purpose: This program finds the sum of all the numbers entered,
        '   the sum of the even numbers entered, the sum of the odd
        '   numbers entered and the average of all of the numbers entered
        '   (if you do the bonus).
        ' Input: The user may enter any number of positive values to be
        '   summed in any order, entering -1 to end the program.
        ' Processing: Uses a loop to accept numbers from the user
        '   until a value of -1 is entered.  It adds all numbers
        '   entered to an overall sum.  It also adds each number to
        '   another sum variable depending on whether the number is 
        '   even or odd.  After all numbers have been entered the average
        '   of all numbers is calculated by dividing the overall sum by
        '   the number of values entered.
        ' Output: In the list box, displays each number entered by the 
        '   user followed by the sum of all numbers entered, 
        '   the sum of all even numbers, the sum of all odd numbers and 
        '   the average of all numbers.
        '-----------------------------------------------------------
        Const EndValue As Integer = -1
        Dim num As Integer
        Dim sumNos As Integer
        Dim count As Integer
        Dim even, odd As Integer
        Dim average As Double
        'FInding the sum of the numbers enterd by user
        count = 0
        sumNos = 0
        lstSums.Items.Add("")
        num = InputBox("Enter a number. Enter (-1) to end.")
        Do While num <> EndValue
            'finding the even and odd numbers
            If num Mod 2 = 1 Then
                odd = odd + num
            ElseIf num Mod 2 = 0 Then
                even = even + num
            End If
            count = count + 1
            sumNos = sumNos + num
            lstSums.Items.Add(num)
            num = InputBox("Enter a number. Enter (-1) to end.")
        Loop
        'Finding the average of all the numbers
        average = sumNos / count
        'displaying the totals in the box
        lstSums.Items.Add("")
        lstSums.Items.Add("Sum of numbers entered = " & sumNos)
        lstSums.Items.Add("Sum of even number = " & even)
        lstSums.Items.Add("Sum of odd number = " & odd)
        lstSums.Items.Add("Average of all numbers = " & average)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstSums.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
