<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRun
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
        Me.components = New System.ComponentModel.Container()
        Me.LblHello = New System.Windows.Forms.Label()
        Me.BtnCalc = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuRun = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.mnuContext.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHello
        '
        Me.LblHello.AutoSize = True
        Me.LblHello.Location = New System.Drawing.Point(121, 25)
        Me.LblHello.Name = "LblHello"
        Me.LblHello.Size = New System.Drawing.Size(40, 17)
        Me.LblHello.TabIndex = 0
        Me.LblHello.Text = "Hello"
        '
        'BtnCalc
        '
        Me.BtnCalc.Location = New System.Drawing.Point(124, 62)
        Me.BtnCalc.Name = "BtnCalc"
        Me.BtnCalc.Size = New System.Drawing.Size(82, 23)
        Me.BtnCalc.TabIndex = 1
        Me.BtnCalc.Text = "Calculator"
        Me.BtnCalc.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRun})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(282, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuRun
        '
        Me.mnuRun.Name = "mnuRun"
        Me.mnuRun.Size = New System.Drawing.Size(109, 24)
        Me.mnuRun.Text = "Run Notepad"
        '
        'mnuContext
        '
        Me.mnuContext.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mnuContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuControl})
        Me.mnuContext.Name = "mnuContext"
        Me.mnuContext.Size = New System.Drawing.Size(196, 56)
        '
        'mnuControl
        '
        Me.mnuControl.Name = "mnuControl"
        Me.mnuControl.Size = New System.Drawing.Size(195, 24)
        Me.mnuControl.Text = "Run Control Panel"
        '
        'FrmRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.ContextMenuStrip = Me.mnuContext
        Me.Controls.Add(Me.BtnCalc)
        Me.Controls.Add(Me.LblHello)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmRun"
        Me.Text = "FrmRun"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.mnuContext.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHello As Label
    Friend WithEvents BtnCalc As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuRun As ToolStripMenuItem
    Friend WithEvents mnuContext As ContextMenuStrip
    Friend WithEvents mnuControl As ToolStripMenuItem
End Class
