<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtFASM = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtFAFM = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFAAC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFASG = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtCASM = New System.Windows.Forms.TextBox()
        Me.txtCAUW = New System.Windows.Forms.TextBox()
        Me.txtCAAC = New System.Windows.Forms.TextBox()
        Me.txtCASG = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCementSG = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtStrength = New System.Windows.Forms.TextBox()
        Me.txtSlump = New System.Windows.Forms.TextBox()
        Me.rdbNonAirEntrained = New System.Windows.Forms.RadioButton()
        Me.rdbAirEntrained = New System.Windows.Forms.RadioButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMSA = New System.Windows.Forms.ComboBox()
        Me.cmbExposure = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.picGraph = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtFAOutput = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCAOutput = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtWaterOutput = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCementOutput = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.rdbWeightPercent = New System.Windows.Forms.RadioButton()
        Me.rdbWeight = New System.Windows.Forms.RadioButton()
        Me.rdbVolumePercent = New System.Windows.Forms.RadioButton()
        Me.rdbVolume = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.picBarChart = New System.Windows.Forms.PictureBox()
        Me.picPieChart = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.picGraph, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.picBarChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPieChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(944, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(143, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(143, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(143, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(146, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.toolStripSeparator3, Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.toolStripSeparator4, Me.SelectAllToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.UndoToolStripMenuItem.Text = "&Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.RedoToolStripMenuItem.Text = "&Redo"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Image = CType(resources.GetObject("CutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CutToolStripMenuItem.Text = "Cu&t"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Image = CType(resources.GetObject("CopyToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.CopyToolStripMenuItem.Text = "&Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Image = CType(resources.GetObject("PasteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PasteToolStripMenuItem.Text = "&Paste"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SelectAllToolStripMenuItem.Text = "Select &All"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RadomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'RadomizeToolStripMenuItem
        '
        Me.RadomizeToolStripMenuItem.Name = "RadomizeToolStripMenuItem"
        Me.RadomizeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RadomizeToolStripMenuItem.Text = "&Randomize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(119, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 360
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.picPieChart)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.SplitContainer1.Panel2MinSize = 520
        Me.SplitContainer1.Size = New System.Drawing.Size(944, 657)
        Me.SplitContainer1.SplitterDistance = 420
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Panel1MinSize = 280
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer2.Panel2MinSize = 280
        Me.SplitContainer2.Size = New System.Drawing.Size(420, 657)
        Me.SplitContainer2.SplitterDistance = 338
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Panel2.Size = New System.Drawing.Size(420, 281)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtFASM)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtFAFM)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtFAAC)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtFASG)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 446)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(321, 160)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fine Aggregates Properties"
        '
        'txtFASM
        '
        Me.txtFASM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFASM.Location = New System.Drawing.Point(211, 118)
        Me.txtFASM.Name = "txtFASM"
        Me.txtFASM.Size = New System.Drawing.Size(104, 27)
        Me.txtFASM.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(86, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 19)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Fineness Modulus"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFAFM
        '
        Me.txtFAFM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFAFM.Location = New System.Drawing.Point(211, 85)
        Me.txtFAFM.Name = "txtFAFM"
        Me.txtFAFM.Size = New System.Drawing.Size(104, 27)
        Me.txtFAFM.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(104, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 19)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Specific Gravity"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFAAC
        '
        Me.txtFAAC.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFAAC.Location = New System.Drawing.Point(211, 52)
        Me.txtFAAC.Name = "txtFAAC"
        Me.txtFAAC.Size = New System.Drawing.Size(104, 27)
        Me.txtFAAC.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(72, 56)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 19)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Absorption Capacity"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFASG
        '
        Me.txtFASG.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFASG.Location = New System.Drawing.Point(211, 19)
        Me.txtFASG.Name = "txtFASG"
        Me.txtFASG.Size = New System.Drawing.Size(104, 27)
        Me.txtFASG.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(93, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 19)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Surface Moisture"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCASM)
        Me.GroupBox3.Controls.Add(Me.txtCAUW)
        Me.GroupBox3.Controls.Add(Me.txtCAAC)
        Me.GroupBox3.Controls.Add(Me.txtCASG)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(321, 160)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coarse Aggregates Properties"
        '
        'txtCASM
        '
        Me.txtCASM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCASM.Location = New System.Drawing.Point(211, 118)
        Me.txtCASM.Name = "txtCASM"
        Me.txtCASM.Size = New System.Drawing.Size(104, 27)
        Me.txtCASM.TabIndex = 3
        '
        'txtCAUW
        '
        Me.txtCAUW.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCAUW.Location = New System.Drawing.Point(211, 85)
        Me.txtCAUW.Name = "txtCAUW"
        Me.txtCAUW.Size = New System.Drawing.Size(104, 27)
        Me.txtCAUW.TabIndex = 2
        '
        'txtCAAC
        '
        Me.txtCAAC.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCAAC.Location = New System.Drawing.Point(211, 52)
        Me.txtCAAC.Name = "txtCAAC"
        Me.txtCAAC.Size = New System.Drawing.Size(104, 27)
        Me.txtCAAC.TabIndex = 1
        '
        'txtCASG
        '
        Me.txtCASG.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCASG.Location = New System.Drawing.Point(211, 19)
        Me.txtCASG.Name = "txtCASG"
        Me.txtCASG.Size = New System.Drawing.Size(104, 27)
        Me.txtCASG.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(93, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 19)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Surface Moisture"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(47, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 19)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Dry-rodded Unit Weight"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(72, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 19)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Absorption Capacity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(104, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Specific Gravity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCementSG)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 210)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 64)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cement Properties"
        '
        'txtCementSG
        '
        Me.txtCementSG.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCementSG.Location = New System.Drawing.Point(211, 19)
        Me.txtCementSG.Name = "txtCementSG"
        Me.txtCementSG.Size = New System.Drawing.Size(104, 27)
        Me.txtCementSG.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(104, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Specific Gravity"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtStrength)
        Me.GroupBox1.Controls.Add(Me.txtSlump)
        Me.GroupBox1.Controls.Add(Me.rdbNonAirEntrained)
        Me.GroupBox1.Controls.Add(Me.rdbAirEntrained)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMSA)
        Me.GroupBox1.Controls.Add(Me.cmbExposure)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 194)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'txtStrength
        '
        Me.txtStrength.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtStrength.Location = New System.Drawing.Point(211, 19)
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(104, 27)
        Me.txtStrength.TabIndex = 0
        '
        'txtSlump
        '
        Me.txtSlump.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSlump.Location = New System.Drawing.Point(211, 52)
        Me.txtSlump.Name = "txtSlump"
        Me.txtSlump.Size = New System.Drawing.Size(104, 27)
        Me.txtSlump.TabIndex = 1
        '
        'rdbNonAirEntrained
        '
        Me.rdbNonAirEntrained.AutoSize = True
        Me.rdbNonAirEntrained.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbNonAirEntrained.Location = New System.Drawing.Point(177, 153)
        Me.rdbNonAirEntrained.Name = "rdbNonAirEntrained"
        Me.rdbNonAirEntrained.Size = New System.Drawing.Size(138, 23)
        Me.rdbNonAirEntrained.TabIndex = 5
        Me.rdbNonAirEntrained.TabStop = True
        Me.rdbNonAirEntrained.Text = "Non-Air Entrained"
        Me.rdbNonAirEntrained.UseVisualStyleBackColor = True
        '
        'rdbAirEntrained
        '
        Me.rdbAirEntrained.AutoSize = True
        Me.rdbAirEntrained.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbAirEntrained.Location = New System.Drawing.Point(65, 153)
        Me.rdbAirEntrained.Name = "rdbAirEntrained"
        Me.rdbAirEntrained.Size = New System.Drawing.Size(106, 23)
        Me.rdbAirEntrained.TabIndex = 4
        Me.rdbAirEntrained.TabStop = True
        Me.rdbAirEntrained.Text = "Air Entrained"
        Me.rdbAirEntrained.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(52, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 19)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Max Aggregate Size (in)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Exposure"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(135, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Slump (in)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Compressive Strength (ksi)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbMSA
        '
        Me.cmbMSA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMSA.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbMSA.FormattingEnabled = True
        Me.cmbMSA.Items.AddRange(New Object() {"3/8", "1/2", "3/4", "1", "1-1/2", "2", "3", "6"})
        Me.cmbMSA.Location = New System.Drawing.Point(211, 119)
        Me.cmbMSA.Name = "cmbMSA"
        Me.cmbMSA.Size = New System.Drawing.Size(104, 28)
        Me.cmbMSA.TabIndex = 3
        '
        'cmbExposure
        '
        Me.cmbExposure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExposure.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbExposure.FormattingEnabled = True
        Me.cmbExposure.Items.AddRange(New Object() {"Mild", "Moderate", "Severe"})
        Me.cmbExposure.Location = New System.Drawing.Point(211, 85)
        Me.cmbExposure.Name = "cmbExposure"
        Me.cmbExposure.Size = New System.Drawing.Size(104, 28)
        Me.cmbExposure.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnCompute)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 281)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(420, 57)
        Me.Panel1.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(327, 18)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 28)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompute.Location = New System.Drawing.Point(239, 18)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(82, 28)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.picGraph)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(7, 7, 7, 7)
        Me.Panel4.Size = New System.Drawing.Size(420, 316)
        Me.Panel4.TabIndex = 1
        '
        'picGraph
        '
        Me.picGraph.BackColor = System.Drawing.Color.Black
        Me.picGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picGraph.Location = New System.Drawing.Point(7, 7)
        Me.picGraph.Name = "picGraph"
        Me.picGraph.Size = New System.Drawing.Size(406, 302)
        Me.picGraph.TabIndex = 0
        Me.picGraph.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.GroupBox5)
        Me.Panel6.Controls.Add(Me.rdbWeightPercent)
        Me.Panel6.Controls.Add(Me.rdbWeight)
        Me.Panel6.Controls.Add(Me.rdbVolumePercent)
        Me.Panel6.Controls.Add(Me.rdbVolume)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(7, 7)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel6.Size = New System.Drawing.Size(507, 196)
        Me.Panel6.TabIndex = 3
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtFAOutput)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.txtCAOutput)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.txtWaterOutput)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtCementOutput)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Location = New System.Drawing.Point(177, 11)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(319, 160)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concrete Mix Proportion"
        '
        'txtFAOutput
        '
        Me.txtFAOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFAOutput.Location = New System.Drawing.Point(187, 118)
        Me.txtFAOutput.Name = "txtFAOutput"
        Me.txtFAOutput.ReadOnly = True
        Me.txtFAOutput.Size = New System.Drawing.Size(126, 27)
        Me.txtFAOutput.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(10, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(171, 27)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Cement"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCAOutput
        '
        Me.txtCAOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCAOutput.Location = New System.Drawing.Point(187, 85)
        Me.txtCAOutput.Name = "txtCAOutput"
        Me.txtCAOutput.ReadOnly = True
        Me.txtCAOutput.Size = New System.Drawing.Size(126, 27)
        Me.txtCAOutput.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(10, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(171, 27)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Water"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterOutput
        '
        Me.txtWaterOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtWaterOutput.Location = New System.Drawing.Point(187, 52)
        Me.txtWaterOutput.Name = "txtWaterOutput"
        Me.txtWaterOutput.ReadOnly = True
        Me.txtWaterOutput.Size = New System.Drawing.Size(126, 27)
        Me.txtWaterOutput.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(6, 85)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(175, 27)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Coarse Aggregates"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCementOutput
        '
        Me.txtCementOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCementOutput.Location = New System.Drawing.Point(187, 19)
        Me.txtCementOutput.Name = "txtCementOutput"
        Me.txtCementOutput.ReadOnly = True
        Me.txtCementOutput.Size = New System.Drawing.Size(126, 27)
        Me.txtCementOutput.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(6, 118)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(175, 27)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Fine Aggregates"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdbWeightPercent
        '
        Me.rdbWeightPercent.AutoSize = True
        Me.rdbWeightPercent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbWeightPercent.Location = New System.Drawing.Point(11, 98)
        Me.rdbWeightPercent.Name = "rdbWeightPercent"
        Me.rdbWeightPercent.Size = New System.Drawing.Size(112, 23)
        Me.rdbWeightPercent.TabIndex = 3
        Me.rdbWeightPercent.TabStop = True
        Me.rdbWeightPercent.Text = "By Weight (%)"
        Me.rdbWeightPercent.UseVisualStyleBackColor = True
        '
        'rdbWeight
        '
        Me.rdbWeight.AutoSize = True
        Me.rdbWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbWeight.Location = New System.Drawing.Point(11, 69)
        Me.rdbWeight.Name = "rdbWeight"
        Me.rdbWeight.Size = New System.Drawing.Size(118, 23)
        Me.rdbWeight.TabIndex = 2
        Me.rdbWeight.TabStop = True
        Me.rdbWeight.Text = "By Weight (lbs)"
        Me.rdbWeight.UseVisualStyleBackColor = True
        '
        'rdbVolumePercent
        '
        Me.rdbVolumePercent.AutoSize = True
        Me.rdbVolumePercent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbVolumePercent.Location = New System.Drawing.Point(11, 40)
        Me.rdbVolumePercent.Name = "rdbVolumePercent"
        Me.rdbVolumePercent.Size = New System.Drawing.Size(115, 23)
        Me.rdbVolumePercent.TabIndex = 1
        Me.rdbVolumePercent.TabStop = True
        Me.rdbVolumePercent.Text = "By Volume (%)"
        Me.rdbVolumePercent.UseVisualStyleBackColor = True
        '
        'rdbVolume
        '
        Me.rdbVolume.AutoSize = True
        Me.rdbVolume.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbVolume.Location = New System.Drawing.Point(11, 11)
        Me.rdbVolume.Name = "rdbVolume"
        Me.rdbVolume.Size = New System.Drawing.Size(124, 23)
        Me.rdbVolume.TabIndex = 0
        Me.rdbVolume.TabStop = True
        Me.rdbVolume.Text = "By Volume (yd³)"
        Me.rdbVolume.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.picBarChart)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(7, 510)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(507, 140)
        Me.Panel5.TabIndex = 2
        '
        'picBarChart
        '
        Me.picBarChart.BackColor = System.Drawing.Color.Black
        Me.picBarChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBarChart.Location = New System.Drawing.Point(0, 0)
        Me.picBarChart.Name = "picBarChart"
        Me.picBarChart.Size = New System.Drawing.Size(507, 140)
        Me.picBarChart.TabIndex = 1
        Me.picBarChart.TabStop = False
        '
        'picPieChart
        '
        Me.picPieChart.BackColor = System.Drawing.Color.Black
        Me.picPieChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picPieChart.Location = New System.Drawing.Point(7, 7)
        Me.picPieChart.Name = "picPieChart"
        Me.picPieChart.Size = New System.Drawing.Size(507, 643)
        Me.picPieChart.TabIndex = 1
        Me.picPieChart.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 681)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(960, 720)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concrete Mix Designer"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.picGraph, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.picBarChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPieChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCompute As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents picGraph As PictureBox
    Friend WithEvents txtCASG As TextBox
    Friend WithEvents txtCementSG As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbExposure As ComboBox
    Friend WithEvents rdbNonAirEntrained As RadioButton
    Friend WithEvents rdbAirEntrained As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFASM As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtFAFM As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFAAC As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFASG As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCASM As TextBox
    Friend WithEvents txtCAUW As TextBox
    Friend WithEvents txtCAAC As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtFAOutput As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCAOutput As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtWaterOutput As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtCementOutput As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents picBarChart As PictureBox
    Friend WithEvents picPieChart As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents rdbVolumePercent As RadioButton
    Friend WithEvents rdbVolume As RadioButton
    Friend WithEvents rdbWeightPercent As RadioButton
    Friend WithEvents rdbWeight As RadioButton
    Friend WithEvents txtStrength As TextBox
    Friend WithEvents txtSlump As TextBox
    Friend WithEvents cmbMSA As ComboBox
    Friend WithEvents Label17 As Label
End Class
