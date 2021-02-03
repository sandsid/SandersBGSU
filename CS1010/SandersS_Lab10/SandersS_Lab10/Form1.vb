Option Strict Off
'Sidney Sanders
'CS 1010   12:30-1:20     12/1/2017

Public Class Form1
    Private Sub btnPizzaStores_Click(sender As Object, e As EventArgs) Handles btnPizzaStores.Click
        Const eleNum As Integer = 8
        Dim company(eleNum) As String
        Dim stores(eleNum) As Integer
        Dim searchName As String
        Dim position As Integer = 0

        'read in pizza place and num of stores and put into array
        readPizzaData(company, stores, eleNum)

        'dispaying the arrays into a listbox
        displayPizzaData(company, stores, eleNum)

        'find a company in the array and displaying it into listbox
        searchName = InputBox("Enter name to search for")
        findName(searchName, company, position, eleNum)
        If position = -1 Then
            lstBox.Items.Add(searchName & " not found.")
        Else
            lstBox.Items.Add(searchName & " has " & stores(position) & " stores.")
        End If

        'bonus finding the store with the most buildings 
        mostStores(stores, company, position, eleNum)
        lstBox.Items.Add("The Pizza Company " & company(position))
        lstBox.Items.Add("has the most stores with " & stores(position) & " stores.")

    End Sub

    Sub readPizzaData(ByRef company() As String, ByRef stores() As Integer, ByVal eleNum As Integer)
        Dim sr As IO.StreamReader = IO.File.OpenText("lab10.txt")
        Dim x As Integer

        For x = 1 To 8
            company(x) = sr.ReadLine
            stores(x) = sr.ReadLine

        Next

        sr.Close()
    End Sub

    Sub displayPizzaData(ByRef company() As String, ByRef stores() As Integer, ByVal eleNum As Integer)
        Dim x As Integer
        Dim fmt As String = "{0, -7}{1, -17}{2, -10}"

        lstBox.Items.Add("       Pizza Company Stores")
        lstBox.Items.Add("          Sidney Sanders")
        lstBox.Items.Add("")
        lstBox.Items.Add("Ele #  Company         Stores")

        For x = 1 To eleNum
            lstBox.Items.Add(String.Format(fmt, " " & x, company(x), stores(x)))
        Next


    End Sub

    Sub findName(ByVal searchName As String, ByVal company() As String, ByRef position As Integer, ByVal eleNum As Integer)
        Dim x As Integer

        For x = 1 To eleNum
            If searchName = company(x) Then
                position = x
            End If
        Next
        If position > 0 Then
            position = position
        Else
            position = -1
        End If

    End Sub

    Sub mostStores(ByRef stores() As Integer, ByRef company() As String, ByRef position As Integer, ByVal eleNum As Integer)
        Dim x As Integer
        Dim mostStores As Integer = 0

        position = 0

        For x = 1 To eleNum
            If stores(x) > mostStores Then
                position = x
            End If
        Next
        'position = 5
    End Sub

    Private Sub btnClear_Click_1(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBox.Items.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
