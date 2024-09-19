Public Class BorrowedItems
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub BorrowRelease_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddataB()
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

        End Try
    End Sub
    Private Sub ButtonBackBN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackBN.Click
        Mainform.Show()
        Me.Close()

    End Sub
End Class