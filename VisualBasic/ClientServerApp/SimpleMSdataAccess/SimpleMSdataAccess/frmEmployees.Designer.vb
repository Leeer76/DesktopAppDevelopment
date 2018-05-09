<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim TitleOfCourtesyLabel As System.Windows.Forms.Label
        Dim BirthDateLabel As System.Windows.Forms.Label
        Dim HireDateLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim RegionLabel As System.Windows.Forms.Label
        Dim PostalCodeLabel As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim ReportsToLabel As System.Windows.Forms.Label
        Me._NwindTables_1_DataSet = New SimpleMSdataAccess._NwindTables_1_DataSet()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.TableAdapterManager()
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
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.TitleOfCourtesyTextBox = New System.Windows.Forms.TextBox()
        Me.BirthDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HireDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.PhotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.ReportsToTextBox = New System.Windows.Forms.TextBox()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrdersTableAdapter = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.OrdersTableAdapter()
        Me.OrdersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Order_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_DetailsTableAdapter = New SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.Order_DetailsTableAdapter()
        Me.Order_DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        EmployeeIDLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        TitleOfCourtesyLabel = New System.Windows.Forms.Label()
        BirthDateLabel = New System.Windows.Forms.Label()
        HireDateLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        RegionLabel = New System.Windows.Forms.Label()
        PostalCodeLabel = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        ReportsToLabel = New System.Windows.Forms.Label()
        CType(Me._NwindTables_1_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_NwindTables_1_DataSet
        '
        Me._NwindTables_1_DataSet.DataSetName = "_NwindTables_1_DataSet"
        Me._NwindTables_1_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me._NwindTables_1_DataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.Order_DetailsTableAdapter = Me.Order_DetailsTableAdapter
        Me.TableAdapterManager.OrdersTableAdapter = Me.OrdersTableAdapter
        Me.TableAdapterManager.ProductsTableAdapter = Nothing
        Me.TableAdapterManager.ShippersTableAdapter = Nothing
        Me.TableAdapterManager.SuppliersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = SimpleMSdataAccess._NwindTables_1_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(925, 27)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(12, 54)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(91, 17)
        EmployeeIDLabel.TabIndex = 1
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'EmployeeIDTextBox
        '
        Me.EmployeeIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "EmployeeID", True))
        Me.EmployeeIDTextBox.Location = New System.Drawing.Point(136, 51)
        Me.EmployeeIDTextBox.Name = "EmployeeIDTextBox"
        Me.EmployeeIDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmployeeIDTextBox.TabIndex = 2
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(12, 82)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(80, 17)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(136, 79)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LastNameTextBox.TabIndex = 4
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(12, 110)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(80, 17)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(136, 107)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(12, 138)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(39, 17)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(136, 135)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TitleTextBox.TabIndex = 8
        '
        'TitleOfCourtesyLabel
        '
        TitleOfCourtesyLabel.AutoSize = True
        TitleOfCourtesyLabel.Location = New System.Drawing.Point(12, 166)
        TitleOfCourtesyLabel.Name = "TitleOfCourtesyLabel"
        TitleOfCourtesyLabel.Size = New System.Drawing.Size(118, 17)
        TitleOfCourtesyLabel.TabIndex = 9
        TitleOfCourtesyLabel.Text = "Title Of Courtesy:"
        '
        'TitleOfCourtesyTextBox
        '
        Me.TitleOfCourtesyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "TitleOfCourtesy", True))
        Me.TitleOfCourtesyTextBox.Location = New System.Drawing.Point(136, 163)
        Me.TitleOfCourtesyTextBox.Name = "TitleOfCourtesyTextBox"
        Me.TitleOfCourtesyTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TitleOfCourtesyTextBox.TabIndex = 10
        '
        'BirthDateLabel
        '
        BirthDateLabel.AutoSize = True
        BirthDateLabel.Location = New System.Drawing.Point(12, 223)
        BirthDateLabel.Name = "BirthDateLabel"
        BirthDateLabel.Size = New System.Drawing.Size(75, 17)
        BirthDateLabel.TabIndex = 11
        BirthDateLabel.Text = "Birth Date:"
        '
        'BirthDateDateTimePicker
        '
        Me.BirthDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeesBindingSource, "BirthDate", True))
        Me.BirthDateDateTimePicker.Location = New System.Drawing.Point(136, 219)
        Me.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker"
        Me.BirthDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.BirthDateDateTimePicker.TabIndex = 12
        '
        'HireDateLabel
        '
        HireDateLabel.AutoSize = True
        HireDateLabel.Location = New System.Drawing.Point(342, 223)
        HireDateLabel.Name = "HireDateLabel"
        HireDateLabel.Size = New System.Drawing.Size(72, 17)
        HireDateLabel.TabIndex = 13
        HireDateLabel.Text = "Hire Date:"
        '
        'HireDateDateTimePicker
        '
        Me.HireDateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeesBindingSource, "HireDate", True))
        Me.HireDateDateTimePicker.Location = New System.Drawing.Point(466, 219)
        Me.HireDateDateTimePicker.Name = "HireDateDateTimePicker"
        Me.HireDateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.HireDateDateTimePicker.TabIndex = 14
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(342, 51)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(64, 17)
        AddressLabel.TabIndex = 15
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(466, 48)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AddressTextBox.TabIndex = 16
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(342, 79)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(35, 17)
        CityLabel.TabIndex = 17
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "City", True))
        Me.CityTextBox.Location = New System.Drawing.Point(466, 76)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CityTextBox.TabIndex = 18
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(342, 107)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(57, 17)
        RegionLabel.TabIndex = 19
        RegionLabel.Text = "Region:"
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(466, 104)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(200, 22)
        Me.RegionTextBox.TabIndex = 20
        '
        'PostalCodeLabel
        '
        PostalCodeLabel.AutoSize = True
        PostalCodeLabel.Location = New System.Drawing.Point(342, 135)
        PostalCodeLabel.Name = "PostalCodeLabel"
        PostalCodeLabel.Size = New System.Drawing.Size(88, 17)
        PostalCodeLabel.TabIndex = 21
        PostalCodeLabel.Text = "Postal Code:"
        '
        'PostalCodeTextBox
        '
        Me.PostalCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "PostalCode", True))
        Me.PostalCodeTextBox.Location = New System.Drawing.Point(466, 132)
        Me.PostalCodeTextBox.Name = "PostalCodeTextBox"
        Me.PostalCodeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PostalCodeTextBox.TabIndex = 22
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(342, 163)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(61, 17)
        CountryLabel.TabIndex = 23
        CountryLabel.Text = "Country:"
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(466, 160)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CountryTextBox.TabIndex = 24
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Location = New System.Drawing.Point(342, 191)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(94, 17)
        HomePhoneLabel.TabIndex = 25
        HomePhoneLabel.Text = "Home Phone:"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "HomePhone", True))
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(466, 188)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(200, 22)
        Me.HomePhoneTextBox.TabIndex = 26
        '
        'PhotoPictureBox
        '
        Me.PhotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmployeesBindingSource, "Photo", True))
        Me.PhotoPictureBox.Location = New System.Drawing.Point(672, 48)
        Me.PhotoPictureBox.Name = "PhotoPictureBox"
        Me.PhotoPictureBox.Size = New System.Drawing.Size(237, 271)
        Me.PhotoPictureBox.TabIndex = 30
        Me.PhotoPictureBox.TabStop = False
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(12, 247)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(654, 72)
        Me.NotesTextBox.TabIndex = 32
        '
        'ReportsToLabel
        '
        ReportsToLabel.AutoSize = True
        ReportsToLabel.Location = New System.Drawing.Point(12, 194)
        ReportsToLabel.Name = "ReportsToLabel"
        ReportsToLabel.Size = New System.Drawing.Size(83, 17)
        ReportsToLabel.TabIndex = 33
        ReportsToLabel.Text = "Reports To:"
        '
        'ReportsToTextBox
        '
        Me.ReportsToTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "ReportsTo", True))
        Me.ReportsToTextBox.Location = New System.Drawing.Point(136, 191)
        Me.ReportsToTextBox.Name = "ReportsToTextBox"
        Me.ReportsToTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ReportsToTextBox.TabIndex = 34
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "EmployeesOrders"
        Me.OrdersBindingSource.DataSource = Me.EmployeesBindingSource
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrdersDataGridView
        '
        Me.OrdersDataGridView.AutoGenerateColumns = False
        Me.OrdersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.OrdersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrdersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.OrdersDataGridView.DataSource = Me.OrdersBindingSource
        Me.OrdersDataGridView.Location = New System.Drawing.Point(12, 352)
        Me.OrdersDataGridView.Name = "OrdersDataGridView"
        Me.OrdersDataGridView.RowTemplate.Height = 24
        Me.OrdersDataGridView.Size = New System.Drawing.Size(897, 168)
        Me.OrdersDataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "OrderID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "OrderID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 87
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CustomerID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CustomerID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 110
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 112
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrderDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OrderDate"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 104
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RequiredDate"
        Me.DataGridViewTextBoxColumn5.HeaderText = "RequiredDate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ShippedDate"
        Me.DataGridViewTextBoxColumn6.HeaderText = "ShippedDate"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 119
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ShipVia"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ShipVia"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 85
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Freight"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Freight"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 81
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ShipName"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ShipName"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 102
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "ShipAddress"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ShipAddress"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 117
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ShipCity"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ShipCity"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 88
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ShipRegion"
        Me.DataGridViewTextBoxColumn12.HeaderText = "ShipRegion"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 110
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "ShipPostalCode"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ShipPostalCode"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 137
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "ShipCountry"
        Me.DataGridViewTextBoxColumn14.HeaderText = "ShipCountry"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 114
        '
        'Order_DetailsBindingSource
        '
        Me.Order_DetailsBindingSource.DataMember = "Order Details"
        Me.Order_DetailsBindingSource.DataSource = Me._NwindTables_1_DataSet
        '
        'Order_DetailsTableAdapter
        '
        Me.Order_DetailsTableAdapter.ClearBeforeFill = True
        '
        'Order_DetailsDataGridView
        '
        Me.Order_DetailsDataGridView.AutoGenerateColumns = False
        Me.Order_DetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.Order_DetailsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Order_DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Order_DetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.Order_DetailsDataGridView.DataSource = Me.Order_DetailsBindingSource
        Me.Order_DetailsDataGridView.Location = New System.Drawing.Point(12, 542)
        Me.Order_DetailsDataGridView.Name = "Order_DetailsDataGridView"
        Me.Order_DetailsDataGridView.RowTemplate.Height = 24
        Me.Order_DetailsDataGridView.Size = New System.Drawing.Size(897, 141)
        Me.Order_DetailsDataGridView.TabIndex = 34
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "OrderID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "OrderID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Width = 87
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn16.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 99
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "UnitPrice"
        Me.DataGridViewTextBoxColumn17.HeaderText = "UnitPrice"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 94
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 90
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "Discount"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Discount"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 92
        '
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 693)
        Me.Controls.Add(Me.Order_DetailsDataGridView)
        Me.Controls.Add(Me.OrdersDataGridView)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.EmployeeIDTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(TitleOfCourtesyLabel)
        Me.Controls.Add(Me.TitleOfCourtesyTextBox)
        Me.Controls.Add(BirthDateLabel)
        Me.Controls.Add(Me.BirthDateDateTimePicker)
        Me.Controls.Add(HireDateLabel)
        Me.Controls.Add(Me.HireDateDateTimePicker)
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
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(Me.PhotoPictureBox)
        Me.Controls.Add(Me.NotesTextBox)
        Me.Controls.Add(ReportsToLabel)
        Me.Controls.Add(Me.ReportsToTextBox)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Name = "frmEmployees"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Employees"
        CType(Me._NwindTables_1_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        CType(Me.PhotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _NwindTables_1_DataSet As _NwindTables_1_DataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As _NwindTables_1_DataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As _NwindTables_1_DataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents OrdersTableAdapter As _NwindTables_1_DataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents EmployeeIDTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents TitleOfCourtesyTextBox As TextBox
    Friend WithEvents BirthDateDateTimePicker As DateTimePicker
    Friend WithEvents HireDateDateTimePicker As DateTimePicker
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents RegionTextBox As TextBox
    Friend WithEvents PostalCodeTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents HomePhoneTextBox As TextBox
    Friend WithEvents PhotoPictureBox As PictureBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents ReportsToTextBox As TextBox
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents Order_DetailsTableAdapter As _NwindTables_1_DataSetTableAdapters.Order_DetailsTableAdapter
    Friend WithEvents OrdersDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Order_DetailsBindingSource As BindingSource
    Friend WithEvents Order_DetailsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
End Class
