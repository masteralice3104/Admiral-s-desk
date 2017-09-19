Public Class バージョン情報




    Private Sub OKボタン_Click(sender As Object, e As EventArgs) Handles OKボタン.Click
        'OKボタンを押下したらこの「バージョン情報」ウインドウは閉じられる
        Me.Close()
    End Sub

    Private Sub バージョン情報_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'このウインドウには最大化や最小化、閉じるボタンは必要ないので消す
        Me.ControlBox = Not Me.ControlBox

        '画面の真ん中に表示するために設定
        Me.StartPosition = FormStartPosition.CenterScreen

        'このウインドウを最前面にする
        Me.TopMost = True

    End Sub
End Class