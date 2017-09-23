<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 資源等管理
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
        Me.表示部分 = New System.Windows.Forms.DataGridView()
        Me.資源資材名 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.数値 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.表示部分, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '表示部分
        '
        Me.表示部分.AllowUserToAddRows = False
        Me.表示部分.AllowUserToDeleteRows = False
        Me.表示部分.AllowUserToResizeColumns = False
        Me.表示部分.AllowUserToResizeRows = False
        Me.表示部分.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.表示部分.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.資源資材名, Me.数値})
        Me.表示部分.Dock = System.Windows.Forms.DockStyle.Fill
        Me.表示部分.Location = New System.Drawing.Point(0, 0)
        Me.表示部分.Name = "表示部分"
        Me.表示部分.RowHeadersVisible = False
        Me.表示部分.RowTemplate.Height = 21
        Me.表示部分.Size = New System.Drawing.Size(164, 167)
        Me.表示部分.TabIndex = 0
        '
        '資源資材名
        '
        Me.資源資材名.HeaderText = "資源資材名"
        Me.資源資材名.Name = "資源資材名"
        '
        '数値
        '
        Me.数値.HeaderText = "数値"
        Me.数値.MaxInputLength = 6
        Me.数値.Name = "数値"
        Me.数値.Width = 60
        '
        '資源等管理
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(164, 167)
        Me.ControlBox = False
        Me.Controls.Add(Me.表示部分)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "資源等管理", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.資源等管理
        Me.Name = "資源等管理"
        Me.ShowInTaskbar = False
        Me.Text = "資源・資材"
        CType(Me.表示部分, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents 表示部分 As DataGridView
    Friend WithEvents 資源資材名 As DataGridViewTextBoxColumn
    Friend WithEvents 数値 As DataGridViewTextBoxColumn
End Class
