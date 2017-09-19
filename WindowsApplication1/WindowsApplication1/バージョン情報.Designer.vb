<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class バージョン情報
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.プログラム名 = New System.Windows.Forms.Label()
        Me.バージョン番号 = New System.Windows.Forms.Label()
        Me.OKボタン = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'プログラム名
        '
        Me.プログラム名.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.プログラム名.AutoSize = True
        Me.プログラム名.Location = New System.Drawing.Point(21, 9)
        Me.プログラム名.Name = "プログラム名"
        Me.プログラム名.Size = New System.Drawing.Size(85, 12)
        Me.プログラム名.TabIndex = 0
        Me.プログラム名.Text = "名称未設定soft"
        '
        'バージョン番号
        '
        Me.バージョン番号.AutoSize = True
        Me.バージョン番号.Location = New System.Drawing.Point(12, 21)
        Me.バージョン番号.Name = "バージョン番号"
        Me.バージョン番号.Size = New System.Drawing.Size(118, 12)
        Me.バージョン番号.TabIndex = 1
        Me.バージョン番号.Text = "ver. alpha 0.0.1.170918"
        '
        'OKボタン
        '
        Me.OKボタン.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OKボタン.Location = New System.Drawing.Point(31, 46)
        Me.OKボタン.Name = "OKボタン"
        Me.OKボタン.Size = New System.Drawing.Size(75, 23)
        Me.OKボタン.TabIndex = 2
        Me.OKボタン.Text = "OK(&O)"
        Me.OKボタン.UseVisualStyleBackColor = True
        '
        'バージョン情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(134, 81)
        Me.Controls.Add(Me.OKボタン)
        Me.Controls.Add(Me.バージョン番号)
        Me.Controls.Add(Me.プログラム名)
        Me.Name = "バージョン情報"
        Me.Text = "バージョン情報"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents プログラム名 As Label
    Friend WithEvents バージョン番号 As Label
    Friend WithEvents OKボタン As Button
End Class
