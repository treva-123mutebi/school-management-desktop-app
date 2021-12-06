Module Visible

    Public Sub visfalse(ByVal design As String)

        Select Case design

            Case 1
                With Form1
                    .Label5.Hide()
                    .DataGridView1.Hide()
                    .Button5.Hide()
                    .Label8.Hide()
                    .ComboBox2.Hide()

                End With

        End Select

    End Sub
    Public Sub vistrue(ByVal design As String)

        Select Case design

            Case 1
                With Form1
                    .Label5.Show()
                    .DataGridView1.Show()
                    .Button5.Show()
                    .Label8.Show()
                    .ComboBox2.Show()

                End With
            Case 2
                
        End Select

    End Sub

End Module
