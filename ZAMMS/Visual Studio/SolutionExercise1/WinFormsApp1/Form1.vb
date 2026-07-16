Imports System.Threading

Public Class Form1

    Private formIsLoaded As Boolean = False
    Private rnd As New Random()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Form is loading...")
        formIsLoaded = True
    End Sub
    Private Sub ButtonEX1_Click(sender As Object, e As EventArgs) Handles ButtonEX1.Click
        txtEX1.Text = "First Click "
    End Sub
    Private Sub txtEX1_TextChanged(sender As Object, e As EventArgs) Handles txtEX1.TextChanged
        ButtonEX1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256))
    End Sub
    Private Sub ButtonEX1_BackColorChanged(sender As Object, e As EventArgs) Handles ButtonEX1.BackColorChanged
        If formIsLoaded Then
            MessageBox.Show("Hello, World!")
        End If
    End Sub

End Class