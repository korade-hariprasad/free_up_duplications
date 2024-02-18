Public Class main

    Dim path, tmp, xten, todel As String
    Dim fileEntries As String()
    Dim original, duplicate, names, attrs, md5s As New List(Of String)

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbPath.Text = "E:\Test"
        tbxten.Text = ".bmp"
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click

        '''''''''''''''''''''''''''''TEST HERE               
        'If IO.Directory.Exists(tbPath.Text.ToString) = False Or tbxten.Text.ToString = "" Then
        '    MsgBox("invalid path or extension")
        'Else
        '    path = tbPath.Text.ToString
        '    fileEntries = IO.Directory.GetFiles(path)
        '    For Each f In fileEntries
        '        Dim tmpfile As New IO.FileInfo(f)
        '        MsgBox(f + " " + tmpfile.Length.ToString)
        '    Next
        'End If
        '''''''''''''''''''''''''''''''''''''''''''''''working codde start
        If IO.Directory.Exists(tbPath.Text.ToString) = False Or tbxten.Text.ToString = "" Then
            MsgBox("invalid path or extension")
        Else
            ''''''''''''''''''''''''''''''''''''''main here'''''''''''''''''''''''
            path = tbPath.Text.ToString
            xten = tbxten.Text.ToString
            fileEntries = IO.Directory.GetFiles(path, "*" + xten)
            For Each f In fileEntries
                tmp = IO.Path.GetFileNameWithoutExtension(f)
                names.Add(tmp)
            Next
            'For Each name As String In namestmp
            '    'MsgBox("Before : " + name + " " + name.Length.ToString)
            '    names.Add(name.Replace(xten, ""))
            '    'MsgBox("After : " + name + " " + name.Length.ToString)
            'Next
            For Each n1 In names
                For Each n2 In names
                    'MsgBox("Comparing " + n1 + " with " + n2)
                    If n2.Contains(n1) And n2.Length <> n1.Length Then
                        Dim t1 As String = path + "\" + n1 + xten
                        Dim t2 As String = path + "\" + n2 + xten
                        Dim tmpfile1 As New IO.FileInfo(t1)
                        Dim tmpfile2 As New IO.FileInfo(t2)
                        'MsgBox(t1 + " " + t2 + " " + tmpfile1.Length.ToString + " " + tmpfile2.Length.ToString)
                        If tmpfile1.Length = tmpfile2.Length Then
                            duplicate.Add(n2)
                        End If
                        'MsgBox(n2 + " added to duplicate")
                    End If
                Next
            Next
            If duplicate.Count = 0 Then
                MsgBox("No Duplicates Found !!")
            Else
                For Each du In duplicate
                    todel = path + "\" + du + xten
                    Try
                        My.Computer.FileSystem.DeleteFile(todel, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                    Catch

                    End Try
                Next
                MsgBox("Deleted all duplicates")
            End If
        End If
        '''''''''''''''''''''''''''''''''''''''''''''''working codde end
    End Sub
End Class
