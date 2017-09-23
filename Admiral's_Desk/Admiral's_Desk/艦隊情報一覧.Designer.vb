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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.艦隊表示 = New System.Windows.Forms.DataGridView()
        Me.艦娘名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.コンディション = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.艦隊表示, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1, 1)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(737, 20)
        Me.ComboBox1.TabIndex = 0
        '
        '艦隊表示
        '
        Me.艦隊表示.AllowUserToAddRows = False
        Me.艦隊表示.AllowUserToDeleteRows = False
        Me.艦隊表示.AllowUserToResizeColumns = False
        Me.艦隊表示.AllowUserToResizeRows = False
        Me.艦隊表示.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.艦隊表示.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.艦娘名, Me.HP, Me.コンディション})
        Me.艦隊表示.Location = New System.Drawing.Point(1, 28)
        Me.艦隊表示.Name = "艦隊表示"
        Me.艦隊表示.RowHeadersVisible = False
        Me.艦隊表示.RowTemplate.Height = 21
        Me.艦隊表示.Size = New System.Drawing.Size(737, 230)
        Me.艦隊表示.TabIndex = 1
        '
        '艦娘名
        '
        Me.艦娘名.HeaderText = "艦娘名"
        Me.艦娘名.MaxInputLength = 25
        Me.艦娘名.Name = "艦娘名"
        Me.艦娘名.Width = 150
        '
        'HP
        '
        Me.HP.HeaderText = "HP"
        Me.HP.MaxInputLength = 7
        Me.HP.Name = "HP"
        Me.HP.Width = 50
        '
        'コンディション
        '
        Me.コンディション.HeaderText = "cond."
        Me.コンディション.MaxInputLength = 3
        Me.コンディション.Name = "コンディション"
        Me.コンディション.Width = 40
        '
        '艦隊情報一覧
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 261)
        Me.ControlBox = False
        Me.Controls.Add(Me.艦隊表示)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "艦隊情報一覧"
        Me.ShowInTaskbar = False
        Me.Text = "艦隊情報一覧"
        CType(Me.艦隊表示, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents 艦隊表示 As DataGridView
    Friend WithEvents 艦娘名 As DataGridViewTextBoxColumn
    Friend WithEvents HP As DataGridViewTextBoxColumn
    Friend WithEvents コンディション As DataGridViewTextBoxColumn
End Class
