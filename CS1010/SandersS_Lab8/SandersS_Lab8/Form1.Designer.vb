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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblBMI = New System.Windows.Forms.Label()
        Me.lblRisk = New System.Windows.Forms.Label()
        Me.lblInterp = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.txtBMI = New System.Windows.Forms.TextBox()
        Me.txtRisk = New System.Windows.Forms.TextBox()
        Me.txtInterp = New System.Windows.Forms.TextBox()
        Me.lblBonus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(197, 533)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(196, 52)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(60, 441)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(474, 66)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate Body Mass Index"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBy.Location = New System.Drawing.Point(95, 598)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(389, 31)
        Me.lblDevBy.TabIndex = 2
        Me.lblDevBy.Text = "Developed By: Sidney Sanders"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(24, 39)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(245, 31)
        Me.lblWeight.TabIndex = 3
        Me.lblWeight.Text = "Weight (In Pounds)"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.Location = New System.Drawing.Point(24, 121)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(229, 31)
        Me.lblHeight.TabIndex = 4
        Me.lblHeight.Text = "Height (In Inches)"
        '
        'lblBMI
        '
        Me.lblBMI.AutoSize = True
        Me.lblBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMI.Location = New System.Drawing.Point(24, 200)
        Me.lblBMI.Name = "lblBMI"
        Me.lblBMI.Size = New System.Drawing.Size(221, 31)
        Me.lblBMI.TabIndex = 5
        Me.lblBMI.Text = "Body Mass Index"
        '
        'lblRisk
        '
        Me.lblRisk.AutoSize = True
        Me.lblRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRisk.Location = New System.Drawing.Point(24, 287)
        Me.lblRisk.Name = "lblRisk"
        Me.lblRisk.Size = New System.Drawing.Size(193, 31)
        Me.lblRisk.TabIndex = 6
        Me.lblRisk.Text = "Risk Category "
        '
        'lblInterp
        '
        Me.lblInterp.AutoSize = True
        Me.lblInterp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterp.Location = New System.Drawing.Point(24, 375)
        Me.lblInterp.Name = "lblInterp"
        Me.lblInterp.Size = New System.Drawing.Size(175, 31)
        Me.lblInterp.TabIndex = 7
        Me.lblInterp.Text = "Interpretation"
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(337, 39)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(222, 38)
        Me.txtWeight.TabIndex = 8
        '
        'txtHeight
        '
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(337, 114)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(222, 38)
        Me.txtHeight.TabIndex = 9
        '
        'txtBMI
        '
        Me.txtBMI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMI.Location = New System.Drawing.Point(337, 200)
        Me.txtBMI.Name = "txtBMI"
        Me.txtBMI.ReadOnly = True
        Me.txtBMI.Size = New System.Drawing.Size(222, 38)
        Me.txtBMI.TabIndex = 10
        '
        'txtRisk
        '
        Me.txtRisk.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRisk.Location = New System.Drawing.Point(337, 284)
        Me.txtRisk.Name = "txtRisk"
        Me.txtRisk.ReadOnly = True
        Me.txtRisk.Size = New System.Drawing.Size(222, 38)
        Me.txtRisk.TabIndex = 11
        '
        'txtInterp
        '
        Me.txtInterp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterp.Location = New System.Drawing.Point(337, 372)
        Me.txtInterp.Name = "txtInterp"
        Me.txtInterp.ReadOnly = True
        Me.txtInterp.Size = New System.Drawing.Size(222, 38)
        Me.txtInterp.TabIndex = 12
        '
        'lblBonus
        '
        Me.lblBonus.AutoSize = True
        Me.lblBonus.Location = New System.Drawing.Point(25, 643)
        Me.lblBonus.Name = "lblBonus"
        Me.lblBonus.Size = New System.Drawing.Size(135, 25)
        Me.lblBonus.TabIndex = 13
        Me.lblBonus.Text = "Doing Bonus"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 694)
        Me.Controls.Add(Me.lblBonus)
        Me.Controls.Add(Me.txtInterp)
        Me.Controls.Add(Me.txtRisk)
        Me.Controls.Add(Me.txtBMI)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.lblInterp)
        Me.Controls.Add(Me.lblRisk)
        Me.Controls.Add(Me.lblBMI)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.Text = "Body Mass Index"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblDevBy As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblBMI As Label
    Friend WithEvents lblRisk As Label
    Friend WithEvents lblInterp As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtBMI As TextBox
    Friend WithEvents txtRisk As TextBox
    Friend WithEvents txtInterp As TextBox
    Friend WithEvents lblBonus As Label
End Class
