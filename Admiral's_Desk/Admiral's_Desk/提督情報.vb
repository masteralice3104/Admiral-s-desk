Public Class 提督情報
    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.提督情報アクセス.Checked = False
    End Sub

End Class