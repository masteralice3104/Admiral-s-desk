Public Class 遠征情報
    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.遠征情報アクセス.Checked = False
    End Sub

    Private Sub タイマ_Tick(sender As Object, e As EventArgs) Handles タイマ.Tick
        'あんまり良くないけど有効ではないスレッド間の操作が発生するのでこれを言っておく
        DataGridView.CheckForIllegalCrossThreadCalls = False


        'まずは中身を消す
        遠征情報表示.Rows.Clear()

        If MyDataClass.MyPort(1).api_mission IsNot Nothing Then
            For cnt As Integer = 0 To 3
                If MyDataClass.MyPort(cnt).api_mission(0).Equals(1) Then

                    'unixタイムスタンプからの変更
                    Dim 現在時刻 = DateTimeOffset.Now
                    Dim 帰還時刻 = DateTimeOffset.FromUnixTimeSeconds(MyDataClass.MyPort(cnt).api_mission(2) / 1000).ToLocalTime
                    Dim 残り時間 = 帰還時刻 - 現在時刻

                    Dim 艦隊名称 = MyDataClass.MyPort(cnt).api_name
                    Dim 遠征名称 = Component.KancolleMissionIDSearch(MyDataClass.MyPort(cnt).api_mission(1))

                    遠征情報表示.Rows.Add(艦隊名称, 遠征名称, 残り時間.ToString("hh\:mm\:ss"), String.Format("{0:MM/dd HH:mm:ss}", 帰還時刻))
                End If
            Next
        End If
    End Sub
End Class