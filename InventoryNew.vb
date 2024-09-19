Public Class InventoryNew
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub ButtonBackIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackIN.Click
        Me.Close()
        Inventoryy.Show()
    End Sub

   

    Private Sub ButtonSaveIN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveIN.Click
        Try
            Dim stat As String = ""
            If Me.NumericUpDown1.Text = 0 Then
                stat = "Out of Stock"
            ElseIf Me.NumericUpDown1.Text > 0 Then
                stat = "Stocked"
            End If

            If  String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                MsgBox("Empty Item Name is Not Valid!")
                Me.TextBox2.Focus()
            ElseIf String.IsNullOrEmpty(Me.NumericUpDown1.Text) = True Then
                MsgBox("Empty Quantity is Not Valid!")
                Me.NumericUpDown1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox3.Text) = True Then
                MsgBox("Empty Price is Not Valid!")
                Me.TextBox3.Focus()
            ElseIf String.IsNullOrEmpty(Me.ComboBox1.Text) = True Then
                MsgBox("Empty Item Type is Not Valid!")
                Me.ComboBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox6.Text) = True Then
                MsgBox("Empty Supplier is Not Valid!")
                Me.TextBox6.Focus()
            Else
                If MessageBox.Show("DO YOU WANT TO SAVE RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    DATASET.Tables.Clear()
                    CONN.Open()
                    CMD = CONN.CreateCommand
                    CMD.CommandText = "Insert Into suppliesinventorytable values(@Item_Name, @Quantity, @Price, @Status, @Item_Type, @Supplier)"
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

                    ADAPTER.InsertCommand = CMD
                    ADAPTER.InsertCommand.ExecuteNonQuery()
                    CONN.Close()
                    MsgBox("RECORD SAVE")
                    Inventoryy.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")
                    Inventoryy.loaddata()
                    Me.Close()





                Else

                    MsgBox("RECORD NOT SAVE")

                End If

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub InventoryNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


End Class