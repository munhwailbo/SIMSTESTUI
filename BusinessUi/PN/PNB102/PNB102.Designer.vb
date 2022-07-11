Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNB102
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNB102))
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.lblBranchNm = New System.Windows.Forms.Label
            Me.lblBaseDt = New System.Windows.Forms.Label
            Me.dtpBaseDt = New ubiLease.CommonControls.dtp
            Me.Opt2 = New ubiLease.CommonControls.opt
            Me.optsend = New System.Windows.Forms.RadioButton
            Me.optBranchHp = New System.Windows.Forms.RadioButton
            Me.optMonthDepositBack = New System.Windows.Forms.RadioButton
            Me.optMonAmtList = New System.Windows.Forms.RadioButton
            Me.optMonthTotal = New System.Windows.Forms.RadioButton
            Me.Label1 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.picIo_2_1 = New System.Windows.Forms.PictureBox
            Me.lblDeliveryBranchCd = New System.Windows.Forms.Label
            Me.dtpTransferDate = New ubiLease.CommonControls.dtp
            Me.Label2 = New System.Windows.Forms.Label
            Me.numTransferNum = New ubiLease.CommonControls.num
            Me.Label40 = New System.Windows.Forms.Label
            Me.popProcessDivCd = New ubiLease.CommonControls.pop
            Me.Label19 = New System.Windows.Forms.Label
            Me.popContractDivCd = New ubiLease.CommonControls.pop
            Me.Label3 = New System.Windows.Forms.Label
            Me.popBranchCd = New ubiLease.CommonControls.pop
            Me.lblNote = New System.Windows.Forms.Label
            Me.txtOwnerNm = New ubiLease.CommonControls.txt
            Me.lblPhoneNumber = New System.Windows.Forms.Label
            Me.txtOwnerPhoneNum = New ubiLease.CommonControls.txt
            Me.popPostNum = New ubiLease.CommonControls.pop
            Me.txtAddr2 = New ubiLease.CommonControls.txt
            Me.lblOldPostNum = New System.Windows.Forms.Label
            Me.lblOldAddr2 = New System.Windows.Forms.Label
            Me.txtAddr1 = New ubiLease.CommonControls.txt
            Me.numSiteArea = New ubiLease.CommonControls.num
            Me.Label4 = New System.Windows.Forms.Label
            Me.numBuildingArea = New ubiLease.CommonControls.num
            Me.Label43 = New System.Windows.Forms.Label
            Me.numUseArea = New ubiLease.CommonControls.num
            Me.Label5 = New System.Windows.Forms.Label
            Me.Label6 = New System.Windows.Forms.Label
            Me.txtLimitedItem = New ubiLease.CommonControls.txt
            Me.Label7 = New System.Windows.Forms.Label
            Me.txtObligation = New ubiLease.CommonControls.txt
            Me.Label8 = New System.Windows.Forms.Label
            Me.dtpContractStDt = New ubiLease.CommonControls.dtp
            Me.Label9 = New System.Windows.Forms.Label
            Me.dtpContractEdDt = New ubiLease.CommonControls.dtp
            Me.Label10 = New System.Windows.Forms.Label
            Me.Label11 = New System.Windows.Forms.Label
            Me.txtSecurityOwnerNm = New ubiLease.CommonControls.txt
            Me.txtSecurityLimitedItem = New ubiLease.CommonControls.txt
            Me.Label12 = New System.Windows.Forms.Label
            Me.numSecuritySiteArea = New ubiLease.CommonControls.num
            Me.Label13 = New System.Windows.Forms.Label
            Me.numSecurityBuildingArea = New ubiLease.CommonControls.num
            Me.Label14 = New System.Windows.Forms.Label
            Me.txtSecurityAddr1 = New ubiLease.CommonControls.txt
            Me.popSecurityPostNum = New ubiLease.CommonControls.pop
            Me.txtSecurityAddr2 = New ubiLease.CommonControls.txt
            Me.Label15 = New System.Windows.Forms.Label
            Me.Label16 = New System.Windows.Forms.Label
            Me.numRentAmt = New ubiLease.CommonControls.num
            Me.Label17 = New System.Windows.Forms.Label
            Me.numRentDepositAmt = New ubiLease.CommonControls.num
            Me.Label18 = New System.Windows.Forms.Label
            Me.popBankCd = New ubiLease.CommonControls.pop
            Me.Label20 = New System.Windows.Forms.Label
            Me.txtDepositorNm = New ubiLease.CommonControls.txt
            Me.Label21 = New System.Windows.Forms.Label
            Me.txtAccountNum = New ubiLease.CommonControls.txt
            Me.Label22 = New System.Windows.Forms.Label
            Me.txtOwnerRelation = New ubiLease.CommonControls.txt
            Me.Label23 = New System.Windows.Forms.Label
            Me.txtFloor = New ubiLease.CommonControls.txt
            Me.picIo_2_3 = New System.Windows.Forms.PictureBox
            Me.Label24 = New System.Windows.Forms.Label
            Me.Label25 = New System.Windows.Forms.Label
            Me.picIo_2_2 = New System.Windows.Forms.PictureBox
            Me.Label26 = New System.Windows.Forms.Label
            Me.lblRecordState = New System.Windows.Forms.Label
            Me.Label27 = New System.Windows.Forms.Label
            Me.Label28 = New System.Windows.Forms.Label
            Me.Label29 = New System.Windows.Forms.Label
            Me.chkdeferPaymentYn = New ubiLease.CommonControls.chk
            Me.chkVatYn = New ubiLease.CommonControls.chk
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Opt2.SuspendLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'grd_1
            '
            Me.grd_1.AllowBigSelection = False
            Me.grd_1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Both
            Me.grd_1.AllowUserResizing = C1.Win.C1FlexGrid.Classic.AllowUserResizeSettings.flexResizeColumns
            Me.grd_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
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
            Me.grd_1.Location = New System.Drawing.Point(4, 401)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(803, 270)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 69
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(4, 5)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 42)
            Me.picCriteria_1.TabIndex = 9
            Me.picCriteria_1.TabStop = False
            '
            'lblBranchNm
            '
            Me.lblBranchNm.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBranchNm.Location = New System.Drawing.Point(250, 16)
            Me.lblBranchNm.Name = "lblBranchNm"
            Me.lblBranchNm.Size = New System.Drawing.Size(54, 20)
            Me.lblBranchNm.TabIndex = 34
            Me.lblBranchNm.Text = "지국코드"
            Me.lblBranchNm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblBaseDt
            '
            Me.lblBaseDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblBaseDt.Location = New System.Drawing.Point(49, 16)
            Me.lblBaseDt.Name = "lblBaseDt"
            Me.lblBaseDt.Size = New System.Drawing.Size(53, 20)
            Me.lblBaseDt.TabIndex = 33
            Me.lblBaseDt.Text = "기준일자"
            Me.lblBaseDt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'dtpBaseDt
            '
            Me.dtpBaseDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpBaseDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpBaseDt.BorderStyle = 2
            Me.dtpBaseDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpBaseDt.CaptionName = "기준일자"
            Me.dtpBaseDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpBaseDt.Location = New System.Drawing.Point(108, 16)
            Me.dtpBaseDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpBaseDt.MaxLength = 0
            Me.dtpBaseDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpBaseDt.Name = "dtpBaseDt"
            Me.dtpBaseDt.ReadOnlys = False
            Me.dtpBaseDt.SelectedText = ""
            Me.dtpBaseDt.SelectionLength = 0
            Me.dtpBaseDt.SelectionStart = 0
            Me.dtpBaseDt.Size = New System.Drawing.Size(100, 20)
            Me.dtpBaseDt.TabIndex = 0
            Me.dtpBaseDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpBaseDt.TextAlign = 0
            Me.dtpBaseDt.TextValue = ""
            Me.dtpBaseDt.ToolTipText = ""
            '
            'Opt2
            '
            Me.Opt2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Opt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Opt2.CaptionName = Nothing
            Me.Opt2.Controls.Add(Me.optsend)
            Me.Opt2.Controls.Add(Me.optBranchHp)
            Me.Opt2.Controls.Add(Me.optMonthDepositBack)
            Me.Opt2.Controls.Add(Me.optMonAmtList)
            Me.Opt2.Controls.Add(Me.optMonthTotal)
            Me.Opt2.Location = New System.Drawing.Point(4, 50)
            Me.Opt2.MaximumSize = New System.Drawing.Size(600, 60)
            Me.Opt2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.Opt2.Name = "Opt2"
            Me.Opt2.ReadOnlys = False
            Me.Opt2.Size = New System.Drawing.Size(600, 46)
            Me.Opt2.TabIndex = 35
            Me.Opt2.Tag = Nothing
            Me.Opt2.TextValue = ""
            '
            'optsend
            '
            Me.optsend.AutoSize = True
            Me.optsend.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optsend.Location = New System.Drawing.Point(392, 4)
            Me.optsend.Name = "optsend"
            Me.optsend.Size = New System.Drawing.Size(175, 16)
            Me.optsend.TabIndex = 2
            Me.optsend.Text = "지국사무실 임차료 송금내역"
            Me.optsend.UseVisualStyleBackColor = False
            '
            'optBranchHp
            '
            Me.optBranchHp.AutoSize = True
            Me.optBranchHp.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optBranchHp.Location = New System.Drawing.Point(197, 23)
            Me.optBranchHp.Name = "optBranchHp"
            Me.optBranchHp.Size = New System.Drawing.Size(135, 16)
            Me.optBranchHp.TabIndex = 4
            Me.optBranchHp.Text = "지국사무실 지원현황"
            Me.optBranchHp.UseVisualStyleBackColor = False
            '
            'optMonthDepositBack
            '
            Me.optMonthDepositBack.AutoSize = True
            Me.optMonthDepositBack.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMonthDepositBack.Location = New System.Drawing.Point(14, 23)
            Me.optMonthDepositBack.Name = "optMonthDepositBack"
            Me.optMonthDepositBack.Size = New System.Drawing.Size(167, 16)
            Me.optMonthDepositBack.TabIndex = 3
            Me.optMonthDepositBack.Text = "폐지국임차보증금회수현황"
            Me.optMonthDepositBack.UseVisualStyleBackColor = False
            '
            'optMonAmtList
            '
            Me.optMonAmtList.AutoSize = True
            Me.optMonAmtList.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMonAmtList.Checked = True
            Me.optMonAmtList.Location = New System.Drawing.Point(14, 4)
            Me.optMonAmtList.Name = "optMonAmtList"
            Me.optMonAmtList.Size = New System.Drawing.Size(167, 16)
            Me.optMonAmtList.TabIndex = 0
            Me.optMonAmtList.TabStop = True
            Me.optMonAmtList.Text = "지국사무실임차료지급내역"
            Me.optMonAmtList.UseVisualStyleBackColor = False
            '
            'optMonthTotal
            '
            Me.optMonthTotal.AutoSize = True
            Me.optMonthTotal.BackColor = System.Drawing.Color.WhiteSmoke
            Me.optMonthTotal.Location = New System.Drawing.Point(197, 4)
            Me.optMonthTotal.Name = "optMonthTotal"
            Me.optMonthTotal.Size = New System.Drawing.Size(179, 16)
            Me.optMonthTotal.TabIndex = 1
            Me.optMonthTotal.Text = "지국사무실임차료현황총괄표"
            Me.optMonthTotal.UseVisualStyleBackColor = False
            '
            'Label1
            '
            Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.ForeColor = System.Drawing.SystemColors.WindowFrame
            Me.Label1.Location = New System.Drawing.Point(619, 55)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(179, 35)
            Me.Label1.TabIndex = 36
            Me.Label1.Text = "출력을 원하시는 항목을 선택 후 미리보기/인쇄 메뉴를 선택하세요."
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(607, 50)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(200, 46)
            Me.PictureBox1.TabIndex = 1672
            Me.PictureBox1.TabStop = False
            '
            'popBranchCd_R
            '
            Me.popBranchCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd_R.BorderStyle = 2
            Me.popBranchCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd_R.CaptionName = "투입 지국 코드"
            Me.popBranchCd_R.CodeText = ""
            Me.popBranchCd_R.CodeWidth = 80
            Me.popBranchCd_R.Location = New System.Drawing.Point(308, 16)
            Me.popBranchCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd_R.MaxLength = 7
            Me.popBranchCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd_R.Name = "popBranchCd_R"
            Me.popBranchCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd_R.NameText = ""
            Me.popBranchCd_R.ReadOnlys = False
            Me.popBranchCd_R.SelectedText = ""
            Me.popBranchCd_R.SelectionLength = 0
            Me.popBranchCd_R.SelectionStart = 0
            Me.popBranchCd_R.Size = New System.Drawing.Size(296, 20)
            Me.popBranchCd_R.TabIndex = 1
            Me.popBranchCd_R.Tag = "code(지국코드)"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            '
            'picIo_2_1
            '
            Me.picIo_2_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_1.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_1.Location = New System.Drawing.Point(4, 100)
            Me.picIo_2_1.Name = "picIo_2_1"
            Me.picIo_2_1.Size = New System.Drawing.Size(803, 167)
            Me.picIo_2_1.TabIndex = 1675
            Me.picIo_2_1.TabStop = False
            '
            'lblDeliveryBranchCd
            '
            Me.lblDeliveryBranchCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblDeliveryBranchCd.Location = New System.Drawing.Point(12, 127)
            Me.lblDeliveryBranchCd.Name = "lblDeliveryBranchCd"
            Me.lblDeliveryBranchCd.Size = New System.Drawing.Size(70, 18)
            Me.lblDeliveryBranchCd.TabIndex = 38
            Me.lblDeliveryBranchCd.Text = "지국코드"
            Me.lblDeliveryBranchCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpTransferDate
            '
            Me.dtpTransferDate.BackColor = System.Drawing.SystemColors.Window
            Me.dtpTransferDate.BorderColor = System.Drawing.Color.Empty
            Me.dtpTransferDate.BorderStyle = 2
            Me.dtpTransferDate.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpTransferDate.CaptionName = "발행 일자"
            Me.dtpTransferDate.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpTransferDate.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpTransferDate.Location = New System.Drawing.Point(300, 126)
            Me.dtpTransferDate.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpTransferDate.MaxLength = 0
            Me.dtpTransferDate.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpTransferDate.Name = "dtpTransferDate"
            Me.dtpTransferDate.ReadOnlys = False
            Me.dtpTransferDate.SelectedText = ""
            Me.dtpTransferDate.SelectionLength = 0
            Me.dtpTransferDate.SelectionStart = 0
            Me.dtpTransferDate.Size = New System.Drawing.Size(100, 20)
            Me.dtpTransferDate.TabIndex = 3
            Me.dtpTransferDate.Tag = "format(&&&&-&&-&&);"
            Me.dtpTransferDate.TextAlign = 0
            Me.dtpTransferDate.TextValue = ""
            Me.dtpTransferDate.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.GhostWhite
            Me.Label2.Location = New System.Drawing.Point(233, 129)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(59, 15)
            Me.Label2.TabIndex = 39
            Me.Label2.Text = "관리일자"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'numTransferNum
            '
            Me.numTransferNum.BackColor = System.Drawing.SystemColors.Window
            Me.numTransferNum.BorderColor = System.Drawing.Color.Empty
            Me.numTransferNum.BorderStyle = 2
            Me.numTransferNum.CaptionName = Nothing
            Me.numTransferNum.Enabled = False
            Me.numTransferNum.LengthPrecision = 15
            Me.numTransferNum.LengthScale = 0
            Me.numTransferNum.Location = New System.Drawing.Point(489, 126)
            Me.numTransferNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numTransferNum.MaxLength = 32767
            Me.numTransferNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numTransferNum.Name = "numTransferNum"
            Me.numTransferNum.ReadOnlys = False
            Me.numTransferNum.SelectedText = ""
            Me.numTransferNum.SelectionLength = 0
            Me.numTransferNum.SelectionStart = 1
            Me.numTransferNum.Size = New System.Drawing.Size(86, 20)
            Me.numTransferNum.TabIndex = 4
            Me.numTransferNum.Tag = Nothing
            Me.numTransferNum.TextValue = "0"
            Me.numTransferNum.ToolTipText = ""
            '
            'Label40
            '
            Me.Label40.BackColor = System.Drawing.Color.GhostWhite
            Me.Label40.Location = New System.Drawing.Point(418, 127)
            Me.Label40.Name = "Label40"
            Me.Label40.Size = New System.Drawing.Size(65, 18)
            Me.Label40.TabIndex = 40
            Me.Label40.Text = "이전횟수"
            Me.Label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popProcessDivCd
            '
            Me.popProcessDivCd.BorderColor = System.Drawing.Color.Empty
            Me.popProcessDivCd.BorderStyle = 2
            Me.popProcessDivCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popProcessDivCd.CaptionName = "처리구분코드"
            Me.popProcessDivCd.CodeText = ""
            Me.popProcessDivCd.CodeWidth = 30
            Me.popProcessDivCd.Location = New System.Drawing.Point(300, 172)
            Me.popProcessDivCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popProcessDivCd.MaxLength = 1
            Me.popProcessDivCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popProcessDivCd.Name = "popProcessDivCd"
            Me.popProcessDivCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popProcessDivCd.NameText = ""
            Me.popProcessDivCd.ReadOnlys = False
            Me.popProcessDivCd.SelectedText = ""
            Me.popProcessDivCd.SelectionLength = 0
            Me.popProcessDivCd.SelectionStart = 0
            Me.popProcessDivCd.Size = New System.Drawing.Size(100, 20)
            Me.popProcessDivCd.TabIndex = 11
            Me.popProcessDivCd.Tag = "code(지국사무실처리구분코드);"
            Me.popProcessDivCd.TextAlign = 0
            Me.popProcessDivCd.TextValue = ""
            Me.popProcessDivCd.ToolTipText = ""
            '
            'Label19
            '
            Me.Label19.BackColor = System.Drawing.Color.GhostWhite
            Me.Label19.Location = New System.Drawing.Point(233, 173)
            Me.Label19.Name = "Label19"
            Me.Label19.Size = New System.Drawing.Size(59, 18)
            Me.Label19.TabIndex = 48
            Me.Label19.Text = "처리구분"
            Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popContractDivCd
            '
            Me.popContractDivCd.BorderColor = System.Drawing.Color.Empty
            Me.popContractDivCd.BorderStyle = 2
            Me.popContractDivCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popContractDivCd.CaptionName = "계약구분 코드"
            Me.popContractDivCd.CodeText = ""
            Me.popContractDivCd.CodeWidth = 30
            Me.popContractDivCd.Location = New System.Drawing.Point(87, 172)
            Me.popContractDivCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popContractDivCd.MaxLength = 1
            Me.popContractDivCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popContractDivCd.Name = "popContractDivCd"
            Me.popContractDivCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popContractDivCd.NameText = ""
            Me.popContractDivCd.ReadOnlys = False
            Me.popContractDivCd.SelectedText = ""
            Me.popContractDivCd.SelectionLength = 0
            Me.popContractDivCd.SelectionStart = 0
            Me.popContractDivCd.Size = New System.Drawing.Size(139, 20)
            Me.popContractDivCd.TabIndex = 10
            Me.popContractDivCd.Tag = "code(지국사무실계약구분코드);"
            Me.popContractDivCd.TextAlign = 0
            Me.popContractDivCd.TextValue = ""
            Me.popContractDivCd.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(12, 173)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(70, 18)
            Me.Label3.TabIndex = 46
            Me.Label3.Text = "계약구분"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBranchCd
            '
            Me.popBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd.BorderStyle = 2
            Me.popBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd.CaptionName = "국지 코드"
            Me.popBranchCd.CodeText = ""
            Me.popBranchCd.CodeWidth = 50
            Me.popBranchCd.Location = New System.Drawing.Point(87, 126)
            Me.popBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd.MaxLength = 7
            Me.popBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd.Name = "popBranchCd"
            Me.popBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd.NameText = ""
            Me.popBranchCd.ReadOnlys = False
            Me.popBranchCd.SelectedText = ""
            Me.popBranchCd.SelectionLength = 0
            Me.popBranchCd.SelectionStart = 0
            Me.popBranchCd.Size = New System.Drawing.Size(139, 20)
            Me.popBranchCd.TabIndex = 2
            Me.popBranchCd.Tag = "code(지국코드);"
            Me.popBranchCd.TextAlign = 0
            Me.popBranchCd.TextValue = ""
            Me.popBranchCd.ToolTipText = ""
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Location = New System.Drawing.Point(12, 241)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(70, 18)
            Me.lblNote.TabIndex = 47
            Me.lblNote.Text = "소유주명"
            Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtOwnerNm
            '
            Me.txtOwnerNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtOwnerNm.BorderColor = System.Drawing.Color.Empty
            Me.txtOwnerNm.BorderStyle = 2
            Me.txtOwnerNm.CaptionName = ""
            Me.txtOwnerNm.Location = New System.Drawing.Point(87, 240)
            Me.txtOwnerNm.MaxLength = 12
            Me.txtOwnerNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOwnerNm.Multiline = False
            Me.txtOwnerNm.Name = "txtOwnerNm"
            Me.txtOwnerNm.ReadOnlys = False
            Me.txtOwnerNm.SelectedText = ""
            Me.txtOwnerNm.SelectionLength = 0
            Me.txtOwnerNm.SelectionStart = 0
            Me.txtOwnerNm.Size = New System.Drawing.Size(108, 20)
            Me.txtOwnerNm.TabIndex = 20
            Me.txtOwnerNm.Tag = ""
            Me.txtOwnerNm.TextAlign = 0
            Me.txtOwnerNm.TextValue = ""
            Me.txtOwnerNm.ToolTipText = ""
            '
            'lblPhoneNumber
            '
            Me.lblPhoneNumber.BackColor = System.Drawing.Color.GhostWhite
            Me.lblPhoneNumber.Location = New System.Drawing.Point(203, 241)
            Me.lblPhoneNumber.Name = "lblPhoneNumber"
            Me.lblPhoneNumber.Size = New System.Drawing.Size(89, 18)
            Me.lblPhoneNumber.TabIndex = 56
            Me.lblPhoneNumber.Text = "건물주연락처"
            Me.lblPhoneNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtOwnerPhoneNum
            '
            Me.txtOwnerPhoneNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtOwnerPhoneNum.BorderColor = System.Drawing.Color.Empty
            Me.txtOwnerPhoneNum.BorderStyle = 2
            Me.txtOwnerPhoneNum.CaptionName = "건물주연락처"
            Me.txtOwnerPhoneNum.Location = New System.Drawing.Point(300, 240)
            Me.txtOwnerPhoneNum.MaxLength = 14
            Me.txtOwnerPhoneNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOwnerPhoneNum.Multiline = False
            Me.txtOwnerPhoneNum.Name = "txtOwnerPhoneNum"
            Me.txtOwnerPhoneNum.ReadOnlys = False
            Me.txtOwnerPhoneNum.SelectedText = ""
            Me.txtOwnerPhoneNum.SelectionLength = 0
            Me.txtOwnerPhoneNum.SelectionStart = 0
            Me.txtOwnerPhoneNum.Size = New System.Drawing.Size(100, 20)
            Me.txtOwnerPhoneNum.TabIndex = 21
            Me.txtOwnerPhoneNum.Tag = ""
            Me.txtOwnerPhoneNum.TextAlign = 0
            Me.txtOwnerPhoneNum.TextValue = ""
            Me.txtOwnerPhoneNum.ToolTipText = ""
            '
            'popPostNum
            '
            Me.popPostNum.BorderColor = System.Drawing.Color.Empty
            Me.popPostNum.BorderStyle = 2
            Me.popPostNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popPostNum.CaptionName = "구우편번호"
            Me.popPostNum.CodeText = ""
            Me.popPostNum.CodeWidth = 50
            Me.popPostNum.Location = New System.Drawing.Point(87, 196)
            Me.popPostNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popPostNum.MaxLength = 6
            Me.popPostNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popPostNum.Name = "popPostNum"
            Me.popPostNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popPostNum.NameText = ""
            Me.popPostNum.ReadOnlys = False
            Me.popPostNum.SelectedText = ""
            Me.popPostNum.SelectionLength = 0
            Me.popPostNum.SelectionStart = 0
            Me.popPostNum.Size = New System.Drawing.Size(73, 20)
            Me.popPostNum.TabIndex = 13
            Me.popPostNum.Tag = "code(우편번호);rtnvalue(txtAddr1);"
            Me.popPostNum.TextAlign = 0
            Me.popPostNum.TextValue = ""
            Me.popPostNum.ToolTipText = ""
            '
            'txtAddr2
            '
            Me.txtAddr2.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddr2.BorderColor = System.Drawing.Color.Empty
            Me.txtAddr2.BorderStyle = 2
            Me.txtAddr2.CaptionName = "구주소"
            Me.txtAddr2.Location = New System.Drawing.Point(489, 196)
            Me.txtAddr2.MaxLength = 40
            Me.txtAddr2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddr2.Multiline = False
            Me.txtAddr2.Name = "txtAddr2"
            Me.txtAddr2.ReadOnlys = False
            Me.txtAddr2.SelectedText = ""
            Me.txtAddr2.SelectionLength = 0
            Me.txtAddr2.SelectionStart = 0
            Me.txtAddr2.Size = New System.Drawing.Size(302, 20)
            Me.txtAddr2.TabIndex = 15
            Me.txtAddr2.Tag = "need;"
            Me.txtAddr2.TextAlign = 0
            Me.txtAddr2.TextValue = ""
            Me.txtAddr2.ToolTipText = ""
            '
            'lblOldPostNum
            '
            Me.lblOldPostNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblOldPostNum.Location = New System.Drawing.Point(12, 197)
            Me.lblOldPostNum.Name = "lblOldPostNum"
            Me.lblOldPostNum.Size = New System.Drawing.Size(70, 18)
            Me.lblOldPostNum.TabIndex = 49
            Me.lblOldPostNum.Text = "우편번호"
            Me.lblOldPostNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblOldAddr2
            '
            Me.lblOldAddr2.BackColor = System.Drawing.Color.GhostWhite
            Me.lblOldAddr2.Location = New System.Drawing.Point(417, 197)
            Me.lblOldAddr2.Name = "lblOldAddr2"
            Me.lblOldAddr2.Size = New System.Drawing.Size(65, 18)
            Me.lblOldAddr2.TabIndex = 50
            Me.lblOldAddr2.Text = "상세주소"
            Me.lblOldAddr2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAddr1
            '
            Me.txtAddr1.BackColor = System.Drawing.SystemColors.Window
            Me.txtAddr1.BorderColor = System.Drawing.Color.Empty
            Me.txtAddr1.BorderStyle = 2
            Me.txtAddr1.CaptionName = "구주소"
            Me.txtAddr1.Location = New System.Drawing.Point(159, 196)
            Me.txtAddr1.MaxLength = 40
            Me.txtAddr1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAddr1.Multiline = False
            Me.txtAddr1.Name = "txtAddr1"
            Me.txtAddr1.ReadOnlys = False
            Me.txtAddr1.SelectedText = ""
            Me.txtAddr1.SelectionLength = 0
            Me.txtAddr1.SelectionStart = 0
            Me.txtAddr1.Size = New System.Drawing.Size(241, 20)
            Me.txtAddr1.TabIndex = 14
            Me.txtAddr1.Tag = ""
            Me.txtAddr1.TextAlign = 0
            Me.txtAddr1.TextValue = ""
            Me.txtAddr1.ToolTipText = ""
            '
            'numSiteArea
            '
            Me.numSiteArea.BackColor = System.Drawing.SystemColors.Window
            Me.numSiteArea.BorderColor = System.Drawing.Color.Empty
            Me.numSiteArea.BorderStyle = 2
            Me.numSiteArea.CaptionName = "대지 평수"
            Me.numSiteArea.LengthPrecision = 15
            Me.numSiteArea.LengthScale = 0
            Me.numSiteArea.Location = New System.Drawing.Point(87, 218)
            Me.numSiteArea.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numSiteArea.MaxLength = 32767
            Me.numSiteArea.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numSiteArea.Name = "numSiteArea"
            Me.numSiteArea.ReadOnlys = False
            Me.numSiteArea.SelectedText = ""
            Me.numSiteArea.SelectionLength = 0
            Me.numSiteArea.SelectionStart = 1
            Me.numSiteArea.Size = New System.Drawing.Size(76, 20)
            Me.numSiteArea.TabIndex = 16
            Me.numSiteArea.Tag = Nothing
            Me.numSiteArea.TextValue = "0"
            Me.numSiteArea.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.GhostWhite
            Me.Label4.Location = New System.Drawing.Point(12, 219)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(70, 18)
            Me.Label4.TabIndex = 51
            Me.Label4.Text = "대지면적"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numBuildingArea
            '
            Me.numBuildingArea.BackColor = System.Drawing.SystemColors.Window
            Me.numBuildingArea.BorderColor = System.Drawing.Color.Empty
            Me.numBuildingArea.BorderStyle = 2
            Me.numBuildingArea.CaptionName = "건물 평수"
            Me.numBuildingArea.LengthPrecision = 15
            Me.numBuildingArea.LengthScale = 0
            Me.numBuildingArea.Location = New System.Drawing.Point(300, 218)
            Me.numBuildingArea.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numBuildingArea.MaxLength = 32767
            Me.numBuildingArea.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numBuildingArea.Name = "numBuildingArea"
            Me.numBuildingArea.ReadOnlys = False
            Me.numBuildingArea.SelectedText = ""
            Me.numBuildingArea.SelectionLength = 0
            Me.numBuildingArea.SelectionStart = 1
            Me.numBuildingArea.Size = New System.Drawing.Size(76, 20)
            Me.numBuildingArea.TabIndex = 17
            Me.numBuildingArea.Tag = ""
            Me.numBuildingArea.TextValue = "0"
            Me.numBuildingArea.ToolTipText = ""
            '
            'Label43
            '
            Me.Label43.BackColor = System.Drawing.Color.GhostWhite
            Me.Label43.Location = New System.Drawing.Point(233, 219)
            Me.Label43.Name = "Label43"
            Me.Label43.Size = New System.Drawing.Size(59, 18)
            Me.Label43.TabIndex = 52
            Me.Label43.Text = "건물면적"
            Me.Label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numUseArea
            '
            Me.numUseArea.BackColor = System.Drawing.SystemColors.Window
            Me.numUseArea.BorderColor = System.Drawing.Color.Empty
            Me.numUseArea.BorderStyle = 2
            Me.numUseArea.CaptionName = "사용 평수"
            Me.numUseArea.LengthPrecision = 15
            Me.numUseArea.LengthScale = 0
            Me.numUseArea.Location = New System.Drawing.Point(489, 218)
            Me.numUseArea.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numUseArea.MaxLength = 32767
            Me.numUseArea.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numUseArea.Name = "numUseArea"
            Me.numUseArea.ReadOnlys = False
            Me.numUseArea.SelectedText = ""
            Me.numUseArea.SelectionLength = 0
            Me.numUseArea.SelectionStart = 1
            Me.numUseArea.Size = New System.Drawing.Size(76, 20)
            Me.numUseArea.TabIndex = 18
            Me.numUseArea.Tag = ""
            Me.numUseArea.TextValue = "0"
            Me.numUseArea.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(417, 219)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 18)
            Me.Label5.TabIndex = 53
            Me.Label5.Text = "사용면적"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label6
            '
            Me.Label6.BackColor = System.Drawing.Color.GhostWhite
            Me.Label6.Location = New System.Drawing.Point(613, 219)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(64, 18)
            Me.Label6.TabIndex = 41
            Me.Label6.Text = "층구분"
            Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtLimitedItem
            '
            Me.txtLimitedItem.BackColor = System.Drawing.SystemColors.Window
            Me.txtLimitedItem.BorderColor = System.Drawing.Color.Empty
            Me.txtLimitedItem.BorderStyle = 2
            Me.txtLimitedItem.CaptionName = "제한 물건"
            Me.txtLimitedItem.Location = New System.Drawing.Point(489, 240)
            Me.txtLimitedItem.MaxLength = 40
            Me.txtLimitedItem.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtLimitedItem.Multiline = False
            Me.txtLimitedItem.Name = "txtLimitedItem"
            Me.txtLimitedItem.ReadOnlys = False
            Me.txtLimitedItem.SelectedText = ""
            Me.txtLimitedItem.SelectionLength = 0
            Me.txtLimitedItem.SelectionStart = 0
            Me.txtLimitedItem.Size = New System.Drawing.Size(108, 20)
            Me.txtLimitedItem.TabIndex = 19
            Me.txtLimitedItem.Tag = ""
            Me.txtLimitedItem.TextAlign = 0
            Me.txtLimitedItem.TextValue = ""
            Me.txtLimitedItem.ToolTipText = ""
            '
            'Label7
            '
            Me.Label7.BackColor = System.Drawing.Color.GhostWhite
            Me.Label7.Location = New System.Drawing.Point(418, 241)
            Me.Label7.Name = "Label7"
            Me.Label7.Size = New System.Drawing.Size(64, 18)
            Me.Label7.TabIndex = 54
            Me.Label7.Text = "제한물건"
            Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtObligation
            '
            Me.txtObligation.BackColor = System.Drawing.SystemColors.Window
            Me.txtObligation.BorderColor = System.Drawing.Color.Empty
            Me.txtObligation.BorderStyle = 2
            Me.txtObligation.CaptionName = "채권 확보"
            Me.txtObligation.Location = New System.Drawing.Point(489, 172)
            Me.txtObligation.MaxLength = 40
            Me.txtObligation.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtObligation.Multiline = False
            Me.txtObligation.Name = "txtObligation"
            Me.txtObligation.ReadOnlys = False
            Me.txtObligation.SelectedText = ""
            Me.txtObligation.SelectionLength = 0
            Me.txtObligation.SelectionStart = 0
            Me.txtObligation.Size = New System.Drawing.Size(302, 20)
            Me.txtObligation.TabIndex = 12
            Me.txtObligation.Tag = ""
            Me.txtObligation.TextAlign = 0
            Me.txtObligation.TextValue = ""
            Me.txtObligation.ToolTipText = ""
            '
            'Label8
            '
            Me.Label8.BackColor = System.Drawing.Color.GhostWhite
            Me.Label8.Location = New System.Drawing.Point(413, 173)
            Me.Label8.Name = "Label8"
            Me.Label8.Size = New System.Drawing.Size(70, 18)
            Me.Label8.TabIndex = 55
            Me.Label8.Text = "채권확보"
            Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpContractStDt
            '
            Me.dtpContractStDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpContractStDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpContractStDt.BorderStyle = 2
            Me.dtpContractStDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpContractStDt.CaptionName = "계약 시작 일자"
            Me.dtpContractStDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpContractStDt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpContractStDt.Location = New System.Drawing.Point(489, 149)
            Me.dtpContractStDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpContractStDt.MaxLength = 0
            Me.dtpContractStDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpContractStDt.Name = "dtpContractStDt"
            Me.dtpContractStDt.ReadOnlys = False
            Me.dtpContractStDt.SelectedText = ""
            Me.dtpContractStDt.SelectionLength = 0
            Me.dtpContractStDt.SelectionStart = 0
            Me.dtpContractStDt.Size = New System.Drawing.Size(108, 20)
            Me.dtpContractStDt.TabIndex = 8
            Me.dtpContractStDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpContractStDt.TextAlign = 0
            Me.dtpContractStDt.TextValue = ""
            Me.dtpContractStDt.ToolTipText = ""
            '
            'Label9
            '
            Me.Label9.BackColor = System.Drawing.Color.GhostWhite
            Me.Label9.Location = New System.Drawing.Point(418, 152)
            Me.Label9.Name = "Label9"
            Me.Label9.Size = New System.Drawing.Size(65, 15)
            Me.Label9.TabIndex = 44
            Me.Label9.Text = "계약일자"
            Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'dtpContractEdDt
            '
            Me.dtpContractEdDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpContractEdDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpContractEdDt.BorderStyle = 2
            Me.dtpContractEdDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpContractEdDt.CaptionName = "계약 종료 일자"
            Me.dtpContractEdDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpContractEdDt.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.dtpContractEdDt.Location = New System.Drawing.Point(684, 149)
            Me.dtpContractEdDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpContractEdDt.MaxLength = 0
            Me.dtpContractEdDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpContractEdDt.Name = "dtpContractEdDt"
            Me.dtpContractEdDt.ReadOnlys = False
            Me.dtpContractEdDt.SelectedText = ""
            Me.dtpContractEdDt.SelectionLength = 0
            Me.dtpContractEdDt.SelectionStart = 0
            Me.dtpContractEdDt.Size = New System.Drawing.Size(108, 20)
            Me.dtpContractEdDt.TabIndex = 9
            Me.dtpContractEdDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpContractEdDt.TextAlign = 0
            Me.dtpContractEdDt.TextValue = ""
            Me.dtpContractEdDt.ToolTipText = ""
            '
            'Label10
            '
            Me.Label10.BackColor = System.Drawing.Color.GhostWhite
            Me.Label10.Location = New System.Drawing.Point(601, 152)
            Me.Label10.Name = "Label10"
            Me.Label10.Size = New System.Drawing.Size(81, 15)
            Me.Label10.TabIndex = 45
            Me.Label10.Text = "계약만료일자"
            Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight
            '
            'Label11
            '
            Me.Label11.BackColor = System.Drawing.Color.GhostWhite
            Me.Label11.Location = New System.Drawing.Point(620, 369)
            Me.Label11.Name = "Label11"
            Me.Label11.Size = New System.Drawing.Size(60, 18)
            Me.Label11.TabIndex = 68
            Me.Label11.Text = "소유주명"
            Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSecurityOwnerNm
            '
            Me.txtSecurityOwnerNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtSecurityOwnerNm.BorderColor = System.Drawing.Color.Empty
            Me.txtSecurityOwnerNm.BorderStyle = 2
            Me.txtSecurityOwnerNm.CaptionName = "(대물)소유주명"
            Me.txtSecurityOwnerNm.Location = New System.Drawing.Point(684, 368)
            Me.txtSecurityOwnerNm.MaxLength = 12
            Me.txtSecurityOwnerNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSecurityOwnerNm.Multiline = False
            Me.txtSecurityOwnerNm.Name = "txtSecurityOwnerNm"
            Me.txtSecurityOwnerNm.ReadOnlys = False
            Me.txtSecurityOwnerNm.SelectedText = ""
            Me.txtSecurityOwnerNm.SelectionLength = 0
            Me.txtSecurityOwnerNm.SelectionStart = 0
            Me.txtSecurityOwnerNm.Size = New System.Drawing.Size(108, 20)
            Me.txtSecurityOwnerNm.TabIndex = 33
            Me.txtSecurityOwnerNm.Tag = ""
            Me.txtSecurityOwnerNm.TextAlign = 0
            Me.txtSecurityOwnerNm.TextValue = ""
            Me.txtSecurityOwnerNm.ToolTipText = ""
            '
            'txtSecurityLimitedItem
            '
            Me.txtSecurityLimitedItem.BackColor = System.Drawing.SystemColors.Window
            Me.txtSecurityLimitedItem.BorderColor = System.Drawing.Color.Empty
            Me.txtSecurityLimitedItem.BorderStyle = 2
            Me.txtSecurityLimitedItem.CaptionName = "(대물)제한물건"
            Me.txtSecurityLimitedItem.Location = New System.Drawing.Point(489, 368)
            Me.txtSecurityLimitedItem.MaxLength = 40
            Me.txtSecurityLimitedItem.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSecurityLimitedItem.Multiline = False
            Me.txtSecurityLimitedItem.Name = "txtSecurityLimitedItem"
            Me.txtSecurityLimitedItem.ReadOnlys = False
            Me.txtSecurityLimitedItem.SelectedText = ""
            Me.txtSecurityLimitedItem.SelectionLength = 0
            Me.txtSecurityLimitedItem.SelectionStart = 0
            Me.txtSecurityLimitedItem.Size = New System.Drawing.Size(108, 20)
            Me.txtSecurityLimitedItem.TabIndex = 32
            Me.txtSecurityLimitedItem.Tag = ""
            Me.txtSecurityLimitedItem.TextAlign = 0
            Me.txtSecurityLimitedItem.TextValue = ""
            Me.txtSecurityLimitedItem.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(418, 369)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(65, 18)
            Me.Label12.TabIndex = 67
            Me.Label12.Text = "제한물건"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numSecuritySiteArea
            '
            Me.numSecuritySiteArea.BackColor = System.Drawing.SystemColors.Window
            Me.numSecuritySiteArea.BorderColor = System.Drawing.Color.Empty
            Me.numSecuritySiteArea.BorderStyle = 2
            Me.numSecuritySiteArea.CaptionName = "(대물)대지평수"
            Me.numSecuritySiteArea.LengthPrecision = 15
            Me.numSecuritySiteArea.LengthScale = 0
            Me.numSecuritySiteArea.Location = New System.Drawing.Point(87, 368)
            Me.numSecuritySiteArea.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numSecuritySiteArea.MaxLength = 32767
            Me.numSecuritySiteArea.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numSecuritySiteArea.Name = "numSecuritySiteArea"
            Me.numSecuritySiteArea.ReadOnlys = False
            Me.numSecuritySiteArea.SelectedText = ""
            Me.numSecuritySiteArea.SelectionLength = 0
            Me.numSecuritySiteArea.SelectionStart = 1
            Me.numSecuritySiteArea.Size = New System.Drawing.Size(94, 20)
            Me.numSecuritySiteArea.TabIndex = 30
            Me.numSecuritySiteArea.Tag = Nothing
            Me.numSecuritySiteArea.TextValue = "0"
            Me.numSecuritySiteArea.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.GhostWhite
            Me.Label13.Location = New System.Drawing.Point(12, 369)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(70, 18)
            Me.Label13.TabIndex = 65
            Me.Label13.Text = "대지평수"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numSecurityBuildingArea
            '
            Me.numSecurityBuildingArea.BackColor = System.Drawing.SystemColors.Window
            Me.numSecurityBuildingArea.BorderColor = System.Drawing.Color.Empty
            Me.numSecurityBuildingArea.BorderStyle = 2
            Me.numSecurityBuildingArea.CaptionName = "(대물)건물평수"
            Me.numSecurityBuildingArea.LengthPrecision = 15
            Me.numSecurityBuildingArea.LengthScale = 0
            Me.numSecurityBuildingArea.Location = New System.Drawing.Point(300, 368)
            Me.numSecurityBuildingArea.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numSecurityBuildingArea.MaxLength = 32767
            Me.numSecurityBuildingArea.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numSecurityBuildingArea.Name = "numSecurityBuildingArea"
            Me.numSecurityBuildingArea.ReadOnlys = False
            Me.numSecurityBuildingArea.SelectedText = ""
            Me.numSecurityBuildingArea.SelectionLength = 0
            Me.numSecurityBuildingArea.SelectionStart = 1
            Me.numSecurityBuildingArea.Size = New System.Drawing.Size(100, 20)
            Me.numSecurityBuildingArea.TabIndex = 31
            Me.numSecurityBuildingArea.Tag = ""
            Me.numSecurityBuildingArea.TextValue = "0"
            Me.numSecurityBuildingArea.ToolTipText = ""
            '
            'Label14
            '
            Me.Label14.BackColor = System.Drawing.Color.GhostWhite
            Me.Label14.Location = New System.Drawing.Point(233, 369)
            Me.Label14.Name = "Label14"
            Me.Label14.Size = New System.Drawing.Size(59, 18)
            Me.Label14.TabIndex = 66
            Me.Label14.Text = "건물평수"
            Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtSecurityAddr1
            '
            Me.txtSecurityAddr1.BackColor = System.Drawing.SystemColors.Window
            Me.txtSecurityAddr1.BorderColor = System.Drawing.Color.Empty
            Me.txtSecurityAddr1.BorderStyle = 2
            Me.txtSecurityAddr1.CaptionName = "(대물)주소1"
            Me.txtSecurityAddr1.Location = New System.Drawing.Point(159, 346)
            Me.txtSecurityAddr1.MaxLength = 40
            Me.txtSecurityAddr1.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSecurityAddr1.Multiline = False
            Me.txtSecurityAddr1.Name = "txtSecurityAddr1"
            Me.txtSecurityAddr1.ReadOnlys = False
            Me.txtSecurityAddr1.SelectedText = ""
            Me.txtSecurityAddr1.SelectionLength = 0
            Me.txtSecurityAddr1.SelectionStart = 0
            Me.txtSecurityAddr1.Size = New System.Drawing.Size(241, 20)
            Me.txtSecurityAddr1.TabIndex = 28
            Me.txtSecurityAddr1.Tag = ""
            Me.txtSecurityAddr1.TextAlign = 0
            Me.txtSecurityAddr1.TextValue = ""
            Me.txtSecurityAddr1.ToolTipText = ""
            '
            'popSecurityPostNum
            '
            Me.popSecurityPostNum.BorderColor = System.Drawing.Color.Empty
            Me.popSecurityPostNum.BorderStyle = 2
            Me.popSecurityPostNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popSecurityPostNum.CaptionName = "(대물)우편번호"
            Me.popSecurityPostNum.CodeText = ""
            Me.popSecurityPostNum.CodeWidth = 50
            Me.popSecurityPostNum.Location = New System.Drawing.Point(87, 346)
            Me.popSecurityPostNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popSecurityPostNum.MaxLength = 6
            Me.popSecurityPostNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popSecurityPostNum.Name = "popSecurityPostNum"
            Me.popSecurityPostNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popSecurityPostNum.NameText = ""
            Me.popSecurityPostNum.ReadOnlys = False
            Me.popSecurityPostNum.SelectedText = ""
            Me.popSecurityPostNum.SelectionLength = 0
            Me.popSecurityPostNum.SelectionStart = 0
            Me.popSecurityPostNum.Size = New System.Drawing.Size(72, 20)
            Me.popSecurityPostNum.TabIndex = 27
            Me.popSecurityPostNum.Tag = "code(우편번호);rtnvalue(txtSecurityAddr1);"
            Me.popSecurityPostNum.TextAlign = 0
            Me.popSecurityPostNum.TextValue = ""
            Me.popSecurityPostNum.ToolTipText = ""
            '
            'txtSecurityAddr2
            '
            Me.txtSecurityAddr2.BackColor = System.Drawing.SystemColors.Window
            Me.txtSecurityAddr2.BorderColor = System.Drawing.Color.Empty
            Me.txtSecurityAddr2.BorderStyle = 2
            Me.txtSecurityAddr2.CaptionName = "(대물)주소2"
            Me.txtSecurityAddr2.Location = New System.Drawing.Point(489, 346)
            Me.txtSecurityAddr2.MaxLength = 40
            Me.txtSecurityAddr2.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtSecurityAddr2.Multiline = False
            Me.txtSecurityAddr2.Name = "txtSecurityAddr2"
            Me.txtSecurityAddr2.ReadOnlys = False
            Me.txtSecurityAddr2.SelectedText = ""
            Me.txtSecurityAddr2.SelectionLength = 0
            Me.txtSecurityAddr2.SelectionStart = 0
            Me.txtSecurityAddr2.Size = New System.Drawing.Size(303, 20)
            Me.txtSecurityAddr2.TabIndex = 29
            Me.txtSecurityAddr2.Tag = ""
            Me.txtSecurityAddr2.TextAlign = 0
            Me.txtSecurityAddr2.TextValue = ""
            Me.txtSecurityAddr2.ToolTipText = ""
            '
            'Label15
            '
            Me.Label15.BackColor = System.Drawing.Color.GhostWhite
            Me.Label15.Location = New System.Drawing.Point(12, 347)
            Me.Label15.Name = "Label15"
            Me.Label15.Size = New System.Drawing.Size(70, 18)
            Me.Label15.TabIndex = 63
            Me.Label15.Text = "우편번호"
            Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label16
            '
            Me.Label16.BackColor = System.Drawing.Color.GhostWhite
            Me.Label16.Location = New System.Drawing.Point(418, 347)
            Me.Label16.Name = "Label16"
            Me.Label16.Size = New System.Drawing.Size(65, 18)
            Me.Label16.TabIndex = 64
            Me.Label16.Text = "상세주소"
            Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numRentAmt
            '
            Me.numRentAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numRentAmt.BorderColor = System.Drawing.Color.Empty
            Me.numRentAmt.BorderStyle = 2
            Me.numRentAmt.CaptionName = "임차료"
            Me.numRentAmt.LengthPrecision = 15
            Me.numRentAmt.LengthScale = 0
            Me.numRentAmt.Location = New System.Drawing.Point(300, 149)
            Me.numRentAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numRentAmt.MaxLength = 32767
            Me.numRentAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numRentAmt.Name = "numRentAmt"
            Me.numRentAmt.ReadOnlys = False
            Me.numRentAmt.SelectedText = ""
            Me.numRentAmt.SelectionLength = 0
            Me.numRentAmt.SelectionStart = 1
            Me.numRentAmt.Size = New System.Drawing.Size(100, 20)
            Me.numRentAmt.TabIndex = 7
            Me.numRentAmt.Tag = ""
            Me.numRentAmt.TextValue = "0"
            Me.numRentAmt.ToolTipText = ""
            '
            'Label17
            '
            Me.Label17.BackColor = System.Drawing.Color.GhostWhite
            Me.Label17.Location = New System.Drawing.Point(233, 150)
            Me.Label17.Name = "Label17"
            Me.Label17.Size = New System.Drawing.Size(59, 18)
            Me.Label17.TabIndex = 43
            Me.Label17.Text = "월세"
            Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numRentDepositAmt
            '
            Me.numRentDepositAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numRentDepositAmt.BorderColor = System.Drawing.Color.Empty
            Me.numRentDepositAmt.BorderStyle = 2
            Me.numRentDepositAmt.CaptionName = "임차 보증금"
            Me.numRentDepositAmt.LengthPrecision = 15
            Me.numRentDepositAmt.LengthScale = 0
            Me.numRentDepositAmt.Location = New System.Drawing.Point(87, 149)
            Me.numRentDepositAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numRentDepositAmt.MaxLength = 32767
            Me.numRentDepositAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numRentDepositAmt.Name = "numRentDepositAmt"
            Me.numRentDepositAmt.ReadOnlys = False
            Me.numRentDepositAmt.SelectedText = ""
            Me.numRentDepositAmt.SelectionLength = 0
            Me.numRentDepositAmt.SelectionStart = 1
            Me.numRentDepositAmt.Size = New System.Drawing.Size(139, 20)
            Me.numRentDepositAmt.TabIndex = 6
            Me.numRentDepositAmt.Tag = ""
            Me.numRentDepositAmt.TextValue = "0"
            Me.numRentDepositAmt.ToolTipText = ""
            '
            'Label18
            '
            Me.Label18.BackColor = System.Drawing.Color.GhostWhite
            Me.Label18.Location = New System.Drawing.Point(12, 150)
            Me.Label18.Name = "Label18"
            Me.Label18.Size = New System.Drawing.Size(70, 18)
            Me.Label18.TabIndex = 42
            Me.Label18.Text = "임차보증금"
            Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBankCd
            '
            Me.popBankCd.BorderColor = System.Drawing.Color.Empty
            Me.popBankCd.BorderStyle = 2
            Me.popBankCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBankCd.CaptionName = "은행코드"
            Me.popBankCd.CodeText = ""
            Me.popBankCd.CodeWidth = 50
            Me.popBankCd.Location = New System.Drawing.Point(143, 286)
            Me.popBankCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBankCd.MaxLength = 4
            Me.popBankCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBankCd.Name = "popBankCd"
            Me.popBankCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBankCd.NameText = ""
            Me.popBankCd.ReadOnlys = False
            Me.popBankCd.SelectedText = ""
            Me.popBankCd.SelectionLength = 0
            Me.popBankCd.SelectionStart = 0
            Me.popBankCd.Size = New System.Drawing.Size(257, 20)
            Me.popBankCd.TabIndex = 23
            Me.popBankCd.Tag = "code(은행코드);"
            Me.popBankCd.TextAlign = 0
            Me.popBankCd.TextValue = ""
            Me.popBankCd.ToolTipText = ""
            '
            'Label20
            '
            Me.Label20.BackColor = System.Drawing.Color.GhostWhite
            Me.Label20.Location = New System.Drawing.Point(82, 287)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(55, 18)
            Me.Label20.TabIndex = 59
            Me.Label20.Text = "은행코드"
            Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtDepositorNm
            '
            Me.txtDepositorNm.BackColor = System.Drawing.SystemColors.Window
            Me.txtDepositorNm.BorderColor = System.Drawing.Color.Empty
            Me.txtDepositorNm.BorderStyle = 2
            Me.txtDepositorNm.CaptionName = "예금주명"
            Me.txtDepositorNm.Location = New System.Drawing.Point(683, 286)
            Me.txtDepositorNm.MaxLength = 40
            Me.txtDepositorNm.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtDepositorNm.Multiline = False
            Me.txtDepositorNm.Name = "txtDepositorNm"
            Me.txtDepositorNm.ReadOnlys = False
            Me.txtDepositorNm.SelectedText = ""
            Me.txtDepositorNm.SelectionLength = 0
            Me.txtDepositorNm.SelectionStart = 0
            Me.txtDepositorNm.Size = New System.Drawing.Size(108, 20)
            Me.txtDepositorNm.TabIndex = 26
            Me.txtDepositorNm.Tag = ""
            Me.txtDepositorNm.TextAlign = 0
            Me.txtDepositorNm.TextValue = ""
            Me.txtDepositorNm.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(620, 287)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(60, 18)
            Me.Label21.TabIndex = 61
            Me.Label21.Text = "예금주명"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtAccountNum
            '
            Me.txtAccountNum.BackColor = System.Drawing.SystemColors.Window
            Me.txtAccountNum.BorderColor = System.Drawing.Color.Empty
            Me.txtAccountNum.BorderStyle = 2
            Me.txtAccountNum.CaptionName = "계좌번호"
            Me.txtAccountNum.Location = New System.Drawing.Point(489, 286)
            Me.txtAccountNum.MaxLength = 40
            Me.txtAccountNum.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtAccountNum.Multiline = False
            Me.txtAccountNum.Name = "txtAccountNum"
            Me.txtAccountNum.ReadOnlys = False
            Me.txtAccountNum.SelectedText = ""
            Me.txtAccountNum.SelectionLength = 0
            Me.txtAccountNum.SelectionStart = 0
            Me.txtAccountNum.Size = New System.Drawing.Size(116, 20)
            Me.txtAccountNum.TabIndex = 25
            Me.txtAccountNum.Tag = ""
            Me.txtAccountNum.TextAlign = 0
            Me.txtAccountNum.TextValue = ""
            Me.txtAccountNum.ToolTipText = ""
            '
            'Label22
            '
            Me.Label22.BackColor = System.Drawing.Color.GhostWhite
            Me.Label22.Location = New System.Drawing.Point(418, 287)
            Me.Label22.Name = "Label22"
            Me.Label22.Size = New System.Drawing.Size(65, 18)
            Me.Label22.TabIndex = 24
            Me.Label22.Text = "계좌번호"
            Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtOwnerRelation
            '
            Me.txtOwnerRelation.BackColor = System.Drawing.SystemColors.Window
            Me.txtOwnerRelation.BorderColor = System.Drawing.Color.Empty
            Me.txtOwnerRelation.BorderStyle = 2
            Me.txtOwnerRelation.CaptionName = "건물주와의 관계"
            Me.txtOwnerRelation.Location = New System.Drawing.Point(738, 240)
            Me.txtOwnerRelation.MaxLength = 40
            Me.txtOwnerRelation.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtOwnerRelation.Multiline = False
            Me.txtOwnerRelation.Name = "txtOwnerRelation"
            Me.txtOwnerRelation.ReadOnlys = False
            Me.txtOwnerRelation.SelectedText = ""
            Me.txtOwnerRelation.SelectionLength = 0
            Me.txtOwnerRelation.SelectionStart = 0
            Me.txtOwnerRelation.Size = New System.Drawing.Size(47, 20)
            Me.txtOwnerRelation.TabIndex = 22
            Me.txtOwnerRelation.Tag = ""
            Me.txtOwnerRelation.TextAlign = 0
            Me.txtOwnerRelation.TextValue = ""
            Me.txtOwnerRelation.ToolTipText = ""
            Me.txtOwnerRelation.Visible = False
            '
            'Label23
            '
            Me.Label23.BackColor = System.Drawing.Color.GhostWhite
            Me.Label23.Location = New System.Drawing.Point(631, 241)
            Me.Label23.Name = "Label23"
            Me.Label23.Size = New System.Drawing.Size(101, 18)
            Me.Label23.TabIndex = 57
            Me.Label23.Text = "건물주와의관계"
            Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.Label23.Visible = False
            '
            'txtFloor
            '
            Me.txtFloor.BackColor = System.Drawing.SystemColors.Window
            Me.txtFloor.BorderColor = System.Drawing.Color.Empty
            Me.txtFloor.BorderStyle = 2
            Me.txtFloor.CaptionName = "구주소"
            Me.txtFloor.Location = New System.Drawing.Point(684, 218)
            Me.txtFloor.MaxLength = 40
            Me.txtFloor.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtFloor.Multiline = False
            Me.txtFloor.Name = "txtFloor"
            Me.txtFloor.ReadOnlys = False
            Me.txtFloor.SelectedText = ""
            Me.txtFloor.SelectionLength = 0
            Me.txtFloor.SelectionStart = 0
            Me.txtFloor.Size = New System.Drawing.Size(108, 20)
            Me.txtFloor.TabIndex = 5
            Me.txtFloor.Tag = ""
            Me.txtFloor.TextAlign = 0
            Me.txtFloor.TextValue = ""
            Me.txtFloor.ToolTipText = ""
            '
            'picIo_2_3
            '
            Me.picIo_2_3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_3.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_3.Location = New System.Drawing.Point(4, 319)
            Me.picIo_2_3.Name = "picIo_2_3"
            Me.picIo_2_3.Size = New System.Drawing.Size(803, 78)
            Me.picIo_2_3.TabIndex = 1743
            Me.picIo_2_3.TabStop = False
            '
            'Label24
            '
            Me.Label24.BackColor = System.Drawing.Color.GhostWhite
            Me.Label24.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label24.Location = New System.Drawing.Point(12, 325)
            Me.Label24.Name = "Label24"
            Me.Label24.Size = New System.Drawing.Size(61, 18)
            Me.Label24.TabIndex = 62
            Me.Label24.Text = "대물담보"
            Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'Label25
            '
            Me.Label25.BackColor = System.Drawing.Color.GhostWhite
            Me.Label25.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label25.Location = New System.Drawing.Point(15, 276)
            Me.Label25.Name = "Label25"
            Me.Label25.Size = New System.Drawing.Size(61, 18)
            Me.Label25.TabIndex = 58
            Me.Label25.Text = "은행"
            Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'picIo_2_2
            '
            Me.picIo_2_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2_2.Location = New System.Drawing.Point(4, 271)
            Me.picIo_2_2.Name = "picIo_2_2"
            Me.picIo_2_2.Size = New System.Drawing.Size(803, 44)
            Me.picIo_2_2.TabIndex = 1746
            Me.picIo_2_2.TabStop = False
            '
            'Label26
            '
            Me.Label26.BackColor = System.Drawing.Color.GhostWhite
            Me.Label26.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label26.Location = New System.Drawing.Point(11, 104)
            Me.Label26.Name = "Label26"
            Me.Label26.Size = New System.Drawing.Size(71, 18)
            Me.Label26.TabIndex = 37
            Me.Label26.Text = "지국사무실"
            Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblRecordState
            '
            Me.lblRecordState.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblRecordState.Location = New System.Drawing.Point(738, 105)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(60, 18)
            Me.lblRecordState.TabIndex = 1747
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label27
            '
            Me.Label27.BackColor = System.Drawing.Color.GhostWhite
            Me.Label27.Location = New System.Drawing.Point(163, 219)
            Me.Label27.Name = "Label27"
            Me.Label27.Size = New System.Drawing.Size(44, 18)
            Me.Label27.TabIndex = 1748
            Me.Label27.Text = "m²(평)"
            Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label28
            '
            Me.Label28.BackColor = System.Drawing.Color.GhostWhite
            Me.Label28.Location = New System.Drawing.Point(374, 219)
            Me.Label28.Name = "Label28"
            Me.Label28.Size = New System.Drawing.Size(44, 18)
            Me.Label28.TabIndex = 1749
            Me.Label28.Text = "m²(평)"
            Me.Label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label29
            '
            Me.Label29.BackColor = System.Drawing.Color.GhostWhite
            Me.Label29.Location = New System.Drawing.Point(567, 219)
            Me.Label29.Name = "Label29"
            Me.Label29.Size = New System.Drawing.Size(44, 18)
            Me.Label29.TabIndex = 1750
            Me.Label29.Text = "m²(평)"
            Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'chkdeferPaymentYn
            '
            Me.chkdeferPaymentYn.AutoSize = True
            Me.chkdeferPaymentYn.BackColor = System.Drawing.SystemColors.Window
            Me.chkdeferPaymentYn.CaptionName = "월세보류여부"
            Me.chkdeferPaymentYn.Enabled = False
            Me.chkdeferPaymentYn.Location = New System.Drawing.Point(591, 127)
            Me.chkdeferPaymentYn.Name = "chkdeferPaymentYn"
            Me.chkdeferPaymentYn.ReadOnlys = False
            Me.chkdeferPaymentYn.Size = New System.Drawing.Size(96, 16)
            Me.chkdeferPaymentYn.TabIndex = 1752
            Me.chkdeferPaymentYn.Tag = Nothing
            Me.chkdeferPaymentYn.Text = "월세보류여부"
            Me.chkdeferPaymentYn.TextValue = "0"
            Me.chkdeferPaymentYn.UseVisualStyleBackColor = False
            '
            'chkVatYn
            '
            Me.chkVatYn.AutoSize = True
            Me.chkVatYn.BackColor = System.Drawing.SystemColors.Window
            Me.chkVatYn.CaptionName = "VAT포함여부"
            Me.chkVatYn.Enabled = False
            Me.chkVatYn.Location = New System.Drawing.Point(693, 127)
            Me.chkVatYn.Name = "chkVatYn"
            Me.chkVatYn.ReadOnlys = False
            Me.chkVatYn.Size = New System.Drawing.Size(96, 16)
            Me.chkVatYn.TabIndex = 1753
            Me.chkVatYn.Tag = Nothing
            Me.chkVatYn.Text = "VAT포함여부"
            Me.chkVatYn.TextValue = "0"
            Me.chkVatYn.UseVisualStyleBackColor = False
            '
            'PNB102
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.chkVatYn)
            Me.Controls.Add(Me.chkdeferPaymentYn)
            Me.Controls.Add(Me.Label6)
            Me.Controls.Add(Me.txtFloor)
            Me.Controls.Add(Me.Label7)
            Me.Controls.Add(Me.txtLimitedItem)
            Me.Controls.Add(Me.Label29)
            Me.Controls.Add(Me.Label28)
            Me.Controls.Add(Me.Label27)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.Label26)
            Me.Controls.Add(Me.Label25)
            Me.Controls.Add(Me.Label24)
            Me.Controls.Add(Me.Label23)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.Label16)
            Me.Controls.Add(Me.Label11)
            Me.Controls.Add(Me.Label8)
            Me.Controls.Add(Me.lblOldAddr2)
            Me.Controls.Add(Me.lblPhoneNumber)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.Label40)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label19)
            Me.Controls.Add(Me.Label17)
            Me.Controls.Add(Me.Label14)
            Me.Controls.Add(Me.Label10)
            Me.Controls.Add(Me.Label9)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.Label22)
            Me.Controls.Add(Me.Label18)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.lblOldPostNum)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.lblDeliveryBranchCd)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.Label15)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.Label43)
            Me.Controls.Add(Me.txtOwnerRelation)
            Me.Controls.Add(Me.popBankCd)
            Me.Controls.Add(Me.numRentAmt)
            Me.Controls.Add(Me.txtSecurityLimitedItem)
            Me.Controls.Add(Me.numSecurityBuildingArea)
            Me.Controls.Add(Me.txtSecurityAddr1)
            Me.Controls.Add(Me.popSecurityPostNum)
            Me.Controls.Add(Me.txtSecurityAddr2)
            Me.Controls.Add(Me.txtSecurityOwnerNm)
            Me.Controls.Add(Me.dtpContractEdDt)
            Me.Controls.Add(Me.dtpContractStDt)
            Me.Controls.Add(Me.txtObligation)
            Me.Controls.Add(Me.numUseArea)
            Me.Controls.Add(Me.numSiteArea)
            Me.Controls.Add(Me.numBuildingArea)
            Me.Controls.Add(Me.txtAddr1)
            Me.Controls.Add(Me.popPostNum)
            Me.Controls.Add(Me.txtAddr2)
            Me.Controls.Add(Me.txtOwnerPhoneNum)
            Me.Controls.Add(Me.txtOwnerNm)
            Me.Controls.Add(Me.popBranchCd)
            Me.Controls.Add(Me.popContractDivCd)
            Me.Controls.Add(Me.popProcessDivCd)
            Me.Controls.Add(Me.numTransferNum)
            Me.Controls.Add(Me.dtpTransferDate)
            Me.Controls.Add(Me.txtAccountNum)
            Me.Controls.Add(Me.numRentDepositAmt)
            Me.Controls.Add(Me.txtDepositorNm)
            Me.Controls.Add(Me.numSecuritySiteArea)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.Opt2)
            Me.Controls.Add(Me.lblBaseDt)
            Me.Controls.Add(Me.dtpBaseDt)
            Me.Controls.Add(Me.lblBranchNm)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picIo_2_1)
            Me.Controls.Add(Me.picIo_2_3)
            Me.Controls.Add(Me.picIo_2_2)
            Me.Name = "PNB102"
            Me.Size = New System.Drawing.Size(811, 674)
            Me.Controls.SetChildIndex(Me.picIo_2_2, 0)
            Me.Controls.SetChildIndex(Me.picIo_2_3, 0)
            Me.Controls.SetChildIndex(Me.picIo_2_1, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblBranchNm, 0)
            Me.Controls.SetChildIndex(Me.dtpBaseDt, 0)
            Me.Controls.SetChildIndex(Me.lblBaseDt, 0)
            Me.Controls.SetChildIndex(Me.Opt2, 0)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd_R, 0)
            Me.Controls.SetChildIndex(Me.numSecuritySiteArea, 0)
            Me.Controls.SetChildIndex(Me.txtDepositorNm, 0)
            Me.Controls.SetChildIndex(Me.numRentDepositAmt, 0)
            Me.Controls.SetChildIndex(Me.txtAccountNum, 0)
            Me.Controls.SetChildIndex(Me.dtpTransferDate, 0)
            Me.Controls.SetChildIndex(Me.numTransferNum, 0)
            Me.Controls.SetChildIndex(Me.popProcessDivCd, 0)
            Me.Controls.SetChildIndex(Me.popContractDivCd, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd, 0)
            Me.Controls.SetChildIndex(Me.txtOwnerNm, 0)
            Me.Controls.SetChildIndex(Me.txtOwnerPhoneNum, 0)
            Me.Controls.SetChildIndex(Me.txtAddr2, 0)
            Me.Controls.SetChildIndex(Me.popPostNum, 0)
            Me.Controls.SetChildIndex(Me.txtAddr1, 0)
            Me.Controls.SetChildIndex(Me.numBuildingArea, 0)
            Me.Controls.SetChildIndex(Me.numSiteArea, 0)
            Me.Controls.SetChildIndex(Me.numUseArea, 0)
            Me.Controls.SetChildIndex(Me.txtObligation, 0)
            Me.Controls.SetChildIndex(Me.dtpContractStDt, 0)
            Me.Controls.SetChildIndex(Me.dtpContractEdDt, 0)
            Me.Controls.SetChildIndex(Me.txtSecurityOwnerNm, 0)
            Me.Controls.SetChildIndex(Me.txtSecurityAddr2, 0)
            Me.Controls.SetChildIndex(Me.popSecurityPostNum, 0)
            Me.Controls.SetChildIndex(Me.txtSecurityAddr1, 0)
            Me.Controls.SetChildIndex(Me.numSecurityBuildingArea, 0)
            Me.Controls.SetChildIndex(Me.txtSecurityLimitedItem, 0)
            Me.Controls.SetChildIndex(Me.numRentAmt, 0)
            Me.Controls.SetChildIndex(Me.popBankCd, 0)
            Me.Controls.SetChildIndex(Me.txtOwnerRelation, 0)
            Me.Controls.SetChildIndex(Me.Label43, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.Label15, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.lblDeliveryBranchCd, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.lblOldPostNum, 0)
            Me.Controls.SetChildIndex(Me.Label13, 0)
            Me.Controls.SetChildIndex(Me.Label18, 0)
            Me.Controls.SetChildIndex(Me.Label22, 0)
            Me.Controls.SetChildIndex(Me.Label21, 0)
            Me.Controls.SetChildIndex(Me.Label9, 0)
            Me.Controls.SetChildIndex(Me.Label10, 0)
            Me.Controls.SetChildIndex(Me.Label14, 0)
            Me.Controls.SetChildIndex(Me.Label17, 0)
            Me.Controls.SetChildIndex(Me.Label19, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.Label40, 0)
            Me.Controls.SetChildIndex(Me.lblNote, 0)
            Me.Controls.SetChildIndex(Me.lblPhoneNumber, 0)
            Me.Controls.SetChildIndex(Me.lblOldAddr2, 0)
            Me.Controls.SetChildIndex(Me.Label8, 0)
            Me.Controls.SetChildIndex(Me.Label11, 0)
            Me.Controls.SetChildIndex(Me.Label16, 0)
            Me.Controls.SetChildIndex(Me.Label12, 0)
            Me.Controls.SetChildIndex(Me.Label20, 0)
            Me.Controls.SetChildIndex(Me.Label23, 0)
            Me.Controls.SetChildIndex(Me.Label24, 0)
            Me.Controls.SetChildIndex(Me.Label25, 0)
            Me.Controls.SetChildIndex(Me.Label26, 0)
            Me.Controls.SetChildIndex(Me.lblRecordState, 0)
            Me.Controls.SetChildIndex(Me.Label27, 0)
            Me.Controls.SetChildIndex(Me.Label28, 0)
            Me.Controls.SetChildIndex(Me.Label29, 0)
            Me.Controls.SetChildIndex(Me.txtLimitedItem, 0)
            Me.Controls.SetChildIndex(Me.Label7, 0)
            Me.Controls.SetChildIndex(Me.txtFloor, 0)
            Me.Controls.SetChildIndex(Me.Label6, 0)
            Me.Controls.SetChildIndex(Me.chkdeferPaymentYn, 0)
            Me.Controls.SetChildIndex(Me.chkVatYn, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Opt2.ResumeLayout(False)
            Me.Opt2.PerformLayout()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblBranchNm As System.Windows.Forms.Label
        Friend WithEvents lblBaseDt As System.Windows.Forms.Label
        Friend WithEvents dtpBaseDt As ubiLease.CommonControls.dtp
        Friend WithEvents Opt2 As ubiLease.CommonControls.opt
        Friend WithEvents optBranchHp As System.Windows.Forms.RadioButton
        Friend WithEvents optMonthDepositBack As System.Windows.Forms.RadioButton
        Friend WithEvents optMonAmtList As System.Windows.Forms.RadioButton
        Friend WithEvents optMonthTotal As System.Windows.Forms.RadioButton
        Friend WithEvents optsend As System.Windows.Forms.RadioButton
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents picIo_2_1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblDeliveryBranchCd As System.Windows.Forms.Label
        Friend WithEvents dtpTransferDate As ubiLease.CommonControls.dtp
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents numTransferNum As ubiLease.CommonControls.num
        Friend WithEvents Label40 As System.Windows.Forms.Label
        Friend WithEvents popProcessDivCd As ubiLease.CommonControls.pop
        Friend WithEvents Label19 As System.Windows.Forms.Label
        Friend WithEvents popContractDivCd As ubiLease.CommonControls.pop
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents lblNote As System.Windows.Forms.Label
        Friend WithEvents txtOwnerNm As ubiLease.CommonControls.txt
        Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
        Friend WithEvents txtOwnerPhoneNum As ubiLease.CommonControls.txt
        Friend WithEvents popPostNum As ubiLease.CommonControls.pop
        Friend WithEvents txtAddr2 As ubiLease.CommonControls.txt
        Friend WithEvents lblOldPostNum As System.Windows.Forms.Label
        Friend WithEvents lblOldAddr2 As System.Windows.Forms.Label
        Friend WithEvents txtAddr1 As ubiLease.CommonControls.txt
        Friend WithEvents numSiteArea As ubiLease.CommonControls.num
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents numBuildingArea As ubiLease.CommonControls.num
        Friend WithEvents Label43 As System.Windows.Forms.Label
        Friend WithEvents numUseArea As ubiLease.CommonControls.num
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents Label6 As System.Windows.Forms.Label
        Friend WithEvents txtLimitedItem As ubiLease.CommonControls.txt
        Friend WithEvents Label7 As System.Windows.Forms.Label
        Friend WithEvents txtObligation As ubiLease.CommonControls.txt
        Friend WithEvents Label8 As System.Windows.Forms.Label
        Friend WithEvents dtpContractStDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label9 As System.Windows.Forms.Label
        Friend WithEvents dtpContractEdDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label10 As System.Windows.Forms.Label
        Friend WithEvents Label11 As System.Windows.Forms.Label
        Friend WithEvents txtSecurityOwnerNm As ubiLease.CommonControls.txt
        Friend WithEvents txtSecurityLimitedItem As ubiLease.CommonControls.txt
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents numSecuritySiteArea As ubiLease.CommonControls.num
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents numSecurityBuildingArea As ubiLease.CommonControls.num
        Friend WithEvents Label14 As System.Windows.Forms.Label
        Friend WithEvents txtSecurityAddr1 As ubiLease.CommonControls.txt
        Friend WithEvents popSecurityPostNum As ubiLease.CommonControls.pop
        Friend WithEvents txtSecurityAddr2 As ubiLease.CommonControls.txt
        Friend WithEvents Label15 As System.Windows.Forms.Label
        Friend WithEvents Label16 As System.Windows.Forms.Label
        Friend WithEvents numRentAmt As ubiLease.CommonControls.num
        Friend WithEvents Label17 As System.Windows.Forms.Label
        Friend WithEvents numRentDepositAmt As ubiLease.CommonControls.num
        Friend WithEvents Label18 As System.Windows.Forms.Label
        Friend WithEvents popBankCd As ubiLease.CommonControls.pop
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents txtDepositorNm As ubiLease.CommonControls.txt
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents txtAccountNum As ubiLease.CommonControls.txt
        Friend WithEvents Label22 As System.Windows.Forms.Label
        Friend WithEvents txtOwnerRelation As ubiLease.CommonControls.txt
        Friend WithEvents Label23 As System.Windows.Forms.Label
        Friend WithEvents txtFloor As ubiLease.CommonControls.txt
        Friend WithEvents picIo_2_3 As System.Windows.Forms.PictureBox
        Friend WithEvents Label24 As System.Windows.Forms.Label
        Friend WithEvents Label25 As System.Windows.Forms.Label
        Friend WithEvents picIo_2_2 As System.Windows.Forms.PictureBox
        Friend WithEvents Label26 As System.Windows.Forms.Label
        Friend WithEvents lblRecordState As System.Windows.Forms.Label
        Friend WithEvents Label27 As System.Windows.Forms.Label
        Friend WithEvents Label28 As System.Windows.Forms.Label
        Friend WithEvents Label29 As System.Windows.Forms.Label
        Friend WithEvents chkdeferPaymentYn As ubiLease.CommonControls.chk
        Friend WithEvents chkVatYn As ubiLease.CommonControls.chk

    End Class

End Namespace
