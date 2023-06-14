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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RadomizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReferenceTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.lblExposure = New System.Windows.Forms.Label()
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
        Me.AciDatabaseDataSet = New Concrete_Mix_Designer.ACIDatabaseDataSet()
        Me.TableAdapterManager = New Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.AirContentForAirEntrainedTableAdapter = New Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.AirContentForAirEntrainedTableAdapter()
        Me.AirContentForNonAirEntrainedTableAdapter = New Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.AirContentForNonAirEntrainedTableAdapter()
        Me.WaterCementRatioTableAdapter = New Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.WaterCementRatioTableAdapter()
        Me.WaterContentForAirEntrainedTableAdapter = New Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.WaterContentForAirEntrainedTableAdapter()
        Me.WaterContentForNonAirEntrainedTableAdapter = New Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.WaterContentForNonAirEntrainedTableAdapter()
        Me.MenuStrip.SuspendLayout()
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
        CType(Me.AciDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(1259, 28)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem, Me.toolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.NewToolStripMenuItem.Text = "&New"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(178, 6)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = CType(resources.GetObject("SaveToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save &As"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(178, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RadomizeToolStripMenuItem, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(58, 24)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'RadomizeToolStripMenuItem
        '
        Me.RadomizeToolStripMenuItem.Name = "RadomizeToolStripMenuItem"
        Me.RadomizeToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.RadomizeToolStripMenuItem.Text = "&Randomize"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(167, 26)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReferenceTablesToolStripMenuItem, Me.toolStripSeparator5, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ReferenceTablesToolStripMenuItem
        '
        Me.ReferenceTablesToolStripMenuItem.Name = "ReferenceTablesToolStripMenuItem"
        Me.ReferenceTablesToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.ReferenceTablesToolStripMenuItem.Text = "&Reference Tables"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(200, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(203, 26)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 28)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
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
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.SplitContainer1.Panel2MinSize = 520
        Me.SplitContainer1.Size = New System.Drawing.Size(1259, 810)
        Me.SplitContainer1.SplitterDistance = 560
        Me.SplitContainer1.TabIndex = 0
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(560, 810)
        Me.SplitContainer2.SplitterDistance = 416
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
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel2.Size = New System.Drawing.Size(560, 346)
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
        Me.GroupBox4.Location = New System.Drawing.Point(16, 549)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(428, 197)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Fine Aggregates Properties"
        '
        'txtFASM
        '
        Me.txtFASM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFASM.Location = New System.Drawing.Point(281, 145)
        Me.txtFASM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFASM.Name = "txtFASM"
        Me.txtFASM.Size = New System.Drawing.Size(137, 32)
        Me.txtFASM.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(115, 110)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 23)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Fineness Modulus"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFAFM
        '
        Me.txtFAFM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFAFM.Location = New System.Drawing.Point(281, 105)
        Me.txtFAFM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFAFM.Name = "txtFAFM"
        Me.txtFAFM.Size = New System.Drawing.Size(137, 32)
        Me.txtFAFM.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(139, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(125, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Specific Gravity"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFAAC
        '
        Me.txtFAAC.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFAAC.Location = New System.Drawing.Point(281, 64)
        Me.txtFAAC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFAAC.Name = "txtFAAC"
        Me.txtFAAC.Size = New System.Drawing.Size(137, 32)
        Me.txtFAAC.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label10.Location = New System.Drawing.Point(96, 69)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(164, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Absorption Capacity"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFASG
        '
        Me.txtFASG.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFASG.Location = New System.Drawing.Point(281, 23)
        Me.txtFASG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFASG.Name = "txtFASG"
        Me.txtFASG.Size = New System.Drawing.Size(137, 32)
        Me.txtFASG.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(124, 150)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 23)
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
        Me.GroupBox3.Location = New System.Drawing.Point(16, 345)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(428, 197)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Coarse Aggregates Properties"
        '
        'txtCASM
        '
        Me.txtCASM.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCASM.Location = New System.Drawing.Point(281, 145)
        Me.txtCASM.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCASM.Name = "txtCASM"
        Me.txtCASM.Size = New System.Drawing.Size(137, 32)
        Me.txtCASM.TabIndex = 3
        '
        'txtCAUW
        '
        Me.txtCAUW.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCAUW.Location = New System.Drawing.Point(281, 105)
        Me.txtCAUW.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCAUW.Name = "txtCAUW"
        Me.txtCAUW.Size = New System.Drawing.Size(137, 32)
        Me.txtCAUW.TabIndex = 2
        '
        'txtCAAC
        '
        Me.txtCAAC.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCAAC.Location = New System.Drawing.Point(281, 64)
        Me.txtCAAC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCAAC.Name = "txtCAAC"
        Me.txtCAAC.Size = New System.Drawing.Size(137, 32)
        Me.txtCAAC.TabIndex = 1
        '
        'txtCASG
        '
        Me.txtCASG.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCASG.Location = New System.Drawing.Point(281, 23)
        Me.txtCASG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCASG.Name = "txtCASG"
        Me.txtCASG.Size = New System.Drawing.Size(137, 32)
        Me.txtCASG.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(124, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Surface Moisture"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(63, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(194, 23)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Dry-rodded Unit Weight"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(96, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(164, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Absorption Capacity"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(139, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Specific Gravity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCementSG)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 258)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(428, 79)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cement Properties"
        '
        'txtCementSG
        '
        Me.txtCementSG.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCementSG.Location = New System.Drawing.Point(281, 23)
        Me.txtCementSG.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCementSG.Name = "txtCementSG"
        Me.txtCementSG.Size = New System.Drawing.Size(137, 32)
        Me.txtCementSG.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(139, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 23)
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
        Me.GroupBox1.Controls.Add(Me.lblExposure)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbMSA)
        Me.GroupBox1.Controls.Add(Me.cmbExposure)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(428, 239)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'txtStrength
        '
        Me.txtStrength.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtStrength.Location = New System.Drawing.Point(283, 23)
        Me.txtStrength.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStrength.Name = "txtStrength"
        Me.txtStrength.Size = New System.Drawing.Size(137, 32)
        Me.txtStrength.TabIndex = 0
        '
        'txtSlump
        '
        Me.txtSlump.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtSlump.Location = New System.Drawing.Point(283, 63)
        Me.txtSlump.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSlump.Name = "txtSlump"
        Me.txtSlump.Size = New System.Drawing.Size(137, 32)
        Me.txtSlump.TabIndex = 1
        '
        'rdbNonAirEntrained
        '
        Me.rdbNonAirEntrained.AutoSize = True
        Me.rdbNonAirEntrained.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbNonAirEntrained.Location = New System.Drawing.Point(250, 144)
        Me.rdbNonAirEntrained.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbNonAirEntrained.Name = "rdbNonAirEntrained"
        Me.rdbNonAirEntrained.Size = New System.Drawing.Size(170, 27)
        Me.rdbNonAirEntrained.TabIndex = 5
        Me.rdbNonAirEntrained.TabStop = True
        Me.rdbNonAirEntrained.Text = "Non-Air Entrained"
        Me.rdbNonAirEntrained.UseVisualStyleBackColor = True
        '
        'rdbAirEntrained
        '
        Me.rdbAirEntrained.AutoSize = True
        Me.rdbAirEntrained.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbAirEntrained.Location = New System.Drawing.Point(112, 144)
        Me.rdbAirEntrained.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbAirEntrained.Name = "rdbAirEntrained"
        Me.rdbAirEntrained.Size = New System.Drawing.Size(130, 27)
        Me.rdbAirEntrained.TabIndex = 4
        Me.rdbAirEntrained.TabStop = True
        Me.rdbAirEntrained.Text = "Air Entrained"
        Me.rdbAirEntrained.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(84, 108)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(191, 23)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Max Aggregate Size (in)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblExposure
        '
        Me.lblExposure.AutoSize = True
        Me.lblExposure.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lblExposure.Location = New System.Drawing.Point(196, 184)
        Me.lblExposure.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblExposure.Name = "lblExposure"
        Me.lblExposure.Size = New System.Drawing.Size(79, 23)
        Me.lblExposure.TabIndex = 1
        Me.lblExposure.Text = "Exposure"
        Me.lblExposure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(188, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Slump (in)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(65, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 23)
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
        Me.cmbMSA.Location = New System.Drawing.Point(283, 103)
        Me.cmbMSA.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMSA.Name = "cmbMSA"
        Me.cmbMSA.Size = New System.Drawing.Size(137, 33)
        Me.cmbMSA.TabIndex = 3
        '
        'cmbExposure
        '
        Me.cmbExposure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbExposure.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cmbExposure.FormattingEnabled = True
        Me.cmbExposure.Items.AddRange(New Object() {"Mild", "Moderate", "Severe"})
        Me.cmbExposure.Location = New System.Drawing.Point(283, 179)
        Me.cmbExposure.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbExposure.Name = "cmbExposure"
        Me.cmbExposure.Size = New System.Drawing.Size(137, 33)
        Me.cmbExposure.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnReset)
        Me.Panel1.Controls.Add(Me.btnCompute)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 346)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(560, 70)
        Me.Panel1.TabIndex = 1
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(141, 24)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(109, 34)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(24, 24)
        Me.btnCompute.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(109, 34)
        Me.btnCompute.TabIndex = 0
        Me.btnCompute.Text = "&Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.picGraph)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(9)
        Me.Panel4.Size = New System.Drawing.Size(560, 390)
        Me.Panel4.TabIndex = 1
        '
        'picGraph
        '
        Me.picGraph.BackColor = System.Drawing.Color.Transparent
        Me.picGraph.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picGraph.Location = New System.Drawing.Point(9, 9)
        Me.picGraph.Margin = New System.Windows.Forms.Padding(4)
        Me.picGraph.Name = "picGraph"
        Me.picGraph.Size = New System.Drawing.Size(542, 372)
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
        Me.Panel6.Location = New System.Drawing.Point(9, 9)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.Panel6.Size = New System.Drawing.Size(677, 241)
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
        Me.GroupBox5.Location = New System.Drawing.Point(236, 14)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(426, 197)
        Me.GroupBox5.TabIndex = 4
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Concrete Mix Proportion"
        '
        'txtFAOutput
        '
        Me.txtFAOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtFAOutput.Location = New System.Drawing.Point(249, 145)
        Me.txtFAOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFAOutput.Name = "txtFAOutput"
        Me.txtFAOutput.ReadOnly = True
        Me.txtFAOutput.Size = New System.Drawing.Size(167, 32)
        Me.txtFAOutput.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(13, 23)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(228, 33)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Cement"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCAOutput
        '
        Me.txtCAOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCAOutput.Location = New System.Drawing.Point(249, 105)
        Me.txtCAOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCAOutput.Name = "txtCAOutput"
        Me.txtCAOutput.ReadOnly = True
        Me.txtCAOutput.Size = New System.Drawing.Size(167, 32)
        Me.txtCAOutput.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label14.Location = New System.Drawing.Point(13, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(228, 33)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Water"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtWaterOutput
        '
        Me.txtWaterOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtWaterOutput.Location = New System.Drawing.Point(249, 64)
        Me.txtWaterOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWaterOutput.Name = "txtWaterOutput"
        Me.txtWaterOutput.ReadOnly = True
        Me.txtWaterOutput.Size = New System.Drawing.Size(167, 32)
        Me.txtWaterOutput.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label15.Location = New System.Drawing.Point(8, 105)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(233, 33)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Coarse Aggregates"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCementOutput
        '
        Me.txtCementOutput.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txtCementOutput.Location = New System.Drawing.Point(249, 23)
        Me.txtCementOutput.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCementOutput.Name = "txtCementOutput"
        Me.txtCementOutput.ReadOnly = True
        Me.txtCementOutput.Size = New System.Drawing.Size(167, 32)
        Me.txtCementOutput.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(8, 145)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(233, 33)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Fine Aggregates"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdbWeightPercent
        '
        Me.rdbWeightPercent.AutoSize = True
        Me.rdbWeightPercent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbWeightPercent.Location = New System.Drawing.Point(15, 121)
        Me.rdbWeightPercent.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbWeightPercent.Name = "rdbWeightPercent"
        Me.rdbWeightPercent.Size = New System.Drawing.Size(137, 27)
        Me.rdbWeightPercent.TabIndex = 3
        Me.rdbWeightPercent.TabStop = True
        Me.rdbWeightPercent.Text = "By Weight (%)"
        Me.rdbWeightPercent.UseVisualStyleBackColor = True
        '
        'rdbWeight
        '
        Me.rdbWeight.AutoSize = True
        Me.rdbWeight.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbWeight.Location = New System.Drawing.Point(15, 85)
        Me.rdbWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbWeight.Name = "rdbWeight"
        Me.rdbWeight.Size = New System.Drawing.Size(144, 27)
        Me.rdbWeight.TabIndex = 2
        Me.rdbWeight.TabStop = True
        Me.rdbWeight.Text = "By Weight (lbs)"
        Me.rdbWeight.UseVisualStyleBackColor = True
        '
        'rdbVolumePercent
        '
        Me.rdbVolumePercent.AutoSize = True
        Me.rdbVolumePercent.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbVolumePercent.Location = New System.Drawing.Point(15, 49)
        Me.rdbVolumePercent.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbVolumePercent.Name = "rdbVolumePercent"
        Me.rdbVolumePercent.Size = New System.Drawing.Size(141, 27)
        Me.rdbVolumePercent.TabIndex = 1
        Me.rdbVolumePercent.TabStop = True
        Me.rdbVolumePercent.Text = "By Volume (%)"
        Me.rdbVolumePercent.UseVisualStyleBackColor = True
        '
        'rdbVolume
        '
        Me.rdbVolume.AutoSize = True
        Me.rdbVolume.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rdbVolume.Location = New System.Drawing.Point(15, 14)
        Me.rdbVolume.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbVolume.Name = "rdbVolume"
        Me.rdbVolume.Size = New System.Drawing.Size(151, 27)
        Me.rdbVolume.TabIndex = 0
        Me.rdbVolume.TabStop = True
        Me.rdbVolume.Text = "By Volume (yd³)"
        Me.rdbVolume.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.picBarChart)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(9, 629)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(677, 172)
        Me.Panel5.TabIndex = 2
        '
        'picBarChart
        '
        Me.picBarChart.BackColor = System.Drawing.Color.Transparent
        Me.picBarChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBarChart.Location = New System.Drawing.Point(0, 0)
        Me.picBarChart.Margin = New System.Windows.Forms.Padding(4)
        Me.picBarChart.Name = "picBarChart"
        Me.picBarChart.Size = New System.Drawing.Size(677, 172)
        Me.picBarChart.TabIndex = 1
        Me.picBarChart.TabStop = False
        '
        'picPieChart
        '
        Me.picPieChart.BackColor = System.Drawing.Color.Transparent
        Me.picPieChart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picPieChart.Location = New System.Drawing.Point(9, 9)
        Me.picPieChart.Margin = New System.Windows.Forms.Padding(4)
        Me.picPieChart.Name = "picPieChart"
        Me.picPieChart.Size = New System.Drawing.Size(677, 792)
        Me.picPieChart.TabIndex = 1
        Me.picPieChart.TabStop = False
        '
        'AciDatabaseDataSet
        '
        Me.AciDatabaseDataSet.DataSetName = "ACIDatabaseDataSet"
        Me.AciDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AirContentForAirEntrainedTableAdapter = Me.AirContentForAirEntrainedTableAdapter
        Me.TableAdapterManager.AirContentForNonAirEntrainedTableAdapter = Me.AirContentForNonAirEntrainedTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Concrete_Mix_Designer.ACIDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaterCementRatioTableAdapter = Me.WaterCementRatioTableAdapter
        Me.TableAdapterManager.WaterContentForAirEntrainedTableAdapter = Me.WaterContentForAirEntrainedTableAdapter
        Me.TableAdapterManager.WaterContentForNonAirEntrainedTableAdapter = Me.WaterContentForNonAirEntrainedTableAdapter
        '
        'AirContentForAirEntrainedTableAdapter
        '
        Me.AirContentForAirEntrainedTableAdapter.ClearBeforeFill = True
        '
        'AirContentForNonAirEntrainedTableAdapter
        '
        Me.AirContentForNonAirEntrainedTableAdapter.ClearBeforeFill = True
        '
        'WaterCementRatioTableAdapter
        '
        Me.WaterCementRatioTableAdapter.ClearBeforeFill = True
        '
        'WaterContentForAirEntrainedTableAdapter
        '
        Me.WaterContentForAirEntrainedTableAdapter.ClearBeforeFill = True
        '
        'WaterContentForNonAirEntrainedTableAdapter
        '
        Me.WaterContentForNonAirEntrainedTableAdapter.ClearBeforeFill = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 838)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1274, 875)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Concrete Mix Designer"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
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
        CType(Me.AciDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator As ToolStripSeparator
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RadomizeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReferenceTablesToolStripMenuItem As ToolStripMenuItem
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
    Friend WithEvents lblExposure As Label
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
    Friend WithEvents AciDatabaseDataSet As ACIDatabaseDataSet
    Friend WithEvents TableAdapterManager As ACIDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AirContentForAirEntrainedTableAdapter As ACIDatabaseDataSetTableAdapters.AirContentForAirEntrainedTableAdapter
    Friend WithEvents AirContentForNonAirEntrainedTableAdapter As ACIDatabaseDataSetTableAdapters.AirContentForNonAirEntrainedTableAdapter
    Friend WithEvents WaterCementRatioTableAdapter As ACIDatabaseDataSetTableAdapters.WaterCementRatioTableAdapter
    Friend WithEvents WaterContentForAirEntrainedTableAdapter As ACIDatabaseDataSetTableAdapters.WaterContentForAirEntrainedTableAdapter
    Friend WithEvents WaterContentForNonAirEntrainedTableAdapter As ACIDatabaseDataSetTableAdapters.WaterContentForNonAirEntrainedTableAdapter
End Class
