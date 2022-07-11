Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI302
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI302))
            Me.cboColBankCd = New ubiLease.CommonControls.cbo
            Me.lblColBankCd = New System.Windows.Forms.Label
            Me.cboColTypeCd = New ubiLease.CommonControls.cbo
            Me.lblColTypeCd = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            Me.dtpToColDt = New ubiLease.CommonControls.dtp
            Me.lblHahaha = New System.Windows.Forms.Label
            Me.lblNote = New System.Windows.Forms.Label
            Me.dtpFromColDt = New ubiLease.CommonControls.dtp
            Me.lblColDt = New System.Windows.Forms.Label
            Me.dtpColDt = New ubiLease.CommonControls.dtp
            Me.lbColDate = New System.Windows.Forms.Label
            Me.lblColAmt = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.lblColProcessTypeCd = New System.Windows.Forms.Label
            Me.txtRecipient = New ubiLease.CommonControls.txt
            Me.popBranchCd = New ubiLease.CommonControls.pop
            Me.lblDeliveryBranchCd = New System.Windows.Forms.Label
            Me.txtNote = New ubiLease.CommonControls.txt
            Me.popProcEmpNum = New ubiLease.CommonControls.pop
            Me.Label21 = New System.Windows.Forms.Label
            Me.dtpCalYearMonths = New ubiLease.CommonControls.dtp
            Me.Label38 = New System.Windows.Forms.Label
            Me.numColAmt = New ubiLease.CommonControls.num
            Me.numColOrders = New ubiLease.CommonControls.num
            Me.popChargeEmpNum_R = New ubiLease.CommonControls.pop
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.popBranchCd_R = New ubiLease.CommonControls.pop
            Me.lblRecordState = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cboColBankCd
            '
            Me.cboColBankCd.BackColor = System.Drawing.Color.White
            Me.cboColBankCd.CaptionName = "은행코드"
            Me.cboColBankCd.ListCount = 0
            Me.cboColBankCd.Location = New System.Drawing.Point(121, 108)
            Me.cboColBankCd.Name = "cboColBankCd"
            Me.cboColBankCd.ReadOnlys = False
            Me.cboColBankCd.Size = New System.Drawing.Size(174, 20)
            Me.cboColBankCd.TabIndex = 8
            Me.cboColBankCd.Tag = "need();code(입금계좌코드|선택하세요);"
            Me.cboColBankCd.TextValue = ""
            '
            'lblColBankCd
            '
            Me.lblColBankCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColBankCd.Location = New System.Drawing.Point(56, 111)
            Me.lblColBankCd.Name = "lblColBankCd"
            Me.lblColBankCd.Size = New System.Drawing.Size(61, 15)
            Me.lblColBankCd.TabIndex = 1511
            Me.lblColBankCd.Text = "입금 계좌"
            Me.lblColBankCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboColTypeCd
            '
            Me.cboColTypeCd.BackColor = System.Drawing.Color.White
            Me.cboColTypeCd.CaptionName = "입금구분코드"
            Me.cboColTypeCd.ListCount = 0
            Me.cboColTypeCd.Location = New System.Drawing.Point(383, 86)
            Me.cboColTypeCd.Name = "cboColTypeCd"
            Me.cboColTypeCd.ReadOnlys = False
            Me.cboColTypeCd.Size = New System.Drawing.Size(135, 20)
            Me.cboColTypeCd.TabIndex = 6
            Me.cboColTypeCd.Tag = "init(I1);code(입금구분코드);"
            Me.cboColTypeCd.TextValue = ""
            '
            'lblColTypeCd
            '
            Me.lblColTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColTypeCd.Location = New System.Drawing.Point(317, 89)
            Me.lblColTypeCd.Name = "lblColTypeCd"
            Me.lblColTypeCd.Size = New System.Drawing.Size(62, 15)
            Me.lblColTypeCd.TabIndex = 1509
            Me.lblColTypeCd.Text = "입금 구분"
            Me.lblColTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.Label20.Location = New System.Drawing.Point(16, 70)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(36, 12)
            Me.Label20.TabIndex = 1507
            Me.Label20.Text = "입금 "
            '
            'dtpToColDt
            '
            Me.dtpToColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpToColDt.BorderStyle = 2
            Me.dtpToColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToColDt.CaptionName = "입금일자"
            Me.dtpToColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToColDt.Location = New System.Drawing.Point(217, 22)
            Me.dtpToColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToColDt.MaxLength = 0
            Me.dtpToColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToColDt.Name = "dtpToColDt"
            Me.dtpToColDt.ReadOnlys = False
            Me.dtpToColDt.SelectedText = ""
            Me.dtpToColDt.SelectionLength = 0
            Me.dtpToColDt.SelectionStart = 0
            Me.dtpToColDt.Size = New System.Drawing.Size(95, 20)
            Me.dtpToColDt.TabIndex = 1
            Me.dtpToColDt.TabStop = False
            Me.dtpToColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpToColDt.TextAlign = 0
            Me.dtpToColDt.TextValue = ""
            Me.dtpToColDt.ToolTipText = ""
            '
            'lblHahaha
            '
            Me.lblHahaha.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblHahaha.Location = New System.Drawing.Point(203, 25)
            Me.lblHahaha.Name = "lblHahaha"
            Me.lblHahaha.Size = New System.Drawing.Size(15, 15)
            Me.lblHahaha.TabIndex = 1504
            Me.lblHahaha.Text = "~"
            Me.lblHahaha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Location = New System.Drawing.Point(56, 155)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(61, 15)
            Me.lblNote.TabIndex = 1503
            Me.lblNote.Text = "적요"
            Me.lblNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpFromColDt
            '
            Me.dtpFromColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpFromColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpFromColDt.BorderStyle = 2
            Me.dtpFromColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpFromColDt.CaptionName = "접수년"
            Me.dtpFromColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpFromColDt.Location = New System.Drawing.Point(109, 22)
            Me.dtpFromColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromColDt.MaxLength = 0
            Me.dtpFromColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromColDt.Name = "dtpFromColDt"
            Me.dtpFromColDt.ReadOnlys = False
            Me.dtpFromColDt.SelectedText = ""
            Me.dtpFromColDt.SelectionLength = 0
            Me.dtpFromColDt.SelectionStart = 0
            Me.dtpFromColDt.Size = New System.Drawing.Size(95, 20)
            Me.dtpFromColDt.TabIndex = 0
            Me.dtpFromColDt.TabStop = False
            Me.dtpFromColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpFromColDt.TextAlign = 0
            Me.dtpFromColDt.TextValue = ""
            Me.dtpFromColDt.ToolTipText = ""
            '
            'lblColDt
            '
            Me.lblColDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblColDt.Location = New System.Drawing.Point(38, 25)
            Me.lblColDt.Name = "lblColDt"
            Me.lblColDt.Size = New System.Drawing.Size(65, 15)
            Me.lblColDt.TabIndex = 1501
            Me.lblColDt.Text = "입금 일자"
            Me.lblColDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpColDt
            '
            Me.dtpColDt.BackColor = System.Drawing.Color.White
            Me.dtpColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpColDt.BorderStyle = 2
            Me.dtpColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpColDt.CaptionName = "입금일자"
            Me.dtpColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpColDt.Location = New System.Drawing.Point(121, 86)
            Me.dtpColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpColDt.MaxLength = 0
            Me.dtpColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpColDt.Name = "dtpColDt"
            Me.dtpColDt.ReadOnlys = True
            Me.dtpColDt.SelectedText = ""
            Me.dtpColDt.SelectionLength = 0
            Me.dtpColDt.SelectionStart = 0
            Me.dtpColDt.Size = New System.Drawing.Size(103, 20)
            Me.dtpColDt.TabIndex = 4
            Me.dtpColDt.TabStop = False
            Me.dtpColDt.Tag = "need();format(&&&&-&&-&&);"
            Me.dtpColDt.TextAlign = 0
            Me.dtpColDt.TextValue = ""
            Me.dtpColDt.ToolTipText = ""
            '
            'lbColDate
            '
            Me.lbColDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lbColDate.Location = New System.Drawing.Point(56, 89)
            Me.lbColDate.Name = "lbColDate"
            Me.lbColDate.Size = New System.Drawing.Size(61, 15)
            Me.lbColDate.TabIndex = 1499
            Me.lbColDate.Text = "입금 일자"
            Me.lbColDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblColAmt
            '
            Me.lblColAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColAmt.Location = New System.Drawing.Point(56, 133)
            Me.lblColAmt.Name = "lblColAmt"
            Me.lblColAmt.Size = New System.Drawing.Size(61, 15)
            Me.lblColAmt.TabIndex = 1496
            Me.lblColAmt.Text = "입금 금액"
            Me.lblColAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
            Me.grd_1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle
            Me.grd_1.Cols = 2
            Me.grd_1.ColumnInfo = "2,1,1,0,0,0,Columns:"
            Me.grd_1.ExplorerBar = 0
            Me.grd_1.ExtendLastCol = True
            Me.grd_1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Solid
            Me.grd_1.Font = New System.Drawing.Font("굴림", 9.0!)
            Me.grd_1.FrozenCols = 1
            Me.grd_1.GridColorFixed = System.Drawing.SystemColors.ControlDark
            Me.grd_1.Location = New System.Drawing.Point(6, 184)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(799, 486)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 13
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(7, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(799, 51)
            Me.picCriteria_1.TabIndex = 1491
            Me.picCriteria_1.TabStop = False
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(7, 63)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(799, 115)
            Me.picIo_2.TabIndex = 1493
            Me.picIo_2.TabStop = False
            '
            'lblColProcessTypeCd
            '
            Me.lblColProcessTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColProcessTypeCd.Location = New System.Drawing.Point(317, 111)
            Me.lblColProcessTypeCd.Name = "lblColProcessTypeCd"
            Me.lblColProcessTypeCd.Size = New System.Drawing.Size(62, 14)
            Me.lblColProcessTypeCd.TabIndex = 1515
            Me.lblColProcessTypeCd.Text = "입금자 명"
            Me.lblColProcessTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRecipient
            '
            Me.txtRecipient.BackColor = System.Drawing.Color.White
            Me.txtRecipient.BorderColor = System.Drawing.Color.Empty
            Me.txtRecipient.BorderStyle = 2
            Me.txtRecipient.CaptionName = "예금주 명"
            Me.txtRecipient.Location = New System.Drawing.Point(383, 108)
            Me.txtRecipient.MaxLength = 40
            Me.txtRecipient.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRecipient.Multiline = False
            Me.txtRecipient.Name = "txtRecipient"
            Me.txtRecipient.ReadOnlys = True
            Me.txtRecipient.SelectedText = ""
            Me.txtRecipient.SelectionLength = 0
            Me.txtRecipient.SelectionStart = 0
            Me.txtRecipient.Size = New System.Drawing.Size(135, 20)
            Me.txtRecipient.TabIndex = 9
            Me.txtRecipient.Tag = ""
            Me.txtRecipient.TextAlign = 0
            Me.txtRecipient.TextValue = ""
            Me.txtRecipient.ToolTipText = ""
            '
            'popBranchCd
            '
            Me.popBranchCd.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd.BorderStyle = 2
            Me.popBranchCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd.CaptionName = "지국 번호"
            Me.popBranchCd.CodeText = ""
            Me.popBranchCd.CodeWidth = 65
            Me.popBranchCd.Location = New System.Drawing.Point(592, 130)
            Me.popBranchCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd.MaxLength = 9
            Me.popBranchCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd.Name = "popBranchCd"
            Me.popBranchCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd.NameText = ""
            Me.popBranchCd.ReadOnlys = False
            Me.popBranchCd.SelectedText = ""
            Me.popBranchCd.SelectionLength = 0
            Me.popBranchCd.SelectionStart = 0
            Me.popBranchCd.Size = New System.Drawing.Size(179, 20)
            Me.popBranchCd.TabIndex = 12
            Me.popBranchCd.Tag = "need();code(지국번호);"
            Me.popBranchCd.TextAlign = 0
            Me.popBranchCd.TextValue = ""
            Me.popBranchCd.ToolTipText = ""
            '
            'lblDeliveryBranchCd
            '
            Me.lblDeliveryBranchCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblDeliveryBranchCd.Location = New System.Drawing.Point(526, 131)
            Me.lblDeliveryBranchCd.Name = "lblDeliveryBranchCd"
            Me.lblDeliveryBranchCd.Size = New System.Drawing.Size(62, 18)
            Me.lblDeliveryBranchCd.TabIndex = 1611
            Me.lblDeliveryBranchCd.Text = "지국번호"
            Me.lblDeliveryBranchCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtNote
            '
            Me.txtNote.BackColor = System.Drawing.Color.White
            Me.txtNote.BorderColor = System.Drawing.Color.Empty
            Me.txtNote.BorderStyle = 2
            Me.txtNote.CaptionName = "적요"
            Me.txtNote.Location = New System.Drawing.Point(121, 152)
            Me.txtNote.MaxLength = 40
            Me.txtNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNote.Multiline = False
            Me.txtNote.Name = "txtNote"
            Me.txtNote.ReadOnlys = True
            Me.txtNote.SelectedText = ""
            Me.txtNote.SelectionLength = 0
            Me.txtNote.SelectionStart = 0
            Me.txtNote.Size = New System.Drawing.Size(651, 20)
            Me.txtNote.TabIndex = 13
            Me.txtNote.Tag = ""
            Me.txtNote.TextAlign = 0
            Me.txtNote.TextValue = ""
            Me.txtNote.ToolTipText = ""
            '
            'popProcEmpNum
            '
            Me.popProcEmpNum.BorderColor = System.Drawing.Color.Empty
            Me.popProcEmpNum.BorderStyle = 2
            Me.popProcEmpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popProcEmpNum.CaptionName = "담당자"
            Me.popProcEmpNum.CodeText = ""
            Me.popProcEmpNum.CodeWidth = 55
            Me.popProcEmpNum.Location = New System.Drawing.Point(592, 86)
            Me.popProcEmpNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popProcEmpNum.MaxLength = 6
            Me.popProcEmpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popProcEmpNum.Name = "popProcEmpNum"
            Me.popProcEmpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popProcEmpNum.NameText = ""
            Me.popProcEmpNum.ReadOnlys = False
            Me.popProcEmpNum.SelectedText = ""
            Me.popProcEmpNum.SelectionLength = 0
            Me.popProcEmpNum.SelectionStart = 0
            Me.popProcEmpNum.Size = New System.Drawing.Size(179, 20)
            Me.popProcEmpNum.TabIndex = 7
            Me.popProcEmpNum.Tag = "need();code(사원 명);"
            Me.popProcEmpNum.TextAlign = 0
            Me.popProcEmpNum.TextValue = ""
            Me.popProcEmpNum.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(526, 89)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(62, 15)
            Me.Label21.TabIndex = 1690
            Me.Label21.Text = "입금담당자"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths
            '
            Me.dtpCalYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths.BorderStyle = 2
            Me.dtpCalYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths.CaptionName = "지대 년월"
            Me.dtpCalYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths.Location = New System.Drawing.Point(383, 130)
            Me.dtpCalYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths.MaxLength = 0
            Me.dtpCalYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths.Name = "dtpCalYearMonths"
            Me.dtpCalYearMonths.ReadOnlys = False
            Me.dtpCalYearMonths.SelectedText = ""
            Me.dtpCalYearMonths.SelectionLength = 0
            Me.dtpCalYearMonths.SelectionStart = 0
            Me.dtpCalYearMonths.Size = New System.Drawing.Size(80, 20)
            Me.dtpCalYearMonths.TabIndex = 11
            Me.dtpCalYearMonths.Tag = "need();format(####-##);"
            Me.dtpCalYearMonths.TextAlign = 0
            Me.dtpCalYearMonths.TextValue = ""
            Me.dtpCalYearMonths.ToolTipText = ""
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.GhostWhite
            Me.Label38.Location = New System.Drawing.Point(317, 131)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(62, 18)
            Me.Label38.TabIndex = 1692
            Me.Label38.Text = "지대 년월"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numColAmt
            '
            Me.numColAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numColAmt.BorderColor = System.Drawing.Color.Empty
            Me.numColAmt.BorderStyle = 2
            Me.numColAmt.CaptionName = "입금 금액"
            Me.numColAmt.LengthPrecision = 15
            Me.numColAmt.LengthScale = 0
            Me.numColAmt.Location = New System.Drawing.Point(121, 130)
            Me.numColAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numColAmt.MaxLength = 32767
            Me.numColAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numColAmt.Name = "numColAmt"
            Me.numColAmt.ReadOnlys = False
            Me.numColAmt.SelectedText = ""
            Me.numColAmt.SelectionLength = 0
            Me.numColAmt.SelectionStart = 1
            Me.numColAmt.Size = New System.Drawing.Size(173, 20)
            Me.numColAmt.TabIndex = 10
            Me.numColAmt.Tag = "need();"
            Me.numColAmt.TextValue = "0"
            Me.numColAmt.ToolTipText = ""
            '
            'numColOrders
            '
            Me.numColOrders.BackColor = System.Drawing.SystemColors.Window
            Me.numColOrders.BorderColor = System.Drawing.Color.Empty
            Me.numColOrders.BorderStyle = 2
            Me.numColOrders.CaptionName = "입금 번호"
            Me.numColOrders.LengthPrecision = 15
            Me.numColOrders.LengthScale = 0
            Me.numColOrders.Location = New System.Drawing.Point(221, 86)
            Me.numColOrders.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numColOrders.MaxLength = 32767
            Me.numColOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numColOrders.Name = "numColOrders"
            Me.numColOrders.ReadOnlys = False
            Me.numColOrders.SelectedText = ""
            Me.numColOrders.SelectionLength = 0
            Me.numColOrders.SelectionStart = 1
            Me.numColOrders.Size = New System.Drawing.Size(52, 20)
            Me.numColOrders.TabIndex = 5
            Me.numColOrders.Tag = "read;"
            Me.numColOrders.TextValue = "0"
            Me.numColOrders.ToolTipText = ""
            '
            'popChargeEmpNum_R
            '
            Me.popChargeEmpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popChargeEmpNum_R.BorderStyle = 2
            Me.popChargeEmpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popChargeEmpNum_R.CaptionName = "담당자"
            Me.popChargeEmpNum_R.CodeText = ""
            Me.popChargeEmpNum_R.CodeWidth = 55
            Me.popChargeEmpNum_R.Location = New System.Drawing.Point(375, 22)
            Me.popChargeEmpNum_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popChargeEmpNum_R.MaxLength = 6
            Me.popChargeEmpNum_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popChargeEmpNum_R.Name = "popChargeEmpNum_R"
            Me.popChargeEmpNum_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popChargeEmpNum_R.NameText = ""
            Me.popChargeEmpNum_R.ReadOnlys = False
            Me.popChargeEmpNum_R.SelectedText = ""
            Me.popChargeEmpNum_R.SelectionLength = 0
            Me.popChargeEmpNum_R.SelectionStart = 0
            Me.popChargeEmpNum_R.Size = New System.Drawing.Size(152, 20)
            Me.popChargeEmpNum_R.TabIndex = 2
            Me.popChargeEmpNum_R.Tag = "code(영업사원 명);"
            Me.popChargeEmpNum_R.TextAlign = 0
            Me.popChargeEmpNum_R.TextValue = ""
            Me.popChargeEmpNum_R.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(320, 25)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(50, 15)
            Me.Label1.TabIndex = 1694
            Me.Label1.Text = "담당자"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(545, 25)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(54, 14)
            Me.Label2.TabIndex = 1696
            Me.Label2.Text = "지국번호"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popBranchCd_R
            '
            Me.popBranchCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popBranchCd_R.BorderStyle = 2
            Me.popBranchCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popBranchCd_R.CaptionName = "지국 코드"
            Me.popBranchCd_R.CodeText = ""
            Me.popBranchCd_R.CodeWidth = 65
            Me.popBranchCd_R.Location = New System.Drawing.Point(608, 22)
            Me.popBranchCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popBranchCd_R.MaxLength = 9
            Me.popBranchCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popBranchCd_R.Name = "popBranchCd_R"
            Me.popBranchCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popBranchCd_R.NameText = ""
            Me.popBranchCd_R.ReadOnlys = False
            Me.popBranchCd_R.SelectedText = ""
            Me.popBranchCd_R.SelectionLength = 0
            Me.popBranchCd_R.SelectionStart = 0
            Me.popBranchCd_R.Size = New System.Drawing.Size(176, 20)
            Me.popBranchCd_R.TabIndex = 3
            Me.popBranchCd_R.Tag = "code(지국번호);"
            Me.popBranchCd_R.TextAlign = 0
            Me.popBranchCd_R.TextValue = ""
            Me.popBranchCd_R.ToolTipText = ""
            '
            'lblRecordState
            '
            Me.lblRecordState.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblRecordState.Location = New System.Drawing.Point(701, 69)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 1748
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI302
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.popBranchCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.popChargeEmpNum_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.numColOrders)
            Me.Controls.Add(Me.numColAmt)
            Me.Controls.Add(Me.dtpCalYearMonths)
            Me.Controls.Add(Me.Label38)
            Me.Controls.Add(Me.popProcEmpNum)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.txtNote)
            Me.Controls.Add(Me.popBranchCd)
            Me.Controls.Add(Me.lblDeliveryBranchCd)
            Me.Controls.Add(Me.txtRecipient)
            Me.Controls.Add(Me.lblColProcessTypeCd)
            Me.Controls.Add(Me.cboColBankCd)
            Me.Controls.Add(Me.lblColBankCd)
            Me.Controls.Add(Me.cboColTypeCd)
            Me.Controls.Add(Me.lblColTypeCd)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.dtpToColDt)
            Me.Controls.Add(Me.lblHahaha)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.dtpFromColDt)
            Me.Controls.Add(Me.lblColDt)
            Me.Controls.Add(Me.dtpColDt)
            Me.Controls.Add(Me.lbColDate)
            Me.Controls.Add(Me.lblColAmt)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picIo_2)
            Me.Name = "PNI302"
            Me.Size = New System.Drawing.Size(811, 673)
            Me.Controls.SetChildIndex(Me.picIo_2, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblColAmt, 0)
            Me.Controls.SetChildIndex(Me.lbColDate, 0)
            Me.Controls.SetChildIndex(Me.dtpColDt, 0)
            Me.Controls.SetChildIndex(Me.lblColDt, 0)
            Me.Controls.SetChildIndex(Me.dtpFromColDt, 0)
            Me.Controls.SetChildIndex(Me.lblNote, 0)
            Me.Controls.SetChildIndex(Me.lblHahaha, 0)
            Me.Controls.SetChildIndex(Me.dtpToColDt, 0)
            Me.Controls.SetChildIndex(Me.Label20, 0)
            Me.Controls.SetChildIndex(Me.lblColTypeCd, 0)
            Me.Controls.SetChildIndex(Me.cboColTypeCd, 0)
            Me.Controls.SetChildIndex(Me.lblColBankCd, 0)
            Me.Controls.SetChildIndex(Me.cboColBankCd, 0)
            Me.Controls.SetChildIndex(Me.lblColProcessTypeCd, 0)
            Me.Controls.SetChildIndex(Me.txtRecipient, 0)
            Me.Controls.SetChildIndex(Me.lblDeliveryBranchCd, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd, 0)
            Me.Controls.SetChildIndex(Me.txtNote, 0)
            Me.Controls.SetChildIndex(Me.Label21, 0)
            Me.Controls.SetChildIndex(Me.popProcEmpNum, 0)
            Me.Controls.SetChildIndex(Me.Label38, 0)
            Me.Controls.SetChildIndex(Me.dtpCalYearMonths, 0)
            Me.Controls.SetChildIndex(Me.numColAmt, 0)
            Me.Controls.SetChildIndex(Me.numColOrders, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.popChargeEmpNum_R, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popBranchCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblRecordState, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cboColBankCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblColBankCd As System.Windows.Forms.Label
        Friend WithEvents cboColTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblColTypeCd As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents dtpToColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblHahaha As System.Windows.Forms.Label
        Friend WithEvents lblNote As System.Windows.Forms.Label
        Friend WithEvents dtpFromColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblColDt As System.Windows.Forms.Label
        Friend WithEvents dtpColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lbColDate As System.Windows.Forms.Label
        Friend WithEvents lblColAmt As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents lblColProcessTypeCd As System.Windows.Forms.Label
        Friend WithEvents txtRecipient As ubiLease.CommonControls.txt
        Friend WithEvents popBranchCd As ubiLease.CommonControls.pop
        Friend WithEvents lblDeliveryBranchCd As System.Windows.Forms.Label
        Friend WithEvents txtNote As ubiLease.CommonControls.txt
        Friend WithEvents popProcEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents numColAmt As ubiLease.CommonControls.num
        Friend WithEvents numColOrders As ubiLease.CommonControls.num
        Friend WithEvents popChargeEmpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents popBranchCd_R As ubiLease.CommonControls.pop
        Friend WithEvents lblRecordState As System.Windows.Forms.Label


    End Class

End Namespace
