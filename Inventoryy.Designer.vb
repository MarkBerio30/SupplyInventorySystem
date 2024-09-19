<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventoryy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventoryy))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ButtonRestockI = New System.Windows.Forms.Button()
        Me.ButtonEditI = New System.Windows.Forms.Button()
        Me.ButtonNewI = New System.Windows.Forms.Button()
        Me.ButtonSearchI = New System.Windows.Forms.Button()
        Me.ButtonDeleteI = New System.Windows.Forms.Button()
        Me.ButtonBackI = New System.Windows.Forms.Button()
        Me.ButtonRefreshI = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CONN = New System.Data.SqlClient.SqlConnection()
        Me.ADAPTER = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonRestockI
        '
        Me.ButtonRestockI.BackColor = System.Drawing.Color.DimGray
        Me.ButtonRestockI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRestockI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRestockI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRestockI.ForeColor = System.Drawing.Color.White
        Me.ButtonRestockI.Image = CType(resources.GetObject("ButtonRestockI.Image"), System.Drawing.Image)
        Me.ButtonRestockI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRestockI.Location = New System.Drawing.Point(437, 369)
        Me.ButtonRestockI.Name = "ButtonRestockI"
        Me.ButtonRestockI.Size = New System.Drawing.Size(103, 43)
        Me.ButtonRestockI.TabIndex = 31
        Me.ButtonRestockI.Text = "RESTOCK"
        Me.ButtonRestockI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRestockI.UseVisualStyleBackColor = False
        '
        'ButtonEditI
        '
        Me.ButtonEditI.BackColor = System.Drawing.Color.DimGray
        Me.ButtonEditI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonEditI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditI.ForeColor = System.Drawing.Color.White
        Me.ButtonEditI.Image = CType(resources.GetObject("ButtonEditI.Image"), System.Drawing.Image)
        Me.ButtonEditI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEditI.Location = New System.Drawing.Point(325, 369)
        Me.ButtonEditI.Name = "ButtonEditI"
        Me.ButtonEditI.Size = New System.Drawing.Size(76, 43)
        Me.ButtonEditI.TabIndex = 26
        Me.ButtonEditI.Text = "EDIT"
        Me.ButtonEditI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEditI.UseVisualStyleBackColor = False
        '
        'ButtonNewI
        '
        Me.ButtonNewI.BackColor = System.Drawing.Color.DimGray
        Me.ButtonNewI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonNewI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNewI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewI.ForeColor = System.Drawing.Color.White
        Me.ButtonNewI.Image = CType(resources.GetObject("ButtonNewI.Image"), System.Drawing.Image)
        Me.ButtonNewI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNewI.Location = New System.Drawing.Point(209, 369)
        Me.ButtonNewI.Name = "ButtonNewI"
        Me.ButtonNewI.Size = New System.Drawing.Size(76, 43)
        Me.ButtonNewI.TabIndex = 25
        Me.ButtonNewI.Text = "NEW"
        Me.ButtonNewI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNewI.UseVisualStyleBackColor = False
        '
        'ButtonSearchI
        '
        Me.ButtonSearchI.BackColor = System.Drawing.Color.Silver
        Me.ButtonSearchI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSearchI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearchI.ForeColor = System.Drawing.Color.Black
        Me.ButtonSearchI.Image = CType(resources.GetObject("ButtonSearchI.Image"), System.Drawing.Image)
        Me.ButtonSearchI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearchI.Location = New System.Drawing.Point(821, 12)
        Me.ButtonSearchI.Name = "ButtonSearchI"
        Me.ButtonSearchI.Size = New System.Drawing.Size(96, 39)
        Me.ButtonSearchI.TabIndex = 30
        Me.ButtonSearchI.Text = "SEARCH"
        Me.ButtonSearchI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSearchI.UseVisualStyleBackColor = False
        '
        'ButtonDeleteI
        '
        Me.ButtonDeleteI.BackColor = System.Drawing.Color.DimGray
        Me.ButtonDeleteI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDeleteI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteI.ForeColor = System.Drawing.Color.White
        Me.ButtonDeleteI.Image = CType(resources.GetObject("ButtonDeleteI.Image"), System.Drawing.Image)
        Me.ButtonDeleteI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDeleteI.Location = New System.Drawing.Point(711, 369)
        Me.ButtonDeleteI.Name = "ButtonDeleteI"
        Me.ButtonDeleteI.Size = New System.Drawing.Size(87, 43)
        Me.ButtonDeleteI.TabIndex = 27
        Me.ButtonDeleteI.Text = "DELETE"
        Me.ButtonDeleteI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDeleteI.UseVisualStyleBackColor = False
        '
        'ButtonBackI
        '
        Me.ButtonBackI.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBackI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonBackI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBackI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackI.ForeColor = System.Drawing.Color.White
        Me.ButtonBackI.Image = Global.SUPPYINVENTORYSYSTEM.My.Resources.Resources.backward_32x32
        Me.ButtonBackI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBackI.Location = New System.Drawing.Point(826, 369)
        Me.ButtonBackI.Name = "ButtonBackI"
        Me.ButtonBackI.Size = New System.Drawing.Size(76, 43)
        Me.ButtonBackI.TabIndex = 29
        Me.ButtonBackI.Text = "BACK"
        Me.ButtonBackI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBackI.UseVisualStyleBackColor = False
        '
        'ButtonRefreshI
        '
        Me.ButtonRefreshI.BackColor = System.Drawing.Color.DimGray
        Me.ButtonRefreshI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRefreshI.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefreshI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshI.ForeColor = System.Drawing.Color.White
        Me.ButtonRefreshI.Image = CType(resources.GetObject("ButtonRefreshI.Image"), System.Drawing.Image)
        Me.ButtonRefreshI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshI.Location = New System.Drawing.Point(579, 369)
        Me.ButtonRefreshI.Name = "ButtonRefreshI"
        Me.ButtonRefreshI.Size = New System.Drawing.Size(96, 43)
        Me.ButtonRefreshI.TabIndex = 28
        Me.ButtonRefreshI.Text = "REFRESH"
        Me.ButtonRefreshI.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefreshI.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 100
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(693, 257)
        Me.DataGridView1.TabIndex = 24
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
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(194, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(726, 295)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INVENTORY"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.Label4)
        Me.PanelControl1.Controls.Add(Me.Label3)
        Me.PanelControl1.Controls.Add(Me.Label5)
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(185, 437)
        Me.PanelControl1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "------"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Current User:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Jan/00/2020"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(41, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 19)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "00-00-00"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(23, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Inventoryy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 437)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.ButtonRestockI)
        Me.Controls.Add(Me.ButtonEditI)
        Me.Controls.Add(Me.ButtonNewI)
        Me.Controls.Add(Me.ButtonSearchI)
        Me.Controls.Add(Me.ButtonDeleteI)
        Me.Controls.Add(Me.ButtonBackI)
        Me.Controls.Add(Me.ButtonRefreshI)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventoryy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XtraForm5"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonRestockI As System.Windows.Forms.Button
    Friend WithEvents ButtonEditI As System.Windows.Forms.Button
    Friend WithEvents ButtonNewI As System.Windows.Forms.Button
    Friend WithEvents ButtonSearchI As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteI As System.Windows.Forms.Button
    Friend WithEvents ButtonBackI As System.Windows.Forms.Button
    Friend WithEvents ButtonRefreshI As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CONN As System.Data.SqlClient.SqlConnection
    Friend WithEvents ADAPTER As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
