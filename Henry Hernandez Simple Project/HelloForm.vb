Public Class HelloForm
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Location.X + Label1.Width < 0 Then
            Label1.Location = New Point(Me.Width, Label1.Location.Y)
        Else
            Label1.Location = New Point(Label1.Location.X - 10, Label1.Location.Y)
        End If
        If Me.Label1.ForeColor = SystemColors.ControlText Then
            Me.Label1.ForeColor = Color.YellowGreen
        Else
            Me.Label1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub HelloForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class