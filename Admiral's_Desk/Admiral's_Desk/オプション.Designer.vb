<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class オプション
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.全般設定 = New System.Windows.Forms.TabPage()
        Me.更新チェック = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.全般設定.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.全般設定)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(260, 137)
        Me.TabControl1.TabIndex = 0
        '
        '全般設定
        '
        Me.全般設定.Controls.Add(Me.更新チェック)
        Me.全般設定.Location = New System.Drawing.Point(4, 22)
        Me.全般設定.Name = "全般設定"
        Me.全般設定.Padding = New System.Windows.Forms.Padding(3)
        Me.全般設定.Size = New System.Drawing.Size(252, 111)
        Me.全般設定.TabIndex = 0
        Me.全般設定.Text = "全般"
        Me.全般設定.UseVisualStyleBackColor = True
        '
        '更新チェック
        '
        Me.更新チェック.AutoSize = True
        Me.更新チェック.CheckState = Global.Admiral_s_Desk.My.MySettings.Default.更新確認の有無
        Me.更新チェック.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Global.Admiral_s_Desk.My.MySettings.Default, "更新確認の有無", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.更新チェック.Location = New System.Drawing.Point(7, 7)
        Me.更新チェック.Name = "更新チェック"
        Me.更新チェック.Size = New System.Drawing.Size(155, 16)
        Me.更新チェック.TabIndex = 0
        Me.更新チェック.Text = "起動時に更新の確認をする"
        Me.更新チェック.UseVisualStyleBackColor = True
        '
        'オプション
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 161)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(300, 200)
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "オプション"
        Me.Text = "オプション"
        Me.TabControl1.ResumeLayout(False)
        Me.全般設定.ResumeLayout(False)
        Me.全般設定.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents 全般設定 As TabPage
    Friend WithEvents 更新チェック As CheckBox
End Class
