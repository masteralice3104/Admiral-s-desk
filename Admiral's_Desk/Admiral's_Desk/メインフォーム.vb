Public Class メインフォーム
    Private Sub ブラウザ_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles ブラウザ.DocumentCompleted
        ブラウザ.ScrollBarsEnabled = False
        ブラウザ.Document.Window.ScrollTo(123, 95)
    End Sub

    Private Sub メインフォーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Nekoxyを使います
        'ここはNekoxyExampleを参考にしてます


        'とりあえず消す
        Nekoxy.HttpProxy.Shutdown()

        'プロキシをはじめる
        Nekoxy.HttpProxy.Startup(12345, False, True)

        'イベントハンドラを設定
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf データ検知




    End Sub

    Private Sub データ検知(oSession As Nekoxy.Session)
        'とりあえずNekoxyからパスを受け取る
        Dim path As String = oSession.Request.PathAndQuery

        'JSONのデータもぶち込む
        Dim JSONtemporaryData As String = oSession.Response.BodyAsString

        If (path.StartsWith("/kcsapi/api_")) Then
            'JSONの先頭にある余計な文字を取り除く
            Dim JSONData As String = JSONtemporaryData.Substring(7)

            'JSON文字列→JSON形式データに復元
            Dim JSONObject As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)




#If DEBUG Then
            'ここからデバッグ用
            Debug.Listeners.Add(New TextWriterTraceListener(Console.Out))
            Debug.WriteLine("艦これのデータを検知しました")

            If JSONObject("api_result") IsNot Nothing Then
                Debug.WriteLine("api_result:{0}", JSONObject("api_result"))
            End If
            Debug.WriteLine(path)

            Static number As Long
            number += 1

            Dim filePath As String = String.Format("C:\test\{0}.json", number)
            Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")
            Dim URLfilepath As String = "C:\test\URL.txt"


            System.IO.File.WriteAllText(filePath, JSONData, enc)
            System.IO.File.AppendAllText(URLfilepath, Format("{0}", number) & path & vbCrLf, enc)
            'ここまでデバッグ用
#End If


        End If

    End Sub

    Private Sub メインフォーム_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        'Nekoxyの終了
        Nekoxy.HttpProxy.Shutdown()
    End Sub

    Private Sub 提督情報アクセス_CheckedChanged(sender As Object, e As EventArgs) Handles 提督情報アクセス.CheckedChanged
        If 提督情報アクセス.Checked = True Then
            提督情報.Visible = True
        Else
            提督情報.Visible = False
        End If
    End Sub

    Private Sub 艦隊情報アクセス_CheckedChanged(sender As Object, e As EventArgs) Handles 艦隊情報アクセス.CheckedChanged
        If 艦隊情報アクセス.Checked = True Then
            艦隊情報.Visible = True
        Else
            艦隊情報.Visible = False
        End If
    End Sub

    Private Sub 遠征情報アクセス_CheckedChanged(sender As Object, e As EventArgs) Handles 遠征情報アクセス.CheckedChanged
        If 遠征情報アクセス.Checked = True Then
            遠征情報.Visible = True
        Else
            遠征情報.Visible = False
        End If
    End Sub
End Class
