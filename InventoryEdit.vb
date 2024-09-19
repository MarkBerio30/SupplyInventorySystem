Public Class InventoryEdit
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub ButtonBackIE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackIE.Click
        Me.Close()
        Inventoryy.Show()
    End Sub

    Private Sub ButtonUpdateIE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateIE.Click
        Try
            Dim stat As String = ""
            If Me.NumericUpDown1.Text = 0 Then
                stat = "Out of Stock"
            ElseIf Me.NumericUpDown1.Text > 0 Then
                stat = "Stocked"
            End If

            If String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                MsgBox("Empty Item_Name is Not Valid!")
                Me.TextBox2.Focus()
            ElseIf String.IsNullOrEmpty(Me.NumericUpDown1.Text) = True Then
                MsgBox("Empty Quantity is Not Valid!")
                Me.NumericUpDown1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox3.Text) = True Then
                MsgBox("Empty Price is Not Valid!")
                Me.TextBox3.Focus()
            ElseIf String.IsNullOrEmpty(Me.ComboBox1.Text) = True Then
                MsgBox("Empty Item_Type is Not Valid!")
                ComboBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox6.Text) = True Then
                MsgBox("Empty Supplier is Not Valid!")
                TextBox6.Focus()

            Else
                If MessageBox.Show("DO YOU WANT TO UPDATE RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    DATASET.Tables.Clear()
                    CONN.Open()
                    CMD = CONN.CreateCommand
                    CMD.CommandText = "UPDATE suppliesinventorytable SET [Item Name] = @Item_Name, Quantity = @Quantity, Price = @Price, Status = @Status, [Item Type] = @Item_Type, Supplier = @Supplier WHERE [Item Code] = '" & Me.TextBox1.Text & "'"

                    CMD.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Price", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Item_Type", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Supplier", SqlDbType.NVarChar, 50)

                    CMD.Parameters("@Item_Name").Value = Me.TextBox2.Text
                    CMD.Parameters("@Quantity").Value = Me.NumericUpDown1.Text
                    CMD.Parameters("@Price").Value = Me.TextBox3.Text
                    CMD.Parameters("@Status").Value = stat
                    CMD.Parameters("@Item_Type").Value = Me.ComboBox1.Text
                    CMD.Parameters("@Supplier").Value = Me.TextBox6.Text
                    ADAPTER.UpdateCommand = CMD
                    ADAPTER.UpdateCommand.ExecuteNonQuery()
                    CONN.Close()
                    MsgBox("RECORD UPDATE")

                    Inventoryy.loaddata()
                    Me.Hide()
                    Mainform.loaddata()


                Else
                    MsgBox("RECORD NOT UPDATED")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class