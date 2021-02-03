Option Strict Off
Public Class Form1
    'Sidney Sanders         CS1010:12:30-1:20       10/11/17
    '   this program is used to find the perfect weight for the hight that a person is. 
    '   the input would be when they eneter their gender and begining, ending height. Then 
    '   the compuuter will calculate and give the user an output into the list box. 
    '   the display is what shows in the listbox
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clearing all textboxes in the program to start fresh
        lstBox.Items.Clear()
        txtErrorBox.Text = ""
        txtGender.Text = ""
        txtBeginHeight.Text = ""
        txtEndHeight.Text = ""
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub

    Private Sub btnDisplayWeight_Click(sender As Object, e As EventArgs) Handles btnDisplayWeight.Click

        'calling the variables and assigning them values.
        Dim beginHeight, endHeight As Integer
        Dim weight As Double
        Dim gender As String
        Dim errorMessage As String = "One or more of the inputs are incorect"
        Dim fmtStr As String = "{0,-10}{1,-10}"

        ' getting the user information from the text boxes in the program.
        gender = txtGender.Text
        beginHeight = txtBeginHeight.Text
        endHeight = txtEndHeight.Text

        'begining of calculating the dowhile and checking if entrys are correct
        '   and then calculating the answer and displayong it into the list box
        If beginHeight >= 30 And endHeight >= beginHeight Then
            txtErrorBox.Text = ""
            If gender = "F" Then
                lstBox.Items.Clear()
                txtErrorBox.Text = ""
                lstBox.Items.Add(String.Format(fmtStr, "Height", "Weight"))
                Do While beginHeight <= endHeight
                    weight = (beginHeight * 3.5) - 108
                    lstBox.Items.Add(String.Format(fmtStr, beginHeight, weight))
                    beginHeight = beginHeight + 1


                Loop
            ElseIf gender = "M" Then
                lstBox.Items.Clear()
                txtErrorBox.Text = ""
                lstBox.Items.Add(String.Format(fmtStr, "Height", "Weight"))
                Do While beginHeight <= endHeight
                    weight = (beginHeight * 4) - 128
                    lstBox.Items.Add(String.Format(fmtStr, beginHeight, weight))
                    beginHeight = beginHeight + 1

                Loop
                'begining of the bonus to find the answer if the user inputs the lowercase letter of the gender
            ElseIf gender = "f" Then
                lstBox.Items.Clear()
                txtErrorBox.Text = ""
                lstBox.Items.Add(String.Format(fmtStr, "Height", "Weight"))
                Do While beginHeight <= endHeight
                    weight = (beginHeight * 3.5) - 108
                    lstBox.Items.Add(String.Format(fmtStr, beginHeight, weight))
                    beginHeight = beginHeight + 1
                Loop
            ElseIf gender = "m" Then
                lstBox.Items.Clear()
                txtErrorBox.Text = ""
                lstBox.Items.Add(String.Format(fmtStr, "Height", "Weight"))
                Do While beginHeight <= endHeight
                    weight = (beginHeight * 4) - 128
                    lstBox.Items.Add(String.Format(fmtStr, beginHeight, weight))
                    beginHeight = beginHeight + 1

                Loop
            Else
                txtErrorBox.Text = errorMessage
            End If
        Else
            txtErrorBox.Text = errorMessage
        End If

    End Sub
End Class
