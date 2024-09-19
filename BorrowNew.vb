Public Class BorrowNew

    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Dim w As String
    Public Sub ss()
        Try
            Dim Icmd As String = "SELECT * FROM suppliesinventorytable WHERE [Item Name] = '" & Me.ComboBox1.Text & "' and Quantity = '0'"

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                w = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Name").ToString
                If ComboBox1.Text = w Then
                    MsgBox("THIS ITEM IS OUT OF STOCK")
                End If
            Else
                borrowadd()

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub searchh()
        Try
            Dim Icmd As String = "SELECT * FROM suppliesinventorytable WHERE [Item Type] = 'Subject for Return'"

            DATASET.Tables.Clear()
            If Me.ComboBox1.Text <> "" Then
                Icmd = Icmd & "AND [Item Name] = '" & Me.ComboBox1.Text & "'"
            End If

            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Code").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Name").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Quantity").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Price").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Status").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Type").ToString
                Inventoryy.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Supplier").ToString
                Me.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub updates()
        Try
            Dim a As String
            a = Me.TextBox3.Text - Me.NumericUpDown1.Text
            Dim stat As String = ""
            If a = 0 Then
                stat = "Out of Stock"
            ElseIf a > 0 Then
                stat = "Stocked"
            End If

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "UPDATE suppliesinventorytable SET Quantity = @Quantity, Status = @Status where [Item Name] = '" & Me.ComboBox1.Text & "'"

            CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)
            CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)

            CMD.Parameters("@Quantity").Value = a
            CMD.Parameters("@Status").Value = stat
            ADAPTER.UpdateCommand = CMD
            ADAPTER.UpdateCommand.ExecuteNonQuery()
            CONN.Close()
            Inventoryy.loaddata()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ItemName()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox1.ResetText()
            Me.ComboBox1.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT [Item Name] FROM suppliesinventorytable where [Item Type] = 'Subject for Return' "
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("suppliesinventorytable").Rows.Count - 1
                    Me.ComboBox1.Items.Add(DATASET.Tables("suppliesinventorytable").Rows(i).Item("Item Name").ToString())
                Next
            End If
            Me.ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub borrowadd()

        Try
            Dim stat As String = ""
            If Me.NumericUpDown1.Text = 0 Then
                stat = "Out of Stock"
            ElseIf Me.NumericUpDown1.Text > 0 Then
                stat = "Stocked"
            End If
            If String.IsNullOrEmpty(Me.TextBox1.Text) = True Then
                MsgBox("Empty Borrower is Not Valid")
                Me.TextBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.ComboBox3.Text) = True Then
                MsgBox("Empty Department No is Not Valid!")
                Me.ComboBox3.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                MsgBox("Empty Cellphone No is Not Valid!")
                Me.TextBox2.Focus()
            ElseIf String.IsNullOrEmpty(Me.ComboBox1.Text) = True Then
                MsgBox("Empty Item Borrowed is Not Valid!")
                Me.ComboBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.NumericUpDown1.Text) = True Then
                MsgBox("Empty Quantity is Not Valid!")
                Me.NumericUpDown1.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox5.Text) = True Then
                MsgBox("Empty Person in Charge is Not Valid!")
                Me.TextBox5.Focus()
            ElseIf String.IsNullOrEmpty(Me.ComboBox2.Text) = True Then
                MsgBox("Empty School Year is Not Valid!")
                Me.ComboBox2.Focus()
            Else
                If MessageBox.Show("DO YOU WANT TO SAVE RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    DATASET.Tables.Clear()
                    CONN.Open()
                    CMD = CONN.CreateCommand
                    CMD.CommandText = "Insert Into BorrowTable values(@Borrower, @Department, @Cellphone_No,  @Item_Borrowed, @Quantity, @Person_in_Charge, @Date_Borrowed, @Return_Due_Date, @Date_Returned, @School_Year, @Status)"
                    CMD.Parameters.Add("@Borrower", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Department", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Cellphone_No", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Item_Borrowed", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Person_in_Charge", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Date_Borrowed", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Return_Due_Date", SqlDbType.Date)
                    CMD.Parameters.Add("@Date_Returned", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@School_Year", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Status", SqlDbType.NVarChar, 50)


                    CMD.Parameters("@Borrower").Value = Me.TextBox1.Text
                    CMD.Parameters("@Department").Value = Me.ComboBox3.Text()
                    CMD.Parameters("@Cellphone_No").Value = Me.TextBox2.Text
                    CMD.Parameters("@Item_Borrowed").Value = Me.ComboBox1.Text
                    CMD.Parameters("@Quantity").Value = Me.NumericUpDown1.Text
                    CMD.Parameters("@Person_in_Charge").Value = Me.TextBox5.Text
                    CMD.Parameters("@Date_Borrowed").Value = DateString
                    CMD.Parameters("@Return_Due_Date").Value = DateTimePicker1.Text
                    CMD.Parameters("@Date_Returned").Value = "---"
                    CMD.Parameters("@School_Year").Value = Me.ComboBox2.Text
                    CMD.Parameters("@Status").Value = "Borrow"
                    ADAPTER.InsertCommand = CMD
                    ADAPTER.InsertCommand.ExecuteNonQuery()
                    CONN.Close()
                    MsgBox("RECORD SAVE")
                    Borrow.DataGridView1.DataSource = DATASET.Tables("BorrowTable")
                    Borrow.loaddataB()
                    updates()
                    searchh()



                    Me.Close()

                Else

                    MsgBox("RECORD NOT SAVE")

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSaveBN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveBN.Click
        ss()
    End Sub

    Private Sub ButtonBackBN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackBN.Click
        Me.Close()
        Borrow.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.TextBox6.Text = DateString
    End Sub


    Private Sub BorrowNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox5.Text = Borrow.Label1.Text
        ItemName()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        searchh()
    End Sub

    Private Sub DataGridView1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        Try
            Me.TextBox3.Text = Me.DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
        Catch ex As Exception

        End Try
    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try
            If Me.TextBox1.Text.Length = 12 Then
                Dim Icmd As String = "SELECT * FROM BorrowersTable WHERE [User Code] = '" & Me.TextBox1.Text & "'"
                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = Icmd
                ADAPTER.SelectCommand = CMD
                ADAPTER.SelectCommand.ExecuteNonQuery()
                ADAPTER.Fill(DATASET, "BorrowersTable")
                CONN.Close()
                If DATASET.Tables("BorrowersTable").Rows.Count > 0 Then
                    Me.TextBox1.Text = DATASET.Tables("BorrowersTable").Rows(0).Item("Name").ToString
                    Me.TextBox2.Text = DATASET.Tables("BorrowersTable").Rows(0).Item("Cellphone No").ToString
                    Me.ComboBox3.Text = DATASET.Tables("BorrowersTable").Rows(0).Item("Department").ToString
                Else

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        Try
            If Me.ComboBox1.Text.Length = 6 Then
                Dim Icmd As String = "SELECT * FROM suppliesinventorytable WHERE [Item Code] = '" & Me.ComboBox1.Text & "' and [Item Type] = 'Subject for Return'"
                DATASET.Tables.Clear()
                CONN.Open()
                CMD = CONN.CreateCommand
                CMD.CommandText = Icmd
                ADAPTER.SelectCommand = CMD
                ADAPTER.SelectCommand.ExecuteNonQuery()
                ADAPTER.Fill(DATASET, "suppliesinventorytable")
                CONN.Close()
                If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                    Me.ComboBox1.Text = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Item Name").ToString

                Else

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class