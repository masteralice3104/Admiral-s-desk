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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.動作調整バー = New System.Windows.Forms.TrackBar()
        Me.更新チェック = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.全般設定.SuspendLayout()
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.全般設定.Controls.Add(Me.Label5)
        Me.全般設定.Controls.Add(Me.Label4)
        Me.全般設定.Controls.Add(Me.Label3)
        Me.全般設定.Controls.Add(Me.Label2)
        Me.全般設定.Controls.Add(Me.動作調整バー)
        Me.全般設定.Controls.Add(Me.Label1)
        Me.全般設定.Controls.Add(Me.更新チェック)
        Me.全般設定.Location = New System.Drawing.Point(4, 22)
        Me.全般設定.Name = "全般設定"
        Me.全般設定.Padding = New System.Windows.Forms.Padding(3)
        Me.全般設定.Size = New System.Drawing.Size(252, 111)
        Me.全般設定.TabIndex = 0
        Me.全般設定.Text = "全般"
        Me.全般設定.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "動作速度設定"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(217, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "推奨"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "x0.67"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 12)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "x0.50"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "x0.40"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '動作調整バー
        '
        Me.動作調整バー.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.Admiral_s_Desk.My.MySettings.Default, "動作速度", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.動作調整バー.Location = New System.Drawing.Point(9, 60)
        Me.動作調整バー.Maximum = 3
        Me.動作調整バー.Name = "動作調整バー"
        Me.動作調整バー.Size = New System.Drawing.Size(237, 45)
        Me.動作調整バー.TabIndex = 2
        Me.動作調整バー.Value = Global.Admiral_s_Desk.My.MySettings.Default.動作速度
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
        CType(Me.動作調整バー, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents 全般設定 As TabPage
    Friend WithEvents 更新チェック As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents 動作調整バー As TrackBar
    Friend WithEvents Label1 As Label
End Class
