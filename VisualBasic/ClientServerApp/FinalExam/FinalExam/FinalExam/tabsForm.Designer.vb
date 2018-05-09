<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tabsForm
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
        Dim Au_idLabel As System.Windows.Forms.Label
        Dim Au_lnameLabel As System.Windows.Forms.Label
        Dim Au_fnameLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim ZipLabel As System.Windows.Forms.Label
        Dim ContractLabel As System.Windows.Forms.Label
        Dim Pub_idLabel1 As System.Windows.Forms.Label
        Dim Pub_nameLabel As System.Windows.Forms.Label
        Dim CityLabel1 As System.Windows.Forms.Label
        Dim StateLabel1 As System.Windows.Forms.Label
        Dim CountryLabel As System.Windows.Forms.Label
        Dim Emp_idLabel As System.Windows.Forms.Label
        Dim FnameLabel As System.Windows.Forms.Label
        Dim MinitLabel As System.Windows.Forms.Label
        Dim LnameLabel As System.Windows.Forms.Label
        Dim Job_idLabel As System.Windows.Forms.Label
        Dim Job_lvlLabel As System.Windows.Forms.Label
        Dim Pub_idLabel2 As System.Windows.Forms.Label
        Dim Hire_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tabsForm))
        Me.Title_idLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TypeLabel = New System.Windows.Forms.Label()
        Me.Pub_idLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.AdvanceLabel = New System.Windows.Forms.Label()
        Me.RoyaltyLabel = New System.Windows.Forms.Label()
        Me.Ytd_salesLabel = New System.Windows.Forms.Label()
        Me.NotesLabel = New System.Windows.Forms.Label()
        Me.PubdateLabel = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.btnTitle = New System.Windows.Forms.Button()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.TitlesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PubsDataSet = New FinalExam.pubsDataSet()
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
        Me.Title_idTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.TypeTextBox = New System.Windows.Forms.TextBox()
        Me.Pub_idTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.AdvanceTextBox = New System.Windows.Forms.TextBox()
        Me.RoyaltyTextBox = New System.Windows.Forms.TextBox()
        Me.Ytd_salesTextBox = New System.Windows.Forms.TextBox()
        Me.NotesTextBox = New System.Windows.Forms.TextBox()
        Me.PubdateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnAuthor = New System.Windows.Forms.Button()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem1 = New System.Windows.Forms.ToolStripButton()
        Me.AuthorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnLocate = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Au_idTextBox = New System.Windows.Forms.TextBox()
        Me.Au_lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Au_fnameTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.ContractTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.btnPub = New System.Windows.Forms.Button()
        Me.BindingNavigator3 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem2 = New System.Windows.Forms.ToolStripButton()
        Me.PublishersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem2 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem2 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem2 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Pub_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.Pub_nameTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox1 = New System.Windows.Forms.TextBox()
        Me.StateTextBox1 = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnEmp = New System.Windows.Forms.Button()
        Me.BindingNavigator4 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem3 = New System.Windows.Forms.ToolStripButton()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem3 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem3 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem3 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Emp_idTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.MinitTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.Job_idTextBox = New System.Windows.Forms.TextBox()
        Me.Job_lvlTextBox = New System.Windows.Forms.TextBox()
        Me.Pub_idTextBox2 = New System.Windows.Forms.TextBox()
        Me.Hire_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TitlesTableAdapter = New FinalExam.pubsDataSetTableAdapters.titlesTableAdapter()
        Me.TableAdapterManager = New FinalExam.pubsDataSetTableAdapters.TableAdapterManager()
        Me.AuthorsTableAdapter = New FinalExam.pubsDataSetTableAdapters.authorsTableAdapter()
        Me.PublishersTableAdapter = New FinalExam.pubsDataSetTableAdapters.publishersTableAdapter()
        Me.EmployeeTableAdapter = New FinalExam.pubsDataSetTableAdapters.employeeTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Au_idLabel = New System.Windows.Forms.Label()
        Au_lnameLabel = New System.Windows.Forms.Label()
        Au_fnameLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        ZipLabel = New System.Windows.Forms.Label()
        ContractLabel = New System.Windows.Forms.Label()
        Pub_idLabel1 = New System.Windows.Forms.Label()
        Pub_nameLabel = New System.Windows.Forms.Label()
        CityLabel1 = New System.Windows.Forms.Label()
        StateLabel1 = New System.Windows.Forms.Label()
        CountryLabel = New System.Windows.Forms.Label()
        Emp_idLabel = New System.Windows.Forms.Label()
        FnameLabel = New System.Windows.Forms.Label()
        MinitLabel = New System.Windows.Forms.Label()
        LnameLabel = New System.Windows.Forms.Label()
        Job_idLabel = New System.Windows.Forms.Label()
        Job_lvlLabel = New System.Windows.Forms.Label()
        Pub_idLabel2 = New System.Windows.Forms.Label()
        Hire_dateLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PubsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator3.SuspendLayout()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator4.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Au_idLabel
        '
        Au_idLabel.AutoSize = True
        Au_idLabel.Location = New System.Drawing.Point(8, 46)
        Au_idLabel.Name = "Au_idLabel"
        Au_idLabel.Size = New System.Drawing.Size(43, 17)
        Au_idLabel.TabIndex = 0
        Au_idLabel.Text = "au id:"
        '
        'Au_lnameLabel
        '
        Au_lnameLabel.AutoSize = True
        Au_lnameLabel.Location = New System.Drawing.Point(8, 74)
        Au_lnameLabel.Name = "Au_lnameLabel"
        Au_lnameLabel.Size = New System.Drawing.Size(70, 17)
        Au_lnameLabel.TabIndex = 2
        Au_lnameLabel.Text = "au lname:"
        '
        'Au_fnameLabel
        '
        Au_fnameLabel.AutoSize = True
        Au_fnameLabel.Location = New System.Drawing.Point(8, 102)
        Au_fnameLabel.Name = "Au_fnameLabel"
        Au_fnameLabel.Size = New System.Drawing.Size(71, 17)
        Au_fnameLabel.TabIndex = 4
        Au_fnameLabel.Text = "au fname:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(8, 130)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(52, 17)
        PhoneLabel.TabIndex = 6
        PhoneLabel.Text = "phone:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(8, 158)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(63, 17)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "address:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(8, 186)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(33, 17)
        CityLabel.TabIndex = 10
        CityLabel.Text = "city:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(8, 214)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(43, 17)
        StateLabel.TabIndex = 12
        StateLabel.Text = "state:"
        '
        'ZipLabel
        '
        ZipLabel.AutoSize = True
        ZipLabel.Location = New System.Drawing.Point(8, 242)
        ZipLabel.Name = "ZipLabel"
        ZipLabel.Size = New System.Drawing.Size(30, 17)
        ZipLabel.TabIndex = 14
        ZipLabel.Text = "zip:"
        '
        'ContractLabel
        '
        ContractLabel.AutoSize = True
        ContractLabel.Location = New System.Drawing.Point(8, 270)
        ContractLabel.Name = "ContractLabel"
        ContractLabel.Size = New System.Drawing.Size(63, 17)
        ContractLabel.TabIndex = 16
        ContractLabel.Text = "contract:"
        '
        'Pub_idLabel1
        '
        Pub_idLabel1.AutoSize = True
        Pub_idLabel1.Location = New System.Drawing.Point(8, 46)
        Pub_idLabel1.Name = "Pub_idLabel1"
        Pub_idLabel1.Size = New System.Drawing.Size(51, 17)
        Pub_idLabel1.TabIndex = 0
        Pub_idLabel1.Text = "pub id:"
        '
        'Pub_nameLabel
        '
        Pub_nameLabel.AutoSize = True
        Pub_nameLabel.Location = New System.Drawing.Point(8, 74)
        Pub_nameLabel.Name = "Pub_nameLabel"
        Pub_nameLabel.Size = New System.Drawing.Size(75, 17)
        Pub_nameLabel.TabIndex = 2
        Pub_nameLabel.Text = "pub name:"
        '
        'CityLabel1
        '
        CityLabel1.AutoSize = True
        CityLabel1.Location = New System.Drawing.Point(8, 102)
        CityLabel1.Name = "CityLabel1"
        CityLabel1.Size = New System.Drawing.Size(33, 17)
        CityLabel1.TabIndex = 4
        CityLabel1.Text = "city:"
        '
        'StateLabel1
        '
        StateLabel1.AutoSize = True
        StateLabel1.Location = New System.Drawing.Point(8, 130)
        StateLabel1.Name = "StateLabel1"
        StateLabel1.Size = New System.Drawing.Size(43, 17)
        StateLabel1.TabIndex = 6
        StateLabel1.Text = "state:"
        '
        'CountryLabel
        '
        CountryLabel.AutoSize = True
        CountryLabel.Location = New System.Drawing.Point(8, 158)
        CountryLabel.Name = "CountryLabel"
        CountryLabel.Size = New System.Drawing.Size(59, 17)
        CountryLabel.TabIndex = 8
        CountryLabel.Text = "country:"
        '
        'Emp_idLabel
        '
        Emp_idLabel.AutoSize = True
        Emp_idLabel.Location = New System.Drawing.Point(8, 56)
        Emp_idLabel.Name = "Emp_idLabel"
        Emp_idLabel.Size = New System.Drawing.Size(54, 17)
        Emp_idLabel.TabIndex = 0
        Emp_idLabel.Text = "emp id:"
        '
        'FnameLabel
        '
        FnameLabel.AutoSize = True
        FnameLabel.Location = New System.Drawing.Point(8, 84)
        FnameLabel.Name = "FnameLabel"
        FnameLabel.Size = New System.Drawing.Size(51, 17)
        FnameLabel.TabIndex = 2
        FnameLabel.Text = "fname:"
        '
        'MinitLabel
        '
        MinitLabel.AutoSize = True
        MinitLabel.Location = New System.Drawing.Point(8, 112)
        MinitLabel.Name = "MinitLabel"
        MinitLabel.Size = New System.Drawing.Size(41, 17)
        MinitLabel.TabIndex = 4
        MinitLabel.Text = "minit:"
        '
        'LnameLabel
        '
        LnameLabel.AutoSize = True
        LnameLabel.Location = New System.Drawing.Point(8, 140)
        LnameLabel.Name = "LnameLabel"
        LnameLabel.Size = New System.Drawing.Size(50, 17)
        LnameLabel.TabIndex = 6
        LnameLabel.Text = "lname:"
        '
        'Job_idLabel
        '
        Job_idLabel.AutoSize = True
        Job_idLabel.Location = New System.Drawing.Point(8, 168)
        Job_idLabel.Name = "Job_idLabel"
        Job_idLabel.Size = New System.Drawing.Size(46, 17)
        Job_idLabel.TabIndex = 8
        Job_idLabel.Text = "job id:"
        '
        'Job_lvlLabel
        '
        Job_lvlLabel.AutoSize = True
        Job_lvlLabel.Location = New System.Drawing.Point(8, 196)
        Job_lvlLabel.Name = "Job_lvlLabel"
        Job_lvlLabel.Size = New System.Drawing.Size(48, 17)
        Job_lvlLabel.TabIndex = 10
        Job_lvlLabel.Text = "job lvl:"
        '
        'Pub_idLabel2
        '
        Pub_idLabel2.AutoSize = True
        Pub_idLabel2.Location = New System.Drawing.Point(8, 224)
        Pub_idLabel2.Name = "Pub_idLabel2"
        Pub_idLabel2.Size = New System.Drawing.Size(51, 17)
        Pub_idLabel2.TabIndex = 12
        Pub_idLabel2.Text = "pub id:"
        '
        'Hire_dateLabel
        '
        Hire_dateLabel.AutoSize = True
        Hire_dateLabel.Location = New System.Drawing.Point(8, 253)
        Hire_dateLabel.Name = "Hire_dateLabel"
        Hire_dateLabel.Size = New System.Drawing.Size(68, 17)
        Hire_dateLabel.TabIndex = 14
        Hire_dateLabel.Text = "hire date:"
        '
        'Title_idLabel
        '
        Me.Title_idLabel.AutoSize = True
        Me.Title_idLabel.Location = New System.Drawing.Point(6, 54)
        Me.Title_idLabel.Name = "Title_idLabel"
        Me.Title_idLabel.Size = New System.Drawing.Size(49, 17)
        Me.Title_idLabel.TabIndex = 0
        Me.Title_idLabel.Text = "title id:"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(6, 82)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(34, 17)
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "title:"
        '
        'TypeLabel
        '
        Me.TypeLabel.AutoSize = True
        Me.TypeLabel.Location = New System.Drawing.Point(6, 110)
        Me.TypeLabel.Name = "TypeLabel"
        Me.TypeLabel.Size = New System.Drawing.Size(39, 17)
        Me.TypeLabel.TabIndex = 4
        Me.TypeLabel.Text = "type:"
        '
        'Pub_idLabel
        '
        Me.Pub_idLabel.AutoSize = True
        Me.Pub_idLabel.Location = New System.Drawing.Point(6, 138)
        Me.Pub_idLabel.Name = "Pub_idLabel"
        Me.Pub_idLabel.Size = New System.Drawing.Size(51, 17)
        Me.Pub_idLabel.TabIndex = 6
        Me.Pub_idLabel.Text = "pub id:"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Location = New System.Drawing.Point(6, 166)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(43, 17)
        Me.PriceLabel.TabIndex = 8
        Me.PriceLabel.Text = "price:"
        '
        'AdvanceLabel
        '
        Me.AdvanceLabel.AutoSize = True
        Me.AdvanceLabel.Location = New System.Drawing.Point(6, 194)
        Me.AdvanceLabel.Name = "AdvanceLabel"
        Me.AdvanceLabel.Size = New System.Drawing.Size(66, 17)
        Me.AdvanceLabel.TabIndex = 10
        Me.AdvanceLabel.Text = "advance:"
        '
        'RoyaltyLabel
        '
        Me.RoyaltyLabel.AutoSize = True
        Me.RoyaltyLabel.Location = New System.Drawing.Point(6, 222)
        Me.RoyaltyLabel.Name = "RoyaltyLabel"
        Me.RoyaltyLabel.Size = New System.Drawing.Size(54, 17)
        Me.RoyaltyLabel.TabIndex = 12
        Me.RoyaltyLabel.Text = "royalty:"
        '
        'Ytd_salesLabel
        '
        Me.Ytd_salesLabel.AutoSize = True
        Me.Ytd_salesLabel.Location = New System.Drawing.Point(6, 250)
        Me.Ytd_salesLabel.Name = "Ytd_salesLabel"
        Me.Ytd_salesLabel.Size = New System.Drawing.Size(68, 17)
        Me.Ytd_salesLabel.TabIndex = 14
        Me.Ytd_salesLabel.Text = "ytd sales:"
        '
        'NotesLabel
        '
        Me.NotesLabel.AutoSize = True
        Me.NotesLabel.Location = New System.Drawing.Point(6, 278)
        Me.NotesLabel.Name = "NotesLabel"
        Me.NotesLabel.Size = New System.Drawing.Size(47, 17)
        Me.NotesLabel.TabIndex = 16
        Me.NotesLabel.Text = "notes:"
        '
        'PubdateLabel
        '
        Me.PubdateLabel.AutoSize = True
        Me.PubdateLabel.Location = New System.Drawing.Point(8, 409)
        Me.PubdateLabel.Name = "PubdateLabel"
        Me.PubdateLabel.Size = New System.Drawing.Size(64, 17)
        Me.PubdateLabel.TabIndex = 18
        Me.PubdateLabel.Text = "pubdate:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1914, 1017)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnTitle)
        Me.TabPage1.Controls.Add(Me.BindingNavigator1)
        Me.TabPage1.Controls.Add(Me.Title_idLabel)
        Me.TabPage1.Controls.Add(Me.Title_idTextBox)
        Me.TabPage1.Controls.Add(Me.TitleLabel)
        Me.TabPage1.Controls.Add(Me.TitleTextBox)
        Me.TabPage1.Controls.Add(Me.TypeLabel)
        Me.TabPage1.Controls.Add(Me.TypeTextBox)
        Me.TabPage1.Controls.Add(Me.Pub_idLabel)
        Me.TabPage1.Controls.Add(Me.Pub_idTextBox)
        Me.TabPage1.Controls.Add(Me.PriceLabel)
        Me.TabPage1.Controls.Add(Me.PriceTextBox)
        Me.TabPage1.Controls.Add(Me.AdvanceLabel)
        Me.TabPage1.Controls.Add(Me.AdvanceTextBox)
        Me.TabPage1.Controls.Add(Me.RoyaltyLabel)
        Me.TabPage1.Controls.Add(Me.RoyaltyTextBox)
        Me.TabPage1.Controls.Add(Me.Ytd_salesLabel)
        Me.TabPage1.Controls.Add(Me.Ytd_salesTextBox)
        Me.TabPage1.Controls.Add(Me.NotesLabel)
        Me.TabPage1.Controls.Add(Me.NotesTextBox)
        Me.TabPage1.Controls.Add(Me.PubdateLabel)
        Me.TabPage1.Controls.Add(Me.PubdateDateTimePicker)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1906, 988)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Titles"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnTitle
        '
        Me.btnTitle.Location = New System.Drawing.Point(11, 450)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(500, 64)
        Me.btnTitle.TabIndex = 21
        Me.btnTitle.Text = "&Tell Me About The Title"
        Me.btnTitle.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.TitlesBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1900, 27)
        Me.BindingNavigator1.TabIndex = 20
        Me.BindingNavigator1.Text = "BindingNavigator1"
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
        'TitlesBindingSource
        '
        Me.TitlesBindingSource.DataMember = "titles"
        Me.TitlesBindingSource.DataSource = Me.PubsDataSet
        '
        'PubsDataSet
        '
        Me.PubsDataSet.DataSetName = "pubsDataSet"
        Me.PubsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Title_idTextBox
        '
        Me.Title_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "title_id", True))
        Me.Title_idTextBox.Location = New System.Drawing.Point(80, 51)
        Me.Title_idTextBox.Name = "Title_idTextBox"
        Me.Title_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Title_idTextBox.TabIndex = 1
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(80, 79)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(431, 22)
        Me.TitleTextBox.TabIndex = 3
        '
        'TypeTextBox
        '
        Me.TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "type", True))
        Me.TypeTextBox.Location = New System.Drawing.Point(80, 107)
        Me.TypeTextBox.Name = "TypeTextBox"
        Me.TypeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TypeTextBox.TabIndex = 5
        '
        'Pub_idTextBox
        '
        Me.Pub_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "pub_id", True))
        Me.Pub_idTextBox.Location = New System.Drawing.Point(80, 135)
        Me.Pub_idTextBox.Name = "Pub_idTextBox"
        Me.Pub_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Pub_idTextBox.TabIndex = 7
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(80, 163)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PriceTextBox.TabIndex = 9
        '
        'AdvanceTextBox
        '
        Me.AdvanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "advance", True))
        Me.AdvanceTextBox.Location = New System.Drawing.Point(80, 191)
        Me.AdvanceTextBox.Name = "AdvanceTextBox"
        Me.AdvanceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AdvanceTextBox.TabIndex = 11
        '
        'RoyaltyTextBox
        '
        Me.RoyaltyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "royalty", True))
        Me.RoyaltyTextBox.Location = New System.Drawing.Point(80, 219)
        Me.RoyaltyTextBox.Name = "RoyaltyTextBox"
        Me.RoyaltyTextBox.Size = New System.Drawing.Size(200, 22)
        Me.RoyaltyTextBox.TabIndex = 13
        '
        'Ytd_salesTextBox
        '
        Me.Ytd_salesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "ytd_sales", True))
        Me.Ytd_salesTextBox.Location = New System.Drawing.Point(80, 247)
        Me.Ytd_salesTextBox.Name = "Ytd_salesTextBox"
        Me.Ytd_salesTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Ytd_salesTextBox.TabIndex = 15
        '
        'NotesTextBox
        '
        Me.NotesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TitlesBindingSource, "notes", True))
        Me.NotesTextBox.Location = New System.Drawing.Point(80, 275)
        Me.NotesTextBox.Multiline = True
        Me.NotesTextBox.Name = "NotesTextBox"
        Me.NotesTextBox.Size = New System.Drawing.Size(431, 124)
        Me.NotesTextBox.TabIndex = 17
        '
        'PubdateDateTimePicker
        '
        Me.PubdateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TitlesBindingSource, "pubdate", True))
        Me.PubdateDateTimePicker.Location = New System.Drawing.Point(82, 405)
        Me.PubdateDateTimePicker.Name = "PubdateDateTimePicker"
        Me.PubdateDateTimePicker.Size = New System.Drawing.Size(238, 22)
        Me.PubdateDateTimePicker.TabIndex = 19
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAuthor)
        Me.TabPage2.Controls.Add(Me.BindingNavigator2)
        Me.TabPage2.Controls.Add(Me.btnLocate)
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Controls.Add(Au_idLabel)
        Me.TabPage2.Controls.Add(Me.Au_idTextBox)
        Me.TabPage2.Controls.Add(Au_lnameLabel)
        Me.TabPage2.Controls.Add(Me.Au_lnameTextBox)
        Me.TabPage2.Controls.Add(Au_fnameLabel)
        Me.TabPage2.Controls.Add(Me.Au_fnameTextBox)
        Me.TabPage2.Controls.Add(PhoneLabel)
        Me.TabPage2.Controls.Add(Me.PhoneTextBox)
        Me.TabPage2.Controls.Add(AddressLabel)
        Me.TabPage2.Controls.Add(Me.AddressTextBox)
        Me.TabPage2.Controls.Add(CityLabel)
        Me.TabPage2.Controls.Add(Me.CityTextBox)
        Me.TabPage2.Controls.Add(StateLabel)
        Me.TabPage2.Controls.Add(Me.StateTextBox)
        Me.TabPage2.Controls.Add(ZipLabel)
        Me.TabPage2.Controls.Add(Me.ZipTextBox)
        Me.TabPage2.Controls.Add(ContractLabel)
        Me.TabPage2.Controls.Add(Me.ContractTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1906, 988)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Authors"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnAuthor
        '
        Me.btnAuthor.Location = New System.Drawing.Point(307, 321)
        Me.btnAuthor.Name = "btnAuthor"
        Me.btnAuthor.Size = New System.Drawing.Size(193, 23)
        Me.btnAuthor.TabIndex = 22
        Me.btnAuthor.Text = "&Tell Me About The Author"
        Me.btnAuthor.UseVisualStyleBackColor = True
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.BindingNavigatorAddNewItem1
        Me.BindingNavigator2.BindingSource = Me.AuthorsBindingSource
        Me.BindingNavigator2.CountItem = Me.BindingNavigatorCountItem1
        Me.BindingNavigator2.DeleteItem = Me.BindingNavigatorDeleteItem1
        Me.BindingNavigator2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.BindingNavigatorAddNewItem1, Me.BindingNavigatorDeleteItem1})
        Me.BindingNavigator2.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator2.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.BindingNavigator2.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.BindingNavigator2.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.BindingNavigator2.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.BindingNavigatorPositionItem1
        Me.BindingNavigator2.Size = New System.Drawing.Size(1900, 27)
        Me.BindingNavigator2.TabIndex = 20
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'BindingNavigatorAddNewItem1
        '
        Me.BindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem1.Image = CType(resources.GetObject("BindingNavigatorAddNewItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem1.Name = "BindingNavigatorAddNewItem1"
        Me.BindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem1.Text = "Add new"
        '
        'AuthorsBindingSource
        '
        Me.AuthorsBindingSource.DataMember = "authors"
        Me.AuthorsBindingSource.DataSource = Me.PubsDataSet
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem1.Text = "of {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem1
        '
        Me.BindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem1.Image = CType(resources.GetObject("BindingNavigatorDeleteItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem1.Name = "BindingNavigatorDeleteItem1"
        Me.BindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem1.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 27)
        '
        'btnLocate
        '
        Me.btnLocate.Location = New System.Drawing.Point(11, 321)
        Me.btnLocate.Name = "btnLocate"
        Me.btnLocate.Size = New System.Drawing.Size(290, 23)
        Me.btnLocate.TabIndex = 19
        Me.btnLocate.Text = "Locate Author"
        Me.btnLocate.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 373)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(1910, 647)
        Me.WebBrowser1.TabIndex = 18
        '
        'Au_idTextBox
        '
        Me.Au_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "au_id", True))
        Me.Au_idTextBox.Location = New System.Drawing.Point(85, 43)
        Me.Au_idTextBox.Name = "Au_idTextBox"
        Me.Au_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Au_idTextBox.TabIndex = 1
        '
        'Au_lnameTextBox
        '
        Me.Au_lnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "au_lname", True))
        Me.Au_lnameTextBox.Location = New System.Drawing.Point(85, 71)
        Me.Au_lnameTextBox.Name = "Au_lnameTextBox"
        Me.Au_lnameTextBox.Size = New System.Drawing.Size(216, 22)
        Me.Au_lnameTextBox.TabIndex = 3
        '
        'Au_fnameTextBox
        '
        Me.Au_fnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "au_fname", True))
        Me.Au_fnameTextBox.Location = New System.Drawing.Point(85, 99)
        Me.Au_fnameTextBox.Name = "Au_fnameTextBox"
        Me.Au_fnameTextBox.Size = New System.Drawing.Size(216, 22)
        Me.Au_fnameTextBox.TabIndex = 5
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(85, 127)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(216, 22)
        Me.PhoneTextBox.TabIndex = 7
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(85, 155)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(415, 22)
        Me.AddressTextBox.TabIndex = 9
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "city", True))
        Me.CityTextBox.Location = New System.Drawing.Point(85, 183)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(216, 22)
        Me.CityTextBox.TabIndex = 11
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "state", True))
        Me.StateTextBox.Location = New System.Drawing.Point(85, 211)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(216, 22)
        Me.StateTextBox.TabIndex = 13
        '
        'ZipTextBox
        '
        Me.ZipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "zip", True))
        Me.ZipTextBox.Location = New System.Drawing.Point(85, 239)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ZipTextBox.TabIndex = 15
        '
        'ContractTextBox
        '
        Me.ContractTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AuthorsBindingSource, "contract", True))
        Me.ContractTextBox.Location = New System.Drawing.Point(85, 267)
        Me.ContractTextBox.Name = "ContractTextBox"
        Me.ContractTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ContractTextBox.TabIndex = 17
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnPub)
        Me.TabPage3.Controls.Add(Me.BindingNavigator3)
        Me.TabPage3.Controls.Add(Pub_idLabel1)
        Me.TabPage3.Controls.Add(Me.Pub_idTextBox1)
        Me.TabPage3.Controls.Add(Pub_nameLabel)
        Me.TabPage3.Controls.Add(Me.Pub_nameTextBox)
        Me.TabPage3.Controls.Add(CityLabel1)
        Me.TabPage3.Controls.Add(Me.CityTextBox1)
        Me.TabPage3.Controls.Add(StateLabel1)
        Me.TabPage3.Controls.Add(Me.StateTextBox1)
        Me.TabPage3.Controls.Add(CountryLabel)
        Me.TabPage3.Controls.Add(Me.CountryTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1906, 988)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Publishers"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnPub
        '
        Me.btnPub.Location = New System.Drawing.Point(11, 229)
        Me.btnPub.Name = "btnPub"
        Me.btnPub.Size = New System.Drawing.Size(522, 64)
        Me.btnPub.TabIndex = 22
        Me.btnPub.Text = "&Tell Me About The Publisher"
        Me.btnPub.UseVisualStyleBackColor = True
        '
        'BindingNavigator3
        '
        Me.BindingNavigator3.AddNewItem = Me.BindingNavigatorAddNewItem2
        Me.BindingNavigator3.BindingSource = Me.PublishersBindingSource
        Me.BindingNavigator3.CountItem = Me.BindingNavigatorCountItem2
        Me.BindingNavigator3.DeleteItem = Me.BindingNavigatorDeleteItem2
        Me.BindingNavigator3.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem2, Me.BindingNavigatorMovePreviousItem2, Me.BindingNavigatorSeparator6, Me.BindingNavigatorPositionItem2, Me.BindingNavigatorCountItem2, Me.BindingNavigatorSeparator7, Me.BindingNavigatorMoveNextItem2, Me.BindingNavigatorMoveLastItem2, Me.BindingNavigatorSeparator8, Me.BindingNavigatorAddNewItem2, Me.BindingNavigatorDeleteItem2})
        Me.BindingNavigator3.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator3.MoveFirstItem = Me.BindingNavigatorMoveFirstItem2
        Me.BindingNavigator3.MoveLastItem = Me.BindingNavigatorMoveLastItem2
        Me.BindingNavigator3.MoveNextItem = Me.BindingNavigatorMoveNextItem2
        Me.BindingNavigator3.MovePreviousItem = Me.BindingNavigatorMovePreviousItem2
        Me.BindingNavigator3.Name = "BindingNavigator3"
        Me.BindingNavigator3.PositionItem = Me.BindingNavigatorPositionItem2
        Me.BindingNavigator3.Size = New System.Drawing.Size(1906, 27)
        Me.BindingNavigator3.TabIndex = 10
        Me.BindingNavigator3.Text = "BindingNavigator3"
        '
        'BindingNavigatorAddNewItem2
        '
        Me.BindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem2.Image = CType(resources.GetObject("BindingNavigatorAddNewItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem2.Name = "BindingNavigatorAddNewItem2"
        Me.BindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem2.Text = "Add new"
        '
        'PublishersBindingSource
        '
        Me.PublishersBindingSource.DataMember = "publishers"
        Me.PublishersBindingSource.DataSource = Me.PubsDataSet
        '
        'BindingNavigatorCountItem2
        '
        Me.BindingNavigatorCountItem2.Name = "BindingNavigatorCountItem2"
        Me.BindingNavigatorCountItem2.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem2.Text = "of {0}"
        Me.BindingNavigatorCountItem2.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem2
        '
        Me.BindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem2.Image = CType(resources.GetObject("BindingNavigatorDeleteItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem2.Name = "BindingNavigatorDeleteItem2"
        Me.BindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem2.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem2
        '
        Me.BindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem2.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem2.Name = "BindingNavigatorMoveFirstItem2"
        Me.BindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem2.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem2
        '
        Me.BindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem2.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem2.Name = "BindingNavigatorMovePreviousItem2"
        Me.BindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem2.Text = "Move previous"
        '
        'BindingNavigatorSeparator6
        '
        Me.BindingNavigatorSeparator6.Name = "BindingNavigatorSeparator6"
        Me.BindingNavigatorSeparator6.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem2
        '
        Me.BindingNavigatorPositionItem2.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem2.AutoSize = False
        Me.BindingNavigatorPositionItem2.Name = "BindingNavigatorPositionItem2"
        Me.BindingNavigatorPositionItem2.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem2.Text = "0"
        Me.BindingNavigatorPositionItem2.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator7
        '
        Me.BindingNavigatorSeparator7.Name = "BindingNavigatorSeparator7"
        Me.BindingNavigatorSeparator7.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem2
        '
        Me.BindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem2.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem2.Name = "BindingNavigatorMoveNextItem2"
        Me.BindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem2.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem2
        '
        Me.BindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem2.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem2.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem2.Name = "BindingNavigatorMoveLastItem2"
        Me.BindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem2.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem2.Text = "Move last"
        '
        'BindingNavigatorSeparator8
        '
        Me.BindingNavigatorSeparator8.Name = "BindingNavigatorSeparator8"
        Me.BindingNavigatorSeparator8.Size = New System.Drawing.Size(6, 27)
        '
        'Pub_idTextBox1
        '
        Me.Pub_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "pub_id", True))
        Me.Pub_idTextBox1.Location = New System.Drawing.Point(89, 43)
        Me.Pub_idTextBox1.Name = "Pub_idTextBox1"
        Me.Pub_idTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Pub_idTextBox1.TabIndex = 1
        '
        'Pub_nameTextBox
        '
        Me.Pub_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "pub_name", True))
        Me.Pub_nameTextBox.Location = New System.Drawing.Point(89, 71)
        Me.Pub_nameTextBox.Name = "Pub_nameTextBox"
        Me.Pub_nameTextBox.Size = New System.Drawing.Size(444, 22)
        Me.Pub_nameTextBox.TabIndex = 3
        '
        'CityTextBox1
        '
        Me.CityTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "city", True))
        Me.CityTextBox1.Location = New System.Drawing.Point(89, 99)
        Me.CityTextBox1.Name = "CityTextBox1"
        Me.CityTextBox1.Size = New System.Drawing.Size(307, 22)
        Me.CityTextBox1.TabIndex = 5
        '
        'StateTextBox1
        '
        Me.StateTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "state", True))
        Me.StateTextBox1.Location = New System.Drawing.Point(89, 127)
        Me.StateTextBox1.Name = "StateTextBox1"
        Me.StateTextBox1.Size = New System.Drawing.Size(307, 22)
        Me.StateTextBox1.TabIndex = 7
        '
        'CountryTextBox
        '
        Me.CountryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PublishersBindingSource, "country", True))
        Me.CountryTextBox.Location = New System.Drawing.Point(89, 155)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(191, 22)
        Me.CountryTextBox.TabIndex = 9
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.btnEmp)
        Me.TabPage4.Controls.Add(Me.BindingNavigator4)
        Me.TabPage4.Controls.Add(Emp_idLabel)
        Me.TabPage4.Controls.Add(Me.Emp_idTextBox)
        Me.TabPage4.Controls.Add(FnameLabel)
        Me.TabPage4.Controls.Add(Me.FnameTextBox)
        Me.TabPage4.Controls.Add(MinitLabel)
        Me.TabPage4.Controls.Add(Me.MinitTextBox)
        Me.TabPage4.Controls.Add(LnameLabel)
        Me.TabPage4.Controls.Add(Me.LnameTextBox)
        Me.TabPage4.Controls.Add(Job_idLabel)
        Me.TabPage4.Controls.Add(Me.Job_idTextBox)
        Me.TabPage4.Controls.Add(Job_lvlLabel)
        Me.TabPage4.Controls.Add(Me.Job_lvlTextBox)
        Me.TabPage4.Controls.Add(Pub_idLabel2)
        Me.TabPage4.Controls.Add(Me.Pub_idTextBox2)
        Me.TabPage4.Controls.Add(Hire_dateLabel)
        Me.TabPage4.Controls.Add(Me.Hire_dateDateTimePicker)
        Me.TabPage4.Location = New System.Drawing.Point(4, 25)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1906, 988)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Employee"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'btnEmp
        '
        Me.btnEmp.Location = New System.Drawing.Point(11, 302)
        Me.btnEmp.Name = "btnEmp"
        Me.btnEmp.Size = New System.Drawing.Size(507, 64)
        Me.btnEmp.TabIndex = 22
        Me.btnEmp.Text = "&Tell Me About The Employee"
        Me.btnEmp.UseVisualStyleBackColor = True
        '
        'BindingNavigator4
        '
        Me.BindingNavigator4.AddNewItem = Me.BindingNavigatorAddNewItem3
        Me.BindingNavigator4.BindingSource = Me.EmployeeBindingSource
        Me.BindingNavigator4.CountItem = Me.BindingNavigatorCountItem3
        Me.BindingNavigator4.DeleteItem = Me.BindingNavigatorDeleteItem3
        Me.BindingNavigator4.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem3, Me.BindingNavigatorMovePreviousItem3, Me.BindingNavigatorSeparator9, Me.BindingNavigatorPositionItem3, Me.BindingNavigatorCountItem3, Me.BindingNavigatorSeparator10, Me.BindingNavigatorMoveNextItem3, Me.BindingNavigatorMoveLastItem3, Me.BindingNavigatorSeparator11, Me.BindingNavigatorAddNewItem3, Me.BindingNavigatorDeleteItem3})
        Me.BindingNavigator4.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator4.MoveFirstItem = Me.BindingNavigatorMoveFirstItem3
        Me.BindingNavigator4.MoveLastItem = Me.BindingNavigatorMoveLastItem3
        Me.BindingNavigator4.MoveNextItem = Me.BindingNavigatorMoveNextItem3
        Me.BindingNavigator4.MovePreviousItem = Me.BindingNavigatorMovePreviousItem3
        Me.BindingNavigator4.Name = "BindingNavigator4"
        Me.BindingNavigator4.PositionItem = Me.BindingNavigatorPositionItem3
        Me.BindingNavigator4.Size = New System.Drawing.Size(1906, 27)
        Me.BindingNavigator4.TabIndex = 16
        Me.BindingNavigator4.Text = "BindingNavigator4"
        '
        'BindingNavigatorAddNewItem3
        '
        Me.BindingNavigatorAddNewItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem3.Image = CType(resources.GetObject("BindingNavigatorAddNewItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem3.Name = "BindingNavigatorAddNewItem3"
        Me.BindingNavigatorAddNewItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem3.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem3.Text = "Add new"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.PubsDataSet
        '
        'BindingNavigatorCountItem3
        '
        Me.BindingNavigatorCountItem3.Name = "BindingNavigatorCountItem3"
        Me.BindingNavigatorCountItem3.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem3.Text = "of {0}"
        Me.BindingNavigatorCountItem3.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem3
        '
        Me.BindingNavigatorDeleteItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem3.Image = CType(resources.GetObject("BindingNavigatorDeleteItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem3.Name = "BindingNavigatorDeleteItem3"
        Me.BindingNavigatorDeleteItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem3.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem3.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem3
        '
        Me.BindingNavigatorMoveFirstItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem3.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem3.Name = "BindingNavigatorMoveFirstItem3"
        Me.BindingNavigatorMoveFirstItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem3.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem3.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem3
        '
        Me.BindingNavigatorMovePreviousItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem3.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem3.Name = "BindingNavigatorMovePreviousItem3"
        Me.BindingNavigatorMovePreviousItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem3.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem3.Text = "Move previous"
        '
        'BindingNavigatorSeparator9
        '
        Me.BindingNavigatorSeparator9.Name = "BindingNavigatorSeparator9"
        Me.BindingNavigatorSeparator9.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem3
        '
        Me.BindingNavigatorPositionItem3.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem3.AutoSize = False
        Me.BindingNavigatorPositionItem3.Name = "BindingNavigatorPositionItem3"
        Me.BindingNavigatorPositionItem3.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem3.Text = "0"
        Me.BindingNavigatorPositionItem3.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator10
        '
        Me.BindingNavigatorSeparator10.Name = "BindingNavigatorSeparator10"
        Me.BindingNavigatorSeparator10.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem3
        '
        Me.BindingNavigatorMoveNextItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem3.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem3.Name = "BindingNavigatorMoveNextItem3"
        Me.BindingNavigatorMoveNextItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem3.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem3.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem3
        '
        Me.BindingNavigatorMoveLastItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem3.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem3.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem3.Name = "BindingNavigatorMoveLastItem3"
        Me.BindingNavigatorMoveLastItem3.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem3.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem3.Text = "Move last"
        '
        'BindingNavigatorSeparator11
        '
        Me.BindingNavigatorSeparator11.Name = "BindingNavigatorSeparator11"
        Me.BindingNavigatorSeparator11.Size = New System.Drawing.Size(6, 27)
        '
        'Emp_idTextBox
        '
        Me.Emp_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "emp_id", True))
        Me.Emp_idTextBox.Location = New System.Drawing.Point(82, 53)
        Me.Emp_idTextBox.Name = "Emp_idTextBox"
        Me.Emp_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Emp_idTextBox.TabIndex = 1
        '
        'FnameTextBox
        '
        Me.FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "fname", True))
        Me.FnameTextBox.Location = New System.Drawing.Point(82, 81)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(436, 22)
        Me.FnameTextBox.TabIndex = 3
        '
        'MinitTextBox
        '
        Me.MinitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "minit", True))
        Me.MinitTextBox.Location = New System.Drawing.Point(82, 109)
        Me.MinitTextBox.Name = "MinitTextBox"
        Me.MinitTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MinitTextBox.TabIndex = 5
        '
        'LnameTextBox
        '
        Me.LnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "lname", True))
        Me.LnameTextBox.Location = New System.Drawing.Point(82, 137)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(436, 22)
        Me.LnameTextBox.TabIndex = 7
        '
        'Job_idTextBox
        '
        Me.Job_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "job_id", True))
        Me.Job_idTextBox.Location = New System.Drawing.Point(82, 165)
        Me.Job_idTextBox.Name = "Job_idTextBox"
        Me.Job_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Job_idTextBox.TabIndex = 9
        '
        'Job_lvlTextBox
        '
        Me.Job_lvlTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "job_lvl", True))
        Me.Job_lvlTextBox.Location = New System.Drawing.Point(82, 193)
        Me.Job_lvlTextBox.Name = "Job_lvlTextBox"
        Me.Job_lvlTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Job_lvlTextBox.TabIndex = 11
        '
        'Pub_idTextBox2
        '
        Me.Pub_idTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "pub_id", True))
        Me.Pub_idTextBox2.Location = New System.Drawing.Point(82, 221)
        Me.Pub_idTextBox2.Name = "Pub_idTextBox2"
        Me.Pub_idTextBox2.Size = New System.Drawing.Size(200, 22)
        Me.Pub_idTextBox2.TabIndex = 13
        '
        'Hire_dateDateTimePicker
        '
        Me.Hire_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmployeeBindingSource, "hire_date", True))
        Me.Hire_dateDateTimePicker.Location = New System.Drawing.Point(82, 249)
        Me.Hire_dateDateTimePicker.Name = "Hire_dateDateTimePicker"
        Me.Hire_dateDateTimePicker.Size = New System.Drawing.Size(242, 22)
        Me.Hire_dateDateTimePicker.TabIndex = 15
        '
        'TitlesTableAdapter
        '
        Me.TitlesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.authorsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.publishersTableAdapter = Nothing
        Me.TableAdapterManager.titleauthorTableAdapter = Nothing
        Me.TableAdapterManager.titlesTableAdapter = Me.TitlesTableAdapter
        Me.TableAdapterManager.UpdateOrder = FinalExam.pubsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AuthorsTableAdapter
        '
        Me.AuthorsTableAdapter.ClearBeforeFill = True
        '
        'PublishersTableAdapter
        '
        Me.PublishersTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1914, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(108, 26)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'tabsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "tabsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tabsForm"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.TitlesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PubsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        CType(Me.AuthorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BindingNavigator3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator3.ResumeLayout(False)
        Me.BindingNavigator3.PerformLayout()
        CType(Me.PublishersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.BindingNavigator4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator4.ResumeLayout(False)
        Me.BindingNavigator4.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents PubsDataSet As pubsDataSet
    Friend WithEvents TitlesBindingSource As BindingSource
    Friend WithEvents TitlesTableAdapter As pubsDataSetTableAdapters.titlesTableAdapter
    Friend WithEvents TableAdapterManager As pubsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Title_idTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents TypeTextBox As TextBox
    Friend WithEvents Pub_idTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents AdvanceTextBox As TextBox
    Friend WithEvents RoyaltyTextBox As TextBox
    Friend WithEvents Ytd_salesTextBox As TextBox
    Friend WithEvents NotesTextBox As TextBox
    Friend WithEvents PubdateDateTimePicker As DateTimePicker
    Friend WithEvents Title_idLabel As Label
    Friend WithEvents TitleLabel As Label
    Friend WithEvents TypeLabel As Label
    Friend WithEvents Pub_idLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents AdvanceLabel As Label
    Friend WithEvents RoyaltyLabel As Label
    Friend WithEvents Ytd_salesLabel As Label
    Friend WithEvents NotesLabel As Label
    Friend WithEvents PubdateLabel As Label
    Friend WithEvents AuthorsBindingSource As BindingSource
    Friend WithEvents AuthorsTableAdapter As pubsDataSetTableAdapters.authorsTableAdapter
    Friend WithEvents Au_idTextBox As TextBox
    Friend WithEvents Au_lnameTextBox As TextBox
    Friend WithEvents Au_fnameTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents ContractTextBox As TextBox
    Friend WithEvents PublishersBindingSource As BindingSource
    Friend WithEvents PublishersTableAdapter As pubsDataSetTableAdapters.publishersTableAdapter
    Friend WithEvents Pub_idTextBox1 As TextBox
    Friend WithEvents Pub_nameTextBox As TextBox
    Friend WithEvents CityTextBox1 As TextBox
    Friend WithEvents StateTextBox1 As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As pubsDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents Emp_idTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents MinitTextBox As TextBox
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents Job_idTextBox As TextBox
    Friend WithEvents Job_lvlTextBox As TextBox
    Friend WithEvents Pub_idTextBox2 As TextBox
    Friend WithEvents Hire_dateDateTimePicker As DateTimePicker
    Friend WithEvents btnLocate As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents BindingNavigator2 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem1 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator3 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem1 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator4 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem1 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator5 As ToolStripSeparator
    Friend WithEvents BindingNavigator3 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem2 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator6 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem2 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator7 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem2 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator8 As ToolStripSeparator
    Friend WithEvents BindingNavigator4 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem3 As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator9 As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem3 As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator10 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem3 As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator11 As ToolStripSeparator
    Friend WithEvents btnTitle As Button
    Friend WithEvents btnAuthor As Button
    Friend WithEvents btnPub As Button
    Friend WithEvents btnEmp As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
