<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductsListForm
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
        Me.ProductListBox = New System.Windows.Forms.ListBox()
        Me.ProductsListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductsListBox_DataSet = New ProductsListBoxNavigation.ProductsListBox_DataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ProductsListTableAdapter = New ProductsListBoxNavigation.ProductsListBox_DataSetTableAdapters.ProductsListTableAdapter()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.ProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.txtUnitStock = New System.Windows.Forms.TextBox()
        Me.txtUnitOrder = New System.Windows.Forms.TextBox()
        Me.txtReorderLevel = New System.Windows.Forms.TextBox()
        Me.txtQtyUnit = New System.Windows.Forms.TextBox()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.ProductsTableAdapter = New ProductsListBoxNavigation.ProductsListBox_DataSetTableAdapters.ProductsTableAdapter()
        Me.ProductsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnProductName = New System.Windows.Forms.Button()
        Me.btnCategoryId = New System.Windows.Forms.Button()
        Me.btnQtyUnit = New System.Windows.Forms.Button()
        Me.btnUnitPrice = New System.Windows.Forms.Button()
        Me.btnUnitStock = New System.Windows.Forms.Button()
        Me.btnUnitsOrder = New System.Windows.Forms.Button()
        Me.btnReorderLevel = New System.Windows.Forms.Button()
        Me.btnSupplier = New System.Windows.Forms.Button()
        CType(Me.ProductsListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsListBox_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductListBox
        '
        Me.ProductListBox.DataSource = Me.ProductsListBindingSource
        Me.ProductListBox.DisplayMember = "ProductID"
        Me.ProductListBox.FormattingEnabled = True
        Me.ProductListBox.ItemHeight = 16
        Me.ProductListBox.Location = New System.Drawing.Point(16, 33)
        Me.ProductListBox.Name = "ProductListBox"
        Me.ProductListBox.Size = New System.Drawing.Size(71, 372)
        Me.ProductListBox.TabIndex = 1
        Me.ProductListBox.ValueMember = "ProductID"
        '
        'ProductsListBindingSource
        '
        Me.ProductsListBindingSource.DataMember = "ProductsList"
        Me.ProductsListBindingSource.DataSource = Me.ProductsListBox_DataSet
        '
        'ProductsListBox_DataSet
        '
        Me.ProductsListBox_DataSet.DataSetName = "ProductsListBox_DataSet"
        Me.ProductsListBox_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(166, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(166, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Supplier ID:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Category ID:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(166, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Qty per unit:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Unit price:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(166, 259)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Units in stock:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(166, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Units on order:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(166, 349)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Reorder level:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProductsListTableAdapter
        '
        Me.ProductsListTableAdapter.ClearBeforeFill = True
        '
        'txtProductName
        '
        Me.txtProductName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ProductName", True))
        Me.txtProductName.Location = New System.Drawing.Point(166, 54)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(300, 22)
        Me.txtProductName.TabIndex = 3
        '
        'ProductsBindingSource
        '
        Me.ProductsBindingSource.DataMember = "Products"
        Me.ProductsBindingSource.DataSource = Me.ProductsListBox_DataSet
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitPrice", True))
        Me.txtUnitPrice.Location = New System.Drawing.Point(166, 234)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(72, 22)
        Me.txtUnitPrice.TabIndex = 11
        '
        'txtUnitStock
        '
        Me.txtUnitStock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsInStock", True))
        Me.txtUnitStock.Location = New System.Drawing.Point(166, 279)
        Me.txtUnitStock.Name = "txtUnitStock"
        Me.txtUnitStock.Size = New System.Drawing.Size(72, 22)
        Me.txtUnitStock.TabIndex = 13
        '
        'txtUnitOrder
        '
        Me.txtUnitOrder.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "UnitsOnOrder", True))
        Me.txtUnitOrder.Location = New System.Drawing.Point(166, 324)
        Me.txtUnitOrder.Name = "txtUnitOrder"
        Me.txtUnitOrder.Size = New System.Drawing.Size(72, 22)
        Me.txtUnitOrder.TabIndex = 15
        '
        'txtReorderLevel
        '
        Me.txtReorderLevel.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "ReorderLevel", True))
        Me.txtReorderLevel.Location = New System.Drawing.Point(166, 369)
        Me.txtReorderLevel.Name = "txtReorderLevel"
        Me.txtReorderLevel.Size = New System.Drawing.Size(72, 22)
        Me.txtReorderLevel.TabIndex = 17
        '
        'txtQtyUnit
        '
        Me.txtQtyUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "QuantityPerUnit", True))
        Me.txtQtyUnit.Location = New System.Drawing.Point(166, 189)
        Me.txtQtyUnit.Name = "txtQtyUnit"
        Me.txtQtyUnit.Size = New System.Drawing.Size(168, 22)
        Me.txtQtyUnit.TabIndex = 9
        '
        'txtCategory
        '
        Me.txtCategory.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "CategoryID", True))
        Me.txtCategory.Location = New System.Drawing.Point(166, 144)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.Size = New System.Drawing.Size(72, 22)
        Me.txtCategory.TabIndex = 7
        '
        'txtSupplier
        '
        Me.txtSupplier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductsBindingSource, "SupplierID", True))
        Me.txtSupplier.Location = New System.Drawing.Point(166, 99)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(72, 22)
        Me.txtSupplier.TabIndex = 5
        '
        'ProductsTableAdapter
        '
        Me.ProductsTableAdapter.ClearBeforeFill = True
        '
        'ProductsBindingSource1
        '
        Me.ProductsBindingSource1.DataMember = "Products"
        Me.ProductsBindingSource1.DataSource = Me.ProductsListBox_DataSet
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(391, 426)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 30)
        Me.btnSearch.TabIndex = 18
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(310, 426)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 30)
        Me.btnUpdate.TabIndex = 19
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(148, 426)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 21
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(229, 426)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 30)
        Me.btnInsert.TabIndex = 20
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnProductName
        '
        Me.btnProductName.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnProductName.Location = New System.Drawing.Point(115, 49)
        Me.btnProductName.Name = "btnProductName"
        Me.btnProductName.Size = New System.Drawing.Size(45, 33)
        Me.btnProductName.TabIndex = 22
        Me.btnProductName.UseVisualStyleBackColor = True
        '
        'btnCategoryId
        '
        Me.btnCategoryId.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnCategoryId.Location = New System.Drawing.Point(115, 139)
        Me.btnCategoryId.Name = "btnCategoryId"
        Me.btnCategoryId.Size = New System.Drawing.Size(45, 33)
        Me.btnCategoryId.TabIndex = 23
        Me.btnCategoryId.UseVisualStyleBackColor = True
        '
        'btnQtyUnit
        '
        Me.btnQtyUnit.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnQtyUnit.Location = New System.Drawing.Point(115, 184)
        Me.btnQtyUnit.Name = "btnQtyUnit"
        Me.btnQtyUnit.Size = New System.Drawing.Size(45, 33)
        Me.btnQtyUnit.TabIndex = 24
        Me.btnQtyUnit.UseVisualStyleBackColor = True
        '
        'btnUnitPrice
        '
        Me.btnUnitPrice.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnUnitPrice.Location = New System.Drawing.Point(115, 229)
        Me.btnUnitPrice.Name = "btnUnitPrice"
        Me.btnUnitPrice.Size = New System.Drawing.Size(45, 33)
        Me.btnUnitPrice.TabIndex = 25
        Me.btnUnitPrice.UseVisualStyleBackColor = True
        '
        'btnUnitStock
        '
        Me.btnUnitStock.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnUnitStock.Location = New System.Drawing.Point(115, 274)
        Me.btnUnitStock.Name = "btnUnitStock"
        Me.btnUnitStock.Size = New System.Drawing.Size(45, 33)
        Me.btnUnitStock.TabIndex = 26
        Me.btnUnitStock.UseVisualStyleBackColor = True
        '
        'btnUnitsOrder
        '
        Me.btnUnitsOrder.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnUnitsOrder.Location = New System.Drawing.Point(115, 319)
        Me.btnUnitsOrder.Name = "btnUnitsOrder"
        Me.btnUnitsOrder.Size = New System.Drawing.Size(45, 33)
        Me.btnUnitsOrder.TabIndex = 27
        Me.btnUnitsOrder.UseVisualStyleBackColor = True
        '
        'btnReorderLevel
        '
        Me.btnReorderLevel.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnReorderLevel.Location = New System.Drawing.Point(115, 364)
        Me.btnReorderLevel.Name = "btnReorderLevel"
        Me.btnReorderLevel.Size = New System.Drawing.Size(45, 33)
        Me.btnReorderLevel.TabIndex = 28
        Me.btnReorderLevel.UseVisualStyleBackColor = True
        '
        'btnSupplier
        '
        Me.btnSupplier.Image = Global.ProductsListBoxNavigation.My.Resources.Resources.speaker_filled
        Me.btnSupplier.Location = New System.Drawing.Point(115, 94)
        Me.btnSupplier.Name = "btnSupplier"
        Me.btnSupplier.Size = New System.Drawing.Size(45, 33)
        Me.btnSupplier.TabIndex = 29
        Me.btnSupplier.UseVisualStyleBackColor = True
        '
        'ProductsListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 468)
        Me.Controls.Add(Me.btnSupplier)
        Me.Controls.Add(Me.btnReorderLevel)
        Me.Controls.Add(Me.btnUnitsOrder)
        Me.Controls.Add(Me.btnUnitStock)
        Me.Controls.Add(Me.btnUnitPrice)
        Me.Controls.Add(Me.btnQtyUnit)
        Me.Controls.Add(Me.btnCategoryId)
        Me.Controls.Add(Me.btnProductName)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.txtQtyUnit)
        Me.Controls.Add(Me.txtReorderLevel)
        Me.Controls.Add(Me.txtUnitOrder)
        Me.Controls.Add(Me.txtUnitStock)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProductListBox)
        Me.Name = "ProductsListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ProductsListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsListBox_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ProductsListBox_DataSet As ProductsListBox_DataSet
    Friend WithEvents ProductsListBindingSource As BindingSource
    Friend WithEvents ProductsListTableAdapter As ProductsListBox_DataSetTableAdapters.ProductsListTableAdapter
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents txtUnitStock As TextBox
    Friend WithEvents txtUnitOrder As TextBox
    Friend WithEvents txtReorderLevel As TextBox
    Friend WithEvents txtQtyUnit As TextBox
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents ProductsBindingSource As BindingSource
    Friend WithEvents ProductsTableAdapter As ProductsListBox_DataSetTableAdapters.ProductsTableAdapter
    Friend WithEvents ProductsBindingSource1 As BindingSource
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnProductName As Button
    Friend WithEvents btnCategoryId As Button
    Friend WithEvents btnQtyUnit As Button
    Friend WithEvents btnUnitPrice As Button
    Friend WithEvents btnUnitStock As Button
    Friend WithEvents btnUnitsOrder As Button
    Friend WithEvents btnReorderLevel As Button
    Friend WithEvents btnSupplier As Button
End Class
