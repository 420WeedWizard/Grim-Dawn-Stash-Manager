Public Class Form1
    Private Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As System.Int16) As Int16
    Dim SaveLocation As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\My Games\Grim Dawn\save\"
    Dim GSTFile As String = SaveLocation & "transfer.gst"
    Dim AppPath As String = Application.StartupPath
    Dim ConfigPath As String = AppPath & "\options.cfg"
    Dim GSTInfo As String = AppPath & "\GST.cfg"
    Dim GSTFiles As String = AppPath & "\gst"
    Dim HotkeyInfo As String = Application.StartupPath & "\hotkey.cfg"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveGSTList()
        hotkeys.SaveHotkeys()

        Try
            If Loaded = True Then
                UnloadStash(ListView1.Items(LoadedIndex).SubItems(2).Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckSaveLocation()
        LoadGSTList()
        hotkeys.LoadHotkeys()

        StripStatus.Text = ""

    End Sub

    Public LoadedFile As String = ""
    Public Loaded As Boolean = False
    Public Sub LoadStash(ByVal FileName As String, ByVal Title As String, ByVal ListViewIndex As Integer)
        Loaded = True
        Dim LoadedFile As String = FileName
        StripStatus.Text = FileName & " | LOADED"
        System.IO.File.Copy(GSTFiles & "\" & FileName, GSTFile, True)

        ListView1.Items(ListViewIndex).BackColor = Color.Green
        ListView1.Items(ListViewIndex).ForeColor = Color.White

        Dim Popup As New display
        Popup.Opacity = 80
        Popup.Label3.Text = Title
        Popup.Label4.Text = FileName
        Popup.Show()
        Popup.Location = New Point(100, 100)

    End Sub

    Public Sub UnloadStash(ByVal FileName As String)
        Dim LoadedFile As String = FileName
        ListView1.Items(LoadedIndex).BackColor = Color.White
        ListView1.Items(LoadedIndex).ForeColor = Color.Black
        StripStatus.Text = ""
        System.IO.File.Copy(GSTFile, GSTFiles & "\" & FileName, True)
        Loaded = False
    End Sub


    Public Sub SaveGSTList()
        Dim FileC As String = ""
        Dim int0 As Integer = 0
        While int0 < ListView1.Items.Count
            FileC &= ListView1.Items.Item(int0).SubItems.Item(0).Text & "♂" & ListView1.Items.Item(int0).SubItems.Item(1).Text & "♂" & ListView1.Items.Item(int0).SubItems.Item(2).Text & "®"
            int0 += 1
        End While
        System.IO.File.WriteAllText(GSTInfo, FileC)
    End Sub
    Private Sub LoadGSTList()
        ListView1.Items.Clear()

        Dim Lines() As String = System.IO.File.ReadAllText(GSTInfo).Split("®")
        Dim int0 As Integer = 0

        If Lines.Count = 0 Then
            Exit Sub
        End If

        Do While int0 < Lines.Count - 1

            Dim Row() As String = Lines(int0).Split("♂")
            Dim Title As String = Row(0)
            Dim Desc As String = Row(1)
            Dim File As String = Row(2)

            If System.IO.File.Exists(GSTFiles & "\" & File) Then

                With ListView1.Items.Add(Title)
                    .SubItems.Add(Desc)
                    .SubItems.Add(File)
                End With

            End If


            int0 += 1
        Loop


    End Sub

    Private Sub CheckSaveLocation()
        If System.IO.File.Exists(GSTInfo) = False Then
            System.IO.File.WriteAllText(GSTInfo, "")
        End If
        If System.IO.File.Exists(HotkeyInfo) = False Then
            System.IO.File.WriteAllText(HotkeyInfo, "")
        End If
        If System.IO.Directory.Exists(SaveLocation) = False Then
            ReturnError("%" & SaveLocation & "% - not found")
        End If

        If System.IO.File.Exists(GSTFile) = False Then
            ReturnError("%" & GSTFile & "% - not found")
        End If

        If System.IO.File.Exists(GSTFiles) = False Then
            System.IO.Directory.CreateDirectory(GSTFiles)
        End If

    End Sub


    'Standart Function to work with errors and display them
    Private Function ReturnError(Optional ByVal Errorcode As String = "UNDEFINED")
        MsgBox("Error" & vbNewLine & Errorcode.Replace("%", Chr(34)))
        Application.Exit()
    End Function

    
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If GetAsyncKeyState(Keys.F12) <> 0 Then
            Dim Popup As New display
            Popup.Opacity = 80
            Popup.Show()
            Popup.Location = New Point(100, 100)
        End If
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        hotkeys.ShowDialog()

    End Sub

    Private Sub AddGSTFile()
        Dim FileS As New OpenFileDialog
        FileS.InitialDirectory = SaveLocation
        FileS.Title = "Please selected the Stashfile"
        FileS.Filter = "Grim Dawn Stash File - Softcore(*.gst)|*.gst|All files (*.*)|*.*"
        FileS.ShowDialog()
        If FileS.FileName.Trim = "" Then
            Exit Sub
        End If
        Dim AddForm As New add
        AddForm.Text = FileS.FileName
        AddForm.Label4.Text = FileS.FileName
        AddForm.ShowDialog()
    End Sub

    Private Sub SelectFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFileToolStripMenuItem.Click
       
        AddGSTFile()


    End Sub


    Public LoadedIndex As Integer = 0
    Private Sub LoadStashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadStashToolStripMenuItem.Click
        Try

            If ListView1.Items.Count = 0 Then
                Exit Sub
            End If

            If Loaded = False Then
                LoadStash(ListView1.SelectedItems(0).SubItems(2).Text, ListView1.SelectedItems(0).Text, ListView1.SelectedItems(0).Index)
                LoadedIndex = ListView1.SelectedItems(0).Index
               
            Else
                UnloadStash(ListView1.Items(LoadedIndex).SubItems(2).Text)

                If Not ListView1.SelectedItems(0).Index = LoadedIndex Then
                    LoadStash(ListView1.SelectedItems(0).SubItems(2).Text, ListView1.SelectedItems(0).Text, ListView1.SelectedItems(0).Index)
                    LoadedIndex = ListView1.SelectedItems(0).Index
                End If
            End If


           
        Catch ex As Exception
            MsgBox("ERROR" & ex.Message)
        End Try


    End Sub

    Private Sub ConfirmToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfirmToolStripMenuItem.Click

        Dim EX As Boolean = False
        For Each Entry In hotkeys.ListView1.Items
            If Entry.subitems(2).text = ListView1.SelectedItems(0).Text Then
                EX = True
            End If
        Next

        If EX = True Then
            MsgBox("You cannot delete Stash files that have a hotkey assigned.", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        UnloadStash(ListView1.Items(LoadedIndex).SubItems(2).Text)
        ListView1.Items(LoadedIndex).BackColor = Color.White
        ListView1.Items(LoadedIndex).ForeColor = Color.Black

        System.IO.File.Delete(GSTFiles & "\" & ListView1.SelectedItems(0).SubItems(2).Text)
        SaveGSTList()
        LoadGSTList()

        hotkeys.LoadHotkeys()
        hotkeys.SaveHotkeys()


    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening
        If Loaded = True Then
            ContextMenuStrip1.Items.Item(1).Enabled = True
        Else
            ContextMenuStrip1.Items.Item(1).Enabled = False
        End If
    End Sub

    Private Sub UnloadStashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnloadStashToolStripMenuItem.Click
        
        Try
            UnloadStash(ListView1.Items(LoadedIndex).SubItems(2).Text)
           
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddEmtpyStashToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddEmtpyStashToolStripMenuItem.Click
        AddEmptyStash()
    End Sub

    Private Sub AddEmptyStash()

        Dim EmptyStash As String = AppPath & "\emptyStashPreset.gst"

        System.IO.File.WriteAllBytes(EmptyStash, My.Resources.transfer_empty)

        If Not System.IO.File.Exists(EmptyStash) Then
            MsgBox("Cannot load empty stash file preset." & vbNewLine & EmptyStash, MsgBoxStyle.Critical, "")
            Exit Sub

        End If

        Dim AddForm As New add
        AddForm.Text = EmptyStash
        AddForm.Label4.Text = EmptyStash
        AddForm.ShowDialog()

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.TopMost = True
        Me.TopMost = False
        Me.Show()
    End Sub

    Private Sub HotkeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HotkeyToolStripMenuItem.Click
        hotkeys.ShowDialog()
    End Sub

    Private Sub GrimDawnStashFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GrimDawnStashFileToolStripMenuItem.Click
        AddGSTFile()
    End Sub

    Private Sub EmptyStashFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmptyStashFileToolStripMenuItem.Click
        AddEmptyStash()
    End Sub

    Private Sub ForumThreadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForumThreadToolStripMenuItem.Click
        Process.Start("http://www.grimdawn.com/forums/showthread.php?p=315353")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

End Class
