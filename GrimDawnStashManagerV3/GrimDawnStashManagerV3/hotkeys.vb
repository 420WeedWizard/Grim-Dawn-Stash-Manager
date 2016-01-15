Public Class hotkeys
    Private Declare Function GetAsyncKeyState Lib "user32.dll" (ByVal vKey As System.Int16) As Int16
    Dim HotkeyInfo As String = Application.StartupPath & "\hotkey.cfg"

    Private Sub AddHotkeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddHotkeyToolStripMenuItem.Click
        Dim NewHK As New addKey
        NewHK.ShowDialog()

    End Sub

    Private Sub hotkeys_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveHotkeys()
    End Sub

    Private Sub hotkeys_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadHotkeys()


    End Sub

    Public Sub LoadHotkeys()
        ListView1.Items.Clear()

        Dim Lines() As String = System.IO.File.ReadAllText(HotkeyInfo).Split("®")
        Dim int0 As Integer = 0

        If Lines.Count = 0 Then
            Exit Sub
        End If

        Do While int0 < Lines.Count - 1

            Dim Row() As String = Lines(int0).Split("♂")
            Dim Title As String = Row(0)
            Dim Desc As String = Row(1)
            Dim File As String = Row(2)


            With ListView1.Items.Add(Title)
                .SubItems.Add(Desc)
                .SubItems.Add(File)
            End With



            int0 += 1
        Loop


    End Sub


    Public Sub SaveHotkeys()
        Dim FileC As String = ""
        Dim int0 As Integer = 0
        While int0 < ListView1.Items.Count
            FileC &= ListView1.Items.Item(int0).SubItems.Item(0).Text & "♂" & ListView1.Items.Item(int0).SubItems.Item(1).Text & "♂" & ListView1.Items.Item(int0).SubItems.Item(2).Text & "®"
            int0 += 1
        End While
        System.IO.File.WriteAllText(HotkeyInfo, FileC)

    End Sub


    Public Sub CheckHotkeys()
        For Each line In ListView1.Items
            Dim KeyCode As Short = line.subitems(1).text
            If GetAsyncKeyState(KeyCode) <> 0 Then

                Dim DesiredIndex As Integer = 0
                Dim DesiredFile As String = ""
                Dim DesiredTitle As String = ""

                For Each Entry In Form1.ListView1.Items
                    If Entry.text = line.subitems(2).text Then
                        DesiredIndex = Entry.index
                        DesiredFile = Entry.subitems(2).text
                        DesiredTitle = Entry.text
                    End If

                Next

                Try
                    If Form1.Loaded = False Then
                        Form1.LoadStash(DesiredFile, DesiredTitle, DesiredIndex)
                        Form1.Loaded = True
                        Form1.LoadedIndex = DesiredIndex
                    Else
                        Form1.UnloadStash(Form1.ListView1.Items(Form1.LoadedIndex).SubItems(2).Text)
                        Form1.LoadStash(DesiredFile, DesiredTitle, DesiredIndex)
                        Form1.Loaded = True
                        Form1.LoadedIndex = DesiredIndex
                    End If


                Catch ex As Exception

                End Try

            End If
        Next
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        CheckHotkeys()

    End Sub

    Private Sub RemoveHotkeyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoveHotkeyToolStripMenuItem.Click
        ListView1.SelectedItems(0).Remove()
        SaveHotkeys()
        LoadHotkeys()

    End Sub
End Class