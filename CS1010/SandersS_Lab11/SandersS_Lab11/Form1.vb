Option Strict Off
'Sidney Sanders     CS1010      12:30-1:20      12/8/17
Public Class Form1
    Private Sub btnRaiseSalary_Click(sender As Object, e As EventArgs) Handles btnRaiseSalary.Click
        Const maxNum As Integer = 10
        Dim salaries(maxNum) As Double

        ReadSalaries(salaries, maxNum)
        lstBox.Items.Add("     Employee Salaries")
        lstBox.Items.Add("      Sidney Sanders ")
        DisplaySalaries(salaries, maxNum)
        lstBox.Items.Add("Salasies raised by 5%")
        RaiseSalaries(salaries, maxNum)
        DisplaySalaries(salaries, maxNum)
        lstBox.Items.Add("Salaries sorted from least to greatest")
        SortSalaries(salaries, maxNum)
        DisplaySalaries(salaries, maxNum)

    End Sub

    Sub ReadSalaries(ByRef salaries() As Double, ByVal maxNum As Integer)
        Dim sr As IO.StreamReader = IO.File.OpenText("lab11.txt")
        Dim x As Integer

        For x = 1 To maxNum
            salaries(x) = sr.ReadLine
        Next

        sr.Close()
    End Sub

    Sub DisplaySalaries(ByVal salaries() As Double, ByVal maxNum As Integer)
        Dim x As Integer
        Dim fmtSalaries As String = "{0, -18}{1, -10}"


        lstBox.Items.Add("")
        lstBox.Items.Add("   Ele#          Salary")
        For x = 1 To maxNum
            lstBox.Items.Add(String.Format(fmtSalaries, "    " & x, salaries(x)))
        Next

    End Sub

    Sub RaiseSalaries(ByRef salaries() As Double, ByVal maxNum As Integer)
        Dim x As Integer
        Dim raise As Double = 0

        For x = 1 To maxNum
            raise = salaries(x) * 0.05
            salaries(x) = salaries(x) + raise
        Next

    End Sub

    Sub SortSalaries(ByVal salaries() As Double, ByVal maxNum As Integer)
        Dim x As Integer
        Dim sorted As String = "Y"
        Dim temp As Integer
        Dim numPairs As Integer = maxNum - 1

        sorted = "N"
        Do While sorted <> "Y"
            sorted = "Y"
            For x = 1 To numPairs
                If salaries(x) > salaries(x + 1) Then
                    temp = salaries(x)
                    salaries(x) = salaries(x + 1)
                    salaries(x + 1) = temp
                    sorted = "N"
                End If
            Next
            numPairs = numPairs - 1
        Loop



    End Sub
End Class
