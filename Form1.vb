Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 950
        If Label1.Text = 0 Then
            Label1.Text = Val(Label1.Text) + 1
        Else
            Label1.Text = Val(Label1.Text) + 1
        End If
        If Label1.Text = 60 Then
            Label4.Text = Val(Label4.Text) + 1
            Label1.Text = 0
        End If
        If Label4.Text = 60 Then
            Label5.Text = Val(Label5.Text) + 1
            Label4.Text = 0
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        If Label1.Text = 0 Then
            Timer1.Start()
        Else
            Timer1.Start()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        Label1.Text = 0
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
