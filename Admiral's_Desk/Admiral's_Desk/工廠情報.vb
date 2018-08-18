Public Class 工廠情報
    Private Sub 工廠情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub 入渠情報()

        'まずは中身を消す
        入渠情報表示.Rows.Clear()

        For Each Repair In MyDataClass.RepairingDock

            'api_state = 1 は入渠中を示す
            If Repair.api_state = 1 Then

                '必要な変数を準備
                Dim 艦娘名 As String = ""
                Dim 現在時刻 = DateTimeOffset.Now
                Dim 終了時刻_long As Long = CType(Repair.api_complete_time / 1000, Long)
                Dim 終了時刻 = DateTimeOffset.FromUnixTimeSeconds(終了時刻_long).ToLocalTime
                Dim 残り時間 = 終了時刻 - 現在時刻
                Dim 残り時間表示 As String = 残り時間.Hours.ToString("00") + ":" + 残り時間.Minutes.ToString("00") + ":" + (残り時間.Seconds Mod 60).ToString("00")

                If 残り時間.Seconds < 0 Then
                    残り時間表示 = "終了済み"
                End If


                'api_ship_id→commondataclass.allkanmusudata
                If Component.KancolleShipIdSearch(MyDataClass.MyKanmusu(Component.KancollePortKanmusuSearch(Repair.api_ship_id)).api_ship_id) IsNot Nothing Then
                    艦娘名 = CommonDataClass.AllKanmusuData(Component.KancolleShipIdSearch(MyDataClass.MyKanmusu(Component.KancollePortKanmusuSearch(Repair.api_ship_id)).api_ship_id)).api_name
                End If

                'Datagridviewに追加！
                入渠情報表示.Rows.Add(艦娘名, 残り時間表示, String.Format("{0:MM/dd HH:mm:ss}", 終了時刻))

            End If
        Next

    End Sub

    Private Sub 開発情報()
        '消す
        開発情報表示.Rows.Clear()

        '表示文字
        Dim 表示 As String = "************"


        If MyDataClass.Development.EquipmentID = -1 Then
            表示 = "開発失敗"
        ElseIf MyDataClass.Development.EquipmentID > 0 And ネタバレ防止.Checked = False Then
            表示 = "開発成功:" + CommonDataClass.AllEquipmentData(Component.KancolleAllEquipmentIDSearch(MyDataClass.Development.EquipmentID)).api_name
        End If

        '書く
        開発情報表示.Rows.Add(表示)
    End Sub

    Private Sub 建造情報()
        '消す
        建造情報表示.Rows.Clear()
        For Each develop In MyDataClass.Building

            'api_state = 1 は入渠中を示す
            If develop.api_state > 0 Then

                '必要な変数を準備
                Dim 艦娘名 As String = ""
                Dim 現在時刻 = DateTimeOffset.Now
                Dim 終了時刻_long As Long = CType(develop.api_complete_time / 1000, Long)
                Dim 終了時刻 = DateTimeOffset.FromUnixTimeSeconds(終了時刻_long).ToLocalTime
                Dim 残り時間 = 終了時刻 - 現在時刻
                Dim 残り時間表示 As String = 残り時間.Hours.ToString("00") + ":" + 残り時間.Minutes.ToString("00") + ":" + (残り時間.Seconds Mod 60).ToString("00")
                Dim 終了時刻表示 As String = String.Format("{0:MM/dd HH:mm:ss}", 終了時刻)


                If 残り時間.Seconds < 0 Or develop.api_state = 3 Then
                    残り時間表示 = "00:00:00"
                    終了時刻表示 = "終了済み"
                End If

                If Component.KancolleShipIdSearch(develop.api_created_ship_id) IsNot Nothing Then
                    艦娘名 = CommonDataClass.AllKanmusuData(Component.KancolleShipIdSearch(develop.api_created_ship_id)).api_name
                End If

                If ネタバレ防止.Checked = True Then
                    艦娘名 = "************"
                End If

                'Datagridviewに追加！
                建造情報表示.Rows.Add(艦娘名, 残り時間表示, 終了時刻表示)

            End If
        Next
    End Sub

    Private Sub 情報更新タイマ_Tick(sender As Object, e As EventArgs) Handles 情報更新タイマ.Tick
        入渠情報()
        開発情報()
        建造情報()

        '動作速度設定
        情報更新タイマ.Interval = 1000 * オプション.動作速度設定
    End Sub

    Private Sub ネタバレ防止_CheckedChanged(sender As Object, e As EventArgs) Handles ネタバレ防止.CheckedChanged
        開発情報()
        建造情報()
    End Sub
End Class