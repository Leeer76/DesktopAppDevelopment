<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.BtnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter your name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(181, 44)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 1
        '
        'BtnHello
        '
        Me.BtnHello.Location = New System.Drawing.Point(115, 101)
        Me.BtnHello.Name = "BtnHello"
        Me.BtnHello.Size = New System.Drawing.Size(75, 23)
        Me.BtnHello.TabIndex = 2
        Me.BtnHello.Text = "Hello"
        Me.BtnHello.UseVisualStyleBackColor = True
        '
        'FrmMain
        '
        Me.AcceptButton = Me.BtnHello
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 146)
        Me.Controls.Add(Me.BtnHello)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.Text = "My Run Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents BtnHello As Button
End Class
