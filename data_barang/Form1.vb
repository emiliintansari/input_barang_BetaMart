Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "abcde" Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("silahkan cek username atau password anda kembali")
        End If
    End Sub
End Class
