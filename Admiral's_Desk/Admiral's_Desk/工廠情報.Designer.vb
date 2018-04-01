<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 工廠情報
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.入渠情報表示 = New System.Windows.Forms.DataGridView()
        Me.艦娘名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.残り時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.完了時刻 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.建造情報表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.開発情報表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ネタバレ防止 = New System.Windows.Forms.CheckBox()
        Me.情報更新タイマ = New System.Windows.Forms.Timer(Me.components)
        CType(Me.入渠情報表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.建造情報表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.開発情報表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "入渠"
        '
        '入渠情報表示
        '
        Me.入渠情報表示.AllowUserToAddRows = False
        Me.入渠情報表示.AllowUserToDeleteRows = False
        Me.入渠情報表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.入渠情報表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.艦娘名, Me.残り時間, Me.完了時刻})
        Me.入渠情報表示.Location = New System.Drawing.Point(57, 13)
        Me.入渠情報表示.Name = "入渠情報表示"
        Me.入渠情報表示.ReadOnly = True
        Me.入渠情報表示.RowHeadersVisible = False
        Me.入渠情報表示.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.入渠情報表示.RowTemplate.Height = 21
        Me.入渠情報表示.Size = New System.Drawing.Size(265, 108)
        Me.入渠情報表示.TabIndex = 1
        '
        '艦娘名
        '
        Me.艦娘名.HeaderText = "艦娘名"
        Me.艦娘名.Name = "艦娘名"
        Me.艦娘名.ReadOnly = True
        '
        '残り時間
        '
        Me.残り時間.HeaderText = "残り時間"
        Me.残り時間.Name = "残り時間"
        Me.残り時間.ReadOnly = True
        Me.残り時間.Width = 80
        '
        '完了時刻
        '
        Me.完了時刻.HeaderText = "完了時刻"
        Me.完了時刻.Name = "完了時刻"
        Me.完了時刻.ReadOnly = True
        Me.完了時刻.Width = 80
        '
        '建造情報表示
        '
        Me.建造情報表示.AllowUserToAddRows = False
        Me.建造情報表示.AllowUserToDeleteRows = False
        Me.建造情報表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.建造情報表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.建造情報表示.Location = New System.Drawing.Point(57, 127)
        Me.建造情報表示.Name = "建造情報表示"
        Me.建造情報表示.ReadOnly = True
        Me.建造情報表示.RowHeadersVisible = False
        Me.建造情報表示.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.建造情報表示.RowTemplate.Height = 21
        Me.建造情報表示.Size = New System.Drawing.Size(265, 108)
        Me.建造情報表示.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "艦娘名"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "残り時間"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "完了時刻"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "建造"
        '
        '開発情報表示
        '
        Me.開発情報表示.AllowUserToAddRows = False
        Me.開発情報表示.AllowUserToDeleteRows = False
        Me.開発情報表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.開発情報表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        Me.開発情報表示.Location = New System.Drawing.Point(57, 241)
        Me.開発情報表示.Name = "開発情報表示"
        Me.開発情報表示.ReadOnly = True
        Me.開発情報表示.RowHeadersVisible = False
        Me.開発情報表示.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.開発情報表示.RowTemplate.Height = 21
        Me.開発情報表示.Size = New System.Drawing.Size(265, 45)
        Me.開発情報表示.TabIndex = 5
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "装備名"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 260
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "開発"
        '
        'ネタバレ防止
        '
        Me.ネタバレ防止.AutoSize = True
        Me.ネタバレ防止.Checked = Global.Admiral_s_Desk.My.MySettings.Default.建造開発ネタバレチェック
        Me.ネタバレ防止.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ネタバレ防止.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Admiral_s_Desk.My.MySettings.Default, "建造開発ネタバレチェック", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ネタバレ防止.Location = New System.Drawing.Point(16, 292)
        Me.ネタバレ防止.Name = "ネタバレ防止"
        Me.ネタバレ防止.Size = New System.Drawing.Size(177, 16)
        Me.ネタバレ防止.TabIndex = 6
        Me.ネタバレ防止.Text = "建造・開発のネタバレを防止する"
        Me.ネタバレ防止.UseVisualStyleBackColor = True
        '
        '情報更新タイマ
        '
        Me.情報更新タイマ.Enabled = True
        Me.情報更新タイマ.Interval = 1000
        '
        '工廠情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.ネタバレ防止)
        Me.Controls.Add(Me.開発情報表示)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.建造情報表示)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.入渠情報表示)
        Me.Controls.Add(Me.Label1)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "工廠情報ウインドウ位置", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.工廠情報ウインドウ位置
        Me.MaximumSize = New System.Drawing.Size(350, 350)
        Me.MinimumSize = New System.Drawing.Size(350, 350)
        Me.Name = "工廠情報"
        Me.Text = "工廠情報"
        CType(Me.入渠情報表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.建造情報表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.開発情報表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents 入渠情報表示 As DataGridView
    Friend WithEvents 艦娘名 As DataGridViewTextBoxColumn
    Friend WithEvents 残り時間 As DataGridViewTextBoxColumn
    Friend WithEvents 完了時刻 As DataGridViewTextBoxColumn
    Friend WithEvents 建造情報表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents 開発情報表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents ネタバレ防止 As CheckBox
    Friend WithEvents 情報更新タイマ As Timer
End Class
