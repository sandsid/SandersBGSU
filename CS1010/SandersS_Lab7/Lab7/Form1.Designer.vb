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
        Me.lstCityPops = New System.Windows.Forms.ListBox()
        Me.btnShowPop = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstCityPops
        '
        Me.lstCityPops.FormattingEnabled = True
        Me.lstCityPops.ItemHeight = 25
        Me.lstCityPops.Location = New System.Drawing.Point(0, 0)
        Me.lstCityPops.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstCityPops.Name = "lstCityPops"
        Me.lstCityPops.Size = New System.Drawing.Size(558, 379)
        Me.lstCityPops.TabIndex = 0
        '
        'btnShowPop
        '
        Me.btnShowPop.Location = New System.Drawing.Point(24, 410)
        Me.btnShowPop.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnShowPop.Name = "btnShowPop"
        Me.btnShowPop.Size = New System.Drawing.Size(262, 44)
        Me.btnShowPop.TabIndex = 1
        Me.btnShowPop.Text = "Display city populations"
        Me.btnShowPop.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(356, 410)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(150, 44)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Location = New System.Drawing.Point(66, 460)
        Me.lblDevBy.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(308, 25)
        Me.lblDevBy.TabIndex = 3
        Me.lblDevBy.Text = "Developed by: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 502)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnShowPop)
        Me.Controls.Add(Me.lstCityPops)
        Me.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.Name = "Form1"
        Me.Text = "City Population"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstCityPops As ListBox
    Friend WithEvents btnShowPop As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDevBy As Label
End Class
