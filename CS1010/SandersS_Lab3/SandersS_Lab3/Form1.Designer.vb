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
        Me.txtChangeAmount = New System.Windows.Forms.TextBox()
        Me.txtQuarters = New System.Windows.Forms.TextBox()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.txtNickels = New System.Windows.Forms.TextBox()
        Me.txtDimes = New System.Windows.Forms.TextBox()
        Me.lblEnterAmount = New System.Windows.Forms.Label()
        Me.lblQuarters = New System.Windows.Forms.Label()
        Me.lblPennies = New System.Windows.Forms.Label()
        Me.lblNickels = New System.Windows.Forms.Label()
        Me.lblDimes = New System.Windows.Forms.Label()
        Me.btnCoinsNeeded = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtChangeAmount
        '
        Me.txtChangeAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeAmount.Location = New System.Drawing.Point(401, 33)
        Me.txtChangeAmount.Name = "txtChangeAmount"
        Me.txtChangeAmount.Size = New System.Drawing.Size(188, 44)
        Me.txtChangeAmount.TabIndex = 4
        '
        'txtQuarters
        '
        Me.txtQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuarters.Location = New System.Drawing.Point(401, 128)
        Me.txtQuarters.Name = "txtQuarters"
        Me.txtQuarters.ReadOnly = True
        Me.txtQuarters.Size = New System.Drawing.Size(188, 44)
        Me.txtQuarters.TabIndex = 7
        '
        'txtPennies
        '
        Me.txtPennies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPennies.Location = New System.Drawing.Point(401, 365)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.ReadOnly = True
        Me.txtPennies.Size = New System.Drawing.Size(188, 44)
        Me.txtPennies.TabIndex = 8
        '
        'txtNickels
        '
        Me.txtNickels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNickels.Location = New System.Drawing.Point(401, 284)
        Me.txtNickels.Name = "txtNickels"
        Me.txtNickels.ReadOnly = True
        Me.txtNickels.Size = New System.Drawing.Size(188, 44)
        Me.txtNickels.TabIndex = 9
        '
        'txtDimes
        '
        Me.txtDimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimes.Location = New System.Drawing.Point(401, 210)
        Me.txtDimes.Name = "txtDimes"
        Me.txtDimes.ReadOnly = True
        Me.txtDimes.Size = New System.Drawing.Size(188, 44)
        Me.txtDimes.TabIndex = 10
        '
        'lblEnterAmount
        '
        Me.lblEnterAmount.AutoSize = True
        Me.lblEnterAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterAmount.Location = New System.Drawing.Point(12, 33)
        Me.lblEnterAmount.Name = "lblEnterAmount"
        Me.lblEnterAmount.Size = New System.Drawing.Size(364, 74)
        Me.lblEnterAmount.TabIndex = 11
        Me.lblEnterAmount.Text = "Enter Amount of change" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "nedded (1-99 cents)"
        '
        'lblQuarters
        '
        Me.lblQuarters.AutoSize = True
        Me.lblQuarters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuarters.Location = New System.Drawing.Point(12, 131)
        Me.lblQuarters.Name = "lblQuarters"
        Me.lblQuarters.Size = New System.Drawing.Size(142, 37)
        Me.lblQuarters.TabIndex = 12
        Me.lblQuarters.Text = "Quarters"
        '
        'lblPennies
        '
        Me.lblPennies.AutoSize = True
        Me.lblPennies.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPennies.Location = New System.Drawing.Point(12, 368)
        Me.lblPennies.Name = "lblPennies"
        Me.lblPennies.Size = New System.Drawing.Size(131, 37)
        Me.lblPennies.TabIndex = 13
        Me.lblPennies.Text = "Pennies"
        '
        'lblNickels
        '
        Me.lblNickels.AutoSize = True
        Me.lblNickels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNickels.Location = New System.Drawing.Point(12, 287)
        Me.lblNickels.Name = "lblNickels"
        Me.lblNickels.Size = New System.Drawing.Size(120, 37)
        Me.lblNickels.TabIndex = 14
        Me.lblNickels.Text = "Nickels"
        '
        'lblDimes
        '
        Me.lblDimes.AutoSize = True
        Me.lblDimes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDimes.Location = New System.Drawing.Point(12, 213)
        Me.lblDimes.Name = "lblDimes"
        Me.lblDimes.Size = New System.Drawing.Size(107, 37)
        Me.lblDimes.TabIndex = 15
        Me.lblDimes.Text = "Dimes"
        '
        'btnCoinsNeeded
        '
        Me.btnCoinsNeeded.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCoinsNeeded.Location = New System.Drawing.Point(116, 450)
        Me.btnCoinsNeeded.Name = "btnCoinsNeeded"
        Me.btnCoinsNeeded.Size = New System.Drawing.Size(382, 64)
        Me.btnCoinsNeeded.TabIndex = 16
        Me.btnCoinsNeeded.Text = "Find coins needed"
        Me.btnCoinsNeeded.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 526)
        Me.Controls.Add(Me.btnCoinsNeeded)
        Me.Controls.Add(Me.lblDimes)
        Me.Controls.Add(Me.lblNickels)
        Me.Controls.Add(Me.lblPennies)
        Me.Controls.Add(Me.lblQuarters)
        Me.Controls.Add(Me.lblEnterAmount)
        Me.Controls.Add(Me.txtDimes)
        Me.Controls.Add(Me.txtNickels)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.txtQuarters)
        Me.Controls.Add(Me.txtChangeAmount)
        Me.Name = "Form1"
        Me.Text = "Make Change"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtChangeAmount As TextBox
    Friend WithEvents txtQuarters As TextBox
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents txtNickels As TextBox
    Friend WithEvents txtDimes As TextBox
    Friend WithEvents lblEnterAmount As Label
    Friend WithEvents lblQuarters As Label
    Friend WithEvents lblPennies As Label
    Friend WithEvents lblNickels As Label
    Friend WithEvents lblDimes As Label
    Friend WithEvents btnCoinsNeeded As Button
End Class
