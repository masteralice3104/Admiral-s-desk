Public Class メインフォーム

    'アップデートに必要な情報

    Public Const ソフト名 As String = "Admiral's Desk"
    Public Const バージョン As String = "0.1.2.0"
    Public Const バージョン他表記 As String = "α"
    Dim 更新後URL As String = ""



    Private Sub ブラウザ_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles ブラウザ.DocumentCompleted
        ブラウザ.ScrollBarsEnabled = False
        ブラウザ.Document.Window.ScrollTo(123, 95)

    End Sub



    Private Sub メインフォーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ウインドウ名だけ変更
        MyBase.Text += " " + バージョン & バージョン他表記


        'Nekoxyを使います
        'ここはNekoxyExampleを参考にしてます


        'とりあえず消す
        Nekoxy.HttpProxy.Shutdown()

        'プロキシをはじめる
        Nekoxy.HttpProxy.Startup(12345, False, True)

        'イベントハンドラを設定
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf データ検知



        '動作速度の設定
        If オプション.動作調整バー.Value = 3 Then
            オプション.動作速度設定 = 1.0
        ElseIf オプション.動作調整バー.Value = 2 Then
            オプション.動作速度設定 = 1.5
        ElseIf オプション.動作調整バー.Value = 1 Then
            オプション.動作速度設定 = 2.0
        ElseIf オプション.動作調整バー.Value = 0 Then
            オプション.動作速度設定 = 2.5
        End If
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

    Private Sub 更新ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 更新ToolStripMenuItem.Click
        'メッセージボックスを表示する
        Dim result As DialogResult = MessageBox.Show("ページを更新します", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)

        If result = DialogResult.OK Then
            'はい
            ブラウザ.Refresh()
        End If

    End Sub

    Private Sub 中止ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 中止ToolStripMenuItem.Click
        ブラウザ.Stop()
    End Sub

    Private Sub オプションoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles オプションoToolStripMenuItem.Click
        オプション.Visible = True
    End Sub

    Private Sub 終了XToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了XToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub 更新確認ブラウザ_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles 更新確認ブラウザ.DocumentCompleted
        '更新の確認用

        Dim 現在バージョン As String = ソフト名 + " " + バージョン


        If 更新確認ブラウザ.Document.Body.OuterText.ToString.StartsWith(現在バージョン) Then
        Else

            If オプション.更新チェック.Checked = True Then
                '更新が必要な場合

                Dim result As DialogResult = MessageBox.Show("新しいバージョンがあります。紹介ツイートを表示しますか？",
                                                             "更新確認",
                                                             MessageBoxButtons.YesNoCancel,
                                                             MessageBoxIcon.Exclamation,
                                                             MessageBoxDefaultButton.Button2)

                '選択肢を見る
                If result = DialogResult.Yes Then
                    Dim 開くページ As String = ""

                    If 更新後URL = "" Then
                        開くページ = "https://ux.getuploader.com/masteralice3104/"
                    Else
                        開くページ = 更新後URL
                    End If

                    'ページを開く
                    '参考
                    System.Diagnostics.Process.Start(開くページ)
                End If
                End If

        End If
    End Sub

    Private Sub 更新URL確認用ブラウザ_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles 更新URL確認用ブラウザ.DocumentCompleted
        更新後URL = 更新URL確認用ブラウザ.Document.Body.OuterText.ToString
    End Sub

    Private Sub 工廠情報アクセス_CheckedChanged(sender As Object, e As EventArgs) Handles 工廠情報アクセス.CheckedChanged
        If 工廠情報アクセス.Checked = True Then
            工廠情報.Visible = True
        Else
            工廠情報.Visible = False
        End If
    End Sub

    Private Sub 任務情報アクセス_CheckedChanged(sender As Object, e As EventArgs) Handles 任務情報アクセス.CheckedChanged
        If 任務情報アクセス.Checked = True Then
            任務情報.Visible = True
        Else
            任務情報.Visible = False
        End If
    End Sub

    Private Sub 汎用タイマ_Tick(sender As Object, e As EventArgs) Handles 汎用タイマ.Tick

        'ドロップ艦娘保存
        If MyDataClass.Start.出力 = True Then

            If オプション.入手艦娘記録.Checked = True And オプション.保存ファイル名.Text <> "" Then
                Dim filePath As String = オプション.保存ファイル名.Text
                Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")

                Dim マップ名 As String = String.Format("""{0}-{1}""", MyDataClass.Start.api_maparea_id, MyDataClass.Start.api_mapinfo_no)

                IO.File.AppendAllText(filePath, String.Format("{0},{1},{2},{3},", マップ名, MyDataClass.Start.api_no, MyDataClass.Start.api_ship_type, MyDataClass.Start.api_ship_name) & MyDataClass.Start.api_win_rank & "," & String.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTimeOffset.Now) & "" & vbCrLf, enc)
            End If

            MyDataClass.Start.出力 = False

        End If
        '大破通知
        If MyDataClass.Start.出撃 = True Then

        End If
    End Sub

    Private Sub 全艦娘一覧ウインドウ表示_Click(sender As Object, e As EventArgs) Handles 全艦娘一覧ウインドウ表示.Click
        全艦娘一覧.Visible = True
    End Sub
End Class
