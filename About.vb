Public Class About
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub SupportLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles SupportLink.LinkClicked
        Process.Start("http://adf.ly/1mVOUd")
    End Sub

    Private Sub YouTube_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YouTube.LinkClicked
        Process.Start("https://www.youtube.com/channel/UCqj5YzRrnAm3w0ozyqkw0bw")
    End Sub

    Private Sub GitHub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles GitHub.LinkClicked
        Process.Start("https://github.com/havenvanheusen")
    End Sub

    Private Sub Reddit_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles Reddit.LinkClicked
        Process.Start("https://www.reddit.com/user/ThatHavenGuy/")
    End Sub
End Class