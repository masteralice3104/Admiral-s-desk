<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 任務情報
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
        Me.受注中任務 = New System.Windows.Forms.GroupBox()
        Me.受注中任務表示 = New System.Windows.Forms.DataGridView()
        Me.種類 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.任務名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.状態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.任務更新タイマ = New System.Windows.Forms.Timer(Me.components)
        Me.受注中任務.SuspendLayout()
        CType(Me.受注中任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '受注中任務
        '
        Me.受注中任務.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.受注中任務.AutoSize = True
        Me.受注中任務.Controls.Add(Me.受注中任務表示)
        Me.受注中任務.Location = New System.Drawing.Point(12, 12)
        Me.受注中任務.Name = "受注中任務"
        Me.受注中任務.Size = New System.Drawing.Size(360, 157)
        Me.受注中任務.TabIndex = 1
        Me.受注中任務.TabStop = False
        Me.受注中任務.Text = "受注中"
        '
        '受注中任務表示
        '
        Me.受注中任務表示.AllowUserToAddRows = False
        Me.受注中任務表示.AllowUserToDeleteRows = False
        Me.受注中任務表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.受注中任務表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.種類, Me.任務名, Me.状態})
        Me.受注中任務表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.受注中任務表示.Location = New System.Drawing.Point(3, 15)
        Me.受注中任務表示.Name = "受注中任務表示"
        Me.受注中任務表示.ReadOnly = True
        Me.受注中任務表示.RowHeadersVisible = False
        Me.受注中任務表示.RowTemplate.Height = 21
        Me.受注中任務表示.Size = New System.Drawing.Size(354, 139)
        Me.受注中任務表示.TabIndex = 0
        '
        '種類
        '
        Me.種類.HeaderText = "種類"
        Me.種類.Name = "種類"
        Me.種類.ReadOnly = True
        Me.種類.Width = 60
        '
        '任務名
        '
        Me.任務名.HeaderText = "任務名"
        Me.任務名.Name = "任務名"
        Me.任務名.ReadOnly = True
        Me.任務名.Width = 150
        '
        '状態
        '
        Me.状態.HeaderText = "状態"
        Me.状態.Name = "状態"
        Me.状態.ReadOnly = True
        Me.状態.Width = 140
        '
        '任務更新タイマ
        '
        Me.任務更新タイマ.Enabled = True
        Me.任務更新タイマ.Interval = 1000
        '
        '任務情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 181)
        Me.ControlBox = False
        Me.Controls.Add(Me.受注中任務)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "任務情報ウインドウ位置", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.任務情報ウインドウ位置
        Me.MaximumSize = New System.Drawing.Size(400, 220)
        Me.MinimumSize = New System.Drawing.Size(400, 220)
        Me.Name = "任務情報"
        Me.Text = "任務情報"
        Me.受注中任務.ResumeLayout(False)
        CType(Me.受注中任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 受注中任務 As GroupBox
    Friend WithEvents 受注中任務表示 As DataGridView
    Friend WithEvents 任務更新タイマ As Timer
    Friend WithEvents 種類 As DataGridViewTextBoxColumn
    Friend WithEvents 任務名 As DataGridViewTextBoxColumn
    Friend WithEvents 状態 As DataGridViewTextBoxColumn
End Class
