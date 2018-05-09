<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomers))
        Dim CustomerIDLabel As System.Windows.Forms.Label
        Dim CompanyNameLabel As System.Windows.Forms.Label
        Dim ContactNameLabel As System.Windows.Forms.Label
        Dim ContactTitleLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim RegionLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim FaxLabel As System.Windows.Forms.Label
        Me._NwindTables_1_DataSet = New SimpleMSdataAccess._NwindTables_1_DataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.CustomersTableAdapter()
        Me.TableAdapterManager = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.TableAdapterManager()
        Me.CustomersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CustomersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerIDTextBox = New System.Windows.Forms.TextBox()
        Me.CompanyNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactNameTextBox = New System.Windows.Forms.TextBox()
        Me.ContactTitleTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxTextBox = New System.Windows.Forms.TextBox()
        CustomerIDLabel = New System.Windows.Forms.Label()
        CompanyNameLabel = New System.Windows.Forms.Label()
        ContactNameLabel = New System.Windows.Forms.Label()
        ContactTitleLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        RegionLabel = New System.Windows.Forms.Label()
        PostalCodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        FaxLabel = New System.Windows.Forms.Label()
        CType(Me._NwindTables_1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomersBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '_NwindTables_1_DataSet
        '
        Me._NwindTables_1_DataSet.DataSetName = "_NwindTables_1_DataSet"
        Me._NwindTables_1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me._NwindTables_1_DataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Me.CustomersTableAdapter
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CustomersBindingNavigator
        '
        Me.CustomersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CustomersBindingNavigator.BindingSource = Me.CustomersBindingSource
        Me.CustomersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CustomersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CustomersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CustomersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CustomersBindingNavigatorSaveItem})
        Me.CustomersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CustomersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CustomersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CustomersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CustomersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CustomersBindingNavigator.Name = "CustomersBindingNavigator"
        Me.CustomersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CustomersBindingNavigator.Size = New System.Drawing.Size(363, 27)
        Me.CustomersBindingNavigator.TabIndex = 0
        Me.CustomersBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        'CustomersBindingNavigatorSaveItem
        '
        Me.CustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CustomersBindingNavigatorSaveItem.Image = CType(resources.GetObject("CustomersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CustomersBindingNavigatorSaveItem.Name = "CustomersBindingNavigatorSaveItem"
        Me.CustomersBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.CustomersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerIDLabel
        '
        CustomerIDLabel.AutoSize = True
        CustomerIDLabel.Location = New System.Drawing.Point(12, 62)
        CustomerIDLabel.Name = "CustomerIDLabel"
        CustomerIDLabel.Size = New System.Drawing.Size(89, 17)
        CustomerIDLabel.TabIndex = 1
        CustomerIDLabel.Text = "Customer ID:"
        '
        'CustomerIDTextBox
        '
        Me.CustomerIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CustomerID", True))
        Me.CustomerIDTextBox.Location = New System.Drawing.Point(130, 59)
        Me.CustomerIDTextBox.Name = "CustomerIDTextBox"
        Me.CustomerIDTextBox.Size = New System.Drawing.Size(193, 22)
        Me.CustomerIDTextBox.TabIndex = 2
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(12, 90)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(112, 17)
        CompanyNameLabel.TabIndex = 3
        CompanyNameLabel.Text = "Company Name:"
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(130, 87)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(193, 22)
        Me.CompanyNameTextBox.TabIndex = 4
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(12, 118)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(101, 17)
        ContactNameLabel.TabIndex = 5
        ContactNameLabel.Text = "Contact Name:"
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Location = New System.Drawing.Point(130, 115)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(193, 22)
        Me.ContactNameTextBox.TabIndex = 6
        '
        'ContactTitleLabel
        '
        ContactTitleLabel.AutoSize = True
        ContactTitleLabel.Location = New System.Drawing.Point(12, 146)
        ContactTitleLabel.Name = "ContactTitleLabel"
        ContactTitleLabel.Size = New System.Drawing.Size(91, 17)
        ContactTitleLabel.TabIndex = 7
        ContactTitleLabel.Text = "Contact Title:"
        '
        'ContactTitleTextBox
        '
        Me.ContactTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "ContactTitle", True))
        Me.ContactTitleTextBox.Location = New System.Drawing.Point(130, 143)
        Me.ContactTitleTextBox.Name = "ContactTitleTextBox"
        Me.ContactTitleTextBox.Size = New System.Drawing.Size(193, 22)
        Me.ContactTitleTextBox.TabIndex = 8
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 174)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(130, 171)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(193, 22)
        Me.AddressTextBox.TabIndex = 10
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(12, 202)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(130, 199)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(193, 22)
        Me.CityTextBox.TabIndex = 12
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(12, 230)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(57, 17)
        RegionLabel.TabIndex = 13
        RegionLabel.Text = "Region:"
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(130, 227)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(193, 22)
        Me.RegionTextBox.TabIndex = 14
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(12, 258)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(88, 17)
        PostalCodeLabel.TabIndex = 15
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(130, 255)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(193, 22)
        Me.PostalCodeTextBox.TabIndex = 16
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(12, 286)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 17)
        CountryLabel.TabIndex = 17
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(130, 283)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(193, 22)
        Me.CountryTextBox.TabIndex = 18
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(12, 314)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 19
        PhoneLabel.Text = "Phone:"
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(130, 311)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(193, 22)
        Me.PhoneTextBox.TabIndex = 20
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(12, 342)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(34, 17)
        FaxLabel.TabIndex = 21
        FaxLabel.Text = "Fax:"
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomersBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(130, 339)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(193, 22)
        Me.FaxTextBox.TabIndex = 22
        '
        'frmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 394)
        Me.Controls.Add(CustomerIDLabel)
        Me.Controls.Add(Me.CustomerIDTextBox)
        Me.Controls.Add(CompanyNameLabel)
        Me.Controls.Add(Me.CompanyNameTextBox)
        Me.Controls.Add(ContactNameLabel)
        Me.Controls.Add(Me.ContactNameTextBox)
        Me.Controls.Add(ContactTitleLabel)
        Me.Controls.Add(Me.ContactTitleTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(RegionLabel)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(PostalCodeLabel)
        Me.Controls.Add(Me.PostalCodeTextBox)
        Me.Controls.Add(CountryLabel)
        Me.Controls.Add(Me.CountryTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(FaxLabel)
        Me.Controls.Add(Me.FaxTextBox)
        Me.Controls.Add(Me.CustomersBindingNavigator)
        Me.Name = "frmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Customers"
        CType(Me._NwindTables_1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomersBindingNavigator.ResumeLayout(False)
        Me.CustomersBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _NwindTables_1_DataSet As _NwindTables_1_DataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As _NwindTables_1_DataSetTableAdapters.CustomersTableAdapter
    Friend WithEvents TableAdapterManager As _NwindTables_1_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents CustomersBindingNavigator As BindingNavigator
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
    Friend WithEvents CustomersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerIDTextBox As TextBox
    Friend WithEvents CompanyNameTextBox As TextBox
    Friend WithEvents ContactNameTextBox As TextBox
    Friend WithEvents ContactTitleTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents RegionTextBox As TextBox
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents FaxTextBox As TextBox
End Class
