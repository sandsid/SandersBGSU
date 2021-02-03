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
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblDevBy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstBox
        '
        Me.lstBox.Font = New System.Drawing.Font("Courier New", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBox.FormattingEnabled = True
        Me.lstBox.ItemHeight = 30
        Me.lstBox.Location = New System.Drawing.Point(12, 34)
        Me.lstBox.Name = "lstBox"
        Me.lstBox.Size = New System.Drawing.Size(1036, 454)
        Me.lstBox.TabIndex = 0
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.Location = New System.Drawing.Point(277, 494)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(509, 62)
        Me.btnSalesReport.TabIndex = 1
        Me.btnSalesReport.Text = "Ad Sales Report"
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(215, 562)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(240, 58)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(618, 562)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(240, 58)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblDevBy
        '
        Me.lblDevBy.AutoSize = True
        Me.lblDevBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDevBy.Location = New System.Drawing.Point(339, 623)
        Me.lblDevBy.Name = "lblDevBy"
        Me.lblDevBy.Size = New System.Drawing.Size(389, 31)
        Me.lblDevBy.TabIndex = 4
        Me.lblDevBy.Text = "Developed By: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 664)
        Me.Controls.Add(Me.lblDevBy)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSalesReport)
        Me.Controls.Add(Me.lstBox)
        Me.Name = "Form1"
        Me.Text = "Ad Sales "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBox As ListBox
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDevBy As Label
End Class
