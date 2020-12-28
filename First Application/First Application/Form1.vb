Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btOne.Click
        Dim s As String
        s = tbOne.Text
        MessageBox.Show(s)
        btOne.Text = s



    End Sub
End Class
