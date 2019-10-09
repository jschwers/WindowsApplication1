Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Collections
Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Runtime.InteropServices
Public Class GUIControl
    'add an item to a ListView
    Public Delegate Sub ListViewAddItem(ByVal l As ListView, ByVal s As String)
    Public Shared Sub ListViewAddItem1(ByVal l As ListView, ByVal s As String)

        l.Items.Add(New ListViewItem(s))
    End Sub
    Public Shared Sub IListViewAddItem(ByVal form As Control, ByVal l As ListView, ByVal s As String)

        If l.InvokeRequired Then
            Dim LVAI As New ListViewAddItem(AddressOf GUIControl.ListViewAddItem1)
            form.Invoke(LVAI, New [Object]() {l, s})
        Else
            l.Items.Add(New ListViewItem(s))
        End If
    End Sub

    'Insert an item to a ListView

    Public Delegate Sub ListViewInsertItem(ByVal l As ListView, ByVal i As Integer, ByVal s As String)
    Public Shared Sub ListViewInsertItem1(ByVal l As ListView, ByVal i As Integer, ByVal s As String)
        l.Items.Insert(i, New ListViewItem(s))
    End Sub
    Public Shared Sub IListViewInsertItem(ByVal form As Control, ByVal l As ListView, ByVal i As Integer, ByVal s As String)

        If l.InvokeRequired Then
            Dim LVAI As New ListViewInsertItem(AddressOf GUIControl.ListViewInsertItem1)
            form.Invoke(LVAI, New [Object]() {l, i, s})
        Else
            l.Items.Insert(i, New ListViewItem(s))
        End If
    End Sub

    'add an item to a ListView
    Public Delegate Sub ListBoxAddItem(ByVal l As ListBox, ByVal s As String)
    Public Shared Sub ListBoxAddItem1(ByVal l As ListBox, ByVal s As String)
        l.Items.Add(s)
    End Sub
    Public Shared Sub IListBoxAddItem(ByVal form As Control, ByVal l As ListBox, ByVal s As String)

        If l.InvokeRequired Then
            Dim LBAI As New ListBoxAddItem(AddressOf GUIControl.ListBoxAddItem1)
            form.Invoke(LBAI, New [Object]() {l, s})
        Else
            l.Items.Add(s)
        End If
    End Sub

    'enable or disable a control
    Public Delegate Sub ControlEnable(ByVal c As Control, ByVal enable As Boolean)
    Public Shared Sub ControlEnable1(ByVal c As Control, ByVal enable As Boolean)
        c.Enabled = enable
    End Sub
    Public Shared Sub IControlEnable(ByVal form As Control, ByVal c As Control, ByVal enable As Boolean)

        If c.InvokeRequired Then
            Dim ce As New ControlEnable(AddressOf GUIControl.ControlEnable1)
            form.Invoke(ce, New [Object]() {c, enable})
        Else
            c.Enabled = enable
        End If
    End Sub
    'update a control's text
    Public Delegate Sub ControlSetText(ByVal c As Control, ByVal s As String)
    Public Shared Sub ControlSetText1(ByVal c As Control, ByVal s As String)
        c.Text = s
    End Sub
    Public Shared Sub IControlSetText(ByVal form As Control, ByVal c As Control, ByVal s As String)

        If c.InvokeRequired Then
            Dim cst As New ControlSetText(AddressOf GUIControl.ControlSetText1)
            form.Invoke(cst, New [Object]() {c, s})
        Else
            c.Text = s
        End If
    End Sub

    'get count
    Public Delegate Function ListViewItemCount(ByVal l As ListView) As Integer
    Public Shared Function ListViewItemCount1(ByVal l As ListView) As Integer
        Return l.Items.Count
    End Function
    Public Shared Function IListViewItemCount(ByVal form As Control, ByVal l As ListView) As Integer

        If l.InvokeRequired Then
            Dim LVIC As New ListViewItemCount(AddressOf GUIControl.ListViewItemCount1)
            Return CInt(form.Invoke(LVIC, New [Object]() {l}))
        Else
            Return l.Items.Count
        End If
    End Function

End Class
