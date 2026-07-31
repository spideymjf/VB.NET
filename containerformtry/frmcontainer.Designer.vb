<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcontainer
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmContainer))
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        SplitMain = New SplitContainer()
        dgvDataClient = New DataGridView()
        Code_Client = New DataGridViewTextBoxColumn()
        Nom_Client = New DataGridViewTextBoxColumn()
        SplitRight = New SplitContainer()
        dgvFacture = New DataGridView()
        ToolStrip1 = New ToolStrip()
        BtnPanelVertical = New ToolStripButton()
        BtnPanelHorizontal = New ToolStripButton()
        dgvdetailfacture = New DataGridView()
        CType(SplitMain, ComponentModel.ISupportInitialize).BeginInit()
        SplitMain.Panel1.SuspendLayout()
        SplitMain.Panel2.SuspendLayout()
        SplitMain.SuspendLayout()
        CType(dgvDataClient, ComponentModel.ISupportInitialize).BeginInit()
        CType(SplitRight, ComponentModel.ISupportInitialize).BeginInit()
        SplitRight.Panel1.SuspendLayout()
        SplitRight.Panel2.SuspendLayout()
        SplitRight.SuspendLayout()
        CType(dgvFacture, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        CType(dgvdetailfacture, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' SplitMain
        ' 
        SplitMain.BorderStyle = BorderStyle.Fixed3D
        SplitMain.Dock = DockStyle.Fill
        SplitMain.Location = New Point(0, 0)
        SplitMain.Name = "SplitMain"
        ' 
        ' SplitMain.Panel1
        ' 
        SplitMain.Panel1.BackColor = Color.LightSkyBlue
        SplitMain.Panel1.Controls.Add(dgvDataClient)
        ' 
        ' SplitMain.Panel2
        ' 
        SplitMain.Panel2.BackColor = Color.WhiteSmoke
        SplitMain.Panel2.Controls.Add(SplitRight)
        SplitMain.Size = New Size(1261, 672)
        SplitMain.SplitterDistance = 388
        SplitMain.TabIndex = 0
        ' 
        ' dgvDataClient
        ' 
        dgvDataClient.AllowUserToAddRows = False
        dgvDataClient.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvDataClient.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        dgvDataClient.BackgroundColor = SystemColors.Window
        dgvDataClient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvDataClient.Columns.AddRange(New DataGridViewColumn() {Code_Client, Nom_Client})
        dgvDataClient.Dock = DockStyle.Fill
        dgvDataClient.GridColor = SystemColors.Info
        dgvDataClient.Location = New Point(0, 0)
        dgvDataClient.Name = "dgvDataClient"
        dgvDataClient.ReadOnly = True
        dgvDataClient.Size = New Size(384, 668)
        dgvDataClient.TabIndex = 0
        ' 
        ' Code_Client
        ' 
        Code_Client.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        Code_Client.DataPropertyName = "Code_Client"
        Code_Client.HeaderText = "Code Client"
        Code_Client.Name = "Code_Client"
        Code_Client.ReadOnly = True
        Code_Client.Width = 94
        ' 
        ' Nom_Client
        ' 
        Nom_Client.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Nom_Client.DataPropertyName = "Nom_Client"
        Nom_Client.HeaderText = "Nom Client"
        Nom_Client.Name = "Nom_Client"
        Nom_Client.ReadOnly = True
        ' 
        ' SplitRight
        ' 
        SplitRight.BorderStyle = BorderStyle.FixedSingle
        SplitRight.Dock = DockStyle.Fill
        SplitRight.Location = New Point(0, 0)
        SplitRight.Name = "SplitRight"
        SplitRight.Orientation = Orientation.Horizontal
        ' 
        ' SplitRight.Panel1
        ' 
        SplitRight.Panel1.Controls.Add(dgvFacture)
        SplitRight.Panel1.Controls.Add(ToolStrip1)
        ' 
        ' SplitRight.Panel2
        ' 
        SplitRight.Panel2.BackColor = Color.LightGreen
        SplitRight.Panel2.Controls.Add(dgvdetailfacture)
        SplitRight.Size = New Size(865, 668)
        SplitRight.SplitterDistance = 400
        SplitRight.TabIndex = 0
        ' 
        ' dgvFacture
        ' 
        dgvFacture.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        dgvFacture.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        dgvFacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.Format = "N3"
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        dgvFacture.DefaultCellStyle = DataGridViewCellStyle1
        dgvFacture.Dock = DockStyle.Fill
        dgvFacture.Location = New Point(0, 25)
        dgvFacture.Name = "dgvFacture"
        dgvFacture.Size = New Size(863, 373)
        dgvFacture.TabIndex = 1
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {BtnPanelVertical, BtnPanelHorizontal})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(863, 25)
        ToolStrip1.TabIndex = 0
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' BtnPanelVertical
        ' 
        BtnPanelVertical.CheckOnClick = True
        BtnPanelVertical.DisplayStyle = ToolStripItemDisplayStyle.Image
        BtnPanelVertical.Image = CType(resources.GetObject("BtnPanelVertical.Image"), Image)
        BtnPanelVertical.ImageTransparentColor = Color.Magenta
        BtnPanelVertical.Name = "BtnPanelVertical"
        BtnPanelVertical.Size = New Size(23, 22)
        BtnPanelVertical.Text = "Panel Vertical"
        ' 
        ' BtnPanelHorizontal
        ' 
        BtnPanelHorizontal.CheckOnClick = True
        BtnPanelHorizontal.DisplayStyle = ToolStripItemDisplayStyle.Image
        BtnPanelHorizontal.Image = CType(resources.GetObject("BtnPanelHorizontal.Image"), Image)
        BtnPanelHorizontal.ImageTransparentColor = Color.Magenta
        BtnPanelHorizontal.Name = "BtnPanelHorizontal"
        BtnPanelHorizontal.Size = New Size(23, 22)
        BtnPanelHorizontal.Text = "Panel Horizontal"
        ' 
        ' dgvdetailfacture
        ' 
        dgvdetailfacture.AllowUserToAddRows = False
        dgvdetailfacture.AllowUserToDeleteRows = False
        dgvdetailfacture.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        dgvdetailfacture.DefaultCellStyle = DataGridViewCellStyle2
        dgvdetailfacture.Dock = DockStyle.Fill
        dgvdetailfacture.Location = New Point(0, 0)
        dgvdetailfacture.Name = "dgvdetailfacture"
        dgvdetailfacture.Size = New Size(863, 262)
        dgvdetailfacture.TabIndex = 0
        ' 
        ' FrmContainer
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1261, 672)
        Controls.Add(SplitMain)
        Name = "FrmContainer"
        Text = "Form1"
        SplitMain.Panel1.ResumeLayout(False)
        SplitMain.Panel2.ResumeLayout(False)
        CType(SplitMain, ComponentModel.ISupportInitialize).EndInit()
        SplitMain.ResumeLayout(False)
        CType(dgvDataClient, ComponentModel.ISupportInitialize).EndInit()
        SplitRight.Panel1.ResumeLayout(False)
        SplitRight.Panel1.PerformLayout()
        SplitRight.Panel2.ResumeLayout(False)
        CType(SplitRight, ComponentModel.ISupportInitialize).EndInit()
        SplitRight.ResumeLayout(False)
        CType(dgvFacture, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(dgvdetailfacture, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitMain As SplitContainer
    Friend WithEvents SplitRight As SplitContainer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnPanelVertical As ToolStripButton
    Friend WithEvents BtnPanelHorizontal As ToolStripButton
    Friend WithEvents dgvDataClient As DataGridView
    Friend WithEvents Code_Client As DataGridViewTextBoxColumn
    Friend WithEvents Nom_Client As DataGridViewTextBoxColumn
    Friend WithEvents dgvdetailfacture As DataGridView
    Friend WithEvents dgvFacture As DataGridView

End Class
