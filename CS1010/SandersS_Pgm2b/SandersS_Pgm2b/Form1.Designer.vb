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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtHoursCycling = New System.Windows.Forms.TextBox()
        Me.txtHoursRunning = New System.Windows.Forms.TextBox()
        Me.txtHoursSwimming = New System.Windows.Forms.TextBox()
        Me.txtCaloriesBurned = New System.Windows.Forms.TextBox()
        Me.txtPoundsLost = New System.Windows.Forms.TextBox()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Number of hours cycling"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of hours running"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Number of hours swimming"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 231)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Total calories burned"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 283)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pounds Lost"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(31, 428)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(223, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Developed By:Sidney Sanders"
        '
        'txtHoursCycling
        '
        Me.txtHoursCycling.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursCycling.Location = New System.Drawing.Point(345, 22)
        Me.txtHoursCycling.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoursCycling.Name = "txtHoursCycling"
        Me.txtHoursCycling.Size = New System.Drawing.Size(233, 26)
        Me.txtHoursCycling.TabIndex = 6
        '
        'txtHoursRunning
        '
        Me.txtHoursRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursRunning.Location = New System.Drawing.Point(345, 78)
        Me.txtHoursRunning.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoursRunning.Name = "txtHoursRunning"
        Me.txtHoursRunning.Size = New System.Drawing.Size(233, 26)
        Me.txtHoursRunning.TabIndex = 7
        '
        'txtHoursSwimming
        '
        Me.txtHoursSwimming.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHoursSwimming.Location = New System.Drawing.Point(345, 132)
        Me.txtHoursSwimming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtHoursSwimming.Name = "txtHoursSwimming"
        Me.txtHoursSwimming.Size = New System.Drawing.Size(233, 26)
        Me.txtHoursSwimming.TabIndex = 8
        '
        'txtCaloriesBurned
        '
        Me.txtCaloriesBurned.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCaloriesBurned.Location = New System.Drawing.Point(345, 228)
        Me.txtCaloriesBurned.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCaloriesBurned.Name = "txtCaloriesBurned"
        Me.txtCaloriesBurned.ReadOnly = True
        Me.txtCaloriesBurned.Size = New System.Drawing.Size(233, 26)
        Me.txtCaloriesBurned.TabIndex = 9
        '
        'txtPoundsLost
        '
        Me.txtPoundsLost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPoundsLost.Location = New System.Drawing.Point(345, 279)
        Me.txtPoundsLost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPoundsLost.Name = "txtPoundsLost"
        Me.txtPoundsLost.ReadOnly = True
        Me.txtPoundsLost.Size = New System.Drawing.Size(233, 26)
        Me.txtPoundsLost.TabIndex = 10
        '
        'btnCompute
        '
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.Location = New System.Drawing.Point(44, 336)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(515, 57)
        Me.btnCompute.TabIndex = 11
        Me.btnCompute.Text = "Compute Weight Loss"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(379, 421)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(180, 42)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 486)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.txtPoundsLost)
        Me.Controls.Add(Me.txtCaloriesBurned)
        Me.Controls.Add(Me.txtHoursSwimming)
        Me.Controls.Add(Me.txtHoursRunning)
        Me.Controls.Add(Me.txtHoursCycling)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Triathlon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtHoursCycling As TextBox
    Friend WithEvents txtHoursRunning As TextBox
    Friend WithEvents txtHoursSwimming As TextBox
    Friend WithEvents txtCaloriesBurned As TextBox
    Friend WithEvents txtPoundsLost As TextBox
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClose As Button
End Class
