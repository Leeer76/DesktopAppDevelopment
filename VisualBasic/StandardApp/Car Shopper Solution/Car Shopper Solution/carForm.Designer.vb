<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carForm
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
        Me.priceLabel = New System.Windows.Forms.Label()
        Me.priceTextBox = New System.Windows.Forms.TextBox()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dealerLabel = New System.Windows.Forms.Label()
        Me.bankRateLabel = New System.Windows.Forms.Label()
        Me.termLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.rebateTextBox = New System.Windows.Forms.TextBox()
        Me.dealerRateComboBox = New System.Windows.Forms.ComboBox()
        Me.bankRateComboBox = New System.Windows.Forms.ComboBox()
        Me.termComboBox = New System.Windows.Forms.ComboBox()
        Me.dealerOutPutLabel = New System.Windows.Forms.Label()
        Me.bankOutPutLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(204, 218)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(95, 33)
        Me.calcButton.TabIndex = 10
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'priceLabel
        '
        Me.priceLabel.AutoSize = True
        Me.priceLabel.Location = New System.Drawing.Point(12, 9)
        Me.priceLabel.Name = "priceLabel"
        Me.priceLabel.Size = New System.Drawing.Size(44, 20)
        Me.priceLabel.TabIndex = 0
        Me.priceLabel.Text = "&Price:"
        Me.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'priceTextBox
        '
        Me.priceTextBox.Location = New System.Drawing.Point(12, 32)
        Me.priceTextBox.Name = "priceTextBox"
        Me.priceTextBox.Size = New System.Drawing.Size(83, 27)
        Me.priceTextBox.TabIndex = 1
        Me.priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(305, 218)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(95, 33)
        Me.resetButton.TabIndex = 11
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(406, 218)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(95, 33)
        Me.exitButton.TabIndex = 12
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Re&bate:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dealerLabel
        '
        Me.dealerLabel.AutoSize = True
        Me.dealerLabel.Location = New System.Drawing.Point(240, 9)
        Me.dealerLabel.Name = "dealerLabel"
        Me.dealerLabel.Size = New System.Drawing.Size(86, 20)
        Me.dealerLabel.TabIndex = 4
        Me.dealerLabel.Text = "&Dealer rate:"
        Me.dealerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bankRateLabel
        '
        Me.bankRateLabel.AutoSize = True
        Me.bankRateLabel.Location = New System.Drawing.Point(329, 9)
        Me.bankRateLabel.Name = "bankRateLabel"
        Me.bankRateLabel.Size = New System.Drawing.Size(74, 20)
        Me.bankRateLabel.TabIndex = 6
        Me.bankRateLabel.Text = "&Bank rate:"
        Me.bankRateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'termLabel
        '
        Me.termLabel.AutoSize = True
        Me.termLabel.Location = New System.Drawing.Point(418, 8)
        Me.termLabel.Name = "termLabel"
        Me.termLabel.Size = New System.Drawing.Size(93, 20)
        Me.termLabel.TabIndex = 8
        Me.termLabel.Text = "&Term (years):"
        Me.termLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(101, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dealer monthly payment:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(283, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Bank monthly payment:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rebateTextBox
        '
        Me.rebateTextBox.Location = New System.Drawing.Point(101, 32)
        Me.rebateTextBox.Name = "rebateTextBox"
        Me.rebateTextBox.Size = New System.Drawing.Size(83, 27)
        Me.rebateTextBox.TabIndex = 3
        Me.rebateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dealerRateComboBox
        '
        Me.dealerRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.dealerRateComboBox.FormattingEnabled = True
        Me.dealerRateComboBox.Location = New System.Drawing.Point(240, 31)
        Me.dealerRateComboBox.Name = "dealerRateComboBox"
        Me.dealerRateComboBox.Size = New System.Drawing.Size(83, 28)
        Me.dealerRateComboBox.TabIndex = 5
        '
        'bankRateComboBox
        '
        Me.bankRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.bankRateComboBox.FormattingEnabled = True
        Me.bankRateComboBox.Location = New System.Drawing.Point(329, 31)
        Me.bankRateComboBox.Name = "bankRateComboBox"
        Me.bankRateComboBox.Size = New System.Drawing.Size(83, 28)
        Me.bankRateComboBox.TabIndex = 7
        '
        'termComboBox
        '
        Me.termComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.termComboBox.FormattingEnabled = True
        Me.termComboBox.Location = New System.Drawing.Point(418, 31)
        Me.termComboBox.Name = "termComboBox"
        Me.termComboBox.Size = New System.Drawing.Size(83, 28)
        Me.termComboBox.TabIndex = 9
        '
        'dealerOutPutLabel
        '
        Me.dealerOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dealerOutPutLabel.Location = New System.Drawing.Point(101, 126)
        Me.dealerOutPutLabel.Name = "dealerOutPutLabel"
        Me.dealerOutPutLabel.Size = New System.Drawing.Size(168, 36)
        Me.dealerOutPutLabel.TabIndex = 14
        Me.dealerOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bankOutPutLabel
        '
        Me.bankOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bankOutPutLabel.Location = New System.Drawing.Point(283, 126)
        Me.bankOutPutLabel.Name = "bankOutPutLabel"
        Me.bankOutPutLabel.Size = New System.Drawing.Size(168, 36)
        Me.bankOutPutLabel.TabIndex = 16
        Me.bankOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'carForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(526, 275)
        Me.Controls.Add(Me.bankOutPutLabel)
        Me.Controls.Add(Me.dealerOutPutLabel)
        Me.Controls.Add(Me.termComboBox)
        Me.Controls.Add(Me.bankRateComboBox)
        Me.Controls.Add(Me.dealerRateComboBox)
        Me.Controls.Add(Me.rebateTextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.termLabel)
        Me.Controls.Add(Me.bankRateLabel)
        Me.Controls.Add(Me.dealerLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.priceTextBox)
        Me.Controls.Add(Me.priceLabel)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "carForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Shopper Inc."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcButton As Button
    Friend WithEvents priceLabel As Label
    Friend WithEvents priceTextBox As TextBox
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents dealerLabel As Label
    Friend WithEvents bankRateLabel As Label
    Friend WithEvents termLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rebateTextBox As TextBox
    Friend WithEvents dealerRateComboBox As ComboBox
    Friend WithEvents bankRateComboBox As ComboBox
    Friend WithEvents termComboBox As ComboBox
    Friend WithEvents dealerOutPutLabel As Label
    Friend WithEvents bankOutPutLabel As Label
End Class
