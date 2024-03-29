Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE411
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE411))
            Me.cboColTypeCd = New ubiLease.CommonControls.cbo
            Me.lblColTypeCd = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            Me.dtpToColDt = New ubiLease.CommonControls.dtp
            Me.Label13 = New System.Windows.Forms.Label
            Me.lblNote = New System.Windows.Forms.Label
            Me.dtpFromColDt = New ubiLease.CommonControls.dtp
            Me.lblColDt = New System.Windows.Forms.Label
            Me.dtpProcDt = New ubiLease.CommonControls.dtp
            Me.lbColDate = New System.Windows.Forms.Label
            Me.lblColAmt = New System.Windows.Forms.Label
            Me.grd_1 = New ubiLease.GridControl.grd
            Me.picCriteria_1 = New System.Windows.Forms.PictureBox
            Me.picIo_2 = New System.Windows.Forms.PictureBox
            Me.lblColProcessTypeCd = New System.Windows.Forms.Label
            Me.txtRecipient = New ubiLease.CommonControls.txt
            Me.txtNote = New ubiLease.CommonControls.txt
            Me.popProcEmpNum = New ubiLease.CommonControls.pop
            Me.Label21 = New System.Windows.Forms.Label
            Me.numDistributionAmt = New ubiLease.CommonControls.num
            Me.numProcOrders = New ubiLease.CommonControls.num
            Me.popCompanyCd = New ubiLease.CommonControls.pop
            Me.Label12 = New System.Windows.Forms.Label
            Me.popEmployeeExpNum = New ubiLease.CommonControls.pop
            Me.lblEmployeeExpNum = New System.Windows.Forms.Label
            Me.cboColBankCd = New ubiLease.CommonControls.cbo
            Me.lblColBankCd = New System.Windows.Forms.Label
            Me.popCompanyCd_R = New ubiLease.CommonControls.pop
            Me.Label2 = New System.Windows.Forms.Label
            Me.PictureBox1 = New System.Windows.Forms.PictureBox
            Me.lblRecordState = New System.Windows.Forms.Label
            Me.numCollectionAmt = New ubiLease.CommonControls.num
            Me.Label1 = New System.Windows.Forms.Label
            Me.numDemandAmt = New ubiLease.CommonControls.num
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpCalYearMonths = New ubiLease.CommonControls.dtp
            Me.Label38 = New System.Windows.Forms.Label
            Me.popEmployeeExpNum_R = New ubiLease.CommonControls.pop
            Me.Label4 = New System.Windows.Forms.Label
            Me.dtpDistYearMonths = New ubiLease.CommonControls.dtp
            Me.Label5 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cboColTypeCd
            '
            Me.cboColTypeCd.BackColor = System.Drawing.Color.White
            Me.cboColTypeCd.CaptionName = "입금구분코드"
            Me.cboColTypeCd.ListCount = 0
            Me.cboColTypeCd.Location = New System.Drawing.Point(492, 93)
            Me.cboColTypeCd.Name = "cboColTypeCd"
            Me.cboColTypeCd.ReadOnlys = False
            Me.cboColTypeCd.Size = New System.Drawing.Size(34, 20)
            Me.cboColTypeCd.TabIndex = 5
            Me.cboColTypeCd.Tag = "read;init(D1);code(입금구분코드);"
            Me.cboColTypeCd.TextValue = ""
            Me.cboColTypeCd.Visible = False
            '
            'lblColTypeCd
            '
            Me.lblColTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColTypeCd.Location = New System.Drawing.Point(408, 96)
            Me.lblColTypeCd.Name = "lblColTypeCd"
            Me.lblColTypeCd.Size = New System.Drawing.Size(79, 15)
            Me.lblColTypeCd.TabIndex = 1509
            Me.lblColTypeCd.Text = "입금 구분"
            Me.lblColTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblColTypeCd.Visible = False
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Label20.Location = New System.Drawing.Point(18, 92)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(212, 12)
            Me.Label20.TabIndex = 1507
            Me.Label20.Text = "< 본사수금구독료 기초잔액 등록 >"
            '
            'dtpToColDt
            '
            Me.dtpToColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpToColDt.BorderStyle = 2
            Me.dtpToColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToColDt.CaptionName = "입금일자"
            Me.dtpToColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToColDt.Location = New System.Drawing.Point(227, 21)
            Me.dtpToColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToColDt.MaxLength = 0
            Me.dtpToColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToColDt.Name = "dtpToColDt"
            Me.dtpToColDt.ReadOnlys = False
            Me.dtpToColDt.SelectedText = ""
            Me.dtpToColDt.SelectionLength = 0
            Me.dtpToColDt.SelectionStart = 0
            Me.dtpToColDt.Size = New System.Drawing.Size(99, 20)
            Me.dtpToColDt.TabIndex = 1
            Me.dtpToColDt.TabStop = False
            Me.dtpToColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpToColDt.TextAlign = 0
            Me.dtpToColDt.TextValue = ""
            Me.dtpToColDt.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label13.Location = New System.Drawing.Point(212, 26)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(15, 15)
            Me.Label13.TabIndex = 1504
            Me.Label13.Text = "~"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Location = New System.Drawing.Point(421, 187)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(65, 15)
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
            Me.dtpFromColDt.Location = New System.Drawing.Point(113, 21)
            Me.dtpFromColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromColDt.MaxLength = 0
            Me.dtpFromColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromColDt.Name = "dtpFromColDt"
            Me.dtpFromColDt.ReadOnlys = False
            Me.dtpFromColDt.SelectedText = ""
            Me.dtpFromColDt.SelectionLength = 0
            Me.dtpFromColDt.SelectionStart = 0
            Me.dtpFromColDt.Size = New System.Drawing.Size(99, 20)
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
            Me.lblColDt.Location = New System.Drawing.Point(42, 26)
            Me.lblColDt.Name = "lblColDt"
            Me.lblColDt.Size = New System.Drawing.Size(65, 15)
            Me.lblColDt.TabIndex = 1501
            Me.lblColDt.Text = "작성 일자"
            Me.lblColDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpProcDt
            '
            Me.dtpProcDt.BackColor = System.Drawing.Color.White
            Me.dtpProcDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpProcDt.BorderStyle = 2
            Me.dtpProcDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpProcDt.CaptionName = "기준일자"
            Me.dtpProcDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpProcDt.Location = New System.Drawing.Point(113, 116)
            Me.dtpProcDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpProcDt.MaxLength = 0
            Me.dtpProcDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpProcDt.Name = "dtpProcDt"
            Me.dtpProcDt.ReadOnlys = True
            Me.dtpProcDt.SelectedText = ""
            Me.dtpProcDt.SelectionLength = 0
            Me.dtpProcDt.SelectionStart = 0
            Me.dtpProcDt.Size = New System.Drawing.Size(103, 20)
            Me.dtpProcDt.TabIndex = 4
            Me.dtpProcDt.TabStop = False
            Me.dtpProcDt.Tag = "need();format(&&&&-&&-&&);"
            Me.dtpProcDt.TextAlign = 0
            Me.dtpProcDt.TextValue = ""
            Me.dtpProcDt.ToolTipText = ""
            '
            'lbColDate
            '
            Me.lbColDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lbColDate.Location = New System.Drawing.Point(42, 119)
            Me.lbColDate.Name = "lbColDate"
            Me.lbColDate.Size = New System.Drawing.Size(65, 15)
            Me.lbColDate.TabIndex = 1499
            Me.lbColDate.Text = "작성 일자"
            Me.lbColDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblColAmt
            '
            Me.lblColAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColAmt.Location = New System.Drawing.Point(232, 186)
            Me.lblColAmt.Name = "lblColAmt"
            Me.lblColAmt.Size = New System.Drawing.Size(67, 15)
            Me.lblColAmt.TabIndex = 1496
            Me.lblColAmt.Text = "배분 금액"
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
            Me.grd_1.Location = New System.Drawing.Point(5, 227)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 439)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 15
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 69)
            Me.picCriteria_1.TabIndex = 1491
            Me.picCriteria_1.TabStop = False
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(12, 85)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(788, 129)
            Me.picIo_2.TabIndex = 1493
            Me.picIo_2.TabStop = False
            '
            'lblColProcessTypeCd
            '
            Me.lblColProcessTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColProcessTypeCd.Location = New System.Drawing.Point(548, 96)
            Me.lblColProcessTypeCd.Name = "lblColProcessTypeCd"
            Me.lblColProcessTypeCd.Size = New System.Drawing.Size(79, 14)
            Me.lblColProcessTypeCd.TabIndex = 1515
            Me.lblColProcessTypeCd.Text = "입금자 명"
            Me.lblColProcessTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblColProcessTypeCd.Visible = False
            '
            'txtRecipient
            '
            Me.txtRecipient.BackColor = System.Drawing.Color.White
            Me.txtRecipient.BorderColor = System.Drawing.Color.Empty
            Me.txtRecipient.BorderStyle = 2
            Me.txtRecipient.CaptionName = "예금주 명"
            Me.txtRecipient.Location = New System.Drawing.Point(632, 93)
            Me.txtRecipient.MaxLength = 40
            Me.txtRecipient.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRecipient.Multiline = False
            Me.txtRecipient.Name = "txtRecipient"
            Me.txtRecipient.ReadOnlys = True
            Me.txtRecipient.SelectedText = ""
            Me.txtRecipient.SelectionLength = 0
            Me.txtRecipient.SelectionStart = 0
            Me.txtRecipient.Size = New System.Drawing.Size(71, 20)
            Me.txtRecipient.TabIndex = 6
            Me.txtRecipient.Tag = "need();"
            Me.txtRecipient.TextAlign = 0
            Me.txtRecipient.TextValue = ""
            Me.txtRecipient.ToolTipText = ""
            Me.txtRecipient.Visible = False
            '
            'txtNote
            '
            Me.txtNote.BackColor = System.Drawing.Color.White
            Me.txtNote.BorderColor = System.Drawing.Color.Empty
            Me.txtNote.BorderStyle = 2
            Me.txtNote.CaptionName = "적요"
            Me.txtNote.Location = New System.Drawing.Point(492, 184)
            Me.txtNote.MaxLength = 40
            Me.txtNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNote.Multiline = False
            Me.txtNote.Name = "txtNote"
            Me.txtNote.ReadOnlys = True
            Me.txtNote.SelectedText = ""
            Me.txtNote.SelectionLength = 0
            Me.txtNote.SelectionStart = 0
            Me.txtNote.Size = New System.Drawing.Size(288, 20)
            Me.txtNote.TabIndex = 14
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
            Me.popProcEmpNum.Location = New System.Drawing.Point(492, 116)
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
            Me.popProcEmpNum.Size = New System.Drawing.Size(188, 20)
            Me.popProcEmpNum.TabIndex = 6
            Me.popProcEmpNum.Tag = "need();code(사원 명);"
            Me.popProcEmpNum.TextAlign = 0
            Me.popProcEmpNum.TextValue = ""
            Me.popProcEmpNum.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(420, 119)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(67, 15)
            Me.Label21.TabIndex = 1690
            Me.Label21.Text = "입금 담당"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numDistributionAmt
            '
            Me.numDistributionAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numDistributionAmt.BorderColor = System.Drawing.Color.Empty
            Me.numDistributionAmt.BorderStyle = 2
            Me.numDistributionAmt.CaptionName = "배분 금액"
            Me.numDistributionAmt.LengthPrecision = 15
            Me.numDistributionAmt.LengthScale = 0
            Me.numDistributionAmt.Location = New System.Drawing.Point(301, 183)
            Me.numDistributionAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numDistributionAmt.MaxLength = 32767
            Me.numDistributionAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numDistributionAmt.Name = "numDistributionAmt"
            Me.numDistributionAmt.ReadOnlys = False
            Me.numDistributionAmt.SelectedText = ""
            Me.numDistributionAmt.SelectionLength = 0
            Me.numDistributionAmt.SelectionStart = 1
            Me.numDistributionAmt.Size = New System.Drawing.Size(100, 20)
            Me.numDistributionAmt.TabIndex = 13
            Me.numDistributionAmt.Tag = ""
            Me.numDistributionAmt.TextValue = "0"
            Me.numDistributionAmt.ToolTipText = ""
            '
            'numProcOrders
            '
            Me.numProcOrders.BackColor = System.Drawing.SystemColors.Window
            Me.numProcOrders.BorderColor = System.Drawing.Color.Empty
            Me.numProcOrders.BorderStyle = 2
            Me.numProcOrders.CaptionName = "입금 번호"
            Me.numProcOrders.LengthPrecision = 15
            Me.numProcOrders.LengthScale = 0
            Me.numProcOrders.Location = New System.Drawing.Point(213, 116)
            Me.numProcOrders.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numProcOrders.MaxLength = 32767
            Me.numProcOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numProcOrders.Name = "numProcOrders"
            Me.numProcOrders.ReadOnlys = False
            Me.numProcOrders.SelectedText = ""
            Me.numProcOrders.SelectionLength = 0
            Me.numProcOrders.SelectionStart = 1
            Me.numProcOrders.Size = New System.Drawing.Size(52, 20)
            Me.numProcOrders.TabIndex = 5
            Me.numProcOrders.Tag = "read;"
            Me.numProcOrders.TextValue = "0"
            Me.numProcOrders.ToolTipText = ""
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(113, 139)
            Me.popCompanyCd.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCompanyCd.MaxLength = 12
            Me.popCompanyCd.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd.Name = "popCompanyCd"
            Me.popCompanyCd.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd.NameText = ""
            Me.popCompanyCd.ReadOnlys = False
            Me.popCompanyCd.SelectedText = ""
            Me.popCompanyCd.SelectionLength = 0
            Me.popCompanyCd.SelectionStart = 0
            Me.popCompanyCd.Size = New System.Drawing.Size(287, 20)
            Me.popCompanyCd.TabIndex = 7
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(42, 142)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(65, 15)
            Me.Label12.TabIndex = 1697
            Me.Label12.Text = "확장처 명"
            Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeExpNum
            '
            Me.popEmployeeExpNum.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeExpNum.BorderStyle = 2
            Me.popEmployeeExpNum.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeExpNum.CaptionName = "사원확장 명"
            Me.popEmployeeExpNum.CodeText = ""
            Me.popEmployeeExpNum.CodeWidth = 90
            Me.popEmployeeExpNum.Location = New System.Drawing.Point(492, 139)
            Me.popEmployeeExpNum.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popEmployeeExpNum.MaxLength = 12
            Me.popEmployeeExpNum.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popEmployeeExpNum.Name = "popEmployeeExpNum"
            Me.popEmployeeExpNum.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popEmployeeExpNum.NameText = ""
            Me.popEmployeeExpNum.ReadOnlys = False
            Me.popEmployeeExpNum.SelectedText = ""
            Me.popEmployeeExpNum.SelectionLength = 0
            Me.popEmployeeExpNum.SelectionStart = 0
            Me.popEmployeeExpNum.Size = New System.Drawing.Size(287, 20)
            Me.popEmployeeExpNum.TabIndex = 8
            Me.popEmployeeExpNum.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum.TextAlign = 0
            Me.popEmployeeExpNum.TextValue = ""
            Me.popEmployeeExpNum.ToolTipText = ""
            '
            'lblEmployeeExpNum
            '
            Me.lblEmployeeExpNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEmployeeExpNum.Location = New System.Drawing.Point(420, 140)
            Me.lblEmployeeExpNum.Name = "lblEmployeeExpNum"
            Me.lblEmployeeExpNum.Size = New System.Drawing.Size(67, 18)
            Me.lblEmployeeExpNum.TabIndex = 1696
            Me.lblEmployeeExpNum.Text = "확  장  명"
            Me.lblEmployeeExpNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboColBankCd
            '
            Me.cboColBankCd.BackColor = System.Drawing.Color.White
            Me.cboColBankCd.CaptionName = "은행코드"
            Me.cboColBankCd.ListCount = 0
            Me.cboColBankCd.Location = New System.Drawing.Point(356, 92)
            Me.cboColBankCd.Name = "cboColBankCd"
            Me.cboColBankCd.ReadOnlys = False
            Me.cboColBankCd.Size = New System.Drawing.Size(29, 20)
            Me.cboColBankCd.TabIndex = 5
            Me.cboColBankCd.Tag = "init(I101);code(입금계좌코드|선택하세요);"
            Me.cboColBankCd.TextValue = ""
            Me.cboColBankCd.Visible = False
            '
            'lblColBankCd
            '
            Me.lblColBankCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColBankCd.Location = New System.Drawing.Point(290, 95)
            Me.lblColBankCd.Name = "lblColBankCd"
            Me.lblColBankCd.Size = New System.Drawing.Size(61, 15)
            Me.lblColBankCd.TabIndex = 1699
            Me.lblColBankCd.Text = "입금 계좌"
            Me.lblColBankCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblColBankCd.Visible = False
            '
            'popCompanyCd_R
            '
            Me.popCompanyCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd_R.BorderStyle = 2
            Me.popCompanyCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd_R.CaptionName = "확장처 코드"
            Me.popCompanyCd_R.CodeText = ""
            Me.popCompanyCd_R.CodeWidth = 90
            Me.popCompanyCd_R.Location = New System.Drawing.Point(113, 44)
            Me.popCompanyCd_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.popCompanyCd_R.MaxLength = 12
            Me.popCompanyCd_R.MinimumSize = New System.Drawing.Size(19, 20)
            Me.popCompanyCd_R.Name = "popCompanyCd_R"
            Me.popCompanyCd_R.NameBackColor = System.Drawing.SystemColors.MenuBar
            Me.popCompanyCd_R.NameText = ""
            Me.popCompanyCd_R.ReadOnlys = False
            Me.popCompanyCd_R.SelectedText = ""
            Me.popCompanyCd_R.SelectionLength = 0
            Me.popCompanyCd_R.SelectionStart = 0
            Me.popCompanyCd_R.Size = New System.Drawing.Size(289, 20)
            Me.popCompanyCd_R.TabIndex = 2
            Me.popCompanyCd_R.Tag = "code(확장처 명);"
            Me.popCompanyCd_R.TextAlign = 0
            Me.popCompanyCd_R.TextValue = ""
            Me.popCompanyCd_R.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(42, 47)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(65, 15)
            Me.Label2.TabIndex = 1701
            Me.Label2.Text = "확장처 명"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 79)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(801, 142)
            Me.PictureBox1.TabIndex = 1702
            Me.PictureBox1.TabStop = False
            '
            'lblRecordState
            '
            Me.lblRecordState.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblRecordState.Location = New System.Drawing.Point(709, 93)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 1749
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numCollectionAmt
            '
            Me.numCollectionAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numCollectionAmt.BorderColor = System.Drawing.Color.Empty
            Me.numCollectionAmt.BorderStyle = 2
            Me.numCollectionAmt.CaptionName = "수금 금액"
            Me.numCollectionAmt.LengthPrecision = 15
            Me.numCollectionAmt.LengthScale = 0
            Me.numCollectionAmt.Location = New System.Drawing.Point(492, 162)
            Me.numCollectionAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numCollectionAmt.MaxLength = 32767
            Me.numCollectionAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numCollectionAmt.Name = "numCollectionAmt"
            Me.numCollectionAmt.ReadOnlys = False
            Me.numCollectionAmt.SelectedText = ""
            Me.numCollectionAmt.SelectionLength = 0
            Me.numCollectionAmt.SelectionStart = 1
            Me.numCollectionAmt.Size = New System.Drawing.Size(100, 20)
            Me.numCollectionAmt.TabIndex = 11
            Me.numCollectionAmt.Tag = ""
            Me.numCollectionAmt.TextValue = "0"
            Me.numCollectionAmt.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.GhostWhite
            Me.Label1.Location = New System.Drawing.Point(420, 165)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(67, 15)
            Me.Label1.TabIndex = 1751
            Me.Label1.Text = "수금 금액"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numDemandAmt
            '
            Me.numDemandAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numDemandAmt.BorderColor = System.Drawing.Color.Empty
            Me.numDemandAmt.BorderStyle = 2
            Me.numDemandAmt.CaptionName = "청구 금액"
            Me.numDemandAmt.LengthPrecision = 15
            Me.numDemandAmt.LengthScale = 0
            Me.numDemandAmt.Location = New System.Drawing.Point(301, 162)
            Me.numDemandAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numDemandAmt.MaxLength = 32767
            Me.numDemandAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numDemandAmt.Name = "numDemandAmt"
            Me.numDemandAmt.ReadOnlys = False
            Me.numDemandAmt.SelectedText = ""
            Me.numDemandAmt.SelectionLength = 0
            Me.numDemandAmt.SelectionStart = 1
            Me.numDemandAmt.Size = New System.Drawing.Size(100, 20)
            Me.numDemandAmt.TabIndex = 10
            Me.numDemandAmt.Tag = ""
            Me.numDemandAmt.TextValue = "0"
            Me.numDemandAmt.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(232, 165)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(67, 15)
            Me.Label3.TabIndex = 1753
            Me.Label3.Text = "청구 금액"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths
            '
            Me.dtpCalYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths.BorderStyle = 2
            Me.dtpCalYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths.CaptionName = "청구 월"
            Me.dtpCalYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths.Location = New System.Drawing.Point(113, 162)
            Me.dtpCalYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths.MaxLength = 0
            Me.dtpCalYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths.Name = "dtpCalYearMonths"
            Me.dtpCalYearMonths.ReadOnlys = False
            Me.dtpCalYearMonths.SelectedText = ""
            Me.dtpCalYearMonths.SelectionLength = 0
            Me.dtpCalYearMonths.SelectionStart = 0
            Me.dtpCalYearMonths.Size = New System.Drawing.Size(80, 20)
            Me.dtpCalYearMonths.TabIndex = 9
            Me.dtpCalYearMonths.Tag = "need();format(####-##);"
            Me.dtpCalYearMonths.TextAlign = 0
            Me.dtpCalYearMonths.TextValue = ""
            Me.dtpCalYearMonths.ToolTipText = ""
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.GhostWhite
            Me.Label38.Location = New System.Drawing.Point(42, 163)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(65, 18)
            Me.Label38.TabIndex = 1755
            Me.Label38.Text = "청구 월"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popEmployeeExpNum_R
            '
            Me.popEmployeeExpNum_R.BorderColor = System.Drawing.Color.Empty
            Me.popEmployeeExpNum_R.BorderStyle = 2
            Me.popEmployeeExpNum_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popEmployeeExpNum_R.CaptionName = "사원확장 명"
            Me.popEmployeeExpNum_R.CodeText = ""
            Me.popEmployeeExpNum_R.CodeWidth = 90
            Me.popEmployeeExpNum_R.Location = New System.Drawing.Point(492, 42)
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
            Me.popEmployeeExpNum_R.TabIndex = 3
            Me.popEmployeeExpNum_R.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum_R.TextAlign = 0
            Me.popEmployeeExpNum_R.TextValue = ""
            Me.popEmployeeExpNum_R.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(420, 43)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(67, 18)
            Me.Label4.TabIndex = 1757
            Me.Label4.Text = "확  장  명"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpDistYearMonths
            '
            Me.dtpDistYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpDistYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpDistYearMonths.BorderStyle = 2
            Me.dtpDistYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpDistYearMonths.CaptionName = "배분 월"
            Me.dtpDistYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpDistYearMonths.Location = New System.Drawing.Point(113, 184)
            Me.dtpDistYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpDistYearMonths.MaxLength = 0
            Me.dtpDistYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpDistYearMonths.Name = "dtpDistYearMonths"
            Me.dtpDistYearMonths.ReadOnlys = False
            Me.dtpDistYearMonths.SelectedText = ""
            Me.dtpDistYearMonths.SelectionLength = 0
            Me.dtpDistYearMonths.SelectionStart = 0
            Me.dtpDistYearMonths.Size = New System.Drawing.Size(80, 20)
            Me.dtpDistYearMonths.TabIndex = 12
            Me.dtpDistYearMonths.Tag = "format(####-##);"
            Me.dtpDistYearMonths.TextAlign = 0
            Me.dtpDistYearMonths.TextValue = ""
            Me.dtpDistYearMonths.ToolTipText = ""
            '
            'Label5
            '
            Me.Label5.BackColor = System.Drawing.Color.GhostWhite
            Me.Label5.Location = New System.Drawing.Point(42, 185)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(65, 18)
            Me.Label5.TabIndex = 1759
            Me.Label5.Text = "배분 월"
            Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNE411
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpDistYearMonths)
            Me.Controls.Add(Me.Label5)
            Me.Controls.Add(Me.popEmployeeExpNum_R)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpCalYearMonths)
            Me.Controls.Add(Me.Label38)
            Me.Controls.Add(Me.numDemandAmt)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.numCollectionAmt)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.popCompanyCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboColBankCd)
            Me.Controls.Add(Me.lblColBankCd)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.popEmployeeExpNum)
            Me.Controls.Add(Me.lblEmployeeExpNum)
            Me.Controls.Add(Me.numProcOrders)
            Me.Controls.Add(Me.numDistributionAmt)
            Me.Controls.Add(Me.popProcEmpNum)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.txtRecipient)
            Me.Controls.Add(Me.txtNote)
            Me.Controls.Add(Me.lblColProcessTypeCd)
            Me.Controls.Add(Me.cboColTypeCd)
            Me.Controls.Add(Me.lblColTypeCd)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.dtpToColDt)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.dtpFromColDt)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.lblColDt)
            Me.Controls.Add(Me.dtpProcDt)
            Me.Controls.Add(Me.lbColDate)
            Me.Controls.Add(Me.lblColAmt)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNE411"
            Me.Size = New System.Drawing.Size(811, 673)
            Me.Controls.SetChildIndex(Me.PictureBox1, 0)
            Me.Controls.SetChildIndex(Me.picIo_2, 0)
            Me.Controls.SetChildIndex(Me.picCriteria_1, 0)
            Me.Controls.SetChildIndex(Me.grd_1, 0)
            Me.Controls.SetChildIndex(Me.lblColAmt, 0)
            Me.Controls.SetChildIndex(Me.lbColDate, 0)
            Me.Controls.SetChildIndex(Me.dtpProcDt, 0)
            Me.Controls.SetChildIndex(Me.lblColDt, 0)
            Me.Controls.SetChildIndex(Me.lblNote, 0)
            Me.Controls.SetChildIndex(Me.dtpFromColDt, 0)
            Me.Controls.SetChildIndex(Me.Label13, 0)
            Me.Controls.SetChildIndex(Me.dtpToColDt, 0)
            Me.Controls.SetChildIndex(Me.Label20, 0)
            Me.Controls.SetChildIndex(Me.lblColTypeCd, 0)
            Me.Controls.SetChildIndex(Me.cboColTypeCd, 0)
            Me.Controls.SetChildIndex(Me.lblColProcessTypeCd, 0)
            Me.Controls.SetChildIndex(Me.txtNote, 0)
            Me.Controls.SetChildIndex(Me.txtRecipient, 0)
            Me.Controls.SetChildIndex(Me.Label21, 0)
            Me.Controls.SetChildIndex(Me.popProcEmpNum, 0)
            Me.Controls.SetChildIndex(Me.numDistributionAmt, 0)
            Me.Controls.SetChildIndex(Me.numProcOrders, 0)
            Me.Controls.SetChildIndex(Me.lblEmployeeExpNum, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeExpNum, 0)
            Me.Controls.SetChildIndex(Me.Label12, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd, 0)
            Me.Controls.SetChildIndex(Me.lblColBankCd, 0)
            Me.Controls.SetChildIndex(Me.cboColBankCd, 0)
            Me.Controls.SetChildIndex(Me.Label2, 0)
            Me.Controls.SetChildIndex(Me.popCompanyCd_R, 0)
            Me.Controls.SetChildIndex(Me.lblRecordState, 0)
            Me.Controls.SetChildIndex(Me.Label1, 0)
            Me.Controls.SetChildIndex(Me.numCollectionAmt, 0)
            Me.Controls.SetChildIndex(Me.Label3, 0)
            Me.Controls.SetChildIndex(Me.numDemandAmt, 0)
            Me.Controls.SetChildIndex(Me.Label38, 0)
            Me.Controls.SetChildIndex(Me.dtpCalYearMonths, 0)
            Me.Controls.SetChildIndex(Me.Label4, 0)
            Me.Controls.SetChildIndex(Me.popEmployeeExpNum_R, 0)
            Me.Controls.SetChildIndex(Me.Label5, 0)
            Me.Controls.SetChildIndex(Me.dtpDistYearMonths, 0)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents cboColTypeCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblColTypeCd As System.Windows.Forms.Label
        Friend WithEvents Label20 As System.Windows.Forms.Label
        Friend WithEvents dtpToColDt As ubiLease.CommonControls.dtp
        Friend WithEvents Label13 As System.Windows.Forms.Label
        Friend WithEvents lblNote As System.Windows.Forms.Label
        Friend WithEvents dtpFromColDt As ubiLease.CommonControls.dtp
        Friend WithEvents lblColDt As System.Windows.Forms.Label
        Friend WithEvents dtpProcDt As ubiLease.CommonControls.dtp
        Friend WithEvents lbColDate As System.Windows.Forms.Label
        Friend WithEvents lblColAmt As System.Windows.Forms.Label
        Friend WithEvents grd_1 As ubiLease.GridControl.grd
        Friend WithEvents picCriteria_1 As System.Windows.Forms.PictureBox
        Friend WithEvents picIo_2 As System.Windows.Forms.PictureBox
        Friend WithEvents lblColProcessTypeCd As System.Windows.Forms.Label
        Friend WithEvents txtRecipient As ubiLease.CommonControls.txt
        Friend WithEvents txtNote As ubiLease.CommonControls.txt
        Friend WithEvents popProcEmpNum As ubiLease.CommonControls.pop
        Friend WithEvents Label21 As System.Windows.Forms.Label
        Friend WithEvents numDistributionAmt As ubiLease.CommonControls.num
        Friend WithEvents numProcOrders As ubiLease.CommonControls.num
        Friend WithEvents popCompanyCd As ubiLease.CommonControls.pop
        Friend WithEvents Label12 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeExpNum As ubiLease.CommonControls.pop
        Friend WithEvents lblEmployeeExpNum As System.Windows.Forms.Label
        Friend WithEvents cboColBankCd As ubiLease.CommonControls.cbo
        Friend WithEvents lblColBankCd As System.Windows.Forms.Label
        Friend WithEvents popCompanyCd_R As ubiLease.CommonControls.pop
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Friend WithEvents lblRecordState As System.Windows.Forms.Label
        Friend WithEvents numCollectionAmt As ubiLease.CommonControls.num
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents numDemandAmt As ubiLease.CommonControls.num
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents popEmployeeExpNum_R As ubiLease.CommonControls.pop
        Friend WithEvents Label4 As System.Windows.Forms.Label
        Friend WithEvents dtpDistYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label5 As System.Windows.Forms.Label


    End Class

End Namespace
