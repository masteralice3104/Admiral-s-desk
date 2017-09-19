Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fiddlerを使います
        'http://www2.hatenadiary.jp/entry/2013/12/11/215927 を参照しました


        'Fiddlerを起動する
        '引数→ポートは自動選択(0) , FiddlerCoreStartupFlags oFlags(Fiddler用フラグ)
        Fiddler.FiddlerApplication.Startup(0, Fiddler.FiddlerCoreStartupFlags.ChainToUpstreamGateway)

        'WinInetのプロキシ設定をする
        'これはWebbrowserコントロール(このプログラムにおいては"艦これ画面"としているもの)のプロキシ設定をすることとなる
        Fiddler.URLMonInterop.SetProxyInProcess(String.Format("127.0.0.1:{0}", Fiddler.FiddlerApplication.oProxy.ListenPort), "<local>")

        'イベンドハンドラの設定
        'http://blog.livedoor.jp/akf0/archives/51492706.html を参照しました
        'これでデータ受信後に「艦これデータ受信」が起動するはず
        AddHandler Fiddler.FiddlerApplication.AfterSessionComplete, AddressOf 艦これデータ受信

    End Sub


    Private Sub Form1_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        'プロキシ設定を外す
        Fiddler.URLMonInterop.ResetProxyInProcessToDefault()

        'Fiddlerを終了させる
        Fiddler.FiddlerApplication.Shutdown()
    End Sub

    Private Sub 艦これデータ受信(oSession As Fiddler.Session)
        'http://d.hatena.ne.jp/kfujieda/20140726/1406356357 より参照
        '

        'URLをみて艦これかどうか判別
        If Not (oSession.PathAndQuery.StartsWith("/kcsapi/api_")) Then
            '元の場所にｶｴﾚ!
            oSession.Ignore()
            Return
        End If

        'JSONをぶち込む
        Dim JSONData As String = oSession.GetResponseBodyAsString()

        'ここからデバッグ用
        Static number As Long
        number += 1

        Dim filePath As String = String.Format("C:\test\{0}.json", number)
        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")

        System.IO.File.WriteAllText(filePath, JSONData, enc)


        System.Diagnostics.Debug.WriteLine(String.Format("Session {0}({3}):HTTP {1} for {2}", oSession.id, oSession.responseCode, oSession.fullUrl, oSession.oResponse.MIMEType))

        'ここまでデバッグ用
    End Sub

    Private Sub 艦これ画面_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles 艦これ画面.DocumentCompleted
        艦これ画面.ScrollBarsEnabled = False
        艦これ画面.Document.Window.ScrollTo(123, 95)
    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 終了ToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub バージョン情報AToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles バージョン情報AToolStripMenuItem.Click
        バージョン情報.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 提督情報.Click

    End Sub
End Class
