Public Class Disclaimer
    Private Sub Disclaimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        If DontShow.Checked Then
            My.Settings.DisclaimerSetting = True
            My.Settings.Save()
        End If
        Me.Close()
    End Sub

    Private Sub QuitButton_Click(sender As Object, e As EventArgs) Handles QuitButton.Click
        My.Forms.RAMDiskCopy2.Close()
    End Sub
End Class