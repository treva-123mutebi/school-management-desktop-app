<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmstudent
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStudIDNo = New System.Windows.Forms.TextBox
        Me.cbogender = New System.Windows.Forms.ComboBox
        Me.lblgender = New System.Windows.Forms.Label
        Me.lblcrsyr = New System.Windows.Forms.Label
        Me.txtcrsyr = New System.Windows.Forms.TextBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.lblmi = New System.Windows.Forms.Label
        Me.txtmi = New System.Windows.Forms.TextBox
        Me.lblfname = New System.Windows.Forms.Label
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.lbllname = New System.Windows.Forms.Label
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtStudIDNo)
        Me.GroupBox1.Controls.Add(Me.cbogender)
        Me.GroupBox1.Controls.Add(Me.lblgender)
        Me.GroupBox1.Controls.Add(Me.lblcrsyr)
        Me.GroupBox1.Controls.Add(Me.txtcrsyr)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.lblmi)
        Me.GroupBox1.Controls.Add(Me.txtmi)
        Me.GroupBox1.Controls.Add(Me.lblfname)
        Me.GroupBox1.Controls.Add(Me.txtfname)
        Me.GroupBox1.Controls.Add(Me.lbllname)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(437, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 215)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Student"
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(298, 169)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 29)
        Me.Button3.TabIndex = 49
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(340, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 24)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Label5"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(51, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Student ID No."
        '
        'txtStudIDNo
        '
        Me.txtStudIDNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudIDNo.Location = New System.Drawing.Point(49, 110)
        Me.txtStudIDNo.Name = "txtStudIDNo"
        Me.txtStudIDNo.Size = New System.Drawing.Size(196, 26)
        Me.txtStudIDNo.TabIndex = 11
        '
        'cbogender
        '
        Me.cbogender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbogender.FormattingEnabled = True
        Me.cbogender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cbogender.Location = New System.Drawing.Point(49, 169)
        Me.cbogender.Name = "cbogender"
        Me.cbogender.Size = New System.Drawing.Size(111, 28)
        Me.cbogender.TabIndex = 10
        '
        'lblgender
        '
        Me.lblgender.AutoSize = True
        Me.lblgender.ForeColor = System.Drawing.Color.Blue
        Me.lblgender.Location = New System.Drawing.Point(52, 143)
        Me.lblgender.Name = "lblgender"
        Me.lblgender.Size = New System.Drawing.Size(63, 20)
        Me.lblgender.TabIndex = 9
        Me.lblgender.Text = "Gender"
        '
        'lblcrsyr
        '
        Me.lblcrsyr.AutoSize = True
        Me.lblcrsyr.ForeColor = System.Drawing.Color.Blue
        Me.lblcrsyr.Location = New System.Drawing.Point(258, 84)
        Me.lblcrsyr.Name = "lblcrsyr"
        Me.lblcrsyr.Size = New System.Drawing.Size(88, 20)
        Me.lblcrsyr.TabIndex = 7
        Me.lblcrsyr.Text = "Course / Yr"
        '
        'txtcrsyr
        '
        Me.txtcrsyr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcrsyr.Location = New System.Drawing.Point(256, 110)
        Me.txtcrsyr.Name = "txtcrsyr"
        Me.txtcrsyr.Size = New System.Drawing.Size(166, 26)
        Me.txtcrsyr.TabIndex = 6
        '
        'btnAdd
        '
        Me.btnAdd.ForeColor = System.Drawing.Color.Maroon
        Me.btnAdd.Location = New System.Drawing.Point(396, 168)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 29)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblmi
        '
        Me.lblmi.AutoSize = True
        Me.lblmi.ForeColor = System.Drawing.Color.Blue
        Me.lblmi.Location = New System.Drawing.Point(392, 28)
        Me.lblmi.Name = "lblmi"
        Me.lblmi.Size = New System.Drawing.Size(27, 20)
        Me.lblmi.TabIndex = 5
        Me.lblmi.Text = "MI"
        '
        'txtmi
        '
        Me.txtmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmi.Location = New System.Drawing.Point(389, 53)
        Me.txtmi.Name = "txtmi"
        Me.txtmi.Size = New System.Drawing.Size(48, 26)
        Me.txtmi.TabIndex = 4
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.ForeColor = System.Drawing.Color.Blue
        Me.lblfname.Location = New System.Drawing.Point(219, 27)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(86, 20)
        Me.lblfname.TabIndex = 3
        Me.lblfname.Text = "First Name"
        '
        'txtfname
        '
        Me.txtfname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfname.Location = New System.Drawing.Point(217, 53)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(166, 26)
        Me.txtfname.TabIndex = 2
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.ForeColor = System.Drawing.Color.Blue
        Me.lbllname.Location = New System.Drawing.Point(47, 28)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(86, 20)
        Me.lbllname.TabIndex = 1
        Me.lbllname.Text = "Last Name"
        '
        'txtlname
        '
        Me.txtlname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlname.Location = New System.Drawing.Point(45, 53)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(166, 26)
        Me.txtlname.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EJBClassRecord.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(898, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 43)
        Me.Button1.TabIndex = 51
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EJBClassRecord.My.Resources.Resources.student_icon
        Me.PictureBox1.Location = New System.Drawing.Point(11, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(301, 285)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(321, 75)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 28)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Camera"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(321, 216)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(91, 28)
        Me.Button4.TabIndex = 54
        Me.Button4.Text = "Capture"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(321, 251)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(91, 28)
        Me.Button5.TabIndex = 55
        Me.Button5.Text = "Save"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmstudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(953, 306)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmstudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmstudent"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStudIDNo As System.Windows.Forms.TextBox
    Friend WithEvents cbogender As System.Windows.Forms.ComboBox
    Friend WithEvents lblgender As System.Windows.Forms.Label
    Friend WithEvents lblcrsyr As System.Windows.Forms.Label
    Friend WithEvents txtcrsyr As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents lblmi As System.Windows.Forms.Label
    Friend WithEvents txtmi As System.Windows.Forms.TextBox
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
