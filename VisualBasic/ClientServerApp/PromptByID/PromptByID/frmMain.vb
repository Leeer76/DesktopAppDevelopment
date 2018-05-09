Public Class frmMain
    Private Sub CIS272BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CIS272BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CIS272BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.CIS272DataSet)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.CIS272TableAdapter.Fill(Me.CIS272DataSet.CIS272, New System.Nullable(Of Integer)(CType(IDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub IDToolStripTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles IDToolStripTextBox.KeyDown
        'if enter was pressed call the fill click event
        If e.KeyCode = Keys.Enter Then
            IDToolStripTextBox.Text = IDToolStripTextBox.Text.Replace(";", "").Replace("?", "")
            FillToolStripButton.PerformClick()
        End If
    End Sub
End Class
