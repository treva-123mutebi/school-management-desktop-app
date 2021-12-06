<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchedule
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cbosy = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnaddsched = New System.Windows.Forms.Button
        Me.txtsubject = New System.Windows.Forms.TextBox
        Me.lblsubject = New System.Windows.Forms.Label
        Me.cbosemester = New System.Windows.Forms.ComboBox
        Me.lblsemester = New System.Windows.Forms.Label
        Me.txttime = New System.Windows.Forms.TextBox
        Me.lbltime = New System.Windows.Forms.Label
        Me.cboday = New System.Windows.Forms.ComboBox
        Me.lblday = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.cbosy)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnaddsched)
        Me.GroupBox3.Controls.Add(Me.txtsubject)
        Me.GroupBox3.Controls.Add(Me.lblsubject)
        Me.GroupBox3.Controls.Add(Me.cbosemester)
        Me.GroupBox3.Controls.Add(Me.lblsemester)
        Me.GroupBox3.Controls.Add(Me.txttime)
        Me.GroupBox3.Controls.Add(Me.lbltime)
        Me.GroupBox3.Controls.Add(Me.cboday)
        Me.GroupBox3.Controls.Add(Me.lblday)
        Me.GroupBox3.Location = New System.Drawing.Point(294, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(548, 234)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Schedule"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(292, 153)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 34)
        Me.Button3.TabIndex = 23
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(292, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 34)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'cbosy
        '
        Me.cbosy.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosy.FormattingEnabled = True
        Me.cbosy.Items.AddRange(New Object() {"2013-2014", "2014-2015", "2015-2016", "2016-2017", "2017-2018"})
        Me.cbosy.Location = New System.Drawing.Point(335, 50)
        Me.cbosy.Name = "cbosy"
        Me.cbosy.Size = New System.Drawing.Size(132, 28)
        Me.cbosy.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(332, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Academic Year"
        '
        'btnaddsched
        '
        Me.btnaddsched.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddsched.ForeColor = System.Drawing.Color.Black
        Me.btnaddsched.Location = New System.Drawing.Point(438, 184)
        Me.btnaddsched.Name = "btnaddsched"
        Me.btnaddsched.Size = New System.Drawing.Size(95, 35)
        Me.btnaddsched.TabIndex = 4
        Me.btnaddsched.Text = "Add"
        Me.btnaddsched.UseVisualStyleBackColor = True
        '
        'txtsubject
        '
        Me.txtsubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsubject.Location = New System.Drawing.Point(36, 175)
        Me.txtsubject.Name = "txtsubject"
        Me.txtsubject.Size = New System.Drawing.Size(238, 26)
        Me.txtsubject.TabIndex = 18
        '
        'lblsubject
        '
        Me.lblsubject.AutoSize = True
        Me.lblsubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsubject.ForeColor = System.Drawing.Color.Blue
        Me.lblsubject.Location = New System.Drawing.Point(40, 149)
        Me.lblsubject.Name = "lblsubject"
        Me.lblsubject.Size = New System.Drawing.Size(63, 20)
        Me.lblsubject.TabIndex = 19
        Me.lblsubject.Text = "Subject"
        '
        'cbosemester
        '
        Me.cbosemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosemester.FormattingEnabled = True
        Me.cbosemester.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.cbosemester.Location = New System.Drawing.Point(165, 50)
        Me.cbosemester.Name = "cbosemester"
        Me.cbosemester.Size = New System.Drawing.Size(164, 28)
        Me.cbosemester.TabIndex = 17
        '
        'lblsemester
        '
        Me.lblsemester.AutoSize = True
        Me.lblsemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsemester.ForeColor = System.Drawing.Color.Blue
        Me.lblsemester.Location = New System.Drawing.Point(162, 27)
        Me.lblsemester.Name = "lblsemester"
        Me.lblsemester.Size = New System.Drawing.Size(78, 20)
        Me.lblsemester.TabIndex = 16
        Me.lblsemester.Text = "Semester"
        '
        'txttime
        '
        Me.txttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttime.Location = New System.Drawing.Point(36, 117)
        Me.txttime.Name = "txttime"
        Me.txttime.Size = New System.Drawing.Size(238, 26)
        Me.txttime.TabIndex = 13
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.ForeColor = System.Drawing.Color.Blue
        Me.lbltime.Location = New System.Drawing.Point(39, 94)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(43, 20)
        Me.lbltime.TabIndex = 15
        Me.lbltime.Text = "Time"
        '
        'cboday
        '
        Me.cboday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboday.FormattingEnabled = True
        Me.cboday.Items.AddRange(New Object() {"MWF", "TTH"})
        Me.cboday.Location = New System.Drawing.Point(36, 50)
        Me.cboday.Name = "cboday"
        Me.cboday.Size = New System.Drawing.Size(116, 28)
        Me.cboday.TabIndex = 14
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblday.ForeColor = System.Drawing.Color.Blue
        Me.lblday.Location = New System.Drawing.Point(32, 27)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(37, 20)
        Me.lblday.TabIndex = 13
        Me.lblday.Text = "Day"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.EJBClassRecord.My.Resources.Resources.close
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Maroon
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button1.Location = New System.Drawing.Point(799, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 43)
        Me.Button1.TabIndex = 49
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.EJBClassRecord.My.Resources.Resources.Schedule_icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(271, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 301)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSchedule"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbosy As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnaddsched As System.Windows.Forms.Button
    Friend WithEvents txtsubject As System.Windows.Forms.TextBox
    Friend WithEvents lblsubject As System.Windows.Forms.Label
    Friend WithEvents cbosemester As System.Windows.Forms.ComboBox
    Friend WithEvents lblsemester As System.Windows.Forms.Label
    Friend WithEvents txttime As System.Windows.Forms.TextBox
    Friend WithEvents lbltime As System.Windows.Forms.Label
    Friend WithEvents cboday As System.Windows.Forms.ComboBox
    Friend WithEvents lblday As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
