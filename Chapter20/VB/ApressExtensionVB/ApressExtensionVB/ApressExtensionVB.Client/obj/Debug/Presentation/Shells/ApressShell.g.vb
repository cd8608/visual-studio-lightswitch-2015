﻿#ExternalChecksum("C:\Source2015\Source2015Ready\Chapter20\VB\ApressExtensionVB\ApressExtensionVB\ApressExtensionVB.Client\Presentation\Shells\ApressShell.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","8C82B79AAD6BD43C29CD66927162A725")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading


Namespace Presentation.Shells
    
    <Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
    Partial Public Class ApressShell
        Inherits System.Windows.Controls.UserControl
        
        Friend WithEvents CommandPanel As System.Windows.Controls.ListBox
        
        Friend WithEvents navigationGroup As System.Windows.Controls.ComboBox
        
        Friend WithEvents navigationItems As System.Windows.Controls.ComboBox
        
        Friend WithEvents ScreenArea As System.Windows.Controls.TabControl
        
        Friend WithEvents LoggedInUser As System.Windows.Controls.TextBlock
        
        Private _contentLoaded As Boolean
        
        '''<summary>
        '''InitializeComponent
        '''</summary>
        <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Sub InitializeComponent()
            If _contentLoaded Then
                Return
            End If
            _contentLoaded = true
            System.Windows.Application.LoadComponent(Me, New System.Uri("/ApressExtensionVB.Client;component/Presentation/Shells/ApressShell.xaml", System.UriKind.Relative))
            Me.CommandPanel = CType(Me.FindName("CommandPanel"),System.Windows.Controls.ListBox)
            Me.navigationGroup = CType(Me.FindName("navigationGroup"),System.Windows.Controls.ComboBox)
            Me.navigationItems = CType(Me.FindName("navigationItems"),System.Windows.Controls.ComboBox)
            Me.ScreenArea = CType(Me.FindName("ScreenArea"),System.Windows.Controls.TabControl)
            Me.LoggedInUser = CType(Me.FindName("LoggedInUser"),System.Windows.Controls.TextBlock)
        End Sub
    End Class
End Namespace

