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
        Me.lstBoxATM = New System.Windows.Forms.ListBox()
        Me.lblStartingCash = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtStartCash = New System.Windows.Forms.TextBox()
        Me.btnRunATM = New System.Windows.Forms.Button()
        Me.lbldevby = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBoxATM
        '
        Me.lstBoxATM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBoxATM.FormattingEnabled = True
        Me.lstBoxATM.ItemHeight = 31
        Me.lstBoxATM.Location = New System.Drawing.Point(23, 12)
        Me.lstBoxATM.Name = "lstBoxATM"
        Me.lstBoxATM.Size = New System.Drawing.Size(647, 376)
        Me.lstBoxATM.TabIndex = 0
        '
        'lblStartingCash
        '
        Me.lblStartingCash.AutoSize = True
        Me.lblStartingCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingCash.Location = New System.Drawing.Point(17, 440)
        Me.lblStartingCash.Name = "lblStartingCash"
        Me.lblStartingCash.Size = New System.Drawing.Size(179, 31)
        Me.lblStartingCash.TabIndex = 1
        Me.lblStartingCash.Text = "Starting Cash"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(475, 431)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 55)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(475, 508)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 55)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtStartCash
        '
        Me.txtStartCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartCash.Location = New System.Drawing.Point(244, 440)
        Me.txtStartCash.Name = "txtStartCash"
        Me.txtStartCash.Size = New System.Drawing.Size(171, 38)
        Me.txtStartCash.TabIndex = 4
        '
        'btnRunATM
        '
        Me.btnRunATM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRunATM.Location = New System.Drawing.Point(28, 519)
        Me.btnRunATM.Name = "btnRunATM"
        Me.btnRunATM.Size = New System.Drawing.Size(395, 43)
        Me.btnRunATM.TabIndex = 5
        Me.btnRunATM.Text = "Run ATM machine"
        Me.btnRunATM.UseVisualStyleBackColor = True
        '
        'lbldevby
        '
        Me.lbldevby.AutoSize = True
        Me.lbldevby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldevby.Location = New System.Drawing.Point(22, 596)
        Me.lbldevby.Name = "lbldevby"
        Me.lbldevby.Size = New System.Drawing.Size(378, 31)
        Me.lbldevby.TabIndex = 6
        Me.lbldevby.Text = "Developed by Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 655)
        Me.Controls.Add(Me.lbldevby)
        Me.Controls.Add(Me.btnRunATM)
        Me.Controls.Add(Me.txtStartCash)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblStartingCash)
        Me.Controls.Add(Me.lstBoxATM)
        Me.Name = "Form1"
        Me.Text = "ATM Supply"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBoxATM As ListBox
    Friend WithEvents lblStartingCash As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtStartCash As TextBox
    Friend WithEvents btnRunATM As Button
    Friend WithEvents lbldevby As Label
End Class
