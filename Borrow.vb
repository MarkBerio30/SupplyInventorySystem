Public Class Borrow 
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Dim q1 As String
    Dim q2 As String
    Dim sum As String

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

    Public Sub search1()
        Try
            Dim Icmd As String = "SELECT * FROM BorrowTable WHERE [Record No] = '" & BorrowEdit.Label10.Text & "'"
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            If DATASET.Tables("BorrowTable").Rows.Count > 0 Then
                q1 = DATASET.Tables("BorrowTable").Rows(0).Item("Quantity").ToString
                search2()
            Else

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub search2()
        Try
            Dim Icmd As String = "SELECT Quantity FROM suppliesinventorytable WHERE [item name] = '" & BorrowEdit.TextBox3.Text & "'"
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                q2 = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Quantity").ToString
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub DataGridView2_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.RowEnter
        Try
            Me.TextBox3.Text = Me.DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub loaddataB()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from BorrowTable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("BorrowTable")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Borrow_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loaddataB()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay
        Label3.Text = Date.Now.ToString("MMM/dd/yyyy")
    End Sub

    Private Sub ButtonBackB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackB.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub ButtonNewB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewB.Click
        BorrowNew.Show()
    End Sub

    Private Sub ButtonEditB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditB.Click
        BorrowEdit.Show()
    End Sub

    Private Sub ButtonSearchB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchB.Click
        BorrowSearch.Show()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            BorrowEdit.Label10.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            BorrowEdit.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            BorrowEdit.ComboBox3.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            BorrowEdit.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            BorrowEdit.TextBox3.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            BorrowEdit.NumericUpDown1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            BorrowEdit.TextBox5.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            BorrowEdit.TextBox6.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            BorrowEdit.DateTimePicker1.Value = Me.DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString
            BorrowEdit.ComboBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString
            Me.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            Me.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
        Catch ex As Exception

        End Try
    End Sub
    Public Sub delete()
        Try
            If MessageBox.Show("DO YOU WANT TO DELETE THIS RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = "Delete from BorrowTable  Where [Record No] = '" & BorrowEdit.Label10.Text & "'"
                ADAPTER.DeleteCommand = CMD
                ADAPTER.DeleteCommand.ExecuteNonQuery()
                CONN.Close()
                MsgBox("RECORD DELETED!")

                Me.DataGridView1.DataSource = DATASET.Tables("BorrowTable")
                s()
                loaddataB()
                Inventoryy.DataGridView1.DataSource = DATASET.Tables("Suppliesinventorytable")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDeleteB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteB.Click
        search1()
        sum = Val(q1) + Val(q2)
        updates()
        delete()
    End Sub

    Private Sub ButtonRefreshB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefreshB.Click
        loaddataB()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BorrowEdit.Show()
    End Sub

  
End Class