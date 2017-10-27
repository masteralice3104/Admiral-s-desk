Imports System
Imports System.Threading

Public Class 遠征情報表示

    Private Sub 遠征情報表示_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Nekoxy.HttpProxy.AfterSessionComplete, AddressOf 遠征情報更新

        遠征情報.Rows.Add("", "")
        遠征情報.Rows.Add("", "")
        遠征情報.Rows.Add("", "")
        遠征情報.Rows(0).Cells(1).Tag = "0"
        遠征情報.Rows(1).Cells(1).Tag = "0"
        遠征情報.Rows(2).Cells(1).Tag = "0"
        毎秒更新タイマー.Enabled = True
    End Sub

    Private Sub 遠征情報更新(oSession As Nekoxy.Session)
        'とりあえずNekoxyからパスを受け取る
        Dim path As String = oSession.Request.PathAndQuery

        'JSONのデータもぶち込む
        Dim JSONtemporaryData As String = oSession.Response.BodyAsString

        If (path.StartsWith("/kcsapi/api_")) Then
            'JSONの先頭にある余計な文字を取り除く
            Dim JSONData As String = JSONtemporaryData.Substring(7)

            'JSON文字列→JSON形式データに復元
            Dim JSONObject As Object = Newtonsoft.Json.JsonConvert.DeserializeObject(JSONData)

            'これがJSONのデータを表示する部分だ
            If path.StartsWith("/kcsapi/api_get_member/deck") Then
                For count = 1 To 3
                    Me.遠征情報.Rows(count - 1).Cells(1).Tag = Format("{0}", JSONObject("api_data")(count)("api_mission")(2))
                Next
            ElseIf path.StartsWith("/kcsapi/api_port/port") Then
                For count = 1 To 3
                    Me.遠征情報.Rows(count - 1).Cells(1).Tag = Format("{0}", JSONObject("api_data")("api_deck_port")(count)("api_mission")(2))
                Next

            End If

        End If

    End Sub

    Private Sub 毎秒更新()
        For count = 0 To 2
            Dim Span As TimeSpan
            If Me.遠征情報.Rows(count).Cells(1).Tag <> "0" Then
                Dim Thistime As DateTimeOffset = DateTimeOffset.UtcNow
                Span = DateTimeOffset.FromUnixTimeSeconds(Long.Parse(Me.遠征情報.Rows(count).Cells(1).Tag) / 1000) - Thistime
                Dim Time As Long = Span.TotalSeconds
                If Time > "0" Then
                    Me.遠征情報.Rows(count).Cells(1).Value = Span.ToString("hh\:mm\:ss")
                Else
                    Me.遠征情報.Rows(count).Cells(1).Value = "00:00:00"
                End If
            Else
                Me.遠征情報.Rows(count).Cells(1).Value = ""
            End If
        Next
        Me.遠征情報.Rows(0).Cells(0).Value = 艦隊情報一覧.艦隊名2
        Me.遠征情報.Rows(1).Cells(0).Value = 艦隊情報一覧.艦隊名3
        Me.遠征情報.Rows(2).Cells(0).Value = 艦隊情報一覧.艦隊名4

    End Sub





    Private Sub 毎秒更新タイマー_Tick(sender As Object, e As EventArgs) Handles 毎秒更新タイマー.Tick
        毎秒更新()
    End Sub

    Private Sub 遠征情報_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles 遠征情報.CellContentClick

    End Sub
End Class