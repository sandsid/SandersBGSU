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
        Me.lblHeightRange = New System.Windows.Forms.Label()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblBeginHeight = New System.Windows.Forms.Label()
        Me.lblEndHeight = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtBeginHeight = New System.Windows.Forms.TextBox()
        Me.txtEndHeight = New System.Windows.Forms.TextBox()
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnDisplayWeight = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtErrorBox = New System.Windows.Forms.TextBox()
        Me.lblDevBySS = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeightRange
        '
        Me.lblHeightRange.AutoSize = True
        Me.lblHeightRange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeightRange.Location = New System.Drawing.Point(438, 9)
        Me.lblHeightRange.Name = "lblHeightRange"
        Me.lblHeightRange.Size = New System.Drawing.Size(273, 31)
        Me.lblHeightRange.TabIndex = 0
        Me.lblHeightRange.Text = "Height range (inches)"
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGender.Location = New System.Drawing.Point(12, 60)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(199, 31)
        Me.lblGender.TabIndex = 1
        Me.lblGender.Text = "Gender(M or F)"
        '
        'lblBeginHeight
        '
        Me.lblBeginHeight.AutoSize = True
        Me.lblBeginHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginHeight.Location = New System.Drawing.Point(294, 60)
        Me.lblBeginHeight.Name = "lblBeginHeight"
        Me.lblBeginHeight.Size = New System.Drawing.Size(220, 31)
        Me.lblBeginHeight.TabIndex = 2
        Me.lblBeginHeight.Text = "Beginning Height"
        '
        'lblEndHeight
        '
        Me.lblEndHeight.AutoSize = True
        Me.lblEndHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndHeight.Location = New System.Drawing.Point(619, 60)
        Me.lblEndHeight.Name = "lblEndHeight"
        Me.lblEndHeight.Size = New System.Drawing.Size(184, 31)
        Me.lblEndHeight.TabIndex = 3
        Me.lblEndHeight.Text = "Ending Height"
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(18, 117)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(186, 38)
        Me.txtGender.TabIndex = 4
        '
        'txtBeginHeight
        '
        Me.txtBeginHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeginHeight.Location = New System.Drawing.Point(310, 117)
        Me.txtBeginHeight.Name = "txtBeginHeight"
        Me.txtBeginHeight.Size = New System.Drawing.Size(186, 38)
        Me.txtBeginHeight.TabIndex = 5
        '
        'txtEndHeight
        '
        Me.txtEndHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndHeight.Location = New System.Drawing.Point(617, 117)
        Me.txtEndHeight.Name = "txtEndHeight"
        Me.txtEndHeight.Size = New System.Drawing.Size(186, 38)
        Me.txtEndHeight.TabIndex = 6
        '
        'lstBox
        '
        Me.lstBox.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 30
        Me.lstBox.Location = New System.Drawing.Point(155, 173)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(510, 394)
        Me.lstBox.TabIndex = 7
        '
        'btnDisplayWeight
        '
        Me.btnDisplayWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayWeight.Location = New System.Drawing.Point(232, 583)
        Me.btnDisplayWeight.Name = "btnDisplayWeight"
        Me.btnDisplayWeight.Size = New System.Drawing.Size(346, 49)
        Me.btnDisplayWeight.TabIndex = 8
        Me.btnDisplayWeight.Text = "Display Ideal Weights"
        Me.btnDisplayWeight.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(122, 647)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(178, 49)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(518, 647)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(178, 49)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtErrorBox
        '
        Me.txtErrorBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtErrorBox.Location = New System.Drawing.Point(32, 702)
        Me.txtErrorBox.Name = "txtErrorBox"
        Me.txtErrorBox.ReadOnly = True
        Me.txtErrorBox.Size = New System.Drawing.Size(741, 49)
        Me.txtErrorBox.TabIndex = 11
        '
        'lblDevBySS
        '
        Me.lblDevBySS.AutoSize = True
        Me.lblDevBySS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBySS.Location = New System.Drawing.Point(200, 772)
        Me.lblDevBySS.Name = "lblDevBySS"
        Me.lblDevBySS.Size = New System.Drawing.Size(389, 31)
        Me.lblDevBySS.TabIndex = 12
        Me.lblDevBySS.Text = "Developed By: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 830)
        Me.Controls.Add(Me.lblDevBySS)
        Me.Controls.Add(Me.txtErrorBox)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayWeight)
        Me.Controls.Add(Me.lstBox)
        Me.Controls.Add(Me.txtEndHeight)
        Me.Controls.Add(Me.txtBeginHeight)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.lblEndHeight)
        Me.Controls.Add(Me.lblBeginHeight)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblHeightRange)
        Me.Name = "Form1"
        Me.Text = "Ideal Weights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeightRange As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblBeginHeight As Label
    Friend WithEvents lblEndHeight As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents txtBeginHeight As TextBox
    Friend WithEvents txtEndHeight As TextBox
    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnDisplayWeight As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtErrorBox As TextBox
    Friend WithEvents lblDevBySS As Label
End Class
