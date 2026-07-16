<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEx2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnAppelFrmEx1 = New Button()
        BtnAffichageVariableApplicationFormEx1 = New Button()
        SuspendLayout()
        ' 
        ' BtnAppelFrmEx1
        ' 
        BtnAppelFrmEx1.Location = New Point(216, 76)
        BtnAppelFrmEx1.Name = "BtnAppelFrmEx1"
        BtnAppelFrmEx1.Size = New Size(309, 94)
        BtnAppelFrmEx1.TabIndex = 0
        BtnAppelFrmEx1.Text = "Appel Form Ex1"
        BtnAppelFrmEx1.UseVisualStyleBackColor = True
        ' 
        ' BtnAffichageVariableApplicationFormEx1
        ' 
        BtnAffichageVariableApplicationFormEx1.Location = New Point(216, 235)
        BtnAffichageVariableApplicationFormEx1.Name = "BtnAffichageVariableApplicationFormEx1"
        BtnAffichageVariableApplicationFormEx1.Size = New Size(309, 103)
        BtnAffichageVariableApplicationFormEx1.TabIndex = 1
        BtnAffichageVariableApplicationFormEx1.Text = "Afficher Variable Application Ex1"
        BtnAffichageVariableApplicationFormEx1.UseVisualStyleBackColor = True
        ' 
        ' FrmEx2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(728, 461)
        Controls.Add(BtnAffichageVariableApplicationFormEx1)
        Controls.Add(BtnAppelFrmEx1)
        Name = "FrmEx2"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnAppelFrmEx1 As Button
    Friend WithEvents BtnAffichageVariableApplicationFormEx1 As Button
End Class
