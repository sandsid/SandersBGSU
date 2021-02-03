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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtWon = New System.Windows.Forms.TextBox()
        Me.txtPercentage = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtLost = New System.Windows.Forms.TextBox()
        Me.lblWon = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblLost = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(221, 241)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtWon
        '
        Me.txtWon.Location = New System.Drawing.Point(211, 12)
        Me.txtWon.Name = "txtWon"
        Me.txtWon.Size = New System.Drawing.Size(100, 20)
        Me.txtWon.TabIndex = 8
        '
        'txtPercentage
        '
        Me.txtPercentage.Location = New System.Drawing.Point(211, 156)
        Me.txtPercentage.Name = "txtPercentage"
        Me.txtPercentage.ReadOnly = True
        Me.txtPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtPercentage.TabIndex = 9
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(211, 109)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 10
        '
        'txtLost
        '
        Me.txtLost.Location = New System.Drawing.Point(211, 63)
        Me.txtLost.Name = "txtLost"
        Me.txtLost.Size = New System.Drawing.Size(100, 20)
        Me.txtLost.TabIndex = 11
        '
        'lblWon
        '
        Me.lblWon.AutoSize = True
        Me.lblWon.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWon.Location = New System.Drawing.Point(12, 19)
        Me.lblWon.Name = "lblWon"
        Me.lblWon.Size = New System.Drawing.Size(93, 18)
        Me.lblWon.TabIndex = 12
        Me.lblWon.Text = "Games Won"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(12, 155)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(140, 18)
        Me.lblPercent.TabIndex = 13
        Me.lblPercent.Text = "Winning Percentage"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(12, 108)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(142, 18)
        Me.lblTotal.TabIndex = 14
        Me.lblTotal.Text = "Total Games Played"
        '
        'lblLost
        '
        Me.lblLost.AutoSize = True
        Me.lblLost.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLost.Location = New System.Drawing.Point(12, 62)
        Me.lblLost.Name = "lblLost"
        Me.lblLost.Size = New System.Drawing.Size(90, 18)
        Me.lblLost.TabIndex = 15
        Me.lblLost.Text = "Games Lost"
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(15, 195)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(296, 28)
        Me.btnCompute.TabIndex = 16
        Me.btnCompute.Text = "Compute Winning Percentage"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBy.Location = New System.Drawing.Point(12, 242)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(196, 16)
        Me.lblDevBy.TabIndex = 17
        Me.lblDevBy.Text = "Developed by: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 304)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblLost)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPercent)
        Me.Controls.Add(Me.lblWon)
        Me.Controls.Add(Me.txtLost)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtPercentage)
        Me.Controls.Add(Me.txtWon)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.Text = "Win Percent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents txtWon As TextBox
    Friend WithEvents txtPercentage As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtLost As TextBox
    Friend WithEvents lblWon As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblLost As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblDevBy As Label
End Class
