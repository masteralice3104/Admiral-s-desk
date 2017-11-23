'艦これから降ってきたデータに関する構造体
Public Structure DataClass
    '全員同じデータになるはずのところ
    Public Structure CommonData
        '艦娘データ
        Public Structure Kanmusu
            Public api_id As Integer           '艦娘固有のID(艦娘の同定に使う)
            Public api_sortno As Integer       'ソートNo
            Public api_name As String          '艦娘名
            Public api_yomi As String          '読み
            Public api_stype As Integer        '艦種
            Public api_ctype As Integer        '艦型
            Public api_afterlv As Integer      '改造レベル
            Public api_aftershipid As String   '改造後のapi_id
            Public api_taik() As Integer       '耐久([0]が初期値、[1]が最大値)
            'api_taikは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_souk() As Integer       '装甲([0]が初期値、[1]が最大値)
            'api_soukは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_houg() As Integer       '砲撃([0]が初期値、[1]が最大値)
            'api_hougは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_raig() As Integer       '雷装([0]が初期値、[1]が最大値)
            'api_raigは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_tyku() As Integer       '対空([0]が初期値、[1]が最大値)
            'api_tykuは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_luck() As Integer       '運([0]が初期値、[1]が最大値)
            'api_luckは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_soku As Integer         '速力
            Public api_leng As Integer         '射程
            Public api_slot_num As Integer     'スロット数
            Public api_maxeq() As Integer      'スロットごとの搭載機数(航空機搭載艦のみ)
            'api_maxeqは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_buildtime As Integer    '建造時間
            Public api_broken() As Integer     '解体時の資源(燃,弾,鋼,ボの順)
            'api_brokenは必ず初期化時にReDimしてサイズを4にしなければならない!
            Public api_powup() As Integer      '近代化改修の素材に使用したときの上昇値
            'api_powupは必ず初期化時にReDimしてサイズを4にしなければならない!
            Public api_backs As Integer        '背景画像?
            Public api_getmes As String        '入手時メッセージ(html形式)
            Public api_afterfuel As Integer    '改造時使用燃料
            Public api_afterbull As Integer    '改造時使用弾薬
            Public api_fuel_max As Integer     '燃料MAX
            Public api_bull_max As Integer     '弾薬MAX
            'Public api_voicef As Integer       '?
            Public api_tais() As Integer       '対潜([0]が初期値、[1]が最大値)
            'api_taisは必ず初期化時にReDimしてサイズを2にしなければならない!
            'api_taisはなにも定義がないとapi_tais = { 16 , 39 }となっている?
        End Structure


        '装備一覧
        Public Structure Equipment
            Public api_id As Integer           '装備固有ID
            Public api_sortno As Integer       '装備を並べるときの順番
            Public api_name As String       '装備名
            Public api_type() As Integer       '装備詳細
            'api_typeは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_taik As Integer         '耐久
            Public api_souk As Integer         '装甲
            Public api_houg As Integer         '火力
            Public api_raig As Integer         '雷装
            Public api_soku As Integer         '速度
            Public api_baku As Integer         '爆装
            Public api_tyku As Integer         '対空
            Public api_tais As Integer         '対潜
            'Public api_atap As Integer         '?
            Public api_houm As Integer         '砲撃命中
            Public api_raim As Integer         '雷装命中
            Public api_kaih As Integer         '回避
            Public api_houk As Integer         '砲撃回避
            Public api_raik As Integer         '雷撃回避
            Public api_bakk As Integer         '爆撃回避
            Public api_saku As Integer         '索敵
            ' Public api_sakb As Integer         '?
            Public api_luck As Integer         '運
            Public api_leng As Integer         '射程
            Public api_rare As Integer         'レア度
            Public api_broken() As Integer     '解体したとき出て来る資材
            'api_brokenは必ず初期化時にReDimしてサイズを4にしなければならない!
            Public api_info As String       '説明文(html形式)
        End Structure

    End Structure

    '人それぞれで違うデータに関するもの
    Public Structure IndividualData

        '提督情報
        Public Class Admiral
            Public api_member_id As String          '提督毎の固有の数字
            Public api_nickname As String           '提督の名前
            'Public api_nickname_id As String        '?
            'Public api_active_flag As Integer       '?
            Public api_starttime As Integer         'ログイン日時
            Public api_level As Integer             '提督レベル
            Public api_rank As Integer              '提督階級
            Public api_experience As Integer        '提督経験値
            'Public api_fleetname As Object         'なんかnullが入ってるので無視
            Public api_comment As String            'コメント
            'Public api_comment_id As String         '?
            Public api_max_chara As Integer         '最大所持艦娘数
            Public api_max_slotitem As Integer      '最大所持装備数
            'Public api_max_kagu As Integer          '?
            'Public api_playtime As Integer          '?
            Public api_tutorial As Integer          'チュートリアル実行中フラグ?
            Public api_furniture() As Integer       '現在設置してる家具
            'api_furnitureは必ず初期化時にReDimしてサイズを6にしなければならない!
            Public api_count_deck As Integer        '開放済艦隊
            Public api_count_kdock As Integer       '開放済建造ドック
            Public api_count_ndock As Integer       '開放済入渠ドック
            Public api_fcoin As Integer             '家具コイン
            Public api_st_win As Integer            '戦闘勝利数?
            Public api_st_lose As Integer           '戦闘敗北数?
            Public api_ms_count As Integer          '遠征回数
            Public api_ms_success As Integer        '遠征失敗数
            Public api_pt_win As Integer            '演習勝利数
            Public api_pt_lose As Integer           '演習敗北数
            'Public api_pt_challenged As Integer     '?
            'Public api_pt_challenged_win As Integer '?
            'Public api_firstflag As Integer         '?
            Public api_tutorial_progress As Integer 'チュートリアル進行度
            'Public api_pvp() As Integer             '文字的に不穏な香りがするやつ
            Public api_medals As Integer            '甲勲章数
            Public api_large_dock As Integer        '補強増設数
        End Class

        '資材情報
        Public Structure Resource
            Public Fuel As Integer                         '燃料
            Public Bullet As Integer                       '弾薬
            Public Steel As Integer                        '鋼材
            Public Bauxite As Integer                      'ボーキサイト
            Public HighspeedBuildingMaterial As Integer    '高速建造材
            Public HighspeedRepairingMaterial As Integer   '高速修復材
            Public DevelopmentMaterial As Integer          '開発資材
            Public ImprovementMaterial As Integer          '改修資材
        End Structure

        '入渠ドック
        Public Class RepairingDock
            Public api_member_id As Integer             '提督固有ID?
            Public api_id As Integer                    'ドック番号
            Public api_state As Integer                 '状態
            Public api_ship_id As Integer               'ドックに入ってる艦
            Public api_complete_time As Integer         '終了時間
            'Public api_complete_time_str As String      '?
            'Public api_item1 As Integer                 '?
            'Public api_item2 As Integer                 '?
            'Public api_item3 As Integer                 '?
            'Public api_item4 As Integer                 '?
        End Class

        '艦娘情報
        Public Class Kanmusu
            Public api_id As Integer            '番号
            Public api_sortno As Integer        'ソートNo
            Public api_ship_id As Integer       '艦娘識別の番号(同定に使用)
            Public api_lv As Integer            'Lv
            Public api_exp() As Integer         '経験値
            'api_expは必ず初期化時にReDimしてサイズを3にしなければならない!
            Public api_nowhp As Integer         '現在HP
            Public api_maxhp As Integer         '最大HP
            Public api_soku As Integer          '速力
            Public api_leng As Integer          '射程
            Public api_slot() As Integer        'スロットの状態(なぜか5こある)
            'api_slotは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_onslot() As Integer      'スロット搭載数
            'api_onslotは必ず初期化時にReDimしてサイズを5にしなければならない!
            Public api_slot_ex As Integer       '補強増設の状態
            'Public api_kyouka() As Integer      '?
            'Public api_backs As Integer         '?
            Public api_fuel As Integer          '燃料
            Public api_bull As Integer          '弾薬
            Public api_slotnum As Integer       'スロット数
            Public api_ndock_time As Integer    '入渠時間
            'Public api_ndock_item() As Integer  '?
            'Public api_srate As Integer         '?
            Public api_cond As Integer          'cond値
            Public api_karyoku() As Integer     '火力
            'api_karyokuは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_raisou() As Integer      '雷装
            'api_raisouは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_taiku() As Integer       '対空
            'api_taikuは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_soukou() As Integer      '装甲
            'api_soukouは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_kaihi() As Integer       '回避
            'api_kaihiは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_taisen() As Integer      '対潜
            'api_taisenは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_sakuteki() As Integer    '索敵
            'api_sakutekiは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_lucky() As Integer       '運
            'api_luckyは必ず初期化時にReDimしてサイズを2にしなければならない!
            Public api_locked As Integer        'ロックの有無
            Public api_locked_equip As Integer  'ロック装備の有無
        End Class

        '装備情報
        Public Structure Equipment
            Public api_id As Integer           '装備番号
            Public api_slotitem_id As Integer  '装備固有ID(どの装備かの同定に使用)
            Public api_locked As Integer       'ロックされているか否か
            Public api_level As Integer        '改修度?
        End Structure

        '艦隊情報
        Public Structure Port
            'Public api_member_id As Integer    '?
            Public api_id As Integer           '艦隊の番号(1～4)
            Public api_name As String       '艦隊の名称
            'Public api_name_id As Integer      '?
            Public api_mission() As Integer    '?
            'api_missionは必ず初期化時にReDimしてサイズを4にしなければならない！
            Public api_flagship As Integer     '旗艦?
            Public api_ship() As Integer       '艦隊に所属している艦娘の番号
            'api_shipは必ず初期化時にReDimしてサイズを6にしなければならない！
        End Structure

    End Structure

End Structure


Public Class CommonDataClass
    '共通データ
    Public Shared AllKanmusuData(1024) As DataClass.CommonData.Kanmusu         '艦娘の基本データとりあえず(1024)
    Public Shared AllEquipmentData(4096) As DataClass.CommonData.Equipment     '装備の基本データとりあえず(4096)
End Class

Public Class MyDataClass
    '個別データ
    Public Shared Admiral As DataClass.IndividualData.Admiral                  '提督データ
    Public Shared MyResource As DataClass.IndividualData.Resource              '資源資材
    Public Shared MyKanmusu(1024) As DataClass.IndividualData.Kanmusu          '艦娘データとりあえず(1024)
    Public Shared MyEquipment(4096) As DataClass.IndividualData.Equipment      '所持装備とりあえず(4096)
    Public Shared MyPort(4) As DataClass.IndividualData.Port                   '艦隊4つぶん
    Public Shared RepairingDock(4) As DataClass.IndividualData.RepairingDock   '入渠ドック情報
End Class

Public Class URLDataClass
    Public Const kcsapi As String = "/kcsapi/api_"
    Public Const api_start2 As String = "/kcsapi/api_start2"
End Class

Public Class MagicNumberClass
    'マジックナンバーっぽいものを格納するところ


End Class

