Public Class 遠征情報
    Private Sub 情報ウインドウ_Close() Handles MyBase.Closed
        'ここだけをいじる
        メインフォーム.遠征情報アクセス.Checked = False
    End Sub

End Class