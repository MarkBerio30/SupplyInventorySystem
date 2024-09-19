Public Class ReleaseSearch
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Release.Show()
        Me.Hide()

    End Sub

    Private Sub ReleaseSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        NameCombo()
        ItemReleased()

    End Sub

    Private Sub ButtonSearchRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchRS.Click
        Try
            Dim Icmd As String = "SELECT * FROM ReleaseTable WHERE [Record No] <> '0'"
            DATASET.Tables.Clear()
            If Me.ComboBox1.Text <> "" Then
                Icmd = Icmd & "AND Name = '" & Me.ComboBox1.Text & "'"
            End If
            If Me.ComboBox2.Text <> "" Then
                Icmd = Icmd & "AND [Item Released] = '" & Me.ComboBox2.Text & "'"
            End If

            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "ReleaseTable")
            CONN.Close()
            If DATASET.Tables("ReleaseTable").Rows.Count > 0 Then
                ReleaseNew.TextBox1.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("Name").ToString
                ReleaseNew.TextBox2.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("Cellphone No").ToString
                ReleaseNew.ComboBox1.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("Item Released").ToString
                ReleaseNew.NumericUpDown1.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("Quantity").ToString
                ReleaseNew.TextBox5.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("Date Released").ToString
                ReleaseNew.TextBox6.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("Person in Charge").ToString
                ReleaseNew.ComboBox2.Text = DATASET.Tables("ReleaseTable").Rows(0).Item("School Year").ToString

                MsgBox("RECORD FOUND")
                Release.DataGridView1.DataSource = DATASET.Tables("ReleaseTable")
            Else
                MsgBox("RECORD NOT FOUND")
            End If
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub NameCombo()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox1.ResetText()
            Me.ComboBox1.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT Name FROM ReleaseTable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "ReleaseTable")
            CONN.Close()
            If DATASET.Tables("ReleaseTable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("ReleaseTable").Rows.Count - 1
                    Me.ComboBox1.Items.Add(DATASET.Tables("ReleaseTable").Rows(i).Item("Name").ToString())
                Next
            End If
            Me.ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ItemReleased()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox2.ResetText()
            Me.ComboBox2.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT [Item Released] FROM ReleaseTable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "ReleaseTable")
            CONN.Close()
            If DATASET.Tables("ReleaseTable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("ReleaseTable").Rows.Count - 1
                    Me.ComboBox2.Items.Add(DATASET.Tables("ReleaseTable").Rows(i).Item("Item Released").ToString())
                Next
            End If
            Me.ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonBackRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackRS.Click
        Release.Show()
        Me.Hide()

    End Sub
End Class


  