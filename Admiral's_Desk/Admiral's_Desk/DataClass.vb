'艦これから降ってきたデータに関する構造体
Public Structure DataClass
    '全員同じデータになるはずのところ
    Public Structure CommonData
        '艦娘データ
        Public Structure Kanmusu
            Public api_id As Long           '艦娘固有のID(艦娘の同定に使う)
            '1～1500が艦娘で1501～が深海棲艦の模様
            '1501～以降だとデータ仕様が異なる
            Public api_sortno As Long       'ソートNo
            Public api_name As String          '艦娘名
            Public api_yomi As String          '読み
            Public api_stype As Long        '艦種
            Public api_ctype As Long        '艦型
            Public api_afterlv As Long      '改造レベル
            Public api_aftershipid As String   '改造後のapi_id
            Public api_taik() As Long       '耐久([0]が初期値、[1]が最大値)
            'api_taikは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_souk() As Long       '装甲([0]が初期値、[1]が最大値)
            'api_soukは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_houg() As Long       '砲撃([0]が初期値、[1]が最大値)
            'api_hougは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_raig() As Long       '雷装([0]が初期値、[1]が最大値)
            'api_raigは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_tyku() As Long       '対空([0]が初期値、[1]が最大値)
            'api_tykuは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_luck() As Long       '運([0]が初期値、[1]が最大値)
            'api_luckは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_soku As Long         '速力
            Public api_leng As Long         '射程
            Public api_slot_num As Long     'スロット数
            Public api_maxeq() As Long      'スロットごとの搭載機数(航空機搭載艦のみ)
            'api_maxeqは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_buildtime As Long    '建造時間
            Public api_broken() As Long     '解体時の資源(燃,弾,鋼,ボの順)
            'api_brokenは必ず初期化時にReDimしてサイズを4にしなければならない!
            Public api_powup() As Long      '近代化改修の素材に使用したときの上昇値
            'api_powupは必ず初期化時にReDimしてサイズを4にしなければならない!
            Public api_backs As Long        '背景画像?
            Public api_getmes As String        '入手時メッセージ(html形式)
            Public api_afterfuel As Long    '改造時使用燃料
            Public api_afterbull As Long    '改造時使用弾薬
            Public api_fuel_max As Long     '燃料MAX
            Public api_bull_max As Long     '弾薬MAX
            'Public api_voicef As long       '?
            Public api_tais() As Long       '対潜([0]が初期値、[1]が最大値)
            'api_taisは必ず初期化時にReDimしてサイズを2にしなければならない!
            'api_taisはなにも定義がないとapi_tais = { 16 , 39 }となっている?
        End Structure

        '装備一覧
        Public Structure Equipment
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
            'Public api_atap As long         '?
            Public api_houm As Long         '砲撃命中
            Public api_raim As Long         '雷装命中
            Public api_kaih As Long         '回避
            Public api_houk As Long         '砲撃回避
            Public api_raik As Long         '雷撃回避
            Public api_bakk As Long         '爆撃回避
            Public api_saku As Long         '索敵
            ' Public api_sakb As long         '?
            Public api_luck As Long         '運
            Public api_leng As Long         '射程
            Public api_rare As Long         'レア度
            Public api_broken() As Long     '解体したとき出て来る資材
            'api_brokenは必ず初期化時にReDimしてサイズを4にしなければならない!
            Public api_info As String       '説明文(html形式)
        End Structure

        '艦種データ
        Public Structure ShipType
            Public api_id As Long
            Public api_name As String
        End Structure

        '遠征データ
        Public Structure Mission
            Public api_id As Long
            Public api_disp_no As String
            Public api_name As String
            Public api_details As String
        End Structure

        'マップデータ
        Public Structure MapInfo
            Public api_id As Long                       'マップID
            Public api_maparea_id As Long               'api_noと組み合わせてマップ名(通称)を表現。
            Public api_name As String                   'マップ名
            Public api_no As Long                       'string.format("{0}-{1}",api_maparea_id,api_no)って感じに使う
            Public api_max_maphp As Long                'マップのHP。HP制じゃないマップはnullになっている
            Public api_required_defeat_count As Long    'マップ突破までに必要な回数

        End Structure
    End Structure

    '人それぞれで違うデータに関するもの
    Public Structure IndividualData

        '提督情報
        Public Structure Admiral
            Public api_member_id As String          '提督毎の固有の数字
            Public api_nickname As String           '提督の名前                      これいる
            'Public api_nickname_id As String        '?
            'Public api_active_flag As long       '?
            'Public api_starttime As long         'ログイン日時
            Public api_level As Long             '提督レベル                      これいる
            Public api_rank As Long              '提督階級                        これいる
            Public api_experience As Long        '提督経験値                      これいる
            'Public api_fleetname As Object         'なんかnullが入ってるので無視
            Public api_comment As String            'コメント
            'Public api_comment_id As String         '?
            Public api_max_chara As Long         '最大所持艦娘数                  これいる
            Public api_max_slotitem As Long      '最大所持装備数                  これいる
            'Public api_max_kagu As long          '?
            'Public api_playtime As long          '?
            Public api_tutorial As Long          'チュートリアル実行中フラグ?
            Public api_furniture() As Long       '現在設置してる家具
            'api_furnitureは必ず初期化時にReDimしてサイズを6にしなければならない!
            Public api_count_deck As Long        '開放済艦隊                      これいる
            Public api_count_kdock As Long       '開放済建造ドック                これいる
            Public api_count_ndock As Long       '開放済入渠ドック                これいる
            Public api_fcoin As Long             '家具コイン
            Public api_st_win As Long            '戦闘勝利数?
            Public api_st_lose As Long           '戦闘敗北数?
            Public api_ms_count As Long          '遠征回数
            Public api_ms_success As Long        '遠征失敗数
            Public api_pt_win As Long            '演習勝利数
            Public api_pt_lose As Long           '演習敗北数
            'Public api_pt_challenged As long     '?
            'Public api_pt_challenged_win As long '?
            'Public api_firstflag As long         '?
            Public api_tutorial_progress As Long 'チュートリアル進行度
            'Public api_pvp() As long             '文字的に不穏な香りがするやつ
            Public api_medals As Long            '甲勲章数
            Public api_large_dock As Long        '補強増設数
        End Structure

        '資材情報
        Public Structure Resource
            Public Fuel As Long                         '燃料          これいる
            Public Bullet As Long                       '弾薬          これいる
            Public Steel As Long                        '鋼材          これいる
            Public Bauxite As Long                      'ボーキサイト  これいる
            Public HighspeedBuildingMaterial As Long    '高速建造材    これいる
            Public HighspeedRepairingMaterial As Long   '高速修復材    これいる
            Public DevelopmentMaterial As Long          '開発資材      これいる
            Public ImprovementMaterial As Long          '改修資材      これいる
        End Structure

        '入渠ドック
        Public Structure RepairingDock
            'Public api_member_id As long             '提督固有ID?
            Public api_id As Long                    'ドック番号
            Public api_state As Long                 '状態
            Public api_ship_id As Long               'ドックに入ってる艦
            Public api_complete_time As Long         '終了時間
            'Public api_complete_time_str As String      '?
            'Public api_item1 As long                 '?
            'Public api_item2 As long                 '?
            'Public api_item3 As long                 '?
            'Public api_item4 As long                 '?
        End Structure

        '艦娘情報
        Public Structure Kanmusu
            Public api_id As Long            '番号
            Public api_sortno As Long        'ソートNo
            Public api_ship_id As Long       '艦娘識別の番号(同定に使用)
            Public api_lv As Long            'Lv
            Public api_exp() As Long         '経験値
            'api_expは必ず初期化時にReDimしてサイズを3にしなければならない!
            Public api_nowhp As Long         '現在HP
            Public api_maxhp As Long         '最大HP
            Public api_soku As Long          '速力
            Public api_leng As Long          '射程
            Public api_slot() As Long        'スロットの状態(なぜか5こある)(※180326追記：武蔵改二は5スロット)
            'api_slotは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_onslot() As Long      'スロット搭載数
            'api_onslotは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_slot_ex As Long       '補強増設の状態
            'Public api_kyouka() As Long      '?
            'Public api_backs As Long         '?
            Public api_fuel As Long          '燃料
            Public api_bull As Long          '弾薬
            Public api_slotnum As Long       'スロット数
            Public api_ndock_time As Long    '入渠時間
            'Public api_ndock_item() As Long  '?
            'Public api_srate As Long         '?
            Public api_cond As Long          'cond値
            Public api_karyoku() As Long     '火力
            'api_karyokuは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_raisou() As Long      '雷装
            'api_raisouは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_taiku() As Long       '対空
            'api_taikuは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_soukou() As Long      '装甲
            'api_soukouは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_kaihi() As Long       '回避
            'api_kaihiは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_taisen() As Long      '対潜
            'api_taisenは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_sakuteki() As Long    '索敵
            'api_sakutekiは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_lucky() As Long       '運
            'api_luckyは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_locked As Long        'ロックの有無
            Public api_locked_equip As Long  'ロック装備の有無
        End Structure

        '装備情報
        Public Structure Equipment
            Public api_id As Long           '装備番号
            Public api_slotitem_id As Long  '装備固有ID(どの装備かの同定に使用)
            Public api_locked As Long       'ロックされているか否か
            Public api_level As Long        '改修度
            Public api_alv As Long          '熟練度
        End Structure

        '艦隊情報
        Public Structure Port
            'Public api_member_id As long    '?
            Public api_id As Long           '艦隊の番号(1～4)
            Public api_name As String       '艦隊の名称
            'Public api_name_id As long      '?
            Public api_mission() As Long    '?
            'api_missionは必ず初期化時にReDimしてサイズを4にしなければならない！
            Public api_flagship As Long     '旗艦?
            Public api_ship() As Long       '艦隊に所属している艦娘の番号
            'api_shipは必ず初期化時にReDimしてサイズを6にしなければならない！
        End Structure

        'マップ情報
        Public Structure MapInfo
            Public api_id As Long           'マップ通称(1-1とか
            Public api_cleared As Long      'クリアしたか否か
            Public api_exboss_flag As Long  'EXか否か?
            Public api_defeat_count As Long '削った回数?
        End Structure

        '開発情報
        Public Structure Development
            Public EquipmentID As Integer
        End Structure

        '建造情報
        Public Structure Building
            Public api_state As Long
            Public api_created_ship_id As Long
            Public api_complete_time As Long
            Public api_item1 As Long
            Public api_item2 As Long
            Public api_item3 As Long
            Public api_item4 As Long
            Public api_item5 As Long
        End Structure


    End Structure

End Structure


Public Class CommonDataClass
    '共通データ
    Public Shared AllKanmusuData(2048) As DataClass.CommonData.Kanmusu         '艦娘の基本データとりあえず(2048)
    Public Shared AllEquipmentData(4096) As DataClass.CommonData.Equipment     '装備の基本データとりあえず(4096)
    Public Shared ShipType(21) As DataClass.CommonData.ShipType                '艦種データ
    Public Shared Mission(50) As DataClass.CommonData.Mission                  '遠征データ
    Public Shared MapInfo(127) As DataClass.CommonData.MapInfo                  'マップデータ
End Class

Public Class MyDataClass
    '個別データ
    'ここは共通データです
    'ここのデータをもとに数値操作を行うべし
    Public Shared Admiral As DataClass.IndividualData.Admiral                  '提督データ
    Public Shared MyResource As DataClass.IndividualData.Resource              '資源資材
    Public Shared MyKanmusu(1024) As DataClass.IndividualData.Kanmusu          '艦娘データとりあえず(1024)
    Public Shared MyEquipment(4096) As DataClass.IndividualData.Equipment      '所持装備とりあえず(4096)
    Public Shared MyPort(3) As DataClass.IndividualData.Port                   '艦隊4つぶん
    Public Shared RepairingDock(4) As DataClass.IndividualData.RepairingDock   '入渠ドック情報
    Public Shared MapInfo(64) As DataClass.IndividualData.MapInfo              'マップ情報
    Public Shared Development As DataClass.IndividualData.Development          '開発情報
    Public Shared Building(3) As DataClass.IndividualData.Building             '建造情報

    'イベントフラグのためのクラス
    'このへんから→http://rucio.a.la9.jp/main/dotnet/shokyu/standard49.htm
    Public Class Events

        '更新イベント
        Public Shared Event Info_Refresh(ByVal sender As Object, ByVal e As EventArgs)

        Public Sub Info_Refresh_Events()
            RaiseEvent Info_Refresh(Me, New EventArgs)
        End Sub

    End Class

    'イベントフラグの実体
    Public Shared WithEvents EventsEpoch As New MyDataClass.Events

End Class

Public Class URLDataClass
    Public Const kcsapi As String = "/kcsapi/api_"
    Public Const api_start2 As String = "/kcsapi/api_start2"
    Public Const port As String = "/kcsapi/api_port/port"
    Public Const ndock As String = "/kcsapi/api_get_member/ndock"
    Public Const get_incentive As String = "/kcsapi/api_req_member/get_incentive"
    Public Const require_info As String = "/kcsapi/api_get_member/require_info"
    Public Const material As String = "/kcsapi/api_get_member/material"
    Public Const clearitemget As String = "/kcsapi/api_req_quest/clearitemget"
    Public Const questlist As String = "/kcsapi/api_get_member/questlist"
    Public Const start As String = "/kcsapi/api_req_quest/start"
    Public Const map_info As String = "/kcsapi/api_get_member/mapinfo"
    Public Const charge As String = "/kcsapi/api_req_hokyu/charge"
    Public Const deck As String = "/kcsapi/api_get_member/deck"
    Public Const ship3 As String = "/kcsapi/api_get_member/ship3"
    Public Const ship_deck As String = "/kcsapi/api_get_member/ship_deck"
    Public Const createitem As String = "/kcsapi/api_req_kousyou/createitem"
    Public Const kdock As String = "/kcsapi/api_get_member/kdock"
End Class



Public Class StructureOperationClass

    '艦これの共通データ更新
    'これは1回しか起こらないはず
    '無論更新した場合は除く
    Public Shared Sub KancolleCommonDataReset(oSession As Nekoxy.Session)
        'api_start2のjsonであることを確認する
        If Component.KancolleReadJson(oSession, URLDataClass.api_start2) IsNot Nothing Then

            'JSONをメモリに保存する
            Dim JsonData As Newtonsoft.Json.Linq.JObject = Component.KancolleReadJson(oSession, URLDataClass.api_start2)


            '艦娘数を元に配列の調整
            ReDim CommonDataClass.AllKanmusuData(JsonData("api_data")("api_mst_ship").Count - 1)

            'AllKanmusuDataはDataclass.CommonData.Kanmusu型なので個々の要素の配列を調整する必要がある
            'よって必要な配列の調整を行う
            For count As Integer = 0 To CommonDataClass.AllKanmusuData.Count - 1
                ReDim CommonDataClass.AllKanmusuData(count).api_taik(2)
                ReDim CommonDataClass.AllKanmusuData(count).api_souk(2)
                ReDim CommonDataClass.AllKanmusuData(count).api_houg(2)
                ReDim CommonDataClass.AllKanmusuData(count).api_raig(2)
                ReDim CommonDataClass.AllKanmusuData(count).api_tyku(2)
                ReDim CommonDataClass.AllKanmusuData(count).api_luck(2)
                ReDim CommonDataClass.AllKanmusuData(count).api_maxeq(5)
                ReDim CommonDataClass.AllKanmusuData(count).api_broken(4)
                ReDim CommonDataClass.AllKanmusuData(count).api_powup(4)
                ReDim CommonDataClass.AllKanmusuData(count).api_tais(2)
            Next

            '装備数をもとに配列の調整
            ReDim CommonDataClass.AllEquipmentData(JsonData("api_data")("api_mst_slotitem").Count - 1)

            'AllEquipmentDataはDataclass.CommonData.Equipment型なので個々の要素の配列の調整の要有り
            For Count As Integer = 0 To CommonDataClass.AllEquipmentData.Count - 1
                ReDim CommonDataClass.AllEquipmentData(Count).api_type(5)
                ReDim CommonDataClass.AllEquipmentData(Count).api_broken(4)
            Next

            '艦種データの配列調整
            ReDim CommonDataClass.ShipType(JsonData("api_data")("api_mst_stype").Count - 1)



            'JsonObjectの準備
            Dim JsonObject As Object = Component.KancolleReadJson(oSession, URLDataClass.api_start2)

            'ここで実際の艦娘データの読み込み
            If JsonObject("api_data")("api_mst_ship")(0) IsNot Nothing Then
                For count As Integer = 0 To JsonObject("api_data")("api_mst_ship").Count - 1

                    '艦娘基本情報

                    '以下7項目は艦娘・深海棲艦共通のデータ
                    CommonDataClass.AllKanmusuData(count).api_id = JsonObject("api_data")("api_mst_ship")(count)("api_id")
                    CommonDataClass.AllKanmusuData(count).api_name = JsonObject("api_data")("api_mst_ship")(count)("api_name")
                    CommonDataClass.AllKanmusuData(count).api_yomi = JsonObject("api_data")("api_mst_ship")(count)("api_yomi")
                    CommonDataClass.AllKanmusuData(count).api_stype = JsonObject("api_data")("api_mst_ship")(count)("api_stype")
                    CommonDataClass.AllKanmusuData(count).api_ctype = JsonObject("api_data")("api_mst_ship")(count)("api_ctype")
                    CommonDataClass.AllKanmusuData(count).api_soku = JsonObject("api_data")("api_mst_ship")(count)("api_soku")

                    '以下は艦娘のみデータ
                    If CommonDataClass.AllKanmusuData(count).api_id < 1501 Then
                        CommonDataClass.AllKanmusuData(count).api_slot_num = JsonObject("api_data")("api_mst_ship")(count)("api_slot_num")
                        CommonDataClass.AllKanmusuData(count).api_sortno = JsonObject("api_data")("api_mst_ship")(count)("api_sortno")
                        CommonDataClass.AllKanmusuData(count).api_afterlv = JsonObject("api_data")("api_mst_ship")(count)("api_afterlv")
                        CommonDataClass.AllKanmusuData(count).api_aftershipid = JsonObject("api_data")("api_mst_ship")(count)("api_aftershipid")
                        CommonDataClass.AllKanmusuData(count).api_taik(0) = JsonObject("api_data")("api_mst_ship")(count)("api_taik")(0)
                        CommonDataClass.AllKanmusuData(count).api_taik(1) = JsonObject("api_data")("api_mst_ship")(count)("api_taik")(1)
                        CommonDataClass.AllKanmusuData(count).api_souk(0) = JsonObject("api_data")("api_mst_ship")(count)("api_souk")(0)
                        CommonDataClass.AllKanmusuData(count).api_souk(1) = JsonObject("api_data")("api_mst_ship")(count)("api_souk")(1)
                        CommonDataClass.AllKanmusuData(count).api_houg(0) = JsonObject("api_data")("api_mst_ship")(count)("api_houg")(0)
                        CommonDataClass.AllKanmusuData(count).api_houg(1) = JsonObject("api_data")("api_mst_ship")(count)("api_houg")(1)
                        CommonDataClass.AllKanmusuData(count).api_raig(0) = JsonObject("api_data")("api_mst_ship")(count)("api_raig")(0)
                        CommonDataClass.AllKanmusuData(count).api_raig(1) = JsonObject("api_data")("api_mst_ship")(count)("api_raig")(1)
                        CommonDataClass.AllKanmusuData(count).api_tyku(0) = JsonObject("api_data")("api_mst_ship")(count)("api_tyku")(0)
                        CommonDataClass.AllKanmusuData(count).api_tyku(1) = JsonObject("api_data")("api_mst_ship")(count)("api_tyku")(1)
                        CommonDataClass.AllKanmusuData(count).api_luck(0) = JsonObject("api_data")("api_mst_ship")(count)("api_luck")(0)
                        CommonDataClass.AllKanmusuData(count).api_luck(1) = JsonObject("api_data")("api_mst_ship")(count)("api_luck")(1)
                        CommonDataClass.AllKanmusuData(count).api_leng = JsonObject("api_data")("api_mst_ship")(count)("api_leng")
                        CommonDataClass.AllKanmusuData(count).api_maxeq(0) = JsonObject("api_data")("api_mst_ship")(count)("api_maxeq")(0)
                        CommonDataClass.AllKanmusuData(count).api_maxeq(1) = JsonObject("api_data")("api_mst_ship")(count)("api_maxeq")(1)
                        CommonDataClass.AllKanmusuData(count).api_maxeq(2) = JsonObject("api_data")("api_mst_ship")(count)("api_maxeq")(2)
                        CommonDataClass.AllKanmusuData(count).api_maxeq(3) = JsonObject("api_data")("api_mst_ship")(count)("api_maxeq")(3)
                        CommonDataClass.AllKanmusuData(count).api_maxeq(4) = JsonObject("api_data")("api_mst_ship")(count)("api_maxeq")(4)
                        CommonDataClass.AllKanmusuData(count).api_buildtime = JsonObject("api_data")("api_mst_ship")(count)("api_buildtime")
                        CommonDataClass.AllKanmusuData(count).api_broken(0) = JsonObject("api_data")("api_mst_ship")(count)("api_broken")(0)
                        CommonDataClass.AllKanmusuData(count).api_broken(1) = JsonObject("api_data")("api_mst_ship")(count)("api_broken")(1)
                        CommonDataClass.AllKanmusuData(count).api_broken(2) = JsonObject("api_data")("api_mst_ship")(count)("api_broken")(2)
                        CommonDataClass.AllKanmusuData(count).api_broken(3) = JsonObject("api_data")("api_mst_ship")(count)("api_broken")(3)
                        CommonDataClass.AllKanmusuData(count).api_powup(0) = JsonObject("api_data")("api_mst_ship")(count)("api_powup")(0)
                        CommonDataClass.AllKanmusuData(count).api_powup(1) = JsonObject("api_data")("api_mst_ship")(count)("api_powup")(1)
                        CommonDataClass.AllKanmusuData(count).api_powup(2) = JsonObject("api_data")("api_mst_ship")(count)("api_powup")(2)
                        CommonDataClass.AllKanmusuData(count).api_powup(3) = JsonObject("api_data")("api_mst_ship")(count)("api_powup")(3)
                        CommonDataClass.AllKanmusuData(count).api_backs = JsonObject("api_data")("api_mst_ship")(count)("api_backs")
                        CommonDataClass.AllKanmusuData(count).api_getmes = JsonObject("api_data")("api_mst_ship")(count)("api_getmes")
                        CommonDataClass.AllKanmusuData(count).api_afterfuel = JsonObject("api_data")("api_mst_ship")(count)("api_afterfuel")
                        CommonDataClass.AllKanmusuData(count).api_afterbull = JsonObject("api_data")("api_mst_ship")(count)("api_afterbull")
                        CommonDataClass.AllKanmusuData(count).api_fuel_max = JsonObject("api_data")("api_mst_ship")(count)("api_fuel_max")
                        CommonDataClass.AllKanmusuData(count).api_bull_max = JsonObject("api_data")("api_mst_ship")(count)("api_bull_max")

                        'api_taisのみ特殊な扱いをするので別記
                        If JsonObject("api_data")("api_mst_ship")(count)("api_tais") IsNot Nothing Then
                            CommonDataClass.AllKanmusuData(count).api_tais(0) = 16
                            CommonDataClass.AllKanmusuData(count).api_tais(1) = 39

                            For cnt As Integer = 0 To JsonObject("api_data")("api_mst_ship")(count)("api_tais").count - 1
                                CommonDataClass.AllKanmusuData(count).api_tais(cnt) = JsonObject("api_data")("api_mst_ship")(count)("api_tais")(cnt)
                            Next
                        Else
                            CommonDataClass.AllKanmusuData(count).api_tais(0) = 16
                            CommonDataClass.AllKanmusuData(count).api_tais(1) = 39
                        End If

                    End If
                Next
            End If

            'ここで実際の装備データの読み込み
            If JsonObject("api_data")("api_mst_slotitem")(0) IsNot Nothing Then
                For count As Integer = 0 To JsonObject("api_data")("api_mst_slotitem").count - 1
                    CommonDataClass.AllEquipmentData(count).api_id = JsonObject("api_data")("api_mst_slotitem")(count)("api_id")
                    CommonDataClass.AllEquipmentData(count).api_sortno = JsonObject("api_data")("api_mst_slotitem")(count)("api_sortno")
                    CommonDataClass.AllEquipmentData(count).api_name = JsonObject("api_data")("api_mst_slotitem")(count)("api_name")
                    CommonDataClass.AllEquipmentData(count).api_type(0) = JsonObject("api_data")("api_mst_slotitem")(count)("api_type")(0)
                    CommonDataClass.AllEquipmentData(count).api_type(1) = JsonObject("api_data")("api_mst_slotitem")(count)("api_type")(1)
                    CommonDataClass.AllEquipmentData(count).api_type(2) = JsonObject("api_data")("api_mst_slotitem")(count)("api_type")(2)
                    CommonDataClass.AllEquipmentData(count).api_type(3) = JsonObject("api_data")("api_mst_slotitem")(count)("api_type")(3)
                    CommonDataClass.AllEquipmentData(count).api_type(4) = JsonObject("api_data")("api_mst_slotitem")(count)("api_type")(4)
                    CommonDataClass.AllEquipmentData(count).api_taik = JsonObject("api_data")("api_mst_slotitem")(count)("api_taik")
                    CommonDataClass.AllEquipmentData(count).api_souk = JsonObject("api_data")("api_mst_slotitem")(count)("api_souk")
                    CommonDataClass.AllEquipmentData(count).api_houg = JsonObject("api_data")("api_mst_slotitem")(count)("api_houg")
                    CommonDataClass.AllEquipmentData(count).api_raig = JsonObject("api_data")("api_mst_slotitem")(count)("api_raig")
                    CommonDataClass.AllEquipmentData(count).api_soku = JsonObject("api_data")("api_mst_slotitem")(count)("api_soku")
                    CommonDataClass.AllEquipmentData(count).api_baku = JsonObject("api_data")("api_mst_slotitem")(count)("api_baku")
                    CommonDataClass.AllEquipmentData(count).api_tyku = JsonObject("api_data")("api_mst_slotitem")(count)("api_tyku")
                    CommonDataClass.AllEquipmentData(count).api_tais = JsonObject("api_data")("api_mst_slotitem")(count)("api_tais")
                    CommonDataClass.AllEquipmentData(count).api_houm = JsonObject("api_data")("api_mst_slotitem")(count)("api_houm")
                    CommonDataClass.AllEquipmentData(count).api_raim = JsonObject("api_data")("api_mst_slotitem")(count)("api_raim")
                    CommonDataClass.AllEquipmentData(count).api_kaih = JsonObject("api_data")("api_mst_slotitem")(count)("api_kaih")
                    CommonDataClass.AllEquipmentData(count).api_houk = JsonObject("api_data")("api_mst_slotitem")(count)("api_houk")
                    CommonDataClass.AllEquipmentData(count).api_raik = JsonObject("api_data")("api_mst_slotitem")(count)("api_raik")
                    CommonDataClass.AllEquipmentData(count).api_bakk = JsonObject("api_data")("api_mst_slotitem")(count)("api_bakk")
                    CommonDataClass.AllEquipmentData(count).api_saku = JsonObject("api_data")("api_mst_slotitem")(count)("api_saku")
                    CommonDataClass.AllEquipmentData(count).api_luck = JsonObject("api_data")("api_mst_slotitem")(count)("api_luck")
                    CommonDataClass.AllEquipmentData(count).api_leng = JsonObject("api_data")("api_mst_slotitem")(count)("api_leng")
                    CommonDataClass.AllEquipmentData(count).api_rare = JsonObject("api_data")("api_mst_slotitem")(count)("api_rare")
                    CommonDataClass.AllEquipmentData(count).api_broken(0) = JsonObject("api_data")("api_mst_slotitem")(count)("api_broken")(0)
                    CommonDataClass.AllEquipmentData(count).api_broken(1) = JsonObject("api_data")("api_mst_slotitem")(count)("api_broken")(1)
                    CommonDataClass.AllEquipmentData(count).api_broken(2) = JsonObject("api_data")("api_mst_slotitem")(count)("api_broken")(2)
                    CommonDataClass.AllEquipmentData(count).api_broken(3) = JsonObject("api_data")("api_mst_slotitem")(count)("api_broken")(3)
                    CommonDataClass.AllEquipmentData(count).api_info = JsonObject("api_data")("api_mst_slotitem")(count)("api_info")

                Next
            End If


            '艦種データの読込
            If JsonObject("api_data")("api_mst_stype")(0) IsNot Nothing Then
                For count As Integer = 0 To JsonObject("api_data")("api_mst_stype").count - 1
                    CommonDataClass.ShipType(count).api_id = JsonObject("api_data")("api_mst_stype")(count)("api_id")
                    CommonDataClass.ShipType(count).api_name = JsonObject("api_data")("api_mst_stype")(count)("api_name")

                Next
            End If

            '遠征データの読込
            If JsonObject("api_data")("api_mst_mission")(0) IsNot Nothing Then
                ReDim CommonDataClass.Mission(JsonObject("api_data")("api_mst_mission").count - 1)
                For count As Integer = 0 To JsonObject("api_data")("api_mst_mission").count - 1
                    CommonDataClass.Mission(count).api_id = JsonObject("api_data")("api_mst_mission")(count)("api_id")
                    CommonDataClass.Mission(count).api_name = JsonObject("api_data")("api_mst_mission")(count)("api_name")
                    CommonDataClass.Mission(count).api_details = JsonObject("api_data")("api_mst_mission")(count)("api_details")
                    CommonDataClass.Mission(count).api_disp_no = JsonObject("api_data")("api_mst_mission")(count)("api_disp_no")
                Next
            End If

            'マップデータの読み込み
            If JsonObject("api_data")("api_mst_mapinfo")(0) IsNot Nothing Then

                ReDim CommonDataClass.MapInfo(JsonObject("api_data")("api_mst_mapinfo").count - 1)
                For count As Integer = 0 To JsonObject("api_data")("api_mst_mapinfo").count - 1
                    CommonDataClass.MapInfo(count).api_id = JsonObject("api_data")("api_mst_mapinfo")(count)("api_id")
                    CommonDataClass.MapInfo(count).api_maparea_id = JsonObject("api_data")("api_mst_mapinfo")(count)("api_maparea_id")
                    CommonDataClass.MapInfo(count).api_no = JsonObject("api_data")("api_mst_mapinfo")(count)("api_no")
                    If JsonObject("api_data")("api_mst_mapinfo")(count)("api_max_maphp").value IsNot Nothing Then
                        CommonDataClass.MapInfo(count).api_max_maphp = JsonObject("api_data")("api_mst_mapinfo")(count)("api_max_maphp")
                    End If

                    If JsonObject("api_data")("api_mst_mapinfo")(count)("api_required_defeat_count").value IsNot Nothing Then
                        CommonDataClass.MapInfo(count).api_required_defeat_count = JsonObject("api_data")("api_mst_mapinfo")(count)("api_required_defeat_count")
                    End If
                Next
            End If
        End If



    End Sub




    '提督情報の構造体初期化
    Private Sub AdmiralDataStructureReset()
        '配列のReDimのみ必要なのでする
        ReDim MyDataClass.Admiral.api_furniture(6)
    End Sub


    'Jsonのデータを構造体にぶち込む
    'Public Shared Sub JsonDataInputToStructure(ByVal JsonObject As Newtonsoft.Json.Linq.JObject, ByVal path As String)
    '■　引値
    '   JsonObject  Newtonsoft.Json.Linq.JObject型の変数。Jsonをパースしただけのオブジェクトでいいと思われる
    '   path        String形で表されるURLの一部データ。/kcsapiから始まるアレ

    Public Shared Sub JsonDataInputToStructure(ByVal JsonObject As Newtonsoft.Json.Linq.JObject, ByVal path As String)

        '一つ一つ存在確認をする
        'api_data 存在時
        If JsonObject("api_data") IsNot Nothing Then

            '提督データの取得
            'URLで大体判別
            If path = URLDataClass.port Then

                'api_data -> api_basic 存在時
                'なんか/kcsapi/api_get_member/ndockらへんがapi_basicに変なデータ(なぜそこに配列型が混ざる？)をもってるみたいので先にURLで刎ねないとだめっぽいです。ゆるさん
                If JsonObject("api_data")("api_basic") IsNot Nothing Then

                    If JsonObject("api_data")("api_basic")("api_member_id") IsNot Nothing Then MyDataClass.Admiral.api_member_id = JsonObject("api_data")("api_basic")("api_member_id")
                    If JsonObject("api_data")("api_basic")("api_nickname") IsNot Nothing Then MyDataClass.Admiral.api_nickname = JsonObject("api_data")("api_basic")("api_nickname")
                    If JsonObject("api_data")("api_basic")("api_level") IsNot Nothing Then MyDataClass.Admiral.api_level = JsonObject("api_data")("api_basic")("api_level")
                    If JsonObject("api_data")("api_basic")("api_rank") IsNot Nothing Then MyDataClass.Admiral.api_rank = JsonObject("api_data")("api_basic")("api_rank")
                    If JsonObject("api_data")("api_basic")("api_experience") IsNot Nothing Then MyDataClass.Admiral.api_experience = JsonObject("api_data")("api_basic")("api_experience")
                    If JsonObject("api_data")("api_basic")("api_comment") IsNot Nothing Then MyDataClass.Admiral.api_comment = JsonObject("api_data")("api_basic")("api_comment")
                    If JsonObject("api_data")("api_basic")("api_max_chara") IsNot Nothing Then MyDataClass.Admiral.api_max_chara = JsonObject("api_data")("api_basic")("api_max_chara")
                    If JsonObject("api_data")("api_basic")("api_max_slotitem") IsNot Nothing Then MyDataClass.Admiral.api_max_slotitem = JsonObject("api_data")("api_basic")("api_max_slotitem")
                    If JsonObject("api_data")("api_basic")("api_tutorial") IsNot Nothing Then MyDataClass.Admiral.api_tutorial = JsonObject("api_data")("api_basic")("api_tutorial")
                    If JsonObject("api_data")("api_basic")("api_count_deck") IsNot Nothing Then MyDataClass.Admiral.api_count_deck = JsonObject("api_data")("api_basic")("api_count_deck")
                    If JsonObject("api_data")("api_basic")("api_count_kdock") IsNot Nothing Then MyDataClass.Admiral.api_count_kdock = JsonObject("api_data")("api_basic")("api_count_kdock")
                    If JsonObject("api_data")("api_basic")("api_count_ndock") IsNot Nothing Then MyDataClass.Admiral.api_count_ndock = JsonObject("api_data")("api_basic")("api_count_ndock")
                    If JsonObject("api_data")("api_basic")("api_fcoin") IsNot Nothing Then MyDataClass.Admiral.api_fcoin = JsonObject("api_data")("api_basic")("api_fcoin")
                    If JsonObject("api_data")("api_basic")("api_st_win") IsNot Nothing Then MyDataClass.Admiral.api_st_win = JsonObject("api_data")("api_basic")("api_st_win")
                    If JsonObject("api_data")("api_basic")("api_st_lose") IsNot Nothing Then MyDataClass.Admiral.api_st_lose = JsonObject("api_data")("api_basic")("api_st_lose")
                    If JsonObject("api_data")("api_basic")("api_ms_count") IsNot Nothing Then MyDataClass.Admiral.api_ms_count = JsonObject("api_data")("api_basic")("api_ms_count")
                    If JsonObject("api_data")("api_basic")("api_ms_success") IsNot Nothing Then MyDataClass.Admiral.api_ms_success = JsonObject("api_data")("api_basic")("api_ms_success")
                    If JsonObject("api_data")("api_basic")("api_pt_win") IsNot Nothing Then MyDataClass.Admiral.api_pt_win = JsonObject("api_data")("api_basic")("api_pt_win")
                    If JsonObject("api_data")("api_basic")("api_pt_lose") IsNot Nothing Then MyDataClass.Admiral.api_pt_lose = JsonObject("api_data")("api_basic")("api_pt_lose")
                    If JsonObject("api_data")("api_basic")("api_tutorial_progress") IsNot Nothing Then MyDataClass.Admiral.api_tutorial_progress = JsonObject("api_data")("api_basic")("api_tutorial_progress")
                    If JsonObject("api_data")("api_basic")("api_medals") IsNot Nothing Then MyDataClass.Admiral.api_medals = JsonObject("api_data")("api_basic")("api_medals")
                    If JsonObject("api_data")("api_basic")("api_large_dock") IsNot Nothing Then MyDataClass.Admiral.api_large_dock = JsonObject("api_data")("api_basic")("api_large_dock")
                    If JsonObject("api_data")("api_basic")("api_furniture") IsNot Nothing Then
                        ReDim MyDataClass.Admiral.api_furniture(6)
                        For count As Integer = 0 To 5
                            MyDataClass.Admiral.api_furniture(count) = JsonObject("api_data")("api_basic")("api_furniture")(count)
                        Next
                    End If



                End If
            End If


            '資材データの取得
            'URLで大体判別
            If path = URLDataClass.port Then

                If JsonObject("api_data")("api_material") IsNot Nothing Then

                    If JsonObject("api_data")("api_material")(0) IsNot Nothing Then MyDataClass.MyResource.Fuel = JsonObject("api_data")("api_material")(0)("api_value")
                    If JsonObject("api_data")("api_material")(1) IsNot Nothing Then MyDataClass.MyResource.Bullet = JsonObject("api_data")("api_material")(1)("api_value")
                    If JsonObject("api_data")("api_material")(2) IsNot Nothing Then MyDataClass.MyResource.Steel = JsonObject("api_data")("api_material")(2)("api_value")
                    If JsonObject("api_data")("api_material")(3) IsNot Nothing Then MyDataClass.MyResource.Bauxite = JsonObject("api_data")("api_material")(3)("api_value")
                    If JsonObject("api_data")("api_material")(4) IsNot Nothing Then MyDataClass.MyResource.HighspeedBuildingMaterial = JsonObject("api_data")("api_material")(4)("api_value")
                    If JsonObject("api_data")("api_material")(5) IsNot Nothing Then MyDataClass.MyResource.HighspeedRepairingMaterial = JsonObject("api_data")("api_material")(5)("api_value")
                    If JsonObject("api_data")("api_material")(6) IsNot Nothing Then MyDataClass.MyResource.DevelopmentMaterial = JsonObject("api_data")("api_material")(6)("api_value")
                    If JsonObject("api_data")("api_material")(7) IsNot Nothing Then MyDataClass.MyResource.ImprovementMaterial = JsonObject("api_data")("api_material")(7)("api_value")

                End If


            End If
            If path = URLDataClass.charge Then
                If JsonObject("api_data")("api_material") IsNot Nothing Then

                    If JsonObject("api_data")("api_material")(0) IsNot Nothing Then MyDataClass.MyResource.Fuel = JsonObject("api_data")("api_material")(0)
                    If JsonObject("api_data")("api_material")(1) IsNot Nothing Then MyDataClass.MyResource.Bullet = JsonObject("api_data")("api_material")(1)
                    If JsonObject("api_data")("api_material")(2) IsNot Nothing Then MyDataClass.MyResource.Steel = JsonObject("api_data")("api_material")(2)
                    If JsonObject("api_data")("api_material")(3) IsNot Nothing Then MyDataClass.MyResource.Bauxite = JsonObject("api_data")("api_material")(3)
                End If

            End If




            '入渠データの取得
            'URLにより読み取る箇所が異なる
            If path = URLDataClass.ndock Then
                If JsonObject("api_data")(0) IsNot Nothing Then
                    For count As Integer = 0 To 3
                        MyDataClass.RepairingDock(count).api_id = JsonObject("api_data")(count)("api_id")
                        MyDataClass.RepairingDock(count).api_state = JsonObject("api_data")(count)("api_state")
                        MyDataClass.RepairingDock(count).api_ship_id = JsonObject("api_data")(count)("api_ship_id")
                        MyDataClass.RepairingDock(count).api_complete_time = JsonObject("api_data")(count)("api_complete_time")
                    Next
                End If
            End If
            If path = URLDataClass.port Then
                If JsonObject("api_data")("api_ndock") IsNot Nothing Then
                    For count As Integer = 0 To 3
                        If JsonObject("api_data")("api_ndock")(count)("api_id") IsNot Nothing Then MyDataClass.RepairingDock(count).api_id = JsonObject("api_data")("api_ndock")(count)("api_id")
                        If JsonObject("api_data")("api_ndock")(count)("api_state") IsNot Nothing Then MyDataClass.RepairingDock(count).api_state = JsonObject("api_data")("api_ndock")(count)("api_state")
                        If JsonObject("api_data")("api_ndock")(count)("api_ship_id") IsNot Nothing Then MyDataClass.RepairingDock(count).api_ship_id = JsonObject("api_data")("api_ndock")(count)("api_ship_id")
                        If JsonObject("api_data")("api_ndock")(count)("api_complete_time") IsNot Nothing Then MyDataClass.RepairingDock(count).api_complete_time = JsonObject("api_data")("api_ndock")(count)("api_complete_time")
                    Next

                End If

            End If



            '保有艦娘データの取得


            If path = URLDataClass.port Then
                Dim dir As String = "api_ship"


                'まずは艦娘データ配列の調整
                ReDim MyDataClass.MyKanmusu(JsonObject("api_data")("api_ship").Count - 1)
                '代入
                For count As Int32 = 0 To JsonObject("api_data")(Dir).Count - 1

                    If JsonObject("api_data")(Dir)(count)("api_id") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_id = JsonObject("api_data")(Dir)(count)("api_id")
                    If JsonObject("api_data")(Dir)(count)("api_sortno") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_sortno = JsonObject("api_data")(Dir)(count)("api_sortno")
                    If JsonObject("api_data")(Dir)(count)("api_ship_id") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_ship_id = JsonObject("api_data")(Dir)(count)("api_ship_id")
                    If JsonObject("api_data")(Dir)(count)("api_lv") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_lv = JsonObject("api_data")(Dir)(count)("api_lv")
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_exp(2)
                    If JsonObject("api_data")(Dir)(count)("api_exp")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_exp(0) = JsonObject("api_data")(Dir)(count)("api_exp")(0)
                    If JsonObject("api_data")(Dir)(count)("api_exp")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_exp(1) = JsonObject("api_data")(Dir)(count)("api_exp")(1)
                    If JsonObject("api_data")(Dir)(count)("api_exp")(2) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_exp(2) = JsonObject("api_data")(Dir)(count)("api_exp")(2)
                    If JsonObject("api_data")(Dir)(count)("api_nowhp") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_nowhp = JsonObject("api_data")(Dir)(count)("api_nowhp")
                    If JsonObject("api_data")(Dir)(count)("api_maxhp") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_maxhp = JsonObject("api_data")(Dir)(count)("api_maxhp")
                    If JsonObject("api_data")(Dir)(count)("api_soku") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_soku = JsonObject("api_data")(Dir)(count)("api_soku")
                    If JsonObject("api_data")(Dir)(count)("api_leng") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_leng = JsonObject("api_data")(Dir)(count)("api_leng")
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_slot(4)
                    If JsonObject("api_data")(Dir)(count)("api_slot")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slot(0) = JsonObject("api_data")(Dir)(count)("api_slot")(0)
                    If JsonObject("api_data")(Dir)(count)("api_slot")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slot(1) = JsonObject("api_data")(Dir)(count)("api_slot")(1)
                    If JsonObject("api_data")(Dir)(count)("api_slot")(2) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slot(2) = JsonObject("api_data")(Dir)(count)("api_slot")(2)
                    If JsonObject("api_data")(Dir)(count)("api_slot")(3) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slot(3) = JsonObject("api_data")(Dir)(count)("api_slot")(3)
                    If JsonObject("api_data")(Dir)(count)("api_slot")(4) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slot(4) = JsonObject("api_data")(Dir)(count)("api_slot")(4)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_onslot(4)
                    If JsonObject("api_data")(Dir)(count)("api_onslot")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_onslot(0) = JsonObject("api_data")(Dir)(count)("api_onslot")(0)
                    If JsonObject("api_data")(Dir)(count)("api_onslot")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_onslot(1) = JsonObject("api_data")(Dir)(count)("api_onslot")(1)
                    If JsonObject("api_data")(Dir)(count)("api_onslot")(2) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_onslot(2) = JsonObject("api_data")(Dir)(count)("api_onslot")(2)
                    If JsonObject("api_data")(Dir)(count)("api_onslot")(3) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_onslot(3) = JsonObject("api_data")(Dir)(count)("api_onslot")(3)
                    If JsonObject("api_data")(Dir)(count)("api_onslot")(4) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_onslot(4) = JsonObject("api_data")(Dir)(count)("api_onslot")(4)
                    If JsonObject("api_data")(Dir)(count)("api_slot_ex") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slot_ex = JsonObject("api_data")(Dir)(count)("api_slot_ex")
                    If JsonObject("api_data")(Dir)(count)("api_fuel") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_fuel = JsonObject("api_data")(Dir)(count)("api_fuel")
                    If JsonObject("api_data")(Dir)(count)("api_bull") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_bull = JsonObject("api_data")(Dir)(count)("api_bull")
                    If JsonObject("api_data")(Dir)(count)("api_slotnum") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_slotnum = JsonObject("api_data")(Dir)(count)("api_slotnum")
                    If JsonObject("api_data")(Dir)(count)("api_ndock_time") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_ndock_time = JsonObject("api_data")(Dir)(count)("api_ndock_time")
                    If JsonObject("api_data")(Dir)(count)("api_cond") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_cond = JsonObject("api_data")(Dir)(count)("api_cond")
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_karyoku(1)
                    If JsonObject("api_data")(Dir)(count)("api_karyoku")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_karyoku(0) = JsonObject("api_data")(Dir)(count)("api_karyoku")(0)
                    If JsonObject("api_data")(Dir)(count)("api_karyoku")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_karyoku(1) = JsonObject("api_data")(Dir)(count)("api_karyoku")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_raisou(1)
                    If JsonObject("api_data")(Dir)(count)("api_raisou")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_raisou(0) = JsonObject("api_data")(Dir)(count)("api_raisou")(0)
                    If JsonObject("api_data")(Dir)(count)("api_raisou")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_raisou(1) = JsonObject("api_data")(Dir)(count)("api_raisou")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_taiku(1)
                    If JsonObject("api_data")(Dir)(count)("api_taiku")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_taiku(0) = JsonObject("api_data")(Dir)(count)("api_taiku")(0)
                    If JsonObject("api_data")(Dir)(count)("api_taiku")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_taiku(1) = JsonObject("api_data")(Dir)(count)("api_taiku")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_soukou(1)
                    If JsonObject("api_data")(Dir)(count)("api_soukou")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_soukou(0) = JsonObject("api_data")(Dir)(count)("api_soukou")(0)
                    If JsonObject("api_data")(Dir)(count)("api_soukou")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_soukou(1) = JsonObject("api_data")(Dir)(count)("api_soukou")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_kaihi(1)
                    If JsonObject("api_data")(Dir)(count)("api_kaihi")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_kaihi(0) = JsonObject("api_data")(Dir)(count)("api_kaihi")(0)
                    If JsonObject("api_data")(Dir)(count)("api_kaihi")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_kaihi(1) = JsonObject("api_data")(Dir)(count)("api_kaihi")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_taisen(1)
                    If JsonObject("api_data")(Dir)(count)("api_taisen")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_taisen(0) = JsonObject("api_data")(Dir)(count)("api_taisen")(0)
                    If JsonObject("api_data")(Dir)(count)("api_taisen")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_taisen(1) = JsonObject("api_data")(Dir)(count)("api_taisen")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_sakuteki(1)
                    If JsonObject("api_data")(Dir)(count)("api_sakuteki")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_sakuteki(0) = JsonObject("api_data")(Dir)(count)("api_sakuteki")(0)
                    If JsonObject("api_data")(Dir)(count)("api_sakuteki")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_sakuteki(1) = JsonObject("api_data")(Dir)(count)("api_sakuteki")(1)
                    ReDim Preserve MyDataClass.MyKanmusu(count).api_lucky(1)
                    If JsonObject("api_data")(Dir)(count)("api_lucky")(0) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_lucky(0) = JsonObject("api_data")(Dir)(count)("api_lucky")(0)
                    If JsonObject("api_data")(Dir)(count)("api_lucky")(1) IsNot Nothing Then MyDataClass.MyKanmusu(count).api_lucky(1) = JsonObject("api_data")(Dir)(count)("api_lucky")(1)
                    If JsonObject("api_data")(Dir)(count)("api_locked") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_locked = JsonObject("api_data")(Dir)(count)("api_locked")
                    If JsonObject("api_data")(Dir)(count)("api_locked_equip") IsNot Nothing Then MyDataClass.MyKanmusu(count).api_locked_equip = JsonObject("api_data")(Dir)(count)("api_locked_equip")

                Next

            End If
            If path = URLDataClass.ship3 Or path = URLDataClass.ship_deck Then
                Dim dir As String = "api_ship_data"


                For cnt As Integer = 0 To JsonObject("api_data")(dir).Count - 1
                    If JsonObject("api_data")(dir)(cnt)("api_id") IsNot Nothing Then
                        'id一致艦娘を探す
                        If Component.KancollePortKanmusuSearch(JsonObject("api_data")(dir)(cnt)("api_id")) IsNot Nothing Then
                            Dim 艦娘配列番号 As Integer = Component.KancollePortKanmusuSearch(JsonObject("api_data")(dir)(cnt)("api_id"))


                            If JsonObject("api_data")(dir)(cnt)("api_id") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_id = JsonObject("api_data")(dir)(cnt)("api_id")
                            If JsonObject("api_data")(dir)(cnt)("api_sortno") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_sortno = JsonObject("api_data")(dir)(cnt)("api_sortno")
                            If JsonObject("api_data")(dir)(cnt)("api_ship_id") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_ship_id = JsonObject("api_data")(dir)(cnt)("api_ship_id")
                            If JsonObject("api_data")(dir)(cnt)("api_lv") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_lv = JsonObject("api_data")(dir)(cnt)("api_lv")
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_exp(2)
                            If JsonObject("api_data")(dir)(cnt)("api_exp")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_exp(0) = JsonObject("api_data")(dir)(cnt)("api_exp")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_exp")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_exp(1) = JsonObject("api_data")(dir)(cnt)("api_exp")(1)
                            If JsonObject("api_data")(dir)(cnt)("api_exp")(2) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_exp(2) = JsonObject("api_data")(dir)(cnt)("api_exp")(2)
                            If JsonObject("api_data")(dir)(cnt)("api_nowhp") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_nowhp = JsonObject("api_data")(dir)(cnt)("api_nowhp")
                            If JsonObject("api_data")(dir)(cnt)("api_maxhp") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_maxhp = JsonObject("api_data")(dir)(cnt)("api_maxhp")
                            If JsonObject("api_data")(dir)(cnt)("api_soku") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_soku = JsonObject("api_data")(dir)(cnt)("api_soku")
                            If JsonObject("api_data")(dir)(cnt)("api_leng") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_leng = JsonObject("api_data")(dir)(cnt)("api_leng")
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_slot(4)
                            If JsonObject("api_data")(dir)(cnt)("api_slot")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slot(0) = JsonObject("api_data")(dir)(cnt)("api_slot")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_slot")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slot(1) = JsonObject("api_data")(dir)(cnt)("api_slot")(1)
                            If JsonObject("api_data")(dir)(cnt)("api_slot")(2) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slot(2) = JsonObject("api_data")(dir)(cnt)("api_slot")(2)
                            If JsonObject("api_data")(dir)(cnt)("api_slot")(3) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slot(3) = JsonObject("api_data")(dir)(cnt)("api_slot")(3)
                            If JsonObject("api_data")(dir)(cnt)("api_slot")(4) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slot(4) = JsonObject("api_data")(dir)(cnt)("api_slot")(4)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(4)
                            If JsonObject("api_data")(dir)(cnt)("api_onslot")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(0) = JsonObject("api_data")(dir)(cnt)("api_onslot")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_onslot")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(1) = JsonObject("api_data")(dir)(cnt)("api_onslot")(1)
                            If JsonObject("api_data")(dir)(cnt)("api_onslot")(2) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(2) = JsonObject("api_data")(dir)(cnt)("api_onslot")(2)
                            If JsonObject("api_data")(dir)(cnt)("api_onslot")(3) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(3) = JsonObject("api_data")(dir)(cnt)("api_onslot")(3)
                            If JsonObject("api_data")(dir)(cnt)("api_onslot")(4) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(4) = JsonObject("api_data")(dir)(cnt)("api_onslot")(4)
                            If JsonObject("api_data")(dir)(cnt)("api_slot_ex") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slot_ex = JsonObject("api_data")(dir)(cnt)("api_slot_ex")
                            If JsonObject("api_data")(dir)(cnt)("api_fuel") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_fuel = JsonObject("api_data")(dir)(cnt)("api_fuel")
                            If JsonObject("api_data")(dir)(cnt)("api_bull") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_bull = JsonObject("api_data")(dir)(cnt)("api_bull")
                            If JsonObject("api_data")(dir)(cnt)("api_slotnum") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_slotnum = JsonObject("api_data")(dir)(cnt)("api_slotnum")
                            If JsonObject("api_data")(dir)(cnt)("api_ndock_time") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_ndock_time = JsonObject("api_data")(dir)(cnt)("api_ndock_time")
                            If JsonObject("api_data")(dir)(cnt)("api_cond") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_cond = JsonObject("api_data")(dir)(cnt)("api_cond")
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_karyoku(1)
                            If JsonObject("api_data")(dir)(cnt)("api_karyoku")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_karyoku(0) = JsonObject("api_data")(dir)(cnt)("api_karyoku")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_karyoku")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_karyoku(1) = JsonObject("api_data")(dir)(cnt)("api_karyoku")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_raisou(1)
                            If JsonObject("api_data")(dir)(cnt)("api_raisou")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_raisou(0) = JsonObject("api_data")(dir)(cnt)("api_raisou")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_raisou")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_raisou(1) = JsonObject("api_data")(dir)(cnt)("api_raisou")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_taiku(1)
                            If JsonObject("api_data")(dir)(cnt)("api_taiku")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_taiku(0) = JsonObject("api_data")(dir)(cnt)("api_taiku")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_taiku")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_taiku(1) = JsonObject("api_data")(dir)(cnt)("api_taiku")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_soukou(1)
                            If JsonObject("api_data")(dir)(cnt)("api_soukou")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_soukou(0) = JsonObject("api_data")(dir)(cnt)("api_soukou")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_soukou")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_soukou(1) = JsonObject("api_data")(dir)(cnt)("api_soukou")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_kaihi(1)
                            If JsonObject("api_data")(dir)(cnt)("api_kaihi")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_kaihi(0) = JsonObject("api_data")(dir)(cnt)("api_kaihi")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_kaihi")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_kaihi(1) = JsonObject("api_data")(dir)(cnt)("api_kaihi")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_taisen(1)
                            If JsonObject("api_data")(dir)(cnt)("api_taisen")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_taisen(0) = JsonObject("api_data")(dir)(cnt)("api_taisen")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_taisen")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_taisen(1) = JsonObject("api_data")(dir)(cnt)("api_taisen")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_sakuteki(1)
                            If JsonObject("api_data")(dir)(cnt)("api_sakuteki")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_sakuteki(0) = JsonObject("api_data")(dir)(cnt)("api_sakuteki")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_sakuteki")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_sakuteki(1) = JsonObject("api_data")(dir)(cnt)("api_sakuteki")(1)
                            ReDim Preserve MyDataClass.MyKanmusu(艦娘配列番号).api_lucky(1)
                            If JsonObject("api_data")(dir)(cnt)("api_lucky")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_lucky(0) = JsonObject("api_data")(dir)(cnt)("api_lucky")(0)
                            If JsonObject("api_data")(dir)(cnt)("api_lucky")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_lucky(1) = JsonObject("api_data")(dir)(cnt)("api_lucky")(1)
                            If JsonObject("api_data")(dir)(cnt)("api_locked") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_locked = JsonObject("api_data")(dir)(cnt)("api_locked")
                            If JsonObject("api_data")(dir)(cnt)("api_locked_equip") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_locked_equip = JsonObject("api_data")(dir)(cnt)("api_locked_equip")
                        End If

                    End If

                Next


            End If
            If path = URLDataClass.charge Then
                Dim dir As String = "api_ship"



                '代入
                For count As Int32 = 0 To JsonObject("api_data")(dir).Count - 1

                    Dim 艦娘配列番号 As Integer = -1
                    If JsonObject("api_data")(dir)(count)("api_id") IsNot Nothing Then
                        艦娘配列番号 = Component.KancollePortKanmusuSearch(JsonObject("api_data")(dir)(count)("api_id"))
                        If JsonObject("api_data")(dir)(count)("api_id") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_id = JsonObject("api_data")(dir)(count)("api_id")
                        ReDim Preserve MyDataClass.MyKanmusu(count).api_onslot(4)
                        If JsonObject("api_data")(dir)(count)("api_onslot")(0) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(0) = JsonObject("api_data")(dir)(count)("api_onslot")(0)
                        If JsonObject("api_data")(dir)(count)("api_onslot")(1) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(1) = JsonObject("api_data")(dir)(count)("api_onslot")(1)
                        If JsonObject("api_data")(dir)(count)("api_onslot")(2) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(2) = JsonObject("api_data")(dir)(count)("api_onslot")(2)
                        If JsonObject("api_data")(dir)(count)("api_onslot")(3) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(3) = JsonObject("api_data")(dir)(count)("api_onslot")(3)
                        If JsonObject("api_data")(dir)(count)("api_onslot")(4) IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_onslot(4) = JsonObject("api_data")(dir)(count)("api_onslot")(4)
                        If JsonObject("api_data")(dir)(count)("api_fuel") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_fuel = JsonObject("api_data")(dir)(count)("api_fuel")
                        If JsonObject("api_data")(dir)(count)("api_bull") IsNot Nothing Then MyDataClass.MyKanmusu(艦娘配列番号).api_bull = JsonObject("api_data")(dir)(count)("api_bull")
                    Else
                        Continue For
                    End If
                Next
            End If



            '保有艦隊データの取得
            If path = URLDataClass.port Then
                If JsonObject("api_data")("api_deck_port") IsNot Nothing Then
                    For count As Integer = 0 To 3
                        If JsonObject("api_data")("api_deck_port")(count)("api_id") IsNot Nothing Then MyDataClass.MyPort(count).api_id = JsonObject("api_data")("api_deck_port")(count)("api_id")
                        If JsonObject("api_data")("api_deck_port")(count)("api_name") IsNot Nothing Then MyDataClass.MyPort(count).api_name = JsonObject("api_data")("api_deck_port")(count)("api_name")
                        If JsonObject("api_data")("api_deck_port")(count)("api_ship") IsNot Nothing Then
                            ReDim Preserve MyDataClass.MyPort(count).api_ship(JsonObject("api_data")("api_deck_port")(count)("api_ship").Count - 1)
                            For cnt As Integer = 0 To JsonObject("api_data")("api_deck_port")(count)("api_ship").Count - 1
                                MyDataClass.MyPort(count).api_ship(cnt) = JsonObject("api_data")("api_deck_port")(count)("api_ship")(cnt)
                            Next
                        End If
                        If JsonObject("api_data")("api_deck_port")(count)("api_mission") IsNot Nothing Then
                            ReDim MyDataClass.MyPort(count).api_mission(3)
                            For cnt As Integer = 0 To JsonObject("api_data")("api_deck_port")(count)("api_mission").Count - 1
                                MyDataClass.MyPort(count).api_mission(cnt) = JsonObject("api_data")("api_deck_port")(count)("api_mission")(cnt)
                            Next
                        End If
                    Next

                End If
            End If
            If path = URLDataClass.deck Then
                If JsonObject("api_data")(0) IsNot Nothing Then
                    For count As Integer = 0 To 3
                        If JsonObject("api_data")(count)("api_mission") IsNot Nothing Then
                            ReDim MyDataClass.MyPort(count).api_mission(3)
                            For cnt As Integer = 0 To 3
                                MyDataClass.MyPort(count).api_mission(cnt) = JsonObject("api_data")(count)("api_mission")(cnt)
                            Next
                        End If
                    Next

                End If
            End If


            'require_infoであることを確認する
            If path = URLDataClass.require_info Then
                If JsonObject("api_data")("api_slot_item")(0) IsNot Nothing Then
                    '所有装備についての配列調整
                    ReDim MyDataClass.MyEquipment(JsonObject("api_data")("api_slot_item").Count - 1)

                    '読込
                    For count As Integer = 0 To JsonObject("api_data")("api_slot_item").Count - 1
                        If JsonObject("api_data")("api_slot_item")(count)("api_id") IsNot Nothing Then MyDataClass.MyEquipment(count).api_id = JsonObject("api_data")("api_slot_item")(count)("api_id")
                        If JsonObject("api_data")("api_slot_item")(count)("api_level") IsNot Nothing Then MyDataClass.MyEquipment(count).api_level = JsonObject("api_data")("api_slot_item")(count)("api_level")
                        If JsonObject("api_data")("api_slot_item")(count)("api_locked") IsNot Nothing Then MyDataClass.MyEquipment(count).api_locked = JsonObject("api_data")("api_slot_item")(count)("api_locked")
                        If JsonObject("api_data")("api_slot_item")(count)("api_slotitem_id") IsNot Nothing Then MyDataClass.MyEquipment(count).api_slotitem_id = JsonObject("api_data")("api_slot_item")(count)("api_slotitem_id")
                        If JsonObject("api_data")("api_slot_item")(count)("api_alv") IsNot Nothing Then
                            MyDataClass.MyEquipment(count).api_alv = JsonObject("api_data")("api_slot_item")(count)("api_alv")
                        Else
                            MyDataClass.MyEquipment(count).api_alv = 0
                        End If
                    Next

                End If
            End If


            'mapinfoであることを確認
            If path = URLDataClass.map_info Then
                If JsonObject("api_data")("api_map_info")(0) IsNot Nothing Then
                    'マップ状態についての配列調整
                    ReDim MyDataClass.MapInfo(JsonObject("api_data")("api_map_info").Count - 1)

                    '読込
                    For count As Integer = 0 To JsonObject("api_data")("api_map_info").Count - 1
                        If JsonObject("api_data")("api_map_info")(count)("api_id") IsNot Nothing Then MyDataClass.MapInfo(count).api_id = JsonObject("api_data")("api_map_info")(count)("api_id")
                        If JsonObject("api_data")("api_map_info")(count)("api_cleared") IsNot Nothing Then MyDataClass.MapInfo(count).api_cleared = JsonObject("api_data")("api_map_info")(count)("api_cleared")
                        If JsonObject("api_data")("api_map_info")(count)("api_exboss_flag") IsNot Nothing Then MyDataClass.MapInfo(count).api_exboss_flag = JsonObject("api_data")("api_map_info")(count)("api_exboss_flag")
                        If JsonObject("api_data")("api_map_info")(count)("api_defeat_count") IsNot Nothing Then
                            MyDataClass.MapInfo(count).api_defeat_count = JsonObject("api_data")("api_map_info")(count)("api_defeat_count")
                        Else
                            MyDataClass.MapInfo(count).api_defeat_count = Nothing
                        End If

                    Next
                End If
            End If

            '開発情報取得
            If path = URLDataClass.createitem Then
                If JsonObject("api_data") IsNot Nothing Then
                    If JsonObject("api_data")("api_fdata") IsNot Nothing Then
                        '開発失敗時
                        MyDataClass.Development.EquipmentID = -1
                    End If
                    If JsonObject("api_data")("api_slot_item") IsNot Nothing Then
                        '開発成功
                        MyDataClass.Development.EquipmentID = JsonObject("api_data")("api_slot_item")("api_slotitem_id")
                    End If
                End If
            End If


            '建造ドックの取得
            If path = URLDataClass.kdock Then
                For count As Integer = 0 To JsonObject("api_data").Count - 1
                    If JsonObject("api_data")(count)("api_state") IsNot Nothing Then MyDataClass.Building(count).api_state = JsonObject("api_data")(count)("api_state")
                    If JsonObject("api_data")(count)("api_created_ship_id") IsNot Nothing Then MyDataClass.Building(count).api_created_ship_id = JsonObject("api_data")(count)("api_created_ship_id")
                    If JsonObject("api_data")(count)("api_complete_time") IsNot Nothing Then MyDataClass.Building(count).api_complete_time = JsonObject("api_data")(count)("api_complete_time")
                    If JsonObject("api_data")(count)("api_item1") IsNot Nothing Then MyDataClass.Building(count).api_item1 = JsonObject("api_data")(count)("api_item1")
                    If JsonObject("api_data")(count)("api_item2") IsNot Nothing Then MyDataClass.Building(count).api_item2 = JsonObject("api_data")(count)("api_item2")
                    If JsonObject("api_data")(count)("api_item3") IsNot Nothing Then MyDataClass.Building(count).api_item3 = JsonObject("api_data")(count)("api_item3")
                    If JsonObject("api_data")(count)("api_item4") IsNot Nothing Then MyDataClass.Building(count).api_item4 = JsonObject("api_data")(count)("api_item4")
                    If JsonObject("api_data")(count)("api_item5") IsNot Nothing Then MyDataClass.Building(count).api_item5 = JsonObject("api_data")(count)("api_item5")
                Next
            End If
            If path = URLDataClass.require_info Then
                For count As Integer = 0 To JsonObject("api_data")("api_kdock").Count - 1
                    If JsonObject("api_data")("api_kdock")(count)("api_state") IsNot Nothing Then MyDataClass.Building(count).api_state = JsonObject("api_data")("api_kdock")(count)("api_state")
                    If JsonObject("api_data")("api_kdock")(count)("api_created_ship_id") IsNot Nothing Then MyDataClass.Building(count).api_created_ship_id = JsonObject("api_data")("api_kdock")(count)("api_created_ship_id")
                    If JsonObject("api_data")("api_kdock")(count)("api_complete_time") IsNot Nothing Then MyDataClass.Building(count).api_complete_time = JsonObject("api_data")("api_kdock")(count)("api_complete_time")
                    If JsonObject("api_data")("api_kdock")(count)("api_item1") IsNot Nothing Then MyDataClass.Building(count).api_item1 = JsonObject("api_data")("api_kdock")(count)("api_item1")
                    If JsonObject("api_data")("api_kdock")(count)("api_item2") IsNot Nothing Then MyDataClass.Building(count).api_item2 = JsonObject("api_data")("api_kdock")(count)("api_item2")
                    If JsonObject("api_data")("api_kdock")(count)("api_item3") IsNot Nothing Then MyDataClass.Building(count).api_item3 = JsonObject("api_data")("api_kdock")(count)("api_item3")
                    If JsonObject("api_data")("api_kdock")(count)("api_item4") IsNot Nothing Then MyDataClass.Building(count).api_item4 = JsonObject("api_data")("api_kdock")(count)("api_item4")
                    If JsonObject("api_data")("api_kdock")(count)("api_item5") IsNot Nothing Then MyDataClass.Building(count).api_item5 = JsonObject("api_data")("api_kdock")(count)("api_item5")
                Next

            End If



            '更新確認イベント
            MyDataClass.EventsEpoch.Info_Refresh_Events()

        End If
    End Sub



End Class




