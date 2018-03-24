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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.合計TP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.対空カットイン艦数 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.先制対潜艦数 = New System.Windows.Forms.Label()
        CType(Me.一艦隊情報, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 20)
        Me.ComboBox1.TabIndex = 0
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
        Me.一艦隊情報.Size = New System.Drawing.Size(570, 210)
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
        Me.cond.Width = 40
        '
        '燃料
        '
        Me.燃料.HeaderText = "燃料"
        Me.燃料.Name = "燃料"
        Me.燃料.ReadOnly = True
        Me.燃料.Width = 40
        '
        '弾薬
        '
        Me.弾薬.HeaderText = "弾薬"
        Me.弾薬.Name = "弾薬"
        Me.弾薬.ReadOnly = True
        Me.弾薬.Width = 40
        '
        '装備1
        '
        Me.装備1.HeaderText = "1"
        Me.装備1.Name = "装備1"
        Me.装備1.ReadOnly = True
        Me.装備1.Width = 30
        '
        '装備2
        '
        Me.装備2.HeaderText = "2"
        Me.装備2.Name = "装備2"
        Me.装備2.ReadOnly = True
        Me.装備2.Width = 30
        '
        '装備3
        '
        Me.装備3.HeaderText = "3"
        Me.装備3.Name = "装備3"
        Me.装備3.ReadOnly = True
        Me.装備3.Width = 30
        '
        '装備4
        '
        Me.装備4.HeaderText = "4"
        Me.装備4.Name = "装備4"
        Me.装備4.ReadOnly = True
        Me.装備4.Width = 30
        '
        '装備5
        '
        Me.装備5.HeaderText = "5"
        Me.装備5.Name = "装備5"
        Me.装備5.ReadOnly = True
        Me.装備5.Width = 30
        '
        '補強増設
        '
        Me.補強増設.HeaderText = "増"
        Me.補強増設.Name = "補強増設"
        Me.補強増設.ReadOnly = True
        Me.補強増設.Width = 30
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
        Me.ラベル02.Location = New System.Drawing.Point(288, 16)
        Me.ラベル02.Name = "ラベル02"
        Me.ラベル02.Size = New System.Drawing.Size(29, 12)
        Me.ラベル02.TabIndex = 4
        Me.ラベル02.Text = "索敵"
        '
        '合計索敵値
        '
        Me.合計索敵値.AutoSize = True
        Me.合計索敵値.Location = New System.Drawing.Point(323, 16)
        Me.合計索敵値.Name = "合計索敵値"
        Me.合計索敵値.Size = New System.Drawing.Size(29, 12)
        Me.合計索敵値.TabIndex = 5
        Me.合計索敵値.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(358, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TP"
        '
        '合計TP
        '
        Me.合計TP.AutoSize = True
        Me.合計TP.Location = New System.Drawing.Point(383, 16)
        Me.合計TP.Name = "合計TP"
        Me.合計TP.Size = New System.Drawing.Size(29, 12)
        Me.合計TP.TabIndex = 7
        Me.合計TP.Text = "0000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(418, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 12)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "対空CI艦"
        '
        '対空カットイン艦数
        '
        Me.対空カットイン艦数.AutoSize = True
        Me.対空カットイン艦数.Location = New System.Drawing.Point(476, 16)
        Me.対空カットイン艦数.Name = "対空カットイン艦数"
        Me.対空カットイン艦数.Size = New System.Drawing.Size(17, 12)
        Me.対空カットイン艦数.TabIndex = 9
        Me.対空カットイン艦数.Text = "00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(499, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "先制対潜"
        '
        '先制対潜艦数
        '
        Me.先制対潜艦数.AutoSize = True
        Me.先制対潜艦数.Location = New System.Drawing.Point(558, 16)
        Me.先制対潜艦数.Name = "先制対潜艦数"
        Me.先制対潜艦数.Size = New System.Drawing.Size(17, 12)
        Me.先制対潜艦数.TabIndex = 11
        Me.先制対潜艦数.Text = "00"
        '
        '艦隊情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 261)
        Me.Controls.Add(Me.先制対潜艦数)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.対空カットイン艦数)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.合計TP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.合計索敵値)
        Me.Controls.Add(Me.ラベル02)
        Me.Controls.Add(Me.制空値)
        Me.Controls.Add(Me.ラベル01)
        Me.Controls.Add(Me.一艦隊情報)
        Me.Controls.Add(Me.ComboBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(610, 50)
        Me.Name = "艦隊情報"
        Me.Text = "艦隊情報"
        CType(Me.一艦隊情報, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 一艦隊情報 As DataGridView
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
    Friend WithEvents ラベル01 As Label
    Friend WithEvents 制空値 As Label
    Friend WithEvents ラベル02 As Label
    Friend WithEvents 合計索敵値 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents 合計TP As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents 対空カットイン艦数 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents 先制対潜艦数 As Label
End Class
