Public Class 艦隊情報

    '必要な変数
    Private 選択艦隊 As Long = 0
    Private 艦隊名(3) As String







    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.艦隊情報アクセス.Checked = False
    End Sub

    Private Sub 艦隊情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyDataClass.Events.MyPort, AddressOf 艦隊情報更新
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




        情報更新タイマ.Enabled = True

    End Sub

    Private Sub 情報更新タイマ_Tick(sender As Object, e As EventArgs) Handles 情報更新タイマ.Tick
        'まずDataGridViewの項目全消し
        一艦隊情報.Rows.Clear()

        '変なデータを読まないようにする
        If MyDataClass.MyPort(選択艦隊).api_ship IsNot Nothing Then
            'ここで必要な値を用意
            Dim 制空値 As Long = 0





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


                        'ここで出力！
                        一艦隊情報.Rows.Add(艦種, 艦娘名, Lv, HP, cond, 燃料, 弾薬, 装備(0), 装備(1), 装備(2), 装備(3), 装備(4), 装備(5))
                        Me.制空値.Text = 制空値.ToString







                    End If



                Else
                    '表示しないため何も処理しない
                End If
            Next
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