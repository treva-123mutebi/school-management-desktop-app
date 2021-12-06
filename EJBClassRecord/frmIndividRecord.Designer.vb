<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndividRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblstudentname = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.lblgrade = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.lblScoreid = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Button8 = New System.Windows.Forms.Button
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.btnexcuse = New System.Windows.Forms.Button
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.btnabsent = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnpresent = New System.Windows.Forms.Button
        Me.lbltitle = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.lblscorename = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.lblname = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.Button9 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblstudentname
        '
        Me.lblstudentname.AutoSize = True
        Me.lblstudentname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstudentname.Location = New System.Drawing.Point(15, 8)
        Me.lblstudentname.Name = "lblstudentname"
        Me.lblstudentname.Size = New System.Drawing.Size(83, 25)
        Me.lblstudentname.TabIndex = 1
        Me.lblstudentname.Text = "Label1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button11)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.lblgrade)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.lblScoreid)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.lblstudentname)
        Me.Panel1.Location = New System.Drawing.Point(20, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(977, 258)
        Me.Panel1.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.EJBClassRecord.My.Resources.Resources._128_Student_1
        Me.PictureBox2.Location = New System.Drawing.Point(20, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(217, 188)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(245, 74)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(119, 23)
        Me.Button11.TabIndex = 45
        Me.Button11.Text = "Edit Information"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(245, 210)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(116, 23)
        Me.Button6.TabIndex = 44
        Me.Button6.Text = "Save Picture"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(245, 181)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 23)
        Me.Button4.TabIndex = 42
        Me.Button4.Text = "Upload Picture"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'lblgrade
        '
        Me.lblgrade.AutoSize = True
        Me.lblgrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrade.ForeColor = System.Drawing.Color.Blue
        Me.lblgrade.Location = New System.Drawing.Point(248, 116)
        Me.lblgrade.Name = "lblgrade"
        Me.lblgrade.Size = New System.Drawing.Size(134, 55)
        Me.lblgrade.TabIndex = 41
        Me.lblgrade.Text = "GRD"
        Me.lblgrade.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(245, 45)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(119, 23)
        Me.Button7.TabIndex = 11
        Me.Button7.Text = "Transfer Schedule"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(41, 196)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(138, 20)
        Me.TextBox2.TabIndex = 43
        '
        'lblScoreid
        '
        Me.lblScoreid.AutoSize = True
        Me.lblScoreid.Location = New System.Drawing.Point(38, 66)
        Me.lblScoreid.Name = "lblScoreid"
        Me.lblScoreid.Size = New System.Drawing.Size(39, 13)
        Me.lblScoreid.TabIndex = 39
        Me.lblScoreid.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(866, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Class Activities"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(386, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(560, 200)
        Me.DataGridView1.TabIndex = 2
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Black
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button8.Location = New System.Drawing.Point(20, 183)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(268, 23)
        Me.Button8.TabIndex = 10
        Me.Button8.Text = "Show Record"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.EJBClassRecord.My.Resources.Resources.Absent_blue
        Me.PictureBox3.Location = New System.Drawing.Point(20, 123)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 53)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 9
        Me.PictureBox3.TabStop = False
        '
        'btnexcuse
        '
        Me.btnexcuse.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexcuse.ForeColor = System.Drawing.Color.Fuchsia
        Me.btnexcuse.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnexcuse.Location = New System.Drawing.Point(100, 123)
        Me.btnexcuse.Name = "btnexcuse"
        Me.btnexcuse.Size = New System.Drawing.Size(188, 53)
        Me.btnexcuse.TabIndex = 8
        Me.btnexcuse.Text = "Excuse"
        Me.btnexcuse.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.EJBClassRecord.My.Resources.Resources.Bloque
        Me.PictureBox4.Location = New System.Drawing.Point(20, 64)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(74, 53)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'btnabsent
        '
        Me.btnabsent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnabsent.ForeColor = System.Drawing.Color.Red
        Me.btnabsent.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnabsent.Location = New System.Drawing.Point(100, 64)
        Me.btnabsent.Name = "btnabsent"
        Me.btnabsent.Size = New System.Drawing.Size(188, 53)
        Me.btnabsent.TabIndex = 6
        Me.btnabsent.Text = "Absent"
        Me.btnabsent.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EJBClassRecord.My.Resources.Resources.attendance_list_icon
        Me.PictureBox1.Location = New System.Drawing.Point(20, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'btnpresent
        '
        Me.btnpresent.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpresent.ForeColor = System.Drawing.Color.Blue
        Me.btnpresent.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnpresent.Location = New System.Drawing.Point(100, 5)
        Me.btnpresent.Name = "btnpresent"
        Me.btnpresent.Size = New System.Drawing.Size(188, 53)
        Me.btnpresent.TabIndex = 4
        Me.btnpresent.Text = "Present"
        Me.btnpresent.UseVisualStyleBackColor = True
        '
        'lbltitle
        '
        Me.lbltitle.AutoSize = True
        Me.lbltitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltitle.ForeColor = System.Drawing.Color.Yellow
        Me.lbltitle.Location = New System.Drawing.Point(23, 25)
        Me.lbltitle.Name = "lbltitle"
        Me.lbltitle.Size = New System.Drawing.Size(217, 29)
        Me.lbltitle.TabIndex = 2
        Me.lbltitle.Text = "Individual Record"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupBox5)
        Me.Panel2.Controls.Add(Me.btnexcuse)
        Me.Panel2.Controls.Add(Me.btnpresent)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.btnabsent)
        Me.Panel2.Controls.Add(Me.Button8)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(20, 333)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(977, 210)
        Me.Panel2.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.lblscorename)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Button2)
        Me.GroupBox5.Controls.Add(Me.lblname)
        Me.GroupBox5.Controls.Add(Me.Button3)
        Me.GroupBox5.Location = New System.Drawing.Point(761, 10)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(204, 190)
        Me.GroupBox5.TabIndex = 38
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Record Student Score"
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(46, 151)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(77, 29)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Edit"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'lblscorename
        '
        Me.lblscorename.AutoSize = True
        Me.lblscorename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblscorename.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblscorename.Location = New System.Drawing.Point(19, 28)
        Me.lblscorename.Name = "lblscorename"
        Me.lblscorename.Size = New System.Drawing.Size(57, 20)
        Me.lblscorename.TabIndex = 40
        Me.lblscorename.Text = "Label1"
        Me.lblscorename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(95, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(90, 47)
        Me.TextBox1.TabIndex = 32
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.Color.Maroon
        Me.Button2.Location = New System.Drawing.Point(556, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblname.Location = New System.Drawing.Point(11, 71)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(77, 24)
        Me.lblname.TabIndex = 24
        Me.lblname.Text = "Score :"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(126, 151)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 29)
        Me.Button3.TabIndex = 38
        Me.Button3.Text = "Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(294, 10)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(458, 190)
        Me.DataGridView2.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EJBClassRecord.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(949, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 43)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(796, 37)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(142, 23)
        Me.Button9.TabIndex = 46
        Me.Button9.Text = "Print Report Card"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'frmIndividRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1019, 555)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIndividRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIndividRecord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblstudentname As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblScoreid As System.Windows.Forms.Label
    Friend WithEvents lblscorename As System.Windows.Forms.Label
    Friend WithEvents lblgrade As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnpresent As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents btnexcuse As System.Windows.Forms.Button
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents btnabsent As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
