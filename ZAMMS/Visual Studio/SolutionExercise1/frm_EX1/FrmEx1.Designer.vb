<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEx1
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
        BtnIncrement = New Button()
        TxtCompteurGlobal = New TextBox()
        LblCompteurGlobal = New Label()
        LblCompteurLocal = New Label()
        TxtCompteurLocal = New TextBox()
        TxtSaisieVariable = New TextBox()
        LblSaisieVariable = New Label()
        SuspendLayout()
        ' 
        ' BtnIncrement
        ' 
        BtnIncrement.Location = New Point(87, 68)
        BtnIncrement.Name = "BtnIncrement"
        BtnIncrement.Size = New Size(187, 79)
        BtnIncrement.TabIndex = 0
        BtnIncrement.Text = "BtnIncrmnt"
        BtnIncrement.UseVisualStyleBackColor = True
        ' 
        ' TxtCompteurGlobal
        ' 
        TxtCompteurGlobal.Location = New Point(343, 75)
        TxtCompteurGlobal.Name = "TxtCompteurGlobal"
        TxtCompteurGlobal.Size = New Size(307, 23)
        TxtCompteurGlobal.TabIndex = 1
        ' 
        ' LblCompteurGlobal
        ' 
        LblCompteurGlobal.AutoSize = True
        LblCompteurGlobal.BackColor = SystemColors.MenuHighlight
        LblCompteurGlobal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCompteurGlobal.ForeColor = SystemColors.ActiveCaptionText
        LblCompteurGlobal.Location = New Point(384, 33)
        LblCompteurGlobal.Name = "LblCompteurGlobal"
        LblCompteurGlobal.Size = New Size(227, 25)
        LblCompteurGlobal.TabIndex = 2
        LblCompteurGlobal.Text = "Valeur Compteur Global"
        ' 
        ' LblCompteurLocal
        ' 
        LblCompteurLocal.AutoSize = True
        LblCompteurLocal.BackColor = SystemColors.MenuHighlight
        LblCompteurLocal.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LblCompteurLocal.ForeColor = SystemColors.ActiveCaptionText
        LblCompteurLocal.Location = New Point(396, 122)
        LblCompteurLocal.Name = "LblCompteurLocal"
        LblCompteurLocal.Size = New Size(215, 25)
        LblCompteurLocal.TabIndex = 4
        LblCompteurLocal.Text = "Valeur Compteur Local"
        ' 
        ' TxtCompteurLocal
        ' 
        TxtCompteurLocal.Location = New Point(343, 154)
        TxtCompteurLocal.Name = "TxtCompteurLocal"
        TxtCompteurLocal.Size = New Size(307, 23)
        TxtCompteurLocal.TabIndex = 3
        ' 
        ' TxtSaisieVariable
        ' 
        TxtSaisieVariable.Location = New Point(347, 305)
        TxtSaisieVariable.Name = "TxtSaisieVariable"
        TxtSaisieVariable.Size = New Size(161, 23)
        TxtSaisieVariable.TabIndex = 5
        ' 
        ' LblSaisieVariable
        ' 
        LblSaisieVariable.AutoSize = True
        LblSaisieVariable.Location = New Point(235, 308)
        LblSaisieVariable.Name = "LblSaisieVariable"
        LblSaisieVariable.Size = New Size(106, 15)
        LblSaisieVariable.TabIndex = 6
        LblSaisieVariable.Text = "Saississez Variable :"
        ' 
        ' FrmEx1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 450)
        Controls.Add(LblSaisieVariable)
        Controls.Add(TxtSaisieVariable)
        Controls.Add(LblCompteurLocal)
        Controls.Add(TxtCompteurLocal)
        Controls.Add(LblCompteurGlobal)
        Controls.Add(TxtCompteurGlobal)
        Controls.Add(BtnIncrement)
        Name = "FrmEx1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnIncrement As Button
    Friend WithEvents TxtCompteurGlobal As TextBox
    Friend WithEvents LblCompteurGlobal As Label
    Friend WithEvents LblCompteurLocal As Label
    Friend WithEvents TxtCompteurLocal As TextBox
    Friend WithEvents TxtSaisieVariable As TextBox
    Friend WithEvents LblSaisieVariable As Label

End Class
