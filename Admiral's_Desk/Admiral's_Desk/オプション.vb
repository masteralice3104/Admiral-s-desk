Public Class オプション
    Public Shared 動作速度設定 As Double = 1.0
    Private Sub 動作調整バー_Scroll(sender As Object, e As EventArgs) Handles 動作調整バー.Scroll

        If 動作調整バー.Value = 3 Then
            動作速度設定 = 1.0
        ElseIf 動作調整バー.Value = 2 Then
            動作速度設定 = 1.5
        ElseIf 動作調整バー.Value = 1 Then
            動作速度設定 = 2.0
        ElseIf 動作調整バー.Value = 0 Then
            動作速度設定 = 2.5
        End If

    End Sub

    Private Sub オプション_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If 動作調整バー.Value = 3 Then
            動作速度設定 = 1.0
        ElseIf 動作調整バー.Value = 2 Then
            動作速度設定 = 1.5
        ElseIf 動作調整バー.Value = 1 Then
            動作速度設定 = 2.0
        ElseIf 動作調整バー.Value = 0 Then
            動作速度設定 = 2.5
        End If
    End Sub
End Class