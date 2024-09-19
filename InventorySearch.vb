Public Class InventorySearch

    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet

    Private Sub ButtonBackIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBackIS.Click
        Me.Close()
        Inventoryy.Show()
    End Sub

    Private Sub InventorySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Item_Code()
        Item_Name()
    End Sub

    Private Sub ButtonSearchIS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSearchIS.Click
        Try
            Dim Icmd As String = "SELECT * FROM suppliesinventorytable WHERE [Item Code] <> '0'"
            DATASET.Tables.Clear()
            If Me.ComboBox1.Text <> "" Then
                Icmd = Icmd & "AND [Item Code] = '" & Me.ComboBox1.Text & "'"
            End If
            If Me.ComboBox2.Text <> "" Then
                Icmd = Icmd & "AND [Item Name] = '" & Me.ComboBox2.Text & "'"
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
                MsgBox("RECORD FOUND")
                Inventoryy.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")

            Else
                MsgBox("RECORD NOT FOUND")
            End If
            Me.Hide()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Item_Code()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox1.ResetText()
            Me.ComboBox1.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT [Item Code] FROM suppliesinventorytable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("suppliesinventorytable").Rows.Count - 1
                    Me.ComboBox1.Items.Add(DATASET.Tables("suppliesinventorytable").Rows(i).Item("Item Code").ToString())
                Next
            End If
            Me.ComboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Item_Name()
        Try
            DATASET.Tables.Clear()
            Me.ComboBox2.ResetText()
            Me.ComboBox2.Items.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "SELECT DISTINCT [Item Name] FROM suppliesinventorytable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            If DATASET.Tables("suppliesinventorytable").Rows.Count > 0 Then
                For i = 0 To DATASET.Tables("suppliesinventorytable").Rows.Count - 1
                    Me.ComboBox2.Items.Add(DATASET.Tables("suppliesinventorytable").Rows(i).Item("Item Name").ToString())
                Next
            End If
            Me.ComboBox2.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            Me.ComboBox2.AutoCompleteSource = AutoCompleteSource.ListItems

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class