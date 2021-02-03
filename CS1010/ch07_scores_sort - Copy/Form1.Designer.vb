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
        Me.btnGetScores = New System.Windows.Forms.Button()
        Me.lstScores = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnGetScores
        '
        Me.btnGetScores.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetScores.Location = New System.Drawing.Point(177, 448)
        Me.btnGetScores.Name = "btnGetScores"
        Me.btnGetScores.Size = New System.Drawing.Size(204, 33)
        Me.btnGetScores.TabIndex = 0
        Me.btnGetScores.Text = "Get scores"
        Me.btnGetScores.UseVisualStyleBackColor = True
        '
        'lstScores
        '
        Me.lstScores.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScores.FormattingEnabled = True
        Me.lstScores.ItemHeight = 23
        Me.lstScores.Location = New System.Drawing.Point(12, 12)
        Me.lstScores.Name = "lstScores"
        Me.lstScores.Size = New System.Drawing.Size(517, 418)
        Me.lstScores.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 493)
        Me.Controls.Add(Me.lstScores)
        Me.Controls.Add(Me.btnGetScores)
        Me.Name = "Form1"
        Me.Text = "Test Scores"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnGetScores As System.Windows.Forms.Button
    Friend WithEvents lstScores As System.Windows.Forms.ListBox

End Class
