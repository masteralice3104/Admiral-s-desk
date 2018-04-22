<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 戦闘予報
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
        Me.出力ウインドウ = New System.Windows.Forms.TextBox()
        Me.更新タイマ = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        '出力ウインドウ
        '
        Me.出力ウインドウ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.出力ウインドウ.Location = New System.Drawing.Point(0, 0)
        Me.出力ウインドウ.Multiline = True
        Me.出力ウインドウ.Name = "出力ウインドウ"
        Me.出力ウインドウ.ReadOnly = True
        Me.出力ウインドウ.Size = New System.Drawing.Size(800, 450)
        Me.出力ウインドウ.TabIndex = 0
        '
        '更新タイマ
        '
        Me.更新タイマ.Enabled = True
        Me.更新タイマ.Interval = 1000
        '
        '戦闘予報
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.出力ウインドウ)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.Admiral_s_Desk.My.MySettings.Default, "戦闘予報ウインドウ位置", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Location = Global.Admiral_s_Desk.My.MySettings.Default.戦闘予報ウインドウ位置
        Me.Name = "戦闘予報"
        Me.Text = "戦闘予報"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents 出力ウインドウ As TextBox
    Friend WithEvents 更新タイマ As Timer
End Class
