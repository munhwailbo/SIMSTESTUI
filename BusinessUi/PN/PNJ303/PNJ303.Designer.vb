Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNJ303
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNJ303))
            Me.lblCodeDivisionHangulName = New System.Windows.Forms.Label
            Me.lblCodeDivision = New System.Windows.Forms.Label
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label1 = New System.Windows.Forms.Label
            Me.popChargeEmpNum = New ubiLease.CommonControls.txt
            Me.popBranchNum = New ubiLease.CommonControls.txt
            Me.cboOldOrNew = New ubiLease.CommonControls.cbo
            Me.BtnNewLine = New ubiLease.CommonControls.btn
            Me.PictureBox2 = New System.Windows.Forms.PictureBox
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.dtpProcDT = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.dtpDmdYMFr = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.dtpDmdYMTo = New ubiLease.CommonControls.dtp
            Me.btnApprovalAll = New ubiLease.CommonControls.btn
            Me.chkDmdYM_R = New ubiLease.CommonControls.chk
            Me.chkDmd1 = New ubiLease.CommonControls.chk
            Me.chkDmd2 = New ubiLease.CommonControls.chk
            Me.picBar = New System.Windows.Forms.PictureBox
            Me.picBar2 = New System.Windows.Forms.PictureBox
            Me.popCouponCorpCd_R = New ubiLease.CommonControls.pop
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpBaseDt2_R = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.dtpBaseDt_R = New ubiLease.CommonControls.dtp
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 71)
            Me.picCriteria_1.TabIndex = 2
            Me.picCriteria_1.TabStop = False
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(4, 79)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 270)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 4
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(439, 366)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(73, 15)
            Me.Label1.TabIndex = 5
            Me.Label1.Text = "기준 일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label1.Visible = False
            '
            'popChargeEmpNum
            '
            Me.popChargeEmpNum.BackColor = System.Drawing.SystemColors.Window
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
            'BtnNewLine
            '
            Me.BtnNewLine.BackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnNewLine.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.BtnNewLine.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.BtnNewLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.BtnNewLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.BtnNewLine.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.BtnNewLine.Location = New System.Drawing.Point(33, 359)
            Me.BtnNewLine.Name = "BtnNewLine"
            Me.BtnNewLine.Size = New System.Drawing.Size(149, 28)
            Me.BtnNewLine.TabIndex = 5
            Me.BtnNewLine.Text = "배분 처리"
            Me.BtnNewLine.UseVisualStyleBackColor = True
            '
            'PictureBox2
            '
            Me.PictureBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox2.Location = New System.Drawing.Point(236, 354)
            Me.PictureBox2.Name = "PictureBox2"
            Me.PictureBox2.Size = New System.Drawing.Size(571, 38)
            Me.PictureBox2.TabIndex = 1643
            Me.PictureBox2.TabStop = False
            '
            'PictureBox1
            '
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(4, 354)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(226, 38)
            Me.PictureBox1.TabIndex = 1761
            Me.PictureBox1.TabStop = False
            '
            'dtpProcDT
            '
            Me.dtpProcDT.BackColor = System.Drawing.SystemColors.Window
            Me.dtpProcDT.BorderColor = System.Drawing.Color.Empty
            Me.dtpProcDT.BorderStyle = 2
            Me.dtpProcDT.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpProcDT.CaptionName = "작업 일자"
            Me.dtpProcDT.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpProcDT.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpProcDT.Location = New System.Drawing.Point(359, 363)
            Me.dtpProcDT.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpProcDT.MaxLength = 0
            Me.dtpProcDT.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpProcDT.Name = "dtpProcDT"
            Me.dtpProcDT.ReadOnlys = False
            Me.dtpProcDT.SelectedText = ""
            Me.dtpProcDT.SelectionLength = 0
            Me.dtpProcDT.SelectionStart = 0
            Me.dtpProcDT.Size = New System.Drawing.Size(108, 20)
            Me.dtpProcDT.TabIndex = 7
            Me.dtpProcDT.Tag = "format(&&&&-&&-&&);"
            Me.dtpProcDT.TextAlign = 0
            Me.dtpProcDT.TextValue = ""
            Me.dtpProcDT.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(255, 366)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(98, 15)
            Me.Label2.TabIndex = 6
            Me.Label2.Text = "배분 적용 일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpDmdYMFr
            '
            Me.dtpDmdYMFr.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDmdYMFr.BorderColor = System.Drawing.Color.Empty
            Me.dtpDmdYMFr.BorderStyle = 2
            Me.dtpDmdYMFr.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDmdYMFr.CaptionName = "청구 년 월"
            Me.dtpDmdYMFr.DateTimeFormatText = "yyyy-MM"
            Me.dtpDmdYMFr.Enabled = False
            Me.dtpDmdYMFr.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpDmdYMFr.Location = New System.Drawing.Point(671, 370)
            Me.dtpDmdYMFr.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDmdYMFr.MaxLength = 0
            Me.dtpDmdYMFr.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDmdYMFr.Name = "dtpDmdYMFr"
            Me.dtpDmdYMFr.ReadOnlys = False
            Me.dtpDmdYMFr.SelectedText = ""
            Me.dtpDmdYMFr.SelectionLength = 0
            Me.dtpDmdYMFr.SelectionStart = 0
            Me.dtpDmdYMFr.Size = New System.Drawing.Size(56, 20)
            Me.dtpDmdYMFr.TabIndex = 1762
            Me.dtpDmdYMFr.Tag = "format(&&&&-&&);"
            Me.dtpDmdYMFr.TextAlign = 0
            Me.dtpDmdYMFr.TextValue = ""
            Me.dtpDmdYMFr.ToolTipText = ""
            Me.dtpDmdYMFr.Visible = False
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label3.Location = New System.Drawing.Point(742, 356)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(15, 15)
            Me.Label3.TabIndex = 1764
            Me.Label3.Text = "~"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.Label3.Visible = False
            '
            'grd_2
            '
            Me.grd_2.AllowBigSelection = False
            Me.grd_2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_2.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.grd_2.BackColorBkg = System.Drawing.Color.WhiteSmoke
            Me.grd_2.BackColorFixed = System.Drawing.Color.Gainsboro
            Me.grd_2.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_2.Cols = 2
            Me.grd_2.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(4, 395)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 18
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(804, 246)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1766
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'dtpDmdYMTo
            '
            Me.dtpDmdYMTo.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDmdYMTo.BorderColor = System.Drawing.Color.Empty
            Me.dtpDmdYMTo.BorderStyle = 2
            Me.dtpDmdYMTo.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDmdYMTo.CaptionName = "청구 년 월"
            Me.dtpDmdYMTo.DateTimeFormatText = "yyyy-MM"
            Me.dtpDmdYMTo.Enabled = False
            Me.dtpDmdYMTo.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpDmdYMTo.Location = New System.Drawing.Point(734, 369)
            Me.dtpDmdYMTo.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDmdYMTo.MaxLength = 0
            Me.dtpDmdYMTo.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDmdYMTo.Name = "dtpDmdYMTo"
            Me.dtpDmdYMTo.ReadOnlys = False
            Me.dtpDmdYMTo.SelectedText = ""
            Me.dtpDmdYMTo.SelectionLength = 0
            Me.dtpDmdYMTo.SelectionStart = 0
            Me.dtpDmdYMTo.Size = New System.Drawing.Size(56, 20)
            Me.dtpDmdYMTo.TabIndex = 1767
            Me.dtpDmdYMTo.Tag = "format(&&&&-&&);"
            Me.dtpDmdYMTo.TextAlign = 0
            Me.dtpDmdYMTo.TextValue = ""
            Me.dtpDmdYMTo.ToolTipText = ""
            Me.dtpDmdYMTo.Visible = False
            '
            'btnApprovalAll
            '
            Me.btnApprovalAll.BackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
            Me.btnApprovalAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.WhiteSmoke
            Me.btnApprovalAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnApprovalAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GhostWhite
            Me.btnApprovalAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
            Me.btnApprovalAll.Location = New System.Drawing.Point(510, 359)
            Me.btnApprovalAll.Name = "btnApprovalAll"
            Me.btnApprovalAll.Size = New System.Drawing.Size(123, 28)
            Me.btnApprovalAll.TabIndex = 8
            Me.btnApprovalAll.Text = "일괄 적용"
            Me.btnApprovalAll.UseVisualStyleBackColor = True
            '
            'chkDmdYM_R
            '
            Me.chkDmdYM_R.AutoSize = True
            Me.chkDmdYM_R.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkDmdYM_R.CaptionName = "청구 년월"
            Me.chkDmdYM_R.Enabled = False
            Me.chkDmdYM_R.Location = New System.Drawing.Point(651, 359)
            Me.chkDmdYM_R.Name = "chkDmdYM_R"
            Me.chkDmdYM_R.ReadOnlys = False
            Me.chkDmdYM_R.Size = New System.Drawing.Size(76, 16)
            Me.chkDmdYM_R.TabIndex = 1770
            Me.chkDmdYM_R.Tag = Nothing
            Me.chkDmdYM_R.Text = "청구 년월"
            Me.chkDmdYM_R.TextValue = "0"
            Me.chkDmdYM_R.UseVisualStyleBackColor = False
            Me.chkDmdYM_R.Visible = False
            '
            'chkDmd1
            '
            Me.chkDmd1.AutoSize = True
            Me.chkDmd1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkDmd1.CaptionName = "청구 년월"
            Me.chkDmd1.Enabled = False
            Me.chkDmd1.Location = New System.Drawing.Point(487, 48)
            Me.chkDmd1.Name = "chkDmd1"
            Me.chkDmd1.ReadOnlys = False
            Me.chkDmd1.Size = New System.Drawing.Size(104, 16)
            Me.chkDmd1.TabIndex = 2
            Me.chkDmd1.Tag = Nothing
            Me.chkDmd1.Text = "배분 완료 포함"
            Me.chkDmd1.TextValue = "0"
            Me.chkDmd1.UseVisualStyleBackColor = False
            '
            'chkDmd2
            '
            Me.chkDmd2.AutoSize = True
            Me.chkDmd2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.chkDmd2.CaptionName = "청구 년월"
            Me.chkDmd2.Checked = True
            Me.chkDmd2.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chkDmd2.Enabled = False
            Me.chkDmd2.Location = New System.Drawing.Point(616, 48)
            Me.chkDmd2.Name = "chkDmd2"
            Me.chkDmd2.ReadOnlys = False
            Me.chkDmd2.Size = New System.Drawing.Size(92, 16)
            Me.chkDmd2.TabIndex = 3
            Me.chkDmd2.Tag = Nothing
            Me.chkDmd2.Text = "미 배분 포함"
            Me.chkDmd2.TextValue = "1"
            Me.chkDmd2.UseVisualStyleBackColor = False
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar.Location = New System.Drawing.Point(4, 350)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(803, 3)
            Me.picBar.TabIndex = 1773
            Me.picBar.TabStop = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(4, 279)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(803, 2)
            Me.picBar2.TabIndex = 1774
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'popCouponCorpCd_R
            '
            Me.popCouponCorpCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popCouponCorpCd_R.BorderStyle = 2
            Me.popCouponCorpCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCouponCorpCd_R.CaptionName = "확장처 코드"
            Me.popCouponCorpCd_R.CodeText = ""
            Me.popCouponCorpCd_R.CodeWidth = 50
            Me.popCouponCorpCd_R.Location = New System.Drawing.Point(129, 17)
            Me.popCouponCorpCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCouponCorpCd_R.MaxLength = 4
            Me.popCouponCorpCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCouponCorpCd_R.Name = "popCouponCorpCd_R"
            Me.popCouponCorpCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCouponCorpCd_R.NameText = ""
            Me.popCouponCorpCd_R.ReadOnlys = False
            Me.popCouponCorpCd_R.SelectedText = ""
            Me.popCouponCorpCd_R.SelectionLength = 0
            Me.popCouponCorpCd_R.SelectionStart = 0
            Me.popCouponCorpCd_R.Size = New System.Drawing.Size(291, 20)
            Me.popCouponCorpCd_R.TabIndex = 0
            Me.popCouponCorpCd_R.Tag = "code(소속사 명);"
            Me.popCouponCorpCd_R.TextAlign = 0
            Me.popCouponCorpCd_R.TextValue = ""
            Me.popCouponCorpCd_R.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(41, 17)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(83, 20)
            Me.Label5.TabIndex = 1777
            Me.Label5.Text = "소속사"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(227, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(78, 20)
            Me.Label4.TabIndex = 1781
            Me.Label4.Text = "처리기준일자"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBaseDt2_R
            '
            Me.dtpBaseDt2_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseDt2_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseDt2_R.BorderStyle = 2
            Me.dtpBaseDt2_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseDt2_R.CaptionName = "처리기준일자"
            Me.dtpBaseDt2_R.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseDt2_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseDt2_R.Location = New System.Drawing.Point(307, 41)
            Me.dtpBaseDt2_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseDt2_R.MaxLength = 0
            Me.dtpBaseDt2_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseDt2_R.Name = "dtpBaseDt2_R"
            Me.dtpBaseDt2_R.ReadOnlys = False
            Me.dtpBaseDt2_R.SelectedText = ""
            Me.dtpBaseDt2_R.SelectionLength = 0
            Me.dtpBaseDt2_R.SelectionStart = 0
            Me.dtpBaseDt2_R.Size = New System.Drawing.Size(114, 20)
            Me.dtpBaseDt2_R.TabIndex = 1780
            Me.dtpBaseDt2_R.Tag = "format(&&&&-&&-&&);"
            Me.dtpBaseDt2_R.TextAlign = 0
            Me.dtpBaseDt2_R.TextValue = ""
            Me.dtpBaseDt2_R.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(41, 43)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(83, 20)
            Me.Label6.TabIndex = 1779
            Me.Label6.Text = "배분기준년월"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBaseDt_R
            '
            Me.dtpBaseDt_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseDt_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseDt_R.BorderStyle = 2
            Me.dtpBaseDt_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseDt_R.CaptionName = "작업 년 월"
            Me.dtpBaseDt_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpBaseDt_R.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpBaseDt_R.Location = New System.Drawing.Point(129, 43)
            Me.dtpBaseDt_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseDt_R.MaxLength = 0
            Me.dtpBaseDt_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseDt_R.Name = "dtpBaseDt_R"
            Me.dtpBaseDt_R.ReadOnlys = False
            Me.dtpBaseDt_R.SelectedText = ""
            Me.dtpBaseDt_R.SelectionLength = 0
            Me.dtpBaseDt_R.SelectionStart = 0
            Me.dtpBaseDt_R.Size = New System.Drawing.Size(88, 20)
            Me.dtpBaseDt_R.TabIndex = 1778
            Me.dtpBaseDt_R.Tag = "format(&&&&-&&);"
            Me.dtpBaseDt_R.TextAlign = 0
            Me.dtpBaseDt_R.TextValue = ""
            Me.dtpBaseDt_R.ToolTipText = ""
            '
            'PNJ303
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpBaseDt2_R)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.dtpBaseDt_R)
            Me.Controls.Add(Me.popCouponCorpCd_R)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.chkDmd2)
            Me.Controls.Add(Me.chkDmd1)
            Me.Controls.Add(Me.chkDmdYM_R)
            Me.Controls.Add(Me.dtpDmdYMTo)
            Me.Controls.Add(Me.btnApprovalAll)
            Me.Controls.Add(Me.BtnNewLine)
            Me.Controls.Add(Me.dtpProcDT)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.dtpDmdYMFr)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.PictureBox2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.cboOldOrNew)
            Me.Controls.Add(Me.popChargeEmpNum)
            Me.Controls.Add(Me.popBranchNum)
            Me.Controls.Add(Me.lblCodeDivisionHangulName)
            Me.Controls.Add(Me.lblCodeDivision)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.grd_1)
            Me.Name = "PNJ303"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivision, 0)
            Me.Controls.SetChildIndex(Me.lblCodeDivisionHangulName, 0)
            Me.Controls.SetChildIndex(Me.popBranchNum, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum, 0)
            Me.Controls.SetChildIndex(Me.cboOldOrNew, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.PictureBox2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.dtpDmdYMFr, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.dtpProcDT, 0)
            Me.Controls.SetChildIndex(Me.BtnNewLine, 0)
            Me.Controls.SetChildIndex(Me.btnApprovalAll, 0)
            Me.Controls.SetChildIndex(Me.dtpDmdYMTo, 0)
            Me.Controls.SetChildIndex(Me.chkDmdYM_R, 0)
            Me.Controls.SetChildIndex(Me.chkDmd1, 0)
            Me.Controls.SetChildIndex(Me.chkDmd2, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.popCouponCorpCd_R, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseDt_R, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseDt2_R, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents lblCodeDivisionHangulName As System.Windows.Forms.Label
        Friend WithEvents lblCodeDivision As System.Windows.Forms.Label
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents popChargeEmpNum As ubiLease.CommonControls.txt
        Friend WithEvents popBranchNum As ubiLease.CommonControls.txt
        Friend WithEvents cboOldOrNew As ubiLease.CommonControls.cbo
        Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
        Friend WithEvents BtnNewLine As ubiLease.CommonControls.btn
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents dtpProcDT As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents dtpDmdYMFr As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents dtpDmdYMTo As ubiLease.CommonControls.dtp
        Friend WithEvents btnApprovalAll As ubiLease.CommonControls.btn
        Friend WithEvents chkDmdYM_R As ubiLease.CommonControls.chk
        Friend WithEvents chkDmd1 As ubiLease.CommonControls.chk
        Friend WithEvents chkDmd2 As ubiLease.CommonControls.chk
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents popCouponCorpCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseDt2_R As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents dtpBaseDt_R As ubiLease.CommonControls.dtp

    End Class

End Namespace
