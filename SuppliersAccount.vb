Public Class SuppliersAccount
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Private Sub SuppliersAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loaddatak()
    End Sub
    Public Sub loaddatak()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select [Rec No], Name, Company, [Cellphone No], [Email Address], Address from Supplierstable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "Supplierstable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("Supplierstable")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub buttondefault()
        Me.ButtonNewUA.Enabled = True
        Me.ButtonNewUA.Text = "NEW ACCOUNT"
        Me.ButtonEditUA.Enabled = True
        Me.ButtonEditUA.Text = "EDIT"
        Me.ButtonDeleteUA.Enabled = True
        Me.ButtonCancelUA.Enabled = True
        Me.ButtonBackUA.Enabled = True
    End Sub

    Public Sub buttonadd()
        Me.ButtonNewUA.Enabled = True
        Me.ButtonEditUA.Enabled = False
        Me.ButtonDeleteUA.Enabled = False
        Me.ButtonCancelUA.Enabled = True
        Me.ButtonBackUA.Enabled = False
    End Sub

    Public Sub buttonedit()
        Me.ButtonNewUA.Enabled = False
        Me.ButtonEditUA.Enabled = True
        Me.ButtonDeleteUA.Enabled = False
        Me.ButtonCancelUA.Enabled = True
        Me.ButtonBackUA.Enabled = False
    End Sub

    Public Sub cleartext()
        Try
            Me.TextBox1.Text = ""
            Me.TextBox2.Text = ""
            Me.TextBox3.Text = ""
            Me.TextBox4.Text = ""
            Me.TextBox5.Text = ""

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            Me.Label7.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
            Me.TextBox1.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.TextBox2.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
            Me.TextBox3.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
            Me.TextBox4.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
            Me.TextBox5.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ButtonNewUA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNewUA.Click
        Try
            If Me.ButtonNewUA.Text = "NEW ACCOUNT" Then
                cleartext()
                buttonadd()
                Me.TextBox1.Focus()
                Me.ButtonNewUA.Text = "SAVE"
            ElseIf Me.ButtonNewUA.Text = "SAVE" Then

                If String.IsNullOrEmpty(Me.TextBox1.Text) = True Then
                    MsgBox("Empty Name is Not Valid")
                    Me.TextBox1.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                    MsgBox("Empty Company is Not Valid!")
                    Me.TextBox2.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox3.Text) = True Then
                    MsgBox("Empty Cellphone No is Not Valid!")
                    Me.TextBox3.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox4.Text) = True Then
                    MsgBox("Empty Email Address is Not Valid!")
                    Me.TextBox4.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox5.Text) = True Then
                    MsgBox("Empty Address is Not Valid!")

                Else
                    If MessageBox.Show("DO YOU WANT TO SAVE RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DATASET.Tables.Clear()
                        CONN.Open()
                        CMD = CONN.CreateCommand
                        CMD.CommandText = "Insert Into Supplierstable values(@Name, @Company, @Cellphone_No, @Email_Address, @Address)"
                        CMD.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Company", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Cellphone_No", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Email_Address", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Address", SqlDbType.NVarChar, 50)

                        CMD.Parameters("@Name").Value = Me.TextBox1.Text
                        CMD.Parameters("@Company").Value = Me.TextBox2.Text
                        CMD.Parameters("@Cellphone_No").Value = Me.TextBox3.Text
                        CMD.Parameters("@Email_Address").Value = Me.TextBox4.Text
                        CMD.Parameters("@Address").Value = Me.TextBox5.Text

                        ADAPTER.InsertCommand = CMD
                        ADAPTER.InsertCommand.ExecuteNonQuery()
                        CONN.Close()
                        MsgBox("RECORD SAVE")
                        Me.DataGridView1.DataSource = DATASET.Tables("Supplierstable")
                        loaddatak()
                        buttondefault()
                        cleartext()

                    Else
                        MsgBox("RECORD NOT SAVE")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonEditUA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEditUA.Click
        Try
            If Me.ButtonEditUA.Text = "EDIT" Then
                buttonedit()
                Me.TextBox1.Focus()
                Me.ButtonEditUA.Text = "UPDATE"
            ElseIf Me.ButtonEditUA.Text = "UPDATE" Then

                If String.IsNullOrEmpty(Me.TextBox1.Text) = True Then
                    MsgBox("Empty User Code is Not Valid")
                    Me.TextBox1.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                    MsgBox("Empty Name No is Not Valid!")
                    Me.TextBox2.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox3.Text) = True Then
                    MsgBox("Empty Cellphone_No is Not Valid!")
                    Me.TextBox3.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox4.Text) = True Then
                    MsgBox("Empty Email Address is Not Valid!")
                    Me.TextBox4.Focus()
                ElseIf String.IsNullOrEmpty(Me.TextBox5.Text) = True Then
                    MsgBox("Empty Address No is Not Valid!")
                    Me.TextBox5.Focus()

                Else
                    If MessageBox.Show("DO YOU WANT TO UPDATE RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        DATASET.Tables.Clear()
                        CONN.Open()
                        CMD = CONN.CreateCommand
                        CMD.CommandText = "UPDATE Supplierstable SET Name = @Name, Company = @Company, [Cellphone No] = @Cellphone_No, [Email Address] = @Email_Address, Address = @Address WHERE [REC NO] = '" & Me.Label7.Text & "'"

                        CMD.Parameters.Add("@Name", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Company", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Cellphone_No", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Email_Address", SqlDbType.NVarChar, 50)
                        CMD.Parameters.Add("@Address", SqlDbType.NVarChar, 50)

                        CMD.Parameters("@Name").Value = Me.TextBox1.Text
                        CMD.Parameters("@Company").Value = Me.TextBox2.Text
                        CMD.Parameters("@Cellphone_No").Value = Me.TextBox3.Text
                        CMD.Parameters("@Email_Address").Value = Me.TextBox4.Text
                        CMD.Parameters("@Address").Value = Me.TextBox5.Text
                        ADAPTER.UpdateCommand = CMD
                        ADAPTER.UpdateCommand.ExecuteNonQuery()
                        CONN.Close()
                        MsgBox("RECORD UPDATED")
                        loaddatak()
                    Else
                        MsgBox("RECORD NOT UPDATED")
                    End If
                    loaddatak()
                    buttondefault()
                    cleartext()
                    Me.ButtonEditUA.Text = "EDIT"
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonDeleteUA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteUA.Click
        Try
            If MessageBox.Show("DO YOU WANT TO DELETE THIS RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = "Delete from Supplierstable"
                ADAPTER.DeleteCommand = CMD
                ADAPTER.DeleteCommand.ExecuteNonQuery()
                CONN.Close()
                MsgBox("RECORD DELETED!")
                Me.DataGridView1.DataSource = DATASET.Tables("Supplierstable")
                loaddatak()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonCancelUA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonCancelUA.Click
        buttondefault()
        cleartext()
    End Sub

    Private Sub ButtonBackUA_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackUA.Click
        Me.Close()
        Mainform.Show()
    End Sub
End Class