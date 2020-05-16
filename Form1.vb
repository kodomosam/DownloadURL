Public Class Form1
    Private Sub cmdDownload_Click(sender As Object, e As EventArgs) Handles cmdDownload.Click
        Dim strOut As String

        Dim web As New DownloadURL()


        web.defineURL1(txtURL.Text)

        web.downloadURL(strOut)

        txtPagina.Text = strOut
    End Sub
End Class
