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
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblWeekday = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtWeekday = New System.Windows.Forms.TextBox()
        Me.btnFindWeekday = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(32, 50)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(106, 37)
        Me.lblMonth.TabIndex = 0
        Me.lblMonth.Text = "Month"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(32, 127)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(73, 37)
        Me.lblDay.TabIndex = 1
        Me.lblDay.Text = "Day"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(32, 200)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(85, 37)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "Year"
        '
        'lblWeekday
        '
        Me.lblWeekday.AutoSize = True
        Me.lblWeekday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekday.Location = New System.Drawing.Point(32, 278)
        Me.lblWeekday.Name = "lblWeekday"
        Me.lblWeekday.Size = New System.Drawing.Size(199, 37)
        Me.lblWeekday.TabIndex = 3
        Me.lblWeekday.Text = "Day of Week"
        '
        'txtMonth
        '
        Me.txtMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.Location = New System.Drawing.Point(274, 47)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(308, 44)
        Me.txtMonth.TabIndex = 4
        '
        'txtDay
        '
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.Location = New System.Drawing.Point(274, 124)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(316, 44)
        Me.txtDay.TabIndex = 5
        '
        'txtYear
        '
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(274, 197)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(316, 44)
        Me.txtYear.TabIndex = 6
        '
        'txtWeekday
        '
        Me.txtWeekday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeekday.Location = New System.Drawing.Point(274, 275)
        Me.txtWeekday.Name = "txtWeekday"
        Me.txtWeekday.ReadOnly = True
        Me.txtWeekday.Size = New System.Drawing.Size(316, 44)
        Me.txtWeekday.TabIndex = 7
        '
        'btnFindWeekday
        '
        Me.btnFindWeekday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFindWeekday.Location = New System.Drawing.Point(124, 350)
        Me.btnFindWeekday.Name = "btnFindWeekday"
        Me.btnFindWeekday.Size = New System.Drawing.Size(380, 68)
        Me.btnFindWeekday.TabIndex = 8
        Me.btnFindWeekday.Text = "Find Day of Week"
        Me.btnFindWeekday.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 439)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(454, 37)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Developed By: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 507)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFindWeekday)
        Me.Controls.Add(Me.txtWeekday)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.lblWeekday)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblMonth)
        Me.Name = "Form1"
        Me.Text = "Day of Week"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMonth As Label
    Friend WithEvents lblDay As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblWeekday As Label
    Friend WithEvents txtMonth As TextBox
    Friend WithEvents txtDay As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtWeekday As TextBox
    Friend WithEvents btnFindWeekday As Button
    Friend WithEvents Label1 As Label
End Class
