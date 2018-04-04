Public Class オプション
    Public Shared 動作速度設定 As Double = 1.0
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
End Class