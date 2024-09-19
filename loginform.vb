Public Class loginform 

    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet

    Public Sub cleartext()
        Try
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
  
    Private Sub ButtonExitLF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonExitLF.Click
        Me.Close()
    End Sub

    Private Sub ButtonLoginLF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLoginLF.Click
        Try
            Dim Icmd As String = "SELECT * FROM UserAccountTable WHERE [Record No] <> '0'"
            DataSet.Tables.Clear()
            If String.IsNullOrEmpty(Me.TextBox1.Text) = True Then
                MsgBox("Please Enter User Name")
                Me.TextBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                MsgBox("Please Enter Password")
                Me.TextBox2.Focus()
            Else
                If Me.TextBox1.Text <> "" Then
                    Icmd = Icmd & "AND [User Name] = '" & Me.TextBox1.Text & "'"
                End If
                If Me.TextBox2.Text <> "" Then
                    Icmd = Icmd & "AND Password = '" & Me.TextBox2.Text & "'"
                End If

                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = Icmd
                ADAPTER.SelectCommand = CMD
                ADAPTER.SelectCommand.ExecuteNonQuery()
                ADAPTER.Fill(DATASET, "UserAccountTable")
                CONN.Close()
                If DATASET.Tables("UserAccountTable").Rows.Count > 0 Then
                    UserAccount.TextBox1.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("User Name").ToString
                    UserAccount.TextBox2.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Password").ToString
                    UserAccount.TextBox3.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    UserAccount.TextBox4.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Email Address").ToString
                    UserAccount.TextBox5.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Cellphone No").ToString
                    UserAccount.TextBox6.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Address").ToString
                    Mainform.Label6.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    Borrow.Label1.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    Release.Label12.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    ReleaseNew.TextBox6.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    RETURNING.Label2.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    Inventoryy.Label1.Text = DATASET.Tables("UserAccountTable").Rows(0).Item("Name").ToString
                    MsgBox("Welcome To Supply Inventory System!")
                    UserAccount.DataGridView1.DataSource = DATASET.Tables("UserAccountTable")
                    Me.Hide()
                    Mainform.Show()
                    cleartext()
                Else
                    MsgBox("Incorrect User Name or Password")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class