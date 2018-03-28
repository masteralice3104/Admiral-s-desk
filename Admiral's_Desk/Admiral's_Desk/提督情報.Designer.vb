<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 提督情報
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
        Me.components = New System.ComponentModel.Container()
        Me.提督名 = New System.Windows.Forms.Label()
        Me.表示ラベル01 = New System.Windows.Forms.Label()
        Me.母港収容状況 = New System.Windows.Forms.Label()
        Me.提督階級 = New System.Windows.Forms.Label()
        Me.提督Lv = New System.Windows.Forms.Label()
        Me.提督Lvアップ残経験値 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.装備数 = New System.Windows.Forms.Label()
        Me.表示ラベル02 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.現在資材状況 = New System.Windows.Forms.GroupBox()
        Me.資材資源量DataGridView = New System.Windows.Forms.DataGridView()
        Me.資源資材量 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.総数 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.攻略中マップ一覧 = New System.Windows.Forms.GroupBox()
        Me.マップ状態 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.更新タイマ = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.現在資材状況.SuspendLayout()
        CType(Me.資材資源量DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.攻略中マップ一覧.SuspendLayout()
        CType(Me.マップ状態, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '提督名
        '
        Me.提督名.AutoSize = True
        Me.提督名.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.提督名.Location = New System.Drawing.Point(3, 0)
        Me.提督名.Name = "提督名"
        Me.提督名.Size = New System.Drawing.Size(187, 29)
        Me.提督名.TabIndex = 0
        Me.提督名.Text = "提督名未設定"
        '
        '表示ラベル01
        '
        Me.表示ラベル01.AutoSize = True
        Me.表示ラベル01.Location = New System.Drawing.Point(3, 0)
        Me.表示ラベル01.Name = "表示ラベル01"
        Me.表示ラベル01.Size = New System.Drawing.Size(29, 12)
        Me.表示ラベル01.TabIndex = 1
        Me.表示ラベル01.Text = "母港"
        '
        '母港収容状況
        '
        Me.母港収容状況.AutoSize = True
        Me.母港収容状況.Location = New System.Drawing.Point(38, 0)
        Me.母港収容状況.Name = "母港収容状況"
        Me.母港収容状況.Size = New System.Drawing.Size(23, 12)
        Me.母港収容状況.TabIndex = 2
        Me.母港収容状況.Text = "0/0"
        '
        '提督階級
        '
        Me.提督階級.AutoSize = True
        Me.提督階級.Location = New System.Drawing.Point(196, 17)
        Me.提督階級.Name = "提督階級"
        Me.提督階級.Size = New System.Drawing.Size(65, 12)
        Me.提督階級.TabIndex = 3
        Me.提督階級.Text = "階級未設定"
        '
        '提督Lv
        '
        Me.提督Lv.AutoSize = True
        Me.提督Lv.Location = New System.Drawing.Point(196, 0)
        Me.提督Lv.Name = "提督Lv"
        Me.提督Lv.Size = New System.Drawing.Size(17, 12)
        Me.提督Lv.TabIndex = 4
        Me.提督Lv.Text = "Lv"
        '
        '提督Lvアップ残経験値
        '
        Me.提督Lvアップ残経験値.AutoSize = True
        Me.提督Lvアップ残経験値.Font = New System.Drawing.Font("MS UI Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.提督Lvアップ残経験値.Location = New System.Drawing.Point(246, 0)
        Me.提督Lvアップ残経験値.Name = "提督Lvアップ残経験値"
        Me.提督Lvアップ残経験値.Size = New System.Drawing.Size(26, 11)
        Me.提督Lvアップ残経験値.TabIndex = 5
        Me.提督Lvアップ残経験値.Text = "next"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.装備数)
        Me.Panel1.Controls.Add(Me.表示ラベル02)
        Me.Panel1.Controls.Add(Me.表示ラベル01)
        Me.Panel1.Controls.Add(Me.母港収容状況)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 15)
        Me.Panel1.TabIndex = 6
        '
        '装備数
        '
        Me.装備数.AutoSize = True
        Me.装備数.Location = New System.Drawing.Point(219, 0)
        Me.装備数.Name = "装備数"
        Me.装備数.Size = New System.Drawing.Size(23, 12)
        Me.装備数.TabIndex = 4
        Me.装備数.Text = "0/0"
        '
        '表示ラベル02
        '
        Me.表示ラベル02.AutoSize = True
        Me.表示ラベル02.Location = New System.Drawing.Point(184, 0)
        Me.表示ラベル02.Name = "表示ラベル02"
        Me.表示ラベル02.Size = New System.Drawing.Size(29, 12)
        Me.表示ラベル02.TabIndex = 3
        Me.表示ラベル02.Text = "装備"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.提督名)
        Me.Panel2.Controls.Add(Me.提督Lv)
        Me.Panel2.Controls.Add(Me.提督Lvアップ残経験値)
        Me.Panel2.Controls.Add(Me.提督階級)
        Me.Panel2.Location = New System.Drawing.Point(12, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 32)
        Me.Panel2.TabIndex = 7
        '
        '現在資材状況
        '
        Me.現在資材状況.Controls.Add(Me.資材資源量DataGridView)
        Me.現在資材状況.Location = New System.Drawing.Point(12, 64)
        Me.現在資材状況.Name = "現在資材状況"
        Me.現在資材状況.Size = New System.Drawing.Size(168, 233)
        Me.現在資材状況.TabIndex = 8
        Me.現在資材状況.TabStop = False
        Me.現在資材状況.Text = "各種資材・資源量"
        '
        '資材資源量DataGridView
        '
        Me.資材資源量DataGridView.AllowUserToAddRows = False
        Me.資材資源量DataGridView.AllowUserToDeleteRows = False
        Me.資材資源量DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.資材資源量DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.資源資材量, Me.総数})
        Me.資材資源量DataGridView.Location = New System.Drawing.Point(7, 19)
        Me.資材資源量DataGridView.Name = "資材資源量DataGridView"
        Me.資材資源量DataGridView.ReadOnly = True
        Me.資材資源量DataGridView.RowHeadersVisible = False
        Me.資材資源量DataGridView.RowTemplate.Height = 21
        Me.資材資源量DataGridView.Size = New System.Drawing.Size(155, 205)
        Me.資材資源量DataGridView.TabIndex = 0
        '
        '資源資材量
        '
        Me.資源資材量.HeaderText = "資源・資材"
        Me.資源資材量.Name = "資源資材量"
        Me.資源資材量.ReadOnly = True
        Me.資源資材量.Width = 90
        '
        '総数
        '
        Me.総数.HeaderText = "総数"
        Me.総数.Name = "総数"
        Me.総数.ReadOnly = True
        Me.総数.Width = 60
        '
        '攻略中マップ一覧
        '
        Me.攻略中マップ一覧.Controls.Add(Me.マップ状態)
        Me.攻略中マップ一覧.Location = New System.Drawing.Point(186, 64)
        Me.攻略中マップ一覧.Name = "攻略中マップ一覧"
        Me.攻略中マップ一覧.Size = New System.Drawing.Size(168, 233)
        Me.攻略中マップ一覧.TabIndex = 9
        Me.攻略中マップ一覧.TabStop = False
        Me.攻略中マップ一覧.Text = "攻略中マップ"
        '
        'マップ状態
        '
        Me.マップ状態.AllowUserToAddRows = False
        Me.マップ状態.AllowUserToDeleteRows = False
        Me.マップ状態.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.マップ状態.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.マップ状態.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.マップ状態.Location = New System.Drawing.Point(7, 19)
        Me.マップ状態.Name = "マップ状態"
        Me.マップ状態.ReadOnly = True
        Me.マップ状態.RowHeadersVisible = False
        Me.マップ状態.RowTemplate.Height = 21
        Me.マップ状態.Size = New System.Drawing.Size(155, 205)
        Me.マップ状態.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "マップ"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 90
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "残り"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 60
        '
        '更新タイマ
        '
        Me.更新タイマ.Enabled = True
        '
        '提督情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(354, 301)
        Me.Controls.Add(Me.攻略中マップ一覧)
        Me.Controls.Add(Me.現在資材状況)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "提督情報"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "提督情報"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.現在資材状況.ResumeLayout(False)
        CType(Me.資材資源量DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.攻略中マップ一覧.ResumeLayout(False)
        CType(Me.マップ状態, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 提督名 As Label
    Friend WithEvents 表示ラベル01 As Label
    Friend WithEvents 母港収容状況 As Label
    Friend WithEvents 提督階級 As Label
    Friend WithEvents 提督Lv As Label
    Friend WithEvents 提督Lvアップ残経験値 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents 装備数 As Label
    Friend WithEvents 表示ラベル02 As Label
    Friend WithEvents 現在資材状況 As GroupBox
    Friend WithEvents 資材資源量DataGridView As DataGridView
    Friend WithEvents 資源資材量 As DataGridViewTextBoxColumn
    Friend WithEvents 総数 As DataGridViewTextBoxColumn
    Friend WithEvents 攻略中マップ一覧 As GroupBox
    Friend WithEvents マップ状態 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents 更新タイマ As Timer
End Class
