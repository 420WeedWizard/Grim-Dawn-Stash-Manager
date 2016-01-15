Public Class display

    Private Sub display_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Dim C As Double = 0.8
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        
        Me.Opacity = C

        C -= 0.1

        If C < 0.1 Then
            Me.Close()
        End If

    End Sub
End Class