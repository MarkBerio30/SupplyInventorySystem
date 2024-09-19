Public Class BorrowSearch

    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet

    Private Sub ButtonBackBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackBS.Click
        Me.Close()
        Borrow.Show()
    End Sub

    Private Sub BorrowSearch_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        borrower()
        itemborrowed()
    End Sub

    Public Sub borrower()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox1.ResetText()
            Me.ComboBox1.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT Borrower FROM BorrowTable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            If DATASET.Tables("BorrowTable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("BorrowTable").Rows.Count - 1
                    Me.ComboBox1.Items.Add(DATASET.Tables("BorrowTable").Rows(i).Item("Borrower").ToString())
                Next
            End If
            Me.ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub itemborrowed()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox2.ResetText()
            Me.ComboBox2.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT [Item Borrowed] FROM BorrowTable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            If DATASET.Tables("BorrowTable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("BorrowTable").Rows.Count - 1
                    Me.ComboBox2.Items.Add(DATASET.Tables("BorrowTable").Rows(i).Item("Item Borrowed").ToString())
                Next
            End If
            Me.ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSearchBS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchBS.Click
        Try
            Dim Icmd As String = "SELECT * FROM BorrowTable WHERE [Record No] <> '0'"
            DATASET.Tables.Clear()
            If Me.ComboBox1.Text <> "" Then
                Icmd = Icmd & "AND Borrower = '" & Me.ComboBox1.Text & "'"
            End If
            If Me.ComboBox2.Text <> "" Then
                Icmd = Icmd & "AND [Item Borrowed] = '" & Me.ComboBox2.Text & "'"
            End If

            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            If DATASET.Tables("BorrowTable").Rows.Count > 0 Then
                BorrowNew.TextBox1.Text = DATASET.Tables("BorrowTable").Rows(0).Item("Borrower").ToString
                BorrowNew.TextBox2.Text = DATASET.Tables("BorrowTable").Rows(0).Item("Cellphone No").ToString
                BorrowNew.ComboBox1.Text = DATASET.Tables("BorrowTable").Rows(0).Item("Item Borrowed").ToString
                BorrowNew.NumericUpDown1.Text = DATASET.Tables("BorrowTable").Rows(0).Item("Quantity").ToString
                BorrowNew.TextBox5.Text = DATASET.Tables("BorrowTable").Rows(0).Item("Person in Charge").ToString
                BorrowNew.TextBox6.Text = DATASET.Tables("BorrowTable").Rows(0).Item("Date Borrowed").ToString
                BorrowNew.ComboBox2.Text = DATASET.Tables("BorrowTable").Rows(0).Item("School Year").ToString
                MsgBox("RECORD FOUND")
                Borrow.DataGridView1.DataSource = DATASET.Tables("BorrowTable")
            Else
                MsgBox("RECORD NOT FOUND")
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
