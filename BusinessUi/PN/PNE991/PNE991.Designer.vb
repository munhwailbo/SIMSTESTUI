Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNE991
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNE991))
            Me.cboColTypeCd = New ubiLease.CommonControls.cbo
            Me.lblColTypeCd = New System.Windows.Forms.Label
            Me.Label20 = New System.Windows.Forms.Label
            Me.dtpToColDt = New ubiLease.CommonControls.dtp
            Me.Label13 = New System.Windows.Forms.Label
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
            Me.txtNote = New ubiLease.CommonControls.txt
            Me.popProcEmpNum = New ubiLease.CommonControls.pop
            Me.Label21 = New System.Windows.Forms.Label
            Me.numColAmt = New ubiLease.CommonControls.num
            Me.numColOrders = New ubiLease.CommonControls.num
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
            Me.cboColTypeCd.Location = New System.Drawing.Point(442, 89)
            Me.cboColTypeCd.Name = "cboColTypeCd"
            Me.cboColTypeCd.ReadOnlys = False
            Me.cboColTypeCd.Size = New System.Drawing.Size(155, 20)
            Me.cboColTypeCd.TabIndex = 4
            Me.cboColTypeCd.Tag = "read;init(D1);code(입금구분코드);"
            Me.cboColTypeCd.TextValue = ""
            '
            'lblColTypeCd
            '
            Me.lblColTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColTypeCd.Location = New System.Drawing.Point(358, 92)
            Me.lblColTypeCd.Name = "lblColTypeCd"
            Me.lblColTypeCd.Size = New System.Drawing.Size(79, 15)
            Me.lblColTypeCd.TabIndex = 1509
            Me.lblColTypeCd.Text = "입금 구분"
            Me.lblColTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Label20.Location = New System.Drawing.Point(20, 73)
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
            Me.dtpToColDt.Location = New System.Drawing.Point(229, 21)
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
            Me.Label13.Location = New System.Drawing.Point(214, 26)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(15, 15)
            Me.Label13.TabIndex = 1504
            Me.Label13.Text = "~"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Location = New System.Drawing.Point(68, 161)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(79, 15)
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
            Me.dtpFromColDt.Location = New System.Drawing.Point(115, 21)
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
            Me.lblColDt.Location = New System.Drawing.Point(44, 26)
            Me.lblColDt.Name = "lblColDt"
            Me.lblColDt.Size = New System.Drawing.Size(65, 15)
            Me.lblColDt.TabIndex = 1501
            Me.lblColDt.Text = "기준 일자"
            Me.lblColDt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpColDt
            '
            Me.dtpColDt.BackColor = System.Drawing.Color.White
            Me.dtpColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpColDt.BorderStyle = 2
            Me.dtpColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpColDt.CaptionName = "기준일자"
            Me.dtpColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpColDt.Location = New System.Drawing.Point(152, 89)
            Me.dtpColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpColDt.MaxLength = 0
            Me.dtpColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpColDt.Name = "dtpColDt"
            Me.dtpColDt.ReadOnlys = True
            Me.dtpColDt.SelectedText = ""
            Me.dtpColDt.SelectionLength = 0
            Me.dtpColDt.SelectionStart = 0
            Me.dtpColDt.Size = New System.Drawing.Size(103, 20)
            Me.dtpColDt.TabIndex = 2
            Me.dtpColDt.TabStop = False
            Me.dtpColDt.Tag = "need();format(&&&&-&&-&&);"
            Me.dtpColDt.TextAlign = 0
            Me.dtpColDt.TextValue = ""
            Me.dtpColDt.ToolTipText = ""
            '
            'lbColDate
            '
            Me.lbColDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lbColDate.Location = New System.Drawing.Point(80, 92)
            Me.lbColDate.Name = "lbColDate"
            Me.lbColDate.Size = New System.Drawing.Size(67, 15)
            Me.lbColDate.TabIndex = 1499
            Me.lbColDate.Text = "기준 일자"
            Me.lbColDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblColAmt
            '
            Me.lblColAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColAmt.Location = New System.Drawing.Point(80, 115)
            Me.lblColAmt.Name = "lblColAmt"
            Me.lblColAmt.Size = New System.Drawing.Size(67, 15)
            Me.lblColAmt.TabIndex = 1496
            Me.lblColAmt.Text = "잔액"
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
            Me.grd_1.Location = New System.Drawing.Point(5, 198)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(801, 470)
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
            Me.picCriteria_1.Location = New System.Drawing.Point(5, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(801, 51)
            Me.picCriteria_1.TabIndex = 1491
            Me.picCriteria_1.TabStop = False
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(12, 66)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(788, 121)
            Me.picIo_2.TabIndex = 1493
            Me.picIo_2.TabStop = False
            '
            'lblColProcessTypeCd
            '
            Me.lblColProcessTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColProcessTypeCd.Location = New System.Drawing.Point(529, 72)
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
            Me.txtRecipient.Location = New System.Drawing.Point(613, 69)
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
            Me.txtNote.Location = New System.Drawing.Point(152, 158)
            Me.txtNote.MaxLength = 40
            Me.txtNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNote.Multiline = False
            Me.txtNote.Name = "txtNote"
            Me.txtNote.ReadOnlys = True
            Me.txtNote.SelectedText = ""
            Me.txtNote.SelectionLength = 0
            Me.txtNote.SelectionStart = 0
            Me.txtNote.Size = New System.Drawing.Size(630, 20)
            Me.txtNote.TabIndex = 11
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
            Me.popProcEmpNum.Location = New System.Drawing.Point(152, 135)
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
            Me.popProcEmpNum.TabIndex = 9
            Me.popProcEmpNum.Tag = "need();code(사원 명);"
            Me.popProcEmpNum.TextAlign = 0
            Me.popProcEmpNum.TextValue = ""
            Me.popProcEmpNum.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(80, 138)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(67, 15)
            Me.Label21.TabIndex = 1690
            Me.Label21.Text = "입금 담당"
            Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'numColAmt
            '
            Me.numColAmt.BackColor = System.Drawing.SystemColors.Window
            Me.numColAmt.BorderColor = System.Drawing.Color.Empty
            Me.numColAmt.BorderStyle = 2
            Me.numColAmt.CaptionName = "입금 금액"
            Me.numColAmt.LengthPrecision = 15
            Me.numColAmt.LengthScale = 0
            Me.numColAmt.Location = New System.Drawing.Point(152, 112)
            Me.numColAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numColAmt.MaxLength = 32767
            Me.numColAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numColAmt.Name = "numColAmt"
            Me.numColAmt.ReadOnlys = False
            Me.numColAmt.SelectedText = ""
            Me.numColAmt.SelectionLength = 0
            Me.numColAmt.SelectionStart = 1
            Me.numColAmt.Size = New System.Drawing.Size(188, 20)
            Me.numColAmt.TabIndex = 7
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
            Me.numColOrders.Location = New System.Drawing.Point(252, 89)
            Me.numColOrders.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numColOrders.MaxLength = 32767
            Me.numColOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numColOrders.Name = "numColOrders"
            Me.numColOrders.ReadOnlys = False
            Me.numColOrders.SelectedText = ""
            Me.numColOrders.SelectionLength = 0
            Me.numColOrders.SelectionStart = 1
            Me.numColOrders.Size = New System.Drawing.Size(52, 20)
            Me.numColOrders.TabIndex = 3
            Me.numColOrders.Tag = "read;"
            Me.numColOrders.TextValue = "0"
            Me.numColOrders.ToolTipText = ""
            '
            'popCompanyCd
            '
            Me.popCompanyCd.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd.BorderStyle = 2
            Me.popCompanyCd.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd.CaptionName = "확장처 코드"
            Me.popCompanyCd.CodeText = ""
            Me.popCompanyCd.CodeWidth = 90
            Me.popCompanyCd.Location = New System.Drawing.Point(442, 112)
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
            Me.popCompanyCd.Size = New System.Drawing.Size(340, 20)
            Me.popCompanyCd.TabIndex = 8
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(358, 115)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(79, 15)
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
            Me.popEmployeeExpNum.Location = New System.Drawing.Point(442, 135)
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
            Me.popEmployeeExpNum.Size = New System.Drawing.Size(340, 20)
            Me.popEmployeeExpNum.TabIndex = 10
            Me.popEmployeeExpNum.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum.TextAlign = 0
            Me.popEmployeeExpNum.TextValue = ""
            Me.popEmployeeExpNum.ToolTipText = ""
            '
            'lblEmployeeExpNum
            '
            Me.lblEmployeeExpNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEmployeeExpNum.Location = New System.Drawing.Point(358, 136)
            Me.lblEmployeeExpNum.Name = "lblEmployeeExpNum"
            Me.lblEmployeeExpNum.Size = New System.Drawing.Size(79, 18)
            Me.lblEmployeeExpNum.TabIndex = 1696
            Me.lblEmployeeExpNum.Text = "확  장  명"
            Me.lblEmployeeExpNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboColBankCd
            '
            Me.cboColBankCd.BackColor = System.Drawing.Color.White
            Me.cboColBankCd.CaptionName = "은행코드"
            Me.cboColBankCd.ListCount = 0
            Me.cboColBankCd.Location = New System.Drawing.Point(323, 69)
            Me.cboColBankCd.Name = "cboColBankCd"
            Me.cboColBankCd.ReadOnlys = False
            Me.cboColBankCd.Size = New System.Drawing.Size(188, 20)
            Me.cboColBankCd.TabIndex = 5
            Me.cboColBankCd.Tag = "init(I101);code(입금계좌코드|선택하세요);"
            Me.cboColBankCd.TextValue = ""
            Me.cboColBankCd.Visible = False
            '
            'lblColBankCd
            '
            Me.lblColBankCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColBankCd.Location = New System.Drawing.Point(257, 72)
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
            Me.popCompanyCd_R.Location = New System.Drawing.Point(439, 21)
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
            Me.popCompanyCd_R.Size = New System.Drawing.Size(340, 20)
            Me.popCompanyCd_R.TabIndex = 1700
            Me.popCompanyCd_R.Tag = "code(확장처 명);"
            Me.popCompanyCd_R.TextAlign = 0
            Me.popCompanyCd_R.TextValue = ""
            Me.popCompanyCd_R.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(355, 24)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(79, 15)
            Me.Label2.TabIndex = 1701
            Me.Label2.Text = "확장처"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PictureBox1
            '
            Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
            Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PictureBox1.Location = New System.Drawing.Point(5, 60)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(801, 133)
            Me.PictureBox1.TabIndex = 1702
            Me.PictureBox1.TabStop = False
            '
            'lblRecordState
            '
            Me.lblRecordState.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblRecordState.Location = New System.Drawing.Point(711, 72)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 11)
            Me.lblRecordState.TabIndex = 1749
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNE991
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.lblRecordState)
            Me.Controls.Add(Me.popCompanyCd_R)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.cboColBankCd)
            Me.Controls.Add(Me.lblColBankCd)
            Me.Controls.Add(Me.popCompanyCd)
            Me.Controls.Add(Me.Label12)
            Me.Controls.Add(Me.popEmployeeExpNum)
            Me.Controls.Add(Me.lblEmployeeExpNum)
            Me.Controls.Add(Me.numColOrders)
            Me.Controls.Add(Me.numColAmt)
            Me.Controls.Add(Me.popProcEmpNum)
            Me.Controls.Add(Me.Label21)
            Me.Controls.Add(Me.txtNote)
            Me.Controls.Add(Me.txtRecipient)
            Me.Controls.Add(Me.lblColProcessTypeCd)
            Me.Controls.Add(Me.cboColTypeCd)
            Me.Controls.Add(Me.lblColTypeCd)
            Me.Controls.Add(Me.Label20)
            Me.Controls.Add(Me.dtpToColDt)
            Me.Controls.Add(Me.Label13)
            Me.Controls.Add(Me.lblNote)
            Me.Controls.Add(Me.dtpFromColDt)
            Me.Controls.Add(Me.lblColDt)
            Me.Controls.Add(Me.dtpColDt)
            Me.Controls.Add(Me.lbColDate)
            Me.Controls.Add(Me.lblColAmt)
            Me.Controls.Add(Me.grd_1)
            Me.Controls.Add(Me.picCriteria_1)
            Me.Controls.Add(Me.picIo_2)
            Me.Controls.Add(Me.PictureBox1)
            Me.Name = "PNE991"
            Me.Size = New System.Drawing.Size(811, 673)
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
        Friend WithEvents dtpColDt As ubiLease.CommonControls.dtp
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
        Friend WithEvents numColAmt As ubiLease.CommonControls.num
        Friend WithEvents numColOrders As ubiLease.CommonControls.num
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


    End Class

End Namespace
