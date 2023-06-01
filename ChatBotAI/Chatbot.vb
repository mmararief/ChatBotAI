Imports System.IO
Imports System.Net

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
        data += " ""frequency_penalty"": " & frequency_penalty & ", "
        data += " ""presence_penalty"": " & presence_penalty & ", "
        data += " ""stop"": ["" Human:"", "" AI:""]"
        data += "}"


        Using streamWriter As New StreamWriter(request.GetRequestStream())
            streamWriter.Write(data)
            streamWriter.Flush()
            streamWriter.Close()
        End Using

        Dim response As HttpWebResponse = request.GetResponse()
        Dim streamReader As New StreamReader(response.GetResponseStream())
        Dim sJson As String = streamReader.ReadToEnd()
        'add reference System.Web.Extensions
        Dim oJavaScriptSerializer As New System.Web.Script.Serialization.JavaScriptSerializer
        Dim oJson As Hashtable = oJavaScriptSerializer.Deserialize(Of Hashtable)(sJson)
        Dim sResponse As String = oJson("choices")(0)("text")
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
        txtChat.Text = txtChat.Text + vbNewLine + "Human : " + txtQuestion.Text + vbNewLine + " AI : "
        Dim response = callOpenAi(txtQuestion.Text, 500, 0.9, "text-davinci-003", 1, 0.0, 0.6)
        For Each x In response

            txtChat.AppendText(x)
        Next

        txtQuestion.Text = ""

    End Sub
End Class