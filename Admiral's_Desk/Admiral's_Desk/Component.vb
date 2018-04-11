Public Class Component
    '   Public Function KancolleReadJson(oSession As Object, PathString As String)
    '   ■引数
    '       oSession    Nekoxy.Session型のセッションデータ
    '       PathString  String型のURLの部分データ。/kcsapiから始まるやつ
    '   ■返値
    '       艦これのデータ時はNewtonsoft.Json.Linq.JObject型のJSONオブジェクトデータ
    '       異常値及び艦これのデータではないと判別したときは何も返さない
    '   
    Public Shared Function KancolleReadJson(oSession As Object, PathString As String)
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


    '陣形の数値データを名称で返す
    Public Shared Function FormationNameString(ByVal no As Long)
        If no = 1 Then
            Return "単縦陣"
        ElseIf no = 2 Then
            Return "複縦陣"
        ElseIf no = 3 Then
            Return "輪形陣"
        ElseIf no = 4 Then
            Return "梯形陣"
        ElseIf no = 5 Then
            Return "単横陣"
        ElseIf no = 6 Then
            Return "警戒陣"
        Else
            Return "エラー"
        End If
    End Function

    '戦闘種別の数値データを名称で返す
    Public Shared Function BattleTypeNameString(ByVal no As Long)
        If no = 0 Then
            Return "不明"
        ElseIf no = 1 Then
            Return "昼戦"
        ElseIf no = 2 Then
            Return "開幕夜戦"
        ElseIf no = 3 Then
            Return "夜戦(昼戦移行あり)"
        ElseIf no = 4 Then
            Return "航空戦"
        ElseIf no = 5 Then
            Return "空襲戦"
        ElseIf no = 6 Then
            Return "アイテム"
        ElseIf no = 7 Then
            Return "分岐"
        ElseIf no = 8 Then
            Return "うずしお"
        ElseIf no = 9 Then
            Return "未設定"
        ElseIf no = 10 Then
            Return "未設定"
        ElseIf no = 11 Then
            Return "未設定"
        Else
            Return "エラー"
        End If
    End Function

    Public Shared Function MapIDSquareString(ByVal mapname As String, ByVal no As Integer)
        'https://docs.google.com/spreadsheets/d/1iD_-noBo9TYWmtsplXiT1HbKY5c9VzS6rUocwgBJdpo/htmlview
        'ここより

        If mapname = "1-1" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "C"
        ElseIf mapname = "1-2" Then
            If no = 1 Then Return "A"
            If no = 3 Then Return "B"
            If no = 2 Then Return "C"
            If no = 4 Then Return "D"
        ElseIf mapname = "1-3" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 4 Then Return "C"
            If no = 8 Then Return "C"
            If no = 3 Then Return "D"
            If no = 5 Then Return "E"
            If no = 6 Then Return "F"
            If no = 9 Then Return "F"
            If no = 7 Then Return "G"
        ElseIf mapname = "1-4" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "G"
            If no = 4 Then Return "C"
            If no = 5 Then Return "H"
            If no = 6 Then Return "D"
            If no = 8 Then Return "I"
            If no = 9 Then Return "J"
            If no = 10 Then Return "F"
            If no = 11 Then Return "C"
            If no = 12 Then Return "F"
        ElseIf mapname = "1-5" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 4 Then Return "C"
            If no = 3 Then Return "D"
            If no = 5 Then Return "E"
            If no = 6 Then Return "F"
            If no = 8 Then Return "G"
            If no = 7 Then Return "H"
            If no = 9 Then Return "I"
            If no = 10 Then Return "I"
        ElseIf mapname = "1-6" Then
            If no = 1 Then Return "A"
            If no = 13 Then Return "B"
            If no = 2 Then Return "C"
            If no = 11 Then Return "D"
            If no = 16 Then Return "D"
            If no = 3 Then Return "E"
            If no = 12 Then Return "F"
            If no = 4 Then Return "G"
            If no = 5 Then Return "H"
            If no = 10 Then Return "I"
            If no = 9 Then Return "J"
            If no = 15 Then Return "K"
            If no = 8 Then Return "L"
            If no = 7 Then Return "M"
            If no = 14 Then Return "N"
            If no = 17 Then Return "N"
        ElseIf mapname = "2-1" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 4 Then Return "C"
            If no = 3 Then Return "D"
            If no = 6 Then Return "E"
            If no = 5 Then Return "F"
        ElseIf mapname = "2-2" Then
            If no = 1 Then Return "A"
            If no = 3 Then Return "B"
            If no = 5 Then Return "C"
            If no = 6 Then Return "D"
            If no = 2 Then Return "E"
            If no = 8 Then Return "E"
            If no = 7 Then Return "F"
            If no = 4 Then Return "G"
        ElseIf mapname = "2-3" Then
            If no = 2 Then Return "A"
            If no = 5 Then Return "B"
            If no = 1 Then Return "C"
            If no = 4 Then Return "D"
            If no = 6 Then Return "E"
            If no = 12 Then Return "E"
            If no = 10 Then Return "F"
            If no = 11 Then Return "G"
            If no = 3 Then Return "H"
            If no = 7 Then Return "I"
            If no = 8 Then Return "J"
            If no = 9 Then Return "K"
        ElseIf mapname = "2-4" Then
            If no = 1 Then Return "A"
            If no = 4 Then Return "B"
            If no = 5 Then Return "C"
            If no = 6 Then Return "D"
            If no = 7 Then Return "E"
            If no = 3 Then Return "F"
            If no = 11 Then Return "G"
            If no = 19 Then Return "G"
            If no = 13 Then Return "H"
            If no = 12 Then Return "I"
            If no = 16 Then Return "J"
            If no = 17 Then Return "J"
            If no = 18 Then Return "J"
            If no = 2 Then Return "K"
            If no = 8 Then Return "L"
            If no = 9 Then Return "M"
            If no = 10 Then Return "N"
            If no = 14 Then Return "O"
            If no = 15 Then Return "P"
        ElseIf mapname = "2-5" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 4 Then Return "C"
            If no = 5 Then Return "D"
            If no = 6 Then Return "E"
            If no = 3 Then Return "F"
            If no = 7 Then Return "G"
            If no = 8 Then Return "H"
            If no = 13 Then Return "H"
            If no = 14 Then Return "H"
            If no = 9 Then Return "I"
            If no = 10 Then Return "J"
            If no = 11 Then Return "K"
            If no = 12 Then Return "L"
            If no = 15 Then Return "L"
        ElseIf mapname = "3-1" Then
            If no = 2 Then Return "A"
            If no = 4 Then Return "B"
            If no = 5 Then Return "C"
            If no = 1 Then Return "D"
            If no = 6 Then Return "E"
            If no = 3 Then Return "F"
        ElseIf mapname = "3-2" Then
            If no = 2 Then Return "A"
            If no = 5 Then Return "B"
            If no = 9 Then Return "B"
            If no = 6 Then Return "C"
            If no = 3 Then Return "D"
            If no = 1 Then Return "E"
            If no = 4 Then Return "F"
            If no = 10 Then Return "F"
            If no = 7 Then Return "G"
            If no = 8 Then Return "H"
        ElseIf mapname = "3-3" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 5 Then Return "C"
            If no = 8 Then Return "D"
            If no = 3 Then Return "E"
            If no = 6 Then Return "F"
            If no = 11 Then Return "G"
            If no = 13 Then Return "G"
            If no = 4 Then Return "H"
            If no = 7 Then Return "I"
            If no = 12 Then Return "I"
            If no = 10 Then Return "J"
            If no = 9 Then Return "K"
        ElseIf mapname = "3-4" Then
            If no = 1 Then Return "A"
            If no = 4 Then Return "B"
            If no = 9 Then Return "C"
            If no = 12 Then Return "D"
            If no = 15 Then Return "E"
            If no = 20 Then Return "E"
            If no = 5 Then Return "F"
            If no = 16 Then Return "F"
            If no = 7 Then Return "G"
            If no = 10 Then Return "H"
            If no = 18 Then Return "H"
            If no = 1 Then Return "H"
            If no = 13 Then Return "I"
            If no = 2 Then Return "J"
            If no = 3 Then Return "K"
            If no = 6 Then Return "L"
            If no = 17 Then Return "L"
            If no = 8 Then Return "M"
            If no = 11 Then Return "N"
            If no = 14 Then Return "O"
        ElseIf mapname = "3-5" Then
            If no = 1 Then Return "A"
            If no = 6 Then Return "B"
            If no = 13 Then Return "B"
            If no = 4 Then Return "C"
            If no = 3 Then Return "D"
            If no = 5 Then Return "E"
            If no = 12 Then Return "E"
            If no = 8 Then Return "F"
            If no = 14 Then Return "F"
            If no = 7 Then Return "G"
            If no = 2 Then Return "H"
            If no = 9 Then Return "I"
            If no = 10 Then Return "J"
            If no = 11 Then Return "K"
            If no = 15 Then Return "K"
        ElseIf mapname = "4-1" Then
            If no = 2 Then Return "A"
            If no = 6 Then Return "B"
            If no = 8 Then Return "C"
            If no = 9 Then Return "D"
            If no = 12 Then Return "D"
            If no = 1 Then Return "E"
            If no = 4 Then Return "F"
            If no = 7 Then Return "G"
            If no = 3 Then Return "H"
            If no = 5 Then Return "I"
            If no = 10 Then Return "I"
            If no = 11 Then Return "I"
        ElseIf mapname = "4-2" Then
            If no = 2 Then Return "A"
            If no = 3 Then Return "B"
            If no = 6 Then Return "C"
            If no = 9 Then Return "D"
            If no = 13 Then Return "D"
            If no = 5 Then Return "E"
            If no = 10 Then Return "E"
            If no = 1 Then Return "F"
            If no = 4 Then Return "G"
            If no = 7 Then Return "H"
            If no = 11 Then Return "H"
            If no = 12 Then Return "H"
            If no = 8 Then Return "I"
        ElseIf mapname = "4-3" Then
            If no = 2 Then Return "A"
            If no = 3 Then Return "B"
            If no = 6 Then Return "C"
            If no = 7 Then Return "D"
            If no = 17 Then Return "D"
            If no = 18 Then Return "D"
            If no = 11 Then Return "E"
            If no = 4 Then Return "F"
            If no = 14 Then Return "F"
            If no = 15 Then Return "F"
            If no = 8 Then Return "G"
            If no = 19 Then Return "G"
            If no = 20 Then Return "G"
            If no = 9 Then Return "H"
            If no = 13 Then Return "I"
            If no = 1 Then Return "J"
            If no = 5 Then Return "K"
            If no = 16 Then Return "K"
            If no = 10 Then Return "L"
            If no = 21 Then Return "L"
            If no = 12 Then Return "M"
        ElseIf mapname = "4-4" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 5 Then Return "C"
            If no = 11 Then Return "C"
            If no = 6 Then Return "D"
            If no = 9 Then Return "E"
            If no = 4 Then Return "F"
            If no = 7 Then Return "G"
            If no = 12 Then Return "G"
            If no = 13 Then Return "G"
            If no = 10 Then Return "H"
            If no = 3 Then Return "I"
            If no = 8 Then Return "J"
            If no = 14 Then Return "J"
        ElseIf mapname = "4-5" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 4 Then Return "C"
            If no = 14 Then Return "C"
            If no = 3 Then Return "D"
            If no = 5 Then Return "E"
            If no = 6 Then Return "F"
            If no = 15 Then Return "F"
            If no = 16 Then Return "F"
            If no = 7 Then Return "G"
            If no = 8 Then Return "H"
            If no = 17 Then Return "H"
            If no = 9 Then Return "I"
            If no = 10 Then Return "J"
            If no = 18 Then Return "J"
            If no = 11 Then Return "K"
            If no = 12 Then Return "L"
            If no = 13 Then Return "M"
            If no = 19 Then Return "M"
        ElseIf mapname = "5-1" Then
            If no = 2 Then Return "A"
            If no = 1 Then Return "B"
            If no = 4 Then Return "C"
            If no = 3 Then Return "D"
            If no = 6 Then Return "E"
            If no = 11 Then Return "E"
            If no = 5 Then Return "F"
            If no = 10 Then Return "F"
            If no = 8 Then Return "G"
            If no = 7 Then Return "H"
            If no = 12 Then Return "H"
            If no = 9 Then Return "I"
        ElseIf mapname = "5-2" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 6 Then Return "C"
            If no = 10 Then Return "D"
            If no = 14 Then Return "D"
            If no = 5 Then Return "E"
            If no = 3 Then Return "F"
            If no = 4 Then Return "G"
            If no = 11 Then Return "G"
            If no = 8 Then Return "H"
            If no = 12 Then Return "H"
            If no = 7 Then Return "I"
            If no = 9 Then Return "J"
            If no = 13 Then Return "J"
        ElseIf mapname = "5-3" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "C"
            If no = 4 Then Return "D"
            If no = 12 Then Return "D"
            If no = 5 Then Return "E"
            If no = 6 Then Return "F"
            If no = 7 Then Return "G"
            If no = 8 Then Return "H"
            If no = 9 Then Return "I"
            If no = 13 Then Return "I"
            If no = 14 Then Return "I"
            If no = 10 Then Return "J"
            If no = 11 Then Return "K"
        ElseIf mapname = "5-4" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "C"
            If no = 8 Then Return "D"
            If no = 7 Then Return "E"
            If no = 4 Then Return "F"
            If no = 5 Then Return "G"
            If no = 12 Then Return "H"
            If no = 17 Then Return "H"
            If no = 6 Then Return "I"
            If no = 9 Then Return "I"
            If no = 14 Then Return "J"
            If no = 13 Then Return "K"
            If no = 9 Then Return "L"
            If no = 11 Then Return "M"
            If no = 18 Then Return "M"
            If no = 10 Then Return "N"
            If no = 15 Then Return "O"
            If no = 19 Then Return "O"
            If no = 2 Then Return "O"
        ElseIf mapname = "5-5" Then
            If no = 2 Then Return "A"
            If no = 1 Then Return "B"
            If no = 4 Then Return "C"
            If no = 5 Then Return "D"
            If no = 12 Then Return "E"
            If no = 17 Then Return "E"
            If no = 3 Then Return "F"
            If no = 10 Then Return "G"
            If no = 15 Then Return "G"
            If no = 11 Then Return "H"
            If no = 16 Then Return "H"
            If no = 9 Then Return "I"
            If no = 8 Then Return "J"
            If no = 6 Then Return "K"
            If no = 13 Then Return "L"
            If no = 7 Then Return "M"
            If no = 14 Then Return "N"
            If no = 18 Then Return "N"
        ElseIf mapname = "6-1" Then
            If no = 2 Then Return "A"
            If no = 3 Then Return "B"
            If no = 4 Then Return "C"
            If no = 5 Then Return "D"
            If no = 12 Then Return "D"
            If no = 13 Then Return "D"
            If no = 6 Then Return "E"
            If no = 8 Then Return "F"
            If no = 1 Then Return "G"
            If no = 7 Then Return "H"
            If no = 9 Then Return "I"
            If no = 10 Then Return "J"
            If no = 11 Then Return "K"
        ElseIf mapname = "6-2" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 12 Then Return "B"
            If no = 3 Then Return "C"
            If no = 4 Then Return "D"
            If no = 13 Then Return "D"
            If no = 5 Then Return "E"
            If no = 14 Then Return "E"
            If no = 6 Then Return "F"
            If no = 7 Then Return "G"
            If no = 9 Then Return "H"
            If no = 16 Then Return "H"
            If no = 10 Then Return "I"
            If no = 8 Then Return "J"
            If no = 15 Then Return "J"
            If no = 11 Then Return "K"
            If no = 17 Then Return "K"
            If no = 1 Then Return "K"
        ElseIf mapname = "6-3" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "C"
            If no = 4 Then Return "D"
            If no = 5 Then Return "E"
            If no = 6 Then Return "F"
            If no = 7 Then Return "G"
            If no = 8 Then Return "H"
            If no = 12 Then Return "H"
            If no = 9 Then Return "I"
            If no = 10 Then Return "J"
            If no = 11 Then Return "K"
        ElseIf mapname = "6-4" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "C"
            If no = 4 Then Return "D"
            If no = 15 Then Return "D"
            If no = 6 Then Return "F"
            If no = 13 Then Return "M"
            If no = 14 Then Return "N"
        ElseIf mapname = "6-5" Then
            If no = 1 Then Return "A"
            If no = 2 Then Return "B"
            If no = 3 Then Return "C"
            If no = 14 Then Return "C"
            If no = 4 Then Return "D"
            If no = 6 Then Return "F"
            If no = 7 Then Return "G"
            If no = 17 Then Return "I"
            If no = 10 Then Return "J"
            If no = 13 Then Return "M"
        End If
        Dim temp As String = "[マス名不明]api_no:" + no.ToString
        Return temp
    End Function

    '母港にいる艦娘と艦隊所属艦のIDを照合し、母港IDを取得する関数
    Public Shared Function KancollePortKanmusuSearch(ByVal PortID As Integer)
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
    Public Shared Function KancolleShipIdSearch(ByVal MyKanmusuID As Integer)
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
    Public Shared Function KancolleStypeSearch(ByVal stype As Integer)
        Dim 一致艦種 As String = ""

        For count As Integer = 0 To CommonDataClass.ShipType.Count - 1
            If CommonDataClass.ShipType(count).api_id.Equals(stype) Then
                一致艦種 = CommonDataClass.ShipType(count).api_name
            End If
        Next


        '出力
        If 一致艦種 Is Nothing Then
            Return Nothing
        Else
            Return 一致艦種
        End If
    End Function

    '装備検索①
    '保有装備個別のID(艦娘のslotで保持されているid)が引数
    '戻値はMyDataClass.MyEquipmentの配列番号かNothing(失敗時)
    Public Shared Function KancolleMyEquipmentIDSearch(ByVal 個別装備ID As Integer)
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
    Public Shared Function KancolleAllEquipmentIDSearch(ByVal 共通装備ID As Integer)
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
    Public Shared Function KancolleEquipmentNameSearch(ByVal 個別装備ID As Integer)
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

    Public Shared Function KancolleEquipmentAirspaceSearch(ByVal 個別装備ID As Integer)
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


    '33式計算
    Public Structure 艦これ索敵スコア
        Public Shared 分岐点係数 As Integer = 1
        Public Shared 装備単体索敵値総和 As Double = 0
        Public Shared 艦娘索敵値平方根総和 As Integer = 0
        Public Shared 司令部レベル As Integer = 0
        Public Shared 出撃艦数 As Integer = 0

        Public Shared Function 装備単体索敵値(ByVal 個別装備ID As Integer)
            '装備ごとの倍率は以下の通り。
            '装備分類    倍率	        装備分類	    倍率
            '艦上爆撃機   0.6	        艦上戦闘機   	0.6
            '艦上攻撃機   0.8	        水上戦闘機   	0.6
            '艦上偵察機   1.0	        大型飛行艇   	0.6
            '水上偵察機   1.2	        ソナー	        0.6
            '水上爆撃機   1.1	        水上艦要員	    0.6
            '電探(大型 / 小型)	0.6	    対潜哨戒機	    0.6
            '探照灯 0.6                 艦隊司令部施設	0.6
            '噴式戦闘爆撃機 0.6         潜水艦装備	    0.6
            'http://wikiwiki.jp/kancolle/?%C6%EE%C0%BE%BD%F4%C5%E7%B3%A4%B0%E8#area5


            '予め用意しておく変数
            Dim 所有装備配列番号 As Integer
            Dim 装備一覧配列番号 As Integer
            Dim 装備索敵値 As Double = 0.0
            Dim 装備倍率 As Double = 0.0


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

            '照合する
            '■倍率0.6群
            '   艦戦          06
            '   艦爆          07
            '   水戦          45
            '   大型飛行艇    41
            '   ソナー        14  40?
            '   水上艦要員    39
            '   電探          12  13
            '   対潜哨戒機    26
            '   探照灯        29  42
            '   司令部施設    34
            '   噴式戦闘爆撃機57
            '   潜水艦装備    49
            Dim 倍率6割群() As Integer = {6, 7, 45, 41, 14, 40, 39, 12, 13, 26, 29, 42, 34, 57, 49}

            For count As Integer = 0 To 倍率6割群.Count - 1
                If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(倍率6割群(count)) Then
                    装備倍率 = 0.6
                    Exit For
                End If
            Next


            '■倍率0.8群
            '   艦攻          08
            Dim 倍率8割群() As Integer = {8}
            For count As Integer = 0 To 倍率8割群.Count - 1
                If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(倍率8割群(count)) Then
                    装備倍率 = 0.8
                    Exit For
                End If
            Next

            '■倍率1.0群
            '   艦偵          09
            Dim 倍率10割群() As Integer = {9}
            For count As Integer = 0 To 倍率10割群.Count - 1
                If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(倍率10割群(count)) Then
                    装備倍率 = 1.0
                    Exit For
                End If
            Next


            '■倍率1.1群
            '   水爆          11
            Dim 倍率11割群() As Integer = {11}
            For count As Integer = 0 To 倍率11割群.Count - 1
                If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(倍率11割群(count)) Then
                    装備倍率 = 1.1
                    Exit For
                End If
            Next


            '■倍率1.2群
            '   水偵          10
            Dim 倍率12割群() As Integer = {10}
            For count As Integer = 0 To 倍率12割群.Count - 1
                If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(倍率12割群(count)) Then
                    装備倍率 = 1.2
                    Exit For
                End If
            Next

            '装備素索敵
            装備索敵値 = CommonDataClass.AllEquipmentData(装備一覧配列番号).api_saku

            '改修度を考慮に入れる
            If MyDataClass.MyEquipment(所有装備配列番号).api_level <> 0 And MyDataClass.MyEquipment(所有装備配列番号).api_level.ToString <> "0" Then
                If CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(9) Then
                    '艦偵
                    装備索敵値 += 1.2 * MyDataClass.MyEquipment(所有装備配列番号).api_level
                ElseIf CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(10) Then
                    '水偵
                    装備索敵値 += 1.2 * MyDataClass.MyEquipment(所有装備配列番号).api_level
                ElseIf CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(12) Then
                    '小型電探
                    装備索敵値 += 1.25 * MyDataClass.MyEquipment(所有装備配列番号).api_level
                ElseIf CommonDataClass.AllEquipmentData(装備一覧配列番号).api_type(2).Equals(13) Then
                    '大型電探
                    装備索敵値 += 1.4 * MyDataClass.MyEquipment(所有装備配列番号).api_level
                End If
            End If

            '最後に出力
            Dim 出力 As Double = 装備倍率 * 装備索敵値
            Return 出力

        End Function

        Public Shared Function 判定式33計算()
            '以下の式は2016年10月現在推定されている索敵判定の式です(引用元、通称判定式(33) )。
            '索敵スコア=分岐点係数×(装備倍率×装備索敵値)の和+√(各艦娘の素索敵)の和-[0.4×司令部レベル(端数切り上げ)]+2×(6-出撃艦数)
            'http://wikiwiki.jp/kancolle/?%C6%EE%C0%BE%BD%F4%C5%E7%B3%A4%B0%E8#area5

            Dim 索敵スコア As Double = 分岐点係数 * 装備単体索敵値総和 + 艦娘索敵値平方根総和 - Math.Ceiling(0.4 * 司令部レベル) + 2 * (6 - 出撃艦数)

            Return 索敵スコア

        End Function
    End Structure




End Class
