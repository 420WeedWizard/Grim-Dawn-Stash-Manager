Imports System
Imports System.Text
Public Class add

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim = "" Then
            MsgBox("Please enter a Title.", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If TextBox3.Text.Trim = "" Then
            MsgBox("Please enter a Filename.", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        If System.IO.File.Exists(Application.StartupPath & "\GST\" & TextBox3.Text) Then
            MsgBox("Filename is already in exsistence", MsgBoxStyle.Critical, "")
            Exit Sub
        End If

        System.IO.File.Copy(Label4.Text, Application.StartupPath & "\GST\" & TextBox3.Text)

        With Form1.ListView1.Items.Add(TextBox1.Text)
            .SubItems.Add(TextBox2.Text)
            .SubItems.Add(TextBox3.Text)
        End With

        MsgBox("Succes", MsgBoxStyle.Information, "")

        Form1.SaveGSTList()


        Me.Close()
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        Label5.Text = "Enter a desired Title for the selected Grim Dawn Stash that will be displayed in the list."
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.GotFocus
        Label5.Text = "*OPTIONAL* Enter a desired describtion for the selected Grim Dawn Stash that will be displayed in the list."
    End Sub

    Private Sub TextBox3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.GotFocus
        Label5.Text = "Automaticly generated filename that the stash is going to be saved under."
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        TextBox3.Text = Convert.ToBase64String(Encoding.UTF8.GetBytes(TextBox1.Text))
    End Sub
End Class