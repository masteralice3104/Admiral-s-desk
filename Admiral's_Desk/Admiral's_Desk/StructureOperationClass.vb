
Public Class StructureOperationClass
    '艦娘基本データの構造体調整
    Public Shared Sub AllEquipmentDataAdjust(ByVal JsonObject As Newtonsoft.Json.Linq.JObject)

    End Sub

    'Jsonのデータを構造体にぶち込む
    Public Shared Sub JsonDataInputToStructure(ByVal JsonObject As Newtonsoft.Json.Linq.JObject)

        '一つ一つ存在確認をする
        'api_data 存在時
        If JsonObject("api_data") IsNot Nothing Then
            'api_data -> api_basic 存在時
            If JsonObject("api_data")("api_basic") IsNot Nothing Then
                '提督データの取得
                If JsonObject("api_data")("api_basic")("api_member_id") IsNot Nothing Then MyDataClass.Admiral.api_member_id = JsonObject("api_data")("api_basic")("api_member_id")
                If JsonObject("api_data")("api_basic")("api_nickname") IsNot Nothing Then MyDataClass.Admiral.api_nickname = JsonObject("api_data")("api_basic")("api_nickname")
                If JsonObject("api_data")("api_basic")("api_starttime") IsNot Nothing Then MyDataClass.Admiral.api_starttime = JsonObject("api_data")("api_basic")("api_starttime")
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
                    For count As Integer = 0 To 5
                        MyDataClass.Admiral.api_furniture(count) = JsonObject("api_data")("api_basic")("api_furniture")(count)
                    Next
                End If
            End If

            If JsonObject("api_data")("api_material") IsNot Nothing Then
                '資材データの取得
                If JsonObject("api_data")("api_material")(0) IsNot Nothing Then MyDataClass.MyResource.Fuel = JsonObject("api_data")("api_material")(0)
                If JsonObject("api_data")("api_material")(1) IsNot Nothing Then MyDataClass.MyResource.Bullet = JsonObject("api_data")("api_material")(1)
                If JsonObject("api_data")("api_material")(2) IsNot Nothing Then MyDataClass.MyResource.Steel = JsonObject("api_data")("api_material")(2)
                If JsonObject("api_data")("api_material")(3) IsNot Nothing Then MyDataClass.MyResource.Bauxite = JsonObject("api_data")("api_material")(3)
                If JsonObject("api_data")("api_material")(4) IsNot Nothing Then MyDataClass.MyResource.HighspeedBuildingMaterial = JsonObject("api_data")("api_material")(4)
                If JsonObject("api_data")("api_material")(5) IsNot Nothing Then MyDataClass.MyResource.HighspeedRepairingMaterial = JsonObject("api_data")("api_material")(5)
                If JsonObject("api_data")("api_material")(6) IsNot Nothing Then MyDataClass.MyResource.DevelopmentMaterial = JsonObject("api_data")("api_material")(6)
                If JsonObject("api_data")("api_material")(7) IsNot Nothing Then MyDataClass.MyResource.ImprovementMaterial = JsonObject("api_data")("api_material")(7)
            End If

            If JsonObject("api_data")("api_ndock") IsNot Nothing Then
                '入渠ドックデータの取得
                For count As Integer = 0 To JsonObject("api_data")("api_ndock").Count
                    If JsonObject("api_data")("api_ndock")(count)("api_member_id") IsNot Nothing Then MyDataClass.RepairingDock(count).api_member_id = JsonObject("api_data")("api_ndock")(count)("api_member_id")
                    If JsonObject("api_data")("api_ndock")(count)("api_id") IsNot Nothing Then MyDataClass.RepairingDock(count).api_id = JsonObject("api_data")("api_ndock")(count)("api_id")
                    If JsonObject("api_data")("api_ndock")(count)("api_state") IsNot Nothing Then MyDataClass.RepairingDock(count).api_state = JsonObject("api_data")("api_ndock")(count)("api_state")
                    If JsonObject("api_data")("api_ndock")(count)("api_ship_id") IsNot Nothing Then MyDataClass.RepairingDock(count).api_ship_id = JsonObject("api_data")("api_ndock")(count)("api_ship_id")
                    If JsonObject("api_data")("api_ndock")(count)("api_complete_time") IsNot Nothing Then MyDataClass.RepairingDock(count).api_complete_time = JsonObject("api_data")("api_ndock")(count)("api_complete_time")
                Next

            End If

        End If


    End Sub



End Class




