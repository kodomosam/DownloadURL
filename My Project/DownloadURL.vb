Imports System
Imports System.Text
Imports System.IO
Imports System.Net

Public Class DownloadURL
    Private m_strURL As String

    Public Sub defineURL1(ByVal strURL As String)
        m_strURL = strURL
    End Sub
    Public Sub downloadURL(ByRef strConteudo As String)

        Dim req As WebRequest = WebRequest.Create(m_strURL)
        Dim res As WebResponse = req.GetResponse()
        Dim iTotalBuffer As Integer = 0
        Dim Buffer(128) As [Byte]
        Dim stream As Stream = res.GetResponseStream()

        iTotalBuffer = stream.Read(Buffer, 0, 128)
        Dim strRes As New StringBuilder("")

        While iTotalBuffer <> 0
            strRes.Append(Encoding.ASCII.GetString(Buffer, 0, iTotalBuffer))
            iTotalBuffer = stream.Read(Buffer, 0, 128)
        End While

        strConteudo = strRes.ToString()

    End Sub
End Class
