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
        Me.lstBox = New System.Windows.Forms.ListBox()
        Me.btnPizzaStores = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.Font = New System.Drawing.Font("Courier New", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 32
        Me.lstBox.Location = New System.Drawing.Point(28, 12)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(567, 516)
        Me.lstBox.TabIndex = 0
        '
        'btnPizzaStores
        '
        Me.btnPizzaStores.Location = New System.Drawing.Point(90, 550)
        Me.btnPizzaStores.Name = "btnPizzaStores"
        Me.btnPizzaStores.Size = New System.Drawing.Size(448, 58)
        Me.btnPizzaStores.TabIndex = 1
        Me.btnPizzaStores.Text = "Pizza Company Stores"
        Me.btnPizzaStores.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(28, 628)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(232, 49)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(344, 628)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(251, 49)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 691)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Developed By: SIdney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 725)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPizzaStores)
        Me.Controls.Add(Me.lstBox)
        Me.Name = "Form1"
        Me.Text = "Pizza Company Stores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnPizzaStores As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
End Class
