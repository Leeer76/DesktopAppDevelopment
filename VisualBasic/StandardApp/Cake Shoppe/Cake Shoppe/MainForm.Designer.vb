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
        Me.bdayButton = New System.Windows.Forms.Button()
        Me.bdayPictureBox = New System.Windows.Forms.PictureBox()
        Me.typeLabel = New System.Windows.Forms.Label()
        Me.weddingButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.weddingPictureBox = New System.Windows.Forms.PictureBox()
        Me.displayPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.bdayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.weddingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bdayButton
        '
        Me.bdayButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.bdayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.bdayButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdayButton.ForeColor = System.Drawing.Color.Black
        Me.bdayButton.Location = New System.Drawing.Point(140, 304)
        Me.bdayButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bdayButton.Name = "bdayButton"
        Me.bdayButton.Size = New System.Drawing.Size(80, 29)
        Me.bdayButton.TabIndex = 0
        Me.bdayButton.Text = "Birthday"
        Me.bdayButton.UseVisualStyleBackColor = False
        '
        'bdayPictureBox
        '
        Me.bdayPictureBox.Image = CType(resources.GetObject("bdayPictureBox.Image"), System.Drawing.Image)
        Me.bdayPictureBox.Location = New System.Drawing.Point(12, 463)
        Me.bdayPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bdayPictureBox.Name = "bdayPictureBox"
        Me.bdayPictureBox.Size = New System.Drawing.Size(165, 125)
        Me.bdayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.bdayPictureBox.TabIndex = 1
        Me.bdayPictureBox.TabStop = False
        '
        'typeLabel
        '
        Me.typeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.typeLabel.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeLabel.ForeColor = System.Drawing.Color.Black
        Me.typeLabel.Location = New System.Drawing.Point(174, 29)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(180, 30)
        Me.typeLabel.TabIndex = 2
        Me.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'weddingButton
        '
        Me.weddingButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.weddingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.weddingButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.weddingButton.ForeColor = System.Drawing.Color.Black
        Me.weddingButton.Location = New System.Drawing.Point(224, 304)
        Me.weddingButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.weddingButton.Name = "weddingButton"
        Me.weddingButton.Size = New System.Drawing.Size(80, 29)
        Me.weddingButton.TabIndex = 3
        Me.weddingButton.Text = "Wedding"
        Me.weddingButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.ForeColor = System.Drawing.Color.Black
        Me.exitButton.Location = New System.Drawing.Point(308, 304)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(80, 29)
        Me.exitButton.TabIndex = 4
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'weddingPictureBox
        '
        Me.weddingPictureBox.Image = CType(resources.GetObject("weddingPictureBox.Image"), System.Drawing.Image)
        Me.weddingPictureBox.Location = New System.Drawing.Point(237, 463)
        Me.weddingPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.weddingPictureBox.Name = "weddingPictureBox"
        Me.weddingPictureBox.Size = New System.Drawing.Size(165, 125)
        Me.weddingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.weddingPictureBox.TabIndex = 5
        Me.weddingPictureBox.TabStop = False
        '
        'displayPictureBox
        '
        Me.displayPictureBox.Location = New System.Drawing.Point(152, 75)
        Me.displayPictureBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.displayPictureBox.Name = "displayPictureBox"
        Me.displayPictureBox.Size = New System.Drawing.Size(225, 205)
        Me.displayPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.displayPictureBox.TabIndex = 6
        Me.displayPictureBox.TabStop = False
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(529, 398)
        Me.Controls.Add(Me.displayPictureBox)
        Me.Controls.Add(Me.weddingPictureBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.weddingButton)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.bdayPictureBox)
        Me.Controls.Add(Me.bdayButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cake Shoppe"
        CType(Me.bdayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.weddingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.displayPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bdayButton As Button
    Friend WithEvents bdayPictureBox As PictureBox
    Friend WithEvents typeLabel As Label
    Friend WithEvents weddingButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents weddingPictureBox As PictureBox
    Friend WithEvents displayPictureBox As PictureBox
End Class
