<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Release
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Release))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonSearchR = New System.Windows.Forms.Button()
        Me.ButtonNewR = New System.Windows.Forms.Button()
        Me.ButtonDeleteD = New System.Windows.Forms.Button()
        Me.ButtonBackR = New System.Windows.Forms.Button()
        Me.ButtonEditR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonRefreshR = New System.Windows.Forms.Button()
        Me.ADAPTER = New System.Data.SqlClient.SqlDataAdapter()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.CONN = New System.Data.SqlClient.SqlConnection()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(24, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 19)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "------"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(25, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(119, 19)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Current User:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(39, 330)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 19)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Jan/00/2020"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(41, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "00-00-00"
        '
        'ButtonSearchR
        '
        Me.ButtonSearchR.BackColor = System.Drawing.Color.Silver
        Me.ButtonSearchR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSearchR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSearchR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSearchR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearchR.ForeColor = System.Drawing.Color.Black
        Me.ButtonSearchR.Image = CType(resources.GetObject("ButtonSearchR.Image"), System.Drawing.Image)
        Me.ButtonSearchR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSearchR.Location = New System.Drawing.Point(753, 31)
        Me.ButtonSearchR.Name = "ButtonSearchR"
        Me.ButtonSearchR.Size = New System.Drawing.Size(101, 36)
        Me.ButtonSearchR.TabIndex = 34
        Me.ButtonSearchR.Text = "SEARCH"
        Me.ButtonSearchR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSearchR.UseVisualStyleBackColor = False
        '
        'ButtonNewR
        '
        Me.ButtonNewR.BackColor = System.Drawing.Color.DimGray
        Me.ButtonNewR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonNewR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNewR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewR.ForeColor = System.Drawing.Color.White
        Me.ButtonNewR.Image = CType(resources.GetObject("ButtonNewR.Image"), System.Drawing.Image)
        Me.ButtonNewR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonNewR.Location = New System.Drawing.Point(247, 402)
        Me.ButtonNewR.Name = "ButtonNewR"
        Me.ButtonNewR.Size = New System.Drawing.Size(87, 43)
        Me.ButtonNewR.TabIndex = 30
        Me.ButtonNewR.Text = "NEW"
        Me.ButtonNewR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonNewR.UseVisualStyleBackColor = False
        '
        'ButtonDeleteD
        '
        Me.ButtonDeleteD.BackColor = System.Drawing.Color.DimGray
        Me.ButtonDeleteD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDeleteD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteD.ForeColor = System.Drawing.Color.White
        Me.ButtonDeleteD.Image = CType(resources.GetObject("ButtonDeleteD.Image"), System.Drawing.Image)
        Me.ButtonDeleteD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDeleteD.Location = New System.Drawing.Point(475, 402)
        Me.ButtonDeleteD.Name = "ButtonDeleteD"
        Me.ButtonDeleteD.Size = New System.Drawing.Size(87, 43)
        Me.ButtonDeleteD.TabIndex = 30
        Me.ButtonDeleteD.Text = "DELETE"
        Me.ButtonDeleteD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDeleteD.UseVisualStyleBackColor = False
        '
        'ButtonBackR
        '
        Me.ButtonBackR.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBackR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonBackR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBackR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackR.ForeColor = System.Drawing.Color.White
        Me.ButtonBackR.Image = CType(resources.GetObject("ButtonBackR.Image"), System.Drawing.Image)
        Me.ButtonBackR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBackR.Location = New System.Drawing.Point(716, 402)
        Me.ButtonBackR.Name = "ButtonBackR"
        Me.ButtonBackR.Size = New System.Drawing.Size(86, 43)
        Me.ButtonBackR.TabIndex = 33
        Me.ButtonBackR.Text = "BACK"
        Me.ButtonBackR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBackR.UseVisualStyleBackColor = False
        '
        'ButtonEditR
        '
        Me.ButtonEditR.BackColor = System.Drawing.Color.DimGray
        Me.ButtonEditR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonEditR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditR.ForeColor = System.Drawing.Color.White
        Me.ButtonEditR.Image = CType(resources.GetObject("ButtonEditR.Image"), System.Drawing.Image)
        Me.ButtonEditR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEditR.Location = New System.Drawing.Point(364, 402)
        Me.ButtonEditR.Name = "ButtonEditR"
        Me.ButtonEditR.Size = New System.Drawing.Size(87, 43)
        Me.ButtonEditR.TabIndex = 30
        Me.ButtonEditR.Text = "EDIT"
        Me.ButtonEditR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonEditR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 23)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Size = New System.Drawing.Size(595, 266)
        Me.DataGridView1.TabIndex = 27
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ButtonRefreshR
        '
        Me.ButtonRefreshR.BackColor = System.Drawing.Color.DimGray
        Me.ButtonRefreshR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonRefreshR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRefreshR.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRefreshR.ForeColor = System.Drawing.Color.White
        Me.ButtonRefreshR.Image = CType(resources.GetObject("ButtonRefreshR.Image"), System.Drawing.Image)
        Me.ButtonRefreshR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefreshR.Location = New System.Drawing.Point(586, 402)
        Me.ButtonRefreshR.Name = "ButtonRefreshR"
        Me.ButtonRefreshR.Size = New System.Drawing.Size(105, 43)
        Me.ButtonRefreshR.TabIndex = 32
        Me.ButtonRefreshR.Text = "REFRESH"
        Me.ButtonRefreshR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefreshR.UseVisualStyleBackColor = False
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
        'CONN
        '
        Me.CONN.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrate" & _
            "d Security=True;User Instance=True"
        Me.CONN.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        suppliesinventorytable.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            suppliesinventorytable"
        Me.SqlSelectCommand1.Connection = Me.CONN
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.PictureBox1)
        Me.PanelControl1.Controls.Add(Me.Label12)
        Me.PanelControl1.Controls.Add(Me.Label11)
        Me.PanelControl1.Controls.Add(Me.Label13)
        Me.PanelControl1.Controls.Add(Me.Label10)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(173, 470)
        Me.PanelControl1.TabIndex = 28
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(201, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 300)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "RELEASE"
        '
        'Release
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.ButtonSearchR)
        Me.Controls.Add(Me.ButtonNewR)
        Me.Controls.Add(Me.ButtonDeleteD)
        Me.Controls.Add(Me.ButtonBackR)
        Me.Controls.Add(Me.ButtonEditR)
        Me.Controls.Add(Me.ButtonRefreshR)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Release"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LEND"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ButtonSearchR As System.Windows.Forms.Button
    Friend WithEvents ButtonNewR As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteD As System.Windows.Forms.Button
    Friend WithEvents ButtonBackR As System.Windows.Forms.Button
    Friend WithEvents ButtonEditR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ButtonRefreshR As System.Windows.Forms.Button
    Friend WithEvents ADAPTER As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CONN As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
