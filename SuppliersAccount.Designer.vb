<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SuppliersAccount
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.CONN = New System.Data.SqlClient.SqlConnection()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.ADAPTER = New System.Data.SqlClient.SqlDataAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonNewUA = New System.Windows.Forms.Button()
        Me.ButtonDeleteUA = New System.Windows.Forms.Button()
        Me.ButtonEditUA = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ButtonCancelUA = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ButtonBackUA = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        suppliesinventorytable.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            suppliesinventorytable"
        Me.SqlSelectCommand1.Connection = Me.CONN
        '
        'CONN
        '
        Me.CONN.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrate" & _
            "d Security=True;User Instance=True"
        Me.CONN.FireInfoMessageEventOnUserErrors = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(14, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.Size = New System.Drawing.Size(488, 344)
        Me.DataGridView1.TabIndex = 108
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [suppliesinventorytable] ([Item Code], [Item Name], [Quantity], [Stat" & _
            "us], [Item Type], [Supplier]) VALUES (@Item_Code, @Item_Name, @Quantity, @Status" & _
            ", @Item_Type, @Supplier)"
        Me.SqlInsertCommand1.Connection = Me.CONN
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Item_Code", System.Data.SqlDbType.NVarChar, 0, "Item Code"), New System.Data.SqlClient.SqlParameter("@Item_Name", System.Data.SqlDbType.NVarChar, 0, "Item Name"), New System.Data.SqlClient.SqlParameter("@Quantity", System.Data.SqlDbType.NVarChar, 0, "Quantity"), New System.Data.SqlClient.SqlParameter("@Status", System.Data.SqlDbType.NVarChar, 0, "Status"), New System.Data.SqlClient.SqlParameter("@Item_Type", System.Data.SqlDbType.NVarChar, 0, "Item Type"), New System.Data.SqlClient.SqlParameter("@Supplier", System.Data.SqlDbType.NVarChar, 0, "Supplier")})
        '
        'ADAPTER
        '
        Me.ADAPTER.InsertCommand = Me.SqlInsertCommand1
        Me.ADAPTER.SelectCommand = Me.SqlSelectCommand1
        Me.ADAPTER.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "suppliesinventorytable", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Item Code", "Item Code"), New System.Data.Common.DataColumnMapping("Item Name", "Item Name"), New System.Data.Common.DataColumnMapping("Quantity", "Quantity"), New System.Data.Common.DataColumnMapping("Status", "Status"), New System.Data.Common.DataColumnMapping("Item Type", "Item Type"), New System.Data.Common.DataColumnMapping("Supplier", "Supplier")})})
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ButtonNewUA)
        Me.GroupBox1.Controls.Add(Me.ButtonDeleteUA)
        Me.GroupBox1.Controls.Add(Me.ButtonEditUA)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ButtonCancelUA)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ButtonBackUA)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(893, 377)
        Me.GroupBox1.TabIndex = 126
        Me.GroupBox1.TabStop = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(625, 193)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(258, 26)
        Me.TextBox5.TabIndex = 135
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(625, 127)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(258, 26)
        Me.TextBox3.TabIndex = 134
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(625, 160)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(258, 26)
        Me.TextBox4.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(565, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 18)
        Me.Label2.TabIndex = 132
        Me.Label2.Text = "Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(625, 94)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 26)
        Me.TextBox2.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(528, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Record No:"
        '
        'ButtonNewUA
        '
        Me.ButtonNewUA.BackColor = System.Drawing.Color.DimGray
        Me.ButtonNewUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonNewUA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonNewUA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNewUA.ForeColor = System.Drawing.Color.White
        Me.ButtonNewUA.Location = New System.Drawing.Point(550, 234)
        Me.ButtonNewUA.Name = "ButtonNewUA"
        Me.ButtonNewUA.Size = New System.Drawing.Size(96, 43)
        Me.ButtonNewUA.TabIndex = 126
        Me.ButtonNewUA.Text = "NEW ACCOUNT"
        Me.ButtonNewUA.UseVisualStyleBackColor = False
        '
        'ButtonDeleteUA
        '
        Me.ButtonDeleteUA.BackColor = System.Drawing.Color.DimGray
        Me.ButtonDeleteUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonDeleteUA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonDeleteUA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDeleteUA.ForeColor = System.Drawing.Color.White
        Me.ButtonDeleteUA.Location = New System.Drawing.Point(788, 231)
        Me.ButtonDeleteUA.Name = "ButtonDeleteUA"
        Me.ButtonDeleteUA.Size = New System.Drawing.Size(96, 43)
        Me.ButtonDeleteUA.TabIndex = 128
        Me.ButtonDeleteUA.Text = "DELETE"
        Me.ButtonDeleteUA.UseVisualStyleBackColor = False
        '
        'ButtonEditUA
        '
        Me.ButtonEditUA.BackColor = System.Drawing.Color.DimGray
        Me.ButtonEditUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonEditUA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEditUA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEditUA.ForeColor = System.Drawing.Color.White
        Me.ButtonEditUA.Location = New System.Drawing.Point(671, 234)
        Me.ButtonEditUA.Name = "ButtonEditUA"
        Me.ButtonEditUA.Size = New System.Drawing.Size(96, 43)
        Me.ButtonEditUA.TabIndex = 127
        Me.ButtonEditUA.Text = "EDIT"
        Me.ButtonEditUA.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(625, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 26)
        Me.TextBox1.TabIndex = 142
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(625, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 18)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "0"
        '
        'ButtonCancelUA
        '
        Me.ButtonCancelUA.BackColor = System.Drawing.Color.DimGray
        Me.ButtonCancelUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonCancelUA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCancelUA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancelUA.ForeColor = System.Drawing.Color.White
        Me.ButtonCancelUA.Location = New System.Drawing.Point(626, 283)
        Me.ButtonCancelUA.Name = "ButtonCancelUA"
        Me.ButtonCancelUA.Size = New System.Drawing.Size(96, 43)
        Me.ButtonCancelUA.TabIndex = 140
        Me.ButtonCancelUA.Text = "CANCEL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ButtonCancelUA.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(546, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 18)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(505, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 18)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Email Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(511, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 18)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Cellphone No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(540, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 18)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Company:"
        '
        'ButtonBackUA
        '
        Me.ButtonBackUA.BackColor = System.Drawing.Color.DimGray
        Me.ButtonBackUA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButtonBackUA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBackUA.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBackUA.ForeColor = System.Drawing.Color.White
        Me.ButtonBackUA.Location = New System.Drawing.Point(742, 280)
        Me.ButtonBackUA.Name = "ButtonBackUA"
        Me.ButtonBackUA.Size = New System.Drawing.Size(96, 43)
        Me.ButtonBackUA.TabIndex = 129
        Me.ButtonBackUA.Text = "BACK"
        Me.ButtonBackUA.UseVisualStyleBackColor = False
        '
        'SuppliersAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 397)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SuppliersAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "XtraForm9"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents CONN As System.Data.SqlClient.SqlConnection
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents ADAPTER As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonNewUA As System.Windows.Forms.Button
    Friend WithEvents ButtonDeleteUA As System.Windows.Forms.Button
    Friend WithEvents ButtonEditUA As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ButtonCancelUA As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonBackUA As System.Windows.Forms.Button
End Class
