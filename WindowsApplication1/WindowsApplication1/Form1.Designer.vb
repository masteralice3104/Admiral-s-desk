<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.艦これ画面 = New System.Windows.Forms.WebBrowser()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示VToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.最新の情報に更新F5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.中止EscToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.オプションOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプF1ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.バージョン情報AToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.提督情報 = New System.Windows.Forms.ToolStripMenuItem()
        Me.提督情報TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        '艦これ画面
        '
        Me.艦これ画面.AllowWebBrowserDrop = False
        Me.艦これ画面.Dock = System.Windows.Forms.DockStyle.Fill
        Me.艦これ画面.Location = New System.Drawing.Point(0, 24)
        Me.艦これ画面.MaximumSize = New System.Drawing.Size(801, 481)
        Me.艦これ画面.MinimumSize = New System.Drawing.Size(801, 481)
        Me.艦これ画面.Name = "艦これ画面"
        Me.艦これ画面.Size = New System.Drawing.Size(801, 481)
        Me.艦これ画面.TabIndex = 0
        Me.艦これ画面.Url = New System.Uri("http://www.dmm.com/netgame/social/-/gadgets/=/app_id=854854/", System.UriKind.Absolute)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.表示VToolStripMenuItem, Me.ツールTToolStripMenuItem, Me.提督情報, Me.ヘルプF1ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.終了ToolStripMenuItem})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.終了ToolStripMenuItem.Text = "終了(&X)"
        '
        '表示VToolStripMenuItem
        '
        Me.表示VToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.最新の情報に更新F5ToolStripMenuItem, Me.中止EscToolStripMenuItem})
        Me.表示VToolStripMenuItem.Name = "表示VToolStripMenuItem"
        Me.表示VToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.表示VToolStripMenuItem.Text = "表示(&V)"
        '
        '最新の情報に更新F5ToolStripMenuItem
        '
        Me.最新の情報に更新F5ToolStripMenuItem.Name = "最新の情報に更新F5ToolStripMenuItem"
        Me.最新の情報に更新F5ToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.最新の情報に更新F5ToolStripMenuItem.Text = "最新の情報に更新(&F5)"
        '
        '中止EscToolStripMenuItem
        '
        Me.中止EscToolStripMenuItem.Name = "中止EscToolStripMenuItem"
        Me.中止EscToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.中止EscToolStripMenuItem.Text = "中止(&Esc)"
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
        'ヘルプF1ToolStripMenuItem
        '
        Me.ヘルプF1ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.バージョン情報AToolStripMenuItem})
        Me.ヘルプF1ToolStripMenuItem.Name = "ヘルプF1ToolStripMenuItem"
        Me.ヘルプF1ToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ヘルプF1ToolStripMenuItem.Text = "ヘルプ(&H)"
        '
        'バージョン情報AToolStripMenuItem
        '
        Me.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem"
        Me.バージョン情報AToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.バージョン情報AToolStripMenuItem.Text = "バージョン情報(&A)"
        '
        '提督情報
        '
        Me.提督情報.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.提督情報TToolStripMenuItem})
        Me.提督情報.Name = "提督情報"
        Me.提督情報.Size = New System.Drawing.Size(54, 20)
        Me.提督情報.Text = "情報(&I)"
        '
        '提督情報TToolStripMenuItem
        '
        Me.提督情報TToolStripMenuItem.Name = "提督情報TToolStripMenuItem"
        Me.提督情報TToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.提督情報TToolStripMenuItem.Text = "提督情報(&T)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.艦これ画面)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MinimumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "名称未確定"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 艦これ画面 As WebBrowser
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 表示VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 最新の情報に更新F5ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 中止EscToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ツールTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents オプションOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ヘルプF1ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents バージョン情報AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 提督情報 As ToolStripMenuItem
    Friend WithEvents 提督情報TToolStripMenuItem As ToolStripMenuItem
End Class
