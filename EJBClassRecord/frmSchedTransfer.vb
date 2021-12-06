Public Class frmSchedTransfer

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged
        ejbselect("select scheduleID, sched_day & ', ' & sched_time & ' ' & sched_subject as partsched from tblschedule where sy = '" & ComboBox1.Text & "'")
        fillcombobox(cboschedid, 1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim sql As String

        If ComboBox1.Text = Nothing Then
            MsgBox("Please select Academic Year first")
        Else
            Sql = "select sched_day & ', ' & sched_time & ' ' & sched_subject & ', ' & sched_semester & ' ' & sy from tblschedule where scheduleID =" & cboschedid.SelectedValue & ""
            ejbfindthis(Sql)
            CheckResult(51)


        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ejbupdate2("update tblstudent set scheduleID = " & cboschedid.SelectedValue & " where studentID = " & Form1.lblstudentID.Text & "")
        Me.Close()


    End Sub
End Class