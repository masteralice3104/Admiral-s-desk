<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class メインフォーム
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.エクスポートEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.中止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.遠征支援SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オプションoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ミュート切り替え = New System.Windows.Forms.Button()
        Me.スクリーンショット撮影 = New System.Windows.Forms.Button()
        Me.戦闘予報アクセス = New System.Windows.Forms.CheckBox()
        Me.全艦娘一覧ウインドウ表示 = New System.Windows.Forms.Button()
        Me.遠征情報アクセス = New System.Windows.Forms.CheckBox()
        Me.任務情報アクセス = New System.Windows.Forms.CheckBox()
        Me.工廠情報アクセス = New System.Windows.Forms.CheckBox()
        Me.基地航空隊情報アクセス = New System.Windows.Forms.CheckBox()
        Me.艦隊情報アクセス = New System.Windows.Forms.CheckBox()
        Me.提督情報アクセス = New System.Windows.Forms.CheckBox()
        Me.情報アクセスラベル = New System.Windows.Forms.Label()
        Me.更新確認ブラウザ = New System.Windows.Forms.WebBrowser()
        Me.更新URL確認用ブラウザ = New System.Windows.Forms.WebBrowser()
        Me.汎用タイマ = New System.Windows.Forms.Timer(Me.components)
        Me.通知領域 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.bp = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ツールTToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1204, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.エクスポートEToolStripMenuItem, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'エクスポートEToolStripMenuItem
        '
        Me.エクスポートEToolStripMenuItem.Enabled = False
        Me.エクスポートEToolStripMenuItem.Name = "エクスポートEToolStripMenuItem"
        Me.エクスポートEToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.エクスポートEToolStripMenuItem.Text = "エクスポート(&M)"
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.更新ToolStripMenuItem, Me.中止ToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        '更新ToolStripMenuItem
        '
        Me.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem"
        Me.更新ToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.更新ToolStripMenuItem.Text = "更新(&R)"
        '
        '中止ToolStripMenuItem
        '
        Me.中止ToolStripMenuItem.Name = "中止ToolStripMenuItem"
        Me.中止ToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.中止ToolStripMenuItem.Text = "中止(&P)"
        '
        'ツールTToolStripMenuItem
        '
        Me.ツールTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.遠征支援SToolStripMenuItem, Me.オプションoToolStripMenuItem})
        Me.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem"
        Me.ツールTToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ツールTToolStripMenuItem.Text = "ツール(&T)"
        '
        '遠征支援SToolStripMenuItem
        '
        Me.遠征支援SToolStripMenuItem.Name = "遠征支援SToolStripMenuItem"
        Me.遠征支援SToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.遠征支援SToolStripMenuItem.Text = "遠征支援(&S)"
        '
        'オプションoToolStripMenuItem
        '
        Me.オプションoToolStripMenuItem.Name = "オプションoToolStripMenuItem"
        Me.オプションoToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.オプションoToolStripMenuItem.Text = "オプション(&O)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ヘルプHToolStripMenuItem1})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'ヘルプHToolStripMenuItem1
        '
        Me.ヘルプHToolStripMenuItem1.Enabled = False
        Me.ヘルプHToolStripMenuItem1.Name = "ヘルプHToolStripMenuItem1"
        Me.ヘルプHToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.ヘルプHToolStripMenuItem1.Text = "ヘルプ(&H)"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ミュート切り替え)
        Me.Panel1.Controls.Add(Me.スクリーンショット撮影)
        Me.Panel1.Controls.Add(Me.戦闘予報アクセス)
        Me.Panel1.Controls.Add(Me.全艦娘一覧ウインドウ表示)
        Me.Panel1.Controls.Add(Me.遠征情報アクセス)
        Me.Panel1.Controls.Add(Me.任務情報アクセス)
        Me.Panel1.Controls.Add(Me.工廠情報アクセス)
        Me.Panel1.Controls.Add(Me.基地航空隊情報アクセス)
        Me.Panel1.Controls.Add(Me.艦隊情報アクセス)
        Me.Panel1.Controls.Add(Me.提督情報アクセス)
        Me.Panel1.Controls.Add(Me.情報アクセスラベル)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 749)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 41)
        Me.Panel1.TabIndex = 2
        '
        'ミュート切り替え
        '
        Me.ミュート切り替え.Dock = System.Windows.Forms.DockStyle.Right
        Me.ミュート切り替え.Location = New System.Drawing.Point(979, 12)
        Me.ミュート切り替え.Name = "ミュート切り替え"
        Me.ミュート切り替え.Size = New System.Drawing.Size(75, 29)
        Me.ミュート切り替え.TabIndex = 10
        Me.ミュート切り替え.Text = "ミュート"
        Me.ミュート切り替え.UseVisualStyleBackColor = True
        '
        'スクリーンショット撮影
        '
        Me.スクリーンショット撮影.Dock = System.Windows.Forms.DockStyle.Right
        Me.スクリーンショット撮影.Enabled = False
        Me.スクリーンショット撮影.Location = New System.Drawing.Point(1054, 12)
        Me.スクリーンショット撮影.Name = "スクリーンショット撮影"
        Me.スクリーンショット撮影.Size = New System.Drawing.Size(75, 29)
        Me.スクリーンショット撮影.TabIndex = 9
        Me.スクリーンショット撮影.Text = "SS撮影！"
        Me.スクリーンショット撮影.UseVisualStyleBackColor = True
        '
        '戦闘予報アクセス
        '
        Me.戦闘予報アクセス.AutoSize = True
        Me.戦闘予報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.戦闘予報ウインドウ表示
        Me.戦闘予報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "戦闘予報ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.戦闘予報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.戦闘予報アクセス.Enabled = False
        Me.戦闘予報アクセス.Location = New System.Drawing.Point(324, 12)
        Me.戦闘予報アクセス.Name = "戦闘予報アクセス"
        Me.戦闘予報アクセス.Size = New System.Drawing.Size(72, 29)
        Me.戦闘予報アクセス.TabIndex = 8
        Me.戦闘予報アクセス.Text = "戦闘予報"
        Me.戦闘予報アクセス.UseVisualStyleBackColor = True
        '
        '全艦娘一覧ウインドウ表示
        '
        Me.全艦娘一覧ウインドウ表示.Dock = System.Windows.Forms.DockStyle.Right
        Me.全艦娘一覧ウインドウ表示.Location = New System.Drawing.Point(1129, 12)
        Me.全艦娘一覧ウインドウ表示.Name = "全艦娘一覧ウインドウ表示"
        Me.全艦娘一覧ウインドウ表示.Size = New System.Drawing.Size(75, 29)
        Me.全艦娘一覧ウインドウ表示.TabIndex = 7
        Me.全艦娘一覧ウインドウ表示.Text = "全艦娘一覧"
        Me.全艦娘一覧ウインドウ表示.UseVisualStyleBackColor = True
        '
        '遠征情報アクセス
        '
        Me.遠征情報アクセス.AutoSize = True
        Me.遠征情報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.遠征ウインドウ表示
        Me.遠征情報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "遠征ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.遠征情報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.遠征情報アクセス.Location = New System.Drawing.Point(276, 12)
        Me.遠征情報アクセス.Name = "遠征情報アクセス"
        Me.遠征情報アクセス.Size = New System.Drawing.Size(48, 29)
        Me.遠征情報アクセス.TabIndex = 6
        Me.遠征情報アクセス.Text = "遠征"
        Me.遠征情報アクセス.UseVisualStyleBackColor = True
        '
        '任務情報アクセス
        '
        Me.任務情報アクセス.AutoSize = True
        Me.任務情報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.任務ウインドウ表示
        Me.任務情報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "任務ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.任務情報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.任務情報アクセス.Location = New System.Drawing.Point(228, 12)
        Me.任務情報アクセス.Name = "任務情報アクセス"
        Me.任務情報アクセス.Size = New System.Drawing.Size(48, 29)
        Me.任務情報アクセス.TabIndex = 5
        Me.任務情報アクセス.Text = "任務"
        Me.任務情報アクセス.UseVisualStyleBackColor = True
        '
        '工廠情報アクセス
        '
        Me.工廠情報アクセス.AutoSize = True
        Me.工廠情報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.工廠ウインドウ表示
        Me.工廠情報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "工廠ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.工廠情報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.工廠情報アクセス.Location = New System.Drawing.Point(180, 12)
        Me.工廠情報アクセス.Name = "工廠情報アクセス"
        Me.工廠情報アクセス.Size = New System.Drawing.Size(48, 29)
        Me.工廠情報アクセス.TabIndex = 4
        Me.工廠情報アクセス.Text = "工廠"
        Me.工廠情報アクセス.UseVisualStyleBackColor = True
        '
        '基地航空隊情報アクセス
        '
        Me.基地航空隊情報アクセス.AutoSize = True
        Me.基地航空隊情報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.基地航空隊ウインドウ表示
        Me.基地航空隊情報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "基地航空隊ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.基地航空隊情報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.基地航空隊情報アクセス.Enabled = False
        Me.基地航空隊情報アクセス.Location = New System.Drawing.Point(96, 12)
        Me.基地航空隊情報アクセス.Name = "基地航空隊情報アクセス"
        Me.基地航空隊情報アクセス.Size = New System.Drawing.Size(84, 29)
        Me.基地航空隊情報アクセス.TabIndex = 3
        Me.基地航空隊情報アクセス.Text = "基地航空隊"
        Me.基地航空隊情報アクセス.UseVisualStyleBackColor = True
        '
        '艦隊情報アクセス
        '
        Me.艦隊情報アクセス.AutoSize = True
        Me.艦隊情報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.艦隊ウインドウ表示
        Me.艦隊情報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "艦隊ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.艦隊情報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.艦隊情報アクセス.Location = New System.Drawing.Point(48, 12)
        Me.艦隊情報アクセス.Name = "艦隊情報アクセス"
        Me.艦隊情報アクセス.Size = New System.Drawing.Size(48, 29)
        Me.艦隊情報アクセス.TabIndex = 2
        Me.艦隊情報アクセス.Text = "艦隊"
        Me.艦隊情報アクセス.UseVisualStyleBackColor = True
        '
        '提督情報アクセス
        '
        Me.提督情報アクセス.AutoSize = True
        Me.提督情報アクセス.Checked = Global.Admiral_s_Desk.My.MySettings.Default.提督ウインドウ表示
        Me.提督情報アクセス.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "提督ウインドウ表示", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.提督情報アクセス.Dock = System.Windows.Forms.DockStyle.Left
        Me.提督情報アクセス.Location = New System.Drawing.Point(0, 12)
        Me.提督情報アクセス.Name = "提督情報アクセス"
        Me.提督情報アクセス.Size = New System.Drawing.Size(48, 29)
        Me.提督情報アクセス.TabIndex = 1
        Me.提督情報アクセス.Text = "提督"
        Me.提督情報アクセス.UseVisualStyleBackColor = True
        '
        '情報アクセスラベル
        '
        Me.情報アクセスラベル.AutoSize = True
        Me.情報アクセスラベル.Dock = System.Windows.Forms.DockStyle.Top
        Me.情報アクセスラベル.Location = New System.Drawing.Point(0, 0)
        Me.情報アクセスラベル.Name = "情報アクセスラベル"
        Me.情報アクセスラベル.Size = New System.Drawing.Size(29, 12)
        Me.情報アクセスラベル.TabIndex = 0
        Me.情報アクセスラベル.Text = "詳細"
        '
        '更新確認ブラウザ
        '
        Me.更新確認ブラウザ.Location = New System.Drawing.Point(12, 38)
        Me.更新確認ブラウザ.MinimumSize = New System.Drawing.Size(20, 20)
        Me.更新確認ブラウザ.Name = "更新確認ブラウザ"
        Me.更新確認ブラウザ.Size = New System.Drawing.Size(250, 250)
        Me.更新確認ブラウザ.TabIndex = 3
        Me.更新確認ブラウザ.Url = New System.Uri("https://raw.githubusercontent.com/masteralice3104/Admiral-s-desk/master/Refresh", System.UriKind.Absolute)
        Me.更新確認ブラウザ.Visible = False
        '
        '更新URL確認用ブラウザ
        '
        Me.更新URL確認用ブラウザ.Location = New System.Drawing.Point(470, 184)
        Me.更新URL確認用ブラウザ.MinimumSize = New System.Drawing.Size(20, 20)
        Me.更新URL確認用ブラウザ.Name = "更新URL確認用ブラウザ"
        Me.更新URL確認用ブラウザ.Size = New System.Drawing.Size(250, 250)
        Me.更新URL確認用ブラウザ.TabIndex = 4
        Me.更新URL確認用ブラウザ.Url = New System.Uri("https://raw.githubusercontent.com/masteralice3104/Admiral-s-desk/master/RefreshUR" &
        "L", System.UriKind.Absolute)
        Me.更新URL確認用ブラウザ.Visible = False
        '
        '汎用タイマ
        '
        Me.汎用タイマ.Interval = 1000
        '
        '通知領域
        '
        Me.通知領域.Text = "Admiral's Desk"
        '
        'bp
        '
        Me.bp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bp.Location = New System.Drawing.Point(0, 24)
        Me.bp.MaximumSize = New System.Drawing.Size(1204, 725)
        Me.bp.MinimumSize = New System.Drawing.Size(1204, 725)
        Me.bp.Name = "bp"
        Me.bp.Size = New System.Drawing.Size(1204, 725)
        Me.bp.TabIndex = 5
        '
        'メインフォーム
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1204, 790)
        Me.Controls.Add(Me.bp)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.更新URL確認用ブラウザ)
        Me.Controls.Add(Me.更新確認ブラウザ)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "KancolleFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.KancolleFormLocation
        Me.Name = "メインフォーム"
        Me.Text = "Admiral's desk"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ツールTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents 情報アクセスラベル As Label
    Friend WithEvents 遠征情報アクセス As CheckBox
    Friend WithEvents 任務情報アクセス As CheckBox
    Friend WithEvents 工廠情報アクセス As CheckBox
    Friend WithEvents 基地航空隊情報アクセス As CheckBox
    Friend WithEvents 艦隊情報アクセス As CheckBox
    Friend WithEvents 提督情報アクセス As CheckBox
    Friend WithEvents 更新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 中止ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents エクスポートEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents オプションoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 更新確認ブラウザ As WebBrowser
    Friend WithEvents 更新URL確認用ブラウザ As WebBrowser
    Friend WithEvents 汎用タイマ As Timer
    Friend WithEvents 全艦娘一覧ウインドウ表示 As Button
    Friend WithEvents 戦闘予報アクセス As CheckBox
    Friend WithEvents スクリーンショット撮影 As Button
    Friend WithEvents 遠征支援SToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 通知領域 As NotifyIcon
    Friend WithEvents ミュート切り替え As Button
    Friend WithEvents bp As Panel
End Class
