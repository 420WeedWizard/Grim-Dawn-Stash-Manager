﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Dieser Code wurde von einem Tool generiert.
'     Laufzeitversion:2.0.50727.5485
'
'     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
'     der Code erneut generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    '-Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    'Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    'mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    '''<summary>
    '''  Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("GrimDawnStashManagerV3.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        '''  Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        Friend ReadOnly Property _1452874527_preferences_desktop_keyboard() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("1452874527_preferences-desktop-keyboard", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property test111() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("test111", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        Friend ReadOnly Property transfer_empty() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("transfer_empty", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        Friend ReadOnly Property Unbenannt_12() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Unbenannt-12", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
