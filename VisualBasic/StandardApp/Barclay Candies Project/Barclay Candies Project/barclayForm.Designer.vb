<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class barclayForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pricesListBox = New System.Windows.Forms.ListBox()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.outPutLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(173, 103)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(91, 33)
        Me.calcButton.TabIndex = 0
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Prices:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pricesListBox
        '
        Me.pricesListBox.FormattingEnabled = True
        Me.pricesListBox.ItemHeight = 20
        Me.pricesListBox.Location = New System.Drawing.Point(16, 32)
        Me.pricesListBox.Name = "pricesListBox"
        Me.pricesListBox.Size = New System.Drawing.Size(106, 104)
        Me.pricesListBox.TabIndex = 3
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(270, 103)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(91, 33)
        Me.exitButton.TabIndex = 1
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Total due:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'outPutLabel
        '
        Me.outPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.outPutLabel.Location = New System.Drawing.Point(173, 29)
        Me.outPutLabel.Name = "outPutLabel"
        Me.outPutLabel.Size = New System.Drawing.Size(188, 43)
        Me.outPutLabel.TabIndex = 5
        Me.outPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'barclayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 171)
        Me.Controls.Add(Me.outPutLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.pricesListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "barclayForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barclay Candies"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents pricesListBox As ListBox
    Friend WithEvents exitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents outPutLabel As Label
End Class
