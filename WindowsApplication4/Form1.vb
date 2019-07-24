Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SaveFileBtn.Click
        If LinkFile.Text <> "" And PathFile.Text <> "" And NameFile.Text <> "" Then
            Try

                WebClient.DownloadFile(LinkFile.Text, PathFile.Text)
                MsgBox("File is downloaded", MsgBoxStyle.Information)


            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Error")
            End Try
        End If


    End Sub

    Private Sub OpenFolderBtn_Click(sender As Object, e As EventArgs) Handles OpenFolderBtn.Click
        If NameFile.Text <> "" And SliderEx.Text <> "" Then
            If FolderBrowserDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                PathFile.Text = FolderBrowserDialog.SelectedPath & "\" & NameFile.Text & "." & SliderEx.Text
            End If
        End If

    End Sub

    Private Sub SliderEx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SliderEx.SelectedIndexChanged
        SliderEx.Text = SliderEx.SelectedItem
    End Sub

    Private Sub WebClient_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles WebClient.DownloadFileCompleted

    End Sub

End Class
