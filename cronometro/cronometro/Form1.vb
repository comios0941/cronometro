Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text + 1
        If Label3.Text = 60 Then
            Label3.Text = 0
            Label2.Text = Label2.Text + 1
            If Label2.Text = 60 Then
                Label2.Text = 0
                Label1.Text = Label1.Text + 1
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Label3.Text = 0
        Label2.Text = 0
        Label1.Text = 0
    End Sub
End Class
