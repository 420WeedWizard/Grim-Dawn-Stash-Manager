Public Class addKey

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        TextBox1.Text = e.KeyCode
        TextBox2.Text = e.KeyCode.ToString
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        TextBox1.Text = e.KeyCode
        TextBox2.Text = e.KeyCode.ToString
    End Sub

    Private Sub addKey_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each Entry In Form1.ListView1.Items
            ComboBox1.Items.Add(Entry.text)
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        ' Duplicate Check
        Dim EX As Boolean = False
        For Each Entry In hotkeys.ListView1.Items
            If Entry.subitems(2).text = ComboBox1.Text Then
                EX = True
            End If
        Next
        If EX = True Then
            MsgBox("This Stash already has a Hotkey assigned.", MsgBoxStyle.Critical, "")
            Exit Sub
        End If


        ' Add to list
        With hotkeys.ListView1.Items.Add(TextBox2.Text)
            .SubItems.Add(TextBox1.Text)
            .SubItems.Add(ComboBox1.Text)
        End With

        hotkeys.SaveHotkeys()

        Me.Close()
    End Sub
End Class