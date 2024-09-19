Public Class Itemstobereturn
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub Itemstobereturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddata()
    End Sub
    Public Sub loaddata()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from BorrowTable where Status = 'Borrow'"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("BorrowTable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonBackRN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackRN.Click
        Mainform.Show()
        Me.Close()

    End Sub

End Class