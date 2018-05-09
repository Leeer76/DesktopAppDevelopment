<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class autoForm
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
        Me.principleLabel = New System.Windows.Forms.Label()
        Me.principleTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.interestTextBox = New System.Windows.Forms.TextBox()
        Me.downTextBox = New System.Windows.Forms.TextBox()
        Me.interestLabel = New System.Windows.Forms.Label()
        Me.downLabel = New System.Windows.Forms.Label()
        Me.paymentLabel = New System.Windows.Forms.Label()
        Me.paymentTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'principleLabel
        '
        Me.principleLabel.AutoSize = True
        Me.principleLabel.Location = New System.Drawing.Point(12, 28)
        Me.principleLabel.Name = "principleLabel"
        Me.principleLabel.Size = New System.Drawing.Size(69, 20)
        Me.principleLabel.TabIndex = 0
        Me.principleLabel.Text = "&Principle:"
        Me.principleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'principleTextBox
        '
        Me.principleTextBox.Location = New System.Drawing.Point(174, 25)
        Me.principleTextBox.Name = "principleTextBox"
        Me.principleTextBox.Size = New System.Drawing.Size(100, 27)
        Me.principleTextBox.TabIndex = 1
        Me.principleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calcButton
        '
        Me.calcButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.calcButton.Location = New System.Drawing.Point(16, 384)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(82, 29)
        Me.calcButton.TabIndex = 6
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(104, 384)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(82, 29)
        Me.resetButton.TabIndex = 7
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(192, 384)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(82, 29)
        Me.exitButton.TabIndex = 8
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'interestTextBox
        '
        Me.interestTextBox.Location = New System.Drawing.Point(174, 93)
        Me.interestTextBox.Name = "interestTextBox"
        Me.interestTextBox.Size = New System.Drawing.Size(100, 27)
        Me.interestTextBox.TabIndex = 5
        Me.interestTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'downTextBox
        '
        Me.downTextBox.Location = New System.Drawing.Point(174, 59)
        Me.downTextBox.Name = "downTextBox"
        Me.downTextBox.Size = New System.Drawing.Size(100, 27)
        Me.downTextBox.TabIndex = 3
        Me.downTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'interestLabel
        '
        Me.interestLabel.AutoSize = True
        Me.interestLabel.Location = New System.Drawing.Point(12, 96)
        Me.interestLabel.Name = "interestLabel"
        Me.interestLabel.Size = New System.Drawing.Size(91, 20)
        Me.interestLabel.TabIndex = 4
        Me.interestLabel.Text = "&Interest rate:"
        Me.interestLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'downLabel
        '
        Me.downLabel.AutoSize = True
        Me.downLabel.Location = New System.Drawing.Point(12, 62)
        Me.downLabel.Name = "downLabel"
        Me.downLabel.Size = New System.Drawing.Size(113, 20)
        Me.downLabel.TabIndex = 2
        Me.downLabel.Text = "&Down payment:"
        Me.downLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'paymentLabel
        '
        Me.paymentLabel.AutoSize = True
        Me.paymentLabel.Location = New System.Drawing.Point(12, 146)
        Me.paymentLabel.Name = "paymentLabel"
        Me.paymentLabel.Size = New System.Drawing.Size(122, 20)
        Me.paymentLabel.TabIndex = 9
        Me.paymentLabel.Text = "Payment options:"
        Me.paymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'paymentTextBox
        '
        Me.paymentTextBox.Location = New System.Drawing.Point(16, 169)
        Me.paymentTextBox.Multiline = True
        Me.paymentTextBox.Name = "paymentTextBox"
        Me.paymentTextBox.ReadOnly = True
        Me.paymentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.paymentTextBox.Size = New System.Drawing.Size(258, 195)
        Me.paymentTextBox.TabIndex = 10
        Me.paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'autoForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(294, 431)
        Me.Controls.Add(Me.paymentTextBox)
        Me.Controls.Add(Me.paymentLabel)
        Me.Controls.Add(Me.downLabel)
        Me.Controls.Add(Me.interestLabel)
        Me.Controls.Add(Me.downTextBox)
        Me.Controls.Add(Me.interestTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.principleTextBox)
        Me.Controls.Add(Me.principleLabel)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "autoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auto Loan Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents principleLabel As Label
    Friend WithEvents principleTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents interestTextBox As TextBox
    Friend WithEvents downTextBox As TextBox
    Friend WithEvents interestLabel As Label
    Friend WithEvents downLabel As Label
    Friend WithEvents paymentLabel As Label
    Friend WithEvents paymentTextBox As TextBox
End Class
