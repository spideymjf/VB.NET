Imports System.Windows

Public Class FrmEx2
    Private Sub BtnAffichageVariableApplicationFormEx1_Click(sender As Object, e As EventArgs) Handles BtnAffichageVariableApplicationFormEx1.Click

        Try
            Dim VariableAppEx1 As String
            VariableAppEx1 = FrmEx1.VariableApplicationFormEx1
            MessageBox.Show("La valeur de la variable Application Du Form Ex1 est : " & VariableAppEx1, "variable Application", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error opening Form2: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnAppelFrmEx1_Click(sender As Object, e As EventArgs) Handles BtnAppelFrmEx1.Click
        Try
            Dim f1 As New FrmEx1()
            f1.Show()
        Catch ex As Exception
            MessageBox.Show("Error opening Form1: " & ex.Message)
        End Try
    End Sub
End Class