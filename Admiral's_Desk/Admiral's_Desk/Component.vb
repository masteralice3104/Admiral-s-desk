Public Class Component
    '   Public Function KancolleReadJson(oSession As Object)
    '   引数
    '   oSession    Nekoxy.Session型のセッションデータ
    '   
    '   返値
    '   艦これのデータ時はNewtonsoft.Json.Linq.JObject型のJSONオブジェクトデータ
    '   異常値及び艦これのデータではないと判別したときは何も返さない
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
End Class
