Public Class Suppliers
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    

    Public Sub search()
        Try
            Dim Icmd As String = "SELECT * FROM Supplierstable where Name = '" & Label13.Text & "'"
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "Supplierstable")
            CONN.Close()
            If DATASET.Tables("Supplierstable").Rows.Count > 0 Then
                Label7.Text = DATASET.Tables("Supplierstable").Rows(0).Item("Rec No").ToString
                Label8.Text = DATASET.Tables("Supplierstable").Rows(0).Item("Name").ToString
                Label9.Text = DATASET.Tables("Supplierstable").Rows(0).Item("Company").ToString
                Label10.Text = DATASET.Tables("Supplierstable").Rows(0).Item("Cellphone No").ToString
                Label11.Text = DATASET.Tables("Supplierstable").Rows(0).Item("Email Address").ToString
                Label12.Text = DATASET.Tables("Supplierstable").Rows(0).Item("Address").ToString
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ButtonBackB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackB.Click
        outofstock.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
    End Sub

    Private Sub Suppliers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        search()

    End Sub
End Class