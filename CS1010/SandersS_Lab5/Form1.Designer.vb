<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstSums = New System.Windows.Forms.ListBox()
        Me.btnEvenSum = New System.Windows.Forms.Button()
        Me.btnSumsEvenOdd = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblNames = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstSums
        '
        Me.lstSums.FormattingEnabled = True
        Me.lstSums.ItemHeight = 25
        Me.lstSums.Location = New System.Drawing.Point(76, 12)
        Me.lstSums.Name = "lstSums"
        Me.lstSums.Size = New System.Drawing.Size(362, 479)
        Me.lstSums.TabIndex = 0
        '
        'btnEvenSum
        '
        Me.btnEvenSum.Location = New System.Drawing.Point(35, 533)
        Me.btnEvenSum.Name = "btnEvenSum"
        Me.btnEvenSum.Size = New System.Drawing.Size(144, 135)
        Me.btnEvenSum.TabIndex = 1
        Me.btnEvenSum.Text = "Find sum of even numbers 2 to 10"
        Me.btnEvenSum.UseVisualStyleBackColor = True
        '
        'btnSumsEvenOdd
        '
        Me.btnSumsEvenOdd.Location = New System.Drawing.Point(203, 533)
        Me.btnSumsEvenOdd.Name = "btnSumsEvenOdd"
        Me.btnSumsEvenOdd.Size = New System.Drawing.Size(166, 135)
        Me.btnSumsEvenOdd.TabIndex = 2
        Me.btnSumsEvenOdd.Text = "Find sum of numbers"
        Me.btnSumsEvenOdd.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(400, 623)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(111, 70)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(400, 533)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(111, 67)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblNames
        '
        Me.lblNames.AutoSize = True
        Me.lblNames.Location = New System.Drawing.Point(40, 688)
        Me.lblNames.Name = "lblNames"
        Me.lblNames.Size = New System.Drawing.Size(308, 25)
        Me.lblNames.TabIndex = 5
        Me.lblNames.Text = "Developed by: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 722)
        Me.Controls.Add(Me.lblNames)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSumsEvenOdd)
        Me.Controls.Add(Me.btnEvenSum)
        Me.Controls.Add(Me.lstSums)
        Me.Name = "Form1"
        Me.Text = "Do While Loops"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstSums As ListBox
    Friend WithEvents btnEvenSum As Button
    Friend WithEvents btnSumsEvenOdd As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblNames As Label
End Class
