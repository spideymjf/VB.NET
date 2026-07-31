Public Class FrmContainer

    Private WithEvents SplitMain As SplitContainer
    Private WithEvents SplitRight As SplitContainer
    Private WithEvents ToolBarTop As ToolStrip
    Private WithEvents TabsTop As TabControl

    Private Sub FrmContainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Split Container"
        Me.WindowState = FormWindowState.Maximized

        SplitMain = New SplitContainer()
        SplitMain.Dock = DockStyle.Fill
        SplitMain.Orientation = Orientation.Vertical
        SplitMain.BorderStyle = BorderStyle.Fixed3D
        SplitMain.SplitterWidth = 6
        Me.Controls.Add(SplitMain)

        SplitMain.FixedPanel = FixedPanel.Panel1
        SplitMain.Panel1MinSize = 150
        SplitMain.SplitterDistance = 400
        SplitMain.Panel1.BackColor = Color.LightSkyBlue

        SplitRight = New SplitContainer()
        SplitRight.Dock = DockStyle.Fill
        SplitRight.Orientation = Orientation.Horizontal
        SplitRight.BorderStyle = BorderStyle.FixedSingle
        SplitRight.SplitterWidth = 4
        SplitMain.Panel2.Controls.Add(SplitRight)
        SplitMain.Panel2.BackColor = Color.White

        SplitRight.SplitterDistance = 600
        SplitRight.Panel2.BackColor = Color.LightGreen

        ToolBarTop = New ToolStrip()
        ToolBarTop.Dock = DockStyle.Top

        Dim btnPanelVertical As New ToolStripButton("Panel Vertical")
        btnPanelVertical.CheckOnClick = True
        btnPanelVertical.Image = Image.FromFile("C:\Users\Admin\Pictures\vertical.png")
        btnPanelVertical.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        AddHandler btnPanelVertical.Click, AddressOf BtnPanelVertical_Click

        Dim btnPanelHorizontal As New ToolStripButton("Panel Horizontal")
        btnPanelHorizontal.CheckOnClick = True
        btnPanelHorizontal.Image = Image.FromFile("C:\Users\Admin\Pictures\horizontal.jpg")
        btnPanelHorizontal.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        AddHandler btnPanelHorizontal.Click, AddressOf BtnPanelHorizontal_Click

        ToolBarTop.Items.Add(btnPanelVertical)
        ToolBarTop.Items.Add(btnPanelHorizontal)

        TabsTop = New TabControl()
        TabsTop.Dock = DockStyle.Fill

        Dim tabPage1 As New TabPage("Tab 1")
        Dim tabPage2 As New TabPage("Tab 2")
        tabPage1.BackColor = Color.White
        tabPage2.BackColor = Color.Aquamarine

        Dim lblTab1 As New Label()
        lblTab1.Text = "This is Tab 1"
        lblTab1.AutoSize = True
        lblTab1.Location = New Point(10, 10)
        tabPage1.Controls.Add(lblTab1)

        Dim lblTab2 As New Label()
        lblTab2.Text = "This is Tab 2"
        lblTab2.AutoSize = True
        lblTab2.Location = New Point(50, 50)
        tabPage2.Controls.Add(lblTab2)

        TabsTop.TabPages.Add(tabPage1)
        TabsTop.TabPages.Add(tabPage2)

        SplitRight.Panel1.Controls.Add(TabsTop)
        SplitRight.Panel1.Controls.Add(ToolBarTop)
        SplitRight.Panel1.BackColor = Color.LightYellow

    End Sub

    Private Sub BtnPanelVertical_Click(sender As Object, e As EventArgs)
        SplitMain.Panel1Collapsed = Not SplitMain.Panel1Collapsed
    End Sub

    Private Sub BtnPanelHorizontal_Click(sender As Object, e As EventArgs)
        SplitRight.Panel2Collapsed = Not SplitRight.Panel2Collapsed
    End Sub

End Class