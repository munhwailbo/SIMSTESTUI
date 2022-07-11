Namespace ubiLease.UI.MainUi

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
        Partial Class frmMainUi
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer
        'Public CommonSaveDialog = New System.Windows.Forms.SaveFileDialog

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainUi))
            Me.mnuSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuExportDataToPrinter = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuExportDataToExcel = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuDeleteData = New System.Windows.Forms.ToolStripMenuItem()
            Me.tlbMain = New System.Windows.Forms.ToolStrip()
            Me.btnRequestData = New System.Windows.Forms.ToolStripButton()
            Me.btnNewData = New System.Windows.Forms.ToolStripButton()
            Me.btnSaveData = New System.Windows.Forms.ToolStripButton()
            Me.btnDeleteData = New System.Windows.Forms.ToolStripButton()
            Me.btnSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnExportDataToExcel = New System.Windows.Forms.ToolStripButton()
            Me.btnExportDataToPreview = New System.Windows.Forms.ToolStripButton()
            Me.btnExportDataToPrinter = New System.Windows.Forms.ToolStripButton()
            Me.btnSeparator2 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnExit = New System.Windows.Forms.ToolStripButton()
            Me.btnSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnHelp = New System.Windows.Forms.ToolStripButton()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.btnNotepad = New System.Windows.Forms.ToolStripButton()
            Me.btnCalc = New System.Windows.Forms.ToolStripButton()
            Me.splMain = New System.Windows.Forms.Splitter()
            Me.pnlLeft = New System.Windows.Forms.Panel()
            Me.pnlLeftBottom = New System.Windows.Forms.Panel()
            Me.trvLeftBottom = New System.Windows.Forms.TreeView()
            Me.imgListMain = New System.Windows.Forms.ImageList()
            Me.lblWorkFlow = New System.Windows.Forms.Label()
            Me.splLeft = New System.Windows.Forms.Splitter()
            Me.pnlLeftTop = New System.Windows.Forms.Panel()
            Me.lblLetTopLabel = New System.Windows.Forms.Label()
            Me.trvMain = New System.Windows.Forms.TreeView()
            Me.btnCTI_Logout = New ubiLease.CommonControls.btn()
            Me.btnCTIShow = New ubiLease.CommonControls.btn()
            Me.sttMain = New System.Windows.Forms.StatusStrip()
            Me.lblStatus1 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus2 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblRequestData = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus3 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblCreateData = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus4 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblUpdateData = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus5 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblDeleteData = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus8 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblMessage = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus6 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblLoginTime = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblStatus7 = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblCurrentTime = New System.Windows.Forms.ToolStripStatusLabel()
            Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
            Me.mnuNewData = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSaveData = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuRequestData = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuMain = New System.Windows.Forms.MenuStrip()
            Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuExportDataToPreview = New System.Windows.Forms.ToolStripMenuItem()
            Me.mnuSeparator3 = New System.Windows.Forms.ToolStripSeparator()
            Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
            Me.pnlTop = New System.Windows.Forms.Panel()
            Me.picAllClose = New System.Windows.Forms.PictureBox()
            Me.picOpenedProgram = New System.Windows.Forms.PictureBox()
            Me.pnlTopLeft = New System.Windows.Forms.Panel()
            Me.picLine = New System.Windows.Forms.PictureBox()
            Me.picTopLeft = New System.Windows.Forms.PictureBox()
            Me.picClose = New System.Windows.Forms.PictureBox()
            Me.pnlRight = New System.Windows.Forms.Panel()
            Me.lblLogin = New System.Windows.Forms.Label()
            Me.imgListSub = New System.Windows.Forms.ImageList()
            Me.cntMnuMain = New System.Windows.Forms.ContextMenuStrip()
            Me.tmrMain = New System.Windows.Forms.Timer()
            Me.CommonSaveDialog = New System.Windows.Forms.SaveFileDialog()
            Me.tlbMain.SuspendLayout()
            Me.pnlLeft.SuspendLayout()
            Me.pnlLeftBottom.SuspendLayout()
            Me.pnlLeftTop.SuspendLayout()
            Me.sttMain.SuspendLayout()
            Me.mnuMain.SuspendLayout()
            Me.pnlTop.SuspendLayout()
            CType(Me.picAllClose, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picOpenedProgram, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlTopLeft.SuspendLayout()
            CType(Me.picLine, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picClose, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'mnuSeparator2
            '
            Me.mnuSeparator2.Name = "mnuSeparator2"
            Me.mnuSeparator2.Size = New System.Drawing.Size(194, 6)
            '
            'mnuExportDataToPrinter
            '
            Me.mnuExportDataToPrinter.Name = "mnuExportDataToPrinter"
            Me.mnuExportDataToPrinter.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
            Me.mnuExportDataToPrinter.Size = New System.Drawing.Size(197, 22)
            Me.mnuExportDataToPrinter.Text = "인쇄"
            '
            'mnuExportDataToExcel
            '
            Me.mnuExportDataToExcel.Name = "mnuExportDataToExcel"
            Me.mnuExportDataToExcel.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
            Me.mnuExportDataToExcel.Size = New System.Drawing.Size(197, 22)
            Me.mnuExportDataToExcel.Text = "엑셀"
            '
            'mnuExit
            '
            Me.mnuExit.Name = "mnuExit"
            Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
            Me.mnuExit.Size = New System.Drawing.Size(197, 22)
            Me.mnuExit.Text = "종료"
            '
            'mnuDeleteData
            '
            Me.mnuDeleteData.Name = "mnuDeleteData"
            Me.mnuDeleteData.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
            Me.mnuDeleteData.Size = New System.Drawing.Size(197, 22)
            Me.mnuDeleteData.Text = "삭제"
            '
            'tlbMain
            '
            Me.tlbMain.BackColor = System.Drawing.Color.White
            Me.tlbMain.Font = New System.Drawing.Font("굴림", 8.5!)
            Me.tlbMain.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.tlbMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnRequestData, Me.btnNewData, Me.btnSaveData, Me.btnDeleteData, Me.btnSeparator1, Me.btnExportDataToExcel, Me.btnExportDataToPreview, Me.btnExportDataToPrinter, Me.btnSeparator2, Me.btnExit, Me.btnSeparator3, Me.btnHelp, Me.ToolStripSeparator1, Me.btnNotepad, Me.btnCalc})
            Me.tlbMain.Location = New System.Drawing.Point(200, 24)
            Me.tlbMain.Name = "tlbMain"
            Me.tlbMain.Size = New System.Drawing.Size(873, 31)
            Me.tlbMain.TabIndex = 13
            Me.tlbMain.Text = "tlbMain"
            '
            'btnRequestData
            '
            Me.btnRequestData.Image = Global.My.Resources.Resources.open_32x32
            Me.btnRequestData.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnRequestData.Name = "btnRequestData"
            Me.btnRequestData.Size = New System.Drawing.Size(69, 28)
            Me.btnRequestData.Text = " 조 회 "
            Me.btnRequestData.ToolTipText = " 조 회, Ctrl+R"
            '
            'btnNewData
            '
            Me.btnNewData.Image = Global.My.Resources.Resources.new_32x32
            Me.btnNewData.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnNewData.Name = "btnNewData"
            Me.btnNewData.Size = New System.Drawing.Size(69, 28)
            Me.btnNewData.Text = " 신 규 "
            Me.btnNewData.ToolTipText = " 신 규, Ctrl+N"
            '
            'btnSaveData
            '
            Me.btnSaveData.Image = Global.My.Resources.Resources.save_32x32
            Me.btnSaveData.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnSaveData.Name = "btnSaveData"
            Me.btnSaveData.Size = New System.Drawing.Size(69, 28)
            Me.btnSaveData.Text = " 저 장 "
            Me.btnSaveData.ToolTipText = " 저 장, Ctrl+S"
            '
            'btnDeleteData
            '
            Me.btnDeleteData.Image = Global.My.Resources.Resources.delete_32x32
            Me.btnDeleteData.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnDeleteData.Name = "btnDeleteData"
            Me.btnDeleteData.Size = New System.Drawing.Size(69, 28)
            Me.btnDeleteData.Text = " 삭 제 "
            Me.btnDeleteData.ToolTipText = " 삭 제, Ctrl+D"
            '
            'btnSeparator1
            '
            Me.btnSeparator1.Name = "btnSeparator1"
            Me.btnSeparator1.Size = New System.Drawing.Size(6, 31)
            '
            'btnExportDataToExcel
            '
            Me.btnExportDataToExcel.Image = Global.My.Resources.Resources.엑셀
            Me.btnExportDataToExcel.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnExportDataToExcel.Name = "btnExportDataToExcel"
            Me.btnExportDataToExcel.Size = New System.Drawing.Size(69, 28)
            Me.btnExportDataToExcel.Text = " 엑 셀 "
            Me.btnExportDataToExcel.ToolTipText = " 엑 셀, Ctrl+E"
            '
            'btnExportDataToPreview
            '
            Me.btnExportDataToPreview.Image = Global.My.Resources.Resources.preview_32x32
            Me.btnExportDataToPreview.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnExportDataToPreview.Name = "btnExportDataToPreview"
            Me.btnExportDataToPreview.Size = New System.Drawing.Size(81, 28)
            Me.btnExportDataToPreview.Text = "미리보기"
            Me.btnExportDataToPreview.ToolTipText = "미리보기, Ctrl+Shift+V"
            '
            'btnExportDataToPrinter
            '
            Me.btnExportDataToPrinter.Image = Global.My.Resources.Resources.인쇄
            Me.btnExportDataToPrinter.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnExportDataToPrinter.Name = "btnExportDataToPrinter"
            Me.btnExportDataToPrinter.Size = New System.Drawing.Size(69, 28)
            Me.btnExportDataToPrinter.Text = " 인 쇄 "
            Me.btnExportDataToPrinter.ToolTipText = " 인 쇄, Ctrl+P "
            '
            'btnSeparator2
            '
            Me.btnSeparator2.Name = "btnSeparator2"
            Me.btnSeparator2.Size = New System.Drawing.Size(6, 31)
            '
            'btnExit
            '
            Me.btnExit.Image = Global.My.Resources.Resources.x_32x32
            Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnExit.Name = "btnExit"
            Me.btnExit.Size = New System.Drawing.Size(69, 28)
            Me.btnExit.Text = " 종 료 "
            Me.btnExit.ToolTipText = " 종 료, Ctrl+X"
            '
            'btnSeparator3
            '
            Me.btnSeparator3.Name = "btnSeparator3"
            Me.btnSeparator3.Size = New System.Drawing.Size(6, 31)
            '
            'btnHelp
            '
            Me.btnHelp.Image = Global.My.Resources.Resources.help_32x32
            Me.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnHelp.Name = "btnHelp"
            Me.btnHelp.Size = New System.Drawing.Size(69, 28)
            Me.btnHelp.Text = "도움말"
            Me.btnHelp.ToolTipText = "도움말 F1"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
            '
            'btnNotepad
            '
            Me.btnNotepad.Image = Global.My.Resources.Resources.메모장
            Me.btnNotepad.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnNotepad.Name = "btnNotepad"
            Me.btnNotepad.Size = New System.Drawing.Size(69, 28)
            Me.btnNotepad.Text = "메모장"
            '
            'btnCalc
            '
            Me.btnCalc.Image = Global.My.Resources.Resources.계산기
            Me.btnCalc.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.btnCalc.Name = "btnCalc"
            Me.btnCalc.Size = New System.Drawing.Size(69, 28)
            Me.btnCalc.Text = "계산기"
            '
            'splMain
            '
            Me.splMain.Location = New System.Drawing.Point(197, 0)
            Me.splMain.Name = "splMain"
            Me.splMain.Size = New System.Drawing.Size(3, 741)
            Me.splMain.TabIndex = 12
            Me.splMain.TabStop = False
            '
            'pnlLeft
            '
            Me.pnlLeft.AutoScroll = True
            Me.pnlLeft.BackColor = System.Drawing.Color.GhostWhite
            Me.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlLeft.Controls.Add(Me.pnlLeftBottom)
            Me.pnlLeft.Controls.Add(Me.splLeft)
            Me.pnlLeft.Controls.Add(Me.pnlLeftTop)
            Me.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlLeft.Location = New System.Drawing.Point(0, 0)
            Me.pnlLeft.Name = "pnlLeft"
            Me.pnlLeft.Size = New System.Drawing.Size(197, 741)
            Me.pnlLeft.TabIndex = 2
            '
            'pnlLeftBottom
            '
            Me.pnlLeftBottom.AutoScroll = True
            Me.pnlLeftBottom.BackColor = System.Drawing.Color.GhostWhite
            Me.pnlLeftBottom.Controls.Add(Me.trvLeftBottom)
            Me.pnlLeftBottom.Controls.Add(Me.lblWorkFlow)
            Me.pnlLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlLeftBottom.Location = New System.Drawing.Point(0, 648)
            Me.pnlLeftBottom.Name = "pnlLeftBottom"
            Me.pnlLeftBottom.Size = New System.Drawing.Size(195, 91)
            Me.pnlLeftBottom.TabIndex = 0
            '
            'trvLeftBottom
            '
            Me.trvLeftBottom.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.trvLeftBottom.BackColor = System.Drawing.Color.White
            Me.trvLeftBottom.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.trvLeftBottom.ImageIndex = 0
            Me.trvLeftBottom.ImageList = Me.imgListMain
            Me.trvLeftBottom.Location = New System.Drawing.Point(-1, 20)
            Me.trvLeftBottom.Name = "trvLeftBottom"
            Me.trvLeftBottom.SelectedImageIndex = 0
            Me.trvLeftBottom.Size = New System.Drawing.Size(195, 68)
            Me.trvLeftBottom.TabIndex = 1
            '
            'imgListMain
            '
            Me.imgListMain.ImageStream = CType(resources.GetObject("imgListMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgListMain.TransparentColor = System.Drawing.Color.Transparent
            Me.imgListMain.Images.SetKeyName(0, "picClose")
            Me.imgListMain.Images.SetKeyName(1, "picOpen")
            Me.imgListMain.Images.SetKeyName(2, "picPrint")
            Me.imgListMain.Images.SetKeyName(3, "picSave")
            Me.imgListMain.Images.SetKeyName(4, "picSearch")
            '
            'lblWorkFlow
            '
            Me.lblWorkFlow.BackColor = System.Drawing.Color.Gainsboro
            Me.lblWorkFlow.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblWorkFlow.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblWorkFlow.Location = New System.Drawing.Point(0, 0)
            Me.lblWorkFlow.Name = "lblWorkFlow"
            Me.lblWorkFlow.Size = New System.Drawing.Size(195, 17)
            Me.lblWorkFlow.TabIndex = 0
            Me.lblWorkFlow.Text = "즐겨찾기"
            Me.lblWorkFlow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'splLeft
            '
            Me.splLeft.BackColor = System.Drawing.Color.Gainsboro
            Me.splLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.splLeft.Dock = System.Windows.Forms.DockStyle.Top
            Me.splLeft.Location = New System.Drawing.Point(0, 643)
            Me.splLeft.Name = "splLeft"
            Me.splLeft.Size = New System.Drawing.Size(195, 5)
            Me.splLeft.TabIndex = 4
            Me.splLeft.TabStop = False
            '
            'pnlLeftTop
            '
            Me.pnlLeftTop.AutoScroll = True
            Me.pnlLeftTop.BackColor = System.Drawing.Color.White
            Me.pnlLeftTop.Controls.Add(Me.lblLetTopLabel)
            Me.pnlLeftTop.Controls.Add(Me.trvMain)
            Me.pnlLeftTop.Controls.Add(Me.btnCTI_Logout)
            Me.pnlLeftTop.Controls.Add(Me.btnCTIShow)
            Me.pnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlLeftTop.Location = New System.Drawing.Point(0, 0)
            Me.pnlLeftTop.Name = "pnlLeftTop"
            Me.pnlLeftTop.Size = New System.Drawing.Size(195, 643)
            Me.pnlLeftTop.TabIndex = 3
            '
            'lblLetTopLabel
            '
            Me.lblLetTopLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblLetTopLabel.BackColor = System.Drawing.Color.PeachPuff
            Me.lblLetTopLabel.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblLetTopLabel.Location = New System.Drawing.Point(0, 27)
            Me.lblLetTopLabel.Name = "lblLetTopLabel"
            Me.lblLetTopLabel.Size = New System.Drawing.Size(195, 17)
            Me.lblLetTopLabel.TabIndex = 16
            Me.lblLetTopLabel.Text = "SIMS 3.0"
            Me.lblLetTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'trvMain
            '
            Me.trvMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.trvMain.BackColor = System.Drawing.Color.GhostWhite
            Me.trvMain.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.trvMain.ImageIndex = 0
            Me.trvMain.ImageList = Me.imgListMain
            Me.trvMain.Location = New System.Drawing.Point(2, 47)
            Me.trvMain.Name = "trvMain"
            Me.trvMain.SelectedImageIndex = 0
            Me.trvMain.Size = New System.Drawing.Size(192, 593)
            Me.trvMain.TabIndex = 0
            '
            'btnCTI_Logout
            '
            Me.btnCTI_Logout.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCTI_Logout.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCTI_Logout.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCTI_Logout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCTI_Logout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCTI_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCTI_Logout.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnCTI_Logout.Location = New System.Drawing.Point(95, 5)
            Me.btnCTI_Logout.Name = "btnCTI_Logout"
            Me.btnCTI_Logout.Size = New System.Drawing.Size(94, 18)
            Me.btnCTI_Logout.TabIndex = 15
            Me.btnCTI_Logout.TabStop = False
            Me.btnCTI_Logout.Text = "CTI로그아웃"
            Me.btnCTI_Logout.UseVisualStyleBackColor = True
            '
            'btnCTIShow
            '
            Me.btnCTIShow.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCTIShow.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnCTIShow.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnCTIShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnCTIShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnCTIShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnCTIShow.Font = New System.Drawing.Font("굴림", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.btnCTIShow.Location = New System.Drawing.Point(10, 5)
            Me.btnCTIShow.Name = "btnCTIShow"
            Me.btnCTIShow.Size = New System.Drawing.Size(84, 18)
            Me.btnCTIShow.TabIndex = 14
            Me.btnCTIShow.TabStop = False
            Me.btnCTIShow.Text = "CTI 로그인"
            Me.btnCTIShow.UseVisualStyleBackColor = True
            '
            'sttMain
            '
            Me.sttMain.Font = New System.Drawing.Font("굴림", 8.0!)
            Me.sttMain.GripMargin = New System.Windows.Forms.Padding(0)
            Me.sttMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus1, Me.lblStatus2, Me.lblRequestData, Me.lblStatus3, Me.lblCreateData, Me.lblStatus4, Me.lblUpdateData, Me.lblStatus5, Me.lblDeleteData, Me.lblStatus8, Me.lblMessage, Me.lblStatus6, Me.lblLoginTime, Me.lblStatus7, Me.lblCurrentTime, Me.lblVersion})
            Me.sttMain.Location = New System.Drawing.Point(200, 719)
            Me.sttMain.Name = "sttMain"
            Me.sttMain.Size = New System.Drawing.Size(873, 22)
            Me.sttMain.TabIndex = 4
            Me.sttMain.Text = "sttMain"
            '
            'lblStatus1
            '
            Me.lblStatus1.AutoSize = False
            Me.lblStatus1.Name = "lblStatus1"
            Me.lblStatus1.Size = New System.Drawing.Size(193, 17)
            '
            'lblStatus2
            '
            Me.lblStatus2.Name = "lblStatus2"
            Me.lblStatus2.Size = New System.Drawing.Size(60, 17)
            Me.lblStatus2.Text = "조회자료 : "
            '
            'lblRequestData
            '
            Me.lblRequestData.AutoSize = False
            Me.lblRequestData.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblRequestData.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblRequestData.Name = "lblRequestData"
            Me.lblRequestData.Size = New System.Drawing.Size(50, 17)
            '
            'lblStatus3
            '
            Me.lblStatus3.Name = "lblStatus3"
            Me.lblStatus3.Size = New System.Drawing.Size(64, 17)
            Me.lblStatus3.Text = " 등록자료 : "
            '
            'lblCreateData
            '
            Me.lblCreateData.AutoSize = False
            Me.lblCreateData.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCreateData.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblCreateData.Name = "lblCreateData"
            Me.lblCreateData.Size = New System.Drawing.Size(40, 17)
            '
            'lblStatus4
            '
            Me.lblStatus4.Name = "lblStatus4"
            Me.lblStatus4.Size = New System.Drawing.Size(64, 17)
            Me.lblStatus4.Text = " 변경자료 : "
            '
            'lblUpdateData
            '
            Me.lblUpdateData.AutoSize = False
            Me.lblUpdateData.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblUpdateData.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblUpdateData.Name = "lblUpdateData"
            Me.lblUpdateData.Size = New System.Drawing.Size(40, 17)
            '
            'lblStatus5
            '
            Me.lblStatus5.Name = "lblStatus5"
            Me.lblStatus5.Size = New System.Drawing.Size(64, 17)
            Me.lblStatus5.Text = " 삭제자료 : "
            '
            'lblDeleteData
            '
            Me.lblDeleteData.AutoSize = False
            Me.lblDeleteData.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblDeleteData.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblDeleteData.Name = "lblDeleteData"
            Me.lblDeleteData.Size = New System.Drawing.Size(40, 17)
            '
            'lblStatus8
            '
            Me.lblStatus8.AutoSize = False
            Me.lblStatus8.Name = "lblStatus8"
            Me.lblStatus8.Size = New System.Drawing.Size(10, 17)
            '
            'lblMessage
            '
            Me.lblMessage.AutoSize = False
            Me.lblMessage.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblMessage.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblMessage.Name = "lblMessage"
            Me.lblMessage.Size = New System.Drawing.Size(250, 17)
            Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblStatus6
            '
            Me.lblStatus6.Name = "lblStatus6"
            Me.lblStatus6.Size = New System.Drawing.Size(75, 11)
            Me.lblStatus6.Text = " 로그인시간 : "
            '
            'lblLoginTime
            '
            Me.lblLoginTime.AutoSize = False
            Me.lblLoginTime.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblLoginTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblLoginTime.Name = "lblLoginTime"
            Me.lblLoginTime.Size = New System.Drawing.Size(60, 17)
            '
            'lblStatus7
            '
            Me.lblStatus7.Name = "lblStatus7"
            Me.lblStatus7.Size = New System.Drawing.Size(68, 11)
            Me.lblStatus7.Text = "  현재시간 : "
            '
            'lblCurrentTime
            '
            Me.lblCurrentTime.AutoSize = False
            Me.lblCurrentTime.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCurrentTime.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
            Me.lblCurrentTime.Name = "lblCurrentTime"
            Me.lblCurrentTime.Size = New System.Drawing.Size(60, 17)
            '
            'lblVersion
            '
            Me.lblVersion.Name = "lblVersion"
            Me.lblVersion.Size = New System.Drawing.Size(62, 11)
            Me.lblVersion.Text = "lblVersion"
            '
            'mnuNewData
            '
            Me.mnuNewData.Name = "mnuNewData"
            Me.mnuNewData.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
            Me.mnuNewData.Size = New System.Drawing.Size(197, 22)
            Me.mnuNewData.Text = "신규"
            '
            'mnuSaveData
            '
            Me.mnuSaveData.Name = "mnuSaveData"
            Me.mnuSaveData.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
            Me.mnuSaveData.Size = New System.Drawing.Size(197, 22)
            Me.mnuSaveData.Text = "저장"
            '
            'mnuRequestData
            '
            Me.mnuRequestData.Name = "mnuRequestData"
            Me.mnuRequestData.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
            Me.mnuRequestData.Size = New System.Drawing.Size(197, 22)
            Me.mnuRequestData.Text = "조회"
            '
            'mnuMain
            '
            Me.mnuMain.BackColor = System.Drawing.Color.White
            Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
            Me.mnuMain.Location = New System.Drawing.Point(200, 0)
            Me.mnuMain.Name = "mnuMain"
            Me.mnuMain.Size = New System.Drawing.Size(873, 24)
            Me.mnuMain.TabIndex = 0
            '
            'mnuFile
            '
            Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuRequestData, Me.mnuNewData, Me.mnuSaveData, Me.mnuDeleteData, Me.mnuSeparator1, Me.mnuExportDataToExcel, Me.mnuExportDataToPreview, Me.mnuExportDataToPrinter, Me.mnuSeparator2, Me.mnuExit, Me.mnuSeparator3, Me.mnuHelp})
            Me.mnuFile.Name = "mnuFile"
            Me.mnuFile.Size = New System.Drawing.Size(43, 20)
            Me.mnuFile.Text = "파일"
            '
            'mnuSeparator1
            '
            Me.mnuSeparator1.Name = "mnuSeparator1"
            Me.mnuSeparator1.Size = New System.Drawing.Size(194, 6)
            '
            'mnuExportDataToPreview
            '
            Me.mnuExportDataToPreview.Name = "mnuExportDataToPreview"
            Me.mnuExportDataToPreview.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
            Me.mnuExportDataToPreview.Size = New System.Drawing.Size(197, 22)
            Me.mnuExportDataToPreview.Text = "미리보기"
            '
            'mnuSeparator3
            '
            Me.mnuSeparator3.Name = "mnuSeparator3"
            Me.mnuSeparator3.Size = New System.Drawing.Size(194, 6)
            '
            'mnuHelp
            '
            Me.mnuHelp.Name = "mnuHelp"
            Me.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1
            Me.mnuHelp.Size = New System.Drawing.Size(197, 22)
            Me.mnuHelp.Text = "도움말"
            Me.mnuHelp.ToolTipText = "도움말 F1"
            '
            'pnlTop
            '
            Me.pnlTop.BackColor = System.Drawing.Color.GhostWhite
            Me.pnlTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.pnlTop.Controls.Add(Me.picAllClose)
            Me.pnlTop.Controls.Add(Me.picOpenedProgram)
            Me.pnlTop.Controls.Add(Me.pnlTopLeft)
            Me.pnlTop.Controls.Add(Me.picClose)
            Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTop.Location = New System.Drawing.Point(200, 67)
            Me.pnlTop.Name = "pnlTop"
            Me.pnlTop.Size = New System.Drawing.Size(873, 20)
            Me.pnlTop.TabIndex = 2
            '
            'picAllClose
            '
            Me.picAllClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picAllClose.BackColor = System.Drawing.Color.White
            Me.picAllClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.picAllClose.Image = Global.My.Resources.Resources.Main_exit
            Me.picAllClose.Location = New System.Drawing.Point(848, 0)
            Me.picAllClose.Margin = New System.Windows.Forms.Padding(0)
            Me.picAllClose.Name = "picAllClose"
            Me.picAllClose.Size = New System.Drawing.Size(24, 19)
            Me.picAllClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picAllClose.TabIndex = 21
            Me.picAllClose.TabStop = False
            Me.picAllClose.Tag = "모두닫기"
            '
            'picOpenedProgram
            '
            Me.picOpenedProgram.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picOpenedProgram.BackColor = System.Drawing.Color.White
            Me.picOpenedProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.picOpenedProgram.Image = Global.My.Resources.Resources.List_screen
            Me.picOpenedProgram.InitialImage = CType(resources.GetObject("picOpenedProgram.InitialImage"), System.Drawing.Image)
            Me.picOpenedProgram.Location = New System.Drawing.Point(811, 1)
            Me.picOpenedProgram.Margin = New System.Windows.Forms.Padding(0)
            Me.picOpenedProgram.Name = "picOpenedProgram"
            Me.picOpenedProgram.Size = New System.Drawing.Size(18, 18)
            Me.picOpenedProgram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picOpenedProgram.TabIndex = 20
            Me.picOpenedProgram.TabStop = False
            '
            'pnlTopLeft
            '
            Me.pnlTopLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.pnlTopLeft.BackColor = System.Drawing.Color.GhostWhite
            Me.pnlTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.pnlTopLeft.Controls.Add(Me.picLine)
            Me.pnlTopLeft.Controls.Add(Me.picTopLeft)
            Me.pnlTopLeft.Location = New System.Drawing.Point(0, 0)
            Me.pnlTopLeft.Name = "pnlTopLeft"
            Me.pnlTopLeft.Size = New System.Drawing.Size(816, 19)
            Me.pnlTopLeft.TabIndex = 19
            '
            'picLine
            '
            Me.picLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picLine.BackColor = System.Drawing.Color.DarkGray
            Me.picLine.Location = New System.Drawing.Point(0, 18)
            Me.picLine.Name = "picLine"
            Me.picLine.Size = New System.Drawing.Size(892, 1)
            Me.picLine.TabIndex = 17
            Me.picLine.TabStop = False
            '
            'picTopLeft
            '
            Me.picTopLeft.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTopLeft.BackColor = System.Drawing.Color.Gainsboro
            Me.picTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTopLeft.Location = New System.Drawing.Point(0, 0)
            Me.picTopLeft.Name = "picTopLeft"
            Me.picTopLeft.Size = New System.Drawing.Size(871, 20)
            Me.picTopLeft.TabIndex = 21
            Me.picTopLeft.TabStop = False
            '
            'picClose
            '
            Me.picClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picClose.BackColor = System.Drawing.Color.White
            Me.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.picClose.Image = Global.My.Resources.Resources.Close_screen
            Me.picClose.Location = New System.Drawing.Point(829, 1)
            Me.picClose.Margin = New System.Windows.Forms.Padding(0)
            Me.picClose.Name = "picClose"
            Me.picClose.Size = New System.Drawing.Size(18, 18)
            Me.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.picClose.TabIndex = 15
            Me.picClose.TabStop = False
            '
            'pnlRight
            '
            Me.pnlRight.AutoScroll = True
            Me.pnlRight.BackColor = System.Drawing.Color.GhostWhite
            Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlRight.Location = New System.Drawing.Point(200, 87)
            Me.pnlRight.Name = "pnlRight"
            Me.pnlRight.Size = New System.Drawing.Size(873, 632)
            Me.pnlRight.TabIndex = 3
            '
            'lblLogin
            '
            Me.lblLogin.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblLogin.Dock = System.Windows.Forms.DockStyle.Top
            Me.lblLogin.Font = New System.Drawing.Font("굴림", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblLogin.Location = New System.Drawing.Point(200, 55)
            Me.lblLogin.Name = "lblLogin"
            Me.lblLogin.Size = New System.Drawing.Size(873, 12)
            Me.lblLogin.TabIndex = 16
            Me.lblLogin.Text = "본점 / 마케팅실 / 홍길동 / 대리"
            Me.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'imgListSub
            '
            Me.imgListSub.ImageStream = CType(resources.GetObject("imgListSub.ImageStream"), System.Windows.Forms.ImageListStreamer)
            Me.imgListSub.TransparentColor = System.Drawing.Color.Transparent
            Me.imgListSub.Images.SetKeyName(0, "picClose")
            Me.imgListSub.Images.SetKeyName(1, "picClose")
            Me.imgListSub.Images.SetKeyName(2, "picMinimumSize")
            Me.imgListSub.Images.SetKeyName(3, "picMinimumSize")
            '
            'cntMnuMain
            '
            Me.cntMnuMain.Name = "cntMnuMain"
            Me.cntMnuMain.Size = New System.Drawing.Size(61, 4)
            '
            'tmrMain
            '
            Me.tmrMain.Enabled = True
            '
            'frmMainUi
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1073, 741)
            Me.Controls.Add(Me.pnlRight)
            Me.Controls.Add(Me.pnlTop)
            Me.Controls.Add(Me.sttMain)
            Me.Controls.Add(Me.lblLogin)
            Me.Controls.Add(Me.tlbMain)
            Me.Controls.Add(Me.mnuMain)
            Me.Controls.Add(Me.splMain)
            Me.Controls.Add(Me.pnlLeft)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "frmMainUi"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.tlbMain.ResumeLayout(False)
            Me.tlbMain.PerformLayout()
            Me.pnlLeft.ResumeLayout(False)
            Me.pnlLeftBottom.ResumeLayout(False)
            Me.pnlLeftTop.ResumeLayout(False)
            Me.sttMain.ResumeLayout(False)
            Me.sttMain.PerformLayout()
            Me.mnuMain.ResumeLayout(False)
            Me.mnuMain.PerformLayout()
            Me.pnlTop.ResumeLayout(False)
            CType(Me.picAllClose, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picOpenedProgram, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlTopLeft.ResumeLayout(False)
            CType(Me.picLine, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picClose, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents mnuSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuExportDataToPrinter As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuExportDataToExcel As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuDeleteData As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents splMain As System.Windows.Forms.Splitter
        Friend WithEvents pnlLeft As System.Windows.Forms.Panel
        Friend WithEvents mnuNewData As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSaveData As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuRequestData As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
        Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents mnuSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuExportDataToPreview As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents pnlTop As System.Windows.Forms.Panel
        Friend WithEvents pnlRight As System.Windows.Forms.Panel
        Friend WithEvents pnlLeftBottom As System.Windows.Forms.Panel
        Friend WithEvents splLeft As System.Windows.Forms.Splitter
        Friend WithEvents pnlLeftTop As System.Windows.Forms.Panel
        Friend WithEvents trvMain As System.Windows.Forms.TreeView
        Friend WithEvents lblWorkFlow As System.Windows.Forms.Label
        Friend WithEvents trvLeftBottom As System.Windows.Forms.TreeView
        Friend WithEvents tlbMain As System.Windows.Forms.ToolStrip
        Friend WithEvents btnRequestData As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnNewData As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSaveData As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnDeleteData As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents btnExportDataToExcel As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnExportDataToPreview As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnExportDataToPrinter As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSeparator2 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents btnExit As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnCTI_Logout As ubiLease.CommonControls.btn
        Friend WithEvents btnCTIShow As ubiLease.CommonControls.btn
        Friend WithEvents imgListMain As System.Windows.Forms.ImageList
        Friend WithEvents sttMain As System.Windows.Forms.StatusStrip
        Friend WithEvents lblStatus8 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents picClose As System.Windows.Forms.PictureBox
        Friend WithEvents imgListSub As System.Windows.Forms.ImageList
        Friend WithEvents pnlTopLeft As System.Windows.Forms.Panel
        Friend WithEvents picTopLeft As System.Windows.Forms.PictureBox
        Friend WithEvents picLine As System.Windows.Forms.PictureBox
        Friend WithEvents cntMnuMain As System.Windows.Forms.ContextMenuStrip
        Friend WithEvents picOpenedProgram As System.Windows.Forms.PictureBox

        Friend WithEvents lblStatus1 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblStatus2 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblStatus3 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblStatus4 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblStatus5 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblStatus6 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblStatus7 As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents lblCurrentTime As System.Windows.Forms.ToolStripStatusLabel

        Public WithEvents lblLoginTime As System.Windows.Forms.ToolStripStatusLabel

        Public WithEvents lblLogin As System.Windows.Forms.Label
        Public WithEvents lblRequestData As System.Windows.Forms.ToolStripStatusLabel
        Public WithEvents lblUpdateData As System.Windows.Forms.ToolStripStatusLabel
        Public WithEvents lblCreateData As System.Windows.Forms.ToolStripStatusLabel
        Public WithEvents lblDeleteData As System.Windows.Forms.ToolStripStatusLabel
        Public WithEvents lblMessage As System.Windows.Forms.ToolStripStatusLabel
        Friend WithEvents tmrMain As System.Windows.Forms.Timer
        Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnSeparator3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuSeparator3 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents CommonSaveDialog As System.Windows.Forms.SaveFileDialog
        Friend WithEvents lblLetTopLabel As System.Windows.Forms.Label
        Friend WithEvents picAllClose As System.Windows.Forms.PictureBox
        Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Friend WithEvents btnNotepad As System.Windows.Forms.ToolStripButton
        Friend WithEvents btnCalc As System.Windows.Forms.ToolStripButton
        Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    End Class

End Namespace
