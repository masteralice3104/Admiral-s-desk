<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class オプション
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
        Me.艦これブラウザ設定 = New System.Windows.Forms.TabControl()
        Me.全般設定 = New System.Windows.Forms.TabPage()
        Me.大破通知 = New System.Windows.Forms.CheckBox()
        Me.保存ファイル名設定 = New System.Windows.Forms.Button()
        Me.保存ファイル名 = New System.Windows.Forms.TextBox()
        Me.入手艦娘記録 = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.動作調整バー = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.更新チェック = New System.Windows.Forms.CheckBox()
        Me.画面設定 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.拡大率調節バー = New System.Windows.Forms.TrackBar()
        Me.ドロップ艦娘保存 = New System.Windows.Forms.SaveFileDialog()
        Me.艦これブラウザ設定.SuspendLayout()
        Me.全般設定.SuspendLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.画面設定.SuspendLayout()
        CType(Me.拡大率調節バー, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '艦これブラウザ設定
        '
        Me.艦これブラウザ設定.Controls.Add(Me.全般設定)
        Me.艦これブラウザ設定.Controls.Add(Me.画面設定)
        Me.艦これブラウザ設定.Cursor = System.Windows.Forms.Cursors.Default
        Me.艦これブラウザ設定.Location = New System.Drawing.Point(12, 12)
        Me.艦これブラウザ設定.Name = "艦これブラウザ設定"
        Me.艦これブラウザ設定.SelectedIndex = 0
        Me.艦これブラウザ設定.Size = New System.Drawing.Size(260, 237)
        Me.艦これブラウザ設定.TabIndex = 0
        '
        '全般設定
        '
        Me.全般設定.Controls.Add(Me.大破通知)
        Me.全般設定.Controls.Add(Me.保存ファイル名設定)
        Me.全般設定.Controls.Add(Me.保存ファイル名)
        Me.全般設定.Controls.Add(Me.入手艦娘記録)
        Me.全般設定.Controls.Add(Me.Label5)
        Me.全般設定.Controls.Add(Me.Label4)
        Me.全般設定.Controls.Add(Me.Label3)
        Me.全般設定.Controls.Add(Me.Label2)
        Me.全般設定.Controls.Add(Me.動作調整バー)
        Me.全般設定.Controls.Add(Me.Label1)
        Me.全般設定.Controls.Add(Me.更新チェック)
        Me.全般設定.Location = New System.Drawing.Point(4, 22)
        Me.全般設定.Name = "全般設定"
        Me.全般設定.Padding = New System.Windows.Forms.Padding(3)
        Me.全般設定.Size = New System.Drawing.Size(252, 211)
        Me.全般設定.TabIndex = 0
        Me.全般設定.Text = "全般"
        Me.全般設定.UseVisualStyleBackColor = True
        '
        '大破通知
        '
        Me.大破通知.AutoSize = True
        Me.大破通知.Checked = Global.Admiral_s_Desk.My.MySettings.Default.大破通知
        Me.大破通知.CheckState = System.Windows.Forms.CheckState.Checked
        Me.大破通知.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "大破通知", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.大破通知.Location = New System.Drawing.Point(7, 78)
        Me.大破通知.Name = "大破通知"
        Me.大破通知.Size = New System.Drawing.Size(158, 16)
        Me.大破通知.TabIndex = 10
        Me.大破通知.Text = "戦闘時の大破艦を通知する"
        Me.大破通知.UseVisualStyleBackColor = True
        '
        '保存ファイル名設定
        '
        Me.保存ファイル名設定.Location = New System.Drawing.Point(171, 50)
        Me.保存ファイル名設定.Name = "保存ファイル名設定"
        Me.保存ファイル名設定.Size = New System.Drawing.Size(75, 23)
        Me.保存ファイル名設定.TabIndex = 9
        Me.保存ファイル名設定.Text = "開く"
        Me.保存ファイル名設定.UseVisualStyleBackColor = True
        '
        '保存ファイル名
        '
        Me.保存ファイル名.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "入手艦娘記録名", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.保存ファイル名.Location = New System.Drawing.Point(11, 52)
        Me.保存ファイル名.Name = "保存ファイル名"
        Me.保存ファイル名.ReadOnly = True
        Me.保存ファイル名.Size = New System.Drawing.Size(154, 19)
        Me.保存ファイル名.TabIndex = 8
        Me.保存ファイル名.Text = Global.Admiral_s_Desk.My.MySettings.Default.入手艦娘記録名
        '
        '入手艦娘記録
        '
        Me.入手艦娘記録.AutoSize = True
        Me.入手艦娘記録.Checked = Global.Admiral_s_Desk.My.MySettings.Default.入手艦娘記録
        Me.入手艦娘記録.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "入手艦娘記録", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.入手艦娘記録.Location = New System.Drawing.Point(7, 30)
        Me.入手艦娘記録.Name = "入手艦娘記録"
        Me.入手艦娘記録.Size = New System.Drawing.Size(196, 16)
        Me.入手艦娘記録.TabIndex = 7
        Me.入手艦娘記録.Text = "ドロップした艦娘を記録する(試験的)"
        Me.入手艦娘記録.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "x0.40"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "x0.50"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "x0.67"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "推奨"
        '
        '動作調整バー
        '
        Me.動作調整バー.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Admiral_s_Desk.My.MySettings.Default, "動作速度", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.動作調整バー.Location = New System.Drawing.Point(7, 160)
        Me.動作調整バー.Maximum = 3
        Me.動作調整バー.Name = "動作調整バー"
        Me.動作調整バー.Size = New System.Drawing.Size(237, 45)
        Me.動作調整バー.TabIndex = 2
        Me.動作調整バー.Value = Global.Admiral_s_Desk.My.MySettings.Default.動作速度
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "動作速度設定"
        '
        '更新チェック
        '
        Me.更新チェック.AutoSize = True
        Me.更新チェック.Checked = Global.Admiral_s_Desk.My.MySettings.Default.更新確認
        Me.更新チェック.CheckState = System.Windows.Forms.CheckState.Checked
        Me.更新チェック.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "更新確認", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.更新チェック.Location = New System.Drawing.Point(7, 7)
        Me.更新チェック.Name = "更新チェック"
        Me.更新チェック.Size = New System.Drawing.Size(155, 16)
        Me.更新チェック.TabIndex = 0
        Me.更新チェック.Text = "起動時に更新の確認をする"
        Me.更新チェック.UseVisualStyleBackColor = True
        '
        '画面設定
        '
        Me.画面設定.Controls.Add(Me.Label7)
        Me.画面設定.Controls.Add(Me.Label6)
        Me.画面設定.Controls.Add(Me.拡大率調節バー)
        Me.画面設定.Location = New System.Drawing.Point(4, 22)
        Me.画面設定.Name = "画面設定"
        Me.画面設定.Padding = New System.Windows.Forms.Padding(3)
        Me.画面設定.Size = New System.Drawing.Size(252, 211)
        Me.画面設定.TabIndex = 1
        Me.画面設定.Text = "画面"
        Me.画面設定.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "メイン画面の拡大率"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(239, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "25%    50%     75%   100%   125%    150%  175%"
        '
        '拡大率調節バー
        '
        Me.拡大率調節バー.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Admiral_s_Desk.My.MySettings.Default, "拡大率", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.拡大率調節バー.LargeChange = 2
        Me.拡大率調節バー.Location = New System.Drawing.Point(3, 23)
        Me.拡大率調節バー.Maximum = 6
        Me.拡大率調節バー.Name = "拡大率調節バー"
        Me.拡大率調節バー.Size = New System.Drawing.Size(243, 45)
        Me.拡大率調節バー.TabIndex = 0
        Me.拡大率調節バー.Value = Global.Admiral_s_Desk.My.MySettings.Default.拡大率
        '
        'オプション
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.艦これブラウザ設定)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "オプション"
        Me.Text = "オプション"
        Me.艦これブラウザ設定.ResumeLayout(False)
        Me.全般設定.ResumeLayout(False)
        Me.全般設定.PerformLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.画面設定.ResumeLayout(False)
        Me.画面設定.PerformLayout()
        CType(Me.拡大率調節バー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 艦これブラウザ設定 As TabControl
    Friend WithEvents 全般設定 As TabPage
    Friend WithEvents 更新チェック As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents 動作調整バー As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents 保存ファイル名設定 As Button
    Friend WithEvents 保存ファイル名 As TextBox
    Friend WithEvents 入手艦娘記録 As CheckBox
    Friend WithEvents ドロップ艦娘保存 As SaveFileDialog
    Friend WithEvents 大破通知 As CheckBox
    Friend WithEvents 画面設定 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents 拡大率調節バー As TrackBar
    Friend WithEvents Label7 As Label
End Class
