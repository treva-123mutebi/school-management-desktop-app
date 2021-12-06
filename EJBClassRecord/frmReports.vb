Public Class frmReports

    Dim acscmd As New OleDb.OleDbCommand
    Dim acsda As New OleDb.OleDbDataAdapter
    Dim acscon As OleDb.OleDbConnection = myconn()
    Dim acsds As New DataSet
    Dim strsql As String
    Dim strreportname As String

    Public Sub report(ByVal sql As String, ByVal rptname As String)
        acsds = New DataSet
        strsql = sql
        acscmd.CommandText = strsql
        acscmd.Connection = acscon
        acsda.SelectCommand = acscmd
        acsda.Fill(acsds)

        strreportname = rptname
        Dim strreportpath As String = Application.StartupPath & "\reports\" & strreportname & ".rpt"
        If Not IO.File.Exists(strreportpath) Then
            MsgBox("Unable to locate file:" & vbCrLf & strreportpath)

        End If

        Dim reportdoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument

        reportdoc.Load(strreportpath)
        reportdoc.SetDataSource(acsds.Tables(0))

        CrystalReportViewer1.ShowRefreshButton = False
        CrystalReportViewer1.ShowCloseButton = False
        CrystalReportViewer1.ShowGroupTreeButton = False
        CrystalReportViewer1.ReportSource = reportdoc
    End Sub

   

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        report("SELECT tblstudent.*, tblSchedule.* FROM tblSchedule INNER JOIN tblstudent ON tblSchedule.scheduleID = tblstudent.scheduleID where tblSchedule.scheduleID= " & Form1.cboschedid.SelectedValue & "", "GradeSheet")

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        report("SELECT tblstudent.*, tblrecords.* FROM tblrecords INNER JOIN tblstudent ON tblrecords.studentID = tblstudent.studentID WHERE tblstudent.studentID=" & Form1.lblstudentID.Text & "", "NewGradeSheet")


    End Sub

    
   
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        report("SELECT tblstudent.*, tblAttendance.* FROM tblAttendance INNER JOIN tblstudent ON tblAttendance.studentID = tblstudent.studentID WHERE tblstudent.studentID=" & Form1.lblstudentID.Text & " order by tblattendance.remarks", "AttReport")


    End Sub
End Class