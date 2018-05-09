Public Class frmCategories
    Private Sub CategoriesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoriesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub

    Private Sub frmCategories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_NwindTables_1_DataSet.Categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Fill(Me._NwindTables_1_DataSet.Categories)

    End Sub
End Class