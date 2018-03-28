<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 遠征情報
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
        Me.遠征情報表示 = New System.Windows.Forms.DataGridView()
        Me.艦隊名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.遠征名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.残り時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.帰還時刻 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.タイマ = New System.Windows.Forms.Timer(Me.components)
        CType(Me.遠征情報表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '遠征情報表示
        '
        Me.遠征情報表示.AllowUserToAddRows = False
        Me.遠征情報表示.AllowUserToDeleteRows = False
        Me.遠征情報表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.遠征情報表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.艦隊名, Me.遠征名, Me.残り時間, Me.帰還時刻})
        Me.遠征情報表示.Dock = System.Windows.Forms.DockStyle.Fill
        Me.遠征情報表示.Location = New System.Drawing.Point(0, 0)
        Me.遠征情報表示.Name = "遠征情報表示"
        Me.遠征情報表示.ReadOnly = True
        Me.遠征情報表示.RowHeadersVisible = False
        Me.遠征情報表示.RowTemplate.Height = 21
        Me.遠征情報表示.Size = New System.Drawing.Size(384, 111)
        Me.遠征情報表示.TabIndex = 0
        '
        '艦隊名
        '
        Me.艦隊名.HeaderText = "艦隊名"
        Me.艦隊名.Name = "艦隊名"
        Me.艦隊名.ReadOnly = True
        '
        '遠征名
        '
        Me.遠征名.HeaderText = "遠征名"
        Me.遠征名.Name = "遠征名"
        Me.遠征名.ReadOnly = True
        Me.遠征名.Width = 120
        '
        '残り時間
        '
        Me.残り時間.HeaderText = "残り時間"
        Me.残り時間.Name = "残り時間"
        Me.残り時間.ReadOnly = True
        Me.残り時間.Width = 80
        '
        '帰還時刻
        '
        Me.帰還時刻.HeaderText = "帰還時刻"
        Me.帰還時刻.Name = "帰還時刻"
        Me.帰還時刻.ReadOnly = True
        Me.帰還時刻.Width = 80
        '
        'タイマ
        '
        Me.タイマ.Enabled = True
        '
        '遠征情報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 111)
        Me.Controls.Add(Me.遠征情報表示)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 150)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 150)
        Me.Name = "遠征情報"
        Me.Text = "遠征情報"
        CType(Me.遠征情報表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 遠征情報表示 As DataGridView
    Friend WithEvents 艦隊名 As DataGridViewTextBoxColumn
    Friend WithEvents 遠征名 As DataGridViewTextBoxColumn
    Friend WithEvents 残り時間 As DataGridViewTextBoxColumn
    Friend WithEvents 帰還時刻 As DataGridViewTextBoxColumn
    Friend WithEvents タイマ As Timer
End Class
