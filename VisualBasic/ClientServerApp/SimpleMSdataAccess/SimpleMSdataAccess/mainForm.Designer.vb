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
        Me.BtnCategories = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.BtnEmployees = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCategories
        '
        Me.BtnCategories.Location = New System.Drawing.Point(23, 37)
        Me.BtnCategories.Name = "BtnCategories"
        Me.BtnCategories.Size = New System.Drawing.Size(265, 30)
        Me.BtnCategories.TabIndex = 0
        Me.BtnCategories.Text = "&Categories"
        Me.BtnCategories.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(23, 73)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(265, 30)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "C&ustomers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'BtnEmployees
        '
        Me.BtnEmployees.Location = New System.Drawing.Point(23, 109)
        Me.BtnEmployees.Name = "BtnEmployees"
        Me.BtnEmployees.Size = New System.Drawing.Size(265, 30)
        Me.BtnEmployees.TabIndex = 2
        Me.BtnEmployees.Text = "&Employees"
        Me.BtnEmployees.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Location = New System.Drawing.Point(23, 145)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(265, 30)
        Me.btnSupplier.TabIndex = 3
        Me.btnSupplier.Text = "&Supplier"
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 211)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.BtnEmployees)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.BtnCategories)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Northwind Data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCategories As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents BtnEmployees As Button
    Friend WithEvents btnSupplier As Button
End Class
