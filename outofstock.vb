Public Class outofstock
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet

    Private Sub XtraForm6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from suppliesinventorytable where status = 'Out of Stock'"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonBackRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackRN.Click
        Mainform.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Suppliers.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            Suppliers.Label13.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString
        Catch ex As Exception

        End Try
    End Sub

End Class