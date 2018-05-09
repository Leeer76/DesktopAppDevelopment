<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsupplier
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
        Dim SupplierIDLabel As System.Windows.Forms.Label
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
        Dim HomePageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmsupplier))
        Me._NwindTables_1_DataSet = New SimpleMSdataAccess._NwindTables_1_DataSet()
        Me.SuppliersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SuppliersTableAdapter = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.SuppliersTableAdapter()
        Me.TableAdapterManager = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.TableAdapterManager()
        Me.ProductsTableAdapter = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.ProductsTableAdapter()
        Me.SuppliersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SuppliersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SupplierIDTextBox = New System.Windows.Forms.TextBox()
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
        Me.HomePageTextBox = New System.Windows.Forms.TextBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        SupplierIDLabel = New System.Windows.Forms.Label()
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
        HomePageLabel = New System.Windows.Forms.Label()
        CType(Me._NwindTables_1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuppliersBindingNavigator.SuspendLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SupplierIDLabel
        '
        SupplierIDLabel.AutoSize = True
        SupplierIDLabel.Location = New System.Drawing.Point(12, 52)
        SupplierIDLabel.Name = "SupplierIDLabel"
        SupplierIDLabel.Size = New System.Drawing.Size(81, 17)
        SupplierIDLabel.TabIndex = 1
        SupplierIDLabel.Text = "Supplier ID:"
        '
        'CompanyNameLabel
        '
        CompanyNameLabel.AutoSize = True
        CompanyNameLabel.Location = New System.Drawing.Point(12, 80)
        CompanyNameLabel.Name = "CompanyNameLabel"
        CompanyNameLabel.Size = New System.Drawing.Size(112, 17)
        CompanyNameLabel.TabIndex = 3
        CompanyNameLabel.Text = "Company Name:"
        '
        'ContactNameLabel
        '
        ContactNameLabel.AutoSize = True
        ContactNameLabel.Location = New System.Drawing.Point(12, 108)
        ContactNameLabel.Name = "ContactNameLabel"
        ContactNameLabel.Size = New System.Drawing.Size(101, 17)
        ContactNameLabel.TabIndex = 5
        ContactNameLabel.Text = "Contact Name:"
        '
        'ContactTitleLabel
        '
        ContactTitleLabel.AutoSize = True
        ContactTitleLabel.Location = New System.Drawing.Point(12, 136)
        ContactTitleLabel.Name = "ContactTitleLabel"
        ContactTitleLabel.Size = New System.Drawing.Size(91, 17)
        ContactTitleLabel.TabIndex = 7
        ContactTitleLabel.Text = "Contact Title:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(12, 164)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 9
        AddressLabel.Text = "Address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(12, 192)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(634, 52)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(57, 17)
        RegionLabel.TabIndex = 13
        RegionLabel.Text = "Region:"
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(634, 80)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(88, 17)
        PostalCodeLabel.TabIndex = 15
        PostalCodeLabel.Text = "Postal Code:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(634, 108)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 17)
        CountryLabel.TabIndex = 17
        CountryLabel.Text = "Country:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(634, 136)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(53, 17)
        PhoneLabel.TabIndex = 19
        PhoneLabel.Text = "Phone:"
        '
        'FaxLabel
        '
        FaxLabel.AutoSize = True
        FaxLabel.Location = New System.Drawing.Point(634, 164)
        FaxLabel.Name = "FaxLabel"
        FaxLabel.Size = New System.Drawing.Size(34, 17)
        FaxLabel.TabIndex = 21
        FaxLabel.Text = "Fax:"
        '
        'HomePageLabel
        '
        HomePageLabel.AutoSize = True
        HomePageLabel.Location = New System.Drawing.Point(634, 192)
        HomePageLabel.Name = "HomePageLabel"
        HomePageLabel.Size = New System.Drawing.Size(86, 17)
        HomePageLabel.TabIndex = 23
        HomePageLabel.Text = "Home Page:"
        '
        '_NwindTables_1_DataSet
        '
        Me._NwindTables_1_DataSet.DataSetName = "_NwindTables_1_DataSet"
        Me._NwindTables_1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SuppliersBindingSource
        '
        Me.SuppliersBindingSource.DataMember = "Suppliers"
        Me.SuppliersBindingSource.DataSource = Me._NwindTables_1_DataSet
        '
        'SuppliersTableAdapter
        '
        Me.SuppliersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Nothing
        Me.TableAdapterManager.Order_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.OrdersTableAdapter = Nothing
        Me.TableAdapterManager.ProductsTableAdapter = Me.ProductsTableAdapter
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Me.SuppliersTableAdapter
        Me.TableAdapterManager.UpdateOrder = SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'SuppliersBindingNavigator
        '
        Me.SuppliersBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SuppliersBindingNavigator.BindingSource = Me.SuppliersBindingSource
        Me.SuppliersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SuppliersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SuppliersBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.SuppliersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SuppliersBindingNavigatorSaveItem})
        Me.SuppliersBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SuppliersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SuppliersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SuppliersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SuppliersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SuppliersBindingNavigator.Name = "SuppliersBindingNavigator"
        Me.SuppliersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SuppliersBindingNavigator.Size = New System.Drawing.Size(1222, 27)
        Me.SuppliersBindingNavigator.TabIndex = 0
        Me.SuppliersBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'SuppliersBindingNavigatorSaveItem
        '
        Me.SuppliersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SuppliersBindingNavigatorSaveItem.Image = CType(resources.GetObject("SuppliersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SuppliersBindingNavigatorSaveItem.Name = "SuppliersBindingNavigatorSaveItem"
        Me.SuppliersBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.SuppliersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SupplierIDTextBox
        '
        Me.SupplierIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "SupplierID", True))
        Me.SupplierIDTextBox.Location = New System.Drawing.Point(130, 49)
        Me.SupplierIDTextBox.Name = "SupplierIDTextBox"
        Me.SupplierIDTextBox.Size = New System.Drawing.Size(454, 22)
        Me.SupplierIDTextBox.TabIndex = 2
        '
        'CompanyNameTextBox
        '
        Me.CompanyNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "CompanyName", True))
        Me.CompanyNameTextBox.Location = New System.Drawing.Point(130, 77)
        Me.CompanyNameTextBox.Name = "CompanyNameTextBox"
        Me.CompanyNameTextBox.Size = New System.Drawing.Size(454, 22)
        Me.CompanyNameTextBox.TabIndex = 4
        '
        'ContactNameTextBox
        '
        Me.ContactNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ContactName", True))
        Me.ContactNameTextBox.Location = New System.Drawing.Point(130, 105)
        Me.ContactNameTextBox.Name = "ContactNameTextBox"
        Me.ContactNameTextBox.Size = New System.Drawing.Size(454, 22)
        Me.ContactNameTextBox.TabIndex = 6
        '
        'ContactTitleTextBox
        '
        Me.ContactTitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "ContactTitle", True))
        Me.ContactTitleTextBox.Location = New System.Drawing.Point(130, 133)
        Me.ContactTitleTextBox.Name = "ContactTitleTextBox"
        Me.ContactTitleTextBox.Size = New System.Drawing.Size(454, 22)
        Me.ContactTitleTextBox.TabIndex = 8
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(130, 161)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(454, 22)
        Me.AddressTextBox.TabIndex = 10
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(130, 189)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(454, 22)
        Me.CityTextBox.TabIndex = 12
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(752, 49)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(454, 22)
        Me.RegionTextBox.TabIndex = 14
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(752, 77)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(454, 22)
        Me.PostalCodeTextBox.TabIndex = 16
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(752, 105)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(454, 22)
        Me.CountryTextBox.TabIndex = 18
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(752, 133)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(454, 22)
        Me.PhoneTextBox.TabIndex = 20
        '
        'FaxTextBox
        '
        Me.FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "Fax", True))
        Me.FaxTextBox.Location = New System.Drawing.Point(752, 161)
        Me.FaxTextBox.Name = "FaxTextBox"
        Me.FaxTextBox.Size = New System.Drawing.Size(454, 22)
        Me.FaxTextBox.TabIndex = 22
        '
        'HomePageTextBox
        '
        Me.HomePageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SuppliersBindingSource, "HomePage", True))
        Me.HomePageTextBox.Location = New System.Drawing.Point(752, 189)
        Me.HomePageTextBox.Name = "HomePageTextBox"
        Me.HomePageTextBox.Size = New System.Drawing.Size(454, 22)
        Me.HomePageTextBox.TabIndex = 24
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "SuppliersProducts"
        Me.ProductsBindingSource.DataSource = Me.SuppliersBindingSource
        '
        'ProductsDataGridView
        '
        Me.ProductsDataGridView.AutoGenerateColumns = False
        Me.ProductsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ProductsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewCheckBoxColumn1})
        Me.ProductsDataGridView.DataSource = Me.ProductsBindingSource
        Me.ProductsDataGridView.Location = New System.Drawing.Point(15, 244)
        Me.ProductsDataGridView.Name = "ProductsDataGridView"
        Me.ProductsDataGridView.RowTemplate.Height = 24
        Me.ProductsDataGridView.Size = New System.Drawing.Size(1191, 213)
        Me.ProductsDataGridView.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 99
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProductName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 123
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SupplierID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SupplierID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 102
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CategoryID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CategoryID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 107
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn5.HeaderText = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 137
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 94
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "UnitsInStock"
        Me.DataGridViewTextBoxColumn7.HeaderText = "UnitsInStock"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 115
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn8.HeaderText = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 125
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ReorderLevel"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 123
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Discontinued"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Discontinued"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 96
        '
        'frmsupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1222, 471)
        Me.Controls.Add(Me.ProductsDataGridView)
        Me.Controls.Add(SupplierIDLabel)
        Me.Controls.Add(Me.SupplierIDTextBox)
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
        Me.Controls.Add(HomePageLabel)
        Me.Controls.Add(Me.HomePageTextBox)
        Me.Controls.Add(Me.SuppliersBindingNavigator)
        Me.Name = "frmsupplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "supplier"
        CType(Me._NwindTables_1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SuppliersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SuppliersBindingNavigator.ResumeLayout(False)
        Me.SuppliersBindingNavigator.PerformLayout()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _NwindTables_1_DataSet As _NwindTables_1_DataSet
    Friend WithEvents SuppliersBindingSource As BindingSource
    Friend WithEvents SuppliersTableAdapter As _NwindTables_1_DataSetTableAdapters.SuppliersTableAdapter
    Friend WithEvents TableAdapterManager As _NwindTables_1_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SuppliersBindingNavigator As BindingNavigator
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
    Friend WithEvents SuppliersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SupplierIDTextBox As TextBox
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
    Friend WithEvents HomePageTextBox As TextBox
    Friend WithEvents ProductsTableAdapter As _NwindTables_1_DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
End Class
