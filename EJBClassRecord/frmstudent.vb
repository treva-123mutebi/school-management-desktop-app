

Public Class frmstudent

    Dim sql As String

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Try

            If Label5.Text = "Label5" Then
                MsgBox("Please Select Student Schedule")
            Else
                sql = "select * from tblstudent where school_idno ='" & txtStudIDNo.Text & "'"
                ejbfindthis(sql)
                CheckResult(1)

                cleartext(GroupBox1, "txt")
                cbogender.Text = Nothing
            End If


        Catch ex As Exception

        End Try

        Form1.Show()
        Me.Close()


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ejbupdate2("update tblstudent set school_idno = '" & txtStudIDNo.Text & "', lname = '" & txtlname.Text & "', fname = '" & txtfname.Text & "', mname = '" & txtmi.Text & "', course_yr = '" & txtcrsyr.Text & "', gender = '" & cbogender.Text & "' where studentId = " & Form1.lblstudentID.Text & "")
        frmIndividRecord.Close()

        Me.Close()

    End Sub


    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = PictureBox1.Height
        Dim iWidth As Integer = PictureBox1.Width
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, PictureBox1.Handle.ToInt32, 0)
        If SendMessage(hHwnd, WM_Cap_Paki_CONNECT, iDevice, 0) Then
            SendMessage(hHwnd, WM_Cap_SET_SCALE, True, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEWRATE, 66, 0)
            SendMessage(hHwnd, WM_Cap_SET_PREVIEW, True, 0)
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureBox1.Width, PictureBox1.Height, SWP_NOMOVE Or SWP_NOZORDER)
        Else
            DestroyWindow(hHwnd)
        End If
    End Sub

    Private Sub ClosePreviewWindow()
        SendMessage(hHwnd, WM_Cap_Paki_DISCONNECT, iDevice, 0)
        DestroyWindow(hHwnd)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Call OpenPreviewWindow()
        ' Shell("C:\Program Files (x86)\ASUS\ASUS LifeFrame3\LifeFrame.exe", AppWinStyle.Hide)



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        Dim Data As IDataObject
        Dim Bmap As Image
        SendMessage(hHwnd, WM_Cap_EDIT_COPY, 0, 0)
        Data = Clipboard.GetDataObject()

        If Data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            Bmap = CType(Data.GetData(GetType(System.Drawing.Bitmap)), Image)
            PictureBox1.Image = Bmap
            ClosePreviewWindow()

        End If



    End Sub




    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        Dim savefiledialog1 As New SaveFileDialog

        savefiledialog1.Title = "save File"
        savefiledialog1.FileName = " *.bmp "
        savefiledialog1.Filter = "Bitmap |*.bmp* "

        If savefiledialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image.Save(savefiledialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp)

        End If

     

    End Sub
End Class