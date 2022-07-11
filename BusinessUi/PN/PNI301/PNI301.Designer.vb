Namespace ubiLease.UI.BusinessUi.PN

    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PNI301
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PNI301))
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
            Me.lblRecordState = New System.Windows.Forms.Label
            Me.dtpCalYearMonths = New ubiLease.CommonControls.dtp
            Me.Label38 = New System.Windows.Forms.Label
            Me.dtpColYearMonths = New ubiLease.CommonControls.dtp
            Me.Label3 = New System.Windows.Forms.Label
            Me.dtpColYearMonths_R = New ubiLease.CommonControls.dtp
            Me.Label1 = New System.Windows.Forms.Label
            Me.dtpCalYearMonths_R = New ubiLease.CommonControls.dtp
            Me.Label4 = New System.Windows.Forms.Label
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'cboColTypeCd
            '
            Me.cboColTypeCd.BackColor = System.Drawing.Color.White
            Me.cboColTypeCd.CaptionName = "입금구분코드"
            Me.cboColTypeCd.ListCount = 0
            Me.cboColTypeCd.Location = New System.Drawing.Point(693, 117)
            Me.cboColTypeCd.Name = "cboColTypeCd"
            Me.cboColTypeCd.ReadOnlys = False
            Me.cboColTypeCd.Size = New System.Drawing.Size(85, 20)
            Me.cboColTypeCd.TabIndex = 6
            Me.cboColTypeCd.Tag = "read;init(D1);code(입금구분코드);"
            Me.cboColTypeCd.TextValue = ""
            Me.cboColTypeCd.Visible = False
            '
            'lblColTypeCd
            '
            Me.lblColTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColTypeCd.Location = New System.Drawing.Point(727, 97)
            Me.lblColTypeCd.Name = "lblColTypeCd"
            Me.lblColTypeCd.Size = New System.Drawing.Size(51, 15)
            Me.lblColTypeCd.TabIndex = 21
            Me.lblColTypeCd.Text = "입금 구분"
            Me.lblColTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.lblColTypeCd.Visible = False
            '
            'Label20
            '
            Me.Label20.AutoSize = True
            Me.Label20.BackColor = System.Drawing.Color.GhostWhite
            Me.Label20.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold)
            Me.Label20.Location = New System.Drawing.Point(16, 80)
            Me.Label20.Name = "Label20"
            Me.Label20.Size = New System.Drawing.Size(155, 12)
            Me.Label20.TabIndex = 17
            Me.Label20.Text = "< 본사수금구독료 입금 >"
            '
            'dtpToColDt
            '
            Me.dtpToColDt.BackColor = System.Drawing.SystemColors.Window
            Me.dtpToColDt.BorderColor = System.Drawing.Color.Empty
            Me.dtpToColDt.BorderStyle = 2
            Me.dtpToColDt.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpToColDt.CaptionName = "입금일자"
            Me.dtpToColDt.DateTimeFormatText = "yyyy-MM-dd"
            Me.dtpToColDt.Location = New System.Drawing.Point(418, 42)
            Me.dtpToColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpToColDt.MaxLength = 0
            Me.dtpToColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpToColDt.Name = "dtpToColDt"
            Me.dtpToColDt.ReadOnlys = False
            Me.dtpToColDt.SelectedText = ""
            Me.dtpToColDt.SelectionLength = 0
            Me.dtpToColDt.SelectionStart = 0
            Me.dtpToColDt.Size = New System.Drawing.Size(99, 20)
            Me.dtpToColDt.TabIndex = 4
            Me.dtpToColDt.TabStop = False
            Me.dtpToColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpToColDt.TextAlign = 0
            Me.dtpToColDt.TextValue = ""
            Me.dtpToColDt.ToolTipText = ""
            '
            'Label13
            '
            Me.Label13.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label13.Location = New System.Drawing.Point(403, 45)
            Me.Label13.Name = "Label13"
            Me.Label13.Size = New System.Drawing.Size(15, 15)
            Me.Label13.TabIndex = 15
            Me.Label13.Text = "~"
            Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'lblNote
            '
            Me.lblNote.BackColor = System.Drawing.Color.GhostWhite
            Me.lblNote.Location = New System.Drawing.Point(64, 191)
            Me.lblNote.Name = "lblNote"
            Me.lblNote.Size = New System.Drawing.Size(79, 15)
            Me.lblNote.TabIndex = 29
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
            Me.dtpFromColDt.Location = New System.Drawing.Point(304, 42)
            Me.dtpFromColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpFromColDt.MaxLength = 0
            Me.dtpFromColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpFromColDt.Name = "dtpFromColDt"
            Me.dtpFromColDt.ReadOnlys = False
            Me.dtpFromColDt.SelectedText = ""
            Me.dtpFromColDt.SelectionLength = 0
            Me.dtpFromColDt.SelectionStart = 0
            Me.dtpFromColDt.Size = New System.Drawing.Size(99, 20)
            Me.dtpFromColDt.TabIndex = 3
            Me.dtpFromColDt.TabStop = False
            Me.dtpFromColDt.Tag = "format(&&&&-&&-&&);"
            Me.dtpFromColDt.TextAlign = 0
            Me.dtpFromColDt.TextValue = ""
            Me.dtpFromColDt.ToolTipText = ""
            '
            'lblColDt
            '
            Me.lblColDt.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lblColDt.Location = New System.Drawing.Point(233, 45)
            Me.lblColDt.Name = "lblColDt"
            Me.lblColDt.Size = New System.Drawing.Size(65, 15)
            Me.lblColDt.TabIndex = 14
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
            Me.dtpColDt.Location = New System.Drawing.Point(148, 96)
            Me.dtpColDt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpColDt.MaxLength = 0
            Me.dtpColDt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpColDt.Name = "dtpColDt"
            Me.dtpColDt.ReadOnlys = True
            Me.dtpColDt.SelectedText = ""
            Me.dtpColDt.SelectionLength = 0
            Me.dtpColDt.SelectionStart = 0
            Me.dtpColDt.Size = New System.Drawing.Size(103, 20)
            Me.dtpColDt.TabIndex = 3
            Me.dtpColDt.TabStop = False
            Me.dtpColDt.Tag = "need();format(&&&&-&&-&&);"
            Me.dtpColDt.TextAlign = 0
            Me.dtpColDt.TextValue = ""
            Me.dtpColDt.ToolTipText = ""
            '
            'lbColDate
            '
            Me.lbColDate.BackColor = System.Drawing.Color.GhostWhite
            Me.lbColDate.Location = New System.Drawing.Point(76, 99)
            Me.lbColDate.Name = "lbColDate"
            Me.lbColDate.Size = New System.Drawing.Size(67, 15)
            Me.lbColDate.TabIndex = 18
            Me.lbColDate.Text = "입금 일자"
            Me.lbColDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblColAmt
            '
            Me.lblColAmt.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColAmt.Location = New System.Drawing.Point(76, 145)
            Me.lblColAmt.Name = "lblColAmt"
            Me.lblColAmt.Size = New System.Drawing.Size(67, 15)
            Me.lblColAmt.TabIndex = 25
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
            Me.grd_1.Location = New System.Drawing.Point(4, 218)
            Me.grd_1.Name = "grd_1"
            Me.grd_1.NodeClosedPicture = Nothing
            Me.grd_1.NodeOpenPicture = Nothing
            Me.grd_1.OutlineCol = -1
            Me.grd_1.RowHeightMax = 18
            Me.grd_1.RowHeightMin = 18
            Me.grd_1.Rows = 2
            Me.grd_1.Size = New System.Drawing.Size(804, 450)
            Me.grd_1.StyleInfo = resources.GetString("grd_1.StyleInfo")
            Me.grd_1.TabBehavior = C1.Win.C1FlexGrid.Classic.TabBehaviorSettings.flexTabCells
            Me.grd_1.TabIndex = 30
            Me.grd_1.TreeColor = System.Drawing.Color.DarkGray
            '
            'picCriteria_1
            '
            Me.picCriteria_1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picCriteria_1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.picCriteria_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picCriteria_1.Location = New System.Drawing.Point(4, 6)
            Me.picCriteria_1.Name = "picCriteria_1"
            Me.picCriteria_1.Size = New System.Drawing.Size(803, 66)
            Me.picCriteria_1.TabIndex = 1491
            Me.picCriteria_1.TabStop = False
            '
            'picIo_2
            '
            Me.picIo_2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.picIo_2.BackColor = System.Drawing.Color.GhostWhite
            Me.picIo_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.picIo_2.Location = New System.Drawing.Point(4, 75)
            Me.picIo_2.Name = "picIo_2"
            Me.picIo_2.Size = New System.Drawing.Size(803, 139)
            Me.picIo_2.TabIndex = 1493
            Me.picIo_2.TabStop = False
            '
            'lblColProcessTypeCd
            '
            Me.lblColProcessTypeCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColProcessTypeCd.Location = New System.Drawing.Point(354, 122)
            Me.lblColProcessTypeCd.Name = "lblColProcessTypeCd"
            Me.lblColProcessTypeCd.Size = New System.Drawing.Size(79, 14)
            Me.lblColProcessTypeCd.TabIndex = 24
            Me.lblColProcessTypeCd.Text = "입금자 명"
            Me.lblColProcessTypeCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'txtRecipient
            '
            Me.txtRecipient.BackColor = System.Drawing.Color.White
            Me.txtRecipient.BorderColor = System.Drawing.Color.Empty
            Me.txtRecipient.BorderStyle = 2
            Me.txtRecipient.CaptionName = "예금주 명"
            Me.txtRecipient.Location = New System.Drawing.Point(438, 119)
            Me.txtRecipient.MaxLength = 40
            Me.txtRecipient.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtRecipient.Multiline = False
            Me.txtRecipient.Name = "txtRecipient"
            Me.txtRecipient.ReadOnlys = True
            Me.txtRecipient.SelectedText = ""
            Me.txtRecipient.SelectionLength = 0
            Me.txtRecipient.SelectionStart = 0
            Me.txtRecipient.Size = New System.Drawing.Size(224, 20)
            Me.txtRecipient.TabIndex = 8
            Me.txtRecipient.Tag = "need();"
            Me.txtRecipient.TextAlign = 0
            Me.txtRecipient.TextValue = ""
            Me.txtRecipient.ToolTipText = ""
            '
            'txtNote
            '
            Me.txtNote.BackColor = System.Drawing.Color.White
            Me.txtNote.BorderColor = System.Drawing.Color.Empty
            Me.txtNote.BorderStyle = 2
            Me.txtNote.CaptionName = "적요"
            Me.txtNote.Location = New System.Drawing.Point(148, 188)
            Me.txtNote.MaxLength = 40
            Me.txtNote.MinimumSize = New System.Drawing.Size(20, 20)
            Me.txtNote.Multiline = False
            Me.txtNote.Name = "txtNote"
            Me.txtNote.ReadOnlys = True
            Me.txtNote.SelectedText = ""
            Me.txtNote.SelectionLength = 0
            Me.txtNote.SelectionStart = 0
            Me.txtNote.Size = New System.Drawing.Size(630, 20)
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
            Me.popProcEmpNum.Location = New System.Drawing.Point(148, 165)
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
            Me.popProcEmpNum.TabIndex = 11
            Me.popProcEmpNum.Tag = "need();code(사원 명);"
            Me.popProcEmpNum.TextAlign = 0
            Me.popProcEmpNum.TextValue = ""
            Me.popProcEmpNum.ToolTipText = ""
            '
            'Label21
            '
            Me.Label21.BackColor = System.Drawing.Color.GhostWhite
            Me.Label21.Location = New System.Drawing.Point(76, 168)
            Me.Label21.Name = "Label21"
            Me.Label21.Size = New System.Drawing.Size(67, 15)
            Me.Label21.TabIndex = 27
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
            Me.numColAmt.Location = New System.Drawing.Point(148, 142)
            Me.numColAmt.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numColAmt.MaxLength = 32767
            Me.numColAmt.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numColAmt.Name = "numColAmt"
            Me.numColAmt.ReadOnlys = False
            Me.numColAmt.SelectedText = ""
            Me.numColAmt.SelectionLength = 0
            Me.numColAmt.SelectionStart = 1
            Me.numColAmt.Size = New System.Drawing.Size(188, 20)
            Me.numColAmt.TabIndex = 9
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
            Me.numColOrders.Location = New System.Drawing.Point(248, 96)
            Me.numColOrders.MaximumSize = New System.Drawing.Size(500, 20)
            Me.numColOrders.MaxLength = 32767
            Me.numColOrders.MinimumSize = New System.Drawing.Size(20, 20)
            Me.numColOrders.Name = "numColOrders"
            Me.numColOrders.ReadOnlys = False
            Me.numColOrders.SelectedText = ""
            Me.numColOrders.SelectionLength = 0
            Me.numColOrders.SelectionStart = 1
            Me.numColOrders.Size = New System.Drawing.Size(52, 20)
            Me.numColOrders.TabIndex = 4
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
            Me.popCompanyCd.Location = New System.Drawing.Point(438, 142)
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
            Me.popCompanyCd.TabIndex = 10
            Me.popCompanyCd.Tag = "code(확장처 명);"
            Me.popCompanyCd.TextAlign = 0
            Me.popCompanyCd.TextValue = ""
            Me.popCompanyCd.ToolTipText = ""
            '
            'Label12
            '
            Me.Label12.BackColor = System.Drawing.Color.GhostWhite
            Me.Label12.Location = New System.Drawing.Point(354, 145)
            Me.Label12.Name = "Label12"
            Me.Label12.Size = New System.Drawing.Size(79, 15)
            Me.Label12.TabIndex = 26
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
            Me.popEmployeeExpNum.Location = New System.Drawing.Point(438, 165)
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
            Me.popEmployeeExpNum.TabIndex = 12
            Me.popEmployeeExpNum.Tag = "code(사원확장 명);rtnValue(popCompanyCd);"
            Me.popEmployeeExpNum.TextAlign = 0
            Me.popEmployeeExpNum.TextValue = ""
            Me.popEmployeeExpNum.ToolTipText = ""
            '
            'lblEmployeeExpNum
            '
            Me.lblEmployeeExpNum.BackColor = System.Drawing.Color.GhostWhite
            Me.lblEmployeeExpNum.Location = New System.Drawing.Point(354, 166)
            Me.lblEmployeeExpNum.Name = "lblEmployeeExpNum"
            Me.lblEmployeeExpNum.Size = New System.Drawing.Size(79, 18)
            Me.lblEmployeeExpNum.TabIndex = 28
            Me.lblEmployeeExpNum.Text = "확  장  명"
            Me.lblEmployeeExpNum.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'cboColBankCd
            '
            Me.cboColBankCd.BackColor = System.Drawing.Color.White
            Me.cboColBankCd.CaptionName = "은행코드"
            Me.cboColBankCd.ListCount = 0
            Me.cboColBankCd.Location = New System.Drawing.Point(148, 119)
            Me.cboColBankCd.Name = "cboColBankCd"
            Me.cboColBankCd.ReadOnlys = False
            Me.cboColBankCd.Size = New System.Drawing.Size(188, 20)
            Me.cboColBankCd.TabIndex = 7
            Me.cboColBankCd.Tag = "need();init(I101);code(입금계좌코드|선택하세요);"
            Me.cboColBankCd.TextValue = ""
            '
            'lblColBankCd
            '
            Me.lblColBankCd.BackColor = System.Drawing.Color.GhostWhite
            Me.lblColBankCd.Location = New System.Drawing.Point(82, 122)
            Me.lblColBankCd.Name = "lblColBankCd"
            Me.lblColBankCd.Size = New System.Drawing.Size(61, 15)
            Me.lblColBankCd.TabIndex = 23
            Me.lblColBankCd.Text = "입금 계좌"
            Me.lblColBankCd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'popCompanyCd_R
            '
            Me.popCompanyCd_R.BorderColor = System.Drawing.Color.Empty
            Me.popCompanyCd_R.BorderStyle = 2
            Me.popCompanyCd_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.popCompanyCd_R.CaptionName = "확장처 코드"
            Me.popCompanyCd_R.CodeText = ""
            Me.popCompanyCd_R.CodeWidth = 90
            Me.popCompanyCd_R.Location = New System.Drawing.Point(305, 19)
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
            Me.popCompanyCd_R.TabIndex = 1
            Me.popCompanyCd_R.Tag = "code(확장처 명);"
            Me.popCompanyCd_R.TextAlign = 0
            Me.popCompanyCd_R.TextValue = ""
            Me.popCompanyCd_R.ToolTipText = ""
            '
            'Label2
            '
            Me.Label2.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label2.Location = New System.Drawing.Point(221, 22)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(79, 15)
            Me.Label2.TabIndex = 16
            Me.Label2.Text = "확장처"
            Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'lblRecordState
            '
            Me.lblRecordState.BackColor = System.Drawing.Color.GhostWhite
            Me.lblRecordState.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
            Me.lblRecordState.ForeColor = System.Drawing.SystemColors.ActiveCaption
            Me.lblRecordState.Location = New System.Drawing.Point(707, 80)
            Me.lblRecordState.Name = "lblRecordState"
            Me.lblRecordState.Size = New System.Drawing.Size(71, 16)
            Me.lblRecordState.TabIndex = 22
            Me.lblRecordState.Text = "신규"
            Me.lblRecordState.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths
            '
            Me.dtpCalYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths.BorderStyle = 2
            Me.dtpCalYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths.CaptionName = "청구 월"
            Me.dtpCalYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths.Location = New System.Drawing.Point(438, 96)
            Me.dtpCalYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths.MaxLength = 0
            Me.dtpCalYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths.Name = "dtpCalYearMonths"
            Me.dtpCalYearMonths.ReadOnlys = False
            Me.dtpCalYearMonths.SelectedText = ""
            Me.dtpCalYearMonths.SelectionLength = 0
            Me.dtpCalYearMonths.SelectionStart = 0
            Me.dtpCalYearMonths.Size = New System.Drawing.Size(80, 20)
            Me.dtpCalYearMonths.TabIndex = 5
            Me.dtpCalYearMonths.Tag = "need();format(####-##);"
            Me.dtpCalYearMonths.TextAlign = 0
            Me.dtpCalYearMonths.TextValue = ""
            Me.dtpCalYearMonths.ToolTipText = ""
            '
            'Label38
            '
            Me.Label38.BackColor = System.Drawing.Color.GhostWhite
            Me.Label38.Location = New System.Drawing.Point(371, 97)
            Me.Label38.Name = "Label38"
            Me.Label38.Size = New System.Drawing.Size(62, 18)
            Me.Label38.TabIndex = 19
            Me.Label38.Text = "청구 월"
            Me.Label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpColYearMonths
            '
            Me.dtpColYearMonths.BackColor = System.Drawing.SystemColors.Window
            Me.dtpColYearMonths.BorderColor = System.Drawing.Color.Empty
            Me.dtpColYearMonths.BorderStyle = 2
            Me.dtpColYearMonths.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpColYearMonths.CaptionName = "수금 월"
            Me.dtpColYearMonths.DateTimeFormatText = "yyyy-MM"
            Me.dtpColYearMonths.Location = New System.Drawing.Point(582, 96)
            Me.dtpColYearMonths.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpColYearMonths.MaxLength = 0
            Me.dtpColYearMonths.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpColYearMonths.Name = "dtpColYearMonths"
            Me.dtpColYearMonths.ReadOnlys = False
            Me.dtpColYearMonths.SelectedText = ""
            Me.dtpColYearMonths.SelectionLength = 0
            Me.dtpColYearMonths.SelectionStart = 0
            Me.dtpColYearMonths.Size = New System.Drawing.Size(80, 20)
            Me.dtpColYearMonths.TabIndex = 1494
            Me.dtpColYearMonths.Tag = "need();format(####-##);"
            Me.dtpColYearMonths.TextAlign = 0
            Me.dtpColYearMonths.TextValue = ""
            Me.dtpColYearMonths.ToolTipText = ""
            '
            'Label3
            '
            Me.Label3.BackColor = System.Drawing.Color.GhostWhite
            Me.Label3.Location = New System.Drawing.Point(527, 97)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(50, 18)
            Me.Label3.TabIndex = 1495
            Me.Label3.Text = "수금 월"
            Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpColYearMonths_R
            '
            Me.dtpColYearMonths_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpColYearMonths_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpColYearMonths_R.BorderStyle = 2
            Me.dtpColYearMonths_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpColYearMonths_R.CaptionName = "수금 년 월"
            Me.dtpColYearMonths_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpColYearMonths_R.Location = New System.Drawing.Point(111, 42)
            Me.dtpColYearMonths_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpColYearMonths_R.MaxLength = 0
            Me.dtpColYearMonths_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpColYearMonths_R.Name = "dtpColYearMonths_R"
            Me.dtpColYearMonths_R.ReadOnlys = False
            Me.dtpColYearMonths_R.SelectedText = ""
            Me.dtpColYearMonths_R.SelectionLength = 0
            Me.dtpColYearMonths_R.SelectionStart = 0
            Me.dtpColYearMonths_R.Size = New System.Drawing.Size(80, 20)
            Me.dtpColYearMonths_R.TabIndex = 2
            Me.dtpColYearMonths_R.Tag = "format(####-##);"
            Me.dtpColYearMonths_R.TextAlign = 0
            Me.dtpColYearMonths_R.TextValue = ""
            Me.dtpColYearMonths_R.ToolTipText = ""
            '
            'Label1
            '
            Me.Label1.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label1.Location = New System.Drawing.Point(44, 43)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(62, 18)
            Me.Label1.TabIndex = 1499
            Me.Label1.Text = "수금 월"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'dtpCalYearMonths_R
            '
            Me.dtpCalYearMonths_R.BackColor = System.Drawing.SystemColors.Window
            Me.dtpCalYearMonths_R.BorderColor = System.Drawing.Color.Empty
            Me.dtpCalYearMonths_R.BorderStyle = 2
            Me.dtpCalYearMonths_R.ButtonBackColor = System.Drawing.Color.WhiteSmoke
            Me.dtpCalYearMonths_R.CaptionName = "청구 년 월"
            Me.dtpCalYearMonths_R.DateTimeFormatText = "yyyy-MM"
            Me.dtpCalYearMonths_R.Location = New System.Drawing.Point(111, 19)
            Me.dtpCalYearMonths_R.MaximumSize = New System.Drawing.Size(500, 20)
            Me.dtpCalYearMonths_R.MaxLength = 0
            Me.dtpCalYearMonths_R.MinimumSize = New System.Drawing.Size(20, 20)
            Me.dtpCalYearMonths_R.Name = "dtpCalYearMonths_R"
            Me.dtpCalYearMonths_R.ReadOnlys = False
            Me.dtpCalYearMonths_R.SelectedText = ""
            Me.dtpCalYearMonths_R.SelectionLength = 0
            Me.dtpCalYearMonths_R.SelectionStart = 0
            Me.dtpCalYearMonths_R.Size = New System.Drawing.Size(80, 20)
            Me.dtpCalYearMonths_R.TabIndex = 0
            Me.dtpCalYearMonths_R.Tag = "format(####-##);"
            Me.dtpCalYearMonths_R.TextAlign = 0
            Me.dtpCalYearMonths_R.TextValue = ""
            Me.dtpCalYearMonths_R.ToolTipText = ""
            '
            'Label4
            '
            Me.Label4.BackColor = System.Drawing.Color.WhiteSmoke
            Me.Label4.Location = New System.Drawing.Point(44, 20)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(62, 18)
            Me.Label4.TabIndex = 1497
            Me.Label4.Text = "청구 월"
            Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'PNI301
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
            Me.Controls.Add(Me.dtpColYearMonths_R)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.dtpCalYearMonths_R)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.dtpColYearMonths)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.dtpCalYearMonths)
            Me.Controls.Add(Me.Label38)
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
            Me.Name = "PNI301"
            Me.Size = New System.Drawing.Size(811, 673)
            CType(Me.grd_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picCriteria_1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picIo_2, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents lblRecordState As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label38 As System.Windows.Forms.Label
        Friend WithEvents dtpColYearMonths As ubiLease.CommonControls.dtp
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents dtpColYearMonths_R As ubiLease.CommonControls.dtp
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents dtpCalYearMonths_R As ubiLease.CommonControls.dtp
        Friend WithEvents Label4 As System.Windows.Forms.Label


    End Class

End Namespace
