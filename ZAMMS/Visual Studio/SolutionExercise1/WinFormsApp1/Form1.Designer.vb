<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        ButtonEX1 = New Button()
        txtEX1 = New TextBox()
        SuspendLayout()
        ' 
        ' ButtonEX1
        ' 
        ButtonEX1.AutoSize = True
        ButtonEX1.BackColor = SystemColors.HotTrack
        ButtonEX1.FlatStyle = FlatStyle.Popup
        ButtonEX1.ForeColor = SystemColors.WindowText
        ButtonEX1.Location = New Point(479, 139)
        ButtonEX1.Name = "ButtonEX1"
        ButtonEX1.Size = New Size(131, 79)
        ButtonEX1.TabIndex = 0
        ButtonEX1.Text = "PRESS"
        ButtonEX1.UseVisualStyleBackColor = False
        ' 
        ' txtEX1
        ' 
        txtEX1.BackColor = SystemColors.Info
        txtEX1.BorderStyle = BorderStyle.FixedSingle
        txtEX1.CharacterCasing = CharacterCasing.Upper
        txtEX1.ForeColor = SystemColors.Desktop
        txtEX1.Location = New Point(452, 310)
        txtEX1.Name = "txtEX1"
        txtEX1.Size = New Size(181, 23)
        txtEX1.TabIndex = 1
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(981, 514)
        Controls.Add(txtEX1)
        Controls.Add(ButtonEX1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonEX1 As Button
    Friend WithEvents txtEX1 As TextBox

End Class
