<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class メインフォーム
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
        Me.ブラウザ画面 = New System.Windows.Forms.WebBrowser()
        Me.メニューバー = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.エクスポートEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了XToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ウインドウWToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.資源資材一覧ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.艦隊情報ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.遠征情報ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ブラウザBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.読込中止ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.提督情報TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オプションOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.メニューバー.SuspendLayout()
        Me.SuspendLayout()
        '
        'ブラウザ画面
        '
        Me.ブラウザ画面.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ブラウザ画面.Location = New System.Drawing.Point(0, 24)
        Me.ブラウザ画面.MaximumSize = New System.Drawing.Size(801, 481)
        Me.ブラウザ画面.MinimumSize = New System.Drawing.Size(801, 481)
        Me.ブラウザ画面.Name = "ブラウザ画面"
        Me.ブラウザ画面.Size = New System.Drawing.Size(801, 481)
        Me.ブラウザ画面.TabIndex = 0
        Me.ブラウザ画面.Url = New System.Uri("http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/", System.UriKind.Absolute)
        '
        'メニューバー
        '
        Me.メニューバー.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ツールTToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.メニューバー.Location = New System.Drawing.Point(0, 0)
        Me.メニューバー.Name = "メニューバー"
        Me.メニューバー.Size = New System.Drawing.Size(802, 24)
        Me.メニューバー.TabIndex = 1
        Me.メニューバー.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.エクスポートEToolStripMenuItem, Me.終了XToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル（&F)"
        '
        'エクスポートEToolStripMenuItem
        '
        Me.エクスポートEToolStripMenuItem.Name = "エクスポートEToolStripMenuItem"
        Me.エクスポートEToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.エクスポートEToolStripMenuItem.Text = "エクスポート(&E)"
        '
        '終了XToolStripMenuItem
        '
        Me.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem"
        Me.終了XToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.終了XToolStripMenuItem.Text = "終了(&X)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ウインドウWToolStripMenuItem, Me.ブラウザBToolStripMenuItem, Me.提督情報TToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        'ウインドウWToolStripMenuItem
        '
        Me.ウインドウWToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.資源資材一覧ToolStripMenuItem, Me.艦隊情報ToolStripMenuItem, Me.遠征情報ToolStripMenuItem})
        Me.ウインドウWToolStripMenuItem.Name = "ウインドウWToolStripMenuItem"
        Me.ウインドウWToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ウインドウWToolStripMenuItem.Text = "ウインドウ(&W)"
        '
        '資源資材一覧ToolStripMenuItem
        '
        Me.資源資材一覧ToolStripMenuItem.Checked = True
        Me.資源資材一覧ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.資源資材一覧ToolStripMenuItem.Name = "資源資材一覧ToolStripMenuItem"
        Me.資源資材一覧ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.資源資材一覧ToolStripMenuItem.Text = "資源・資材一覧"
        '
        '艦隊情報ToolStripMenuItem
        '
        Me.艦隊情報ToolStripMenuItem.Checked = True
        Me.艦隊情報ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.艦隊情報ToolStripMenuItem.Name = "艦隊情報ToolStripMenuItem"
        Me.艦隊情報ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.艦隊情報ToolStripMenuItem.Text = "艦隊情報"
        '
        '遠征情報ToolStripMenuItem
        '
        Me.遠征情報ToolStripMenuItem.Checked = True
        Me.遠征情報ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.遠征情報ToolStripMenuItem.Name = "遠征情報ToolStripMenuItem"
        Me.遠征情報ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.遠征情報ToolStripMenuItem.Text = "遠征情報"
        '
        'ブラウザBToolStripMenuItem
        '
        Me.ブラウザBToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.更新ToolStripMenuItem, Me.読込中止ToolStripMenuItem})
        Me.ブラウザBToolStripMenuItem.Name = "ブラウザBToolStripMenuItem"
        Me.ブラウザBToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ブラウザBToolStripMenuItem.Text = "ブラウザ(&B)"
        '
        '更新ToolStripMenuItem
        '
        Me.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem"
        Me.更新ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.更新ToolStripMenuItem.Text = "更新"
        '
        '読込中止ToolStripMenuItem
        '
        Me.読込中止ToolStripMenuItem.Name = "読込中止ToolStripMenuItem"
        Me.読込中止ToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.読込中止ToolStripMenuItem.Text = "読込中止"
        '
        '提督情報TToolStripMenuItem
        '
        Me.提督情報TToolStripMenuItem.Name = "提督情報TToolStripMenuItem"
        Me.提督情報TToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.提督情報TToolStripMenuItem.Text = "提督情報(&T)"
        '
        'ツールTToolStripMenuItem
        '
        Me.ツールTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.オプションOToolStripMenuItem})
        Me.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem"
        Me.ツールTToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ツールTToolStripMenuItem.Text = "ツール(&T)"
        '
        'オプションOToolStripMenuItem
        '
        Me.オプションOToolStripMenuItem.Name = "オプションOToolStripMenuItem"
        Me.オプションOToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.オプションOToolStripMenuItem.Text = "オプション(&O)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報AToolStripMenuItem})
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報AToolStripMenuItem
        '
        Me.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem"
        Me.バージョン情報AToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)"
        '
        'メインフォーム
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 507)
        Me.Controls.Add(Me.ブラウザ画面)
        Me.Controls.Add(Me.メニューバー)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "KancolleFormLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.KancolleFormLocation
        Me.MainMenuStrip = Me.メニューバー
        Me.Name = "メインフォーム"
        Me.Text = "Admiral's desk"
        Me.メニューバー.ResumeLayout(False)
        Me.メニューバー.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ブラウザ画面 As WebBrowser
    Friend WithEvents メニューバー As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ウインドウWToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ブラウザBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 更新ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 読込中止ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ツールTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents オプションOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents エクスポートEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了XToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 資源資材一覧ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 艦隊情報ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 提督情報TToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 遠征情報ToolStripMenuItem As ToolStripMenuItem
End Class
