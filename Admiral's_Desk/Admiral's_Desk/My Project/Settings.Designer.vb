﻿'------------------------------------------------------------------------------
' <auto-generated>
'     このコードはツールによって生成されました。
'     ランタイム バージョン:4.0.30319.42000
'
'     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
'     コードが再生成されるときに損失したりします。
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings 自動保存機能"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property KancolleFormLocation() As Global.System.Drawing.Point
            Get
                Return CType(Me("KancolleFormLocation"),Global.System.Drawing.Point)
            End Get
            Set
                Me("KancolleFormLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 資源等管理() As Global.System.Drawing.Point
            Get
                Return CType(Me("資源等管理"),Global.System.Drawing.Point)
            End Get
            Set
                Me("資源等管理") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 遠征情報表示() As Global.System.Drawing.Point
            Get
                Return CType(Me("遠征情報表示"),Global.System.Drawing.Point)
            End Get
            Set
                Me("遠征情報表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 艦隊情報一覧位置() As Global.System.Drawing.Point
            Get
                Return CType(Me("艦隊情報一覧位置"),Global.System.Drawing.Point)
            End Get
            Set
                Me("艦隊情報一覧位置") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 遠征情報ウインドウ位置() As Global.System.Drawing.Point
            Get
                Return CType(Me("遠征情報ウインドウ位置"),Global.System.Drawing.Point)
            End Get
            Set
                Me("遠征情報ウインドウ位置") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 艦隊情報ウインドウ位置() As Global.System.Drawing.Point
            Get
                Return CType(Me("艦隊情報ウインドウ位置"),Global.System.Drawing.Point)
            End Get
            Set
                Me("艦隊情報ウインドウ位置") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 提督情報ウインドウ位置() As Global.System.Drawing.Point
            Get
                Return CType(Me("提督情報ウインドウ位置"),Global.System.Drawing.Point)
            End Get
            Set
                Me("提督情報ウインドウ位置") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Unchecked")>  _
        Public Property 更新確認の有無() As Global.System.Windows.Forms.CheckState
            Get
                Return CType(Me("更新確認の有無"),Global.System.Windows.Forms.CheckState)
            End Get
            Set
                Me("更新確認の有無") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 提督ウインドウ表示() As Boolean
            Get
                Return CType(Me("提督ウインドウ表示"),Boolean)
            End Get
            Set
                Me("提督ウインドウ表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 艦隊ウインドウ表示() As Boolean
            Get
                Return CType(Me("艦隊ウインドウ表示"),Boolean)
            End Get
            Set
                Me("艦隊ウインドウ表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 基地航空隊ウインドウ表示() As Boolean
            Get
                Return CType(Me("基地航空隊ウインドウ表示"),Boolean)
            End Get
            Set
                Me("基地航空隊ウインドウ表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 工廠ウインドウ表示() As Boolean
            Get
                Return CType(Me("工廠ウインドウ表示"),Boolean)
            End Get
            Set
                Me("工廠ウインドウ表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 任務ウインドウ表示() As Boolean
            Get
                Return CType(Me("任務ウインドウ表示"),Boolean)
            End Get
            Set
                Me("任務ウインドウ表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 遠征ウインドウ表示() As Boolean
            Get
                Return CType(Me("遠征ウインドウ表示"),Boolean)
            End Get
            Set
                Me("遠征ウインドウ表示") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 工廠情報ウインドウ位置() As Global.System.Drawing.Point
            Get
                Return CType(Me("工廠情報ウインドウ位置"),Global.System.Drawing.Point)
            End Get
            Set
                Me("工廠情報ウインドウ位置") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property 建造開発ネタバレチェック() As Boolean
            Get
                Return CType(Me("建造開発ネタバレチェック"),Boolean)
            End Get
            Set
                Me("建造開発ネタバレチェック") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property 動作速度() As Integer
            Get
                Return CType(Me("動作速度"),Integer)
            End Get
            Set
                Me("動作速度") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0, 0")>  _
        Public Property 任務情報ウインドウ位置() As Global.System.Drawing.Point
            Get
                Return CType(Me("任務情報ウインドウ位置"),Global.System.Drawing.Point)
            End Get
            Set
                Me("任務情報ウインドウ位置") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property 入手艦娘記録() As Boolean
            Get
                Return CType(Me("入手艦娘記録"),Boolean)
            End Get
            Set
                Me("入手艦娘記録") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property 入手艦娘記録名() As String
            Get
                Return CType(Me("入手艦娘記録名"),String)
            End Get
            Set
                Me("入手艦娘記録名") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property 更新確認() As Boolean
            Get
                Return CType(Me("更新確認"),Boolean)
            End Get
            Set
                Me("更新確認") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property 大破通知() As Boolean
            Get
                Return CType(Me("大破通知"),Boolean)
            End Get
            Set
                Me("大破通知") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.Admiral_s_Desk.My.MySettings
            Get
                Return Global.Admiral_s_Desk.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
