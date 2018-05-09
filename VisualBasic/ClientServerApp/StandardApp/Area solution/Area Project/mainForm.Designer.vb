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
        Me.rectangleButton = New System.Windows.Forms.Button()
        Me.areatitleLabel = New System.Windows.Forms.Label()
        Me.triangleButton = New System.Windows.Forms.Button()
        Me.paralleButton = New System.Windows.Forms.Button()
        Me.circleButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.formulaLabel = New System.Windows.Forms.Label()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        Me.trianglePictureBox = New System.Windows.Forms.PictureBox()
        Me.parallePictureBox = New System.Windows.Forms.PictureBox()
        Me.rectanglePictureBox = New System.Windows.Forms.PictureBox()
        Me.circlePictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trianglePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.parallePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rectanglePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circlePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rectangleButton
        '
        Me.rectangleButton.Location = New System.Drawing.Point(47, 256)
        Me.rectangleButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rectangleButton.Name = "rectangleButton"
        Me.rectangleButton.Size = New System.Drawing.Size(127, 29)
        Me.rectangleButton.TabIndex = 0
        Me.rectangleButton.Text = "Rectangle"
        Me.rectangleButton.UseVisualStyleBackColor = True
        '
        'areatitleLabel
        '
        Me.areatitleLabel.Location = New System.Drawing.Point(43, 102)
        Me.areatitleLabel.Name = "areatitleLabel"
        Me.areatitleLabel.Size = New System.Drawing.Size(112, 29)
        Me.areatitleLabel.TabIndex = 1
        Me.areatitleLabel.Text = "Area Formula:"
        Me.areatitleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'triangleButton
        '
        Me.triangleButton.Location = New System.Drawing.Point(231, 256)
        Me.triangleButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.triangleButton.Name = "triangleButton"
        Me.triangleButton.Size = New System.Drawing.Size(127, 29)
        Me.triangleButton.TabIndex = 2
        Me.triangleButton.Text = "Triangle"
        Me.triangleButton.UseVisualStyleBackColor = True
        '
        'paralleButton
        '
        Me.paralleButton.Location = New System.Drawing.Point(47, 320)
        Me.paralleButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.paralleButton.Name = "paralleButton"
        Me.paralleButton.Size = New System.Drawing.Size(127, 29)
        Me.paralleButton.TabIndex = 3
        Me.paralleButton.Text = "Parallelogram"
        Me.paralleButton.UseVisualStyleBackColor = True
        '
        'circleButton
        '
        Me.circleButton.Location = New System.Drawing.Point(231, 320)
        Me.circleButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.circleButton.Name = "circleButton"
        Me.circleButton.Size = New System.Drawing.Size(127, 29)
        Me.circleButton.TabIndex = 4
        Me.circleButton.Text = "Circle"
        Me.circleButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(140, 391)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(127, 29)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'formulaLabel
        '
        Me.formulaLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.formulaLabel.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formulaLabel.Location = New System.Drawing.Point(46, 131)
        Me.formulaLabel.Name = "formulaLabel"
        Me.formulaLabel.Size = New System.Drawing.Size(312, 55)
        Me.formulaLabel.TabIndex = 6
        Me.formulaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(384, 32)
        Me.displayPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(381, 253)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 7
        Me.displayPictureBox.TabStop = False
        '
        'trianglePictureBox
        '
        Me.trianglePictureBox.Image = CType(resources.GetObject("trianglePictureBox.Image"), System.Drawing.Image)
        Me.trianglePictureBox.Location = New System.Drawing.Point(153, 635)
        Me.trianglePictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.trianglePictureBox.Name = "trianglePictureBox"
        Me.trianglePictureBox.Size = New System.Drawing.Size(108, 95)
        Me.trianglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.trianglePictureBox.TabIndex = 8
        Me.trianglePictureBox.TabStop = False
        '
        'parallePictureBox
        '
        Me.parallePictureBox.Image = CType(resources.GetObject("parallePictureBox.Image"), System.Drawing.Image)
        Me.parallePictureBox.Location = New System.Drawing.Point(21, 635)
        Me.parallePictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.parallePictureBox.Name = "parallePictureBox"
        Me.parallePictureBox.Size = New System.Drawing.Size(101, 95)
        Me.parallePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.parallePictureBox.TabIndex = 9
        Me.parallePictureBox.TabStop = False
        '
        'rectanglePictureBox
        '
        Me.rectanglePictureBox.Image = CType(resources.GetObject("rectanglePictureBox.Image"), System.Drawing.Image)
        Me.rectanglePictureBox.Location = New System.Drawing.Point(153, 759)
        Me.rectanglePictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rectanglePictureBox.Name = "rectanglePictureBox"
        Me.rectanglePictureBox.Size = New System.Drawing.Size(101, 95)
        Me.rectanglePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.rectanglePictureBox.TabIndex = 10
        Me.rectanglePictureBox.TabStop = False
        '
        'circlePictureBox
        '
        Me.circlePictureBox.Image = CType(resources.GetObject("circlePictureBox.Image"), System.Drawing.Image)
        Me.circlePictureBox.Location = New System.Drawing.Point(21, 759)
        Me.circlePictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.circlePictureBox.Name = "circlePictureBox"
        Me.circlePictureBox.Size = New System.Drawing.Size(108, 95)
        Me.circlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.circlePictureBox.TabIndex = 11
        Me.circlePictureBox.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(777, 459)
        Me.Controls.Add(Me.circlePictureBox)
        Me.Controls.Add(Me.rectanglePictureBox)
        Me.Controls.Add(Me.parallePictureBox)
        Me.Controls.Add(Me.trianglePictureBox)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.formulaLabel)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.circleButton)
        Me.Controls.Add(Me.paralleButton)
        Me.Controls.Add(Me.triangleButton)
        Me.Controls.Add(Me.areatitleLabel)
        Me.Controls.Add(Me.rectangleButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Area Formulas"
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trianglePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.parallePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rectanglePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circlePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rectangleButton As Button
    Friend WithEvents areatitleLabel As Label
    Friend WithEvents triangleButton As Button
    Friend WithEvents paralleButton As Button
    Friend WithEvents circleButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents formulaLabel As Label
    Friend WithEvents displayPictureBox As PictureBox
    Friend WithEvents trianglePictureBox As PictureBox
    Friend WithEvents parallePictureBox As PictureBox
    Friend WithEvents rectanglePictureBox As PictureBox
    Friend WithEvents circlePictureBox As PictureBox
End Class
