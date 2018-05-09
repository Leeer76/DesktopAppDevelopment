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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Me.DsNorthwinds = New EmployeesMapApp.dsNorthwinds()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New EmployeesMapApp.dsNorthwindsTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New EmployeesMapApp.dsNorthwindsTableAdapters.TableAdapterManager()
        Me.EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeeIDTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.ExtensionTextBox = New System.Windows.Forms.TextBox()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        CType(Me.DsNorthwinds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DsNorthwinds
        '
        Me.DsNorthwinds.DataSetName = "dsNorthwinds"
        Me.DsNorthwinds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.DsNorthwinds
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.UpdateOrder = EmployeesMapApp.dsNorthwindsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesBindingNavigator
        '
        Me.EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeesBindingNavigator.BindingSource = Me.EmployeesBindingSource
        Me.EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeesBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeesBindingNavigatorSaveItem})
        Me.EmployeesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeesBindingNavigator.Name = "EmployeesBindingNavigator"
        Me.EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(1902, 27)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(12, 69)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(91, 17)
        EmployeeIDLabel.TabIndex = 1
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(136, 66)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeIDTextBox.TabIndex = 2
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 97)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 17)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(136, 94)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LastNameTextBox.TabIndex = 4
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 125)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(136, 122)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(369, 69)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(493, 66)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(249, 22)
        Me.AddressTextBox.TabIndex = 16
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(369, 97)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 17
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(493, 94)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(117, 22)
        Me.CityTextBox.TabIndex = 18
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(616, 94)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(43, 22)
        Me.RegionTextBox.TabIndex = 20
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(665, 94)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(77, 22)
        Me.PostalCodeTextBox.TabIndex = 22
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(369, 125)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 17)
        CountryLabel.TabIndex = 23
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(493, 122)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CountryTextBox.TabIndex = 24
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Location = New System.Drawing.Point(369, 155)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(94, 17)
        HomePhoneLabel.TabIndex = 25
        HomePhoneLabel.Text = "Home Phone:"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "HomePhone", True))
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(493, 152)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(166, 22)
        Me.HomePhoneTextBox.TabIndex = 26
        '
        'ExtensionTextBox
        '
        Me.ExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Extension", True))
        Me.ExtensionTextBox.Location = New System.Drawing.Point(665, 150)
        Me.ExtensionTextBox.Name = "ExtensionTextBox"
        Me.ExtensionTextBox.Size = New System.Drawing.Size(77, 22)
        Me.ExtensionTextBox.TabIndex = 28
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmployeesBindingSource, "Photo", True))
        Me.PhotoPictureBox.Location = New System.Drawing.Point(765, 66)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(200, 210)
        Me.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PhotoPictureBox.TabIndex = 30
        Me.PhotoPictureBox.TabStop = False
        '
        'btnMap
        '
        Me.btnMap.Location = New System.Drawing.Point(12, 180)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(727, 35)
        Me.btnMap.TabIndex = 31
        Me.btnMap.Text = "Map Employee Address"
        Me.btnMap.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 282)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1902, 751)
        Me.WebBrowser1.TabIndex = 32
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1902, 1033)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnMap)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(Me.ExtensionTextBox)
        Me.Controls.Add(Me.PhotoPictureBox)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Name = "mainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Map"
        CType(Me.DsNorthwinds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsNorthwinds As dsNorthwinds
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As dsNorthwindsTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As dsNorthwindsTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents EmployeesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents RegionTextBox As TextBox
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents HomePhoneTextBox As TextBox
    Friend WithEvents ExtensionTextBox As TextBox
    Friend WithEvents PhotoPictureBox As PictureBox
    Friend WithEvents btnMap As Button
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
