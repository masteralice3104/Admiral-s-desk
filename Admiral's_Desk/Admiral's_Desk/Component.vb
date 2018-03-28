Public Class Component
    '   Public Function KancolleReadJson(oSession As Object, PathString As String)
    '   ■引数
    '       oSession    Nekoxy.Session型のセッションデータ
    '       PathString  String型のURLの部分データ。/kcsapiから始まるやつ
    '   ■返値
    '       艦これのデータ時はNewtonsoft.Json.Linq.JObject型のJSONオブジェクトデータ
    '       異常値及び艦これのデータではないと判別したときは何も返さない
    '   
    Public Shared Function KancolleReadJson(oSession As Object, PathString As String) As Object
        'とりあえずNekoxyからパスを受け取る
        Dim path As String = oSession.Request.PathAndQuery

        'JSONのデータもぶち込む
        Dim JSONtemporaryData As String = oSession.Response.BodyAsString
        If (path.StartsWith(PathString)) Then
            'JSONの先頭にある余計な文字を取り除く
            Dim JSONData As String = JSONtemporaryData.Substring(7)


            'JSON文字列→JSON形式データに復元
            Dim JSONObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)
            Return JSONObject
        Else
            Return Nothing
        End If
    End Function





    '母港にいる艦娘と艦隊所属艦のIDを照合し、母港IDを取得する関数
    Public Shared Function KancollePortKanmusuSearch(ByVal PortID)
        '照合し一致するIDがあればここに収納
        Dim 一致ID As Integer = -1

        For count As Integer = 0 To MyDataClass.MyKanmusu.Count - 1
            If MyDataClass.MyKanmusu(count).api_id.Equals(PortID) Then
                '一致すれば変数に収納する
                一致ID = count
            End If
        Next

        '出力
        If 一致ID.Equals(-1) Then
            Return Nothing
        Else
            Return 一致ID
        End If
    End Function

    'MyKanmusuDataから得たshipidを照合する
    Public Shared Function KancolleShipIdSearch(ByVal MyKanmusuID)
        'api_ship_idあたりと照合
        Dim 一致ID As Integer = -1

        For count As Integer = 0 To CommonDataClass.AllKanmusuData.Count - 1
            If CommonDataClass.AllKanmusuData(count).api_id.Equals(MyKanmusuID) Then
                一致ID = count
            End If
        Next

        '出力
        If 一致ID.Equals(-1) Then
            Return Nothing
        Else
            Return 一致ID
        End If
    End Function


    '艦種検索→string型で出力
    Public Shared Function KancolleStypeSearch(ByVal stype)
        Dim 一致艦種 As String = ""

        For count As Integer = 0 To CommonDataClass.ShipType.Count - 1
            If CommonDataClass.ShipType(count).api_id.Equals(stype) Then
                一致艦種 = CommonDataClass.ShipType(count).api_name
            End If
        Next


        '出力
        If 一致艦種.Equals("") Then
            Return Nothing
        Else
            Return 一致艦種
        End If
    End Function

    '装備検索①
    '保有装備個別のID(艦娘のslotで保持されているid)が引数
    '戻値はMyDataClass.MyEquipmentの配列番号かNothing(失敗時)
    Public Shared Function KancolleMyEquipmentIDSearch(ByVal 個別装備ID)
        '装備IDを手がかりに所有装備より検索
        For count As Integer = 0 To MyDataClass.MyEquipment.Count - 1
            If MyDataClass.MyEquipment(count).api_id.Equals(個別装備ID) Then
                Return count
            End If
        Next
        Return Nothing

    End Function

    '装備検索②
    '装備ごとに共通のID(①の結果より求められるもの)
    '戻値はCommonDataClass.AllEquipmentDataの配列番号かNothing(失敗時)
    Public Shared Function KancolleAllEquipmentIDSearch(ByVal 共通装備ID)
        '装備IDを手がかりに全装備より検索
        For count As Integer = 0 To CommonDataClass.AllEquipmentData.Count - 1
            If CommonDataClass.AllEquipmentData(count).api_id.Equals(共通装備ID) Then
                Return count
            End If
        Next
        Return Nothing

    End Function

    '装備検索③
    '①と②を複合し扱いやすくしたもの
    '戻り値はString型で「装備名+改修状態」が返される
    'nothingが返るときは失敗
    Public Shared Function KancolleEquipmentNameSearch(ByVal 個別装備ID)
        '予め用意しておく変数
        Dim 所有装備配列番号 As Integer
        Dim 装備一覧配列番号 As Integer
        Dim 装備名 As String = ""


        '①で検索
        If KancolleMyEquipmentIDSearch(個別装備ID) IsNot Nothing Then
            所有装備配列番号 = KancolleMyEquipmentIDSearch(個別装備ID)
        Else
            Return Nothing
        End If

        '②で検索
        If KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id) IsNot Nothing Then
            装備一覧配列番号 = KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id)
        Else
            Return Nothing
        End If

        '装備名の代入
        装備名 = CommonDataClass.AllEquipmentData(装備一覧配列番号).api_name

        '改修状態の追加
        If MyDataClass.MyEquipment(所有装備配列番号).api_level <> 0 Then
            装備名 = 装備名 + "★" + String.Format("{0}", MyDataClass.MyEquipment(所有装備配列番号).api_level)
        End If

        Return 装備名

    End Function

    '装備検索④
    '①と②を複合し扱いやすくしたもの
    '戻り値はLong型で「艦載機の対空値」が返される
    'nothingが返るときは失敗
    'なお現在
    '   艦戦
    '   艦爆
    '   艦攻
    '   水爆
    '   水戦
    '   局戦
    '   陸戦
    '   陸攻
    'のみ対応中
    '
    '
    '

    Public Shared Function KancolleEquipmentAirspaceSearch(ByVal 個別装備ID)
        '予め用意しておく変数
        Dim 所有装備配列番号 As Integer
        Dim 装備一覧配列番号 As Integer
        Dim 制空値 As Long = 0


        '①で検索
        If KancolleMyEquipmentIDSearch(個別装備ID) IsNot Nothing Then
            所有装備配列番号 = KancolleMyEquipmentIDSearch(個別装備ID)
        Else
            Return Nothing
        End If

        '②で検索
        If KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id) IsNot Nothing Then
            装備一覧配列番号 = KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id)
        Else
            Return Nothing
        End If

        '制空値の代入
        If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(6) Or      '艦戦
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(7) Or     '艦爆
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(8) Or     '艦攻
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(11) Or    '水爆
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(47) Or    '陸攻
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(48) Or    '陸戦
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(45) Then  '水戦
            制空値 = CommonDataClass.AllEquipmentData(装備一覧配列番号).api_tyku
        End If

        Return 制空値

    End Function

    '熟練度補正計算
    '熟練補正計算
    '上昇制空値 = 内部熟練ボーナス + 制空ボーナス(艦戦・水戦・局戦/水爆)
    '内部熟練ボーナス =√(内部熟練度/10)
    'http://wikiwiki.jp/kancolle/?%B4%CF%BA%DC%B5%A1%BD%CF%CE%FD%C5%D9#Effect
    Public Shared Function KancolleEquipmentProficiencyCorrectionSearch(ByVal 個別装備ID)
        '予め用意しておく変数
        Dim 所有装備配列番号 As Integer
        Dim 装備一覧配列番号 As Integer
        Dim 制空値 As Double = 0


        '①で検索
        If KancolleMyEquipmentIDSearch(個別装備ID) IsNot Nothing Then
            所有装備配列番号 = KancolleMyEquipmentIDSearch(個別装備ID)
        Else
            Return Nothing
        End If

        '②で検索
        If KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id) IsNot Nothing Then
            装備一覧配列番号 = KancolleAllEquipmentIDSearch(MyDataClass.MyEquipment(所有装備配列番号).api_slotitem_id)
        Else
            Return Nothing
        End If

        '内部熟練ボーナスの代入
        制空値 += Math.Sqrt(MyDataClass.MyEquipment(所有装備配列番号).api_alv)

        '制空値の代入
        If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(6) Or          '艦戦
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(48) Or        '陸戦
            CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(45) Then      '水戦

            If MyDataClass.MyEquipment(所有装備配列番号).api_alv = 2 Then
                制空値 += 2
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 3 Then
                制空値 += 5
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 4 Then
                制空値 += 9
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 5 Then
                制空値 += 14
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 6 Then
                制空値 += 14
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 7 Then
                制空値 += 22
            End If

        ElseIf CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(11) Then   '水爆
            If MyDataClass.MyEquipment(所有装備配列番号).api_alv = 2 Then
                制空値 += 1
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 3 Then
                制空値 += 1
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 4 Then
                制空値 += 1
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 5 Then
                制空値 += 3
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 6 Then
                制空値 += 3
            ElseIf MyDataClass.MyEquipment(所有装備配列番号).api_alv = 7 Then
                制空値 += 6
            End If
        End If

        Return 制空値

    End Function

    '遠征検索
    Public Shared Function KancolleMissionIDSearch(ByVal 遠征ID As Integer)
        For count As Integer = 0 To CommonDataClass.Mission.Count - 1
            If CommonDataClass.Mission(count).api_id.Equals(遠征ID) Then
                Return CommonDataClass.Mission(count).api_name
            End If
        Next
        Return Nothing
    End Function
End Class
