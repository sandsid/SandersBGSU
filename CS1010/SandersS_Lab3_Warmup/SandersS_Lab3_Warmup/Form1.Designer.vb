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
        Me.lblEnterNum = New System.Windows.Forms.Label()
        Me.btnResult = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtEnterNum = New System.Windows.Forms.TextBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblEnterNum
        '
        Me.lblEnterNum.AutoSize = True
        Me.lblEnterNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterNum.Location = New System.Drawing.Point(41, 25)
        Me.lblEnterNum.Name = "lblEnterNum"
        Me.lblEnterNum.Size = New System.Drawing.Size(312, 74)
        Me.lblEnterNum.TabIndex = 0
        Me.lblEnterNum.Text = "Enter a number from" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 10 to 99"
        '
        'btnResult
        '
        Me.btnResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResult.Location = New System.Drawing.Point(335, 243)
        Me.btnResult.Name = "btnResult"
        Me.btnResult.Size = New System.Drawing.Size(335, 56)
        Me.btnResult.TabIndex = 1
        Me.btnResult.Text = "Click to see results"
        Me.btnResult.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(41, 151)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(106, 37)
        Me.lblResult.TabIndex = 2
        Me.lblResult.Text = "Result"
        '
        'txtEnterNum
        '
        Me.txtEnterNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterNum.Location = New System.Drawing.Point(394, 30)
        Me.txtEnterNum.Name = "txtEnterNum"
        Me.txtEnterNum.Size = New System.Drawing.Size(276, 44)
        Me.txtEnterNum.TabIndex = 3
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResult.Location = New System.Drawing.Point(394, 151)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(276, 44)
        Me.txtResult.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 332)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtEnterNum)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnResult)
        Me.Controls.Add(Me.lblEnterNum)
        Me.Name = "Form1"
        Me.Text = "Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEnterNum As Label
    Friend WithEvents btnResult As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents txtEnterNum As TextBox
    Friend WithEvents txtResult As TextBox
End Class
