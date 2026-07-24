<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLoginCount
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
        lblLoginCount = New Label()
        SuspendLayout()
        ' 
        ' lblLoginCount
        ' 
        lblLoginCount.AutoSize = True
        lblLoginCount.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLoginCount.Location = New Point(223, 206)
        lblLoginCount.Name = "lblLoginCount"
        lblLoginCount.Size = New Size(142, 30)
        lblLoginCount.TabIndex = 0
        lblLoginCount.Text = "lblLoginCount"
        lblLoginCount.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FormLoginCount
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblLoginCount)
        Name = "FormLoginCount"
        Text = "FormLoginCount"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLoginCount As Label

End Class
