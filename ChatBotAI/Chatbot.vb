Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Text

Imports System.Web.UI.WebControls

Public Class Chatbot
    Dim OPENAI_API_KEY = "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"

    Function callOpenAi(sQuestion As String, iMaxTokens As Integer, dTemperature As Double, sModel As String, top_p As Integer, frequency_penalty As Double, presence_penalty As Double)
        System.Net.ServicePointManager.SecurityProtocol =
        System.Net.SecurityProtocolType.Ssl3 Or
        System.Net.SecurityProtocolType.Tls12 Or
        System.Net.SecurityProtocolType.Tls11 Or
        System.Net.SecurityProtocolType.Tls
        Dim apiEndpoint As String = "https://api.openai.com/v1/completions"
        Dim request As HttpWebRequest = WebRequest.Create(apiEndpoint)
        request.Method = "POST"
        request.ContentType = "application/json"
        request.Headers.Add("Authorization", "Bearer " & OPENAI_API_KEY)

        Dim data As String = "{"
        data += " ""model"":""" & sModel & ""","
        data += " ""prompt"": """ & cleanString(sQuestion) & ""","
        data += " ""max_tokens"": " & iMaxTokens & ","
        data += " ""temperature"": " & dTemperature & ", "
        data += " ""top_p"": " & top_p & ", "
        data += " ""frequency_penalty"": " & frequency_penalty & ", "
        data += " ""presence_penalty"": " & presence_penalty & ", "
        data += " ""stop"": ["" Human:"", "" AI:""]"
        data += "}"


        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(data)
            streamWriter.Flush()
            streamWriter.Close()
        End Using

        Dim response As HttpWebResponse = Nothing
        Dim sResponse As String = ""

        Try
            response = request.GetResponse()
            Dim streamReader As New StreamReader(response.GetResponseStream())
            Dim sJson As String = streamReader.ReadToEnd()
            'add reference System.Web.Extensions
            Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
            Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
            sResponse = oJson("choices")(0)("text")
        Catch ex As WebException
            Dim errorResponse As HttpWebResponse = DirectCast(ex.Response, HttpWebResponse)
            If errorResponse.StatusCode = HttpStatusCode.BadRequest Then
                ' Menghandle respon dengan kode status 400 Bad Request
                sResponse = "Terjadi kesalahan dalam permintaan."
            Else
                ' Menghandle respon dengan kode status lain
                sResponse = "Terjadi kesalahan dalam komunikasi dengan Api."
            End If
        Catch ex As Exception
            ' Menghandle exception umum
            sResponse = "Terjadi kesalahan dalam pemrosesan."
        Finally
            If response IsNot Nothing Then
                response.Close()
            End If
        End Try

        Return sResponse

    End Function
    Private Function cleanString(ByVal s As String) As String
        If s.IndexOf("\") <> -1 Then s = Replace(s, "\", "\\")
        If s.IndexOf(vbCrLf) <> -1 Then s = Replace(s, vbCrLf, "\n")
        If s.IndexOf(vbCr) <> -1 Then s = Replace(s, vbCr, "\r")
        If s.IndexOf(vbLf) <> -1 Then s = Replace(s, vbLf, "\f")
        If s.IndexOf(vbTab) <> -1 Then s = Replace(s, vbTab, "\t")
        If s.IndexOf("""") = -1 Then
            Return s
        Else
            Return Replace(s, """", "\""")
        End If
    End Function

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        txtChat.Text = txtChat.Text + vbNewLine + vbNewLine + "    Human     :  " + txtQuestion.Text + vbNewLine + "    Dudu        :  "
        Dim response = callOpenAi(txtQuestion.Text, 1500, 0.9, "text-davinci-003", 1, 0.0, 0.6)
        For Each x In response

            txtChat.AppendText(x)
        Next

        txtQuestion.Text = ""

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        End
    End Sub

    Private Sub txtQuestion_TextChanged(sender As Object, e As EventArgs) Handles txtQuestion.TextChanged
        If txtQuestion.Text = "" Then
            btnSend.FillColor = Color.FromArgb(172, 172, 190)
        Else
            btnSend.FillColor = Color.FromArgb(25, 195, 125)
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        txtChat.Text = ""

    End Sub

    Private Sub Guna2GradientButton2_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton2.Click
        pnlContent.Visible = True
        With ImageGeneration
            .TopLevel = False
            pnlContent.Controls.Add(ImageGeneration)
            .BringToFront()
            .Show()
        End With
        Guna2GradientButton3.Visible = True
        Guna2GradientButton2.Visible = False
        Guna2GradientButton1.Visible = False
    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        pnlContent.Visible = False
        Guna2GradientButton2.Visible = True
        Guna2GradientButton3.Visible = False
        Guna2GradientButton1.Visible = True
    End Sub
End Class