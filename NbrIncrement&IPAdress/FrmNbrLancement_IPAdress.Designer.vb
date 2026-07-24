<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNbrLancement_IPAdress
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
        LblNbrLancement = New Label()
        LblIPAddress = New Label()
        SuspendLayout()
        ' 
        ' LblNbrLancement
        ' 
        LblNbrLancement.AutoSize = True
        LblNbrLancement.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblNbrLancement.Location = New Point(105, 140)
        LblNbrLancement.Name = "LblNbrLancement"
        LblNbrLancement.Size = New Size(262, 40)
        LblNbrLancement.TabIndex = 0
        LblNbrLancement.Text = "LblNbrLancement"
        ' 
        ' LblIPAddress
        ' 
        LblIPAddress.AutoSize = True
        LblIPAddress.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblIPAddress.Location = New Point(105, 251)
        LblIPAddress.Name = "LblIPAddress"
        LblIPAddress.Size = New Size(193, 40)
        LblIPAddress.TabIndex = 1
        LblIPAddress.Text = "LblIPAddress"
        ' 
        ' FrmNbrLancement_IPAdress
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(792, 398)
        Controls.Add(LblIPAddress)
        Controls.Add(LblNbrLancement)
        Name = "FrmNbrLancement_IPAdress"
        Text = "FrmNbrLancement_IPAdress"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LblNbrLancement As Label
    Friend WithEvents LblIPAddress As Label

End Class
