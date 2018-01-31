Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Create an instance of MessageForm. 
        Dim frmHelloForm As New HelloForm

        ' Display the form in modal style. 
        frmHelloForm.Show()
    End Sub
End Class
