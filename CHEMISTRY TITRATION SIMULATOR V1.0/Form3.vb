Public Class Form3
    Dim x As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        x = x + 1
        Dim ctl As Control
        For Each ctl In Controls
            If TypeOf ctl Is PictureBox Then
                If ctl.Name(1) = x & "" Then
                    ctl.BackColor = Color.Black
                Else
                    ctl.BackColor = Color.White
                End If
            End If
        Next
        If x = 6 Then
            x = 0
        End If
        Me.Focus()
        Me.Show()
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer1.Enabled = False
        Me.Hide()
        Form1.Show()
    End Sub
End Class