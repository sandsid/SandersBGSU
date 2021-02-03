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
        Me.lblNumBagels = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtNumBagels = New System.Windows.Forms.TextBox()
        Me.txtTotalCost = New System.Windows.Forms.TextBox()
        Me.btnTotalCostofBagels = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lbldevby = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblNumBagels
        '
        Me.lblNumBagels.AutoSize = True
        Me.lblNumBagels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumBagels.Location = New System.Drawing.Point(36, 46)
        Me.lblNumBagels.Name = "lblNumBagels"
        Me.lblNumBagels.Size = New System.Drawing.Size(274, 37)
        Me.lblNumBagels.TabIndex = 4
        Me.lblNumBagels.Text = "Number of Bagels"
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(36, 124)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(164, 37)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "Total Cost"
        '
        'txtNumBagels
        '
        Me.txtNumBagels.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumBagels.Location = New System.Drawing.Point(327, 43)
        Me.txtNumBagels.Name = "txtNumBagels"
        Me.txtNumBagels.Size = New System.Drawing.Size(244, 44)
        Me.txtNumBagels.TabIndex = 6
        '
        'txtTotalCost
        '
        Me.txtTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCost.Location = New System.Drawing.Point(327, 121)
        Me.txtTotalCost.Name = "txtTotalCost"
        Me.txtTotalCost.ReadOnly = True
        Me.txtTotalCost.Size = New System.Drawing.Size(244, 44)
        Me.txtTotalCost.TabIndex = 7
        '
        'btnTotalCostofBagels
        '
        Me.btnTotalCostofBagels.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTotalCostofBagels.Location = New System.Drawing.Point(34, 193)
        Me.btnTotalCostofBagels.Name = "btnTotalCostofBagels"
        Me.btnTotalCostofBagels.Size = New System.Drawing.Size(337, 56)
        Me.btnTotalCostofBagels.TabIndex = 8
        Me.btnTotalCostofBagels.Text = "Find Total Cost of Bagels"
        Me.btnTotalCostofBagels.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(404, 193)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(167, 56)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lbldevby
        '
        Me.lbldevby.AutoSize = True
        Me.lbldevby.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldevby.Location = New System.Drawing.Point(99, 276)
        Me.lbldevby.Name = "lbldevby"
        Me.lbldevby.Size = New System.Drawing.Size(389, 31)
        Me.lbldevby.TabIndex = 10
        Me.lbldevby.Text = "Developed By: Sidney Sanders"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 326)
        Me.Controls.Add(Me.lbldevby)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnTotalCostofBagels)
        Me.Controls.Add(Me.txtTotalCost)
        Me.Controls.Add(Me.txtNumBagels)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.lblNumBagels)
        Me.Name = "Form1"
        Me.Text = "Bagels Cost"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumBagels As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents txtNumBagels As TextBox
    Friend WithEvents txtTotalCost As TextBox
    Friend WithEvents btnTotalCostofBagels As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbldevby As Label
End Class
