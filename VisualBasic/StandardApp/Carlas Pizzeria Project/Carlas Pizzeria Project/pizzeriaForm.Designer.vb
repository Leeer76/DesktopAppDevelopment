<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pizzeriaForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MamaTextBox = New System.Windows.Forms.TextBox()
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.classicTextBox = New System.Windows.Forms.TextBox()
        Me.papaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.taxOutPutLabel = New System.Windows.Forms.Label()
        Me.priceOutputLabel = New System.Windows.Forms.Label()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.veggieGlutenTextBox = New System.Windows.Forms.TextBox()
        Me.papaGlutenTextBox = New System.Windows.Forms.TextBox()
        Me.mamaGlutenTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.couponCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Mama Carla's"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MamaTextBox
        '
        Me.MamaTextBox.Location = New System.Drawing.Point(32, 47)
        Me.MamaTextBox.Name = "MamaTextBox"
        Me.MamaTextBox.Size = New System.Drawing.Size(53, 27)
        Me.MamaTextBox.TabIndex = 1
        Me.MamaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(32, 296)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(110, 33)
        Me.calcButton.TabIndex = 13
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "&Papa Gino's"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Classic &Veggie"
        '
        'classicTextBox
        '
        Me.classicTextBox.Location = New System.Drawing.Point(32, 113)
        Me.classicTextBox.Name = "classicTextBox"
        Me.classicTextBox.Size = New System.Drawing.Size(53, 27)
        Me.classicTextBox.TabIndex = 9
        Me.classicTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'papaTextBox
        '
        Me.papaTextBox.Location = New System.Drawing.Point(32, 80)
        Me.papaTextBox.Name = "papaTextBox"
        Me.papaTextBox.Size = New System.Drawing.Size(53, 27)
        Me.papaTextBox.TabIndex = 5
        Me.papaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 20)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Tax:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Price:"
        '
        'taxOutPutLabel
        '
        Me.taxOutPutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.taxOutPutLabel.Location = New System.Drawing.Point(205, 175)
        Me.taxOutPutLabel.Name = "taxOutPutLabel"
        Me.taxOutPutLabel.Size = New System.Drawing.Size(104, 30)
        Me.taxOutPutLabel.TabIndex = 17
        Me.taxOutPutLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'priceOutputLabel
        '
        Me.priceOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.priceOutputLabel.Location = New System.Drawing.Point(205, 230)
        Me.priceOutputLabel.Name = "priceOutputLabel"
        Me.priceOutputLabel.Size = New System.Drawing.Size(104, 30)
        Me.priceOutputLabel.TabIndex = 19
        Me.priceOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(148, 296)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(110, 33)
        Me.resetButton.TabIndex = 14
        Me.resetButton.Text = "&Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(264, 296)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 33)
        Me.exitButton.TabIndex = 15
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'veggieGlutenTextBox
        '
        Me.veggieGlutenTextBox.Location = New System.Drawing.Point(205, 113)
        Me.veggieGlutenTextBox.Name = "veggieGlutenTextBox"
        Me.veggieGlutenTextBox.Size = New System.Drawing.Size(53, 27)
        Me.veggieGlutenTextBox.TabIndex = 11
        Me.veggieGlutenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'papaGlutenTextBox
        '
        Me.papaGlutenTextBox.Location = New System.Drawing.Point(205, 80)
        Me.papaGlutenTextBox.Name = "papaGlutenTextBox"
        Me.papaGlutenTextBox.Size = New System.Drawing.Size(53, 27)
        Me.papaGlutenTextBox.TabIndex = 7
        Me.papaGlutenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'mamaGlutenTextBox
        '
        Me.mamaGlutenTextBox.Location = New System.Drawing.Point(205, 47)
        Me.mamaGlutenTextBox.Name = "mamaGlutenTextBox"
        Me.mamaGlutenTextBox.Size = New System.Drawing.Size(53, 27)
        Me.mamaGlutenTextBox.TabIndex = 3
        Me.mamaGlutenTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(264, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "M&ama Carla's gluten-free"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Papa &Gino's gluten-free"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(264, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "C&lassic Veggie gluten-free"
        '
        'couponCheckBox
        '
        Me.couponCheckBox.AutoSize = True
        Me.couponCheckBox.Location = New System.Drawing.Point(32, 179)
        Me.couponCheckBox.Name = "couponCheckBox"
        Me.couponCheckBox.Size = New System.Drawing.Size(101, 24)
        Me.couponCheckBox.TabIndex = 12
        Me.couponCheckBox.Text = "$&3 coupon"
        Me.couponCheckBox.UseVisualStyleBackColor = True
        '
        'pizzeriaForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(472, 360)
        Me.Controls.Add(Me.couponCheckBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.mamaGlutenTextBox)
        Me.Controls.Add(Me.papaGlutenTextBox)
        Me.Controls.Add(Me.veggieGlutenTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.priceOutputLabel)
        Me.Controls.Add(Me.taxOutPutLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.papaTextBox)
        Me.Controls.Add(Me.classicTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.calcButton)
        Me.Controls.Add(Me.MamaTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "pizzeriaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carla's Pizzeria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MamaTextBox As TextBox
    Friend WithEvents calcButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents classicTextBox As TextBox
    Friend WithEvents papaTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents taxOutPutLabel As Label
    Friend WithEvents priceOutputLabel As Label
    Friend WithEvents resetButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents veggieGlutenTextBox As TextBox
    Friend WithEvents papaGlutenTextBox As TextBox
    Friend WithEvents mamaGlutenTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents couponCheckBox As CheckBox
End Class
