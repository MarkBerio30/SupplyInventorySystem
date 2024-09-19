Public Class ReleaseItem
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
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
    Private Sub ReleaseItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddataD()

    End Sub

    Private Sub ButtonBackBN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackBN.Click
        Mainform.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class