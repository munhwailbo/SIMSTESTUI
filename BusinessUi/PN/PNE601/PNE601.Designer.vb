Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE601
        Inherits CommonControls.UiControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE601))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label()
            Me.lblCodeDivision = New System.Windows.Forms.Label()
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox()
            Me.popChargeEmpNum = New ubiLease.CommonControls.txt()
            Me.popBranchNum = New ubiLease.CommonControls.txt()
            Me.cboOldOrNew = New ubiLease.CommonControls.cbo()
            Me.lblExpandDt = New System.Windows.Forms.Label()
            Me.dtpExpandDt = New ubiLease.CommonControls.dtp()
            Me.btnPlanningTeam = New System.Windows.Forms.Button()
            Me.btnSaleTeam = New System.Windows.Forms.Button()
            Me.btnPlanningTeamPost = New System.Windows.Forms.Button()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.picBar4 = New System.Windows.Forms.PictureBox()
            Me.picBar3 = New System.Windows.Forms.PictureBox()
            Me.picBar2 = New System.Windows.Forms.PictureBox()
            Me.picBar = New System.Windows.Forms.PictureBox()
            Me.grd_3 = New ubiLease.GridControl.grd()
            Me.grd_2 = New ubiLease.GridControl.grd()
            Me.grd_1 = New ubiLease.GridControl.grd()
            Me.btnLoadData = New System.Windows.Forms.Button()
            Me.btnSalesReport = New System.Windows.Forms.Button()
            Me.lblSaveDir = New System.Windows.Forms.Label()
            Me.txtPath = New ubiLease.CommonControls.txt()
            Me.btnSearchDir = New ubiLease.CommonControls.btn()
            Me.lblPath = New System.Windows.Forms.Label()
            Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar4, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'lblCodeDivisionHangulName
            '
            Me.lblCodeDivisionHangulName.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivisionHangulName.Location = New System.Drawing.Point(239, 22)
            Me.lblCodeDivisionHangulName.Name = "lblCodeDivisionHangulName"
            Me.lblCodeDivisionHangulName.Size = New System.Drawing.Size(57, 15)
            Me.lblCodeDivisionHangulName.TabIndex = 6
            Me.lblCodeDivisionHangulName.Text = "담당명"
            Me.lblCodeDivisionHangulName.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblCodeDivisionHangulName.Visible = False
            '
            'lblCodeDivision
            '
            Me.lblCodeDivision.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblCodeDivision.Location = New System.Drawing.Point(452, 22)
            Me.lblCodeDivision.Name = "lblCodeDivision"
            Me.lblCodeDivision.Size = New System.Drawing.Size(60, 15)
            Me.lblCodeDivision.TabIndex = 7
            Me.lblCodeDivision.Text = "지국 명"
            Me.lblCodeDivision.TextAlign = System.Drawing.ContentAlignment.TopRight
            Me.lblCodeDivision.Visible = False
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(4, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 51)
            Me.picCriteria_1.TabIndex = 2
            Me.picCriteria_1.TabStop = False
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BackColor = System.Drawing.SystemColors.Window
            Me.popChargeEmpNum.BaseBackColor = System.Drawing.Color.White
            Me.popChargeEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum.BorderStyle = 2
            Me.popChargeEmpNum.CaptionName = "담당 명"
            Me.popChargeEmpNum.Location = New System.Drawing.Point(305, 19)
            Me.popChargeEmpNum.MaxLength = 32767
            Me.popChargeEmpNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popChargeEmpNum.Multiline = False
            Me.popChargeEmpNum.Name = "popChargeEmpNum"
            Me.popChargeEmpNum.ReadOnlys = False
            Me.popChargeEmpNum.SelectedText = ""
            Me.popChargeEmpNum.SelectionLength = 0
            Me.popChargeEmpNum.SelectionStart = 0
            Me.popChargeEmpNum.Size = New System.Drawing.Size(115, 20)
            Me.popChargeEmpNum.TabIndex = 1
            Me.popChargeEmpNum.Tag = Nothing
            Me.popChargeEmpNum.TextAlign = 0
            Me.popChargeEmpNum.TextValue = ""
            Me.popChargeEmpNum.ToolTipText = ""
            Me.popChargeEmpNum.Visible = False
            '
            'popBranchNum
            '
            Me.popBranchNum.BackColor = System.Drawing.SystemColors.Window
            Me.popBranchNum.BaseBackColor = System.Drawing.Color.White
            Me.popBranchNum.BorderColor = System.Drawing.Color.Empty
            Me.popBranchNum.BorderStyle = 2
            Me.popBranchNum.CaptionName = "지국 명"
            Me.popBranchNum.Location = New System.Drawing.Point(518, 19)
            Me.popBranchNum.MaxLength = 32767
            Me.popBranchNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.popBranchNum.Multiline = False
            Me.popBranchNum.Name = "popBranchNum"
            Me.popBranchNum.ReadOnlys = False
            Me.popBranchNum.SelectedText = ""
            Me.popBranchNum.SelectionLength = 0
            Me.popBranchNum.SelectionStart = 0
            Me.popBranchNum.Size = New System.Drawing.Size(115, 20)
            Me.popBranchNum.TabIndex = 2
            Me.popBranchNum.Tag = Nothing
            Me.popBranchNum.TextAlign = 0
            Me.popBranchNum.TextValue = ""
            Me.popBranchNum.ToolTipText = ""
            Me.popBranchNum.Visible = False
            '
            'cboOldOrNew
            '
            Me.cboOldOrNew.CaptionName = "전임현임구분"
            Me.cboOldOrNew.Enabled = False
            Me.cboOldOrNew.ListCount = 0
            Me.cboOldOrNew.Location = New System.Drawing.Point(676, 19)
            Me.cboOldOrNew.Name = "cboOldOrNew"
            Me.cboOldOrNew.ReadOnlys = False
            Me.cboOldOrNew.Size = New System.Drawing.Size(114, 20)
            Me.cboOldOrNew.TabIndex = 3
            Me.cboOldOrNew.Tag = "code(담당자구분코드|전체);"
            Me.cboOldOrNew.TextValue = ""
            Me.cboOldOrNew.Visible = False
            '
            'lblExpandDt
            '
            Me.lblExpandDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblExpandDt.Location = New System.Drawing.Point(29, 23)
            Me.lblExpandDt.Name = "lblExpandDt"
            Me.lblExpandDt.Size = New System.Drawing.Size(57, 17)
            Me.lblExpandDt.TabIndex = 9
            Me.lblExpandDt.Text = "확장일자"
            Me.lblExpandDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpExpandDt
            '
            Me.dtpExpandDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpExpandDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpExpandDt.BorderStyle = 2
            Me.dtpExpandDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpExpandDt.CaptionName = "회계 일자"
            Me.dtpExpandDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpExpandDt.Location = New System.Drawing.Point(89, 20)
            Me.dtpExpandDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpExpandDt.MaxLength = 0
            Me.dtpExpandDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpExpandDt.Name = "dtpExpandDt"
            Me.dtpExpandDt.ReadOnlys = False
            Me.dtpExpandDt.SelectedText = ""
            Me.dtpExpandDt.SelectionLength = 0
            Me.dtpExpandDt.SelectionStart = 0
            Me.dtpExpandDt.Size = New System.Drawing.Size(104, 20)
            Me.dtpExpandDt.TabIndex = 8
            Me.dtpExpandDt.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpExpandDt.TextAlign = 0
            Me.dtpExpandDt.TextValue = ""
            Me.dtpExpandDt.ToolTipText = ""
            '
            'btnPlanningTeam
            '
            Me.btnPlanningTeam.Location = New System.Drawing.Point(420, 19)
            Me.btnPlanningTeam.Name = "btnPlanningTeam"
            Me.btnPlanningTeam.Size = New System.Drawing.Size(118, 23)
            Me.btnPlanningTeam.TabIndex = 10
            Me.btnPlanningTeam.Text = "기획관리국 집계표"
            Me.btnPlanningTeam.UseVisualStyleBackColor = True
            '
            'btnSaleTeam
            '
            Me.btnSaleTeam.Location = New System.Drawing.Point(544, 19)
            Me.btnSaleTeam.Name = "btnSaleTeam"
            Me.btnSaleTeam.Size = New System.Drawing.Size(118, 23)
            Me.btnSaleTeam.TabIndex = 11
            Me.btnSaleTeam.Text = "판매국 집계표"
            Me.btnSaleTeam.UseVisualStyleBackColor = True
            '
            'btnPlanningTeamPost
            '
            Me.btnPlanningTeamPost.Location = New System.Drawing.Point(296, 19)
            Me.btnPlanningTeamPost.Name = "btnPlanningTeamPost"
            Me.btnPlanningTeamPost.Size = New System.Drawing.Size(118, 23)
            Me.btnPlanningTeamPost.TabIndex = 12
            Me.btnPlanningTeamPost.Text = "기획관리국 포스트"
            Me.btnPlanningTeamPost.UseVisualStyleBackColor = True
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(4, 62)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(803, 51)
            Me.PictureBox1.TabIndex = 13
            Me.PictureBox1.TabStop = False
            '
            'picBar4
            '
            Me.picBar4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar4.BackColor = System.Drawing.Color.DarkGray
            Me.picBar4.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar4.Location = New System.Drawing.Point(4, 424)
            Me.picBar4.Name = "picBar4"
            Me.picBar4.Size = New System.Drawing.Size(804, 2)
            Me.picBar4.TabIndex = 1793
            Me.picBar4.TabStop = False
            Me.picBar4.Visible = False
            '
            'picBar3
            '
            Me.picBar3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar3.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar3.Location = New System.Drawing.Point(4, 460)
            Me.picBar3.Name = "picBar3"
            Me.picBar3.Size = New System.Drawing.Size(804, 3)
            Me.picBar3.TabIndex = 1792
            Me.picBar3.TabStop = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(4, 242)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(804, 2)
            Me.picBar2.TabIndex = 1791
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar.Location = New System.Drawing.Point(4, 278)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(804, 3)
            Me.picBar.TabIndex = 1790
            Me.picBar.TabStop = False
            '
            'grd_3
            '
            Me.grd_3.AllowBigSelection = False
            Me.grd_3.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_3.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_3.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_3.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_3.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_3.Cols = 2
            Me.grd_3.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_3.ExplorerBar = 0
            Me.grd_3.ExtendLastCol = True
            Me.grd_3.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_3.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_3.FrozenCols = 1
            Me.grd_3.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_3.Location = New System.Drawing.Point(4, 464)
            Me.grd_3.Name = "grd_3"
            Me.grd_3.NodeClosedPicture = Nothing
            Me.grd_3.NodeOpenPicture = Nothing
            Me.grd_3.OutlineCol = -1
            Me.grd_3.RowHeightMax = 18
            Me.grd_3.RowHeightMin = 18
            Me.grd_3.Rows = 2
            Me.grd_3.Size = New System.Drawing.Size(803, 180)
            Me.grd_3.StyleInfo = resources.GetString("grd_3.StyleInfo")
            Me.grd_3.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_3.TabIndex = 1789
            Me.grd_3.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(4, 282)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(803, 178)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1788
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_1.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_1.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(4, 119)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 159)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1787
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'btnLoadData
            '
            Me.btnLoadData.Location = New System.Drawing.Point(18, 76)
            Me.btnLoadData.Name = "btnLoadData"
            Me.btnLoadData.Size = New System.Drawing.Size(118, 23)
            Me.btnLoadData.TabIndex = 1794
            Me.btnLoadData.Text = "기초자료 불러오기"
            Me.btnLoadData.UseVisualStyleBackColor = True
            '
            'btnSalesReport
            '
            Me.btnSalesReport.Location = New System.Drawing.Point(668, 19)
            Me.btnSalesReport.Name = "btnSalesReport"
            Me.btnSalesReport.Size = New System.Drawing.Size(118, 23)
            Me.btnSalesReport.TabIndex = 1795
            Me.btnSalesReport.Text = "판매국 보고서"
            Me.btnSalesReport.UseVisualStyleBackColor = True
            '
            'lblSaveDir
            '
            Me.lblSaveDir.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblSaveDir.Location = New System.Drawing.Point(181, 79)
            Me.lblSaveDir.Name = "lblSaveDir"
            Me.lblSaveDir.Size = New System.Drawing.Size(59, 15)
            Me.lblSaveDir.TabIndex = 1798
            Me.lblSaveDir.Text = "저장 경로"
            '
            'txtPath
            '
            Me.txtPath.BackColor = System.Drawing.SystemColors.Window
            Me.txtPath.BaseBackColor = System.Drawing.Color.White
            Me.txtPath.BorderColor = System.Drawing.Color.Empty
            Me.txtPath.BorderStyle = 1
            Me.txtPath.CaptionName = "폴더경로"
            Me.txtPath.Enabled = False
            Me.txtPath.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.txtPath.Location = New System.Drawing.Point(243, 76)
            Me.txtPath.MaxLength = 50
            Me.txtPath.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtPath.Multiline = False
            Me.txtPath.Name = "txtPath"
            Me.txtPath.ReadOnlys = False
            Me.txtPath.SelectedText = ""
            Me.txtPath.SelectionLength = 0
            Me.txtPath.SelectionStart = 0
            Me.txtPath.Size = New System.Drawing.Size(419, 20)
            Me.txtPath.TabIndex = 1797
            Me.txtPath.Tag = ""
            Me.txtPath.TextAlign = 0
            Me.txtPath.TextValue = ""
            Me.txtPath.ToolTipText = ""
            '
            'btnSearchDir
            '
            Me.btnSearchDir.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnSearchDir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnSearchDir.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnSearchDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnSearchDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnSearchDir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnSearchDir.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.btnSearchDir.Location = New System.Drawing.Point(678, 76)
            Me.btnSearchDir.Name = "btnSearchDir"
            Me.btnSearchDir.Size = New System.Drawing.Size(100, 20)
            Me.btnSearchDir.TabIndex = 1796
            Me.btnSearchDir.TabStop = False
            Me.btnSearchDir.Text = "폴더 선택"
            Me.btnSearchDir.UseVisualStyleBackColor = True
            '
            'lblPath
            '
            Me.lblPath.BackColor = System.Drawing.Color.Transparent
            Me.lblPath.Location = New System.Drawing.Point(497, 80)
            Me.lblPath.Name = "lblPath"
            Me.lblPath.Size = New System.Drawing.Size(156, 11)
            Me.lblPath.TabIndex = 1799
            Me.lblPath.Text = "경로를 반드시 입력하세요"
            '
            'PNE601
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblPath)
            Me.Controls.Add(Me.lblSaveDir)
            Me.Controls.Add(Me.txtPath)
            Me.Controls.Add(Me.btnSearchDir)
            Me.Controls.Add(Me.btnSalesReport)
            Me.Controls.Add(Me.btnLoadData)
            Me.Controls.Add(Me.picBar4)
            Me.Controls.Add(Me.picBar3)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.grd_3)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.btnPlanningTeamPost)
            Me.Controls.Add(Me.btnSaleTeam)
            Me.Controls.Add(Me.btnPlanningTeam)
            Me.Controls.Add(Me.lblExpandDt)
            Me.Controls.Add(Me.dtpExpandDt)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.cboOldOrNew)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.popBranchNum)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.lblCodeDivision)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNE601"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivision, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.popBranchNum, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            Me.Controls.SetChildIndex(Me.cboOldOrNew, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.dtpExpandDt, 0)
            Me.Controls.SetChildIndex(Me.lblExpandDt, 0)
            Me.Controls.SetChildIndex(Me.btnPlanningTeam, 0)
            Me.Controls.SetChildIndex(Me.btnSaleTeam, 0)
            Me.Controls.SetChildIndex(Me.btnPlanningTeamPost, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.grd_3, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.picBar3, 0)
            Me.Controls.SetChildIndex(Me.picBar4, 0)
            Me.Controls.SetChildIndex(Me.btnLoadData, 0)
            Me.Controls.SetChildIndex(Me.btnSalesReport, 0)
            Me.Controls.SetChildIndex(Me.btnSearchDir, 0)
            Me.Controls.SetChildIndex(Me.txtPath, 0)
            Me.Controls.SetChildIndex(Me.lblSaveDir, 0)
            Me.Controls.SetChildIndex(Me.lblPath, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar4, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents lblCodeDivision As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.txt
        Friend WithEvents popBranchNum As ubiLease.CommonControls.txt
        Friend WithEvents cboOldOrNew As ubiLease.CommonControls.cbo
        Friend WithEvents lblExpandDt As System.Windows.Forms.Label
        Friend WithEvents dtpExpandDt As ubiLease.CommonControls.dtp
        Friend WithEvents btnPlanningTeam As System.Windows.Forms.Button
        Friend WithEvents btnSaleTeam As System.Windows.Forms.Button
        Friend WithEvents btnPlanningTeamPost As System.Windows.Forms.Button
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar4 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar3 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents grd_3 As ubiLease.GridControl.grd
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents btnLoadData As System.Windows.Forms.Button
        Friend WithEvents btnSalesReport As System.Windows.Forms.Button
        Friend WithEvents lblSaveDir As System.Windows.Forms.Label
        Friend WithEvents txtPath As CommonControls.txt
        Friend WithEvents btnSearchDir As CommonControls.btn
        Friend WithEvents lblPath As System.Windows.Forms.Label
        Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    End Class

End Namespace
