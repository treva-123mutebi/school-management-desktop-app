Public Class frmSchedule

    Dim sql As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnaddsched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddsched.Click
        Try
            Sql = "select * from tblschedule where sched_time = '" & txttime.Text & "' and sched_day = '" & cboday.Text & "' and sched_subject = '" & txtsubject.Text & "' and sched_semester = '" & cbosemester.Text & "' and sy = '" & cbosy.Text & "'"
            ejbfindthis(Sql)
            CheckResult(2)

            Me.Close()



        Catch ex As Exception

        End Try

        Form1.ComboBox1.Text = Nothing
        Form1.cboschedid.Text = Nothing

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        sql = "select * from tblschedule where scheduleID = " & Form1.cboschedid.SelectedValue & ""
        ejbfindthis(sql)
        CheckResult(12)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ejbupdate2("UPDATE tblschedule SET sched_subject = '" & txtsubject.Text & "', sched_time = '" & txttime.Text & "', sched_day = '" & cboday.Text & "', sched_semester = '" & cbosemester.Text & "', sy = '" & cbosy.Text & "' where scheduleID = " & Form1.cboschedid.SelectedValue & "")

        With Form1
            .ComboBox1.Text = Nothing
            .cboschedid.Text = Nothing
        End With

        Me.Close()


    End Sub
End Class