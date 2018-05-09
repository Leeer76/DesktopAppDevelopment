Public Class ProductDetails
    'public varibales
    Public intProductID As Integer
    Private Sub ProductDetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ProductDetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductDetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub
    Private Sub ProductDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.ProductDetailsTableAdapter.Fill(Me._NwindTables_1_DataSet.ProductDetails, intProductID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class