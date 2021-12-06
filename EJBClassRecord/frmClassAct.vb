Public Class frmClassAct

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form1.Show()
        Me.Close()


    End Sub

    Private Sub btnaddscore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddscore.Click

        Dim sql As String

        Sql = "select sum (score_percentage) from tblScore where schedule ='" & Label5.Text & "' and term ='" & ComboBox2.Text & "'"
        ejbfindthis(Sql)
        CheckResult(3)

        frmClassAct_Load(sender, e)


    End Sub

    Private Sub frmClassAct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Start()

        ejbselect("select * from tblscore where scheduleID =" & Form1.cboschedid.SelectedValue & " and term ='" & Form1.ComboBox2.Text & "'")
        fillTable(DataGridView1, "t1")

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblclock.Text = TimeOfDay
        lbldate.Text = Today

    End Sub

  
    
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ejbupdate2("update tblScore set score_name = '" & txtscorename.Text & "', score_date = '" & lbldate.Text & "', score_time = '" & lblclock.Text & "', score_total = " & txttotalscore.Text & ", score_percentage = " & txtscorepercent.Text & ", term = '" & ComboBox2.Text & "' where scoreID =" & lblscoreid.Text & "")
        Me.Close()


    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim sql As String

        lblscoreid.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Button2.Enabled = True
        btnaddscore.Enabled = False
        Button3.Enabled = True


        sql = "select * from tblscore where scoreID = " & lblScoreid.Text & ""
        ejbfindthis(sql)
        CheckResult(13)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sql As String

        sql = "select sum (score_percentage) from tblScore where schedule ='" & Label5.Text & "' and term ='" & ComboBox2.Text & "'"
        ejbfindthis(sql)
        CheckResult(3)

        frmClassAct_Load(sender, e)


    End Sub
End Class