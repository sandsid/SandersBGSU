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
        Me.txtCloudCoverage = New System.Windows.Forms.TextBox()
        Me.txtWeatherD = New System.Windows.Forms.TextBox()
        Me.lblCloudCoverage = New System.Windows.Forms.Label()
        Me.lblWeatherD = New System.Windows.Forms.Label()
        Me.btnCloudConditions = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCloudCoverage
        '
        Me.txtCloudCoverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCloudCoverage.Location = New System.Drawing.Point(513, 38)
        Me.txtCloudCoverage.Name = "txtCloudCoverage"
        Me.txtCloudCoverage.Size = New System.Drawing.Size(244, 44)
        Me.txtCloudCoverage.TabIndex = 7
        '
        'txtWeatherD
        '
        Me.txtWeatherD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeatherD.Location = New System.Drawing.Point(513, 127)
        Me.txtWeatherD.Name = "txtWeatherD"
        Me.txtWeatherD.ReadOnly = True
        Me.txtWeatherD.Size = New System.Drawing.Size(244, 44)
        Me.txtWeatherD.TabIndex = 8
        '
        'lblCloudCoverage
        '
        Me.lblCloudCoverage.AutoSize = True
        Me.lblCloudCoverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCloudCoverage.Location = New System.Drawing.Point(22, 41)
        Me.lblCloudCoverage.Name = "lblCloudCoverage"
        Me.lblCloudCoverage.Size = New System.Drawing.Size(454, 37)
        Me.lblCloudCoverage.TabIndex = 9
        Me.lblCloudCoverage.Text = "Percentage of Cloud Coverage"
        '
        'lblWeatherD
        '
        Me.lblWeatherD.AutoSize = True
        Me.lblWeatherD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeatherD.Location = New System.Drawing.Point(22, 130)
        Me.lblWeatherD.Name = "lblWeatherD"
        Me.lblWeatherD.Size = New System.Drawing.Size(293, 37)
        Me.lblWeatherD.TabIndex = 10
        Me.lblWeatherD.Text = "Weather Descriptor"
        '
        'btnCloudConditions
        '
        Me.btnCloudConditions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloudConditions.Location = New System.Drawing.Point(37, 226)
        Me.btnCloudConditions.Name = "btnCloudConditions"
        Me.btnCloudConditions.Size = New System.Drawing.Size(509, 59)
        Me.btnCloudConditions.TabIndex = 11
        Me.btnCloudConditions.Text = "Cloud conditions"
        Me.btnCloudConditions.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(576, 226)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(197, 59)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBy.Location = New System.Drawing.Point(153, 318)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(454, 37)
        Me.lblDevBy.TabIndex = 13
        Me.lblDevBy.Text = "Developed By: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 381)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCloudConditions)
        Me.Controls.Add(Me.lblWeatherD)
        Me.Controls.Add(Me.lblCloudCoverage)
        Me.Controls.Add(Me.txtWeatherD)
        Me.Controls.Add(Me.txtCloudCoverage)
        Me.Name = "Form1"
        Me.Text = "Cloud Cover"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCloudCoverage As TextBox
    Friend WithEvents txtWeatherD As TextBox
    Friend WithEvents lblCloudCoverage As Label
    Friend WithEvents lblWeatherD As Label
    Friend WithEvents btnCloudConditions As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDevBy As Label
End Class
