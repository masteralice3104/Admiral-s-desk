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
        Me.任務情報表示 = New System.Windows.Forms.TabControl()
        Me.デイリー任務 = New System.Windows.Forms.TabPage()
        Me.ウィークリー = New System.Windows.Forms.TabPage()
        Me.マンスリー = New System.Windows.Forms.TabPage()
        Me.クォータリー = New System.Windows.Forms.TabPage()
        Me.単発 = New System.Windows.Forms.TabPage()
        Me.受注中任務 = New System.Windows.Forms.GroupBox()
        Me.受注中任務表示 = New System.Windows.Forms.DataGridView()
        Me.種類 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.任務名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.状態 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.デイリー任務表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ウィークリー任務表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.マンスリー任務表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.クォータリー任務表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.単発任務表示 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.任務情報表示.SuspendLayout()
        Me.デイリー任務.SuspendLayout()
        Me.ウィークリー.SuspendLayout()
        Me.マンスリー.SuspendLayout()
        Me.クォータリー.SuspendLayout()
        Me.単発.SuspendLayout()
        Me.受注中任務.SuspendLayout()
        CType(Me.受注中任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.デイリー任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ウィークリー任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.マンスリー任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.クォータリー任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.単発任務表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '任務情報表示
        '
        Me.任務情報表示.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.任務情報表示.Controls.Add(Me.デイリー任務)
        Me.任務情報表示.Controls.Add(Me.ウィークリー)
        Me.任務情報表示.Controls.Add(Me.マンスリー)
        Me.任務情報表示.Controls.Add(Me.クォータリー)
        Me.任務情報表示.Controls.Add(Me.単発)
        Me.任務情報表示.Location = New System.Drawing.Point(13, 13)
        Me.任務情報表示.Name = "任務情報表示"
        Me.任務情報表示.SelectedIndex = 0
        Me.任務情報表示.Size = New System.Drawing.Size(359, 153)
        Me.任務情報表示.TabIndex = 0
        '
        'デイリー任務
        '
        Me.デイリー任務.Controls.Add(Me.デイリー任務表示)
        Me.デイリー任務.Location = New System.Drawing.Point(4, 22)
        Me.デイリー任務.Name = "デイリー任務"
        Me.デイリー任務.Padding = New System.Windows.Forms.Padding(3)
        Me.デイリー任務.Size = New System.Drawing.Size(351, 127)
        Me.デイリー任務.TabIndex = 0
        Me.デイリー任務.Text = "デイリー"
        Me.デイリー任務.UseVisualStyleBackColor = True
        '
        'ウィークリー
        '
        Me.ウィークリー.Controls.Add(Me.ウィークリー任務表示)
        Me.ウィークリー.Location = New System.Drawing.Point(4, 22)
        Me.ウィークリー.Name = "ウィークリー"
        Me.ウィークリー.Padding = New System.Windows.Forms.Padding(3)
        Me.ウィークリー.Size = New System.Drawing.Size(351, 127)
        Me.ウィークリー.TabIndex = 1
        Me.ウィークリー.Text = "ウィークリー"
        Me.ウィークリー.UseVisualStyleBackColor = True
        '
        'マンスリー
        '
        Me.マンスリー.Controls.Add(Me.マンスリー任務表示)
        Me.マンスリー.Location = New System.Drawing.Point(4, 22)
        Me.マンスリー.Name = "マンスリー"
        Me.マンスリー.Padding = New System.Windows.Forms.Padding(3)
        Me.マンスリー.Size = New System.Drawing.Size(351, 127)
        Me.マンスリー.TabIndex = 2
        Me.マンスリー.Text = "マンスリー"
        Me.マンスリー.UseVisualStyleBackColor = True
        '
        'クォータリー
        '
        Me.クォータリー.Controls.Add(Me.クォータリー任務表示)
        Me.クォータリー.Location = New System.Drawing.Point(4, 22)
        Me.クォータリー.Name = "クォータリー"
        Me.クォータリー.Padding = New System.Windows.Forms.Padding(3)
        Me.クォータリー.Size = New System.Drawing.Size(351, 127)
        Me.クォータリー.TabIndex = 3
        Me.クォータリー.Text = "クォータリー"
        Me.クォータリー.UseVisualStyleBackColor = True
        '
        '単発
        '
        Me.単発.Controls.Add(Me.単発任務表示)
        Me.単発.Location = New System.Drawing.Point(4, 22)
        Me.単発.Name = "単発"
        Me.単発.Padding = New System.Windows.Forms.Padding(3)
        Me.単発.Size = New System.Drawing.Size(351, 127)
        Me.単発.TabIndex = 4
        Me.単発.Text = "単発"
        Me.単発.UseVisualStyleBackColor = True
        '
        '受注中任務
        '
        Me.受注中任務.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.受注中任務.Controls.Add(Me.受注中任務表示)
        Me.受注中任務.Location = New System.Drawing.Point(17, 173)
        Me.受注中任務.Name = "受注中任務"
        Me.受注中任務.Size = New System.Drawing.Size(351, 126)
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
        Me.受注中任務表示.Size = New System.Drawing.Size(345, 108)
        Me.受注中任務表示.TabIndex = 0
        '
        '種類
        '
        Me.種類.HeaderText = "種類"
        Me.種類.Name = "種類"
        Me.種類.ReadOnly = True
        Me.種類.Width = 55
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
        Me.状態.Width = 135
        '
        'デイリー任務表示
        '
        Me.デイリー任務表示.AllowUserToAddRows = False
        Me.デイリー任務表示.AllowUserToDeleteRows = False
        Me.デイリー任務表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.デイリー任務表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.デイリー任務表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.デイリー任務表示.Location = New System.Drawing.Point(3, 3)
        Me.デイリー任務表示.Name = "デイリー任務表示"
        Me.デイリー任務表示.ReadOnly = True
        Me.デイリー任務表示.RowHeadersVisible = False
        Me.デイリー任務表示.RowTemplate.Height = 21
        Me.デイリー任務表示.Size = New System.Drawing.Size(345, 121)
        Me.デイリー任務表示.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "種類"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "任務名"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "状態"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 135
        '
        'ウィークリー任務表示
        '
        Me.ウィークリー任務表示.AllowUserToAddRows = False
        Me.ウィークリー任務表示.AllowUserToDeleteRows = False
        Me.ウィークリー任務表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ウィークリー任務表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ウィークリー任務表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ウィークリー任務表示.Location = New System.Drawing.Point(3, 3)
        Me.ウィークリー任務表示.Name = "ウィークリー任務表示"
        Me.ウィークリー任務表示.ReadOnly = True
        Me.ウィークリー任務表示.RowHeadersVisible = False
        Me.ウィークリー任務表示.RowTemplate.Height = 21
        Me.ウィークリー任務表示.Size = New System.Drawing.Size(345, 121)
        Me.ウィークリー任務表示.TabIndex = 1
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "種類"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 55
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "任務名"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "状態"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 135
        '
        'マンスリー任務表示
        '
        Me.マンスリー任務表示.AllowUserToAddRows = False
        Me.マンスリー任務表示.AllowUserToDeleteRows = False
        Me.マンスリー任務表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.マンスリー任務表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.マンスリー任務表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.マンスリー任務表示.Location = New System.Drawing.Point(3, 3)
        Me.マンスリー任務表示.Name = "マンスリー任務表示"
        Me.マンスリー任務表示.ReadOnly = True
        Me.マンスリー任務表示.RowHeadersVisible = False
        Me.マンスリー任務表示.RowTemplate.Height = 21
        Me.マンスリー任務表示.Size = New System.Drawing.Size(345, 121)
        Me.マンスリー任務表示.TabIndex = 1
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "種類"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 55
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "任務名"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.HeaderText = "状態"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 135
        '
        'クォータリー任務表示
        '
        Me.クォータリー任務表示.AllowUserToAddRows = False
        Me.クォータリー任務表示.AllowUserToDeleteRows = False
        Me.クォータリー任務表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.クォータリー任務表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.クォータリー任務表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.クォータリー任務表示.Location = New System.Drawing.Point(3, 3)
        Me.クォータリー任務表示.Name = "クォータリー任務表示"
        Me.クォータリー任務表示.ReadOnly = True
        Me.クォータリー任務表示.RowHeadersVisible = False
        Me.クォータリー任務表示.RowTemplate.Height = 21
        Me.クォータリー任務表示.Size = New System.Drawing.Size(345, 121)
        Me.クォータリー任務表示.TabIndex = 1
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.HeaderText = "種類"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 55
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.HeaderText = "任務名"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.HeaderText = "状態"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Width = 135
        '
        '単発任務表示
        '
        Me.単発任務表示.AllowUserToAddRows = False
        Me.単発任務表示.AllowUserToDeleteRows = False
        Me.単発任務表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.単発任務表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.単発任務表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.単発任務表示.Location = New System.Drawing.Point(3, 3)
        Me.単発任務表示.Name = "単発任務表示"
        Me.単発任務表示.ReadOnly = True
        Me.単発任務表示.RowHeadersVisible = False
        Me.単発任務表示.RowTemplate.Height = 21
        Me.単発任務表示.Size = New System.Drawing.Size(345, 121)
        Me.単発任務表示.TabIndex = 1
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "種類"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 55
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.HeaderText = "任務名"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 150
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.HeaderText = "状態"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Width = 135
        '
        '任務情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.受注中任務)
        Me.Controls.Add(Me.任務情報表示)
        Me.MaximumSize = New System.Drawing.Size(400, 350)
        Me.MinimumSize = New System.Drawing.Size(400, 350)
        Me.Name = "任務情報"
        Me.Text = "任務情報"
        Me.任務情報表示.ResumeLayout(False)
        Me.デイリー任務.ResumeLayout(False)
        Me.ウィークリー.ResumeLayout(False)
        Me.マンスリー.ResumeLayout(False)
        Me.クォータリー.ResumeLayout(False)
        Me.単発.ResumeLayout(False)
        Me.受注中任務.ResumeLayout(False)
        CType(Me.受注中任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.デイリー任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ウィークリー任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.マンスリー任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.クォータリー任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.単発任務表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 任務情報表示 As TabControl
    Friend WithEvents デイリー任務 As TabPage
    Friend WithEvents ウィークリー As TabPage
    Friend WithEvents マンスリー As TabPage
    Friend WithEvents クォータリー As TabPage
    Friend WithEvents 単発 As TabPage
    Friend WithEvents 受注中任務 As GroupBox
    Friend WithEvents 受注中任務表示 As DataGridView
    Friend WithEvents デイリー任務表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ウィークリー任務表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents マンスリー任務表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents クォータリー任務表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents 単発任務表示 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents 種類 As DataGridViewTextBoxColumn
    Friend WithEvents 任務名 As DataGridViewTextBoxColumn
    Friend WithEvents 状態 As DataGridViewTextBoxColumn
End Class
