Public Class 艦隊情報
    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.艦隊情報アクセス.Checked = False
    End Sub


End Class