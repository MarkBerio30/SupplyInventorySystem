<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrow
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrow))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ButtonEditB = New System.Windows.Forms.Button()
        Me.ButtonNewB = New System.Windows.Forms.Button()
        Me.ButtonSearchB = New System.Windows.Forms.Button()
        Me.ButtonDeleteB = New System.Windows.Forms.Button()
        Me.ButtonBackB = New System.Windows.Forms.Button()
        Me.ButtonRefreshB = New System.Windows.Forms.Button()
        Me.CONN = New System.Data.SqlClient.SqlConnection()
        Me.ADAPTER = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(595, 272)
        Me.DataGridView1.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(27, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 266)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(73, 200)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 19)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "------"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(27, 159)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 19)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Current User:"
        '
        'ButtonEditB
        '
        Me.ButtonEditB.BackColor = System.Drawing.Color.DimGray
        Me.ButtonEditB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonEditB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditB.ForeColor = System.Drawing.Color.White
        Me.ButtonEditB.Image = CType(resources.GetObject("ButtonEditB.Image"), System.Drawing.Image)
        Me.ButtonEditB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEditB.Location = New System.Drawing.Point(359, 398)
        Me.ButtonEditB.Name = "ButtonEditB"
        Me.ButtonEditB.Size = New System.Drawing.Size(83, 43)
        Me.ButtonEditB.TabIndex = 19
        Me.ButtonEditB.Text = "EDIT"
        Me.ButtonEditB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEditB.UseVisualStyleBackColor = False
        '
        'ButtonNewB
        '
        Me.ButtonNewB.BackColor = System.Drawing.Color.DimGray
        Me.ButtonNewB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonNewB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNewB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewB.ForeColor = System.Drawing.Color.White
        Me.ButtonNewB.Image = CType(resources.GetObject("ButtonNewB.Image"), System.Drawing.Image)
        Me.ButtonNewB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNewB.Location = New System.Drawing.Point(243, 398)
        Me.ButtonNewB.Name = "ButtonNewB"
        Me.ButtonNewB.Size = New System.Drawing.Size(82, 43)
        Me.ButtonNewB.TabIndex = 18
        Me.ButtonNewB.Text = "NEW"
        Me.ButtonNewB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNewB.UseVisualStyleBackColor = False
        '
        'ButtonSearchB
        '
        Me.ButtonSearchB.BackColor = System.Drawing.Color.Silver
        Me.ButtonSearchB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSearchB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearchB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearchB.ForeColor = System.Drawing.Color.Black
        Me.ButtonSearchB.Image = CType(resources.GetObject("ButtonSearchB.Image"), System.Drawing.Image)
        Me.ButtonSearchB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearchB.Location = New System.Drawing.Point(753, 27)
        Me.ButtonSearchB.Name = "ButtonSearchB"
        Me.ButtonSearchB.Size = New System.Drawing.Size(101, 36)
        Me.ButtonSearchB.TabIndex = 23
        Me.ButtonSearchB.Text = "SEARCH"
        Me.ButtonSearchB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSearchB.UseVisualStyleBackColor = False
        '
        'ButtonDeleteB
        '
        Me.ButtonDeleteB.BackColor = System.Drawing.Color.DimGray
        Me.ButtonDeleteB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDeleteB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteB.ForeColor = System.Drawing.Color.White
        Me.ButtonDeleteB.Image = CType(resources.GetObject("ButtonDeleteB.Image"), System.Drawing.Image)
        Me.ButtonDeleteB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDeleteB.Location = New System.Drawing.Point(599, 398)
        Me.ButtonDeleteB.Name = "ButtonDeleteB"
        Me.ButtonDeleteB.Size = New System.Drawing.Size(90, 43)
        Me.ButtonDeleteB.TabIndex = 20
        Me.ButtonDeleteB.Text = "DELETE"
        Me.ButtonDeleteB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDeleteB.UseVisualStyleBackColor = False
        '
        'ButtonBackB
        '
        Me.ButtonBackB.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBackB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonBackB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBackB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackB.ForeColor = System.Drawing.Color.White
        Me.ButtonBackB.Image = CType(resources.GetObject("ButtonBackB.Image"), System.Drawing.Image)
        Me.ButtonBackB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBackB.Location = New System.Drawing.Point(710, 398)
        Me.ButtonBackB.Name = "ButtonBackB"
        Me.ButtonBackB.Size = New System.Drawing.Size(86, 43)
        Me.ButtonBackB.TabIndex = 22
        Me.ButtonBackB.Text = "BACK"
        Me.ButtonBackB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBackB.UseVisualStyleBackColor = False
        '
        'ButtonRefreshB
        '
        Me.ButtonRefreshB.BackColor = System.Drawing.Color.DimGray
        Me.ButtonRefreshB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRefreshB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefreshB.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshB.ForeColor = System.Drawing.Color.White
        Me.ButtonRefreshB.Image = CType(resources.GetObject("ButtonRefreshB.Image"), System.Drawing.Image)
        Me.ButtonRefreshB.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshB.Location = New System.Drawing.Point(472, 398)
        Me.ButtonRefreshB.Name = "ButtonRefreshB"
        Me.ButtonRefreshB.Size = New System.Drawing.Size(102, 43)
        Me.ButtonRefreshB.TabIndex = 21
        Me.ButtonRefreshB.Text = "REFRESH"
        Me.ButtonRefreshB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefreshB.UseVisualStyleBackColor = False
        '
        'CONN
        '
        Me.CONN.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrate" & _
            "d Security=True;User Instance=True"
        Me.CONN.FireInfoMessageEventOnUserErrors = False
        '
        'ADAPTER
        '
        Me.ADAPTER.InsertCommand = Me.SqlInsertCommand1
        Me.ADAPTER.SelectCommand = Me.SqlSelectCommand1
        Me.ADAPTER.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "suppliesinventorytable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Item Code", "Item Code"), New System.Data.Common.DataColumnMapping("Item Name", "Item Name"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Item Type", "Item Type"), New System.Data.Common.DataColumnMapping("Supplier", "Supplier")})})
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [suppliesinventorytable] ([Item Code], [Item Name], [Quantity], [Stat" & _
            "us], [Item Type], [Supplier]) VALUES (@Item_Code, @Item_Name, @Quantity, @Status" & _
            ", @Item_Type, @Supplier)"
        Me.SqlInsertCommand1.Connection = Me.CONN
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Item_Code", System.Data.SqlDbType.NVarChar, 0, "Item Code"), New System.Data.SqlClient.SqlParameter("@Item_Name", System.Data.SqlDbType.NVarChar, 0, "Item Name"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.NVarChar, 0, "Quantity"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Item_Type", System.Data.SqlDbType.NVarChar, 0, "Item Type"), New System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.NVarChar, 0, "Supplier")})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        suppliesinventorytable.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            suppliesinventorytable"
        Me.SqlSelectCommand1.Connection = Me.CONN
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.DataGridView2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(208, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 300)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BORROW"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(92, 232)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 23)
        Me.TextBox3.TabIndex = 95
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(24, 209)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(62, 17)
        Me.DataGridView2.TabIndex = 93
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 232)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(62, 23)
        Me.TextBox1.TabIndex = 96
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(24, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(62, 23)
        Me.TextBox2.TabIndex = 94
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(173, 470)
        Me.PanelControl1.TabIndex = 31
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "------"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Jan/00/2020"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Current User:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "00-00-00"
        '
        'Borrow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 470)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ButtonEditB)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ButtonNewB)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonSearchB)
        Me.Controls.Add(Me.ButtonDeleteB)
        Me.Controls.Add(Me.ButtonBackB)
        Me.Controls.Add(Me.ButtonRefreshB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Borrow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "s"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ButtonEditB As System.Windows.Forms.Button
    Friend WithEvents ButtonNewB As System.Windows.Forms.Button
    Friend WithEvents ButtonSearchB As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteB As System.Windows.Forms.Button
    Friend WithEvents ButtonBackB As System.Windows.Forms.Button
    Friend WithEvents ButtonRefreshB As System.Windows.Forms.Button
    Friend WithEvents CONN As System.Data.SqlClient.SqlConnection
    Friend WithEvents ADAPTER As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
