<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 艦隊情報一覧
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
        Me.艦隊表示 = New System.Windows.Forms.DataGridView()
        Me.ステータスバー = New System.Windows.Forms.StatusStrip()
        Me.艦隊番号1 = New System.Windows.Forms.Button()
        Me.艦隊番号2 = New System.Windows.Forms.Button()
        Me.艦隊番号3 = New System.Windows.Forms.Button()
        Me.艦隊番号4 = New System.Windows.Forms.Button()
        Me.艦隊情報更新タイマー = New System.Windows.Forms.Timer(Me.components)
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.艦娘名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.レベル = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.コンディション = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.燃料 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.弾薬 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.装備5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.艦隊表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '艦隊表示
        '
        Me.艦隊表示.AllowUserToAddRows = False
        Me.艦隊表示.AllowUserToDeleteRows = False
        Me.艦隊表示.AllowUserToResizeColumns = False
        Me.艦隊表示.AllowUserToResizeRows = False
        Me.艦隊表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.艦隊表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.艦娘名, Me.レベル, Me.HP, Me.コンディション, Me.燃料, Me.弾薬, Me.装備1, Me.装備2, Me.装備3, Me.装備4, Me.装備5})
        Me.艦隊表示.Location = New System.Drawing.Point(1, 0)
        Me.艦隊表示.Name = "艦隊表示"
        Me.艦隊表示.ReadOnly = True
        Me.艦隊表示.RowHeadersVisible = False
        Me.艦隊表示.RowTemplate.Height = 21
        Me.艦隊表示.Size = New System.Drawing.Size(889, 148)
        Me.艦隊表示.TabIndex = 1
        '
        'ステータスバー
        '
        Me.ステータスバー.Location = New System.Drawing.Point(0, 149)
        Me.ステータスバー.Name = "ステータスバー"
        Me.ステータスバー.Size = New System.Drawing.Size(890, 22)
        Me.ステータスバー.TabIndex = 2
        Me.ステータスバー.Text = "StatusStrip1"
        '
        '艦隊番号1
        '
        Me.艦隊番号1.AutoSize = True
        Me.艦隊番号1.Location = New System.Drawing.Point(1, 148)
        Me.艦隊番号1.Name = "艦隊番号1"
        Me.艦隊番号1.Size = New System.Drawing.Size(75, 23)
        Me.艦隊番号1.TabIndex = 3
        Me.艦隊番号1.UseMnemonic = False
        Me.艦隊番号1.UseVisualStyleBackColor = True
        '
        '艦隊番号2
        '
        Me.艦隊番号2.Location = New System.Drawing.Point(82, 148)
        Me.艦隊番号2.Name = "艦隊番号2"
        Me.艦隊番号2.Size = New System.Drawing.Size(75, 23)
        Me.艦隊番号2.TabIndex = 4
        Me.艦隊番号2.UseVisualStyleBackColor = True
        '
        '艦隊番号3
        '
        Me.艦隊番号3.Location = New System.Drawing.Point(163, 148)
        Me.艦隊番号3.Name = "艦隊番号3"
        Me.艦隊番号3.Size = New System.Drawing.Size(75, 23)
        Me.艦隊番号3.TabIndex = 5
        Me.艦隊番号3.UseVisualStyleBackColor = True
        '
        '艦隊番号4
        '
        Me.艦隊番号4.Location = New System.Drawing.Point(244, 148)
        Me.艦隊番号4.Name = "艦隊番号4"
        Me.艦隊番号4.Size = New System.Drawing.Size(75, 23)
        Me.艦隊番号4.TabIndex = 6
        Me.艦隊番号4.UseVisualStyleBackColor = True
        '
        '艦隊情報更新タイマー
        '
        Me.艦隊情報更新タイマー.Enabled = True
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        '艦娘名
        '
        Me.艦娘名.HeaderText = "艦娘名"
        Me.艦娘名.MaxInputLength = 25
        Me.艦娘名.Name = "艦娘名"
        Me.艦娘名.ReadOnly = True
        Me.艦娘名.Width = 125
        '
        'レベル
        '
        Me.レベル.HeaderText = "Lv."
        Me.レベル.MaxInputLength = 3
        Me.レベル.Name = "レベル"
        Me.レベル.ReadOnly = True
        Me.レベル.Width = 50
        '
        'HP
        '
        Me.HP.HeaderText = "HP"
        Me.HP.MaxInputLength = 7
        Me.HP.Name = "HP"
        Me.HP.ReadOnly = True
        Me.HP.Width = 50
        '
        'コンディション
        '
        Me.コンディション.HeaderText = "cond."
        Me.コンディション.MaxInputLength = 3
        Me.コンディション.Name = "コンディション"
        Me.コンディション.ReadOnly = True
        Me.コンディション.Width = 40
        '
        '燃料
        '
        Me.燃料.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.燃料.HeaderText = "燃料"
        Me.燃料.MaxInputLength = 3
        Me.燃料.Name = "燃料"
        Me.燃料.ReadOnly = True
        Me.燃料.Width = 52
        '
        '弾薬
        '
        Me.弾薬.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.弾薬.HeaderText = "弾薬"
        Me.弾薬.MaxInputLength = 3
        Me.弾薬.Name = "弾薬"
        Me.弾薬.ReadOnly = True
        Me.弾薬.Width = 52
        '
        '装備1
        '
        Me.装備1.HeaderText = "装備1"
        Me.装備1.Name = "装備1"
        Me.装備1.ReadOnly = True
        '
        '装備2
        '
        Me.装備2.HeaderText = "装備2"
        Me.装備2.Name = "装備2"
        Me.装備2.ReadOnly = True
        '
        '装備3
        '
        Me.装備3.HeaderText = "装備3"
        Me.装備3.Name = "装備3"
        Me.装備3.ReadOnly = True
        '
        '装備4
        '
        Me.装備4.HeaderText = "装備4"
        Me.装備4.Name = "装備4"
        Me.装備4.ReadOnly = True
        '
        '装備5
        '
        Me.装備5.HeaderText = "装備5"
        Me.装備5.Name = "装備5"
        Me.装備5.ReadOnly = True
        '
        '艦隊情報一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(890, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.艦隊番号4)
        Me.Controls.Add(Me.艦隊番号3)
        Me.Controls.Add(Me.艦隊番号2)
        Me.Controls.Add(Me.艦隊番号1)
        Me.Controls.Add(Me.ステータスバー)
        Me.Controls.Add(Me.艦隊表示)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "艦隊情報一覧位置", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.艦隊情報一覧位置
        Me.Name = "艦隊情報一覧"
        Me.ShowInTaskbar = False
        Me.Text = "艦隊情報一覧"
        CType(Me.艦隊表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 艦隊表示 As DataGridView
    Friend WithEvents ステータスバー As StatusStrip
    Friend WithEvents 艦隊番号1 As Button
    Friend WithEvents 艦隊番号2 As Button
    Friend WithEvents 艦隊番号3 As Button
    Friend WithEvents 艦隊番号4 As Button
    Friend WithEvents 艦隊情報更新タイマー As Timer
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents 艦娘名 As DataGridViewTextBoxColumn
    Friend WithEvents レベル As DataGridViewTextBoxColumn
    Friend WithEvents HP As DataGridViewTextBoxColumn
    Friend WithEvents コンディション As DataGridViewTextBoxColumn
    Friend WithEvents 燃料 As DataGridViewTextBoxColumn
    Friend WithEvents 弾薬 As DataGridViewTextBoxColumn
    Friend WithEvents 装備1 As DataGridViewTextBoxColumn
    Friend WithEvents 装備2 As DataGridViewTextBoxColumn
    Friend WithEvents 装備3 As DataGridViewTextBoxColumn
    Friend WithEvents 装備4 As DataGridViewTextBoxColumn
    Friend WithEvents 装備5 As DataGridViewTextBoxColumn
End Class
