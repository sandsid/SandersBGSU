Option Strict Off
Public Class Form1
    'Sidney Sanders CS1010 12:30-1:20

    'Program 3 Due 9-20-17

    'Purpose: The purpose of this program is to determine the day of week the date falls on 
    'And to determine if it Is within a leap year.

    'input: The input in this program is when the user types in the day month and year 
    ' that they want to figure the day

    'Processing: the processing will begin by declaring the dateValue and then using that
    '  to find the last two digets of the year to calculate to a smaller number to compare
    '  in an if statement using months. Then the program starts to check wether the date 
    '  is in a leap year. 

    'Output: the code then takes the finished process and displays it in the textbox.
    '  the outpu will diplay the day of week and then if it is a leap year is says 
    '  the day and next to it in parenthesis leap year.

    Private Sub btnFindWeekday_Click(sender As Object, e As EventArgs) Handles btnFindWeekday.Click
        'Define variables for month day and year

        Dim day, year, month, dateValue As Integer
        Dim dayOfWeek As String = ""
        Dim leapTrueFale As Boolean
        Dim lastTwo, leapYear As Integer
        'get day month year from user

        day = txtDay.Text
        year = txtYear.Text
        month = txtMonth.Text

        'calculate day of week

        'step 1, 2, and 3

        lastTwo = year Mod 100
        dateValue = lastTwo \ 4
        dateValue = lastTwo + dateValue
        If year > 2000 Then
            dateValue = dateValue + 6
        End If

        dateValue = dateValue + day

        If month = 1 Or month = 10 Then
            dateValue = dateValue + 1
        ElseIf month = 2 Or month = 3 Or month = 11 Then
            dateValue = dateValue + 4
        ElseIf month = 4 Or month = 7 Then
            dateValue = dateValue
        ElseIf month = 5 Then
            dateValue = dateValue + 2
        ElseIf month = 6 Then
            dateValue = dateValue + 5
        ElseIf month = 8 Then
            dateValue = dateValue + 3
        Else
            dateValue = dateValue + 6
        End If

        'finding leap year **bonus**

        leapYear = year Mod 4
        If leapYear = 0 Then
            If month = 1 Or month = 2 Then
                dateValue = dateValue - 1
            Else
                dateValue = dateValue
            End If
            leapTrueFale = True
        ElseIf (year Mod 400) = 0 Then
            If month = 1 Or month = 2 Then
                dateValue = dateValue - 1
            Else
                leapTrueFale = True
            End If
        Else
            leapTrueFale = False
        End If

        ' end of leap year calculation

        'start of finding the day and leap year
        dateValue = dateValue Mod 7

        If dateValue = 1 Then
            If leapTrueFale = True Then
                dayOfWeek = "Sunday (Leap Year)"
            Else
                dayOfWeek = "Sunday"
            End If
        ElseIf dateValue = 2 Then
            If leapTrueFale = True Then
                dayOfWeek = "Monday (Leap year)"
            Else
                dayOfWeek = "Monday"
            End If
        ElseIf dateValue = 3 Then
            If leapTrueFale = True Then
                dayOfWeek = "Tuesday (Leap Year)"
            Else
                dayOfWeek = "Tuesday"
            End If
        ElseIf dateValue = 4 Then
            If leapTrueFale = True Then
                dayOfWeek = "Wednesday (Leap Year)"
            Else
                dayOfWeek = "Wednesday"
            End If
        ElseIf dateValue = 5 Then
            If leapTrueFale = True Then
                dayOfWeek = "Thursday (Leap Year)"
            Else
                dayOfWeek = "Thursday"
            End If
        ElseIf dateValue = 6 Then
            If leapTrueFale = True Then
                dayOfWeek = "Friday (Leap Year)"
            Else
                dayOfWeek = "Friday"
            End If
        Else
            If leapTrueFale = True Then
                dayOfWeek = "Saturday (Leap Year)"
            Else
                dayOfWeek = "Saturday"
            End If
        End If
        ' display the answer for the day of week 

        txtWeekday.Text = dayOfWeek

    End Sub
End Class
