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
        Me.ドロップ艦娘保存 = New System.Windows.Forms.SaveFileDialog()
        Me.debug = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.音量切替 = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.大破通知 = New System.Windows.Forms.CheckBox()
        Me.遠征終了通知チェック = New System.Windows.Forms.CheckBox()
        Me.全般設定 = New System.Windows.Forms.TabPage()
        Me.更新チェック = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.動作調整バー = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.入手艦娘記録 = New System.Windows.Forms.CheckBox()
        Me.保存ファイル名 = New System.Windows.Forms.TextBox()
        Me.保存ファイル名設定 = New System.Windows.Forms.Button()
        Me.設定 = New System.Windows.Forms.TabControl()
        Me.debug.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.全般設定.SuspendLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.設定.SuspendLayout()
        Me.SuspendLayout()
        '
        'debug
        '
        Me.debug.Controls.Add(Me.音量切替)
        Me.debug.Controls.Add(Me.Button1)
        Me.debug.Location = New System.Drawing.Point(4, 22)
        Me.debug.Name = "debug"
        Me.debug.Padding = New System.Windows.Forms.Padding(3)
        Me.debug.Size = New System.Drawing.Size(252, 211)
        Me.debug.TabIndex = 3
        Me.debug.Text = "debug"
        Me.debug.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "通知テスト"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '音量切替
        '
        Me.音量切替.Location = New System.Drawing.Point(89, 6)
        Me.音量切替.Name = "音量切替"
        Me.音量切替.Size = New System.Drawing.Size(75, 23)
        Me.音量切替.TabIndex = 1
        Me.音量切替.Text = "ミュートテスト"
        Me.音量切替.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.遠征終了通知チェック)
        Me.TabPage1.Controls.Add(Me.大破通知)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(252, 211)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "通知"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        '大破通知
        '
        Me.大破通知.AutoSize = True
        Me.大破通知.Checked = Global.Admiral_s_Desk.My.MySettings.Default.大破通知
        Me.大破通知.CheckState = System.Windows.Forms.CheckState.Checked
        Me.大破通知.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "大破通知", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.大破通知.Location = New System.Drawing.Point(6, 6)
        Me.大破通知.Name = "大破通知"
        Me.大破通知.Size = New System.Drawing.Size(158, 16)
        Me.大破通知.TabIndex = 11
        Me.大破通知.Text = "戦闘時の大破艦を通知する"
        Me.大破通知.UseVisualStyleBackColor = True
        '
        '遠征終了通知チェック
        '
        Me.遠征終了通知チェック.AutoSize = True
        Me.遠征終了通知チェック.Checked = Global.Admiral_s_Desk.My.MySettings.Default.遠征終了通知設定
        Me.遠征終了通知チェック.CheckState = System.Windows.Forms.CheckState.Checked
        Me.遠征終了通知チェック.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "遠征終了通知設定", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.遠征終了通知チェック.Location = New System.Drawing.Point(6, 28)
        Me.遠征終了通知チェック.Name = "遠征終了通知チェック"
        Me.遠征終了通知チェック.Size = New System.Drawing.Size(136, 16)
        Me.遠征終了通知チェック.TabIndex = 12
        Me.遠征終了通知チェック.Text = "遠征終了時に通知する"
        Me.遠征終了通知チェック.UseVisualStyleBackColor = True
        '
        '全般設定
        '
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "動作速度設定"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "推奨"
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
        '保存ファイル名設定
        '
        Me.保存ファイル名設定.Location = New System.Drawing.Point(171, 50)
        Me.保存ファイル名設定.Name = "保存ファイル名設定"
        Me.保存ファイル名設定.Size = New System.Drawing.Size(75, 23)
        Me.保存ファイル名設定.TabIndex = 9
        Me.保存ファイル名設定.Text = "開く"
        Me.保存ファイル名設定.UseVisualStyleBackColor = True
        '
        '設定
        '
        Me.設定.Controls.Add(Me.全般設定)
        Me.設定.Controls.Add(Me.TabPage1)
        Me.設定.Controls.Add(Me.debug)
        Me.設定.Cursor = System.Windows.Forms.Cursors.Default
        Me.設定.Location = New System.Drawing.Point(12, 12)
        Me.設定.Name = "設定"
        Me.設定.SelectedIndex = 0
        Me.設定.Size = New System.Drawing.Size(260, 237)
        Me.設定.TabIndex = 0
        '
        'オプション
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.設定)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 300)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "オプション"
        Me.Text = "オプション"
        Me.debug.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.全般設定.ResumeLayout(False)
        Me.全般設定.PerformLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.設定.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ドロップ艦娘保存 As SaveFileDialog
    Friend WithEvents debug As TabPage
    Friend WithEvents 音量切替 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents 遠征終了通知チェック As CheckBox
    Friend WithEvents 大破通知 As CheckBox
    Friend WithEvents 全般設定 As TabPage
    Friend WithEvents 保存ファイル名設定 As Button
    Friend WithEvents 保存ファイル名 As TextBox
    Friend WithEvents 入手艦娘記録 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents 動作調整バー As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents 更新チェック As CheckBox
    Friend WithEvents 設定 As TabControl
End Class
