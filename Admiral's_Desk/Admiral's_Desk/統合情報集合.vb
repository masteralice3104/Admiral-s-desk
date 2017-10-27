

Public Class 統合情報集合
    '説明
    '統合情報集合は、艦これの基礎データの集合です
    '基本的にデバッグ用途以外では表示しない予定です

    '構造体の宣言
    Public Structure 艦娘基礎情報
        Public api_id As Long          '艦娘固有id
        Public api_name As String      '艦娘名
        Public api_stype As Long       '艦種
        Public api_fuel_max As Long    '燃料
        Public api_bull_max As Long    '弾薬量
        Public api_slot_num As Long    '標準スロット数
    End Structure

    'どこからでも使えるようにしておく
    Public 艦娘基礎情報集合(1500) As 艦娘基礎情報

    '装備基礎情報の定義
    Public Structure 装備基礎情報
        Public api_id As Long           '装備固有ID
        Public api_sortno As Long       '装備を並べるときの順番
        Public api_name As String       '装備名
        Public api_type() As Long       '装備詳細
        'api_typeは必ず初期化時にReDimしてサイズを5にしなければならない!
        Public api_taik As Long         '耐久
        Public api_souk As Long         '装甲
        Public api_houg As Long         '火力
        Public api_raig As Long         '雷装
        Public api_soku As Long         '速度
        Public api_baku As Long         '爆装
        Public api_tyku As Long         '対空
        Public api_tais As Long         '対潜
        Public api_atap As Long         '?
        Public api_houm As Long         '砲撃命中
        Public api_raim As Long         '雷装命中
        Public api_kaih As Long         '回避
        Public api_houk As Long         '砲撃回避
        Public api_raik As Long         '雷撃回避
        Public api_bakk As Long         '爆撃回避
        Public api_saku As Long         '索敵
        Public api_sakb As Long         '?
        Public api_luck As Long         '運
        Public api_leng As Long         '射程
        Public api_rare As Long         'レア度
        Public api_broken() As Long     '解体したとき出て来る資材
        'api_brokenは必ず初期化時にReDimしてサイズを4にしなければならない!
        Public api_info As String       '説明文(html形式)

    End Structure

    'どこからでも使えるようにしておく
    Public 装備基礎情報集合(2047) As 装備基礎情報

    '装備情報
    Public Structure 装備情報
        Public api_id As Long           '装備番号
        Public api_slotitem_id As Long  '装備固有ID
        Public api_locked As Long       'ロックされているか否か
        Public api_level As Long        '改修度?
    End Structure

    'どこからでも使えるようにしておく
    Public 装備情報集合(1000) As 装備情報


    '母港情報は自艦隊の艦娘の情報です
    Public Structure 母港情報
        Public 艦娘番号 As Long
        Public 艦娘の特定 As Long
        Public 艦娘LV As Long
        Public 艦娘スロット装備() As Long
        Public 艦娘スロット搭載数() As Long
        Public 艦娘燃料状態 As Long
        Public 艦娘弾薬状態 As Long
        Public 艦娘現在HP As Long
        Public 艦娘最大HP As Long
        Public 艦娘スロット数 As Long
        Public 艦娘コンディション値 As Long
        Public 艦娘索敵値 As Long
        Public api_slot_ex As Long
    End Structure

    'どこからでも使えるようにしておく
    Public 母港情報集合(1000) As 母港情報


    'これは重要。更新許可になってからじゃないと読ませない
    Public 情報更新許可 As Boolean = False




    Private Sub 統合情報集合_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 統合情報集合更新
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 母港情報更新
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 装備基礎情報集合更新
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 装備情報集合更新
        情報更新許可 = False
        MyBase.Visible = False
    End Sub


    Private Sub 装備情報集合更新(oSession As Nekoxy.Session)
        'URL及びJSON解析
        If Component.KancolleReadJson(oSession, "/kcsapi/api_get_member/require_info") IsNot Nothing Then
            '////////////////////////////////////////////////////////////////////
            '
            '                   下準備
            '
            '////////////////////////////////////////////////////////////////////

            '大丈夫だったらJSONDataに突っ込む
            Dim JSONData As Newtonsoft.Json.Linq.JObject = Component.KancolleReadJson(oSession, "/kcsapi/api_get_member/require_info")

            '全装備数をJSONDataに突っ込む
            Dim 全装備数 As Long = JSONData("api_data")("api_slot_item").Count

            '配列をリサイズ(必須)
            ReDim 装備情報集合(全装備数)

            '////////////////////////////////////////////////////////////////////
            '
            '                   本処理
            '
            '////////////////////////////////////////////////////////////////////

            For count As Int32 = 0 To 全装備数 - 1
                装備情報集合(count).api_id = JSONData("api_data")("api_slot_item")(count)("api_id")
                装備情報集合(count).api_slotitem_id = JSONData("api_data")("api_slot_item")(count)("api_slotitem_id")
                装備情報集合(count).api_locked = JSONData("api_data")("api_slot_item")(count)("api_locked")
                装備情報集合(count).api_locked = JSONData("api_data")("api_slot_item")(count)("api_level")
            Next


        End If
    End Sub

    Private Sub 装備基礎情報集合更新(oSession As Nekoxy.Session)
        'URLとJSONの解析
        If Component.KancolleReadJson(oSession, "/kcsapi/api_start2") IsNot Nothing Then
            '////////////////////////////////////////////////////////////////////
            '
            '                   下準備
            '
            '////////////////////////////////////////////////////////////////////

            '大丈夫だったらJSONDataに突っ込む
            Dim JSONData As Newtonsoft.Json.Linq.JObject = Component.KancolleReadJson(oSession, "/kcsapi/api_start2")

            '装備数を変数に突っ込む
            Dim 全装備数 As Long = JSONData("api_data")("api_mst_slotitem").Count

            '配列をリサイズ(必須)
            ReDim 装備基礎情報集合(全装備数)

            '配列をリサイズ(必須)
            For count As Int32 = 0 To 全装備数 - 1
                ReDim 装備基礎情報集合(count).api_type(5)
                ReDim 装備基礎情報集合(count).api_broken(4)
            Next

            '////////////////////////////////////////////////////////////////////
            '
            '                   本処理
            '
            '////////////////////////////////////////////////////////////////////
            For count As Int32 = 0 To 全装備数 - 1
                '怒涛の代入
                'もし途中経路で書き換えられたら大変なデータが突っ込まれることになる

                装備基礎情報集合(count).api_id = JSONData("api_data")("api_mst_slotitem")(count)("api_id")
                装備基礎情報集合(count).api_sortno = JSONData("api_data")("api_mst_slotitem")(count)("api_sortno")
                装備基礎情報集合(count).api_name = JSONData("api_data")("api_mst_slotitem")(count)("api_name")
                装備基礎情報集合(count).api_taik = JSONData("api_data")("api_mst_slotitem")(count)("api_taik")
                装備基礎情報集合(count).api_souk = JSONData("api_data")("api_mst_slotitem")(count)("api_souk")
                装備基礎情報集合(count).api_houg = JSONData("api_data")("api_mst_slotitem")(count)("api_houg")
                装備基礎情報集合(count).api_raig = JSONData("api_data")("api_mst_slotitem")(count)("api_raig")
                装備基礎情報集合(count).api_soku = JSONData("api_data")("api_mst_slotitem")(count)("api_soku")
                装備基礎情報集合(count).api_baku = JSONData("api_data")("api_mst_slotitem")(count)("api_baku")
                装備基礎情報集合(count).api_tyku = JSONData("api_data")("api_mst_slotitem")(count)("api_tyku")
                装備基礎情報集合(count).api_tais = JSONData("api_data")("api_mst_slotitem")(count)("api_tais")
                装備基礎情報集合(count).api_atap = JSONData("api_data")("api_mst_slotitem")(count)("api_atap")
                装備基礎情報集合(count).api_houm = JSONData("api_data")("api_mst_slotitem")(count)("api_houm")
                装備基礎情報集合(count).api_raim = JSONData("api_data")("api_mst_slotitem")(count)("api_raim")
                装備基礎情報集合(count).api_houk = JSONData("api_data")("api_mst_slotitem")(count)("api_houk")
                装備基礎情報集合(count).api_raik = JSONData("api_data")("api_mst_slotitem")(count)("api_raik")
                装備基礎情報集合(count).api_bakk = JSONData("api_data")("api_mst_slotitem")(count)("api_bakk")
                装備基礎情報集合(count).api_saku = JSONData("api_data")("api_mst_slotitem")(count)("api_saku")
                装備基礎情報集合(count).api_sakb = JSONData("api_data")("api_mst_slotitem")(count)("api_sakb")
                装備基礎情報集合(count).api_luck = JSONData("api_data")("api_mst_slotitem")(count)("api_luck")
                装備基礎情報集合(count).api_leng = JSONData("api_data")("api_mst_slotitem")(count)("api_leng")
                装備基礎情報集合(count).api_rare = JSONData("api_data")("api_mst_slotitem")(count)("api_rare")
                装備基礎情報集合(count).api_info = JSONData("api_data")("api_mst_slotitem")(count)("api_info")

                For 第2ループ As Int32 = 0 To 4
                    装備基礎情報集合(count).api_type(第2ループ) = JSONData("api_data")("api_mst_slotitem")(count)("api_type")(第2ループ)
                Next
                For 第2ループ As Int32 = 0 To 3
                    装備基礎情報集合(count).api_broken(第2ループ) = JSONData("api_data")("api_mst_slotitem")(count)("api_broken")(第2ループ)
                Next
            Next


        End If

    End Sub

    Private Sub 統合情報集合更新(oSession As Nekoxy.Session)
        'とりあえずNekoxyからパスを受け取る
        Dim path As String = oSession.Request.PathAndQuery

        'JSONのデータもぶち込む
        Dim JSONtemporaryData As String = oSession.Response.BodyAsString

        If (path.StartsWith("/kcsapi/api_")) Then
            'JSONの先頭にある余計な文字を取り除く
            Dim JSONData As String = JSONtemporaryData.Substring(7)

            'JSON文字列→JSON形式データに復元
            Dim JSONObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)

            'これがJSONのデータを格納する部分だ
            If path.StartsWith("/kcsapi/api_start2") Then
                Dim 艦娘一覧配列数 As Long = JSONObject("api_data")("api_mst_ship").Count

                ReDim 艦娘基礎情報集合(艦娘一覧配列数)
                For count As Int32 = 0 To 艦娘一覧配列数 - 1
                    艦娘基礎情報集合(count).api_id = JSONObject("api_data")("api_mst_ship")(count)("api_id")
                    艦娘基礎情報集合(count).api_name = JSONObject("api_data")("api_mst_ship")(count)("api_name")
                    艦娘基礎情報集合(count).api_stype = JSONObject("api_data")("api_mst_ship")(count)("api_stype")
                    If JSONObject("api_data")("api_mst_ship")(count)("api_fuel_max") IsNot Nothing Then
                        艦娘基礎情報集合(count).api_fuel_max = JSONObject("api_data")("api_mst_ship")(count)("api_fuel_max")
                        艦娘基礎情報集合(count).api_bull_max = JSONObject("api_data")("api_mst_ship")(count)("api_bull_max")
                        艦娘基礎情報集合(count).api_slot_num = JSONObject("api_data")("api_mst_ship")(count)("api_slot_num")
                    Else
                        艦娘基礎情報集合(count).api_fuel_max = -1
                        艦娘基礎情報集合(count).api_bull_max = -1
                        艦娘基礎情報集合(count).api_slot_num = -1
                    End If

                Next
            ElseIf path.StartsWith("/kcsapi/api_req_hokyu/charge") Then
                For count As Int32 = 0 To JSONObject("api_data")("api_ship").Count - 1
                    For 艦娘検索 As Int32 = 0 To 母港情報集合.Count - 1
                        For JSON配列番号 As Int32 = 0 To JSONObject("api_data")("api_ship").Count - 1
                            Dim 艦娘番号 As Long = JSONObject("api_data")("api_ship")(JSON配列番号)("api_id")
                            If 母港情報集合(艦娘検索).艦娘番号 = 艦娘番号 Then
                                Dim 燃料状態 As Long = JSONObject("api_data")("api_ship")(JSON配列番号)("api_fuel")
                                Dim 弾薬状態 As Long = JSONObject("api_data")("api_ship")(JSON配列番号)("api_bull")

                                母港情報集合(艦娘検索).艦娘燃料状態 = 燃料状態
                                母港情報集合(艦娘検索).艦娘弾薬状態 = 弾薬状態
                            End If
                        Next
                    Next
                Next
            End If
        End If
    End Sub



    Private Sub 母港情報更新(oSession As Nekoxy.Session)
        'とりあえずNekoxyからパスを受け取る
        Dim path As String = oSession.Request.PathAndQuery

        'JSONのデータもぶち込む
        Dim JSONtemporaryData As String = oSession.Response.BodyAsString

        If (path.StartsWith("/kcsapi/api_")) Then
            'JSONの先頭にある余計な文字を取り除く
            Dim JSONData As String = JSONtemporaryData.Substring(7)

            'JSON文字列→JSON形式データに復元
            Dim JSONObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)

            'これがJSONのデータを表示する部分だ
            If path.StartsWith("/kcsapi/api_port/port") Then
                Dim 艦娘一覧配列数 As Long = JSONObject("api_data")("api_ship").Count
                ReDim 母港情報集合(艦娘一覧配列数)


                For count As Int32 = 0 To 艦娘一覧配列数 - 1
                    母港情報集合(count).艦娘番号 = JSONObject("api_data")("api_ship")(count)("api_id")

                    母港情報集合(count).艦娘の特定 = JSONObject("api_data")("api_ship")(count)("api_ship_id")

                    母港情報集合(count).艦娘LV = JSONObject("api_data")("api_ship")(count)("api_lv")

                    ReDim 母港情報集合(count).艦娘スロット装備(4)
                    母港情報集合(count).艦娘スロット装備(0) = JSONObject("api_data")("api_ship")(count)("api_slot")(0)
                    母港情報集合(count).艦娘スロット装備(1) = JSONObject("api_data")("api_ship")(count)("api_slot")(1)
                    母港情報集合(count).艦娘スロット装備(2) = JSONObject("api_data")("api_ship")(count)("api_slot")(2)
                    母港情報集合(count).艦娘スロット装備(3) = JSONObject("api_data")("api_ship")(count)("api_slot")(3)


                    If JSONObject("api_data")("api_ship")(count)("api_slot_ex") IsNot Nothing Then
                        母港情報集合(count).api_slot_ex = JSONObject("api_data")("api_ship")(count)("api_slot_ex")
                        母港情報集合(count).艦娘スロット装備(4) = JSONObject("api_data")("api_ship")(count)("api_slot_ex")
                    Else
                        母港情報集合(count).api_slot_ex = -1
                        母港情報集合(count).艦娘スロット装備(4) = -1
                    End If

                    ReDim 母港情報集合(count).艦娘スロット搭載数(4)
                    母港情報集合(count).艦娘スロット搭載数(0) = JSONObject("api_data")("api_ship")(count)("api_onslot")(0)
                    母港情報集合(count).艦娘スロット搭載数(1) = JSONObject("api_data")("api_ship")(count)("api_onslot")(1)
                    母港情報集合(count).艦娘スロット搭載数(2) = JSONObject("api_data")("api_ship")(count)("api_onslot")(2)
                    母港情報集合(count).艦娘スロット搭載数(3) = JSONObject("api_data")("api_ship")(count)("api_onslot")(3)
                    母港情報集合(count).艦娘スロット搭載数(4) = JSONObject("api_data")("api_ship")(count)("api_onslot")(4)



                    母港情報集合(count).艦娘燃料状態 = JSONObject("api_data")("api_ship")(count)("api_fuel")

                    母港情報集合(count).艦娘弾薬状態 = JSONObject("api_data")("api_ship")(count)("api_bull")

                    母港情報集合(count).艦娘現在HP = JSONObject("api_data")("api_ship")(count)("api_nowhp")

                    母港情報集合(count).艦娘最大HP = JSONObject("api_data")("api_ship")(count)("api_maxhp")

                    母港情報集合(count).艦娘スロット数 = JSONObject("api_data")("api_ship")(count)("api_slotnum")

                    母港情報集合(count).艦娘コンディション値 = JSONObject("api_data")("api_ship")(count)("api_cond")

                    母港情報集合(count).艦娘索敵値 = JSONObject("api_data")("api_ship")(count)("api_sakuteki")(0)

                Next

                情報更新許可 = Enabled

            End If
        End If

    End Sub




End Class