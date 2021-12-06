Module ejbsqlstatements

    Dim cmd As New OleDb.OleDbCommand
    Dim da As New OleDb.OleDbDataAdapter

    
    Public Sub ejbfindthis(ByVal sql As String)
        Try
            con.Open()
            With cmd
                .Connection = con
                .CommandText = sql
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
        con.Close()
        da.Dispose()

    End Sub

    Public Sub CheckResult(ByVal var As String)

        Dim table As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(table)


            If table.Rows.Count > 0 Then


                Select Case var

                    Case 1
                        MsgBox("Student Already Exist")
                    Case 2
                        MsgBox("Schedule Already Exist")
                    Case 3

                        Dim percent As Integer

                        percent = table.Rows(0).Item(0) + frmClassAct.txtscorepercent.Text

                        If percent > 100 Then

                            MsgBox("Percentage Allocation Exceed")

                        Else
                            ejbinsert("INSERT INTO tblScore (score_name, score_date, score_time, score_total, score_percentage, schedule, term, scheduleID)" & _
                                  " VALUES('" & frmClassAct.txtscorename.Text & "','" & frmClassAct.lbldate.Text & "','" & frmClassAct.lblclock.Text & "'," & frmClassAct.txttotalscore.Text & "," & frmClassAct.txtscorepercent.Text & ",'" & frmClassAct.Label5.Text & "','" & frmClassAct.ComboBox2.Text & "'," & Form1.cboschedid.SelectedValue & ")")

                        End If


                    Case 4
                        MsgBox("Score Already Recorded")

                    Case 5
                        Dim schedule As String
                        schedule = table.Rows(0).Item(0)
                        Form1.Label5.Text = schedule
                    Case 51
                        Dim schedule As String
                        schedule = table.Rows(0).Item(0)
                        frmSchedTransfer.Label5.Text = schedule
                    Case 6

                        Dim rs0, ts0, ps0, sper As Double
                        Dim r0 As Double

                        rs0 = table.Rows(0).Item(2)
                        ts0 = table.Rows(0).Item(3)
                        ps0 = ts0 / 2

                        sper = table.Rows(0).Item(4)

                        r0 = ((((75 - 100) * (rs0 - ts0)) / (ps0 - ts0)) + 100) * (sper / 100)

                        ejbupdate("UPDATE tblrecords set partial_grade = " & r0 & " where studentID = " & Form1.lblstudentID.Text & " and scoreid = " & frmIndividRecord.lblScoreid.Text & "")

                        'MsgBox("Score Computed")

                    Case 7
                        Dim pg As Double
                        Dim sql As String

                        pg = Math.Round((table.Rows(0).Item(0)), 0)

                        frmIndividRecord.lblgrade.Text = pg

                        If Form1.ComboBox2.Text = "Prelim" Then

                            ejbupdate("UPDATE tblstudent set prelimgrade = " & pg & " where studentID = " & Form1.lblstudentID.Text & "")

                        ElseIf Form1.ComboBox2.Text = "Midterm" Then

                            ejbupdate("UPDATE tblstudent set midtermgrade = " & pg & " where studentID = " & Form1.lblstudentID.Text & "")

                        ElseIf Form1.ComboBox2.Text = "Final" Then

                            ejbupdate("UPDATE tblstudent set finalgrade = " & pg & " where studentID = " & Form1.lblstudentID.Text & "")

                            sql = "Select prelimgrade, midtermgrade, finalgrade from tblstudent where studentID =" & Form1.lblstudentID.Text & ""
                            ejbfindthis(sql)
                            CheckResult(8)


                        End If




                    Case 8
                        Dim fa, pg, mg, fg As Double

                        pg = table.Rows(0).Item(0)
                        mg = table.Rows(0).Item(1)
                        fg = table.Rows(0).Item(2)

                        fa = Math.Round(((pg * 0.3) + (mg * 0.3) + (fg * 0.4)), 0)

                        ejbupdate("UPDATE tblstudent set finalaverage = " & fa & " where studentID = " & Form1.lblstudentID.Text & "")

                        If fa > 74 Then

                            ejbupdate("UPDATE tblstudent set remarks = 'Passed' where studentID = " & Form1.lblstudentID.Text & "")

                        Else
                            ejbupdate("UPDATE tblstudent set remarks = 'Failed' where studentID = " & Form1.lblstudentID.Text & "")

                        End If

                    Case 9
                        Dim monitor As Integer

                        monitor = table.Rows(0).Item(0)

                        frmAttendance.lblcount.Text = monitor

                    Case 10

                        Dim path As String

                        path = table.Rows(0).Item(2)

                        ejbupdate2("UPDATE tblstudentpic SET piclocation='" & frmIndividRecord.TextBox2.Text & "'  where studentID = " & Form1.lblstudentID.Text & "")

                    Case 11
                        Dim path As String

                        path = table.Rows(0).Item(0)

                        ' MsgBox(Application.StartupPath & "\pictures" & "\" & path)
                        frmIndividRecord.PictureBox2.Image = Image.FromFile("" & Application.StartupPath & "\pictures" & "\" & path & "")
                    Case 12
                        Dim st, sd, ss, ssem, sy As String

                        st = table.Rows(0).Item(1)
                        sd = table.Rows(0).Item(2)
                        ss = table.Rows(0).Item(3)
                        ssem = table.Rows(0).Item(4)
                        sy = table.Rows(0).Item(5)

                        frmSchedule.txttime.Text = st
                        frmSchedule.cboday.Text = sd
                        frmSchedule.txtsubject.Text = ss
                        frmSchedule.cbosemester.Text = ssem
                        frmSchedule.cbosy.Text = sy
                    Case 13
                        Dim sn, t As String
                        Dim stot, sp As Double
                        Dim sid As Integer

                        sid = table.Rows(0).Item(0)
                        sn = table.Rows(0).Item(1)
                        stot = table.Rows(0).Item(4)
                        sp = table.Rows(0).Item(5)
                        t = table.Rows(0).Item(7)


                        frmClassAct.lblscoreid.Text = sid
                        frmClassAct.txtscorename.Text = sn
                        frmClassAct.txttotalscore.Text = stot
                        frmClassAct.ComboBox2.Text = t
                        frmClassAct.txtscorepercent.Text = sp

                    Case 14
                        Dim sidno, ln, fn, mi, cy, g As String


                        sidno = table.Rows(0).Item(1)
                        ln = table.Rows(0).Item(2)
                        fn = table.Rows(0).Item(3)
                        mi = table.Rows(0).Item(4)
                        cy = table.Rows(0).Item(5)
                        g = table.Rows(0).Item(6)

                        frmstudent.txtStudIDNo.Text = sidno
                        frmstudent.txtfname.Text = fn
                        frmstudent.txtlname.Text = ln
                        frmstudent.txtmi.Text = mi
                        frmstudent.txtcrsyr.Text = cy
                        frmstudent.cbogender.Text = g

                        frmstudent.Show()

                    Case 15
                        MsgBox("Teacher Already Exist")
                   

                End Select

            Else

                Select var

                    Case 1
                        ejbinsert("INSERT INTO tblstudent (school_idno, lname, fname, mname, course_yr, gender, scheduleID)" & _
                                  " VALUES('" & frmstudent.txtStudIDNo.Text & "','" & frmstudent.txtlname.Text & "','" & frmstudent.txtfname.Text & "','" & frmstudent.txtmi.Text & "','" & _
                                  frmstudent.txtcrsyr.Text & "','" & frmstudent.cbogender.Text & "'," & Form1.cboschedid.SelectedValue & ")")

                        ejbselect("select * from tblstudent where scheduleID =" & Form1.cboschedid.SelectedValue & " order by lname")
                        fillTable(Form1.DataGridView1, "s")

                    Case 2
                        ejbinsert("INSERT INTO tblSchedule (sched_time, sched_day, sched_subject, sched_semester, sy)" & _
                                  " VALUES('" & frmSchedule.txttime.Text & "','" & frmSchedule.cboday.Text & "','" & frmSchedule.txtsubject.Text & "','" & frmSchedule.cbosemester.Text & "','" & frmSchedule.cbosy.Text & "')")
                    Case 3
                        ejbinsert("INSERT INTO tblScore (score_name, score_date, score_time, score_total, score_percentage, schedule, term, scheduleID)" & _
                              " VALUES('" & frmClassAct.txtscorename.Text & "','" & frmClassAct.lbldate.Text & "','" & frmClassAct.lblclock.Text & "'," & frmClassAct.txttotalscore.Text & "," & frmClassAct.txtscorepercent.Text & ",'" & frmClassAct.Label5.Text & "','" & frmClassAct.ComboBox2.Text & "'," & Form1.cboschedid.SelectedValue & ")")
                    Case 4

                        ejbinsert("insert into tblrecords (scoreID, studentID, score, score_name, term, scheduleID) values (" & frmIndividRecord.lblScoreid.Text & "," & Form1.lblstudentID.Text & "," & frmIndividRecord.TextBox1.Text & ",'" & frmIndividRecord.lblscorename.Text & "','" & Form1.ComboBox2.Text & "'," & Form1.cboschedid.SelectedValue & ")")

                    Case 5
                        Form1.Label5.Text = "No schedule for this term."
                    Case 7
                        MsgBox("Grades Not Yet Computed")

                    Case 10

                        Dim path As String

                        path = frmIndividRecord.TextBox2.Text

                        ejbinsert("insert into tblstudentpic (piclocation, studentID) values ('" & path & "'," & Form1.lblstudentID.Text & ")")


                    Case 15
                        ejbinsert("INSERT INTO tblTeachers (EmployeeID, tlname, tfname, tmi, tgender, yrsservice, taddress, grad_prog, specialization, tschool, inclusive_yrs, tstatus)" & _
                                 " VALUES('" & frmTeachers.txtempid.Text & "','" & frmTeachers.txtlname.Text & "','" & frmTeachers.txtfname.Text & "','" & frmTeachers.txtmi.Text & "','" & _
                                 frmTeachers.cbogender.Text & "','" & frmTeachers.txtys.Text & "','" & frmTeachers.txtadd.Text & "','" & frmTeachers.txtgp.Text & "','" & frmTeachers.txtspec.Text & "','" & frmTeachers.txtschool.Text & "','" & frmTeachers.txtiy.Text & "','" & frmTeachers.txtstatus.Text & "')")

                   

                End Select

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

End Module
