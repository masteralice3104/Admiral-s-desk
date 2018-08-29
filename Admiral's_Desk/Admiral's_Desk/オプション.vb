Public Class オプション
    Friend Shared ReadOnly 疲労回復通知保存 As Boolean
    Public Shared 動作速度設定 As Double = 1.0
    Public Shared 拡大率設定 As Double = 1.0
    Public Shared ブラウザ座標X出力 As Double = 200
    Public Shared ブラウザ座標Y出力 As Double = 210
    Public Shared javascriptcall As Boolean = False


    Private Sub 動作調整バー_Scroll(sender As Object, e As EventArgs) Handles 動作調整バー.Scroll

        If 動作調整バー.Value = 3 Then
            動作速度設定 = 1.0
        ElseIf 動作調整バー.Value = 2 Then
            動作速度設定 = 1.5
        ElseIf 動作調整バー.Value = 1 Then
            動作速度設定 = 2.0
        ElseIf 動作調整バー.Value = 0 Then
            動作速度設定 = 2.5
        End If

    End Sub

    Private Sub オプション_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '初期設定


        'debugタブを消す
#If DEBUG Then
#Else
#End If


        '動作速度設定
        If 動作調整バー.Value = 3 Then
            動作速度設定 = 1.0
        ElseIf 動作調整バー.Value = 2 Then
            動作速度設定 = 1.5
        ElseIf 動作調整バー.Value = 1 Then
            動作速度設定 = 2.0
        ElseIf 動作調整バー.Value = 0 Then
            動作速度設定 = 2.5
        End If

        '入手艦娘記録設定
        If 入手艦娘記録.Checked = True Then
            保存ファイル名.Enabled = True
            保存ファイル名設定.Enabled = True
        Else
            保存ファイル名.Enabled = False
            保存ファイル名設定.Enabled = False
        End If

        'プロキシ利用設定
        プロキシ設定_host.Enabled = プロキシ利用.Checked
        port.Enabled = プロキシ利用.Checked

        '通知設定
        通知秒.Enabled = 遠征終了通知チェック.Checked
        Integer.TryParse(通知秒.Text, メインフォーム.オプション設定_遠征通知通知秒)
        メインフォーム.オプション設定_疲労回復通知 = 疲労回復通知チェック.Checked

        '通知用SE設定
        遠征終了時SEファイルパス.Enabled = 遠征終了時SE.Checked
        遠征終了時SEファイル名選択.Enabled = 遠征終了時SE.Checked

    End Sub

    Private Sub 入手艦娘記録_CheckedChanged(sender As Object, e As EventArgs) Handles 入手艦娘記録.CheckedChanged
        If 入手艦娘記録.Checked = True Then
            保存ファイル名.Enabled = True
            保存ファイル名設定.Enabled = True
        Else
            保存ファイル名.Enabled = False
            保存ファイル名設定.Enabled = False
        End If
    End Sub

    Private Sub 保存ファイル名設定_Click(sender As Object, e As EventArgs) Handles 保存ファイル名設定.Click
        'https://dobon.net/vb/dotnet/form/savefiledialog.html
        'ここを参考

        '初期設定
        ドロップ艦娘保存.FileName = "DropKanmusu.csv"   'ファイル名
        ドロップ艦娘保存.InitialDirectory = ""          '初期フォルダ(空だと現在のディレクトリ)
        ドロップ艦娘保存.Filter = "csvファイル(*.csv)|*.csv|すべてのファイル(*.*)|*.*"    'ファイル種類
        ドロップ艦娘保存.FilterIndex = 1

        If ドロップ艦娘保存.ShowDialog() = DialogResult.OK Then
            保存ファイル名.Text = ドロップ艦娘保存.FileName
        End If


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        メインフォーム.通知領域.Visible = True
        メインフォーム.通知領域.ShowBalloonTip(4000, "通知", "これはテスト通知です", ToolTipIcon.Warning)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If Component.GetVolume <> 0 Then
            Component.SetVolume(0)
        Else
            Component.SetVolume(4294967295)
        End If
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub プロキシ利用_CheckedChanged_1(sender As Object, e As EventArgs)
        プロキシ設定_host.Enabled = プロキシ利用.Checked
        port.Enabled = プロキシ利用.Checked
    End Sub

    Private Sub 画面設定適用_Click(sender As Object, e As EventArgs) Handles 画面設定適用.Click
        Dim パーセント拡大率 As Double = 100
        If ブラウザ拡大率.Text <> "" And Double.TryParse(ブラウザ拡大率.Text, パーセント拡大率) Then

            Dim 拡大率 As Double = Double.Parse(ブラウザ拡大率.Text)
            If 拡大率 > 0 Then
                拡大率設定 = パーセント拡大率 / 100
                Dim bpsize = New Size(1200 * 拡大率設定, 720 * 拡大率設定 + 24)
                Dim mainsize = New Size(1200 * 拡大率設定 + 20, 720 * 拡大率設定 + 41 + 63)



                メインフォーム.Panel1.Size = New Size(1200 * 拡大率設定 + 4, 41)

                メインフォーム.bp.MaximumSize = bpsize
                メインフォーム.bp.MinimumSize = bpsize
                メインフォーム.bp.Size = bpsize
                メインフォーム.bp.SendToBack()
                メインフォーム.MaximumSize = mainsize
                メインフォーム.MinimumSize = mainsize

                Double.TryParse(ブラウザ座標X.Text, ブラウザ座標X出力)
                Double.TryParse(ブラウザ座標Y.Text, ブラウザ座標Y出力)


                javascriptcall = True

            End If
        End If

    End Sub

    Private Sub 三分の二モード_Click(sender As Object, e As EventArgs) Handles 三分の二モード.Click



        ブラウザ拡大率.Text = 66.6666666666666
        ブラウザ座標X.Text = 200
        ブラウザ座標Y.Text = 191

        画面設定適用.PerformClick()
    End Sub

    Private Sub 等倍モード_Click(sender As Object, e As EventArgs) Handles 等倍モード.Click

        ブラウザ拡大率.Text = 100.0
        ブラウザ座標X.Text = 199
        ブラウザ座標Y.Text = 53

        画面設定適用.PerformClick()
    End Sub

    Private Sub プロキシ利用_CheckedChanged(sender As Object, e As EventArgs) Handles プロキシ利用.CheckedChanged
        プロキシ設定_host.Enabled = プロキシ利用.Checked
        port.Enabled = プロキシ利用.Checked
    End Sub

    Private Sub 遠征終了通知チェック_CheckedChanged(sender As Object, e As EventArgs) Handles 遠征終了通知チェック.CheckedChanged
        通知秒.Enabled = 遠征終了通知チェック.Checked
        メインフォーム.オプション設定_遠征通知 = 遠征終了通知チェック.Checked
        Integer.TryParse(通知秒.Text, メインフォーム.オプション設定_遠征通知通知秒)
        通知秒設定適用.Enabled = 遠征終了通知チェック.Checked
    End Sub

    Private Sub 疲労回復通知チェック_CheckedChanged(sender As Object, e As EventArgs) Handles 疲労回復通知チェック.CheckedChanged
        メインフォーム.オプション設定_疲労回復通知 = 疲労回復通知チェック.Checked
    End Sub

    Private Sub 遠征終了時SE_CheckedChanged(sender As Object, e As EventArgs) Handles 遠征終了時SE.CheckedChanged
        遠征終了時SEファイルパス.Enabled = 遠征終了時SE.Checked
        遠征終了時SEファイル名選択.Enabled = 遠征終了時SE.Checked
    End Sub

    Private Sub 遠征終了時SEファイル名選択_Click(sender As Object, e As EventArgs) Handles 遠征終了時SEファイル名選択.Click
        遠征終了時SEファイル名.FileName = "se.wav"
        遠征終了時SEファイル名.Filter = "WAVファイル(*.wav)|*.wav|すべてのファイル(*.*)|*.*"
        遠征終了時SEファイル名.FilterIndex = 1
        遠征終了時SEファイル名.Title = "ファイルを選択して下さい"
        遠征終了時SEファイル名.RestoreDirectory = True
        If 遠征終了時SEファイル名.ShowDialog() = DialogResult.OK Then
            'OKボタンがクリックされたとき
            遠征終了時SEファイルパス.Text = 遠征終了時SEファイル名.FileName
        End If
    End Sub

    Private Sub 通知秒設定適用_Click(sender As Object, e As EventArgs) Handles 通知秒設定適用.Click
        メインフォーム.オプション設定_遠征通知 = 遠征終了通知チェック.Checked
        Integer.TryParse(通知秒.Text, メインフォーム.オプション設定_遠征通知通知秒)
    End Sub
End Class