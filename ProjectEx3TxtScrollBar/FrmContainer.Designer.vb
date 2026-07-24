<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmContainer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtMultiline = New TextBox()
        BtnAdd = New Button()
        TxtInput = New TextBox()
        SuspendLayout()
        ' 
        ' TxtMultiline
        ' 
        TxtMultiline.Location = New Point(460, 147)
        TxtMultiline.Multiline = True
        TxtMultiline.Name = "TxtMultiline"
        TxtMultiline.Size = New Size(264, 202)
        TxtMultiline.TabIndex = 0
        ' 
        ' BtnAdd
        ' 
        BtnAdd.Location = New Point(328, 241)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(75, 23)
        BtnAdd.TabIndex = 1
        BtnAdd.Text = "BtnAdd"
        BtnAdd.UseVisualStyleBackColor = True
        ' 
        ' TxtInput
        ' 
        TxtInput.Location = New Point(88, 241)
        TxtInput.Name = "TxtInput"
        TxtInput.Size = New Size(200, 23)
        TxtInput.TabIndex = 2
        ' 
        ' FrmContainer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TxtInput)
        Controls.Add(BtnAdd)
        Controls.Add(TxtMultiline)
        Name = "FrmContainer"
        Text = "FrmContainer"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtMultiline As TextBox
    Friend WithEvents BtnAdd As Button
    Friend WithEvents TxtInput As TextBox

End Class
