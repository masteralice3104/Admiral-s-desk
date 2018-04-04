<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 全艦娘一覧
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
        Me.艦娘一覧 = New System.Windows.Forms.DataGridView()
        Me.更新タイマ = New System.Windows.Forms.Timer(Me.components)
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.艦種 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.艦娘名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cond = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.耐久 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.対潜 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.運 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.夜戦火力 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.補強増設 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.艦娘一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '艦娘一覧
        '
        Me.艦娘一覧.AllowUserToAddRows = False
        Me.艦娘一覧.AllowUserToDeleteRows = False
        Me.艦娘一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.艦娘一覧.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.艦種, Me.艦娘名, Me.Lv, Me.cond, Me.耐久, Me.対潜, Me.運, Me.夜戦火力, Me.装備1, Me.装備2, Me.装備3, Me.装備4, Me.装備5, Me.補強増設})
        Me.艦娘一覧.Dock = System.Windows.Forms.DockStyle.Fill
        Me.艦娘一覧.Location = New System.Drawing.Point(0, 0)
        Me.艦娘一覧.Name = "艦娘一覧"
        Me.艦娘一覧.ReadOnly = True
        Me.艦娘一覧.RowHeadersVisible = False
        Me.艦娘一覧.RowTemplate.Height = 21
        Me.艦娘一覧.Size = New System.Drawing.Size(800, 450)
        Me.艦娘一覧.TabIndex = 0
        '
        '更新タイマ
        '
        Me.更新タイマ.Enabled = True
        Me.更新タイマ.Interval = 2000
        '
        'ID
        '
        Me.ID.HeaderText = "#"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        '艦種
        '
        Me.艦種.HeaderText = "艦種"
        Me.艦種.Name = "艦種"
        Me.艦種.ReadOnly = True
        '
        '艦娘名
        '
        Me.艦娘名.HeaderText = "艦娘名"
        Me.艦娘名.Name = "艦娘名"
        Me.艦娘名.ReadOnly = True
        '
        'Lv
        '
        Me.Lv.HeaderText = "Lv"
        Me.Lv.Name = "Lv"
        Me.Lv.ReadOnly = True
        Me.Lv.Width = 50
        '
        'cond
        '
        Me.cond.HeaderText = "cond."
        Me.cond.Name = "cond"
        Me.cond.ReadOnly = True
        Me.cond.Width = 50
        '
        '耐久
        '
        Me.耐久.HeaderText = "耐久"
        Me.耐久.Name = "耐久"
        Me.耐久.ReadOnly = True
        Me.耐久.Width = 40
        '
        '対潜
        '
        Me.対潜.HeaderText = "対潜"
        Me.対潜.Name = "対潜"
        Me.対潜.ReadOnly = True
        Me.対潜.Width = 40
        '
        '運
        '
        Me.運.HeaderText = "運"
        Me.運.Name = "運"
        Me.運.ReadOnly = True
        Me.運.Width = 40
        '
        '夜戦火力
        '
        Me.夜戦火力.HeaderText = "夜戦"
        Me.夜戦火力.Name = "夜戦火力"
        Me.夜戦火力.ReadOnly = True
        Me.夜戦火力.Width = 40
        '
        '装備1
        '
        Me.装備1.HeaderText = "1"
        Me.装備1.Name = "装備1"
        Me.装備1.ReadOnly = True
        '
        '装備2
        '
        Me.装備2.HeaderText = "2"
        Me.装備2.Name = "装備2"
        Me.装備2.ReadOnly = True
        '
        '装備3
        '
        Me.装備3.HeaderText = "3"
        Me.装備3.Name = "装備3"
        Me.装備3.ReadOnly = True
        '
        '装備4
        '
        Me.装備4.HeaderText = "4"
        Me.装備4.Name = "装備4"
        Me.装備4.ReadOnly = True
        '
        '装備5
        '
        Me.装備5.HeaderText = "5"
        Me.装備5.Name = "装備5"
        Me.装備5.ReadOnly = True
        '
        '補強増設
        '
        Me.補強増設.HeaderText = "増設"
        Me.補強増設.Name = "補強増設"
        Me.補強増設.ReadOnly = True
        '
        '全艦娘一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.艦娘一覧)
        Me.Name = "全艦娘一覧"
        Me.Text = "全艦娘一覧"
        CType(Me.艦娘一覧, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 艦娘一覧 As DataGridView
    Friend WithEvents 更新タイマ As Timer
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents 艦種 As DataGridViewTextBoxColumn
    Friend WithEvents 艦娘名 As DataGridViewTextBoxColumn
    Friend WithEvents Lv As DataGridViewTextBoxColumn
    Friend WithEvents cond As DataGridViewTextBoxColumn
    Friend WithEvents 耐久 As DataGridViewTextBoxColumn
    Friend WithEvents 対潜 As DataGridViewTextBoxColumn
    Friend WithEvents 運 As DataGridViewTextBoxColumn
    Friend WithEvents 夜戦火力 As DataGridViewTextBoxColumn
    Friend WithEvents 装備1 As DataGridViewTextBoxColumn
    Friend WithEvents 装備2 As DataGridViewTextBoxColumn
    Friend WithEvents 装備3 As DataGridViewTextBoxColumn
    Friend WithEvents 装備4 As DataGridViewTextBoxColumn
    Friend WithEvents 装備5 As DataGridViewTextBoxColumn
    Friend WithEvents 補強増設 As DataGridViewTextBoxColumn
End Class
