Public Class frmAttendance

    Dim sql As String

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        frmIndividRecord.Show()
        Me.Close()

    End Sub

    Private Sub frmAttendance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ejbselect("select * from tblattendance where studentID = " & Form1.lblstudentID.Text & " and term = '" & Form1.ComboBox2.Text & "' order by remarks")
        fillTable(DataGridView1, 2)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = Nothing Then
            MsgBox("Please select remarks to count")
        Else
            sql = "select count (remarks) from tblattendance where studentID = " & Form1.lblstudentID.Text & " and remarks = '" & ComboBox1.Text & "' and term = '" & Form1.ComboBox2.Text & "'"
            ejbfindthis(sql)
            CheckResult(9)

        End If

       

    End Sub
End Class