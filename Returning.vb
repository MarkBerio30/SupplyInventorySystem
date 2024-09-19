Public Class RETURNING 
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet

    Public Sub LoaddataC()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from BorrowTable where status='Borrow' order by status"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("BorrowTable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
  
    Private Sub RETURNING_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoaddataC()
    End Sub

    Private Sub ButtonBackRt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackRt.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Public Sub updates()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "UPDATE suppliesinventorytable SET Quantity = @Quantity where [Item Name] = '" & Me.TextBox1.Text & "'"

            CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)

            CMD.Parameters("@Quantity").Value = Val(Me.TextBox3.Text) + Val(Me.TextBox2.Text)
            ADAPTER.UpdateCommand = CMD
            ADAPTER.UpdateCommand.ExecuteNonQuery()
            CONN.Close()
            Inventoryy.loaddata()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ButtonReturnRt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReturnRt.Click
        Try
            If MessageBox.Show("RETURN ITEM?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = "UPDATE BorrowTable SET [Date Returned] = @Date_Returned, Status = @Status where [Record No] = '" & Me.Label12.Text & "'"
                CMD.Parameters.Add("@Date_Returned", SqlDbType.NVarChar, 50)
                CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)

                CMD.Parameters("@Date_Returned").Value = DateString
                CMD.Parameters("@Status").Value = "Returned"
                ADAPTER.UpdateCommand = CMD
                ADAPTER.UpdateCommand.ExecuteNonQuery()
                CONN.Close()
                s()
                updates()
                Borrow.loaddataB()
                LoaddataC()


            Else
                MsgBox("NOT RETURNED")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub s()
        DATASET.Tables.Clear()
        CONN.Open()
        CMD = CONN.CreateCommand
        CMD.CommandText = "UPDATE suppliesinventorytable SET Status = @Status where [Item Name] = '" & Me.TextBox1.Text & "'"
        CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)

        CMD.Parameters("@Status").Value = "Stocked"
        ADAPTER.UpdateCommand = CMD
        ADAPTER.UpdateCommand.ExecuteNonQuery()
        CONN.Close()
       
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            Dim Icmd As String = "SELECT * FROM suppliesinventorytable WHERE [Item Code] <> '0'"
            DATASET.Tables.Clear()
            If Me.TextBox1.Text <> "" Then
                Icmd = Icmd & "AND [Item Name] = '" & Me.TextBox1.Text & "'"
            End If

            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Code").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Name").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Quantity").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Status").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Type").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Supplier").ToString
                Me.DataGridView2.DataSource = DATASET.Tables("suppliesinventorytable")


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            Me.Label12.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            Me.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label11.Text = Date.Now.ToString("MMM/dd/yyyy")
        Label10.Text = TimeOfDay
    End Sub

    Private Sub DataGridView2_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowEnter
        Try

            Me.TextBox3.Text = Me.DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSearchRt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchRt.Click
        RETURNSEARCH.Show()


    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class