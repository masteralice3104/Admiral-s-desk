Public Class 提督情報




    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.提督情報アクセス.Checked = False
    End Sub

    Private Sub 提督情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ハンドラを設定
        AddHandler MyDataClass.Events.Info_Refresh, AddressOf 提督情報等更新

    End Sub

    '提督情報更新
    Private Sub 提督情報等更新()
        'あんまり良くないけど有効ではないスレッド間の操作が発生するのでこれを言っておく
        DataGridView.CheckForIllegalCrossThreadCalls = False


        '本処理1
        提督名変更()
        提督レベル変更()
        提督レベル残り()
        提督階級変更()
        母港及装備状態表示()
        マップ状態表示()



        '資材資源量変更()
        'ここで上記関数を動かすとSystem.NullReferenceExceptionが出る
        '代わりにタイマーで一回限り動かせるようにする
        資材資源量更新タイマー.Enabled = True
        資材資源量更新タイマー.Start()
    End Sub


    '提督名の変更
    Public Sub 提督名変更()
        If MyDataClass.Admiral.api_nickname <> "" Then
            提督名.Text = MyDataClass.Admiral.api_nickname.ToString
        End If
    End Sub


    '提督レベルの変更
    Public Sub 提督レベル変更()
        If MyDataClass.Admiral.api_level.ToString <> "0" Then
            提督Lv.Text = "Lv." + MyDataClass.Admiral.api_level.ToString
        End If
    End Sub

    '提督レベルがUPするまでの経験値
    Public Sub 提督レベル残り()
        If MyDataClass.Admiral.api_experience.ToString = "0" Then
            Exit Sub
        End If
        '経験値しかないので残りを計算する他ない

        '提督レベルをIntegerで保持
        Dim 提督レベル As Integer = Integer.Parse(MyDataClass.Admiral.api_level.ToString)
        '↑型がよくわからないからとりあえず文字列型で出力→Integerに変換かけてる
        '変な値入ったらどうなるのやら

        '今の提督経験値
        Dim 今の提督経験値 As Integer = Integer.Parse(MyDataClass.Admiral.api_experience.ToString)

        'Lv1の初期値100を突っ込んでおく
        Dim 次のレベルの提督経験値 As Integer = 100

        '次のレベルの提督経験値を求める
        If 提督レベル < 98 Then

            For count As Integer = 1 To 提督レベル
                次のレベルの提督経験値 += (count - 1) * 100
            Next
        ElseIf 提督レベル = 98 Then
            次のレベルの提督経験値 = 1000000
        ElseIf 提督レベル > 98 Then
            次のレベルの提督経験値 = 1000000
            If 提督レベル >= 99 Then 次のレベルの提督経験値 += 300000
            If 提督レベル >= 100 Then 次のレベルの提督経験値 += 300000
            If 提督レベル >= 101 Then 次のレベルの提督経験値 += 300000
            If 提督レベル >= 102 Then 次のレベルの提督経験値 += 300000
            If 提督レベル >= 103 Then 次のレベルの提督経験値 += 400000
            If 提督レベル >= 104 Then 次のレベルの提督経験値 += 400000
            If 提督レベル >= 105 Then 次のレベルの提督経験値 += 500000
            If 提督レベル >= 106 Then 次のレベルの提督経験値 += 500000
            If 提督レベル >= 107 Then 次のレベルの提督経験値 += 600000
            If 提督レベル >= 108 Then 次のレベルの提督経験値 += 600000
            If 提督レベル >= 109 Then 次のレベルの提督経験値 += 700000
            If 提督レベル >= 110 Then 次のレベルの提督経験値 += 700000
            If 提督レベル >= 111 Then 次のレベルの提督経験値 += 800000
            If 提督レベル >= 112 Then 次のレベルの提督経験値 += 800000
            If 提督レベル >= 113 Then 次のレベルの提督経験値 += 900000
            If 提督レベル >= 114 Then 次のレベルの提督経験値 += 900000
            If 提督レベル >= 115 Then 次のレベルの提督経験値 += 1000000
            If 提督レベル >= 116 Then 次のレベルの提督経験値 += 1000000
            If 提督レベル >= 117 Then 次のレベルの提督経験値 += 1000000
            If 提督レベル >= 118 Then 次のレベルの提督経験値 += 1000000
            If 提督レベル >= 119 Then 次のレベルの提督経験値 += 1000000
        End If

        '引き算したのを表示
        If 提督レベル = 120 Then
            提督Lvアップ残経験値.Text = "next 0"
        Else
            提督Lvアップ残経験値.Text = "next " + (次のレベルの提督経験値 - 今の提督経験値).ToString
        End If

    End Sub

    '提督階級の変更
    Public Sub 提督階級変更()

        If MyDataClass.Admiral.api_rank.ToString <> "0" Then
            Dim 提督階級番号 As Integer = Integer.Parse(MyDataClass.Admiral.api_rank.ToString)
            Dim 表示名 As String = ""


            If 提督階級番号 = 1 Then 表示名 = "元帥"
            If 提督階級番号 = 2 Then 表示名 = "大将"
            If 提督階級番号 = 3 Then 表示名 = "中将"
            If 提督階級番号 = 4 Then 表示名 = "少将"
            If 提督階級番号 = 5 Then 表示名 = "大佐"
            If 提督階級番号 = 6 Then 表示名 = "中佐"
            If 提督階級番号 = 7 Then 表示名 = "新米中佐"
            If 提督階級番号 = 8 Then 表示名 = "少佐"
            If 提督階級番号 = 9 Then 表示名 = "中堅少佐"
            If 提督階級番号 = 10 Then 表示名 = "新米少佐"

            提督階級.Text = 表示名
        End If
    End Sub


    '資材資源量の変更
    Public Sub 資材資源量変更()


        'とりあえず全削除
        If Me.資材資源量DataGridView.Rows.Count > 0 Then
            For i = 0 To Me.資材資源量DataGridView.Rows.Count - 1 Step 1
                Me.資材資源量DataGridView.Rows.RemoveAt(0)
            Next
        End If





        '右寄せにする
        資材資源量DataGridView.Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        '行追加
        資材資源量行追加("燃料", MyDataClass.MyResource.Fuel.ToString)
        資材資源量行追加("弾薬", MyDataClass.MyResource.Bullet.ToString)
        資材資源量行追加("鋼材", MyDataClass.MyResource.Steel.ToString)
        資材資源量行追加("ボーキサイト", MyDataClass.MyResource.Bauxite.ToString)
        資材資源量行追加("高速建造材", MyDataClass.MyResource.HighspeedBuildingMaterial.ToString)
        資材資源量行追加("高速修復材", MyDataClass.MyResource.HighspeedRepairingMaterial.ToString)
        資材資源量行追加("開発資材", MyDataClass.MyResource.DevelopmentMaterial.ToString)
        資材資源量行追加("改修資材", MyDataClass.MyResource.ImprovementMaterial.ToString)



    End Sub

    Private Sub 資材資源量行追加(ByVal 名称 As String, ByVal 量 As String)
        資材資源量DataGridView.Rows.Add(名称, 量)
    End Sub

    Private Sub 母港及装備状態表示()
        母港収容状況.Text = String.Format("{0}/{1}", MyDataClass.MyKanmusu.Count, MyDataClass.Admiral.api_max_chara)
        装備数.Text = String.Format("{0}/{1}", MyDataClass.MyEquipment.Count, MyDataClass.Admiral.api_max_slotitem)
    End Sub

    Private Sub マップ状態表示()
        'とりあえず全削除
        If Me.マップ状態.Rows.Count > 0 Then
            For i = 0 To Me.マップ状態.Rows.Count - 1 Step 1
                Me.マップ状態.Rows.RemoveAt(0)
            Next
        End If

        '追加欄
        If MyDataClass.MapInfo.Count <> 128 Then
            For count As Integer = 0 To MyDataClass.MapInfo.Count - 1
                If MyDataClass.MapInfo(count).api_cleared = 0 Then
                    Dim マップ名 As String = ""
                    Dim 攻略状態 As String = ""

                    For cnt As Integer = 0 To CommonDataClass.MapInfo.Count - 1
                        If MyDataClass.MapInfo(count).api_id.Equals(CommonDataClass.MapInfo(cnt).api_id) Then
                            マップ名 = CommonDataClass.MapInfo(cnt).api_maparea_id.ToString + "-" + CommonDataClass.MapInfo(cnt).api_no.ToString
                            攻略状態 = MyDataClass.MapInfo(count).api_defeat_count.ToString + "/" + CommonDataClass.MapInfo(cnt).api_required_defeat_count.ToString
                            If CommonDataClass.MapInfo(cnt).api_max_maphp.ToString <> 0 Then
                                攻略状態 = MyDataClass.MapInfo(count).api_defeat_count.ToString + "/" + CommonDataClass.MapInfo(cnt).api_max_maphp.ToString
                            End If
                            Exit For
                        End If
                    Next


                    If マップ名 <> "" And マップ名 <> "0-0" Then
                        マップ状態.Rows.Add()
                        マップ状態.Rows(マップ状態.Rows.Count - 1).Cells(0).Value = マップ名
                        マップ状態.Rows(マップ状態.Rows.Count - 1).Cells(1).Value = 攻略状態

                    End If

                End If
            Next
        End If


    End Sub

    Private Sub 資材資源量更新タイマー_Tick(sender As Object, e As EventArgs) Handles 資材資源量更新タイマー.Tick
        資材資源量変更()
    End Sub
End Class