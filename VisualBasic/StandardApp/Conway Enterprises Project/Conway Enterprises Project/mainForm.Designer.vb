<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.domesticLabel = New System.Windows.Forms.Label()
        Me.displayButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.intLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.domesticTotalLabel = New System.Windows.Forms.Label()
        Me.intTotalLabel = New System.Windows.Forms.Label()
        Me.grandTotalLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'domesticLabel
        '
        Me.domesticLabel.AutoSize = True
        Me.domesticLabel.Location = New System.Drawing.Point(47, 53)
        Me.domesticLabel.Name = "domesticLabel"
        Me.domesticLabel.Size = New System.Drawing.Size(110, 20)
        Me.domesticLabel.TabIndex = 2
        Me.domesticLabel.Text = "Total domestic:"
        Me.domesticLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'displayButton
        '
        Me.displayButton.Location = New System.Drawing.Point(107, 270)
        Me.displayButton.Name = "displayButton"
        Me.displayButton.Size = New System.Drawing.Size(129, 33)
        Me.displayButton.TabIndex = 0
        Me.displayButton.Text = "&Display Totals"
        Me.displayButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(242, 270)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(129, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'intLabel
        '
        Me.intLabel.AutoSize = True
        Me.intLabel.Location = New System.Drawing.Point(47, 127)
        Me.intLabel.Name = "intLabel"
        Me.intLabel.Size = New System.Drawing.Size(133, 20)
        Me.intLabel.TabIndex = 4
        Me.intLabel.Text = "Total international:"
        Me.intLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(47, 197)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(110, 20)
        Me.totalLabel.TabIndex = 6
        Me.totalLabel.Text = "Total company:"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'domesticTotalLabel
        '
        Me.domesticTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.domesticTotalLabel.Location = New System.Drawing.Point(186, 43)
        Me.domesticTotalLabel.Name = "domesticTotalLabel"
        Me.domesticTotalLabel.Size = New System.Drawing.Size(185, 41)
        Me.domesticTotalLabel.TabIndex = 3
        Me.domesticTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intTotalLabel
        '
        Me.intTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.intTotalLabel.Location = New System.Drawing.Point(186, 117)
        Me.intTotalLabel.Name = "intTotalLabel"
        Me.intTotalLabel.Size = New System.Drawing.Size(185, 41)
        Me.intTotalLabel.TabIndex = 5
        Me.intTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grandTotalLabel
        '
        Me.grandTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grandTotalLabel.Location = New System.Drawing.Point(186, 187)
        Me.grandTotalLabel.Name = "grandTotalLabel"
        Me.grandTotalLabel.Size = New System.Drawing.Size(185, 41)
        Me.grandTotalLabel.TabIndex = 7
        Me.grandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mainForm
        '
        Me.AcceptButton = Me.displayButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(422, 342)
        Me.Controls.Add(Me.grandTotalLabel)
        Me.Controls.Add(Me.intTotalLabel)
        Me.Controls.Add(Me.domesticTotalLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.intLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.displayButton)
        Me.Controls.Add(Me.domesticLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conway Enterprises"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents domesticLabel As Label
    Friend WithEvents displayButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents intLabel As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents domesticTotalLabel As Label
    Friend WithEvents intTotalLabel As Label
    Friend WithEvents grandTotalLabel As Label
End Class
