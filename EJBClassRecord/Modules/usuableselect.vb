Module usuableselect


    Dim cmd As New OleDb.OleDbCommand
    Dim da, dcb As New OleDb.OleDbDataAdapter

    Public Sub cleartext(ByVal group As Object, ByVal clear As String)
        If clear = "cb" Then
            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(ComboBox) Then
                    ctrl.Text = Nothing
                End If
            Next

        ElseIf clear = "txt" Then

            For Each ctrl As Control In group.Controls
                If ctrl.GetType Is GetType(TextBox) Then
                    ctrl.Text = Nothing

                End If
            Next
        End If

        
    End Sub

    Public Sub clearall(ByVal group As Object, ByVal cleardtg As Object)
        For Each ctrl As Control In group.Controls
            If ctrl.GetType Is GetType(TextBox) Then
                ctrl.Text = Nothing
                cleardtg.DataSource = Nothing
            End If
        Next
    End Sub

    Public Sub ejbselect(ByVal sql As String)
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

    Public Sub fillTable(ByVal dtgrd As Object, ByVal design As String)
        Dim publictable As New DataTable

        Try
            da.SelectCommand = cmd
            da.Fill(publictable)
            dtgrd.DataSource = publictable

            If design = "t" Then

                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(5).Visible = False
                dtgrd.Columns(6).Visible = False


            ElseIf design = "s" Then

                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(1).Visible = False
                dtgrd.Columns(12).Visible = False

                dtgrd.Columns(6).Visible = False
                'dtgrd.Columns(7).Visible = False


            ElseIf design = "t1" Then
                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(6).Visible = False
                dtgrd.Columns(7).Visible = False
                dtgrd.Columns(8).Visible = False


            ElseIf design = "r" Then
                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(1).Visible = False
                dtgrd.Columns(2).Visible = False
                dtgrd.Columns(3).Visible = False

            ElseIf design = 1 Then
                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(8).Visible = False
                dtgrd.Columns(9).Visible = False
                dtgrd.Columns(10).Visible = False
                dtgrd.Columns(11).Visible = False
                dtgrd.Columns(12).Visible = False
                dtgrd.Columns(7).width = 300

            ElseIf design = 2 Then
                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(1).Visible = False

                dtgrd.Columns(5).Visible = False

            ElseIf design = 3 Then
                dtgrd.Columns(0).Visible = False
                dtgrd.Columns(5).Visible = False
                dtgrd.Columns(6).Visible = False
                dtgrd.Columns(7).Visible = False
                dtgrd.Columns(9).Visible = False
                dtgrd.Columns(10).Visible = False
                dtgrd.Columns(11).Visible = False
                dtgrd.Columns(12).Visible = False

            End If

            da.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub




    Public Sub fillcombobox(ByVal cb As Object, ByVal design As Integer)

        Dim cbcatgorytbl As New DataTable

        dcb.SelectCommand = cmd

        dcb.Fill(cbcatgorytbl)

        Try

            Select Case design

                Case 1
                    With cb
                        .DataSource = cbcatgorytbl
                        .DisplayMember = "partsched"
                        .ValueMember = "scheduleID"

                    End With

                Case 2
                    With cb
                        .DataSource = cbcatgorytbl
                        .DisplayMember = " "
                        .ValueMember = "schedule"

                    End With

            End Select

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    

End Module
