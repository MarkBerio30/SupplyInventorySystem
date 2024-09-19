Public Class Restockinventory
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Inventoryy.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim stat As String = ""
            If Me.NumericUpDown1.Text = 0 Then
                stat = "Out of Stock"
            ElseIf Me.NumericUpDown1.Text > 0 Then
                stat = "Stocked"
            End If

            If String.IsNullOrEmpty(Me.TextBox1.Text) = True Then
                MsgBox("Empty Item_Name is Not Valid")
                Me.TextBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                MsgBox("Empty Item_Code is Not Valid!")
                Me.TextBox2.Focus()
            ElseIf String.IsNullOrEmpty(Me.NumericUpDown1.Text) = True Then
                MsgBox("Empty Quantity is Not Valid!")
                Me.NumericUpDown1.Focus()


            Else
                If MessageBox.Show("DO YOU WANT TO RESTOCK THIS RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    DATASET.Tables.Clear()
                    CONN.Open()
                    CMD = CONN.CreateCommand
                    CMD.CommandText = "UPDATE suppliesinventorytable SET [Item Name] = @Item_Name, Quantity = @Quantity, Status = @Status WHERE [Item Code] = '" & Me.TextBox2.Text & "'"

                    CMD.Parameters.Add("@Item_Name", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)



                    CMD.Parameters("@Item_Name").Value = Me.TextBox1.Text
                    CMD.Parameters("@Quantity").Value = Me.NumericUpDown1.Text
                    CMD.Parameters("@Status").Value = stat
                    ADAPTER.UpdateCommand = CMD
                    ADAPTER.UpdateCommand.ExecuteNonQuery()
                    CONN.Close()
                    MsgBox("RESTOCKED")
                    Inventoryy.loaddata()
                    Me.Close()
                    Inventoryy.Show()

                Else
                    MsgBox("NOT RESTOCKED")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class

