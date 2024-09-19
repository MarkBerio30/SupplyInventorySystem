Imports DevExpress.XtraScheduler
Imports System.IO.Ports
Imports System.IO
Imports System.Drawing.Imaging

Public Class Mainform
    Dim CMD As New SqlClient.SqlCommand
    Dim DATASET As New DataSet
    Dim iBorrower As String = ""
    Dim iCellphoneNo As String = ""
    Dim iQuantity As String = ""
    Dim iItemBorrowed As String = ""
    Dim iReturnDueDate As String = ""


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = TimeOfDay
        Label2.Text = Date.Now.ToString("MMM/dd/yyyy")
    End Sub
    Public Sub Send_SMS()
        Dim Global_SMS_Message As String = ""
        Dim smsMessageIn As String = iBorrower & " We would like to inform you that the " & iQuantity & " " & iItemBorrowed & " you borrowed is due to be returned " & iReturnDueDate & ". Please return on the said due date. From: SNS Supply Office"


        SerialPort1 = New System.IO.Ports.SerialPort
        SerialPort1.PortName = "COM17"
        SerialPort1.BaudRate = 9600
        SerialPort1.Parity = Parity.None
        SerialPort1.StopBits = StopBits.One
        SerialPort1.DataBits = 8
        SerialPort1.Handshake = Handshake.RequestToSend
        SerialPort1.DtrEnable = True
        SerialPort1.RtsEnable = True
        SerialPort1.NewLine = vbCrLf
        Global_SMS_Message = smsMessageIn
        SerialPort1.Open()

        If SerialPort1.IsOpen() = True Then
            SerialPort1.Write("AT" & vbCrLf)
            SerialPort1.Write("AT+CMGF=1" & vbCrLf)
            SerialPort1.Write("AT+CMGS=" & Chr(34) & iCellphoneNo & Chr(34) & vbCrLf)
            SerialPort1.Write(Global_SMS_Message & Chr(26))
            SerialPort1.Close()
        Else
            MsgBox("Port Not Available")

        End If

    End Sub
    Public Sub loaddata()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from suppliesinventorytable"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "suppliesinventorytable")
            CONN.Close()
            Me.DataGridView1.DataSource = DATASET.Tables("suppliesinventorytable")
            alarms()
            For a = 0 To Me.DataGridView1.Rows.Count - 2
                If Me.DataGridView1.Rows(a).Cells("Status").Value.ToString = "Out of Stock" Then
                    Me.Button1.Text = Val(Me.Button1.Text) + 1
                End If
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub loaddataP()
        Try
            DATASET.Tables.Clear()
            CONN.Open()
            CMD = CONN.CreateCommand
            CMD.CommandText = "select * from BorrowTable where Status = 'Borrow' order by [Return due date]"
            ADAPTER.SelectCommand = CMD
            ADAPTER.SelectCommand.ExecuteNonQuery()
            ADAPTER.Fill(DATASET, "BorrowTable")
            CONN.Close()
            Me.DataGridView2.DataSource = DATASET.Tables("BorrowTable")
            alarm()
            'colors()
            For i = 0 To Me.DataGridView2.Rows.Count - 2
                If Me.DataGridView2.Rows(i).Cells("Status").Value.ToString = "Borrow" Then
                    Me.Button2.Text = Val(Me.Button2.Text) + 1
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub alarms()
        For i As Integer = 0 To DataGridView1.Rows.Count() - 1 Step +1
            Dim val As String

            val = DataGridView1.Rows(i).Cells(4).Value

            If val = "Out of Stock" Then
                DataGridView1.Rows(i).DefaultCellStyle.BackColor = Color.Orange

            Else

            End If
        Next
    End Sub
    Public Sub alarm()

        'For i As Integer = 0 To DataGridView2.Rows.Count() - 1 Step +1
        Dim val As String
        For i = 0 To DataGridView2.Rows.Count() - 1 Step +1

            val = Me.DataGridView2.Rows(i).Cells(8).Value

            If val = Now.Date.ToString("yyyy-MM-dd") Then
                'DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Red
                iCellphoneNo = Me.DataGridView2.Rows(i).Cells(3).Value
                iBorrower = Me.DataGridView2.Rows(i).Cells(1).Value
                iQuantity = Me.DataGridView2.Rows(i).Cells(5).Value
                iItemBorrowed = Me.DataGridView2.Rows(i).Cells(4).Value
                Send_SMS()
            End If
        Next
    End Sub
    Public Sub colors()
        For i As Integer = 0 To DataGridView2.Rows.Count() - 1
            Dim val As String = ""
            val = DataGridView2.Rows(i).Cells(8).Value
            If val = Date.Now.ToString("yyyy-MM-dd") And
                ProgressBar1.Value = "10" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
            ProgressBar1.Value = "20" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.White
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "30" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "40" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.White
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "50" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "60" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.White
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "70" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "80" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.White
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "90" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.Red
            ElseIf val = Date.Now.ToString("yyyy-MM-dd") And
                   ProgressBar1.Value = "100" Then
                DataGridView2.Rows(i).DefaultCellStyle.BackColor = Color.White
            ElseIf ProgressBar1.Value = 100 Then
                ProgressBar1.Value = 0
                Timer3.Stop()
            ElseIf ProgressBar1.Value = 0 Then
                Timer3.Start()
                ProgressBar1.Increment(5)
            End If
        Next
    End Sub

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.BorrowTable' table. You can move, or remove it, as needed.
        Me.BorrowTableTableAdapter1.Fill(Me.Database1DataSet2.BorrowTable)
        'TODO: This line of code loads data into the 'Database1DataSet1.BorrowTable' table. You can move, or remove it, as needed.
        Me.BorrowTableTableAdapter.Fill(Me.Database1DataSet1.BorrowTable)
        loaddata()
        Me.Label6.Text = Borrow.Label1.Text
        Me.SchedulerControl1.DayView.ShowAllDayArea = True
        Me.SchedulerControl1.GoToToday()
        Timer2.Start()
        loaddataP()
        Timer2.Start()
        alarm()

    End Sub

    Private Sub NavBarItem4_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem4.LinkClicked
        Me.Close()
        Borrow.Show()
    End Sub

    Private Sub NavBarItem5_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem5.LinkClicked
        Me.Close()
        RETURNING.Show()
    End Sub

    Private Sub NavBarItem6_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem6.LinkClicked
        Me.Close()
        Release.Show()
    End Sub

    Private Sub NavBarItem7_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem7.LinkClicked
        Me.Close()
        Inventoryy.Show()
    End Sub

    Private Sub ButtonLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonLogOut.Click
        Me.Close()
        loginform.Show()
    End Sub

    Private Sub NavBarItem10_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem10.LinkClicked
        UserAccount.Show()
        Me.Close()
    End Sub

    Private Sub NavBarItem9_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem9.LinkClicked
        ReleaseItem.Show()
        Me.Close()
    End Sub

    Private Sub NavBarItem8_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem8.LinkClicked
        BorrowedItems.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        outofstock.Show()
    End Sub

    Private Sub NavBarItem12_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem12.LinkClicked
        BorrowersAccount.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Itemstobereturn.Show()
    End Sub

    Private Sub NavBarItem13_LinkClicked(ByVal sender As Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem13.LinkClicked
        SuppliersAccount.Show()
        Me.Hide()

    End Sub


    Private Sub GroupBox7_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox7.Enter

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ProgressBar1.Increment(5)
        colors()
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        ProgressBar1.Increment(5)
        colors()
    End Sub
End Class