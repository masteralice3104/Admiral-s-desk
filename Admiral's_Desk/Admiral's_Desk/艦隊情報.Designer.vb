<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 艦隊情報
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
        Me.艦隊選択 = New System.Windows.Forms.ComboBox()
        Me.一艦隊情報 = New System.Windows.Forms.DataGridView()
        Me.艦種 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.艦娘名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cond = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.燃料 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.弾薬 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.補強増設 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ラベル01 = New System.Windows.Forms.Label()
        Me.制空値 = New System.Windows.Forms.Label()
        Me.ラベル02 = New System.Windows.Forms.Label()
        Me.合計索敵値 = New System.Windows.Forms.Label()
        Me.分岐点係数 = New System.Windows.Forms.TextBox()
        Me.ラベル03 = New System.Windows.Forms.Label()
        Me.艦隊情報更新フラグ管理用タイマ = New System.Windows.Forms.Timer(Me.components)
        CType(Me.一艦隊情報, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '艦隊選択
        '
        Me.艦隊選択.FormattingEnabled = True
        Me.艦隊選択.Items.AddRange(New Object() {"艦隊情報なし"})
        Me.艦隊選択.Location = New System.Drawing.Point(13, 13)
        Me.艦隊選択.Name = "艦隊選択"
        Me.艦隊選択.Size = New System.Drawing.Size(187, 20)
        Me.艦隊選択.TabIndex = 0
        '
        '一艦隊情報
        '
        Me.一艦隊情報.AllowUserToAddRows = False
        Me.一艦隊情報.AllowUserToDeleteRows = False
        Me.一艦隊情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.一艦隊情報.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.一艦隊情報.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.艦種, Me.艦娘名, Me.Lv, Me.HP, Me.cond, Me.燃料, Me.弾薬, Me.装備1, Me.装備2, Me.装備3, Me.装備4, Me.装備5, Me.補強増設})
        Me.一艦隊情報.Location = New System.Drawing.Point(12, 39)
        Me.一艦隊情報.Name = "一艦隊情報"
        Me.一艦隊情報.ReadOnly = True
        Me.一艦隊情報.RowHeadersVisible = False
        Me.一艦隊情報.RowTemplate.Height = 21
        Me.一艦隊情報.Size = New System.Drawing.Size(860, 210)
        Me.一艦隊情報.TabIndex = 1
        '
        '艦種
        '
        Me.艦種.HeaderText = "艦種"
        Me.艦種.Name = "艦種"
        Me.艦種.ReadOnly = True
        Me.艦種.Width = 75
        '
        '艦娘名
        '
        Me.艦娘名.HeaderText = "艦娘名"
        Me.艦娘名.Name = "艦娘名"
        Me.艦娘名.ReadOnly = True
        Me.艦娘名.Width = 120
        '
        'Lv
        '
        Me.Lv.HeaderText = "Lv"
        Me.Lv.Name = "Lv"
        Me.Lv.ReadOnly = True
        Me.Lv.Width = 30
        '
        'HP
        '
        Me.HP.HeaderText = "HP"
        Me.HP.Name = "HP"
        Me.HP.ReadOnly = True
        Me.HP.Width = 40
        '
        'cond
        '
        Me.cond.HeaderText = "cond."
        Me.cond.Name = "cond"
        Me.cond.ReadOnly = True
        Me.cond.Width = 35
        '
        '燃料
        '
        Me.燃料.HeaderText = "燃料"
        Me.燃料.Name = "燃料"
        Me.燃料.ReadOnly = True
        Me.燃料.Width = 55
        '
        '弾薬
        '
        Me.弾薬.HeaderText = "弾薬"
        Me.弾薬.Name = "弾薬"
        Me.弾薬.ReadOnly = True
        Me.弾薬.Width = 55
        '
        '装備1
        '
        Me.装備1.HeaderText = "1"
        Me.装備1.Name = "装備1"
        Me.装備1.ReadOnly = True
        Me.装備1.Width = 74
        '
        '装備2
        '
        Me.装備2.HeaderText = "2"
        Me.装備2.Name = "装備2"
        Me.装備2.ReadOnly = True
        Me.装備2.Width = 74
        '
        '装備3
        '
        Me.装備3.HeaderText = "3"
        Me.装備3.Name = "装備3"
        Me.装備3.ReadOnly = True
        Me.装備3.Width = 74
        '
        '装備4
        '
        Me.装備4.HeaderText = "4"
        Me.装備4.Name = "装備4"
        Me.装備4.ReadOnly = True
        Me.装備4.Width = 74
        '
        '装備5
        '
        Me.装備5.HeaderText = "5"
        Me.装備5.Name = "装備5"
        Me.装備5.ReadOnly = True
        Me.装備5.Width = 74
        '
        '補強増設
        '
        Me.補強増設.HeaderText = "増設"
        Me.補強増設.Name = "補強増設"
        Me.補強増設.ReadOnly = True
        Me.補強増設.Width = 74
        '
        'ラベル01
        '
        Me.ラベル01.AutoSize = True
        Me.ラベル01.Location = New System.Drawing.Point(206, 16)
        Me.ラベル01.Name = "ラベル01"
        Me.ラベル01.Size = New System.Drawing.Size(41, 12)
        Me.ラベル01.TabIndex = 2
        Me.ラベル01.Text = "制空値"
        '
        '制空値
        '
        Me.制空値.AutoSize = True
        Me.制空値.Location = New System.Drawing.Point(253, 16)
        Me.制空値.Name = "制空値"
        Me.制空値.Size = New System.Drawing.Size(29, 12)
        Me.制空値.TabIndex = 3
        Me.制空値.Text = "0000"
        '
        'ラベル02
        '
        Me.ラベル02.AutoSize = True
        Me.ラベル02.Location = New System.Drawing.Point(385, 16)
        Me.ラベル02.Name = "ラベル02"
        Me.ラベル02.Size = New System.Drawing.Size(29, 12)
        Me.ラベル02.TabIndex = 4
        Me.ラベル02.Text = "33式"
        '
        '合計索敵値
        '
        Me.合計索敵値.AutoSize = True
        Me.合計索敵値.Location = New System.Drawing.Point(420, 15)
        Me.合計索敵値.Name = "合計索敵値"
        Me.合計索敵値.Size = New System.Drawing.Size(25, 12)
        Me.合計索敵値.TabIndex = 5
        Me.合計索敵値.Text = "00.0"
        '
        '分岐点係数
        '
        Me.分岐点係数.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.分岐点係数.Location = New System.Drawing.Point(359, 12)
        Me.分岐点係数.MaxLength = 1
        Me.分岐点係数.Name = "分岐点係数"
        Me.分岐点係数.Size = New System.Drawing.Size(20, 19)
        Me.分岐点係数.TabIndex = 6
        Me.分岐点係数.Text = "1"
        '
        'ラベル03
        '
        Me.ラベル03.AutoSize = True
        Me.ラベル03.Location = New System.Drawing.Point(288, 16)
        Me.ラベル03.Name = "ラベル03"
        Me.ラベル03.Size = New System.Drawing.Size(65, 12)
        Me.ラベル03.TabIndex = 7
        Me.ラベル03.Text = "分岐点係数"
        '
        '艦隊情報更新フラグ管理用タイマ
        '
        Me.艦隊情報更新フラグ管理用タイマ.Enabled = True
        Me.艦隊情報更新フラグ管理用タイマ.Interval = 250
        '
        '艦隊情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.ラベル03)
        Me.Controls.Add(Me.分岐点係数)
        Me.Controls.Add(Me.合計索敵値)
        Me.Controls.Add(Me.ラベル02)
        Me.Controls.Add(Me.制空値)
        Me.Controls.Add(Me.ラベル01)
        Me.Controls.Add(Me.一艦隊情報)
        Me.Controls.Add(Me.艦隊選択)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "艦隊情報ウインドウ位置", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.艦隊情報ウインドウ位置
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 50)
        Me.Name = "艦隊情報"
        Me.Text = "艦隊情報"
        CType(Me.一艦隊情報, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 艦隊選択 As ComboBox
    Friend WithEvents 一艦隊情報 As DataGridView
    Friend WithEvents ラベル01 As Label
    Friend WithEvents 制空値 As Label
    Friend WithEvents ラベル02 As Label
    Friend WithEvents 合計索敵値 As Label
    Friend WithEvents 艦種 As DataGridViewTextBoxColumn
    Friend WithEvents 艦娘名 As DataGridViewTextBoxColumn
    Friend WithEvents Lv As DataGridViewTextBoxColumn
    Friend WithEvents HP As DataGridViewTextBoxColumn
    Friend WithEvents cond As DataGridViewTextBoxColumn
    Friend WithEvents 燃料 As DataGridViewTextBoxColumn
    Friend WithEvents 弾薬 As DataGridViewTextBoxColumn
    Friend WithEvents 装備1 As DataGridViewTextBoxColumn
    Friend WithEvents 装備2 As DataGridViewTextBoxColumn
    Friend WithEvents 装備3 As DataGridViewTextBoxColumn
    Friend WithEvents 装備4 As DataGridViewTextBoxColumn
    Friend WithEvents 装備5 As DataGridViewTextBoxColumn
    Friend WithEvents 補強増設 As DataGridViewTextBoxColumn
    Friend WithEvents 分岐点係数 As TextBox
    Friend WithEvents ラベル03 As Label
    Friend WithEvents 艦隊情報更新フラグ管理用タイマ As Timer
End Class
