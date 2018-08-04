Public Class 遠征情報

    Public Shared 遠征終了通知() As Integer = {0, 0, 0, 0}
    '遠征終了通知の意味
    '   0   通知することは特になし
    '   1   通知待ち
    '   2   通知済み

    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.遠征情報アクセス.Checked = False
    End Sub

    Private Sub タイマ_Tick(sender As Object, e As EventArgs) Handles タイマ.Tick
        'あんまり良くないけど有効ではないスレッド間の操作が発生するのでこれを言っておく
        'DataGridView.CheckForIllegalCrossThreadCalls = False


        'まずは中身を消す
        遠征情報表示.Rows.Clear()

        If MyDataClass.MyPort(1).api_mission IsNot Nothing Then
            For cnt As Integer = 0 To 3
                If MyDataClass.MyPort(cnt).api_mission(0).Equals(1) Then

                    'unixタイムスタンプからの変更
                    Dim 現在時刻 = DateTimeOffset.Now
                    Dim 帰還時刻 = DateTimeOffset.FromUnixTimeSeconds(MyDataClass.MyPort(cnt).api_mission(2) / 1000).ToLocalTime
                    Dim 残り時間 = 帰還時刻 - 現在時刻
                    Dim 残り時間表示 As String = 残り時間.ToString("hh\:mm") + ":" + (残り時間.Seconds Mod 60).ToString("00")

                    If 残り時間.Seconds < 0 Then
                        残り時間表示 = "帰還済み"

                        '遠征終了通知をさせるために必要
                        If 遠征終了通知(cnt) = 0 Then
                            遠征終了通知(cnt) = 1
                        End If
                    Else
                        If 遠征終了通知(cnt) = 2 Then
                            遠征終了通知(cnt) = 0
                        End If
                    End If


                    Dim 艦隊名称 = MyDataClass.MyPort(cnt).api_name
                    Dim 遠征名称 = Component.KancolleMissionIDSearch(MyDataClass.MyPort(cnt).api_mission(1))

                    遠征情報表示.Rows.Add(艦隊名称, 遠征名称, 残り時間表示, String.Format("{0:MM/dd HH:mm:ss}", 帰還時刻))
                End If
            Next
        End If



        '動作速度設定
        タイマ.Interval = 1000 * オプション.動作速度設定
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        遠征支援.Visible = True
    End Sub

    Private Sub 遠征情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class