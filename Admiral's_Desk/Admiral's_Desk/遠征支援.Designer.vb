<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 遠征支援
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.遠征名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.時間 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.燃料 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.弾薬 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.鋼材 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ボーキサイト = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.必須条件 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.大成功条件 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.遠征名, Me.時間, Me.燃料, Me.弾薬, Me.鋼材, Me.ボーキサイト, Me.必須条件, Me.大成功条件})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 21
        Me.DataGridView1.Size = New System.Drawing.Size(729, 351)
        Me.DataGridView1.TabIndex = 0
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 45
        '
        '遠征名
        '
        Me.遠征名.HeaderText = "遠征名"
        Me.遠征名.Name = "遠征名"
        Me.遠征名.ReadOnly = True
        '
        '時間
        '
        Me.時間.HeaderText = "時間"
        Me.時間.Name = "時間"
        Me.時間.ReadOnly = True
        Me.時間.Width = 60
        '
        '燃料
        '
        Me.燃料.HeaderText = "燃"
        Me.燃料.Name = "燃料"
        Me.燃料.ReadOnly = True
        Me.燃料.Width = 30
        '
        '弾薬
        '
        Me.弾薬.HeaderText = "弾"
        Me.弾薬.Name = "弾薬"
        Me.弾薬.ReadOnly = True
        Me.弾薬.Width = 30
        '
        '鋼材
        '
        Me.鋼材.HeaderText = "鋼"
        Me.鋼材.Name = "鋼材"
        Me.鋼材.ReadOnly = True
        Me.鋼材.Width = 30
        '
        'ボーキサイト
        '
        Me.ボーキサイト.HeaderText = "ボ"
        Me.ボーキサイト.Name = "ボーキサイト"
        Me.ボーキサイト.ReadOnly = True
        Me.ボーキサイト.Width = 30
        '
        '必須条件
        '
        Me.必須条件.HeaderText = "必須条件"
        Me.必須条件.Name = "必須条件"
        Me.必須条件.ReadOnly = True
        Me.必須条件.Width = 200
        '
        '大成功条件
        '
        Me.大成功条件.HeaderText = "大成功条件"
        Me.大成功条件.Name = "大成功条件"
        Me.大成功条件.ReadOnly = True
        Me.大成功条件.Width = 200
        '
        '遠征支援
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 351)
        Me.Controls.Add(Me.DataGridView1)
        Me.MinimumSize = New System.Drawing.Size(745, 0)
        Me.Name = "遠征支援"
        Me.Text = "遠征支援"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents 遠征名 As DataGridViewTextBoxColumn
    Friend WithEvents 時間 As DataGridViewTextBoxColumn
    Friend WithEvents 燃料 As DataGridViewTextBoxColumn
    Friend WithEvents 弾薬 As DataGridViewTextBoxColumn
    Friend WithEvents 鋼材 As DataGridViewTextBoxColumn
    Friend WithEvents ボーキサイト As DataGridViewTextBoxColumn
    Friend WithEvents 必須条件 As DataGridViewTextBoxColumn
    Friend WithEvents 大成功条件 As DataGridViewTextBoxColumn
End Class
