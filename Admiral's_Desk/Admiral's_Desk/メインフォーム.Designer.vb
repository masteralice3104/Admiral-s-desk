﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ブラウザ = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.遠征情報アクセス = New System.Windows.Forms.CheckBox()
        Me.任務情報アクセス = New System.Windows.Forms.CheckBox()
        Me.工廠情報アクセス = New System.Windows.Forms.CheckBox()
        Me.基地航空隊情報アクセス = New System.Windows.Forms.CheckBox()
        Me.艦隊情報アクセス = New System.Windows.Forms.CheckBox()
        Me.提督情報アクセス = New System.Windows.Forms.CheckBox()
        Me.情報アクセスラベル = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ツールTToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        'ツールTToolStripMenuItem
        '
        Me.ツールTToolStripMenuItem.Name = "ツールTToolStripMenuItem"
        Me.ツールTToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ツールTToolStripMenuItem.Text = "ツール(&T)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'ブラウザ
        '
        Me.ブラウザ.Dock = System.Windows.Forms.DockStyle.Top
        Me.ブラウザ.Location = New System.Drawing.Point(0, 24)
        Me.ブラウザ.MaximumSize = New System.Drawing.Size(802, 482)
        Me.ブラウザ.MinimumSize = New System.Drawing.Size(800, 482)
        Me.ブラウザ.Name = "ブラウザ"
        Me.ブラウザ.ScriptErrorsSuppressed = True
        Me.ブラウザ.ScrollBarsEnabled = False
        Me.ブラウザ.Size = New System.Drawing.Size(802, 482)
        Me.ブラウザ.TabIndex = 1
        Me.ブラウザ.Url = New System.Uri("http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/", System.UriKind.Absolute)
        Me.ブラウザ.WebBrowserShortcutsEnabled = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.遠征情報アクセス)
        Me.Panel1.Controls.Add(Me.任務情報アクセス)
        Me.Panel1.Controls.Add(Me.工廠情報アクセス)
        Me.Panel1.Controls.Add(Me.基地航空隊情報アクセス)
        Me.Panel1.Controls.Add(Me.艦隊情報アクセス)
        Me.Panel1.Controls.Add(Me.提督情報アクセス)
        Me.Panel1.Controls.Add(Me.情報アクセスラベル)
        Me.Panel1.Location = New System.Drawing.Point(0, 510)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 41)
        Me.Panel1.TabIndex = 2
        '
        '遠征情報アクセス
        '
        Me.遠征情報アクセス.AutoSize = True
        Me.遠征情報アクセス.Location = New System.Drawing.Point(309, 16)
        Me.遠征情報アクセス.Name = "遠征情報アクセス"
        Me.遠征情報アクセス.Size = New System.Drawing.Size(48, 16)
        Me.遠征情報アクセス.TabIndex = 6
        Me.遠征情報アクセス.Text = "遠征"
        Me.遠征情報アクセス.UseVisualStyleBackColor = True
        '
        '任務情報アクセス
        '
        Me.任務情報アクセス.AutoSize = True
        Me.任務情報アクセス.Enabled = False
        Me.任務情報アクセス.Location = New System.Drawing.Point(255, 16)
        Me.任務情報アクセス.Name = "任務情報アクセス"
        Me.任務情報アクセス.Size = New System.Drawing.Size(48, 16)
        Me.任務情報アクセス.TabIndex = 5
        Me.任務情報アクセス.Text = "任務"
        Me.任務情報アクセス.UseVisualStyleBackColor = True
        '
        '工廠情報アクセス
        '
        Me.工廠情報アクセス.AutoSize = True
        Me.工廠情報アクセス.Enabled = False
        Me.工廠情報アクセス.Location = New System.Drawing.Point(201, 15)
        Me.工廠情報アクセス.Name = "工廠情報アクセス"
        Me.工廠情報アクセス.Size = New System.Drawing.Size(48, 16)
        Me.工廠情報アクセス.TabIndex = 4
        Me.工廠情報アクセス.Text = "工廠"
        Me.工廠情報アクセス.UseVisualStyleBackColor = True
        '
        '基地航空隊情報アクセス
        '
        Me.基地航空隊情報アクセス.AutoSize = True
        Me.基地航空隊情報アクセス.Enabled = False
        Me.基地航空隊情報アクセス.Location = New System.Drawing.Point(111, 15)
        Me.基地航空隊情報アクセス.Name = "基地航空隊情報アクセス"
        Me.基地航空隊情報アクセス.Size = New System.Drawing.Size(84, 16)
        Me.基地航空隊情報アクセス.TabIndex = 3
        Me.基地航空隊情報アクセス.Text = "基地航空隊"
        Me.基地航空隊情報アクセス.UseVisualStyleBackColor = True
        '
        '艦隊情報アクセス
        '
        Me.艦隊情報アクセス.AutoSize = True
        Me.艦隊情報アクセス.Location = New System.Drawing.Point(57, 15)
        Me.艦隊情報アクセス.Name = "艦隊情報アクセス"
        Me.艦隊情報アクセス.Size = New System.Drawing.Size(48, 16)
        Me.艦隊情報アクセス.TabIndex = 2
        Me.艦隊情報アクセス.Text = "艦隊"
        Me.艦隊情報アクセス.UseVisualStyleBackColor = True
        '
        '提督情報アクセス
        '
        Me.提督情報アクセス.AutoSize = True
        Me.提督情報アクセス.Location = New System.Drawing.Point(3, 16)
        Me.提督情報アクセス.Name = "提督情報アクセス"
        Me.提督情報アクセス.Size = New System.Drawing.Size(48, 16)
        Me.提督情報アクセス.TabIndex = 1
        Me.提督情報アクセス.Text = "提督"
        Me.提督情報アクセス.UseVisualStyleBackColor = True
        '
        '情報アクセスラベル
        '
        Me.情報アクセスラベル.AutoSize = True
        Me.情報アクセスラベル.Location = New System.Drawing.Point(3, 0)
        Me.情報アクセスラベル.Name = "情報アクセスラベル"
        Me.情報アクセスラベル.Size = New System.Drawing.Size(29, 12)
        Me.情報アクセスラベル.TabIndex = 0
        Me.情報アクセスラベル.Text = "詳細"
        '
        'メインフォーム
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 550)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ブラウザ)
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
    Friend WithEvents ブラウザ As WebBrowser
    Friend WithEvents Panel1 As Panel
    Friend WithEvents 情報アクセスラベル As Label
    Friend WithEvents 遠征情報アクセス As CheckBox
    Friend WithEvents 任務情報アクセス As CheckBox
    Friend WithEvents 工廠情報アクセス As CheckBox
    Friend WithEvents 基地航空隊情報アクセス As CheckBox
    Friend WithEvents 艦隊情報アクセス As CheckBox
    Friend WithEvents 提督情報アクセス As CheckBox
End Class
