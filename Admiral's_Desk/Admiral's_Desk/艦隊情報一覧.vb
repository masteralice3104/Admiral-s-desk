Public Class 艦隊情報一覧

    Dim 現在艦隊選択 As Long = 1
    Public 艦隊名1 As String = ""
    Public 艦隊名2 As String = ""
    Public 艦隊名3 As String = ""
    Public 艦隊名4 As String = ""

    Dim 艦隊所属艦ID(23) As Long
    Dim 艦隊所属艦表示(23) As Boolean

    Private Sub 艦隊情報一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 艦隊情報更新
        For count = 0 To 23
            艦隊表示.Rows.Add("", "", "", "", "", "", "", "", "", "", "")
            艦隊表示.Rows.Item(count).Visible = False
        Next


        '変数の初期化
        For count = 0 To 23

            艦隊所属艦ID(count) = -1
            艦隊所属艦表示(count) = False
        Next

    End Sub

    'データ更新時に呼ばれる
    Private Sub 艦隊情報更新(oSession As Nekoxy.Session)
        'とりあえずNekoxyからパスを受け取る
        Dim path As String = oSession.Request.PathAndQuery

        'JSONのデータもぶち込む
        Dim JSONtemporaryData As String = oSession.Response.BodyAsString

        If (path.StartsWith("/kcsapi/api_")) Then
            'JSONの先頭にある余計な文字を取り除く
            Dim JSONData As String = JSONtemporaryData.Substring(7)

            'JSON文字列→JSON形式データに復元
            Dim JSONObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)

            '艦隊名表示操作部分
            If (path.StartsWith("/kcsapi/api_port/port")) Then
                艦隊名1 = String.Format("{0}", JSONObject("api_data")("api_deck_port")(0)("api_name"))
                艦隊名2 = String.Format("{0}", JSONObject("api_data")("api_deck_port")(1)("api_name"))
                艦隊名3 = String.Format("{0}", JSONObject("api_data")("api_deck_port")(2)("api_name"))
                艦隊名4 = String.Format("{0}", JSONObject("api_data")("api_deck_port")(3)("api_name"))
            End If

            '艦隊情報取得部分01
            If (path.StartsWith("/kcsapi/api_port/port")) Then
                For count = 0 To 23
                    Select Case count
                        Case 0 To 5
                            Dim IDString As String = Format("{0}", JSONObject("api_data")("api_deck_port")(0)("api_ship")(count Mod 6))
                            艦隊所属艦ID(count) = Long.Parse(IDString)
                        Case 6 To 11
                            Dim IDString As String = Format("{0}", JSONObject("api_data")("api_deck_port")(1)("api_ship")(count Mod 6))
                            艦隊所属艦ID(count) = Long.Parse(IDString)
                        Case 12 To 17
                            Dim IDString As String = Format("{0}", JSONObject("api_data")("api_deck_port")(2)("api_ship")(count Mod 6))
                            艦隊所属艦ID(count) = Long.Parse(IDString)
                        Case 18 To 23
                            Dim IDString As String = Format("{0}", JSONObject("api_data")("api_deck_port")(3)("api_ship")(count Mod 6))
                            艦隊所属艦ID(count) = Long.Parse(IDString)
                    End Select
                Next
            End If



        End If

    End Sub

    Private Sub 艦隊情報更新タイマー_Tick(sender As Object, e As EventArgs) Handles 艦隊情報更新タイマー.Tick
        艦隊番号1.Text = 艦隊名1
        艦隊番号2.Text = 艦隊名2
        艦隊番号3.Text = 艦隊名3
        艦隊番号4.Text = 艦隊名4



        For count = 0 To 23
            艦隊表示.Rows.Item(count).Cells(0).Value = 艦隊所属艦ID(count)

            If (艦隊所属艦ID(count) > 1) Then
                '検索！
                If 統合情報集合.情報更新許可 = Enabled Then
                    For search As Int32 = 0 To 統合情報集合.母港情報集合.Count - 1

                        'ここで検索するIDは「艦娘の入手順につけられるID」
                        If 艦隊所属艦ID(count) = 統合情報集合.母港情報集合(search).艦娘番号 Then

                            '検索して出てくるのは「艦娘を区別するためのID」なので、それをもとに名前を検索する
                            For 艦娘検索 As Int32 = 0 To 統合情報集合.艦娘基礎情報集合.Count - 1

                                '艦娘固有のIDが一致した場合
                                If 統合情報集合.艦娘基礎情報集合(艦娘検索).api_id = 統合情報集合.母港情報集合(search).艦娘の特定 Then

                                    '艦娘の名前
                                    艦隊表示.Rows.Item(count).Cells(1).Value = 統合情報集合.艦娘基礎情報集合(艦娘検索).api_name

                                    '艦娘の燃料
                                    Dim 艦娘燃料表示 As String = String.Format("{0}/{1}", 統合情報集合.母港情報集合(search).艦娘燃料状態, 統合情報集合.艦娘基礎情報集合(艦娘検索).api_fuel_max)
                                    艦隊表示.Rows.Item(count).Cells(5).Value = 艦娘燃料表示

                                    '艦娘の弾薬
                                    Dim 艦娘弾薬表示 As String = String.Format("{0}/{1}", 統合情報集合.母港情報集合(search).艦娘弾薬状態, 統合情報集合.艦娘基礎情報集合(艦娘検索).api_bull_max)
                                    艦隊表示.Rows.Item(count).Cells(6).Value = 艦娘弾薬表示

                                End If
                            Next

                            '艦娘のLV
                            艦隊表示.Rows.Item(count).Cells(2).Value = 統合情報集合.母港情報集合(search).艦娘LV

                            '艦娘のHP
                            Dim 艦娘HP表示 As String = String.Format("{0}/{1}", 統合情報集合.母港情報集合(search).艦娘現在HP, 統合情報集合.母港情報集合(search).艦娘最大HP)
                            艦隊表示.Rows.Item(count).Cells(3).Value = 艦娘HP表示

                            '艦娘のcond値
                            艦隊表示.Rows.Item(count).Cells(4).Value = 統合情報集合.母港情報集合(search).艦娘コンディション値

                            '艦娘の装備
                            For 第2ループ As Int32 = 0 To 4
                                Dim 艦娘装備番号 As Long = 統合情報集合.母港情報集合(search).艦娘スロット装備(第2ループ)

                                '装備番号が一致したものの名前を代入！
                                For 装備検索 As Int32 = 0 To 統合情報集合.装備情報集合.Count - 1
                                    If 統合情報集合.装備情報集合(装備検索).api_id = 艦娘装備番号 Then

                                        For 装備名前検索 As Int32 = 0 To 統合情報集合.装備基礎情報集合.Count - 1
                                            If 統合情報集合.装備基礎情報集合(装備名前検索).api_id = 統合情報集合.装備情報集合(装備検索).api_slotitem_id Then
                                                Dim 装備名 As String = String.Format("{0}", 統合情報集合.装備基礎情報集合(装備名前検索).api_name)
                                                艦隊表示.Rows.Item(count).Cells(7 + 第2ループ).Value = 装備名

                                            End If

                                        Next


                                    End If
                                Next
                            Next


                        End If

                    Next
                End If



                '最後にみえるようにする
                艦隊表示.Rows.Item(count).Visible = True

                'だが表示対象ではないときは隠す！
                Select Case count
                    Case 0 To 5
                        If Not 現在艦隊選択 = 1 Then
                            艦隊表示.Rows.Item(count).Visible = False
                        End If
                    Case 6 To 11
                        If Not 現在艦隊選択 = 2 Then
                            艦隊表示.Rows.Item(count).Visible = False
                        End If
                    Case 12 To 17
                        If Not 現在艦隊選択 = 3 Then
                            艦隊表示.Rows.Item(count).Visible = False
                        End If
                    Case 18 To 23
                        If Not 現在艦隊選択 = 4 Then
                            艦隊表示.Rows.Item(count).Visible = False
                        End If
                End Select
            Else
                '見させないよ
                艦隊表示.Rows.Item(count).Visible = False
            End If

        Next

    End Sub

    Private Sub 艦隊番号1_Click(sender As Object, e As EventArgs) Handles 艦隊番号1.Click
        現在艦隊選択 = 1
    End Sub

    Private Sub 艦隊番号2_Click(sender As Object, e As EventArgs) Handles 艦隊番号2.Click
        現在艦隊選択 = 2
    End Sub

    Private Sub 艦隊番号3_Click(sender As Object, e As EventArgs) Handles 艦隊番号3.Click
        現在艦隊選択 = 3
    End Sub

    Private Sub 艦隊番号4_Click(sender As Object, e As EventArgs) Handles 艦隊番号4.Click
        現在艦隊選択 = 4
    End Sub

    Private Sub 艦隊表示_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles 艦隊表示.CellContentClick

    End Sub
End Class