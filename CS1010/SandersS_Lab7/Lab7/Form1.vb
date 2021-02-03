Public Class Form1
    'Sidney Sanders     CS1010      12:30-1:20
    Private Sub btnShowPop_Click(sender As Object, e As EventArgs) Handles btnShowPop.Click

        Dim sr As IO.StreamReader
        sr = IO.File.OpenText("lab7.txt")

        Dim cityName As String
        Dim cityPop As Double
        Dim numCities As Integer = 0
        Dim totalPop As Double = 0.0
        Dim largCity As String = ""
        Dim largPop As Double = 0.0
        Dim fmtDiscription As String = "{0, -15}{1, -25}"
        Dim fmtCities As String = "{0, -23}{1, -20}"
        Dim sw As IO.StreamWriter = IO.File.CreateText("SandersS_Lab7_rpt.txt")

        'Start of entering things into the list and text file
        sw.WriteLine("           City Population Report")
        sw.WriteLine("               Sidney Sanders")
        sw.WriteLine(String.Format(fmtDiscription, "City Name", "Population (millions)"))
        sw.WriteLine("---------------------------------------")

        'reading begins and calculation to find largest city starts
        Do Until sr.EndOfStream
            cityName = sr.ReadLine
            cityPop = sr.ReadLine
            lstCityPops.Items.Add(cityName & "        " & cityPop)
            sw.WriteLine(String.Format(fmtCities, cityName, cityPop))
            If cityPop > largPop Then
                largCity = cityName
                largPop = cityPop
            End If
            totalPop = totalPop + cityPop
            numCities = numCities + 1
        Loop

        'Final thoughts including total and largest population is displayed
        sw.WriteLine("The totl Number of Cities:    " & numCities)
        sw.WriteLine("The Total Population for all cities:   " & totalPop)
        sw.WriteLine("The largest Population: " & largPop & " In " & largCity)

        'end of program and closing files
        sr.Close()
        sw.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
End Class
