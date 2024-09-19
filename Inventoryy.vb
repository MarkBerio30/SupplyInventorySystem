Public Class Inventoryy

    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Public Sub loaddata()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from suppliesinventorytable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")
            alarms()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub alarms()
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            Dim val As String

            val = DataGridView1.Rows(i).Cells(4).Value

            If val = "Out of Stock" Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Orange

            Else

            End If
        Next
    End Sub
    Private Sub Inventoryy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub

    Private Sub ButtonSearchI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchI.Click
        InventorySearch.Show()
    End Sub

    Private Sub ButtonNewI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewI.Click
        InventoryNew.Show()
    End Sub

    Private Sub ButtonEditI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditI.Click
        InventoryEdit.Show()
    End Sub

    Private Sub ButtonBackI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackI.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            InventoryEdit.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            InventoryEdit.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            InventoryEdit.NumericUpDown1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            InventoryEdit.TextBox3.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            InventoryEdit.ComboBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
            InventoryEdit.TextBox6.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
            Restockinventory.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            Restockinventory.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Restockinventory.NumericUpDown1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ButtonDeleteI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteI.Click
        Try
            If MessageBox.Show("DO YOU WANT TO DELETE THIS RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = "Delete from suppliesinventorytable  Where [Item Code] = '" & InventoryEdit.TextBox1.Text & "'"
                ADAPTER.DeleteCommand = CMD
                ADAPTER.DeleteCommand.ExecuteNonQuery()
                CONN.Close()
                MsgBox("RECORD DELETED!")
                Me.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")
                loaddata()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonRefreshI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRefreshI.Click
        loaddata()

    End Sub

    Private Sub ButtonRestockI_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRestockI.Click
        Restockinventory.Show()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label5.Text = TimeOfDay
        Label3.Text = Date.Now.ToString("MMM/dd/yyyy")

    End Sub


End Class

