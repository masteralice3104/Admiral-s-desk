Public Class 任務情報

    Public Shared 任務更新フラグ As Boolean = False


    Private Sub 任務情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyDataClass.Events.Info_Refresh, AddressOf 任務更新フラグ更新
    End Sub


    Private Sub 任務更新フラグ更新()
        任務更新フラグ = True
    End Sub






    Private Sub 任務更新()
        'まず消す
        受注中任務表示.Rows.Clear()

        For Each quest In MyDataClass.Quest
            '任務が存在しているもの

            If quest.api_no.ToString <> "0" Then
                '必要な変数を準備
                Dim 任務種別 As String = ""
                Dim 任務名称 As String = ""
                Dim 任務状態 As String = ""


                If quest.api_type = 1 Then
                    任務種別 = "デイリー"
                ElseIf quest.api_type = 2 Then
                    任務種別 = "ウィークリー"
                ElseIf quest.api_type = 3 Then
                    任務種別 = "マンスリー"
                ElseIf quest.api_type = 4 Then
                    任務種別 = "単発"
                ElseIf quest.api_type = 5 Then
                    任務種別 = "その他"
                End If



                任務名称 = quest.api_title
                If quest.api_state = 2 Then
                    任務状態 = "受注中"
                End If

                If quest.api_progress_flag = 1 Then
                    任務状態 += "：50％以上達成"
                ElseIf quest.api_progress_flag = 2 Then
                    任務状態 += "：80％以上達成"
                End If

                If 任務状態 = "" Then
                    Continue For
                End If
                '最後に追加
                受注中任務表示.Rows.Add(任務種別, 任務名称, 任務状態)


                End If

        Next

    End Sub





    Private Sub 任務更新タイマ_Tick(sender As Object, e As EventArgs) Handles 任務更新タイマ.Tick
        If 任務更新フラグ = True Then
            任務更新()
            任務更新フラグ = False
        End If

        '動作速度設定変更
        任務更新タイマ.Interval = 1000 * オプション.動作速度設定
    End Sub
End Class