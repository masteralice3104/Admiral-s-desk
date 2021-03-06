﻿Public Class 戦闘予報
    '変数
    Public Shared 戦闘予報情報更新 As Boolean = False

    Private Sub 情報更新フラグ()
        戦闘予報情報更新 = True
    End Sub

    Private Sub 更新タイマ_Tick(sender As Object, e As EventArgs) Handles 更新タイマ.Tick

        If 戦闘予報情報更新 = True Then
            画面更新()
            戦闘予報情報更新 = False
        End If

        '動作速度設定
        更新タイマ.Interval = 1000 * オプション.動作速度設定

    End Sub

    Private Sub 画面更新()
        'この関数はあくまで仮のものであり内容変更に耐えうるものとする

        '予報文作成
        'あくまでここは仮

        Dim 予報文 As String = ""
        Dim データ読み込み回数 As Long = 0
        Dim 最小制空値 As Long = 10000
        Dim 最大制空値 As Long = 0
        Dim 自艦隊制空値 As Long
        Dim 航空戦確率() As Long = {0, 0, 0, 0, 0}
        Dim 弾着確率 As Long = 0


        '出撃中
        If MyDataClass.Start.出撃 = True Then

            '制空値入力
            自艦隊制空値 = Long.Parse(艦隊情報.制空値.Text)

            'マップ判定
            If MyDataClass.Start.api_maparea_id <> Nothing And MyDataClass.Start.api_mapinfo_no <> Nothing Then

                'マス判定
                If MyDataClass.Start.api_no <> Nothing Then

                    'マップ名作成
                    Dim マップ名 As String = MyDataClass.Start.api_maparea_id.ToString + "-" + MyDataClass.Start.api_mapinfo_no.ToString

                    '予報
                    予報文 += "次のマス" + マップ名 + "-" + Component.MapIDSquareString(マップ名, MyDataClass.Start.api_no) + "の予報です" + vbCrLf


                    For Each BasicData In CommonDataClass.予測基礎情報

                        'マップ名・マス番号一致確認
                        If BasicData.map = マップ名 And BasicData.square = Component.MapIDSquareString(マップ名, MyDataClass.Start.api_no) Then

                            '読込初回処理
                            If データ読み込み回数 = 0 Then
                                予報文 += "戦闘種別：" + Component.BattleTypeNameString(BasicData.Battle_type) + vbCrLf
                            End If

                            If BasicData.Battle_type = 6 Or BasicData.Battle_type = 7 Or BasicData.Battle_type = 8 Then
                                Continue For
                            End If

                            '飛ばすフラグ
                            Dim 飛ばすフラグ As Boolean = False

                            '前哨戦と最終形態を判別する
                            For count As Integer = 0 To 提督情報.マップ状態.Rows.Count - 1
                                If 提督情報.マップ状態.Rows(count).Cells(0).ToString = マップ名 Then
                                    If 提督情報.マップ状態.Rows(count).Cells(1).ToString.StartsWith("1/") Then
                                        If BasicData.Battle_type = 9 Then
                                            飛ばすフラグ = True
                                        End If
                                    Else
                                        If BasicData.Battle_type = 10 Then
                                            飛ばすフラグ = True
                                        End If
                                    End If
                                    If BasicData.Battle_type = 1 Then
                                        飛ばすフラグ = True
                                    End If
                                End If
                            Next

                            '飛ばすフラグをみつけたら飛ばす
                            If 飛ばすフラグ = True Then
                                Continue For
                            End If


                            If データ読み込み回数 = 0 Then

                                予報文 += "的中率　｜　陣  形　 ｜　編　成" + vbCrLf
                            End If

                            '司令LV確認
                            If BasicData.max_lv >= MyDataClass.Admiral.api_level And BasicData.min_lv <= MyDataClass.Admiral.api_level Then
                                '敵編成情報
                                予報文 += BasicData.percent.ToString("00") + "％　 　｜　" + Component.FormationNameString(BasicData.formation) + "  ｜　　" + BasicData.hensei + vbCrLf

                                '制空値比較
                                If 最大制空値 <= BasicData.air Then
                                    最大制空値 = BasicData.air
                                End If
                                If 最小制空値 >= BasicData.air Then
                                    最小制空値 = BasicData.air
                                End If

                                '制空値判定
                                Select Case 自艦隊制空値
                                    Case Is >= BasicData.air * 3
                                        航空戦確率(0) += BasicData.percent
                                    Case BasicData.air * 1.5 To BasicData.air * 3 - 1
                                        航空戦確率(1) += BasicData.percent
                                    Case BasicData.air / 1.5 To BasicData.air * 1.5 - 1
                                        航空戦確率(2) += BasicData.percent
                                    Case BasicData.air / 3 To BasicData.air / 1.5 - 1
                                        航空戦確率(3) += BasicData.percent
                                        '弾着確率
                                        If BasicData.danchaku = 1 Then
                                            弾着確率 += BasicData.percent
                                        End If
                                    Case Is <= BasicData.air / 3
                                        航空戦確率(4) += BasicData.percent
                                        '弾着確率
                                        If BasicData.danchaku = 1 Then
                                            弾着確率 += BasicData.percent
                                        End If
                                End Select

                                'データ読み込みカウント
                                データ読み込み回数 += 1

                                End If

                            End If
                    Next

                End If
            End If
        End If

        If データ読み込み回数 > 0 Then

            '詳細
            予報文 += "敵制空値は" + 最小制空値.ToString + "～" + 最大制空値.ToString + "のため" + vbCrLf
            予報文 += "    確保：" + 航空戦確率(0).ToString + "%" + vbCrLf
            予報文 += "    優勢：" + 航空戦確率(1).ToString + "%" + vbCrLf
            予報文 += "    均衡：" + 航空戦確率(2).ToString + "%" + vbCrLf
            予報文 += "    劣勢：" + 航空戦確率(3).ToString + "%" + vbCrLf
            予報文 += "    喪失：" + 航空戦確率(4).ToString + "%" + vbCrLf + vbCrLf

            予報文 += "弾着観測射撃をされる可能性：" + 弾着確率.ToString + "％" + vbCrLf

        End If

        '出力
        出力ウインドウ.Text = 予報文
    End Sub

    Private Sub 戦闘予報_close(sender As Object, e As EventArgs) Handles MyBase.Closed
        メインフォーム.戦闘予報アクセス.Checked = False
    End Sub

    Private Sub 戦闘予報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyDataClass.Events.Info_Refresh, AddressOf 情報更新フラグ

        'ここだけ仮。ほんとはconstとかにしたい
        Dim textFile As String = "./forecast.json"
        Dim json_ver As Integer = 1




        Dim enc As System.Text.Encoding = System.Text.Encoding.GetEncoding("shift_jis")

        '読み込んで
        Dim json As String = System.IO.File.ReadAllText(textFile, enc)

        'JSONオブジェクトにする
        Dim JSONObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(json)

        '変数格納用
        Dim マップ名 As String = ""
        Dim マス名称 As String = 0
        Dim 戦闘種別 As Integer = 0
        Dim 的中確率 As Integer = 0
        Dim 敵艦陣形 As Integer = 0
        Dim 敵制空値 As Integer = 0
        Dim 敵弾着可 As Integer = 0
        Dim 敵艦編成 As String = ""
        Dim 司令Lv() As Integer = {1, 120}

        'ここからjsonの解析
        If JSONObject("data") IsNot Nothing And JSONObject("json_ver").ToString = json_ver.ToString Then
            For Each Obj In JSONObject("data")
                '読み込んで
                If Obj("map") IsNot Nothing Then マップ名 = Obj("map")
                If Obj("square") IsNot Nothing Then マス名称 = Obj("square")
                If Obj("Battle_type") IsNot Nothing Then 戦闘種別 = Obj("Battle_type")
                If Obj("percent") IsNot Nothing Then 的中確率 = Obj("percent")
                If Obj("min_lv") IsNot Nothing Then 司令Lv(0) = Obj("min_lv")
                If Obj("max_lv") IsNot Nothing Then 司令Lv(1) = Obj("max_lv")
                If Obj("danchaku") IsNot Nothing Then 敵弾着可 = Obj("danchaku")
                If Obj("hensei") IsNot Nothing Then 敵艦編成 = Obj("hensei")
                If Obj("formation") IsNot Nothing Then 敵艦陣形 = Obj("formation")
                If Obj("air") IsNot Nothing Then 敵制空値 = Obj("air")

                'メモリに保存

                'まずは配列を一個だけ大きくして
                ReDim Preserve CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count)

                '代入
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).map = マップ名
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).square = マス名称
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).Battle_type = 戦闘種別
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).percent = 的中確率
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).formation = 敵艦陣形
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).air = 敵制空値
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).danchaku = 敵弾着可
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).hensei = 敵艦編成
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).min_lv = 司令Lv(0)
                CommonDataClass.予測基礎情報(CommonDataClass.予測基礎情報.Count - 1).max_lv = 司令Lv(1)
            Next
        End If


    End Sub
End Class




