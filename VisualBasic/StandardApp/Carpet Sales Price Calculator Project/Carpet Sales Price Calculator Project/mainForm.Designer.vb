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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Me.calcButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.typeGroupBox = New System.Windows.Forms.GroupBox()
        Me.foamRadioButton = New System.Windows.Forms.RadioButton()
        Me.juteRadioButton = New System.Windows.Forms.RadioButton()
        Me.urethaneRadioButton = New System.Windows.Forms.RadioButton()
        Me.lengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.widthTextBox = New System.Windows.Forms.TextBox()
        Me.gradeGroupBox = New System.Windows.Forms.GroupBox()
        Me.basicRadioButton = New System.Windows.Forms.RadioButton()
        Me.primeRadioButton = New System.Windows.Forms.RadioButton()
        Me.standardRadioButton = New System.Windows.Forms.RadioButton()
        Me.deliveryComboBox = New System.Windows.Forms.ComboBox()
        Me.deliveryGroupBox = New System.Windows.Forms.GroupBox()
        Me.noDeliveryRadioButton = New System.Windows.Forms.RadioButton()
        Me.yesDeliveryRadioButton = New System.Windows.Forms.RadioButton()
        Me.gaurdGroupBox = New System.Windows.Forms.GroupBox()
        Me.noScotchRadioButton1 = New System.Windows.Forms.RadioButton()
        Me.yesScotchRadioButton = New System.Windows.Forms.RadioButton()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.outputListBox = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.typeGroupBox.SuspendLayout()
        Me.gradeGroupBox.SuspendLayout()
        Me.deliveryGroupBox.SuspendLayout()
        Me.gaurdGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calcButton
        '
        Me.calcButton.Location = New System.Drawing.Point(525, 408)
        Me.calcButton.Name = "calcButton"
        Me.calcButton.Size = New System.Drawing.Size(105, 33)
        Me.calcButton.TabIndex = 8
        Me.calcButton.Text = "&Calculate"
        Me.calcButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Length:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'typeGroupBox
        '
        Me.typeGroupBox.Controls.Add(Me.foamRadioButton)
        Me.typeGroupBox.Controls.Add(Me.juteRadioButton)
        Me.typeGroupBox.Controls.Add(Me.urethaneRadioButton)
        Me.typeGroupBox.Location = New System.Drawing.Point(118, 9)
        Me.typeGroupBox.Name = "typeGroupBox"
        Me.typeGroupBox.Size = New System.Drawing.Size(115, 118)
        Me.typeGroupBox.TabIndex = 4
        Me.typeGroupBox.TabStop = False
        Me.typeGroupBox.Text = "Backing type:"
        '
        'foamRadioButton
        '
        Me.foamRadioButton.AutoSize = True
        Me.foamRadioButton.Checked = True
        Me.foamRadioButton.Location = New System.Drawing.Point(6, 23)
        Me.foamRadioButton.Name = "foamRadioButton"
        Me.foamRadioButton.Size = New System.Drawing.Size(67, 24)
        Me.foamRadioButton.TabIndex = 0
        Me.foamRadioButton.TabStop = True
        Me.foamRadioButton.Text = "&Foam"
        Me.foamRadioButton.UseVisualStyleBackColor = True
        '
        'juteRadioButton
        '
        Me.juteRadioButton.AutoSize = True
        Me.juteRadioButton.Location = New System.Drawing.Point(6, 83)
        Me.juteRadioButton.Name = "juteRadioButton"
        Me.juteRadioButton.Size = New System.Drawing.Size(56, 24)
        Me.juteRadioButton.TabIndex = 2
        Me.juteRadioButton.Text = "&Jute"
        Me.juteRadioButton.UseVisualStyleBackColor = True
        '
        'urethaneRadioButton
        '
        Me.urethaneRadioButton.AutoSize = True
        Me.urethaneRadioButton.Location = New System.Drawing.Point(6, 53)
        Me.urethaneRadioButton.Name = "urethaneRadioButton"
        Me.urethaneRadioButton.Size = New System.Drawing.Size(90, 24)
        Me.urethaneRadioButton.TabIndex = 1
        Me.urethaneRadioButton.Text = "&Urethane"
        Me.urethaneRadioButton.UseVisualStyleBackColor = True
        '
        'lengthTextBox
        '
        Me.lengthTextBox.Location = New System.Drawing.Point(12, 32)
        Me.lengthTextBox.Name = "lengthTextBox"
        Me.lengthTextBox.Size = New System.Drawing.Size(100, 27)
        Me.lengthTextBox.TabIndex = 1
        Me.lengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Width:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'widthTextBox
        '
        Me.widthTextBox.Location = New System.Drawing.Point(12, 90)
        Me.widthTextBox.Name = "widthTextBox"
        Me.widthTextBox.Size = New System.Drawing.Size(100, 27)
        Me.widthTextBox.TabIndex = 3
        Me.widthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gradeGroupBox
        '
        Me.gradeGroupBox.Controls.Add(Me.basicRadioButton)
        Me.gradeGroupBox.Controls.Add(Me.primeRadioButton)
        Me.gradeGroupBox.Controls.Add(Me.standardRadioButton)
        Me.gradeGroupBox.Location = New System.Drawing.Point(239, 9)
        Me.gradeGroupBox.Name = "gradeGroupBox"
        Me.gradeGroupBox.Size = New System.Drawing.Size(110, 118)
        Me.gradeGroupBox.TabIndex = 5
        Me.gradeGroupBox.TabStop = False
        Me.gradeGroupBox.Text = "Grade:"
        '
        'basicRadioButton
        '
        Me.basicRadioButton.AutoSize = True
        Me.basicRadioButton.Checked = True
        Me.basicRadioButton.Location = New System.Drawing.Point(6, 23)
        Me.basicRadioButton.Name = "basicRadioButton"
        Me.basicRadioButton.Size = New System.Drawing.Size(64, 24)
        Me.basicRadioButton.TabIndex = 0
        Me.basicRadioButton.TabStop = True
        Me.basicRadioButton.Text = "&Basic"
        Me.basicRadioButton.UseVisualStyleBackColor = True
        '
        'primeRadioButton
        '
        Me.primeRadioButton.AutoSize = True
        Me.primeRadioButton.Location = New System.Drawing.Point(6, 83)
        Me.primeRadioButton.Name = "primeRadioButton"
        Me.primeRadioButton.Size = New System.Drawing.Size(68, 24)
        Me.primeRadioButton.TabIndex = 2
        Me.primeRadioButton.Text = "&Prime"
        Me.primeRadioButton.UseVisualStyleBackColor = True
        '
        'standardRadioButton
        '
        Me.standardRadioButton.AutoSize = True
        Me.standardRadioButton.Location = New System.Drawing.Point(6, 53)
        Me.standardRadioButton.Name = "standardRadioButton"
        Me.standardRadioButton.Size = New System.Drawing.Size(90, 24)
        Me.standardRadioButton.TabIndex = 1
        Me.standardRadioButton.Text = "&Standard"
        Me.standardRadioButton.UseVisualStyleBackColor = True
        '
        'deliveryComboBox
        '
        Me.deliveryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.deliveryComboBox.Enabled = False
        Me.deliveryComboBox.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryComboBox.FormattingEnabled = True
        Me.deliveryComboBox.Items.AddRange(New Object() {"In town", "Less than 100 miles away", "100-500 miles away", "More than 500 miles away"})
        Me.deliveryComboBox.Location = New System.Drawing.Point(64, 24)
        Me.deliveryComboBox.Name = "deliveryComboBox"
        Me.deliveryComboBox.Size = New System.Drawing.Size(126, 25)
        Me.deliveryComboBox.TabIndex = 2
        '
        'deliveryGroupBox
        '
        Me.deliveryGroupBox.Controls.Add(Me.noDeliveryRadioButton)
        Me.deliveryGroupBox.Controls.Add(Me.yesDeliveryRadioButton)
        Me.deliveryGroupBox.Controls.Add(Me.deliveryComboBox)
        Me.deliveryGroupBox.Location = New System.Drawing.Point(355, 9)
        Me.deliveryGroupBox.Name = "deliveryGroupBox"
        Me.deliveryGroupBox.Size = New System.Drawing.Size(196, 91)
        Me.deliveryGroupBox.TabIndex = 6
        Me.deliveryGroupBox.TabStop = False
        Me.deliveryGroupBox.Text = "Delivery:"
        '
        'noDeliveryRadioButton
        '
        Me.noDeliveryRadioButton.AutoSize = True
        Me.noDeliveryRadioButton.Checked = True
        Me.noDeliveryRadioButton.Location = New System.Drawing.Point(6, 55)
        Me.noDeliveryRadioButton.Name = "noDeliveryRadioButton"
        Me.noDeliveryRadioButton.Size = New System.Drawing.Size(50, 24)
        Me.noDeliveryRadioButton.TabIndex = 4
        Me.noDeliveryRadioButton.TabStop = True
        Me.noDeliveryRadioButton.Text = "&No"
        Me.noDeliveryRadioButton.UseVisualStyleBackColor = True
        '
        'yesDeliveryRadioButton
        '
        Me.yesDeliveryRadioButton.AutoSize = True
        Me.yesDeliveryRadioButton.Location = New System.Drawing.Point(6, 25)
        Me.yesDeliveryRadioButton.Name = "yesDeliveryRadioButton"
        Me.yesDeliveryRadioButton.Size = New System.Drawing.Size(51, 24)
        Me.yesDeliveryRadioButton.TabIndex = 3
        Me.yesDeliveryRadioButton.Text = "&Yes"
        Me.yesDeliveryRadioButton.UseVisualStyleBackColor = True
        '
        'gaurdGroupBox
        '
        Me.gaurdGroupBox.Controls.Add(Me.noScotchRadioButton1)
        Me.gaurdGroupBox.Controls.Add(Me.yesScotchRadioButton)
        Me.gaurdGroupBox.Location = New System.Drawing.Point(557, 9)
        Me.gaurdGroupBox.Name = "gaurdGroupBox"
        Me.gaurdGroupBox.Size = New System.Drawing.Size(184, 91)
        Me.gaurdGroupBox.TabIndex = 7
        Me.gaurdGroupBox.TabStop = False
        Me.gaurdGroupBox.Text = "Scotchguard protection:"
        '
        'noScotchRadioButton1
        '
        Me.noScotchRadioButton1.AutoSize = True
        Me.noScotchRadioButton1.Location = New System.Drawing.Point(7, 56)
        Me.noScotchRadioButton1.Name = "noScotchRadioButton1"
        Me.noScotchRadioButton1.Size = New System.Drawing.Size(50, 24)
        Me.noScotchRadioButton1.TabIndex = 5
        Me.noScotchRadioButton1.Text = "N&o"
        Me.noScotchRadioButton1.UseVisualStyleBackColor = True
        '
        'yesScotchRadioButton
        '
        Me.yesScotchRadioButton.AutoSize = True
        Me.yesScotchRadioButton.Checked = True
        Me.yesScotchRadioButton.Location = New System.Drawing.Point(7, 23)
        Me.yesScotchRadioButton.Name = "yesScotchRadioButton"
        Me.yesScotchRadioButton.Size = New System.Drawing.Size(51, 24)
        Me.yesScotchRadioButton.TabIndex = 6
        Me.yesScotchRadioButton.TabStop = True
        Me.yesScotchRadioButton.Text = "Y&es"
        Me.yesScotchRadioButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(636, 408)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(105, 33)
        Me.exitButton.TabIndex = 9
        Me.exitButton.Text = "E&xit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'outputListBox
        '
        Me.outputListBox.FormattingEnabled = True
        Me.outputListBox.ItemHeight = 20
        Me.outputListBox.Location = New System.Drawing.Point(12, 133)
        Me.outputListBox.Name = "outputListBox"
        Me.outputListBox.Size = New System.Drawing.Size(221, 264)
        Me.outputListBox.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(287, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(454, 264)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'mainForm
        '
        Me.AcceptButton = Me.calcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(760, 453)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.outputListBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.gaurdGroupBox)
        Me.Controls.Add(Me.deliveryGroupBox)
        Me.Controls.Add(Me.gradeGroupBox)
        Me.Controls.Add(Me.widthTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lengthTextBox)
        Me.Controls.Add(Me.typeGroupBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.calcButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carpet Sales Price Calculator"
        Me.typeGroupBox.ResumeLayout(False)
        Me.typeGroupBox.PerformLayout()
        Me.gradeGroupBox.ResumeLayout(False)
        Me.gradeGroupBox.PerformLayout()
        Me.deliveryGroupBox.ResumeLayout(False)
        Me.deliveryGroupBox.PerformLayout()
        Me.gaurdGroupBox.ResumeLayout(False)
        Me.gaurdGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents typeGroupBox As GroupBox
    Friend WithEvents lengthTextBox As TextBox
    Friend WithEvents foamRadioButton As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents widthTextBox As TextBox
    Friend WithEvents juteRadioButton As RadioButton
    Friend WithEvents urethaneRadioButton As RadioButton
    Friend WithEvents gradeGroupBox As GroupBox
    Friend WithEvents basicRadioButton As RadioButton
    Friend WithEvents primeRadioButton As RadioButton
    Friend WithEvents standardRadioButton As RadioButton
    Friend WithEvents deliveryComboBox As ComboBox
    Friend WithEvents deliveryGroupBox As GroupBox
    Friend WithEvents gaurdGroupBox As GroupBox
    Friend WithEvents exitButton As Button
    Friend WithEvents outputListBox As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents noDeliveryRadioButton As RadioButton
    Friend WithEvents yesDeliveryRadioButton As RadioButton
    Friend WithEvents noScotchRadioButton1 As RadioButton
    Friend WithEvents yesScotchRadioButton As RadioButton
End Class
