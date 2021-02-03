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
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.lblDistance = New System.Windows.Forms.Label()
        Me.txtNumSeconds = New System.Windows.Forms.TextBox()
        Me.txtDistanceMiles = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.Location = New System.Drawing.Point(16, 20)
        Me.lblSeconds.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(424, 74)
        Me.lblSeconds.TabIndex = 0
        Me.lblSeconds.Text = "Number of seconds between" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Lightning and thinder"
        '
        'lblDistance
        '
        Me.lblDistance.AutoSize = True
        Me.lblDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistance.Location = New System.Drawing.Point(16, 78)
        Me.lblDistance.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDistance.Name = "lblDistance"
        Me.lblDistance.Size = New System.Drawing.Size(413, 74)
        Me.lblDistance.TabIndex = 1
        Me.lblDistance.Text = "The distance of the storm in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "miles"
        '
        'txtNumSeconds
        '
        Me.txtNumSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumSeconds.Location = New System.Drawing.Point(427, 20)
        Me.txtNumSeconds.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumSeconds.Name = "txtNumSeconds"
        Me.txtNumSeconds.Size = New System.Drawing.Size(173, 44)
        Me.txtNumSeconds.TabIndex = 2
        '
        'txtDistanceMiles
        '
        Me.txtDistanceMiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistanceMiles.Location = New System.Drawing.Point(427, 98)
        Me.txtDistanceMiles.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDistanceMiles.Name = "txtDistanceMiles"
        Me.txtDistanceMiles.ReadOnly = True
        Me.txtDistanceMiles.Size = New System.Drawing.Size(173, 44)
        Me.txtDistanceMiles.TabIndex = 3
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(75, 208)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(354, 43)
        Me.btnCompute.TabIndex = 4
        Me.btnCompute.Text = "Compute Distance"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBy.Location = New System.Drawing.Point(89, 294)
        Me.lblDevBy.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(454, 37)
        Me.lblDevBy.TabIndex = 5
        Me.lblDevBy.Text = "Developed By: Sidney Sanders"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(478, 208)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(122, 51)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(15.0!, 30.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 374)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtDistanceMiles)
        Me.Controls.Add(Me.txtNumSeconds)
        Me.Controls.Add(Me.lblDistance)
        Me.Controls.Add(Me.lblSeconds)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Thunder and Lightning"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSeconds As Label
    Friend WithEvents lblDistance As Label
    Friend WithEvents txtNumSeconds As TextBox
    Friend WithEvents txtDistanceMiles As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblDevBy As Label
    Friend WithEvents btnClose As Button
End Class
