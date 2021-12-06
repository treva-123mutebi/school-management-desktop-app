Public Class Form1

    Dim sql As String

    Private Sub ComboBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.TextChanged

        ejbselect("select scheduleID, sched_day & ', ' & sched_time & ' ' & sched_subject as partsched from tblschedule where sy = '" & ComboBox1.Text & "'")
        fillcombobox(cboschedid, 1)




    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        visfalse(1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If ComboBox1.Text = Nothing Then
            MsgBox("Please select Academic Year first")
        Else
            sql = "select sched_day & ', ' & sched_time & ' ' & sched_subject & ', ' & sched_semester & ' ' & sy from tblschedule where scheduleID =" & cboschedid.SelectedValue & ""
            ejbfindthis(sql)
            CheckResult(5)

            ejbselect("select * from tblstudent where scheduleID =" & cboschedid.SelectedValue & " order by lname")
            fillTable(DataGridView1, "s")

            vistrue(1)
        End If

    End Sub

    Private Sub btnaddsched_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaddsched.Click
        frmSchedule.Show()
        visfalse(1)
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        lblstudentID.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString


        If ComboBox2.Text = Nothing Then

            MsgBox("Please select term.")
        Else



            With frmIndividRecord

                .lbltitle.Text = "Individual Record ( " & ComboBox2.Text & " ) "
                .Show()
                '.Label7.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
                '.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString & ", " & DataGridView1.CurrentRow.Cells(3).Value.ToString & " " & DataGridView1.CurrentRow.Cells(4).Value.ToString

            End With




            frmIndividRecord.lblstudentname.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString & ", " & DataGridView1.CurrentRow.Cells(3).Value.ToString & " " & DataGridView1.CurrentRow.Cells(4).Value.ToString
            'Form3.Label1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString

        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Hide()
        frmstudent.Show()
        frmstudent.Label5.Text = Label5.Text
        frmstudent.Button3.Enabled = False
    End Sub

    Private Sub btnClassAct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClassAct.Click
        

        If Label5.Text = "Label5" Or ComboBox2.Text = Nothing Then

            MsgBox("Please Select Schedule and Term")

        Else

            frmClassAct.Label5.Text = Label5.Text


            frmClassAct.Show()
            visfalse(1)

        End If

    End Sub

   

  
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If Label5.Text = "Label5" Then
            MsgBox("Please check schedule first")

        Else
            frmReports.Show()
            frmReports.Button2.Enabled = False
            frmReports.Button1.Enabled = True
            frmReports.Button3.Enabled = False



        End If



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button3_Click(sender, e)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        frmTeachers.Show()
        Me.Hide()


    End Sub
End Class
