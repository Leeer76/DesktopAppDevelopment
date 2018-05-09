<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSpeakAssignment
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
        Me.txtQuestion = New System.Windows.Forms.TextBox()
        Me.btnAsk = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.pbComp = New System.Windows.Forms.PictureBox()
        CType(Me.pbComp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter question here:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQuestion
        '
        Me.txtQuestion.Location = New System.Drawing.Point(16, 33)
        Me.txtQuestion.Multiline = True
        Me.txtQuestion.Name = "txtQuestion"
        Me.txtQuestion.Size = New System.Drawing.Size(324, 137)
        Me.txtQuestion.TabIndex = 1
        '
        'btnAsk
        '
        Me.btnAsk.Location = New System.Drawing.Point(252, 193)
        Me.btnAsk.Name = "btnAsk"
        Me.btnAsk.Size = New System.Drawing.Size(88, 33)
        Me.btnAsk.TabIndex = 2
        Me.btnAsk.Text = "Ask?"
        Me.btnAsk.UseVisualStyleBackColor = True
        '
        'btnNo
        '
        Me.btnNo.Location = New System.Drawing.Point(110, 193)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(88, 33)
        Me.btnNo.TabIndex = 4
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Location = New System.Drawing.Point(16, 193)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(88, 33)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'pbComp
        '
        Me.pbComp.Image = Global.SpeakAssignment.My.Resources.Resources.computer
        Me.pbComp.Location = New System.Drawing.Point(52, 10)
        Me.pbComp.Name = "pbComp"
        Me.pbComp.Size = New System.Drawing.Size(257, 224)
        Me.pbComp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbComp.TabIndex = 6
        Me.pbComp.TabStop = False
        '
        'frmSpeakAssignment
        '
        Me.AcceptButton = Me.btnAsk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 245)
        Me.Controls.Add(Me.pbComp)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.btnAsk)
        Me.Controls.Add(Me.txtQuestion)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmSpeakAssignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "A-I Friend"
        CType(Me.pbComp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtQuestion As TextBox
    Friend WithEvents btnAsk As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents btnYes As Button
    Friend WithEvents pbComp As PictureBox
End Class
