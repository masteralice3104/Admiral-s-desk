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

        'この辺は Component.KancolleReadJson で置換されました

        '        'とりあえずNekoxyからパスを受け取る
        '       Dim path As String = oSession.Request.PathAndQuery
        '
        '       'JSONのデータもぶち込む
        '        Dim JSONtemporaryData As String = oSession.Response.BodyAsString

        '        If (path.StartsWith("/kcsapi/api_")) Then
        '          'JSONの先頭にある余計な文字を取り除く
        '           Dim JSONData As String = JSONtemporaryData.Substring(7)
        '
        '           'JSON文字列→JSON形式データに復元
        '            Dim JSONObject As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)

        Dim JSONObject As Object = Component.KancolleReadJson(oSession, URLDataClass.kcsapi)
        If JSONObject IsNot Nothing Then
            'Q: このすぐ上の2行なにやってんの？
            'A: 受け取ったデータがJsonかどうかを判別してます
            '   JsonであればNothingにならないはず
            '   艦これで使われる以外のJsonは想定してないから万が一がありえます

            '以後のデータ処理に必要なパスを出します。/kcsapiのアレです
            Dim path As String = oSession.Request.PathAndQuery                   'jsonのパス



#If DEBUG Then
            'ここからデバッグ用

            'デバッグに必要なデータをつくる
            Dim JSONData As String = oSession.Response.BodyAsString.Substring(7) 'JSON生データ


            'デバッグコンソール見てね！
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


            IO.File.WriteAllText(filePath, JSONData, enc)
            IO.File.AppendAllText(URLfilepath, Format("{0}", number) & path & vbCrLf, enc)
            'ここまでデバッグ用
#End If


            'ここから実装

            '共通データの取得関数
            StructureOperationClass.KancolleCommonDataReset(oSession)

            '構造体に代入する関数
            StructureOperationClass.JsonDataInputToStructure(JSONObject, path)


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
