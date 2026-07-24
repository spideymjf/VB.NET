Imports System.Net

Public Class FrmNbrLancement_IPAdress
    Dim filePath As String = "Pathfile\NbrLancement.txt"
    Dim launchCount As Integer
    Dim ipAddress As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If My.Computer.FileSystem.FileExists(filePath) Then
                Dim content As String = My.Computer.FileSystem.ReadAllText(filePath)
                Dim parts() As String = content.Split(";"c)

                If parts.Length >= 1 Then
                    If Not Integer.TryParse(parts(0).Trim(), launchCount) Then
                        launchCount = 0
                    End If
                Else
                    launchCount = 0
                End If
            Else
                launchCount = 0
            End If

            launchCount += 1

            ipAddress = GetLocalIPAddress()

            Dim dataToSave As String = launchCount.ToString() & ";" & ipAddress
            My.Computer.FileSystem.WriteAllText(filePath, dataToSave, False)

            LblNbrLancement.Text = "Launch count: " & launchCount.ToString()
            LblIPAddress.Text = "IP Address: " & ipAddress

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Function GetLocalIPAddress() As String
        Dim hostName As String = Dns.GetHostName()
        Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)

        For Each ip As IPAddress In hostEntry.AddressList
            If ip.AddressFamily = Sockets.AddressFamily.InterNetwork Then
                Return ip.ToString()
            End If
        Next

        Return "IP not found"
    End Function
End Class
