
Public Class メインフォーム

    'アップデートに必要な情報
    Public Const ソフト名 As String = "Admiral's Desk"
    Public Const バージョン As String = "0.2.0.3"
    Public Const バージョン他表記 As String = "α"
    Dim 更新後URL As String = ""


    'プロキシ切り替え用
    Public Const notnekoxy As Boolean = False

    'Titanium用
    Dim proxyServer As Titanium.Web.Proxy.ProxyServer
    Dim explicitEndPoint As Titanium.Web.Proxy.Models.ExplicitProxyEndPoint

    'Cefsharp移行？
    Public Const cef As Boolean = True

    'ブラウザ制御用
    Shared WithEvents Cefbrowser As CefSharp.WinForms.ChromiumWebBrowser

    Private Sub メインフォーム_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'ウインドウ名だけ変更
        MyBase.Text += " " + バージョン & バージョン他表記

        'フォーム所有設定
        Me.AddOwnedForm(遠征情報)
        Me.AddOwnedForm(艦隊情報)
        Me.AddOwnedForm(提督情報)
        Me.AddOwnedForm(工廠情報)
        Me.AddOwnedForm(任務情報)
        'Me.AddOwnedForm()
        'Me.AddOwnedForm()


        CefSharp.Cef.Shutdown()

        '******************************************************
        '
        '　　　　　　　　Titaniumセッティング
        '
        '******************************************************

        proxyServer = New Titanium.Web.Proxy.ProxyServer

        AddHandler proxyServer.BeforeResponse, AddressOf データ検知T


        '上流プロキシ設定
        If オプション.プロキシ利用.Checked = True And オプション.プロキシ設定_host.Text <> "" And オプション.port.Text <> "" Then
            proxyServer.UpStreamHttpProxy = New Titanium.Web.Proxy.Models.ExternalProxy()
            proxyServer.UpStreamHttpProxy.HostName = オプション.プロキシ設定_host.Text
            proxyServer.UpStreamHttpProxy.Port = Integer.Parse(オプション.port.Text)
        End If

        explicitEndPoint = New Titanium.Web.Proxy.Models.ExplicitProxyEndPoint(System.Net.IPAddress.Loopback, 4297)

        proxyServer.AddEndPoint(explicitEndPoint)

        proxyServer.Start()




        'Cefsharpの設定
        Dim settings As CefSharp.CefSettings = New CefSharp.CefSettings

        'これ入れるとhttpキャプチャができる
        settings.CefCommandLineArgs.Add("proxy-server", "127.0.0.1:4297")

        'キャッシュ設定
        settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\CEF"

        'ハードウェアアクセラレーション
        If オプション.ハードウェアアクセラレーション.Checked = True Then
            settings.CefCommandLineArgs.Add("disable-gpu", "disable-gpu")
        End If

        'サブプロセスを殺せ
        CefSharp.CefSharpSettings.SubprocessExitIfParentProcessClosed = True

        'リセット
        CefSharp.Cef.Initialize(settings)



        'Cefsharpのコントロール作成

        Cefbrowser = New CefSharp.WinForms.ChromiumWebBrowser("http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/")

        bp.Controls.Add(Cefbrowser)
        Cefbrowser.Visible = True
        Cefbrowser.Dock = System.Windows.Forms.DockStyle.Fill
        AddHandler Cefbrowser.FrameLoadEnd, AddressOf 読込終了時



        '


        '通知領域の設定
        通知領域.Icon = SystemIcons.Application


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

        '拡大率の設定
        Dim パーセント拡大率 As Double = 100
        If Double.TryParse(オプション.ブラウザ拡大率.Text, パーセント拡大率) Then
            オプション.拡大率設定 = パーセント拡大率 / 100
            Me.Panel1.Size = New Size(1200 * オプション.拡大率設定 + 4, 41)
            Dim bpsize = New Size(1200 * オプション.拡大率設定 + 2, 720 * オプション.拡大率設定 + 24)
            Dim mainsize = New Size(1200 * オプション.拡大率設定 + 20, 720 * オプション.拡大率設定 + 41 + 63)

            Me.bp.MaximumSize = bpsize
            Me.bp.MinimumSize = bpsize
            Me.bp.Size = bpsize
            Me.bp.SendToBack()
            Me.MaximumSize = mainsize
            Me.MinimumSize = mainsize

        Else
            オプション.拡大率設定 = 1.0


            Me.Panel1.Size = New Size(1200 * オプション.拡大率設定 + 4, 41)
            Dim bpsize = New Size(1200 * オプション.拡大率設定, 720 * オプション.拡大率設定 + 24)
            Dim mainsize = New Size(1200 * オプション.拡大率設定 + 20, 720 * オプション.拡大率設定 + 41 + 63)

            Me.bp.MaximumSize = bpsize
            Me.bp.MinimumSize = bpsize
            Me.bp.Size = bpsize
            Me.bp.SendToBack()
            Me.MaximumSize = mainsize
            Me.MinimumSize = mainsize

        End If

        If Double.TryParse(オプション.ブラウザ座標X.Text, オプション.ブラウザ座標X出力) _
            And Double.TryParse(オプション.ブラウザ座標Y.Text, オプション.ブラウザ座標Y出力) Then

        End If


        'ミュートボタンの設定
        If Component.GetVolume() = 0 Then
            ミュート切り替え.Text = "ミュート解除"
        End If



    End Sub

    Private Sub 読込終了時(sender As Object, args As CefSharp.FrameLoadEndEventArgs)
        ' args.Browser.MainFrame.ExecuteJavaScriptAsync("var removeelem = document.getelementbyid('ntg-recommend');removeelem.parentNode.removechild(removeelem);")
        'args.Browser.MainFrame.ExecuteJavaScriptAsync("document.getelementbyid('ntg-recommend').remove();")
        args.Browser.MainFrame.ExecuteJavaScriptAsync("if(location.href==='http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/'){document.body.style.overflow = 'hidden';}")
        args.Browser.MainFrame.ExecuteJavaScriptAsync("$('#game_frame').css({ 'transform' : 'scale(" + オプション.拡大率設定.ToString + ")'});")
        args.Browser.MainFrame.ExecuteJavaScriptAsync("if(location.href==='http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/'){window.scrollTo(" + オプション.ブラウザ座標X出力.ToString + "," + オプション.ブラウザ座標Y出力.ToString + ");}")
        args.Browser.MainFrame.ExecuteJavaScriptAsync("if(location.href==='http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/'){recommend_area.removeClass('show');}")
        オプション.javascriptcall = True
        汎用タイマ.Enabled = True
    End Sub
    'メインフォームはもともと800x480
    '820, 589
    'ブラウザはもともと
    '804, 485


    'titanium用
    Private Async Function データ検知T(ByVal sender As Object, ByVal e As Titanium.Web.Proxy.EventArguments.SessionEventArgs) As Task



        'Q:      このすぐ上の2行なにやってんの？
        '    A:  受け取ったデータがJsonかどうかを判別してます
        '        JsonであればNothingにならないはず
        '        艦これで使われる以外のJsonは想定してないから万が一がありえます

        '        以後のデータ処理に必要なパスを出します。/kcsapiのアレです
        '         Dim path As String = e.WebSession.Request.Url                   'jsonのパス

        '        Uriオブジェクトを作成
        Dim responseHeaders = e.WebSession.Response.Headers

        If (e.WebSession.Response.StatusCode <> 200) Then
            Exit Function
        End If

        Dim Resbody As String = Await e.GetResponseBodyAsString

        Dim url As String = e.WebSession.Request.Url



        Dim path As String = url
        Dim JSONData As String = Resbody
        Dim u As New Uri(path)

        If u.LocalPath.StartsWith(URLDataClass.kcsapi) Then

            'ここから実装
            Dim JSONObject As Object = Component.KancolleReadJson2(JSONData, u.LocalPath, URLDataClass.kcsapi)

            '共通データの取得関数
            StructureOperationClass.KancolleCommonDataReset(JSONData, u.LocalPath)

            '構造体に代入する関数
            StructureOperationClass.JsonDataInputToStructure(JSONObject, u.LocalPath)
        End If




        オプション.javascriptcall = True



    End Function

    Private Sub メインフォーム_Close() Handles MyBase.Closed
        オプション.javascriptcall = False
        proxyServer.Stop()
        CefSharp.Cef.Shutdown()

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
            'ブラウザ.Refresh()
            Cefbrowser.GetBrowser.Reload()
        End If

    End Sub

    Private Sub 中止ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 中止ToolStripMenuItem.Click
        'ブラウザ.Stop()
        Cefbrowser.GetBrowser.StopLoad()
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

                IO.File.AppendAllText(filePath, String.Format("{0},{1},{2},{3},", マップ名, Component.MapIDSquareString(マップ名, MyDataClass.Start.api_no), MyDataClass.Start.api_ship_type, MyDataClass.Start.api_ship_name) & MyDataClass.Start.api_win_rank & "," & String.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTimeOffset.Now) & "" & vbCrLf, enc)
            End If

            MyDataClass.Start.出力 = False

        End If

        '大破艦通知
        If 艦隊情報.大破艦通知 = True Then
            通知領域.Visible = True
            通知領域.ShowBalloonTip(30000, "注意！", "大破した艦がいます", ToolTipIcon.Warning)
            艦隊情報.大破艦通知 = False
        End If

        '遠征終了通知
        For cnt = 0 To 遠征情報.遠征終了通知.Count - 1
            If 遠征情報.遠征終了通知(cnt) = 1 And オプション.遠征終了通知チェック.Checked = True Then
                通知領域.Visible = True
                通知領域.ShowBalloonTip(30000, MyDataClass.MyPort(cnt).api_name, "遠征が終了しました", ToolTipIcon.Info)
                遠征情報.遠征終了通知(cnt) = 2
            End If
        Next

        If MyDataClass.MyPort(1).api_mission IsNot Nothing Then
            For cnt = 0 To 3
                If MyDataClass.MyPort(cnt).api_mission(0).Equals(1) Then

                    'unixタイムスタンプからの変更
                    Dim 現在時刻 As DateTimeOffset = DateTimeOffset.Now
                    Dim 帰還時刻 As DateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(MyDataClass.MyPort(cnt).api_mission(2) / 1000).ToLocalTime
                    Dim 残り時間 As TimeSpan = 帰還時刻 - 現在時刻
                    Dim 残り時間表示 As String = 残り時間.Hours.ToString("00") + ":" + 残り時間.Minutes.ToString("00") + ":" + (残り時間.Seconds Mod 60).ToString("00")

                    If 残り時間.Seconds < 0 Then
                        残り時間表示 = "帰還済み"

                        '遠征終了通知をさせるために必要
                        If 遠征情報.遠征終了通知(cnt) = 0 Then
                            遠征情報.遠征終了通知(cnt) = 1
                        End If
                    End If


                    Dim 艦隊名称 = MyDataClass.MyPort(cnt).api_name
                    Dim 遠征名称 = Component.KancolleMissionIDSearch(MyDataClass.MyPort(cnt).api_mission(1))

                Else
                    遠征情報.遠征終了通知(cnt) = 0
                End If

            Next
        End If


        '疲労回復タイマー
        For cnt = 0 To MyDataClass.MyPort.Length - 1
            Dim 最悪cond As Integer = 100
            Dim 回復時間 As DateTimeOffset = DateTimeOffset.Now
            If MyDataClass.MyPort(cnt).api_ship IsNot Nothing Then
                For Each ship In MyDataClass.MyPort(cnt).api_ship
                    If Component.KancollePortKanmusuSearch(ship) IsNot Nothing Then
                        Dim 母港配列ID As Integer = Component.KancollePortKanmusuSearch(ship)


                        '最悪だったら代入
                        If 最悪cond > MyDataClass.MyKanmusu(母港配列ID).api_cond Then
                            最悪cond = MyDataClass.MyKanmusu(母港配列ID).api_cond
                            If 最悪cond < 49 Then
                                Dim ts As New TimeSpan(0, 49 - 最悪cond, 0)
                                回復時間 = DateTimeOffset.Now + ts
                            End If
                        End If
                    End If
                Next


                '出撃中はOFFにしておく
                If MyDataClass.Start.出撃 = True Then
                    MyDataClass.MyPort(cnt).noapi_condtimer = 5
                End If
                If MyDataClass.Start.出撃 = False And MyDataClass.MyPort(cnt).noapi_condtimer = 5 Then
                    MyDataClass.MyPort(cnt).noapi_condtimer = 0
                End If


                '0なら記録
                If 最悪cond < 49 And MyDataClass.MyPort(cnt).noapi_condtimer = 0 Then
                    MyDataClass.MyPort(cnt).noapi_condtime = 回復時間
                    MyDataClass.MyPort(cnt).noapi_condtimer = 1
                End If

                '早まった場合
                If 最悪cond < 49 And MyDataClass.MyPort(cnt).noapi_condtimer = 1 And (回復時間 - MyDataClass.MyPort(cnt).noapi_condtime).Seconds < 0 Then
                    MyDataClass.MyPort(cnt).noapi_condtime = 回復時間
                    MyDataClass.MyPort(cnt).noapi_condtimer = 1
                End If


                '終わった場合
                If MyDataClass.MyPort(cnt).noapi_condtimer = 1 And (MyDataClass.MyPort(cnt).noapi_condtime - DateTimeOffset.Now).Seconds < 0 Then
                    If オプション.疲労回復通知.Checked = True Then
                        '通知する
                        通知領域.Visible = True
                        通知領域.ShowBalloonTip(30000, MyDataClass.MyPort(cnt).api_name, "疲労が回復しました", ToolTipIcon.Info)
                    End If
                    MyDataClass.MyPort(cnt).noapi_condtimer = 0
                End If

                '伊良湖とか使った場合
                If MyDataClass.MyPort(cnt).noapi_condtimer = 1 And 最悪cond >= 49 Then
                    MyDataClass.MyPort(cnt).noapi_condtimer = 0
                End If

            End If


                Debug.WriteLine("cnt :" + cnt.ToString)
            Debug.WriteLine("co  :" + MyDataClass.MyPort(cnt).noapi_condtime.ToString)
            Debug.WriteLine("回  :" + 回復時間.ToString)
            Debug.WriteLine("ti  :" + MyDataClass.MyPort(cnt).noapi_condtimer.ToString)

            '画面処理
            If オプション.javascriptcall = True Then
                Cefbrowser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("if(location.href==='http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/'){document.body.style.overflow = 'hidden';}")
                Cefbrowser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("$('#game_frame').css({ 'transform' : 'scale(" + オプション.拡大率設定.ToString + ")'});")
                Cefbrowser.GetBrowser.MainFrame.ExecuteJavaScriptAsync("if(location.href==='http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/'){window.scrollTo(" + オプション.ブラウザ座標X出力.ToString + "," + オプション.ブラウザ座標Y出力.ToString + ");}")
                オプション.javascriptcall = False
            End If

        Next
    End Sub

    Private Sub 全艦娘一覧ウインドウ表示_Click(sender As Object, e As EventArgs) Handles 全艦娘一覧ウインドウ表示.Click
        全艦娘一覧.Visible = True
    End Sub

    Private Sub 戦闘予報アクセス_CheckedChanged(sender As Object, e As EventArgs) Handles 戦闘予報アクセス.CheckedChanged
        If 戦闘予報アクセス.Checked = True Then
            戦闘予報.Visible = True
        Else
            戦闘予報.Visible = False
        End If
    End Sub



    Private Declare Function PrintWindow Lib "User32" (ByVal hWnd As IntPtr, ByVal hdcBlt As IntPtr, ByVal nFlags As Integer) As Boolean
    Private Sub スクリーンショット撮影_Click(sender As Object, e As EventArgs) Handles スクリーンショット撮影.Click
        ''temp画像保存領域
        'Dim imgtemp As New Bitmap(802, 482) '撮影用
        'Dim rectemp As New Bitmap(800, 400) '切抜用

        'ファイル名作成
        Dim nowTime As DateTimeOffset = Now
        Dim nowTimeStr As String = nowTime.Year.ToString + nowTime.Month.ToString("00") + nowTime.Day.ToString("00") + nowTime.Hour.ToString("00") + nowTime.Minute.ToString("00") + nowTime.Second.ToString("00") + nowTime.Millisecond.ToString("00")
        Dim Filename As String = My.Application.Info.DirectoryPath + "\SS\" + nowTimeStr + ".png"

        'フォルダ存在チェック
        If System.IO.Directory.Exists(My.Application.Info.DirectoryPath + "\SS\") Then
            'なにもしない
        Else
            'フォルダを作る
            MkDir(My.Application.Info.DirectoryPath + "\SS\")
        End If

        ''webbrowserから画像をコピー
        'Using targetGraphics As Graphics = Graphics.FromImage(imgtemp)
        '    Dim hDC As IntPtr = targetGraphics.GetHdc()
        '    'PrintWindow(ブラウザ.Handle, hDC, 0)
        '    PrintWindow(Cefbrowser.Handle, hDC, 0)
        '    targetGraphics.ReleaseHdc(hDC)
        'End Using

        ''そして切抜き
        'Dim rect As New Rectangle(1, 1, 800, 480)
        'rectemp = imgtemp.Clone(rect, imgtemp.PixelFormat)

        ''ファイルに保存
        'rectemp.Save(Filename, Imaging.ImageFormat.Png)

        ''後処理
        'imgtemp.Dispose()
        'rectemp.Dispose()



        'Bitmapの作成
        Dim bmp As New Bitmap(bp.Width - 2, bp.Height - 24)
        'Graphicsの作成
        Dim g As Graphics = Graphics.FromImage(bmp)
        '画面全体をコピーする
        g.CopyFromScreen(Me.PointToScreen(New Point(0, 24)), New Point(0, 0), bmp.Size)
        '解放
        g.Dispose()

        bmp.Save(Filename, Imaging.ImageFormat.Png)

    End Sub

    Private Sub 遠征支援SToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 遠征支援SToolStripMenuItem.Click
        遠征支援.Visible = True
    End Sub

    Private Sub ミュート切り替え_Click(sender As Object, e As EventArgs) Handles ミュート切り替え.Click

        If Component.GetVolume <> 0 Then
            Component.SetVolume(0)
            ミュート切り替え.Text = "ミュート解除"
        Else
            Component.SetVolume(4294967295)
            ミュート切り替え.Text = "ミュート"
        End If
    End Sub
End Class
