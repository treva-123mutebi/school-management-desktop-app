Public Class frmIndividRecord

    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub frmIndividRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        sql = "select piclocation from tblstudentpic where studentID = " & Form1.lblstudentID.Text & ""
        ejbfindthis(sql)
        CheckResult(11)

        ejbselect("select * from tblscore where scheduleID =" & Form1.cboschedid.SelectedValue & " and term ='" & Form1.ComboBox2.Text & "'")
        fillTable(DataGridView1, "t1")



        

    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        ejbselect("SELECT tblstudent.studentID, tblstudent.lname, tblstudent.fname, tblstudent.mname, tblrecords.score_name, tblrecords.score, tblrecords.partial_grade FROM tblrecords INNER JOIN tblstudent ON tblrecords.studentID = tblstudent.studentID where tblstudent.studentID =" & Form1.lblstudentID.Text & " and term ='" & Form1.ComboBox2.Text & "'")
        fillTable(DataGridView2, "r")

        lblScoreid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        lblscorename.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString


    End Sub



    
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If lblscorename.Text = "Label1" Then

            MsgBox("Please select class activity to record or edit")
        Else
            sql = "select * from tblrecords where scoreId=" & lblScoreid.Text & " and studentID =" & Form1.lblstudentID.Text & " and term ='" & Form1.ComboBox2.Text & "'"
            ejbfindthis(sql)
            CheckResult(4)

            ejbselect("SELECT tblstudent.studentID, tblstudent.lname, tblstudent.fname, tblstudent.mname, tblrecords.score_name, tblrecords.score, tblrecords.partial_grade FROM tblrecords INNER JOIN tblstudent ON tblrecords.studentID = tblstudent.studentID where tblstudent.studentID =" & Form1.lblstudentID.Text & " and term ='" & Form1.ComboBox2.Text & "'")
            fillTable(DataGridView2, "r")

            sql = "SELECT tblrecords.studentID, tblrecords.score_name, tblrecords.score, tblScore.score_total, tblScore.score_percentage, tblrecords.term, tblrecords.recordID, tblrecords.scoreID FROM tblrecords INNER JOIN tblScore ON tblrecords.scoreID = tblScore.scoreId WHERE (((tblrecords.studentID)=" & Form1.lblstudentID.Text & ") AND ((tblrecords.term)='" & Form1.ComboBox2.Text & "') AND ((tblrecords.scoreID)=" & lblScoreid.Text & "));"
            ejbfindthis(sql)
            CheckResult(6)

            sql = "select sum (partial_grade) from tblrecords where studentID =" & Form1.lblstudentID.Text & " and term ='" & Form1.ComboBox2.Text & "'"
            ejbfindthis(sql)
            CheckResult(7)



        End If

        TextBox1.Clear()


    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        If lblscorename.Text = "Label1" Or TextBox1.Text = Nothing Then

            MsgBox("Please select class activity to record or edit")
        Else

            ejbupdate("UPDATE tblrecords set score = " & TextBox1.Text & " where scoreID = " & lblScoreid.Text & " and studentID = " & Form1.lblstudentID.Text & "")

            sql = "SELECT tblrecords.studentID, tblrecords.score_name, tblrecords.score, tblScore.score_total, tblScore.score_percentage, tblrecords.term, tblrecords.recordID, tblrecords.scoreID FROM tblrecords INNER JOIN tblScore ON tblrecords.scoreID = tblScore.scoreId WHERE (((tblrecords.studentID)=" & Form1.lblstudentID.Text & ") AND ((tblrecords.term)='" & Form1.ComboBox2.Text & "') AND ((tblrecords.scoreID)=" & lblScoreid.Text & "));"
            ejbfindthis(sql)
            CheckResult(6)

            sql = "select sum (partial_grade) from tblrecords where studentID =" & Form1.lblstudentID.Text & " and term ='" & Form1.ComboBox2.Text & "'"
            ejbfindthis(sql)
            CheckResult(7)




        End If

        TextBox1.Clear()


    End Sub

    
    
    Private Sub btnpresent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpresent.Click

        ejbinsert2("INSERT INTO tblAttendance (studentID, remarks, checkdate, checktime, term)" & _
              " VALUES(" & Form1.lblstudentID.Text & ",'" & btnpresent.Text & "','" & Date.Today & "','" & TimeOfDay & "','" & Form1.ComboBox2.Text & "')")

        Me.Close()

    End Sub

    Private Sub btnabsent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnabsent.Click

        ejbinsert2("INSERT INTO tblAttendance (studentID, remarks, checkdate, checktime, term)" & _
      " VALUES(" & Form1.lblstudentID.Text & ",'" & btnabsent.Text & "','" & Date.Today & "','" & TimeOfDay & "','" & Form1.ComboBox2.Text & "')")


        Me.Close()

    End Sub

    Private Sub btnexcuse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexcuse.Click

        ejbinsert2("INSERT INTO tblAttendance (studentID, remarks, checkdate, checktime, term)" & _
" VALUES(" & Form1.lblstudentID.Text & ",'" & btnexcuse.Text & "','" & Date.Today & "','" & TimeOfDay & "','" & Form1.ComboBox2.Text & "')")


        Me.Close()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        frmAttendance.Show()

    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Dim strfilenam As String

        If OpenFileDialog1.ShowDialog = 1 Then

            PictureBox2.Image = System.Drawing.Image.FromFile(OpenFileDialog1.FileName)
            TextBox2.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)
            'strfilenam = OpenFileDialog1.FileName

            'TextBox2.Text = strfilenam

        End If

    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        sql = "select * from tblstudentpic where studentID = " & Form1.lblstudentID.Text & ""
        ejbfindthis(sql)
        CheckResult(10)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        frmSchedTransfer.Show()
        Me.Close()

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        frmstudent.btnAdd.Enabled = False
        frmstudent.Label5.Text = Form1.Label5.Text

        sql = "select * from tblstudent where studentID = " & Form1.lblstudentID.Text & ""
        ejbfindthis(sql)
        CheckResult(14)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        frmReports.Show()

        frmReports.Button1.Enabled = False
        frmReports.Button2.Enabled = True
        frmReports.Button3.Enabled = True

    End Sub
End Class