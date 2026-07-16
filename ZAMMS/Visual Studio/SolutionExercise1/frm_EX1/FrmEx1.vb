Imports System.Threading

Public Class FrmEx1
    Dim CompteurGlobal As Integer = 0
    Dim ProgressBar As New ProgressBar()
    Dim IsFormLoaded As Boolean = False
    Private WithEvents incrementTimer As New System.Windows.Forms.Timer()
    Private incrementMax As Integer = 0
    Private incrementCount As Integer = 0
    Public Shared VariableApplicationFormEx1 As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsFormLoaded = True
        ProgressBar.Height = 60
        ProgressBar.Dock = DockStyle.Bottom

        ProgressBar.Minimum = 0
        ProgressBar.Maximum = 10
    End Sub
    Private Sub TextBoxCompteurGlobal_Click(sender As Object, e As EventArgs) Handles TxtCompteurGlobal.Click

    End Sub

    Private Sub TextBoxCompteurLocal_Click(sender As Object, e As EventArgs) Handles TxtCompteurLocal.Click

    End Sub

    Private Sub ButtonIncrement_Click(sender As Object, e As EventArgs) Handles BtnIncrement.Click
        Try
            If IsFormLoaded Then
                If incrementTimer.Enabled Then
                    incrementTimer.Stop()
                End If

                incrementMax = 10
                incrementCount = 0
                incrementTimer.Interval = 500
                incrementTimer.Start()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub incrementTimer_Tick(sender As Object, e As EventArgs) Handles incrementTimer.Tick
        Try
            Static CompteurLocal As Integer

            If incrementCount = 0 Then
                CompteurLocal = 0
            End If

            If incrementCount < incrementMax Then
                CompteurGlobal += 1
                CompteurLocal += 1
                ProgressBar.Value = CompteurLocal
                TxtCompteurGlobal.Text = CompteurGlobal.ToString()
                TxtCompteurLocal.Text = CompteurLocal.ToString()
                incrementCount += 1
                Me.Controls.Add(ProgressBar)
            Else
                incrementTimer.Stop()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            incrementTimer.Stop()
        End Try
    End Sub

    Private Sub TxtSaisieVariable_TextChanged(sender As Object, e As EventArgs) Handles TxtSaisieVariable.TextChanged
        Try
            VariableApplicationFormEx1 = TxtSaisieVariable.Text
        Catch ex As Exception
            Console.WriteLine("Error Typing Variable: " & ex.Message)
        End Try
    End Sub
End Class