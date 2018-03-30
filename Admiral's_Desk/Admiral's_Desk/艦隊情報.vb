﻿Public Class 艦隊情報

    '必要な変数
    Private 選択艦隊 As Long = 0
    Private 艦隊名(3) As String







    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.艦隊情報アクセス.Checked = False
    End Sub

    Private Sub 艦隊情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyDataClass.Events.Info_Refresh, AddressOf 艦隊情報更新
        艦隊情報更新()
    End Sub



    Private Sub 艦隊情報更新()
        'あんまり良くないけど有効ではないスレッド間の操作が発生するのでこれを言っておく
        DataGridView.CheckForIllegalCrossThreadCalls = False


        'まずは中身を消す
        艦隊選択.Items.Clear()

        '配列の整理
        If MyDataClass.MyPort(0).api_name IsNot Nothing Then
            ReDim Preserve 艦隊名(MyDataClass.MyPort.Count - 1)
        End If

        '艦隊名の取得
        For count As Integer = 0 To MyDataClass.MyPort.Count - 1
            If MyDataClass.MyPort(count).api_name IsNot Nothing Then
                艦隊名(count) = MyDataClass.MyPort(count).api_name
            End If
        Next

        '艦隊名の代入
        For count As Integer = 0 To 艦隊名.Count - 1
            If 艦隊名(count) IsNot Nothing Then
                艦隊選択.Items.Add(艦隊名(count))
            End If
        Next




        情報更新タイマ.Start()

    End Sub

    Private Sub 情報更新タイマ_Tick(sender As Object, e As EventArgs) Handles 情報更新タイマ.Tick
        'まずDataGridViewの項目全消し
        一艦隊情報.Rows.Clear()

        '変なデータを読まないようにする
        If MyDataClass.MyPort(選択艦隊).api_ship IsNot Nothing Then
            'ここで必要な値を用意
            Dim 制空値 As Long = 0

            '変数を初期化
            If 分岐点係数.Text <> "" Then
                Component.艦これ索敵スコア.分岐点係数 = Integer.Parse(分岐点係数.Text)
            Else
                Component.艦これ索敵スコア.分岐点係数 = 0
            End If
            Component.艦これ索敵スコア.出撃艦数 = 0
            Component.艦これ索敵スコア.艦娘索敵値平方根総和 = 0
            Component.艦これ索敵スコア.司令部レベル = MyDataClass.Admiral.api_level
            Component.艦これ索敵スコア.装備単体索敵値総和 = 0

            '一行一行追加していく
            For count As Integer = 0 To MyDataClass.MyPort(選択艦隊).api_ship.Count - 1
                '遊撃部隊対策としてapi_shipはちゃんと.Countする
                If MyDataClass.MyPort(選択艦隊).api_ship(count) <> -1 Then
                    '艦隊所属艦を母港の艦娘と照合する
                    If Component.KancollePortKanmusuSearch(MyDataClass.MyPort(選択艦隊).api_ship(count)) IsNot Nothing Then

                        '発見できた母港IDを保存
                        '母港IDがわかれば艦娘の情報がわかる
                        Dim 母港配列ID As Integer = Component.KancollePortKanmusuSearch(MyDataClass.MyPort(選択艦隊).api_ship(count))
                        Dim 艦娘配列ID As Integer = Component.KancolleShipIdSearch(MyDataClass.MyKanmusu(母港配列ID).api_ship_id)





                        '出力するための一時保存
                        Dim 艦種 As String = String.Format("{0}", Component.KancolleStypeSearch(CommonDataClass.AllKanmusuData(艦娘配列ID).api_stype))
                        Dim 艦娘名 As String = String.Format("{0}", CommonDataClass.AllKanmusuData(艦娘配列ID).api_name)
                        Dim Lv As String = String.Format("{0}", MyDataClass.MyKanmusu(母港配列ID).api_lv)
                        Dim HP As String = String.Format("{0}/{1}", MyDataClass.MyKanmusu(母港配列ID).api_nowhp, MyDataClass.MyKanmusu(母港配列ID).api_maxhp)
                        Dim cond As String = String.Format("{0}", MyDataClass.MyKanmusu(母港配列ID).api_cond)

                        Dim 燃料上限 As Integer
                        Dim 弾薬上限 As Integer
                        Dim 燃料現在 As Integer = MyDataClass.MyKanmusu(母港配列ID).api_fuel
                        Dim 弾薬現在 As Integer = MyDataClass.MyKanmusu(母港配列ID).api_bull

                        'ケッコンしてるか否かで燃料弾薬の値が変わる
                        If MyDataClass.MyKanmusu(母港配列ID).api_lv > 99 Then
                            'ケッコンしている時
                            燃料上限 = Math.Floor(Double.Parse(CommonDataClass.AllKanmusuData(艦娘配列ID).api_fuel_max) * 0.85)
                            弾薬上限 = Math.Floor(Double.Parse(CommonDataClass.AllKanmusuData(艦娘配列ID).api_bull_max) * 0.85)
                            If 弾薬上限.Equals(0) Then
                                弾薬上限 = 1
                            End If
                            燃料現在 = Math.Floor(Double.Parse(MyDataClass.MyKanmusu(母港配列ID).api_fuel * 0.85))
                            弾薬現在 = Math.Floor(Double.Parse(MyDataClass.MyKanmusu(母港配列ID).api_bull * 0.85))
                        Else
                            'ケッコンしていない時
                            燃料上限 = CommonDataClass.AllKanmusuData(艦娘配列ID).api_fuel_max
                            弾薬上限 = CommonDataClass.AllKanmusuData(艦娘配列ID).api_bull_max
                        End If

                        Dim 燃料 As String = String.Format("{0}/{1}", 燃料現在, 燃料上限)
                        Dim 弾薬 As String = String.Format("{0}/{1}", 弾薬現在, 弾薬上限)


                        '装備の初期化
                        Dim 装備(5) As String
                        For cnt As Integer = 0 To 5
                            装備(cnt) = ""
                        Next

                        '装備に突っ込む
                        For cnt As Integer = 0 To 4
                            装備(cnt) = Component.KancolleEquipmentNameSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot(cnt))
                        Next

                        '補強増設も忘れずに
                        If Component.KancolleEquipmentNameSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot_ex) IsNot Nothing Then
                            装備(5) = Component.KancolleEquipmentNameSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot_ex)
                        End If



                        '制空値を出す
                        '制空値 = [(艦載機の対空値) × √(搭載数) ＋ 熟練度補正]　の総計　（[]は端数切り捨て）
                        'http://wikiwiki.jp/kancolle/?%B9%D2%B6%F5%C0%EF#AirSupremacy
                        For cnt As Integer = 0 To 4
                            Dim 対空値 As Long = Component.KancolleEquipmentAirspaceSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot(cnt))
                            Dim 搭載数 As Long = CommonDataClass.AllKanmusuData(艦娘配列ID).api_maxeq(cnt)
                            Dim 熟練補正 As Double = Component.KancolleEquipmentProficiencyCorrectionSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot(cnt))





                            If cnt <> 5 Then
                                制空値 += Double.Parse(対空値 * Math.Sqrt(搭載数) + 熟練補正)
                            End If

                        Next

                        '装備索敵値を出す
                        For cnt As Integer = 0 To 4
                            Component.艦これ索敵スコア.装備単体索敵値総和 += Component.艦これ索敵スコア.装備単体索敵値(MyDataClass.MyKanmusu(母港配列ID).api_slot(cnt))
                        Next

                        '素索敵を出す
                        Dim 素索敵 As Integer = MyDataClass.MyKanmusu(母港配列ID).api_sakuteki(0)
                        For cnt As Integer = 0 To 4
                            If Component.KancolleMyEquipmentIDSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot(cnt)) IsNot Nothing Then
                                Dim 所有装備配列番号 As Long = Component.KancolleMyEquipmentIDSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot(cnt))

                                If Component.KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id) IsNot Nothing Then
                                    Dim 装備一覧配列番号 As Long = Component.KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id)
                                    素索敵 -= CommonDataClass.AllEquipmentData(装備一覧配列番号).api_saku
                                End If

                            End If
                        Next


                        '補強増設も忘れずに
                        If Component.KancolleEquipmentNameSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot_ex) IsNot Nothing Then
                            If Component.KancolleMyEquipmentIDSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot_ex) IsNot Nothing Then
                                Dim 所有装備配列番号 As Long = Component.KancolleMyEquipmentIDSearch(MyDataClass.MyKanmusu(母港配列ID).api_slot_ex)
                                If Component.KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id) IsNot Nothing Then
                                    Dim 装備一覧配列番号 As Long = Component.KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id)
                                    素索敵 -= CommonDataClass.AllEquipmentData(装備一覧配列番号).api_saku
                                End If

                            End If
                        End If



                        Component.艦これ索敵スコア.艦娘索敵値平方根総和 += Math.Sqrt(素索敵)

                        '出撃艦数は数える
                        Component.艦これ索敵スコア.出撃艦数 += 1


                        'ここで出力！
                        '艦隊情報
                        一艦隊情報.Rows.Add(艦種, 艦娘名, Lv, HP, cond, 燃料, 弾薬, 装備(0), 装備(1), 装備(2), 装備(3), 装備(4), 装備(5))

                    End If



                Else
                    '表示しないため何も処理しない
                End If
            Next


            'ここで出力！

            '制空値
            Me.制空値.Text = 制空値.ToString

            '索敵スコア
            Me.合計索敵値.Text = Component.艦これ索敵スコア.判定式33計算()

            'デバッグ用
            'DebugWindow.Text = "分岐点係数" + Component.艦これ索敵スコア.分岐点係数.ToString + "装備単体索敵値総和" + Component.艦これ索敵スコア.装備単体索敵値総和.ToString + "艦娘索敵値平方根総和" + Component.艦これ索敵スコア.艦娘索敵値平方根総和.ToString + "司令部レベル" + Component.艦これ索敵スコア.司令部レベル.ToString + "出撃艦数" + Component.艦これ索敵スコア.出撃艦数.ToString
        End If


    End Sub

    Private Sub 艦隊選択_SelectedIndexChanged(sender As Object, e As EventArgs) Handles 艦隊選択.SelectedIndexChanged
        'どの艦隊を選んだか保存
        選択艦隊 = 艦隊選択.SelectedIndex



        'デバッグ用
#If DEBUG Then
        Debug.WriteLine(String.Format("選択艦隊:{0}", 選択艦隊))
#End If

    End Sub
End Class