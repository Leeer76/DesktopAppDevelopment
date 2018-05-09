<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cableForm
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
        Me.calcButton = New System.Windows.Forms.Button()
        Me.businessRadioButton = New System.Windows.Forms.RadioButton()
        Me.residentRadioButton = New System.Windows.Forms.RadioButton()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.outPutLabel = New System.Windows.Forms.Label()
        Me.premiumChanLabel = New System.Windows.Forms.Label()
        Me.connectionsLabel = New System.Windows.Forms.Label()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.premiumchannelsListBox = New System.Windows.Forms.ListBox()
        Me.connectionsListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(163, 179)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(160, 32)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "Calculate Total &Due"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'businessRadioButton
        '
        Me.businessRadioButton.AutoSize = True
        Me.businessRadioButton.Checked = True
        Me.businessRadioButton.Location = New System.Drawing.Point(12, 12)
        Me.businessRadioButton.Name = "businessRadioButton"
        Me.businessRadioButton.Size = New System.Drawing.Size(85, 24)
        Me.businessRadioButton.TabIndex = 0
        Me.businessRadioButton.TabStop = True
        Me.businessRadioButton.Text = "&Business"
        Me.businessRadioButton.UseVisualStyleBackColor = True
        '
        'residentRadioButton
        '
        Me.residentRadioButton.AutoSize = True
        Me.residentRadioButton.Location = New System.Drawing.Point(12, 42)
        Me.residentRadioButton.Name = "residentRadioButton"
        Me.residentRadioButton.Size = New System.Drawing.Size(103, 24)
        Me.residentRadioButton.TabIndex = 1
        Me.residentRadioButton.TabStop = True
        Me.residentRadioButton.Text = "&Residential"
        Me.residentRadioButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(334, 179)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 32)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'outPutLabel
        '
        Me.outPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outPutLabel.Location = New System.Drawing.Point(12, 179)
        Me.outPutLabel.Name = "outPutLabel"
        Me.outPutLabel.Size = New System.Drawing.Size(122, 32)
        Me.outPutLabel.TabIndex = 9
        Me.outPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'premiumChanLabel
        '
        Me.premiumChanLabel.AutoSize = True
        Me.premiumChanLabel.Location = New System.Drawing.Point(159, 14)
        Me.premiumChanLabel.Name = "premiumChanLabel"
        Me.premiumChanLabel.Size = New System.Drawing.Size(132, 20)
        Me.premiumChanLabel.TabIndex = 2
        Me.premiumChanLabel.Text = "&Premium channels:"
        Me.premiumChanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'connectionsLabel
        '
        Me.connectionsLabel.AutoSize = True
        Me.connectionsLabel.Location = New System.Drawing.Point(330, 14)
        Me.connectionsLabel.Name = "connectionsLabel"
        Me.connectionsLabel.Size = New System.Drawing.Size(93, 20)
        Me.connectionsLabel.TabIndex = 4
        Me.connectionsLabel.Text = "&Connections:"
        Me.connectionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'totalLabel
        '
        Me.totalLabel.AutoSize = True
        Me.totalLabel.Location = New System.Drawing.Point(12, 159)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(74, 20)
        Me.totalLabel.TabIndex = 8
        Me.totalLabel.Text = "Total due:"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'premiumchannelsListBox
        '
        Me.premiumchannelsListBox.FormattingEnabled = True
        Me.premiumchannelsListBox.ItemHeight = 20
        Me.premiumchannelsListBox.Location = New System.Drawing.Point(163, 37)
        Me.premiumchannelsListBox.Name = "premiumchannelsListBox"
        Me.premiumchannelsListBox.Size = New System.Drawing.Size(71, 84)
        Me.premiumchannelsListBox.TabIndex = 3
        '
        'connectionsListBox
        '
        Me.connectionsListBox.FormattingEnabled = True
        Me.connectionsListBox.ItemHeight = 20
        Me.connectionsListBox.Location = New System.Drawing.Point(334, 37)
        Me.connectionsListBox.Name = "connectionsListBox"
        Me.connectionsListBox.Size = New System.Drawing.Size(71, 84)
        Me.connectionsListBox.TabIndex = 5
        '
        'cableForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(453, 237)
        Me.Controls.Add(Me.connectionsListBox)
        Me.Controls.Add(Me.premiumchannelsListBox)
        Me.Controls.Add(Me.outPutLabel)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.connectionsLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.residentRadioButton)
        Me.Controls.Add(Me.businessRadioButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.premiumChanLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "cableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cable Direct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents calcButton As Button
    Friend WithEvents businessRadioButton As RadioButton
    Friend WithEvents residentRadioButton As RadioButton
    Friend WithEvents exitButton As Button
    Friend WithEvents outPutLabel As Label
    Friend WithEvents premiumChanLabel As Label
    Friend WithEvents connectionsLabel As Label
    Friend WithEvents totalLabel As Label
    Friend WithEvents premiumchannelsListBox As ListBox
    Friend WithEvents connectionsListBox As ListBox
End Class
