<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class オプション
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ドロップ艦娘保存 = New System.Windows.Forms.SaveFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.保存ファイル名設定 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.拡大率 = New System.Windows.Forms.GroupBox()
        Me.port = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.三分の二モード = New System.Windows.Forms.Button()
        Me.ハードウェアアクセラレーション = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.等倍モード = New System.Windows.Forms.Button()
        Me.ブラウザ座標Y = New System.Windows.Forms.TextBox()
        Me.プロキシ設定_host = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.プロキシ利用 = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ブラウザ座標X = New System.Windows.Forms.TextBox()
        Me.画面設定適用 = New System.Windows.Forms.Button()
        Me.ブラウザ拡大率 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.遠征終了時SEファイル名選択 = New System.Windows.Forms.Button()
        Me.遠征終了時SEファイルパス = New System.Windows.Forms.TextBox()
        Me.遠征終了時SE = New System.Windows.Forms.CheckBox()
        Me.大破通知 = New System.Windows.Forms.CheckBox()
        Me.遠征終了通知チェック = New System.Windows.Forms.CheckBox()
        Me.疲労回復通知チェック = New System.Windows.Forms.CheckBox()
        Me.通知秒 = New System.Windows.Forms.TextBox()
        Me.遠征終了時SEファイル名 = New System.Windows.Forms.OpenFileDialog()
        Me.保存ファイル名 = New System.Windows.Forms.TextBox()
        Me.更新チェック = New System.Windows.Forms.CheckBox()
        Me.動作調整バー = New System.Windows.Forms.TrackBar()
        Me.入手艦娘記録 = New System.Windows.Forms.CheckBox()
        Me.通知秒設定適用 = New System.Windows.Forms.Button()
        Me.拡大率.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 12)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "秒前に通知する"
        '
        '保存ファイル名設定
        '
        Me.保存ファイル名設定.Location = New System.Drawing.Point(186, 53)
        Me.保存ファイル名設定.Name = "保存ファイル名設定"
        Me.保存ファイル名設定.Size = New System.Drawing.Size(75, 23)
        Me.保存ファイル名設定.TabIndex = 9
        Me.保存ファイル名設定.Text = "開く"
        Me.保存ファイル名設定.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "x0.40"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "x0.50"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "x0.67"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "推奨"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "動作速度設定"
        '
        '拡大率
        '
        Me.拡大率.Controls.Add(Me.port)
        Me.拡大率.Controls.Add(Me.Label9)
        Me.拡大率.Controls.Add(Me.三分の二モード)
        Me.拡大率.Controls.Add(Me.ハードウェアアクセラレーション)
        Me.拡大率.Controls.Add(Me.Label8)
        Me.拡大率.Controls.Add(Me.等倍モード)
        Me.拡大率.Controls.Add(Me.ブラウザ座標Y)
        Me.拡大率.Controls.Add(Me.プロキシ設定_host)
        Me.拡大率.Controls.Add(Me.Label10)
        Me.拡大率.Controls.Add(Me.Label12)
        Me.拡大率.Controls.Add(Me.プロキシ利用)
        Me.拡大率.Controls.Add(Me.Label11)
        Me.拡大率.Controls.Add(Me.ブラウザ座標X)
        Me.拡大率.Controls.Add(Me.画面設定適用)
        Me.拡大率.Controls.Add(Me.ブラウザ拡大率)
        Me.拡大率.Location = New System.Drawing.Point(323, 12)
        Me.拡大率.Name = "拡大率"
        Me.拡大率.Size = New System.Drawing.Size(249, 165)
        Me.拡大率.TabIndex = 0
        Me.拡大率.TabStop = False
        Me.拡大率.Text = "ブラウザ設定"
        '
        'port
        '
        Me.port.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "プロキシポート設定", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.port.Location = New System.Drawing.Point(188, 136)
        Me.port.Mask = "00000"
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(58, 19)
        Me.port.TabIndex = 15
        Me.port.Text = Global.Admiral_s_Desk.My.MySettings.Default.プロキシポート設定
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(157, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(25, 12)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "port"
        '
        '三分の二モード
        '
        Me.三分の二モード.Location = New System.Drawing.Point(2, 63)
        Me.三分の二モード.Name = "三分の二モード"
        Me.三分の二モード.Size = New System.Drawing.Size(75, 23)
        Me.三分の二モード.TabIndex = 11
        Me.三分の二モード.Text = "66.67%"
        Me.三分の二モード.UseVisualStyleBackColor = True
        '
        'ハードウェアアクセラレーション
        '
        Me.ハードウェアアクセラレーション.AutoSize = True
        Me.ハードウェアアクセラレーション.Checked = Global.Admiral_s_Desk.My.MySettings.Default.ハードウェアアクセラレーション
        Me.ハードウェアアクセラレーション.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "ハードウェアアクセラレーション", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ハードウェアアクセラレーション.Location = New System.Drawing.Point(2, 92)
        Me.ハードウェアアクセラレーション.Name = "ハードウェアアクセラレーション"
        Me.ハードウェアアクセラレーション.Size = New System.Drawing.Size(218, 16)
        Me.ハードウェアアクセラレーション.TabIndex = 1
        Me.ハードウェアアクセラレーション.Text = "ハードウェアアクセラレーションを無効にする"
        Me.ハードウェアアクセラレーション.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(27, 12)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "host"
        '
        '等倍モード
        '
        Me.等倍モード.Location = New System.Drawing.Point(83, 63)
        Me.等倍モード.Name = "等倍モード"
        Me.等倍モード.Size = New System.Drawing.Size(75, 23)
        Me.等倍モード.TabIndex = 10
        Me.等倍モード.Text = "100%"
        Me.等倍モード.UseVisualStyleBackColor = True
        '
        'ブラウザ座標Y
        '
        Me.ブラウザ座標Y.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "ブラウザ座標Y", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ブラウザ座標Y.Location = New System.Drawing.Point(155, 38)
        Me.ブラウザ座標Y.Name = "ブラウザ座標Y"
        Me.ブラウザ座標Y.Size = New System.Drawing.Size(60, 19)
        Me.ブラウザ座標Y.TabIndex = 9
        Me.ブラウザ座標Y.Text = Global.Admiral_s_Desk.My.MySettings.Default.ブラウザ座標Y
        '
        'プロキシ設定_host
        '
        Me.プロキシ設定_host.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "プロキシ利用設定", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.プロキシ設定_host.Enabled = False
        Me.プロキシ設定_host.Location = New System.Drawing.Point(55, 136)
        Me.プロキシ設定_host.Name = "プロキシ設定_host"
        Me.プロキシ設定_host.Size = New System.Drawing.Size(96, 19)
        Me.プロキシ設定_host.TabIndex = 12
        Me.プロキシ設定_host.Text = Global.Admiral_s_Desk.My.MySettings.Default.プロキシ利用設定
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 12)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "ブラウザ拡大率"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 12)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "ブラウザ座標"
        '
        'プロキシ利用
        '
        Me.プロキシ利用.AutoSize = True
        Me.プロキシ利用.Checked = Global.Admiral_s_Desk.My.MySettings.Default.プロキシ利用
        Me.プロキシ利用.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "プロキシ利用", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.プロキシ利用.Location = New System.Drawing.Point(2, 114)
        Me.プロキシ利用.Name = "プロキシ利用"
        Me.プロキシ利用.Size = New System.Drawing.Size(166, 16)
        Me.プロキシ利用.TabIndex = 11
        Me.プロキシ利用.Text = "上流プロキシを使用する(http)"
        Me.プロキシ利用.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(201, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "%"
        '
        'ブラウザ座標X
        '
        Me.ブラウザ座標X.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "ブラウザ座標X", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ブラウザ座標X.Location = New System.Drawing.Point(89, 38)
        Me.ブラウザ座標X.Name = "ブラウザ座標X"
        Me.ブラウザ座標X.Size = New System.Drawing.Size(60, 19)
        Me.ブラウザ座標X.TabIndex = 7
        Me.ブラウザ座標X.Text = Global.Admiral_s_Desk.My.MySettings.Default.ブラウザ座標X
        '
        '画面設定適用
        '
        Me.画面設定適用.Location = New System.Drawing.Point(164, 63)
        Me.画面設定適用.Name = "画面設定適用"
        Me.画面設定適用.Size = New System.Drawing.Size(75, 23)
        Me.画面設定適用.TabIndex = 5
        Me.画面設定適用.Text = "適用"
        Me.画面設定適用.UseVisualStyleBackColor = True
        '
        'ブラウザ拡大率
        '
        Me.ブラウザ拡大率.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "ブラウザ拡大率", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ブラウザ拡大率.Location = New System.Drawing.Point(89, 12)
        Me.ブラウザ拡大率.Name = "ブラウザ拡大率"
        Me.ブラウザ拡大率.Size = New System.Drawing.Size(100, 19)
        Me.ブラウザ拡大率.TabIndex = 6
        Me.ブラウザ拡大率.Text = Global.Admiral_s_Desk.My.MySettings.Default.ブラウザ拡大率
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.通知秒設定適用)
        Me.GroupBox1.Controls.Add(Me.遠征終了時SEファイル名選択)
        Me.GroupBox1.Controls.Add(Me.遠征終了時SEファイルパス)
        Me.GroupBox1.Controls.Add(Me.遠征終了時SE)
        Me.GroupBox1.Controls.Add(Me.大破通知)
        Me.GroupBox1.Controls.Add(Me.遠征終了通知チェック)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.疲労回復通知チェック)
        Me.GroupBox1.Controls.Add(Me.通知秒)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 154)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "通知設定"
        '
        '遠征終了時SEファイル名選択
        '
        Me.遠征終了時SEファイル名選択.Location = New System.Drawing.Point(162, 105)
        Me.遠征終了時SEファイル名選択.Name = "遠征終了時SEファイル名選択"
        Me.遠征終了時SEファイル名選択.Size = New System.Drawing.Size(75, 23)
        Me.遠征終了時SEファイル名選択.TabIndex = 18
        Me.遠征終了時SEファイル名選択.Text = "開く"
        Me.遠征終了時SEファイル名選択.UseVisualStyleBackColor = True
        '
        '遠征終了時SEファイルパス
        '
        Me.遠征終了時SEファイルパス.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "遠征完了時SEファイルパス", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.遠征終了時SEファイルパス.Location = New System.Drawing.Point(34, 107)
        Me.遠征終了時SEファイルパス.Name = "遠征終了時SEファイルパス"
        Me.遠征終了時SEファイルパス.ReadOnly = True
        Me.遠征終了時SEファイルパス.Size = New System.Drawing.Size(121, 19)
        Me.遠征終了時SEファイルパス.TabIndex = 17
        Me.遠征終了時SEファイルパス.Text = Global.Admiral_s_Desk.My.MySettings.Default.遠征完了時SEファイルパス
        '
        '遠征終了時SE
        '
        Me.遠征終了時SE.AutoSize = True
        Me.遠征終了時SE.Checked = Global.Admiral_s_Desk.My.MySettings.Default.遠征完了時SE
        Me.遠征終了時SE.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "遠征完了時SE", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.遠征終了時SE.Location = New System.Drawing.Point(20, 86)
        Me.遠征終了時SE.Name = "遠征終了時SE"
        Me.遠征終了時SE.Size = New System.Drawing.Size(114, 16)
        Me.遠征終了時SE.TabIndex = 16
        Me.遠征終了時SE.Text = "通知時にSEを流す"
        Me.遠征終了時SE.UseVisualStyleBackColor = True
        '
        '大破通知
        '
        Me.大破通知.AutoSize = True
        Me.大破通知.Checked = Global.Admiral_s_Desk.My.MySettings.Default.大破通知
        Me.大破通知.CheckState = System.Windows.Forms.CheckState.Checked
        Me.大破通知.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "大破通知", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.大破通知.Location = New System.Drawing.Point(6, 18)
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
        Me.遠征終了通知チェック.Location = New System.Drawing.Point(6, 40)
        Me.遠征終了通知チェック.Name = "遠征終了通知チェック"
        Me.遠征終了通知チェック.Size = New System.Drawing.Size(136, 16)
        Me.遠征終了通知チェック.TabIndex = 12
        Me.遠征終了通知チェック.Text = "遠征終了時に通知する"
        Me.遠征終了通知チェック.UseVisualStyleBackColor = True
        '
        '疲労回復通知チェック
        '
        Me.疲労回復通知チェック.AutoSize = True
        Me.疲労回復通知チェック.Checked = Global.Admiral_s_Desk.My.MySettings.Default.疲労回復通知保存
        Me.疲労回復通知チェック.CheckState = System.Windows.Forms.CheckState.Checked
        Me.疲労回復通知チェック.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "疲労回復通知保存", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.疲労回復通知チェック.Location = New System.Drawing.Point(6, 132)
        Me.疲労回復通知チェック.Name = "疲労回復通知チェック"
        Me.疲労回復通知チェック.Size = New System.Drawing.Size(160, 16)
        Me.疲労回復通知チェック.TabIndex = 13
        Me.疲労回復通知チェック.Text = "疲労回復終了時に通知する"
        Me.疲労回復通知チェック.UseVisualStyleBackColor = True
        '
        '通知秒
        '
        Me.通知秒.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "通知秒数", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.通知秒.Location = New System.Drawing.Point(20, 61)
        Me.通知秒.Name = "通知秒"
        Me.通知秒.Size = New System.Drawing.Size(35, 19)
        Me.通知秒.TabIndex = 14
        Me.通知秒.Text = Global.Admiral_s_Desk.My.MySettings.Default.通知秒数
        '
        '遠征終了時SEファイル名
        '
        Me.遠征終了時SEファイル名.FileName = "OpenFileDialog1"
        '
        '保存ファイル名
        '
        Me.保存ファイル名.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.Admiral_s_Desk.My.MySettings.Default, "入手艦娘記録名", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.保存ファイル名.Location = New System.Drawing.Point(26, 56)
        Me.保存ファイル名.Name = "保存ファイル名"
        Me.保存ファイル名.ReadOnly = True
        Me.保存ファイル名.Size = New System.Drawing.Size(154, 19)
        Me.保存ファイル名.TabIndex = 8
        Me.保存ファイル名.Text = Global.Admiral_s_Desk.My.MySettings.Default.入手艦娘記録名
        '
        '更新チェック
        '
        Me.更新チェック.AutoSize = True
        Me.更新チェック.Checked = Global.Admiral_s_Desk.My.MySettings.Default.更新確認
        Me.更新チェック.CheckState = System.Windows.Forms.CheckState.Checked
        Me.更新チェック.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "更新確認", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.更新チェック.Location = New System.Drawing.Point(12, 12)
        Me.更新チェック.Name = "更新チェック"
        Me.更新チェック.Size = New System.Drawing.Size(155, 16)
        Me.更新チェック.TabIndex = 0
        Me.更新チェック.Text = "起動時に更新の確認をする"
        Me.更新チェック.UseVisualStyleBackColor = True
        '
        '動作調整バー
        '
        Me.動作調整バー.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Admiral_s_Desk.My.MySettings.Default, "動作速度", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.動作調整バー.Location = New System.Drawing.Point(12, 103)
        Me.動作調整バー.Maximum = 3
        Me.動作調整バー.Name = "動作調整バー"
        Me.動作調整バー.Size = New System.Drawing.Size(237, 45)
        Me.動作調整バー.TabIndex = 2
        Me.動作調整バー.Value = Global.Admiral_s_Desk.My.MySettings.Default.動作速度
        '
        '入手艦娘記録
        '
        Me.入手艦娘記録.AutoSize = True
        Me.入手艦娘記録.Checked = Global.Admiral_s_Desk.My.MySettings.Default.入手艦娘記録
        Me.入手艦娘記録.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "入手艦娘記録", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.入手艦娘記録.Location = New System.Drawing.Point(12, 34)
        Me.入手艦娘記録.Name = "入手艦娘記録"
        Me.入手艦娘記録.Size = New System.Drawing.Size(196, 16)
        Me.入手艦娘記録.TabIndex = 7
        Me.入手艦娘記録.Text = "ドロップした艦娘を記録する(試験的)"
        Me.入手艦娘記録.UseVisualStyleBackColor = True
        '
        '通知秒設定適用
        '
        Me.通知秒設定適用.Location = New System.Drawing.Point(162, 59)
        Me.通知秒設定適用.Name = "通知秒設定適用"
        Me.通知秒設定適用.Size = New System.Drawing.Size(75, 23)
        Me.通知秒設定適用.TabIndex = 19
        Me.通知秒設定適用.Text = "適用"
        Me.通知秒設定適用.UseVisualStyleBackColor = True
        '
        'オプション
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.拡大率)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.保存ファイル名)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.保存ファイル名設定)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.更新チェック)
        Me.Controls.Add(Me.動作調整バー)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.入手艦娘記録)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 400)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "オプション"
        Me.Text = "オプション"
        Me.拡大率.ResumeLayout(False)
        Me.拡大率.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ドロップ艦娘保存 As SaveFileDialog
    Friend WithEvents 遠征終了通知チェック As CheckBox
    Friend WithEvents 大破通知 As CheckBox
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
    Friend WithEvents 疲労回復通知チェック As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents 通知秒 As TextBox
    Friend WithEvents ハードウェアアクセラレーション As CheckBox
    Friend WithEvents 拡大率 As GroupBox
    Friend WithEvents port As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents 三分の二モード As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents 等倍モード As Button
    Friend WithEvents ブラウザ座標Y As TextBox
    Friend WithEvents プロキシ設定_host As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents プロキシ利用 As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents ブラウザ座標X As TextBox
    Friend WithEvents 画面設定適用 As Button
    Friend WithEvents ブラウザ拡大率 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents 遠征終了時SEファイル名選択 As Button
    Friend WithEvents 遠征終了時SEファイルパス As TextBox
    Friend WithEvents 遠征終了時SE As CheckBox
    Friend WithEvents 遠征終了時SEファイル名 As OpenFileDialog
    Friend WithEvents 通知秒設定適用 As Button
End Class
