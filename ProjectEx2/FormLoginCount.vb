Imports Microsoft.Win32

Public Class FormLoginCount

    Private Const RegPath As String = "SOFTWARE\ApplicationLogin"
    Private Const RegKeyName As String = "LoginCount"

    Private Sub FormLoginCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim count As Integer = GetAndIncrementLoginCount()
        lblLoginCount.Text = "This form has been opened " & count.ToString() & " time(s)."
    End Sub

    Private Sub ColorDialog1_Disposed(sender As Object, e As EventArgs)

    End Sub

    Private Function GetAndIncrementLoginCount() As Integer
        Dim count As Integer = 0

        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey(RegPath, True)

        If key Is Nothing Then
            key = Registry.CurrentUser.CreateSubKey(RegPath)
        End If

        Dim value As Object = key.GetValue(RegKeyName, 0)
        count = Convert.ToInt32(value)
        count += 1
        key.SetValue(RegKeyName, count, RegistryValueKind.DWord)
        key.Close()

        Return count
    End Function

End Class