Public Class video
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        principal.Show()
        Me.Hide()

    End Sub

    Private Sub AxWindowsMediaPlayer1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        WebBrowser1.Navigate("https://youtu.be/6aV9FWuDQ8Q")
        Height = 816
        Width = 489


    End Sub


End Class