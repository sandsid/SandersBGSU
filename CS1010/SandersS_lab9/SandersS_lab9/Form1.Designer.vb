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
        Me.lstRainData = New System.Windows.Forms.ListBox()
        Me.btnProcessRain = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstRainData
        '
        Me.lstRainData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRainData.FormattingEnabled = True
        Me.lstRainData.ItemHeight = 33
        Me.lstRainData.Location = New System.Drawing.Point(12, 12)
        Me.lstRainData.Name = "lstRainData"
        Me.lstRainData.Size = New System.Drawing.Size(730, 367)
        Me.lstRainData.TabIndex = 0
        '
        'btnProcessRain
        '
        Me.btnProcessRain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessRain.Location = New System.Drawing.Point(201, 394)
        Me.btnProcessRain.Name = "btnProcessRain"
        Me.btnProcessRain.Size = New System.Drawing.Size(332, 62)
        Me.btnProcessRain.TabIndex = 1
        Me.btnProcessRain.Text = "Process Rain Data"
        Me.btnProcessRain.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(98, 492)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(183, 57)
        Me.BtnClear.TabIndex = 2
        Me.BtnClear.Text = "Clear "
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(444, 492)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(183, 57)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 585)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.btnProcessRain)
        Me.Controls.Add(Me.lstRainData)
        Me.Name = "Form1"
        Me.Text = "Rain"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRainData As ListBox
    Friend WithEvents btnProcessRain As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents btnClose As Button
End Class
