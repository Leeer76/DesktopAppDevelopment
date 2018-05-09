Public Class frmOrdersDetails

    'public variables
    Public intOrderID As Integer

    Private Sub Order_DetailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Order_DetailsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order_DetailsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._NwindTables_1_DataSet)

    End Sub
    Private Sub frmOrdersDetails_Load(sender As Object, e As EventArgs) Handles Me.Load
        'use integer passed from first form to fill this data

        Try
            Me.Order_DetailsTableAdapter.Fill(Me._NwindTables_1_DataSet.Order_Details, intOrderID)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class