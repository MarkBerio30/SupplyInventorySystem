Public Class Release
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Dim q1 As String
    Dim q2 As String
    Dim sum As String
    Dim i As String
    Public Sub search1()
        Try
            Dim Icmd As String = "SELECT * FROM ReleaseTable WHERE [Record No] = '" & ReleaseEdit.Label10.Text & "'"
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "ReleaseTable")
            CONN.Close()
            If DATASET.Tables("ReleaseTable").Rows.Count > 0 Then
                q1 = DATASET.Tables("ReleaseTable").Rows(0).Item("Quantity").ToString
                search2()
            Else

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub search2()
        Try
            Dim Icmd As String = "SELECT Quantity FROM suppliesinventorytable WHERE [Item Name] = '" & ReleaseEdit.ComboBox1.Text & "'"
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
            CMD.CommandText = "UPDATE suppliesinventorytable SET Quantity = @Quantity WHERE [item name] = '" & ReleaseEdit.ComboBox1.Text & "'"
            CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)

            '
            CMD.Parameters("@Quantity").Value = sum

            ADAPTER.UpdateCommand = CMD
            ADAPTER.UpdateCommand.ExecuteNonQuery()
            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub s()
        DATASET.Tables.Clear()
        CONN.Open()
        CMD = CONN.CreateCommand
        CMD.CommandText = "UPDATE suppliesinventorytable SET Status = @Status where [Item Name] = '" & ReleaseEdit.ComboBox1.Text & "'"
        CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)

        CMD.Parameters("@Status").Value = "Stocked"
        ADAPTER.UpdateCommand = CMD
        ADAPTER.UpdateCommand.ExecuteNonQuery()
        CONN.Close()

    End Sub

    Public Sub loaddataD()
        Try

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from ReleaseTable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "ReleaseTable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("ReleaseTable")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Release_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddataD()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ReleaseSearch.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Mainform.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Label11.Text = TimeOfDay
        Label12.Text = DateString
    End Sub

    Private Sub ButtonNewR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewR.Click
        ReleaseNew.Show()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            ReleaseEdit.Label10.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            ReleaseEdit.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            ReleaseEdit.ComboBox3.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            ReleaseEdit.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            ReleaseEdit.ComboBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            ReleaseEdit.NumericUpDown1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            ReleaseEdit.TextBox5.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            ReleaseEdit.TextBox6.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString
            ReleaseEdit.ComboBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonBackR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackR.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub ButtonSearchR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchR.Click
        ReleaseSearch.Show()
    End Sub

    Private Sub ButtonEditR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditR.Click
        ReleaseEdit.Show()
    End Sub


    Public Sub delete()
        Try
            If MessageBox.Show("DO YOU WANT TO DELETE THIS RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = "Delete from ReleaseTable  Where [Record No] = '" & ReleaseEdit.Label10.Text & "'"
                ADAPTER.DeleteCommand = CMD
                ADAPTER.DeleteCommand.ExecuteNonQuery()
                CONN.Close()
                MsgBox("RECORD DELETED!")
                Me.DataGridView1.DataSource = DATASET.Tables("ReleasedTable")
                s()
                loaddataD()
                Inventoryy.DataGridView1.DataSource = DATASET.Tables("Suppliesinventorytable")

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ButtonDeleteD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteD.Click
        search1()
        sum = Val(q1) + Val(q2)
        updates()
        delete()
    End Sub

    Private Sub ButtonRefreshR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefreshR.Click
        loaddataD()
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label10.Text = TimeOfDay
        Label11.Text = Date.Now.ToString("MMM/dd/yyyy")

    End Sub
End Class