Public Class 全艦娘一覧
    Public Shared 更新確認 As Boolean = False


    Private Sub 艦隊一覧表示()
        'まずは消す
        艦娘一覧.Rows.Clear()


        For Each Kanmusu In MyDataClass.MyKanmusu
            '変数の準備
            Dim ID As Integer
            Dim 艦種 As String = ""
            Dim 艦娘名 As String = ""
            Dim Lv As Integer
            Dim cond As Integer
            Dim 耐久 As Integer
            Dim 対潜 As Integer
            Dim 運 As Integer
            Dim 夜戦火力 As Integer
            Dim 装備() As String = {"", "", "", "", "", ""}

            '発見できた母港IDを保存
            '母港IDがわかれば艦娘の情報がわかる
            Dim 母港配列ID As Integer = Component.KancollePortKanmusuSearch(Kanmusu.api_id)
            Dim 艦娘配列ID As Integer = Component.KancolleShipIdSearch(Kanmusu.api_ship_id)


            '変数への代入
            ID = Kanmusu.api_id
            If ID.ToString <> "0" Then
                艦種 = Component.KancolleStypeSearch(CommonDataClass.AllKanmusuData(艦娘配列ID).api_stype.ToString)
                艦娘名 = CommonDataClass.AllKanmusuData(艦娘配列ID).api_name.ToString
                If Kanmusu.api_lv.ToString IsNot Nothing Then Lv = Kanmusu.api_lv
                If Kanmusu.api_cond.ToString IsNot Nothing Then cond = Kanmusu.api_cond
                If Kanmusu.api_maxhp.ToString IsNot Nothing Then 耐久 = Kanmusu.api_maxhp
                If Kanmusu.api_taisen IsNot Nothing Then 対潜 = Kanmusu.api_taisen(0)
                If Kanmusu.api_lucky.ToString IsNot Nothing Then 運 = Kanmusu.api_lucky(0)
                夜戦火力 = Kanmusu.api_karyoku(0) + Kanmusu.api_raisou(0)
                For cnt As Integer = 0 To Kanmusu.api_slot.length - 1
                    装備(cnt) = Component.KancolleEquipmentNameSearch(Kanmusu.api_slot(cnt))
                Next
                If Component.KancolleEquipmentNameSearch(Kanmusu.api_slot_ex) IsNot Nothing Then
                    装備(5) = Component.KancolleEquipmentNameSearch(Kanmusu.api_slot_ex)
                End If

                '出力
                艦娘一覧.Rows.Add(ID, 艦種, 艦娘名, Lv, cond, 耐久, 対潜, 運, 夜戦火力, 装備(0), 装備(1), 装備(2), 装備(3), 装備(4), 装備(5))






            End If


        Next




    End Sub

    Private Sub 全艦娘一覧_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler MyDataClass.Events.Info_Refresh, AddressOf 更新確認変更
        艦隊一覧表示()
    End Sub

    Private Sub 更新確認変更()
        更新確認 = True
    End Sub

    Private Sub 更新タイマ_Tick(sender As Object, e As EventArgs) Handles 更新タイマ.Tick
        If 更新確認 = True Then
            艦隊一覧表示()
            更新確認 = False
        End If

        更新タイマ.Interval = 2000 * オプション.動作速度設定
    End Sub

End Class