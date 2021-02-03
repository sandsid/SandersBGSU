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
        Me.btnRed = New System.Windows.Forms.Button()
        Me.lblBack = New System.Windows.Forms.Label()
        Me.btnBlue = New System.Windows.Forms.Button()
        Me.txtPhrase = New System.Windows.Forms.TextBox()
        Me.btnWhite = New System.Windows.Forms.Button()
        Me.btnYellow = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFore = New System.Windows.Forms.Label()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRed
        '
        Me.btnRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRed.Location = New System.Drawing.Point(160, 16)
        Me.btnRed.Name = "btnRed"
        Me.btnRed.Size = New System.Drawing.Size(92, 40)
        Me.btnRed.TabIndex = 0
        Me.btnRed.Text = "Red"
        Me.btnRed.UseVisualStyleBackColor = True
        '
        'lblBack
        '
        Me.lblBack.AutoSize = True
        Me.lblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBack.Location = New System.Drawing.Point(24, 25)
        Me.lblBack.Name = "lblBack"
        Me.lblBack.Size = New System.Drawing.Size(95, 20)
        Me.lblBack.TabIndex = 1
        Me.lblBack.Text = "Background"
        '
        'btnBlue
        '
        Me.btnBlue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBlue.Location = New System.Drawing.Point(292, 15)
        Me.btnBlue.Name = "btnBlue"
        Me.btnBlue.Size = New System.Drawing.Size(92, 40)
        Me.btnBlue.TabIndex = 2
        Me.btnBlue.Text = "Blue"
        Me.btnBlue.UseVisualStyleBackColor = True
        '
        'txtPhrase
        '
        Me.txtPhrase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhrase.Location = New System.Drawing.Point(28, 81)
        Me.txtPhrase.Name = "txtPhrase"
        Me.txtPhrase.Size = New System.Drawing.Size(356, 26)
        Me.txtPhrase.TabIndex = 3
        Me.txtPhrase.Text = "Beautiful Day"
        Me.txtPhrase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnWhite
        '
        Me.btnWhite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWhite.Location = New System.Drawing.Point(160, 128)
        Me.btnWhite.Name = "btnWhite"
        Me.btnWhite.Size = New System.Drawing.Size(92, 40)
        Me.btnWhite.TabIndex = 4
        Me.btnWhite.Text = "White"
        Me.btnWhite.UseVisualStyleBackColor = True
        '
        'btnYellow
        '
        Me.btnYellow.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYellow.Location = New System.Drawing.Point(292, 128)
        Me.btnYellow.Name = "btnYellow"
        Me.btnYellow.Size = New System.Drawing.Size(92, 40)
        Me.btnYellow.TabIndex = 5
        Me.btnYellow.Text = "Yellow"
        Me.btnYellow.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(292, 192)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 40)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFore
        '
        Me.lblFore.AutoSize = True
        Me.lblFore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFore.Location = New System.Drawing.Point(24, 138)
        Me.lblFore.Name = "lblFore"
        Me.lblFore.Size = New System.Drawing.Size(92, 20)
        Me.lblFore.TabIndex = 7
        Me.lblFore.Text = "Foreground"
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBy.Location = New System.Drawing.Point(24, 202)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(225, 20)
        Me.lblDevBy.TabIndex = 8
        Me.lblDevBy.Text = "Developed by: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 261)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.lblFore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnYellow)
        Me.Controls.Add(Me.btnWhite)
        Me.Controls.Add(Me.txtPhrase)
        Me.Controls.Add(Me.btnBlue)
        Me.Controls.Add(Me.lblBack)
        Me.Controls.Add(Me.btnRed)
        Me.Name = "Form1"
        Me.Text = "Colorful Text"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRed As Button
    Friend WithEvents lblBack As Label
    Friend WithEvents btnBlue As Button
    Friend WithEvents txtPhrase As TextBox
    Friend WithEvents btnWhite As Button
    Friend WithEvents btnYellow As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFore As Label
    Friend WithEvents lblDevBy As Label
End Class
