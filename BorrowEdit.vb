Public Class BorrowEdit

    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Dim q1 As String
    Dim q2 As String
    Dim m1 As String
    Dim m2 As String
    Dim sum As String
    Dim minus As String
    Dim w As String

    Public Sub search1()
        Try
            Dim Icmd As String = "SELECT * FROM BorrowTable WHERE [Record No] = '" & Me.Label10.Text & "'"

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            If DATASET.Tables("BorrowTable").Rows.Count > 0 Then
                q1 = DATASET.Tables("BorrowTable").Rows(0).Item("Quantity").ToString

            Else

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub search2()
        Try
            Dim Icmd As String = "SELECT Quantity FROM suppliesinventorytable WHERE [Item Name] = '" & Me.TextBox3.Text & "'"
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                q2 = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Quantity").ToString
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub search3()
        Try
            Dim Icmd As String = "SELECT * FROM BorrowTable WHERE [Record No] = '" & Me.Label10.Text & "'"

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            If DATASET.Tables("BorrowTable").Rows.Count > 0 Then
                m1 = DATASET.Tables("BorrowTable").Rows(0).Item("Quantity").ToString
            Else

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub search4()
        Try
            Dim Icmd As String = "SELECT Quantity FROM suppliesinventorytable WHERE [Item Name] = '" & Me.TextBox3.Text & "'"
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = Icmd
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                m2 = DATASET.Tables("suppliesinventorytable").Rows(0).Item("Quantity").ToString
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub updates()
        Try

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "UPDATE suppliesinventorytable SET Quantity = @Quantity WHERE [item name] = '" & Me.TextBox3.Text & "'"
            CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)

            '
            CMD.Parameters("@Quantity").Value = sum



            ADAPTER.UpdateCommand = CMD
            ADAPTER.UpdateCommand.ExecuteNonQuery()
            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub updates2()
        Try

            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "UPDATE suppliesinventorytable SET Quantity = @Quantity WHERE [item name] = '" & Me.TextBox3.Text & "'"
            CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)

            '
            CMD.Parameters("@Quantity").Value = minus



            ADAPTER.UpdateCommand = CMD
            ADAPTER.UpdateCommand.ExecuteNonQuery()
            CONN.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub ss()
        Try
            Dim Icmd As String = "SELECT * FROM suppliesinventorytable WHERE [Item Name] = '" & Me.TextBox3.Text & "' and Quantity = '0'"

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
                If TextBox3.Text = w Then
                    MsgBox("THIS ITEM IS OUT OF STOCK")
                End If
            Else
                borrowupdate()


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub borrowupdate()
        Try
            
            If String.IsNullOrEmpty(Me.TextBox1.Text) = True Then
                MsgBox("Empty Borrower is Not Valid")
                Me.TextBox1.Focus()
            ElseIf String.IsNullOrEmpty(Me.ComboBox3.Text) = True Then
                MsgBox("Empty Department is Not Valid!")
                Me.ComboBox3.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox2.Text) = True Then
                MsgBox("Empty Cellphone No is Not Valid!")
                Me.TextBox2.Focus()
            ElseIf String.IsNullOrEmpty(Me.TextBox3.Text) = True Then
                MsgBox("Empty Item Borrowed is Not Valid!")
                Me.TextBox3.Focus()
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
                If MessageBox.Show("DO YOU WANT TO UPDATE RECORD?", "SYSTEM MESSAGE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                    DATASET.Tables.Clear()
                    CONN.Open()
                    CMD = CONN.CreateCommand
                    CMD.CommandText = "UPDATE BorrowTable SET Borrower = @Borrower, Department = @Department, [Cellphone No] = @Cellphone_No, [Item Borrowed] = @Item_Borrowed, Quantity = @Quantity, [Person in Charge] = @Person_in_Charge, [Date Borrowed] = @Date_Borrowed, [Return Due Date] = @Return_Due_Date, [Date Returned] = @Date_Returned, [School Year] = @School_Year WHERE [Record No] = '" & Me.Label10.Text & "'"

                    CMD.Parameters.Add("@Borrower", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Department", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Cellphone_No", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Item_Borrowed", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Quantity", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Person_in_Charge", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Date_Borrowed", SqlDbType.Date)
                    CMD.Parameters.Add("@Return_Due_Date", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@Date_Returned", SqlDbType.NVarChar, 50)
                    CMD.Parameters.Add("@School_Year", SqlDbType.NVarChar, 50)

                    CMD.Parameters("@Borrower").Value = Me.TextBox1.Text
                    CMD.Parameters("@Department").Value = Me.ComboBox3.Text
                    CMD.Parameters("@Cellphone_No").Value = Me.TextBox2.Text
                    CMD.Parameters("@Item_Borrowed").Value = Me.TextBox3.Text
                    CMD.Parameters("@Quantity").Value = Me.NumericUpDown1.Text
                    CMD.Parameters("@Person_in_Charge").Value = Me.TextBox5.Text
                    CMD.Parameters("@Date_Borrowed").Value = DateString
                    CMD.Parameters("@Return_Due_Date").Value = Me.DateTimePicker1.Text
                    CMD.Parameters("@Date_Returned").Value = "---"
                    CMD.Parameters("@School_Year").Value = Me.ComboBox2.Text
                    ADAPTER.UpdateCommand = CMD
                    ADAPTER.UpdateCommand.ExecuteNonQuery()
                    CONN.Close()
                    MsgBox("RECORD UPDATED")
                    Borrow.loaddataB()

                    Me.Close()


                Else
                    MsgBox("RECORD NOT UPDATED")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUpdateBE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUpdateBE.Click
        search1()
        search2()
        sum = Val(q1) + Val(q2)
        updates()
        search4()
        minus = Val(m2) - Val(NumericUpDown1.Value)
        updates2()
        ss()

    End Sub

    Private Sub ButtonBackBE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackBE.Click
        Me.Close()
        Borrow.Show()
    End Sub


    Private Sub BorrowEdit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TextBox5.Text = Borrow.Label1.Text
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.TextBox6.Text = DateString
    End Sub

  
End Class
