Public Class 資源等管理


    Private Sub 資源等管理_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 資源等一覧更新
        表示部分.Rows.Add("燃料", "0")
        表示部分.Rows.Add("弾薬", "0")
        表示部分.Rows.Add("鋼材", "0")
        表示部分.Rows.Add("ボーキサイト", "0")
        表示部分.Rows.Add("高速建造材", "0")
        表示部分.Rows.Add("高速修復材", "0")
        表示部分.Rows.Add("開発資材", "0")
        表示部分.Rows.Add("改修資材", "0")
    End Sub

    Private Sub 資源等一覧更新(oSession As Nekoxy.Session)
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

                For count = 0 To 7

                    Me.表示部分.Rows(count).Cells(1).Value = String.Format("{0}", JSONObject("api_data")("api_material")(count)("api_value"))
                Next
            ElseIf path.StartsWith("/kcsapi/api_req_hokyu/charge") Then
                For count = 0 To 3
                    Me.表示部分.Rows(count).Cells(1).Value = String.Format("{0}", JSONObject("api_data")("api_material")(count))
                Next
            End If

        End If

    End Sub

End Class