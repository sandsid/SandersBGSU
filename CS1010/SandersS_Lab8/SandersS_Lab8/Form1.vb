Option Strict Off
Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Close button procedure, ends program
        End
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Calling the variables and assigning then values
        Dim weight, height As Integer
        Dim BMI As Double
        Dim risk As String = ""
        Dim interp As String = ""

        'getting the height and weight from user
        weight = txtWeight.Text
        height = txtHeight.Text

        'calling the calculation procedure and then displaying the answer in the text box
        calcBMI(weight, height, BMI)
        txtBMI.Text = BMI

        'calling the check BMI to get the risk and interptretaion from the procedure, then displaying in in text box
        checkBMI(BMI, risk, interp)
        txtRisk.Text = risk
        txtInterp.Text = interp

    End Sub
    Sub calcBMI(ByVal weight As Integer, ByVal height As Integer, ByRef BMI As Double)

        'calculation for the BMI answer 
        BMI = (weight * 703) / (height ^ 2)
    End Sub
    Sub checkBMI(ByVal BMI As Double, ByRef risk As String, ByRef interp As String)

        'if statement to determine the risk and interpretation
        If BMI < 20 Then
            risk = "Low"
            interp = "UnderWeight"
        ElseIf BMI <= 25 Then
            risk = "Low"
            interp = "Normal"
        ElseIf BMI <= 30 Then
            risk = "Medium"
            interp = "Overweight"
        ElseIf BMI > 30 Then
            risk = "High"
            interp = "Obese"
        End If
    End Sub
End Class
