<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientManipulation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmClientManipulation))
        SplitContainer1 = New SplitContainer()
        dgvclient = New DataGridView()
        TxtEmail = New TextBox()
        TxtTelephone = New TextBox()
        TxtNomClient = New TextBox()
        txtcodeClient = New TextBox()
        LblEmailClient = New Label()
        LblTelephoneClient = New Label()
        LblNomClient = New Label()
        LblCodeClient = New Label()
        ToolStrip1 = New ToolStrip()
        Vertical_Panel = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        Add = New ToolStripButton()
        Save = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        Change = New ToolStripButton()
        Update = New ToolStripButton()
        ToolStripSeparator3 = New ToolStripSeparator()
        Delete = New ToolStripButton()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainer1.Panel1.SuspendLayout()
        SplitContainer1.Panel2.SuspendLayout()
        SplitContainer1.SuspendLayout()
        CType(dgvclient, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainer1
        ' 
        SplitContainer1.AllowDrop = True
        SplitContainer1.BorderStyle = BorderStyle.Fixed3D
        SplitContainer1.Dock = DockStyle.Fill
        SplitContainer1.Location = New Point(0, 0)
        SplitContainer1.Name = "SplitContainer1"
        ' 
        ' SplitContainer1.Panel1
        ' 
        SplitContainer1.Panel1.BackColor = Color.LightGray
        SplitContainer1.Panel1.Controls.Add(dgvclient)
        ' 
        ' SplitContainer1.Panel2
        ' 
        SplitContainer1.Panel2.Controls.Add(TxtEmail)
        SplitContainer1.Panel2.Controls.Add(TxtTelephone)
        SplitContainer1.Panel2.Controls.Add(TxtNomClient)
        SplitContainer1.Panel2.Controls.Add(txtcodeClient)
        SplitContainer1.Panel2.Controls.Add(LblEmailClient)
        SplitContainer1.Panel2.Controls.Add(LblTelephoneClient)
        SplitContainer1.Panel2.Controls.Add(LblNomClient)
        SplitContainer1.Panel2.Controls.Add(LblCodeClient)
        SplitContainer1.Panel2.Controls.Add(ToolStrip1)
        SplitContainer1.Size = New Size(1140, 515)
        SplitContainer1.SplitterDistance = 379
        SplitContainer1.TabIndex = 0
        ' 
        ' dgvclient
        ' 
        dgvclient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvclient.Dock = DockStyle.Bottom
        dgvclient.Location = New Point(0, 153)
        dgvclient.Name = "dgvclient"
        dgvclient.Size = New Size(375, 358)
        dgvclient.TabIndex = 0
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(234, 252)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(278, 23)
        TxtEmail.TabIndex = 8
        ' 
        ' TxtTelephone
        ' 
        TxtTelephone.Location = New Point(234, 214)
        TxtTelephone.Name = "TxtTelephone"
        TxtTelephone.Size = New Size(278, 23)
        TxtTelephone.TabIndex = 7
        ' 
        ' TxtNomClient
        ' 
        TxtNomClient.Location = New Point(234, 178)
        TxtNomClient.Name = "TxtNomClient"
        TxtNomClient.Size = New Size(278, 23)
        TxtNomClient.TabIndex = 6
        ' 
        ' txtcodeClient
        ' 
        txtcodeClient.Location = New Point(234, 145)
        txtcodeClient.Name = "txtcodeClient"
        txtcodeClient.Size = New Size(96, 23)
        txtcodeClient.TabIndex = 5
        ' 
        ' LblEmailClient
        ' 
        LblEmailClient.AutoSize = True
        LblEmailClient.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblEmailClient.Location = New Point(51, 252)
        LblEmailClient.Name = "LblEmailClient"
        LblEmailClient.Size = New Size(69, 25)
        LblEmailClient.TabIndex = 4
        LblEmailClient.Text = "Email :"
        ' 
        ' LblTelephoneClient
        ' 
        LblTelephoneClient.AutoSize = True
        LblTelephoneClient.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblTelephoneClient.Location = New Point(51, 214)
        LblTelephoneClient.Name = "LblTelephoneClient"
        LblTelephoneClient.Size = New Size(113, 25)
        LblTelephoneClient.TabIndex = 3
        LblTelephoneClient.Text = "Telephone :"
        ' 
        ' LblNomClient
        ' 
        LblNomClient.AutoSize = True
        LblNomClient.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblNomClient.Location = New Point(51, 176)
        LblNomClient.Name = "LblNomClient"
        LblNomClient.Size = New Size(122, 25)
        LblNomClient.TabIndex = 2
        LblNomClient.Text = "Nom Client :"
        ' 
        ' LblCodeClient
        ' 
        LblCodeClient.AutoSize = True
        LblCodeClient.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        LblCodeClient.Location = New Point(51, 140)
        LblCodeClient.Name = "LblCodeClient"
        LblCodeClient.Size = New Size(124, 25)
        LblCodeClient.TabIndex = 1
        LblCodeClient.Text = "Code Client :"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackgroundImageLayout = ImageLayout.None
        ToolStrip1.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ToolStrip1.Items.AddRange(New ToolStripItem() {Vertical_Panel, ToolStripSeparator1, Add, Save, ToolStripSeparator2, Change, Update, ToolStripSeparator3, Delete})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(753, 104)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' Vertical_Panel
        ' 
        Vertical_Panel.AutoSize = False
        Vertical_Panel.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Vertical_Panel.Image = CType(resources.GetObject("Vertical_Panel.Image"), Image)
        Vertical_Panel.ImageTransparentColor = Color.Magenta
        Vertical_Panel.Name = "Vertical_Panel"
        Vertical_Panel.Size = New Size(101, 101)
        Vertical_Panel.Tag = ""
        Vertical_Panel.Text = "Vertical_Panel"
        Vertical_Panel.TextAlign = ContentAlignment.BottomCenter
        Vertical_Panel.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 104)
        ' 
        ' Add
        ' 
        Add.AutoSize = False
        Add.Image = CType(resources.GetObject("Add.Image"), Image)
        Add.ImageTransparentColor = Color.Magenta
        Add.Name = "Add"
        Add.Size = New Size(101, 101)
        Add.Text = "Add"
        Add.TextAlign = ContentAlignment.BottomCenter
        Add.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' Save
        ' 
        Save.AutoSize = False
        Save.Image = CType(resources.GetObject("Save.Image"), Image)
        Save.ImageTransparentColor = Color.Magenta
        Save.Name = "Save"
        Save.Size = New Size(101, 101)
        Save.Text = "Save"
        Save.TextAlign = ContentAlignment.BottomCenter
        Save.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 104)
        ' 
        ' Change
        ' 
        Change.AutoSize = False
        Change.Image = CType(resources.GetObject("Change.Image"), Image)
        Change.ImageTransparentColor = Color.Magenta
        Change.Name = "Change"
        Change.Size = New Size(101, 101)
        Change.Text = "Change"
        Change.TextAlign = ContentAlignment.BottomCenter
        Change.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' Update
        ' 
        Update.AutoSize = False
        Update.Image = CType(resources.GetObject("Update.Image"), Image)
        Update.ImageTransparentColor = Color.Magenta
        Update.Name = "Update"
        Update.Size = New Size(101, 101)
        Update.Text = "Update"
        Update.TextAlign = ContentAlignment.BottomCenter
        Update.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(6, 104)
        ' 
        ' Delete
        ' 
        Delete.AutoSize = False
        Delete.Image = CType(resources.GetObject("Delete.Image"), Image)
        Delete.ImageTransparentColor = Color.Magenta
        Delete.Name = "Delete"
        Delete.Size = New Size(101, 101)
        Delete.Text = "Delete"
        Delete.TextAlign = ContentAlignment.BottomCenter
        Delete.TextImageRelation = TextImageRelation.ImageAboveText
        ' 
        ' FrmClientManipulation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1140, 515)
        Controls.Add(SplitContainer1)
        Name = "FrmClientManipulation"
        StartPosition = FormStartPosition.CenterScreen
        Text = "FrmClientManipulation"
        SplitContainer1.Panel1.ResumeLayout(False)
        SplitContainer1.Panel2.ResumeLayout(False)
        SplitContainer1.Panel2.PerformLayout()
        CType(SplitContainer1, ComponentModel.ISupportInitialize).EndInit()
        SplitContainer1.ResumeLayout(False)
        CType(dgvclient, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents dgvclient As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Vertical_Panel As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Add As ToolStripButton
    Friend WithEvents Save As ToolStripButton
    Friend WithEvents Change As ToolStripButton
    Friend WithEvents Update As ToolStripButton
    Friend WithEvents Delete As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtTelephone As TextBox
    Friend WithEvents TxtNomClient As TextBox
    Friend WithEvents txtcodeClient As TextBox
    Friend WithEvents LblEmailClient As Label
    Friend WithEvents LblTelephoneClient As Label
    Friend WithEvents LblNomClient As Label
    Friend WithEvents LblCodeClient As Label
End Class
