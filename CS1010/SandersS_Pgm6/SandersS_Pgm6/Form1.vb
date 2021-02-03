Option Strict Off
'Sidney Sanders CS1010 12:30-1:20

'Purpose: the purpose of this program is the development of an online advertising thing for the cumstomers. it gives them
'         how much the advertisment Is going To cost And Then know the total they owe For their ad. 
'Input: the input is coming from a text file with all the information in it. they get the information by reading it directly 
'       from the file 
'Processing: the processing in this program is very condensed and has many different calculations. the sub procedures 
'            have alot of use in passing back and forth variables and refrences. 
'Output:
Public Class Form1

    'Clear button
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstBox.Items.Clear()
    End Sub

    'End button 
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    'Mainsub when button is clicked
    Private Sub btnSalesReport_Click(sender As Object, e As EventArgs) Handles btnSalesReport.Click
        ' calling all the varriables that i will be using in the program
        Dim sr As IO.StreamReader = IO.File.OpenText("pgm6.txt")
        Dim idNum, placeCode, lineNum As Integer
        Dim adType As String = ""
        Dim adTypeName As String = ""
        Dim extraLine, extraLineCost, totalAdCost, basePrice As Integer
        Dim fmtHeader As String = "{0, -4}{1, -9}{2, -11}{3, -7}{4, -10}{5, -12}{6, -10}"
        Dim fmtAdSales As String = "{0,-7}{1,-9}{2,-10}{3,-8}{4,-6}{5, -13}{6,-10}"

        ' creating the heading of the report that will show in the list box
        lstBox.Items.Add("                      Ad Sales Report")
        lstBox.Items.Add("                      Sidney Sanders")
        lstBox.Items.Add("")
        lstBox.Items.Add(String.Format(fmtHeader, "ID", "PlcCode", "Base Price", "#Lines",
                                       "Extra Ln", "Ad Type", "Ad Cost"))
        lstBox.Items.Add("---------------------------------------------------------------")

        'begining of reading the file, checking and calculation, and displaying the end  results
        Do Until sr.EndOfStream
            idNum = sr.ReadLine
            placeCode = sr.ReadLine
            lineNum = sr.ReadLine
            adType = sr.ReadLine

            'this is where the subs are called to make the calculations 
            CheckBaseAndLineCost(lineNum, adType, extraLine, extraLineCost, placeCode, basePrice)
            CheckAdType(adType, totalAdCost, adTypeName)
            CheckTotalCost(basePrice, extraLineCost, totalAdCost, adType)

            'alfter all the calculations are complete the end variables are displayed
            lstBox.Items.Add(String.Format(fmtAdSales, idNum, placeCode, "$" & basePrice, lineNum, extraLineCost, adTypeName,
                                           "$" & totalAdCost \ 1000 & "," & totalAdCost Mod 1000 & ".00"))
        Loop
        'end of program, closing the file
        sr.Close()
    End Sub
    'first sub finding the base price and extraline cost 
    Sub CheckBaseAndLineCost(ByVal lineNum As Integer, ByVal adType As String,
                             ByRef extraLine As Integer, ByRef extraLineCost As Integer,
                             ByVal placeCode As Integer, ByRef basePrice As Integer)

        'finding how many extra lines their are
        If lineNum > 10 Then
            extraLine = lineNum - 10
        Else
            extraLine = 0
        End If

        'calculation the extraline cost and base price for customer
        If placeCode = 1 Then
            extraLineCost = extraLine * 125
            basePrice = 1500
        ElseIf placeCode = 2 Then
            extraLineCost = extraLine * 50
            basePrice = 900
        Else
            extraLineCost = extraLine * 100
            basePrice = 2200
        End If

    End Sub
    'Second sub to find what the ad type is 
    Sub CheckAdType(ByVal adType As String, ByRef totalAdCost As Integer, ByRef adTypeName As String)

        If adType = "T" Then
            adTypeName = "Text Only"
        ElseIf adType = "G" Then
            adTypeName = "Graphics"
        Else
            adTypeName = "Animation"
        End If

    End Sub

    'third sub to find the total cost of the ad 
    Sub CheckTotalCost(ByVal basePrice As Integer, ByVal extraLineCost As Integer,
                       ByRef totalAdCost As Integer, ByVal adType As String)

        totalAdCost = basePrice + extraLineCost

        If adType = "T" Then
            totalAdCost = totalAdCost
        ElseIf adType = "G" Then
            totalAdCost = totalAdCost + (totalAdCost * 0.4)
        Else
            totalAdCost = totalAdCost + (totalAdCost * 0.6)
        End If


    End Sub

End Class
