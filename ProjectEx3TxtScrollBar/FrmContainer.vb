Public Class FrmContainer
    Private Sub FrmContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtMultiline.Multiline = True
        TxtMultiline.ScrollBars = ScrollBars.Vertical
        TxtMultiline.WordWrap = False
    End Sub

    Private Sub AddText(newText As String)
        TxtMultiline.AppendText(newText & Environment.NewLine)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddText(TxtInput.Text)
    End Sub
End Class
