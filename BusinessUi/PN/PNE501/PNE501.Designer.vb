Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE501
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE501))
            Me.dtpProcYM_R = New ubiLease.CommonControls.dtp
            Me.Label6 = New System.Windows.Forms.Label
            Me.Label8 = New System.Windows.Forms.Label
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.lblFormDivisionCode = New System.Windows.Forms.Label
            Me.picCriteria = New System.Windows.Forms.PictureBox
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.Label5 = New System.Windows.Forms.Label
            Me.cboBillDivCd_R = New ubiLease.CommonControls.cbo
            Me.popCompanyCd_R = New ubiLease.CommonControls.pop
            Me.lbl확장처 = New System.Windows.Forms.Label
            Me.popEmployeeExpNum_R = New ubiLease.CommonControls.pop
            Me.Label15 = New System.Windows.Forms.Label
            Me.grd_2 = New ubiLease.GridControl.grd
            Me.numBaseDay_R = New ubiLease.CommonControls.num
            Me.lblTitle2 = New System.Windows.Forms.Label
            Me.picTitle2 = New System.Windows.Forms.PictureBox
            Me.lblTitle1 = New System.Windows.Forms.Label
            Me.picTitle1 = New System.Windows.Forms.PictureBox
            Me.picBar2 = New System.Windows.Forms.PictureBox
            Me.picBar = New System.Windows.Forms.PictureBox
            Me.chkAll = New ubiLease.CommonControls.chk
            Me.btnBatchApply = New System.Windows.Forms.Button
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpDisYearMonth = New ubiLease.CommonControls.dtp
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'dtpProcYM_R
            '
            Me.dtpProcYM_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpProcYM_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpProcYM_R.BorderStyle = 2
            Me.dtpProcYM_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpProcYM_R.CaptionName = "배분월"
            Me.dtpProcYM_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpProcYM_R.Location = New System.Drawing.Point(84, 11)
            Me.dtpProcYM_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpProcYM_R.MaxLength = 0
            Me.dtpProcYM_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpProcYM_R.Name = "dtpProcYM_R"
            Me.dtpProcYM_R.ReadOnlys = False
            Me.dtpProcYM_R.SelectedText = ""
            Me.dtpProcYM_R.SelectionLength = 0
            Me.dtpProcYM_R.SelectionStart = 0
            Me.dtpProcYM_R.Size = New System.Drawing.Size(80, 20)
            Me.dtpProcYM_R.TabIndex = 1550
            Me.dtpProcYM_R.Tag = "need;format(####-##);format(&&&&-&&);"
            Me.dtpProcYM_R.TextAlign = 0
            Me.dtpProcYM_R.TextValue = ""
            Me.dtpProcYM_R.ToolTipText = ""
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label6.Location = New System.Drawing.Point(172, 13)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(41, 15)
            Me.Label6.TabIndex = 1553
            Me.Label6.Text = "기준일"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label8.Location = New System.Drawing.Point(21, 13)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(58, 15)
            Me.Label8.TabIndex = 1552
            Me.Label8.Text = "배분월"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBranchCd_R
            '
            Me.popBranchCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd_R.BorderStyle = 2
            Me.popBranchCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd_R.CaptionName = "지사지국 코드"
            Me.popBranchCd_R.CodeText = ""
            Me.popBranchCd_R.CodeWidth = 60
            Me.popBranchCd_R.Location = New System.Drawing.Point(84, 38)
            Me.popBranchCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd_R.MaxLength = 32767
            Me.popBranchCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd_R.Name = "popBranchCd_R"
            Me.popBranchCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd_R.NameText = ""
            Me.popBranchCd_R.ReadOnlys = False
            Me.popBranchCd_R.SelectedText = ""
            Me.popBranchCd_R.SelectionLength = 0
            Me.popBranchCd_R.SelectionStart = 0
            Me.popBranchCd_R.Size = New System.Drawing.Size(331, 20)
            Me.popBranchCd_R.TabIndex = 1539
            Me.popBranchCd_R.Tag = "code(지국코드);"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            '
            'lblFormDivisionCode
            '
            Me.lblFormDivisionCode.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblFormDivisionCode.Location = New System.Drawing.Point(21, 41)
            Me.lblFormDivisionCode.Name = "lblFormDivisionCode"
            Me.lblFormDivisionCode.Size = New System.Drawing.Size(58, 15)
            Me.lblFormDivisionCode.TabIndex = 1548
            Me.lblFormDivisionCode.Text = "지   국"
            Me.lblFormDivisionCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'picCriteria
            '
            Me.picCriteria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria.Location = New System.Drawing.Point(3, 4)
            Me.picCriteria.Name = "picCriteria"
            Me.picCriteria.Size = New System.Drawing.Size(804, 63)
            Me.picCriteria.TabIndex = 1543
            Me.picCriteria.TabStop = False
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
            Me.grd_1.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(3, 91)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 15
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 344)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 1542
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label5.Location = New System.Drawing.Point(248, 13)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(54, 15)
            Me.Label5.TabIndex = 1577
            Me.Label5.Text = "접수유형"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboBillDivCd_R
            '
            Me.cboBillDivCd_R.CaptionName = "접수유형"
            Me.cboBillDivCd_R.ListCount = 0
            Me.cboBillDivCd_R.Location = New System.Drawing.Point(307, 11)
            Me.cboBillDivCd_R.Name = "cboBillDivCd_R"
            Me.cboBillDivCd_R.ReadOnlys = False
            Me.cboBillDivCd_R.Size = New System.Drawing.Size(108, 20)
            Me.cboBillDivCd_R.TabIndex = 1576
            Me.cboBillDivCd_R.Tag = "code(청구유형명|전체);"
            Me.cboBillDivCd_R.TextValue = ""
            '
            'popCompanyCd_R
            '
            Me.popCompanyCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd_R.BorderStyle = 2
            Me.popCompanyCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd_R.CaptionName = "접수처"
            Me.popCompanyCd_R.CodeText = ""
            Me.popCompanyCd_R.CodeWidth = 80
            Me.popCompanyCd_R.Location = New System.Drawing.Point(503, 11)
            Me.popCompanyCd_R.MaximumSize = New System.Drawing.Size(800, 20)
            Me.popCompanyCd_R.MaxLength = 12
            Me.popCompanyCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd_R.Name = "popCompanyCd_R"
            Me.popCompanyCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd_R.NameText = ""
            Me.popCompanyCd_R.ReadOnlys = False
            Me.popCompanyCd_R.SelectedText = ""
            Me.popCompanyCd_R.SelectionLength = 0
            Me.popCompanyCd_R.SelectionStart = 0
            Me.popCompanyCd_R.Size = New System.Drawing.Size(287, 20)
            Me.popCompanyCd_R.TabIndex = 1707
            Me.popCompanyCd_R.Tag = "code(확장처 명);"
            Me.popCompanyCd_R.TextAlign = 0
            Me.popCompanyCd_R.TextValue = ""
            Me.popCompanyCd_R.ToolTipText = ""
            '
            'lbl확장처
            '
            Me.lbl확장처.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lbl확장처.Location = New System.Drawing.Point(436, 14)
            Me.lbl확장처.Name = "lbl확장처"
            Me.lbl확장처.Size = New System.Drawing.Size(61, 15)
            Me.lbl확장처.TabIndex = 1708
            Me.lbl확장처.Text = "접 수 처"
            Me.lbl확장처.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeExpNum_R
            '
            Me.popEmployeeExpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeExpNum_R.BorderStyle = 2
            Me.popEmployeeExpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeExpNum_R.CaptionName = "사원확장 명"
            Me.popEmployeeExpNum_R.CodeText = ""
            Me.popEmployeeExpNum_R.CodeWidth = 90
            Me.popEmployeeExpNum_R.Location = New System.Drawing.Point(503, 37)
            Me.popEmployeeExpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeExpNum_R.MaxLength = 12
            Me.popEmployeeExpNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeExpNum_R.Name = "popEmployeeExpNum_R"
            Me.popEmployeeExpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeExpNum_R.NameText = ""
            Me.popEmployeeExpNum_R.ReadOnlys = False
            Me.popEmployeeExpNum_R.SelectedText = ""
            Me.popEmployeeExpNum_R.SelectionLength = 0
            Me.popEmployeeExpNum_R.SelectionStart = 0
            Me.popEmployeeExpNum_R.Size = New System.Drawing.Size(287, 20)
            Me.popEmployeeExpNum_R.TabIndex = 1760
            Me.popEmployeeExpNum_R.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum_R.TextAlign = 0
            Me.popEmployeeExpNum_R.TextValue = ""
            Me.popEmployeeExpNum_R.ToolTipText = ""
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label15.Location = New System.Drawing.Point(436, 38)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(61, 18)
            Me.Label15.TabIndex = 1761
            Me.Label15.Text = "접수번호"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_2.ColumnInfo = "10,1,1,0,0,95,Columns:0{Width:30;TextAlign:CenterCenter;TextAlignFixed:CenterCent" & _
                "er;}" & Global.Microsoft.VisualBasic.ChrW(9)
            Me.grd_2.ExplorerBar = 0
            Me.grd_2.ExtendLastCol = True
            Me.grd_2.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_2.Font = New System.Drawing.Font("굴림", 9.75!)
            Me.grd_2.FrozenCols = 1
            Me.grd_2.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_2.Location = New System.Drawing.Point(3, 465)
            Me.grd_2.Name = "grd_2"
            Me.grd_2.NodeClosedPicture = Nothing
            Me.grd_2.NodeOpenPicture = Nothing
            Me.grd_2.OutlineCol = -1
            Me.grd_2.RowHeightMax = 18
            Me.grd_2.RowHeightMin = 15
            Me.grd_2.Rows = 2
            Me.grd_2.Size = New System.Drawing.Size(804, 177)
            Me.grd_2.StyleInfo = resources.GetString("grd_2.StyleInfo")
            Me.grd_2.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_2.TabIndex = 1762
            Me.grd_2.TreeColor = System.Drawing.Color.DarkGray
            '
            'numBaseDay_R
            '
            Me.numBaseDay_R.BackColor = System.Drawing.SystemColors.Window
            Me.numBaseDay_R.BorderColor = System.Drawing.Color.Empty
            Me.numBaseDay_R.BorderStyle = 2
            Me.numBaseDay_R.CaptionName = Nothing
            Me.numBaseDay_R.LengthPrecision = 2
            Me.numBaseDay_R.LengthScale = 0
            Me.numBaseDay_R.Location = New System.Drawing.Point(213, 11)
            Me.numBaseDay_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numBaseDay_R.MaxLength = 2
            Me.numBaseDay_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numBaseDay_R.Name = "numBaseDay_R"
            Me.numBaseDay_R.ReadOnlys = False
            Me.numBaseDay_R.SelectedText = ""
            Me.numBaseDay_R.SelectionLength = 0
            Me.numBaseDay_R.SelectionStart = 1
            Me.numBaseDay_R.Size = New System.Drawing.Size(26, 20)
            Me.numBaseDay_R.TabIndex = 1763
            Me.numBaseDay_R.Tag = Nothing
            Me.numBaseDay_R.TextValue = "0"
            Me.numBaseDay_R.ToolTipText = ""
            '
            'lblTitle2
            '
            Me.lblTitle2.AutoSize = True
            Me.lblTitle2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle2.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle2.Location = New System.Drawing.Point(11, 445)
            Me.lblTitle2.Name = "lblTitle2"
            Me.lblTitle2.Size = New System.Drawing.Size(80, 12)
            Me.lblTitle2.TabIndex = 1824
            Me.lblTitle2.Text = "<독자 정보>"
            Me.lblTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle2
            '
            Me.picTitle2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle2.BackColor = System.Drawing.Color.LightGray
            Me.picTitle2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle2.Location = New System.Drawing.Point(3, 440)
            Me.picTitle2.Name = "picTitle2"
            Me.picTitle2.Size = New System.Drawing.Size(804, 29)
            Me.picTitle2.TabIndex = 1823
            Me.picTitle2.TabStop = False
            '
            'lblTitle1
            '
            Me.lblTitle1.AutoSize = True
            Me.lblTitle1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblTitle1.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblTitle1.Location = New System.Drawing.Point(10, 73)
            Me.lblTitle1.Name = "lblTitle1"
            Me.lblTitle1.Size = New System.Drawing.Size(106, 12)
            Me.lblTitle1.TabIndex = 1822
            Me.lblTitle1.Text = "<부수차이 현황>"
            Me.lblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picTitle1
            '
            Me.picTitle1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picTitle1.BackColor = System.Drawing.Color.LightGray
            Me.picTitle1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picTitle1.Location = New System.Drawing.Point(3, 68)
            Me.picTitle1.Name = "picTitle1"
            Me.picTitle1.Size = New System.Drawing.Size(804, 26)
            Me.picTitle1.TabIndex = 1821
            Me.picTitle1.TabStop = False
            '
            'picBar2
            '
            Me.picBar2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar2.BackColor = System.Drawing.Color.DarkGray
            Me.picBar2.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.picBar2.Location = New System.Drawing.Point(3, 360)
            Me.picBar2.Name = "picBar2"
            Me.picBar2.Size = New System.Drawing.Size(804, 2)
            Me.picBar2.TabIndex = 1826
            Me.picBar2.TabStop = False
            Me.picBar2.Visible = False
            '
            'picBar
            '
            Me.picBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picBar.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picBar.Cursor = System.Windows.Forms.Cursors.HSplit
            Me.picBar.Location = New System.Drawing.Point(3, 436)
            Me.picBar.Name = "picBar"
            Me.picBar.Size = New System.Drawing.Size(804, 3)
            Me.picBar.TabIndex = 1825
            Me.picBar.TabStop = False
            '
            'chkAll
            '
            Me.chkAll.AutoSize = True
            Me.chkAll.CaptionName = Nothing
            Me.chkAll.Location = New System.Drawing.Point(824, 13)
            Me.chkAll.Name = "chkAll"
            Me.chkAll.ReadOnlys = False
            Me.chkAll.Size = New System.Drawing.Size(48, 16)
            Me.chkAll.TabIndex = 1827
            Me.chkAll.Tag = Nothing
            Me.chkAll.Text = "전체"
            Me.chkAll.TextValue = "0"
            Me.chkAll.UseVisualStyleBackColor = True
            '
            'btnBatchApply
            '
            Me.btnBatchApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.btnBatchApply.Location = New System.Drawing.Point(715, 441)
            Me.btnBatchApply.Name = "btnBatchApply"
            Me.btnBatchApply.Size = New System.Drawing.Size(75, 23)
            Me.btnBatchApply.TabIndex = 1828
            Me.btnBatchApply.Text = "일괄 적용"
            Me.btnBatchApply.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.LightGray
            Me.Label1.Location = New System.Drawing.Point(544, 445)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(58, 15)
            Me.Label1.TabIndex = 1830
            Me.Label1.Text = "명단일자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpDisYearMonth
            '
            Me.dtpDisYearMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.dtpDisYearMonth.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDisYearMonth.BorderColor = System.Drawing.Color.Empty
            Me.dtpDisYearMonth.BorderStyle = 2
            Me.dtpDisYearMonth.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDisYearMonth.CaptionName = "회계 일자"
            Me.dtpDisYearMonth.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpDisYearMonth.Location = New System.Drawing.Point(606, 442)
            Me.dtpDisYearMonth.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDisYearMonth.MaxLength = 0
            Me.dtpDisYearMonth.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDisYearMonth.Name = "dtpDisYearMonth"
            Me.dtpDisYearMonth.ReadOnlys = False
            Me.dtpDisYearMonth.SelectedText = ""
            Me.dtpDisYearMonth.SelectionLength = 0
            Me.dtpDisYearMonth.SelectionStart = 0
            Me.dtpDisYearMonth.Size = New System.Drawing.Size(104, 20)
            Me.dtpDisYearMonth.TabIndex = 1831
            Me.dtpDisYearMonth.Tag = "need;format(&&&&-&&-&&)"
            Me.dtpDisYearMonth.TextAlign = 0
            Me.dtpDisYearMonth.TextValue = ""
            Me.dtpDisYearMonth.ToolTipText = ""
            '
            'PNE501
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpDisYearMonth)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.btnBatchApply)
            Me.Controls.Add(Me.chkAll)
            Me.Controls.Add(Me.picBar2)
            Me.Controls.Add(Me.picBar)
            Me.Controls.Add(Me.lblTitle2)
            Me.Controls.Add(Me.lblTitle1)
            Me.Controls.Add(Me.numBaseDay_R)
            Me.Controls.Add(Me.grd_2)
            Me.Controls.Add(Me.popEmployeeExpNum_R)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.popCompanyCd_R)
            Me.Controls.Add(Me.lbl확장처)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.cboBillDivCd_R)
            Me.Controls.Add(Me.dtpProcYM_R)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.lblFormDivisionCode)
            Me.Controls.Add(Me.picCriteria)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picTitle2)
            Me.Controls.Add(Me.picTitle1)
            Me.Name = "PNE501"
            Me.Size = New System.Drawing.Size(811, 647)
            Me.Controls.SetChildIndex(Me.picTitle1, 0)
            Me.Controls.SetChildIndex(Me.picTitle2, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria, 0)
            Me.Controls.SetChildIndex(Me.lblFormDivisionCode, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.dtpProcYM_R, 0)
            Me.Controls.SetChildIndex(Me.cboBillDivCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.lbl확장처, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd_R, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeExpNum_R, 0)
            Me.Controls.SetChildIndex(Me.grd_2, 0)
            Me.Controls.SetChildIndex(Me.numBaseDay_R, 0)
            Me.Controls.SetChildIndex(Me.lblTitle1, 0)
            Me.Controls.SetChildIndex(Me.lblTitle2, 0)
            Me.Controls.SetChildIndex(Me.picBar, 0)
            Me.Controls.SetChildIndex(Me.picBar2, 0)
            Me.Controls.SetChildIndex(Me.chkAll, 0)
            Me.Controls.SetChildIndex(Me.btnBatchApply, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.dtpDisYearMonth, 0)
            CType(Me.picCriteria, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.grd_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picTitle1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picBar, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents dtpProcYM_R As ubiLease.CommonControls.dtp
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents lblFormDivisionCode As System.Windows.Forms.Label
        Friend WithEvents picCriteria As System.Windows.Forms.PictureBox
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents cboBillDivCd_R As ubiLease.CommonControls.cbo
        Friend WithEvents popCompanyCd_R As ubiLease.CommonControls.pop
        Friend WithEvents lbl확장처 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeExpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents grd_2 As ubiLease.GridControl.grd
        Friend WithEvents numBaseDay_R As ubiLease.CommonControls.num
        Friend WithEvents lblTitle2 As System.Windows.Forms.Label
        Friend WithEvents picTitle2 As System.Windows.Forms.PictureBox
        Friend WithEvents lblTitle1 As System.Windows.Forms.Label
        Friend WithEvents picTitle1 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar2 As System.Windows.Forms.PictureBox
        Friend WithEvents picBar As System.Windows.Forms.PictureBox
        Friend WithEvents chkAll As ubiLease.CommonControls.chk
        Friend WithEvents btnBatchApply As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpDisYearMonth As ubiLease.CommonControls.dtp


    End Class

End Namespace
