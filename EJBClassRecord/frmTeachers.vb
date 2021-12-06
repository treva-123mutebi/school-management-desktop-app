Public Class frmTeachers

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click


        Try
            Dim sql As String
           
            sql = "select * from tblTeachers where EmployeeID ='" & txtempid.Text & "'"
            ejbfindthis(Sql)
            CheckResult(15)
            Form1.Show()
            Me.Close()


        Catch ex As Exception

        End Try

    End Sub

    'Private Sub frmTeachers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    ejbselect("select * from tblTeachers where scheduleID =" & Form1.cboschedid.SelectedValue & " order by tlname")
    '    fillTable(DataGridView1, 3)


    'End Sub
End Class