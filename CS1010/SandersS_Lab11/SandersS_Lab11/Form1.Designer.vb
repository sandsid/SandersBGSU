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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnRaiseSalary = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 32
        Me.lstBox.Location = New System.Drawing.Point(37, 28)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(443, 484)
        Me.lstBox.TabIndex = 0
        '
        'btnRaiseSalary
        '
        Me.btnRaiseSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaiseSalary.Location = New System.Drawing.Point(50, 533)
        Me.btnRaiseSalary.Name = "btnRaiseSalary"
        Me.btnRaiseSalary.Size = New System.Drawing.Size(412, 72)
        Me.btnRaiseSalary.TabIndex = 1
        Me.btnRaiseSalary.Text = "Raise salaries"
        Me.btnRaiseSalary.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Location = New System.Drawing.Point(95, 637)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(308, 25)
        Me.lblDevBy.TabIndex = 4
        Me.lblDevBy.Text = "Developed by: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 694)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnRaiseSalary)
        Me.Controls.Add(Me.lstBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnRaiseSalary As Button
    Friend WithEvents lblDevBy As Label
End Class
